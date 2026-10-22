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

public sealed class ReportsDirectiveMigrationTests
{
    private const string LegacySuppression =
        @"auditLog\.auditLogRoot.*|report.reportRoot.*|(auditLog|report)_(Create|Delete|Update).*";
    private const string FailureArguments = "(skip={skip},top={top},filter='{filter}',skipToken='{skipToken}')";

    private sealed record FunctionCase(string Path, string OperationId, string Noun);

    private static readonly string RepoRoot = FindRepoRoot();
    private static readonly Dictionary<string, Lazy<OpenApiDocument>> Specs = new()
    {
        ["v1.0"] = new(() => ReadSpec("openApiDocs_KiotaCompat", "v1.0")),
        ["beta"] = new(() => ReadSpec("openApiDocs_KiotaCompat", "beta")),
    };

    [Theory]
    [InlineData("v1.0", false, 34, 0)]
    [InlineData("v1.0", true, 34, 0)]
    [InlineData("beta", false, 66, 18)]
    [InlineData("beta", true, 66, 18)]
    public void SuppressionAccountsForEveryActualLegacyMatch(
        string profile, bool useCollisionData, int survivorCount, int removedCount)
    {
        var current = Specs[profile].Value;
        var legacy = ReadSpec("openApiDocs", profile);
        var mapping = Mapping(2).GetProperty("profiles").GetProperty(profile);
        Assert.Equal("Legacy", mapping.GetProperty("operationIdSource").GetString());
        Assert.False(mapping.GetProperty("absenceExpected").GetBoolean());
        var config = new GeneratorConfig("Test.Client", "unused", profile, useCollisionData);
        var accounted = new HashSet<string>(StringComparer.Ordinal);
        var survivors = mapping.GetProperty("operations").EnumerateArray().ToArray();
        var removed = mapping.GetProperty("removedLegacyOperations").EnumerateArray().ToArray();
        Assert.Equal(survivorCount, survivors.Length);
        Assert.Equal(removedCount, removed.Length);

        foreach (var entry in survivors)
        {
            var method = new HttpMethod(Text(entry, "method"));
            var path = Text(entry, "path");
            var legacyPath = Text(entry, "legacyPath");
            var legacyId = Text(entry, "legacyOperationId");
            Assert.Equal(Text(entry, "operationId"), current.Paths[path].Operations![method].OperationId);
            Assert.Equal(legacyId, legacy.Paths[legacyPath].Operations![method].OperationId);
            Assert.Matches(LegacySuppression, legacyId);
            Assert.Equal(CmdletConfigurator.NormalizePathTemplate(legacyPath), CmdletConfigurator.NormalizePathTemplate(path));
            Assert.True(accounted.Add($"{method} {legacyPath} {legacyId}"));
            Assert.True(CmdletConfigurator.IsSuppressed(method, path, config), $"{profile}: {method} {path}");
        }

        foreach (var entry in removed)
        {
            var method = new HttpMethod(Text(entry, "method"));
            var path = Text(entry, "path");
            var operationId = Text(entry, "operationId");
            Assert.Equal(operationId, legacy.Paths[path].Operations![method].OperationId);
            Assert.Matches(LegacySuppression, operationId);
            Assert.False(string.IsNullOrWhiteSpace(Text(entry, "notes")));
            Assert.DoesNotContain(current.Paths, candidate =>
                CmdletConfigurator.NormalizePathTemplate(candidate.Key) == CmdletConfigurator.NormalizePathTemplate(path)
                && candidate.Value.Operations!.ContainsKey(method));
            Assert.True(accounted.Add($"{method} {path} {operationId}"));
        }

        var expected = legacy.Paths.SelectMany(path => path.Value.Operations!
            .Where(operation => Regex.IsMatch(operation.Value.OperationId!, LegacySuppression))
            .Select(operation => $"{operation.Key} {path.Key} {operation.Value.OperationId}"));
        Assert.True(accounted.SetEquals(expected), "The ledger must account for the complete source regex set.");
    }

