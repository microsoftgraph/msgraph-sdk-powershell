using Microsoft.Graph.PowerShell.Authentication;
using Xunit;
using Microsoft.Graph.PowerShell.Authentication.Core.TokenCache;
using System.Text;

namespace Microsoft.Graph.Authentication.Test.Helpers
{
    public class InMemortyTokenCacheTests
    {

        [Fact]
        public void InMemoryTokenCahceShouldBeNullWhenGraphSessionIsInitialized()
        {
            GraphSession.Initialize(() => new GraphSession());

            Assert.NotNull(GraphSession.Instance);
            Assert.Null(GraphSession.Instance.InMemoryTokenCache);

            GraphSession.Reset();
        }

        [Fact]
        public void InMemoryTokenCahceShouldHaveEmptyTokenCacheWhenInitialized()
        {
            GraphSession.Initialize(() => new GraphSession());
            GraphSession.Instance.InMemoryTokenCache = new InMemoryTokenCache();
            
            Assert.NotNull(GraphSession.Instance.InMemoryTokenCache);
            Assert.NotNull(GraphSession.Instance.InMemoryTokenCache.ReadTokenData());
            Assert.Empty(GraphSession.Instance.InMemoryTokenCache.ReadTokenData());

            GraphSession.Reset();
        }

        [Fact]
        public void InMemoryTokenCahceShouldHaveInitializedTokenData()
        {
            GraphSession.Initialize(() => new GraphSession());
            string mockCacheData = "mockCacheData";
            byte[] mockCacheDataBytes = Encoding.UTF8.GetBytes(mockCacheData);
            
            GraphSession.Instance.InMemoryTokenCache = new InMemoryTokenCache(mockCacheDataBytes);
            var cachedBytes = GraphSession.Instance.InMemoryTokenCache.ReadTokenData();

            Assert.NotNull(GraphSession.Instance.InMemoryTokenCache);
            Assert.NotNull(cachedBytes);
            Assert.NotEmpty(cachedBytes);
            Assert.Equal(mockCacheDataBytes.Length, cachedBytes.Length);
            Assert.Equal(mockCacheData, Encoding.UTF8.GetString(cachedBytes));

            GraphSession.Reset();
        }

        [Fact]
        public void UpdateTokenDataWithoutFlushShouldNotFlushInitializedTokenData()
        {
            GraphSession.Initialize(() => new GraphSession());
            string mockCacheData = "intialTokenData";
            byte[] mockCacheDataBytes = Encoding.UTF8.GetBytes(mockCacheData);
            
            GraphSession.Instance.InMemoryTokenCache = new InMemoryTokenCache(mockCacheDataBytes);
            GraphSession.Instance.InMemoryTokenCache.UpdateTokenDataWithoutFlush(Encoding.UTF8.GetBytes("updatedTokenData"));
            var cachedBytes = GraphSession.Instance.InMemoryTokenCache.ReadTokenData();

            Assert.NotNull(GraphSession.Instance.InMemoryTokenCache);
            Assert.NotNull(cachedBytes);
            Assert.NotEmpty(cachedBytes);
            Assert.Equal(mockCacheDataBytes.Length, cachedBytes.Length);
            Assert.Equal(mockCacheData, Encoding.UTF8.GetString(cachedBytes));

            GraphSession.Reset();
        }
        
        [Fact]
        public void UpdateTokenDataWithFlushShouldOverwroteInitializedTokenData()
        {
            GraphSession.Initialize(() => new GraphSession());
            string mockCacheData = "intialTokenData";
            byte[] mockCacheDataBytes = Encoding.UTF8.GetBytes(mockCacheData);
            
            GraphSession.Instance.InMemoryTokenCache = new InMemoryTokenCache(mockCacheDataBytes);
            string updatedTokenData = "updatedTokenData";
            byte[] updatedTokenDataBytes = Encoding.UTF8.GetBytes(updatedTokenData);
            GraphSession.Instance.InMemoryTokenCache.UpdateTokenDataWithoutFlush(updatedTokenDataBytes);
            GraphSession.Instance.InMemoryTokenCache.FlushTokenData();
            var cachedBytes = GraphSession.Instance.InMemoryTokenCache.ReadTokenData();

            Assert.NotNull(GraphSession.Instance.InMemoryTokenCache);
            Assert.NotNull(cachedBytes);
            Assert.NotEmpty(cachedBytes);
            Assert.Equal(updatedTokenData, Encoding.UTF8.GetString(cachedBytes));

            GraphSession.Reset();
        }

        [Fact]
        public void ClearCacheShouldClearInMemoeryTokenCache()
        {
            GraphSession.Initialize(() => new GraphSession());
            string mockCacheData = "intialTokenData";
            byte[] mockCacheDataBytes = Encoding.UTF8.GetBytes(mockCacheData);

            GraphSession.Instance.InMemoryTokenCache = new InMemoryTokenCache(mockCacheDataBytes);
            string updatedTokenData = "updatedTokenData";
            byte[] updatedTokenDataBytes = Encoding.UTF8.GetBytes(updatedTokenData);
            GraphSession.Instance.InMemoryTokenCache.UpdateTokenDataWithoutFlush(updatedTokenDataBytes);
            GraphSession.Instance.InMemoryTokenCache.FlushTokenData();
            GraphSession.Instance.InMemoryTokenCache.ClearCache();
            var cachedBytes = GraphSession.Instance.InMemoryTokenCache.ReadTokenData();
            

            Assert.NotNull(GraphSession.Instance.InMemoryTokenCache);
            Assert.NotNull(cachedBytes);
            Assert.Empty(cachedBytes);

            GraphSession.Reset();
        }        
    }
}
