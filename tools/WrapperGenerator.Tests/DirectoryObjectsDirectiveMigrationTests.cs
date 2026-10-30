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

public sealed class DirectoryObjectsDirectiveMigrationTests
{
    private const string PkiPath = "/directory/publicKeyInfrastructure";
    private const string PkiSubject = "DirectoryPublicKeyInfrastructure";
    private const string ConfigurationSubject = PkiSubject + "CertificateBasedAuthConfiguration";
    private const string AuthoritySubject = ConfigurationSubject + "CertificateAuthority";

    [Fact]
    public void LedgerAccountsForEveryOriginalSelectorWithoutRepairingTyposOrDroppingDuplicates()
    {
        (string Verb, string Subject)[] expected =
        [
            ("Remove", AuthoritySubject),
            ("Update", ConfigurationSubject),
            ("Update", PkiSubject),
            ("Remove", AuthoritySubject),
            ("New", AuthoritySubject),
            ("New", "Mg" + ConfigurationSubject),
            ("Invoke", "Upload" + ConfigurationSubject),
            ("Get", ConfigurationSubject + "Count"),
            ("Get", "MgBeta" + AuthoritySubject + "Count"),
            ("Get", AuthoritySubject),
            ("Get", ConfigurationSubject),
            ("Get", PkiSubject),
            ("Get", AuthoritySubject + "Count"),
            ("New", ConfigurationSubject),
            ("Remove", PkiSubject),
            ("Remove", ConfigurationSubject),
            ("Update", AuthoritySubject),
        ];
        var source = File.ReadAllText(Path.Combine(RepoRoot(), "src", "DirectoryObjects", "DirectoryObjects.md"));
        var directives = Regex.Matches(source,
            @"(?m)^  - where:\r?\n      verb: (?<verb>\w+)\r?\n      subject: (?<subject>[^\r\n]+)\r?\n    remove: true\s*$");
        using var ledger = ReadLedger();
        var mappings = ledger.RootElement.GetProperty("mappings").EnumerateArray().ToArray();

        Assert.Equal(17, directives.Count);
        Assert.Equal(17, mappings.Length);
        Assert.DoesNotContain("remove-path-by-operation:", source);
        Assert.Equal(0, ledger.RootElement.GetProperty("reviewScope").GetProperty("deferredGroups").GetInt32());
        for (var i = 0; i < mappings.Length; i++)
        {
            var mapping = mappings[i];
            var selector = mapping.GetProperty("sourceSelector");
            Assert.Equal(i + 1, mapping.GetProperty("directiveIndex").GetInt32());
            Assert.Equal("CmdletSuppression", mapping.GetProperty("classification").GetString());
            Assert.Equal(expected[i].Verb, directives[i].Groups["verb"].Value);
            Assert.Equal("^" + expected[i].Subject + "$", directives[i].Groups["subject"].Value);
            Assert.Equal(expected[i].Verb, selector.GetProperty("verb").GetString());
            Assert.Equal(directives[i].Groups["subject"].Value, selector.GetProperty("subject").GetString());
            Assert.Equal(JsonValueKind.Null, selector.GetProperty("variant").ValueKind);
            Assert.Contains(mapping.GetProperty("sourceContains").GetString()!, directives[i].Value);
            Assert.Equal(i is 5 or 8 ? "LiteralSelectorNoMatch" : "NoCompatibleOperation",
                mapping.GetProperty("implementation").GetString());
            Assert.False(mapping.TryGetProperty("operationIdSource", out _));
        }
    }

