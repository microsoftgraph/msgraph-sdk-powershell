using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Reader;
using WrapperGenerator;
using Xunit;

namespace WrapperGenerator.Tests;

public sealed class DeviceManagementDirectiveMigrationTests
{
    private sealed record ReviewedOperation(string Method, string Path, string OperationId, OperationKind Kind);

    [Theory]
    [InlineData("POST", "/deviceManagement/deviceConfigurations/{deviceConfiguration-id}/assignedAccessMultiModeProfiles")]
    [InlineData("POST", "/deviceManagement/deviceConfigurations/{deviceConfiguration-id}/windowsPrivacyAccessControls")]
    [InlineData("GET", "/deviceManagement/deviceManagementScripts/{deviceManagementScript-id}/userRunStates/{deviceManagementScriptUserState-id}/deviceRunStates/{deviceManagementScriptDeviceState-id}/managedDevice")]
    [InlineData("GET", "/deviceManagement/deviceManagementScripts/{deviceManagementScript-id}/userRunStates/{deviceManagementScriptUserState-id}/deviceRunStates/$count")]
    [InlineData("GET", "/deviceManagement/deviceShellScripts/{deviceShellScript-id}/userRunStates/{deviceManagementScriptUserState-id}/deviceRunStates/{deviceManagementScriptDeviceState-id}/managedDevice")]
    [InlineData("GET", "/deviceManagement/deviceShellScripts/{deviceShellScript-id}/userRunStates/{deviceManagementScriptUserState-id}/deviceRunStates/$count")]
    [InlineData("GET", "/deviceManagement/groupPolicyConfigurations/{groupPolicyConfiguration-id}/definitionValues/{groupPolicyDefinitionValue-id}/presentationValues/{groupPolicyPresentationValue-id}/definitionValue")]
    [InlineData("GET", "/deviceManagement/groupPolicyConfigurations/{groupPolicyConfiguration-id}/definitionValues/{groupPolicyDefinitionValue-id}/presentationValues/{groupPolicyPresentationValue-id}/presentation")]
    [InlineData("GET", "/deviceManagement/groupPolicyConfigurations/{groupPolicyConfiguration-id}/definitionValues/{groupPolicyDefinitionValue-id}/presentationValues/$count")]
    [InlineData("POST", "/deviceManagement/groupPolicyConfigurations/{groupPolicyConfiguration-id}/updateDefinitionValues")]
    [InlineData("POST", "/deviceManagement/intents/{deviceManagementIntent-id}/updateSettings")]
    [InlineData("POST", "/deviceManagement/microsoftTunnelSites/{microsoftTunnelSite-id}/microsoftTunnelServers/{microsoftTunnelServer-id}/createServerLogCollectionRequest")]
    [InlineData("POST", "/deviceManagement/managedDevices/{managedDevice-id}/logCollectionRequests")]
    [InlineData("POST", "/deviceManagement/comanagedDevices/{managedDevice-id}/logCollectionRequests")]
    [InlineData("PATCH", "/deviceManagement/comanagedDevices/{managedDevice-id}")]
    public void ReviewedRoutesAreSuppressedWithOrWithoutDerivedData(string method, string path)
    {
        var httpMethod = new HttpMethod(method);
        Assert.True(CmdletConfigurator.IsSuppressed(httpMethod, path));
        foreach (var profile in new[] { "v1.0", "beta" })
        foreach (var useCollisionData in new[] { false, true })
        {
            var config = new GeneratorConfig("Test.Client", "unused", useCollisionData);
            Assert.True(CmdletConfigurator.IsSuppressed(httpMethod, path, config, apiVersion: profile));
            Assert.True(CmdletConfigurator.IsSuppressed(httpMethod, path.ToUpperInvariant() + "/", config, apiVersion: profile));
        }
    }

