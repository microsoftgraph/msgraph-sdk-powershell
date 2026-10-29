using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;

namespace WrapperGenerator;

// Matching engine for hand-tuned cmdlet configurations. The cited entries live beside each
// module in src/<Module>/wrapper/<Module>_cmdletConfigurations.cs.
//
// The published Microsoft.Graph names are mostly algorithmic. Module entries cover the rest:
// renames from hand-written AutoRest directives in the msgraph-sdk-powershell module
// configs, and suppressions for spec routes the published SDK ships nothing for.
//
// Add an entry only when the published surface cannot come out of the naming rules, and
// cite the evidence: the directive when one exists, otherwise the shipped-command
// inventory (the oracle, MgCommandMetadata.json).
public static partial class CmdletConfigurator
{
    /// <summary>One reviewed operation behind a public command, selected by existing mandatory path IDs.</summary>
    /// <param name="Method">The HTTP method shared by the group's operations.</param>
    /// <param name="Path">The exact OpenAPI path, including named placeholders.</param>
    /// <param name="FamilyName">A maintainer-chosen label used with the shape to name parameter sets.</param>
    public sealed record OperationVariant(string Method, string Path, string FamilyName);

    /// <summary>Compatible parameter-set variants registered in a module's cmdlet configuration.</summary>
    /// <param name="Routes">The complete reviewed operations sharing one public cmdlet.</param>
    /// <param name="DefaultFamily">The family whose minimal mandatory-ID set supplies the default.</param>
    public sealed record OperationVariantGroup(IReadOnlyList<OperationVariant> Routes, string DefaultFamily);

    internal enum OverrideKind
    {
        SuppressOperation,
        ReplaceNoun,
        StripNounPrefix,
        ReplaceVerb,
        GroupVariants,
    }

    // How Pattern is matched against the normalized path: the full path (Exact), its start
    // (Prefix), or its end (Suffix — for navs that recur under many roots, like
    // .../resourceRoleScopes/{}/scope appearing under several parents).
    internal enum PathMatch
    {
        Exact,
        Prefix,
        Suffix,
    }

    internal sealed record Entry(OverrideKind Kind, HttpMethod? Method, string Pattern, PathMatch Match, string? Value, string Reason,
        OperationVariantGroup? VariantGroup = null);

    // One command's compatible parameter-set variants, not a public endpoint selector.
    internal static Entry GroupVariants(OperationVariantGroup group, string reason) =>
        new(OverrideKind.GroupVariants, null, "", PathMatch.Exact, null, reason, VariantGroup: group);

    internal static IEnumerable<OperationVariantGroup> GetOperationVariantGroups(IReadOnlyList<Entry>? entries = null) =>
        (entries ?? Entries).Where(e => e.Kind == OverrideKind.GroupVariants).Select(e => e.VariantGroup
            ?? throw new InvalidOperationException("GroupVariants entry requires an operation variant group."));

    // NormalizePath lowercases before matching, so a Pattern containing an uppercase letter can
    // never match anything: the entry is silently dead and the override looks applied but is not.
    // Every pre-existing entry happened to be single-word lowercase, so nothing surfaced this
    // until a camelCase path was added. Failing at startup beats debugging a missing rename.
    static CmdletConfigurator()
    {
        var dead = Entries.FindAll(e => e.Pattern != e.Pattern.ToLowerInvariant());
        if (dead.Count > 0)
        {
            throw new InvalidOperationException(
                "CmdletConfigurator pattern(s) contain uppercase and can never match, because paths are " +
                "lowercased before comparison: " + string.Join(", ", dead.ConvertAll(e => e.Pattern)));
        }
    }

    // Static field initialization order is unspecified across partial-class files. Defer
    // aggregation until first use so every module collection has been initialized.
    private static readonly Lazy<List<Entry>> LazyEntries = new(CreateEntries);

    private static List<Entry> Entries => LazyEntries.Value;

