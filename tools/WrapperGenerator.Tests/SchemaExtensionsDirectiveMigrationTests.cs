using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Reader;
using WrapperGenerator;
using Xunit;

namespace WrapperGenerator.Tests;

public sealed class SchemaExtensionsDirectiveMigrationTests
{
    [Theory]
    [InlineData("v1.0")]
    [InlineData("beta")]
    public async Task EmptySharedConfigurationPreservesAllCompatibleOperations(string profile)
    {
        var root = FindRepoRoot();
        var settings = new OpenApiReaderSettings();
        settings.AddYamlReader();
        using var stream = File.OpenRead(Path.Combine(root, "openApiDocs_KiotaCompat", profile, "SchemaExtensions.yml"));
        var result = await OpenApiDocument.LoadAsync(stream, settings: settings, cancellationToken: CancellationToken.None);
        var document = Assert.IsType<OpenApiDocument>(result.Document);
        Assert.Equal(6, document.Paths.Values.Sum(path => path.Operations!.Count));

        var expectedOperations = new[]
        {
            (HttpMethod.Get, "/schemaExtensions", "schemaExtensions.schemaExtension.ListSchemaExtension"),
            (HttpMethod.Post, "/schemaExtensions", "schemaExtensions.schemaExtension.CreateSchemaExtension"),
            (HttpMethod.Get, "/schemaExtensions/{schemaExtension-id}", "schemaExtensions.schemaExtension.GetSchemaExtension"),
            (HttpMethod.Patch, "/schemaExtensions/{schemaExtension-id}", "schemaExtensions.schemaExtension.UpdateSchemaExtension"),
            (HttpMethod.Delete, "/schemaExtensions/{schemaExtension-id}", "schemaExtensions.schemaExtension.DeleteSchemaExtension"),
            (HttpMethod.Get, "/schemaExtensions/$count", "schemaExtensions.GetCount-e324"),
        };
        foreach (var (method, path, operationId) in expectedOperations)
            Assert.Equal(operationId, document.Paths[path].Operations![method].OperationId);

        var output = Path.Combine(Path.GetTempPath(), "wrapper-generator-tests", Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(output);
        try
        {
            var config = new GeneratorConfig("Microsoft.Graph.PowerShell.SchemaExtensions.Client", output, profile);
            var service = new PowerShellWrapperGenerationService(document, config, NullLogger.Instance);
            await service.GenerateAsync(CancellationToken.None);

            var expectedFiles = new[]
            {
                "GetMgSchemaExtension.g.cs",
                "GetMgSchemaExtensionCount.g.cs",
                "GetMgSchemaExtension_Get.g.cs",
                "GetMgSchemaExtension_List.g.cs",
                "NewMgSchemaExtension.g.cs",
                "RemoveMgSchemaExtension.g.cs",
                "UpdateMgSchemaExtension.g.cs",
            };
            Assert.Equal(expectedFiles.OrderBy(name => name, StringComparer.Ordinal),
                Directory.GetFiles(output, "*.g.cs").Select(Path.GetFileName).OrderBy(name => name, StringComparer.Ordinal));
            foreach (var (_, path, _) in expectedOperations)
                Assert.Contains(Directory.GetFiles(output, "*.g.cs"),
                    file => File.ReadAllText(file).Contains($"\"{path}\"", StringComparison.Ordinal));
        }
        finally
        {
            Directory.Delete(output, recursive: true);
        }
    }

    private static string FindRepoRoot()
    {
        var directory = AppContext.BaseDirectory;
        while (directory is not null &&
            !File.Exists(Path.Combine(directory, "src", "SchemaExtensions", "SchemaExtensions.md")))
            directory = Path.GetDirectoryName(directory);
        return directory ?? throw new InvalidOperationException("Repo root not found from test base directory.");
    }
}
