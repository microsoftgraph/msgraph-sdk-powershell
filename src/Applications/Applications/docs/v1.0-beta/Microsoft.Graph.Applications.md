---
Module Name: Microsoft.Graph.Applications
Module Guid: c6061b4e-c0fa-4102-a8ed-7d15bcdcf776
Download Help Link: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.applications
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Applications Module
## Description
Microsoft Graph PowerShell Cmdlets

## Microsoft.Graph.Applications Cmdlets
### [Add-MgApplicationKey](Add-MgApplicationKey.md)
Invoke action addKey

### [Add-MgApplicationPassword](Add-MgApplicationPassword.md)
Invoke action addPassword

### [Add-MgServicePrincipalTokenSigningCertificate](Add-MgServicePrincipalTokenSigningCertificate.md)
Invoke action addTokenSigningCertificate

### [Clear-MgApplicationVerifiedPublisher](Clear-MgApplicationVerifiedPublisher.md)
Invoke action unsetVerifiedPublisher

### [Confirm-MgApplicationMemberGroup](Confirm-MgApplicationMemberGroup.md)
Invoke action checkMemberGroups

### [Confirm-MgApplicationMemberObject](Confirm-MgApplicationMemberObject.md)
Invoke action checkMemberObjects

### [Confirm-MgServicePrincipalMemberGroup](Confirm-MgServicePrincipalMemberGroup.md)
Invoke action checkMemberGroups

### [Confirm-MgServicePrincipalMemberObject](Confirm-MgServicePrincipalMemberObject.md)
Invoke action checkMemberObjects

### [Find-MgApplicationSynchronizationJobSchemaDirectory](Find-MgApplicationSynchronizationJobSchemaDirectory.md)
Invoke action discover

### [Find-MgApplicationSynchronizationTemplateSchemaDirectory](Find-MgApplicationSynchronizationTemplateSchemaDirectory.md)
Invoke action discover

### [Find-MgServicePrincipalSynchronizationJobSchemaDirectory](Find-MgServicePrincipalSynchronizationJobSchemaDirectory.md)
Invoke action discover

### [Find-MgServicePrincipalSynchronizationTemplateSchemaDirectory](Find-MgServicePrincipalSynchronizationTemplateSchemaDirectory.md)
Invoke action discover

### [Get-MgApplication](Get-MgApplication.md)
Get entity from applications by key

### [Get-MgApplicationAppManagementPolicy](Get-MgApplicationAppManagementPolicy.md)
The appManagementPolicy applied to this application.

### [Get-MgApplicationAppManagementPolicyByRef](Get-MgApplicationAppManagementPolicyByRef.md)
The appManagementPolicy applied to this application.

### [Get-MgApplicationById](Get-MgApplicationById.md)
Invoke action getByIds

### [Get-MgApplicationConnectorGroup](Get-MgApplicationConnectorGroup.md)
The connectorGroup the application is using with Azure AD Application Proxy.
Nullable.

### [Get-MgApplicationConnectorGroupByRef](Get-MgApplicationConnectorGroupByRef.md)
The connectorGroup the application is using with Azure AD Application Proxy.
Nullable.

### [Get-MgApplicationCreatedOnBehalfOf](Get-MgApplicationCreatedOnBehalfOf.md)
Read-only.

### [Get-MgApplicationCreatedOnBehalfOfByRef](Get-MgApplicationCreatedOnBehalfOfByRef.md)
Read-only.

### [Get-MgApplicationDelta](Get-MgApplicationDelta.md)
Invoke function delta

### [Get-MgApplicationExtensionProperty](Get-MgApplicationExtensionProperty.md)
Read-only.
Nullable.

### [Get-MgApplicationFederatedIdentityCredential](Get-MgApplicationFederatedIdentityCredential.md)
Federated identities for applications.
This object can only be retrieved on a single GET request (GET /applications/{id}/federatedIdentityCredentials).

### [Get-MgApplicationHomeRealmDiscoveryPolicy](Get-MgApplicationHomeRealmDiscoveryPolicy.md)
Get homeRealmDiscoveryPolicies from applications

### [Get-MgApplicationHomeRealmDiscoveryPolicyByRef](Get-MgApplicationHomeRealmDiscoveryPolicyByRef.md)
Get ref of homeRealmDiscoveryPolicies from applications

### [Get-MgApplicationLogo](Get-MgApplicationLogo.md)
The main logo for the application.
Not nullable.

### [Get-MgApplicationMemberGroup](Get-MgApplicationMemberGroup.md)
Invoke action getMemberGroups

### [Get-MgApplicationMemberObject](Get-MgApplicationMemberObject.md)
Invoke action getMemberObjects

### [Get-MgApplicationOwner](Get-MgApplicationOwner.md)
Directory objects that are owners of the application.
Read-only.
Nullable.
Supports $expand.

### [Get-MgApplicationOwnerByRef](Get-MgApplicationOwnerByRef.md)
Directory objects that are owners of the application.
Read-only.
Nullable.
Supports $expand.

### [Get-MgApplicationSynchronization](Get-MgApplicationSynchronization.md)
Get synchronization from applications

### [Get-MgApplicationSynchronizationAccessToken](Get-MgApplicationSynchronizationAccessToken.md)
Invoke action acquireAccessToken

### [Get-MgApplicationSynchronizationJob](Get-MgApplicationSynchronizationJob.md)
Get jobs from applications

### [Get-MgApplicationSynchronizationJobSchema](Get-MgApplicationSynchronizationJobSchema.md)
The synchronization schema configured for the job.

### [Get-MgApplicationSynchronizationJobSchemaDirectory](Get-MgApplicationSynchronizationJobSchemaDirectory.md)
Contains the collection of directories and all of their objects.

### [Get-MgApplicationSynchronizationTemplate](Get-MgApplicationSynchronizationTemplate.md)
Get templates from applications

### [Get-MgApplicationSynchronizationTemplateSchema](Get-MgApplicationSynchronizationTemplateSchema.md)
Default synchronization schema for the jobs based on this template.

### [Get-MgApplicationSynchronizationTemplateSchemaDirectory](Get-MgApplicationSynchronizationTemplateSchemaDirectory.md)
Contains the collection of directories and all of their objects.

### [Get-MgApplicationTemplate](Get-MgApplicationTemplate.md)
Get entity from applicationTemplates by key

### [Get-MgApplicationTokenIssuancePolicy](Get-MgApplicationTokenIssuancePolicy.md)
Get tokenIssuancePolicies from applications

