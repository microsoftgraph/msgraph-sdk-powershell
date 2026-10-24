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

public sealed class MixedReadRouteTests
{
    private const string Client = "Microsoft.Graph.PowerShell.MixedRead.Client";
    private const string Aggregate = "/widgets/{widget-id}/parentCalculate()";
    private const string List = "/widgets/{widget-id}/parents/{parent-id}/calculate";
    private const string Item = List + "/{calculation-id}";
    private const string TeamsAggregate = "/users/{user-id}/chats/getAllMessages()";
    private const string TeamsList = "/users/{user-id}/chats/{chat-id}/messages";
    private const string TeamsItem = TeamsList + "/{chatMessage-id}";
    private const string Scratch = @"C:\Users\ramsess\.copilot\session-state\61a84a3f-fd2a-43d5-a841-0d07b0196e7e\files\mixed-read-fixture";
    private static readonly string[] ListQueries =
        ["$top", "$skip", "$search", "$filter", "$count", "$orderby", "$select", "$expand"];

    [Fact]
    public void MixedReadsAreAnInitOnlyOptInWithoutChangingPositionalRecords()
    {
        var route = new MultiRoute("GET", Aggregate, "Aggregate");
        var group = new MultiRouteGroup("beta", [route], "Aggregate", "Route");
        var (method, path, name) = route;
        var (version, routes, defaultRoute, selector) = group;

        Assert.False(group.AllowMixedReadOperations);
        Assert.Equal(("GET", Aggregate, "Aggregate"), (method, path, name));
        Assert.Equal(("beta", "Aggregate", "Route"), (version, defaultRoute, selector));
        Assert.Same(group.Routes, routes);
        Assert.Equal(3, Assert.Single(typeof(MultiRoute).GetConstructors()).GetParameters().Length);
        Assert.Equal(4, Assert.Single(typeof(MultiRouteGroup).GetConstructors()).GetParameters().Length);
        Assert.NotNull(typeof(MultiRouteGroup).GetProperty(nameof(MultiRouteGroup.AllowMixedReadOperations))!.SetMethod);
    }

