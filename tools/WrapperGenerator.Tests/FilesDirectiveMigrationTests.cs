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

public sealed class FilesDirectiveMigrationTests
{
    private const string SharedListSingleton = "/shares/{sharedDriveItem-id}/listItem";
    private const string SharedListCollection = "/shares/{sharedDriveItem-id}/list/items";

    [Theory]
    [InlineData("v1.0", 10, 46)]
    [InlineData("beta", 56, 216)]
    public void OriginalLegacySelectorSurvivorsEqualCurrentLiteralSelection(string profile, int survivors, int removals)
    {
        var root = FindRepoRoot();
        var markdown = File.ReadAllText(Path.Combine(root, "src", "Files", "Files.md"));
        var selector = new Regex(Regex.Match(markdown, @"remove-path-by-operation: ([^\r\n]+)").Groups[1].Value);
        var original = ReadOperations(Path.Combine(root, "openApiDocs", profile, "Files.yml"))
            .Where(operation => selector.IsMatch(operation.Id)).ToArray();
        var current = ReadOperations(Path.Combine(root, "openApiDocs_KiotaCompat", profile, "Files.yml"));
        var currentByKey = current.ToDictionary(Key, StringComparer.Ordinal);
        var surviving = new List<SpecOperation>();
        var removed = new List<SpecOperation>();
        foreach (var old in original)
        {
            if (currentByKey.TryGetValue(Key(old), out var successor))
                surviving.Add(successor);
            else if (old.Method == "POST" && old.Kind == "action" &&
                old.Path.EndsWith("/microsoft.graph.createLink", StringComparison.Ordinal) &&
                currentByKey.TryGetValue(Key(old with { Path = old.Path.Replace("/microsoft.graph.createLink", "/createLink", StringComparison.Ordinal) }), out successor))
            {
                Assert.Equal("action", successor.Kind);
                surviving.Add(successor);
            }
            else
                removed.Add(old);
        }

        Assert.Equal(survivors + removals, original.Length);
        Assert.Equal(survivors, surviving.Count);
        Assert.Equal(removals, removed.Count);
        Assert.Equal(surviving.Select(Key).OrderBy(key => key, StringComparer.Ordinal),
            current.Where(operation => selector.IsMatch(operation.Id)).Select(Key).OrderBy(key => key, StringComparer.Ordinal));
        using var ledger = ReadLedger();
        var mapping = ledger.RootElement.GetProperty("mappings")[0].GetProperty("profiles").GetProperty(profile);
        var declared = mapping.GetProperty("operations").EnumerateArray().Select(operation =>
            new SpecOperation(operation.GetProperty("method").GetString()!, operation.GetProperty("path").GetString()!,
                operation.GetProperty("operationId").GetString()!, "")).ToArray();
        Assert.Equal(surviving.Select(operation => (operation.Method, operation.Path, operation.Id)).OrderBy(operation => operation.Path),
            declared.Select(operation => (operation.Method, operation.Path, operation.Id)).OrderBy(operation => operation.Path));
        Assert.DoesNotContain("operationIdSource", ledger.RootElement.GetRawText());
        Assert.DoesNotContain("removedLegacyOperations", ledger.RootElement.GetRawText());
        Assert.DoesNotContain("legacyPath", ledger.RootElement.GetRawText());
    }

    [Theory]
    [InlineData("v1.0", true, 10)]
    [InlineData("v1.0", false, 10)]
    [InlineData("beta", true, 56)]
    [InlineData("beta", false, 56)]
    public void EverySurvivingLegacySelectionIsSuppressed(string profile, bool useCollisionData, int survivingCount)
    {
        using var ledger = ReadLedger();
        var mapping = ledger.RootElement.GetProperty("mappings")[0].GetProperty("profiles").GetProperty(profile);
        Assert.False(mapping.GetProperty("absenceExpected").GetBoolean());
        Assert.Equal(survivingCount, mapping.GetProperty("operations").GetArrayLength());
        var config = new GeneratorConfig("Test.Client", "unused", useCollisionData);
        foreach (var operation in mapping.GetProperty("operations").EnumerateArray())
        {
            var method = new HttpMethod(operation.GetProperty("method").GetString()!);
            var path = operation.GetProperty("path").GetString()!;
            Assert.True(CmdletConfigurator.IsSuppressed(method, path, config, apiVersion: profile), $"{profile}: {method} {path}");
        }
    }

