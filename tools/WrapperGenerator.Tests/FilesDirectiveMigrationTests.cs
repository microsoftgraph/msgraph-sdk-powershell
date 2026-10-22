using System;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using WrapperGenerator;
using Xunit;

namespace WrapperGenerator.Tests;

public sealed class FilesDirectiveMigrationTests
{
    [Theory]
    [InlineData("v1.0", true, 10, 46)]
    [InlineData("v1.0", false, 10, 46)]
    [InlineData("beta", true, 56, 216)]
    [InlineData("beta", false, 56, 216)]
    public void EverySurvivingLegacySelectionIsSuppressed(
        string profile, bool useCollisionData, int survivingCount, int removedCount)
    {
        using var ledger = ReadLedger();
        var mapping = ledger.RootElement.GetProperty("mappings")[0].GetProperty("profiles").GetProperty(profile);
        Assert.Equal("Legacy", mapping.GetProperty("operationIdSource").GetString());
        Assert.False(mapping.GetProperty("absenceExpected").GetBoolean());
        Assert.Equal(survivingCount, mapping.GetProperty("operations").GetArrayLength());
        Assert.Equal(removedCount, mapping.GetProperty("removedLegacyOperations").GetArrayLength());
        var config = new GeneratorConfig("Test.Client", "unused", profile, useCollisionData);

        foreach (var operation in mapping.GetProperty("operations").EnumerateArray())
        {
            var method = new HttpMethod(operation.GetProperty("method").GetString()!);
            var path = operation.GetProperty("path").GetString()!;
            Assert.True(CmdletConfigurator.IsSuppressed(method, path, config), $"{profile}: {method} {path}");
        }
    }

    [Theory]
    [InlineData("v1.0", true)]
    [InlineData("v1.0", false)]
    [InlineData("beta", true)]
    [InlineData("beta", false)]
    public void ExistingDefaultDriveRenamesRemainGetOnly(string profile, bool useCollisionData)
    {
        var config = new GeneratorConfig("Test.Client", "unused", profile, useCollisionData);
        foreach (var (path, noun) in new[]
        {
            ("/groups/{group-id}/drive", "GroupDefaultDrive"),
            ("/users/{user-id}/drive", "UserDefaultDrive"),
            ("/sites/{site-id}/drive", "SiteDefaultDrive"),
            ("/groups/{group-id}/sites/{site-id}/drive", "GroupSiteDefaultDrive"),
        })
        {
            var naming = Naming.Resolve(new OperationInfo(HttpMethod.Get, path), config);
            Assert.Equal("Get", naming.VerbName);
            Assert.Equal($"Mg{noun}", naming.Noun);
            Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get, path, config));
            Assert.Equal("Unchanged", CmdletConfigurator.ApplyNounOverrides(HttpMethod.Patch, path, "Unchanged", config));
        }

        Assert.Equal("MgGroupDrive", Naming.Resolve(new OperationInfo(HttpMethod.Get, "/groups/{group-id}/drives"), config).Noun);
        Assert.Equal("MgUserDrive", Naming.Resolve(new OperationInfo(HttpMethod.Get, "/users/{user-id}/drives"), config).Noun);
    }

    [Theory]
    [InlineData("v1.0", true)]
    [InlineData("v1.0", false)]
    [InlineData("beta", true)]
    [InlineData("beta", false)]
    public void CollectionListsAndUnselectedNeighborsRemainAvailable(string profile, bool useCollisionData)
    {
        var config = new GeneratorConfig("Test.Client", "unused", profile, useCollisionData);
        string[] paths =
        [
            "/drives/{drive-id}/items/{driveItem-id}/analytics/itemActivityStats/{itemActivityStat-id}/activities",
            "/drives/{drive-id}/items/{driveItem-id}/analytics/itemActivityStats/{itemActivityStat-id}",
            "/drives/{drive-id}/items/{driveItem-id}/children",
            "/drives/{drive-id}/items/{driveItem-id}/permissions",
            "/shares/{sharedDriveItem-id}/list/items/{listItem-id}/driveItem",
            "/shares/{sharedDriveItem-id}/list/items/{listItem-id}/fields",
        ];
        foreach (var path in paths)
            Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get, path, config), $"{profile}: GET {path}");

        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Post, "/drives/{drive-id}/items/{driveItem-id}/createLink", config));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Post, "/shares/{sharedDriveItem-id}/driveItem/createLink", config));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get, "/shares/{sharedDriveItem-id}/list/items/{listItem-id}/createLink", config));
        Assert.True(CmdletConfigurator.IsSuppressed(HttpMethod.Get, "/shares/{sharedDriveItem-id}/list/items/{listItem-id}", config));

        if (profile == "beta")
        {
            foreach (var path in new[]
            {
                "/drives/{drive-id}/activities",
                "/drives/{drive-id}/items/{driveItem-id}/activities",
                "/drives/{drive-id}/list/activities",
                "/drives/{drive-id}/list/items/{listItem-id}/activities",
                "/shares/{sharedDriveItem-id}/list/activities",
                "/shares/{sharedDriveItem-id}/list/items/{listItem-id}/activities",
            })
                Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get, path, config), $"beta: GET {path}");
        }
    }

    private static JsonDocument ReadLedger()
    {
        var directory = AppContext.BaseDirectory;
        while (directory is not null)
        {
            var path = Path.Combine(directory, "src", "Files", "wrapper", "Files_directiveMigrationMap.json");
            if (File.Exists(path))
                return JsonDocument.Parse(File.ReadAllText(path));
            directory = Path.GetDirectoryName(directory);
        }
        throw new InvalidOperationException("Files directive migration ledger not found from test base directory.");
    }
}
