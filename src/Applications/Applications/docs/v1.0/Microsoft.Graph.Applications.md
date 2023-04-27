---
Module Name: Microsoft.Graph.Applications
Module Guid: 607715e4-962b-4c64-9742-f8ea277f7e45
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

### [Add-MgServicePrincipalKey](Add-MgServicePrincipalKey.md)
Invoke action addKey

### [Add-MgServicePrincipalPassword](Add-MgServicePrincipalPassword.md)
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

### [Get-MgApplication](Get-MgApplication.md)
Get the properties and relationships of an application object.

### [Get-MgApplicationAppManagementPolicy](Get-MgApplicationAppManagementPolicy.md)
The appManagementPolicy applied to this application.

### [Get-MgApplicationAppManagementPolicyByRef](Get-MgApplicationAppManagementPolicyByRef.md)
The appManagementPolicy applied to this application.

### [Get-MgApplicationById](Get-MgApplicationById.md)
Invoke action getByIds

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

### [Get-MgApplicationTemplate](Get-MgApplicationTemplate.md)
Retrieve the properties of an applicationTemplate object.

### [Get-MgApplicationTokenIssuancePolicy](Get-MgApplicationTokenIssuancePolicy.md)
Get tokenIssuancePolicies from applications

### [Get-MgApplicationTokenIssuancePolicyByRef](Get-MgApplicationTokenIssuancePolicyByRef.md)
Get ref of tokenIssuancePolicies from applications

### [Get-MgApplicationTokenLifetimePolicy](Get-MgApplicationTokenLifetimePolicy.md)
Get tokenLifetimePolicies from applications

### [Get-MgApplicationTokenLifetimePolicyByRef](Get-MgApplicationTokenLifetimePolicyByRef.md)
Get ref of tokenLifetimePolicies from applications

### [Get-MgGroupAppRoleAssignment](Get-MgGroupAppRoleAssignment.md)
Represents the app roles a group has been granted for an application.
Supports $expand.

### [Get-MgServicePrincipal](Get-MgServicePrincipal.md)
Retrieve the properties and relationships of a servicePrincipal object.

### [Get-MgServicePrincipalAppManagementPolicy](Get-MgServicePrincipalAppManagementPolicy.md)
The appManagementPolicy applied to this application.

### [Get-MgServicePrincipalAppRoleAssignedTo](Get-MgServicePrincipalAppRoleAssignedTo.md)
App role assignments for this app or service, granted to users, groups, and other service principals.
Supports $expand.

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
Get delegatedPermissionClassifications from servicePrincipals

### [Get-MgServicePrincipalDelta](Get-MgServicePrincipalDelta.md)
Invoke function delta

### [Get-MgServicePrincipalEndpoint](Get-MgServicePrincipalEndpoint.md)
Get endpoints from servicePrincipals

### [Get-MgServicePrincipalHomeRealmDiscoveryPolicy](Get-MgServicePrincipalHomeRealmDiscoveryPolicy.md)
The homeRealmDiscoveryPolicies assigned to this service principal.
Supports $expand.

### [Get-MgServicePrincipalHomeRealmDiscoveryPolicyByRef](Get-MgServicePrincipalHomeRealmDiscoveryPolicyByRef.md)
The homeRealmDiscoveryPolicies assigned to this service principal.
Supports $expand.

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

### [Get-MgServicePrincipalOwnedObjectAsAppRoleAssignment](Get-MgServicePrincipalOwnedObjectAsAppRoleAssignment.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.appRoleAssignment

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

### [Get-MgServicePrincipalTokenIssuancePolicy](Get-MgServicePrincipalTokenIssuancePolicy.md)
The tokenIssuancePolicies assigned to this service principal.

### [Get-MgServicePrincipalTokenLifetimePolicy](Get-MgServicePrincipalTokenLifetimePolicy.md)
The tokenLifetimePolicies assigned to this service principal.

### [Get-MgServicePrincipalTransitiveMemberOf](Get-MgServicePrincipalTransitiveMemberOf.md)
Get transitiveMemberOf from servicePrincipals

