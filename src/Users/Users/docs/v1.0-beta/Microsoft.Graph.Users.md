---
Module Name: Microsoft.Graph.Beta.Users
Module Guid: bf0d07bf-16bd-4740-820e-0a2e6b49d735
Download Help Link: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.Beta.users
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Beta.Users Module
## Description
Microsoft.Graph.Beta PowerShell Cmdlets

## Microsoft.Graph.Beta.Users Cmdlets
### [Get-MgBetaUser](Get-MgBetaUser.md)
Retrieve the properties and relationships of user object.
This operation returns by default only a subset of the more commonly used properties for each user.
These _default_ properties are noted in the Properties section.
To get properties that are _not_ returned by default, do a GET operation for the user and specify the properties in a `$select` OData query option.
Because the **user** resource supports extensions, you can also use the `GET` operation to get custom properties and extension data in a **user** instance.

### [Get-MgBetaUserCreatedObject](Get-MgBetaUserCreatedObject.md)
Directory objects that were created by the user.
Read-only.
Nullable.

### [Get-MgBetaUserDirectReport](Get-MgBetaUserDirectReport.md)
The users and contacts that report to the user.
(The users and contacts that have their manager property set to this user.) Read-only.
Nullable.
Supports $expand.

### [Get-MgBetaUserExtension](Get-MgBetaUserExtension.md)
The collection of open extensions defined for the user.
Supports $expand.
Nullable.

### [Get-MgBetaUserLicenseDetail](Get-MgBetaUserLicenseDetail.md)
Get licenseDetails from users

### [Get-MgBetaUserManager](Get-MgBetaUserManager.md)
Returns the user or organizational contact assigned as the user's manager.
Optionally, you can expand the manager's chain up to the root node.

### [Get-MgBetaUserManagerByRef](Get-MgBetaUserManagerByRef.md)
Returns the user or organizational contact assigned as the user's manager.
Optionally, you can expand the manager's chain up to the root node.

### [Get-MgBetaUserMemberOf](Get-MgBetaUserMemberOf.md)
The groups, directory roles and administrative units that the user is a member of.
Read-only.
Nullable.
Supports $expand.

### [Get-MgBetaUserNotification](Get-MgBetaUserNotification.md)
Get notifications from users

### [Get-MgBetaUserOauth2PermissionGrant](Get-MgBetaUserOauth2PermissionGrant.md)
Get oauth2PermissionGrants from users

### [Get-MgBetaUserOutlookMasterCategory](Get-MgBetaUserOutlookMasterCategory.md)
A list of categories defined for the user.

### [Get-MgBetaUserOutlookTask](Get-MgBetaUserOutlookTask.md)
Get tasks from users

### [Get-MgBetaUserOutlookTaskAttachment](Get-MgBetaUserOutlookTaskAttachment.md)
The collection of fileAttachment, itemAttachment, and referenceAttachment attachments for the task.
Read-only.
Nullable.

### [Get-MgBetaUserOutlookTaskFolder](Get-MgBetaUserOutlookTaskFolder.md)
Get taskFolders from users

### [Get-MgBetaUserOutlookTaskFolderMultiValueExtendedProperty](Get-MgBetaUserOutlookTaskFolderMultiValueExtendedProperty.md)
The collection of multi-value extended properties defined for the task folder.
Read-only.
Nullable.

### [Get-MgBetaUserOutlookTaskFolderSingleValueExtendedProperty](Get-MgBetaUserOutlookTaskFolderSingleValueExtendedProperty.md)
The collection of single-value extended properties defined for the task folder.
Read-only.
Nullable.

### [Get-MgBetaUserOutlookTaskFolderTask](Get-MgBetaUserOutlookTaskFolderTask.md)
The tasks in this task folder.
Read-only.
Nullable.

### [Get-MgBetaUserOutlookTaskFolderTaskAttachment](Get-MgBetaUserOutlookTaskFolderTaskAttachment.md)
The collection of fileAttachment, itemAttachment, and referenceAttachment attachments for the task.
Read-only.
Nullable.

