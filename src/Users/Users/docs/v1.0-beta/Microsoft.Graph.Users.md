---
Module Name: Microsoft.Graph.Users
Module Guid: 0fb61503-84a0-4a63-8d30-6851e4ee8429
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
This operation returns by default only a subset of the more commonly used properties for each user.
These _default_ properties are noted in the Properties section.
To get properties that are _not_ returned by default, do a GET operation for the user and specify the properties in a `$select` OData query option.
Because the **user** resource supports extensions, you can also use the `GET` operation to get custom properties and extension data in a **user** instance.

### [Get-MgUserCreatedObject](Get-MgUserCreatedObject.md)
Directory objects that were created by the user.
Read-only.
Nullable.

### [Get-MgUserCreatedObjectAsServicePrincipal](Get-MgUserCreatedObjectAsServicePrincipal.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.servicePrincipal

### [Get-MgUserDirectReport](Get-MgUserDirectReport.md)
The users and contacts that report to the user.
(The users and contacts that have their manager property set to this user.) Read-only.
Nullable.
Supports $expand.

### [Get-MgUserDirectReportAsOrgContact](Get-MgUserDirectReportAsOrgContact.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.orgContact

### [Get-MgUserDirectReportAsUser](Get-MgUserDirectReportAsUser.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.user

### [Get-MgUserExtension](Get-MgUserExtension.md)
The collection of open extensions defined for the user.
Supports $expand.
Nullable.

### [Get-MgUserLicenseDetail](Get-MgUserLicenseDetail.md)
Get licenseDetails from users

### [Get-MgUserManager](Get-MgUserManager.md)
The user or contact that is this user's manager.
Read-only.
(HTTP Methods: GET, PUT, DELETE.).
Supports $expand.

### [Get-MgUserManagerByRef](Get-MgUserManagerByRef.md)
The user or contact that is this user's manager.
Read-only.
(HTTP Methods: GET, PUT, DELETE.).
Supports $expand.

### [Get-MgUserMemberOf](Get-MgUserMemberOf.md)
The groups, directory roles and administrative units that the user is a member of.
Read-only.
Nullable.
Supports $expand.

### [Get-MgUserMemberOfAsAdministrativeUnit](Get-MgUserMemberOfAsAdministrativeUnit.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.administrativeUnit

### [Get-MgUserMemberOfAsGroup](Get-MgUserMemberOfAsGroup.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.group

### [Get-MgUserNotification](Get-MgUserNotification.md)
Get notifications from users

### [Get-MgUserOauth2PermissionGrant](Get-MgUserOauth2PermissionGrant.md)
Get oauth2PermissionGrants from users

### [Get-MgUserOutlookMasterCategory](Get-MgUserOutlookMasterCategory.md)
A list of categories defined for the user.

### [Get-MgUserOutlookTask](Get-MgUserOutlookTask.md)
Get tasks from users

### [Get-MgUserOutlookTaskAttachment](Get-MgUserOutlookTaskAttachment.md)
The collection of fileAttachment, itemAttachment, and referenceAttachment attachments for the task.
Read-only.
Nullable.

### [Get-MgUserOutlookTaskFolder](Get-MgUserOutlookTaskFolder.md)
Get taskFolders from users

### [Get-MgUserOutlookTaskFolderMultiValueExtendedProperty](Get-MgUserOutlookTaskFolderMultiValueExtendedProperty.md)
The collection of multi-value extended properties defined for the task folder.
Read-only.
Nullable.

### [Get-MgUserOutlookTaskFolderSingleValueExtendedProperty](Get-MgUserOutlookTaskFolderSingleValueExtendedProperty.md)
The collection of single-value extended properties defined for the task folder.
Read-only.
Nullable.

### [Get-MgUserOutlookTaskFolderTask](Get-MgUserOutlookTaskFolderTask.md)
The tasks in this task folder.
Read-only.
Nullable.

### [Get-MgUserOutlookTaskFolderTaskAttachment](Get-MgUserOutlookTaskFolderTaskAttachment.md)
The collection of fileAttachment, itemAttachment, and referenceAttachment attachments for the task.
Read-only.
Nullable.

### [Get-MgUserOutlookTaskFolderTaskMultiValueExtendedProperty](Get-MgUserOutlookTaskFolderTaskMultiValueExtendedProperty.md)
The collection of multi-value extended properties defined for the task.
Read-only.
Nullable.

