using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Reader;
using WrapperGenerator;
using Xunit;

namespace WrapperGenerator.Tests;

public sealed class DevicesCloudPrintDirectiveMigrationTests
{
    [Theory]
    [InlineData("v1.0", "openApiDocs")]
    [InlineData("beta", "openApiDocs")]
    [InlineData("v1.0", "openApiDocs_KiotaCompat")]
    [InlineData("beta", "openApiDocs_KiotaCompat")]
    public void ReportSelectorHasReviewedAbsenceInLegacyAndCompatibleSpecs(string profile, string specRoot)
    {
        var document = LoadSpec(profile, specRoot);
        var selector = new Regex(@"^print(_.*Report|\.report.*)", RegexOptions.CultureInvariant);
        var operationCount = 0;
        foreach (var path in document.Paths)
        {
            Assert.NotNull(path.Value.Operations);
            foreach (var operation in path.Value.Operations.Values)
            {
                Assert.False(string.IsNullOrWhiteSpace(operation.OperationId));
                Assert.DoesNotMatch(selector, operation.OperationId!);
                operationCount++;
            }
        }
        Assert.True(operationCount > 0, "Absence must be reviewed against a nonempty spec.");
    }

    [Theory]
    [InlineData("v1.0")]
    [InlineData("beta")]
    public void ReviewedPrinterCreationEvidenceMatchesOriginalAndCompatibleSpecs(string profile)
    {
        using var ledger = JsonDocument.Parse(File.ReadAllText(Path.Combine(FindRepoRoot(),
            "src", "Devices.CloudPrint", "wrapper", "Devices.CloudPrint_directiveMigrationMap.json")));
        var mapping = ledger.RootElement.GetProperty("mappings").EnumerateArray()
            .Single(row => row.GetProperty("directiveIndex").GetInt32() == 2);
        var evidence = mapping.GetProperty("profiles").GetProperty(profile).GetProperty("operations")
            .EnumerateArray().Select(row =>
                $"{row.GetProperty("method").GetString()} {row.GetProperty("path").GetString()} [{row.GetProperty("operationId").GetString()}]")
            .ToArray();
        Assert.Equal(["POST /print/printers [print_CreatePrinter]"], evidence);
        foreach (var specRoot in new[] { "openApiDocs", "openApiDocs_KiotaCompat" })
        {
            var document = LoadSpec(profile, specRoot);
            var selected = document.Paths.SelectMany(path => path.Value.Operations!
                .Where(operation => operation.Value.OperationId == "print_CreatePrinter")
                .Select(operation => $"{operation.Key.Method} {path.Key} [{operation.Value.OperationId}]"))
                .ToArray();
            Assert.Equal(evidence, selected);
            var createPath = specRoot == "openApiDocs" ? "/print/printers/microsoft.graph.create" : "/print/printers/create";
            AssertOperation(document, HttpMethod.Post, createPath, "print.printer_create");
        }
    }

    [Theory]
    [InlineData("v1.0", false)]
    [InlineData("v1.0", true)]
    [InlineData("beta", false)]
    [InlineData("beta", true)]
    public void ExistingReviewedReferenceCollisionPolicyKeepsPublishedCollectionRoutes(string profile, bool useCollisionData)
    {
        var document = LoadSpec(profile);
        var config = new GeneratorConfig("Test.Client", "unused", useCollisionData);
        using var metadata = JsonDocument.Parse(File.ReadAllText(Path.Combine(FindRepoRoot(),
            "src", "Authentication", "Authentication", "custom", "common", "MgCommandMetadata.json")));
        foreach (var (collection, item, noun) in new[]
        {
            ("allowedGroups", "group-id", "Group"),
            ("allowedUsers", "user-id", "User"),
        })
        {
            var collectionPath = $"/print/shares/{{printerShare-id}}/{collection}/$ref";
            var itemPath = $"/print/shares/{{printerShare-id}}/{collection}/{{{item}}}/$ref";
            AssertOperation(document, HttpMethod.Delete, itemPath, $"print.share.allowed{noun}_Delete{noun}GraphBPreRef");
            Assert.True(CmdletConfigurator.IsSuppressed(HttpMethod.Delete, itemPath, config, apiVersion: profile));
            foreach (var (method, operation) in new[]
            {
                (HttpMethod.Get, "List"),
                (HttpMethod.Post, "Create"),
                (HttpMethod.Delete, "Delete"),
            })
            {
                AssertOperation(document, method, collectionPath,
                    $"print.share_{operation}Allowed{noun}GraphBPreRef");
                Assert.False(CmdletConfigurator.IsSuppressed(method, collectionPath, config, apiVersion: profile));
            }
            var command = $"Remove-Mg{(profile == "beta" ? "Beta" : "")}PrintShareAllowed{noun}ByRef";
            var published = metadata.RootElement.EnumerateArray().Where(row =>
                row.GetProperty("ApiVersion").GetString() == profile &&
                row.GetProperty("Command").GetString() == command).ToArray();
            var publishedRoute = Assert.Single(published);
            Assert.Equal("DELETE", publishedRoute.GetProperty("Method").GetString());
            Assert.Equal(collectionPath, publishedRoute.GetProperty("Uri").GetString());
            if (profile == "v1.0")
            {
                Assert.True(DerivedCollisionResolutions.IsSuppressed(profile, HttpMethod.Delete,
                    CmdletConfigurator.NormalizePathTemplate(itemPath)));
            }
        }
    }

