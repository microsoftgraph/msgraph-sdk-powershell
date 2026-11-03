using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.OpenApi;
using WrapperGenerator;
using Xunit;
using static WrapperGenerator.CmdletConfigurator;

namespace WrapperGenerator.Tests;

public sealed class MultiRouteTests
{
    private const string Client = "Microsoft.Graph.PowerShell.Test.Client";
    private const string Entity = Client + ".Models.OnPremisesAgentGroup";
    private const string Root = "/onPremisesPublishingProfiles/{onPremisesPublishingProfile-id}/agentGroups";
    private const string Item = Root + "/{onPremisesAgentGroup-id}";
    private const string Agent = "/onPremisesPublishingProfiles/{onPremisesPublishingProfile-id}/agents/{onPremisesAgent-id}/agentGroups";
    private const string WidgetRoot = "/widgets";
    private const string WidgetParent = "/widgets/{parent-id}/widgets";

    [Fact]
    public async Task ActualApplicationsFiveGetPathsEmitTwoPublicCommandsAndFiveOrderedWorkers()
    {
        var (document, groups) = Applications();

        var files = await Generate(document, groups, apiVersion: "beta");

        Assert.Equal(7, files.Count);
        foreach (var group in groups)
        {
            var naming = Resolve(group.Routes[0].Path);
            var source = files[FileStem(naming) + ".g.cs"];
            Assert.Contains("DefaultParameterSetName = \"Root" + (group == groups[0] ? "List" : "Scalar") + "\"", source);
            AssertForwarding(source);
            AssertCatchFilters(source, dispatcher: true);
            Assert.DoesNotContain("public string Route", source);
            Assert.DoesNotContain("ValidateSet(", source);
            Assert.DoesNotContain("BodyParameter", source);
            Assert.DoesNotContain("SupportsShouldProcess", source);
            for (var i = 0; i < group.Routes.Count; i++)
            {
                var route = group.Routes[i];
                var shape = route.Path.EndsWith("/$count", StringComparison.Ordinal) ? "Scalar"
                    : route.Path == Item ? "Get" : "List";
                var set = route.FamilyName + shape;
                var worker = files[$"{FileStem(naming)}_Route{i}.g.cs"];
                Assert.Contains($"[GraphRoute(\"GET\", \"{route.Path}\", ParameterSetName = \"{set}\")]", source);
                Assert.Contains($"\"Get-{naming.Noun}_Route{i}\"", source);
                Assert.Contains($"[GraphRoute(\"GET\", \"{route.Path}\")]", worker);
                Assert.Contains(".GetAsync(", worker);
                Assert.DoesNotContain("InvokeCommand.InvokeScript", worker);
                AssertCatchFilters(worker);
                var output = shape == "Scalar" ? "int" : Entity;
                Assert.Contains($"[OutputType(typeof({output}), ParameterSetName = new[] {{ \"{set}\" }})]", source);
                Assert.Contains($"[OutputType(typeof({output}))]", worker);
            }
        }
        var entitySource = files[FileStem(Resolve(Root)) + ".g.cs"];
        foreach (var set in new[] { "RootList", "RootGet", "AgentList" })
            AssertMandatory(entitySource, "OnPremisesPublishingProfileId", set);
        AssertMandatory(entitySource, "OnPremisesAgentGroupId", "RootGet");
        AssertMandatory(entitySource, "OnPremisesAgentId", "AgentList");
        Assert.Contains("client.OnPremisesPublishingProfiles[OnPremisesPublishingProfileId].AgentGroups.GetAsync(",
            files[FileStem(Resolve(Root)) + "_Route0.g.cs"]);
        Assert.Contains(".AgentGroups[OnPremisesAgentGroupId].GetAsync(",
            files[FileStem(Resolve(Root)) + "_Route1.g.cs"]);
        Assert.Contains(".Agents[OnPremisesAgentId].AgentGroups.GetAsync(",
            files[FileStem(Resolve(Root)) + "_Route2.g.cs"]);
    }

    [Fact]
    public async Task ExistingODataArraysAliasesHeadersAndPaginationArePreservedPerShape()
    {
        var (document, groups) = Applications();
        foreach (var route in groups.SelectMany(g => g.Routes))
        {
            var query = route.Path.EndsWith("/$count", StringComparison.Ordinal)
                ? new[] { "$filter", "$search" }
                : route.Path == Item ? new[] { "$select", "$expand" }
                : new[] { "$select", "$expand", "$filter", "$search", "$orderby", "$top", "$skip", "$count" };
            Operation(document, route.Path).Parameters = [Header("ConsistencyLevel"), .. Queries(query)];
        }

        var files = await Generate(document, groups, apiVersion: "beta");
        var source = files[FileStem(Resolve(Root)) + ".g.cs"];

        foreach (var declaration in new[]
        {
            "string[]? Property", "string[]? ExpandProperty", "string? Filter", "string? Search",
            "string[]? Sort", "int Top", "int Skip", "SwitchParameter Count", "SwitchParameter All",
            "string? ConsistencyLevel",
        })
            Assert.Contains("public " + declaration, source);
        foreach (var alias in new[] { "Select", "Expand", "OrderBy" })
            Assert.Contains($"[Alias(\"{alias}\")]", source);
        Assert.DoesNotContain("public string? AccessToken", source);
        AssertForwarding(source);
        var listWorker = files[FileStem(Resolve(Root)) + "_Route0.g.cs"];
        foreach (var property in new[] { "Select", "Expand", "Filter", "Search", "Orderby", "Top", "Skip", "Count" })
            Assert.Contains("requestConfiguration.QueryParameters." + property, listWorker);
        Assert.Contains("requestConfiguration.Headers.Add(\"ConsistencyLevel\", ConsistencyLevel!)", listWorker);
        Assert.Contains("AddRequestHeaders(requestConfiguration.Headers)", listWorker);
        Assert.Contains("All.IsPresent", listWorker);
        Assert.Contains("WithUrl", listWorker);
        var itemWorker = files[FileStem(Resolve(Root)) + "_Route1.g.cs"];
        Assert.DoesNotContain("public SwitchParameter All", itemWorker);
        Assert.DoesNotContain("public int Top", itemWorker);
        var countWorker = files[FileStem(Resolve(Root + "/$count")) + "_Route1.g.cs"];
        Assert.Contains("QueryParameters.Filter", countWorker);
        Assert.Contains("QueryParameters.Search", countWorker);
        Assert.DoesNotContain("public SwitchParameter All", countWorker);
    }

