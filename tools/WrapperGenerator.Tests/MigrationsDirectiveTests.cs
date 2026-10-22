using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.OpenApi;
using Microsoft.OpenApi.MicrosoftExtensions;
using Microsoft.OpenApi.Reader;
using WrapperGenerator;
using Xunit;

namespace WrapperGenerator.Tests;

public sealed class MigrationsDirectiveTests
{
    private const string Jobs = "/solutions/migrations/crossTenantMigrationJobs";
    private const string Job = Jobs + "/{crossTenantMigrationJob-id}";
    private const string Users = Job + "/users";
    private const string User = Users + "/{crossTenantMigrationTask-id}";
    private const string DisplayName = Jobs + "(displayName='{displayName}')";

    [Theory]
    [InlineData("GET", "/solutions/migrations")]
    [InlineData("PATCH", "/solutions/migrations")]
    [InlineData("DELETE", "/solutions/migrations")]
    [InlineData("GET", DisplayName)]
    [InlineData("PATCH", DisplayName)]
    [InlineData("DELETE", DisplayName)]
    [InlineData("POST", DisplayName + "/cancel")]
    [InlineData("POST", DisplayName + "/migrate")]
    [InlineData("POST", DisplayName + "/validate")]
    [InlineData("GET", Jobs + "/$count")]
    [InlineData("GET", Users + "/$count")]
    [InlineData("DELETE", User)]
    [InlineData("POST", Users)]
    [InlineData("PATCH", User)]
    public void SuppressesOnlyReviewedOperations(string method, string path)
    {
        Assert.True(CmdletConfigurator.IsSuppressed(new HttpMethod(method), path));
        Assert.True(CmdletConfigurator.IsSuppressed(new HttpMethod(method), path, Beta()));
    }

    [Theory]
    [InlineData("GET", Jobs, "Get", "MgCrossTenantMigrationJob", OperationKind.Resource)]
    [InlineData("GET", Job, "Get", "MgCrossTenantMigrationJob", OperationKind.Resource)]
    [InlineData("POST", Jobs, "New", "MgCrossTenantMigrationJob", OperationKind.Resource)]
    [InlineData("PATCH", Job, "Update", "MgCrossTenantMigrationJob", OperationKind.Resource)]
    [InlineData("DELETE", Job, "Remove", "MgCrossTenantMigrationJob", OperationKind.Resource)]
    [InlineData("GET", Users, "Get", "MgCrossTenantMigrationJobUser", OperationKind.Resource)]
    [InlineData("GET", User, "Get", "MgCrossTenantMigrationJobUser", OperationKind.Resource)]
    [InlineData("POST", Job + "/cancel", "Stop", "MgCrossTenantMigrationJob", OperationKind.Action)]
    [InlineData("POST", Job + "/migrate", "Move", "MgCrossTenantMigrationJob", OperationKind.Action)]
    [InlineData("POST", Job + "/validate", "Test", "MgCrossTenantMigrationJob", OperationKind.Action)]
    [InlineData("POST", User + "/cancel", "Stop", "MgCrossTenantMigrationJobUser", OperationKind.Action)]
    public void PreservesBothReadRoutesAndPublishedActionNames(
        string method, string path, string verb, string noun, OperationKind kind)
    {
        foreach (var useCollisionData in new[] { false, true })
        {
            var config = Beta(useCollisionData);
            Assert.False(CmdletConfigurator.IsSuppressed(new HttpMethod(method), path, config));
            var naming = Naming.Resolve(new OperationInfo(new HttpMethod(method), path, Kind: kind), config);
            Assert.Equal(verb, naming.VerbName);
            Assert.Equal(noun, naming.Noun);
        }
    }

    [Theory]
    [InlineData("GET", Job + "/usersExtra")]
    [InlineData("DELETE", Job + "/usersExtra/{id}")]
    [InlineData("POST", "/solutions/migrations/crossTenantMigrationJobsExtra")]
    [InlineData("GET", "/solutions/backupRestore")]
    [InlineData("GET", "/solutions/bookingBusinesses")]
    public void LeavesNeighboringRoutesUnchanged(string method, string path)
    {
        var httpMethod = new HttpMethod(method);
        Assert.False(CmdletConfigurator.IsSuppressed(httpMethod, path, Beta()));
        Assert.Null(CmdletConfigurator.TryGetOverriddenVerb(httpMethod, path, Beta()));
        Assert.Equal("Neighbor", CmdletConfigurator.ApplyNounOverrides(httpMethod, path, "Neighbor", Beta()));
    }

