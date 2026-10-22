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

public sealed class DeviceManagementEnrollmentDirectiveMigrationTests
{
    private const string Module = "DeviceManagement.Enrollment";
    private const string AutopilotItem =
        "/deviceManagement/windowsAutopilotDeviceIdentities/{windowsAutopilotDeviceIdentity-id}";
    private const string Function =
        "assignedPrincipals(transitive=@transitive,directoryScopeType='@directoryScopeType',directoryScopeId='@directoryScopeId')";

    [Theory]
    [InlineData("v1.0", false, 1)]
    [InlineData("v1.0", true, 1)]
    [InlineData("beta", false, 13)]
    [InlineData("beta", true, 13)]
    public async Task ReviewedOperationsExistAndAreSuppressed(string profile, bool useCollisionData, int expectedCount)
    {
        var spec = await ReadSpecAsync("openApiDocs_KiotaCompat", profile);
        using var ledger = ReadLedger();
        var config = new GeneratorConfig("Test.Client", "unused", profile, useCollisionData);
        var count = 0;
        foreach (var mapping in ledger.RootElement.GetProperty("mappings").EnumerateArray())
        {
            foreach (var operation in mapping.GetProperty("profiles").GetProperty(profile)
                .GetProperty("operations").EnumerateArray())
            {
                var method = new HttpMethod(operation.GetProperty("method").GetString()!);
                var path = operation.GetProperty("path").GetString()!;
                var actual = spec.Paths![path].Operations![method];
                Assert.Equal(operation.GetProperty("operationId").GetString(), actual.OperationId);
                Assert.True(CmdletConfigurator.IsSuppressed(method, path, config), $"{method} {path}");
                Assert.True(CmdletConfigurator.IsSuppressed(method,
                    CmdletConfigurator.NormalizePathTemplate(path) + "/", config), $"Normalized {method} {path}");
                count++;
            }
        }
        Assert.Equal(expectedCount, count);
    }

    [Theory]
    [InlineData("v1.0", 0)]
    [InlineData("beta", 11)]
    public async Task LegacySelectorEvidenceCoversTheCompleteActualSourceSet(string profile, int expectedCount)
    {
        var legacy = await ReadSpecAsync("openApiDocs", profile);
        using var ledger = ReadLedger();
        var mapping = ledger.RootElement.GetProperty("mappings")[0].GetProperty("profiles").GetProperty(profile);
        var selector = new Regex(
            @"^(deviceManagement_.*UserExperienceAnalytic.*|roleManagement\..*\.roleDefinition\.inheritsPermissionsFrom.*)$");
        var selected = legacy.Paths!
            .SelectMany(path => path.Value.Operations!.Select(operation =>
                (Method: operation.Key.Method, Path: path.Key, Id: operation.Value.OperationId!)))
            .Where(operation => selector.IsMatch(operation.Id!))
            .OrderBy(operation => operation.Path, StringComparer.Ordinal).ThenBy(operation => operation.Method)
            .ToArray();
        var reviewed = mapping.GetProperty("operations").EnumerateArray()
            .Select(operation => (
                Method: operation.GetProperty("method").GetString()!,
                Path: operation.GetProperty("legacyPath").GetString()!,
                Id: operation.GetProperty("legacyOperationId").GetString()!))
            .OrderBy(operation => operation.Path, StringComparer.Ordinal).ThenBy(operation => operation.Method)
            .ToArray();

        Assert.Equal(expectedCount, selected.Length);
        Assert.Equal(selected, reviewed);
        Assert.Empty(mapping.GetProperty("removedLegacyOperations").EnumerateArray());
    }

