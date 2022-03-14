---
Module Name: Microsoft.Graph.Identity.DirectoryManagement
Module Guid: d346f578-73bb-473f-86a5-bce3a2e9a76a
Download Help Link: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.directorymanagement
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Identity.DirectoryManagement Module
## Description
Microsoft Graph PowerShell Cmdlets

## Microsoft.Graph.Identity.DirectoryManagement Cmdlets
### [Confirm-MgContactMemberGroup](Confirm-MgContactMemberGroup.md)
Invoke action checkMemberGroups

### [Confirm-MgContactMemberObject](Confirm-MgContactMemberObject.md)
Invoke action checkMemberObjects

### [Confirm-MgContractMemberGroup](Confirm-MgContractMemberGroup.md)
Invoke action checkMemberGroups

### [Confirm-MgContractMemberObject](Confirm-MgContractMemberObject.md)
Invoke action checkMemberObjects

### [Confirm-MgDeviceMemberGroup](Confirm-MgDeviceMemberGroup.md)
Invoke action checkMemberGroups

### [Confirm-MgDeviceMemberObject](Confirm-MgDeviceMemberObject.md)
Invoke action checkMemberObjects

### [Confirm-MgDirectoryRoleMemberGroup](Confirm-MgDirectoryRoleMemberGroup.md)
Invoke action checkMemberGroups

### [Confirm-MgDirectoryRoleMemberObject](Confirm-MgDirectoryRoleMemberObject.md)
Invoke action checkMemberObjects

### [Confirm-MgDirectoryRoleTemplateMemberGroup](Confirm-MgDirectoryRoleTemplateMemberGroup.md)
Invoke action checkMemberGroups

### [Confirm-MgDirectoryRoleTemplateMemberObject](Confirm-MgDirectoryRoleTemplateMemberObject.md)
Invoke action checkMemberObjects

### [Confirm-MgDomain](Confirm-MgDomain.md)
Invoke action verify

### [Confirm-MgOrganizationMemberGroup](Confirm-MgOrganizationMemberGroup.md)
Invoke action checkMemberGroups

### [Confirm-MgOrganizationMemberObject](Confirm-MgOrganizationMemberObject.md)
Invoke action checkMemberObjects

### [Get-MgContact](Get-MgContact.md)
Get entity from contacts by key

### [Get-MgContactById](Get-MgContactById.md)
Invoke action getByIds

### [Get-MgContactDelta](Get-MgContactDelta.md)
Invoke function delta

### [Get-MgContactDirectReport](Get-MgContactDirectReport.md)
The contact's direct reports.
(The users and contacts that have their manager property set to this contact.) Read-only.
Nullable.
Supports $expand.

### [Get-MgContactDirectReportByRef](Get-MgContactDirectReportByRef.md)
The contact's direct reports.
(The users and contacts that have their manager property set to this contact.) Read-only.
Nullable.
Supports $expand.

### [Get-MgContactManager](Get-MgContactManager.md)
The user or contact that is this contact's manager.
Read-only.
Supports $expand.

### [Get-MgContactManagerByRef](Get-MgContactManagerByRef.md)
The user or contact that is this contact's manager.
Read-only.
Supports $expand.

### [Get-MgContactMemberGroup](Get-MgContactMemberGroup.md)
Invoke action getMemberGroups

### [Get-MgContactMemberObject](Get-MgContactMemberObject.md)
Invoke action getMemberObjects

### [Get-MgContactMemberOf](Get-MgContactMemberOf.md)
Groups that this contact is a member of.
Read-only.
Nullable.
Supports $expand.

### [Get-MgContactMemberOfByRef](Get-MgContactMemberOfByRef.md)
Groups that this contact is a member of.
Read-only.
Nullable.
Supports $expand.

### [Get-MgContactTransitiveMemberOf](Get-MgContactTransitiveMemberOf.md)
Get transitiveMemberOf from contacts

### [Get-MgContactTransitiveMemberOfByRef](Get-MgContactTransitiveMemberOfByRef.md)
Get ref of transitiveMemberOf from contacts