    [Theory]
    [InlineData("v1.0", false)]
    [InlineData("v1.0", true)]
    [InlineData("beta", false)]
    [InlineData("beta", true)]
    public void NeighboringReadsNestedMutationsAndReportsOwnedActionsRemain(string profile, bool useCollisionData)
    {
        var spec = Specs[profile].Value;
        var config = new GeneratorConfig("Test.Client", "unused", profile, useCollisionData);
        (HttpMethod Method, string Path)[] neighbors =
        [
            (HttpMethod.Get, "/deviceManagement/reports"),
            (HttpMethod.Get, "/deviceManagement/reports/exportJobs"),
            (HttpMethod.Get, "/deviceManagement/reports/exportJobs/{deviceManagementExportJob-id}"),
            (HttpMethod.Post, "/deviceManagement/reports/getCachedReport"),
            (HttpMethod.Post, "/deviceManagement/reports/retrieveDeviceAppInstallationStatusReport"),
            (HttpMethod.Get, "/reports/authenticationMethods/userRegistrationDetails"),
            (HttpMethod.Post, "/reports/authenticationMethods/userRegistrationDetails"),
            (HttpMethod.Patch, "/reports/authenticationMethods/userRegistrationDetails/{userRegistrationDetails-id}"),
            (HttpMethod.Delete, "/reports/authenticationMethods/userRegistrationDetails/{userRegistrationDetails-id}"),
        ];
        if (profile == "beta")
        {
            neighbors =
            [
                .. neighbors,
                (HttpMethod.Post, "/deviceManagement/reports/getCertificatesReport"),
                (HttpMethod.Post, "/auditLogs/auditActivityTypes"),
                (HttpMethod.Patch, "/reports/azureADPremiumLicenseInsight"),
                (HttpMethod.Delete, "/reports/correlations/{identityCorrelation-id}"),
                (HttpMethod.Get, "/reports/applicationSignInDetailedSummary"),
                (HttpMethod.Get, "/reports/applicationSignInDetailedSummary/{applicationSignInDetailedSummary-id}"),
                (HttpMethod.Get, "/reports/applicationSignInDetailedSummary/$count"),
            ];
        }
        foreach (var (method, path) in neighbors)
        {
            Assert.True(spec.Paths[path].Operations!.ContainsKey(method), $"Missing neighbor: {profile} {method} {path}");
            Assert.False(CmdletConfigurator.IsSuppressed(method, path, config), $"Suppressed neighbor: {profile} {method} {path}");
        }
    }

