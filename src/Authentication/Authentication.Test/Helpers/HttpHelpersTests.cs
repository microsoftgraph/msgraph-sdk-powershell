﻿// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------
namespace Microsoft.Graph.Authentication.Test.Helpers
{
    using System;
    using System.Net.Http;
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
    }
}
