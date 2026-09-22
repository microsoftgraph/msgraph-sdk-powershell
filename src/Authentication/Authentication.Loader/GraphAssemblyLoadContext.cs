// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Loader;

namespace Microsoft.Graph.PowerShell.Authentication.Loader
{
    /// <summary>
    /// A private <see cref="AssemblyLoadContext"/> that hosts Microsoft.Graph.Authentication.Core and all of its
    /// third-party dependencies (Azure.Identity, Microsoft.Identity.Client, Microsoft.Kiota.*, Microsoft.Graph.Core, ...)
    /// so that they never collide with copies loaded by other PowerShell modules in the default context.
    /// </summary>
    public sealed class GraphAssemblyLoadContext : AssemblyLoadContext
    {
        /// <summary>
        /// Assemblies that must always be resolved from the default load context because their types are shared
        /// with the cmdlet assembly, the PowerShell engine or the generated service modules.
        /// </summary>
        private static readonly HashSet<string> s_sharedAssemblyNames = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            "Newtonsoft.Json",
            "System.Management.Automation",
            "Microsoft.PowerShell.Commands.Utility",
            "Microsoft.PowerShell.Commands.Management",
            "Microsoft.PowerShell.Security",
            "Microsoft.PowerShell.ConsoleHost",
            "Microsoft.Graph.Authentication",
            "Microsoft.Graph.Authentication.Loader",
        };

        /// <summary>
        /// Simple names of the assemblies that make up the shared framework (Trusted Platform Assemblies). These must always
        /// come from the runtime, never from the module's Dependencies folder: loading e.g. the netstandard build of
        /// System.Memory.dll into this context would create a second, incompatible ReadOnlyMemory&lt;T&gt; type.
        /// </summary>
        private static readonly HashSet<string> s_trustedPlatformAssemblies = GetTrustedPlatformAssemblies();

        private readonly string _dependencyFolder;
        private readonly string _psEditionDependencyFolder;
        private readonly string _nativeFolder;

        public GraphAssemblyLoadContext(string dependencyFolder, string psEditionDependencyFolder)
            : base(name: "Microsoft.Graph.Authentication", isCollectible: false)
        {
            _dependencyFolder = dependencyFolder ?? throw new ArgumentNullException(nameof(dependencyFolder));
            _psEditionDependencyFolder = psEditionDependencyFolder ?? throw new ArgumentNullException(nameof(psEditionDependencyFolder));
            _nativeFolder = Path.Combine(_dependencyFolder, "runtimes", GetRuntimeIdentifier(), "native");
        }

        /// <summary>
        /// Gets the folder containing shared managed dependencies.
        /// </summary>
        public string DependencyFolder => _dependencyFolder;

        /// <summary>
        /// Gets the folder containing PowerShell edition specific managed dependencies.
        /// </summary>
        public string PSEditionDependencyFolder => _psEditionDependencyFolder;

        /// <inheritdoc/>
        protected override Assembly Load(AssemblyName assemblyName)
        {
            if (s_sharedAssemblyNames.Contains(assemblyName.Name) || s_trustedPlatformAssemblies.Contains(assemblyName.Name))
            {
                // Defer to the default context so type identity is preserved across the boundary.
                return null;
            }

            string path = ResolveManagedPath(assemblyName.Name);
            return path != null ? LoadFromAssemblyPath(path) : null;
        }

        /// <inheritdoc/>
        protected override IntPtr LoadUnmanagedDll(string unmanagedDllName)
        {
            foreach (string candidate in GetNativeCandidates(unmanagedDllName))
            {
                if (File.Exists(candidate))
                {
                    return LoadUnmanagedDllFromPath(candidate);
                }
            }
            return IntPtr.Zero;
        }

        /// <summary>
        /// Attempts to resolve a managed assembly file for the given simple name from the module's dependency folders.
        /// </summary>
        /// <param name="simpleName">Simple assembly name (without extension).</param>
        /// <returns>The full path when found; otherwise null.</returns>
        public string ResolveManagedPath(string simpleName)
        {
            string fileName = simpleName + ".dll";

            string path = Path.Combine(_psEditionDependencyFolder, fileName);
            if (File.Exists(path))
                return path;

            path = Path.Combine(_dependencyFolder, fileName);
            return File.Exists(path) ? path : null;
        }

        private IEnumerable<string> GetNativeCandidates(string unmanagedDllName)
        {
            string fileName = unmanagedDllName.EndsWith(".dll", StringComparison.OrdinalIgnoreCase) ? unmanagedDllName : unmanagedDllName + ".dll";
            yield return Path.Combine(_nativeFolder, fileName);
            yield return Path.Combine(_psEditionDependencyFolder, "runtimes", GetRuntimeIdentifier(), "native", fileName);
            yield return Path.Combine(_psEditionDependencyFolder, fileName);
            yield return Path.Combine(_dependencyFolder, fileName);
        }

        private static HashSet<string> GetTrustedPlatformAssemblies()
        {
            var result = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            if (AppContext.GetData("TRUSTED_PLATFORM_ASSEMBLIES") is string tpa)
            {
                foreach (string path in tpa.Split(Path.PathSeparator))
                {
                    if (!string.IsNullOrEmpty(path))
                        result.Add(Path.GetFileNameWithoutExtension(path));
                }
            }
            return result;
        }

        private static string GetRuntimeIdentifier()
        {
            string os = RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? "win"
                : RuntimeInformation.IsOSPlatform(OSPlatform.OSX) ? "osx"
                : "linux";
            string arch = RuntimeInformation.ProcessArchitecture switch
            {
                Architecture.X86 => "x86",
                Architecture.Arm64 => "arm64",
                Architecture.Arm => "arm",
                _ => "x64",
            };
            return $"{os}-{arch}";
        }
    }
}
