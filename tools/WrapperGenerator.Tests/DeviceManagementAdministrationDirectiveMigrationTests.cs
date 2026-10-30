using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Reader;
using WrapperGenerator;
using Xunit;

namespace WrapperGenerator.Tests;

public sealed class DeviceManagementAdministrationDirectiveMigrationTests
{
    private const string Module = "DeviceManagement.Administration";
    private const string Profile = "v1.0";
    private const string Root = "/deviceManagement/virtualEndpoint";
    private static readonly GeneratorConfig Config = new("Test.Client", "unused");
    private static readonly Lazy<OpenApiDocument> Legacy = new(() => Load("openApiDocs"));
    private static readonly Lazy<OpenApiDocument> Compatible = new(() => Load("openApiDocs_KiotaCompat"));

    [Theory]
    [InlineData("POST", "/auditEvents", "CreateAuditEvent")]
    [InlineData("PATCH", "/auditEvents/{cloudPcAuditEvent-id}", "UpdateAuditEvent")]
    [InlineData("DELETE", "/auditEvents/{cloudPcAuditEvent-id}", "DeleteAuditEvent")]
    [InlineData("POST", "/cloudPCs", "CreateCloudPC")]
    [InlineData("PATCH", "/cloudPCs/{cloudPC-id}", "UpdateCloudPC")]
    [InlineData("DELETE", "/cloudPCs/{cloudPC-id}", "DeleteCloudPC")]
    public void CollectionWritesReuseExistingDerivedSuppressions(string method, string suffix, string operationId)
    {
        AssertSuppressedBridge(method, Root + suffix,
            "deviceManagement.virtualEndpoint_" + operationId);
    }

    [Theory]
    [InlineData("PATCH", "Update")]
    [InlineData("DELETE", "Delete")]
    public void SingletonWritesReuseExistingDerivedSuppressions(string method, string verb)
    {
        AssertSuppressedBridge(method, Root,
            "deviceManagement_" + verb + "VirtualEndpoint");
    }

    [Fact]
    public void ReviewedLedgerCoversAllAndOnlySelectedWrites()
    {
        using var ledger = JsonDocument.Parse(File.ReadAllText(Path.Combine(RepoRoot(), "src", Module,
            "wrapper", Module + "_directiveMigrationMap.json")));
        var mappings = ledger.RootElement.GetProperty("mappings").EnumerateArray().ToArray();
        Assert.Equal(4, mappings.Length);
        for (var i = 0; i < mappings.Length; i++)
        {
            Assert.Equal(i + 1, mappings[i].GetProperty("directiveIndex").GetInt32());
            var profile = mappings[i].GetProperty("profiles").GetProperty(Profile);
            var expected = Compatible.Value.Paths
                .Where(path => i == 2
                    ? path.Key == Root + "/auditEvents" || path.Key == Root + "/auditEvents/{cloudPcAuditEvent-id}"
                        || path.Key == Root + "/cloudPCs" || path.Key == Root + "/cloudPCs/{cloudPC-id}"
                    : i == 3 && path.Key == Root)
                .SelectMany(path => path.Value.Operations!
                    .Where(op => op.Key == HttpMethod.Post || op.Key == HttpMethod.Patch || op.Key == HttpMethod.Delete)
                    .Select(op => $"{op.Key.Method} {path.Key} [{op.Value.OperationId}]"))
                .OrderBy(key => key, StringComparer.Ordinal).ToArray();
            var reviewed = profile.GetProperty("operations").EnumerateArray()
                .Select(op => $"{op.GetProperty("method").GetString()} {op.GetProperty("path").GetString()} [{op.GetProperty("operationId").GetString()}]")
                .OrderBy(key => key, StringComparer.Ordinal).ToArray();
            Assert.Equal(i < 2, profile.GetProperty("absenceExpected").GetBoolean());
            Assert.Equal(i < 2 ? 0 : i == 2 ? 6 : 2, reviewed.Length);
            Assert.Equal(expected, reviewed);

            var beta = mappings[i].GetProperty("profiles").GetProperty("beta");
            Assert.True(beta.GetProperty("excluded").GetBoolean());
            Assert.Empty(beta.GetProperty("operations").EnumerateArray());
            Assert.False(beta.TryGetProperty("absenceExpected", out _));
            Assert.Contains("Missing compatible beta spec", beta.GetProperty("notes").GetString());
        }
        Assert.False(File.Exists(Path.Combine(RepoRoot(), "openApiDocs_KiotaCompat", "beta", Module + ".yml")));
        Assert.True(File.Exists(Path.Combine(RepoRoot(), "openApiDocs", "beta", Module + ".yml")));
    }

