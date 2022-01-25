// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.PowerShell.Authentication
{
    using System.IO;
    public static class Constants
    {
        public const double ClientTimeout = 300;
        public const int MaxContentLength = 10240;
        public const string SDKHeaderValue = "graph-powershell/{0}.{1}.{2}";
        internal const string UserParameterSet = "UserParameterSet";
        internal const string AppParameterSet = "AppParameterSet";
        internal const string AccessTokenParameterSet = "AccessTokenParameterSet";
        internal static readonly string SettingFilePath = Path.Combine(Core.Constants.GraphDirectoryPath, "GraphContext.json");
        internal const string ProfileDescription = "A snapshot of the Microsoft Graph {0} API for {1} cloud.";
    }
}
