using System.Collections.Generic;
using System.Linq;
using Microsoft.OpenApi;
using WrapperGenerator;
using Xunit;

namespace WrapperGenerator.Tests;

public sealed class SchemaPropertiesTests
{
    private static OpenApiSchema Scalar(JsonSchemaType type, bool readOnly = false) =>
        new() { Type = type, ReadOnly = readOnly };

    [Fact]
    public void KeepsPrimitivesAndPrimitiveArrays_ExcludesServerManagedAndComplex()
    {
        var body = new OpenApiSchema
        {
            Type = JsonSchemaType.Object,
            Properties = new Dictionary<string, IOpenApiSchema>
            {
                // kept
                ["displayName"] = Scalar(JsonSchemaType.String),
                ["accountEnabled"] = Scalar(JsonSchemaType.Boolean),
                ["jobTitle"] = Scalar(JsonSchemaType.Integer),
                ["businessPhones"] = new OpenApiSchema { Type = JsonSchemaType.Array, Items = Scalar(JsonSchemaType.String) },
                // excluded
                ["id"] = Scalar(JsonSchemaType.String),                       // server-assigned
                ["@odata.type"] = Scalar(JsonSchemaType.String),              // @-prefixed OData control
                ["createdDateTime"] = Scalar(JsonSchemaType.String, readOnly: true), // ReadOnly
                ["assignedLicenses"] = new OpenApiSchema                       // nested complex
                {
                    Type = JsonSchemaType.Object,
                    Properties = new Dictionary<string, IOpenApiSchema> { ["skuId"] = Scalar(JsonSchemaType.String) },
                },
            },
        };

        var names = SchemaProperties.ExtractPrimitiveProperties(body).Select(p => p.OpenApiName).ToHashSet();

        Assert.Contains("displayName", names);
        Assert.Contains("accountEnabled", names);
        Assert.Contains("jobTitle", names);
        Assert.Contains("businessPhones", names);

        Assert.DoesNotContain("id", names);
        Assert.DoesNotContain("@odata.type", names);
        Assert.DoesNotContain("createdDateTime", names);
        Assert.DoesNotContain("assignedLicenses", names);
    }

    [Fact]
    public void MapsScalarAndArrayShapes()
    {
        var body = new OpenApiSchema
        {
            Type = JsonSchemaType.Object,
            Properties = new Dictionary<string, IOpenApiSchema>
            {
                ["displayName"] = Scalar(JsonSchemaType.String),
                ["businessPhones"] = new OpenApiSchema { Type = JsonSchemaType.Array, Items = Scalar(JsonSchemaType.String) },
            },
        };

        var props = SchemaProperties.ExtractPrimitiveProperties(body);

        var scalar = props.Single(p => p.OpenApiName == "displayName");
        Assert.False(scalar.IsArray);
        Assert.Equal("string", scalar.PsTypeName);
        Assert.Equal("DisplayName", scalar.PascalName);

        var array = props.Single(p => p.OpenApiName == "businessPhones");
        Assert.True(array.IsArray);
        Assert.Equal("string[]", array.PsTypeName);
        Assert.Equal("BusinessPhones", array.PascalName);
    }

    [Fact]
    public void HasPasswordProfile_DetectsDirectAndViaAllOf()
    {
        var withProfile = new OpenApiSchema
        {
            Properties = new Dictionary<string, IOpenApiSchema> { ["passwordProfile"] = new OpenApiSchema { Type = JsonSchemaType.Object } },
        };
        Assert.True(SchemaProperties.HasPasswordProfile(withProfile));

        var viaAllOf = new OpenApiSchema { AllOf = new List<IOpenApiSchema> { withProfile } };
        Assert.True(SchemaProperties.HasPasswordProfile(viaAllOf));

        var without = new OpenApiSchema
        {
            Properties = new Dictionary<string, IOpenApiSchema> { ["displayName"] = Scalar(JsonSchemaType.String) },
        };
        Assert.False(SchemaProperties.HasPasswordProfile(without));
    }
}
