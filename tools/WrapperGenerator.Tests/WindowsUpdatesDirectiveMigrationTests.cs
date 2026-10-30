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

public sealed class WindowsUpdatesDirectiveMigrationTests
{
    private static readonly string RepoRoot = FindRepoRoot();
    private static readonly Lazy<IReadOnlyList<Route>> Compatible = new(() => ReadRoutes("openApiDocs_KiotaCompat"));
    private static readonly Lazy<IReadOnlyList<Route>> Legacy = new(() => ReadRoutes("openApiDocs"));

    [Fact]
    public void OriginalOperationIdSelectorHasCompleteActualLegacyAndCurrentCoverage()
    {
        var markdown = File.ReadAllText(Path.Combine(RepoRoot, "src", "WindowsUpdates", "WindowsUpdates.md"));
        var pattern = Regex.Match(markdown, @"(?m)^\s+- remove-path-by-operation: (.+)$")
            .Groups[1].Value.Trim().Replace(@"\_", "_", StringComparison.Ordinal);
        Assert.NotEmpty(pattern);
        var expected = Legacy.Value.Where(route => Regex.IsMatch(route.OperationId, pattern)).ToArray();
        Assert.Equal(266, Legacy.Value.Count);
        Assert.Equal(59, expected.Length);
        var currentSelected = Compatible.Value.Where(route => Regex.IsMatch(route.OperationId, pattern)).ToArray();
        Assert.Equal(59, currentSelected.Length);
        Assert.Equal(
            expected.Select(route => route.Method + " " + Normalize(route.Path)).OrderBy(key => key).ToArray(),
            currentSelected.Select(route => route.Method + " " + Normalize(route.Path)).OrderBy(key => key).ToArray());

        using var ledger = ReadLedger();
        var profile = Mapping(ledger, 1).GetProperty("profiles").GetProperty("beta");
        Assert.False(profile.TryGetProperty("operationIdSource", out _));
        Assert.False(profile.TryGetProperty("removedLegacyOperations", out _));
        var bridges = profile.GetProperty("operations").EnumerateArray().ToArray();
        Assert.Equal(expected.Length, bridges.Length);
        var changedIds = 0;
        foreach (var old in expected)
        {
            var successor = Assert.Single(currentSelected, route =>
                route.Method == old.Method && Normalize(route.Path) == Normalize(old.Path));
            var bridge = Assert.Single(bridges, row =>
                row.GetProperty("method").GetString() == old.Method &&
                row.GetProperty("path").GetString() == successor.Path);
            Assert.Equal(successor.Path, bridge.GetProperty("path").GetString());
            Assert.Equal(successor.OperationId, bridge.GetProperty("operationId").GetString());
            Assert.False(bridge.TryGetProperty("legacyPath", out _));
            Assert.False(bridge.TryGetProperty("legacyOperationId", out _));
            if (old.OperationId != successor.OperationId)
            {
                changedIds++;
                var separator = old.OperationId.LastIndexOf('_');
                Assert.True(separator > 0);
                Assert.Equal(old.OperationId.Insert(separator, ".updatableAsset"), successor.OperationId);
            }
        }
        Assert.Equal(8, changedIds);
    }