    private static List<Entry> CreateEntries() =>
    [
        .. ApplicationsCmdletConfigurations,
        .. BackupRestoreCmdletConfigurations,
        .. BookingsCmdletConfigurations,
        .. BusinessScenarioCmdletConfigurations,
        .. CalendarCmdletConfigurations,
        .. ChangeNotificationsCmdletConfigurations,
        .. CloudCommunicationsCmdletConfigurations,
        .. ComplianceCmdletConfigurations,
        .. ConfigurationManagementCmdletConfigurations,
        .. CrossDeviceExperiencesCmdletConfigurations,
        .. DeviceManagementCmdletConfigurations,
        .. DeviceManagementAdministrationCmdletConfigurations,
        .. DeviceManagementEnrollmentCmdletConfigurations,
        .. DeviceManagementFunctionsCmdletConfigurations,
        .. DevicesCloudPrintCmdletConfigurations,
        .. DevicesCorporateManagementCmdletConfigurations,
        .. DevicesServiceAnnouncementCmdletConfigurations,
        .. DirectoryObjectsCmdletConfigurations,
        .. EducationCmdletConfigurations,
        .. FilesCmdletConfigurations,
        .. FinancialsCmdletConfigurations,
        .. GroupsCmdletConfigurations,
        .. IdentityDirectoryManagementCmdletConfigurations,
        .. IdentityGovernanceCmdletConfigurations,
        .. IdentityPartnerCmdletConfigurations,
        .. IdentitySignInsCmdletConfigurations,
        .. MailCmdletConfigurations,
        .. ManagedTenantsCmdletConfigurations,
        .. MigrationsCmdletConfigurations,
        .. NetworkAccessCmdletConfigurations,
        .. NotesCmdletConfigurations,
        .. PeopleCmdletConfigurations,
        .. PersonalContactsCmdletConfigurations,
        .. PlannerCmdletConfigurations,
        .. ReportsCmdletConfigurations,
        .. SchemaExtensionsCmdletConfigurations,
        .. SearchCmdletConfigurations,
        .. SecurityCmdletConfigurations,
        .. SitesCmdletConfigurations,
        .. TeamsCmdletConfigurations,
        .. UsersCmdletConfigurations,
        .. UsersActionsCmdletConfigurations,
        .. UsersFunctionsCmdletConfigurations,
        .. WindowsUpdatesCmdletConfigurations,
    ];

    [GeneratedRegex(@"\{[^}]*\}")]
    private static partial Regex PathParamRegex();

    // Parameter names are erased before comparing, so "/users/{user-id}/calendar" and
    // "/users/{id}/calendar" both match the "/users/{}/calendar" module entries. A spec-side
    // parameter rename must not silently disable an override.
    // An empty argument list is dropped: the spec spells a zero-argument function
    // "filterOperators()", while the published inventory records the same operation as
    // "/schema/filterOperators" and kiota exposes it as a plain property. Keeping the parentheses
    // made a route key that could never match an oracle-derived entry, so every such function
    // silently kept its structural name instead of its published one.
    private static string NormalizePath(string pathTemplate) =>
        PathParamRegex().Replace(pathTemplate, "{}").Replace("()", "", StringComparison.Ordinal)
            .TrimEnd('/').ToLowerInvariant();

    // The same normalization, for callers that need to report or key by a route rather than
    // match one — the derived data files and the collision diagnostics both use this form, so
    // there is one definition of what a route looks like.
    public static string NormalizePathTemplate(string pathTemplate)
    {
        ArgumentNullException.ThrowIfNull(pathTemplate);
        return NormalizePath(pathTemplate);
    }

