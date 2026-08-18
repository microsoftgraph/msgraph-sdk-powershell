using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.OpenApi;

namespace WrapperGenerator;

public sealed record CmdletProperty(string OpenApiName, string PascalName, string PsTypeName, bool IsArray)
{
    // The emitted -Parameter name. Differs from PascalName only when the body property
    // collides with a path parameter; see ResolveParameterNameCollisions.
    public string ParameterName { get; init; } = PascalName;
}

// A body property whose type is a model in the spec's component schemas, bound as a parameter
// typed as the corresponding kiota model class. ReferenceId is the component schema key
// ("microsoft.graph.passwordProfile"); the generation service turns it into a CLR type name,
// because only it knows kiota's namespace and reserved-name rules.
// IsEnum carries through because an enum is a value type: kiota declares a collection of one
// with nullable elements (List<CalendarRoleType?>), unlike a collection of models.
public sealed record ComplexProperty(string OpenApiName, string PascalName, string ReferenceId, bool IsArray, bool IsEnum)
{
    public string ParameterName { get; init; } = PascalName;
}

// A property the spec gives no type, which kiota emits as UntypedNode. It binds as object and
// is converted at assignment, so a caller passes an ordinary PowerShell value.
public sealed record UntypedProperty(string OpenApiName, string PascalName)
{
    public string ParameterName { get; init; } = PascalName;
}

// The same after parameter-name collision resolution. LocalName names the converted value in
// the emitted assignment; it is derived from the parameter so two properties in one cmdlet
// cannot declare the same local.
public sealed record UntypedParameter(string PascalName, string ParameterName)
{
    public string LocalName => "untyped" + ParameterName;
}

// A complex property after the generation service has turned its ReferenceId into a kiota CLR
// type name. Emission takes this rather than ComplexProperty so a parameter cannot be emitted
// with an unresolved type.
public sealed record ComplexParameter(string PascalName, string ParameterName, string TypeName, bool IsArray, bool IsEnum)
{
    // The declared parameter type. An array of enums needs nullable elements to assign to
    // kiota's List<TEnum?>; an array of models must not, matching List<TModel>.
    public string ElementNullableTypeName => IsArray
        ? TypeName + (IsEnum ? "?[]" : "[]")
        : TypeName;
}

// Why a property could not be bound. Each value is a distinct spec shape rather than a generic
// "unsupported", so a sweep says which shapes are worth implementing next instead of just how
// many were missed.
public enum UnsupportedShape
{
    InlineEnum,       // enum declared inline; kiota synthesises the type name from the parent
    UnknownFormat,    // a format with no verified kiota CLR mapping
    InlineObject,     // anonymous object; kiota synthesises the type name from the parent
    Union,            // anyOf/oneOf that is a real choice, not the numeric/INF encoding
    Dictionary,       // free-form map (additionalProperties)
    Unresolvable,     // an array with no item schema, or a reference with no bindable target
}

public sealed record UnsupportedProperty(string OpenApiName, UnsupportedShape Shape, bool IsRequired);

// Why a property is deliberately not a parameter. Each is a protocol or framework rule, never a
// Graph corpus special case, and each is named so an external check can tell a policy exclusion
// apart from an omission.
public enum ExclusionPolicy
{
    ServerAssignedId,     // "id" is assigned by the service
    ODataControlData,     // an OData annotation carrying protocol metadata, e.g. @odata.type
    KiotaAdditionalData,  // the IAdditionalDataHolder bag every kiota model already exposes
    ReadOnlySchema,       // readOnly: true - the OpenAPI signal for server-managed
    NavigationProperty,   // x-ms-navigationProperty - a relationship with its own request path
}

public sealed record ExcludedProperty(string OpenApiName, ExclusionPolicy Policy);

// The full classification of one request body. PropertiesSeen is counted independently of the
// buckets, so Scalars + Complex + Unsupported + Excluded == PropertiesSeen is a real
// invariant rather than an identity that holds by construction; Classify throws if it breaks.
public sealed record BodyProperties(
    IReadOnlyList<CmdletProperty> Scalars,
    IReadOnlyList<ComplexProperty> Complex,
    IReadOnlyList<UntypedProperty> Untyped,
    IReadOnlyList<UnsupportedProperty> Unsupported,
    IReadOnlyList<ExcludedProperty> Excluded,
    int PropertiesSeen);