    [Theory]
    [InlineData("GET", "/deviceManagement/managedDevices/{managedDevice-id}/logCollectionRequests")]
    [InlineData("GET", "/deviceManagement/managedDevices/{managedDevice-id}/logCollectionRequests/{deviceLogCollectionResponse-id}")]
    [InlineData("PATCH", "/deviceManagement/managedDevices/{managedDevice-id}/logCollectionRequests/{deviceLogCollectionResponse-id}")]
    [InlineData("DELETE", "/deviceManagement/managedDevices/{managedDevice-id}/logCollectionRequests/{deviceLogCollectionResponse-id}")]
    [InlineData("POST", "/deviceManagement/managedDevices/{managedDevice-id}/logCollectionRequests/{deviceLogCollectionResponse-id}/createDownloadUrl")]
    [InlineData("GET", "/deviceManagement/comanagedDevices/{managedDevice-id}/logCollectionRequests")]
    [InlineData("GET", "/deviceManagement/comanagedDevices/{managedDevice-id}/logCollectionRequests/{deviceLogCollectionResponse-id}")]
    [InlineData("PATCH", "/deviceManagement/comanagedDevices/{managedDevice-id}/logCollectionRequests/{deviceLogCollectionResponse-id}")]
    [InlineData("DELETE", "/deviceManagement/comanagedDevices/{managedDevice-id}/logCollectionRequests/{deviceLogCollectionResponse-id}")]
    [InlineData("GET", "/deviceManagement/comanagedDevices/{managedDevice-id}")]
    [InlineData("GET", "/deviceManagement/comanagedDevices")]
    [InlineData("POST", "/deviceManagement/comanagedDevices")]
    [InlineData("PATCH", "/deviceManagement/comanagedDevices/{managedDevice-id}/deviceCategory")]
    [InlineData("PATCH", "/deviceManagement/managedDevices/{managedDevice-id}")]
    [InlineData("GET", "/deviceManagement/deviceManagementScripts/{deviceManagementScript-id}/userRunStates/{deviceManagementScriptUserState-id}/deviceRunStates")]
    [InlineData("GET", "/deviceManagement/deviceManagementScripts/{deviceManagementScript-id}/userRunStates/{deviceManagementScriptUserState-id}/deviceRunStates/{deviceManagementScriptDeviceState-id}")]
    [InlineData("GET", "/deviceManagement/deviceShellScripts/{deviceShellScript-id}/userRunStates/{deviceManagementScriptUserState-id}/deviceRunStates")]
    [InlineData("GET", "/deviceManagement/deviceShellScripts/{deviceShellScript-id}/userRunStates/{deviceManagementScriptUserState-id}/deviceRunStates/{deviceManagementScriptDeviceState-id}")]
    [InlineData("GET", "/deviceManagement/groupPolicyConfigurations/{groupPolicyConfiguration-id}/definitionValues/{groupPolicyDefinitionValue-id}/presentationValues")]
    [InlineData("GET", "/deviceManagement/groupPolicyConfigurations/{groupPolicyConfiguration-id}/definitionValues/{groupPolicyDefinitionValue-id}/presentationValues/{groupPolicyPresentationValue-id}")]
    [InlineData("PATCH", "/deviceManagement/groupPolicyConfigurations/{groupPolicyConfiguration-id}/definitionValues/{groupPolicyDefinitionValue-id}")]
    [InlineData("PATCH", "/deviceManagement/intents/{deviceManagementIntent-id}/settings/{deviceManagementSettingInstance-id}")]
    [InlineData("POST", "/deviceManagement/deviceConfigurations/{deviceConfiguration-id}/assign")]
    [InlineData("POST", "/deviceManagement/microsoftTunnelSites/{microsoftTunnelSite-id}/microsoftTunnelServers/{microsoftTunnelServer-id}/generateServerLogCollectionRequest")]
    public void NeighboringOperationsRemainAvailable(string method, string path)
    {
        var httpMethod = new HttpMethod(method);
        Assert.False(CmdletConfigurator.IsSuppressed(httpMethod, path));
        foreach (var profile in new[] { "v1.0", "beta" })
        foreach (var useCollisionData in new[] { false, true })
        {
            var config = new GeneratorConfig("Test.Client", "unused", useCollisionData);
            Assert.False(CmdletConfigurator.IsSuppressed(httpMethod, path, config, apiVersion: profile));
        }
    }

    [Theory]
    [InlineData("v1.0", false)]
    [InlineData("v1.0", true)]
    [InlineData("beta", false)]
    [InlineData("beta", true)]
    public void UnaffectedLogAndComanagedDeviceNamesArePreserved(string profile, bool useCollisionData)
    {
        var config = new GeneratorConfig("Test.Client", "unused", useCollisionData);
        var logRequest = Naming.Resolve(new OperationInfo(HttpMethod.Get,
            "/deviceManagement/managedDevices/{managedDevice-id}/logCollectionRequests"), config, apiVersion: profile);
        Assert.Equal("Get", logRequest.VerbName);
        Assert.Equal("MgDeviceManagementManagedDeviceLogCollectionRequest", logRequest.Noun);
        var comanagedDevice = Naming.Resolve(new OperationInfo(HttpMethod.Get,
            "/deviceManagement/comanagedDevices/{managedDevice-id}"), config, apiVersion: profile);
        Assert.Equal("Get", comanagedDevice.VerbName);
        Assert.Equal("MgDeviceManagementComanagedDevice", comanagedDevice.Noun);
    }

