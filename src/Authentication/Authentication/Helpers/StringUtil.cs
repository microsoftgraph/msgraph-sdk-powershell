using System;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.Management.Automation.Host;
using System.Net;
using System.Text;
using System.Threading;

namespace Microsoft.Graph.PowerShell.Authentication.Helpers
{
    internal static class StringUtil
    {
        internal static string FormatCurrentCulture(string formatSpec, params object[] args)
        {
            return string.Format(CultureInfo.CurrentCulture, formatSpec, args);
        }
        /// <summary>
        /// Formats a Dictionary into a UrlEncoded string
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        internal static string FormatDictionary(this IDictionary content)
        {
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            var bodyBuilder = new StringBuilder();
            foreach (string key in content.Keys)
            {
                if (0 < bodyBuilder.Length)
                {
                    bodyBuilder.Append("&");
                }

                var value = content[key];

                // URLEncode the key and value
                var encodedKey = WebUtility.UrlEncode(key);
                var encodedValue = string.Empty;
                if (value != null)
                {
                    encodedValue = WebUtility.UrlEncode(value.ToString());
                }

                bodyBuilder.AppendFormat("{0}={1}", encodedKey, encodedValue);
            }

            return bodyBuilder.ToString();
        }

    }

}