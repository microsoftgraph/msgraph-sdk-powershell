using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Reader;
using WrapperGenerator;
using Xunit;

namespace WrapperGenerator.Tests;

public sealed class MailDirectiveMigrationTests
{
    private const string Message = "/users/{user-id}/messages/{message-id}";
    private const string FolderMessage = "/users/{user-id}/mailFolders/{mailFolder-id}/messages/{message-id}";
    private const string ChildFolderMessage = "/users/{user-id}/mailFolders/{mailFolder-id}/childFolders/{mailFolder-id1}/messages/{message-id}";
    private static readonly GeneratorConfig V1 = new("Test.Client", "unused", ApiVersion: "v1.0");
    private static readonly Lazy<string> RepoRoot = new(FindRepoRoot);
    private static readonly Lazy<OpenApiDocument> Spec = new(ReadSpec);

    [Fact]
    public void ReviewedLedgerMatchesEverySelectedCompatibleOperation()
    {
        using var ledger = JsonDocument.Parse(File.ReadAllText(Path.Combine(
            RepoRoot.Value, "src", "Mail", "wrapper", "Mail_directiveMigrationMap.json")));
        Assert.Equal("v1.0", Assert.Single(ledger.RootElement.GetProperty("requiredProfiles").EnumerateArray()).GetString());
        var mappings = ledger.RootElement.GetProperty("mappings").EnumerateArray().ToArray();
        Assert.Equal(3, mappings.Length);
        var source = File.ReadAllText(Path.Combine(RepoRoot.Value, "src", "Mail", "Mail.md"));
        var counts = new[] { 1, 3, 3 };
        var suffixes = new[] { "/$value", "/replyAll", "/createReplyAll" };

        for (var i = 0; i < mappings.Length; i++)
        {
            var mapping = mappings[i];
            Assert.Equal("Mail", mapping.GetProperty("module").GetString());
            Assert.Equal(i + 1, mapping.GetProperty("directiveIndex").GetInt32());
            Assert.Equal(i == 0 ? "CmdletSuppression" : "SubjectRename", mapping.GetProperty("classification").GetString());
            Assert.Equal("DerivedParityData", mapping.GetProperty("implementation").GetString());
            Assert.Contains(mapping.GetProperty("sourceContains").GetString()!, source, StringComparison.Ordinal);
            var profile = mapping.GetProperty("profiles").GetProperty("v1.0");
            Assert.False(profile.GetProperty("absenceExpected").GetBoolean());
            var operations = profile.GetProperty("operations").EnumerateArray().ToArray();
            Assert.Equal(counts[i], operations.Length);
            var expectedPaths = i == 0
                ? new[] { FolderMessage + suffixes[i] }
                : new[] { Message, FolderMessage, ChildFolderMessage }.Select(p => p + suffixes[i]).ToArray();
            Assert.Equal(expectedPaths.OrderBy(p => p), operations.Select(o => o.GetProperty("path").GetString()!).OrderBy(p => p));

            foreach (var operation in operations)
            {
                var method = operation.GetProperty("method").GetString()!;
                Assert.Equal(i == 0 ? "GET" : "POST", method);
                var actual = SpecOperation(method, operation.GetProperty("path").GetString()!);
                Assert.Equal(operation.GetProperty("operationId").GetString(), actual.OperationId);
            }
        }
    }

    [Fact]
    public void BetaIsExplicitlyExcludedForMissingCompatibleInputNotOperationAbsence()
    {
        Assert.False(File.Exists(Path.Combine(RepoRoot.Value, "openApiDocs_KiotaCompat", "beta", "Mail.yml")));
        using var ledger = JsonDocument.Parse(File.ReadAllText(Path.Combine(
            RepoRoot.Value, "src", "Mail", "wrapper", "Mail_directiveMigrationMap.json")));
        Assert.Contains("no legacy fallback", ledger.RootElement.GetProperty("excludedProfiles").GetProperty("beta").GetString()!);
        foreach (var mapping in ledger.RootElement.GetProperty("mappings").EnumerateArray())
        {
            var beta = mapping.GetProperty("profiles").GetProperty("beta");
            Assert.True(beta.GetProperty("excluded").GetBoolean());
            Assert.False(beta.TryGetProperty("absenceExpected", out _));
            Assert.Empty(beta.GetProperty("operations").EnumerateArray());
            Assert.Contains("no API-operation absence assertion", beta.GetProperty("notes").GetString()!);
        }
    }

