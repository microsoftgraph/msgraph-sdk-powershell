using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Reader;
using WrapperGenerator;
using Xunit;

namespace WrapperGenerator.Tests;

public sealed class CloudCommunicationsDirectiveMigrationTests
{
    private const string CreateOrGet = "/communications/onlineMeetings/createOrGet";
    private const string UserCreateOrGet = "/users/{user-id}/onlineMeetings/createOrGet";
    private const string MuteAll = "/communications/calls/{call-id}/participants/muteAll";
    private const string Recording = "/users/{user-id}/onlineMeetings/getAllRecordings(meetingOrganizerUserId='@meetingOrganizerUserId',startDateTime=@startDateTime,endDateTime=@endDateTime)";
    private const string Transcript = "/users/{user-id}/onlineMeetings/getAllTranscripts(meetingOrganizerUserId='@meetingOrganizerUserId',startDateTime=@startDateTime,endDateTime=@endDateTime)";

    private static readonly (HttpMethod Method, string Path, string Id)[] LegacySuppressions =
    [
        (HttpMethod.Get, "/communications", "communication.cloudCommunication_GetCloudCommunication"),
        (HttpMethod.Patch, "/communications", "communication.cloudCommunication_UpdateCloudCommunication"),
        (HttpMethod.Get, "/communications/callRecords", "communication_ListCallRecord"),
        (HttpMethod.Post, "/communications/callRecords", "communication_CreateCallRecord"),
        (HttpMethod.Patch, "/communications/callRecords/{callRecord-id}", "communication_UpdateCallRecord"),
        (HttpMethod.Delete, "/communications/callRecords/{callRecord-id}", "communication_DeleteCallRecord"),
        (HttpMethod.Get, "/communications/callRecords/{callRecord-id}/sessions/{session-id}/segments", "communication.callRecord.session_ListSegment"),
        (HttpMethod.Post, "/communications/callRecords/{callRecord-id}/sessions/{session-id}/segments", "communication.callRecord.session_CreateSegment"),
        (HttpMethod.Get, "/communications/callRecords/{callRecord-id}/sessions/{session-id}/segments/{segment-id}", "communication.callRecord.session_GetSegment"),
        (HttpMethod.Patch, "/communications/callRecords/{callRecord-id}/sessions/{session-id}/segments/{segment-id}", "communication.callRecord.session_UpdateSegment"),
        (HttpMethod.Delete, "/communications/callRecords/{callRecord-id}/sessions/{session-id}/segments/{segment-id}", "communication.callRecord.session_DeleteSegment"),
        (HttpMethod.Get, "/communications/calls", "communication_ListCall"),
        (HttpMethod.Patch, "/communications/calls/{call-id}", "communication_UpdateCall"),
    ];

    [Theory]
    [InlineData("v1.0")]
    [InlineData("beta")]
    public async Task OriginalLegacySelectorMatchesExactlyTheReviewedSuppressionSet(string profile)
    {
        var legacy = await LoadSpec(profile, "openApiDocs");
        var compatible = await LoadSpec(profile);
        var selector = new Regex("^communication(.cloudCommunication_.*CloudCommunication|_(List|Create|Update|Delete)CallRecord|.callRecord.session_.*Segment|(_List|_Update)Call)$");
        var matches = legacy.Paths
            .SelectMany(path => path.Value.Operations!
                .Where(operation => selector.IsMatch(operation.Value.OperationId!))
                .Select(operation => (Method: operation.Key, Path: path.Key)))
            .ToArray();

        Assert.Equal(13, matches.Length);
        Assert.Equal(
            LegacySuppressions.Select(operation => $"{operation.Method} {CmdletConfigurator.NormalizePathTemplate(operation.Path)}").Order(),
            matches.Select(operation => $"{operation.Method} {CmdletConfigurator.NormalizePathTemplate(operation.Path)}").Order());
        var currentMatches = compatible.Paths.SelectMany(path => path.Value.Operations!
            .Where(operation => selector.IsMatch(operation.Value.OperationId!))
            .Select(operation => $"{operation.Key} {path.Key} [{operation.Value.OperationId}]")).Order();
        Assert.Equal(matches.Select(operation =>
            $"{operation.Method} {operation.Path} [{legacy.Paths[operation.Path].Operations![operation.Method].OperationId}]").Order(), currentMatches);
        foreach (var (method, path) in matches)
        {
            var current = Assert.Single(compatible.Paths, candidate =>
                CmdletConfigurator.NormalizePathTemplate(candidate.Key) == CmdletConfigurator.NormalizePathTemplate(path)
                && candidate.Value.Operations!.ContainsKey(method));
            var reviewed = Assert.Single(LegacySuppressions, operation =>
                operation.Method == method && operation.Path == current.Key);
            Assert.Equal(reviewed.Id, current.Value.Operations![method].OperationId);
        }
    }

