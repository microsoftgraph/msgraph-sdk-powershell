// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Graph.PowerShell.Authentication.Handlers
{
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
        //TODO: Add unit test.
        private HttpRequestMessage SetHttpVersion(HttpRequestMessage request)
        {
            request.Version = new Version(2, 0); // default to HTTP/2. The HTTP client fall back to HTTP/1.1 as needed.
            return request;
        }
    }
}
