// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.PowerShell.Authentication
{
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;

    internal class GraphEnvironment : IGraphEnvironment
    {
        /// <summary>
        /// Predefined Microsoft Graph environments
        /// </summary>
        public static IDictionary<string, GraphEnvironment> GraphEnvironments { get; } = new ConcurrentDictionary<string, GraphEnvironment>(StringComparer.InvariantCultureIgnoreCase);

        static GraphEnvironment()
        {
            InitializeEnvironment();
        }

        /// <summary>
        /// Initializes environments with well known national cloud environments.
        /// </summary>
        public static void InitializeEnvironment()
        {
            GraphEnvironments.Clear();
            foreach (var env in GraphEnvironmentConstants.GraphEnvironmentEndpoints)
            {
                GraphEnvironments.Add(env.Key, env.Value);
            }
        }

        /// <summary>
        /// The name of the environment.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The token audience needed to get access tokens for Microsoft Graph endpoint.
        /// </summary>
        public string AzureADEndpoint { get; set; }

        /// <summary>
        /// The URI of Microsoft Graph endpoint.
        /// </summary>
        public string GraphEndpoint { get; set; }

        /// <summary>
        /// Type of environment.
        /// </summary>
        public string Type { get; set; }
    }
}
