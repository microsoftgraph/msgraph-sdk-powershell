---
Module Name: Microsoft.Graph.Identity.DirectoryManagement
Module Guid: 384ce8c5-9a5b-42de-886a-e51449397f4b
Download Help Link: https://learn.microsoft.com/powershell/module/microsoft.graph.identity.directorymanagement
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Identity.DirectoryManagement Module
## Description
Microsoft Graph PowerShell Cmdlets

## Microsoft.Graph.Identity.DirectoryManagement Cmdlets
### [Confirm-MgContactMemberGroup](Confirm-MgContactMemberGroup.md)
Check for membership in a specified list of group IDs, and return from that list those groups (identified by IDs) of which the specified user, group, service principal, organizational contact, device, or directory object is a member.
This function is transitive.
You can check up to a maximum of 20 groups per request.
This function supports all groups provisioned in Azure AD.
Because Microsoft 365 groups cannot contain other groups, membership in a Microsoft 365 group is always direct.

### [Confirm-MgContactMemberObject](Confirm-MgContactMemberObject.md)
Invoke action checkMemberObjects

### [Confirm-MgContractMemberGroup](Confirm-MgContractMemberGroup.md)
Check for membership in a specified list of group IDs, and return from that list those groups (identified by IDs) of which the specified user, group, service principal, organizational contact, device, or directory object is a member.
This function is transitive.
You can check up to a maximum of 20 groups per request.
This function supports all groups provisioned in Azure AD.
Because Microsoft 365 groups cannot contain other groups, membership in a Microsoft 365 group is always direct.

### [Confirm-MgContractMemberObject](Confirm-MgContractMemberObject.md)
Invoke action checkMemberObjects

### [Confirm-MgDeviceMemberGroup](Confirm-MgDeviceMemberGroup.md)
Check for membership in a specified list of group IDs, and return from that list those groups (identified by IDs) of which the specified user, group, service principal, organizational contact, device, or directory object is a member.
This function is transitive.
You can check up to a maximum of 20 groups per request.
This function supports all groups provisioned in Azure AD.
Because Microsoft 365 groups cannot contain other groups, membership in a Microsoft 365 group is always direct.

### [Confirm-MgDeviceMemberObject](Confirm-MgDeviceMemberObject.md)
Invoke action checkMemberObjects

### [Confirm-MgDirectoryDeletedItemMemberGroup](Confirm-MgDirectoryDeletedItemMemberGroup.md)
Check for membership in a specified list of group IDs, and return from that list those groups (identified by IDs) of which the specified user, group, service principal, organizational contact, device, or directory object is a member.
This function is transitive.
You can check up to a maximum of 20 groups per request.
This function supports all groups provisioned in Azure AD.
Because Microsoft 365 groups cannot contain other groups, membership in a Microsoft 365 group is always direct.

### [Confirm-MgDirectoryDeletedItemMemberObject](Confirm-MgDirectoryDeletedItemMemberObject.md)
Invoke action checkMemberObjects

### [Confirm-MgDirectoryRoleMemberGroup](Confirm-MgDirectoryRoleMemberGroup.md)
Check for membership in a specified list of group IDs, and return from that list those groups (identified by IDs) of which the specified user, group, service principal, organizational contact, device, or directory object is a member.
This function is transitive.
You can check up to a maximum of 20 groups per request.
This function supports all groups provisioned in Azure AD.
Because Microsoft 365 groups cannot contain other groups, membership in a Microsoft 365 group is always direct.

### [Confirm-MgDirectoryRoleMemberObject](Confirm-MgDirectoryRoleMemberObject.md)
Invoke action checkMemberObjects

### [Confirm-MgDirectoryRoleTemplateMemberGroup](Confirm-MgDirectoryRoleTemplateMemberGroup.md)
Check for membership in a specified list of group IDs, and return from that list those groups (identified by IDs) of which the specified user, group, service principal, organizational contact, device, or directory object is a member.
This function is transitive.
You can check up to a maximum of 20 groups per request.
This function supports all groups provisioned in Azure AD.
Because Microsoft 365 groups cannot contain other groups, membership in a Microsoft 365 group is always direct.

### [Confirm-MgDirectoryRoleTemplateMemberObject](Confirm-MgDirectoryRoleTemplateMemberObject.md)
Invoke action checkMemberObjects

### [Confirm-MgDomain](Confirm-MgDomain.md)
Validates the ownership of the domain.

### [Confirm-MgOrganizationMemberGroup](Confirm-MgOrganizationMemberGroup.md)
Check for membership in a specified list of group IDs, and return from that list those groups (identified by IDs) of which the specified user, group, service principal, organizational contact, device, or directory object is a member.
This function is transitive.
You can check up to a maximum of 20 groups per request.
This function supports all groups provisioned in Azure AD.
Because Microsoft 365 groups cannot contain other groups, membership in a Microsoft 365 group is always direct.

### [Confirm-MgOrganizationMemberObject](Confirm-MgOrganizationMemberObject.md)
Invoke action checkMemberObjects

### [Get-MgContact](Get-MgContact.md)
Get the properties and relationships of an organizational contact.

### [Get-MgContactById](Get-MgContactById.md)
Return the directory objects specified in a list of IDs.
Only a subset of user properties are returned by default in v1.0.
Some common uses for this function are to:

### [Get-MgContactCount](Get-MgContactCount.md)
Get the number of the resource

### [Get-MgContactDelta](Get-MgContactDelta.md)
Invoke function delta

### [Get-MgContactDirectReport](Get-MgContactDirectReport.md)
The contact's direct reports.
(The users and contacts that have their manager property set to this contact.)  Read-only.
Nullable.
Supports $expand.

### [Get-MgContactDirectReportAsOrgContact](Get-MgContactDirectReportAsOrgContact.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.orgContact

### [Get-MgContactDirectReportAsUser](Get-MgContactDirectReportAsUser.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.user

### [Get-MgContactDirectReportCount](Get-MgContactDirectReportCount.md)
Get the number of the resource

### [Get-MgContactDirectReportCountAsOrgContact](Get-MgContactDirectReportCountAsOrgContact.md)
Get the number of the resource

### [Get-MgContactDirectReportCountAsUser](Get-MgContactDirectReportCountAsUser.md)
Get the number of the resource

### [Get-MgContactManager](Get-MgContactManager.md)
Get this organizational contact's manager.

### [Get-MgContactMemberGroup](Get-MgContactMemberGroup.md)
Return all the group IDs for the groups that the specified user, group, service principal, organizational contact, device, or directory object is a member of.
This function is transitive.

### [Get-MgContactMemberObject](Get-MgContactMemberObject.md)
Return all IDs for the groups, administrative units, and directory roles that a user, group, service principal, organizational contact, device, or directory object is a member of.
This function is transitive.
Note: Only users and role-enabled groups can be members of directory roles.

### [Get-MgContactMemberOf](Get-MgContactMemberOf.md)
Groups that this contact is a member of.
Read-only.
Nullable.
Supports $expand.

### [Get-MgContactMemberOfAsAdministrativeUnit](Get-MgContactMemberOfAsAdministrativeUnit.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.administrativeUnit

### [Get-MgContactMemberOfAsGroup](Get-MgContactMemberOfAsGroup.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.group

### [Get-MgContactMemberOfCount](Get-MgContactMemberOfCount.md)
Get the number of the resource

### [Get-MgContactMemberOfCountAsAdministrativeUnit](Get-MgContactMemberOfCountAsAdministrativeUnit.md)
Get the number of the resource

### [Get-MgContactMemberOfCountAsGroup](Get-MgContactMemberOfCountAsGroup.md)
Get the number of the resource

