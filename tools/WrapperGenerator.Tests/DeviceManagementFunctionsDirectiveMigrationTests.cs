using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Reader;
using WrapperGenerator;
using Xunit;

namespace WrapperGenerator.Tests;

public sealed class DeviceManagementFunctionsDirectiveMigrationTests
{
    private sealed record FunctionRoute(string Path, string OperationId, string FileStem);

    private static FunctionRoute[] Routes(string profile) =>
    [
        new("/deviceManagement/getEffectivePermissions(scope='{scope}')",
            "deviceManagement_getEffectivePermission",
            "GetMgDeviceManagementGetEffectivePermissionsWithScope"),
        new("/deviceManagement/userExperienceAnalyticsSummarizeWorkFromAnywhereDevices()",
            "deviceManagement_userExperienceAnalyticsSummarizeWorkFromAnywhereDevice",
            "GetMgDeviceManagementUserExperienceAnalyticsSummarizeWorkFromAnywhereDevices"),
        new("/deviceManagement/verifyWindowsEnrollmentAutoDiscovery(domainName='{domainName}')",
            "deviceManagement_verifyWindowsEnrollmentAutoDiscovery",
            "GetMgDeviceManagementVerifyWindowsEnrollmentAutoDiscoveryWithDomainName"),
        .. profile == "beta" ? BetaOnlyRoutes : Array.Empty<FunctionRoute>(),
    ];

    private static readonly FunctionRoute[] BetaOnlyRoutes =
    [
        new("/deviceManagement/getAssignedRoleDetails()", "deviceManagement_getAssignedRoleDetail",
            "GetMgDeviceManagementGetAssignedRoleDetails"),
        new("/deviceManagement/getComanagedDevicesSummary()", "deviceManagement_getComanagedDevicesSummary",
            "GetMgDeviceManagementGetComanagedDevicesSummary"),
        new("/deviceManagement/getComanagementEligibleDevicesSummary()", "deviceManagement_getComanagementEligibleDevicesSummary",
            "GetMgDeviceManagementGetComanagementEligibleDevicesSummary"),
        new("/deviceManagement/getEffectivePermissions()", "deviceManagement_getEffectivePermission",
            "GetMgDeviceManagementGetEffectivePermissions"),
        new("/deviceManagement/getRoleScopeTagsByIds(ids={ids})", "deviceManagement_getRoleScopeTagsGraphBPreId",
            "GetMgDeviceManagementGetRoleScopeTagsByIdsWithIds"),
        new("/deviceManagement/getRoleScopeTagsByResource(resource='{resource}')", "deviceManagement_getRoleScopeTagsGraphBPreResource",
            "GetMgDeviceManagementGetRoleScopeTagsByResourceWithResource"),
        new("/deviceManagement/getSuggestedEnrollmentLimit(enrollmentType='{enrollmentType}')",
            "deviceManagement_getSuggestedEnrollmentLimit",
            "GetMgDeviceManagementGetSuggestedEnrollmentLimitWithEnrollmentType"),
        new("/deviceManagement/retrieveUserRoleDetail(userid='{userid}')", "deviceManagement_retrieveUserRoleDetail",
            "GetMgDeviceManagementRetrieveUserRoleDetailWithUserid"),
        new("/deviceManagement/scopedForResource(resource='{resource}')", "deviceManagement_scopedGraphFPreResource",
            "GetMgDeviceManagementScopedForResourceWithResource"),
        new("/deviceManagement/userExperienceAnalyticsSummarizedDeviceScopes()",
            "deviceManagement_userExperienceAnalyticsSummarizedDeviceScope",
            "GetMgDeviceManagementUserExperienceAnalyticsSummarizedDeviceScopes"),
    ];

    [Fact]
    public void SharedSourceHasNoDirectivesAndReviewedMappingsRemainEmpty()
    {
        var root = FindRepoRoot();
        var source = File.ReadAllText(Path.Combine(root, "src", "DeviceManagement.Functions", "DeviceManagement.Functions.md"));
        Assert.Contains("# Directives go here!", source, StringComparison.Ordinal);
        Assert.DoesNotMatch(@"(?m)^\s*directive:\s*$", source);

        using var ledger = JsonDocument.Parse(File.ReadAllText(Path.Combine(root, "src", "DeviceManagement.Functions",
            "wrapper", "DeviceManagement.Functions_directiveMigrationMap.json")));
        Assert.Empty(ledger.RootElement.GetProperty("mappings").EnumerateArray());
    }

    [Theory]
    [InlineData("v1.0", 3)]
    [InlineData("beta", 13)]
    public void CompatibleSpecRetainsExactReviewedFunctionInventory(string profile, int expectedCount)
    {
        var document = LoadSpec(profile);
        var actual = document.Paths.SelectMany(path => path.Value.Operations!
            .Select(operation => $"{operation.Key.Method} {path.Key} {operation.Value.OperationId}"))
            .OrderBy(identity => identity, StringComparer.Ordinal).ToArray();
        var expected = Routes(profile).Select(route => $"GET {route.Path} {route.OperationId}")
            .OrderBy(identity => identity, StringComparer.Ordinal).ToArray();

        Assert.Equal(expectedCount, actual.Length);
        Assert.Equal(expected, actual);
        foreach (var route in Routes(profile))
        {
            var operation = document.Paths[route.Path].Operations![HttpMethod.Get];
            var marker = Assert.IsType<JsonNodeExtension>(operation.Extensions!["x-ms-docs-operation-type"]);
            Assert.Equal("function", marker.Node!.GetValue<string>());
        }
    }

