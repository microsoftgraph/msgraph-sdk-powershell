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

public sealed class ReviewedRouteExtensionTests
{
    private const string Client = "Microsoft.Graph.PowerShell.Test.Client";
    private const string FunctionRoot = "/external/industryData/runs";
    private const string FunctionName = "/microsoft.graph.industryData.getStatistics()";
    private const string FunctionFile = "GetMgExternalIndustryDataRunGetStatistics";
    private const string Statistics = "industryDataRunStatistics";
    private const string ActionRoot = "/directory/impactedResources";
    private const string ActionItem = "/{impactedResource-id}";

    [Fact]
    public void ExistingConfigurationConstructorsKeepEveryExtensionOptIn()
    {
        var route = new MultiRoute("GET", "/widgets", "Collection");
        var group = new MultiRouteGroup("v1.0", [route, route with { Path = "/widgets/{widget-id}", Name = "Item" }], "Collection");
        var (method, path, name) = route;
        var (version, routes, defaultRoute, selector) = group;

        Assert.Equal(("GET", "/widgets", "Collection"), (method, path, name));
        Assert.Equal("v1.0", version);
        Assert.Equal(group.Routes, routes);
        Assert.Equal("Collection", defaultRoute);
        Assert.Null(selector);
        Assert.Empty(route.QueryBindings);
        Assert.False(group.AllowZeroArgumentFunctions);
        Assert.False(group.AllowAsymmetricRoutes);
        Assert.False(group.AllowResponseUnion);
        Assert.False(group.AllowRouteSpecificBodies);
        Assert.False(group.AllowReferenceDelete);
        Assert.Equal("Route", new MultiRouteGroup(version, routes, defaultRoute, "Route").SelectorParameter);
    }

    [Fact]
    public async Task ReviewedZeroArgumentFunctionsKeepTypedWorkersAndDiscriminateByRunId()
    {
        var (document, group) = FunctionFixture();

        var files = await Generate(document, group);

        Assert.Equal(3, files.Count);
        var source = files[FunctionFile + ".g.cs"];
        Assert.Contains("DefaultParameterSetName = \"CollectionGet\"", source);
        Assert.Contains("[Parameter(Mandatory = true, ParameterSetName = \"ItemGet\", Position = 0)]", source);
        Assert.Contains("public string IndustryDataRunId", source);
        Assert.DoesNotContain("public string Route", source);
        Assert.DoesNotContain("ValidateSet", source);
        Assert.DoesNotContain("public SwitchParameter All", source);
        Assert.DoesNotContain("SupportsShouldProcess", source);
        Assert.Contains($"(\"\", \"CollectionGet\") => \"Get-MgExternalIndustryDataRunGetStatistics_Route0\"", source);
        Assert.Contains($"(\"\", \"ItemGet\") => \"Get-MgExternalIndustryDataRunGetStatistics_Route1\"", source);
        foreach (var (route, i) in group.Routes.Select((r, i) => (r, i)))
        {
            var naming = Naming.Resolve(new OperationInfo(HttpMethod.Get, route.Path, Kind: OperationKind.Function));
            Assert.Equal("MgExternalIndustryDataRunGetStatistics", naming.Noun);
            Assert.Equal("MicrosoftGraphIndustryDataGetStatistics", naming.OperationMemberName);
            Assert.Equal("GetStatistics", naming.OperationTypeName);
            Assert.Equal("External.IndustryData.Runs." + (i == 1 ? "Item." : "") + "MicrosoftGraphIndustryDataGetStatistics",
                naming.OperationTypeNamespace);
            var worker = files[$"{FunctionFile}_Route{i}.g.cs"];
            Assert.Contains("client.External.IndustryData.Runs" + (i == 1 ? "[IndustryDataRunId]" : "")
                + ".MicrosoftGraphIndustryDataGetStatistics.GetAsync(", worker);
            Assert.DoesNotContain("MicrosoftGraphIndustryDataGetStatistics()", worker);
            Assert.DoesNotContain("GetAsGetStatistics", worker);
            Assert.Contains($"[OutputType(typeof({Client}.Models.IndustryDataRunStatistics))]", worker);
            Assert.Contains($"[GraphRoute(\"GET\", \"{route.Path}\")]", worker);
            Assert.Contains($"[GraphRoute(\"GET\", \"{route.Path}\", ParameterSetName = \"{route.Name}Get\")]", source);
            Assert.Contains($"[OutputType(typeof({Client}.Models.IndustryDataRunStatistics), ParameterSetName = new[] {{ \"{route.Name}Get\" }})]", source);
        }
        AssertTypedForwarding(source);
    }

