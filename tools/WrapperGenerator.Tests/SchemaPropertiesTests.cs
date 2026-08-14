using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using Microsoft.OpenApi;
using WrapperGenerator;
using Xunit;

namespace WrapperGenerator.Tests;

public sealed class SchemaPropertiesTests
{
    private static OpenApiSchema Scalar(JsonSchemaType type, bool readOnly = false, string? format = null) =>
        new() { Type = type, ReadOnly = readOnly, Format = format };

    // Component schemas the tests' $refs point at. Classification resolves a reference before
    // deciding what it is, so the target's shape is what matters, not the reference itself.
    private static readonly Dictionary<string, IOpenApiSchema> Components = new(StringComparer.Ordinal)
    {
        ["graph.passwordProfile"] = new OpenApiSchema
        {
            Type = JsonSchemaType.Object,
            Properties = new Dictionary<string, IOpenApiSchema> { ["password"] = Scalar(JsonSchemaType.String) },
        },
        ["graph.assignedLicense"] = new OpenApiSchema { Type = JsonSchemaType.Object },
        ["graph.importance"] = new OpenApiSchema { Type = JsonSchemaType.String, Enum = [new System.Text.Json.Nodes.JsonArray()] },
        // Graph's marker for "this numeric may also arrive as INF/-INF/NaN". The VALUES are what
        // identify the encoding, so they are real here rather than a placeholder.
        ["graph.referenceNumeric"] = new OpenApiSchema
        {
            Type = JsonSchemaType.String,
            Enum = [JsonValue.Create("-INF")!, JsonValue.Create("INF")!, JsonValue.Create("NaN")!],
        },
        // A string enum that is NOT the sentinel set: a meaningful alternative, not an encoding.
        ["graph.currency"] = new OpenApiSchema
        {
            Type = JsonSchemaType.String,
            Enum = [JsonValue.Create("usd")!, JsonValue.Create("eur")!],
        },
    };

    private static IOpenApiSchema? Resolve(string id) => Components.TryGetValue(id, out var s) ? s : null;

    private static BodyProperties ClassifyBody(Dictionary<string, IOpenApiSchema> properties, params string[] required) =>
        SchemaProperties.Classify(
            new OpenApiSchema
            {
                Type = JsonSchemaType.Object,
                Properties = properties,
                Required = new HashSet<string>(required, StringComparer.Ordinal),
            },
            Resolve);

    // Kiota strips underscores when naming model members: signIn's "riskEventTypes_v2"
    // becomes RiskEventTypesV2 (verified against a generated SignIn model). The body
    // assignment targets that member, so extraction must produce the same name.
    [Fact]
    public void MapsUnderscorePropertyNamesTheWayKiotaDoes()
    {
        var classified = ClassifyBody(new Dictionary<string, IOpenApiSchema>
        {
            ["riskEventTypes_v2"] = new OpenApiSchema { Type = JsonSchemaType.Array, Items = Scalar(JsonSchemaType.String) },
        });

        var property = Assert.Single(classified.Scalars);
        Assert.Equal("RiskEventTypesV2", property.PascalName);
        Assert.Equal("riskEventTypes_v2", property.OpenApiName);
    }

    // PATCH /devices/{device-id} carries a body property "deviceId" (Entra's device
    // identifier — a different value from the path's object id). The published SDK ships
    // both as -DeviceId and -DeviceId1; the resolver reproduces that "1" suffix. The body
    // assignment target (PascalName) must stay untouched — only the parameter renames.
    [Fact]
    public void SuffixesBodyPropertyThatCollidesWithPathParameter()
    {
        var scalars = new[]
        {
            new CmdletProperty("deviceId", "DeviceId", "string", IsArray: false),
            new CmdletProperty("displayName", "DisplayName", "string", IsArray: false),
        };

        var (resolved, _, _) = SchemaProperties.ResolveParameterNameCollisions(scalars, [], [], ["DeviceId"]);

        var renamed = Assert.Single(resolved, p => p.OpenApiName == "deviceId");
        Assert.Equal("DeviceId1", renamed.ParameterName);
        Assert.Equal("DeviceId", renamed.PascalName);

        var untouched = Assert.Single(resolved, p => p.OpenApiName == "displayName");
        Assert.Equal("DisplayName", untouched.ParameterName);
    }

