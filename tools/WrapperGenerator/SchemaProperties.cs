using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.OpenApi;

namespace WrapperGenerator;

public sealed record CmdletProperty(string OpenApiName, string PascalName, string PsTypeName, bool IsArray);

// Maps a body schema's top-level primitive properties onto cmdlet parameters. Deliberately
// shallow, per team decision: nested complex properties are skipped rather than modeled.
// Server-managed properties are excluded, and passwordProfile is flagged separately via
// HasPasswordProfile.
public static class SchemaProperties
{
    public static IReadOnlyList<CmdletProperty> ExtractPrimitiveProperties(IOpenApiSchema schema)
    {
        ArgumentNullException.ThrowIfNull(schema);
        var result = new List<CmdletProperty>();
        var seen = new HashSet<string>(StringComparer.Ordinal);

        void Walk(IOpenApiSchema s)
        {
            foreach (var inherited in s.AllOf ?? [])
                Walk(inherited);

            foreach (var (name, propSchema) in s.Properties ?? new Dictionary<string, IOpenApiSchema>())
            {
                if (IsProtocolOrServerManagedProperty(name, propSchema) || !seen.Add(name))
                    continue;

                if (IsPlainScalar(propSchema))
                {
                    result.Add(new CmdletProperty(name, name.ToFirstCharacterUpperCase(), MapPsType(propSchema), IsArray: false));
                }
                else if (propSchema.Type == JsonSchemaType.Array && propSchema.Items is { } items && IsPlainScalar(items))
                {
                    result.Add(new CmdletProperty(name, name.ToFirstCharacterUpperCase(), MapPsType(items) + "[]", IsArray: true));
                }
            }
        }

        Walk(schema);
        return result;
    }

    // Detects a passwordProfile property (directly or via allOf) so the emitter can flatten
    // it into parameters; Graph requires it to create a user. Generalizing this pattern is
    // tracked in #3690.
    public static bool HasPasswordProfile(IOpenApiSchema schema)
    {
        ArgumentNullException.ThrowIfNull(schema);
        if (schema.Properties?.ContainsKey("passwordProfile") ?? false)
            return true;
        return schema.AllOf?.Any(HasPasswordProfile) ?? false;
    }

    // A "format" on a string (date-time, uuid, byte, ...) means Kiota maps it to a non-string
    // CLR type, and an enum-valued string becomes a real enum type. Both are left out rather
    // than guessing Kiota's mapping and risking a type mismatch. Schema.Type is a flags enum
    // and nullable unions set the Null bit, so it is masked off before comparing.
    private static bool IsPlainScalar(IOpenApiSchema schema) => (schema.Type & ~JsonSchemaType.Null) switch
    {
        JsonSchemaType.String => string.IsNullOrEmpty(schema.Format) && (schema.Enum?.Count ?? 0) == 0,
        JsonSchemaType.Boolean or JsonSchemaType.Integer or JsonSchemaType.Number => true,
        _ => false,
    };

    // Numeric mapping: an explicit format decides the CLR type, mirroring Kiota's own
    // mapping so a wrapper parameter always matches the Kiota model property it is assigned
    // to. Without a format, integer stays int and number stays double.
    private static string MapPsType(IOpenApiSchema schema) => (schema.Type & ~JsonSchemaType.Null) switch
    {
        JsonSchemaType.String => "string",
        JsonSchemaType.Boolean => "bool",
        JsonSchemaType.Integer or JsonSchemaType.Number => schema.Format?.ToLowerInvariant() switch
        {
            "int64" => "long",
            "int32" => "int",
            "float" => "float",
            "double" => "double",
            "decimal" => "decimal",
            _ => (schema.Type & ~JsonSchemaType.Null) == JsonSchemaType.Integer ? "int" : "double",
        },
        _ => "string",
    };

    // Excludes properties a caller cannot or should not set. "id" is server-assigned.
    // "@"-prefixed names like "@odata.type" are OData control data that Kiota's serializer
    // fills in from the model type, and they are not legal C# identifiers anyway. ReadOnly is
    // the general OpenAPI signal for server-managed. Future exclusions of this kind belong here.
    private static bool IsProtocolOrServerManagedProperty(string name, IOpenApiSchema propSchema) =>
        name == "id" || name.StartsWith('@') || propSchema.ReadOnly;
}
