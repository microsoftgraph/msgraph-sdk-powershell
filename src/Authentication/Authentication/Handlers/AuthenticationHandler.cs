﻿// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------


using Azure.Core;
using Microsoft.Graph.Authentication;
using Microsoft.Graph.PowerShell.Authentication.Core.Utilities;
using Microsoft.Graph.PowerShell.Authentication.Extensions;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Graph.PowerShell.Authentication.Handlers
{
    internal class AuthenticationHandler : DelegatingHandler
    {
        private const string ClaimsKey = "claims";
        private const string BearerAuthenticationScheme = "Bearer";
        private const string PopAuthenticationScheme = "Pop";
        private int MaxRetry { get; set; } = 1;

        public AzureIdentityAccessTokenProvider AuthenticationProvider { get; set; }

        public AuthenticationHandler(AzureIdentityAccessTokenProvider authenticationProvider)
        {
            AuthenticationProvider = authenticationProvider;
        }

        public AuthenticationHandler(AzureIdentityAccessTokenProvider authenticationProvider, HttpMessageHandler innerHandler)
            : this(authenticationProvider)
        {
            InnerHandler = innerHandler;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage httpRequestMessage, CancellationToken cancellationToken)
        {
            // Authenticate request using AuthenticationProvider
            if (AuthenticationProvider != null)
            {
                await AuthenticateRequestAsync(httpRequestMessage, cancellationToken: cancellationToken).ConfigureAwait(false);

                HttpResponseMessage response = await base.SendAsync(httpRequestMessage, cancellationToken).ConfigureAwait(false);

                // Continuous nonce extraction on each request
                if (GraphSession.Instance.GraphOption.EnableATPoPForMSGraph)
                {
                    GraphSession.Instance.GraphRequestPopContext.PopTokenContext = new PopTokenRequestContext(GraphSession.Instance.AuthContext.Scopes, isProofOfPossessionEnabled: true, proofOfPossessionNonce: WwwAuthenticateParameters.CreateFromAuthenticationHeaders(response.Headers, PopAuthenticationScheme).Nonce, request: GraphSession.Instance.GraphRequestPopContext.Request);
                }

                // Check if response is a 401 & is not a streamed body (is buffered)
                if (response.StatusCode == HttpStatusCode.Unauthorized && httpRequestMessage.IsBuffered())
                {
                    // re-issue the request to get a new access token
                    return await SendRetryAsync(response, cancellationToken);
                }
                return response;
            }
            else
            {
                return await base.SendAsync(httpRequestMessage, cancellationToken).ConfigureAwait(false);
            }
        }

        private async Task AuthenticateRequestAsync(HttpRequestMessage httpRequestMessage, Dictionary<string, object> additionalAuthenticationContext = default, CancellationToken cancellationToken = default)
        {
            if (AuthenticationProvider != null)
            {
                if (GraphSession.Instance.GraphOption.EnableATPoPForMSGraph)
                {
                    GraphSession.Instance.GraphRequestPopContext.Request.Method = RequestMethod.Parse(httpRequestMessage.Method.Method.ToUpper());
                    GraphSession.Instance.GraphRequestPopContext.Request.Uri.Reset(httpRequestMessage.RequestUri);
                    foreach (var header in httpRequestMessage.Headers)
                    {
                        GraphSession.Instance.GraphRequestPopContext.Request.Headers.Add(header.Key, header.Value.First());
                    }
                    
                    var accessToken = await GraphSession.Instance.GraphRequestPopContext.PopInteractiveBrowserCredential.GetTokenAsync(GraphSession.Instance.GraphRequestPopContext.PopTokenContext, cancellationToken).ConfigureAwait(false);
                    httpRequestMessage.Headers.Authorization = new AuthenticationHeaderValue(PopAuthenticationScheme, accessToken.Token);
                }
                else
                {
                    var accessToken = await AuthenticationProvider.GetAuthorizationTokenAsync(httpRequestMessage.RequestUri, additionalAuthenticationContext, cancellationToken: cancellationToken).ConfigureAwait(false);
                    if (!string.IsNullOrEmpty(accessToken))
                        httpRequestMessage.Headers.Authorization = new AuthenticationHeaderValue(BearerAuthenticationScheme, accessToken);
                }
            }
        }

        private async Task<HttpResponseMessage> SendRetryAsync(HttpResponseMessage httpResponseMessage, CancellationToken cancellationToken)
        {
            int retryAttempt = 0;
            while (retryAttempt < MaxRetry)
            {
                // general clone request with internal CloneAsync (see CloneAsync for details) extension method 
                var newRequest = await httpResponseMessage.RequestMessage.CloneAsync();

                // extract the www-authenticate header and add claims to the request context
                var additionalRequestInfo = new Dictionary<string, object>();
                if (httpResponseMessage.Headers.WwwAuthenticate.Any())
                {
                    var wwwAuthenticateHeader = httpResponseMessage.Headers.WwwAuthenticate.FirstOrDefault();
                    var claims = GetClaimsFromHeader(wwwAuthenticateHeader);
                    additionalRequestInfo.Add(ClaimsKey, claims);
                }
                await DrainAsync(httpResponseMessage).ConfigureAwait(false);

                // Authenticate request using auth provider
                await AuthenticateRequestAsync(newRequest, additionalRequestInfo, cancellationToken).ConfigureAwait(false);
                httpResponseMessage = await base.SendAsync(newRequest, cancellationToken);

                retryAttempt++;

                if (httpResponseMessage.StatusCode != HttpStatusCode.Unauthorized || !newRequest.IsBuffered())
                {
                    // Re-issue the request to get a new access token
                    return httpResponseMessage;
                }
            }
            return httpResponseMessage;
        }

        private static readonly Regex caeValueRegex = new Regex("\"([^\"]*)\"", RegexOptions.Compiled, TimeSpan.FromMilliseconds(100));
        private static string GetClaimsFromHeader(AuthenticationHeaderValue wwwAuthenticateHeader)
        {
            var rawResponseClaims = wwwAuthenticateHeader.Parameter?.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .FirstOrDefault(x => x.StartsWith(ClaimsKey, StringComparison.OrdinalIgnoreCase));
            if (!string.IsNullOrEmpty(rawResponseClaims) &&
                caeValueRegex.Match(rawResponseClaims) is Match claimsMatch &&
                claimsMatch.Groups.Count > 1)
            {
                return claimsMatch.Groups[1].Value;
            }
            return null;
        }

        private static async Task DrainAsync(HttpResponseMessage response)
        {
            if (response.Content != null)
            {
                using (var discard = await response.Content.ReadAsStreamAsync())
                {
                    response.Content.Dispose();
                }
            }
            response.Dispose();
        }
    }
}