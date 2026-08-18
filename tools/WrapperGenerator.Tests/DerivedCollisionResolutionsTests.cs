using System.Net.Http;
using WrapperGenerator;
using Xunit;

namespace WrapperGenerator.Tests;

// The derived collision data (tools/WrapperGenerator/data/collision-*.json, embedded at
// build time) must only act when a run opts in via GeneratorConfig: the curated-only paths
// the naming tests pin are exercised with config null, so a data-file regeneration can never
// silently shift those expectations. Entries asserted here are oracle-cited in the data
// files' evidence fields.
public sealed class DerivedCollisionResolutionsTests
{
    private static readonly GeneratorConfig DataOn = new("Test.Client", "unused");
    private static readonly GeneratorConfig DataOff = new("Test.Client", "unused", UseCollisionData: false);

    // Oracle: /groupSettings ships nothing in v1.0; Get/New/Update/Remove-MgGroupSetting all
    // ship from the nested /groups/{id}/settings routes.
    [Fact]
    public void DerivedSuppressionAppliesOnlyWithDataEnabled()
    {
        Assert.True(NamingOverrides.IsSuppressed(HttpMethod.Get, "/groupSettings", DataOn));
        Assert.False(NamingOverrides.IsSuppressed(HttpMethod.Get, "/groupSettings", DataOff));
        Assert.False(NamingOverrides.IsSuppressed(HttpMethod.Get, "/groupSettings"));
    }

    // Oracle: the nested catalog resourceRoles route ships as
    // Get-MgEntitlementManagementCatalogResourceRole - the published noun drops the
    // IdentityGovernance prefix our path rules produce.
    [Fact]
    public void DerivedRenameReplacesTheNounVerbatim()
    {
        var path = "/identityGovernance/entitlementManagement/catalogs/{accessPackageCatalog-id}/resourceRoles";

        var renamed = Naming.Resolve(new OperationInfo(HttpMethod.Get, path), DataOn);
        Assert.Equal("MgEntitlementManagementCatalogResourceRole", renamed.Noun);

        var untouched = Naming.Resolve(new OperationInfo(HttpMethod.Get, path));
        Assert.Equal("MgIdentityGovernanceEntitlementManagementCatalogResourceRole", untouched.Noun);
    }

    // A derived rename is keyed by method: the GET rename of the resourceRoles route must not
    // leak onto a POST of a DIFFERENT route that only shares the prefix.
    [Fact]
    public void DerivedEntriesAreExactMatchOnly()
    {
        Assert.False(NamingOverrides.IsSuppressed(HttpMethod.Get, "/groupSettings/extra/segment", DataOn));
    }

    // The two deferred cross-path merges (the only ones in all of v1.0): the published SDK
    // serves one command from two unrelated routes; the singleton side is kept, the
    // collection side is suppressed until cross-path parameter sets land.
    [Theory]
    [InlineData("/groups/{group-id}/photos")]
    [InlineData("/shares/{sharedDriveItem-id}/list/items")]
    public void DeferredCrossPathRoutesAreSuppressed(string pathTemplate)
    {
        Assert.True(NamingOverrides.IsSuppressed(HttpMethod.Get, pathTemplate, DataOn));
    }
}
