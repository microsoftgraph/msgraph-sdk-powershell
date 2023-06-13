---
Module Name: Microsoft.Graph.Applications
Module Guid: 44c70db7-1146-48db-b82c-92898210b76d
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
Get the properties and relationships of an application object.

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
Supports $filter (/$count eq 0, /$count ne 0).
Read-only.

### [Get-MgApplicationDelta](Get-MgApplicationDelta.md)
Invoke function delta

### [Get-MgApplicationExtensionProperty](Get-MgApplicationExtensionProperty.md)
Read-only.
Nullable.
Supports $expand and $filter (/$count eq 0, /$count ne 0).

### [Get-MgApplicationFederatedIdentityCredential](Get-MgApplicationFederatedIdentityCredential.md)
Federated identities for applications.
Supports $expand and $filter (startsWith, /$count eq 0, /$count ne 0).

### [Get-MgApplicationHomeRealmDiscoveryPolicy](Get-MgApplicationHomeRealmDiscoveryPolicy.md)
Get homeRealmDiscoveryPolicies from applications

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
Supports $expand and $filter (/$count eq 0, /$count ne 0, /$count eq 1, /$count ne 1).

### [Get-MgApplicationOwnerAsEndpoint](Get-MgApplicationOwnerAsEndpoint.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.endpoint

### [Get-MgApplicationOwnerAsServicePrincipal](Get-MgApplicationOwnerAsServicePrincipal.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.servicePrincipal

### [Get-MgApplicationOwnerAsUser](Get-MgApplicationOwnerAsUser.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.user

### [Get-MgApplicationOwnerByRef](Get-MgApplicationOwnerByRef.md)
Directory objects that are owners of the application.
Read-only.
Nullable.
Supports $expand and $filter (/$count eq 0, /$count ne 0, /$count eq 1, /$count ne 1).

### [Get-MgApplicationSynchronization](Get-MgApplicationSynchronization.md)
Represents the capability for Azure Active Directory (Azure AD) identity synchronization through the Microsoft Graph API.

### [Get-MgApplicationSynchronizationAccessToken](Get-MgApplicationSynchronizationAccessToken.md)
Invoke action acquireAccessToken

### [Get-MgApplicationSynchronizationJob](Get-MgApplicationSynchronizationJob.md)
Performs synchronization by periodically running in the background, polling for changes in one directory, and pushing them to another directory.

### [Get-MgApplicationSynchronizationJobSchema](Get-MgApplicationSynchronizationJobSchema.md)
The synchronization schema configured for the job.

### [Get-MgApplicationSynchronizationJobSchemaDirectory](Get-MgApplicationSynchronizationJobSchemaDirectory.md)
Contains the collection of directories and all of their objects.

### [Get-MgApplicationSynchronizationTemplate](Get-MgApplicationSynchronizationTemplate.md)
Pre-configured synchronization settings for a particular application.

### [Get-MgApplicationSynchronizationTemplateSchema](Get-MgApplicationSynchronizationTemplateSchema.md)
Default synchronization schema for the jobs based on this template.

### [Get-MgApplicationSynchronizationTemplateSchemaDirectory](Get-MgApplicationSynchronizationTemplateSchemaDirectory.md)
Contains the collection of directories and all of their objects.

### [Get-MgApplicationTemplate](Get-MgApplicationTemplate.md)
Retrieve the properties of an applicationTemplate object.

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

### [Get-MgOnPremisePublishingProfileAgentGroupByRef](Get-MgOnPremisePublishingProfileAgentGroupByRef.md)
List of onPremisesAgentGroups that an onPremisesAgent is assigned to.
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

### [Get-MgOnPremisePublishingProfileAgentGroupPublishedResourceAgentGroupByRef](Get-MgOnPremisePublishingProfileAgentGroupPublishedResourceAgentGroupByRef.md)
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
Get applications from onPremisesPublishingProfiles

### [Get-MgOnPremisePublishingProfileConnectorGroupApplicationLogo](Get-MgOnPremisePublishingProfileConnectorGroupApplicationLogo.md)
The main logo for the application.
Not nullable.

### [Get-MgOnPremisePublishingProfileConnectorGroupMember](Get-MgOnPremisePublishingProfileConnectorGroupMember.md)
Get members from onPremisesPublishingProfiles

### [Get-MgOnPremisePublishingProfileConnectorGroupMemberByRef](Get-MgOnPremisePublishingProfileConnectorGroupMemberByRef.md)
Get ref of members from onPremisesPublishingProfiles

