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

public sealed class PeopleDirectiveMigrationTests
{
    private const string Analytics = "/users/{user-id}/analytics";
    private const string Statistics = Analytics + "/activityStatistics";
    private const string StatisticsItem = Statistics + "/{activityStatistics-id}";
    private static readonly string RepoRoot = FindRepoRoot();

    [Theory]
    [InlineData("v1.0", 0)]
    [InlineData("beta", 3)]
    public void CurrentLiteralSelectorEqualsEveryOriginalLegacySelectedSurvivor(string profile, int count)
    {
        var source = File.ReadAllText(Path.Combine(RepoRoot, "src", "People", "People.md"));
        var selector = Regex.Match(source, @"(?m)^\s+- remove-path-by-operation: ([^\r\n]+)\r?$").Groups[1].Value;
        Assert.NotEmpty(selector);
        var legacy = ReadOperations("openApiDocs", profile);
        var compatible = ReadOperations("openApiDocs_KiotaCompat", profile);
        var selected = legacy.Where(op => Regex.IsMatch(op.Id, selector)).ToArray();
        var literal = compatible.Where(op => Regex.IsMatch(op.Id, selector)).ToArray();
        Assert.Equal(count, selected.Length);
        Assert.Equal(count, literal.Length);
        using var ledger = ReadLedger();
        var profileMapping = ledger.RootElement.GetProperty("mappings")[0].GetProperty("profiles")
            .GetProperty(profile);
        Assert.False(profileMapping.TryGetProperty("operationIdSource", out _));
        var evidence = profileMapping.GetProperty("operations").EnumerateArray().ToArray();
        Assert.Equal(count, evidence.Length);
        var lineage = ledger.RootElement.GetProperty("audit").GetProperty("legacySuppressionLineage")
            .EnumerateArray().ToArray();

        foreach (var old in selected)
        {
            var current = Assert.Single(compatible, op => op.Method == old.Method && op.Path == old.Path);
            Assert.Contains(current, literal);
            var bridge = Assert.Single(evidence, op =>
                op.GetProperty("method").GetString() == old.Method &&
                op.GetProperty("path").GetString() == old.Path);
            Assert.Equal(current.Path, bridge.GetProperty("path").GetString());
            Assert.Equal(current.Id, bridge.GetProperty("operationId").GetString());
            Assert.Equal(old.Id, current.Id);
            Assert.False(bridge.TryGetProperty("legacyPath", out _));
            Assert.False(bridge.TryGetProperty("legacyOperationId", out _));
            var original = Assert.Single(lineage, op =>
                op.GetProperty("method").GetString() == old.Method &&
                op.GetProperty("path").GetString() == old.Path);
            Assert.Equal(old.Id, original.GetProperty("operationId").GetString());
            Assert.Equal(current.Id, original.GetProperty("compatibleOperationId").GetString());
            foreach (var useCollisionData in new[] { false, true })
                Assert.True(CmdletConfigurator.IsSuppressed(new HttpMethod(current.Method), current.Path,
                    Config(useCollisionData), apiVersion: profile));
        }

        Assert.All(literal, current =>
            Assert.Single(selected, old => old.Method == current.Method && old.Path == current.Path));
        foreach (var useCollisionData in new[] { false, true })
            Assert.Equal(count, compatible.Count(op =>
                CmdletConfigurator.IsSuppressed(new HttpMethod(op.Method), op.Path,
                    Config(useCollisionData), apiVersion: profile)));
    }

    [Theory]
    [InlineData("GET", Statistics, "Get")]
    [InlineData("POST", Statistics, "New")]
    [InlineData("GET", StatisticsItem, "Get")]
    [InlineData("PATCH", StatisticsItem, "Update")]
    [InlineData("DELETE", StatisticsItem, "Remove")]
    public void RenamesFiveSurvivingStatisticsOperationsWithoutSuppressingThem(string method, string path, string verb)
    {
        var current = Assert.Single(ReadOperations("openApiDocs_KiotaCompat", "beta"),
            op => op.Method == method && op.Path == path);
        var old = Assert.Single(ReadOperations("openApiDocs", "beta"),
            op => op.Method == method && op.Path == path);
        Assert.StartsWith("user.analytic_", old.Id);
        Assert.Equal(old.Id, current.Id);
        using var ledger = ReadLedger();
        var evidence = ledger.RootElement.GetProperty("mappings")[1].GetProperty("profiles")
            .GetProperty("beta").GetProperty("operations").EnumerateArray().ToArray();
        var reviewed = Assert.Single(evidence, op =>
            op.GetProperty("method").GetString() == method && op.GetProperty("path").GetString() == path);
        Assert.Equal(current.Id, reviewed.GetProperty("operationId").GetString());
        foreach (var useCollisionData in new[] { false, true })
        {
            var config = Config(useCollisionData);
            Assert.False(CmdletConfigurator.IsSuppressed(new HttpMethod(method), path, config, apiVersion: "beta"));
            var naming = Naming.Resolve(new OperationInfo(new HttpMethod(method), path), config, apiVersion: "beta");
            Assert.Equal("MgUserActivityStatistics", naming.Noun);
            Assert.Equal(verb, naming.VerbName);
            Assert.Equal(path, naming.SourcePath);
            Assert.Contains(".Analytics.ActivityStatistics", naming.BuilderExpression);
        }
    }

