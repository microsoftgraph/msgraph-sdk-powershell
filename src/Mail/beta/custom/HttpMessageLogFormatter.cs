// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.Beta.PowerShell
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;
    using System.Xml.Linq;

    public static class HttpMessageLogFormatter
    {
        internal static async Task<HttpRequestMessage> CloneAsync(this HttpRequestMessage originalRequest)
        {
            var newRequest = new HttpRequestMessage(originalRequest.Method, originalRequest.RequestUri);

            // Copy requestClone headers.
            foreach (var header in originalRequest.Headers)
                newRequest.Headers.TryAddWithoutValidation(header.Key, header.Value);

            // Copy requestClone properties.
            foreach (var property in originalRequest.Properties)
                newRequest.Properties.Add(property);

            // Set Content if previous requestClone had one.
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

        public static async Task<string> GetHttpRequestLogAsync(HttpRequestMessage request)
        {
            if (request == null) return string.Empty;
            var requestClone = await request.CloneAsync().ConfigureAwait(false);
            string body = string.Empty;
            try
            {
                body = (requestClone.Content == null) ? string.Empty : FormatString(await requestClone.Content.ReadAsStringAsync());
            }
            catch { }

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"============================ HTTP REQUEST ============================{Environment.NewLine}");
            stringBuilder.AppendLine($"HTTP Method:{Environment.NewLine}{requestClone.Method.ToString()}{Environment.NewLine}");
            stringBuilder.AppendLine($"Absolute Uri:{Environment.NewLine}{requestClone.RequestUri.ToString()}{Environment.NewLine}");
            stringBuilder.AppendLine($"Headers:{Environment.NewLine}{HeadersToString(ConvertHttpHeadersToCollection(requestClone.Headers))}{Environment.NewLine}");
            stringBuilder.AppendLine($"Body:{Environment.NewLine}{SanitizeBody(body)}{Environment.NewLine}");
            return stringBuilder.ToString();
        }

        public static async Task<string> GetHttpResponseLogAsync(HttpResponseMessage response)
        {
            if (response == null) return string.Empty;

            string body = string.Empty;
            try
            {
                body = (response.Content == null) ? string.Empty : FormatString(await response.Content.ReadAsStringAsync());
            }
            catch { }

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"============================ HTTP RESPONSE ============================{Environment.NewLine}");
            stringBuilder.AppendLine($"Status Code:{Environment.NewLine}{response.StatusCode}{Environment.NewLine}");
            stringBuilder.AppendLine($"Headers:{Environment.NewLine}{HeadersToString(ConvertHttpHeadersToCollection(response.Headers))}{Environment.NewLine}");
            stringBuilder.AppendLine($"Body:{Environment.NewLine}{SanitizeBody(body)}{Environment.NewLine}");
            return stringBuilder.ToString();
        }

        private static Regex regexPattern = new Regex("(\\s*\"access_token\"\\s*:\\s*)\"[^\"]+\"", RegexOptions.Compiled);
        private static object SanitizeBody(string body)
        {
            IList<Regex> regexList = new List<Regex>();
            // Remove access_token:*  instances in body.
            regexList.Add(regexPattern);

            foreach (Regex matcher in regexList)
            {
                body = matcher.Replace(body, "$1\"<redacted>\"");
            }

            return body;
        }

        private static IDictionary<string, IEnumerable<string>> ConvertHttpHeadersToCollection(HttpHeaders headers)
        {
            headers.Remove("Authorization");
            return headers.ToDictionary(a => a.Key, a => a.Value);
        }

        private static object HeadersToString(IDictionary<string, IEnumerable<string>> headers)
        {
            StringBuilder stringBuilder = headers.Aggregate(new StringBuilder(),
                (sb, kvp) => sb.AppendLine(string.Format("{0,-30}: {1}", kvp.Key, String.Join(",", kvp.Value.ToArray()))));

            if (stringBuilder.Length > 0)
                stringBuilder.Remove(stringBuilder.Length - 2, 2);

            return stringBuilder.ToString();
        }

        private static string FormatString(string content)
        {
            try
            {
                content = content.Trim();
                if ((content.StartsWith("{") && content.EndsWith("}")) || // object
                    (content.StartsWith("[") && content.EndsWith("]"))) // array
                {
                    return JsonConvert.SerializeObject(JsonConvert.DeserializeObject(content), Formatting.Indented);
                }
                if (content.StartsWith("<"))
                {
                    return XDocument.Parse(content).ToString();
                }
            }
            catch
            {
                return content;
            }

            if (content.Length > Microsoft.Graph.PowerShell.Authentication.Constants.MaxContentLength)
            {
                return content.Substring(0, Microsoft.Graph.PowerShell.Authentication.Constants.MaxContentLength) + "\r\nDATA TRUNCATED DUE TO SIZE\r\n";
            }

            return content;
        }
    }
}