    [Fact]
    public void AllMappedOperationsRecordExactRefreshedIdsWithoutAssumingGlobalIdEquality()
    {
        using var ledger = ReadLedger();
        foreach (var mapping in ledger.RootElement.GetProperty("mappings").EnumerateArray())
        {
            foreach (var operation in mapping.GetProperty("profiles").GetProperty("beta")
                         .GetProperty("operations").EnumerateArray())
            {
                var current = Assert.Single(Compatible.Value, route =>
                    route.Method == operation.GetProperty("method").GetString() &&
                    route.Path == operation.GetProperty("path").GetString());
                Assert.Equal(current.OperationId, operation.GetProperty("operationId").GetString());
            }
        }
        Assert.Equal(24, Legacy.Value.Count(old => old.OperationId != Assert.Single(Compatible.Value,
            route => route.Method == old.Method && Normalize(route.Path) == Normalize(old.Path)).OperationId));
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void AllReviewedSuppressionsAndOnlyThoseSuppressionsApplyToActualBetaOperations(bool useCollisionData)
    {
        using var ledger = ReadLedger();
        var suppressed = new HashSet<string>(StringComparer.Ordinal);
        foreach (var index in new[] { 1, 3, 4, 5, 6 })
        {
            foreach (var operation in Mapping(ledger, index).GetProperty("profiles")
                         .GetProperty("beta").GetProperty("operations").EnumerateArray())
                suppressed.Add(operation.GetProperty("method").GetString() + " " +
                    Normalize(operation.GetProperty("path").GetString()!));
        }
        Assert.Equal(77, suppressed.Count);
        Assert.Equal(266, Compatible.Value.Count);
        var config = new GeneratorConfig("Test.Client", "unused", useCollisionData);
        foreach (var route in Compatible.Value)
            Assert.Equal(suppressed.Contains(route.Method + " " + Normalize(route.Path)),
                CmdletConfigurator.IsSuppressed(new HttpMethod(route.Method), route.Path, config, apiVersion: "beta"));
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void EverySurvivingRouteHasFinalWindowsUpdatesNameAndOnlyNormalListItemPairsShareNames(bool useCollisionData)
    {
        var config = new GeneratorConfig("Test.Client", "unused", useCollisionData);
        var survivors = Compatible.Value.Where(route =>
            !CmdletConfigurator.IsSuppressed(new HttpMethod(route.Method), route.Path, config, apiVersion: "beta")).ToArray();
        Assert.Equal(189, survivors.Length);
        var names = survivors.Select(route => Naming.Resolve(
            new OperationInfo(new HttpMethod(route.Method), route.Path, Kind: route.Kind), config, apiVersion: "beta")).ToArray();
        Assert.All(names, name => Assert.StartsWith("MgWindowsUpdates", name.Noun));
        foreach (var group in names.GroupBy(name => (name.VerbName, name.Noun)))
        {
            if (group.Count() == 1)
                continue;
            var pair = group.OrderBy(name => name.SourcePath.Length).ToArray();
            Assert.Equal(2, pair.Length);
            Assert.All(pair, name => Assert.Equal("GET", name.SourceMethod));
            Assert.Equal(pair[0].SourcePath + "/{}", Regex.Replace(pair[1].SourcePath, @"\{[^}]*\}$", "{}"));
        }
    }

    [Theory]
    [InlineData("GET", "/admin/windows/updates/catalog/entries", "Get", "MgWindowsUpdatesCatalogEntry")]
    [InlineData("GET", "/admin/windows/updates/catalog/entries/{catalogEntry-id}", "Get", "MgWindowsUpdatesCatalogEntry")]
    [InlineData("GET", "/admin/windows/updates/catalog/entries/$count", "Get", "MgWindowsUpdatesCatalogEntryCount")]
    [InlineData("POST", "/admin/windows/updates/deployments", "New", "MgWindowsUpdatesDeployment")]
    [InlineData("GET", "/admin/windows/updates/deployments/{deployment-id}/audience/applicableContent", "Get", "MgWindowsUpdatesDeploymentAudienceApplicableContent")]
    [InlineData("GET", "/admin/windows/updates/deployments/{deployment-id}/audience/exclusions/$count", "Get", "MgWindowsUpdatesDeploymentAudienceExclusionCount")]
    [InlineData("GET", "/admin/windows/updates/deployments/{deployment-id}/audience/members/{updatableAsset-id}", "Get", "MgWindowsUpdatesDeploymentAudienceMember")]
    [InlineData("GET", "/admin/windows/updates/policies", "Get", "MgWindowsUpdatesPolicy")]
    [InlineData("PATCH", "/admin/windows/updates/policies/{policy-id}", "Update", "MgWindowsUpdatesPolicy")]
    [InlineData("GET", "/admin/windows/updates/policies/$count", "Get", "MgWindowsUpdatesPolicyCount")]
    [InlineData("GET", "/admin/windows/updates/updatePolicies", "Get", "MgWindowsUpdatesUpdatePolicy")]
    [InlineData("POST", "/admin/windows/updates/updatePolicies", "New", "MgWindowsUpdatesUpdatePolicy")]
    [InlineData("PATCH", "/admin/windows/updates/updatePolicies/{updatePolicy-id}", "Update", "MgWindowsUpdatesUpdatePolicy")]
    [InlineData("GET", "/admin/windows/updates/updatePolicies/$count", "Get", "MgWindowsUpdatesUpdatePolicyCount")]
    [InlineData("GET", "/admin/windows/updates/updatePolicies/{updatePolicy-id}/audience", "Get", "MgWindowsUpdatesPolicyAudience")]
    [InlineData("GET", "/admin/windows/updates/updatePolicies/{updatePolicy-id}/complianceChanges", "Get", "MgWindowsUpdatesPolicyComplianceChange")]
    [InlineData("GET", "/admin/windows/updates/products/{product-id}/revisions/{productRevision-id}/catalogEntry", "Get", "MgWindowsUpdatesProductRevisionCatalogEntry")]
    [InlineData("GET", "/admin/windows/updates/resourceConnections", "Get", "MgWindowsUpdatesResourceConnection")]
    [InlineData("POST", "/admin/windows/updates/deployments/{deployment-id}/audience/microsoft.graph.windowsUpdates.updateAudienceById", "Invoke", "MgWindowsUpdatesDeploymentAudienceUpdateAudienceById")]
    [InlineData("POST", "/admin/windows/updates/updatableAssets/{updatableAsset-id}/microsoft.graph.windowsUpdates.addMembers", "Invoke", "MgWindowsUpdatesUpdatableAssetAddMembers")]
    [InlineData("GET", "/admin/windows/updates/products/microsoft.graph.windowsUpdates.findByCatalogId(catalogID='{catalogID}')", "Get", "MgWindowsUpdatesProductFindByCatalogIdWithCatalogID")]
    [InlineData("GET", "/admin/windows/updates/products/{product-id}/microsoft.graph.windowsUpdates.getKnownIssuesByTimeRange(daysInPast={daysInPast},includeAllActive=@includeAllActive)", "Get", "MgWindowsUpdatesProductGetKnownIssuesByTimeRangeWithDaysInPastWithIncludeAllActive")]
    public void SharedSubjectRenamesPreserveSelectedAndNeighboringNames(
        string method, string path, string expectedVerb, string expectedNoun)
    {
        var route = Assert.Single(Compatible.Value, route => route.Method == method && route.Path == path);
        var config = new GeneratorConfig("Test.Client", "unused");
        Assert.False(CmdletConfigurator.IsSuppressed(new HttpMethod(method), path, config, apiVersion: "beta"));
        var name = Naming.Resolve(new OperationInfo(new HttpMethod(method), path, Kind: route.Kind), config, apiVersion: "beta");
        Assert.Equal(expectedVerb, name.VerbName);
        Assert.Equal(expectedNoun, name.Noun);
    }

    [Theory]
    [InlineData("exclusions", "addMembersById", true)]
    [InlineData("exclusions", "removeMembersById", true)]
    [InlineData("exclusions", "enrollAssetsById", false)]
    [InlineData("exclusions", "unenrollAssetsById", false)]
    [InlineData("members", "enrollAssetsById", false)]
    [InlineData("members", "unenrollAssetsById", false)]
    public void DistinctGraphBPreIdLegacySubjectsRemainAvailable(string navigation, string action, bool item)
    {
        var path = "/admin/windows/updates/deployments/{deployment-id}/audience/" +
            navigation + (item ? "/{updatableAsset-id}" : "") + "/microsoft.graph.windowsUpdates." + action;
        var old = Assert.Single(Legacy.Value, route => route.Method == "POST" && route.Path == path);
        Assert.Contains("GraphBPreId", old.OperationId);
        var current = Assert.Single(Compatible.Value, route => route.Method == "POST" && route.Path == path);
        Assert.Equal(OperationKind.Action, current.Kind);
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Post, path,
            new GeneratorConfig("Test.Client", "unused"), apiVersion: "beta"));
    }

