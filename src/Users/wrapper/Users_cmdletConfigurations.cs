using System.Collections.Generic;

namespace WrapperGenerator;

public static partial class CmdletConfigurator
{
    private static readonly List<Entry> UsersCmdletConfigurations =
    [
        // Get-MgUserPhoto serves both /photo and /photos; the /photos routes ship no distinct
        // cmdlet, and generating them would collide with the singleton's noun.
        new(OverrideKind.SuppressOperation, Method: null, "/users/{}/photos", Match: PathMatch.Exact, Value: null,
            Reason: "oracle: Get-MgUserPhoto serves /photo and /photos; the collection ships no distinct cmdlet"),
        new(OverrideKind.SuppressOperation, Method: null, "/users/{}/photos/{}", Match: PathMatch.Exact, Value: null,
            Reason: "oracle: /photos/{} ships nothing; the photo surface is the /photo singleton"),
    ];
}
