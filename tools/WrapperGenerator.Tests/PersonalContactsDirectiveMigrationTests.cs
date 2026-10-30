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

public sealed class PersonalContactsDirectiveMigrationTests
{
    private const string Contacts = "/users/{user-id}/contacts";
    private const string Contact = Contacts + "/{contact-id}";
    private const string Folders = "/users/{user-id}/contactFolders";
    private const string Folder = Folders + "/{contactFolder-id}";
    private const string FolderContact = Folder + "/contacts/{contact-id}";
    private const string ChildFolderContact = Folder + "/childFolders/{contactFolder-id1}/contacts/{contact-id}";

    private sealed record ExpectedRoute(string Method, string Path, string OperationId, string Verb, string Noun);

    private static readonly ExpectedRoute[] UnaffectedRoutes =
    [
        new("GET", Contacts, "user_ListContact", "Get", "MgUserContact"),
        new("POST", Contacts, "user_CreateContact", "New", "MgUserContact"),
        new("GET", Contact, "user_GetContact", "Get", "MgUserContact"),
        new("PATCH", Contact, "user_UpdateContact", "Update", "MgUserContact"),
        new("DELETE", Contact, "user_DeleteContact", "Remove", "MgUserContact"),
        new("GET", Folders, "user_ListContactFolder", "Get", "MgUserContactFolder"),
        new("POST", Folders, "user_CreateContactFolder", "New", "MgUserContactFolder"),
        new("GET", Folder, "user_GetContactFolder", "Get", "MgUserContactFolder"),
        new("PATCH", Folder, "user_UpdateContactFolder", "Update", "MgUserContactFolder"),
        new("DELETE", Folder, "user_DeleteContactFolder", "Remove", "MgUserContactFolder"),
        new("GET", FolderContact, "user.contactFolder_GetContact", "Get", "MgUserContactFolderContact"),
        new("PATCH", FolderContact, "user.contactFolder_UpdateContact", "Update", "MgUserContactFolderContact"),
        new("DELETE", FolderContact, "user.contactFolder_DeleteContact", "Remove", "MgUserContactFolderContact"),
        new("GET", ChildFolderContact, "user.contactFolder.childFolder_GetContact", "Get", "MgUserContactFolderChildFolderContact"),
        new("PATCH", ChildFolderContact, "user.contactFolder.childFolder_UpdateContact", "Update", "MgUserContactFolderChildFolderContact"),
        new("DELETE", ChildFolderContact, "user.contactFolder.childFolder_DeleteContact", "Remove", "MgUserContactFolderChildFolderContact"),
        new("GET", Contact + "/extensions", "user.contact_ListExtension", "Get", "MgUserContactExtension"),
        new("POST", Contact + "/extensions", "user.contact_CreateExtension", "New", "MgUserContactExtension"),
        new("GET", Contacts + "/$count", "user.contact_GetCount", "Get", "MgUserContactCount"),
        new("GET", Contact + "/photo/$value", "user.contact_GetPhotoContent", "Get", "MgUserContactPhotoContent"),
        new("PUT", Contact + "/photo/$value", "user.contact_SetPhotoContent", "Set", "MgUserContactPhotoContent"),
        new("DELETE", Contact + "/photo/$value", "user.contact_DeletePhotoContent", "Remove", "MgUserContactPhotoContent"),
    ];

    [Fact]
    public void SharedSourceAndReviewedLedgerContainNoDirectivesOrInventedMappings()
    {
        var moduleRoot = Path.Combine(FindRepoRoot(), "src", "PersonalContacts");
        var source = File.ReadAllText(Path.Combine(moduleRoot, "PersonalContacts.md"));
        Assert.False(Regex.IsMatch(source, @"^\s*directive\s*:", RegexOptions.Multiline),
            "New shared directives require an explicit migration review, not the empty audit ledger.");

        using var ledger = JsonDocument.Parse(File.ReadAllText(Path.Combine(
            moduleRoot, "wrapper", "PersonalContacts_directiveMigrationMap.json")));
        var mappings = ledger.RootElement.GetProperty("mappings");
        Assert.Equal(JsonValueKind.Array, mappings.ValueKind);
        Assert.Empty(mappings.EnumerateArray());
    }