### [Get-MgApplicationTokenIssuancePolicyByRef](Get-MgApplicationTokenIssuancePolicyByRef.md)
Get ref of tokenIssuancePolicies from applications

### [Get-MgApplicationTokenLifetimePolicy](Get-MgApplicationTokenLifetimePolicy.md)
The tokenLifetimePolicies assigned to this application.
Supports $expand.

### [Get-MgApplicationTokenLifetimePolicyByRef](Get-MgApplicationTokenLifetimePolicyByRef.md)
The tokenLifetimePolicies assigned to this application.
Supports $expand.

### [Get-MgApplicationUserOwnedObject](Get-MgApplicationUserOwnedObject.md)
Invoke action getUserOwnedObjects

### [Get-MgGroupAppRoleAssignment](Get-MgGroupAppRoleAssignment.md)
Represents the app roles a group has been granted for an application.
Supports $expand.

### [Get-MgOnPremisePublishingProfile](Get-MgOnPremisePublishingProfile.md)
Get entity from onPremisesPublishingProfiles by key

### [Get-MgOnPremisePublishingProfileAgent](Get-MgOnPremisePublishingProfileAgent.md)
List of existing onPremisesAgent objects.
Read-only.
Nullable.

### [Get-MgOnPremisePublishingProfileAgentGroup](Get-MgOnPremisePublishingProfileAgentGroup.md)
List of existing onPremisesAgentGroup objects.
Read-only.
Nullable.

### [Get-MgOnPremisePublishingProfileAgentGroupAgent](Get-MgOnPremisePublishingProfileAgentGroupAgent.md)
List of onPremisesAgent that are assigned to an onPremisesAgentGroup.
Read-only.
Nullable.

### [Get-MgOnPremisePublishingProfileAgentGroupPublishedResource](Get-MgOnPremisePublishingProfileAgentGroupPublishedResource.md)
List of publishedResource that are assigned to an onPremisesAgentGroup.
Read-only.
Nullable.

### [Get-MgOnPremisePublishingProfileAgentGroupPublishedResourceAgentGroup](Get-MgOnPremisePublishingProfileAgentGroupPublishedResourceAgentGroup.md)
List of onPremisesAgentGroups that a publishedResource is assigned to.
Read-only.
Nullable.

### [Get-MgOnPremisePublishingProfileConnector](Get-MgOnPremisePublishingProfileConnector.md)
List of existing connector objects for applications published through Application Proxy.
Read-only.
Nullable.

### [Get-MgOnPremisePublishingProfileConnectorGroup](Get-MgOnPremisePublishingProfileConnectorGroup.md)
List of existing connectorGroup objects for applications published through Application Proxy.
Read-only.
Nullable.

### [Get-MgOnPremisePublishingProfileConnectorGroupApplication](Get-MgOnPremisePublishingProfileConnectorGroupApplication.md)
Read-only.
Nullable.

### [Get-MgOnPremisePublishingProfileConnectorGroupApplicationByRef](Get-MgOnPremisePublishingProfileConnectorGroupApplicationByRef.md)
Read-only.
Nullable.

### [Get-MgOnPremisePublishingProfileConnectorGroupMember](Get-MgOnPremisePublishingProfileConnectorGroupMember.md)
Read-only.
Nullable.

### [Get-MgOnPremisePublishingProfileConnectorMemberOf](Get-MgOnPremisePublishingProfileConnectorMemberOf.md)
The connectorGroup that the connector is a member of.
Read-only.

### [Get-MgOnPremisePublishingProfilePublishedResource](Get-MgOnPremisePublishingProfilePublishedResource.md)
List of existing publishedResource objects.
Read-only.
Nullable.

### [Get-MgOnPremisePublishingProfilePublishedResourceAgentGroup](Get-MgOnPremisePublishingProfilePublishedResourceAgentGroup.md)
List of onPremisesAgentGroups that a publishedResource is assigned to.
Read-only.
Nullable.

### [Get-MgOnPremisePublishingProfilePublishedResourceAgentGroupAgent](Get-MgOnPremisePublishingProfilePublishedResourceAgentGroupAgent.md)
List of onPremisesAgent that are assigned to an onPremisesAgentGroup.
Read-only.
Nullable.

### [Get-MgOnPremisePublishingProfilePublishedResourceAgentGroupPublishedResource](Get-MgOnPremisePublishingProfilePublishedResourceAgentGroupPublishedResource.md)
List of publishedResource that are assigned to an onPremisesAgentGroup.
Read-only.
Nullable.

### [Get-MgServicePrincipal](Get-MgServicePrincipal.md)
Get entity from servicePrincipals by key

### [Get-MgServicePrincipalAppManagementPolicy](Get-MgServicePrincipalAppManagementPolicy.md)
The appManagementPolicy applied to this service principal.

### [Get-MgServicePrincipalAppManagementPolicyByRef](Get-MgServicePrincipalAppManagementPolicyByRef.md)
The appManagementPolicy applied to this service principal.

### [Get-MgServicePrincipalAppRoleAssignedTo](Get-MgServicePrincipalAppRoleAssignedTo.md)
App role assignments for this app or service, granted to users, groups, and other service principals.Supports $expand.

### [Get-MgServicePrincipalAppRoleAssignment](Get-MgServicePrincipalAppRoleAssignment.md)
App role assignment for another app or service, granted to this service principal.
Supports $expand.

### [Get-MgServicePrincipalById](Get-MgServicePrincipalById.md)
Invoke action getByIds

### [Get-MgServicePrincipalClaimMappingPolicy](Get-MgServicePrincipalClaimMappingPolicy.md)
The claimsMappingPolicies assigned to this service principal.
Supports $expand.

### [Get-MgServicePrincipalClaimMappingPolicyByRef](Get-MgServicePrincipalClaimMappingPolicyByRef.md)
The claimsMappingPolicies assigned to this service principal.
Supports $expand.

### [Get-MgServicePrincipalCreatedObject](Get-MgServicePrincipalCreatedObject.md)
Directory objects created by this service principal.
Read-only.
Nullable.

### [Get-MgServicePrincipalCreatedObjectByRef](Get-MgServicePrincipalCreatedObjectByRef.md)
Directory objects created by this service principal.
Read-only.
Nullable.

### [Get-MgServicePrincipalDelegatedPermissionClassification](Get-MgServicePrincipalDelegatedPermissionClassification.md)
The permission classifications for delegated permissions exposed by the app that this service principal represents.
Supports $expand.

