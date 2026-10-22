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

public sealed class DerivedRouteOptInTests
{
    private const string Client = "Microsoft.Graph.PowerShell.Test.Client";
    private const string Root = "/groups/{group-id}/onenote/sectionGroups";
    private const string Item = Root + "/{sectionGroup-id}";
    private const string Nested = Item + "/sectionGroups";
    private const string NestedItem = Nested + "/{sectionGroup-id1}";

    [Fact]
    public async Task DerivedSuppressedMembersStillMakeAReviewedGroupIncompleteByDefault()
    {
        var (document, group) = NotesFixture();
        var config = Config("unused", group);
        Assert.False(group.IncludeDerivedSuppressedRoutes);
        Assert.False(CmdletConfigurator.IsCuratedSuppressed(HttpMethod.Get, Nested));
        Assert.True(CmdletConfigurator.IsSuppressed(HttpMethod.Get, Nested, config));

        var error = await Assert.ThrowsAsync<InvalidOperationException>(() => Generate(document, group));

        Assert.Contains("incomplete", error.Message, StringComparison.OrdinalIgnoreCase);
        Assert.Contains(Nested, error.Message);
    }

    [Fact]
    public async Task ExplicitDerivedAllowanceRestoresOnlyTheExactReviewedMembers()
    {
        var (document, group) = NotesFixture();
        group = group with { IncludeDerivedSuppressedRoutes = true };
        Add(document, NestedItem, Response(document, list: false));
        var config = Config("unused", group);
        Assert.False(CmdletConfigurator.IsCuratedSuppressed(HttpMethod.Get, NestedItem));
        Assert.True(CmdletConfigurator.IsSuppressed(HttpMethod.Get, NestedItem, config));

        var files = await Generate(document, group);

        Assert.Equal(4, files.Count);
        var source = PublicSource(files);
        Assert.Contains("DefaultParameterSetName = \"Route\"", source);
        Assert.Contains("[ValidateSet(\"Published\", \"Root\", \"Nested\")]", source);
        foreach (var route in group.Routes)
        {
            Assert.Contains($"[GraphRoute(\"GET\", \"{route.Path}\", ParameterSetName = \"Route\")]", source);
            var worker = Assert.Single(files.Values, worker => worker.Contains($"[GraphRoute(\"GET\", \"{route.Path}\")]", StringComparison.Ordinal));
            Assert.Contains($"[OutputType(typeof({Client}.Models.SectionGroup))]", worker);
        }
        Assert.Contains("client.Groups[GroupId].Onenote.SectionGroups[SectionGroupId].SectionGroups.GetAsync(",
            string.Join("\n", files.Values));
        Assert.DoesNotContain(NestedItem, string.Join("\n", files.Values));
        Assert.True(CmdletConfigurator.IsSuppressed(HttpMethod.Get, Nested, config));
        Assert.True(CmdletConfigurator.IsSuppressed(HttpMethod.Get, NestedItem, config));
    }

