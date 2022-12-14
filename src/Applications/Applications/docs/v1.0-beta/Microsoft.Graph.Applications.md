---
Module Name: Microsoft.Graph.Beta.Applications
Module Guid: 0495599b-29dc-4963-b533-b66db030a2d0
Download Help Link: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.Beta.applications
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Beta.Applications Module
## Description
Microsoft.Graph.Beta PowerShell Cmdlets

## Microsoft.Graph.Beta.Applications Cmdlets
### [Add-MgBetaApplicationKey](Add-MgBetaApplicationKey.md)
Add a key credential to an application.
This method, along with removeKey, can be used by an application to automate rolling its expiring keys.
As part of the request validation for this method, a proof of possession of an existing key is verified before the action can be performed.
Applications that don’t have any existing valid certificates (no certificates have been added yet, or all certificates have expired), won’t be able to use this service action.
You can use the Update application operation to perform an update instead.

### [Add-MgBetaApplicationPassword](Add-MgBetaApplicationPassword.md)
Adds a strong password to an application.

### [Add-MgBetaServicePrincipalTokenSigningCertificate](Add-MgBetaServicePrincipalTokenSigningCertificate.md)
Creates a self-signed signing certificate and returns a selfSignedCertificate object, which is the public part of the generated certificate.
The self-signed signing certificate is composed of the following objects which are added to the servicePrincipal: \n+ The keyCredentials object with the following objects:\n    + A private key object with **usage** set to `Sign`.\n    + A public key object with **usage** set to `Verify`.\n+ The passwordCredentials object.
All the objects have the same value of **customKeyIdentifier**.
The **passwordCredential** is used to open the PFX file (private key).
It and the associated private key object have the same value of **keyId**.
Once set during creation through the **displayName** property, the subject of the certificate cannot be updated.
The **startDateTime** is set to the same time the certificate is created using the action.
The **endDateTime** can be up to three years after the certificate is created.

### [Clear-MgBetaApplicationVerifiedPublisher](Clear-MgBetaApplicationVerifiedPublisher.md)
Unset the the verifiedPublisher previously set on an application, removing all verified publisher properties.
For more information, see Publisher verification.

### [Confirm-MgBetaApplicationMemberGroup](Confirm-MgBetaApplicationMemberGroup.md)
Check for membership in a specified list of group IDs, and return from that list those groups (identified by IDs) of which the specified user, group, service principal, organizational contact, device, or directory object is a member.
This function is transitive.
You can check up to a maximum of 20 groups per request.
This function supports all groups provisioned in Azure AD.
Because Microsoft 365 groups cannot contain other groups, membership in a Microsoft 365 group is always direct.

### [Confirm-MgBetaApplicationMemberObject](Confirm-MgBetaApplicationMemberObject.md)
Invoke action checkMemberObjects

### [Confirm-MgBetaServicePrincipalMemberGroup](Confirm-MgBetaServicePrincipalMemberGroup.md)
Check for membership in a specified list of group IDs, and return from that list those groups (identified by IDs) of which the specified user, group, service principal, organizational contact, device, or directory object is a member.
This function is transitive.
You can check up to a maximum of 20 groups per request.
This function supports all groups provisioned in Azure AD.
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

### [Get-MgBetaApplicationById](Get-MgBetaApplicationById.md)
Return the directory objects specified in a list of IDs.
Some common uses for this function are to:

### [Get-MgBetaApplicationConnectorGroup](Get-MgBetaApplicationConnectorGroup.md)
The connectorGroup the application is using with Azure AD Application Proxy.
Nullable.

### [Get-MgBetaApplicationConnectorGroupByRef](Get-MgBetaApplicationConnectorGroupByRef.md)
The connectorGroup the application is using with Azure AD Application Proxy.
Nullable.

### [Get-MgBetaApplicationCreatedOnBehalfOf](Get-MgBetaApplicationCreatedOnBehalfOf.md)
Supports $filter (/$count eq 0, /$count ne 0).
Read-only.

### [Get-MgBetaApplicationDelta](Get-MgBetaApplicationDelta.md)
Invoke function delta

### [Get-MgBetaApplicationExtensionProperty](Get-MgBetaApplicationExtensionProperty.md)
Read-only.
Nullable.
Supports $expand and $filter (/$count eq 0, /$count ne 0).

### [Get-MgBetaApplicationFederatedIdentityCredential](Get-MgBetaApplicationFederatedIdentityCredential.md)
Federated identities for applications.
Supports $expand and $filter (startsWith, /$count eq 0, /$count ne 0).

### [Get-MgBetaApplicationHomeRealmDiscoveryPolicy](Get-MgBetaApplicationHomeRealmDiscoveryPolicy.md)
Get homeRealmDiscoveryPolicies from applications

### [Get-MgBetaApplicationLogo](Get-MgBetaApplicationLogo.md)
The main logo for the application.
Not nullable.

### [Get-MgBetaApplicationMemberGroup](Get-MgBetaApplicationMemberGroup.md)
Return all the group IDs for the groups that the specified user, group, service principal, organizational contact, device, or directory object is a member of.
This function is transitive.

### [Get-MgBetaApplicationMemberObject](Get-MgBetaApplicationMemberObject.md)
Invoke action getMemberObjects

### [Get-MgBetaApplicationOwner](Get-MgBetaApplicationOwner.md)
Directory objects that are owners of the application.
Read-only.
Nullable.
Supports $expand and $filter (/$count eq 0, /$count ne 0, /$count eq 1, /$count ne 1).

### [Get-MgBetaApplicationOwnerByRef](Get-MgBetaApplicationOwnerByRef.md)
Directory objects that are owners of the application.
Read-only.
Nullable.
Supports $expand and $filter (/$count eq 0, /$count ne 0, /$count eq 1, /$count ne 1).

