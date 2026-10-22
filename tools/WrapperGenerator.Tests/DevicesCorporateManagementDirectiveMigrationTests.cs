using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Reader;
using WrapperGenerator;
using Xunit;

namespace WrapperGenerator.Tests;

public sealed class DevicesCorporateManagementDirectiveMigrationTests
{
    private const string Module = "Devices.CorporateManagement";
    private const string LogCollection = "/users/{user-id}/managedDevices/{managedDevice-id}/logCollectionRequests";

    [Theory]
    [InlineData("v1.0", false)]
    [InlineData("v1.0", true)]
    [InlineData("beta", false)]
    [InlineData("beta", true)]
    public void SharedRenamesAndNeighborsKeepTheirExactNames(string profile, bool useCollisionData)
    {
        var config = new GeneratorConfig("Test.Client", "unused", profile, useCollisionData);
        (string Method, string Path, OperationKind Kind, string Verb, string Noun)[] cases =
        [
            ("GET", "/deviceAppManagement", OperationKind.Resource, "Get", "DeviceAppManagement"),
            ("PATCH", "/deviceAppManagement", OperationKind.Resource, "Update", "DeviceAppManagement"),
            ("GET", "/deviceAppManagement/mobileAppRelationships", OperationKind.Resource, "Get", "DeviceAppManagementMobileAppRelationship"),
            ("POST", "/deviceAppManagement/mobileAppRelationships", OperationKind.Resource, "New", "DeviceAppManagementMobileAppRelationship"),
            ("GET", "/deviceAppManagement/mobileAppRelationships/$count", OperationKind.Resource, "Get", "DeviceAppManagementMobileAppRelationshipCount"),
            ("PATCH", "/deviceAppManagement/mobileAppRelationships/{mobileAppRelationship-id}", OperationKind.Resource, "Update", "DeviceAppManagementMultipleMobileAppRelationship"),
            ("DELETE", "/deviceAppManagement/mobileAppRelationships/{mobileAppRelationship-id}", OperationKind.Resource, "Remove", "DeviceAppManagementMobileAppRelationship"),
            ("GET", LogCollection, OperationKind.Resource, "Get", "UserManagedDeviceLogCollectionResponse"),
            ("GET", LogCollection + "/{deviceLogCollectionResponse-id}", OperationKind.Resource, "Get", "UserManagedDeviceLogCollectionResponse"),
            ("POST", LogCollection, OperationKind.Resource, "New", "UserManagedDeviceLogCollectionResponse"),
            ("PATCH", LogCollection + "/{deviceLogCollectionResponse-id}", OperationKind.Resource, "Update", "UserManagedDeviceLogCollectionResponse"),
            ("DELETE", LogCollection + "/{deviceLogCollectionResponse-id}", OperationKind.Resource, "Remove", "UserManagedDeviceLogCollectionResponse"),
            ("GET", LogCollection + "/$count", OperationKind.Resource, "Get", "UserManagedDeviceLogCollectionRequestCount"),
            ("GET", "/deviceAppManagement/iosManagedAppProtections", OperationKind.Resource, "Get", "DeviceAppManagementiOSManagedAppProtection"),
            ("PATCH", "/deviceAppManagement/iosManagedAppProtections/{iosManagedAppProtection-id}", OperationKind.Resource, "Update", "DeviceAppManagementiOSManagedAppProtection"),
            ("GET", "/deviceAppManagement/mobileApps/graph.iosLobApp/$count", OperationKind.Resource, "Get", "DeviceAppManagementMobileAppCountAsiOSLobApp"),
            ("GET", "/deviceAppManagement/mobileApps/{mobileApp-id}/graph.iosLobApp/contentVersions", OperationKind.Resource, "Get", "DeviceAppManagementMobileAppAsiOSLobAppContentVersion"),
            ("POST", "/deviceAppManagement/mobileApps/{mobileApp-id}/graph.managedIOSLobApp/contentVersions/{mobileAppContent-id}/files/{mobileAppContentFile-id}/commit", OperationKind.Action, "Invoke", "DeviceAppManagementMobileAppAsManagediOSLobAppContentVersionFileCommit"),
            ("GET", "/deviceAppManagement/androidManagedAppProtections", OperationKind.Resource, "Get", "DeviceAppManagementAndroidManagedAppProtection"),
            ("GET", "/deviceAppManagement/mobileApps/graph.androidLobApp", OperationKind.Resource, "Get", "DeviceAppManagementMobileAppAsAndroidLobApp"),
        ];
        foreach (var (method, path, kind, verb, noun) in cases)
        {
            var naming = Naming.Resolve(new(new HttpMethod(method), path, Kind: kind), config);
            Assert.Equal(verb, naming.VerbName);
            Assert.Equal("Mg" + noun, naming.Noun);
            Assert.Equal(verb + "Mg" + noun + "Command", naming.ClassName);
        }

        if (profile == "beta")
        {
            AssertName(HttpMethod.Post, "/deviceAppManagement/policySets/{policySet-id}/update",
                OperationKind.Action, "Update", "DeviceAppManagementMultiplePolicySet");
            AssertName(HttpMethod.Patch, "/deviceAppManagement/policySets/{policySet-id}",
                OperationKind.Resource, "Update", "DeviceAppManagementPolicySet");
            AssertName(HttpMethod.Get, "/deviceAppManagement/deviceAppManagementTasks",
                OperationKind.Resource, "Get", "DeviceAppManagementTask");
            AssertName(HttpMethod.Get, "/deviceAppManagement/deviceAppManagementTasks/{deviceAppManagementTask-id}",
                OperationKind.Resource, "Get", "DeviceAppManagementTask");
            AssertName(HttpMethod.Get, "/deviceAppManagement/deviceAppManagementTasks/$count",
                OperationKind.Resource, "Get", "DeviceAppManagementTaskCount");
            AssertName(HttpMethod.Post, "/deviceAppManagement/deviceAppManagementTasks/{deviceAppManagementTask-id}/updateStatus",
                OperationKind.Action, "Invoke", "DeviceAppManagementTaskUpdateStatus");
            AssertName(HttpMethod.Get, "/deviceAppManagement/iosLobAppProvisioningConfigurations/{iosLobAppProvisioningConfiguration-id}/deviceStatuses",
                OperationKind.Resource, "Get", "DeviceAppManagementiOSLobAppProvisioningConfigurationDeviceStatus");
        }

        void AssertName(HttpMethod method, string path, OperationKind kind, string verb, string noun)
        {
            var naming = Naming.Resolve(new(method, path, Kind: kind), config);
            Assert.Equal(verb, naming.VerbName);
            Assert.Equal("Mg" + noun, naming.Noun);
        }
    }

