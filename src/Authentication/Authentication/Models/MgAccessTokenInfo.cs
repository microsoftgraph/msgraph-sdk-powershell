// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System;
using System.Security;

namespace Microsoft.Graph.PowerShell.Authentication.Models
{
    /// <summary>
    /// Represents an access token returned by <c>Get-MgAccessToken -AsObject</c>, including its
    /// lifetime information.
    /// </summary>
    public class MgAccessTokenInfo
    {
        /// <summary>
        /// The access token, as a <see cref="SecureString"/>.
        /// </summary>
        public SecureString Token { get; set; }

        /// <summary>
        /// The UTC date and time at which the token expires.
        /// </summary>
        public DateTimeOffset ExpiresOn { get; set; }

        /// <summary>
        /// The remaining lifetime of the token.
        /// </summary>
        public TimeSpan ExpiresIn => ExpiresOn - DateTimeOffset.UtcNow;

        /// <summary>
        /// The scopes the token was issued for.
        /// </summary>
        public string[] Scopes { get; set; }
    }
}
