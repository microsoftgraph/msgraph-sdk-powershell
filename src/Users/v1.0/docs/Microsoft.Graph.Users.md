---
Module Name: Microsoft.Graph.Users
Module Guid: 9b210578-ba4f-4989-94d8-99e27cefac72
Download Help Link: https://learn.microsoft.com/powershell/module/microsoft.graph.users
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Users Module
## Description
Microsoft Graph PowerShell Cmdlets

## Microsoft.Graph.Users Cmdlets
### [Get-MgUser](Get-MgUser.md)
Read properties and relationships of the user object.

### [Get-MgUserCount](Get-MgUserCount.md)
Get the number of the resource

### [Get-MgUserCreatedObject](Get-MgUserCreatedObject.md)
Directory objects that the user created.
Read-only.
Nullable.

### [Get-MgUserCreatedObjectAsServicePrincipal](Get-MgUserCreatedObjectAsServicePrincipal.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.servicePrincipal

### [Get-MgUserCreatedObjectCount](Get-MgUserCreatedObjectCount.md)
Get the number of the resource

### [Get-MgUserCreatedObjectCountAsServicePrincipal](Get-MgUserCreatedObjectCountAsServicePrincipal.md)
Get the number of the resource

### [Get-MgUserDirectReport](Get-MgUserDirectReport.md)
The users and contacts that report to the user.
(The users and contacts that have their manager property set to this user.) Read-only.
Nullable.
Supports $expand.

### [Get-MgUserDirectReportAsOrgContact](Get-MgUserDirectReportAsOrgContact.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.orgContact

### [Get-MgUserDirectReportAsUser](Get-MgUserDirectReportAsUser.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.user

### [Get-MgUserDirectReportCount](Get-MgUserDirectReportCount.md)
Get the number of the resource

### [Get-MgUserDirectReportCountAsOrgContact](Get-MgUserDirectReportCountAsOrgContact.md)
Get the number of the resource

### [Get-MgUserDirectReportCountAsUser](Get-MgUserDirectReportCountAsUser.md)
Get the number of the resource

### [Get-MgUserExtension](Get-MgUserExtension.md)
The collection of open extensions defined for the user.
Read-only.
Supports $expand.
Nullable.

### [Get-MgUserExtensionCount](Get-MgUserExtensionCount.md)
Get the number of the resource

### [Get-MgUserLicenseDetail](Get-MgUserLicenseDetail.md)
A collection of this user's license details.
Read-only.

### [Get-MgUserLicenseDetailCount](Get-MgUserLicenseDetailCount.md)
Get the number of the resource

### [Get-MgUserMailboxSetting](Get-MgUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
Returned only on $select.

### [Get-MgUserManager](Get-MgUserManager.md)
Returns the user or organizational contact assigned as the user's manager.
Optionally, you can expand the manager's chain up to the root node.

### [Get-MgUserManagerByRef](Get-MgUserManagerByRef.md)
Returns the user or organizational contact assigned as the user's manager.
Optionally, you can expand the manager's chain up to the root node.

### [Get-MgUserMemberOf](Get-MgUserMemberOf.md)
The groups and directory roles that the user is a member of.
Read-only.
Nullable.
Supports $expand.

### [Get-MgUserMemberOfAsAdministrativeUnit](Get-MgUserMemberOfAsAdministrativeUnit.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.administrativeUnit

### [Get-MgUserMemberOfAsDirectoryRole](Get-MgUserMemberOfAsDirectoryRole.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.directoryRole

### [Get-MgUserMemberOfAsGroup](Get-MgUserMemberOfAsGroup.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.group

### [Get-MgUserMemberOfCount](Get-MgUserMemberOfCount.md)
Get the number of the resource

### [Get-MgUserMemberOfCountAsAdministrativeUnit](Get-MgUserMemberOfCountAsAdministrativeUnit.md)
Get the number of the resource

### [Get-MgUserMemberOfCountAsDirectoryRole](Get-MgUserMemberOfCountAsDirectoryRole.md)
Get the number of the resource

### [Get-MgUserMemberOfCountAsGroup](Get-MgUserMemberOfCountAsGroup.md)
Get the number of the resource

### [Get-MgUserOauth2PermissionGrant](Get-MgUserOauth2PermissionGrant.md)
Get oauth2PermissionGrants from users

### [Get-MgUserOauth2PermissionGrantCount](Get-MgUserOauth2PermissionGrantCount.md)
Get the number of the resource

