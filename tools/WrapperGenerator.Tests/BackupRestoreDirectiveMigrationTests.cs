using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Reader;
using WrapperGenerator;
using Xunit;

namespace WrapperGenerator.Tests;

public sealed class BackupRestoreDirectiveMigrationTests
{
    [Fact]
    public void AuditHasNoInventedDirectivesOrMappings()
    {
        var root = FindRepoRoot();
        var audit = File.ReadAllText(Path.Combine(root, "src", "BackupRestore", "BackupRestore.md"));
        Assert.DoesNotMatch(@"(?m)^\s*directive:\s*$", audit);

        using var ledger = JsonDocument.Parse(File.ReadAllText(Path.Combine(root, "src",
            "BackupRestore", "wrapper", "BackupRestore_directiveMigrationMap.json")));
        Assert.Empty(ledger.RootElement.GetProperty("mappings").EnumerateArray());
    }

    [Theory]
    [InlineData("v1.0", 150, 247)]
    [InlineData("beta", 194, 314)]
    public async Task EveryRealSpecOperationRetainsCuratedAndDerivedDecisions(
        string profile, int expectedPaths, int expectedOperations)
    {
        var document = await LoadSpecAsync(profile);
        Assert.Equal(expectedPaths, document.Paths.Count);
        Assert.Equal(expectedOperations, document.Paths.Values.Sum(path => path.Operations!.Count));

        foreach (var path in document.Paths)
        {
            Assert.StartsWith("/solutions/backupRestore", path.Key);
            foreach (var operation in path.Value.Operations!)
            {
                Assert.False(string.IsNullOrWhiteSpace(operation.Value.OperationId),
                    $"{profile}: {operation.Key} {path.Key} must retain operation-ID evidence.");
                var normalized = CmdletConfigurator.NormalizePathTemplate(path.Key);
                const string structuralNoun = "SolutionBackupRestoreAuditProbe";

                foreach (var useDerivedData in new[] { false, true })
                {
                    var config = new GeneratorConfig("Test.Client", "unused", profile, useDerivedData);
                    var expectedSuppression = useDerivedData &&
                        DerivedCollisionResolutions.IsSuppressed(profile, operation.Key, normalized);
                    var hasDerivedName = DerivedCollisionResolutions.TryReplaceName(
                        profile, operation.Key, normalized, out var derivedName) && useDerivedData;

                    Assert.Equal(expectedSuppression,
                        CmdletConfigurator.IsSuppressed(operation.Key, path.Key, config));
                    Assert.Equal(hasDerivedName ? derivedName.Verb : null,
                        CmdletConfigurator.TryGetOverriddenVerb(operation.Key, path.Key, config));
                    Assert.Equal(hasDerivedName ? derivedName.Noun : structuralNoun,
                        CmdletConfigurator.ApplyNounOverrides(operation.Key, path.Key, structuralNoun, config));
                }
            }
        }
    }

    [Theory]
    [InlineData("v1.0", false)]
    [InlineData("v1.0", true)]
    [InlineData("beta", false)]
    [InlineData("beta", true)]
    public async Task RealResourceNeighborsKeepSolutionPrefix(string profile, bool useDerivedData)
    {
        var document = await LoadSpecAsync(profile);
        var config = new GeneratorConfig("Test.Client", "unused", profile, useDerivedData);
        var cases = new[]
        {
            ("GET", "/solutions/backupRestore", "solutions.GetBackupRestore",
                "Get", "MgSolutionBackupRestore"),
            ("PATCH", "/solutions/backupRestore", "solutions.UpdateBackupRestore",
                "Update", "MgSolutionBackupRestore"),
            ("DELETE", "/solutions/backupRestore", "solutions.DeleteBackupRestore",
                "Remove", "MgSolutionBackupRestore"),
            ("GET", "/solutions/backupRestore/protectionPolicies",
                "solutions.backupRestore.ListProtectionPolicies", "Get", "MgSolutionBackupRestoreProtectionPolicy"),
            ("GET", "/solutions/backupRestore/protectionPolicies/{protectionPolicyBase-id}",
                "solutions.backupRestore.GetProtectionPolicies", "Get", "MgSolutionBackupRestoreProtectionPolicy"),
            ("GET", "/solutions/backupRestore/serviceApps",
                "solutions.backupRestore.ListServiceApps", "Get", "MgSolutionBackupRestoreServiceApp"),
            ("POST", "/solutions/backupRestore/serviceApps",
                "solutions.backupRestore.CreateServiceApps", "New", "MgSolutionBackupRestoreServiceApp"),
            ("GET", "/solutions/backupRestore/exchangeProtectionPolicies/{exchangeProtectionPolicy-id}/mailboxProtectionUnits",
                "solutions.backupRestore.exchangeProtectionPolicies.ListMailboxProtectionUnits",
                "Get", "MgSolutionBackupRestoreExchangeProtectionPolicyMailboxProtectionUnit"),
        };

        foreach (var (method, path, operationId, verb, noun) in cases)
        {
            var httpMethod = new HttpMethod(method);
            AssertOperation(document, httpMethod, path, operationId);
            Assert.False(CmdletConfigurator.IsSuppressed(httpMethod, path, config));
            var naming = Naming.Resolve(new OperationInfo(httpMethod, path), config);
            Assert.Equal(verb, naming.VerbName);
            Assert.Equal(noun, naming.Noun);
        }
    }

