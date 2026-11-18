using System;
using System.Collections.Generic;
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

public sealed class DirectoryManagementDirectiveMigrationTests
{
    [Theory]
    [InlineData("v1.0", true)]
    [InlineData("v1.0", false)]
    [InlineData("beta", true)]
    [InlineData("beta", false)]
    public void SharedDirectivesPreserveItemCastsTemplatesContactsAndReferenceNeighbors(string profile, bool derived)
    {
        var config = new GeneratorConfig("Test.Client", "unused", derived);
        Assert.True(Suppressed(HttpMethod.Get, "/directory/deletedItems"));
        Assert.True(Suppressed(HttpMethod.Get, "/directory/deletedItems/$count"));
        Assert.False(Suppressed(HttpMethod.Get, "/directory/deletedItems/{directoryObject-id}"));
        Assert.False(Suppressed(HttpMethod.Delete, "/directory/deletedItems/{directoryObject-id}"));
        Assert.False(Suppressed(HttpMethod.Post, "/directory/deletedItems/{directoryObject-id}/restore"));
        foreach (var type in new[] { "administrativeUnit", "application", "device", "group", "servicePrincipal", "user" })
        {
            var suffix = char.ToUpperInvariant(type[0]) + type[1..];
            var list = $"/directory/deletedItems/graph.{type}";
            var item = $"/directory/deletedItems/{{directoryObject-id}}/graph.{type}";
            Assert.False(Suppressed(HttpMethod.Get, list));
            Assert.False(Suppressed(HttpMethod.Get, item));
            Assert.False(Suppressed(HttpMethod.Get, list + "/$count"));
            Assert.Equal("MgDirectoryDeletedItemAs" + suffix, Resolve(HttpMethod.Get, list).Noun);
            Assert.Equal("MgDirectoryDeletedItemAs" + suffix, Resolve(HttpMethod.Get, item).Noun);
            Assert.Equal("MgDirectoryDeletedItemCountAs" + suffix, Resolve(HttpMethod.Get, list + "/$count").Noun);
        }
        foreach (var navigation in new[]
        {
            "/devices/{device-id}/registeredOwners",
            "/devices/{device-id}/registeredUsers",
            "/directory/administrativeUnits/{administrativeUnit-id}/members",
            "/directoryRoles/{directoryRole-id}/members",
        })
        {
            Assert.True(Suppressed(HttpMethod.Delete, navigation + "/$ref"));
            Assert.False(Suppressed(HttpMethod.Get, navigation + "/$ref"));
            Assert.False(Suppressed(HttpMethod.Post, navigation + "/$ref"));
            Assert.False(Suppressed(HttpMethod.Get, navigation));
            Assert.False(Suppressed(HttpMethod.Delete, navigation + "/{directoryObject-id}/$ref"));
        }
        Assert.False(Suppressed(HttpMethod.Get, "/policies/featureRolloutPolicies/{featureRolloutPolicy-id}/appliesTo/$ref"));
        Assert.False(Suppressed(HttpMethod.Delete, "/administrativeUnits/{administrativeUnit-id}/members/$ref"));
        AssertCrudNames("/directoryRoleTemplates", "{directoryRoleTemplate-id}", "MgDirectoryRoleTemplate");
        AssertCrudNames("/contacts", "{orgContact-id}", "MgContact", create: false);
        Assert.Equal("MgContactDirectReport", Resolve(HttpMethod.Get, "/contacts/{orgContact-id}/directReports").Noun);
        Assert.Equal("MgDirectoryRoleTemplateCount", Resolve(HttpMethod.Get, "/directoryRoleTemplates/$count").Noun);
        Assert.False(Suppressed(HttpMethod.Get, "/contacts/delta()"));
        Assert.False(Suppressed(HttpMethod.Get, "/directoryRoleTemplates/delta()"));
        if (profile == "beta")
        {
            AssertCrudNames("/directorySettingTemplates", "{directorySettingTemplate-id}", "MgDirectorySettingTemplate");
            AssertCrudNames("/settings", "{directorySetting-id}", "MgDirectorySetting");
            Assert.Equal("MgSettingCount", Resolve(HttpMethod.Get, "/settings/$count").Noun);
            Assert.Equal("MgSettingTemplate", Resolve(HttpMethod.Get, "/settings/{directorySetting-id}/template").Noun);
            Assert.Equal("MgGroupSetting", Resolve(HttpMethod.Get, "/groups/{group-id}/settings").Noun);
        }

        bool Suppressed(HttpMethod method, string path) => CmdletConfigurator.IsSuppressed(method, path, config, apiVersion: profile);
        CmdletNaming Resolve(HttpMethod method, string path) => Naming.Resolve(new OperationInfo(method, path), config, apiVersion: profile);
        void AssertCrudNames(string collection, string id, string noun, bool create = true)
        {
            Assert.Equal(noun, Resolve(HttpMethod.Get, collection).Noun);
            if (create)
                Assert.Equal(noun, Resolve(HttpMethod.Post, collection).Noun);
            foreach (var method in new[] { HttpMethod.Get, HttpMethod.Patch, HttpMethod.Delete })
            {
                Assert.False(Suppressed(method, collection + "/" + id));
                Assert.Equal(noun, Resolve(method, collection + "/" + id).Noun);
            }
        }
    }

