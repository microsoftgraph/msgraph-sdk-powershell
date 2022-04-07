// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System.IO;

namespace Microsoft.Graph.PowerShell.Authentication
{
    public static class Constants
    {
        public const double ClientTimeout = 300;
        public const int MaxContentLength = 10240;
        public const string SDKHeaderValue = "graph-powershell/{0}.{1}.{2}";
        internal const string UserParameterSet = nameof(UserParameterSet);
        internal const string AppParameterSet = nameof(AppParameterSet);
        internal const string AccessTokenParameterSet = nameof(AccessTokenParameterSet);
        internal const string ProfileDescription = "A snapshot of the Microsoft Graph {0} API for {1} cloud.";
        internal static readonly string ContextSettingsPath = Path.Combine(Core.Constants.GraphDirectoryPath, "mg.context.json");
    }
}
