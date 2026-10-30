using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Reader;
using WrapperGenerator;
using Xunit;

namespace WrapperGenerator.Tests;

public sealed class IdentityGovernanceDirectiveMigrationTests
{
    private const string EntitlementManagement = "/identityGovernance/entitlementManagement";
    private static readonly string[] PrivilegedAssignmentGetRoutes =
    [
        "/privilegedRoleAssignments",
        "/privilegedRoleAssignments/{privilegedRoleAssignment-id}",
        "/privilegedRoles/{privilegedRole-id}/assignments",
        "/privilegedRoles/{privilegedRole-id}/assignments/{privilegedRoleAssignment-id}",
    ];
    private static readonly Lazy<JsonDocument> Ledger = new(() => JsonDocument.Parse(File.ReadAllText(
        Path.Combine(FindRepoRoot(), "src", "Identity.Governance", "wrapper", "Identity.Governance_directiveMigrationMap.json"))));
    private static readonly Dictionary<string, Lazy<Task<OpenApiDocument>>> Specs = new()
    {
        ["v1.0"] = new(() => LoadSpecAsync("v1.0")),
        ["beta"] = new(() => LoadSpecAsync("beta")),
    };
    private static readonly Dictionary<string, Lazy<Task<OpenApiDocument>>> LegacySpecs = new()
    {
        ["v1.0"] = new(() => LoadSpecAsync("v1.0", legacyEvidence: true)),
        ["beta"] = new(() => LoadSpecAsync("beta", legacyEvidence: true)),
    };

    [Fact]
    public void AccountsForAllSeventyActiveSharedGroupsAndExplicitDeferrals()
    {
        var mappings = Ledger.Value.RootElement.GetProperty("mappings").EnumerateArray().ToArray();
        Assert.Equal(Enumerable.Range(1, 70), mappings.Select(m => m.GetProperty("directiveIndex").GetInt32()));
        var source = File.ReadAllText(Path.Combine(FindRepoRoot(), "src", "Identity.Governance", "Identity.Governance.md"));
        Assert.Equal(70, Regex.Matches(source, @"(?m)^  - (?:where:|remove-path-by-operation:)").Count);
        Assert.Equal(70, Regex.Matches(source, @"(?m)^# Wrapper migration \d+:").Count);
        foreach (var mapping in mappings)
            Assert.Contains(mapping.GetProperty("sourceContains").GetString()!, source, StringComparison.Ordinal);
        var scope = Ledger.Value.RootElement.GetProperty("scope");
        Assert.Empty(scope.GetProperty("deferredParameterDirectives").EnumerateArray());
        Assert.Empty(scope.GetProperty("deferredSchemaDirectives").EnumerateArray());
        Assert.Equal(3, scope.GetProperty("ignored").GetArrayLength());
        Assert.Contains("remain deferred", scope.GetProperty("deferralPolicy").GetString()!, StringComparison.Ordinal);
    }

    [Theory]
    [InlineData("v1.0", 2670)]
    [InlineData("beta", 3258)]
    public async Task EveryReviewedOperationHasExactCompatibleEvidenceAndItsReviewedOutcome(string profile, int operationCount)
    {
        var document = await Specs[profile].Value;
        Assert.Equal(operationCount, Operations(document).Count());
        var config = Config();
        foreach (var mapping in Ledger.Value.RootElement.GetProperty("mappings").EnumerateArray())
        {
            var profileMap = mapping.GetProperty("profiles").GetProperty(profile);
            var operations = profileMap.GetProperty("operations").EnumerateArray().ToArray();
            Assert.Equal(operations.Length == 0, profileMap.GetProperty("absenceExpected").GetBoolean());
            foreach (var evidence in operations)
            {
                var path = evidence.GetProperty("path").GetString()!;
                var method = new HttpMethod(evidence.GetProperty("method").GetString()!);
                Assert.True(document.Paths.TryGetValue(path, out var item), $"Missing {profile} {method} {path}");
                Assert.True(item!.Operations!.TryGetValue(method, out var operation), $"Missing {profile} {method} {path}");
                Assert.Equal(evidence.GetProperty("operationId").GetString(), operation!.OperationId);
                var index = mapping.GetProperty("directiveIndex").GetInt32();
                if (mapping.GetProperty("implementation").GetString() == "CmdletConfigurator" && index <= 63)
                    Assert.True(CmdletConfigurator.IsSuppressed(method, path, config, apiVersion: profile), $"Group {index}: {profile} {method} {path}");
                if (mapping.GetProperty("implementation").GetString() == "StructuralNaming")
                    Assert.False(CmdletConfigurator.IsSuppressed(method, path, config, apiVersion: profile), $"Group {index} must preserve {profile} {method} {path}");
                if (index == 70)
                    Assert.DoesNotContain("IdentityGovernance", CmdletConfigurator.ApplyNounOverrides(
                        method, path, "IdentityGovernanceEntitlementManagementProbe", config, apiVersion: profile), StringComparison.Ordinal);
            }
        }
    }

