---
Module Name: Microsoft.Graph.Applications
Module Guid: d9f6d543-1603-4a4d-b9d1-3474038ecd37
Download Help Link: https://learn.microsoft.com/powershell/module/microsoft.graph.applications
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Applications Module
## Description
Microsoft Graph PowerShell Cmdlets

## Microsoft.Graph.Applications Cmdlets
### [Add-MgApplicationKey](Add-MgApplicationKey.md)
Add a key credential to an application.
This method, along with removeKey can be used by an application to automate rolling its expiring keys.
As part of the request validation for this method, a proof of possession of an existing key is verified before the action can be performed.
Applications that don’t have any existing valid certificates (no certificates have been added yet, or all certificates have expired), won’t be able to use this service action.
You can use the Update application operation to perform an update instead.

### [Add-MgApplicationPassword](Add-MgApplicationPassword.md)
Adds a strong password or secret to an application.

### [Add-MgServicePrincipalKey](Add-MgServicePrincipalKey.md)
Adds a key credential to a servicePrincipal.
This method along with removeKey can be used by a servicePrincipal to automate rolling its expiring keys.
As part of the request validation for this method, a proof of possession of an existing key is verified before the action can be performed.
ServicePrincipals that don’t have any existing valid certificates (i.e.: no certificates have been added yet, or all certificates have expired), won’t be able to use this service action.
Update servicePrincipal can be used to perform an update instead.

### [Add-MgServicePrincipalPassword](Add-MgServicePrincipalPassword.md)
Add a strong password or secret to a servicePrincipal object.

### [Add-MgServicePrincipalTokenSigningCertificate](Add-MgServicePrincipalTokenSigningCertificate.md)
Create a self-signed signing certificate and return a selfSignedCertificate object, which is the public part of the generated certificate.
The self-signed signing certificate is composed of the following objects, which are added to the servicePrincipal: \n+ The keyCredentials object with the following objects:\n    + A private key object with **usage** set to `Sign`.\n    + A public key object with **usage** set to `Verify`.\n+ The passwordCredentials object.
All the objects have the same value of **customKeyIdentifier**.
The **passwordCredential** is used to open the PFX file (private key).
It and the associated private key object have the same value of **keyId**.
When set during creation through the **displayName** property, the subject of the certificate cannot be updated.
The **startDateTime** is set to the same time the certificate is created using the action.
The **endDateTime** can be up to three years after the certificate is created.

### [Clear-MgApplicationVerifiedPublisher](Clear-MgApplicationVerifiedPublisher.md)
Unset the verifiedPublisher previously set on an application, removing all verified publisher properties.
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

### [Get-MgApplication](Get-MgApplication.md)
Get the properties and relationships of an application object.

### [Get-MgApplicationAppManagementPolicy](Get-MgApplicationAppManagementPolicy.md)
The appManagementPolicy applied to this application.

### [Get-MgApplicationAppManagementPolicyByRef](Get-MgApplicationAppManagementPolicyByRef.md)
The appManagementPolicy applied to this application.

### [Get-MgApplicationAppManagementPolicyCount](Get-MgApplicationAppManagementPolicyCount.md)
Get the number of the resource

### [Get-MgApplicationById](Get-MgApplicationById.md)
Return the directory objects specified in a list of IDs.
Some common uses for this function are to:

### [Get-MgApplicationCount](Get-MgApplicationCount.md)
Get the number of the resource

### [Get-MgApplicationCreatedOnBehalfOf](Get-MgApplicationCreatedOnBehalfOf.md)
Supports $filter (/$count eq 0, /$count ne 0).
Read-only.

### [Get-MgApplicationDelta](Get-MgApplicationDelta.md)
Invoke function delta

### [Get-MgApplicationExtensionProperty](Get-MgApplicationExtensionProperty.md)
Read a directory extension definition represented by an extensionProperty object.

### [Get-MgApplicationExtensionPropertyCount](Get-MgApplicationExtensionPropertyCount.md)
Get the number of the resource

