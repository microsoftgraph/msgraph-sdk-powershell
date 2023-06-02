//// ------------------------------------------------------------------------------
////  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
//// ------------------------------------------------------------------------------

//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Reflection;

//namespace Microsoft.Graph.PowerShell.Authentication.Utilities
//{
//    public static class DependencyAssemblyResolver
//    {
//        private static readonly Assembly Self = typeof(DependencyAssemblyResolver).Assembly;
//        private static readonly AssemblyLoadContextProxy Proxy = AssemblyLoadContextProxy.CreateLoadContext("msgraph-load-context");

//        // Catalog our dependencies here to ensure we don't load anything else.
//        private static readonly HashSet<string> Dependencies = new HashSet<string>(StringComparer.Ordinal);

//        // Dependencies that need to be loaded per framework.
//        private static readonly HashSet<string> MultiFrameworkDependencies = new HashSet<string>(StringComparer.Ordinal);

//        // Set up the path to our dependency directory within the module.
//        private static readonly string DependencyFolder = Path.GetFullPath(Path.Combine(Path.GetDirectoryName(Self.Location), "Dependencies"));

//        /// <summary>
//        /// Framework dependency path. /Desktop for PS 5.1, and /Core for PS 6+.
//        /// </summary>
//        private static string PSEdition;

//        /// <summary>
//        /// Initializes our custom assembly resolve event handler. This should be called on module import.
//        /// </summary>
//        /// <param name="isDesktopEdition"></param>
//        public static void Initialize(bool isDesktopEdition = false)
//        {
//            PSEdition = isDesktopEdition ? "Desktop" : "Core";

//            foreach (string filePath in Directory.EnumerateFiles(DependencyFolder, "*.dll", SearchOption.TopDirectoryOnly))
//            {
//                Dependencies.Add(AssemblyName.GetAssemblyName(filePath).Name);
//            }

//            foreach (string filePath in Directory.EnumerateFiles(Path.Combine(DependencyFolder, PSEdition), "*.dll", SearchOption.TopDirectoryOnly))
//            {
//                MultiFrameworkDependencies.Add(AssemblyName.GetAssemblyName(filePath).Name);
//            }

//            // Set up our event handler when the module is loaded.
//            AppDomain.CurrentDomain.AssemblyResolve += ResolvingHandler;
//        }

//        /// <summary>
//        /// Remove our custom assembly resolve event handler from the current app domain.
//        /// This should be called when our module is removed.
//        /// </summary>
//        internal static void Reset()
//        {
//            // Remove our event hander when the module is unloaded.
//            AppDomain.CurrentDomain.AssemblyResolve -= ResolvingHandler;
//        }

//        private static bool IsRequiredAssembly(AssemblyName assemblyName)
//        {
//            return Dependencies.Contains(assemblyName.Name) || MultiFrameworkDependencies.Contains(assemblyName.Name);
//        }

//        private static Assembly ResolvingHandler(object sender, ResolveEventArgs args)
//        {
//            try
//            {
//                AssemblyName assemblyName = new AssemblyName(args.Name);
//                // We try to resolve our dependencies on our own.
//                if (IsRequiredAssembly(assemblyName))
//                {
//                    string requiredAssemblyPath = MultiFrameworkDependencies.Contains(assemblyName.Name)
//                        ? requiredAssemblyPath = Path.Combine(DependencyFolder, PSEdition, $"{assemblyName.Name}.dll")
//                        : requiredAssemblyPath = Path.Combine(DependencyFolder, $"{assemblyName.Name}.dll");
//                    if (File.Exists(requiredAssemblyPath))
//                    {
//                        // - In .NET, load the assembly into the custom assembly load context.
//                        // - In .NET Framework, assembly conflict is not a problem, so we load the assembly
//                        //   by 'Assembly.LoadFrom', the same as what powershell.exe would do.
//                        return Proxy != null
//                            ? Proxy.LoadFromAssemblyPath(requiredAssemblyPath)
//                            : Assembly.LoadFrom(requiredAssemblyPath);
//                    }
//                }
//            }
//            catch
//            {
//                // If an error is encountered, we fall back to PowerShell's default dependency resolution.
//            }
//            return null;
//        }
//    }

//    internal class AssemblyLoadContextProxy
//    {
//        private readonly object CustomContext;
//        private readonly MethodInfo loadFromAssemblyPathMethod;

//        private AssemblyLoadContextProxy(Type alc, string loadContextName)
//        {
//            var ctor = alc.GetConstructor(new[] { typeof(string), typeof(bool) });
//            loadFromAssemblyPathMethod = alc.GetMethod("LoadFromAssemblyPath", new[] { typeof(string) });
//            CustomContext = ctor.Invoke(new object[] { loadContextName, false });
//        }

//        internal Assembly LoadFromAssemblyPath(string assemblyPath)
//        {
//            return (Assembly)loadFromAssemblyPathMethod.Invoke(CustomContext, new[] { assemblyPath });
//        }

//        internal static AssemblyLoadContextProxy CreateLoadContext(string name)
//        {
//            if (string.IsNullOrEmpty(name))
//            {
//                throw new ArgumentNullException(nameof(name));
//            }

//            var alc = typeof(object).Assembly.GetType("System.Runtime.Loader.AssemblyLoadContext");
//            return alc != null
//                ? new AssemblyLoadContextProxy(alc, name)
//                : null;
//        }
//    }
//}
