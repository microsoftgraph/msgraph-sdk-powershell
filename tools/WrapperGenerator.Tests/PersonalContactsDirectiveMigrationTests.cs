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
        new("GET", Contacts, "users.ListContacts", "Get", "MgUserContact"),
        new("POST", Contacts, "users.CreateContacts", "New", "MgUserContact"),
        new("GET", Contact, "users.GetContacts", "Get", "MgUserContact"),
        new("PATCH", Contact, "users.UpdateContacts", "Update", "MgUserContact"),
        new("DELETE", Contact, "users.DeleteContacts", "Remove", "MgUserContact"),
        new("GET", Folders, "users.ListContactFolders", "Get", "MgUserContactFolder"),
        new("POST", Folders, "users.CreateContactFolders", "New", "MgUserContactFolder"),
        new("GET", Folder, "users.GetContactFolders", "Get", "MgUserContactFolder"),
        new("PATCH", Folder, "users.UpdateContactFolders", "Update", "MgUserContactFolder"),
        new("DELETE", Folder, "users.DeleteContactFolders", "Remove", "MgUserContactFolder"),
        new("GET", FolderContact, "users.contactFolders.GetContacts", "Get", "MgUserContactFolderContact"),
        new("PATCH", FolderContact, "users.contactFolders.UpdateContacts", "Update", "MgUserContactFolderContact"),
        new("DELETE", FolderContact, "users.contactFolders.DeleteContacts", "Remove", "MgUserContactFolderContact"),
        new("GET", ChildFolderContact, "users.contactFolders.childFolders.GetContacts", "Get", "MgUserContactFolderChildFolderContact"),
        new("PATCH", ChildFolderContact, "users.contactFolders.childFolders.UpdateContacts", "Update", "MgUserContactFolderChildFolderContact"),
        new("DELETE", ChildFolderContact, "users.contactFolders.childFolders.DeleteContacts", "Remove", "MgUserContactFolderChildFolderContact"),
        new("GET", Contact + "/extensions", "users.contacts.ListExtensions", "Get", "MgUserContactExtension"),
        new("POST", Contact + "/extensions", "users.contacts.CreateExtensions", "New", "MgUserContactExtension"),
        new("GET", Contacts + "/$count", "users.contacts.GetCount-4943", "Get", "MgUserContactCount"),
        new("GET", Contact + "/photo/$value", "users.contacts.GetPhotoContent", "Get", "MgUserContactPhotoContent"),
        new("PUT", Contact + "/photo/$value", "users.contacts.UpdatePhotoContent", "Set", "MgUserContactPhotoContent"),
        new("DELETE", Contact + "/photo/$value", "users.contacts.DeletePhotoContent", "Remove", "MgUserContactPhotoContent"),
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
    [InlineData("v1.0")]
    [InlineData("beta")]
    public async Task CompatibleSpecPreservesUnsuppressedOperationsAndNeighboringNames(string profile)
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

        var config = new GeneratorConfig("Microsoft.Graph.PersonalContacts", string.Empty, profile);
        foreach (var (path, item) in document.Paths)
        {
            Assert.NotNull(item.Operations);
            foreach (var (method, operation) in item.Operations)
            {
                Assert.False(string.IsNullOrWhiteSpace(operation.OperationId));
                Assert.False(CmdletConfigurator.IsSuppressed(method, path, config),
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

            // Pin both structural naming and the production curated/derived configuration.
            foreach (var naming in new[]
            {
                Naming.Resolve(new OperationInfo(method, expected.Path)),
                Naming.Resolve(new OperationInfo(method, expected.Path), config),
            })
            {
                Assert.Equal(expected.Verb, naming.VerbName);
                Assert.Equal(expected.Noun, naming.Noun);
                Assert.Equal($"{expected.Verb}{expected.Noun}Command", naming.ClassName);
                Assert.Equal(expected.Path, naming.SourcePath);
                Assert.Equal(expected.Method, naming.SourceMethod);
            }
        }
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
