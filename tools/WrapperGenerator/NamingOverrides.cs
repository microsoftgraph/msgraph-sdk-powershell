using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.RegularExpressions;

namespace WrapperGenerator;

// Hand-tuned naming exceptions, kept as data with a cited source on every entry.
//
// The published Microsoft.Graph names are mostly algorithmic. Entries here cover the rest:
// renames from hand-written AutoRest directives in the msgraph-sdk-powershell module
// configs, and suppressions for spec routes the published SDK ships nothing for.
//
// Add an entry only when the published surface cannot come out of the naming rules, and
// cite the evidence: the directive when one exists, otherwise the shipped-command
// inventory (the oracle, MgCommandMetadata.json).
public static partial class NamingOverrides
{
    private enum OverrideKind
    {
        SuppressOperation,
        ReplaceNoun,
        StripNounPrefix,
    }

    // How Pattern is matched against the normalized path: the full path (Exact), its start
    // (Prefix), or its end (Suffix — for navs that recur under many roots, like
    // .../resourceRoleScopes/{}/scope appearing under several parents).
    private enum PathMatch
    {
        Exact,
        Prefix,
        Suffix,
    }

    private sealed record Entry(OverrideKind Kind, HttpMethod? Method, string Pattern, PathMatch Match, string? Value, string Reason);