### [Get-MgServicePrincipalDelta](Get-MgServicePrincipalDelta.md)
Invoke function delta

### [Get-MgServicePrincipalEndpoint](Get-MgServicePrincipalEndpoint.md)
Endpoints available for discovery.
Services like Sharepoint populate this property with a tenant specific SharePoint endpoints that other applications can discover and use in their experiences.

### [Get-MgServicePrincipalFederatedIdentityCredential](Get-MgServicePrincipalFederatedIdentityCredential.md)
Get federatedIdentityCredentials from servicePrincipals

### [Get-MgServicePrincipalHomeRealmDiscoveryPolicy](Get-MgServicePrincipalHomeRealmDiscoveryPolicy.md)
The homeRealmDiscoveryPolicies assigned to this service principal.
Supports $expand.

### [Get-MgServicePrincipalHomeRealmDiscoveryPolicyByRef](Get-MgServicePrincipalHomeRealmDiscoveryPolicyByRef.md)
The homeRealmDiscoveryPolicies assigned to this service principal.
Supports $expand.

### [Get-MgServicePrincipalLicenseDetail](Get-MgServicePrincipalLicenseDetail.md)
Get licenseDetails from servicePrincipals

### [Get-MgServicePrincipalMemberGroup](Get-MgServicePrincipalMemberGroup.md)
Invoke action getMemberGroups

### [Get-MgServicePrincipalMemberObject](Get-MgServicePrincipalMemberObject.md)
Invoke action getMemberObjects

### [Get-MgServicePrincipalMemberOf](Get-MgServicePrincipalMemberOf.md)
Roles that this service principal is a member of.
HTTP Methods: GET Read-only.
Nullable.
Supports $expand.

### [Get-MgServicePrincipalMemberOfByRef](Get-MgServicePrincipalMemberOfByRef.md)
Roles that this service principal is a member of.
HTTP Methods: GET Read-only.
Nullable.
Supports $expand.

### [Get-MgServicePrincipalOauth2PermissionGrant](Get-MgServicePrincipalOauth2PermissionGrant.md)
Delegated permission grants authorizing this service principal to access an API on behalf of a signed-in user.
Read-only.
Nullable.

### [Get-MgServicePrincipalOauth2PermissionGrantByRef](Get-MgServicePrincipalOauth2PermissionGrantByRef.md)
Delegated permission grants authorizing this service principal to access an API on behalf of a signed-in user.
Read-only.
Nullable.

### [Get-MgServicePrincipalOwnedObject](Get-MgServicePrincipalOwnedObject.md)
Directory objects that are owned by this service principal.
Read-only.
Nullable.
Supports $expand.

### [Get-MgServicePrincipalOwnedObjectByRef](Get-MgServicePrincipalOwnedObjectByRef.md)
Directory objects that are owned by this service principal.
Read-only.
Nullable.
Supports $expand.

### [Get-MgServicePrincipalOwner](Get-MgServicePrincipalOwner.md)
Directory objects that are owners of this servicePrincipal.
The owners are a set of non-admin users or servicePrincipals who are allowed to modify this object.
Read-only.
Nullable.
Supports $expand.

### [Get-MgServicePrincipalOwnerByRef](Get-MgServicePrincipalOwnerByRef.md)
Directory objects that are owners of this servicePrincipal.
The owners are a set of non-admin users or servicePrincipals who are allowed to modify this object.
Read-only.
Nullable.
Supports $expand.

### [Get-MgServicePrincipalPasswordSingleSignOnCredentials](Get-MgServicePrincipalPasswordSingleSignOnCredentials.md)
Invoke action getPasswordSingleSignOnCredentials

### [Get-MgServicePrincipalSynchronization](Get-MgServicePrincipalSynchronization.md)
Get synchronization from servicePrincipals

### [Get-MgServicePrincipalSynchronizationAccessToken](Get-MgServicePrincipalSynchronizationAccessToken.md)
Invoke action acquireAccessToken

### [Get-MgServicePrincipalSynchronizationJob](Get-MgServicePrincipalSynchronizationJob.md)
Get jobs from servicePrincipals

### [Get-MgServicePrincipalSynchronizationJobSchema](Get-MgServicePrincipalSynchronizationJobSchema.md)
The synchronization schema configured for the job.

### [Get-MgServicePrincipalSynchronizationJobSchemaDirectory](Get-MgServicePrincipalSynchronizationJobSchemaDirectory.md)
Contains the collection of directories and all of their objects.

### [Get-MgServicePrincipalSynchronizationTemplate](Get-MgServicePrincipalSynchronizationTemplate.md)
Get templates from servicePrincipals

### [Get-MgServicePrincipalSynchronizationTemplateSchema](Get-MgServicePrincipalSynchronizationTemplateSchema.md)
Default synchronization schema for the jobs based on this template.

### [Get-MgServicePrincipalSynchronizationTemplateSchemaDirectory](Get-MgServicePrincipalSynchronizationTemplateSchemaDirectory.md)
Contains the collection of directories and all of their objects.

### [Get-MgServicePrincipalTokenIssuancePolicy](Get-MgServicePrincipalTokenIssuancePolicy.md)
The tokenIssuancePolicies assigned to this service principal.
Supports $expand.

### [Get-MgServicePrincipalTokenIssuancePolicyByRef](Get-MgServicePrincipalTokenIssuancePolicyByRef.md)
The tokenIssuancePolicies assigned to this service principal.
Supports $expand.

### [Get-MgServicePrincipalTokenLifetimePolicy](Get-MgServicePrincipalTokenLifetimePolicy.md)
The tokenLifetimePolicies assigned to this service principal.
Supports $expand.

### [Get-MgServicePrincipalTokenLifetimePolicyByRef](Get-MgServicePrincipalTokenLifetimePolicyByRef.md)
The tokenLifetimePolicies assigned to this service principal.
Supports $expand.

### [Get-MgServicePrincipalTransitiveMemberOf](Get-MgServicePrincipalTransitiveMemberOf.md)
Get transitiveMemberOf from servicePrincipals

### [Get-MgServicePrincipalTransitiveMemberOfByRef](Get-MgServicePrincipalTransitiveMemberOfByRef.md)
Get ref of transitiveMemberOf from servicePrincipals

### [Get-MgServicePrincipalUserOwnedObject](Get-MgServicePrincipalUserOwnedObject.md)
Invoke action getUserOwnedObjects

### [Get-MgUserAppRoleAssignment](Get-MgUserAppRoleAssignment.md)
Represents the app roles a user has been granted for an application.
Supports $expand.

