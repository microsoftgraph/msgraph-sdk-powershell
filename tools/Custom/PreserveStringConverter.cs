using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NamespacePrefixPlaceholder.PowerShell.JsonUtilities
{
    public class PreserveStringConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(string); // Only applies to string properties
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            // If the value is a number but the property expects a string, return it as a string
            if ((reader.TokenType == JsonToken.Integer || reader.TokenType == JsonToken.Float) && objectType == typeof(string))
            {
                return reader.Value?.ToString();
            }

            return reader?.Value; // Otherwise, keep it as is
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteValue(value); // Preserve the original type
        }
    }
}