### [Get-MgBetaUserOutlookTaskFolderTaskMultiValueExtendedProperty](Get-MgBetaUserOutlookTaskFolderTaskMultiValueExtendedProperty.md)
The collection of multi-value extended properties defined for the task.
Read-only.
Nullable.

### [Get-MgBetaUserOutlookTaskFolderTaskSingleValueExtendedProperty](Get-MgBetaUserOutlookTaskFolderTaskSingleValueExtendedProperty.md)
The collection of single-value extended properties defined for the task.
Read-only.
Nullable.

### [Get-MgBetaUserOutlookTaskGroup](Get-MgBetaUserOutlookTaskGroup.md)
Get taskGroups from users

### [Get-MgBetaUserOutlookTaskGroupTaskFolder](Get-MgBetaUserOutlookTaskGroupTaskFolder.md)
The collection of task folders in the task group.
Read-only.
Nullable.

### [Get-MgBetaUserOutlookTaskGroupTaskFolderMultiValueExtendedProperty](Get-MgBetaUserOutlookTaskGroupTaskFolderMultiValueExtendedProperty.md)
The collection of multi-value extended properties defined for the task folder.
Read-only.
Nullable.

### [Get-MgBetaUserOutlookTaskGroupTaskFolderSingleValueExtendedProperty](Get-MgBetaUserOutlookTaskGroupTaskFolderSingleValueExtendedProperty.md)
The collection of single-value extended properties defined for the task folder.
Read-only.
Nullable.

### [Get-MgBetaUserOutlookTaskGroupTaskFolderTask](Get-MgBetaUserOutlookTaskGroupTaskFolderTask.md)
The tasks in this task folder.
Read-only.
Nullable.

### [Get-MgBetaUserOutlookTaskGroupTaskFolderTaskAttachment](Get-MgBetaUserOutlookTaskGroupTaskFolderTaskAttachment.md)
The collection of fileAttachment, itemAttachment, and referenceAttachment attachments for the task.
Read-only.
Nullable.

### [Get-MgBetaUserOutlookTaskGroupTaskFolderTaskMultiValueExtendedProperty](Get-MgBetaUserOutlookTaskGroupTaskFolderTaskMultiValueExtendedProperty.md)
The collection of multi-value extended properties defined for the task.
Read-only.
Nullable.

### [Get-MgBetaUserOutlookTaskGroupTaskFolderTaskSingleValueExtendedProperty](Get-MgBetaUserOutlookTaskGroupTaskFolderTaskSingleValueExtendedProperty.md)
The collection of single-value extended properties defined for the task.
Read-only.
Nullable.

### [Get-MgBetaUserOutlookTaskMultiValueExtendedProperty](Get-MgBetaUserOutlookTaskMultiValueExtendedProperty.md)
The collection of multi-value extended properties defined for the task.
Read-only.
Nullable.

### [Get-MgBetaUserOutlookTaskSingleValueExtendedProperty](Get-MgBetaUserOutlookTaskSingleValueExtendedProperty.md)
The collection of single-value extended properties defined for the task.
Read-only.
Nullable.

### [Get-MgBetaUserOwnedDevice](Get-MgBetaUserOwnedDevice.md)
Devices that are owned by the user.
Read-only.
Nullable.
Supports $expand.

### [Get-MgBetaUserOwnedObject](Get-MgBetaUserOwnedObject.md)
Directory objects that are owned by the user.
Read-only.
Nullable.
Supports $expand and $filter (/$count eq 0, /$count ne 0, /$count eq 1, /$count ne 1).

### [Get-MgBetaUserPhoto](Get-MgBetaUserPhoto.md)
The user's profile photo.
Read-only.

### [Get-MgBetaUserPhotoContent](Get-MgBetaUserPhotoContent.md)
Get media content for the navigation property photo from users