### [Get-MgApplicationFederatedIdentityCredential](Get-MgApplicationFederatedIdentityCredential.md)
Read the properties and relationships of a federatedIdentityCredential object.

### [Get-MgApplicationFederatedIdentityCredentialCount](Get-MgApplicationFederatedIdentityCredentialCount.md)
Get the number of the resource

### [Get-MgApplicationHomeRealmDiscoveryPolicy](Get-MgApplicationHomeRealmDiscoveryPolicy.md)
Get homeRealmDiscoveryPolicies from applications

### [Get-MgApplicationHomeRealmDiscoveryPolicyCount](Get-MgApplicationHomeRealmDiscoveryPolicyCount.md)
Get the number of the resource

### [Get-MgApplicationListOwnerCountAsAppRoleAssignment](Get-MgApplicationListOwnerCountAsAppRoleAssignment.md)
Get the number of the resource

### [Get-MgApplicationListOwnerCountAsEndpoint](Get-MgApplicationListOwnerCountAsEndpoint.md)
Get the number of the resource

### [Get-MgApplicationListOwnerCountAsServicePrincipal](Get-MgApplicationListOwnerCountAsServicePrincipal.md)
Get the number of the resource

### [Get-MgApplicationListOwnerCountAsUser](Get-MgApplicationListOwnerCountAsUser.md)
Get the number of the resource

### [Get-MgApplicationLogo](Get-MgApplicationLogo.md)
The main logo for the application.
Not nullable.

### [Get-MgApplicationMemberGroup](Get-MgApplicationMemberGroup.md)
Return all the group IDs for the groups that the specified user, group, service principal, organizational contact, device, or directory object is a member of.
This function is transitive.

### [Get-MgApplicationMemberObject](Get-MgApplicationMemberObject.md)
Return all IDs for the groups, administrative units, and directory roles that a user, group, service principal, organizational contact, device, or directory object is a member of.
This function is transitive.
**Note:** Only users and role-enabled groups can be members of directory roles.

### [Get-MgApplicationOwner](Get-MgApplicationOwner.md)
Directory objects that are owners of the application.
Read-only.
Nullable.
Supports $expand and $filter (/$count eq 0, /$count ne 0, /$count eq 1, /$count ne 1).

### [Get-MgApplicationOwnerAsAppRoleAssignment](Get-MgApplicationOwnerAsAppRoleAssignment.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.appRoleAssignment

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

### [Get-MgApplicationOwnerCount](Get-MgApplicationOwnerCount.md)
Get the number of the resource

### [Get-MgApplicationTemplate](Get-MgApplicationTemplate.md)
Retrieve the properties of an applicationTemplate object.

### [Get-MgApplicationTemplateCount](Get-MgApplicationTemplateCount.md)
Get the number of the resource

### [Get-MgApplicationTokenIssuancePolicy](Get-MgApplicationTokenIssuancePolicy.md)
List the tokenIssuancePolicy objects that are assigned to an application.

### [Get-MgApplicationTokenIssuancePolicyByRef](Get-MgApplicationTokenIssuancePolicyByRef.md)
List the tokenIssuancePolicy objects that are assigned to an application.

### [Get-MgApplicationTokenIssuancePolicyCount](Get-MgApplicationTokenIssuancePolicyCount.md)
Get the number of the resource

### [Get-MgApplicationTokenLifetimePolicy](Get-MgApplicationTokenLifetimePolicy.md)
List the tokenLifetimePolicy objects that are assigned to an application.

### [Get-MgApplicationTokenLifetimePolicyByRef](Get-MgApplicationTokenLifetimePolicyByRef.md)
List the tokenLifetimePolicy objects that are assigned to an application.

### [Get-MgApplicationTokenLifetimePolicyCount](Get-MgApplicationTokenLifetimePolicyCount.md)
Get the number of the resource