### [Get-MgUserOutlookTaskFolderTaskSingleValueExtendedProperty](Get-MgUserOutlookTaskFolderTaskSingleValueExtendedProperty.md)
The collection of single-value extended properties defined for the task.
Read-only.
Nullable.

### [Get-MgUserOutlookTaskGroup](Get-MgUserOutlookTaskGroup.md)
Get taskGroups from users

### [Get-MgUserOutlookTaskGroupTaskFolder](Get-MgUserOutlookTaskGroupTaskFolder.md)
The collection of task folders in the task group.
Read-only.
Nullable.

### [Get-MgUserOutlookTaskGroupTaskFolderMultiValueExtendedProperty](Get-MgUserOutlookTaskGroupTaskFolderMultiValueExtendedProperty.md)
The collection of multi-value extended properties defined for the task folder.
Read-only.
Nullable.

### [Get-MgUserOutlookTaskGroupTaskFolderSingleValueExtendedProperty](Get-MgUserOutlookTaskGroupTaskFolderSingleValueExtendedProperty.md)
The collection of single-value extended properties defined for the task folder.
Read-only.
Nullable.

### [Get-MgUserOutlookTaskGroupTaskFolderTask](Get-MgUserOutlookTaskGroupTaskFolderTask.md)
The tasks in this task folder.
Read-only.
Nullable.

### [Get-MgUserOutlookTaskGroupTaskFolderTaskAttachment](Get-MgUserOutlookTaskGroupTaskFolderTaskAttachment.md)
The collection of fileAttachment, itemAttachment, and referenceAttachment attachments for the task.
Read-only.
Nullable.

### [Get-MgUserOutlookTaskGroupTaskFolderTaskMultiValueExtendedProperty](Get-MgUserOutlookTaskGroupTaskFolderTaskMultiValueExtendedProperty.md)
The collection of multi-value extended properties defined for the task.
Read-only.
Nullable.

### [Get-MgUserOutlookTaskGroupTaskFolderTaskSingleValueExtendedProperty](Get-MgUserOutlookTaskGroupTaskFolderTaskSingleValueExtendedProperty.md)
The collection of single-value extended properties defined for the task.
Read-only.
Nullable.

### [Get-MgUserOutlookTaskMultiValueExtendedProperty](Get-MgUserOutlookTaskMultiValueExtendedProperty.md)
The collection of multi-value extended properties defined for the task.
Read-only.
Nullable.

### [Get-MgUserOutlookTaskSingleValueExtendedProperty](Get-MgUserOutlookTaskSingleValueExtendedProperty.md)
The collection of single-value extended properties defined for the task.
Read-only.
Nullable.

### [Get-MgUserOwnedDevice](Get-MgUserOwnedDevice.md)
Devices that are owned by the user.
Read-only.
Nullable.
Supports $expand.

### [Get-MgUserOwnedDeviceAsDevice](Get-MgUserOwnedDeviceAsDevice.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.device

### [Get-MgUserOwnedDeviceAsEndpoint](Get-MgUserOwnedDeviceAsEndpoint.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.endpoint

### [Get-MgUserOwnedObject](Get-MgUserOwnedObject.md)
Directory objects that are owned by the user.
Read-only.
Nullable.
Supports $expand and $filter (/$count eq 0, /$count ne 0, /$count eq 1, /$count ne 1).

### [Get-MgUserOwnedObjectAsApplication](Get-MgUserOwnedObjectAsApplication.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.application

### [Get-MgUserOwnedObjectAsGroup](Get-MgUserOwnedObjectAsGroup.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.group

### [Get-MgUserOwnedObjectAsServicePrincipal](Get-MgUserOwnedObjectAsServicePrincipal.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.servicePrincipal

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

### [Get-MgUserRegisteredDeviceAsDevice](Get-MgUserRegisteredDeviceAsDevice.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.device

### [Get-MgUserRegisteredDeviceAsEndpoint](Get-MgUserRegisteredDeviceAsEndpoint.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.endpoint

### [Get-MgUserSetting](Get-MgUserSetting.md)
Get settings from users

### [Get-MgUserSettingContactMergeSuggestion](Get-MgUserSettingContactMergeSuggestion.md)
The user's settings for the visibility of merge suggestion for the duplicate contacts in the user's contact list.