    [Theory]
    [InlineData("v1.0", false)]
    [InlineData("v1.0", true)]
    [InlineData("beta", false)]
    [InlineData("beta", true)]
    public void ReviewedFunctionsKeepExistingNamesWithoutNewSuppressions(string profile, bool useCollisionData)
    {
        var document = LoadSpec(profile);
        var config = new GeneratorConfig("Test.Client", "unused", UseCollisionData: useCollisionData);

        foreach (var route in Routes(profile))
        {
            Assert.Equal(route.OperationId, document.Paths[route.Path].Operations![HttpMethod.Get].OperationId);
            Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get, route.Path, config, apiVersion: profile));
            var naming = Naming.Resolve(new OperationInfo(HttpMethod.Get, route.Path, null, OperationKind.Function),
                config, apiVersion: profile);
            Assert.Equal(ExpectedFileStem(route, profile, useCollisionData) + "Command", naming.ClassName);
        }
    }

    [Theory]
    [InlineData("v1.0", false)]
    [InlineData("v1.0", true)]
    [InlineData("beta", false)]
    [InlineData("beta", true)]
    public async Task GenerationKeepsEveryFunctionWithSeparateProfileContext(string profile, bool useCollisionData)
    {
        var output = Path.Combine(Path.GetTempPath(), "device-management-functions-audit", Guid.NewGuid().ToString("N"));
        try
        {
            var config = new GeneratorConfig("Test.Client", output, UseCollisionData: useCollisionData);
            await new PowerShellWrapperGenerationService(LoadSpec(profile), config, NullLogger.Instance, apiVersion: profile)
                .GenerateAsync(CancellationToken.None);

            var expected = Routes(profile).Select(route => ExpectedFileStem(route, profile, useCollisionData) + ".g.cs")
                .OrderBy(name => name, StringComparer.Ordinal).ToArray();
            var actual = Directory.GetFiles(output, "*.g.cs").Select(Path.GetFileName)
                .OrderBy(name => name, StringComparer.Ordinal).ToArray();
            Assert.Equal(expected, actual);
        }
        finally
        {
            if (Directory.Exists(output))
                Directory.Delete(output, recursive: true);
        }
    }

    [Theory]
    [InlineData("v1.0")]
    [InlineData("beta")]
    public void ScopedPermissionFunctionKeepsItsInlineArgumentAndKiotaMember(string profile)
    {
        const string path = "/deviceManagement/getEffectivePermissions(scope='{scope}')";
        Assert.True(LoadSpec(profile).Paths.ContainsKey(path));
        var naming = Naming.Resolve(new OperationInfo(HttpMethod.Get, path, null, OperationKind.Function),
            new GeneratorConfig("Test.Client", "unused"), apiVersion: profile);

        var parameter = Assert.Single(naming.FunctionParameters);
        Assert.Equal("scope", parameter.TemplateName);
        Assert.Equal("Scope", parameter.PsName);
        Assert.Equal("GetEffectivePermissionsWithScope", naming.OperationMemberName);
        Assert.Equal("DeviceManagement.GetEffectivePermissionsWithScope", naming.OperationTypeNamespace);
    }

    private static string ExpectedFileStem(FunctionRoute route, string profile, bool useCollisionData) =>
        profile == "v1.0" && useCollisionData &&
        route.Path == "/deviceManagement/userExperienceAnalyticsSummarizeWorkFromAnywhereDevices()"
            ? "InvokeMgExperienceDeviceManagement"
            : route.FileStem;

    private static OpenApiDocument LoadSpec(string profile)
    {
        var path = Path.Combine(FindRepoRoot(), "openApiDocs_KiotaCompat", profile, "DeviceManagement.Functions.yml");
        Assert.True(File.Exists(path), $"Required compatible specification is missing: {path}");
        var settings = new OpenApiReaderSettings();
        settings.AddYamlReader();
        using var stream = File.OpenRead(path);
        var result = OpenApiDocument.LoadAsync(stream, settings: settings, cancellationToken: CancellationToken.None)
            .GetAwaiter().GetResult();
        return Assert.IsType<OpenApiDocument>(result.Document);
    }

    private static string FindRepoRoot()
    {
        var directory = AppContext.BaseDirectory;
        while (directory is not null && !File.Exists(Path.Combine(directory, "src", "DeviceManagement.Functions",
            "DeviceManagement.Functions.md")))
            directory = Path.GetDirectoryName(directory);
        return directory ?? throw new InvalidOperationException("Repository root not found from test base directory.");
    }
}
