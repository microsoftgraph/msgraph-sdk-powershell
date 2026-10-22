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

public sealed class ExplicitRouteSelectionTests
{
    private const string Client = "Microsoft.Graph.PowerShell.Test.Client";
    private const string SecurityCases = "/security/cases/ediscoveryCases/{ediscoveryCase-id}/";

    [Fact]
    public void NewPoliciesRemainOptInWithoutChangingExistingConstructors()
    {
        var route = new MultiRoute("GET", "/widgets/$count", "Nested");
        var group = new MultiRouteGroup("v1.0", [route, route with { Name = "TopLevel", Path = "/widgets/{widget-id}/widgets/$count" }],
            "Nested", "Route");
        var (method, path, name) = route;
        var (version, routes, defaultRoute, selector) = group;

        Assert.Equal(("GET", "/widgets/$count", "Nested"), (method, path, name));
        Assert.Equal(("v1.0", "Nested", "Route"), (version, defaultRoute, selector));
        Assert.Same(group.Routes, routes);
        Assert.Empty(route.QueryBindings);
        Assert.False(group.AllowZeroArgumentFunctions);
        Assert.False(group.AllowAsymmetricRoutes);
        Assert.False(group.AllowResponseUnion);
        Assert.False(group.AllowRouteSpecificBodies);
        Assert.False(group.AllowReferenceDelete);
        Assert.False(group.AllowExplicitRouteSelection);
        Assert.False(group.AllowMediaRoutes);
        Assert.False(group.IncludeDerivedSuppressedRoutes);
        Assert.False(group.AllowPublishedParameterInference);
        Assert.False(group.AllowMixedReadOperations);
        Assert.Null(new MultiRouteGroup(version, routes, defaultRoute).SelectorParameter);
    }

    [Theory]
    [InlineData("articles", "article-id", "indicators", "articleIndicators", "ArticleId", "Articles", "Indicators")]
    [InlineData("hosts", "host-id", "components", "hostComponents", "HostId", "Hosts", "Components")]
    public async Task ExplicitCountRoutesMakeOnlyRouteUniqueIdsOptionalOnThePublicCommand(
        string parent, string template, string child, string topLevel, string id, string parentMember, string childMember)
    {
        var (document, group) = CountFixture(parent, template, child, topLevel);

        var files = await Generate(document, group);

        Assert.Equal(3, files.Count);
        var naming = Naming.Resolve(new OperationInfo(HttpMethod.Get, group.Routes[0].Path));
        Assert.Equal(naming.Noun, Naming.Resolve(new OperationInfo(HttpMethod.Get, group.Routes[1].Path)).Noun);
        var stem = naming.VerbName + naming.Noun;
        var source = files[stem + ".g.cs"];
        Assert.Contains("DefaultParameterSetName = \"Route\"", source);
        Assert.Contains("[ValidateSet(\"Published\", \"Nested\", \"TopLevel\")]", source);
        AssertParameter(source, id, mandatory: false, "Route");
        Assert.Contains("[OutputType(typeof(int), ParameterSetName = new[] { \"Route\" })]", source);
        foreach (var route in group.Routes)
            Assert.Contains($"[GraphRoute(\"GET\", \"{route.Path}\", ParameterSetName = \"Route\")]", source);
        var nested = files[stem + "_Route0.g.cs"];
        var top = files[stem + "_Route1.g.cs"];
        AssertWorkerPathParameter(nested, id, position: 0);
        Assert.Contains($"client.Security.ThreatIntelligence.{parentMember}[{id}].{childMember}.Count.GetAsync(", nested);
        Assert.DoesNotContain("public string " + id, top);
        Assert.Contains("client.Security.ThreatIntelligence." + char.ToUpperInvariant(topLevel[0]) + topLevel[1..] + ".Count.GetAsync(", top);
        Assert.Contains("[OutputType(typeof(int))]", nested);
        Assert.Contains("[OutputType(typeof(int))]", top);
        AssertSelectionContract(source, "Nested");
        AssertRouteCandidate(source, "Nested", "Scalar", [id], [id]);
        AssertRouteCandidate(source, "TopLevel", "Scalar", [], []);
        Assert.Contains("\"" + naming.VerbName + "-" + naming.Noun + "_Route0\"", source);
        Assert.Contains("\"" + naming.VerbName + "-" + naming.Noun + "_Route1\"", source);
    }

