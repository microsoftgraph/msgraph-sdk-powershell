using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using Microsoft.Graph.PowerShell.Authentication.Cmdlets;

namespace Microsoft.Graph.PowerShell.Authentication.Helpers
{
    internal static class WebResponseHelper
    {
        internal static string GetCharacterSet(this HttpResponseMessage response)
        {
            var characterSet = response.Content.Headers.ContentType.CharSet;
            return characterSet;
        }

        internal static Dictionary<string, IEnumerable<string>> GetHeadersDictionary(this HttpResponseMessage response)
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

        internal static string GetProtocol(this HttpResponseMessage response)
        {
            var protocol = string.Format(CultureInfo.InvariantCulture,
                "HTTP/{0}", response.Version);
            return protocol;
        }

        internal static int GetStatusCode(this HttpResponseMessage response)
        {
            var statusCode = (int) response.StatusCode;
            return statusCode;
        }

        internal static string GetStatusDescription(this HttpResponseMessage response)
        {
            var statusDescription = response.StatusCode.ToString();
            return statusDescription;
        }

        internal static bool IsText(this HttpResponseMessage response)
        {
            // ContentType may not exist in response header.
            var contentType = response.Content.Headers.ContentType?.MediaType;
            return ContentHelper.IsText(contentType);
        }
    }
}