    [Theory]
    [InlineData("v1.0", 237)]
    [InlineData("beta", 1061)]
    public async Task OriginalOperationIdSuppressionAccountsForEveryActualLegacyMatch(string profile, int count)
    {
        var mapping = Ledger.Value.RootElement.GetProperty("mappings")[0];
        var source = mapping.GetProperty("sourceContains").GetString()!;
        var regex = new Regex(source["remove-path-by-operation: ".Length..]);
        var profileMap = mapping.GetProperty("profiles").GetProperty(profile);
        Assert.Equal("Legacy", profileMap.GetProperty("operationIdSource").GetString());
        var legacy = await LegacySpecs[profile].Value;
        var current = Operations(await Specs[profile].Value).ToArray();
        var actual = Operations(legacy)
            .Where(o => regex.IsMatch(o.Operation.OperationId!))
            .Select(o => $"{o.Method} {o.Path} [{o.Operation.OperationId}]").ToHashSet(StringComparer.Ordinal);
        var reviewed = new HashSet<string>(StringComparer.Ordinal);
        foreach (var evidence in profileMap.GetProperty("operations").EnumerateArray())
        {
            var method = new HttpMethod(evidence.GetProperty("method").GetString()!);
            var path = evidence.GetProperty("path").GetString()!;
            var oldPath = evidence.GetProperty("legacyPath").GetString()!;
            var oldId = evidence.GetProperty("legacyOperationId").GetString()!;
            Assert.Equal(oldId, legacy.Paths[oldPath].Operations![method].OperationId);
            Assert.Matches(regex, oldId);
            var selectorPath = oldPath;
            if (evidence.TryGetProperty("legacyPathTranslation", out var translation))
            {
                Assert.Equal("UnqualifyFinalOperation", translation.GetString());
                selectorPath = Regex.Replace(oldPath, @"/microsoft\.graph\.([^/]+)$", "/$1");
                Assert.NotEqual(oldPath, selectorPath);
                var kind = GraphOperationType(legacy.Paths[oldPath].Operations![method]);
                Assert.Contains(kind, new[] { "action", "function" });
                Assert.Equal(kind, GraphOperationType(current.Single(o => o.Method == method && o.Path == path).Operation));
                Assert.Equal(kind == "action" ? HttpMethod.Post : HttpMethod.Get, method);
            }
            Assert.Equal(NormalizeLegacyPath(selectorPath), NormalizeLegacyPath(path));
            Assert.Single(current, o => o.Method == method && NormalizeLegacyPath(o.Path) == NormalizeLegacyPath(selectorPath));
            Assert.True(reviewed.Add($"{method} {oldPath} [{oldId}]"));
        }
        foreach (var evidence in profileMap.GetProperty("removedLegacyOperations").EnumerateArray())
        {
            var method = new HttpMethod(evidence.GetProperty("method").GetString()!);
            var path = evidence.GetProperty("path").GetString()!;
            var id = evidence.GetProperty("operationId").GetString()!;
            Assert.Equal(id, legacy.Paths[path].Operations![method].OperationId);
            Assert.Matches(regex, id);
            Assert.DoesNotContain(current, o => o.Method == method && NormalizeLegacyPath(o.Path) == NormalizeLegacyPath(path));
            Assert.False(string.IsNullOrWhiteSpace(evidence.GetProperty("notes").GetString()));
            Assert.True(reviewed.Add($"{method} {path} [{id}]"));
        }
        Assert.Equal(count, actual.Count);
        Assert.True(actual.SetEquals(reviewed), $"{profile} legacy source regex matches are not fully accounted.");
    }

    [Theory]
    [InlineData("v1.0")]
    [InlineData("beta")]
    public async Task SurvivingUnqualifiedActionsAreNotMisreportedAsRemovedLegacyOperations(string profile)
    {
        var current = Operations(await Specs[profile].Value).ToArray();
        var removed = Ledger.Value.RootElement.GetProperty("mappings")[0]
            .GetProperty("profiles").GetProperty(profile).GetProperty("removedLegacyOperations");
        foreach (var evidence in removed.EnumerateArray())
        {
            var method = new HttpMethod(evidence.GetProperty("method").GetString()!);
            var path = evidence.GetProperty("path").GetString()!;
            var unqualified = Regex.Replace(path, @"/microsoft\.graph\.([^/]+)$", "/$1");
            Assert.DoesNotContain(current, o => o.Method == method &&
                NormalizeLegacyPath(o.Path) == NormalizeLegacyPath(unqualified));
        }
    }

    [Theory]
    [InlineData("v1.0", 4)]
    [InlineData("beta", 74)]
    public async Task QualifiedOperationSuccessorsHaveActualActionOrFunctionMetadataOnBothSides(string profile, int expectedCount)
    {
        var mapping = Ledger.Value.RootElement.GetProperty("mappings")[0];
        var source = mapping.GetProperty("sourceContains").GetString()!;
        var regex = new Regex(source["remove-path-by-operation: ".Length..]);
        var current = Operations(await Specs[profile].Value).ToArray();
        var count = 0;
        foreach (var old in Operations(await LegacySpecs[profile].Value).Where(o => regex.IsMatch(o.Operation.OperationId!)))
        {
            var unqualified = Regex.Replace(old.Path, @"/microsoft\.graph\.([^/]+)$", "/$1");
            if (unqualified == old.Path)
                continue;
            var successors = current.Where(o => o.Method == old.Method &&
                NormalizeLegacyPath(o.Path) == NormalizeLegacyPath(unqualified)).ToArray();
            if (successors.Length == 0)
                continue;
            var successor = Assert.Single(successors);
            var kind = GraphOperationType(old.Operation);
            Assert.Contains(kind, new[] { "action", "function" });
            Assert.Equal(kind, GraphOperationType(successor.Operation));
            Assert.Equal(kind == "action" ? HttpMethod.Post : HttpMethod.Get, old.Method);
            count++;
        }
        Assert.Equal(expectedCount, count);
    }

