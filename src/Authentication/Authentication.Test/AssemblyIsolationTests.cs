// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using Microsoft.Graph.PowerShell.Authentication;
using System;
using System.Linq;
using Xunit;

namespace Microsoft.Graph.Authentication.Test
{
    /// <summary>
    /// Guards the AssemblyLoadContext isolation boundary: the cmdlet assembly (Microsoft.Graph.Authentication.dll) is loaded
    /// into the default load context by PowerShell, so it must never reference any of the assemblies that are isolated inside
    /// the module's private load context. If this test fails, a type from an isolated dependency leaked into the cmdlet assembly
    /// and must be moved behind an API in Microsoft.Graph.Authentication.Core.
    /// </summary>
    public class AssemblyIsolationTests
    {
        private static readonly string[] IsolatedAssemblyPrefixes =
        {
            "Azure.",
            "Microsoft.Identity.",
            "Microsoft.IdentityModel.",
            "Microsoft.Graph.Core",
            "Microsoft.Kiota.",
            "System.Text.Json",
            "System.ClientModel",
            "System.Memory.Data",
        };

        [Fact]
        public void CmdletAssemblyMustNotReferenceIsolatedDependencies()
        {
            var cmdletAssembly = typeof(ModuleInitializer).Assembly;

            var leaked = cmdletAssembly.GetReferencedAssemblies()
                .Select(a => a.Name)
                .Where(name => IsolatedAssemblyPrefixes.Any(prefix => name.StartsWith(prefix, StringComparison.OrdinalIgnoreCase)))
                .ToArray();

            Assert.True(leaked.Length == 0,
                $"Microsoft.Graph.Authentication.dll references isolated assemblies: {string.Join(", ", leaked)}. " +
                "Move the offending code into Microsoft.Graph.Authentication.Core.");
        }

        [Fact]
        public void CmdletAssemblyOnlyReferencesAllowedAssemblies()
        {
            var cmdletAssembly = typeof(ModuleInitializer).Assembly;

            var allowed = new[]
            {
                "netstandard",
                "mscorlib",
                "System",
                "System.Core",
                "System.Management.Automation",
                "Microsoft.Win32.Registry",
                "Newtonsoft.Json",
                "Microsoft.Graph.Authentication.Core",
            };

            var unexpected = cmdletAssembly.GetReferencedAssemblies()
                .Select(a => a.Name)
                .Where(name => !allowed.Contains(name, StringComparer.OrdinalIgnoreCase) && !name.StartsWith("System.", StringComparison.OrdinalIgnoreCase))
                .ToArray();

            Assert.True(unexpected.Length == 0,
                $"Microsoft.Graph.Authentication.dll has unexpected references: {string.Join(", ", unexpected)}.");
        }
    }
}
