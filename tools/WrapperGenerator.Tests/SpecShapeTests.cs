using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Reader;
using Xunit;

namespace WrapperGenerator.Tests;

// Pins the two spec facts complex-property binding depends on. Both are properties of the
// Graph documents AND of the reader that parses them, so an in-memory OpenApiSchema cannot
// prove either - these parse real YAML.
//
// If either breaks (a reader upgrade drops unknown extensions, or Graph changes how it marks
// navigation properties), binding would start emitting parameters for navigation properties
// like -AdhocCalls or -AppRoleAssignments, which are not request-body fields at all. That
// failure would be silent in the generator and only visible as nonsense cmdlet surface, so it
// is gated here instead.
public sealed class SpecShapeTests
{
    // The reader models a $ref as an OpenApiSchemaReference rather than an inlined schema;
    // read it through the public API here so these tests pin the reader, not our helper.
    private static string? ReferenceIdOf(IOpenApiSchema schema) =>
        schema is OpenApiSchemaReference reference ? reference.Reference?.Id : null;

    private static OpenApiDocument Parse(string yaml)
    {
        var settings = new OpenApiReaderSettings();
        settings.AddYamlReader();
        using var stream = new MemoryStream(Encoding.UTF8.GetBytes(yaml));
        var result = OpenApiDocument.LoadAsync(stream, settings: settings, cancellationToken: CancellationToken.None)
            .GetAwaiter().GetResult();
        return result.Document!;
    }

    // Graph marks navigation properties with x-ms-navigationProperty: true and does NOT set
    // readOnly on them, so the extension is the only signal that keeps them out of the bound
    // parameter set.
    [Fact]
    public void ReaderPreservesNavigationPropertyExtension()
    {
        const string yaml = """
            openapi: 3.0.1
            info: { title: probe, version: 1.0.0 }
            paths: {}
            components:
              schemas:
                probe.entity:
                  type: object
                  properties:
                    displayName:
                      type: string
                    adhocCalls:
                      type: array
                      items:
                        $ref: '#/components/schemas/probe.child'
                      x-ms-navigationProperty: true
                probe.child:
                  type: object
                  properties:
                    id: { type: string }
            """;

        var entity = Parse(yaml).Components!.Schemas!["probe.entity"];
        var nav = entity.Properties!["adhocCalls"];
        var structural = entity.Properties!["displayName"];

        Assert.True(nav.Extensions is not null && nav.Extensions.ContainsKey("x-ms-navigationProperty"),
            "Reader dropped x-ms-navigationProperty; navigation properties can no longer be excluded from body binding.");
        Assert.False(nav.ReadOnly, "Graph does not set readOnly on navigation properties - the extension is the only signal.");
        Assert.False(structural.Extensions?.ContainsKey("x-ms-navigationProperty") ?? false);
    }

    // A nullable complex property is expressed as anyOf[ $ref, { type: object, nullable: true } ]
    // - verified against user.passwordProfile, the property that motivated typed binding. The
    // branch carrying the $ref must stay resolvable through the reader.
    [Fact]
    public void ReaderPreservesNullableRefCompositionShape()
    {
        const string yaml = """
            openapi: 3.0.1
            info: { title: probe, version: 1.0.0 }
            paths: {}
            components:
              schemas:
                probe.user:
                  type: object
                  properties:
                    passwordProfile:
                      anyOf:
                        - $ref: '#/components/schemas/probe.passwordProfile'
                        - type: object
                          nullable: true
                probe.passwordProfile:
                  type: object
                  properties:
                    password: { type: string }
            """;

        var property = Parse(yaml).Components!.Schemas!["probe.user"].Properties!["passwordProfile"];

        Assert.NotNull(property.AnyOf);
        Assert.Equal(2, property.AnyOf!.Count);
        var refs = property.AnyOf.Where(b => ReferenceIdOf(b) is not null).ToList();
        Assert.Single(refs);
        Assert.Equal("probe.passwordProfile", ReferenceIdOf(refs[0]));
    }

    // A $ref does not imply an object: microsoft.graph.importance is a string enum reached the
    // same way passwordProfile is. Classification has to resolve the reference and look at the
    // target, or enums would be bound as model-typed parameters that do not compile.
    [Fact]
    public void ReferencedSchemaMayBeAnEnumNotAnObject()
    {
        const string yaml = """
            openapi: 3.0.1
            info: { title: probe, version: 1.0.0 }
            paths: {}
            components:
              schemas:
                probe.message:
                  type: object
                  properties:
                    importance:
                      $ref: '#/components/schemas/probe.importance'
                probe.importance:
                  type: string
                  enum: [low, normal, high]
            """;

        var document = Parse(yaml);
        var importance = document.Components!.Schemas!["probe.message"].Properties!["importance"];

        var referenceId = ReferenceIdOf(importance);
        Assert.Equal("probe.importance", referenceId);

        var target = document.Components.Schemas[referenceId!];
        Assert.True((target.Type & ~JsonSchemaType.Null) == JsonSchemaType.String);
        Assert.NotEmpty(target.Enum!);
    }
}
