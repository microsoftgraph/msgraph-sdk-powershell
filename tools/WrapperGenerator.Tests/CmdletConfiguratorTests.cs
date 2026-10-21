using System;
using System.Net.Http;
using WrapperGenerator;
using Xunit;
using static WrapperGenerator.CmdletConfigurator;

namespace WrapperGenerator.Tests;

public sealed class CmdletConfiguratorTests
{
    private static readonly GeneratorConfig Stable = new("Test.Client", "unused");
    private static readonly GeneratorConfig Beta = Stable with { ApiVersion = "beta" };
    private const string DerivedRenamePath = "/identityGovernance/entitlementManagement/catalogs/{id}/resourceRoles";

    [Fact]
    public void CuratedVerbAndNounBeatDerivedNamesOnlyInTheirProfile()
    {
        Entry[] entries =
        [
            new(OverrideKind.ReplaceNoun, HttpMethod.Get, NormalizePathTemplate(DerivedRenamePath),
                PathMatch.Exact, "ReviewedRole", "test directive", ApiVersion: "v1.0"),
            new(OverrideKind.ReplaceVerb, HttpMethod.Get, NormalizePathTemplate(DerivedRenamePath),
                PathMatch.Exact, "Find", "test directive", ApiVersion: "v1.0"),
        ];
        ValidateEntries(entries);
        Assert.Equal("ReviewedRole", ApplyNounOverrides(HttpMethod.Get, DerivedRenamePath, "StructuralRole", Stable, entries));
        Assert.Equal("Find", TryGetOverriddenVerb(HttpMethod.Get, DerivedRenamePath, Stable, entries));
        Assert.Equal("StructuralRole", ApplyNounOverrides(HttpMethod.Get, DerivedRenamePath, "StructuralRole", Beta, entries));
        Assert.Null(TryGetOverriddenVerb(HttpMethod.Get, DerivedRenamePath, Beta, entries));
        Assert.Equal(ApplyNounOverrides(HttpMethod.Post, DerivedRenamePath, "StructuralRole", Stable, []),
            ApplyNounOverrides(HttpMethod.Post, DerivedRenamePath, "StructuralRole", Stable, entries));
        Assert.Equal("Neighbor", ApplyNounOverrides(HttpMethod.Get, DerivedRenamePath + "/neighbor", "Neighbor", Stable, entries));
        Assert.Equal("EntitlementManagementCatalogResourceRole",
            ApplyNounOverrides(HttpMethod.Get, DerivedRenamePath, "StructuralRole", Stable, []));
    }

    [Fact]
    public void DerivedSuppressionCannotSilentlyHideAnExplicitCuratedName()
    {
        Entry[] entries =
        [
            new(OverrideKind.ReplaceNoun, HttpMethod.Get, "/groupsettings", PathMatch.Exact,
                "ReviewedSetting", "test directive", ApiVersion: "v1.0"),
        ];
        Assert.False(IsSuppressed(HttpMethod.Get, "/groupSettings", Stable, entries));
        Assert.True(IsSuppressed(HttpMethod.Get, "/groupSettings", Stable, []));
        Assert.False(IsSuppressed(HttpMethod.Get, "/groupSettings", Beta, entries));
        Entry suppression = new(OverrideKind.SuppressOperation, HttpMethod.Get, "/groupsettings",
            PathMatch.Exact, null, "explicit suppression", ApiVersion: "v1.0");
        Assert.True(IsSuppressed(HttpMethod.Get, "/groupSettings", Stable, [.. entries, suppression]));
    }

    [Fact]
    public void BetaSuppressionDoesNotLeakAcrossMethodPathOrProfile()
    {
        Entry[] entries =
        [
            new(OverrideKind.SuppressOperation, HttpMethod.Patch, "/widgets/{}", PathMatch.Exact,
                null, "beta-only directive", ApiVersion: "beta"),
        ];
        Assert.True(IsSuppressed(HttpMethod.Patch, "/widgets/{widget-id}", Beta, entries));
        Assert.False(IsSuppressed(HttpMethod.Patch, "/widgets/{id}", Stable, entries));
        Assert.False(IsSuppressed(HttpMethod.Patch, "/widgets/{id}", null, entries));
        Assert.False(IsSuppressed(HttpMethod.Get, "/widgets/{id}", Beta, entries));
        Assert.False(IsSuppressed(HttpMethod.Delete, "/widgets/{id}", Beta, entries));
        Assert.False(IsSuppressed(HttpMethod.Patch, "/widgets/{id}/neighbor", Beta, entries));
    }