### [Get-MgBetaUserRegisteredDevice](Get-MgBetaUserRegisteredDevice.md)
Devices that are registered for the user.
Read-only.
Nullable.
Supports $expand.

### [Get-MgBetaUserSetting](Get-MgBetaUserSetting.md)
Get settings from users

### [Get-MgBetaUserSettingContactMergeSuggestion](Get-MgBetaUserSettingContactMergeSuggestion.md)
Read the properties and relationships of a contactMergeSuggestions object.

### [Get-MgBetaUserSettingItemInsight](Get-MgBetaUserSettingItemInsight.md)
Get the user-customizable privacy settings for itemInsights and meeting hours insights.

### [Get-MgBetaUserSettingRegionalAndLanguageSetting](Get-MgBetaUserSettingRegionalAndLanguageSetting.md)
Get the properties of a regionalAndLanguageSettings object.

### [Get-MgBetaUserSettingShiftPreference](Get-MgBetaUserSettingShiftPreference.md)
Retrieve the properties and relationships of a shiftPreferences object by ID.

### [Get-MgBetaUserTodoList](Get-MgBetaUserTodoList.md)
The task lists in the users mailbox.

### [Get-MgBetaUserTodoListExtension](Get-MgBetaUserTodoListExtension.md)
The collection of open extensions defined for the task list.
Nullable.

### [Get-MgBetaUserTodoListTask](Get-MgBetaUserTodoListTask.md)
The tasks in this task list.
Read-only.
Nullable.

### [Get-MgBetaUserTodoListTaskAttachment](Get-MgBetaUserTodoListTaskAttachment.md)
A collection of file attachments for the task.

### [Get-MgBetaUserTodoListTaskAttachmentContent](Get-MgBetaUserTodoListTaskAttachmentContent.md)
Get media content for the navigation property attachments from users

### [Get-MgBetaUserTodoListTaskAttachmentSession](Get-MgBetaUserTodoListTaskAttachmentSession.md)
Get attachmentSessions from users

### [Get-MgBetaUserTodoListTaskAttachmentSessionContent](Get-MgBetaUserTodoListTaskAttachmentSessionContent.md)
The content streams that are uploaded.

### [Get-MgBetaUserTodoListTaskChecklistItem](Get-MgBetaUserTodoListTaskChecklistItem.md)
A collection of smaller subtasks linked to the more complex parent task.

### [Get-MgBetaUserTodoListTaskExtension](Get-MgBetaUserTodoListTaskExtension.md)
The collection of open extensions defined for the task.
Nullable.

### [Get-MgBetaUserTodoListTaskLinkedResource](Get-MgBetaUserTodoListTaskLinkedResource.md)
A collection of resources linked to the task.

### [Get-MgBetaUserTransitiveMemberOf](Get-MgBetaUserTransitiveMemberOf.md)
The groups, including nested groups, and directory roles that a user is a member of.
Nullable.

### [Get-MgBetaUserTransitiveReport](Get-MgBetaUserTransitiveReport.md)
The transitive reports for a user.
Read-only.

### [New-MgBetaUser](New-MgBetaUser.md)
Create a new user.\nThe request body contains the user to create.
At a minimum, you must specify the required properties for the user.
You can optionally specify any other writable properties.
This operation returns by default only a subset of the properties for each user.
These default properties are noted in the Properties section.
To get properties that are not returned by default, do a GET operation and specify the properties in a `$select` OData query option.

### [New-MgBetaUserExtension](New-MgBetaUserExtension.md)
Create new navigation property to extensions for users

### [New-MgBetaUserNotification](New-MgBetaUserNotification.md)
Create new navigation property to notifications for users

### [New-MgBetaUserOutlookMasterCategory](New-MgBetaUserOutlookMasterCategory.md)
Create an outlookCategory object in the user's master list of categories.

