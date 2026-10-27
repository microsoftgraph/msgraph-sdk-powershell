using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Reader;
using WrapperGenerator;
using Xunit;

namespace WrapperGenerator.Tests;

public sealed class EducationDirectiveMigrationTests
{
    private sealed record SpecOperation(HttpMethod Method, string Path, string OperationId);

    private static readonly SpecOperation[] OriginalSelection =
    [
        new(HttpMethod.Delete, "/education/classes/{educationClass-id}/assignments/{educationAssignment-id}/categories/$ref",
            "education.class.assignment_DeleteCategoryGraphBPreRef"),
        new(HttpMethod.Delete, "/education/classes/{educationClass-id}/members/$ref",
            "education.class_DeleteMemberGraphBPreRef"),
        new(HttpMethod.Delete, "/education/classes/{educationClass-id}/teachers/$ref",
            "education.class_DeleteTeacherGraphBPreRef"),
        new(HttpMethod.Delete, "/education/me/assignments/{educationAssignment-id}/categories/$ref",
            "education.me.assignment_DeleteCategoryGraphBPreRef"),
        new(HttpMethod.Delete, "/education/schools/{educationSchool-id}/classes/$ref",
            "education.school_DeleteClassGraphBPreRef"),
        new(HttpMethod.Delete, "/education/schools/{educationSchool-id}/users/$ref",
            "education.school_DeleteUserGraphBPreRef"),
        new(HttpMethod.Delete, "/education/users/{educationUser-id}/assignments/{educationAssignment-id}/categories/$ref",
            "education.user.assignment_DeleteCategoryGraphBPreRef"),
    ];

    [Theory]
    [InlineData("v1.0", false)]
    [InlineData("v1.0", true)]
    [InlineData("beta", false)]
    [InlineData("beta", true)]
    public void SuppressesCompleteLegacySelectionWithoutSuppressingReferenceNeighbors(string profile, bool useCollisionData)
    {
        var root = FindRepoRoot();
        var source = File.ReadAllText(Path.Combine(root, "src", "Education", "Education.md"));
        var pattern = Regex.Match(source, @"(?m)^\s*- remove-path-by-operation:\s*(.+)$").Groups[1].Value.Trim();
        Assert.NotEmpty(pattern);
        var selector = new Regex(pattern);
        var legacy = ReadOperations(Path.Combine(root, "openApiDocs", profile, "Education.yml"));
        var compatible = ReadOperations(Path.Combine(root, "openApiDocs_KiotaCompat", profile, "Education.yml"));
        var selected = legacy.Where(operation => selector.IsMatch(operation.OperationId)).ToArray();
        Assert.Equal(OriginalSelection.OrderBy(operation => operation.Path), selected.OrderBy(operation => operation.Path));
        var currentSelection = compatible.Where(operation => selector.IsMatch(operation.OperationId)).ToArray();
        Assert.Equal(selected.Length, currentSelection.Length);

        using var ledger = JsonDocument.Parse(File.ReadAllText(
            Path.Combine(root, "src", "Education", "wrapper", "Education_directiveMigrationMap.json")));
        var mapping = Assert.Single(ledger.RootElement.GetProperty("mappings").EnumerateArray());
        Assert.Contains(mapping.GetProperty("sourceContains").GetString()!, source, StringComparison.Ordinal);
        var profileMap = mapping.GetProperty("profiles").GetProperty(profile);
        Assert.False(profileMap.GetProperty("absenceExpected").GetBoolean());
        var reviewed = profileMap.GetProperty("operations").EnumerateArray().ToArray();
        Assert.Equal(selected.Length, reviewed.Length);
        var covered = new HashSet<SpecOperation>();
        var config = new GeneratorConfig("Test.Client", "unused", profile, useCollisionData);

        foreach (var expected in reviewed)
        {
            var method = new HttpMethod(expected.GetProperty("method").GetString()!);
            var old = Assert.Single(selected, operation =>
                operation.Method == method
                && CmdletConfigurator.NormalizePathTemplate(operation.Path)
                    == CmdletConfigurator.NormalizePathTemplate(expected.GetProperty("path").GetString()!));
            Assert.True(covered.Add(old), $"Duplicate legacy evidence: {old}");
            var counterpart = Assert.Single(compatible, operation =>
                operation.Method == method
                && CmdletConfigurator.NormalizePathTemplate(operation.Path) == CmdletConfigurator.NormalizePathTemplate(old.Path));
            Assert.Equal(expected.GetProperty("path").GetString(), counterpart.Path);
            Assert.Equal(expected.GetProperty("operationId").GetString(), counterpart.OperationId);
            Assert.Equal(old.OperationId, counterpart.OperationId);
            Assert.Contains(counterpart, currentSelection);
            Assert.Equal(HttpMethod.Delete, counterpart.Method);
            Assert.True(CmdletConfigurator.IsSuppressed(method, counterpart.Path, config));
            Assert.True(CmdletConfigurator.IsSuppressed(method,
                Regex.Replace(counterpart.Path, @"\{[^}]*\}", "{renamed-id}") + "/", config));

            foreach (var neighborMethod in new[] { HttpMethod.Get, HttpMethod.Post })
            {
                var neighbor = Assert.Single(compatible, operation =>
                    operation.Method == neighborMethod && operation.Path == counterpart.Path);
                Assert.False(CmdletConfigurator.IsSuppressed(neighbor.Method, neighbor.Path, config));
            }

            var itemPath = counterpart.Path[..^"/$ref".Length] + "/{neighbor-id}/$ref";
            var itemDelete = Assert.Single(compatible, operation =>
                operation.Method == HttpMethod.Delete
                && CmdletConfigurator.NormalizePathTemplate(operation.Path) == CmdletConfigurator.NormalizePathTemplate(itemPath));
            Assert.False(CmdletConfigurator.IsSuppressed(itemDelete.Method, itemDelete.Path, config));
            Assert.False(CmdletConfigurator.IsSuppressed(method, counterpart.Path + "/unrelated", config));
        }

        Assert.Equal(selected.Length, covered.Count);
    }

