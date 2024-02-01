---
Module Name: Microsoft.Graph.Beta.Applications
Module Guid: 70250959-26a2-470e-9509-2713fa322104
Download Help Link: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.applications
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Beta.Applications Module
## Description
Microsoft Graph PowerShell Cmdlets

## Microsoft.Graph.Beta.Applications Cmdlets
### [Add-MgBetaApplicationKey](Add-MgBetaApplicationKey.md)
Add a key credential to an application.
This method, along with removeKey, can be used by an application to automate rolling its expiring keys.
As part of the request validation for this method, a proof of possession of an existing key is verified before the action can be performed.
Applications that don't have any existing valid certificates (no certificates have been added yet, or all certificates have expired), won't be able to use this service action.
You can use the Update application operation to perform an update instead.

### [Add-MgBetaApplicationPassword](Add-MgBetaApplicationPassword.md)
Adds a strong password to an application.

### [Add-MgBetaServicePrincipalTokenSigningCertificate](Add-MgBetaServicePrincipalTokenSigningCertificate.md)
Creates a self-signed signing certificate and returns a selfSignedCertificate object, which is the public part of the generated certificate.
The self-signed signing certificate is composed of the following objects which are added to the servicePrincipal: \n+ The keyCredentials object with the following objects:\n    + A private key object with usage set to Sign.\n    + A public key object with usage set to Verify.\n+ The passwordCredentials object.
All the objects have the same value of customKeyIdentifier.
The passwordCredential is used to open the PFX file (private key).
It and the associated private key object have the same value of keyId.
Once set during creation through the displayName property, the subject of the certificate cannot be updated.
The startDateTime is set to the same time the certificate is created using the action.
The endDateTime can be up to three years after the certificate is created.

### [Clear-MgBetaApplicationVerifiedPublisher](Clear-MgBetaApplicationVerifiedPublisher.md)
Unset the verifiedPublisher previously set on an application, removing all verified publisher properties.
For more information, see Publisher verification.

### [Confirm-MgBetaApplicationMemberGroup](Confirm-MgBetaApplicationMemberGroup.md)
Check for membership in a specified list of group IDs, and return from that list those groups (identified by IDs) of which the specified user, group, service principal, organizational contact, device, or directory object is a member.
This function is transitive.
You can check up to a maximum of 20 groups per request.
This function supports all groups provisioned in Microsoft Entra ID.
Because Microsoft 365 groups cannot contain other groups, membership in a Microsoft 365 group is always direct.

### [Confirm-MgBetaApplicationMemberObject](Confirm-MgBetaApplicationMemberObject.md)
Invoke action checkMemberObjects

### [Confirm-MgBetaServicePrincipalMemberGroup](Confirm-MgBetaServicePrincipalMemberGroup.md)
Check for membership in a specified list of group IDs, and return from that list those groups (identified by IDs) of which the specified user, group, service principal, organizational contact, device, or directory object is a member.
This function is transitive.
You can check up to a maximum of 20 groups per request.
This function supports all groups provisioned in Microsoft Entra ID.
Because Microsoft 365 groups cannot contain other groups, membership in a Microsoft 365 group is always direct.

### [Confirm-MgBetaServicePrincipalMemberObject](Confirm-MgBetaServicePrincipalMemberObject.md)
Invoke action checkMemberObjects

### [Find-MgBetaApplicationSynchronizationJobSchemaDirectory](Find-MgBetaApplicationSynchronizationJobSchemaDirectory.md)
Discover the latest schema definition for provisioning to an application.

### [Find-MgBetaApplicationSynchronizationTemplateSchemaDirectory](Find-MgBetaApplicationSynchronizationTemplateSchemaDirectory.md)
Discover the latest schema definition for provisioning to an application.

### [Find-MgBetaServicePrincipalSynchronizationJobSchemaDirectory](Find-MgBetaServicePrincipalSynchronizationJobSchemaDirectory.md)
Discover the latest schema definition for provisioning to an application.

### [Find-MgBetaServicePrincipalSynchronizationTemplateSchemaDirectory](Find-MgBetaServicePrincipalSynchronizationTemplateSchemaDirectory.md)
Discover the latest schema definition for provisioning to an application.

### [Get-MgBetaApplication](Get-MgBetaApplication.md)
Get the properties and relationships of an application object.

### [Get-MgBetaApplicationAppManagementPolicy](Get-MgBetaApplicationAppManagementPolicy.md)
The appManagementPolicy applied to this application.

### [Get-MgBetaApplicationAppManagementPolicyByRef](Get-MgBetaApplicationAppManagementPolicyByRef.md)
The appManagementPolicy applied to this application.

### [Get-MgBetaApplicationAppManagementPolicyCount](Get-MgBetaApplicationAppManagementPolicyCount.md)
Get the number of the resource

### [Get-MgBetaApplicationByAppId](Get-MgBetaApplicationByAppId.md)
Get the properties and relationships of an application object.

### [Get-MgBetaApplicationById](Get-MgBetaApplicationById.md)
Return the directory objects specified in a list of IDs.
Some common uses for this function are to:

### [Get-MgBetaApplicationByUniqueName](Get-MgBetaApplicationByUniqueName.md)
Get the properties and relationships of an application object.

### [Get-MgBetaApplicationConnectorGroup](Get-MgBetaApplicationConnectorGroup.md)
The connectorGroup the application is using with Microsoft Entra application proxy.
Nullable.

### [Get-MgBetaApplicationConnectorGroupByRef](Get-MgBetaApplicationConnectorGroupByRef.md)
The connectorGroup the application is using with Microsoft Entra application proxy.
Nullable.

### [Get-MgBetaApplicationCount](Get-MgBetaApplicationCount.md)
Get the number of the resource

### [Get-MgBetaApplicationCreatedOnBehalfOf](Get-MgBetaApplicationCreatedOnBehalfOf.md)
Supports $filter (/$count eq 0, /$count ne 0).
Read-only.

### [Get-MgBetaApplicationDelta](Get-MgBetaApplicationDelta.md)
Invoke function delta

### [Get-MgBetaApplicationExtensionProperty](Get-MgBetaApplicationExtensionProperty.md)
Read a directory extension definition represented by an extensionProperty object.

### [Get-MgBetaApplicationExtensionPropertyCount](Get-MgBetaApplicationExtensionPropertyCount.md)
Get the number of the resource

### [Get-MgBetaApplicationFederatedIdentityCredential](Get-MgBetaApplicationFederatedIdentityCredential.md)
Read the properties and relationships of a federatedIdentityCredential object.

### [Get-MgBetaApplicationFederatedIdentityCredentialCount](Get-MgBetaApplicationFederatedIdentityCredentialCount.md)
Get the number of the resource

### [Get-MgBetaApplicationHomeRealmDiscoveryPolicy](Get-MgBetaApplicationHomeRealmDiscoveryPolicy.md)
Get homeRealmDiscoveryPolicies from applications

### [Get-MgBetaApplicationHomeRealmDiscoveryPolicyCount](Get-MgBetaApplicationHomeRealmDiscoveryPolicyCount.md)
Get the number of the resource

### [Get-MgBetaApplicationLogo](Get-MgBetaApplicationLogo.md)
The main logo for the application.
Not nullable.

### [Get-MgBetaApplicationMemberGroup](Get-MgBetaApplicationMemberGroup.md)
Return all the group IDs for the groups that the specified user, group, service principal, organizational contact, device, or directory object is a member of.
This function is transitive.
This API returns up to 11,000 group IDs.
If more than 11,000 results are available, it returns a 400 Bad Request error with the Directory_ResultSizeLimitExceeded error code.
As a workaround, use the List group transitive memberOf API.

### [Get-MgBetaApplicationMemberObject](Get-MgBetaApplicationMemberObject.md)
Invoke action getMemberObjects

### [Get-MgBetaApplicationOwner](Get-MgBetaApplicationOwner.md)
Directory objects that are owners of the application.
Read-only.
Nullable.
Supports $expand, $filter (/$count eq 0, /$count ne 0, /$count eq 1, /$count ne 1), and $select nested in $expand.

### [Get-MgBetaApplicationOwnerAsEndpoint](Get-MgBetaApplicationOwnerAsEndpoint.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.endpoint

### [Get-MgBetaApplicationOwnerAsServicePrincipal](Get-MgBetaApplicationOwnerAsServicePrincipal.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.servicePrincipal

### [Get-MgBetaApplicationOwnerAsUser](Get-MgBetaApplicationOwnerAsUser.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.user

### [Get-MgBetaApplicationOwnerByRef](Get-MgBetaApplicationOwnerByRef.md)
Directory objects that are owners of the application.
Read-only.
Nullable.
Supports $expand, $filter (/$count eq 0, /$count ne 0, /$count eq 1, /$count ne 1), and $select nested in $expand.

### [Get-MgBetaApplicationOwnerCount](Get-MgBetaApplicationOwnerCount.md)
Get the number of the resource

### [Get-MgBetaApplicationOwnerCountAsEndpoint](Get-MgBetaApplicationOwnerCountAsEndpoint.md)
Get the number of the resource

### [Get-MgBetaApplicationOwnerCountAsServicePrincipal](Get-MgBetaApplicationOwnerCountAsServicePrincipal.md)
Get the number of the resource

### [Get-MgBetaApplicationOwnerCountAsUser](Get-MgBetaApplicationOwnerCountAsUser.md)
Get the number of the resource

### [Get-MgBetaApplicationSynchronization](Get-MgBetaApplicationSynchronization.md)
Represents the capability for Microsoft Entra identity synchronization through the Microsoft Graph API.

### [Get-MgBetaApplicationSynchronizationAccessToken](Get-MgBetaApplicationSynchronizationAccessToken.md)
Acquire an OAuth Access token to authorize the Microsoft Entra provisioning service to provision users into an application.

### [Get-MgBetaApplicationSynchronizationJob](Get-MgBetaApplicationSynchronizationJob.md)
Retrieve the existing synchronization job and its properties.

### [Get-MgBetaApplicationSynchronizationJobBulkUpload](Get-MgBetaApplicationSynchronizationJobBulkUpload.md)
The bulk upload operation for the job.

