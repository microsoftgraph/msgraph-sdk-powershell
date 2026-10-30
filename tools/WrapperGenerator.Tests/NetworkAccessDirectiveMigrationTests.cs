using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Reader;
using WrapperGenerator;
using Xunit;

namespace WrapperGenerator.Tests;

public sealed class NetworkAccessDirectiveMigrationTests
{
    private const string Policy = "/networkAccess/forwardingPolicies/{forwardingPolicy-id}";
    private const string Rules = Policy + "/policyRules";
    private const string Rule = Rules + "/{policyRule-id}";
    private static readonly (string Path, string Noun)[] LinkedPolicyFamilies =
    [
        ("/networkAccess/connectivity/remoteNetworks/{remoteNetwork-id}/forwardingProfiles/{forwardingProfile-id}/policies",
            "MgNetworkAccessConnectivityRemoteNetworkForwardingProfilePolicy"),
        ("/networkAccess/filteringProfiles/{filteringProfile-id}/policies", "MgNetworkAccessFilteringProfilePolicy"),
        ("/networkAccess/forwardingProfiles/{forwardingProfile-id}/policies", "MgNetworkAccessForwardingProfilePolicy"),
    ];

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public void SharedUpdateSuppressionBridgesTheExactLegacyAndCompatibleOperation(bool useCollisionData)
    {
        var config = new GeneratorConfig("Test.Client", "unused", useCollisionData);
        var legacy = LoadSpec("openApiDocs");
        var compatible = LoadSpec("openApiDocs_KiotaCompat");
        foreach (var document in new[] { legacy, compatible })
        {
            var selection = document.Paths.SelectMany(path => path.Value.Operations!
                .Where(operation => operation.Value.OperationId == "networkAccess.forwardingPolicy_UpdatePolicyRule")
                .Select(operation => $"{operation.Key} {path.Key}")).ToArray();
            Assert.Equal(["PATCH " + Rule], selection);
        }

        var suppressed = compatible.Paths.SelectMany(path => path.Value.Operations!
            .Where(operation => CmdletConfigurator.IsSuppressed(operation.Key, path.Key, config, apiVersion: "beta"))
            .Select(operation => $"{operation.Key} {path.Key}")).ToArray();
        Assert.Equal(["PATCH " + Rule], suppressed);
        Assert.True(CmdletConfigurator.IsSuppressed(HttpMethod.Patch,
            "/NETWORKACCESS/FORWARDINGPOLICIES/{renamed-id}/POLICYRULES/{renamed-rule-id}/", config, apiVersion: "beta"));
    }

