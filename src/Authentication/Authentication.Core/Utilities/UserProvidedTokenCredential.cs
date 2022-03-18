// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using Azure.Core;
using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Graph.PowerShell.Authentication.Core.Utilities
{
    public class UserProvidedTokenCredential : TokenCredential
    {
        private readonly NetworkCredential _userProvidedToken;

        public UserProvidedTokenCredential(NetworkCredential userProvidedToken)
        {
            _userProvidedToken = userProvidedToken;
        }

        public override AccessToken GetToken(TokenRequestContext requestContext, CancellationToken cancellationToken)
        {
            // TODO: Inteligently extract expiresOn from provided token.
            return new AccessToken(_userProvidedToken.Password, DateTimeOffset.Now.AddHours(1));
        }

        public override ValueTask<AccessToken> GetTokenAsync(TokenRequestContext requestContext, CancellationToken cancellationToken)
        {
            return new ValueTask<AccessToken>(this.GetToken(requestContext, cancellationToken));
        }
    }
}
