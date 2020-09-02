// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Graph.PowerShell
{
    /// <summary>
    /// Derived <see cref="HttpContent"/> class which can encapsulate an <see cref="HttpResponseMessage"/>
    /// or an <see cref="HttpRequestMessage"/> as an entity with media type "application/http".
    /// </summary>
    internal class HttpMessageFormatter : HttpContent
    {
        private const string SP = " ";
        private const string ColonSP = ": ";
        private const string CRLF = "\r\n";
        private const string CommaSeparator = ", ";

        private const int DefaultHeaderAllocation = 2 * 1024;

        private const string DefaultMediaType = "application/http";

        private const string MsgTypeParameter = "msgtype";
        private const string DefaultRequestMsgType = "request";
        private const string DefaultResponseMsgType = "response";

        // Set of header fields that only support single values such as Set-Cookie.
        private static readonly HashSet<string> _singleValueHeaderFields = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            "Cookie",
            "Set-Cookie",
            "X-Powered-By",
        };

        // Set of header fields that should get serialized as space-separated values such as User-Agent.
        private static readonly HashSet<string> _spaceSeparatedValueHeaderFields = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            "User-Agent",
        };

        // Set of header fields that should not get serialized
        private static readonly HashSet<string> _neverSerializedHeaderFields = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            "Authorization"
        };

        private bool _contentConsumed;
        private Lazy<Task<Stream>> _streamTask;

        /// <summary>
        /// Initializes a new instance of the <see cref="HttpMessageContent"/> class encapsulating an
        /// <see cref="HttpRequestMessage"/>.
        /// </summary>
        /// <param name="httpRequest">The <see cref="HttpResponseMessage"/> instance to encapsulate.</param>
        public HttpMessageFormatter(HttpRequestMessage httpRequest)
        {
            HttpRequestMessage = httpRequest ?? throw new ArgumentNullException(nameof(httpRequest));
            Headers.ContentType = new MediaTypeHeaderValue(DefaultMediaType);
            Headers.ContentType.Parameters.Add(new NameValueHeaderValue(MsgTypeParameter, DefaultRequestMsgType));

            InitializeStreamTask();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HttpMessageContent"/> class encapsulating an
        /// <see cref="HttpResponseMessage"/>.
        /// </summary>
        /// <param name="httpResponse">The <see cref="HttpResponseMessage"/> instance to encapsulate.</param>
        public HttpMessageFormatter(HttpResponseMessage httpResponse)
        {
            HttpResponseMessage = httpResponse ?? throw new ArgumentNullException(nameof(httpResponse));
            Headers.ContentType = new MediaTypeHeaderValue(DefaultMediaType);
            Headers.ContentType.Parameters.Add(new NameValueHeaderValue(MsgTypeParameter, DefaultResponseMsgType));

            InitializeStreamTask();
        }

        private HttpContent Content
        {
            get { return HttpRequestMessage != null ? HttpRequestMessage.Content : HttpResponseMessage.Content; }
        }

        /// <summary>
        /// Gets the HTTP request message.
        /// </summary>
        public HttpRequestMessage HttpRequestMessage { get; private set; }

        /// <summary>
        /// Gets the HTTP response message.
        /// </summary>
        public HttpResponseMessage HttpResponseMessage { get; private set; }

        private void InitializeStreamTask()
        {
            _streamTask = new Lazy<Task<Stream>>(() => Content?.ReadAsStreamAsync());
        }

        /// <summary>
        /// Validates whether the content contains an HTTP Request or an HTTP Response.
        /// </summary>
        /// <param name="content">The content to validate.</param>
        /// <param name="isRequest">if set to <c>true</c> if the content is either an HTTP Request or an HTTP Response.</param>
        /// <param name="throwOnError">Indicates whether validation failure should result in an <see cref="Exception"/> or not.</param>
        /// <returns><c>true</c> if content is either an HTTP Request or an HTTP Response</returns>
        internal static bool ValidateHttpMessageContent(HttpContent content, bool isRequest, bool throwOnError)
        {
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            MediaTypeHeaderValue contentType = content.Headers.ContentType;
            if (contentType != null)
            {
                if (!contentType.MediaType.Equals(DefaultMediaType, StringComparison.OrdinalIgnoreCase))
                {
                    if (throwOnError)
                    {
                        throw new ArgumentException("HttpMessageInvalidMediaType", nameof(content));
                    }
                    else
                    {
                        return false;
                    }
                }

                foreach (NameValueHeaderValue parameter in contentType.Parameters)
                {
                    if (parameter.Name.Equals(MsgTypeParameter, StringComparison.OrdinalIgnoreCase))
                    {
                        string msgType = UnquoteToken(parameter.Value);
                        if (!msgType.Equals(isRequest ? DefaultRequestMsgType : DefaultResponseMsgType, StringComparison.OrdinalIgnoreCase))
                        {
                            if (throwOnError)
                            {
                                throw new ArgumentException("HttpMessageInvalidMediaType", nameof(content));
                            }
                            else
                            {
                                return false;
                            }
                        }

                        return true;
                    }
                }
            }

            if (throwOnError)
            {
                throw new ArgumentException("HttpMessageInvalidMediaType", nameof(content));
            }
            else
            {
                return false;
            }
        }


        public static string UnquoteToken(string token)
        {
            if (String.IsNullOrWhiteSpace(token))
            {
                return token;
            }

            if (token.StartsWith("\"", StringComparison.Ordinal) && token.EndsWith("\"", StringComparison.Ordinal) && token.Length > 1)
            {
                return token.Substring(1, token.Length - 2);
            }

            return token;
        }


        /// <summary>
        /// Asynchronously serializes the object's content to the given <paramref name="stream"/>.
        /// </summary>
        /// <param name="stream">The <see cref="Stream"/> to which to write.</param>
        /// <param name="context">The associated <see cref="TransportContext"/>.</param>
        /// <returns>A <see cref="Task"/> instance that is asynchronously serializing the object's content.</returns>
        protected override async Task SerializeToStreamAsync(Stream stream, TransportContext context)
        {
            if (stream == null)
            {
                throw new ArgumentNullException(nameof(stream));
            }

            byte[] header = SerializeHeader();
            await stream.WriteAsync(header, 0, header.Length);

            if (Content != null)
            {
                Stream readStream = await _streamTask.Value;
                ValidateStreamForReading(readStream);
                await Content.CopyToAsync(stream);
            }
        }

        /// <summary>
        /// Computes the length of the stream if possible.
        /// </summary>
        /// <param name="length">The computed length of the stream.</param>
        /// <returns><c>true</c> if the length has been computed; otherwise <c>false</c>.</returns>
        protected override bool TryComputeLength(out long length)
        {
            // We have four states we could be in:
            //   1. We have content, but the task is still running or finished without success
            //   2. We have content, the task has finished successfully, and the stream came back as a null or non-seekable
            //   3. We have content, the task has finished successfully, and the stream is seekable, so we know its length
            //   4. We don't have content (streamTask.Value == null)
            //
            // For #1 and #2, we return false.
            // For #3, we return true & the size of our headers + the content length
            // For #4, we return true & the size of our headers

            bool hasContent = _streamTask.Value != null;
            length = 0;

            // Cases #1, #2, #3
            // We serialize header to a StringBuilder so that we can determine the length
            // following the pattern for HttpContent to try and determine the message length.
            // The perf overhead is no larger than for the other HttpContent implementations.
            byte[] header = SerializeHeader();
            length += header.Length;
            return true;
        }

        /// <summary>
        /// Serializes the HTTP request line.
        /// </summary>
        /// <param name="message">Where to write the request line.</param>
        /// <param name="httpRequest">The HTTP request.</param>
        private static void SerializeRequestLine(StringBuilder message, HttpRequestMessage httpRequest)
        {
            Contract.Assert(message != null, "message cannot be null");
            message.Append(httpRequest.Method + SP);
            message.Append(httpRequest.RequestUri.PathAndQuery + SP);
            message.Append($"HTTP/{(httpRequest.Version != null ? httpRequest.Version.ToString(2) : "1.1")}{CRLF}");

            // Only insert host header if not already present.
            if (httpRequest.Headers.Host == null)
            {
                message.Append($"HTTP{ColonSP}{httpRequest.RequestUri.Authority}{CRLF}");
            }
        }

        /// <summary>
        /// Serializes the HTTP status line.
        /// </summary>
        /// <param name="message">Where to write the status line.</param>
        /// <param name="httpResponse">The HTTP response.</param>
        private static void SerializeStatusLine(StringBuilder message, HttpResponseMessage httpResponse)
        {
            Contract.Assert(message != null, "message cannot be null");
            message.Append($"HTTP/{(httpResponse.Version != null ? httpResponse.Version.ToString(2) : "1.1")}{SP}");
            message.Append((int)httpResponse.StatusCode + SP);
            message.Append(httpResponse.ReasonPhrase + CRLF);
        }

        /// <summary>
        /// Serializes the header fields.
        /// </summary>
        /// <param name="message">Where to write the status line.</param>
        /// <param name="headers">The headers to write.</param>
        private static void SerializeHeaderFields(StringBuilder message, HttpHeaders headers)
        {
            Contract.Assert(message != null, "message cannot be null");
            if (headers != null)
            {
                foreach (KeyValuePair<string, IEnumerable<string>> header in headers)
                {
                    if (_neverSerializedHeaderFields.Contains(header.Key))
                    {
                        continue;
                    }
                    if (_singleValueHeaderFields.Contains(header.Key))
                    {
                        foreach (string value in header.Value)
                        {
                            message.Append(header.Key + ColonSP + value + CRLF);
                        }
                    }
                    else if (_spaceSeparatedValueHeaderFields.Contains(header.Key))
                    {
                        message.Append(header.Key + ColonSP + String.Join(SP, header.Value) + CRLF);
                    }
                    else
                    {
                        message.Append(header.Key + ColonSP + String.Join(CommaSeparator, header.Value) + CRLF);
                    }
                }
            }
        }

        private byte[] SerializeHeader()
        {
            StringBuilder message = new StringBuilder(DefaultHeaderAllocation);
            HttpHeaders headers;
            HttpContent content;
            if (HttpRequestMessage != null)
            {
                SerializeRequestLine(message, HttpRequestMessage);
                headers = HttpRequestMessage.Headers;
                content = HttpRequestMessage.Content;
            }
            else
            {
                SerializeStatusLine(message, HttpResponseMessage);
                headers = HttpResponseMessage.Headers;
                content = HttpResponseMessage.Content;
            }

            SerializeHeaderFields(message, headers);
            if (content != null)
            {
                SerializeHeaderFields(message, content.Headers);
            }

            message.Append(CRLF);
            return Encoding.UTF8.GetBytes(message.ToString());
        }

        private void ValidateStreamForReading(Stream stream)
        {
            // If the content needs to be written to a target stream a 2nd time, then the stream must support
            // seeking (e.g. a FileStream), otherwise the stream can't be copied a second time to a target 
            // stream (e.g. a NetworkStream).
            if (_contentConsumed)
            {
                if (stream != null && stream.CanRead)
                {
                    stream.Position = 0;
                }
                else
                {
                    throw new InvalidOperationException("HttpMessageContentAlreadyRead");
                }
            }

            _contentConsumed = true;
        }
    }
}