### [Get-MgBetaApplicationSynchronization](Get-MgBetaApplicationSynchronization.md)
Get synchronization from applications

### [Get-MgBetaApplicationSynchronizationAccessToken](Get-MgBetaApplicationSynchronizationAccessToken.md)
Acquire an OAuth Access token to authorize the Azure AD provisioning service to provision users into an application.

### [Get-MgBetaApplicationSynchronizationJob](Get-MgBetaApplicationSynchronizationJob.md)
Performs synchronization by periodically running in the background, polling for changes in one directory, and pushing them to another directory.

### [Get-MgBetaApplicationSynchronizationJobSchema](Get-MgBetaApplicationSynchronizationJobSchema.md)
Retrieve the schema for a given synchronization job or template.

### [Get-MgBetaApplicationSynchronizationJobSchemaDirectory](Get-MgBetaApplicationSynchronizationJobSchemaDirectory.md)
Contains the collection of directories and all of their objects.

### [Get-MgBetaApplicationSynchronizationTemplate](Get-MgBetaApplicationSynchronizationTemplate.md)
Pre-configured synchronization settings for a particular application.

### [Get-MgBetaApplicationSynchronizationTemplateSchema](Get-MgBetaApplicationSynchronizationTemplateSchema.md)
Default synchronization schema for the jobs based on this template.

### [Get-MgBetaApplicationSynchronizationTemplateSchemaDirectory](Get-MgBetaApplicationSynchronizationTemplateSchemaDirectory.md)
Contains the collection of directories and all of their objects.

### [Get-MgBetaApplicationTemplate](Get-MgBetaApplicationTemplate.md)
Retrieve the properties of an applicationTemplate object.

### [Get-MgBetaApplicationTokenIssuancePolicy](Get-MgBetaApplicationTokenIssuancePolicy.md)
List the tokenIssuancePolicy objects that are assigned to an application.

### [Get-MgBetaApplicationTokenIssuancePolicyByRef](Get-MgBetaApplicationTokenIssuancePolicyByRef.md)
List the tokenIssuancePolicy objects that are assigned to an application.

### [Get-MgBetaApplicationTokenLifetimePolicy](Get-MgBetaApplicationTokenLifetimePolicy.md)
List the tokenLifetimePolicy objects that are assigned to an application or servicePrincipal..

### [Get-MgBetaApplicationTokenLifetimePolicyByRef](Get-MgBetaApplicationTokenLifetimePolicyByRef.md)
List the tokenLifetimePolicy objects that are assigned to an application or servicePrincipal..

### [Get-MgBetaApplicationUserOwnedObject](Get-MgBetaApplicationUserOwnedObject.md)
Invoke action getUserOwnedObjects

### [Get-MgBetaGroupAppRoleAssignment](Get-MgBetaGroupAppRoleAssignment.md)
Represents the app roles a group has been granted for an application.
Supports $expand.

### [Get-MgBetaOnPremisePublishingProfile](Get-MgBetaOnPremisePublishingProfile.md)
Get entity from onPremisesPublishingProfiles by key

### [Get-MgBetaOnPremisePublishingProfileAgent](Get-MgBetaOnPremisePublishingProfileAgent.md)
List of existing onPremisesAgent objects.
Read-only.
Nullable.

### [Get-MgBetaOnPremisePublishingProfileAgentGroup](Get-MgBetaOnPremisePublishingProfileAgentGroup.md)
List of existing onPremisesAgentGroup objects.
Read-only.
Nullable.

### [Get-MgBetaOnPremisePublishingProfileAgentGroupAgent](Get-MgBetaOnPremisePublishingProfileAgentGroupAgent.md)
List of onPremisesAgent that are assigned to an onPremisesAgentGroup.
Read-only.
Nullable.

### [Get-MgBetaOnPremisePublishingProfileAgentGroupByRef](Get-MgBetaOnPremisePublishingProfileAgentGroupByRef.md)
List of onPremisesAgentGroups that an onPremisesAgent is assigned to.
Read-only.
Nullable.

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

### [Get-MgBetaOnPremisePublishingProfileConnector](Get-MgBetaOnPremisePublishingProfileConnector.md)
List of existing connector objects for applications published through Application Proxy.
Read-only.
Nullable.

### [Get-MgBetaOnPremisePublishingProfileConnectorGroup](Get-MgBetaOnPremisePublishingProfileConnectorGroup.md)
List of existing connectorGroup objects for applications published through Application Proxy.
Read-only.
Nullable.

### [Get-MgBetaOnPremisePublishingProfileConnectorGroupApplication](Get-MgBetaOnPremisePublishingProfileConnectorGroupApplication.md)
Get applications from onPremisesPublishingProfiles

### [Get-MgBetaOnPremisePublishingProfileConnectorGroupApplicationLogo](Get-MgBetaOnPremisePublishingProfileConnectorGroupApplicationLogo.md)
The main logo for the application.
Not nullable.

### [Get-MgBetaOnPremisePublishingProfileConnectorGroupMember](Get-MgBetaOnPremisePublishingProfileConnectorGroupMember.md)
Get members from onPremisesPublishingProfiles

### [Get-MgBetaOnPremisePublishingProfileConnectorGroupMemberByRef](Get-MgBetaOnPremisePublishingProfileConnectorGroupMemberByRef.md)
Get ref of members from onPremisesPublishingProfiles

### [Get-MgBetaOnPremisePublishingProfileConnectorMemberOf](Get-MgBetaOnPremisePublishingProfileConnectorMemberOf.md)
The connectorGroup that the connector is a member of.
Read-only.