    [Fact]
    public async Task ExistingCountGroupStillRejectsRouteSpecificPublicParametersWithoutExplicitAllowance()
    {
        var (document, group) = CountFixture();

        var error = await Assert.ThrowsAsync<InvalidOperationException>(() =>
            Generate(document, group with { AllowExplicitRouteSelection = false }));

        Assert.Contains("identical public parameters", error.Message, StringComparison.OrdinalIgnoreCase);
    }

    [Theory]
    [InlineData("custodians", "ediscoveryCustodian-id", "EdiscoveryCustodianId", "applyHold", "ApplyHold")]
    [InlineData("custodians", "ediscoveryCustodian-id", "EdiscoveryCustodianId", "removeHold", "RemoveHold")]
    [InlineData("custodians", "ediscoveryCustodian-id", "EdiscoveryCustodianId", "updateIndex", "UpdateIndex")]
    [InlineData("noncustodialDataSources", "ediscoveryNoncustodialDataSource-id", "EdiscoveryNoncustodialDataSourceId", "applyHold", "ApplyHold")]
    [InlineData("noncustodialDataSources", "ediscoveryNoncustodialDataSource-id", "EdiscoveryNoncustodialDataSourceId", "removeHold", "RemoveHold")]
    [InlineData("noncustodialDataSources", "ediscoveryNoncustodialDataSource-id", "EdiscoveryNoncustodialDataSourceId", "updateIndex", "UpdateIndex")]
    public async Task ExplicitSecurityActionsPreserveSharedRequiredIdsAndTypedRouteSpecificBodies(
        string resource, string template, string id, string operationName, string typeName)
    {
        var (document, group) = ActionFixture(resource, template, operationName);

        var files = await Generate(document, group);

        Assert.Equal(3, files.Count);
        var naming = Naming.Resolve(new OperationInfo(HttpMethod.Post, group.Routes[0].Path, Kind: OperationKind.Action));
        Assert.Equal(naming.Noun, Naming.Resolve(new OperationInfo(HttpMethod.Post, group.Routes[1].Path, Kind: OperationKind.Action)).Noun);
        var stem = naming.VerbName + naming.Noun;
        var source = files[stem + ".g.cs"];
        Assert.Contains("DefaultParameterSetName = \"Route\"", source);
        Assert.Contains("[ValidateSet(\"Published\", \"Item\", \"Collection\")]", source);
        AssertParameter(source, "EdiscoveryCaseId", mandatory: true, "Route");
        AssertParameter(source, id, mandatory: false, "Route");
        AssertParameter(source, "Ids", mandatory: false, "Route");
        Assert.Contains("public string[]? Ids", source);
        Assert.DoesNotContain("BodyParameter", source);
        Assert.DoesNotContain("[OutputType(", source);
        Assert.Contains("SupportsShouldProcess = true", source);
        foreach (var route in group.Routes)
            Assert.Contains($"[GraphRoute(\"POST\", \"{route.Path}\", ParameterSetName = \"Route\")]", source);
        var item = files[stem + "_Route0.g.cs"];
        var collection = files[stem + "_Route1.g.cs"];
        AssertWorkerPathParameter(item, id, position: 1);
        Assert.DoesNotContain("PostRequestBody", item);
        Assert.DoesNotContain("public string[]? Ids", item);
        Assert.Contains(".PostAsync(", item);
        Assert.DoesNotContain("public string " + id, collection);
        Assert.Contains("public string[]? Ids", collection);
        var resourceMember = char.ToUpperInvariant(resource[0]) + resource[1..];
        var bodyType = $"global::{Client}.Security.Cases.EdiscoveryCases.Item.{resourceMember}.MicrosoftGraphSecurity{typeName}.{typeName}PostRequestBody";
        Assert.Contains("new " + bodyType + "()", collection);
        Assert.Contains("body.Ids = Ids!.ToList()", collection);
        Assert.Contains(".PostAsync(body,", collection);
        Assert.Contains($"client.Security.Cases.EdiscoveryCases[EdiscoveryCaseId].{resourceMember}[{id}].MicrosoftGraphSecurity{typeName}", item);
        Assert.Contains($"client.Security.Cases.EdiscoveryCases[EdiscoveryCaseId].{resourceMember}.MicrosoftGraphSecurity{typeName}", collection);
        foreach (var worker in new[] { item, collection })
        {
            AssertWorkerPathParameter(worker, "EdiscoveryCaseId", position: 0);
            Assert.Contains("if (!ShouldProcess(", worker);
            Assert.DoesNotContain("dynamic", worker);
            Assert.DoesNotContain("System.Reflection", worker);
        }
        AssertSelectionContract(source, "Item");
        AssertRouteCandidate(source, "Item", "Invoke", ["EdiscoveryCaseId", id], ["EdiscoveryCaseId", id]);
        AssertRouteCandidate(source, "Collection", "Invoke", ["EdiscoveryCaseId", "Ids"], ["EdiscoveryCaseId"]);
    }

