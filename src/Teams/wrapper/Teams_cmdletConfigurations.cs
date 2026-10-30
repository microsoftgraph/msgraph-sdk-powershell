using System.Collections.Generic;
using System.Net.Http;

namespace WrapperGenerator;

public static partial class CmdletConfigurator
{
    private static readonly List<Entry> TeamsCmdletConfigurations = CreateTeamsCmdletConfigurations();

    private static List<Entry> CreateTeamsCmdletConfigurations()
    {
        List<Entry> entries =
        [
            // Existing Info-wrapper nav suppressions leave shipped siblings unaffected.
            new(OverrideKind.SuppressOperation, Method: null, "/pinnedmessages/{}/message", Match: PathMatch.Suffix, Value: null,
                Reason: "oracle: ships nothing under any root; list side ships (Get-MgChatPinnedMessage)"),
            new(OverrideKind.SuppressOperation, Method: null, "/sharedwithteams/{}/team", Match: PathMatch.Suffix, Value: null,
                Reason: "oracle: ships nothing; sibling /allowedMembers ships, so node-only"),
            new(OverrideKind.SuppressOperation, Method: null, "/associatedteams/{}/team", Match: PathMatch.Suffix, Value: null,
                Reason: "oracle: ships nothing; list side ships (Get-MgUserTeamworkAssociatedTeam)"),
            // user_ListJoinedTeam is outside directive 1; user.joinedTeam_GetCount is inside it.
            new(OverrideKind.SuppressOperation, HttpMethod.Get, "/teams/{}/group", PathMatch.Exact, null, "Teams.md directive 1: team_GetGroup"),
            new(OverrideKind.SuppressOperation, HttpMethod.Post, "/users/{}/joinedteams", PathMatch.Exact, null, "Teams.md directive 1: user_CreateJoinedTeam"),
            new(OverrideKind.SuppressOperation, null, "/users/{}/joinedteams/{}", PathMatch.Exact, null, "Teams.md directive 1: user_(Get|Update|Delete)JoinedTeam"),
            new(OverrideKind.SuppressOperation, HttpMethod.Get, "/users/{}/joinedteams/$count", PathMatch.Exact, null, "Teams.md directive 1: user.joinedTeam_GetCount"),
            new(OverrideKind.SuppressOperation, null, "/users/{}/joinedteams/{}/", PathMatch.Prefix, null, "Teams.md directive 1: user.joinedTeam.*"),
            new(OverrideKind.SuppressOperation, HttpMethod.Get, "/users/{}/joinedteams/getallmessages", PathMatch.Exact, null, "Teams.md directive 1: user.joinedTeam_getAllMessage"),
            // The suffix in directive 5 is [A-Z]*, not .*: descendants with mixed-case nouns remain.
            new(OverrideKind.SuppressOperation, null, "/teamwork/teamtemplates/{}/definitions/{}/teamdefinition", PathMatch.Exact, null, "Teams.md directive 5: exact TeamDefinition subject, not its subtree"),
        ];

        foreach (var root in new[]
        {
            "/chats/{}", "/groups/{}/team", "/teams/{}",
            "/users/{}/chats/{}", "/users/{}/joinedteams/{}", "/users/{}/teamwork",
            "/teamwork/teamtemplates/{}/definitions/{}/teamdefinition",
        })
            entries.Add(new(OverrideKind.SuppressOperation, HttpMethod.Patch, root + "/installedapps/{}", PathMatch.Exact, null,
                "Teams.md directive 1: *_UpdateInstalledApp; preserve GET/POST/DELETE and upgrade action"));

        foreach (var root in new[] { "/chats/{}", "/teams/{}/channels/{}", "/teams/{}/primarychannel" })
        {
            entries.Add(new(OverrideKind.SuppressOperation, HttpMethod.Delete, root + "/messages/{}", PathMatch.Exact, null,
                "Teams.md directive 2: Remove (Chat|TeamChannel|TeamPrimaryChannel)Message"));
            entries.Add(new(OverrideKind.SuppressOperation, HttpMethod.Delete, root + "/messages/{}/replies/{}", PathMatch.Exact, null,
                "Teams.md directive 3: Remove (Chat|TeamChannel|TeamPrimaryChannel)MessageReply"));
            foreach (var method in new[] { HttpMethod.Patch, HttpMethod.Delete })
                entries.Add(new(OverrideKind.SuppressOperation, method, root + "/messages/{}/hostedcontents/{}", PathMatch.Exact, null,
                    "Teams.md directive 4: Remove|Update direct MessageHostedContent, not reply hosted content"));
        }

        foreach (var (path, noun) in new[]
        {
            ("/teams/getallmessages", "AllTeamMessage"),
            ("/teamwork/deletedteams/getallmessages", "AllTeamworkDeletedTeamMessage"),
            ("/teams/{}/allchannels", "AllTeamChannel"),
            ("/teams/{}/allchannels/{}", "AllTeamChannel"),
            ("/groups/{}/team/allchannels", "AllGroupTeamChannel"),
            ("/groups/{}/team/allchannels/{}", "AllGroupTeamChannel"),
            ("/teams/{}/allchannels/$count", "AllTeamChannelCount"),
            ("/groups/{}/team/allchannels/$count", "AllGroupTeamChannelCount"),
            ("/users/{}/chats/{}/messages", "AllUserChatMessage"),
            ("/users/{}/chats/{}/messages/{}", "AllUserChatMessage"),
            ("/users/{}/chats/getallmessages", "AllUserChatMessageAcrossChat"),
        })
            entries.Add(new(OverrideKind.ReplaceNoun, HttpMethod.Get, path, PathMatch.Exact, noun,
                "Teams.md directives 6-9: All subject renames; v1.0 derived names remain authoritative, beta needs curated coverage"));

        return entries;
    }
}
