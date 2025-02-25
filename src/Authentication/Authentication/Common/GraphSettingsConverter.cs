// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using Microsoft.Graph.PowerShell.Authentication.Interfaces;
using Microsoft.Graph.PowerShell.Authentication.Models;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Microsoft.Graph.PowerShell.Authentication.Common
{
    /// <summary>
    /// A <see cref="JsonConverter"/> for <see cref="GraphSettings"/>.
    /// </summary>
    internal class GraphSettingsConverter : JsonConverter<IGraphEnvironment>
    {
        public override IGraphEnvironment Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (typeToConvert == typeof(IGraphEnvironment))
            {
                return JsonSerializer.Deserialize<GraphEnvironment>(ref reader, options);
            }
            else if (typeToConvert == typeof(Dictionary<string, IGraphEnvironment>))
            {
                var tempResult = JsonSerializer.Deserialize<Dictionary<string, GraphEnvironment>>(ref reader, options);
                var result = new Dictionary<string, IGraphEnvironment>(StringComparer.OrdinalIgnoreCase);
                foreach (var key in tempResult.Keys)
                {
                    result[key] = tempResult[key];
                }

                return (IGraphEnvironment)(object)result;
            }

            throw new JsonException($"Cannot convert to {typeToConvert}");
        }

        public override void Write(Utf8JsonWriter writer, IGraphEnvironment value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value, options);
        }
    }
}
