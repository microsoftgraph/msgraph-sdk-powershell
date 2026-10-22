using System.Net.Http;
using WrapperGenerator;
using Xunit;

namespace WrapperGenerator.Tests;

public sealed class DirectoryManagementDirectiveMigrationTests
{
    [Theory]
    [InlineData("v1.0", true)]
    [InlineData("v1.0", false)]
    [InlineData("beta", true)]
    [InlineData("beta", false)]
    public void DeletedItemsSuppressionLeavesItemCastsCountsAndActions(string profile, bool derived)
    {
        var config = new GeneratorConfig("Test.Client", "unused", profile, derived);
        Assert.True(CmdletConfigurator.IsSuppressed(HttpMethod.Get, "/directory/deletedItems", config));
        Assert.True(CmdletConfigurator.IsSuppressed(HttpMethod.Get, "/directory/deletedItems/$count", config));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get, "/directory/deletedItems/{directoryObject-id}", config));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Delete, "/directory/deletedItems/{directoryObject-id}", config));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Post, "/directory/deletedItems/{directoryObject-id}/restore", config));

        foreach (var type in new[] { "administrativeUnit", "application", "device", "group", "servicePrincipal", "user" })
        {
            var suffix = char.ToUpperInvariant(type[0]) + type[1..];
            var list = $"/directory/deletedItems/graph.{type}";
            var item = $"/directory/deletedItems/{{directoryObject-id}}/graph.{type}";
            Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get, list, config));
            Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get, item, config));
            Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get, list + "/$count", config));
            Assert.Equal("MgDirectoryDeletedItemAs" + suffix, Resolve(HttpMethod.Get, list, config).Noun);
            Assert.Equal("MgDirectoryDeletedItemAs" + suffix, Resolve(HttpMethod.Get, item, config).Noun);
            Assert.Equal("MgDirectoryDeletedItemCountAs" + suffix, Resolve(HttpMethod.Get, list + "/$count", config).Noun);
        }
    }

    [Theory]
    [InlineData("v1.0", true)]
    [InlineData("v1.0", false)]
    [InlineData("beta", true)]
    [InlineData("beta", false)]
    public void LegacyReferenceSelectorSuppressesCollectionDeleteOnly(string profile, bool derived)
    {
        var config = new GeneratorConfig("Test.Client", "unused", profile, derived);
        foreach (var navigation in new[]
        {
            "/devices/{device-id}/registeredOwners",
            "/devices/{device-id}/registeredUsers",
            "/directory/administrativeUnits/{administrativeUnit-id}/members",
            "/directoryRoles/{directoryRole-id}/members",
        })
        {
            Assert.True(CmdletConfigurator.IsSuppressed(HttpMethod.Delete, navigation + "/$ref", config));
            Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get, navigation + "/$ref", config));
            Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Post, navigation + "/$ref", config));
            Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get, navigation, config));
            Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Delete, navigation + "/{directoryObject-id}/$ref", config));
        }
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get,
            "/policies/featureRolloutPolicies/{featureRolloutPolicy-id}/appliesTo/$ref", config));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Delete,
            "/administrativeUnits/{administrativeUnit-id}/members/$ref", config));
    }

    [Theory]
    [InlineData("v1.0", true)]
    [InlineData("v1.0", false)]
    [InlineData("beta", true)]
    [InlineData("beta", false)]
    public void StructuralTemplateAndContactNamesDoNotNeedOverrides(string profile, bool derived)
    {
        var config = new GeneratorConfig("Test.Client", "unused", profile, derived);
        AssertCrudNames("/directoryRoleTemplates", "{directoryRoleTemplate-id}", "MgDirectoryRoleTemplate", config);
        AssertCrudNames("/contacts", "{orgContact-id}", "MgContact", config, create: false);
        if (profile == "beta")
            AssertCrudNames("/directorySettingTemplates", "{directorySettingTemplate-id}", "MgDirectorySettingTemplate", config);
        Assert.Equal("MgContactDirectReport", Resolve(HttpMethod.Get, "/contacts/{orgContact-id}/directReports", config).Noun);
        Assert.Equal("MgDirectoryRoleTemplateCount", Resolve(HttpMethod.Get, "/directoryRoleTemplates/$count", config).Noun);
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get, "/contacts/delta()", config));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get, "/directoryRoleTemplates/delta()", config));
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public void BetaSettingRenameIsExactAndDoesNotRenameCount(bool derived)
    {
        var config = new GeneratorConfig("Test.Client", "unused", "beta", derived);
        AssertCrudNames("/settings", "{directorySetting-id}", "MgDirectorySetting", config);
        Assert.Equal("MgSettingCount", Resolve(HttpMethod.Get, "/settings/$count", config).Noun);
        Assert.Equal("MgSettingTemplate", Resolve(HttpMethod.Get, "/settings/{directorySetting-id}/template", config).Noun);
        Assert.Equal("MgGroupSetting", Resolve(HttpMethod.Get, "/groups/{group-id}/settings", config).Noun);
    }

    [Fact]
    public void V1DerivedReferenceRenameKeepsPrecedence()
    {
        const string path = "/devices/{device-id}/registeredOwners/{directoryObject-id}/$ref";
        var config = new GeneratorConfig("Test.Client", "unused", "v1.0");
        Assert.Equal("MgDeviceRegisteredOwnerDirectoryObjectByRef", Resolve(HttpMethod.Delete, path, config).Noun);
    }

    private static CmdletNaming Resolve(HttpMethod method, string path, GeneratorConfig config) =>
        Naming.Resolve(new OperationInfo(method, path), config);

    private static void AssertCrudNames(string collection, string id, string noun, GeneratorConfig config, bool create = true)
    {
        Assert.Equal(noun, Resolve(HttpMethod.Get, collection, config).Noun);
        if (create)
            Assert.Equal(noun, Resolve(HttpMethod.Post, collection, config).Noun);
        foreach (var method in new[] { HttpMethod.Get, HttpMethod.Patch, HttpMethod.Delete })
        {
            Assert.False(CmdletConfigurator.IsSuppressed(method, collection + "/" + id, config));
            Assert.Equal(noun, Resolve(method, collection + "/" + id, config).Noun);
        }
    }
}