    [Theory]
    [InlineData("v1.0", false)]
    [InlineData("v1.0", true)]
    [InlineData("beta", false)]
    [InlineData("beta", true)]
    public void SuppressesOnlyOrdinaryPrinterCreationAndPreservesNeighbors(string profile, bool useCollisionData)
    {
        var document = LoadSpec(profile);
        var config = new GeneratorConfig("Test.Client", "unused", useCollisionData);
        AssertOperation(document, HttpMethod.Post, "/print/printers", "print_CreatePrinter");
        Assert.True(CmdletConfigurator.IsSuppressed(HttpMethod.Post, "/print/printers", config, apiVersion: profile));
        Assert.True(CmdletConfigurator.IsSuppressed(HttpMethod.Post, "/PRINT/PRINTERS/", config, apiVersion: profile));

        (HttpMethod Method, string Path, string OperationId)[] neighbors =
        [
            (HttpMethod.Get, "/print", "print_GetPrint"),
            (HttpMethod.Get, "/print/printers", "print_ListPrinter"),
            (HttpMethod.Get, "/print/printers/{printer-id}", "print_GetPrinter"),
            (HttpMethod.Patch, "/print/printers/{printer-id}", "print_UpdatePrinter"),
            (HttpMethod.Delete, "/print/printers/{printer-id}", "print_DeletePrinter"),
            (HttpMethod.Post, "/print/printers/{printer-id}/jobs", "print.printer_CreateJob"),
            (HttpMethod.Post, "/print/printers/create", "print.printer_create"),
            (HttpMethod.Post, "/print/shares", "print_CreateShare"),
        ];
        foreach (var neighbor in neighbors)
        {
            AssertOperation(document, neighbor.Method, neighbor.Path, neighbor.OperationId);
            Assert.False(CmdletConfigurator.IsSuppressed(neighbor.Method, neighbor.Path, config, apiVersion: profile),
                $"{profile}: {neighbor.Method} {neighbor.Path} must remain available.");
        }

        var createAction = document.Paths["/print/printers/create"].Operations![HttpMethod.Post];
        Assert.NotNull(createAction.Extensions);
        Assert.True(createAction.Extensions.TryGetValue("x-ms-docs-operation-type", out var operationType));
        var actionType = Assert.IsType<JsonNodeExtension>(operationType);
        Assert.Equal("action", actionType.Node!.GetValue<string>());

        // Beta must not accidentally borrow the v1.0 oracle via a default profile.
        var naming = Naming.Resolve(
            new OperationInfo(HttpMethod.Post, "/print/printers/create", Kind: OperationKind.Action),
            config, apiVersion: profile);
        Assert.Equal(profile == "v1.0" && useCollisionData ? "New" : "Invoke", naming.VerbName);
        Assert.Equal(profile == "v1.0" && useCollisionData ? "MgPrintPrinter" : "MgPrinterCreate", naming.Noun);
        if (profile == "v1.0" && useCollisionData)
        {
            Assert.True(DerivedCollisionResolutions.IsSuppressed(profile, HttpMethod.Post, "/print/printers"));
        }
    }

    private static void AssertOperation(OpenApiDocument document, HttpMethod method, string path, string operationId)
    {
        Assert.True(document.Paths.TryGetValue(path, out var pathItem), $"Compatible spec lacks {path}.");
        Assert.NotNull(pathItem.Operations);
        Assert.True(pathItem.Operations.TryGetValue(method, out var operation), $"Compatible spec lacks {method} {path}.");
        Assert.Equal(operationId, operation.OperationId);
    }

    private static OpenApiDocument LoadSpec(string profile, string specRoot = "openApiDocs_KiotaCompat")
    {
        var path = Path.Combine(FindRepoRoot(), specRoot, profile, "Devices.CloudPrint.yml");
        Assert.True(File.Exists(path), $"Required spec missing: {path}");
        var settings = new OpenApiReaderSettings();
        settings.AddYamlReader();
        using var stream = File.OpenRead(path);
        var result = OpenApiDocument.LoadAsync(stream, settings: settings, cancellationToken: CancellationToken.None)
            .GetAwaiter().GetResult();
        Assert.NotNull(result.Document);
        return result.Document;
    }

    private static string FindRepoRoot()
    {
        var directory = AppContext.BaseDirectory;
        while (directory is not null &&
            !File.Exists(Path.Combine(directory, "src", "Devices.CloudPrint", "Devices.CloudPrint.md")))
        {
            directory = Path.GetDirectoryName(directory);
        }
        Assert.NotNull(directory);
        return directory;
    }
}
