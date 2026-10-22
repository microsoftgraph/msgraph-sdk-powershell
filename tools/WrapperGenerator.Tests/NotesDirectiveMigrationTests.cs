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

public sealed class NotesDirectiveMigrationTests
{
    private static string RepoRoot()
    {
        var root = new DirectoryInfo(AppContext.BaseDirectory);
        while (root is not null && !Directory.Exists(Path.Combine(root.FullName, "openApiDocs_KiotaCompat")))
            root = root.Parent;
        Assert.NotNull(root);
        return root.FullName;
    }

    private static async Task<OpenApiDocument> ReadSpec(string root, string profile)
    {
        var path = Path.Combine(RepoRoot(), root, profile, "Notes.yml");
        Assert.True(File.Exists(path));
        var settings = new OpenApiReaderSettings();
        settings.AddYamlReader();
        using var stream = File.OpenRead(path);
        var result = await OpenApiDocument.LoadAsync(stream, settings: settings, cancellationToken: CancellationToken.None);
        Assert.NotNull(result.Document);
        return result.Document;
    }

    [Fact]
    public void PreservesInvalidOriginalAndRepairsExactlyOneTerminalParenthesis()
    {
        using var ledger = JsonDocument.Parse(File.ReadAllText(
            Path.Combine(RepoRoot(), "src", "Notes", "wrapper", "Notes_directiveMigrationMap.json")));
        var audit = ledger.RootElement.GetProperty("sourceCorrection");
        const string prefix = "- remove-path-by-operation: ";
        const string invalidOriginal = @"^(user|group|site)_.*Onenote$|.*\.onenote\..*parent.*|.*\.notebook_(Get|Update|Delete)Section.*|.*\.notebook\.section.*|.*\.sectionGroup_(Get|Update|Delete)Section.*|.*\.sectionGroup\.section.*|.*\.section_(Get|Update|Delete)Page|.*\.section.page.*|.*\.onenote_(List|Create|Update|Delete)(Operation|Resource)|group\.site_.*Onenote$|group\.site\.onenote.*$|.*\.onenote\..*\.parent.*|.*\.notebook\.section.*|.*\.sectionGroup\.section.*|.*\.section\.page.*|site\..*_(Create|Get|Update|Delete)Activity$|site\..*\.activity.*|^site_(remove|add)$|^.*site\.(.*_.*SourceColumn|contentType_.*(Base|BaseType|ColumnPosition)|.*_(Get|Create|Update|Delete)Activity|.*\.activity.*";
        Assert.Equal(prefix + invalidOriginal, audit.GetProperty("originalDirective").GetString());
        Assert.Throws<RegexParseException>(() => new Regex(invalidOriginal));
        Assert.Contains("Not enough )'s", audit.GetProperty("originalParseError").GetString());
        var corrected = prefix + invalidOriginal + ")";
        Assert.Equal(corrected, audit.GetProperty("correctedDirective").GetString());
        var source = File.ReadAllText(Path.Combine(RepoRoot(), "src", "Notes", "Notes.md"));
        Assert.Equal(corrected, Regex.Match(source, @"(?m)^  - remove-path-by-operation: .+$").Value.Trim());
    }

