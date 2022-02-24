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

### [Add-MgServicePrincipalKey](Add-MgServicePrincipalKey.md)
Invoke action addKey

### [Add-MgServicePrincipalPassword](Add-MgServicePrincipalPassword.md)
Invoke action addPassword

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
Get entity from applications by key

### [Get-MgApplicationById](Get-MgApplicationById.md)
Invoke action getByIds

### [Get-MgApplicationCreatedOnBehalfOf](Get-MgApplicationCreatedOnBehalfOf.md)
Read-only.

### [Get-MgApplicationCreatedOnBehalfOfByRef](Get-MgApplicationCreatedOnBehalfOfByRef.md)
Read-only.

### [Get-MgApplicationDelta](Get-MgApplicationDelta.md)
Invoke function delta

### [Get-MgApplicationExtensionProperty](Get-MgApplicationExtensionProperty.md)
Read-only.
Nullable.

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

### [Get-MgGroupAppRoleAssignment](Get-MgGroupAppRoleAssignment.md)
Represents the app roles a group has been granted for an application.
Supports $expand.

### [Get-MgServicePrincipal](Get-MgServicePrincipal.md)
Get entity from servicePrincipals by key

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

### [Get-MgUserAppRoleAssignment](Get-MgUserAppRoleAssignment.md)
Represents the app roles a user has been granted for an application.
Supports $expand.

### [Invoke-MgInstantiateApplicationTemplate](Invoke-MgInstantiateApplicationTemplate.md)
Invoke action instantiate

### [New-MgApplication](New-MgApplication.md)
Add new entity to applications

### [New-MgApplicationExtensionProperty](New-MgApplicationExtensionProperty.md)
Read-only.
Nullable.

### [New-MgApplicationHomeRealmDiscoveryPolicyByRef](New-MgApplicationHomeRealmDiscoveryPolicyByRef.md)
Create new navigation property ref to homeRealmDiscoveryPolicies for applications

### [New-MgApplicationOwnerByRef](New-MgApplicationOwnerByRef.md)
Directory objects that are owners of the application.
Read-only.
Nullable.
Supports $expand.

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

### [New-MgServicePrincipal](New-MgServicePrincipal.md)
Add new entity to servicePrincipals

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

### [New-MgServicePrincipalHomeRealmDiscoveryPolicyByRef](New-MgServicePrincipalHomeRealmDiscoveryPolicyByRef.md)
The homeRealmDiscoveryPolicies assigned to this service principal.
Supports $expand.

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

### [Remove-MgApplication](Remove-MgApplication.md)
Delete entity from applications

### [Remove-MgApplicationCreatedOnBehalfOfByRef](Remove-MgApplicationCreatedOnBehalfOfByRef.md)
Read-only.

### [Remove-MgApplicationExtensionProperty](Remove-MgApplicationExtensionProperty.md)
Read-only.
Nullable.

### [Remove-MgApplicationKey](Remove-MgApplicationKey.md)
Invoke action removeKey

### [Remove-MgApplicationPassword](Remove-MgApplicationPassword.md)
Invoke action removePassword

### [Remove-MgApplicationTemplate](Remove-MgApplicationTemplate.md)
Delete entity from applicationTemplates

### [Remove-MgGroupAppRoleAssignment](Remove-MgGroupAppRoleAssignment.md)
Represents the app roles a group has been granted for an application.
Supports $expand.

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

### [Remove-MgServicePrincipalKey](Remove-MgServicePrincipalKey.md)
Invoke action removeKey

### [Remove-MgServicePrincipalPassword](Remove-MgServicePrincipalPassword.md)
Invoke action removePassword

### [Remove-MgUserAppRoleAssignment](Remove-MgUserAppRoleAssignment.md)
Represents the app roles a user has been granted for an application.
Supports $expand.

### [Restore-MgApplication](Restore-MgApplication.md)
Invoke action restore

### [Restore-MgServicePrincipal](Restore-MgServicePrincipal.md)
Invoke action restore

### [Set-MgApplicationCreatedOnBehalfOfByRef](Set-MgApplicationCreatedOnBehalfOfByRef.md)
Read-only.

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
Update entity in applications

### [Update-MgApplicationExtensionProperty](Update-MgApplicationExtensionProperty.md)
Read-only.
Nullable.

### [Update-MgApplicationTemplate](Update-MgApplicationTemplate.md)
Update entity in applicationTemplates

### [Update-MgGroupAppRoleAssignment](Update-MgGroupAppRoleAssignment.md)
Represents the app roles a group has been granted for an application.
Supports $expand.

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

### [Update-MgUserAppRoleAssignment](Update-MgUserAppRoleAssignment.md)
Represents the app roles a user has been granted for an application.
Supports $expand.

