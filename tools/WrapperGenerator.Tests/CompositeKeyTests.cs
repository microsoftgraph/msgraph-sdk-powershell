using System;
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

public sealed class CompositeKeyTests
{
    private const string Keys = "id='{id}',policyId='{policyId}',deviceId='{deviceId}'";
    private const string Member = "WithIdWithPolicyIdWithDeviceId";

    private static string Route(string parent) =>
        $"/deviceManagement/{parent}/{{managedDevice-id}}/deviceHealthScriptStates/{Keys}";

    [Theory]
    [InlineData("managedDevices", "GET", "Get")]
    [InlineData("managedDevices", "PATCH", "Update")]
    [InlineData("managedDevices", "DELETE", "Remove")]
    [InlineData("comanagedDevices", "GET", "Get")]
    [InlineData("comanagedDevices", "PATCH", "Update")]
    [InlineData("comanagedDevices", "DELETE", "Remove")]
    public void ResolvesActualRoutesWithoutChangingTheirIdentityOrDefaultNoun(string parent, string method, string verb)
    {
        var path = Route(parent);
        var naming = Naming.Resolve(new OperationInfo(new HttpMethod(method), path));
        var parentMember = parent == "managedDevices" ? "ManagedDevices" : "ComanagedDevices";
        var parentNoun = parent == "managedDevices" ? "ManagedDevice" : "ComanagedDevice";

        Assert.Equal(path, naming.SourcePath);
        Assert.Equal(method, naming.SourceMethod);
        Assert.Equal(verb, naming.VerbName);
        Assert.Equal($"MgDeviceManagement{parentNoun}HealthScriptStateIdidpolicyIdpolicyIddeviceIddeviceId", naming.Noun);
        Assert.Equal(["ManagedDeviceId", "Id", "PolicyId", "DeviceId"], naming.PathParamNames);
        Assert.Equal(["managedDevice-id", "id", "policyId", "deviceId"], naming.PathParamTemplates);
        Assert.Equal($"DeviceManagement.{parentMember}[ManagedDeviceId].DeviceHealthScriptStates.{Member}()", naming.BuilderExpression);
        Assert.Equal($"DeviceManagement.{parentMember}.Item.DeviceHealthScriptStates.{Member}", naming.CompositeKeyBuilderNamespace);
        Assert.Empty(naming.FunctionParameters);
        Assert.Equal(OperationKind.Resource, naming.Kind);
    }

    [Fact]
    public void KeepsAllNestedParentValuesInOrderAndEscapesTheirTemplateKeys()
    {
        var naming = Naming.Resolve(new OperationInfo(HttpMethod.Get,
            "/tenants/{tenant-id}/deviceManagement/managedDevices/{managedDevice-id}/deviceHealthScriptStates/" + Keys));
        var source = CmdletEmitter.EmitItemGet(naming, new EmitContext("Regression.Client"),
            "Regression.Client.Models.DeviceHealthScriptPolicyState", new System.Collections.Generic.HashSet<string>());

        Assert.Equal(["TenantId", "ManagedDeviceId", "Id", "PolicyId", "DeviceId"], naming.PathParamNames);
        Assert.Equal("Tenants[TenantId].DeviceManagement.ManagedDevices[ManagedDeviceId].DeviceHealthScriptStates." + Member + "()",
            naming.BuilderExpression);
        Assert.Contains("""{ "tenant%2Did", TenantId }, { "managedDevice%2Did", ManagedDeviceId }, { "id", Id }, { "policyId", PolicyId }, { "deviceId", DeviceId }""", source);
    }

