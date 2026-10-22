using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Reader;
using WrapperGenerator;
using Xunit;

namespace WrapperGenerator.Tests;

public sealed class ApplicationsDirectiveMigrationTests
{
    [Theory]
    [InlineData("v1.0")]
    [InlineData("beta")]
    public async Task ReviewedLedgerMatchesCompatibleSpecAndMigratedBehavior(string profile)
    {
        var root = FindRepoRoot();
        var settings = new OpenApiReaderSettings();
        settings.AddYamlReader();
        using var stream = File.OpenRead(Path.Combine(root, "openApiDocs_KiotaCompat", profile, "Applications.yml"));
        var result = await OpenApiDocument.LoadAsync(stream, settings: settings,
            cancellationToken: TestContext.Current.CancellationToken);
        var document = Assert.IsType<OpenApiDocument>(result.Document);
        using var ledger = JsonDocument.Parse(File.ReadAllText(Path.Combine(root,
            "src", "Applications", "wrapper", "Applications_directiveMigrationMap.json")));
        var mappings = ledger.RootElement.GetProperty("mappings").EnumerateArray().ToArray();
        Assert.Equal(4, mappings.Length);

        foreach (var mapping in mappings)
        {
            var index = mapping.GetProperty("directiveIndex").GetInt32();
            var evidence = mapping.GetProperty("profiles").GetProperty(profile);
            var operations = evidence.GetProperty("operations").EnumerateArray().ToArray();
            Assert.Equal(operations.Length == 0, evidence.GetProperty("absenceExpected").GetBoolean());
            Assert.Equal(index switch
            {
                1 => 2,
                2 => 9,
                3 when profile == "beta" => 6,
                4 => profile == "beta" ? 12 : 7,
                _ => 0,
            }, operations.Length);

            foreach (var operation in operations)
            {
                var method = new HttpMethod(operation.GetProperty("method").GetString()!);
                var path = operation.GetProperty("path").GetString()!;
                Assert.True(document.Paths.ContainsKey(path), $"Missing {profile} path: {path}");
                Assert.Equal(operation.GetProperty("operationId").GetString(),
                    document.Paths[path].Operations![method].OperationId);

                foreach (var useCollisionData in new[] { false, true })
                {
                    var config = new GeneratorConfig("Test.Client", "unused", profile, useCollisionData);
                    Assert.Equal(index is 1 or 2 or 4, CmdletConfigurator.IsSuppressed(method, path, config));
                    if (index == 3)
                    {
                        var expected = "MgOnPremisePublishingProfile" +
                            (path.EndsWith("/$count", StringComparison.Ordinal) ? "Count" : "");
                        Assert.Equal(expected, Naming.Resolve(new OperationInfo(method, path), config).Noun);
                        Assert.Equal(expected, Naming.Resolve(new OperationInfo(method, path)).Noun);
                    }
                }
            }
        }

        var credentialPaths = document.Paths
            .Where(p => p.Key.StartsWith("/servicePrincipals/{servicePrincipal-id}/federatedIdentityCredentials",
                StringComparison.Ordinal))
            .SelectMany(p => p.Value.Operations!.Select(o => $"{o.Key.Method} {p.Key}"))
            .OrderBy(p => p).ToArray();
        var reviewedCredentials = mappings[1].GetProperty("profiles").GetProperty(profile)
            .GetProperty("operations").EnumerateArray()
            .Select(o => $"{o.GetProperty("method").GetString()} {o.GetProperty("path").GetString()}")
            .OrderBy(p => p).ToArray();
        Assert.Equal(credentialPaths, reviewedCredentials);
        Assert.Equal(profile == "beta",
            document.Paths.Keys.Any(p => p.StartsWith("/onPremisesPublishingProfiles", StringComparison.Ordinal)));

        var source = File.ReadAllText(Path.Combine(root, "src", "Applications", "Applications.md"));
        var pattern = Regex.Match(source, @"(?m)^\s*- remove-path-by-operation: (.+)\r?$").Groups[1].Value.Trim();
        Assert.NotEmpty(pattern);
        var legacySelector = new Regex(pattern);
        Assert.DoesNotContain(document.Paths.Values.SelectMany(p => p.Operations!.Values),
            o => legacySelector.IsMatch(o.OperationId!));

        using var legacyStream = File.OpenRead(Path.Combine(root, "openApiDocs", profile, "Applications.yml"));
        var legacyResult = await OpenApiDocument.LoadAsync(legacyStream, settings: settings,
            cancellationToken: TestContext.Current.CancellationToken);
        var legacyDocument = Assert.IsType<OpenApiDocument>(legacyResult.Document);
        var legacyMatches = legacyDocument.Paths.SelectMany(p => p.Value.Operations!
            .Where(o => legacySelector.IsMatch(o.Value.OperationId!))
            .Select(o => $"{o.Key.Method} {CmdletConfigurator.NormalizePathTemplate(p.Key)}"))
            .OrderBy(p => p).ToArray();
        var translatedMatches = mappings[3].GetProperty("profiles").GetProperty(profile)
            .GetProperty("operations").EnumerateArray()
            .Select(o => $"{o.GetProperty("method").GetString()} " +
                CmdletConfigurator.NormalizePathTemplate(o.GetProperty("path").GetString()!))
            .OrderBy(p => p).ToArray();
        Assert.Equal(profile == "beta" ? 12 : 7, legacyMatches.Length);
        Assert.Equal(legacyMatches, translatedMatches);
        Assert.Equal("Legacy", mappings[3].GetProperty("profiles").GetProperty(profile)
            .GetProperty("operationIdSource").GetString());
        foreach (var operation in mappings[3].GetProperty("profiles").GetProperty(profile)
            .GetProperty("operations").EnumerateArray())
        {
            var method = new HttpMethod(operation.GetProperty("method").GetString()!);
            var legacyPath = operation.GetProperty("legacyPath").GetString()!;
            var legacyId = operation.GetProperty("legacyOperationId").GetString()!;
            Assert.Matches(legacySelector, legacyId);
            Assert.Equal(legacyId, legacyDocument.Paths[legacyPath].Operations![method].OperationId);
            Assert.Equal(CmdletConfigurator.NormalizePathTemplate(legacyPath),
                CmdletConfigurator.NormalizePathTemplate(operation.GetProperty("path").GetString()!));
        }
    }