### [Get-MgGroupAppRoleAssignment](Get-MgGroupAppRoleAssignment.md)
Represents the app roles a group has been granted for an application.
Supports $expand.

### [Get-MgGroupAppRoleAssignmentCount](Get-MgGroupAppRoleAssignmentCount.md)
Get the number of the resource

### [Get-MgServicePrincipal](Get-MgServicePrincipal.md)
Retrieve the properties and relationships of a servicePrincipal object.

### [Get-MgServicePrincipalAppManagementPolicy](Get-MgServicePrincipalAppManagementPolicy.md)
The appManagementPolicy applied to this application.

### [Get-MgServicePrincipalAppManagementPolicyCount](Get-MgServicePrincipalAppManagementPolicyCount.md)
Get the number of the resource

### [Get-MgServicePrincipalAppRoleAssignedTo](Get-MgServicePrincipalAppRoleAssignedTo.md)
App role assignments for this app or service, granted to users, groups, and other service principals.
Supports $expand.

### [Get-MgServicePrincipalAppRoleAssignedToCount](Get-MgServicePrincipalAppRoleAssignedToCount.md)
Get the number of the resource

### [Get-MgServicePrincipalAppRoleAssignment](Get-MgServicePrincipalAppRoleAssignment.md)
App role assignment for another app or service, granted to this service principal.
Supports $expand.

### [Get-MgServicePrincipalAppRoleAssignmentCount](Get-MgServicePrincipalAppRoleAssignmentCount.md)
Get the number of the resource

### [Get-MgServicePrincipalById](Get-MgServicePrincipalById.md)
Return the directory objects specified in a list of IDs.
Some common uses for this function are to:

### [Get-MgServicePrincipalClaimMappingPolicy](Get-MgServicePrincipalClaimMappingPolicy.md)
List the claimsMappingPolicy objects that are assigned to a servicePrincipal.

### [Get-MgServicePrincipalClaimMappingPolicyByRef](Get-MgServicePrincipalClaimMappingPolicyByRef.md)
List the claimsMappingPolicy objects that are assigned to a servicePrincipal.

### [Get-MgServicePrincipalClaimMappingPolicyCount](Get-MgServicePrincipalClaimMappingPolicyCount.md)
Get the number of the resource

### [Get-MgServicePrincipalCount](Get-MgServicePrincipalCount.md)
Get the number of the resource

### [Get-MgServicePrincipalCreatedObject](Get-MgServicePrincipalCreatedObject.md)
Directory objects created by this service principal.
Read-only.
Nullable.

### [Get-MgServicePrincipalCreatedObjectAsServicePrincipal](Get-MgServicePrincipalCreatedObjectAsServicePrincipal.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.servicePrincipal

### [Get-MgServicePrincipalCreatedObjectCount](Get-MgServicePrincipalCreatedObjectCount.md)
Get the number of the resource

### [Get-MgServicePrincipalDelegatedPermissionClassification](Get-MgServicePrincipalDelegatedPermissionClassification.md)
Get delegatedPermissionClassifications from servicePrincipals

### [Get-MgServicePrincipalDelegatedPermissionClassificationCount](Get-MgServicePrincipalDelegatedPermissionClassificationCount.md)
Get the number of the resource

### [Get-MgServicePrincipalDelta](Get-MgServicePrincipalDelta.md)
Invoke function delta

### [Get-MgServicePrincipalEndpoint](Get-MgServicePrincipalEndpoint.md)
Get endpoints from servicePrincipals

### [Get-MgServicePrincipalEndpointCount](Get-MgServicePrincipalEndpointCount.md)
Get the number of the resource

### [Get-MgServicePrincipalHomeRealmDiscoveryPolicy](Get-MgServicePrincipalHomeRealmDiscoveryPolicy.md)
List the homeRealmDiscoveryPolicy objects that are assigned to a servicePrincipal.

