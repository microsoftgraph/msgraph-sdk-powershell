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
        new(OverrideKind.ReplaceNoun, HttpMethod.Get, "/sites/{}/sites/$count", Match: PathMatch.Exact, Value: "SubSiteCount",
            Reason: "Sites.md directive 5; preserve the published SubSiteCount noun in both profiles"),
        new(OverrideKind.ReplaceNoun, HttpMethod.Get, "/groups/{}/sites/{}/sites/$count", Match: PathMatch.Exact, Value: "GroupSubSiteCount",
            Reason: "Sites.md directive 8; preserve the published GroupSubSiteCount noun in both profiles"),
        new(OverrideKind.ReplaceNoun, HttpMethod.Get, "/sites/getallsites", Match: PathMatch.Exact, Value: "AllSite",
            Reason: "Sites.md directive 12; published Get-MgAllSite/Get-MgBetaAllSite"),
        new(OverrideKind.SuppressOperation, HttpMethod.Post, "/sites", Match: PathMatch.Exact, Value: null,
            Reason: "Sites.md directive 2 removes New-Site; POST /sites exists only in the beta input"),

        // Directive 1's repaired legacy selector covers the complete GroupSite OneNote tree.
        // Exact root + slash-delimited subtree avoid unrelated similarly prefixed navigation.
        new(OverrideKind.SuppressOperation, Method: null, "/groups/{}/sites/{}/onenote", Match: PathMatch.Exact, Value: null,
            Reason: "Sites.md directives 1/3; reviewed complete same-profile legacy evidence in Sites_directiveMigrationMap.json"),
        new(OverrideKind.SuppressOperation, Method: null, "/groups/{}/sites/{}/onenote/", Match: PathMatch.Prefix, Value: null,
            Reason: "Sites.md directives 1/3; every actual GroupSite OneNote operation is selected, including the five page PATCHes"),

        // The selector removes activity creation and item descendants, NOT collection GETs.
        new(OverrideKind.SuppressOperation, HttpMethod.Post, "/sites/{}/analytics/itemactivitystats/{}/activities", Match: PathMatch.Exact, Value: null,
            Reason: "Sites.md directive 1: site.analytic.itemActivityStat_CreateActivity"),
        new(OverrideKind.SuppressOperation, Method: null, "/sites/{}/analytics/itemactivitystats/{}/activities/", Match: PathMatch.Prefix, Value: null,
            Reason: "Sites.md directive 1: exact reviewed activity item/descendant and count operations"),
        new(OverrideKind.SuppressOperation, HttpMethod.Post, "/groups/{}/sites/{}/analytics/itemactivitystats/{}/activities", Match: PathMatch.Exact, Value: null,
            Reason: "Sites.md directive 1: group.site.analytic.itemActivityStat_CreateActivity"),
        new(OverrideKind.SuppressOperation, Method: null, "/groups/{}/sites/{}/analytics/itemactivitystats/{}/activities/", Match: PathMatch.Prefix, Value: null,
            Reason: "Sites.md directive 1: exact reviewed group-site activity item/descendant and count operations"),
        new(OverrideKind.SuppressOperation, HttpMethod.Post, "/sites/{}/lists/{}/activities", Match: PathMatch.Exact, Value: null,
            Reason: "Sites.md directive 1: beta site.list_CreateActivity; preserve list activity collection GET"),
        new(OverrideKind.SuppressOperation, HttpMethod.Post, "/groups/{}/sites/{}/lists/{}/activities", Match: PathMatch.Exact, Value: null,
            Reason: "Sites.md directive 1: beta group.site.list_CreateActivity; preserve list activity collection GET"),
        new(OverrideKind.SuppressOperation, HttpMethod.Post, "/sites/{}/lists/{}/items/{}/activities", Match: PathMatch.Exact, Value: null,
            Reason: "Sites.md directive 1: beta site.list.item_CreateActivity"),
        new(OverrideKind.SuppressOperation, Method: null, "/sites/{}/lists/{}/items/{}/activities/", Match: PathMatch.Prefix, Value: null,
            Reason: "Sites.md directive 1: beta site.list.item activity item/descendant and count operations"),
        new(OverrideKind.SuppressOperation, HttpMethod.Post, "/groups/{}/sites/{}/lists/{}/items/{}/activities", Match: PathMatch.Exact, Value: null,
            Reason: "Sites.md directive 1: beta group.site.list.item_CreateActivity"),
        new(OverrideKind.SuppressOperation, Method: null, "/groups/{}/sites/{}/lists/{}/items/{}/activities/", Match: PathMatch.Prefix, Value: null,
            Reason: "Sites.md directive 1: beta group.site.list.item activity item/descendant and count operations"),

        new(OverrideKind.SuppressOperation, HttpMethod.Get, "/sites/{}/columns/{}/sourcecolumn", Match: PathMatch.Exact, Value: null,
            Reason: "Sites.md directive 1: site.column_GetSourceColumn"),
        new(OverrideKind.SuppressOperation, HttpMethod.Get, "/sites/{}/contenttypes/{}/columns/{}/sourcecolumn", Match: PathMatch.Exact, Value: null,
            Reason: "Sites.md directive 1: site.contentType.column_GetSourceColumn"),
        new(OverrideKind.SuppressOperation, HttpMethod.Get, "/sites/{}/lists/{}/columns/{}/sourcecolumn", Match: PathMatch.Exact, Value: null,
            Reason: "Sites.md directive 1: site.list.column_GetSourceColumn"),
        new(OverrideKind.SuppressOperation, HttpMethod.Get, "/sites/{}/lists/{}/contenttypes/{}/columns/{}/sourcecolumn", Match: PathMatch.Exact, Value: null,
            Reason: "Sites.md directive 1: site.list.contentType.column_GetSourceColumn"),
        new(OverrideKind.SuppressOperation, HttpMethod.Get, "/groups/{}/sites/{}/columns/{}/sourcecolumn", Match: PathMatch.Exact, Value: null,
            Reason: "Sites.md directive 1: group.site.column_GetSourceColumn"),
        new(OverrideKind.SuppressOperation, HttpMethod.Get, "/groups/{}/sites/{}/contenttypes/{}/columns/{}/sourcecolumn", Match: PathMatch.Exact, Value: null,
            Reason: "Sites.md directive 1: group.site.contentType.column_GetSourceColumn"),
        new(OverrideKind.SuppressOperation, HttpMethod.Get, "/groups/{}/sites/{}/lists/{}/columns/{}/sourcecolumn", Match: PathMatch.Exact, Value: null,
            Reason: "Sites.md directive 1: group.site.list.column_GetSourceColumn"),
        new(OverrideKind.SuppressOperation, HttpMethod.Get, "/groups/{}/sites/{}/lists/{}/contenttypes/{}/columns/{}/sourcecolumn", Match: PathMatch.Exact, Value: null,
            Reason: "Sites.md directive 1: group.site.list.contentType.column_GetSourceColumn"),

        new(OverrideKind.SuppressOperation, HttpMethod.Get, "/sites/{}/contenttypes/{}/base", Match: PathMatch.Exact, Value: null,
            Reason: "Sites.md directive 1: site.contentType_GetBase"),
        new(OverrideKind.SuppressOperation, HttpMethod.Get, "/sites/{}/contenttypes/{}/basetypes", Match: PathMatch.Exact, Value: null,
            Reason: "Sites.md directive 1: site.contentType_ListBaseType"),
        new(OverrideKind.SuppressOperation, HttpMethod.Get, "/sites/{}/contenttypes/{}/basetypes/{}", Match: PathMatch.Exact, Value: null,
            Reason: "Sites.md directive 1: site.contentType_GetBaseType"),
        new(OverrideKind.SuppressOperation, HttpMethod.Get, "/sites/{}/contenttypes/{}/columnpositions", Match: PathMatch.Exact, Value: null,
            Reason: "Sites.md directive 1: site.contentType_ListColumnPosition"),
        new(OverrideKind.SuppressOperation, HttpMethod.Get, "/sites/{}/contenttypes/{}/columnpositions/{}", Match: PathMatch.Exact, Value: null,
            Reason: "Sites.md directive 1: site.contentType_GetColumnPosition"),
        new(OverrideKind.SuppressOperation, HttpMethod.Get, "/groups/{}/sites/{}/contenttypes/{}/base", Match: PathMatch.Exact, Value: null,
            Reason: "Sites.md directive 1: group.site.contentType_GetBase"),
        new(OverrideKind.SuppressOperation, HttpMethod.Get, "/groups/{}/sites/{}/contenttypes/{}/basetypes", Match: PathMatch.Exact, Value: null,
            Reason: "Sites.md directive 1: group.site.contentType_ListBaseType"),
        new(OverrideKind.SuppressOperation, HttpMethod.Get, "/groups/{}/sites/{}/contenttypes/{}/basetypes/{}", Match: PathMatch.Exact, Value: null,
            Reason: "Sites.md directive 1: group.site.contentType_GetBaseType"),
        new(OverrideKind.SuppressOperation, HttpMethod.Get, "/groups/{}/sites/{}/contenttypes/{}/columnpositions", Match: PathMatch.Exact, Value: null,
            Reason: "Sites.md directive 1: group.site.contentType_ListColumnPosition"),
        new(OverrideKind.SuppressOperation, HttpMethod.Get, "/groups/{}/sites/{}/contenttypes/{}/columnpositions/{}", Match: PathMatch.Exact, Value: null,
            Reason: "Sites.md directive 1: group.site.contentType_GetColumnPosition"),
        new(OverrideKind.SuppressOperation, HttpMethod.Post, "/sites/add", Match: PathMatch.Exact, Value: null,
            Reason: "Sites.md directive 1: exact site_add action; do not suppress group-site add"),
        new(OverrideKind.SuppressOperation, HttpMethod.Post, "/sites/remove", Match: PathMatch.Exact, Value: null,
            Reason: "Sites.md directive 1: exact site_remove action; do not suppress group-site remove"),
    ];
}
