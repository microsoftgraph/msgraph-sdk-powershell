// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.PowerShell.Authentication.Extensions
{
    using System;
    internal static class StringExtensions
    {
        /// <summary>
        /// Indicates whether a specified string is null, empty, consists only of white-space, or has the specified search value.
        /// </summary>
        /// <param name="target">The target string to look in.</param>
        /// <param name="searchValue">The substring to seek.</param>
        /// <param name="comparison">The <see cref="StringComparison"/> to use. This defaults to <see cref="StringComparison.OrdinalIgnoreCase"/>.</param>
        /// <returns>true if the searchValue parameter occurs within this string; otherwise, false.</returns>
        public static bool ContainsValue(this string target, string searchValue, StringComparison comparison = StringComparison.OrdinalIgnoreCase)
        {
            if (string.IsNullOrWhiteSpace(target) || string.IsNullOrWhiteSpace(searchValue))
            {
                return false;
            }

            switch (comparison)
            {
                case StringComparison.CurrentCultureIgnoreCase:
                case StringComparison.OrdinalIgnoreCase:
                    target = target.ToLower();
                    searchValue = searchValue.ToLower();
                    break;
                case StringComparison.InvariantCultureIgnoreCase:
                    target = target.ToLowerInvariant();
                    searchValue = searchValue.ToLowerInvariant();
                    break;
            }

            return target.Contains(searchValue);
        }

        /// <summary>
        /// Gets the base URL of a URL string.
        /// </summary>
        /// <param name="url">A URL string to get its base URL (Authority).</param>
        public static string GetBaseUrl(this string url)
        {
            Uri uri = new Uri(url);
            return uri.GetLeftPart(UriPartial.Authority);
        }
    }
}
