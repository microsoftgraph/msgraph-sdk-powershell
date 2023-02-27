// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using Azure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Graph.PowerShell.Authentication.Core.Utilities
{
    internal class AzureIdentityAuthProvider : IAuthenticationProvider
    {
        private readonly TokenCredential _credential;
        private readonly IEnumerable<string> _scopes;
        private readonly string _claims;

        /// <summary>
        /// An AuthProvider to handle instances of <see cref="TokenCredential"/> from Azure.Core and Azure.Identity
        /// </summary>
        /// <param name="tokenCredential">The <see cref="TokenCredential"/> to use for authentication</param>
        /// <param name="scopes">Scopes required to access Microsoft Graph. This defaults to https://graph.microsoft.com/.default when none is set.</param>
        /// <param name="claims">Additional claims to be included in the token.</param>
        /// <exception cref="ArgumentException"> When a null <see cref="TokenCredential"/> is passed</exception>
        public AzureIdentityAuthProvider(TokenCredential tokenCredential, IEnumerable<string> scopes = null, string claims = null)
        {
            _credential = tokenCredential ?? throw new ArgumentException(
                              string.Format(ErrorConstants.Message.NullOrEmptyParameter, nameof(tokenCredential)),
                              nameof(tokenCredential));
            _scopes = scopes ?? new List<string> { Constants.DefaultScopeUrl };
            _claims = claims;
        }
        public async Task AuthenticateRequestAsync(HttpRequestMessage request)
        {
            AuthenticationHandlerOption authenticationHandlerOption = request.GetMiddlewareOption<AuthenticationHandlerOption>() ?? new AuthenticationHandlerOption();
            ICaeAuthenticationProviderOption authenticationProviderOption = authenticationHandlerOption.AuthenticationProviderOption as ICaeAuthenticationProviderOption;

            var decodedClaims = authenticationProviderOption?.Claims ?? _claims;

            AccessToken token = await _credential.GetTokenAsync(new TokenRequestContext(_scopes.ToArray(), claims: decodedClaims), CancellationToken.None).ConfigureAwait(false);
            request.Headers.Authorization = new AuthenticationHeaderValue(CoreConstants.Headers.Bearer, token.Token);
        }
    }
}
