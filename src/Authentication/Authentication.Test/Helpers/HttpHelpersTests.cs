﻿// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------
using Microsoft.Graph.PowerShell.Authentication;
using Microsoft.Graph.PowerShell.Authentication.Core.TokenCache;
using Microsoft.Graph.PowerShell.Authentication.Core.Utilities;
using Microsoft.Graph.PowerShell.Authentication.Helpers;
using Microsoft.Graph.PowerShell.Authentication.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Microsoft.Graph.Authentication.Test.Helpers
{
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
            GraphSession.Instance.RequestContext = new RequestContext();

            HttpClient httpClient = HttpHelpers.GetGraphHttpClient();

            Assert.Equal(GraphSession.Instance.RequestContext.ClientTimeout, TimeSpan.FromSeconds(Constants.ClientTimeout));
            Assert.Equal(httpClient.Timeout, GraphSession.Instance.RequestContext.ClientTimeout);

            // reset static instance.
            GraphSession.Reset();
        }

        [Fact]
        public void GetGraphHttpClientWithClientTimeoutParameterShouldReturnHttpClientWithSpecifiedTimeout()
        {
            GraphSession.Initialize(() => new GraphSession());
            TimeSpan timeSpan = TimeSpan.FromSeconds(10);
            GraphSession.Instance.AuthContext = new AuthContext
            {
                AuthType = AuthenticationType.UserProvidedAccessToken,
                ContextScope = ContextScope.Process
            };
            GraphSession.Instance.RequestContext = new RequestContext { ClientTimeout = timeSpan };

            HttpClient httpClient = HttpHelpers.GetGraphHttpClient();

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
                ContextScope = ContextScope.Process
            };
            GraphSession.Instance.RequestContext = new RequestContext { ClientTimeout = timeSpan };

            HttpClient httpClient = HttpHelpers.GetGraphHttpClient();

            Assert.Equal(GraphSession.Instance.RequestContext.ClientTimeout, timeSpan);
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
            GraphSession.Instance.RequestContext = new RequestContext();

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
            GraphSession.Instance.RequestContext = new RequestContext();

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
            GraphSession.Instance.RequestContext = new RequestContext();

            HttpClient httpClient = HttpHelpers.GetGraphHttpClient();

            Assert.NotNull(httpClient);
            Assert.NotNull(GraphSession.Instance.GraphHttpClient);
            Assert.Equal(httpClient.BaseAddress, GraphSession.Instance.GraphHttpClient.BaseAddress);

            // reset static instance.
            GraphSession.Reset();
        }

        [Fact]
        public async Task GetGraphHttpClientShouldReturnNewHttpClientOnSignOutThenSignInAsync()
        {
            GraphSession.Initialize(() => new GraphSession());
            GraphSession.Instance.InMemoryTokenCache = new InMemoryTokenCache();
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
            await AuthenticationHelpers.LogoutAsync();
            Assert.Null(GraphSession.Instance.AuthContext);
            Assert.Null(GraphSession.Instance.GraphHttpClient);

            // Mock sign in.
            GraphSession.Initialize(() => new GraphSession());
            GraphSession.Instance.AuthContext = new AuthContext
            {
                AuthType = AuthenticationType.UserProvidedAccessToken,
                ContextScope = ContextScope.Process,
            };
            GraphSession.Instance.RequestContext = new RequestContext();
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

        [Fact]
        public async void GetGraphHttpClientShouldBeThreadSafeAsync()
        {
            GraphSession.Initialize(() => new GraphSession());
            GraphSession.Instance.RequestContext = new RequestContext();
            GraphSession.Instance.AuthContext = new AuthContext
            {
                AuthType = AuthenticationType.UserProvidedAccessToken,
                ContextScope = ContextScope.Process,
                PSHostVersion = new Version("7.2.7")
            };

            var tasks = new List<Task<HttpClient>>();
            for (int i = 0; i < 100; i++)
            {
                tasks.Add(Task.Factory.StartNew(() => HttpHelpers.GetGraphHttpClient()));
            }
            var exception = await Record.ExceptionAsync(() => Task.WhenAll(tasks));
            Assert.Null(exception);

            // reset static instance.
            GraphSession.Reset();
        }
    }
}
