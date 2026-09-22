// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System;
using System.Reflection;
using System.Runtime.Loader;

namespace Microsoft.Graph.PowerShell.Authentication.Loader
{
    /// <summary>
    /// Entry point used by the cmdlet assembly (via reflection, since it targets netstandard2.0) to set up the
    /// isolated <see cref="GraphAssemblyLoadContext"/> and hook the default context so that requests for
    /// Microsoft.Graph.Authentication.Core are redirected into it.
    /// </summary>
    public static class GraphLoadContextInitializer
    {
        /// <summary>
        /// Simple name of the engine assembly that is redirected into the isolated context.
        /// </summary>
        public const string CoreAssemblyName = "Microsoft.Graph.Authentication.Core";

        private static readonly object s_lock = new object();
        private static GraphAssemblyLoadContext s_context;

        /// <summary>
        /// The isolated context; null until <see cref="Initialize"/> has been called.
        /// </summary>
        public static GraphAssemblyLoadContext Context => s_context;

        /// <summary>
        /// Creates the isolated context and registers the default-context redirect. Safe to call multiple times.
        /// </summary>
        /// <param name="dependencyFolder">Path to the module's <c>Dependencies</c> folder.</param>
        /// <param name="psEditionDependencyFolder">Path to the module's <c>Dependencies/Core</c> folder.</param>
        public static void Initialize(string dependencyFolder, string psEditionDependencyFolder)
        {
            if (s_context != null)
                return;

            lock (s_lock)
            {
                if (s_context != null)
                    return;

                s_context = new GraphAssemblyLoadContext(dependencyFolder, psEditionDependencyFolder);
                AssemblyLoadContext.Default.Resolving += OnDefaultResolving;
            }
        }

        /// <summary>
        /// Unregisters the default-context redirect. The isolated context itself is not collectible and remains alive
        /// for the lifetime of the process, which matches PowerShell's own behaviour for binary modules.
        /// </summary>
        public static void Shutdown()
        {
            lock (s_lock)
            {
                if (s_context == null)
                    return;
                AssemblyLoadContext.Default.Resolving -= OnDefaultResolving;
            }
        }

        private static Assembly OnDefaultResolving(AssemblyLoadContext defaultContext, AssemblyName assemblyName)
        {
            // Only the engine assembly is bridged into the default context. Everything else that Core needs is
            // resolved by GraphAssemblyLoadContext.Load and stays invisible to other modules.
            if (!string.Equals(assemblyName.Name, CoreAssemblyName, StringComparison.OrdinalIgnoreCase))
                return null;

            var context = s_context;
            if (context == null)
                return null;

            string path = context.ResolveManagedPath(assemblyName.Name);
            return path != null ? context.LoadFromAssemblyPath(path) : null;
        }
    }
}
