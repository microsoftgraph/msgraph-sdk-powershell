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
    [InlineData("v1.0", true)]
    [InlineData("beta", true)]
    [InlineData("v1.0", false)]
    [InlineData("beta", false)]
    public async Task EmptySharedConfigurationPreservesAllCompatibleOperations(string profile, bool useCollisionData)
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
            (HttpMethod.Get, "/schemaExtensions", "schemaExtension_ListSchemaExtension", "Get", "MgSchemaExtension", "GetMgSchemaExtension_List.g.cs"),
            (HttpMethod.Post, "/schemaExtensions", "schemaExtension_CreateSchemaExtension", "New", "MgSchemaExtension", "NewMgSchemaExtension.g.cs"),
            (HttpMethod.Get, "/schemaExtensions/{schemaExtension-id}", "schemaExtension_GetSchemaExtension", "Get", "MgSchemaExtension", "GetMgSchemaExtension_Get.g.cs"),
            (HttpMethod.Patch, "/schemaExtensions/{schemaExtension-id}", "schemaExtension_UpdateSchemaExtension", "Update", "MgSchemaExtension", "UpdateMgSchemaExtension.g.cs"),
            (HttpMethod.Delete, "/schemaExtensions/{schemaExtension-id}", "schemaExtension_DeleteSchemaExtension", "Remove", "MgSchemaExtension", "RemoveMgSchemaExtension.g.cs"),
            (HttpMethod.Get, "/schemaExtensions/$count", "schemaExtension_GetCount", "Get", "MgSchemaExtensionCount", "GetMgSchemaExtensionCount.g.cs"),
        };

        var output = Path.Combine(Path.GetTempPath(), "wrapper-generator-tests", Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(output);
        try
        {
            var config = new GeneratorConfig("Microsoft.Graph.PowerShell.SchemaExtensions.Client", output,
                UseCollisionData: useCollisionData);
            foreach (var (method, path, operationId, verb, noun, _) in expectedOperations)
            {
                Assert.Equal(operationId, document.Paths[path].Operations![method].OperationId);
                Assert.False(CmdletConfigurator.IsSuppressed(method, path, config, apiVersion: profile));
                var naming = Naming.Resolve(new OperationInfo(method, path), config, apiVersion: profile);
                Assert.Equal(verb, naming.VerbName);
                Assert.Equal(noun, naming.Noun);
            }

            var service = new PowerShellWrapperGenerationService(document, config, NullLogger.Instance,
                apiVersion: profile);
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
            foreach (var (method, path, _, _, _, file) in expectedOperations)
                Assert.Contains($"[GraphRoute(\"{method.Method}\", \"{path}\")]",
                    File.ReadAllText(Path.Combine(output, file)));
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
