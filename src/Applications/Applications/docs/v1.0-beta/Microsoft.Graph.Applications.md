---
Module Name: Microsoft.Graph.Applications
Module Guid: 0495599b-29dc-4963-b533-b66db030a2d0
Download Help Link: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.applications
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Applications Module
## Description
Microsoft Graph PowerShell Cmdlets

## Microsoft.Graph.Applications Cmdlets
### [Add-MgApplicationKey](Add-MgApplicationKey.md)
Add a key credential to an application.
This method, along with removeKey, can be used by an application to automate rolling its expiring keys.
As part of the request validation for this method, a proof of possession of an existing key is verified before the action can be performed.
Applications that don’t have any existing valid certificates (no certificates have been added yet, or all certificates have expired), won’t be able to use this service action.
You can use the Update application operation to perform an update instead.

### [Add-MgApplicationPassword](Add-MgApplicationPassword.md)
Adds a strong password to an application.

### [Add-MgServicePrincipalTokenSigningCertificate](Add-MgServicePrincipalTokenSigningCertificate.md)
Creates a self-signed signing certificate and returns a selfSignedCertificate object, which is the public part of the generated certificate.
The self-signed signing certificate is composed of the following objects which are added to the servicePrincipal: \n+ The keyCredentials object with the following objects:\n    + A private key object with **usage** set to `Sign`.\n    + A public key object with **usage** set to `Verify`.\n+ The passwordCredentials object.
All the objects have the same value of **customKeyIdentifier**.
The **passwordCredential** is used to open the PFX file (private key).
It and the associated private key object have the same value of **keyId**.
Once set during creation through the **displayName** property, the subject of the certificate cannot be updated.
The **startDateTime** is set to the same time the certificate is created using the action.
The **endDateTime** can be up to three years after the certificate is created.

### [Clear-MgApplicationVerifiedPublisher](Clear-MgApplicationVerifiedPublisher.md)
Unset the the verifiedPublisher previously set on an application, removing all verified publisher properties.
For more information, see Publisher verification.

### [Confirm-MgApplicationMemberGroup](Confirm-MgApplicationMemberGroup.md)
Check for membership in a specified list of group IDs, and return from that list those groups (identified by IDs) of which the specified user, group, service principal, organizational contact, device, or directory object is a member.
This function is transitive.
You can check up to a maximum of 20 groups per request.
This function supports all groups provisioned in Azure AD.
Because Microsoft 365 groups cannot contain other groups, membership in a Microsoft 365 group is always direct.

### [Confirm-MgApplicationMemberObject](Confirm-MgApplicationMemberObject.md)
Invoke action checkMemberObjects

### [Confirm-MgServicePrincipalMemberGroup](Confirm-MgServicePrincipalMemberGroup.md)
Check for membership in a specified list of group IDs, and return from that list those groups (identified by IDs) of which the specified user, group, service principal, organizational contact, device, or directory object is a member.
This function is transitive.
You can check up to a maximum of 20 groups per request.
This function supports all groups provisioned in Azure AD.
Because Microsoft 365 groups cannot contain other groups, membership in a Microsoft 365 group is always direct.

### [Confirm-MgServicePrincipalMemberObject](Confirm-MgServicePrincipalMemberObject.md)
Invoke action checkMemberObjects

### [Find-MgApplicationSynchronizationJobSchemaDirectory](Find-MgApplicationSynchronizationJobSchemaDirectory.md)
Discover the latest schema definition for provisioning to an application.

### [Find-MgApplicationSynchronizationTemplateSchemaDirectory](Find-MgApplicationSynchronizationTemplateSchemaDirectory.md)
Discover the latest schema definition for provisioning to an application.

### [Find-MgServicePrincipalSynchronizationJobSchemaDirectory](Find-MgServicePrincipalSynchronizationJobSchemaDirectory.md)
Discover the latest schema definition for provisioning to an application.

### [Find-MgServicePrincipalSynchronizationTemplateSchemaDirectory](Find-MgServicePrincipalSynchronizationTemplateSchemaDirectory.md)
Discover the latest schema definition for provisioning to an application.

### [Get-MgApplication](Get-MgApplication.md)
Get the properties and relationships of an application object.

### [Get-MgApplicationAppManagementPolicy](Get-MgApplicationAppManagementPolicy.md)
The appManagementPolicy applied to this application.

### [Get-MgApplicationAppManagementPolicyByRef](Get-MgApplicationAppManagementPolicyByRef.md)
The appManagementPolicy applied to this application.

