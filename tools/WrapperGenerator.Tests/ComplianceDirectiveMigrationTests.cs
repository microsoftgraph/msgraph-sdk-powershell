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

public sealed class ComplianceDirectiveMigrationTests
{
    private sealed record ReviewedOperation(string Method, string Path, string OperationId);

    private const string RetiredItem =
        "/compliance/ediscovery/cases/{case-id}/noncustodialDataSources/{noncustodialDataSource-id}";
    private const string RetiredNavigation = RetiredItem + "/dataSource";

    [Theory]
    [InlineData("v1.0", false)]
    [InlineData("v1.0", true)]
    [InlineData("beta", false)]
    [InlineData("beta", true)]
    public async Task CompatibleSpecAndReviewedLedgerAgreeOnRetiredCoverage(string profile, bool useCollisionData)
    {
        var root = FindRepoRoot();
        var document = await ReadSpecAsync("openApiDocs_KiotaCompat", profile);
        var path = Assert.Single(document.Paths);
        Assert.Equal("/compliance", path.Key);
        var operations = Assert.IsAssignableFrom<System.Collections.Generic.IDictionary<HttpMethod, OpenApiOperation>>(path.Value.Operations);
        Assert.Equal(2, operations.Count);
        Assert.Equal("compliance_GetCompliance", operations[HttpMethod.Get].OperationId);
        Assert.Equal("compliance_UpdateCompliance", operations[HttpMethod.Patch].OperationId);
        Assert.DoesNotContain(document.Paths.Keys, key => key.StartsWith("/compliance/ediscovery", StringComparison.Ordinal));

        using var ledger = JsonDocument.Parse(File.ReadAllText(
            Path.Combine(root, "src", "Compliance", "wrapper", "Compliance_directiveMigrationMap.json")));
        var mappings = ledger.RootElement.GetProperty("mappings").EnumerateArray().ToArray();
        Assert.Equal(2, mappings.Length);
        foreach (var mapping in mappings)
        {
            Assert.Contains(mapping.GetProperty("sourceContains").GetString()!,
                File.ReadAllText(Path.Combine(root, "src", "Compliance", "Compliance.md")));
            var evidence = mapping.GetProperty("profiles").GetProperty(profile);
            Assert.True(evidence.GetProperty("absenceExpected").GetBoolean());
            Assert.Empty(evidence.GetProperty("operations").EnumerateArray());
        }

        var config = new GeneratorConfig("Test.Client", "unused", useCollisionData);
        foreach (var operation in operations)
        {
            Assert.False(CmdletConfigurator.IsSuppressed(operation.Key, path.Key, config, apiVersion: profile));
            var naming = Naming.Resolve(new OperationInfo(operation.Key, path.Key), config, apiVersion: profile);
            Assert.Equal(operation.Key == HttpMethod.Get ? "Get" : "Update", naming.VerbName);
            Assert.Equal("MgCompliance", naming.Noun);
        }

        var output = Path.Combine(Path.GetTempPath(), "wrapper-generator-tests", Guid.NewGuid().ToString("N"));
        try
        {
            var service = new PowerShellWrapperGenerationService(document, config with { OutputPath = output },
                NullLogger.Instance, apiVersion: profile);
            await service.GenerateAsync(CancellationToken.None);
            Assert.Equal(new[] { "GetMgCompliance.g.cs", "UpdateMgCompliance.g.cs" },
                Directory.GetFiles(output, "*.g.cs").Select(Path.GetFileName).OrderBy(name => name).ToArray());
            Assert.Contains("[GraphRoute(\"GET\", \"/compliance\")]",
                File.ReadAllText(Path.Combine(output, "GetMgCompliance.g.cs")));
            var mutation = File.ReadAllText(Path.Combine(output, "UpdateMgCompliance.g.cs"));
            Assert.Contains("[GraphRoute(\"PATCH\", \"/compliance\")]", mutation);
            Assert.Contains("SupportsShouldProcess = true", mutation);
        }
        finally
        {
            if (Directory.Exists(output))
                Directory.Delete(output, recursive: true);
        }
    }