    [Fact]
    public async Task ExplicitAsymmetricNotesUseOnePublicSetWithoutInventingANestedGet()
    {
        var (document, group) = NotesFixture();

        var files = await Generate(document, group);

        Assert.Equal(4, files.Count);
        var stem = "Get" + Naming.Resolve(new OperationInfo(HttpMethod.Get, group.Routes[0].Path)).Noun;
        var source = files[stem + ".g.cs"];
        Assert.Contains("DefaultParameterSetName = \"Route\"", source);
        Assert.Contains("[ValidateSet(\"Published\", \"Root\", \"Nested\")]", source);
        AssertParameter(source, "GroupId", mandatory: true, "Route");
        AssertParameter(source, "SectionGroupId", mandatory: false, "Route");
        foreach (var parameter in new[] { "Property", "Filter", "Top", "All" })
            AssertParameter(source, parameter, mandatory: false, "Route");
        Assert.Contains("[Alias(\"Select\")]", source);
        Assert.DoesNotContain("ParameterSetName = \"List\"", source);
        Assert.DoesNotContain("ParameterSetName = \"Get\"", source);
        foreach (var route in group.Routes)
            Assert.Contains($"[GraphRoute(\"GET\", \"{route.Path}\", ParameterSetName = \"Route\")]", source);
        Assert.Contains($"[OutputType(typeof({Client}.Models.SectionGroup), ParameterSetName = new[] {{ \"Route\" }})]", source);
        var rootList = files[stem + "_Route0.g.cs"];
        var rootGet = files[stem + "_Route1.g.cs"];
        var nestedList = files[stem + "_Route2.g.cs"];
        Assert.Contains("client.Groups[GroupId].Onenote.SectionGroups.GetAsync(", rootList);
        Assert.Contains("client.Groups[GroupId].Onenote.SectionGroups[SectionGroupId].GetAsync(", rootGet);
        Assert.Contains("client.Groups[GroupId].Onenote.SectionGroups[SectionGroupId].SectionGroups.GetAsync(", nestedList);
        Assert.DoesNotContain("public string SectionGroupId", rootList);
        Assert.Contains("public string SectionGroupId", rootGet);
        Assert.Contains("public string SectionGroupId", nestedList);
        Assert.Contains("public SwitchParameter All", rootList);
        Assert.DoesNotContain("public SwitchParameter All", rootGet);
        Assert.Contains("public SwitchParameter All", nestedList);
        AssertRouteCandidate(source, "Root", "List", ["GroupId", "Filter", "Property", "Select", "Top", "All"], ["GroupId"]);
        AssertRouteCandidate(source, "Root", "Get", ["GroupId", "SectionGroupId", "Property", "Select"], ["GroupId", "SectionGroupId"]);
        AssertRouteCandidate(source, "Nested", "List", ["GroupId", "SectionGroupId", "Filter", "Property", "Select", "Top", "All"], ["GroupId", "SectionGroupId"]);
        Assert.DoesNotContain("(\"Nested\", \"Get\",", source);
        AssertSelectionContract(source, "Root");
    }

    [Fact]
    public async Task ExplicitSelectionDoesNotImplicitlyAuthorizeAsymmetricOperationShapes()
    {
        var (document, group) = NotesFixture();

        var error = await Assert.ThrowsAsync<InvalidOperationException>(() =>
            Generate(document, group with { AllowAsymmetricRoutes = false }));

        Assert.Contains("asymmetric resource GET", error.Message, StringComparison.OrdinalIgnoreCase);
    }

