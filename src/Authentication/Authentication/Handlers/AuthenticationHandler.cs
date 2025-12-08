// ------------------------------------------------------------------------------
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
        private TokenRequestContext popTokenRequestContext;
        private string cachedNonce;

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

                // Extract nonce from API responses for future PoP requests
                if (GraphSession.Instance.GraphOption.EnableATPoPForMSGraph && IsApiRequest(httpRequestMessage.RequestUri))
                {
                    try
                    {
                        var wwwAuthParams = WwwAuthenticateParameters.CreateFromAuthenticationHeaders(response.Headers, PopAuthenticationScheme);
                        if (wwwAuthParams?.Nonce != null && !string.IsNullOrEmpty(wwwAuthParams.Nonce))
                        {
                            cachedNonce = wwwAuthParams.Nonce;
                        }
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine($"AuthenticationHandler: Failed to extract PoP nonce: {ex.Message}");
                        // Don't throw - nonce extraction failure shouldn't break the response
                    }
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
                // Determine if this is an API request that should use PoP (when enabled)
                // vs an authentication request that should always use Bearer
                bool isApiRequest = IsApiRequest(httpRequestMessage.RequestUri);
                bool shouldUsePoP = GraphSession.Instance.GraphOption.EnableATPoPForMSGraph && isApiRequest;
                
                // Debug logging for flow routing
                if (GraphSession.Instance.GraphOption.EnableATPoPForMSGraph)
                {
                    var requestType = isApiRequest ? "API" : "Auth";
                    var tokenType = shouldUsePoP ? "PoP" : "Bearer";
                    System.Diagnostics.Debug.WriteLine($"AuthenticationHandler: {requestType} request to {httpRequestMessage.RequestUri?.Host} using {tokenType} token");
                }
                
                if (shouldUsePoP)
                {
                    // API Request with PoP enabled - use PoP tokens ONLY
                    try
                    {
                        // Create proper TokenRequestContext for PoP
                        // Note: cachedNonce may be null for initial requests - this is expected
                        popTokenRequestContext = new TokenRequestContext(
                            scopes: GraphSession.Instance.AuthContext.Scopes,
                            parentRequestId: null,
                            claims: additionalAuthenticationContext?.ContainsKey(ClaimsKey) == true ? additionalAuthenticationContext[ClaimsKey]?.ToString() : null,
                            tenantId: null,
                            isCaeEnabled: false,
                            isProofOfPossessionEnabled: true,
                            proofOfPossessionNonce: cachedNonce // May be null for initial requests
                        );
                        
                        // Get TokenCredential from existing AuthenticationProvider
                        var tokenCredential = await AuthenticationHelpers.GetTokenCredentialAsync(
                            GraphSession.Instance.AuthContext, cancellationToken).ConfigureAwait(false);
                        
                        var accessToken = await tokenCredential.GetTokenAsync(popTokenRequestContext, cancellationToken).ConfigureAwait(false);
                        httpRequestMessage.Headers.Authorization = new AuthenticationHeaderValue(PopAuthenticationScheme, accessToken.Token);
                    }
                    catch (Exception ex) when (!(ex is OperationCanceledException))
                    {
                        // Re-throw with context for PoP-specific failures
                        throw new AuthenticationException($"Failed to acquire PoP token for {httpRequestMessage.RequestUri}: {ex.Message}", ex);
                    }
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

        /// <summary>
        /// Determines if the request is an API request that should use PoP when enabled,
        /// vs an authentication/token request that should always use Bearer tokens.
        /// This method implements the core routing logic for AT-PoP:
        /// - Graph API endpoints → PoP tokens (when enabled) 
        /// - Authentication endpoints → Bearer tokens (always)
        /// - Unknown endpoints → Bearer tokens (safe default)
        /// </summary>
        /// <param name="requestUri">The request URI to evaluate</param>
        /// <returns>True if this is an API request, false if it's an authentication request</returns>
        private static bool IsApiRequest(Uri requestUri)
        {
            if (requestUri == null) return false;
            
            var host = requestUri.Host?.ToLowerInvariant();
            var path = requestUri.AbsolutePath?.ToLowerInvariant();
            
            // Microsoft Graph API endpoints that should use PoP
            if (host?.Contains("graph.microsoft.com") == true ||
                host?.Contains("graph.microsoft.us") == true ||
                host?.Contains("microsoftgraph.chinacloudapi.cn") == true ||
                host?.Contains("graph.microsoft.de") == true)
            {
                // Exclude authentication/token endpoints - these should always use Bearer
                if (path?.Contains("/oauth2/") == true ||
                    path?.Contains("/token") == true ||
                    path?.Contains("/authorize") == true ||
                    path?.Contains("/devicecode") == true)
                {
                    return false; // Authentication request
                }
                return true; // API request
            }
            
            // Azure AD/authentication endpoints - never use PoP
            if (host?.Contains("login.microsoftonline.com") == true ||
                host?.Contains("login.microsoft.com") == true ||
                host?.Contains("login.chinacloudapi.cn") == true ||
                host?.Contains("login.microsoftonline.de") == true ||
                host?.Contains("login.microsoftonline.us") == true)
            {
                return false; // Authentication request
            }
            
            return false; // Default to authentication request for unknown endpoints
        }
    }
}