// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using Microsoft.Graph.PowerShell.Authentication.Models;
using System.Collections.Generic;

namespace Microsoft.Graph.PowerShell.Authentication
{
    internal static class GraphEnvironmentConstants
    {
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
            /// The graph national cloud for China.
            /// </summary>
            public const string China = "China";

            /// <summary>
            /// The French sovereign cloud operated by Bleu.
            /// </summary>
            public const string BleuCloud = "BleuCloud";

            /// <summary>
            /// The German sovereign cloud operated by Delos.
            /// </summary>
            public const string DelosCloud = "DelosCloud";

            /// <summary>
            /// Sovereign Government Cloud.
            /// </summary>
            public const string GovSGCloud = "GovSGCloud";
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
            // China national cloud endpoints.
            {
                EnvironmentName.China, new GraphEnvironment
                {
                    Name = EnvironmentName.China,
                    Type = EnvironmentType.BuiltIn,
                    AzureADEndpoint = "https://login.chinacloudapi.cn",
                    GraphEndpoint = "https://microsoftgraph.chinacloudapi.cn"
                }
            },
            // French sovereign cloud endpoints.
            {
                EnvironmentName.BleuCloud, new GraphEnvironment
                {
                    Name = EnvironmentName.BleuCloud,
                    Type = EnvironmentType.BuiltIn,
                    AzureADEndpoint = "https://login.sovcloud-identity.fr",
                    GraphEndpoint = "https://graph.svc.sovcloud.fr"
                }
            },
            // German sovereign cloud endpoints.
            {
                EnvironmentName.DelosCloud, new GraphEnvironment
                {
                    Name = EnvironmentName.DelosCloud,
                    Type = EnvironmentType.BuiltIn,
                    AzureADEndpoint = "https://login.sovcloud-identity.de",
                    GraphEndpoint = "https://graph.svc.sovcloud.de"
                }
            },
            // Sovereign Government Cloud endpoints.
            {
                EnvironmentName.GovSGCloud, new GraphEnvironment
                {
                    Name = EnvironmentName.GovSGCloud,
                    Type = EnvironmentType.BuiltIn,
                    AzureADEndpoint = "https://login.sovcloud-identity.sg",
                    GraphEndpoint = "https://graph.svc.sovcloud.sg"
                }
            }
        };
    }
}
