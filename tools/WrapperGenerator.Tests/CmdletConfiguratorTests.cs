using System;
using System.Net.Http;
using WrapperGenerator;
using Xunit;
using static WrapperGenerator.CmdletConfigurator;

namespace WrapperGenerator.Tests;

public sealed class CmdletConfiguratorTests
{
    private const string FunctionPath = "/fixtures/{fixture-id}/resolve(Input='{Input}')";
    private static readonly Entry[] VerbEntries =
    [
        new(OverrideKind.ReplaceNoun, HttpMethod.Get, "/fixtures/{}/resolve(input='{}')",
            PathMatch.Exact, "FixtureResolve", "Independent noun override"),
        new(OverrideKind.ReplaceVerb, HttpMethod.Get, "/fixtures/{}/resolve(input='{}')",
            PathMatch.Exact, "Invoke", "Shared directive verb override"),
    ];

    [Theory]
    [InlineData(null, false)]
    [InlineData("v1.0", false)]
    [InlineData("beta", false)]
    [InlineData("v1.0", true)]
    [InlineData("beta", true)]
    public void CuratedVerbAppliesIndependentlyOfDerivedData(string? apiVersion, bool useCollisionData)
    {
        var config = apiVersion is null ? null : new GeneratorConfig("Test.Client", "unused", useCollisionData);
        var verb = TryGetOverriddenVerb(HttpMethod.Get, FunctionPath, config, VerbEntries, apiVersion ?? "v1.0");

        Assert.Equal("Invoke", verb);
        Assert.Equal(PsVerb.Invoke, PsVerb.FromApprovedName(verb!));
    }

    [Theory]
    [InlineData("GET", "/FIXTURES/{renamed-id}/RESOLVE(Input='{renamed-input}')/", "Invoke")]
    [InlineData("POST", FunctionPath, null)]
    [InlineData("GET", "/fixtures/{fixture-id}/resolve(Input='{Input}')/child", null)]
    [InlineData("GET", "/fixtures/{fixture-id}/other(Input='{Input}')", null)]
    public void CuratedVerbUsesExistingMethodAndNormalizedPathMatching(string method, string path, string? expected)
    {
        Assert.Equal(expected, TryGetOverriddenVerb(new HttpMethod(method), path, null, VerbEntries));
    }

    [Theory]
    [InlineData(null, "Invoke")]
    [InlineData("v1.0", "Invoke")]
    [InlineData("beta", "Invoke")]
    [InlineData("BETA", "Invoke")]
    public void SameCuratedEntryAppliesToEveryIngestingProfile(string? apiVersion, string? expected)
    {
        Entry[] entries =
        [
            new(OverrideKind.ReplaceVerb, null, "/fixtures/", PathMatch.Prefix, "Invoke", "Shared module configuration"),
        ];
        var config = apiVersion is null ? null : new GeneratorConfig("Test.Client", "unused", false);
        Assert.Equal(expected, TryGetOverriddenVerb(HttpMethod.Get, FunctionPath, config, entries, apiVersion ?? "v1.0"));
    }

    [Fact]
    public void CuratedVerbSupportsUnscopedMethodsAndExistingPrefixSuffixMatching()
    {
        Entry[] entries =
        [
            new(OverrideKind.ReplaceVerb, null, "/fixtures/", PathMatch.Prefix, "Confirm", "Unscoped prefix"),
            new(OverrideKind.ReplaceVerb, HttpMethod.Post, "/resolve", PathMatch.Suffix, "Invoke", "Scoped suffix"),
        ];
        Assert.Equal("Confirm", TryGetOverriddenVerb(HttpMethod.Delete, "/fixtures/{id}", null, entries));
        Assert.Equal("Confirm", TryGetOverriddenVerb(HttpMethod.Get, "/fixtures/{id}", null, entries));
        Assert.Equal("Invoke", TryGetOverriddenVerb(HttpMethod.Post, "/other/resolve", null, entries));
        Assert.Null(TryGetOverriddenVerb(HttpMethod.Get, "/other/resolve", null, entries));
    }

