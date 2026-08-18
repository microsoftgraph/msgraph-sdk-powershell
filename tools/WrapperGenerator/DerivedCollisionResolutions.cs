using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text.Json;

namespace WrapperGenerator;

// Collision resolutions DERIVED from the published-command oracle, as opposed to the curated
// judgment entries in NamingOverrides. tools/Derive-CollisionResolutions.ps1 writes the
// data/collision-*.json files from (collision inventory x MgCommandMetadata.json) and its
// -Validate mode fails when the checked-in files drift from a fresh derivation; the files are
// embedded at build time so a generation run never reads the 22 MB oracle itself.
//
// Entries are exact-match only, keyed by API version + HTTP method + normalized URI, and
// exist solely for operations that appeared in the collision inventory. Anything broader
// (subtree prunes, cross-path merge picks) is curated in NamingOverrides with a citation.
internal static class DerivedCollisionResolutions
{
    private sealed record DataEntry(string ApiVersion, string Method, string Uri, string Action, string? ReplacementNoun, string? ReplacementVerb);

    // A rename carries the published noun and, for an action or function, the published verb:
    // the SDK distinguishes applyHold from removeHold by verb alone (Add- vs Remove-) on the
    // same noun, so a noun-only rename would name both cmdlets identically.
    public sealed record DerivedName(string Noun, string? Verb);

    private sealed record Tables(HashSet<string> Suppressions, Dictionary<string, DerivedName> Renames);

    private static readonly Lazy<Dictionary<string, Tables>> ByApiVersion = new(Load);

    private static readonly JsonSerializerOptions JsonOptions = new() { PropertyNameCaseInsensitive = true };

    public static bool IsSuppressed(string apiVersion, HttpMethod method, string normalizedPath) =>
        ByApiVersion.Value.TryGetValue(apiVersion, out var tables)
        && tables.Suppressions.Contains(Key(method, normalizedPath));

    public static bool TryReplaceName(string apiVersion, HttpMethod method, string normalizedPath, out DerivedName name)
    {
        name = null!;
        return ByApiVersion.Value.TryGetValue(apiVersion, out var tables)
            && tables.Renames.TryGetValue(Key(method, normalizedPath), out name!);
    }

    private static string Key(HttpMethod method, string normalizedPath) => $"{method.Method.ToUpperInvariant()} {normalizedPath}";

    private static Dictionary<string, Tables> Load()
    {
        var result = new Dictionary<string, Tables>(StringComparer.Ordinal);
        var assembly = typeof(DerivedCollisionResolutions).Assembly;
        foreach (var resource in assembly.GetManifestResourceNames())
        {
            // Two derivations share this reader and schema: collision resolutions
            // (Derive-CollisionResolutions.ps1) and full-surface parity resolutions
            // (Derive-ParityResolutions.ps1). Both are oracle-derived, keyed the same way.
            var isDerivedData = resource.Contains(".data.collision-", StringComparison.Ordinal)
                || resource.Contains(".data.parity-", StringComparison.Ordinal);
            if (!isDerivedData || !resource.EndsWith(".json", StringComparison.Ordinal))
                continue;
            using var stream = assembly.GetManifestResourceStream(resource)!;
            var entries = JsonSerializer.Deserialize<List<DataEntry>>(stream, JsonOptions) ?? [];
            foreach (var entry in entries)
            {
                if (!result.TryGetValue(entry.ApiVersion, out var tables))
                    result[entry.ApiVersion] = tables = new Tables(new HashSet<string>(StringComparer.Ordinal), new Dictionary<string, DerivedName>(StringComparer.Ordinal));
                var key = $"{entry.Method.ToUpperInvariant()} {entry.Uri}";
                switch (entry.Action)
                {
                    case "suppress":
                        tables.Suppressions.Add(key);
                        break;
                    case "rename" when !string.IsNullOrEmpty(entry.ReplacementNoun):
                        tables.Renames[key] = new DerivedName(entry.ReplacementNoun, entry.ReplacementVerb);
                        break;
                    default:
                        // A malformed data file must fail the run, not silently generate the
                        // very collision the entry was derived to resolve.
                        throw new InvalidDataException($"{resource}: entry '{key}' has unsupported action '{entry.Action}'.");
                }
            }
        }
        return result;
    }
}