    [Theory]
    [InlineData("v1.0", false)]
    [InlineData("v1.0", true)]
    [InlineData("beta", false)]
    [InlineData("beta", true)]
    public async Task GenerationPreservesDistinctLatestReportAndLiveEventSurfaces(string profile, bool useCollisionData)
    {
        var document = await LoadSpec(profile);
        if (!useCollisionData)
        {
            foreach (var path in document.Paths.Keys.Where(path =>
                !Regex.IsMatch(path, @"^/(communications|users/\{user-id\})/onlineMeetings/\{onlineMeeting-id\}/(meetingAttendanceReport|attendanceReports|recording|recordings)(/|$)")).ToArray())
                document.Paths.Remove(path);
        }
        var output = Path.Combine(Path.GetTempPath(), "cloudcommunications-complete-source", Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(output);
        try
        {
            var config = new GeneratorConfig("Test.Client", output, useCollisionData);
            await new PowerShellWrapperGenerationService(document, config, NullLogger.Instance, apiVersion: profile)
                .GenerateAsync(CancellationToken.None);
            var files = Directory.GetFiles(output, "*.g.cs").ToDictionary(path => Path.GetFileName(path)!, File.ReadAllText);
            foreach (var (parent, scope) in new[]
            {
                ("/communications/onlineMeetings/{onlineMeeting-id}", "Communication"),
                ("/users/{user-id}/onlineMeetings/{onlineMeeting-id}", "User"),
            })
            {
                var latest = parent + "/meetingAttendanceReport";
                if (!document.Paths.ContainsKey(latest))
                {
                    Assert.DoesNotContain(files.Keys, file => file.Contains(scope + "OnlineMeetingLatestAttendanceReport", StringComparison.Ordinal));
                    continue;
                }
                Assert.Contains("latest online meeting session", document.Paths[latest].Operations![HttpMethod.Get].Description!, StringComparison.Ordinal);
                foreach (var (method, child, noun) in new[]
                {
                    ("GET", "", "LatestAttendanceReport"),
                    ("PATCH", "", "LatestAttendanceReport"),
                    ("DELETE", "", "LatestAttendanceReport"),
                    ("GET", "/attendanceRecords", "LatestAttendanceReportAttendanceRecord"),
                    ("POST", "/attendanceRecords", "LatestAttendanceReportAttendanceRecord"),
                    ("GET", "/attendanceRecords/{attendanceRecord-id}", "LatestAttendanceReportAttendanceRecord"),
                    ("PATCH", "/attendanceRecords/{attendanceRecord-id}", "LatestAttendanceReportAttendanceRecord"),
                    ("DELETE", "/attendanceRecords/{attendanceRecord-id}", "LatestAttendanceReportAttendanceRecord"),
                    ("GET", "/attendanceRecords/$count", "LatestAttendanceReportAttendanceRecordCount"),
                })
                {
                    var naming = Naming.Resolve(new OperationInfo(new HttpMethod(method), latest + child), config, apiVersion: profile);
                    Assert.Equal("Mg" + scope + "OnlineMeeting" + noun, naming.Noun);
                    Assert.Contains(files.Values, source => source.Contains($"[GraphRoute(\"{method}\", \"{latest + child}\")]", StringComparison.Ordinal));
                }
                var records = files["GetMg" + scope + "OnlineMeetingLatestAttendanceReportAttendanceRecord.g.cs"];
                Assert.Contains("DefaultParameterSetName = \"List\"", records, StringComparison.Ordinal);
                Assert.DoesNotContain("public string Route", records, StringComparison.Ordinal);
                var plural = files["GetMg" + scope + "OnlineMeetingAttendanceReport.g.cs"];
                Assert.Contains("DefaultParameterSetName = \"List\"", plural, StringComparison.Ordinal);
                Assert.DoesNotContain("LatestAttendanceReport", plural, StringComparison.Ordinal);
                var binary = files["GetMg" + scope + "OnlineMeetingLiveEventRecording.g.cs"];
                Assert.Contains("OutFile", binary, StringComparison.Ordinal);
                Assert.Contains("[OutputType(typeof(byte[]))]", binary, StringComparison.Ordinal);
                var json = files["GetMg" + scope + "OnlineMeetingRecording.g.cs"];
                Assert.Contains("DefaultParameterSetName = \"List\"", json, StringComparison.Ordinal);
                Assert.DoesNotContain("OutFile", json, StringComparison.Ordinal);
                Assert.Contains(files.Values, source => source.Contains($"[GraphRoute(\"GET\", \"{parent}/recordings/{{callRecording-id}}/content\")]", StringComparison.Ordinal));
                Assert.DoesNotContain(files.Values, source => source.Contains("public string Route", StringComparison.Ordinal));
            }
        }
        finally
        {
            Directory.Delete(output, recursive: true);
        }
    }

    [Theory]
    [InlineData("/communications/onlineMeetings/{onlineMeeting-id}")]
    [InlineData("/users/{user-id}/onlineMeetings/{onlineMeeting-id}")]
    public async Task BetaRecordingRoutesHaveDistinctBinaryAndTypedJsonContracts(string parent)
    {
        var document = await LoadSpec("beta");
        var binary = document.Paths[parent + "/recording"].Operations![HttpMethod.Get];
        var list = document.Paths[parent + "/recordings"].Operations![HttpMethod.Get];
        var item = document.Paths[parent + "/recordings/{callRecording-id}"].Operations![HttpMethod.Get];
        var binaryResponse = Assert.Single(binary.Responses!, response => response.Key.StartsWith('2')).Value;
        var binaryContent = Assert.Single(binaryResponse.Content!);
        Assert.Equal("application/octet-stream", binaryContent.Key);
        Assert.Equal(JsonSchemaType.String, binaryContent.Value.Schema!.Type);
        Assert.Equal("binary", binaryContent.Value.Schema.Format);
        Assert.Null(binary.RequestBody);
        Assert.Empty(binary.Parameters ?? []);

        foreach (var operation in new[] { list, item })
        {
            Assert.Null(operation.RequestBody);
            Assert.DoesNotContain(operation.Parameters ?? [], parameter =>
                parameter.In != ParameterLocation.Path && parameter.Required);
        }
        var listResponse = Assert.Single(list.Responses!, response => response.Key.StartsWith('2')).Value;
        var itemResponse = Assert.Single(item.Responses!, response => response.Key.StartsWith('2')).Value;
        Assert.Equal("microsoft.graph.callRecordingCollectionResponse",
            listResponse.Content!["application/json"].Schema!.GetReferenceId());
        Assert.Equal("microsoft.graph.callRecording",
            itemResponse.Content!["application/json"].Schema!.GetReferenceId());
        Assert.Equal(
            new[] { "$count", "$expand", "$filter", "$orderby", "$search", "$select", "$skip", "$top" },
            list.Parameters!.Where(parameter => parameter.In == ParameterLocation.Query).Select(parameter => parameter.Name).Order());
        Assert.Equal(
            new[] { "$expand", "$select" },
            item.Parameters!.Where(parameter => parameter.In == ParameterLocation.Query).Select(parameter => parameter.Name).Order());

        foreach (var suffix in new[] { "/recording", "/recordings/{callRecording-id}" })
        {
            var remove = document.Paths[parent + suffix].Operations![HttpMethod.Delete];
            Assert.Null(remove.RequestBody);
            Assert.True(remove.Responses!.ContainsKey("204"));
            var header = Assert.Single(remove.Parameters!, parameter => parameter.In == ParameterLocation.Header);
            Assert.Equal("If-Match", header.Name);
            Assert.False(header.Required);
            Assert.Equal(JsonSchemaType.String, header.Schema!.Type);
        }
    }

    [Theory]
    [InlineData("/communications/onlineMeetings/{onlineMeeting-id}", "communication.onlineMeeting")]
    [InlineData("/users/{user-id}/onlineMeetings/{onlineMeeting-id}", "user.onlineMeeting")]
    public async Task BetaAttendanceAliasesPreserveExactSameShapeOperationContracts(string parent, string idPrefix)
    {
        var document = await LoadSpec("beta");
        const string plural = "/attendanceReports/{meetingAttendanceReport-id}";
        const string singleton = "/meetingAttendanceReport";
        (HttpMethod Method, string Child, string PluralId, string SingletonId, string? Body)[] pairs =
        [
            (HttpMethod.Patch, "", "UpdateAttendanceReport", "UpdateMeetingAttendanceReport", "meetingAttendanceReport"),
            (HttpMethod.Delete, "", "DeleteAttendanceReport", "DeleteMeetingAttendanceReport", null),
            (HttpMethod.Post, "/attendanceRecords", "attendanceReport_CreateAttendanceRecord", "meetingAttendanceReport_CreateAttendanceRecord", "attendanceRecord"),
            (HttpMethod.Patch, "/attendanceRecords/{attendanceRecord-id}", "attendanceReport_UpdateAttendanceRecord", "meetingAttendanceReport_UpdateAttendanceRecord", "attendanceRecord"),
            (HttpMethod.Delete, "/attendanceRecords/{attendanceRecord-id}", "attendanceReport_DeleteAttendanceRecord", "meetingAttendanceReport_DeleteAttendanceRecord", null),
            (HttpMethod.Get, "/attendanceRecords", "attendanceReport_ListAttendanceRecord", "meetingAttendanceReport_ListAttendanceRecord", null),
            (HttpMethod.Get, "/attendanceRecords/{attendanceRecord-id}", "attendanceReport_GetAttendanceRecord", "meetingAttendanceReport_GetAttendanceRecord", null),
        ];
        foreach (var (method, child, pluralId, singletonId, body) in pairs)
        {
            var pluralPath = parent + plural + child;
            var singletonPath = parent + singleton + child;
            AssertOperation(document, method, pluralPath, idPrefix + (child.Length == 0 ? "_" : ".") + pluralId);
            AssertOperation(document, method, singletonPath, idPrefix + (child.Length == 0 ? "_" : ".") + singletonId);
            var left = document.Paths[pluralPath].Operations![method];
            var right = document.Paths[singletonPath].Operations![method];
            Assert.DoesNotContain(left.Parameters ?? [], parameter => parameter.In != ParameterLocation.Path && parameter.Required);
            Assert.DoesNotContain(right.Parameters ?? [], parameter => parameter.In != ParameterLocation.Path && parameter.Required);
            Assert.Equal(
                (left.Parameters ?? []).Where(parameter => parameter.In != ParameterLocation.Path).Select(parameter => $"{parameter.In}:{parameter.Name}:{parameter.Required}").Order(),
                (right.Parameters ?? []).Where(parameter => parameter.In != ParameterLocation.Path).Select(parameter => $"{parameter.In}:{parameter.Name}:{parameter.Required}").Order());
            if (body is null)
            {
                Assert.Null(left.RequestBody);
                Assert.Null(right.RequestBody);
            }
            else
            {
                Assert.Equal("microsoft.graph." + body, left.RequestBody!.Content!["application/json"].Schema!.GetReferenceId());
                Assert.Equal("microsoft.graph." + body, right.RequestBody!.Content!["application/json"].Schema!.GetReferenceId());
                Assert.Equal(left.RequestBody.Required, right.RequestBody.Required);
            }
            if (method == HttpMethod.Delete)
            {
                Assert.True(left.Responses!.ContainsKey("204"));
                Assert.True(right.Responses!.ContainsKey("204"));
                var header = Assert.Single(left.Parameters!, parameter => parameter.In == ParameterLocation.Header);
                Assert.Equal("If-Match", header.Name);
                Assert.False(header.Required);
            }
            else
            {
                var leftResponse = Assert.Single(left.Responses!, response => response.Key.StartsWith('2')).Value;
                var rightResponse = Assert.Single(right.Responses!, response => response.Key.StartsWith('2')).Value;
                Assert.Equal(
                    leftResponse.Content!["application/json"].Schema!.GetReferenceId(),
                    rightResponse.Content!["application/json"].Schema!.GetReferenceId());
            }
        }
    }

    [Theory]
    [InlineData("v1.0", false)]
    [InlineData("v1.0", true)]
    [InlineData("beta", false)]
    [InlineData("beta", true)]
    public async Task SharedSelectorsPreserveRenamesAndSuppressOnlyReviewedOperations(string profile, bool useCollisionData)
    {
        var document = await LoadSpec(profile);
        var config = new GeneratorConfig("Test.Client", "unused", useCollisionData);

        AssertOperation(document, HttpMethod.Post, CreateOrGet, "communication.onlineMeeting_createOrGet");
        AssertOperation(document, HttpMethod.Post, UserCreateOrGet, "user.onlineMeeting_createOrGet");
        AssertOperation(document, HttpMethod.Get, Recording, "user.onlineMeeting_getAllRecording");
        AssertOperation(document, HttpMethod.Get, Transcript, "user.onlineMeeting_getAllTranscript");
        AssertNaming(CreateOrGet, "CreateOrGetCommunicationOnlineMeeting", config, profile);
        Assert.True(CmdletConfigurator.IsSuppressed(HttpMethod.Post, UserCreateOrGet, config, apiVersion: profile));
        Assert.True(CmdletConfigurator.IsSuppressed(HttpMethod.Get, Recording, config, apiVersion: profile));
        Assert.True(CmdletConfigurator.IsSuppressed(HttpMethod.Get, Transcript, config, apiVersion: profile));
        foreach (var (method, path, id) in LegacySuppressions)
        {
            AssertOperation(document, method, path, id);
            Assert.True(CmdletConfigurator.IsSuppressed(method, path, config, apiVersion: profile), $"{method} {path}");
            Assert.False(CmdletConfigurator.IsSuppressed(method, path + "/unrelated", config, apiVersion: profile));
        }

        if (profile == "beta")
        {
            AssertOperation(document, HttpMethod.Post, MuteAll, "communication.call.participant_muteAll");
            AssertNaming(MuteAll, "MuteAllCommunicationCallParticipant", config, profile);
        }
        else
        {
            Assert.False(document.Paths.ContainsKey(MuteAll));
        }

        (HttpMethod Method, string Path, string Id)[] neighbors =
        [
            (HttpMethod.Post, "/communications/calls", "communication_CreateCall"),
            (HttpMethod.Get, "/communications/calls/{call-id}", "communication_GetCall"),
            (HttpMethod.Delete, "/communications/calls/{call-id}", "communication_DeleteCall"),
            (HttpMethod.Get, "/communications/callRecords/{callRecord-id}", "communication_GetCallRecord"),
            (HttpMethod.Get, "/communications/onlineMeetings", "communication_ListOnlineMeeting"),
            (HttpMethod.Post, "/users/{user-id}/onlineMeetings", "user_CreateOnlineMeeting"),
            (HttpMethod.Get, "/users/{user-id}/onlineMeetings", "user_ListOnlineMeeting"),
            (HttpMethod.Get, "/users/{user-id}/onlineMeetings/{onlineMeeting-id}", "user_GetOnlineMeeting"),
            (HttpMethod.Patch, "/users/{user-id}/onlineMeetings/{onlineMeeting-id}", "user_UpdateOnlineMeeting"),
            (HttpMethod.Delete, "/users/{user-id}/onlineMeetings/{onlineMeeting-id}", "user_DeleteOnlineMeeting"),
            (HttpMethod.Post, "/communications/calls/{call-id}/mute", "communication.call_mute"),
            (HttpMethod.Post, "/communications/calls/{call-id}/participants/{participant-id}/mute", "communication.call.participant_mute"),
            (HttpMethod.Get, Recording.Replace("/users/{user-id}", "/communications", StringComparison.Ordinal), "communication.onlineMeeting_getAllRecording"),
            (HttpMethod.Get, Transcript.Replace("/users/{user-id}", "/communications", StringComparison.Ordinal), "communication.onlineMeeting_getAllTranscript"),
            (HttpMethod.Get, "/communications/adhocCalls/getAllRecordings(userId='@userId',startDateTime=@startDateTime,endDateTime=@endDateTime)", "communication.adhocCall_getAllRecording"),
            (HttpMethod.Get, "/communications/adhocCalls/getAllTranscripts(userId='@userId',startDateTime=@startDateTime,endDateTime=@endDateTime)", "communication.adhocCall_getAllTranscript"),
            (HttpMethod.Get, "/users/{user-id}/onlineMeetings/{onlineMeeting-id}/recordings", "user.onlineMeeting_ListRecording"),
            (HttpMethod.Get, "/users/{user-id}/onlineMeetings/{onlineMeeting-id}/transcripts", "user.onlineMeeting_ListTranscript"),
        ];
        foreach (var (method, path, id) in neighbors)
        {
            AssertOperation(document, method, path, id);
            Assert.False(CmdletConfigurator.IsSuppressed(method, path, config, apiVersion: profile), $"{method} {path}");
        }

        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get, UserCreateOrGet, config, apiVersion: profile));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Post, UserCreateOrGet + "/child", config, apiVersion: profile));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Post, Recording, config, apiVersion: profile));
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Get, Transcript + "/child", config, apiVersion: profile));
        Assert.Null(CmdletConfigurator.TryGetOverriddenVerb(HttpMethod.Get, CreateOrGet, config, apiVersion: profile));
        Assert.Equal("Unchanged", CmdletConfigurator.ApplyNounOverrides(HttpMethod.Get, CreateOrGet, "Unchanged", config, apiVersion: profile));
        Assert.Equal("Unchanged", CmdletConfigurator.ApplyNounOverrides(HttpMethod.Post, MuteAll + "/child", "Unchanged", config, apiVersion: profile));
    }

    [Theory]
    [InlineData("v1.0", false)]
    [InlineData("v1.0", true)]
    [InlineData("beta", false)]
    [InlineData("beta", true)]
    public async Task TargetedGenerationEmitsSharedNamesAndKeepsUserMeetingCreation(string profile, bool useCollisionData)
    {
        var document = await LoadSpec(profile);
        var selectedPaths = new HashSet<string>(StringComparer.Ordinal)
        {
            CreateOrGet, UserCreateOrGet, MuteAll, Recording, Transcript, "/users/{user-id}/onlineMeetings",
        };
        selectedPaths.UnionWith(LegacySuppressions.Select(operation => operation.Path));
        foreach (var path in document.Paths.Keys.Where(path => !selectedPaths.Contains(path)).ToArray())
            document.Paths.Remove(path);

        var output = Path.Combine(Path.GetTempPath(), "cloudcommunications-directive-tests", Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(output);
        try
        {
            var config = new GeneratorConfig("Test.Client", output, useCollisionData);
            await new PowerShellWrapperGenerationService(document, config, NullLogger.Instance, apiVersion: profile)
                .GenerateAsync(CancellationToken.None);
            var files = Directory.GetFiles(output, "*.g.cs").Select(Path.GetFileName).ToArray();
            Assert.Contains("InvokeMgCreateOrGetCommunicationOnlineMeeting.g.cs", files);
            Assert.Contains("NewMgUserOnlineMeeting.g.cs", files);
            Assert.DoesNotContain(files, file => file!.Contains("UserOnlineMeetingCreateOrGet", StringComparison.Ordinal));
            Assert.DoesNotContain(files, file => file!.Contains("GetAllRecordings", StringComparison.Ordinal));
            Assert.DoesNotContain(files, file => file!.Contains("GetAllTranscripts", StringComparison.Ordinal));
            Assert.DoesNotContain("InvokeMgCommunicationOnlineMeetingCreateOrGet.g.cs", files);
            Assert.Equal(profile == "beta", files.Contains("InvokeMgMuteAllCommunicationCallParticipant.g.cs"));
            Assert.DoesNotContain("InvokeMgCommunicationCallParticipantMuteAll.g.cs", files);

            var sources = string.Join("\n", Directory.GetFiles(output, "*.g.cs").Select(File.ReadAllText));
            foreach (var (method, path, _) in LegacySuppressions)
                Assert.DoesNotContain($"[GraphRoute(\"{method}\", \"{path}\")]", sources, StringComparison.Ordinal);
            Assert.Contains("[GraphRoute(\"GET\", \"/communications/callRecords/{callRecord-id}\")]", sources, StringComparison.Ordinal);
            Assert.Contains("[GraphRoute(\"POST\", \"/communications/calls\")]", sources, StringComparison.Ordinal);

            var source = File.ReadAllText(Path.Combine(output, "InvokeMgCreateOrGetCommunicationOnlineMeeting.g.cs"));
            Assert.Contains("[Cmdlet(VerbsLifecycle.Invoke, \"MgCreateOrGetCommunicationOnlineMeeting\"", source, StringComparison.Ordinal);
            Assert.Contains("Communications.OnlineMeetings.CreateOrGet.PostAsync(", source, StringComparison.Ordinal);
        }
        finally
        {
            Directory.Delete(output, recursive: true);
        }
    }

    private static void AssertNaming(string path, string noun, GeneratorConfig config, string profile)
    {
        var naming = Naming.Resolve(new OperationInfo(HttpMethod.Post, path, Kind: OperationKind.Action), config, apiVersion: profile);
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Post, path, config, apiVersion: profile));
        Assert.Equal("Invoke", naming.VerbName);
        Assert.Equal("Mg" + noun, naming.Noun);
    }

    private static void AssertOperation(OpenApiDocument document, HttpMethod method, string path, string operationId)
    {
        Assert.True(document.Paths.TryGetValue(path, out var item), $"Missing compatible path: {path}");
        Assert.True(item.Operations!.TryGetValue(method, out var operation), $"Missing compatible operation: {method} {path}");
        Assert.Equal(operationId, operation.OperationId);
    }

    private static async Task<OpenApiDocument> LoadSpec(string profile, string specDirectory = "openApiDocs_KiotaCompat")
    {
        var root = AppContext.BaseDirectory;
        while (root is not null && !Directory.Exists(Path.Combine(root, "openApiDocs_KiotaCompat")))
            root = Path.GetDirectoryName(root);
        Assert.NotNull(root);
        var path = Path.Combine(root, specDirectory, profile, "CloudCommunications.yml");
        var settings = new OpenApiReaderSettings();
        settings.AddYamlReader();
        await using var stream = File.OpenRead(path);
        var result = await OpenApiDocument.LoadAsync(stream, settings: settings, cancellationToken: CancellationToken.None);
        Assert.NotNull(result.Document);
        return result.Document;
    }
}