    [Fact]
    public void GroupPolicySubjectsAndSingletonCreateAreAbsentFromBothActualV1Sources()
    {
        foreach (var document in new[] { Legacy.Value, Compatible.Value })
        {
            Assert.DoesNotContain(document.Paths.Keys, path =>
                path.Contains("groupPolicyMigrationReports", StringComparison.OrdinalIgnoreCase)
                || path.Contains("groupPolicyUploadedDefinitionFiles", StringComparison.OrdinalIgnoreCase));
            Assert.False(document.Paths[Root].Operations!.ContainsKey(HttpMethod.Post));
        }
    }

    [Theory]
    [InlineData("/auditEvents/microsoft.graph.getAuditActivityTypes()", "/auditEvents/getAuditActivityTypes()",
        "auditEvent_getAuditActivityType",
        "MgDeviceManagementVirtualEndpointAuditEventAuditActivityType")]
    [InlineData("/deviceImages/microsoft.graph.getSourceImages()", "/deviceImages/getSourceImages()",
        "deviceImage_getSourceImage",
        "MgDeviceManagementVirtualEndpointDeviceImageSourceImage")]
    public void FunctionSubjectsAreReadOnlyAndDoNotMatchTheWriteVerbSelector(
        string legacySuffix, string compatibleSuffix, string operationId, string noun)
    {
        var legacyPath = Legacy.Value.Paths[Root + legacySuffix];
        var compatiblePath = Compatible.Value.Paths[Root + compatibleSuffix];
        Assert.Equal(HttpMethod.Get, Assert.Single(legacyPath.Operations!).Key);
        Assert.Equal(HttpMethod.Get, Assert.Single(compatiblePath.Operations!).Key);
        Assert.Equal("deviceManagement.virtualEndpoint." + operationId,
            legacyPath.Operations![HttpMethod.Get].OperationId);
        Assert.Equal("deviceManagement.virtualEndpoint." + operationId,
            compatiblePath.Operations![HttpMethod.Get].OperationId);
        AssertNaming("GET", Root + compatibleSuffix, OperationKind.Function, "Get", noun);
    }

    [Theory]
    [InlineData("GET", "", "MgDeviceManagementVirtualEndpoint")]
    [InlineData("GET", "/auditEvents", "MgDeviceManagementVirtualEndpointAuditEvent")]
    [InlineData("GET", "/auditEvents/{cloudPcAuditEvent-id}", "MgDeviceManagementVirtualEndpointAuditEvent")]
    [InlineData("GET", "/cloudPCs", "MgDeviceManagementVirtualEndpointCloudPc")]
    [InlineData("GET", "/cloudPCs/{cloudPC-id}", "MgDeviceManagementVirtualEndpointCloudPc")]
    [InlineData("POST", "/deviceImages", "MgDeviceManagementVirtualEndpointDeviceImage")]
    public void NeighboringReadsAndNestedWritesRemainAvailable(string method, string suffix, string noun)
    {
        AssertNaming(method, Root + suffix, OperationKind.Resource, method == "GET" ? "Get" : "New", noun);
    }