### [Get-MgUserSettingItemInsight](Get-MgUserSettingItemInsight.md)
The user's settings for the visibility of meeting hour insights, and insights derived between a user and other items in Microsoft 365, such as documents or sites.
Get userInsightsSettings through this navigation property.

### [Get-MgUserSettingRegionalAndLanguageSetting](Get-MgUserSettingRegionalAndLanguageSetting.md)
The user's preferences for languages, regional locale and date/time formatting.

### [Get-MgUserSettingShiftPreference](Get-MgUserSettingShiftPreference.md)
The shift preferences for the user.

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
A collection of file attachments for the task.

### [Get-MgUserTodoListTaskAttachmentContent](Get-MgUserTodoListTaskAttachmentContent.md)
Get media content for the navigation property attachments from users

### [Get-MgUserTodoListTaskAttachmentSession](Get-MgUserTodoListTaskAttachmentSession.md)
Get attachmentSessions from users

### [Get-MgUserTodoListTaskAttachmentSessionContent](Get-MgUserTodoListTaskAttachmentSessionContent.md)
The content streams that are uploaded.

### [Get-MgUserTodoListTaskChecklistItem](Get-MgUserTodoListTaskChecklistItem.md)
A collection of smaller subtasks linked to the more complex parent task.

### [Get-MgUserTodoListTaskExtension](Get-MgUserTodoListTaskExtension.md)
The collection of open extensions defined for the task.
Nullable.

### [Get-MgUserTodoListTaskLinkedResource](Get-MgUserTodoListTaskLinkedResource.md)
A collection of resources linked to the task.

### [Get-MgUserTransitiveMemberOf](Get-MgUserTransitiveMemberOf.md)
The groups, including nested groups, and directory roles that a user is a member of.
Nullable.

### [Get-MgUserTransitiveMemberOfAsAdministrativeUnit](Get-MgUserTransitiveMemberOfAsAdministrativeUnit.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.administrativeUnit

### [Get-MgUserTransitiveMemberOfAsGroup](Get-MgUserTransitiveMemberOfAsGroup.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.group

### [Get-MgUserTransitiveReport](Get-MgUserTransitiveReport.md)
The transitive reports for a user.
Read-only.

### [New-MgUser](New-MgUser.md)
Create a new user.\nThe request body contains the user to create.
At a minimum, you must specify the required properties for the user.
You can optionally specify any other writable properties.
This operation returns by default only a subset of the properties for each user.
These default properties are noted in the Properties section.
To get properties that are not returned by default, do a GET operation and specify the properties in a `$select` OData query option.

### [New-MgUserExtension](New-MgUserExtension.md)
Create new navigation property to extensions for users

### [New-MgUserNotification](New-MgUserNotification.md)
Create new navigation property to notifications for users

### [New-MgUserOutlookMasterCategory](New-MgUserOutlookMasterCategory.md)
Create new navigation property to masterCategories for users

### [New-MgUserOutlookTask](New-MgUserOutlookTask.md)
Create new navigation property to tasks for users

### [New-MgUserOutlookTaskAttachment](New-MgUserOutlookTaskAttachment.md)
Create new navigation property to attachments for users

### [New-MgUserOutlookTaskFolder](New-MgUserOutlookTaskFolder.md)
Create new navigation property to taskFolders for users

### [New-MgUserOutlookTaskFolderMultiValueExtendedProperty](New-MgUserOutlookTaskFolderMultiValueExtendedProperty.md)
Create new navigation property to multiValueExtendedProperties for users

### [New-MgUserOutlookTaskFolderSingleValueExtendedProperty](New-MgUserOutlookTaskFolderSingleValueExtendedProperty.md)
Create new navigation property to singleValueExtendedProperties for users

### [New-MgUserOutlookTaskFolderTask](New-MgUserOutlookTaskFolderTask.md)
Create new navigation property to tasks for users

### [New-MgUserOutlookTaskFolderTaskAttachment](New-MgUserOutlookTaskFolderTaskAttachment.md)
Create new navigation property to attachments for users

### [New-MgUserOutlookTaskFolderTaskMultiValueExtendedProperty](New-MgUserOutlookTaskFolderTaskMultiValueExtendedProperty.md)
Create new navigation property to multiValueExtendedProperties for users