### [Invoke-MgFilterApplicationSynchronizationJobSchemaOperator](Invoke-MgFilterApplicationSynchronizationJobSchemaOperator.md)
Invoke function filterOperators

### [Invoke-MgFilterApplicationSynchronizationTemplateSchemaOperator](Invoke-MgFilterApplicationSynchronizationTemplateSchemaOperator.md)
Invoke function filterOperators

### [Invoke-MgFilterServicePrincipalSynchronizationJobSchemaOperator](Invoke-MgFilterServicePrincipalSynchronizationJobSchemaOperator.md)
Invoke function filterOperators

### [Invoke-MgFilterServicePrincipalSynchronizationTemplateSchemaOperator](Invoke-MgFilterServicePrincipalSynchronizationTemplateSchemaOperator.md)
Invoke function filterOperators

### [Invoke-MgFunctionApplicationSynchronizationJobSchema](Invoke-MgFunctionApplicationSynchronizationJobSchema.md)
Invoke function functions

### [Invoke-MgFunctionApplicationSynchronizationTemplateSchema](Invoke-MgFunctionApplicationSynchronizationTemplateSchema.md)
Invoke function functions

### [Invoke-MgFunctionServicePrincipalSynchronizationJobSchema](Invoke-MgFunctionServicePrincipalSynchronizationJobSchema.md)
Invoke function functions

### [Invoke-MgFunctionServicePrincipalSynchronizationTemplateSchema](Invoke-MgFunctionServicePrincipalSynchronizationTemplateSchema.md)
Invoke function functions

### [Invoke-MgInstantiateApplicationTemplate](Invoke-MgInstantiateApplicationTemplate.md)
Invoke action instantiate

### [Invoke-MgParseApplicationSynchronizationJobSchemaExpression](Invoke-MgParseApplicationSynchronizationJobSchemaExpression.md)
Invoke action parseExpression

### [Invoke-MgParseApplicationSynchronizationTemplateSchemaExpression](Invoke-MgParseApplicationSynchronizationTemplateSchemaExpression.md)
Invoke action parseExpression

### [Invoke-MgParseServicePrincipalSynchronizationJobSchemaExpression](Invoke-MgParseServicePrincipalSynchronizationJobSchemaExpression.md)
Invoke action parseExpression

### [Invoke-MgParseServicePrincipalSynchronizationTemplateSchemaExpression](Invoke-MgParseServicePrincipalSynchronizationTemplateSchemaExpression.md)
Invoke action parseExpression

### [New-MgApplication](New-MgApplication.md)
Add new entity to applications

### [New-MgApplicationAppManagementPolicyByRef](New-MgApplicationAppManagementPolicyByRef.md)
The appManagementPolicy applied to this application.

### [New-MgApplicationExtensionProperty](New-MgApplicationExtensionProperty.md)
Read-only.
Nullable.

### [New-MgApplicationFederatedIdentityCredential](New-MgApplicationFederatedIdentityCredential.md)
Federated identities for applications.
This object can only be retrieved on a single GET request (GET /applications/{id}/federatedIdentityCredentials).

### [New-MgApplicationHomeRealmDiscoveryPolicyByRef](New-MgApplicationHomeRealmDiscoveryPolicyByRef.md)
Create new navigation property ref to homeRealmDiscoveryPolicies for applications

### [New-MgApplicationOwnerByRef](New-MgApplicationOwnerByRef.md)
Directory objects that are owners of the application.
Read-only.
Nullable.
Supports $expand.

### [New-MgApplicationSynchronizationJob](New-MgApplicationSynchronizationJob.md)
Create new navigation property to jobs for applications

### [New-MgApplicationSynchronizationJobOnDemand](New-MgApplicationSynchronizationJobOnDemand.md)
Invoke action provisionOnDemand

### [New-MgApplicationSynchronizationJobSchemaDirectory](New-MgApplicationSynchronizationJobSchemaDirectory.md)
Contains the collection of directories and all of their objects.

### [New-MgApplicationSynchronizationTemplate](New-MgApplicationSynchronizationTemplate.md)
Create new navigation property to templates for applications

### [New-MgApplicationSynchronizationTemplateSchemaDirectory](New-MgApplicationSynchronizationTemplateSchemaDirectory.md)
Contains the collection of directories and all of their objects.

### [New-MgApplicationTemplate](New-MgApplicationTemplate.md)
Add new entity to applicationTemplates

### [New-MgApplicationTokenIssuancePolicyByRef](New-MgApplicationTokenIssuancePolicyByRef.md)
Create new navigation property ref to tokenIssuancePolicies for applications

### [New-MgApplicationTokenLifetimePolicyByRef](New-MgApplicationTokenLifetimePolicyByRef.md)
The tokenLifetimePolicies assigned to this application.
Supports $expand.

### [New-MgGroupAppRoleAssignment](New-MgGroupAppRoleAssignment.md)
Represents the app roles a group has been granted for an application.
Supports $expand.

### [New-MgOnPremisePublishingProfile](New-MgOnPremisePublishingProfile.md)
Add new entity to onPremisesPublishingProfiles

### [New-MgOnPremisePublishingProfileAgent](New-MgOnPremisePublishingProfileAgent.md)
List of existing onPremisesAgent objects.
Read-only.
Nullable.

### [New-MgOnPremisePublishingProfileAgentGroup](New-MgOnPremisePublishingProfileAgentGroup.md)
List of existing onPremisesAgentGroup objects.
Read-only.
Nullable.

### [New-MgOnPremisePublishingProfileAgentGroupAgent](New-MgOnPremisePublishingProfileAgentGroupAgent.md)
List of onPremisesAgent that are assigned to an onPremisesAgentGroup.
Read-only.
Nullable.

### [New-MgOnPremisePublishingProfileAgentGroupPublishedResource](New-MgOnPremisePublishingProfileAgentGroupPublishedResource.md)
List of publishedResource that are assigned to an onPremisesAgentGroup.
Read-only.
Nullable.

### [New-MgOnPremisePublishingProfileAgentGroupPublishedResourceAgentGroup](New-MgOnPremisePublishingProfileAgentGroupPublishedResourceAgentGroup.md)
List of onPremisesAgentGroups that a publishedResource is assigned to.
Read-only.
Nullable.

### [New-MgOnPremisePublishingProfileConnector](New-MgOnPremisePublishingProfileConnector.md)
List of existing connector objects for applications published through Application Proxy.
Read-only.
Nullable.

