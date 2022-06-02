// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System.IO;

namespace Microsoft.Graph.PowerShell.Authentication.Core
{
    public static class Constants
    {
        public const int MaxAuthenticationTimeOutInSeconds = 120;
        public const string DefaultTenant = "common";
        public static readonly string GraphDirectoryPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.UserProfile), ".mg");
        internal const int TokenExpirationBufferInMinutes = 5;
        internal const string DefaultAzureADEndpoint = "https://login.microsoftonline.com";
        internal static readonly string DefaultGraphEndpoint = "https://graph.microsoft.com";
        internal const string CacheName = "mg.msal.cache";
        internal const string AuthRecordName = "mg.authrecord.json";
        internal const int MaxAuthRetry = 2;
        internal static readonly string AuthRecordPath = Path.Combine(GraphDirectoryPath, AuthRecordName);
    }
}
