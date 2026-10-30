using System;
using System.Collections.Generic;
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
        var config = new GeneratorConfig("Test.Client", "unused", useCollisionData);
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
                    Assert.True(CmdletConfigurator.IsSuppressed(method, path, config, apiVersion: profile), $"Directive {index}: {method} {path}");
                }
                else
                {
                    Assert.False(CmdletConfigurator.IsSuppressed(method, path, config, apiVersion: profile), $"Directive {index}: {method} {path}");
                    // Resource naming suffices here: action-specific verbs do not affect
                    // whether the shared subject prefix has been removed.
                    var naming = Naming.Resolve(new OperationInfo(method, path), config, apiVersion: profile);
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
        var config = new GeneratorConfig("Test.Client", "unused", useCollisionData);
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
            Assert.False(CmdletConfigurator.IsSuppressed(new HttpMethod(method), path, config, apiVersion: profile), $"{profile}: {method} {path}");
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
                Assert.False(CmdletConfigurator.IsSuppressed(new HttpMethod(method), path, config, apiVersion: profile), $"{profile}: {method} {path}");
            }
        }
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void UnnumberedStrengthSuppressionDoesNotBroadenToTheLegacyPluralAlias(bool useCollisionData)
    {
        var config = new GeneratorConfig("Test.Client", "unused", useCollisionData);
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get, "/identity/conditionalAccess/authenticationStrengths", config, apiVersion: "beta"));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Post, "/identity/conditionalAccess/authenticationStrengths/policies", config, apiVersion: "beta"));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Patch, "/identity/conditionalAccess/authenticationStrengths/policies/{id}", config, apiVersion: "beta"));
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
        Assert.False(suppression.TryGetProperty("operationIdSource", out _));
        Assert.False(suppression.TryGetProperty("removedLegacyOperations", out _));
        var surviving = suppression.GetProperty("operations").EnumerateArray().ToArray();
        Assert.Equal(survivingCount, surviving.Length);
        var legacy = ReadSpec("openApiDocs", profile);
        var pattern = mappings[0].GetProperty("sourceContains").GetString()!["remove-path-by-operation: ".Length..];
        var selected = Operations(legacy).Where(op => Regex.IsMatch(op.Operation.OperationId ?? string.Empty, pattern)).ToArray();
        Assert.Equal(legacyCount, selected.Length);
        var removed = selected.Where(op => op.Path.StartsWith("/identityProviders", StringComparison.Ordinal)).ToArray();
        Assert.Equal(7, removed.Length);
        foreach (var old in removed)
        {
            Assert.DoesNotContain(Operations(CompatibleSpec(profile)), op => op.Method == old.Method
                && CmdletConfigurator.NormalizePathTemplate(op.Path) == CmdletConfigurator.NormalizePathTemplate(old.Path.Replace("/microsoft.graph.", "/", StringComparison.Ordinal)));
        }
        var bridged = selected.Except(removed).Select(old => Bridge(CompatibleSpec(profile), old)).ToArray();
        var literal = Operations(CompatibleSpec(profile))
            .Where(op => Regex.IsMatch(op.Operation.OperationId ?? string.Empty, pattern)).ToArray();
        Assert.Equal(bridged.Select(Triple).OrderBy(x => x, StringComparer.Ordinal),
            literal.Select(Triple).OrderBy(x => x, StringComparer.Ordinal));
        Assert.Equal(bridged.Select(Triple).OrderBy(x => x, StringComparer.Ordinal),
            surviving.Select(op => $"{op.GetProperty("method").GetString()} {op.GetProperty("path").GetString()} [{op.GetProperty("operationId").GetString()}]")
                .OrderBy(x => x, StringComparer.Ordinal));
        Assert.All(surviving, op =>
        {
            Assert.False(op.TryGetProperty("legacyPath", out _));
            Assert.False(op.TryGetProperty("legacyOperationId", out _));
            Assert.False(op.TryGetProperty("legacyPathTranslation", out _));
        });
        if (profile == "beta")
        {
            var oldPin = Assert.Single(selected, op => op.Operation.OperationId == "user.authentication.qrCodePinMethod.pin_updatePin");
            Assert.Equal("/users/{user-id}/authentication/qrCodePinMethod/pin/microsoft.graph.updatePin", oldPin.Path);
            Assert.Equal("/users/{user-id}/authentication/qrCodePinMethod/pin/updatePin", Bridge(CompatibleSpec(profile), oldPin).Path);
        }
        var numberedProvider = mappings.Single(m => m.GetProperty("directiveIndex").GetInt32() == 9)
            .GetProperty("profiles").GetProperty(profile);
        Assert.True(numberedProvider.GetProperty("absenceExpected").GetBoolean());
        Assert.Empty(numberedProvider.GetProperty("operations").EnumerateArray());
        Assert.Contains(removed, op => op.Method == HttpMethod.Patch && op.Path == "/identityProviders/{identityProvider-id}");
    }

    [Theory]
    [InlineData("v1.0", true)]
    [InlineData("beta", true)]
    [InlineData("v1.0", false)]
    [InlineData("beta", false)]
    public void DerivedRiskActionNamesRemainAuthoritative(string profile, bool useCollisionData)
    {
        const string path = "/identityProtection/riskyUsers/confirmCompromised";
        var config = new GeneratorConfig("Test.Client", "unused", useCollisionData);
        var naming = Naming.Resolve(new OperationInfo(HttpMethod.Post, path, Kind: OperationKind.Action), config, apiVersion: profile);
        Assert.Equal(profile == "v1.0" && useCollisionData ? "Confirm" : "Invoke", naming.VerbName);
        Assert.Equal(profile == "v1.0" && useCollisionData ? "MgRiskyUserCompromised" : "MgRiskyUserConfirmCompromised", naming.Noun);
    }

    [Theory]
    [InlineData("v1.0")]
    [InlineData("beta")]
    public void WhereSelectorLedgersCoverEverySurvivingOriginalSourceOperation(string profile)
    {
        using var ledger = ReadLedger();
        var legacy = Operations(ReadSpec("openApiDocs", profile)).ToArray();
        foreach (var mapping in ledger.RootElement.GetProperty("mappings").EnumerateArray().Where(m => m.GetProperty("directiveIndex").GetInt32() != 1))
        {
            var index = mapping.GetProperty("directiveIndex").GetInt32();
            var source = legacy.Where(op => index switch
            {
                2 => Regex.IsMatch(op.Operation.OperationId!, @"^oauth2PermissionGrant_(List|Create|Get|Update|Delete)OAuth2PermissionGrant$"),
                3 => Regex.IsMatch(op.Operation.OperationId!, @"^dataPolicyOperation_(List|Create|Get|Update|Delete)DataPolicyOperation$"),
                4 => op.Path.StartsWith("/identityProtection/", StringComparison.Ordinal),
                5 => Regex.IsMatch(op.Operation.OperationId!, @"^user_(Get|Update|Delete)Authentication$"),
                6 => Regex.IsMatch(op.Operation.OperationId!, @"^informationProtection_(List|Create|Get|Update|Delete)SensitivityLabel$|^informationProtection\.sensitivityLabel_(List|Create|Get|Update|Delete)Sublabel$"),
                7 => Regex.IsMatch(op.Operation.OperationId!, @"^user\.authentication_(Create|Update)PasswordMethod$"),
                8 => op.Path.StartsWith("/identity/conditionalAccess/authenticationStrength/", StringComparison.Ordinal)
                    && !op.Path.EndsWith("/microsoft.graph.usage()", StringComparison.Ordinal)
                    && !(op.Method == HttpMethod.Post && op.Path.EndsWith("/combinationConfigurations", StringComparison.Ordinal))
                    || op.Path == "/identity/conditionalAccess/authenticationStrength",
                9 => op.Method == HttpMethod.Patch && op.Path == "/identityProviders/{identityProvider-id}",
                _ => throw new InvalidOperationException($"Unexpected shared directive {index}."),
            }).ToArray();
            var removed = source.Where(op => index == 9
                || index == 8 && op.Operation.OperationId == "identity.conditionalAccess.authenticationStrength.policy_findGraphBPreMethodMode").ToArray();
            foreach (var old in removed)
            {
                var target = old.Path.Replace("/microsoft.graph.", "/", StringComparison.Ordinal);
                Assert.DoesNotContain(Operations(CompatibleSpec(profile)), op => op.Method == old.Method
                    && CmdletConfigurator.NormalizePathTemplate(op.Path) == CmdletConfigurator.NormalizePathTemplate(target));
            }
            Assert.Equal(index == 9 || index == 8 && profile == "beta" ? 1 : 0, removed.Length);
            var expected = source.Except(removed).Select(op => Triple(Bridge(CompatibleSpec(profile), op))).OrderBy(x => x, StringComparer.Ordinal);
            var actual = mapping.GetProperty("profiles").GetProperty(profile).GetProperty("operations").EnumerateArray()
                .Select(op => $"{op.GetProperty("method").GetString()} {op.GetProperty("path").GetString()} [{op.GetProperty("operationId").GetString()}]")
                .OrderBy(x => x, StringComparer.Ordinal);
            Assert.Equal(expected, actual);
        }
    }

    [Theory]
    [InlineData("v1.0", false)]
    [InlineData("v1.0", true)]
    [InlineData("beta", false)]
    [InlineData("beta", true)]
    public void CollisionCorrectionsKeepDistinctSourceContractsAndDerivedPrecedence(string profile, bool useCollisionData)
    {
        var config = new GeneratorConfig("Test.Client", "unused", useCollisionData);
        const string attributes = "/identity/authenticationEventsFlows/{authenticationEventsFlow-id}/graph.externalUsersSelfServiceSignUpEventsFlow/onAttributeCollection/graph.onAttributeCollectionExternalUsersSelfServiceSignUp/attributes";
        const string providers = "/identity/authenticationEventsFlows/{authenticationEventsFlow-id}/graph.externalUsersSelfServiceSignUpEventsFlow/onAuthenticationMethodLoadStart/graph.onAuthenticationMethodLoadStartExternalUsersSelfServiceSignUp/identityProviders";
        (string Collection, string Item, string ItemNoun)[] references =
        [
            (attributes + "/$ref", attributes + "/{identityUserFlowAttribute-id}/$ref",
                "MgIdentityAuthenticationEventFlowAsExternalUserSelfServiceSignUpEventFlowOnAttributeCollectionAsOnAttributeCollectionExternalUserSelfServiceSignUpAttributeIdentityUserFlowAttributeByRef"),
            (providers + "/$ref", providers + "/{identityProviderBase-id}/$ref",
                "MgIdentityAuthenticationEventFlowAsExternalUserSelfServiceSignUpEventFlowOnAuthenticationMethodLoadStartAsOnAuthenticationMethodLoadStartExternalUserSelfServiceSignUpIdentityProviderBaseByRef"),
        ];
        if (profile == "beta")
        {
            references = [.. references,
                ("/policies/mobileAppManagementPolicies/{mobileAppManagementPolicy-id}/includedGroups/$ref",
                    "/policies/mobileAppManagementPolicies/{mobileAppManagementPolicy-id}/includedGroups/{group-id}/$ref",
                    "MgPolicyMobileAppManagementPolicyIncludedGroupGroupByRef"),
                ("/policies/mobileDeviceManagementPolicies/{mobileDeviceManagementPolicy-id}/includedGroups/$ref",
                    "/policies/mobileDeviceManagementPolicies/{mobileDeviceManagementPolicy-id}/includedGroups/{group-id}/$ref",
                    "MgPolicyMobileDeviceManagementPolicyIncludedGroupGroupByRef")];
        }
        foreach (var (collection, item, expectedNoun) in references)
        {
            var collectionOperation = FindOperation(CompatibleSpec(profile), HttpMethod.Delete, collection);
            var itemOperation = FindOperation(CompatibleSpec(profile), HttpMethod.Delete, item);
            Assert.Contains(collectionOperation.Parameters!, p => p.Name == "@id" && p.In == ParameterLocation.Query && p.Required);
            Assert.DoesNotContain(itemOperation.Parameters!, p => p.In == ParameterLocation.Query);
            var collectionName = Naming.Resolve(new OperationInfo(HttpMethod.Delete, collection), config, apiVersion: profile);
            var itemName = Naming.Resolve(new OperationInfo(HttpMethod.Delete, item), config, apiVersion: profile);
            Assert.NotEqual(collectionName.Noun, itemName.Noun);
            Assert.Equal(expectedNoun, itemName.Noun);
            Assert.Equal(profile == "v1.0" && useCollisionData, CmdletConfigurator.IsSuppressed(HttpMethod.Delete, collection, config, apiVersion: profile));
            Assert.Equal(profile == "v1.0" && useCollisionData, CmdletConfigurator.IsSuppressed(HttpMethod.Delete, item, config, apiVersion: profile));
        }

        const string collectionAction = "/identity/customAuthenticationExtensions/validateAuthenticationConfiguration";
        const string itemAction = "/identity/customAuthenticationExtensions/{customAuthenticationExtension-id}/validateAuthenticationConfiguration";
        var collectionPost = FindOperation(CompatibleSpec(profile), HttpMethod.Post, collectionAction);
        var itemPost = FindOperation(CompatibleSpec(profile), HttpMethod.Post, itemAction);
        Assert.True(collectionPost.RequestBody!.Required);
        Assert.Equal(["authenticationConfiguration", "endpointConfiguration"],
            collectionPost.RequestBody.Content!["application/json"].Schema!.Properties!.Keys.OrderBy(x => x, StringComparer.Ordinal));
        Assert.Null(itemPost.RequestBody);
        foreach (var (path, expectedNoun) in new[]
        {
            (collectionAction, "MgIdentityCustomAuthenticationExtensionEndpointAuthenticationConfiguration"),
            (itemAction, "MgIdentityCustomAuthenticationExtensionAuthenticationConfiguration"),
        })
        {
            var naming = Naming.Resolve(new OperationInfo(HttpMethod.Post, path, Kind: OperationKind.Action), config, apiVersion: profile);
            Assert.Equal("Test", naming.VerbName);
            Assert.Equal(expectedNoun, naming.Noun);
        }
        Assert.Equal(profile == "v1.0" && useCollisionData,
            CmdletConfigurator.IsSuppressed(HttpMethod.Post, collectionAction, config, apiVersion: profile));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Post, itemAction, config, apiVersion: profile));
    }

    private sealed record SourceOperation(HttpMethod Method, string Path, OpenApiOperation Operation);

    private static IEnumerable<SourceOperation> Operations(OpenApiDocument document) =>
        document.Paths.SelectMany(path => (path.Value.Operations ?? new Dictionary<HttpMethod, OpenApiOperation>())
            .Select(operation => new SourceOperation(operation.Key, path.Key, operation.Value)));

    private static string Triple(SourceOperation operation) =>
        $"{operation.Method.Method} {operation.Path} [{operation.Operation.OperationId}]";

    private static string OperationKindOf(SourceOperation operation) =>
        operation.Operation.Extensions?.TryGetValue("x-ms-docs-operation-type", out var kind) == true
            ? kind is JsonNodeExtension node ? node.Node?.ToString().Trim('"') ?? string.Empty : string.Empty
            : string.Empty;

    private static SourceOperation Bridge(OpenApiDocument current, SourceOperation old)
    {
        var exact = Operations(current).Where(op => op.Method == old.Method && op.Path == old.Path).ToArray();
        if (exact.Length != 0)
            return Assert.Single(exact);
        var kind = OperationKindOf(old);
        Assert.True(kind == "action" && old.Method == HttpMethod.Post || kind == "function" && old.Method == HttpMethod.Get,
            $"Only actual actions/functions may unqualify their final segment: {Triple(old)}");
        var slash = old.Path.LastIndexOf('/');
        var final = old.Path[(slash + 1)..];
        Assert.StartsWith("microsoft.graph.", final);
        var path = old.Path[..(slash + 1)] + final["microsoft.graph.".Length..];
        var result = Assert.Single(Operations(current), op => op.Method == old.Method && op.Path == path);
        Assert.Equal(kind, OperationKindOf(result));
        return result;
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
