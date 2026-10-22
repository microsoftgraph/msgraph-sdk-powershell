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

public sealed class PlannerDirectiveMigrationTests
{
    private static string RepoRoot
    {
        get
        {
            var directory = new DirectoryInfo(AppContext.BaseDirectory);
            while (directory is not null && !Directory.Exists(Path.Combine(directory.FullName, "openApiDocs_KiotaCompat")))
                directory = directory.Parent;
            return directory?.FullName ?? throw new InvalidOperationException("Repository root not found.");
        }
    }

    private static OpenApiDocument ReadSpec(string root, string profile)
    {
        var settings = new OpenApiReaderSettings();
        settings.AddYamlReader();
        using var stream = File.OpenRead(Path.Combine(RepoRoot, root, profile, "Planner.yml"));
        return OpenApiDocument.LoadAsync(stream, settings: settings, cancellationToken: CancellationToken.None)
            .GetAwaiter().GetResult().Document ?? throw new InvalidOperationException("Planner spec could not be read.");
    }

    private static string Key(string method, string path) =>
        method + " " + CmdletConfigurator.NormalizePathTemplate(path);

    [Theory]
    [InlineData("v1.0", 137, 0)]
    [InlineData("beta", 206, 24)]
    public void OriginalLegacySelectorIsCompletelyAccountedFor(string profile, int expectedCount, int expectedTranslations)
    {
        var source = File.ReadAllText(Path.Combine(RepoRoot, "src", "Planner", "Planner.md"));
        var selector = Regex.Match(source, @"remove-path-by-operation: ([^\r\n]+)").Groups[1].Value;
        var legacy = ReadSpec("openApiDocs", profile);
        var matches = legacy.Paths.SelectMany(path => path.Value.Operations!
            .Where(operation => Regex.IsMatch(operation.Value.OperationId!, selector))
            .Select(operation => Key(operation.Key.Method, path.Key) + " " + operation.Value.OperationId))
            .ToHashSet(StringComparer.Ordinal);
        Assert.Equal(expectedCount, matches.Count);

        using var ledger = JsonDocument.Parse(File.ReadAllText(Path.Combine(RepoRoot, "src", "Planner", "wrapper", "Planner_directiveMigrationMap.json")));
        var evidence = ledger.RootElement.GetProperty("mappings")[0].GetProperty("profiles").GetProperty(profile);
        Assert.Equal("Legacy", evidence.GetProperty("operationIdSource").GetString());
        Assert.Empty(evidence.GetProperty("removedLegacyOperations").EnumerateArray());
        var operations = evidence.GetProperty("operations").EnumerateArray().ToArray();
        Assert.Equal(expectedCount, operations.Length);
        Assert.Equal(expectedTranslations, operations.Count(operation => operation.TryGetProperty("legacyPathTranslation", out _)));
        Assert.True(matches.SetEquals(operations.Select(operation =>
            Key(operation.GetProperty("method").GetString()!, operation.GetProperty("legacyPath").GetString()!) +
            " " + operation.GetProperty("legacyOperationId").GetString())));
    }

    [Theory]
    [InlineData("v1.0")]
    [InlineData("beta")]
    public void ExactSharedSuppressionsCoverTheLedgerWithoutSuppressingOtherSpecOperations(string profile)
    {
        using var ledger = JsonDocument.Parse(File.ReadAllText(Path.Combine(RepoRoot, "src", "Planner", "wrapper", "Planner_directiveMigrationMap.json")));
        var expected = new HashSet<string>(StringComparer.Ordinal);
        var compatible = ReadSpec("openApiDocs_KiotaCompat", profile);
        var config = new GeneratorConfig("Test.Client", "unused", profile);
        foreach (var mapping in ledger.RootElement.GetProperty("mappings").EnumerateArray())
        {
            foreach (var operation in mapping.GetProperty("profiles").GetProperty(profile).GetProperty("operations").EnumerateArray())
            {
                var method = operation.GetProperty("method").GetString()!;
                var path = operation.GetProperty("path").GetString()!;
                var actual = compatible.Paths[path].Operations![new HttpMethod(method)];
                Assert.Equal(operation.GetProperty("operationId").GetString(), actual.OperationId);
                expected.Add(Key(method, path));
                Assert.True(CmdletConfigurator.IsSuppressed(new HttpMethod(method), path, config), method + " " + path);
            }
        }
        Assert.NotEmpty(expected);
        foreach (var path in compatible.Paths)
        {
            foreach (var operation in path.Value.Operations!)
                Assert.Equal(expected.Contains(Key(operation.Key.Method, path.Key)),
                    CmdletConfigurator.IsSuppressed(operation.Key, path.Key));
        }
    }

    [Theory]
    [InlineData("GET", "/users/{user-id}/planner/plans")]
    [InlineData("GET", "/users/{user-id}/planner/tasks")]
    [InlineData("GET", "/groups/{group-id}/planner/plans/{plannerPlan-id}/buckets")]
    [InlineData("GET", "/groups/{group-id}/planner/plans/{plannerPlan-id}/tasks")]
    [InlineData("DELETE", "/groups/{group-id}/planner/plans/{plannerPlan-id}/details")]
    [InlineData("GET", "/planner/buckets/{plannerBucket-id}/tasks")]
    [InlineData("GET", "/planner/plans/{plannerPlan-id}/tasks")]
    [InlineData("PATCH", "/planner/tasks/{plannerTask-id}/details")]
    [InlineData("DELETE", "/planner/tasks/{plannerTask-id}/assignedToTaskBoardFormat")]
    public void PublishedResourceNeighborsRemainAvailableInBothProfiles(string method, string path)
    {
        foreach (var profile in new[] { "v1.0", "beta" })
            Assert.False(CmdletConfigurator.IsSuppressed(new HttpMethod(method), path, new("Test.Client", "unused", profile)));
    }

    [Theory]
    [InlineData("GET", "/users/{user-id}/planner/plans/delta()")]
    [InlineData("GET", "/users/{user-id}/planner/tasks/delta()")]
    [InlineData("POST", "/users/{user-id}/planner/plans/{plannerPlan-id}/archive")]
    [InlineData("POST", "/users/{user-id}/planner/plans/{plannerPlan-id}/unarchive")]
    [InlineData("POST", "/users/{user-id}/planner/plans/{plannerPlan-id}/moveToContainer")]
    [InlineData("GET", "/users/{user-id}/planner/plans/{plannerPlan-id}/getUsageRights()")]
    [InlineData("GET", "/planner/rosters/{plannerRoster-id}/plans")]
    [InlineData("GET", "/planner/rosters/{plannerRoster-id}/plans/{plannerPlan-id}")]
    public void ParentCallsAndBetaRosterNeighborsAreNotDescendantSubjectMatches(string method, string path)
    {
        Assert.False(CmdletConfigurator.IsSuppressed(new HttpMethod(method), path, new("Test.Client", "unused", "beta")));
    }

    [Theory]
    [InlineData("/users/{user-id}/planner/plans/$count")]
    [InlineData("/users/{user-id}/planner/tasks/$count")]
    public void CountSubjectsMatchTheDescendantDirectiveEvenWithoutALegacyOperationType(string path)
    {
        foreach (var profile in new[] { "v1.0", "beta" })
        {
            Assert.True(CmdletConfigurator.IsSuppressed(HttpMethod.Get, path));
            Assert.True(CmdletConfigurator.IsSuppressed(HttpMethod.Get, path, new("Test.Client", "unused", profile)));
        }
    }
}