    [Theory]
    [InlineData("v1.0", false)]
    [InlineData("v1.0", true)]
    [InlineData("beta", false)]
    [InlineData("beta", true)]
    public async Task NeighboringCrudAndActionsRemainAvailable(string profile, bool useCollisionData)
    {
        var spec = await ReadSpecAsync("openApiDocs_KiotaCompat", profile);
        var config = new GeneratorConfig("Test.Client", "unused", profile, useCollisionData);
        foreach (var method in new[] { HttpMethod.Get, HttpMethod.Delete })
            AssertAvailable(method, AutopilotItem);
        foreach (var action in new[] { "assignUserToDevice", "unassignUserFromDevice", "updateDeviceProperties" })
            AssertAvailable(HttpMethod.Post, AutopilotItem + "/" + action);
        AssertAvailable(HttpMethod.Get, "/deviceManagement/windowsAutopilotDeviceIdentities");
        AssertAvailable(HttpMethod.Post, "/deviceManagement/windowsAutopilotDeviceIdentities");
        AssertAvailable(HttpMethod.Get, "/deviceManagement/windowsAutopilotDeviceIdentities/$count");
        AssertAvailable(HttpMethod.Get, "/deviceManagement/conditionalAccessSettings");
        AssertAvailable(HttpMethod.Patch, "/deviceManagement/conditionalAccessSettings");

        if (profile == "beta")
        {
            foreach (var root in new[] { "cloudPC", "deviceManagement", "exchange" })
            {
                var role = $"/roleManagement/{root}/roleDefinitions/{{unifiedRoleDefinition-id}}";
                AssertAvailable(HttpMethod.Get, role + "/" + Function);
                AssertAvailable(HttpMethod.Get, role + "/inheritsPermissionsFrom");
                AssertAvailable(HttpMethod.Post, role + "/inheritsPermissionsFrom");
                foreach (var method in new[] { HttpMethod.Get, HttpMethod.Patch, HttpMethod.Delete })
                    AssertAvailable(method, role + "/inheritsPermissionsFrom/{unifiedRoleDefinition-id1}");
            }
        }

        void AssertAvailable(HttpMethod method, string path)
        {
            Assert.True(spec.Paths!.ContainsKey(path), $"Missing neighbor {path}");
            Assert.True(spec.Paths[path].Operations!.ContainsKey(method), $"Missing neighbor {method} {path}");
            Assert.False(CmdletConfigurator.IsSuppressed(method, path, config), $"{method} {path}");
        }
    }

    [Fact]
    public void PublishedV1AutopilotActionNamesRemainDerived()
    {
        var config = new GeneratorConfig("Test.Client", "unused", "v1.0");
        Assert.True(DerivedCollisionResolutions.IsSuppressed("v1.0", HttpMethod.Patch,
            CmdletConfigurator.NormalizePathTemplate(AutopilotItem)));
        Assert.Equal("DeviceManagementWindowsAutopilotDeviceIdentityDeviceProperty",
            CmdletConfigurator.ApplyNounOverrides(HttpMethod.Post, AutopilotItem + "/updateDeviceProperties", "unused", config));
        Assert.Equal("Update",
            CmdletConfigurator.TryGetOverriddenVerb(HttpMethod.Post, AutopilotItem + "/updateDeviceProperties", config));
        Assert.Equal("DeviceManagementWindowsAutopilotDeviceIdentityUserToDevice",
            CmdletConfigurator.ApplyNounOverrides(HttpMethod.Post, AutopilotItem + "/assignUserToDevice", "unused", config));
    }

    private static JsonDocument ReadLedger() => JsonDocument.Parse(File.ReadAllText(
        Path.Combine(FindRepoRoot(), "src", Module, "wrapper", Module + "_directiveMigrationMap.json")));

    private static async Task<OpenApiDocument> ReadSpecAsync(string root, string profile)
    {
        var settings = new OpenApiReaderSettings();
        settings.AddYamlReader();
        await using var stream = File.OpenRead(Path.Combine(FindRepoRoot(), root, profile, Module + ".yml"));
        var result = await OpenApiDocument.LoadAsync(stream, settings: settings);
        return Assert.IsType<OpenApiDocument>(result.Document);
    }

    private static string FindRepoRoot()
    {
        var directory = AppContext.BaseDirectory;
        while (directory is not null && !File.Exists(Path.Combine(directory, "src", Module, Module + ".md")))
            directory = Path.GetDirectoryName(directory);
        return directory ?? throw new InvalidOperationException("Repository root not found from the test directory.");
    }
}
