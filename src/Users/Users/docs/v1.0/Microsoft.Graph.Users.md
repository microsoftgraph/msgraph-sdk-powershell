---
Module Name: Microsoft.Graph.Users
Module Guid: 656d43d1-1e84-469c-89bd-29fb422ba9c6
Download Help Link: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.users
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Users Module
## Description
Microsoft Graph PowerShell Cmdlets

## Microsoft.Graph.Users Cmdlets
### [Get-MgUser](Get-MgUser.md)
Retrieve the properties and relationships of user object.

### [Get-MgUserCreatedObject](Get-MgUserCreatedObject.md)
Directory objects that were created by the user.
Read-only.
Nullable.

### [Get-MgUserDirectReport](Get-MgUserDirectReport.md)
The users and contacts that report to the user.
(The users and contacts that have their manager property set to this user.) Read-only.
Nullable.
Supports $expand.

### [Get-MgUserExtension](Get-MgUserExtension.md)
The collection of open extensions defined for the user.
Read-only.
Supports $expand.
Nullable.

### [Get-MgUserLicenseDetail](Get-MgUserLicenseDetail.md)
A collection of this user's license details.
Read-only.

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

### [Get-MgUserOauth2PermissionGrant](Get-MgUserOauth2PermissionGrant.md)
Get oauth2PermissionGrants from users

### [Get-MgUserOutlookMasterCategory](Get-MgUserOutlookMasterCategory.md)
A list of categories defined for the user.

### [Get-MgUserOwnedDevice](Get-MgUserOwnedDevice.md)
Devices that are owned by the user.
Read-only.
Nullable.
Supports $expand.

### [Get-MgUserOwnedObject](Get-MgUserOwnedObject.md)
Directory objects that are owned by the user.
Read-only.
Nullable.
Supports $expand.

### [Get-MgUserPhoto](Get-MgUserPhoto.md)
The user's profile photo.
Read-only.

### [Get-MgUserPhotoContent](Get-MgUserPhotoContent.md)
Get media content for the navigation property photo from users

### [Get-MgUserRegisteredDevice](Get-MgUserRegisteredDevice.md)
Devices that are registered for the user.
Read-only.
Nullable.
Supports $expand.

### [Get-MgUserSetting](Get-MgUserSetting.md)
Get settings from users

### [Get-MgUserSettingShiftPreference](Get-MgUserSettingShiftPreference.md)
Retrieve the properties and relationships of a shiftPreferences object by ID.

### [Get-MgUserTodoList](Get-MgUserTodoList.md)
The task lists in the users mailbox.

### [Get-MgUserTodoListExtension](Get-MgUserTodoListExtension.md)
The collection of open extensions defined for the task list.
Nullable.

### [Get-MgUserTodoListTask](Get-MgUserTodoListTask.md)
The tasks in this task list.
Read-only.
Nullable.

### [Get-MgUserTodoListTaskAttachment](Get-MgUserTodoListTaskAttachment.md)
Get attachments from users

### [Get-MgUserTodoListTaskAttachmentContent](Get-MgUserTodoListTaskAttachmentContent.md)
Get media content for the navigation property attachments from users

### [Get-MgUserTodoListTaskAttachmentSession](Get-MgUserTodoListTaskAttachmentSession.md)
Get attachmentSessions from users

### [Get-MgUserTodoListTaskAttachmentSessionContent](Get-MgUserTodoListTaskAttachmentSessionContent.md)
Get content for the navigation property attachmentSessions from users

### [Get-MgUserTodoListTaskChecklistItem](Get-MgUserTodoListTaskChecklistItem.md)
A collection of checklistItems linked to a task.

### [Get-MgUserTodoListTaskExtension](Get-MgUserTodoListTaskExtension.md)
The collection of open extensions defined for the task.
Nullable.

### [Get-MgUserTodoListTaskLinkedResource](Get-MgUserTodoListTaskLinkedResource.md)
A collection of resources linked to the task.

### [Get-MgUserTransitiveMemberOf](Get-MgUserTransitiveMemberOf.md)
The groups, including nested groups, and directory roles that a user is a member of.
Nullable.

### [New-MgUser](New-MgUser.md)
Create a new user.\nThe request body contains the user to create.
At a minimum, you must specify the required properties for the user.
You can optionally specify any other writable properties.

### [New-MgUserExtension](New-MgUserExtension.md)
Create new navigation property to extensions for users

### [New-MgUserOutlookMasterCategory](New-MgUserOutlookMasterCategory.md)
Create an outlookCategory object in the user's master list of categories.

### [New-MgUserTodoList](New-MgUserTodoList.md)
Create a new lists object.

### [New-MgUserTodoListExtension](New-MgUserTodoListExtension.md)
Create new navigation property to extensions for users

### [New-MgUserTodoListTask](New-MgUserTodoListTask.md)
Create a new task object in a specified todoTaskList.

