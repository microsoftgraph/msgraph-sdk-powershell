// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Extensions;

namespace Microsoft.Graph.PowerShell.Authentication.Extensions
{
    internal static class HttpRequestMessageExtensions
    {
        /// <summary>
        /// Create a new HTTP request by copying previous HTTP request's headers and properties from response's request message.
        /// </summary>
        /// <param name="originalRequest">The previous <see cref="HttpRequestMessage"/> needs to be copy.</param>
        /// <returns>The <see cref="HttpRequestMessage"/>.</returns>
        /// <remarks>
        /// Re-issue a new HTTP request with the previous request's headers and properities
        /// </remarks>
        internal static async Task<HttpRequestMessage> CloneAsync(this HttpRequestMessage originalRequest)
        {
            var newRequest = new HttpRequestMessage(originalRequest.Method, originalRequest.RequestUri);

            // Copy request headers.
            foreach (var header in originalRequest.Headers)
                newRequest.Headers.TryAddWithoutValidation(header.Key, header.Value);

            // Copy request properties.
#if NET5_0_OR_GREATER
            foreach(var property in originalRequest.Options)
                if(property.Value is IRequestOption requestOption)
                    newRequest.Options.Set(new HttpRequestOptionsKey<IRequestOption>(property.Key), requestOption);
                else
                    newRequest.Options.Set(new HttpRequestOptionsKey<object>(property.Key), property.Value);
#else
            foreach(var property in originalRequest.Properties)
                newRequest.Properties.TryAdd(property.Key, property.Value);
#endif
            // Set Content if previous request had one.
            if (originalRequest.Content != null)
            {
                // HttpClient doesn't rewind streams and we have to explicitly do so.
                await originalRequest.Content.ReadAsStreamAsync().ContinueWith(t =>
                {
                    if (t.Result.CanSeek)
                        t.Result.Seek(0, SeekOrigin.Begin);
                    newRequest.Content = new StreamContent(t.Result);
                }).ConfigureAwait(false);

                // Copy content headers.
                if (originalRequest.Content.Headers != null)
                    foreach (var contentHeader in originalRequest.Content.Headers)
                        newRequest.Content.Headers.TryAddWithoutValidation(contentHeader.Key, contentHeader.Value);
            }

            return newRequest;
        }

        /// <summary>
        /// Checks the HTTP request's content to determine if it's buffered or streamed content.
        /// </summary>
        /// <param name="httpRequestMessage">The <see cref="HttpRequestMessage"/>needs to be sent.</param>
        /// <returns></returns>
        internal static bool IsBuffered(this HttpRequestMessage httpRequestMessage)
        {
            HttpContent requestContent = httpRequestMessage.Content;

            if ((httpRequestMessage.Method == HttpMethod.Put || httpRequestMessage.Method == HttpMethod.Post || httpRequestMessage.Method.Method.Equals("PATCH"))
                && requestContent != null && (requestContent.Headers.ContentLength == null || (int)requestContent.Headers.ContentLength == -1))
            {
                return false;
            }
            return true;
        }
    }
}