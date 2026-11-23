#if ONEAUTH_PREVIEW
using Azure.Core;
using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Graph.PowerShell.Authentication.Core.Http
{
    internal sealed class DPoPAuthenticationHandler : DelegatingHandler
    {
        private static readonly Regex s_claims = new Regex(
            "\\bclaims=\"([^\"]+)\"", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(100));
        private readonly TokenCredential _credential;
        private readonly string[] _scopes;
        private readonly Func<Uri, bool> _isAllowedHost;
        private readonly ConcurrentDictionary<string, string> _nonces = new ConcurrentDictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        internal DPoPAuthenticationHandler(TokenCredential credential, string[] scopes, Func<Uri, bool> isAllowedHost)
        {
            _credential = credential ?? throw new ArgumentNullException(nameof(credential));
            _scopes = scopes ?? throw new ArgumentNullException(nameof(scopes));
            _isAllowedHost = isAllowedHost ?? throw new ArgumentNullException(nameof(isAllowedHost));
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (request.RequestUri == null || request.RequestUri.Scheme != Uri.UriSchemeHttps || !_isAllowedHost(request.RequestUri))
                throw new InvalidOperationException("DPoP requests require HTTPS and a trusted Microsoft Graph host.");

            _nonces.TryGetValue(request.RequestUri.Authority, out string nonce);
            string claims = null;
            for (int attempt = 0; ; attempt++)
            {
                var token = await _credential.GetTokenAsync(
                    new TokenRequestContext(_scopes, claims: claims, isCaeEnabled: true), cancellationToken).ConfigureAwait(false);
                if (!string.Equals(token.TokenType, "DPoP", StringComparison.OrdinalIgnoreCase) || token.ProofProvider == null)
                    throw new InvalidOperationException("The OneAuth preview requires a DPoP token and proof provider; the request was not sent.");

                var proof = await token.ProofProvider.CreateProofAsync(
                    new TokenProofRequest(request.Method.Method, request.RequestUri, token.Token, nonce), cancellationToken).ConfigureAwait(false);
                if (string.IsNullOrWhiteSpace(proof.Value))
                    throw new InvalidOperationException("The DPoP proof is empty; the request was not sent.");

                var accessToken = proof.AccessToken ?? token.Token;
                if (string.IsNullOrWhiteSpace(accessToken))
                    throw new InvalidOperationException("The DPoP access token is empty; the request was not sent.");
                request.Headers.Authorization = new AuthenticationHeaderValue("DPoP", accessToken);
                request.Headers.Remove("DPoP");
                request.Headers.Add("DPoP", proof.Value);
                var response = await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
                var responseNonce = response.Headers.TryGetValues("DPoP-Nonce", out var nonces) ? nonces.FirstOrDefault() : null;
                if (!string.IsNullOrEmpty(responseNonce))
                {
                    nonce = responseNonce;
                    _nonces[request.RequestUri.Authority] = nonce;
                }

                // Replays from retry middleware enter this handler again and get a new proof.
                // Handle a single nonce/CAE challenge here without replaying an unbuffered body.
                if (attempt != 0 || response.StatusCode != HttpStatusCode.Unauthorized ||
                    (request.Content != null && !(request.Content is ByteArrayContent)))
                    return response;

                var challenge = response.Headers.WwwAuthenticate.FirstOrDefault(
                    header => string.Equals(header.Scheme, "DPoP", StringComparison.OrdinalIgnoreCase));
                var claimsMatch = s_claims.Match(challenge?.Parameter ?? string.Empty);
                if (claimsMatch.Success)
                    claims = Encoding.UTF8.GetString(Convert.FromBase64String(claimsMatch.Groups[1].Value));
                if (string.IsNullOrEmpty(responseNonce) && claims == null)
                    return response;

                response.Dispose();
            }
        }
    }
}
#endif
