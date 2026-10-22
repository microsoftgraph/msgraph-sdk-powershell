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

    [Theory]
    [InlineData("v1.0", 63, "InvokeMgQuerySearch.g.cs")]
    [InlineData("beta", 145, "InvokeMgSearchQuery.g.cs")]
    public async Task CompatibleProfilesKeepExistingOperationsAndNames(
        string profile, int operationCount, string queryFile)
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
        var config = new GeneratorConfig("Microsoft.Graph.PowerShell.Search.Client", output, profile);
        foreach (var (path, item) in document.Paths)
        {
            Assert.NotNull(item.Operations);
            foreach (var method in item.Operations.Keys)
            {
                Assert.False(CmdletConfigurator.IsSuppressed(method, path));
                Assert.False(CmdletConfigurator.IsSuppressed(method, path, config));
            }
        }

        AssertOperation(document, HttpMethod.Get, "/external/connections", "external.ListConnections");
        AssertOperation(document, HttpMethod.Get, ConnectionPath, "external.GetConnections");
        AssertOperation(document, HttpMethod.Post, "/external/connections", "external.CreateConnections");
        AssertOperation(document, HttpMethod.Patch, ConnectionPath, "external.UpdateConnections");
        AssertOperation(document, HttpMethod.Delete, ConnectionPath, "external.DeleteConnections");
        AssertOperation(document, HttpMethod.Put, ItemPath, "external.connections.SetItems");
        AssertOperation(document, HttpMethod.Get, SchemaPath, "external.connections.GetSchema");
        AssertOperation(document, HttpMethod.Patch, SchemaPath, "external.connections.UpdateSchema");
        AssertOperation(document, HttpMethod.Get, "/search/bookmarks", "search.ListBookmarks");
        AssertOperation(document, HttpMethod.Get, "/search/bookmarks/{bookmark-id}", "search.GetBookmarks");
        AssertOperation(document, HttpMethod.Post, "/search/query", "search.query");

        if (profile == "beta")
        {
            AssertOperation(document, HttpMethod.Get, QuotaPath, "external.connections.GetQuota");
            AssertOperation(document, HttpMethod.Patch, QuotaPath, "external.connections.UpdateQuota");
            AssertOperation(document, HttpMethod.Delete, QuotaPath, "external.connections.DeleteQuota");
        }
        else
        {
            Assert.False(document.Paths.ContainsKey(QuotaPath));
        }

        var reviewedPaths = new OpenApiPaths();
        foreach (var path in new[]
        {
            "/external/connections", ConnectionPath, ItemPath, SchemaPath,
            "/search/bookmarks", "/search/bookmarks/{bookmark-id}", "/search/query",
        })
            reviewedPaths.Add(path, document.Paths[path]);
        if (profile == "beta")
            reviewedPaths.Add(QuotaPath, document.Paths[QuotaPath]);
        // Keep real operations and schemas, but isolate emission from unrelated beta IndustryData collisions.
        document.Paths = reviewedPaths;

        try
        {
            var service = new PowerShellWrapperGenerationService(document, config, NullLogger.Instance);
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
                profile == "v1.0" ? "InvokeMgSearchQuery.g.cs" : "InvokeMgQuerySearch.g.cs")));

            if (profile == "beta")
            {
                AssertEmitted(output, "GetMgExternalConnectionQuota.g.cs", "GET", QuotaPath);
                AssertEmitted(output, "UpdateMgExternalConnectionQuota.g.cs", "PATCH", QuotaPath);
                AssertEmitted(output, "RemoveMgExternalConnectionQuota.g.cs", "DELETE", QuotaPath);
            }
            else
            {
                Assert.Empty(Directory.GetFiles(output, "*MgExternalConnectionQuota.g.cs"));
            }
        }
        finally
        {
            if (Directory.Exists(output))
                Directory.Delete(output, recursive: true);
        }
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
        Assert.Contains($"[GraphRoute(\"{method}\", \"{path}\")]", File.ReadAllText(file));
    }

    private static string FindRepoRoot()
    {
        var directory = AppContext.BaseDirectory;
        while (directory is not null && !File.Exists(Path.Combine(directory, "src", "Search", "Search.md")))
            directory = Path.GetDirectoryName(directory);
        return directory ?? throw new InvalidOperationException("Repository root not found from test base directory.");
    }
}
