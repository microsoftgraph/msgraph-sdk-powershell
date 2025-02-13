namespace Microsoft.Graph.PowerShell.JsonUtilities
{
    using Newtonsoft.Json.Linq;
    using System.Linq;

    public static class JsonExtensions
    {
        /// <summary>
        /// Removes JSON properties that have a value of "defaultnull" and converts properties with values of "null" or empty strings ("") to actual JSON null values.
        /// </summary>
        /// <param name="jsonObject">The JObject to process and clean.</param>
        /// <returns>
        /// A JSON string representation of the cleaned JObject with "defaultnull" properties removed and "null" or empty string values converted to JSON null.
        /// </returns>
        /// <example>
        /// JObject json = JObject.Parse(@"{""name"": ""John"", ""email"": ""defaultnull"", ""address"": ""null""}");
        /// string cleanedJson = json.RemoveDefaultNullProperties();
        /// Console.WriteLine(cleanedJson);
        /// // Output: { "name": "John", "address": null }
        /// </example>
        public static string RemoveDefaultNullProperties(this JObject jsonObject)
        {
            try
            {
                foreach (var property in jsonObject.Properties().ToList())
                {
                    if (property.Value.Type == JTokenType.Object)
                    {
                        RemoveDefaultNullProperties((JObject)property.Value);
                    }
                    else if (property.Value.Type == JTokenType.Array)
                    {
                        foreach (var item in property.Value)
                        {
                            if (item.Type == JTokenType.Object)
                            {
                                RemoveDefaultNullProperties((JObject)item);
                            }
                        }
                    }
                    else if (property.Value.Type == JTokenType.String && property.Value.ToString() == "defaultnull")
                    {
                        property.Remove();
                    }
                    else if (property.Value.Type == JTokenType.String && (property.Value.ToString() == "null" || property.Value.ToString() == ""))
                    {
                        property.Value = JValue.CreateNull();
                    }
                }
            }
            catch (System.Exception)
            {
                return jsonObject.ToString(); // Return the original string if parsing fails
            }
            return jsonObject.ToString();
        }
        public static string ReplaceAndRemoveSlashes(this string body)
        {
            return body.Replace("/", "").Replace("\\", "").Replace("rn", "").Replace("\"{", "{").Replace("}\"", "}");
        }
    }
}