    private static readonly List<Entry> Entries =
    [
        // The SDK ships no Update cmdlet for /users/{id}/calendar. Its pipeline removes the
        // operation outright, in src/Calendar/Calendar.md: remove-path-by-operation
        // user_UpdateCalendar. The wrapper must not invent a cmdlet the SDK chose to drop.
        new(OverrideKind.SuppressOperation, HttpMethod.Patch, "/users/{}/calendar", Match: PathMatch.Exact, Value: null,
            Reason: "Calendar.md remove-path-by-operation user_UpdateCalendar"),

        // GET /users/{id}/calendar ships as Get-MgUserDefaultCalendar, renamed in
        // src/Calendar/Calendar.md: "^(User)(Calendar)$" -> "$1Default$2".
        new(OverrideKind.ReplaceNoun, HttpMethod.Get, "/users/{}/calendar", Match: PathMatch.Exact, Value: "UserDefaultCalendar",
            Reason: "Calendar.md directive renames UserCalendar to UserDefaultCalendar"),

        // The SDK ships no cmdlets for the /solutions root singleton itself (Get-MgSolution /
        // Update-MgSolution do not exist): src/Bookings/Bookings.md removes every solutionsRoot
        // operation with remove-path-by-operation ^solution\.solutionsRoot.*$. Exact-path, all
        // methods, so operations on children like /solutions/bookingBusinesses are unaffected.
        new(OverrideKind.SuppressOperation, Method: null, "/solutions", Match: PathMatch.Exact, Value: null,
            Reason: "Bookings.md remove-path-by-operation ^solution\\.solutionsRoot.*$"),

        // Most nouns under /solutions/ drop the "Solution" prefix (for example
        // Get-MgBookingBusiness, Get-MgVirtualEventWebinar). BackupRestore is a known
        // exception where published cmdlets keep the Solution prefix.
        new(OverrideKind.StripNounPrefix, Method: null, "/solutions/", Match: PathMatch.Prefix, Value: "Solution",
            Reason: "Bookings/VirtualEvents naming pattern under /solutions/*; BackupRestore is explicitly excluded in ApplyNounOverrides"),

        // The spec carries two parallel termStore trees; the shipped surface stitches them:
        // GET/POST come from the /termStores collection (Get-MgSiteTermStore, New-...), while
        // PATCH/DELETE and all 402 descendant command rows come from the /termStore singleton.
        // Nothing ships under /termStores/{id}, and the singleton root GET has no distinct
        // cmdlet — generating either would collide with its shipped twin.
        new(OverrideKind.SuppressOperation, Method: null, "/sites/{}/termstores/{}", Match: PathMatch.Prefix, Value: null,
            Reason: "oracle: zero commands under /termStores/{id}; descendants ship from the /termStore singleton tree"),
        new(OverrideKind.SuppressOperation, HttpMethod.Get, "/sites/{}/termstore", Match: PathMatch.Exact, Value: null,
            Reason: "oracle: Get-MgSiteTermStore serves GET /termStore and /termStores; GET generates from the collection side only"),
        new(OverrideKind.SuppressOperation, Method: null, "/groups/{}/sites/{}/termstores/{}", Match: PathMatch.Prefix, Value: null,
            Reason: "oracle: zero commands under /termStores/{id}; descendants ship from the /termStore singleton tree"),
        new(OverrideKind.SuppressOperation, HttpMethod.Get, "/groups/{}/sites/{}/termstore", Match: PathMatch.Exact, Value: null,
            Reason: "oracle: Get-MgGroupSiteTermStore serves GET /termStore and /termStores; GET generates from the collection side only"),

        // Get-MgUserPhoto serves both /photo and /photos; the /photos routes ship no distinct
        // cmdlet, and generating them would collide with the singleton's noun.
        new(OverrideKind.SuppressOperation, Method: null, "/users/{}/photos", Match: PathMatch.Exact, Value: null,
            Reason: "oracle: Get-MgUserPhoto serves /photo and /photos; the collection ships no distinct cmdlet"),
        new(OverrideKind.SuppressOperation, Method: null, "/users/{}/photos/{}", Match: PathMatch.Exact, Value: null,
            Reason: "oracle: /photos/{} ships nothing; the photo surface is the /photo singleton"),

        // Self-referential /sites: singularizing sites/{id}/sites collapses to the parent's
        // noun, so the sub-sites cmdlets would overwrite Get-MgSite. The SDK ships them
        // renamed: Get-MgSubSite and Get-MgGroupSubSite (v1.0 and beta, incl. $count).
        new(OverrideKind.ReplaceNoun, Method: null, "/sites/{}/sites", Match: PathMatch.Exact, Value: "SubSite",
            Reason: "Sites.md directive; oracle ships Get-MgSubSite for /sites/{site-id}/sites"),
        new(OverrideKind.ReplaceNoun, Method: null, "/sites/{}/sites/{}", Match: PathMatch.Exact, Value: "SubSite",
            Reason: "Sites.md directive; oracle ships Get-MgSubSite for /sites/{site-id}/sites/{site-id1}"),
        new(OverrideKind.ReplaceNoun, Method: null, "/groups/{}/sites/{}/sites", Match: PathMatch.Exact, Value: "GroupSubSite",
            Reason: "Sites.md directive; oracle ships Get-MgGroupSubSite"),
        new(OverrideKind.ReplaceNoun, Method: null, "/groups/{}/sites/{}/sites/{}", Match: PathMatch.Exact, Value: "GroupSubSite",
            Reason: "Sites.md directive; oracle ships Get-MgGroupSubSite"),

        // ---- Collision resolutions from the full-inventory oracle sweep (issue #3704). ----

        // Identity.Governance: agreement file item ops ship only from the /file singleton
        // (Update/Remove-MgAgreementFile); /files/{} items ship nothing, /files/{}/versions does.
        new(OverrideKind.SuppressOperation, Method: null, "/agreements/{}/files/{}", Match: PathMatch.Exact, Value: null,
            Reason: "oracle: /files/{} item ops ship nothing; file surface is the /file singleton (Update/Remove-MgAgreementFile)"),
        new(OverrideKind.SuppressOperation, Method: null, "/identitygovernance/termsofuse/agreements/{}/files/{}", Match: PathMatch.Exact, Value: null,
            Reason: "oracle: ships nothing; mirrors /agreements/{}/files/{} suppression"),
        // GET of the file/files pair ships from the collection (same command on both URIs),
        // like the termStore root stitch; Update/Remove stay on the singleton.
        new(OverrideKind.SuppressOperation, HttpMethod.Get, "/agreements/{}/file", Match: PathMatch.Exact, Value: null,
            Reason: "oracle: Get-MgAgreementFile serves /file and /files; GET generated from the collection side only"),
        new(OverrideKind.SuppressOperation, HttpMethod.Get, "/identitygovernance/termsofuse/agreements/{}/file", Match: PathMatch.Exact, Value: null,
            Reason: "oracle: Get-MgIdentityGovernanceTermsOfUseAgreementFile serves /file and /files; GET from the collection side only"),
        // The /scope node duplicates its parent's noun and ships nothing anywhere; its
        // children ship with the Scope segment elided (…ResourceRoleScopeResource).
        new(OverrideKind.SuppressOperation, Method: null, "/resourcerolescopes/{}/scope", Match: PathMatch.Suffix, Value: null,
            Reason: "oracle: the /scope node ships nothing under any parent; children ship with Scope elided"),
        new(OverrideKind.SuppressOperation, Method: null, "/identitygovernance/entitlementmanagement/assignments/{}/assignmentpolicy", Match: PathMatch.Exact, Value: null,
            Reason: "nav duplicate of /assignmentPolicies (Get-MgEntitlementManagementAssignmentPolicy); ships nothing"),
        new(OverrideKind.SuppressOperation, Method: null, "/identitygovernance/entitlementmanagement/resources/{}/environment", Match: PathMatch.Exact, Value: null,
            Reason: "nav duplicate of /resourceEnvironments (Get-MgEntitlementManagementResourceEnvironment); ships nothing"),
        new(OverrideKind.SuppressOperation, Method: null, "/identitygovernance/lifecycleworkflows", Match: PathMatch.Exact, Value: null,
            Reason: "the container node's own operations ship nothing; its children ship"),
        new(OverrideKind.SuppressOperation, Method: null, "/identitygovernance/termsofuse/agreements/{}/acceptances", Match: PathMatch.Prefix, Value: null,
            Reason: "ships nothing; acceptances ship from /termsOfUse/agreementAcceptances (Get-MgIdentityGovernanceTermsOfUseAgreementAcceptance)"),

        // Security threatIntelligence: nested navs under articles/{} and hosts/{} duplicate
        // the shipped top-level sets (articleIndicators, hostComponents, hostCookies,
        // hostPairs, hostPorts, hostSslCertificates, hostTrackers) and ship nothing
        // themselves. Exact-only: two of these navs have shipped $count children
        // (Get-MgSecurityThreatIntelligenceHost{SslCertificate,Tracker}Count); the other five
        // ship no children at all.
        new(OverrideKind.SuppressOperation, Method: null, "/security/threatintelligence/articles/{}/indicators", Match: PathMatch.Exact, Value: null, Reason: "oracle: ships nothing; top-level articleIndicators ships"),
        new(OverrideKind.SuppressOperation, Method: null, "/security/threatintelligence/articles/{}/indicators/{}", Match: PathMatch.Exact, Value: null, Reason: "oracle: ships nothing; top-level articleIndicators ships"),
        new(OverrideKind.SuppressOperation, Method: null, "/security/threatintelligence/hosts/{}/components", Match: PathMatch.Exact, Value: null, Reason: "oracle: ships nothing; top-level hostComponents ships"),
        new(OverrideKind.SuppressOperation, Method: null, "/security/threatintelligence/hosts/{}/components/{}", Match: PathMatch.Exact, Value: null, Reason: "oracle: ships nothing; top-level hostComponents ships"),
        new(OverrideKind.SuppressOperation, Method: null, "/security/threatintelligence/hosts/{}/cookies", Match: PathMatch.Exact, Value: null, Reason: "oracle: ships nothing; top-level hostCookies ships"),
        new(OverrideKind.SuppressOperation, Method: null, "/security/threatintelligence/hosts/{}/cookies/{}", Match: PathMatch.Exact, Value: null, Reason: "oracle: ships nothing; top-level hostCookies ships"),
        new(OverrideKind.SuppressOperation, Method: null, "/security/threatintelligence/hosts/{}/hostpairs", Match: PathMatch.Exact, Value: null, Reason: "oracle: ships nothing; top-level hostPairs ships"),
        new(OverrideKind.SuppressOperation, Method: null, "/security/threatintelligence/hosts/{}/hostpairs/{}", Match: PathMatch.Exact, Value: null, Reason: "oracle: ships nothing; top-level hostPairs ships"),
        new(OverrideKind.SuppressOperation, Method: null, "/security/threatintelligence/hosts/{}/ports", Match: PathMatch.Exact, Value: null, Reason: "oracle: ships nothing; top-level hostPorts ships"),
        new(OverrideKind.SuppressOperation, Method: null, "/security/threatintelligence/hosts/{}/ports/{}", Match: PathMatch.Exact, Value: null, Reason: "oracle: ships nothing; top-level hostPorts ships"),
        new(OverrideKind.SuppressOperation, Method: null, "/security/threatintelligence/hosts/{}/sslcertificates", Match: PathMatch.Exact, Value: null, Reason: "oracle: ships nothing; top-level hostSslCertificates ships"),
        new(OverrideKind.SuppressOperation, Method: null, "/security/threatintelligence/hosts/{}/sslcertificates/{}", Match: PathMatch.Exact, Value: null, Reason: "oracle: ships nothing; top-level hostSslCertificates ships"),
        new(OverrideKind.SuppressOperation, Method: null, "/security/threatintelligence/hosts/{}/trackers", Match: PathMatch.Exact, Value: null, Reason: "oracle: ships nothing; top-level hostTrackers ships"),
        new(OverrideKind.SuppressOperation, Method: null, "/security/threatintelligence/hosts/{}/trackers/{}", Match: PathMatch.Exact, Value: null, Reason: "oracle: ships nothing; top-level hostTrackers ships"),
        // The attackSimulation container node itself ships nothing; children under a
        // simulation item ship nothing either (the list/item pair then merges normally).
        new(OverrideKind.SuppressOperation, Method: null, "/security/attacksimulation", Match: PathMatch.Exact, Value: null,
            Reason: "oracle: the container node ships nothing; its child collections ship"),
        new(OverrideKind.SuppressOperation, Method: null, "/security/attacksimulation/simulations/{}/", Match: PathMatch.Prefix, Value: null,
            Reason: "oracle: nothing under a simulation item ships in v1.0"),

        // Calendar: the shipped default-calendar surface. Events under a NAMED calendar and
        // the default-calendar event item tree ship nothing; event items ship from
        // /users/{}/events (Get-MgUserEvent family).
        new(OverrideKind.ReplaceNoun, Method: null, "/users/{}/calendar/events", Match: PathMatch.Exact, Value: "UserDefaultCalendarEvent",
            Reason: "oracle: list/create ship as Get/New-MgUserDefaultCalendarEvent"),
        new(OverrideKind.SuppressOperation, Method: null, "/users/{}/calendar/events/{}", Match: PathMatch.Prefix, Value: null,
            Reason: "oracle: default-calendar event items ship nothing; items ship from /users/{}/events/{}"),
        new(OverrideKind.SuppressOperation, Method: null, "/users/{}/calendars/{}/events/{}", Match: PathMatch.Prefix, Value: null,
            Reason: "oracle: named-calendar event items ship nothing; items ship from /users/{}/events/{}"),
        new(OverrideKind.SuppressOperation, Method: null, "/users/{}/calendars/{}/calendarpermissions", Match: PathMatch.Prefix, Value: null,
            Reason: "oracle: permissions ship only from the default calendar (Get-MgUserCalendarPermission on /users/{}/calendar/calendarPermissions)"),

        // Teams Info-wrapper navs: the wrapped single-entity navigation ships nothing under
        // any root. The suffix matches just the nav node, so shipped siblings
        // (…SharedWithTeamAllowedMember) are unaffected.
        new(OverrideKind.SuppressOperation, Method: null, "/pinnedmessages/{}/message", Match: PathMatch.Suffix, Value: null,
            Reason: "oracle: ships nothing under any root; list side ships (Get-MgChatPinnedMessage)"),
        new(OverrideKind.SuppressOperation, Method: null, "/sharedwithteams/{}/team", Match: PathMatch.Suffix, Value: null,
            Reason: "oracle: ships nothing; sibling /allowedMembers ships, so node-only"),
        new(OverrideKind.SuppressOperation, Method: null, "/associatedteams/{}/team", Match: PathMatch.Suffix, Value: null,
            Reason: "oracle: ships nothing; list side ships (Get-MgUserTeamworkAssociatedTeam)"),

        // Groups: the nested lifecycle-policies GET ships renamed; everything else on that
        // route ships from the top-level set. Photos items ship nothing (singleton /photo).
        new(OverrideKind.ReplaceNoun, HttpMethod.Get, "/groups/{}/grouplifecyclepolicies", Match: PathMatch.Exact, Value: "GroupLifecyclePolicyByGroup",
            Reason: "Groups.md directive (subject $1ByGroup); oracle ships Get-MgGroupLifecyclePolicyByGroup"),
        new(OverrideKind.SuppressOperation, Method: null, "/groups/{}/grouplifecyclepolicies/", Match: PathMatch.Prefix, Value: null,
            Reason: "oracle: item/children under the nested route ship nothing; the set ships top-level"),
        new(OverrideKind.SuppressOperation, Method: null, "/groups/{}/photos/{}", Match: PathMatch.Exact, Value: null,
            Reason: "oracle: photos items ship nothing; shipped surface is the /photo singleton (Get-MgGroupPhoto)"),

        // Small-module resolutions.
        new(OverrideKind.SuppressOperation, Method: null, "/solutions/virtualevents", Match: PathMatch.Exact, Value: null,
            Reason: "oracle: the virtualEvents root node ships nothing; children ship (Get-MgVirtualEventWebinar)"),
        new(OverrideKind.SuppressOperation, Method: null, "/replies/{}/replyto", Match: PathMatch.Suffix, Value: null,
            Reason: "oracle: the replyTo nav ships nothing under any root"),
        new(OverrideKind.SuppressOperation, Method: null, "/deviceappmanagement/mobileapps/{}/categories", Match: PathMatch.Prefix, Value: null,
            Reason: "oracle: nested app categories ship nothing; the set ships top-level (mobileAppCategories)"),
        new(OverrideKind.SuppressOperation, Method: null, "/education/classes/{}/assignments/{}/categories", Match: PathMatch.Exact, Value: null,
            Reason: "oracle: the plain path ships nothing; the shipped surface is the $ref route"),
        new(OverrideKind.SuppressOperation, Method: null, "/education/users/{}/user", Match: PathMatch.Exact, Value: null,
            Reason: "oracle: the user self-nav node ships nothing; its children (mailboxSettings) ship"),
        new(OverrideKind.ReplaceNoun, HttpMethod.Get, "/groups/{}/drive", Match: PathMatch.Exact, Value: "GroupDefaultDrive",
            Reason: "Files.md directive (subject $1Default$2); oracle ships Get-MgGroupDefaultDrive"),
        new(OverrideKind.ReplaceNoun, HttpMethod.Get, "/users/{}/drive", Match: PathMatch.Exact, Value: "UserDefaultDrive",
            Reason: "Files.md directive (subject $1Default$2); oracle ships Get-MgUserDefaultDrive"),
        new(OverrideKind.ReplaceNoun, HttpMethod.Get, "/sites/{}/drive", Match: PathMatch.Exact, Value: "SiteDefaultDrive",
            Reason: "oracle ships Get-MgSiteDefaultDrive for the site default-drive singleton"),
        new(OverrideKind.ReplaceNoun, HttpMethod.Get, "/groups/{}/sites/{}/drive", Match: PathMatch.Exact, Value: "GroupSiteDefaultDrive",
            Reason: "oracle ships Get-MgGroupSiteDefaultDrive"),
        new(OverrideKind.SuppressOperation, HttpMethod.Get, "/shares/{}/list/items/{}", Match: PathMatch.Exact, Value: null,
            Reason: "oracle: the bare shared-list item GET ships nothing; its descendants ship"),
        new(OverrideKind.SuppressOperation, Method: null, "/identityproviders", Match: PathMatch.Prefix, Value: null,
            Reason: "oracle: the deprecated top-level /identityProviders set ships nothing in v1.0; shipped surface is /identity/identityProviders (Get-MgIdentityProvider)"),
    ];

