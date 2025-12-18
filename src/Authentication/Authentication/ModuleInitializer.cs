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
    /// This class is used to load the dependencies of the module into the current AppDomain.
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
            AppDomain.CurrentDomain.AssemblyResolve += ResolvingHandler;
        }

        /// <inheritDoc/>
        public void OnRemove(PSModuleInfo psModuleInfo)
        {
            AppDomain.CurrentDomain.AssemblyResolve -= ResolvingHandler;
        }

        /// <summary>
        /// Checks to see if the requested assembly matches the assemblies in our dependencies folder.
        /// The requesting assembly is always available in .NET, but could be null in .NET Framework.
        /// - When the requesting assembly is available, we check whether the loading request came from this
        ///   module (the 'Microsoft.*', Azure.Identity, or Azure.Core assemblies in this case), so as to make sure we only act on the request
        ///   from this module.
        /// - When the requesting assembly is not available, we just have to depend on the assembly name only.
        /// </summary>
        /// <param name="assemblyName"><see cref="AssemblyName"/> being requested.</param>
        /// <param name="requestingAssembly">The requesting <see cref="Assembly"/>.</param>
        /// <returns>True if assembly is present and matches in dependencies folder; otherwise False.</returns>
        private static bool IsAssemblyMatching(AssemblyName assemblyName, Assembly requestingAssembly)
        {
            return requestingAssembly != null
                ? (requestingAssembly.FullName.StartsWith("Microsoft") 
                    || requestingAssembly.FullName.StartsWith("Azure.Identity")
                    || requestingAssembly.FullName.StartsWith("Azure.Core")) && IsAssemblyPresent(assemblyName)
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
            if (IsAssemblyMatching(assemblyName, args.RequestingAssembly))
            {
                string filePath = GetRequiredAssemblyPath(assemblyName);
                if (!string.IsNullOrEmpty(filePath))
                {
                    // - In .NET, load the assembly into the custom assembly load context.
                    // - In .NET Framework, assembly conflict is not a problem, so we load the assembly
                    //   by 'Assembly.LoadFrom', the same as what powershell.exe would do.
                    return s_proxy != null
                        ? s_proxy.LoadFromAssemblyPath(filePath)
                        : Assembly.LoadFrom(filePath);
                }
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

        private AssemblyLoadContextProxy(Type alc, string loadContextName)
        {
            var ctor = alc.GetConstructor(new[] { typeof(string), typeof(bool) });
            _loadFromAssemblyPath = alc.GetMethod("LoadFromAssemblyPath", new[] { typeof(string) });
            _customContext = ctor.Invoke(new object[] { loadContextName, false });
        }

        internal Assembly LoadFromAssemblyPath(string assemblyPath)
        {
            return (Assembly)_loadFromAssemblyPath.Invoke(_customContext, new[] { assemblyPath });
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
}
