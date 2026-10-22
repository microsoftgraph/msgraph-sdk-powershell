using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.OpenApi;
using WrapperGenerator;
using Xunit;

namespace WrapperGenerator.Tests;

public sealed class ReferenceDeleteTests
{
    private const string Collection = "/administrativeUnits/{administrativeUnit-id}/members/$ref";
    private const string Item = "/administrativeUnits/{administrativeUnit-id}/members/{directoryObject-id}/$ref";
    private const string Client = "Microsoft.Graph.PowerShell.ReferenceDelete.Client";
    private const string Command = "RemoveMgAdministrativeUnitMemberByRef";

    [Fact]
    public async Task ReviewedReferenceDeletesBindTheRequiredQueryOnlyOnTheCollectionWorker()
    {
        var files = await Generate(Document(), Group());

        Assert.Equal(3, files.Count);
        var dispatcher = files[Command + ".g.cs"];
        Assert.Contains("DefaultParameterSetName = \"ItemInvoke\"", dispatcher);
        Assert.Contains("[Parameter(Mandatory = true, ParameterSetName = \"CollectionInvoke\")]", dispatcher);
        Assert.Contains("public string MemberReferenceUri", dispatcher);
        Assert.Contains("[Parameter(Mandatory = true, ParameterSetName = \"ItemInvoke\", Position = 1)]", dispatcher);
        Assert.Contains("public string DirectoryObjectId", dispatcher);
        Assert.DoesNotContain("public string Route", dispatcher);
        Assert.DoesNotContain("ValidateSet", dispatcher);
        Assert.DoesNotContain("ParameterSetName = \"CollectionInvoke\", Position = 1", dispatcher);
        Assert.Contains("new Dictionary<string, object>(MyInvocation.BoundParameters)", dispatcher);
        Assert.Contains("PipelineResultTypes.Output | PipelineResultTypes.Error", dispatcher);
        Assert.Contains("ThrowTerminatingError(rex.ErrorRecord)", dispatcher);

        var collection = files[Command + "_Route0.g.cs"].ReplaceLineEndings("\n");
        Assert.Contains("[Parameter(Mandatory = true)]\n        public string MemberReferenceUri { get; set; } = string.Empty;", collection);
        Assert.Contains("client.AdministrativeUnits[AdministrativeUnitId].Members.Ref.DeleteAsync(", collection);
        Assert.Contains("if (this.IsParameterBound(nameof(MemberReferenceUri)))", collection);
        Assert.Contains("requestConfiguration.QueryParameters.Id = MemberReferenceUri;", collection);
        Assert.DoesNotContain("QueryParameters.MemberReferenceUri", collection);
        Assert.DoesNotContain("public string DirectoryObjectId", collection);

        var item = files[Command + "_Route1.g.cs"];
        Assert.Contains("client.AdministrativeUnits[AdministrativeUnitId].Members[DirectoryObjectId].Ref.DeleteAsync(", item);
        Assert.DoesNotContain("MemberReferenceUri", item);
        Assert.DoesNotContain("QueryParameters", item);
        foreach (var source in files.Values)
        {
            Assert.Contains("SupportsShouldProcess = true", source);
            Assert.Contains("public string? IfMatch", source);
            Assert.Contains("ex is not PipelineStoppedException && ex is not OperationCanceledException", source);
        }
        foreach (var worker in new[] { collection, item })
        {
            Assert.Contains("if (!ShouldProcess(", worker);
            Assert.Contains("requestConfiguration.Headers.Add(\"If-Match\", IfMatch!);", worker);
            Assert.Contains("AddRequestHeaders(requestConfiguration.Headers);", worker);
            Assert.Contains("ThrowGraphRequestFailed(ex,", worker);
        }
    }

    [Fact]
    public void RemoveEmitterSupportsOptionalQueriesAndIndependentTypedBuilderNames()
    {
        var naming = Naming.Resolve(new OperationInfo(HttpMethod.Delete, Collection)) with
        {
            HeaderParams = [new("If-Match", "IfMatch")],
        };
        var source = CmdletEmitter.EmitRemove(naming, new EmitContext(Client),
            [new("@id", "MemberReferenceUri", false) { BuilderPropertyName = "Id" }])
            .ReplaceLineEndings("\n");

        Assert.Contains("[Parameter(Mandatory = false)]\n        public string? MemberReferenceUri { get; set; }", source);
        Assert.Contains("requestConfiguration.QueryParameters.Id = MemberReferenceUri;", source);
        Assert.Contains("requestConfiguration.Headers.Add(\"If-Match\", IfMatch!);", source);
        Assert.Contains("AddRequestHeaders(requestConfiguration.Headers);", source);
        Assert.Contains("if (!ShouldProcess(", source);
        Assert.DoesNotContain("QueryParameters.MemberReferenceUri", source);
    }

    [Fact]
    public void RemoveEmitterKeepsNullAndEmptyQueryExtensionsByteIdentical()
    {
        var naming = Naming.Resolve(new OperationInfo(HttpMethod.Delete, Item)) with
        {
            HeaderParams = [new("If-Match", "IfMatch")],
        };
        var context = new EmitContext(Client);
        var original = CmdletEmitter.EmitRemove(naming, context);

        Assert.Equal(original, CmdletEmitter.EmitRemove(naming, context, null));
        Assert.Equal(original, CmdletEmitter.EmitRemove(naming, context, []));
        Assert.DoesNotContain("QueryParameters", original);
        Assert.DoesNotContain("MemberReferenceUri", original);
    }

