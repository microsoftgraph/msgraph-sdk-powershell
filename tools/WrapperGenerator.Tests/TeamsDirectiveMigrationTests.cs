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

public sealed class TeamsDirectiveMigrationTests
{
    private const string OriginalSelector = @"^(team_GetGroup|user\.joinedTeam.*|user_(Get|Update|Delete|Create)JoinedTeam|.*_UpdateInstalledApp)$";
    private static readonly string RepoRoot = FindRepoRoot();
    private static readonly Lazy<Dictionary<string, OpenApiDocument>> Documents = new(LoadDocuments);

    [Theory]
    [InlineData("v1.0", 337, 63)]
    [InlineData("beta", 9, 0)]
    public void OriginalOperationIdSelectorHasCompleteSurvivingLineage(string profile, int expectedCount, int expectedTranslations)
    {
        var legacy = Document("openApiDocs", profile);
        var compatible = Document("openApiDocs_KiotaCompat", profile);
        var originalMatches = legacy.Paths
            .SelectMany(path => path.Value.Operations!.Select(operation => (Path: path.Key, Method: operation.Key, Operation: operation.Value)))
            .Where(operation => Regex.IsMatch(operation.Operation.OperationId!, OriginalSelector))
            .ToArray();
        using var ledger = ReadLedger();
        var evidence = ledger.RootElement.GetProperty("mappings")[0].GetProperty("profiles").GetProperty(profile);
        var operations = evidence.GetProperty("operations").EnumerateArray().ToArray();

        Assert.Equal(expectedCount, originalMatches.Length);
        Assert.Equal(expectedCount, operations.Length);
        Assert.Equal("Legacy", evidence.GetProperty("operationIdSource").GetString());
        Assert.Empty(evidence.GetProperty("removedLegacyOperations").EnumerateArray());
        Assert.Equal(expectedTranslations, operations.Count(operation => operation.TryGetProperty("legacyPathTranslation", out _)));

        foreach (var old in originalMatches)
        {
            var bridge = Assert.Single(operations, operation =>
                operation.GetProperty("legacyOperationId").GetString() == old.Operation.OperationId
                && operation.GetProperty("legacyPath").GetString() == old.Path
                && operation.GetProperty("method").GetString() == old.Method.Method);
            var path = bridge.GetProperty("path").GetString()!;
            var modern = compatible.Paths[path].Operations![old.Method];
            Assert.Equal(bridge.GetProperty("operationId").GetString(), modern.OperationId);
            if (bridge.TryGetProperty("legacyPathTranslation", out var translation))
            {
                Assert.Equal("UnqualifyFinalOperation", translation.GetString());
                var kind = Kind(old.Operation);
                Assert.NotEqual(OperationKind.Resource, kind);
                Assert.Equal(kind, Kind(modern));
                var slash = old.Path.LastIndexOf('/');
                Assert.Equal(old.Path[..(slash + 1)], path[..(path.LastIndexOf('/') + 1)]);
                Assert.StartsWith("microsoft.graph.", old.Path[(slash + 1)..]);
                Assert.Equal(
                    CmdletConfigurator.NormalizePathTemplate(old.Path.Replace("/microsoft.graph.", "/", StringComparison.Ordinal)),
                    CmdletConfigurator.NormalizePathTemplate(path));
            }
            else
            {
                Assert.Equal(CmdletConfigurator.NormalizePathTemplate(old.Path), CmdletConfigurator.NormalizePathTemplate(path));
            }
        }
    }

    [Theory]
    [InlineData("v1.0")]
    [InlineData("beta")]
    public void EveryReviewedSuppressionAndRenameUsesActualCompatibleOperations(string profile)
    {
        var document = Document("openApiDocs_KiotaCompat", profile);
        using var ledger = ReadLedger();
        var mappings = ledger.RootElement.GetProperty("mappings").EnumerateArray().ToArray();
        Assert.Equal(9, mappings.Length);
        var source = File.ReadAllText(Path.Combine(RepoRoot, "src", "Teams", "Teams.md"));

        foreach (var mapping in mappings)
        {
            Assert.Contains(mapping.GetProperty("sourceContains").GetString()!, source);
            var index = mapping.GetProperty("directiveIndex").GetInt32();
            var operations = mapping.GetProperty("profiles").GetProperty(profile).GetProperty("operations").EnumerateArray().ToArray();
            Assert.Equal(index == 5 && profile == "v1.0", operations.Length == 0);
            foreach (var evidence in operations)
            {
                var method = new HttpMethod(evidence.GetProperty("method").GetString()!);
                var path = evidence.GetProperty("path").GetString()!;
                var operation = document.Paths[path].Operations![method];
                Assert.Equal(evidence.GetProperty("operationId").GetString(), operation.OperationId);
                foreach (var useDerivedData in new[] { false, true })
                {
                    var config = new GeneratorConfig("Test.Client", "unused", profile, useDerivedData);
                    if (index <= 5)
                        Assert.True(CmdletConfigurator.IsSuppressed(method, path, config), $"{profile} directive {index}: {method} {path}");
                    else
                    {
                        var name = Naming.Resolve(new OperationInfo(method, path, Kind: Kind(operation)), config);
                        Assert.Equal("Get", name.VerbName);
                        Assert.Equal("Mg" + evidence.GetProperty("expectedNoun").GetString(), name.Noun);
                    }
                }
            }
        }
    }

