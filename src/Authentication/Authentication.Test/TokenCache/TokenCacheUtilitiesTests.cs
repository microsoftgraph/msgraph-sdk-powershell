using Microsoft.Graph.PowerShell.Authentication;
using Microsoft.Graph.PowerShell.Authentication.Core.TokenCache;
using Microsoft.Graph.PowerShell.Authentication.Core.Utilities;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Microsoft.Graph.Authentication.Test.TokenCache
{
    public class TokenCacheUtilitiesTests : IDisposable
    {
        public TokenCacheUtilitiesTests()
        {
            GraphSession.Initialize(() => new GraphSession());
            GraphSession.Instance.InMemoryTokenCache = new InMemoryTokenCache();
            GraphSession.Instance.GraphOption = new GraphOption();
        }

        public void Dispose()
        {
            GraphSession.Reset();
        }

        [Fact]
        public async Task LogoutAsyncShouldClearInMemoryCacheForProcessScope()
        {
            // Arrange
            GraphSession.Instance.InMemoryTokenCache = new InMemoryTokenCache(
                Encoding.UTF8.GetBytes("mockTokenData"));
            GraphSession.Instance.AuthContext = new AuthContext
            {
                AuthType = AuthenticationType.UserProvidedAccessToken,
                ContextScope = ContextScope.Process
            };

            // Act
            var result = await AuthenticationHelpers.LogoutAsync();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(AuthenticationType.UserProvidedAccessToken, result.AuthType);
            Assert.Null(GraphSession.Instance.AuthContext);
            Assert.Null(GraphSession.Instance.GraphHttpClient);
            Assert.Empty(GraphSession.Instance.InMemoryTokenCache.ReadTokenData());
        }

        [Fact]
        public async Task LogoutAsyncShouldNotThrowWhenAuthContextIsNull()
        {
            // Arrange
            GraphSession.Instance.AuthContext = null;

            // Act - should not throw even though there's no auth context
            var result = await AuthenticationHelpers.LogoutAsync();

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public async Task LogoutAsyncShouldAttemptCacheClearForCurrentUserScope()
        {
            // Arrange
            GraphSession.Instance.AuthContext = new AuthContext
            {
                AuthType = AuthenticationType.UserProvidedAccessToken,
                ContextScope = ContextScope.CurrentUser
            };

            // Act - should not throw even if no persisted cache exists on disk
            var result = await AuthenticationHelpers.LogoutAsync();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(ContextScope.CurrentUser, result.ContextScope);
            Assert.Null(GraphSession.Instance.AuthContext);
        }

        [Fact]
        public async Task LogoutAsyncWithSignOutFromBrokerShouldNotThrowWhenBrokerNotInUse()
        {
            // Arrange - a custom client id with WAM disabled means the broker path is skipped,
            // so no real broker accounts are touched during the test.
            GraphSession.Instance.GraphOption = new GraphOption { DisableWAMForMSGraph = true };
            GraphSession.Instance.AuthContext = new AuthContext
            {
                ClientId = "11111111-1111-1111-1111-111111111111",
                AuthType = AuthenticationType.UserProvidedAccessToken,
                ContextScope = ContextScope.Process
            };

            // Act - requesting broker sign-out must not throw when the broker is not in use.
            var result = await AuthenticationHelpers.LogoutAsync(signOutFromBroker: true);

            // Assert
            Assert.NotNull(result);
            Assert.Null(GraphSession.Instance.AuthContext);
            Assert.Null(GraphSession.Instance.GraphHttpClient);
        }

        [Fact]
        public async Task LogoutAsyncWithSignOutFromBrokerShouldStillClearContextForCurrentUser()
        {
            // Arrange - WAM disabled so the broker path is skipped; the file cache clear still runs.
            GraphSession.Instance.GraphOption = new GraphOption { DisableWAMForMSGraph = true };
            GraphSession.Instance.AuthContext = new AuthContext
            {
                ClientId = "11111111-1111-1111-1111-111111111111",
                AuthType = AuthenticationType.UserProvidedAccessToken,
                ContextScope = ContextScope.CurrentUser
            };

            // Act
            var result = await AuthenticationHelpers.LogoutAsync(signOutFromBroker: true);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(ContextScope.CurrentUser, result.ContextScope);
            Assert.Null(GraphSession.Instance.AuthContext);
        }
    }
}
