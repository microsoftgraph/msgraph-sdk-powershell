using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.OpenApi;
using WrapperGenerator;
using Xunit;

namespace WrapperGenerator.Tests;

public sealed class GenerationServiceRegressionTests
{
    // Kiota moves a model INTO a same-named sub-namespace when both exist:
    // microsoft.graph.security (alongside microsoft.graph.security.*) generates as
    // Models.Security.Security, and a bare "Security" reference resolves to the namespace
    // instead — it does not compile (found by building the Security module end to end).
    [Theory]
    // always fully qualified: bare "Directory" resolved to System.IO.Directory under
    // implicit usings (Identity.DirectoryManagement), bare "Security" to the sub-namespace.
    [InlineData("microsoft.graph.user", "Test.Models.User")]
    [InlineData("microsoft.graph.directory", "Test.Models.Directory")]
    [InlineData("microsoft.graph.security", "Test.Models.Security.Security")]
    [InlineData("microsoft.graph.security.alert", "Test.Models.Security.Alert")]
    [InlineData("microsoft.graph.partners", "Test.Models.Partners.Partners")]
    public void ResolvesModelTypeNamesTheWayKiotaLaysThemOut(string schemaName, string expected)
    {
        var subNamespaces = new HashSet<string> { "Security", "Partners", "CallRecords" };
        Assert.Equal(expected,
            PowerShellWrapperGenerationService.ResolveModelTypeName(schemaName, "Test.Models", subNamespaces));
    }

    // Kiota renames reserved class names (BCL conflicts) by appending "Object", then dedupes
    // numerically: microsoft.graph.directory -> DirectoryObject1, because directoryObject
    // already exists (verified against the Identity.DirectoryManagement client).
    [Fact]
    public void AppliesKiotaReservedNameRenames()
    {
        var renames = new Dictionary<string, string>
        {
            ["Directory"] = "DirectoryObject1",
            ["IdentityGovernance.Task"] = "TaskObject",
        };
        Assert.Equal("Test.Models.DirectoryObject1",
            PowerShellWrapperGenerationService.ResolveModelTypeName(
                "microsoft.graph.directory", "Test.Models", new HashSet<string>(), renames));
        // Reserved renames apply inside sub-namespaces too: identityGovernance.task
        // generates as Models.IdentityGovernance.TaskObject (verified against the
        // Identity.Governance client).
        Assert.Equal("Test.Models.IdentityGovernance.TaskObject",
            PowerShellWrapperGenerationService.ResolveModelTypeName(
                "microsoft.graph.identityGovernance.task", "Test.Models", new HashSet<string> { "IdentityGovernance" }, renames));
    }

    [Fact]
    public async Task GenerateAsync_SkipsGetWithoutJsonSuccessSchema_DoesNotThrow()
    {
        var operation = new OpenApiOperation
        {
            OperationId = "user_get_plain_text",
            Responses = new OpenApiResponses
            {
                ["200"] = new OpenApiResponse
                {
                    Content = new Dictionary<string, IOpenApiMediaType>
                    {
                        ["text/plain"] = new OpenApiMediaType
                        {
                            Schema = new OpenApiSchema { Type = JsonSchemaType.String },
                        },
                    },
                },
            },
        };

        var document = BuildDocument(HttpMethod.Get, "/users/{user-id}", operation);
        var files = await RunGeneratorAndListFilesAsync(document);

        Assert.Contains("Shared.g.cs", files);
        Assert.DoesNotContain(files, f => f != "Shared.g.cs");
    }

    [Fact]
    public async Task GenerateAsync_SkipsUnsupportedHttpMethod_DoesNotThrow()
    {
        var operation = new OpenApiOperation
        {
            OperationId = "user_set_photo_value",
            RequestBody = new OpenApiRequestBody
            {
                Content = new Dictionary<string, IOpenApiMediaType>
                {
                    ["application/json"] = new OpenApiMediaType
                    {
                        Schema = new OpenApiSchema
                        {
                            Type = JsonSchemaType.Object,
                            Properties = new Dictionary<string, IOpenApiSchema>
                            {
                                ["displayName"] = new OpenApiSchema { Type = JsonSchemaType.String },
                            },
                        },
                    },
                },
            },
        };

        var document = BuildDocument(HttpMethod.Put, "/users/{user-id}/photo/$value", operation);
        var files = await RunGeneratorAndListFilesAsync(document);

        Assert.Contains("Shared.g.cs", files);
        Assert.DoesNotContain(files, f => f != "Shared.g.cs");
    }