    [Fact]
    public void FirstMatchingCuratedVerbWinsWithoutReadingOtherOverrideKinds()
    {
        Entry[] entries =
        [
            new(OverrideKind.SuppressOperation, null, "/fixtures/", PathMatch.Prefix, null, "Not a verb"),
            .. VerbEntries,
            new(OverrideKind.ReplaceVerb, HttpMethod.Get, "/fixtures/", PathMatch.Prefix, "Get", "Later match"),
        ];
        Assert.Equal("Invoke", TryGetOverriddenVerb(HttpMethod.Get, FunctionPath, null, entries));
        Assert.Null(TryGetOverriddenVerb(HttpMethod.Get, FunctionPath, null, [VerbEntries[0]]));
    }

    [Theory]
    [InlineData(true, "Invoke")]
    [InlineData(false, "Confirm")]
    public void DerivedVerbTakesPrecedenceOverCuratedVerb(bool useCollisionData, string expected)
    {
        const string path = "/users/{user-id}/calendar/allowedCalendarSharingRoles(User='{User}')";
        Entry[] entries =
        [
            new(OverrideKind.ReplaceVerb, HttpMethod.Get, NormalizePathTemplate(path),
                PathMatch.Exact, "Confirm", "Deliberately differs from the published derived verb"),
        ];
        var config = new GeneratorConfig("Test.Client", "unused", UseCollisionData: useCollisionData);
        Assert.Equal(expected, TryGetOverriddenVerb(HttpMethod.Get, path, config, entries));
    }

    [Fact]
    public void RuntimeOracleProfileDoesNotScopeTheSharedCuratedVerb()
    {
        const string path = "/users/{user-id}/calendar/allowedCalendarSharingRoles(User='{User}')";
        Entry[] entries =
        [
            new(OverrideKind.ReplaceVerb, HttpMethod.Get, NormalizePathTemplate(path),
                PathMatch.Exact, "Confirm", "Shared configuration fallback"),
        ];
        var shared = new GeneratorConfig("Test.Client", "unused");

        Assert.Equal("Invoke", TryGetOverriddenVerb(HttpMethod.Get, path, shared, entries, "v1.0"));
        Assert.Equal("Confirm", TryGetOverriddenVerb(HttpMethod.Get, path, shared, entries, "beta"));
        Assert.Equal("Invoke", TryGetOverriddenVerb(HttpMethod.Get, path, shared, entries, "v1.0"));
    }

    [Theory]
    [InlineData(true, null)]
    [InlineData(false, "Confirm")]
    public void DerivedRenameWithNullVerbPreservesStructuralDefault(bool useCollisionData, string? expected)
    {
        const string path = "/applications/{application-id}/owners/{directoryObject-id}/$ref";
        Entry[] entries =
        [
            new(OverrideKind.ReplaceVerb, HttpMethod.Delete, NormalizePathTemplate(path),
                PathMatch.Exact, "Confirm", "Must not replace an authoritative derived null verb"),
        ];
        var config = new GeneratorConfig("Test.Client", "unused", UseCollisionData: useCollisionData);
        Assert.Equal(expected, TryGetOverriddenVerb(HttpMethod.Delete, path, config, entries));
    }

    [Fact]
    public void ExistingPublicLookupKeepsNullForUnmatchedOperationsAndRejectsNullArguments()
    {
        Assert.Null(TryGetOverriddenVerb(HttpMethod.Get, FunctionPath, null));
        Assert.Null(TryGetOverriddenVerb(HttpMethod.Get, FunctionPath, new("Test.Client", "unused"), "beta"));
        Assert.Throws<ArgumentNullException>(() => TryGetOverriddenVerb(null!, FunctionPath, null));
        Assert.Throws<ArgumentNullException>(() => TryGetOverriddenVerb(HttpMethod.Get, null!, null));
    }
}