    [Fact]
    public async Task LedgerAccountsForEveryActualLegacyAndCompatibleOperation()
    {
        var root = FindRepoRoot();
        var legacy = await ReadSpec(Path.Combine(root, "openApiDocs", "beta", "Migrations.yml"));
        var compatible = await ReadSpec(Path.Combine(root, "openApiDocs_KiotaCompat", "beta", "Migrations.yml"));
        using var ledger = JsonDocument.Parse(await File.ReadAllTextAsync(
            Path.Combine(root, "src", "Migrations", "wrapper", "Migrations_directiveMigrationMap.json"),
            TestContext.Current.CancellationToken));
        var mappings = ledger.RootElement.GetProperty("mappings").EnumerateArray().ToArray();
        Assert.Equal(4, mappings.Length);
        Assert.All(mappings, mapping => Assert.True(
            mapping.GetProperty("profiles").GetProperty("v1.0").GetProperty("excluded").GetBoolean()));
        var evidence = mappings.SelectMany(mapping => mapping.GetProperty("profiles")
            .GetProperty("beta").GetProperty("operations").EnumerateArray()).ToArray();
        var operations = compatible.Paths.SelectMany(path => path.Value.Operations!.Select(operation =>
            (Path: path.Key, Method: operation.Key, Operation: operation.Value))).ToArray();
        Assert.Equal(25, operations.Length);
        Assert.Equal(25, legacy.Paths.Sum(path => path.Value.Operations!.Count));
        Assert.Equal(25, evidence.Select(row => (row.GetProperty("method").GetString(),
            row.GetProperty("path").GetString())).Distinct().Count());
        foreach (var row in evidence)
        {
            var path = row.GetProperty("path").GetString()!;
            var method = new HttpMethod(row.GetProperty("method").GetString()!);
            var actual = Assert.Single(operations, operation => operation.Path == path && operation.Method == method);
            Assert.Equal(row.GetProperty("operationId").GetString(), actual.Operation.OperationId);
        }
        var lineage = ledger.RootElement.GetProperty("audit").GetProperty("legacyOperations").EnumerateArray().ToArray();
        Assert.Equal(25, lineage.Length);
        Assert.Equal(25, lineage.Select(row => (row.GetProperty("method").GetString(),
            row.GetProperty("path").GetString())).Distinct().Count());
        var convertedActions = 0;
        foreach (var row in lineage)
        {
            var path = row.GetProperty("path").GetString()!;
            var method = new HttpMethod(row.GetProperty("method").GetString()!);
            var old = legacy.Paths[path].Operations![method];
            Assert.Equal(row.GetProperty("operationId").GetString(), old.OperationId);
            var finalSlash = path.LastIndexOf('/');
            var translatedPath = path;
            if (path[(finalSlash + 1)..].StartsWith("microsoft.graph.", StringComparison.Ordinal))
            {
                Assert.Equal(HttpMethod.Post, method);
                AssertAction(old);
                translatedPath = path[..(finalSlash + 1)] + path[(finalSlash + 1 + "microsoft.graph.".Length)..];
                convertedActions++;
            }
            var current = Assert.Single(operations, operation =>
                operation.Path == translatedPath && operation.Method == method).Operation;
            if (translatedPath != path) AssertAction(current);
            Assert.NotEqual(old.OperationId, current.OperationId);
        }
        Assert.Equal(7, convertedActions);
        var suppressed = operations.Where(operation =>
            CmdletConfigurator.IsSuppressed(operation.Method, operation.Path, Beta())).ToArray();
        Assert.Equal(14, suppressed.Length);
        var removals = mappings.Skip(1).SelectMany(mapping => mapping.GetProperty("profiles")
            .GetProperty("beta").GetProperty("operations").EnumerateArray()).ToArray();
        Assert.Equal(14, removals.Length);
        Assert.All(suppressed, operation => Assert.Single(removals, row =>
            row.GetProperty("path").GetString() == operation.Path &&
            row.GetProperty("method").GetString() == operation.Method.Method));
    }

    private static GeneratorConfig Beta(bool useCollisionData = true) =>
        new("Microsoft.Graph.PowerShell.Migrations.Client", "unused", "beta", useCollisionData);

    private static async Task<OpenApiDocument> ReadSpec(string path)
    {
        var settings = new OpenApiReaderSettings();
        settings.AddYamlReader();
        using var stream = File.OpenRead(path);
        return (await OpenApiDocument.LoadAsync(stream, settings: settings,
            cancellationToken: TestContext.Current.CancellationToken)).Document!;
    }

    private static void AssertAction(OpenApiOperation operation)
    {
        var extension = Assert.IsType<JsonNodeExtension>(operation.Extensions!["x-ms-docs-operation-type"]);
        Assert.Equal("action", extension.Node!.ToString().Trim('"'));
    }

    private static string FindRepoRoot()
    {
        for (var dir = new DirectoryInfo(AppContext.BaseDirectory); dir is not null; dir = dir.Parent)
            if (Directory.Exists(Path.Combine(dir.FullName, "openApiDocs_KiotaCompat")))
                return dir.FullName;
        throw new DirectoryNotFoundException("Could not find the repository's compatible specs.");
    }
}
