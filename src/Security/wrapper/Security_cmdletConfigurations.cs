using System.Collections.Generic;

namespace WrapperGenerator;

public static partial class CmdletConfigurator
{
    private static readonly List<Entry> SecurityCmdletConfigurations =
    [
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