    [Theory]
    [InlineData("v1.0")]
    [InlineData("beta")]
    public async Task CorrectedSelectorAccountsForEveryActualLegacySuccessorAndNoExtraSuppressions(string profile)
    {
        using var ledger = JsonDocument.Parse(File.ReadAllText(
            Path.Combine(RepoRoot(), "src", "Notes", "wrapper", "Notes_directiveMigrationMap.json")));
        var first = ledger.RootElement.GetProperty("mappings")[0];
        var active = first.GetProperty("sourceContains").GetString()!;
        var regex = new Regex(active["- remove-path-by-operation: ".Length..]);
        var legacy = await ReadSpec("openApiDocs", profile);
        var compatible = await ReadSpec("openApiDocs_KiotaCompat", profile);
        var sourceMatches = legacy.Paths.SelectMany(path => path.Value.Operations!.Select(op =>
                (Path: path.Key, Method: op.Key, Operation: op.Value)))
            .Where(op => regex.IsMatch(op.Operation.OperationId!)).ToArray();
        Assert.Equal(298, sourceMatches.Length);
        var profileMap = first.GetProperty("profiles").GetProperty(profile);
        Assert.Equal("Legacy", profileMap.GetProperty("operationIdSource").GetString());
        Assert.False(profileMap.GetProperty("absenceExpected").GetBoolean());
        Assert.Empty(profileMap.GetProperty("removedLegacyOperations").EnumerateArray());
        var operations = profileMap.GetProperty("operations").EnumerateArray().ToArray();
        Assert.Equal(298, operations.Length);
        var actualSourceKeys = sourceMatches.Select(op => $"{op.Method} {op.Path} [{op.Operation.OperationId}]").ToHashSet();
        var reviewedSourceKeys = operations.Select(op =>
            $"{op.GetProperty("method").GetString()} {op.GetProperty("legacyPath").GetString()} [{op.GetProperty("legacyOperationId").GetString()}]").ToHashSet();
        Assert.True(actualSourceKeys.SetEquals(reviewedSourceKeys));
        Assert.Equal(54, operations.Count(op => op.TryGetProperty("legacyPathTranslation", out _)));

        var suppressionKeys = new HashSet<string>(StringComparer.Ordinal);
        foreach (var operation in operations)
        {
            var method = new HttpMethod(operation.GetProperty("method").GetString()!);
            var path = operation.GetProperty("path").GetString()!;
            var oldPath = operation.GetProperty("legacyPath").GetString()!;
            var current = compatible.Paths[path].Operations![method];
            Assert.Equal(operation.GetProperty("operationId").GetString(), current.OperationId);
            var bridgePath = oldPath;
            if (operation.TryGetProperty("legacyPathTranslation", out var translation))
            {
                Assert.Equal("UnqualifyFinalOperation", translation.GetString());
                var old = legacy.Paths[oldPath].Operations![method];
                var oldKind = Assert.IsType<JsonNodeExtension>(old.Extensions!["x-ms-docs-operation-type"]).Node!.ToString();
                var newKind = Assert.IsType<JsonNodeExtension>(current.Extensions!["x-ms-docs-operation-type"]).Node!.ToString();
                Assert.Equal(oldKind, newKind);
                Assert.Contains(oldKind, new[] { "action", "function" });
                Assert.Equal(oldKind == "action" ? HttpMethod.Post : HttpMethod.Get, method);
                bridgePath = Regex.Replace(oldPath, @"/microsoft\.graph\.([^/]+)$", "/$1");
            }
            var normalized = CmdletConfigurator.NormalizePathTemplate(bridgePath);
            Assert.Equal(normalized, CmdletConfigurator.NormalizePathTemplate(path));
            Assert.Single(compatible.Paths, candidate =>
                CmdletConfigurator.NormalizePathTemplate(candidate.Key) == normalized &&
                candidate.Value.Operations!.ContainsKey(method));
            suppressionKeys.Add($"{method} {path}");
        }
        foreach (var operation in ledger.RootElement.GetProperty("mappings")[1]
            .GetProperty("profiles").GetProperty(profile).GetProperty("operations").EnumerateArray())
            suppressionKeys.Add($"{operation.GetProperty("method").GetString()} {operation.GetProperty("path").GetString()}");
        Assert.Equal(301, suppressionKeys.Count);

        var config = new GeneratorConfig("Notes", "", profile, UseCollisionData: false);
        foreach (var path in compatible.Paths)
        foreach (var operation in path.Value.Operations!)
            Assert.Equal(suppressionKeys.Contains($"{operation.Key} {path.Key}"),
                CmdletConfigurator.IsSuppressed(operation.Key, path.Key, config));
    }

    [Theory]
    [InlineData("v1.0")]
    [InlineData("beta")]
    public async Task PublishedSectionGroupRoutesRetainTheirActualParameterContracts(string profile)
    {
        var document = await ReadSpec("openApiDocs_KiotaCompat", profile);
        foreach (var (root, id) in new[] { ("groups", "group-id"), ("sites", "site-id"), ("users", "user-id") })
        {
            var list = $"/{root}/{{{id}}}/onenote/sectionGroups";
            var get = list + "/{sectionGroup-id}";
            var nested = get + "/sectionGroups";
            foreach (var (path, operationId, isList) in new[]
            {
                (list, $"{root}.onenote.ListSectionGroups", true),
                (get, $"{root}.onenote.GetSectionGroups", false),
                (nested, $"{root}.onenote.sectionGroups.ListSectionGroups", true),
            })
            {
                var item = document.Paths[path];
                Assert.Empty(item.Parameters ?? []);
                var operation = item.Operations![HttpMethod.Get];
                Assert.Equal(operationId, operation.OperationId);
                var parameters = operation.Parameters!;
                Assert.All(parameters, parameter =>
                {
                    Assert.Equal(ParameterLocation.Query, parameter.In);
                    Assert.False(parameter.Required);
                    Assert.False(parameter.Explode);
                    Assert.Equal(ParameterStyle.Form, parameter.Style);
                });
                var expectedNames = isList
                    ? new[] { "$count", "$expand", "$filter", "$orderby", "$search", "$select", "$skip", "$top" }
                    : new[] { "$expand", "$select" };
                Assert.Equal(expectedNames, parameters.Select(parameter => parameter.Name).OrderBy(name => name));
                foreach (var parameter in parameters)
                {
                    var expectedType = parameter.Name switch
                    {
                        "$count" => JsonSchemaType.Boolean,
                        "$skip" or "$top" => JsonSchemaType.Integer,
                        "$expand" or "$select" or "$orderby" => JsonSchemaType.Array,
                        _ => JsonSchemaType.String,
                    };
                    Assert.Equal(expectedType, parameter.Schema!.Type);
                    if (expectedType == JsonSchemaType.Array)
                        Assert.Equal(JsonSchemaType.String, parameter.Schema.Items!.Type);
                }
                Assert.Equal(isList ? "microsoft.graph.sectionGroupCollectionResponse" : "microsoft.graph.sectionGroup",
                    Assert.IsType<OpenApiSchemaReference>(
                        operation.Responses!["2XX"].Content!["application/json"].Schema).Reference!.Id);
            }
        }
    }

