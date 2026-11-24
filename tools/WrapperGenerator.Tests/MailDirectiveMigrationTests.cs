using System;
using System.Collections.Generic;
using System.Diagnostics;
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

public sealed class MailDirectiveMigrationTests
{
    private const string Message = "/users/{user-id}/messages/{message-id}";
    private const string FolderMessage = "/users/{user-id}/mailFolders/{mailFolder-id}/messages/{message-id}";
    private const string ChildFolderMessage = "/users/{user-id}/mailFolders/{mailFolder-id}/childFolders/{mailFolder-id1}/messages/{message-id}";
    private const string Profile = "v1.0";
    private static readonly GeneratorConfig Config = new("Test.Client", "unused");
    private static readonly Lazy<string> RepoRoot = new(FindRepoRoot);
    private static readonly Lazy<OpenApiDocument> Spec = new(() => ReadSpec("openApiDocs_KiotaCompat"));
    private static readonly Lazy<OpenApiDocument> SourceSpec = new(() => ReadSpec("openApiDocs"));

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
            Assert.Equal("CmdletConfigurator", mapping.GetProperty("implementation").GetString());
            Assert.True(mapping.GetProperty("replacesParityData").GetBoolean());
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

    [Theory]
    [InlineData(1, "^user\\.mailFolder_GetMessagesContent$", "/$value",
        "user.mailFolder_GetMessagesContent")]
    [InlineData(2, "^user(?:\\.mailFolder(?:\\.childFolder)?)?\\.message_replyAll$", "/replyAll",
        "user.mailFolder.childFolder.message_replyAll|user.mailFolder.message_replyAll|user.message_replyAll")]
    [InlineData(3, "^user(?:\\.mailFolder(?:\\.childFolder)?)?\\.message_createReplyAll$", "/createReplyAll",
        "user.mailFolder.childFolder.message_createReplyAll|user.mailFolder.message_createReplyAll|user.message_createReplyAll")]
    public void CompleteOriginalSelectionEqualsLedgerAndCurrentSurvivors(
        int directiveIndex, string sourcePattern, string suffix, string sourceIds)
    {
        var source = SourceSpec.Value.Paths.SelectMany(path => path.Value.Operations!
            .Where(operation => Regex.IsMatch(operation.Value.OperationId ?? "", sourcePattern))
            .Select(operation => (Method: operation.Key.Method,
                Path: path.Key.Replace("/microsoft.graph.", "/", StringComparison.Ordinal),
                Id: operation.Value.OperationId!))).ToArray();
        Assert.Equal(sourceIds.Split('|').OrderBy(id => id), source.Select(operation => operation.Id).OrderBy(id => id));
        using var ledger = JsonDocument.Parse(File.ReadAllText(Path.Combine(
            RepoRoot.Value, "src", "Mail", "wrapper", "Mail_directiveMigrationMap.json")));
        var mapped = ledger.RootElement.GetProperty("mappings")[directiveIndex - 1]
            .GetProperty("profiles").GetProperty(Profile).GetProperty("operations").EnumerateArray()
            .Select(operation => $"{operation.GetProperty("method").GetString()} {operation.GetProperty("path").GetString()}")
            .OrderBy(route => route).ToArray();
        Assert.Equal(mapped, source.Select(operation => $"{operation.Method} {operation.Path}").OrderBy(route => route));

        var current = Spec.Value.Paths.Where(path => path.Key.EndsWith(suffix, StringComparison.Ordinal))
            .SelectMany(path => path.Value.Operations!
                .Where(operation => directiveIndex == 1
                    ? operation.Key == HttpMethod.Get && path.Key == FolderMessage + suffix
                    : operation.Key == HttpMethod.Post)
                .Select(operation => $"{operation.Key.Method} {path.Key}"))
            .OrderBy(route => route).ToArray();
        Assert.Equal(mapped, current);
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
    public void FolderContentSuppressionIsOwnedByModuleConfiguration()
    {
        const string path = FolderMessage + "/$value";
        Assert.Equal("user.mailFolder_GetMessagesContent", SpecOperation("GET", path).OperationId);
        Assert.True(CmdletConfigurator.IsSuppressed(HttpMethod.Get, path, Config, apiVersion: Profile));
        Assert.True(CmdletConfigurator.IsSuppressed(HttpMethod.Get, path, apiVersion: Profile));
        Assert.True(CmdletConfigurator.IsSuppressed(HttpMethod.Get, path,
            Config with { UseCollisionData = false }, apiVersion: Profile));
        Assert.True(CmdletConfigurator.IsSuppressed(HttpMethod.Get,
            "/users/{id}/mailFolders/{folder}/messages/{message}/$value", Config, apiVersion: Profile));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Post, path, Config, apiVersion: Profile));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get, path + "/other", Config, apiVersion: Profile));
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
        Assert.False(CmdletConfigurator.IsSuppressed(httpMethod, path, Config, apiVersion: Profile));
        Assert.Equal(noun, Naming.Resolve(new OperationInfo(httpMethod, path), Config, apiVersion: Profile).Noun);
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
    public void ModuleOwnsReplyAllRenamesAndKeepsPlainReplyNeighbors(
        string path, string verb, string noun, bool migrated)
    {
        var operation = SpecOperation("POST", path);
        Assert.EndsWith(path[(path.LastIndexOf('/') + 1)..], operation.OperationId);
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Post, path, Config, apiVersion: Profile));
        var info = new OperationInfo(HttpMethod.Post, path, Kind: OperationKind.Action);
        var naming = Naming.Resolve(info, Config, apiVersion: Profile);
        Assert.Equal(verb, naming.VerbName);
        Assert.Equal(noun, naming.Noun);
        if (migrated)
        {
            foreach (var config in new[] { null, Config with { UseCollisionData = false } })
            {
                var authored = Naming.Resolve(info, config, apiVersion: Profile);
                Assert.Equal(verb, authored.VerbName);
                Assert.Equal(noun, authored.Noun);
            }
            Assert.Equal("Unchanged", CmdletConfigurator.ApplyNounOverrides(
                HttpMethod.Get, path, "Unchanged", Config with { UseCollisionData = false }, apiVersion: Profile));
            Assert.Equal("Unchanged", CmdletConfigurator.ApplyNounOverrides(
                HttpMethod.Post, path + "/other", "Unchanged", Config with { UseCollisionData = false }, apiVersion: Profile));
            Assert.Null(CmdletConfigurator.TryGetOverriddenVerb(
                HttpMethod.Get, path, Config with { UseCollisionData = false }, apiVersion: Profile));
            Assert.Null(CmdletConfigurator.TryGetOverriddenVerb(
                HttpMethod.Post, path + "/other", Config with { UseCollisionData = false }, apiVersion: Profile));
        }
    }

    [Fact]
    public void ModuleOwnedOperationsHaveNoDuplicateDerivedEntries()
    {
        var owned = ReplyActions().Where(row => (bool)row[3])
            .Select(row => "POST " + CmdletConfigurator.NormalizePathTemplate((string)row[0]))
            .Append("GET " + CmdletConfigurator.NormalizePathTemplate(FolderMessage + "/$value"))
            .ToHashSet(StringComparer.Ordinal);
        var data = Path.Combine(RepoRoot.Value, "tools", "WrapperGenerator", "data");
        foreach (var name in new[] { "parity-renames.v1.0.json", "parity-suppressions.v1.0.json",
            "collision-renames.v1.0.json", "collision-suppressions.v1.0.json" })
        {
            using var document = JsonDocument.Parse(File.ReadAllText(Path.Combine(data, name)));
            foreach (var entry in document.RootElement.EnumerateArray())
                Assert.DoesNotContain(entry.GetProperty("method").GetString() + " " + entry.GetProperty("uri").GetString(), owned);
        }
    }

    [Fact]
    public async Task SelectedDirectivesGenerateWithoutDerivedData()
    {
        var output = Path.Combine(Path.GetTempPath(), "mail-authored-directives", Guid.NewGuid().ToString("N"));
        try
        {
            var document = ReadSpec("openApiDocs_KiotaCompat");
            var selected = ReplyActions().Where(row => (bool)row[3]).ToArray();
            var paths = selected.Select(row => (string)row[0]).Append(FolderMessage + "/$value").ToHashSet(StringComparer.Ordinal);
            foreach (var path in document.Paths.Keys.Where(path => !paths.Contains(path)).ToArray())
                document.Paths.Remove(path);
            var content = (OpenApiPathItem)document.Paths[FolderMessage + "/$value"];
            content.Operations = new Dictionary<HttpMethod, OpenApiOperation>
            {
                [HttpMethod.Get] = content.Operations![HttpMethod.Get],
            };
            var config = Config with { OutputPath = output, UseCollisionData = false };
            await new PowerShellWrapperGenerationService(document, config, NullLogger.Instance, apiVersion: Profile)
                .GenerateAsync(CancellationToken.None);
            var expected = selected.Select(row => $"{row[1]}{row[2]}.g.cs").OrderBy(name => name);
            Assert.Equal(expected, Directory.GetFiles(output, "*.g.cs").Select(Path.GetFileName).OrderBy(name => name));
        }
        finally
        {
            if (Directory.Exists(output))
                Directory.Delete(output, recursive: true);
        }
    }

    [Fact]
    public void ParityDerivationDoesNotRecreateModuleOwnedEntries()
    {
        var output = Path.Combine(Path.GetTempPath(), "mail-parity-ownership", Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(output);
        try
        {
            var rows = new List<string> { "\"ApiVersion\",\"Command\",\"Method\",\"Uri\",\"Disposition\",\"OracleCommands\"" };
            foreach (var row in ReplyActions().Where(row => (bool)row[3]))
            {
                var path = Regex.Replace((string)row[0], @"\{[^}]*\}", "{param}");
                rows.Add($"\"v1.0\",\"Invoke-MgHistoricalName\",\"POST\",\"{path}\",\"mismatch\",\"{row[1]}-{row[2]}\"");
            }
            rows.Add("\"v1.0\",\"Get-MgUserMailFolderMessageContent\",\"GET\",\"/users/{param}/mailFolders/{param}/messages/{param}/$value\",\"no-oracle\",\"\"");
            rows.Add("\"v1.0\",\"Invoke-MgUserMessageReply\",\"POST\",\"/users/{param}/messages/{param}/reply\",\"mismatch\",\"Invoke-MgReplyUserMessage\"");
            rows.Add("\"v1.0\",\"Get-MgUnshippedNeighbor\",\"GET\",\"/unshippedNeighbor\",\"no-oracle\",\"\"");
            File.WriteAllLines(Path.Combine(output, "parity-input-ledger.v1.0.csv"), rows);
            var oracle = Path.Combine(output, "oracle.json");
            File.WriteAllText(oracle, """[{"ApiVersion":"v1.0","Command":"Invoke-MgReplyUserMessage"}]""");
            var start = new ProcessStartInfo("pwsh")
            {
                ArgumentList = { "-NoProfile", "-NonInteractive", "-File",
                    Path.Combine(RepoRoot.Value, "tools", "Derive-ParityResolutions.ps1"),
                    "-OutDir", output, "-OraclePath", oracle },
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
            };
            using var process = Process.Start(start) ?? throw new InvalidOperationException("Failed to start parity derivation.");
            var stdout = process.StandardOutput.ReadToEnd();
            var stderr = process.StandardError.ReadToEnd();
            process.WaitForExit();
            Assert.True(process.ExitCode == 0, stdout + stderr);
            using var renames = JsonDocument.Parse(File.ReadAllText(Path.Combine(output, "parity-renames.v1.0.json")));
            var rename = Assert.Single(renames.RootElement.EnumerateArray());
            Assert.Equal("/users/{}/messages/{}/reply", rename.GetProperty("uri").GetString());
            Assert.Equal("ReplyUserMessage", rename.GetProperty("replacementNoun").GetString());
            using var suppressions = JsonDocument.Parse(File.ReadAllText(Path.Combine(output, "parity-suppressions.v1.0.json")));
            Assert.Equal("/unshippedneighbor", Assert.Single(suppressions.RootElement.EnumerateArray()).GetProperty("uri").GetString());
            Assert.Equal(7, File.ReadLines(Path.Combine(output, "parity-resolution-ledger.v1.0.csv"))
                .Count(line => line.Contains("\"module-configuration\"", StringComparison.Ordinal)));
        }
        finally
        {
            Directory.Delete(output, recursive: true);
        }
    }

    [Fact]
    public void ExistingCuratedReplyToSuppressionRemainsIntact()
    {
        const string path = "/replies/{id}/replyTo";
        Assert.True(CmdletConfigurator.IsSuppressed(HttpMethod.Get, path, Config, apiVersion: Profile));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get, path + "/other", Config, apiVersion: Profile));
    }

    [Fact]
    public async Task GeneratedMailCommandsPassExplicitRuntimeProfileToAuthentication()
    {
        var output = Path.Combine(Path.GetTempPath(), "mail-directive-tests", Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(output);
        try
        {
            var service = new PowerShellWrapperGenerationService(
                Spec.Value, Config with { OutputPath = output }, NullLogger.Instance, apiVersion: Profile);
            await service.GenerateAsync(CancellationToken.None);

            foreach (var (path, verb, noun) in ReplyActions()
                .Select(row => ((string)row[0], (string)row[1], (string)row[2])))
            {
                var source = File.ReadAllText(Path.Combine(output, $"{verb}{noun}.g.cs"));
                Assert.Contains($"[GraphRoute(\"POST\", \"{path}\")]", source);
                Assert.Contains("GetRequestAdapter(\"v1.0\")", source);
                Assert.DoesNotContain("GetRequestAdapter()", source);
            }
            var item = File.ReadAllText(Path.Combine(output, "GetMgUserMessage_Get.g.cs"));
            Assert.Contains("GetRequestAdapter(\"v1.0\")", item);
            Assert.False(File.Exists(Path.Combine(output, "GetMgUserMailFolderMessageContent.g.cs")));

            var patches = Spec.Value.Paths
                .Where(path => path.Value.Operations!.ContainsKey(HttpMethod.Patch)).ToArray();
            Assert.Equal(12, patches.Length);
            foreach (var patch in patches)
            {
                var name = Naming.Resolve(new OperationInfo(HttpMethod.Patch, patch.Key), Config, apiVersion: Profile);
                var source = File.ReadAllText(Path.Combine(output, $"{name.VerbName}{name.Noun}.g.cs"));
                Assert.Contains($"[GraphRoute(\"PATCH\", \"{patch.Key}\")]", source);
                Assert.Contains(".PatchAsync(", source);
                Assert.DoesNotContain(".GetAsync(", source);
                Assert.DoesNotContain("re-fetching", source);
                Assert.DoesNotContain("if (result is null)", source);
                Assert.Contains("if (result is not null)", source);
            }
            var requiredQueries = Spec.Value.Paths.SelectMany(path =>
                (path.Value.Parameters ?? []).Concat(path.Value.Operations!.Values
                    .SelectMany(operation => operation.Parameters ?? [])))
                .Where(parameter => parameter.In == ParameterLocation.Query && parameter.Required);
            Assert.Empty(requiredQueries);
        }
        finally
        {
            Directory.Delete(output, recursive: true);
        }
    }

    private static OpenApiOperation SpecOperation(string method, string path)
    {
        Assert.True(Spec.Value.Paths.TryGetValue(path, out var item), $"Missing Mail v1.0 path: {path}");
        Assert.NotNull(item.Operations);
        Assert.True(item.Operations.TryGetValue(new HttpMethod(method), out var operation),
            $"Missing Mail v1.0 operation: {method} {path}");
        return operation;
    }

    private static OpenApiDocument ReadSpec(string specRoot)
    {
        var settings = new OpenApiReaderSettings();
        settings.AddYamlReader();
        using var stream = File.OpenRead(Path.Combine(RepoRoot.Value, specRoot, Profile, "Mail.yml"));
        var result = OpenApiDocument.LoadAsync(stream, settings: settings, cancellationToken: CancellationToken.None)
            .GetAwaiter().GetResult();
        return result.Document ?? throw new InvalidDataException($"Could not parse {specRoot} Mail {Profile} spec.");
    }

    private static string FindRepoRoot()
    {
        var directory = new DirectoryInfo(AppContext.BaseDirectory);
        while (directory is not null && !File.Exists(Path.Combine(directory.FullName, "src", "Mail", "Mail.md")))
            directory = directory.Parent;
        return directory?.FullName ?? throw new InvalidOperationException("Could not locate the Mail module.");
    }
}
