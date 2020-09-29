namespace Microsoft.Graph.Authentication.Test
{
    using Microsoft.Graph.PowerShell.Authentication.Helpers;
    using System;
    using System.Linq;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Xunit;
    public class ODataQueryOptionsHandlerTests : IDisposable
    {
        private HttpMessageInvoker _invoker;
        private FakeSuccessHandler _fakeSuccessHandler;
        private ODataQueryOptionsHandler _graphODataHandler;
        private string _randomGuid;

        public ODataQueryOptionsHandlerTests()
        {
            this._fakeSuccessHandler = new FakeSuccessHandler();
            this._graphODataHandler = new ODataQueryOptionsHandler(_fakeSuccessHandler);
            this._invoker = new HttpMessageInvoker(_graphODataHandler);
            this._randomGuid = Guid.NewGuid().ToString();
        }

        public void Dispose()
        {
            this._invoker.Dispose();
        }

        [Fact]
        public async Task ShouldAddDollarSignToStandardODataQueryOptionsToV1Endpoint()
        {
            // Arrange
            string topParam = "$top=5";
            string orderbyParam = "$Orderby=DisplayName";
            string selectParam = "Select=DisplayName%2CId%2CMail%2CUserType";
            string filterParam = "filter=graphlearn_courses/courseId%20eq%20'123'";
            string expandParam = "ExPaNd=members";

            Uri requestUrl = new Uri($"https://graph.microsoft.com/v1.0/users?{topParam}&{orderbyParam}&{selectParam}&{filterParam}&{expandParam}");
            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUrl);

            // Act
            var response = await this._invoker.SendAsync(httpRequestMessage, new CancellationToken());
            var sentRequestQuery = response.RequestMessage.RequestUri.Query;

            // Assert
            Assert.NotEqual(requestUrl.Query, sentRequestQuery);
            Assert.Contains(topParam, sentRequestQuery);
            Assert.Contains(orderbyParam, sentRequestQuery);
            Assert.Contains($"${selectParam}", sentRequestQuery);
            Assert.Contains($"${filterParam}", sentRequestQuery);
            Assert.Contains($"${expandParam}", sentRequestQuery);
            Assert.Equal(5, sentRequestQuery.Split('&').Length);
            Assert.Equal(1, response.RequestMessage.RequestUri.AbsoluteUri.Count(u => (u == '?')));
        }

        [Fact]
        public async Task ShouldSkipWhenGraphVersionIsBeta()
        {
            // Arrange
            string topParam = "$top=5";
            string orderbyParam = "$Orderby=DisplayName";
            string selectParam = "Select=DisplayName%2CId%2CMail%2CUserType";
            string filterParam = "filter=graphlearn_courses/courseId%20eq%20'123'";
            string expandParam = "ExPaNd=members";

            Uri requestUrl = new Uri($"https://graph.microsoft.com/Beta/users?{topParam}&{orderbyParam}&{selectParam}&{filterParam}&{expandParam}");
            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUrl);

            // Act
            var response = await this._invoker.SendAsync(httpRequestMessage, new CancellationToken());

            // Assert
            Assert.Equal(requestUrl.ToString(), response.RequestMessage.RequestUri.ToString());
            Assert.Equal(5, response.RequestMessage.RequestUri.Query.Split('&').Length);
        }

        [Fact]
        public async Task ShouldSkipWhenQueryIsNotPresent()
        {
            // Arrange
            Uri requestUrl = new Uri($"https://graph.microsoft.com/v1.0/users/_randomGuid");
            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUrl);

            // Act
            var response = await this._invoker.SendAsync(httpRequestMessage, new CancellationToken());

            // Assert
            Assert.Equal(requestUrl.ToString(), response.RequestMessage.RequestUri.ToString());
            Assert.Empty(response.RequestMessage.RequestUri.Query);
        }
    }
}
