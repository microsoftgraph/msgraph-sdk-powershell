namespace Microsoft.Graph.Authentication.Test.TokenCache
{
    using Microsoft.Graph.PowerShell.Authentication;
    using Microsoft.Graph.PowerShell.Authentication.TokenCache;
    using System;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using Xunit;

    public class TokenCacheStorageTests: IDisposable
    {
        private IAuthContext _testAppContext1 = new AuthContext { ClientId = "test_app_id_1"  };

        [Fact]
        public void ShouldStoreNewTokenToPlatformCache()
        {
            // Arrange
            string strContent = "random data for app.";
            byte[] bufferToStore = Encoding.UTF8.GetBytes(strContent);

            // Act
            TokenCacheStorage.SetToken(_testAppContext1, bufferToStore);

            // Assert
            byte[] storedBuffer = TokenCacheStorage.GetToken(_testAppContext1);
            Assert.Equal(bufferToStore.Length, storedBuffer.Length);
            Assert.Equal(strContent, Encoding.UTF8.GetString(storedBuffer));

            // Cleanup
            CleanTokenCache(_testAppContext1);
        }

        [Fact]
        public void ShouldStoreMultipleAppTokensInPlatformCache()
        {
            // Arrange
            string app1StrContent = "random data for app 1.";
            byte[] app1BufferToStore = Encoding.UTF8.GetBytes(app1StrContent);

            IAuthContext testAppContext2 = new AuthContext { ClientId = "test_app_id_2" };
            string app2StrContent = "random data for app 2 plus more data.";
            byte[] app2BufferToStore = Encoding.UTF8.GetBytes(app2StrContent);

            // Act
            TokenCacheStorage.SetToken(_testAppContext1, app1BufferToStore);
            TokenCacheStorage.SetToken(testAppContext2, app2BufferToStore);

            // Assert
            byte[] app1StoredBuffer = TokenCacheStorage.GetToken(_testAppContext1);
            Assert.Equal(app1BufferToStore.Length, app1StoredBuffer.Length);
            Assert.Equal(app1StrContent, Encoding.UTF8.GetString(app1StoredBuffer));

            byte[] app2StoredBuffer = TokenCacheStorage.GetToken(testAppContext2);
            Assert.Equal(app2BufferToStore.Length, app2StoredBuffer.Length);
            Assert.Equal(app2StrContent, Encoding.UTF8.GetString(app2StoredBuffer));

            // Cleanup
            CleanTokenCache(_testAppContext1);
            CleanTokenCache(testAppContext2);
        }


        [Fact]
        public void ShouldUpdateTokenInPlatformCache()
        {
            // Arrange
            string originalStrContent = "random data for app.";
            byte[] originalBuffer = Encoding.UTF8.GetBytes(originalStrContent);
            TokenCacheStorage.SetToken(_testAppContext1, originalBuffer);

            // Act
            string strContentToUpdate = "updated random data for app.";
            byte[] updateBuffer = Encoding.UTF8.GetBytes(strContentToUpdate);
            TokenCacheStorage.SetToken(_testAppContext1, updateBuffer);

            // Assert
            byte[] storedBuffer = TokenCacheStorage.GetToken(_testAppContext1);
            Assert.NotEqual(originalBuffer.Length, storedBuffer.Length);
            Assert.Equal(updateBuffer.Length, storedBuffer.Length);
            Assert.Equal(strContentToUpdate, Encoding.UTF8.GetString(storedBuffer));

            // Cleanup
            CleanTokenCache(_testAppContext1);
        }

        [Fact]
        public void ShouldReturnNoContentWhenPlatformCacheIsEmpty()
        {
            // Arrange
            CleanTokenCache(_testAppContext1);

            // Act
            byte[] storedBuffer = TokenCacheStorage.GetToken(_testAppContext1);

            // Assert
            Assert.Empty(storedBuffer);
        }

        [Fact]
        public void ShouldDeleteCache()
        {
            // Arrange
            string originalStrContent = "random data for app.";
            byte[] originalBuffer = Encoding.UTF8.GetBytes(originalStrContent);
            TokenCacheStorage.SetToken(_testAppContext1, originalBuffer);

            // Act
            TokenCacheStorage.DeleteToken(_testAppContext1);

            // Assert
            byte[] storedBuffer = TokenCacheStorage.GetToken(_testAppContext1);
            Assert.Empty(storedBuffer);
        }


        [Fact]
        public void ShouldMakeParallelCallsToTokenCache()
        {
            // Arrange
            int executions = 50;
            int count = 0;
            bool failed = false;

            // Act
            Parallel.For(0, executions, (index) => {
                byte[] contentBuffer = Encoding.UTF8.GetBytes(index.ToString());
                var testAuthContext = new AuthContext { ClientId = index.ToString() };
                TokenCacheStorage.SetToken(testAuthContext, contentBuffer);

                byte[] storedBuffer = TokenCacheStorage.GetToken(testAuthContext);
                if (index.ToString() != Encoding.UTF8.GetString(storedBuffer))
                {
                    failed = true;
                }

                CleanTokenCache(testAuthContext);
                Interlocked.Increment(ref count);
            });

            // Assert
            Assert.Equal(executions, count);
            Assert.False(failed, "Unexpected content found.");
        }

        public void Dispose()
        {
            CleanTokenCache(_testAppContext1);
        }

        private void CleanTokenCache(IAuthContext authContext)
        {
            TokenCacheStorage.DeleteToken(authContext);
        }
    }
}