    // Scalars and complex properties share one C# property namespace on the emitted class, so
    // a complex property must not be handed a name a scalar (or a path id) already took.
    [Fact]
    public void ResolvesCollisionsAcrossScalarAndComplexProperties()
    {
        var scalars = new[] { new CmdletProperty("photo", "Photo", "string", IsArray: false) };
        var complex = new[] { new ComplexProperty("photo2", "Photo", "graph.passwordProfile", IsArray: false, IsEnum: false) };

        var (resolvedScalars, resolvedComplex, _) = SchemaProperties.ResolveParameterNameCollisions(scalars, complex, [], []);

        Assert.Equal("Photo", resolvedScalars[0].ParameterName);
        Assert.Equal("Photo1", resolvedComplex[0].ParameterName);
        Assert.Equal("Photo", resolvedComplex[0].PascalName);
    }

    [Fact]
    public void KeepsPrimitivesAndPrimitiveArrays_ExcludesServerManagedAndNavigation()
    {
        var classified = ClassifyBody(new Dictionary<string, IOpenApiSchema>
        {
            // bound
            ["displayName"] = Scalar(JsonSchemaType.String),
            ["accountEnabled"] = Scalar(JsonSchemaType.Boolean),
            ["businessPhones"] = new OpenApiSchema { Type = JsonSchemaType.Array, Items = Scalar(JsonSchemaType.String) },
            // excluded
            ["id"] = Scalar(JsonSchemaType.String),                                // server-assigned
            ["@odata.type"] = Scalar(JsonSchemaType.String),                       // OData control data
            ["createdDateTime"] = Scalar(JsonSchemaType.String, readOnly: true),   // ReadOnly
            ["manager"] = new OpenApiSchema                                        // relationship, not a body field
            {
                Type = JsonSchemaType.Object,
                Extensions = new Dictionary<string, IOpenApiExtension> { ["x-ms-navigationProperty"] = new JsonNodeExtension(true) },
            },
        });

        var names = classified.Scalars.Select(p => p.OpenApiName).ToHashSet();
        Assert.Contains("displayName", names);
        Assert.Contains("accountEnabled", names);
        Assert.Contains("businessPhones", names);

        Assert.Equal(4, classified.Excluded.Count);
        Assert.Empty(classified.Complex);
        Assert.Empty(classified.Unsupported);
    }

    // The property that motivated typed binding: Graph writes a nullable complex property as
    // anyOf[$ref, {type: object, nullable: true}], and it must bind to the referenced model.
    [Fact]
    public void BindsNullableReferenceComposition()
    {
        var classified = ClassifyBody(new Dictionary<string, IOpenApiSchema>
        {
            ["passwordProfile"] = new OpenApiSchema
            {
                AnyOf =
                [
                    new OpenApiSchemaReference("graph.passwordProfile"),
                    new OpenApiSchema { Type = JsonSchemaType.Object },
                ],
            },
        }, required: "passwordProfile");

        var complex = Assert.Single(classified.Complex);
        Assert.Equal("passwordProfile", complex.OpenApiName);
        Assert.Equal("PasswordProfile", complex.PascalName);
        Assert.Equal("graph.passwordProfile", complex.ReferenceId);
        Assert.False(complex.IsArray);
    }

    [Fact]
    public void BindsDirectReferenceAndReferenceArray()
    {
        var classified = ClassifyBody(new Dictionary<string, IOpenApiSchema>
        {
            ["passwordProfile"] = new OpenApiSchemaReference("graph.passwordProfile"),
            ["assignedLicenses"] = new OpenApiSchema
            {
                Type = JsonSchemaType.Array,
                Items = new OpenApiSchemaReference("graph.assignedLicense"),
            },
        });

        var single = Assert.Single(classified.Complex, p => p.OpenApiName == "passwordProfile");
        Assert.False(single.IsArray);

        var array = Assert.Single(classified.Complex, p => p.OpenApiName == "assignedLicenses");
        Assert.True(array.IsArray);
        Assert.Equal("graph.assignedLicense", array.ReferenceId);
    }

    // An enum reference binds like a model reference: kiota emits both as named types in the
    // models namespace (Models/Importance.cs holds "public enum Importance"), so one path
    // resolves both. PowerShell converts a string argument to the enum on binding.
    [Fact]
    public void BindsReferenceToEnumAsANamedType()
    {
        var classified = ClassifyBody(new Dictionary<string, IOpenApiSchema>
        {
            ["importance"] = new OpenApiSchemaReference("graph.importance"),
        });

        Assert.Empty(classified.Unsupported);
        var complex = Assert.Single(classified.Complex);
        Assert.Equal("importance", complex.OpenApiName);
        Assert.Equal("graph.importance", complex.ReferenceId);
    }