### [Get-MgOnPremisePublishingProfileConnectorMemberOf](Get-MgOnPremisePublishingProfileConnectorMemberOf.md)
The connectorGroup that the connector is a member of.
Read-only.

### [Get-MgOnPremisePublishingProfileConnectorMemberOfByRef](Get-MgOnPremisePublishingProfileConnectorMemberOfByRef.md)
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

### [Get-MgOnPremisePublishingProfilePublishedResourceAgentGroupByRef](Get-MgOnPremisePublishingProfilePublishedResourceAgentGroupByRef.md)
List of onPremisesAgentGroups that a publishedResource is assigned to.
Read-only.
Nullable.

### [Get-MgServicePrincipal](Get-MgServicePrincipal.md)
Retrieve the properties and relationships of a servicePrincipal object.

### [Get-MgServicePrincipalAppManagementPolicy](Get-MgServicePrincipalAppManagementPolicy.md)
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

### [Get-MgServicePrincipalCreatedObjectAsServicePrincipal](Get-MgServicePrincipalCreatedObjectAsServicePrincipal.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.servicePrincipal

### [Get-MgServicePrincipalDelegatedPermissionClassification](Get-MgServicePrincipalDelegatedPermissionClassification.md)
The permission classifications for delegated permissions exposed by the app that this service principal represents.
Supports $expand.

### [Get-MgServicePrincipalDelta](Get-MgServicePrincipalDelta.md)
Invoke function delta

### [Get-MgServicePrincipalEndpoint](Get-MgServicePrincipalEndpoint.md)
Endpoints available for discovery.
Services like Sharepoint populate this property with a tenant specific SharePoint endpoints that other applications can discover and use in their experiences.

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

### [Get-MgServicePrincipalMemberOfAsAdministrativeUnit](Get-MgServicePrincipalMemberOfAsAdministrativeUnit.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.administrativeUnit

### [Get-MgServicePrincipalMemberOfAsGroup](Get-MgServicePrincipalMemberOfAsGroup.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.group

### [Get-MgServicePrincipalOauth2PermissionGrant](Get-MgServicePrincipalOauth2PermissionGrant.md)
Delegated permission grants authorizing this service principal to access an API on behalf of a signed-in user.
Read-only.
Nullable.

### [Get-MgServicePrincipalOwnedObject](Get-MgServicePrincipalOwnedObject.md)
Directory objects that are owned by this service principal.
Read-only.
Nullable.
Supports $expand and $filter (/$count eq 0, /$count ne 0, /$count eq 1, /$count ne 1).

### [Get-MgServicePrincipalOwnedObjectAsApplication](Get-MgServicePrincipalOwnedObjectAsApplication.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.application

### [Get-MgServicePrincipalOwnedObjectAsEndpoint](Get-MgServicePrincipalOwnedObjectAsEndpoint.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.endpoint

### [Get-MgServicePrincipalOwnedObjectAsGroup](Get-MgServicePrincipalOwnedObjectAsGroup.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.group

### [Get-MgServicePrincipalOwnedObjectAsServicePrincipal](Get-MgServicePrincipalOwnedObjectAsServicePrincipal.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.servicePrincipal

### [Get-MgServicePrincipalOwner](Get-MgServicePrincipalOwner.md)
Directory objects that are owners of this servicePrincipal.
The owners are a set of non-admin users or servicePrincipals who are allowed to modify this object.
Read-only.
Nullable.
Supports $expand and $filter (/$count eq 0, /$count ne 0, /$count eq 1, /$count ne 1).

### [Get-MgServicePrincipalOwnerAsEndpoint](Get-MgServicePrincipalOwnerAsEndpoint.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.endpoint

### [Get-MgServicePrincipalOwnerAsServicePrincipal](Get-MgServicePrincipalOwnerAsServicePrincipal.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.servicePrincipal

### [Get-MgServicePrincipalOwnerAsUser](Get-MgServicePrincipalOwnerAsUser.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.user

### [Get-MgServicePrincipalOwnerByRef](Get-MgServicePrincipalOwnerByRef.md)
Directory objects that are owners of this servicePrincipal.
The owners are a set of non-admin users or servicePrincipals who are allowed to modify this object.
Read-only.
Nullable.
Supports $expand and $filter (/$count eq 0, /$count ne 0, /$count eq 1, /$count ne 1).