    [Theory]
    [InlineData("GET", "/users/{user-id}/joinedTeams")]
    [InlineData("GET", "/teams/{team-id}/installedApps/{teamsAppInstallation-id}")]
    [InlineData("DELETE", "/teams/{team-id}/installedApps/{teamsAppInstallation-id}")]
    [InlineData("POST", "/teams/{team-id}/installedApps/{teamsAppInstallation-id}/upgrade")]
    [InlineData("PATCH", "/teams/{team-id}/channels/{channel-id}/messages/{chatMessage-id}")]
    [InlineData("PATCH", "/chats/{chat-id}/messages/{chatMessage-id}/replies/{chatMessage-id1}")]
    [InlineData("PATCH", "/teams/{team-id}/primaryChannel/messages/{chatMessage-id}/replies/{chatMessage-id1}/hostedContents/{chatMessageHostedContent-id}")]
    [InlineData("DELETE", "/groups/{group-id}/team/channels/{channel-id}/messages/{chatMessage-id}")]
    [InlineData("GET", "/teamwork/teamTemplates/{teamTemplate-id}/definitions/{teamTemplateDefinition-id}/teamDefinition/channels")]
    [InlineData("GET", "/teamwork/teamTemplates/{teamTemplate-id}/definitions/{teamTemplateDefinition-id}/teamDefinition/primaryChannel")]
    public void SharedSuppressionsDoNotBroadenToUnaffectedNeighbors(string method, string path)
    {
        var observedProfiles = 0;
        foreach (var profile in new[] { "v1.0", "beta" })
        {
            var document = Document("openApiDocs_KiotaCompat", profile);
            if (!document.Paths.TryGetValue(path, out var item) || !item.Operations!.ContainsKey(new HttpMethod(method)))
                continue;
            observedProfiles++;
            Assert.False(CmdletConfigurator.IsSuppressed(new HttpMethod(method), path,
                new GeneratorConfig("Test.Client", "unused", profile, UseCollisionData: false)));
        }
        Assert.True(observedProfiles > 0, $"Neighbor is missing from both required compatible specs: {method} {path}");
    }

    [Theory]
    [InlineData("GET", "/teams/{team-id}/channels", "MgTeamChannel")]
    [InlineData("GET", "/groups/{group-id}/team/channels", "MgGroupTeamChannel")]
    [InlineData("GET", "/teams/{team-id}/channels/{channel-id}/messages", "MgTeamChannelMessage")]
    [InlineData("POST", "/users/{user-id}/chats/{chat-id}/messages", "MgUserChatMessage")]
    [InlineData("PATCH", "/users/{user-id}/chats/{chat-id}/messages/{chatMessage-id}", "MgUserChatMessage")]
    public void AllRenamesLeaveOrdinaryChannelsAndNonGetMessagesUnchanged(string method, string path, string expectedNoun)
    {
        foreach (var profile in new[] { "v1.0", "beta" })
        {
            Assert.True(Document("openApiDocs_KiotaCompat", profile).Paths[path].Operations!.ContainsKey(new HttpMethod(method)));
            foreach (var useDerivedData in new[] { false, true })
                Assert.Equal(expectedNoun, Naming.Resolve(new OperationInfo(new HttpMethod(method), path),
                    new GeneratorConfig("Test.Client", "unused", profile, useDerivedData)).Noun);
        }
    }

    [Theory]
    [InlineData("v1.0")]
    [InlineData("beta")]
    public void AllUserChatMessageEvidenceRetainsBothResourcesAndAggregateFunction(string profile)
    {
        using var ledger = ReadLedger();
        var operations = ledger.RootElement.GetProperty("mappings")[8].GetProperty("profiles").GetProperty(profile)
            .GetProperty("operations").EnumerateArray().ToArray();
        Assert.Equal(3, operations.Length);
        Assert.Equal(3, operations.Select(operation => operation.GetProperty("path").GetString()).Distinct().Count());
        var aggregate = Assert.Single(operations, operation => operation.GetProperty("path").GetString()!.EndsWith("/getAllMessages()", StringComparison.Ordinal));
        var actual = Document("openApiDocs_KiotaCompat", profile).Paths[aggregate.GetProperty("path").GetString()!].Operations![HttpMethod.Get];
        Assert.Equal(OperationKind.Function, Kind(actual));
        Assert.Contains(actual.Parameters!, parameter => parameter.Name == "model" && parameter.In == ParameterLocation.Query);
        Assert.Equal("users.user.chats.getAllMessages", actual.OperationId);
        Assert.DoesNotContain(Document("openApiDocs_KiotaCompat", profile).Paths.Keys,
            path => path.StartsWith("/users/", StringComparison.Ordinal) && path.Contains("/onlineMeetings", StringComparison.Ordinal));
    }