    // Every mapping here was read off a generated Graph client; a wrong CLR name is a compile
    // error in the module, so these are pinned rather than trusted to kiota's documentation.
    [Theory]
    [InlineData("date-time", "global::System.DateTimeOffset")]
    [InlineData("uuid", "global::System.Guid")]
    [InlineData("duration", "global::System.TimeSpan")]
    [InlineData("date", "global::Microsoft.Kiota.Abstractions.Date")]
    [InlineData("time", "global::Microsoft.Kiota.Abstractions.Time")]
    [InlineData("base64url", "byte[]")]
    [InlineData("binary", "byte[]")]
    public void MapsFormattedStringsToTheTypeKiotaGenerates(string format, string expected)
    {
        var classified = ClassifyBody(new Dictionary<string, IOpenApiSchema>
        {
            ["value"] = Scalar(JsonSchemaType.String, format: format),
        });

        Assert.Equal(expected, Assert.Single(classified.Scalars).PsTypeName);
    }

    // An unrecognised format must be reported, never bound as plain string: kiota would have
    // mapped it to some other CLR type and the assignment would not compile.
    [Fact]
    public void ReportsUnknownStringFormatRatherThanFallingBackToString()
    {
        var classified = ClassifyBody(new Dictionary<string, IOpenApiSchema>
        {
            ["odd"] = Scalar(JsonSchemaType.String, format: "some-future-format"),
        });

        Assert.Empty(classified.Scalars);
        Assert.Equal(UnsupportedShape.UnknownFormat, Assert.Single(classified.Unsupported).Shape);
    }

    // uint8 generates as byte? (rgbColor.r/g/b). int16 has no short? anywhere in the generated
    // clients, so kiota widens it to int and so must we.
    [Theory]
    [InlineData("uint8", JsonSchemaType.Integer, "byte")]
    [InlineData("int16", JsonSchemaType.Integer, "int")]
    public void MapsNarrowIntegerFormatsTheWayKiotaDoes(string format, JsonSchemaType type, string expected)
    {
        var classified = ClassifyBody(new Dictionary<string, IOpenApiSchema>
        {
            ["n"] = Scalar(type, format: format),
        });

        Assert.Equal(expected, Assert.Single(classified.Scalars).PsTypeName);
    }

    // Graph writes a numeric that may also carry OData's INF/NaN string as a three-way union.
    // Kiota keeps the numeric (bookingService.price -> double?), so the numeric branch binds.
    [Fact]
    public void BindsTheNumericBranchOfGraphsInfinityUnion()
    {
        var classified = ClassifyBody(new Dictionary<string, IOpenApiSchema>
        {
            ["price"] = new OpenApiSchema
            {
                OneOf =
                [
                    new OpenApiSchema { Type = JsonSchemaType.Number, Format = "double" },
                    new OpenApiSchema { Type = JsonSchemaType.String },
                    new OpenApiSchemaReference("graph.referenceNumeric"),
                ],
            },
        });

        Assert.Empty(classified.Unsupported);
        Assert.Equal("double", Assert.Single(classified.Scalars).PsTypeName);
    }

    // Without the sentinel enum, "number or string" is an ordinary union whose string arm means
    // something. Binding the numeric would silently discard it, so the sentinel is required
    // evidence that the string arm is only OData's non-finite encoding.
    [Fact]
    public void ReportsNumericAndPlainStringUnionWithNoSentinelEnum()
    {
        var classified = ClassifyBody(new Dictionary<string, IOpenApiSchema>
        {
            ["amount"] = new OpenApiSchema
            {
                OneOf =
                [
                    new OpenApiSchema { Type = JsonSchemaType.Number, Format = "double" },
                    new OpenApiSchema { Type = JsonSchemaType.String },
                ],
            },
        });

        Assert.Empty(classified.Scalars);
        Assert.Equal(UnsupportedShape.Union, Assert.Single(classified.Unsupported).Shape);
    }

    // A referenced string enum that is not the sentinel set is a real alternative too.
    [Fact]
    public void ReportsNumericUnionWhoseEnumIsNotTheSentinelSet()
    {
        var classified = ClassifyBody(new Dictionary<string, IOpenApiSchema>
        {
            ["price"] = new OpenApiSchema
            {
                OneOf =
                [
                    new OpenApiSchema { Type = JsonSchemaType.Number, Format = "double" },
                    new OpenApiSchemaReference("graph.currency"),
                ],
            },
        });

        Assert.Empty(classified.Scalars);
        Assert.Equal(UnsupportedShape.Union, Assert.Single(classified.Unsupported).Shape);
    }