    // Authored rules are shared by every ingesting module. Only the generated oracle layer
    // uses the generation run's API version; it is not part of the authored configuration.
    public static bool IsSuppressed(HttpMethod httpMethod, string pathTemplate, GeneratorConfig? config = null,
        string apiVersion = "v1.0")
    {
        ArgumentNullException.ThrowIfNull(httpMethod);
        ArgumentNullException.ThrowIfNull(pathTemplate);
        var path = NormalizePath(pathTemplate);
        if (config is { UseCollisionData: true } && DerivedCollisionResolutions.IsSuppressed(apiVersion, httpMethod, path))
            return true;
        foreach (var entry in Entries)
        {
            if (entry.Kind == OverrideKind.SuppressOperation && Matches(entry, httpMethod, path))
                return true;
        }
        return false;
    }

    // Derived names remain authoritative, including a null verb that keeps the structural
    // default. Otherwise a shared directive may require a curated verb in either profile.
    public static string? TryGetOverriddenVerb(HttpMethod httpMethod, string pathTemplate, GeneratorConfig? config,
        string apiVersion = "v1.0") =>
        TryGetOverriddenVerb(httpMethod, pathTemplate, config, Entries, apiVersion);

    internal static string? TryGetOverriddenVerb(HttpMethod httpMethod, string pathTemplate, GeneratorConfig? config,
        IReadOnlyList<Entry> entries, string apiVersion = "v1.0")
    {
        ArgumentNullException.ThrowIfNull(httpMethod);
        ArgumentNullException.ThrowIfNull(pathTemplate);
        var path = NormalizePath(pathTemplate);
        if (config is { UseCollisionData: true }
            && DerivedCollisionResolutions.TryReplaceName(apiVersion, httpMethod, path, out var derived))
            return derived.Verb;
        foreach (var entry in entries)
        {
            if (entry.Kind == OverrideKind.ReplaceVerb && Matches(entry, httpMethod, path))
                return entry.Value;
        }
        return null;
    }

    public static string ApplyNounOverrides(HttpMethod httpMethod, string pathTemplate, string noun, GeneratorConfig? config = null,
        string apiVersion = "v1.0")
    {
        ArgumentNullException.ThrowIfNull(httpMethod);
        ArgumentNullException.ThrowIfNull(pathTemplate);
        ArgumentNullException.ThrowIfNull(noun);
        var path = NormalizePath(pathTemplate);

        // A derived rename is the published noun verbatim; nothing curated may rewrite it.
        if (config is { UseCollisionData: true } && DerivedCollisionResolutions.TryReplaceName(apiVersion, httpMethod, path, out var derived))
            return derived.Noun;

        // Published BackupRestore cmdlets retain the Solution prefix (for example,
        // Get-MgSolutionBackupRestore). Do not apply /solutions/* strip rules here.
        var skipSolutionStrip = path.StartsWith("/solutions/backuprestore", StringComparison.Ordinal);

        foreach (var entry in Entries)
        {
            if (!Matches(entry, httpMethod, path))
                continue;
            switch (entry.Kind)
            {
                case OverrideKind.ReplaceNoun:
                    return entry.Value!;
                case OverrideKind.StripNounPrefix when skipSolutionStrip:
                    break;
                case OverrideKind.StripNounPrefix when noun.StartsWith(entry.Value!, StringComparison.Ordinal) && noun.Length > entry.Value!.Length:
                    noun = noun[entry.Value!.Length..];
                    break;
            }
        }
        return noun;
    }

    private static bool Matches(Entry entry, HttpMethod httpMethod, string normalizedPath)
    {
        // HttpMethod's own equality is case-insensitive, so no string comparison is needed.
        if (entry.Method is not null && entry.Method != httpMethod)
            return false;
        return entry.Match switch
        {
            PathMatch.Exact => string.Equals(normalizedPath, entry.Pattern, StringComparison.Ordinal),
            PathMatch.Prefix => normalizedPath.StartsWith(entry.Pattern, StringComparison.Ordinal),
            _ => normalizedPath.EndsWith(entry.Pattern, StringComparison.Ordinal),
        };
    }
}