### [Get-MgContract](Get-MgContract.md)
Get entity from contracts by key

### [Get-MgContractById](Get-MgContractById.md)
Invoke action getByIds

### [Get-MgContractMemberGroup](Get-MgContractMemberGroup.md)
Invoke action getMemberGroups

### [Get-MgContractMemberObject](Get-MgContractMemberObject.md)
Invoke action getMemberObjects

### [Get-MgDevice](Get-MgDevice.md)
Get entities from devices

### [Get-MgDeviceById](Get-MgDeviceById.md)
Get entity from devices by key

### [Get-MgDeviceExtension](Get-MgDeviceExtension.md)
The collection of open extensions defined for the device.
Read-only.
Nullable.

### [Get-MgDeviceMemberGroup](Get-MgDeviceMemberGroup.md)
Invoke action getMemberGroups

### [Get-MgDeviceMemberObject](Get-MgDeviceMemberObject.md)
Invoke action getMemberObjects

### [Get-MgDeviceMemberOf](Get-MgDeviceMemberOf.md)
Groups that this device is a member of.
Read-only.
Nullable.
Supports $expand.

### [Get-MgDeviceMemberOfByRef](Get-MgDeviceMemberOfByRef.md)
Groups that this device is a member of.
Read-only.
Nullable.
Supports $expand.

### [Get-MgDeviceRegisteredOwner](Get-MgDeviceRegisteredOwner.md)
The user that cloud joined the device or registered their personal device.
The registered owner is set at the time of registration.
Currently, there can be only one owner.
Read-only.
Nullable.
Supports $expand.

### [Get-MgDeviceRegisteredOwnerByRef](Get-MgDeviceRegisteredOwnerByRef.md)
The user that cloud joined the device or registered their personal device.
The registered owner is set at the time of registration.
Currently, there can be only one owner.
Read-only.
Nullable.
Supports $expand.

### [Get-MgDeviceRegisteredUser](Get-MgDeviceRegisteredUser.md)
Collection of registered users of the device.
For cloud joined devices and registered personal devices, registered users are set to the same value as registered owners at the time of registration.
Read-only.
Nullable.
Supports $expand.

### [Get-MgDeviceRegisteredUserByRef](Get-MgDeviceRegisteredUserByRef.md)
Collection of registered users of the device.
For cloud joined devices and registered personal devices, registered users are set to the same value as registered owners at the time of registration.
Read-only.
Nullable.
Supports $expand.

### [Get-MgDeviceTransitiveMemberOf](Get-MgDeviceTransitiveMemberOf.md)
Groups that the device is a member of.
This operation is transitive.
Supports $expand.

### [Get-MgDeviceTransitiveMemberOfByRef](Get-MgDeviceTransitiveMemberOfByRef.md)
Groups that the device is a member of.
This operation is transitive.
Supports $expand.

### [Get-MgDirectory](Get-MgDirectory.md)
Get directory

### [Get-MgDirectoryAdministrativeUnit](Get-MgDirectoryAdministrativeUnit.md)
Conceptual container for user and group directory objects.

### [Get-MgDirectoryAdministrativeUnitDelta](Get-MgDirectoryAdministrativeUnitDelta.md)
Invoke function delta

### [Get-MgDirectoryAdministrativeUnitExtension](Get-MgDirectoryAdministrativeUnitExtension.md)
The collection of open extensions defined for this administrative unit.
Nullable.

### [Get-MgDirectoryAdministrativeUnitMember](Get-MgDirectoryAdministrativeUnitMember.md)
Users and groups that are members of this administrative unit.
Supports $expand.

### [Get-MgDirectoryAdministrativeUnitMemberByRef](Get-MgDirectoryAdministrativeUnitMemberByRef.md)
Users and groups that are members of this administrative unit.
Supports $expand.

### [Get-MgDirectoryAdministrativeUnitScopedRoleMember](Get-MgDirectoryAdministrativeUnitScopedRoleMember.md)
Scoped-role members of this administrative unit.

