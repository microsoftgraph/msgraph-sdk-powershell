using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Text.RegularExpressions;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Reader;
using WrapperGenerator;
using Xunit;

namespace WrapperGenerator.Tests;

public sealed class IdentitySignInsDirectiveMigrationTests
{
    private static readonly Lazy<OpenApiDocument> V1Spec = new(() => ReadSpec("openApiDocs_KiotaCompat", "v1.0"));
    private static readonly Lazy<OpenApiDocument> BetaSpec = new(() => ReadSpec("openApiDocs_KiotaCompat", "beta"));

    [Theory]
    [InlineData("v1.0", false)]
    [InlineData("v1.0", true)]
    [InlineData("beta", false)]
    [InlineData("beta", true)]
    public void ReviewedOperationsHaveTheirIntendedDisposition(string profile, bool useCollisionData)
    {
        using var ledger = ReadLedger();
        var mappings = ledger.RootElement.GetProperty("mappings").EnumerateArray().ToArray();
        Assert.Equal(9, mappings.Length);
        var config = new GeneratorConfig("Test.Client", "unused", profile, useCollisionData);
        var operationCount = 0;
        foreach (var mapping in mappings)
        {
            var index = mapping.GetProperty("directiveIndex").GetInt32();
            foreach (var operation in mapping.GetProperty("profiles").GetProperty(profile).GetProperty("operations").EnumerateArray())
            {
                operationCount++;
                var method = new HttpMethod(operation.GetProperty("method").GetString()!);
                var path = operation.GetProperty("path").GetString()!;
                var actual = FindOperation(CompatibleSpec(profile), method, path);
                Assert.Equal(operation.GetProperty("operationId").GetString(), actual.OperationId);
                if (index is 1 or 5 or 6 or 7 or 8)
                {
                    Assert.True(CmdletConfigurator.IsSuppressed(method, path, config), $"Directive {index}: {method} {path}");
                }
                else
                {
                    Assert.False(CmdletConfigurator.IsSuppressed(method, path, config), $"Directive {index}: {method} {path}");
                    // Resource naming suffices here: action-specific verbs do not affect
                    // whether the shared subject prefix has been removed.
                    var naming = Naming.Resolve(new OperationInfo(method, path), config);
                    if (index == 2)
                        Assert.Equal("MgOauth2PermissionGrant", naming.Noun);
                    else if (index == 3)
                        Assert.Equal("MgDataPolicyOperation", naming.Noun);
                    else
                        Assert.DoesNotContain("IdentityProtection", naming.Noun, StringComparison.Ordinal);
                }
            }
        }
        Assert.Equal(profile == "v1.0" ? 90 : 116, operationCount);
    }