### [Get-MgBetaApplicationSynchronizationJobBulkUploadContent](Get-MgBetaApplicationSynchronizationJobBulkUploadContent.md)
Get media content for the navigation property bulkUpload from applications

### [Get-MgBetaApplicationSynchronizationJobCount](Get-MgBetaApplicationSynchronizationJobCount.md)
Get the number of the resource

### [Get-MgBetaApplicationSynchronizationJobSchema](Get-MgBetaApplicationSynchronizationJobSchema.md)
Retrieve the schema for a given synchronization job or template.

### [Get-MgBetaApplicationSynchronizationJobSchemaDirectory](Get-MgBetaApplicationSynchronizationJobSchemaDirectory.md)
Contains the collection of directories and all of their objects.

### [Get-MgBetaApplicationSynchronizationJobSchemaDirectoryCount](Get-MgBetaApplicationSynchronizationJobSchemaDirectoryCount.md)
Get the number of the resource

### [Get-MgBetaApplicationSynchronizationSecretCount](Get-MgBetaApplicationSynchronizationSecretCount.md)
Get the number of the resource

### [Get-MgBetaApplicationSynchronizationTemplate](Get-MgBetaApplicationSynchronizationTemplate.md)
Pre-configured synchronization settings for a particular application.

### [Get-MgBetaApplicationSynchronizationTemplateCount](Get-MgBetaApplicationSynchronizationTemplateCount.md)
Get the number of the resource

### [Get-MgBetaApplicationSynchronizationTemplateSchema](Get-MgBetaApplicationSynchronizationTemplateSchema.md)
Default synchronization schema for the jobs based on this template.

### [Get-MgBetaApplicationSynchronizationTemplateSchemaDirectory](Get-MgBetaApplicationSynchronizationTemplateSchemaDirectory.md)
Contains the collection of directories and all of their objects.

### [Get-MgBetaApplicationSynchronizationTemplateSchemaDirectoryCount](Get-MgBetaApplicationSynchronizationTemplateSchemaDirectoryCount.md)
Get the number of the resource

### [Get-MgBetaApplicationTemplate](Get-MgBetaApplicationTemplate.md)
Retrieve the properties of an applicationTemplate object.

### [Get-MgBetaApplicationTemplateCount](Get-MgBetaApplicationTemplateCount.md)
Get the number of the resource

### [Get-MgBetaApplicationTokenIssuancePolicy](Get-MgBetaApplicationTokenIssuancePolicy.md)
List the tokenIssuancePolicy objects that are assigned to an application.

### [Get-MgBetaApplicationTokenIssuancePolicyByRef](Get-MgBetaApplicationTokenIssuancePolicyByRef.md)
List the tokenIssuancePolicy objects that are assigned to an application.

### [Get-MgBetaApplicationTokenIssuancePolicyCount](Get-MgBetaApplicationTokenIssuancePolicyCount.md)
Get the number of the resource

### [Get-MgBetaApplicationTokenLifetimePolicy](Get-MgBetaApplicationTokenLifetimePolicy.md)
List the tokenLifetimePolicy objects that are assigned to an application or servicePrincipal.
Only one object is returned in the collection because only one tokenLifetimePolicy can be assigned to an application.

### [Get-MgBetaApplicationTokenLifetimePolicyByRef](Get-MgBetaApplicationTokenLifetimePolicyByRef.md)
List the tokenLifetimePolicy objects that are assigned to an application or servicePrincipal.
Only one object is returned in the collection because only one tokenLifetimePolicy can be assigned to an application.

### [Get-MgBetaApplicationTokenLifetimePolicyCount](Get-MgBetaApplicationTokenLifetimePolicyCount.md)
Get the number of the resource

### [Get-MgBetaApplicationUserOwnedObject](Get-MgBetaApplicationUserOwnedObject.md)
Retrieve a list of recently deleted application and group objects owned by the specified user.
This API returns up to 1,000 deleted objects owned by the user, sorted by ID, and doesn't support pagination.

### [Get-MgBetaGroupAppRoleAssignment](Get-MgBetaGroupAppRoleAssignment.md)
Represents the app roles a group has been granted for an application.
Supports $expand.

### [Get-MgBetaGroupAppRoleAssignmentCount](Get-MgBetaGroupAppRoleAssignmentCount.md)
Get the number of the resource

### [Get-MgBetaOnPremisePublishingProfile](Get-MgBetaOnPremisePublishingProfile.md)
Get entity from onPremisesPublishingProfiles by key

### [Get-MgBetaOnPremisePublishingProfileAgent](Get-MgBetaOnPremisePublishingProfileAgent.md)
Retrieve the properties and relationships of an onPremisesAgent object.

### [Get-MgBetaOnPremisePublishingProfileAgentCount](Get-MgBetaOnPremisePublishingProfileAgentCount.md)
Get the number of the resource

### [Get-MgBetaOnPremisePublishingProfileAgentGroup](Get-MgBetaOnPremisePublishingProfileAgentGroup.md)
Retrieve the properties and relationships of an onPremisesAgentGroup object.

### [Get-MgBetaOnPremisePublishingProfileAgentGroupAgent](Get-MgBetaOnPremisePublishingProfileAgentGroupAgent.md)
List of onPremisesAgent that are assigned to an onPremisesAgentGroup.
Read-only.
Nullable.

### [Get-MgBetaOnPremisePublishingProfileAgentGroupAgentCount](Get-MgBetaOnPremisePublishingProfileAgentGroupAgentCount.md)
Get the number of the resource

### [Get-MgBetaOnPremisePublishingProfileAgentGroupByRef](Get-MgBetaOnPremisePublishingProfileAgentGroupByRef.md)
List of onPremisesAgentGroups that an onPremisesAgent is assigned to.
Read-only.
Nullable.

### [Get-MgBetaOnPremisePublishingProfileAgentGroupCount](Get-MgBetaOnPremisePublishingProfileAgentGroupCount.md)
Get the number of the resource

### [Get-MgBetaOnPremisePublishingProfileAgentGroupPublishedResource](Get-MgBetaOnPremisePublishingProfileAgentGroupPublishedResource.md)
List of publishedResource that are assigned to an onPremisesAgentGroup.
Read-only.
Nullable.

### [Get-MgBetaOnPremisePublishingProfileAgentGroupPublishedResourceAgentGroup](Get-MgBetaOnPremisePublishingProfileAgentGroupPublishedResourceAgentGroup.md)
List of onPremisesAgentGroups that a publishedResource is assigned to.
Read-only.
Nullable.

### [Get-MgBetaOnPremisePublishingProfileAgentGroupPublishedResourceAgentGroupByRef](Get-MgBetaOnPremisePublishingProfileAgentGroupPublishedResourceAgentGroupByRef.md)
List of onPremisesAgentGroups that a publishedResource is assigned to.
Read-only.
Nullable.

### [Get-MgBetaOnPremisePublishingProfileAgentGroupPublishedResourceAgentGroupCount](Get-MgBetaOnPremisePublishingProfileAgentGroupPublishedResourceAgentGroupCount.md)
Get the number of the resource

### [Get-MgBetaOnPremisePublishingProfileAgentGroupPublishedResourceCount](Get-MgBetaOnPremisePublishingProfileAgentGroupPublishedResourceCount.md)
Get the number of the resource

### [Get-MgBetaOnPremisePublishingProfileConnector](Get-MgBetaOnPremisePublishingProfileConnector.md)
Retrieve the properties and relationships of a connector object.

### [Get-MgBetaOnPremisePublishingProfileConnectorCount](Get-MgBetaOnPremisePublishingProfileConnectorCount.md)
Get the number of the resource

### [Get-MgBetaOnPremisePublishingProfileConnectorGroup](Get-MgBetaOnPremisePublishingProfileConnectorGroup.md)
Retrieve the properties of a connectorGroup.

### [Get-MgBetaOnPremisePublishingProfileConnectorGroupApplication](Get-MgBetaOnPremisePublishingProfileConnectorGroupApplication.md)
Get applications from onPremisesPublishingProfiles

### [Get-MgBetaOnPremisePublishingProfileConnectorGroupApplicationCount](Get-MgBetaOnPremisePublishingProfileConnectorGroupApplicationCount.md)
Get the number of the resource

### [Get-MgBetaOnPremisePublishingProfileConnectorGroupApplicationLogo](Get-MgBetaOnPremisePublishingProfileConnectorGroupApplicationLogo.md)
The main logo for the application.
Not nullable.

### [Get-MgBetaOnPremisePublishingProfileConnectorGroupCount](Get-MgBetaOnPremisePublishingProfileConnectorGroupCount.md)
Get the number of the resource

### [Get-MgBetaOnPremisePublishingProfileConnectorGroupMember](Get-MgBetaOnPremisePublishingProfileConnectorGroupMember.md)
Get members from onPremisesPublishingProfiles

### [Get-MgBetaOnPremisePublishingProfileConnectorGroupMemberByRef](Get-MgBetaOnPremisePublishingProfileConnectorGroupMemberByRef.md)
Get ref of members from onPremisesPublishingProfiles

### [Get-MgBetaOnPremisePublishingProfileConnectorGroupMemberCount](Get-MgBetaOnPremisePublishingProfileConnectorGroupMemberCount.md)
Get the number of the resource

### [Get-MgBetaOnPremisePublishingProfileConnectorMemberOf](Get-MgBetaOnPremisePublishingProfileConnectorMemberOf.md)
The connectorGroup that the connector is a member of.
Read-only.

### [Get-MgBetaOnPremisePublishingProfileConnectorMemberOfByRef](Get-MgBetaOnPremisePublishingProfileConnectorMemberOfByRef.md)
The connectorGroup that the connector is a member of.
Read-only.

### [Get-MgBetaOnPremisePublishingProfileConnectorMemberOfCount](Get-MgBetaOnPremisePublishingProfileConnectorMemberOfCount.md)
Get the number of the resource

### [Get-MgBetaOnPremisePublishingProfileCount](Get-MgBetaOnPremisePublishingProfileCount.md)
Get the number of the resource