### [Get-MgServicePrincipalPasswordSingleSignOnCredentials](Get-MgServicePrincipalPasswordSingleSignOnCredentials.md)
Invoke action getPasswordSingleSignOnCredentials

### [Get-MgServicePrincipalSynchronization](Get-MgServicePrincipalSynchronization.md)
Represents the capability for Azure Active Directory (Azure AD) identity synchronization through the Microsoft Graph API.

### [Get-MgServicePrincipalSynchronizationAccessToken](Get-MgServicePrincipalSynchronizationAccessToken.md)
Invoke action acquireAccessToken

### [Get-MgServicePrincipalSynchronizationJob](Get-MgServicePrincipalSynchronizationJob.md)
Performs synchronization by periodically running in the background, polling for changes in one directory, and pushing them to another directory.

### [Get-MgServicePrincipalSynchronizationJobSchema](Get-MgServicePrincipalSynchronizationJobSchema.md)
The synchronization schema configured for the job.

### [Get-MgServicePrincipalSynchronizationJobSchemaDirectory](Get-MgServicePrincipalSynchronizationJobSchemaDirectory.md)
Contains the collection of directories and all of their objects.

### [Get-MgServicePrincipalSynchronizationTemplate](Get-MgServicePrincipalSynchronizationTemplate.md)
Pre-configured synchronization settings for a particular application.

### [Get-MgServicePrincipalSynchronizationTemplateSchema](Get-MgServicePrincipalSynchronizationTemplateSchema.md)
Default synchronization schema for the jobs based on this template.

### [Get-MgServicePrincipalSynchronizationTemplateSchemaDirectory](Get-MgServicePrincipalSynchronizationTemplateSchemaDirectory.md)
Contains the collection of directories and all of their objects.

### [Get-MgServicePrincipalTokenIssuancePolicy](Get-MgServicePrincipalTokenIssuancePolicy.md)
The tokenIssuancePolicies assigned to this service principal.
Supports $expand.

### [Get-MgServicePrincipalTokenLifetimePolicy](Get-MgServicePrincipalTokenLifetimePolicy.md)
The tokenLifetimePolicies assigned to this service principal.
Supports $expand.

### [Get-MgServicePrincipalTransitiveMemberOf](Get-MgServicePrincipalTransitiveMemberOf.md)
Get transitiveMemberOf from servicePrincipals

### [Get-MgServicePrincipalTransitiveMemberOfAsAdministrativeUnit](Get-MgServicePrincipalTransitiveMemberOfAsAdministrativeUnit.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.administrativeUnit

### [Get-MgServicePrincipalTransitiveMemberOfAsGroup](Get-MgServicePrincipalTransitiveMemberOfAsGroup.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.group

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
Create a new application object.

### [New-MgApplicationAppManagementPolicyByRef](New-MgApplicationAppManagementPolicyByRef.md)
Create new navigation property ref to appManagementPolicies for applications

### [New-MgApplicationExtensionProperty](New-MgApplicationExtensionProperty.md)
Create new navigation property to extensionProperties for applications

### [New-MgApplicationFederatedIdentityCredential](New-MgApplicationFederatedIdentityCredential.md)
Create new navigation property to federatedIdentityCredentials for applications

### [New-MgApplicationOwnerByRef](New-MgApplicationOwnerByRef.md)
Create new navigation property ref to owners for applications

### [New-MgApplicationSynchronizationJob](New-MgApplicationSynchronizationJob.md)
Create new navigation property to jobs for applications

### [New-MgApplicationSynchronizationJobOnDemand](New-MgApplicationSynchronizationJobOnDemand.md)
Invoke action provisionOnDemand

### [New-MgApplicationSynchronizationJobSchemaDirectory](New-MgApplicationSynchronizationJobSchemaDirectory.md)
Create new navigation property to directories for applications

### [New-MgApplicationSynchronizationTemplate](New-MgApplicationSynchronizationTemplate.md)
Create new navigation property to templates for applications

### [New-MgApplicationSynchronizationTemplateSchemaDirectory](New-MgApplicationSynchronizationTemplateSchemaDirectory.md)
Create new navigation property to directories for applications

### [New-MgApplicationTokenIssuancePolicyByRef](New-MgApplicationTokenIssuancePolicyByRef.md)
Create new navigation property ref to tokenIssuancePolicies for applications

### [New-MgApplicationTokenLifetimePolicyByRef](New-MgApplicationTokenLifetimePolicyByRef.md)
Create new navigation property ref to tokenLifetimePolicies for applications

