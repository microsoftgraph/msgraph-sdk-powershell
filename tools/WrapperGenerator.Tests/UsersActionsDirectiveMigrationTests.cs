using System;
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

public sealed class UsersActionsDirectiveMigrationTests
{
    [Theory]
    [InlineData("v1.0", "removeAllDevicesFromManagement", "Remove", "AllUserDeviceFromManagement")]
    [InlineData("beta", "removeAllDevicesFromManagement", "Remove", "AllUserDeviceFromManagement")]
    [InlineData("beta", "invalidateAllRefreshTokens", "Invoke", "InvalidateAllUserRefreshToken")]
    [InlineData("beta", "getUserOwnedObjects", "Get", "UserOwnedObjectByType")]
    [InlineData("v1.0", "changePassword", "Update", "UserPassword")]
    [InlineData("beta", "changePassword", "Update", "UserPassword")]
    public void SharedRenamesUseActualCompatibleActions(string profile, string action, string verb, string noun)
    {
        var document = LoadSpec("openApiDocs_KiotaCompat", profile);
        var path = action == "getUserOwnedObjects" ? $"/users/{action}" : $"/users/{{user-id}}/{action}";
        var operation = Assert.Single(document.Paths[path].Operations!);
        Assert.Equal(HttpMethod.Post, operation.Key);
        Assert.EndsWith("." + action, operation.Value.OperationId, StringComparison.Ordinal);
        AssertAction(operation.Value);
        AssertName(path, verb, noun, new GeneratorConfig("Test.Client", "unused", profile));
    }