### [Get-MgBetaOnPremisePublishingProfilePublishedResource](Get-MgBetaOnPremisePublishingProfilePublishedResource.md)
Retrieve the properties and relationships of publishedResource object.

### [Get-MgBetaOnPremisePublishingProfilePublishedResourceAgentGroup](Get-MgBetaOnPremisePublishingProfilePublishedResourceAgentGroup.md)
List of onPremisesAgentGroups that a publishedResource is assigned to.
Read-only.
Nullable.

### [Get-MgBetaOnPremisePublishingProfilePublishedResourceAgentGroupByRef](Get-MgBetaOnPremisePublishingProfilePublishedResourceAgentGroupByRef.md)
List of onPremisesAgentGroups that a publishedResource is assigned to.
Read-only.
Nullable.

### [Get-MgBetaOnPremisePublishingProfilePublishedResourceAgentGroupCount](Get-MgBetaOnPremisePublishingProfilePublishedResourceAgentGroupCount.md)
Get the number of the resource

### [Get-MgBetaOnPremisePublishingProfilePublishedResourceCount](Get-MgBetaOnPremisePublishingProfilePublishedResourceCount.md)
Get the number of the resource

### [Get-MgBetaServicePrincipal](Get-MgBetaServicePrincipal.md)
Retrieve the properties and relationships of a servicePrincipal object.

### [Get-MgBetaServicePrincipalAppManagementPolicy](Get-MgBetaServicePrincipalAppManagementPolicy.md)
The appManagementPolicy applied to this service principal.

### [Get-MgBetaServicePrincipalAppManagementPolicyCount](Get-MgBetaServicePrincipalAppManagementPolicyCount.md)
Get the number of the resource

### [Get-MgBetaServicePrincipalAppRoleAssignedTo](Get-MgBetaServicePrincipalAppRoleAssignedTo.md)
App role assignments for this app or service, granted to users, groups, and other service principals.Supports $expand.

### [Get-MgBetaServicePrincipalAppRoleAssignedToCount](Get-MgBetaServicePrincipalAppRoleAssignedToCount.md)
Get the number of the resource

### [Get-MgBetaServicePrincipalAppRoleAssignment](Get-MgBetaServicePrincipalAppRoleAssignment.md)
App role assignment for another app or service, granted to this service principal.
Supports $expand.

### [Get-MgBetaServicePrincipalAppRoleAssignmentCount](Get-MgBetaServicePrincipalAppRoleAssignmentCount.md)
Get the number of the resource

### [Get-MgBetaServicePrincipalByAppId](Get-MgBetaServicePrincipalByAppId.md)
Retrieve the properties and relationships of a servicePrincipal object.

### [Get-MgBetaServicePrincipalById](Get-MgBetaServicePrincipalById.md)
Return the directory objects specified in a list of IDs.
Some common uses for this function are to:

### [Get-MgBetaServicePrincipalClaimMappingPolicy](Get-MgBetaServicePrincipalClaimMappingPolicy.md)
List the claimsMappingPolicy objects that are assigned to a servicePrincipal.

### [Get-MgBetaServicePrincipalClaimMappingPolicyByRef](Get-MgBetaServicePrincipalClaimMappingPolicyByRef.md)
List the claimsMappingPolicy objects that are assigned to a servicePrincipal.

### [Get-MgBetaServicePrincipalClaimMappingPolicyCount](Get-MgBetaServicePrincipalClaimMappingPolicyCount.md)
Get the number of the resource

### [Get-MgBetaServicePrincipalCount](Get-MgBetaServicePrincipalCount.md)
Get the number of the resource

### [Get-MgBetaServicePrincipalCreatedObject](Get-MgBetaServicePrincipalCreatedObject.md)
Directory objects created by this service principal.
Read-only.
Nullable.

### [Get-MgBetaServicePrincipalCreatedObjectAsServicePrincipal](Get-MgBetaServicePrincipalCreatedObjectAsServicePrincipal.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.servicePrincipal

### [Get-MgBetaServicePrincipalCreatedObjectCount](Get-MgBetaServicePrincipalCreatedObjectCount.md)
Get the number of the resource

### [Get-MgBetaServicePrincipalCreatedObjectCountAsServicePrincipal](Get-MgBetaServicePrincipalCreatedObjectCountAsServicePrincipal.md)
Get the number of the resource

### [Get-MgBetaServicePrincipalDelegatedPermissionClassification](Get-MgBetaServicePrincipalDelegatedPermissionClassification.md)
The permission classifications for delegated permissions exposed by the app that this service principal represents.
Supports $expand.

### [Get-MgBetaServicePrincipalDelegatedPermissionClassificationCount](Get-MgBetaServicePrincipalDelegatedPermissionClassificationCount.md)
Get the number of the resource

### [Get-MgBetaServicePrincipalDelta](Get-MgBetaServicePrincipalDelta.md)
Invoke function delta

### [Get-MgBetaServicePrincipalEndpoint](Get-MgBetaServicePrincipalEndpoint.md)
Endpoints available for discovery.
Services like Sharepoint populate this property with a tenant specific SharePoint endpoints that other applications can discover and use in their experiences.

### [Get-MgBetaServicePrincipalEndpointCount](Get-MgBetaServicePrincipalEndpointCount.md)
Get the number of the resource

### [Get-MgBetaServicePrincipalHomeRealmDiscoveryPolicy](Get-MgBetaServicePrincipalHomeRealmDiscoveryPolicy.md)
List the homeRealmDiscoveryPolicy objects that are assigned to a servicePrincipal.

### [Get-MgBetaServicePrincipalHomeRealmDiscoveryPolicyByRef](Get-MgBetaServicePrincipalHomeRealmDiscoveryPolicyByRef.md)
List the homeRealmDiscoveryPolicy objects that are assigned to a servicePrincipal.

### [Get-MgBetaServicePrincipalHomeRealmDiscoveryPolicyCount](Get-MgBetaServicePrincipalHomeRealmDiscoveryPolicyCount.md)
Get the number of the resource

### [Get-MgBetaServicePrincipalLicenseDetail](Get-MgBetaServicePrincipalLicenseDetail.md)
Get licenseDetails from servicePrincipals

### [Get-MgBetaServicePrincipalLicenseDetailCount](Get-MgBetaServicePrincipalLicenseDetailCount.md)
Get the number of the resource

### [Get-MgBetaServicePrincipalLicenseDetailTeamLicensingDetail](Get-MgBetaServicePrincipalLicenseDetailTeamLicensingDetail.md)
Invoke function getTeamsLicensingDetails

### [Get-MgBetaServicePrincipalMemberGroup](Get-MgBetaServicePrincipalMemberGroup.md)
Return all the group IDs for the groups that the specified user, group, service principal, organizational contact, device, or directory object is a member of.
This function is transitive.
This API returns up to 11,000 group IDs.
If more than 11,000 results are available, it returns a 400 Bad Request error with the Directory_ResultSizeLimitExceeded error code.
As a workaround, use the List group transitive memberOf API.

### [Get-MgBetaServicePrincipalMemberObject](Get-MgBetaServicePrincipalMemberObject.md)
Invoke action getMemberObjects

### [Get-MgBetaServicePrincipalMemberOf](Get-MgBetaServicePrincipalMemberOf.md)
Roles that this service principal is a member of.
HTTP Methods: GET Read-only.
Nullable.
Supports $expand.

### [Get-MgBetaServicePrincipalMemberOfAsAdministrativeUnit](Get-MgBetaServicePrincipalMemberOfAsAdministrativeUnit.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.administrativeUnit

### [Get-MgBetaServicePrincipalMemberOfAsDirectoryRole](Get-MgBetaServicePrincipalMemberOfAsDirectoryRole.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.directoryRole

### [Get-MgBetaServicePrincipalMemberOfAsGroup](Get-MgBetaServicePrincipalMemberOfAsGroup.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.group

### [Get-MgBetaServicePrincipalMemberOfCount](Get-MgBetaServicePrincipalMemberOfCount.md)
Get the number of the resource

### [Get-MgBetaServicePrincipalMemberOfCountAsAdministrativeUnit](Get-MgBetaServicePrincipalMemberOfCountAsAdministrativeUnit.md)
Get the number of the resource

### [Get-MgBetaServicePrincipalMemberOfCountAsDirectoryRole](Get-MgBetaServicePrincipalMemberOfCountAsDirectoryRole.md)
Get the number of the resource

### [Get-MgBetaServicePrincipalMemberOfCountAsGroup](Get-MgBetaServicePrincipalMemberOfCountAsGroup.md)
Get the number of the resource

### [Get-MgBetaServicePrincipalOauth2PermissionGrant](Get-MgBetaServicePrincipalOauth2PermissionGrant.md)
Delegated permission grants authorizing this service principal to access an API on behalf of a signed-in user.
Read-only.
Nullable.

### [Get-MgBetaServicePrincipalOauth2PermissionGrantCount](Get-MgBetaServicePrincipalOauth2PermissionGrantCount.md)
Get the number of the resource

### [Get-MgBetaServicePrincipalOwnedObject](Get-MgBetaServicePrincipalOwnedObject.md)
Directory objects that are owned by this service principal.
Read-only.
Nullable.
Supports $expand and $filter (/$count eq 0, /$count ne 0, /$count eq 1, /$count ne 1).

### [Get-MgBetaServicePrincipalOwnedObjectAsApplication](Get-MgBetaServicePrincipalOwnedObjectAsApplication.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.application

### [Get-MgBetaServicePrincipalOwnedObjectAsEndpoint](Get-MgBetaServicePrincipalOwnedObjectAsEndpoint.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.endpoint

### [Get-MgBetaServicePrincipalOwnedObjectAsGroup](Get-MgBetaServicePrincipalOwnedObjectAsGroup.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.group

### [Get-MgBetaServicePrincipalOwnedObjectAsServicePrincipal](Get-MgBetaServicePrincipalOwnedObjectAsServicePrincipal.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.servicePrincipal

### [Get-MgBetaServicePrincipalOwnedObjectCount](Get-MgBetaServicePrincipalOwnedObjectCount.md)
Get the number of the resource

