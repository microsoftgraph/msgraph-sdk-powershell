// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using Microsoft.Graph.PowerShell.Authentication.Properties;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Management.Automation;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Microsoft.Graph.PowerShell.Authentication.Helpers
{
    public static class StringUtil
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
                    bodyBuilder.Append('&');
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


        private static readonly JsonSerializerOptions _jsonSerializerOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };
        /// <summary>
        ///     Convert a JSON string back to an object of type <see cref="PSObject"/> or
        ///     <see cref="Hashtable"/> depending on parameter <paramref name="returnHashtable"/>.
        /// </summary>
        /// <param name="jsonString">The JSON text to convert.</param>
        /// <param name="returnHashtable">True if the result should be returned as a <see cref="Hashtable"/>
        /// instead of a <see cref="PSObject"/>.</param>
        /// <param name="maxDepth">The max depth allowed when deserializing the json jsonString. Set to null for no maximum.</param>
        /// <param name="error">An error record if the conversion failed.</param>
        /// <returns>A <see cref="PSObject"/> or a <see cref="Hashtable"/>
        /// if the <paramref name="returnHashtable"/> parameter is true.</returns>
        public static object ConvertFromJson(this string jsonString, bool returnHashtable, int? maxDepth, out ErrorRecord error)
        {
            if (jsonString == null)
            {
                throw new ArgumentNullException(nameof(jsonString));
            }

            error = null;
            try
            {
                if (maxDepth != null)
                {
                    _jsonSerializerOptions.MaxDepth = maxDepth.Value;
                }
                if (returnHashtable)
                {
                    return JsonSerializer.Deserialize<Hashtable>(jsonString, _jsonSerializerOptions);
                }
                var obj = JsonSerializer.Deserialize<PSObject>(jsonString, _jsonSerializerOptions);
            }
            catch (JsonException je)
            {
                var msg = string.Format(CultureInfo.CurrentCulture, Resources.JsonDeserializationFailed, je.Message);

                // the same as JavaScriptSerializer does
                throw new ArgumentException(msg, je);
            }
        }

        private class DuplicateMemberHashSet : HashSet<string>
        {
            public DuplicateMemberHashSet()
                : base(StringComparer.OrdinalIgnoreCase)
            {
            }

            public bool TryGetValue(string entryKey, out string entry)
            {
                entry = this.FirstOrDefault(x => x == entryKey);
                return entry != null;
            }
        }

        private static PSObject PopulateFromJDictionary(JObject entries, DuplicateMemberHashSet memberHashTracker, out ErrorRecord error)
        {
            error = null;
            var result = new PSObject();
            foreach (var entry in entries)
            {
                if (string.IsNullOrEmpty(entry.Key))
                {
                    var errorMsg = string.Format(CultureInfo.CurrentCulture, Resources.EmptyKeyInJsonString);
                    error = new ErrorRecord(
                        new InvalidOperationException(errorMsg),
                        ErrorConstants.Codes.InvokeGraphRequestEmptyKeyInJsonString,
                        ErrorCategory.InvalidOperation,
                        null);
                    return null;
                }

                // Case sensitive duplicates should normally not occur since JsonConvert.DeserializeObject
                // does not throw when encountering duplicates and just uses the last entry.
                if (memberHashTracker.TryGetValue(entry.Key, out var maybePropertyName)
                    && string.Equals(entry.Key, maybePropertyName, StringComparison.Ordinal))
                {
                    var errorMsg = string.Format(CultureInfo.CurrentCulture, Resources.DuplicateKeysInJsonString, entry.Key);
                    error = new ErrorRecord(
                        new InvalidOperationException(errorMsg),
                        ErrorConstants.Codes.InvokeGraphRequestDuplicateKeysInJsonString,
                        ErrorCategory.InvalidOperation,
                        null);
                    return null;
                }

                // Compare case insensitive to tell the user to use the -OutputType HashTable option instead.
                // This is because PSObject cannot have keys with different casing.
                if (memberHashTracker.TryGetValue(entry.Key, out var propertyName))
                {
                    var errorMsg = string.Format(CultureInfo.CurrentCulture, Resources.KeysWithDifferentCasingInJsonString, propertyName, entry.Key);
                    error = new ErrorRecord(
                        new InvalidOperationException(errorMsg),
                        ErrorConstants.Codes.InvokeGraphRequestKeysWithDifferentCasingInJsonString,
                        ErrorCategory.InvalidOperation,
                        null);
                    return null;
                }

                // Array
                switch (entry.Value)
                {
                    case JArray list:
                        {
                            var listResult = PopulateFromJArray(list, out error);
                            if (error != null)
                            {
                                return null;
                            }

                            result.Properties.Add(new PSNoteProperty(entry.Key, listResult));
                            break;
                        }
                    case JObject dic:
                        {
                            // Dictionary
                            var dicResult = PopulateFromJDictionary(dic, new DuplicateMemberHashSet(), out error);
                            if (error != null)
                            {
                                return null;
                            }

                            result.Properties.Add(new PSNoteProperty(entry.Key, dicResult));
                            break;
                        }
                    case JValue value:
                        {
                            result.Properties.Add(new PSNoteProperty(entry.Key, value.Value));
                            break;
                        }
                }

                memberHashTracker.Add(entry.Key);
            }

            return result;
        }

        private static ICollection<object> PopulateFromJArray(JArray list, out ErrorRecord error)
        {
            error = null;
            var result = new object[list.Count];

            for (var index = 0; index < list.Count; index++)
            {
                var element = list[index];
                switch (element)
                {
                    case JArray subList:
                        {
                            // Array
                            var listResult = PopulateFromJArray(subList, out error);
                            if (error != null)
                            {
                                return null;
                            }

                            result[index] = listResult;
                            break;
                        }
                    case JObject dic:
                        {
                            // Dictionary
                            var dicResult = PopulateFromJDictionary(dic, new DuplicateMemberHashSet(), out error);
                            if (error != null)
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

        private static ICollection<object> PopulateHashTableFromJArray(JArray list, out ErrorRecord error)
        {
            error = null;
            var result = new object[list.Count];

            for (var index = 0; index < list.Count; index++)
            {
                var element = list[index];

                switch (element)
                {
                    case JArray array:
                        {
                            // Array
                            var listResult = PopulateHashTableFromJArray(array, out error);
                            if (error != null)
                            {
                                return null;
                            }

                            result[index] = listResult;
                            break;
                        }
                    case JObject dic:
                        {
                            // Dictionary
                            var dicResult = PopulateHashTableFromJDictionary(dic, out error);
                            if (error != null)
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

        private static Hashtable PopulateHashTableFromJDictionary(JObject entries, out ErrorRecord error)
        {
            error = null;
            var result = new Hashtable(entries.Count, StringComparer.OrdinalIgnoreCase);
            foreach (var entry in entries)
            {
                // Case sensitive duplicates should normally not occur since JsonConvert.DeserializeObject
                // does not throw when encountering duplicates and just uses the last entry.
                if (result.ContainsKey(entry.Key))
                {
                    var errorMsg = string.Format(CultureInfo.CurrentCulture, Resources.DuplicateKeysInJsonString, entry.Key);
                    error = new ErrorRecord(
                        new InvalidOperationException(errorMsg),
                        ErrorConstants.Codes.InvokeGraphRequestDuplicateKeysInJsonString,
                        ErrorCategory.InvalidOperation,
                        null);
                    return null;
                }

                switch (entry.Value)
                {
                    case JArray list:
                        {
                            // Array
                            var listResult = PopulateHashTableFromJArray(list, out error);
                            if (error != null)
                            {
                                return null;
                            }

                            result.Add(entry.Key, listResult);
                            break;
                        }
                    case JObject dic:
                        {
                            // Dictionary
                            var dicResult = PopulateHashTableFromJDictionary(dic, out error);
                            if (error != null)
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