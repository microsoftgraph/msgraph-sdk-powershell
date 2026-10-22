using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Reader;
using WrapperGenerator;
using Xunit;

namespace WrapperGenerator.Tests;

public sealed class IdentityPartnerDirectiveMigrationTests
{
    private static readonly (string Collection, string ItemParameter, string OperationPrefix,
        string Resource, string CountSuffix, string Noun)[] Routes =
    [
        ("/tenantRelationships/delegatedAdminCustomers", "delegatedAdminCustomer-id",
            "tenantRelationships.", "DelegatedAdminCustomers", "delegatedAdminCustomers.GetCount-e293",
            "TenantRelationshipDelegatedAdminCustomer"),
        ("/tenantRelationships/delegatedAdminCustomers/{delegatedAdminCustomer-id}/serviceManagementDetails",
            "delegatedAdminServiceManagementDetail-id", "tenantRelationships.delegatedAdminCustomers.",
            "ServiceManagementDetails", "serviceManagementDetails.GetCount-d662",
            "TenantRelationshipDelegatedAdminCustomerServiceManagementDetail"),
        ("/tenantRelationships/delegatedAdminRelationships", "delegatedAdminRelationship-id",
            "tenantRelationships.", "DelegatedAdminRelationships", "delegatedAdminRelationships.GetCount-9d12",
            "TenantRelationshipDelegatedAdminRelationship"),
        ("/tenantRelationships/delegatedAdminRelationships/{delegatedAdminRelationship-id}/accessAssignments",
            "delegatedAdminAccessAssignment-id", "tenantRelationships.delegatedAdminRelationships.",
            "AccessAssignments", "accessAssignments.GetCount-8cbf",
            "TenantRelationshipDelegatedAdminRelationshipAccessAssignment"),
        ("/tenantRelationships/delegatedAdminRelationships/{delegatedAdminRelationship-id}/operations",
            "delegatedAdminRelationshipOperation-id", "tenantRelationships.delegatedAdminRelationships.",
            "Operations", "operations.GetCount-3beb", "TenantRelationshipDelegatedAdminRelationshipOperation"),
        ("/tenantRelationships/delegatedAdminRelationships/{delegatedAdminRelationship-id}/requests",
            "delegatedAdminRelationshipRequest-id", "tenantRelationships.delegatedAdminRelationships.",
            "Requests", "requests.GetCount-f3a6", "TenantRelationshipDelegatedAdminRelationshipRequest"),
    ];

    [Fact]
    public void SharedAuditHasNoDirectivesOrInventedMappings()
    {
        var moduleRoot = Path.Combine(FindRepoRoot(), "src", "Identity.Partner");
        var audit = File.ReadAllText(Path.Combine(moduleRoot, "Identity.Partner.md"));
        Assert.DoesNotMatch(@"(?m)^\s*directive:\s*$", audit);

        using var ledger = JsonDocument.Parse(File.ReadAllText(
            Path.Combine(moduleRoot, "wrapper", "Identity.Partner_directiveMigrationMap.json")));
        Assert.Empty(ledger.RootElement.GetProperty("mappings").EnumerateArray());
    }

    [Theory]
    [InlineData("v1.0")]
    [InlineData("beta")]
    public async Task RealCompatibleOperationsRemainUnsuppressedAndStructurallyNamed(string profile)
    {
        var specPath = Path.Combine(FindRepoRoot(), "openApiDocs_KiotaCompat", profile, "Identity.Partner.yml");
        Assert.True(File.Exists(specPath), $"Required compatible specification missing: {specPath}");
        var settings = new OpenApiReaderSettings();
        settings.AddYamlReader();
        await using var stream = File.OpenRead(specPath);
        var result = await OpenApiDocument.LoadAsync(stream, settings: settings,
            cancellationToken: TestContext.Current.CancellationToken);
        var document = Assert.IsType<OpenApiDocument>(result.Document);
        Assert.NotNull(document.Paths);
        Assert.Equal(18, document.Paths.Count);
        Assert.Equal(36, document.Paths.Sum(path => path.Value.Operations!.Count));

        foreach (var route in Routes)
        {
            var itemPath = route.Collection + "/{" + route.ItemParameter + "}";
            AssertOperation(HttpMethod.Get, route.Collection, "List" + route.Resource, "Get", route.Noun);
            AssertOperation(HttpMethod.Post, route.Collection, "Create" + route.Resource, "New", route.Noun);
            AssertOperation(HttpMethod.Get, itemPath, "Get" + route.Resource, "Get", route.Noun);
            AssertOperation(HttpMethod.Patch, itemPath, "Update" + route.Resource, "Update", route.Noun);
            AssertOperation(HttpMethod.Delete, itemPath, "Delete" + route.Resource, "Remove", route.Noun);
            AssertOperation(HttpMethod.Get, route.Collection + "/$count", route.CountSuffix, "Get", route.Noun + "Count");

            void AssertOperation(HttpMethod method, string path, string operationSuffix, string verb, string noun)
            {
                Assert.True(document.Paths.TryGetValue(path, out var pathItem), $"Missing {profile} path: {path}");
                Assert.NotNull(pathItem.Operations);
                Assert.True(pathItem.Operations.TryGetValue(method, out var operation),
                    $"Missing {profile} operation: {method} {path}");
                Assert.Equal(route.OperationPrefix + operationSuffix, operation.OperationId);

                foreach (var useCollisionData in new[] { false, true })
                {
                    var config = new GeneratorConfig("Test.Client", "unused", profile, useCollisionData);
                    Assert.False(CmdletConfigurator.IsSuppressed(method, path, config),
                        $"Unexpected {profile} suppression: {method} {path}");
                    Assert.Null(CmdletConfigurator.TryGetOverriddenVerb(method, path, config));
                    Assert.Equal(noun, CmdletConfigurator.ApplyNounOverrides(method, path, noun, config));
                    var naming = Naming.Resolve(new OperationInfo(method, path), config);
                    Assert.Equal(verb, naming.VerbName);
                    Assert.Equal("Mg" + noun, naming.Noun);
                }
            }
        }
    }

    private static string FindRepoRoot()
    {
        var directory = new DirectoryInfo(AppContext.BaseDirectory);
        while (directory is not null
            && !Directory.Exists(Path.Combine(directory.FullName, ".git"))
            && !File.Exists(Path.Combine(directory.FullName, ".git")))
            directory = directory.Parent;
        return directory?.FullName
            ?? throw new InvalidOperationException("Could not locate repository root from " + AppContext.BaseDirectory);
    }
}