### [Get-MgBetaServicePrincipalOwnedObjectCountAsApplication](Get-MgBetaServicePrincipalOwnedObjectCountAsApplication.md)
Get the number of the resource

### [Get-MgBetaServicePrincipalOwnedObjectCountAsEndpoint](Get-MgBetaServicePrincipalOwnedObjectCountAsEndpoint.md)
Get the number of the resource

### [Get-MgBetaServicePrincipalOwnedObjectCountAsGroup](Get-MgBetaServicePrincipalOwnedObjectCountAsGroup.md)
Get the number of the resource

### [Get-MgBetaServicePrincipalOwnedObjectCountAsServicePrincipal](Get-MgBetaServicePrincipalOwnedObjectCountAsServicePrincipal.md)
Get the number of the resource

### [Get-MgBetaServicePrincipalOwner](Get-MgBetaServicePrincipalOwner.md)
Directory objects that are owners of this servicePrincipal.
The owners are a set of non-admin users or servicePrincipals who are allowed to modify this object.
Read-only.
Nullable.
Supports $expand and $filter (/$count eq 0, /$count ne 0, /$count eq 1, /$count ne 1).

### [Get-MgBetaServicePrincipalOwnerAsEndpoint](Get-MgBetaServicePrincipalOwnerAsEndpoint.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.endpoint

### [Get-MgBetaServicePrincipalOwnerAsServicePrincipal](Get-MgBetaServicePrincipalOwnerAsServicePrincipal.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.servicePrincipal

### [Get-MgBetaServicePrincipalOwnerAsUser](Get-MgBetaServicePrincipalOwnerAsUser.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.user

### [Get-MgBetaServicePrincipalOwnerByRef](Get-MgBetaServicePrincipalOwnerByRef.md)
Directory objects that are owners of this servicePrincipal.
The owners are a set of non-admin users or servicePrincipals who are allowed to modify this object.
Read-only.
Nullable.
Supports $expand and $filter (/$count eq 0, /$count ne 0, /$count eq 1, /$count ne 1).

### [Get-MgBetaServicePrincipalOwnerCount](Get-MgBetaServicePrincipalOwnerCount.md)
Get the number of the resource

### [Get-MgBetaServicePrincipalOwnerCountAsEndpoint](Get-MgBetaServicePrincipalOwnerCountAsEndpoint.md)
Get the number of the resource

### [Get-MgBetaServicePrincipalOwnerCountAsServicePrincipal](Get-MgBetaServicePrincipalOwnerCountAsServicePrincipal.md)
Get the number of the resource

### [Get-MgBetaServicePrincipalOwnerCountAsUser](Get-MgBetaServicePrincipalOwnerCountAsUser.md)
Get the number of the resource

### [Get-MgBetaServicePrincipalPasswordSingleSignOnCredential](Get-MgBetaServicePrincipalPasswordSingleSignOnCredential.md)
Get a list of single sign-on credentials using a password for a user or group.

### [Get-MgBetaServicePrincipalRemoteDesktopSecurityConfiguration](Get-MgBetaServicePrincipalRemoteDesktopSecurityConfiguration.md)
Read the properties and relationships of a remoteDesktopSecurityConfiguration object on a servicePrincipal.
Use this configuration to view the Microsoft Entra ID Remote Desktop Services (RDS) authentication protocol to authenticate a user to Microsoft Entra joined or Microsoft Entra hybrid joined devices.
Additionally you can view any targetDeviceGroups that have been configured for SSO.

### [Get-MgBetaServicePrincipalRemoteDesktopSecurityConfigurationTargetDeviceGroup](Get-MgBetaServicePrincipalRemoteDesktopSecurityConfigurationTargetDeviceGroup.md)
Read the properties and relationships of a targetDeviceGroup object for the remoteDesktopSecurityConfiguration object on the servicePrincipal.

### [Get-MgBetaServicePrincipalRemoteDesktopSecurityConfigurationTargetDeviceGroupCount](Get-MgBetaServicePrincipalRemoteDesktopSecurityConfigurationTargetDeviceGroupCount.md)
Get the number of the resource

### [Get-MgBetaServicePrincipalSynchronization](Get-MgBetaServicePrincipalSynchronization.md)
Represents the capability for Microsoft Entra identity synchronization through the Microsoft Graph API.

### [Get-MgBetaServicePrincipalSynchronizationAccessToken](Get-MgBetaServicePrincipalSynchronizationAccessToken.md)
Acquire an OAuth Access token to authorize the Microsoft Entra provisioning service to provision users into an application.

### [Get-MgBetaServicePrincipalSynchronizationJob](Get-MgBetaServicePrincipalSynchronizationJob.md)
Retrieve the existing synchronization job and its properties.

### [Get-MgBetaServicePrincipalSynchronizationJobBulkUpload](Get-MgBetaServicePrincipalSynchronizationJobBulkUpload.md)
The bulk upload operation for the job.

### [Get-MgBetaServicePrincipalSynchronizationJobBulkUploadContent](Get-MgBetaServicePrincipalSynchronizationJobBulkUploadContent.md)
Get media content for the navigation property bulkUpload from servicePrincipals

### [Get-MgBetaServicePrincipalSynchronizationJobCount](Get-MgBetaServicePrincipalSynchronizationJobCount.md)
Get the number of the resource

### [Get-MgBetaServicePrincipalSynchronizationJobSchema](Get-MgBetaServicePrincipalSynchronizationJobSchema.md)
Retrieve the schema for a given synchronization job or template.

### [Get-MgBetaServicePrincipalSynchronizationJobSchemaDirectory](Get-MgBetaServicePrincipalSynchronizationJobSchemaDirectory.md)
Contains the collection of directories and all of their objects.

### [Get-MgBetaServicePrincipalSynchronizationJobSchemaDirectoryCount](Get-MgBetaServicePrincipalSynchronizationJobSchemaDirectoryCount.md)
Get the number of the resource

### [Get-MgBetaServicePrincipalSynchronizationSecretCount](Get-MgBetaServicePrincipalSynchronizationSecretCount.md)
Get the number of the resource

### [Get-MgBetaServicePrincipalSynchronizationTemplate](Get-MgBetaServicePrincipalSynchronizationTemplate.md)
Pre-configured synchronization settings for a particular application.

### [Get-MgBetaServicePrincipalSynchronizationTemplateCount](Get-MgBetaServicePrincipalSynchronizationTemplateCount.md)
Get the number of the resource

### [Get-MgBetaServicePrincipalSynchronizationTemplateSchema](Get-MgBetaServicePrincipalSynchronizationTemplateSchema.md)
Default synchronization schema for the jobs based on this template.

### [Get-MgBetaServicePrincipalSynchronizationTemplateSchemaDirectory](Get-MgBetaServicePrincipalSynchronizationTemplateSchemaDirectory.md)
Contains the collection of directories and all of their objects.

### [Get-MgBetaServicePrincipalSynchronizationTemplateSchemaDirectoryCount](Get-MgBetaServicePrincipalSynchronizationTemplateSchemaDirectoryCount.md)
Get the number of the resource

### [Get-MgBetaServicePrincipalTokenIssuancePolicy](Get-MgBetaServicePrincipalTokenIssuancePolicy.md)
The tokenIssuancePolicies assigned to this service principal.
Supports $expand.

### [Get-MgBetaServicePrincipalTokenIssuancePolicyCount](Get-MgBetaServicePrincipalTokenIssuancePolicyCount.md)
Get the number of the resource

### [Get-MgBetaServicePrincipalTokenLifetimePolicy](Get-MgBetaServicePrincipalTokenLifetimePolicy.md)
The tokenLifetimePolicies assigned to this service principal.
Supports $expand.

### [Get-MgBetaServicePrincipalTokenLifetimePolicyCount](Get-MgBetaServicePrincipalTokenLifetimePolicyCount.md)
Get the number of the resource

### [Get-MgBetaServicePrincipalTransitiveMemberOf](Get-MgBetaServicePrincipalTransitiveMemberOf.md)
Get transitiveMemberOf from servicePrincipals

### [Get-MgBetaServicePrincipalTransitiveMemberOfAsAdministrativeUnit](Get-MgBetaServicePrincipalTransitiveMemberOfAsAdministrativeUnit.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.administrativeUnit

### [Get-MgBetaServicePrincipalTransitiveMemberOfAsDirectoryRole](Get-MgBetaServicePrincipalTransitiveMemberOfAsDirectoryRole.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.directoryRole

### [Get-MgBetaServicePrincipalTransitiveMemberOfAsGroup](Get-MgBetaServicePrincipalTransitiveMemberOfAsGroup.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.group

### [Get-MgBetaServicePrincipalTransitiveMemberOfCount](Get-MgBetaServicePrincipalTransitiveMemberOfCount.md)
Get the number of the resource

### [Get-MgBetaServicePrincipalTransitiveMemberOfCountAsAdministrativeUnit](Get-MgBetaServicePrincipalTransitiveMemberOfCountAsAdministrativeUnit.md)
Get the number of the resource

### [Get-MgBetaServicePrincipalTransitiveMemberOfCountAsDirectoryRole](Get-MgBetaServicePrincipalTransitiveMemberOfCountAsDirectoryRole.md)
Get the number of the resource

### [Get-MgBetaServicePrincipalTransitiveMemberOfCountAsGroup](Get-MgBetaServicePrincipalTransitiveMemberOfCountAsGroup.md)
Get the number of the resource

### [Get-MgBetaServicePrincipalUserOwnedObject](Get-MgBetaServicePrincipalUserOwnedObject.md)
Retrieve a list of recently deleted application and group objects owned by the specified user.
This API returns up to 1,000 deleted objects owned by the user, sorted by ID, and doesn't support pagination.

### [Get-MgBetaUserAppRoleAssignment](Get-MgBetaUserAppRoleAssignment.md)
Represents the app roles a user has been granted for an application.
Supports $expand.

### [Get-MgBetaUserAppRoleAssignmentCount](Get-MgBetaUserAppRoleAssignmentCount.md)
Get the number of the resource