### [Get-MgApplicationById](Get-MgApplicationById.md)
Return the directory objects specified in a list of IDs.
Some common uses for this function are to:

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
Return all the group IDs for the groups that the specified user, group, service principal, organizational contact, device, or directory object is a member of.
This function is transitive.

### [Get-MgApplicationMemberObject](Get-MgApplicationMemberObject.md)
Invoke action getMemberObjects

### [Get-MgApplicationOwner](Get-MgApplicationOwner.md)
Directory objects that are owners of the application.
Read-only.
Nullable.
Supports $expand and $filter (/$count eq 0, /$count ne 0, /$count eq 1, /$count ne 1).

### [Get-MgApplicationOwnerByRef](Get-MgApplicationOwnerByRef.md)
Directory objects that are owners of the application.
Read-only.
Nullable.
Supports $expand and $filter (/$count eq 0, /$count ne 0, /$count eq 1, /$count ne 1).

### [Get-MgApplicationSynchronization](Get-MgApplicationSynchronization.md)
Get synchronization from applications

### [Get-MgApplicationSynchronizationAccessToken](Get-MgApplicationSynchronizationAccessToken.md)
Acquire an OAuth Access token to authorize the Azure AD provisioning service to provision users into an application.

### [Get-MgApplicationSynchronizationJob](Get-MgApplicationSynchronizationJob.md)
Performs synchronization by periodically running in the background, polling for changes in one directory, and pushing them to another directory.

### [Get-MgApplicationSynchronizationJobSchema](Get-MgApplicationSynchronizationJobSchema.md)
Retrieve the schema for a given synchronization job or template.

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
List the tokenIssuancePolicy objects that are assigned to an application.

### [Get-MgApplicationTokenIssuancePolicyByRef](Get-MgApplicationTokenIssuancePolicyByRef.md)
List the tokenIssuancePolicy objects that are assigned to an application.

### [Get-MgApplicationTokenLifetimePolicy](Get-MgApplicationTokenLifetimePolicy.md)
List the tokenLifetimePolicy objects that are assigned to an application or servicePrincipal..

### [Get-MgApplicationTokenLifetimePolicyByRef](Get-MgApplicationTokenLifetimePolicyByRef.md)
List the tokenLifetimePolicy objects that are assigned to an application or servicePrincipal..

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
Return the directory objects specified in a list of IDs.
Some common uses for this function are to:

### [Get-MgServicePrincipalClaimMappingPolicy](Get-MgServicePrincipalClaimMappingPolicy.md)
List the claimsMappingPolicy objects that are assigned to a servicePrincipal.

### [Get-MgServicePrincipalClaimMappingPolicyByRef](Get-MgServicePrincipalClaimMappingPolicyByRef.md)
List the claimsMappingPolicy objects that are assigned to a servicePrincipal.

### [Get-MgServicePrincipalCreatedObject](Get-MgServicePrincipalCreatedObject.md)
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

### [Get-MgServicePrincipalHomeRealmDiscoveryPolicy](Get-MgServicePrincipalHomeRealmDiscoveryPolicy.md)
List the homeRealmDiscoveryPolicy objects that are assigned to a servicePrincipal.

### [Get-MgServicePrincipalHomeRealmDiscoveryPolicyByRef](Get-MgServicePrincipalHomeRealmDiscoveryPolicyByRef.md)
List the homeRealmDiscoveryPolicy objects that are assigned to a servicePrincipal.

### [Get-MgServicePrincipalLicenseDetail](Get-MgServicePrincipalLicenseDetail.md)
Get licenseDetails from servicePrincipals

### [Get-MgServicePrincipalMemberGroup](Get-MgServicePrincipalMemberGroup.md)
Return all the group IDs for the groups that the specified user, group, service principal, organizational contact, device, or directory object is a member of.
This function is transitive.

### [Get-MgServicePrincipalMemberObject](Get-MgServicePrincipalMemberObject.md)
Invoke action getMemberObjects

### [Get-MgServicePrincipalMemberOf](Get-MgServicePrincipalMemberOf.md)
Roles that this service principal is a member of.
HTTP Methods: GET Read-only.
Nullable.
Supports $expand.

### [Get-MgServicePrincipalOauth2PermissionGrant](Get-MgServicePrincipalOauth2PermissionGrant.md)
Delegated permission grants authorizing this service principal to access an API on behalf of a signed-in user.
Read-only.
Nullable.

