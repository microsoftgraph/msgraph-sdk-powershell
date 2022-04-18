// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using Azure.Core;
using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Graph.PowerShell.Authentication.Core.Utilities
{
    public class UserProvidedTokenCredential : TokenCredential
    {
        public override AccessToken GetToken(TokenRequestContext requestContext, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            var token = Encoding.UTF8.GetString(GraphSession.Instance.InMemoryTokenCache.ReadTokenData());
            var jwtPayload = JwtHelpers.DecodeToObject<Models.JwtPayload>(token);
            var exp = jwtPayload?.Exp == null ? DateTimeOffset.Now.AddMinutes(55) : DateTimeOffset.FromUnixTimeSeconds(jwtPayload.Exp);
            return new AccessToken(token, exp);
        }

        public override ValueTask<AccessToken> GetTokenAsync(TokenRequestContext requestContext, CancellationToken cancellationToken)
        {
            return new ValueTask<AccessToken>(GetToken(requestContext, cancellationToken));
        }
    }
}