### [Invoke-MgBetaFilterApplicationSynchronizationJobSchemaOperator](Invoke-MgBetaFilterApplicationSynchronizationJobSchemaOperator.md)
Invoke function filterOperators

### [Invoke-MgBetaFilterApplicationSynchronizationTemplateSchemaOperator](Invoke-MgBetaFilterApplicationSynchronizationTemplateSchemaOperator.md)
Invoke function filterOperators

### [Invoke-MgBetaFilterServicePrincipalSynchronizationJobSchemaOperator](Invoke-MgBetaFilterServicePrincipalSynchronizationJobSchemaOperator.md)
Invoke function filterOperators

### [Invoke-MgBetaFilterServicePrincipalSynchronizationTemplateSchemaOperator](Invoke-MgBetaFilterServicePrincipalSynchronizationTemplateSchemaOperator.md)
Invoke function filterOperators

### [Invoke-MgBetaFunctionApplicationSynchronizationJobSchema](Invoke-MgBetaFunctionApplicationSynchronizationJobSchema.md)
Invoke function functions

### [Invoke-MgBetaFunctionApplicationSynchronizationTemplateSchema](Invoke-MgBetaFunctionApplicationSynchronizationTemplateSchema.md)
Invoke function functions

### [Invoke-MgBetaFunctionServicePrincipalSynchronizationJobSchema](Invoke-MgBetaFunctionServicePrincipalSynchronizationJobSchema.md)
Invoke function functions

### [Invoke-MgBetaFunctionServicePrincipalSynchronizationTemplateSchema](Invoke-MgBetaFunctionServicePrincipalSynchronizationTemplateSchema.md)
Invoke function functions

### [Invoke-MgBetaInstantiateApplicationTemplate](Invoke-MgBetaInstantiateApplicationTemplate.md)
Add an instance of an application from the Microsoft Entra application gallery into your directory.
You can also use this API to instantiate non-gallery apps.
Use the following ID for the applicationTemplate object: 8adf8e6e-67b2-4cf2-a259-e3dc5476c621.

### [Invoke-MgBetaParseApplicationSynchronizationJobSchemaExpression](Invoke-MgBetaParseApplicationSynchronizationJobSchemaExpression.md)
Parse a given string expression into an attributeMappingSource object.
For more information about expressions, see Writing Expressions for Attribute Mappings in Microsoft Entra ID.

### [Invoke-MgBetaParseApplicationSynchronizationTemplateSchemaExpression](Invoke-MgBetaParseApplicationSynchronizationTemplateSchemaExpression.md)
Parse a given string expression into an attributeMappingSource object.
For more information about expressions, see Writing Expressions for Attribute Mappings in Microsoft Entra ID.

### [Invoke-MgBetaParseServicePrincipalSynchronizationJobSchemaExpression](Invoke-MgBetaParseServicePrincipalSynchronizationJobSchemaExpression.md)
Parse a given string expression into an attributeMappingSource object.
For more information about expressions, see Writing Expressions for Attribute Mappings in Microsoft Entra ID.

### [Invoke-MgBetaParseServicePrincipalSynchronizationTemplateSchemaExpression](Invoke-MgBetaParseServicePrincipalSynchronizationTemplateSchemaExpression.md)
Parse a given string expression into an attributeMappingSource object.
For more information about expressions, see Writing Expressions for Attribute Mappings in Microsoft Entra ID.

### [New-MgBetaApplication](New-MgBetaApplication.md)
Create a new application object.

### [New-MgBetaApplicationAppManagementPolicyByRef](New-MgBetaApplicationAppManagementPolicyByRef.md)
Assign an appManagementPolicy policy object to an application or service principal object.
The application or service principal adopts this policy over the tenant-wide tenantAppManagementPolicy setting.
Only one policy object can be assigned to an application or service principal.

### [New-MgBetaApplicationExtensionProperty](New-MgBetaApplicationExtensionProperty.md)
Create a new directory extension definition, represented by an extensionProperty object.

### [New-MgBetaApplicationFederatedIdentityCredential](New-MgBetaApplicationFederatedIdentityCredential.md)
Create a new federatedIdentityCredential object for an application.
By configuring a trust relationship between your Microsoft Entra application registration and the identity provider for your compute platform, you can use tokens issued by that platform to authenticate with Microsoft identity platform and call APIs in the Microsoft ecosystem.
Maximum of 20 objects can be added to an application.

### [New-MgBetaApplicationOwnerByRef](New-MgBetaApplicationOwnerByRef.md)
Use this API to add an owner to an application by posting to the owners collection.

### [New-MgBetaApplicationSynchronizationJob](New-MgBetaApplicationSynchronizationJob.md)
Create new synchronization job with a default synchronization schema.
The job is created in a disabled state.
Call Start job to start synchronization.

### [New-MgBetaApplicationSynchronizationJobOnDemand](New-MgBetaApplicationSynchronizationJobOnDemand.md)
Select a user and provision the account on-demand.
The rate limit for this API is 5 requests per 10 seconds.
No user or group will be provisioned on-demand that would not have been provisioned through the regular provisioning cycles.

### [New-MgBetaApplicationSynchronizationJobSchemaDirectory](New-MgBetaApplicationSynchronizationJobSchemaDirectory.md)
Create new navigation property to directories for applications

### [New-MgBetaApplicationSynchronizationTemplate](New-MgBetaApplicationSynchronizationTemplate.md)
Create new navigation property to templates for applications

### [New-MgBetaApplicationSynchronizationTemplateSchemaDirectory](New-MgBetaApplicationSynchronizationTemplateSchemaDirectory.md)
Create new navigation property to directories for applications

### [New-MgBetaApplicationTokenIssuancePolicyByRef](New-MgBetaApplicationTokenIssuancePolicyByRef.md)
Assign a tokenIssuancePolicy to an application.

### [New-MgBetaApplicationTokenLifetimePolicyByRef](New-MgBetaApplicationTokenLifetimePolicyByRef.md)
Assign a tokenLifetimePolicy to an application or servicePrincipal.
You can have multiple tokenLifetimePolicy policies in a tenant but can assign only one tokenLifetimePolicy per application.

### [New-MgBetaGroupAppRoleAssignment](New-MgBetaGroupAppRoleAssignment.md)
Use this API to assign an app role to a security group.
All direct members of the group will be considered assigned.
Security groups with dynamic memberships are supported.
To grant an app role assignment to a group, you need three identifiers: Additional licenses might be required to use a group to manage access to applications.

### [New-MgBetaOnPremisePublishingProfile](New-MgBetaOnPremisePublishingProfile.md)
Add new entity to onPremisesPublishingProfiles

### [New-MgBetaOnPremisePublishingProfileAgent](New-MgBetaOnPremisePublishingProfileAgent.md)
Create new navigation property to agents for onPremisesPublishingProfiles

### [New-MgBetaOnPremisePublishingProfileAgentGroup](New-MgBetaOnPremisePublishingProfileAgentGroup.md)
Create a new onPremisesAgentGroup object.

### [New-MgBetaOnPremisePublishingProfileAgentGroupAgent](New-MgBetaOnPremisePublishingProfileAgentGroupAgent.md)
Create new navigation property to agents for onPremisesPublishingProfiles

### [New-MgBetaOnPremisePublishingProfileAgentGroupByRef](New-MgBetaOnPremisePublishingProfileAgentGroupByRef.md)
Create new navigation property ref to agentGroups for onPremisesPublishingProfiles

### [New-MgBetaOnPremisePublishingProfileAgentGroupPublishedResource](New-MgBetaOnPremisePublishingProfileAgentGroupPublishedResource.md)
Create new navigation property to publishedResources for onPremisesPublishingProfiles

### [New-MgBetaOnPremisePublishingProfileAgentGroupPublishedResourceAgentGroup](New-MgBetaOnPremisePublishingProfileAgentGroupPublishedResourceAgentGroup.md)
Create new navigation property to agentGroups for onPremisesPublishingProfiles

### [New-MgBetaOnPremisePublishingProfileAgentGroupPublishedResourceAgentGroupByRef](New-MgBetaOnPremisePublishingProfileAgentGroupPublishedResourceAgentGroupByRef.md)
Create new navigation property ref to agentGroups for onPremisesPublishingProfiles

### [New-MgBetaOnPremisePublishingProfileConnector](New-MgBetaOnPremisePublishingProfileConnector.md)
Create new navigation property to connectors for onPremisesPublishingProfiles

### [New-MgBetaOnPremisePublishingProfileConnectorGroup](New-MgBetaOnPremisePublishingProfileConnectorGroup.md)
Create a new connectorGroup.

### [New-MgBetaOnPremisePublishingProfileConnectorGroupMemberByRef](New-MgBetaOnPremisePublishingProfileConnectorGroupMemberByRef.md)
Create new navigation property ref to members for onPremisesPublishingProfiles

### [New-MgBetaOnPremisePublishingProfileConnectorMemberOfByRef](New-MgBetaOnPremisePublishingProfileConnectorMemberOfByRef.md)
Create new navigation property ref to memberOf for onPremisesPublishingProfiles

### [New-MgBetaOnPremisePublishingProfilePublishedResource](New-MgBetaOnPremisePublishingProfilePublishedResource.md)
Create a new publishedResource object.

### [New-MgBetaOnPremisePublishingProfilePublishedResourceAgentGroup](New-MgBetaOnPremisePublishingProfilePublishedResourceAgentGroup.md)
Create new navigation property to agentGroups for onPremisesPublishingProfiles

### [New-MgBetaOnPremisePublishingProfilePublishedResourceAgentGroupByRef](New-MgBetaOnPremisePublishingProfilePublishedResourceAgentGroupByRef.md)
Create new navigation property ref to agentGroups for onPremisesPublishingProfiles

### [New-MgBetaServicePrincipal](New-MgBetaServicePrincipal.md)
Create a new servicePrincipal object.

### [New-MgBetaServicePrincipalAppRoleAssignedTo](New-MgBetaServicePrincipalAppRoleAssignedTo.md)
Assign an app role for a resource service principal, to a user, group, or client service principal.
App roles that are assigned to service principals are also known as application permissions.
Application permissions can be granted directly with app role assignments, or through a consent experience.
To grant an app role assignment, you need three identifiers:

