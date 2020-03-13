// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------
namespace Microsoft.Graph.PowerShell.Authentication.Models
{
    public enum AuthenticationType
    {
        Delegated,
        AppOnly
    }

    public class AuthConfig
    {
        private const string PowerShellClientId = "14d82eec-204b-4c2f-b7e8-296a70dab67e";
        public string ClientId { get; set; }
        public string TenantId { get; set; }
        public string CertificateThumbprint { get; set; }
        public string[] Scopes { get; set; }
        public AuthenticationType AuthType { get; set; }
        public string CertificateName { get; set; }
        public string Account { get; set; }
        public string AppName { get; set; }

        public AuthConfig()
        {
            ClientId = PowerShellClientId;
        }
    }
}