### [New-MgOnPremisePublishingProfileConnectorGroup](New-MgOnPremisePublishingProfileConnectorGroup.md)
List of existing connectorGroup objects for applications published through Application Proxy.
Read-only.
Nullable.

### [New-MgOnPremisePublishingProfileConnectorGroupApplicationByRef](New-MgOnPremisePublishingProfileConnectorGroupApplicationByRef.md)
Read-only.
Nullable.

### [New-MgOnPremisePublishingProfileConnectorMemberOf](New-MgOnPremisePublishingProfileConnectorMemberOf.md)
The connectorGroup that the connector is a member of.
Read-only.

### [New-MgOnPremisePublishingProfilePublishedResource](New-MgOnPremisePublishingProfilePublishedResource.md)
List of existing publishedResource objects.
Read-only.
Nullable.

### [New-MgOnPremisePublishingProfilePublishedResourceAgentGroup](New-MgOnPremisePublishingProfilePublishedResourceAgentGroup.md)
List of onPremisesAgentGroups that a publishedResource is assigned to.
Read-only.
Nullable.

### [New-MgOnPremisePublishingProfilePublishedResourceAgentGroupAgent](New-MgOnPremisePublishingProfilePublishedResourceAgentGroupAgent.md)
List of onPremisesAgent that are assigned to an onPremisesAgentGroup.
Read-only.
Nullable.

### [New-MgOnPremisePublishingProfilePublishedResourceAgentGroupPublishedResource](New-MgOnPremisePublishingProfilePublishedResourceAgentGroupPublishedResource.md)
List of publishedResource that are assigned to an onPremisesAgentGroup.
Read-only.
Nullable.

### [New-MgServicePrincipal](New-MgServicePrincipal.md)
Add new entity to servicePrincipals

### [New-MgServicePrincipalAppManagementPolicyByRef](New-MgServicePrincipalAppManagementPolicyByRef.md)
The appManagementPolicy applied to this service principal.

### [New-MgServicePrincipalAppRoleAssignedTo](New-MgServicePrincipalAppRoleAssignedTo.md)
App role assignments for this app or service, granted to users, groups, and other service principals.Supports $expand.

### [New-MgServicePrincipalAppRoleAssignment](New-MgServicePrincipalAppRoleAssignment.md)
App role assignment for another app or service, granted to this service principal.
Supports $expand.

### [New-MgServicePrincipalClaimMappingPolicyByRef](New-MgServicePrincipalClaimMappingPolicyByRef.md)
The claimsMappingPolicies assigned to this service principal.
Supports $expand.

### [New-MgServicePrincipalCreatedObjectByRef](New-MgServicePrincipalCreatedObjectByRef.md)
Directory objects created by this service principal.
Read-only.
Nullable.

### [New-MgServicePrincipalDelegatedPermissionClassification](New-MgServicePrincipalDelegatedPermissionClassification.md)
The permission classifications for delegated permissions exposed by the app that this service principal represents.
Supports $expand.

### [New-MgServicePrincipalEndpoint](New-MgServicePrincipalEndpoint.md)
Endpoints available for discovery.
Services like Sharepoint populate this property with a tenant specific SharePoint endpoints that other applications can discover and use in their experiences.

### [New-MgServicePrincipalFederatedIdentityCredential](New-MgServicePrincipalFederatedIdentityCredential.md)
Create new navigation property to federatedIdentityCredentials for servicePrincipals

### [New-MgServicePrincipalHomeRealmDiscoveryPolicyByRef](New-MgServicePrincipalHomeRealmDiscoveryPolicyByRef.md)
The homeRealmDiscoveryPolicies assigned to this service principal.
Supports $expand.

### [New-MgServicePrincipalLicenseDetail](New-MgServicePrincipalLicenseDetail.md)
Create new navigation property to licenseDetails for servicePrincipals

### [New-MgServicePrincipalMemberOfByRef](New-MgServicePrincipalMemberOfByRef.md)
Roles that this service principal is a member of.
HTTP Methods: GET Read-only.
Nullable.
Supports $expand.

### [New-MgServicePrincipalOauth2PermissionGrantByRef](New-MgServicePrincipalOauth2PermissionGrantByRef.md)
Delegated permission grants authorizing this service principal to access an API on behalf of a signed-in user.
Read-only.
Nullable.

### [New-MgServicePrincipalOwnedObjectByRef](New-MgServicePrincipalOwnedObjectByRef.md)
Directory objects that are owned by this service principal.
Read-only.
Nullable.
Supports $expand.

### [New-MgServicePrincipalOwnerByRef](New-MgServicePrincipalOwnerByRef.md)
Directory objects that are owners of this servicePrincipal.
The owners are a set of non-admin users or servicePrincipals who are allowed to modify this object.
Read-only.
Nullable.
Supports $expand.

### [New-MgServicePrincipalPasswordSingleSignOnCredentials](New-MgServicePrincipalPasswordSingleSignOnCredentials.md)
Invoke action createPasswordSingleSignOnCredentials

### [New-MgServicePrincipalSynchronizationJob](New-MgServicePrincipalSynchronizationJob.md)
Create new navigation property to jobs for servicePrincipals

### [New-MgServicePrincipalSynchronizationJobOnDemand](New-MgServicePrincipalSynchronizationJobOnDemand.md)
Invoke action provisionOnDemand

### [New-MgServicePrincipalSynchronizationJobSchemaDirectory](New-MgServicePrincipalSynchronizationJobSchemaDirectory.md)
Contains the collection of directories and all of their objects.

### [New-MgServicePrincipalSynchronizationTemplate](New-MgServicePrincipalSynchronizationTemplate.md)
Create new navigation property to templates for servicePrincipals

### [New-MgServicePrincipalSynchronizationTemplateSchemaDirectory](New-MgServicePrincipalSynchronizationTemplateSchemaDirectory.md)
Contains the collection of directories and all of their objects.

### [New-MgServicePrincipalTokenIssuancePolicyByRef](New-MgServicePrincipalTokenIssuancePolicyByRef.md)
The tokenIssuancePolicies assigned to this service principal.
Supports $expand.

### [New-MgServicePrincipalTokenLifetimePolicyByRef](New-MgServicePrincipalTokenLifetimePolicyByRef.md)
The tokenLifetimePolicies assigned to this service principal.
Supports $expand.

### [New-MgServicePrincipalTransitiveMemberOfByRef](New-MgServicePrincipalTransitiveMemberOfByRef.md)
Create new navigation property ref to transitiveMemberOf for servicePrincipals