    [Fact]
    public async Task OriginalStrictPolicyStillRejectsReferenceDeletesWithoutTheFlag()
    {
        var group = Group() with
        {
            AllowReferenceDelete = false,
            Routes = [new("DELETE", Collection, "Collection"), new("DELETE", Item, "Item")],
        };

        var error = await Assert.ThrowsAsync<InvalidOperationException>(() => Generate(Document(), group));

        Assert.Contains("Unsupported multi-route operation shape", error.Message);
    }

    [Fact]
    public async Task QueryMappingsCannotBypassTheExplicitReferenceDeleteFlag()
    {
        var error = await Assert.ThrowsAsync<InvalidOperationException>(() =>
            Generate(Document(), Group() with { AllowReferenceDelete = false }));

        Assert.Contains("reference DELETE", error.Message, StringComparison.OrdinalIgnoreCase);
    }

    [Theory]
    [InlineData("missing-mapping")]
    [InlineData("wrong-query-mapping")]
    [InlineData("wrong-public-name")]
    [InlineData("duplicate-mapping")]
    [InlineData("missing-query")]
    [InlineData("wrong-query")]
    [InlineData("optional-query")]
    [InlineData("integer-query")]
    [InlineData("array-query")]
    [InlineData("enum-query")]
    [InlineData("extra-query")]
    [InlineData("item-mapping-without-query")]
    public async Task ReferenceDeletesRejectUnreviewedOrIncompleteQueryBindings(string difference)
    {
        var document = Document();
        var group = Group();
        var operation = document.Paths[Collection].Operations![HttpMethod.Delete];
        var query = (OpenApiParameter)operation.Parameters!.Single(p => p.In == ParameterLocation.Query);
        var route = group.Routes[0];
        switch (difference)
        {
            case "missing-mapping":
                route = route with { QueryBindings = [] };
                break;
            case "wrong-query-mapping":
                route = route with { QueryBindings = [new("id", "MemberReferenceUri")] };
                break;
            case "wrong-public-name":
                route = route with { QueryBindings = [new("@id", "ReferenceUri")] };
                break;
            case "duplicate-mapping":
                route = route with { QueryBindings = [new("@id", "MemberReferenceUri"), new("@id", "OtherUri")] };
                break;
            case "missing-query":
                operation.Parameters!.Remove(query);
                break;
            case "wrong-query":
                query.Name = "id";
                break;
            case "optional-query":
                query.Required = false;
                break;
            case "integer-query":
                query.Schema = new OpenApiSchema { Type = JsonSchemaType.Integer };
                break;
            case "array-query":
                query.Schema = new OpenApiSchema { Type = JsonSchemaType.Array, Items = new OpenApiSchema { Type = JsonSchemaType.String } };
                break;
            case "enum-query":
                query.Schema = new OpenApiSchema
                {
                    Type = JsonSchemaType.String,
                    Enum = [System.Text.Json.Nodes.JsonValue.Create("member")!],
                };
                break;
            case "extra-query":
                operation.Parameters!.Add(new OpenApiParameter
                {
                    Name = "$filter", In = ParameterLocation.Query,
                    Schema = new OpenApiSchema { Type = JsonSchemaType.String },
                });
                break;
            case "item-mapping-without-query":
                group = group with
                {
                    Routes = [route, group.Routes[1] with { QueryBindings = [new("@id", "MemberReferenceUri")] }],
                };
                break;
        }
        group = group with { Routes = [route, group.Routes[1]] };

        var error = await Assert.ThrowsAsync<InvalidOperationException>(() => Generate(document, group));

        Assert.Contains("Reference DELETE", error.Message, StringComparison.OrdinalIgnoreCase);
    }

    private static MultiRouteGroup Group() => new("beta",
    [
        new("DELETE", Collection, "Collection") { QueryBindings = [new("@id", "MemberReferenceUri")] },
        new("DELETE", Item, "Item"),
    ], "Item") { AllowReferenceDelete = true };

    private static OpenApiDocument Document()
    {
        var document = new OpenApiDocument { Paths = new OpenApiPaths() };
        foreach (var path in new[] { Collection, Item })
        {
            document.Paths[path] = new OpenApiPathItem
            {
                Operations = new Dictionary<HttpMethod, OpenApiOperation>
                {
                    [HttpMethod.Delete] = new()
                    {
                        Parameters =
                        [
                            new OpenApiParameter
                            {
                                Name = "If-Match", In = ParameterLocation.Header,
                                Schema = new OpenApiSchema { Type = JsonSchemaType.String },
                            },
                        ],
                        Responses = new OpenApiResponses { ["204"] = new OpenApiResponse() },
                    },
                },
            };
        }
        document.Paths[Collection].Operations![HttpMethod.Delete].Parameters!.Add(new OpenApiParameter
        {
            Name = "@id", In = ParameterLocation.Query, Required = true,
            Schema = new OpenApiSchema { Type = JsonSchemaType.String },
        });
        return document;
    }

    private static async Task<Dictionary<string, string>> Generate(OpenApiDocument document, MultiRouteGroup group)
    {
        var output = Path.Combine(Directory.GetCurrentDirectory(), ".reference-delete-tests-" + Guid.NewGuid().ToString("N"));
        try
        {
            document.RegisterComponents();
            var config = new GeneratorConfig(Client, output, "beta", UseCollisionData: false, MultiRouteGroups: [group]);
            await new PowerShellWrapperGenerationService(document, config, NullLogger.Instance).GenerateAsync(CancellationToken.None);
            return Directory.GetFiles(output, "*.g.cs").ToDictionary(path => Path.GetFileName(path), File.ReadAllText);
        }
        finally
        {
            if (Directory.Exists(output))
                Directory.Delete(output, recursive: true);
        }
    }
}
