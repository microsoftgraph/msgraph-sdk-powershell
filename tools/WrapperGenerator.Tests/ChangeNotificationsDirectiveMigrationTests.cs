using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Reader;
using WrapperGenerator;
using Xunit;

namespace WrapperGenerator.Tests;

public sealed class ChangeNotificationsDirectiveMigrationTests
{
    private static string FindRepoRoot()
    {
        var directory = AppContext.BaseDirectory;
        while (directory is not null &&
            !File.Exists(Path.Combine(directory, "src", "ChangeNotifications", "ChangeNotifications.md")))
            directory = Path.GetDirectoryName(directory);
        return directory ?? throw new InvalidOperationException("Repository root not found.");
    }

    private static JsonDocument ReadAudit(string root) =>
        JsonDocument.Parse(File.ReadAllText(Path.Combine(root, "src", "ChangeNotifications", "wrapper",
            "ChangeNotifications_directiveMigrationMap.json")));

    [Fact]
    public void EmptySharedSourceHasAnHonestAuditWithoutOverrides()
    {
        var root = FindRepoRoot();
        using var ledger = ReadAudit(root);
        Assert.Empty(ledger.RootElement.GetProperty("mappings").EnumerateArray());
        var audit = ledger.RootElement.GetProperty("audit");
        Assert.Equal("ChangeNotifications", audit.GetProperty("module").GetString());
        Assert.Equal("NoSharedDirectives", audit.GetProperty("disposition").GetString());
        Assert.Equal(0, audit.GetProperty("sharedCmdletDirectiveCount").GetInt32());
        Assert.Equal(0, audit.GetProperty("deferredParameterDirectiveCount").GetInt32());
        Assert.Equal(0, audit.GetProperty("deferredSchemaDirectiveCount").GetInt32());
        Assert.Empty(audit.GetProperty("excludedProfiles").EnumerateArray());
        Assert.DoesNotMatch(@"(?m)^\s*directive:", File.ReadAllText(
            Path.Combine(root, "src", "ChangeNotifications", "ChangeNotifications.md")));
        Assert.Matches(@"ChangeNotificationsCmdletConfigurations\s*=\s*\[\s*\]", File.ReadAllText(
            Path.Combine(root, "src", "ChangeNotifications", "wrapper",
                "ChangeNotifications_cmdletConfigurations.cs")));
    }

    [Theory]
    [InlineData("v1.0", true)]
    [InlineData("v1.0", false)]
    [InlineData("beta", true)]
    [InlineData("beta", false)]
    public async Task CompatibleOperationsKeepTheirIdentityAndNaming(string profile, bool useCollisionData)
    {
        var root = FindRepoRoot();
        using var ledger = ReadAudit(root);
        var evidence = ledger.RootElement.GetProperty("audit").GetProperty("profiles").GetProperty(profile);
        Assert.Equal($"openApiDocs_KiotaCompat/{profile}/ChangeNotifications.yml",
            evidence.GetProperty("spec").GetString());
        var settings = new OpenApiReaderSettings();
        settings.AddYamlReader();
        using var stream = File.OpenRead(Path.Combine(root, "openApiDocs_KiotaCompat", profile,
            "ChangeNotifications.yml"));
        var result = await OpenApiDocument.LoadAsync(stream, settings: settings,
            cancellationToken: CancellationToken.None);
        var document = Assert.IsType<OpenApiDocument>(result.Document);
        const int expectedCount = 7;
        Assert.Equal(expectedCount, document.Paths.Sum(path => path.Value.Operations!.Count));
        var operations = evidence.GetProperty("operations").EnumerateArray().ToArray();
        Assert.Equal(expectedCount, operations.Length);
        Assert.Equal(expectedCount, operations.Select(operation =>
            $"{operation.GetProperty("method").GetString()} {operation.GetProperty("path").GetString()}")
            .Distinct(StringComparer.Ordinal).Count());

        var structuralNames = new Dictionary<string, (string Command, OperationKind Kind)>(StringComparer.Ordinal)
        {
            ["subscription_ListSubscription"] = ("Get-MgSubscription", OperationKind.Resource),
            ["subscription_CreateSubscription"] = ("New-MgSubscription", OperationKind.Resource),
            ["subscription_GetSubscription"] = ("Get-MgSubscription", OperationKind.Resource),
            ["subscription_UpdateSubscription"] = ("Update-MgSubscription", OperationKind.Resource),
            ["subscription_DeleteSubscription"] = ("Remove-MgSubscription", OperationKind.Resource),
            ["subscription_reauthorize"] = ("Invoke-MgSubscriptionReauthorize", OperationKind.Action),
            ["subscription_getVapidPublicKey"] = ("Get-MgSubscriptionGetVapidPublicKey", OperationKind.Function),
        };
        var config = new GeneratorConfig("Microsoft.Graph.PowerShell.Test.Client", Path.GetTempPath(),
            UseCollisionData: useCollisionData);
        foreach (var operation in operations)
        {
            var method = new HttpMethod(operation.GetProperty("method").GetString()!);
            var path = operation.GetProperty("path").GetString()!;
            var operationId = operation.GetProperty("operationId").GetString()!;
            Assert.True(document.Paths.ContainsKey(path), $"Missing {profile} {method} {path}.");
            var actual = Assert.Single(document.Paths[path].Operations!,
                candidate => candidate.Key == method).Value;
            Assert.Equal(operationId, actual.OperationId);
            var expected = structuralNames[operationId];
            var extension = Assert.IsType<JsonNodeExtension>(
                actual.Extensions!["x-ms-docs-operation-type"]);
            Assert.Equal(expected.Kind switch
            {
                OperationKind.Action => "action",
                OperationKind.Function => "function",
                _ => "operation",
            }, extension.Node!.ToString().Trim('"'));

            Assert.False(CmdletConfigurator.IsSuppressed(method, path, apiVersion: profile));
            Assert.False(CmdletConfigurator.IsSuppressed(method, path, config, apiVersion: profile));
            var operationInfo = new OperationInfo(method, path, Kind: expected.Kind);
            var structural = Naming.Resolve(operationInfo, apiVersion: profile);
            Assert.Equal(expected.Command, $"{structural.VerbName}-{structural.Noun}");
            var configured = Naming.Resolve(operationInfo, config, apiVersion: profile);
            var configuredName = useCollisionData && profile == "v1.0" && expected.Kind == OperationKind.Action
                ? "Invoke-MgReauthorizeSubscription"
                : expected.Command;
            Assert.Equal(configuredName, $"{configured.VerbName}-{configured.Noun}");
        }
    }
}
