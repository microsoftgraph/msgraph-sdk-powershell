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
    [InlineData("v1.0", 6, true)]
    [InlineData("v1.0", 6, false)]
    [InlineData("beta", 7, true)]
    [InlineData("beta", 7, false)]
    public void OriginalLegacySelectorAccountsForEveryExactSurvivingOperation(string profile, int expectedCount, bool useCollisionData)
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
        Assert.False(mapping.TryGetProperty("operationIdSource", out _));
        Assert.False(mapping.GetProperty("absenceExpected").GetBoolean());
        var reviewed = mapping.GetProperty("operations").EnumerateArray().ToArray();
        Assert.Equal(expectedCount, reviewed.Length);
        Assert.Equal(
            legacy.Select(o => $"{o.Method} {o.Path}").OrderBy(k => k),
            reviewed.Select(o => $"{o.GetProperty("method").GetString()} {o.GetProperty("path").GetString()}").OrderBy(k => k));
        var current = Operations(Specs.Value[$"openApiDocs_KiotaCompat|{profile}"]).ToArray();
        Assert.Equal(6, current.Count(o => selector.IsMatch(o.Operation.OperationId!)));

        foreach (var expected in reviewed)
        {
            var method = expected.GetProperty("method").GetString()!;
            var path = expected.GetProperty("path").GetString()!;
            var actual = Assert.Single(Operations(Specs.Value[$"openApiDocs_KiotaCompat|{profile}"]),
                o => o.Method == method && o.Path == path);
            Assert.Equal(expected.GetProperty("operationId").GetString(), actual.Operation.OperationId);
            var original = Assert.Single(legacy, o => o.Method == method && o.Path == path);
            if (path == AggregatedApps)
            {
                Assert.Equal("security.dataDiscovery.cloudAppDiscovery.uploadedStream_aggregatedAppsDetail", original.Operation.OperationId);
                Assert.Equal("security.dataDiscovery.cloudAppDiscovery.uploadedStream.cloudAppDiscoveryReport_aggregatedAppsDetail", actual.Operation.OperationId);
            }
            else
                Assert.Equal(original.Operation.OperationId, actual.Operation.OperationId);
            Assert.True(CmdletConfigurator.IsSuppressed(new HttpMethod(method), path, Config(useCollisionData), apiVersion: profile));
        }
    }

    [Theory]
    [InlineData("v1.0", true)]
    [InlineData("v1.0", false)]
    [InlineData("beta", true)]
    [InlineData("beta", false)]
    public void EveryReviewedCurrentOperationExistsAndHasItsDeclaredDisposition(string profile, bool useCollisionData)
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
                    Assert.True(CmdletConfigurator.IsSuppressed(new HttpMethod(method), path, Config(useCollisionData), apiVersion: profile));
                else
                    Assert.False(CmdletConfigurator.IsSuppressed(new HttpMethod(method), path, Config(useCollisionData), apiVersion: profile));
            }
        }
        var count = Naming.Resolve(new OperationInfo(HttpMethod.Get, "/security/alerts_v2/$count"), Config(useCollisionData), apiVersion: profile);
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
    [InlineData("v1.0", true)]
    [InlineData("v1.0", false)]
    [InlineData("beta", true)]
    [InlineData("beta", false)]
    public void SurvivingNeighborsRemainUnsuppressedAndKeepTheirNames(string profile, bool useCollisionData)
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
            Assert.False(CmdletConfigurator.IsSuppressed(new HttpMethod(method), path, Config(useCollisionData), apiVersion: profile));
            Assert.Equal(noun, Naming.Resolve(new OperationInfo(new HttpMethod(method), path), Config(useCollisionData), apiVersion: profile).Noun);
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

    [Fact]
    public void BetaActionCollisionsRetainBothContractsAndPublishedItemDefaults()
    {
        using var metadata = JsonDocument.Parse(File.ReadAllText(Path.Combine(
            RepoRoot.Value, "src", "Authentication", "Authentication", "custom", "common", "MgCommandMetadata.json")));
        var document = Specs.Value["openApiDocs_KiotaCompat|beta"];
        foreach (var (collection, id, noun) in new[]
        {
            ("custodians", "ediscoveryCustodian-id", "Custodian"),
            ("noncustodialDataSources", "ediscoveryNoncustodialDataSource-id", "NoncustodialDataSource"),
        })
        foreach (var (action, verb, suffix) in new[]
        {
            ("applyHold", "Add", "Hold"), ("removeHold", "Remove", "Hold"), ("updateIndex", "Update", "Index"),
        })
        {
            var root = $"/security/cases/ediscoveryCases/{{ediscoveryCase-id}}/{collection}";
            var itemPath = $"{root}/{{{id}}}/microsoft.graph.security.{action}";
            var collectionPath = $"{root}/microsoft.graph.security.{action}";
            var item = document.Paths[itemPath].Operations![HttpMethod.Post];
            var bulk = document.Paths[collectionPath].Operations![HttpMethod.Post];
            Assert.Null(item.RequestBody);
            Assert.NotNull(bulk.RequestBody);
            Assert.True(bulk.RequestBody.Required);
            var media = Assert.Single(bulk.RequestBody.Content!);
            Assert.Equal("application/json", media.Key);
            var property = Assert.Single(media.Value.Schema!.Properties!);
            Assert.Equal("ids", property.Key);
            Assert.Equal(JsonSchemaType.Array, property.Value.Type);
            Assert.Equal(JsonSchemaType.String, property.Value.Items!.Type & ~JsonSchemaType.Null);
            Assert.True(media.Value.Schema.Required is null || media.Value.Schema.Required.Count == 0);
            Assert.Equal(new[] { "204" }, item.Responses!.Keys.Where(k => k.StartsWith("2", StringComparison.Ordinal)));
            Assert.Equal(new[] { "204" }, bulk.Responses!.Keys.Where(k => k.StartsWith("2", StringComparison.Ordinal)));
            Assert.True(item.Responses["204"].Content is null || item.Responses["204"].Content!.Count == 0);
            Assert.True(bulk.Responses["204"].Content is null || bulk.Responses["204"].Content!.Count == 0);
            Assert.True(item.Parameters is null || item.Parameters.Count == 0);
            Assert.True(bulk.Parameters is null || bulk.Parameters.Count == 0);
            Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Post, itemPath, Config(), apiVersion: "beta"));
            Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Post, collectionPath, Config(), apiVersion: "beta"));
            var published = PublishedDefault(metadata, $"{verb}-MgBetaSecurityCaseEdiscoveryCase{noun}{suffix}");
            Assert.Equal(itemPath.Replace("/microsoft.graph.security.", "/", StringComparison.Ordinal),
                published.GetProperty("Uri").GetString());
            Assert.Contains(published.GetProperty("Variants").EnumerateArray(),
                v => v.GetString()!.EndsWith("Expanded", StringComparison.Ordinal));
        }
    }

    [Fact]
    public void BetaCountCollisionsRetainBothRoutesAndPublishedDefaultDifferences()
    {
        using var metadata = JsonDocument.Parse(File.ReadAllText(Path.Combine(
            RepoRoot.Value, "src", "Authentication", "Authentication", "custom", "common", "MgCommandMetadata.json")));
        var document = Specs.Value["openApiDocs_KiotaCompat|beta"];
        foreach (var (top, nested, noun, nestedDefault) in new[]
        {
            ("articleIndicators", "articles/{article-id}/indicators", "ArticleIndicator", false),
            ("hostComponents", "hosts/{host-id}/components", "HostComponent", false),
            ("hostCookies", "hosts/{host-id}/cookies", "HostCookie", false),
            ("hostPairs", "hosts/{host-id}/hostPairs", "HostPair", false),
            ("hostPorts", "hosts/{host-id}/ports", "HostPort", false),
            ("hostSslCertificates", "hosts/{host-id}/sslCertificates", "HostSslCertificate", true),
            ("hostTrackers", "hosts/{host-id}/trackers", "HostTracker", true),
        })
        {
            var topPath = $"/security/threatIntelligence/{top}/$count";
            var nestedPath = $"/security/threatIntelligence/{nested}/$count";
            foreach (var path in new[] { topPath, nestedPath })
            {
                var operation = document.Paths[path].Operations![HttpMethod.Get];
                Assert.Null(operation.RequestBody);
                var queries = operation.Parameters!;
                Assert.Equal(new[] { "$filter", "$search" }, queries.Select(p => p.Name).OrderBy(n => n));
                Assert.All(queries, p =>
                {
                    Assert.Equal(ParameterLocation.Query, p.In);
                    Assert.False(p.Required);
                    Assert.Equal(JsonSchemaType.String, p.Schema!.Type);
                });
                var media = Assert.Single(operation.Responses!["2XX"].Content!);
                Assert.Equal("text/plain", media.Key);
                Assert.Equal(JsonSchemaType.Integer, media.Value.Schema!.Type);
                Assert.Equal("int32", media.Value.Schema.Format);
                Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get, path, Config(), apiVersion: "beta"));
            }
            var published = PublishedDefault(metadata, $"Get-MgBetaSecurityThreatIntelligence{noun}Count");
            Assert.Equal(nestedDefault ? nestedPath : topPath, published.GetProperty("Uri").GetString());
            Assert.Contains(published.GetProperty("Variants").EnumerateArray(), v => v.GetString() == "Get1");
        }
    }

    private static JsonElement PublishedDefault(JsonDocument metadata, string command) =>
        Assert.Single(metadata.RootElement.EnumerateArray(),
            row => row.GetProperty("ApiVersion").GetString() == "beta" &&
                row.GetProperty("Command").GetString() == command);

    [Theory]
    [InlineData("v1.0", true)]
    [InlineData("v1.0", false)]
    [InlineData("beta", true)]
    [InlineData("beta", false)]
    public void CollisionAlternativesHaveSourceScopedNamesWithoutChangingPublishedCountDefaults(string profile, bool useCollisionData)
    {
        var document = Specs.Value[$"openApiDocs_KiotaCompat|{profile}"];
        foreach (var (top, nested, noun, nestedDefault) in new[]
        {
            ("articleIndicators", "articles/{article-id}/indicators", "ArticleIndicator", false),
            ("hostComponents", "hosts/{host-id}/components", "HostComponent", false),
            ("hostCookies", "hosts/{host-id}/cookies", "HostCookie", false),
            ("hostPairs", "hosts/{host-id}/hostPairs", "HostPair", false),
            ("hostPorts", "hosts/{host-id}/ports", "HostPort", false),
            ("hostSslCertificates", "hosts/{host-id}/sslCertificates", "HostSslCertificate", true),
            ("hostTrackers", "hosts/{host-id}/trackers", "HostTracker", true),
        })
        {
            var topPath = $"/security/threatIntelligence/{top}/$count";
            var nestedPath = $"/security/threatIntelligence/{nested}/$count";
            var defaultPath = nestedDefault ? nestedPath : topPath;
            var alternatePath = nestedDefault ? topPath : nestedPath;
            var publishedNoun = $"MgSecurityThreatIntelligence{noun}Count";
            var suffix = nestedDefault ? "AcrossHost" : top == "articleIndicators" ? "ByArticle" : "ByHost";
            Assert.True(document.Paths.ContainsKey(defaultPath));
            Assert.True(document.Paths.ContainsKey(alternatePath));
            Assert.Equal(publishedNoun, Naming.Resolve(new OperationInfo(HttpMethod.Get, defaultPath), Config(useCollisionData), profile).Noun);
            Assert.Equal(publishedNoun + suffix, Naming.Resolve(new OperationInfo(HttpMethod.Get, alternatePath), Config(useCollisionData), profile).Noun);
            Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get, defaultPath, Config(useCollisionData), profile));
            Assert.Equal(profile == "v1.0" && useCollisionData,
                CmdletConfigurator.IsSuppressed(HttpMethod.Get, alternatePath, Config(useCollisionData), profile));
        }
        foreach (var (collection, noun) in new[] { ("custodians", "Custodian"), ("noncustodialDataSources", "NoncustodialDataSource") })
        foreach (var action in new[] { "applyHold", "removeHold", "updateIndex" })
        {
            var path = $"/security/cases/ediscoveryCases/{{ediscoveryCase-id}}/{collection}/microsoft.graph.security.{action}";
            if (!document.Paths.ContainsKey(path))
            {
                Assert.Equal("v1.0", profile);
                Assert.Equal("updateIndex", action);
                continue;
            }
            var naming = Naming.Resolve(new OperationInfo(HttpMethod.Post, path, Kind: OperationKind.Action), Config(useCollisionData), profile);
            var actionNoun = char.ToUpperInvariant(action[0]) + action[1..];
            Assert.Equal($"MgSecurityCaseEdiscoveryCase{noun}{actionNoun}Multiple", naming.Noun);
            Assert.Equal("Invoke", naming.VerbName);
            Assert.Equal(profile == "v1.0" && useCollisionData,
                CmdletConfigurator.IsSuppressed(HttpMethod.Post, path, Config(useCollisionData), profile));
        }
    }

    private static GeneratorConfig Config(bool useCollisionData = true) => new("Test.Client", "unused", UseCollisionData: useCollisionData);

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