### [Get-MgContactTransitiveMemberOf](Get-MgContactTransitiveMemberOf.md)
Groups that this contact is a member of, including groups that the contact is nested under.
Read-only.
Nullable.

### [Get-MgContactTransitiveMemberOfAsAdministrativeUnit](Get-MgContactTransitiveMemberOfAsAdministrativeUnit.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.administrativeUnit

### [Get-MgContactTransitiveMemberOfAsGroup](Get-MgContactTransitiveMemberOfAsGroup.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.group

### [Get-MgContactTransitiveMemberOfCount](Get-MgContactTransitiveMemberOfCount.md)
Get the number of the resource

### [Get-MgContactTransitiveMemberOfCountAsAdministrativeUnit](Get-MgContactTransitiveMemberOfCountAsAdministrativeUnit.md)
Get the number of the resource

### [Get-MgContactTransitiveMemberOfCountAsGroup](Get-MgContactTransitiveMemberOfCountAsGroup.md)
Get the number of the resource

### [Get-MgContract](Get-MgContract.md)
Retrieve the properties and relationships of contract object.

### [Get-MgContractById](Get-MgContractById.md)
Return the directory objects specified in a list of IDs.
Only a subset of user properties are returned by default in v1.0.
Some common uses for this function are to:

### [Get-MgContractCount](Get-MgContractCount.md)
Get the number of the resource

### [Get-MgContractDelta](Get-MgContractDelta.md)
Invoke function delta

### [Get-MgContractMemberGroup](Get-MgContractMemberGroup.md)
Return all the group IDs for the groups that the specified user, group, service principal, organizational contact, device, or directory object is a member of.
This function is transitive.

### [Get-MgContractMemberObject](Get-MgContractMemberObject.md)
Return all IDs for the groups, administrative units, and directory roles that a user, group, service principal, organizational contact, device, or directory object is a member of.
This function is transitive.
Note: Only users and role-enabled groups can be members of directory roles.

### [Get-MgDevice](Get-MgDevice.md)
Get the properties and relationships of a device object.

### [Get-MgDeviceByDeviceId](Get-MgDeviceByDeviceId.md)
Get the properties and relationships of a device object.

### [Get-MgDeviceById](Get-MgDeviceById.md)
Return the directory objects specified in a list of IDs.
Only a subset of user properties are returned by default in v1.0.
Some common uses for this function are to:

### [Get-MgDeviceCount](Get-MgDeviceCount.md)
Get the number of the resource

### [Get-MgDeviceDelta](Get-MgDeviceDelta.md)
Invoke function delta

### [Get-MgDeviceExtension](Get-MgDeviceExtension.md)
The collection of open extensions defined for the device.
Read-only.
Nullable.

### [Get-MgDeviceExtensionCount](Get-MgDeviceExtensionCount.md)
Get the number of the resource

### [Get-MgDeviceMemberGroup](Get-MgDeviceMemberGroup.md)
Return all the group IDs for the groups that the specified user, group, service principal, organizational contact, device, or directory object is a member of.
This function is transitive.

### [Get-MgDeviceMemberObject](Get-MgDeviceMemberObject.md)
Return all IDs for the groups, administrative units, and directory roles that a user, group, service principal, organizational contact, device, or directory object is a member of.
This function is transitive.
Note: Only users and role-enabled groups can be members of directory roles.

### [Get-MgDeviceMemberOf](Get-MgDeviceMemberOf.md)
Groups and administrative units that this device is a member of.
Read-only.
Nullable.
Supports $expand.

### [Get-MgDeviceMemberOfAsAdministrativeUnit](Get-MgDeviceMemberOfAsAdministrativeUnit.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.administrativeUnit

### [Get-MgDeviceMemberOfAsGroup](Get-MgDeviceMemberOfAsGroup.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.group

### [Get-MgDeviceMemberOfCount](Get-MgDeviceMemberOfCount.md)
Get the number of the resource

### [Get-MgDeviceMemberOfCountAsAdministrativeUnit](Get-MgDeviceMemberOfCountAsAdministrativeUnit.md)
Get the number of the resource

### [Get-MgDeviceMemberOfCountAsGroup](Get-MgDeviceMemberOfCountAsGroup.md)
Get the number of the resource

### [Get-MgDeviceRegisteredOwner](Get-MgDeviceRegisteredOwner.md)
The user that cloud joined the device or registered their personal device.
The registered owner is set at the time of registration.
Read-only.
Nullable.
Supports $expand.

### [Get-MgDeviceRegisteredOwnerAsAppRoleAssignment](Get-MgDeviceRegisteredOwnerAsAppRoleAssignment.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.appRoleAssignment

### [Get-MgDeviceRegisteredOwnerAsEndpoint](Get-MgDeviceRegisteredOwnerAsEndpoint.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.endpoint

### [Get-MgDeviceRegisteredOwnerAsServicePrincipal](Get-MgDeviceRegisteredOwnerAsServicePrincipal.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.servicePrincipal

### [Get-MgDeviceRegisteredOwnerAsUser](Get-MgDeviceRegisteredOwnerAsUser.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.user

### [Get-MgDeviceRegisteredOwnerByRef](Get-MgDeviceRegisteredOwnerByRef.md)
The user that cloud joined the device or registered their personal device.
The registered owner is set at the time of registration.
Read-only.
Nullable.
Supports $expand.

### [Get-MgDeviceRegisteredOwnerCount](Get-MgDeviceRegisteredOwnerCount.md)
Get the number of the resource

### [Get-MgDeviceRegisteredOwnerCountAsAppRoleAssignment](Get-MgDeviceRegisteredOwnerCountAsAppRoleAssignment.md)
Get the number of the resource

### [Get-MgDeviceRegisteredOwnerCountAsEndpoint](Get-MgDeviceRegisteredOwnerCountAsEndpoint.md)
Get the number of the resource

### [Get-MgDeviceRegisteredOwnerCountAsServicePrincipal](Get-MgDeviceRegisteredOwnerCountAsServicePrincipal.md)
Get the number of the resource

### [Get-MgDeviceRegisteredOwnerCountAsUser](Get-MgDeviceRegisteredOwnerCountAsUser.md)
Get the number of the resource

### [Get-MgDeviceRegisteredUser](Get-MgDeviceRegisteredUser.md)
Collection of registered users of the device.
For cloud joined devices and registered personal devices, registered users are set to the same value as registered owners at the time of registration.
Read-only.
Nullable.
Supports $expand.

### [Get-MgDeviceRegisteredUserAsAppRoleAssignment](Get-MgDeviceRegisteredUserAsAppRoleAssignment.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.appRoleAssignment

### [Get-MgDeviceRegisteredUserAsEndpoint](Get-MgDeviceRegisteredUserAsEndpoint.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.endpoint

### [Get-MgDeviceRegisteredUserAsServicePrincipal](Get-MgDeviceRegisteredUserAsServicePrincipal.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.servicePrincipal

### [Get-MgDeviceRegisteredUserAsUser](Get-MgDeviceRegisteredUserAsUser.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.user

### [Get-MgDeviceRegisteredUserByRef](Get-MgDeviceRegisteredUserByRef.md)
Collection of registered users of the device.
For cloud joined devices and registered personal devices, registered users are set to the same value as registered owners at the time of registration.
Read-only.
Nullable.
Supports $expand.

### [Get-MgDeviceRegisteredUserCount](Get-MgDeviceRegisteredUserCount.md)
Get the number of the resource

### [Get-MgDeviceRegisteredUserCountAsAppRoleAssignment](Get-MgDeviceRegisteredUserCountAsAppRoleAssignment.md)
Get the number of the resource