### [Get-MgBetaOnPremisePublishingProfileConnectorMemberOfByRef](Get-MgBetaOnPremisePublishingProfileConnectorMemberOfByRef.md)
The connectorGroup that the connector is a member of.
Read-only.

### [Get-MgBetaOnPremisePublishingProfilePublishedResource](Get-MgBetaOnPremisePublishingProfilePublishedResource.md)
List of existing publishedResource objects.
Read-only.
Nullable.

### [Get-MgBetaOnPremisePublishingProfilePublishedResourceAgentGroup](Get-MgBetaOnPremisePublishingProfilePublishedResourceAgentGroup.md)
List of onPremisesAgentGroups that a publishedResource is assigned to.
Read-only.
Nullable.

### [Get-MgBetaOnPremisePublishingProfilePublishedResourceAgentGroupByRef](Get-MgBetaOnPremisePublishingProfilePublishedResourceAgentGroupByRef.md)
List of onPremisesAgentGroups that a publishedResource is assigned to.
Read-only.
Nullable.

### [Get-MgBetaServicePrincipal](Get-MgBetaServicePrincipal.md)
Retrieve the properties and relationships of a servicePrincipal object.

### [Get-MgBetaServicePrincipalAppManagementPolicy](Get-MgBetaServicePrincipalAppManagementPolicy.md)
The appManagementPolicy applied to this service principal.

### [Get-MgBetaServicePrincipalAppRoleAssignedTo](Get-MgBetaServicePrincipalAppRoleAssignedTo.md)
App role assignments for this app or service, granted to users, groups, and other service principals.Supports $expand.

### [Get-MgBetaServicePrincipalAppRoleAssignment](Get-MgBetaServicePrincipalAppRoleAssignment.md)
App role assignment for another app or service, granted to this service principal.
Supports $expand.

### [Get-MgBetaServicePrincipalById](Get-MgBetaServicePrincipalById.md)
Return the directory objects specified in a list of IDs.
Some common uses for this function are to:

### [Get-MgBetaServicePrincipalClaimMappingPolicy](Get-MgBetaServicePrincipalClaimMappingPolicy.md)
List the claimsMappingPolicy objects that are assigned to a servicePrincipal.

### [Get-MgBetaServicePrincipalClaimMappingPolicyByRef](Get-MgBetaServicePrincipalClaimMappingPolicyByRef.md)
List the claimsMappingPolicy objects that are assigned to a servicePrincipal.

### [Get-MgBetaServicePrincipalCreatedObject](Get-MgBetaServicePrincipalCreatedObject.md)
Directory objects created by this service principal.
Read-only.
Nullable.

### [Get-MgBetaServicePrincipalDelegatedPermissionClassification](Get-MgBetaServicePrincipalDelegatedPermissionClassification.md)
The permission classifications for delegated permissions exposed by the app that this service principal represents.
Supports $expand.

### [Get-MgBetaServicePrincipalDelta](Get-MgBetaServicePrincipalDelta.md)
Invoke function delta

### [Get-MgBetaServicePrincipalEndpoint](Get-MgBetaServicePrincipalEndpoint.md)
Endpoints available for discovery.
Services like Sharepoint populate this property with a tenant specific SharePoint endpoints that other applications can discover and use in their experiences.

### [Get-MgBetaServicePrincipalHomeRealmDiscoveryPolicy](Get-MgBetaServicePrincipalHomeRealmDiscoveryPolicy.md)
List the homeRealmDiscoveryPolicy objects that are assigned to a servicePrincipal.

### [Get-MgBetaServicePrincipalHomeRealmDiscoveryPolicyByRef](Get-MgBetaServicePrincipalHomeRealmDiscoveryPolicyByRef.md)
List the homeRealmDiscoveryPolicy objects that are assigned to a servicePrincipal.

### [Get-MgBetaServicePrincipalLicenseDetail](Get-MgBetaServicePrincipalLicenseDetail.md)
Get licenseDetails from servicePrincipals

### [Get-MgBetaServicePrincipalMemberGroup](Get-MgBetaServicePrincipalMemberGroup.md)
Return all the group IDs for the groups that the specified user, group, service principal, organizational contact, device, or directory object is a member of.
This function is transitive.

### [Get-MgBetaServicePrincipalMemberObject](Get-MgBetaServicePrincipalMemberObject.md)
Invoke action getMemberObjects

### [Get-MgBetaServicePrincipalMemberOf](Get-MgBetaServicePrincipalMemberOf.md)
Roles that this service principal is a member of.
HTTP Methods: GET Read-only.
Nullable.
Supports $expand.

### [Get-MgBetaServicePrincipalOauth2PermissionGrant](Get-MgBetaServicePrincipalOauth2PermissionGrant.md)
Delegated permission grants authorizing this service principal to access an API on behalf of a signed-in user.
Read-only.
Nullable.

### [Get-MgBetaServicePrincipalOwnedObject](Get-MgBetaServicePrincipalOwnedObject.md)
Directory objects that are owned by this service principal.
Read-only.
Nullable.
Supports $expand and $filter (/$count eq 0, /$count ne 0, /$count eq 1, /$count ne 1).

### [Get-MgBetaServicePrincipalOwner](Get-MgBetaServicePrincipalOwner.md)
Directory objects that are owners of this servicePrincipal.
The owners are a set of non-admin users or servicePrincipals who are allowed to modify this object.
Read-only.
Nullable.
Supports $expand and $filter (/$count eq 0, /$count ne 0, /$count eq 1, /$count ne 1).

