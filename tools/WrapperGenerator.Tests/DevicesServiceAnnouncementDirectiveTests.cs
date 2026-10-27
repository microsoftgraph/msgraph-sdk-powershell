using System;
using System.Collections.Generic;
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

public sealed class DevicesServiceAnnouncementDirectiveTests
{
    private static string FindRepoRoot()
    {
        var directory = new DirectoryInfo(AppContext.BaseDirectory);
        while (directory is not null && !Directory.Exists(Path.Combine(directory.FullName, "openApiDocs_KiotaCompat")))
            directory = directory.Parent;
        return directory?.FullName ?? throw new InvalidOperationException("Could not locate the compatible specifications.");
    }

    private static async Task<OpenApiDocument> LoadSpec(string root, string profile)
    {
        var settings = new OpenApiReaderSettings();
        settings.AddYamlReader();
        using var stream = File.OpenRead(Path.Combine(FindRepoRoot(), root, profile, "Devices.ServiceAnnouncement.yml"));
        var result = await OpenApiDocument.LoadAsync(stream, settings: settings);
        return result.Document ?? throw new InvalidOperationException("Could not read the service announcement specification.");
    }

    private static OperationKind Kind(OpenApiOperation operation, HttpMethod method)
    {
        if (operation.Extensions?.TryGetValue("x-ms-docs-operation-type", out var extension) == true &&
            extension is JsonNodeExtension node)
        {
            return node.Node?.ToString().Trim('"') switch
            {
                "action" when method == HttpMethod.Post => OperationKind.Action,
                "function" when method == HttpMethod.Get => OperationKind.Function,
                _ => OperationKind.Resource,
            };
        }
        return OperationKind.Resource;
    }

    private static IEnumerable<(HttpMethod Method, string Path, string Id, OperationKind Kind)> Operations(OpenApiDocument document) =>
        document.Paths.SelectMany(path => path.Value.Operations!.Select(operation =>
            (operation.Key, path.Key, operation.Value.OperationId!, Kind(operation.Value, operation.Key))));

    // Only the final action/function qualifier is translated, never an earlier cast.
    private static string BridgePath(string path) =>
        CmdletConfigurator.NormalizePathTemplate(Regex.Replace(path, @"/microsoft\.graph\.([^/]+)$", "/$1"));

    [Theory]
    [InlineData("v1.0", 22)]
    [InlineData("beta", 31)]
    public async Task ReviewedSuppressionsCoverTheLegacySelectorExactly(string profile, int expectedCount)
    {
        var source = File.ReadAllText(Path.Combine(FindRepoRoot(), "src", "Devices.ServiceAnnouncement", "Devices.ServiceAnnouncement.md"));
        var selector = Regex.Match(source, @"(?m)^\s+- remove-path-by-operation: (.+)\r?$").Groups[1].Value.Trim();
        Assert.NotEmpty(selector);
        var selected = Operations(await LoadSpec("openApiDocs", profile))
            .Where(operation => Regex.IsMatch(operation.Id, selector)).ToList();
        Assert.Equal(expectedCount, selected.Count);
        var compatible = Operations(await LoadSpec("openApiDocs_KiotaCompat", profile)).ToList();
        var currentSelected = compatible.Where(operation => Regex.IsMatch(operation.Id, selector)).ToList();
        Assert.Equal(expectedCount, currentSelected.Count);
        using var ledger = JsonDocument.Parse(File.ReadAllText(Path.Combine(FindRepoRoot(), "src",
            "Devices.ServiceAnnouncement", "wrapper", "Devices.ServiceAnnouncement_directiveMigrationMap.json")));
        var profileMap = ledger.RootElement.GetProperty("mappings")[0].GetProperty("profiles").GetProperty(profile);
        Assert.False(profileMap.TryGetProperty("operationIdSource", out _));
        var reviewed = profileMap.GetProperty("operations").EnumerateArray().ToList();
        Assert.Equal(expectedCount, reviewed.Count);
        var translatedCount = 0;
        foreach (var operation in selected)
        {
            var bridged = Assert.Single(compatible, candidate =>
                candidate.Method == operation.Method && BridgePath(candidate.Path) == BridgePath(operation.Path));
            Assert.Equal(operation.Id, bridged.Id);
            Assert.Contains(bridged, currentSelected);
            Assert.Single(reviewed, evidence =>
                evidence.GetProperty("method").GetString() == bridged.Method.Method &&
                evidence.GetProperty("path").GetString() == bridged.Path &&
                evidence.GetProperty("operationId").GetString() == bridged.Id);
            if (operation.Path != bridged.Path)
            {
                translatedCount++;
                Assert.NotEqual(OperationKind.Resource, operation.Kind);
                Assert.Equal(operation.Kind, bridged.Kind);
                var separator = bridged.Path.LastIndexOf('/');
                Assert.Equal(
                    bridged.Path[..(separator + 1)] + "microsoft.graph." + bridged.Path[(separator + 1)..],
                    operation.Path);
            }
        }
        Assert.Equal(profile == "beta" ? 9 : 0, translatedCount);
        foreach (var operation in compatible)
        {
            var expected = selected.Any(candidate =>
                candidate.Method == operation.Method && BridgePath(candidate.Path) == BridgePath(operation.Path));
            foreach (var useDerived in new[] { false, true })
            {
                var config = new GeneratorConfig("Test.Client", "unused", profile, useDerived);
                Assert.Equal(expected, CmdletConfigurator.IsSuppressed(operation.Method, operation.Path, config));
            }
        }
    }