    [Fact]
    public async Task RepeatedResourceNamesSupportFourNaturalListAndItemSetsWithoutInventingIds()
    {
        var document = Document();
        var routes = new[]
        {
            new OperationVariant("GET", WidgetRoot, "Root"),
            new OperationVariant("GET", WidgetRoot + "/{widget-id}", "Root"),
            new OperationVariant("GET", WidgetParent, "Parent"),
            new OperationVariant("GET", WidgetParent + "/{widget-id}", "Parent"),
        };
        for (var i = 0; i < routes.Length; i++)
            Add(document, "GET", routes[i].Path, Get(document, list: i % 2 == 0));

        var files = await Generate(document, [new(routes, "Root")]);

        Assert.Equal(5, files.Count);
        var source = files["GetMgWidget.g.cs"];
        Assert.Contains("DefaultParameterSetName = \"RootList\"", source);
        foreach (var set in new[] { "RootList", "RootGet", "ParentList", "ParentGet" })
            Assert.Contains($"ParameterSetName = \"{set}\"", source);
        AssertMandatory(source, "ParentId", "ParentList");
        AssertMandatory(source, "ParentId", "ParentGet");
        AssertMandatory(source, "WidgetId", "RootGet");
        AssertMandatory(source, "WidgetId", "ParentGet");
        Assert.DoesNotContain("WidgetId1", source);
        Assert.DoesNotContain("public string Route", source);
        Assert.Contains("client.Widgets[ParentId].Widgets[WidgetId].GetAsync(", files["GetMgWidget_Route3.g.cs"]);
    }

    [Fact]
    public async Task RootFamilyWithOnlyAnItemUsesItsGetSetAsDefault()
    {
        var document = Document();
        var routes = new[]
        {
            new OperationVariant("GET", WidgetRoot + "/{widget-id}", "Root"),
            new OperationVariant("GET", WidgetParent + "/{widget-id}", "Parent"),
        };
        foreach (var route in routes)
            Add(document, "GET", route.Path, Get(document));

        var files = await Generate(document, [new(routes, "Root")]);

        Assert.Equal(3, files.Count);
        Assert.Contains("DefaultParameterSetName = \"RootGet\"", files["GetMgWidget.g.cs"]);
        AssertMandatory(files["GetMgWidget.g.cs"], "WidgetId", "RootGet");
        AssertMandatory(files["GetMgWidget.g.cs"], "ParentId", "ParentGet");
    }

    [Fact]
    public async Task CountGroupsKeepScalarWorkersAndRootScalarDefault()
    {
        var document = Document();
        var routes = new[]
        {
            new OperationVariant("GET", WidgetRoot + "/$count", "Root"),
            new OperationVariant("GET", WidgetParent + "/$count", "Parent"),
        };
        foreach (var route in routes)
            Add(document, "GET", route.Path, Count());

        var files = await Generate(document, [new(routes, "Root")]);

        Assert.Equal(3, files.Count);
        var source = files["GetMgWidgetCount.g.cs"];
        Assert.Contains("DefaultParameterSetName = \"RootScalar\"", source);
        Assert.Contains("ParameterSetName = \"ParentScalar\"", source);
        Assert.DoesNotContain("public SwitchParameter All", source);
        Assert.DoesNotContain("BodyParameter", source);
        AssertMandatory(source, "ParentId", "ParentScalar");
    }

    [Fact]
    public async Task OrdinaryListAndItemPairRetainsItsOriginalDispatcherAndTypedWorkers()
    {
        var document = Document();
        Add(document, "GET", WidgetRoot, Get(document, list: true));
        Add(document, "GET", WidgetRoot + "/{widget-id}", Get(document));

        var files = await Generate(document);

        Assert.Equal(3, files.Count);
        var source = files["GetMgWidget.g.cs"];
        Assert.Contains("DefaultParameterSetName = \"List\"", source);
        Assert.Contains("ParameterSetName = \"Get\"", source);
        Assert.Contains("public string WidgetId", source);
        Assert.Contains("client.Widgets.GetAsync(", files["GetMgWidget_List.g.cs"]);
        Assert.Contains("client.Widgets[WidgetId].GetAsync(", files["GetMgWidget_Get.g.cs"]);
        Assert.DoesNotContain("_Route", source);
        Assert.Contains("InvokeCommand.InvokeScript", source);
    }

    [Fact]
    public async Task OrdinarySingleRouteKeepsItsTypedEmitter()
    {
        var document = Document();
        Add(document, "GET", WidgetRoot + "/{widget-id}", Get(document));

        var files = await Generate(document);

        Assert.Single(files);
        var source = files["GetMgWidget.g.cs"];
        Assert.Contains("[OutputType(typeof(" + Entity + "))]", source);
        Assert.Contains("client.Widgets[WidgetId].GetAsync(", source);
        Assert.DoesNotContain("_Route", source);
        Assert.DoesNotContain("InvokeCommand.InvokeScript", source);
        AssertCatchFilters(source);
    }

    [Fact]
    public async Task UnoptedCollisionStillFailsInsteadOfSilentlyChoosingARoute()
    {
        var (document, _) = Widgets();

        var ex = await Assert.ThrowsAsync<InvalidOperationException>(() => Generate(document, useCollisionData: true));

        Assert.Contains("collision", ex.Message, StringComparison.OrdinalIgnoreCase);
        Assert.Contains("GetMgWidget.g.cs", ex.Message);
        Assert.Contains("/widgets", ex.Message);
    }

    [Theory]
    [InlineData("v1.0")]
    [InlineData("beta")]
    public async Task SameVariantConfigurationAppliesToEitherIngestingProfile(string apiVersion)
    {
        var (document, group) = Widgets();

        var files = await Generate(document, [group], apiVersion, useCollisionData: true);

        Assert.Equal(3, files.Count);
        Assert.Contains("RootList", files["GetMgWidget.g.cs"]);
        Assert.Contains("ParentList", files["GetMgWidget.g.cs"]);
    }