### [Get-MgBetaServicePrincipalOwnerByRef](Get-MgBetaServicePrincipalOwnerByRef.md)
Directory objects that are owners of this servicePrincipal.
The owners are a set of non-admin users or servicePrincipals who are allowed to modify this object.
Read-only.
Nullable.
Supports $expand and $filter (/$count eq 0, /$count ne 0, /$count eq 1, /$count ne 1).

### [Get-MgBetaServicePrincipalPasswordSingleSignOnCredentials](Get-MgBetaServicePrincipalPasswordSingleSignOnCredentials.md)
Get a list of single sign-on credentials using a password for a user or group.

### [Get-MgBetaServicePrincipalSynchronization](Get-MgBetaServicePrincipalSynchronization.md)
Get synchronization from servicePrincipals

### [Get-MgBetaServicePrincipalSynchronizationAccessToken](Get-MgBetaServicePrincipalSynchronizationAccessToken.md)
Acquire an OAuth Access token to authorize the Azure AD provisioning service to provision users into an application.

### [Get-MgBetaServicePrincipalSynchronizationJob](Get-MgBetaServicePrincipalSynchronizationJob.md)
Performs synchronization by periodically running in the background, polling for changes in one directory, and pushing them to another directory.

### [Get-MgBetaServicePrincipalSynchronizationJobSchema](Get-MgBetaServicePrincipalSynchronizationJobSchema.md)
Retrieve the schema for a given synchronization job or template.

### [Get-MgBetaServicePrincipalSynchronizationJobSchemaDirectory](Get-MgBetaServicePrincipalSynchronizationJobSchemaDirectory.md)
Contains the collection of directories and all of their objects.

### [Get-MgBetaServicePrincipalSynchronizationTemplate](Get-MgBetaServicePrincipalSynchronizationTemplate.md)
Pre-configured synchronization settings for a particular application.

### [Get-MgBetaServicePrincipalSynchronizationTemplateSchema](Get-MgBetaServicePrincipalSynchronizationTemplateSchema.md)
Default synchronization schema for the jobs based on this template.

### [Get-MgBetaServicePrincipalSynchronizationTemplateSchemaDirectory](Get-MgBetaServicePrincipalSynchronizationTemplateSchemaDirectory.md)
Contains the collection of directories and all of their objects.

### [Get-MgBetaServicePrincipalTokenIssuancePolicy](Get-MgBetaServicePrincipalTokenIssuancePolicy.md)
The tokenIssuancePolicies assigned to this service principal.
Supports $expand.

### [Get-MgBetaServicePrincipalTokenLifetimePolicy](Get-MgBetaServicePrincipalTokenLifetimePolicy.md)
The tokenLifetimePolicies assigned to this service principal.
Supports $expand.

### [Get-MgBetaServicePrincipalTransitiveMemberOf](Get-MgBetaServicePrincipalTransitiveMemberOf.md)
Get transitiveMemberOf from servicePrincipals

### [Get-MgBetaServicePrincipalUserOwnedObject](Get-MgBetaServicePrincipalUserOwnedObject.md)
Invoke action getUserOwnedObjects

### [Get-MgBetaUserAppRoleAssignment](Get-MgBetaUserAppRoleAssignment.md)
Represents the app roles a user has been granted for an application.
Supports $expand.

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
Add an instance of an application from the Azure AD application gallery into your directory.
You can also use this API to instantiate non-gallery apps.
Use the following ID for the **applicationTemplate** object: `8adf8e6e-67b2-4cf2-a259-e3dc5476c621`.

### [Invoke-MgBetaParseApplicationSynchronizationJobSchemaExpression](Invoke-MgBetaParseApplicationSynchronizationJobSchemaExpression.md)
Parse a given string expression into an attributeMappingSource object.
For more information about expressions, see Writing Expressions for Attribute Mappings in Azure Active Directory.

### [Invoke-MgBetaParseApplicationSynchronizationTemplateSchemaExpression](Invoke-MgBetaParseApplicationSynchronizationTemplateSchemaExpression.md)
Parse a given string expression into an attributeMappingSource object.
For more information about expressions, see Writing Expressions for Attribute Mappings in Azure Active Directory.

### [Invoke-MgBetaParseServicePrincipalSynchronizationJobSchemaExpression](Invoke-MgBetaParseServicePrincipalSynchronizationJobSchemaExpression.md)
Parse a given string expression into an attributeMappingSource object.
For more information about expressions, see Writing Expressions for Attribute Mappings in Azure Active Directory.

### [Invoke-MgBetaParseServicePrincipalSynchronizationTemplateSchemaExpression](Invoke-MgBetaParseServicePrincipalSynchronizationTemplateSchemaExpression.md)
Parse a given string expression into an attributeMappingSource object.
For more information about expressions, see Writing Expressions for Attribute Mappings in Azure Active Directory.

### [New-MgBetaApplication](New-MgBetaApplication.md)
Create a new application object.

### [New-MgBetaApplicationAppManagementPolicyByRef](New-MgBetaApplicationAppManagementPolicyByRef.md)
Create new navigation property ref to appManagementPolicies for applications

### [New-MgBetaApplicationExtensionProperty](New-MgBetaApplicationExtensionProperty.md)
Create a new directory extension definition, represented by an extensionProperty object.

### [New-MgBetaApplicationFederatedIdentityCredential](New-MgBetaApplicationFederatedIdentityCredential.md)
Create a new federatedIdentityCredential object for an application.
By configuring a trust relationship between your Azure AD application registration and the identity provider for your compute platform, you can use tokens issued by that platform to authenticate with Microsoft identity platform and call APIs in the Microsoft ecosystem.
Maximum of 20 objects can be added to an application.