    [Theory]
    [InlineData("v1.0", true)]
    [InlineData("v1.0", false)]
    [InlineData("beta", true)]
    [InlineData("beta", false)]
    public async Task AmbiguousSharedListRoutesUseDescriptiveNamesWithoutSelectors(string profile, bool useCollisionData)
    {
        var settings = new OpenApiReaderSettings();
        settings.AddYamlReader();
        using var stream = File.OpenRead(Path.Combine(FindRepoRoot(), "openApiDocs_KiotaCompat", profile, "Files.yml"));
        var result = await OpenApiDocument.LoadAsync(stream, settings: settings, cancellationToken: CancellationToken.None);
        var document = Assert.IsType<OpenApiDocument>(result.Document);
        foreach (var path in document.Paths.Keys.ToArray())
            if (path != SharedListSingleton && path != SharedListCollection)
                document.Paths.Remove(path);
        foreach (var path in document.Paths.Values)
            foreach (var method in path.Operations!.Keys.Where(method => method != HttpMethod.Get).ToArray())
                path.Operations.Remove(method);
        Assert.Equal("share_GetListItem", document.Paths[SharedListSingleton].Operations![HttpMethod.Get].OperationId);
        Assert.Equal("share.list_ListItem", document.Paths[SharedListCollection].Operations![HttpMethod.Get].OperationId);
        var output = Path.Combine(Path.GetTempPath(), "files-shared-list-tests-" + Guid.NewGuid().ToString("N"));
        try
        {
            await new PowerShellWrapperGenerationService(document,
                new GeneratorConfig("Microsoft.Graph.PowerShell.Files.Client", output, useCollisionData),
                NullLogger.Instance, apiVersion: profile).GenerateAsync(CancellationToken.None);
            var singleton = File.ReadAllText(Path.Combine(output, "GetMgShareListItem.g.cs"));
            Assert.Contains($"[GraphRoute(\"GET\", \"{SharedListSingleton}\")]", singleton);
            Assert.DoesNotContain("public string Route", singleton);
            var collectionPath = Path.Combine(output, "GetMgShareListContainedItem.g.cs");
            if (profile == "v1.0" && useCollisionData)
                Assert.False(File.Exists(collectionPath)); // Preserve existing v1.0 derived suppression.
            else
            {
                var collection = File.ReadAllText(collectionPath);
                Assert.Contains($"[GraphRoute(\"GET\", \"{SharedListCollection}\")]", collection);
                Assert.Contains("public string SharedDriveItemId", collection);
                Assert.Contains("public SwitchParameter All", collection);
                Assert.Contains("public string? Filter", collection);
                Assert.DoesNotContain("public string Route", collection);
            }
        }
        finally
        {
            if (Directory.Exists(output))
                Directory.Delete(output, recursive: true);
        }
    }

