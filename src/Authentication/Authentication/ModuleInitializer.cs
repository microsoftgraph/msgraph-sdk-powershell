// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using Microsoft.Graph.PowerShell.Authentication.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Reflection;

namespace Microsoft.Graph.PowerShell.Authentication
{
    /// <summary>
    /// This class is used to load the dependencies of the module into an isolated assembly load context.
    /// </summary>
    public class ModuleInitializer : IModuleAssemblyInitializer, IModuleAssemblyCleanup
    {
        private static readonly string s_dependencyFolder;
        private static readonly string s_psEditionDependencyFolder;
        private static readonly HashSet<string> s_dependencies;
        private static readonly HashSet<string> s_psEditionDependencies;
        private static readonly AssemblyLoadContextProxy s_proxy;

        static ModuleInitializer()
        {
            s_dependencyFolder = Path.Combine(Path.GetDirectoryName(typeof(ModuleInitializer).Assembly.Location), "Dependencies");
            s_psEditionDependencyFolder = Path.Combine(s_dependencyFolder, RuntimeUtils.IsPsCore() ? "Core" : "Desktop");
            s_dependencies = new HashSet<string>(StringComparer.Ordinal);
            s_psEditionDependencies = new HashSet<string>(StringComparer.Ordinal);
            s_proxy = AssemblyLoadContextProxy.CreateLoadContext("msgraph-load-context");

            // Add shared dependencies.
            foreach (string filePath in Directory.EnumerateFiles(s_dependencyFolder, "*.dll"))
            {
                try
                {
                    s_dependencies.Add(AssemblyName.GetAssemblyName(filePath).FullName);
                }
                catch (BadImageFormatException)
                {
                    // Skip files without metadata.
                    continue;
                }
            }

            // Add the dependencies for the current PowerShell edition. Can be either Desktop (PS 5.1) or Core (PS 7+).
            foreach (string filePath in Directory.EnumerateFiles(s_psEditionDependencyFolder, "*.dll"))
            {
                try
                {
                    s_psEditionDependencies.Add(AssemblyName.GetAssemblyName(filePath).FullName);
                }
                catch (BadImageFormatException)
                {
                    // Skip files without metadata.
                    continue;
                }
            }
        }

        /// <inheritDoc/>
        public void OnImport()
        {
            if (s_proxy != null)
            {
                s_proxy.AddResolvingHandler(LoadContextResolvingHandler);

                // The module entry assemblies are loaded into the default context by PowerShell.
                // Bridge only their initial dependency requests into the isolated context.
                AppDomain.CurrentDomain.AssemblyResolve += GraphAssemblyResolvingHandler;
            }
            else
            {
                AppDomain.CurrentDomain.AssemblyResolve += ResolvingHandler;
            }
        }

        /// <inheritDoc/>
        public void OnRemove(PSModuleInfo psModuleInfo)
        {
            if (s_proxy != null)
            {
                AppDomain.CurrentDomain.AssemblyResolve -= GraphAssemblyResolvingHandler;
                s_proxy.RemoveResolvingHandler();
            }
            else
            {
                AppDomain.CurrentDomain.AssemblyResolve -= ResolvingHandler;
            }
        }

        /// <summary>
        /// Preserves the legacy .NET Framework matching behavior where custom load contexts are unavailable.
        /// </summary>
        /// <param name="assemblyName"><see cref="AssemblyName"/> being requested.</param>
        /// <param name="requestingAssembly">The requesting <see cref="Assembly"/>.</param>
        /// <returns>True if the dependency should be resolved; otherwise False.</returns>
        private static bool IsLegacyAssemblyMatching(AssemblyName assemblyName, Assembly requestingAssembly)
        {
            return requestingAssembly != null
                ? (requestingAssembly.FullName.StartsWith("Microsoft")
                    || requestingAssembly.FullName.StartsWith("Azure.Identity")
                    || requestingAssembly.FullName.StartsWith("Azure.Core")
                    || requestingAssembly.FullName.StartsWith("System.Text.Json")) && IsAssemblyPresent(assemblyName)
                : IsAssemblyPresent(assemblyName);
        }

        /// <summary>
        /// Checks to see if the assembly is present in the shared or PSEdition dependencies folder.
        /// Check is done by first matching the assembly by its full name; otherwise, we match using the assembly name.
        /// </summary>
        /// <param name="assemblyName"><see cref="AssemblyName"/> to match.</param>
        /// <returns>True if assembly is present in dependencies folder; otherwise False.</returns>
        private static bool IsAssemblyPresent(AssemblyName assemblyName)
        {
            return s_dependencies.Contains(assemblyName.FullName) || s_psEditionDependencies.Contains(assemblyName.FullName)
                ? true
                : !string.IsNullOrEmpty(s_dependencies.SingleOrDefault((x) => x.StartsWith($"{assemblyName.Name},"))) || !string.IsNullOrEmpty(s_psEditionDependencies.SingleOrDefault((x) => x.StartsWith($"{assemblyName.Name},")));
        }

