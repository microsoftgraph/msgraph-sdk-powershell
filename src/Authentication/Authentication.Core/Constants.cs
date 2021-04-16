// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.PowerShell.Authentication.Core
{
    using System.IO;
    public static class Constants
    {
        public const int MaxDeviceCodeTimeOut = 120; // 2 mins timeout.
        public static readonly string GraphDirectoryPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.UserProfile), ".graph");
        internal const string TokenCacheServiceName = "com.microsoft.graph.powershell.sdkcache";
        internal const string DefaultProfile = "v1.0";
        internal const int TokenExpirationBufferInMinutes = 5;
        internal const string DefaulAdTenant = "common";
        internal const string DefaultAzureADEndpoint = "https://login.microsoftonline.com";
    }
}