### [New-MgBetaServicePrincipalAppRoleAssignment](New-MgBetaServicePrincipalAppRoleAssignment.md)
Assign an app role to a client service principal.
App roles that are assigned to service principals are also known as application permissions.
Application permissions can be granted directly with app role assignments, or through a consent experience.
To grant an app role assignment to a client service principal, you need three identifiers:

### [New-MgBetaServicePrincipalClaimMappingPolicyByRef](New-MgBetaServicePrincipalClaimMappingPolicyByRef.md)
Assign a claimsMappingPolicy to a servicePrincipal.

### [New-MgBetaServicePrincipalDelegatedPermissionClassification](New-MgBetaServicePrincipalDelegatedPermissionClassification.md)
Classify a delegated permission by adding a delegatedPermissionClassification to the servicePrincipal representing the API.

### [New-MgBetaServicePrincipalEndpoint](New-MgBetaServicePrincipalEndpoint.md)
Create new navigation property to endpoints for servicePrincipals

### [New-MgBetaServicePrincipalHomeRealmDiscoveryPolicyByRef](New-MgBetaServicePrincipalHomeRealmDiscoveryPolicyByRef.md)
Assign a homeRealmDiscoveryPolicy to a servicePrincipal.

### [New-MgBetaServicePrincipalLicenseDetail](New-MgBetaServicePrincipalLicenseDetail.md)
Create new navigation property to licenseDetails for servicePrincipals

### [New-MgBetaServicePrincipalOwnerByRef](New-MgBetaServicePrincipalOwnerByRef.md)
Add an owner for the servicePrincipal.
Service principal owners can be users, the service principal itself, or other service principals.

### [New-MgBetaServicePrincipalPasswordSingleSignOnCredential](New-MgBetaServicePrincipalPasswordSingleSignOnCredential.md)
Create single sign-on credentials using a password for a user or group.

### [New-MgBetaServicePrincipalRemoteDesktopSecurityConfigurationTargetDeviceGroup](New-MgBetaServicePrincipalRemoteDesktopSecurityConfigurationTargetDeviceGroup.md)
Create a new targetDeviceGroup object for the remoteDesktopSecurityConfiguration object on the servicePrincipal.
You can configure a maximum of 10 target device groups for the remoteDesktopSecurityConfiguraiton object on the servicePrincipal.

### [New-MgBetaServicePrincipalSynchronizationJob](New-MgBetaServicePrincipalSynchronizationJob.md)
Create new synchronization job with a default synchronization schema.
The job is created in a disabled state.
Call Start job to start synchronization.

### [New-MgBetaServicePrincipalSynchronizationJobOnDemand](New-MgBetaServicePrincipalSynchronizationJobOnDemand.md)
Select a user and provision the account on-demand.
The rate limit for this API is 5 requests per 10 seconds.
No user or group will be provisioned on-demand that would not have been provisioned through the regular provisioning cycles.

### [New-MgBetaServicePrincipalSynchronizationJobSchemaDirectory](New-MgBetaServicePrincipalSynchronizationJobSchemaDirectory.md)
Create new navigation property to directories for servicePrincipals

### [New-MgBetaServicePrincipalSynchronizationTemplate](New-MgBetaServicePrincipalSynchronizationTemplate.md)
Create new navigation property to templates for servicePrincipals

### [New-MgBetaServicePrincipalSynchronizationTemplateSchemaDirectory](New-MgBetaServicePrincipalSynchronizationTemplateSchemaDirectory.md)
Create new navigation property to directories for servicePrincipals

### [New-MgBetaUserAppRoleAssignment](New-MgBetaUserAppRoleAssignment.md)
Use this API to assign an app role to a user.
To grant an app role assignment to a user, you need three identifiers:

### [Ping-MgBetaApplicationSynchronization](Ping-MgBetaApplicationSynchronization.md)
Invoke function Ping

### [Ping-MgBetaServicePrincipalSynchronization](Ping-MgBetaServicePrincipalSynchronization.md)
Invoke function Ping

### [Remove-MgBetaApplication](Remove-MgBetaApplication.md)
Deletes an application.
When deleted, apps are moved to a temporary container and can be restored within 30 days.
After that time, they are permanently deleted.

### [Remove-MgBetaApplicationAppManagementPolicyByRef](Remove-MgBetaApplicationAppManagementPolicyByRef.md)
Remove an appManagementPolicy policy object from an application or service principal object.
When you remove the appManagementPolicy, the application or service principal adopts the tenant-wide tenantAppManagementPolicy setting.

### [Remove-MgBetaApplicationByAppId](Remove-MgBetaApplicationByAppId.md)
Deletes an application.
When deleted, apps are moved to a temporary container and can be restored within 30 days.
After that time, they are permanently deleted.

### [Remove-MgBetaApplicationByUniqueName](Remove-MgBetaApplicationByUniqueName.md)
Deletes an application.
When deleted, apps are moved to a temporary container and can be restored within 30 days.
After that time, they are permanently deleted.

### [Remove-MgBetaApplicationConnectorGroupByRef](Remove-MgBetaApplicationConnectorGroupByRef.md)
Delete ref of navigation property connectorGroup for applications

### [Remove-MgBetaApplicationExtensionProperty](Remove-MgBetaApplicationExtensionProperty.md)
Delete a directory extension definition represented by an extensionProperty object.
You can delete only directory extensions that aren't synced from on-premises active directory (AD).

### [Remove-MgBetaApplicationFederatedIdentityCredential](Remove-MgBetaApplicationFederatedIdentityCredential.md)
Deletes a federatedIdentityCredential object from an application.

### [Remove-MgBetaApplicationKey](Remove-MgBetaApplicationKey.md)
Remove a key credential from an application.
This method along with addKey can be used by an application to automate rolling its expiring keys.
As part of the request validation for this method, a proof of possession of an existing key is verified before the action can be performed.

### [Remove-MgBetaApplicationOwnerByRef](Remove-MgBetaApplicationOwnerByRef.md)
Remove an owner from an application.
As a recommended best practice, apps should have at least two owners.

### [Remove-MgBetaApplicationPassword](Remove-MgBetaApplicationPassword.md)
Removes a password from an application.

### [Remove-MgBetaApplicationSynchronization](Remove-MgBetaApplicationSynchronization.md)
Delete navigation property synchronization for applications

### [Remove-MgBetaApplicationSynchronizationJob](Remove-MgBetaApplicationSynchronizationJob.md)
Stop the synchronization job, and permanently delete all the state associated with it.
Synchronized accounts are left as-is.

### [Remove-MgBetaApplicationSynchronizationJobBulkUpload](Remove-MgBetaApplicationSynchronizationJobBulkUpload.md)
Delete navigation property bulkUpload for applications

### [Remove-MgBetaApplicationSynchronizationJobSchema](Remove-MgBetaApplicationSynchronizationJobSchema.md)
Delete navigation property schema for applications

### [Remove-MgBetaApplicationSynchronizationJobSchemaDirectory](Remove-MgBetaApplicationSynchronizationJobSchemaDirectory.md)
Delete navigation property directories for applications

### [Remove-MgBetaApplicationSynchronizationTemplate](Remove-MgBetaApplicationSynchronizationTemplate.md)
Delete navigation property templates for applications

### [Remove-MgBetaApplicationSynchronizationTemplateSchema](Remove-MgBetaApplicationSynchronizationTemplateSchema.md)
Delete navigation property schema for applications

### [Remove-MgBetaApplicationSynchronizationTemplateSchemaDirectory](Remove-MgBetaApplicationSynchronizationTemplateSchemaDirectory.md)
Delete navigation property directories for applications

### [Remove-MgBetaApplicationTokenIssuancePolicyByRef](Remove-MgBetaApplicationTokenIssuancePolicyByRef.md)
Remove a tokenIssuancePolicy from an application.

### [Remove-MgBetaApplicationTokenLifetimePolicyByRef](Remove-MgBetaApplicationTokenLifetimePolicyByRef.md)
Remove a tokenLifetimePolicy from an application or servicePrincipal.

### [Remove-MgBetaGroupAppRoleAssignment](Remove-MgBetaGroupAppRoleAssignment.md)
Deletes an appRoleAssignment that a group has been granted.

### [Remove-MgBetaOnPremisePublishingProfile](Remove-MgBetaOnPremisePublishingProfile.md)
Delete entity from onPremisesPublishingProfiles

### [Remove-MgBetaOnPremisePublishingProfileAgent](Remove-MgBetaOnPremisePublishingProfileAgent.md)
Delete navigation property agents for onPremisesPublishingProfiles

### [Remove-MgBetaOnPremisePublishingProfileAgentGroup](Remove-MgBetaOnPremisePublishingProfileAgentGroup.md)
Delete an onPremisesAgentGroup object.

### [Remove-MgBetaOnPremisePublishingProfileAgentGroupAgent](Remove-MgBetaOnPremisePublishingProfileAgentGroupAgent.md)
Delete navigation property agents for onPremisesPublishingProfiles

### [Remove-MgBetaOnPremisePublishingProfileAgentGroupByRef](Remove-MgBetaOnPremisePublishingProfileAgentGroupByRef.md)
Delete ref of navigation property agentGroups for onPremisesPublishingProfiles

### [Remove-MgBetaOnPremisePublishingProfileAgentGroupPublishedResource](Remove-MgBetaOnPremisePublishingProfileAgentGroupPublishedResource.md)
Delete navigation property publishedResources for onPremisesPublishingProfiles

### [Remove-MgBetaOnPremisePublishingProfileAgentGroupPublishedResourceAgentGroupByRef](Remove-MgBetaOnPremisePublishingProfileAgentGroupPublishedResourceAgentGroupByRef.md)
Delete ref of navigation property agentGroups for onPremisesPublishingProfiles

### [Remove-MgBetaOnPremisePublishingProfileConnector](Remove-MgBetaOnPremisePublishingProfileConnector.md)
Delete navigation property connectors for onPremisesPublishingProfiles

