﻿// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace Microsoft.Graph.PowerShell.Authentication.Utilities
{
    public static class DependencyAssemblyResolver
    {
        // Catalog our dependencies here to ensure we don't load anything else.
        private static IReadOnlyDictionary<string, Version> Dependencies = new Dictionary<string, Version>
        {
            { "Azure.Core", new Version("1.25.0") },
            { "Azure.Identity", new Version("1.7.0") },
            { "Azure.Identity.BrokeredAuthentication", new Version("1.0.0") },
            { "Microsoft.Bcl.AsyncInterfaces", new Version("6.0.0") },
            { "Microsoft.Graph.Core", new Version("2.0.14") },
            { "Microsoft.Identity.Client", new Version("4.47.2") },
            { "Microsoft.Identity.Client.Broker", new Version("4.47.2") },
            { "Microsoft.Identity.Client.NativeInterop", new Version("0.13.0")},
            { "Microsoft.Identity.Client.Extensions.Msal", new Version("2.24.0") },
            { "Microsoft.IdentityModel.Abstractions", new Version("6.27.0") },
            { "Microsoft.IdentityModel.JsonWebTokens", new Version("6.27.0") },
            { "Microsoft.IdentityModel.Logging", new Version("6.27.0") },
            { "Microsoft.IdentityModel.Tokens", new Version("6.27.0") },
            { "System.IdentityModel.Tokens.Jwt", new Version("6.27.0") },
            { "System.Security.Cryptography.ProtectedData", new Version("6.0.0") },
            { "Newtonsoft.Json", new Version("13.0.1") },
            { "System.Text.Json", new Version("7.0.1") },
            { "System.Text.Encodings.Web", new Version("6.0.0") },
            { "System.Threading.Tasks.Extensions", new Version("4.5.4") },
            { "System.Diagnostics.DiagnosticSource", new Version("4.0.4") },
            { "System.Runtime.CompilerServices.Unsafe", new Version("4.0.4") },
            { "System.Memory", new Version("4.0.1") },
            { "System.Buffers", new Version("4.0.2") },
            { "System.Numerics.Vectors", new Version("4.1.3") },
            { "System.Net.Http.WinHttpHandler", new Version("6.0.0") }
        };

        /// <summary>
        /// Dependencies that need to be loaded per framework.
        /// </summary>
        private static readonly IList<string> MultiFrameworkDependencies = new List<string> {
            "Microsoft.Identity.Client",
            "System.Security.Cryptography.ProtectedData",
            "Microsoft.Graph.Core",
            "System.Net.Http.WinHttpHandler"
        };

        // Set up the path to our dependency directory within the module.
        private static readonly string DependenciesDirPath = Path.GetFullPath(Path.Combine(
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
                    && (requiredVersion.Major >= assemblymName.Version.Major || string.Equals(assemblymName.Name, "Newtonsoft.Json", StringComparison.OrdinalIgnoreCase)))
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
