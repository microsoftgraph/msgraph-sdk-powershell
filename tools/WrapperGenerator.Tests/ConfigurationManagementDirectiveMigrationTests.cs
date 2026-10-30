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
    private const string OperationPrefix = "admin.configurationManagement";
    private const string NounPrefix = "MgAdminConfigurationManagement";

    private sealed record ExpectedOperation(string Method, string Path, string OperationId, string Verb, string Noun);

    private static readonly ExpectedOperation[] Operations =
    [
        new("GET", "configurationDrifts", "_ListConfigurationDrift", "Get", "ConfigurationDrift"),
        new("GET", "configurationDrifts/{configurationDrift-id}", "_GetConfigurationDrift", "Get", "ConfigurationDrift"),
        new("GET", "configurationDrifts/$count", ".configurationDrift_GetCount", "Get", "ConfigurationDriftCount"),
        new("GET", "configurationMonitoringResults", "_ListConfigurationMonitoringResult", "Get", "ConfigurationMonitoringResult"),
        new("GET", "configurationMonitoringResults/{configurationMonitoringResult-id}", "_GetConfigurationMonitoringResult", "Get", "ConfigurationMonitoringResult"),
        new("GET", "configurationMonitoringResults/$count", ".configurationMonitoringResult_GetCount", "Get", "ConfigurationMonitoringResultCount"),
        new("GET", "configurationMonitors", "_ListConfigurationMonitor", "Get", "ConfigurationMonitor"),
        new("POST", "configurationMonitors", "_CreateConfigurationMonitor", "New", "ConfigurationMonitor"),
        new("GET", "configurationMonitors/{configurationMonitor-id}", "_GetConfigurationMonitor", "Get", "ConfigurationMonitor"),
        new("PATCH", "configurationMonitors/{configurationMonitor-id}", "_UpdateConfigurationMonitor", "Update", "ConfigurationMonitor"),
        new("DELETE", "configurationMonitors/{configurationMonitor-id}", "_DeleteConfigurationMonitor", "Remove", "ConfigurationMonitor"),
        new("GET", "configurationMonitors/{configurationMonitor-id}/baseline", ".configurationMonitor_GetBaseline", "Get", "ConfigurationMonitorBaseline"),
        new("GET", "configurationMonitors/$count", ".configurationMonitor_GetCount", "Get", "ConfigurationMonitorCount"),
        new("GET", "configurationSnapshotJobs", "_ListConfigurationSnapshotJob", "Get", "ConfigurationSnapshotJob"),
        new("GET", "configurationSnapshotJobs/{configurationSnapshotJob-id}", "_GetConfigurationSnapshotJob", "Get", "ConfigurationSnapshotJob"),
        new("DELETE", "configurationSnapshotJobs/{configurationSnapshotJob-id}", "_DeleteConfigurationSnapshotJob", "Remove", "ConfigurationSnapshotJob"),
        new("GET", "configurationSnapshots", "_ListConfigurationSnapshot", "Get", "ConfigurationSnapshot"),
        new("GET", "configurationSnapshots/{configurationBaseline-id}", "_GetConfigurationSnapshot", "Get", "ConfigurationSnapshot"),
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

        var config = new GeneratorConfig("Test.Client", "unused", UseCollisionData: useCollisionData);
        foreach (var operation in Operations)
        {
            var method = new HttpMethod(operation.Method);
            var path = Root + operation.Path;
            Assert.False(CmdletConfigurator.IsSuppressed(method, path, config, apiVersion: profile), $"{profile}: {method} {path}");
            Assert.Null(CmdletConfigurator.TryGetOverriddenVerb(method, path, config, apiVersion: profile));
            Assert.Equal("UnchangedNoun", CmdletConfigurator.ApplyNounOverrides(method, path, "UnchangedNoun", config, apiVersion: profile));
            var naming = Naming.Resolve(new OperationInfo(method, path), config, apiVersion: profile);
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
