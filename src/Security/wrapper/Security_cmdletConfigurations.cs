using System.Collections.Generic;
using System.Net.Http;

namespace WrapperGenerator;

public static partial class CmdletConfigurator
{
    private static readonly List<Entry> SecurityCmdletConfigurations =
    [
        // Bulk actions have an ids request body; item actions are bodyless. They
        // cannot share natural-ID variants with identical public body contracts.
        // Multiple preserves the item command and describes the actual bulk body.
        new(OverrideKind.ReplaceNoun, HttpMethod.Post, "/security/cases/ediscoverycases/{}/custodians/microsoft.graph.security.applyhold", PathMatch.Exact,
            "SecurityCaseEdiscoveryCaseCustodianApplyHoldMultiple", "Collection action accepts ids; preserve bodyless item action"),
        new(OverrideKind.ReplaceNoun, HttpMethod.Post, "/security/cases/ediscoverycases/{}/custodians/microsoft.graph.security.removehold", PathMatch.Exact,
            "SecurityCaseEdiscoveryCaseCustodianRemoveHoldMultiple", "Collection action accepts ids; preserve bodyless item action"),
        new(OverrideKind.ReplaceNoun, HttpMethod.Post, "/security/cases/ediscoverycases/{}/custodians/microsoft.graph.security.updateindex", PathMatch.Exact,
            "SecurityCaseEdiscoveryCaseCustodianUpdateIndexMultiple", "Collection action accepts ids; preserve bodyless item action"),
        new(OverrideKind.ReplaceNoun, HttpMethod.Post, "/security/cases/ediscoverycases/{}/noncustodialdatasources/microsoft.graph.security.applyhold", PathMatch.Exact,
            "SecurityCaseEdiscoveryCaseNoncustodialDataSourceApplyHoldMultiple", "Collection action accepts ids; preserve bodyless item action"),
        new(OverrideKind.ReplaceNoun, HttpMethod.Post, "/security/cases/ediscoverycases/{}/noncustodialdatasources/microsoft.graph.security.removehold", PathMatch.Exact,
            "SecurityCaseEdiscoveryCaseNoncustodialDataSourceRemoveHoldMultiple", "Collection action accepts ids; preserve bodyless item action"),
        new(OverrideKind.ReplaceNoun, HttpMethod.Post, "/security/cases/ediscoverycases/{}/noncustodialdatasources/microsoft.graph.security.updateindex", PathMatch.Exact,
            "SecurityCaseEdiscoveryCaseNoncustodialDataSourceUpdateIndexMultiple", "Collection action accepts ids; preserve bodyless item action"),
        // Existing v1 derived suppressions remain authoritative. Shared groups
        // would include suppressed members there. Give beta alternatives scope
        // names instead, preserving each published count's original route.
        new(OverrideKind.ReplaceNoun, HttpMethod.Get, "/security/threatintelligence/articles/{}/indicators/$count", PathMatch.Exact,
            "SecurityThreatIntelligenceArticleIndicatorCountByArticle", "Article-scoped alternative; published default is articleIndicators/$count"),
        new(OverrideKind.ReplaceNoun, HttpMethod.Get, "/security/threatintelligence/hosts/{}/components/$count", PathMatch.Exact,
            "SecurityThreatIntelligenceHostComponentCountByHost", "Host-scoped alternative; published default is hostComponents/$count"),
        new(OverrideKind.ReplaceNoun, HttpMethod.Get, "/security/threatintelligence/hosts/{}/cookies/$count", PathMatch.Exact,
            "SecurityThreatIntelligenceHostCookieCountByHost", "Host-scoped alternative; published default is hostCookies/$count"),
        new(OverrideKind.ReplaceNoun, HttpMethod.Get, "/security/threatintelligence/hosts/{}/hostpairs/$count", PathMatch.Exact,
            "SecurityThreatIntelligenceHostPairCountByHost", "Host-scoped alternative; published default is hostPairs/$count"),
        new(OverrideKind.ReplaceNoun, HttpMethod.Get, "/security/threatintelligence/hosts/{}/ports/$count", PathMatch.Exact,
            "SecurityThreatIntelligenceHostPortCountByHost", "Host-scoped alternative; published default is hostPorts/$count"),
        new(OverrideKind.ReplaceNoun, HttpMethod.Get, "/security/threatintelligence/hostsslcertificates/$count", PathMatch.Exact,
            "SecurityThreatIntelligenceHostSslCertificateCountAcrossHost", "All-host collection alternative; preserve published hosts/{host-id}/sslCertificates/$count"),
        new(OverrideKind.ReplaceNoun, HttpMethod.Get, "/security/threatintelligence/hosttrackers/$count", PathMatch.Exact,
            "SecurityThreatIntelligenceHostTrackerCountAcrossHost", "All-host collection alternative; preserve published hosts/{host-id}/trackers/$count"),
        // Security.md shared directives 1 and 2. The attackSimulation portion of
        // directive 1 and directive 3 are already covered by the container entry below.
        new(OverrideKind.SuppressOperation, HttpMethod.Get, "/security", PathMatch.Exact, null,
            "Security.md: remove Get-Security (also covered by derived v1.0 parity data)"),
        new(OverrideKind.SuppressOperation, HttpMethod.Patch, "/security", PathMatch.Exact, null,
            "Security.md: remove Update-Security (also covered by derived v1.0 parity data)"),
        new(OverrideKind.SuppressOperation, HttpMethod.Get, "/security/cases/ediscoverycases/{}/noncustodialdatasources/{}/datasource", PathMatch.Exact, null,
            "Security.md: legacy noncustodialDataSource_GetDataSource; exact surviving route"),
        new(OverrideKind.SuppressOperation, HttpMethod.Patch, "/security/cases/ediscoverycases/{}/noncustodialdatasources/{}/datasource", PathMatch.Exact, null,
            "Security.md: legacy noncustodialDataSource_UpdateDataSource; exact surviving route"),
        new(OverrideKind.SuppressOperation, HttpMethod.Delete, "/security/cases/ediscoverycases/{}/noncustodialdatasources/{}/datasource", PathMatch.Exact, null,
            "Security.md: legacy noncustodialDataSource_DeleteDataSource; exact surviving route"),
        new(OverrideKind.SuppressOperation, HttpMethod.Get, "/security/datadiscovery/cloudappdiscovery/uploadedstreams/{}/microsoft.graph.security.aggregatedappsdetails(period={})", PathMatch.Exact, null,
            "Security.md: legacy uploadedStream_aggregatedAppsDetail; exact surviving beta function"),
        // Security threatIntelligence: nested navs under articles/{} and hosts/{} duplicate
        // the shipped top-level sets (articleIndicators, hostComponents, hostCookies,
        // hostPairs, hostPorts, hostSslCertificates, hostTrackers) and ship nothing
        // themselves. Exact-only: two of these navs have shipped $count children
        // (Get-MgSecurityThreatIntelligenceHost{SslCertificate,Tracker}Count); the other five
        // ship no children at all.
        new(OverrideKind.SuppressOperation, Method: null, "/security/threatintelligence/articles/{}/indicators", Match: PathMatch.Exact, Value: null, Reason: "oracle: ships nothing; top-level articleIndicators ships"),
        new(OverrideKind.SuppressOperation, Method: null, "/security/threatintelligence/articles/{}/indicators/{}", Match: PathMatch.Exact, Value: null, Reason: "oracle: ships nothing; top-level articleIndicators ships"),
        new(OverrideKind.SuppressOperation, Method: null, "/security/threatintelligence/hosts/{}/components", Match: PathMatch.Exact, Value: null, Reason: "oracle: ships nothing; top-level hostComponents ships"),
        new(OverrideKind.SuppressOperation, Method: null, "/security/threatintelligence/hosts/{}/components/{}", Match: PathMatch.Exact, Value: null, Reason: "oracle: ships nothing; top-level hostComponents ships"),
        new(OverrideKind.SuppressOperation, Method: null, "/security/threatintelligence/hosts/{}/cookies", Match: PathMatch.Exact, Value: null, Reason: "oracle: ships nothing; top-level hostCookies ships"),
        new(OverrideKind.SuppressOperation, Method: null, "/security/threatintelligence/hosts/{}/cookies/{}", Match: PathMatch.Exact, Value: null, Reason: "oracle: ships nothing; top-level hostCookies ships"),
        new(OverrideKind.SuppressOperation, Method: null, "/security/threatintelligence/hosts/{}/hostpairs", Match: PathMatch.Exact, Value: null, Reason: "oracle: ships nothing; top-level hostPairs ships"),
        new(OverrideKind.SuppressOperation, Method: null, "/security/threatintelligence/hosts/{}/hostpairs/{}", Match: PathMatch.Exact, Value: null, Reason: "oracle: ships nothing; top-level hostPairs ships"),
        new(OverrideKind.SuppressOperation, Method: null, "/security/threatintelligence/hosts/{}/ports", Match: PathMatch.Exact, Value: null, Reason: "oracle: ships nothing; top-level hostPorts ships"),
        new(OverrideKind.SuppressOperation, Method: null, "/security/threatintelligence/hosts/{}/ports/{}", Match: PathMatch.Exact, Value: null, Reason: "oracle: ships nothing; top-level hostPorts ships"),
        new(OverrideKind.SuppressOperation, Method: null, "/security/threatintelligence/hosts/{}/sslcertificates", Match: PathMatch.Exact, Value: null, Reason: "oracle: ships nothing; top-level hostSslCertificates ships"),
        new(OverrideKind.SuppressOperation, Method: null, "/security/threatintelligence/hosts/{}/sslcertificates/{}", Match: PathMatch.Exact, Value: null, Reason: "oracle: ships nothing; top-level hostSslCertificates ships"),
        new(OverrideKind.SuppressOperation, Method: null, "/security/threatintelligence/hosts/{}/trackers", Match: PathMatch.Exact, Value: null, Reason: "oracle: ships nothing; top-level hostTrackers ships"),
        new(OverrideKind.SuppressOperation, Method: null, "/security/threatintelligence/hosts/{}/trackers/{}", Match: PathMatch.Exact, Value: null, Reason: "oracle: ships nothing; top-level hostTrackers ships"),
        // The attackSimulation container node itself ships nothing; children under a
        // simulation item ship nothing either (the list/item pair then merges normally).
        new(OverrideKind.SuppressOperation, Method: null, "/security/attacksimulation", Match: PathMatch.Exact, Value: null,
            Reason: "oracle: the container node ships nothing; its child collections ship"),
        new(OverrideKind.SuppressOperation, Method: null, "/security/attacksimulation/simulations/{}/", Match: PathMatch.Prefix, Value: null,
            Reason: "oracle: nothing under a simulation item ships in v1.0"),
    ];
}
