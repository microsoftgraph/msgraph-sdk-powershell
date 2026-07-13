// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using Newtonsoft.Json;
using System;
using System.Management.Automation;

namespace Microsoft.Graph.PowerShell.Authentication.Helpers
{
    /// <summary>
    ///     Serializes <see cref="PSObject" /> values by unwrapping them to their underlying base object.
    ///     PowerShell wraps values that pass through the pipeline (e.g. bare $_ in ForEach-Object) in a
    ///     <see cref="PSObject" />. Without this converter, Newtonsoft.Json reflects over the PowerShell
    ///     adapted members of the wrapper (such as the Chars indexed property on strings) instead of the
    ///     underlying value and fails with a self-referencing loop error.
    /// </summary>
    internal class PSObjectJsonConverter : JsonConverter
    {
        public override bool CanRead => false;

        public override bool CanConvert(Type objectType)
        {
            return typeof(PSObject).IsAssignableFrom(objectType);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var psObject = (PSObject)value;
            if (psObject.BaseObject is PSCustomObject)
            {
                // Pure custom objects (e.g. [pscustomobject]@{ ... }) have no underlying CLR object
                // to fall back on; project their properties into a JSON object instead.
                writer.WriteStartObject();
                foreach (var property in psObject.Properties)
                {
                    writer.WritePropertyName(property.Name);
                    serializer.Serialize(writer, property.Value);
                }
                writer.WriteEndObject();
            }
            else
            {
                // Serialize the underlying CLR object. Nested PSObject-wrapped values (e.g. inside
                // dictionaries or collections) are routed back through this converter by the serializer.
                serializer.Serialize(writer, psObject.BaseObject);
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotSupportedException();
        }
    }
}