    [Fact]
    public async Task GenerateAsync_SkipsPostWithNonRefBodySchema_DoesNotThrow()
    {
        var operation = new OpenApiOperation
        {
            OperationId = "user_create_inline",
            RequestBody = new OpenApiRequestBody
            {
                Content = new Dictionary<string, IOpenApiMediaType>
                {
                    ["application/json"] = new OpenApiMediaType
                    {
                        // Inline object schema (no $ref) previously caused entity-type resolution crashes.
                        Schema = new OpenApiSchema
                        {
                            Type = JsonSchemaType.Object,
                            Properties = new Dictionary<string, IOpenApiSchema>
                            {
                                ["displayName"] = new OpenApiSchema { Type = JsonSchemaType.String },
                            },
                        },
                    },
                },
            },
        };

        var document = BuildDocument(HttpMethod.Post, "/users", operation);
        var files = await RunGeneratorAndListFilesAsync(document);

        Assert.Contains("Shared.g.cs", files);
        Assert.DoesNotContain(files, f => f != "Shared.g.cs");
    }

    [Theory]
    // $count would produce a mangled noun (Get-MgUsercount); $value an invalid builder chain
    // (client...$value does not compile); parameterized function segments mangle into garbage
    // nouns. All are skipped up front until those shapes are supported.
    [InlineData("/users/$count")]
    [InlineData("/users/{user-id}/photo/$value")]
    [InlineData("/solutions/virtualEvents/townhalls/getByUserIdAndRole(userId='{userId}',role='{role}')")]
    public async Task GenerateAsync_SkipsUnsupportedODataPathSegments_DoesNotEmitMalformedCmdlets(string path)
    {
        var operation = new OpenApiOperation
        {
            OperationId = "unsupported_shape",
            Responses = new OpenApiResponses
            {
                ["2XX"] = new OpenApiResponse
                {
                    Content = new Dictionary<string, IOpenApiMediaType>
                    {
                        ["application/json"] = new OpenApiMediaType
                        {
                            Schema = new OpenApiSchema { Type = JsonSchemaType.Object },
                        },
                    },
                },
            },
        };

        var document = BuildDocument(HttpMethod.Get, path, operation);
        var files = await RunGeneratorAndListFilesAsync(document);

        Assert.Contains("Shared.g.cs", files);
        Assert.DoesNotContain(files, f => f != "Shared.g.cs");
    }

    private static OpenApiDocument BuildDocument(HttpMethod method, string path, OpenApiOperation operation)
    {
        return new OpenApiDocument
        {
            Paths = new OpenApiPaths
            {
                [path] = new OpenApiPathItem
                {
                    Operations = new Dictionary<HttpMethod, OpenApiOperation>
                    {
                        [method] = operation,
                    },
                },
            },
        };
    }

    private static async Task<string[]> RunGeneratorAndListFilesAsync(OpenApiDocument document)
    {
        var outputDir = Path.Combine(Path.GetTempPath(), "wrapper-generator-tests", Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(outputDir);

        try
        {
            var config = new GeneratorConfig("Microsoft.Graph.PowerShell.Test.Client", outputDir);
            var service = new PowerShellWrapperGenerationService(document, config, NullLogger.Instance);

            await service.GenerateAsync(CancellationToken.None);

            var files = Directory.GetFiles(outputDir, "*.g.cs", SearchOption.TopDirectoryOnly);
            for (var i = 0; i < files.Length; i++)
                files[i] = Path.GetFileName(files[i]);
            return files;
        }
        finally
        {
            if (Directory.Exists(outputDir))
                Directory.Delete(outputDir, recursive: true);
        }
    }
}
