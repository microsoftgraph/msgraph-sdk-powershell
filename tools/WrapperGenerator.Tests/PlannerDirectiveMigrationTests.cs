using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging.Abstractions;
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
    [InlineData("v1.0", 137, 137, 0)]
    [InlineData("beta", 206, 182, 24)]
    public void OriginalLegacySelectorIsCompletelyAccountedFor(
        string profile, int expectedCount, int expectedLiteralCount, int expectedTranslations)
    {
        var source = File.ReadAllText(Path.Combine(RepoRoot, "src", "Planner", "Planner.md"));
        var selector = Regex.Match(source, @"remove-path-by-operation: ([^\r\n]+)").Groups[1].Value;
        var legacy = ReadSpec("openApiDocs", profile);
        var compatible = ReadSpec("openApiDocs_KiotaCompat", profile);
        var matches = legacy.Paths.SelectMany(path => path.Value.Operations!
            .Where(operation => Regex.IsMatch(operation.Value.OperationId!, selector))
            .Select(operation => Key(operation.Key.Method, path.Key) + " " + operation.Value.OperationId))
            .ToHashSet(StringComparer.Ordinal);
        Assert.Equal(expectedCount, matches.Count);

        using var ledger = JsonDocument.Parse(File.ReadAllText(Path.Combine(RepoRoot, "src", "Planner", "wrapper", "Planner_directiveMigrationMap.json")));
        var evidence = ledger.RootElement.GetProperty("mappings")[0].GetProperty("profiles").GetProperty(profile);
        var operations = evidence.GetProperty("operations").EnumerateArray().ToArray();
        Assert.Equal(expectedCount, operations.Length);
        Assert.Equal(expectedTranslations, operations.Count(operation => operation.TryGetProperty("legacyPathTranslation", out _)));
        var literalMatches = compatible.Paths.SelectMany(path => path.Value.Operations!
            .Where(operation => Regex.IsMatch(operation.Value.OperationId!, selector))
            .Select(operation => Key(operation.Key.Method, path.Key) + " " + operation.Value.OperationId))
            .ToHashSet(StringComparer.Ordinal);
        Assert.Equal(expectedLiteralCount, literalMatches.Count);
        if (expectedTranslations == 0)
        {
            Assert.False(evidence.TryGetProperty("operationIdSource", out _));
            Assert.False(evidence.TryGetProperty("removedLegacyOperations", out _));
            foreach (var operation in operations)
            {
                Assert.False(operation.TryGetProperty("legacyPath", out _));
                Assert.False(operation.TryGetProperty("legacyOperationId", out _));
            }
            Assert.True(matches.SetEquals(literalMatches));
            Assert.True(literalMatches.SetEquals(operations.Select(operation =>
                Key(operation.GetProperty("method").GetString()!, operation.GetProperty("path").GetString()!) +
                " " + operation.GetProperty("operationId").GetString())));
            return;
        }

        Assert.Equal("Legacy", evidence.GetProperty("operationIdSource").GetString());
        Assert.Empty(evidence.GetProperty("removedLegacyOperations").EnumerateArray());
        Assert.True(matches.SetEquals(operations.Select(operation =>
            Key(operation.GetProperty("method").GetString()!, operation.GetProperty("legacyPath").GetString()!) +
            " " + operation.GetProperty("legacyOperationId").GetString())));
        foreach (var operation in operations)
        {
            var method = new HttpMethod(operation.GetProperty("method").GetString()!);
            var oldPath = operation.GetProperty("legacyPath").GetString()!;
            var newPath = operation.GetProperty("path").GetString()!;
            var oldOperation = legacy.Paths[oldPath].Operations![method];
            var currentOperation = compatible.Paths[newPath].Operations![method];
            Assert.Equal(operation.GetProperty("legacyOperationId").GetString(), oldOperation.OperationId);
            Assert.Equal(operation.GetProperty("operationId").GetString(), currentOperation.OperationId);
            if (!operation.TryGetProperty("legacyPathTranslation", out var translation))
            {
                Assert.Equal(oldPath, newPath);
                continue;
            }
            Assert.Equal("UnqualifyFinalOperation", translation.GetString());
            var kind = KindOf(oldOperation, method);
            Assert.NotEqual(OperationKind.Resource, kind);
            Assert.Equal(kind, KindOf(currentOperation, method));
            Assert.Equal(CmdletConfigurator.NormalizePathTemplate(oldPath[..oldPath.LastIndexOf('/')]),
                CmdletConfigurator.NormalizePathTemplate(newPath[..newPath.LastIndexOf('/')]));
            Assert.Equal("microsoft.graph." + newPath[(newPath.LastIndexOf('/') + 1)..].Replace("()", "", StringComparison.Ordinal),
                oldPath[(oldPath.LastIndexOf('/') + 1)..].Replace("()", "", StringComparison.Ordinal));
        }
        Assert.Equal(14, operations.Count(operation => operation.TryGetProperty("legacyPathTranslation", out _) &&
            operation.GetProperty("method").GetString() == "POST"));
        Assert.Equal(10, operations.Count(operation => operation.TryGetProperty("legacyPathTranslation", out _) &&
            operation.GetProperty("method").GetString() == "GET"));
    }

    [Theory]
    [InlineData("v1.0", false)]
    [InlineData("v1.0", true)]
    [InlineData("beta", false)]
    [InlineData("beta", true)]
    public void ExactSharedSuppressionsCoverTheLedgerWithoutSuppressingOtherSpecOperations(string profile, bool useCollisionData)
    {
        using var ledger = JsonDocument.Parse(File.ReadAllText(Path.Combine(RepoRoot, "src", "Planner", "wrapper", "Planner_directiveMigrationMap.json")));
        var expected = new HashSet<string>(StringComparer.Ordinal);
        var compatible = ReadSpec("openApiDocs_KiotaCompat", profile);
        var config = new GeneratorConfig("Test.Client", "unused", useCollisionData);
        foreach (var mapping in ledger.RootElement.GetProperty("mappings").EnumerateArray())
        {
            foreach (var operation in mapping.GetProperty("profiles").GetProperty(profile).GetProperty("operations").EnumerateArray())
            {
                var method = operation.GetProperty("method").GetString()!;
                var path = operation.GetProperty("path").GetString()!;
                var actual = compatible.Paths[path].Operations![new HttpMethod(method)];
                Assert.Equal(operation.GetProperty("operationId").GetString(), actual.OperationId);
                expected.Add(Key(method, path));
                Assert.True(CmdletConfigurator.IsSuppressed(new HttpMethod(method), path, config, apiVersion: profile), method + " " + path);
            }
        }
        Assert.NotEmpty(expected);
        foreach (var path in compatible.Paths)
        {
            foreach (var operation in path.Value.Operations!)
                Assert.Equal(expected.Contains(Key(operation.Key.Method, path.Key)),
                    CmdletConfigurator.IsSuppressed(operation.Key, path.Key, config, apiVersion: profile));
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
        {
            foreach (var useCollisionData in new[] { false, true })
                Assert.False(CmdletConfigurator.IsSuppressed(new HttpMethod(method), path,
                    new("Test.Client", "unused", useCollisionData), apiVersion: profile));
        }
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
        foreach (var useCollisionData in new[] { false, true })
            Assert.False(CmdletConfigurator.IsSuppressed(new HttpMethod(method), path,
                new("Test.Client", "unused", useCollisionData), apiVersion: "beta"));
    }

    [Theory]
    [InlineData("/users/{user-id}/planner/plans/$count")]
    [InlineData("/users/{user-id}/planner/tasks/$count")]
    public void CountSubjectsMatchTheDescendantDirectiveEvenWithoutALegacyOperationType(string path)
    {
        foreach (var profile in new[] { "v1.0", "beta" })
        {
            foreach (var useCollisionData in new[] { false, true })
                Assert.True(CmdletConfigurator.IsSuppressed(HttpMethod.Get, path,
                    new("Test.Client", "unused", useCollisionData), apiVersion: profile));
        }
    }

    [Theory]
    [InlineData("v1.0", false)]
    [InlineData("v1.0", true)]
    [InlineData("beta", false)]
    [InlineData("beta", true)]
    public void SharedNamingAndRuntimeProfileKeepPublishedNeighbors(string profile, bool useCollisionData)
    {
        var config = new GeneratorConfig("Test.Client", "unused", useCollisionData);
        var naming = Naming.Resolve(new OperationInfo(HttpMethod.Get, "/groups/{group-id}/planner/plans/{plannerPlan-id}/buckets"),
            config, apiVersion: profile);
        Assert.Equal("Get", naming.VerbName);
        Assert.Equal("MgGroupPlannerPlanBucket", naming.Noun);
        Assert.Equal("MgGroupPlannerPlanBucket",
            CmdletConfigurator.ApplyNounOverrides(HttpMethod.Get, "/groups/{group-id}/planner/plans/{plannerPlan-id}/buckets",
                naming.Noun, config, apiVersion: profile));
        Assert.Null(CmdletConfigurator.TryGetOverriddenVerb(HttpMethod.Get,
            "/groups/{group-id}/planner/plans/{plannerPlan-id}/buckets", config, apiVersion: profile));
    }

    [Theory]
    [InlineData("v1.0", false)]
    [InlineData("v1.0", true)]
    [InlineData("beta", false)]
    [InlineData("beta", true)]
    public async Task CurrentServiceUsesSeparateProfileAndSharedRulesForTheActualModuleSpec(string profile, bool useCollisionData)
    {
        var output = Path.Combine(Path.GetTempPath(), "planner-directive-tests-" + Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(output);
        try
        {
            var config = new GeneratorConfig("Test.Client", output, useCollisionData);
            var service = new PowerShellWrapperGenerationService(ReadSpec("openApiDocs_KiotaCompat", profile),
                config, NullLogger.Instance, apiVersion: profile);
            await service.GenerateAsync(CancellationToken.None);
            var files = Directory.GetFiles(output, "*.g.cs");
            Assert.NotEmpty(files);
            var source = string.Join("\n", files.Select(File.ReadAllText));
            Assert.Contains("[GraphRoute(\"GET\", \"/users/{user-id}/planner/plans\")]", source);
            Assert.Contains("[GraphRoute(\"GET\", \"/groups/{group-id}/planner/plans/{plannerPlan-id}/buckets\")]", source);
            Assert.DoesNotContain("[GraphRoute(\"GET\", \"/users/{user-id}/planner/plans/$count\")]", source);
            Assert.DoesNotContain("[GraphRoute(\"GET\", \"/users/{user-id}/planner/tasks/$count\")]", source);
            if (profile == "beta")
            {
                Assert.Contains("[GraphRoute(\"GET\", \"/users/{user-id}/planner/plans/delta()\")]", source);
                Assert.Contains("[GraphRoute(\"POST\", \"/users/{user-id}/planner/plans/{plannerPlan-id}/archive\")]", source);
                Assert.DoesNotContain("[GraphRoute(\"GET\", \"/users/{user-id}/planner/plans/{plannerPlan-id}/tasks/delta()\")]", source);
            }
        }
        finally
        {
            Directory.Delete(output, recursive: true);
        }
    }

    private static OperationKind KindOf(OpenApiOperation operation, HttpMethod method)
    {
        var kind = operation.Extensions?.TryGetValue("x-ms-docs-operation-type", out var value) == true &&
            value is JsonNodeExtension node ? node.Node?.ToString() : null;
        return kind switch
        {
            "action" when method == HttpMethod.Post => OperationKind.Action,
            "function" when method == HttpMethod.Get => OperationKind.Function,
            _ => OperationKind.Resource,
        };
    }
}
