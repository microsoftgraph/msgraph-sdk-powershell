using System.Collections.Generic;
using System.Net.Http;
namespace WrapperGenerator;
public static partial class CmdletConfigurator
{
    // The adjacent migration ledger bridges both actual legacy beta selector matches
    // to unchanged method/path pairs with converted IDs. v1.0 has no source matches.
    private static readonly List<Entry> CrossDeviceExperiencesCmdletConfigurations =
    [
        new(OverrideKind.SuppressOperation, HttpMethod.Delete,
            "/users/{}/devices/{}/registeredowners/$ref", PathMatch.Exact, null,
            "CrossDeviceExperiences.md: user.device_DeleteRegisteredOwnerGraphBPreRef survives as users.devices.DeleteRefRegisteredOwners."),
        new(OverrideKind.SuppressOperation, HttpMethod.Delete,
            "/users/{}/devices/{}/registeredusers/$ref", PathMatch.Exact, null,
            "CrossDeviceExperiences.md: user.device_DeleteRegisteredUserGraphBPreRef survives as users.devices.DeleteRefRegisteredUsers."),
        // Independent published item nouns; the shared selector suppresses collection
        // deletes only, not these item-reference operations.
        new(OverrideKind.ReplaceNoun, HttpMethod.Delete,
            "/users/{}/devices/{}/registeredowners/{}/$ref", PathMatch.Exact,
            "UserDeviceRegisteredOwnerDirectoryObjectByRef",
            "Beta users.devices.registeredOwners.DeleteRefDirectoryObject: oracle Remove-MgBetaUserDeviceRegisteredOwnerDirectoryObjectByRef."),
        new(OverrideKind.ReplaceNoun, HttpMethod.Delete,
            "/users/{}/devices/{}/registeredusers/{}/$ref", PathMatch.Exact,
            "UserDeviceRegisteredUserDirectoryObjectByRef",
            "Beta users.devices.registeredUsers.DeleteRefDirectoryObject: oracle Remove-MgBetaUserDeviceRegisteredUserDirectoryObjectByRef."),
    ];
}