    [Theory]
    [InlineData(null)]
    [InlineData("v1.0")]
    [InlineData("beta")]
    public void UnscopedEntriesKeepTheirExistingBehavior(string? profile)
    {
        Entry[] entries =
        [
            new(OverrideKind.ReplaceNoun, HttpMethod.Get, "/widgets", PathMatch.Exact, "OldName", "existing directive"),
            new(OverrideKind.ReplaceVerb, HttpMethod.Get, "/widgets", PathMatch.Exact, "Find", "reviewed directive"),
        ];
        var config = profile is null ? null : Stable with { ApiVersion = profile };
        Assert.Equal("OldName", ApplyNounOverrides(HttpMethod.Get, "/widgets", "Widget", config, entries));
        Assert.Equal("Find", TryGetOverriddenVerb(HttpMethod.Get, "/widgets", config, entries));
    }

    [Fact]
    public void RejectsInvalidProfilesPatternsAndUnapprovedVerbs()
    {
        Assert.Throws<InvalidOperationException>(() => ValidateEntries(
            [new(OverrideKind.ReplaceVerb, HttpMethod.Get, "/widgets", PathMatch.Exact, "Find", "test", ApiVersion: "preview")]));
        Assert.Throws<InvalidOperationException>(() => ValidateEntries(
            [new(OverrideKind.ReplaceNoun, HttpMethod.Get, "/Widgets", PathMatch.Exact, "Widget", "test")]));
        Assert.Throws<NotSupportedException>(() => ValidateEntries(
            [new(OverrideKind.ReplaceVerb, HttpMethod.Get, "/widgets", PathMatch.Exact, "Fetch", "test")]));
        Assert.Throws<InvalidOperationException>(() => ValidateEntries(
            [new(OverrideKind.ReplaceVerb, HttpMethod.Get, "/widgets", PathMatch.Exact, null, "test")]));
    }

    [Theory]
    [InlineData("POST", "/administrativeUnits/{administrativeUnit-id}/checkMemberGroups")]
    [InlineData("POST", "/administrativeUnits/{administrativeUnit-id}/checkMemberObjects")]
    [InlineData("POST", "/administrativeUnits/{administrativeUnit-id}/getMemberGroups")]
    [InlineData("POST", "/administrativeUnits/{administrativeUnit-id}/getMemberObjects")]
    [InlineData("POST", "/administrativeUnits/{administrativeUnit-id}/restore")]
    [InlineData("GET", "/administrativeUnits/delta()")]
    [InlineData("POST", "/administrativeUnits/getByIds")]
    [InlineData("POST", "/administrativeUnits/getUserOwnedObjects")]
    [InlineData("POST", "/administrativeUnits/validateProperties")]
    public void ModuleLocalSuppressionDoesNotHideTheOtherOwningSlice(string method, string path)
    {
        var httpMethod = new HttpMethod(method);
        Entry[] entries =
        [
            new(OverrideKind.SuppressOperation, httpMethod, NormalizePathTemplate(path),
                PathMatch.Exact, null, "module-local admin selector", ApiVersion: "beta", Module: "Devices.ServiceAnnouncement"),
        ];
        foreach (var module in new[] { "Devices.ServiceAnnouncement", "Identity.DirectoryManagement" })
            foreach (var profile in new[] { "v1.0", "beta" })
            {
                var config = Stable with { Module = module, ApiVersion = profile, UseCollisionData = false };
                Assert.Equal(module == "Devices.ServiceAnnouncement" && profile == "beta", IsSuppressed(httpMethod, path, config, entries));
                Assert.False(IsSuppressed(httpMethod == HttpMethod.Get ? HttpMethod.Post : HttpMethod.Get, path, config, entries));
                Assert.False(IsSuppressed(httpMethod, path + "/neighbor", config, entries));
            }
    }

