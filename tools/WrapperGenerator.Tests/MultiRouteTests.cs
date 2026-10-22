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

public sealed class MultiRouteTests
{
    private const string Legacy = "/bookingBusinesses";
    private const string Solutions = "/solutions/bookingBusinesses";
    private const string Item = "/{bookingBusiness-id}";
    private const string Client = "Microsoft.Graph.PowerShell.Test.Client";
    private const string Entity = Client + ".Models.BookingBusiness";

    [Fact]
    public async Task ListAndItemRoutesShareOnePublicCommandWithFourTypedWorkers()
    {
        var document = Document();
        foreach (var root in new[] { Legacy, Solutions })
        {
            Add(document, "GET", root, Get(document, list: true));
            Add(document, "GET", root + Item, Get(document));
        }
        var group = Group("GET", "", includeItem: true);

        var files = await Generate(document, [group]);

        Assert.Equal(5, files.Count);
        var source = files["GetMgBookingBusiness.g.cs"];
        Assert.Contains("DefaultParameterSetName = \"List\"", source);
        Assert.Contains("[ValidateSet(\"Published\", \"Legacy\", \"Solutions\")]", source);
        Assert.Contains("public string Route { get; set; } = \"Published\";", source);
        Assert.Contains("? \"LEGACY\" : Route.ToUpperInvariant()", source);
        Assert.Contains("[OutputType(typeof(" + Entity + "), ParameterSetName = new[] { \"List\" })]", source);
        Assert.Contains("[OutputType(typeof(" + Entity + "), ParameterSetName = new[] { \"Get\" })]", source);
        Assert.Contains("ParameterSetName = \"Get\", Position = 0", source);
        Assert.Contains("public string BookingBusinessId", source);
        Assert.DoesNotContain("SupportsShouldProcess", source);
        for (var i = 0; i < 4; i++)
        {
            var worker = files[$"GetMgBookingBusiness_Route{i}.g.cs"];
            var route = group.Routes[i];
            var shape = route.Path.EndsWith(Item, StringComparison.Ordinal) ? "Get" : "List";
            Assert.Contains($"(\"{route.Name.ToUpperInvariant()}\", \"{shape}\") => \"Get-MgBookingBusiness_Route{i}\"", source);
            Assert.Contains($"[GraphRoute(\"GET\", \"{route.Path}\", ParameterSetName = \"{shape}\")]", source);
            Assert.Contains($"[GraphRoute(\"GET\", \"{route.Path}\")]", worker);
            Assert.Contains("[OutputType(typeof(" + Entity + "))]", worker);
            Assert.Contains(route.Name == "Legacy" ? "client.BookingBusinesses" : "client.Solutions.BookingBusinesses", worker);
            Assert.Contains(shape == "List" ? "result?.Value" : "[BookingBusinessId]", worker);
            Assert.Contains(".GetAsync(", worker);
            Assert.DoesNotContain("InvokeCommand.InvokeScript", worker);
            AssertCatchFilters(worker);
        }
        AssertForwarding(source, "Route");
        AssertCatchFilters(source, dispatcher: true);
    }

    [Fact]
    public async Task DispatcherPreservesQueryAliasesHeadersAndAllWithoutInventingParameters()
    {
        var document = Document();
        foreach (var root in new[] { Legacy, Solutions })
        {
            var list = Get(document, list: true);
            list.Parameters = [Header("ConsistencyLevel"), .. Queries("$select", "$expand", "$filter", "$search", "$orderby", "$top", "$skip", "$count")];
            var item = Get(document);
            item.Parameters = [Header("If-Match"), .. Queries("$select", "$expand")];
            Add(document, "GET", root, list);
            Add(document, "GET", root + Item, item);
        }

        var files = await Generate(document, [Group("GET", "", includeItem: true)]);
        var source = files["GetMgBookingBusiness.g.cs"];
        foreach (var declaration in new[]
        {
            "string[]? Property", "string[]? ExpandProperty", "string? Filter", "string? Search",
            "string[]? Sort", "int Top", "int Skip", "SwitchParameter Count", "SwitchParameter All",
            "string? ConsistencyLevel", "string? IfMatch",
        })
            Assert.Contains("public " + declaration, source);
        foreach (var alias in new[] { "Select", "Expand", "OrderBy" })
            Assert.Contains($"[Alias(\"{alias}\")]", source);
        Assert.DoesNotContain("public string? AccessToken", source);
        Assert.DoesNotContain("public Dictionary", source);
        AssertForwarding(source, "Route");

        var listWorker = files["GetMgBookingBusiness_Route0.g.cs"];
        foreach (var property in new[] { "Select", "Expand", "Filter", "Search", "Orderby", "Top", "Skip", "Count" })
            Assert.Contains("requestConfiguration.QueryParameters." + property, listWorker);
        Assert.Contains("requestConfiguration.Headers.Add(\"ConsistencyLevel\", ConsistencyLevel!)", listWorker);
        Assert.Contains("AddRequestHeaders(requestConfiguration.Headers)", listWorker);
        Assert.Contains("WithUrl", listWorker);
        Assert.Contains("All.IsPresent", listWorker);

        var itemWorker = files["GetMgBookingBusiness_Route1.g.cs"];
        Assert.Contains("requestConfiguration.Headers.Add(\"If-Match\", IfMatch!)", itemWorker);
        Assert.DoesNotContain("public SwitchParameter All", itemWorker);
        Assert.DoesNotContain("public string? Filter", itemWorker);
    }

    [Fact]
    public async Task CalendarViewPreservesRequiredStartAndEndOnBothListAndItemRoutes()
    {
        var (document, group) = CalendarViewFixture();

        var files = await Generate(document, [group]);

        Assert.Equal(5, files.Count);
        var source = files["GetMgBookingBusinessCalendarView.g.cs"];
        Assert.Contains("DefaultParameterSetName = \"List\"", source);
        foreach (var parameter in new[] { "Start", "End" })
        {
            Assert.Contains("public string " + parameter + " { get; set; } = string.Empty;", source);
            foreach (var shape in new[] { "List", "Get" })
                Assert.Contains($"[Parameter(Mandatory = true, ParameterSetName = \"{shape}\")]", source);
            Assert.DoesNotContain("public string? " + parameter, source);
        }
        Assert.Contains("public string BookingBusinessId", source);
        Assert.Contains("public string BookingAppointmentId", source);
        Assert.Contains("public SwitchParameter All", source);
        Assert.Contains("[Alias(\"Select\")]", source);
        AssertForwarding(source, "Route");
        for (var i = 0; i < group.Routes.Count; i++)
        {
            var worker = files[$"GetMgBookingBusinessCalendarView_Route{i}.g.cs"].ReplaceLineEndings("\n");
            var builder = i < 2 ? "client.BookingBusinesses" : "client.Solutions.BookingBusinesses";
            builder += "[BookingBusinessId].CalendarView" + (i % 2 == 0 ? "" : "[BookingAppointmentId]");
            Assert.Contains(builder + ".GetAsync(", worker);
            foreach (var parameter in new[] { "Start", "End" })
            {
                Assert.Contains("[Parameter(Mandatory = true)]\n        public string "
                    + parameter + " { get; set; } = string.Empty;", worker);
                Assert.Contains($"if (this.IsParameterBound(nameof({parameter})))", worker);
                Assert.Contains($"requestConfiguration.QueryParameters.{parameter} = {parameter};", worker);
            }
            Assert.Equal(i % 2 == 0, worker.Contains("public SwitchParameter All", StringComparison.Ordinal));
        }
    }

