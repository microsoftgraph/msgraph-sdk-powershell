# Applications

This directory contains common [AutoREST.PowerShell](https://github.com/Azure/autorest.powershell) configurations for Applications v1.0 and/or beta modules.

## AutoRest Configuration

> see <https://aka.ms/autorest>

``` yaml
require:
  - $(this-folder)/../readme.graph.md
```

### Directives

> see https://github.com/Azure/autorest/blob/master/docs/powershell/directives.md

``` yaml
directive:
# Wrapper migration: suppress only collection-bound validateCredentials; item-bound
# actions remain. Existing v1.0 collision coverage is extended to both profiles by
# Applications_cmdletConfigurations.cs; exact evidence is in the adjacent ledger.
  - where:
      verb: Test
      subject: (Application|ServicePrincipal)SynchronizationJobCredential
      variant: Validate1|ValidateExpanded1|ValidateViaIdentity1|ValidateViaIdentityExpanded1
    remove: true
# Wrapper migration: exact servicePrincipal federatedIdentityCredentials routes,
# including count and name-keyed operations, are suppressed in both profiles.
# Application credentials and neighboring servicePrincipal routes remain available.
  - where:
      subject: (ServicePrincipal)FederatedIdentityCredential.*
    remove: true
# Rename cmdlets with duplicates in their name.
# Wrapper migration: StructuralNaming already emits a single OnPremisePublishingProfile
# noun for the beta root operations (and the Count suffix for its count operation).
# The compatible v1.0 spec has no publishing-profile routes; no rename override is needed.
  - where:
      subject: ^(OnPremisePublishingProfile)(\1)+
    set:
      subject: $1
#Prevent paths from being generated to allow for aliasing as a result of breaking changes in 2.18.0 and 2.17.0
# Wrapper migration: the complete legacy-source selection survives at the same
# method/path: seven operations in v1.0 and twelve in beta. Compatible operation IDs
# now match the originals, so the adjacent ledger uses literal current evidence.
# Suppress only these collection references, retaining item-reference neighbors.
  - remove-path-by-operation: ^application_DeleteOwnerGraphBPreRef$|^application_DeleteAppManagementPolicyGraphBPreRef$|^application_DeleteTokenIssuancePolicyGraphBPreRef$|^application_DeleteTokenLifetimePolicyGraphBPreRef$|^servicePrincipal_DeleteClaimsMappingPolicyGraphBPreRef$|^servicePrincipal_DeleteHomeRealmDiscoveryPolicyGraphBPreRef$|^servicePrincipal_DeleteOwnerGraphBPreRef$|^onPremisesPublishingProfile.agentGroup.agent_DeleteAgentGroupGraphBPreRef$|^onPremisesPublishingProfile.connectorGroup_DeleteMemberGraphBPreRef$|^onPremisesPublishingProfile.connector_ListMemberGraphOPreGraphBPreRef$|^onPremisesPublishingProfile.publishedResource_DeleteAgentGroupGraphBPreRef$|^onPremisesPublishingProfile.agentGroup.publishedResource_DeleteAgentGroupGraphBPreRef$

  # Set parameter alias
  # Wrapper migration: Deferred. Retain ApplicationId/ObjectId alias in AutoRest;
  # parameter aliases/transforms are outside this cmdlet-surface migration.
  - where:
      parameter-name: ApplicationId
    set:
      alias:
        - ObjectId
```

### Wrapper collision audit

The compatible specifications preserve the complete original operation-ID selection
in both profiles. The migration ledger records current literal IDs; tests compare the
entire selection with the actual same-profile legacy input. Parameter aliases remain
deferred, and profile-specific and global directives are not part of this migration.

The remaining beta agent-group GET collisions are a published parameter-set family,
not evidence that one endpoint is obsolete. The published Applications 2.38.1 proxy
uses `List` (default), `Get`, and `List2` for the profile collection, profile item, and
agent-scoped collection, respectively; the count command uses `Get` (default) and
`Get2`. `OnPremisesAgentId` distinguishes the agent-scoped routes. Current service
documentation describes both the profile's agent groups and an agent's assigned
groups; no retirement evidence justifies suppressing either.

The current wrapper generator cannot dispatch this family under its shared published
names. Resolving it requires reviewed multi-route support rather than an arbitrary
rename, route default, or endpoint removal. See the official
[list API](https://learn.microsoft.com/graph/api/onpremisesagentgroup-list?view=graph-rest-beta),
[agent relationships](https://learn.microsoft.com/graph/api/resources/onpremisesagent?view=graph-rest-beta),
[published command](https://learn.microsoft.com/powershell/module/microsoft.graph.beta.applications/get-mgbetaonpremisepublishingprofileagentgroup?view=graph-powershell-beta),
and [published count command](https://learn.microsoft.com/powershell/module/microsoft.graph.beta.applications/get-mgbetaonpremisepublishingprofileagentgroupcount?view=graph-powershell-beta).
