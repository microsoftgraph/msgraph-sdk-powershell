// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.PowerShell.Authentication.Utilities
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Reflection;
    public static class DependencyAssemblyResolver
    {
        // Catalog our dependencies here to ensure we don't load anything else.
        private static IReadOnlyDictionary<string, Version> Dependencies = new Dictionary<string, Version>
        {
            { "Microsoft.Identity.Client", new Version("4.23.0.0") },
            { "Microsoft.Graph.Auth",  new Version("1.0.0.0") },
            { "Microsoft.IdentityModel.Tokens", new Version("5.6.0.61018") },
            { "Microsoft.IdentityModel.Logging", new Version("5.6.0.61018") },
            { "Microsoft.IdentityModel.JsonWebTokens", new Version("5.6.0.61018") },
            { "System.IdentityModel.Tokens.Jwt", new Version("5.6.0.61018") },
            { "System.Security.Cryptography.ProtectedData", new Version("4.3.0.0") },
            { "Newtonsoft.Json", new Version("10.0.3.21018") },
        };

        /// <summary>
        /// Dependencies that need to be loaded per framework.
        /// </summary>
        private static IList<string> MultiFrameworkDependencies = new List<string> {
            "Microsoft.Identity.Client",
            "System.Security.Cryptography.ProtectedData"
        };

        // Set up the path to our dependency directory within the module.
        private static string DependenciesDirPath = Path.GetFullPath(Path.Combine(
                Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Dependencies"));

        /// <summary>
        /// Framework dependency path. /Desktop for PS 5.1, and /Core for PS 6+.
        /// </summary>
        private static string FrameworkDependenciesDirPath;

        /// <summary>
        /// Initializes our custom assembly resolve event handler. This should be called on module import.
        /// </summary>
        /// <param name="isDesktopEdition"></param>
        public static void Initialize(bool isDesktopEdition = false)
        {
            if (isDesktopEdition)
            {
                FrameworkDependenciesDirPath = "Desktop";
            }
            else
            {
                FrameworkDependenciesDirPath = "Core";
            }
            // Set up our event handler when the module is loaded.
            AppDomain.CurrentDomain.AssemblyResolve += HandleResolveEvent;
        }

        /// <summary>
        /// Remove our custom assembly resolve event handler from the current app domain.
        /// This should be called when our module is removed.
        /// </summary>
        internal static void Reset()
        {
            // Remove our event hander when the module is unloaded.
            AppDomain.CurrentDomain.AssemblyResolve -= HandleResolveEvent;
        }


        private static Assembly HandleResolveEvent(object sender, ResolveEventArgs args)
        {
            try
            {
                AssemblyName assemblymName = new AssemblyName(args.Name);
                // We try to resolve our dependencies on our own.
                if (Dependencies.TryGetValue(assemblymName.Name, out Version requiredVersion)
                    && requiredVersion >= assemblymName.Version
                    && (requiredVersion.Major == assemblymName.Version.Major || string.Equals(assemblymName.Name, "Newtonsoft.Json", StringComparison.OrdinalIgnoreCase)))
                {
                    string requiredAssemblyPath = string.Empty;
                    if (MultiFrameworkDependencies.Contains(assemblymName.Name))
                    {
                        requiredAssemblyPath = Path.Combine(DependenciesDirPath, FrameworkDependenciesDirPath, $"{assemblymName.Name}.dll");
                    }
                    else
                    {
                        requiredAssemblyPath = Path.Combine(DependenciesDirPath, $"{assemblymName.Name}.dll");
                    }
                    return Assembly.LoadFile(requiredAssemblyPath);
                }
            }
            catch
            {
                // If an error is encountered, we fall back to PowerShell's default dependency resolution.
            }
            return null;
        }
    }
}