### [Get-MgDirectoryDeletedItem](Get-MgDirectoryDeletedItem.md)
Recently deleted items.
Read-only.
Nullable.

### [Get-MgDirectoryRole](Get-MgDirectoryRole.md)
Get entity from directoryRoles by key

### [Get-MgDirectoryRoleById](Get-MgDirectoryRoleById.md)
Invoke action getByIds

### [Get-MgDirectoryRoleDelta](Get-MgDirectoryRoleDelta.md)
Invoke function delta

### [Get-MgDirectoryRoleMember](Get-MgDirectoryRoleMember.md)
Users that are members of this directory role.
HTTP Methods: GET, POST, DELETE.
Read-only.
Nullable.
Supports $expand.

### [Get-MgDirectoryRoleMemberByRef](Get-MgDirectoryRoleMemberByRef.md)
Users that are members of this directory role.
HTTP Methods: GET, POST, DELETE.
Read-only.
Nullable.
Supports $expand.

### [Get-MgDirectoryRoleMemberGroup](Get-MgDirectoryRoleMemberGroup.md)
Invoke action getMemberGroups

### [Get-MgDirectoryRoleMemberObject](Get-MgDirectoryRoleMemberObject.md)
Invoke action getMemberObjects

### [Get-MgDirectoryRoleScopedMember](Get-MgDirectoryRoleScopedMember.md)
Members of this directory role that are scoped to administrative units.
Read-only.
Nullable.

### [Get-MgDirectoryRoleTemplate](Get-MgDirectoryRoleTemplate.md)
Get entity from directoryRoleTemplates by key

### [Get-MgDirectoryRoleTemplateById](Get-MgDirectoryRoleTemplateById.md)
Invoke action getByIds

### [Get-MgDirectoryRoleTemplateMemberGroup](Get-MgDirectoryRoleTemplateMemberGroup.md)
Invoke action getMemberGroups

### [Get-MgDirectoryRoleTemplateMemberObject](Get-MgDirectoryRoleTemplateMemberObject.md)
Invoke action getMemberObjects

### [Get-MgDomain](Get-MgDomain.md)
Get entity from domains by key

### [Get-MgDomainDomainNameReferenceByRef](Get-MgDomainDomainNameReferenceByRef.md)
Read-only, Nullable

### [Get-MgDomainNameReference](Get-MgDomainNameReference.md)
Read-only, Nullable

### [Get-MgDomainServiceConfigurationRecord](Get-MgDomainServiceConfigurationRecord.md)
DNS records the customer adds to the DNS zone file of the domain before the domain can be used by Microsoft Online services.
Read-only, Nullable

### [Get-MgDomainVerificationDnsRecord](Get-MgDomainVerificationDnsRecord.md)
DNS records that the customer adds to the DNS zone file of the domain before the customer can complete domain ownership verification with Azure AD.
Read-only, Nullable

### [Get-MgOrganization](Get-MgOrganization.md)
Get entity from organization by key

### [Get-MgOrganizationBranding](Get-MgOrganizationBranding.md)
Get branding from organization

### [Get-MgOrganizationById](Get-MgOrganizationById.md)
Invoke action getByIds

### [Get-MgOrganizationExtension](Get-MgOrganizationExtension.md)
The collection of open extensions defined for the organization.
Read-only.
Nullable.

### [Get-MgOrganizationMemberGroup](Get-MgOrganizationMemberGroup.md)
Invoke action getMemberGroups

### [Get-MgOrganizationMemberObject](Get-MgOrganizationMemberObject.md)
Invoke action getMemberObjects

### [Get-MgSubscribedSku](Get-MgSubscribedSku.md)
Get entity from subscribedSkus by key

### [Get-MgUserScopedRoleMemberOf](Get-MgUserScopedRoleMemberOf.md)
The scoped-role administrative unit memberships for this user.
Read-only.
Nullable.

### [Invoke-MgForceDomainDelete](Invoke-MgForceDomainDelete.md)
Invoke action forceDelete

