// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.PowerShell.Authentication
{
    using System;
    using System.IO;
    public static class Constants
    {
        public const string GraphAuthConfigId = "GraphAuthConfigId";
        public const string SDKHeaderValue = "Graph-powershell-{0}-{1}.{2}.{3}";
        internal const string UserParameterSet = "UserParameterSet";
        internal const string AppParameterSet = "AppParameterSet";
        internal const int MaxDeviceCodeTimeOut = 120; // 2 mins timeout.
        internal const string UserCacheFileName = "userTokenCache.bin3";
        internal const string AppCacheFileName = "appTokenCache.bin3";
        internal static readonly string TokenCacheDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), ".graph");
    }
}
