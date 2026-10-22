using System.Collections.Generic;
using System.Net.Http;

namespace WrapperGenerator;

public static partial class CmdletConfigurator
{
    private static readonly List<Entry> SecurityCmdletConfigurations =
    [
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
