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
    [InlineData("GET", "/solutions/businessScenarios", "solutions.ListBusinessScenarios", "Get", "MgBusinessScenario")]
    [InlineData("POST", "/solutions/businessScenarios", "solutions.CreateBusinessScenarios", "New", "MgBusinessScenario")]
    [InlineData("GET", "/solutions/businessScenarios/{businessScenario-id}", "solutions.GetBusinessScenarios", "Get", "MgBusinessScenario")]
    [InlineData("PATCH", "/solutions/businessScenarios/{businessScenario-id}", "solutions.UpdateBusinessScenarios", "Update", "MgBusinessScenario")]
    [InlineData("DELETE", "/solutions/businessScenarios/{businessScenario-id}", "solutions.DeleteBusinessScenarios", "Remove", "MgBusinessScenario")]
    [InlineData("GET", "/solutions/businessScenarios/{businessScenario-id}/planner", "solutions.businessScenarios.GetPlanner", "Get", "MgBusinessScenarioPlanner")]
    [InlineData("POST", "/solutions/businessScenarios/{businessScenario-id}/planner/getPlan", "solutions.businessScenarios.businessScenario.planner.getPlan", "Invoke", "MgBusinessScenarioPlannerGetPlan", OperationKind.Action)]
    [InlineData("GET", "/solutions/businessScenarios/{businessScenario-id}/planner/tasks", "solutions.businessScenarios.planner.ListTasks", "Get", "MgBusinessScenarioPlannerTask")]
    [InlineData("GET", "/solutions/businessScenarios/{businessScenario-id}/planner/tasks/{businessScenarioTask-id}", "solutions.businessScenarios.planner.GetTasks", "Get", "MgBusinessScenarioPlannerTask")]
    [InlineData("GET", "/solutions/businessScenarios/$count", "solutions.businessScenarios.GetCount-69a1", "Get", "MgBusinessScenarioCount")]
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
            var config = new GeneratorConfig("Test.Client", "unused", "beta", useCollisionData);
            Assert.False(CmdletConfigurator.IsSuppressed(httpMethod, path, config));
            var naming = Naming.Resolve(new OperationInfo(httpMethod, path, Kind: kind), config);
            Assert.Equal(expectedVerb, naming.VerbName);
            Assert.Equal(expectedNoun, naming.Noun);
        }
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void NoRealBetaOperationIsSuppressed(bool useCollisionData)
    {
        var config = new GeneratorConfig("Test.Client", "unused", "beta", useCollisionData);
        var operationCount = 0;
        foreach (var (path, pathItem) in BetaDocument.Value.Paths)
        {
            Assert.NotNull(pathItem.Operations);
            foreach (var method in pathItem.Operations.Keys)
            {
                Assert.False(CmdletConfigurator.IsSuppressed(method, path, config),
                    $"Unexpected suppression of beta {method} {path}.");
                operationCount++;
            }
        }
        Assert.True(operationCount > 0, "The compatible beta document must contain real operations.");
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