    [Fact]
    public async Task SyntheticMixedReadsUseNaturalSharedNamesAndTypedPagedFunctionWorkers()
    {
        var naming = Naming.Resolve(new OperationInfo(HttpMethod.Get, Aggregate, Kind: OperationKind.Function));
        Assert.Equal("MgWidgetParentCalculate", naming.Noun);
        Assert.Equal(naming.Noun, Naming.Resolve(new OperationInfo(HttpMethod.Get, List)).Noun);
        Assert.Equal(naming.Noun, Naming.Resolve(new OperationInfo(HttpMethod.Get, Item)).Noun);
        var files = await Generate(Document(), Group());

        Assert.Equal(4, files.Count);
        var dispatcher = files["GetMgWidgetParentCalculate.g.cs"];
        Assert.Contains("DefaultParameterSetName = \"Route\"", dispatcher);
        Assert.Contains("[ValidateSet(\"Published\", \"Aggregate\", \"Chat\")]", dispatcher);
        AssertParameter(dispatcher, "WidgetId", true);
        AssertParameter(dispatcher, "ParentId", false);
        AssertParameter(dispatcher, "CalculationId", false);
        AssertParameter(dispatcher, "Model", false);
        Assert.Contains($"[OutputType(typeof({Client}.Models.Widget), ParameterSetName = new[] {{ \"Route\" }})]", dispatcher);
        Assert.DoesNotContain("ParameterSetName = \"Get\"", dispatcher);
        Assert.DoesNotContain("ParameterSetName = \"List\"", dispatcher);
        foreach (var route in Group().Routes)
            Assert.Contains($"[GraphRoute(\"GET\", \"{route.Path}\", ParameterSetName = \"Route\")]", dispatcher);
        var aggregateCandidate = Candidate(dispatcher, "Aggregate", "List");
        Assert.Contains("\"Model\"", aggregateCandidate);
        Assert.DoesNotContain("\"ParentId\"", aggregateCandidate);
        Assert.EndsWith("new string[] { \"WidgetId\" }),", aggregateCandidate);
        Assert.EndsWith("new string[] { \"WidgetId\", \"ParentId\" }),", Candidate(dispatcher, "Chat", "List"));
        Assert.EndsWith("new string[] { \"WidgetId\", \"ParentId\", \"CalculationId\" }),", Candidate(dispatcher, "Chat", "Get"));
        Assert.DoesNotContain("\"Model\"", Candidate(dispatcher, "Chat", "List"));
        Assert.DoesNotContain("\"All\"", Candidate(dispatcher, "Chat", "Get"));
        Assert.Contains("InvalidGraphRouteParameters", dispatcher);
        Assert.Contains("candidate.Required", dispatcher);
        Assert.Contains("candidate.Allowed", dispatcher);
        Assert.Contains("parameters.Remove(\"Route\")", dispatcher);
        Assert.Contains("defaultRoutes.Count > 0", dispatcher);
        Assert.DoesNotContain("? !string.Equals(candidate.Label, \"Aggregate\"", dispatcher);
        Assert.DoesNotContain("parameters.Remove(\"ParentId\")", dispatcher);
        Assert.DoesNotContain("parameters.Remove(\"Model\")", dispatcher);
        Assert.DoesNotContain("dynamic", dispatcher);
        Assert.DoesNotContain("System.Reflection", dispatcher);

        var function = files["GetMgWidgetParentCalculate_Route0.g.cs"];
        Assert.Contains($"[OutputType(typeof({Client}.Models.Widget))]", function);
        Assert.Contains(Client + ".Widgets.Item.ParentCalculate.ParentCalculateGetResponse? result", function);
        Assert.Contains("client.Widgets[WidgetId].ParentCalculate.GetAsParentCalculateGetResponseAsync(", function);
        Assert.Contains(".WithUrl(nextLink).GetAsParentCalculateGetResponseAsync(", function);
        Assert.Contains("public SwitchParameter All", function);
        Assert.Contains("public string? Model", function);
        Assert.Equal(1, function.Split("requestConfiguration.QueryParameters.Model = Model").Length - 1);
        Assert.Contains("requestConfiguration.QueryParameters.Top = Top", function);
        Assert.Contains("requestConfiguration.QueryParameters.Select = Property", function);
        Assert.Contains("fetched < Top", function);
        Assert.Contains("}, StoppingToken)", function);
        Assert.Equal(2, function.Split("AddRequestHeaders(requestConfiguration.Headers)").Length - 1);
        Assert.Contains("WriteObject(items, enumerateCollection: true)", function);
        Assert.Contains("Use -All to return all pages", function);
        Assert.DoesNotContain("public string ParentId", function);
        Assert.DoesNotContain("dynamic", function);
        var list = files["GetMgWidgetParentCalculate_Route1.g.cs"];
        var item = files["GetMgWidgetParentCalculate_Route2.g.cs"];
        Assert.Contains("client.Widgets[WidgetId].Parents[ParentId].Calculate.GetAsync(", list);
        Assert.Contains("Models.WidgetCollectionResponse? result", list);
        Assert.Contains("client.Widgets[WidgetId].Parents[ParentId].Calculate[CalculationId].GetAsync(", item);
        Assert.DoesNotContain("public SwitchParameter All", item);
        Assert.DoesNotContain("public string? Model", list);
    }

    [Theory]
    [InlineData("mixed")]
    [InlineData("zero-argument")]
    [InlineData("asymmetric")]
    [InlineData("explicit")]
    [InlineData("inference")]
    [InlineData("selector")]
    public async Task EveryMixedReadAuthorizationIsRequired(string missing)
    {
        var group = Group();
        group = missing switch
        {
            "mixed" => group with { AllowMixedReadOperations = false },
            "zero-argument" => group with { AllowZeroArgumentFunctions = false },
            "asymmetric" => group with { AllowAsymmetricRoutes = false },
            "explicit" => group with { AllowExplicitRouteSelection = false },
            "inference" => group with { AllowPublishedParameterInference = false },
            _ => group with { SelectorParameter = null },
        };
        await Assert.ThrowsAsync<InvalidOperationException>(() => Generate(Document(), group));
    }

