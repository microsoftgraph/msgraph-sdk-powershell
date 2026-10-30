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

public sealed class CrossDeviceExperiencesDirectiveMigrationTests
{
    [Theory]
    [InlineData("v1.0")]
    [InlineData("beta")]
    public async Task SharedSelectorCoversCompleteActualLegacyMatchSetAndCompatibleSurvivors(string profile)
    {
        using var ledger = ReadLedger();
        var mapping = Assert.Single(ledger.RootElement.GetProperty("mappings").EnumerateArray());
        Assert.Equal("OperationIdSuppression", mapping.GetProperty("classification").GetString());
        Assert.Equal("CmdletConfigurator", mapping.GetProperty("implementation").GetString());
        var source = File.ReadAllText(Path.Combine(FindRepoRoot(), "src",
            "CrossDeviceExperiences", "CrossDeviceExperiences.md"));
        var directive = Assert.Single(Regex.Matches(source, @"(?m)^\s+- remove-path-by-operation: (.+)$").Cast<Match>());
        Assert.Contains(mapping.GetProperty("sourceContains").GetString()!, source);
        var selector = directive.Groups[1].Value.Trim();
        var profileMap = mapping.GetProperty("profiles").GetProperty(profile);
        Assert.Equal(profile == "v1.0", profileMap.GetProperty("absenceExpected").GetBoolean());
        var evidence = profileMap.GetProperty("evidence");
        Assert.Equal(selector, evidence.GetProperty("selector").GetString());

        var document = await ReadSpecAsync(profile);
        var operations = document.Paths.SelectMany(path => path.Value.Operations!
            .Select(operation => (Method: operation.Key, Path: path.Key, Operation: operation.Value))).ToArray();
        Assert.Equal(evidence.GetProperty("pathCount").GetInt32(), document.Paths.Count);
        Assert.Equal(evidence.GetProperty("operationCount").GetInt32(), operations.Length);
        var literalMatches = operations.Where(operation =>
            Regex.IsMatch(operation.Operation.OperationId!, selector)).ToArray();
        Assert.Equal(evidence.GetProperty("selectorMatchCount").GetInt32(), literalMatches.Length);
        var legacy = await ReadSpecAsync(profile, "openApiDocs");
        var legacyOperations = legacy.Paths.SelectMany(path => path.Value.Operations!
            .Select(operation => (Method: operation.Key, Path: path.Key, Operation: operation.Value))).ToArray();
        Assert.Equal(evidence.GetProperty("legacyOperationCount").GetInt32(), legacyOperations.Length);
        var sourceMatches = legacyOperations.Where(operation =>
            Regex.IsMatch(operation.Operation.OperationId!, selector)).ToArray();
        Assert.Equal(evidence.GetProperty("legacySelectorMatchCount").GetInt32(), sourceMatches.Length);
        var reviewed = profileMap.GetProperty("operations").EnumerateArray().ToArray();
        Assert.Equal(sourceMatches.Length, reviewed.Length);
        Assert.Equal(sourceMatches.Length, literalMatches.Length);
        Assert.Equal(
            sourceMatches.Select(operation => $"{operation.Method} {CmdletConfigurator.NormalizePathTemplate(operation.Path)}")
                .OrderBy(key => key, StringComparer.Ordinal),
            literalMatches.Select(operation => $"{operation.Method} {CmdletConfigurator.NormalizePathTemplate(operation.Path)}")
                .OrderBy(key => key, StringComparer.Ordinal));
        Assert.False(profileMap.TryGetProperty("operationIdSource", out _));
        Assert.False(profileMap.TryGetProperty("removedLegacyOperations", out _));
        Assert.Equal(evidence.GetProperty("survivingLegacyMatchCount").GetInt32(), reviewed.Length);
        Assert.Equal(0, evidence.GetProperty("removedLegacyMatchCount").GetInt32());
        foreach (var expected in reviewed)
        {
            var method = new HttpMethod(expected.GetProperty("method").GetString()!);
            var newPath = expected.GetProperty("path").GetString()!;
            var old = Assert.Single(sourceMatches, operation =>
                operation.Method == method
                && CmdletConfigurator.NormalizePathTemplate(operation.Path)
                    == CmdletConfigurator.NormalizePathTemplate(newPath));
            Assert.Equal(expected.GetProperty("operationId").GetString(), old.Operation.OperationId);
            Assert.Equal(CmdletConfigurator.NormalizePathTemplate(old.Path),
                CmdletConfigurator.NormalizePathTemplate(newPath));
            var counterpart = Assert.Single(document.Paths.SelectMany(path => path.Value.Operations!
                .Where(operation => operation.Key == method
                    && CmdletConfigurator.NormalizePathTemplate(path.Key)
                        == CmdletConfigurator.NormalizePathTemplate(old.Path))
                .Select(operation => (Path: path.Key, Operation: operation.Value))));
            Assert.Equal(newPath, counterpart.Path);
            Assert.Equal(expected.GetProperty("operationId").GetString(), counterpart.Operation.OperationId);
            Assert.True(CmdletConfigurator.IsSuppressed(method, newPath, apiVersion: profile));
            foreach (var useCollisionData in new[] { false, true })
                Assert.True(CmdletConfigurator.IsSuppressed(method, newPath,
                    new GeneratorConfig("Test.Client", "unused", UseCollisionData: useCollisionData),
                    apiVersion: profile));
        }
        if (profile == "v1.0")
            Assert.DoesNotContain(document.Paths.Keys, path => path.Contains("/devices", StringComparison.Ordinal));
        else
        {
            Assert.Equal(2, sourceMatches.Length);
        }
    }