### [Get-MgServicePrincipalHomeRealmDiscoveryPolicyByRef](Get-MgServicePrincipalHomeRealmDiscoveryPolicyByRef.md)
List the homeRealmDiscoveryPolicy objects that are assigned to a servicePrincipal.

### [Get-MgServicePrincipalHomeRealmDiscoveryPolicyCount](Get-MgServicePrincipalHomeRealmDiscoveryPolicyCount.md)
Get the number of the resource

### [Get-MgServicePrincipalListCreatedObjectCountAsServicePrincipal](Get-MgServicePrincipalListCreatedObjectCountAsServicePrincipal.md)
Get the number of the resource

### [Get-MgServicePrincipalListMemberOfCountAsAdministrativeUnit](Get-MgServicePrincipalListMemberOfCountAsAdministrativeUnit.md)
Get the number of the resource

### [Get-MgServicePrincipalListMemberOfCountAsGroup](Get-MgServicePrincipalListMemberOfCountAsGroup.md)
Get the number of the resource

### [Get-MgServicePrincipalListOwnedObjectCountAsApplication](Get-MgServicePrincipalListOwnedObjectCountAsApplication.md)
Get the number of the resource

### [Get-MgServicePrincipalListOwnedObjectCountAsAppRoleAssignment](Get-MgServicePrincipalListOwnedObjectCountAsAppRoleAssignment.md)
Get the number of the resource

### [Get-MgServicePrincipalListOwnedObjectCountAsEndpoint](Get-MgServicePrincipalListOwnedObjectCountAsEndpoint.md)
Get the number of the resource

### [Get-MgServicePrincipalListOwnedObjectCountAsGroup](Get-MgServicePrincipalListOwnedObjectCountAsGroup.md)
Get the number of the resource

### [Get-MgServicePrincipalListOwnedObjectCountAsServicePrincipal](Get-MgServicePrincipalListOwnedObjectCountAsServicePrincipal.md)
Get the number of the resource

### [Get-MgServicePrincipalListOwnerCountAsAppRoleAssignment](Get-MgServicePrincipalListOwnerCountAsAppRoleAssignment.md)
Get the number of the resource

### [Get-MgServicePrincipalListOwnerCountAsEndpoint](Get-MgServicePrincipalListOwnerCountAsEndpoint.md)
Get the number of the resource

### [Get-MgServicePrincipalListOwnerCountAsServicePrincipal](Get-MgServicePrincipalListOwnerCountAsServicePrincipal.md)
Get the number of the resource

### [Get-MgServicePrincipalListOwnerCountAsUser](Get-MgServicePrincipalListOwnerCountAsUser.md)
Get the number of the resource

### [Get-MgServicePrincipalListTransitiveMemberOfCountAsAdministrativeUnit](Get-MgServicePrincipalListTransitiveMemberOfCountAsAdministrativeUnit.md)
Get the number of the resource

### [Get-MgServicePrincipalListTransitiveMemberOfCountAsGroup](Get-MgServicePrincipalListTransitiveMemberOfCountAsGroup.md)
Get the number of the resource

### [Get-MgServicePrincipalMemberGroup](Get-MgServicePrincipalMemberGroup.md)
Return all the group IDs for the groups that the specified user, group, service principal, organizational contact, device, or directory object is a member of.
This function is transitive.

### [Get-MgServicePrincipalMemberObject](Get-MgServicePrincipalMemberObject.md)
Return all IDs for the groups, administrative units, and directory roles that a user, group, service principal, organizational contact, device, or directory object is a member of.
This function is transitive.
**Note:** Only users and role-enabled groups can be members of directory roles.

### [Get-MgServicePrincipalMemberOf](Get-MgServicePrincipalMemberOf.md)
Roles that this service principal is a member of.
HTTP Methods: GET Read-only.
Nullable.
Supports $expand.

### [Get-MgServicePrincipalMemberOfAsAdministrativeUnit](Get-MgServicePrincipalMemberOfAsAdministrativeUnit.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.administrativeUnit

