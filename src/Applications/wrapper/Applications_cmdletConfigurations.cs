using System.Collections.Generic;
using System.Net.Http;

namespace WrapperGenerator;

public static partial class CmdletConfigurator
{
    private static readonly List<Entry> ApplicationsCmdletConfigurations =
    [
        // Validate1 is the collection-bound action, not the retained job-item action.
        // Derived v1.0 collision data covers these two routes, but beta has no such data.
        new(OverrideKind.SuppressOperation, HttpMethod.Post,
            "/applications/{}/synchronization/jobs/validatecredentials",
            PathMatch.Exact, null, "Applications.md removes collection-bound Validate1 variants"),
        new(OverrideKind.SuppressOperation, HttpMethod.Post,
            "/serviceprincipals/{}/synchronization/jobs/validatecredentials",
            PathMatch.Exact, null, "Applications.md removes collection-bound Validate1 variants"),

        // The shared subject selector removes servicePrincipal credentials only.
        // Exact entries also cover beta and the name-keyed routes missing from v1.0 parity data.
        new(OverrideKind.SuppressOperation, HttpMethod.Get,
            "/serviceprincipals/{}/federatedidentitycredentials",
            PathMatch.Exact, null, "Applications.md removes ServicePrincipalFederatedIdentityCredential.*"),
        new(OverrideKind.SuppressOperation, HttpMethod.Post,
            "/serviceprincipals/{}/federatedidentitycredentials",
            PathMatch.Exact, null, "Applications.md removes ServicePrincipalFederatedIdentityCredential.*"),
        new(OverrideKind.SuppressOperation, HttpMethod.Get,
            "/serviceprincipals/{}/federatedidentitycredentials/{}",
            PathMatch.Exact, null, "Applications.md removes ServicePrincipalFederatedIdentityCredential.*"),
        new(OverrideKind.SuppressOperation, HttpMethod.Patch,
            "/serviceprincipals/{}/federatedidentitycredentials/{}",
            PathMatch.Exact, null, "Applications.md removes ServicePrincipalFederatedIdentityCredential.*"),
        new(OverrideKind.SuppressOperation, HttpMethod.Delete,
            "/serviceprincipals/{}/federatedidentitycredentials/{}",
            PathMatch.Exact, null, "Applications.md removes ServicePrincipalFederatedIdentityCredential.*"),
        new(OverrideKind.SuppressOperation, HttpMethod.Get,
            "/serviceprincipals/{}/federatedidentitycredentials(name='{}')",
            PathMatch.Exact, null, "Applications.md removes ServicePrincipalFederatedIdentityCredential.*"),
        new(OverrideKind.SuppressOperation, HttpMethod.Patch,
            "/serviceprincipals/{}/federatedidentitycredentials(name='{}')",
            PathMatch.Exact, null, "Applications.md removes ServicePrincipalFederatedIdentityCredential.*"),
        new(OverrideKind.SuppressOperation, HttpMethod.Delete,
            "/serviceprincipals/{}/federatedidentitycredentials(name='{}')",
            PathMatch.Exact, null, "Applications.md removes ServicePrincipalFederatedIdentityCredential.*"),
        new(OverrideKind.SuppressOperation, HttpMethod.Get,
            "/serviceprincipals/{}/federatedidentitycredentials/$count",
            PathMatch.Exact, null, "Applications.md removes ServicePrincipalFederatedIdentityCredential.*"),
    ];
}
