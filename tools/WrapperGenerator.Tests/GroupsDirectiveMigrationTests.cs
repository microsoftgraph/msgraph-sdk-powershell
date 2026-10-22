using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Text.RegularExpressions;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Reader;
using WrapperGenerator;
using Xunit;

namespace WrapperGenerator.Tests;

public sealed class GroupsDirectiveMigrationTests
{
    private static readonly string RepoRoot = FindRepoRoot();
    private static readonly Lazy<OpenApiDocument> V1Spec = new(() => ReadSpec("v1.0"));
    private static readonly Lazy<OpenApiDocument> BetaSpec = new(() => ReadSpec("beta"));

    [Theory]
    [InlineData("v1.0")]
    [InlineData("beta")]
    public void AllSeventeenReviewedGroupsHaveExactSpecEvidence(string profile)
    {
        using var ledger = ReadLedger();
        var mappings = ledger.RootElement.GetProperty("mappings").EnumerateArray().ToArray();
        Assert.Equal(Enumerable.Range(1, 17), mappings.Select(m => m.GetProperty("directiveIndex").GetInt32()));
        var document = Spec(profile);
        foreach (var mapping in mappings)
        {
            var evidence = mapping.GetProperty("profiles").GetProperty(profile);
            var operations = evidence.GetProperty("operations").EnumerateArray().ToArray();
            Assert.Equal(operations.Length == 0, evidence.GetProperty("absenceExpected").GetBoolean());
            if (evidence.TryGetProperty("absencePathPattern", out var absencePattern))
                Assert.DoesNotContain(document.Paths.Keys, path => Regex.IsMatch(path, absencePattern.GetString()!));
            foreach (var operation in operations)
            {
                var path = operation.GetProperty("path").GetString()!;
                var method = new HttpMethod(operation.GetProperty("method").GetString()!);
                Assert.Equal(operation.GetProperty("operationId").GetString(), SpecOperation(profile, method, path).OperationId);
            }
        }

        var source = File.ReadAllText(Path.Combine(RepoRoot, "src", "Groups", "Groups.md"));
        var pattern = Regex.Match(source, @"(?m)^\s+- remove-path-by-operation:\s*(.+)$").Groups[1].Value.Trim();
        var candidates = document.Paths.SelectMany(path => path.Value.Operations!
            .Where(operation => Regex.IsMatch(operation.Value.OperationId!, pattern))
            .Select(operation => $"{operation.Key.Method} {path.Key}")).OrderBy(key => key);
        var reviewed = mappings[0].GetProperty("profiles").GetProperty(profile).GetProperty("operations")
            .EnumerateArray().Select(operation => $"{operation.GetProperty("method").GetString()} {operation.GetProperty("path").GetString()}")
            .OrderBy(key => key);
        Assert.Equal(candidates, reviewed);
    }

    [Theory]
    [InlineData("v1.0", false)]
    [InlineData("v1.0", true)]
    [InlineData("beta", false)]
    [InlineData("beta", true)]
    public void ReviewedOperationsHaveTheirMigratedSurface(string profile, bool useCollisionData)
    {
        var config = new GeneratorConfig("Test.Client", "unused", profile, useCollisionData);
        using var ledger = ReadLedger();
        foreach (var mapping in ledger.RootElement.GetProperty("mappings").EnumerateArray())
        {
            var index = mapping.GetProperty("directiveIndex").GetInt32();
            foreach (var operation in mapping.GetProperty("profiles").GetProperty(profile).GetProperty("operations").EnumerateArray())
            {
                var method = new HttpMethod(operation.GetProperty("method").GetString()!);
                var path = operation.GetProperty("path").GetString()!;
                var suppressed = index is 1 or 4 or 8 or 17;
                Assert.Equal(suppressed, CmdletConfigurator.IsSuppressed(method, path, config));
                if (suppressed)
                    continue;
                var (verb, noun) = index switch
                {
                    2 => ("Get", "GroupLifecyclePolicyByGroup"),
                    3 => (method.Method switch
                    {
                        "GET" => "Get",
                        "POST" => "New",
                        "PATCH" => "Update",
                        "DELETE" => "Remove",
                        _ => throw new InvalidOperationException($"Unexpected policy method {method}."),
                    }, "GroupLifecyclePolicy"),
                    5 => ("Test", "GroupDynamicMembershipRule"),
                    6 => ("Remove", "GroupFromLifecyclePolicy"),
                    7 => ("Add", "GroupToLifecyclePolicy"),
                    9 => ("Invoke", "RenewGroupLifecyclePolicy"),
                    _ => throw new InvalidOperationException($"Unexpected applicable directive {index}."),
                };
                var kind = index is 5 or 6 or 7 or 9 ? OperationKind.Action : OperationKind.Resource;
                var name = Naming.Resolve(new OperationInfo(method, path, Kind: kind), config);
                Assert.Equal(verb, name.VerbName);
                Assert.Equal(PsVerb.FromApprovedName(verb).AttributeClass, name.VerbsClass);
                Assert.Equal("Mg" + noun, name.Noun);
                Assert.Equal($"{verb}Mg{noun}Command", name.ClassName);
            }
        }
    }