### [New-MgGroupAppRoleAssignment](New-MgGroupAppRoleAssignment.md)
Create new navigation property to appRoleAssignments for groups

### [New-MgOnPremisePublishingProfile](New-MgOnPremisePublishingProfile.md)
Add new entity to onPremisesPublishingProfiles

### [New-MgOnPremisePublishingProfileAgent](New-MgOnPremisePublishingProfileAgent.md)
Create new navigation property to agents for onPremisesPublishingProfiles

### [New-MgOnPremisePublishingProfileAgentGroup](New-MgOnPremisePublishingProfileAgentGroup.md)
Create new navigation property to agentGroups for onPremisesPublishingProfiles

### [New-MgOnPremisePublishingProfileAgentGroupAgent](New-MgOnPremisePublishingProfileAgentGroupAgent.md)
Create new navigation property to agents for onPremisesPublishingProfiles

### [New-MgOnPremisePublishingProfileAgentGroupByRef](New-MgOnPremisePublishingProfileAgentGroupByRef.md)
Create new navigation property ref to agentGroups for onPremisesPublishingProfiles

### [New-MgOnPremisePublishingProfileAgentGroupPublishedResource](New-MgOnPremisePublishingProfileAgentGroupPublishedResource.md)
Create new navigation property to publishedResources for onPremisesPublishingProfiles

### [New-MgOnPremisePublishingProfileAgentGroupPublishedResourceAgentGroup](New-MgOnPremisePublishingProfileAgentGroupPublishedResourceAgentGroup.md)
Create new navigation property to agentGroups for onPremisesPublishingProfiles

### [New-MgOnPremisePublishingProfileAgentGroupPublishedResourceAgentGroupByRef](New-MgOnPremisePublishingProfileAgentGroupPublishedResourceAgentGroupByRef.md)
Create new navigation property ref to agentGroups for onPremisesPublishingProfiles

### [New-MgOnPremisePublishingProfileConnector](New-MgOnPremisePublishingProfileConnector.md)
Create new navigation property to connectors for onPremisesPublishingProfiles

### [New-MgOnPremisePublishingProfileConnectorGroup](New-MgOnPremisePublishingProfileConnectorGroup.md)
Create new navigation property to connectorGroups for onPremisesPublishingProfiles

### [New-MgOnPremisePublishingProfileConnectorMemberOfByRef](New-MgOnPremisePublishingProfileConnectorMemberOfByRef.md)
Create new navigation property ref to memberOf for onPremisesPublishingProfiles

### [New-MgOnPremisePublishingProfilePublishedResource](New-MgOnPremisePublishingProfilePublishedResource.md)
Create new navigation property to publishedResources for onPremisesPublishingProfiles

### [New-MgOnPremisePublishingProfilePublishedResourceAgentGroup](New-MgOnPremisePublishingProfilePublishedResourceAgentGroup.md)
Create new navigation property to agentGroups for onPremisesPublishingProfiles

### [New-MgOnPremisePublishingProfilePublishedResourceAgentGroupByRef](New-MgOnPremisePublishingProfilePublishedResourceAgentGroupByRef.md)
Create new navigation property ref to agentGroups for onPremisesPublishingProfiles

### [New-MgServicePrincipal](New-MgServicePrincipal.md)
Create a new servicePrincipal object.

### [New-MgServicePrincipalAppRoleAssignedTo](New-MgServicePrincipalAppRoleAssignedTo.md)
Create new navigation property to appRoleAssignedTo for servicePrincipals

### [New-MgServicePrincipalAppRoleAssignment](New-MgServicePrincipalAppRoleAssignment.md)
Create new navigation property to appRoleAssignments for servicePrincipals

### [New-MgServicePrincipalClaimMappingPolicyByRef](New-MgServicePrincipalClaimMappingPolicyByRef.md)
Create new navigation property ref to claimsMappingPolicies for servicePrincipals

### [New-MgServicePrincipalDelegatedPermissionClassification](New-MgServicePrincipalDelegatedPermissionClassification.md)
Create new navigation property to delegatedPermissionClassifications for servicePrincipals

### [New-MgServicePrincipalEndpoint](New-MgServicePrincipalEndpoint.md)
Create new navigation property to endpoints for servicePrincipals

### [New-MgServicePrincipalHomeRealmDiscoveryPolicyByRef](New-MgServicePrincipalHomeRealmDiscoveryPolicyByRef.md)
Create new navigation property ref to homeRealmDiscoveryPolicies for servicePrincipals

