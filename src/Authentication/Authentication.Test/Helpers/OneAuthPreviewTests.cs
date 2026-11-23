#if ONEAUTH_PREVIEW && NET8_0_OR_GREATER
using Azure.Core;
using Azure.Identity;
using Microsoft.Graph.PowerShell.Authentication;
using Microsoft.Graph.PowerShell.Authentication.Core.Http;
using Microsoft.Graph.PowerShell.Authentication.Core.Utilities;
using Microsoft.Graph.PowerShell.Authentication.Models;
using Moq;
using System;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Microsoft.Graph.Authentication.Test.Helpers
{
    public class OneAuthPreviewTests : IDisposable
    {
        private const string RuntimeVariable = "AZURE_IDENTITY_BROKER_ENABLE_ONEAUTH";
        private const string DPoPVariable = "AZURE_IDENTITY_BROKER_ENABLE_ONEAUTH_DPOP";
        private readonly string _previousRuntime = Environment.GetEnvironmentVariable(RuntimeVariable);
        private readonly string _previousDPoP = Environment.GetEnvironmentVariable(DPoPVariable);

        public OneAuthPreviewTests()
        {
            Environment.SetEnvironmentVariable(RuntimeVariable, "false");
            Environment.SetEnvironmentVariable(DPoPVariable, "true");
            GraphSession.Initialize(() => new GraphSession());
            GraphSession.Instance.GraphOption = new GraphOption { DisableWAMForMSGraph = false };
        }

        [Fact]
        public async Task DPoPOptsIntoOneAuthAndBuildsSilentBrokerCredential()
        {
            if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                return;

            var credential = await AuthenticationHelpers.GetTokenCredentialAsync(CreateContext());

            Assert.True(OneAuthPreview.IsActive);
            Assert.IsType<InteractiveBrowserCredential>(credential);
        }

        [Theory]
        [InlineData(AuthenticationType.AppOnly, TokenCredentialType.ClientSecret)]
        [InlineData(AuthenticationType.ManagedIdentity, TokenCredentialType.ManagedIdentity)]
        [InlineData(AuthenticationType.EnvironmentVariable, TokenCredentialType.EnvironmentVariable)]
        [InlineData(AuthenticationType.UserProvidedAccessToken, TokenCredentialType.UserProvidedAccessToken)]
        [InlineData(AuthenticationType.Delegated, TokenCredentialType.DeviceCode)]
        public async Task RejectsUnsupportedFlowsInsteadOfFallingBack(AuthenticationType authType, TokenCredentialType credentialType)
        {
            var context = CreateContext();
            context.AuthType = authType;
            context.TokenCredentialType = credentialType;

            await Assert.ThrowsAsync<NotSupportedException>(() => AuthenticationHelpers.GetTokenCredentialAsync(context));
        }

        [Fact]
        public async Task RejectsDisabledWam()
        {
            GraphSession.Instance.GraphOption.DisableWAMForMSGraph = true;

            await Assert.ThrowsAsync<NotSupportedException>(() => AuthenticationHelpers.GetTokenCredentialAsync(CreateContext()));
        }

        [Fact]
        public async Task RejectsBearerTokenAtSignInWhenDPoPWasRequested()
        {
            var credential = new Mock<TokenCredential>();
            credential.Setup(value => value.GetTokenAsync(It.IsAny<TokenRequestContext>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new AccessToken("bearer-token", DateTimeOffset.UtcNow.AddMinutes(10)));

            await Assert.ThrowsAsync<InvalidOperationException>(
                () => AuthenticationHelpers.SignInAsync(CreateContext(), tokenCredential: credential.Object));
        }

        [Fact]
        public void PlacesProofSigningAfterRetryAndCustomHandlersAndDisablesTransportRedirects()
        {
            if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                return;

            var trailingHandler = new PassThroughHandler();
            using var client = GraphHttpClientFactory.Create(
                CreateContext(), new RequestContext(), trailingHandlers: new[] { trailingHandler });

            var proofHandler = Assert.IsType<DPoPAuthenticationHandler>(trailingHandler.InnerHandler);
            var transport = Assert.IsType<HttpClientHandler>(proofHandler.InnerHandler);
            Assert.False(transport.AllowAutoRedirect);
        }

        private static AuthContext CreateContext() => new AuthContext
        {
            ClientId = "11111111-1111-1111-1111-111111111111",
            AuthType = AuthenticationType.Delegated,
            TokenCredentialType = TokenCredentialType.InteractiveBrowser,
            ContextScope = ContextScope.Process,
            Scopes = new[] { "https://graph.microsoft.com/.default" }
        };

        public void Dispose()
        {
            Environment.SetEnvironmentVariable(RuntimeVariable, _previousRuntime);
            Environment.SetEnvironmentVariable(DPoPVariable, _previousDPoP);
            GraphSession.Reset();
        }

        private sealed class PassThroughHandler : DelegatingHandler { }
    }
}
#endif
