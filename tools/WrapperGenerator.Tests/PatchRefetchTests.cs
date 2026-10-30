using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.OpenApi;
using WrapperGenerator;
using Xunit;
using static WrapperGenerator.CmdletConfigurator;

namespace WrapperGenerator.Tests;

public sealed class PatchRefetchTests
{
    [Theory]
    [InlineData("v1.0")]
    [InlineData("beta")]
    public async Task OrdinaryAndGroupedRefetchBindOnlyGenericHeadersOnTheSelectedTypedBuilder(string profile)
    {
        var root = Path.Combine(Path.GetTempPath(), "wrapper-refetch-" + Guid.NewGuid().ToString("N"));
        try
        {
            await PatchRefetchFixture.GenerateAsync(root, profile);
            var files = Directory.GetFiles(Path.Combine(root, "Cmdlets"), "*.g.cs")
                .ToDictionary(path => Path.GetFileName(path)!, File.ReadAllText);
            foreach (var name in new[] { "UpdateMgAgreement", "UpdateMgProfileWidget_Route0", "UpdateMgProfileWidget_Route1",
                "UpdateMgProfileOrphanWidget_Route0" })
            {
                var source = files[name + ".g.cs"];
                var refetch = source[source.IndexOf("if (result is null)", StringComparison.Ordinal)..];
                Assert.Contains(".GetAsync(requestConfiguration =>", refetch);
                Assert.Contains("AddRequestHeaders(requestConfiguration.Headers);", refetch);
                Assert.DoesNotContain("IfMatch", refetch);
                Assert.DoesNotContain("QueryParameters", refetch);
                Assert.DoesNotContain("body.", refetch);
                Assert.DoesNotContain("WithUrl", refetch);
                Assert.Contains("requestConfiguration.Headers.Add(\"If-Match\", IfMatch!)", source);
                Assert.Equal(1, source.Split("ShouldProcess(", StringSplitOptions.None).Length - 1);
                Assert.True(source.IndexOf("ShouldProcess(", StringComparison.Ordinal) < source.IndexOf("var body", StringComparison.Ordinal));
            }
            Assert.Contains("client.Profiles[ProfileId].Widgets[WidgetId].Widgets[ChildWidgetId].GetAsync(",
                files["UpdateMgProfileWidget_Route1.g.cs"]);
            foreach (var name in new[] { "UpdateMgPlace", "UpdateMgProfileOrphanWidget_Route1",
                "SetMgAgreement", "SetMgProfileWidget_Route0", "SetMgProfileWidget_Route1" })
                Assert.DoesNotContain(".GetAsync(", files[name + ".g.cs"]);
            foreach (var name in new[] { "UpdateMgProfileWidget", "UpdateMgProfileOrphanWidget", "SetMgProfileWidget" })
            {
                Assert.DoesNotContain("ShouldProcess(", files[name + ".g.cs"]);
                Assert.Contains("MyInvocation.BoundParameters, internalCmdletName", files[name + ".g.cs"]);
            }
        }
        finally
        {
            if (Directory.Exists(root))
                Directory.Delete(root, recursive: true);
        }
    }
}

// Shared by the source-level test and Test-WrapperPatchRefetch.ps1's real Kiota compile/transport gate.
public static class PatchRefetchFixture
{
    public const string ClientNamespace = "Microsoft.Graph.PowerShell.RefetchProbe.Client";

    public static async Task GenerateAsync(string root, string profile)
    {
        var paths = new Dictionary<string, object>();
        object Parameter(string name, string location, bool required = false) =>
            new { name, @in = location, required, schema = new { type = "string" } };
        object Reference() => new Dictionary<string, string> { ["$ref"] = "#/components/schemas/microsoft.graph.widget" };
        object Operation(string method, string path)
        {
            var parameters = path.Split('/').Where(s => s.StartsWith('{'))
                .Select(s => Parameter(s[1..^1], "path", true)).ToList();
            if (method != "get")
                parameters.Add(Parameter("If-Match", "header"));
            var response = new { description = "Success", content = new Dictionary<string, object>
                { ["application/json"] = new { schema = Reference() } } };
            var responses = new Dictionary<string, object> { ["200"] = response };
            var operation = new Dictionary<string, object>
            {
                ["operationId"] = method + paths.Count,
                ["parameters"] = parameters,
                ["responses"] = responses,
            };
            if (method != "get")
            {
                operation["requestBody"] = new { required = true, content = new Dictionary<string, object>
                    { ["application/json"] = new { schema = Reference() } } };
                responses["204"] = new { description = "No content" };
            }
            return operation;
        }
        void Add(string path, params string[] methods) =>
            paths.Add(path, methods.ToDictionary(method => method, method => Operation(method, path)));
        const string widgets = "/profiles/{profile-id}/widgets";
        const string orphans = "/profiles/{profile-id}/orphanWidgets";
        Add("/agreements/{agreement-id}", "get", "patch", "put");
        Add("/places/{place-id}", "patch");
        Add(widgets + "/{widget-id}", "get", "patch", "put");
        Add(widgets + "/{widget-id}/widgets/{childWidget-id}", "get", "patch", "put");
        Add(orphans + "/{orphanWidget-id}", "get", "patch");
        Add(orphans + "/{orphanWidget-id}/orphanWidgets/{childWidget-id}", "patch");
        var schema = new
        {
            type = "object",
            properties = new Dictionary<string, object>
            {
                ["id"] = new { type = "string" },
                ["displayName"] = new { type = "string" },
                ["profileId"] = new { type = "string" },
            },
        };
        var spec = new
        {
            openapi = "3.0.1",
            info = new { title = "PATCH refetch transport regression", version = "1.0" },
            servers = new[] { new { url = "https://graph.microsoft.com/" + profile } },
            paths,
            components = new { schemas = new Dictionary<string, object> { ["microsoft.graph.widget"] = schema } },
        };
        Directory.CreateDirectory(root);
        var specPath = Path.Combine(root, "openapi.json");
        await File.WriteAllTextAsync(specPath, JsonSerializer.Serialize(spec, new JsonSerializerOptions { WriteIndented = true }));
        await using var stream = File.OpenRead(specPath);
        var read = await OpenApiDocument.LoadAsync(stream);
        var document = read.Document ?? throw new InvalidOperationException("Fixture OpenAPI failed to load.");
        var groups = new[]
        {
            new OperationVariantGroup([new("PATCH", widgets + "/{widget-id}", "Root"),
                new("PATCH", widgets + "/{widget-id}/widgets/{childWidget-id}", "Parent")], "Root"),
            new OperationVariantGroup([new("PUT", widgets + "/{widget-id}", "Root"),
                new("PUT", widgets + "/{widget-id}/widgets/{childWidget-id}", "Parent")], "Root"),
            new OperationVariantGroup([new("PATCH", orphans + "/{orphanWidget-id}", "Root"),
                new("PATCH", orphans + "/{orphanWidget-id}/orphanWidgets/{childWidget-id}", "Parent")], "Root"),
        };
        var entries = groups.Select(group => GroupVariants(group, "Isolated PATCH refetch regression")).ToArray();
        await new PowerShellWrapperGenerationService(document,
            new GeneratorConfig(ClientNamespace, Path.Combine(root, "Cmdlets"), UseCollisionData: false),
            NullLogger.Instance, profile, entries).GenerateAsync(CancellationToken.None);
    }
}