### [Get-MgServicePrincipalMemberOfAsGroup](Get-MgServicePrincipalMemberOfAsGroup.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.group

### [Get-MgServicePrincipalMemberOfCount](Get-MgServicePrincipalMemberOfCount.md)
Get the number of the resource

### [Get-MgServicePrincipalOauth2PermissionGrant](Get-MgServicePrincipalOauth2PermissionGrant.md)
Delegated permission grants authorizing this service principal to access an API on behalf of a signed-in user.
Read-only.
Nullable.

### [Get-MgServicePrincipalOauth2PermissionGrantCount](Get-MgServicePrincipalOauth2PermissionGrantCount.md)
Get the number of the resource

### [Get-MgServicePrincipalOwnedObject](Get-MgServicePrincipalOwnedObject.md)
Directory objects that are owned by this service principal.
Read-only.
Nullable.
Supports $expand and $filter (/$count eq 0, /$count ne 0, /$count eq 1, /$count ne 1).

### [Get-MgServicePrincipalOwnedObjectAsApplication](Get-MgServicePrincipalOwnedObjectAsApplication.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.application

### [Get-MgServicePrincipalOwnedObjectAsAppRoleAssignment](Get-MgServicePrincipalOwnedObjectAsAppRoleAssignment.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.appRoleAssignment

### [Get-MgServicePrincipalOwnedObjectAsEndpoint](Get-MgServicePrincipalOwnedObjectAsEndpoint.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.endpoint

### [Get-MgServicePrincipalOwnedObjectAsGroup](Get-MgServicePrincipalOwnedObjectAsGroup.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.group

### [Get-MgServicePrincipalOwnedObjectAsServicePrincipal](Get-MgServicePrincipalOwnedObjectAsServicePrincipal.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.servicePrincipal

### [Get-MgServicePrincipalOwnedObjectCount](Get-MgServicePrincipalOwnedObjectCount.md)
Get the number of the resource

### [Get-MgServicePrincipalOwner](Get-MgServicePrincipalOwner.md)
Directory objects that are owners of this servicePrincipal.
The owners are a set of non-admin users or servicePrincipals who are allowed to modify this object.
Read-only.
Nullable.
Supports $expand and $filter (/$count eq 0, /$count ne 0, /$count eq 1, /$count ne 1).

### [Get-MgServicePrincipalOwnerAsAppRoleAssignment](Get-MgServicePrincipalOwnerAsAppRoleAssignment.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.appRoleAssignment

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

### [Get-MgServicePrincipalOwnerCount](Get-MgServicePrincipalOwnerCount.md)
Get the number of the resource

### [Get-MgServicePrincipalTokenIssuancePolicy](Get-MgServicePrincipalTokenIssuancePolicy.md)
The tokenIssuancePolicies assigned to this service principal.

### [Get-MgServicePrincipalTokenIssuancePolicyCount](Get-MgServicePrincipalTokenIssuancePolicyCount.md)
Get the number of the resource

### [Get-MgServicePrincipalTokenLifetimePolicy](Get-MgServicePrincipalTokenLifetimePolicy.md)
The tokenLifetimePolicies assigned to this service principal.

### [Get-MgServicePrincipalTokenLifetimePolicyCount](Get-MgServicePrincipalTokenLifetimePolicyCount.md)
Get the number of the resource

### [Get-MgServicePrincipalTransitiveMemberOf](Get-MgServicePrincipalTransitiveMemberOf.md)
Get transitiveMemberOf from servicePrincipals

### [Get-MgServicePrincipalTransitiveMemberOfAsAdministrativeUnit](Get-MgServicePrincipalTransitiveMemberOfAsAdministrativeUnit.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.administrativeUnit

### [Get-MgServicePrincipalTransitiveMemberOfAsGroup](Get-MgServicePrincipalTransitiveMemberOfAsGroup.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.group

### [Get-MgServicePrincipalTransitiveMemberOfCount](Get-MgServicePrincipalTransitiveMemberOfCount.md)
Get the number of the resource

