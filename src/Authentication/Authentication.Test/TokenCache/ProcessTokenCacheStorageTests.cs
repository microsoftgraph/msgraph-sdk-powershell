namespace Microsoft.Graph.Authentication.Test.TokenCache
{
    using Microsoft.Graph.PowerShell.Authentication;
    using Microsoft.Graph.PowerShell.Authentication.Common;
    using Microsoft.Graph.PowerShell.Authentication.TokenCache;
    using System;
    using System.Text;
    using System.Threading;
    using Xunit;

    public class ProcessTokenCacheStorageTests: IDisposable
    {
        // Defaults to process context scope.
        private IAuthContext _testAppContext1;
        public ProcessTokenCacheStorageTests()
        {
            _testAppContext1 = new AuthContext { ClientId = "test_app_id_1" };
            GraphSessionInitializer.InitializeSession();
        }

        [Fact]
        public void ShouldStoreNewTokenInProccessCache()
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
        }

        [Fact]
        public void ShouldUpdateTokenInProccessCache()
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
        }

        [Fact]
        public void ShouldReturnNoContentWhenProccessCacheIsEmpty()
        {
            // Act
            byte[] storedBuffer = TokenCacheStorage.GetToken(_testAppContext1);

            // Assert
            Assert.Empty(storedBuffer);
        }

        [Fact]
        public void ShouldDeleteProccessCache()
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
        public void ProccessTokenCacheShouldBeThreadSafe()
        {
            // Arrange
            int executions = 50;
            int count = 0;
            bool failed = false;
            Thread[] threads = new Thread[executions];

            // Act
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(() => {
                    byte[] contentBuffer = Encoding.UTF8.GetBytes(i.ToString());
                    TokenCacheStorage.SetToken(_testAppContext1, contentBuffer);
                    Thread.Sleep(2000);

                    byte[] storedBuffer = TokenCacheStorage.GetToken(_testAppContext1);
                    if (i.ToString() != Encoding.UTF8.GetString(storedBuffer))
                    {
                        failed = true;
                    }

                    Interlocked.Increment(ref count);
                });
            }

            foreach (Thread thread in threads)
            {
                thread.Start();
            }

            foreach (Thread thread in threads)
            {
                thread.Join();
            }

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
            GraphSession.Reset();
        }
    }
}