    [Fact]
    public async Task NotesPublishedParameterInferenceRequiresItsOwnOptIn()
    {
        var (document, group) = NotesFixture();

        var defaultOnly = await Generate(document, group);
        var inferred = await Generate(document, group with { AllowPublishedParameterInference = true });

        var stem = "Get" + Naming.Resolve(new OperationInfo(HttpMethod.Get, group.Routes[0].Path)).Noun;
        var defaultSource = defaultOnly[stem + ".g.cs"];
        var inferredSource = inferred[stem + ".g.cs"];
        AssertSelectionContract(defaultSource, "Root");
        Assert.NotEqual(defaultSource, inferredSource);
        Assert.DoesNotContain("? !string.Equals(candidate.Label, \"Root\", StringComparison.OrdinalIgnoreCase)", inferredSource);
        Assert.Contains("DefaultParameterSetName = \"Route\"", inferredSource);
        AssertParameter(inferredSource, "GroupId", mandatory: true, "Route");
        AssertParameter(inferredSource, "SectionGroupId", mandatory: false, "Route");
        AssertRouteCandidate(inferredSource, "Root", "List", ["GroupId", "Filter", "Property", "Select", "Top", "All"], ["GroupId"]);
        AssertRouteCandidate(inferredSource, "Root", "Get", ["GroupId", "SectionGroupId", "Property", "Select"], ["GroupId", "SectionGroupId"]);
        AssertRouteCandidate(inferredSource, "Nested", "List", ["GroupId", "SectionGroupId", "Filter", "Property", "Select", "Top", "All"], ["GroupId", "SectionGroupId"]);
        foreach (var file in defaultOnly.Keys.Where(file => file != stem + ".g.cs"))
            Assert.Equal(defaultOnly[file], inferred[file]);
    }

    [Fact]
    public async Task ExplicitActionSelectionDoesNotAlsoAuthorizeDifferentBodies()
    {
        var (document, group) = ActionFixture();

        var error = await Assert.ThrowsAsync<InvalidOperationException>(() =>
            Generate(document, group with { AllowRouteSpecificBodies = false }));

        Assert.Contains("body", error.Message, StringComparison.OrdinalIgnoreCase);
    }

    [Fact]
    public async Task BodySpecificSelectorStillRequiresExplicitSelectionAllowance()
    {
        var (document, group) = ActionFixture();

        var error = await Assert.ThrowsAsync<InvalidOperationException>(() =>
            Generate(document, group with { AllowExplicitRouteSelection = false }));

        Assert.Contains("explicit route-selection", error.Message, StringComparison.OrdinalIgnoreCase);
    }

    [Fact]
    public async Task ExplicitSelectionRequiresASelector()
    {
        var (document, group) = CountFixture();

        var error = await Assert.ThrowsAsync<InvalidOperationException>(() => Generate(document, group with { SelectorParameter = null }));

        Assert.Contains("selector", error.Message, StringComparison.OrdinalIgnoreCase);
    }

    [Fact]
    public async Task ExplicitCountSelectionDoesNotAuthorizeTheMediaPolicy()
    {
        var (document, group) = CountFixture();

        var error = await Assert.ThrowsAsync<InvalidOperationException>(() =>
            Generate(document, group with { AllowMediaRoutes = true }));

        Assert.Contains("media route policy", error.Message, StringComparison.OrdinalIgnoreCase);
    }

    [Theory]
    [InlineData("route")]
    [InlineData("WhatIf")]
    [InlineData("route-name")]
    public async Task ExplicitSelectionDoesNotBypassSelectorValidation(string selector)
    {
        var (document, group) = CountFixture();

        var error = await Assert.ThrowsAsync<InvalidOperationException>(() => Generate(document, group with { SelectorParameter = selector }));

        Assert.Contains("selector", error.Message, StringComparison.OrdinalIgnoreCase);
    }

    [Theory]
    [InlineData(ParameterLocation.Query)]
    [InlineData(ParameterLocation.Header)]
    public async Task ExplicitSelectionDoesNotIgnoreInheritedQueryOrHeaderParameters(ParameterLocation location)
    {
        var (document, group) = CountFixture();
        ((OpenApiPathItem)document.Paths[group.Routes[1].Path]).Parameters =
        [
            new OpenApiParameter { Name = "inherited", In = location, Schema = new OpenApiSchema { Type = JsonSchemaType.String } },
        ];

        var error = await Assert.ThrowsAsync<InvalidOperationException>(() => Generate(document, group));

        Assert.Contains("path-item query or header parameters", error.Message, StringComparison.OrdinalIgnoreCase);
    }

