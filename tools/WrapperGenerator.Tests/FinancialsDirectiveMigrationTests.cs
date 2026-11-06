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
    private static readonly string[] ExcludedPostPaths =
    [
        "/financials/companies/{company-id}/journals/{journal-id}/post",
        "/financials/companies/{company-id}/purchaseInvoices/{purchaseInvoice-id}/post",
        "/financials/companies/{company-id}/salesInvoices/{salesInvoice-id}/post",
    ];

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public void OnlyUserExcludedTerminalPostPathsAreSuppressedAndOnlyTwoWriteNamesAreRepaired(bool useCollisionData)
    {
        var config = new GeneratorConfig("Microsoft.Graph.PowerShell.Financials.Client", "", UseCollisionData: useCollisionData);
        var operations = BetaDocument.Value.Paths
            .SelectMany(path => path.Value.Operations!.Select(operation => (Path: path.Key, Method: operation.Key)))
            .ToArray();

        Assert.Equal(648, operations.Length);
        Assert.Equal(ExcludedPostPaths.OrderBy(path => path, StringComparer.Ordinal),
            BetaDocument.Value.Paths.Keys.Where(path => path.EndsWith("/post", StringComparison.Ordinal))
                .OrderBy(path => path, StringComparer.Ordinal));
        Assert.Equal(3, operations.Count(operation => ExcludedPostPaths.Contains(operation.Path)));
        Assert.Equal(47, operations.Count(operation => operation.Method == HttpMethod.Post
            && !ExcludedPostPaths.Contains(operation.Path)));
        foreach (var operation in operations)
        {
            Assert.Equal(ExcludedPostPaths.Contains(operation.Path),
                CmdletConfigurator.IsSuppressed(operation.Method, operation.Path, config, apiVersion: "beta"));
            var itemNavigationWrite = operation.Path == "/financials/companies/{company-id}/items/{item-id}/itemCategory"
                && (operation.Method == HttpMethod.Patch || operation.Method == HttpMethod.Delete);
            Assert.Equal(itemNavigationWrite ? "FinancialCompanyItemCategoryByItem" : "FinancialsAuditSentinel",
                CmdletConfigurator.ApplyNounOverrides(operation.Method, operation.Path, "FinancialsAuditSentinel", config, apiVersion: "beta"));
            Assert.Null(CmdletConfigurator.TryGetOverriddenVerb(operation.Method, operation.Path, config, apiVersion: "beta"));
        }
    }

    [Theory]
    [InlineData("GET", "/financials", "financial_GetFinancial", "Get", "MgFinancial")]
    [InlineData("PATCH", "/financials", "financial_UpdateFinancial", "Update", "MgFinancial")]
    [InlineData("GET", "/financials/companies", "financial_ListCompany", "Get", "MgFinancialCompany")]
    [InlineData("GET", "/financials/companies/{company-id}", "financial_GetCompany", "Get", "MgFinancialCompany")]
    [InlineData("GET", "/financials/companies/{company-id}/accounts", "financial.company_ListAccount", "Get", "MgFinancialCompanyAccount")]
    [InlineData("GET", "/financials/companies/{company-id}/accounts/{account-id}", "financial.company_GetAccount", "Get", "MgFinancialCompanyAccount")]
    [InlineData("POST", "/financials/companies/{company-id}/customers", "financial.company_CreateCustomer", "New", "MgFinancialCompanyCustomer")]
    [InlineData("PATCH", "/financials/companies/{company-id}/customers/{customer-id}", "financial.company_UpdateCustomer", "Update", "MgFinancialCompanyCustomer")]
    [InlineData("DELETE", "/financials/companies/{company-id}/customers/{customer-id}", "financial.company_DeleteCustomer", "Remove", "MgFinancialCompanyCustomer")]
    public void NeighboringBetaRoutesKeepTheirOperationIdentityAndName(
        string method, string path, string operationId, string verb, string noun)
    {
        var httpMethod = new HttpMethod(method);
        var operation = BetaDocument.Value.Paths[path].Operations![httpMethod];
        Assert.Equal(operationId, operation.OperationId);

        foreach (var useCollisionData in new[] { true, false })
        {
            var config = new GeneratorConfig("Microsoft.Graph.PowerShell.Financials.Client", "", UseCollisionData: useCollisionData);
            var naming = Naming.Resolve(new OperationInfo(httpMethod, path, HeaderParams: null), config, apiVersion: "beta");
            Assert.Equal(verb, naming.VerbName);
            Assert.Equal(noun, naming.Noun);
            Assert.Equal(path, naming.SourcePath);
            Assert.Equal(method, naming.SourceMethod);
        }
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
    [InlineData("/financials/companies/{company-id}/salesInvoices/{salesInvoice-id}/postAndSend",
        "financial.company.salesInvoice_postAndSend", "InvokeMgFinancialCompanySaleInvoicePostAndSend.g.cs")]
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

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public async Task CompatibleNaturalIdVariantsAndDistinctWritesPreserveAllTwentySevenOperations(bool useCollisionData)
    {
        var groups = CmdletConfigurator.GetOperationVariantGroups()
            .Where(group => group.Routes.All(route => route.Path.StartsWith("/financials/", StringComparison.Ordinal)))
            .ToArray();
        Assert.Equal(9, groups.Length);
        Assert.Equal(23, groups.Sum(group => group.Routes.Count));
        var legacy = LoadDocument("openApiDocs");
        foreach (var route in groups.SelectMany(group => group.Routes))
            Assert.Equal(legacy.Paths[route.Path].Operations![new HttpMethod(route.Method)].OperationId,
                BetaDocument.Value.Paths[route.Path].Operations![new HttpMethod(route.Method)].OperationId);
        await WithGeneratedSources(BetaDocument.Value, output =>
        {
            foreach (var group in groups)
            {
                Assert.Equal("Root", group.DefaultFamily);
                var naming = Naming.Resolve(new OperationInfo(new HttpMethod(group.Routes[0].Method), group.Routes[0].Path),
                    apiVersion: "beta");
                var source = File.ReadAllText(Path.Combine(output, $"{naming.VerbName}{naming.Noun}.g.cs"));
                Assert.Contains("DefaultParameterSetName = \"Root", source, StringComparison.Ordinal);
                Assert.DoesNotContain("public string Route", source, StringComparison.Ordinal);
                foreach (var route in group.Routes)
                {
                    var operation = BetaDocument.Value.Paths[route.Path].Operations![new HttpMethod(route.Method)];
                    Assert.False(string.IsNullOrEmpty(operation.OperationId));
                    Assert.Contains($"[GraphRoute(\"{route.Method}\", \"{route.Path}\", ParameterSetName = \"{route.FamilyName}",
                        source, StringComparison.Ordinal);
                }
            }
            foreach (var verb in new[] { "Update", "Remove" })
            {
                var root = File.ReadAllText(Path.Combine(output, $"{verb}MgFinancialCompanyItemCategory.g.cs"));
                var nested = File.ReadAllText(Path.Combine(output, $"{verb}MgFinancialCompanyItemCategoryByItem.g.cs"));
                Assert.Contains("/financials/companies/{company-id}/itemCategories/{itemCategory-id}", root, StringComparison.Ordinal);
                Assert.Contains("/financials/companies/{company-id}/items/{item-id}/itemCategory", nested, StringComparison.Ordinal);
                Assert.Contains("public string ItemCategoryId", root, StringComparison.Ordinal);
                Assert.Contains("public string ItemId", nested, StringComparison.Ordinal);
            }
        }, useCollisionData);
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public async Task TerminalPostExclusionKeepsSpecAndAllOtherPostCmdletRoutes(bool useCollisionData)
    {
        var excludedIds = new[]
        {
            "financial.company.journal_post",
            "financial.company.purchaseInvoice_post",
            "financial.company.salesInvoice_post",
        };
        for (var index = 0; index < ExcludedPostPaths.Length; index++)
            Assert.Equal(excludedIds[index], BetaDocument.Value.Paths[ExcludedPostPaths[index]].Operations![HttpMethod.Post].OperationId);

        await WithGeneratedSources(BetaDocument.Value, output =>
        {
            var sources = Directory.GetFiles(output, "*.g.cs").Select(File.ReadAllText).ToArray();
            foreach (var path in ExcludedPostPaths)
                Assert.DoesNotContain(sources, source => source.Contains($"[GraphRoute(\"POST\", \"{path}\"", StringComparison.Ordinal));
            foreach (var name in new[] { "JournalPost", "PurchaseInvoicePost", "SaleInvoicePost" })
                Assert.False(File.Exists(Path.Combine(output, $"InvokeMgFinancialCompany{name}.g.cs")));
            var retained = BetaDocument.Value.Paths
                .Where(path => path.Value.Operations!.ContainsKey(HttpMethod.Post) && !ExcludedPostPaths.Contains(path.Key))
                .Select(path => path.Key).ToArray();
            Assert.Equal(47, retained.Length);
            foreach (var path in retained)
                Assert.Contains(sources, source => source.Contains($"[GraphRoute(\"POST\", \"{path}\"", StringComparison.Ordinal));
            Assert.Contains(sources, source => source.Contains("GetRequestAdapter(\"beta\")", StringComparison.Ordinal));
        }, useCollisionData);
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public async Task EveryBetaPatchEmitsOnlyItsOwnOperationWithoutImplicitReadback(bool useCollisionData)
    {
        await WithGeneratedSources(BetaDocument.Value, output =>
        {
            var sources = Directory.GetFiles(output, "*.g.cs").Select(File.ReadAllText).ToArray();
            var paths = BetaDocument.Value.Paths.Where(path => path.Value.Operations!.ContainsKey(HttpMethod.Patch))
                .Select(path => path.Key).ToArray();
            Assert.Equal(131, paths.Length);
            foreach (var path in paths)
            {
                var source = Assert.Single(sources, source =>
                    source.Contains($"[GraphRoute(\"PATCH\", \"{path}\")]", StringComparison.Ordinal));
                Assert.Contains(".PatchAsync(", source, StringComparison.Ordinal);
                Assert.Contains("GetRequestAdapter(\"beta\")", source, StringComparison.Ordinal);
                Assert.Contains("AddRequestHeaders(requestConfiguration.Headers)", source, StringComparison.Ordinal);
                Assert.DoesNotContain(".GetAsync(", source, StringComparison.Ordinal);
                Assert.DoesNotContain("if (result is null)", source, StringComparison.Ordinal);
                Assert.DoesNotContain("PassThru", source, StringComparison.Ordinal);
                Assert.DoesNotContain("ReadBack", source, StringComparison.Ordinal);
                Assert.DoesNotContain("Refetch", source, StringComparison.Ordinal);
                Assert.Contains("if (result is not null)", source, StringComparison.Ordinal);
            }
        }, useCollisionData);
    }

    private static async Task WithGeneratedSources(OpenApiDocument document, Action<string> assertSources, bool useCollisionData = true)
    {
        var output = Path.Combine(Path.GetTempPath(), "financials-directive-tests", Guid.NewGuid().ToString("N"));
        try
        {
            var config = new GeneratorConfig("Microsoft.Graph.PowerShell.Financials.Client", output, UseCollisionData: useCollisionData);
            await new PowerShellWrapperGenerationService(document, config, NullLogger.Instance, apiVersion: "beta")
                .GenerateAsync(CancellationToken.None);
            assertSources(output);
        }
        finally
        {
            if (Directory.Exists(output))
                Directory.Delete(output, recursive: true);
        }
    }

    private static OpenApiDocument LoadBetaDocument() => LoadDocument("openApiDocs_KiotaCompat");

    private static OpenApiDocument LoadDocument(string specRoot)
    {
        var root = new DirectoryInfo(AppContext.BaseDirectory);
        while (root is not null
            && !Directory.Exists(Path.Combine(root.FullName, ".git"))
            && !File.Exists(Path.Combine(root.FullName, ".git")))
            root = root.Parent;
        Assert.NotNull(root);

        // Legacy input is read only for lineage assertions, never as a generation fallback.
        var path = Path.Combine(root.FullName, specRoot, "beta", "Financials.yml");
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