### [New-MgUserTodoListTaskAttachment](New-MgUserTodoListTaskAttachment.md)
Create new navigation property to attachments for users

### [New-MgUserTodoListTaskChecklistItem](New-MgUserTodoListTaskChecklistItem.md)
Create new navigation property to checklistItems for users

### [New-MgUserTodoListTaskExtension](New-MgUserTodoListTaskExtension.md)
Create new navigation property to extensions for users

### [New-MgUserTodoListTaskLinkedResource](New-MgUserTodoListTaskLinkedResource.md)
Create a linkedResource object to associate a specified task with an item in a partner application.
For example, you can associate a task with an email item in Outlook that spurred the task, and you can create a **linkedResource** object to track its association.
You can also create a **linkedResource** object while creating a task.

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
Delete ref of navigation property manager for users

### [Remove-MgUserOutlookMasterCategory](Remove-MgUserOutlookMasterCategory.md)
Delete navigation property masterCategories for users

### [Remove-MgUserSetting](Remove-MgUserSetting.md)
Delete navigation property settings for users

### [Remove-MgUserSettingShiftPreference](Remove-MgUserSettingShiftPreference.md)
Delete navigation property shiftPreferences for users

### [Remove-MgUserTodoList](Remove-MgUserTodoList.md)
Delete navigation property lists for users

### [Remove-MgUserTodoListExtension](Remove-MgUserTodoListExtension.md)
Delete navigation property extensions for users

### [Remove-MgUserTodoListTask](Remove-MgUserTodoListTask.md)
Delete navigation property tasks for users

### [Remove-MgUserTodoListTaskAttachment](Remove-MgUserTodoListTaskAttachment.md)
Delete navigation property attachments for users

### [Remove-MgUserTodoListTaskAttachmentSession](Remove-MgUserTodoListTaskAttachmentSession.md)
Delete navigation property attachmentSessions for users

### [Remove-MgUserTodoListTaskChecklistItem](Remove-MgUserTodoListTaskChecklistItem.md)
Delete navigation property checklistItems for users

### [Remove-MgUserTodoListTaskExtension](Remove-MgUserTodoListTaskExtension.md)
Delete navigation property extensions for users

### [Remove-MgUserTodoListTaskLinkedResource](Remove-MgUserTodoListTaskLinkedResource.md)
Delete navigation property linkedResources for users

### [Set-MgUserManagerByRef](Set-MgUserManagerByRef.md)
Update the ref of navigation property manager in users

### [Set-MgUserPhotoContent](Set-MgUserPhotoContent.md)
Update media content for the navigation property photo in users

### [Set-MgUserTodoListTaskAttachmentContent](Set-MgUserTodoListTaskAttachmentContent.md)
Update media content for the navigation property attachments in users

### [Set-MgUserTodoListTaskAttachmentSessionContent](Set-MgUserTodoListTaskAttachmentSessionContent.md)
Update content for the navigation property attachmentSessions in users

### [Update-MgUser](Update-MgUser.md)
Update the properties of a user object.
Not all properties can be updated by Member or Guest users with their default permissions without Administrator roles.
Compare member and guest default permissions to see properties they can manage.

### [Update-MgUserExtension](Update-MgUserExtension.md)
Update the navigation property extensions in users

### [Update-MgUserLicenseDetail](Update-MgUserLicenseDetail.md)
Update the navigation property licenseDetails in users

### [Update-MgUserOutlookMasterCategory](Update-MgUserOutlookMasterCategory.md)
Update the navigation property masterCategories in users

### [Update-MgUserPhoto](Update-MgUserPhoto.md)
Update the navigation property photo in users

### [Update-MgUserSetting](Update-MgUserSetting.md)
Update the navigation property settings in users

### [Update-MgUserSettingShiftPreference](Update-MgUserSettingShiftPreference.md)
Update the properties and relationships of a shiftPreferences object.

### [Update-MgUserTodoList](Update-MgUserTodoList.md)
Update the navigation property lists in users

### [Update-MgUserTodoListExtension](Update-MgUserTodoListExtension.md)
Update the navigation property extensions in users

### [Update-MgUserTodoListTask](Update-MgUserTodoListTask.md)
Update the navigation property tasks in users

### [Update-MgUserTodoListTaskAttachmentSession](Update-MgUserTodoListTaskAttachmentSession.md)
Update the navigation property attachmentSessions in users

### [Update-MgUserTodoListTaskChecklistItem](Update-MgUserTodoListTaskChecklistItem.md)
Update the navigation property checklistItems in users

### [Update-MgUserTodoListTaskExtension](Update-MgUserTodoListTaskExtension.md)
Update the navigation property extensions in users

### [Update-MgUserTodoListTaskLinkedResource](Update-MgUserTodoListTaskLinkedResource.md)
Update the navigation property linkedResources in users

