using System;
using System.IO;
using System.Net.Http;
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
    [InlineData("v1.0", false)]
    [InlineData("v1.0", true)]
    [InlineData("beta", false)]
    [InlineData("beta", true)]
    public void SuppressesOnlyOrdinaryPrinterCreationAndPreservesNeighbors(string profile, bool useCollisionData)
    {
        var document = LoadSpec(profile);
        var config = new GeneratorConfig("Test.Client", "unused", profile, useCollisionData);
        AssertOperation(document, HttpMethod.Post, "/print/printers", "print.CreatePrinters");
        Assert.True(CmdletConfigurator.IsSuppressed(HttpMethod.Post, "/print/printers", config));
        Assert.True(CmdletConfigurator.IsSuppressed(HttpMethod.Post, "/PRINT/PRINTERS/", config));

        (HttpMethod Method, string Path, string OperationId)[] neighbors =
        [
            (HttpMethod.Get, "/print", "print.print.GetPrint"),
            (HttpMethod.Get, "/print/printers", "print.ListPrinters"),
            (HttpMethod.Get, "/print/printers/{printer-id}", "print.GetPrinters"),
            (HttpMethod.Patch, "/print/printers/{printer-id}", "print.UpdatePrinters"),
            (HttpMethod.Delete, "/print/printers/{printer-id}", "print.DeletePrinters"),
            (HttpMethod.Post, "/print/printers/{printer-id}/jobs", "print.printers.CreateJobs"),
            (HttpMethod.Post, "/print/printers/create", "print.printers.create"),
            (HttpMethod.Post, "/print/shares", "print.CreateShares"),
        ];
        foreach (var neighbor in neighbors)
        {
            AssertOperation(document, neighbor.Method, neighbor.Path, neighbor.OperationId);
            Assert.False(CmdletConfigurator.IsSuppressed(neighbor.Method, neighbor.Path, config),
                $"{profile}: {neighbor.Method} {neighbor.Path} must remain available.");
        }

        var createAction = document.Paths["/print/printers/create"].Operations![HttpMethod.Post];
        Assert.NotNull(createAction.Extensions);
        Assert.True(createAction.Extensions.TryGetValue("x-ms-docs-operation-type", out var operationType));
        var actionType = Assert.IsType<JsonNodeExtension>(operationType);
        Assert.Equal("action", actionType.Node!.GetValue<string>());

        // Preserve the existing published v1.0 action name, rather than suppressing
        // every operation whose final name is New-MgPrintPrinter.
        if (profile == "v1.0" && useCollisionData)
        {
            Assert.True(DerivedCollisionResolutions.IsSuppressed(profile, HttpMethod.Post, "/print/printers"));
            var naming = Naming.Resolve(
                new OperationInfo(HttpMethod.Post, "/print/printers/create", Kind: OperationKind.Action), config);
            Assert.Equal("New", naming.VerbName);
            Assert.Equal("MgPrintPrinter", naming.Noun);
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
        var directory = AppContext.BaseDirectory;
        while (directory is not null &&
            !File.Exists(Path.Combine(directory, "src", "Devices.CloudPrint", "Devices.CloudPrint.md")))
        {
            directory = Path.GetDirectoryName(directory);
        }
        Assert.NotNull(directory);
        var path = Path.Combine(directory, specRoot, profile, "Devices.CloudPrint.yml");
        Assert.True(File.Exists(path), $"Required spec missing: {path}");
        var settings = new OpenApiReaderSettings();
        settings.AddYamlReader();
        using var stream = File.OpenRead(path);
        var result = OpenApiDocument.LoadAsync(stream, settings: settings, cancellationToken: CancellationToken.None)
            .GetAwaiter().GetResult();
        Assert.NotNull(result.Document);
        return result.Document;
    }
}