    [Theory]
    [InlineData("v1.0", "Enable", "MgSolutionBackupRestore")]
    [InlineData("beta", "Invoke", "MgSolutionBackupRestoreEnable")]
    public async Task ExistingActionRenameAndFunctionNeighborRemainUnchanged(
        string profile, string expectedVerb, string expectedNoun)
    {
        var document = await LoadSpecAsync(profile);
        var config = new GeneratorConfig("Test.Client", "unused", profile);
        const string enablePath = "/solutions/backupRestore/enable";
        AssertOperation(document, HttpMethod.Post, enablePath, "solutions.backupRestore.enable");
        var naming = Naming.Resolve(new OperationInfo(HttpMethod.Post, enablePath,
            Kind: OperationKind.Action), config);
        Assert.Equal(expectedVerb, naming.VerbName);
        Assert.Equal(expectedNoun, naming.Noun);
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Post, enablePath, config));

        const string browsePath = "/solutions/backupRestore/browseSessions/{browseSessionBase-id}/browse";
        const string functionPath = browsePath + "(nextFetchToken='{nextFetchToken}')";
        AssertOperation(document, HttpMethod.Get, functionPath,
            "solutions.backupRestore.browseSessions.browseSessionBase.browse-ae5b");
        // The existing v1.0 suppression key retains the named function placeholder;
        // NormalizePathTemplate erases it. Preserve and document that baseline discrepancy.
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get, functionPath, config));
        AssertOperation(document, HttpMethod.Post, browsePath,
            "solutions.backupRestore.browseSessions.browseSessionBase.browse");
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Post, browsePath, config));
        const string itemPath = "/solutions/backupRestore/browseSessions/{browseSessionBase-id}";
        AssertOperation(document, HttpMethod.Get, itemPath, "solutions.backupRestore.GetBrowseSessions");
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get, itemPath, config));
        Assert.Equal("MgSolutionBackupRestoreBrowseSession",
            Naming.Resolve(new OperationInfo(HttpMethod.Get, itemPath), config).Noun);
    }

    private static void AssertOperation(OpenApiDocument document, HttpMethod method, string path, string operationId)
    {
        Assert.True(document.Paths.TryGetValue(path, out var item), $"Missing real-spec route: {method} {path}");
        Assert.NotNull(item.Operations);
        Assert.True(item.Operations.TryGetValue(method, out var operation), $"Missing real-spec method: {method} {path}");
        Assert.Equal(operationId, operation.OperationId);
    }

    private static async Task<OpenApiDocument> LoadSpecAsync(string profile)
    {
        var path = Path.Combine(FindRepoRoot(), "openApiDocs_KiotaCompat", profile, "BackupRestore.yml");
        using var stream = File.OpenRead(path);
        var settings = new OpenApiReaderSettings();
        settings.AddYamlReader();
        var result = await OpenApiDocument.LoadAsync(stream, settings: settings, cancellationToken: CancellationToken.None);
        Assert.NotNull(result.Document);
        return result.Document;
    }

    private static string FindRepoRoot()
    {
        var dir = new DirectoryInfo(AppContext.BaseDirectory);
        while (dir is not null
            && !Directory.Exists(Path.Combine(dir.FullName, ".git"))
            && !File.Exists(Path.Combine(dir.FullName, ".git")))
            dir = dir.Parent;
        return dir?.FullName ?? throw new InvalidOperationException("Could not locate repository root.");
    }
}
