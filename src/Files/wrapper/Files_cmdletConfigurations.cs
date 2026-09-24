using System.Collections.Generic;
using System.Net.Http;

namespace WrapperGenerator;

public static partial class CmdletConfigurator
{
    private static readonly List<Entry> FilesCmdletConfigurations =
    [
        new(OverrideKind.ReplaceNoun, HttpMethod.Get, "/groups/{}/drive", Match: PathMatch.Exact, Value: "GroupDefaultDrive",
            Reason: "Files.md directive (subject $1Default$2); oracle ships Get-MgGroupDefaultDrive"),
        new(OverrideKind.ReplaceNoun, HttpMethod.Get, "/users/{}/drive", Match: PathMatch.Exact, Value: "UserDefaultDrive",
            Reason: "Files.md directive (subject $1Default$2); oracle ships Get-MgUserDefaultDrive"),
        new(OverrideKind.ReplaceNoun, HttpMethod.Get, "/sites/{}/drive", Match: PathMatch.Exact, Value: "SiteDefaultDrive",
            Reason: "oracle ships Get-MgSiteDefaultDrive for the site default-drive singleton"),
        new(OverrideKind.ReplaceNoun, HttpMethod.Get, "/groups/{}/sites/{}/drive", Match: PathMatch.Exact, Value: "GroupSiteDefaultDrive",
            Reason: "oracle ships Get-MgGroupSiteDefaultDrive"),
        new(OverrideKind.SuppressOperation, HttpMethod.Get, "/shares/{}/list/items/{}", Match: PathMatch.Exact, Value: null,
            Reason: "oracle: the bare shared-list item GET ships nothing; its descendants ship"),
    ];
}
