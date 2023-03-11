// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using Microsoft.Graph.PowerShell.Authentication.Core.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace Microsoft.Graph.PowerShell.Authentication.Utilities
{
    public static class DependencyAssemblyResolver
    {
        private static readonly Assembly Self = typeof(DependencyAssemblyResolver).Assembly;
        private static readonly Assembly Core = typeof(AuthenticationHelpers).Assembly;
        private static readonly AssemblyLoadContextProxy Proxy = AssemblyLoadContextProxy.CreateLoadContext("msgraph-load-context");

        // Catalog our dependencies here to ensure we don't load anything else.
        private static readonly HashSet<string> Dependencies = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            "Azure.Core",
            "Azure.Identity",
            "Microsoft.Bcl.AsyncInterfaces",
            "Microsoft.Graph.Core",
            "Microsoft.Identity.Client",
            "Microsoft.Identity.Client.Extensions.Msal",
            "Microsoft.IdentityModel.Abstractions",
            "Microsoft.IdentityModel.JsonWebTokens",
            "Microsoft.IdentityModel.Logging",
            "Microsoft.IdentityModel.Tokens",
            "System.IdentityModel.Tokens.Jwt",
            "System.Security.Cryptography.ProtectedData",
            "Newtonsoft.Json",
            "System.Text.Json",
            "System.Text.Encodings.Web",
            "System.Threading.Tasks.Extensions",
            "System.Diagnostics.DiagnosticSource",
            "System.Runtime.CompilerServices.Unsafe",
            "System.Memory",
            "System.Buffers",
            "System.Numerics.Vectors",
            "System.Net.Http.WinHttpHandler"
        };

        /// <summary>
        /// Dependencies that need to be loaded per framework.
        /// </summary>
        private static readonly IList<string> MultiFrameworkDependencies = new List<string> {
            "Azure.Core",
            "Azure.Identity",
            "Microsoft.Identity.Client",
            "Microsoft.Identity.Client.Extensions.Msal",
            "System.Security.Cryptography.ProtectedData",
            "Microsoft.Graph.Core",
            "System.Net.Http.WinHttpHandler"
        };

        // Set up the path to our dependency directory within the module.
        private static readonly string DependencyFolder = Path.GetFullPath(Path.Combine(Path.GetDirectoryName(Self.Location), "Dependencies"));

        /// <summary>
        /// Framework dependency path. /Desktop for PS 5.1, and /Core for PS 6+.
        /// </summary>
        private static string PSEdition;

        /// <summary>
        /// Initializes our custom assembly resolve event handler. This should be called on module import.
        /// </summary>
        /// <param name="isDesktopEdition"></param>
        public static void Initialize(bool isDesktopEdition = false)
        {
            PSEdition = isDesktopEdition ? "Desktop" : "Core";
            // Set up our event handler when the module is loaded.
            AppDomain.CurrentDomain.AssemblyResolve += ResolvingHandler;
        }

        /// <summary>
        /// Remove our custom assembly resolve event handler from the current app domain.
        /// This should be called when our module is removed.
        /// </summary>
        internal static void Reset()
        {
            // Remove our event hander when the module is unloaded.
            AppDomain.CurrentDomain.AssemblyResolve -= ResolvingHandler;
        }

        private static Assembly ResolvingHandler(object sender, ResolveEventArgs args)
        {
            try
            {
                AssemblyName assemblyName = new AssemblyName(args.Name);
                // We try to resolve our dependencies on our own.
                if (Dependencies.Contains(assemblyName.Name))
                {
                    string requiredAssemblyPath = MultiFrameworkDependencies.Contains(assemblyName.Name)
                        ? requiredAssemblyPath = Path.Combine(DependencyFolder, PSEdition, $"{assemblyName.Name}.dll")
                        : requiredAssemblyPath = Path.Combine(DependencyFolder, $"{assemblyName.Name}.dll");
                    if (File.Exists(requiredAssemblyPath))
                    {
                        // - In .NET, load the assembly into the custom assembly load context.
                        // - In .NET Framework, assembly conflict is not a problem, so we load the assembly
                        //   by 'Assembly.LoadFrom', the same as what powershell.exe would do.
                        return Proxy != null
                            ? Proxy.LoadFromAssemblyPath(requiredAssemblyPath)
                            : Assembly.LoadFrom(requiredAssemblyPath);
                    }
                }
            }
            catch
            {
                // If an error is encountered, we fall back to PowerShell's default dependency resolution.
            }
            return null;
        }
    }

    internal class AssemblyLoadContextProxy
    {
        private readonly object CustomContext;
        private readonly MethodInfo loadFromAssemblyPathMethod;

        private AssemblyLoadContextProxy(Type alc, string loadContextName)
        {
            var ctor = alc.GetConstructor(new[] { typeof(string), typeof(bool) });
            loadFromAssemblyPathMethod = alc.GetMethod("LoadFromAssemblyPath", new[] { typeof(string) });
            CustomContext = ctor.Invoke(new object[] { loadContextName, false });
        }

        internal Assembly LoadFromAssemblyPath(string assemblyPath)
        {
            return (Assembly)loadFromAssemblyPathMethod.Invoke(CustomContext, new[] { assemblyPath });
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
