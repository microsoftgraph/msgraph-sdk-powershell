using System.Collections.Generic;
using System.Net.Http;
namespace WrapperGenerator;
public static partial class CmdletConfigurator
{
    // Both aligned beta literal matches equal the actual legacy method/path survivor
    // set. The adjacent ledger and tests pin this; v1.0 has no source matches.
    private static readonly List<Entry> CrossDeviceExperiencesCmdletConfigurations =
    [
        new(OverrideKind.SuppressOperation, HttpMethod.Delete,
            "/users/{}/devices/{}/registeredowners/$ref", PathMatch.Exact, null,
            "CrossDeviceExperiences.md: user.device_DeleteRegisteredOwnerGraphBPreRef, the aligned literal match and exact legacy survivor."),
        new(OverrideKind.SuppressOperation, HttpMethod.Delete,
            "/users/{}/devices/{}/registeredusers/$ref", PathMatch.Exact, null,
            "CrossDeviceExperiences.md: user.device_DeleteRegisteredUserGraphBPreRef, the aligned literal match and exact legacy survivor."),
        // Independent published item nouns; the shared selector suppresses collection
        // deletes only, not these item-reference operations.
        new(OverrideKind.ReplaceNoun, HttpMethod.Delete,
            "/users/{}/devices/{}/registeredowners/{}/$ref", PathMatch.Exact,
            "UserDeviceRegisteredOwnerDirectoryObjectByRef",
            "Beta user.device.registeredOwner_DeleteDirectoryObjectGraphBPreRef: oracle Remove-MgBetaUserDeviceRegisteredOwnerDirectoryObjectByRef."),
        new(OverrideKind.ReplaceNoun, HttpMethod.Delete,
            "/users/{}/devices/{}/registeredusers/{}/$ref", PathMatch.Exact,
            "UserDeviceRegisteredUserDirectoryObjectByRef",
            "Beta user.device.registeredUser_DeleteDirectoryObjectGraphBPreRef: oracle Remove-MgBetaUserDeviceRegisteredUserDirectoryObjectByRef."),
    ];
}