### [New-MgBetaUserOutlookTask](New-MgBetaUserOutlookTask.md)
Create an Outlook task in the specified task folder.
The POST method always ignores the time portion of **startDateTime** and **dueDateTime** in the request body, and assumes the time \nto be always midnight in the specified time zone.

### [New-MgBetaUserOutlookTaskAttachment](New-MgBetaUserOutlookTaskAttachment.md)
Use this API to add an attachment to an outlookTask.
The attachment can be a file (of fileAttachment type) or Outlook item (itemAttachment type).

### [New-MgBetaUserOutlookTaskFolder](New-MgBetaUserOutlookTaskFolder.md)
Create new navigation property to taskFolders for users

### [New-MgBetaUserOutlookTaskFolderMultiValueExtendedProperty](New-MgBetaUserOutlookTaskFolderMultiValueExtendedProperty.md)
Create new navigation property to multiValueExtendedProperties for users

### [New-MgBetaUserOutlookTaskFolderSingleValueExtendedProperty](New-MgBetaUserOutlookTaskFolderSingleValueExtendedProperty.md)
Create new navigation property to singleValueExtendedProperties for users

### [New-MgBetaUserOutlookTaskFolderTask](New-MgBetaUserOutlookTaskFolderTask.md)
Create new navigation property to tasks for users

### [New-MgBetaUserOutlookTaskFolderTaskAttachment](New-MgBetaUserOutlookTaskFolderTaskAttachment.md)
Use this API to add an attachment to an outlookTask.
The attachment can be a file (of fileAttachment type) or Outlook item (itemAttachment type).

### [New-MgBetaUserOutlookTaskFolderTaskMultiValueExtendedProperty](New-MgBetaUserOutlookTaskFolderTaskMultiValueExtendedProperty.md)
Create new navigation property to multiValueExtendedProperties for users

### [New-MgBetaUserOutlookTaskFolderTaskSingleValueExtendedProperty](New-MgBetaUserOutlookTaskFolderTaskSingleValueExtendedProperty.md)
Create new navigation property to singleValueExtendedProperties for users

### [New-MgBetaUserOutlookTaskGroup](New-MgBetaUserOutlookTaskGroup.md)
Create an Outlook task group in the user's mailbox.

### [New-MgBetaUserOutlookTaskGroupTaskFolder](New-MgBetaUserOutlookTaskGroupTaskFolder.md)
Create new navigation property to taskFolders for users

### [New-MgBetaUserOutlookTaskGroupTaskFolderMultiValueExtendedProperty](New-MgBetaUserOutlookTaskGroupTaskFolderMultiValueExtendedProperty.md)
Create new navigation property to multiValueExtendedProperties for users

### [New-MgBetaUserOutlookTaskGroupTaskFolderSingleValueExtendedProperty](New-MgBetaUserOutlookTaskGroupTaskFolderSingleValueExtendedProperty.md)
Create new navigation property to singleValueExtendedProperties for users

### [New-MgBetaUserOutlookTaskGroupTaskFolderTask](New-MgBetaUserOutlookTaskGroupTaskFolderTask.md)
Create new navigation property to tasks for users

### [New-MgBetaUserOutlookTaskGroupTaskFolderTaskAttachment](New-MgBetaUserOutlookTaskGroupTaskFolderTaskAttachment.md)
Use this API to add an attachment to an outlookTask.
The attachment can be a file (of fileAttachment type) or Outlook item (itemAttachment type).

### [New-MgBetaUserOutlookTaskGroupTaskFolderTaskMultiValueExtendedProperty](New-MgBetaUserOutlookTaskGroupTaskFolderTaskMultiValueExtendedProperty.md)
Create new navigation property to multiValueExtendedProperties for users

### [New-MgBetaUserOutlookTaskGroupTaskFolderTaskSingleValueExtendedProperty](New-MgBetaUserOutlookTaskGroupTaskFolderTaskSingleValueExtendedProperty.md)
Create new navigation property to singleValueExtendedProperties for users