// Maps a request body schema onto cmdlet parameters. Scalars bind directly; properties whose
// type is a referenced model bind as that model's kiota type (PowerShell coerces a hashtable
// into it). Shapes whose kiota type name cannot be derived from the spec - inline objects and
// enums, unions, dictionaries - are reported rather than guessed, because a wrong type name is
// a compile error in the generated module.
public static class SchemaProperties
{
    // resolveReference maps a component schema key to its schema, so a $ref can be inspected
    // before deciding what it is: a reference to microsoft.graph.importance is a string enum,
    // not a model, and binding it as a model would not compile.
    public static BodyProperties Classify(IOpenApiSchema schema, Func<string, IOpenApiSchema?> resolveReference)
    {
        ArgumentNullException.ThrowIfNull(schema);
        ArgumentNullException.ThrowIfNull(resolveReference);

        var scalars = new List<CmdletProperty>();
        var complex = new List<ComplexProperty>();
        var untyped = new List<UntypedProperty>();
        var unsupported = new List<UnsupportedProperty>();
        var excluded = new List<ExcludedProperty>();
        var seen = new HashSet<string>(StringComparer.Ordinal);
        var required = new HashSet<string>(StringComparer.Ordinal);

        void CollectRequired(IOpenApiSchema s)
        {
            foreach (var inherited in s.AllOf ?? [])
                CollectRequired(inherited);
            if (s.Required is { } names)
            {
                foreach (var name in names)
                    required.Add(name);
            }
        }
        CollectRequired(schema);

        void Walk(IOpenApiSchema s)
        {
            foreach (var inherited in s.AllOf ?? [])
                Walk(inherited);

            foreach (var (name, propSchema) in s.Properties ?? new Dictionary<string, IOpenApiSchema>())
            {
                if (!seen.Add(name))
                    continue;

                if (TryGetExclusionPolicy(name, propSchema) is { } policy)
                {
                    excluded.Add(new ExcludedProperty(name, policy));
                    continue;
                }

                var isRequired = required.Contains(name);
                var pascal = ToKiotaPropertyName(name);

                switch (ClassifyProperty(propSchema, resolveReference))
                {
                    case ScalarShape scalarShape:
                        scalars.Add(new CmdletProperty(name, pascal, scalarShape.PsTypeName, scalarShape.IsArray));
                        break;
                    case ModelShape modelShape:
                        // Requiredness is deliberately not carried here: every bound parameter
                        // is optional, and Graph's schemas do not mark requiredness usefully.
                        // The measurement behind that is in docs/body-property-binding.md.
                        complex.Add(new ComplexProperty(name, pascal, modelShape.ReferenceId, modelShape.IsArray, modelShape.IsEnum));
                        break;
                    case UntypedShape:
                        untyped.Add(new UntypedProperty(name, pascal));
                        break;
                    case UnsupportedNativeShape u:
                        unsupported.Add(new UnsupportedProperty(name, u.Shape, isRequired));
                        break;
                }
            }
        }

        Walk(schema);

        // seen counts every distinct property the walk reached, without reference to where it
        // was routed. A property that fell through the shape switch would show up here and
        // nowhere else, which is precisely the failure a summed total could never reveal.
        var accountedFor = scalars.Count + complex.Count + untyped.Count + unsupported.Count + excluded.Count;
        if (seen.Count != accountedFor)
        {
            throw new InvalidOperationException(
                $"Body property classification is not exhaustive: reached {seen.Count} properties but accounted for " +
                $"{accountedFor} (scalar {scalars.Count} + model {complex.Count} + untyped {untyped.Count} + unsupported {unsupported.Count} + excluded {excluded.Count}).");
        }

        return new BodyProperties(scalars, complex, untyped, unsupported, excluded, seen.Count);
    }

    private abstract record PropertyShape;
    private sealed record UntypedShape : PropertyShape;
    private sealed record ScalarShape(string PsTypeName, bool IsArray) : PropertyShape;
    private sealed record ModelShape(string ReferenceId, bool IsArray, bool IsEnum) : PropertyShape;
    private sealed record UnsupportedNativeShape(UnsupportedShape Shape) : PropertyShape;