### [Get-MgServicePrincipalOwnedObject](Get-MgServicePrincipalOwnedObject.md)
Directory objects that are owned by this service principal.
Read-only.
Nullable.
Supports $expand and $filter (/$count eq 0, /$count ne 0, /$count eq 1, /$count ne 1).

### [Get-MgServicePrincipalOwner](Get-MgServicePrincipalOwner.md)
Directory objects that are owners of this servicePrincipal.
The owners are a set of non-admin users or servicePrincipals who are allowed to modify this object.
Read-only.
Nullable.
Supports $expand and $filter (/$count eq 0, /$count ne 0, /$count eq 1, /$count ne 1).

### [Get-MgServicePrincipalOwnerByRef](Get-MgServicePrincipalOwnerByRef.md)
Directory objects that are owners of this servicePrincipal.
The owners are a set of non-admin users or servicePrincipals who are allowed to modify this object.
Read-only.
Nullable.
Supports $expand and $filter (/$count eq 0, /$count ne 0, /$count eq 1, /$count ne 1).

### [Get-MgServicePrincipalPasswordSingleSignOnCredentials](Get-MgServicePrincipalPasswordSingleSignOnCredentials.md)
Get a list of single sign-on credentials using a password for a user or group.

### [Get-MgServicePrincipalSynchronization](Get-MgServicePrincipalSynchronization.md)
Get synchronization from servicePrincipals

### [Get-MgServicePrincipalSynchronizationAccessToken](Get-MgServicePrincipalSynchronizationAccessToken.md)
Acquire an OAuth Access token to authorize the Azure AD provisioning service to provision users into an application.

### [Get-MgServicePrincipalSynchronizationJob](Get-MgServicePrincipalSynchronizationJob.md)
Performs synchronization by periodically running in the background, polling for changes in one directory, and pushing them to another directory.

### [Get-MgServicePrincipalSynchronizationJobSchema](Get-MgServicePrincipalSynchronizationJobSchema.md)
Retrieve the schema for a given synchronization job or template.

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
Add an instance of an application from the Azure AD application gallery into your directory.
You can also use this API to instantiate non-gallery apps.
Use the following ID for the **applicationTemplate** object: `8adf8e6e-67b2-4cf2-a259-e3dc5476c621`.

### [Invoke-MgParseApplicationSynchronizationJobSchemaExpression](Invoke-MgParseApplicationSynchronizationJobSchemaExpression.md)
Parse a given string expression into an attributeMappingSource object.
For more information about expressions, see Writing Expressions for Attribute Mappings in Azure Active Directory.

### [Invoke-MgParseApplicationSynchronizationTemplateSchemaExpression](Invoke-MgParseApplicationSynchronizationTemplateSchemaExpression.md)
Parse a given string expression into an attributeMappingSource object.
For more information about expressions, see Writing Expressions for Attribute Mappings in Azure Active Directory.

### [Invoke-MgParseServicePrincipalSynchronizationJobSchemaExpression](Invoke-MgParseServicePrincipalSynchronizationJobSchemaExpression.md)
Parse a given string expression into an attributeMappingSource object.
For more information about expressions, see Writing Expressions for Attribute Mappings in Azure Active Directory.

### [Invoke-MgParseServicePrincipalSynchronizationTemplateSchemaExpression](Invoke-MgParseServicePrincipalSynchronizationTemplateSchemaExpression.md)
Parse a given string expression into an attributeMappingSource object.
For more information about expressions, see Writing Expressions for Attribute Mappings in Azure Active Directory.

### [New-MgApplication](New-MgApplication.md)
Create a new application object.

### [New-MgApplicationAppManagementPolicyByRef](New-MgApplicationAppManagementPolicyByRef.md)
Create new navigation property ref to appManagementPolicies for applications

### [New-MgApplicationExtensionProperty](New-MgApplicationExtensionProperty.md)
Create a new directory extension definition, represented by an extensionProperty object.

### [New-MgApplicationFederatedIdentityCredential](New-MgApplicationFederatedIdentityCredential.md)
Create a new federatedIdentityCredential object for an application.
By configuring a trust relationship between your Azure AD application registration and the identity provider for your compute platform, you can use tokens issued by that platform to authenticate with Microsoft identity platform and call APIs in the Microsoft ecosystem.
Maximum of 20 objects can be added to an application.

### [New-MgApplicationOwnerByRef](New-MgApplicationOwnerByRef.md)
Create new navigation property ref to owners for applications