### [New-MgUserOutlookTaskFolderTaskSingleValueExtendedProperty](New-MgUserOutlookTaskFolderTaskSingleValueExtendedProperty.md)
Create new navigation property to singleValueExtendedProperties for users

### [New-MgUserOutlookTaskGroup](New-MgUserOutlookTaskGroup.md)
Create new navigation property to taskGroups for users

### [New-MgUserOutlookTaskGroupTaskFolder](New-MgUserOutlookTaskGroupTaskFolder.md)
Create new navigation property to taskFolders for users

### [New-MgUserOutlookTaskGroupTaskFolderMultiValueExtendedProperty](New-MgUserOutlookTaskGroupTaskFolderMultiValueExtendedProperty.md)
Create new navigation property to multiValueExtendedProperties for users

### [New-MgUserOutlookTaskGroupTaskFolderSingleValueExtendedProperty](New-MgUserOutlookTaskGroupTaskFolderSingleValueExtendedProperty.md)
Create new navigation property to singleValueExtendedProperties for users

### [New-MgUserOutlookTaskGroupTaskFolderTask](New-MgUserOutlookTaskGroupTaskFolderTask.md)
Create new navigation property to tasks for users

### [New-MgUserOutlookTaskGroupTaskFolderTaskAttachment](New-MgUserOutlookTaskGroupTaskFolderTaskAttachment.md)
Create new navigation property to attachments for users

### [New-MgUserOutlookTaskGroupTaskFolderTaskMultiValueExtendedProperty](New-MgUserOutlookTaskGroupTaskFolderTaskMultiValueExtendedProperty.md)
Create new navigation property to multiValueExtendedProperties for users

### [New-MgUserOutlookTaskGroupTaskFolderTaskSingleValueExtendedProperty](New-MgUserOutlookTaskGroupTaskFolderTaskSingleValueExtendedProperty.md)
Create new navigation property to singleValueExtendedProperties for users

### [New-MgUserOutlookTaskMultiValueExtendedProperty](New-MgUserOutlookTaskMultiValueExtendedProperty.md)
Create new navigation property to multiValueExtendedProperties for users

### [New-MgUserOutlookTaskSingleValueExtendedProperty](New-MgUserOutlookTaskSingleValueExtendedProperty.md)
Create new navigation property to singleValueExtendedProperties for users

### [New-MgUserTodoList](New-MgUserTodoList.md)
Create new navigation property to lists for users

### [New-MgUserTodoListExtension](New-MgUserTodoListExtension.md)
Create new navigation property to extensions for users

### [New-MgUserTodoListTask](New-MgUserTodoListTask.md)
Create new navigation property to tasks for users

### [New-MgUserTodoListTaskAttachment](New-MgUserTodoListTaskAttachment.md)
Create new navigation property to attachments for users

### [New-MgUserTodoListTaskChecklistItem](New-MgUserTodoListTaskChecklistItem.md)
Create new navigation property to checklistItems for users

### [New-MgUserTodoListTaskExtension](New-MgUserTodoListTaskExtension.md)
Create new navigation property to extensions for users

### [New-MgUserTodoListTaskLinkedResource](New-MgUserTodoListTaskLinkedResource.md)
Create new navigation property to linkedResources for users

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

### [Remove-MgUserNotification](Remove-MgUserNotification.md)
Delete navigation property notifications for users

### [Remove-MgUserOutlookMasterCategory](Remove-MgUserOutlookMasterCategory.md)
Delete navigation property masterCategories for users

### [Remove-MgUserOutlookTask](Remove-MgUserOutlookTask.md)
Delete navigation property tasks for users

### [Remove-MgUserOutlookTaskAttachment](Remove-MgUserOutlookTaskAttachment.md)
Delete navigation property attachments for users

### [Remove-MgUserOutlookTaskFolder](Remove-MgUserOutlookTaskFolder.md)
Delete navigation property taskFolders for users

### [Remove-MgUserOutlookTaskFolderMultiValueExtendedProperty](Remove-MgUserOutlookTaskFolderMultiValueExtendedProperty.md)
Delete navigation property multiValueExtendedProperties for users

