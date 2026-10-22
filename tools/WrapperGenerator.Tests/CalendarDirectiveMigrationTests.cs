using System;
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

public sealed class CalendarDirectiveMigrationTests
{
    private static readonly string RepoRoot = FindRepoRoot();
    private static readonly Lazy<OpenApiDocument> V1 = new(() => ReadSpec("v1.0"));
    private static readonly Lazy<OpenApiDocument> Beta = new(() => ReadSpec("beta"));
    private const string SharingPath = "/users/{user-id}/calendar/allowedCalendarSharingRoles(User='{User}')";

    [Theory]
    [InlineData("v1.0")]
    [InlineData("beta")]
    public void ReviewedLedgerMatchesEveryExactOperationAndOriginalSelector(string profile)
    {
        var spec = Spec(profile);
        using var ledger = ReadLedger();
        var source = File.ReadAllText(Path.Combine(RepoRoot, "src", "Calendar", "Calendar.md"));
        var directives = ledger.RootElement.GetProperty("mappings").EnumerateArray().ToArray();
        Assert.Equal(6, directives.Length);
        Assert.Equal(Enumerable.Range(1, 6), directives.Select(d => d.GetProperty("directiveIndex").GetInt32()));
        foreach (var directive in directives)
        {
            Assert.Contains(directive.GetProperty("sourceContains").GetString()!, source);
            var map = directive.GetProperty("profiles").GetProperty(profile);
            Assert.False(map.GetProperty("absenceExpected").GetBoolean());
            foreach (var operation in map.GetProperty("operations").EnumerateArray())
            {
                var method = new HttpMethod(operation.GetProperty("method").GetString()!);
                var path = operation.GetProperty("path").GetString()!;
                Assert.True(spec.Paths.TryGetValue(path, out var item), $"Missing {profile} {method} {path}");
                Assert.NotNull(item!.Operations);
                Assert.True(item.Operations.TryGetValue(method, out var actual), $"Missing {profile} {method} {path}");
                Assert.Equal(operation.GetProperty("operationId").GetString(), actual!.OperationId);
            }
        }

        var pattern = Regex.Match(source, @"(?m)^\s*- remove-path-by-operation: (.+)\r?$").Groups[1].Value.Trim();
        var regex = new Regex(pattern);
        var matched = spec.Paths.SelectMany(p => p.Value.Operations!
            .Where(o => regex.IsMatch(o.Value.OperationId!))
            .Select(o => $"{o.Key.Method.ToUpperInvariant()} {p.Key} [{o.Value.OperationId}]"))
            .OrderBy(x => x, StringComparer.Ordinal).ToArray();
        var reviewed = directives[0].GetProperty("profiles").GetProperty(profile).GetProperty("operations")
            .EnumerateArray().Select(o =>
                $"{o.GetProperty("method").GetString()} {o.GetProperty("path").GetString()} [{o.GetProperty("operationId").GetString()}]")
            .OrderBy(x => x, StringComparer.Ordinal).ToArray();
        Assert.Equal(26, matched.Length);
        Assert.Equal(matched, reviewed);
    }

