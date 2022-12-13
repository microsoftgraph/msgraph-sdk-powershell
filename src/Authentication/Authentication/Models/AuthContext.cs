// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System;
using System.Security;
using System.Security.Cryptography.X509Certificates;

namespace Microsoft.Graph.PowerShell.Authentication
{
    public class AuthContext : IAuthContext
    {
        private const string PowerShellClientId = "14d82eec-204b-4c2f-b7e8-296a70dab67e";
        public string ClientId { get; set; }
        public string TenantId { get; set; }
        public string[] Scopes { get; set; }
        public AuthenticationType AuthType { get; set; }
        public TokenCredentialType TokenCredentialType { get; set; }
        public string CertificateThumbprint { get; set; }
        public string CertificateSubjectName { get; set; }
        public string Account { get; set; }
        public string AppName { get; set; }
        public ContextScope ContextScope { get; set; }
        public X509Certificate2 Certificate { get; set; }
        public Version PSHostVersion { get; set; }
        public string ManagedIdentityId { get; set; }
        public SecureString ClientSecret { get; set; }

        public AuthContext()
        {
            ClientId = PowerShellClientId;
        }
    }
}