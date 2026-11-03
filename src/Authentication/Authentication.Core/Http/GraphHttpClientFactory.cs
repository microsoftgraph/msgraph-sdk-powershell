// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using Microsoft.Graph.PowerShell.Authentication.Core.Interfaces;
using Microsoft.Graph.PowerShell.Authentication.Core.Utilities;
using Microsoft.Kiota.Http.HttpClientLibrary.Middleware;
using Microsoft.Kiota.Http.HttpClientLibrary.Middleware.Options;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Net.Http;

namespace Microsoft.Graph.PowerShell.Authentication.Core.Http
{
    /// <summary>
    /// Builds the Microsoft Graph <see cref="HttpClient"/> pipeline.
    /// The public surface of this type intentionally only exposes BCL types (<see cref="HttpClient"/>, <see cref="DelegatingHandler"/>)
    /// and types owned by this assembly, so that callers living in the default <c>AssemblyLoadContext</c> never bind to
    /// Microsoft.Graph.Core, Microsoft.Kiota.* or Azure.* directly.
    /// </summary>
    public static class GraphHttpClientFactory
    {
        /// <summary>
        /// Creates a pre-configured Microsoft Graph <see cref="HttpClient"/> for the provided <see cref="IAuthContext"/>.
        /// </summary>
        /// <param name="authContext">The authentication context used to acquire tokens.</param>
        /// <param name="requestContext">Retry/timeout settings.</param>
        /// <param name="customHandlers">
        /// Optional handlers supplied by the caller. They are inserted after authentication and before the retry/redirect
        /// handlers, in the order provided.
        /// </param>
        /// <param name="trailingHandlers">
        /// Optional handlers supplied by the caller that are appended after the retry/redirect handlers, in the order provided.
        /// </param>
        /// <param name="useLegacyClientHandler">
        /// When true a <see cref="HttpClientHandler"/> with auto-redirect disabled and GZip/Deflate decompression is used
        /// as the final handler (required on .NET Framework / Windows PowerShell).
        /// </param>
        /// <returns>A configured <see cref="HttpClient"/>.</returns>
        public static HttpClient Create(
            IAuthContext authContext,
            IRequestContext requestContext,
            IEnumerable<DelegatingHandler> customHandlers = null,
            IEnumerable<DelegatingHandler> trailingHandlers = null,
            bool useLegacyClientHandler = false)
        {
            if (authContext is null)
                throw new AuthenticationException(ErrorConstants.Message.MissingAuthContext);
            if (requestContext is null)
                throw new AuthenticationException(string.Format(CultureInfo.InvariantCulture, ErrorConstants.Message.MissingSessionProperty, nameof(requestContext)));

            var authProvider = AuthenticationHelpers.GetAuthenticationProviderAsync(authContext).ConfigureAwait(false).GetAwaiter().GetResult();

            var delegatingHandlers = new List<DelegatingHandler>
            {
                new AuthenticationHandler(authProvider)
            };

            if (customHandlers != null)
                delegatingHandlers.AddRange(customHandlers);

            delegatingHandlers.Add(new RetryHandler(new RetryHandlerOption
            {
                Delay = requestContext.RetryDelay,
                MaxRetry = requestContext.MaxRetry,
                RetriesTimeLimit = requestContext.RetriesTimeLimit
            }));
            delegatingHandlers.Add(new RedirectHandler());

            if (trailingHandlers != null)
                delegatingHandlers.AddRange(trailingHandlers);

            HttpClient httpClient = useLegacyClientHandler
                ? GraphClientFactory.Create(delegatingHandlers, finalHandler: new HttpClientHandler
                {
                    AllowAutoRedirect = false,
                    AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
                })
                : GraphClientFactory.Create(delegatingHandlers);

            httpClient.Timeout = requestContext.ClientTimeout;
            return httpClient;
        }
    }
}