### [New-MgUserAppRoleAssignment](New-MgUserAppRoleAssignment.md)
Represents the app roles a user has been granted for an application.
Supports $expand.

### [Ping-MgApplicationsSynchronization](Ping-MgApplicationsSynchronization.md)
Invoke function Ping

### [Ping-MgServicePrincipalsSynchronization](Ping-MgServicePrincipalsSynchronization.md)
Invoke function Ping

### [Remove-MgApplication](Remove-MgApplication.md)
Delete entity from applications

### [Remove-MgApplicationConnectorGroupByRef](Remove-MgApplicationConnectorGroupByRef.md)
The connectorGroup the application is using with Azure AD Application Proxy.
Nullable.

### [Remove-MgApplicationCreatedOnBehalfOfByRef](Remove-MgApplicationCreatedOnBehalfOfByRef.md)
Read-only.

### [Remove-MgApplicationExtensionProperty](Remove-MgApplicationExtensionProperty.md)
Read-only.
Nullable.

### [Remove-MgApplicationFederatedIdentityCredential](Remove-MgApplicationFederatedIdentityCredential.md)
Federated identities for applications.
This object can only be retrieved on a single GET request (GET /applications/{id}/federatedIdentityCredentials).

### [Remove-MgApplicationKey](Remove-MgApplicationKey.md)
Invoke action removeKey

### [Remove-MgApplicationPassword](Remove-MgApplicationPassword.md)
Invoke action removePassword

### [Remove-MgApplicationSynchronization](Remove-MgApplicationSynchronization.md)
Delete navigation property synchronization for applications

### [Remove-MgApplicationSynchronizationJob](Remove-MgApplicationSynchronizationJob.md)
Delete navigation property jobs for applications

### [Remove-MgApplicationSynchronizationJobSchema](Remove-MgApplicationSynchronizationJobSchema.md)
The synchronization schema configured for the job.

### [Remove-MgApplicationSynchronizationJobSchemaDirectory](Remove-MgApplicationSynchronizationJobSchemaDirectory.md)
Contains the collection of directories and all of their objects.

### [Remove-MgApplicationSynchronizationTemplate](Remove-MgApplicationSynchronizationTemplate.md)
Delete navigation property templates for applications

### [Remove-MgApplicationSynchronizationTemplateSchema](Remove-MgApplicationSynchronizationTemplateSchema.md)
Default synchronization schema for the jobs based on this template.

### [Remove-MgApplicationSynchronizationTemplateSchemaDirectory](Remove-MgApplicationSynchronizationTemplateSchemaDirectory.md)
Contains the collection of directories and all of their objects.

### [Remove-MgApplicationTemplate](Remove-MgApplicationTemplate.md)
Delete entity from applicationTemplates

### [Remove-MgGroupAppRoleAssignment](Remove-MgGroupAppRoleAssignment.md)
Represents the app roles a group has been granted for an application.
Supports $expand.

### [Remove-MgOnPremisePublishingProfile](Remove-MgOnPremisePublishingProfile.md)
Delete entity from onPremisesPublishingProfiles

### [Remove-MgOnPremisePublishingProfileAgent](Remove-MgOnPremisePublishingProfileAgent.md)
List of existing onPremisesAgent objects.
Read-only.
Nullable.

### [Remove-MgOnPremisePublishingProfileAgentGroup](Remove-MgOnPremisePublishingProfileAgentGroup.md)
List of existing onPremisesAgentGroup objects.
Read-only.
Nullable.

### [Remove-MgOnPremisePublishingProfileAgentGroupAgent](Remove-MgOnPremisePublishingProfileAgentGroupAgent.md)
List of onPremisesAgent that are assigned to an onPremisesAgentGroup.
Read-only.
Nullable.

### [Remove-MgOnPremisePublishingProfileAgentGroupPublishedResource](Remove-MgOnPremisePublishingProfileAgentGroupPublishedResource.md)
List of publishedResource that are assigned to an onPremisesAgentGroup.
Read-only.
Nullable.

### [Remove-MgOnPremisePublishingProfileAgentGroupPublishedResourceAgentGroup](Remove-MgOnPremisePublishingProfileAgentGroupPublishedResourceAgentGroup.md)
List of onPremisesAgentGroups that a publishedResource is assigned to.
Read-only.
Nullable.

### [Remove-MgOnPremisePublishingProfileConnector](Remove-MgOnPremisePublishingProfileConnector.md)
List of existing connector objects for applications published through Application Proxy.
Read-only.
Nullable.

### [Remove-MgOnPremisePublishingProfileConnectorGroup](Remove-MgOnPremisePublishingProfileConnectorGroup.md)
List of existing connectorGroup objects for applications published through Application Proxy.
Read-only.
Nullable.

### [Remove-MgOnPremisePublishingProfileConnectorMemberOf](Remove-MgOnPremisePublishingProfileConnectorMemberOf.md)
The connectorGroup that the connector is a member of.
Read-only.

### [Remove-MgOnPremisePublishingProfilePublishedResource](Remove-MgOnPremisePublishingProfilePublishedResource.md)
List of existing publishedResource objects.
Read-only.
Nullable.

### [Remove-MgOnPremisePublishingProfilePublishedResourceAgentGroup](Remove-MgOnPremisePublishingProfilePublishedResourceAgentGroup.md)
List of onPremisesAgentGroups that a publishedResource is assigned to.
Read-only.
Nullable.

### [Remove-MgOnPremisePublishingProfilePublishedResourceAgentGroupAgent](Remove-MgOnPremisePublishingProfilePublishedResourceAgentGroupAgent.md)
List of onPremisesAgent that are assigned to an onPremisesAgentGroup.
Read-only.
Nullable.

### [Remove-MgOnPremisePublishingProfilePublishedResourceAgentGroupPublishedResource](Remove-MgOnPremisePublishingProfilePublishedResourceAgentGroupPublishedResource.md)
List of publishedResource that are assigned to an onPremisesAgentGroup.
Read-only.
Nullable.

### [Remove-MgServicePrincipal](Remove-MgServicePrincipal.md)
Delete entity from servicePrincipals

### [Remove-MgServicePrincipalAppRoleAssignedTo](Remove-MgServicePrincipalAppRoleAssignedTo.md)
App role assignments for this app or service, granted to users, groups, and other service principals.Supports $expand.