### [New-MgApplicationSynchronizationJob](New-MgApplicationSynchronizationJob.md)
Create new synchronization job with a default synchronization schema.
The job is created in a disabled state.
Call Start job to start synchronization.

### [New-MgApplicationSynchronizationJobOnDemand](New-MgApplicationSynchronizationJobOnDemand.md)
Select a user and provision the account on-demand.
The rate limit for this API is 5 requests per 10 seconds.

### [New-MgApplicationSynchronizationJobSchemaDirectory](New-MgApplicationSynchronizationJobSchemaDirectory.md)
Create new navigation property to directories for applications

### [New-MgApplicationSynchronizationTemplate](New-MgApplicationSynchronizationTemplate.md)
Create new navigation property to templates for applications

### [New-MgApplicationSynchronizationTemplateSchemaDirectory](New-MgApplicationSynchronizationTemplateSchemaDirectory.md)
Create new navigation property to directories for applications

### [New-MgApplicationTemplate](New-MgApplicationTemplate.md)
Add new entity to applicationTemplates

### [New-MgApplicationTokenIssuancePolicyByRef](New-MgApplicationTokenIssuancePolicyByRef.md)
Create new navigation property ref to tokenIssuancePolicies for applications

### [New-MgApplicationTokenLifetimePolicyByRef](New-MgApplicationTokenLifetimePolicyByRef.md)
Assign a tokenLifetimePolicy to an application or servicePrincipal.

### [New-MgGroupAppRoleAssignment](New-MgGroupAppRoleAssignment.md)
Use this API to assign an app role to a security group.
All direct members of the group will be considered assigned.
Security groups with dynamic memberships are supported.
To grant an app role assignment to a group, you need three identifiers: Additional licenses might be required to use a group to manage access to applications.

### [New-MgOnPremisePublishingProfile](New-MgOnPremisePublishingProfile.md)
Add new entity to onPremisesPublishingProfiles

### [New-MgOnPremisePublishingProfileAgent](New-MgOnPremisePublishingProfileAgent.md)
Create new navigation property to agents for onPremisesPublishingProfiles

### [New-MgOnPremisePublishingProfileAgentGroup](New-MgOnPremisePublishingProfileAgentGroup.md)
Create a new onPremisesAgentGroup object.

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
Create a connectorGroup object.

### [New-MgOnPremisePublishingProfileConnectorMemberOfByRef](New-MgOnPremisePublishingProfileConnectorMemberOfByRef.md)
Create new navigation property ref to memberOf for onPremisesPublishingProfiles

### [New-MgOnPremisePublishingProfilePublishedResource](New-MgOnPremisePublishingProfilePublishedResource.md)
Create a new publishedResource object.

### [New-MgOnPremisePublishingProfilePublishedResourceAgentGroup](New-MgOnPremisePublishingProfilePublishedResourceAgentGroup.md)
Create new navigation property to agentGroups for onPremisesPublishingProfiles

### [New-MgOnPremisePublishingProfilePublishedResourceAgentGroupByRef](New-MgOnPremisePublishingProfilePublishedResourceAgentGroupByRef.md)
Create new navigation property ref to agentGroups for onPremisesPublishingProfiles

### [New-MgServicePrincipal](New-MgServicePrincipal.md)
Create a new servicePrincipal object.

### [New-MgServicePrincipalAppRoleAssignedTo](New-MgServicePrincipalAppRoleAssignedTo.md)
Assign an app role for a resource service principal, to a user, group, or client service principal.
App roles that are assigned to service principals are also known as application permissions.
Application permissions can be granted directly with app role assignments, or through a consent experience.
To grant an app role assignment, you need three identifiers:

### [New-MgServicePrincipalAppRoleAssignment](New-MgServicePrincipalAppRoleAssignment.md)
Assign an app role to a client service principal.
App roles that are assigned to service principals are also known as application permissions.
Application permissions can be granted directly with app role assignments, or through a consent experience.
To grant an app role assignment to a client service principal, you need three identifiers:

### [New-MgServicePrincipalClaimMappingPolicyByRef](New-MgServicePrincipalClaimMappingPolicyByRef.md)
Create new navigation property ref to claimsMappingPolicies for servicePrincipals

### [New-MgServicePrincipalDelegatedPermissionClassification](New-MgServicePrincipalDelegatedPermissionClassification.md)
Classify a delegated permission by adding a delegatedPermissionClassification to the servicePrincipal representing the API.