    [Theory]
    [InlineData("v1.0", false)]
    [InlineData("v1.0", true)]
    [InlineData("beta", false)]
    [InlineData("beta", true)]
    public async Task CompatibleSpecPreservesUnsuppressedOperationsAndNeighboringNames(
        string profile, bool useCollisionData)
    {
        var specPath = Path.Combine(FindRepoRoot(), "openApiDocs_KiotaCompat", profile, "PersonalContacts.yml");
        Assert.True(File.Exists(specPath), $"Required compatible spec missing: {specPath}");
        var settings = new OpenApiReaderSettings();
        settings.AddYamlReader();
        using var stream = File.OpenRead(specPath);
        var result = await OpenApiDocument.LoadAsync(
            stream, settings: settings, cancellationToken: TestContext.Current.CancellationToken);
        var document = Assert.IsType<OpenApiDocument>(result.Document);
        Assert.NotNull(document.Paths);
        Assert.Equal(40, document.Paths.Count);
        Assert.Equal(73, document.Paths.Values.Sum(path => path.Operations?.Count ?? 0));

        var config = new GeneratorConfig("Microsoft.Graph.PersonalContacts", string.Empty,
            UseCollisionData: useCollisionData);
        foreach (var (path, item) in document.Paths)
        {
            Assert.NotNull(item.Operations);
            foreach (var (method, operation) in item.Operations)
            {
                Assert.False(string.IsNullOrWhiteSpace(operation.OperationId));
                Assert.False(CmdletConfigurator.IsSuppressed(method, path, config, apiVersion: profile),
                    $"{profile}: unexpected suppression of {method} {path} ({operation.OperationId}).");
            }
        }

        foreach (var expected in UnaffectedRoutes)
        {
            Assert.True(document.Paths.TryGetValue(expected.Path, out var item),
                $"{profile}: missing path {expected.Path}.");
            Assert.NotNull(item.Operations);
            var method = new HttpMethod(expected.Method);
            Assert.True(item.Operations.TryGetValue(method, out var operation),
                $"{profile}: missing {method} {expected.Path}.");
            Assert.Equal(expected.OperationId, operation.OperationId);

            var naming = Naming.Resolve(new OperationInfo(method, expected.Path), config, apiVersion: profile);
            Assert.Equal(expected.Verb, naming.VerbName);
            Assert.Equal(expected.Noun, naming.Noun);
            Assert.Equal($"{expected.Verb}{expected.Noun}Command", naming.ClassName);
            Assert.Equal(expected.Path, naming.SourcePath);
            Assert.Equal(expected.Method, naming.SourceMethod);
        }

        const string actionPath = Contact + "/permanentDelete";
        Assert.Equal("user.contact_permanentDelete",
            document.Paths[actionPath].Operations![HttpMethod.Post].OperationId);
        var actionName = Naming.Resolve(
            new OperationInfo(HttpMethod.Post, actionPath, Kind: OperationKind.Action),
            config, apiVersion: profile);
        // Only v1.0 has a derived published-name override; beta must not use that default context.
        var usesPublishedName = useCollisionData && profile == "v1.0";
        Assert.Equal(usesPublishedName ? "Remove" : "Invoke", actionName.VerbName);
        Assert.Equal(usesPublishedName ? "MgUserContactPermanent" : "MgUserContactPermanentDelete",
            actionName.Noun);
    }

    private static string FindRepoRoot()
    {
        var directory = new DirectoryInfo(AppContext.BaseDirectory);
        while (directory is not null
            && !Directory.Exists(Path.Combine(directory.FullName, ".git"))
            && !File.Exists(Path.Combine(directory.FullName, ".git")))
            directory = directory.Parent;
        return directory?.FullName
            ?? throw new InvalidOperationException("Could not locate repo root from " + AppContext.BaseDirectory);
    }
}
