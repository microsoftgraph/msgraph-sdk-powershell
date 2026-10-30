using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Reader;
using WrapperGenerator;
using Xunit;

namespace WrapperGenerator.Tests;

public sealed class RequiredDeleteQueryTests
{
    private const string Route = "/administrativeUnits/{administrativeUnit-id}/members/$ref";
    private const string Client = "DeleteQueryFixture.Client";

    [Theory]
    [InlineData(false, "v1.0")]
    [InlineData(true, "v1.0")]
    [InlineData(false, "beta")]
    [InlineData(true, "beta")]
    public async Task NativeRequiredQueryUsesTypedMemberAndKeepsOrdinaryDeleteContract(bool inherited, string profile)
    {
        var document = await LoadFixture();
        KeepRoute(document, Route);
        var item = (OpenApiPathItem)document.Paths[Route];
        var operation = item.Operations![HttpMethod.Delete];
        if (inherited)
        {
            item.Parameters = operation.Parameters;
            operation.Parameters = [];
        }
        var source = Assert.Single((await Generate(document, profile)).Values);
        Assert.Contains("public string Id { get; set; }", source);
        Assert.Contains("[ValidateNotNullOrEmpty]", source);
        Assert.Contains("[Parameter(Mandatory = true, Position = 1,", source);
        Assert.Contains("Value for the '@id' query parameter.", source);
        Assert.Contains("requestConfiguration.QueryParameters.Id = Id;", source);
        Assert.DoesNotContain("OdataId", source);
        Assert.Contains("client.AdministrativeUnits[AdministrativeUnitId].Members.Ref.DeleteAsync(", source);
        Assert.Contains("requestConfiguration.Headers.Add(\"If-Match\", IfMatch!)", source);
        Assert.Contains("AddRequestHeaders(requestConfiguration.Headers)", source);
        Assert.Contains("ConfirmImpact = ConfirmImpact.High", source);
        Assert.Single(System.Text.RegularExpressions.Regex.Matches(source, @"ShouldProcess\("));
        Assert.Contains($"[GraphRoute(\"DELETE\", \"{Route}\")]", source);
        Assert.Contains("GetRequestAdapter()", source);
        Assert.DoesNotContain("new Uri", source);
        Assert.DoesNotContain("body", source.Replace("no body", "", StringComparison.Ordinal));
        Assert.DoesNotContain("Route {", source);
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public async Task OperationDeclarationOverridesInheritedQueryByExactNameAndLocation(bool required)
    {
        var document = await LoadFixture();
        KeepRoute(document, Route);
        var item = (OpenApiPathItem)document.Paths[Route];
        var operation = item.Operations![HttpMethod.Delete];
        item.Parameters = [Query("@id", required: !required, type: JsonSchemaType.Integer)];
        operation.Parameters = [Query("@id", required)];
        var source = Assert.Single((await Generate(document)).Values);
        Assert.Equal(required, source.Contains("public string Id ", StringComparison.Ordinal));
        Assert.Equal(required, source.Contains("QueryParameters.Id = Id", StringComparison.Ordinal));
    }

    [Theory]
    [InlineData("integer")]
    [InlineData("array")]
    [InlineData("nullable")]
    [InlineData("format")]
    [InlineData("enum")]
    [InlineData("union")]
    [InlineData("allOf")]
    [InlineData("content")]
    [InlineData("style")]
    [InlineData("reserved-encoding")]
    [InlineData("name")]
    [InlineData("missing-schema")]
    [InlineData("body")]
    [InlineData("path-collision")]
    [InlineData("header-collision")]
    [InlineData("common-collision")]
    [InlineData("member-collision")]
    [InlineData("duplicate")]
    [InlineData("inherited-duplicate")]
    public async Task UnsupportedRequiredContractFailsExplicitly(string scenario)
    {
        var document = await LoadFixture();
        KeepRoute(document, Route);
        var item = (OpenApiPathItem)document.Paths[Route];
        var operation = item.Operations![HttpMethod.Delete];
        var query = Query("@id");
        var schema = (OpenApiSchema)query.Schema!;
        operation.Parameters = [query];
        switch (scenario)
        {
            case "integer": schema.Type = JsonSchemaType.Integer; break;
            case "array": schema.Type = JsonSchemaType.Array; schema.Items = new OpenApiSchema { Type = JsonSchemaType.String }; break;
            case "nullable": schema.Type |= JsonSchemaType.Null; break;
            case "format": schema.Format = "uuid"; break;
            case "enum": schema.Enum = [System.Text.Json.Nodes.JsonValue.Create("x")!]; break;
            case "union": schema.OneOf = [new OpenApiSchema { Type = JsonSchemaType.String }]; break;
            case "allOf": schema.AllOf = [new OpenApiSchema { Type = JsonSchemaType.String }]; break;
            case "content": query.Content = new Dictionary<string, IOpenApiMediaType> { ["application/json"] = new OpenApiMediaType { Schema = schema } }; break;
            case "style": query.Style = ParameterStyle.DeepObject; break;
            case "reserved-encoding": query.AllowReserved = true; break;
            case "name": query.Name = "a-b"; break;
            case "missing-schema": query.Schema = null; break;
            case "body": operation.RequestBody = new OpenApiRequestBody(); break;
            case "path-collision": query.Name = "administrativeUnitId"; break;
            case "header-collision": operation.Parameters.Add(new OpenApiParameter { Name = "Id", In = ParameterLocation.Header }); break;
            case "common-collision": query.Name = "headers"; break;
            case "member-collision": operation.Parameters.Add(Query("id", required: false)); break;
            case "duplicate": operation.Parameters.Add(Query("@id")); break;
            case "inherited-duplicate": item.Parameters = [Query("@id"), Query("@id")]; break;
        }
        var failure = await Assert.ThrowsAsync<InvalidOperationException>(() => Generate(document));
        Assert.Contains("DELETE", failure.Message);
        Assert.Contains(Route, failure.Message);
    }

    [Theory]
    [InlineData("/administrativeUnits/{administrativeUnit-id}/members/{directoryObject-id}/$ref")]
    [InlineData("/administrativeUnits/{administrativeUnit-id}")]
    public async Task NoQueryNeighborsKeepTheExactExistingEmitterOutput(string route)
    {
        var document = await LoadFixture();
        KeepRoute(document, route);
        var operation = document.Paths[route].Operations![HttpMethod.Delete];
        var naming = Naming.Resolve(new OperationInfo(HttpMethod.Delete, route,
            (operation.Parameters ?? []).Where(p => p.In == ParameterLocation.Header).Select(p => p.Name!).ToArray()),
            new GeneratorConfig(Client, ".", UseCollisionData: false));
        Assert.Equal(CmdletEmitter.EmitRemove(naming, new EmitContext(Client)),
            Assert.Single((await Generate(document)).Values));
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public async Task NativeRequiredQueriesDoNotBecomeNaturalIdDiscriminators(bool inherited)
    {
        const string root = "/profiles/{profile-id}/widgets/{widget-id}";
        const string nested = "/profiles/{profile-id}/widgets/{parent-id}/widgets/{widget-id}";
        var document = new OpenApiDocument { Paths = new OpenApiPaths() };
        foreach (var path in new[] { root, nested })
        {
            document.Paths[path] = new OpenApiPathItem
            {
                Parameters = inherited ? [Query("@id")] : [],
                Operations = new Dictionary<HttpMethod, OpenApiOperation>
                {
                    [HttpMethod.Delete] = new()
                    {
                        Parameters = inherited ? [] : [Query("@id")],
                        Responses = new OpenApiResponses { ["204"] = new OpenApiResponse { Description = "Success" } },
                    },
                },
            };
        }
        var group = new CmdletConfigurator.OperationVariantGroup([
            new("DELETE", root, "Root"), new("DELETE", nested, "Parent")], "Root");
        var entry = CmdletConfigurator.GroupVariants(group, "Required queries cannot discriminate natural path-ID variants.");
        var failure = await Assert.ThrowsAsync<InvalidOperationException>(() => Generate(document, entries: [entry]));
        Assert.Contains("Unsupported mutation group member, input location or query", failure.Message);
    }

    private static OpenApiParameter Query(string name, bool required = true, JsonSchemaType type = JsonSchemaType.String) => new()
    {
        Name = name, In = ParameterLocation.Query, Required = required, Style = ParameterStyle.Form, Explode = false,
        Schema = new OpenApiSchema { Type = type },
    };

    private static async Task<OpenApiDocument> LoadFixture()
    {
        var settings = new OpenApiReaderSettings();
        settings.AddYamlReader();
        await using var stream = File.OpenRead(Path.Combine(AppContext.BaseDirectory, "Fixtures", "required-delete-query.yml"));
        return (await OpenApiDocument.LoadAsync(stream, settings: settings)).Document!;
    }

    private static void KeepRoute(OpenApiDocument document, string route)
    {
        foreach (var path in document.Paths.Keys.Where(p => p != route).ToArray())
            document.Paths.Remove(path);
    }

    private static async Task<Dictionary<string, string>> Generate(OpenApiDocument document, string profile = "beta",
        IReadOnlyList<CmdletConfigurator.Entry>? entries = null)
    {
        var output = Path.Combine(Path.GetTempPath(), "wrapper-delete-tests", Guid.NewGuid().ToString("N"));
        try
        {
            var service = new PowerShellWrapperGenerationService(document,
                new GeneratorConfig(Client, output, UseCollisionData: false), NullLogger.Instance, profile, entries);
            await service.GenerateAsync(CancellationToken.None);
            return Directory.GetFiles(output, "*.g.cs").ToDictionary(p => Path.GetFileName(p), File.ReadAllText);
        }
        finally
        {
            if (Directory.Exists(output))
                Directory.Delete(output, recursive: true);
        }
    }
}