    [Theory]
    [InlineData("different-list-model")]
    [InlineData("different-item-model")]
    [InlineData("wrong-model-type")]
    [InlineData("required-model")]
    [InlineData("unsupported-query")]
    [InlineData("wrong-odata-type")]
    [InlineData("required-odata")]
    [InlineData("request-body")]
    [InlineData("non-json-request-body")]
    [InlineData("function-header")]
    [InlineData("path-item-header")]
    [InlineData("path-item-query")]
    [InlineData("unpaged-function")]
    [InlineData("scalar-function")]
    public async Task MixedPolicyRejectsUnsupportedContractsRatherThanRelaxingUnrelatedGuards(string difference)
    {
        var document = Document();
        var function = document.Paths[Aggregate].Operations![HttpMethod.Get];
        switch (difference)
        {
            case "different-list-model":
                document.Paths[List].Operations![HttpMethod.Get].Responses = Response(Collection(document, "microsoft.graph.other"));
                break;
            case "different-item-model":
                document.Paths[Item].Operations![HttpMethod.Get].Responses = Response(new OpenApiSchemaReference("microsoft.graph.other", document));
                break;
            case "wrong-model-type":
                ((OpenApiParameter)function.Parameters!.Single(p => p.Name == "model")).Schema = new OpenApiSchema { Type = JsonSchemaType.Integer };
                break;
            case "required-model":
                ((OpenApiParameter)function.Parameters!.Single(p => p.Name == "model")).Required = true;
                break;
            case "unsupported-query":
                function.Parameters!.Add(Query("unsupported"));
                break;
            case "wrong-odata-type":
                ((OpenApiParameter)function.Parameters!.Single(p => p.Name == "$top")).Schema = new OpenApiSchema { Type = JsonSchemaType.String };
                break;
            case "required-odata":
                ((OpenApiParameter)function.Parameters!.Single(p => p.Name == "$filter")).Required = true;
                break;
            case "request-body":
            case "non-json-request-body":
                function.RequestBody = new OpenApiRequestBody
                {
                    Content = new Dictionary<string, IOpenApiMediaType>
                    {
                        [difference == "request-body" ? "application/json" : "text/plain"] =
                            new OpenApiMediaType { Schema = new OpenApiSchema { Type = JsonSchemaType.String } },
                    },
                };
                break;
            case "function-header":
                function.Parameters!.Add(new OpenApiParameter { Name = "X-Unsupported", In = ParameterLocation.Header, Schema = new OpenApiSchema { Type = JsonSchemaType.String } });
                break;
            case "path-item-header":
            case "path-item-query":
                ((OpenApiPathItem)document.Paths[Aggregate]).Parameters =
                    [new OpenApiParameter { Name = "unexpected", In = difference == "path-item-header" ? ParameterLocation.Header : ParameterLocation.Query, Schema = new OpenApiSchema { Type = JsonSchemaType.String } }];
                break;
            case "unpaged-function":
                function.Responses = Response(new OpenApiSchemaReference("microsoft.graph.widget", document));
                break;
            case "scalar-function":
                function.Responses = Response(new OpenApiSchema { Type = JsonSchemaType.Integer });
                break;
        }
        await Assert.ThrowsAsync<InvalidOperationException>(() => Generate(document, Group()));
    }