### [New-MgBetaApplicationOwnerByRef](New-MgBetaApplicationOwnerByRef.md)
Create new navigation property ref to owners for applications

### [New-MgBetaApplicationSynchronizationJob](New-MgBetaApplicationSynchronizationJob.md)
Create new synchronization job with a default synchronization schema.
The job is created in a disabled state.
Call Start job to start synchronization.

### [New-MgBetaApplicationSynchronizationJobOnDemand](New-MgBetaApplicationSynchronizationJobOnDemand.md)
Select a user and provision the account on-demand.
The rate limit for this API is 5 requests per 10 seconds.

### [New-MgBetaApplicationSynchronizationJobSchemaDirectory](New-MgBetaApplicationSynchronizationJobSchemaDirectory.md)
Create new navigation property to directories for applications

### [New-MgBetaApplicationSynchronizationTemplate](New-MgBetaApplicationSynchronizationTemplate.md)
Create new navigation property to templates for applications

### [New-MgBetaApplicationSynchronizationTemplateSchemaDirectory](New-MgBetaApplicationSynchronizationTemplateSchemaDirectory.md)
Create new navigation property to directories for applications

### [New-MgBetaApplicationTemplate](New-MgBetaApplicationTemplate.md)
Add new entity to applicationTemplates

### [New-MgBetaApplicationTokenIssuancePolicyByRef](New-MgBetaApplicationTokenIssuancePolicyByRef.md)
Create new navigation property ref to tokenIssuancePolicies for applications

### [New-MgBetaApplicationTokenLifetimePolicyByRef](New-MgBetaApplicationTokenLifetimePolicyByRef.md)
Assign a tokenLifetimePolicy to an application or servicePrincipal.

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
Create a connectorGroup object.

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
Create new navigation property ref to claimsMappingPolicies for servicePrincipals

### [New-MgBetaServicePrincipalDelegatedPermissionClassification](New-MgBetaServicePrincipalDelegatedPermissionClassification.md)
Classify a delegated permission by adding a delegatedPermissionClassification to the servicePrincipal representing the API.

### [New-MgBetaServicePrincipalEndpoint](New-MgBetaServicePrincipalEndpoint.md)
Create new navigation property to endpoints for servicePrincipals

### [New-MgBetaServicePrincipalHomeRealmDiscoveryPolicyByRef](New-MgBetaServicePrincipalHomeRealmDiscoveryPolicyByRef.md)
Create new navigation property ref to homeRealmDiscoveryPolicies for servicePrincipals

### [New-MgBetaServicePrincipalLicenseDetail](New-MgBetaServicePrincipalLicenseDetail.md)
Create new navigation property to licenseDetails for servicePrincipals

### [New-MgBetaServicePrincipalOwnerByRef](New-MgBetaServicePrincipalOwnerByRef.md)
Create new navigation property ref to owners for servicePrincipals

### [New-MgBetaServicePrincipalPasswordSingleSignOnCredentials](New-MgBetaServicePrincipalPasswordSingleSignOnCredentials.md)
Create single sign-on credentials using a password for a user or group.

### [New-MgBetaServicePrincipalSynchronizationJob](New-MgBetaServicePrincipalSynchronizationJob.md)
Create new synchronization job with a default synchronization schema.
The job is created in a disabled state.
Call Start job to start synchronization.

### [New-MgBetaServicePrincipalSynchronizationJobOnDemand](New-MgBetaServicePrincipalSynchronizationJobOnDemand.md)
Select a user and provision the account on-demand.
The rate limit for this API is 5 requests per 10 seconds.

### [New-MgBetaServicePrincipalSynchronizationJobSchemaDirectory](New-MgBetaServicePrincipalSynchronizationJobSchemaDirectory.md)
Create new navigation property to directories for servicePrincipals

### [New-MgBetaServicePrincipalSynchronizationTemplate](New-MgBetaServicePrincipalSynchronizationTemplate.md)
Create new navigation property to templates for servicePrincipals

### [New-MgBetaServicePrincipalSynchronizationTemplateSchemaDirectory](New-MgBetaServicePrincipalSynchronizationTemplateSchemaDirectory.md)
Create new navigation property to directories for servicePrincipals

### [New-MgBetaUserAppRoleAssignment](New-MgBetaUserAppRoleAssignment.md)
Use this API to assign an app role to a user.
To grant an app role assignment to a user, you need three identifiers:

### [Ping-MgBetaApplicationsSynchronization](Ping-MgBetaApplicationsSynchronization.md)
Invoke function Ping

### [Ping-MgBetaServicePrincipalsSynchronization](Ping-MgBetaServicePrincipalsSynchronization.md)
Invoke function Ping

### [Remove-MgBetaApplication](Remove-MgBetaApplication.md)
Deletes an application.
When deleted, apps are moved to a temporary container and can be restored within 30 days.
After that time, they are permanently deleted.

### [Remove-MgBetaApplicationAppManagementPolicyByRef](Remove-MgBetaApplicationAppManagementPolicyByRef.md)
Delete ref of navigation property appManagementPolicies for applications

### [Remove-MgBetaApplicationConnectorGroupByRef](Remove-MgBetaApplicationConnectorGroupByRef.md)
Delete ref of navigation property connectorGroup for applications

### [Remove-MgBetaApplicationExtensionProperty](Remove-MgBetaApplicationExtensionProperty.md)
Delete navigation property extensionProperties for applications

### [Remove-MgBetaApplicationFederatedIdentityCredential](Remove-MgBetaApplicationFederatedIdentityCredential.md)
Delete navigation property federatedIdentityCredentials for applications

