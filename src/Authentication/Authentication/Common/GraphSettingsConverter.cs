// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.PowerShell.Authentication.Common
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// A <see cref="JsonConverter"/> for <see cref="GraphSettings"/>.
    /// </summary>
    internal class GraphSettingsConverter: JsonConverter
    {
        public override bool CanWrite => true;
        public override bool CanRead => true;
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(IGraphEnvironment);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (objectType == typeof(IGraphEnvironment))
            {
                return serializer.Deserialize<GraphEnvironment>(reader);
            }
            else if (objectType == typeof(Dictionary<string, IGraphEnvironment>))
            {
                var tempResult = serializer.Deserialize<Dictionary<string, GraphEnvironment>>(reader);
                var result = new Dictionary<string, IGraphEnvironment>(StringComparer.OrdinalIgnoreCase);
                foreach (var key in tempResult.Keys)
                {
                    result[key] = tempResult[key];
                }

                return result;
            }

            return serializer.Deserialize(reader);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }
    }
}