### [Get-MgDeviceRegisteredUserCountAsEndpoint](Get-MgDeviceRegisteredUserCountAsEndpoint.md)
Get the number of the resource

### [Get-MgDeviceRegisteredUserCountAsServicePrincipal](Get-MgDeviceRegisteredUserCountAsServicePrincipal.md)
Get the number of the resource

### [Get-MgDeviceRegisteredUserCountAsUser](Get-MgDeviceRegisteredUserCountAsUser.md)
Get the number of the resource

### [Get-MgDeviceTransitiveMemberOf](Get-MgDeviceTransitiveMemberOf.md)
Groups and administrative units that the device is a member of.
This operation is transitive.
Supports $expand.

### [Get-MgDeviceTransitiveMemberOfAsAdministrativeUnit](Get-MgDeviceTransitiveMemberOfAsAdministrativeUnit.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.administrativeUnit

### [Get-MgDeviceTransitiveMemberOfAsGroup](Get-MgDeviceTransitiveMemberOfAsGroup.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.group

### [Get-MgDeviceTransitiveMemberOfCount](Get-MgDeviceTransitiveMemberOfCount.md)
Get the number of the resource

### [Get-MgDeviceTransitiveMemberOfCountAsAdministrativeUnit](Get-MgDeviceTransitiveMemberOfCountAsAdministrativeUnit.md)
Get the number of the resource

### [Get-MgDeviceTransitiveMemberOfCountAsGroup](Get-MgDeviceTransitiveMemberOfCountAsGroup.md)
Get the number of the resource

### [Get-MgDirectory](Get-MgDirectory.md)
Get directory

### [Get-MgDirectoryAdministrativeUnit](Get-MgDirectoryAdministrativeUnit.md)
Retrieve the properties and relationships of an administrativeUnit object.

### [Get-MgDirectoryAdministrativeUnitCount](Get-MgDirectoryAdministrativeUnitCount.md)
Get the number of the resource

### [Get-MgDirectoryAdministrativeUnitDelta](Get-MgDirectoryAdministrativeUnitDelta.md)
Invoke function delta

### [Get-MgDirectoryAdministrativeUnitExtension](Get-MgDirectoryAdministrativeUnitExtension.md)
The collection of open extensions defined for this administrative unit.
Nullable.

### [Get-MgDirectoryAdministrativeUnitExtensionCount](Get-MgDirectoryAdministrativeUnitExtensionCount.md)
Get the number of the resource

### [Get-MgDirectoryAdministrativeUnitMember](Get-MgDirectoryAdministrativeUnitMember.md)
Users and groups that are members of this administrative unit.
Supports $expand.

### [Get-MgDirectoryAdministrativeUnitMemberAsApplication](Get-MgDirectoryAdministrativeUnitMemberAsApplication.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.application

### [Get-MgDirectoryAdministrativeUnitMemberAsDevice](Get-MgDirectoryAdministrativeUnitMemberAsDevice.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.device

### [Get-MgDirectoryAdministrativeUnitMemberAsGroup](Get-MgDirectoryAdministrativeUnitMemberAsGroup.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.group

### [Get-MgDirectoryAdministrativeUnitMemberAsOrgContact](Get-MgDirectoryAdministrativeUnitMemberAsOrgContact.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.orgContact

### [Get-MgDirectoryAdministrativeUnitMemberAsServicePrincipal](Get-MgDirectoryAdministrativeUnitMemberAsServicePrincipal.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.servicePrincipal

### [Get-MgDirectoryAdministrativeUnitMemberAsUser](Get-MgDirectoryAdministrativeUnitMemberAsUser.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.user

### [Get-MgDirectoryAdministrativeUnitMemberByRef](Get-MgDirectoryAdministrativeUnitMemberByRef.md)
Users and groups that are members of this administrative unit.
Supports $expand.

### [Get-MgDirectoryAdministrativeUnitMemberCount](Get-MgDirectoryAdministrativeUnitMemberCount.md)
Get the number of the resource

### [Get-MgDirectoryAdministrativeUnitMemberCountAsApplication](Get-MgDirectoryAdministrativeUnitMemberCountAsApplication.md)
Get the number of the resource

### [Get-MgDirectoryAdministrativeUnitMemberCountAsDevice](Get-MgDirectoryAdministrativeUnitMemberCountAsDevice.md)
Get the number of the resource

### [Get-MgDirectoryAdministrativeUnitMemberCountAsGroup](Get-MgDirectoryAdministrativeUnitMemberCountAsGroup.md)
Get the number of the resource

### [Get-MgDirectoryAdministrativeUnitMemberCountAsOrgContact](Get-MgDirectoryAdministrativeUnitMemberCountAsOrgContact.md)
Get the number of the resource

### [Get-MgDirectoryAdministrativeUnitMemberCountAsServicePrincipal](Get-MgDirectoryAdministrativeUnitMemberCountAsServicePrincipal.md)
Get the number of the resource

### [Get-MgDirectoryAdministrativeUnitMemberCountAsUser](Get-MgDirectoryAdministrativeUnitMemberCountAsUser.md)
Get the number of the resource

### [Get-MgDirectoryAdministrativeUnitScopedRoleMember](Get-MgDirectoryAdministrativeUnitScopedRoleMember.md)
Get an Azure Active Directory (Azure AD) role assignment with administrative unit scope.

### [Get-MgDirectoryAdministrativeUnitScopedRoleMemberCount](Get-MgDirectoryAdministrativeUnitScopedRoleMemberCount.md)
Get the number of the resource

### [Get-MgDirectoryAttributeSet](Get-MgDirectoryAttributeSet.md)
Read the properties and relationships of an attributeSet object.

### [Get-MgDirectoryAttributeSetCount](Get-MgDirectoryAttributeSetCount.md)
Get the number of the resource

### [Get-MgDirectoryCustomSecurityAttributeDefinition](Get-MgDirectoryCustomSecurityAttributeDefinition.md)
Read the properties and relationships of a customSecurityAttributeDefinition object.

### [Get-MgDirectoryCustomSecurityAttributeDefinitionAllowedValue](Get-MgDirectoryCustomSecurityAttributeDefinitionAllowedValue.md)
Read the properties and relationships of an allowedValue object.

### [Get-MgDirectoryCustomSecurityAttributeDefinitionAllowedValueCount](Get-MgDirectoryCustomSecurityAttributeDefinitionAllowedValueCount.md)
Get the number of the resource

### [Get-MgDirectoryCustomSecurityAttributeDefinitionCount](Get-MgDirectoryCustomSecurityAttributeDefinitionCount.md)
Get the number of the resource

### [Get-MgDirectoryDeletedItem](Get-MgDirectoryDeletedItem.md)
Retrieve the properties of a recently deleted application, group, servicePrincipal, administrative unit, or user object from deleted items.

### [Get-MgDirectoryDeletedItemAsAdministrativeUnit](Get-MgDirectoryDeletedItemAsAdministrativeUnit.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.administrativeUnit

### [Get-MgDirectoryDeletedItemAsApplication](Get-MgDirectoryDeletedItemAsApplication.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.application

### [Get-MgDirectoryDeletedItemAsDevice](Get-MgDirectoryDeletedItemAsDevice.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.device

### [Get-MgDirectoryDeletedItemAsGroup](Get-MgDirectoryDeletedItemAsGroup.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.group

### [Get-MgDirectoryDeletedItemAsServicePrincipal](Get-MgDirectoryDeletedItemAsServicePrincipal.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.servicePrincipal

### [Get-MgDirectoryDeletedItemAsUser](Get-MgDirectoryDeletedItemAsUser.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.user

