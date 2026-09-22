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
    /// Bootstraps dependency loading for the module.
    /// <list type="bullet">
    /// <item>
    /// On PowerShell 7+ (.NET) the <c>Microsoft.Graph.Authentication.Loader</c> assembly is loaded from <c>Dependencies/Core</c>
    /// and asked to create a private <c>AssemblyLoadContext</c>. Only <c>Microsoft.Graph.Authentication.Core</c> is bridged into
    /// the default context; Azure.Identity, MSAL, Kiota, Microsoft.Graph.Core, etc. stay invisible to other modules.
    /// </item>
    /// <item>
    /// On Windows PowerShell 5.1 (.NET Framework) there is no <c>AssemblyLoadContext</c>, so the historical
    /// <see cref="AppDomain.AssemblyResolve"/> + <see cref="Assembly.LoadFrom(string)"/> approach is kept.
    /// </item>
    /// </list>
    /// IMPORTANT: this type must not reference any type from <c>Microsoft.Graph.Authentication.Core</c> (directly or via
    /// field/parameter/local types) because its static constructor runs before the load-context redirect is in place.
    /// </summary>
    public class ModuleInitializer : IModuleAssemblyInitializer, IModuleAssemblyCleanup
    {
        private const string LoaderAssemblyFileName = "Microsoft.Graph.Authentication.Loader.dll";
        private const string LoaderInitializerTypeName = "Microsoft.Graph.PowerShell.Authentication.Loader.GraphLoadContextInitializer";

        private static readonly string s_dependencyFolder;
        private static readonly string s_psEditionDependencyFolder;
        private static readonly HashSet<string> s_dependencies;
        private static readonly HashSet<string> s_psEditionDependencies;
        private static readonly bool s_isPsCore;
        private static readonly Type s_loaderInitializer;

        static ModuleInitializer()
        {
            s_isPsCore = RuntimeUtils.IsPsCore();
            s_dependencyFolder = Path.Combine(Path.GetDirectoryName(typeof(ModuleInitializer).Assembly.Location), "Dependencies");
            s_psEditionDependencyFolder = Path.Combine(s_dependencyFolder, s_isPsCore ? "Core" : "Desktop");
            s_dependencies = new HashSet<string>(StringComparer.Ordinal);
            s_psEditionDependencies = new HashSet<string>(StringComparer.Ordinal);

            if (s_isPsCore)
            {
                // Register the isolated load context as early as possible: before any method that references
                // Microsoft.Graph.Authentication.Core is JIT-compiled.
                s_loaderInitializer = InitializeIsolatedLoadContext();
                return;
            }

            // .NET Framework: index the dependency folders for the AssemblyResolve handler.
            IndexDependencyFolder(s_dependencyFolder, s_dependencies);
            IndexDependencyFolder(s_psEditionDependencyFolder, s_psEditionDependencies);
        }

        /// <inheritDoc/>
        public void OnImport()
        {
            if (s_isPsCore)
                return;

            AppDomain.CurrentDomain.AssemblyResolve += ResolvingHandler;
        }

        /// <inheritDoc/>
        public void OnRemove(PSModuleInfo psModuleInfo)
        {
            if (s_isPsCore)
            {
                s_loaderInitializer?.GetMethod("Shutdown", BindingFlags.Public | BindingFlags.Static)?.Invoke(null, null);
                return;
            }

            AppDomain.CurrentDomain.AssemblyResolve -= ResolvingHandler;
        }

        /// <summary>
        /// Loads the Loader assembly into the default context and calls <c>GraphLoadContextInitializer.Initialize</c>.
        /// </summary>
        /// <returns>The initializer type, or null when the loader could not be found.</returns>
        private static Type InitializeIsolatedLoadContext()
        {
            string loaderPath = Path.Combine(s_psEditionDependencyFolder, LoaderAssemblyFileName);
            if (!File.Exists(loaderPath))
            {
                throw new FileNotFoundException(
                    $"The Microsoft.Graph.Authentication module is incomplete: '{loaderPath}' was not found.", loaderPath);
            }

            Assembly loader = Assembly.LoadFrom(loaderPath);
            Type initializer = loader.GetType(LoaderInitializerTypeName, throwOnError: true);
            MethodInfo initialize = initializer.GetMethod("Initialize", BindingFlags.Public | BindingFlags.Static, null, new[] { typeof(string), typeof(string) }, null);
            initialize.Invoke(null, new object[] { s_dependencyFolder, s_psEditionDependencyFolder });
            return initializer;
        }

        private static void IndexDependencyFolder(string folder, HashSet<string> target)
        {
            if (!Directory.Exists(folder))
                return;

            foreach (string filePath in Directory.EnumerateFiles(folder, "*.dll"))
            {
                try
                {
                    target.Add(AssemblyName.GetAssemblyName(filePath).FullName);
                }
                catch (BadImageFormatException)
                {
                    // Skip files without metadata.
                    continue;
                }
            }
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
        /// Resolves the assembly reference from the dependencies folder (.NET Framework only).
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
                    // In .NET Framework, assembly conflict is not a problem, so we load the assembly
                    // by 'Assembly.LoadFrom', the same as what powershell.exe would do.
                    return Assembly.LoadFrom(filePath);
                }
            }
            return null;
        }
    }
}