### [New-MgContact](New-MgContact.md)
Add new entity to contacts

### [New-MgContactDirectReportByRef](New-MgContactDirectReportByRef.md)
The contact's direct reports.
(The users and contacts that have their manager property set to this contact.) Read-only.
Nullable.
Supports $expand.

### [New-MgContactMemberOfByRef](New-MgContactMemberOfByRef.md)
Groups that this contact is a member of.
Read-only.
Nullable.
Supports $expand.

### [New-MgContactTransitiveMemberOfByRef](New-MgContactTransitiveMemberOfByRef.md)
Create new navigation property ref to transitiveMemberOf for contacts

### [New-MgContract](New-MgContract.md)
Add new entity to contracts

### [New-MgDevice](New-MgDevice.md)
Add new entity to devices

### [New-MgDeviceExtension](New-MgDeviceExtension.md)
The collection of open extensions defined for the device.
Read-only.
Nullable.

### [New-MgDeviceMemberOfByRef](New-MgDeviceMemberOfByRef.md)
Groups that this device is a member of.
Read-only.
Nullable.
Supports $expand.

### [New-MgDeviceRegisteredOwnerByRef](New-MgDeviceRegisteredOwnerByRef.md)
The user that cloud joined the device or registered their personal device.
The registered owner is set at the time of registration.
Currently, there can be only one owner.
Read-only.
Nullable.
Supports $expand.

### [New-MgDeviceRegisteredUserByRef](New-MgDeviceRegisteredUserByRef.md)
Collection of registered users of the device.
For cloud joined devices and registered personal devices, registered users are set to the same value as registered owners at the time of registration.
Read-only.
Nullable.
Supports $expand.

### [New-MgDeviceTransitiveMemberOfByRef](New-MgDeviceTransitiveMemberOfByRef.md)
Groups that the device is a member of.
This operation is transitive.
Supports $expand.

### [New-MgDirectoryAdministrativeUnit](New-MgDirectoryAdministrativeUnit.md)
Conceptual container for user and group directory objects.

### [New-MgDirectoryAdministrativeUnitExtension](New-MgDirectoryAdministrativeUnitExtension.md)
The collection of open extensions defined for this administrative unit.
Nullable.

### [New-MgDirectoryAdministrativeUnitMemberByRef](New-MgDirectoryAdministrativeUnitMemberByRef.md)
Users and groups that are members of this administrative unit.
Supports $expand.

### [New-MgDirectoryAdministrativeUnitScopedRoleMember](New-MgDirectoryAdministrativeUnitScopedRoleMember.md)
Scoped-role members of this administrative unit.

### [New-MgDirectoryDeletedItem](New-MgDirectoryDeletedItem.md)
Recently deleted items.
Read-only.
Nullable.

### [New-MgDirectoryRole](New-MgDirectoryRole.md)
Add new entity to directoryRoles

### [New-MgDirectoryRoleMemberByRef](New-MgDirectoryRoleMemberByRef.md)
Users that are members of this directory role.
HTTP Methods: GET, POST, DELETE.
Read-only.
Nullable.
Supports $expand.

### [New-MgDirectoryRoleScopedMember](New-MgDirectoryRoleScopedMember.md)
Members of this directory role that are scoped to administrative units.
Read-only.
Nullable.

### [New-MgDirectoryRoleTemplate](New-MgDirectoryRoleTemplate.md)
Add new entity to directoryRoleTemplates

### [New-MgDomain](New-MgDomain.md)
Add new entity to domains

### [New-MgDomainDomainNameReferenceByRef](New-MgDomainDomainNameReferenceByRef.md)
Read-only, Nullable

### [New-MgDomainServiceConfigurationRecord](New-MgDomainServiceConfigurationRecord.md)
DNS records the customer adds to the DNS zone file of the domain before the domain can be used by Microsoft Online services.
Read-only, Nullable