    [Fact]
    public async Task CalendarViewRejectsUnsupportedNonODataIntegerQueryExplicitly()
    {
        var (document, group) = CalendarViewFixture();
        foreach (var route in group.Routes)
        {
            var operation = document.Paths[route.Path].Operations![HttpMethod.Get];
            operation.Parameters!.Add(new OpenApiParameter
            {
                Name = "offset",
                In = ParameterLocation.Query,
                Schema = new OpenApiSchema { Type = JsonSchemaType.Integer },
            });
        }

        var ex = await Assert.ThrowsAsync<InvalidOperationException>(() => Generate(document, [group]));

        Assert.Contains("Unsupported multi-route query parameter 'offset'", ex.Message);
        Assert.Contains("only plain named strings", ex.Message);
    }

    [Theory]
    [InlineData("missing")]
    [InlineData("required")]
    [InlineData("renamed")]
    public async Task CalendarViewRequiresMatchingNonODataQueryShapesAcrossRoutes(string difference)
    {
        var (document, group) = CalendarViewFixture();
        var operation = document.Paths[group.Routes[2].Path].Operations![HttpMethod.Get];
        var start = (OpenApiParameter)operation.Parameters!.Single(p => p.Name == "start");
        if (difference == "missing")
            operation.Parameters!.Remove(start);
        else if (difference == "required")
            start.Required = false;
        else
            start.Name = "from";

        var ex = await Assert.ThrowsAsync<InvalidOperationException>(() => Generate(document, [group]));

        Assert.Contains("Incompatible multi-route", ex.Message);
    }

    [Fact]
    public async Task NonOptedInCalendarViewKeepsExistingQuerySurfaceUnchanged()
    {
        var (document, group) = CalendarViewFixture();
        foreach (var route in group.Routes.Where(r => r.Name == "Solutions"))
            document.Paths.Remove(route.Path);

        var files = await Generate(document);

        Assert.Equal(3, files.Count);
        foreach (var source in files.Values)
        {
            Assert.DoesNotContain("public string Start", source);
            Assert.DoesNotContain("public string End", source);
            Assert.DoesNotContain("QueryParameters.Start", source);
            Assert.DoesNotContain("QueryParameters.End", source);
        }
    }

    [Fact]
    public async Task ScalarWorkersForwardRequiredAndOptionalNonODataStrings()
    {
        var document = Document();
        foreach (var root in new[] { Legacy, Solutions })
        {
            var operation = Count();
            operation.Parameters =
            [
                new OpenApiParameter
                {
                    Name = "start", In = ParameterLocation.Query, Required = true,
                    Schema = new OpenApiSchema { Type = JsonSchemaType.String },
                },
                new OpenApiParameter
                {
                    Name = "locale", In = ParameterLocation.Query,
                    Schema = new OpenApiSchema { Type = JsonSchemaType.String },
                },
            ];
            Add(document, "GET", root + "/$count", operation);
        }

        var files = await Generate(document, [Group("GET", "/$count")]);

        var source = files["GetMgBookingBusinessCount.g.cs"];
        Assert.Contains("[Parameter(Mandatory = true, ParameterSetName = \"Scalar\")]", source);
        Assert.Contains("public string Start { get; set; } = string.Empty;", source);
        Assert.Contains("[Parameter(Mandatory = false, ParameterSetName = \"Scalar\")]", source);
        Assert.Contains("public string? Locale { get; set; }", source);
        AssertForwarding(source, "Route");
        foreach (var worker in files.Where(p => p.Key.Contains("_Route", StringComparison.Ordinal)).Select(p => p.Value))
        {
            Assert.Contains("[OutputType(typeof(int))]", worker);
            Assert.Contains("public string Start { get; set; } = string.Empty;", worker);
            Assert.Contains("public string? Locale { get; set; }", worker);
            Assert.Contains("requestConfiguration.QueryParameters.Start = Start;", worker);
            Assert.Contains("requestConfiguration.QueryParameters.Locale = Locale;", worker);
        }
    }

    [Fact]
    public async Task CountRoutesKeepScalarTypingAndOnlySupportedQueryOptions()
    {
        var document = Document();
        foreach (var root in new[] { Legacy, Solutions })
        {
            var operation = Count();
            operation.Parameters = [Header("ConsistencyLevel"), .. Queries("$filter", "$search")];
            Add(document, "GET", root + "/$count", operation);
        }

        var files = await Generate(document, [Group("GET", "/$count")]);

        Assert.Equal(3, files.Count);
        var source = files["GetMgBookingBusinessCount.g.cs"];
        Assert.Contains("DefaultParameterSetName = \"Scalar\"", source);
        Assert.Contains("[OutputType(typeof(int), ParameterSetName = new[] { \"Scalar\" })]", source);
        Assert.Contains("public string? Filter", source);
        Assert.Contains("public string? Search", source);
        Assert.Contains("public string? ConsistencyLevel", source);
        foreach (var text in new[] { "SwitchParameter All", "string[]? Property", "public int Top", "BookingBusinessId" })
            Assert.DoesNotContain(text, source);
        foreach (var worker in files.Where(p => p.Key.Contains("_Route", StringComparison.Ordinal)).Select(p => p.Value))
        {
            Assert.Contains("[OutputType(typeof(int))]", worker);
            Assert.Contains(".BookingBusinesses.Count.GetAsync(", worker);
            Assert.Contains("requestConfiguration.QueryParameters.Filter", worker);
            Assert.Contains("requestConfiguration.QueryParameters.Search", worker);
            Assert.Contains("requestConfiguration.Headers.Add(\"ConsistencyLevel\", ConsistencyLevel!)", worker);
            Assert.DoesNotContain("result.Value", worker);
        }
        AssertForwarding(source, "Route");
    }