    private static (OpenApiDocument Document, MultiRouteGroup Group) CountFixture(
        string parent = "articles", string template = "article-id", string child = "indicators", string topLevel = "articleIndicators")
    {
        var document = Document();
        var routes = new[]
        {
            new MultiRoute("GET", $"/security/threatIntelligence/{parent}/{{{template}}}/{child}/$count", "Nested"),
            new MultiRoute("GET", $"/security/threatIntelligence/{topLevel}/$count", "TopLevel"),
        };
        foreach (var route in routes)
            Add(document, route, new OpenApiOperation
            {
                Responses = new OpenApiResponses
                {
                    ["200"] = new OpenApiResponse
                    {
                        Content = new Dictionary<string, IOpenApiMediaType>
                        {
                            ["text/plain"] = new OpenApiMediaType { Schema = new OpenApiSchema { Type = JsonSchemaType.Integer, Format = "int32" } },
                        },
                    },
                },
            });
        return (document, new MultiRouteGroup("v1.0", routes, "Nested", "Route") { AllowExplicitRouteSelection = true });
    }

    private static (OpenApiDocument Document, MultiRouteGroup Group) ActionFixture(
        string resource = "custodians", string template = "ediscoveryCustodian-id", string operationName = "applyHold")
    {
        var document = Document();
        var root = SecurityCases + resource;
        var suffix = "/microsoft.graph.security." + operationName;
        var routes = new[]
        {
            new MultiRoute("POST", root + "/{" + template + "}" + suffix, "Item"),
            new MultiRoute("POST", root + suffix, "Collection"),
        };
        foreach (var route in routes)
            Add(document, route, new OpenApiOperation
            {
                Extensions = new Dictionary<string, IOpenApiExtension>
                {
                    ["x-ms-docs-operation-type"] = new JsonNodeExtension("action"),
                },
                Responses = new OpenApiResponses { ["204"] = new OpenApiResponse() },
                RequestBody = route.Name == "Item" ? null : new OpenApiRequestBody
                {
                    Content = new Dictionary<string, IOpenApiMediaType>
                    {
                        ["application/json"] = new OpenApiMediaType
                        {
                            Schema = new OpenApiSchema
                            {
                                Type = JsonSchemaType.Object,
                                Properties = new Dictionary<string, IOpenApiSchema>
                                {
                                    ["ids"] = new OpenApiSchema { Type = JsonSchemaType.Array, Items = new OpenApiSchema { Type = JsonSchemaType.String } },
                                },
                            },
                        },
                    },
                },
            });
        return (document, new MultiRouteGroup("v1.0", routes, "Item", "Route")
        {
            AllowExplicitRouteSelection = true,
            AllowRouteSpecificBodies = true,
        });
    }

    private static (OpenApiDocument Document, MultiRouteGroup Group) NotesFixture()
    {
        var document = Document();
        document.Components!.Schemas = new Dictionary<string, IOpenApiSchema>
        {
            ["microsoft.graph.sectionGroup"] = new OpenApiSchema { Type = JsonSchemaType.Object },
        };
        var routes = new[]
        {
            new MultiRoute("GET", "/groups/{group-id}/onenote/sectionGroups", "Root"),
            new MultiRoute("GET", "/groups/{group-id}/onenote/sectionGroups/{sectionGroup-id}", "Root"),
            new MultiRoute("GET", "/groups/{group-id}/onenote/sectionGroups/{sectionGroup-id}/sectionGroups", "Nested"),
        };
        for (var i = 0; i < routes.Length; i++)
        {
            var entity = new OpenApiSchemaReference("microsoft.graph.sectionGroup", document);
            var response = i == 1 ? (IOpenApiSchema)entity : new OpenApiSchema
            {
                Type = JsonSchemaType.Object,
                Properties = new Dictionary<string, IOpenApiSchema>
                {
                    ["value"] = new OpenApiSchema { Type = JsonSchemaType.Array, Items = entity },
                },
            };
            Add(document, routes[i], new OpenApiOperation
            {
                Parameters = (i == 1 ? new[] { "$select" } : ["$select", "$filter", "$top"])
                    .Select(name => (IOpenApiParameter)new OpenApiParameter
                    {
                        Name = name,
                        In = ParameterLocation.Query,
                        Schema = new OpenApiSchema { Type = name == "$top" ? JsonSchemaType.Integer : JsonSchemaType.String },
                    }).ToList(),
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
            });
        }
        return (document, new MultiRouteGroup("v1.0", routes, "Root", "Route")
        {
            AllowExplicitRouteSelection = true,
            AllowAsymmetricRoutes = true,
        });
    }

