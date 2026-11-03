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
    /// Microsoft.Graph.Authentication.Core and the Kiota contracts used by generated v3 cmdlets are redirected into it.
    /// </summary>
    public static class GraphLoadContextInitializer
    {
        /// <summary>
        /// Simple name of the engine assembly that is redirected into the isolated context.
        /// </summary>
        public const string CoreAssemblyName = "Microsoft.Graph.Authentication.Core";

        private static readonly object s_lock = new object();
        private static GraphAssemblyLoadContext s_context;
        private static bool s_resolvingHooked;

        /// <summary>
        /// The isolated context; null until <see cref="Initialize"/> has been called.
        /// </summary>
        public static GraphAssemblyLoadContext Context => s_context;

        /// <summary>
        /// Creates the isolated context (once) and ensures the default-context redirect is registered. Safe to call
        /// multiple times, including after a <see cref="Shutdown"/> triggered by a module remove: the isolated context is
        /// reused while the <see cref="AssemblyLoadContext.Resolving"/> hook is re-established so a remove/re-import cycle
        /// keeps resolving Microsoft.Graph.Authentication.Core.
        /// </summary>
        /// <param name="dependencyFolder">Path to the module's <c>Dependencies</c> folder.</param>
        /// <param name="psEditionDependencyFolder">Path to the module's <c>Dependencies/Core</c> folder.</param>
        public static void Initialize(string dependencyFolder, string psEditionDependencyFolder)
        {
            lock (s_lock)
            {
                if (s_context == null)
                {
                    s_context = new GraphAssemblyLoadContext(dependencyFolder, psEditionDependencyFolder);
                }

                if (!s_resolvingHooked)
                {
                    AssemblyLoadContext.Default.Resolving += OnDefaultResolving;
                    s_resolvingHooked = true;
                }
            }
        }

        /// <summary>
        /// Unregisters the default-context redirect. The isolated context itself is not collectible and remains alive
        /// for the lifetime of the process, which matches PowerShell's own behaviour for binary modules; a later
        /// <see cref="Initialize"/> call re-registers the redirect against the existing context.
        /// </summary>
        public static void Shutdown()
        {
            lock (s_lock)
            {
                if (!s_resolvingHooked)
                    return;
                AssemblyLoadContext.Default.Resolving -= OnDefaultResolving;
                s_resolvingHooked = false;
            }
        }

        private static Assembly OnDefaultResolving(AssemblyLoadContext defaultContext, AssemblyName assemblyName)
        {
            // Generated v3 cmdlets expose Kiota models and value types. Resolve those contracts to the SAME
            // assemblies used by the authenticated HTTP pipeline, without loading a second dependency closure.
            if (!string.Equals(assemblyName.Name, CoreAssemblyName, StringComparison.OrdinalIgnoreCase)
                && !assemblyName.Name.StartsWith("Microsoft.Kiota.", StringComparison.OrdinalIgnoreCase))
                return null;

            var context = s_context;
            if (context == null)
                return null;

            return context.ResolveManagedPath(assemblyName.Name) != null ? context.LoadFromAssemblyName(assemblyName) : null;
        }
    }
}
