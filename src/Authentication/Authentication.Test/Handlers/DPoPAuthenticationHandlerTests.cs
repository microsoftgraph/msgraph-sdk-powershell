#if ONEAUTH_PREVIEW && NET8_0_OR_GREATER
using Azure.Core;
using Microsoft.Graph.PowerShell.Authentication.Core.Http;
using Microsoft.Kiota.Http.HttpClientLibrary.Middleware;
using Microsoft.Kiota.Http.HttpClientLibrary.Middleware.Options;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Microsoft.Graph.Authentication.Test.Handlers
{
    public class DPoPAuthenticationHandlerTests
    {
        private static readonly Uri s_uri = new Uri("https://graph.microsoft.com/v1.0/me");

        [Fact]
        public async Task SignsEveryThrottlingRetryWithTheProofProvidersToken()
        {
            var proofs = new RecordingProofProvider { AccessToken = "renewed-token" };
            var credential = new RecordingCredential(CreateToken(proofs));
            var transport = new RecordingTransport((_, attempt) =>
                new HttpResponseMessage(attempt == 1 ? HttpStatusCode.ServiceUnavailable : HttpStatusCode.OK));
            using var client = CreateClient(credential, transport, retry: true);

            using var response = await client.GetAsync(s_uri);

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.Equal(new[] { "proof-1", "proof-2" }, transport.Proofs);
            Assert.All(transport.Authorization, header => Assert.Equal("DPoP renewed-token", header));
            Assert.All(proofs.Requests, request =>
            {
                Assert.Equal("GET", request.Method);
                Assert.Equal(s_uri, request.Uri);
                Assert.Equal("original-token", request.AccessToken);
            });
        }

        [Fact]
        public async Task HandlesNonceAndClaimsChallengeAndRemembersNonce()
        {
            const string claims = "{\"access_token\":{\"xms_cc\":{\"values\":[\"cp1\"]}}}";
            var proofs = new RecordingProofProvider();
            var credential = new RecordingCredential(CreateToken(proofs));
            var transport = new RecordingTransport((_, attempt) =>
            {
                var response = new HttpResponseMessage(attempt == 1 ? HttpStatusCode.Unauthorized : HttpStatusCode.OK);
                if (attempt == 1)
                {
                    response.Headers.Add("DPoP-Nonce", "resource-nonce");
                    response.Headers.WwwAuthenticate.Add(new AuthenticationHeaderValue(
                        "DPoP", $"claims=\"{Convert.ToBase64String(Encoding.UTF8.GetBytes(claims))}\""));
                }
                return response;
            });
            using var client = CreateClient(credential, transport);

            using var response = await client.GetAsync(s_uri);
            using var secondResponse = await client.GetAsync(s_uri);

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.Equal(3, transport.Proofs.Count);
            Assert.Null(proofs.Requests[0].Nonce);
            Assert.Equal("resource-nonce", proofs.Requests[1].Nonce);
            Assert.Equal("resource-nonce", proofs.Requests[2].Nonce);
            Assert.Equal(claims, credential.Requests[1].Claims);
            Assert.True(credential.Requests[1].IsCaeEnabled);
        }

        [Theory]
        [InlineData("Bearer", true, "proof")]
        [InlineData("DPoP", false, "proof")]
        [InlineData("DPoP", true, "")]
        public async Task FailsClosedWithoutADPoPTokenAndProof(string tokenType, bool hasProvider, string proof)
        {
            var provider = hasProvider ? new RecordingProofProvider { Proof = proof } : null;
            var credential = new RecordingCredential(CreateToken(provider, tokenType));
            var transport = new RecordingTransport((_, __) => new HttpResponseMessage(HttpStatusCode.OK));
            using var client = CreateClient(credential, transport);

            await Assert.ThrowsAsync<InvalidOperationException>(() => client.GetAsync(s_uri));

            Assert.Empty(transport.Proofs);
        }

        [Theory]
        [InlineData("http://graph.microsoft.com/v1.0/me")]
        [InlineData("https://untrusted.example/v1.0/me")]
        public async Task RejectsUntrustedOrInsecureDestinationsBeforeAcquiringAToken(string uri)
        {
            var credential = new RecordingCredential(CreateToken(new RecordingProofProvider()));
            var transport = new RecordingTransport((_, __) => new HttpResponseMessage(HttpStatusCode.OK));
            using var client = CreateClient(credential, transport);

            await Assert.ThrowsAsync<InvalidOperationException>(() => client.GetAsync(uri));

            Assert.Empty(credential.Requests);
            Assert.Empty(transport.Proofs);
        }

        [Fact]
        public async Task DoesNotReplayStreamingBodiesOrLoopOnNonceChallenges()
        {
            var proofs = new RecordingProofProvider();
            var credential = new RecordingCredential(CreateToken(proofs));
            var transport = new RecordingTransport((_, __) =>
            {
                var response = new HttpResponseMessage(HttpStatusCode.Unauthorized);
                response.Headers.Add("DPoP-Nonce", "nonce");
                return response;
            });
            using var client = CreateClient(credential, transport);
            using var body = new StreamContent(new MemoryStream(new byte[] { 1, 2, 3 }));

            using var streamedResponse = await client.PostAsync(s_uri, body);
            Assert.Equal(HttpStatusCode.Unauthorized, streamedResponse.StatusCode);
            Assert.Single(transport.Proofs);

            using var bufferedResponse = await client.PostAsync(s_uri, new StringContent("body"));
            Assert.Equal(HttpStatusCode.Unauthorized, bufferedResponse.StatusCode);
            Assert.Equal(3, transport.Proofs.Count);
            Assert.Equal("POST", proofs.Requests[2].Method);
        }

        private static AccessToken CreateToken(TokenProofProvider proofs, string tokenType = "DPoP")
        {
            return new AccessToken("original-token", DateTimeOffset.UtcNow.AddMinutes(10), null, tokenType, null, proofs);
        }

        private static HttpClient CreateClient(RecordingCredential credential, HttpMessageHandler transport, bool retry = false)
        {
            var handler = new DPoPAuthenticationHandler(
                credential, new[] { "https://graph.microsoft.com/.default" }, uri => uri.Host == s_uri.Host)
            {
                InnerHandler = transport
            };
            if (!retry)
                return new HttpClient(handler);

            return new HttpClient(new RetryHandler(new RetryHandlerOption { MaxRetry = 1, Delay = 0 })
            {
                InnerHandler = handler
            });
        }

        private sealed class RecordingCredential : TokenCredential
        {
            private readonly AccessToken _token;
            internal List<TokenRequestContext> Requests { get; } = new List<TokenRequestContext>();

            internal RecordingCredential(AccessToken token) => _token = token;

            public override AccessToken GetToken(TokenRequestContext requestContext, CancellationToken cancellationToken)
            {
                cancellationToken.ThrowIfCancellationRequested();
                Requests.Add(requestContext);
                return _token;
            }

            public override ValueTask<AccessToken> GetTokenAsync(TokenRequestContext requestContext, CancellationToken cancellationToken)
                => new ValueTask<AccessToken>(GetToken(requestContext, cancellationToken));
        }

        private sealed class RecordingProofProvider : TokenProofProvider
        {
            internal List<TokenProofRequest> Requests { get; } = new List<TokenProofRequest>();
            internal string AccessToken { get; set; }
            internal string Proof { get; set; }
            public override string HeaderName => "DPoP";

            public override TokenProof CreateProof(TokenProofRequest request, CancellationToken cancellationToken)
            {
                cancellationToken.ThrowIfCancellationRequested();
                Requests.Add(request);
                return new TokenProof(Proof ?? $"proof-{Requests.Count}", AccessToken);
            }

            public override ValueTask<TokenProof> CreateProofAsync(TokenProofRequest request, CancellationToken cancellationToken)
                => new ValueTask<TokenProof>(CreateProof(request, cancellationToken));
        }

        private sealed class RecordingTransport : HttpMessageHandler
        {
            private readonly Func<HttpRequestMessage, int, HttpResponseMessage> _respond;
            internal List<string> Proofs { get; } = new List<string>();
            internal List<string> Authorization { get; } = new List<string>();

            internal RecordingTransport(Func<HttpRequestMessage, int, HttpResponseMessage> respond) => _respond = respond;

            protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                Proofs.Add(request.Headers.GetValues("DPoP").Single());
                Authorization.Add(request.Headers.Authorization.ToString());
                var response = _respond(request, Proofs.Count);
                response.RequestMessage = request;
                return Task.FromResult(response);
            }
        }
    }
}
#endif