### [New-MgServicePrincipalEndpoint](New-MgServicePrincipalEndpoint.md)
Create new navigation property to endpoints for servicePrincipals

### [New-MgServicePrincipalHomeRealmDiscoveryPolicyByRef](New-MgServicePrincipalHomeRealmDiscoveryPolicyByRef.md)
Create new navigation property ref to homeRealmDiscoveryPolicies for servicePrincipals

### [New-MgServicePrincipalLicenseDetail](New-MgServicePrincipalLicenseDetail.md)
Create new navigation property to licenseDetails for servicePrincipals

### [New-MgServicePrincipalOwnerByRef](New-MgServicePrincipalOwnerByRef.md)
Create new navigation property ref to owners for servicePrincipals

### [New-MgServicePrincipalPasswordSingleSignOnCredentials](New-MgServicePrincipalPasswordSingleSignOnCredentials.md)
Create single sign-on credentials using a password for a user or group.

### [New-MgServicePrincipalSynchronizationJob](New-MgServicePrincipalSynchronizationJob.md)
Create new synchronization job with a default synchronization schema.
The job is created in a disabled state.
Call Start job to start synchronization.

### [New-MgServicePrincipalSynchronizationJobOnDemand](New-MgServicePrincipalSynchronizationJobOnDemand.md)
Select a user and provision the account on-demand.
The rate limit for this API is 5 requests per 10 seconds.

### [New-MgServicePrincipalSynchronizationJobSchemaDirectory](New-MgServicePrincipalSynchronizationJobSchemaDirectory.md)
Create new navigation property to directories for servicePrincipals

### [New-MgServicePrincipalSynchronizationTemplate](New-MgServicePrincipalSynchronizationTemplate.md)
Create new navigation property to templates for servicePrincipals

### [New-MgServicePrincipalSynchronizationTemplateSchemaDirectory](New-MgServicePrincipalSynchronizationTemplateSchemaDirectory.md)
Create new navigation property to directories for servicePrincipals

### [New-MgUserAppRoleAssignment](New-MgUserAppRoleAssignment.md)
Use this API to assign an app role to a user.
To grant an app role assignment to a user, you need three identifiers:

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
Remove a key credential from an application.
This method along with addKey can be used by an application to automate rolling its expiring keys.
As part of the request validation for this method, a proof of possession of an existing key is verified before the action can be performed.

### [Remove-MgApplicationOwnerByRef](Remove-MgApplicationOwnerByRef.md)
Delete ref of navigation property owners for applications

### [Remove-MgApplicationPassword](Remove-MgApplicationPassword.md)
Removes a password from an application.

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

### [Remove-MgApplicationTemplate](Remove-MgApplicationTemplate.md)
Delete entity from applicationTemplates

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
Delete single sign-on credentials using a password for a user or group.

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
Restart a stopped synchronization job, forcing it to reprocess all the objects in the directory.
Optionally clears existing the synchronization state and previous errors.

### [Restart-MgServicePrincipalSynchronizationJob](Restart-MgServicePrincipalSynchronizationJob.md)
Restart a stopped synchronization job, forcing it to reprocess all the objects in the directory.
Optionally clears existing the synchronization state and previous errors.

### [Set-MgApplicationConnectorGroupByRef](Set-MgApplicationConnectorGroupByRef.md)
Update the ref of navigation property connectorGroup in applications

### [Set-MgApplicationLogo](Set-MgApplicationLogo.md)
The main logo for the application.
Not nullable.

### [Set-MgApplicationVerifiedPublisher](Set-MgApplicationVerifiedPublisher.md)
Set the the verifiedPublisher on an application.
For more information, including prerequisites to setting a verified publisher, see Publisher verification.

### [Set-MgOnPremisePublishingProfileConnectorGroupApplicationLogo](Set-MgOnPremisePublishingProfileConnectorGroupApplicationLogo.md)
The main logo for the application.
Not nullable.

### [Start-MgApplicationSynchronizationJob](Start-MgApplicationSynchronizationJob.md)
Start an existing synchronization job.
If the job is in a paused state, it will continue processing changes from the point where it was paused.
If the job is in quarantine, the quarantine status will be cleared.
Do not create scripts to call the start job continuously while it's running because that can cause the service to stop running.
Use the start job only when the job is currently paused or in quarantine.

