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
        Assert.True(root.GetProperty("profiles").GetProperty(profile).GetProperty("absenceExpected").GetBoolean());
        Assert.Empty(ReadEvidence(root, profile, "operations"));
        Assert.DoesNotContain(operations, o => Regex.IsMatch(o.OperationId, @"^solution\.solutionsRoot.*$"));
        Assert.Equal(
            Sorted(operations.Where(o => o.Path == "/solutions").ToArray()),
            Sorted(ReadEvidence(root, profile, "compatibilityOperations")));

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
        var config = new GeneratorConfig("Test.Client", "unused", profile, useCollisionData);
        using var ledger = ReadLedger();
        var mappings = ledger.RootElement.GetProperty("mappings").EnumerateArray().ToArray();
        foreach (var operation in ReadEvidence(mappings[0], profile, "compatibilityOperations")
            .Concat(ReadEvidence(mappings[1], profile, "operations")))
        {
            Assert.True(CmdletConfigurator.IsSuppressed(new HttpMethod(operation.Method), operation.Path, config));
        }

        foreach (var operation in ReadEvidence(mappings[2], profile, "operations"))
        {
            var method = new HttpMethod(operation.Method);
            var naming = Naming.Resolve(new OperationInfo(method, operation.Path), config);
            Assert.False(naming.Noun.StartsWith("MgSolution", StringComparison.Ordinal));
            if (!useCollisionData)
            {
                Assert.Equal("Probe", CmdletConfigurator.ApplyNounOverrides(method, operation.Path, "SolutionProbe", config));
                Assert.Equal(operation.Path == "/solutions/virtualEvents",
                    CmdletConfigurator.IsSuppressed(method, operation.Path, config));
            }
        }
    }

    [Theory]
    [InlineData("v1.0")]
    [InlineData("beta")]
    public async Task NeighboringRoutesRetainNamesAndAreNotSuppressed(string profile)
    {
        var operations = await ReadOperationsAsync(profile);
        var config = new GeneratorConfig("Test.Client", "unused", profile);
        var expected = new[]
        {
            ("GET", "/solutions/bookingBusinesses/{bookingBusiness-id}", "solutions.GetBookingBusinesses", "MgBookingBusiness"),
            ("PATCH", "/solutions/bookingBusinesses/{bookingBusiness-id}", "solutions.UpdateBookingBusinesses", "MgBookingBusiness"),
            ("POST", "/solutions/bookingCurrencies", "solutions.CreateBookingCurrencies", "MgBookingCurrency"),
            ("GET", "/solutions/virtualEvents/events/{virtualEvent-id}", "solutions.virtualEvents.GetEvents", "MgVirtualEvent"),
            ("PATCH", "/solutions/virtualEvents/events/{virtualEvent-id}", "solutions.virtualEvents.UpdateEvents", "MgVirtualEvent"),
            ("DELETE", "/solutions/virtualEvents/events/{virtualEvent-id}", "solutions.virtualEvents.DeleteEvents", "MgVirtualEvent"),
            ("GET", "/solutions/virtualEvents/webinars/{virtualEventWebinar-id}", "solutions.virtualEvents.GetWebinars", "MgVirtualEventWebinar"),
        };
        foreach (var (method, path, operationId, noun) in expected)
        {
            Assert.Contains(new ReviewedOperation(method, path, operationId), operations);
            var httpMethod = new HttpMethod(method);
            Assert.False(CmdletConfigurator.IsSuppressed(httpMethod, path, config));
            Assert.Equal(noun, Naming.Resolve(new OperationInfo(httpMethod, path), config).Noun);
        }

        if (profile == "beta")
        {
            var topLevel = operations.Where(o => !o.Path.StartsWith("/solutions", StringComparison.Ordinal)).ToArray();
            Assert.Equal(53, topLevel.Length);
            foreach (var operation in topLevel)
            {
                var method = new HttpMethod(operation.Method);
                Assert.False(CmdletConfigurator.IsSuppressed(method, operation.Path, config));
                Assert.Equal("SolutionProbe",
                    CmdletConfigurator.ApplyNounOverrides(method, operation.Path, "SolutionProbe", config));
            }
            Assert.Equal("MgBookingBusiness",
                Naming.Resolve(new OperationInfo(HttpMethod.Get, "/bookingBusinesses/{bookingBusiness-id}"), config).Noun);
        }
    }

    [Theory]
    [InlineData("v1.0", false)]
    [InlineData("v1.0", true)]
    [InlineData("beta", false)]
    [InlineData("beta", true)]
    public void SolutionPrefixStripDoesNotRenameBackupRestore(string profile, bool useCollisionData)
    {
        var config = new GeneratorConfig("Test.Client", "unused", profile, useCollisionData);
        foreach (var path in new[] { "/solutions/backupRestore", "/solutions/backupRestore/restorePoints" })
        {
            Assert.Equal("SolutionBackupRestore",
                CmdletConfigurator.ApplyNounOverrides(HttpMethod.Get, path, "SolutionBackupRestore", config));
        }
        Assert.Equal("MgSolutionBackupRestore",
            Naming.Resolve(new OperationInfo(HttpMethod.Get, "/solutions/backupRestore"), config).Noun);
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

    private static async Task<ReviewedOperation[]> ReadOperationsAsync(string profile)
    {
        var settings = new OpenApiReaderSettings();
        settings.AddYamlReader();
        using var stream = File.OpenRead(
            Path.Combine(FindRepoRoot(), "openApiDocs_KiotaCompat", profile, "Bookings.yml"));
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