    [Theory]
    [InlineData("v1.0")]
    [InlineData("beta")]
    public async Task AbsentSelectorsDoNotHideCompatibleEntityOrReferenceOperations(string profile)
    {
        var selectors = new Dictionary<int, (string Path, string Methods)>
        {
            [2] = (@"accessPackages/\{\}/accessPackageCatalog/\$ref", "GET|PUT|DELETE"),
            [3] = (@"accessPackages/\{\}/catalog/\$ref", "GET|PUT|DELETE"),
            [5] = (@"assignments/\{\}/accessPackage/\$ref", "GET|PUT|DELETE"),
            [7] = (@"accessPackageAssignments/\{\}/accessPackageAssignmentPolicy", "GET|PATCH|DELETE"),
            [8] = (@"accessPackageAssignments/\{\}/accessPackageAssignmentRequests(?:/\{\})?", "GET|POST|PATCH|DELETE"),
            [13] = (@"accessPackages/\{\}/assignmentPolicies/\{\}/accessPackage/\$ref", "GET|PUT|DELETE"),
            [15] = (@"accessPackageAssignmentRequests/\{\}/accessPackage", "GET"),
            [17] = (@"accessPackageAssignmentRequests/\{\}/accessPackageAssignment", "GET|PATCH|DELETE"),
            [19] = (@"accessPackageAssignmentRequests/\{\}/accessPackage/\$ref", "GET|PUT|DELETE"),
            [20] = (@"assignmentRequests/\{\}/accessPackage/\$ref", "GET|PUT|DELETE"),
            [21] = (@"assignmentRequests/\{\}/assignment/\$ref", "GET|PUT|DELETE"),
            [22] = (@"assignmentRequests/\{\}/requestor/\$ref", "GET|PUT|DELETE"),
            [23] = (@"accessPackageAssignmentRequests/\{\}/requestor", "GET|PATCH|DELETE"),
            [31] = (@"assignments/\{\}/target/\$ref", "GET|PUT|DELETE"),
            [32] = (@"accessPackageCatalogs/\{\}/accessPackages(?:/\{\})?", "GET|POST|PATCH|DELETE"),
            [33] = (@"catalogs/\{\}/accessPackages(?:/\{\})?/\$ref", "GET|PUT|DELETE"),
            [35] = (@"catalogs/\{\}/accessPackages/\{\}/catalog", "GET"),
            [37] = (@"accessPackageResources/\{\}/accessPackageResourceEnvironment/\$ref", "GET|PUT|DELETE"),
            [41] = (@"accessPackageResourceEnvironments/\{\}/accessPackageResources(?:/\{\})?/\$ref", "GET|POST"),
            [43] = (@"accessPackageResourceRequests/\{\}/accessPackageResource/\$ref", "GET|PUT|DELETE"),
            [48] = (@"accessPackageCatalogs/\{\}/accessPackageResourceRoles(?:/\{\})?", "GET|POST|PATCH|DELETE"),
            [49] = (@"accessPackageCatalogs/\{\}/accessPackageResourceScopes(?:/\{\})?", "GET|POST|PATCH|DELETE"),
            [54] = (@"accessPackageCatalogs/\{\}/accessPackageResources(?:/\{\})?", "GET|POST|PATCH|DELETE"),
            [61] = (@"connectedOrganizations/\{\}/(?:internalSponsors|externalSponsors)(?:/\{\})?", "POST|PATCH|DELETE"),
        };
        var absent = Ledger.Value.RootElement.GetProperty("mappings").EnumerateArray()
            .Where(m => m.GetProperty("implementation").GetString() == "NoCompatibleOperation")
            .Select(m => m.GetProperty("directiveIndex").GetInt32()).OrderBy(i => i);
        Assert.Equal(selectors.Keys.OrderBy(i => i), absent);
        var operations = Operations(await Specs[profile].Value).ToArray();
        foreach (var (index, selector) in selectors)
        {
            var pathRegex = new Regex($"^{EntitlementManagement}/{selector.Path}$", RegexOptions.CultureInvariant);
            var methods = selector.Methods.Split('|');
            Assert.DoesNotContain(operations, o => methods.Contains(o.Method.Method, StringComparer.Ordinal) &&
                pathRegex.IsMatch(Regex.Replace(o.Path, @"\{[^}]+\}", "{}")));
            Assert.True(Ledger.Value.RootElement.GetProperty("mappings")[index - 1]
                .GetProperty("profiles").GetProperty(profile).GetProperty("absenceExpected").GetBoolean());
        }
    }