### [Get-MgUserOutlookMasterCategory](Get-MgUserOutlookMasterCategory.md)
Get the properties and relationships of the specified outlookCategory object.

### [Get-MgUserOutlookMasterCategoryCount](Get-MgUserOutlookMasterCategoryCount.md)
Get the number of the resource

### [Get-MgUserOwnedDevice](Get-MgUserOwnedDevice.md)
Devices that are owned by the user.
Read-only.
Nullable.
Supports $expand and $filter (/$count eq 0, /$count ne 0, /$count eq 1, /$count ne 1).

### [Get-MgUserOwnedDeviceAsAppRoleAssignment](Get-MgUserOwnedDeviceAsAppRoleAssignment.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.appRoleAssignment

### [Get-MgUserOwnedDeviceAsDevice](Get-MgUserOwnedDeviceAsDevice.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.device

### [Get-MgUserOwnedDeviceAsEndpoint](Get-MgUserOwnedDeviceAsEndpoint.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.endpoint

### [Get-MgUserOwnedDeviceCount](Get-MgUserOwnedDeviceCount.md)
Get the number of the resource

### [Get-MgUserOwnedDeviceCountAsAppRoleAssignment](Get-MgUserOwnedDeviceCountAsAppRoleAssignment.md)
Get the number of the resource

### [Get-MgUserOwnedDeviceCountAsDevice](Get-MgUserOwnedDeviceCountAsDevice.md)
Get the number of the resource

### [Get-MgUserOwnedDeviceCountAsEndpoint](Get-MgUserOwnedDeviceCountAsEndpoint.md)
Get the number of the resource

### [Get-MgUserOwnedObject](Get-MgUserOwnedObject.md)
Directory objects that are owned by the user.
Read-only.
Nullable.
Supports $expand, $select nested in $expand, and $filter (/$count eq 0, /$count ne 0, /$count eq 1, /$count ne 1).

### [Get-MgUserOwnedObjectAsApplication](Get-MgUserOwnedObjectAsApplication.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.application

### [Get-MgUserOwnedObjectAsGroup](Get-MgUserOwnedObjectAsGroup.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.group

### [Get-MgUserOwnedObjectAsServicePrincipal](Get-MgUserOwnedObjectAsServicePrincipal.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.servicePrincipal

### [Get-MgUserOwnedObjectCount](Get-MgUserOwnedObjectCount.md)
Get the number of the resource

### [Get-MgUserOwnedObjectCountAsApplication](Get-MgUserOwnedObjectCountAsApplication.md)
Get the number of the resource

### [Get-MgUserOwnedObjectCountAsGroup](Get-MgUserOwnedObjectCountAsGroup.md)
Get the number of the resource

### [Get-MgUserOwnedObjectCountAsServicePrincipal](Get-MgUserOwnedObjectCountAsServicePrincipal.md)
Get the number of the resource

### [Get-MgUserPhoto](Get-MgUserPhoto.md)
Get the specified profilePhoto or its metadata (profilePhoto properties).
The supported sizes of HD photos on Microsoft 365 are as follows: 48x48, 64x64, 96x96, 120x120, 240x240,\n360x360, 432x432, 504x504, and 648x648.
Photos can be any dimension if they're stored in Microsoft Entra ID.
You can get the metadata of the largest available photo or specify a size to get the metadata for that photo size.\nIf the size you request is unavailable, you can still get a smaller size that the user has uploaded and made available.\nFor example, if the user uploads a photo that is 504x504 pixels, all but the 648x648 size of the photo is available for download.

### [Get-MgUserPhotoContent](Get-MgUserPhotoContent.md)
Get media content for the navigation property photo from users

### [Get-MgUserRegisteredDevice](Get-MgUserRegisteredDevice.md)
Devices that are registered for the user.
Read-only.
Nullable.
Supports $expand and returns up to 100 objects.

### [Get-MgUserRegisteredDeviceAsAppRoleAssignment](Get-MgUserRegisteredDeviceAsAppRoleAssignment.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.appRoleAssignment

### [Get-MgUserRegisteredDeviceAsDevice](Get-MgUserRegisteredDeviceAsDevice.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.device

### [Get-MgUserRegisteredDeviceAsEndpoint](Get-MgUserRegisteredDeviceAsEndpoint.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.endpoint

