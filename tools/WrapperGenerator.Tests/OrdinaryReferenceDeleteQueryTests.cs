using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.OpenApi;
using Xunit;

namespace WrapperGenerator.Tests;

public sealed class OrdinaryReferenceDeleteQueryTests
{
    private const string Root = "/referenceOwners/{owner-id}/sponsors/$ref";
    private const string Client = "Microsoft.Graph.PowerShell.OrdinaryReferenceDelete.Client";

    [Theory]
    [InlineData("v1.0")]
    [InlineData("beta")]
    public async Task ExplicitBindingEmitsOneOrdinaryCommandWithRequiredIdAndTypedQuery(string profile)
    {
        var files = await Generate(Document(), profile, [Binding(profile)]);
        var source = Assert.Single(files).Value.ReplaceLineEndings("\n");

        Assert.Contains("[Parameter(Mandatory = true)]\n        public string Id { get; set; } = string.Empty;", source);
        Assert.Contains("client.ReferenceOwners[OwnerId].Sponsors.Ref.DeleteAsync(", source);
        Assert.Contains("if (this.IsParameterBound(nameof(Id)))", source);
        Assert.Contains("requestConfiguration.QueryParameters.Id = Id;", source);
        Assert.Contains("public string? IfMatch", source);
        Assert.Contains("requestConfiguration.Headers.Add(\"If-Match\", IfMatch!);", source);
        Assert.Contains("AddRequestHeaders(requestConfiguration.Headers);", source);
        Assert.Contains("SupportsShouldProcess = true", source);
        Assert.Contains("if (!ShouldProcess(", source);
        Assert.Contains($"[GraphRoute(\"DELETE\", \"{Root}\"", source);
        Assert.DoesNotContain("_Route", source);
        Assert.DoesNotContain("MemberReferenceUri", source);
        Assert.DoesNotContain("DirectoryObjectId", source);
        Assert.DoesNotContain("public string Route", source);
        Assert.DoesNotContain("InvokeCommand.InvokeScript", source);
        var naming = Naming.Resolve(new OperationInfo(HttpMethod.Delete, Root));
        Assert.Equal(naming.VerbName + naming.Noun + ".g.cs", Assert.Single(files).Key);
    }

    [Fact]
    public async Task UnconfiguredOrdinaryRemoveRemainsByteIdentical()
    {
        var files = await Generate(Document(), "beta", []);
        var naming = Naming.Resolve(new OperationInfo(HttpMethod.Delete, Root, HeaderParams: ["If-Match"]));

        Assert.Equal(CmdletEmitter.EmitRemove(naming, new EmitContext(Client)), Assert.Single(files).Value);
        Assert.DoesNotContain("QueryParameters", Assert.Single(files).Value);
    }

    [Fact]
    public async Task BindingsAreProfileIsolatedAndDoNotRequireAbsentModulePaths()
    {
        var inactive = await Generate(Document(), "v1.0", [Binding("beta")]);
        Assert.DoesNotContain("QueryParameters", Assert.Single(inactive).Value);
        var active = await Generate(Document(), "v1.0", [Binding("v1.0"), Binding("beta")]);
        Assert.Contains("QueryParameters.Id = Id;", Assert.Single(active).Value);

        var absent = await Generate(new OpenApiDocument { Paths = new OpenApiPaths() }, "beta",
            [Binding("beta")], [Group("/unrelated/{owner-id}/members/$ref")]);
        Assert.Empty(absent);
    }

    [Fact]
    public async Task BindingDoesNotRequireAnyMultiRouteFeatureFlags()
    {
        var files = await Generate(Document(), "beta", [Binding("beta")],
            [Group("/unrelated/{owner-id}/members/$ref")]);
        Assert.Contains("QueryParameters.Id = Id;", Assert.Single(files).Value);
    }

    [Fact]
    public async Task ExactPathMatchingIsCaseInsensitiveWithoutChangingTheSourceRoute()
    {
        var source = Assert.Single(await Generate(Document(), "beta",
            [Binding("beta") with { Path = Root.ToUpperInvariant() }])).Value;
        Assert.Contains($"[GraphRoute(\"DELETE\", \"{Root}\")]", source);
        Assert.DoesNotContain("ParameterSetName", source);
    }

    [Fact]
    public async Task AnExplicitBindingCannotSilentlyUnsuppressOrDropAnOrdinaryDelete()
    {
        const string path = "/applications/{application-id}/owners/$ref";
        var config = new GeneratorConfig(Client, "", "v1.0", UseCollisionData: true);
        Assert.True(CmdletConfigurator.IsSuppressed(HttpMethod.Delete, path, config));

        var error = await Assert.ThrowsAsync<InvalidOperationException>(() =>
            Generate(Document(path), "v1.0", [new("v1.0", path, "Id")], useCollisionData: true));
        Assert.Contains("suppressed", error.Message, StringComparison.OrdinalIgnoreCase);
    }

