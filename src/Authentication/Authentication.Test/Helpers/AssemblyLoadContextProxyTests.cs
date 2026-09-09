// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using Microsoft.Graph.PowerShell.Authentication;
using System;
using System.Reflection;
using System.Reflection.Emit;
using Xunit;

namespace Microsoft.Graph.Authentication.Test.Helpers
{
    public class AssemblyLoadContextProxyTests
    {
        [Fact]
        public void GraphAssemblyCheckShouldRejectExchangeAssembly()
        {
            Assembly graphAssembly = CreateDynamicAssembly($"Microsoft.Graph.Test.{Guid.NewGuid()}");
            Assembly exchangeAssembly = CreateDynamicAssembly($"Microsoft.Exchange.Test.{Guid.NewGuid()}");

            Assert.True(AssemblyResolutionHelpers.IsGraphAssembly(graphAssembly));
            Assert.False(AssemblyResolutionHelpers.IsGraphAssembly(exchangeAssembly));
        }

        [Fact]
        public void ResolvingHandlerShouldBeAttachedToCustomLoadContext()
        {
            AssemblyLoadContextProxy proxy = AssemblyLoadContextProxy.CreateLoadContext($"msgraph-test-{Guid.NewGuid()}");
            if (proxy == null)
                return;

            var requestedAssembly = new AssemblyName($"Missing.Graph.Dependency.{Guid.NewGuid()}");
            AssemblyName resolvedAssembly = null;

            proxy.AddResolvingHandler((context, assemblyName) =>
            {
                resolvedAssembly = assemblyName;
                return null;
            });

            try
            {
                Action loadMissingAssembly = () => proxy.LoadFromAssemblyName(requestedAssembly);
                Assert.Throws<TargetInvocationException>(loadMissingAssembly);
                Assert.Equal(requestedAssembly.Name, resolvedAssembly?.Name);
            }
            finally
            {
                proxy.RemoveResolvingHandler();
            }
        }

        private static Assembly CreateDynamicAssembly(string name)
        {
            return AssemblyBuilder.DefineDynamicAssembly(new AssemblyName(name), AssemblyBuilderAccess.Run);
        }
    }
}