    [Theory]
    [InlineData("v1.0")]
    [InlineData("beta")]
    public async Task ExactSuppressionsPreserveNeighboringMethodsCollectionsReferencesAndDescendants(string profile)
    {
        var document = await Specs[profile].Value;
        var config = Config();
        var neighbors = new List<(HttpMethod Method, string Path)>
        {
            (HttpMethod.Get, EntitlementManagement + "/settings"),
            (HttpMethod.Patch, EntitlementManagement + "/settings"),
            (HttpMethod.Patch, EntitlementManagement + "/accessPackageAssignmentApprovals/{approval-id}"),
            (HttpMethod.Delete, EntitlementManagement + "/accessPackageAssignmentApprovals/{approval-id}"),
            (HttpMethod.Get, EntitlementManagement + "/accessPackageAssignmentApprovals/$count"),
            (HttpMethod.Get, EntitlementManagement + "/accessPackageAssignmentApprovals/filterByCurrentUser(on='{on}')"),
            (HttpMethod.Get, EntitlementManagement + "/accessPackages"),
            (HttpMethod.Get, EntitlementManagement + "/accessPackages/filterByCurrentUser(on='{on}')"),
            (HttpMethod.Get, EntitlementManagement + "/connectedOrganizations/{connectedOrganization-id}/externalSponsors"),
            (HttpMethod.Post, EntitlementManagement + "/connectedOrganizations/{connectedOrganization-id}/externalSponsors/$ref"),
            (HttpMethod.Delete, EntitlementManagement + "/connectedOrganizations/{connectedOrganization-id}/externalSponsors/{directoryObject-id}/$ref"),
            (HttpMethod.Get, "/agreements/{agreement-id}/files"),
            (HttpMethod.Post, "/agreements/{agreement-id}/files"),
            (HttpMethod.Patch, "/agreements/{agreement-id}/file"),
            (HttpMethod.Delete, "/agreements/{agreement-id}/file"),
            (HttpMethod.Get, "/agreements/{agreement-id}/files/{agreementFileLocalization-id}/versions"),
            (HttpMethod.Get, "/identityGovernance/accessReviews/definitions"),
            (HttpMethod.Get, "/identityGovernance/appConsent/appConsentRequests"),
        };
        if (profile == "v1.0")
        {
            neighbors.AddRange([
                (HttpMethod.Post, EntitlementManagement + "/assignments"),
                (HttpMethod.Delete, EntitlementManagement + "/assignments/{accessPackageAssignment-id}"),
                (HttpMethod.Get, EntitlementManagement + "/accessPackages/{accessPackage-id}/catalog"),
                (HttpMethod.Get, EntitlementManagement + "/catalogs"),
                (HttpMethod.Post, EntitlementManagement + "/catalogs"),
                (HttpMethod.Get, EntitlementManagement + "/catalogs/{accessPackageCatalog-id}/resourceRoles"),
                (HttpMethod.Get, EntitlementManagement + "/catalogs/{accessPackageCatalog-id}/resourceRoles/{accessPackageResourceRole-id}"),
                (HttpMethod.Post, EntitlementManagement + "/catalogs/{accessPackageCatalog-id}/resourceRoles"),
                (HttpMethod.Get, EntitlementManagement + "/catalogs/{accessPackageCatalog-id}/resourceScopes"),
                (HttpMethod.Get, EntitlementManagement + "/catalogs/{accessPackageCatalog-id}/resources"),
                (HttpMethod.Get, EntitlementManagement + "/catalogs/{accessPackageCatalog-id}/accessPackages/$count"),
                (HttpMethod.Get, EntitlementManagement + "/accessPackageAssignmentApprovals/{approval-id}/stages"),
                (HttpMethod.Post, EntitlementManagement + "/accessPackageAssignmentApprovals/{approval-id}/stages"),
            ]);
        }
        else
        {
            neighbors.AddRange([
                (HttpMethod.Get, EntitlementManagement + "/accessPackageAssignments"),
                (HttpMethod.Patch, EntitlementManagement + "/accessPackageAssignments/{accessPackageAssignment-id}"),
                (HttpMethod.Get, EntitlementManagement + "/accessPackageAssignmentResourceRoles"),
                (HttpMethod.Get, EntitlementManagement + "/accessPackageAssignmentResourceRoles/My()"),
                (HttpMethod.Get, EntitlementManagement + "/accessPackageResources"),
                (HttpMethod.Get, EntitlementManagement + "/accessPackageResourceEnvironments"),
                (HttpMethod.Get, "/privilegedRoleAssignments"),
                (HttpMethod.Patch, "/privilegedAccess/{privilegedAccess-id}/roleAssignmentRequests/{governanceRoleAssignmentRequest-id}"),
                (HttpMethod.Post, "/privilegedAccess/{privilegedAccess-id}/roleAssignmentRequests/{governanceRoleAssignmentRequest-id}/updateRequest"),
                (HttpMethod.Patch, "/privilegedAccess/{privilegedAccess-id}/resources/{governanceResource-id}/roleAssignmentRequests/{governanceRoleAssignmentRequest-id}"),
            ]);
        }
        foreach (var (method, path) in neighbors)
        {
            Assert.True(document.Paths.TryGetValue(path, out var item) && item.Operations!.ContainsKey(method),
                $"Neighbor is not actual {profile} evidence: {method} {path}");
            Assert.False(CmdletConfigurator.IsSuppressed(method, path, config, apiVersion: profile), $"Unexpected suppression: {profile} {method} {path}");
        }
    }

    [Theory]
    [InlineData("GET", "/accessPackageAssignments/{accessPackageAssignment-id}/target/connectedOrganization",
        "identityGovernance.entitlementManagement.accessPackageAssignment.target_GetConnectedOrganization")]
    [InlineData("GET", "/accessPackageAssignments/{accessPackageAssignment-id}/accessPackageAssignmentResourceRoles/$count",
        "identityGovernance.entitlementManagement.accessPackageAssignment.accessPackageAssignmentResourceRole_GetCount")]
    [InlineData("POST", "/accessPackageResourceRoleScopes",
        "identityGovernance.entitlementManagement_CreateAccessPackageResourceRoleScope")]
    [InlineData("PATCH", "/accessPackageResourceRoleScopes/{accessPackageResourceRoleScope-id}",
        "identityGovernance.entitlementManagement_UpdateAccessPackageResourceRoleScope")]
    [InlineData("GET", "/accessPackageResources/{accessPackageResource-id}/accessPackageResourceRoles/$count",
        "identityGovernance.entitlementManagement.accessPackageResource.accessPackageResourceRole_GetCount")]
    [InlineData("GET", "/accessPackageResources/{accessPackageResource-id}/accessPackageResourceRoles/{accessPackageResourceRole-id}/accessPackageResource",
        "identityGovernance.entitlementManagement.accessPackageResource.accessPackageResourceRole_GetAccessPackageResource")]
    public void ActualLegacyRegexSuppressesSelectedDescendantCountsAndRoleScopeMutations(
        string method, string tail, string legacyOperationId)
    {
        var mapping = Ledger.Value.RootElement.GetProperty("mappings")[0];
        Assert.Contains(mapping.GetProperty("profiles").GetProperty("beta").GetProperty("operations").EnumerateArray(),
            o => o.GetProperty("method").GetString() == method && o.GetProperty("path").GetString() == EntitlementManagement + tail &&
                o.GetProperty("legacyOperationId").GetString() == legacyOperationId);
        Assert.True(CmdletConfigurator.IsSuppressed(new HttpMethod(method), EntitlementManagement + tail, Config(), apiVersion: "beta"));
    }

