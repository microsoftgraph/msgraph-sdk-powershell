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

        // The legacy GraphBPreRef IDs changed in the compatible conversion. The ledger
        // bridges their exact source method/path to these collection references, not item refs.
        new(OverrideKind.SuppressOperation, HttpMethod.Delete,
            "/applications/{}/appmanagementpolicies/$ref",
            PathMatch.Exact, null, "Applications.md removes application_DeleteAppManagementPolicyGraphBPreRef"),
        new(OverrideKind.SuppressOperation, HttpMethod.Delete,
            "/applications/{}/owners/$ref",
            PathMatch.Exact, null, "Applications.md removes application_DeleteOwnerGraphBPreRef"),
        new(OverrideKind.SuppressOperation, HttpMethod.Delete,
            "/applications/{}/tokenissuancepolicies/$ref",
            PathMatch.Exact, null, "Applications.md removes application_DeleteTokenIssuancePolicyGraphBPreRef"),
        new(OverrideKind.SuppressOperation, HttpMethod.Delete,
            "/applications/{}/tokenlifetimepolicies/$ref",
            PathMatch.Exact, null, "Applications.md removes application_DeleteTokenLifetimePolicyGraphBPreRef"),
        new(OverrideKind.SuppressOperation, HttpMethod.Delete,
            "/serviceprincipals/{}/claimsmappingpolicies/$ref",
            PathMatch.Exact, null, "Applications.md removes servicePrincipal_DeleteClaimsMappingPolicyGraphBPreRef"),
        new(OverrideKind.SuppressOperation, HttpMethod.Delete,
            "/serviceprincipals/{}/homerealmdiscoverypolicies/$ref",
            PathMatch.Exact, null, "Applications.md removes servicePrincipal_DeleteHomeRealmDiscoveryPolicyGraphBPreRef"),
        new(OverrideKind.SuppressOperation, HttpMethod.Delete,
            "/serviceprincipals/{}/owners/$ref",
            PathMatch.Exact, null, "Applications.md removes servicePrincipal_DeleteOwnerGraphBPreRef"),
        new(OverrideKind.SuppressOperation, HttpMethod.Delete,
            "/onpremisespublishingprofiles/{}/agentgroups/{}/agents/{}/agentgroups/$ref",
            PathMatch.Exact, null, "Applications.md removes onPremisesPublishingProfile.agentGroup.agent_DeleteAgentGroupGraphBPreRef"),
        new(OverrideKind.SuppressOperation, HttpMethod.Delete,
            "/onpremisespublishingprofiles/{}/agentgroups/{}/publishedresources/{}/agentgroups/$ref",
            PathMatch.Exact, null, "Applications.md removes onPremisesPublishingProfile.agentGroup.publishedResource_DeleteAgentGroupGraphBPreRef"),
        new(OverrideKind.SuppressOperation, HttpMethod.Delete,
            "/onpremisespublishingprofiles/{}/connectorgroups/{}/members/$ref",
            PathMatch.Exact, null, "Applications.md removes onPremisesPublishingProfile.connectorGroup_DeleteMemberGraphBPreRef"),
        new(OverrideKind.SuppressOperation, HttpMethod.Get,
            "/onpremisespublishingprofiles/{}/connectors/{}/memberof/$ref",
            PathMatch.Exact, null, "Applications.md removes onPremisesPublishingProfile.connector_ListMemberGraphOPreGraphBPreRef"),
        new(OverrideKind.SuppressOperation, HttpMethod.Delete,
            "/onpremisespublishingprofiles/{}/publishedresources/{}/agentgroups/$ref",
            PathMatch.Exact, null, "Applications.md removes onPremisesPublishingProfile.publishedResource_DeleteAgentGroupGraphBPreRef"),

        // Published item-reference nouns distinguish these DELETEs from their retained
        // collection-reference DELETEs. The agent-group command's Delete1 parameter set
        // selects the shorter agents/{id} route (Microsoft Learn, docs commit 07b0cf8f).
        new(OverrideKind.ReplaceNoun, HttpMethod.Delete,
            "/onpremisespublishingprofiles/{}/agents/{}/agentgroups/{}/$ref",
            PathMatch.Exact, "OnPremisePublishingProfileAgentGroupOnPremiseAgentGroupByRef",
            "Published Remove-MgBetaOnPremisePublishingProfileAgentGroupOnPremiseAgentGroupByRef Delete1"),
        new(OverrideKind.ReplaceNoun, HttpMethod.Delete,
            "/onpremisespublishingprofiles/{}/connectors/{}/memberof/{}/$ref",
            PathMatch.Exact, "OnPremisePublishingProfileConnectorMemberOfConnectorGroupByRef",
            "MgCommandMetadata.json publishes the item-reference ConnectorGroup noun"),
        new(OverrideKind.ReplaceNoun, HttpMethod.Delete,
            "/serviceprincipals/{}/tokenissuancepolicies/{}/$ref",
            PathMatch.Exact, "ServicePrincipalTokenIssuancePolicyTokenIssuancePolicyByRef",
            "MgCommandMetadata.json publishes the item-reference TokenIssuancePolicy noun"),
        new(OverrideKind.ReplaceNoun, HttpMethod.Delete,
            "/serviceprincipals/{}/tokenlifetimepolicies/{}/$ref",
            PathMatch.Exact, "ServicePrincipalTokenLifetimePolicyTokenLifetimePolicyByRef",
            "MgCommandMetadata.json publishes the item-reference TokenLifetimePolicy noun"),
    ];
}
