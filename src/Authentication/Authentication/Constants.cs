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
        public const string DotNetSDKHeaderValue = "graph-dotnet";
        public const string PSSDKHeaderValueV1 = "graph-powershell/{0}.{1}.{2}";
        public const string PSSDKHeaderValueBeta = "graph-powershell-beta/{0}.{1}.{2}";
        internal const string UserParameterSet = nameof(UserParameterSet);
        internal const string AppParameterSet = nameof(AppParameterSet);
        internal const string AccessTokenParameterSet = nameof(AccessTokenParameterSet);
        internal const string IdentityParameterSet = nameof(IdentityParameterSet);
        internal static readonly string ContextSettingsPath = Path.Combine(Core.Constants.GraphDirectoryPath, "mg.context.json");

        public static class HelpMessages
        {
            public const string Scopes = "An array of delegated permissions to consent to.";
            public const string ClientId = "The client id of your application.";
            public const string CertificateSubjectName = "The subject distinguished name of a certificate. The Certificate will be retrieved from the current user's certificate store.";
            public const string CertificateThumbprint = "The thumbprint of your certificate. The Certificate will be retrieved from the current user's certificate store.";
            public const string Certificate = "An X.509 certificate supplied during invocation.";
            public const string AccessToken = "Specifies a bearer token for Microsoft Graph service. Access tokens do timeout and you'll have to handle their refresh.";
            public const string TenantId = "The id of the tenant to connect to. You can also use this parameter to specify your sign-in audience. i.e., common, organizations, or consumers. See https://docs.microsoft.com/en-us/azure/active-directory/develop/msal-client-application-configuration#authority.";
            public const string ContextScope = "Determines the scope of authentication context. This accepts `Process` for the current process, or `CurrentUser` for all sessions started by user.";
            public const string Environment = "The name of the national cloud environment to connect to. By default global cloud is used.";
            public const string UseDeviceCode = "Use device code authentication instead of a browser control.";
            public const string ClientTimeout = "Sets the HTTP client timeout in seconds.";
            public const string Identity = "Login using a Managed Service Identity (MSI).";
        }
    }
}