### [New-MgBetaUserOutlookTaskMultiValueExtendedProperty](New-MgBetaUserOutlookTaskMultiValueExtendedProperty.md)
Create new navigation property to multiValueExtendedProperties for users

### [New-MgBetaUserOutlookTaskSingleValueExtendedProperty](New-MgBetaUserOutlookTaskSingleValueExtendedProperty.md)
Create new navigation property to singleValueExtendedProperties for users

### [New-MgBetaUserTodoList](New-MgBetaUserTodoList.md)
Create a new lists object.

### [New-MgBetaUserTodoListExtension](New-MgBetaUserTodoListExtension.md)
Create new navigation property to extensions for users

### [New-MgBetaUserTodoListTask](New-MgBetaUserTodoListTask.md)
Create a new task object in a specified todoTaskList.

### [New-MgBetaUserTodoListTaskAttachment](New-MgBetaUserTodoListTaskAttachment.md)
Add a new taskFileAttachment object to a todoTask.
This operation limits the size of the attachment you can add to under 3 MB.
If the size of the file attachments is more than 3 MB, create an upload session to upload the attachments.

### [New-MgBetaUserTodoListTaskChecklistItem](New-MgBetaUserTodoListTaskChecklistItem.md)
Create new navigation property to checklistItems for users

### [New-MgBetaUserTodoListTaskExtension](New-MgBetaUserTodoListTaskExtension.md)
Create new navigation property to extensions for users

### [New-MgBetaUserTodoListTaskLinkedResource](New-MgBetaUserTodoListTaskLinkedResource.md)
Create a linkedResource object to associate a specified task with an item in a partner application.
For example, you can associate a task with an email item in Outlook that spurred the task, and you can create a **linkedResource** object to track its association.
You can also create a **linkedResource** object while creating a todoTask.

### [Remove-MgBetaUser](Remove-MgBetaUser.md)
Delete user.
 When deleted, user resources are moved to a temporary container and can be restored within 30 days.
After that time, they are permanently deleted.
To learn more, see deletedItems.

### [Remove-MgBetaUserExtension](Remove-MgBetaUserExtension.md)
Delete navigation property extensions for users

### [Remove-MgBetaUserLicenseDetail](Remove-MgBetaUserLicenseDetail.md)
Delete navigation property licenseDetails for users

### [Remove-MgBetaUserManagerByRef](Remove-MgBetaUserManagerByRef.md)
Delete ref of navigation property manager for users

### [Remove-MgBetaUserNotification](Remove-MgBetaUserNotification.md)
Delete navigation property notifications for users

### [Remove-MgBetaUserOutlookMasterCategory](Remove-MgBetaUserOutlookMasterCategory.md)
Delete navigation property masterCategories for users

### [Remove-MgBetaUserOutlookTask](Remove-MgBetaUserOutlookTask.md)
Delete navigation property tasks for users

### [Remove-MgBetaUserOutlookTaskAttachment](Remove-MgBetaUserOutlookTaskAttachment.md)
Delete navigation property attachments for users

### [Remove-MgBetaUserOutlookTaskFolder](Remove-MgBetaUserOutlookTaskFolder.md)
Delete navigation property taskFolders for users

### [Remove-MgBetaUserOutlookTaskFolderMultiValueExtendedProperty](Remove-MgBetaUserOutlookTaskFolderMultiValueExtendedProperty.md)
Delete navigation property multiValueExtendedProperties for users

### [Remove-MgBetaUserOutlookTaskFolderSingleValueExtendedProperty](Remove-MgBetaUserOutlookTaskFolderSingleValueExtendedProperty.md)
Delete navigation property singleValueExtendedProperties for users

### [Remove-MgBetaUserOutlookTaskFolderTask](Remove-MgBetaUserOutlookTaskFolderTask.md)
Delete navigation property tasks for users

### [Remove-MgBetaUserOutlookTaskFolderTaskAttachment](Remove-MgBetaUserOutlookTaskFolderTaskAttachment.md)
Delete navigation property attachments for users

