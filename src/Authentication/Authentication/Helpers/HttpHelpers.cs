// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------
using Microsoft.Graph.Authentication;
using Microsoft.Graph.PowerShell.Authentication.Core.Interfaces;
using Microsoft.Graph.PowerShell.Authentication.Core.Utilities;
using Microsoft.Graph.PowerShell.Authentication.Handlers;
using Microsoft.Kiota.Http.HttpClientLibrary.Middleware;
using Microsoft.Kiota.Http.HttpClientLibrary.Middleware.Options;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Net.Http;

namespace Microsoft.Graph.PowerShell.Authentication.Helpers
{
    /// <summary>
    /// A HTTP helper class.
    /// </summary>
    public static class HttpHelpers
    {
        /// <summary>
        /// Creates a pre-configured Microsoft Graph <see cref="HttpClient"/>.
        /// </summary>
        /// <param name="authContext"></param>
        /// <returns></returns>
        public static HttpClient GetGraphHttpClient()
        {
            if (GraphSession.Instance?.GraphHttpClient != null)
                return GraphSession.Instance.GraphHttpClient;

            var requestUserAgent = new RequestUserAgent(GraphSession.Instance.AuthContext?.PSHostVersion, null);

            AzureIdentityAccessTokenProvider authProvider = AuthenticationHelpers.GetAuthenticationProviderAsync(GraphSession.Instance.AuthContext).ConfigureAwait(false).GetAwaiter().GetResult();
            var newHttpClient = GetGraphHttpClient(authProvider, GraphSession.Instance.RequestContext);
            newHttpClient.DefaultRequestHeaders.UserAgent.ParseAdd(requestUserAgent.UserAgent);
            GraphSession.Instance.GraphHttpClient = newHttpClient;
            return newHttpClient;
        }

        /// <summary>
        /// Creates a pre-configured Microsoft Graph <see cref="HttpClient"/>.
        /// with an <see cref="IAuthenticationProvider"/>
        /// </summary>
        /// <param name="authProvider">Custom AuthProvider</param>
        /// <returns></returns>
        private static HttpClient GetGraphHttpClient(AzureIdentityAccessTokenProvider authProvider, IRequestContext requestContext)
        {
            if (requestContext is null)
                throw new AuthenticationException(string.Format(CultureInfo.InvariantCulture, Core.ErrorConstants.Message.MissingSessionProperty, nameof(requestContext)));

            IList<DelegatingHandler> delegatingHandlers = new List<DelegatingHandler> {
                new AuthenticationHandler(authProvider),
                new NationalCloudHandler(),
                new ODataQueryOptionsHandler(),
                new HttpVersionHandler(),
                new CompressionHandler(),
                new RetryHandler(new RetryHandlerOption{
                    Delay = requestContext.RetryDelay,
                    MaxRetry = requestContext.MaxRetry,
                    RetriesTimeLimit= requestContext.RetriesTimeLimit
                }),
                new RedirectHandler(),
                new RequestHeaderHandler() // Should always be last.
            };

            HttpClient httpClient = RuntimeUtils.IsPsCore()
                ? GraphClientFactory.Create(delegatingHandlers)
                : GraphClientFactory.Create(delegatingHandlers, finalHandler: new HttpClientHandler
                {
                    AllowAutoRedirect = false,
                    AutomaticDecompression = DecompressionMethods.None
                });
            httpClient.Timeout = requestContext.ClientTimeout;
            return httpClient;
        }
    }
}
