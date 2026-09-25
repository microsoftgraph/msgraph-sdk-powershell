using System.Collections.Generic;

namespace WrapperGenerator;

public static partial class CmdletConfigurator
{
    private static readonly List<Entry> TeamsCmdletConfigurations =
    [
        // Teams Info-wrapper navs: the wrapped single-entity navigation ships nothing under
        // any root. The suffix matches just the nav node, so shipped siblings
        // (…SharedWithTeamAllowedMember) are unaffected.
        new(OverrideKind.SuppressOperation, Method: null, "/pinnedmessages/{}/message", Match: PathMatch.Suffix, Value: null,
            Reason: "oracle: ships nothing under any root; list side ships (Get-MgChatPinnedMessage)"),
        new(OverrideKind.SuppressOperation, Method: null, "/sharedwithteams/{}/team", Match: PathMatch.Suffix, Value: null,
            Reason: "oracle: ships nothing; sibling /allowedMembers ships, so node-only"),
        new(OverrideKind.SuppressOperation, Method: null, "/associatedteams/{}/team", Match: PathMatch.Suffix, Value: null,
            Reason: "oracle: ships nothing; list side ships (Get-MgUserTeamworkAssociatedTeam)"),
    ];
}
