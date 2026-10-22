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

public sealed class FinancialsDirectiveMigrationTests
{
    private static readonly Lazy<OpenApiDocument> BetaDocument = new(LoadBetaDocument);

    [Fact]
    public void EmptySharedAuditLeavesEveryRealBetaOperationUnsuppressedAndStructurallyNamed()
    {
        var config = new GeneratorConfig("Microsoft.Graph.Beta.PowerShell.Financials.Client", "", ApiVersion: "beta");
        var operations = BetaDocument.Value.Paths
            .SelectMany(path => path.Value.Operations!.Select(operation => (Path: path.Key, Method: operation.Key)))
            .ToArray();

        Assert.Equal(648, operations.Length);
        foreach (var operation in operations)
        {
            Assert.False(CmdletConfigurator.IsSuppressed(operation.Method, operation.Path, config),
                $"Unexpected suppression: {operation.Method} {operation.Path}");
            Assert.Equal("FinancialsAuditSentinel",
                CmdletConfigurator.ApplyNounOverrides(operation.Method, operation.Path, "FinancialsAuditSentinel", config));
            Assert.Null(CmdletConfigurator.TryGetOverriddenVerb(operation.Method, operation.Path, config));
        }
    }

    [Theory]
    [InlineData("GET", "/financials", "financials.financials.GetFinancials", "Get", "MgFinancial")]
    [InlineData("PATCH", "/financials", "financials.financials.UpdateFinancials", "Update", "MgFinancial")]
    [InlineData("GET", "/financials/companies", "financials.ListCompanies", "Get", "MgFinancialCompany")]
    [InlineData("GET", "/financials/companies/{company-id}", "financials.GetCompanies", "Get", "MgFinancialCompany")]
    [InlineData("GET", "/financials/companies/{company-id}/accounts", "financials.companies.ListAccounts", "Get", "MgFinancialCompanyAccount")]
    [InlineData("GET", "/financials/companies/{company-id}/accounts/{account-id}", "financials.companies.GetAccounts", "Get", "MgFinancialCompanyAccount")]
    [InlineData("POST", "/financials/companies/{company-id}/customers", "financials.companies.CreateCustomers", "New", "MgFinancialCompanyCustomer")]
    [InlineData("PATCH", "/financials/companies/{company-id}/customers/{customer-id}", "financials.companies.UpdateCustomers", "Update", "MgFinancialCompanyCustomer")]
    [InlineData("DELETE", "/financials/companies/{company-id}/customers/{customer-id}", "financials.companies.DeleteCustomers", "Remove", "MgFinancialCompanyCustomer")]
    public void NeighboringBetaRoutesKeepTheirOperationIdentityAndName(
        string method, string path, string operationId, string verb, string noun)
    {
        var httpMethod = new HttpMethod(method);
        var operation = BetaDocument.Value.Paths[path].Operations![httpMethod];
        Assert.Equal(operationId, operation.OperationId);

        var config = new GeneratorConfig("Microsoft.Graph.Beta.PowerShell.Financials.Client", "", ApiVersion: "beta");
        var naming = Naming.Resolve(new OperationInfo(httpMethod, path, HeaderParams: null), config);
        Assert.Equal(verb, naming.VerbName);
        Assert.Equal(noun, naming.Noun);
        Assert.Equal(path, naming.SourcePath);
        Assert.Equal(method, naming.SourceMethod);
    }

