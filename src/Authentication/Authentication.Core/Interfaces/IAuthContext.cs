// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System;
using System.Security;
using System.Security.Cryptography.X509Certificates;

namespace Microsoft.Graph.PowerShell.Authentication
{
    public enum AuthenticationType
    {
        Delegated,
        AppOnly,
        UserProvidedAccessToken,
        ManagedIdentity,
        EnvironmentVariable
    }

    public enum ContextScope
    {
        Process,
        CurrentUser
    }

    public enum TokenCredentialType
    {
        InteractiveBrowser,
        DeviceCode,
        ClientCertificate,
        UserProvidedAccessToken,
        ManagedIdentity,
        ClientSecret,
        EnvironmentVariable
    }

    public interface IAuthContext
    {
        string ManagedIdentityId { get; set; }
        string ClientId { get; set; }
        string TenantId { get; set; }
        string[] Scopes { get; set; }
        AuthenticationType AuthType { get; set; }
        TokenCredentialType TokenCredentialType { get; set; }
        string AppName { get; set; }
        string Account { get; set; }
        string CertificateThumbprint { get; set; }
        string CertificateSubjectName { get; set; }
        X509Certificate2 Certificate { get; set; }
        ContextScope ContextScope { get; set; }
        Version PSHostVersion { get; set; }
        SecureString ClientSecret { get; set; }
        //SigninUi SigninUi { get; set; }
    }
}