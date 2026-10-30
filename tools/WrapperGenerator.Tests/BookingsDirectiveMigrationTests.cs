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

public sealed class BookingsDirectiveMigrationTests
{
    private sealed record ReviewedOperation(string Method, string Path, string OperationId);

    [Theory]
    [InlineData("v1.0", 209, 207)]
    [InlineData("beta", 309, 254)]
    public async Task ReviewedLedgerPinsCompleteCompatibleOperationEvidence(
        string profile, int operationCount, int renamedOperationCount)
    {
        var operations = await ReadOperationsAsync(profile);
        Assert.Equal(operationCount, operations.Length);
        using var ledger = ReadLedger();
        var mappings = ledger.RootElement.GetProperty("mappings").EnumerateArray().ToArray();
        Assert.Equal(3, mappings.Length);
        var source = File.ReadAllText(Path.Combine(FindRepoRoot(), "src", "Bookings", "Bookings.md"));
        foreach (var mapping in mappings)
        {
            Assert.Equal("Bookings", mapping.GetProperty("module").GetString());
            Assert.Contains(mapping.GetProperty("sourceContains").GetString()!, source);
            foreach (var operation in ReadEvidence(mapping, profile, "operations"))
                Assert.Contains(operation, operations);
        }

        var root = mappings.Single(m => m.GetProperty("directiveIndex").GetInt32() == 1);
        var rootProfile = root.GetProperty("profiles").GetProperty(profile);
        Assert.False(rootProfile.GetProperty("absenceExpected").GetBoolean());
        Assert.Equal(
            Sorted(operations.Where(o => Regex.IsMatch(o.OperationId, @"^solution\.solutionsRoot.*$")).ToArray()),
            Sorted(ReadEvidence(root, profile, "operations")));
        Assert.Equal(
            Sorted(operations.Where(o => o.Path == "/solutions").ToArray()),
            Sorted(ReadEvidence(root, profile, "operations")));
        var legacyOperations = await ReadOperationsAsync(profile, "openApiDocs");
        var originalMatches = legacyOperations.Where(o => Regex.IsMatch(o.OperationId, @"^solution\.solutionsRoot.*$")).ToArray();
        Assert.Equal(2, originalMatches.Length);
        Assert.Equal(Sorted(originalMatches), Sorted(ReadEvidence(root, profile, "operations")));
        foreach (var bridge in rootProfile.GetProperty("operations").EnumerateArray())
        {
            Assert.False(bridge.TryGetProperty("legacyPath", out _));
            Assert.False(bridge.TryGetProperty("legacyOperationId", out _));
        }

        var suppression = mappings.Single(m => m.GetProperty("directiveIndex").GetInt32() == 2);
        var suppressed = ReadEvidence(suppression, profile, "operations");
        Assert.Equal(3, suppressed.Length);
        Assert.Equal(
            Sorted(operations.Where(o => o.Path == "/solutions/virtualEvents").ToArray()),
            Sorted(suppressed));

        var rename = mappings.Single(m => m.GetProperty("directiveIndex").GetInt32() == 3);
        var renamed = ReadEvidence(rename, profile, "operations");
        Assert.Equal(renamedOperationCount, renamed.Length);
        Assert.Equal(
            Sorted(operations.Where(o => o.Path.StartsWith("/solutions/", StringComparison.Ordinal)).ToArray()),
            Sorted(renamed));
        Assert.DoesNotContain(operations, o => o.Path.StartsWith("/solutions/backupRestore", StringComparison.Ordinal));
    }

    [Theory]
    [InlineData("v1.0", false)]
    [InlineData("v1.0", true)]
    [InlineData("beta", false)]
    [InlineData("beta", true)]
    public void ExistingReviewedSuppressionsAndRenamesApplyWithOrWithoutDerivedData(
        string profile, bool useCollisionData)
    {
        var config = new GeneratorConfig("Test.Client", "unused", useCollisionData);
        using var ledger = ReadLedger();
        var mappings = ledger.RootElement.GetProperty("mappings").EnumerateArray().ToArray();
        foreach (var operation in ReadEvidence(mappings[0], profile, "operations")
            .Concat(ReadEvidence(mappings[1], profile, "operations")))
        {
            Assert.True(CmdletConfigurator.IsSuppressed(new HttpMethod(operation.Method), operation.Path, config, profile));
        }

        foreach (var operation in ReadEvidence(mappings[2], profile, "operations"))
        {
            var method = new HttpMethod(operation.Method);
            var naming = Naming.Resolve(new OperationInfo(method, operation.Path), config, profile);
            Assert.False(naming.Noun.StartsWith("MgSolution", StringComparison.Ordinal));
            if (!useCollisionData)
            {
                Assert.Equal("Probe", CmdletConfigurator.ApplyNounOverrides(method, operation.Path, "SolutionProbe", config, profile));
                Assert.Equal(operation.Path == "/solutions/virtualEvents",
                    CmdletConfigurator.IsSuppressed(method, operation.Path, config, profile));
            }
        }
    }

