using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Reader;
using WrapperGenerator;
using Xunit;

namespace WrapperGenerator.Tests;

public sealed class SearchDirectiveMigrationTests
{
    private const string ConnectionPath = "/external/connections/{externalConnection-id}";
    private const string ItemPath = ConnectionPath + "/items/{externalItem-id}";
    private const string SchemaPath = ConnectionPath + "/schema";
    private const string QuotaPath = ConnectionPath + "/quota";
    private const string RunsPath = "/external/industryData/runs";
    private const string RunPath = RunsPath + "/{industryDataRun-id}";
    private const string StatisticsFunction = "/microsoft.graph.industryData.getStatistics()";
    private const string RunActivitiesPath = RunPath + "/activities";
    private const string RunActivityPath = RunActivitiesPath + "/{industryDataRunActivity-id}";
    private const string ActivityPath = RunActivityPath + "/activity";

    [Fact]
    public void SharedPlaceholderHasNoDirectivesOrInventedMappings()
    {
        var root = FindRepoRoot();
        var shared = File.ReadAllText(Path.Combine(root, "src", "Search", "Search.md"));
        Assert.DoesNotMatch(@"(?m)^\s*directive:\s*$", shared);
        Assert.Contains("# Directives go here!", shared);

        using var ledger = JsonDocument.Parse(File.ReadAllText(Path.Combine(
            root, "src", "Search", "wrapper", "Search_directiveMigrationMap.json")));
        Assert.Empty(ledger.RootElement.GetProperty("mappings").EnumerateArray());
    }

    [Fact]
    public async Task BetaIndustryDataDescriptionsDistinguishDifferentOperations()
    {
        var settings = new OpenApiReaderSettings();
        settings.AddYamlReader();
        using var stream = File.OpenRead(Path.Combine(
            FindRepoRoot(), "openApiDocs_KiotaCompat", "beta", "Search.yml"));
        var result = await OpenApiDocument.LoadAsync(
            stream, settings: settings, cancellationToken: CancellationToken.None);
        Assert.NotNull(result.Document);
        var document = result.Document;

        foreach (var path in new[] { RunsPath + StatisticsFunction, RunPath + StatisticsFunction })
        {
            var item = document.Paths[path];
            var operation = item.Operations![HttpMethod.Get];
            Assert.NotNull(operation.Extensions);
            var kind = Assert.IsType<JsonNodeExtension>(operation.Extensions["x-ms-docs-operation-type"]);
            Assert.Equal("function", kind.Node!.ToString());
            Assert.EndsWith("getStatistics()", path);
            Assert.DoesNotContain((item.Parameters ?? []).Concat(operation.Parameters ?? []),
                parameter => parameter.In is ParameterLocation.Query or ParameterLocation.Header);
            Assert.Null(operation.RequestBody);
            var response = operation.Responses!["2XX"].Content!["application/json"].Schema!;
            var reference = Assert.Single(response.AnyOf!, schema => schema.GetReferenceId() is not null);
            Assert.Equal("microsoft.graph.industryData.industryDataRunStatistics", reference.GetReferenceId());
        }

        foreach (var (path, schemaName) in new[]
        {
            (RunActivityPath, "microsoft.graph.industryData.industryDataRunActivity"),
            (ActivityPath, "microsoft.graph.industryData.industryDataActivity"),
        })
        {
            var operation = document.Paths[path].Operations![HttpMethod.Get];
            var parameters = operation.Parameters ?? [];
            Assert.Equal(new[] { "$expand", "$select" },
                parameters.Where(parameter => parameter.In == ParameterLocation.Query)
                    .Select(parameter => parameter.Name).OrderBy(name => name, StringComparer.Ordinal));
            Assert.DoesNotContain(parameters, parameter => parameter.In == ParameterLocation.Header || parameter.Required);
            Assert.Equal(schemaName,
                operation.Responses!["2XX"].Content!["application/json"].Schema!.GetReferenceId());
        }
        Assert.Equal("Get statistics for an industryDataRun.",
            document.Paths[RunPath + StatisticsFunction].Operations![HttpMethod.Get].Description);
        Assert.Equal("The flow that was run by this activity.",
            document.Paths[ActivityPath].Operations![HttpMethod.Get].Description);
    }

