// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------


using System;
using System.Collections;
using System.Globalization;
using System.Net;
using System.Text;
using Microsoft.Graph.PowerShell.Authentication.Properties;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Microsoft.Graph.PowerShell.Authentication.Helpers
{
    internal static class StringUtil
    {
        /// <summary>
        ///     Formats the specified string, using the current culture.
        /// </summary>
        /// <param name="formatSpec"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        internal static string FormatCurrentCulture(this string formatSpec, params object[] args)
        {
            return string.Format(CultureInfo.CurrentCulture, formatSpec, args);
        }

        /// <summary>
        ///     Formats a Dictionary into a UrlEncoded string
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

        /// <summary>
        ///     Convert json string to object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="jsonString"></param>
        /// <param name="obj"></param>
        /// <param name="exRef"></param>
        /// <returns></returns>
        internal static bool TryConvert<T>(this string jsonString, out object obj, ref Exception exRef)
        {
            var converted = false;
            try
            {
                obj = JsonConvert.DeserializeObject<T>(jsonString);
                if (obj == null)
                {
                    JToken.Parse(jsonString);
                }
                else
                {
                    converted = true;
                }
            }
            catch (JsonException ex)
            {
                var msg = Resources.JsonSerializationFailed.FormatCurrentCulture(ex.Message);
                exRef = new ArgumentException(msg, ex);
                obj = default;
            }
            catch (Exception jsonParseException)
            {
                exRef = jsonParseException;
                obj = default;
            }

            return converted;
        }
    }
}