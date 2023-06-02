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

            foreach (string filePath in Directory.EnumerateFiles(s_dependencyFolder, "*.dll"))
            {
                s_dependencies.Add(AssemblyName.GetAssemblyName(filePath).FullName);
            }

            foreach (string filePath in Directory.EnumerateFiles(s_psEditionDependencyFolder, "*.dll"))
            {
                s_psEditionDependencies.Add(AssemblyName.GetAssemblyName(filePath).FullName);
            }
        }
        public void OnImport()
        {
            AppDomain.CurrentDomain.AssemblyResolve += ResolvingHandler;
        }

        public void OnRemove(PSModuleInfo psModuleInfo)
        {
            AppDomain.CurrentDomain.AssemblyResolve -= ResolvingHandler;
        }

        private static bool IsAssemblyMatching(AssemblyName assemblyName, Assembly requestingAssembly)
        {
            // The requesting assembly is always available in .NET, but could be null in .NET Framework.
            // - When the requesting assembly is available, we check whether the loading request came from this
            //   module (the 'Microsoft.Graph*' assembly in this case), so as to make sure we only act on the request
            //   from this module.
            // - When the requesting assembly is not available, we just have to depend on the assembly name only.
            return requestingAssembly != null
                ? requestingAssembly.FullName.StartsWith("Microsoft") && IsAssemblyPresent(assemblyName)
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
            if (s_dependencies.Contains(assemblyName.FullName) || s_psEditionDependencies.Contains(assemblyName.FullName))
                return true;
            else
                return !string.IsNullOrEmpty(s_dependencies.SingleOrDefault((x) => x.StartsWith(assemblyName.Name))) || !string.IsNullOrEmpty(s_psEditionDependencies.SingleOrDefault((x) => x.StartsWith(assemblyName.Name)));
        }

        private static string GetRequiredAssemblyPath(AssemblyName assemblyName)
        {
            string fileName = assemblyName.Name + ".dll";
            string filePath = Path.Combine(s_psEditionDependencyFolder, fileName);

            if (File.Exists(filePath))
                return filePath;

            filePath = Path.Combine(s_dependencyFolder, fileName);
            return File.Exists(filePath) ? filePath : null;
        }


        internal static Assembly ResolvingHandler(object sender, ResolveEventArgs args)
        {
            var assemblyName = new AssemblyName(args.Name);
            if (IsAssemblyMatching(assemblyName, args.RequestingAssembly))
            {
                string filePath = GetRequiredAssemblyPath(assemblyName);
                if (!string.IsNullOrEmpty(filePath))
                {
                    Console.WriteLine($"<*** Fall in 'ResolvingHandler': {assemblyName.FullName} requested by {args.RequestingAssembly?.FullName} from {filePath} -- Loaded! ***>");
                    // - In .NET, load the assembly into the custom assembly load context.
                    // - In .NET Framework, assembly conflict is not a problem, so we load the assembly
                    //   by 'Assembly.LoadFrom', the same as what powershell.exe would do.
                    return s_proxy != null
                        ? s_proxy.LoadFromAssemblyPath(filePath)
                        : Assembly.LoadFrom(filePath);
                }
            }
            else
            {
                Console.WriteLine($"<*** Failed to match in 'ResolvingHandler': {assemblyName.FullName} requested by {args.RequestingAssembly?.FullName} ***>");
            }
            return null;
        }
    }

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
