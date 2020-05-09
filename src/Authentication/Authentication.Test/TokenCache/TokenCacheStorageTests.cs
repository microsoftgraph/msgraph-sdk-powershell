namespace Microsoft.Graph.Authentication.Test.TokenCache
{
    using Microsoft.Graph.PowerShell.Authentication.TokenCache;
    using System;
    using System.Text;
    using System.Threading.Tasks;
    using Xunit;

    public class TokenCacheStorageTests: IDisposable
    {
        private const string TestAppId1 = "test_app_id_1";

        [Fact]
        public void ShouldStoreNewTokenToPlatformCache()
        {
            // Arrange
            string strContent = "random data for app.";
            byte[] bufferToStore = Encoding.UTF8.GetBytes(strContent);

            // Act
            TokenCacheStorage.SetToken(TestAppId1, bufferToStore);

            // Assert
            byte[] storedBuffer = TokenCacheStorage.GetToken(TestAppId1);
            Assert.Equal(bufferToStore.Length, storedBuffer.Length);
            Assert.Equal(strContent, Encoding.UTF8.GetString(storedBuffer));

            // Cleanup
            CleanTokenCache(TestAppId1);
        }

        [Fact]
        public void ShouldStoreMultipleAppTokensInPlatformCache()
        {
            // Arrange
            string app1StrContent = "random data for app 1.";
            byte[] app1BufferToStore = Encoding.UTF8.GetBytes(app1StrContent);

            string TestAppId2 = "test_app_id_2";
            string app2StrContent = "random data for app 2 plus more data.";
            byte[] app2BufferToStore = Encoding.UTF8.GetBytes(app2StrContent);

            // Act
            TokenCacheStorage.SetToken(TestAppId1, app1BufferToStore);
            TokenCacheStorage.SetToken(TestAppId2, app2BufferToStore);

            // Assert
            byte[] app1StoredBuffer = TokenCacheStorage.GetToken(TestAppId1);
            Assert.Equal(app1BufferToStore.Length, app1StoredBuffer.Length);
            Assert.Equal(app1StrContent, Encoding.UTF8.GetString(app1StoredBuffer));

            byte[] app2StoredBuffer = TokenCacheStorage.GetToken(TestAppId2);
            Assert.Equal(app2BufferToStore.Length, app2StoredBuffer.Length);
            Assert.Equal(app2StrContent, Encoding.UTF8.GetString(app2StoredBuffer));

            // Cleanup
            CleanTokenCache(TestAppId1);
            CleanTokenCache(TestAppId2);
        }


        [Fact]
        public void ShouldUpdateTokenInPlatformCache()
        {
            // Arrange
            string originalStrContent = "random data for app.";
            byte[] originalBuffer = Encoding.UTF8.GetBytes(originalStrContent);
            TokenCacheStorage.SetToken(TestAppId1, originalBuffer);

            // Act
            string strContentToUpdate = "updated random data for app.";
            byte[] updateBuffer = Encoding.UTF8.GetBytes(strContentToUpdate);
            TokenCacheStorage.SetToken(TestAppId1, updateBuffer);

            // Assert
            byte[] storedBuffer = TokenCacheStorage.GetToken(TestAppId1);
            Assert.NotEqual(originalBuffer.Length, storedBuffer.Length);
            Assert.Equal(updateBuffer.Length, storedBuffer.Length);
            Assert.Equal(strContentToUpdate, Encoding.UTF8.GetString(storedBuffer));

            // Cleanup
            CleanTokenCache(TestAppId1);
        }

        [Fact]
        public void ShouldReturnNoContentWhenPlatformCacheIsEmpty()
        {
            // Arrange
            CleanTokenCache(TestAppId1);

            // Act
            byte[] storedBuffer = TokenCacheStorage.GetToken(TestAppId1);

            // Assert
            Assert.Empty(storedBuffer);
        }

        [Fact]
        public void ShouldDeleteCache()
        {
            // Arrange
            string originalStrContent = "random data for app.";
            byte[] originalBuffer = Encoding.UTF8.GetBytes(originalStrContent);
            TokenCacheStorage.SetToken(TestAppId1, originalBuffer);

            // Act
            TokenCacheStorage.DeleteToken(TestAppId1);

            // Assert
            byte[] storedBuffer = TokenCacheStorage.GetToken(TestAppId1);
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
                TokenCacheStorage.SetToken($"{index}", contentBuffer);

                byte[] storedBuffer = TokenCacheStorage.GetToken(index.ToString());
                if (index.ToString() != Encoding.UTF8.GetString(storedBuffer))
                {
                    failed = true;
                }

                CleanTokenCache(index.ToString());
                count++;
            });

            // Assert
            Assert.Equal(executions, count);
            Assert.False(failed);
        }

        public void Dispose()
        {
            CleanTokenCache(TestAppId1);
        }

        private void CleanTokenCache(string appId)
        {
            TokenCacheStorage.DeleteToken(appId);
        }
    }
}