### [Get-MgServicePrincipalTransitiveMemberOfAsAdministrativeUnit](Get-MgServicePrincipalTransitiveMemberOfAsAdministrativeUnit.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.administrativeUnit

### [Get-MgServicePrincipalTransitiveMemberOfAsGroup](Get-MgServicePrincipalTransitiveMemberOfAsGroup.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.group

### [Get-MgUserAppRoleAssignment](Get-MgUserAppRoleAssignment.md)
Represents the app roles a user has been granted for an application.
Supports $expand.

### [Invoke-MgInstantiateApplicationTemplate](Invoke-MgInstantiateApplicationTemplate.md)
Invoke action instantiate

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

### [New-MgApplicationTokenIssuancePolicyByRef](New-MgApplicationTokenIssuancePolicyByRef.md)
Create new navigation property ref to tokenIssuancePolicies for applications

### [New-MgApplicationTokenLifetimePolicyByRef](New-MgApplicationTokenLifetimePolicyByRef.md)
Create new navigation property ref to tokenLifetimePolicies for applications

### [New-MgGroupAppRoleAssignment](New-MgGroupAppRoleAssignment.md)
Create new navigation property to appRoleAssignments for groups

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

### [New-MgServicePrincipalOwnerByRef](New-MgServicePrincipalOwnerByRef.md)
Create new navigation property ref to owners for servicePrincipals

### [New-MgUserAppRoleAssignment](New-MgUserAppRoleAssignment.md)
Create new navigation property to appRoleAssignments for users

### [Remove-MgApplication](Remove-MgApplication.md)
Delete an application object.
When deleted, apps are moved to a temporary container and can be restored within 30 days.
After that time, they are permanently deleted.

### [Remove-MgApplicationAppManagementPolicyByRef](Remove-MgApplicationAppManagementPolicyByRef.md)
Delete ref of navigation property appManagementPolicies for applications

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

### [Remove-MgApplicationTokenIssuancePolicyByRef](Remove-MgApplicationTokenIssuancePolicyByRef.md)
Delete ref of navigation property tokenIssuancePolicies for applications

### [Remove-MgApplicationTokenLifetimePolicyByRef](Remove-MgApplicationTokenLifetimePolicyByRef.md)
Delete ref of navigation property tokenLifetimePolicies for applications

### [Remove-MgGroupAppRoleAssignment](Remove-MgGroupAppRoleAssignment.md)
Delete navigation property appRoleAssignments for groups

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

### [Remove-MgServicePrincipalKey](Remove-MgServicePrincipalKey.md)
Invoke action removeKey

### [Remove-MgServicePrincipalOwnerByRef](Remove-MgServicePrincipalOwnerByRef.md)
Delete ref of navigation property owners for servicePrincipals

### [Remove-MgServicePrincipalPassword](Remove-MgServicePrincipalPassword.md)
Invoke action removePassword

### [Remove-MgUserAppRoleAssignment](Remove-MgUserAppRoleAssignment.md)
Delete navigation property appRoleAssignments for users

### [Set-MgApplicationLogo](Set-MgApplicationLogo.md)
The main logo for the application.
Not nullable.

### [Set-MgApplicationVerifiedPublisher](Set-MgApplicationVerifiedPublisher.md)
Invoke action setVerifiedPublisher

### [Test-MgApplicationProperty](Test-MgApplicationProperty.md)
Invoke action validateProperties

### [Test-MgServicePrincipalProperty](Test-MgServicePrincipalProperty.md)
Invoke action validateProperties

### [Update-MgApplication](Update-MgApplication.md)
Update the properties of an application object.

### [Update-MgApplicationExtensionProperty](Update-MgApplicationExtensionProperty.md)
Update the navigation property extensionProperties in applications

### [Update-MgApplicationFederatedIdentityCredential](Update-MgApplicationFederatedIdentityCredential.md)
Update the navigation property federatedIdentityCredentials in applications

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

