// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------
namespace Microsoft.Graph.Authentication.Test.Helpers
{
    using System;
    using System.Net.Http;
    using Microsoft.Graph.Authentication.Core;
    using Microsoft.Graph.PowerShell.Authentication;
    using Microsoft.Graph.PowerShell.Authentication.Helpers;
    using Xunit;

    public class HttpHelpersTests
    {
        [Fact]
        public void GetGraphHttpClientWithDefaultParametersShouldReturnHttpClientWithDefaultTimeout()
        {
            GraphSession.Initialize(() => new GraphSession());
            GraphSession.Instance.AuthContext = new AuthContext
            {
                AuthType = AuthenticationType.UserProvidedAccessToken,
                ContextScope = ContextScope.Process
            };

            HttpClient httpClient = HttpHelpers.GetGraphHttpClient();

            Assert.Equal(GraphSession.Instance.AuthContext.ClientTimeout, TimeSpan.FromSeconds(Constants.ClientTimeout));
            Assert.Equal(httpClient.Timeout, GraphSession.Instance.AuthContext.ClientTimeout);

            // reset static instance.
            GraphSession.Reset();
        }

        [Fact]
        public void GetGraphHttpClientWithClientTimeoutParameterShouldReturnHttpClientWithSpecifiedTimeout()
        {
            GraphSession.Initialize(() => new GraphSession());
            TimeSpan timeSpan = TimeSpan.FromSeconds(10);
            var authContext = new AuthContext
            {
                AuthType = AuthenticationType.UserProvidedAccessToken,
                ContextScope = ContextScope.Process
            };
            IAuthenticationProvider authProvider = AuthenticationHelpers.GetAuthProvider(authContext);

            HttpClient httpClient = HttpHelpers.GetGraphHttpClient(authProvider, timeSpan);

            Assert.Equal(authContext.ClientTimeout, TimeSpan.FromSeconds(Constants.ClientTimeout));
            Assert.Equal(httpClient.Timeout, timeSpan);

            // reset static instance.
            GraphSession.Reset();
        }

        [Fact]
        public void GetGraphHttpClientShouldReturnHttpClientWithCustomerProvidedTimeout()
        {
            GraphSession.Initialize(() => new GraphSession());
            TimeSpan timeSpan = TimeSpan.FromSeconds(10);
            GraphSession.Instance.AuthContext = new AuthContext
            {
                AuthType = AuthenticationType.UserProvidedAccessToken,
                ContextScope = ContextScope.Process,
                ClientTimeout = timeSpan
            };

            HttpClient httpClient = HttpHelpers.GetGraphHttpClient();

            Assert.Equal(GraphSession.Instance.AuthContext.ClientTimeout, timeSpan);
            Assert.Equal(httpClient.Timeout, timeSpan);

            // reset static instance.
            GraphSession.Reset();
        }

        [Fact]
        public void GetGraphHttpClientShouldReturnInSessionHttpClientWhenSessionHasAClient()
        {
            GraphSession.Initialize(() => new GraphSession());
            GraphSession.Instance.AuthContext = new AuthContext
            {
                AuthType = AuthenticationType.UserProvidedAccessToken,
                ContextScope = ContextScope.Process,
            };
            GraphSession.Instance.GraphHttpClient = new HttpClient
            {
                BaseAddress = new Uri("https://test.contoso.com/v1.0/")
            };

            HttpClient httpClient = HttpHelpers.GetGraphHttpClient();

            Assert.NotNull(httpClient);
            Assert.NotNull(GraphSession.Instance.GraphHttpClient);
            Assert.Equal(httpClient.BaseAddress, GraphSession.Instance.GraphHttpClient.BaseAddress);

            // reset static instance.
            GraphSession.Reset();
        }

        [Fact]
        public void GetGraphHttpClientShouldReturnNewHttpClientWhenSessionHasNoClient()
        {
            GraphSession.Initialize(() => new GraphSession());
            GraphSession.Instance.AuthContext = new AuthContext
            {
                AuthType = AuthenticationType.UserProvidedAccessToken,
                ContextScope = ContextScope.Process,
            };
            GraphSession.Instance.GraphHttpClient = null;

            HttpClient httpClient = HttpHelpers.GetGraphHttpClient();

            Assert.NotNull(httpClient);
            Assert.NotNull(GraphSession.Instance.GraphHttpClient);
            Assert.Equal(httpClient.BaseAddress, GraphSession.Instance.GraphHttpClient.BaseAddress);

            // reset static instance.
            GraphSession.Reset();
        }

        [Fact]
        public void GetGraphHttpClientShouldReturnNewHttpClientWhenSessionIsNew()
        {
            GraphSession.Initialize(() => new GraphSession());
            GraphSession.Instance.AuthContext = new AuthContext
            {
                AuthType = AuthenticationType.UserProvidedAccessToken,
                ContextScope = ContextScope.Process,
            };

            HttpClient httpClient = HttpHelpers.GetGraphHttpClient();

            Assert.NotNull(httpClient);
            Assert.NotNull(GraphSession.Instance.GraphHttpClient);
            Assert.Equal(httpClient.BaseAddress, GraphSession.Instance.GraphHttpClient.BaseAddress);

            // reset static instance.
            GraphSession.Reset();
        }

        [Fact]
        public void GetGraphHttpClientShouldReturnNewHttpClientSignOutThenSignIn()
        {
            GraphSession.Initialize(() => new GraphSession());
            GraphSession.Instance.AuthContext = new AuthContext
            {
                AuthType = AuthenticationType.UserProvidedAccessToken,
                ContextScope = ContextScope.Process,
            };

            var dummyClient = new HttpClient
            {
                BaseAddress = new Uri("https://test.contoso.com/v1.0/")
            };
            GraphSession.Instance.GraphHttpClient = dummyClient;
            HttpClient httpClientAttempt1 = HttpHelpers.GetGraphHttpClient();

            // Mock sign out.
            Authenticator.LogOut(GraphSession.Instance.AuthContext);
            GraphSession.Instance.AuthContext = null;
            GraphSession.Instance.GraphHttpClient = null;

            // Mock sign in.
            GraphSession.Initialize(() => new GraphSession());
            GraphSession.Instance.AuthContext = new AuthContext
            {
                AuthType = AuthenticationType.UserProvidedAccessToken,
                ContextScope = ContextScope.Process,
            };
            HttpClient httpClientAttempt2 = HttpHelpers.GetGraphHttpClient();

            Assert.NotNull(httpClientAttempt1);
            Assert.NotNull(httpClientAttempt2);
            Assert.NotNull(GraphSession.Instance.GraphHttpClient);
            Assert.NotEqual(httpClientAttempt2.BaseAddress, httpClientAttempt1.BaseAddress);
            Assert.Equal(httpClientAttempt1.BaseAddress, dummyClient.BaseAddress);
            Assert.Equal(httpClientAttempt2.BaseAddress, GraphSession.Instance.GraphHttpClient.BaseAddress);

            // reset static instance.
            GraphSession.Reset();
        }
    }
}
