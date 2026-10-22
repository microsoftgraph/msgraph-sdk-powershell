using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Reader;
using WrapperGenerator;
using Xunit;

namespace WrapperGenerator.Tests;

public sealed class SecurityDirectiveMigrationTests
{
    private const string NestedDataSource =
        "/security/cases/ediscoveryCases/{ediscoveryCase-id}/noncustodialDataSources/{ediscoveryNoncustodialDataSource-id}/dataSource";
    private const string AggregatedApps =
        "/security/dataDiscovery/cloudAppDiscovery/uploadedStreams/{cloudAppDiscoveryReport-id}/microsoft.graph.security.aggregatedAppsDetails(period={period})";
    private static readonly Lazy<string> RepoRoot = new(FindRepoRoot);
    private static readonly Lazy<Dictionary<string, OpenApiDocument>> Specs = new(LoadSpecs);

    [Theory]
    [InlineData("v1.0", 6)]
    [InlineData("beta", 7)]
    public void OriginalLegacySelectorAccountsForEveryExactSurvivingOperation(string profile, int expectedCount)
    {
        var source = File.ReadAllText(Path.Combine(RepoRoot.Value, "src", "Security", "Security.md"));
        var pattern = Regex.Match(source, @"(?m)^\s+- remove-path-by-operation:\s*(.+)$").Groups[1].Value.Trim();
        Assert.NotEmpty(pattern);
        var selector = new Regex(pattern);
        var legacy = Operations(Specs.Value[$"openApiDocs|{profile}"])
            .Where(o => selector.IsMatch(o.Operation.OperationId!)).ToArray();
        Assert.Equal(expectedCount, legacy.Length);

        using var ledger = ReadLedger();
        var mapping = ledger.RootElement.GetProperty("mappings")[0].GetProperty("profiles").GetProperty(profile);
        Assert.Equal("Legacy", mapping.GetProperty("operationIdSource").GetString());
        Assert.False(mapping.GetProperty("absenceExpected").GetBoolean());
        Assert.Equal(0, mapping.GetProperty("removedLegacyOperations").GetArrayLength());
        var reviewed = mapping.GetProperty("operations").EnumerateArray().ToArray();
        Assert.Equal(expectedCount, reviewed.Length);
        Assert.Equal(
            legacy.Select(o => $"{o.Method} {o.Path} [{o.Operation.OperationId}]").OrderBy(k => k),
            reviewed.Select(o => $"{o.GetProperty("method").GetString()} {o.GetProperty("legacyPath").GetString()} [{o.GetProperty("legacyOperationId").GetString()}]").OrderBy(k => k));

        foreach (var expected in reviewed)
        {
            var method = expected.GetProperty("method").GetString()!;
            var path = expected.GetProperty("path").GetString()!;
            var actual = Assert.Single(Operations(Specs.Value[$"openApiDocs_KiotaCompat|{profile}"]),
                o => o.Method == method && o.Path == path);
            Assert.Equal(expected.GetProperty("legacyPath").GetString(), path);
            Assert.Equal(expected.GetProperty("operationId").GetString(), actual.Operation.OperationId);
            Assert.NotEqual(expected.GetProperty("legacyOperationId").GetString(), actual.Operation.OperationId);
            Assert.True(CmdletConfigurator.IsSuppressed(new HttpMethod(method), path, Config(profile)));
        }
    }

    [Theory]
    [InlineData("v1.0")]
    [InlineData("beta")]
    public void EveryReviewedCurrentOperationExistsAndHasItsDeclaredDisposition(string profile)
    {
        using var ledger = ReadLedger();
        var mappings = ledger.RootElement.GetProperty("mappings").EnumerateArray().ToArray();
        Assert.Equal(6, mappings.Length);
        foreach (var mapping in mappings)
        {
            var index = mapping.GetProperty("directiveIndex").GetInt32();
            var evidence = mapping.GetProperty("profiles").GetProperty(profile);
            foreach (var expected in evidence.GetProperty("operations").EnumerateArray())
            {
                var method = expected.GetProperty("method").GetString()!;
                var path = expected.GetProperty("path").GetString()!;
                var actual = Assert.Single(Operations(Specs.Value[$"openApiDocs_KiotaCompat|{profile}"]),
                    o => o.Method == method && o.Path == path);
                Assert.Equal(expected.GetProperty("operationId").GetString(), actual.Operation.OperationId);
                if (index <= 3)
                    Assert.True(CmdletConfigurator.IsSuppressed(new HttpMethod(method), path, Config(profile)));
                else
                    Assert.False(CmdletConfigurator.IsSuppressed(new HttpMethod(method), path, Config(profile)));
            }
        }
        var count = Naming.Resolve(new OperationInfo(HttpMethod.Get, "/security/alerts_v2/$count"), Config(profile));
        Assert.Equal("Get", count.VerbName);
        Assert.Equal("MgSecurityAlertV2Count", count.Noun);
    }