    [Fact]
    public void SharedWhereSelectorsAndActionsRemainActiveAndUnchanged()
    {
        var source = File.ReadAllText(Path.Combine(RepoRoot(), "src", "Notes", "Notes.md")).Replace("\r\n", "\n");
        var body = Regex.Match(source, @"(?s)directive:\s*\n(?<body>.*?)```").Groups["body"].Value;
        body = Regex.Replace(body, @"(?m)^\s*#[^\n]*\n", "");
        var directives = Regex.Matches(body, @"(?ms)^  - .+?(?=^  - |\z)");
        Assert.Equal(9, directives.Count);
        const string pageSubjects = "^GroupOnenoteNotebookSectionGroupSectionPage$|^GroupOnenoteNotebookSectionPage$|^GroupOnenotePage$|^GroupOnenoteSectionGroupSectionPage$|^GroupOnenoteSectionPage$|^SiteOnenoteNotebookSectionGroupSectionPage$|^SiteOnenoteNotebookSectionPage$|^SiteOnenotePage$|^SiteOnenoteSectionGroupSectionPage$|^SiteOnenoteSectionPage$|^UserOnenoteNotebookSectionGroupSectionPage$|^UserOnenoteNotebookSectionPage$|^UserOnenotePage$|^UserOnenoteSectionGroupSectionPage$|^UserOnenoteSectionPage$";
        Assert.Equal("- where:\n      verb: Update\n      subject: " + pageSubjects +
            "\n      variant: ^Update$|UpdateExpanded$|UpdateViaIdentity$|UpdateViaIdentityExpanded$\n    remove: true",
            directives[1].Value.Trim());
        var renames = new[]
        {
            ("Update", "(^SiteOnenote.*)", "$1Content"),
            ("Get", "^(GroupOnenote)Notebook(RecentNotebook)$", "$1$2"),
            ("Update", "^(GroupOnenotePage)$", "$1Content"),
            ("Update", "^(GroupOnenoteSectionPage)$", "$1Content"),
            ("Update", "^(GroupOnenoteNotebookSectionPage)$", "$1Content"),
            ("Update", "^(GroupOnenoteSectionGroupSectionPage)$", "$1Content"),
            ("Update", "^(GroupOnenoteNotebookSectionGroupSectionPage)$", "$1Content"),
        };
        for (var i = 0; i < renames.Length; i++)
        {
            var (verb, subject, replacement) = renames[i];
            Assert.Equal($"- where:\n      verb: {verb}\n      subject: {subject}\n    set:\n      subject: {replacement}",
                directives[i + 2].Value.Trim());
        }
    }