    [Theory]
    [InlineData("v1.0", false)]
    [InlineData("v1.0", true)]
    [InlineData("beta", false)]
    [InlineData("beta", true)]
    public void CollectionSuppressionRetainsItemActionsAndNeighboringResources(string profile, bool useCollisionData)
    {
        var config = new GeneratorConfig("Test.Client", "unused", profile, useCollisionData);
        foreach (var parent in new[] { "/applications/{application-id}", "/servicePrincipals/{servicePrincipal-id}" })
        {
            Assert.True(CmdletConfigurator.IsSuppressed(HttpMethod.Post,
                parent + "/synchronization/jobs/validateCredentials", config));
            Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Post,
                parent + "/synchronization/jobs/{synchronizationJob-id}/validateCredentials", config));
            Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get, parent + "/synchronization/jobs", config));
            Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get, parent, config));
        }

        const string credentials = "/applications/{application-id}/federatedIdentityCredentials";
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get, credentials, config));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Post, credentials, config));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get,
            credentials + "/{federatedIdentityCredential-id}", config));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Patch,
            credentials + "/{federatedIdentityCredential-id}", config));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Delete,
            credentials + "/{federatedIdentityCredential-id}", config));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get, credentials + "/$count", config));

        Assert.True(CmdletConfigurator.IsSuppressed(HttpMethod.Patch,
            "/SERVICEPRINCIPALS/{renamed-id}/FEDERATEDIDENTITYCREDENTIALS(name='{renamed-name}')/", config));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Post,
            "/servicePrincipals/{servicePrincipal-id}/federatedIdentityCredentials(name='{name}')", config));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get,
            "/servicePrincipals/{servicePrincipal-id}/federatedIdentityCredentialsNeighbor", config));
    }

    [Theory]
    [InlineData("v1.0", false)]
    [InlineData("v1.0", true)]
    [InlineData("beta", false)]
    [InlineData("beta", true)]
    public void TranslatedLegacyCollectionSuppressionRetainsItemReferenceNeighbors(string profile, bool useCollisionData)
    {
        var config = new GeneratorConfig("Test.Client", "unused", profile, useCollisionData);
        string[] paths =
        [
            "/applications/{application-id}/owners/{directoryObject-id}/$ref",
            "/applications/{application-id}/appManagementPolicies/{appManagementPolicy-id}/$ref",
            "/applications/{application-id}/tokenIssuancePolicies/{tokenIssuancePolicy-id}/$ref",
            "/applications/{application-id}/tokenLifetimePolicies/{tokenLifetimePolicy-id}/$ref",
            "/servicePrincipals/{servicePrincipal-id}/claimsMappingPolicies/{claimsMappingPolicy-id}/$ref",
            "/servicePrincipals/{servicePrincipal-id}/homeRealmDiscoveryPolicies/{homeRealmDiscoveryPolicy-id}/$ref",
            "/servicePrincipals/{servicePrincipal-id}/owners/{directoryObject-id}/$ref",
        ];
        foreach (var path in paths)
        {
            Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Delete, path, config));
            var collectionReference = Regex.Replace(path, @"/\{[^}]+\}/\$ref$", "/$ref");
            Assert.True(CmdletConfigurator.IsSuppressed(HttpMethod.Delete, collectionReference, config));
            Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get, collectionReference, config));
        }

        if (profile == "beta")
        {
            Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Delete,
                "/onPremisesPublishingProfiles/{onPremisesPublishingProfile-id}/connectorGroups/{connectorGroup-id}/members/{connector-id}/$ref",
                config));
            Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Delete,
                "/onPremisesPublishingProfiles/{onPremisesPublishingProfile-id}/publishedResources/{publishedResource-id}/agentGroups/{onPremisesAgentGroup-id}/$ref",
                config));
            Assert.True(CmdletConfigurator.IsSuppressed(HttpMethod.Get,
                "/onPremisesPublishingProfiles/{onPremisesPublishingProfile-id}/connectors/{connector-id}/memberOf/$ref",
                config));
            Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get,
                "/onPremisesPublishingProfiles/{onPremisesPublishingProfile-id}/connectors/{connector-id}/memberOf", config));
            Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Post,
                "/onPremisesPublishingProfiles/{onPremisesPublishingProfile-id}/connectors/{connector-id}/memberOf/$ref",
                config));
            Assert.Equal("MgOnPremisePublishingProfileAgentGroup", Naming.Resolve(new OperationInfo(HttpMethod.Get,
                "/onPremisesPublishingProfiles/{onPremisesPublishingProfile-id}/agentGroups"), config).Noun);
        }
    }

    private static string FindRepoRoot()
    {
        var dir = AppContext.BaseDirectory;
        while (dir is not null && !Directory.Exists(Path.Combine(dir, "openApiDocs_KiotaCompat")))
            dir = Path.GetDirectoryName(dir);
        return dir ?? throw new InvalidOperationException("Repo root not found from test base directory.");
    }
}
