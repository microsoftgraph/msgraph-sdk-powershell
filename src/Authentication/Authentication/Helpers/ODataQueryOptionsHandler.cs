// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.PowerShell.Authentication.Helpers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// A <see cref="DelegatingHandler"/> implementation that is used to properly format OData query parameters.
    /// </summary>
    public class ODataQueryOptionsHandler : DelegatingHandler
    {
        private List<string> _standardODataQueryOptions = new List<string>
        {
            "count",
            "expand",
            "filter",
            "format",
            "orderby",
            "search",
            "select",
            "skip",
            "top"
        };

        /// <summary>
        /// Creates a new <see cref="ODataQueryOptionsHandler"/>.
        /// </summary>
        public ODataQueryOptionsHandler()
        {

        }

        /// <summary>
        /// Creates a new <see cref="ODataQueryOptionsHandler"/>.
        /// </summary>
        /// <param name="innerHandler">Optional <see cref="HttpMessageHandler"/> to be called after <see cref="ODataQueryOptionsHandler"/>.</param>
        public ODataQueryOptionsHandler(HttpMessageHandler innerHandler)
        {
            this.InnerHandler = innerHandler;
        }

        /// <summary>
        /// Sends the <see cref="HttpRequestMessage"/>.
        /// </summary>
        /// <param name="request">The request to send.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns></returns>
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            request = AddDollarSignToQueryParameters(request);
            return base.SendAsync(request, cancellationToken);
        }

        /// <summary>
        /// Add `$` to all standard OData query options. v1.0 endpoint requires $ to be prefixed to all OData query options.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        private HttpRequestMessage AddDollarSignToQueryParameters(HttpRequestMessage request)
        {
            if (request.RequestUri.Segments[1].ToLower().Contains("v1.0") && request.RequestUri.Query != null)
            {
                string newRequestQuery = request.RequestUri.Query;
                string[] querySegments = newRequestQuery.Split(new char[] { '&', '?' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string querySegment in querySegments)
                {
                    string targetQueryParam = querySegment.Split(new char[] { '=' }).FirstOrDefault();
                    if (_standardODataQueryOptions.Contains(targetQueryParam.ToLower()))
                        newRequestQuery = newRequestQuery.Replace(targetQueryParam, $"${targetQueryParam}");
                }

                // Remove leading question mark. NET 4.x doesn't drop the question mark when appending it to Query property of UriBuilder.
                if (newRequestQuery.Contains("?"))
                {
                    newRequestQuery = newRequestQuery.Split('?')[1];
                }
                UriBuilder uriBuilder = new UriBuilder(request.RequestUri)
                {
                    Query = newRequestQuery
                };
                request.RequestUri = uriBuilder.Uri;
            }

            return request;
        }
    }
}
