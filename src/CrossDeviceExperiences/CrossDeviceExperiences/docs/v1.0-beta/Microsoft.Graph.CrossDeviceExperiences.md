---
Module Name: Microsoft.Graph.CrossDeviceExperiences
Module Guid: ecb0edba-8f48-42f8-9820-509a300b77e6
Download Help Link: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.crossdeviceexperiences
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.CrossDeviceExperiences Module
## Description
Microsoft Graph PowerShell Cmdlets

## Microsoft.Graph.CrossDeviceExperiences Cmdlets
### [Get-MgUserActivity](Get-MgUserActivity.md)
Get activities from users

### [Get-MgUserActivityHistoryItem](Get-MgUserActivityHistoryItem.md)
Get historyItems from users

### [Get-MgUserActivityHistoryItemActivity](Get-MgUserActivityHistoryItemActivity.md)
Get activity from users

### [Get-MgUserDevice](Get-MgUserDevice.md)
Get devices from users

### [Get-MgUserDeviceCommand](Get-MgUserDeviceCommand.md)
Set of commands sent to this device.

### [Get-MgUserDeviceCommandResponsepayload](Get-MgUserDeviceCommandResponsepayload.md)
Get responsepayload from users

### [Get-MgUserDeviceExtension](Get-MgUserDeviceExtension.md)
The collection of open extensions defined for the device.
Read-only.
Nullable.

### [Get-MgUserDeviceMemberOf](Get-MgUserDeviceMemberOf.md)
Groups and administrative units that this device is a member of.
Read-only.
Nullable.
Supports $expand.

### [Get-MgUserDeviceRegisteredOwner](Get-MgUserDeviceRegisteredOwner.md)
The user that cloud joined the device or registered their personal device.
The registered owner is set at the time of registration.
Currently, there can be only one owner.
Read-only.
Nullable.
Supports $expand.

### [Get-MgUserDeviceRegisteredOwnerByRef](Get-MgUserDeviceRegisteredOwnerByRef.md)
The user that cloud joined the device or registered their personal device.
The registered owner is set at the time of registration.
Currently, there can be only one owner.
Read-only.
Nullable.
Supports $expand.

### [Get-MgUserDeviceRegisteredUser](Get-MgUserDeviceRegisteredUser.md)
Collection of registered users of the device.
For cloud joined devices and registered personal devices, registered users are set to the same value as registered owners at the time of registration.
Read-only.
Nullable.
Supports $expand.

### [Get-MgUserDeviceRegisteredUserByRef](Get-MgUserDeviceRegisteredUserByRef.md)
Collection of registered users of the device.
For cloud joined devices and registered personal devices, registered users are set to the same value as registered owners at the time of registration.
Read-only.
Nullable.
Supports $expand.

### [Get-MgUserDeviceTransitiveMemberOf](Get-MgUserDeviceTransitiveMemberOf.md)
Groups and administrative units that this device is a member of.
This operation is transitive.
Supports $expand.

### [Get-MgUserDeviceUsageRights](Get-MgUserDeviceUsageRights.md)
Represents the usage rights a device has been granted.

### [Group-MgUserDeviceGetMemberOfAs](Group-MgUserDeviceGetMemberOfAs.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.group

### [Group-MgUserDeviceGetTransitiveMemberOfAs](Group-MgUserDeviceGetTransitiveMemberOfAs.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.group

### [Group-MgUserDeviceListMemberOfAs](Group-MgUserDeviceListMemberOfAs.md)
Get the items of type microsoft.graph.group in the microsoft.graph.directoryObject collection

### [Group-MgUserDeviceListTransitiveMemberOfAs](Group-MgUserDeviceListTransitiveMemberOfAs.md)
Get the items of type microsoft.graph.group in the microsoft.graph.directoryObject collection

### [Invoke-MgAsUserDeviceGetMemberOfAdministrativeUnit](Invoke-MgAsUserDeviceGetMemberOfAdministrativeUnit.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.administrativeUnit

### [Invoke-MgAsUserDeviceGetRegisteredOwnerEndpoint](Invoke-MgAsUserDeviceGetRegisteredOwnerEndpoint.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.endpoint

### [Invoke-MgAsUserDeviceGetRegisteredOwnerUser](Invoke-MgAsUserDeviceGetRegisteredOwnerUser.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.user

### [Invoke-MgAsUserDeviceGetRegisteredUser](Invoke-MgAsUserDeviceGetRegisteredUser.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.user

### [Invoke-MgAsUserDeviceGetRegisteredUserEndpoint](Invoke-MgAsUserDeviceGetRegisteredUserEndpoint.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.endpoint

### [Invoke-MgAsUserDeviceGetTransitiveMemberOfAdministrativeUnit](Invoke-MgAsUserDeviceGetTransitiveMemberOfAdministrativeUnit.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.administrativeUnit

### [Invoke-MgAsUserDeviceListMemberOfAdministrativeUnit](Invoke-MgAsUserDeviceListMemberOfAdministrativeUnit.md)
Get the items of type microsoft.graph.administrativeUnit in the microsoft.graph.directoryObject collection