### [Get-MgUserRegisteredDeviceCount](Get-MgUserRegisteredDeviceCount.md)
Get the number of the resource

### [Get-MgUserRegisteredDeviceCountAsAppRoleAssignment](Get-MgUserRegisteredDeviceCountAsAppRoleAssignment.md)
Get the number of the resource

### [Get-MgUserRegisteredDeviceCountAsDevice](Get-MgUserRegisteredDeviceCountAsDevice.md)
Get the number of the resource

### [Get-MgUserRegisteredDeviceCountAsEndpoint](Get-MgUserRegisteredDeviceCountAsEndpoint.md)
Get the number of the resource

### [Get-MgUserSetting](Get-MgUserSetting.md)
Read the user and organization userSettings object.\nTo learn how to update the properties of the userSettings object, see update user settings.

### [Get-MgUserSettingShiftPreference](Get-MgUserSettingShiftPreference.md)
Retrieve the properties and relationships of a shiftPreferences object by ID.

### [Get-MgUserSettingWindows](Get-MgUserSettingWindows.md)
Read the properties and relationships of a windowsSetting object by passing the ID of the setting in the URL.
This method gets the setting for the signed-in user.

### [Get-MgUserSettingWindowsCount](Get-MgUserSettingWindowsCount.md)
Get the number of the resource

### [Get-MgUserSettingWindowsInstance](Get-MgUserSettingWindowsInstance.md)
Read the properties and relationships of a windowsSettingInstance object by passing the Windows setting ID and Windows setting instance ID in the URL.
This method gets a windowsSettingInstance for the signed-in user.

### [Get-MgUserSettingWindowsInstanceCount](Get-MgUserSettingWindowsInstanceCount.md)
Get the number of the resource

### [Get-MgUserSponsor](Get-MgUserSponsor.md)
The users and groups responsible for this guest user's privileges in the tenant and keep the guest user's information and access updated.
(HTTP Methods: GET, POST, DELETE.).
Supports $expand.

### [Get-MgUserSponsorCount](Get-MgUserSponsorCount.md)
Get the number of the resource

### [Get-MgUserTodoList](Get-MgUserTodoList.md)
Read the properties and relationships of a todoTaskList object.

### [Get-MgUserTodoListCount](Get-MgUserTodoListCount.md)
Get the number of the resource

### [Get-MgUserTodoListExtension](Get-MgUserTodoListExtension.md)
The collection of open extensions defined for the task list.
Nullable.

### [Get-MgUserTodoListExtensionCount](Get-MgUserTodoListExtensionCount.md)
Get the number of the resource

### [Get-MgUserTodoTask](Get-MgUserTodoTask.md)
Read the properties and relationships of a todoTask object.

### [Get-MgUserTodoTaskAttachment](Get-MgUserTodoTaskAttachment.md)
Read the properties and relationships of a taskFileAttachment object.

### [Get-MgUserTodoTaskAttachmentContent](Get-MgUserTodoTaskAttachmentContent.md)
Get media content for the navigation property attachments from users

### [Get-MgUserTodoTaskAttachmentCount](Get-MgUserTodoTaskAttachmentCount.md)
Get the number of the resource

### [Get-MgUserTodoTaskAttachmentSession](Get-MgUserTodoTaskAttachmentSession.md)
Get attachmentSessions from users

### [Get-MgUserTodoTaskAttachmentSessionContent](Get-MgUserTodoTaskAttachmentSessionContent.md)
The content streams that are uploaded.

### [Get-MgUserTodoTaskAttachmentSessionCount](Get-MgUserTodoTaskAttachmentSessionCount.md)
Get the number of the resource

### [Get-MgUserTodoTaskChecklistItem](Get-MgUserTodoTaskChecklistItem.md)
Read the properties and relationships of a checklistItem object.

### [Get-MgUserTodoTaskChecklistItemCount](Get-MgUserTodoTaskChecklistItemCount.md)
Get the number of the resource

### [Get-MgUserTodoTaskCount](Get-MgUserTodoTaskCount.md)
Get the number of the resource

### [Get-MgUserTodoTaskExtension](Get-MgUserTodoTaskExtension.md)
The collection of open extensions defined for the task.
Nullable.

### [Get-MgUserTodoTaskExtensionCount](Get-MgUserTodoTaskExtensionCount.md)
Get the number of the resource

### [Get-MgUserTodoTaskLinkedResource](Get-MgUserTodoTaskLinkedResource.md)
Read the properties and relationships of a linkedResource object.