    [Theory]
    [InlineData("v1.0", 265, 265, 0, 0)]
    [InlineData("beta", 1090, 1071, 12, 11)]
    public async Task CompleteOriginalSelectionsAndAllCurrentSurvivorsRemainReviewed(
        string profile, int legacyCount, int currentCount, int selectedCount, int literalCount)
    {
        var legacy = await ReadOperationsAsync(profile, "openApiDocs");
        var current = await ReadOperationsAsync(profile, "openApiDocs_KiotaCompat");
        Assert.Equal(legacyCount, legacy.Length);
        Assert.Equal(currentCount, current.Length);
        using var ledger = JsonDocument.Parse(File.ReadAllText(Path.Combine(FindRepoRoot(),
            "src", "DeviceManagement", "wrapper", "DeviceManagement_directiveMigrationMap.json")));
        var mappings = ledger.RootElement.GetProperty("mappings").EnumerateArray().ToArray();
        Assert.Equal(4, mappings.Length);
        var source = File.ReadAllText(Path.Combine(FindRepoRoot(), "src", "DeviceManagement", "DeviceManagement.md"));
        foreach (var mapping in mappings)
        {
            Assert.Contains(mapping.GetProperty("sourceContains").GetString()!, source);
            foreach (var evidence in ReadEvidence(mapping, profile))
                Assert.Single(current, operation => EvidenceKey(operation) == evidence);
        }

        var selector = mappings[0].GetProperty("sourceContains").GetString()!
            .Replace("remove-path-by-operation: ", "", StringComparison.Ordinal);
        var regex = new Regex(selector);
        var original = legacy.Where(operation => regex.IsMatch(operation.OperationId)).ToArray();
        Assert.Equal(selectedCount, original.Length);
        var survivors = original.Select(operation => Assert.Single(current, candidate =>
            candidate.Method == operation.Method && candidate.Path == CompatiblePath(operation) &&
            candidate.Kind == operation.Kind)).ToArray();
        Assert.Equal(ReadEvidence(mappings[0], profile).Order(StringComparer.Ordinal),
            survivors.Select(EvidenceKey).Order(StringComparer.Ordinal));
        var profileEvidence = mappings[0].GetProperty("profiles").GetProperty(profile);
        if (profile == "beta")
        {
            Assert.Equal("Legacy", profileEvidence.GetProperty("operationIdSource").GetString());
            var bridges = profileEvidence.GetProperty("operations").EnumerateArray().ToArray();
            var reviewedLegacy = bridges.Select(bridge => Assert.Single(original, operation =>
                operation.Method == bridge.GetProperty("method").GetString() &&
                operation.Path == bridge.GetProperty("legacyPath").GetString() &&
                operation.OperationId == bridge.GetProperty("legacyOperationId").GetString())).ToArray();
            Assert.Equal(original.Select(EvidenceKey).Order(StringComparer.Ordinal),
                reviewedLegacy.Select(EvidenceKey).Order(StringComparer.Ordinal));
            Assert.Equal(12, reviewedLegacy.Select(EvidenceKey).Distinct(StringComparer.Ordinal).Count());
            Assert.Equal(5, bridges.Count(bridge => bridge.TryGetProperty("legacyPathTranslation", out _)));
            foreach (var bridge in bridges)
            {
                var previous = Assert.Single(reviewedLegacy, operation =>
                    operation.Method == bridge.GetProperty("method").GetString() &&
                    operation.Path == bridge.GetProperty("legacyPath").GetString());
                var successor = Assert.Single(current, operation =>
                    operation.Method == previous.Method &&
                    operation.Path == bridge.GetProperty("path").GetString() &&
                    operation.OperationId == bridge.GetProperty("operationId").GetString());
                Assert.Equal(previous.Kind, successor.Kind);
                if (bridge.TryGetProperty("legacyPathTranslation", out var translation))
                {
                    Assert.Equal("UnqualifyFinalOperation", translation.GetString());
                    Assert.Equal("POST", previous.Method);
                    Assert.Equal(OperationKind.Action, previous.Kind);
                    Assert.Equal(CompatiblePath(previous), successor.Path);
                    Assert.NotEqual(previous.Path, successor.Path);
                }
                else
                    Assert.Equal(previous.Path, successor.Path);
            }
        }
        else
            Assert.False(profileEvidence.TryGetProperty("operationIdSource", out _));
        Assert.Equal(literalCount, current.Count(operation => regex.IsMatch(operation.OperationId)));
        var unmatched = survivors.Where(operation => !regex.IsMatch(operation.OperationId)).ToArray();
        if (profile == "beta")
        {
            var intent = Assert.Single(unmatched);
            Assert.Equal(new ReviewedOperation("POST",
                "/deviceManagement/intents/{deviceManagementIntent-id}/updateSettings",
                "deviceManagement.intent.deviceManagementIntent_updateSetting", OperationKind.Action), intent);
            Assert.Contains(original, operation => operation.OperationId == "deviceManagement.intent_updateSetting");
            Assert.False(mappings[0].GetProperty("profiles").GetProperty(profile).GetProperty("absenceExpected").GetBoolean());
            Assert.Equal(5, original.Count(operation => operation.Kind == OperationKind.Action));
        }
        else
            Assert.Empty(unmatched);

        var logRequests = legacy.Where(operation => operation.OperationId is
            "deviceManagement.managedDevice_CreateLogCollectionRequest" or
            "deviceManagement.comanagedDevice_CreateLogCollectionRequest").ToArray();
        Assert.Equal(profile == "beta" ? 2 : 1, logRequests.Length);
        Assert.Equal(ReadEvidence(mappings[1], profile).Order(StringComparer.Ordinal),
            logRequests.Select(operation => Assert.Single(current, candidate => candidate.Method == operation.Method &&
                candidate.Path == operation.Path)).Select(EvidenceKey).Order(StringComparer.Ordinal));
        var comanagedUpdate = legacy.Where(operation => operation.OperationId == "deviceManagement_UpdateComanagedDevice").ToArray();
        Assert.Equal(profile == "beta" ? 1 : 0, comanagedUpdate.Length);
        Assert.Equal(ReadEvidence(mappings[2], profile).Order(StringComparer.Ordinal),
            comanagedUpdate.Select(operation => Assert.Single(current, candidate => candidate.Method == operation.Method &&
                candidate.Path == operation.Path)).Select(EvidenceKey).Order(StringComparer.Ordinal));
        Assert.Empty(ReadEvidence(mappings[3], profile));
        Assert.DoesNotContain(legacy.Concat(current), operation =>
            operation.Path.Contains("userExperienceAnalyticsDeviceScope", StringComparison.OrdinalIgnoreCase) ||
            operation.OperationId.Contains("userExperienceAnalyticDeviceScopeAction", StringComparison.OrdinalIgnoreCase));
    }

