using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Reader;
using WrapperGenerator;
using Xunit;

namespace WrapperGenerator.Tests;

public sealed class IdentityGovernanceRequiredQueryTests
{
    private const string Root = "/identityGovernance/entitlementManagement";
    private static readonly Dictionary<string, Lazy<Task<OpenApiDocument>>> Specs = new()
    {
        ["v1.0"] = new(() => Load("v1.0")),
        ["beta"] = new(() => Load("beta")),
    };

    [Theory]
    [InlineData("v1.0", 4, 2)]
    [InlineData("beta", 6, 2)]
    public async Task ActualRequiredReferencesHaveMandatoryQueryIdAndKeepNativeWireMembers(
        string profile, int declaredCount, int survivingCount)
    {
        var spec = await Specs[profile].Value;
        var config = new GeneratorConfig("Microsoft.Graph.PowerShell.Test.Client", "unused");
        var declared = spec.Paths.SelectMany(p => p.Value.Operations!.Select(o =>
            (Path: p.Key, Item: p.Value, Method: o.Key, Operation: o.Value)))
            .Where(o => Effective(o.Item, o.Operation).Any(p => p.In == ParameterLocation.Query && p.Required))
            .ToArray();
        Assert.Equal(declaredCount, declared.Length);
        var surviving = declared.Where(o => !CmdletConfigurator.IsSuppressed(o.Method, o.Path, config, apiVersion: profile)).ToArray();
        Assert.Equal(survivingCount, surviving.Length);
        var expected = new List<string>
        {
            Root + "/accessPackages/{accessPackage-id}/incompatibleAccessPackages/$ref",
            Root + "/accessPackages/{accessPackage-id}/incompatibleGroups/$ref",
        };
        Assert.Equal(expected.OrderBy(p => p, StringComparer.Ordinal),
            surviving.Select(o => o.Path).OrderBy(p => p, StringComparer.Ordinal));
        foreach (var op in declared.Except(surviving))
            Assert.True(CmdletConfigurator.IsSuppressed(op.Method, op.Path,
                config with { UseCollisionData = false }, apiVersion: profile),
                "Existing shared authored suppressions must remain in force for non-shipping required-query routes.");

        var document = new OpenApiDocument { Info = spec.Info, Components = spec.Components, Paths = new OpenApiPaths() };
        foreach (var op in surviving)
        {
            Assert.Equal(HttpMethod.Delete, op.Method);
            Assert.EndsWith("/$ref", op.Path, StringComparison.Ordinal);
            var query = Assert.Single(Effective(op.Item, op.Operation), p => p.In == ParameterLocation.Query && p.Required);
            Assert.Equal("@id", query.Name);
            Assert.Equal(JsonSchemaType.String, query.Schema!.Type);
            Assert.Null(op.Operation.RequestBody);
            document.Paths.Add(op.Path, new OpenApiPathItem
            {
                Parameters = op.Item.Parameters,
                Operations = new Dictionary<HttpMethod, OpenApiOperation> { [HttpMethod.Delete] = op.Operation },
            });
        }
        var output = Path.Combine(Path.GetTempPath(), "governance-required-query", Guid.NewGuid().ToString("N"));
        try
        {
            await new PowerShellWrapperGenerationService(document, config with { OutputPath = output },
                NullLogger.Instance, apiVersion: profile).GenerateAsync(TestContext.Current.CancellationToken);
            var sources = Directory.GetFiles(output, "*.g.cs");
            Assert.Equal(survivingCount, sources.Length);
            foreach (var op in surviving)
            {
                var name = Naming.Resolve(new OperationInfo(op.Method, op.Path), config, apiVersion: profile);
                var source = File.ReadAllText(Path.Combine(output, $"{name.VerbName}{name.Noun}.g.cs"));
                Assert.Contains($"[GraphRoute(\"DELETE\", \"{op.Path}\")]", source, StringComparison.Ordinal);
                Assert.Contains("public string QueryId { get; set; }", source, StringComparison.Ordinal);
                Assert.Contains("[ValidateNotNullOrEmpty]", source, StringComparison.Ordinal);
                Assert.Matches(@"\[Parameter\(Mandatory = true,[^\]]+\)\]\s*\[ValidateNotNullOrEmpty\]", source);
                Assert.Contains("requestConfiguration.QueryParameters.Id = QueryId;", source, StringComparison.Ordinal);
                Assert.DoesNotContain("public string Id ", source, StringComparison.Ordinal);
                Assert.DoesNotContain("QueryParameters.QueryId", source, StringComparison.Ordinal);
                Assert.Contains("requestConfiguration.Headers.Add(\"If-Match\", IfMatch!)", source, StringComparison.Ordinal);
                Assert.Contains("AddRequestHeaders(requestConfiguration.Headers)", source, StringComparison.Ordinal);
                Assert.Contains($"GetRequestAdapter(\"{profile}\")", source, StringComparison.Ordinal);
                Assert.Contains("ConfirmImpact = ConfirmImpact.High", source, StringComparison.Ordinal);
                Assert.DoesNotContain("var body", source, StringComparison.Ordinal);
            }
        }
        finally
        {
            if (Directory.Exists(output))
                Directory.Delete(output, recursive: true);
        }
    }

    [Theory]
    [InlineData("v1.0")]
    [InlineData("beta")]
    public async Task AllSharedNaturalIdGroupsRemainPathOnlyAndItemReferencesNeedNoQuery(string profile)
    {
        var spec = await Specs[profile].Value;
        foreach (var group in CmdletConfigurator.GetOperationVariantGroups())
            foreach (var route in group.Routes)
                if (spec.Paths.TryGetValue(route.Path, out var item) &&
                    item.Operations!.TryGetValue(new HttpMethod(route.Method), out var operation))
                    Assert.DoesNotContain(Effective(item, operation), p => p.In == ParameterLocation.Query && p.Required);
        var neighbor = Root + "/accessPackages/{accessPackage-id}/incompatibleGroups/{group-id}/$ref";
        var path = spec.Paths[neighbor];
        Assert.DoesNotContain(Effective(path, path.Operations![HttpMethod.Delete]), p => p.In == ParameterLocation.Query && p.Required);
    }

    private static IEnumerable<IOpenApiParameter> Effective(IOpenApiPathItem item, OpenApiOperation operation) =>
        (item.Parameters ?? []).Concat(operation.Parameters ?? [])
            .GroupBy(p => (p.Name, p.In)).Select(g => g.Last());

    private static async Task<OpenApiDocument> Load(string profile)
    {
        var root = AppContext.BaseDirectory;
        while (root is not null && !File.Exists(Path.Combine(root, "src", "Identity.Governance", "Identity.Governance.md")))
            root = Path.GetDirectoryName(root);
        if (root is null)
            throw new InvalidOperationException("Repository root not found.");
        var settings = new OpenApiReaderSettings();
        settings.AddYamlReader();
        using var stream = File.OpenRead(Path.Combine(root, "openApiDocs_KiotaCompat", profile, "Identity.Governance.yml"));
        return (await OpenApiDocument.LoadAsync(stream, settings: settings)).Document
            ?? throw new InvalidOperationException($"Could not load actual compatible {profile} Governance spec.");
    }
}