### [Remove-MgBetaApplicationKey](Remove-MgBetaApplicationKey.md)
Remove a key credential from an application.
This method along with addKey can be used by an application to automate rolling its expiring keys.
As part of the request validation for this method, a proof of possession of an existing key is verified before the action can be performed.

### [Remove-MgBetaApplicationOwnerByRef](Remove-MgBetaApplicationOwnerByRef.md)
Delete ref of navigation property owners for applications

### [Remove-MgBetaApplicationPassword](Remove-MgBetaApplicationPassword.md)
Removes a password from an application.

### [Remove-MgBetaApplicationSynchronization](Remove-MgBetaApplicationSynchronization.md)
Delete navigation property synchronization for applications

### [Remove-MgBetaApplicationSynchronizationJob](Remove-MgBetaApplicationSynchronizationJob.md)
Delete navigation property jobs for applications

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

### [Remove-MgBetaApplicationTemplate](Remove-MgBetaApplicationTemplate.md)
Delete entity from applicationTemplates

### [Remove-MgBetaApplicationTokenIssuancePolicyByRef](Remove-MgBetaApplicationTokenIssuancePolicyByRef.md)
Delete ref of navigation property tokenIssuancePolicies for applications

### [Remove-MgBetaApplicationTokenLifetimePolicyByRef](Remove-MgBetaApplicationTokenLifetimePolicyByRef.md)
Delete ref of navigation property tokenLifetimePolicies for applications

### [Remove-MgBetaGroupAppRoleAssignment](Remove-MgBetaGroupAppRoleAssignment.md)
Delete navigation property appRoleAssignments for groups

### [Remove-MgBetaOnPremisePublishingProfile](Remove-MgBetaOnPremisePublishingProfile.md)
Delete entity from onPremisesPublishingProfiles

### [Remove-MgBetaOnPremisePublishingProfileAgent](Remove-MgBetaOnPremisePublishingProfileAgent.md)
Delete navigation property agents for onPremisesPublishingProfiles

### [Remove-MgBetaOnPremisePublishingProfileAgentGroup](Remove-MgBetaOnPremisePublishingProfileAgentGroup.md)
Delete navigation property agentGroups for onPremisesPublishingProfiles

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
Delete navigation property connectorGroups for onPremisesPublishingProfiles

### [Remove-MgBetaOnPremisePublishingProfileConnectorMemberOfByRef](Remove-MgBetaOnPremisePublishingProfileConnectorMemberOfByRef.md)
Delete ref of navigation property memberOf for onPremisesPublishingProfiles

### [Remove-MgBetaOnPremisePublishingProfilePublishedResource](Remove-MgBetaOnPremisePublishingProfilePublishedResource.md)
Delete navigation property publishedResources for onPremisesPublishingProfiles

### [Remove-MgBetaOnPremisePublishingProfilePublishedResourceAgentGroupByRef](Remove-MgBetaOnPremisePublishingProfilePublishedResourceAgentGroupByRef.md)
Delete ref of navigation property agentGroups for onPremisesPublishingProfiles

### [Remove-MgBetaServicePrincipal](Remove-MgBetaServicePrincipal.md)
Delete a servicePrincipal object.

### [Remove-MgBetaServicePrincipalAppRoleAssignedTo](Remove-MgBetaServicePrincipalAppRoleAssignedTo.md)
Delete navigation property appRoleAssignedTo for servicePrincipals

### [Remove-MgBetaServicePrincipalAppRoleAssignment](Remove-MgBetaServicePrincipalAppRoleAssignment.md)
Delete navigation property appRoleAssignments for servicePrincipals

### [Remove-MgBetaServicePrincipalClaimMappingPolicyByRef](Remove-MgBetaServicePrincipalClaimMappingPolicyByRef.md)
Delete ref of navigation property claimsMappingPolicies for servicePrincipals

### [Remove-MgBetaServicePrincipalDelegatedPermissionClassification](Remove-MgBetaServicePrincipalDelegatedPermissionClassification.md)
Delete navigation property delegatedPermissionClassifications for servicePrincipals

### [Remove-MgBetaServicePrincipalEndpoint](Remove-MgBetaServicePrincipalEndpoint.md)
Delete navigation property endpoints for servicePrincipals

### [Remove-MgBetaServicePrincipalHomeRealmDiscoveryPolicyByRef](Remove-MgBetaServicePrincipalHomeRealmDiscoveryPolicyByRef.md)
Delete ref of navigation property homeRealmDiscoveryPolicies for servicePrincipals

### [Remove-MgBetaServicePrincipalLicenseDetail](Remove-MgBetaServicePrincipalLicenseDetail.md)
Delete navigation property licenseDetails for servicePrincipals

### [Remove-MgBetaServicePrincipalOwnerByRef](Remove-MgBetaServicePrincipalOwnerByRef.md)
Delete ref of navigation property owners for servicePrincipals

### [Remove-MgBetaServicePrincipalPasswordSingleSignOnCredentials](Remove-MgBetaServicePrincipalPasswordSingleSignOnCredentials.md)
Delete single sign-on credentials using a password for a user or group.

### [Remove-MgBetaServicePrincipalSynchronization](Remove-MgBetaServicePrincipalSynchronization.md)
Delete navigation property synchronization for servicePrincipals

### [Remove-MgBetaServicePrincipalSynchronizationJob](Remove-MgBetaServicePrincipalSynchronizationJob.md)
Delete navigation property jobs for servicePrincipals

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
Delete navigation property appRoleAssignments for users

### [Restart-MgBetaApplicationSynchronizationJob](Restart-MgBetaApplicationSynchronizationJob.md)
Restart a stopped synchronization job, forcing it to reprocess all the objects in the directory.
Optionally clears existing the synchronization state and previous errors.