    [Theory]
    [InlineData("v1.0")]
    [InlineData("beta")]
    public async Task SurvivingRoutesDropOnlyAdminAndKeepDerivedNames(string profile)
    {
        var operations = Operations(await LoadSpec("openApiDocs_KiotaCompat", profile)).ToList();
        var config = new GeneratorConfig("Test.Client", "unused", profile);
        var surviving = operations.Where(operation => !CmdletConfigurator.IsSuppressed(operation.Method, operation.Path, config)).ToList();
        Assert.Equal(25, surviving.Count);
        using var ledger = JsonDocument.Parse(File.ReadAllText(Path.Combine(FindRepoRoot(), "src",
            "Devices.ServiceAnnouncement", "wrapper", "Devices.ServiceAnnouncement_directiveMigrationMap.json")));
        var reviewed = ledger.RootElement.GetProperty("mappings")[1].GetProperty("profiles")
            .GetProperty(profile).GetProperty("operations").EnumerateArray().ToList();
        Assert.Equal(surviving.Count, reviewed.Count);
        foreach (var operation in surviving)
        {
            Assert.Single(reviewed, evidence =>
                evidence.GetProperty("method").GetString() == operation.Method.Method &&
                evidence.GetProperty("path").GetString() == operation.Path &&
                evidence.GetProperty("operationId").GetString() == operation.Id);
            var naming = Naming.Resolve(new OperationInfo(operation.Method, operation.Path, Kind: operation.Kind), config);
            Assert.Contains("ServiceAnnouncement", naming.Noun);
            Assert.DoesNotContain("Admin", naming.Noun);
        }
        var message = Naming.Resolve(new OperationInfo(HttpMethod.Get, "/admin/serviceAnnouncement/messages/{message-id}"), config);
        Assert.Equal("MgServiceAnnouncementMessage", message.Noun);
        var archive = Naming.Resolve(new OperationInfo(HttpMethod.Post, "/admin/serviceAnnouncement/messages/archive",
            Kind: OperationKind.Action), config);
        Assert.Equal(profile == "v1.0" ? "MgArchiveServiceAnnouncementMessage" : "MgServiceAnnouncementMessageArchive", archive.Noun);
        Assert.Equal("Invoke", archive.VerbName);
    }

    [Theory]
    [InlineData("GET", "/admin/reportSettings", "MgAdminReportSetting")]
    [InlineData("PATCH", "/admin/reportSettings", "MgAdminReportSetting")]
    [InlineData("GET", "/admin/serviceAnnouncementExtra/messages", "MgAdminServiceAnnouncementExtraMessage")]
    [InlineData("GET", "/administrativeUnits/{unit-id}", "MgAdministrativeUnit")]
    [InlineData("GET", "/administrativeUnits/{unit-id}/checkMemberGroups", "MgAdministrativeUnitCheckMemberGroup")]
    [InlineData("POST", "/administrativeUnits/{unit-id}/checkMemberGroups/child", "MgAdministrativeUnitCheckMemberGroupChild")]
    public void NeighboringRoutesAndMethodsAreUnchanged(string method, string path, string noun)
    {
        foreach (var profile in new[] { "v1.0", "beta" })
        {
            var config = new GeneratorConfig("Test.Client", "unused", profile);
            var httpMethod = new HttpMethod(method);
            Assert.False(CmdletConfigurator.IsSuppressed(httpMethod, path, config));
            Assert.Equal(noun, Naming.Resolve(new OperationInfo(httpMethod, path), config).Noun);
        }
    }
}