    [Fact]
    public async Task ZeroArgumentFunctionGroupsRemainRejectedWithoutTheirFlag()
    {
        var (document, group) = FunctionFixture();

        await Reject(document, group with { AllowZeroArgumentFunctions = false });
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public async Task FunctionOptInRejectsNonJsonAndEmptyRequestBodyDeclarations(bool requiredTextBody)
    {
        var (document, group) = FunctionFixture();
        document.Paths[group.Routes[1].Path].Operations![HttpMethod.Get].RequestBody = requiredTextBody
            ? new OpenApiRequestBody
            {
                Required = true,
                Content = new Dictionary<string, IOpenApiMediaType>
                {
                    ["text/plain"] = new OpenApiMediaType { Schema = new OpenApiSchema { Type = JsonSchemaType.String } },
                },
            }
            : new OpenApiRequestBody();

        var error = await Assert.ThrowsAsync<InvalidOperationException>(() => Generate(document, group));

        Assert.Contains("Reviewed GET route extensions do not support any request body", error.Message);
    }

    [Theory]
    [InlineData("arguments")]
    [InlineData("parameter-alias")]
    [InlineData("intermediate-call")]
    [InlineData("delta")]
    [InlineData("query")]
    [InlineData("header")]
    [InlineData("missing-response")]
    public async Task FunctionOptInDoesNotAuthorizeOtherCallShapes(string difference)
    {
        var (document, group) = FunctionFixture();
        if (difference is "arguments" or "parameter-alias" or "intermediate-call" or "delta")
        {
            var suffix = difference switch
            {
                "arguments" => "/microsoft.graph.industryData.getStatistics(resourceId='{resourceId}')",
                "parameter-alias" => "/microsoft.graph.industryData.getStatistics(resourceId=@resourceId)",
                "intermediate-call" => "/microsoft.graph.industryData.getStatistics(resourceId='{resourceId}')/result",
                _ => "/delta()",
            };
            var routes = group.Routes.Select(r => r with { Path = r.Path[..^FunctionName.Length] + suffix }).ToArray();
            for (var i = 0; i < routes.Length; i++)
            {
                var operation = document.Paths[group.Routes[i].Path].Operations![HttpMethod.Get];
                document.Paths.Remove(group.Routes[i].Path);
                Add(document, routes[i], operation);
            }
            group = group with { Routes = routes };
        }
        else
        {
            foreach (var route in group.Routes)
            {
                var operation = document.Paths[route.Path].Operations![HttpMethod.Get];
                if (difference == "missing-response")
                    operation.Responses = new OpenApiResponses { ["204"] = new OpenApiResponse() };
                else
                    operation.Parameters = [Parameter(difference == "query" ? "$select" : "ConsistencyLevel",
                        difference == "query" ? ParameterLocation.Query : ParameterLocation.Header)];
            }
        }

        await Reject(document, group);
    }

    [Theory]
    [InlineData("function", ParameterLocation.Query)]
    [InlineData("function", ParameterLocation.Header)]
    [InlineData("asymmetric", ParameterLocation.Query)]
    [InlineData("asymmetric", ParameterLocation.Header)]
    [InlineData("response", ParameterLocation.Query)]
    [InlineData("response", ParameterLocation.Header)]
    [InlineData("body", ParameterLocation.Query)]
    [InlineData("body", ParameterLocation.Header)]
    public async Task ReviewedExtensionsRejectInheritedQueryAndHeaderParameters(string policy, ParameterLocation location)
    {
        var (document, group) = policy switch
        {
            "function" => FunctionFixture(),
            "asymmetric" => FilesFixture(),
            "response" => SearchFixture(),
            _ => ActionFixture("addTag"),
        };
        if (policy == "response")
        {
            document.Paths.Remove(group.Routes[0].Path);
            group = group with { Routes = group.Routes.Skip(1).ToArray(), AllowAsymmetricRoutes = false };
        }
        else if (policy == "body")
        {
            document.Paths[group.Routes[0].Path].Operations![HttpMethod.Post].Responses =
                document.Paths[group.Routes[1].Path].Operations![HttpMethod.Post].Responses;
            group = group with { AllowResponseUnion = false };
        }
        var pathItem = (OpenApiPathItem)document.Paths[group.Routes[1].Path];
        pathItem.Parameters = [Parameter(location == ParameterLocation.Query ? "$select" : "ConsistencyLevel", location)];

        var error = await Assert.ThrowsAsync<InvalidOperationException>(() => Generate(document, group));

        Assert.Contains("Reviewed route extensions do not support path-item query or header parameters", error.Message);
    }

    [Fact]
    public async Task ZeroArgumentFunctionsStillPermitInheritedPathIdDeclarations()
    {
        var (document, group) = FunctionFixture();
        var pathItem = (OpenApiPathItem)document.Paths[group.Routes[1].Path];
        var id = Parameter("industryDataRun-id", ParameterLocation.Path);
        id.Required = true;
        pathItem.Parameters = [id];

        var files = await Generate(document, group);

        Assert.Equal(3, files.Count);
        Assert.Contains("public string IndustryDataRunId", files[FunctionFile + ".g.cs"]);
        Assert.Contains("client.External.IndustryData.Runs[IndustryDataRunId].MicrosoftGraphIndustryDataGetStatistics.GetAsync(",
            files[FunctionFile + "_Route1.g.cs"]);
    }

    [Fact]
    public async Task ReviewedSingletonAndCollectionGetPreserveShapeSpecificParametersAndMetadata()
    {
        var (document, group) = FilesFixture();

        var files = await Generate(document, group);

        Assert.Equal(3, files.Count);
        var source = files["GetMgShareListItem.g.cs"];
        Assert.Contains("DefaultParameterSetName = \"Get\"", source);
        Assert.Contains("[ValidateSet(\"Published\", \"Singleton\", \"Collection\")]", source);
        Assert.Contains("public string Route { get; set; } = \"Published\";", source);
        Assert.Contains("[Parameter(Mandatory = true, ParameterSetName = \"Get\", Position = 0)]", source);
        Assert.Contains("[Parameter(Mandatory = true, ParameterSetName = \"List\", Position = 0)]", source);
        Assert.Contains("public string SharedDriveItemId", source);
        AssertParameterSets(source, "Property", "Get", "List");
        AssertParameterSets(source, "ExpandProperty", "Get", "List");
        foreach (var parameter in new[] { "Filter", "Search", "Sort", "Top", "Skip", "Count", "All" })
            AssertParameterSets(source, parameter, "List");
        foreach (var alias in new[] { "Select", "Expand", "OrderBy" })
            Assert.Contains($"[Alias(\"{alias}\")]", source);
        foreach (var (route, i) in group.Routes.Select((r, i) => (r, i)))
        {
            var shape = i == 0 ? "Get" : "List";
            Assert.Contains($"[GraphRoute(\"GET\", \"{route.Path}\", ParameterSetName = \"{shape}\")]", source);
            Assert.Contains($"[OutputType(typeof({Client}.Models.ListItem), ParameterSetName = new[] {{ \"{shape}\" }})]", source);
            var worker = files[$"GetMgShareListItem_Route{i}.g.cs"];
            Assert.Contains("client.Shares[SharedDriveItemId]." + (i == 0 ? "ListItem" : "List.Items") + ".GetAsync(", worker);
            Assert.Equal(i == 1, worker.Contains("public SwitchParameter All", StringComparison.Ordinal));
            Assert.Contains($"[OutputType(typeof({Client}.Models.ListItem))]", worker);
        }
        AssertTypedForwarding(source, "Route");
    }

    [Fact]
    public async Task AsymmetricFamiliesStillRequireExplicitShapeAllowance()
    {
        var (document, group) = FilesFixture();

        var error = await Reject(document, group with { AllowAsymmetricRoutes = false });

        Assert.Contains("shape", error.Message, StringComparison.OrdinalIgnoreCase);
    }

    [Fact]
    public async Task ReviewedGetResponseUnionTruthfullyReportsEachGetModelButNotOnList()
    {
        var (document, group) = SearchFixture();

        var files = await Generate(document, group);

        Assert.Equal(4, files.Count);
        var source = files["GetMgWidget.g.cs"];
        Assert.Contains("DefaultParameterSetName = \"List\"", source);
        Assert.Contains("[ValidateSet(\"Published\", \"RunActivity\", \"Activity\")]", source);
        Assert.Contains($"[OutputType(typeof({Client}.Models.IndustryDataRunActivity), ParameterSetName = new[] {{ \"List\" }})]", source);
        foreach (var model in new[] { "IndustryDataRunActivity", "IndustryDataActivity" })
            Assert.Contains($"[OutputType(typeof({Client}.Models.{model}), ParameterSetName = new[] {{ \"Get\" }})]", source);
        Assert.DoesNotContain($"[OutputType(typeof({Client}.Models.IndustryDataActivity), ParameterSetName = new[] {{ \"List\" }})]", source);
        for (var i = 0; i < 3; i++)
        {
            var worker = files[$"GetMgWidget_Route{i}.g.cs"];
            var model = i == 2 ? "IndustryDataActivity" : "IndustryDataRunActivity";
            Assert.Contains($"[OutputType(typeof({Client}.Models.{model}))]", worker);
            Assert.DoesNotContain("typeof(object)", worker);
            Assert.Contains(i == 2
                ? "client.Widgets[IndustryDataRunId].Widgets[IndustryDataRunActivityId].Widgets.GetAsync("
                : "client.Widgets[IndustryDataRunId].Widgets" + (i == 1 ? "[IndustryDataRunActivityId]" : "") + ".GetAsync(", worker);
        }
        AssertTypedForwarding(source, "Route");
    }

    [Theory]
    [InlineData(false, false)]
    [InlineData(true, false)]
    [InlineData(false, true)]
    public async Task ShapeAndResponseAllowancesDoNotImplicitlyEnableEachOther(bool asymmetric, bool union)
    {
        var (document, group) = SearchFixture();

        var error = await Reject(document, group with { AllowAsymmetricRoutes = asymmetric, AllowResponseUnion = union });

        if (asymmetric)
            Assert.Contains("response", error.Message, StringComparison.OrdinalIgnoreCase);
        else if (union)
            Assert.Contains("shape", error.Message, StringComparison.OrdinalIgnoreCase);
    }

    [Fact]
    public async Task ExistingSymmetricGetGroupsStillRejectDifferentResponseModels()
    {
        var (document, group) = SearchFixture();
        document.Paths.Remove(group.Routes[0].Path);
        group = group with
        {
            Routes = group.Routes.Skip(1).ToArray(),
            AllowAsymmetricRoutes = false,
            AllowResponseUnion = false,
        };

        var error = await Reject(document, group);

        Assert.Contains("response", error.Message, StringComparison.OrdinalIgnoreCase);
    }

    [Fact]
    public async Task ExplicitResponseUnionDoesNotRequireAsymmetryForMatchingGetShapes()
    {
        var (document, group) = SearchFixture();
        document.Paths.Remove(group.Routes[0].Path);
        group = group with { Routes = group.Routes.Skip(1).ToArray(), AllowAsymmetricRoutes = false };

        var files = await Generate(document, group);

        Assert.Equal(3, files.Count);
        var source = files["GetMgWidget.g.cs"];
        Assert.Contains("DefaultParameterSetName = \"Get\"", source);
        foreach (var model in new[] { "IndustryDataRunActivity", "IndustryDataActivity" })
            Assert.Contains($"[OutputType(typeof({Client}.Models.{model}), ParameterSetName = new[] {{ \"Get\" }})]", source);
    }

    [Theory]
    [InlineData("addTag", "DisplayName", "RecommendationTag")]
    [InlineData("removeTag", "TagId", "ImpactedResource")]
    public async Task ReviewedDirectoryActionsKeepSeparateExpandedBodiesAndTypedReturnContracts(
        string operationName, string itemParameter, string itemModel)
    {
        var (document, group) = ActionFixture(operationName);

        var files = await Generate(document, group);

        var stem = "InvokeMgDirectoryImpactedResource" + char.ToUpperInvariant(operationName[0]) + operationName[1..];
        Assert.Equal(3, files.Count);
        var source = files[stem + ".g.cs"];
        Assert.Contains("DefaultParameterSetName = \"CollectionInvoke\"", source);
        Assert.Contains("SupportsShouldProcess = true", source);
        Assert.Contains("[Parameter(Mandatory = true, ParameterSetName = \"ItemInvoke\", Position = 0)]", source);
        Assert.Contains("public string ImpactedResourceId", source);
        AssertParameterSets(source, "ResourceIds", "CollectionInvoke");
        AssertParameterSets(source, "DisplayName", operationName == "addTag"
            ? ["CollectionInvoke", "ItemInvoke"] : ["CollectionInvoke"]);
        if (operationName == "removeTag")
            AssertParameterSets(source, itemParameter, "ItemInvoke");
        Assert.DoesNotContain("BodyParameter", source);
        Assert.DoesNotContain("public string Route", source);
        var member = char.ToUpperInvariant(operationName[0]) + operationName[1..];
        var collectionType = $"global::{Client}.DirectoryNamespace.ImpactedResources.{member}.{member}PostResponse";
        Assert.Contains($"[OutputType(typeof({collectionType}), ParameterSetName = new[] {{ \"CollectionInvoke\" }})]", source);
        Assert.Contains($"[OutputType(typeof({Client}.Models.{itemModel}), ParameterSetName = new[] {{ \"ItemInvoke\" }})]", source);
        for (var i = 0; i < 2; i++)
        {
            var worker = files[$"{stem}_Route{i}.g.cs"];
            var operationNamespace = $"global::{Client}.DirectoryNamespace.ImpactedResources." + (i == 1 ? "Item." : "") + member;
            Assert.Contains($"new {operationNamespace}.{member}PostRequestBody()", worker);
            Assert.Contains("client.Directory.ImpactedResources" + (i == 1 ? "[ImpactedResourceId]" : "") + "." + member, worker);
            Assert.DoesNotContain("dynamic", worker);
            Assert.DoesNotContain("System.Reflection", worker);
            Assert.DoesNotContain("BodyParameter", worker);
            Assert.Contains("if (!ShouldProcess(", worker);
            if (i == 0)
            {
                Assert.Contains($"[OutputType(typeof({collectionType}))]", worker);
                Assert.Contains($".PostAs{member}PostResponseAsync(body,", worker);
                Assert.Contains("body.ResourceIds = ResourceIds!.ToList()", worker);
                Assert.Contains("body.DisplayName = DisplayName", worker);
                Assert.DoesNotContain("public string ImpactedResourceId", worker);
            }
            else
            {
                Assert.Contains($"[OutputType(typeof({Client}.Models.{itemModel}))]", worker);
                Assert.Contains(".PostAsync(body,", worker);
                Assert.Contains($"body.{itemParameter} = {itemParameter}", worker);
                Assert.DoesNotContain("public string[]? ResourceIds", worker);
            }
        }
        AssertTypedForwarding(source);
    }

    [Theory]
    [InlineData("addTag", false, true, "body")]
    [InlineData("addTag", true, false, "response")]
    [InlineData("removeTag", false, true, "body")]
    [InlineData("removeTag", true, false, "response")]
    public async Task DirectoryActionAllowancesEachRequireTheirOwnExplicitFlag(
        string operationName, bool bodies, bool union, string contract)
    {
        var (document, group) = ActionFixture(operationName);

        var error = await Reject(document, group with { AllowRouteSpecificBodies = bodies, AllowResponseUnion = union });

        Assert.Contains(contract, error.Message, StringComparison.OrdinalIgnoreCase);
    }

    [Fact]
    public async Task RouteSpecificBodiesCannotUnifyDifferentClrTypesForTheSameParameter()
    {
        var (document, group) = ActionFixture("addTag");
        var body = (OpenApiSchema)document.Paths[group.Routes[1].Path].Operations![HttpMethod.Post]
            .RequestBody!.Content!["application/json"].Schema!;
        body.Properties!["displayName"] = new OpenApiSchema { Type = JsonSchemaType.Integer, Format = "int32" };

        var error = await Reject(document, group);

        Assert.Contains("parameter", error.Message, StringComparison.OrdinalIgnoreCase);
    }

    [Theory]
    [InlineData("inline-object", "InlineObject")]
    [InlineData("unknown-format", "UnknownFormat")]
    public async Task RouteSpecificBodiesRejectUnsupportedPropertiesInsteadOfDroppingThem(string shape, string diagnostic)
    {
        var (document, group) = ActionFixture("addTag");
        var body = (OpenApiSchema)document.Paths[group.Routes[1].Path].Operations![HttpMethod.Post]
            .RequestBody!.Content!["application/json"].Schema!;
        body.Properties!["unboundValue"] = shape == "inline-object" ? new OpenApiSchema
        {
            Type = JsonSchemaType.Object,
            Properties = new Dictionary<string, IOpenApiSchema> { ["label"] = new OpenApiSchema { Type = JsonSchemaType.String } },
        } : new OpenApiSchema { Type = JsonSchemaType.String, Format = "unreviewed-format" };

        var error = await Assert.ThrowsAsync<InvalidOperationException>(() => Generate(document, group));

        Assert.Contains("Unsupported route-specific body properties", error.Message);
        Assert.Contains("unboundValue", error.Message);
        Assert.Contains(diagnostic, error.Message);
    }

    [Theory]
    [InlineData("query")]
    [InlineData("parameter-alias")]
    [InlineData("media")]
    public async Task ActionExtensionsDoNotAuthorizeUnsupportedQueryOrMediaContracts(string difference)
    {
        var (document, group) = ActionFixture("addTag");
        foreach (var route in group.Routes)
        {
            var operation = document.Paths[route.Path].Operations![HttpMethod.Post];
            if (difference == "media")
                operation.RequestBody!.Content!["text/plain"] = new OpenApiMediaType
                {
                    Schema = new OpenApiSchema { Type = JsonSchemaType.String },
                };
            else
                operation.Parameters = [Parameter(difference == "query" ? "$select" : "@displayName", ParameterLocation.Query)];
        }

        await Reject(document, group);
    }

    [Fact]
    public async Task AsymmetricPolicyRequiresAnExplicitSelector()
    {
        var (document, group) = FilesFixture();

        var error = await Assert.ThrowsAsync<InvalidOperationException>(() => Generate(document, group with { SelectorParameter = null }));

        Assert.Contains("explicit selector", error.Message, StringComparison.OrdinalIgnoreCase);
    }

    [Theory]
    [InlineData("function", "GET functions")]
    [InlineData("body", "POST actions")]
    public async Task ResourceGetGroupsCannotClaimCallSpecificPolicies(string policy, string diagnostic)
    {
        var (document, group) = FilesFixture();
        group = policy == "function" ? group with { AllowZeroArgumentFunctions = true }
            : group with { AllowRouteSpecificBodies = true };

        var error = await Assert.ThrowsAsync<InvalidOperationException>(() => Generate(document, group));

        Assert.Contains(diagnostic, error.Message, StringComparison.OrdinalIgnoreCase);
    }

    [Fact]
    public async Task RouteSpecificActionBodiesRequireParentDiscriminationNotASelector()
    {
        var (document, group) = ActionFixture("addTag");

        var error = await Assert.ThrowsAsync<InvalidOperationException>(() => Generate(document, group with { SelectorParameter = "Route" }));

        Assert.Contains("Route-specific body plans require", error.Message, StringComparison.OrdinalIgnoreCase);
    }

    [Fact]
    public async Task AsymmetricResourcePolicyCannotBeAppliedToActionGroups()
    {
        var (document, group) = ActionFixture("addTag");
        group = group with { AllowAsymmetricRoutes = true, AllowRouteSpecificBodies = false, SelectorParameter = "Route" };

        var error = await Assert.ThrowsAsync<InvalidOperationException>(() => Generate(document, group));

        Assert.Contains("resource GET", error.Message, StringComparison.OrdinalIgnoreCase);
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public async Task ResponseUnionPolicyCannotBeAppliedToFunctionsOrResourceMutations(bool mutation)
    {
        var (document, group) = mutation ? ActionFixture("addTag") : FunctionFixture();
        if (mutation)
        {
            var routes = group.Routes.Select(r => r with { Method = "PATCH" }).ToArray();
            for (var i = 0; i < routes.Length; i++)
            {
                var operation = document.Paths[routes[i].Path].Operations![HttpMethod.Post];
                operation.Extensions = null;
                Add(document, routes[i], operation);
            }
            group = group with { Routes = routes, AllowRouteSpecificBodies = false };
        }

        var error = await Assert.ThrowsAsync<InvalidOperationException>(() => Generate(document, group with { AllowResponseUnion = true }));

        Assert.Contains("resource GET or POST action", error.Message, StringComparison.OrdinalIgnoreCase);
    }

    private static (OpenApiDocument Document, MultiRouteGroup Group) FunctionFixture()
    {
        var document = Document(Statistics);
        var routes = new[]
        {
            new MultiRoute("GET", FunctionRoot + FunctionName, "Collection"),
            new MultiRoute("GET", FunctionRoot + "/{industryDataRun-id}" + FunctionName, "Item"),
        };
        foreach (var route in routes)
            Add(document, route, Operation(NullableReference(document, Statistics), OperationKind.Function));
        return (document, new MultiRouteGroup("v1.0", routes, "Collection") { AllowZeroArgumentFunctions = true });
    }

    private static (OpenApiDocument Document, MultiRouteGroup Group) FilesFixture()
    {
        var document = Document("listItem");
        var routes = new[]
        {
            new MultiRoute("GET", "/shares/{sharedDriveItem-id}/listItem", "Singleton"),
            new MultiRoute("GET", "/shares/{sharedDriveItem-id}/list/items", "Collection"),
        };
        for (var i = 0; i < routes.Length; i++)
        {
            var operation = Operation(i == 0 ? Reference(document, "listItem") : Collection(document, "listItem"));
            operation.Parameters = Queries(i == 0
                ? ["$select", "$expand"]
                : ["$select", "$expand", "$filter", "$search", "$orderby", "$top", "$skip", "$count"]);
            Add(document, routes[i], operation);
        }
        return (document, new MultiRouteGroup("v1.0", routes, "Singleton", "Route") { AllowAsymmetricRoutes = true });
    }

    private static (OpenApiDocument Document, MultiRouteGroup Group) SearchFixture()
    {
        var document = Document("industryDataRunActivity", "industryDataActivity");
        // Repeated nouns use the existing structural collapse, isolating reviewed route policy
        // from module-specific published renames of /runs/.../activities/.../activity.
        var routes = new[]
        {
            new MultiRoute("GET", "/widgets/{industryDataRun-id}/widgets", "RunActivity"),
            new MultiRoute("GET", "/widgets/{industryDataRun-id}/widgets/{industryDataRunActivity-id}", "RunActivity"),
            new MultiRoute("GET", "/widgets/{industryDataRun-id}/widgets/{industryDataRunActivity-id}/widgets", "Activity"),
        };
        for (var i = 0; i < routes.Length; i++)
        {
            var operation = Operation(i == 0 ? Collection(document, "industryDataRunActivity")
                : Reference(document, i == 1 ? "industryDataRunActivity" : "industryDataActivity"));
            operation.Parameters = Queries(i == 0 ? ["$select", "$expand", "$filter"] : ["$select", "$expand"]);
            Add(document, routes[i], operation);
        }
        return (document, new MultiRouteGroup("v1.0", routes, "RunActivity", "Route")
        {
            AllowAsymmetricRoutes = true,
            AllowResponseUnion = true,
        });
    }

    private static (OpenApiDocument Document, MultiRouteGroup Group) ActionFixture(string name)
    {
        var document = Document("impactedResource", "recommendationTag");
        var routes = new[]
        {
            new MultiRoute("POST", ActionRoot + "/" + name, "Collection"),
            new MultiRoute("POST", ActionRoot + ActionItem + "/" + name, "Item"),
        };
        for (var i = 0; i < routes.Length; i++)
        {
            var operation = Operation(i == 0 ? Collection(document, "impactedResource")
                : NullableReference(document, name == "addTag" ? "recommendationTag" : "impactedResource"), OperationKind.Action);
            var properties = new Dictionary<string, IOpenApiSchema>();
            if (i == 0)
                properties["resourceIds"] = new OpenApiSchema
                {
                    Type = JsonSchemaType.Array,
                    Items = new OpenApiSchema { Type = JsonSchemaType.String },
                };
            properties[i == 1 && name == "removeTag" ? "tagId" : "displayName"] = new OpenApiSchema { Type = JsonSchemaType.String };
            operation.RequestBody = new OpenApiRequestBody
            {
                Content = new Dictionary<string, IOpenApiMediaType>
                {
                    ["application/json"] = new OpenApiMediaType
                    {
                        Schema = new OpenApiSchema { Type = JsonSchemaType.Object, Properties = properties },
                    },
                },
            };
            Add(document, routes[i], operation);
        }
        return (document, new MultiRouteGroup("v1.0", routes, "Collection")
        {
            AllowRouteSpecificBodies = true,
            AllowResponseUnion = true,
        });
    }

    private static OpenApiDocument Document(params string[] models) => new()
    {
        Paths = new OpenApiPaths(),
        Components = new OpenApiComponents
        {
            Schemas = models.ToDictionary(name => "microsoft.graph." + name, _ => (IOpenApiSchema)new OpenApiSchema
            {
                Type = JsonSchemaType.Object,
                Properties = new Dictionary<string, IOpenApiSchema> { ["id"] = new OpenApiSchema { Type = JsonSchemaType.String } },
            }),
        },
    };

    private static IOpenApiSchema Reference(OpenApiDocument document, string model) =>
        new OpenApiSchemaReference("microsoft.graph." + model, document);

    private static OpenApiSchema NullableReference(OpenApiDocument document, string model) => new()
    {
        AnyOf = [Reference(document, model), new OpenApiSchema { Type = JsonSchemaType.Object | JsonSchemaType.Null }],
    };

    private static OpenApiSchema Collection(OpenApiDocument document, string model) => new()
    {
        Type = JsonSchemaType.Object,
        Properties = new Dictionary<string, IOpenApiSchema>
        {
            ["value"] = new OpenApiSchema { Type = JsonSchemaType.Array, Items = Reference(document, model) },
        },
    };

    private static OpenApiOperation Operation(IOpenApiSchema response, OperationKind kind = OperationKind.Resource) => new()
    {
        Responses = new OpenApiResponses
        {
            ["200"] = new OpenApiResponse
            {
                Content = new Dictionary<string, IOpenApiMediaType>
                {
                    ["application/json"] = new OpenApiMediaType { Schema = response },
                },
            },
        },
        Extensions = kind == OperationKind.Resource ? null : new Dictionary<string, IOpenApiExtension>
        {
            ["x-ms-docs-operation-type"] = new JsonNodeExtension(kind == OperationKind.Action ? "action" : "function"),
        },
    };

    private static OpenApiParameter Parameter(string name, ParameterLocation location) => new()
    {
        Name = name,
        In = location,
        Schema = new OpenApiSchema
        {
            Type = name is "$top" or "$skip" ? JsonSchemaType.Integer : name == "$count" ? JsonSchemaType.Boolean : JsonSchemaType.String,
        },
    };

    private static List<IOpenApiParameter> Queries(string[] names) =>
        names.Select(name => (IOpenApiParameter)Parameter(name, ParameterLocation.Query)).ToList();

    private static void Add(OpenApiDocument document, MultiRoute route, OpenApiOperation operation) =>
        document.Paths[route.Path] = new OpenApiPathItem
        {
            Operations = new Dictionary<HttpMethod, OpenApiOperation> { [new HttpMethod(route.Method)] = operation },
        };

    private static void AssertParameterSets(string source, string parameter, params string[] sets)
    {
        var lines = source.ReplaceLineEndings("\n").Split('\n');
        var declaration = Array.FindIndex(lines, line => line.Contains(" " + parameter + " { get; set; }", StringComparison.Ordinal));
        Assert.True(declaration >= 0, "Missing parameter " + parameter);
        var attributes = new List<string>();
        for (var i = declaration - 1; i >= 0 && lines[i].TrimStart().StartsWith('['); i--)
            if (lines[i].Contains("[Parameter(", StringComparison.Ordinal))
                attributes.Add(lines[i]);
        Assert.Equal(sets.Length, attributes.Count);
        foreach (var set in sets)
            Assert.Contains(attributes, attribute => attribute.Contains($"ParameterSetName = \"{set}\"", StringComparison.Ordinal));
    }

    private static void AssertTypedForwarding(string source, string? selector = null)
    {
        Assert.Contains("new Dictionary<string, object>(MyInvocation.BoundParameters", source);
        Assert.Contains("\"param($BoundParameters, $CmdletName) & $CmdletName @BoundParameters\"", source);
        Assert.Contains("PipelineResultTypes.Output | PipelineResultTypes.Error", source);
        Assert.Contains("parameters, internalCmdletName", source);
        if (selector is not null)
            Assert.Contains($"parameters.Remove(\"{selector}\")", source);
        Assert.DoesNotContain("dynamic", source);
        Assert.DoesNotContain("System.Reflection", source);
    }

    private static async Task<InvalidOperationException> Reject(OpenApiDocument document, MultiRouteGroup group)
    {
        var error = await Assert.ThrowsAsync<InvalidOperationException>(() => Generate(document, group));
        Assert.Contains("multi-route", error.Message, StringComparison.OrdinalIgnoreCase);
        return error;
    }

    private static async Task<Dictionary<string, string>> Generate(OpenApiDocument document, MultiRouteGroup group)
    {
        var output = Path.Combine(Directory.GetCurrentDirectory(), ".reviewed-route-tests-" + Guid.NewGuid().ToString("N"));
        try
        {
            document.RegisterComponents();
            var config = new GeneratorConfig(Client, output, UseCollisionData: false, MultiRouteGroups: [group]);
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