    [Theory]
    [InlineData("v1.0")]
    [InlineData("beta")]
    public async Task NeighboringRoutesRetainNamesAndAreNotSuppressed(string profile)
    {
        var operations = await ReadOperationsAsync(profile);
        var config = new GeneratorConfig("Test.Client", "unused");
        var expected = new[]
        {
            ("GET", "/solutions/bookingBusinesses/{bookingBusiness-id}", "solution_GetBookingBusiness", "MgBookingBusiness"),
            ("PATCH", "/solutions/bookingBusinesses/{bookingBusiness-id}", "solution_UpdateBookingBusiness", "MgBookingBusiness"),
            ("POST", "/solutions/bookingCurrencies", "solution_CreateBookingCurrency", "MgBookingCurrency"),
            ("GET", "/solutions/virtualEvents/events/{virtualEvent-id}", "solution.virtualEvent_GetEvent", "MgVirtualEvent"),
            ("PATCH", "/solutions/virtualEvents/events/{virtualEvent-id}", "solution.virtualEvent_UpdateEvent", "MgVirtualEvent"),
            ("DELETE", "/solutions/virtualEvents/events/{virtualEvent-id}", "solution.virtualEvent_DeleteEvent", "MgVirtualEvent"),
            ("GET", "/solutions/virtualEvents/webinars/{virtualEventWebinar-id}", "solution.virtualEvent_GetWebinar", "MgVirtualEventWebinar"),
        };
        foreach (var (method, path, operationId, noun) in expected)
        {
            Assert.Contains(new ReviewedOperation(method, path, operationId), operations);
            var httpMethod = new HttpMethod(method);
            Assert.False(CmdletConfigurator.IsSuppressed(httpMethod, path, config, profile));
            Assert.Equal(noun, Naming.Resolve(new OperationInfo(httpMethod, path), config, profile).Noun);
        }

        Assert.All(operations.Where(o =>
            Regex.IsMatch(o.Path, @"^/(bookingBusinesses|bookingCurrencies)(/|$)", RegexOptions.IgnoreCase)),
            operation => Assert.True(CmdletConfigurator.IsSuppressed(
                new HttpMethod(operation.Method), operation.Path, config, profile)));
    }