### [Get-MgUserTodoTaskLinkedResourceCount](Get-MgUserTodoTaskLinkedResourceCount.md)
Get the number of the resource

### [Get-MgUserTransitiveMemberOf](Get-MgUserTransitiveMemberOf.md)
The groups, including nested groups, and directory roles that a user is a member of.
Nullable.

### [Get-MgUserTransitiveMemberOfAsAdministrativeUnit](Get-MgUserTransitiveMemberOfAsAdministrativeUnit.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.administrativeUnit

### [Get-MgUserTransitiveMemberOfAsDirectoryRole](Get-MgUserTransitiveMemberOfAsDirectoryRole.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.directoryRole

### [Get-MgUserTransitiveMemberOfAsGroup](Get-MgUserTransitiveMemberOfAsGroup.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.group

### [Get-MgUserTransitiveMemberOfCount](Get-MgUserTransitiveMemberOfCount.md)
Get the number of the resource

### [Get-MgUserTransitiveMemberOfCountAsAdministrativeUnit](Get-MgUserTransitiveMemberOfCountAsAdministrativeUnit.md)
Get the number of the resource

### [Get-MgUserTransitiveMemberOfCountAsDirectoryRole](Get-MgUserTransitiveMemberOfCountAsDirectoryRole.md)
Get the number of the resource

### [Get-MgUserTransitiveMemberOfCountAsGroup](Get-MgUserTransitiveMemberOfCountAsGroup.md)
Get the number of the resource

### [New-MgUser](New-MgUser.md)
Create a new user object.

### [New-MgUserExtension](New-MgUserExtension.md)
Create new navigation property to extensions for users

### [New-MgUserOutlookMasterCategory](New-MgUserOutlookMasterCategory.md)
Create an outlookCategory object in the user's master list of categories.

### [New-MgUserSettingWindows](New-MgUserSettingWindows.md)
Create new navigation property to windows for users

### [New-MgUserSettingWindowsInstance](New-MgUserSettingWindowsInstance.md)
Create new navigation property to instances for users

### [New-MgUserTodoList](New-MgUserTodoList.md)
Create a new lists object.

### [New-MgUserTodoListExtension](New-MgUserTodoListExtension.md)
Create new navigation property to extensions for users

### [New-MgUserTodoListTask](New-MgUserTodoListTask.md)
Create a new task object in a specified todoTaskList.

### [New-MgUserTodoListTaskAttachment](New-MgUserTodoListTaskAttachment.md)
Add a new taskFileAttachment object to a todoTask.
This operation limits the size of the attachment you can add to under 3 MB.
If the size of the file attachments is more than 3 MB, create an upload session to upload the attachments.

### [New-MgUserTodoListTaskChecklistItem](New-MgUserTodoListTaskChecklistItem.md)
Create a new checklistItem object.

### [New-MgUserTodoListTaskExtension](New-MgUserTodoListTaskExtension.md)
Create new navigation property to extensions for users

### [New-MgUserTodoListTaskLinkedResource](New-MgUserTodoListTaskLinkedResource.md)
Create a linkedResource object to associate a specified task with an item in a partner application.
For example, you can associate a task with an email item in Outlook that spurred the task, and you can create a linkedResource object to track its association.
You can also create a linkedResource object while creating a task.

### [Remove-MgUser](Remove-MgUser.md)
Delete user.
 When deleted, user resources are moved to a temporary container and can be restored within 30 days.
After that time, they are permanently deleted.
To learn more, see deletedItems.

### [Remove-MgUserExtension](Remove-MgUserExtension.md)
Delete navigation property extensions for users

### [Remove-MgUserLicenseDetail](Remove-MgUserLicenseDetail.md)
Delete navigation property licenseDetails for users

### [Remove-MgUserManagerByRef](Remove-MgUserManagerByRef.md)
Remove a user's manager.

### [Remove-MgUserOutlookMasterCategory](Remove-MgUserOutlookMasterCategory.md)
Delete the specified outlookCategory object.

### [Remove-MgUserPhoto](Remove-MgUserPhoto.md)
Delete navigation property photo for users

### [Remove-MgUserSetting](Remove-MgUserSetting.md)
Delete navigation property settings for users

### [Remove-MgUserSettingShiftPreference](Remove-MgUserSettingShiftPreference.md)
Delete navigation property shiftPreferences for users

