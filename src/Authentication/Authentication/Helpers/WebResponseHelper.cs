// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Net.Http;

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
    }
}