    [Theory]
    [InlineData("v1.0")]
    [InlineData("beta")]
    public async Task CompatibleProfilesRetainRenamedOperationsAndUnchangedNeighbors(string profile)
    {
        var document = await ReadSpec("openApiDocs_KiotaCompat", profile);
        var config = new GeneratorConfig("Notes", "", profile);
        foreach (var route in new[]
        {
            "/sites/{site-id}/onenote/notebooks/{notebook-id}",
            "/sites/{site-id}/onenote/sectionGroups/{sectionGroup-id}",
            "/sites/{site-id}/onenote/sections/{onenoteSection-id}",
        })
        {
            Assert.NotNull(document.Paths[route].Operations![HttpMethod.Patch].OperationId);
            Assert.NotNull(document.Paths[route].Operations![HttpMethod.Get].OperationId);
            Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get, route, config));
        }
        foreach (var route in new[]
        {
            "/groups/{group-id}/onenote/pages/{onenotePage-id}",
            "/sites/{site-id}/onenote/pages/{onenotePage-id}",
            "/users/{user-id}/onenote/pages/{onenotePage-id}",
        })
        {
            Assert.NotNull(document.Paths[route].Operations![HttpMethod.Patch].OperationId);
            Assert.NotNull(document.Paths[route + "/onenotePatchContent"].Operations![HttpMethod.Post].OperationId);
            Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Post, route + "/onenotePatchContent", config));
        }
        const string recent = "/groups/{group-id}/onenote/notebooks/getRecentNotebooks(includePersonalNotebooks={includePersonalNotebooks})";
        Assert.NotNull(document.Paths[recent].Operations![HttpMethod.Get].OperationId);
        Assert.NotNull(document.Paths["/groups/{group-id}/onenote/notebooks"].Operations![HttpMethod.Get].OperationId);
    }

    [Theory]
    [InlineData("v1.0")]
    [InlineData("beta")]
    public void RemovesResourcePageUpdatesWithoutRemovingPatchContentAction(string profile)
    {
        var config = new GeneratorConfig("Notes", "", profile);
        foreach (var root in new[] { "/groups/{group-id}", "/sites/{site-id}", "/users/{user-id}" })
        {
            var page = root + "/onenote/pages/{onenotePage-id}";
            Assert.True(CmdletConfigurator.IsSuppressed(HttpMethod.Patch, page, config));
            Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get, page, config));
            Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Post, page + "/onenotePatchContent", config));
        }
    }

    [Theory]
    [InlineData("v1.0", "/sites/{site-id}/onenote/notebooks/{notebook-id}", "MgSiteOnenoteNotebookContent")]
    [InlineData("beta", "/sites/{site-id}/onenote/notebooks/{notebook-id}", "MgSiteOnenoteNotebookContent")]
    [InlineData("v1.0", "/sites/{site-id}/onenote/sectionGroups/{sectionGroup-id}", "MgSiteOnenoteSectionGroupContent")]
    [InlineData("beta", "/sites/{site-id}/onenote/sectionGroups/{sectionGroup-id}", "MgSiteOnenoteSectionGroupContent")]
    [InlineData("v1.0", "/sites/{site-id}/onenote/sections/{onenoteSection-id}", "MgSiteOnenoteSectionContent")]
    [InlineData("beta", "/sites/{site-id}/onenote/sections/{onenoteSection-id}", "MgSiteOnenoteSectionContent")]
    public void SiteUpdateRenameDoesNotRenameReadNeighbor(string profile, string path, string expected)
    {
        var config = new GeneratorConfig("Notes", "", profile);
        var update = Naming.Resolve(new OperationInfo(HttpMethod.Patch, path), config);
        Assert.Equal("Update", update.VerbName);
        Assert.Equal(expected, update.Noun);
        Assert.Equal(expected[..^"Content".Length],
            Naming.Resolve(new OperationInfo(HttpMethod.Get, path), config).Noun);
    }

    [Theory]
    [InlineData("v1.0", "/groups/{group-id}/onenote/pages/{onenotePage-id}/onenotePatchContent", "MgGroupOnenotePageContent")]
    [InlineData("beta", "/groups/{group-id}/onenote/pages/{onenotePage-id}/onenotePatchContent", "MgGroupOnenotePageContent")]
    [InlineData("v1.0", "/sites/{site-id}/onenote/pages/{onenotePage-id}/onenotePatchContent", "MgSiteOnenotePageContent")]
    [InlineData("beta", "/sites/{site-id}/onenote/pages/{onenotePage-id}/onenotePatchContent", "MgSiteOnenotePageContent")]
    public void RetainsPublishedContentActionName(string profile, string path, string expected)
    {
        var config = new GeneratorConfig("Notes", "", profile);
        var action = Naming.Resolve(new OperationInfo(HttpMethod.Post, path, Kind: OperationKind.Action), config);
        Assert.Equal("Update", action.VerbName);
        Assert.Equal(expected, action.Noun);
        Assert.Equal(path, action.SourcePath);
    }

    [Theory]
    [InlineData("v1.0")]
    [InlineData("beta")]
    public void RemovesRedundantNotebookFromGroupRecentNotebookOnly(string profile)
    {
        const string root = "/groups/{group-id}/onenote/notebooks";
        const string recent = root + "/getRecentNotebooks(includePersonalNotebooks={includePersonalNotebooks})";
        var config = new GeneratorConfig("Notes", "", profile);
        Assert.Equal("MgGroupOnenoteRecentNotebook",
            Naming.Resolve(new OperationInfo(HttpMethod.Get, recent, Kind: OperationKind.Function), config).Noun);
        Assert.Equal("MgGroupOnenoteNotebook",
            Naming.Resolve(new OperationInfo(HttpMethod.Get, root), config).Noun);
    }
}