### [Remove-MgBetaOnPremisePublishingProfileConnectorGroup](Remove-MgBetaOnPremisePublishingProfileConnectorGroup.md)
Delete a connectorGroup.
All connectors and applications must be removed from the connector group before a connector group can be deleted.

### [Remove-MgBetaOnPremisePublishingProfileConnectorGroupMemberByRef](Remove-MgBetaOnPremisePublishingProfileConnectorGroupMemberByRef.md)
Delete ref of navigation property members for onPremisesPublishingProfiles

### [Remove-MgBetaOnPremisePublishingProfileConnectorMemberOfByRef](Remove-MgBetaOnPremisePublishingProfileConnectorMemberOfByRef.md)
Delete ref of navigation property memberOf for onPremisesPublishingProfiles

### [Remove-MgBetaOnPremisePublishingProfilePublishedResource](Remove-MgBetaOnPremisePublishingProfilePublishedResource.md)
Delete navigation property publishedResources for onPremisesPublishingProfiles

### [Remove-MgBetaOnPremisePublishingProfilePublishedResourceAgentGroupByRef](Remove-MgBetaOnPremisePublishingProfilePublishedResourceAgentGroupByRef.md)
Delete ref of navigation property agentGroups for onPremisesPublishingProfiles

### [Remove-MgBetaServicePrincipal](Remove-MgBetaServicePrincipal.md)
Delete a servicePrincipal object.

### [Remove-MgBetaServicePrincipalAppManagementPolicy](Remove-MgBetaServicePrincipalAppManagementPolicy.md)
Remove an appManagementPolicy policy object from an application or service principal object.
When you remove the appManagementPolicy, the application or service principal adopts the tenant-wide tenantAppManagementPolicy setting.

### [Remove-MgBetaServicePrincipalAppRoleAssignedTo](Remove-MgBetaServicePrincipalAppRoleAssignedTo.md)
Deletes an appRoleAssignment that a user, group, or client service principal has been granted for a resource service principal.

### [Remove-MgBetaServicePrincipalAppRoleAssignment](Remove-MgBetaServicePrincipalAppRoleAssignment.md)
Deletes an appRoleAssignment that a service principal has been granted.
App roles that are assigned to service principals are also known as application permissions.
Deleting an app role assignment for a service principal is equivalent to revoking the app-only permission grant.

### [Remove-MgBetaServicePrincipalByAppId](Remove-MgBetaServicePrincipalByAppId.md)
Delete a servicePrincipal object.

### [Remove-MgBetaServicePrincipalClaimMappingPolicyByRef](Remove-MgBetaServicePrincipalClaimMappingPolicyByRef.md)
Remove a claimsMappingPolicy from a servicePrincipal.

### [Remove-MgBetaServicePrincipalDelegatedPermissionClassification](Remove-MgBetaServicePrincipalDelegatedPermissionClassification.md)
Deletes a delegatedPermissionClassification which had previously been set for a delegated permission.

### [Remove-MgBetaServicePrincipalEndpoint](Remove-MgBetaServicePrincipalEndpoint.md)
Delete navigation property endpoints for servicePrincipals

### [Remove-MgBetaServicePrincipalHomeRealmDiscoveryPolicyByRef](Remove-MgBetaServicePrincipalHomeRealmDiscoveryPolicyByRef.md)
Remove a homeRealmDiscoveryPolicy from a servicePrincipal.

### [Remove-MgBetaServicePrincipalLicenseDetail](Remove-MgBetaServicePrincipalLicenseDetail.md)
Delete navigation property licenseDetails for servicePrincipals

### [Remove-MgBetaServicePrincipalOwnerByRef](Remove-MgBetaServicePrincipalOwnerByRef.md)
Remove an owner from a servicePrincipal object.
As a recommended best practice, service principals should have at least two owners.

### [Remove-MgBetaServicePrincipalPasswordSingleSignOnCredential](Remove-MgBetaServicePrincipalPasswordSingleSignOnCredential.md)
Delete single sign-on credentials using a password for a user or group.

### [Remove-MgBetaServicePrincipalRemoteDesktopSecurityConfiguration](Remove-MgBetaServicePrincipalRemoteDesktopSecurityConfiguration.md)
Delete a remoteDesktopSecurityConfiguration object on a servicePrincipal.
Removing remoteDesktopSecurityConfiguration object on the servicePrincipal disables the Microsoft Entra ID Remote Desktop Services (RDS) authentication protocol to authenticate a user to Microsoft Entra joined or Microsoft Entra hybrid joined devices, and removes any target device groups that you configured for SSO.

### [Remove-MgBetaServicePrincipalRemoteDesktopSecurityConfigurationTargetDeviceGroup](Remove-MgBetaServicePrincipalRemoteDesktopSecurityConfigurationTargetDeviceGroup.md)
Delete a targetDeviceGroup object for the remoteDesktopSecurityConfiguration object on the servicePrincipal.
Any user authenticating using the Microsoft Entra ID Remote Desktop Services (RDS) authentication protocol to a Microsoft Entra joined or Microsoft Entra hybrid joined device that's in the removed targetDeviceGroup doesn't get SSO prompts.

### [Remove-MgBetaServicePrincipalSynchronization](Remove-MgBetaServicePrincipalSynchronization.md)
Delete navigation property synchronization for servicePrincipals

### [Remove-MgBetaServicePrincipalSynchronizationJob](Remove-MgBetaServicePrincipalSynchronizationJob.md)
Stop the synchronization job, and permanently delete all the state associated with it.
Synchronized accounts are left as-is.

### [Remove-MgBetaServicePrincipalSynchronizationJobBulkUpload](Remove-MgBetaServicePrincipalSynchronizationJobBulkUpload.md)
Delete navigation property bulkUpload for servicePrincipals

### [Remove-MgBetaServicePrincipalSynchronizationJobSchema](Remove-MgBetaServicePrincipalSynchronizationJobSchema.md)
Delete navigation property schema for servicePrincipals

### [Remove-MgBetaServicePrincipalSynchronizationJobSchemaDirectory](Remove-MgBetaServicePrincipalSynchronizationJobSchemaDirectory.md)
Delete navigation property directories for servicePrincipals

### [Remove-MgBetaServicePrincipalSynchronizationTemplate](Remove-MgBetaServicePrincipalSynchronizationTemplate.md)
Delete navigation property templates for servicePrincipals

### [Remove-MgBetaServicePrincipalSynchronizationTemplateSchema](Remove-MgBetaServicePrincipalSynchronizationTemplateSchema.md)
Delete navigation property schema for servicePrincipals

### [Remove-MgBetaServicePrincipalSynchronizationTemplateSchemaDirectory](Remove-MgBetaServicePrincipalSynchronizationTemplateSchemaDirectory.md)
Delete navigation property directories for servicePrincipals

### [Remove-MgBetaUserAppRoleAssignment](Remove-MgBetaUserAppRoleAssignment.md)
Delete an appRoleAssignment that has been granted to a user.

### [Restart-MgBetaApplicationSynchronizationJob](Restart-MgBetaApplicationSynchronizationJob.md)
Restart a stopped synchronization job, forcing it to reprocess all the objects in the directory.
Optionally clears existing the synchronization state and previous errors.

### [Restart-MgBetaServicePrincipalSynchronizationJob](Restart-MgBetaServicePrincipalSynchronizationJob.md)
Restart a stopped synchronization job, forcing it to reprocess all the objects in the directory.
Optionally clears existing the synchronization state and previous errors.

### [Set-MgBetaApplicationConnectorGroupByRef](Set-MgBetaApplicationConnectorGroupByRef.md)
Assign a connectorGroup to an application.

### [Set-MgBetaApplicationLogo](Set-MgBetaApplicationLogo.md)
The main logo for the application.
Not nullable.

### [Set-MgBetaApplicationSynchronization](Set-MgBetaApplicationSynchronization.md)
Update the navigation property synchronization in applications

### [Set-MgBetaApplicationSynchronizationJobBulkUploadContent](Set-MgBetaApplicationSynchronizationJobBulkUploadContent.md)
Update media content for the navigation property bulkUpload in applications

### [Set-MgBetaApplicationSynchronizationSecret](Set-MgBetaApplicationSynchronizationSecret.md)
Update property secrets value.

### [Set-MgBetaApplicationVerifiedPublisher](Set-MgBetaApplicationVerifiedPublisher.md)
Set the the verifiedPublisher on an application.
For more information, including prerequisites to setting a verified publisher, see Publisher verification.

### [Set-MgBetaOnPremisePublishingProfileConnectorGroupApplicationLogo](Set-MgBetaOnPremisePublishingProfileConnectorGroupApplicationLogo.md)
The main logo for the application.
Not nullable.

### [Set-MgBetaServicePrincipalSynchronization](Set-MgBetaServicePrincipalSynchronization.md)
Update the navigation property synchronization in servicePrincipals

### [Set-MgBetaServicePrincipalSynchronizationJobBulkUploadContent](Set-MgBetaServicePrincipalSynchronizationJobBulkUploadContent.md)
Update media content for the navigation property bulkUpload in servicePrincipals

### [Set-MgBetaServicePrincipalSynchronizationSecret](Set-MgBetaServicePrincipalSynchronizationSecret.md)
Update property secrets value.

### [Start-MgBetaApplicationSynchronizationJob](Start-MgBetaApplicationSynchronizationJob.md)
Start an existing synchronization job.
If the job is in a paused state, it continues processing changes from the point where it was paused.
If the job is in quarantine, the quarantine status is cleared.
Don't create scripts to call the start job continuously while it's running because that can cause the service to stop running.
Use the start job only when the job is currently paused or in quarantine.

### [Start-MgBetaServicePrincipalSynchronizationJob](Start-MgBetaServicePrincipalSynchronizationJob.md)
Start an existing synchronization job.
If the job is in a paused state, it continues processing changes from the point where it was paused.
If the job is in quarantine, the quarantine status is cleared.
Don't create scripts to call the start job continuously while it's running because that can cause the service to stop running.
Use the start job only when the job is currently paused or in quarantine.

### [Suspend-MgBetaApplicationSynchronizationJob](Suspend-MgBetaApplicationSynchronizationJob.md)
Temporarily stop a running synchronization job.
All the progress, including job state, is persisted, and the job continues from where it left off when a start call is made.

