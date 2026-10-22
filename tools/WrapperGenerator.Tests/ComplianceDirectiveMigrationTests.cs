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

public sealed class ComplianceDirectiveMigrationTests
{
    private const string RetiredItem =
        "/compliance/ediscovery/cases/{case-id}/noncustodialDataSources/{noncustodialDataSource-id}";
    private const string RetiredNavigation = RetiredItem + "/dataSource";

    [Theory]
    [InlineData("v1.0")]
    [InlineData("beta")]
    public async Task CompatibleSpecAndReviewedLedgerAgreeOnRetiredCoverage(string profile)
    {
        var root = FindRepoRoot();
        var settings = new OpenApiReaderSettings();
        settings.AddYamlReader();
        using var stream = File.OpenRead(Path.Combine(root, "openApiDocs_KiotaCompat", profile, "Compliance.yml"));
        var result = await OpenApiDocument.LoadAsync(stream, settings: settings, cancellationToken: CancellationToken.None);
        var document = Assert.IsType<OpenApiDocument>(result.Document);
        var path = Assert.Single(document.Paths);
        Assert.Equal("/compliance", path.Key);
        var operations = Assert.IsAssignableFrom<System.Collections.Generic.IDictionary<HttpMethod, OpenApiOperation>>(path.Value.Operations);
        Assert.Equal(2, operations.Count);
        Assert.Equal("compliance.compliance.GetCompliance", operations[HttpMethod.Get].OperationId);
        Assert.Equal("compliance.compliance.UpdateCompliance", operations[HttpMethod.Patch].OperationId);
        Assert.DoesNotContain(document.Paths.Keys, key => key.StartsWith("/compliance/ediscovery", StringComparison.Ordinal));

        using var ledger = JsonDocument.Parse(File.ReadAllText(
            Path.Combine(root, "src", "Compliance", "wrapper", "Compliance_directiveMigrationMap.json")));
        var mappings = ledger.RootElement.GetProperty("mappings").EnumerateArray().ToArray();
        Assert.Equal(2, mappings.Length);
        foreach (var mapping in mappings)
        {
            var evidence = mapping.GetProperty("profiles").GetProperty(profile);
            Assert.True(evidence.GetProperty("absenceExpected").GetBoolean());
            Assert.Empty(evidence.GetProperty("operations").EnumerateArray());
        }

        foreach (var operation in operations)
        {
            Assert.False(CmdletConfigurator.IsSuppressed(operation.Key, path.Key));
            var naming = Naming.Resolve(new OperationInfo(operation.Key, path.Key));
            Assert.Equal(operation.Key == HttpMethod.Get ? "Get" : "Update", naming.VerbName);
            Assert.Equal("MgCompliance", naming.Noun);
        }
    }

    [Fact]
    public void DormantSuppressionsPreserveSharedSemanticsWithoutSuppressingNeighbors()
    {
        Assert.True(CmdletConfigurator.IsSuppressed(HttpMethod.Patch, RetiredNavigation));
        Assert.True(CmdletConfigurator.IsSuppressed(HttpMethod.Delete, RetiredNavigation));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get, RetiredNavigation));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Patch, RetiredItem));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Delete, RetiredItem));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Patch, RetiredNavigation + "/neighbor"));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Delete, RetiredNavigation + "/neighbor"));
    }

    [Fact]
    public void RetiredGetHasStructuralRenameWithoutCuratedOverride()
    {
        var naming = Naming.Resolve(new OperationInfo(HttpMethod.Get, RetiredNavigation));
        Assert.Equal("Get", naming.VerbName);
        Assert.Equal("MgComplianceEdiscoveryCaseNoncustodialDataSourceDataSource", naming.Noun);
    }

    private static string FindRepoRoot()
    {
        var directory = new DirectoryInfo(AppContext.BaseDirectory);
        while (directory is not null && !File.Exists(Path.Combine(directory.FullName, ".git")) &&
               !Directory.Exists(Path.Combine(directory.FullName, ".git")))
            directory = directory.Parent;
        return directory?.FullName ?? throw new InvalidOperationException("Could not locate repository root.");
    }
}