    [Theory]
    [InlineData("v1.0", true, "MgDeviceRegisteredOwnerDirectoryObjectByRef")]
    [InlineData("v1.0", false, "MgDeviceRegisteredOwnerByRef")]
    [InlineData("beta", true, "MgDeviceRegisteredOwnerByRef")]
    [InlineData("beta", false, "MgDeviceRegisteredOwnerByRef")]
    public void DerivedReferenceNamesUseTheSeparateRuntimeProfile(string profile, bool derived, string expected)
    {
        var naming = Naming.Resolve(new OperationInfo(HttpMethod.Delete,
            "/devices/{device-id}/registeredOwners/{directoryObject-id}/$ref"),
            new GeneratorConfig("Test.Client", "unused", derived), apiVersion: profile);
        Assert.Equal(expected, naming.Noun);
    }

    [Theory]
    [InlineData("v1.0", true)]
    [InlineData("v1.0", false)]
    [InlineData("beta", true)]
    [InlineData("beta", false)]
    public async Task CurrentLiteralLedgerAccountsForEveryActualOriginalSourceOperation(string profile, bool derived)
    {
        var root = RepoRoot();
        using var ledger = JsonDocument.Parse(File.ReadAllText(Path.Combine(root, "src", "Identity.DirectoryManagement",
            "wrapper", "Identity.DirectoryManagement_directiveMigrationMap.json")));
        var source = await ReadSpec(root, "openApiDocs", profile);
        var current = await ReadSpec(root, "openApiDocs_KiotaCompat", profile);
        var config = new GeneratorConfig("Test.Client", "unused", derived);
        foreach (var mapping in ledger.RootElement.GetProperty("mappings").EnumerateArray())
        {
            var review = mapping.GetProperty("profiles").GetProperty(profile);
            var originals = review.GetProperty("originalSourceOperations").EnumerateArray().ToArray();
            var currentKeys = new HashSet<string>(StringComparer.Ordinal);
            foreach (var evidence in originals)
            {
                var method = new HttpMethod(evidence.GetProperty("method").GetString()!);
                var path = evidence.GetProperty("path").GetString()!;
                Assert.Equal(evidence.GetProperty("operationId").GetString(), source.Paths[path].Operations![method].OperationId);
                if (evidence.GetProperty("disposition").GetString() == "RemovedDuplicate")
                {
                    Assert.False(current.Paths.ContainsKey(path));
                    continue;
                }
                var counterpart = evidence.GetProperty("compatibleOperation");
                var currentPath = counterpart.GetProperty("path").GetString()!;
                var operation = current.Paths[currentPath].Operations![method];
                Assert.Equal(counterpart.GetProperty("operationId").GetString(), operation.OperationId);
                currentKeys.Add(method.Method + " " + currentPath);
                if (mapping.GetProperty("classification").GetString()!.Contains("Suppression", StringComparison.Ordinal))
                    Assert.True(CmdletConfigurator.IsSuppressed(method, currentPath, config, apiVersion: profile));
            }
            Assert.Equal(currentKeys.OrderBy(k => k), review.GetProperty("operations").EnumerateArray()
                .Select(o => o.GetProperty("method").GetString() + " " + o.GetProperty("path").GetString()).OrderBy(k => k));
            if (mapping.GetProperty("classification").GetString() == "OperationIdSuppression")
            {
                var pattern = mapping.GetProperty("sourceContains").GetString()!["remove-path-by-operation: ".Length..];
                var selectedSource = source.Paths.SelectMany(path => path.Value.Operations!
                    .Where(op => System.Text.RegularExpressions.Regex.IsMatch(op.Value.OperationId!, pattern))
                    .Select(op => op.Key.Method + " " + path.Key)).OrderBy(k => k);
                Assert.Equal(selectedSource, originals.Select(o => o.GetProperty("method").GetString()
                    + " " + o.GetProperty("path").GetString()).OrderBy(k => k));
                var selectedCurrent = current.Paths.SelectMany(path => path.Value.Operations!
                    .Where(op => System.Text.RegularExpressions.Regex.IsMatch(op.Value.OperationId!, pattern))
                    .Select(op => op.Key.Method + " " + path.Key)).OrderBy(k => k);
                Assert.Equal(selectedCurrent, currentKeys.OrderBy(k => k));
            }
        }
        if (profile == "beta")
        {
            foreach (var neighbor in ledger.RootElement.GetProperty("independentNeighborEvidence").EnumerateArray())
            {
                var name = neighbor.GetProperty("module").GetString()!;
                var originalNeighbor = await ReadSpec(root, "openApiDocs", profile, name);
                var currentNeighbor = await ReadSpec(root, "openApiDocs_KiotaCompat", profile, name);
                var method = new HttpMethod(neighbor.GetProperty("method").GetString()!);
                var path = neighbor.GetProperty("path").GetString()!;
                Assert.Equal(neighbor.GetProperty("originalOperationId").GetString(),
                    originalNeighbor.Paths[path].Operations![method].OperationId);
                Assert.Equal(neighbor.GetProperty("currentOperationId").GetString(),
                    currentNeighbor.Paths[path].Operations![method].OperationId);
            }
        }
    }