### [New-MgDomainVerificationDnsRecord](New-MgDomainVerificationDnsRecord.md)
DNS records that the customer adds to the DNS zone file of the domain before the customer can complete domain ownership verification with Azure AD.
Read-only, Nullable

### [New-MgOrganization](New-MgOrganization.md)
Add new entity to organization

### [New-MgOrganizationExtension](New-MgOrganizationExtension.md)
The collection of open extensions defined for the organization.
Read-only.
Nullable.

### [New-MgSubscribedSku](New-MgSubscribedSku.md)
Add new entity to subscribedSkus

### [New-MgUserScopedRoleMemberOf](New-MgUserScopedRoleMemberOf.md)
The scoped-role administrative unit memberships for this user.
Read-only.
Nullable.

### [Remove-MgContact](Remove-MgContact.md)
Delete entity from contacts

### [Remove-MgContactManagerByRef](Remove-MgContactManagerByRef.md)
The user or contact that is this contact's manager.
Read-only.
Supports $expand.

### [Remove-MgContract](Remove-MgContract.md)
Delete entity from contracts

### [Remove-MgDevice](Remove-MgDevice.md)
Delete entity from devices

### [Remove-MgDeviceExtension](Remove-MgDeviceExtension.md)
The collection of open extensions defined for the device.
Read-only.
Nullable.

### [Remove-MgDirectoryAdministrativeUnit](Remove-MgDirectoryAdministrativeUnit.md)
Conceptual container for user and group directory objects.

### [Remove-MgDirectoryAdministrativeUnitExtension](Remove-MgDirectoryAdministrativeUnitExtension.md)
The collection of open extensions defined for this administrative unit.
Nullable.

### [Remove-MgDirectoryAdministrativeUnitScopedRoleMember](Remove-MgDirectoryAdministrativeUnitScopedRoleMember.md)
Scoped-role members of this administrative unit.

### [Remove-MgDirectoryDeletedItem](Remove-MgDirectoryDeletedItem.md)
Recently deleted items.
Read-only.
Nullable.

### [Remove-MgDirectoryRole](Remove-MgDirectoryRole.md)
Delete entity from directoryRoles

### [Remove-MgDirectoryRoleScopedMember](Remove-MgDirectoryRoleScopedMember.md)
Members of this directory role that are scoped to administrative units.
Read-only.
Nullable.

### [Remove-MgDirectoryRoleTemplate](Remove-MgDirectoryRoleTemplate.md)
Delete entity from directoryRoleTemplates

### [Remove-MgDomain](Remove-MgDomain.md)
Delete entity from domains

### [Remove-MgDomainServiceConfigurationRecord](Remove-MgDomainServiceConfigurationRecord.md)
DNS records the customer adds to the DNS zone file of the domain before the domain can be used by Microsoft Online services.
Read-only, Nullable

### [Remove-MgDomainVerificationDnsRecord](Remove-MgDomainVerificationDnsRecord.md)
DNS records that the customer adds to the DNS zone file of the domain before the customer can complete domain ownership verification with Azure AD.
Read-only, Nullable

### [Remove-MgOrganization](Remove-MgOrganization.md)
Delete entity from organization

### [Remove-MgOrganizationBranding](Remove-MgOrganizationBranding.md)
Delete navigation property branding for organization

### [Remove-MgOrganizationExtension](Remove-MgOrganizationExtension.md)
The collection of open extensions defined for the organization.
Read-only.
Nullable.

### [Remove-MgSubscribedSku](Remove-MgSubscribedSku.md)
Delete entity from subscribedSkus

### [Remove-MgUserScopedRoleMemberOf](Remove-MgUserScopedRoleMemberOf.md)
The scoped-role administrative unit memberships for this user.
Read-only.
Nullable.

### [Restore-MgContact](Restore-MgContact.md)
Invoke action restore

### [Restore-MgContract](Restore-MgContract.md)
Invoke action restore

### [Restore-MgDevice](Restore-MgDevice.md)
Invoke action restore

### [Restore-MgDirectoryRole](Restore-MgDirectoryRole.md)
Invoke action restore