### [Restart-MgBetaServicePrincipalSynchronizationJob](Restart-MgBetaServicePrincipalSynchronizationJob.md)
Restart a stopped synchronization job, forcing it to reprocess all the objects in the directory.
Optionally clears existing the synchronization state and previous errors.

### [Set-MgBetaApplicationConnectorGroupByRef](Set-MgBetaApplicationConnectorGroupByRef.md)
Update the ref of navigation property connectorGroup in applications

### [Set-MgBetaApplicationLogo](Set-MgBetaApplicationLogo.md)
The main logo for the application.
Not nullable.

### [Set-MgBetaApplicationVerifiedPublisher](Set-MgBetaApplicationVerifiedPublisher.md)
Set the the verifiedPublisher on an application.
For more information, including prerequisites to setting a verified publisher, see Publisher verification.

### [Set-MgBetaOnPremisePublishingProfileConnectorGroupApplicationLogo](Set-MgBetaOnPremisePublishingProfileConnectorGroupApplicationLogo.md)
The main logo for the application.
Not nullable.

### [Start-MgBetaApplicationSynchronizationJob](Start-MgBetaApplicationSynchronizationJob.md)
Start an existing synchronization job.
If the job is in a paused state, it will continue processing changes from the point where it was paused.
If the job is in quarantine, the quarantine status will be cleared.
Do not create scripts to call the start job continuously while it's running because that can cause the service to stop running.
Use the start job only when the job is currently paused or in quarantine.

### [Start-MgBetaServicePrincipalSynchronizationJob](Start-MgBetaServicePrincipalSynchronizationJob.md)
Start an existing synchronization job.
If the job is in a paused state, it will continue processing changes from the point where it was paused.
If the job is in quarantine, the quarantine status will be cleared.
Do not create scripts to call the start job continuously while it's running because that can cause the service to stop running.
Use the start job only when the job is currently paused or in quarantine.

### [Stop-MgBetaApplicationSynchronizationJob](Stop-MgBetaApplicationSynchronizationJob.md)
Invoke action stop

### [Stop-MgBetaServicePrincipalSynchronizationJob](Stop-MgBetaServicePrincipalSynchronizationJob.md)
Invoke action stop

### [Suspend-MgBetaApplicationSynchronizationJob](Suspend-MgBetaApplicationSynchronizationJob.md)
Temporarily stop a running synchronization job.
All the progress, including job state, is persisted, and the job will continue from where it left off when a start call is made.

### [Suspend-MgBetaServicePrincipalSynchronizationJob](Suspend-MgBetaServicePrincipalSynchronizationJob.md)
Temporarily stop a running synchronization job.
All the progress, including job state, is persisted, and the job will continue from where it left off when a start call is made.

### [Test-MgBetaApplicationProperty](Test-MgBetaApplicationProperty.md)
Validate that a Microsoft 365 group's display name or mail nickname complies with naming policies.
Clients can use this API to determine whether a display name or mail nickname is valid before trying to **create** a Microsoft 365 group.
For validating properties of an existing group, use the validateProperties function for groups.
The following validations are performed for the display name and mail nickname properties: \n1.
Validate the prefix and suffix naming policy\n2.
Validate the custom banned words policy\n3.
Validate the mail nickname is unique This API returns with the first failure encountered.
If one or more properties fail multiple validations, only the property with the first validation failure is returned.
However, you can validate both the mail nickname and the display name and receive a collection of validation errors if you are only validating the prefix and suffix naming policy.

### [Test-MgBetaApplicationSynchronizationJobCredentials](Test-MgBetaApplicationSynchronizationJobCredentials.md)
Validate that the credentials are valid in the tenant.

### [Test-MgBetaServicePrincipalProperty](Test-MgBetaServicePrincipalProperty.md)
Validate that a Microsoft 365 group's display name or mail nickname complies with naming policies.
Clients can use this API to determine whether a display name or mail nickname is valid before trying to **create** a Microsoft 365 group.
For validating properties of an existing group, use the validateProperties function for groups.
The following validations are performed for the display name and mail nickname properties: \n1.
Validate the prefix and suffix naming policy\n2.
Validate the custom banned words policy\n3.
Validate the mail nickname is unique This API returns with the first failure encountered.
If one or more properties fail multiple validations, only the property with the first validation failure is returned.
However, you can validate both the mail nickname and the display name and receive a collection of validation errors if you are only validating the prefix and suffix naming policy.

### [Test-MgBetaServicePrincipalSynchronizationJobCredentials](Test-MgBetaServicePrincipalSynchronizationJobCredentials.md)
Validate that the credentials are valid in the tenant.

### [Update-MgBetaApplication](Update-MgBetaApplication.md)
Update the properties of an application object.

### [Update-MgBetaApplicationExtensionProperty](Update-MgBetaApplicationExtensionProperty.md)
Update the navigation property extensionProperties in applications

### [Update-MgBetaApplicationFederatedIdentityCredential](Update-MgBetaApplicationFederatedIdentityCredential.md)
Update the navigation property federatedIdentityCredentials in applications

### [Update-MgBetaApplicationSynchronization](Update-MgBetaApplicationSynchronization.md)
Update the navigation property synchronization in applications

### [Update-MgBetaApplicationSynchronizationJob](Update-MgBetaApplicationSynchronizationJob.md)
Update the navigation property jobs in applications

### [Update-MgBetaApplicationSynchronizationJobSchema](Update-MgBetaApplicationSynchronizationJobSchema.md)
Update the synchronization schema for a given job or template.
This method fully replaces the current schema with the one provided in the request.
To update the schema of a template, make the call on the application object.
You must be the owner of the application.