    [Fact]
    public async Task BetaWithoutDerivedSuppressionDoesNotNeedOrChangeWithTheAllowance()
    {
        var (document, group) = NotesFixture();
        group = group with { ApiVersion = "beta" };
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get, Nested, Config("unused", group, "beta")));

        var defaultFiles = await Generate(document, group, "beta");
        var optedInFiles = await Generate(document, group with { IncludeDerivedSuppressedRoutes = true }, "beta");

        Assert.Equal(4, defaultFiles.Count);
        Assert.Equal(defaultFiles.Keys.Order(), optedInFiles.Keys.Order());
        foreach (var file in defaultFiles)
            Assert.Equal(file.Value, optedInFiles[file.Key]);
        Assert.Contains($"[GraphRoute(\"GET\", \"{Nested}\", ParameterSetName = \"Route\")]", PublicSource(defaultFiles));
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public async Task DerivedAllowanceNeverRestoresACuratedSuppression(bool includeDerived)
    {
        var document = Document();
        const string legacy = "/bookingBusinesses/{bookingBusiness-id}";
        Add(document, legacy, Response(document, list: false));
        Add(document, "/solutions", Response(document, list: false));
        var group = new MultiRouteGroup("v1.0",
            [new("GET", legacy, "Legacy"), new("GET", "/solutions", "Solutions")], "Legacy", "Route")
        {
            IncludeDerivedSuppressedRoutes = includeDerived,
        };
        Assert.True(CmdletConfigurator.IsCuratedSuppressed(HttpMethod.Get, "/solutions"));
        Assert.True(CmdletConfigurator.IsSuppressed(HttpMethod.Get, "/solutions", Config("unused", group)));

        var error = await Assert.ThrowsAsync<InvalidOperationException>(() => Generate(document, group));

        Assert.Contains("incomplete", error.Message, StringComparison.OrdinalIgnoreCase);
        Assert.Contains("/solutions", error.Message);
        Assert.DoesNotContain("same public command", error.Message, StringComparison.OrdinalIgnoreCase);
    }

    [Fact]
    public async Task AnotherProfilesAllowanceCannotRestoreDerivedSuppressedOperations()
    {
        var (document, group) = NotesFixture();
        group = group with { ApiVersion = "beta", IncludeDerivedSuppressedRoutes = true };

        var files = await Generate(document, group, "v1.0");

        Assert.Equal(3, files.Count);
        var source = string.Join("\n", files.Values);
        Assert.DoesNotContain(Nested, source);
        Assert.DoesNotContain("public string Route", source);
        Assert.DoesNotContain("_Route", string.Join("\n", files.Keys));
        Assert.Contains("DefaultParameterSetName = \"List\"", source);
        Assert.True(CmdletConfigurator.IsSuppressed(HttpMethod.Get, Nested, Config("unused", group)));
    }

    [Fact]
    public async Task AnAbsentReviewedGroupIsStillANoOpWithTheAllowance()
    {
        var (_, group) = NotesFixture();
        group = group with { IncludeDerivedSuppressedRoutes = true };
        var document = Document();
        Add(document, "/widgets/{widget-id}", Response(document, list: false));

        var files = await Generate(document, group);

        var source = Assert.Single(files).Value;
        Assert.Contains("[GraphRoute(\"GET\", \"/widgets/{widget-id}\")]", source);
        Assert.DoesNotContain("public string Route", source);
        Assert.DoesNotContain(Root, source);
    }

    private static (OpenApiDocument Document, MultiRouteGroup Group) NotesFixture()
    {
        var document = Document();
        var routes = new[]
        {
            new MultiRoute("GET", Root, "Root"),
            new MultiRoute("GET", Item, "Root"),
            new MultiRoute("GET", Nested, "Nested"),
        };
        for (var i = 0; i < routes.Length; i++)
            Add(document, routes[i].Path, Response(document, list: i != 1));
        return (document, new MultiRouteGroup("v1.0", routes, "Root", "Route")
        {
            AllowAsymmetricRoutes = true,
            AllowExplicitRouteSelection = true,
            AllowPublishedParameterInference = true,
        });
    }

    private static OpenApiDocument Document() => new()
    {
        Paths = new OpenApiPaths(),
        Components = new OpenApiComponents
        {
            Schemas = new Dictionary<string, IOpenApiSchema>
            {
                ["microsoft.graph.sectionGroup"] = new OpenApiSchema
                {
                    Type = JsonSchemaType.Object,
                    Properties = new Dictionary<string, IOpenApiSchema> { ["id"] = new OpenApiSchema { Type = JsonSchemaType.String } },
                },
            },
        },
    };

    private static OpenApiOperation Response(OpenApiDocument document, bool list)
    {
        var entity = new OpenApiSchemaReference("microsoft.graph.sectionGroup", document);
        return new OpenApiOperation
        {
            Responses = new OpenApiResponses
            {
                ["200"] = new OpenApiResponse
                {
                    Content = new Dictionary<string, IOpenApiMediaType>
                    {
                        ["application/json"] = new OpenApiMediaType
                        {
                            Schema = list ? new OpenApiSchema
                            {
                                Type = JsonSchemaType.Object,
                                Properties = new Dictionary<string, IOpenApiSchema>
                                {
                                    ["value"] = new OpenApiSchema { Type = JsonSchemaType.Array, Items = entity },
                                },
                            } : entity,
                        },
                    },
                },
            },
        };
    }

    private static void Add(OpenApiDocument document, string path, OpenApiOperation operation) =>
        document.Paths[path] = new OpenApiPathItem
        {
            Operations = new Dictionary<HttpMethod, OpenApiOperation> { [HttpMethod.Get] = operation },
        };

    private static GeneratorConfig Config(string output, MultiRouteGroup group, string apiVersion = "v1.0") =>
        new(Client, output, ApiVersion: apiVersion, UseCollisionData: true, MultiRouteGroups: [group]);

    private static string PublicSource(Dictionary<string, string> files) =>
        Assert.Single(files, file => !file.Key.Contains("_Route", StringComparison.Ordinal)).Value;

    private static async Task<Dictionary<string, string>> Generate(
        OpenApiDocument document, MultiRouteGroup group, string apiVersion = "v1.0")
    {
        var output = Path.Combine(Directory.GetCurrentDirectory(), ".derived-route-tests-" + Guid.NewGuid().ToString("N"));
        try
        {
            document.RegisterComponents();
            await new PowerShellWrapperGenerationService(document, Config(output, group, apiVersion), NullLogger.Instance)
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