### [Restore-MgDirectoryRoleTemplate](Restore-MgDirectoryRoleTemplate.md)
Invoke action restore

### [Restore-MgOrganization](Restore-MgOrganization.md)
Invoke action restore

### [Set-MgContactManagerByRef](Set-MgContactManagerByRef.md)
The user or contact that is this contact's manager.
Read-only.
Supports $expand.

### [Set-MgOrganizationMobileDeviceManagementAuthority](Set-MgOrganizationMobileDeviceManagementAuthority.md)
Set mobile device management authority

### [Test-MgContactProperty](Test-MgContactProperty.md)
Invoke action validateProperties

### [Test-MgContractProperty](Test-MgContractProperty.md)
Invoke action validateProperties

### [Test-MgDeviceProperty](Test-MgDeviceProperty.md)
Invoke action validateProperties

### [Test-MgDirectoryRoleProperty](Test-MgDirectoryRoleProperty.md)
Invoke action validateProperties

### [Test-MgDirectoryRoleTemplateProperty](Test-MgDirectoryRoleTemplateProperty.md)
Invoke action validateProperties

### [Test-MgOrganizationProperty](Test-MgOrganizationProperty.md)
Invoke action validateProperties

### [Update-MgContact](Update-MgContact.md)
Update entity in contacts

### [Update-MgContract](Update-MgContract.md)
Update entity in contracts

### [Update-MgDevice](Update-MgDevice.md)
Update entity in devices

### [Update-MgDeviceExtension](Update-MgDeviceExtension.md)
The collection of open extensions defined for the device.
Read-only.
Nullable.

### [Update-MgDirectory](Update-MgDirectory.md)
Update directory

### [Update-MgDirectoryAdministrativeUnit](Update-MgDirectoryAdministrativeUnit.md)
Conceptual container for user and group directory objects.

### [Update-MgDirectoryAdministrativeUnitExtension](Update-MgDirectoryAdministrativeUnitExtension.md)
The collection of open extensions defined for this administrative unit.
Nullable.

### [Update-MgDirectoryAdministrativeUnitScopedRoleMember](Update-MgDirectoryAdministrativeUnitScopedRoleMember.md)
Scoped-role members of this administrative unit.

### [Update-MgDirectoryDeletedItem](Update-MgDirectoryDeletedItem.md)
Recently deleted items.
Read-only.
Nullable.

### [Update-MgDirectoryRole](Update-MgDirectoryRole.md)
Update entity in directoryRoles

### [Update-MgDirectoryRoleScopedMember](Update-MgDirectoryRoleScopedMember.md)
Members of this directory role that are scoped to administrative units.
Read-only.
Nullable.

### [Update-MgDirectoryRoleTemplate](Update-MgDirectoryRoleTemplate.md)
Update entity in directoryRoleTemplates

### [Update-MgDomain](Update-MgDomain.md)
Update entity in domains

### [Update-MgDomainServiceConfigurationRecord](Update-MgDomainServiceConfigurationRecord.md)
DNS records the customer adds to the DNS zone file of the domain before the domain can be used by Microsoft Online services.
Read-only, Nullable

### [Update-MgDomainVerificationDnsRecord](Update-MgDomainVerificationDnsRecord.md)
DNS records that the customer adds to the DNS zone file of the domain before the customer can complete domain ownership verification with Azure AD.
Read-only, Nullable

### [Update-MgOrganization](Update-MgOrganization.md)
Update entity in organization

### [Update-MgOrganizationBranding](Update-MgOrganizationBranding.md)
Update the navigation property branding in organization

### [Update-MgOrganizationExtension](Update-MgOrganizationExtension.md)
The collection of open extensions defined for the organization.
Read-only.
Nullable.

### [Update-MgSubscribedSku](Update-MgSubscribedSku.md)
Update entity in subscribedSkus

### [Update-MgUserScopedRoleMemberOf](Update-MgUserScopedRoleMemberOf.md)
The scoped-role administrative unit memberships for this user.
Read-only.
Nullable.