    [Theory]
    [InlineData("v1.0", true)]
    [InlineData("v1.0", false)]
    [InlineData("beta", true)]
    [InlineData("beta", false)]
    public async Task IncompatibleTagOperationsKeepDistinctSourceBackedNamesAndTheirOwnBodies(string profile, bool derived)
    {
        var document = await ReadSpec(RepoRoot(), "openApiDocs_KiotaCompat", profile);
        var paths = document.Paths.Keys.Where(path => path.StartsWith("/directory/", StringComparison.Ordinal)
            && path.Contains("/impactedResources/", StringComparison.Ordinal)
            && (path.EndsWith("/addTag", StringComparison.Ordinal) || path.EndsWith("/removeTag", StringComparison.Ordinal))).ToArray();
        Assert.Equal(profile == "beta" ? 8 : 0, paths.Length);
        foreach (var path in document.Paths.Keys.Except(paths).ToArray())
            document.Paths.Remove(path);
        var output = Path.Combine(Path.GetTempPath(), "directory-management-actions-" + Guid.NewGuid().ToString("N"));
        try
        {
            var config = new GeneratorConfig("Test.Client", output, derived);
            await new PowerShellWrapperGenerationService(document, config, NullLogger.Instance, apiVersion: profile)
                .GenerateAsync(CancellationToken.None);
            var files = Directory.GetFiles(output, "*.g.cs");
            Assert.Equal(paths.Length, files.Length);
            foreach (var path in paths)
            {
                var naming = Naming.Resolve(new OperationInfo(HttpMethod.Post, path, Kind: OperationKind.Action), config, apiVersion: profile);
                var content = File.ReadAllText(Path.Combine(output, naming.ClassName[..^"Command".Length] + ".g.cs"));
                var isItem = path.Contains("/{impactedResource-id}", StringComparison.Ordinal);
                var isRemove = path.EndsWith("/removeTag", StringComparison.Ordinal);
                Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Post, path, config, apiVersion: profile));
                Assert.Contains($"[GraphRoute(\"POST\", \"{path}\")]", content);
                Assert.Contains("ShouldProcess(", content);
                Assert.DoesNotContain("InvokeCommand.InvokeScript", content);
                Assert.Equal(!isItem, content.Contains("public string[]? ResourceIds", StringComparison.Ordinal));
                Assert.Equal(isItem && isRemove, content.Contains("public string? TagId", StringComparison.Ordinal));
                Assert.Equal(!isItem || !isRemove, content.Contains("public string? DisplayName", StringComparison.Ordinal));
                Assert.Equal(isItem, naming.Noun.EndsWith(isRemove ? "RemoveTag" : "AddTag", StringComparison.Ordinal));
                if (!isItem)
                    Assert.EndsWith(isRemove ? "RemoveTagByDisplayName" : "AddTagByResourceId", naming.Noun);
            }
        }
        finally
        {
            if (Directory.Exists(output))
                Directory.Delete(output, recursive: true);
        }
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public async Task RootReferenceDeletesAreNotTheSharedDirectoryReferenceSuppression(bool derived)
    {
        var document = await ReadSpec(RepoRoot(), "openApiDocs_KiotaCompat", "beta");
        const string collection = "/administrativeUnits/{administrativeUnit-id}/members/$ref";
        const string item = "/administrativeUnits/{administrativeUnit-id}/members/{directoryObject-id}/$ref";
        var query = Assert.Single(document.Paths[collection].Operations![HttpMethod.Delete].Parameters!,
            p => p.In == ParameterLocation.Query);
        Assert.Equal("@id", query.Name);
        Assert.True(query.Required);
        var config = new GeneratorConfig("Test.Client", "unused", derived);
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Delete, collection, config, apiVersion: "beta"));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Delete, item, config, apiVersion: "beta"));
        Assert.Equal("MgAdministrativeUnitMemberReferenceByUri",
            Naming.Resolve(new OperationInfo(HttpMethod.Delete, collection), config, apiVersion: "beta").Noun);
        Assert.Equal("MgAdministrativeUnitMemberByRef",
            Naming.Resolve(new OperationInfo(HttpMethod.Delete, item), config, apiVersion: "beta").Noun);
    }

    [Theory]
    [InlineData("v1.0", true)]
    [InlineData("v1.0", false)]
    [InlineData("beta", true)]
    [InlineData("beta", false)]
    public async Task EverySurvivingRequiredNativeQueryHasMandatoryPrefixedInputAndTypedBinding(string profile, bool derived)
    {
        var document = await ReadSpec(RepoRoot(), "openApiDocs_KiotaCompat", profile);
        var config = new GeneratorConfig("Test.Client", "unused", derived);
        var expected = new List<(string Method, string Path, string PublicName, string Member, string Type)>();
        foreach (var path in document.Paths.Keys.ToArray())
        {
            var pathItem = document.Paths[path];
            foreach (var method in pathItem.Operations!.Keys.ToArray())
            {
                var operation = pathItem.Operations[method];
                var effective = new Dictionary<(string?, ParameterLocation?), IOpenApiParameter>();
                foreach (var parameter in (pathItem.Parameters ?? []).Concat(operation.Parameters ?? []))
                    effective[(parameter.Name, parameter.In)] = parameter;
                var required = effective.Values.Where(p => p.In == ParameterLocation.Query && p.Required).ToArray();
                if (required.Length == 0 || CmdletConfigurator.IsSuppressed(method, path, config, apiVersion: profile))
                {
                    pathItem.Operations.Remove(method);
                    continue;
                }
                foreach (var query in required)
                {
                    Assert.True(SchemaProperties.TryMapQueryInputType(query.Schema!, out var type, out _),
                        $"Unsupported actual required input {method} {path}: {query.Name}");
                    var member = query.Name!.TrimStart('@', '$').ToPascalCase('-', '.', '_');
                    expected.Add((method.Method, path, "Query" + member, member, type));
                }
            }
            if (pathItem.Operations.Count == 0)
                document.Paths.Remove(path);
        }
        var output = Path.Combine(Path.GetTempPath(), "directory-management-required-queries-" + Guid.NewGuid().ToString("N"));
        try
        {
            await new PowerShellWrapperGenerationService(document, config with { OutputPath = output },
                NullLogger.Instance, apiVersion: profile).GenerateAsync(CancellationToken.None);
            var sources = Directory.GetFiles(output, "*.g.cs").Select(File.ReadAllText).ToArray();
            foreach (var query in expected)
            {
                var source = Assert.Single(sources, s =>
                    s.Contains($"[GraphRoute(\"{query.Method}\", \"{query.Path}\")]", StringComparison.Ordinal));
                Assert.Contains($"public {query.Type} {query.PublicName} ", source);
                Assert.Contains($"requestConfiguration.QueryParameters.{query.Member} = {query.PublicName};", source);
                Assert.Matches(@"(?s)\[Parameter\(Mandatory = true,[^\]]*\)\]\s*\[ValidateNotNull(?:OrEmpty)?\]\s*public "
                    + System.Text.RegularExpressions.Regex.Escape(query.Type + " " + query.PublicName) + @"\b", source);
                Assert.DoesNotContain($"public {query.Type} {query.Member} ", source);
                Assert.Contains($"GetRequestAdapter(\"{profile}\")", source);
            }
            if (profile == "beta")
                Assert.NotEmpty(expected);
            else
                Assert.Empty(expected);
        }
        finally
        {
            if (Directory.Exists(output))
                Directory.Delete(output, recursive: true);
        }
    }

    [Theory]
    [InlineData("v1.0", true)]
    [InlineData("v1.0", false)]
    [InlineData("beta", true)]
    [InlineData("beta", false)]
    public async Task ActualContactAndSettingPatchSourcesNeverAddImplicitReadback(string profile, bool derived)
    {
        var document = await ReadSpec(RepoRoot(), "openApiDocs_KiotaCompat", profile);
        var selected = new[] { "/contacts/{orgContact-id}", "/settings/{directorySetting-id}" }
            .Where(document.Paths.ContainsKey).ToArray();
        Assert.Equal(profile == "beta" ? 2 : 1, selected.Length);
        foreach (var path in document.Paths.Keys.Except(selected).ToArray())
            document.Paths.Remove(path);
        foreach (var path in selected)
            foreach (var method in document.Paths[path].Operations!.Keys.Where(m => m != HttpMethod.Patch).ToArray())
                document.Paths[path].Operations!.Remove(method);
        var output = Path.Combine(Path.GetTempPath(), "directory-management-patch-results-" + Guid.NewGuid().ToString("N"));
        try
        {
            var config = new GeneratorConfig("Test.Client", output, derived);
            await new PowerShellWrapperGenerationService(document, config, NullLogger.Instance, apiVersion: profile)
                .GenerateAsync(CancellationToken.None);
            Assert.Equal(selected.Length, Directory.GetFiles(output, "*.g.cs").Length);
            foreach (var path in selected)
            {
                var naming = Naming.Resolve(new OperationInfo(HttpMethod.Patch, path), config, apiVersion: profile);
                var source = File.ReadAllText(Path.Combine(output, naming.ClassName[..^"Command".Length] + ".g.cs"));
                Assert.Contains($"[GraphRoute(\"PATCH\", \"{path}\")]", source);
                Assert.Contains(".PatchAsync(body,", source);
                Assert.DoesNotContain(".GetAsync(", source);
                Assert.DoesNotContain("public SwitchParameter PassThru", source);
                Assert.DoesNotContain("public SwitchParameter ReadBack", source);
                Assert.DoesNotContain("public SwitchParameter Refetch", source);
                Assert.Contains("if (result is not null)", source);
                Assert.Contains("WriteObject(result);", source);
                Assert.Contains("AddRequestHeaders(requestConfiguration.Headers)", source);
                Assert.Contains("body.DisplayName = DisplayName", source);
            }
        }
        finally
        {
            if (Directory.Exists(output))
                Directory.Delete(output, recursive: true);
        }
    }

    private static string RepoRoot()
    {
        var root = new DirectoryInfo(AppContext.BaseDirectory);
        while (root is not null && !File.Exists(Path.Combine(root.FullName, "tools", "Build-WrapperModule.ps1")))
            root = root.Parent;
        return root?.FullName ?? throw new InvalidOperationException("Repository root not found.");
    }

    private static async Task<OpenApiDocument> ReadSpec(string root, string source, string profile, string module = "Identity.DirectoryManagement")
    {
        var settings = new OpenApiReaderSettings();
        settings.AddYamlReader();
        using var input = File.OpenRead(Path.Combine(root, source, profile, module + ".yml"));
        var parsed = await OpenApiDocument.LoadAsync(input, settings: settings, cancellationToken: CancellationToken.None);
        return Assert.IsType<OpenApiDocument>(parsed.Document);
    }
}