    [Theory]
    [InlineData("v1.0")]
    [InlineData("beta")]
    public async Task SingleRouteMigrationEmissionRetainsRenamedOperationsAndNeighbors(string profile)
    {
        var original = Document("openApiDocs_KiotaCompat", profile);
        var selected = new OpenApiDocument { Components = original.Components, Paths = new OpenApiPaths() };
        using var ledger = ReadLedger();
        var mappings = ledger.RootElement.GetProperty("mappings").EnumerateArray()
            .Where(mapping => mapping.GetProperty("directiveIndex").GetInt32() < 9).ToArray();
        foreach (var mapping in mappings)
        foreach (var evidence in mapping.GetProperty("profiles").GetProperty(profile).GetProperty("operations").EnumerateArray())
            Include(evidence.GetProperty("path").GetString()!, new HttpMethod(evidence.GetProperty("method").GetString()!));
        Include("/users/{user-id}/joinedTeams", HttpMethod.Get);
        Include("/teams/{team-id}/channels", HttpMethod.Get);
        Include("/chats/{chat-id}/messages/{chatMessage-id}", HttpMethod.Patch);

        var output = Path.Combine(Path.GetTempPath(), "teams-directive-tests", Guid.NewGuid().ToString("N"));
        try
        {
            var service = new PowerShellWrapperGenerationService(selected,
                new GeneratorConfig("Microsoft.Graph.PowerShell.Teams.Client", output, profile), NullLogger.Instance);
            await service.GenerateAsync(CancellationToken.None);
            var sources = Directory.GetFiles(output, "*.g.cs").ToDictionary(file => new FileInfo(file).Name, File.ReadAllText);
            Assert.Contains("GetMgUserJoinedTeam.g.cs", sources.Keys);
            Assert.Contains("GetMgTeamChannel.g.cs", sources.Keys);
            Assert.Contains("UpdateMgChatMessage.g.cs", sources.Keys);

            foreach (var mapping in mappings)
            foreach (var evidence in mapping.GetProperty("profiles").GetProperty(profile).GetProperty("operations").EnumerateArray())
            {
                var path = evidence.GetProperty("path").GetString()!;
                var route = $"[GraphRoute(\"{evidence.GetProperty("method").GetString()}\", \"{path}\")]";
                if (mapping.GetProperty("directiveIndex").GetInt32() <= 5)
                    Assert.DoesNotContain(sources.Values, source => source.Contains(route, StringComparison.Ordinal));
                else
                {
                    var noun = evidence.GetProperty("expectedNoun").GetString()!;
                    Assert.Contains("GetMg" + noun + ".g.cs", sources.Keys);
                    Assert.Contains(sources.Values, source => source.Contains(route, StringComparison.Ordinal));
                }
            }
        }
        finally
        {
            if (Directory.Exists(output))
                Directory.Delete(output, recursive: true);
        }

        void Include(string path, HttpMethod method)
        {
            if (!selected.Paths.TryGetValue(path, out var item))
            {
                item = new OpenApiPathItem { Operations = new Dictionary<HttpMethod, OpenApiOperation>() };
                selected.Paths.Add(path, item);
            }
            item.Operations![method] = original.Paths[path].Operations![method];
        }
    }

    private static OperationKind Kind(OpenApiOperation operation) =>
        operation.Extensions is not null
        && operation.Extensions.TryGetValue("x-ms-docs-operation-type", out var extension)
        && extension is JsonNodeExtension node
            ? node.Node?.ToString() switch
            {
                "action" => OperationKind.Action,
                "function" => OperationKind.Function,
                _ => OperationKind.Resource,
            }
            : OperationKind.Resource;

    private static JsonDocument ReadLedger() =>
        JsonDocument.Parse(File.ReadAllText(Path.Combine(RepoRoot, "src", "Teams", "wrapper", "Teams_directiveMigrationMap.json")));

    private static OpenApiDocument Document(string root, string profile) => Documents.Value[$"{root}|{profile}"];

    private static Dictionary<string, OpenApiDocument> LoadDocuments()
    {
        var documents = new Dictionary<string, OpenApiDocument>(StringComparer.Ordinal);
        var settings = new OpenApiReaderSettings();
        settings.AddYamlReader();
        foreach (var root in new[] { "openApiDocs", "openApiDocs_KiotaCompat" })
        foreach (var profile in new[] { "v1.0", "beta" })
        {
            using var stream = File.OpenRead(Path.Combine(RepoRoot, root, profile, "Teams.yml"));
            var result = OpenApiDocument.LoadAsync(stream, settings: settings, cancellationToken: CancellationToken.None).GetAwaiter().GetResult();
            documents.Add($"{root}|{profile}", result.Document ?? throw new InvalidDataException($"Cannot parse {root}/{profile}/Teams.yml"));
        }
        return documents;
    }

    private static string FindRepoRoot()
    {
        for (var directory = new DirectoryInfo(AppContext.BaseDirectory); directory is not null; directory = directory.Parent)
            if (File.Exists(Path.Combine(directory.FullName, "src", "Teams", "Teams.md")))
                return directory.FullName;
        throw new DirectoryNotFoundException("Cannot find the Teams shared directive source.");
    }
}