    [Theory]
    [InlineData("v1.0")]
    [InlineData("beta")]
    public void RetiredBulkActionsAreActualLegacyRoutesNotGuessedVariants(string profile)
    {
        (string Path, string Id)[] actions =
        [
            ("/security/tiIndicators/microsoft.graph.deleteTiIndicators", "security.tiIndicator_deleteTiIndicator"),
            ("/security/alerts/microsoft.graph.updateAlerts", "security.alert_updateAlert"),
            ("/security/tiIndicators/microsoft.graph.updateTiIndicators", "security.tiIndicator_updateTiIndicator"),
        ];
        var old = Operations(Specs.Value[$"openApiDocs|{profile}"]).ToArray();
        var current = Operations(Specs.Value[$"openApiDocs_KiotaCompat|{profile}"]).ToArray();
        foreach (var (path, id) in actions)
        {
            var legacy = old.Where(o => o.Method == "POST" && o.Path == path).ToArray();
            if (profile == "beta")
                Assert.Equal(id, Assert.Single(legacy).Operation.OperationId);
            else
                Assert.Empty(legacy);
            var action = path[(path.LastIndexOf('/') + 1)..].Replace("microsoft.graph.", "", StringComparison.Ordinal);
            Assert.DoesNotContain(current, o => o.Operation.OperationId == id ||
                o.Path.Split('/').Any(s => s.Equals(action, StringComparison.OrdinalIgnoreCase) ||
                    s.EndsWith("." + action, StringComparison.OrdinalIgnoreCase)));
        }
        Assert.DoesNotContain(current, o => o.Path == "/security/alerts" || o.Path.StartsWith("/security/alerts/", StringComparison.Ordinal) ||
            o.Path == "/security/tiIndicators" || o.Path.StartsWith("/security/tiIndicators/", StringComparison.Ordinal));
        using var ledger = ReadLedger();
        foreach (var index in new[] { 3, 4 })
        {
            var mapping = ledger.RootElement.GetProperty("mappings")[index];
            Assert.Equal("ReviewedApiRemoval", mapping.GetProperty("implementation").GetString());
            Assert.True(mapping.GetProperty("profiles").GetProperty(profile).GetProperty("absenceExpected").GetBoolean());
            Assert.Equal(0, mapping.GetProperty("profiles").GetProperty(profile).GetProperty("operations").GetArrayLength());
        }
    }

    [Theory]
    [InlineData("v1.0")]
    [InlineData("beta")]
    public void SurvivingNeighborsRemainUnsuppressedAndKeepTheirNames(string profile)
    {
        (string Method, string Path, string Noun)[] neighbors =
        [
            ("GET", "/security/attackSimulation/simulations", "MgSecurityAttackSimulation"),
            ("GET", NestedDataSource[..NestedDataSource.LastIndexOf('/')], "MgSecurityCaseEdiscoveryCaseNoncustodialDataSource"),
            ("PATCH", NestedDataSource[..NestedDataSource.LastIndexOf('/')], "MgSecurityCaseEdiscoveryCaseNoncustodialDataSource"),
            ("DELETE", NestedDataSource[..NestedDataSource.LastIndexOf('/')], "MgSecurityCaseEdiscoveryCaseNoncustodialDataSource"),
            ("GET", "/security/alerts_v2", "MgSecurityAlertV2"),
            ("PATCH", "/security/alerts_v2/{alert-id}", "MgSecurityAlertV2"),
        ];
        foreach (var (method, path, noun) in neighbors)
        {
            Assert.Single(Operations(Specs.Value[$"openApiDocs_KiotaCompat|{profile}"]),
                o => o.Method == method && o.Path == path);
            Assert.False(CmdletConfigurator.IsSuppressed(new HttpMethod(method), path, Config(profile)));
            Assert.Equal(noun, Naming.Resolve(new OperationInfo(new HttpMethod(method), path), Config(profile)).Noun);
        }
    }

    [Fact]
    public void NewSuppressionsAreExactMethodAndRouteMatches()
    {
        foreach (var method in new[] { HttpMethod.Get, HttpMethod.Patch, HttpMethod.Delete })
        {
            Assert.True(CmdletConfigurator.IsSuppressed(method, NestedDataSource));
            Assert.False(CmdletConfigurator.IsSuppressed(method, NestedDataSource + "/child"));
        }
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Post, NestedDataSource));
        Assert.True(CmdletConfigurator.IsSuppressed(HttpMethod.Get, AggregatedApps));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Post, AggregatedApps));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get, AggregatedApps + "/child"));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Post, "/security"));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Delete, "/security"));
    }

    private static GeneratorConfig Config(string profile) => new("Test.Client", "unused", profile);

    private static JsonDocument ReadLedger() =>
        JsonDocument.Parse(File.ReadAllText(Path.Combine(RepoRoot.Value, "src", "Security", "wrapper", "Security_directiveMigrationMap.json")));

    private static IEnumerable<(string Method, string Path, OpenApiOperation Operation)> Operations(OpenApiDocument document) =>
        document.Paths.SelectMany(p => p.Value.Operations!.Select(o => (o.Key.Method, p.Key, o.Value)));

    private static Dictionary<string, OpenApiDocument> LoadSpecs()
    {
        var settings = new OpenApiReaderSettings();
        settings.AddYamlReader();
        var result = new Dictionary<string, OpenApiDocument>();
        foreach (var root in new[] { "openApiDocs", "openApiDocs_KiotaCompat" })
        foreach (var profile in new[] { "v1.0", "beta" })
        {
            using var stream = File.OpenRead(Path.Combine(RepoRoot.Value, root, profile, "Security.yml"));
            var parsed = OpenApiDocument.LoadAsync(stream, settings: settings, cancellationToken: CancellationToken.None)
                .GetAwaiter().GetResult();
            result.Add($"{root}|{profile}", parsed.Document ?? throw new InvalidOperationException($"Could not parse {root}/{profile}/Security.yml."));
        }
        return result;
    }

    private static string FindRepoRoot()
    {
        var dir = AppContext.BaseDirectory;
        while (dir is not null && !File.Exists(Path.Combine(dir, "src", "Security", "Security.md")))
            dir = Path.GetDirectoryName(dir);
        return dir ?? throw new InvalidOperationException("Repo root not found from test base directory.");
    }
}