    [GeneratedRegex(@"\{[^}]*\}")]
    private static partial Regex PathParamRegex();

    // Parameter names are erased before comparing, so "/users/{user-id}/calendar" and
    // "/users/{id}/calendar" both match the "/users/{}/calendar" entries above. A spec-side
    // parameter rename must not silently disable an override.
    private static string NormalizePath(string pathTemplate) =>
        PathParamRegex().Replace(pathTemplate, "{}").TrimEnd('/').ToLowerInvariant();

    // config carries the API version the derived collision data is keyed by; null (the unit
    // tests' default) applies only the curated entries below, so a data-file change can never
    // silently shift a pinned naming expectation.
    public static bool IsSuppressed(HttpMethod httpMethod, string pathTemplate, GeneratorConfig? config = null)
    {
        ArgumentNullException.ThrowIfNull(httpMethod);
        ArgumentNullException.ThrowIfNull(pathTemplate);
        var path = NormalizePath(pathTemplate);
        if (config is { UseCollisionData: true } && DerivedCollisionResolutions.IsSuppressed(config.ApiVersion, httpMethod, path))
            return true;
        foreach (var entry in Entries)
        {
            if (entry.Kind == OverrideKind.SuppressOperation && Matches(entry, httpMethod, path))
                return true;
        }
        return false;
    }

    public static string ApplyNounOverrides(HttpMethod httpMethod, string pathTemplate, string noun, GeneratorConfig? config = null)
    {
        ArgumentNullException.ThrowIfNull(httpMethod);
        ArgumentNullException.ThrowIfNull(pathTemplate);
        ArgumentNullException.ThrowIfNull(noun);
        var path = NormalizePath(pathTemplate);

        // A derived rename is the published noun verbatim; nothing curated may rewrite it.
        if (config is { UseCollisionData: true } && DerivedCollisionResolutions.TryReplaceNoun(config.ApiVersion, httpMethod, path, out var derivedNoun))
            return derivedNoun;

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