    [Theory]
    [InlineData("v1.0", false)]
    [InlineData("v1.0", true)]
    [InlineData("beta", false)]
    [InlineData("beta", true)]
    public void ReviewedSuppressionsWorkWithAndWithoutDerivedData(string profile, bool useCollisionData)
    {
        var config = new GeneratorConfig("Test.Client", "", profile, useCollisionData);
        using var ledger = ReadLedger();
        foreach (var directive in ledger.RootElement.GetProperty("mappings").EnumerateArray()
                     .Where(d => d.GetProperty("directiveIndex").GetInt32() is 1 or 5 or 6))
        {
            foreach (var operation in directive.GetProperty("profiles").GetProperty(profile).GetProperty("operations").EnumerateArray())
            {
                var method = new HttpMethod(operation.GetProperty("method").GetString()!);
                var path = operation.GetProperty("path").GetString()!;
                Assert.True(CmdletConfigurator.IsSuppressed(method, path, config), $"{profile} {method} {path}");
            }
        }
        Assert.True(CmdletConfigurator.IsSuppressed(HttpMethod.Post, "/users/{user-id}/calendar/events/{event-id}/cancel", config));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get, "/users/{user-id}/calendar", config));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get, "/users/{user-id}/events/delta()", config));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Post, "/users/{user-id}/events/{event-id}/cancel", config));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Post, "/groups/{group-id}/calendar/getSchedule", config));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get, "/groups/{group-id}/calendar/events/{event-id}", config));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Post, "/groups/{group-id}/calendar/events", config));
    }

    [Theory]
    [InlineData("v1.0", false)]
    [InlineData("v1.0", true)]
    [InlineData("beta", false)]
    [InlineData("beta", true)]
    public void RenamesStayExactAndStructuralNeighborsNeedNoOverrides(string profile, bool useCollisionData)
    {
        var config = new GeneratorConfig("Test.Client", "", profile, useCollisionData);
        Assert.Equal("MgUserDefaultCalendar", Resolve(HttpMethod.Get, "/users/{user-id}/calendar", config).Noun);
        Assert.Equal("MgUserDefaultCalendarEvent", Resolve(HttpMethod.Get, "/users/{user-id}/calendar/events", config).Noun);
        Assert.Equal("MgUserDefaultCalendarEvent", Resolve(HttpMethod.Post, "/users/{user-id}/calendar/events", config).Noun);
        Assert.Equal("MgUserCalendar", Resolve(HttpMethod.Get, "/users/{user-id}/calendars", config).Noun);
        Assert.Equal("MgUserCalendar", Resolve(HttpMethod.Get, "/users/{user-id}/calendars/{calendar-id}", config).Noun);
        Assert.Equal("MgGroupCalendarEvent", Resolve(HttpMethod.Get, "/groups/{group-id}/calendar/events/{event-id}", config).Noun);
        Assert.Equal("MgUserEvent", Resolve(HttpMethod.Get, "/users/{user-id}/events/{event-id}", config).Noun);

        var sharing = Resolve(HttpMethod.Get, SharingPath, config, OperationKind.Function);
        Assert.Equal("MgCalendarUserCalendarAllowedCalendarSharingRoles", sharing.Noun);
        Assert.Equal("Invoke", sharing.VerbName);
        Assert.Equal("InvokeMgCalendarUserCalendarAllowedCalendarSharingRolesCommand", sharing.ClassName);
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get, SharingPath, config));
    }

    [Fact]
    public void SharingRoleRenameAlsoWorksWithoutAnyGeneratorConfiguration()
    {
        var naming = Naming.Resolve(new OperationInfo(HttpMethod.Get, SharingPath, Kind: OperationKind.Function));
        Assert.Equal("Invoke", naming.VerbName);
        Assert.Equal("MgCalendarUserCalendarAllowedCalendarSharingRoles", naming.Noun);
        Assert.Equal("InvokeMgCalendarUserCalendarAllowedCalendarSharingRolesCommand", naming.ClassName);
        Assert.Null(CmdletConfigurator.TryGetOverriddenVerb(HttpMethod.Post, SharingPath, null));
        Assert.Null(CmdletConfigurator.TryGetOverriddenVerb(HttpMethod.Get,
            "/users/{user-id}/events/{event-id}/calendar/allowedCalendarSharingRoles(User='{User}')", null));
    }

    [Theory]
    [InlineData("v1.0")]
    [InlineData("beta")]
    public void AbsentLegacyBranchesAreNotFabricatedOrBroadened(string profile)
    {
        var spec = Spec(profile);
        Assert.DoesNotContain(spec.Paths.Keys, p =>
            p.StartsWith("/users/{user-id}/events/{event-id}/calendar/", StringComparison.Ordinal)
            && p.Contains("allowedCalendarSharingRoles", StringComparison.Ordinal));
        var ids = spec.Paths.SelectMany(p => p.Value.Operations!.Values).Select(o => o.OperationId!).ToArray();
        Assert.DoesNotContain(ids, id => Regex.IsMatch(id,
            @"(user|group)_(Update|Delete)Calendar$|user\.calendarGroup_(Get|Update|Delete)Calendar$|user\.calendarGroup\.calendar.*$|placeAsRoomList\.(room|workspace)_(Get|Update|Delete)GraphBPrePlaceId$"));
        Assert.Equal("users.UpdateCalendar", spec.Paths["/users/{user-id}/calendar"].Operations![HttpMethod.Patch].OperationId);
        Assert.Equal("users.calendar.GetEvents", spec.Paths["/users/{user-id}/calendar/events/{event-id}"].Operations![HttpMethod.Get].OperationId);
        Assert.True(CmdletConfigurator.IsSuppressed(HttpMethod.Patch, "/users/{user-id}/calendar"));
    }

    [Theory]
    [InlineData("v1.0")]
    [InlineData("beta")]
    public void ExistingCollisionSuppressionsHaveExactSpecAndBothProfileOracleEvidence(string profile)
    {
        using var ledger = ReadLedger();
        var reconciliation = ledger.RootElement.GetProperty("collisionReconciliation");
        using var derived = JsonDocument.Parse(File.ReadAllText(Path.Combine(RepoRoot,
            reconciliation.GetProperty("source").GetString()!.Replace('/', Path.DirectorySeparatorChar))));
        using var oracle = JsonDocument.Parse(File.ReadAllText(Path.Combine(RepoRoot,
            "src", "Authentication", "Authentication", "custom", "common", "MgCommandMetadata.json")));
        var operations = reconciliation.GetProperty("profiles").GetProperty(profile).GetProperty("operations").EnumerateArray().ToArray();
        Assert.Equal(6, operations.Length);
        foreach (var operation in operations)
        {
            var method = new HttpMethod(operation.GetProperty("method").GetString()!);
            var path = operation.GetProperty("path").GetString()!;
            var normalized = CmdletConfigurator.NormalizePathTemplate(path);
            Assert.Equal(operation.GetProperty("operationId").GetString(), Spec(profile).Paths[path].Operations![method].OperationId);
            Assert.Contains(derived.RootElement.EnumerateArray(), d =>
                d.GetProperty("method").GetString() == method.Method
                && d.GetProperty("uri").GetString() == normalized
                && d.GetProperty("action").GetString() == "suppress");
            Assert.DoesNotContain(oracle.RootElement.EnumerateArray(), row =>
                row.GetProperty("ApiVersion").GetString() == profile
                && row.GetProperty("Method").GetString() == method.Method
                && row.GetProperty("Uri").GetString() is { } uri
                && CmdletConfigurator.NormalizePathTemplate(uri) == normalized);
            Assert.True(CmdletConfigurator.IsSuppressed(method, path, new GeneratorConfig("Test.Client", "", profile)));
            Assert.True(CmdletConfigurator.IsSuppressed(method, path));
        }
        foreach (var path in new[] { "/groups/{group-id}/calendar/calendarView", "/users/{user-id}/calendar/calendarView" })
        {
            Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get, path, new GeneratorConfig("Test.Client", "", profile)));
            Assert.Contains(oracle.RootElement.EnumerateArray(), row =>
                row.GetProperty("ApiVersion").GetString() == profile
                && row.GetProperty("Method").GetString() == "GET"
                && row.GetProperty("Uri").GetString() == path);
        }
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Post, "/users/{user-id}/calendar/permanentDelete",
            new GeneratorConfig("Test.Client", "", profile)));
    }

    [Theory]
    [InlineData("v1.0")]
    [InlineData("beta")]
    public async Task TargetedGenerationUsesRealProfileOperationsAndPreservesNeighbors(string profile)
    {
        var source = Spec(profile);
        var subset = new OpenApiDocument
        {
            Info = source.Info,
            Components = source.Components,
            Paths = new OpenApiPaths(),
        };
        string[] paths =
        [
            "/users/{user-id}/calendar",
            "/users/{user-id}/calendar/events",
            "/users/{user-id}/calendar/events/{event-id}/cancel",
            "/users/{user-id}/calendar/events/delta()",
            "/users/{user-id}/calendars/{calendar-id}/events/delta()",
            "/users/{user-id}/calendar/getSchedule",
            "/users/{user-id}/calendars/{calendar-id}/getSchedule",
            "/users/{user-id}/events/delta()",
            "/users/{user-id}/events/{event-id}/cancel",
            "/groups/{group-id}/calendar/events/{event-id}",
            "/groups/{group-id}/calendar/events/{event-id}/cancel",
            "/groups/{group-id}/calendarView",
            "/groups/{group-id}/calendar/calendarView",
            "/users/{user-id}/calendarView",
            "/users/{user-id}/calendar/calendarView",
            "/users/{user-id}/calendars/{calendar-id}/calendarView",
            "/users/{user-id}/calendar/events/$count",
            "/users/{user-id}/calendars/{calendar-id}/events/$count",
            "/users/{user-id}/calendars/{calendar-id}/permanentDelete",
            "/users/{user-id}/calendar/permanentDelete",
            SharingPath,
        ];
        foreach (var path in paths)
            subset.Paths.Add(path, source.Paths[path]);

        var output = Path.Combine(Path.GetTempPath(), "calendar-directive-tests", Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(output);
        try
        {
            var config = new GeneratorConfig("Test.Client", output, profile);
            await new PowerShellWrapperGenerationService(subset, config, NullLogger.Instance)
                .GenerateAsync(CancellationToken.None);
            var files = Directory.GetFiles(output, "*.g.cs").Select(Path.GetFileName).ToArray();
            Assert.Contains("GetMgUserDefaultCalendar.g.cs", files);
            Assert.Contains("GetMgUserDefaultCalendarEvent.g.cs", files);
            Assert.Contains("NewMgUserDefaultCalendarEvent.g.cs", files);
            Assert.Contains("GetMgUserEventDelta.g.cs", files);
            Assert.Contains(profile == "v1.0" ? "StopMgUserEvent.g.cs" : "InvokeMgUserEventCancel.g.cs", files);
            Assert.Contains("GetMgGroupCalendarEvent.g.cs", files);
            Assert.Contains("GetMgGroupCalendarView.g.cs", files);
            Assert.Contains("GetMgUserCalendarView.g.cs", files);
            Assert.Contains(profile == "v1.0" ? "RemoveMgUserCalendarPermanent.g.cs" : "InvokeMgUserCalendarPermanentDelete.g.cs", files);
            Assert.DoesNotContain("GetMgUserCalendarEventCount.g.cs", files);
            Assert.DoesNotContain(files, f => f!.Contains("CalendarEventDelta", StringComparison.Ordinal));
            Assert.DoesNotContain(files, f => f!.Contains("CalendarGetSchedule", StringComparison.Ordinal));
            Assert.DoesNotContain(files, f => f!.Contains("CalendarEventCancel", StringComparison.Ordinal));
            Assert.Contains("InvokeMgCalendarUserCalendarAllowedCalendarSharingRoles.g.cs", files);
        }
        finally
        {
            Directory.Delete(output, recursive: true);
        }
    }

    private static CmdletNaming Resolve(HttpMethod method, string path, GeneratorConfig config,
        OperationKind kind = OperationKind.Resource) =>
        Naming.Resolve(new OperationInfo(method, path, Kind: kind), config);

    private static OpenApiDocument Spec(string profile) => profile == "v1.0" ? V1.Value : Beta.Value;

    private static OpenApiDocument ReadSpec(string profile)
    {
        var settings = new OpenApiReaderSettings();
        settings.AddYamlReader();
        using var stream = File.OpenRead(Path.Combine(RepoRoot, "openApiDocs_KiotaCompat", profile, "Calendar.yml"));
        var result = OpenApiDocument.LoadAsync(stream, settings: settings, cancellationToken: CancellationToken.None)
            .GetAwaiter().GetResult();
        Assert.NotNull(result.Document);
        return result.Document;
    }

    private static JsonDocument ReadLedger() =>
        JsonDocument.Parse(File.ReadAllText(Path.Combine(RepoRoot, "src", "Calendar", "wrapper", "Calendar_directiveMigrationMap.json")));

    private static string FindRepoRoot()
    {
        var directory = AppContext.BaseDirectory;
        while (directory is not null && !Directory.Exists(Path.Combine(directory, "openApiDocs_KiotaCompat")))
            directory = Path.GetDirectoryName(directory);
        return directory ?? throw new InvalidOperationException("Repository root not found.");
    }
}
