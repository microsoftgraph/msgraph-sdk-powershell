namespace NamespacePrefixPlaceholder.PowerShell.JsonUtilities
{
    using Newtonsoft.Json.Linq;
    using Newtonsoft.Json;
    using System;
    using System.Linq;

    public static class JsonExtensions
    {
        /// <summary>
        /// Recursively removes properties with the value "defaultnull" from a JSON structure
        /// and replaces string values that are "null" with actual null values.
        /// This method supports both JObject (JSON objects) and JArray (JSON arrays),
        /// ensuring proper cleanup of nested structures.
        /// </summary>
        /// <param name="token">The JToken (JObject or JArray) to process.</param>
        /// <returns>The cleaned JSON string with "defaultnull" values removed and "null" strings converted to null.</returns>
        /// <example>
        /// JObject json = JObject.Parse(@"{""name"": ""John"", ""email"": ""defaultnull"", ""address"": ""null""}");
        /// string cleanedJson = json.RemoveDefaultNullProperties();
        /// Console.WriteLine(cleanedJson);
        /// // Output: { "name": "John", "address": null }
        /// </example>

        public static string RemoveDefaultNullProperties(this JToken token)
        {
            try
            {
                ProcessToken(token);

                // If the root token is completely empty, return "{}" or "[]"
                if (token is JObject obj && !obj.HasValues) return "{}";
                if (token is JArray arr && !arr.HasValues) return "[]";

                return token.ToString();
            }
            catch (Exception)
            {
                return token.ToString(); // Return original JSON if an error occurs
            }
        }

        private static JToken ProcessToken(JToken token)
        {
            if (token is JObject jsonObject)
            {
                // Remove properties with "defaultnull" but keep valid ones
                var propertiesToRemove = jsonObject.Properties()
                    .Where(p => p.Value.Type == JTokenType.String && p.Value.ToString().Equals("defaultnull", StringComparison.Ordinal))
                    .ToList();

                foreach (var property in propertiesToRemove)
                {
                    property.Remove();
                }

                // Recursively process remaining properties
                foreach (var property in jsonObject.Properties().ToList())
                {
                    JToken cleanedValue = ProcessToken(property.Value);

                    // Convert explicit "null" strings to actual null
                    if (property.Value.Type == JTokenType.String && property.Value.ToString().Equals("null", StringComparison.Ordinal))
                    {
                        property.Value = JValue.CreateNull();
                    }

                    // Remove the property if it's now empty after processing
                    if (ShouldRemove(cleanedValue))
                    {
                        property.Remove();
                    }
                }

                // Remove the object itself if ALL properties are removed (empty object)
                return jsonObject.HasValues ? jsonObject : null;
            }
            else if (token is JArray jsonArray)
            {
                for (int i = jsonArray.Count - 1; i >= 0; i--)
                {
                    JToken item = jsonArray[i];

                    // Process nested objects/arrays inside the array
                    if (item is JObject || item is JArray)
                    {
                        JToken cleanedItem = ProcessToken(item);

                        if (ShouldRemove(cleanedItem))
                        {
                            jsonArray.RemoveAt(i); // Remove empty or unnecessary items
                        }
                        else
                        {
                            jsonArray[i] = cleanedItem; // Update with cleaned version
                        }
                    }
                    else if (item.Type == JTokenType.String && item.ToString().Equals("null", StringComparison.Ordinal))
                    {
                        jsonArray[i] = JValue.CreateNull(); // Convert "null" string to JSON null
                    }
                    else if (item.Type == JTokenType.String && item.ToString().Equals("defaultnull", StringComparison.Ordinal))
                    {
                        jsonArray.RemoveAt(i); // Remove "defaultnull" entries
                    }
                }

                return jsonArray.HasValues ? jsonArray : null;
            }

            return token;
        }

        private static bool ShouldRemove(JToken token)
        {
            return token == null ||
                   (token.Type == JTokenType.Object && !token.HasValues) || // Remove empty objects
                   (token.Type == JTokenType.Array && !token.HasValues);    // Remove empty arrays
        }


        public static string ReplaceAndRemoveSlashes(this string body)
        {
            try
            {
                // Parse the JSON using Newtonsoft.Json
                JToken jsonToken = JToken.Parse(body);
                if (jsonToken == null) return body; // If parsing fails, return original body

                // Recursively process JSON to remove escape sequences
                ProcessBody(jsonToken);

                // Return cleaned JSON string
                return JsonConvert.SerializeObject(jsonToken, Formatting.None, new PreserveStringConverter());
            }
            catch (Newtonsoft.Json.JsonException)
            {
                // If it's not valid JSON, apply normal string replacements
                return body.Replace("\\", "").Replace("rn", "").Replace("\"{", "{").Replace("}\"", "}");
            }
        }

        private static void ProcessBody(JToken token)
        {
            if (token is JObject jsonObject)
            {
                foreach (var property in jsonObject.Properties().ToList())
                {
                    var value = property.Value;

                    // If the value is a string, attempt to parse it as JSON to remove escaping
                    if (value.Type == JTokenType.String)
                    {
                        string stringValue = value.ToString();
                        try
                        {
                            property.Value = stringValue; // Replace with unescaped JSON object
                            ProcessBody(stringValue); // Recursively process
                        }
                        catch (Newtonsoft.Json.JsonException)
                        {
                            // If parsing fails, leave the value as is
                        }
                    }
                    else if (value is JObject || value is JArray)
                    {
                        ProcessBody(value); // Recursively process nested objects/arrays
                    }
                }
            }
            else if (token is JArray jsonArray)
            {
                for (int i = 0; i < jsonArray.Count; i++)
                {
                    var value = jsonArray[i];

                    // If the value is a string, attempt to parse it as JSON to remove escaping
                    if (value.Type == JTokenType.String)
                    {
                        string stringValue = value.ToString();
                        try
                        {
                            jsonArray[i] = stringValue; // Replace with unescaped JSON object
                            ProcessBody(stringValue); // Recursively process
                        }
                        catch (Newtonsoft.Json.JsonException)
                        {
                            // If parsing fails, leave the value as is
                        }
                    }
                    else if (value is JObject || value is JArray)
                    {
                        ProcessBody(value); // Recursively process nested objects/arrays
                    }
                }
            }
        }
    }
}