### [Remove-MgServicePrincipalAppRoleAssignment](Remove-MgServicePrincipalAppRoleAssignment.md)
App role assignment for another app or service, granted to this service principal.
Supports $expand.

### [Remove-MgServicePrincipalDelegatedPermissionClassification](Remove-MgServicePrincipalDelegatedPermissionClassification.md)
The permission classifications for delegated permissions exposed by the app that this service principal represents.
Supports $expand.

### [Remove-MgServicePrincipalEndpoint](Remove-MgServicePrincipalEndpoint.md)
Endpoints available for discovery.
Services like Sharepoint populate this property with a tenant specific SharePoint endpoints that other applications can discover and use in their experiences.

### [Remove-MgServicePrincipalFederatedIdentityCredential](Remove-MgServicePrincipalFederatedIdentityCredential.md)
Delete navigation property federatedIdentityCredentials for servicePrincipals

### [Remove-MgServicePrincipalLicenseDetail](Remove-MgServicePrincipalLicenseDetail.md)
Delete navigation property licenseDetails for servicePrincipals

### [Remove-MgServicePrincipalPasswordSingleSignOnCredentials](Remove-MgServicePrincipalPasswordSingleSignOnCredentials.md)
Invoke action deletePasswordSingleSignOnCredentials

### [Remove-MgServicePrincipalSynchronization](Remove-MgServicePrincipalSynchronization.md)
Delete navigation property synchronization for servicePrincipals

### [Remove-MgServicePrincipalSynchronizationJob](Remove-MgServicePrincipalSynchronizationJob.md)
Delete navigation property jobs for servicePrincipals

### [Remove-MgServicePrincipalSynchronizationJobSchema](Remove-MgServicePrincipalSynchronizationJobSchema.md)
The synchronization schema configured for the job.

### [Remove-MgServicePrincipalSynchronizationJobSchemaDirectory](Remove-MgServicePrincipalSynchronizationJobSchemaDirectory.md)
Contains the collection of directories and all of their objects.

### [Remove-MgServicePrincipalSynchronizationTemplate](Remove-MgServicePrincipalSynchronizationTemplate.md)
Delete navigation property templates for servicePrincipals

### [Remove-MgServicePrincipalSynchronizationTemplateSchema](Remove-MgServicePrincipalSynchronizationTemplateSchema.md)
Default synchronization schema for the jobs based on this template.

### [Remove-MgServicePrincipalSynchronizationTemplateSchemaDirectory](Remove-MgServicePrincipalSynchronizationTemplateSchemaDirectory.md)
Contains the collection of directories and all of their objects.

### [Remove-MgUserAppRoleAssignment](Remove-MgUserAppRoleAssignment.md)
Represents the app roles a user has been granted for an application.
Supports $expand.

### [Restart-MgApplicationSynchronizationJob](Restart-MgApplicationSynchronizationJob.md)
Invoke action restart

### [Restart-MgServicePrincipalSynchronizationJob](Restart-MgServicePrincipalSynchronizationJob.md)
Invoke action restart

### [Restore-MgApplication](Restore-MgApplication.md)
Invoke action restore

### [Restore-MgServicePrincipal](Restore-MgServicePrincipal.md)
Invoke action restore

### [Set-MgApplicationConnectorGroupByRef](Set-MgApplicationConnectorGroupByRef.md)
The connectorGroup the application is using with Azure AD Application Proxy.
Nullable.

### [Set-MgApplicationCreatedOnBehalfOfByRef](Set-MgApplicationCreatedOnBehalfOfByRef.md)
Read-only.

### [Set-MgApplicationLogo](Set-MgApplicationLogo.md)
The main logo for the application.
Not nullable.

### [Set-MgApplicationVerifiedPublisher](Set-MgApplicationVerifiedPublisher.md)
Invoke action setVerifiedPublisher

### [Start-MgApplicationSynchronizationJob](Start-MgApplicationSynchronizationJob.md)
Invoke action start

### [Start-MgServicePrincipalSynchronizationJob](Start-MgServicePrincipalSynchronizationJob.md)
Invoke action start

### [Stop-MgApplicationSynchronizationJob](Stop-MgApplicationSynchronizationJob.md)
Invoke action stop

### [Stop-MgServicePrincipalSynchronizationJob](Stop-MgServicePrincipalSynchronizationJob.md)
Invoke action stop

### [Suspend-MgApplicationSynchronizationJob](Suspend-MgApplicationSynchronizationJob.md)
Invoke action pause

### [Suspend-MgServicePrincipalSynchronizationJob](Suspend-MgServicePrincipalSynchronizationJob.md)
Invoke action pause

### [Test-MgApplicationProperty](Test-MgApplicationProperty.md)
Invoke action validateProperties

### [Test-MgApplicationSynchronizationJobCredentials](Test-MgApplicationSynchronizationJobCredentials.md)
Invoke action validateCredentials

### [Test-MgServicePrincipalProperty](Test-MgServicePrincipalProperty.md)
Invoke action validateProperties

### [Test-MgServicePrincipalSynchronizationJobCredentials](Test-MgServicePrincipalSynchronizationJobCredentials.md)
Invoke action validateCredentials

### [Update-MgApplication](Update-MgApplication.md)
Update entity in applications

### [Update-MgApplicationExtensionProperty](Update-MgApplicationExtensionProperty.md)
Read-only.
Nullable.

### [Update-MgApplicationFederatedIdentityCredential](Update-MgApplicationFederatedIdentityCredential.md)
Federated identities for applications.
This object can only be retrieved on a single GET request (GET /applications/{id}/federatedIdentityCredentials).

### [Update-MgApplicationSynchronization](Update-MgApplicationSynchronization.md)
Update the navigation property synchronization in applications

### [Update-MgApplicationSynchronizationJob](Update-MgApplicationSynchronizationJob.md)
Update the navigation property jobs in applications

### [Update-MgApplicationSynchronizationJobSchema](Update-MgApplicationSynchronizationJobSchema.md)
The synchronization schema configured for the job.

### [Update-MgApplicationSynchronizationJobSchemaDirectory](Update-MgApplicationSynchronizationJobSchemaDirectory.md)
Contains the collection of directories and all of their objects.

### [Update-MgApplicationSynchronizationTemplate](Update-MgApplicationSynchronizationTemplate.md)
Update the navigation property templates in applications

### [Update-MgApplicationSynchronizationTemplateSchema](Update-MgApplicationSynchronizationTemplateSchema.md)
Default synchronization schema for the jobs based on this template.