    [Theory]
    [InlineData("managedDevices")]
    [InlineData("comanagedDevices")]
    public async Task EmitsAllThreeTypedOperationsAndDistinctPatchBodyParameters(string parent)
    {
        var output = Path.Combine(Path.GetTempPath(), "wrapper-generator-composite", Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(output);
        try
        {
            var settings = new OpenApiReaderSettings();
            settings.AddYamlReader();
            using var stream = new MemoryStream(Encoding.UTF8.GetBytes(Spec(parent)));
            var document = (await OpenApiDocument.LoadAsync(stream, settings: settings,
                cancellationToken: CancellationToken.None)).Document!;
            var config = new GeneratorConfig("Regression.Client", output, UseCollisionData: false);
            await new PowerShellWrapperGenerationService(document, config, NullLogger.Instance)
                .GenerateAsync(CancellationToken.None);
            var sources = Directory.GetFiles(output, "*.g.cs").Select(file => File.ReadAllText(file).ReplaceLineEndings("\n"))
                .Where(source => source.Contains("[GraphRoute(", StringComparison.Ordinal)).ToArray();
            Assert.Equal(3, sources.Length);
            var parentMember = parent == "managedDevices" ? "ManagedDevices" : "ComanagedDevices";
            var constructor = $"new global::Regression.Client.DeviceManagement.{parentMember}.Item.DeviceHealthScriptStates.{Member}.{Member}RequestBuilder(";

            foreach (var method in new[] { "GET", "PATCH", "DELETE" })
            {
                var source = Assert.Single(sources, source => source.Contains($"[GraphRoute(\"{method}\",", StringComparison.Ordinal));
                Assert.Contains($"[GraphRoute(\"{method}\", \"{Route(parent)}\")]", source);
                foreach (var (name, position) in new[] { ("ManagedDeviceId", 0), ("Id", 1), ("PolicyId", 2), ("DeviceId", 3) })
                    Assert.Contains($"[Parameter(Mandatory = true, Position = {position})]\n        public string {name}", source);
                Assert.Contains(constructor, source);
                Assert.Contains("""{ "baseurl", requestAdapter.BaseUrl! }, { "managedDevice%2Did", ManagedDeviceId }, { "id", Id }, { "policyId", PolicyId }, { "deviceId", DeviceId }""", source);
                Assert.Contains("}, requestAdapter).", source);
                Assert.DoesNotContain(".Id=", source);
                Assert.DoesNotContain($".{Member}(", source);

                if (method == "PATCH")
                {
                    Assert.Contains("public string? PolicyId1 { get; set; }", source);
                    Assert.Contains("public string? DeviceId1 { get; set; }", source);
                    Assert.Contains("body.PolicyId = PolicyId1;", source);
                    Assert.Contains("body.DeviceId = DeviceId1;", source);
                    Assert.DoesNotContain("body.PolicyId = PolicyId;", source);
                    Assert.DoesNotContain("body.DeviceId = DeviceId;", source);
                    Assert.Contains("}, requestAdapter).PatchAsync(body,", source);
                    Assert.Contains("}, requestAdapter).GetAsync()", source); // Re-fetch binds the same keys.
                }
                else
                    Assert.Contains(method == "GET" ? "}, requestAdapter).GetAsync(" : "}, requestAdapter).DeleteAsync(", source);
            }
        }
        finally
        {
            Directory.Delete(output, recursive: true);
        }
    }

    [Theory]
    [InlineData("id='{id}',policyId=")]
    [InlineData("id='{id}',policyId='literal'")]
    [InlineData("id='{id}',policyId='{policyId}")]
    [InlineData("id='{id}',policyId={policyId}}")]
    [InlineData("id='{id}',policyId='{policyId}',")]
    [InlineData("id='{id}',id='{policyId}'")]
    [InlineData("id='{id}',policyId='{id}'")]
    [InlineData("id='{managedDevice-id}',policyId='{policyId}'")]
    [InlineData("id='{id}',policyId='{policy\"Id}'")]
    [InlineData("id='{id}',policyId='{policy\\Id}'")]
    [InlineData("id='{id}',policyId='{policyId}'/history/{history-id}")]
    [InlineData("id='{id}'")]
    public void RejectsMalformedOrUnsupportedCompositeExpressions(string segment)
    {
        var error = Assert.Throws<NotSupportedException>(() => Naming.Resolve(new OperationInfo(HttpMethod.Get,
            "/deviceManagement/managedDevices/{managedDevice-id}/deviceHealthScriptStates/" + segment)));
        Assert.Contains("omposite-key", error.Message);
    }

    [Theory]
    [InlineData("/users/{user-id}/messages/{message-id}", OperationKind.Resource, "Users[UserId].Messages[MessageId]")]
    [InlineData("/users/{user-id}/reminderView(StartDateTime='{StartDateTime}',EndDateTime='{EndDateTime}')",
        OperationKind.Function, "Users[UserId].ReminderViewWithStartDateTimeWithEndDateTime()")]
    [InlineData("/users/delta()", OperationKind.Function, "Users.Delta")]
    public void LeavesOrdinaryIndexersAndNamedFunctionsUnchanged(string path, OperationKind kind, string expression)
    {
        var naming = Naming.Resolve(new OperationInfo(HttpMethod.Get, path, Kind: kind));
        Assert.Equal(expression, naming.BuilderExpression);
        Assert.Empty(naming.CompositeKeyBuilderNamespace);
    }

    private static string Spec(string parent) => $$"""
        openapi: 3.0.1
        info: { title: composite regression, version: beta }
        paths:
          "{{Route(parent)}}":
            parameters:
              - name: managedDevice-id
                in: path
                required: true
                schema: { type: string }
            get:
              responses:
                '200':
                  description: The policy state
                  content:
                    application/json:
                      schema:
                        $ref: '#/components/schemas/microsoft.graph.deviceHealthScriptPolicyState'
            patch:
              requestBody:
                required: true
                content:
                  application/json:
                    schema:
                      $ref: '#/components/schemas/microsoft.graph.deviceHealthScriptPolicyState'
              responses:
                '200':
                  description: The policy state
                  content:
                    application/json:
                      schema:
                        $ref: '#/components/schemas/microsoft.graph.deviceHealthScriptPolicyState'
            delete:
              responses:
                '204': { description: Deleted }
        components:
          schemas:
            microsoft.graph.deviceHealthScriptPolicyState:
              type: object
              properties:
                id: { type: string }
                policyId: { type: string }
                deviceId: { type: string }
                policyName: { type: string }
        """;
}