    [Theory]
    [InlineData("v1.0", 0)]
    [InlineData("beta", 16)]
    public void ReviewedLegacyEvidenceCoversActualOperationsAndProvesCompatibleAbsence(string profile, int pkiCount)
    {
        var legacy = ReadOperations("openApiDocs", profile);
        var compatible = ReadOperations("openApiDocs_KiotaCompat", profile);
        var pki = legacy.Where(operation => operation.Path.StartsWith(PkiPath, StringComparison.Ordinal)).ToArray();
        Assert.Equal(pkiCount, pki.Length);
        Assert.Equal(15 + pkiCount, legacy.Length);
        Assert.Equal(15, compatible.Length);
        Assert.DoesNotContain(compatible, operation => operation.Path.StartsWith(PkiPath, StringComparison.OrdinalIgnoreCase));

        using var ledger = ReadLedger();
        var reviewed = new HashSet<Operation>();
        foreach (var mapping in ledger.RootElement.GetProperty("mappings").EnumerateArray())
        {
            var selector = mapping.GetProperty("sourceSelector");
            var verb = selector.GetProperty("verb").GetString();
            var subject = new Regex(selector.GetProperty("subject").GetString()!);
            var selected = pki.Where(operation =>
            {
                var name = LegacyPkiName(operation);
                return name.Verb == verb && subject.IsMatch(name.Subject);
            }).ToArray();
            var evidence = mapping.GetProperty("legacyEvidence").GetProperty(profile).EnumerateArray()
                .Select(operation => new Operation(
                    operation.GetProperty("method").GetString()!,
                    operation.GetProperty("path").GetString()!,
                    operation.GetProperty("operationId").GetString()!)).ToArray();
            Assert.Equal(selected.OrderBy(Key), evidence.OrderBy(Key));
            reviewed.UnionWith(evidence);
            foreach (var operation in evidence)
            {
                Assert.DoesNotContain(compatible, candidate =>
                    candidate.Method == operation.Method && candidate.Path == operation.Path);
                // Upload is the only action in this selected family. Check its actual final
                // unqualified successor too, rather than mistaking namespace removal for absence.
                if (operation.Path.EndsWith("/microsoft.graph.upload", StringComparison.Ordinal))
                    Assert.DoesNotContain(compatible, candidate =>
                        candidate.Method == operation.Method &&
                        candidate.Path == operation.Path.Replace("/microsoft.graph.upload", "/upload", StringComparison.Ordinal));
            }

            var profileMap = mapping.GetProperty("profiles").GetProperty(profile);
            Assert.True(profileMap.GetProperty("absenceExpected").GetBoolean());
            Assert.Equal(0, profileMap.GetProperty("operations").GetArrayLength());
            Assert.False(profileMap.TryGetProperty("excluded", out _));
            Assert.False(profileMap.TryGetProperty("removedLegacyOperations", out _));
        }
        Assert.Equal(pki.OrderBy(Key), reviewed.OrderBy(Key));
    }

    [Theory]
    [InlineData("v1.0", false)]
    [InlineData("v1.0", true)]
    [InlineData("beta", false)]
    [InlineData("beta", true)]
    public void LiveCompatibleNeighborsRetainExistingSuppressionAndResourceNames(string profile, bool useDerivedData)
    {
        var config = new GeneratorConfig("Test.Client", "unused", UseCollisionData: useDerivedData);
        foreach (var operation in ReadOperations("openApiDocs_KiotaCompat", profile))
        {
            var method = new HttpMethod(operation.Method);
            var existingRestoreSuppression = useDerivedData && profile == "v1.0" &&
                operation.Method == "POST" && operation.Path == "/directoryObjects/{directoryObject-id}/restore";
            Assert.Equal(existingRestoreSuppression,
                CmdletConfigurator.IsSuppressed(method, operation.Path, config, apiVersion: profile));

            if (operation.Path is "/directoryObjects" or "/directoryObjects/{directoryObject-id}" or "/directoryObjects/$count")
            {
                var naming = Naming.Resolve(new OperationInfo(method, operation.Path), config, apiVersion: profile);
                Assert.Equal(operation.Method switch
                {
                    "GET" => "Get",
                    "POST" => "New",
                    "PATCH" => "Update",
                    "DELETE" => "Remove",
                    _ => throw new InvalidOperationException(operation.Method),
                }, naming.VerbName);
                Assert.Equal(operation.Path.EndsWith("/$count", StringComparison.Ordinal)
                    ? "MgDirectoryObjectCount" : "MgDirectoryObject", naming.Noun);
            }
        }
    }

