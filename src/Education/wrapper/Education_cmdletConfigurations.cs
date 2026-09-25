using System.Collections.Generic;

namespace WrapperGenerator;

public static partial class CmdletConfigurator
{
    private static readonly List<Entry> EducationCmdletConfigurations =
    [
        new(OverrideKind.SuppressOperation, Method: null, "/education/classes/{}/assignments/{}/categories", Match: PathMatch.Exact, Value: null,
            Reason: "oracle: the plain path ships nothing; the shipped surface is the $ref route"),
        new(OverrideKind.SuppressOperation, Method: null, "/education/users/{}/user", Match: PathMatch.Exact, Value: null,
            Reason: "oracle: the user self-nav node ships nothing; its children (mailboxSettings) ship"),
    ];
}
