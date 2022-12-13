// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using Microsoft.Graph.PowerShell.Authentication.Cmdlets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Graph.PowerShell.Authentication.Handlers
{
    /// <summary>
    /// A <see cref="DelegatingHandler"/> implementation that sets specified request headers all outgoing requests.
    /// </summary>
    /// 
    internal class RequestHeaderHandler : DelegatingHandler
    {
        /// The version for current assembly.
        private static readonly AssemblyName _assemblyInfo = typeof(ConnectMgGraph).GetTypeInfo().Assembly.GetName();

        public RequestHeaderHandler() { }

        public RequestHeaderHandler(HttpRequestHeaders requestHeaders, HttpMessageHandler innerHandler) : base(innerHandler) { }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            SetRequestHeaders(request);
            return base.SendAsync(request, cancellationToken);
        }

        private static void SetRequestHeaders(HttpRequestMessage request)
        {
            string sdkVersionHeaderValue = string.Format(request.RequestUri.AbsolutePath.StartsWith("/beta") ? Constants.PSSDKHeaderValueBeta : Constants.PSSDKHeaderValueV1, _assemblyInfo.Version.Major, _assemblyInfo.Version.Minor, _assemblyInfo.Version.Build);
            PrependHeader(request, CoreConstants.Headers.SdkVersionHeaderName, sdkVersionHeaderValue);
        }

        private static void PrependHeader(HttpRequestMessage request, string headerName, string headerValue)
        {
            if (request.Headers.TryGetValues(headerName, out IEnumerable<string> previousSDKHeaders))
            {
                request.Headers.Remove(headerName);
                request.Headers.Add(headerName, new[] {
                    headerValue, previousSDKHeaders.Where(h => h.StartsWith(Constants.DotNetSDKHeaderValue, StringComparison.InvariantCultureIgnoreCase)).FirstOrDefault()
                });
            }
            else
            {
                request.Headers.Add(headerName, headerValue);
            }
        }
    }
}
