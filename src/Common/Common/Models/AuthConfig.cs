// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------
namespace Microsoft.Graph.PowerShell.Common.Models
{
    public enum AuthenticationType
    {
        Delegated,
        AppOnly
    }

    public class AuthConfig
    {
        public string ClientId { get; set; }
        public string TenantId { get; set; }
        public string ClientSecret { get; set; }
        public string Scopes { get; set; }
        public AuthenticationType AuthType { get; set; }
    }
}