### [Update-MgApplicationSynchronizationTemplateSchemaDirectory](Update-MgApplicationSynchronizationTemplateSchemaDirectory.md)
Contains the collection of directories and all of their objects.

### [Update-MgApplicationTemplate](Update-MgApplicationTemplate.md)
Update entity in applicationTemplates

### [Update-MgGroupAppRoleAssignment](Update-MgGroupAppRoleAssignment.md)
Represents the app roles a group has been granted for an application.
Supports $expand.

### [Update-MgOnPremisePublishingProfile](Update-MgOnPremisePublishingProfile.md)
Update entity in onPremisesPublishingProfiles

### [Update-MgOnPremisePublishingProfileAgent](Update-MgOnPremisePublishingProfileAgent.md)
List of existing onPremisesAgent objects.
Read-only.
Nullable.

### [Update-MgOnPremisePublishingProfileAgentGroup](Update-MgOnPremisePublishingProfileAgentGroup.md)
List of existing onPremisesAgentGroup objects.
Read-only.
Nullable.

### [Update-MgOnPremisePublishingProfileAgentGroupAgent](Update-MgOnPremisePublishingProfileAgentGroupAgent.md)
List of onPremisesAgent that are assigned to an onPremisesAgentGroup.
Read-only.
Nullable.

### [Update-MgOnPremisePublishingProfileAgentGroupPublishedResource](Update-MgOnPremisePublishingProfileAgentGroupPublishedResource.md)
List of publishedResource that are assigned to an onPremisesAgentGroup.
Read-only.
Nullable.

### [Update-MgOnPremisePublishingProfileAgentGroupPublishedResourceAgentGroup](Update-MgOnPremisePublishingProfileAgentGroupPublishedResourceAgentGroup.md)
List of onPremisesAgentGroups that a publishedResource is assigned to.
Read-only.
Nullable.

### [Update-MgOnPremisePublishingProfileConnector](Update-MgOnPremisePublishingProfileConnector.md)
List of existing connector objects for applications published through Application Proxy.
Read-only.
Nullable.

### [Update-MgOnPremisePublishingProfileConnectorGroup](Update-MgOnPremisePublishingProfileConnectorGroup.md)
List of existing connectorGroup objects for applications published through Application Proxy.
Read-only.
Nullable.

### [Update-MgOnPremisePublishingProfileConnectorMemberOf](Update-MgOnPremisePublishingProfileConnectorMemberOf.md)
The connectorGroup that the connector is a member of.
Read-only.

### [Update-MgOnPremisePublishingProfilePublishedResource](Update-MgOnPremisePublishingProfilePublishedResource.md)
List of existing publishedResource objects.
Read-only.
Nullable.

### [Update-MgOnPremisePublishingProfilePublishedResourceAgentGroup](Update-MgOnPremisePublishingProfilePublishedResourceAgentGroup.md)
List of onPremisesAgentGroups that a publishedResource is assigned to.
Read-only.
Nullable.

### [Update-MgOnPremisePublishingProfilePublishedResourceAgentGroupAgent](Update-MgOnPremisePublishingProfilePublishedResourceAgentGroupAgent.md)
List of onPremisesAgent that are assigned to an onPremisesAgentGroup.
Read-only.
Nullable.

### [Update-MgOnPremisePublishingProfilePublishedResourceAgentGroupPublishedResource](Update-MgOnPremisePublishingProfilePublishedResourceAgentGroupPublishedResource.md)
List of publishedResource that are assigned to an onPremisesAgentGroup.
Read-only.
Nullable.

### [Update-MgServicePrincipal](Update-MgServicePrincipal.md)
Update entity in servicePrincipals

### [Update-MgServicePrincipalAppRoleAssignedTo](Update-MgServicePrincipalAppRoleAssignedTo.md)
App role assignments for this app or service, granted to users, groups, and other service principals.Supports $expand.

### [Update-MgServicePrincipalAppRoleAssignment](Update-MgServicePrincipalAppRoleAssignment.md)
App role assignment for another app or service, granted to this service principal.
Supports $expand.

### [Update-MgServicePrincipalDelegatedPermissionClassification](Update-MgServicePrincipalDelegatedPermissionClassification.md)
The permission classifications for delegated permissions exposed by the app that this service principal represents.
Supports $expand.

### [Update-MgServicePrincipalEndpoint](Update-MgServicePrincipalEndpoint.md)
Endpoints available for discovery.
Services like Sharepoint populate this property with a tenant specific SharePoint endpoints that other applications can discover and use in their experiences.

### [Update-MgServicePrincipalFederatedIdentityCredential](Update-MgServicePrincipalFederatedIdentityCredential.md)
Update the navigation property federatedIdentityCredentials in servicePrincipals

### [Update-MgServicePrincipalLicenseDetail](Update-MgServicePrincipalLicenseDetail.md)
Update the navigation property licenseDetails in servicePrincipals

### [Update-MgServicePrincipalPasswordSingleSignOnCredentials](Update-MgServicePrincipalPasswordSingleSignOnCredentials.md)
Invoke action updatePasswordSingleSignOnCredentials

### [Update-MgServicePrincipalSynchronization](Update-MgServicePrincipalSynchronization.md)
Update the navigation property synchronization in servicePrincipals

### [Update-MgServicePrincipalSynchronizationJob](Update-MgServicePrincipalSynchronizationJob.md)
Update the navigation property jobs in servicePrincipals

### [Update-MgServicePrincipalSynchronizationJobSchema](Update-MgServicePrincipalSynchronizationJobSchema.md)
The synchronization schema configured for the job.

### [Update-MgServicePrincipalSynchronizationJobSchemaDirectory](Update-MgServicePrincipalSynchronizationJobSchemaDirectory.md)
Contains the collection of directories and all of their objects.

### [Update-MgServicePrincipalSynchronizationTemplate](Update-MgServicePrincipalSynchronizationTemplate.md)
Update the navigation property templates in servicePrincipals

### [Update-MgServicePrincipalSynchronizationTemplateSchema](Update-MgServicePrincipalSynchronizationTemplateSchema.md)
Default synchronization schema for the jobs based on this template.

### [Update-MgServicePrincipalSynchronizationTemplateSchemaDirectory](Update-MgServicePrincipalSynchronizationTemplateSchemaDirectory.md)
Contains the collection of directories and all of their objects.

### [Update-MgUserAppRoleAssignment](Update-MgUserAppRoleAssignment.md)
Represents the app roles a user has been granted for an application.
Supports $expand.