### [Get-MgDirectoryDeletedItemById](Get-MgDirectoryDeletedItemById.md)
Return the directory objects specified in a list of IDs.
Only a subset of user properties are returned by default in v1.0.
Some common uses for this function are to:

### [Get-MgDirectoryDeletedItemCountAsAdministrativeUnit](Get-MgDirectoryDeletedItemCountAsAdministrativeUnit.md)
Get the number of the resource

### [Get-MgDirectoryDeletedItemCountAsApplication](Get-MgDirectoryDeletedItemCountAsApplication.md)
Get the number of the resource

### [Get-MgDirectoryDeletedItemCountAsDevice](Get-MgDirectoryDeletedItemCountAsDevice.md)
Get the number of the resource

### [Get-MgDirectoryDeletedItemCountAsGroup](Get-MgDirectoryDeletedItemCountAsGroup.md)
Get the number of the resource

### [Get-MgDirectoryDeletedItemCountAsServicePrincipal](Get-MgDirectoryDeletedItemCountAsServicePrincipal.md)
Get the number of the resource

### [Get-MgDirectoryDeletedItemCountAsUser](Get-MgDirectoryDeletedItemCountAsUser.md)
Get the number of the resource

### [Get-MgDirectoryDeletedItemMemberGroup](Get-MgDirectoryDeletedItemMemberGroup.md)
Return all the group IDs for the groups that the specified user, group, service principal, organizational contact, device, or directory object is a member of.
This function is transitive.

### [Get-MgDirectoryDeletedItemMemberObject](Get-MgDirectoryDeletedItemMemberObject.md)
Return all IDs for the groups, administrative units, and directory roles that a user, group, service principal, organizational contact, device, or directory object is a member of.
This function is transitive.
Note: Only users and role-enabled groups can be members of directory roles.

### [Get-MgDirectoryFederationConfiguration](Get-MgDirectoryFederationConfiguration.md)
Configure domain federation with organizations whose identity provider (IdP) supports either the SAML or WS-Fed protocol.

### [Get-MgDirectoryFederationConfigurationCount](Get-MgDirectoryFederationConfigurationCount.md)
Get the number of the resource

### [Get-MgDirectoryOnPremiseSynchronization](Get-MgDirectoryOnPremiseSynchronization.md)
Read the properties and relationships of an onPremisesDirectorySynchronization object.

### [Get-MgDirectoryOnPremiseSynchronizationCount](Get-MgDirectoryOnPremiseSynchronizationCount.md)
Get the number of the resource

### [Get-MgDirectoryRole](Get-MgDirectoryRole.md)
Retrieve the properties of a directoryRole object.
The role must be activated in tenant for a successful response.
You can use both the object ID and template ID of the directoryRole with this API.
The template ID of a built-in role is immutable and can be seen in the role description on the Azure portal.
For details, see Role template IDs.

### [Get-MgDirectoryRoleById](Get-MgDirectoryRoleById.md)
Return the directory objects specified in a list of IDs.
Only a subset of user properties are returned by default in v1.0.
Some common uses for this function are to:

### [Get-MgDirectoryRoleByRoleTemplateId](Get-MgDirectoryRoleByRoleTemplateId.md)
Retrieve the properties of a directoryRole object.
The role must be activated in tenant for a successful response.
You can use both the object ID and template ID of the directoryRole with this API.
The template ID of a built-in role is immutable and can be seen in the role description on the Azure portal.
For details, see Role template IDs.

### [Get-MgDirectoryRoleCount](Get-MgDirectoryRoleCount.md)
Get the number of the resource

### [Get-MgDirectoryRoleDelta](Get-MgDirectoryRoleDelta.md)
Invoke function delta

### [Get-MgDirectoryRoleMember](Get-MgDirectoryRoleMember.md)
Users that are members of this directory role.
HTTP Methods: GET, POST, DELETE.
Read-only.
Nullable.
Supports $expand.

### [Get-MgDirectoryRoleMemberAsApplication](Get-MgDirectoryRoleMemberAsApplication.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.application

### [Get-MgDirectoryRoleMemberAsDevice](Get-MgDirectoryRoleMemberAsDevice.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.device

### [Get-MgDirectoryRoleMemberAsGroup](Get-MgDirectoryRoleMemberAsGroup.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.group

### [Get-MgDirectoryRoleMemberAsOrgContact](Get-MgDirectoryRoleMemberAsOrgContact.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.orgContact

### [Get-MgDirectoryRoleMemberAsServicePrincipal](Get-MgDirectoryRoleMemberAsServicePrincipal.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.servicePrincipal

### [Get-MgDirectoryRoleMemberAsUser](Get-MgDirectoryRoleMemberAsUser.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.user

### [Get-MgDirectoryRoleMemberByRef](Get-MgDirectoryRoleMemberByRef.md)
Users that are members of this directory role.
HTTP Methods: GET, POST, DELETE.
Read-only.
Nullable.
Supports $expand.

### [Get-MgDirectoryRoleMemberCount](Get-MgDirectoryRoleMemberCount.md)
Get the number of the resource

### [Get-MgDirectoryRoleMemberCountAsApplication](Get-MgDirectoryRoleMemberCountAsApplication.md)
Get the number of the resource

### [Get-MgDirectoryRoleMemberCountAsDevice](Get-MgDirectoryRoleMemberCountAsDevice.md)
Get the number of the resource

### [Get-MgDirectoryRoleMemberCountAsGroup](Get-MgDirectoryRoleMemberCountAsGroup.md)
Get the number of the resource

### [Get-MgDirectoryRoleMemberCountAsOrgContact](Get-MgDirectoryRoleMemberCountAsOrgContact.md)
Get the number of the resource

### [Get-MgDirectoryRoleMemberCountAsServicePrincipal](Get-MgDirectoryRoleMemberCountAsServicePrincipal.md)
Get the number of the resource

### [Get-MgDirectoryRoleMemberCountAsUser](Get-MgDirectoryRoleMemberCountAsUser.md)
Get the number of the resource

### [Get-MgDirectoryRoleMemberGroup](Get-MgDirectoryRoleMemberGroup.md)
Return all the group IDs for the groups that the specified user, group, service principal, organizational contact, device, or directory object is a member of.
This function is transitive.

### [Get-MgDirectoryRoleMemberObject](Get-MgDirectoryRoleMemberObject.md)
Return all IDs for the groups, administrative units, and directory roles that a user, group, service principal, organizational contact, device, or directory object is a member of.
This function is transitive.
Note: Only users and role-enabled groups can be members of directory roles.

### [Get-MgDirectoryRoleScopedMember](Get-MgDirectoryRoleScopedMember.md)
Members of this directory role that are scoped to administrative units.
Read-only.
Nullable.

### [Get-MgDirectoryRoleScopedMemberCount](Get-MgDirectoryRoleScopedMemberCount.md)
Get the number of the resource

### [Get-MgDirectoryRoleTemplate](Get-MgDirectoryRoleTemplate.md)
Retrieve the properties and relationships of a directoryroletemplate object.

### [Get-MgDirectoryRoleTemplateById](Get-MgDirectoryRoleTemplateById.md)
Return the directory objects specified in a list of IDs.
Only a subset of user properties are returned by default in v1.0.
Some common uses for this function are to:

### [Get-MgDirectoryRoleTemplateCount](Get-MgDirectoryRoleTemplateCount.md)
Get the number of the resource

### [Get-MgDirectoryRoleTemplateDelta](Get-MgDirectoryRoleTemplateDelta.md)
Invoke function delta