### [Get-MgUserAppRoleAssignment](Get-MgUserAppRoleAssignment.md)
Represents the app roles a user has been granted for an application.
Supports $expand.

### [Get-MgUserAppRoleAssignmentCount](Get-MgUserAppRoleAssignmentCount.md)
Get the number of the resource

### [Invoke-MgInstantiateApplicationTemplate](Invoke-MgInstantiateApplicationTemplate.md)
Add an instance of an application from the Azure AD application gallery into your directory.
You can also use this API to instantiate non-gallery apps.
Use the following ID for the **applicationTemplate** object: `8adf8e6e-67b2-4cf2-a259-e3dc5476c621`.

### [New-MgApplication](New-MgApplication.md)
Create a new application object.

### [New-MgApplicationAppManagementPolicyByRef](New-MgApplicationAppManagementPolicyByRef.md)
Assign an appManagementPolicy policy object to an application or service principal object.
The application or service principal adopts this policy over the tenant-wide tenantAppManagementPolicy setting.
Only one policy object can be assigned to an application or service principal.

### [New-MgApplicationExtensionProperty](New-MgApplicationExtensionProperty.md)
Create a new directory extension definition, represented by an extensionProperty object.

### [New-MgApplicationFederatedIdentityCredential](New-MgApplicationFederatedIdentityCredential.md)
Create a new federatedIdentityCredential object for an application.
By configuring a trust relationship between your Azure AD application registration and the identity provider for your compute platform, you can use tokens issued by that platform to authenticate with Microsoft identity platform and call APIs in the Microsoft ecosystem.
Maximum of 20 objects can be added to an application.

### [New-MgApplicationOwnerByRef](New-MgApplicationOwnerByRef.md)
Add an owner to an application by posting to the owners collection.

### [New-MgApplicationTokenIssuancePolicyByRef](New-MgApplicationTokenIssuancePolicyByRef.md)
Assign a tokenIssuancePolicy to an application.

### [New-MgApplicationTokenLifetimePolicyByRef](New-MgApplicationTokenLifetimePolicyByRef.md)
Assign a tokenLifetimePolicy to an application.

### [New-MgGroupAppRoleAssignment](New-MgGroupAppRoleAssignment.md)
Use this API to assign an app role to a security group.
All direct members of the group will be considered assigned.
Security groups with dynamic memberships are supported.
To grant an app role assignment to a group, you need three identifiers: Additional licenses might be required to use a group to manage access to applications.

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
Assign a claimsMappingPolicy to a servicePrincipal.

### [New-MgServicePrincipalDelegatedPermissionClassification](New-MgServicePrincipalDelegatedPermissionClassification.md)
Classify a delegated permission by adding a delegatedPermissionClassification to the servicePrincipal representing the API.

### [New-MgServicePrincipalEndpoint](New-MgServicePrincipalEndpoint.md)
Create new navigation property to endpoints for servicePrincipals

### [New-MgServicePrincipalHomeRealmDiscoveryPolicyByRef](New-MgServicePrincipalHomeRealmDiscoveryPolicyByRef.md)
Assign a homeRealmDiscoveryPolicy to a servicePrincipal.

### [New-MgServicePrincipalOwnerByRef](New-MgServicePrincipalOwnerByRef.md)
Use this API to add an owner for the servicePrincipal.
Service principal owners can be users, the service principal itself, or other service principals.

### [New-MgUserAppRoleAssignment](New-MgUserAppRoleAssignment.md)
Use this API to assign an app role to a user.
To grant an app role assignment to a user, you need three identifiers:

### [Remove-MgApplication](Remove-MgApplication.md)
Delete an application object.
When deleted, apps are moved to a temporary container and can be restored within 30 days.
After that time, they are permanently deleted.