### [Remove-MgBetaUserOutlookTaskFolderTaskMultiValueExtendedProperty](Remove-MgBetaUserOutlookTaskFolderTaskMultiValueExtendedProperty.md)
Delete navigation property multiValueExtendedProperties for users

### [Remove-MgBetaUserOutlookTaskFolderTaskSingleValueExtendedProperty](Remove-MgBetaUserOutlookTaskFolderTaskSingleValueExtendedProperty.md)
Delete navigation property singleValueExtendedProperties for users

### [Remove-MgBetaUserOutlookTaskGroup](Remove-MgBetaUserOutlookTaskGroup.md)
Delete navigation property taskGroups for users

### [Remove-MgBetaUserOutlookTaskGroupTaskFolder](Remove-MgBetaUserOutlookTaskGroupTaskFolder.md)
Delete navigation property taskFolders for users

### [Remove-MgBetaUserOutlookTaskGroupTaskFolderMultiValueExtendedProperty](Remove-MgBetaUserOutlookTaskGroupTaskFolderMultiValueExtendedProperty.md)
Delete navigation property multiValueExtendedProperties for users

### [Remove-MgBetaUserOutlookTaskGroupTaskFolderSingleValueExtendedProperty](Remove-MgBetaUserOutlookTaskGroupTaskFolderSingleValueExtendedProperty.md)
Delete navigation property singleValueExtendedProperties for users

### [Remove-MgBetaUserOutlookTaskGroupTaskFolderTask](Remove-MgBetaUserOutlookTaskGroupTaskFolderTask.md)
Delete navigation property tasks for users

### [Remove-MgBetaUserOutlookTaskGroupTaskFolderTaskAttachment](Remove-MgBetaUserOutlookTaskGroupTaskFolderTaskAttachment.md)
Delete navigation property attachments for users

### [Remove-MgBetaUserOutlookTaskGroupTaskFolderTaskMultiValueExtendedProperty](Remove-MgBetaUserOutlookTaskGroupTaskFolderTaskMultiValueExtendedProperty.md)
Delete navigation property multiValueExtendedProperties for users

### [Remove-MgBetaUserOutlookTaskGroupTaskFolderTaskSingleValueExtendedProperty](Remove-MgBetaUserOutlookTaskGroupTaskFolderTaskSingleValueExtendedProperty.md)
Delete navigation property singleValueExtendedProperties for users

### [Remove-MgBetaUserOutlookTaskMultiValueExtendedProperty](Remove-MgBetaUserOutlookTaskMultiValueExtendedProperty.md)
Delete navigation property multiValueExtendedProperties for users

### [Remove-MgBetaUserOutlookTaskSingleValueExtendedProperty](Remove-MgBetaUserOutlookTaskSingleValueExtendedProperty.md)
Delete navigation property singleValueExtendedProperties for users

### [Remove-MgBetaUserSetting](Remove-MgBetaUserSetting.md)
Delete navigation property settings for users

### [Remove-MgBetaUserSettingContactMergeSuggestion](Remove-MgBetaUserSettingContactMergeSuggestion.md)
Delete navigation property contactMergeSuggestions for users

### [Remove-MgBetaUserSettingItemInsight](Remove-MgBetaUserSettingItemInsight.md)
Delete navigation property itemInsights for users

### [Remove-MgBetaUserSettingRegionalAndLanguageSetting](Remove-MgBetaUserSettingRegionalAndLanguageSetting.md)
Delete navigation property regionalAndLanguageSettings for users

### [Remove-MgBetaUserSettingShiftPreference](Remove-MgBetaUserSettingShiftPreference.md)
Delete navigation property shiftPreferences for users

### [Remove-MgBetaUserTodoList](Remove-MgBetaUserTodoList.md)
Delete navigation property lists for users

### [Remove-MgBetaUserTodoListExtension](Remove-MgBetaUserTodoListExtension.md)
Delete navigation property extensions for users