    [Theory]
    [InlineData("GET", "/admin/windows/updates/catalog/entries/{id}/catalogEntry")]
    [InlineData("GET", "/admin/windows/updates/deploymentAudiencesArchive")]
    [InlineData("POST", "/admin/windows/updates/deployments/{id}/audience/applicableContent")]
    [InlineData("POST", "/admin/windows/updates/updatableAssets/{id}/microsoft.graph.windowsUpdates.addMembers")]
    [InlineData("POST", "/admin/windows/updates/updatePolicies/{id}/audience/exclusions/{id}/microsoft.graph.windowsUpdates.addMembers")]
    [InlineData("GET", "/admin/windows/updates/deployments/{id}/audience/members/microsoft.graph.windowsUpdates.enrollAssets")]
    [InlineData("POST", "/admin/windows/updates/deployments/{id}/audience/exclusions/microsoft.graph.windowsUpdates.enrollAssets/child")]
    public void SuppressionDoesNotLeakAcrossMethodsRoutesOrSubtrees(string method, string path)
    {
        Assert.False(CmdletConfigurator.IsSuppressed(new HttpMethod(method), path, apiVersion: "beta"));
    }

    [Fact]
    public void MissingCompatibleV1IsExplicitlyExcludedAndTemporaryAliasIsDeferred()
    {
        Assert.False(File.Exists(Path.Combine(RepoRoot, "openApiDocs_KiotaCompat", "v1.0", "WindowsUpdates.yml")));
        using var ledger = ReadLedger();
        var mappings = ledger.RootElement.GetProperty("mappings").EnumerateArray().ToArray();
        Assert.Equal(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 10 },
            mappings.Select(mapping => mapping.GetProperty("directiveIndex").GetInt32()).ToArray());
        foreach (var mapping in mappings)
        {
            var profile = mapping.GetProperty("profiles").GetProperty("v1.0");
            Assert.True(profile.GetProperty("excluded").GetBoolean());
            Assert.Empty(profile.GetProperty("operations").EnumerateArray());
            Assert.False(profile.TryGetProperty("absenceExpected", out _));
            Assert.False(profile.TryGetProperty("operationIdSource", out _));
        }
    }

    private static JsonDocument ReadLedger() => JsonDocument.Parse(File.ReadAllText(
        Path.Combine(RepoRoot, "src", "WindowsUpdates", "wrapper", "WindowsUpdates_directiveMigrationMap.json")));

    private static JsonElement Mapping(JsonDocument ledger, int index) => Assert.Single(
        ledger.RootElement.GetProperty("mappings").EnumerateArray(),
        mapping => mapping.GetProperty("directiveIndex").GetInt32() == index);

    private static string Normalize(string path) => CmdletConfigurator.NormalizePathTemplate(path);

    private static IReadOnlyList<Route> ReadRoutes(string source)
    {
        var settings = new OpenApiReaderSettings();
        settings.AddYamlReader();
        using var stream = File.OpenRead(Path.Combine(RepoRoot, source, "beta", "WindowsUpdates.yml"));
        var document = OpenApiDocument.LoadAsync(stream, settings: settings, cancellationToken: CancellationToken.None)
            .GetAwaiter().GetResult().Document!;
        return document.Paths.SelectMany(path => path.Value.Operations!.Select(operation =>
        {
            var kind = OperationKind.Resource;
            if (operation.Value.Extensions?.TryGetValue("x-ms-docs-operation-type", out var extension) == true &&
                extension is JsonNodeExtension node)
                kind = node.Node?.ToString()?.Trim('"') switch
                {
                    "action" when operation.Key == HttpMethod.Post => OperationKind.Action,
                    "function" when operation.Key == HttpMethod.Get => OperationKind.Function,
                    _ => OperationKind.Resource,
                };
            return new Route(operation.Key.Method.ToUpperInvariant(), path.Key, operation.Value.OperationId!, kind);
        })).ToArray();
    }

    private static string FindRepoRoot()
    {
        var directory = new DirectoryInfo(AppContext.BaseDirectory);
        while (directory is not null && !Directory.Exists(Path.Combine(directory.FullName, "src", "WindowsUpdates")))
            directory = directory.Parent;
        return directory?.FullName ?? throw new InvalidOperationException("Could not locate WindowsUpdates sources.");
    }

    private sealed record Route(string Method, string Path, string OperationId, OperationKind Kind);
}