    [Theory]
    [InlineData("/directoryObjects/{directoryObject-id}/checkMemberGroups", "Confirm", "DirectoryObjectMemberGroup")]
    [InlineData("/directoryObjects/{directoryObject-id}/checkMemberObjects", "Confirm", "DirectoryObjectMemberObject")]
    [InlineData("/directoryObjects/{directoryObject-id}/getMemberGroups", "Get", "DirectoryObjectMemberGroup")]
    [InlineData("/directoryObjects/{directoryObject-id}/getMemberObjects", "Get", "DirectoryObjectMemberObject")]
    [InlineData("/directoryObjects/getAvailableExtensionProperties", "Get", "DirectoryObjectAvailableExtensionProperty")]
    [InlineData("/directoryObjects/getByIds", "Get", "DirectoryObjectById")]
    [InlineData("/directoryObjects/validateProperties", "Test", "DirectoryObjectProperty")]
    public void ExistingDerivedActionRenamesRemainAuthoritative(string path, string verb, string noun)
    {
        var operation = new OperationInfo(HttpMethod.Post, path, Kind: OperationKind.Action);
        var config = new GeneratorConfig("Test.Client", "unused");
        var naming = Naming.Resolve(operation, config, apiVersion: "v1.0");
        Assert.Equal(verb, naming.VerbName);
        Assert.Equal("Mg" + noun, naming.Noun);
        Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Post, path, config, apiVersion: "v1.0"));
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void BetaActionNeighborsNeverConsumeV1OracleRenames(bool useDerivedData)
    {
        (string Path, string Noun)[] actions =
        [
            ("/directoryObjects/{directoryObject-id}/checkMemberGroups", "DirectoryObjectCheckMemberGroups"),
            ("/directoryObjects/{directoryObject-id}/checkMemberObjects", "DirectoryObjectCheckMemberObjects"),
            ("/directoryObjects/{directoryObject-id}/getMemberGroups", "DirectoryObjectGetMemberGroups"),
            ("/directoryObjects/{directoryObject-id}/getMemberObjects", "DirectoryObjectGetMemberObjects"),
            ("/directoryObjects/{directoryObject-id}/restore", "DirectoryObjectRestore"),
            ("/directoryObjects/getByIds", "DirectoryObjectGetByIds"),
            ("/directoryObjects/getUserOwnedObjects", "DirectoryObjectGetUserOwnedObjects"),
            ("/directoryObjects/validateProperties", "DirectoryObjectValidateProperties"),
        ];
        var operations = ReadOperations("openApiDocs_KiotaCompat", "beta");
        var config = new GeneratorConfig("Test.Client", "unused", UseCollisionData: useDerivedData);
        foreach (var (path, noun) in actions)
        {
            Assert.Contains(operations, operation => operation.Method == "POST" && operation.Path == path);
            var naming = Naming.Resolve(new OperationInfo(HttpMethod.Post, path, Kind: OperationKind.Action),
                config, apiVersion: "beta");
            Assert.Equal("Invoke", naming.VerbName);
            Assert.Equal("Mg" + noun, naming.Noun);
            Assert.Null(CmdletConfigurator.TryGetOverriddenVerb(HttpMethod.Post, path, config, apiVersion: "beta"));
            Assert.Equal(noun, CmdletConfigurator.ApplyNounOverrides(HttpMethod.Post, path, noun, config, apiVersion: "beta"));
            Assert.False(CmdletConfigurator.IsSuppressed(HttpMethod.Post, path, config, apiVersion: "beta"));
        }
    }

    private sealed record Operation(string Method, string Path, string OperationId);

    private static string Key(Operation operation) => $"{operation.Method} {operation.Path} [{operation.OperationId}]";

    // These legacy resource IDs encode the old subject explicitly. Do not run modern
    // structural naming over them: upload's published subject places the action first.
    private static (string Verb, string Subject) LegacyPkiName(Operation operation)
    {
        var parts = operation.OperationId.Split('_');
        Assert.Equal(2, parts.Length);
        var prefix = string.Concat(parts[0].Split('.').Select(segment => char.ToUpperInvariant(segment[0]) + segment[1..]));
        foreach (var (legacyVerb, verb) in new[]
        {
            ("List", "Get"), ("Get", "Get"), ("Create", "New"), ("Update", "Update"), ("Delete", "Remove"),
        })
        {
            if (parts[1].StartsWith(legacyVerb, StringComparison.Ordinal))
                return (verb, prefix + parts[1][legacyVerb.Length..]);
        }
        Assert.Equal("upload", parts[1]);
        return ("Invoke", "Upload" + prefix);
    }

    private static JsonDocument ReadLedger() => JsonDocument.Parse(File.ReadAllText(Path.Combine(
        RepoRoot(), "src", "DirectoryObjects", "wrapper", "DirectoryObjects_directiveMigrationMap.json")));

    private static Operation[] ReadOperations(string specRoot, string profile)
    {
        var settings = new OpenApiReaderSettings();
        settings.AddYamlReader();
        using var stream = File.OpenRead(Path.Combine(RepoRoot(), specRoot, profile, "DirectoryObjects.yml"));
        var document = OpenApiDocument.LoadAsync(stream, settings: settings, cancellationToken: CancellationToken.None)
            .GetAwaiter().GetResult().Document;
        Assert.NotNull(document);
        return document.Paths!.SelectMany(path => path.Value.Operations!.Select(operation =>
            new Operation(operation.Key.Method.ToUpperInvariant(), path.Key, operation.Value.OperationId!))).ToArray();
    }

    private static string RepoRoot()
    {
        var directory = new DirectoryInfo(AppContext.BaseDirectory);
        while (directory is not null && !File.Exists(Path.Combine(directory.FullName, "tools", "WrapperGenerator", "WrapperGenerator.csproj")))
            directory = directory.Parent;
        return directory?.FullName ?? throw new InvalidOperationException("Could not locate repository root.");
    }
}