### [New-MgServicePrincipalLicenseDetail](New-MgServicePrincipalLicenseDetail.md)
Create new navigation property to licenseDetails for servicePrincipals

### [New-MgServicePrincipalOwnerByRef](New-MgServicePrincipalOwnerByRef.md)
Create new navigation property ref to owners for servicePrincipals

### [New-MgServicePrincipalPasswordSingleSignOnCredentials](New-MgServicePrincipalPasswordSingleSignOnCredentials.md)
Invoke action createPasswordSingleSignOnCredentials

### [New-MgServicePrincipalSynchronizationJob](New-MgServicePrincipalSynchronizationJob.md)
Create new navigation property to jobs for servicePrincipals

### [New-MgServicePrincipalSynchronizationJobOnDemand](New-MgServicePrincipalSynchronizationJobOnDemand.md)
Invoke action provisionOnDemand

### [New-MgServicePrincipalSynchronizationJobSchemaDirectory](New-MgServicePrincipalSynchronizationJobSchemaDirectory.md)
Create new navigation property to directories for servicePrincipals

### [New-MgServicePrincipalSynchronizationTemplate](New-MgServicePrincipalSynchronizationTemplate.md)
Create new navigation property to templates for servicePrincipals

### [New-MgServicePrincipalSynchronizationTemplateSchemaDirectory](New-MgServicePrincipalSynchronizationTemplateSchemaDirectory.md)
Create new navigation property to directories for servicePrincipals

### [New-MgUserAppRoleAssignment](New-MgUserAppRoleAssignment.md)
Create new navigation property to appRoleAssignments for users

### [Ping-MgApplicationsSynchronization](Ping-MgApplicationsSynchronization.md)
Invoke function Ping

### [Ping-MgServicePrincipalsSynchronization](Ping-MgServicePrincipalsSynchronization.md)
Invoke function Ping

### [Remove-MgApplication](Remove-MgApplication.md)
Deletes an application.
When deleted, apps are moved to a temporary container and can be restored within 30 days.
After that time, they are permanently deleted.

### [Remove-MgApplicationAppManagementPolicyByRef](Remove-MgApplicationAppManagementPolicyByRef.md)
Delete ref of navigation property appManagementPolicies for applications

### [Remove-MgApplicationConnectorGroupByRef](Remove-MgApplicationConnectorGroupByRef.md)
Delete ref of navigation property connectorGroup for applications

### [Remove-MgApplicationExtensionProperty](Remove-MgApplicationExtensionProperty.md)
Delete navigation property extensionProperties for applications

### [Remove-MgApplicationFederatedIdentityCredential](Remove-MgApplicationFederatedIdentityCredential.md)
Delete navigation property federatedIdentityCredentials for applications

### [Remove-MgApplicationKey](Remove-MgApplicationKey.md)
Invoke action removeKey

### [Remove-MgApplicationOwnerByRef](Remove-MgApplicationOwnerByRef.md)
Delete ref of navigation property owners for applications

### [Remove-MgApplicationPassword](Remove-MgApplicationPassword.md)
Invoke action removePassword

### [Remove-MgApplicationSynchronization](Remove-MgApplicationSynchronization.md)
Delete navigation property synchronization for applications

### [Remove-MgApplicationSynchronizationJob](Remove-MgApplicationSynchronizationJob.md)
Delete navigation property jobs for applications

### [Remove-MgApplicationSynchronizationJobSchema](Remove-MgApplicationSynchronizationJobSchema.md)
Delete navigation property schema for applications

### [Remove-MgApplicationSynchronizationJobSchemaDirectory](Remove-MgApplicationSynchronizationJobSchemaDirectory.md)
Delete navigation property directories for applications

### [Remove-MgApplicationSynchronizationTemplate](Remove-MgApplicationSynchronizationTemplate.md)
Delete navigation property templates for applications

### [Remove-MgApplicationSynchronizationTemplateSchema](Remove-MgApplicationSynchronizationTemplateSchema.md)
Delete navigation property schema for applications

### [Remove-MgApplicationSynchronizationTemplateSchemaDirectory](Remove-MgApplicationSynchronizationTemplateSchemaDirectory.md)
Delete navigation property directories for applications

### [Remove-MgApplicationTokenIssuancePolicyByRef](Remove-MgApplicationTokenIssuancePolicyByRef.md)
Delete ref of navigation property tokenIssuancePolicies for applications

