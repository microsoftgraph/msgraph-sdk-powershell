using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Reader;
using WrapperGenerator;
using Xunit;

namespace WrapperGenerator.Tests;

public sealed class UsersDirectiveMigrationTests
{
    private static readonly (string Method, string Path, string LegacyId, string CurrentId)[] RootTodo =
    [
        ("GET", "/users/{user-id}/todo", "user_GetTodo", "users.GetTodo"),
        ("PATCH", "/users/{user-id}/todo", "user_UpdateTodo", "users.UpdateTodo"),
        ("DELETE", "/users/{user-id}/todo", "user_DeleteTodo", "users.DeleteTodo"),
    ];

    [Theory]
    [InlineData("v1.0")]
    [InlineData("beta")]
    public async Task OriginalSelectorAccountsForEveryActualLegacyMatchAndUniqueSuccessor(string profile)
    {
        var legacy = await ReadSpec("openApiDocs", profile);
        var compatible = await ReadSpec("openApiDocs_KiotaCompat", profile);
        var source = File.ReadAllText(Path.Combine(RepoRoot(), "src", "Users", "Users.md"));
        var selector = Regex.Match(source, @"(?m)^\s+- remove-path-by-operation: (.+)\r?$");
        Assert.True(selector.Success);
        var regex = new Regex(selector.Groups[1].Value.Trim());
        var selected = legacy.Paths.SelectMany(path => path.Value.Operations!
                .Where(operation => regex.IsMatch(operation.Value.OperationId!))
                .Select(operation => (Method: operation.Key.Method.ToUpperInvariant(),
                    Path: path.Key, Id: operation.Value.OperationId)))
            .ToArray();

        Assert.Equal(RootTodo.Length, selected.Length);
        foreach (var expected in RootTodo)
        {
            Assert.Single(selected, operation => operation.Method == expected.Method
                && operation.Path == expected.Path && operation.Id == expected.LegacyId);
            var successor = Assert.Single(compatible.Paths[expected.Path].Operations!,
                operation => operation.Key.Method == expected.Method);
            Assert.Equal(expected.CurrentId, successor.Value.OperationId);
            Assert.DoesNotMatch(regex, successor.Value.OperationId!);
        }

        Assert.DoesNotMatch(regex, "user_GetOutlook");
        Assert.DoesNotMatch(regex, "user.todo_ListList");
        // The later List rename cannot resurrect a path removed by directive 1.
        var singleton = legacy.Paths["/users/{user-id}/todo"].Operations![HttpMethod.Get];
        var response = singleton.Responses!["2XX"].Content!["application/json"].Schema;
        var reference = Assert.IsType<OpenApiSchemaReference>(response);
        Assert.Equal("microsoft.graph.todo", reference.Reference!.Id);
    }

    [Theory]
    [InlineData("v1.0", true)]
    [InlineData("v1.0", false)]
    [InlineData("beta", true)]
    [InlineData("beta", false)]
    public async Task SharedSuppressionsAreExactInBothCompatibleProfiles(string profile, bool useCollisionData)
    {
        var document = await ReadSpec("openApiDocs_KiotaCompat", profile);
        var config = new GeneratorConfig("Test.Client", "unused", profile, useCollisionData);
        foreach (var operation in RootTodo)
            AssertSuppressed(document, config, operation.Method, operation.Path, operation.CurrentId);
        AssertSuppressed(document, config, "POST", "/users/{user-id}/licenseDetails", "users.CreateLicenseDetails");
        AssertSuppressed(document, config, "PATCH", "/users/{user-id}/photo", "users.UpdatePhoto");

        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Post, "/users/{user-id}/todo", config));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Patch, "/users/{user-id}/todo/lists/{todoTaskList-id}", config));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Patch, "/users/{user-id}/photos/{profilePhoto-id}/child", config));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get, "/users/{user-id}/licensedetails/child", config));
    }

    [Theory]
    [InlineData("v1.0")]
    [InlineData("beta")]
    public async Task UnaffectedNeighborsAndExistingCuratedPhotoBehaviorRemain(string profile)
    {
        var document = await ReadSpec("openApiDocs_KiotaCompat", profile);
        var config = new GeneratorConfig("Test.Client", "unused", profile);
        (string Method, string Path, string Noun)[] neighbors =
        [
            ("GET", "/users", "MgUser"),
            ("POST", "/users", "MgUser"),
            ("PATCH", "/users/{user-id}", "MgUser"),
            ("GET", "/users/{user-id}/licenseDetails", "MgUserLicenseDetail"),
            ("GET", "/users/{user-id}/licenseDetails/{licenseDetails-id}", "MgUserLicenseDetail"),
            ("GET", "/users/{user-id}/photo", "MgUserPhoto"),
            ("GET", "/users/{user-id}/photo/$value", "MgUserPhotoContent"),
            ("PUT", "/users/{user-id}/photo/$value", "MgUserPhotoContent"),
            ("GET", "/users/{user-id}/todo/lists", "MgUserTodoList"),
            ("POST", "/users/{user-id}/todo/lists", "MgUserTodoList"),
            ("GET", "/users/{user-id}/todo/lists/{todoTaskList-id}", "MgUserTodoList"),
        ];
        foreach (var neighbor in neighbors)
        {
            var method = new HttpMethod(neighbor.Method);
            Assert.True(document.Paths[neighbor.Path].Operations!.ContainsKey(method));
            Assert.False(CmdletConfigurator.IsSuppressed(method, neighbor.Path, config));
            Assert.Equal(neighbor.Noun, Naming.Resolve(new OperationInfo(method, neighbor.Path), config).Noun);
        }

        foreach (var path in new[] { "/users/{user-id}/photos", "/users/{user-id}/photos/{profilePhoto-id}" })
        {
            Assert.True(document.Paths.ContainsKey(path));
            Assert.True(CmdletConfigurator.IsSuppressed(HttpMethod.Get, path, config));
        }
        // Preserve the existing v1.0 derived Outlook suppression without extending a
        // case-sensitive legacy selector to an operation it did not select in beta.
        Assert.Equal(profile == "v1.0",
            CmdletConfigurator.IsSuppressed(HttpMethod.Get, "/users/{user-id}/outlook", config));
    }

    private static void AssertSuppressed(OpenApiDocument document, GeneratorConfig config,
        string methodName, string path, string operationId)
    {
        var method = new HttpMethod(methodName);
        Assert.Equal(operationId, document.Paths[path].Operations![method].OperationId);
        Assert.True(CmdletConfigurator.IsSuppressed(method, path, config));
    }

    private static async Task<OpenApiDocument> ReadSpec(string root, string profile)
    {
        var settings = new OpenApiReaderSettings();
        settings.AddYamlReader();
        await using var stream = File.OpenRead(Path.Combine(RepoRoot(), root, profile, "Users.yml"));
        var result = await OpenApiDocument.LoadAsync(stream, settings: settings, cancellationToken: CancellationToken.None);
        Assert.NotNull(result.Document);
        return result.Document;
    }

    private static string RepoRoot()
    {
        for (var directory = new DirectoryInfo(AppContext.BaseDirectory); directory is not null; directory = directory.Parent)
            if (Directory.Exists(Path.Combine(directory.FullName, "openApiDocs_KiotaCompat")))
                return directory.FullName;
        throw new DirectoryNotFoundException("Cannot locate the compatible Users specifications.");
    }
}
