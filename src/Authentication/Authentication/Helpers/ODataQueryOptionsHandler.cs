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
    public class ODataQueryOptionsHandler : DelegatingHandler
    {
        public ODataQueryOptionsHandler()
        {

        }
        public ODataQueryOptionsHandler(HttpMessageHandler innerHandler)
        {
            this.InnerHandler = innerHandler;
        }

        List<string> _standardODataQueryOptions = new List<string>
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

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
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

                UriBuilder uriBuilder = new UriBuilder(request.RequestUri);
                uriBuilder.Query = newRequestQuery;
                request.RequestUri = uriBuilder.Uri;
            }

            return base.SendAsync(request, cancellationToken);
        }
    }
}