    private static OpenApiDocument Document() => new() { Paths = new OpenApiPaths(), Components = new OpenApiComponents() };

    private static void Add(OpenApiDocument document, MultiRoute route, OpenApiOperation operation) =>
        document.Paths[route.Path] = new OpenApiPathItem
        {
            Operations = new Dictionary<HttpMethod, OpenApiOperation> { [new HttpMethod(route.Method)] = operation },
        };

    private static void AssertParameter(string source, string name, bool mandatory, string set)
    {
        var lines = source.ReplaceLineEndings("\n").Split('\n');
        var index = Array.FindIndex(lines, line => line.Contains(" " + name + " { get; set; }", StringComparison.Ordinal));
        Assert.True(index > 0, "Missing parameter " + name);
        var attributes = new List<string>();
        for (var i = index - 1; i >= 0 && lines[i].TrimStart().StartsWith('['); i--)
            attributes.Add(lines[i]);
        Assert.Contains(attributes, line => line.Contains($"Mandatory = {mandatory.ToString().ToLowerInvariant()}, ParameterSetName = \"{set}\"", StringComparison.Ordinal));
    }

    private static void AssertWorkerPathParameter(string source, string name, int position)
    {
        var lines = source.ReplaceLineEndings("\n").Split('\n');
        var index = Array.FindIndex(lines, line => line.Contains("public string " + name + " { get; set; }", StringComparison.Ordinal));
        Assert.True(index > 0, "Missing worker path parameter " + name);
        Assert.Contains("[Parameter(", lines[index - 1]);
        Assert.Contains("Mandatory = true", lines[index - 1]);
        Assert.Contains("Position = " + position, lines[index - 1]);
    }

    private static void AssertSelectionContract(string source, string defaultRoute)
    {
        Assert.Contains("new Dictionary<string, object>(MyInvocation.BoundParameters", source);
        Assert.Contains("parameters.Remove(\"Route\")", source);
        Assert.Contains("\"Published\"", source);
        Assert.Contains("if (publishedRoute\n                    ? !string.Equals(candidate.Label, \"" + defaultRoute
            + "\", StringComparison.OrdinalIgnoreCase)", source.ReplaceLineEndings("\n"));
        Assert.DoesNotContain("? !string.Equals(candidate.Shape, ParameterSetName", source);
        Assert.Contains("candidate.Required", source);
        Assert.Contains("parameters.ContainsKey(requiredParameter)", source);
        Assert.Contains("candidate.Allowed", source);
        Assert.Contains("InvalidGraphRouteParameters", source);
        Assert.Contains("\"param($BoundParameters, $CmdletName) & $CmdletName @BoundParameters\"", source);
        Assert.Contains("parameters, internalCmdletName", source);
        Assert.DoesNotContain("dynamic", source);
        Assert.DoesNotContain("System.Reflection", source);
    }

    private static void AssertRouteCandidate(string source, string label, string shape, string[] allowed, string[] required)
    {
        var line = Assert.Single(source.ReplaceLineEndings("\n").Split('\n'),
            candidate => candidate.Contains($"(\"{label}\", \"{shape}\", ", StringComparison.Ordinal));
        static string ArrayLiteral(string[] names) => "new string[] { " + string.Join(", ", names.Select(name => "\"" + name + "\"")) + " }";
        Assert.EndsWith(", " + ArrayLiteral(allowed) + ", " + ArrayLiteral(required) + "),", line.Trim());
    }

    private static async Task<Dictionary<string, string>> Generate(OpenApiDocument document, MultiRouteGroup group)
    {
        var output = Path.Combine(Directory.GetCurrentDirectory(), ".explicit-route-tests-" + Guid.NewGuid().ToString("N"));
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