    [Theory]
    [InlineData("v1.0", "/accessPackages/{accessPackage-id}/resourceRoleScopes")]
    [InlineData("v1.0", "/accessPackages/{accessPackage-id}/resourceRoleScopes/{accessPackageResourceRoleScope-id}")]
    [InlineData("beta", "/accessPackageResourceRoleScopes")]
    [InlineData("beta", "/accessPackageResourceRoleScopes/{accessPackageResourceRoleScope-id}")]
    public void RoleScopeWhereSelectorCoversBothActualLegacySubjectLineages(string profile, string tail)
    {
        var operations = Ledger.Value.RootElement.GetProperty("mappings")[44]
            .GetProperty("profiles").GetProperty(profile).GetProperty("operations");
        Assert.Contains(operations.EnumerateArray(),
            o => o.GetProperty("method").GetString() == "GET" && o.GetProperty("path").GetString() == EntitlementManagement + tail);
        Assert.True(CmdletConfigurator.IsSuppressed(HttpMethod.Get, EntitlementManagement + tail, Config(), apiVersion: profile));
    }

    [Theory]
    [InlineData("v1.0")]
    [InlineData("beta")]
    public void PrefixRenameAppliesWithoutDerivedDataAndDoesNotLeakToOtherBranches(string profile)
    {
        var config = Config(useCollisionData: false);
        Assert.Equal("MgEntitlementManagementAccessPackage", Naming.Resolve(
            new OperationInfo(HttpMethod.Get, EntitlementManagement + "/accessPackages"), config, apiVersion: profile).Noun);
        Assert.Equal("MgEntitlementManagementAccessPackageGetApplicablePolicyRequirements", Naming.Resolve(
            new OperationInfo(HttpMethod.Post, EntitlementManagement + "/accessPackages/{accessPackage-id}/getApplicablePolicyRequirements",
                Kind: OperationKind.Action), config, apiVersion: profile).Noun);
        Assert.Equal("MgEntitlementManagementAccessPackageFilterByCurrentUserWithOn", Naming.Resolve(
            new OperationInfo(HttpMethod.Get, EntitlementManagement + "/accessPackages/filterByCurrentUser(on='{on}')",
                Kind: OperationKind.Function), config, apiVersion: profile).Noun);
        Assert.Equal("MgIdentityGovernanceAccessReviewDefinition", Naming.Resolve(
            new OperationInfo(HttpMethod.Get, "/identityGovernance/accessReviews/definitions"), config, apiVersion: profile).Noun);
        Assert.Equal("IdentityGovernanceEntitlementManagementOther", CmdletConfigurator.ApplyNounOverrides(
            HttpMethod.Get, EntitlementManagement + "Other", "IdentityGovernanceEntitlementManagementOther", config, apiVersion: profile));
    }

    [Fact]
    public void ExistingDerivedNamesRemainAuthoritativeOverTheSharedPrefixRule()
    {
        const string path = EntitlementManagement + "/catalogs/{accessPackageCatalog-id}/resourceRoles";
        Assert.Equal("EntitlementManagementCatalogResourceRole", CmdletConfigurator.ApplyNounOverrides(
            HttpMethod.Get, path, "IdentityGovernanceEntitlementManagementProbe", Config(), apiVersion: "v1.0"));
        Assert.Equal("EntitlementManagementProbe", CmdletConfigurator.ApplyNounOverrides(
            HttpMethod.Get, path, "IdentityGovernanceEntitlementManagementProbe", Config(useCollisionData: false), apiVersion: "v1.0"));
    }

    [Fact]
    public void NumberedLegacyRequestUpdatesDoNotMergeDistinctCompatibleRoutes()
    {
        const string root = "/privilegedAccess/{privilegedAccess-id}";
        var direct = Naming.Resolve(new OperationInfo(HttpMethod.Patch,
            root + "/roleAssignmentRequests/{governanceRoleAssignmentRequest-id}"), Config(), apiVersion: "beta");
        var nested = Naming.Resolve(new OperationInfo(HttpMethod.Patch,
            root + "/resources/{governanceResource-id}/roleAssignmentRequests/{governanceRoleAssignmentRequest-id}"), Config(), apiVersion: "beta");
        Assert.Equal("MgPrivilegedAccessRoleAssignmentRequest", direct.Noun);
        Assert.Equal("MgPrivilegedAccessResourceRoleAssignmentRequest", nested.Noun);
        Assert.NotEqual(direct.ClassName, nested.ClassName);
    }