### [Start-MgServicePrincipalSynchronizationJob](Start-MgServicePrincipalSynchronizationJob.md)
Start an existing synchronization job.
If the job is in a paused state, it will continue processing changes from the point where it was paused.
If the job is in quarantine, the quarantine status will be cleared.
Do not create scripts to call the start job continuously while it's running because that can cause the service to stop running.
Use the start job only when the job is currently paused or in quarantine.

### [Stop-MgApplicationSynchronizationJob](Stop-MgApplicationSynchronizationJob.md)
Invoke action stop

### [Stop-MgServicePrincipalSynchronizationJob](Stop-MgServicePrincipalSynchronizationJob.md)
Invoke action stop

### [Suspend-MgApplicationSynchronizationJob](Suspend-MgApplicationSynchronizationJob.md)
Temporarily stop a running synchronization job.
All the progress, including job state, is persisted, and the job will continue from where it left off when a start call is made.

### [Suspend-MgServicePrincipalSynchronizationJob](Suspend-MgServicePrincipalSynchronizationJob.md)
Temporarily stop a running synchronization job.
All the progress, including job state, is persisted, and the job will continue from where it left off when a start call is made.

### [Test-MgApplicationProperty](Test-MgApplicationProperty.md)
Validate that a Microsoft 365 group's display name or mail nickname complies with naming policies.
Clients can use this API to determine whether a display name or mail nickname is valid before trying to **create** a Microsoft 365 group.
For validating properties of an existing group, use the validateProperties function for groups.
The following validations are performed for the display name and mail nickname properties: \n1.
Validate the prefix and suffix naming policy\n2.
Validate the custom banned words policy\n3.
Validate the mail nickname is unique This API returns with the first failure encountered.
If one or more properties fail multiple validations, only the property with the first validation failure is returned.
However, you can validate both the mail nickname and the display name and receive a collection of validation errors if you are only validating the prefix and suffix naming policy.

### [Test-MgApplicationSynchronizationJobCredentials](Test-MgApplicationSynchronizationJobCredentials.md)
Validate that the credentials are valid in the tenant.

### [Test-MgServicePrincipalProperty](Test-MgServicePrincipalProperty.md)
Validate that a Microsoft 365 group's display name or mail nickname complies with naming policies.
Clients can use this API to determine whether a display name or mail nickname is valid before trying to **create** a Microsoft 365 group.
For validating properties of an existing group, use the validateProperties function for groups.
The following validations are performed for the display name and mail nickname properties: \n1.
Validate the prefix and suffix naming policy\n2.
Validate the custom banned words policy\n3.
Validate the mail nickname is unique This API returns with the first failure encountered.
If one or more properties fail multiple validations, only the property with the first validation failure is returned.
However, you can validate both the mail nickname and the display name and receive a collection of validation errors if you are only validating the prefix and suffix naming policy.

### [Test-MgServicePrincipalSynchronizationJobCredentials](Test-MgServicePrincipalSynchronizationJobCredentials.md)
Validate that the credentials are valid in the tenant.

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
Update the synchronization schema for a given job or template.
This method fully replaces the current schema with the one provided in the request.
To update the schema of a template, make the call on the application object.
You must be the owner of the application.

### [Update-MgApplicationSynchronizationJobSchemaDirectory](Update-MgApplicationSynchronizationJobSchemaDirectory.md)
Update the navigation property directories in applications

### [Update-MgApplicationSynchronizationTemplate](Update-MgApplicationSynchronizationTemplate.md)
Update the navigation property templates in applications

### [Update-MgApplicationSynchronizationTemplateSchema](Update-MgApplicationSynchronizationTemplateSchema.md)
Update the navigation property schema in applications

### [Update-MgApplicationSynchronizationTemplateSchemaDirectory](Update-MgApplicationSynchronizationTemplateSchemaDirectory.md)
Update the navigation property directories in applications

### [Update-MgApplicationTemplate](Update-MgApplicationTemplate.md)
Update entity in applicationTemplates

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
Update single sign-on credentials using a password for a user or group.

### [Update-MgServicePrincipalSynchronization](Update-MgServicePrincipalSynchronization.md)
Update the navigation property synchronization in servicePrincipals

### [Update-MgServicePrincipalSynchronizationJob](Update-MgServicePrincipalSynchronizationJob.md)
Update the navigation property jobs in servicePrincipals

### [Update-MgServicePrincipalSynchronizationJobSchema](Update-MgServicePrincipalSynchronizationJobSchema.md)
Update the synchronization schema for a given job or template.
This method fully replaces the current schema with the one provided in the request.
To update the schema of a template, make the call on the application object.
You must be the owner of the application.

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

