// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
        private static readonly AssemblyName _assemblyInfo = typeof(RequestHeaderHandler).GetTypeInfo().Assembly.GetName();

        public RequestHeaderHandler() { }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            string psSdkVersionHeader = string.Format(request.RequestUri.AbsolutePath.StartsWith("/beta") ? Constants.PSSDKHeaderValueBeta
                : Constants.PSSDKHeaderValueV1, _assemblyInfo.Version.Major, _assemblyInfo.Version.Minor, _assemblyInfo.Version.Build);
            if (request.Headers.TryGetValues(CoreConstants.Headers.SdkVersionHeaderName, out IEnumerable<string> previousSDKHeaders))
            {
                var dotNetSdkHeader = previousSDKHeaders.Where(h => h.StartsWith(Constants.DotNetSDKHeaderValue, StringComparison.InvariantCultureIgnoreCase)).FirstOrDefault();
                request.Headers.Remove(CoreConstants.Headers.SdkVersionHeaderName);
                request.Headers.Add(CoreConstants.Headers.SdkVersionHeaderName, new[] { psSdkVersionHeader, dotNetSdkHeader });
            }
            else
            {
                request.Headers.Add(CoreConstants.Headers.SdkVersionHeaderName, psSdkVersionHeader);
            }

            if (request.Headers.Contains(CoreConstants.Headers.ClientRequestId))
                request.Headers.Remove(CoreConstants.Headers.ClientRequestId);
            request.Headers.Add(CoreConstants.Headers.ClientRequestId, Guid.NewGuid().ToString());

            return base.SendAsync(request, cancellationToken);
        }
    }
}
