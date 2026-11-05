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

public sealed class RequiredQueryTests
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
        Assert.Contains("public string QueryId { get; set; }", source);
        Assert.Contains("[ValidateNotNullOrEmpty]", source);
        Assert.Contains("[Parameter(Mandatory = true, Position = 1,", source);
        Assert.Contains("Value for the '@id' query parameter.", source);
        Assert.Contains("requestConfiguration.QueryParameters.Id = QueryId;", source);
        Assert.DoesNotContain("public string Id ", source);
        Assert.DoesNotContain("QueryParameters.QueryId", source);
        Assert.DoesNotContain("OdataId", source);
        Assert.Contains("client.AdministrativeUnits[AdministrativeUnitId].Members.Ref.DeleteAsync(", source);
        Assert.Contains("requestConfiguration.Headers.Add(\"If-Match\", IfMatch!)", source);
        Assert.Contains("AddRequestHeaders(requestConfiguration.Headers)", source);
        Assert.Contains("ConfirmImpact = ConfirmImpact.High", source);
        Assert.Single(System.Text.RegularExpressions.Regex.Matches(source, @"ShouldProcess\("));
        Assert.Contains($"[GraphRoute(\"DELETE\", \"{Route}\")]", source);
        Assert.Contains($"GetRequestAdapter(\"{profile}\")", source);
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
        item.Parameters = [Query("@id", required: !required, type: required ? JsonSchemaType.String : JsonSchemaType.Integer)];
        operation.Parameters = [Query("@id", required)];
        var source = Assert.Single((await Generate(document)).Values);
        Assert.Equal(required, source.Contains("public string QueryId ", StringComparison.Ordinal));
        Assert.Equal(required, source.Contains("QueryParameters.Id = QueryId", StringComparison.Ordinal));
    }

    [Theory]
    [InlineData("unknown-format")]
    [InlineData("numeric-format")]
    [InlineData("duration")]
    [InlineData("binary")]
    [InlineData("base64url")]
    [InlineData("byte")]
    [InlineData("formatted-array")]
    [InlineData("object")]
    [InlineData("nested-array")]
    [InlineData("enum")]
    [InlineData("union")]
    [InlineData("allOf")]
    [InlineData("content")]
    [InlineData("style")]
    [InlineData("reserved-encoding")]
    [InlineData("name")]
    [InlineData("missing-schema")]
    [InlineData("body")]
    [InlineData("header-collision")]
    [InlineData("member-collision")]
    [InlineData("public-collision")]
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
            case "unknown-format": schema.Format = "unverified"; break;
            case "numeric-format": schema.Type = JsonSchemaType.Integer; schema.Format = "unverified"; break;
            case "duration": schema.Format = "duration"; break;
            case "binary": schema.Format = "binary"; break;
            case "base64url": schema.Format = "base64url"; break;
            case "byte": schema.Type = JsonSchemaType.Integer; schema.Format = "uint8"; break;
            case "formatted-array": schema.Type = JsonSchemaType.Array; schema.Items = new OpenApiSchema { Type = JsonSchemaType.String, Format = "uuid" }; break;
            case "object": schema.Type = JsonSchemaType.Object; break;
            case "nested-array": schema.Type = JsonSchemaType.Array; schema.Items = new OpenApiSchema { Type = JsonSchemaType.Array }; break;
            case "enum": schema.Enum = [System.Text.Json.Nodes.JsonValue.Create("x")!]; break;
            case "union": schema.OneOf = [new OpenApiSchema { Type = JsonSchemaType.String }]; break;
            case "allOf": schema.AllOf = [new OpenApiSchema { Type = JsonSchemaType.String }]; break;
            case "content": query.Content = new Dictionary<string, IOpenApiMediaType> { ["application/json"] = new OpenApiMediaType { Schema = schema } }; break;
            case "style": query.Style = ParameterStyle.DeepObject; break;
            case "reserved-encoding": query.AllowReserved = true; break;
            case "name": query.Name = "a/b"; break;
            case "missing-schema": query.Schema = null; break;
            case "body": operation.RequestBody = new OpenApiRequestBody(); break;
            case "header-collision": operation.Parameters.Add(new OpenApiParameter { Name = "QueryId", In = ParameterLocation.Header }); break;
            case "member-collision": operation.Parameters.Add(Query("id", required: false)); break;
            case "public-collision": query.Name = "tenant-id"; operation.Parameters.Add(Query("tenant_id")); break;
            case "duplicate": operation.Parameters.Add(Query("@id")); break;
            case "inherited-duplicate": item.Parameters = [Query("@id"), Query("@id")]; break;
        }
        var failure = await Assert.ThrowsAsync<InvalidOperationException>(() => Generate(document));
        Assert.Contains(Route, failure.Message);
    }

    [Theory]
    [InlineData("tenantId", "QueryTenantId", "TenantId")]
    [InlineData("$filter", "QueryFilter", "Filter")]
    [InlineData("tenant-id", "QueryTenantId", "TenantId")]
    [InlineData("tenant.name", "QueryTenantName", "TenantName")]
    [InlineData("tenant_name", "QueryTenantName", "TenantName")]
    [InlineData("headers", "QueryHeaders", "Headers")]
    public async Task PublicPrefixAndKiotaMemberNamesAreIndependent(string raw, string publicName, string member)
    {
        var document = await LoadFixture();
        KeepRoute(document, Route);
        document.Paths[Route].Operations![HttpMethod.Delete].Parameters = [Query(raw)];
        var source = Assert.Single((await Generate(document)).Values);
        Assert.Contains($"public string {publicName} ", source);
        Assert.Contains($"QueryParameters.{member} = {publicName};", source);
    }

    [Theory]
    [InlineData("v1.0")]
    [InlineData("beta")]
    public async Task EveryExistingEmitterBindsItsOwnRequiredInputsAndKeepsOptionalOptions(string profile)
    {
        var files = await Generate(await LoadFixture("required-queries.yml"), profile);
        var all = string.Join("\n", files.Values);
        Assert.Contains("QueryParameters.TenantId = QueryTenantId;", all);
        Assert.Contains("QueryParameters.Attempt = QueryAttempt;", all);
        Assert.Contains("public bool QueryForce ", all);
        Assert.Contains("public long QueryAttempt ", all);
        Assert.Contains("QueryParameters.Threshold = QueryThreshold;", all);
        Assert.Contains("QueryParameters.Locale = QueryLocale;", all);
        Assert.Contains("public string Code ", all);
        Assert.Contains("QueryParameters.Revision = QueryRevision;", all);
        Assert.Contains("QueryParameters.Filter = QueryFilter;", all);
        Assert.Contains("QueryParameters.UnderscoreName = QueryUnderscoreName;", all);
        foreach (var source in files.Values.Where(s => s.Contains("new ApiClient(", StringComparison.Ordinal)))
            Assert.Contains($"GetRequestAdapter(\"{profile}\")", source);
        var list = Assert.Single(files, f => f.Key.EndsWith("_List.g.cs", StringComparison.Ordinal)).Value;
        Assert.Contains("public int QueryTop ", list);
        Assert.Contains("public bool QueryCount ", list);
        Assert.DoesNotContain("public int Top ", list);
        Assert.DoesNotContain("public SwitchParameter Count ", list);
        Assert.Contains("public string? Filter ", list);
        Assert.Contains("public string[]? Property ", list);
        Assert.Contains("fetched < QueryTop", list);
        var dispatcher = files["GetMgWidget.g.cs"];
        Assert.Contains("public int QueryTop ", dispatcher);
        Assert.Contains("public string QueryView ", dispatcher);
        Assert.Contains("ParameterSetName = \"List\"", dispatcher);
        Assert.Contains("ParameterSetName = \"Get\"", dispatcher);
        var patch = files["UpdateMgWidget.g.cs"];
        var refetch = patch[patch.IndexOf("if (result is null)", StringComparison.Ordinal)..];
        Assert.Contains("QueryParameters.TenantId = QueryTenantId;", patch);
        Assert.DoesNotContain("QueryTenantId", refetch);
        Assert.Contains("QueryParameters.View = QueryView;", refetch);
        Assert.DoesNotContain("IfMatch", refetch);
        var delta = Assert.Single(files, f => f.Key.Contains("Delta", StringComparison.Ordinal)).Value;
        Assert.Contains("Position = 0, ParameterSetName = \"DeltaSync\"", delta);
        Assert.Contains("QueryParameters.TenantId = QueryTenantId;", delta);
        var continuation = delta[delta.IndexOf("result = client.", delta.IndexOf("while (true)", StringComparison.Ordinal), StringComparison.Ordinal)..];
        Assert.DoesNotContain("QueryTenantId", continuation);
        var select = files["GetMgSelectedWidget.g.cs"];
        Assert.Contains("public string[] QuerySelect ", select);
        Assert.Contains("QueryParameters.Select = QuerySelect;", select);
        Assert.DoesNotContain("public string[]? Property ", select);
    }

    [Theory]
    [InlineData("GET", "/widgets")]
    [InlineData("POST", "/widgets")]
    [InlineData("PATCH", "/widgets/{widget-id}")]
    [InlineData("PUT", "/widgets/{widget-id}")]
    [InlineData("POST", "/widgets/{widget-id}/promote")]
    [InlineData("GET", "/widgets/{widget-id}/lookup(code='{code}')")]
    [InlineData("POST", "/widgets/{widget-id}/members/$ref")]
    [InlineData("PUT", "/widgets/{widget-id}/members/$ref")]
    [InlineData("GET", "/widgets/{widget-id}/owner/$ref")]
    [InlineData("GET", "/widgets/$count")]
    [InlineData("GET", "/widgets/{widget-id}/content")]
    [InlineData("PUT", "/widgets/{widget-id}/content")]
    [InlineData("GET", "/widgets/delta()")]
    public async Task RequiredMetadataInheritanceAndOperationOverridesApplyBeforeSpecializedBranches(string method, string route)
    {
        var document = await LoadFixture("required-queries.yml");
        KeepRoute(document, route);
        var item = (OpenApiPathItem)document.Paths[route];
        var operation = item.Operations![new HttpMethod(method)];
        item.Operations = new Dictionary<HttpMethod, OpenApiOperation> { [new HttpMethod(method)] = operation };
        item.Parameters = [Query("scope"), Query("overridden", required: false, type: JsonSchemaType.Integer)];
        operation.Parameters = (operation.Parameters ?? []).Concat([Query("overridden", type: JsonSchemaType.Integer)]).ToList();
        var source = Assert.Single((await Generate(document)).Values);
        Assert.Contains("public string QueryScope ", source);
        Assert.Contains("public int QueryOverridden ", source);
        Assert.Contains("QueryParameters.Scope = QueryScope;", source);
        Assert.Contains("QueryParameters.Overridden = QueryOverridden;", source);
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public async Task RefetchRequiredQueriesHaveAnIndependentContract(bool conflicting)
    {
        const string route = "/widgets/{widget-id}";
        var document = await LoadFixture("required-queries.yml");
        KeepRoute(document, route);
        var item = (OpenApiPathItem)document.Paths[route];
        item.Operations!.Remove(HttpMethod.Put);
        item.Operations[HttpMethod.Get].Parameters = [Query("tenantId", type: conflicting ? JsonSchemaType.Integer : JsonSchemaType.String)];
        if (conflicting)
        {
            var failure = await Assert.ThrowsAsync<InvalidOperationException>(() => Generate(document));
            Assert.Contains("mutation/refetch required query", failure.Message);
        }
        else
        {
            var patch = (await Generate(document))["UpdateMgWidget.g.cs"];
            Assert.Single(System.Text.RegularExpressions.Regex.Matches(patch, "public string QueryTenantId "));
            Assert.Equal(2, System.Text.RegularExpressions.Regex.Matches(patch, "QueryParameters.TenantId = QueryTenantId;").Count);
        }
    }

    [Fact]
    public async Task ReferencedParameterMetadataIsNotDropped()
    {
        const string yaml = """
            openapi: 3.0.4
            info: { title: parameter reference, version: 1.0.0 }
            paths:
              /widgets/{widget-id}:
                parameters:
                  - $ref: '#/components/parameters/tenant'
                delete:
                  responses:
                    '204': { description: Success }
            components:
              parameters:
                tenant:
                  name: tenantId
                  in: query
                  required: true
                  schema: { type: string }
            """;
        var settings = new OpenApiReaderSettings();
        settings.AddYamlReader();
        await using var stream = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(yaml));
        var document = (await OpenApiDocument.LoadAsync(stream, settings: settings, cancellationToken: TestContext.Current.CancellationToken)).Document!;
        var source = Assert.Single((await Generate(document)).Values);
        Assert.Contains("QueryParameters.TenantId = QueryTenantId;", source);
    }

    [Fact]
    public async Task DeltaResumeRequiredInputsAreRejectedInsteadOfDropped()
    {
        var document = await LoadFixture("required-queries.yml");
        const string sync = "/widgets/delta()";
        KeepRoute(document, sync);
        document.Paths["/widgets/delta(token='{token}')"] = new OpenApiPathItem
        {
            Operations = new Dictionary<HttpMethod, OpenApiOperation>
            {
                [HttpMethod.Get] = new()
                {
                    Extensions = document.Paths[sync].Operations![HttpMethod.Get].Extensions,
                    Parameters = [Query("resumeTenant")],
                    Responses = document.Paths[sync].Operations![HttpMethod.Get].Responses,
                },
            },
        };
        var failure = await Assert.ThrowsAsync<InvalidOperationException>(() => Generate(document));
        Assert.Contains("Required query inputs on a delta resume operation are unsupported", failure.Message);
        Assert.Contains("delta(token=", failure.Message);
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public async Task RequiredGetQueriesCannotDiscriminateNaturalPathIdGroups(bool inherited)
    {
        var document = await LoadFixture("required-queries.yml");
        var response = document.Paths["/widgets/{widget-id}"].Operations![HttpMethod.Get].Responses;
        document.Paths.Clear();
        const string root = "/profiles/{profile-id}/widgets/{widget-id}";
        const string parent = "/profiles/{profile-id}/widgets/{parent-id}/widgets/{widget-id}";
        foreach (var route in new[] { root, parent })
            document.Paths[route] = new OpenApiPathItem
            {
                Parameters = inherited ? [Query("tenantId")] : [],
                Operations = new Dictionary<HttpMethod, OpenApiOperation>
                {
                    [HttpMethod.Get] = new() { Parameters = inherited ? [] : [Query("tenantId")], Responses = response },
                },
            };
        var group = new CmdletConfigurator.OperationVariantGroup([
            new("GET", root, "Root"), new("GET", parent, "Parent")], "Root");
        var failure = await Assert.ThrowsAsync<InvalidOperationException>(() => Generate(document,
            entries: [CmdletConfigurator.GroupVariants(group, "Required queries are not path IDs.")]));
        Assert.Contains("GET group", failure.Message);
        Assert.Contains(root, failure.Message);
    }

    [Theory]
    [InlineData("/widgets")]
    [InlineData("/widgets/delta()")]
    public async Task PaginationRejectsANonIntegerRequiredTop(string route)
    {
        var document = await LoadFixture("required-queries.yml");
        KeepRoute(document, route);
        var item = (OpenApiPathItem)document.Paths[route];
        var operation = item.Operations![HttpMethod.Get];
        item.Operations = new Dictionary<HttpMethod, OpenApiOperation> { [HttpMethod.Get] = operation };
        item.Parameters = (item.Parameters ?? []).Where(p => p.Name != "$top").ToList();
        operation.Parameters = [Query("$top", type: JsonSchemaType.Boolean)];
        var failure = await Assert.ThrowsAsync<InvalidOperationException>(() => Generate(document));
        Assert.Contains("Required query '$top' must be an integer", failure.Message);
        Assert.Contains(route, failure.Message);
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public async Task IncompatibleRequiredOverridesFailBeforeEmittingAgainstKiotasInheritedMember(bool serialization)
    {
        var document = await LoadFixture();
        KeepRoute(document, Route);
        var item = (OpenApiPathItem)document.Paths[Route];
        var inherited = Query("@id", required: false);
        var operation = Query("@id", type: serialization ? JsonSchemaType.String : JsonSchemaType.Integer);
        if (serialization) { operation.Explode = true; }
        item.Parameters = [inherited];
        item.Operations![HttpMethod.Delete].Parameters = [operation];
        var failure = await Assert.ThrowsAsync<InvalidOperationException>(() => Generate(document));
        Assert.Contains("Unsupported required query override '@id'", failure.Message);
        Assert.Contains(Route, failure.Message);
    }

    [Theory]
    [InlineData("path")]
    [InlineData("body")]
    [InlineData("inline")]
    public async Task PrefixedPublicNamesCannotHideOtherParameterCollisions(string kind)
    {
        var document = await LoadFixture("required-queries.yml");
        var route = kind == "inline" ? "/widgets/{widget-id}/lookup(code='{code}')" : kind == "body" ? "/widgets" : Route;
        if (kind == "path")
        {
            document = await LoadFixture();
            var item = document.Paths[Route];
            document.Paths.Remove(Route);
            route = Route.Replace("{administrativeUnit-id}", "{query-id}", StringComparison.Ordinal);
            document.Paths[route] = item;
        }
        KeepRoute(document, route);
        if (kind == "body")
            ((OpenApiSchema)document.Components!.Schemas!["microsoft.graph.widget"]).Properties!["queryTenantId"] = new OpenApiSchema { Type = JsonSchemaType.String };
        if (kind == "inline")
        {
            var item = document.Paths[route];
            document.Paths.Remove(route);
            route = route.Replace("{code}", "{query-locale}", StringComparison.Ordinal);
            document.Paths[route] = item;
        }
        var failure = await Assert.ThrowsAsync<InvalidOperationException>(() => Generate(document));
        Assert.Contains("Required query public parameter", failure.Message);
        Assert.Contains(route, failure.Message);
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
        Assert.Equal(CmdletEmitter.EmitRemove(naming, new EmitContext(Client, ApiVersion: "beta")),
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

    private static async Task<OpenApiDocument> LoadFixture(string name = "required-delete-query.yml")
    {
        var settings = new OpenApiReaderSettings();
        settings.AddYamlReader();
        await using var stream = File.OpenRead(Path.Combine(AppContext.BaseDirectory, "Fixtures", name));
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
