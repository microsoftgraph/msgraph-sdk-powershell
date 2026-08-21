using System.Collections.Generic;
using System.Net.Http;
using WrapperGenerator;
using Xunit;

namespace WrapperGenerator.Tests;

public sealed class EmitterTests
{
    // A worker's terminating error (e.g. NoGraphSession) surfaces from InvokeScript as a
    // RuntimeException; the dispatcher must rethrow the original ErrorRecord, not re-wrap it
    // as its own GraphRequestFailed — otherwise every failure loses its identity and the
    // "run Connect-MgGraph" guidance never reaches the user. Found by the module smoke test.
    [Fact]
    public void DispatcherRethrowsTheWorkersOriginalErrorRecord()
    {
        var list = Naming.Resolve(new OperationInfo(HttpMethod.Get, "/users/{user-id}/messages"));
        var item = Naming.Resolve(new OperationInfo(HttpMethod.Get, "/users/{user-id}/messages/{message-id}"));

        var source = CmdletEmitter.EmitGetDispatcher(
            list, item, Naming.WithSuffix(list, "_List"), Naming.WithSuffix(item, "_Get"),
            new EmitContext("Test.Client"), "Message", "MessageCollectionResponse",
            new HashSet<string>(), new HashSet<string>());

        Assert.Contains("catch (RuntimeException rex) when (rex.ErrorRecord is not null)", source);
        Assert.Contains("ThrowTerminatingError(rex.ErrorRecord);", source);
    }

    // A collision-renamed property must emit the suffixed PARAMETER but assign the model's
    // real property: -DeviceId1 binds, body.DeviceId receives (Update-MgDevice pattern).
    [Fact]
    public void EmitsSuffixedParameterButAssignsRealModelProperty()
    {
        var naming = Naming.Resolve(new OperationInfo(HttpMethod.Patch, "/devices/{device-id}"));
        var (properties, _, _) = SchemaProperties.ResolveParameterNameCollisions(
            new[] { new CmdletProperty("deviceId", "DeviceId", "string", IsArray: false) },
            [], [],
            naming.PathParamNames);

        var source = CmdletEmitter.EmitUpdate(naming, new EmitContext("Test.Client"), "Device", properties, [], []);

        Assert.Contains("public string? DeviceId1 { get; set; }", source);
        Assert.Contains("body.DeviceId = DeviceId1;", source);
        Assert.Contains("IsParameterBound(nameof(DeviceId1))", source);
    }

    // A complex body property binds as its kiota model type, fully qualified, and assigns
    // straight to the model property. This is what lets a caller write
    // New-MgUser -PasswordProfile @{ Password = '...' } - PowerShell converts the hashtable
    // to the model on binding. Arrays land as T[] and convert with ToList() like scalar arrays.
    [Fact]
    public void EmitsComplexPropertyAsTypedModelParameter()
    {
        var naming = Naming.Resolve(new OperationInfo(HttpMethod.Post, "/users"));
        var complex = new[]
        {
            new ComplexParameter("PasswordProfile", "PasswordProfile", "Test.Client.Models.PasswordProfile", IsArray: false, IsEnum: false),
            new ComplexParameter("AssignedLicenses", "AssignedLicenses", "Test.Client.Models.AssignedLicense", IsArray: true, IsEnum: false),
            // An enum collection needs nullable elements to assign to kiota's List<TEnum?>.
            new ComplexParameter("Roles", "Roles", "Test.Client.Models.RoleType", IsArray: true, IsEnum: true),
        };

        var source = CmdletEmitter.EmitNew(naming, new EmitContext("Test.Client"), "User", [], complex, []);

        Assert.Contains("public Test.Client.Models.PasswordProfile? PasswordProfile { get; set; }", source);
        Assert.Contains("body.PasswordProfile = PasswordProfile;", source);

        Assert.Contains("public Test.Client.Models.AssignedLicense[]? AssignedLicenses { get; set; }", source);
        Assert.Contains("body.AssignedLicenses = AssignedLicenses!.ToList();", source);

        Assert.Contains("public Test.Client.Models.RoleType?[]? Roles { get; set; }", source);

        // The removed hard-coded special case must not come back in any form.
        Assert.DoesNotContain("ForceChangePasswordNextSignIn", source);
        Assert.DoesNotContain("new PasswordProfile", source);
    }

    // PATCH-only resources (/places/{id}) have no GetAsync on their kiota builder, so the
    // 204 re-fetch must be emitted only when the path has a GET (found by compiling the
    // Calendar module). Without the re-fetch, a bodiless 204 writes nothing — same as the
    // published SDK's Update behavior.
    [Fact]
    public void UpdateEmitsReFetchOnlyWhenPathHasGet()
    {
        var naming = Naming.Resolve(new OperationInfo(HttpMethod.Patch, "/places/{place-id}"));
        var props = new[] { new CmdletProperty("displayName", "DisplayName", "string", IsArray: false) };
        var ctx = new EmitContext("Test.Client");

        var withGet = CmdletEmitter.EmitUpdate(naming, ctx, "Place", props, [], [], reFetchAfterUpdate: true);
        Assert.Contains("re-fetching the updated resource", withGet);
        Assert.Contains(".GetAsync()", withGet);

        var withoutGet = CmdletEmitter.EmitUpdate(naming, ctx, "Place", props, [], [], reFetchAfterUpdate: false);
        Assert.DoesNotContain("re-fetching the updated resource", withoutGet);
        Assert.DoesNotContain(".GetAsync()", withoutGet);
        Assert.Contains("if (result is not null)", withoutGet);
    }

    // A spec-derived noun or header name containing a double quote must be escaped where it is
    // interpolated into a generated C# string literal, or the generated source will not compile.
    [Fact]
    public void EscapesQuotesInSpecDerivedStringLiterals()
    {
        var naming = new CmdletNaming(
            VerbsClass: "VerbsCommon",
            VerbName: "Remove",
            Noun: "MgHe\"llo",                       // quote lands in the [Cmdlet(..., "...")] literal
            ClassName: "RemoveMgHelloCommand",        // class name is a separate, valid identifier
            PathParamNames: new[] { "UserId" },
            BuilderExpression: "Users[UserId]",
            HeaderParams: new[] { new HeaderParam("If\"Match", "IfMatch") }); // quote in a header name

        var source = CmdletEmitter.EmitRemove(naming, new EmitContext("Test.Client"));

        // Escaped forms present (valid literals).
        Assert.Contains("\"MgHe\\\"llo\"", source);   // "MgHe\"llo"
        Assert.Contains("\"If\\\"Match\"", source);   // "If\"Match"

        // Broken/unescaped forms absent.
        Assert.DoesNotContain("\"MgHe\"llo\"", source); // "MgHe"llo"
        Assert.DoesNotContain("\"If\"Match\"", source); // "If"Match"
    }
}