    [Theory]
    [InlineData("Devices.ServiceAnnouncement", "beta", "ServiceName", "Find")]
    [InlineData("Identity.DirectoryManagement", "beta", "DirectoryName", "Search")]
    [InlineData("Devices.ServiceAnnouncement", "v1.0", "GlobalName", "Get")]
    [InlineData("Identity.DirectoryManagement", "v1.0", "GlobalName", "Get")]
    public void ScopedNounAndVerbWinOverGlobalsWithoutLeakingToTheOtherModuleOrProfile(
        string module, string profile, string noun, string verb)
    {
        Entry[] entries =
        [
            new(OverrideKind.ReplaceNoun, HttpMethod.Get, "/widgets", PathMatch.Exact, "GlobalName", "legacy global"),
            new(OverrideKind.ReplaceVerb, HttpMethod.Get, "/widgets", PathMatch.Exact, "Get", "legacy global"),
            new(OverrideKind.ReplaceNoun, HttpMethod.Get, "/widgets", PathMatch.Exact, "ServiceName", "reviewed",
                ApiVersion: "beta", Module: "Devices.ServiceAnnouncement"),
            new(OverrideKind.ReplaceVerb, HttpMethod.Get, "/widgets", PathMatch.Exact, "Find", "reviewed",
                ApiVersion: "beta", Module: "Devices.ServiceAnnouncement"),
            new(OverrideKind.ReplaceNoun, HttpMethod.Get, "/widgets", PathMatch.Exact, "DirectoryName", "reviewed",
                ApiVersion: "beta", Module: "Identity.DirectoryManagement"),
            new(OverrideKind.ReplaceVerb, HttpMethod.Get, "/widgets", PathMatch.Exact, "Search", "reviewed",
                ApiVersion: "beta", Module: "Identity.DirectoryManagement"),
        ];
        ValidateEntries(entries);
        // The namespace deliberately does not identify either configured module.
        var config = Beta with { Module = module, ApiVersion = profile, UseCollisionData = false };
        Assert.Equal(noun, ApplyNounOverrides(HttpMethod.Get, "/widgets", "Widget", config, entries));
        Assert.Equal(verb, TryGetOverriddenVerb(HttpMethod.Get, "/widgets", config, entries));
        Array.Reverse(entries);
        Assert.Equal(noun, ApplyNounOverrides(HttpMethod.Get, "/widgets", "Widget", config, entries));
        Assert.Equal(verb, TryGetOverriddenVerb(HttpMethod.Get, "/widgets", config, entries));
        Assert.Equal("Widget", ApplyNounOverrides(HttpMethod.Post, "/widgets", "Widget", config, entries));
        Assert.Null(TryGetOverriddenVerb(HttpMethod.Get, "/widgets/neighbor", config, entries));
    }

    [Fact]
    public void MissingModuleContextFailsOnlyForAnOtherwiseApplicableScopedRule()
    {
        Entry[] entries =
        [
            new(OverrideKind.SuppressOperation, HttpMethod.Get, "/widgets", PathMatch.Exact, null, "scoped suppression", Module: "People"),
            new(OverrideKind.ReplaceNoun, HttpMethod.Get, "/widgets", PathMatch.Exact, "Person", "scoped noun", Module: "People"),
            new(OverrideKind.ReplaceVerb, HttpMethod.Get, "/widgets", PathMatch.Exact, "Find", "scoped verb", Module: "People"),
        ];
        Assert.Throws<InvalidOperationException>(() => IsSuppressed(HttpMethod.Get, "/widgets", null, entries));
        Assert.Throws<InvalidOperationException>(() => ApplyNounOverrides(HttpMethod.Get, "/widgets", "Widget", Stable, entries));
        Assert.Throws<InvalidOperationException>(() => TryGetOverriddenVerb(HttpMethod.Get, "/widgets", Stable, entries));
        Assert.False(IsSuppressed(HttpMethod.Get, "/neighbor", null, entries));
        Assert.False(IsSuppressed(HttpMethod.Post, "/widgets", null, entries));
    }

