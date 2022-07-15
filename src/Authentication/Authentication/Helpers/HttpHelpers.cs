// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------
using Microsoft.Graph.PowerShell.Authentication.Cmdlets;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using Microsoft.Graph.PowerShell.Authentication.Handlers;
using System.Management.Automation;
using System;
using Microsoft.Graph.PowerShell.Authentication.Core.Utilities;
using Microsoft.Graph.PowerShell.Authentication.Models;

namespace Microsoft.Graph.PowerShell.Authentication.Helpers
{
    /// <summary>
    /// A HTTP helper class.
    /// </summary>
    public static class HttpHelpers
    {
        /// The version for current assembly.
        private static readonly AssemblyName AssemblyInfo = typeof(ConnectMgGraph).GetTypeInfo().Assembly.GetName();

        /// <summary>
        /// Prepends SDK header to an HTTP client.
        /// </summary>
        /// <param name="httpClient"></param>
        private static void PrependSDKVersionHeader(HttpClient httpClient, string headerName, string headerValue)
        {
            if (httpClient.DefaultRequestHeaders.TryGetValues(headerName, out IEnumerable<string> previousSDKHeaders))
            {
                httpClient.DefaultRequestHeaders.Remove(headerName);
                httpClient.DefaultRequestHeaders.Add(headerName, new[] {
                    headerValue, previousSDKHeaders.Where(h => h.StartsWith(Constants.DotNetSDKHeaderValue, StringComparison.InvariantCultureIgnoreCase)).FirstOrDefault()
                });
            }
            else
            {
                httpClient.DefaultRequestHeaders.Add(headerName, headerValue);
            }
        }
        
        private static void ReplaceSDKHeader(HttpClient httpClient, string headerName, string headerValue)
        {
            if (!httpClient.DefaultRequestHeaders.Contains(headerName)) {
                httpClient.DefaultRequestHeaders.Add(headerName, headerValue);
            } else {
                httpClient.DefaultRequestHeaders.Remove(headerName);
                httpClient.DefaultRequestHeaders.Add(headerName, headerValue);
            }
        }

        private static void SetRequestHeaders(HttpClient httpClient, string sdkVersionHeader, string userAgentHeader)
        {
            PrependSDKVersionHeader(httpClient, CoreConstants.Headers.SdkVersionHeaderName, sdkVersionHeader);
            ReplaceSDKHeader(httpClient, HttpKnownHeaderNames.UserAgent, userAgentHeader);            
        }

        public static HttpClient GetGraphHttpClient(InvocationInfo invocationInfo, IAuthContext authContext = null)
        {
            authContext = authContext ?? GraphSession.Instance.AuthContext;
            if (authContext is null) { throw new AuthenticationException(Core.ErrorConstants.Message.MissingAuthContext); }
            var requestUserAgent = new RequestUserAgent(authContext.PSHostVersion, invocationInfo);
            string sdkVersionHeaderValue;
            if (requestUserAgent.App.Contains("Beta"))
                sdkVersionHeaderValue = string.Format(Constants.PSSDKHeaderValueBeta, AssemblyInfo.Version.Major, AssemblyInfo.Version.Minor, AssemblyInfo.Version.Build);
            else
                sdkVersionHeaderValue = string.Format(Constants.PSSDKHeaderValueV1, AssemblyInfo.Version.Major, AssemblyInfo.Version.Minor, AssemblyInfo.Version.Build);
            var httpClient = GetGraphHttpClient(authContext);
            SetRequestHeaders(httpClient, sdkVersionHeaderValue, requestUserAgent.UserAgent);
            return httpClient;
        }

        /// <summary>
        /// Creates a pre-configured Microsoft Graph <see cref="HttpClient"/>.
        /// </summary>
        /// <param name="authContext"></param>
        /// <returns></returns>
        public static HttpClient GetGraphHttpClient(IAuthContext authContext = null)
        {
            if (GraphSession.Instance?.GraphHttpClient != null)
                return GraphSession.Instance.GraphHttpClient;
            authContext = authContext ?? GraphSession.Instance.AuthContext;
            if (authContext is null)
            {
                throw new AuthenticationException(Core.ErrorConstants.Message.MissingAuthContext);
            }

            IAuthenticationProvider authProvider = AuthenticationHelpers.GetAuthenticationProviderAsync(authContext).ConfigureAwait(false).GetAwaiter().GetResult();
            var newHttpClient = GetGraphHttpClient(authProvider, authContext.ClientTimeout);
            GraphSession.Instance.GraphHttpClient = newHttpClient;
            return newHttpClient;
        }

        /// <summary>
        /// Creates a pre-configured Microsoft Graph <see cref="HttpClient"/>.
        /// with an <see cref="IAuthenticationProvider"/>
        /// </summary>
        /// <param name="authProvider">Custom AuthProvider</param>
        /// <returns></returns>
        public static HttpClient GetGraphHttpClient(IAuthenticationProvider authProvider, TimeSpan clientTimeout)
        {
            IList<DelegatingHandler> defaultHandlers = GraphClientFactory.CreateDefaultHandlers(authProvider);

            // Register custom HTTP handlers after AuthHandler.
            defaultHandlers.Insert(1, new NationalCloudHandler());
            defaultHandlers.Insert(2, new ODataQueryOptionsHandler());
            defaultHandlers.Insert(3, new HttpVersionHandler());

            HttpClient httpClient = GraphClientFactory.Create(defaultHandlers);
            httpClient.Timeout = clientTimeout;
            return httpClient;
        }
    }
}
