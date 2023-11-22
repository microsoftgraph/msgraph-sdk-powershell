// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System;
using System.Text;

namespace Microsoft.Graph.PowerShell.Authentication.Helpers
{
    /// <summary>
    /// Escape data string/url encode Uris that have paths containing special characters like #.
    /// For a path like /beta/users/first.last_foo.com#EXT#@contoso.onmicrosoft.com, the last segment contains special characters that need to be escaped
    /// </summary>
    public static class EncodeUriPaths
    {
        public static Uri EscapeDataStrings(this Uri uri)
        {
            int counter = 0;
            var pathSegments = uri.OriginalString.Split('/');
            StringBuilder sb = new StringBuilder();
            foreach (var segment in pathSegments)
            {
                //Skips the left part of the uri i.e https://graph.microsoft.com
                if (counter > 2)
                {
                    sb.Append("/" + Uri.EscapeDataString(segment));
                }
                counter++;
            }
            Uri escapedUri = new Uri(uri.GetLeftPart(UriPartial.Authority) + sb.ToString());
            return escapedUri;
        }
    }
}