namespace NamespacePrefixPlaceholder.PowerShell.JsonUtilities
{
    using Newtonsoft.Json.Linq;
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
                if (token is JObject jsonObject)
                {
                    foreach (var property in jsonObject.Properties().ToList())
                    {
                        if (property.Value.Type == JTokenType.Object)
                        {
                            RemoveDefaultNullProperties(property.Value);
                        }
                        else if (property.Value.Type == JTokenType.Array)
                        {
                            RemoveDefaultNullProperties(property.Value);
                        }
                        else if (property.Value.Type == JTokenType.String && property.Value.ToString().Equals("defaultnull",StringComparison.Ordinal))
                        {
                            property.Remove();
                        }
                        else if (property.Value.Type == JTokenType.String && property.Value.ToString().Equals("null",StringComparison.Ordinal))
                        {
                            property.Value = JValue.CreateNull();
                        }
                    }
                }
                else if (token is JArray jsonArray)
                {
                    // Process each item in the JArray
                    for (int i = jsonArray.Count - 1; i >= 0; i--)
                    {
                        var item = jsonArray[i];

                        if (item.Type == JTokenType.Object)
                        {
                            RemoveDefaultNullProperties(item);
                        }
                        else if (item.Type == JTokenType.String && item.ToString().Equals("defaultnull",StringComparison.Ordinal))
                        {
                            jsonArray.RemoveAt(i); // Remove the "defaultnull" string from the array
                        }
                        else if (item.Type == JTokenType.String && item.ToString().Equals("null",StringComparison.Ordinal))
                        {
                            jsonArray[i] = JValue.CreateNull(); // Convert "null" string to actual null
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine($"Error cleaning JSON: {ex.Message}");
                return token.ToString(); // Return the original JSON if any error occurs
            }

            return token.ToString();
        }

        public static string ReplaceAndRemoveSlashes(this string body)
        {
            return body.Replace("/", "").Replace("\\", "").Replace("rn", "").Replace("\"{", "{").Replace("}\"", "}");
        }
    }
}