    [Theory]
    [InlineData("MemberReferenceUri")]
    [InlineData("id")]
    [InlineData("ReferenceUri")]
    [InlineData("AccessToken")]
    public async Task OnlyTheExactReviewedPublicIdMappingIsAccepted(string publicName)
    {
        var error = await Assert.ThrowsAsync<InvalidOperationException>(() =>
            Generate(Document(), "beta", [Binding("beta") with { ParameterName = publicName }]));
        Assert.Contains("reference DELETE", error.Message, StringComparison.OrdinalIgnoreCase);
    }

    [Theory]
    [InlineData("referenceOwners/{owner-id}/sponsors/$ref")]
    [InlineData("/referenceOwners/*/sponsors/$ref")]
    [InlineData("/referenceOwners/{owner-id}/sponsors")]
    [InlineData("/referenceOwners/{owner-id}/sponsors/$ref/")]
    [InlineData("/referenceOwners/{owner-id}/sponsors/$ref?x/$ref")]
    [InlineData("/users/{}/sponsors/$ref")]
    public async Task ConfigurationRequiresAnExactTerminalReferencePath(string path)
    {
        await Assert.ThrowsAsync<InvalidOperationException>(() =>
            Generate(Document(), "beta", [Binding("beta") with { Path = path }]));
    }

    [Fact]
    public async Task DuplicateBindingsFailEvenWhenTheirModuleIsAbsent()
    {
        var error = await Assert.ThrowsAsync<InvalidOperationException>(() =>
            Generate(new OpenApiDocument { Paths = new OpenApiPaths() }, "beta",
                [Binding("beta"), Binding("BETA") with { Path = Root.ToUpperInvariant() }]));
        Assert.Contains("Duplicate", error.Message);
    }

    [Fact]
    public async Task OrdinaryBindingsCannotOverlapAnyDeleteMultiRouteMember()
    {
        var error = await Assert.ThrowsAsync<InvalidOperationException>(() =>
            Generate(Document(), "beta", [Binding("beta")], [Group(Root)]));
        Assert.Contains("overlaps", error.Message);
    }

    [Theory]
    [InlineData("missing-query")]
    [InlineData("wrong-query")]
    [InlineData("optional-query")]
    [InlineData("integer-query")]
    [InlineData("array-query")]
    [InlineData("enum-query")]
    [InlineData("composed-query")]
    [InlineData("duplicate-query")]
    [InlineData("extra-query")]
    [InlineData("empty-body")]
    [InlineData("json-body")]
    [InlineData("json-response")]
    [InlineData("binary-response")]
    [InlineData("inherited-query")]
    [InlineData("inherited-header")]
    [InlineData("cookie")]
    public async Task OnlyTheReviewedOperationContractIsAccepted(string difference)
    {
        var document = Document();
        var item = (OpenApiPathItem)document.Paths[Root];
        var operation = item.Operations![HttpMethod.Delete];
        var query = (OpenApiParameter)operation.Parameters!.Single(parameter => parameter.In == ParameterLocation.Query);
        switch (difference)
        {
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
                query.Schema = new OpenApiSchema { Type = JsonSchemaType.String, Enum = [System.Text.Json.Nodes.JsonValue.Create("member")!] };
                break;
            case "composed-query":
                query.Schema = new OpenApiSchema { Type = JsonSchemaType.String, AllOf = [new OpenApiSchema { Type = JsonSchemaType.String }] };
                break;
            case "duplicate-query":
                operation.Parameters!.Add(Query("@id"));
                break;
            case "extra-query":
                operation.Parameters!.Add(Query("$filter"));
                break;
            case "empty-body":
                operation.RequestBody = new OpenApiRequestBody();
                break;
            case "json-body":
                operation.RequestBody = new OpenApiRequestBody
                {
                    Content = new Dictionary<string, IOpenApiMediaType>
                    {
                        ["application/json"] = new OpenApiMediaType { Schema = new OpenApiSchema { Type = JsonSchemaType.Object } },
                    },
                };
                break;
            case "json-response":
            case "binary-response":
                operation.Responses!["202"] = new OpenApiResponse
                {
                    Content = new Dictionary<string, IOpenApiMediaType>
                    {
                        [difference == "json-response" ? "application/json" : "application/octet-stream"] =
                            new OpenApiMediaType { Schema = new OpenApiSchema { Type = JsonSchemaType.String } },
                    },
                };
                break;
            case "inherited-query":
            case "inherited-header":
                item.Parameters = [new OpenApiParameter
                {
                    Name = "unreviewed",
                    In = difference == "inherited-query" ? ParameterLocation.Query : ParameterLocation.Header,
                    Schema = new OpenApiSchema { Type = JsonSchemaType.String },
                }];
                break;
            case "cookie":
                operation.Parameters!.Add(new OpenApiParameter { Name = "cookie", In = ParameterLocation.Cookie });
                break;
        }

        var error = await Assert.ThrowsAsync<InvalidOperationException>(() =>
            Generate(document, "beta", [Binding("beta")]));
        Assert.Contains("reference DELETE", error.Message, StringComparison.OrdinalIgnoreCase);
    }