        /// <summary>
        /// Gets the full path of the assembly from the dependencies folder.
        /// </summary>
        /// <param name="assemblyName"><see cref="AssemblyName"/> to find.</param>
        /// <returns>A <see cref="string"/> representing the full path of the assembly from the dependencies folder; otherwise <see cref="null"/>.</returns>
        private static string GetRequiredAssemblyPath(AssemblyName assemblyName)
        {
            string fileName = assemblyName.Name + ".dll";
            string filePath = Path.Combine(s_psEditionDependencyFolder, fileName);

            if (File.Exists(filePath))
                return filePath;

            filePath = Path.Combine(s_dependencyFolder, fileName);
            return File.Exists(filePath) ? filePath : null;
        }


        /// <summary>
        /// Resolves the assembly reference from the dependencies folder.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="args">The event data.</param>
        internal static Assembly ResolvingHandler(object sender, ResolveEventArgs args)
        {
            var assemblyName = new AssemblyName(args.Name);
            return IsLegacyAssemblyMatching(assemblyName, args.RequestingAssembly)
                ? LoadDependency(assemblyName, useLoadContext: false)
                : null;
        }

        /// <summary>
        /// Bridges dependency requests from Graph assemblies loaded by PowerShell into the custom load context.
        /// </summary>
        internal static Assembly GraphAssemblyResolvingHandler(object sender, ResolveEventArgs args)
        {
            var assemblyName = new AssemblyName(args.Name);
            return AssemblyResolutionHelpers.IsGraphAssembly(args.RequestingAssembly) && IsAssemblyPresent(assemblyName)
                ? LoadDependency(assemblyName, useLoadContext: true)
                : null;
        }

        /// <summary>
        /// Resolves transitive dependencies requested from within the custom load context.
        /// </summary>
        internal static Assembly LoadContextResolvingHandler(object sender, AssemblyName assemblyName)
        {
            return IsAssemblyPresent(assemblyName)
                ? LoadDependency(assemblyName, useLoadContext: true)
                : null;
        }

        private static Assembly LoadDependency(AssemblyName assemblyName, bool useLoadContext)
        {
            string filePath = GetRequiredAssemblyPath(assemblyName);
            if (!string.IsNullOrEmpty(filePath))
            {
                return useLoadContext
                    ? s_proxy.LoadFromAssemblyPath(filePath)
                    : Assembly.LoadFrom(filePath);
            }
            return null;
        }
    }

    /// <summary>
    /// An encapsulation of reflection API calls to create a custom AssemblyLoadContext. <see cref="AssemblyLoadContext"/> type is not available when targeting netstandard2.0 .NET Framework.
    /// </summary>
    internal class AssemblyLoadContextProxy
    {
        private readonly object _customContext;
        private readonly MethodInfo _loadFromAssemblyPath;
        private readonly MethodInfo _loadFromAssemblyName;
        private readonly EventInfo _resolving;
        private Delegate _resolvingHandler;

        private AssemblyLoadContextProxy(Type alc, string loadContextName)
        {
            var ctor = alc.GetConstructor(new[] { typeof(string), typeof(bool) });
            _loadFromAssemblyPath = alc.GetMethod("LoadFromAssemblyPath", new[] { typeof(string) });
            _loadFromAssemblyName = alc.GetMethod("LoadFromAssemblyName", new[] { typeof(AssemblyName) });
            _resolving = alc.GetEvent("Resolving");
            _customContext = ctor.Invoke(new object[] { loadContextName, false });
        }

        internal void AddResolvingHandler(Func<object, AssemblyName, Assembly> handler)
        {
            if (_resolvingHandler != null)
                return;

            _resolvingHandler = handler.Target == null
                ? Delegate.CreateDelegate(_resolving.EventHandlerType, handler.Method)
                : Delegate.CreateDelegate(_resolving.EventHandlerType, handler.Target, handler.Method);
            _resolving.AddEventHandler(_customContext, _resolvingHandler);
        }

        internal void RemoveResolvingHandler()
        {
            if (_resolvingHandler == null)
                return;

            _resolving.RemoveEventHandler(_customContext, _resolvingHandler);
            _resolvingHandler = null;
        }

        internal Assembly LoadFromAssemblyPath(string assemblyPath)
        {
            return (Assembly)_loadFromAssemblyPath.Invoke(_customContext, new[] { assemblyPath });
        }

        internal Assembly LoadFromAssemblyName(AssemblyName assemblyName)
        {
            return (Assembly)_loadFromAssemblyName.Invoke(_customContext, new object[] { assemblyName });
        }

        internal static AssemblyLoadContextProxy CreateLoadContext(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            var alc = typeof(object).Assembly.GetType("System.Runtime.Loader.AssemblyLoadContext");
            return alc != null
                ? new AssemblyLoadContextProxy(alc, name)
                : null;
        }
    }

    internal static class AssemblyResolutionHelpers
    {
        internal static bool IsGraphAssembly(Assembly requestingAssembly)
        {
            string assemblyName = requestingAssembly?.GetName().Name;
            return assemblyName != null
                && (assemblyName.Equals("Microsoft.Graph", StringComparison.Ordinal)
                    || assemblyName.StartsWith("Microsoft.Graph.", StringComparison.Ordinal));
        }
    }
}