    [Fact]
    public async Task SharedVariantsEmitIdenticalSourcesWhenOnlyTheRunProfileChanges()
    {
        var (document, group) = Widgets();

        var v1 = await Generate(document, [group], apiVersion: "v1.0");
        var beta = await Generate(document, [group], apiVersion: "beta");

        Assert.Equal(v1.Keys.Order(), beta.Keys.Order());
        foreach (var file in v1)
            Assert.Equal(file.Value, beta[file.Key]);
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public async Task SharedConfigurationDoesNotMixTheGenerationRunsDerivedOracleData(bool cli)
    {
        var (document, group) = Widgets();
        Add(document, "GET", "/groupSettings", Get(document, list: true));
        document.RegisterComponents();
        var output = OutputPath();
        var shared = new GeneratorConfig(Client, output, UseCollisionData: true);
        Entry[] entries = [GroupVariants(group, "Shared fixture registration")];
        try
        {
            foreach (var profile in new[] { "v1.0", "beta", "v1.0" })
            {
                if (cli)
                    await WrapperGenerator.Program.GenerateAsync(document, shared, "fixture.yml",
                        NullLogger.Instance, CancellationToken.None, profile, entries);
                else
                    await new PowerShellWrapperGenerationService(document, shared, NullLogger.Instance, profile, entries)
                        .GenerateAsync(CancellationToken.None);

                Assert.True(File.Exists(Path.Combine(output, "GetMgWidget.g.cs")));
                // This path is oracle-suppressed in v1.0, but not beta; authored rules are shared.
                Assert.Equal(profile == "beta", File.Exists(Path.Combine(output, "GetMgGroupSetting.g.cs")));
            }
        }
        finally
        {
            if (Directory.Exists(output))
                Directory.Delete(output, recursive: true);
        }
    }

    [Fact]
    public async Task AbsentGroupsInAnotherModuleAreANoOp()
    {
        var document = Document();
        Add(document, "GET", "/otherResources/{otherResource-id}", Get(document));
        var (_, group) = Widgets();

        var files = await Generate(document, [group]);

        Assert.Single(files);
        Assert.Contains("GetMgOtherResource.g.cs", files.Keys);
    }

    [Fact]
    public void InternalModuleFactoryAndConfigurationHaveNoApiVersionParameters()
    {
        var (_, group) = Widgets();

        var entry = CmdletConfigurator.GroupVariants(group, "Reviewed natural path-ID sets");
        Entry[] entries = [entry];

        Assert.Equal(CmdletConfigurator.OverrideKind.GroupVariants, entry.Kind);
        Assert.Same(group, entry.VariantGroup);
        Assert.Equal("Reviewed natural path-ID sets", entry.Reason);
        Assert.Contains(group, CmdletConfigurator.GetOperationVariantGroups(entries));
        Assert.Single(CmdletConfigurator.GetOperationVariantGroups(entries), g => ReferenceEquals(g, group));
        Assert.Equal(3, typeof(OperationVariant).GetConstructors().Single(c => c.IsPublic).GetParameters().Length);
        Assert.Equal(2, typeof(OperationVariantGroup).GetConstructors().Single(c => c.IsPublic).GetParameters().Length);
        Assert.Equal(3, typeof(GeneratorConfig).GetConstructors().Single(c => c.IsPublic).GetParameters().Length);
        Assert.Null(typeof(OperationVariantGroup).GetProperty("ApiVersion"));
        Assert.Null(typeof(GeneratorConfig).GetProperty("ApiVersion"));
        Assert.Null(typeof(CmdletConfigurator.Entry).GetProperty("ApiVersion"));
        Assert.Null(typeof(GeneratorConfig).GetProperty("OperationVariantGroups"));
        Assert.Equal(typeof(CmdletConfigurator), typeof(OperationVariant).DeclaringType);
        Assert.Equal(typeof(CmdletConfigurator), typeof(OperationVariantGroup).DeclaringType);
        Assert.Single(typeof(PowerShellWrapperGenerationService).GetConstructors());
    }

    [Fact]
    public async Task IsolatedRegistrationsDoNotChangeTheDefaultModuleConfiguration()
    {
        var (document, group) = Widgets();
        var before = GetOperationVariantGroups().ToArray();

        Assert.Equal(3, (await Generate(document, [group])).Count);
        await Assert.ThrowsAsync<InvalidOperationException>(() => Generate(document, useCollisionData: true));
        Assert.Equal(3, (await Generate(document, [group])).Count);

        Assert.Equal(before, GetOperationVariantGroups());
    }

    [Fact]
    public void RegisteredVariantsDoNotOverrideCuratedOrDerivedNamingInEitherProfile()
    {
        var (_, group) = Widgets();
        foreach (var apiVersion in new[] { "v1.0", "beta" })
        {
            var plain = new GeneratorConfig(Client, ".", true);
            foreach (var path in new[]
            {
                Root, Agent,
                "/identityGovernance/entitlementManagement/catalogs/{accessPackageCatalog-id}/resourceRoles",
                "/solutions/backupRestore",
            })
            {
                var before = Naming.Resolve(new OperationInfo(HttpMethod.Get, path), plain, apiVersion);
                Entry[] entries = [GroupVariants(group, "Shared configuration")];
                Assert.Same(group, Assert.Single(GetOperationVariantGroups(entries)));
                var after = Naming.Resolve(new OperationInfo(HttpMethod.Get, path), plain, apiVersion);
                Assert.Equal(before.VerbName, after.VerbName);
                Assert.Equal(before.Noun, after.Noun);
                Assert.Equal(before.ClassName, after.ClassName);
                Assert.Equal(before.BuilderExpression, after.BuilderExpression);
                Assert.Equal(before.PathParamNames, after.PathParamNames);
                Assert.Equal(before.SourcePath, after.SourcePath);
            }
        }
    }

    [Theory]
    [InlineData("empty")]
    [InlineData("single")]
    [InlineData("missing-default")]
    [InlineData("invalid-label")]
    [InlineData("label-case")]
    [InlineData("duplicate-operation")]
    [InlineData("duplicate-group")]
    [InlineData("wildcard")]
    [InlineData("normalized-placeholder")]
    public async Task InvalidReviewedGroupConfigurationFailsBeforeTouchingExistingOutput(string scenario)
    {
        var (document, group) = Widgets();
        IReadOnlyList<OperationVariantGroup> groups = [scenario switch
        {
            "empty" => group with { Routes = [] },
            "single" => group with { Routes = [group.Routes[0]] },
            "missing-default" => group with { DefaultFamily = "Missing" },
            "invalid-label" => group with { Routes = [group.Routes[0], group.Routes[1] with { FamilyName = "not-a-label" }] },
            "label-case" => group with { Routes = [group.Routes[0], group.Routes[1] with { FamilyName = "rOoT" }] },
            "duplicate-operation" => group with { Routes = [group.Routes[0], group.Routes[0] with { FamilyName = "Other" }] },
            "wildcard" => group with { Routes = [group.Routes[0], group.Routes[1] with { Path = "/widgets/*/widgets" }] },
            "normalized-placeholder" => group with { Routes = [group.Routes[0], group.Routes[1] with { Path = "/widgets/{}/widgets" }] },
            _ => group,
        }];
        if (scenario == "duplicate-group")
            groups = [group, group];

        await RejectWithoutWrites(document, groups);
    }

    [Theory]
    [InlineData("missing")]
    [InlineData("filtered")]
    [InlineData("post-only")]
    [InlineData("suppressed")]
    public async Task IncompleteSelectedGroupsCannotBeLoggedAndSkipped(string scenario)
    {
        var (document, group) = Widgets();
        if (scenario == "filtered")
            IncludePathFilter.Apply(document, [WidgetRoot + "#GET"]);
        else if (scenario == "post-only")
        {
            foreach (var route in group.Routes)
                Add(document, "POST", route.Path, Get(document, list: true));
        }
        else
        {
            document.Paths.Remove(WidgetParent);
            if (scenario == "suppressed")
            {
                Add(document, "GET", "/solutions", Get(document, list: true));
                group = group with { Routes = [group.Routes[0], group.Routes[1] with { Path = "/solutions" }] };
                Assert.True(CmdletConfigurator.IsSuppressed(HttpMethod.Get, "/solutions"));
            }
        }

        await RejectWithoutWrites(document, [group]);
    }

    [Theory]
    [InlineData("post")]
    [InlineData("delete")]
    [InlineData("action")]
    [InlineData("function")]
    [InlineData("media")]
    [InlineData("reference")]
    [InlineData("value")]
    [InlineData("delta")]
    [InlineData("composite")]
    [InlineData("json-body")]
    [InlineData("non-json-body")]
    [InlineData("cookie")]
    [InlineData("required-header")]
    public async Task UnsupportedMemberShapesAreRejectedBeforeAnyFilesystemChanges(string scenario)
    {
        var (document, group) = Widgets();
        var operation = Operation(document, WidgetParent);
        switch (scenario)
        {
            case "post":
            case "delete":
                var method = scenario.ToUpperInvariant();
                document.Paths[WidgetParent].Operations!.Remove(HttpMethod.Get);
                Add(document, method, WidgetParent, operation);
                group = group with { Routes = [group.Routes[0], group.Routes[1] with { Method = method }] };
                break;
            case "action":
            case "function":
                operation.Extensions = new Dictionary<string, IOpenApiExtension>
                {
                    ["x-ms-docs-operation-type"] = new JsonNodeExtension(scenario),
                };
                break;
            case "media":
                operation.Responses!["200"].Content!["application/octet-stream"] = new OpenApiMediaType
                {
                    Schema = new OpenApiSchema { Type = JsonSchemaType.String, Format = "binary" },
                };
                break;
            case "reference":
            case "value":
            case "delta":
            case "composite":
                var path = scenario switch
                {
                    "reference" => WidgetParent + "/$ref",
                    "value" => WidgetParent + "/$value",
                    "delta" => WidgetParent + "/delta()",
                    _ => "/widgets(parentId='{parent-id}',widgetId='{widget-id}')",
                };
                document.Paths.Remove(WidgetParent);
                Add(document, "GET", path, operation);
                group = group with { Routes = [group.Routes[0], group.Routes[1] with { Path = path }] };
                if (scenario == "delta")
                    operation.Extensions = new Dictionary<string, IOpenApiExtension>
                    {
                        ["x-ms-docs-operation-type"] = new JsonNodeExtension("function"),
                    };
                break;
            case "json-body":
            case "non-json-body":
                operation.RequestBody = new OpenApiRequestBody
                {
                    Content = new Dictionary<string, IOpenApiMediaType>
                    {
                        [scenario == "json-body" ? "application/json" : "text/plain"] =
                            new OpenApiMediaType { Schema = Reference(document) },
                    },
                };
                break;
            case "cookie":
                operation.Parameters = [new OpenApiParameter
                {
                    Name = "session", In = ParameterLocation.Cookie,
                    Schema = new OpenApiSchema { Type = JsonSchemaType.String },
                }];
                break;
            default:
                operation.Parameters = [Header("ConsistencyLevel", required: true)];
                break;
        }

        await RejectWithoutWrites(document, [group]);
    }

    [Theory]
    [InlineData("unknown-query")]
    [InlineData("required-query")]
    [InlineData("query-type")]
    [InlineData("query-mismatch")]
    [InlineData("response-type")]
    [InlineData("primitive-list")]
    [InlineData("item-filter")]
    public async Task IncompatibleQueryAndResponseContractsCannotBeMerged(string scenario)
    {
        var (document, group) = Widgets();
        var left = Operation(document, WidgetRoot);
        var right = Operation(document, WidgetParent);
        switch (scenario)
        {
            case "unknown-query":
                left.Parameters = Queries("offset").ToList();
                right.Parameters = Queries("offset").ToList();
                break;
            case "required-query":
                left.Parameters = Queries("$filter").ToList();
                right.Parameters = Queries("$filter").ToList();
                ((OpenApiParameter)right.Parameters[0]).Required = true;
                break;
            case "query-type":
                left.Parameters = Queries("$top").ToList();
                right.Parameters = [new OpenApiParameter
                {
                    Name = "$top", In = ParameterLocation.Query,
                    Schema = new OpenApiSchema { Type = JsonSchemaType.String },
                }];
                break;
            case "query-mismatch":
                right.Parameters = Queries("$select").ToList();
                break;
            case "response-type":
                document.Components!.Schemas!["microsoft.graph.otherGroup"] = new OpenApiSchema { Type = JsonSchemaType.Object };
                right.Responses = Get(document, list: true,
                    entity: new OpenApiSchemaReference("microsoft.graph.otherGroup", document)).Responses;
                break;
            case "primitive-list":
                right.Responses = Get(document, list: true,
                    entity: new OpenApiSchema { Type = JsonSchemaType.String }).Responses;
                break;
            default:
                document.Paths.Remove(WidgetRoot);
                document.Paths.Remove(WidgetParent);
                var paths = new[] { WidgetRoot + "/{widget-id}", WidgetParent + "/{widget-id}" };
                foreach (var path in paths)
                {
                    var item = Get(document);
                    item.Parameters = Queries("$filter").ToList();
                    Add(document, "GET", path, item);
                }
                group = new([new("GET", paths[0], "Root"), new("GET", paths[1], "Parent")], "Root");
                break;
        }

        await RejectWithoutWrites(document, [group]);
    }

    [Theory]
    [InlineData("identical-list-and-singleton")]
    [InlineData("nested-default")]
    [InlineData("nonstructural-list-item")]
    public async Task AmbiguousMandatorySetsAndInvalidListItemFamiliesAreRejected(string scenario)
    {
        var document = Document();
        OperationVariantGroup group;
        if (scenario == "identical-list-and-singleton")
        {
            var singleton = WidgetRoot + "/{parent-id}";
            Add(document, "GET", singleton, Get(document));
            Add(document, "GET", WidgetParent, Get(document, list: true));
            group = new([new("GET", singleton, "Root"), new("GET", WidgetParent, "Parent")], "Root");
        }
        else
        {
            Add(document, "GET", WidgetRoot, Get(document, list: true));
            Add(document, "GET", WidgetParent, Get(document, list: true));
            group = new([new("GET", WidgetRoot, "Root"), new("GET", WidgetParent, "Parent")],
                scenario == "nested-default" ? "Parent" : "Root");
            if (scenario == "nonstructural-list-item")
            {
                var item = WidgetParent + "/{widget-id}";
                Add(document, "GET", item, Get(document));
                group = group with { Routes = [.. group.Routes, new("GET", item, "Root")] };
            }
        }

        await RejectWithoutWrites(document, [group]);
    }

    [Fact]
    public async Task DifferentUnderlyingPublicNamesAreNotRenamedToForceAMerge()
    {
        var (document, group) = Widgets();
        document.Paths.Remove(WidgetParent);
        const string different = "/otherResources/{parent-id}";
        Add(document, "GET", different, Get(document, list: true));
        group = group with { Routes = [group.Routes[0], group.Routes[1] with { Path = different }] };

        await RejectWithoutWrites(document, [group]);
    }

    [Fact]
    public async Task AllGroupsArePreflightedBeforeCreatingAnOutputDirectoryOrWritingAnEarlierValidGroup()
    {
        var (document, groups) = Applications();
        var widget = Get(document, list: true);
        widget.Parameters = Queries("unsupported").ToList();
        Add(document, "GET", WidgetRoot, Get(document, list: true));
        Add(document, "GET", WidgetParent, widget);
        var (_, invalid) = Widgets();
        IReadOnlyList<OperationVariantGroup> all = [.. groups, invalid];
        var output = OutputPath();
        try
        {
            await Assert.ThrowsAsync<InvalidOperationException>(() => GenerateAt(document, all, output, "beta"));
            Assert.False(Directory.Exists(output), "Preflight must precede even output directory creation.");
        }
        finally
        {
            if (Directory.Exists(output))
                Directory.Delete(output, recursive: true);
        }
        await RejectWithoutWrites(document, all, "beta");
    }

    [Theory]
    [InlineData("ordinary-item", false)]
    [InlineData("ordinary-item", true)]
    [InlineData("ordinary-pair", false)]
    [InlineData("ordinary-pair", true)]
    [InlineData("ordinary-count", false)]
    [InlineData("ordinary-count", true)]
    [InlineData("ordinary-case", false)]
    [InlineData("ordinary-case", true)]
    public async Task GroupedOutputCollisionsAreRejectedBeforeServiceOrCliWrites(string scenario, bool collisionData)
    {
        var (document, group) = Widgets();
        OperationVariantGroup[] groups = [group];
        switch (scenario)
        {
            case "ordinary-item":
                Add(document, "GET", WidgetRoot + "/{widget-id}", Get(document));
                break;
            case "ordinary-pair":
                const string ordinaryList = "/widgets/{other-id}/widgets";
                Add(document, "GET", ordinaryList, Get(document, list: true));
                Add(document, "GET", ordinaryList + "/{widget-id}", Get(document));
                break;
            case "ordinary-count":
                document.Paths.Clear();
                foreach (var route in group.Routes)
                    Add(document, "GET", route.Path + "/$count", Count());
                groups = [group with { Routes = group.Routes.Select(r => r with { Path = r.Path + "/$count" }).ToArray() }];
                Add(document, "GET", "/widgets/{other-id}/widgets/$count", Count());
                break;
            default:
                const string caseVariant = "/widgeT/{other-id}";
                Assert.Equal(Resolve(WidgetRoot).ClassName, Resolve(caseVariant).ClassName, ignoreCase: true);
                Add(document, "GET", caseVariant, Get(document));
                break;
        }

        await RejectBeforeServiceOrCliWrites(document, groups, collisionData, "output filename");
    }

    [Fact]
    public async Task UnsupportedUngroupedItemDoesNotReserveAnOutputFilename()
    {
        var (document, group) = Widgets();
        Add(document, "GET", WidgetRoot + "/{widget-id}", new OpenApiOperation());

        var files = await Generate(document, [group]);

        Assert.Equal(3, files.Count);
        Assert.Contains("RootList", files["GetMgWidget.g.cs"]);
        Assert.Contains("ParentList", files["GetMgWidget.g.cs"]);
    }

    [Theory]
    [InlineData("response", "oneOf", false)]
    [InlineData("response", "oneOf", true)]
    [InlineData("response", "anyOf", false)]
    [InlineData("response", "anyOf", true)]
    [InlineData("item", "oneOf", false)]
    [InlineData("item", "oneOf", true)]
    [InlineData("item", "anyOf", false)]
    [InlineData("item", "anyOf", true)]
    public async Task NamedGetUnionsNestedInAllOfAreDelegatedToKiota(string location, string unionKind, bool namedBranch)
    {
        var (document, group) = Widgets();
        var schemaName = location == "response"
            ? "microsoft.graph.onPremisesAgentGroupCollectionResponse"
            : "microsoft.graph.onPremisesAgentGroup";
        var union = new OpenApiSchema();
        var alternatives = new List<IOpenApiSchema>
        {
            new OpenApiSchema { Type = JsonSchemaType.Object },
            new OpenApiSchema { Type = JsonSchemaType.String },
        };
        if (unionKind == "oneOf")
            union.OneOf = alternatives;
        else
            union.AnyOf = alternatives;
        var branch = new OpenApiSchema { AllOf = [union] };
        document.Components!.Schemas!["microsoft.graph.unionBase"] = branch;
        Assert.IsType<OpenApiSchema>(document.Components.Schemas[schemaName]).AllOf =
            [namedBranch ? new OpenApiSchemaReference("microsoft.graph.unionBase", document) : branch];

        var files = await Generate(document, [group]);

        Assert.Equal(3, files.Count);
        Assert.Contains("[OutputType(typeof(object)", files["GetMgWidget.g.cs"]);
        foreach (var worker in files.Where(file => file.Key.Contains("_Route", StringComparison.Ordinal)))
        {
            Assert.Contains("[OutputType(typeof(object))]", worker.Value);
            Assert.Contains(".GetAsync(", worker.Value);
            Assert.DoesNotContain("BasicWidget", worker.Value);
            Assert.DoesNotContain("AdvancedWidget", worker.Value);
        }
    }

    [Theory]
    [InlineData(false, false)]
    [InlineData(false, true)]
    [InlineData(true, false)]
    [InlineData(true, true)]
    public async Task InlineAndNamedUnionResponsesArePassedThroughWithoutChoosingAnArm(bool named, bool anyOf)
    {
        var (document, group) = Widgets();
        document.Components!.Schemas!["microsoft.graph.otherGroup"] = new OpenApiSchema { Type = JsonSchemaType.Object };
        var branches = new List<IOpenApiSchema>
        {
            Reference(document),
            new OpenApiSchemaReference("microsoft.graph.otherGroup", document),
        };
        var union = new OpenApiSchema();
        if (anyOf)
            union.AnyOf = branches;
        else
            union.OneOf = branches;
        document.Components.Schemas["microsoft.graph.unionResult"] = union;
        foreach (var route in group.Routes)
            Operation(document, route.Path).Responses = JsonResponse(named
                ? new OpenApiSchemaReference("microsoft.graph.unionResult", document) : union);

        var files = await Generate(document, [group]);

        Assert.Equal(3, files.Count);
        Assert.Contains("DefaultParameterSetName = \"RootGet\"", files["GetMgWidget.g.cs"]);
        Assert.Contains("object? result;", files["GetMgWidget_Route0.g.cs"]);
        Assert.Contains("WriteObject(result);", files["GetMgWidget_Route0.g.cs"]);
        Assert.DoesNotContain("result?.Value", files["GetMgWidget_Route0.g.cs"]);
    }

    [Fact]
    public async Task NamedGetInheritanceWithoutUnionsRemainsSupported()
    {
        var (document, group) = Widgets();
        document.Components!.Schemas!["microsoft.graph.entityBase"] = new OpenApiSchema
        {
            Type = JsonSchemaType.Object,
            Properties = new Dictionary<string, IOpenApiSchema>
            {
                ["description"] = new OpenApiSchema { Type = JsonSchemaType.String },
            },
        };
        Assert.IsType<OpenApiSchema>(document.Components.Schemas["microsoft.graph.onPremisesAgentGroup"]).AllOf =
            [new OpenApiSchemaReference("microsoft.graph.entityBase", document)];
        var collection = Assert.IsType<OpenApiSchema>(
            document.Components.Schemas["microsoft.graph.onPremisesAgentGroupCollectionResponse"]);
        var properties = collection.Properties;
        collection.Properties = null;
        collection.AllOf = [new OpenApiSchema { Type = JsonSchemaType.Object, Properties = properties }];

        var files = await Generate(document, [group]);

        Assert.Equal(3, files.Count);
        Assert.Contains("RootList", files["GetMgWidget.g.cs"]);
        Assert.Contains(Entity, files["GetMgWidget_Route0.g.cs"]);
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public async Task EverySuccessfulGetResponseMustUseTheSelectedContract(bool matchingContract)
    {
        var (document, group) = Widgets();
        document.Components!.Schemas!["microsoft.graph.otherCollection"] = new OpenApiSchema
        {
            Type = JsonSchemaType.Object,
        };
        foreach (var route in group.Routes)
        {
            var operation = Operation(document, route.Path);
            var selected = operation.Responses!["200"].Content!["application/json"].Schema!;
            operation.Responses["201"] = new OpenApiResponse
            {
                Content = new Dictionary<string, IOpenApiMediaType>
                {
                    ["application/vnd.fixture+json"] = new OpenApiMediaType
                    {
                        Schema = matchingContract ? selected
                            : new OpenApiSchemaReference("microsoft.graph.otherCollection", document),
                    },
                },
            };
        }

        if (matchingContract)
            Assert.Equal(3, (await Generate(document, [group])).Count);
        else
            await RejectBeforeServiceOrCliWrites(document, [group], errorFragment: "success response schemas");
    }

    private static async Task RejectBeforeServiceOrCliWrites(OpenApiDocument document,
        IReadOnlyList<OperationVariantGroup> groups, bool collisionData = false, string? errorFragment = null)
    {
        document.RegisterComponents();
        foreach (var cli in new[] { false, true })
        foreach (var existing in new[] { false, true })
        {
            var output = OutputPath();
            const string generated = "Existing source must survive failed preflight.\r\n";
            const string marker = "{\"descriptionLocation\":\"previous.yml\"}\r\n";
            if (existing)
            {
                Directory.CreateDirectory(output);
                File.WriteAllText(Path.Combine(output, "Sentinel.g.cs"), generated);
                File.WriteAllText(Path.Combine(output, "kiota-lock.json"), marker);
            }
            try
            {
                var config = new GeneratorConfig(Client, output, UseCollisionData: collisionData);
                var entries = RegisterGroups(groups);
                var error = await Assert.ThrowsAsync<InvalidOperationException>(() => cli
                    ? WrapperGenerator.Program.GenerateAsync(document, config, "next.yml",
                        NullLogger.Instance, CancellationToken.None, configurationEntries: entries)
                    : new PowerShellWrapperGenerationService(document, config, NullLogger.Instance, "v1.0", entries)
                        .GenerateAsync(CancellationToken.None));
                if (errorFragment is not null)
                    Assert.Contains(errorFragment, error.Message);
                if (existing)
                {
                    Assert.Equal(generated, File.ReadAllText(Path.Combine(output, "Sentinel.g.cs")));
                    Assert.Equal(marker, File.ReadAllText(Path.Combine(output, "kiota-lock.json")));
                    Assert.Equal(2, Directory.GetFiles(output, "*", SearchOption.AllDirectories).Length);
                }
                else
                    Assert.False(Directory.Exists(output));
            }
            finally
            {
                if (Directory.Exists(output))
                    Directory.Delete(output, recursive: true);
            }
        }
    }

    [Theory]
    [InlineData("partial-applications")]
    [InlineData("unsupported-group")]
    public async Task CliPreflightRejectsGroupsBeforeCreatingOutputOrChangingTheLockMarker(string scenario)
    {
        OpenApiDocument document;
        IReadOnlyList<OperationVariantGroup> groups;
        string apiVersion;
        if (scenario == "partial-applications")
        {
            var applications = Applications();
            document = applications.Document;
            groups = applications.Groups;
            apiVersion = "beta";
            IncludePathFilter.Apply(document, [Root + "#GET"]);
        }
        else
        {
            var widgets = Widgets();
            document = widgets.Document;
            groups = [widgets.Group];
            apiVersion = "v1.0";
            Operation(document, WidgetParent).Parameters = Queries("unsupported").ToList();
        }
        document.RegisterComponents();
        foreach (var existingOutput in new[] { false, true })
        {
            var output = OutputPath();
            var stale = Path.Combine(output, "Sentinel.g.cs");
            var marker = Path.Combine(output, "kiota-lock.json");
            const string generatedSentinel = "Preserve existing generated source.\r\n";
            const string markerSentinel = "{\"descriptionLocation\":\"original-spec.yml\"}\r\n";
            if (existingOutput)
            {
                Directory.CreateDirectory(output);
                File.WriteAllText(stale, generatedSentinel);
                File.WriteAllText(marker, markerSentinel);
            }
            try
            {
                var config = new GeneratorConfig(Client, output, false);
                var specPath = Path.Combine(Directory.GetCurrentDirectory(), "spec.yml");
                await Assert.ThrowsAsync<InvalidOperationException>(() => WrapperGenerator.Program.GenerateAsync(
                    document, config, specPath, NullLogger.Instance, CancellationToken.None, apiVersion, RegisterGroups(groups)));
                if (existingOutput)
                {
                    Assert.Equal(generatedSentinel, File.ReadAllText(stale));
                    Assert.Equal(markerSentinel, File.ReadAllText(marker));
                    Assert.Equal(2, Directory.GetFiles(output, "*", SearchOption.AllDirectories).Length);
                }
                else
                    Assert.False(Directory.Exists(output), "CLI group preflight must precede directory and marker creation.");
            }
            finally
            {
                if (Directory.Exists(output))
                    Directory.Delete(output, recursive: true);
            }
        }
    }

    [Fact]
    public async Task CliStillWritesTheSpecMarkerBeforeAnOrdinaryUnoptedCollisionFails()
    {
        var (document, _) = Widgets();
        document.RegisterComponents();
        var output = OutputPath();
        var specPath = Path.Combine(Directory.GetCurrentDirectory(), "ordinary-spec.yml");
        try
        {
            var config = new GeneratorConfig(Client, output, UseCollisionData: true);
            var ex = await Assert.ThrowsAsync<InvalidOperationException>(() => WrapperGenerator.Program.GenerateAsync(
                document, config, specPath, NullLogger.Instance, CancellationToken.None));

            Assert.Contains("collision", ex.Message, StringComparison.OrdinalIgnoreCase);
            var marker = Path.Combine(output, "kiota-lock.json");
            Assert.True(File.Exists(marker), "Ordinary collision captures still require the CLI spec marker.");
            using var json = JsonDocument.Parse(File.ReadAllText(marker));
            Assert.Equal(Path.GetRelativePath(output, specPath).Replace('\\', '/'),
                json.RootElement.GetProperty("descriptionLocation").GetString());
            Assert.NotEmpty(Directory.GetFiles(output, "*.g.cs"));
        }
        finally
        {
            if (Directory.Exists(output))
                Directory.Delete(output, recursive: true);
        }
    }

    private static void AssertMandatory(string source, string parameter, string set)
    {
        var declaration = source.IndexOf("public string " + parameter + " ", StringComparison.Ordinal);
        Assert.True(declaration >= 0, "Missing path parameter " + parameter);
        var previousDeclaration = source.LastIndexOf("public ", declaration - 1, StringComparison.Ordinal);
        var attributes = source[(previousDeclaration < 0 ? 0 : previousDeclaration)..declaration];
        Assert.Contains($"[Parameter(Mandatory = true, ParameterSetName = \"{set}\"", attributes);
    }

    private static void AssertForwarding(string source)
    {
        Assert.Contains("& $CmdletName @BoundParameters", source);
        Assert.Contains("global::System.Management.Automation.Runspaces.PipelineResultTypes.Output | " +
            "global::System.Management.Automation.Runspaces.PipelineResultTypes.Error", source);
        Assert.Contains("MyInvocation.BoundParameters, internalCmdletName", source);
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

    private static async Task RejectWithoutWrites(
        OpenApiDocument document, IReadOnlyList<OperationVariantGroup> groups, string apiVersion = "v1.0")
    {
        var output = OutputPath();
        Directory.CreateDirectory(output);
        var stale = Path.Combine(output, "Stale.g.cs");
        var other = Path.Combine(output, "keep.txt");
        const string sentinel = "Existing generated output must survive rejected configuration.\r\n";
        File.WriteAllText(stale, sentinel);
        File.WriteAllText(other, "unrelated");
        try
        {
            await Assert.ThrowsAsync<InvalidOperationException>(() => GenerateAt(document, groups, output, apiVersion));
            Assert.Equal(sentinel, File.ReadAllText(stale));
            Assert.Equal("unrelated", File.ReadAllText(other));
            Assert.Equal(new[] { "Stale.g.cs", "keep.txt" },
                Directory.GetFiles(output, "*", SearchOption.AllDirectories).Select(Path.GetFileName)
                    .OrderBy(n => n, StringComparer.Ordinal).ToArray());
        }
        finally
        {
            Directory.Delete(output, recursive: true);
        }
    }

    private static (OpenApiDocument Document, OperationVariantGroup[] Groups) Applications()
    {
        var document = Document();
        Add(document, "GET", Root, Get(document, list: true));
        Add(document, "GET", Item, Get(document));
        Add(document, "GET", Agent, Get(document, list: true));
        Add(document, "GET", Root + "/$count", Count());
        Add(document, "GET", Agent + "/$count", Count());
        return (document,
        [
            new([new("GET", Root, "Root"), new("GET", Item, "Root"), new("GET", Agent, "Agent")], "Root"),
            new([new("GET", Root + "/$count", "Root"), new("GET", Agent + "/$count", "Agent")], "Root"),
        ]);
    }

    private static (OpenApiDocument Document, OperationVariantGroup Group) Widgets()
    {
        var document = Document();
        Add(document, "GET", WidgetRoot, Get(document, list: true));
        Add(document, "GET", WidgetParent, Get(document, list: true));
        return (document, new([new("GET", WidgetRoot, "Root"), new("GET", WidgetParent, "Parent")], "Root"));
    }

    private static CmdletNaming Resolve(string path) => Naming.Resolve(
        new OperationInfo(HttpMethod.Get, path), new GeneratorConfig(Client, ".", false), "beta");

    private static string FileStem(CmdletNaming naming) => naming.ClassName[..^"Command".Length];

    private static OpenApiDocument Document() => new()
    {
        Paths = new OpenApiPaths(),
        Components = new OpenApiComponents
        {
            Schemas = new Dictionary<string, IOpenApiSchema>
            {
                ["microsoft.graph.onPremisesAgentGroup"] = new OpenApiSchema
                {
                    Type = JsonSchemaType.Object,
                    Properties = new Dictionary<string, IOpenApiSchema>
                    {
                        ["id"] = new OpenApiSchema { Type = JsonSchemaType.String },
                        ["displayName"] = new OpenApiSchema { Type = JsonSchemaType.String },
                    },
                },
            },
        },
    };

    private static IOpenApiSchema Reference(OpenApiDocument document) =>
        new OpenApiSchemaReference("microsoft.graph.onPremisesAgentGroup", document);

    private static OpenApiOperation Get(OpenApiDocument document, bool list = false, IOpenApiSchema? entity = null)
    {
        if (!list)
            return new() { Responses = JsonResponse(entity ?? Reference(document)) };
        var collection = entity is null
            ? "microsoft.graph.onPremisesAgentGroupCollectionResponse"
            : "microsoft.graph.alternateCollectionResponse";
        document.Components!.Schemas![collection] = new OpenApiSchema
        {
            Type = JsonSchemaType.Object,
            Properties = new Dictionary<string, IOpenApiSchema>
            {
                ["value"] = new OpenApiSchema { Type = JsonSchemaType.Array, Items = entity ?? Reference(document) },
                ["@odata.nextLink"] = new OpenApiSchema { Type = JsonSchemaType.String | JsonSchemaType.Null },
            },
        };
        return new() { Responses = JsonResponse(new OpenApiSchemaReference(collection, document)) };
    }

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

    private static OpenApiParameter Header(string name, bool required = false) => new()
    {
        Name = name, In = ParameterLocation.Header, Required = required,
        Schema = new OpenApiSchema { Type = JsonSchemaType.String },
    };

    private static IEnumerable<IOpenApiParameter> Queries(params string[] names) => names.Select(name => new OpenApiParameter
    {
        Name = name,
        In = ParameterLocation.Query,
        Schema = name is "$select" or "$expand" or "$orderby"
            ? new OpenApiSchema { Type = JsonSchemaType.Array, Items = new OpenApiSchema { Type = JsonSchemaType.String } }
            : new OpenApiSchema
            {
                Type = name is "$top" or "$skip" ? JsonSchemaType.Integer
                    : name == "$count" ? JsonSchemaType.Boolean : JsonSchemaType.String,
            },
    });

    private static OpenApiOperation Operation(OpenApiDocument document, string path) =>
        document.Paths[path].Operations![HttpMethod.Get];

    private static void Add(OpenApiDocument document, string method, string path, OpenApiOperation operation) =>
        document.Paths[path] = new OpenApiPathItem
        {
            Operations = new Dictionary<HttpMethod, OpenApiOperation> { [new HttpMethod(method)] = operation },
        };

    private static string OutputPath() =>
        Path.Combine(Directory.GetCurrentDirectory(), ".multi-route-tests-" + Guid.NewGuid().ToString("N"));

    private static async Task<Dictionary<string, string>> Generate(
        OpenApiDocument document, IReadOnlyList<OperationVariantGroup>? groups = null, string apiVersion = "v1.0",
        bool useCollisionData = false)
    {
        var output = OutputPath();
        try
        {
            await GenerateAt(document, groups, output, apiVersion, useCollisionData);
            return Directory.GetFiles(output, "*.g.cs").ToDictionary(path => Path.GetFileName(path), File.ReadAllText);
        }
        finally
        {
            if (Directory.Exists(output))
                Directory.Delete(output, recursive: true);
        }
    }

    private static Task GenerateAt(
        OpenApiDocument document, IReadOnlyList<OperationVariantGroup>? groups, string output, string apiVersion,
        bool useCollisionData = false)
    {
        document.RegisterComponents();
        var config = new GeneratorConfig(Client, output, useCollisionData);
        return new PowerShellWrapperGenerationService(document, config, NullLogger.Instance, apiVersion, RegisterGroups(groups))
            .GenerateAsync(CancellationToken.None);
    }

    private static Entry[]? RegisterGroups(IReadOnlyList<OperationVariantGroup>? groups) =>
        groups?.Select(group => GroupVariants(group, "Isolated fixture registration")).ToArray();
}
