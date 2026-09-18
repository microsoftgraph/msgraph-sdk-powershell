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
        // Keep one entry per simple assembly name. The map records the packaged identity as
        // well as its path so a request is validated before a file is selected for loading.
        private static readonly Dictionary<string, AssemblyDependency> s_dependencies;
        private static readonly AssemblyLoadContextProxy s_proxy;
        // AssemblyResolve is process-wide, even though PowerShell modules are imported into
        // module or runspace scopes. Serialize registration so repeated imports do not attach
        // the same static handler more than once.
        private static readonly object s_resolverLock = new object();
        private static bool s_resolverRegistered;

        static ModuleInitializer()
        {
            s_dependencyFolder = Path.Combine(Path.GetDirectoryName(typeof(ModuleInitializer).Assembly.Location), "Dependencies");
            s_psEditionDependencyFolder = Path.Combine(s_dependencyFolder, RuntimeUtils.IsPsCore() ? "Core" : "Desktop");
            s_dependencies = new Dictionary<string, AssemblyDependency>(StringComparer.OrdinalIgnoreCase);
            s_proxy = AssemblyLoadContextProxy.CreateLoadContext("msgraph-load-context");

            // Shared assets provide the baseline. Adding the PowerShell-edition folder second
            // intentionally replaces entries with the same simple name, ensuring that Core or
            // Desktop assets win without relying on filesystem enumeration order.
            AddDependencies(s_dependencyFolder);
            AddDependencies(s_psEditionDependencyFolder);
        }

        /// <inheritDoc/>
        public void OnImport()
        {
            lock (s_resolverLock)
            {
                if (!s_resolverRegistered)
                {
                    AppDomain.CurrentDomain.AssemblyResolve += ResolvingHandler;
                    s_resolverRegistered = true;
                }
            }
        }

        /// <inheritDoc/>
        public void OnRemove(PSModuleInfo psModuleInfo)
        {
            lock (s_resolverLock)
            {
                if (s_resolverRegistered)
                {
                    AppDomain.CurrentDomain.AssemblyResolve -= ResolvingHandler;
                    s_resolverRegistered = false;
                }
            }
        }

        /// <summary>
        /// Checks to see if the requested assembly matches the assemblies in our dependencies folder.
        /// The requesting assembly is always available in .NET, but could be null in .NET Framework.
        /// Only requests from Graph assemblies or assemblies already loaded from Graph's dependency
        /// folders or custom load context are handled. This prevents the process-wide resolver from
        /// supplying Graph dependencies to unrelated modules.
        /// </summary>
        /// <param name="assemblyName"><see cref="AssemblyName"/> being requested.</param>
        /// <param name="requestingAssembly">The requesting <see cref="Assembly"/>.</param>
        /// <returns>True if assembly is present and matches in dependencies folder; otherwise False.</returns>
        private static bool IsAssemblyMatching(AssemblyName assemblyName, Assembly requestingAssembly)
        {
            return IsAssemblyPresent(assemblyName)
                && AssemblyRequestOwnership.IsOwned(
                    requestingAssembly,
                    s_dependencyFolder,
                    s_proxy == null ? null : new Func<Assembly, bool>(s_proxy.Contains),
                    allowUnknownRequester: s_proxy == null);
        }

        /// <summary>
        /// Checks to see if the assembly is present in the shared or PSEdition dependencies folder.
        /// The packaged assembly must have the same name, culture, and public key token, and its
        /// version must be equal to or greater than the requested version.
        /// </summary>
        /// <param name="assemblyName"><see cref="AssemblyName"/> to match.</param>
        /// <returns>True if assembly is present in dependencies folder; otherwise False.</returns>
        private static bool IsAssemblyPresent(AssemblyName assemblyName)
        {
            return s_dependencies.TryGetValue(assemblyName.Name, out AssemblyDependency dependency)
                && AssemblyIdentity.IsCompatible(assemblyName, dependency.Name);
        }

        /// <summary>
        /// Gets the full path of the assembly from the dependencies folder.
        /// </summary>
        /// <param name="assemblyName"><see cref="AssemblyName"/> to find.</param>
        /// <returns>A <see cref="string"/> representing the full path of the assembly from the dependencies folder; otherwise <see cref="null"/>.</returns>
        private static string GetRequiredAssemblyPath(AssemblyName assemblyName)
        {
            return s_dependencies.TryGetValue(assemblyName.Name, out AssemblyDependency dependency)
                ? dependency.Path
                : null;
        }

        private static void AddDependencies(string dependencyFolder)
        {
            foreach (string filePath in Directory.EnumerateFiles(dependencyFolder, "*.dll"))
            {
                try
                {
                    var assemblyName = AssemblyName.GetAssemblyName(filePath);
                    // Assignment, rather than Add, implements the edition-specific override
                    // described in the static constructor.
                    s_dependencies[assemblyName.Name] = new AssemblyDependency(assemblyName, filePath);
                }
                catch (BadImageFormatException)
                {
                    // Skip native files without managed assembly metadata.
                }
            }
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
                    // - MSAL's WAM stack is process-shared because its native runtime supports one
                    //   global initialization. Loading matching MSAL stacks into separate contexts
                    //   creates independent RuntimeBroker statics that compete for that native state.
                    // - If EXO loaded a compatible shared dependency first, return that exact
                    //   default-context instance. Attempting to load Graph's copy would create a
                    //   second identity in Default or fail because Default already owns the name.
                    // - In .NET Framework, assembly conflict is not a problem, so we load the assembly
                    //   by 'Assembly.LoadFrom', the same as what powershell.exe would do.
                    if (s_proxy != null
                        && AssemblyDependencyPolicy.IsProcessShared(
                            assemblyName.Name,
                            args.RequestingAssembly?.GetName().Name))
                    {
                        return s_proxy.FindDefaultAssembly(assemblyName)
                            ?? Assembly.LoadFrom(filePath);
                    }

                    return s_proxy != null
                        ? s_proxy.LoadFromAssemblyPath(filePath)
                        : Assembly.LoadFrom(filePath);
                }
            }
            return null;
        }
    }

    internal static class AssemblyDependencyPolicy
    {
        // These assemblies form one managed/native broker unit. They must share the process
        // default context so Graph and EXO reach the same RuntimeBroker static state and native
        // msalruntime initialization.
        private static readonly HashSet<string> s_processSharedDependencies =
            new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            {
                "Microsoft.Identity.Client",
                "Microsoft.Identity.Client.Broker",
                "Microsoft.Identity.Client.NativeInterop"
            };

        // Microsoft.IdentityModel.Abstractions cannot be globally classified as either shared
        // or private. MSAL exposes IIdentityLogger in public method signatures, so Azure.Identity
        // and the broker must see the same type identity as default-context MSAL. Graph's separate
        // IdentityModel stack, however, must retain its packaged version in msgraph-load-context.
        private static readonly HashSet<string> s_identityLoggerConsumers =
            new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            {
                "Azure.Identity",
                "Azure.Identity.Broker",
                "Microsoft.Identity.Client",
                "Microsoft.Identity.Client.Broker"
            };

        internal static bool IsProcessShared(string assemblyName, string requestingAssemblyName)
        {
            if (string.IsNullOrEmpty(assemblyName))
            {
                return false;
            }

            return s_processSharedDependencies.Contains(assemblyName)
                // Share the logging contract only when the request crosses the private
                // Azure.Identity to process-wide MSAL boundary.
                || (string.Equals(
                        assemblyName,
                        "Microsoft.IdentityModel.Abstractions",
                        StringComparison.OrdinalIgnoreCase)
                    && !string.IsNullOrEmpty(requestingAssemblyName)
                    && s_identityLoggerConsumers.Contains(requestingAssemblyName));
        }
    }

    internal sealed class AssemblyDependency
    {
        internal AssemblyDependency(AssemblyName name, string path)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Path = path ?? throw new ArgumentNullException(nameof(path));
        }

        internal AssemblyName Name { get; }

        internal string Path { get; }
    }

    internal static class AssemblyIdentity
    {
        /// <summary>
        /// Determines whether a packaged or already loaded assembly can satisfy a request.
        /// A newer assembly version is accepted only when its name, culture, and signing token
        /// match; this supports compatible roll-forward while rejecting unrelated same-name DLLs.
        /// </summary>
        internal static bool IsCompatible(AssemblyName requested, AssemblyName packaged)
        {
            if (requested == null || packaged == null
                || !string.Equals(requested.Name, packaged.Name, StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }

            if (requested.Version != null && packaged.Version != null && packaged.Version < requested.Version)
            {
                return false;
            }

            string requestedCulture = NormalizeCulture(requested.CultureName);
            string packagedCulture = NormalizeCulture(packaged.CultureName);
            if (!string.Equals(requestedCulture, packagedCulture, StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }

            byte[] requestedToken = requested.GetPublicKeyToken();
            byte[] packagedToken = packaged.GetPublicKeyToken();
            return requestedToken == null || requestedToken.Length == 0
                || (packagedToken != null && requestedToken.SequenceEqual(packagedToken));
        }

        private static string NormalizeCulture(string culture)
        {
            return string.IsNullOrEmpty(culture) ? "neutral" : culture;
        }
    }

    internal static class AssemblyRequestOwnership
    {
        // Graph service assemblies are installed outside Authentication's dependency directory,
        // so their product namespace is the bootstrap signal. Transitive dependencies are owned
        // by their load context or by their physical location under Dependencies.
        private const string GraphAssemblyPrefix = "Microsoft.Graph.";

        internal static bool IsOwned(
            Assembly requestingAssembly,
            string dependencyFolder,
            Func<Assembly, bool> isInGraphLoadContext,
            bool allowUnknownRequester)
        {
            if (requestingAssembly == null)
            {
                return allowUnknownRequester;
            }

            string assemblyName = requestingAssembly.GetName().Name;
            if (!string.IsNullOrEmpty(assemblyName)
                && assemblyName.StartsWith(GraphAssemblyPrefix, StringComparison.Ordinal))
            {
                return true;
            }

            if (isInGraphLoadContext != null && isInGraphLoadContext(requestingAssembly))
            {
                return true;
            }

            return IsLoadedFromDirectory(requestingAssembly, dependencyFolder);
        }

        private static bool IsLoadedFromDirectory(Assembly assembly, string directory)
        {
            if (string.IsNullOrEmpty(directory))
            {
                return false;
            }

            string assemblyLocation;
            try
            {
                assemblyLocation = assembly.Location;
            }
            catch (NotSupportedException)
            {
                return false;
            }

            if (string.IsNullOrEmpty(assemblyLocation))
            {
                return false;
            }

            string directoryPath = Path.GetFullPath(directory)
                .TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar)
                + Path.DirectorySeparatorChar;
            string assemblyPath = Path.GetFullPath(assemblyLocation);
            StringComparison comparison = Path.DirectorySeparatorChar == '\\' //use built in for windows
                ? StringComparison.OrdinalIgnoreCase
                : StringComparison.Ordinal;

            return assemblyPath.StartsWith(directoryPath, comparison);
        }
    }

    /// <summary>
    /// An encapsulation of reflection API calls to create a custom AssemblyLoadContext. <see cref="AssemblyLoadContext"/> type is not available when targeting netstandard2.0 .NET Framework.
    /// </summary>
    internal class AssemblyLoadContextProxy
    {
        private readonly object _customContext;
        private readonly object _defaultContext;
        private readonly MethodInfo _loadFromAssemblyPath;
        private readonly MethodInfo _getLoadContext;

        private AssemblyLoadContextProxy(Type alc, string loadContextName)
        {
            var ctor = alc.GetConstructor(new[] { typeof(string), typeof(bool) });
            _loadFromAssemblyPath = alc.GetMethod("LoadFromAssemblyPath", new[] { typeof(string) });
            _getLoadContext = alc.GetMethod("GetLoadContext", BindingFlags.Public | BindingFlags.Static);
            _customContext = ctor.Invoke(new object[] { loadContextName, false });
            _defaultContext = alc.GetProperty("Default", BindingFlags.Public | BindingFlags.Static).GetValue(null);
        }

        internal Assembly LoadFromAssemblyPath(string assemblyPath)
        {
            return (Assembly)_loadFromAssemblyPath.Invoke(_customContext, new[] { assemblyPath });
        }

        internal bool Contains(Assembly assembly)
        {
            if (assembly == null)
            {
                return false;
            }

            return ReferenceEquals(
                _customContext,
                _getLoadContext.Invoke(null, new object[] { assembly }));
        }

        internal Assembly FindDefaultAssembly(AssemblyName requestedAssembly)
        {
            // Query assemblies already materialized in Default rather than asking Default to load
            // by name. This makes import order explicit: EXO-first reuses EXO's compatible copy,
            // while Graph-first loads the packaged Graph copy through the resolver.
            return AppDomain.CurrentDomain.GetAssemblies()
                .FirstOrDefault(assembly =>
                    ReferenceEquals(
                        _defaultContext,
                        _getLoadContext.Invoke(null, new object[] { assembly }))
                    && AssemblyIdentity.IsCompatible(requestedAssembly, assembly.GetName()));
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