    [Theory]
    [InlineData("v1.0", false)]
    [InlineData("v1.0", true)]
    [InlineData("beta", false)]
    [InlineData("beta", true)]
    public void SharedFunctionNamesRetainTheirOwnedRoutes(string profile, bool useCollisionData)
    {
        var config = new GeneratorConfig("Test.Client", "unused", profile, useCollisionData);
        foreach (var item in FunctionCases(profile))
        {
            var operation = Specs[profile].Value.Paths[item.Path].Operations![HttpMethod.Get];
            Assert.Equal(item.OperationId, operation.OperationId);
            var extension = Assert.IsType<JsonNodeExtension>(operation.Extensions!["x-ms-docs-operation-type"]);
            Assert.Equal("function", extension.Node!.ToString().Trim('"'));
            var naming = Naming.Resolve(new OperationInfo(HttpMethod.Get, item.Path, Kind: OperationKind.Function), config);
            Assert.Equal("Get", naming.VerbName);
            Assert.Equal("Mg" + item.Noun, naming.Noun);
            Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get, item.Path, config));
        }
    }

    [Theory]
    [InlineData("v1.0", false)]
    [InlineData("v1.0", true)]
    [InlineData("beta", false)]
    [InlineData("beta", true)]
    public async Task TargetedRealSpecFunctionsGenerateWithoutOverloadCollisions(string profile, bool useCollisionData)
    {
        var cases = FunctionCases(profile).ToArray();
        var source = Specs[profile].Value;
        var target = new OpenApiDocument { Paths = new OpenApiPaths(), Components = source.Components };
        foreach (var item in cases)
            target.Paths.Add(item.Path, source.Paths[item.Path]);
        target.Paths.Add("/auditLogs", source.Paths["/auditLogs"]);
        target.Paths.Add("/reports", source.Paths["/reports"]);
        var output = Path.Combine(Path.GetTempPath(), "reports-directive-tests", Guid.NewGuid().ToString("N"));
        try
        {
            var config = new GeneratorConfig("Test.Client", output, profile, useCollisionData);
            await new PowerShellWrapperGenerationService(target, config, NullLogger.Instance)
                .GenerateAsync(CancellationToken.None);
            var expected = cases.Select(item => "GetMg" + item.Noun + ".g.cs").OrderBy(name => name).ToArray();
            var files = Directory.GetFiles(output, "*.g.cs").Select(Path.GetFileName).OrderBy(name => name).ToArray();
            Assert.Equal(expected, files);
            foreach (var item in cases)
            {
                var code = File.ReadAllText(Path.Combine(output, "GetMg" + item.Noun + ".g.cs"));
                Assert.Contains(item.Path, code, StringComparison.Ordinal);
            }
        }
        finally
        {
            if (Directory.Exists(output))
                Directory.Delete(output, recursive: true);
        }
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void ApplicationSummaryRenameKeepsStructuralGetAndCountNames(bool useCollisionData)
    {
        var config = new GeneratorConfig("Test.Client", "unused", "beta", useCollisionData);
        foreach (var suffix in new[] { "", "/{applicationSignInDetailedSummary-id}", "/$count" })
        {
            var path = "/reports/applicationSignInDetailedSummary" + suffix;
            var operation = Specs["beta"].Value.Paths[path].Operations![HttpMethod.Get];
            Assert.NotNull(operation.OperationId);
            Assert.Equal("MgReportApplicationSignInDetailedSummary" + (suffix == "/$count" ? "Count" : ""),
                Naming.Resolve(new OperationInfo(HttpMethod.Get, path), config).Noun);
        }
    }

    private static IEnumerable<FunctionCase> FunctionCases(string profile)
    {
        yield return new("/reports/deviceConfigurationDeviceActivity()", "reports.deviceConfigurationDeviceActivity", "ReportDeviceConfigurationDeviceActivity");
        yield return new("/reports/deviceConfigurationUserActivity()", "reports.deviceConfigurationUserActivity", "ReportDeviceConfigurationUserActivity");
        yield return new("/reports/managedDeviceEnrollmentTopFailures()", "reports.managedDeviceEnrollmentTopFailures-9ce7", "ReportManagedDeviceEnrollmentTopFailure");
        yield return new("/reports/managedDeviceEnrollmentTopFailures(period='{period}')", "reports.managedDeviceEnrollmentTopFailures-2157", "ReportManagedDeviceEnrollmentTopFailureWithPeriod");
        yield return new("/reports/managedDeviceEnrollmentFailureDetails()", "reports.managedDeviceEnrollmentFailureDetails-8191", "ReportManagedDeviceEnrollmentFailureDetail");
        yield return new("/reports/managedDeviceEnrollmentFailureDetails" + FailureArguments, "reports.managedDeviceEnrollmentFailureDetails-aa46", "ReportManagedDeviceEnrollmentFailureDetailWithSkipWithTopWithFilterWithSkipToken");
        if (profile != "beta")
            yield break;
        yield return new("/reports/managedDeviceEnrollmentAbandonmentDetails" + FailureArguments, "reports.managedDeviceEnrollmentAbandonmentDetails", "ReportManagedDeviceEnrollmentAbandonmentDetail");
        yield return new("/reports/managedDeviceEnrollmentAbandonmentSummary" + FailureArguments, "reports.managedDeviceEnrollmentAbandonmentSummary", "ReportManagedDeviceEnrollmentAbandonmentSummary");
        yield return new("/reports/managedDeviceEnrollmentFailureTrends()", "reports.managedDeviceEnrollmentFailureTrends", "ReportManagedDeviceEnrollmentFailureTrend");
        yield return new("/reports/getAzureADApplicationSignInSummary(period='{period}')", "reports.getAzureADApplicationSignInSummary", "ReportAzureAdApplicationSignInSummary");
    }

    private static JsonElement Mapping(int index)
    {
        using var document = JsonDocument.Parse(File.ReadAllText(Path.Combine(
            RepoRoot, "src", "Reports", "wrapper", "Reports_directiveMigrationMap.json")));
        return document.RootElement.GetProperty("mappings").EnumerateArray()
            .Single(entry => entry.GetProperty("directiveIndex").GetInt32() == index).Clone();
    }

    private static string Text(JsonElement entry, string name) => entry.GetProperty(name).GetString()!;

    private static OpenApiDocument ReadSpec(string directory, string profile)
    {
        var settings = new OpenApiReaderSettings();
        settings.AddYamlReader();
        using var stream = File.OpenRead(Path.Combine(RepoRoot, directory, profile, "Reports.yml"));
        return OpenApiDocument.LoadAsync(stream, settings: settings, cancellationToken: CancellationToken.None)
            .GetAwaiter().GetResult().Document!;
    }

    private static string FindRepoRoot()
    {
        var directory = AppContext.BaseDirectory;
        while (directory is not null && !File.Exists(Path.Combine(directory, "src", "Reports", "Reports.md")))
            directory = Path.GetDirectoryName(directory);
        return directory ?? throw new InvalidOperationException("Repository root not found.");
    }
}