    [Fact]
    public void FolderContentSuppressionUsesExistingExactGetParityEntry()
    {
        const string path = FolderMessage + "/$value";
        Assert.Equal("users.mailFolders.GetMessagesContent", SpecOperation("GET", path).OperationId);
        Assert.True(CmdletConfigurator.IsSuppressed(HttpMethod.Get, path, V1));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get, path));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get, path,
            V1 with { UseCollisionData = false }));
        Assert.True(CmdletConfigurator.IsSuppressed(HttpMethod.Get,
            "/users/{id}/mailFolders/{folder}/messages/{message}/$value", V1));
    }

    [Theory]
    [InlineData("GET", Message + "/$value", "MgUserMessageContent")]
    [InlineData("GET", ChildFolderMessage + "/$value", "MgUserMailFolderChildFolderMessageContent")]
    [InlineData("PUT", FolderMessage + "/$value", "MgUserMailFolderMessageContent")]
    [InlineData("DELETE", FolderMessage + "/$value", "MgUserMailFolderMessageContent")]
    [InlineData("GET", FolderMessage, "MgUserMailFolderMessage")]
    public void ContentSuppressionDoesNotAffectNeighbors(string method, string path, string noun)
    {
        SpecOperation(method, path);
        var httpMethod = new HttpMethod(method);
        Assert.False(CmdletConfigurator.IsSuppressed(httpMethod, path, V1));
        Assert.Equal(noun, Naming.Resolve(new OperationInfo(httpMethod, path), V1).Noun);
    }

    public static IEnumerable<object[]> ReplyActions()
    {
        foreach (var (path, noun) in new[]
        {
            (Message, "UserMessage"),
            (FolderMessage, "UserMailFolderMessage"),
            (ChildFolderMessage, "UserMailFolderChildFolderMessage"),
        })
        {
            yield return new object[] { path + "/replyAll", "Invoke", "MgReplyAll" + noun, true };
            yield return new object[] { path + "/createReplyAll", "New", "Mg" + noun + "ReplyAll", true };
            yield return new object[] { path + "/reply", "Invoke", "MgReply" + noun, false };
            yield return new object[] { path + "/createReply", "New", "Mg" + noun + "Reply", false };
        }
    }

    [Theory]
    [MemberData(nameof(ReplyActions))]
    public void ReplyAllRenamesUseExistingParityAndKeepPlainReplyNeighbors(
        string path, string verb, string noun, bool migrated)
    {
        var operation = SpecOperation("POST", path);
        Assert.EndsWith(path[(path.LastIndexOf('/') + 1)..], operation.OperationId);
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Post, path, V1));
        var info = new OperationInfo(HttpMethod.Post, path, Kind: OperationKind.Action);
        var naming = Naming.Resolve(info, V1);
        Assert.Equal(verb, naming.VerbName);
        Assert.Equal(noun, naming.Noun);
        if (migrated)
        {
            // These names require the existing derived data, not new curated overrides.
            Assert.NotEqual(noun, Naming.Resolve(info, V1 with { UseCollisionData = false }).Noun);
        }
    }

    [Fact]
    public void ExistingCuratedReplyToSuppressionRemainsIntact()
    {
        const string path = "/replies/{id}/replyTo";
        Assert.True(CmdletConfigurator.IsSuppressed(HttpMethod.Get, path, V1));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get, path + "/other", V1));
    }

    private static OpenApiOperation SpecOperation(string method, string path)
    {
        Assert.True(Spec.Value.Paths.TryGetValue(path, out var item), $"Missing Mail v1.0 path: {path}");
        Assert.NotNull(item.Operations);
        Assert.True(item.Operations.TryGetValue(new HttpMethod(method), out var operation),
            $"Missing Mail v1.0 operation: {method} {path}");
        return operation;
    }

    private static OpenApiDocument ReadSpec()
    {
        var settings = new OpenApiReaderSettings();
        settings.AddYamlReader();
        using var stream = File.OpenRead(Path.Combine(RepoRoot.Value, "openApiDocs_KiotaCompat", "v1.0", "Mail.yml"));
        var result = OpenApiDocument.LoadAsync(stream, settings: settings, cancellationToken: CancellationToken.None)
            .GetAwaiter().GetResult();
        return result.Document ?? throw new InvalidDataException("Could not parse the compatible Mail v1.0 spec.");
    }

    private static string FindRepoRoot()
    {
        var directory = new DirectoryInfo(AppContext.BaseDirectory);
        while (directory is not null && !File.Exists(Path.Combine(directory.FullName, "src", "Mail", "Mail.md")))
            directory = directory.Parent;
        return directory?.FullName ?? throw new InvalidOperationException("Could not locate the Mail module.");
    }
}