### [Remove-MgApplicationTokenLifetimePolicyByRef](Remove-MgApplicationTokenLifetimePolicyByRef.md)
Delete ref of navigation property tokenLifetimePolicies for applications

### [Remove-MgGroupAppRoleAssignment](Remove-MgGroupAppRoleAssignment.md)
Delete navigation property appRoleAssignments for groups

### [Remove-MgOnPremisePublishingProfile](Remove-MgOnPremisePublishingProfile.md)
Delete entity from onPremisesPublishingProfiles

### [Remove-MgOnPremisePublishingProfileAgent](Remove-MgOnPremisePublishingProfileAgent.md)
Delete navigation property agents for onPremisesPublishingProfiles

### [Remove-MgOnPremisePublishingProfileAgentGroup](Remove-MgOnPremisePublishingProfileAgentGroup.md)
Delete navigation property agentGroups for onPremisesPublishingProfiles

### [Remove-MgOnPremisePublishingProfileAgentGroupAgent](Remove-MgOnPremisePublishingProfileAgentGroupAgent.md)
Delete navigation property agents for onPremisesPublishingProfiles

### [Remove-MgOnPremisePublishingProfileAgentGroupByRef](Remove-MgOnPremisePublishingProfileAgentGroupByRef.md)
Delete ref of navigation property agentGroups for onPremisesPublishingProfiles

### [Remove-MgOnPremisePublishingProfileAgentGroupPublishedResource](Remove-MgOnPremisePublishingProfileAgentGroupPublishedResource.md)
Delete navigation property publishedResources for onPremisesPublishingProfiles

### [Remove-MgOnPremisePublishingProfileAgentGroupPublishedResourceAgentGroupByRef](Remove-MgOnPremisePublishingProfileAgentGroupPublishedResourceAgentGroupByRef.md)
Delete ref of navigation property agentGroups for onPremisesPublishingProfiles

### [Remove-MgOnPremisePublishingProfileConnector](Remove-MgOnPremisePublishingProfileConnector.md)
Delete navigation property connectors for onPremisesPublishingProfiles

### [Remove-MgOnPremisePublishingProfileConnectorGroup](Remove-MgOnPremisePublishingProfileConnectorGroup.md)
Delete navigation property connectorGroups for onPremisesPublishingProfiles

### [Remove-MgOnPremisePublishingProfileConnectorMemberOfByRef](Remove-MgOnPremisePublishingProfileConnectorMemberOfByRef.md)
Delete ref of navigation property memberOf for onPremisesPublishingProfiles

### [Remove-MgOnPremisePublishingProfilePublishedResource](Remove-MgOnPremisePublishingProfilePublishedResource.md)
Delete navigation property publishedResources for onPremisesPublishingProfiles

### [Remove-MgOnPremisePublishingProfilePublishedResourceAgentGroupByRef](Remove-MgOnPremisePublishingProfilePublishedResourceAgentGroupByRef.md)
Delete ref of navigation property agentGroups for onPremisesPublishingProfiles

### [Remove-MgServicePrincipal](Remove-MgServicePrincipal.md)
Delete a servicePrincipal object.

### [Remove-MgServicePrincipalAppRoleAssignedTo](Remove-MgServicePrincipalAppRoleAssignedTo.md)
Delete navigation property appRoleAssignedTo for servicePrincipals

### [Remove-MgServicePrincipalAppRoleAssignment](Remove-MgServicePrincipalAppRoleAssignment.md)
Delete navigation property appRoleAssignments for servicePrincipals

### [Remove-MgServicePrincipalClaimMappingPolicyByRef](Remove-MgServicePrincipalClaimMappingPolicyByRef.md)
Delete ref of navigation property claimsMappingPolicies for servicePrincipals

### [Remove-MgServicePrincipalDelegatedPermissionClassification](Remove-MgServicePrincipalDelegatedPermissionClassification.md)
Delete navigation property delegatedPermissionClassifications for servicePrincipals

### [Remove-MgServicePrincipalEndpoint](Remove-MgServicePrincipalEndpoint.md)
Delete navigation property endpoints for servicePrincipals

### [Remove-MgServicePrincipalHomeRealmDiscoveryPolicyByRef](Remove-MgServicePrincipalHomeRealmDiscoveryPolicyByRef.md)
Delete ref of navigation property homeRealmDiscoveryPolicies for servicePrincipals

### [Remove-MgServicePrincipalLicenseDetail](Remove-MgServicePrincipalLicenseDetail.md)
Delete navigation property licenseDetails for servicePrincipals

