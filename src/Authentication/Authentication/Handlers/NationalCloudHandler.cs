// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.PowerShell.Authentication.Handlers
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    internal class NationalCloudHandler : DelegatingHandler
    {
        /// <summary>
        /// Creates a new <see cref="NationalCloudHandler"/>.
        /// </summary>
        public NationalCloudHandler()
        {

        }

        /// <summary>
        /// Creates a new <see cref="NationalCloudHandler"/>.
        /// </summary>
        /// <param name="innerHandler">Optional <see cref="HttpMessageHandler"/> to be called after <see cref="NationalCloudHandler"/>.</param>
        public NationalCloudHandler(HttpMessageHandler innerHandler)
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
            request = SetNationalCloudEndpoint(request);
            return base.SendAsync(request, cancellationToken);
        }

        /// <summary>
        /// Sets national cloud to the outgoing HttpRequestMessage.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        private HttpRequestMessage SetNationalCloudEndpoint(HttpRequestMessage request)
        {
            if (GraphSession.Instance.Environment != null)
            {
                Uri baseUri = new Uri(GraphSession.Instance.Environment.GraphEndpoint);
                Uri requestUri = new Uri(baseUri, request.RequestUri.PathAndQuery);

                request.RequestUri = requestUri;
            }

            return request;
        }
    }
}