    private static PropertyShape ClassifyProperty(IOpenApiSchema propSchema, Func<string, IOpenApiSchema?> resolveReference)
    {
        // An array is classified by its item schema, at the same single level of nesting the
        // scalar case allows - arrays of arrays are not a shape Graph request bodies use.
        if ((propSchema.Type & ~JsonSchemaType.Null) == JsonSchemaType.Array)
        {
            if (propSchema.Items is not { } items)
                return new UnsupportedNativeShape(UnsupportedShape.Unresolvable);
            return ClassifyLeaf(items, resolveReference, isArray: true);
        }

        return ClassifyLeaf(propSchema, resolveReference, isArray: false);
    }

    private static PropertyShape ClassifyLeaf(IOpenApiSchema leaf, Func<string, IOpenApiSchema?> resolveReference, bool isArray)
    {
        if (TryMapScalar(leaf, out var scalarType, out var badFormat))
            return new ScalarShape(ArrayAware(scalarType, isArray), isArray);
        if (badFormat)
            return new UnsupportedNativeShape(UnsupportedShape.UnknownFormat);

        // A reference, either directly or as the single meaningful branch of a nullable union.
        // An enum reference resolves the same way a model does - kiota emits both as named types
        // in the models namespace - so both bind through the same path.
        var referenceId = leaf.GetReferenceId() ?? SingleReferenceOfNullableUnion(leaf);
        if (referenceId is not null)
        {
            var target = resolveReference(referenceId);
            if (target is null)
                return new UnsupportedNativeShape(UnsupportedShape.Unresolvable);
            var targetType = target.Type & ~JsonSchemaType.Null;
            // Graph model schemas are objects; some declare no type at all and are objects by
            // virtue of carrying properties or an allOf chain. Enums are named types too.
            var isEnum = IsEnumSchema(target);
            if (isEnum || targetType == JsonSchemaType.Object || targetType is null)
                return new ModelShape(referenceId, isArray, isEnum);
            // A reference to a bare scalar carries no kiota type of its own to bind to.
            return new UnsupportedNativeShape(UnsupportedShape.Unresolvable);
        }

        if ((leaf.AnyOf?.Count ?? 0) > 0 || (leaf.OneOf?.Count ?? 0) > 0)
        {
            return TryMapNumericUnion(leaf, resolveReference, out var unionType)
                ? new ScalarShape(ArrayAware(new ScalarType(unionType, IsValueType: true), isArray), isArray)
                : new UnsupportedNativeShape(UnsupportedShape.Union);
        }
        if (IsEnumSchema(leaf))
            return new UnsupportedNativeShape(UnsupportedShape.InlineEnum);
        if (leaf.AdditionalProperties is not null)
            return new UnsupportedNativeShape(UnsupportedShape.Dictionary);
        if ((leaf.Properties?.Count ?? 0) > 0 || (leaf.Type & ~JsonSchemaType.Null) == JsonSchemaType.Object)
            return new UnsupportedNativeShape(UnsupportedShape.InlineObject);

        // Nothing left to go on: no type, reference, enum, format or members - Graph writes
        // these with only a description (workbookChartAxis.maximum) and kiota emits UntypedNode.
        // An array is not treated this way; its element shape is decided by ClassifyProperty.
        return isArray ? new UnsupportedNativeShape(UnsupportedShape.Unresolvable) : new UntypedShape();
    }

    // OData's non-finite doubles: a numeric property that may instead arrive as one of these
    // sentinel strings. Their presence in a referenced enum is what identifies the encoding.
    private static readonly HashSet<string> NonFiniteNumericSentinels =
        new(StringComparer.Ordinal) { "-INF", "INF", "NaN" };

    // Graph encodes a numeric that may also carry an OData non-finite value as a union of the
    // numeric, a bare string, and a reference to a string enum of the sentinels. Kiota keeps the
    // numeric and drops the rest (bookingService.price generates as double?), so the numeric
    // branch is the type to bind.
    //
    // All three conditions are required, because each rules out a different real choice:
    // one numeric branch (two numerics is a choice of precision), every other branch merely
    // stringish (a model or formatted-string arm would be silently discarded), and at least one
    // sentinel enum (without it, "number or string" is an ordinary union whose string arm means
    // something). Recognition is by enum VALUES, never by the name of the schema carrying them.
    private static bool TryMapNumericUnion(IOpenApiSchema schema, Func<string, IOpenApiSchema?> resolveReference, out string mapped)
    {
        mapped = string.Empty;
        var branches = schema.AnyOf ?? schema.OneOf;
        if (branches is null)
            return false;

        var sawSentinelEnum = false;
        foreach (var branch in branches)
        {
            if ((branch.Type & ~JsonSchemaType.Null) is JsonSchemaType.Integer or JsonSchemaType.Number)
            {
                if (mapped.Length > 0)
                    return false;   // two numerics is a genuine choice
                mapped = MapNumericType(branch);
                continue;
            }
            if (!IsStringishAlternative(branch, resolveReference, ref sawSentinelEnum))
                return false;
        }
        return mapped.Length > 0 && sawSentinelEnum;
    }