### [Get-MgDirectoryRoleTemplateMemberGroup](Get-MgDirectoryRoleTemplateMemberGroup.md)
Return all the group IDs for the groups that the specified user, group, service principal, organizational contact, device, or directory object is a member of.
This function is transitive.

### [Get-MgDirectoryRoleTemplateMemberObject](Get-MgDirectoryRoleTemplateMemberObject.md)
Return all IDs for the groups, administrative units, and directory roles that a user, group, service principal, organizational contact, device, or directory object is a member of.
This function is transitive.
Note: Only users and role-enabled groups can be members of directory roles.

### [Get-MgDomain](Get-MgDomain.md)
Retrieve the properties and relationships of domain object.

### [Get-MgDomainCount](Get-MgDomainCount.md)
Get the number of the resource

### [Get-MgDomainFederationConfiguration](Get-MgDomainFederationConfiguration.md)
Read the properties and relationships of an internalDomainFederation object.

### [Get-MgDomainFederationConfigurationCount](Get-MgDomainFederationConfigurationCount.md)
Get the number of the resource

### [Get-MgDomainNameReference](Get-MgDomainNameReference.md)
The objects such as users and groups that reference the domain ID.
Read-only, Nullable.
Supports $expand and $filter by the OData type of objects returned.
For example /domains/{domainId}/domainNameReferences/microsoft.graph.user and /domains/{domainId}/domainNameReferences/microsoft.graph.group.

### [Get-MgDomainNameReferenceCount](Get-MgDomainNameReferenceCount.md)
Get the number of the resource

### [Get-MgDomainServiceConfigurationRecord](Get-MgDomainServiceConfigurationRecord.md)
DNS records the customer adds to the DNS zone file of the domain before the domain can be used by Microsoft Online services.
Read-only, Nullable.
Supports $expand.

### [Get-MgDomainServiceConfigurationRecordCount](Get-MgDomainServiceConfigurationRecordCount.md)
Get the number of the resource

### [Get-MgDomainVerificationDnsRecord](Get-MgDomainVerificationDnsRecord.md)
DNS records that the customer adds to the DNS zone file of the domain before the customer can complete domain ownership verification with Azure AD.
Read-only, Nullable.
Supports $expand.

### [Get-MgDomainVerificationDnsRecordCount](Get-MgDomainVerificationDnsRecordCount.md)
Get the number of the resource

### [Get-MgOrganization](Get-MgOrganization.md)
Get the properties and relationships of the currently authenticated organization.
Since the organization resource supports extensions, you can also use the GET operation to get custom properties and extension data in an organization instance.

### [Get-MgOrganizationBranding](Get-MgOrganizationBranding.md)
Retrieve the default organizational branding object, if the Accept-Language header is set to 0 or default.
If no default organizational branding object exists, this method returns a 404 Not Found error.
If the Accept-Language header is set to an existing locale identified by the value of its id, this method retrieves the branding for the specified locale.
This method retrieves only non-Stream properties, for example, usernameHintText and signInPageText.
To retrieve Stream types of the default branding, for example, bannerLogo and backgroundImage, use the GET organizationalBrandingLocalization method.

### [Get-MgOrganizationBrandingBackgroundImage](Get-MgOrganizationBrandingBackgroundImage.md)
Image that appears as the background of the sign-in page.
The allowed types are PNG or JPEG not smaller than 300 KB and not larger than 1920 × 1080 pixels.
A smaller image will reduce bandwidth requirements and make the page load faster.

### [Get-MgOrganizationBrandingBannerLogo](Get-MgOrganizationBrandingBannerLogo.md)
A banner version of your company logo that appears on the sign-in page.
The allowed types are PNG or JPEG not larger than 36 × 245 pixels.
We recommend using a transparent image with no padding around the logo.

### [Get-MgOrganizationBrandingCustomCss](Get-MgOrganizationBrandingCustomCss.md)
CSS styling that appears on the sign-in page.
The allowed format is .css format only and not larger than 25 KB.

### [Get-MgOrganizationBrandingFavicon](Get-MgOrganizationBrandingFavicon.md)
A custom icon (favicon) to replace a default Microsoft product favicon on an Azure AD tenant.

### [Get-MgOrganizationBrandingHeaderLogo](Get-MgOrganizationBrandingHeaderLogo.md)
A company logo that appears in the header of the sign-in page.
The allowed types are PNG or JPEG not larger than 36 × 245 pixels.
We recommend using a transparent image with no padding around the logo.

### [Get-MgOrganizationBrandingLocalization](Get-MgOrganizationBrandingLocalization.md)
Read the properties and relationships of an organizationalBrandingLocalization object.
To retrieve a localization branding object, specify the value of id in the URL.

### [Get-MgOrganizationBrandingLocalizationBackgroundImage](Get-MgOrganizationBrandingLocalizationBackgroundImage.md)
Image that appears as the background of the sign-in page.
The allowed types are PNG or JPEG not smaller than 300 KB and not larger than 1920 × 1080 pixels.
A smaller image will reduce bandwidth requirements and make the page load faster.

### [Get-MgOrganizationBrandingLocalizationBannerLogo](Get-MgOrganizationBrandingLocalizationBannerLogo.md)
A banner version of your company logo that appears on the sign-in page.
The allowed types are PNG or JPEG not larger than 36 × 245 pixels.
We recommend using a transparent image with no padding around the logo.

### [Get-MgOrganizationBrandingLocalizationCount](Get-MgOrganizationBrandingLocalizationCount.md)
Get the number of the resource

### [Get-MgOrganizationBrandingLocalizationCustomCss](Get-MgOrganizationBrandingLocalizationCustomCss.md)
CSS styling that appears on the sign-in page.
The allowed format is .css format only and not larger than 25 KB.

### [Get-MgOrganizationBrandingLocalizationFavicon](Get-MgOrganizationBrandingLocalizationFavicon.md)
A custom icon (favicon) to replace a default Microsoft product favicon on an Azure AD tenant.

### [Get-MgOrganizationBrandingLocalizationHeaderLogo](Get-MgOrganizationBrandingLocalizationHeaderLogo.md)
A company logo that appears in the header of the sign-in page.
The allowed types are PNG or JPEG not larger than 36 × 245 pixels.
We recommend using a transparent image with no padding around the logo.

### [Get-MgOrganizationBrandingLocalizationSquareLogo](Get-MgOrganizationBrandingLocalizationSquareLogo.md)
A square version of your company logo that appears in Windows 10 out-of-box experiences (OOBE) and when Windows Autopilot is enabled for deployment.
Allowed types are PNG or JPEG not larger than 240 x 240 pixels and not more than 10 KB in size.
We recommend using a transparent image with no padding around the logo.

### [Get-MgOrganizationBrandingLocalizationSquareLogoDark](Get-MgOrganizationBrandingLocalizationSquareLogoDark.md)
A square dark version of your company logo that appears in Windows 10 out-of-box experiences (OOBE) and when Windows Autopilot is enabled for deployment.
Allowed types are PNG or JPEG not larger than 240 x 240 pixels and not more than 10 KB in size.
We recommend using a transparent image with no padding around the logo.

### [Get-MgOrganizationBrandingSquareLogo](Get-MgOrganizationBrandingSquareLogo.md)
A square version of your company logo that appears in Windows 10 out-of-box experiences (OOBE) and when Windows Autopilot is enabled for deployment.
Allowed types are PNG or JPEG not larger than 240 x 240 pixels and not more than 10 KB in size.
We recommend using a transparent image with no padding around the logo.

