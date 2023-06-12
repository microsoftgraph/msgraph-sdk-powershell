using Microsoft.Graph.PowerShell.Authentication.Handlers;
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Microsoft.Graph.Authentication.Test.Handlers
{
    public class HttpVersionHandlerTests : IDisposable
    {
        private readonly FakeSuccessHandler _fakeSuccessHandler;
        private readonly HttpVersionHandler _httpVersionHandler;
        private readonly HttpMessageInvoker _invoker;

        public HttpVersionHandlerTests()
        {
            _fakeSuccessHandler = new FakeSuccessHandler();
            _httpVersionHandler = new HttpVersionHandler(_fakeSuccessHandler);
            _invoker = new HttpMessageInvoker(_httpVersionHandler);
        }

        [Fact]
        public async Task ShouldSetHttpMessageVersionTo2()
        {
            // Arrange
            var requestUrl = new Uri("https://graph.microsoft.com/v1.0/me");
            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUrl);

            // Act
            var response = await _invoker.SendAsync(httpRequestMessage, new CancellationToken());
            var sentRequest = response.RequestMessage;

            // Assert
            Assert.NotNull(sentRequest);
            Assert.Equal(requestUrl, sentRequest.RequestUri);
# if NET6_0_OR_GREATER
            Assert.Equal(sentRequest.Version, new Version(2, 0));
# endif
        }

        public void Dispose()
        {
            Dispose(true);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _invoker.Dispose();
            }
        }
    }
}
