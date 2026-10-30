using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Reader;
using WrapperGenerator;
using Xunit;

namespace WrapperGenerator.Tests;

public sealed class ReservedNavigationTests
{
    [Theory]
    // Kiota 1.36.1 output: only navigation properties get Path, not namespaces or types.
    [InlineData("/widgets/{widget-id}/post", OperationKind.Action,
        "Widgets[WidgetId].PostPath", "Widgets.Item.Post", "Post", "MgWidgetPost")]
    [InlineData("/widgets/{widget-id}/delete", OperationKind.Action,
        "Widgets[WidgetId].DeletePath", "Widgets.Item.Delete", "Delete", "MgWidgetDelete")]
    [InlineData("/widgets/{widget-id}/microsoft.graph.post", OperationKind.Action,
        "Widgets[WidgetId].MicrosoftGraphPost", "Widgets.Item.MicrosoftGraphPost", "MicrosoftGraphPost", "MgWidgetPost")]
    [InlineData("/widgets/{widget-id}/postAndSend", OperationKind.Action,
        "Widgets[WidgetId].PostAndSend", "Widgets.Item.PostAndSend", "PostAndSend", "MgWidgetPostAndSend")]
    [InlineData("/functions/post()", OperationKind.Function,
        "Functions.PostPath", "Functions.Post", "Post", "MgFunctionPost")]
    [InlineData("/functions/post(value='{value}')", OperationKind.Function,
        "Functions.PostWithValue()", "Functions.PostWithValue", "PostWithValue", "MgFunctionPostWithValue")]
    public void EscapesOnlyTheTypedNavigationProperty(string path, OperationKind kind,
        string expression, string typeNamespace, string typeMember, string noun)
    {
        var naming = Naming.Resolve(new OperationInfo(
            kind == OperationKind.Action ? HttpMethod.Post : HttpMethod.Get, path, null, kind));

        Assert.Equal(expression, naming.BuilderExpression);
        Assert.Equal(typeNamespace, naming.OperationTypeNamespace);
        Assert.Equal(typeMember, naming.OperationMemberName);
        Assert.Equal(noun, naming.Noun);
        Assert.Equal(typeMember == "MicrosoftGraphPost" ? "Post" : typeMember, naming.OperationTypeName);
        Assert.Equal(path, naming.SourcePath);
    }

    [Fact]
    public void EscapesIntermediateResourcePropertiesWithoutChangingParametersOrNouns()
    {
        var naming = Naming.Resolve(new OperationInfo(HttpMethod.Get, "/resources/post/{post-id}"));
        Assert.Equal("Resources.PostPath[PostId]", naming.BuilderExpression);
        Assert.Equal("MgResourcePost", naming.Noun);
        Assert.Equal(["PostId"], naming.PathParamNames);
        Assert.Empty(naming.OperationTypeNamespace);
        Assert.Equal("Post", Naming.ParseOperationSegment("post").MemberName);
    }

    [Theory]
    [InlineData("journals", "journal-id", "Journal")]
    [InlineData("purchaseInvoices", "purchaseInvoice-id", "PurchaseInvoice")]
    [InlineData("salesInvoices", "salesInvoice-id", "SaleInvoice")]
    public async Task GeneratesTheActualFinancialsPostActionWithItsOriginalContract(
        string collection, string id, string noun)
    {
        var cancellationToken = TestContext.Current.CancellationToken;
        var directory = AppContext.BaseDirectory;
        while (directory is not null &&
            !File.Exists(Path.Combine(directory, "openApiDocs_KiotaCompat", "beta", "Financials.yml")))
            directory = Path.GetDirectoryName(directory);
        Assert.NotNull(directory);

        var settings = new OpenApiReaderSettings();
        settings.AddYamlReader();
        using var stream = File.OpenRead(Path.Combine(directory, "openApiDocs_KiotaCompat", "beta", "Financials.yml"));
        var result = await OpenApiDocument.LoadAsync(stream, settings: settings, cancellationToken: cancellationToken);
        Assert.NotNull(result.Document);
        var path = $"/financials/companies/{{company-id}}/{collection}/{{{id}}}/post";
        IncludePathFilter.Apply(result.Document, [path + "#POST"]);
        Assert.Single(result.Document.Paths);
        Assert.Equal($"financial.company.{(collection == "journals" ? "journal" : collection[..^1])}_post",
            result.Document.Paths[path].Operations![HttpMethod.Post].OperationId);

        var output = Path.Combine(Path.GetTempPath(), "wrapper-reserved-navigation", Guid.NewGuid().ToString("N"));
        try
        {
            var config = new GeneratorConfig("ReservedNavigation.Client", output, UseCollisionData: false);
            await new PowerShellWrapperGenerationService(result.Document, config, NullLogger.Instance, apiVersion: "beta")
                .GenerateAsync(cancellationToken);
            var file = Assert.Single(Directory.GetFiles(output, "*.g.cs"));
            Assert.Equal($"InvokeMgFinancialCompany{noun}Post.g.cs", Path.GetFileName(file));
            var source = await File.ReadAllTextAsync(file, cancellationToken);
            Assert.Contains($".{collection[..1].ToUpperInvariant() + collection[1..]}[{id.ToPascalCase('-')}].PostPath.PostAsync(requestConfiguration", source, StringComparison.Ordinal);
            Assert.Contains($"[GraphRoute(\"POST\", \"{path}\")]", source, StringComparison.Ordinal);
            Assert.Contains("SupportsShouldProcess = true", source, StringComparison.Ordinal);
            Assert.DoesNotContain("var body = new", source, StringComparison.Ordinal);
            Assert.DoesNotContain("PostPathPostRequestBody", source, StringComparison.Ordinal);
        }
        finally
        {
            if (Directory.Exists(output))
                Directory.Delete(output, recursive: true);
        }
    }
}