    [Theory]
    [InlineData("v1.0", "GET", "/users/{user-id}/people", "MgUserPerson")]
    [InlineData("v1.0", "GET", "/users/{user-id}/people/{person-id}", "MgUserPerson")]
    [InlineData("v1.0", "GET", "/users/{user-id}/people/$count", "MgUserPersonCount")]
    [InlineData("beta", "GET", "/users/{user-id}/people", "MgUserPerson")]
    [InlineData("beta", "GET", "/users/{user-id}/people/{person-id}", "MgUserPerson")]
    [InlineData("beta", "GET", "/users/{user-id}/people/$count", "MgUserPersonCount")]
    [InlineData("beta", "GET", Statistics + "/$count", "MgUserAnalyticActivityStatisticsCount")]
    [InlineData("beta", "GET", "/users/{user-id}/profile", "MgUserProfile")]
    [InlineData("beta", "POST", "/users/{user-id}/profile/projects", "MgUserProfileProject")]
    [InlineData("beta", "PATCH", "/users/{user-id}/profile/projects/{projectParticipation-id}", "MgUserProfileProject")]
    public void KeepsActualUnaffectedNeighborsAndOriginalRoutes(string profile, string method, string path, string noun)
    {
        Assert.Single(ReadOperations("openApiDocs_KiotaCompat", profile),
            op => op.Method == method && op.Path == path);
        foreach (var useCollisionData in new[] { false, true })
        {
            var config = Config(useCollisionData);
            Assert.False(CmdletConfigurator.IsSuppressed(new HttpMethod(method), path, config, apiVersion: profile));
            var naming = Naming.Resolve(new OperationInfo(new HttpMethod(method), path), config, apiVersion: profile);
            Assert.Equal(noun, naming.Noun);
            Assert.Equal(path, naming.SourcePath);
            Assert.Null(CmdletConfigurator.TryGetOverriddenVerb(new HttpMethod(method), path, config, apiVersion: profile));
        }
    }

    [Theory]
    [InlineData("v1.0")]
    [InlineData("beta")]
    public void InsightRenamesAreReviewedAbsencesInBothRealSources(string profile)
    {
        foreach (var root in new[] { "openApiDocs", "openApiDocs_KiotaCompat" })
        {
            var operations = ReadOperations(root, profile);
            Assert.NotEmpty(operations);
            Assert.DoesNotContain(operations, op => op.Path.Contains("insight", StringComparison.OrdinalIgnoreCase));
            if (profile == "v1.0")
                Assert.DoesNotContain(operations, op => op.Path.StartsWith(Analytics, StringComparison.Ordinal));
        }
    }

    [Fact]
    public void ExactOverridesDoNotBroadenToOtherMethodsOrDescendants()
    {
        foreach (var useCollisionData in new[] { false, true })
        {
            var config = Config(useCollisionData);
            Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Post, Analytics, config, apiVersion: "beta"));
            Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get, Statistics + "/child", config, apiVersion: "beta"));
            Assert.Equal("Original", CmdletConfigurator.ApplyNounOverrides(
                HttpMethod.Get, Statistics + "/$count", "Original", config, apiVersion: "beta"));
            Assert.Equal("Original", CmdletConfigurator.ApplyNounOverrides(
                HttpMethod.Put, StatisticsItem, "Original", config, apiVersion: "beta"));
        }
    }

    private static GeneratorConfig Config(bool useCollisionData) => new("Test.Client", "unused", useCollisionData);

    private static JsonDocument ReadLedger() => JsonDocument.Parse(File.ReadAllText(
        Path.Combine(RepoRoot, "src", "People", "wrapper", "People_directiveMigrationMap.json")));

    private static IReadOnlyList<(string Method, string Path, string Id)> ReadOperations(string root, string profile)
    {
        var settings = new OpenApiReaderSettings();
        settings.AddYamlReader();
        using var stream = File.OpenRead(Path.Combine(RepoRoot, root, profile, "People.yml"));
        var result = OpenApiDocument.LoadAsync(stream, settings: settings, cancellationToken: CancellationToken.None)
            .GetAwaiter().GetResult();
        Assert.NotNull(result.Document);
        return result.Document.Paths.SelectMany(path => path.Value.Operations!
            .Select(op => (op.Key.Method, path.Key, op.Value.OperationId!))).ToArray();
    }

    private static string FindRepoRoot()
    {
        var directory = new DirectoryInfo(AppContext.BaseDirectory);
        while (directory is not null && !Directory.Exists(Path.Combine(directory.FullName, "openApiDocs_KiotaCompat")))
            directory = directory.Parent;
        return directory?.FullName ?? throw new InvalidOperationException("Could not locate compatible spec root.");
    }
}