### [Get-MgOrganizationBrandingSquareLogoDark](Get-MgOrganizationBrandingSquareLogoDark.md)
A square dark version of your company logo that appears in Windows 10 out-of-box experiences (OOBE) and when Windows Autopilot is enabled for deployment.
Allowed types are PNG or JPEG not larger than 240 x 240 pixels and not more than 10 KB in size.
We recommend using a transparent image with no padding around the logo.

### [Get-MgOrganizationById](Get-MgOrganizationById.md)
Return the directory objects specified in a list of IDs.
Only a subset of user properties are returned by default in v1.0.
Some common uses for this function are to:

### [Get-MgOrganizationCount](Get-MgOrganizationCount.md)
Get the number of the resource

### [Get-MgOrganizationExtension](Get-MgOrganizationExtension.md)
The collection of open extensions defined for the organization.
Read-only.
Nullable.

### [Get-MgOrganizationExtensionCount](Get-MgOrganizationExtensionCount.md)
Get the number of the resource

### [Get-MgOrganizationMemberGroup](Get-MgOrganizationMemberGroup.md)
Return all the group IDs for the groups that the specified user, group, service principal, organizational contact, device, or directory object is a member of.
This function is transitive.

### [Get-MgOrganizationMemberObject](Get-MgOrganizationMemberObject.md)
Return all IDs for the groups, administrative units, and directory roles that a user, group, service principal, organizational contact, device, or directory object is a member of.
This function is transitive.
Note: Only users and role-enabled groups can be members of directory roles.

### [Get-MgSubscribedSku](Get-MgSubscribedSku.md)
Get a specific commercial subscription that an organization has acquired.

### [Get-MgUserScopedRoleMemberOf](Get-MgUserScopedRoleMemberOf.md)
Get scopedRoleMemberOf from users

### [Get-MgUserScopedRoleMemberOfCount](Get-MgUserScopedRoleMemberOfCount.md)
Get the number of the resource

### [Invoke-MgAvailableDirectoryFederationConfigurationProviderType](Invoke-MgAvailableDirectoryFederationConfigurationProviderType.md)
Invoke function availableProviderTypes

### [Invoke-MgForceDomainDelete](Invoke-MgForceDomainDelete.md)
Deletes a domain using an asynchronous long-running operation.
Prior to calling forceDelete, you must update or remove any references to Exchange as the provisioning service.
The following actions are performed as part of this operation: After the domain deletion completes, API operations for the deleted domain will return a HTTP 404 status code.
To verify deletion of a domain, you can perform a get domain operation.

### [Invoke-MgPromoteDomain](Invoke-MgPromoteDomain.md)
Promote a verified subdomain to the root domain.
A verified domain has its isVerified property set to true.

### [New-MgContact](New-MgContact.md)
Add new entity to contacts

### [New-MgContract](New-MgContract.md)
Add new entity to contracts

### [New-MgDevice](New-MgDevice.md)
Create and register a new device in the organization.

### [New-MgDeviceExtension](New-MgDeviceExtension.md)
Create new navigation property to extensions for devices

### [New-MgDeviceRegisteredOwnerByRef](New-MgDeviceRegisteredOwnerByRef.md)
Add a user as a registered owner of the device.

### [New-MgDeviceRegisteredUserByRef](New-MgDeviceRegisteredUserByRef.md)
Add a registered user for the device.

### [New-MgDirectoryAdministrativeUnit](New-MgDirectoryAdministrativeUnit.md)
Use this API to create a new administrativeUnit.

### [New-MgDirectoryAdministrativeUnitExtension](New-MgDirectoryAdministrativeUnitExtension.md)
Create new navigation property to extensions for directory

### [New-MgDirectoryAdministrativeUnitMember](New-MgDirectoryAdministrativeUnitMember.md)
Create new navigation property to members for directory

### [New-MgDirectoryAdministrativeUnitMemberByRef](New-MgDirectoryAdministrativeUnitMemberByRef.md)
Create new navigation property ref to members for directory

### [New-MgDirectoryAdministrativeUnitScopedRoleMember](New-MgDirectoryAdministrativeUnitScopedRoleMember.md)
Assign an Azure Active Directory (Azure AD) role with administrative unit scope.
For a list of roles that can be assigned with administrative unit scope, see Assign Azure AD roles with administrative unit scope.

### [New-MgDirectoryAttributeSet](New-MgDirectoryAttributeSet.md)
Create a new attributeSet object.

### [New-MgDirectoryCustomSecurityAttributeDefinition](New-MgDirectoryCustomSecurityAttributeDefinition.md)
Create a new customSecurityAttributeDefinition object.

### [New-MgDirectoryCustomSecurityAttributeDefinitionAllowedValue](New-MgDirectoryCustomSecurityAttributeDefinitionAllowedValue.md)
Create a new allowedValue object.

### [New-MgDirectoryDeletedItem](New-MgDirectoryDeletedItem.md)
Create new navigation property to deletedItems for directory

### [New-MgDirectoryFederationConfiguration](New-MgDirectoryFederationConfiguration.md)
Create new navigation property to federationConfigurations for directory

### [New-MgDirectoryOnPremiseSynchronization](New-MgDirectoryOnPremiseSynchronization.md)
Create new navigation property to onPremisesSynchronization for directory

### [New-MgDirectoryRole](New-MgDirectoryRole.md)
Activate a directory role.
To read a directory role or update its members, it must first be activated in the tenant.
The Company Administrators and the implicit user directory roles (User, Guest User, and Restricted Guest User roles) are activated by default.
To access and assign members to other directory roles, you must first activate it with its corresponding directory role template ID.

### [New-MgDirectoryRoleMemberByRef](New-MgDirectoryRoleMemberByRef.md)
Create a new directory role member.
You can use both the object ID and template ID of the directoryRole with this API.
The template ID of a built-in role is immutable and can be seen in the role description on the Azure portal.
For details, see Role template IDs.

### [New-MgDirectoryRoleScopedMember](New-MgDirectoryRoleScopedMember.md)
Create new navigation property to scopedMembers for directoryRoles

### [New-MgDirectoryRoleTemplate](New-MgDirectoryRoleTemplate.md)
Add new entity to directoryRoleTemplates

### [New-MgDomain](New-MgDomain.md)
Adds a domain to the tenant.
Important: You cannot use an associated domain with your Azure AD tenant until ownership is verified.
See List verificationDnsRecords for details.
Root domains require verification.
For example, contoso.com requires verification.
If a root domain is verified, subdomains of the root domain are automatically verified.
For example, subdomain.contoso.com is automatically be verified if contoso.com has been verified.

### [New-MgDomainFederationConfiguration](New-MgDomainFederationConfiguration.md)
Create a new internalDomainFederation object.

### [New-MgDomainServiceConfigurationRecord](New-MgDomainServiceConfigurationRecord.md)
Create new navigation property to serviceConfigurationRecords for domains

### [New-MgDomainVerificationDnsRecord](New-MgDomainVerificationDnsRecord.md)
Create new navigation property to verificationDnsRecords for domains

### [New-MgOrganization](New-MgOrganization.md)
Add new entity to organization

### [New-MgOrganizationBrandingLocalization](New-MgOrganizationBrandingLocalization.md)
Create a new organizationalBrandingLocalization object.
This creates a localized branding and at the same time, the default branding if it doesn't exist.
The default branding is created only once.
It's loaded when a localized branding isn't configured for the user's browser language.
To retrieve the default branding, see Get branding.

### [New-MgOrganizationExtension](New-MgOrganizationExtension.md)
Create new navigation property to extensions for organization

### [New-MgSubscribedSku](New-MgSubscribedSku.md)
Add new entity to subscribedSkus

### [New-MgUserScopedRoleMemberOf](New-MgUserScopedRoleMemberOf.md)
Create new navigation property to scopedRoleMemberOf for users

