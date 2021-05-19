// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.PowerShell.Authentication
{
    using System;
    using System.Security.Cryptography.X509Certificates;

    public enum AuthenticationType
    {
        Delegated,
        AppOnly,
        UserProvidedAccessToken
    }

    public enum ContextScope
    {
        Process,
        CurrentUser
    }

    public enum AuthProviderType
    {
        InteractiveAuthenticationProvider,
        DeviceCodeProvider,
        DeviceCodeProviderFallBack,
        ClientCredentialProvider,
        UserProvidedToken
    }

    public interface IOutput
    {
        Action<string> WriteObject { get; set; }
        Action<string> WriteDebug { get; set; }
        Action<Exception, string, int, object> WriteError { get; set; }
        Action<object, string[]> WriteInformation { get; set; }
        Action<string> WriteVerbose { get; set; }
    }

    public interface IAuthContext
    {
        string ClientId { get; set; }
        string TenantId { get; set; }
        string CertificateThumbprint { get; set; }
        string[] Scopes { get; set; }
        AuthenticationType AuthType { get; set; }
        AuthProviderType AuthProviderType { get; set; }
        string CertificateName { get; set; }
        string Account { get; set; }
        string AppName { get; set; }
        ContextScope ContextScope { get; set; }
        X509Certificate2 Certificate { get; set; }
    }
}