    [Theory]
    [InlineData("v1.0", false)]
    [InlineData("v1.0", true)]
    [InlineData("beta", false)]
    [InlineData("beta", true)]
    public async Task CurrentActivityAndDeviceRoutesAreNotSuppressedByHistoricalSelector(
        string profile, bool useCollisionData)
    {
        using var ledger = ReadLedger();
        var mapping = Assert.Single(ledger.RootElement.GetProperty("mappings").EnumerateArray());
        var neighbors = mapping.GetProperty("profiles").GetProperty(profile)
            .GetProperty("evidence").GetProperty("unaffectedOperations").EnumerateArray().ToArray();
        Assert.NotEmpty(neighbors);
        var document = await ReadSpecAsync(profile);
        var config = new GeneratorConfig("Test.Client", "unused", UseCollisionData: useCollisionData);
        foreach (var neighbor in neighbors)
        {
            var method = new HttpMethod(neighbor.GetProperty("method").GetString()!);
            var path = neighbor.GetProperty("path").GetString()!;
            Assert.True(document.Paths.ContainsKey(path), $"Missing {profile} {method} {path}.");
            Assert.True(document.Paths[path].Operations!.TryGetValue(method, out var operation),
                $"Missing {profile} {method} {path}.");
            Assert.Equal(neighbor.GetProperty("operationId").GetString(), operation.OperationId);
            Assert.False(CmdletConfigurator.IsSuppressed(method, path, apiVersion: profile));
            Assert.False(CmdletConfigurator.IsSuppressed(method, path, config, apiVersion: profile));
        }

        var activity = Naming.Resolve(new OperationInfo(HttpMethod.Delete,
            "/users/{user-id}/activities/{userActivity-id}"), config, apiVersion: profile);
        Assert.Equal("Remove", activity.VerbName);
        Assert.Equal("MgUserActivity", activity.Noun);
    }

    private static JsonDocument ReadLedger() => JsonDocument.Parse(File.ReadAllText(
        Path.Combine(FindRepoRoot(), "src", "CrossDeviceExperiences", "wrapper",
            "CrossDeviceExperiences_directiveMigrationMap.json")));