    [Fact]
    public async Task InheritedPathIdsAndAllOperationHeadersRemainAvailable()
    {
        var document = Document();
        ((OpenApiPathItem)document.Paths[Root]).Parameters =
            [new OpenApiParameter { Name = "owner-id", In = ParameterLocation.Path, Required = true, Schema = new OpenApiSchema { Type = JsonSchemaType.String } }];
        document.Paths[Root].Operations![HttpMethod.Delete].Parameters!.Add(new OpenApiParameter
        {
            Name = "x-reviewed-header", In = ParameterLocation.Header, Schema = new OpenApiSchema { Type = JsonSchemaType.String },
        });

        var source = Assert.Single(await Generate(document, "beta", [Binding("beta")])).Value;
        Assert.Contains("public string OwnerId", source);
        Assert.Contains("public string? IfMatch", source);
        Assert.Contains("public string? XReviewedHeader", source);
        Assert.Contains("requestConfiguration.Headers.Add(\"x-reviewed-header\", XReviewedHeader!);", source);
    }

    [Theory]
    [InlineData("path-id")]
    [InlineData("header-id")]
    [InlineData("path-runtime")]
    [InlineData("header-runtime")]
    [InlineData("header-common-alias")]
    public async Task ParameterNameAndRuntimeAliasConflictsFailInsteadOfRenamingOrDroppingId(string conflict)
    {
        var path = conflict switch
        {
            "path-id" => Root.Replace("{owner-id}", "{id}"),
            "path-runtime" => Root.Replace("{owner-id}", "{accessToken}"),
            _ => Root,
        };
        var document = Document(path);
        if (conflict.StartsWith("header-", StringComparison.Ordinal))
            document.Paths[path].Operations![HttpMethod.Delete].Parameters!.Add(new OpenApiParameter
            {
                Name = conflict switch { "header-id" => "id", "header-runtime" => "Headers", _ => "ea" },
                In = ParameterLocation.Header, Schema = new OpenApiSchema { Type = JsonSchemaType.String },
            });

        var error = await Assert.ThrowsAsync<InvalidOperationException>(() =>
            Generate(document, "beta", [Binding("beta") with { Path = path }]));
        Assert.Contains("conflict", error.Message, StringComparison.OrdinalIgnoreCase);
    }

    private static ReferenceDeleteQueryBinding Binding(string profile) => new(profile, Root, "Id");

    private static MultiRouteGroup Group(string path) => new("beta",
        [new("DELETE", path, "Collection"), new("DELETE", path.Replace("/$ref", "/{member-id}/$ref"), "Item")], "Item");

    private static OpenApiParameter Query(string name) => new()
    {
        Name = name, In = ParameterLocation.Query, Required = true, Schema = new OpenApiSchema { Type = JsonSchemaType.String },
    };

    private static OpenApiDocument Document(string path = Root) => new()
    {
        Paths = new OpenApiPaths
        {
            [path] = new OpenApiPathItem
            {
                Operations = new Dictionary<HttpMethod, OpenApiOperation>
                {
                    [HttpMethod.Delete] = new()
                    {
                        Parameters =
                        [
                            Query("@id"),
                            new OpenApiParameter { Name = "If-Match", In = ParameterLocation.Header, Schema = new OpenApiSchema { Type = JsonSchemaType.String } },
                        ],
                        Responses = new OpenApiResponses { ["204"] = new OpenApiResponse() },
                    },
                },
            },
        },
    };

    private static async Task<Dictionary<string, string>> Generate(OpenApiDocument document, string profile,
        IReadOnlyList<ReferenceDeleteQueryBinding> bindings, IReadOnlyList<MultiRouteGroup>? groups = null,
        bool useCollisionData = false)
    {
        var output = Path.Combine(Directory.GetCurrentDirectory(), ".ordinary-reference-delete-tests-" + Guid.NewGuid().ToString("N"));
        try
        {
            document.RegisterComponents();
            var config = new GeneratorConfig(Client, output, profile, UseCollisionData: useCollisionData, MultiRouteGroups: groups)
            {
                ReferenceDeleteQueryBindings = bindings,
            };
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
