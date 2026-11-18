// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------
using Microsoft.Graph.PowerShell.Authentication.Core.Http;
using Microsoft.Graph.PowerShell.Authentication.Handlers;
using System.Net.Http;

namespace Microsoft.Graph.PowerShell.Authentication.Helpers
{
    /// <summary>
    /// A HTTP helper class.
    /// </summary>
    /// <remarks>
    /// This type is compiled into the cmdlet assembly which lives in the default AssemblyLoadContext.
    /// It must therefore only deal in BCL types and types owned by Microsoft.Graph.Authentication.Core;
    /// all Microsoft.Graph.Core / Kiota / Azure.Identity wiring happens inside <see cref="GraphHttpClientFactory"/>.
    /// </remarks>
    public static class HttpHelpers
    {
        /// <summary>
        /// Creates a pre-configured Microsoft Graph <see cref="HttpClient"/>.
        /// </summary>
        /// <returns></returns>
        public static HttpClient GetGraphHttpClient()
        {
            if (GraphSession.Instance?.GraphHttpClient != null)
                return GraphSession.Instance.GraphHttpClient;

            var requestUserAgent = new RequestUserAgent(GraphSession.Instance.AuthContext?.PSHostVersion, null);

            var newHttpClient = GraphHttpClientFactory.Create(
                GraphSession.Instance.AuthContext,
                GraphSession.Instance.RequestContext,
                customHandlers: new DelegatingHandler[]
                {
                    new NationalCloudHandler(),
                    new ODataQueryOptionsHandler(),
                    new HttpVersionHandler()
                },
                trailingHandlers: new DelegatingHandler[]
                {
                    new RequestHeaderHandler() // Should always be last.
                },
                useLegacyClientHandler: !RuntimeUtils.IsPsCore());
            newHttpClient.DefaultRequestHeaders.UserAgent.ParseAdd(requestUserAgent.UserAgent);
            GraphSession.Instance.GraphHttpClient = newHttpClient;
            return newHttpClient;
        }
    }
}