    [Theory]
    [InlineData("registeredOwners", "RegisteredOwner", false)]
    [InlineData("registeredOwners", "RegisteredOwner", true)]
    [InlineData("registeredUsers", "RegisteredUser", false)]
    [InlineData("registeredUsers", "RegisteredUser", true)]
    public async Task BetaCollectionDeleteIsSuppressedWhileItemDeleteAndOtherMethodsRemain(
        string navigation, string noun, bool useCollisionData)
    {
        var document = await ReadSpecAsync("beta");
        var itemPath = $"/users/{{user-id}}/devices/{{device-id}}/{navigation}/{{directoryObject-id}}/$ref";
        var collectionPath = $"/users/{{user-id}}/devices/{{device-id}}/{navigation}/$ref";
        Assert.Equal($"user.device.{noun[..1].ToLowerInvariant()}{noun[1..]}_DeleteDirectoryObjectGraphBPreRef",
            document.Paths[itemPath].Operations![HttpMethod.Delete].OperationId);
        Assert.Equal($"user.device_Delete{noun}GraphBPreRef",
            document.Paths[collectionPath].Operations![HttpMethod.Delete].OperationId);
        var config = new GeneratorConfig("Test.Client", "unused", UseCollisionData: useCollisionData);
        var item = Naming.Resolve(new OperationInfo(HttpMethod.Delete, itemPath), config, apiVersion: "beta");
        var collection = Naming.Resolve(new OperationInfo(HttpMethod.Delete, collectionPath), config, apiVersion: "beta");
        Assert.Equal($"MgUserDevice{noun}DirectoryObjectByRef", item.Noun);
        Assert.Equal($"MgUserDevice{noun}ByRef", collection.Noun);
        Assert.NotEqual(item.ClassName, collection.ClassName);
        Assert.Equal("Remove", item.VerbName);
        Assert.Equal("Remove", collection.VerbName);
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Delete, itemPath, config, apiVersion: "beta"));
        Assert.True(CmdletConfigurator.IsSuppressed(HttpMethod.Delete, collectionPath, apiVersion: "beta"));
        Assert.True(CmdletConfigurator.IsSuppressed(HttpMethod.Delete, collectionPath, config, apiVersion: "beta"));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get, collectionPath, config, apiVersion: "beta"));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Post, collectionPath, config, apiVersion: "beta"));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Delete, collectionPath + "/extra", config, apiVersion: "beta"));
        Assert.Equal($"MgUserDevice{noun}ByRef",
            Naming.Resolve(new OperationInfo(HttpMethod.Get, collectionPath), config, apiVersion: "beta").Noun);
    }

    [Theory]
    [InlineData("v1.0", false, 16)]
    [InlineData("v1.0", true, 16)]
    [InlineData("beta", false, 117)]
    [InlineData("beta", true, 117)]
    public async Task GenerationServiceKeepsProfileContextAndReviewedRouteSurface(
        string profile, bool useCollisionData, int expectedCount)
    {
        var document = await ReadSpecAsync(profile);
        var output = Path.Combine(Path.GetTempPath(), $"crossdevice-profile-{Guid.NewGuid():N}");
        try
        {
            var config = new GeneratorConfig("Test.Client", output, UseCollisionData: useCollisionData);
            var service = new PowerShellWrapperGenerationService(document, config, NullLogger.Instance,
                apiVersion: profile);
            await service.GenerateAsync(CancellationToken.None);
            var files = Directory.GetFiles(output, "*.g.cs");
            Assert.Equal(expectedCount, files.Length);
            var sources = files.Select(File.ReadAllText).ToArray();
            using var ledger = ReadLedger();
            var mapping = Assert.Single(ledger.RootElement.GetProperty("mappings").EnumerateArray());
            var profileMap = mapping.GetProperty("profiles").GetProperty(profile);
            foreach (var neighbor in profileMap.GetProperty("evidence").GetProperty("unaffectedOperations").EnumerateArray())
            {
                var route = $"[GraphRoute(\"{neighbor.GetProperty("method").GetString()}\", \"{neighbor.GetProperty("path").GetString()}\")]";
                Assert.Contains(sources, source => source.Contains(route, StringComparison.Ordinal));
            }
            foreach (var suppressed in profileMap.GetProperty("operations").EnumerateArray())
            {
                var route = $"[GraphRoute(\"{suppressed.GetProperty("method").GetString()}\", \"{suppressed.GetProperty("path").GetString()}\")]";
                Assert.DoesNotContain(sources, source => source.Contains(route, StringComparison.Ordinal));
            }
            if (profile == "beta")
            {
                Assert.Contains(Path.Combine(output, "RemoveMgUserDeviceRegisteredOwnerDirectoryObjectByRef.g.cs"), files);
                Assert.Contains(Path.Combine(output, "RemoveMgUserDeviceRegisteredUserDirectoryObjectByRef.g.cs"), files);
            }
        }
        finally
        {
            if (Directory.Exists(output))
                Directory.Delete(output, recursive: true);
        }
    }

    private static async Task<OpenApiDocument> ReadSpecAsync(string profile, string specRoot = "openApiDocs_KiotaCompat")
    {
        var settings = new OpenApiReaderSettings();
        settings.AddYamlReader();
        using var stream = File.OpenRead(Path.Combine(FindRepoRoot(), specRoot,
            profile, "CrossDeviceExperiences.yml"));
        var result = await OpenApiDocument.LoadAsync(stream, settings: settings,
            cancellationToken: CancellationToken.None);
        Assert.NotNull(result.Document);
        return result.Document;
    }

    private static string FindRepoRoot()
    {
        var directory = new DirectoryInfo(AppContext.BaseDirectory);
        while (directory is not null
            && !Directory.Exists(Path.Combine(directory.FullName, ".git"))
            && !File.Exists(Path.Combine(directory.FullName, ".git")))
            directory = directory.Parent;
        return directory?.FullName
            ?? throw new InvalidOperationException("Could not locate repository root.");
    }
}