    [Theory]
    [InlineData("GET", Rule)]
    [InlineData("DELETE", Rule)]
    [InlineData("GET", Rules)]
    [InlineData("POST", Rules)]
    [InlineData("PATCH", Policy)]
    [InlineData("PATCH", "/networkAccess/filteringPolicies/{filteringPolicy-id}/policyRules/{policyRule-id}")]
    [InlineData("PATCH", "/networkAccess/cloudFirewallPolicies/{cloudFirewallPolicy-id}/policyRules/{policyRule-id}")]
    [InlineData("PATCH", "/networkAccess/threatIntelligencePolicies/{threatIntelligencePolicy-id}/policyRules/{policyRule-id}")]
    [InlineData("PATCH", "/networkAccess/tlsInspectionPolicies/{tlsInspectionPolicy-id}/policyRules/{policyRule-id}")]
    public void SharedSuppressionLeavesActualBetaNeighborsUntouched(string method, string path)
    {
        Assert.Contains(new HttpMethod(method), LoadSpec("openApiDocs_KiotaCompat").Paths[path].Operations!.Keys);
        foreach (var useCollisionData in new[] { true, false })
        {
            var config = new GeneratorConfig("Test.Client", "unused", useCollisionData);
            Assert.False(CmdletConfigurator.IsSuppressed(new HttpMethod(method), path, config, apiVersion: "beta"));
        }
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public async Task RealBetaGenerationOmitsOnlyTheSharedUpdateAndPreservesPublishedNeighborNames(bool useCollisionData)
    {
        var document = LoadSpec("openApiDocs_KiotaCompat");
        document.Paths = new OpenApiPaths
        {
            [Policy] = document.Paths[Policy],
            [Rules] = document.Paths[Rules],
            [Rule] = document.Paths[Rule],
        };
        var output = Path.Combine(Path.GetTempPath(), "networkaccess-directives", Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(output);
        try
        {
            var config = new GeneratorConfig("Test.Client", output, useCollisionData);
            await new PowerShellWrapperGenerationService(document, config, NullLogger.Instance, apiVersion: "beta")
                .GenerateAsync(CancellationToken.None);
            var files = Directory.GetFiles(output, "*.g.cs").Select(Path.GetFileName).ToArray();
            Assert.DoesNotContain("UpdateMgNetworkAccessForwardingPolicyRule.g.cs", files);
            Assert.Contains("UpdateMgNetworkAccessForwardingPolicy.g.cs", files);
            Assert.Contains("GetMgNetworkAccessForwardingPolicyRule.g.cs", files);
            Assert.Contains("GetMgNetworkAccessForwardingPolicyRule_Get.g.cs", files);
            Assert.Contains("GetMgNetworkAccessForwardingPolicyRule_List.g.cs", files);
            Assert.Contains("NewMgNetworkAccessForwardingPolicyRule.g.cs", files);
            Assert.Contains("RemoveMgNetworkAccessForwardingPolicyRule.g.cs", files);
            var sources = Directory.GetFiles(output, "*.g.cs").Select(File.ReadAllText).ToArray();
            Assert.DoesNotContain(sources, source => source.Contains($"[GraphRoute(\"PATCH\", \"{Rule}\")]"));
            Assert.Contains(sources, source => source.Contains($"[GraphRoute(\"PATCH\", \"{Policy}\")]"));
        }
        finally
        {
            Directory.Delete(output, recursive: true);
        }
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public async Task LinkedPoliciesKeepDistinctTypedNavigationsAndOrdinaryListItemDefaults(bool useCollisionData)
    {
        var document = LoadSpec("openApiDocs_KiotaCompat");
        var paths = new OpenApiPaths();
        foreach (var (path, _) in LinkedPolicyFamilies)
        {
            foreach (var route in new[] { path, path + "/{policyLink-id}", path + "/{policyLink-id}/policy" })
            {
                var item = document.Paths[route];
                paths.Add(route, new OpenApiPathItem
                {
                    Operations = new() { [HttpMethod.Get] = item.Operations![HttpMethod.Get] },
                    Parameters = item.Parameters,
                });
            }
        }
        document.Paths = paths;
        var output = Path.Combine(Path.GetTempPath(), "networkaccess-directives", Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(output);
        try
        {
            var config = new GeneratorConfig("Test.Client", output, useCollisionData);
            foreach (var (path, noun) in LinkedPolicyFamilies)
            {
                var itemPath = path + "/{policyLink-id}";
                var navigationPath = itemPath + "/policy";
                Assert.Equal("microsoft.graph.networkaccess.policyLink",
                    Assert.IsType<OpenApiSchemaReference>(document.Paths[itemPath].Operations![HttpMethod.Get]
                        .Responses!["2XX"].Content!["application/json"].Schema).Reference.Id);
                Assert.Equal("microsoft.graph.networkaccess.policy",
                    Assert.IsType<OpenApiSchemaReference>(document.Paths[navigationPath].Operations![HttpMethod.Get]
                        .Responses!["2XX"].Content!["application/json"].Schema).Reference.Id);
                foreach (var route in new[] { path, itemPath, navigationPath })
                {
                    Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get, route, config, apiVersion: "beta"));
                    Assert.Equal(route == navigationPath ? noun + "LinkPolicy" : noun,
                        Naming.Resolve(new OperationInfo(HttpMethod.Get, route), config, apiVersion: "beta").Noun);
                }
            }
            await new PowerShellWrapperGenerationService(document, config, NullLogger.Instance, apiVersion: "beta")
                .GenerateAsync(CancellationToken.None);
            var files = Directory.GetFiles(output, "*.g.cs");
            Assert.Equal(12, files.Length);
            foreach (var (path, noun) in LinkedPolicyFamilies)
            {
                var dispatcher = File.ReadAllText(Path.Combine(output, $"Get{noun}.g.cs"));
                Assert.Contains("DefaultParameterSetName = \"List\"", dispatcher);
                Assert.Contains($"[GraphRoute(\"GET\", \"{path}\")]", File.ReadAllText(Path.Combine(output, $"Get{noun}_List.g.cs")));
                Assert.Contains($"[GraphRoute(\"GET\", \"{path}/{{policyLink-id}}\")]", File.ReadAllText(Path.Combine(output, $"Get{noun}_Get.g.cs")));
                var navigation = File.ReadAllText(Path.Combine(output, $"Get{noun}LinkPolicy.g.cs"));
                Assert.Contains($"[GraphRoute(\"GET\", \"{path}/{{policyLink-id}}/policy\")]", navigation);
                Assert.Contains(".Policy.GetAsync(", navigation);
            }
        }
        finally
        {
            Directory.Delete(output, recursive: true);
        }
    }

    private static OpenApiDocument LoadSpec(string root)
    {
        var repo = AppContext.BaseDirectory;
        while (repo is not null && !File.Exists(Path.Combine(repo, "src", "NetworkAccess", "NetworkAccess.md")))
            repo = Path.GetDirectoryName(repo);
        if (repo is null)
            throw new InvalidOperationException("Repository root not found from test base directory.");
        var settings = new OpenApiReaderSettings();
        settings.AddYamlReader();
        using var stream = File.OpenRead(Path.Combine(repo, root, "beta", "NetworkAccess.yml"));
        return OpenApiDocument.LoadAsync(stream, settings: settings, cancellationToken: CancellationToken.None)
            .GetAwaiter().GetResult().Document ?? throw new InvalidOperationException("NetworkAccess beta spec could not be loaded.");
    }
}