    [Theory]
    [InlineData("v1.0", false)]
    [InlineData("v1.0", true)]
    [InlineData("beta", false)]
    [InlineData("beta", true)]
    public void PreservesExistingCuratedSuppressionsAndUnrelatedRoutes(string profile, bool useCollisionData)
    {
        var config = new GeneratorConfig("Test.Client", "unused", profile, useCollisionData);
        Assert.True(CmdletConfigurator.IsSuppressed(HttpMethod.Get,
            "/education/classes/{class-id}/assignments/{assignment-id}/categories", config));
        Assert.True(CmdletConfigurator.IsSuppressed(HttpMethod.Get,
            "/education/users/{user-id}/user", config));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Delete,
            "/education/classes/{class-id}", config));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get,
            "/education/users/{user-id}/user/mailboxSettings", config));
        Assert.Equal(profile == "v1.0" && useCollisionData, CmdletConfigurator.IsSuppressed(HttpMethod.Delete,
            "/groups/{group-id}/members/$ref", config));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Delete,
            "/groups/{group-id}/members/{member-id}/$ref", config));
    }

    [Theory]
    [InlineData("v1.0", false)]
    [InlineData("v1.0", true)]
    [InlineData("beta", false)]
    [InlineData("beta", true)]
    public void KeepsPublishedCategoryCountAndDeltaRoutesWithoutNestedNameCollisions(string profile, bool useCollisionData)
    {
        var config = new GeneratorConfig("Test.Client", "unused", profile, useCollisionData);
        var operations = ReadOperations(Path.Combine(FindRepoRoot(), "openApiDocs_KiotaCompat", profile, "Education.yml"));
        using var oracle = JsonDocument.Parse(File.ReadAllText(Path.Combine(
            FindRepoRoot(), "src", "Authentication", "Authentication", "custom", "common", "MgCommandMetadata.json")));
        foreach (var suffix in new[] { "$count", "delta" })
        {
            var nestedPath = $"/education/classes/{{}}/assignments/{{}}/categories/{suffix}";
            var publishedPath = $"/education/classes/{{}}/assignmentcategories/{suffix}";
            var nested = Assert.Single(operations, operation => operation.Method == HttpMethod.Get
                && CmdletConfigurator.NormalizePathTemplate(operation.Path) == nestedPath);
            var published = Assert.Single(operations, operation => operation.Method == HttpMethod.Get
                && CmdletConfigurator.NormalizePathTemplate(operation.Path) == publishedPath);
            var publishedCommands = oracle.RootElement.EnumerateArray().Where(command =>
                command.GetProperty("ApiVersion").GetString() == profile
                && command.GetProperty("Method").GetString() == "GET"
                && command.GetProperty("Uri").GetString() is { } uri
                && CmdletConfigurator.NormalizePathTemplate(uri) == publishedPath).ToArray();
            Assert.Single(publishedCommands);
            Assert.DoesNotContain(oracle.RootElement.EnumerateArray(), command =>
                command.GetProperty("ApiVersion").GetString() == profile
                && command.GetProperty("Method").GetString() == "GET"
                && command.GetProperty("Uri").GetString() is { } uri
                && CmdletConfigurator.NormalizePathTemplate(uri) == nestedPath);
            Assert.True(CmdletConfigurator.IsSuppressed(nested.Method, nested.Path, config));
            Assert.False(CmdletConfigurator.IsSuppressed(published.Method, published.Path, config));
            Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Post, nested.Path, config));
            Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get,
                $"/education/me/assignments/{{assignment-id}}/categories/{suffix}", config));
            Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get,
                $"/education/users/{{user-id}}/assignments/{{assignment-id}}/categories/{suffix}", config));
        }
    }

    private static SpecOperation[] ReadOperations(string path)
    {
        var settings = new OpenApiReaderSettings();
        settings.AddYamlReader();
        using var stream = File.OpenRead(path);
        var result = OpenApiDocument.LoadAsync(stream, settings: settings, cancellationToken: CancellationToken.None)
            .GetAwaiter().GetResult();
        var document = result.Document ?? throw new InvalidOperationException($"Could not parse '{path}'.");
        return document.Paths.SelectMany(route => route.Value.Operations!
            .Select(operation => new SpecOperation(operation.Key, route.Key, operation.Value.OperationId!))).ToArray();
    }

    private static string FindRepoRoot()
    {
        var directory = AppContext.BaseDirectory;
        while (directory is not null && !File.Exists(Path.Combine(directory, "src", "Education", "Education.md")))
            directory = Path.GetDirectoryName(directory);
        return directory ?? throw new InvalidOperationException("Repo root not found from test base directory.");
    }
}
