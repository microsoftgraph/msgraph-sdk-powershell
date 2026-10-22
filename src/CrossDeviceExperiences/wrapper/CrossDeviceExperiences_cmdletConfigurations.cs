using System.Collections.Generic;
using System.Net.Http;
namespace WrapperGenerator;
public static partial class CmdletConfigurator
{
    // The shared operation-ID selector matches neither compatible profile. The adjacent
    // CrossDeviceExperiences_directiveMigrationMap.json records the reviewed absence;
    // do not suppress the distinct live beta registeredOwners/registeredUsers routes.
    private static readonly List<Entry> CrossDeviceExperiencesCmdletConfigurations =
    [
        // Beta has both item and collection reference deletes. Keep both operations,
        // using the published item noun to avoid colliding with the collection noun.
        // These baseline naming repairs are not translations of the absent selector.
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