    [Theory]
    [InlineData("v1.0", false)]
    [InlineData("v1.0", true)]
    [InlineData("beta", false)]
    [InlineData("beta", true)]
    public void DormantSuppressionsPreserveSharedSemanticsWithoutSuppressingNeighbors(string profile, bool useCollisionData)
    {
        var config = new GeneratorConfig("Test.Client", "unused", useCollisionData);
        Assert.True(CmdletConfigurator.IsSuppressed(HttpMethod.Patch, RetiredNavigation, config, apiVersion: profile));
        Assert.True(CmdletConfigurator.IsSuppressed(HttpMethod.Delete, RetiredNavigation, config, apiVersion: profile));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get, RetiredNavigation, config, apiVersion: profile));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Patch, RetiredItem, config, apiVersion: profile));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Delete, RetiredItem, config, apiVersion: profile));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Patch, RetiredNavigation + "/neighbor", config, apiVersion: profile));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Delete, RetiredNavigation + "/neighbor", config, apiVersion: profile));
    }

    [Theory]
    [InlineData("v1.0", false)]
    [InlineData("v1.0", true)]
    [InlineData("beta", false)]
    [InlineData("beta", true)]
    public void RetiredGetHasStructuralRenameWithoutCuratedOverride(string profile, bool useCollisionData)
    {
        var config = new GeneratorConfig("Test.Client", "unused", useCollisionData);
        var naming = Naming.Resolve(new OperationInfo(HttpMethod.Get, RetiredNavigation), config, apiVersion: profile);
        Assert.Equal("Get", naming.VerbName);
        Assert.Equal("MgComplianceEdiscoveryCaseNoncustodialDataSourceDataSource", naming.Noun);
    }

    [Theory]
    [InlineData("v1.0", 0)]
    [InlineData("beta", 3)]
    public async Task CompleteOriginalSelectionHasNoCompatibleSurvivors(string profile, int selectedCount)
    {
        var original = await ReadSpecAsync("openApiDocs", profile);
        var compatible = await ReadSpecAsync("openApiDocs_KiotaCompat", profile);
        var originals = Operations(original);
        var selected = originals.Where(operation => Regex.IsMatch(operation.OperationId,
            @"^compliance\.ediscovery\.case\.noncustodialDataSource_(Get|Update|Delete)DataSource$")).ToArray();
        Assert.Equal(selectedCount, selected.Length);
        Assert.Equal(Sorted(selected), Sorted(originals.Where(operation => operation.Path == RetiredNavigation)));
        Assert.Empty(selected.Intersect(Operations(compatible)));

        using var ledger = JsonDocument.Parse(File.ReadAllText(Path.Combine(
            FindRepoRoot(), "src", "Compliance", "wrapper", "Compliance_directiveMigrationMap.json")));
        var sourceEvidence = ledger.RootElement.GetProperty("review")
            .GetProperty("originalSourceSelection").GetProperty(profile);
        var evidence = sourceEvidence.GetProperty("selectedOperations").EnumerateArray().ToArray();
        Assert.Equal(Sorted(selected), Sorted(evidence.Select(operation => new ReviewedOperation(
            operation.GetProperty("method").GetString()!, operation.GetProperty("path").GetString()!,
            operation.GetProperty("operationId").GetString()!))));
        Assert.Empty(sourceEvidence.GetProperty("survivingOperations").EnumerateArray());
        foreach (var operation in evidence)
            Assert.Equal(operation.GetProperty("method").GetString() == "GET" ? 2 : 1,
                operation.GetProperty("directiveIndex").GetInt32());

        foreach (var operation in selected)
        {
            Assert.True(original.Paths[operation.Path].Operations![new HttpMethod(operation.Method)].Deprecated);
            Assert.Equal(RetiredNavigation, operation.Path);
        }
        if (selectedCount > 0)
        {
            var neighbors = original.Paths[RetiredItem].Operations!;
            Assert.Equal(3, neighbors.Count);
            Assert.Equal("compliance.ediscovery.case_GetNoncustodialDataSource", neighbors[HttpMethod.Get].OperationId);
            Assert.Equal("compliance.ediscovery.case_UpdateNoncustodialDataSource", neighbors[HttpMethod.Patch].OperationId);
            Assert.Equal("compliance.ediscovery.case_DeleteNoncustodialDataSource", neighbors[HttpMethod.Delete].OperationId);
        }
        else
        {
            Assert.DoesNotContain(original.Paths.Keys, path => path.StartsWith("/compliance/ediscovery", StringComparison.Ordinal));
        }
    }

    private static ReviewedOperation[] Operations(OpenApiDocument document) =>
        document.Paths.SelectMany(path => path.Value.Operations!.Select(operation =>
            new ReviewedOperation(operation.Key.Method, path.Key, operation.Value.OperationId!))).ToArray();

    private static string[] Sorted(System.Collections.Generic.IEnumerable<ReviewedOperation> operations) =>
        operations.Select(operation => $"{operation.Method} {operation.Path} [{operation.OperationId}]")
            .OrderBy(operation => operation, StringComparer.Ordinal).ToArray();

    private static async Task<OpenApiDocument> ReadSpecAsync(string specRoot, string profile)
    {
        var settings = new OpenApiReaderSettings();
        settings.AddYamlReader();
        using var stream = File.OpenRead(Path.Combine(FindRepoRoot(), specRoot, profile, "Compliance.yml"));
        var result = await OpenApiDocument.LoadAsync(stream, settings: settings, cancellationToken: CancellationToken.None);
        return Assert.IsType<OpenApiDocument>(result.Document);
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