    [Theory]
    [InlineData("/businessFlowTemplates", "MgBusinessFlowTemplate")]
    [InlineData("/programControlTypes", "MgProgramControlType")]
    [InlineData("/privilegedRoleAssignments", "MgPrivilegedRoleRoleAssignment")]
    [InlineData("/privilegedRoleAssignments/{privilegedRoleAssignment-id}", "MgPrivilegedRoleRoleAssignment")]
    [InlineData("/privilegedRoleAssignmentRequests", "MgPrivilegedRoleAssignmentRequest")]
    [InlineData("/privilegedOperationEvents", "MgPrivilegedOperationEvent")]
    [InlineData("/privilegedRoles/{privilegedRole-id}/assignments", "MgPrivilegedRoleRoleAssignment")]
    [InlineData("/privilegedRoles/{privilegedRole-id}/assignments/{privilegedRoleAssignment-id}", "MgPrivilegedRoleRoleAssignment")]
    public void BetaLegacyRootAndNestedAssignmentRenamesHaveNoRepeatedEntityNames(string path, string expectedNoun)
    {
        Assert.Equal(expectedNoun, Naming.Resolve(new OperationInfo(HttpMethod.Get, path), Config(), apiVersion: "beta").Noun);
    }

    [Theory]
    [InlineData("POST", "/privilegedRoleAssignments")]
    [InlineData("PATCH", "/privilegedRoleAssignments/{privilegedRoleAssignment-id}")]
    [InlineData("DELETE", "/privilegedRoleAssignments/{privilegedRoleAssignment-id}")]
    public void StandaloneAssignmentMutationNamesAreNotChangedByTheGetOnlyRename(string method, string path)
    {
        Assert.Equal("MgPrivilegedRoleAssignment", Naming.Resolve(new OperationInfo(new HttpMethod(method), path), Config(), apiVersion: "beta").Noun);
    }

    [Theory]
    [InlineData("beta", "GET", "/privilegedRoleAssignments", "Get", "MgPrivilegedRoleRoleAssignment")]
    [InlineData("beta", "GET", "/privilegedRoleAssignments/{privilegedRoleAssignment-id}", "Get", "MgPrivilegedRoleRoleAssignment")]
    [InlineData("beta", "GET", "/privilegedRoles/{privilegedRole-id}/assignments", "Get", "MgPrivilegedRoleRoleAssignment")]
    [InlineData("beta", "GET", "/privilegedRoles/{privilegedRole-id}/assignments/{privilegedRoleAssignment-id}", "Get", "MgPrivilegedRoleRoleAssignment")]
    [InlineData("v1.0", "GET", EntitlementManagement + "/accessPackages/{accessPackage-id}/catalog", "Get", "MgEntitlementManagementAccessPackageCatalog")]
    [InlineData("v1.0", "GET", EntitlementManagement + "/accessPackages/{accessPackage-id}/assignmentPolicies", "Get", "MgEntitlementManagementAccessPackageAssignmentPolicy")]
    [InlineData("beta", "PATCH", "/privilegedAccess/{privilegedAccess-id}/roleAssignmentRequests/{governanceRoleAssignmentRequest-id}", "Update", "MgPrivilegedAccessRoleAssignmentRequest")]
    [InlineData("beta", "PATCH", "/privilegedAccess/{privilegedAccess-id}/resources/{governanceResource-id}/roleAssignmentRequests/{governanceRoleAssignmentRequest-id}", "Update", "MgPrivilegedAccessResourceRoleAssignmentRequest")]
    public async Task ReviewedRenamesAndLegacyVariantNeighborsEmitTheirExactCompatibleRoutes(
        string profile, string method, string path, string expectedVerb, string expectedNoun)
    {
        var spec = await Specs[profile].Value;
        var httpMethod = new HttpMethod(method);
        var document = new OpenApiDocument
        {
            Info = spec.Info,
            Components = spec.Components,
            Paths = new OpenApiPaths
            {
                [path] = new OpenApiPathItem
                {
                    Operations = new Dictionary<HttpMethod, OpenApiOperation>
                    {
                        [httpMethod] = spec.Paths[path].Operations![httpMethod],
                    },
                },
            },
        };
        if (profile == "beta" && PrivilegedAssignmentGetRoutes.Contains(path, StringComparer.Ordinal))
        {
            foreach (var route in PrivilegedAssignmentGetRoutes)
                document.Paths[route] = new OpenApiPathItem
                {
                    Operations = new Dictionary<HttpMethod, OpenApiOperation>
                    {
                        [HttpMethod.Get] = spec.Paths[route].Operations![HttpMethod.Get],
                    },
                };
        }
        var output = Path.Combine(Path.GetTempPath(), "governance-directive-tests", Guid.NewGuid().ToString("N"));
        try
        {
            await new PowerShellWrapperGenerationService(document, Config() with { OutputPath = output }, NullLogger.Instance, apiVersion: profile)
                .GenerateAsync(TestContext.Current.CancellationToken);
            var source = File.ReadAllText(Path.Combine(output, $"{expectedVerb}{expectedNoun}.g.cs"));
            Assert.Contains($"[GraphRoute(\"{method}\", \"{path}\"", source, StringComparison.Ordinal);
            var verbsClass = expectedVerb == "Update" ? "VerbsData" : "VerbsCommon";
            Assert.Contains($"[Cmdlet({verbsClass}.{expectedVerb}, \"{expectedNoun}\"", source, StringComparison.Ordinal);
        }
        finally
        {
            if (Directory.Exists(output))
                Directory.Delete(output, recursive: true);
        }
    }

