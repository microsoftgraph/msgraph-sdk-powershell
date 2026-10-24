using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Reader;
using WrapperGenerator;
using Xunit;

namespace WrapperGenerator.Tests;

public sealed class ConfigurationManagementDirectiveMigrationTests
{
    private const string Root = "/admin/configurationManagement/";
    private const string OperationPrefix = "admin.configurationManagement.";
    private const string NounPrefix = "MgAdminConfigurationManagement";

    private sealed record ExpectedOperation(string Method, string Path, string OperationId, string Verb, string Noun);

    private static readonly ExpectedOperation[] Operations =
    [
        new("GET", "configurationDrifts", "ListConfigurationDrifts", "Get", "ConfigurationDrift"),
        new("GET", "configurationDrifts/{configurationDrift-id}", "GetConfigurationDrifts", "Get", "ConfigurationDrift"),
        new("GET", "configurationDrifts/$count", "configurationDrifts.GetCount-b132", "Get", "ConfigurationDriftCount"),
        new("GET", "configurationMonitoringResults", "ListConfigurationMonitoringResults", "Get", "ConfigurationMonitoringResult"),
        new("GET", "configurationMonitoringResults/{configurationMonitoringResult-id}", "GetConfigurationMonitoringResults", "Get", "ConfigurationMonitoringResult"),
        new("GET", "configurationMonitoringResults/$count", "configurationMonitoringResults.GetCount-0ec6", "Get", "ConfigurationMonitoringResultCount"),
        new("GET", "configurationMonitors", "ListConfigurationMonitors", "Get", "ConfigurationMonitor"),
        new("POST", "configurationMonitors", "CreateConfigurationMonitors", "New", "ConfigurationMonitor"),
        new("GET", "configurationMonitors/{configurationMonitor-id}", "GetConfigurationMonitors", "Get", "ConfigurationMonitor"),
        new("PATCH", "configurationMonitors/{configurationMonitor-id}", "UpdateConfigurationMonitors", "Update", "ConfigurationMonitor"),
        new("DELETE", "configurationMonitors/{configurationMonitor-id}", "DeleteConfigurationMonitors", "Remove", "ConfigurationMonitor"),
        new("GET", "configurationMonitors/{configurationMonitor-id}/baseline", "configurationMonitors.GetBaseline", "Get", "ConfigurationMonitorBaseline"),
        new("GET", "configurationMonitors/$count", "configurationMonitors.GetCount-e65d", "Get", "ConfigurationMonitorCount"),
        new("GET", "configurationSnapshotJobs", "ListConfigurationSnapshotJobs", "Get", "ConfigurationSnapshotJob"),
        new("GET", "configurationSnapshotJobs/{configurationSnapshotJob-id}", "GetConfigurationSnapshotJobs", "Get", "ConfigurationSnapshotJob"),
        new("DELETE", "configurationSnapshotJobs/{configurationSnapshotJob-id}", "DeleteConfigurationSnapshotJobs", "Remove", "ConfigurationSnapshotJob"),
        new("GET", "configurationSnapshots", "ListConfigurationSnapshots", "Get", "ConfigurationSnapshot"),
        new("GET", "configurationSnapshots/{configurationBaseline-id}", "GetConfigurationSnapshots", "Get", "ConfigurationSnapshot"),
    ];

    [Theory]
    [InlineData("v1.0", false)]
    [InlineData("v1.0", true)]
    [InlineData("beta", false)]
    [InlineData("beta", true)]
    public async Task RealCompatibleOperationsRemainUnsuppressedAndStructurallyNamed(string profile, bool useCollisionData)
    {
        var settings = new OpenApiReaderSettings();
        settings.AddYamlReader();
        var specPath = Path.Combine(FindRepoRoot(), "openApiDocs_KiotaCompat", profile, "ConfigurationManagement.yml");
        using var stream = File.OpenRead(specPath);
        var result = await OpenApiDocument.LoadAsync(stream, settings: settings,
            cancellationToken: TestContext.Current.CancellationToken);
        var document = Assert.IsType<OpenApiDocument>(result.Document);
        var actualOperations = document.Paths.SelectMany(path =>
            path.Value.Operations!.Select(operation =>
                $"{operation.Key.Method} {path.Key} [{operation.Value.OperationId}]"));
        var expectedOperations = Operations.Select(operation =>
            $"{operation.Method} {Root}{operation.Path} [{OperationPrefix}{operation.OperationId}]");
        Assert.Equal(expectedOperations.OrderBy(value => value, StringComparer.Ordinal),
            actualOperations.OrderBy(value => value, StringComparer.Ordinal));

        var config = new GeneratorConfig("Test.Client", "unused", profile, useCollisionData);
        foreach (var operation in Operations)
        {
            var method = new HttpMethod(operation.Method);
            var path = Root + operation.Path;
            Assert.False(CmdletConfigurator.IsSuppressed(method, path, config), $"{profile}: {method} {path}");
            Assert.Null(CmdletConfigurator.TryGetOverriddenVerb(method, path, config));
            Assert.Equal("UnchangedNoun", CmdletConfigurator.ApplyNounOverrides(method, path, "UnchangedNoun", config));
            var naming = Naming.Resolve(new OperationInfo(method, path), config);
            Assert.Equal(operation.Verb, naming.VerbName);
            Assert.Equal(NounPrefix + operation.Noun, naming.Noun);
        }
    }

    [Fact]
    public void NoSharedDirectivesRequireMappingsOrCuratedOverrides()
    {
        var moduleRoot = Path.Combine(FindRepoRoot(), "src", "ConfigurationManagement");
        var sharedSource = File.ReadAllText(Path.Combine(moduleRoot, "ConfigurationManagement.md"));
        Assert.DoesNotMatch(@"(?m)^\s*directive:", sharedSource);
        using var ledger = JsonDocument.Parse(File.ReadAllText(Path.Combine(moduleRoot, "wrapper",
            "ConfigurationManagement_directiveMigrationMap.json")));
        Assert.Empty(ledger.RootElement.GetProperty("mappings").EnumerateArray());
        var configuration = File.ReadAllText(Path.Combine(moduleRoot, "wrapper",
            "ConfigurationManagement_cmdletConfigurations.cs"));
        Assert.Contains("ConfigurationManagementCmdletConfigurations = [];", configuration);
        Assert.DoesNotContain("new(OverrideKind.", configuration);
    }

    private static string FindRepoRoot()
    {
        var directory = AppContext.BaseDirectory;
        while (directory is not null && !Directory.Exists(Path.Combine(directory, "openApiDocs_KiotaCompat")))
            directory = Path.GetDirectoryName(directory);
        return directory ?? throw new InvalidOperationException("Repo root not found from test base directory.");
    }
}