    [Theory]
    [InlineData("v1.0", true)]
    [InlineData("v1.0", false)]
    [InlineData("beta", true)]
    [InlineData("beta", false)]
    public void ExistingDefaultDriveRenamesRemainGetOnly(string profile, bool useCollisionData)
    {
        var config = new GeneratorConfig("Test.Client", "unused", useCollisionData);
        foreach (var (path, noun) in new[]
        {
            ("/groups/{group-id}/drive", "GroupDefaultDrive"),
            ("/users/{user-id}/drive", "UserDefaultDrive"),
            ("/sites/{site-id}/drive", "SiteDefaultDrive"),
            ("/groups/{group-id}/sites/{site-id}/drive", "GroupSiteDefaultDrive"),
        })
        {
            var naming = Naming.Resolve(new OperationInfo(HttpMethod.Get, path), config, apiVersion: profile);
            Assert.Equal("Get", naming.VerbName);
            Assert.Equal($"Mg{noun}", naming.Noun);
            Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get, path, config, apiVersion: profile));
            Assert.Equal("Unchanged", CmdletConfigurator.ApplyNounOverrides(HttpMethod.Patch, path, "Unchanged", config, apiVersion: profile));
        }
        Assert.Equal("MgGroupDrive", Naming.Resolve(new OperationInfo(HttpMethod.Get, "/groups/{group-id}/drives"), config, apiVersion: profile).Noun);
        Assert.Equal("MgUserDrive", Naming.Resolve(new OperationInfo(HttpMethod.Get, "/users/{user-id}/drives"), config, apiVersion: profile).Noun);
    }

    [Theory]
    [InlineData("v1.0", true)]
    [InlineData("v1.0", false)]
    [InlineData("beta", true)]
    [InlineData("beta", false)]
    public void CollectionListsAndUnselectedNeighborsRemainAvailable(string profile, bool useCollisionData)
    {
        var config = new GeneratorConfig("Test.Client", "unused", useCollisionData);
        string[] paths =
        [
            "/drives/{drive-id}/items/{driveItem-id}/analytics/itemActivityStats/{itemActivityStat-id}/activities",
            "/drives/{drive-id}/items/{driveItem-id}/analytics/itemActivityStats/{itemActivityStat-id}",
            "/drives/{drive-id}/items/{driveItem-id}/children",
            "/drives/{drive-id}/items/{driveItem-id}/permissions",
            "/shares/{sharedDriveItem-id}/list/items/{listItem-id}/driveItem",
            "/shares/{sharedDriveItem-id}/list/items/{listItem-id}/fields",
        ];
        foreach (var path in paths)
            Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get, path, config, apiVersion: profile), $"{profile}: GET {path}");
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Post, "/drives/{drive-id}/items/{driveItem-id}/createLink", config, apiVersion: profile));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Post, "/drives/{drive-id}/list/items/{listItem-id}/createLink", config, apiVersion: profile));
        Assert.True(CmdletConfigurator.IsSuppressed(HttpMethod.Get, "/shares/{sharedDriveItem-id}/list/items/{listItem-id}", config, apiVersion: profile));
        if (profile == "beta")
            foreach (var path in new[]
            {
                "/drives/{drive-id}/activities",
                "/drives/{drive-id}/items/{driveItem-id}/activities",
                "/drives/{drive-id}/list/activities",
                "/drives/{drive-id}/list/items/{listItem-id}/activities",
                "/shares/{sharedDriveItem-id}/list/activities",
                "/shares/{sharedDriveItem-id}/list/items/{listItem-id}/activities",
            })
                Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get, path, config, apiVersion: profile), $"beta: GET {path}");
    }

    private sealed record SpecOperation(string Method, string Path, string Id, string Kind);

    private static string Key(SpecOperation operation) =>
        operation.Method + " " + Regex.Replace(operation.Path, @"\{[^}]+\}", "{}");

    private static List<SpecOperation> ReadOperations(string path)
    {
        var operations = new List<SpecOperation>();
        var currentPath = "";
        var method = "";
        var index = -1;
        foreach (var line in File.ReadLines(path))
        {
            var match = Regex.Match(line, @"^  (?:'(?<path>/.*)'|""(?<path>/.*)""|(?<path>/.*)):\s*$");
            if (match.Success)
            {
                currentPath = match.Groups["path"].Value.Replace("''", "'", StringComparison.Ordinal);
                method = "";
                index = -1;
            }
            else if ((match = Regex.Match(line, @"^    (get|post|patch|put|delete|head|options|trace):$")).Success)
            {
                method = match.Groups[1].Value.ToUpperInvariant();
                index = -1;
            }
            else if (method.Length > 0 && (match = Regex.Match(line, @"^      operationId: (.+)$")).Success)
            {
                operations.Add(new(method, currentPath, match.Groups[1].Value.Trim('\'', '"'), ""));
                index = operations.Count - 1;
                method = "";
            }
            else if (index >= 0 && (match = Regex.Match(line, @"^      x-ms-docs-operation-type: (.+)$")).Success)
                operations[index] = operations[index] with { Kind = match.Groups[1].Value };
        }
        return operations;
    }

    private static JsonDocument ReadLedger() =>
        JsonDocument.Parse(File.ReadAllText(Path.Combine(FindRepoRoot(), "src", "Files", "wrapper", "Files_directiveMigrationMap.json")));

    private static string FindRepoRoot()
    {
        var directory = AppContext.BaseDirectory;
        while (directory is not null)
        {
            if (File.Exists(Path.Combine(directory, "src", "Files", "Files.md")))
                return directory;
            directory = Path.GetDirectoryName(directory);
        }
        throw new InvalidOperationException("Repository root not found from test base directory.");
    }
}