    [Theory]
    [InlineData("v1.0", false)]
    [InlineData("v1.0", true)]
    [InlineData("beta", false)]
    [InlineData("beta", true)]
    public async Task ServiceUsesSharedSuppressionsAndExplicitRunProfile(string profile, bool useCollisionData)
    {
        const string suppressedPath = "/deviceManagement/intents/{deviceManagementIntent-id}/updateSettings";
        const string neighborPath = "/deviceManagement/intents/{deviceManagementIntent-id}/settings/{deviceManagementSettingInstance-id}";
        const string controlPath = "/deviceManagement/intents/{deviceManagementIntent-id}/otherSettings";
        var output = Path.Combine(Path.GetTempPath(), "device-management-directives", Guid.NewGuid().ToString("N"));
        try
        {
            var document = new OpenApiDocument
            {
                Components = new OpenApiComponents
                {
                    Schemas = new Dictionary<string, IOpenApiSchema>
                    {
                        ["microsoft.graph.setting"] = new OpenApiSchema
                        {
                            Type = JsonSchemaType.Object,
                            Properties = new Dictionary<string, IOpenApiSchema>
                            {
                                ["displayName"] = new OpenApiSchema { Type = JsonSchemaType.String },
                            },
                        },
                    },
                },
                Paths = new OpenApiPaths
                {
                    [suppressedPath] = new OpenApiPathItem
                    {
                        Operations = new() { [HttpMethod.Post] = new OpenApiOperation
                        {
                            OperationId = "deviceManagement.intent.deviceManagementIntent_updateSetting",
                            Responses = new OpenApiResponses { ["204"] = new OpenApiResponse() },
                        } },
                    },
                    [neighborPath] = new OpenApiPathItem
                    {
                        Operations = new() { [HttpMethod.Delete] = new OpenApiOperation
                        {
                            OperationId = "deviceManagement.intent_DeleteSetting",
                            Responses = new OpenApiResponses { ["204"] = new OpenApiResponse() },
                        } },
                    },
                },
            };
            var body = new OpenApiRequestBody
            {
                Content = new Dictionary<string, IOpenApiMediaType>
                {
                    ["application/json"] = new OpenApiMediaType
                    {
                        Schema = new OpenApiSchemaReference("microsoft.graph.setting", document),
                    },
                },
            };
            document.Paths[suppressedPath].Operations![HttpMethod.Post].RequestBody = body;
            document.Paths[controlPath] = new OpenApiPathItem
            {
                Operations = new() { [HttpMethod.Post] = new OpenApiOperation
                {
                    OperationId = "deviceManagement.intent_CreateOtherSetting",
                    RequestBody = body,
                    Responses = new OpenApiResponses { ["204"] = new OpenApiResponse() },
                } },
            };
            var config = new GeneratorConfig("Regression.Client", output, useCollisionData);
            await new PowerShellWrapperGenerationService(document, config, NullLogger.Instance, apiVersion: profile)
                .GenerateAsync(CancellationToken.None);
            var generated = Directory.GetFiles(output, "*.g.cs").Select(File.ReadAllText).ToArray();
            Assert.Equal(2, generated.Length);
            var neighbor = Assert.Single(generated, source => source.Contains($"[GraphRoute(\"DELETE\", \"{neighborPath}\")]",
                StringComparison.Ordinal));
            Assert.Contains($"[GraphRoute(\"DELETE\", \"{neighborPath}\")]", neighbor);
            Assert.Contains(generated, source => source.Contains($"[GraphRoute(\"POST\", \"{controlPath}\")]",
                StringComparison.Ordinal));
            Assert.All(generated, source => Assert.DoesNotContain(suppressedPath, source));
        }
        finally
        {
            if (Directory.Exists(output))
                Directory.Delete(output, recursive: true);
        }
    }