### [Remove-MgContact](Remove-MgContact.md)
Delete entity from contacts

### [Remove-MgContract](Remove-MgContract.md)
Delete entity from contracts

### [Remove-MgDevice](Remove-MgDevice.md)
Delete a registered device.

### [Remove-MgDeviceByDeviceId](Remove-MgDeviceByDeviceId.md)
Delete a registered device.

### [Remove-MgDeviceExtension](Remove-MgDeviceExtension.md)
Delete navigation property extensions for devices

### [Remove-MgDeviceRegisteredOwnerByRef](Remove-MgDeviceRegisteredOwnerByRef.md)
Remove a user as a registered owner of the device.

### [Remove-MgDeviceRegisteredUserByRef](Remove-MgDeviceRegisteredUserByRef.md)
Remove a user as a registered user of the device.

### [Remove-MgDirectoryAdministrativeUnit](Remove-MgDirectoryAdministrativeUnit.md)
Delete an administrativeUnit.

### [Remove-MgDirectoryAdministrativeUnitExtension](Remove-MgDirectoryAdministrativeUnitExtension.md)
Delete navigation property extensions for directory

### [Remove-MgDirectoryAdministrativeUnitMemberByRef](Remove-MgDirectoryAdministrativeUnitMemberByRef.md)
Use this API to remove a member (user, group, or device) from an administrative unit.

### [Remove-MgDirectoryAdministrativeUnitScopedRoleMember](Remove-MgDirectoryAdministrativeUnitScopedRoleMember.md)
Remove an Azure Active Directory (Azure AD) role assignment with administrative unit scope.

### [Remove-MgDirectoryAttributeSet](Remove-MgDirectoryAttributeSet.md)
Delete navigation property attributeSets for directory

### [Remove-MgDirectoryCustomSecurityAttributeDefinition](Remove-MgDirectoryCustomSecurityAttributeDefinition.md)
Delete navigation property customSecurityAttributeDefinitions for directory

### [Remove-MgDirectoryCustomSecurityAttributeDefinitionAllowedValue](Remove-MgDirectoryCustomSecurityAttributeDefinitionAllowedValue.md)
Delete navigation property allowedValues for directory

### [Remove-MgDirectoryDeletedItem](Remove-MgDirectoryDeletedItem.md)
Permanently delete a recently deleted application, group, servicePrincipal, or user object from deleted items.
After an item is permanently deleted, it cannot be restored.
Administrative units cannot be permanently deleted by using the deletedItems API.
Soft-deleted administrative units will be permanently deleted 30 days after initial deletion unless they are restored.

### [Remove-MgDirectoryFederationConfiguration](Remove-MgDirectoryFederationConfiguration.md)
Delete a samlOrWsFedExternalDomainFederation object.

### [Remove-MgDirectoryOnPremiseSynchronization](Remove-MgDirectoryOnPremiseSynchronization.md)
Delete navigation property onPremisesSynchronization for directory

### [Remove-MgDirectoryRole](Remove-MgDirectoryRole.md)
Delete entity from directoryRoles

### [Remove-MgDirectoryRoleByRoleTemplateId](Remove-MgDirectoryRoleByRoleTemplateId.md)
Delete entity from directoryRoles by roleTemplateId

### [Remove-MgDirectoryRoleMemberByRef](Remove-MgDirectoryRoleMemberByRef.md)
Remove a member from a directoryRole.
You can use both the object ID and template ID of the directoryRole with this API.
The template ID of a built-in role is immutable and can be seen in the role description on the Azure portal.
For details, see Role template IDs.

### [Remove-MgDirectoryRoleScopedMember](Remove-MgDirectoryRoleScopedMember.md)
Delete navigation property scopedMembers for directoryRoles

### [Remove-MgDirectoryRoleTemplate](Remove-MgDirectoryRoleTemplate.md)
Delete entity from directoryRoleTemplates

### [Remove-MgDomain](Remove-MgDomain.md)
Deletes a domain from a tenant.

### [Remove-MgDomainFederationConfiguration](Remove-MgDomainFederationConfiguration.md)
Delete an internalDomainFederation object.

### [Remove-MgDomainServiceConfigurationRecord](Remove-MgDomainServiceConfigurationRecord.md)
Delete navigation property serviceConfigurationRecords for domains

### [Remove-MgDomainVerificationDnsRecord](Remove-MgDomainVerificationDnsRecord.md)
Delete navigation property verificationDnsRecords for domains

### [Remove-MgOrganization](Remove-MgOrganization.md)
Delete entity from organization

### [Remove-MgOrganizationBranding](Remove-MgOrganizationBranding.md)
Delete the default organizational branding object.
To delete the organizationalBranding object, all images (Stream types) must first be removed from the object.

### [Remove-MgOrganizationBrandingLocalization](Remove-MgOrganizationBrandingLocalization.md)
Delete a localized branding object.
To delete the organizationalBrandingLocalization object, all images (Stream types) must first be removed from the object.

### [Remove-MgOrganizationExtension](Remove-MgOrganizationExtension.md)
Delete navigation property extensions for organization

### [Remove-MgSubscribedSku](Remove-MgSubscribedSku.md)
Delete entity from subscribedSkus

### [Remove-MgUserScopedRoleMemberOf](Remove-MgUserScopedRoleMemberOf.md)
Delete navigation property scopedRoleMemberOf for users

### [Restore-MgDirectoryDeletedItem](Restore-MgDirectoryDeletedItem.md)
Restore a recently deleted application, group, servicePrincipal, administrative unit, or user object from deleted items.
If an item was accidentally deleted, you can fully restore the item.
This is not applicable to security groups, which are deleted permanently.
A recently deleted item will remain available for up to 30 days.
After 30 days, the item is permanently deleted.

### [Set-MgOrganizationBrandingBackgroundImage](Set-MgOrganizationBrandingBackgroundImage.md)
Image that appears as the background of the sign-in page.
The allowed types are PNG or JPEG not smaller than 300 KB and not larger than 1920 × 1080 pixels.
A smaller image will reduce bandwidth requirements and make the page load faster.

### [Set-MgOrganizationBrandingBannerLogo](Set-MgOrganizationBrandingBannerLogo.md)
A banner version of your company logo that appears on the sign-in page.
The allowed types are PNG or JPEG not larger than 36 × 245 pixels.
We recommend using a transparent image with no padding around the logo.

### [Set-MgOrganizationBrandingCustomCss](Set-MgOrganizationBrandingCustomCss.md)
CSS styling that appears on the sign-in page.
The allowed format is .css format only and not larger than 25 KB.

### [Set-MgOrganizationBrandingFavicon](Set-MgOrganizationBrandingFavicon.md)
A custom icon (favicon) to replace a default Microsoft product favicon on an Azure AD tenant.

### [Set-MgOrganizationBrandingHeaderLogo](Set-MgOrganizationBrandingHeaderLogo.md)
A company logo that appears in the header of the sign-in page.
The allowed types are PNG or JPEG not larger than 36 × 245 pixels.
We recommend using a transparent image with no padding around the logo.

### [Set-MgOrganizationBrandingLocalizationBackgroundImage](Set-MgOrganizationBrandingLocalizationBackgroundImage.md)
Image that appears as the background of the sign-in page.
The allowed types are PNG or JPEG not smaller than 300 KB and not larger than 1920 × 1080 pixels.
A smaller image will reduce bandwidth requirements and make the page load faster.

