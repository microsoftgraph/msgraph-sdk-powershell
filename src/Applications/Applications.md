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
# Wrapper migration: reviewed operation-ID absence in both compatible specs. None
# of these legacy IDs match; modern DeleteRef operations are not replacements for
# this exact selector and are deliberately not suppressed. See the reviewed ledger.
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
