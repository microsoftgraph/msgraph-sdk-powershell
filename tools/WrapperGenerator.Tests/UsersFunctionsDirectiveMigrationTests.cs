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

public sealed class UsersFunctionsDirectiveMigrationTests
{
    private sealed record Operation(HttpMethod Method, string Path, OpenApiOperation Definition);

    [Theory]
    [InlineData("v1.0", 7)]
    [InlineData("beta", 16)]
    public void OriginalSelectorsHaveNoTargetsInEitherActualConversion(string profile, int count)
    {
        var source = File.ReadAllText(Path.Combine(RepoRoot(), "src", "Users.Functions", "Users.Functions.md"));
        var selector = Regex.Match(source, @"(?m)remove-path-by-operation:\s*(.+)$");
        Assert.True(selector.Success);
        var regex = new Regex(selector.Groups[1].Value.Trim());
        using var ledger = ReadLedger();
        var mappings = ledger.RootElement.GetProperty("mappings").EnumerateArray().ToArray();
        Assert.Equal(2, mappings.Length);

        foreach (var root in new[] { "openApiDocs", "openApiDocs_KiotaCompat" })
        {
            var operations = ReadOperations(root, profile);
            Assert.Equal(count, operations.Length);
            Assert.All(operations, operation =>
            {
                Assert.DoesNotMatch(regex, operation.Definition.OperationId!);
                Assert.DoesNotContain("/onenote/", operation.Path, StringComparison.OrdinalIgnoreCase);
            });
        }

        Assert.Contains("subject: ^(UserOnenote)Notebook(RecentNotebook)$", source, StringComparison.Ordinal);
        Assert.Contains("subject: $1$2", source, StringComparison.Ordinal);
        foreach (var mapping in mappings)
        {
            Assert.Equal("NoMatchingOperations", mapping.GetProperty("implementation").GetString());
            var evidence = mapping.GetProperty("profiles").GetProperty(profile);
            Assert.True(evidence.GetProperty("absenceExpected").GetBoolean());
            Assert.Empty(evidence.GetProperty("operations").EnumerateArray());
            Assert.False(evidence.TryGetProperty("operationIdSource", out _));
        }
    }

    [Theory]
    [InlineData("v1.0", 7)]
    [InlineData("beta", 16)]
    public void AuditAccountsForEveryRealFunctionWithActualMetadataGuardedBridge(string profile, int count)
    {
        var legacy = ReadOperations("openApiDocs", profile);
        var compatible = ReadOperations("openApiDocs_KiotaCompat", profile);
        Assert.Equal(count, legacy.Length);
        Assert.Equal(count, compatible.Length);
        using var ledger = ReadLedger();
        var audit = ledger.RootElement.GetProperty("scopeAudit").GetProperty("profiles").GetProperty(profile);
        Assert.Equal(count, audit.GetProperty("sourceOperationCount").GetInt32());
        Assert.Equal(count, audit.GetProperty("compatibleOperationCount").GetInt32());
        Assert.Equal(0, audit.GetProperty("originalSelectorMatchCount").GetInt32());
        Assert.Equal(0, audit.GetProperty("compatibleSelectorMatchCount").GetInt32());
        var bridges = audit.GetProperty("operations").EnumerateArray().ToArray();
        Assert.Equal(count, bridges.Length);
        var accountedLegacy = new HashSet<string>(StringComparer.Ordinal);
        var accountedCompatible = new HashSet<string>(StringComparer.Ordinal);

        foreach (var bridge in bridges)
        {
            var oldPath = bridge.GetProperty("sourcePath").GetString()!;
            var newPath = bridge.GetProperty("path").GetString()!;
            Assert.Equal("GET", bridge.GetProperty("method").GetString());
            var oldOperation = Assert.Single(legacy, op => op.Method == HttpMethod.Get && op.Path == oldPath);
            var newOperation = Assert.Single(compatible, op => op.Method == HttpMethod.Get && op.Path == newPath);
            Assert.Equal(bridge.GetProperty("sourceOperationId").GetString(), oldOperation.Definition.OperationId);
            Assert.Equal(bridge.GetProperty("operationId").GetString(), newOperation.Definition.OperationId);
            Assert.NotEqual(oldOperation.Definition.OperationId, newOperation.Definition.OperationId);
            AssertActualFunction(oldOperation);
            AssertActualFunction(newOperation);
            Assert.Equal("function", bridge.GetProperty("sourceKind").GetString());
            Assert.Equal("function", bridge.GetProperty("compatibleKind").GetString());

            var lastSlash = oldPath.LastIndexOf('/');
            var parent = oldPath[..(lastSlash + 1)];
            var final = oldPath[(lastSlash + 1)..];
            Assert.StartsWith("microsoft.graph.", final, StringComparison.Ordinal);
            Assert.Equal(parent + final["microsoft.graph.".Length..], newPath);
            Assert.True(accountedLegacy.Add(oldPath));
            Assert.True(accountedCompatible.Add(newPath));
            // Audit lineage is not a suppression: no actual function matches a shared directive.
            Assert.False(CmdletConfigurator.IsSuppressed(newOperation.Method, newPath,
                new GeneratorConfig("Test.Client", "unused", profile, UseCollisionData: false)));
        }
        Assert.True(accountedLegacy.SetEquals(legacy.Select(op => op.Path)));
        Assert.True(accountedCompatible.SetEquals(compatible.Select(op => op.Path)));
        Assert.Empty(legacy.Select(op => op.Path).Intersect(compatible.Select(op => op.Path), StringComparer.Ordinal));
    }