### [Remove-MgApplicationAppManagementPolicyByRef](Remove-MgApplicationAppManagementPolicyByRef.md)
Remove an appManagementPolicy policy object from an application or service principal object.
When you remove the appManagementPolicy, the application or service principal adopts the tenant-wide tenantAppManagementPolicy setting.

### [Remove-MgApplicationExtensionProperty](Remove-MgApplicationExtensionProperty.md)
Delete a directory extension definition represented by an extensionProperty object.
You can delete only directory extensions that aren't synced from on-premises active directory (AD).

### [Remove-MgApplicationFederatedIdentityCredential](Remove-MgApplicationFederatedIdentityCredential.md)
Delete a federatedIdentityCredential object from an application.

### [Remove-MgApplicationKey](Remove-MgApplicationKey.md)
Remove a key credential from an application.
This method along with addKey can be used by an application to automate rolling its expiring keys.
As part of the request validation for this method, a proof of possession of an existing key is verified before the action can be performed.

### [Remove-MgApplicationOwnerByRef](Remove-MgApplicationOwnerByRef.md)
Remove an owner from an application.
As a recommended best practice, apps should have at least two owners.

### [Remove-MgApplicationPassword](Remove-MgApplicationPassword.md)
Remove a password from an application.

### [Remove-MgApplicationTokenIssuancePolicyByRef](Remove-MgApplicationTokenIssuancePolicyByRef.md)
Remove a tokenIssuancePolicy from an application.

### [Remove-MgApplicationTokenLifetimePolicyByRef](Remove-MgApplicationTokenLifetimePolicyByRef.md)
Remove a tokenLifetimePolicy from an application.

### [Remove-MgGroupAppRoleAssignment](Remove-MgGroupAppRoleAssignment.md)
Deletes an appRoleAssignment that a group has been granted.

### [Remove-MgServicePrincipal](Remove-MgServicePrincipal.md)
Delete a servicePrincipal object.

### [Remove-MgServicePrincipalAppManagementPolicy](Remove-MgServicePrincipalAppManagementPolicy.md)
Remove an appManagementPolicy policy object from an application or service principal object.
When you remove the appManagementPolicy, the application or service principal adopts the tenant-wide tenantAppManagementPolicy setting.

### [Remove-MgServicePrincipalAppRoleAssignedTo](Remove-MgServicePrincipalAppRoleAssignedTo.md)
Deletes an appRoleAssignment that a user, group, or client service principal has been granted for a resource service principal.

### [Remove-MgServicePrincipalAppRoleAssignment](Remove-MgServicePrincipalAppRoleAssignment.md)
Deletes an appRoleAssignment that a service principal has been granted.
App roles which are assigned to service principals are also known as application permissions.
Deleting an app role assignment for a service principal is equivalent to revoking the app-only permission grant.

### [Remove-MgServicePrincipalClaimMappingPolicyByRef](Remove-MgServicePrincipalClaimMappingPolicyByRef.md)
Remove a claimsMappingPolicy from a servicePrincipal.

### [Remove-MgServicePrincipalDelegatedPermissionClassification](Remove-MgServicePrincipalDelegatedPermissionClassification.md)
Deletes a delegatedPermissionClassification which had previously been set for a delegated permission.

### [Remove-MgServicePrincipalEndpoint](Remove-MgServicePrincipalEndpoint.md)
Delete navigation property endpoints for servicePrincipals

### [Remove-MgServicePrincipalHomeRealmDiscoveryPolicyByRef](Remove-MgServicePrincipalHomeRealmDiscoveryPolicyByRef.md)
Remove a homeRealmDiscoveryPolicy from a servicePrincipal.

### [Remove-MgServicePrincipalKey](Remove-MgServicePrincipalKey.md)
Remove a key credential from a servicePrincipal.
This method along with addKey can be used by a servicePrincipal to automate rolling its expiring keys.
As part of the request validation for this method, a proof of possession of an existing key is verified before the action can be performed.

