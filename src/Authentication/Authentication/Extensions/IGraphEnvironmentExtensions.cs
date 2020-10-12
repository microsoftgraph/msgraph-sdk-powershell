// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.PowerShell.Authentication.Extensions
{
    using Microsoft.Graph.PowerShell.Authentication.Interfaces;
    using Microsoft.Graph.PowerShell.Authentication.Models;
    using System;

    public static class IGraphEnvironmentExtensions
    {
        /// <summary>
        /// Merges two <see cref="IGraphEnvironment"/> into one.
        /// </summary>
        /// <param name="environment1">The environment to merge into.</param>
        /// <param name="environment2">The environment to merge.</param>
        /// <returns>A merged <see cref="IGraphEnvironment"/>.</returns>
        public static IGraphEnvironment Merge(this IGraphEnvironment environment1, IGraphEnvironment environment2)
        {
            if (environment1 == null || environment2 == null)
            {
                throw new ArgumentNullException(nameof(environment1));
            }
            if (!string.Equals(environment1.Name, environment2.Name, StringComparison.InvariantCultureIgnoreCase))
            {
                throw new ArgumentException("Environment names do not match.");
            }

            GraphEnvironment mergedEnvironment = new GraphEnvironment
            {
                Name = environment1.Name,
                Type = environment1.Type,
                AzureADEndpoint = environment1.AzureADEndpoint ?? environment2.AzureADEndpoint,
                GraphEndpoint = environment1.GraphEndpoint ?? environment2.GraphEndpoint
            };

            return mergedEnvironment;
        }
    }
}