### [Remove-MgUserOutlookTaskFolderSingleValueExtendedProperty](Remove-MgUserOutlookTaskFolderSingleValueExtendedProperty.md)
Delete navigation property singleValueExtendedProperties for users

### [Remove-MgUserOutlookTaskFolderTask](Remove-MgUserOutlookTaskFolderTask.md)
Delete navigation property tasks for users

### [Remove-MgUserOutlookTaskFolderTaskAttachment](Remove-MgUserOutlookTaskFolderTaskAttachment.md)
Delete navigation property attachments for users

### [Remove-MgUserOutlookTaskFolderTaskMultiValueExtendedProperty](Remove-MgUserOutlookTaskFolderTaskMultiValueExtendedProperty.md)
Delete navigation property multiValueExtendedProperties for users

### [Remove-MgUserOutlookTaskFolderTaskSingleValueExtendedProperty](Remove-MgUserOutlookTaskFolderTaskSingleValueExtendedProperty.md)
Delete navigation property singleValueExtendedProperties for users

### [Remove-MgUserOutlookTaskGroup](Remove-MgUserOutlookTaskGroup.md)
Delete navigation property taskGroups for users

### [Remove-MgUserOutlookTaskGroupTaskFolder](Remove-MgUserOutlookTaskGroupTaskFolder.md)
Delete navigation property taskFolders for users

### [Remove-MgUserOutlookTaskGroupTaskFolderMultiValueExtendedProperty](Remove-MgUserOutlookTaskGroupTaskFolderMultiValueExtendedProperty.md)
Delete navigation property multiValueExtendedProperties for users

### [Remove-MgUserOutlookTaskGroupTaskFolderSingleValueExtendedProperty](Remove-MgUserOutlookTaskGroupTaskFolderSingleValueExtendedProperty.md)
Delete navigation property singleValueExtendedProperties for users

### [Remove-MgUserOutlookTaskGroupTaskFolderTask](Remove-MgUserOutlookTaskGroupTaskFolderTask.md)
Delete navigation property tasks for users

### [Remove-MgUserOutlookTaskGroupTaskFolderTaskAttachment](Remove-MgUserOutlookTaskGroupTaskFolderTaskAttachment.md)
Delete navigation property attachments for users

### [Remove-MgUserOutlookTaskGroupTaskFolderTaskMultiValueExtendedProperty](Remove-MgUserOutlookTaskGroupTaskFolderTaskMultiValueExtendedProperty.md)
Delete navigation property multiValueExtendedProperties for users

### [Remove-MgUserOutlookTaskGroupTaskFolderTaskSingleValueExtendedProperty](Remove-MgUserOutlookTaskGroupTaskFolderTaskSingleValueExtendedProperty.md)
Delete navigation property singleValueExtendedProperties for users

### [Remove-MgUserOutlookTaskMultiValueExtendedProperty](Remove-MgUserOutlookTaskMultiValueExtendedProperty.md)
Delete navigation property multiValueExtendedProperties for users

### [Remove-MgUserOutlookTaskSingleValueExtendedProperty](Remove-MgUserOutlookTaskSingleValueExtendedProperty.md)
Delete navigation property singleValueExtendedProperties for users

### [Remove-MgUserPhoto](Remove-MgUserPhoto.md)
Delete navigation property photo for users

### [Remove-MgUserSetting](Remove-MgUserSetting.md)
Delete navigation property settings for users

### [Remove-MgUserSettingContactMergeSuggestion](Remove-MgUserSettingContactMergeSuggestion.md)
Delete navigation property contactMergeSuggestions for users

### [Remove-MgUserSettingItemInsight](Remove-MgUserSettingItemInsight.md)
Delete navigation property itemInsights for users

### [Remove-MgUserSettingRegionalAndLanguageSetting](Remove-MgUserSettingRegionalAndLanguageSetting.md)
Delete navigation property regionalAndLanguageSettings for users

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
The content streams that are uploaded.

### [Update-MgUser](Update-MgUser.md)
Update the properties of a user object.
Not all properties can be updated by Member or Guest users with their default permissions without Administrator roles.
Compare member and guest default permissions to see properties they can manage.

### [Update-MgUserExtension](Update-MgUserExtension.md)
Update the navigation property extensions in users

### [Update-MgUserLicenseDetail](Update-MgUserLicenseDetail.md)
Update the navigation property licenseDetails in users