### [Remove-MgUserSettingWindows](Remove-MgUserSettingWindows.md)
Delete navigation property windows for users

### [Remove-MgUserSettingWindowsInstance](Remove-MgUserSettingWindowsInstance.md)
Delete navigation property instances for users

### [Remove-MgUserTodoList](Remove-MgUserTodoList.md)
Deletes a todoTaskList object.

### [Remove-MgUserTodoListExtension](Remove-MgUserTodoListExtension.md)
Delete navigation property extensions for users

### [Remove-MgUserTodoListTask](Remove-MgUserTodoListTask.md)
Deletes a todoTask object.

### [Remove-MgUserTodoListTaskAttachment](Remove-MgUserTodoListTaskAttachment.md)
Delete a taskFileAttachment object from a todoTask resource.

### [Remove-MgUserTodoListTaskAttachmentSession](Remove-MgUserTodoListTaskAttachmentSession.md)
Delete navigation property attachmentSessions for users

### [Remove-MgUserTodoListTaskChecklistItem](Remove-MgUserTodoListTaskChecklistItem.md)
Delete a checklistItem object.

### [Remove-MgUserTodoListTaskExtension](Remove-MgUserTodoListTaskExtension.md)
Delete navigation property extensions for users

### [Remove-MgUserTodoListTaskLinkedResource](Remove-MgUserTodoListTaskLinkedResource.md)
Delete a linkedResource object.

### [Set-MgUserManagerByRef](Set-MgUserManagerByRef.md)
Assign a user's manager.

### [Set-MgUserPhotoContent](Set-MgUserPhotoContent.md)
Update media content for the navigation property photo in users

### [Set-MgUserTodoListTaskAttachmentContent](Set-MgUserTodoListTaskAttachmentContent.md)
Update media content for the navigation property attachments in users

### [Set-MgUserTodoListTaskAttachmentSessionContent](Set-MgUserTodoListTaskAttachmentSessionContent.md)
The content streams that are uploaded.

### [Update-MgUser](Update-MgUser.md)
Update the properties of a user object.
Not all properties can be updated by Member or Guest users with their default permissions without Administrator roles.
Compare member and guest default permissions to see properties they can manage.
Customers through Microsoft Entra ID for customers can also use this API operation to update their details.
See Default user permissions in customer tenants for the list of properties they can update.

### [Update-MgUserExtension](Update-MgUserExtension.md)
Update the navigation property extensions in users

### [Update-MgUserLicenseDetail](Update-MgUserLicenseDetail.md)
Update the navigation property licenseDetails in users

### [Update-MgUserMailboxSetting](Update-MgUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgUserOutlookMasterCategory](Update-MgUserOutlookMasterCategory.md)
Update the writable property, color, of the specified outlookCategory object.
You can't modify the displayName property once you have created the category.

### [Update-MgUserSetting](Update-MgUserSetting.md)
Update the properties of the userSettings object.
\nUsers in the same organization can have different settings based on their preference or on the organization policies.
\nTo get the user current settings, see current user settings.

### [Update-MgUserSettingShiftPreference](Update-MgUserSettingShiftPreference.md)
Update the properties and relationships of a shiftPreferences object.

### [Update-MgUserSettingWindows](Update-MgUserSettingWindows.md)
Update the navigation property windows in users

### [Update-MgUserSettingWindowsInstance](Update-MgUserSettingWindowsInstance.md)
Update the navigation property instances in users

### [Update-MgUserTodoList](Update-MgUserTodoList.md)
Update the properties of a todoTaskList object.

### [Update-MgUserTodoListExtension](Update-MgUserTodoListExtension.md)
Update the navigation property extensions in users

### [Update-MgUserTodoListTask](Update-MgUserTodoListTask.md)
Update the properties of a todoTask object.

### [Update-MgUserTodoListTaskAttachmentSession](Update-MgUserTodoListTaskAttachmentSession.md)
Update the navigation property attachmentSessions in users

### [Update-MgUserTodoListTaskChecklistItem](Update-MgUserTodoListTaskChecklistItem.md)
Update the properties of a checklistItem object.

### [Update-MgUserTodoListTaskExtension](Update-MgUserTodoListTaskExtension.md)
Update the navigation property extensions in users

### [Update-MgUserTodoListTaskLinkedResource](Update-MgUserTodoListTaskLinkedResource.md)
Update the properties of a linkedResource object.