### [Invoke-MgAsUserDeviceListRegisteredOwnerEndpoint](Invoke-MgAsUserDeviceListRegisteredOwnerEndpoint.md)
Get the items of type microsoft.graph.endpoint in the microsoft.graph.directoryObject collection

### [Invoke-MgAsUserDeviceListRegisteredOwnerUser](Invoke-MgAsUserDeviceListRegisteredOwnerUser.md)
Get the items of type microsoft.graph.user in the microsoft.graph.directoryObject collection

### [Invoke-MgAsUserDeviceListRegisteredUser](Invoke-MgAsUserDeviceListRegisteredUser.md)
Get the items of type microsoft.graph.user in the microsoft.graph.directoryObject collection

### [Invoke-MgAsUserDeviceListRegisteredUserEndpoint](Invoke-MgAsUserDeviceListRegisteredUserEndpoint.md)
Get the items of type microsoft.graph.endpoint in the microsoft.graph.directoryObject collection

### [Invoke-MgAsUserDeviceListTransitiveMemberOfAdministrativeUnit](Invoke-MgAsUserDeviceListTransitiveMemberOfAdministrativeUnit.md)
Get the items of type microsoft.graph.administrativeUnit in the microsoft.graph.directoryObject collection

### [Invoke-MgServiceUserDeviceGetRegisteredOwner](Invoke-MgServiceUserDeviceGetRegisteredOwner.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.servicePrincipal

### [Invoke-MgServiceUserDeviceGetRegisteredUser](Invoke-MgServiceUserDeviceGetRegisteredUser.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.servicePrincipal

### [Invoke-MgServiceUserDeviceListRegisteredOwner](Invoke-MgServiceUserDeviceListRegisteredOwner.md)
Get the items of type microsoft.graph.servicePrincipal in the microsoft.graph.directoryObject collection

### [Invoke-MgServiceUserDeviceListRegisteredUser](Invoke-MgServiceUserDeviceListRegisteredUser.md)
Get the items of type microsoft.graph.servicePrincipal in the microsoft.graph.directoryObject collection

### [New-MgUserActivity](New-MgUserActivity.md)
Create new navigation property to activities for users

### [New-MgUserActivityHistoryItem](New-MgUserActivityHistoryItem.md)
Create new navigation property to historyItems for users

### [New-MgUserDevice](New-MgUserDevice.md)
Create new navigation property to devices for users

### [New-MgUserDeviceCommand](New-MgUserDeviceCommand.md)
Create new navigation property to commands for users

### [New-MgUserDeviceExtension](New-MgUserDeviceExtension.md)
Create new navigation property to extensions for users

### [New-MgUserDeviceRegisteredOwnerByRef](New-MgUserDeviceRegisteredOwnerByRef.md)
Create new navigation property ref to registeredOwners for users

### [New-MgUserDeviceRegisteredUserByRef](New-MgUserDeviceRegisteredUserByRef.md)
Create new navigation property ref to registeredUsers for users

### [New-MgUserDeviceUsageRights](New-MgUserDeviceUsageRights.md)
Create new navigation property to usageRights for users

### [Remove-MgUserActivity](Remove-MgUserActivity.md)
Delete navigation property activities for users

### [Remove-MgUserActivityHistoryItem](Remove-MgUserActivityHistoryItem.md)
Delete navigation property historyItems for users

### [Remove-MgUserDevice](Remove-MgUserDevice.md)
Delete navigation property devices for users

### [Remove-MgUserDeviceCommand](Remove-MgUserDeviceCommand.md)
Delete navigation property commands for users

### [Remove-MgUserDeviceExtension](Remove-MgUserDeviceExtension.md)
Delete navigation property extensions for users

### [Remove-MgUserDeviceRegisteredOwnerByRef](Remove-MgUserDeviceRegisteredOwnerByRef.md)
Delete ref of navigation property registeredOwners for users

### [Remove-MgUserDeviceRegisteredUserByRef](Remove-MgUserDeviceRegisteredUserByRef.md)
Delete ref of navigation property registeredUsers for users

### [Remove-MgUserDeviceUsageRights](Remove-MgUserDeviceUsageRights.md)
Delete navigation property usageRights for users

### [Update-MgUserActivity](Update-MgUserActivity.md)
Update the navigation property activities in users

### [Update-MgUserActivityHistoryItem](Update-MgUserActivityHistoryItem.md)
Update the navigation property historyItems in users

### [Update-MgUserDevice](Update-MgUserDevice.md)
Update the navigation property devices in users

### [Update-MgUserDeviceCommand](Update-MgUserDeviceCommand.md)
Update the navigation property commands in users

### [Update-MgUserDeviceExtension](Update-MgUserDeviceExtension.md)
Update the navigation property extensions in users

### [Update-MgUserDeviceUsageRights](Update-MgUserDeviceUsageRights.md)
Update the navigation property usageRights in users