    [Theory]
    [InlineData("v1.0", false)]
    [InlineData("v1.0", true)]
    [InlineData("beta", false)]
    [InlineData("beta", true)]
    public async Task ReviewedEvidenceMatchesTheCompatibleSpecAndIosScope(string profile, bool useCollisionData)
    {
        var root = FindRepoRoot();
        var settings = new OpenApiReaderSettings();
        settings.AddYamlReader();
        using var stream = File.OpenRead(Path.Combine(root, "openApiDocs_KiotaCompat", profile, Module + ".yml"));
        var result = await OpenApiDocument.LoadAsync(stream, settings: settings, cancellationToken: CancellationToken.None);
        var document = Assert.IsType<OpenApiDocument>(result.Document);
        using var ledger = JsonDocument.Parse(File.ReadAllText(Path.Combine(root, "src", Module, "wrapper", Module + "_directiveMigrationMap.json")));
        var mappings = ledger.RootElement.GetProperty("mappings").EnumerateArray().ToArray();
        Assert.Equal(new[] { 1, 2, 3, 4, 5, 8, 9, 11, 12 }, mappings.Select(m => m.GetProperty("directiveIndex").GetInt32()));
        Assert.Equal(new[] { 6, 7, 10 }, ledger.RootElement.GetProperty("deferredDirectives").EnumerateArray()
            .Select(m => m.GetProperty("directiveIndex").GetInt32()));
        var config = new GeneratorConfig("Test.Client", "unused", profile, useCollisionData);
        var iosKeys = new HashSet<string>(StringComparer.Ordinal);
        foreach (var mapping in mappings)
        {
            var index = mapping.GetProperty("directiveIndex").GetInt32();
            var evidence = mapping.GetProperty("profiles").GetProperty(profile);
            var operations = evidence.GetProperty("operations").EnumerateArray().ToArray();
            Assert.Equal(operations.Length == 0, evidence.GetProperty("absenceExpected").GetBoolean());
            foreach (var operation in operations)
            {
                var method = new HttpMethod(operation.GetProperty("method").GetString()!);
                var path = operation.GetProperty("path").GetString()!;
                var actual = document.Paths[path].Operations![method];
                Assert.Equal(operation.GetProperty("operationId").GetString(), actual.OperationId);
                if (index != 8)
                    continue;
                iosKeys.Add(method + " " + path);
                Assert.False(CmdletConfigurator.IsSuppressed(method, path, config));
                var noun = Naming.Resolve(new(method, path), config).Noun;
                Assert.Contains("iOS", noun);
                Assert.DoesNotContain("Ios", noun);
            }
            if (index is 9 or 11)
            {
                var actualKeys = operations.Select(op => op.GetProperty("method").GetString() + " " + op.GetProperty("path").GetString())
                    .ToHashSet(StringComparer.Ordinal);
                var expectedKeys = document.Paths.Where(p => p.Key == "/deviceAppManagement" ||
                        p.Key.StartsWith("/deviceAppManagement/", StringComparison.Ordinal))
                    .SelectMany(p => p.Value.Operations!.Keys.Select(method => method + " " + p.Key));
                Assert.True(actualKeys.SetEquals(expectedKeys), "Both alias-scaffolding groups must record their complete shared operation scope.");
            }
            if (index == 12)
            {
                var create = Assert.Single(operations);
                Assert.Equal("POST", create.GetProperty("method").GetString());
                Assert.Equal(LogCollection, create.GetProperty("path").GetString());
            }
        }

        var iosPath = new Regex(@"^/deviceAppManagement/(iosManagedAppProtections|iosLobAppProvisioningConfigurations)(/|$)|^/deviceAppManagement/mobileApps/(\{mobileApp-id\}/)?graph\.(iosLobApp|managedIOSLobApp)(/|$)");
        var expectedIosKeys = document.Paths.Where(p => iosPath.IsMatch(p.Key))
            .SelectMany(p => p.Value.Operations!.Keys.Select(method => method + " " + p.Key));
        Assert.True(iosKeys.SetEquals(expectedIosKeys), "The iOS mapping must cover every affected operation, not just a naming sample.");

        var source = File.ReadAllText(Path.Combine(root, "src", Module, Module + ".md"));
        var oldIds = Regex.Match(source, @"remove-path-by-operation: ([^\r\n]+)").Groups[1].Value;
        Assert.DoesNotContain(document.Paths.Values.SelectMany(p => p.Operations!.Values),
            operation => Regex.IsMatch(operation.OperationId!, oldIds));
        Assert.Equal("users.managedDevices.CreateLogCollectionRequests",
            document.Paths[LogCollection].Operations![HttpMethod.Post].OperationId);
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Post, LogCollection, config));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Patch, "/deviceAppManagement/mobileAppRelationships/{mobileAppRelationship-id}", config));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get, "/deviceAppManagement/mobileAppRelationships/$count", config));
        Assert.True(CmdletConfigurator.IsSuppressed(HttpMethod.Get, "/deviceAppManagement/mobileApps/{mobileApp-id}/categories", config));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get, "/deviceAppManagement/mobileAppCategories", config));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get, "/deviceAppManagement/mobileApps/{mobileApp-id}/category", config));
    }

    private static string FindRepoRoot()
    {
        var directory = AppContext.BaseDirectory;
        while (directory is not null && !Directory.Exists(Path.Combine(directory, "openApiDocs_KiotaCompat")))
            directory = Path.GetDirectoryName(directory);
        return directory ?? throw new InvalidOperationException("Repository root not found.");
    }

    [Theory]
    [InlineData("v1.0", 0)]
    [InlineData("beta", 2)]
    public async Task LegacyLongPathSelectorSuppressesOnlySurvivingExactRoutes(string profile, int expectedCount)
    {
        var root = FindRepoRoot();
        var source = File.ReadAllText(Path.Combine(root, "src", Module, Module + ".md"));
        var selector = new Regex(Regex.Match(source, @"remove-path-by-operation: ([^\r\n]+)").Groups[1].Value);
        var settings = new OpenApiReaderSettings();
        settings.AddYamlReader();
        using var legacyStream = File.OpenRead(Path.Combine(root, "openApiDocs", profile, Module + ".yml"));
        var legacy = (await OpenApiDocument.LoadAsync(legacyStream, settings: settings,
            cancellationToken: TestContext.Current.CancellationToken)).Document!;
        using var compatibleStream = File.OpenRead(Path.Combine(root, "openApiDocs_KiotaCompat", profile, Module + ".yml"));
        var compatible = (await OpenApiDocument.LoadAsync(compatibleStream, settings: settings,
            cancellationToken: TestContext.Current.CancellationToken)).Document!;
        var selected = legacy.Paths.SelectMany(path => path.Value.Operations!
                .Where(operation => selector.IsMatch(operation.Value.OperationId!))
                .Select(operation => (Path: path.Key, Method: operation.Key, Operation: operation.Value)))
            .ToArray();
        Assert.Equal(expectedCount, selected.Length);
        foreach (var operation in selected)
        {
            var path = Assert.Single(compatible.Paths, path =>
                CmdletConfigurator.NormalizePathTemplate(path.Key) == CmdletConfigurator.NormalizePathTemplate(operation.Path));
            var translated = path.Value.Operations![operation.Method];
            Assert.NotEqual(operation.Operation.OperationId, translated.OperationId);
            foreach (var data in new[] { false, true })
                Assert.True(CmdletConfigurator.IsSuppressed(operation.Method, path.Key,
                    new GeneratorConfig("Test.Client", "unused", profile, data)));
        }
        if (profile != "beta")
            return;

        const string statuses = "/deviceAppManagement/wdacSupplementalPolicies/{windowsDefenderApplicationControlSupplementalPolicy-id}/deviceStatuses";
        var config = new GeneratorConfig("Test.Client", "unused", profile);
        Assert.Equal("deviceAppManagement.wdacSupplementalPolicies.deviceStatuses.GetPolicy",
            compatible.Paths[statuses + "/{windowsDefenderApplicationControlSupplementalPolicyDeploymentStatus-id}/policy"].Operations![HttpMethod.Get].OperationId);
        Assert.Equal("deviceAppManagement.wdacSupplementalPolicies.deviceStatuses.GetCount-c722",
            compatible.Paths[statuses + "/$count"].Operations![HttpMethod.Get].OperationId);
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get, statuses, config));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Post, statuses, config));
        foreach (var method in new[] { HttpMethod.Get, HttpMethod.Patch, HttpMethod.Delete })
            Assert.False(CmdletConfigurator.IsSuppressed(method, statuses + "/{windowsDefenderApplicationControlSupplementalPolicyDeploymentStatus-id}", config));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Patch, statuses + "/{windowsDefenderApplicationControlSupplementalPolicyDeploymentStatus-id}/policy", config));
    }
}
