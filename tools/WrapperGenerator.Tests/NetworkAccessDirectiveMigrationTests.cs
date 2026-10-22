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
    private static readonly GeneratorConfig Beta = new("Test.Client", "unused", "beta");

    [Fact]
    public void SharedUpdateSuppressionBridgesTheExactLegacyAndCompatibleOperation()
    {
        var legacy = LoadSpec("openApiDocs");
        var compatible = LoadSpec("openApiDocs_KiotaCompat");
        Assert.Equal("networkAccess.forwardingPolicy_UpdatePolicyRule",
            legacy.Paths[Rule].Operations![HttpMethod.Patch].OperationId);
        Assert.Equal("networkAccess.forwardingPolicies.UpdatePolicyRules",
            compatible.Paths[Rule].Operations![HttpMethod.Patch].OperationId);

        var suppressed = compatible.Paths.SelectMany(path => path.Value.Operations!
            .Where(operation => CmdletConfigurator.IsSuppressed(operation.Key, path.Key, Beta))
            .Select(operation => $"{operation.Key} {path.Key}")).ToArray();
        Assert.Equal(["PATCH " + Rule], suppressed);
        Assert.True(CmdletConfigurator.IsSuppressed(HttpMethod.Patch,
            "/NETWORKACCESS/FORWARDINGPOLICIES/{renamed-id}/POLICYRULES/{renamed-rule-id}/", Beta));
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
        Assert.False(CmdletConfigurator.IsSuppressed(new HttpMethod(method), path, Beta));
    }

    [Fact]
    public async Task RealBetaGenerationOmitsOnlyTheSharedUpdateAndPreservesPublishedNeighborNames()
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
            await new PowerShellWrapperGenerationService(document, Beta with { OutputPath = output }, NullLogger.Instance)
                .GenerateAsync(CancellationToken.None);
            var files = Directory.GetFiles(output, "*.g.cs").Select(Path.GetFileName).ToArray();
            Assert.DoesNotContain("UpdateMgNetworkAccessForwardingPolicyRule.g.cs", files);
            Assert.Contains("UpdateMgNetworkAccessForwardingPolicy.g.cs", files);
            Assert.Contains("GetMgNetworkAccessForwardingPolicyRule.g.cs", files);
            Assert.Contains("GetMgNetworkAccessForwardingPolicyRule_Get.g.cs", files);
            Assert.Contains("GetMgNetworkAccessForwardingPolicyRule_List.g.cs", files);
            Assert.Contains("NewMgNetworkAccessForwardingPolicyRule.g.cs", files);
            Assert.Contains("RemoveMgNetworkAccessForwardingPolicyRule.g.cs", files);
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
