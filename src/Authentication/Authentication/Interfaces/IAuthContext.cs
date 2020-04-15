// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.PowerShell.Authentication
{
    public enum AuthenticationType
    {
        Delegated,
        AppOnly
    }
    public interface IAuthContext
    {
        string ClientId { get; set; }
        string TenantId { get; set; }
        string CertificateThumbprint { get; set; }
        string[] Scopes { get; set; }
        AuthenticationType AuthType { get; set; }
        string CertificateName { get; set; }
        string Account { get; set; }
        string AppName { get; set; }
    }
}
