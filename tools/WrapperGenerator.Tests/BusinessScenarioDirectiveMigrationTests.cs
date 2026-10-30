using System;
using System.IO;
using System.Net.Http;
using System.Threading;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Reader;
using WrapperGenerator;
using Xunit;

namespace WrapperGenerator.Tests;

public sealed class BusinessScenarioDirectiveMigrationTests
{
    private static readonly Lazy<OpenApiDocument> BetaDocument = new(LoadBetaDocument);

    [Theory]
    [InlineData("GET", "/solutions/businessScenarios", "solution_ListBusinessScenario", "Get", "MgBusinessScenario")]
    [InlineData("POST", "/solutions/businessScenarios", "solution_CreateBusinessScenario", "New", "MgBusinessScenario")]
    [InlineData("GET", "/solutions/businessScenarios/{businessScenario-id}", "solution_GetBusinessScenario", "Get", "MgBusinessScenario")]
    [InlineData("PATCH", "/solutions/businessScenarios/{businessScenario-id}", "solution_UpdateBusinessScenario", "Update", "MgBusinessScenario")]
    [InlineData("DELETE", "/solutions/businessScenarios/{businessScenario-id}", "solution_DeleteBusinessScenario", "Remove", "MgBusinessScenario")]
    [InlineData("GET", "/solutions/businessScenarios/{businessScenario-id}/planner", "solution.businessScenario_GetPlanner", "Get", "MgBusinessScenarioPlanner")]
    [InlineData("POST", "/solutions/businessScenarios/{businessScenario-id}/planner/getPlan", "solution.businessScenario.planner_getPlan", "Invoke", "MgBusinessScenarioPlannerGetPlan", OperationKind.Action)]
    [InlineData("GET", "/solutions/businessScenarios/{businessScenario-id}/planner/tasks", "solution.businessScenario.planner_ListTask", "Get", "MgBusinessScenarioPlannerTask")]
    [InlineData("GET", "/solutions/businessScenarios/{businessScenario-id}/planner/tasks/{businessScenarioTask-id}", "solution.businessScenario.planner_GetTask", "Get", "MgBusinessScenarioPlannerTask")]
    [InlineData("GET", "/solutions/businessScenarios/$count", "solution.businessScenario_GetCount", "Get", "MgBusinessScenarioCount")]
    public void RealBetaOperationsRetainExistingNames(
        string method, string path, string operationId, string expectedVerb, string expectedNoun,
        OperationKind kind = OperationKind.Resource)
    {
        var httpMethod = new HttpMethod(method);
        var operation = BetaDocument.Value.Paths[path].Operations![httpMethod];
        Assert.Equal(operationId, operation.OperationId);
        if (operation.Extensions?.TryGetValue("x-ms-docs-operation-type", out var extension) == true)
        {
            var operationType = Assert.IsType<JsonNodeExtension>(extension);
            Assert.Equal(kind == OperationKind.Action ? "action" : "operation", operationType.Node?.ToString());
        }
        else
        {
            Assert.Equal(OperationKind.Resource, kind);
        }

        foreach (var useCollisionData in new[] { false, true })
        {
            var config = new GeneratorConfig("Test.Client", "unused", useCollisionData);
            Assert.False(CmdletConfigurator.IsSuppressed(httpMethod, path, config, apiVersion: "beta"));
            var naming = Naming.Resolve(new OperationInfo(httpMethod, path, Kind: kind), config, apiVersion: "beta");
            Assert.Equal(expectedVerb, naming.VerbName);
            Assert.Equal(expectedNoun, naming.Noun);
        }
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void NoRealBetaOperationIsSuppressed(bool useCollisionData)
    {
        var config = new GeneratorConfig("Test.Client", "unused", useCollisionData);
        Assert.Equal(23, BetaDocument.Value.Paths.Count);
        var operationCount = 0;
        foreach (var (path, pathItem) in BetaDocument.Value.Paths)
        {
            Assert.NotNull(pathItem.Operations);
            foreach (var method in pathItem.Operations.Keys)
            {
                Assert.False(CmdletConfigurator.IsSuppressed(method, path, config, apiVersion: "beta"),
                    $"Unexpected suppression of beta {method} {path}.");
                operationCount++;
            }
        }
        Assert.Equal(51, operationCount);
    }

    private static OpenApiDocument LoadBetaDocument()
    {
        var directory = new DirectoryInfo(AppContext.BaseDirectory);
        while (directory is not null
            && !Directory.Exists(Path.Combine(directory.FullName, ".git"))
            && !File.Exists(Path.Combine(directory.FullName, ".git")))
            directory = directory.Parent;
        Assert.NotNull(directory);

        var path = Path.Combine(directory.FullName, "openApiDocs_KiotaCompat", "beta", "BusinessScenario.yml");
        Assert.True(File.Exists(path), $"Required compatible specification not found: {path}");
        var settings = new OpenApiReaderSettings();
        settings.AddYamlReader();
        using var stream = File.OpenRead(path);
        var result = OpenApiDocument.LoadAsync(stream, settings: settings, cancellationToken: CancellationToken.None)
            .GetAwaiter().GetResult();
        Assert.NotNull(result.Document);
        return result.Document;
    }
}
