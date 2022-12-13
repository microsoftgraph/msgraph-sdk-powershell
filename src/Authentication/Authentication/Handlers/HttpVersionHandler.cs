// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Graph.PowerShell.Authentication.Handlers
{
    /// <summary>
    /// A <see cref="DelegatingHandler"/> implementation that sets HTTP version on all outgoing requests.
    /// </summary>
    internal class HttpVersionHandler : DelegatingHandler
    {
        public HttpVersionHandler()
        {
        }

        public HttpVersionHandler(HttpMessageHandler innerHandler) : base(innerHandler)
        {
        }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            request = SetHttpVersion(request);
            return base.SendAsync(request, cancellationToken);
        }

        private static HttpRequestMessage SetHttpVersion(HttpRequestMessage request)
        {
            // Default to HTTP/2. The HTTP client will fall back to HTTP/1.1 as needed.
            request.Version = new Version(2, 0);
            return request;
        }
    }
}
