using System.Collections.Generic;
using System.Net.Http;

namespace WrapperGenerator;

public static partial class CmdletConfigurator
{
    private static readonly List<Entry> SitesCmdletConfigurations =
    [
        // The spec carries two parallel termStore trees; the shipped surface stitches them:
        // GET/POST come from the /termStores collection (Get-MgSiteTermStore, New-...), while
        // PATCH/DELETE and all 402 descendant command rows come from the /termStore singleton.
        // Nothing ships under /termStores/{id}, and the singleton root GET has no distinct
        // cmdlet — generating either would collide with its shipped twin.
        new(OverrideKind.SuppressOperation, Method: null, "/sites/{}/termstores/{}", Match: PathMatch.Prefix, Value: null,
            Reason: "oracle: zero commands under /termStores/{id}; descendants ship from the /termStore singleton tree"),
        new(OverrideKind.SuppressOperation, HttpMethod.Get, "/sites/{}/termstore", Match: PathMatch.Exact, Value: null,
            Reason: "oracle: Get-MgSiteTermStore serves GET /termStore and /termStores; GET generates from the collection side only"),
        new(OverrideKind.SuppressOperation, Method: null, "/groups/{}/sites/{}/termstores/{}", Match: PathMatch.Prefix, Value: null,
            Reason: "oracle: zero commands under /termStores/{id}; descendants ship from the /termStore singleton tree"),
        new(OverrideKind.SuppressOperation, HttpMethod.Get, "/groups/{}/sites/{}/termstore", Match: PathMatch.Exact, Value: null,
            Reason: "oracle: Get-MgGroupSiteTermStore serves GET /termStore and /termStores; GET generates from the collection side only"),

        // Self-referential /sites: singularizing sites/{id}/sites collapses to the parent's
        // noun, so the sub-sites cmdlets would overwrite Get-MgSite. The SDK ships them
        // renamed: Get-MgSubSite and Get-MgGroupSubSite (v1.0 and beta, incl. $count).
        new(OverrideKind.ReplaceNoun, Method: null, "/sites/{}/sites", Match: PathMatch.Exact, Value: "SubSite",
            Reason: "Sites.md directive; oracle ships Get-MgSubSite for /sites/{site-id}/sites"),
        new(OverrideKind.ReplaceNoun, Method: null, "/sites/{}/sites/{}", Match: PathMatch.Exact, Value: "SubSite",
            Reason: "Sites.md directive; oracle ships Get-MgSubSite for /sites/{site-id}/sites/{site-id1}"),
        new(OverrideKind.ReplaceNoun, Method: null, "/groups/{}/sites/{}/sites", Match: PathMatch.Exact, Value: "GroupSubSite",
            Reason: "Sites.md directive; oracle ships Get-MgGroupSubSite"),
        new(OverrideKind.ReplaceNoun, Method: null, "/groups/{}/sites/{}/sites/{}", Match: PathMatch.Exact, Value: "GroupSubSite",
            Reason: "Sites.md directive; oracle ships Get-MgGroupSubSite"),
    ];
}