    [Theory]
    [InlineData(null)]
    [InlineData("People")]
    [InlineData("CrossDeviceExperiences")]
    public void LegacyGlobalsKeepTheirDefaultsWithOrWithoutModuleContext(string? module)
    {
        Entry[] entries =
        [
            new(OverrideKind.ReplaceNoun, HttpMethod.Get, "/widgets", PathMatch.Exact, "LegacyWidget", "legacy global"),
            new(OverrideKind.ReplaceVerb, HttpMethod.Get, "/widgets", PathMatch.Exact, "Find", "legacy global"),
            new(OverrideKind.SuppressOperation, HttpMethod.Delete, "/widgets", PathMatch.Exact, null, "legacy global"),
        ];
        var config = module is null ? null : Stable with { Module = module };
        Assert.Equal("LegacyWidget", ApplyNounOverrides(HttpMethod.Get, "/widgets", "Widget", config, entries));
        Assert.Equal("Find", TryGetOverriddenVerb(HttpMethod.Get, "/widgets", config, entries));
        Assert.True(IsSuppressed(HttpMethod.Delete, "/widgets", config, entries));
    }

    [Fact]
    public void ScopedNamesRescueDerivedSuppressionOnlyForTheirOwnModuleAndExplicitSuppressionStillWins()
    {
        Entry name = new(OverrideKind.ReplaceNoun, HttpMethod.Get, "/groupsettings",
            PathMatch.Exact, "ReviewedSetting", "reviewed local rule", Module: "People");
        var people = Stable with { Module = "People" };
        Assert.False(IsSuppressed(HttpMethod.Get, "/groupSettings", people, [name]));
        Assert.True(IsSuppressed(HttpMethod.Get, "/groupSettings", Stable with { Module = "Groups" }, [name]));
        Entry suppression = new(OverrideKind.SuppressOperation, HttpMethod.Get, "/groupsettings", PathMatch.Exact, null, "legacy global");
        Assert.True(IsSuppressed(HttpMethod.Get, "/groupSettings", people, [suppression, name]));
        Assert.True(IsSuppressed(HttpMethod.Get, "/groupSettings", people, [name, suppression]));
    }

    [Fact]
    public void PrefixRulesAreScopedAndSameScopeRegistrationOrderRemainsDeterministic()
    {
        var config = Stable with { Module = "People", UseCollisionData = false };
        Entry first = new(OverrideKind.ReplaceNoun, HttpMethod.Get, "/widgets", PathMatch.Exact, "First", "first", Module: "People");
        Entry second = first with { Value = "Second" };
        Assert.Equal("First", ApplyNounOverrides(HttpMethod.Get, "/widgets", "Widget", config, [first, second]));
        Assert.Equal("Second", ApplyNounOverrides(HttpMethod.Get, "/widgets", "Widget", config, [second, first]));
        Entry strip = new(OverrideKind.StripNounPrefix, null, "/widgets", PathMatch.Prefix, "Tenant", "local strip", Module: "People");
        Assert.Equal("Widget", ApplyNounOverrides(HttpMethod.Get, "/widgets", "TenantWidget", config, [strip]));
        Assert.Equal("TenantWidget", ApplyNounOverrides(HttpMethod.Get, "/widgets", "TenantWidget", config with { Module = "Groups" }, [strip]));
    }

    [Theory]
    [InlineData("")]
    [InlineData("people")]
    [InlineData("DevicesServiceAnnouncement")]
    [InlineData("Unknown.Module")]
    public void RejectsNoncanonicalModuleScopesAndContexts(string module)
    {
        Entry entry = new(OverrideKind.ReplaceNoun, HttpMethod.Get, "/widgets", PathMatch.Exact, "Widget", "invalid scope", Module: module);
        Assert.Throws<ArgumentException>(() => ValidateEntries([entry]));
        Assert.Throws<ArgumentException>(() => IsSuppressed(HttpMethod.Get, "/widgets", Stable with { Module = module }, []));
    }
}
