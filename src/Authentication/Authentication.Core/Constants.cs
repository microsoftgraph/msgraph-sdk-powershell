﻿// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System;
using System.IO;

namespace Microsoft.Graph.PowerShell.Authentication.Core
{
    public static class Constants
    {
        public const int MaxAuthenticationTimeOutInSeconds = 120;
        public const string DefaultTenant = "common";
        public const string DefaultMsiIdPrefix = "MSI@";
        public const int DefaultMsiPort = 50342;
        public static readonly string GraphDirectoryPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.UserProfile), ".mg");
        internal const int TokenExpirationBufferInMinutes = 5;
        internal const string DefaultAzureADEndpoint = "https://login.microsoftonline.com";
        internal const string DefaultGraphEndpoint = "https://graph.microsoft.com";
        internal const string DefaultScopeUrl = "https://graph.microsoft.com/.default";
        internal const string CacheName = "mg.msal.cache";
        internal const string AuthRecordName = "mg.authrecord.json";
        internal const int MaxAuthRetry = 2;
        internal static readonly string AuthRecordPath = Path.Combine(GraphDirectoryPath, AuthRecordName);
    }

    internal static class EnvironmentVariables
    {
        internal static string ClientId => Environment.GetEnvironmentVariable("AZURE_CLIENT_ID");
        internal static string TenantId => Environment.GetEnvironmentVariable("AZURE_TENANT_ID");
        internal static string Username => Environment.GetEnvironmentVariable("AZURE_USERNAME");
        internal static string Password => Environment.GetEnvironmentVariable("AZURE_PASSWORD");
        internal static string ClientSecret => Environment.GetEnvironmentVariable("AZURE_CLIENT_SECRET");
        internal static string ClientCertificatePath => Environment.GetEnvironmentVariable("AZURE_CLIENT_CERTIFICATE_PATH");
        internal static string ClientCertificatePassword => Environment.GetEnvironmentVariable("AZURE_CLIENT_CERTIFICATE_PASSWORD");
        internal static string ClientSendCertificateChain => Environment.GetEnvironmentVariable("AZURE_CLIENT_SEND_CERTIFICATE_CHAIN");
    }
}
