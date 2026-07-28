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