    [Theory]
    [InlineData("v1.0", false)]
    [InlineData("v1.0", true)]
    [InlineData("beta", false)]
    [InlineData("beta", true)]
    public void NeighboringRoutesKeepTheirExistingBehavior(string profile, bool useCollisionData)
    {
        var config = new GeneratorConfig("Test.Client", "unused", profile, useCollisionData);
        AssertRoute(profile, config, HttpMethod.Get, "/groupLifecyclePolicies/$count", "Get", "MgGroupLifecyclePolicyCount");
        AssertRoute(profile, config, HttpMethod.Get, "/groups/{group-id}/photo", "Get", "MgGroupPhoto");
        AssertRoute(profile, config, HttpMethod.Put, "/groups/{group-id}/photo/$value", "Set", "MgGroupPhotoContent");
        AssertRoute(profile, config, HttpMethod.Get, "/groups/{group-id}", "Get", "MgGroup");

        var boundValidation = "/groups/{group-id}/validateProperties";
        AssertRoute(profile, config, HttpMethod.Post, boundValidation,
            profile == "v1.0" && useCollisionData ? "Test" : "Invoke",
            profile == "v1.0" && useCollisionData ? "MgGroupProperty" : "MgGroupValidateProperties",
            OperationKind.Action);
        AssertRoute(profile, config, HttpMethod.Post, "/groups/{group-id}/renew", "Invoke",
            profile == "v1.0" && useCollisionData ? "MgRenewGroup" : "MgGroupRenew", OperationKind.Action);
        if (profile == "beta")
        {
            AssertRoute(profile, config, HttpMethod.Get, "/users/{user-id}/joinedGroups", "Get", "MgUserJoinedGroup");
            AssertRoute(profile, config, HttpMethod.Post, "/groups/{group-id}/evaluateDynamicMembership",
                "Invoke", "MgGroupEvaluateDynamicMembership", OperationKind.Action);
        }

        foreach (var path in new[]
        {
            "/groups/{group-id}/groupLifecyclePolicies/{groupLifecyclePolicy-id}/addGroup",
            "/groups/{group-id}/groupLifecyclePolicies/{groupLifecyclePolicy-id}/removeGroup",
        })
        {
            Assert.NotNull(SpecOperation(profile, HttpMethod.Post, path));
            Assert.True(CmdletConfigurator.IsSuppressed(HttpMethod.Post, path, config));
        }
        Assert.True(CmdletConfigurator.IsSuppressed(HttpMethod.Get, "/groups/{group-id}/photos/{profilePhoto-id}", config));

        var sites = Spec(profile).Paths.Where(path => path.Key.Contains("/sites/", StringComparison.Ordinal)).ToArray();
        Assert.NotEmpty(sites);
        foreach (var path in sites)
        {
            foreach (var operation in path.Value.Operations!)
            {
                Assert.False(CmdletConfigurator.IsSuppressed(operation.Key, path.Key, config));
                var kind = operation.Key == HttpMethod.Post ? OperationKind.Action : OperationKind.Function;
                var name = Naming.Resolve(new OperationInfo(operation.Key, path.Key, Kind: kind), config);
                Assert.False(name.Noun.StartsWith("MgAllGroupSite", StringComparison.Ordinal));
            }
        }
    }