### [Remove-MgServicePrincipalOwnerByRef](Remove-MgServicePrincipalOwnerByRef.md)
Delete ref of navigation property owners for servicePrincipals

### [Remove-MgServicePrincipalPasswordSingleSignOnCredentials](Remove-MgServicePrincipalPasswordSingleSignOnCredentials.md)
Invoke action deletePasswordSingleSignOnCredentials

### [Remove-MgServicePrincipalSynchronization](Remove-MgServicePrincipalSynchronization.md)
Delete navigation property synchronization for servicePrincipals

### [Remove-MgServicePrincipalSynchronizationJob](Remove-MgServicePrincipalSynchronizationJob.md)
Delete navigation property jobs for servicePrincipals

### [Remove-MgServicePrincipalSynchronizationJobSchema](Remove-MgServicePrincipalSynchronizationJobSchema.md)
Delete navigation property schema for servicePrincipals

### [Remove-MgServicePrincipalSynchronizationJobSchemaDirectory](Remove-MgServicePrincipalSynchronizationJobSchemaDirectory.md)
Delete navigation property directories for servicePrincipals

### [Remove-MgServicePrincipalSynchronizationTemplate](Remove-MgServicePrincipalSynchronizationTemplate.md)
Delete navigation property templates for servicePrincipals

### [Remove-MgServicePrincipalSynchronizationTemplateSchema](Remove-MgServicePrincipalSynchronizationTemplateSchema.md)
Delete navigation property schema for servicePrincipals

### [Remove-MgServicePrincipalSynchronizationTemplateSchemaDirectory](Remove-MgServicePrincipalSynchronizationTemplateSchemaDirectory.md)
Delete navigation property directories for servicePrincipals

### [Remove-MgUserAppRoleAssignment](Remove-MgUserAppRoleAssignment.md)
Delete navigation property appRoleAssignments for users

### [Restart-MgApplicationSynchronizationJob](Restart-MgApplicationSynchronizationJob.md)
Invoke action restart

### [Restart-MgServicePrincipalSynchronizationJob](Restart-MgServicePrincipalSynchronizationJob.md)
Invoke action restart

### [Set-MgApplicationConnectorGroupByRef](Set-MgApplicationConnectorGroupByRef.md)
Update the ref of navigation property connectorGroup in applications

### [Set-MgApplicationLogo](Set-MgApplicationLogo.md)
The main logo for the application.
Not nullable.

### [Set-MgApplicationSynchronizationSecret](Set-MgApplicationSynchronizationSecret.md)
Update property secrets value.

### [Set-MgApplicationVerifiedPublisher](Set-MgApplicationVerifiedPublisher.md)
Invoke action setVerifiedPublisher

### [Set-MgOnPremisePublishingProfileConnectorGroupApplicationLogo](Set-MgOnPremisePublishingProfileConnectorGroupApplicationLogo.md)
The main logo for the application.
Not nullable.

### [Set-MgServicePrincipalSynchronizationSecret](Set-MgServicePrincipalSynchronizationSecret.md)
Update property secrets value.

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
Update the properties of an application object.

### [Update-MgApplicationExtensionProperty](Update-MgApplicationExtensionProperty.md)
Update the navigation property extensionProperties in applications

### [Update-MgApplicationFederatedIdentityCredential](Update-MgApplicationFederatedIdentityCredential.md)
Update the navigation property federatedIdentityCredentials in applications

### [Update-MgApplicationSynchronization](Update-MgApplicationSynchronization.md)
Update the navigation property synchronization in applications

### [Update-MgApplicationSynchronizationJob](Update-MgApplicationSynchronizationJob.md)
Update the navigation property jobs in applications

### [Update-MgApplicationSynchronizationJobSchema](Update-MgApplicationSynchronizationJobSchema.md)
Update the navigation property schema in applications

### [Update-MgApplicationSynchronizationJobSchemaDirectory](Update-MgApplicationSynchronizationJobSchemaDirectory.md)
Update the navigation property directories in applications

### [Update-MgApplicationSynchronizationTemplate](Update-MgApplicationSynchronizationTemplate.md)
Update the navigation property templates in applications

### [Update-MgApplicationSynchronizationTemplateSchema](Update-MgApplicationSynchronizationTemplateSchema.md)
Update the navigation property schema in applications

### [Update-MgApplicationSynchronizationTemplateSchemaDirectory](Update-MgApplicationSynchronizationTemplateSchemaDirectory.md)
Update the navigation property directories in applications