    [Theory]
    [InlineData("missing")]
    [InlineData("integer")]
    [InlineData("object")]
    [InlineData("null")]
    [InlineData("type-union")]
    [InlineData("anyOf")]
    [InlineData("oneOf")]
    [InlineData("reference")]
    public async Task PagedFunctionRequiresAPlainStringNextLinkEvenWhenValueIsAValidEntityCollection(string shape)
    {
        var document = Document();
        var response = Collection(document);
        Assert.Equal("microsoft.graph.widget", response.Properties!["value"].Items!.GetReferenceId());
        if (shape != "missing")
        {
            IOpenApiSchema nextLink = shape switch
            {
                "integer" => new OpenApiSchema { Type = JsonSchemaType.Integer },
                "object" => new OpenApiSchema { Type = JsonSchemaType.Object },
                "null" => new OpenApiSchema { Type = JsonSchemaType.Null },
                "type-union" => new OpenApiSchema { Type = JsonSchemaType.String | JsonSchemaType.Integer },
                "anyOf" => new OpenApiSchema
                {
                    Type = JsonSchemaType.String,
                    AnyOf = [new OpenApiSchema { Type = JsonSchemaType.String }, new OpenApiSchema { Type = JsonSchemaType.Null }],
                },
                "oneOf" => new OpenApiSchema
                {
                    Type = JsonSchemaType.String,
                    OneOf = [new OpenApiSchema { Type = JsonSchemaType.String }, new OpenApiSchema { Type = JsonSchemaType.Null }],
                },
                _ => new OpenApiSchemaReference("nextLinkString", document),
            };
            document.Components!.Schemas!["nextLinkString"] = new OpenApiSchema { Type = JsonSchemaType.String };
            response.Properties["@odata.nextLink"] = nextLink;
        }
        document.Paths[Aggregate].Operations![HttpMethod.Get].Responses = Response(response);

        var error = await Assert.ThrowsAsync<InvalidOperationException>(() => Generate(document, Group()));

        Assert.Contains("Mixed read function response requires a plain string '@odata.nextLink' pagination member", error.Message);
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public async Task PagedFunctionAcceptsPlainAndNullableStringNextLinksInheritedFromPaginationBase(bool nullable)
    {
        var document = Document();
        var pagination = document.Components!.Schemas!["BaseCollectionPaginationCountResponse"];
        ((OpenApiSchema)pagination.Properties!["@odata.nextLink"]).Type =
            nullable ? JsonSchemaType.String | JsonSchemaType.Null : JsonSchemaType.String;

        var files = await Generate(document, Group());

        var function = files["GetMgWidgetParentCalculate_Route0.g.cs"];
        Assert.Contains("var nextLink = result?.OdataNextLink", function);
        Assert.Contains(".WithUrl(nextLink).GetAsParentCalculateGetResponseAsync(", function);
    }

    [Fact]
    public async Task MixedFlagDoesNotAuthorizeResourceOnlyGroups()
    {
        var document = Document();
        var group = Group();
        var operation = document.Paths[Aggregate].Operations![HttpMethod.Get];
        operation.Extensions = null;
        const string resource = "/widgets/{widget-id}/parentCalculate";
        document.Paths[resource] = document.Paths[Aggregate];
        document.Paths.Remove(Aggregate);
        group = group with
        {
            Routes = group.Routes.Select(r => r.Path == Aggregate ? r with { Path = resource } : r).ToArray(),
        };
        var error = await Assert.ThrowsAsync<InvalidOperationException>(() => Generate(document, group));
        Assert.Contains("exactly one zero-argument paged GET function", error.Message);
    }

    [Fact]
    public async Task InlineFunctionArgumentsAreNotAuthorized()
    {
        var document = Document();
        const string parameterized = "/widgets/{widget-id}/parentCalculate(mode='{mode}')";
        document.Paths[parameterized] = document.Paths[Aggregate];
        document.Paths.Remove(Aggregate);
        var group = Group() with
        {
            Routes = Group().Routes.Select(r => r.Path == Aggregate ? r with { Path = parameterized } : r).ToArray(),
        };
        await Assert.ThrowsAsync<InvalidOperationException>(() => Generate(document, group));
    }

    [Fact]
    public void PagedMethodNameOptInLeavesOrdinaryListSourceUnchanged()
    {
        var naming = Naming.Resolve(new OperationInfo(HttpMethod.Get, List));
        var context = new EmitContext(Client);
        var names = ListQueries.ToHashSet();
        var baseline = CmdletEmitter.EmitListGet(naming, context, "Widget", "WidgetCollectionResponse", names);
        Assert.Equal(baseline, CmdletEmitter.EmitListGet(naming, context, "Widget", "WidgetCollectionResponse", names, methodName: "GetAsync"));
        var function = CmdletEmitter.EmitListGet(naming, context, "Widget", "WidgetCollectionResponse", names,
            methodName: "GetAsParentCalculateGetResponseAsync");
        Assert.Contains(".GetAsParentCalculateGetResponseAsync(", function);
        Assert.Contains(".WithUrl(nextLink).GetAsParentCalculateGetResponseAsync(", function);
    }

    [Theory]
    [InlineData("v1.0")]
    [InlineData("beta")]
    public async Task ActualTeamsContractsPinTheReviewedThreeOperations(string version)
    {
        var settings = new OpenApiReaderSettings();
        settings.AddYamlReader();
        using var stream = File.OpenRead(Path.Combine(RepositoryRoot(), "openApiDocs_KiotaCompat", version, "Teams.yml"));
        var result = await OpenApiDocument.LoadAsync(stream,
            settings: settings, cancellationToken: TestContext.Current.CancellationToken);
        var document = Assert.IsType<OpenApiDocument>(result.Document);
        var list = document.Paths[TeamsList].Operations![HttpMethod.Get];
        var item = document.Paths[TeamsItem].Operations![HttpMethod.Get];
        var aggregate = document.Paths[TeamsAggregate].Operations![HttpMethod.Get];
        foreach (var operation in new[] { list, item, aggregate })
        {
            Assert.Null(operation.RequestBody);
            Assert.DoesNotContain(operation.Parameters ?? [], p => p.In == ParameterLocation.Header);
        }
        Assert.Equal(ListQueries.Order(), Queries(list).Order());
        Assert.Equal(new[] { "$expand", "$select" }, Queries(item).Order());
        Assert.Equal(ListQueries.Append("model").Order(), Queries(aggregate).Order());
        var model = Assert.Single(aggregate.Parameters!, p => p.Name == "model");
        Assert.False(model.Required);
        Assert.Equal(JsonSchemaType.String, model.Schema!.Type);
        Assert.Equal("function", Assert.IsType<JsonNodeExtension>(aggregate.Extensions!["x-ms-docs-operation-type"]).Node!.ToString());
        var naming = Naming.Resolve(new OperationInfo(HttpMethod.Get, TeamsAggregate, Kind: OperationKind.Function));
        Assert.Empty(naming.FunctionParameters);
        Assert.Equal("Users.Item.Chats.GetAllMessages", naming.OperationTypeNamespace);
        Assert.Equal("GetAllMessages", naming.OperationTypeName);
        Assert.Equal("Users[UserId].Chats.GetAllMessages", naming.BuilderExpression);
        Assert.Equal("microsoft.graph.chatMessageCollectionResponse", Success(list).GetReferenceId());
        Assert.Equal("microsoft.graph.chatMessage", Success(item).GetReferenceId());
        var function = Success(aggregate);
        Assert.Null(function.GetReferenceId());
        Assert.Contains(function.AllOf!, s => s.GetReferenceId() == "BaseCollectionPaginationCountResponse");
        var values = function.AllOf!.SelectMany(s => s.Properties ?? new Dictionary<string, IOpenApiSchema>()).Single(p => p.Key == "value").Value;
        Assert.Equal(JsonSchemaType.Array, values.Type);
        Assert.Equal("microsoft.graph.chatMessage", values.Items!.GetReferenceId());
        var nextLink = document.Components!.Schemas!["BaseCollectionPaginationCountResponse"].Properties!["@odata.nextLink"];
        Assert.Equal(JsonSchemaType.String | JsonSchemaType.Null, nextLink.Type);
        Assert.Null(nextLink.GetReferenceId());
        Assert.Empty(nextLink.AnyOf ?? []);
        Assert.Empty(nextLink.OneOf ?? []);
        if (version == "v1.0")
        {
            var config = new GeneratorConfig(Client, Scratch, version);
            Assert.True(CmdletConfigurator.IsSuppressed(HttpMethod.Get, TeamsAggregate, config));
            Assert.False(CmdletConfigurator.IsCuratedSuppressed(HttpMethod.Get, TeamsAggregate));
            Assert.False(Group().IncludeDerivedSuppressedRoutes);
            Assert.True((Group() with { IncludeDerivedSuppressedRoutes = true }).IncludeDerivedSuppressedRoutes);
        }
    }

    private static string[] Queries(OpenApiOperation operation) =>
        (operation.Parameters ?? []).Where(p => p.In == ParameterLocation.Query).Select(p => p.Name!).ToArray();

    private static IOpenApiSchema Success(OpenApiOperation operation) =>
        operation.Responses!.First(r => r.Key.StartsWith('2')).Value.Content!["application/json"].Schema!;

    private static string RepositoryRoot()
    {
        var directory = new DirectoryInfo(AppContext.BaseDirectory);
        while (directory is not null && !Directory.Exists(Path.Combine(directory.FullName, "openApiDocs_KiotaCompat")))
            directory = directory.Parent;
        return directory?.FullName ?? throw new DirectoryNotFoundException("Cannot locate the actual Graph specifications.");
    }

    private static string Candidate(string source, string label, string shape) =>
        Assert.Single(source.ReplaceLineEndings("\n").Split('\n'), line => line.Contains($"(\"{label}\", \"{shape}\", ", StringComparison.Ordinal)).Trim();

    private static void AssertParameter(string source, string name, bool mandatory)
    {
        var lines = source.ReplaceLineEndings("\n").Split('\n');
        var index = Array.FindIndex(lines, line => line.Contains(" " + name + " { get; set; }", StringComparison.Ordinal));
        Assert.True(index > 0, "Missing parameter " + name);
        Assert.Contains($"Mandatory = {mandatory.ToString().ToLowerInvariant()}, ParameterSetName = \"Route\"", lines[index - 1]);
    }

    private static MultiRouteGroup Group() => new("beta",
    [
        new("GET", Aggregate, "Aggregate"),
        new("GET", List, "Chat"),
        new("GET", Item, "Chat"),
    ], "Aggregate", "Route")
    {
        AllowMixedReadOperations = true,
        AllowZeroArgumentFunctions = true,
        AllowAsymmetricRoutes = true,
        AllowExplicitRouteSelection = true,
        AllowPublishedParameterInference = true,
    };

    private static OpenApiParameter Query(string name) => new()
    {
        Name = name,
        In = ParameterLocation.Query,
        Schema = new OpenApiSchema
        {
            Type = name is "$top" or "$skip" ? JsonSchemaType.Integer
                : name == "$count" ? JsonSchemaType.Boolean
                : name is "$select" or "$expand" or "$orderby" ? JsonSchemaType.Array : JsonSchemaType.String,
            Items = name is "$select" or "$expand" or "$orderby" ? new OpenApiSchema { Type = JsonSchemaType.String } : null,
        },
    };

    private static OpenApiSchema Collection(OpenApiDocument document, string entity = "microsoft.graph.widget") => new()
    {
        Type = JsonSchemaType.Object,
        Properties = new Dictionary<string, IOpenApiSchema>
        {
            ["value"] = new OpenApiSchema { Type = JsonSchemaType.Array, Items = new OpenApiSchemaReference(entity, document) },
        },
    };

    private static OpenApiResponses Response(IOpenApiSchema schema) => new()
    {
        ["200"] = new OpenApiResponse
        {
            Content = new Dictionary<string, IOpenApiMediaType> { ["application/json"] = new OpenApiMediaType { Schema = schema } },
        },
    };

    private static OpenApiDocument Document()
    {
        var document = new OpenApiDocument { Paths = new OpenApiPaths(), Components = new OpenApiComponents() };
        document.Components.Schemas = new Dictionary<string, IOpenApiSchema>
        {
            ["microsoft.graph.widget"] = new OpenApiSchema { Type = JsonSchemaType.Object },
            ["microsoft.graph.other"] = new OpenApiSchema { Type = JsonSchemaType.Object },
            ["BaseCollectionPaginationCountResponse"] = new OpenApiSchema
            {
                Type = JsonSchemaType.Object,
                Properties = new Dictionary<string, IOpenApiSchema>
                {
                    ["@odata.nextLink"] = new OpenApiSchema { Type = JsonSchemaType.String | JsonSchemaType.Null },
                    ["@odata.count"] = new OpenApiSchema { Type = JsonSchemaType.Integer },
                },
            },
        };
        document.Components.Schemas["microsoft.graph.widgetCollectionResponse"] = new OpenApiSchema
        {
            AllOf = [new OpenApiSchemaReference("BaseCollectionPaginationCountResponse", document), Collection(document)],
        };
        foreach (var route in Group().Routes)
        {
            var function = route.Path == Aggregate;
            var item = route.Path == Item;
            IOpenApiSchema response = item ? new OpenApiSchemaReference("microsoft.graph.widget", document)
                : function ? new OpenApiSchema { AllOf = [new OpenApiSchemaReference("BaseCollectionPaginationCountResponse", document), Collection(document)] }
                : new OpenApiSchemaReference("microsoft.graph.widgetCollectionResponse", document);
            document.Paths[route.Path] = new OpenApiPathItem
            {
                Operations = new Dictionary<HttpMethod, OpenApiOperation>
                {
                    [HttpMethod.Get] = new()
                    {
                        Extensions = function ? new Dictionary<string, IOpenApiExtension> { ["x-ms-docs-operation-type"] = new JsonNodeExtension("function") } : null,
                        Parameters = (item ? new[] { "$select", "$expand" } : function ? ListQueries.Append("model") : ListQueries)
                            .Select(name => (IOpenApiParameter)Query(name)).ToList(),
                        Responses = Response(response),
                    },
                },
            };
        }
        return document;
    }

    private static async Task<Dictionary<string, string>> Generate(OpenApiDocument document, MultiRouteGroup group)
    {
        var output = Path.Combine(Scratch, "synthetic-" + Guid.NewGuid().ToString("N"));
        try
        {
            document.RegisterComponents();
            var config = new GeneratorConfig(Client, output, "beta", UseCollisionData: false, MultiRouteGroups: [group]);
            await new PowerShellWrapperGenerationService(document, config, NullLogger.Instance).GenerateAsync(CancellationToken.None);
            return Directory.GetFiles(output, "*.g.cs").ToDictionary(path => Path.GetFileName(path)!, File.ReadAllText);
        }
        finally
        {
            if (Directory.Exists(output))
                Directory.Delete(output, recursive: true);
        }
    }
}