    [Theory]
    [InlineData("v1.0", false)]
    [InlineData("v1.0", true)]
    [InlineData("beta", false)]
    [InlineData("beta", true)]
    public void SolutionPrefixStripDoesNotRenameBackupRestore(string profile, bool useCollisionData)
    {
        var config = new GeneratorConfig("Test.Client", "unused", useCollisionData);
        foreach (var path in new[] { "/solutions/backupRestore", "/solutions/backupRestore/restorePoints" })
        {
            Assert.Equal("SolutionBackupRestore",
                CmdletConfigurator.ApplyNounOverrides(HttpMethod.Get, path, "SolutionBackupRestore", config, profile));
        }
        Assert.Equal("MgSolutionBackupRestore",
            Naming.Resolve(new OperationInfo(HttpMethod.Get, "/solutions/backupRestore"), config, profile).Noun);
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public async Task RetiredBetaCmdletsAreSuppressedWithoutRemovingSourceOrSolutionsSuccessors(bool useCollisionData)
    {
        var operations = await ReadOperationsAsync("beta");
        using var ledger = ReadLedger();
        Assert.False(ledger.RootElement.TryGetProperty("routeSelectionPolicy", out _));
        var policy = ledger.RootElement.GetProperty("retirementPolicy");
        Assert.Equal("beta", policy.GetProperty("profile").GetString());
        Assert.Equal("2024-04-30", policy.GetProperty("removalDate").GetString());
        Assert.Equal("Bookings_cmdletConfigurations.cs; shared exact-path SuppressOperation entries.",
            policy.GetProperty("implementation").GetString());
        var historical = await ReadOperationsAsync("beta", "openApiDocs");
        var retired = historical.Where(o =>
            Regex.IsMatch(o.Path, @"^/(bookingBusinesses|bookingCurrencies)(/|$)", RegexOptions.IgnoreCase)).ToArray();
        Assert.Equal(53, policy.GetProperty("suppressedOperations").GetInt32());
        Assert.Equal(policy.GetProperty("suppressedOperations").GetInt32(), retired.Length);
        Assert.Equal(29, policy.GetProperty("suppressedPaths").GetInt32());
        Assert.Equal(policy.GetProperty("suppressedPaths").GetInt32(), retired.Select(o => o.Path).Distinct().Count());
        var config = new GeneratorConfig("Test.Client", "unused", useCollisionData);
        foreach (var operation in retired)
        {
            var compatiblePath = operation.Method == "POST"
                ? Regex.Replace(operation.Path, @"/microsoft\.graph\.([^/]+)$", "/$1")
                : operation.Path;
            Assert.Contains(operations, current =>
                current.Method == operation.Method && current.Path == compatiblePath);
            Assert.True(CmdletConfigurator.IsSuppressed(new HttpMethod(operation.Method), operation.Path, config, "beta"));
            Assert.True(CmdletConfigurator.IsSuppressed(new HttpMethod(operation.Method), compatiblePath, config, "beta"));
            var successor = "/solutions" + compatiblePath;
            var supported = Assert.Single(operations, current => current.Method == operation.Method &&
                CmdletConfigurator.NormalizePathTemplate(current.Path) ==
                CmdletConfigurator.NormalizePathTemplate(successor));
            Assert.False(CmdletConfigurator.IsSuppressed(new HttpMethod(supported.Method), supported.Path, config, "beta"));
        }
    }

    [Theory]
    [InlineData("/bookingBusinesses", true)]
    [InlineData("/BOOKINGBUSINESSES/", true)]
    [InlineData("/bookingBusinesses/{renamed-id}/appointments/{id}/cancel", true)]
    [InlineData("/bookingCurrencies", true)]
    [InlineData("/BOOKINGCURRENCIES/", true)]
    [InlineData("/bookingCurrencies/{renamed-id}", true)]
    [InlineData("/bookingBusinessesArchive", false)]
    [InlineData("/bookingCurrencies-extra/child", false)]
    [InlineData("/other/bookingBusinesses", false)]
    [InlineData("/solutions/bookingBusinesses", false)]
    [InlineData("/solutions/bookingBusinesses/{id}/appointments", false)]
    [InlineData("/solutions/bookingCurrencies", false)]
    [InlineData("/solutions/bookingCurrencies/{id}", false)]
    public void SharedRetirementConfigurationMatchesCompleteRootSegmentsInEitherIngestingProfile(string path, bool retired)
    {
        foreach (var method in new[] { "GET", "POST", "PATCH", "DELETE", "PUT", "OPTIONS", "HEAD", "TRACE" })
        {
            var httpMethod = new HttpMethod(method);
            foreach (var useCollisionData in new[] { false, true })
            {
                var config = new GeneratorConfig("Test.Client", "unused", useCollisionData);
                foreach (var profile in new[] { "v1.0", "beta" })
                    Assert.Equal(retired, CmdletConfigurator.IsSuppressed(httpMethod, path, config, profile));
            }
            Assert.Equal(retired, CmdletConfigurator.IsSuppressed(httpMethod, path));
        }
    }

    private static JsonDocument ReadLedger() => JsonDocument.Parse(File.ReadAllText(
        Path.Combine(FindRepoRoot(), "src", "Bookings", "wrapper", "Bookings_directiveMigrationMap.json")));

    private static ReviewedOperation[] ReadEvidence(JsonElement mapping, string profile, string property) =>
        mapping.GetProperty("profiles").GetProperty(profile).GetProperty(property).EnumerateArray()
            .Select(o => new ReviewedOperation(
                o.GetProperty("method").GetString()!,
                o.GetProperty("path").GetString()!,
                o.GetProperty("operationId").GetString()!))
            .ToArray();

    private static ReviewedOperation[] Sorted(ReviewedOperation[] operations) =>
        operations.OrderBy(o => o.Path, StringComparer.Ordinal).ThenBy(o => o.Method, StringComparer.Ordinal).ToArray();

    private static async Task<ReviewedOperation[]> ReadOperationsAsync(string profile, string specRoot = "openApiDocs_KiotaCompat")
    {
        var settings = new OpenApiReaderSettings();
        settings.AddYamlReader();
        using var stream = File.OpenRead(
            Path.Combine(FindRepoRoot(), specRoot, profile, "Bookings.yml"));
        var result = await OpenApiDocument.LoadAsync(
            stream, settings: settings, cancellationToken: CancellationToken.None);
        Assert.NotNull(result.Document);
        return result.Document.Paths.SelectMany(path => path.Value.Operations!.Select(operation =>
            new ReviewedOperation(operation.Key.Method.ToUpperInvariant(), path.Key, operation.Value.OperationId!)))
            .ToArray();
    }

    private static string FindRepoRoot()
    {
        var directory = AppContext.BaseDirectory;
        while (directory is not null &&
            !File.Exists(Path.Combine(directory, "src", "Bookings", "Bookings.md")))
        {
            directory = Path.GetDirectoryName(directory);
        }
        return directory ?? throw new InvalidOperationException("Repository root not found from test base directory.");
    }
}
