namespace NamespacePrefixPlaceholder.PowerShell.JsonUtilities
{
    using Newtonsoft.Json.Linq;
    using Newtonsoft.Json;
    using System;
    using System.Linq;

    public static class JsonExtensions
    {
        /// <summary>
        /// Converts "null" strings to actual null values, replaces empty objects, and cleans up arrays.
        /// </summary>
        /// <param name="token">The JSON token to process.</param>
        /// <returns>A cleaned JSON string with unnecessary null values removed.</returns>
        public static string RemoveDefaultNullProperties(this JToken token)
        {
            try
            {
                ProcessToken(token);

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

                // Recursively process remaining properties
                foreach (var property in jsonObject.Properties().ToList())
                {
                    JToken cleanedValue = ProcessToken(property.Value);

                    // Convert explicit "null" strings to actual null
                    if (property.Value.Type == JTokenType.String && property.Value.ToString().Equals("null", StringComparison.Ordinal))
                    {
                        property.Value = JValue.CreateNull();
                    }

                    if (property.Value.ToString().Equals("{\r\n}", StringComparison.Ordinal))
                    {

                        property.Value = JObject.Parse("{}"); // Convert empty object to {}
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
                        if (item.ToString().Equals("{\r\n}", StringComparison.Ordinal))
                        {
                            JToken cleanedItem = ProcessToken(item);
                            jsonArray[i] = JObject.Parse("{}"); // Convert empty object to {}
                        }
                        else
                        {
                            JToken cleanedItem = ProcessToken(item);
                            jsonArray[i] = cleanedItem; // Update with cleaned version
                        }

                    }
                    else if (item.Type == JTokenType.String && item.ToString().Equals("null", StringComparison.Ordinal))
                    {
                        jsonArray[i] = JValue.CreateNull(); // Convert "null" string to JSON null
                    }
                    else if (item.Type == JTokenType.String && item.ToString().Equals("nullarray", StringComparison.Ordinal))
                    {
                        jsonArray.RemoveAt(i);
                        i--;
                    }

                }

                return jsonArray.HasValues ? jsonArray : null;
            }

            return token;
        }
    }
}