### [Remove-MgServicePrincipalOwnerByRef](Remove-MgServicePrincipalOwnerByRef.md)
Remove an owner from a servicePrincipal object.
As a recommended best practice, service principals should have at least two owners.

### [Remove-MgServicePrincipalPassword](Remove-MgServicePrincipalPassword.md)
Remove a password from a servicePrincipal object.

### [Remove-MgUserAppRoleAssignment](Remove-MgUserAppRoleAssignment.md)
Delete an appRoleAssignment that has been granted to a user.

### [Set-MgApplicationLogo](Set-MgApplicationLogo.md)
The main logo for the application.
Not nullable.

### [Set-MgApplicationVerifiedPublisher](Set-MgApplicationVerifiedPublisher.md)
Set the verifiedPublisher on an application.
For more information, including prerequisites to setting a verified publisher, see Publisher verification.

### [Test-MgApplicationProperty](Test-MgApplicationProperty.md)
Validate that a Microsoft 365 group's display name or mail nickname complies with naming policies.
Clients can use this API to determine whether a display name or mail nickname is valid before trying to create a Microsoft 365 group.
To validate the properties of an existing group, use the group: validateProperties function.
The following policy validations are performed for the display name and mail nickname properties:\n1.
Validate the prefix and suffix naming policy\n2.
Validate the custom banned words policy\n3.
Validate that the mail nickname is unique This API only returns the first validation failure that is encountered.
If the properties fail multiple validations, only the first validation failure is returned.
However, you can validate both the mail nickname and the display name and receive a collection of validation errors if you are only validating the prefix and suffix naming policy.
To learn more about configuring naming policies, see Configure naming policy.

### [Test-MgServicePrincipalProperty](Test-MgServicePrincipalProperty.md)
Validate that a Microsoft 365 group's display name or mail nickname complies with naming policies.
Clients can use this API to determine whether a display name or mail nickname is valid before trying to create a Microsoft 365 group.
To validate the properties of an existing group, use the group: validateProperties function.
The following policy validations are performed for the display name and mail nickname properties:\n1.
Validate the prefix and suffix naming policy\n2.
Validate the custom banned words policy\n3.
Validate that the mail nickname is unique This API only returns the first validation failure that is encountered.
If the properties fail multiple validations, only the first validation failure is returned.
However, you can validate both the mail nickname and the display name and receive a collection of validation errors if you are only validating the prefix and suffix naming policy.
To learn more about configuring naming policies, see Configure naming policy.

### [Update-MgApplication](Update-MgApplication.md)
Update the properties of an application object.

### [Update-MgApplicationExtensionProperty](Update-MgApplicationExtensionProperty.md)
Update the navigation property extensionProperties in applications

### [Update-MgApplicationFederatedIdentityCredential](Update-MgApplicationFederatedIdentityCredential.md)
Update the properties of a federatedIdentityCredential object.

### [Update-MgGroupAppRoleAssignment](Update-MgGroupAppRoleAssignment.md)
Update the navigation property appRoleAssignments in groups

### [Update-MgServicePrincipal](Update-MgServicePrincipal.md)
Update entity in servicePrincipals

### [Update-MgServicePrincipalAppRoleAssignedTo](Update-MgServicePrincipalAppRoleAssignedTo.md)
Update the navigation property appRoleAssignedTo in servicePrincipals

### [Update-MgServicePrincipalAppRoleAssignment](Update-MgServicePrincipalAppRoleAssignment.md)
Update the navigation property appRoleAssignments in servicePrincipals

### [Update-MgServicePrincipalDelegatedPermissionClassification](Update-MgServicePrincipalDelegatedPermissionClassification.md)
Update the navigation property delegatedPermissionClassifications in servicePrincipals

### [Update-MgServicePrincipalEndpoint](Update-MgServicePrincipalEndpoint.md)
Update the navigation property endpoints in servicePrincipals

### [Update-MgUserAppRoleAssignment](Update-MgUserAppRoleAssignment.md)
Update the navigation property appRoleAssignments in users