    [Fact]
    public async Task RealBetaCompanyAndCustomerRoutesStillEmitTheirUnchangedSurface()
    {
        var document = SelectBetaPaths(
            "/financials",
            "/financials/companies",
            "/financials/companies/{company-id}",
            "/financials/companies/{company-id}/customers",
            "/financials/companies/{company-id}/customers/{customer-id}");

        await WithGeneratedSources(document, output =>
        {
            Assert.Equal(
                new[]
                {
                    "GetMgFinancial.g.cs",
                    "GetMgFinancialCompany.g.cs",
                    "GetMgFinancialCompanyCustomer.g.cs",
                    "GetMgFinancialCompanyCustomer_Get.g.cs",
                    "GetMgFinancialCompanyCustomer_List.g.cs",
                    "GetMgFinancialCompany_Get.g.cs",
                    "GetMgFinancialCompany_List.g.cs",
                    "NewMgFinancialCompanyCustomer.g.cs",
                    "RemoveMgFinancialCompanyCustomer.g.cs",
                    "UpdateMgFinancial.g.cs",
                    "UpdateMgFinancialCompanyCustomer.g.cs",
                }.OrderBy(name => name, StringComparer.Ordinal),
                Directory.GetFiles(output, "*.g.cs").Select(Path.GetFileName).OrderBy(name => name, StringComparer.Ordinal));
            var item = File.ReadAllText(Path.Combine(output, "GetMgFinancialCompanyCustomer_Get.g.cs"));
            Assert.Contains("/financials/companies/{company-id}/customers/{customer-id}", item, StringComparison.Ordinal);
            Assert.Contains("Models.Customer", item, StringComparison.Ordinal);
            var create = File.ReadAllText(Path.Combine(output, "NewMgFinancialCompanyCustomer.g.cs"));
            Assert.Contains("CompanyId", create, StringComparison.Ordinal);
            Assert.Contains("DisplayName", create, StringComparison.Ordinal);
        });
    }

    [Theory]
    [InlineData("/financials/companies/{company-id}/journals/{journal-id}/post",
        "financials.companies.company.journals.journal.post", "InvokeMgFinancialCompanyJournalPost.g.cs")]
    [InlineData("/financials/companies/{company-id}/salesInvoices/{salesInvoice-id}/postAndSend",
        "financials.companies.company.salesInvoices.salesInvoice.postAndSend", "InvokeMgFinancialCompanySaleInvoicePostAndSend.g.cs")]
    public async Task RealBetaActionsRemainDistinctAndAreNotInventedCrudOverrides(
        string path, string operationId, string expectedFile)
    {
        var document = SelectBetaPaths(path);
        Assert.Equal(operationId, document.Paths[path].Operations![HttpMethod.Post].OperationId);
        await WithGeneratedSources(document, output =>
        {
            Assert.Equal(expectedFile, Path.GetFileName(Assert.Single(Directory.GetFiles(output, "*.g.cs"))));
            Assert.Contains(path, File.ReadAllText(Path.Combine(output, expectedFile)), StringComparison.Ordinal);
        });
    }

    private static OpenApiDocument SelectBetaPaths(params string[] paths)
    {
        var selected = new OpenApiPaths();
        foreach (var path in paths)
            selected.Add(path, BetaDocument.Value.Paths[path]);
        return new OpenApiDocument { Paths = selected, Components = BetaDocument.Value.Components };
    }

    private static async Task WithGeneratedSources(OpenApiDocument document, Action<string> assertSources)
    {
        var output = Path.Combine(Path.GetTempPath(), "financials-directive-tests", Guid.NewGuid().ToString("N"));
        try
        {
            var config = new GeneratorConfig("Microsoft.Graph.Beta.PowerShell.Financials.Client", output, ApiVersion: "beta");
            await new PowerShellWrapperGenerationService(document, config, NullLogger.Instance)
                .GenerateAsync(CancellationToken.None);
            assertSources(output);
        }
        finally
        {
            if (Directory.Exists(output))
                Directory.Delete(output, recursive: true);
        }
    }

    private static OpenApiDocument LoadBetaDocument()
    {
        var root = new DirectoryInfo(AppContext.BaseDirectory);
        while (root is not null
            && !Directory.Exists(Path.Combine(root.FullName, ".git"))
            && !File.Exists(Path.Combine(root.FullName, ".git")))
            root = root.Parent;
        Assert.NotNull(root);

        // Read the compatible beta input itself, never a legacy or profile-local fallback.
        var path = Path.Combine(root.FullName, "openApiDocs_KiotaCompat", "beta", "Financials.yml");
        Assert.True(File.Exists(path), $"Required Financials beta specification is missing: {path}");
        var settings = new OpenApiReaderSettings();
        settings.AddYamlReader();
        using var stream = File.OpenRead(path);
        var result = OpenApiDocument.LoadAsync(stream, settings: settings, cancellationToken: CancellationToken.None)
            .GetAwaiter().GetResult();
        Assert.NotNull(result.Document);
        Assert.NotNull(result.Diagnostic);
        Assert.Empty(result.Diagnostic.Errors);
        return result.Document;
    }
}
