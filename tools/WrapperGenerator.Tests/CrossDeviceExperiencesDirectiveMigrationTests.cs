using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
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
    public async Task SharedHistoricalSelectorHasReviewedAbsenceInCompatibleSpec(string profile)
    {
        using var ledger = ReadLedger();
        var mapping = Assert.Single(ledger.RootElement.GetProperty("mappings").EnumerateArray());
        Assert.Equal("OperationIdSuppression", mapping.GetProperty("classification").GetString());
        Assert.Equal("ExpectedAbsence", mapping.GetProperty("implementation").GetString());
        var source = File.ReadAllText(Path.Combine(FindRepoRoot(), "src",
            "CrossDeviceExperiences", "CrossDeviceExperiences.md"));
        var directive = Assert.Single(Regex.Matches(source, @"(?m)^\s+- remove-path-by-operation: (.+)$").Cast<Match>());
        Assert.Contains(mapping.GetProperty("sourceContains").GetString()!, source);
        var selector = directive.Groups[1].Value.Trim();
        var profileMap = mapping.GetProperty("profiles").GetProperty(profile);
        Assert.True(profileMap.GetProperty("absenceExpected").GetBoolean());
        Assert.Empty(profileMap.GetProperty("operations").EnumerateArray());
        var evidence = profileMap.GetProperty("evidence");
        Assert.Equal(selector, evidence.GetProperty("selector").GetString());

        var document = await ReadSpecAsync(profile);
        var operations = document.Paths.Values.SelectMany(path => path.Operations!.Values).ToArray();
        Assert.Equal(evidence.GetProperty("pathCount").GetInt32(), document.Paths.Count);
        Assert.Equal(evidence.GetProperty("operationCount").GetInt32(), operations.Length);
        Assert.Equal(0, evidence.GetProperty("selectorMatchCount").GetInt32());
        Assert.DoesNotContain(operations, operation => Regex.IsMatch(operation.OperationId!, selector));
        if (profile == "v1.0")
            Assert.DoesNotContain(document.Paths.Keys, path => path.Contains("/devices", StringComparison.Ordinal));
    }

    [Theory]
    [InlineData("v1.0")]
    [InlineData("beta")]
    public async Task CurrentActivityAndDeviceRoutesAreNotSuppressedByHistoricalSelector(string profile)
    {
        using var ledger = ReadLedger();
        var mapping = Assert.Single(ledger.RootElement.GetProperty("mappings").EnumerateArray());
        var neighbors = mapping.GetProperty("profiles").GetProperty(profile)
            .GetProperty("evidence").GetProperty("unaffectedOperations").EnumerateArray().ToArray();
        Assert.NotEmpty(neighbors);
        var document = await ReadSpecAsync(profile);
        var config = new GeneratorConfig("Test.Client", "unused", profile);
        foreach (var neighbor in neighbors)
        {
            var method = new HttpMethod(neighbor.GetProperty("method").GetString()!);
            var path = neighbor.GetProperty("path").GetString()!;
            Assert.True(document.Paths.ContainsKey(path), $"Missing {profile} {method} {path}.");
            Assert.True(document.Paths[path].Operations!.TryGetValue(method, out var operation),
                $"Missing {profile} {method} {path}.");
            Assert.Equal(neighbor.GetProperty("operationId").GetString(), operation.OperationId);
            Assert.False(CmdletConfigurator.IsSuppressed(method, path));
            Assert.False(CmdletConfigurator.IsSuppressed(method, path, config));
        }

        var activity = Naming.Resolve(new OperationInfo(HttpMethod.Delete,
            "/users/{user-id}/activities/{userActivity-id}"));
        Assert.Equal("Remove", activity.VerbName);
        Assert.Equal("MgUserActivity", activity.Noun);
    }

    private static JsonDocument ReadLedger() => JsonDocument.Parse(File.ReadAllText(
        Path.Combine(FindRepoRoot(), "src", "CrossDeviceExperiences", "wrapper",
            "CrossDeviceExperiences_directiveMigrationMap.json")));

    [Theory]
    [InlineData("registeredOwners", "RegisteredOwner")]
    [InlineData("registeredUsers", "RegisteredUser")]
    public async Task BetaItemReferenceDeleteUsesPublishedNounWithoutSuppressingCollectionDelete(
        string navigation, string noun)
    {
        var document = await ReadSpecAsync("beta");
        var itemPath = $"/users/{{user-id}}/devices/{{device-id}}/{navigation}/{{directoryObject-id}}/$ref";
        var collectionPath = $"/users/{{user-id}}/devices/{{device-id}}/{navigation}/$ref";
        Assert.Equal($"users.devices.{navigation}.DeleteRefDirectoryObject",
            document.Paths[itemPath].Operations![HttpMethod.Delete].OperationId);
        Assert.Equal($"users.devices.DeleteRef{navigation[..1].ToUpperInvariant()}{navigation[1..]}",
            document.Paths[collectionPath].Operations![HttpMethod.Delete].OperationId);
        var config = new GeneratorConfig("Test.Client", "unused", "beta");
        var item = Naming.Resolve(new OperationInfo(HttpMethod.Delete, itemPath), config);
        var collection = Naming.Resolve(new OperationInfo(HttpMethod.Delete, collectionPath), config);
        Assert.Equal($"MgUserDevice{noun}DirectoryObjectByRef", item.Noun);
        Assert.Equal($"MgUserDevice{noun}ByRef", collection.Noun);
        Assert.NotEqual(item.ClassName, collection.ClassName);
        Assert.Equal("Remove", item.VerbName);
        Assert.Equal("Remove", collection.VerbName);
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Delete, itemPath, config));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Delete, collectionPath, config));
        Assert.Equal($"MgUserDevice{noun}ByRef",
            Naming.Resolve(new OperationInfo(HttpMethod.Get, collectionPath), config).Noun);
    }

    private static async Task<OpenApiDocument> ReadSpecAsync(string profile)
    {
        var settings = new OpenApiReaderSettings();
        settings.AddYamlReader();
        using var stream = File.OpenRead(Path.Combine(FindRepoRoot(), "openApiDocs_KiotaCompat",
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