    [Theory]
    [InlineData("v1.0", true)]
    [InlineData("v1.0", false)]
    [InlineData("beta", true)]
    [InlineData("beta", false)]
    public async Task TargetedEmissionUsesReviewedSuppressionsAndRenameWithoutAClientBuild(string profile, bool useCollisionData)
    {
        var spec = await Specs[profile].Value;
        var selected = profile == "beta"
            ? new[] { EntitlementManagement + "/settings", EntitlementManagement + "/accessPackageResources" }
                .Concat(PrivilegedAssignmentGetRoutes).ToArray()
            : new[] { EntitlementManagement + "/settings", EntitlementManagement + "/accessPackages" };
        var document = new OpenApiDocument
        {
            Info = spec.Info,
            Components = spec.Components,
            Paths = new OpenApiPaths(),
        };
        foreach (var path in selected)
            document.Paths.Add(path, spec.Paths[path]);
        var output = Path.Combine(Path.GetTempPath(), "governance-directive-tests", Guid.NewGuid().ToString("N"));
        try
        {
            await new PowerShellWrapperGenerationService(document, Config(useCollisionData) with { OutputPath = output }, NullLogger.Instance, apiVersion: profile)
                .GenerateAsync(TestContext.Current.CancellationToken);
            var files = Directory.GetFiles(output, "*.g.cs").Select(Path.GetFileName).ToArray();
            Assert.Contains("GetMgEntitlementManagementSetting.g.cs", files);
            Assert.Contains("UpdateMgEntitlementManagementSetting.g.cs", files);
            Assert.DoesNotContain("RemoveMgEntitlementManagementSetting.g.cs", files);
            Assert.DoesNotContain(files, f => f!.Contains("IdentityGovernanceEntitlementManagement", StringComparison.Ordinal));
            if (profile == "beta")
            {
                Assert.Contains("GetMgPrivilegedRoleRoleAssignment.g.cs", files);
                Assert.DoesNotContain("GetMgPrivilegedRoleAssignment.g.cs", files);
                Assert.Contains("NewMgPrivilegedRoleAssignment.g.cs", files);
                Assert.Contains("GetMgEntitlementManagementAccessPackageResource.g.cs", files);
                Assert.DoesNotContain("NewMgEntitlementManagementAccessPackageResource.g.cs", files);
                var dispatcher = File.ReadAllText(Path.Combine(output, "GetMgPrivilegedRoleRoleAssignment.g.cs"));
                Assert.Matches(@"DefaultParameterSetName\s*=\s*""StandaloneList""", dispatcher);
                foreach (var set in new[] { "StandaloneList", "StandaloneGet", "RoleList", "RoleGet" })
                    Assert.Matches($@"ParameterSetName\s*=\s*""{set}""", dispatcher);
                Assert.Matches(@"public\s+string\??\s+PrivilegedRoleId\b", dispatcher);
                Assert.Matches(@"public\s+string\??\s+PrivilegedRoleAssignmentId\b", dispatcher);
                var emitted = string.Join(Environment.NewLine, Directory.GetFiles(output, "*.g.cs").Select(File.ReadAllText));
                foreach (var path in selected.Where(p => p.StartsWith("/privileged", StringComparison.Ordinal)))
                    Assert.Contains($"[GraphRoute(\"GET\", \"{path}\")]", emitted, StringComparison.Ordinal);
            }
            else
            {
                Assert.Contains("GetMgEntitlementManagementAccessPackage.g.cs", files);
                Assert.DoesNotContain("GetMgEntitlementManagementCatalogAccessPackage.g.cs", files);
            }
        }
        finally
        {
            if (Directory.Exists(output))
                Directory.Delete(output, recursive: true);
        }
    }

    [Theory]
    [InlineData("v1.0")]
    [InlineData("beta")]
    public async Task CompleteCompatibleSurfaceEmitsWithoutLosingCollidingRoutes(string profile)
    {
        var output = Path.Combine(Path.GetTempPath(), "governance-directive-tests", Guid.NewGuid().ToString("N"));
        try
        {
            await new PowerShellWrapperGenerationService(await Specs[profile].Value,
                Config() with { OutputPath = output }, NullLogger.Instance, apiVersion: profile)
                .GenerateAsync(TestContext.Current.CancellationToken);
            Assert.NotEmpty(Directory.GetFiles(output, "*.g.cs"));
            if (profile == "beta")
            {
                foreach (var noun in new[] { "ProgramControl", "ProgramAssociatedControl" })
                    foreach (var verb in new[] { "New", "Update" })
                        Assert.True(File.Exists(Path.Combine(output, $"{verb}Mg{noun}.g.cs")));
                Assert.True(File.Exists(Path.Combine(output, "InvokeMgIdentityGovernanceRoleManagementAlertRefresh.g.cs")));
                Assert.True(File.Exists(Path.Combine(output, "InvokeMgIdentityGovernanceRoleManagementAlertRefreshByScope.g.cs")));
                var associatedCreate = File.ReadAllText(Path.Combine(output, "NewMgProgramAssociatedControl.g.cs"));
                Assert.Contains("ProgramId", associatedCreate, StringComparison.Ordinal);
                var scopedRefresh = File.ReadAllText(Path.Combine(output, "InvokeMgIdentityGovernanceRoleManagementAlertRefreshByScope.g.cs"));
                Assert.Contains("ScopeId", scopedRefresh, StringComparison.Ordinal);
                Assert.Contains("ScopeType", scopedRefresh, StringComparison.Ordinal);
            }
        }
        finally
        {
            if (Directory.Exists(output))
                Directory.Delete(output, recursive: true);
        }
    }

