using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging.Abstractions;
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
            "tenantRelationship_", "DelegatedAdminCustomer", "tenantRelationship.delegatedAdminCustomer_GetCount",
            "TenantRelationshipDelegatedAdminCustomer"),
        ("/tenantRelationships/delegatedAdminCustomers/{delegatedAdminCustomer-id}/serviceManagementDetails",
            "delegatedAdminServiceManagementDetail-id", "tenantRelationship.delegatedAdminCustomer_",
            "ServiceManagementDetail", "tenantRelationship.delegatedAdminCustomer.serviceManagementDetail_GetCount",
            "TenantRelationshipDelegatedAdminCustomerServiceManagementDetail"),
        ("/tenantRelationships/delegatedAdminRelationships", "delegatedAdminRelationship-id",
            "tenantRelationship_", "DelegatedAdminRelationship", "tenantRelationship.delegatedAdminRelationship_GetCount",
            "TenantRelationshipDelegatedAdminRelationship"),
        ("/tenantRelationships/delegatedAdminRelationships/{delegatedAdminRelationship-id}/accessAssignments",
            "delegatedAdminAccessAssignment-id", "tenantRelationship.delegatedAdminRelationship_",
            "AccessAssignment", "tenantRelationship.delegatedAdminRelationship.accessAssignment_GetCount",
            "TenantRelationshipDelegatedAdminRelationshipAccessAssignment"),
        ("/tenantRelationships/delegatedAdminRelationships/{delegatedAdminRelationship-id}/operations",
            "delegatedAdminRelationshipOperation-id", "tenantRelationship.delegatedAdminRelationship_",
            "Operation", "tenantRelationship.delegatedAdminRelationship.operation_GetCount",
            "TenantRelationshipDelegatedAdminRelationshipOperation"),
        ("/tenantRelationships/delegatedAdminRelationships/{delegatedAdminRelationship-id}/requests",
            "delegatedAdminRelationshipRequest-id", "tenantRelationship.delegatedAdminRelationship_",
            "Request", "tenantRelationship.delegatedAdminRelationship.request_GetCount",
            "TenantRelationshipDelegatedAdminRelationshipRequest"),
    ];

    [Fact]
    public void SharedAuditHasNoDirectivesOrInventedMappings()
    {
        var moduleRoot = Path.Combine(FindRepoRoot(), "src", "Identity.Partner");
        var audit = File.ReadAllText(Path.Combine(moduleRoot, "Identity.Partner.md"));
        Assert.DoesNotMatch(@"(?m)^\s*directive:\s*$", audit);
        Assert.Matches(@"(?m)^require:\r?\n  - \$\(this-folder\)/\.\./readme\.graph\.md\r?$", audit);

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
            AssertOperation(HttpMethod.Get, route.Collection + "/$count", route.CountSuffix, "Get", route.Noun + "Count",
                fullOperationId: true);

            void AssertOperation(HttpMethod method, string path, string operationSuffix, string verb, string noun,
                bool fullOperationId = false)
            {
                Assert.True(document.Paths.TryGetValue(path, out var pathItem), $"Missing {profile} path: {path}");
                Assert.NotNull(pathItem.Operations);
                Assert.True(pathItem.Operations.TryGetValue(method, out var operation),
                    $"Missing {profile} operation: {method} {path}");
                Assert.Equal(fullOperationId ? operationSuffix : route.OperationPrefix + operationSuffix,
                    operation.OperationId);

                foreach (var useCollisionData in new[] { false, true })
                {
                    var config = new GeneratorConfig("Test.Client", "unused", useCollisionData);
                    Assert.False(CmdletConfigurator.IsSuppressed(method, path, config, apiVersion: profile),
                        $"Unexpected {profile} suppression: {method} {path}");
                    Assert.Null(CmdletConfigurator.TryGetOverriddenVerb(method, path, config, apiVersion: profile));
                    Assert.Equal(noun, CmdletConfigurator.ApplyNounOverrides(method, path, noun, config,
                        apiVersion: profile));
                    var naming = Naming.Resolve(new OperationInfo(method, path), config, apiVersion: profile);
                    Assert.Equal(verb, naming.VerbName);
                    Assert.Equal("Mg" + noun, naming.Noun);
                }
            }

            var output = Path.Combine(Path.GetTempPath(), "IdentityPartnerProfile-" + Guid.NewGuid().ToString("N"));
            try
            {
                var config = new GeneratorConfig("Test.Client", output);
                var service = new PowerShellWrapperGenerationService(document, config, NullLogger.Instance,
                    apiVersion: profile);
                await service.GenerateAsync(TestContext.Current.CancellationToken);
                var sources = Directory.GetFiles(output, "*.g.cs").Select(File.ReadAllText).ToArray();
                Assert.Equal(42, sources.Length);
                var transportSources = sources.Where(source => source.Contains("GetRequestAdapter(", StringComparison.Ordinal))
                    .ToArray();
                Assert.Equal(36, transportSources.Length);
                Assert.All(transportSources, source =>
                {
                    Assert.Contains($"GetRequestAdapter(\"{profile}\")", source, StringComparison.Ordinal);
                    Assert.DoesNotContain("GetRequestAdapter()", source, StringComparison.Ordinal);
                });
            }
            finally
            {
                if (Directory.Exists(output))
                    Directory.Delete(output, recursive: true);
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