    [Theory]
    [InlineData("GET", "/groups/validateProperties")]
    [InlineData("POST", "/groups/validateProperties/child")]
    [InlineData("PUT", "/groups/{id}/photo")]
    [InlineData("PATCH", "/groups/{id}/photo/$value")]
    [InlineData("POST", "/users/{id}/joinedGroups")]
    [InlineData("GET", "/users/{id}/joinedGroups/delta()/child")]
    public void NewSuppressionsDoNotPruneMethodsOrSubtrees(string method, string path)
    {
        Assert.False(CmdletConfigurator.IsSuppressed(new HttpMethod(method), path));
    }

    [Theory]
    [InlineData("GET", "/groupLifecyclePolicies/{id}/addGroup")]
    [InlineData("POST", "/groupLifecyclePolicies/{id}/addGroup/child")]
    [InlineData("POST", "/groupLifecyclePolicies/{id}/removeGroup/child")]
    [InlineData("POST", "/groups/{id}/evaluateDynamicMembership")]
    [InlineData("POST", "/groups/evaluateDynamicMembership/child")]
    public void NewActionRenamesAreExactMethodAndPathMatches(string method, string path)
    {
        var httpMethod = new HttpMethod(method);
        Assert.Null(CmdletConfigurator.TryGetOverriddenVerb(httpMethod, path, null));
        Assert.Equal("Unchanged", CmdletConfigurator.ApplyNounOverrides(httpMethod, path, "Unchanged"));
    }

    private static void AssertRoute(string profile, GeneratorConfig config, HttpMethod method, string path,
        string verb, string noun, OperationKind kind = OperationKind.Resource)
    {
        Assert.NotNull(SpecOperation(profile, method, path));
        Assert.False(CmdletConfigurator.IsSuppressed(method, path, config));
        var name = Naming.Resolve(new OperationInfo(method, path, Kind: kind), config);
        Assert.Equal(verb, name.VerbName);
        Assert.Equal(noun, name.Noun);
    }

    private static OpenApiOperation SpecOperation(string profile, HttpMethod method, string path)
    {
        var document = Spec(profile);
        Assert.True(document.Paths.TryGetValue(path, out var item), $"Missing {profile} path {path}.");
        Assert.NotNull(item.Operations);
        Assert.True(item.Operations.TryGetValue(method, out var operation), $"Missing {profile} {method} {path}.");
        return operation;
    }

    private static OpenApiDocument Spec(string profile) => profile == "v1.0" ? V1Spec.Value : BetaSpec.Value;

    private static OpenApiDocument ReadSpec(string profile)
    {
        var settings = new OpenApiReaderSettings();
        settings.AddYamlReader();
        using var stream = File.OpenRead(Path.Combine(RepoRoot, "openApiDocs_KiotaCompat", profile, "Groups.yml"));
        var result = OpenApiDocument.LoadAsync(stream, settings: settings).GetAwaiter().GetResult();
        return result.Document ?? throw new InvalidOperationException($"Could not parse compatible {profile} Groups spec.");
    }

    private static JsonDocument ReadLedger() => JsonDocument.Parse(File.ReadAllText(
        Path.Combine(RepoRoot, "src", "Groups", "wrapper", "Groups_directiveMigrationMap.json")));

    private static string FindRepoRoot()
    {
        var directory = new DirectoryInfo(AppContext.BaseDirectory);
        while (directory is not null
            && !File.Exists(Path.Combine(directory.FullName, ".git"))
            && !Directory.Exists(Path.Combine(directory.FullName, ".git")))
            directory = directory.Parent;
        return directory?.FullName ?? throw new InvalidOperationException("Could not locate repository root.");
    }
}
