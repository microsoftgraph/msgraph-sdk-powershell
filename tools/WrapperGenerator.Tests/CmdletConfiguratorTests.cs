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
}
