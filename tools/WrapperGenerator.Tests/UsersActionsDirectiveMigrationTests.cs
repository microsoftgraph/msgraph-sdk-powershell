using System;
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
        var legacyPath = path[..(path.LastIndexOf('/') + 1)] + "microsoft.graph." + action;
        var legacy = Assert.Single(LoadSpec("openApiDocs", profile).Paths[legacyPath].Operations!);
        Assert.Equal(legacy.Value.OperationId, operation.Value.OperationId);
        AssertAction(operation.Value);
        AssertName(path, verb, noun, new GeneratorConfig("Test.Client", "unused"), profile);
    }

    [Theory]
    [InlineData("v1.0", false)]
    [InlineData("v1.0", true)]
    [InlineData("beta", false)]
    [InlineData("beta", true)]
    public void SharedRenamesAndNeighborsRespectMethodAndRouteBoundaries(string profile, bool derived)
    {
        var config = new GeneratorConfig("Test.Client", "unused", derived);
        AssertName("/users/{user-id}/removeAllDevicesFromManagement", "Remove", "AllUserDeviceFromManagement", config, profile);
        AssertName("/users/{user-id}/changePassword", "Update", "UserPassword", config, profile);
        if (profile == "beta")
        {
            AssertName("/users/{user-id}/invalidateAllRefreshTokens", "Invoke", "InvalidateAllUserRefreshToken", config, profile);
            AssertName("/users/getUserOwnedObjects", "Get", "UserOwnedObjectByType", config, profile);
        }

        foreach (var path in new[]
        {
            "/users/{user-id}/changePassword",
            "/users/{user-id}/removeAllDevicesFromManagement",
            "/users/{user-id}/invalidateAllRefreshTokens",
            "/users/getUserOwnedObjects",
        })
        {
            Assert.Null(CmdletConfigurator.TryGetOverriddenVerb(HttpMethod.Get, path, config, apiVersion: profile));
            Assert.Equal("Unchanged", CmdletConfigurator.ApplyNounOverrides(HttpMethod.Get, path, "Unchanged", config, apiVersion: profile));
            Assert.Equal("Unchanged", CmdletConfigurator.ApplyNounOverrides(HttpMethod.Post, path + "/neighbor", "Unchanged", config, apiVersion: profile));
            Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Post, path, config, apiVersion: profile));
        }

        Assert.Equal("Unchanged", CmdletConfigurator.ApplyNounOverrides(
            HttpMethod.Post, "/groups/{group-id}/changePassword", "Unchanged", config, apiVersion: profile));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Post, "/users/{user-id}/sendMail", config, apiVersion: profile));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Post, "/users/{user-id}/revokeSignInSessions", config, apiVersion: profile));
    }

    [Theory]
    [InlineData("v1.0", 20, 20)]
    [InlineData("beta", 30, 33)]
    public void OriginalSuppressionSelectorIsEvaluatedAgainstCompleteActualLegacySource(string profile, int legacyCount, int compatibleCount)
    {
        var source = File.ReadAllText(Path.Combine(RepoRoot(), "src", "Users.Actions", "Users.Actions.md"));
        var selector = new Regex(Regex.Match(source, @"remove-path-by-operation: (.+)").Groups[1].Value.Trim());
        var legacy = LoadSpec("openApiDocs", profile);
        var compatible = LoadSpec("openApiDocs_KiotaCompat", profile);
        Assert.Equal(legacyCount, legacy.Paths.Sum(p => p.Value.Operations!.Count));
        Assert.Equal(compatibleCount, compatible.Paths.Sum(p => p.Value.Operations!.Count));
        foreach (var item in compatible.Paths.Values)
        {
            var operation = Assert.Single(item.Operations!);
            AssertAction(operation.Value);
            Assert.DoesNotMatch(selector, operation.Value.OperationId!);
        }
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
            Assert.Equal(old.Value.OperationId, current.Value.OperationId);
        }
    }

    [Theory]
    [InlineData("v1.0", 20, 20)]
    [InlineData("beta", 30, 33)]
    public void ReviewedAuditAccountsForEveryActualOldAndNewOperation(string profile, int legacyCount, int compatibleCount)
    {
        using var ledger = JsonDocument.Parse(File.ReadAllText(Path.Combine(
            RepoRoot(), "src", "Users.Actions", "wrapper", "Users.Actions_directiveMigrationMap.json")));
        var audit = Assert.Single(ledger.RootElement.GetProperty("operationAudit").EnumerateArray(),
            p => p.GetProperty("profile").GetString() == profile);
        Assert.Equal(legacyCount, audit.GetProperty("legacyOperationCount").GetInt32());
        Assert.Equal(compatibleCount, audit.GetProperty("compatibleOperationCount").GetInt32());
        Assert.Equal(0, audit.GetProperty("originalRegexLegacyMatches").GetInt32());
        Assert.Equal(0, audit.GetProperty("originalRegexCompatibleMatches").GetInt32());
        Assert.Equal(0, audit.GetProperty("exactPathOverlap").GetInt32());
        Assert.Equal(legacyCount, audit.GetProperty("kindGuardedUniqueFinalSegmentBridges").GetInt32());
        Assert.Empty(audit.GetProperty("removedOperations").EnumerateArray());
        var evidence = audit.GetProperty("operations").EnumerateArray().ToArray();
        Assert.Equal(legacyCount, evidence.Length);
        Assert.Equal(legacyCount, evidence.Select(e => e.GetProperty("oldPath").GetString()).Distinct().Count());
        Assert.Equal(legacyCount, evidence.Select(e => e.GetProperty("newPath").GetString()).Distinct().Count());
        var additions = audit.GetProperty("compatibleOnlyOperations").EnumerateArray().ToArray();
        Assert.Equal(compatibleCount - legacyCount, additions.Length);
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
        foreach (var addition in additions)
        {
            Assert.Equal("POST", addition.GetProperty("method").GetString());
            Assert.Equal("action", addition.GetProperty("metadataKind").GetString());
            var current = Assert.Single(compatible.Paths[addition.GetProperty("path").GetString()!].Operations!);
            Assert.Equal(addition.GetProperty("operationId").GetString(), current.Value.OperationId);
            AssertAction(current.Value);
        }
        Assert.Equal(compatible.Paths.Keys.OrderBy(p => p, StringComparer.Ordinal),
            evidence.Select(e => e.GetProperty("newPath").GetString()!)
                .Concat(additions.Select(e => e.GetProperty("path").GetString()!)).OrderBy(p => p, StringComparer.Ordinal));
    }

    [Theory]
    [InlineData("v1.0", true, "sendMail", "Send", "UserMail")]
    [InlineData("v1.0", true, "revokeSignInSessions", "Revoke", "UserSignInSession")]
    [InlineData("v1.0", false, "sendMail", "Invoke", "UserSendMail")]
    [InlineData("v1.0", false, "revokeSignInSessions", "Invoke", "UserRevokeSignInSessions")]
    [InlineData("beta", true, "sendMail", "Invoke", "UserSendMail")]
    [InlineData("beta", true, "revokeSignInSessions", "Invoke", "UserRevokeSignInSessions")]
    [InlineData("beta", false, "sendMail", "Invoke", "UserSendMail")]
    [InlineData("beta", false, "revokeSignInSessions", "Invoke", "UserRevokeSignInSessions")]
    public void ActualNeighborActionsKeepExistingProfileBehavior(string profile, bool derived, string action, string verb, string noun)
    {
        var path = $"/users/{{user-id}}/{action}";
        var operation = Assert.Single(LoadSpec("openApiDocs_KiotaCompat", profile).Paths[path].Operations!);
        Assert.Equal(HttpMethod.Post, operation.Key);
        AssertAction(operation.Value);
        var config = new GeneratorConfig("Test.Client", "unused", derived);
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Post, path, config, apiVersion: profile));
        AssertName(path, verb, noun, config, profile);
    }

    [Theory]
    [InlineData("v1.0", true, 17)]
    [InlineData("v1.0", false, 20)]
    [InlineData("beta", true, 33)]
    [InlineData("beta", false, 33)]
    public async Task CurrentServiceUsesSeparateProfileAndPreservesSharedActions(string profile, bool derived, int count)
    {
        var output = Path.Combine(Path.GetTempPath(), "users-actions-directive-tests", Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(output);
        try
        {
            var config = new GeneratorConfig("Test.Client", output, derived);
            await new PowerShellWrapperGenerationService(LoadSpec("openApiDocs_KiotaCompat", profile),
                config, NullLogger.Instance, apiVersion: profile).GenerateAsync(CancellationToken.None);
            Assert.Equal(count, Directory.GetFiles(output, "*.g.cs").Length);
            foreach (var (stem, path) in new[]
            {
                ("RemoveMgAllUserDeviceFromManagement", "/users/{user-id}/removeAllDevicesFromManagement"),
                ("UpdateMgUserPassword", "/users/{user-id}/changePassword"),
            })
            {
                var source = File.ReadAllText(Path.Combine(output, stem + ".g.cs"));
                Assert.Contains($"[GraphRoute(\"POST\", \"{path}\")]", source, StringComparison.Ordinal);
                Assert.Contains("SupportsShouldProcess = true", source, StringComparison.Ordinal);
                Assert.Contains("ShouldProcess(", source, StringComparison.Ordinal);
                Assert.Contains(".PostAsync(", source, StringComparison.Ordinal);
            }
            if (profile == "beta")
            {
                Assert.True(File.Exists(Path.Combine(output, "GetMgUserOwnedObjectByType.g.cs")));
                Assert.True(File.Exists(Path.Combine(output, "InvokeMgInvalidateAllUserRefreshToken.g.cs")));
                foreach (var action in new[] { "AddSelfAsSponsor", "Attest", "RemoveSelfAsSponsor" })
                {
                    var source = File.ReadAllText(Path.Combine(output, "InvokeMgUser" + action + ".g.cs"));
                    Assert.Contains("microsoft.graph.identityGovernance.", source, StringComparison.Ordinal);
                    Assert.Contains("SupportsShouldProcess = true", source, StringComparison.Ordinal);
                }
            }
            var expectedNeighbor = profile == "v1.0" && derived ? "SendMgUserMail" : "InvokeMgUserSendMail";
            Assert.True(File.Exists(Path.Combine(output, expectedNeighbor + ".g.cs")));
        }
        finally
        {
            Directory.Delete(output, recursive: true);
        }
    }

    private static void AssertAction(OpenApiOperation operation) =>
        Assert.Equal("action", Assert.IsType<JsonNodeExtension>(
            operation.Extensions!["x-ms-docs-operation-type"]).Node?.ToString()?.Trim('"'));

    private static void AssertName(string path, string verb, string noun, GeneratorConfig config, string profile)
    {
        var name = Naming.Resolve(new OperationInfo(HttpMethod.Post, path, Kind: OperationKind.Action), config, apiVersion: profile);
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