### [Update-MgBetaApplicationSynchronizationJobSchemaDirectory](Update-MgBetaApplicationSynchronizationJobSchemaDirectory.md)
Update the navigation property directories in applications

### [Update-MgBetaApplicationSynchronizationTemplate](Update-MgBetaApplicationSynchronizationTemplate.md)
Update the navigation property templates in applications

### [Update-MgBetaApplicationSynchronizationTemplateSchema](Update-MgBetaApplicationSynchronizationTemplateSchema.md)
Update the navigation property schema in applications

### [Update-MgBetaApplicationSynchronizationTemplateSchemaDirectory](Update-MgBetaApplicationSynchronizationTemplateSchemaDirectory.md)
Update the navigation property directories in applications

### [Update-MgBetaApplicationTemplate](Update-MgBetaApplicationTemplate.md)
Update entity in applicationTemplates

### [Update-MgBetaGroupAppRoleAssignment](Update-MgBetaGroupAppRoleAssignment.md)
Update the navigation property appRoleAssignments in groups

### [Update-MgBetaOnPremisePublishingProfile](Update-MgBetaOnPremisePublishingProfile.md)
Update entity in onPremisesPublishingProfiles

### [Update-MgBetaOnPremisePublishingProfileAgent](Update-MgBetaOnPremisePublishingProfileAgent.md)
Update the navigation property agents in onPremisesPublishingProfiles

### [Update-MgBetaOnPremisePublishingProfileAgentGroup](Update-MgBetaOnPremisePublishingProfileAgentGroup.md)
Update the navigation property agentGroups in onPremisesPublishingProfiles

### [Update-MgBetaOnPremisePublishingProfileAgentGroupAgent](Update-MgBetaOnPremisePublishingProfileAgentGroupAgent.md)
Update the navigation property agents in onPremisesPublishingProfiles

### [Update-MgBetaOnPremisePublishingProfileAgentGroupPublishedResource](Update-MgBetaOnPremisePublishingProfileAgentGroupPublishedResource.md)
Update the navigation property publishedResources in onPremisesPublishingProfiles

### [Update-MgBetaOnPremisePublishingProfileConnector](Update-MgBetaOnPremisePublishingProfileConnector.md)
Update the navigation property connectors in onPremisesPublishingProfiles

### [Update-MgBetaOnPremisePublishingProfileConnectorGroup](Update-MgBetaOnPremisePublishingProfileConnectorGroup.md)
Update the navigation property connectorGroups in onPremisesPublishingProfiles

### [Update-MgBetaOnPremisePublishingProfilePublishedResource](Update-MgBetaOnPremisePublishingProfilePublishedResource.md)
Update the navigation property publishedResources in onPremisesPublishingProfiles

### [Update-MgBetaServicePrincipal](Update-MgBetaServicePrincipal.md)
Update the properties of servicePrincipal object.

### [Update-MgBetaServicePrincipalAppRoleAssignedTo](Update-MgBetaServicePrincipalAppRoleAssignedTo.md)
Update the navigation property appRoleAssignedTo in servicePrincipals

### [Update-MgBetaServicePrincipalAppRoleAssignment](Update-MgBetaServicePrincipalAppRoleAssignment.md)
Update the navigation property appRoleAssignments in servicePrincipals

### [Update-MgBetaServicePrincipalDelegatedPermissionClassification](Update-MgBetaServicePrincipalDelegatedPermissionClassification.md)
Update the navigation property delegatedPermissionClassifications in servicePrincipals

### [Update-MgBetaServicePrincipalEndpoint](Update-MgBetaServicePrincipalEndpoint.md)
Update the navigation property endpoints in servicePrincipals

### [Update-MgBetaServicePrincipalLicenseDetail](Update-MgBetaServicePrincipalLicenseDetail.md)
Update the navigation property licenseDetails in servicePrincipals

### [Update-MgBetaServicePrincipalPasswordSingleSignOnCredentials](Update-MgBetaServicePrincipalPasswordSingleSignOnCredentials.md)
Update single sign-on credentials using a password for a user or group.

### [Update-MgBetaServicePrincipalSynchronization](Update-MgBetaServicePrincipalSynchronization.md)
Update the navigation property synchronization in servicePrincipals

### [Update-MgBetaServicePrincipalSynchronizationJob](Update-MgBetaServicePrincipalSynchronizationJob.md)
Update the navigation property jobs in servicePrincipals

### [Update-MgBetaServicePrincipalSynchronizationJobSchema](Update-MgBetaServicePrincipalSynchronizationJobSchema.md)
Update the synchronization schema for a given job or template.
This method fully replaces the current schema with the one provided in the request.
To update the schema of a template, make the call on the application object.
You must be the owner of the application.

### [Update-MgBetaServicePrincipalSynchronizationJobSchemaDirectory](Update-MgBetaServicePrincipalSynchronizationJobSchemaDirectory.md)
Update the navigation property directories in servicePrincipals

### [Update-MgBetaServicePrincipalSynchronizationTemplate](Update-MgBetaServicePrincipalSynchronizationTemplate.md)
Update the navigation property templates in servicePrincipals

### [Update-MgBetaServicePrincipalSynchronizationTemplateSchema](Update-MgBetaServicePrincipalSynchronizationTemplateSchema.md)
Update the navigation property schema in servicePrincipals

### [Update-MgBetaServicePrincipalSynchronizationTemplateSchemaDirectory](Update-MgBetaServicePrincipalSynchronizationTemplateSchemaDirectory.md)
Update the navigation property directories in servicePrincipals

### [Update-MgBetaUserAppRoleAssignment](Update-MgBetaUserAppRoleAssignment.md)
Update the navigation property appRoleAssignments in users

