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
        /// Maps the simple name of each assembly that makes up the shared framework (Trusted Platform Assemblies) to the
        /// full path of the runtime copy. These normally come from the runtime, never from the module's Dependencies
        /// folder: loading e.g. the netstandard build of System.Memory.dll into this context would create a second,
        /// incompatible ReadOnlyMemory&lt;T&gt; type. The path is retained so the runtime version can be compared against
        /// the version the module ships, allowing the module's copy to win when it is strictly newer (e.g. the module
        /// ships a far newer System.Text.Json than the one bundled with PowerShell 7.2/7.4).
        /// </summary>
        private static readonly Dictionary<string, string> s_trustedPlatformAssemblies = GetTrustedPlatformAssemblies();

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
            if (s_sharedAssemblyNames.Contains(assemblyName.Name))
            {
                // Defer to the default context so type identity is preserved across the boundary.
                return null;
            }

            string path = ResolveManagedPath(assemblyName.Name);

            if (s_trustedPlatformAssemblies.TryGetValue(assemblyName.Name, out string runtimePath))
            {
                // This is a shared-framework assembly. Normally the runtime copy must win so that types such as
                // ReadOnlyMemory<T> keep a single identity. However, the module may intentionally ship a newer version
                // (for example System.Text.Json 10.x against PowerShell 7.2/7.4 which only bundle 6.x/8.x). In that case
                // the runtime copy cannot satisfy the reference, so prefer the module's assembly when it is strictly newer.
                if (path == null || !ModuleAssemblyIsNewer(path, runtimePath))
                {
                    return null;
                }
            }

            return path != null ? LoadFromAssemblyPath(path) : null;
        }

        /// <summary>
        /// Determines whether the assembly the module ships at <paramref name="modulePath"/> has a higher assembly version
        /// than the runtime copy at <paramref name="runtimePath"/>. When versions cannot be read the runtime copy is
        /// preferred (returns false) to keep the conservative shared-framework behaviour.
        /// </summary>
        private static bool ModuleAssemblyIsNewer(string modulePath, string runtimePath)
        {
            try
            {
                Version moduleVersion = AssemblyName.GetAssemblyName(modulePath).Version;
                Version runtimeVersion = AssemblyName.GetAssemblyName(runtimePath).Version;
                return moduleVersion != null && runtimeVersion != null && moduleVersion > runtimeVersion;
            }
            catch
            {
                return false;
            }
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

        private static Dictionary<string, string> GetTrustedPlatformAssemblies()
        {
            var result = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            if (AppContext.GetData("TRUSTED_PLATFORM_ASSEMBLIES") is string tpa)
            {
                foreach (string path in tpa.Split(Path.PathSeparator))
                {
                    if (!string.IsNullOrEmpty(path))
                        result[Path.GetFileNameWithoutExtension(path)] = path;
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
