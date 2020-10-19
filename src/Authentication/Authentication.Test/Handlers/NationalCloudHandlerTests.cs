namespace Microsoft.Graph.Authentication.Test
{
    using Microsoft.Graph.PowerShell.Authentication;
    using Microsoft.Graph.PowerShell.Authentication.Handlers;
    using Microsoft.Graph.PowerShell.Authentication.Models;
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Xunit;

    public class NationalCloudHandlerTests : IDisposable
    {
        private HttpMessageInvoker _invoker;
        private FakeSuccessHandler _fakeSuccessHandler;
        private NationalCloudHandler _nationalCloudHandler;
        private string topParam = "$top=5";
        private string selectParam = "Select=DisplayName%2CId%2CMail%2CUserType";

        public NationalCloudHandlerTests()
        {
            this._fakeSuccessHandler = new FakeSuccessHandler();
            this._nationalCloudHandler = new NationalCloudHandler(new ODataQueryOptionsHandler(_fakeSuccessHandler));
            this._invoker = new HttpMessageInvoker(_nationalCloudHandler);
        }

        public void Dispose()
        {
            Dispose(true);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                this._invoker.Dispose();
            }
        }


        [Fact]
        public async Task ShouldUseGlobalCloudWhenEnvironmentIsNotSet()
        {
            GraphSession.Initialize(() => new GraphSession());

            // Arrange
            GraphSession.Instance.Environment = null;
            string initialRequestUrl = $"https://graph.microsoft.com/v1.0/users?{topParam}&{selectParam}";
            Uri requestUrl = new Uri(initialRequestUrl);
            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUrl);

            // Act
            var response = await this._invoker.SendAsync(httpRequestMessage, new CancellationToken());
            var sentRequestQuery = response.RequestMessage.RequestUri.Query;

            // Assert
            Assert.Equal(requestUrl.Scheme, response.RequestMessage.RequestUri.Scheme);
            Assert.Equal(requestUrl.Host, response.RequestMessage.RequestUri.Host);
            Assert.Contains(topParam, sentRequestQuery);
            Assert.Contains($"${selectParam}", sentRequestQuery);
            Assert.Equal(2, sentRequestQuery.Split('&').Length);

            GraphSession.Reset();
        }

        [Fact]
        public async Task ShouldUseGermanyCloudWhenEnvironmentIsSetToGermany()
        {
            GraphSession.Initialize(() => new GraphSession());

            // Arrange
            GraphEnvironment germanyEnvironment = GraphEnvironment.BuiltInEnvironments[GraphEnvironmentConstants.EnvironmentName.Germany];
            GraphSession.Instance.Environment = germanyEnvironment;
            Uri requestUrl = new Uri($"https://graph.microsoft.com/beta/users?{topParam}&{selectParam}");
            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUrl);

            // Act
            var response = await this._invoker.SendAsync(httpRequestMessage, new CancellationToken());
            var sentRequestQuery = response.RequestMessage.RequestUri.Query;

            // Assert
            Assert.Equal(requestUrl.Scheme, response.RequestMessage.RequestUri.Scheme);
            Assert.Equal("graph.microsoft.de", response.RequestMessage.RequestUri.Host);
            Assert.Contains(topParam, sentRequestQuery);
            Assert.Contains(selectParam, sentRequestQuery);
            Assert.Equal(2, sentRequestQuery.Split('&').Length);

            GraphSession.Reset();
        }

        [Fact]
        public async Task ShouldUseUserDefinedCloudWhenEnvironmentIsSetToAUserDefinedCloud()
        {
            GraphSession.Initialize(() => new GraphSession());

            // Arrange
            GraphEnvironment userDefinedEnvironment = new GraphEnvironment
            {
                Name = "Canary",
                AzureADEndpoint = "https://login.microsoftonline.com",
                GraphEndpoint = "https://canary.graph.microsoft.com"
            };
            GraphSession.Instance.Environment = userDefinedEnvironment;
            Uri requestUrl = new Uri($"https://graph.microsoft.com/v1.0/users?{topParam}&{selectParam}");
            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUrl);

            // Act
            var response = await this._invoker.SendAsync(httpRequestMessage, new CancellationToken());
            var sentRequestQuery = response.RequestMessage.RequestUri.Query;

            // Assert
            Assert.Equal(requestUrl.Scheme, response.RequestMessage.RequestUri.Scheme);
            Assert.Equal("canary.graph.microsoft.com", response.RequestMessage.RequestUri.Host);
            Assert.Contains(topParam, sentRequestQuery);
            Assert.Contains($"${selectParam}", sentRequestQuery);
            Assert.Equal(2, sentRequestQuery.Split('&').Length);

            GraphSession.Reset();
        }
    }
}
