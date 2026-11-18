using System.Collections.Generic;
using System.Net.Http;

namespace WrapperGenerator;

public static partial class CmdletConfigurator
{
    private static readonly List<Entry> UsersActionsCmdletConfigurations =
    [
        // Shared directives 2 and 8: v1.0 already has authoritative derived names;
        // these fallbacks also preserve the shared behavior in beta.
        new(OverrideKind.ReplaceNoun, HttpMethod.Post, "/users/{}/removealldevicesfrommanagement", PathMatch.Exact,
            "AllUserDeviceFromManagement", "Users.Actions.md directive 2; Remove-Mg[Beta]AllUserDeviceFromManagement"),
        new(OverrideKind.ReplaceVerb, HttpMethod.Post, "/users/{}/removealldevicesfrommanagement", PathMatch.Exact,
            "Remove", "Users.Actions.md directive 2; this POST action is published with Remove"),
        new(OverrideKind.ReplaceNoun, HttpMethod.Post, "/users/{}/invalidateallrefreshtokens", PathMatch.Exact,
            "InvalidateAllUserRefreshToken", "Users.Actions.md directive 3; beta action retains All"),
        new(OverrideKind.ReplaceNoun, HttpMethod.Post, "/users/getuserownedobjects", PathMatch.Exact,
            "UserOwnedObjectByType", "Users.Actions.md directive 4; beta collection-bound action"),
        new(OverrideKind.ReplaceVerb, HttpMethod.Post, "/users/getuserownedobjects", PathMatch.Exact,
            "Get", "Users.Actions.md directive 4; POST action is published as Get-MgBetaUserOwnedObjectByType"),
        new(OverrideKind.ReplaceNoun, HttpMethod.Post, "/users/{}/changepassword", PathMatch.Exact,
            "UserPassword", "Users.Actions.md directive 8; Update-Mg[Beta]UserPassword"),
        new(OverrideKind.ReplaceVerb, HttpMethod.Post, "/users/{}/changepassword", PathMatch.Exact,
            "Update", "Users.Actions.md directive 8; preserve the shared Rename-to-Update directive"),
    ];
}