    // A numeric beside a MODEL is a real choice, not the INF encoding. Recognising only
    // "exactly one numeric branch" would bind the numeric here and silently discard the model
    // arm, so the whole structure has to match.
    [Fact]
    public void ReportsUnionOfANumericAndAModel()
    {
        var classified = ClassifyBody(new Dictionary<string, IOpenApiSchema>
        {
            ["either"] = new OpenApiSchema
            {
                OneOf =
                [
                    new OpenApiSchema { Type = JsonSchemaType.Number, Format = "double" },
                    new OpenApiSchemaReference("graph.passwordProfile"),
                ],
            },
        });

        Assert.Empty(classified.Scalars);
        Assert.Equal(UnsupportedShape.Union, Assert.Single(classified.Unsupported).Shape);
    }

    // A numeric beside a formatted string is likewise not the INF encoding: the string arm
    // carries its own CLR type rather than being a stringish alternative.
    [Fact]
    public void ReportsUnionOfANumericAndAFormattedString()
    {
        var classified = ClassifyBody(new Dictionary<string, IOpenApiSchema>
        {
            ["either"] = new OpenApiSchema
            {
                OneOf =
                [
                    new OpenApiSchema { Type = JsonSchemaType.Number, Format = "double" },
                    new OpenApiSchema { Type = JsonSchemaType.String, Format = "date-time" },
                ],
            },
        });

        Assert.Empty(classified.Scalars);
        Assert.Equal(UnsupportedShape.Union, Assert.Single(classified.Unsupported).Shape);
    }

    // Two numeric branches is a real choice, not the INF encoding: binding one would silently
    // pick a type for the caller.
    [Fact]
    public void ReportsUnionWithMoreThanOneNumericBranch()
    {
        var classified = ClassifyBody(new Dictionary<string, IOpenApiSchema>
        {
            ["ambiguous"] = new OpenApiSchema
            {
                OneOf =
                [
                    new OpenApiSchema { Type = JsonSchemaType.Number, Format = "double" },
                    new OpenApiSchema { Type = JsonSchemaType.Integer, Format = "int64" },
                ],
            },
        });

        Assert.Empty(classified.Scalars);
        Assert.Equal(UnsupportedShape.Union, Assert.Single(classified.Unsupported).Shape);
    }

    // Only a single reference plus pure nullability unwraps. A choice between two real
    // schemas is a union: picking one arm silently would bind the caller to the wrong type.
    [Fact]
    public void ReportsGenuineUnionRatherThanChoosingABranch()
    {
        var classified = ClassifyBody(new Dictionary<string, IOpenApiSchema>
        {
            ["either"] = new OpenApiSchema
            {
                AnyOf =
                [
                    new OpenApiSchemaReference("graph.passwordProfile"),
                    new OpenApiSchemaReference("graph.assignedLicense"),
                ],
            },
        });

        Assert.Empty(classified.Complex);
        Assert.Equal(UnsupportedShape.Union, Assert.Single(classified.Unsupported).Shape);
    }

    // An anonymous object still has no name kiota would agree with, so it stays reported even
    // though a formatted scalar beside it now binds.
    [Fact]
    public void ReportsInlineObjectWhileBindingAFormattedScalarBesideIt()
    {
        var classified = ClassifyBody(new Dictionary<string, IOpenApiSchema>
        {
            ["anonymous"] = new OpenApiSchema
            {
                Type = JsonSchemaType.Object,
                Properties = new Dictionary<string, IOpenApiSchema> { ["x"] = Scalar(JsonSchemaType.String) },
            },
            ["birthday"] = Scalar(JsonSchemaType.String, format: "date-time"),
        });

        Assert.Equal(UnsupportedShape.InlineObject, Assert.Single(classified.Unsupported).Shape);
        Assert.Equal("global::System.DateTimeOffset", Assert.Single(classified.Scalars, p => p.OpenApiName == "birthday").PsTypeName);
    }