### [Suspend-MgBetaServicePrincipalSynchronizationJob](Suspend-MgBetaServicePrincipalSynchronizationJob.md)
Temporarily stop a running synchronization job.
All the progress, including job state, is persisted, and the job continues from where it left off when a start call is made.

### [Test-MgBetaApplicationProperty](Test-MgBetaApplicationProperty.md)
Validate that a Microsoft 365 group's display name or mail nickname complies with naming policies.
Clients can use this API to determine whether a display name or mail nickname is valid before trying to create a Microsoft 365 group.
For validating properties of an existing group, use the validateProperties function for groups.
The following validations are performed for the display name and mail nickname properties: \n1.
Validate the prefix and suffix naming policy\n2.
Validate the custom banned words policy\n3.
Validate the mail nickname is unique This API returns with the first failure encountered.
If one or more properties fail multiple validations, only the property with the first validation failure is returned.
However, you can validate both the mail nickname and the display name and receive a collection of validation errors if you are only validating the prefix and suffix naming policy.

### [Test-MgBetaApplicationSynchronizationJobCredential](Test-MgBetaApplicationSynchronizationJobCredential.md)
Validate that the credentials are valid in the tenant.

### [Test-MgBetaServicePrincipalProperty](Test-MgBetaServicePrincipalProperty.md)
Validate that a Microsoft 365 group's display name or mail nickname complies with naming policies.
Clients can use this API to determine whether a display name or mail nickname is valid before trying to create a Microsoft 365 group.
For validating properties of an existing group, use the validateProperties function for groups.
The following validations are performed for the display name and mail nickname properties: \n1.
Validate the prefix and suffix naming policy\n2.
Validate the custom banned words policy\n3.
Validate the mail nickname is unique This API returns with the first failure encountered.
If one or more properties fail multiple validations, only the property with the first validation failure is returned.
However, you can validate both the mail nickname and the display name and receive a collection of validation errors if you are only validating the prefix and suffix naming policy.

### [Test-MgBetaServicePrincipalSynchronizationJobCredential](Test-MgBetaServicePrincipalSynchronizationJobCredential.md)
Validate that the credentials are valid in the tenant.

### [Update-MgBetaApplication](Update-MgBetaApplication.md)
Update the properties of an application object.

### [Update-MgBetaApplicationByAppId](Update-MgBetaApplicationByAppId.md)
Update the properties of an application object.

### [Update-MgBetaApplicationByUniqueName](Update-MgBetaApplicationByUniqueName.md)
Update the properties of an application object.

### [Update-MgBetaApplicationExtensionProperty](Update-MgBetaApplicationExtensionProperty.md)
Update the navigation property extensionProperties in applications

### [Update-MgBetaApplicationFederatedIdentityCredential](Update-MgBetaApplicationFederatedIdentityCredential.md)
Update the properties of a federatedIdentityCredential object.

### [Update-MgBetaApplicationSynchronizationJob](Update-MgBetaApplicationSynchronizationJob.md)
Update the navigation property jobs in applications

### [Update-MgBetaApplicationSynchronizationJobBulkUpload](Update-MgBetaApplicationSynchronizationJobBulkUpload.md)
Update the navigation property bulkUpload in applications

### [Update-MgBetaApplicationSynchronizationJobSchema](Update-MgBetaApplicationSynchronizationJobSchema.md)
Update the synchronization schema for a given job or template.
This method fully replaces the current schema with the one provided in the request.
To update the schema of a template, make the call on the application object.
You must be the owner of the application.

### [Update-MgBetaApplicationSynchronizationJobSchemaDirectory](Update-MgBetaApplicationSynchronizationJobSchemaDirectory.md)
Update the navigation property directories in applications

### [Update-MgBetaApplicationSynchronizationTemplate](Update-MgBetaApplicationSynchronizationTemplate.md)
Update (override) the synchronization template associated with a given application.

### [Update-MgBetaApplicationSynchronizationTemplateSchema](Update-MgBetaApplicationSynchronizationTemplateSchema.md)
Update the navigation property schema in applications

### [Update-MgBetaApplicationSynchronizationTemplateSchemaDirectory](Update-MgBetaApplicationSynchronizationTemplateSchemaDirectory.md)
Update the navigation property directories in applications

### [Update-MgBetaGroupAppRoleAssignment](Update-MgBetaGroupAppRoleAssignment.md)
Update the navigation property appRoleAssignments in groups

### [Update-MgBetaOnPremisePublishingProfile](Update-MgBetaOnPremisePublishingProfile.md)
Update entity in onPremisesPublishingProfiles

### [Update-MgBetaOnPremisePublishingProfileAgent](Update-MgBetaOnPremisePublishingProfileAgent.md)
Update the navigation property agents in onPremisesPublishingProfiles

### [Update-MgBetaOnPremisePublishingProfileAgentGroup](Update-MgBetaOnPremisePublishingProfileAgentGroup.md)
Update the properties of an onPremisesAgentGroup object.

### [Update-MgBetaOnPremisePublishingProfileAgentGroupAgent](Update-MgBetaOnPremisePublishingProfileAgentGroupAgent.md)
Update the navigation property agents in onPremisesPublishingProfiles

### [Update-MgBetaOnPremisePublishingProfileAgentGroupPublishedResource](Update-MgBetaOnPremisePublishingProfileAgentGroupPublishedResource.md)
Update the navigation property publishedResources in onPremisesPublishingProfiles

### [Update-MgBetaOnPremisePublishingProfileConnector](Update-MgBetaOnPremisePublishingProfileConnector.md)
Update the navigation property connectors in onPremisesPublishingProfiles

### [Update-MgBetaOnPremisePublishingProfileConnectorGroup](Update-MgBetaOnPremisePublishingProfileConnectorGroup.md)
Update the properties of a connectorGroup object.

### [Update-MgBetaOnPremisePublishingProfilePublishedResource](Update-MgBetaOnPremisePublishingProfilePublishedResource.md)
Update the properties of published resource  publishedResource object.

### [Update-MgBetaServicePrincipal](Update-MgBetaServicePrincipal.md)
Update the properties of servicePrincipal object.

### [Update-MgBetaServicePrincipalAppRoleAssignedTo](Update-MgBetaServicePrincipalAppRoleAssignedTo.md)
Update the navigation property appRoleAssignedTo in servicePrincipals

### [Update-MgBetaServicePrincipalAppRoleAssignment](Update-MgBetaServicePrincipalAppRoleAssignment.md)
Update the navigation property appRoleAssignments in servicePrincipals

### [Update-MgBetaServicePrincipalByAppId](Update-MgBetaServicePrincipalByAppId.md)
Update the properties of servicePrincipal object.

### [Update-MgBetaServicePrincipalDelegatedPermissionClassification](Update-MgBetaServicePrincipalDelegatedPermissionClassification.md)
Update the navigation property delegatedPermissionClassifications in servicePrincipals

### [Update-MgBetaServicePrincipalEndpoint](Update-MgBetaServicePrincipalEndpoint.md)
Update the navigation property endpoints in servicePrincipals

### [Update-MgBetaServicePrincipalLicenseDetail](Update-MgBetaServicePrincipalLicenseDetail.md)
Update the navigation property licenseDetails in servicePrincipals

### [Update-MgBetaServicePrincipalPasswordSingleSignOnCredential](Update-MgBetaServicePrincipalPasswordSingleSignOnCredential.md)
Update single sign-on credentials using a password for a user or group.

### [Update-MgBetaServicePrincipalRemoteDesktopSecurityConfiguration](Update-MgBetaServicePrincipalRemoteDesktopSecurityConfiguration.md)
Update the properties of a remoteDesktopSecurityConfiguration object on the servicePrincipal.
Use this configuration to enable or disable the Microsoft Entra ID Remote Desktop Services (RDS) authentication protocol to authenticate a user to Microsoft Entra joined or Microsoft Entra hybrid joined devices.

### [Update-MgBetaServicePrincipalRemoteDesktopSecurityConfigurationTargetDeviceGroup](Update-MgBetaServicePrincipalRemoteDesktopSecurityConfigurationTargetDeviceGroup.md)
Update the properties of a targetDeviceGroup object for remoteDesktopSecurityConfiguration object on the servicePrincipal.
You can configure a maximum of 10 target device groups for the remoteDesktopSecurityConfiguraiton object on the servicePrincipal.

### [Update-MgBetaServicePrincipalSynchronizationJob](Update-MgBetaServicePrincipalSynchronizationJob.md)
Update the navigation property jobs in servicePrincipals

### [Update-MgBetaServicePrincipalSynchronizationJobBulkUpload](Update-MgBetaServicePrincipalSynchronizationJobBulkUpload.md)
Update the navigation property bulkUpload in servicePrincipals

### [Update-MgBetaServicePrincipalSynchronizationJobSchema](Update-MgBetaServicePrincipalSynchronizationJobSchema.md)
Update the synchronization schema for a given job or template.
This method fully replaces the current schema with the one provided in the request.
To update the schema of a template, make the call on the application object.
You must be the owner of the application.

### [Update-MgBetaServicePrincipalSynchronizationJobSchemaDirectory](Update-MgBetaServicePrincipalSynchronizationJobSchemaDirectory.md)
Update the navigation property directories in servicePrincipals

### [Update-MgBetaServicePrincipalSynchronizationTemplate](Update-MgBetaServicePrincipalSynchronizationTemplate.md)
Update (override) the synchronization template associated with a given application.

### [Update-MgBetaServicePrincipalSynchronizationTemplateSchema](Update-MgBetaServicePrincipalSynchronizationTemplateSchema.md)
Update the navigation property schema in servicePrincipals

### [Update-MgBetaServicePrincipalSynchronizationTemplateSchemaDirectory](Update-MgBetaServicePrincipalSynchronizationTemplateSchemaDirectory.md)
Update the navigation property directories in servicePrincipals

### [Update-MgBetaUserAppRoleAssignment](Update-MgBetaUserAppRoleAssignment.md)
Update the navigation property appRoleAssignments in users

