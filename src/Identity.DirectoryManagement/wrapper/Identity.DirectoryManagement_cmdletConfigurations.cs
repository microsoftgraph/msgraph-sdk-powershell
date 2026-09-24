using System.Collections.Generic;

namespace WrapperGenerator;

public static partial class CmdletConfigurator
{
    private static readonly List<Entry> IdentityDirectoryManagementCmdletConfigurations =
    [
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
