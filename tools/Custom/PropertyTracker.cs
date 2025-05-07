using System;
using System.Collections.Generic;


namespace NamespacePrefixPlaceholder.PowerShell.Models
{
    public class PropertyTracker
    {
        private readonly HashSet<string> _trackedProperties = new HashSet<string>();

        public void TrackProperty(string propertyName)
        {
            if (!string.IsNullOrWhiteSpace(propertyName))
            {
                propertyName = char.ToLower(propertyName[0]) + propertyName.Substring(1);  // ✅ force camelCase
                _trackedProperties.Add(propertyName);  // ✅ Track properties that are set
            }
        }

        public bool IsPropertySet(string propertyName)
        {
            // Ensure that the first character of the property name is UpperCase
            if (propertyName.Length > 0)
            {
                propertyName = char.ToLower(propertyName[0]) + propertyName.Substring(1); // ✅ match camelCase
            }
            return _trackedProperties.Contains(propertyName);
        }
        public static T SanitizeValue<T>(object value)
        {
            if (typeof(T) == typeof(string))
            {
                return (T)(object)(string.IsNullOrEmpty(value as string) ? null : value);
            }
            return (T)value;
        }
        public static NamespacePrefixPlaceholder.PowerShell.Runtime.Json.JsonNode ConvertToJsonNode(Type propertyType, object value)
        {
            if (value == null)
            {
                return new NamespacePrefixPlaceholder.PowerShell.Runtime.Json.JsonString("null"); // Explicitly return null if the property is set to null
            }

            // Get the declared property type using reflection


            // Handle different types based on the declared type
            if (propertyType == typeof(string))
            {
                return new NamespacePrefixPlaceholder.PowerShell.Runtime.Json.JsonString(value.ToString());
            }
            else if (propertyType == typeof(int) || propertyType == typeof(int?) ||
                     propertyType == typeof(long) || propertyType == typeof(long?) ||
                     propertyType == typeof(short) || propertyType == typeof(short?))
            {
                return new NamespacePrefixPlaceholder.PowerShell.Runtime.Json.JsonNumber(Convert.ToDouble(value));
            }
            else if (propertyType == typeof(bool) || propertyType == typeof(bool?))
            {
                return new NamespacePrefixPlaceholder.PowerShell.Runtime.Json.JsonBoolean((bool)value);
            }
            else if (propertyType.IsEnum)
            {
                return new NamespacePrefixPlaceholder.PowerShell.Runtime.Json.JsonString(value.ToString());
            }
            else if (propertyType == typeof(DateTime) || propertyType == typeof(DateTime?))
            {
                return new NamespacePrefixPlaceholder.PowerShell.Runtime.Json.JsonString(((DateTime)value).ToString("o")); // ISO 8601 format
            }

            // Fallback to JSON object if the type is complex
            return NamespacePrefixPlaceholder.PowerShell.Runtime.Json.JsonObject.FromObject(value);
        }
    }
}

