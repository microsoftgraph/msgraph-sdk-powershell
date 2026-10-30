using System.Collections.Generic;
using System.Net.Http;

namespace WrapperGenerator;

public static partial class CmdletConfigurator
{
    private static readonly List<Entry> IdentityDirectoryManagementCmdletConfigurations =
    [
        // Shared Identity.DirectoryManagement.md groups 2-3 remove only the untyped list/count.
        new(OverrideKind.SuppressOperation, HttpMethod.Get, "/directory/deleteditems", PathMatch.Exact, null,
            Reason: "shared directive: Get DirectoryDeletedItem List"),
        new(OverrideKind.SuppressOperation, HttpMethod.Get, "/directory/deleteditems/$count", PathMatch.Exact, null,
            Reason: "shared directive: Get DirectoryDeletedItemCount"),

        // Group 11 keeps the item-addressed reference deletes, not the legacy collection variants.
        // v1.0 derived collision data already agrees; these also cover beta and structural-only runs.
        new(OverrideKind.SuppressOperation, HttpMethod.Delete, "/devices/{}/registeredowners/$ref", PathMatch.Exact, null,
            Reason: "shared directive: device_DeleteRegisteredOwnerGraphBPreRef"),
        new(OverrideKind.SuppressOperation, HttpMethod.Delete, "/devices/{}/registeredusers/$ref", PathMatch.Exact, null,
            Reason: "shared directive: device_DeleteRegisteredUserGraphBPreRef"),
        new(OverrideKind.SuppressOperation, HttpMethod.Delete, "/directory/administrativeunits/{}/members/$ref", PathMatch.Exact, null,
            Reason: "shared directive: directory.administrativeUnit_DeleteMemberGraphBPreRef"),
        new(OverrideKind.SuppressOperation, HttpMethod.Delete, "/directoryroles/{}/members/$ref", PathMatch.Exact, null,
            Reason: "shared directive: directoryRole_DeleteMemberGraphBPreRef"),

        // Group 7 renames the beta setting entity, but not SettingCount or nested resources.
        new(OverrideKind.ReplaceNoun, Method: null, "/settings", PathMatch.Exact, "DirectorySetting",
            Reason: "shared directive: SettingDirectorySetting -> DirectorySetting"),
        new(OverrideKind.ReplaceNoun, Method: null, "/settings/{}", PathMatch.Exact, "DirectorySetting",
            Reason: "shared directive: SettingDirectorySetting -> DirectorySetting"),

        // These distinct operations have incompatible bodies/results, not natural-ID variants.
        new(OverrideKind.ReplaceNoun, HttpMethod.Post, "/directory/impactedresources/addtag", PathMatch.Exact,
            "DirectoryImpactedResourceAddTagByResourceId",
            Reason: "collection addTag takes resourceIds[] and returns impactedResources; item addTag returns a recommendationTag"),
        new(OverrideKind.ReplaceNoun, HttpMethod.Post, "/directory/impactedresources/removetag", PathMatch.Exact,
            "DirectoryImpactedResourceRemoveTagByDisplayName",
            Reason: "collection removeTag takes displayName and resourceIds[]; item removeTag takes tagId"),
        new(OverrideKind.ReplaceNoun, HttpMethod.Post, "/directory/recommendations/{}/impactedresources/addtag", PathMatch.Exact,
            "DirectoryRecommendationImpactedResourceAddTagByResourceId",
            Reason: "recommendation collection addTag takes resourceIds[] and returns impactedResources"),
        new(OverrideKind.ReplaceNoun, HttpMethod.Post, "/directory/recommendations/{}/impactedresources/removetag", PathMatch.Exact,
            "DirectoryRecommendationImpactedResourceRemoveTagByDisplayName",
            Reason: "recommendation collection removeTag takes displayName and resourceIds[] rather than an item tagId"),
        new(OverrideKind.ReplaceNoun, HttpMethod.Delete, "/administrativeunits/{}/members/$ref", PathMatch.Exact,
            "AdministrativeUnitMemberReferenceByUri",
            Reason: "collection reference delete requires query @id (the delete Uri); item reference delete requires DirectoryObjectId"),

        // ---- Naming-parity sweep (2026-08-13): one of the two rules proved safe. ----
        //
        // Both safe rules were measured against the whole corpus first: each fixes real
        // mismatches and rewrites no currently-matching name. Every other candidate rule from
        // that sweep broke more names than it fixed (dropping "IdentityGovernance" would have
        // fixed 297 and broken 417), so the rest await oracle-derived naming.

        // "people" is singularized everywhere else and correctly so - /users/{}/people ships as
        // Get-MgUserPerson. Under /admin/people the published SDK keeps the plural, so this is
        // scoped per path rather than by making "people" invariant, which would break UserPerson.
        new(OverrideKind.ReplaceNoun, Method: null, "/admin/people", Match: PathMatch.Exact, Value: "AdminPeople",
            Reason: "oracle ships Get-MgAdminPeople; /admin/people keeps the plural"),
        new(OverrideKind.ReplaceNoun, Method: null, "/admin/people/iteminsights", Match: PathMatch.Exact, Value: "AdminPeopleItemInsight",
            Reason: "oracle ships Get-MgAdminPeopleItemInsight"),
        new(OverrideKind.ReplaceNoun, Method: null, "/admin/people/profilecardproperties", Match: PathMatch.Exact, Value: "AdminPeopleProfileCardProperty",
            Reason: "oracle ships Get-MgAdminPeopleProfileCardProperty"),
        new(OverrideKind.ReplaceNoun, Method: null, "/admin/people/profilecardproperties/{}", Match: PathMatch.Exact, Value: "AdminPeopleProfileCardProperty",
            Reason: "oracle ships Get-MgAdminPeopleProfileCardProperty"),
        new(OverrideKind.ReplaceNoun, Method: null, "/admin/people/profilepropertysettings", Match: PathMatch.Exact, Value: "AdminPeopleProfilePropertySetting",
            Reason: "oracle ships Get-MgAdminPeopleProfilePropertySetting"),
        new(OverrideKind.ReplaceNoun, Method: null, "/admin/people/profilepropertysettings/{}", Match: PathMatch.Exact, Value: "AdminPeopleProfilePropertySetting",
            Reason: "oracle ships Get-MgAdminPeopleProfilePropertySetting"),
        new(OverrideKind.ReplaceNoun, Method: null, "/admin/people/profilesources", Match: PathMatch.Exact, Value: "AdminPeopleProfileSource",
            Reason: "oracle ships Get-MgAdminPeopleProfileSource"),
        new(OverrideKind.ReplaceNoun, Method: null, "/admin/people/profilesources/{}", Match: PathMatch.Exact, Value: "AdminPeopleProfileSource",
            Reason: "oracle ships Get-MgAdminPeopleProfileSource"),
        new(OverrideKind.ReplaceNoun, Method: null, "/admin/people/pronouns", Match: PathMatch.Exact, Value: "AdminPeoplePronoun",
            Reason: "oracle ships Get-MgAdminPeoplePronoun"),
    ];
}