### [Remove-MgBetaUserTodoListTask](Remove-MgBetaUserTodoListTask.md)
Delete navigation property tasks for users

### [Remove-MgBetaUserTodoListTaskAttachment](Remove-MgBetaUserTodoListTaskAttachment.md)
Delete navigation property attachments for users

### [Remove-MgBetaUserTodoListTaskAttachmentSession](Remove-MgBetaUserTodoListTaskAttachmentSession.md)
Delete navigation property attachmentSessions for users

### [Remove-MgBetaUserTodoListTaskChecklistItem](Remove-MgBetaUserTodoListTaskChecklistItem.md)
Delete navigation property checklistItems for users

### [Remove-MgBetaUserTodoListTaskExtension](Remove-MgBetaUserTodoListTaskExtension.md)
Delete navigation property extensions for users

### [Remove-MgBetaUserTodoListTaskLinkedResource](Remove-MgBetaUserTodoListTaskLinkedResource.md)
Delete navigation property linkedResources for users

### [Set-MgBetaUserManagerByRef](Set-MgBetaUserManagerByRef.md)
Update the ref of navigation property manager in users

### [Set-MgBetaUserPhotoContent](Set-MgBetaUserPhotoContent.md)
Update media content for the navigation property photo in users

### [Set-MgBetaUserTodoListTaskAttachmentContent](Set-MgBetaUserTodoListTaskAttachmentContent.md)
Update media content for the navigation property attachments in users

### [Set-MgBetaUserTodoListTaskAttachmentSessionContent](Set-MgBetaUserTodoListTaskAttachmentSessionContent.md)
The content streams that are uploaded.

### [Update-MgBetaUser](Update-MgBetaUser.md)
Update the properties of a user object.
Not all properties can be updated by Member or Guest users with their default permissions without Administrator roles.
Compare member and guest default permissions to see properties they can manage.

### [Update-MgBetaUserExtension](Update-MgBetaUserExtension.md)
Update the navigation property extensions in users

### [Update-MgBetaUserLicenseDetail](Update-MgBetaUserLicenseDetail.md)
Update the navigation property licenseDetails in users

### [Update-MgBetaUserNotification](Update-MgBetaUserNotification.md)
Update the navigation property notifications in users

### [Update-MgBetaUserOutlookMasterCategory](Update-MgBetaUserOutlookMasterCategory.md)
Update the navigation property masterCategories in users

### [Update-MgBetaUserOutlookTask](Update-MgBetaUserOutlookTask.md)
Update the navigation property tasks in users

### [Update-MgBetaUserOutlookTaskFolder](Update-MgBetaUserOutlookTaskFolder.md)
Update the navigation property taskFolders in users

### [Update-MgBetaUserOutlookTaskFolderMultiValueExtendedProperty](Update-MgBetaUserOutlookTaskFolderMultiValueExtendedProperty.md)
Update the navigation property multiValueExtendedProperties in users

### [Update-MgBetaUserOutlookTaskFolderSingleValueExtendedProperty](Update-MgBetaUserOutlookTaskFolderSingleValueExtendedProperty.md)
Update the navigation property singleValueExtendedProperties in users

### [Update-MgBetaUserOutlookTaskFolderTask](Update-MgBetaUserOutlookTaskFolderTask.md)
Update the navigation property tasks in users

### [Update-MgBetaUserOutlookTaskFolderTaskMultiValueExtendedProperty](Update-MgBetaUserOutlookTaskFolderTaskMultiValueExtendedProperty.md)
Update the navigation property multiValueExtendedProperties in users

### [Update-MgBetaUserOutlookTaskFolderTaskSingleValueExtendedProperty](Update-MgBetaUserOutlookTaskFolderTaskSingleValueExtendedProperty.md)
Update the navigation property singleValueExtendedProperties in users

### [Update-MgBetaUserOutlookTaskGroup](Update-MgBetaUserOutlookTaskGroup.md)
Update the navigation property taskGroups in users