    [Fact]
    public void CurrentAdministrationOwnedActionIsNotSuppressedOrMovedToHistoricalActionsModule()
    {
        const string path = Root + "/cloudPCs/{cloudPC-id}/reboot";
        var operation = Compatible.Value.Paths[path].Operations![HttpMethod.Post];
        Assert.Equal("deviceManagement.virtualEndpoint.cloudPC_reboot", operation.OperationId);
        AssertNaming("POST", path, OperationKind.Action, "Restart", "MgDeviceManagementVirtualEndpointCloudPc");
        Assert.False(File.Exists(Path.Combine(RepoRoot(), "openApiDocs_KiotaCompat", "v1.0", "DeviceManagement.Actions.yml")));
    }

    [Theory]
    [InlineData("/deviceManagement/deviceManagementPartners")]
    [InlineData("/deviceManagement/deviceManagementPartners/{deviceManagementPartner-id}")]
    public void ExistingCuratedPartnerNamesArePreserved(string path)
    {
        AssertNaming("GET", path, OperationKind.Resource, "Get", "MgDeviceManagementPartner");
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public void SeparateProfileContextPreservesStructuralAndCuratedNeighbors(bool useCollisionData)
    {
        var config = Config with { UseCollisionData = useCollisionData };
        foreach (var (path, noun) in new[]
        {
            (Root, "MgDeviceManagementVirtualEndpoint"),
            ("/deviceManagement/deviceManagementPartners", "MgDeviceManagementPartner"),
        })
        {
            Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get, path, config, apiVersion: Profile));
            var naming = Naming.Resolve(new OperationInfo(HttpMethod.Get, path), config, apiVersion: Profile);
            Assert.Equal("Get", naming.VerbName);
            Assert.Equal(noun, naming.Noun);
        }
    }

    private static void AssertSuppressedBridge(string method, string path, string operationId)
    {
        var httpMethod = new HttpMethod(method);
        Assert.Equal(operationId, Legacy.Value.Paths[path].Operations![httpMethod].OperationId);
        Assert.Equal(operationId, Compatible.Value.Paths[path].Operations![httpMethod].OperationId);
        Assert.True(CmdletConfigurator.IsSuppressed(httpMethod, path, Config, apiVersion: Profile));
        Assert.True(DerivedCollisionResolutions.IsSuppressed(Profile, httpMethod,
            CmdletConfigurator.NormalizePathTemplate(path)));
        Assert.False(CmdletConfigurator.IsSuppressed(httpMethod, path, Config with { UseCollisionData = false },
            apiVersion: Profile));
    }

    private static void AssertNaming(string method, string path, OperationKind kind, string verb, string noun)
    {
        var httpMethod = new HttpMethod(method);
        Assert.True(Compatible.Value.Paths[path].Operations!.ContainsKey(httpMethod));
        Assert.False(CmdletConfigurator.IsSuppressed(httpMethod, path, Config, apiVersion: Profile));
        var naming = Naming.Resolve(new OperationInfo(httpMethod, path, Kind: kind), Config, apiVersion: Profile);
        Assert.Equal(verb, naming.VerbName);
        Assert.Equal(noun, naming.Noun);
    }

    private static OpenApiDocument Load(string specRoot)
    {
        var settings = new OpenApiReaderSettings();
        settings.AddYamlReader();
        using var stream = File.OpenRead(Path.Combine(RepoRoot(), specRoot, Profile, Module + ".yml"));
        return OpenApiDocument.LoadAsync(stream, settings: settings).GetAwaiter().GetResult().Document
            ?? throw new InvalidDataException($"Could not load {specRoot} v1.0 {Module}.");
    }

    private static string RepoRoot()
    {
        var directory = AppContext.BaseDirectory;
        while (directory is not null && !File.Exists(Path.Combine(directory, "tools", "Get-WrapperDirectiveMigrationInventory.ps1")))
            directory = Path.GetDirectoryName(directory);
        return directory ?? throw new DirectoryNotFoundException("Repository root not found.");
    }
}