    private static bool IsStringishAlternative(IOpenApiSchema branch, Func<string, IOpenApiSchema?> resolveReference, ref bool sawSentinelEnum)
    {
        if (branch.GetReferenceId() is { } id)
        {
            var target = resolveReference(id);
            if (target is null || !IsEnumSchema(target) || (target.Type & ~JsonSchemaType.Null) != JsonSchemaType.String)
                return false;
            // A referenced string enum only qualifies when it carries the sentinels; any other
            // enum is a meaningful alternative, not the non-finite encoding.
            if (!EnumValues(target).All(NonFiniteNumericSentinels.Contains))
                return false;
            sawSentinelEnum = true;
            return true;
        }
        if (IsNullabilityPlaceholder(branch))
            return true;
        return (branch.Type & ~JsonSchemaType.Null) == JsonSchemaType.String
            && string.IsNullOrEmpty(branch.Format)
            && (branch.Enum?.Count ?? 0) == 0;
    }

    // Enum members are JSON nodes; a quoted string node renders with quotes through ToString,
    // so the value is read directly where possible and unquoted otherwise.
    private static IEnumerable<string> EnumValues(IOpenApiSchema schema)
    {
        foreach (var node in schema.Enum ?? [])
        {
            if (node is null)
                continue;
            string? value;
            try { value = node.GetValue<string>(); }
            catch (InvalidOperationException) { value = node.ToString().Trim('"'); }
            catch (FormatException) { value = node.ToString().Trim('"'); }
            if (value is not null)
                yield return value;
        }
    }

    // Graph writes a nullable complex property as anyOf[ $ref, { type: object, nullable: true } ]
    // (user.passwordProfile). Only that exact shape is unwrapped: exactly one branch resolves to
    // a reference and every other branch is an empty nullability placeholder. Two references, or
    // a branch with real content, is a genuine union and stays unsupported rather than having
    // one arm silently chosen for the caller.
    private static string? SingleReferenceOfNullableUnion(IOpenApiSchema schema)
    {
        var branches = schema.AnyOf ?? schema.OneOf;
        if (branches is null || branches.Count == 0)
            return null;

        string? referenceId = null;
        foreach (var branch in branches)
        {
            var id = branch.GetReferenceId();
            if (id is not null)
            {
                if (referenceId is not null)
                    return null;
                referenceId = id;
                continue;
            }
            if (!IsNullabilityPlaceholder(branch))
                return null;
        }
        return referenceId;
    }

    // A branch that adds nullability and nothing else: no reference, no members, no enum, no
    // items, no format.
    private static bool IsNullabilityPlaceholder(IOpenApiSchema schema) =>
        (schema.Properties?.Count ?? 0) == 0
        && (schema.Enum?.Count ?? 0) == 0
        && schema.Items is null
        && schema.AdditionalProperties is null
        && string.IsNullOrEmpty(schema.Format)
        && (schema.AnyOf?.Count ?? 0) == 0
        && (schema.OneOf?.Count ?? 0) == 0;

    private static bool IsEnumSchema(IOpenApiSchema schema) => (schema.Enum?.Count ?? 0) > 0;