    [Theory]
    [InlineData("v1.0", "/users/delta()", "Get", "MgUserDelta")]
    [InlineData("beta", "/users/delta()", "Get", "MgUserDelta")]
    [InlineData("v1.0", "/users/{user-id}/getManagedAppPolicies()", "Get", "MgUserManagedAppPolicy")]
    [InlineData("beta", "/users/{user-id}/getManagedAppPolicies()", "Get", "MgUserGetManagedAppPolicies")]
    [InlineData("v1.0", "/users/{user-id}/exportDeviceAndAppManagementData()", "Export", "MgUserDeviceAndAppManagementData")]
    [InlineData("beta", "/users/{user-id}/findRooms()", "Get", "MgUserFindRooms")]
    public void UnaffectedFunctionsRetainExistingConfiguredNames(string profile, string path, string verb, string noun)
    {
        var operation = Assert.Single(ReadOperations("openApiDocs_KiotaCompat", profile), op => op.Path == path);
        AssertActualFunction(operation);
        var config = new GeneratorConfig("Test.Client", "unused", profile);
        Assert.False(CmdletConfigurator.IsSuppressed(operation.Method, path, config));
        var naming = Naming.Resolve(new OperationInfo(operation.Method, path, Kind: OperationKind.Function), config);
        Assert.Equal(verb, naming.VerbName);
        Assert.Equal(noun, naming.Noun);
    }

    private static void AssertActualFunction(Operation operation)
    {
        Assert.Equal(HttpMethod.Get, operation.Method);
        Assert.NotNull(operation.Definition.Extensions);
        Assert.True(operation.Definition.Extensions.TryGetValue("x-ms-docs-operation-type", out var extension));
        Assert.Equal("function", Assert.IsType<JsonNodeExtension>(extension).Node?.ToString().Trim('"'));
    }

    private static Operation[] ReadOperations(string root, string profile)
    {
        var settings = new OpenApiReaderSettings();
        settings.AddYamlReader();
        using var stream = File.OpenRead(Path.Combine(RepoRoot(), root, profile, "Users.Functions.yml"));
        var result = OpenApiDocument.LoadAsync(stream, settings: settings, cancellationToken: CancellationToken.None)
            .GetAwaiter().GetResult();
        var document = Assert.IsType<OpenApiDocument>(result.Document);
        return document.Paths.SelectMany(path =>
            (path.Value.Operations ?? new Dictionary<HttpMethod, OpenApiOperation>())
                .Select(operation => new Operation(operation.Key, path.Key, operation.Value))).ToArray();
    }

    private static JsonDocument ReadLedger() =>
        JsonDocument.Parse(File.ReadAllText(Path.Combine(RepoRoot(), "src", "Users.Functions", "wrapper",
            "Users.Functions_directiveMigrationMap.json")));

    private static string RepoRoot()
    {
        var directory = AppContext.BaseDirectory;
        while (directory is not null && !Directory.Exists(Path.Combine(directory, "openApiDocs_KiotaCompat")))
            directory = Path.GetDirectoryName(directory);
        return directory ?? throw new InvalidOperationException("Repository root not found.");
    }
}
