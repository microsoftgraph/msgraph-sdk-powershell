// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.PowerShell.Authentication
{
    using System.Collections.Generic;
    internal static class GraphEnvironmentConstants
    {
        /// <summary>
        /// The default AD Tenant value
        /// </summary>
        public const string CommonAdTenant = "common";

        /// <summary>
        /// Collection of predefined environment/cloud names for Microsoft Graph.
        /// </summary>
        public static class EnvironmentName
        {
            /// <summary>
            /// The graph national cloud.
            /// </summary>
            public const string Global = "Global";

            /// <summary>
            /// The graph national cloud US Government.
            /// </summary>
            public const string USGov = "USGov";

            /// <summary>
            /// The graph national cloud for US Government DoD.
            /// </summary>
            public const string USGovDoD = "USGovDoD";

            /// <summary>
            /// The graph national cloud for Germany.
            /// </summary>
            public const string Germany = "Germany";

            /// <summary>
            /// The graph national cloud for China.
            /// </summary>
            public const string China = "China";
        }

        /// <summary>
        /// Environment types.
        /// </summary>
        public static class EnvironmentType
        {
            public const string BuiltIn = "Built-in";
            public const string UserDefined = "User-defined";
        }

        /// <summary>
        /// Known endpoint values for Microsoft Graph national clouds.
        /// </summary>
        internal static readonly IDictionary<string, GraphEnvironment> BuiltInEnvironments = new Dictionary<string, GraphEnvironment>
        {
            // Global national cloud endpoints.
            {
                EnvironmentName.Global, new GraphEnvironment
                {
                    Name = EnvironmentName.Global,
                    Type = EnvironmentType.BuiltIn,
                    AzureADEndpoint = "https://login.microsoftonline.com",
                    GraphEndpoint = "https://graph.microsoft.com"
                }
            },
            // US Gov national cloud endpoints.
            {
                EnvironmentName.USGov, new GraphEnvironment
                {
                    Name = EnvironmentName.USGov,
                    Type = EnvironmentType.BuiltIn,
                    AzureADEndpoint = "https://login.microsoftonline.us",
                    GraphEndpoint = "https://graph.microsoft.us"
                }
            },
            // US Gov DoD national cloud endpoints.
            {
                EnvironmentName.USGovDoD, new GraphEnvironment
                {
                    Name = EnvironmentName.USGovDoD,
                    Type = EnvironmentType.BuiltIn,
                    AzureADEndpoint = "https://login.microsoftonline.us",
                    GraphEndpoint = "https://dod-graph.microsoft.us"
                }
            },
            // Germany national cloud endpoints.
            {
                EnvironmentName.Germany, new GraphEnvironment
                {
                    Name = EnvironmentName.Germany,
                    Type = EnvironmentType.BuiltIn,
                    AzureADEndpoint = "https://login.microsoftonline.de",
                    GraphEndpoint = "https://graph.microsoft.de"
                }
            },
            // China national cloud endpoints.
            {
                EnvironmentName.China, new GraphEnvironment
                {
                    Name = EnvironmentName.China,
                    Type = EnvironmentType.BuiltIn,
                    AzureADEndpoint = "https://login.chinacloudapi.cn",
                    GraphEndpoint = "https://microsoftgraph.chinacloudapi.cn"
                }
            }
        };
    }
}