    // A body property whose Pascal name matches a path parameter would emit a duplicate C#
    // property (PATCH /devices/{device-id} has a path id AND a body property "deviceId" —
    // different values: the URL takes the object id, the body carries Entra's deviceId).
    // The published SDK keeps both reachable by suffixing the body one with "1"
    // (Update-MgDevice ships -DeviceId and -DeviceId1); reproduce that convention rather
    // than dropping a settable property. Scalars and complex properties share one parameter
    // namespace, so they are resolved together.
    public static (IReadOnlyList<CmdletProperty> Scalars, IReadOnlyList<ComplexProperty> Complex, IReadOnlyList<UntypedProperty> Untyped) ResolveParameterNameCollisions(
        IReadOnlyList<CmdletProperty> scalars, IReadOnlyList<ComplexProperty> complex, IReadOnlyList<UntypedProperty> untyped, IReadOnlyList<string> pathParamNames)
    {
        ArgumentNullException.ThrowIfNull(scalars);
        ArgumentNullException.ThrowIfNull(complex);
        ArgumentNullException.ThrowIfNull(untyped);
        ArgumentNullException.ThrowIfNull(pathParamNames);

        var taken = new HashSet<string>(pathParamNames, StringComparer.Ordinal);
        string Unique(string pascal)
        {
            var candidate = pascal;
            while (!taken.Add(candidate))
                candidate += "1";
            return candidate;
        }

        var resolvedScalars = scalars.Select(p => p with { ParameterName = Unique(p.PascalName) }).ToList();
        var resolvedComplex = complex.Select(p => p with { ParameterName = Unique(p.PascalName) }).ToList();
        var resolvedUntyped = untyped.Select(p => p with { ParameterName = Unique(p.PascalName) }).ToList();
        return (resolvedScalars, resolvedComplex, resolvedUntyped);
    }

    // The CLR type kiota gives a formatted string. Every entry is taken from a generated Graph
    // client rather than from kiota's documentation, because only the generated member type has
    // to match: a wrong name is a compile error in the module. Fully qualified so a Graph model
    // called Date or Time cannot capture the name, and because the emitted cmdlets do not import
    // Microsoft.Kiota.Abstractions.
    // IsValueType travels with the mapping rather than in a parallel set: kiota declares a
    // collection of a value type with nullable elements and a reference type without, so the two
    // facts have to move together or a new mapping silently gets the wrong element contract.
    private sealed record ScalarType(string Name, bool IsValueType);

    private static readonly Dictionary<string, ScalarType> StringFormatTypes = new(StringComparer.OrdinalIgnoreCase)
    {
        ["date-time"] = new("global::System.DateTimeOffset", IsValueType: true),
        ["uuid"] = new("global::System.Guid", IsValueType: true),
        ["duration"] = new("global::System.TimeSpan", IsValueType: true),
        ["date"] = new("global::Microsoft.Kiota.Abstractions.Date", IsValueType: true),
        ["time"] = new("global::Microsoft.Kiota.Abstractions.Time", IsValueType: true),
        ["base64url"] = new("byte[]", IsValueType: false),   // an array is a reference type
        ["binary"] = new("byte[]", IsValueType: false),      // no Stream members exist in the generated clients
    };

    // "string" -> "string[]", "int" -> "int?[]", and a non-array passes through unchanged.
    // ToList() on T[] yields List<T>, which will not assign to kiota's List<T?>, so an element
    // that is a value type must be declared nullable.
    private static string ArrayAware(ScalarType scalar, bool isArray) =>
        !isArray ? scalar.Name
        : scalar.IsValueType ? scalar.Name + "?[]"
        : scalar.Name + "[]";

    // Maps a scalar schema to its CLR type. badFormat distinguishes "not a scalar at all" from
    // "a scalar whose format has no verified mapping" — the latter must be reported rather than
    // silently bound as string, which would compile against the wrong kiota member type.
    private static bool TryMapScalar(IOpenApiSchema schema, out ScalarType mapped, out bool badFormat)
    {
        mapped = default!;
        badFormat = false;

        // Schema.Type is a flags enum and nullable unions set the Null bit, so mask it off.
        switch (schema.Type & ~JsonSchemaType.Null)
        {
            case JsonSchemaType.Boolean:
                mapped = new ScalarType("bool", IsValueType: true);
                return true;
            case JsonSchemaType.Integer or JsonSchemaType.Number:
                // Every numeric CLR type is a struct.
                mapped = new ScalarType(MapNumericType(schema), IsValueType: true);
                return true;
            case JsonSchemaType.String:
                // An enum-valued string is a named kiota type, not a scalar; it binds through
                // its $ref like a model does.
                if ((schema.Enum?.Count ?? 0) > 0)
                    return false;
                if (string.IsNullOrEmpty(schema.Format))
                {
                    mapped = new ScalarType("string", IsValueType: false);
                    return true;
                }
                if (StringFormatTypes.TryGetValue(schema.Format, out var formatted))
                {
                    mapped = formatted;
                    return true;
                }
                badFormat = true;
                return false;
            default:
                return false;
        }
    }