### [Update-MgGroupAppRoleAssignment](Update-MgGroupAppRoleAssignment.md)
Update the navigation property appRoleAssignments in groups

### [Update-MgOnPremisePublishingProfile](Update-MgOnPremisePublishingProfile.md)
Update entity in onPremisesPublishingProfiles

### [Update-MgOnPremisePublishingProfileAgent](Update-MgOnPremisePublishingProfileAgent.md)
Update the navigation property agents in onPremisesPublishingProfiles

### [Update-MgOnPremisePublishingProfileAgentGroup](Update-MgOnPremisePublishingProfileAgentGroup.md)
Update the navigation property agentGroups in onPremisesPublishingProfiles

### [Update-MgOnPremisePublishingProfileAgentGroupAgent](Update-MgOnPremisePublishingProfileAgentGroupAgent.md)
Update the navigation property agents in onPremisesPublishingProfiles

### [Update-MgOnPremisePublishingProfileAgentGroupPublishedResource](Update-MgOnPremisePublishingProfileAgentGroupPublishedResource.md)
Update the navigation property publishedResources in onPremisesPublishingProfiles

### [Update-MgOnPremisePublishingProfileConnector](Update-MgOnPremisePublishingProfileConnector.md)
Update the navigation property connectors in onPremisesPublishingProfiles

### [Update-MgOnPremisePublishingProfileConnectorGroup](Update-MgOnPremisePublishingProfileConnectorGroup.md)
Update the navigation property connectorGroups in onPremisesPublishingProfiles

### [Update-MgOnPremisePublishingProfilePublishedResource](Update-MgOnPremisePublishingProfilePublishedResource.md)
Update the navigation property publishedResources in onPremisesPublishingProfiles

### [Update-MgServicePrincipal](Update-MgServicePrincipal.md)
Update the properties of servicePrincipal object.

### [Update-MgServicePrincipalAppRoleAssignedTo](Update-MgServicePrincipalAppRoleAssignedTo.md)
Update the navigation property appRoleAssignedTo in servicePrincipals

### [Update-MgServicePrincipalAppRoleAssignment](Update-MgServicePrincipalAppRoleAssignment.md)
Update the navigation property appRoleAssignments in servicePrincipals

### [Update-MgServicePrincipalDelegatedPermissionClassification](Update-MgServicePrincipalDelegatedPermissionClassification.md)
Update the navigation property delegatedPermissionClassifications in servicePrincipals

### [Update-MgServicePrincipalEndpoint](Update-MgServicePrincipalEndpoint.md)
Update the navigation property endpoints in servicePrincipals

### [Update-MgServicePrincipalLicenseDetail](Update-MgServicePrincipalLicenseDetail.md)
Update the navigation property licenseDetails in servicePrincipals

### [Update-MgServicePrincipalPasswordSingleSignOnCredentials](Update-MgServicePrincipalPasswordSingleSignOnCredentials.md)
Invoke action updatePasswordSingleSignOnCredentials

### [Update-MgServicePrincipalSynchronization](Update-MgServicePrincipalSynchronization.md)
Update the navigation property synchronization in servicePrincipals

### [Update-MgServicePrincipalSynchronizationJob](Update-MgServicePrincipalSynchronizationJob.md)
Update the navigation property jobs in servicePrincipals

### [Update-MgServicePrincipalSynchronizationJobSchema](Update-MgServicePrincipalSynchronizationJobSchema.md)
Update the navigation property schema in servicePrincipals

### [Update-MgServicePrincipalSynchronizationJobSchemaDirectory](Update-MgServicePrincipalSynchronizationJobSchemaDirectory.md)
Update the navigation property directories in servicePrincipals

### [Update-MgServicePrincipalSynchronizationTemplate](Update-MgServicePrincipalSynchronizationTemplate.md)
Update the navigation property templates in servicePrincipals

### [Update-MgServicePrincipalSynchronizationTemplateSchema](Update-MgServicePrincipalSynchronizationTemplateSchema.md)
Update the navigation property schema in servicePrincipals

### [Update-MgServicePrincipalSynchronizationTemplateSchemaDirectory](Update-MgServicePrincipalSynchronizationTemplateSchemaDirectory.md)
Update the navigation property directories in servicePrincipals

### [Update-MgUserAppRoleAssignment](Update-MgUserAppRoleAssignment.md)
Update the navigation property appRoleAssignments in users