    [Theory]
    [InlineData("v1.0", false)]
    [InlineData("v1.0", true)]
    [InlineData("beta", false)]
    [InlineData("beta", true)]
    public void SharedRenamesAndNeighborsRespectMethodAndRouteBoundaries(string profile, bool derived)
    {
        var config = new GeneratorConfig("Test.Client", "unused", profile, derived);
        AssertName("/users/{user-id}/removeAllDevicesFromManagement", "Remove", "AllUserDeviceFromManagement", config);
        AssertName("/users/{user-id}/changePassword", "Update", "UserPassword", config);
        if (profile == "beta")
        {
            AssertName("/users/{user-id}/invalidateAllRefreshTokens", "Invoke", "InvalidateAllUserRefreshToken", config);
            AssertName("/users/getUserOwnedObjects", "Get", "UserOwnedObjectByType", config);
        }

        foreach (var path in new[]
        {
            "/users/{user-id}/changePassword",
            "/users/{user-id}/removeAllDevicesFromManagement",
            "/users/{user-id}/invalidateAllRefreshTokens",
            "/users/getUserOwnedObjects",
        })
        {
            Assert.Null(CmdletConfigurator.TryGetOverriddenVerb(HttpMethod.Get, path, config));
            Assert.Equal("Unchanged", CmdletConfigurator.ApplyNounOverrides(HttpMethod.Get, path, "Unchanged", config));
            Assert.Equal("Unchanged", CmdletConfigurator.ApplyNounOverrides(HttpMethod.Post, path + "/neighbor", "Unchanged", config));
            Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Post, path, config));
        }

        Assert.Equal("Unchanged", CmdletConfigurator.ApplyNounOverrides(
            HttpMethod.Post, "/groups/{group-id}/changePassword", "Unchanged", config));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Post, "/users/{user-id}/sendMail", config));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Post, "/users/{user-id}/revokeSignInSessions", config));
    }

    [Theory]
    [InlineData("v1.0", 20)]
    [InlineData("beta", 30)]
    public void OriginalSuppressionSelectorIsEvaluatedAgainstCompleteActualLegacySource(string profile, int count)
    {
        var source = File.ReadAllText(Path.Combine(RepoRoot(), "src", "Users.Actions", "Users.Actions.md"));
        var selector = new Regex(Regex.Match(source, @"remove-path-by-operation: (.+)").Groups[1].Value.Trim());
        var legacy = LoadSpec("openApiDocs", profile);
        var compatible = LoadSpec("openApiDocs_KiotaCompat", profile);
        Assert.Equal(count, legacy.Paths.Sum(p => p.Value.Operations!.Count));
        Assert.Equal(count, compatible.Paths.Sum(p => p.Value.Operations!.Count));
        foreach (var (path, item) in legacy.Paths)
        {
            var old = Assert.Single(item.Operations!);
            Assert.DoesNotMatch(selector, old.Value.OperationId!);
            Assert.False(compatible.Paths.ContainsKey(path));
            Assert.Equal(HttpMethod.Post, old.Key);
            Assert.Contains("/microsoft.graph.", path, StringComparison.Ordinal);
            var terminal = path[(path.LastIndexOf('/') + 1)..];
            Assert.StartsWith("microsoft.graph.", terminal, StringComparison.Ordinal);
            var successorPath = path[..(path.LastIndexOf('/') + 1)] + terminal["microsoft.graph.".Length..];
            var current = Assert.Single(compatible.Paths[successorPath].Operations!);
            Assert.Equal(old.Key, current.Key);
            AssertAction(old.Value);
            AssertAction(current.Value);
            Assert.DoesNotMatch(selector, current.Value.OperationId!);
            Assert.NotEqual(old.Value.OperationId, current.Value.OperationId);
        }
    }

    [Theory]
    [InlineData("v1.0", 20)]
    [InlineData("beta", 30)]
    public void ReviewedAuditAccountsForEveryActualOldAndNewOperation(string profile, int count)
    {
        using var ledger = JsonDocument.Parse(File.ReadAllText(Path.Combine(
            RepoRoot(), "src", "Users.Actions", "wrapper", "Users.Actions_directiveMigrationMap.json")));
        var audit = Assert.Single(ledger.RootElement.GetProperty("operationAudit").EnumerateArray(),
            p => p.GetProperty("profile").GetString() == profile);
        Assert.Equal(count, audit.GetProperty("legacyOperationCount").GetInt32());
        Assert.Equal(count, audit.GetProperty("compatibleOperationCount").GetInt32());
        Assert.Equal(0, audit.GetProperty("originalRegexLegacyMatches").GetInt32());
        Assert.Equal(0, audit.GetProperty("originalRegexCompatibleMatches").GetInt32());
        Assert.Equal(0, audit.GetProperty("exactPathOverlap").GetInt32());
        Assert.Equal(count, audit.GetProperty("kindGuardedUniqueFinalSegmentBridges").GetInt32());
        Assert.Empty(audit.GetProperty("removedOperations").EnumerateArray());
        var evidence = audit.GetProperty("operations").EnumerateArray().ToArray();
        Assert.Equal(count, evidence.Length);
        Assert.Equal(count, evidence.Select(e => e.GetProperty("oldPath").GetString()).Distinct().Count());
        Assert.Equal(count, evidence.Select(e => e.GetProperty("newPath").GetString()).Distinct().Count());
        var legacy = LoadSpec("openApiDocs", profile);
        var compatible = LoadSpec("openApiDocs_KiotaCompat", profile);
        foreach (var pair in evidence)
        {
            Assert.Equal("POST", pair.GetProperty("method").GetString());
            Assert.Equal("action", pair.GetProperty("oldMetadataKind").GetString());
            Assert.Equal("action", pair.GetProperty("newMetadataKind").GetString());
            Assert.False(pair.GetProperty("selectedByOriginalSuppressionRegex").GetBoolean());
            var old = Assert.Single(legacy.Paths[pair.GetProperty("oldPath").GetString()!].Operations!);
            var current = Assert.Single(compatible.Paths[pair.GetProperty("newPath").GetString()!].Operations!);
            Assert.Equal(pair.GetProperty("oldOperationId").GetString(), old.Value.OperationId);
            Assert.Equal(pair.GetProperty("newOperationId").GetString(), current.Value.OperationId);
        }
    }

    [Theory]
    [InlineData("v1.0", "sendMail", "Send", "UserMail")]
    [InlineData("v1.0", "revokeSignInSessions", "Revoke", "UserSignInSession")]
    [InlineData("beta", "sendMail", "Invoke", "UserSendMail")]
    [InlineData("beta", "revokeSignInSessions", "Invoke", "UserRevokeSignInSessions")]
    public void ActualNeighborActionsKeepExistingProfileBehavior(string profile, string action, string verb, string noun)
    {
        var path = $"/users/{{user-id}}/{action}";
        var operation = Assert.Single(LoadSpec("openApiDocs_KiotaCompat", profile).Paths[path].Operations!);
        Assert.Equal(HttpMethod.Post, operation.Key);
        AssertAction(operation.Value);
        var config = new GeneratorConfig("Test.Client", "unused", profile);
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Post, path, config));
        AssertName(path, verb, noun, config);
    }

    private static void AssertAction(OpenApiOperation operation) =>
        Assert.Equal("action", Assert.IsType<JsonNodeExtension>(
            operation.Extensions!["x-ms-docs-operation-type"]).Node?.ToString()?.Trim('"'));

    private static void AssertName(string path, string verb, string noun, GeneratorConfig config)
    {
        var name = Naming.Resolve(new OperationInfo(HttpMethod.Post, path, Kind: OperationKind.Action), config);
        Assert.Equal(verb, name.VerbName);
        Assert.Equal("Mg" + noun, name.Noun);
        Assert.Equal(path, name.SourcePath);
        Assert.Equal("POST", name.SourceMethod);
    }

    private static OpenApiDocument LoadSpec(string root, string profile)
    {
        var settings = new OpenApiReaderSettings();
        settings.AddYamlReader();
        using var stream = File.OpenRead(Path.Combine(RepoRoot(), root, profile, "Users.Actions.yml"));
        return OpenApiDocument.LoadAsync(stream, settings: settings, cancellationToken: CancellationToken.None)
            .GetAwaiter().GetResult().Document!;
    }

    private static string RepoRoot()
    {
        var directory = new DirectoryInfo(AppContext.BaseDirectory);
        while (directory is not null && !Directory.Exists(Path.Combine(directory.FullName, "openApiDocs_KiotaCompat")))
            directory = directory.Parent;
        return directory?.FullName ?? throw new DirectoryNotFoundException("Repository root not found.");
    }
}