### [Update-MgUserNotification](Update-MgUserNotification.md)
Update the navigation property notifications in users

### [Update-MgUserOutlookMasterCategory](Update-MgUserOutlookMasterCategory.md)
Update the navigation property masterCategories in users

### [Update-MgUserOutlookTask](Update-MgUserOutlookTask.md)
Update the navigation property tasks in users

### [Update-MgUserOutlookTaskFolder](Update-MgUserOutlookTaskFolder.md)
Update the navigation property taskFolders in users

### [Update-MgUserOutlookTaskFolderMultiValueExtendedProperty](Update-MgUserOutlookTaskFolderMultiValueExtendedProperty.md)
Update the navigation property multiValueExtendedProperties in users

### [Update-MgUserOutlookTaskFolderSingleValueExtendedProperty](Update-MgUserOutlookTaskFolderSingleValueExtendedProperty.md)
Update the navigation property singleValueExtendedProperties in users

### [Update-MgUserOutlookTaskFolderTask](Update-MgUserOutlookTaskFolderTask.md)
Update the navigation property tasks in users

### [Update-MgUserOutlookTaskFolderTaskMultiValueExtendedProperty](Update-MgUserOutlookTaskFolderTaskMultiValueExtendedProperty.md)
Update the navigation property multiValueExtendedProperties in users

### [Update-MgUserOutlookTaskFolderTaskSingleValueExtendedProperty](Update-MgUserOutlookTaskFolderTaskSingleValueExtendedProperty.md)
Update the navigation property singleValueExtendedProperties in users

### [Update-MgUserOutlookTaskGroup](Update-MgUserOutlookTaskGroup.md)
Update the navigation property taskGroups in users

### [Update-MgUserOutlookTaskGroupTaskFolder](Update-MgUserOutlookTaskGroupTaskFolder.md)
Update the navigation property taskFolders in users

### [Update-MgUserOutlookTaskGroupTaskFolderMultiValueExtendedProperty](Update-MgUserOutlookTaskGroupTaskFolderMultiValueExtendedProperty.md)
Update the navigation property multiValueExtendedProperties in users

### [Update-MgUserOutlookTaskGroupTaskFolderSingleValueExtendedProperty](Update-MgUserOutlookTaskGroupTaskFolderSingleValueExtendedProperty.md)
Update the navigation property singleValueExtendedProperties in users

### [Update-MgUserOutlookTaskGroupTaskFolderTask](Update-MgUserOutlookTaskGroupTaskFolderTask.md)
Update the navigation property tasks in users

### [Update-MgUserOutlookTaskGroupTaskFolderTaskMultiValueExtendedProperty](Update-MgUserOutlookTaskGroupTaskFolderTaskMultiValueExtendedProperty.md)
Update the navigation property multiValueExtendedProperties in users

### [Update-MgUserOutlookTaskGroupTaskFolderTaskSingleValueExtendedProperty](Update-MgUserOutlookTaskGroupTaskFolderTaskSingleValueExtendedProperty.md)
Update the navigation property singleValueExtendedProperties in users

### [Update-MgUserOutlookTaskMultiValueExtendedProperty](Update-MgUserOutlookTaskMultiValueExtendedProperty.md)
Update the navigation property multiValueExtendedProperties in users

### [Update-MgUserOutlookTaskSingleValueExtendedProperty](Update-MgUserOutlookTaskSingleValueExtendedProperty.md)
Update the navigation property singleValueExtendedProperties in users

### [Update-MgUserPhoto](Update-MgUserPhoto.md)
Update the navigation property photo in users

### [Update-MgUserSetting](Update-MgUserSetting.md)
Update the navigation property settings in users

### [Update-MgUserSettingContactMergeSuggestion](Update-MgUserSettingContactMergeSuggestion.md)
Update the navigation property contactMergeSuggestions in users

### [Update-MgUserSettingItemInsight](Update-MgUserSettingItemInsight.md)
Update the navigation property itemInsights in users

### [Update-MgUserSettingRegionalAndLanguageSetting](Update-MgUserSettingRegionalAndLanguageSetting.md)
Update the navigation property regionalAndLanguageSettings in users

### [Update-MgUserSettingShiftPreference](Update-MgUserSettingShiftPreference.md)
Update the navigation property shiftPreferences in users

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