    // Numeric mapping: when a format is present it decides the CLR type, mirroring Kiota's
    // own mapping, so a wrapper parameter always matches the Kiota model property it is
    // assigned to. Graph's docs declare Edm.Int32 as "type: number, format: int32" — going by
    // the type alone would emit double? against Kiota's int? and not compile. int16 is absent
    // deliberately: no generated client contains a short member, so kiota widens it to int.
    // Without a format, integer stays int and number stays double (fraction and 64-bit safety).
    private static string MapNumericType(IOpenApiSchema schema) => schema.Format?.ToLowerInvariant() switch
    {
        "int64" => "long",
        "int32" => "int",
        "float" => "float",
        "double" => "double",
        "decimal" => "decimal",
        "uint8" => "byte",   // kiota emits byte? (rgbColor.r/g/b)
        _ => (schema.Type & ~JsonSchemaType.Null) == JsonSchemaType.Integer ? "int" : "double",
    };

    // Kiota cleans property symbols when generating model members: underscores are dropped
    // and the following character upper-cased ("riskEventTypes_v2" -> RiskEventTypesV2,
    // verified against a generated SignIn model). The body assignment targets that member,
    // so this mapping must match kiota's or the emitted code does not compile.
    private static readonly char[] KiotaPropertyNameSeparators = ['_', '.'];

    private static string ToKiotaPropertyName(string openApiName)
    {
        // An OData annotation is a member like any other once kiota has named it: the leading
        // "@" is dropped and the dotted parts are Pascal-cased and joined, so "@odata.id"
        // generates as OdataId (verified on microsoft.graph.referenceCreate). Splitting on "."
        // as well as "_" is what turns the annotation into a legal C# member name instead of
        // "body.@odata.id", which does not compile.
        var parts = openApiName.TrimStart('@').Split(KiotaPropertyNameSeparators, StringSplitOptions.RemoveEmptyEntries);
        return string.Concat(parts.Select(static p => char.ToUpperInvariant(p[0]) + p[1..]));
    }

    // Excludes properties a caller cannot or should not set. "id" is server-assigned.
    // "@"-prefixed names like "@odata.type" are OData control data that Kiota's serializer
    // fills in from the model type, and they are not legal C# identifiers anyway.
    // "additionalData" is the open-type bag every kiota model already exposes through
    // IAdditionalDataHolder as IDictionary<string, object>; where a spec also declares it (for
    // example security.alertV2) kiota does not emit a second member, so binding it would assign
    // a model type to the interface's dictionary and fail to compile. ReadOnly is the general
    // OpenAPI signal for server-managed. Navigation properties are relationships (user.manager,
    // user.messages), addressed through their own request paths and not settable in a body;
    // Graph marks them with x-ms-navigationProperty and does NOT set readOnly, so that
    // extension is the only signal that keeps them out.
    // The OData annotations that describe the protocol rather than the resource. @odata.type is
    // the type discriminator; the other three are paging metadata a service returns. None is
    // caller input, and the published SDK exposes a parameter for none of them.
    //
    // @odata.id is deliberately ABSENT: it is the caller-supplied target of a reference write,
    // and the only property microsoft.graph.referenceCreate has. Excluding it left every
    // *-ByRef POST/PUT cmdlet posting an empty body with no way to say what to link. The five
    // annotations here are the complete set that occurs in the v1.0 documents.
    private static readonly HashSet<string> MetadataODataAnnotations = new(StringComparer.Ordinal)
    {
        "@odata.type", "@odata.count", "@odata.nextLink", "@odata.deltaLink",
    };

    private static ExclusionPolicy? TryGetExclusionPolicy(string name, IOpenApiSchema propSchema) =>
        name switch
        {
            "id" => ExclusionPolicy.ServerAssignedId,
            "additionalData" => ExclusionPolicy.KiotaAdditionalData,
            _ when MetadataODataAnnotations.Contains(name) => ExclusionPolicy.ODataControlData,
            _ when propSchema.ReadOnly => ExclusionPolicy.ReadOnlySchema,
            _ when propSchema.Extensions?.ContainsKey("x-ms-navigationProperty") ?? false => ExclusionPolicy.NavigationProperty,
            _ => null,
        };
}