    private static string CompatiblePath(ReviewedOperation operation) =>
        operation.Kind == OperationKind.Action
            ? Regex.Replace(operation.Path, @"/microsoft\.graph\.([^/]+)$", "/$1")
            : operation.Path;

    private static string EvidenceKey(ReviewedOperation operation) =>
        $"{operation.Method} {operation.Path} [{operation.OperationId}]";

    private static string[] ReadEvidence(JsonElement mapping, string profile) =>
        mapping.GetProperty("profiles").GetProperty(profile).GetProperty("operations").EnumerateArray()
            .Select(operation => $"{operation.GetProperty("method").GetString()} {operation.GetProperty("path").GetString()} [{operation.GetProperty("operationId").GetString()}]")
            .ToArray();

    private static async Task<ReviewedOperation[]> ReadOperationsAsync(string profile, string root)
    {
        var settings = new OpenApiReaderSettings();
        settings.AddYamlReader();
        using var stream = File.OpenRead(Path.Combine(FindRepoRoot(), root, profile, "DeviceManagement.yml"));
        var document = (await OpenApiDocument.LoadAsync(stream, settings: settings,
            cancellationToken: CancellationToken.None)).Document!;
        return document.Paths.SelectMany(path => path.Value.Operations!.Select(operation =>
        {
            var type = operation.Value.Extensions is not null &&
                operation.Value.Extensions.TryGetValue("x-ms-docs-operation-type", out var extension)
                ? ((JsonNodeExtension)extension).Node?.ToString() : null;
            var kind = type switch { "action" => OperationKind.Action, "function" => OperationKind.Function, _ => OperationKind.Resource };
            return new ReviewedOperation(operation.Key.Method.ToUpperInvariant(), path.Key, operation.Value.OperationId!, kind);
        })).ToArray();
    }

    private static string FindRepoRoot()
    {
        var directory = new DirectoryInfo(AppContext.BaseDirectory);
        while (directory is not null &&
            !Directory.Exists(Path.Combine(directory.FullName, ".git")) &&
            !File.Exists(Path.Combine(directory.FullName, ".git")))
            directory = directory.Parent;
        return directory?.FullName ?? throw new InvalidOperationException("Repository root not found.");
    }
}