    // Every property seen lands in exactly one bucket. The coverage sweep relies on this
    // identity holding, so a shape that silently falls through would be caught here.
    [Fact]
    public void EveryPropertyIsAccountedForExactlyOnce()
    {
        var properties = new Dictionary<string, IOpenApiSchema>
        {
            ["displayName"] = Scalar(JsonSchemaType.String),
            ["businessPhones"] = new OpenApiSchema { Type = JsonSchemaType.Array, Items = Scalar(JsonSchemaType.String) },
            ["passwordProfile"] = new OpenApiSchemaReference("graph.passwordProfile"),
            ["importance"] = new OpenApiSchemaReference("graph.importance"),
            ["birthday"] = Scalar(JsonSchemaType.String, format: "date-time"),
            ["id"] = Scalar(JsonSchemaType.String),
        };

        var classified = ClassifyBody(properties);

        Assert.Equal(
            properties.Count,
            classified.Scalars.Count + classified.Complex.Count + classified.Unsupported.Count + classified.Excluded.Count);
    }

    // PropertiesSeen is counted independently of the buckets, so the reported total cannot be
    // a restatement of their sum: every property reached is either routed or the classifier
    // throws. Asserting it here keeps the runtime reconciliation line meaningful.
    [Fact]
    public void ReportsIndependentlyCountedTotalThatMatchesTheBuckets()
    {
        var properties = new Dictionary<string, IOpenApiSchema>
        {
            ["displayName"] = Scalar(JsonSchemaType.String),
            ["passwordProfile"] = new OpenApiSchemaReference("graph.passwordProfile"),
            ["importance"] = new OpenApiSchemaReference("graph.importance"),
            ["id"] = Scalar(JsonSchemaType.String),
        };

        var classified = ClassifyBody(properties);

        Assert.Equal(properties.Count, classified.PropertiesSeen);
        Assert.Equal(
            classified.PropertiesSeen,
            classified.Scalars.Count + classified.Complex.Count + classified.Unsupported.Count + classified.Excluded.Count);
    }

    // A property inherited through allOf and also restated on the child is one property, not
    // two: the dedupe must be reflected in the independent count as well, or the invariant
    // would fire spuriously on a perfectly normal Graph schema.
    [Fact]
    public void CountsAPropertyOnceWhenAllOfRestatesIt()
    {
        var classified = SchemaProperties.Classify(
            new OpenApiSchema
            {
                Type = JsonSchemaType.Object,
                AllOf =
                [
                    new OpenApiSchema
                    {
                        Properties = new Dictionary<string, IOpenApiSchema> { ["displayName"] = Scalar(JsonSchemaType.String) },
                    },
                ],
                Properties = new Dictionary<string, IOpenApiSchema> { ["displayName"] = Scalar(JsonSchemaType.String) },
            },
            Resolve);

        Assert.Equal(1, classified.PropertiesSeen);
        Assert.Single(classified.Scalars);
    }

    [Fact]
    public void MapsNumericFormatsWithoutDataLoss()
    {
        var classified = ClassifyBody(new Dictionary<string, IOpenApiSchema>
        {
            ["riskScore"] = Scalar(JsonSchemaType.Number),                      // fractions must survive
            ["sizeInBytes"] = Scalar(JsonSchemaType.Integer, format: "int64"), // values > 2^31 must survive
            ["retryCount"] = Scalar(JsonSchemaType.Integer, format: "int32"),
            ["plainCount"] = Scalar(JsonSchemaType.Integer),
            // Graph's docs declare Edm.Int32/Int64 as type "number" with the format carrying
            // the real type (mailFolder.childFolderCount, messageRule.sequence). The format
            // must win or the parameter type contradicts the Kiota model and won't compile.
            ["childFolderCount"] = Scalar(JsonSchemaType.Number, format: "int32"),
            ["quotaUsed"] = Scalar(JsonSchemaType.Number, format: "int64"),
            ["confidence"] = Scalar(JsonSchemaType.Number, format: "float"),
        });

        var props = classified.Scalars;
        Assert.Equal("double", props.Single(p => p.OpenApiName == "riskScore").PsTypeName);
        Assert.Equal("long", props.Single(p => p.OpenApiName == "sizeInBytes").PsTypeName);
        Assert.Equal("int", props.Single(p => p.OpenApiName == "retryCount").PsTypeName);
        Assert.Equal("int", props.Single(p => p.OpenApiName == "plainCount").PsTypeName);
        Assert.Equal("int", props.Single(p => p.OpenApiName == "childFolderCount").PsTypeName);
        Assert.Equal("long", props.Single(p => p.OpenApiName == "quotaUsed").PsTypeName);
        Assert.Equal("float", props.Single(p => p.OpenApiName == "confidence").PsTypeName);
    }
}
