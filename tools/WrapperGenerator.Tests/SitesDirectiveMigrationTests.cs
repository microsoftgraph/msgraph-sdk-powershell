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

public sealed class SitesDirectiveMigrationTests
{
    [Theory]
    [InlineData("/sites/{site-id}/sites", "MgSubSite")]
    [InlineData("/sites/{site-id}/sites/{child-id}", "MgSubSite")]
    [InlineData("/sites/{site-id}/sites/$count", "MgSubSiteCount")]
    [InlineData("/groups/{group-id}/sites/{site-id}/sites", "MgGroupSubSite")]
    [InlineData("/groups/{group-id}/sites/{site-id}/sites/{child-id}", "MgGroupSubSite")]
    [InlineData("/groups/{group-id}/sites/{site-id}/sites/$count", "MgGroupSubSiteCount")]
    [InlineData("/sites/{site-id}/lists", "MgSiteList")]
    [InlineData("/sites/{site-id}/lists/{list-id}", "MgSiteList")]
    [InlineData("/groups/{group-id}/sites/{site-id}/lists", "MgGroupSiteList")]
    [InlineData("/groups/{group-id}/sites/{site-id}/lists/{list-id}", "MgGroupSiteList")]
    [InlineData("/sites/{site-id}/drive", "MgSiteDefaultDrive")]
    [InlineData("/groups/{group-id}/sites/{site-id}/drive", "MgGroupSiteDefaultDrive")]
    [InlineData("/sites/getAllSites()", "MgAllSite")]
    public void SharedRenamesPreservePublishedNounsInBothProfiles(string path, string noun)
    {
        foreach (var profile in new[] { "v1.0", "beta" })
        foreach (var useCollisionData in new[] { false, true })
        {
            var config = new GeneratorConfig("Test.Client", "unused", useCollisionData);
            var kind = path.EndsWith("()", StringComparison.Ordinal) ? OperationKind.Function : OperationKind.Resource;
            var naming = Naming.Resolve(new OperationInfo(HttpMethod.Get, path, Kind: kind), config, apiVersion: profile);
            Assert.Equal("Get", naming.VerbName);
            Assert.Equal(noun, naming.Noun);
            Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get, path, config, apiVersion: profile));
        }
    }

    [Theory]
    [InlineData("GET", "/sites", "MgSite")]
    [InlineData("GET", "/sites/{site-id}", "MgSite")]
    [InlineData("PATCH", "/sites/{site-id}", "MgSite")]
    [InlineData("GET", "/sites/$count", "MgSiteCount")]
    [InlineData("GET", "/groups/{group-id}/sites", "MgGroupSite")]
    [InlineData("GET", "/groups/{group-id}/sites/{site-id}", "MgGroupSite")]
    [InlineData("GET", "/groups/{group-id}/sites/$count", "MgGroupSiteCount")]
    [InlineData("POST", "/sites/{site-id}/lists", "MgSiteList")]
    [InlineData("DELETE", "/sites/{site-id}/lists/{list-id}", "MgSiteList")]
    public void SharedDirectivesDoNotChangeNeighboringRoutes(string method, string path, string noun)
    {
        foreach (var profile in new[] { "v1.0", "beta" })
        foreach (var useCollisionData in new[] { false, true })
        {
            var config = new GeneratorConfig("Test.Client", "unused", useCollisionData);
            var httpMethod = new HttpMethod(method);
            Assert.False(CmdletConfigurator.IsSuppressed(httpMethod, path, config, apiVersion: profile));
            Assert.Equal(noun, Naming.Resolve(new OperationInfo(httpMethod, path), config, apiVersion: profile).Noun);
        }
    }

    [Fact]
    public void NewSiteSuppressionDoesNotRemoveReadOrUpdate()
    {
        foreach (var profile in new[] { "v1.0", "beta" })
        foreach (var useCollisionData in new[] { false, true })
        {
            var config = new GeneratorConfig("Test.Client", "unused", useCollisionData);
            Assert.True(CmdletConfigurator.IsSuppressed(HttpMethod.Post, "/sites", config, apiVersion: profile));
            Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get, "/sites", config, apiVersion: profile));
            Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Patch, "/sites/{site-id}", config, apiVersion: profile));
        }
    }

    [Fact]
    public void OriginalMalformedSelectorIsNotAnApiAbsenceAssertion()
    {
        using var ledger = JsonDocument.Parse(File.ReadAllText(Path.Combine(FindRepoRoot(), "src", "Sites", "wrapper", "Sites_directiveMigrationMap.json")));
        var original = ledger.RootElement.GetProperty("audit").GetProperty("originalInvalidOperationIdSelector").GetString()!;
        Assert.Throws<RegexParseException>(() => new Regex(original));
        Assert.Equal(1, original.Count(character => character == '(') - original.Count(character => character == ')'));
        var source = File.ReadAllText(Path.Combine(FindRepoRoot(), "src", "Sites", "Sites.md"));
        var active = Regex.Match(source, @"(?m)^\s+- remove-path-by-operation: (.+)$").Groups[1].Value.TrimEnd('\r');
        Assert.Equal(original + ")", active);
        Assert.Contains("# Original invalid selector: " + original, source);
    }

    [Theory]
    [InlineData("v1.0", 196)]
    [InlineData("beta", 227)]
    public void CorrectedSelectorAccountsForAllLegacyMatchesWithoutExtraSuppressions(string profile, int expectedCount)
    {
        var root = FindRepoRoot();
        var legacy = ReadSpec(Path.Combine(root, "openApiDocs", profile, "Sites.yml"));
        var current = ReadSpec(Path.Combine(root, "openApiDocs_KiotaCompat", profile, "Sites.yml"));
        var source = File.ReadAllText(Path.Combine(root, "src", "Sites", "Sites.md"));
        var selector = new Regex(Regex.Match(source, @"(?m)^\s+- remove-path-by-operation: (.+)$").Groups[1].Value.TrimEnd('\r'));
        var selected = legacy.Paths.SelectMany(path => path.Value.Operations!
            .Where(operation => selector.IsMatch(operation.Value.OperationId!))
            .Select(operation => $"{operation.Key.Method.ToUpperInvariant()} {path.Key} [{operation.Value.OperationId}]"))
            .ToHashSet(StringComparer.Ordinal);
        Assert.Equal(expectedCount, selected.Count);
        using var ledger = JsonDocument.Parse(File.ReadAllText(Path.Combine(root, "src", "Sites", "wrapper", "Sites_directiveMigrationMap.json")));
        var mappings = ledger.RootElement.GetProperty("mappings").EnumerateArray().ToArray();
        Assert.Equal(13, mappings.Length);
        var first = mappings.Single(mapping => mapping.GetProperty("directiveIndex").GetInt32() == 1)
            .GetProperty("profiles").GetProperty(profile);
        Assert.False(first.TryGetProperty("operationIdSource", out _));
        Assert.False(first.TryGetProperty("removedLegacyOperations", out _));
        var lineage = ledger.RootElement.GetProperty("audit").GetProperty("originalSelectorLineage").GetProperty(profile).EnumerateArray().ToArray();
        var reviewedLegacy = lineage
            .Select(row => $"{row.GetProperty("originalMethod").GetString()} {row.GetProperty("originalPath").GetString()} [{row.GetProperty("originalOperationId").GetString()}]")
            .ToHashSet(StringComparer.Ordinal);
        Assert.True(selected.SetEquals(reviewedLegacy), "The complete actual corrected-selector legacy set must be recorded.");
        var reviewedCurrent = first.GetProperty("operations").EnumerateArray()
            .Select(row => $"{row.GetProperty("method").GetString()} {row.GetProperty("path").GetString()} [{row.GetProperty("operationId").GetString()}]").ToHashSet(StringComparer.Ordinal);
        var literal = current.Paths.SelectMany(path => path.Value.Operations!
            .Where(operation => selector.IsMatch(operation.Value.OperationId!))
            .Select(operation => $"{operation.Key.Method.ToUpperInvariant()} {path.Key} [{operation.Value.OperationId}]")).ToHashSet(StringComparer.Ordinal);
        Assert.True(literal.SetEquals(reviewedCurrent));
        Assert.True(reviewedCurrent.SetEquals(lineage.Select(row =>
            $"{row.GetProperty("currentMethod").GetString()} {row.GetProperty("currentPath").GetString()} [{row.GetProperty("currentOperationId").GetString()}]")));
        foreach (var row in lineage)
        {
            var oldPath = row.GetProperty("originalPath").GetString()!;
            var path = row.GetProperty("currentPath").GetString()!;
            var method = new HttpMethod(row.GetProperty("originalMethod").GetString()!);
            Assert.Equal(row.GetProperty("originalOperationId").GetString(), legacy.Paths[oldPath].Operations![method].OperationId);
            Assert.Equal(row.GetProperty("currentOperationId").GetString(), current.Paths[path].Operations![method].OperationId);
            var exact = NormalizeLineagePath(oldPath);
            if (exact != NormalizeLineagePath(path))
            {
                var oldOperation = legacy.Paths[oldPath].Operations![method];
                var newOperation = current.Paths[path].Operations![method];
                var oldKind = Assert.IsType<JsonNodeExtension>(oldOperation.Extensions!["x-ms-docs-operation-type"]).Node!.ToString().Trim('"');
                var newKind = Assert.IsType<JsonNodeExtension>(newOperation.Extensions!["x-ms-docs-operation-type"]).Node!.ToString().Trim('"');
                Assert.Equal(oldKind, newKind);
                Assert.True(oldKind == "action" && method == HttpMethod.Post || oldKind == "function" && method == HttpMethod.Get);
                Assert.Equal(NormalizeLineagePath(Regex.Replace(oldPath, @"/microsoft\.graph\.([^/]+)$", "/$1")), NormalizeLineagePath(path));
            }
            Assert.Single(current.Paths, candidate => NormalizeLineagePath(candidate.Key) == NormalizeLineagePath(path)
                && candidate.Value.Operations!.ContainsKey(method));
        }
        var suppressions = mappings.Where(mapping => mapping.GetProperty("directiveIndex").GetInt32() is 1 or 2)
            .SelectMany(mapping => mapping.GetProperty("profiles").GetProperty(profile).GetProperty("operations").EnumerateArray())
            .Select(row => $"{row.GetProperty("method").GetString()} {row.GetProperty("path").GetString()}")
            .ToHashSet(StringComparer.Ordinal);
        var config = new GeneratorConfig("Test.Client", "unused", UseCollisionData: false);
        foreach (var path in current.Paths)
        foreach (var operation in path.Value.Operations!)
        {
            var normalized = CmdletConfigurator.NormalizePathTemplate(path.Key);
            var existingCurated = normalized.StartsWith("/sites/{}/termstores/{}", StringComparison.Ordinal)
                || normalized.StartsWith("/groups/{}/sites/{}/termstores/{}", StringComparison.Ordinal)
                || operation.Key == HttpMethod.Get && normalized is "/sites/{}/termstore" or "/groups/{}/sites/{}/termstore";
            var expected = existingCurated || suppressions.Contains($"{operation.Key.Method.ToUpperInvariant()} {path.Key}");
            Assert.Equal(expected, CmdletConfigurator.IsSuppressed(operation.Key, path.Key, config, apiVersion: profile));
        }
    }

    [Theory]
    [InlineData("v1.0")]
    [InlineData("beta")]
    public void EveryReviewedRouteRetainsItsRealSourceIdentityAndDisposition(string profile)
    {
        var root = FindRepoRoot();
        var legacy = ReadSpec(Path.Combine(root, "openApiDocs", profile, "Sites.yml"));
        var current = ReadSpec(Path.Combine(root, "openApiDocs_KiotaCompat", profile, "Sites.yml"));
        using var ledger = JsonDocument.Parse(File.ReadAllText(Path.Combine(root, "src", "Sites", "wrapper", "Sites_directiveMigrationMap.json")));
        foreach (var mapping in ledger.RootElement.GetProperty("mappings").EnumerateArray())
        {
            var index = mapping.GetProperty("directiveIndex").GetInt32();
            var operations = mapping.GetProperty("profiles").GetProperty(profile).GetProperty("operations");
            foreach (var row in operations.EnumerateArray())
            {
                var method = new HttpMethod(row.GetProperty("method").GetString()!);
                var path = row.GetProperty("path").GetString()!;
                Assert.Equal(row.GetProperty("operationId").GetString(), current.Paths[path].Operations![method].OperationId);
                Assert.False(row.TryGetProperty("legacyPath", out _));
                Assert.False(row.TryGetProperty("legacyOperationId", out _));
                foreach (var useCollisionData in new[] { false, true })
                {
                    var config = new GeneratorConfig("Test.Client", "unused", useCollisionData);
                    if (index is 1 or 2 or 3)
                    {
                        Assert.True(CmdletConfigurator.IsSuppressed(method, path, config, apiVersion: profile), $"{profile} directive {index}: {method} {path}");
                        continue;
                    }
                    Assert.False(CmdletConfigurator.IsSuppressed(method, path, config, apiVersion: profile));
                    var expected = index switch
                    {
                        4 => "MgSubSite",
                        5 => "MgSubSiteCount",
                        6 => "MgSiteList",
                        7 => "MgGroupSubSite",
                        8 => "MgGroupSubSiteCount",
                        9 => "MgGroupSiteList",
                        10 => path.StartsWith("/groups/", StringComparison.Ordinal) ? "MgGroupSiteDefaultDrive" : "MgSiteDefaultDrive",
                        12 => "MgAllSite",
                        _ => throw new InvalidOperationException($"Unexpected surviving directive {index}."),
                    };
                    var kind = index == 12 ? OperationKind.Function : OperationKind.Resource;
                    Assert.Equal(expected, Naming.Resolve(new OperationInfo(method, path, Kind: kind), config, apiVersion: profile).Noun);
                }
            }
            if (index is 11 or 13)
            {
                Assert.Empty(operations.EnumerateArray());
                Assert.DoesNotContain(legacy.Paths.Keys, path => path.StartsWith("/sites/{site-id}/onenote", StringComparison.Ordinal));
                Assert.DoesNotContain(current.Paths.Keys, path => path.StartsWith("/sites/{site-id}/onenote", StringComparison.Ordinal));
            }
        }
    }

    [Fact]
    public void RecursiveRouteEvidenceRetainsAllActualOperationsAndSourceBackedNames()
    {
        var root = FindRepoRoot();
        var legacy = ReadSpec(Path.Combine(root, "openApiDocs", "beta", "Sites.yml"));
        var current = ReadSpec(Path.Combine(root, "openApiDocs_KiotaCompat", "beta", "Sites.yml"));
        using var evidence = JsonDocument.Parse(File.ReadAllText(Path.Combine(root, "src", "Sites", "wrapper", "Sites_multiRouteEvidence.json")));
        var groups = evidence.RootElement.GetProperty("groups").EnumerateArray().ToArray();
        Assert.Equal(84, groups.Length);
        var exactRoutes = new HashSet<string>(StringComparer.Ordinal);
        var config = new GeneratorConfig("Test.Client", "unused");
        foreach (var group in groups)
        foreach (var route in group.GetProperty("routes").EnumerateArray())
        {
            var method = new HttpMethod(route.GetProperty("method").GetString()!);
            var path = route.GetProperty("path").GetString()!;
            Assert.True(exactRoutes.Add($"{method} {path}"));
            Assert.Equal(route.GetProperty("operationId").GetString(), current.Paths[path].Operations![method].OperationId);
            Assert.Equal(route.GetProperty("legacyOperationId").GetString(),
                legacy.Paths[route.GetProperty("legacyPath").GetString()!].Operations![method].OperationId);
            foreach (var useCollisionData in new[] { false, true })
            {
                var naming = Naming.Resolve(new OperationInfo(method, path), config with { UseCollisionData = useCollisionData }, apiVersion: "beta");
                Assert.False(CmdletConfigurator.IsSuppressed(method, path, config with { UseCollisionData = useCollisionData }, apiVersion: "beta"));
                Assert.Equal(route.GetProperty("currentPublicCommand").GetString(), $"{naming.VerbName}-{naming.Noun}");
                if (route.GetProperty("name").GetString() == "Direct")
                    Assert.Equal(group.GetProperty("publicCommand").GetString(), $"{naming.VerbName}-{naming.Noun}");
                else
                    Assert.Contains("NestedChild", naming.Noun);
            }
        }
        Assert.Equal(192, exactRoutes.Count);
    }

    [Fact]
    public void BetaPublishedDefaultsUsePinnedSyntaxAndUniqueActualPathContractsNotLossyUris()
    {
        var root = FindRepoRoot();
        using var evidence = JsonDocument.Parse(File.ReadAllText(Path.Combine(root, "src", "Sites", "wrapper", "Sites_multiRouteEvidence.json")));
        var current = ReadSpec(Path.Combine(root, "openApiDocs_KiotaCompat", "beta", "Sites.yml"));
        var metadataDisagreements = 0;
        foreach (var group in evidence.RootElement.GetProperty("groups").EnumerateArray())
        {
            var proof = group.GetProperty("publishedDefaultProof");
            Assert.Equal("UniqueDefaultContract", proof.GetProperty("status").GetString());
            Assert.Equal("07b0cf8f6305213f3c3830c301fca69a3e82ed17", proof.GetProperty("sourceCommit").GetString());
            Assert.Contains("/07b0cf8f6305213f3c3830c301fca69a3e82ed17/", proof.GetProperty("url").GetString()!);
            Assert.Matches("^[A-F0-9]{64}$", proof.GetProperty("contentSha256").GetString()!);
            var mandatory = Regex.Matches(proof.GetProperty("syntax").GetString()!, @"(?<!\[)-(?<name>[A-Za-z][A-Za-z0-9]*)\s+<")
                .Select(match => match.Groups["name"].Value).ToHashSet(StringComparer.Ordinal);
            Assert.True(mandatory.SetEquals(proof.GetProperty("mandatoryParameters").EnumerateArray().Select(value => value.GetString()!)));
            var requiredIds = mandatory.Where(name => Regex.IsMatch(name, @"Id\d*$")).ToHashSet(StringComparer.Ordinal);
            var matches = group.GetProperty("routes").EnumerateArray().Where(route =>
                requiredIds.SetEquals(Naming.Resolve(new OperationInfo(
                    new HttpMethod(route.GetProperty("method").GetString()!), route.GetProperty("path").GetString()!)).PathParamNames)).ToArray();
            var actual = Assert.Single(matches);
            Assert.Equal("Direct", actual.GetProperty("name").GetString());
            Assert.Equal("Direct", group.GetProperty("defaultRoute").GetString());
            var recorded = Assert.Single(proof.GetProperty("candidateRoutes").EnumerateArray());
            Assert.Equal(actual.GetProperty("path").GetString(), recorded.GetProperty("path").GetString());
            var operation = current.Paths[actual.GetProperty("path").GetString()!].Operations![new HttpMethod(actual.GetProperty("method").GetString()!)];
            Assert.DoesNotContain(operation.Parameters ?? [], parameter => parameter.Required && parameter.In != ParameterLocation.Path);
            if (group.GetProperty("metadataRouteCandidate").GetString() != group.GetProperty("defaultRoute").GetString())
                metadataDisagreements++;
        }
        Assert.Equal(60, metadataDisagreements);
    }

    [Fact]
    public void BetaRecursiveRouteFamiliesHaveMatchingBodyResponseAndQueryContracts()
    {
        var root = FindRepoRoot();
        using var evidence = JsonDocument.Parse(File.ReadAllText(Path.Combine(root, "src", "Sites", "wrapper", "Sites_multiRouteEvidence.json")));
        var current = ReadSpec(Path.Combine(root, "openApiDocs_KiotaCompat", "beta", "Sites.yml"));
        foreach (var group in evidence.RootElement.GetProperty("groups").EnumerateArray())
        {
            var shapes = group.GetProperty("routes").EnumerateArray().GroupBy(route =>
            {
                var path = route.GetProperty("path").GetString()!;
                return route.GetProperty("method").GetString() == "GET" && path.EndsWith('}') ? "Item" : "CollectionOrSingle";
            });
            foreach (var shape in shapes)
            {
                var contracts = shape.Select(route =>
                {
                    var path = route.GetProperty("path").GetString()!;
                    var operation = current.Paths[path].Operations![new HttpMethod(route.GetProperty("method").GetString()!)];
                    var body = MediaSignature(operation.RequestBody?.Content);
                    var response = string.Join("|", operation.Responses!.OrderBy(pair => pair.Key).Select(pair =>
                        $"{pair.Key}:{MediaSignature(pair.Value.Content)}"));
                    var parameters = string.Join("|", (operation.Parameters ?? []).Concat(current.Paths[path].Parameters ?? [])
                        .Where(parameter => parameter.In != ParameterLocation.Path)
                        .OrderBy(parameter => parameter.In).ThenBy(parameter => parameter.Name)
                        .Select(parameter => $"{parameter.In}:{parameter.Name}:{parameter.Required}:{SchemaSignature(parameter.Schema)}"));
                    return $"{body};{response};{parameters}";
                }).Distinct(StringComparer.Ordinal);
                Assert.Single(contracts);
            }
        }
    }

    [Fact]
    public void SixAmbiguousOriginalChildFamiliesHaveDistinctNamesNotUnsupportedSelectors()
    {
        using var evidence = JsonDocument.Parse(File.ReadAllText(Path.Combine(FindRepoRoot(), "src", "Sites", "wrapper", "Sites_multiRouteEvidence.json")));
        var ambiguousGroups = 0;
        var ordinaryGroups = 0;
        foreach (var group in evidence.RootElement.GetProperty("groups").EnumerateArray())
        {
            var routes = group.GetProperty("routes").EnumerateArray().ToArray();
            var duplicates = routes.GroupBy(route => string.Join(",", Naming.Resolve(new OperationInfo(
                    new HttpMethod(route.GetProperty("method").GetString()!), route.GetProperty("path").GetString()!))
                .PathParamNames.OrderBy(name => name, StringComparer.Ordinal)), StringComparer.Ordinal)
                .Where(contract => contract.Count() > 1).ToArray();
            if (duplicates.Length == 0)
            {
                ordinaryGroups++;
                continue;
            }
            ambiguousGroups++;
            Assert.False(group.TryGetProperty("selectorParameter", out _));
            Assert.False(group.TryGetProperty("allowAsymmetricRoutes", out _));
            Assert.False(group.TryGetProperty("allowExplicitRouteSelection", out _));
            Assert.False(group.TryGetProperty("allowPublishedParameterInference", out _));
            Assert.Equal(4, routes.Length);
            Assert.EndsWith("Child", group.GetProperty("publicCommand").GetString()!);
            var sharedContract = Assert.Single(duplicates).ToArray();
            Assert.Equal(2, sharedContract.Length);
            Assert.Contains(sharedContract, route => route.GetProperty("name").GetString() == "Direct"
                && route.GetProperty("path").GetString()!.EndsWith('}'));
            Assert.Contains(sharedContract, route => route.GetProperty("name").GetString() == "Nested"
                && route.GetProperty("path").GetString()!.EndsWith("/children", StringComparison.Ordinal));
            Assert.Equal(2, sharedContract.Select(route => route.GetProperty("currentPublicCommand").GetString()).Distinct(StringComparer.Ordinal).Count());
        }
        Assert.Equal(6, ambiguousGroups);
        Assert.Equal(78, ordinaryGroups);
    }

    [Fact]
    public void EveryRecursiveGetFamilyIsAnActualStructuralListItemPair()
    {
        using var evidence = JsonDocument.Parse(File.ReadAllText(Path.Combine(FindRepoRoot(), "src", "Sites", "wrapper", "Sites_multiRouteEvidence.json")));
        var pairs = 0;
        foreach (var group in evidence.RootElement.GetProperty("groups").EnumerateArray())
        {
            var routes = group.GetProperty("routes").EnumerateArray().ToArray();
            if (routes.Length != 4)
                continue;
            foreach (var family in routes.GroupBy(route => route.GetProperty("name").GetString()))
            {
                var list = Assert.Single(family, route => !route.GetProperty("path").GetString()!.EndsWith('}'));
                var item = Assert.Single(family, route => route.GetProperty("path").GetString()!.EndsWith('}'));
                var listNaming = Naming.Resolve(new OperationInfo(HttpMethod.Get, list.GetProperty("path").GetString()!));
                var itemNaming = Naming.Resolve(new OperationInfo(HttpMethod.Get, item.GetProperty("path").GetString()!));
                Assert.True(Naming.IsListItemPair(listNaming, itemNaming), $"{group.GetProperty("publicCommand").GetString()} {family.Key}");
                pairs++;
            }
        }
        Assert.Equal(24, pairs);
    }

    private static string SchemaSignature(IOpenApiSchema? schema) =>
        schema is OpenApiSchemaReference reference ? $"ref:{reference.Reference?.Id}"
            : schema is null ? "none" : $"{schema.Type}:{schema.Format}:{SchemaSignature(schema.Items)}";

    private static string MediaSignature(IDictionary<string, IOpenApiMediaType>? content) =>
        content is null ? "" : string.Join("|", content.OrderBy(pair => pair.Key).Select(pair => $"{pair.Key}:{SchemaSignature(pair.Value.Schema)}"));

    private static string NormalizeLineagePath(string path) =>
        Regex.Replace(path, @"\{[^}]*\}", "{}").Replace("()", "", StringComparison.Ordinal).ToLowerInvariant();

    private static OpenApiDocument ReadSpec(string path)
    {
        var settings = new OpenApiReaderSettings();
        settings.AddYamlReader();
        using var stream = File.OpenRead(path);
        var result = OpenApiDocument.LoadAsync(stream, settings: settings, cancellationToken: CancellationToken.None).GetAwaiter().GetResult();
        return result.Document ?? throw new InvalidOperationException($"Could not read {path}.");
    }

    private static string FindRepoRoot()
    {
        var directory = new DirectoryInfo(AppContext.BaseDirectory);
        while (directory is not null && !File.Exists(Path.Combine(directory.FullName, "src", "Sites", "Sites.md")))
            directory = directory.Parent;
        return directory?.FullName ?? throw new InvalidOperationException("Could not locate the Sites shared source.");
    }
}