    [Theory]
    [InlineData("v1.0", true, 63, "InvokeMgQuerySearch.g.cs")]
    [InlineData("v1.0", false, 63, "InvokeMgSearchQuery.g.cs")]
    [InlineData("beta", true, 145, "InvokeMgSearchQuery.g.cs")]
    [InlineData("beta", false, 145, "InvokeMgSearchQuery.g.cs")]
    public async Task CompatibleProfilesKeepExistingOperationsAndNames(
        string profile, bool useCollisionData, int operationCount, string queryFile)
    {
        var settings = new OpenApiReaderSettings();
        settings.AddYamlReader();
        using var stream = File.OpenRead(Path.Combine(
            FindRepoRoot(), "openApiDocs_KiotaCompat", profile, "Search.yml"));
        var result = await OpenApiDocument.LoadAsync(
            stream, settings: settings, cancellationToken: CancellationToken.None);
        Assert.NotNull(result.Document);
        var document = result.Document;
        Assert.Equal(operationCount, document.Paths.Sum(path => path.Value.Operations?.Count ?? 0));

        var output = Path.Combine(Path.GetTempPath(), "search-directive-tests", Guid.NewGuid().ToString("N"));
        var config = new GeneratorConfig("Microsoft.Graph.PowerShell.Search.Client", output, useCollisionData);
        foreach (var (path, item) in document.Paths)
        {
            Assert.NotNull(item.Operations);
            foreach (var method in item.Operations.Keys)
            {
                Assert.False(CmdletConfigurator.IsSuppressed(method, path, apiVersion: profile));
                Assert.False(CmdletConfigurator.IsSuppressed(method, path, config, apiVersion: profile));
            }
        }

        AssertOperation(document, HttpMethod.Get, "/external/connections", "external_ListConnection");
        AssertOperation(document, HttpMethod.Get, ConnectionPath, "external_GetConnection");
        AssertOperation(document, HttpMethod.Post, "/external/connections", "external_CreateConnection");
        AssertOperation(document, HttpMethod.Patch, ConnectionPath, "external_UpdateConnection");
        AssertOperation(document, HttpMethod.Delete, ConnectionPath, "external_DeleteConnection");
        AssertOperation(document, HttpMethod.Put, ItemPath, "external.connection_SetItem");
        AssertOperation(document, HttpMethod.Get, SchemaPath, "external.connection_GetSchema");
        AssertOperation(document, HttpMethod.Patch, SchemaPath, "external.connection_UpdateSchema");
        AssertOperation(document, HttpMethod.Get, "/search/bookmarks", "search_ListBookmark");
        AssertOperation(document, HttpMethod.Get, "/search/bookmarks/{bookmark-id}", "search_GetBookmark");
        AssertOperation(document, HttpMethod.Post, "/search/query", "search_query");

        if (profile == "beta")
        {
            AssertOperation(document, HttpMethod.Get, QuotaPath, "external.connection_GetQuota");
            AssertOperation(document, HttpMethod.Patch, QuotaPath, "external.connection_UpdateQuota");
            AssertOperation(document, HttpMethod.Delete, QuotaPath, "external.connection_DeleteQuota");
            AssertOperation(document, HttpMethod.Get, RunsPath + StatisticsFunction,
                "external.industryData.run_getStatistics");
            AssertOperation(document, HttpMethod.Get, RunPath + StatisticsFunction,
                "external.industryData.run.industryDataRun_getStatistics");
            AssertOperation(document, HttpMethod.Get, RunActivitiesPath, "external.industryData.run_ListActivity");
            AssertOperation(document, HttpMethod.Get, RunActivityPath, "external.industryData.run_GetActivity");
            AssertOperation(document, HttpMethod.Get, ActivityPath, "external.industryData.run.activity_GetActivity");
        }
        else
        {
            Assert.False(document.Paths.ContainsKey(QuotaPath));
            Assert.DoesNotContain(document.Paths.Keys, path => path.StartsWith(RunsPath, StringComparison.Ordinal));
        }

        try
        {
            var service = new PowerShellWrapperGenerationService(document, config, NullLogger.Instance, apiVersion: profile);
            await service.GenerateAsync(CancellationToken.None);

            AssertEmitted(output, "GetMgExternalConnection_List.g.cs", "GET", "/external/connections");
            AssertEmitted(output, "GetMgExternalConnection_Get.g.cs", "GET", ConnectionPath);
            AssertEmitted(output, "NewMgExternalConnection.g.cs", "POST", "/external/connections");
            AssertEmitted(output, "UpdateMgExternalConnection.g.cs", "PATCH", ConnectionPath);
            AssertEmitted(output, "RemoveMgExternalConnection.g.cs", "DELETE", ConnectionPath);
            AssertEmitted(output, "SetMgExternalConnectionItem.g.cs", "PUT", ItemPath);
            AssertEmitted(output, "GetMgExternalConnectionSchema.g.cs", "GET", SchemaPath);
            AssertEmitted(output, "UpdateMgExternalConnectionSchema.g.cs", "PATCH", SchemaPath);
            AssertEmitted(output, "GetMgSearchBookmark_List.g.cs", "GET", "/search/bookmarks");
            AssertEmitted(output, "GetMgSearchBookmark_Get.g.cs", "GET", "/search/bookmarks/{bookmark-id}");
            AssertEmitted(output, queryFile, "POST", "/search/query");
            Assert.False(File.Exists(Path.Combine(output,
                queryFile == "InvokeMgQuerySearch.g.cs" ? "InvokeMgSearchQuery.g.cs" : "InvokeMgQuerySearch.g.cs")));

            if (profile == "beta")
            {
                AssertEmitted(output, "GetMgExternalConnectionQuota.g.cs", "GET", QuotaPath);
                AssertEmitted(output, "UpdateMgExternalConnectionQuota.g.cs", "PATCH", QuotaPath);
                AssertEmitted(output, "RemoveMgExternalConnectionQuota.g.cs", "DELETE", QuotaPath);
                AssertIndustryDataCommands(output);
            }
            else
            {
                Assert.Empty(Directory.GetFiles(output, "*MgExternalConnectionQuota.g.cs"));
                Assert.Empty(Directory.GetFiles(output, "*MgExternalIndustryData*.g.cs"));
            }
        }
        finally
        {
            if (Directory.Exists(output))
                Directory.Delete(output, recursive: true);
        }
    }

