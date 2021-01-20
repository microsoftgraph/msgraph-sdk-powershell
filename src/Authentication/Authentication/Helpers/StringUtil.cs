// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Management.Automation;
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
        ///     Convert a JSON string back to an object of type <see cref="System.Management.Automation.PSObject"/> or
        ///     <see cref="System.Collections.Hashtable"/> depending on parameter <paramref name="returnHashtable"/>.
        /// </summary>
        /// <param name="jsonString">The JSON text to convert.</param>
        /// <param name="returnHashtable">True if the result should be returned as a <see cref="System.Collections.Hashtable"/>
        /// instead of a <see cref="System.Management.Automation.PSObject"/>.</param>
        /// <param name="maxDepth">The max depth allowed when deserializing the json jsonString. Set to null for no maximum.</param>
        /// <param name="error">An error record if the conversion failed.</param>
        /// <returns>A <see cref="System.Management.Automation.PSObject"/> or a <see cref="System.Collections.Hashtable"/>
        /// if the <paramref name="returnHashtable"/> parameter is true.</returns>
        internal static object ConvertFromJson(this string jsonString, bool returnHashtable, int? maxDepth, out ErrorRecord error)
        {
            if (jsonString == null)
            {
                throw new ArgumentNullException(nameof(jsonString));
            }

            error = null;
            try
            {
                // JsonConvert.DeserializeObject does not throw an exception when an invalid Json array is passed.
                // This issue is being tracked by https://github.com/JamesNK/Newtonsoft.Json/issues/1930.
                // To work around this, we need to identify when jsonString is a Json array, and then try to parse it via JArray.Parse().

                // If jsonString starts with '[' (ignoring white spaces).
                if (Regex.Match(jsonString, @"^\s*\[").Success)
                {
                    // JArray.Parse() will throw a JsonException if the array is invalid.
                    // This will be caught by the catch block below, and then throw an
                    // ArgumentException - this is done to have same behavior as the JavaScriptSerializer.
                    JArray.Parse(jsonString);

                    // Please note that if the Json array is valid, we don't do anything,
                    // we just continue the deserialization.
                }

                var obj = JsonConvert.DeserializeObject(
                    jsonString,
                    new JsonSerializerSettings
                    {
                        // This TypeNameHandling setting is required to be secure.
                        TypeNameHandling = TypeNameHandling.None,
                        MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                        MaxDepth = maxDepth
                    });

                switch (obj)
                {
                    case JObject dictionary:
                        // JObject is a IDictionary
                        /* Note: Do not use Ternary operator as HashTable is implicitly convertible to PsObject, thus the ternary operation below, always returns a PSObject.
                         * return returnHashtable ? PopulateHashTableFromJDictionary(dictionary, out error) : PopulateFromJDictionary(dictionary, new DuplicateMemberHashSet(), out error);
                         * https://github.com/PowerShell/PowerShell/blob/73f852da4252eabe4097ab48a7b67c5d147a01f3/src/System.Management.Automation/engine/MshObject.cs#L965
                         */
                        if (returnHashtable)
                            return PopulateHashTableFromJDictionary(dictionary, out error);
                        else
                            return PopulateFromJDictionary(dictionary, new DuplicateMemberHashSet(), out error);
                    case JArray list:
                        if (returnHashtable)
                            return PopulateHashTableFromJArray(list, out error);
                        else
                            return PopulateFromJArray(list, out error);
                    default:
                        return obj;
                }
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
                        Errors.InvokeGraphRequestEmptyKeyInJsonString,
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
                        Errors.InvokeGraphRequestDuplicateKeysInJsonString,
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
                        Errors.InvokeGraphRequestKeysWithDifferentCasingInJsonString,
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
                        Errors.InvokeGraphRequestDuplicateKeysInJsonString,
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