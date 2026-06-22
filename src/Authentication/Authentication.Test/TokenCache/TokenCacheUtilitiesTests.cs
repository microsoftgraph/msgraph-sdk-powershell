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
    }
}