    [Theory]
    [InlineData("v1.0", true)]
    [InlineData("v1.0", false)]
    [InlineData("beta", true)]
    [InlineData("beta", false)]
    public void SharedRepairsUseSeparateRuntimeProfile(string profile, bool useCollisionData)
    {
        var config = new GeneratorConfig("Test.Client", "unused", useCollisionData);
        foreach (var (path, kind, expected) in new[]
        {
            (RunPath + StatisticsFunction, OperationKind.Function, "ExternalIndustryDataRunStatistics"),
            (RunsPath + StatisticsFunction, OperationKind.Function, "ExternalIndustryDataRunGetStatistics"),
            (ActivityPath, OperationKind.Resource, "ExternalIndustryDataRunActivityFlow"),
            (RunActivityPath, OperationKind.Resource, "ExternalIndustryDataRunActivity"),
        })
        {
            var naming = Naming.Resolve(new OperationInfo(HttpMethod.Get, path, Kind: kind), config, apiVersion: profile);
            Assert.Equal("Mg" + expected, naming.Noun);
            Assert.Equal(expected, CmdletConfigurator.ApplyNounOverrides(HttpMethod.Get, path, expected, config, apiVersion: profile));
            Assert.Null(CmdletConfigurator.TryGetOverriddenVerb(HttpMethod.Get, path, config, apiVersion: profile));
            Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get, path, config, apiVersion: profile));
            Assert.Empty(naming.FunctionParameters);
        }
    }

    private static void AssertIndustryDataCommands(string output)
    {
        const string statistics = "GetMgExternalIndustryDataRunStatistics";
        const string activity = "GetMgExternalIndustryDataRunActivity";
        AssertEmitted(output, statistics + ".g.cs", "GET", RunPath + StatisticsFunction);
        AssertEmitted(output, "GetMgExternalIndustryDataRunGetStatistics.g.cs", "GET", RunsPath + StatisticsFunction);
        AssertEmitted(output, activity + "_List.g.cs", "GET", RunActivitiesPath);
        AssertEmitted(output, activity + "_Get.g.cs", "GET", RunActivityPath);
        AssertEmitted(output, activity + "Flow.g.cs", "GET", ActivityPath);
        var activityDispatcher = File.ReadAllText(Path.Combine(output, activity + ".g.cs"));
        Assert.Contains("DefaultParameterSetName = \"List\"", activityDispatcher);
        Assert.DoesNotContain("public string Route", activityDispatcher);
        Assert.Empty(Directory.GetFiles(output, "*MgExternalIndustryData*_Route*.g.cs"));
        var runActivityWorker = File.ReadAllText(Path.Combine(output, activity + "_Get.g.cs"));
        var nestedActivityWorker = File.ReadAllText(Path.Combine(output, activity + "Flow.g.cs"));
        Assert.Contains(".IndustryDataRunActivity)", runActivityWorker);
        Assert.DoesNotContain(".IndustryDataActivity)", runActivityWorker);
        Assert.Contains(".IndustryDataActivity)", nestedActivityWorker);
        Assert.DoesNotContain(".IndustryDataRunActivity)", nestedActivityWorker);
    }

    private static void AssertOperation(OpenApiDocument document, HttpMethod method, string path, string operationId)
    {
        Assert.True(document.Paths.TryGetValue(path, out var item), $"Missing compatible path: {path}");
        Assert.NotNull(item.Operations);
        Assert.True(item.Operations.TryGetValue(method, out var operation), $"Missing compatible operation: {method} {path}");
        Assert.Equal(operationId, operation.OperationId);
    }

    private static void AssertEmitted(string output, string fileName, string method, string path)
    {
        var file = Path.Combine(output, fileName);
        Assert.True(File.Exists(file), $"Expected existing Search cmdlet: {fileName}");
        Assert.Contains($"[GraphRoute(\"{method}\", \"{path}\"", File.ReadAllText(file));
    }

    private static string FindRepoRoot()
    {
        var directory = AppContext.BaseDirectory;
        while (directory is not null && !File.Exists(Path.Combine(directory, "src", "Search", "Search.md")))
            directory = Path.GetDirectoryName(directory);
        return directory ?? throw new InvalidOperationException("Repository root not found from test base directory.");
    }
}
