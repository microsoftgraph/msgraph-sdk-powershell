using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Reader;
using WrapperGenerator;
using Xunit;

namespace WrapperGenerator.Tests;

// OData actions and functions: operations that CALL something on a resource rather than doing
// CRUD over it. Every expectation here is a fact about the real Graph documents or about a real
// kiota client generated from them (tools/WrapperGenerator/docs/edge-cases/action-function-edge-cases.md
// records where each was verified), never a restatement of what the generator happens to do.
//
// The spec fragments are copied from openApiDocs_KiotaCompat/v1.0 verbatim, so a change in how
// Graph publishes these operations fails here rather than silently changing the cmdlet surface.
public sealed class ActionFunctionTests
{
    private static OpenApiDocument Parse(string yaml)
    {
        var settings = new OpenApiReaderSettings();
        settings.AddYamlReader();
        using var stream = new MemoryStream(Encoding.UTF8.GetBytes(yaml));
        return OpenApiDocument.LoadAsync(stream, settings: settings, cancellationToken: CancellationToken.None)
            .GetAwaiter().GetResult().Document!;
    }

    private static (string[] Files, string Source) Generate(string yaml, string expectedFile)
    {
        var outputDir = Path.Combine(Path.GetTempPath(), "wrapper-generator-actionfn", Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(outputDir);
        try
        {
            // The oracle-derived rename data is deliberately NOT applied: these tests pin the
            // structural rules that turn a spec shape into a cmdlet, so a data-file change can
            // never silently shift what they assert. Parity of the resulting names against the
            // published SDK is a separate gate (Compare-WrapperCmdletNames.ps1).
            var config = new GeneratorConfig("Microsoft.Graph.PowerShell.Test.Client", outputDir, UseCollisionData: false);
            new PowerShellWrapperGenerationService(Parse(yaml), config, NullLogger.Instance)
                .GenerateAsync(CancellationToken.None).GetAwaiter().GetResult();
            var files = Directory.GetFiles(outputDir, "*.g.cs")
                .Select(f => Path.GetFileName(f) ?? string.Empty).ToArray();
            var path = Path.Combine(outputDir, expectedFile);
            return (files, File.Exists(path) ? File.ReadAllText(path) : string.Empty);
        }
        finally
        {
            if (Directory.Exists(outputDir))
                Directory.Delete(outputDir, recursive: true);
        }
    }

    // ---- naming ---------------------------------------------------------------------------

    private static CmdletNaming Resolve(HttpMethod method, string path, OperationKind kind) =>
        Naming.Resolve(new OperationInfo(method, path, HeaderParams: null, kind));

    [Theory]
    // An action is a call, so it takes the approved "run this" verb rather than POST's New.
    [InlineData("POST", "/users/{user-id}/assignLicense", OperationKind.Action, "Invoke", "MgUserAssignLicense")]
    [InlineData("POST", "/users/{user-id}/sendMail", OperationKind.Action, "Invoke", "MgUserSendMail")]
    // A function is a read and keeps Get. /users/delta() ships exactly this name.
    [InlineData("GET", "/users/delta()", OperationKind.Function, "Get", "MgUserDelta")]
    // The operation name is an identifier, not a resource: it is neither singularized nor
    // collapsed against the preceding segment. Both rules are load-bearing — see the two
    // dedicated tests below.
    [InlineData("GET", "/drives/{drive-id}/items/{driveItem-id}/workbook/functions/averageIfs", OperationKind.Function,
        "Get", "MgDriveItemWorkbookFunctionAverageIfs")]
    // A namespace-qualified action keeps only its bare name in the noun; the qualifier is OData
    // type information and the published route does not carry it either.
    [InlineData("POST", "/security/cases/ediscoveryCases/{ediscoveryCase-id}/custodians/{ediscoveryCustodian-id}/microsoft.graph.security.applyHold",
        OperationKind.Action, "Invoke", "MgSecurityCaseEdiscoveryCaseCustodianApplyHold")]
    public void NamesActionsAndFunctionsFromTheirRoute(string method, string path, OperationKind kind, string expectedVerb, string expectedNoun)
    {
        var naming = Resolve(new HttpMethod(method), path, kind);
        Assert.Equal(expectedVerb, naming.VerbName);
        Assert.Equal(expectedNoun, naming.Noun);
    }

    // averageIf and averageIfs are two different Excel functions. Singularizing the operation
    // segment merged them onto one cmdlet file, which the collision guard caught across five
    // Files routes (averageIfs/countIfs/days/sheets/sumIfs).
    [Fact]
    public void DoesNotSingularizeTheOperationName()
    {
        const string prefix = "/drives/{drive-id}/items/{driveItem-id}/workbook/functions/";
        Assert.NotEqual(
            Resolve(HttpMethod.Get, prefix + "averageIf", OperationKind.Function).Noun,
            Resolve(HttpMethod.Get, prefix + "averageIfs", OperationKind.Function).Noun);
    }

    // The published SDK ships the collection-bound and reply-bound forms of replyWithQuote as
    // two commands (Invoke-MgGraphTeamChannelMessage and ...MessageReply), so the
    // adjacent-duplicate strip that keeps /domains/{id}/domainNameReferences from repeating
    // "Domain" must not erase "Reply" from .../replies/replyWithQuote and merge them.
    [Fact]
    public void DoesNotCollapseTheOperationNameAgainstThePrecedingSegment()
    {
        Assert.NotEqual(
            Resolve(HttpMethod.Post, "/teams/{team-id}/channels/{channel-id}/messages/replyWithQuote", OperationKind.Action).Noun,
            Resolve(HttpMethod.Post, "/teams/{team-id}/channels/{channel-id}/messages/{chatMessage-id}/replies/replyWithQuote", OperationKind.Action).Noun);
    }

    [Theory]
    // Kiota names a parameterized function's builder member by appending one "With<Param>" per
    // inline argument, in path order, and puts its generated types in a namespace that mirrors
    // the route with every {id} segment collapsed to "Item". Verified against clients generated
    // from Users.Functions.yml and Mail.yml.
    [InlineData("/users/{user-id}/reminderView(StartDateTime='{StartDateTime}',EndDateTime='{EndDateTime}')",
        "ReminderViewWithStartDateTimeWithEndDateTime", "Users.Item.ReminderViewWithStartDateTimeWithEndDateTime")]
    [InlineData("/users/{user-id}/exportDeviceAndAppManagementData(skip={skip},top={top})",
        "ExportDeviceAndAppManagementDataWithSkipWithTop", "Users.Item.ExportDeviceAndAppManagementDataWithSkipWithTop")]
    [InlineData("/users/{user-id}/messages/{message-id}/copy", "Copy", "Users.Item.Messages.Item.Copy")]
    // The qualifier survives into the kiota member and namespace even though the noun drops it.
    [InlineData("/security/cases/ediscoveryCases/{ediscoveryCase-id}/custodians/{ediscoveryCustodian-id}/microsoft.graph.security.applyHold",
        "MicrosoftGraphSecurityApplyHold",
        "Security.Cases.EdiscoveryCases.Item.Custodians.Item.MicrosoftGraphSecurityApplyHold")]
    public void PredictsTheKiotaMemberAndTypeNamespace(string path, string expectedMember, string expectedNamespace)
    {
        var naming = Resolve(HttpMethod.Get, path, OperationKind.Function);
        Assert.Equal(expectedMember, naming.OperationMemberName);
        Assert.Equal(expectedNamespace, naming.OperationTypeNamespace);
    }

    [Fact]
    public void ParameterizedFunctionCarriesItsArgumentsInPathOrder()
    {
        var naming = Resolve(HttpMethod.Get,
            "/users/{user-id}/reminderView(StartDateTime='{StartDateTime}',EndDateTime='{EndDateTime}')", OperationKind.Function);
        Assert.Equal(["StartDateTime", "EndDateTime"], naming.FunctionParameters.Select(p => p.TemplateName));
        // The builder member is a method, so the chain has to call it to stay valid C#.
        Assert.EndsWith("ReminderViewWithStartDateTimeWithEndDateTime()", naming.BuilderExpression, StringComparison.Ordinal);
    }

    [Fact]
    public void UnparameterizedFunctionIsABuilderProperty()
    {
        // Kiota exposes a zero-argument function as a property, not a method (verified on
        // Users.Delta and Users.Item.ExportDeviceAndAppManagementData).
        Assert.Equal("Users.Delta", Resolve(HttpMethod.Get, "/users/delta()", OperationKind.Function).BuilderExpression);
    }

    // A verb outside the published SDK's own set is refused rather than guessed at: emitting an
    // unknown Verbs* class would not compile, and inventing one would ship an unapproved verb.
    [Fact]
    public void RejectsAVerbTheSdkDoesNotUse()
    {
        Assert.Equal("VerbsCommon", PsVerb.FromApprovedName("Add").AttributeClass);
        Assert.Equal("VerbsCommunications", PsVerb.FromApprovedName("Send").AttributeClass);
        Assert.Throws<NotSupportedException>(() => PsVerb.FromApprovedName("Frobnicate"));
    }

    // ---- emission -------------------------------------------------------------------------

    // An action whose response references an entity: kiota returns that model from the plain
    // PostAsync, and the action's own parameters come from the inline request body it generates
    // as <Member>PostRequestBody.
    private const string AssignLicenseYaml = """
        openapi: 3.0.1
        info: { title: t, version: v1.0 }
        paths:
          '/users/{user-id}/assignLicense':
            post:
              operationId: users.user.assignLicense
              requestBody:
                content:
                  application/json:
                    schema:
                      type: object
                      properties:
                        addLicenses:
                          type: array
                          items:
                            $ref: '#/components/schemas/microsoft.graph.assignedLicense'
                        removeLicenses:
                          type: array
                          items: { type: string, format: uuid }
              responses:
                2XX:
                  content:
                    application/json:
                      schema:
                        anyOf:
                          - $ref: '#/components/schemas/microsoft.graph.user'
                          - type: object
                            nullable: true
              x-ms-docs-operation-type: action
        components:
          schemas:
            microsoft.graph.user: { type: object, properties: { id: { type: string } } }
            microsoft.graph.assignedLicense: { type: object, properties: { skuId: { type: string, format: uuid } } }
        """;

    [Fact]
    public void EmitsActionWithComplexRequestBodyAndEntityReturn()
    {
        var (files, source) = Generate(AssignLicenseYaml, "InvokeMgUserAssignLicense.g.cs");

        Assert.Contains("InvokeMgUserAssignLicense.g.cs", files);
        // Body type is the per-operation class kiota generates beside the request builder.
        Assert.Contains("new global::Microsoft.Graph.PowerShell.Test.Client.Users.Item.AssignLicense.AssignLicensePostRequestBody()", source, StringComparison.Ordinal);
        // Body properties bind as parameters, arrays included. A model type is emitted fully
        // qualified but without "global::", the way every other bound model parameter is.
        Assert.Contains("public Microsoft.Graph.PowerShell.Test.Client.Models.AssignedLicense[]? AddLicenses", source, StringComparison.Ordinal);
        Assert.Contains("public global::System.Guid?[]? RemoveLicenses", source, StringComparison.Ordinal);
        // anyOf[$ref, nullable] is a nullability annotation, so the return is the entity itself.
        Assert.Contains("[OutputType(typeof(Microsoft.Graph.PowerShell.Test.Client.Models.User))]", source, StringComparison.Ordinal);
        Assert.Contains(".PostAsync(body,", source, StringComparison.Ordinal);
        // An action mutates, so it gates on ShouldProcess like the other writing cmdlets.
        Assert.Contains("SupportsShouldProcess = true", source, StringComparison.Ordinal);
    }

    // An action with no response body at all - the largest single response shape in v1.0 (784
    // operations). Kiota emits a plain Task-returning PostAsync, so the cmdlet has no output.
    private const string SendMailYaml = """
        openapi: 3.0.1
        info: { title: t, version: v1.0 }
        paths:
          '/users/{user-id}/sendMail':
            post:
              operationId: users.user.sendMail
              requestBody:
                content:
                  application/json:
                    schema:
                      type: object
                      properties:
                        saveToSentItems: { type: boolean }
              responses:
                '204': { description: Success }
              x-ms-docs-operation-type: action
        """;

    [Fact]
    public void EmitsNoContentActionWithoutAnOutputType()
    {
        var (files, source) = Generate(SendMailYaml, "InvokeMgUserSendMail.g.cs");

        Assert.Contains("InvokeMgUserSendMail.g.cs", files);
        Assert.DoesNotContain("[OutputType(", source, StringComparison.Ordinal);
        Assert.DoesNotContain("WriteObject(", source, StringComparison.Ordinal);
        Assert.Contains("public bool? SaveToSentItems", source, StringComparison.Ordinal);
    }

    // An action with no request body: kiota's PostAsync takes no body argument, so emitting one
    // would not compile.
    private const string RestoreYaml = """
        openapi: 3.0.1
        info: { title: t, version: v1.0 }
        paths:
          '/users/{user-id}/restore':
            post:
              operationId: users.user.restore
              responses:
                '204': { description: Success }
              x-ms-docs-operation-type: action
        """;

    [Fact]
    public void EmitsBodilessActionWithoutABodyArgument()
    {
        var (_, source) = Generate(RestoreYaml, "InvokeMgUserRestore.g.cs");
        Assert.Contains(".PostAsync(requestConfiguration", source, StringComparison.Ordinal);
        Assert.DoesNotContain("var body = new", source, StringComparison.Ordinal);
    }

    // A response that wraps its payload in "value" is not an entity: kiota generates a
    // per-operation <Member>PostResponse for it and marks the plain PostAsync overload
    // [Obsolete] in favour of PostAs<Member>PostResponseAsync. Calling the obsolete overload
    // would compile with warnings today and break when kiota removes it.
    private const string GetMemberGroupsYaml = """
        openapi: 3.0.1
        info: { title: t, version: v1.0 }
        paths:
          '/users/{user-id}/getMemberGroups':
            post:
              operationId: users.user.getMemberGroups
              requestBody:
                content:
                  application/json:
                    schema:
                      type: object
                      properties:
                        securityEnabledOnly: { type: boolean }
              responses:
                2XX:
                  content:
                    application/json:
                      schema:
                        type: object
                        properties:
                          value:
                            type: array
                            items: { type: string }
              x-ms-docs-operation-type: action
        """;

    [Fact]
    public void CallsTheNonObsoleteMethodForAValueWrappingResponse()
    {
        var (_, source) = Generate(GetMemberGroupsYaml, "InvokeMgUserGetMemberGroups.g.cs");

        Assert.Contains(".PostAsGetMemberGroupsPostResponseAsync(body,", source, StringComparison.Ordinal);
        Assert.Contains("Users.Item.GetMemberGroups.GetMemberGroupsPostResponse", source, StringComparison.Ordinal);
    }

    // A parameterized function. These OpenAPI documents declare no path parameters at all
    // (grep -c 'in: path' over openApiDocs_KiotaCompat/v1.0 is 0), so kiota emits the accessor
    // with an empty signature and leaves the placeholders in the URL template. The values go in
    // through the builder's public path-parameter constructor, keyed by the template's own
    // placeholder names - "{user-id}" is stored percent-encoded as "user%2Did".
    private const string ReminderViewYaml = """
        openapi: 3.0.1
        info: { title: t, version: v1.0 }
        paths:
          "/users/{user-id}/reminderView(StartDateTime='{StartDateTime}',EndDateTime='{EndDateTime}')":
            get:
              operationId: users.user.reminderView
              parameters:
                - { name: $top, in: query, schema: { type: integer } }
              responses:
                2XX:
                  content:
                    application/json:
                      schema:
                        type: object
                        properties:
                          value:
                            type: array
                            items: { $ref: '#/components/schemas/microsoft.graph.reminder' }
              x-ms-docs-operation-type: function
        components:
          schemas:
            microsoft.graph.reminder: { type: object, properties: { eventId: { type: string } } }
        """;

    [Fact]
    public void EmitsParameterizedFunctionBindingItsArgumentsThroughThePathParameters()
    {
        var (files, source) = Generate(ReminderViewYaml, "GetMgUserReminderViewWithStartDateTimeWithEndDateTime.g.cs");

        Assert.Contains("GetMgUserReminderViewWithStartDateTimeWithEndDateTime.g.cs", files);
        // Arguments are mandatory cmdlet parameters positioned after the path ids.
        Assert.Contains("public string StartDateTime", source, StringComparison.Ordinal);
        Assert.Contains("public string EndDateTime", source, StringComparison.Ordinal);
        // Keyed by the URL-template placeholder, with kiota's percent-encoding for "user-id".
        Assert.Contains("{ \"user%2Did\", UserId },", source, StringComparison.Ordinal);
        Assert.Contains("{ \"StartDateTime\", StartDateTime },", source, StringComparison.Ordinal);
        Assert.Contains("new global::Microsoft.Graph.PowerShell.Test.Client.Users.Item.ReminderViewWithStartDateTimeWithEndDateTime.ReminderViewWithStartDateTimeWithEndDateTimeRequestBuilder(pathParameters, requestAdapter)", source, StringComparison.Ordinal);
        // Only declared query options bind: kiota generates a property per declared option.
        Assert.Contains("QueryParameters.Top = Top;", source, StringComparison.Ordinal);
        Assert.DoesNotContain("QueryParameters.Filter", source, StringComparison.Ordinal);
        // A function reads, so it does not gate on ShouldProcess.
        Assert.DoesNotContain("SupportsShouldProcess", source, StringComparison.Ordinal);
    }

    // A function returning a single entity comes back from the plain GetAsync.
    private const string ExportDataYaml = """
        openapi: 3.0.1
        info: { title: t, version: v1.0 }
        paths:
          '/users/{user-id}/exportDeviceAndAppManagementData()':
            get:
              operationId: users.user.exportDeviceAndAppManagementData
              responses:
                2XX:
                  content:
                    application/json:
                      schema:
                        anyOf:
                          - $ref: '#/components/schemas/microsoft.graph.deviceAndAppManagementData'
                          - type: object
                            nullable: true
              x-ms-docs-operation-type: function
        components:
          schemas:
            microsoft.graph.deviceAndAppManagementData: { type: object, properties: { id: { type: string } } }
        """;

    [Fact]
    public void EmitsEntityReturningFunctionThroughPlainGetAsync()
    {
        var (_, source) = Generate(ExportDataYaml, "GetMgUserExportDeviceAndAppManagementData.g.cs");
        Assert.Contains("[OutputType(typeof(Microsoft.Graph.PowerShell.Test.Client.Models.DeviceAndAppManagementData))]", source, StringComparison.Ordinal);
        Assert.Contains(".GetAsync(requestConfiguration", source, StringComparison.Ordinal);
    }

    // An operation whose success response is bytes rather than JSON. Kiota types these as
    // Stream from the ordinary Post/GetAsync, and the Intune reporting surface is almost all of
    // this shape (94 of the 101 shipped cmdlets it covers).
    private const string CachedReportYaml = """
        openapi: 3.0.1
        info: { title: t, version: v1.0 }
        paths:
          /deviceManagement/reports/getCachedReport:
            post:
              operationId: deviceManagement.reports.getCachedReport
              requestBody:
                content:
                  application/json:
                    schema:
                      type: object
                      properties:
                        id: { type: string }
              responses:
                2XX:
                  content:
                    application/octet-stream:
                      schema: { type: string, format: binary }
              x-ms-docs-operation-type: action
        """;

    [Fact]
    public void EmitsStreamReturningActionAsBytes()
    {
        var (files, source) = Generate(CachedReportYaml, "InvokeMgDeviceManagementReportGetCachedReport.g.cs");

        Assert.Contains("InvokeMgDeviceManagementReportGetCachedReport.g.cs", files);
        // The body still binds like any other action; only the response handling differs.
        Assert.Contains("GetCachedReportPostRequestBody()", source, StringComparison.Ordinal);
        Assert.Contains("System.IO.Stream? result;", source, StringComparison.Ordinal);
        // A raw Stream is bound to the request that produced it, so the bytes are what reaches
        // the pipeline — and that is what the declared output type has to say.
        Assert.Contains("[OutputType(typeof(byte[]))]", source, StringComparison.Ordinal);
        Assert.Contains("result.CopyTo(buffer);", source, StringComparison.Ordinal);
        Assert.Contains("WriteObject(buffer.ToArray());", source, StringComparison.Ordinal);
        // The response stream owns the HTTP response. Disposing only the buffer would leak one
        // connection per invocation, across every cmdlet of this shape.
        Assert.Contains("using (result)", source, StringComparison.Ordinal);
    }

    // ---- the resource / operation boundary ------------------------------------------------
    //
    // A stream response is generated for an action or a function and NOT for a resource GET,
    // whose stream downloads remain the pre-existing gap. The two tests below pin both sides.
    // The distinction is load-bearing and easy to lose: the media-content check originally ran
    // against every GET, which silently swallowed 98 stream-returning FUNCTIONS before the
    // action/function path could see them — the bug that made a first attempt recover 20 of 118.

    private const string StreamFunctionYaml = """
        openapi: 3.0.1
        info: { title: t, version: v1.0 }
        paths:
          '/deviceManagement/reports/getReportFilters()':
            get:
              operationId: deviceManagement.reports.getReportFilters
              responses:
                2XX:
                  content:
                    application/octet-stream:
                      schema: { type: string, format: binary }
              x-ms-docs-operation-type: function
        """;

    [Fact]
    public void StreamReturningFunctionGenerates()
    {
        var (files, source) = Generate(StreamFunctionYaml, "GetMgDeviceManagementReportGetReportFilters.g.cs");

        Assert.Contains("GetMgDeviceManagementReportGetReportFilters.g.cs", files);
        Assert.Contains("[OutputType(typeof(byte[]))]", source, StringComparison.Ordinal);
        Assert.Contains("System.IO.Stream? result;", source, StringComparison.Ordinal);
    }

    // The response declares JSON *and* octet-stream, which is how the styled documents describe
    // a /content endpoint (found by compiling Teams). That combination is the whole reason the
    // media check exists: the JSON schema is present, so every other guard is satisfied, and
    // only the binary content stops the generator deserialising an entity from a call kiota
    // types as Stream. A fixture with octet-stream ALONE proves nothing here — the
    // missing-JSON-schema guard rejects it whether the media check runs or not, so the test
    // would pass with the check deleted.
    private const string StreamResourceGetYaml = """
        openapi: 3.0.1
        info: { title: t, version: v1.0 }
        paths:
          '/drives/{drive-id}/items/{driveItem-id}/content':
            get:
              operationId: drives.driveItem.GetContent
              responses:
                2XX:
                  content:
                    application/json:
                      schema: { $ref: '#/components/schemas/microsoft.graph.driveItem' }
                    application/octet-stream:
                      schema: { type: string, format: binary }
        components:
          schemas:
            microsoft.graph.driveItem: { type: object, properties: { id: { type: string } } }
        """;

    // A media download on an ordinary resource GET (no x-ms-docs-operation-type) goes through the
    // content emitter: kiota types the call as Stream, so it binds as bytes with -OutFile rather
    // than deserialising the entity schema the styled document also lists. 78 v1.0 routes are this
    // shape (/content, /logo, /favicon, attachmentsArchive), 75 of which the published SDK ships.
    [Fact]
    public void StreamReturningResourceGetEmitsTheContentShape()
    {
        var (files, source) = Generate(StreamResourceGetYaml, "GetMgDriveItemContent.g.cs");

        Assert.Contains("GetMgDriveItemContent.g.cs", files);
        Assert.Contains("[OutputType(typeof(byte[]))]", source, StringComparison.Ordinal);
        Assert.Contains("System.IO.Stream? result;", source, StringComparison.Ordinal);
        // The response stream owns the HTTP response and is disposed, and -OutFile is declared
        // because this response really is a stream.
        Assert.Contains("using (result)", source, StringComparison.Ordinal);
        Assert.Contains("IsParameterBound(nameof(OutFile))", source, StringComparison.Ordinal);
        // The entity schema the document also lists must NOT be bound.
        Assert.DoesNotContain("DriveItem? result;", source, StringComparison.Ordinal);
    }

    // The binary FORMAT is the signal, not merely a non-JSON media type. A text/plain success
    // response is an ordinary scalar: binding it as a stream would emit a byte[] cmdlet for a
    // string. This is the boundary the media test has to hold, and it is why the check reads the
    // schema's format rather than the content-type string.
    [Fact]
    public void NonBinaryNonJsonResponseIsNotTreatedAsAMediaDownload()
    {
        const string yaml = """
            openapi: 3.0.1
            info: { title: t, version: v1.0 }
            paths:
              '/users/{user-id}/somethingPlain':
                get:
                  operationId: users.user.plain
                  responses:
                    '200':
                      content:
                        text/plain:
                          schema: { type: string }
            """;

        var (files, _) = Generate(yaml, "unused");
        Assert.Equal(["Shared.g.cs"], files);
    }

    // ---- OData $-segments -------------------------------------------------------------------

    // A /$count GET. The response is text/plain (that is how OData returns a count), but kiota
    // types it as int? from a plain GetAsync on the Count builder, so it is neither a media
    // download nor an entity read. The published SDK names it Get-Mg<Noun>Count.
    private const string CountYaml = """
        openapi: 3.0.1
        info: { title: t, version: v1.0 }
        paths:
          '/users/$count':
            get:
              operationId: users.GetCount
              parameters:
                - { name: $filter, in: query, schema: { type: string } }
              responses:
                2XX:
                  content:
                    text/plain:
                      schema: { type: integer, format: int32 }
        """;

    [Fact]
    public void EmitsCountCmdletForTheCountSegment()
    {
        var (files, source) = Generate(CountYaml, "GetMgUserCount.g.cs");

        Assert.Contains("GetMgUserCount.g.cs", files);
        // The noun takes the published suffix and the call goes through kiota's Count member.
        Assert.Contains("\"MgUserCount\"", source, StringComparison.Ordinal);
        Assert.Contains("client.Users.Count.GetAsync(", source, StringComparison.Ordinal);
        Assert.Contains("[OutputType(typeof(int))]", source, StringComparison.Ordinal);
        Assert.Contains("int? result;", source, StringComparison.Ordinal);
        // text/plain must not be mistaken for a media download and filtered out.
        Assert.DoesNotContain("byte[]", source, StringComparison.Ordinal);
    }

    // A collection navigation's /$ref lists reference URLs. Kiota types that as
    // StringCollectionResponse — a collection of strings, not of entities — so the ordinary list
    // emitter's entity resolution does not apply. The published SDK names it …ByRef.
    private const string RefCollectionYaml = """
        openapi: 3.0.1
        info: { title: t, version: v1.0 }
        paths:
          '/groups/{group-id}/members/$ref':
            get:
              operationId: groups.group.ListMemberByRef
              responses:
                2XX:
                  content:
                    application/json:
                      schema:
                        type: object
                        properties:
                          value: { type: array, items: { type: string } }
        """;

    [Fact]
    public void EmitsReferenceListForACollectionRefSegment()
    {
        var (files, source) = Generate(RefCollectionYaml, "GetMgGroupMemberByRef.g.cs");

        Assert.Contains("GetMgGroupMemberByRef.g.cs", files);
        Assert.Contains("\"MgGroupMemberByRef\"", source, StringComparison.Ordinal);
        Assert.Contains("client.Groups[GroupId].Members.Ref.GetAsync(", source, StringComparison.Ordinal);
        Assert.Contains("Models.StringCollectionResponse? result;", source, StringComparison.Ordinal);
    }

    // A /$ref write. microsoft.graph.referenceCreate has exactly ONE property, "@odata.id", and
    // it is the caller-supplied target of the link. Excluding it as OData control data left the
    // cmdlet posting an empty body with no way to say what to link — a cmdlet that cannot work.
    // Kiota names the member OdataId, so the parameter and the assignment must use that.
    private const string RefCreateYaml = """
        openapi: 3.0.1
        info: { title: t, version: v1.0 }
        paths:
          '/groups/{group-id}/members/$ref':
            post:
              operationId: groups.group.CreateMemberByRef
              requestBody:
                content:
                  application/json:
                    schema: { $ref: '#/components/schemas/ReferenceCreate' }
              responses:
                '204': { description: Success }
            put:
              operationId: groups.group.SetMemberByRef
              requestBody:
                content:
                  application/json:
                    schema: { $ref: '#/components/schemas/ReferenceCreate' }
              responses:
                '204': { description: Success }
        components:
          schemas:
            ReferenceCreate:
              type: object
              properties:
                '@odata.id': { type: string }
        """;

    [Theory]
    [InlineData("NewMgGroupMemberByRef.g.cs", "PostAsync")]
    [InlineData("SetMgGroupMemberByRef.g.cs", "PutAsync")]
    public void ReferenceWriteBindsTheODataIdTarget(string file, string method)
    {
        var (files, source) = Generate(RefCreateYaml, file);

        Assert.Contains(file, files);
        // The link target is a real parameter, not swallowed as protocol metadata.
        Assert.Contains("public string? OdataId { get; set; }", source, StringComparison.Ordinal);
        Assert.Contains("body.OdataId = OdataId;", source, StringComparison.Ordinal);
        // "@odata.id" is not a legal C# member; kiota's OdataId spelling is what compiles.
        Assert.DoesNotContain("body.@odata.id", source, StringComparison.Ordinal);
        Assert.Contains($".{method}(body,", source, StringComparison.Ordinal);
        // A reference write returns no content, so it declares no output type.
        Assert.DoesNotContain("[OutputType(", source, StringComparison.Ordinal);
    }

    // The annotations that really are protocol metadata stay excluded — binding @odata.type
    // would put a type discriminator on the parameter surface of ~10,600 body properties.
    [Fact]
    public void MetadataODataAnnotationsAreStillExcluded()
    {
        const string yaml = """
            openapi: 3.0.1
            info: { title: t, version: v1.0 }
            paths:
              '/users/{user-id}/sendMail':
                post:
                  operationId: users.user.sendMail
                  requestBody:
                    content:
                      application/json:
                        schema:
                          type: object
                          properties:
                            '@odata.type': { type: string }
                            '@odata.count': { type: integer, format: int32 }
                            saveToSentItems: { type: boolean }
                  responses:
                    '204': { description: Success }
                  x-ms-docs-operation-type: action
            """;

        var (_, source) = Generate(yaml, "InvokeMgUserSendMail.g.cs");
        Assert.Contains("public bool? SaveToSentItems", source, StringComparison.Ordinal);
        Assert.DoesNotContain("OdataType", source, StringComparison.Ordinal);
        Assert.DoesNotContain("OdataCount", source, StringComparison.Ordinal);
    }

    // A /$value read and write. Kiota exposes the segment as the Content builder (the folder is
    // Value, the accessor is Content) and types both as Stream. -OutFile and -InFile match the
    // published surface: Get-MgUserPhotoContent -OutFile, Set-MgUserPhotoContent -InFile.
    private const string ValueYaml = """
        openapi: 3.0.1
        info: { title: t, version: v1.0 }
        paths:
          '/users/{user-id}/photo/$value':
            get:
              operationId: users.user.photo.GetContent
              responses:
                2XX:
                  content:
                    application/octet-stream:
                      schema: { type: string, format: binary }
            put:
              operationId: users.user.photo.SetContent
              requestBody:
                content:
                  application/octet-stream:
                    schema: { type: string, format: binary }
              responses:
                2XX:
                  content:
                    application/octet-stream:
                      schema: { type: string, format: binary }
        """;

    [Fact]
    public void EmitsContentReadAndWriteForTheValueSegment()
    {
        var (files, getSource) = Generate(ValueYaml, "GetMgUserPhotoContent.g.cs");
        Assert.Contains("GetMgUserPhotoContent.g.cs", files);
        Assert.Contains("SetMgUserPhotoContent.g.cs", files);
        Assert.Contains("client.Users[UserId].Photo.Content.GetAsync(", getSource, StringComparison.Ordinal);
        Assert.Contains("public string? OutFile", getSource, StringComparison.Ordinal);
        Assert.Contains("using (result)", getSource, StringComparison.Ordinal);

        var (_, putSource) = Generate(ValueYaml, "SetMgUserPhotoContent.g.cs");
        Assert.Contains("public string InFile", putSource, StringComparison.Ordinal);
        Assert.Contains("System.IO.File.OpenRead(InFile)", putSource, StringComparison.Ordinal);
        Assert.Contains(".PutAsync(content,", putSource, StringComparison.Ordinal);
    }

    // A $-segment with no emitter must still be skipped rather than fall through to the resource
    // emitters. $count, $ref and $value are emitted; anything else is not.
    [Fact]
    public void UnimplementedODataSegmentsAreStillSkipped()
    {
        const string yaml = """
            openapi: 3.0.1
            info: { title: t, version: v1.0 }
            paths:
              '/users/{user-id}/messages/$delta':
                get:
                  operationId: unsupported.segment
                  responses:
                    2XX:
                      content:
                        application/json:
                          schema: { $ref: '#/components/schemas/microsoft.graph.user' }
            components:
              schemas:
                microsoft.graph.user: { type: object, properties: { id: { type: string } } }
            """;

        var (files, _) = Generate(yaml, "unused");
        Assert.Equal(["Shared.g.cs"], files);
    }

    // Only x-ms-docs-operation-type makes an operation an action or a function. Without it a
    // parenthesised segment is still an unsupported OData shape, and the generator must not
    // start emitting garbage nouns for one.
    [Fact]
    public void TreatsAParenthesisedSegmentAsUnsupportedWhenTheSpecDoesNotCallItAFunction()
    {
        const string yaml = """
            openapi: 3.0.1
            info: { title: t, version: v1.0 }
            paths:
              "/users/{user-id}/somethingElse(x='{x}')":
                get:
                  operationId: users.user.somethingElse
                  responses:
                    2XX:
                      content:
                        application/json:
                          schema: { $ref: '#/components/schemas/microsoft.graph.user' }
            components:
              schemas:
                microsoft.graph.user: { type: object, properties: { id: { type: string } } }
            """;

        var (files, _) = Generate(yaml, "unused");
        Assert.Equal(["Shared.g.cs"], files);
    }

    // An action declared on a method other than POST (or a function on other than GET) would be
    // emitted with the wrong request shape, so the metadata is not trusted on its own.
    [Fact]
    public void IgnoresAnOperationTypeThatContradictsItsHttpMethod()
    {
        const string yaml = """
            openapi: 3.0.1
            info: { title: t, version: v1.0 }
            paths:
              '/users/{user-id}/thing':
                delete:
                  operationId: users.user.thing
                  responses:
                    '204': { description: Success }
                  x-ms-docs-operation-type: action
            """;

        var (files, _) = Generate(yaml, "RemoveMgUserThing.g.cs");
        // Falls back to resource handling: DELETE still emits its ordinary Remove- cmdlet.
        Assert.Contains("RemoveMgUserThing.g.cs", files);
    }

    // A binary upload whose response is the updated ENTITY rather than the bytes back. This is
    // the common shape, not an edge case: 56 of the 190 v1.0 cmdlets that reach EmitContentSet
    // return a driveItem, onenotePage or callRecording. Both PUT paths land here — the /$value
    // branch and EmitSetFor's non-JSON-request-body branch — so the gate belongs in the emitter.
    //
    // -OutFile only ever gets read inside the stream-output block, so on an entity response it is
    // a parameter that accepts a path and silently ignores it. The two cases are asserted
    // together on purpose: deleting the gate fails the entity case, and hard-coding it to ""
    // fails the stream case, so neither mistake passes.
    private const string ContentWriteYaml = """
        openapi: 3.0.1
        info: { title: t, version: v1.0 }
        paths:
          '/drives/{drive-id}/bundles/{driveItem-id}/content':
            put:
              operationId: drives.bundles.SetContent
              requestBody:
                content:
                  application/octet-stream:
                    schema: { type: string, format: binary }
              responses:
                2XX:
                  content:
                    RESPONSE_CONTENT
        components:
          schemas:
            microsoft.graph.driveItem: { type: object, properties: { id: { type: string } } }
        """;

    [Fact]
    public void ContentWriteDeclaresOutFileOnlyWhenTheResponseIsAStream()
    {
        var entityYaml = ContentWriteYaml.Replace("RESPONSE_CONTENT",
            "application/json:\n                      schema: { $ref: '#/components/schemas/microsoft.graph.driveItem' }",
            StringComparison.Ordinal);
        var (files, entitySource) = Generate(entityYaml, "SetMgDriveBundleContent.g.cs");

        Assert.Contains("SetMgDriveBundleContent.g.cs", files);
        // The upload itself is unaffected; only the unusable output redirect goes away.
        Assert.Contains("public string InFile", entitySource, StringComparison.Ordinal);
        Assert.Contains("System.IO.File.OpenRead(InFile)", entitySource, StringComparison.Ordinal);
        Assert.Contains("WriteObject(result);", entitySource, StringComparison.Ordinal);
        Assert.DoesNotContain("OutFile", entitySource, StringComparison.Ordinal);

        var streamYaml = ContentWriteYaml.Replace("RESPONSE_CONTENT",
            "application/octet-stream:\n                      schema: { type: string, format: binary }",
            StringComparison.Ordinal);
        var (_, streamSource) = Generate(streamYaml, "SetMgDriveBundleContent.g.cs");

        // A stream response still redirects to disk, and still disposes the response.
        Assert.Contains("public string? OutFile", streamSource, StringComparison.Ordinal);
        Assert.Contains("IsParameterBound(nameof(OutFile))", streamSource, StringComparison.Ordinal);
        Assert.Contains("using (result)", streamSource, StringComparison.Ordinal);
    }
}