### [Update-MgBetaUserOutlookTaskGroupTaskFolder](Update-MgBetaUserOutlookTaskGroupTaskFolder.md)
Update the navigation property taskFolders in users

### [Update-MgBetaUserOutlookTaskGroupTaskFolderMultiValueExtendedProperty](Update-MgBetaUserOutlookTaskGroupTaskFolderMultiValueExtendedProperty.md)
Update the navigation property multiValueExtendedProperties in users

### [Update-MgBetaUserOutlookTaskGroupTaskFolderSingleValueExtendedProperty](Update-MgBetaUserOutlookTaskGroupTaskFolderSingleValueExtendedProperty.md)
Update the navigation property singleValueExtendedProperties in users

### [Update-MgBetaUserOutlookTaskGroupTaskFolderTask](Update-MgBetaUserOutlookTaskGroupTaskFolderTask.md)
Update the navigation property tasks in users

### [Update-MgBetaUserOutlookTaskGroupTaskFolderTaskMultiValueExtendedProperty](Update-MgBetaUserOutlookTaskGroupTaskFolderTaskMultiValueExtendedProperty.md)
Update the navigation property multiValueExtendedProperties in users

### [Update-MgBetaUserOutlookTaskGroupTaskFolderTaskSingleValueExtendedProperty](Update-MgBetaUserOutlookTaskGroupTaskFolderTaskSingleValueExtendedProperty.md)
Update the navigation property singleValueExtendedProperties in users

### [Update-MgBetaUserOutlookTaskMultiValueExtendedProperty](Update-MgBetaUserOutlookTaskMultiValueExtendedProperty.md)
Update the navigation property multiValueExtendedProperties in users

### [Update-MgBetaUserOutlookTaskSingleValueExtendedProperty](Update-MgBetaUserOutlookTaskSingleValueExtendedProperty.md)
Update the navigation property singleValueExtendedProperties in users

### [Update-MgBetaUserPhoto](Update-MgBetaUserPhoto.md)
Update the navigation property photo in users

### [Update-MgBetaUserSetting](Update-MgBetaUserSetting.md)
Update the navigation property settings in users

### [Update-MgBetaUserSettingContactMergeSuggestion](Update-MgBetaUserSettingContactMergeSuggestion.md)
Update the properties of a contactMergeSuggestions object.

### [Update-MgBetaUserSettingItemInsight](Update-MgBetaUserSettingItemInsight.md)
Update the privacy settings for itemInsights and meeting hours insights of a user.

### [Update-MgBetaUserSettingRegionalAndLanguageSetting](Update-MgBetaUserSettingRegionalAndLanguageSetting.md)
Update the navigation property regionalAndLanguageSettings in users

### [Update-MgBetaUserSettingShiftPreference](Update-MgBetaUserSettingShiftPreference.md)
Update the properties and relationships of a shiftPreferences object.

### [Update-MgBetaUserTodoList](Update-MgBetaUserTodoList.md)
Update the navigation property lists in users

### [Update-MgBetaUserTodoListExtension](Update-MgBetaUserTodoListExtension.md)
Update the navigation property extensions in users

### [Update-MgBetaUserTodoListTask](Update-MgBetaUserTodoListTask.md)
Update the navigation property tasks in users

### [Update-MgBetaUserTodoListTaskAttachmentSession](Update-MgBetaUserTodoListTaskAttachmentSession.md)
Update the navigation property attachmentSessions in users

### [Update-MgBetaUserTodoListTaskChecklistItem](Update-MgBetaUserTodoListTaskChecklistItem.md)
Update the navigation property checklistItems in users

### [Update-MgBetaUserTodoListTaskExtension](Update-MgBetaUserTodoListTaskExtension.md)
Update the navigation property extensions in users

### [Update-MgBetaUserTodoListTaskLinkedResource](Update-MgBetaUserTodoListTaskLinkedResource.md)
Update the navigation property linkedResources in users

