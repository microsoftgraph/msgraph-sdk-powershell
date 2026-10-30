using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Reader;
using WrapperGenerator;
using Xunit;

namespace WrapperGenerator.Tests;

public sealed class UsersDirectiveMigrationTests
{
    private static readonly (string Method, string Path, string LegacyId, string CurrentId)[] RootTodo =
    [
        ("GET", "/users/{user-id}/todo", "user_GetTodo", "user_GetTodo"),
        ("PATCH", "/users/{user-id}/todo", "user_UpdateTodo", "user_UpdateTodo"),
        ("DELETE", "/users/{user-id}/todo", "user_DeleteTodo", "user_DeleteTodo"),
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
        var currentSelected = compatible.Paths.SelectMany(path => path.Value.Operations!
            .Where(operation => regex.IsMatch(operation.Value.OperationId!))
            .Select(operation => $"{operation.Key.Method} {path.Key} [{operation.Value.OperationId}]")).ToArray();
        Assert.Equal(selected.Select(operation => $"{operation.Method} {operation.Path} [{operation.Id}]").Order(),
            currentSelected.Order());
        foreach (var expected in RootTodo)
        {
            Assert.Single(selected, operation => operation.Method == expected.Method
                && operation.Path == expected.Path && operation.Id == expected.LegacyId);
            var successor = Assert.Single(compatible.Paths[expected.Path].Operations!,
                operation => operation.Key.Method == expected.Method);
            Assert.Equal(expected.CurrentId, successor.Value.OperationId);
            Assert.Matches(regex, successor.Value.OperationId!);
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
    [InlineData("v1.0")]
    [InlineData("beta")]
    public async Task ReviewedLedgerRetainsEveryRealSuccessorAndNeverClaimsApiAbsence(string profile)
    {
        var compatible = await ReadSpec("openApiDocs_KiotaCompat", profile);
        var source = File.ReadAllText(Path.Combine(RepoRoot(), "src", "Users", "Users.md"));
        using var ledger = JsonDocument.Parse(File.ReadAllText(Path.Combine(RepoRoot(),
            "src", "Users", "wrapper", "Users_directiveMigrationMap.json")));
        var mappings = ledger.RootElement.GetProperty("mappings").EnumerateArray().ToArray();
        Assert.Equal(4, mappings.Length);
        foreach (var mapping in mappings)
        {
            Assert.Equal("Users", mapping.GetProperty("module").GetString());
            Assert.Contains(mapping.GetProperty("sourceContains").GetString()!, source, StringComparison.Ordinal);
            var profileMapping = mapping.GetProperty("profiles").GetProperty(profile);
            Assert.False(profileMapping.GetProperty("absenceExpected").GetBoolean());
            var operations = profileMapping.GetProperty("operations").EnumerateArray().ToArray();
            Assert.NotEmpty(operations);
            foreach (var operation in operations)
            {
                var method = new HttpMethod(operation.GetProperty("method").GetString()!);
                var path = operation.GetProperty("path").GetString()!;
                Assert.Equal(operation.GetProperty("operationId").GetString(),
                    compatible.Paths[path].Operations![method].OperationId);
            }
        }

        var rootMapping = mappings[0].GetProperty("profiles").GetProperty(profile);
        Assert.False(rootMapping.TryGetProperty("operationIdSource", out _));
        Assert.False(rootMapping.TryGetProperty("removedLegacyOperations", out _));
        var bridges = rootMapping.GetProperty("operations").EnumerateArray().ToArray();
        Assert.Equal(RootTodo.Length, bridges.Length);
        foreach (var expected in RootTodo)
        {
            Assert.Single(bridges, bridge =>
                bridge.GetProperty("method").GetString() == expected.Method
                && bridge.GetProperty("path").GetString() == expected.Path
                && bridge.GetProperty("operationId").GetString() == expected.CurrentId);
        }
        Assert.All(bridges, bridge =>
        {
            Assert.False(bridge.TryGetProperty("legacyPath", out _));
            Assert.False(bridge.TryGetProperty("legacyOperationId", out _));
            Assert.False(bridge.TryGetProperty("legacyPathTranslation", out _));
        });
        Assert.Equal("SupersededBySuppression", mappings[2].GetProperty("implementation").GetString());
        var subsumed = Assert.Single(mappings[2].GetProperty("profiles").GetProperty(profile)
            .GetProperty("operations").EnumerateArray());
        Assert.Equal("/users/{user-id}/todo", subsumed.GetProperty("path").GetString());
        Assert.Equal("user_GetTodo", subsumed.GetProperty("operationId").GetString());
    }

    [Theory]
    [InlineData("v1.0", true)]
    [InlineData("v1.0", false)]
    [InlineData("beta", true)]
    [InlineData("beta", false)]
    public async Task SharedSuppressionsAreExactInBothCompatibleProfiles(string profile, bool useCollisionData)
    {
        var document = await ReadSpec("openApiDocs_KiotaCompat", profile);
        var config = new GeneratorConfig("Test.Client", "unused", useCollisionData);
        foreach (var operation in RootTodo)
            AssertSuppressed(document, config, profile, operation.Method, operation.Path, operation.CurrentId);
        AssertSuppressed(document, config, profile, "POST", "/users/{user-id}/licenseDetails", "user_CreateLicenseDetail");
        AssertSuppressed(document, config, profile, "PATCH", "/users/{user-id}/photo", "user_UpdatePhoto");

        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Post, "/users/{user-id}/todo", config, apiVersion: profile));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Patch, "/users/{user-id}/todo/lists/{todoTaskList-id}", config, apiVersion: profile));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Patch, "/users/{user-id}/photos/{profilePhoto-id}/child", config, apiVersion: profile));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get, "/users/{user-id}/licensedetails/child", config, apiVersion: profile));
    }

    [Theory]
    [InlineData("v1.0", true)]
    [InlineData("v1.0", false)]
    [InlineData("beta", true)]
    [InlineData("beta", false)]
    public async Task UnaffectedNeighborsAndExistingCuratedPhotoBehaviorRemain(string profile, bool useCollisionData)
    {
        var document = await ReadSpec("openApiDocs_KiotaCompat", profile);
        var config = new GeneratorConfig("Test.Client", "unused", useCollisionData);
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
            Assert.False(CmdletConfigurator.IsSuppressed(method, neighbor.Path, config, apiVersion: profile));
            Assert.Equal(neighbor.Noun, Naming.Resolve(new OperationInfo(method, neighbor.Path), config, apiVersion: profile).Noun);
        }

        foreach (var path in new[] { "/users/{user-id}/photos", "/users/{user-id}/photos/{profilePhoto-id}" })
        {
            Assert.True(document.Paths.ContainsKey(path));
            Assert.True(CmdletConfigurator.IsSuppressed(HttpMethod.Get, path, config, apiVersion: profile));
        }
        // Preserve the existing v1.0 derived Outlook suppression without extending a
        // case-sensitive legacy selector to an operation it did not select in beta.
        Assert.Equal(profile == "v1.0" && useCollisionData,
            CmdletConfigurator.IsSuppressed(HttpMethod.Get, "/users/{user-id}/outlook", config, apiVersion: profile));
    }

    [Theory]
    [InlineData("v1.0", "Mg", true)]
    [InlineData("v1.0", "Mg", false)]
    [InlineData("beta", "MgBeta", true)]
    [InlineData("beta", "MgBeta", false)]
    public async Task SponsorItemUsesItsExactPublishedNounWithoutDroppingEitherRoute(string profile, string publishedPrefix,
        bool useCollisionData)
    {
        const string item = "/users/{user-id}/sponsors/{directoryObject-id}/$ref";
        const string root = "/users/{user-id}/sponsors/$ref";
        var document = await ReadSpec("openApiDocs_KiotaCompat", profile);
        var config = new GeneratorConfig("Test.Client", "unused", useCollisionData);
        using var metadata = JsonDocument.Parse(File.ReadAllText(Path.Combine(RepoRoot(),
            "src", "Authentication", "Authentication", "custom", "common", "MgCommandMetadata.json")));
        foreach (var (path, noun) in new[]
        {
            (item, "UserSponsorDirectoryObjectByRef"),
            (root, "UserSponsorByRef"),
        })
        {
            Assert.True(document.Paths[path].Operations!.ContainsKey(HttpMethod.Delete));
            Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Delete, path, config, apiVersion: profile));
            Assert.Equal("Mg" + noun, Naming.Resolve(new OperationInfo(HttpMethod.Delete, path), config, apiVersion: profile).Noun);
            Assert.Single(metadata.RootElement.EnumerateArray(), row =>
                row.GetProperty("ApiVersion").GetString() == profile
                && row.GetProperty("Command").GetString() == "Remove-" + publishedPrefix + noun
                && row.GetProperty("Method").GetString() == "DELETE"
                && row.GetProperty("Uri").GetString() == path);
        }

        var query = Assert.Single(document.Paths[root].Operations![HttpMethod.Delete].Parameters!,
            parameter => parameter.Name == "@id");
        Assert.True(query.Required);
        Assert.Equal(ParameterLocation.Query, query.In);
        Assert.Equal(JsonSchemaType.String, query.Schema!.Type);
    }

    [Fact]
    public async Task BetaPhotoMediaRoutesAreDistinctAndPublishedDefaultIsTheSingleton()
    {
        const string singleton = "/users/{user-id}/photo/$value";
        const string item = "/users/{user-id}/photos/{profilePhoto-id}/$value";
        var document = await ReadSpec("openApiDocs_KiotaCompat", "beta");
        var config = new GeneratorConfig("Test.Client", "unused");
        using var metadata = JsonDocument.Parse(File.ReadAllText(Path.Combine(RepoRoot(),
            "src", "Authentication", "Authentication", "custom", "common", "MgCommandMetadata.json")));
        foreach (var (method, singletonId, itemId, command) in new[]
        {
            (HttpMethod.Get, "user_GetPhotoContent", "user_GetPhotosContent", "Get-MgBetaUserPhotoContent"),
            (HttpMethod.Delete, "user_DeletePhotoContent", "user_DeletePhotosContent", "Remove-MgBetaUserPhotoContent"),
        })
        {
            Assert.Equal(singletonId, document.Paths[singleton].Operations![method].OperationId);
            Assert.Equal(itemId, document.Paths[item].Operations![method].OperationId);
            Assert.False(CmdletConfigurator.IsSuppressed(method, singleton, config, apiVersion: "beta"));
            Assert.False(CmdletConfigurator.IsSuppressed(method, item, config, apiVersion: "beta"));
            Assert.Equal(new[] { "UserId" }, Naming.Resolve(new OperationInfo(method, singleton), config, apiVersion: "beta").PathParamNames);
            Assert.Equal(new[] { "UserId", "ProfilePhotoId" },
                Naming.Resolve(new OperationInfo(method, item), config, apiVersion: "beta").PathParamNames);
            var published = Assert.Single(metadata.RootElement.EnumerateArray(), row =>
                row.GetProperty("ApiVersion").GetString() == "beta"
                && row.GetProperty("Command").GetString() == command);
            Assert.Equal(singleton, published.GetProperty("Uri").GetString());
        }
        foreach (var path in new[] { singleton, item })
        {
            var binary = document.Paths[path].Operations![HttpMethod.Get]
                .Responses!["2XX"].Content!["application/octet-stream"].Schema!;
            Assert.Equal(JsonSchemaType.String, binary.Type);
            Assert.Equal("binary", binary.Format);
            Assert.True(document.Paths[path].Operations![HttpMethod.Delete].Responses!.ContainsKey("204"));
        }
    }

    [Theory]
    [InlineData("v1.0")]
    [InlineData("beta")]
    public async Task GeneratesSharedSuppressionsAndDistinctPublishedSponsorCommands(string profile)
    {
        var output = await GenerateActualProfile(profile);
        var root = output["RemoveMgUserSponsorByRef.g.cs"];
        Assert.Contains("client.Users[UserId].Sponsors.Ref.DeleteAsync", root, StringComparison.Ordinal);
        Assert.DoesNotContain("public string DirectoryObjectId", root, StringComparison.Ordinal);
        Assert.Contains("public string DirectoryObjectId",
            output["RemoveMgUserSponsorDirectoryObjectByRef.g.cs"], StringComparison.Ordinal);
        foreach (var suppressed in new[]
        {
            "GetMgUserTodo.g.cs", "UpdateMgUserTodo.g.cs", "RemoveMgUserTodo.g.cs",
            "NewMgUserLicenseDetail.g.cs", "UpdateMgUserPhoto.g.cs",
        })
            Assert.False(output.ContainsKey(suppressed), $"Suppressed command was generated: {suppressed}");
    }

    [Fact]
    public async Task GeneratesBetaMediaByIdWithoutGroupingOrChangingSingletonUrls()
    {
        var output = await GenerateActualProfile("beta");
        foreach (var command in new[] { "Get", "Remove" })
        {
            var source = output[$"{command}MgUserPhotoContent.g.cs"];
            Assert.Contains("/users/{user-id}/photo/$value", source, StringComparison.Ordinal);
            Assert.DoesNotContain("ProfilePhotoId", source, StringComparison.Ordinal);
            var byId = output[$"{command}MgUserPhotoContentById.g.cs"];
            Assert.Contains("/users/{user-id}/photos/{profilePhoto-id}/$value", byId, StringComparison.Ordinal);
            Assert.Contains("public string ProfilePhotoId", byId, StringComparison.Ordinal);
            Assert.Contains($"client.Users[UserId].Photo.Content.{(command == "Get" ? "Get" : "Delete")}Async",
                source, StringComparison.Ordinal);
            Assert.Contains($"client.Users[UserId].Photos[ProfilePhotoId].Content.{(command == "Get" ? "Get" : "Delete")}Async",
                byId, StringComparison.Ordinal);
        }
        Assert.Contains("OutFile", output["GetMgUserPhotoContent.g.cs"], StringComparison.Ordinal);
        Assert.Contains("IfMatch", output["RemoveMgUserPhotoContent.g.cs"], StringComparison.Ordinal);
        Assert.Contains("SupportsShouldProcess = true", output["RemoveMgUserPhotoContent.g.cs"], StringComparison.Ordinal);
        Assert.Contains("OutFile", output["GetMgUserPhotoContentById.g.cs"], StringComparison.Ordinal);
        Assert.Contains("IfMatch", output["RemoveMgUserPhotoContentById.g.cs"], StringComparison.Ordinal);
        Assert.Contains("SupportsShouldProcess = true", output["RemoveMgUserPhotoContentById.g.cs"], StringComparison.Ordinal);
        Assert.DoesNotContain(output.Keys, name => name.Contains("_Route", StringComparison.Ordinal));
    }

    [Theory]
    [InlineData("v1.0", true)]
    [InlineData("v1.0", false)]
    [InlineData("beta", true)]
    [InlineData("beta", false)]
    public void MediaByIdNamesRemainSharedAndFrozenDerivedOmissionsRemain(string profile, bool useCollisionData)
    {
        var config = new GeneratorConfig("Test.Client", "unused", useCollisionData);
        foreach (var method in new[] { HttpMethod.Get, HttpMethod.Put, HttpMethod.Delete })
        {
            const string item = "/users/{user-id}/photos/{profilePhoto-id}/$value";
            const string singleton = "/users/{user-id}/photo/$value";
            Assert.Equal("MgUserPhotoContentById", Naming.Resolve(new OperationInfo(method, item), config, apiVersion: profile).Noun);
            Assert.Equal("MgUserPhotoContent", Naming.Resolve(new OperationInfo(method, singleton), config, apiVersion: profile).Noun);
            Assert.Equal(profile == "v1.0" && useCollisionData && method != HttpMethod.Put,
                CmdletConfigurator.IsSuppressed(method, item, config, apiVersion: profile));
        }
    }

    private static async Task<Dictionary<string, string>> GenerateActualProfile(string profile)
    {
        var document = await ReadSpec("openApiDocs_KiotaCompat", profile);
        var output = Path.Combine(Path.GetTempPath(), "users-directive-generation", Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(output);
        try
        {
            var config = new GeneratorConfig("Microsoft.Graph.PowerShell.Users.Client", output);
            await new PowerShellWrapperGenerationService(document, config, NullLogger.Instance, apiVersion: profile)
                .GenerateAsync(CancellationToken.None);
            return Directory.GetFiles(output, "*.g.cs").ToDictionary(path => new FileInfo(path).Name, File.ReadAllText);
        }
        finally
        {
            Directory.Delete(output, recursive: true);
        }
    }

    private static void AssertSuppressed(OpenApiDocument document, GeneratorConfig config,
        string profile, string methodName, string path, string operationId)
    {
        var method = new HttpMethod(methodName);
        Assert.Equal(operationId, document.Paths[path].Operations![method].OperationId);
        Assert.True(CmdletConfigurator.IsSuppressed(method, path, config, apiVersion: profile));
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
