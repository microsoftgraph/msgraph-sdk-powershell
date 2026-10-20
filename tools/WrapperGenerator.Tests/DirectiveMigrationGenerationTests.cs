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

public sealed class DirectiveMigrationGenerationTests
{
    [Theory]
    [InlineData("v1.0", true)]
    [InlineData("beta", false)]
    public async Task HistoricalBetaSuppressionKeepsOtherMethodsAndNeighboringRoutes(string profile, bool emitsPatch)
    {
        // This deliberately synthetic historical route is absent from the current corpus.
        // Current-spec absence is checked separately by the inventory/ledger tests.
        const string parent = "/compliance/ediscovery/cases/{case-id}/noncustodialDataSources/{noncustodialDataSource-id}";
        var document = new OpenApiDocument
        {
            Paths = new OpenApiPaths(),
            Components = new OpenApiComponents
            {
                Schemas = new Dictionary<string, IOpenApiSchema>
                {
                    ["microsoft.graph.dataSource"] = new OpenApiSchema
                    {
                        Type = JsonSchemaType.Object,
                        Properties = new Dictionary<string, IOpenApiSchema>
                        {
                            ["displayName"] = new OpenApiSchema { Type = JsonSchemaType.String },
                        },
                    },
                },
            },
        };
        OpenApiOperation Operation(HttpMethod method) => new()
        {
            RequestBody = method == HttpMethod.Patch ? new OpenApiRequestBody
            {
                Content = new Dictionary<string, IOpenApiMediaType>
                {
                    ["application/json"] = new OpenApiMediaType { Schema = new OpenApiSchemaReference("microsoft.graph.dataSource", document) },
                },
            } : null,
            Responses = new OpenApiResponses
            {
                ["200"] = new OpenApiResponse
                {
                    Content = new Dictionary<string, IOpenApiMediaType>
                    {
                        ["application/json"] = new OpenApiMediaType { Schema = new OpenApiSchemaReference("microsoft.graph.dataSource", document) },
                    },
                },
            },
        };
        document.Paths[parent + "/dataSource"] = new OpenApiPathItem
        {
            Operations = new Dictionary<HttpMethod, OpenApiOperation>
            {
                [HttpMethod.Get] = Operation(HttpMethod.Get),
                [HttpMethod.Patch] = Operation(HttpMethod.Patch),
                [HttpMethod.Delete] = Operation(HttpMethod.Delete),
            },
        };
        document.Paths[parent] = new OpenApiPathItem
        {
            Operations = new Dictionary<HttpMethod, OpenApiOperation> { [HttpMethod.Patch] = Operation(HttpMethod.Patch) },
        };
        var output = Path.Combine(Path.GetTempPath(), "wrapper-directive-tests", Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(output);
        try
        {
            var config = new GeneratorConfig("Test.Client", output, ApiVersion: profile, UseCollisionData: false);
            await new PowerShellWrapperGenerationService(document, config, NullLogger.Instance).GenerateAsync(CancellationToken.None);
            const string noun = "MgComplianceEdiscoveryCaseNoncustodialDataSource";
            Assert.True(File.Exists(Path.Combine(output, $"Get{noun}DataSource.g.cs")));
            Assert.Equal(emitsPatch, File.Exists(Path.Combine(output, $"Update{noun}DataSource.g.cs")));
            Assert.Equal(emitsPatch, File.Exists(Path.Combine(output, $"Remove{noun}DataSource.g.cs")));
            Assert.True(File.Exists(Path.Combine(output, $"Update{noun}.g.cs")));
        }
        finally
        {
            Directory.Delete(output, recursive: true);
        }
    }
}