### [Set-MgOrganizationBrandingLocalizationBannerLogo](Set-MgOrganizationBrandingLocalizationBannerLogo.md)
A banner version of your company logo that appears on the sign-in page.
The allowed types are PNG or JPEG not larger than 36 × 245 pixels.
We recommend using a transparent image with no padding around the logo.

### [Set-MgOrganizationBrandingLocalizationCustomCss](Set-MgOrganizationBrandingLocalizationCustomCss.md)
CSS styling that appears on the sign-in page.
The allowed format is .css format only and not larger than 25 KB.

### [Set-MgOrganizationBrandingLocalizationFavicon](Set-MgOrganizationBrandingLocalizationFavicon.md)
A custom icon (favicon) to replace a default Microsoft product favicon on an Azure AD tenant.

### [Set-MgOrganizationBrandingLocalizationHeaderLogo](Set-MgOrganizationBrandingLocalizationHeaderLogo.md)
A company logo that appears in the header of the sign-in page.
The allowed types are PNG or JPEG not larger than 36 × 245 pixels.
We recommend using a transparent image with no padding around the logo.

### [Set-MgOrganizationBrandingLocalizationSquareLogo](Set-MgOrganizationBrandingLocalizationSquareLogo.md)
A square version of your company logo that appears in Windows 10 out-of-box experiences (OOBE) and when Windows Autopilot is enabled for deployment.
Allowed types are PNG or JPEG not larger than 240 x 240 pixels and not more than 10 KB in size.
We recommend using a transparent image with no padding around the logo.

### [Set-MgOrganizationBrandingLocalizationSquareLogoDark](Set-MgOrganizationBrandingLocalizationSquareLogoDark.md)
A square dark version of your company logo that appears in Windows 10 out-of-box experiences (OOBE) and when Windows Autopilot is enabled for deployment.
Allowed types are PNG or JPEG not larger than 240 x 240 pixels and not more than 10 KB in size.
We recommend using a transparent image with no padding around the logo.

### [Set-MgOrganizationBrandingSquareLogo](Set-MgOrganizationBrandingSquareLogo.md)
A square version of your company logo that appears in Windows 10 out-of-box experiences (OOBE) and when Windows Autopilot is enabled for deployment.
Allowed types are PNG or JPEG not larger than 240 x 240 pixels and not more than 10 KB in size.
We recommend using a transparent image with no padding around the logo.

### [Set-MgOrganizationBrandingSquareLogoDark](Set-MgOrganizationBrandingSquareLogoDark.md)
A square dark version of your company logo that appears in Windows 10 out-of-box experiences (OOBE) and when Windows Autopilot is enabled for deployment.
Allowed types are PNG or JPEG not larger than 240 x 240 pixels and not more than 10 KB in size.
We recommend using a transparent image with no padding around the logo.

### [Set-MgOrganizationMobileDeviceManagementAuthority](Set-MgOrganizationMobileDeviceManagementAuthority.md)
Set mobile device management authority

### [Test-MgContactProperty](Test-MgContactProperty.md)
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

### [Test-MgContractProperty](Test-MgContractProperty.md)
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

### [Test-MgDeviceProperty](Test-MgDeviceProperty.md)
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

### [Test-MgDirectoryDeletedItemProperty](Test-MgDirectoryDeletedItemProperty.md)
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

### [Test-MgDirectoryRoleProperty](Test-MgDirectoryRoleProperty.md)
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

### [Test-MgDirectoryRoleTemplateProperty](Test-MgDirectoryRoleTemplateProperty.md)
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

### [Test-MgOrganizationProperty](Test-MgOrganizationProperty.md)
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

### [Update-MgContact](Update-MgContact.md)
Update entity in contacts

### [Update-MgContract](Update-MgContract.md)
Update entity in contracts

### [Update-MgDevice](Update-MgDevice.md)
Update the properties of a registered device.
Only certain properties of a device can be updated through approved Mobile Device Managment (MDM) apps.

### [Update-MgDeviceByDeviceId](Update-MgDeviceByDeviceId.md)
Update the properties of a registered device.
Only certain properties of a device can be updated through approved Mobile Device Managment (MDM) apps.

### [Update-MgDeviceExtension](Update-MgDeviceExtension.md)
Update the navigation property extensions in devices

### [Update-MgDirectory](Update-MgDirectory.md)
Update directory

### [Update-MgDirectoryAdministrativeUnit](Update-MgDirectoryAdministrativeUnit.md)
Update the properties of an administrativeUnit object.

### [Update-MgDirectoryAdministrativeUnitExtension](Update-MgDirectoryAdministrativeUnitExtension.md)
Update the navigation property extensions in directory

### [Update-MgDirectoryAdministrativeUnitScopedRoleMember](Update-MgDirectoryAdministrativeUnitScopedRoleMember.md)
Update the navigation property scopedRoleMembers in directory

### [Update-MgDirectoryAttributeSet](Update-MgDirectoryAttributeSet.md)
Update the properties of an attributeSet object.

### [Update-MgDirectoryCustomSecurityAttributeDefinition](Update-MgDirectoryCustomSecurityAttributeDefinition.md)
Update the properties of a customSecurityAttributeDefinition object.

### [Update-MgDirectoryCustomSecurityAttributeDefinitionAllowedValue](Update-MgDirectoryCustomSecurityAttributeDefinitionAllowedValue.md)
Update the properties of an allowedValue object.

### [Update-MgDirectoryDeletedItem](Update-MgDirectoryDeletedItem.md)
Update the navigation property deletedItems in directory

### [Update-MgDirectoryFederationConfiguration](Update-MgDirectoryFederationConfiguration.md)
Update the navigation property federationConfigurations in directory

### [Update-MgDirectoryOnPremiseSynchronization](Update-MgDirectoryOnPremiseSynchronization.md)
Update the properties of an onPremisesDirectorySynchronization object.

### [Update-MgDirectoryRole](Update-MgDirectoryRole.md)
Update entity in directoryRoles

### [Update-MgDirectoryRoleByRoleTemplateId](Update-MgDirectoryRoleByRoleTemplateId.md)
Update entity in directoryRoles by roleTemplateId

### [Update-MgDirectoryRoleScopedMember](Update-MgDirectoryRoleScopedMember.md)
Update the navigation property scopedMembers in directoryRoles

### [Update-MgDirectoryRoleTemplate](Update-MgDirectoryRoleTemplate.md)
Update entity in directoryRoleTemplates

### [Update-MgDomain](Update-MgDomain.md)
Update the properties of domain object.

### [Update-MgDomainFederationConfiguration](Update-MgDomainFederationConfiguration.md)
Update the properties of an internalDomainFederation object.

### [Update-MgDomainServiceConfigurationRecord](Update-MgDomainServiceConfigurationRecord.md)
Update the navigation property serviceConfigurationRecords in domains

### [Update-MgDomainVerificationDnsRecord](Update-MgDomainVerificationDnsRecord.md)
Update the navigation property verificationDnsRecords in domains

### [Update-MgOrganization](Update-MgOrganization.md)
Update the properties of a organization object.

### [Update-MgOrganizationBranding](Update-MgOrganizationBranding.md)
Update the properties of the default branding object specified by the organizationalBranding resource.

### [Update-MgOrganizationBrandingLocalization](Update-MgOrganizationBrandingLocalization.md)
Update the properties of an organizationalBrandingLocalization object for a specific localization.

### [Update-MgOrganizationExtension](Update-MgOrganizationExtension.md)
Update the navigation property extensions in organization

### [Update-MgSubscribedSku](Update-MgSubscribedSku.md)
Update entity in subscribedSkus

### [Update-MgUserScopedRoleMemberOf](Update-MgUserScopedRoleMemberOf.md)
Update the navigation property scopedRoleMemberOf in users

