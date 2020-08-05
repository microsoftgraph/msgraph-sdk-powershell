// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
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
        internal static bool TryConvertToJson(this string jsonString, out object obj, ref Exception exRef)
        {
            var converted = false;
            try
            {
                obj = jsonString.ConvertFromJson(exception: out exRef);
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

        internal static object ConvertFromJson(this string jsonString, out Exception exception, int maxDepth = 1024)
        {
            if (jsonString == null)
            {
                throw new ArgumentNullException(nameof(jsonString));
            }
            exception = null;
            try
            {
                // If input starts with '[' (ignoring white spaces).
                if (Regex.Match(jsonString, @"^\s*\[").Success)
                {
                    // JArray.Parse() will throw a JsonException if the array is invalid.
                    // This will be caught by the catch block below, and then throw an
                    // ArgumentException - this is done to have same behavior as the JavaScriptSerializer.
                    JArray.Parse(jsonString);

                    // Please note that if the Json array is valid, we don't do anything,
                    // we just continue the deserialization.
                }
                var obj = JsonConvert.DeserializeObject(jsonString,
                    new JsonSerializerSettings
                    {
                        TypeNameHandling = TypeNameHandling.None,
                        MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                        MaxDepth = maxDepth
                    });

                switch (obj)
                {
                    case JObject dictionary:
                        // JObject is a IDictionary
                        return PopulateHashTableFromJDictionary(dictionary, out exception);
                    case JArray list:
                        return PopulateHashTableFromJArray(list, out exception);
                    default:
                        return obj;
                }
            }
            catch (JsonException ex)
            {
                var msg = Resources.JsonSerializationFailed.FormatCurrentCulture(ex.Message);
                throw new ArgumentException(msg, ex);
            }
        }

        private static ICollection<object> PopulateHashTableFromJArray(JArray list, out Exception exception)
        {
            exception = null;
            var result = new object[list.Count];

            for (var index = 0; index < list.Count; index++)
            {
                var element = list[index];

                switch (element)
                {
                    case JArray array:
                        {
                            // Array
                            var listResult = PopulateHashTableFromJArray(array, out exception);
                            if (exception != null)
                            {
                                return null;
                            }

                            result[index] = listResult;
                            break;
                        }
                    case JObject dic:
                        {
                            // Dictionary
                            var dicResult = PopulateHashTableFromJDictionary(dic, out exception);
                            if (exception != null)
                            {
                                return null;
                            }

                            result[index] = dicResult;
                            break;
                        }
                    case JValue value:
                        {
                            result[index] = value.Value;
                            break;
                        }
                }
            }

            return result;
        }

        private static Hashtable PopulateHashTableFromJDictionary(JObject entries, out Exception exception)
        {
            exception = null;
            Hashtable result = new Hashtable(entries.Count);
            foreach (var entry in entries)
            {
                // Case sensitive duplicates should normally not occur since JsonConvert.DeserializeObject
                // does not throw when encountering duplicates and just uses the last entry.
                if (result.ContainsKey(entry.Key))
                {
                    string errorMsg = Resources.DuplicateKeysInJsonString.FormatCurrentCulture(entry.Key);
                    exception = new InvalidOperationException(errorMsg);
                    return null;
                }

                switch (entry.Value)
                {
                    case JArray list:
                        {
                            // Array
                            var listResult = PopulateHashTableFromJArray(list, out exception);
                            if (exception != null)
                            {
                                return null;
                            }

                            result.Add(entry.Key, listResult);
                            break;
                        }
                    case JObject dic:
                        {
                            // Dictionary
                            var dicResult = PopulateHashTableFromJDictionary(dic, out exception);
                            if (exception != null)
                            {
                                return null;
                            }

                            result.Add(entry.Key, dicResult);
                            break;
                        }
                    case JValue value:
                        {
                            result.Add(entry.Key, value.Value);
                            break;
                        }
                }
            }

            return result;
        }
    }
}