    [Fact]
    public async Task BodyContractNamesAreGroundedInActualSourceDescriptionsAndParameters()
    {
        var spec = await Specs["beta"].Value;
        var program = spec.Components!.Schemas!["microsoft.graph.program"];
        Assert.Contains("Controls associated with the program",
            program.AllOf!.Last().Properties!["controls"].Description!, StringComparison.Ordinal);
        var control = spec.Components.Schemas["microsoft.graph.programControl"];
        Assert.Contains("programId", control.AllOf!.Last().Properties!.Keys);
        var item = spec.Paths["/identityGovernance/roleManagementAlerts/alerts/{unifiedRoleManagementAlert-id}/refresh"]
            .Operations![HttpMethod.Post];
        var scoped = spec.Paths["/identityGovernance/roleManagementAlerts/alerts/refresh"].Operations![HttpMethod.Post];
        Assert.Null(item.RequestBody);
        Assert.True(scoped.RequestBody!.Required);
        var properties = scoped.RequestBody.Content!["application/json"].Schema!.Properties!;
        Assert.Equal(new[] { "scopeId", "scopeType" }, properties.Keys.OrderBy(k => k, StringComparer.Ordinal));
    }

    [Fact]
    public async Task EveryAuthoredNaturalIdGroupHasCompatibleActualContracts()
    {
        var spec = await Specs["beta"].Value;
        var errors = new List<string>();
        foreach (var group in CmdletConfigurator.GetOperationVariantGroups().Where(g =>
            g.Routes.Any(r => r.Path.StartsWith("/program", StringComparison.Ordinal) ||
                r.Path.StartsWith("/privilegedRole", StringComparison.Ordinal) ||
                r.Path.StartsWith("/identityGovernance/roleManagementAlerts", StringComparison.Ordinal))))
        {
            var document = new OpenApiDocument { Info = spec.Info, Components = spec.Components, Paths = new OpenApiPaths() };
            foreach (var route in group.Routes)
            {
                if (!document.Paths.TryGetValue(route.Path, out var item))
                    document.Paths.Add(route.Path, item = new OpenApiPathItem { Operations = new Dictionary<HttpMethod, OpenApiOperation>() });
                var method = new HttpMethod(route.Method);
                item.Operations!.Add(method, spec.Paths[route.Path].Operations![method]);
            }
            var output = Path.Combine(Path.GetTempPath(), "governance-directive-tests", Guid.NewGuid().ToString("N"));
            try
            {
                await new PowerShellWrapperGenerationService(document, Config() with { OutputPath = output },
                    NullLogger.Instance, apiVersion: "beta",
                    configurationEntries: [CmdletConfigurator.GroupVariants(group, "Isolated actual Governance group contract")])
                    .GenerateAsync(TestContext.Current.CancellationToken);
            }
            catch (InvalidOperationException exception)
            {
                errors.Add($"{group.Routes[0].Method} {group.Routes[0].Path}: {exception.Message}");
            }
            finally
            {
                if (Directory.Exists(output))
                    Directory.Delete(output, recursive: true);
            }
        }
        Assert.True(errors.Count == 0, string.Join(Environment.NewLine, errors));
    }

    [Theory]
    [InlineData("v1.0", true)]
    [InlineData("v1.0", false)]
    [InlineData("beta", true)]
    [InlineData("beta", false)]
    public void AuthoredRulesAreSharedWhileOracleProfileRemainsExplicit(string profile, bool useCollisionData)
    {
        var config = Config(useCollisionData);
        Assert.True(CmdletConfigurator.IsSuppressed(HttpMethod.Delete, EntitlementManagement + "/settings",
            config, apiVersion: profile));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get, EntitlementManagement + "/settings",
            config, apiVersion: profile));
        Assert.Equal("EntitlementManagementSetting", CmdletConfigurator.ApplyNounOverrides(HttpMethod.Get,
            EntitlementManagement + "/settings", "IdentityGovernanceEntitlementManagementSetting",
            config, apiVersion: profile));
        Assert.Equal("MgEntitlementManagementSetting", Naming.Resolve(new OperationInfo(HttpMethod.Get,
            EntitlementManagement + "/settings"), config, apiVersion: profile).Noun);
        Assert.Null(CmdletConfigurator.TryGetOverriddenVerb(HttpMethod.Get, "/privilegedRoleAssignments",
            config, apiVersion: profile));
    }

    private static GeneratorConfig Config(bool useCollisionData = true) =>
        new("Microsoft.Graph.PowerShell.Test.Client", "unused", UseCollisionData: useCollisionData);

    private static IEnumerable<(string Path, HttpMethod Method, OpenApiOperation Operation)> Operations(OpenApiDocument document) =>
        document.Paths.SelectMany(p => p.Value.Operations!.Select(o => (p.Key, o.Key, o.Value)));

    private static string NormalizeLegacyPath(string path) =>
        Regex.Replace(path, @"\{[^}]+\}", "{}").TrimEnd('/').ToLowerInvariant();

    private static string? GraphOperationType(OpenApiOperation operation) =>
        operation.Extensions is not null &&
        operation.Extensions.TryGetValue("x-ms-docs-operation-type", out var extension) &&
        extension is JsonNodeExtension node ? node.Node?.ToString()?.Trim('"') : null;

    private static async Task<OpenApiDocument> LoadSpecAsync(string profile, bool legacyEvidence = false)
    {
        var settings = new OpenApiReaderSettings();
        settings.AddYamlReader();
        using var stream = File.OpenRead(Path.Combine(FindRepoRoot(), legacyEvidence ? "openApiDocs" : "openApiDocs_KiotaCompat", profile, "Identity.Governance.yml"));
        var result = await OpenApiDocument.LoadAsync(stream, settings: settings);
        return result.Document ?? throw new InvalidOperationException($"Could not parse {profile} compatible Governance spec.");
    }

    private static string FindRepoRoot()
    {
        var directory = AppContext.BaseDirectory;
        while (directory is not null && !File.Exists(Path.Combine(directory, "src", "Identity.Governance", "Identity.Governance.md")))
            directory = Path.GetDirectoryName(directory);
        return directory ?? throw new InvalidOperationException("Could not locate repository root.");
    }
}