    [Theory]
    [InlineData("v1.0", false)]
    [InlineData("v1.0", true)]
    [InlineData("beta", false)]
    [InlineData("beta", true)]
    public void ExactSuppressionsKeepNeighboringOperations(string profile, bool useCollisionData)
    {
        var config = new GeneratorConfig("Test.Client", "unused", profile, useCollisionData);
        (string Method, string Path)[] neighbors =
        [
            ("POST", "/invitations"),
            ("GET", "/identity/conditionalAccess/namedLocations"),
            ("GET", "/identity/conditionalAccess/policies"),
            ("POST", "/identity/conditionalAccess/policies"),
            ("PATCH", "/identity/conditionalAccess/policies/{conditionalAccessPolicy-id}"),
            ("GET", "/identity/identityProviders"),
            ("POST", "/identity/identityProviders"),
            ("PATCH", "/identity/identityProviders/{identityProviderBase-id}"),
            ("DELETE", "/identity/identityProviders/{identityProviderBase-id}"),
            ("GET", "/identity/identityProviders/availableProviderTypes()"),
            ("GET", "/identity/b2xUserFlows/{b2xIdentityUserFlow-id}/userFlowIdentityProviders/$ref"),
            ("POST", "/identity/b2xUserFlows/{b2xIdentityUserFlow-id}/userFlowIdentityProviders/$ref"),
            ("DELETE", "/identity/b2xUserFlows/{b2xIdentityUserFlow-id}/userFlowIdentityProviders/{identityProviderBase-id}/$ref"),
            ("GET", "/policies/featureRolloutPolicies/{featureRolloutPolicy-id}/appliesTo/$ref"),
            ("POST", "/policies/featureRolloutPolicies/{featureRolloutPolicy-id}/appliesTo/$ref"),
            ("DELETE", "/policies/featureRolloutPolicies/{featureRolloutPolicy-id}/appliesTo/{directoryObject-id}/$ref"),
            ("GET", "/users/{user-id}/authentication/passwordMethods"),
            ("GET", "/users/{user-id}/authentication/passwordMethods/{passwordAuthenticationMethod-id}"),
            ("GET", "/users/{user-id}/authentication/passwordMethods/$count"),
            ("POST", "/identity/conditionalAccess/authenticationStrength/policies/{authenticationStrengthPolicy-id}/combinationConfigurations"),
            ("GET", "/identity/conditionalAccess/authenticationStrength/policies/{authenticationStrengthPolicy-id}/usage()"),
            ("GET", "/policies/authenticationStrengthPolicies"),
            ("POST", "/policies/authenticationStrengthPolicies"),
            ("GET", "/policies/claimsMappingPolicies/{claimsMappingPolicy-id}"),
            ("PATCH", "/policies/claimsMappingPolicies/{claimsMappingPolicy-id}"),
            ("GET", "/oauth2PermissionGrants/$count"),
            ("GET", "/oauth2PermissionGrants/delta()"),
            ("GET", "/dataPolicyOperations/$count"),
        ];
        foreach (var (method, path) in neighbors)
        {
            FindOperation(CompatibleSpec(profile), new HttpMethod(method), path);
            Assert.False(CmdletConfigurator.IsSuppressed(new HttpMethod(method), path, config), $"{profile}: {method} {path}");
        }

        if (profile == "beta")
        {
            (string Method, string Path)[] betaNeighbors =
            [
                ("GET", "/informationProtection/sensitivityLabels/$count"),
                ("GET", "/informationProtection/sensitivityLabels/{sensitivityLabel-id}/rights"),
                ("GET", "/informationProtection/sensitivityLabels/{sensitivityLabel-id}/sublabels/$count"),
                ("GET", "/informationProtection/sensitivityLabels/{sensitivityLabel-id}/sublabels/{sensitivityLabel-id1}/rights"),
                ("POST", "/informationProtection/sensitivityLabels/evaluate"),
                ("POST", "/informationProtection/sensitivityLabels/{sensitivityLabel-id}/sublabels/computeRightsAndInheritance"),
                ("GET", "/users/{user-id}/informationProtection/sensitivityLabels"),
                ("GET", "/users/{user-id}/authentication/qrCodePinMethod/pin"),
                ("PATCH", "/users/{user-id}/authentication/qrCodePinMethod/pin"),
                ("DELETE", "/users/{user-id}/authentication/qrCodePinMethod/pin"),
            ];
            foreach (var (method, path) in betaNeighbors)
            {
                FindOperation(CompatibleSpec(profile), new HttpMethod(method), path);
                Assert.False(CmdletConfigurator.IsSuppressed(new HttpMethod(method), path, config), $"{profile}: {method} {path}");
            }
        }
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void UnnumberedStrengthSuppressionDoesNotBroadenToTheLegacyPluralAlias(bool useCollisionData)
    {
        var config = new GeneratorConfig("Test.Client", "unused", "beta", useCollisionData);
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get, "/identity/conditionalAccess/authenticationStrengths", config));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Post, "/identity/conditionalAccess/authenticationStrengths/policies", config));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Patch, "/identity/conditionalAccess/authenticationStrengths/policies/{id}", config));
    }

    [Theory]
    [InlineData("v1.0", 21, 14)]
    [InlineData("beta", 22, 15)]
    public void LegacyOperationIdLedgerAccountsForAllOriginalMatches(string profile, int legacyCount, int survivingCount)
    {
        using var ledger = ReadLedger();
        var mappings = ledger.RootElement.GetProperty("mappings").EnumerateArray().ToArray();
        var suppression = mappings.Single(m => m.GetProperty("directiveIndex").GetInt32() == 1)
            .GetProperty("profiles").GetProperty(profile);
        Assert.Equal("Legacy", suppression.GetProperty("operationIdSource").GetString());
        var surviving = suppression.GetProperty("operations").EnumerateArray().ToArray();
        var removed = suppression.GetProperty("removedLegacyOperations").EnumerateArray().ToArray();
        Assert.Equal(survivingCount, surviving.Length);
        Assert.Equal(legacyCount, surviving.Length + removed.Length);
        Assert.Equal(7, removed.Length);
        var legacy = ReadSpec("openApiDocs", profile);
        var pattern = mappings[0].GetProperty("sourceContains").GetString()!["remove-path-by-operation: ".Length..];
        var actualLegacyMatches = legacy.Paths
            .Where(path => path.Value.Operations is not null)
            .SelectMany(path => path.Value.Operations!
                .Where(operation => Regex.IsMatch(operation.Value.OperationId ?? string.Empty, pattern))
                .Select(operation => $"{operation.Key.Method} {path.Key} [{operation.Value.OperationId}]"))
            .OrderBy(key => key, StringComparer.Ordinal).ToArray();
        var reviewedLegacyMatches = surviving
            .Select(op => $"{op.GetProperty("method").GetString()} {op.GetProperty("legacyPath").GetString()} [{op.GetProperty("legacyOperationId").GetString()}]")
            .Concat(removed.Select(op => $"{op.GetProperty("method").GetString()} {op.GetProperty("path").GetString()} [{op.GetProperty("operationId").GetString()}]"))
            .OrderBy(key => key, StringComparer.Ordinal).ToArray();
        Assert.Equal(actualLegacyMatches, reviewedLegacyMatches);
        Assert.All(removed, op => Assert.StartsWith("/identityProviders", op.GetProperty("path").GetString()));
        Assert.All(surviving, op =>
        {
            Assert.False(string.IsNullOrWhiteSpace(op.GetProperty("legacyPath").GetString()));
            Assert.False(string.IsNullOrWhiteSpace(op.GetProperty("legacyOperationId").GetString()));
        });
        var translated = surviving.Where(op => op.TryGetProperty("legacyPathTranslation", out _)).ToArray();
        if (profile == "beta")
        {
            var pin = Assert.Single(translated);
            Assert.Equal("UnqualifyFinalOperation", pin.GetProperty("legacyPathTranslation").GetString());
            Assert.Equal("POST", pin.GetProperty("method").GetString());
            Assert.Equal("/users/{user-id}/authentication/qrCodePinMethod/pin/updatePin", pin.GetProperty("path").GetString());
            Assert.Equal("/users/{user-id}/authentication/qrCodePinMethod/pin/microsoft.graph.updatePin", pin.GetProperty("legacyPath").GetString());
        }
        else
        {
            Assert.Empty(translated);
        }
        var numberedProvider = mappings.Single(m => m.GetProperty("directiveIndex").GetInt32() == 9)
            .GetProperty("profiles").GetProperty(profile);
        Assert.True(numberedProvider.GetProperty("absenceExpected").GetBoolean());
        Assert.Empty(numberedProvider.GetProperty("operations").EnumerateArray());
        Assert.Contains(removed, op => op.GetProperty("method").GetString() == "PATCH"
            && op.GetProperty("path").GetString() == "/identityProviders/{identityProvider-id}");
    }

    [Theory]
    [InlineData("v1.0")]
    [InlineData("beta")]
    public void DerivedRiskActionNamesRemainAuthoritative(string profile)
    {
        const string path = "/identityProtection/riskyUsers/confirmCompromised";
        var config = new GeneratorConfig("Test.Client", "unused", profile);
        var naming = Naming.Resolve(new OperationInfo(HttpMethod.Post, path, Kind: OperationKind.Action), config);
        Assert.Equal(profile == "v1.0" ? "Confirm" : "Invoke", naming.VerbName);
        Assert.Equal(profile == "v1.0" ? "MgRiskyUserCompromised" : "MgRiskyUserConfirmCompromised", naming.Noun);
    }

    private static OpenApiDocument CompatibleSpec(string profile) => profile switch
    {
        "v1.0" => V1Spec.Value,
        "beta" => BetaSpec.Value,
        _ => throw new ArgumentOutOfRangeException(nameof(profile)),
    };

    private static OpenApiOperation FindOperation(OpenApiDocument document, HttpMethod method, string path)
    {
        Assert.True(document.Paths.TryGetValue(path, out var item), $"Compatible spec is missing {path}");
        Assert.NotNull(item!.Operations);
        Assert.True(item.Operations.TryGetValue(method, out var operation), $"Compatible spec is missing {method} {path}");
        return operation!;
    }

    private static OpenApiDocument ReadSpec(string root, string profile)
    {
        var settings = new OpenApiReaderSettings();
        settings.AddYamlReader();
        using var stream = File.OpenRead(Path.Combine(FindRepoRoot(), root, profile, "Identity.SignIns.yml"));
        return OpenApiDocument.LoadAsync(stream, settings: settings).GetAwaiter().GetResult().Document
            ?? throw new InvalidOperationException($"Failed to read {root}/{profile}/Identity.SignIns.yml.");
    }

    private static JsonDocument ReadLedger() =>
        JsonDocument.Parse(File.ReadAllText(Path.Combine(FindRepoRoot(), "src", "Identity.SignIns", "wrapper", "Identity.SignIns_directiveMigrationMap.json")));

    private static string FindRepoRoot()
    {
        var directory = AppContext.BaseDirectory;
        while (directory is not null)
        {
            var path = Path.Combine(directory, "src", "Identity.SignIns", "wrapper", "Identity.SignIns_directiveMigrationMap.json");
            if (File.Exists(path))
                return directory;
            directory = Path.GetDirectoryName(directory);
        }
        throw new InvalidOperationException("Identity.SignIns directive migration ledger not found.");
    }
}