    [Theory]
    [InlineData("POST", "", "New", "PostAsync", "Medium")]
    [InlineData("PATCH", Item, "Update", "PatchAsync", "Medium")]
    [InlineData("PUT", Item, "Set", "PutAsync", "Medium")]
    [InlineData("DELETE", Item, "Remove", "DeleteAsync", "High")]
    [InlineData("DELETE", "", "Remove", "DeleteAsync", "High")]
    public async Task MutationsUseTypedWorkersAndPreserveActualPathIds(
        string method, string suffix, string verb, string call, string impact)
    {
        var document = Document();
        foreach (var root in new[] { Legacy, Solutions })
        {
            var operation = Mutation(document, body: method != "DELETE");
            operation.Parameters = [Header("If-Match")];
            Add(document, method, root + suffix, operation);
        }

        var files = await Generate(document, [Group(method, suffix)]);

        Assert.Equal(3, files.Count);
        var source = files[$"{verb}MgBookingBusiness.g.cs"];
        Assert.Contains("DefaultParameterSetName = \"Invoke\"", source);
        Assert.Contains($"SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.{impact}", source);
        Assert.Contains("public string? IfMatch", source);
        Assert.Equal(suffix == Item, source.Contains("public string BookingBusinessId", StringComparison.Ordinal));
        Assert.DoesNotContain("if (!ShouldProcess(", source);
        AssertForwarding(source, "Route");
        AssertCatchFilters(source, dispatcher: true);
        for (var i = 0; i < 2; i++)
        {
            var worker = files[$"{verb}MgBookingBusiness_Route{i}.g.cs"];
            Assert.Contains($".{call}(", worker);
            Assert.Contains("if (!ShouldProcess(", worker);
            Assert.Contains("ConfirmImpact = ConfirmImpact." + impact, worker);
            Assert.Equal(suffix == Item, worker.Contains("[BookingBusinessId]", StringComparison.Ordinal));
            Assert.Equal(suffix == Item, worker.Contains("public string BookingBusinessId", StringComparison.Ordinal));
            Assert.Contains("requestConfiguration.Headers.Add(\"If-Match\", IfMatch!)", worker);
            Assert.Contains("AddRequestHeaders(requestConfiguration.Headers)", worker);
            Assert.DoesNotContain("re-fetching the updated resource", worker);
            AssertCatchFilters(worker);
            if (method != "DELETE")
            {
                Assert.Contains("public string? DisplayName", source);
                Assert.Contains("public string? DisplayName", worker);
                Assert.Contains("body.DisplayName = DisplayName", worker);
                Assert.Contains(Entity, worker);
            }
        }
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public async Task ActionWorkersKeepRouteSpecificRequestAndResponseNamespaces(bool expandedBody)
    {
        var document = Document();
        const string suffix = Item + "/publish";
        foreach (var root in new[] { Legacy, Solutions })
        {
            var operation = Mutation(document, body: false);
            operation.Extensions = new Dictionary<string, IOpenApiExtension>
            {
                ["x-ms-docs-operation-type"] = new JsonNodeExtension("action"),
            };
            operation.Parameters = [Header("If-Match")];
            if (expandedBody)
            {
                operation.RequestBody = JsonBody(new OpenApiSchema
                {
                    Type = JsonSchemaType.Object,
                    Properties = new Dictionary<string, IOpenApiSchema>
                    {
                        ["notify"] = new OpenApiSchema { Type = JsonSchemaType.Boolean },
                        ["business"] = Reference(document),
                        ["recipients"] = new OpenApiSchema { Type = JsonSchemaType.Array, Items = new OpenApiSchema { Type = JsonSchemaType.String } },
                    },
                });
                operation.Responses = JsonResponse(new OpenApiSchema
                {
                    Type = JsonSchemaType.Object,
                    Properties = new Dictionary<string, IOpenApiSchema>
                    {
                        ["value"] = new OpenApiSchema { Type = JsonSchemaType.String },
                    },
                });
            }
            Add(document, "POST", root + suffix, operation);
        }
        var group = Group("POST", suffix) with { DefaultRoute = "Solutions" };

        var files = await Generate(document, [group]);

        var source = files["InvokeMgBookingBusinessPublish.g.cs"];
        Assert.Contains("? \"SOLUTIONS\" : Route.ToUpperInvariant()", source);
        Assert.Contains("SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium", source);
        AssertForwarding(source, "Route");
        for (var i = 0; i < 2; i++)
        {
            var worker = files[$"InvokeMgBookingBusinessPublish_Route{i}.g.cs"];
            var operationNamespace = Client + (i == 0 ? "." : ".Solutions.") + "BookingBusinesses.Item.Publish.Publish";
            Assert.Contains("if (!ShouldProcess(", worker);
            Assert.Contains(".BookingBusinesses[BookingBusinessId].Publish.", worker);
            if (expandedBody)
            {
                Assert.Contains("new global::" + operationNamespace + "PostRequestBody", worker);
                Assert.Contains("[OutputType(typeof(global::" + operationNamespace + "PostResponse))]", worker);
                Assert.Contains(".PostAsPublishPostResponseAsync(", worker);
                Assert.Contains("public bool? Notify", source);
                Assert.Contains("public " + Entity + "? Business", source);
                Assert.Contains("public string[]? Recipients", source);
                Assert.Contains("body.Notify = Notify", worker);
                Assert.Contains("body.Business = Business", worker);
                Assert.Contains("body.Recipients = Recipients!.ToList()", worker);
                Assert.Contains("typeof(global::" + operationNamespace + "PostResponse)", source);
            }
            else
            {
                Assert.Contains(".PostAsync(", worker);
                Assert.DoesNotContain("PostRequestBody", worker);
                Assert.DoesNotContain("[OutputType(", source);
            }
            AssertCatchFilters(worker);
        }
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public async Task PublishedRouteUsesExplicitDefaultNotMemberOrdering(bool reverse)
    {
        var document = TwoItems();
        var group = Group("GET", Item) with { DefaultRoute = "Solutions" };
        if (reverse)
            group = group with { Routes = group.Routes.Reverse().ToArray() };

        var files = await Generate(document, [group]);

        var source = files["GetMgBookingBusiness.g.cs"];
        Assert.Contains("? \"SOLUTIONS\" : Route.ToUpperInvariant()", source);
        var index = reverse ? 0 : 1;
        Assert.Contains($"(\"SOLUTIONS\", \"Get\") => \"Get-MgBookingBusiness_Route{index}\"", source);
        Assert.Contains("client.Solutions.BookingBusinesses[BookingBusinessId]", files[$"GetMgBookingBusiness_Route{index}.g.cs"]);
    }

    [Fact]
    public void ParentDiscriminatedGovernanceDispatcherRetainsActualIdsAndFourParameterSets()
    {
        var routes = new[]
        {
            new MultiRoute("GET", "/identityGovernance/accessReviews/definitions/{accessReviewScheduleDefinition-id}/instances", "Definition"),
            new MultiRoute("GET", "/identityGovernance/accessReviews/definitions/{accessReviewScheduleDefinition-id}/instances/{accessReviewInstance-id}", "Definition"),
            new MultiRoute("GET", "/identityGovernance/accessReviews/historyDefinitions/{accessReviewHistoryDefinition-id}/instances", "History"),
            new MultiRoute("GET", "/identityGovernance/accessReviews/historyDefinitions/{accessReviewHistoryDefinition-id}/instances/{accessReviewInstance-id}", "History"),
        };
        var group = new MultiRouteGroup("v1.0", routes, "History");
        var workers = routes.Select((route, i) =>
        {
            var naming = Naming.Resolve(new OperationInfo(HttpMethod.Get, route.Path)) with
            {
                Noun = "MgIdentityGovernanceAccessReviewInstance",
                ClassName = "GetMgIdentityGovernanceAccessReviewInstanceCommand",
            };
            var shape = i % 2 == 0 ? "List" : "Get";
            return new CmdletEmitter.RouteWorker(naming, Naming.WithSuffix(naming, $"_Route{i}"),
                route.Name, shape, CmdletEmitter.GetDispatchParameters(naming, shape, new HashSet<string> { "$select" }, []),
                Client + ".Models.AccessReviewInstance");
        }).ToArray();

        var source = CmdletEmitter.EmitMultiRouteDispatcher(group, workers, new EmitContext(Client));

        Assert.Contains("DefaultParameterSetName = \"HistoryList\"", source);
        foreach (var set in new[] { "DefinitionList", "DefinitionGet", "HistoryList", "HistoryGet" })
            Assert.Contains($"ParameterSetName = \"{set}\"", source);
        foreach (var id in new[] { "AccessReviewScheduleDefinitionId", "AccessReviewHistoryDefinitionId", "AccessReviewInstanceId" })
            Assert.Contains("public string " + id, source);
        Assert.DoesNotContain("public string Route", source);
        Assert.DoesNotContain("ValidateSet", source);
        Assert.DoesNotContain("Id1", source);
        for (var i = 0; i < workers.Length; i++)
        {
            Assert.Contains($"(\"\", \"{routes[i].Name}{workers[i].Shape}\") => \"Get-MgIdentityGovernanceAccessReviewInstance_Route{i}\"", source);
            Assert.Contains($"[GraphRoute(\"GET\", \"{routes[i].Path}\", ParameterSetName = \"{routes[i].Name}{workers[i].Shape}\")]", source);
        }
        var idParameter = Assert.Single(workers[1].Parameters, p => p.Name == "AccessReviewInstanceId");
        Assert.True(idParameter.Mandatory);
        Assert.Equal(1, idParameter.Position);
        AssertForwarding(source);
    }

    [Fact]
    public async Task StructurallyRepeatedNounsCanDiscriminateRoutesWithoutInventingIds()
    {
        var document = Document();
        var routes = new[]
        {
            new MultiRoute("GET", "/widgets", "Root"),
            new MultiRoute("GET", "/widgets/{widget-id}", "Root"),
            new MultiRoute("GET", "/widgets/{parent-id}/widgets", "Parent"),
            new MultiRoute("GET", "/widgets/{parent-id}/widgets/{widget-id}", "Parent"),
        };
        foreach (var (route, i) in routes.Select((r, i) => (r, i)))
            Add(document, "GET", route.Path, Get(document, list: i % 2 == 0));

        var files = await Generate(document, [new MultiRouteGroup("v1.0", routes, "Root")]);

        var source = files["GetMgWidget.g.cs"];
        Assert.Contains("DefaultParameterSetName = \"RootList\"", source);
        Assert.Contains("public string ParentId", source);
        Assert.Contains("public string WidgetId", source);
        Assert.DoesNotContain("WidgetId1", source);
        Assert.Contains("client.Widgets[ParentId].Widgets[WidgetId]", files["GetMgWidget_Route3.g.cs"]);
    }

    [Fact]
    public async Task NoOptInStillFailsWithOriginalCollisionDiagnostic()
    {
        var ex = await Assert.ThrowsAsync<InvalidOperationException>(() => Generate(TwoItems(), useCollisionData: true));

        Assert.Contains("collision", ex.Message);
        Assert.Contains("GetMgBookingBusiness.g.cs", ex.Message);
        Assert.Contains("/bookingbusinesses/{}", ex.Message);
        Assert.Contains("/solutions/bookingbusinesses/{}", ex.Message);
    }

    [Fact]
    public async Task WrongProfileDoesNotActivateGroup()
    {
        var ex = await Assert.ThrowsAsync<InvalidOperationException>(() =>
            Generate(TwoItems(), [Group("GET", Item) with { ApiVersion = "beta" }], useCollisionData: true));

        Assert.Contains("collision", ex.Message);
        Assert.DoesNotContain("Multi-route", ex.Message);
    }

    [Fact]
    public async Task UnrelatedModuleIgnoresAbsentGroup()
    {
        var document = Document();
        Add(document, "GET", "/widgets/{widget-id}", Get(document));

        var files = await Generate(document, [Group("GET", Item)]);

        Assert.Single(files);
        Assert.Contains("GetMgWidget.g.cs", files.Keys);
    }

    [Theory]
    [InlineData("single")]
    [InlineData("empty")]
    [InlineData("too-many")]
    [InlineData("missing-default")]
    [InlineData("same-name")]
    [InlineData("published-name")]
    [InlineData("invalid-name")]
    [InlineData("invalid-selector")]
    [InlineData("wildcard")]
    [InlineData("relative-path")]
    [InlineData("duplicate-operation")]
    [InlineData("overlap")]
    public async Task InvalidGroupsFailLoudly(string scenario)
    {
        var group = Group("GET", Item);
        IReadOnlyList<MultiRouteGroup> groups = [scenario switch
        {
            "single" => group with { Routes = [group.Routes[0]] },
            "empty" => group with { Routes = [] },
            "too-many" => group with { Routes = Enumerable.Range(0, 33).Select(i => new MultiRoute("GET", "/widgets" + i, "Route" + i)).ToArray() },
            "missing-default" => group with { DefaultRoute = "Missing" },
            "same-name" => group with { Routes = group.Routes.Select(r => r with { Name = "Legacy" }).ToArray() },
            "published-name" => group with { Routes = [group.Routes[0] with { Name = "Published" }, group.Routes[1]] },
            "invalid-name" => group with { Routes = [group.Routes[0] with { Name = "not-a-name" }, group.Routes[1]] },
            "invalid-selector" => group with { SelectorParameter = "route-name" },
            "wildcard" => group with { Routes = [group.Routes[0] with { Path = Legacy + "/*" }, group.Routes[1]] },
            "relative-path" => group with { Routes = [group.Routes[0] with { Path = "bookingBusinesses" }, group.Routes[1]] },
            "duplicate-operation" => group with { Routes = [group.Routes[0], group.Routes[0] with { Name = "Solutions" }] },
            _ => group,
        }];
        if (scenario == "overlap")
            groups = [group, group];

        var ex = await Assert.ThrowsAsync<InvalidOperationException>(() => Generate(TwoItems(), groups));

        Assert.True(ex.Message.Contains("multi-route", StringComparison.OrdinalIgnoreCase), ex.Message);
    }

    [Theory]
    [InlineData("missing")]
    [InlineData("unsupported")]
    [InlineData("suppressed")]
    public async Task PartiallyPresentGroupsCannotSilentlyDiscardMembers(string scenario)
    {
        var document = TwoItems();
        var group = Group("GET", Item);
        if (scenario == "missing")
            document.Paths.Remove(Solutions + Item);
        else
        {
            var path = scenario == "suppressed" ? "/solutions" : "/solutions/bookingBusinesses/$unsupported";
            document.Paths.Remove(Solutions + Item);
            Add(document, "GET", path, Get(document));
            group = group with { Routes = [group.Routes[0], group.Routes[1] with { Path = path }] };
        }

        var ex = await Assert.ThrowsAsync<InvalidOperationException>(() => Generate(document, [group]));

        Assert.Contains("incomplete", ex.Message);
    }

    [Theory]
    [InlineData("response")]
    [InlineData("query")]
    [InlineData("header")]
    [InlineData("required-query")]
    [InlineData("query-type")]
    public async Task IncompatibleOperationShapesAreRejected(string difference)
    {
        var document = TwoItems();
        var right = document.Paths[Solutions + Item].Operations![HttpMethod.Get];
        switch (difference)
        {
            case "response":
                document.Components!.Schemas!["microsoft.graph.otherBusiness"] = new OpenApiSchema { Type = JsonSchemaType.Object };
                right.Responses = JsonResponse(new OpenApiSchemaReference("microsoft.graph.otherBusiness", document));
                break;
            case "query":
                right.Parameters = Queries("$select").ToList();
                break;
            case "header":
                right.Parameters = [Header("If-Match")];
                break;
            default:
                var left = document.Paths[Legacy + Item].Operations![HttpMethod.Get];
                left.Parameters = Queries("$select").ToList();
                right.Parameters = Queries("$select").ToList();
                if (difference == "required-query")
                    ((OpenApiParameter)right.Parameters[0]).Required = true;
                else
                    ((OpenApiParameter)right.Parameters[0]).Schema = new OpenApiSchema { Type = JsonSchemaType.Integer };
                break;
        }

        var ex = await Assert.ThrowsAsync<InvalidOperationException>(() => Generate(document, [Group("GET", Item)]));

        Assert.Contains("Incompatible multi-route", ex.Message);
    }

    [Fact]
    public async Task GetRoutesRejectUnexpectedRequestBody()
    {
        var document = TwoItems();
        document.Paths[Solutions + Item].Operations![HttpMethod.Get].RequestBody = JsonBody(Reference(document));

        var ex = await Assert.ThrowsAsync<InvalidOperationException>(() => Generate(document, [Group("GET", Item)]));

        Assert.Contains("Unsupported multi-route operation shape", ex.Message);
        Assert.Contains("GET " + Solutions + Item, ex.Message);
    }

    [Theory]
    [InlineData("AccessToken")]
    [InlineData("Headers")]
    [InlineData("BookingBusinessId")]
    [InlineData("Property")]
    [InlineData("IfMatch")]
    public async Task SelectorCannotShadowAnExistingPublicParameter(string selector)
    {
        var document = TwoItems();
        foreach (var root in new[] { Legacy, Solutions })
            document.Paths[root + Item].Operations![HttpMethod.Get].Parameters = [Header("If-Match"), .. Queries("$select")];

        var ex = await Assert.ThrowsAsync<InvalidOperationException>(() =>
            Generate(document, [Group("GET", Item) with { SelectorParameter = selector }]));

        Assert.Contains(selector, ex.Message);
        Assert.Contains("multi-route selector", ex.Message, StringComparison.OrdinalIgnoreCase);
    }

    [Theory]
    [InlineData("AccessToken")]
    [InlineData("Headers")]
    [InlineData("WhatIf")]
    [InlineData("Confirm")]
    [InlineData("Verbose")]
    [InlineData("Debug")]
    [InlineData("ErrorAction")]
    [InlineData("PipelineVariable")]
    [InlineData("class")]
    [InlineData("namespace")]
    [InlineData("route")]
    public async Task ReservedOrLowercaseSelectorsAreRejectedBeforeEmission(string selector)
    {
        var ex = await Assert.ThrowsAsync<InvalidOperationException>(() =>
            Generate(TwoItems(), [Group("GET", Item) with { SelectorParameter = selector }]));

        Assert.Contains($"Invalid multi-route selector parameter '{selector}'", ex.Message);
    }

    [Theory]
    [InlineData("HEAD")]
    [InlineData("OPTIONS")]
    [InlineData("TRACE")]
    [InlineData("CONNECT")]
    [InlineData("")]
    public async Task RouteMembersRequireAnEmittableHttpMethod(string method)
    {
        var group = Group("GET", Item);
        group = group with { Routes = [group.Routes[0] with { Method = method }, group.Routes[1]] };

        var ex = await Assert.ThrowsAsync<InvalidOperationException>(() => Generate(TwoItems(), [group]));

        Assert.Contains("Invalid exact multi-route member", ex.Message);
    }

    [Fact]
    public async Task RouteLabelsCannotDifferOnlyByCase()
    {
        var group = Group("GET", Item);
        group = group with
        {
            Routes = [.. group.Routes, new MultiRoute("GET", "/widgets", "legacy")],
        };

        var ex = await Assert.ThrowsAsync<InvalidOperationException>(() => Generate(TwoItems(), [group]));

        Assert.Contains("labels differ only by case", ex.Message);
    }

    [Fact]
    public async Task ExactRouteMatchingTreatsMethodAndPathCaseInsensitively()
    {
        var group = Group("GET", Item);
        group = group with
        {
            Routes = group.Routes.Select(r => r with
            {
                Method = r.Method.ToLowerInvariant(), Path = r.Path.ToUpperInvariant(),
            }).ToArray(),
        };

        var files = await Generate(TwoItems(), [group]);

        Assert.Equal(3, files.Count);
        Assert.Contains("client.BookingBusinesses[BookingBusinessId]", files["GetMgBookingBusiness_Route0.g.cs"]);
        Assert.Contains("client.Solutions.BookingBusinesses[BookingBusinessId]", files["GetMgBookingBusiness_Route1.g.cs"]);
    }

    [Fact]
    public async Task ExpandedBodyPropertyDoesNotAcquireTheQuerySelectAlias()
    {
        var document = Document();
        var entity = (OpenApiSchema)document.Components!.Schemas!["microsoft.graph.bookingBusiness"];
        entity.Properties!["property"] = new OpenApiSchema { Type = JsonSchemaType.String };
        foreach (var root in new[] { Legacy, Solutions })
            Add(document, "POST", root, Mutation(document, body: true));

        var files = await Generate(document, [Group("POST", "")]);

        foreach (var source in files.Values)
        {
            Assert.Contains("public string? Property", source);
            Assert.DoesNotContain("[Alias(\"Select\")]", source);
        }
        Assert.Contains("body.Property = Property", files["NewMgBookingBusiness_Route0.g.cs"]);
        Assert.Contains("body.Property = Property", files["NewMgBookingBusiness_Route1.g.cs"]);
    }

    [Fact]
    public async Task IdenticalPathIdsRequireAnExplicitSelector()
    {
        var ex = await Assert.ThrowsAsync<InvalidOperationException>(() =>
            Generate(TwoItems(), [Group("GET", Item) with { SelectorParameter = null }]));

        Assert.Contains("identical path parameters require an explicit selector", ex.Message);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(2)]
    public async Task ThreeWayNoSelectorGroupsRejectAmbiguousIdsRegardlessOfBaseline(int firstRoute)
    {
        var document = Document();
        var routes = new[]
        {
            new MultiRoute("GET", "/widgets", "Root"),
            new MultiRoute("GET", "/widgets/{parent-id}/widgets", "Parent"),
            new MultiRoute("GET", "/solutions/widgets/{parent-id}/widgets", "SolutionsParent"),
        };
        foreach (var route in routes)
            Add(document, "GET", route.Path, Get(document, list: true));
        var ordered = routes.Skip(firstRoute).Concat(routes.Take(firstRoute)).ToArray();

        var ex = await Assert.ThrowsAsync<InvalidOperationException>(() =>
            Generate(document, [new MultiRouteGroup("v1.0", ordered, "Root")]));

        Assert.Contains("identical path parameters require an explicit selector", ex.Message);
    }

    [Fact]
    public async Task NoSelectorRejectsIdenticalIdsAcrossItemAndChildListShapes()
    {
        var document = Document();
        const string itemPath = "/widgets/{widget-id}";
        const string childrenPath = "/widgets/{widget-id}/widgets";
        Add(document, "GET", itemPath, Get(document));
        Add(document, "GET", childrenPath, Get(document, list: true));
        var group = new MultiRouteGroup("v1.0",
        [
            new MultiRoute("GET", itemPath, "Item"),
            new MultiRoute("GET", childrenPath, "Children"),
        ], "Children");

        var ex = await Assert.ThrowsAsync<InvalidOperationException>(() => Generate(document, [group]));

        Assert.Contains("identical path parameters require an explicit selector", ex.Message);
    }

    [Theory]
    [InlineData("Nested")]
    [InlineData("Root")]
    public async Task NoSelectorDefaultCannotShadowARouteWithFewerRequiredIds(string defaultRoute)
    {
        var document = Document();
        const string rootPath = "/widgets";
        const string nestedPath = "/widgets/{parent-id}/widgets";
        Add(document, "GET", rootPath, Get(document, list: true));
        Add(document, "GET", nestedPath, Get(document, list: true));
        var group = new MultiRouteGroup("v1.0",
        [
            new MultiRoute("GET", rootPath, "Root"),
            new MultiRoute("GET", nestedPath, "Nested"),
        ], defaultRoute);

        if (defaultRoute == "Nested")
        {
            var ex = await Assert.ThrowsAsync<InvalidOperationException>(() => Generate(document, [group]));

            Assert.Contains("default parameter set shadows a route", ex.Message);
            return;
        }

        var files = await Generate(document, [group]);

        Assert.Equal(3, files.Count);
        var source = files["GetMgWidget.g.cs"];
        Assert.Contains("DefaultParameterSetName = \"RootList\"", source);
        Assert.Contains("[Parameter(Mandatory = true, ParameterSetName = \"NestedList\", Position = 0)]", source);
        Assert.DoesNotContain("Mandatory = true, ParameterSetName = \"RootList\"", source);
        Assert.Contains("(\"\", \"RootList\") => \"Get-MgWidget_Route0\"", source);
        Assert.Contains("(\"\", \"NestedList\") => \"Get-MgWidget_Route1\"", source);
        Assert.Contains("client.Widgets.GetAsync(", files["GetMgWidget_Route0.g.cs"]);
        Assert.Contains("client.Widgets[ParentId].Widgets.GetAsync(", files["GetMgWidget_Route1.g.cs"]);
    }

    [Fact]
    public async Task SelectedFamiliesMustHaveMatchingListAndItemShapes()
    {
        var document = TwoItems();
        Add(document, "GET", Legacy, Get(document, list: true));
        var group = Group("GET", Item) with
        {
            Routes = [new MultiRoute("GET", Legacy, "Legacy"), .. Group("GET", Item).Routes],
        };

        var ex = await Assert.ThrowsAsync<InvalidOperationException>(() => Generate(document, [group]));

        Assert.Contains("same operation shapes", ex.Message);
    }

    [Fact]
    public async Task DifferentPublicCommandsCannotBeMerged()
    {
        var document = TwoItems();
        document.Paths.Remove(Solutions + Item);
        const string other = "/widgets/{bookingBusiness-id}";
        Add(document, "GET", other, Get(document));
        var group = Group("GET", Item);
        group = group with { Routes = [group.Routes[0], group.Routes[1] with { Path = other }] };

        var ex = await Assert.ThrowsAsync<InvalidOperationException>(() => Generate(document, [group]));

        Assert.Contains("same public command", ex.Message);
    }

    [Theory]
    [InlineData("v1.0")]
    [InlineData("beta")]
    public void BookingsSolutionPrefixUsesExistingSharedNamingRule(string apiVersion)
    {
        var config = new GeneratorConfig(Client, ".", ApiVersion: apiVersion, UseCollisionData: false);
        var legacy = Naming.Resolve(new OperationInfo(HttpMethod.Get, Legacy + Item), config);
        var solutions = Naming.Resolve(new OperationInfo(HttpMethod.Get, Solutions + Item), config);

        Assert.Equal("MgBookingBusiness", legacy.Noun);
        Assert.Equal(legacy.Noun, solutions.Noun);
        Assert.Equal("BookingBusinesses[BookingBusinessId]", legacy.BuilderExpression);
        Assert.Equal("Solutions.BookingBusinesses[BookingBusinessId]", solutions.BuilderExpression);
    }

    [Theory]
    [InlineData("property-type")]
    [InlineData("required-property")]
    [InlineData("missing-property")]
    public async Task ExpandedActionBodiesMustHaveCompatibleShapes(string difference)
    {
        var document = Document();
        const string suffix = Item + "/publish";
        foreach (var root in new[] { Legacy, Solutions })
        {
            var body = new OpenApiSchema
            {
                Type = JsonSchemaType.Object,
                Properties = new Dictionary<string, IOpenApiSchema>
                {
                    ["notify"] = new OpenApiSchema { Type = JsonSchemaType.Boolean },
                },
            };
            if (root == Solutions)
            {
                if (difference == "property-type")
                    body.Properties["notify"] = new OpenApiSchema { Type = JsonSchemaType.String };
                else if (difference == "required-property")
                    body.Required = new HashSet<string> { "notify" };
                else
                    body.Properties.Clear();
            }
            var operation = Mutation(document, body: false);
            operation.RequestBody = JsonBody(body);
            operation.Extensions = new Dictionary<string, IOpenApiExtension>
            {
                ["x-ms-docs-operation-type"] = new JsonNodeExtension("action"),
            };
            Add(document, "POST", root + suffix, operation);
        }

        var ex = await Assert.ThrowsAsync<InvalidOperationException>(() =>
            Generate(document, [Group("POST", suffix)]));

        Assert.Contains("Incompatible multi-route", ex.Message);
    }

    [Fact]
    public async Task SelectorCannotShadowAnExpandedBodyProperty()
    {
        var document = Document();
        foreach (var root in new[] { Legacy, Solutions })
            Add(document, "POST", root, Mutation(document, body: true));

        var ex = await Assert.ThrowsAsync<InvalidOperationException>(() =>
            Generate(document, [Group("POST", "") with { SelectorParameter = "DisplayName" }]));

        Assert.Contains("conflicts with an existing parameter", ex.Message);
    }

    [Fact]
    public async Task SelectorRequiresTheSameActualPublicPathParameters()
    {
        var document = TwoItems();
        document.Paths.Remove(Solutions + Item);
        const string path = Solutions + "/{different-id}";
        Add(document, "GET", path, Get(document));
        var group = Group("GET", Item);
        group = group with { Routes = [group.Routes[0], group.Routes[1] with { Path = path }] };

        var ex = await Assert.ThrowsAsync<InvalidOperationException>(() => Generate(document, [group]));

        Assert.Contains("identical public parameters", ex.Message);
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public async Task PatchWorkerRefetchesOnlyWhenItsOwnPathHasGet(bool includeGet)
    {
        var document = Document();
        foreach (var root in new[] { Legacy, Solutions })
        {
            Add(document, "PATCH", root + Item, Mutation(document, body: true));
            if (includeGet)
                Add(document, "GET", root + Item, Get(document));
        }
        var groups = includeGet
            ? new[] { Group("PATCH", Item), Group("GET", Item) }
            : new[] { Group("PATCH", Item) };

        var files = await Generate(document, groups);

        foreach (var worker in files.Where(p => p.Key.StartsWith("UpdateMgBookingBusiness_Route", StringComparison.Ordinal)).Select(p => p.Value))
            Assert.Equal(includeGet, worker.Contains("re-fetching the updated resource", StringComparison.Ordinal));
    }

    [Fact]
    public async Task DuplicateOperationShapesWithinOneFamilyAreRejected()
    {
        var document = Document();
        var routes = new[]
        {
            new MultiRoute("GET", "/widgets", "Root"),
            new MultiRoute("GET", "/widgets/{parent-id}/widgets", "Root"),
            new MultiRoute("GET", "/widgets/{other-id}/widgets", "Other"),
        };
        foreach (var route in routes)
            Add(document, "GET", route.Path, Get(document, list: true));

        var ex = await Assert.ThrowsAsync<InvalidOperationException>(() =>
            Generate(document, [new MultiRouteGroup("v1.0", routes, "Root")]));

        Assert.Contains("not an unambiguous list/item pair", ex.Message);
    }

    [Fact]
    public async Task SameNounDoesNotMakeUnrelatedListAndItemRoutesAPair()
    {
        var document = Document();
        var routes = new[]
        {
            new MultiRoute("GET", "/widgets/{parent-id}/widgets", "Parent"),
            new MultiRoute("GET", "/widgets/{different-id}/widgets/{widget-id}", "Parent"),
            new MultiRoute("GET", "/widgets", "Root"),
            new MultiRoute("GET", "/widgets/{widget-id}", "Root"),
        };
        for (var i = 0; i < routes.Length; i++)
            Add(document, "GET", routes[i].Path, Get(document, list: i % 2 == 0));

        var ex = await Assert.ThrowsAsync<InvalidOperationException>(() =>
            Generate(document, [new MultiRouteGroup("v1.0", routes, "Root")]));

        Assert.Contains("not an unambiguous list/item pair", ex.Message);
    }

    [Theory]
    [InlineData("query")]
    [InlineData("non-json-body")]
    [InlineData("binary-response")]
    public async Task UnsupportedMutationShapesFailRatherThanEmitPartialDispatchers(string shape)
    {
        var document = Document();
        foreach (var root in new[] { Legacy, Solutions })
        {
            var operation = Mutation(document, body: true);
            if (shape == "query")
                operation.Parameters = Queries("$filter").ToList();
            else if (shape == "non-json-body")
                operation.RequestBody = new OpenApiRequestBody
                {
                    Content = new Dictionary<string, IOpenApiMediaType>
                    {
                        ["application/octet-stream"] = new OpenApiMediaType
                        {
                            Schema = new OpenApiSchema { Type = JsonSchemaType.String, Format = "binary" },
                        },
                    },
                };
            else
                operation.Responses!["200"].Content!["application/octet-stream"] =
                    new OpenApiMediaType { Schema = new OpenApiSchema { Type = JsonSchemaType.String, Format = "binary" } };
            Add(document, "POST", root, operation);
        }

        var ex = await Assert.ThrowsAsync<InvalidOperationException>(() =>
            Generate(document, [Group("POST", "")]));

        Assert.Contains("Unsupported multi-route operation shape", ex.Message);
    }

    private static void AssertForwarding(string source, string? selector = null)
    {
        Assert.Contains("new Dictionary<string, object>(MyInvocation.BoundParameters)", source);
        Assert.Contains("& $CmdletName @BoundParameters", source);
        Assert.Contains("PipelineResultTypes.Output | PipelineResultTypes.Error", source);
        Assert.Contains("parameters, internalCmdletName", source);
        if (selector is not null)
            Assert.Contains($"parameters.Remove(\"{selector}\")", source);
        else
            Assert.DoesNotContain("parameters.Remove(", source);
    }

    private static void AssertCatchFilters(string source, bool dispatcher = false)
    {
        Assert.Contains("catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)", source);
        if (dispatcher)
        {
            Assert.Contains("catch (RuntimeException rex) when (rex is not PipelineStoppedException && rex.ErrorRecord is not null)", source);
            Assert.Contains("ThrowTerminatingError(rex.ErrorRecord)", source);
        }
    }

    private static (OpenApiDocument Document, MultiRouteGroup Group) CalendarViewFixture()
    {
        var document = Document();
        var routes = new List<MultiRoute>();
        foreach (var (root, name) in new[] { (Legacy, "Legacy"), (Solutions, "Solutions") })
        {
            for (var i = 0; i < 2; i++)
            {
                var path = root + Item + "/calendarView" + (i == 0 ? "" : "/{bookingAppointment-id}");
                var operation = Get(document, list: i == 0);
                operation.Parameters =
                [
                    new OpenApiParameter
                    {
                        Name = "start", In = ParameterLocation.Query, Required = true,
                        Schema = new OpenApiSchema { Type = JsonSchemaType.String },
                    },
                    new OpenApiParameter
                    {
                        Name = "end", In = ParameterLocation.Query, Required = true,
                        Schema = new OpenApiSchema { Type = JsonSchemaType.String },
                    },
                    .. Queries("$select", "$expand"),
                ];
                Add(document, "GET", path, operation);
                routes.Add(new MultiRoute("GET", path, name));
            }
        }
        return (document, new MultiRouteGroup("v1.0", routes, "Legacy", "Route"));
    }

    private static OpenApiDocument Document() => new()
    {
        Paths = new OpenApiPaths(),
        Components = new OpenApiComponents
        {
            Schemas = new Dictionary<string, IOpenApiSchema>
            {
                ["microsoft.graph.bookingBusiness"] = new OpenApiSchema
                {
                    Type = JsonSchemaType.Object,
                    Properties = new Dictionary<string, IOpenApiSchema>
                    {
                        ["displayName"] = new OpenApiSchema { Type = JsonSchemaType.String },
                    },
                },
            },
        },
    };

    private static OpenApiDocument TwoItems()
    {
        var document = Document();
        foreach (var root in new[] { Legacy, Solutions })
            Add(document, "GET", root + Item, Get(document));
        return document;
    }

    private static MultiRouteGroup Group(string method, string suffix, bool includeItem = false) => new(
        "v1.0",
        new[] { (Legacy, "Legacy"), (Solutions, "Solutions") }
            .SelectMany(root => includeItem
                ? new[] { new MultiRoute(method, root.Item1, root.Item2), new MultiRoute(method, root.Item1 + Item, root.Item2) }
                : new[] { new MultiRoute(method, root.Item1 + suffix, root.Item2) }).ToArray(),
        "Legacy", "Route");

    private static IOpenApiSchema Reference(OpenApiDocument document) =>
        new OpenApiSchemaReference("microsoft.graph.bookingBusiness", document);

    private static OpenApiOperation Get(OpenApiDocument document, bool list = false) => new()
    {
        Responses = JsonResponse(list ? new OpenApiSchema
        {
            Type = JsonSchemaType.Object,
            Properties = new Dictionary<string, IOpenApiSchema>
            {
                ["value"] = new OpenApiSchema { Type = JsonSchemaType.Array, Items = Reference(document) },
            },
        } : Reference(document)),
    };

    private static OpenApiOperation Count() => new()
    {
        Responses = new OpenApiResponses
        {
            ["200"] = new OpenApiResponse
            {
                Content = new Dictionary<string, IOpenApiMediaType>
                {
                    ["text/plain"] = new OpenApiMediaType
                    {
                        Schema = new OpenApiSchema { Type = JsonSchemaType.Integer, Format = "int32" },
                    },
                },
            },
        },
    };

    private static OpenApiOperation Mutation(OpenApiDocument document, bool body) => new()
    {
        RequestBody = body ? JsonBody(Reference(document)) : null,
        Responses = body ? JsonResponse(Reference(document)) : new OpenApiResponses { ["204"] = new OpenApiResponse() },
    };

    private static OpenApiRequestBody JsonBody(IOpenApiSchema schema) => new()
    {
        Content = new Dictionary<string, IOpenApiMediaType>
        {
            ["application/json"] = new OpenApiMediaType { Schema = schema },
        },
    };

    private static OpenApiResponses JsonResponse(IOpenApiSchema schema) => new()
    {
        ["200"] = new OpenApiResponse
        {
            Content = new Dictionary<string, IOpenApiMediaType>
            {
                ["application/json"] = new OpenApiMediaType { Schema = schema },
            },
        },
    };

    private static OpenApiParameter Header(string name) => new()
    {
        Name = name, In = ParameterLocation.Header, Schema = new OpenApiSchema { Type = JsonSchemaType.String },
    };

    private static IEnumerable<IOpenApiParameter> Queries(params string[] names) => names.Select(name => new OpenApiParameter
    {
        Name = name,
        In = ParameterLocation.Query,
        Schema = new OpenApiSchema
        {
            Type = name is "$top" or "$skip" ? JsonSchemaType.Integer : name == "$count" ? JsonSchemaType.Boolean : JsonSchemaType.String,
        },
    });

    private static void Add(OpenApiDocument document, string method, string path, OpenApiOperation operation)
    {
        if (!document.Paths.TryGetValue(path, out var item))
            document.Paths[path] = item = new OpenApiPathItem { Operations = new Dictionary<HttpMethod, OpenApiOperation>() };
        item.Operations![new HttpMethod(method)] = operation;
    }

    private static async Task<Dictionary<string, string>> Generate(
        OpenApiDocument document, IReadOnlyList<MultiRouteGroup>? groups = null, bool useCollisionData = false)
    {
        var output = Path.Combine(Directory.GetCurrentDirectory(), ".multi-route-tests-" + Guid.NewGuid().ToString("N"));
        try
        {
            document.RegisterComponents();
            var config = new GeneratorConfig(Client, output, UseCollisionData: useCollisionData, MultiRouteGroups: groups);
            await new PowerShellWrapperGenerationService(document, config, NullLogger.Instance)
                .GenerateAsync(CancellationToken.None);
            return Directory.GetFiles(output, "*.g.cs").ToDictionary(path => Path.GetFileName(path), File.ReadAllText);
        }
        finally
        {
            if (Directory.Exists(output))
                Directory.Delete(output, recursive: true);
        }
    }
}
