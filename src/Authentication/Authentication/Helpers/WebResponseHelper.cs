// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Microsoft.Graph.PowerShell.Authentication.Helpers
{
    internal static class WebResponseHelper
    {
        internal static Dictionary<string, IEnumerable<string>> GetHttpResponseHeaders(this HttpResponseMessage response)
        {
            var headers = new Dictionary<string, IEnumerable<string>>(StringComparer.OrdinalIgnoreCase);
            foreach (var entry in response.Headers)
            {
                headers[entry.Key] = entry.Value;
            }

            // In CoreFX, HttpResponseMessage separates content related headers, such as Content-Type to
            // HttpResponseMessage.Content.Headers. The remaining headers are in HttpResponseMessage.Headers.
            // The keys in both should be unique with no duplicates between them.
            // Added for backwards compatibility with PowerShell 5.1 and earlier.
            if (response.Content != null)
            {
                foreach (var entry in response.Content.Headers)
                {
                    headers[entry.Key] = entry.Value;
                }
            }

            return headers;
        }

        /// <summary>
        /// Clones an HttpRequestMessage (without the content)
        /// </summary>
        /// <param name="original">Original HttpRequestMessage (Will be diposed before returning)</param>
        /// <param name="requestUri"></param>
        /// <param name="method"></param>
        /// <returns>A clone of the HttpRequestMessage</returns>
        private static HttpRequestMessage CloneHttpRequest(this HttpRequestMessage original, Uri requestUri = null, HttpMethod method = null)
        {
            var clone = new HttpRequestMessage
            {
                Method = method ?? original.Method,
                RequestUri = requestUri ?? original.RequestUri,
                Version = original.Version,
            };

            foreach (var prop in original.Properties)
            {
                clone.Properties.Add(prop);
            }

            foreach (var header in original.Headers)
            {
                /*
                **temporarily skip cloning telemetry related headers**
                clone.Headers.TryAddWithoutValidation(header.Key, header.Value);
                */
                if (!"x-ms-unique-id".Equals(header.Key) && !"x-ms-client-request-id".Equals(header.Key) && !"CommandName".Equals(header.Key) && !"FullCommandName".Equals(header.Key) && !"ParameterSetName".Equals(header.Key) && !"User-Agent".Equals(header.Key))
                {
                    clone.Headers.TryAddWithoutValidation(header.Key, header.Value);
                }
            }

            return clone;
        }

        /// <summary>
        /// Clones an HttpRequestMessage (including the content stream and content headers) 
        /// </summary>
        /// <param name="original">Original HttpRequestMessage (Will be diposed before returning)</param>
        /// <param name="requestUri"></param>
        /// <param name="method"></param>
        /// <returns>A clone of the HttpRequestMessage</returns>
        private static async Task<HttpRequestMessage> CloneHttpRequestWithContent(this HttpRequestMessage original, Uri requestUri = null, HttpMethod method = null)
        {
            var clone = original.CloneHttpRequest(requestUri, method);
            var stream = new System.IO.MemoryStream();
            if (original.Content != null)
            {
                await original.Content.CopyToAsync(stream).ConfigureAwait(false);
                stream.Position = 0;
                clone.Content = new StreamContent(stream);
                if (original.Content.Headers != null)
                {
                    foreach (var h in original.Content.Headers)
                    {
                        clone.Content.Headers.Add(h.Key, h.Value);
                    }
                }
            }
            return clone;
        }

        /// <summary>
        /// Clones a HttpRequestMessage contained in a corresponding HttpResponseMessage (including the content stream and content headers) 
        /// </summary>
        /// <param name="original">Original HttpRequestMessage (Will be disposed before returning)</param>
        /// <param name="requestUri"></param>
        /// <param name="method"></param>
        /// <returns>A clone of the HttpRequestMessage</returns>
        internal static Task<HttpRequestMessage> CloneHttpRequestWithContent(this HttpResponseMessage original,
            Uri requestUri = null, HttpMethod method = null)
        {
            return original.RequestMessage.CloneHttpRequestWithContent(requestUri, method);
        }
        /// <summary>
        /// Clones a HttpRequestMessage contained in a corresponding HttpResponseMessage
        /// </summary>
        /// <param name="original">Original HttpRequestMessage (Will be disposed before returning)</param>
        /// <param name="requestUri"></param>
        /// <param name="method"></param>
        /// <returns>A clone of the HttpRequestMessage</returns>
        internal static HttpRequestMessage CloneHttpRequest(this HttpResponseMessage original, Uri requestUri = null,
            HttpMethod method = null)
        {
            return original.RequestMessage.CloneHttpRequest(requestUri, method);
        }
    }
}