---
Module Name: Microsoft.Graph.Beta.Users
Module Guid: c50c6b93-adea-4f8f-8f15-f4a4932494e5
Download Help Link: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.users
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Beta.Users Module
## Description
Microsoft Graph PowerShell Cmdlets

## Microsoft.Graph.Beta.Users Cmdlets
### [Get-MgBetaUser](Get-MgBetaUser.md)
Retrieve the properties and relationships of user object.
This operation returns by default only a subset of the more commonly used properties for each user.
These default properties are noted in the Properties section.
To get properties that are not returned by default, do a GET operation for the user and specify the properties in a $select OData query option.
Because the user resource supports extensions, you can also use the GET operation to get custom properties and extension data in a user instance.
This API is available in the following national cloud deployments.

### [Get-MgBetaUserAppRoleAssignedResource](Get-MgBetaUserAppRoleAssignedResource.md)
Get appRoleAssignedResources from users

### [Get-MgBetaUserAppRoleAssignedResourceCount](Get-MgBetaUserAppRoleAssignedResourceCount.md)
Get the number of the resource

### [Get-MgBetaUserCount](Get-MgBetaUserCount.md)
Get the number of the resource

### [Get-MgBetaUserCreatedObject](Get-MgBetaUserCreatedObject.md)
Directory objects that the user created.
Read-only.
Nullable.

### [Get-MgBetaUserCreatedObjectAsServicePrincipal](Get-MgBetaUserCreatedObjectAsServicePrincipal.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.servicePrincipal

### [Get-MgBetaUserCreatedObjectCount](Get-MgBetaUserCreatedObjectCount.md)
Get the number of the resource

### [Get-MgBetaUserCreatedObjectCountAsServicePrincipal](Get-MgBetaUserCreatedObjectCountAsServicePrincipal.md)
Get the number of the resource

### [Get-MgBetaUserDirectReport](Get-MgBetaUserDirectReport.md)
The users and contacts that report to the user.
(The users and contacts that have their manager property set to this user.) Read-only.
Nullable.
Supports $expand.

### [Get-MgBetaUserDirectReportAsOrgContact](Get-MgBetaUserDirectReportAsOrgContact.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.orgContact

### [Get-MgBetaUserDirectReportAsUser](Get-MgBetaUserDirectReportAsUser.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.user

### [Get-MgBetaUserDirectReportCount](Get-MgBetaUserDirectReportCount.md)
Get the number of the resource

### [Get-MgBetaUserDirectReportCountAsOrgContact](Get-MgBetaUserDirectReportCountAsOrgContact.md)
Get the number of the resource

### [Get-MgBetaUserDirectReportCountAsUser](Get-MgBetaUserDirectReportCountAsUser.md)
Get the number of the resource

### [Get-MgBetaUserExtension](Get-MgBetaUserExtension.md)
The collection of open extensions defined for the user.
Supports $expand.
Nullable.

### [Get-MgBetaUserExtensionCount](Get-MgBetaUserExtensionCount.md)
Get the number of the resource

### [Get-MgBetaUserInsight](Get-MgBetaUserInsight.md)
Get insights from users

### [Get-MgBetaUserInsightShared](Get-MgBetaUserInsightShared.md)
Access this property from the derived type itemInsights.

### [Get-MgBetaUserInsightSharedCount](Get-MgBetaUserInsightSharedCount.md)
Get the number of the resource

### [Get-MgBetaUserInsightSharedLastSharedMethod](Get-MgBetaUserInsightSharedLastSharedMethod.md)
Get lastSharedMethod from users

### [Get-MgBetaUserInsightSharedResource](Get-MgBetaUserInsightSharedResource.md)
Used for navigating to the item that was shared.
For file attachments, the type is fileAttachment.
For linked attachments, the type is driveItem.

### [Get-MgBetaUserInsightTrending](Get-MgBetaUserInsightTrending.md)
Access this property from the derived type itemInsights.

### [Get-MgBetaUserInsightTrendingCount](Get-MgBetaUserInsightTrendingCount.md)
Get the number of the resource

### [Get-MgBetaUserInsightTrendingResource](Get-MgBetaUserInsightTrendingResource.md)
Used for navigating to the trending document.

### [Get-MgBetaUserInsightUsed](Get-MgBetaUserInsightUsed.md)
Access this property from the derived type itemInsights.

### [Get-MgBetaUserInsightUsedCount](Get-MgBetaUserInsightUsedCount.md)
Get the number of the resource

### [Get-MgBetaUserInsightUsedResource](Get-MgBetaUserInsightUsedResource.md)
Used for navigating to the item that was used.
For file attachments, the type is fileAttachment.
For linked attachments, the type is driveItem.

### [Get-MgBetaUserLicenseDetail](Get-MgBetaUserLicenseDetail.md)
Get licenseDetails from users

### [Get-MgBetaUserLicenseDetailCount](Get-MgBetaUserLicenseDetailCount.md)
Get the number of the resource

### [Get-MgBetaUserMailboxSetting](Get-MgBetaUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgBetaUserManager](Get-MgBetaUserManager.md)
Returns the user or organizational contact assigned as the user's manager.
Optionally, you can expand the manager's chain up to the root node.
This API is available in the following national cloud deployments.

### [Get-MgBetaUserManagerByRef](Get-MgBetaUserManagerByRef.md)
Returns the user or organizational contact assigned as the user's manager.
Optionally, you can expand the manager's chain up to the root node.
This API is available in the following national cloud deployments.

### [Get-MgBetaUserMemberOf](Get-MgBetaUserMemberOf.md)
The groups, directory roles and administrative units that the user is a member of.
Read-only.
Nullable.
Supports $expand.

### [Get-MgBetaUserMemberOfAsAdministrativeUnit](Get-MgBetaUserMemberOfAsAdministrativeUnit.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.administrativeUnit

### [Get-MgBetaUserMemberOfAsDirectoryRole](Get-MgBetaUserMemberOfAsDirectoryRole.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.directoryRole

### [Get-MgBetaUserMemberOfAsGroup](Get-MgBetaUserMemberOfAsGroup.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.group

### [Get-MgBetaUserMemberOfCount](Get-MgBetaUserMemberOfCount.md)
Get the number of the resource

### [Get-MgBetaUserMemberOfCountAsAdministrativeUnit](Get-MgBetaUserMemberOfCountAsAdministrativeUnit.md)
Get the number of the resource

### [Get-MgBetaUserMemberOfCountAsDirectoryRole](Get-MgBetaUserMemberOfCountAsDirectoryRole.md)
Get the number of the resource

### [Get-MgBetaUserMemberOfCountAsGroup](Get-MgBetaUserMemberOfCountAsGroup.md)
Get the number of the resource

### [Get-MgBetaUserNotification](Get-MgBetaUserNotification.md)
Get notifications from users

### [Get-MgBetaUserNotificationCount](Get-MgBetaUserNotificationCount.md)
Get the number of the resource

### [Get-MgBetaUserOauth2PermissionGrant](Get-MgBetaUserOauth2PermissionGrant.md)
Get oauth2PermissionGrants from users

### [Get-MgBetaUserOauth2PermissionGrantCount](Get-MgBetaUserOauth2PermissionGrantCount.md)
Get the number of the resource

### [Get-MgBetaUserOutlookMasterCategory](Get-MgBetaUserOutlookMasterCategory.md)
Get the properties and relationships of the specified outlookCategory object.
This API is available in the following national cloud deployments.

### [Get-MgBetaUserOutlookMasterCategoryCount](Get-MgBetaUserOutlookMasterCategoryCount.md)
Get the number of the resource

### [Get-MgBetaUserOutlookTask](Get-MgBetaUserOutlookTask.md)
Get the properties and relationships of an Outlook task in the user's mailbox.
By default, this operation (and the POST, PATCH, and complete task operations) returns date-related properties in UTC.
You can use the Prefer: outlook.timezone header to have all the date-related properties in the response represented in a time zone different than UTC.
This API is available in the following national cloud deployments.

### [Get-MgBetaUserOutlookTaskAttachment](Get-MgBetaUserOutlookTaskAttachment.md)
The collection of fileAttachment, itemAttachment, and referenceAttachment attachments for the task.
Read-only.
Nullable.

### [Get-MgBetaUserOutlookTaskAttachmentCount](Get-MgBetaUserOutlookTaskAttachmentCount.md)
Get the number of the resource

### [Get-MgBetaUserOutlookTaskCount](Get-MgBetaUserOutlookTaskCount.md)
Get the number of the resource

### [Get-MgBetaUserOutlookTaskFolder](Get-MgBetaUserOutlookTaskFolder.md)
Get the properties and relationships of the specified Outlook task folder.
This API is available in the following national cloud deployments.

### [Get-MgBetaUserOutlookTaskFolderCount](Get-MgBetaUserOutlookTaskFolderCount.md)
Get the number of the resource

### [Get-MgBetaUserOutlookTaskFolderTask](Get-MgBetaUserOutlookTaskFolderTask.md)
The tasks in this task folder.
Read-only.
Nullable.

### [Get-MgBetaUserOutlookTaskFolderTaskAttachment](Get-MgBetaUserOutlookTaskFolderTaskAttachment.md)
The collection of fileAttachment, itemAttachment, and referenceAttachment attachments for the task.
Read-only.
Nullable.

### [Get-MgBetaUserOutlookTaskFolderTaskAttachmentCount](Get-MgBetaUserOutlookTaskFolderTaskAttachmentCount.md)
Get the number of the resource

### [Get-MgBetaUserOutlookTaskFolderTaskCount](Get-MgBetaUserOutlookTaskFolderTaskCount.md)
Get the number of the resource

### [Get-MgBetaUserOutlookTaskGroup](Get-MgBetaUserOutlookTaskGroup.md)
Get the properties and relationships of the specified Outlook task group.
This API is available in the following national cloud deployments.

### [Get-MgBetaUserOutlookTaskGroupCount](Get-MgBetaUserOutlookTaskGroupCount.md)
Get the number of the resource

### [Get-MgBetaUserOutlookTaskGroupTaskFolder](Get-MgBetaUserOutlookTaskGroupTaskFolder.md)
The collection of task folders in the task group.
Read-only.
Nullable.

### [Get-MgBetaUserOutlookTaskGroupTaskFolderCount](Get-MgBetaUserOutlookTaskGroupTaskFolderCount.md)
Get the number of the resource

### [Get-MgBetaUserOutlookTaskGroupTaskFolderTask](Get-MgBetaUserOutlookTaskGroupTaskFolderTask.md)
The tasks in this task folder.
Read-only.
Nullable.

### [Get-MgBetaUserOutlookTaskGroupTaskFolderTaskAttachment](Get-MgBetaUserOutlookTaskGroupTaskFolderTaskAttachment.md)
The collection of fileAttachment, itemAttachment, and referenceAttachment attachments for the task.
Read-only.
Nullable.

### [Get-MgBetaUserOutlookTaskGroupTaskFolderTaskAttachmentCount](Get-MgBetaUserOutlookTaskGroupTaskFolderTaskAttachmentCount.md)
Get the number of the resource

### [Get-MgBetaUserOutlookTaskGroupTaskFolderTaskCount](Get-MgBetaUserOutlookTaskGroupTaskFolderTaskCount.md)
Get the number of the resource

### [Get-MgBetaUserOwnedDevice](Get-MgBetaUserOwnedDevice.md)
Devices that are owned by the user.
Read-only.
Nullable.
Supports $expand.

### [Get-MgBetaUserOwnedDeviceAsDevice](Get-MgBetaUserOwnedDeviceAsDevice.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.device

### [Get-MgBetaUserOwnedDeviceAsEndpoint](Get-MgBetaUserOwnedDeviceAsEndpoint.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.endpoint

### [Get-MgBetaUserOwnedDeviceCount](Get-MgBetaUserOwnedDeviceCount.md)
Get the number of the resource

### [Get-MgBetaUserOwnedDeviceCountAsDevice](Get-MgBetaUserOwnedDeviceCountAsDevice.md)
Get the number of the resource

### [Get-MgBetaUserOwnedDeviceCountAsEndpoint](Get-MgBetaUserOwnedDeviceCountAsEndpoint.md)
Get the number of the resource

### [Get-MgBetaUserOwnedObject](Get-MgBetaUserOwnedObject.md)
Directory objects that are owned by the user.
Read-only.
Nullable.
Supports $expand, $select nested in $expand, and $filter (/$count eq 0, /$count ne 0, /$count eq 1, /$count ne 1).

### [Get-MgBetaUserOwnedObjectAsApplication](Get-MgBetaUserOwnedObjectAsApplication.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.application

### [Get-MgBetaUserOwnedObjectAsGroup](Get-MgBetaUserOwnedObjectAsGroup.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.group

### [Get-MgBetaUserOwnedObjectAsServicePrincipal](Get-MgBetaUserOwnedObjectAsServicePrincipal.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.servicePrincipal

### [Get-MgBetaUserOwnedObjectCount](Get-MgBetaUserOwnedObjectCount.md)
Get the number of the resource

### [Get-MgBetaUserOwnedObjectCountAsApplication](Get-MgBetaUserOwnedObjectCountAsApplication.md)
Get the number of the resource

### [Get-MgBetaUserOwnedObjectCountAsGroup](Get-MgBetaUserOwnedObjectCountAsGroup.md)
Get the number of the resource

### [Get-MgBetaUserOwnedObjectCountAsServicePrincipal](Get-MgBetaUserOwnedObjectCountAsServicePrincipal.md)
Get the number of the resource

### [Get-MgBetaUserPhoto](Get-MgBetaUserPhoto.md)
The user's profile photo.
Read-only.

### [Get-MgBetaUserPhotoContent](Get-MgBetaUserPhotoContent.md)
Get media content for the navigation property photo from users

### [Get-MgBetaUserPhotoCount](Get-MgBetaUserPhotoCount.md)
Get the number of the resource

### [Get-MgBetaUserRegisteredDevice](Get-MgBetaUserRegisteredDevice.md)
Devices that are registered for the user.
Read-only.
Nullable.
Supports $expand and returns up to 100 objects.

### [Get-MgBetaUserRegisteredDeviceAsDevice](Get-MgBetaUserRegisteredDeviceAsDevice.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.device

### [Get-MgBetaUserRegisteredDeviceAsEndpoint](Get-MgBetaUserRegisteredDeviceAsEndpoint.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.endpoint

### [Get-MgBetaUserRegisteredDeviceCount](Get-MgBetaUserRegisteredDeviceCount.md)
Get the number of the resource

### [Get-MgBetaUserRegisteredDeviceCountAsDevice](Get-MgBetaUserRegisteredDeviceCountAsDevice.md)
Get the number of the resource

### [Get-MgBetaUserRegisteredDeviceCountAsEndpoint](Get-MgBetaUserRegisteredDeviceCountAsEndpoint.md)
Get the number of the resource

### [Get-MgBetaUserSetting](Get-MgBetaUserSetting.md)
Get settings from users

### [Get-MgBetaUserSettingContactMergeSuggestion](Get-MgBetaUserSettingContactMergeSuggestion.md)
Read the properties and relationships of a contactMergeSuggestions object.
This API is available in the following national cloud deployments.

### [Get-MgBetaUserSettingItemInsight](Get-MgBetaUserSettingItemInsight.md)
Get the user-customizable privacy settings for itemInsights and meeting hours insights.
This API is available in the following national cloud deployments.

### [Get-MgBetaUserSettingRegionalAndLanguageSetting](Get-MgBetaUserSettingRegionalAndLanguageSetting.md)
Retrieve the properties of a user's regionalAndLanguageSettings.
This API is available in the following national cloud deployments.

### [Get-MgBetaUserSettingShiftPreference](Get-MgBetaUserSettingShiftPreference.md)
Retrieve the properties and relationships of a shiftPreferences object by ID.
This API is available in the following national cloud deployments.

### [Get-MgBetaUserSponsor](Get-MgBetaUserSponsor.md)
The users and groups that are responsible for this guest user's privileges in the tenant and keep the guest user's information and access updated.
(HTTP Methods: GET, POST, DELETE.).
Supports $expand.

### [Get-MgBetaUserSponsorCount](Get-MgBetaUserSponsorCount.md)
Get the number of the resource

### [Get-MgBetaUserTodoList](Get-MgBetaUserTodoList.md)
Read the properties and relationships of a todoTaskList object.
This API is available in the following national cloud deployments.

### [Get-MgBetaUserTodoListCount](Get-MgBetaUserTodoListCount.md)
Get the number of the resource

### [Get-MgBetaUserTodoListExtension](Get-MgBetaUserTodoListExtension.md)
The collection of open extensions defined for the task list.
Nullable.

### [Get-MgBetaUserTodoListExtensionCount](Get-MgBetaUserTodoListExtensionCount.md)
Get the number of the resource

### [Get-MgBetaUserTodoTask](Get-MgBetaUserTodoTask.md)
Read the properties and relationships of a todoTask object.
This API is available in the following national cloud deployments.

### [Get-MgBetaUserTodoTaskAttachment](Get-MgBetaUserTodoTaskAttachment.md)
Read the properties and relationships of a taskFileAttachment object.
This API is available in the following national cloud deployments.

### [Get-MgBetaUserTodoTaskAttachmentContent](Get-MgBetaUserTodoTaskAttachmentContent.md)
Get media content for the navigation property attachments from users

### [Get-MgBetaUserTodoTaskAttachmentCount](Get-MgBetaUserTodoTaskAttachmentCount.md)
Get the number of the resource

### [Get-MgBetaUserTodoTaskAttachmentSession](Get-MgBetaUserTodoTaskAttachmentSession.md)
Get attachmentSessions from users

### [Get-MgBetaUserTodoTaskAttachmentSessionContent](Get-MgBetaUserTodoTaskAttachmentSessionContent.md)
The content streams that are uploaded.

### [Get-MgBetaUserTodoTaskAttachmentSessionCount](Get-MgBetaUserTodoTaskAttachmentSessionCount.md)
Get the number of the resource

### [Get-MgBetaUserTodoTaskChecklistItem](Get-MgBetaUserTodoTaskChecklistItem.md)
Read the properties and relationships of a checklistItem object.
This API is available in the following national cloud deployments.

### [Get-MgBetaUserTodoTaskChecklistItemCount](Get-MgBetaUserTodoTaskChecklistItemCount.md)
Get the number of the resource

### [Get-MgBetaUserTodoTaskCount](Get-MgBetaUserTodoTaskCount.md)
Get the number of the resource

### [Get-MgBetaUserTodoTaskExtension](Get-MgBetaUserTodoTaskExtension.md)
The collection of open extensions defined for the task.
Nullable.

### [Get-MgBetaUserTodoTaskExtensionCount](Get-MgBetaUserTodoTaskExtensionCount.md)
Get the number of the resource

### [Get-MgBetaUserTodoTaskLinkedResource](Get-MgBetaUserTodoTaskLinkedResource.md)
Read the properties and relationships of a linkedResource object.
This API is available in the following national cloud deployments.

### [Get-MgBetaUserTodoTaskLinkedResourceCount](Get-MgBetaUserTodoTaskLinkedResourceCount.md)
Get the number of the resource

### [Get-MgBetaUserTransitiveMemberOf](Get-MgBetaUserTransitiveMemberOf.md)
The groups, including nested groups, and directory roles that a user is a member of.
Nullable.

### [Get-MgBetaUserTransitiveMemberOfAsAdministrativeUnit](Get-MgBetaUserTransitiveMemberOfAsAdministrativeUnit.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.administrativeUnit

### [Get-MgBetaUserTransitiveMemberOfAsDirectoryRole](Get-MgBetaUserTransitiveMemberOfAsDirectoryRole.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.directoryRole

### [Get-MgBetaUserTransitiveMemberOfAsGroup](Get-MgBetaUserTransitiveMemberOfAsGroup.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.group

### [Get-MgBetaUserTransitiveMemberOfCount](Get-MgBetaUserTransitiveMemberOfCount.md)
Get the number of the resource

### [Get-MgBetaUserTransitiveMemberOfCountAsAdministrativeUnit](Get-MgBetaUserTransitiveMemberOfCountAsAdministrativeUnit.md)
Get the number of the resource

### [Get-MgBetaUserTransitiveMemberOfCountAsDirectoryRole](Get-MgBetaUserTransitiveMemberOfCountAsDirectoryRole.md)
Get the number of the resource

### [Get-MgBetaUserTransitiveMemberOfCountAsGroup](Get-MgBetaUserTransitiveMemberOfCountAsGroup.md)
Get the number of the resource

### [Get-MgBetaUserTransitiveReport](Get-MgBetaUserTransitiveReport.md)
The transitive reports for a user.
Read-only.

### [Get-MgBetaUserTransitiveReportCount](Get-MgBetaUserTransitiveReportCount.md)
Get the number of the resource

### [New-MgBetaUser](New-MgBetaUser.md)
Create a new user.\nThe request body contains the user to create.
At a minimum, you must specify the required properties for the user.
You can optionally specify any other writable properties.
This operation returns by default only a subset of the properties for each user.
These default properties are noted in the Properties section.
To get properties that are not returned by default, do a GET operation and specify the properties in a $select OData query option.
This API is available in the following national cloud deployments.

### [New-MgBetaUserExtension](New-MgBetaUserExtension.md)
Create new navigation property to extensions for users

### [New-MgBetaUserInsightShared](New-MgBetaUserInsightShared.md)
Create new navigation property to shared for users

### [New-MgBetaUserInsightTrending](New-MgBetaUserInsightTrending.md)
Create new navigation property to trending for users

### [New-MgBetaUserInsightUsed](New-MgBetaUserInsightUsed.md)
Create new navigation property to used for users

### [New-MgBetaUserNotification](New-MgBetaUserNotification.md)
Create new navigation property to notifications for users

### [New-MgBetaUserOutlookMasterCategory](New-MgBetaUserOutlookMasterCategory.md)
Create an outlookCategory object in the user's master list of categories.
This API is available in the following national cloud deployments.

### [New-MgBetaUserOutlookTask](New-MgBetaUserOutlookTask.md)
Create an Outlook task in the default task group (My Tasks) and default task folder (Tasks) in the user's mailbox.
The POST method always ignores the time portion of startDateTime and dueDateTime in the request body, and assumes the time \nto be always midnight in the specified time zone.
By default, this operation (and the GET, PATCH, and complete task operations) returns date-related properties in UTC.
\nYou can use the Prefer: outlook.timezone header to have all the date-related properties in the response represented in a time zone \ndifferent than UTC.
This API is available in the following national cloud deployments.

### [New-MgBetaUserOutlookTaskAttachment](New-MgBetaUserOutlookTaskAttachment.md)
Use this API to add an attachment to an outlookTask.
The attachment can be a file (of fileAttachment type) or Outlook item (itemAttachment type).
This API is available in the following national cloud deployments.

### [New-MgBetaUserOutlookTaskFolder](New-MgBetaUserOutlookTaskFolder.md)
Create a task folder in the default task group (My Tasks) of the user's mailbox.
This API is available in the following national cloud deployments.

### [New-MgBetaUserOutlookTaskFolderTask](New-MgBetaUserOutlookTaskFolderTask.md)
Create an Outlook task in the specified task folder.
The POST method always ignores the time portion of startDateTime and dueDateTime in the request body, and assumes the time \nto be always midnight in the specified time zone.
This API is available in the following national cloud deployments.

### [New-MgBetaUserOutlookTaskFolderTaskAttachment](New-MgBetaUserOutlookTaskFolderTaskAttachment.md)
Use this API to add an attachment to an outlookTask.
The attachment can be a file (of fileAttachment type) or Outlook item (itemAttachment type).
This API is available in the following national cloud deployments.

### [New-MgBetaUserOutlookTaskGroup](New-MgBetaUserOutlookTaskGroup.md)
Create an Outlook task group in the user's mailbox.
This API is available in the following national cloud deployments.

### [New-MgBetaUserOutlookTaskGroupTaskFolder](New-MgBetaUserOutlookTaskGroupTaskFolder.md)
Create an Outlook task folder under a specified outlookTaskGroup.
This API is available in the following national cloud deployments.

### [New-MgBetaUserOutlookTaskGroupTaskFolderTask](New-MgBetaUserOutlookTaskGroupTaskFolderTask.md)
Create an Outlook task in the specified task folder.
The POST method always ignores the time portion of startDateTime and dueDateTime in the request body, and assumes the time \nto be always midnight in the specified time zone.
This API is available in the following national cloud deployments.

### [New-MgBetaUserOutlookTaskGroupTaskFolderTaskAttachment](New-MgBetaUserOutlookTaskGroupTaskFolderTaskAttachment.md)
Use this API to add an attachment to an outlookTask.
The attachment can be a file (of fileAttachment type) or Outlook item (itemAttachment type).
This API is available in the following national cloud deployments.

### [New-MgBetaUserTodoList](New-MgBetaUserTodoList.md)
Create a new lists object.
This API is available in the following national cloud deployments.

### [New-MgBetaUserTodoListExtension](New-MgBetaUserTodoListExtension.md)
Create new navigation property to extensions for users

### [New-MgBetaUserTodoListTask](New-MgBetaUserTodoListTask.md)
Create a new task object in a specified todoTaskList.
This API is available in the following national cloud deployments.

### [New-MgBetaUserTodoListTaskAttachment](New-MgBetaUserTodoListTaskAttachment.md)
Add a new taskFileAttachment object to a todoTask.
This operation limits the size of the attachment you can add to under 3 MB.
If the size of the file attachments is more than 3 MB, create an upload session to upload the attachments.
This API is available in the following national cloud deployments.

### [New-MgBetaUserTodoListTaskChecklistItem](New-MgBetaUserTodoListTaskChecklistItem.md)
Create a new checklistItem object as a subtask in a bigger todoTask.
This API is available in the following national cloud deployments.

### [New-MgBetaUserTodoListTaskExtension](New-MgBetaUserTodoListTaskExtension.md)
Create new navigation property to extensions for users

### [New-MgBetaUserTodoListTaskLinkedResource](New-MgBetaUserTodoListTaskLinkedResource.md)
Create a linkedResource object to associate a specified task with an item in a partner application.
For example, you can associate a task with an email item in Outlook that spurred the task, and you can create a linkedResource object to track its association.
You can also create a linkedResource object while creating a todoTask.
This API is available in the following national cloud deployments.

### [Remove-MgBetaUser](Remove-MgBetaUser.md)
Delete user.
 When deleted, user resources are moved to a temporary container and can be restored within 30 days.
After that time, they are permanently deleted.
To learn more, see deletedItems.
This API is available in the following national cloud deployments.

### [Remove-MgBetaUserExtension](Remove-MgBetaUserExtension.md)
Delete navigation property extensions for users

### [Remove-MgBetaUserInsight](Remove-MgBetaUserInsight.md)
Delete navigation property insights for users

### [Remove-MgBetaUserInsightShared](Remove-MgBetaUserInsightShared.md)
Delete navigation property shared for users

### [Remove-MgBetaUserInsightTrending](Remove-MgBetaUserInsightTrending.md)
Delete navigation property trending for users

### [Remove-MgBetaUserInsightUsed](Remove-MgBetaUserInsightUsed.md)
Delete navigation property used for users

### [Remove-MgBetaUserLicenseDetail](Remove-MgBetaUserLicenseDetail.md)
Delete navigation property licenseDetails for users

### [Remove-MgBetaUserManager](Remove-MgBetaUserManager.md)
Remove a user's manager.
This API is available in the following national cloud deployments.

### [Remove-MgBetaUserManagerByRef](Remove-MgBetaUserManagerByRef.md)
Remove a user's manager.
This API is available in the following national cloud deployments.

### [Remove-MgBetaUserNotification](Remove-MgBetaUserNotification.md)
Delete navigation property notifications for users

### [Remove-MgBetaUserOutlookMasterCategory](Remove-MgBetaUserOutlookMasterCategory.md)
Delete the specified outlookCategory object.
This API is available in the following national cloud deployments.

### [Remove-MgBetaUserOutlookTask](Remove-MgBetaUserOutlookTask.md)
Delete the specified Outlook task in the user's mailbox.
This API is available in the following national cloud deployments.

### [Remove-MgBetaUserOutlookTaskAttachment](Remove-MgBetaUserOutlookTaskAttachment.md)
Delete navigation property attachments for users

### [Remove-MgBetaUserOutlookTaskFolder](Remove-MgBetaUserOutlookTaskFolder.md)
Delete the specified Outlook task folder.
This API is available in the following national cloud deployments.

### [Remove-MgBetaUserOutlookTaskFolderTask](Remove-MgBetaUserOutlookTaskFolderTask.md)
Delete navigation property tasks for users

### [Remove-MgBetaUserOutlookTaskFolderTaskAttachment](Remove-MgBetaUserOutlookTaskFolderTaskAttachment.md)
Delete navigation property attachments for users

### [Remove-MgBetaUserOutlookTaskGroup](Remove-MgBetaUserOutlookTaskGroup.md)
Delete navigation property taskGroups for users

### [Remove-MgBetaUserOutlookTaskGroupTaskFolder](Remove-MgBetaUserOutlookTaskGroupTaskFolder.md)
Delete navigation property taskFolders for users

### [Remove-MgBetaUserOutlookTaskGroupTaskFolderTask](Remove-MgBetaUserOutlookTaskGroupTaskFolderTask.md)
Delete navigation property tasks for users

### [Remove-MgBetaUserOutlookTaskGroupTaskFolderTaskAttachment](Remove-MgBetaUserOutlookTaskGroupTaskFolderTaskAttachment.md)
Delete navigation property attachments for users

### [Remove-MgBetaUserPhoto](Remove-MgBetaUserPhoto.md)
Delete navigation property photo for users

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

### [Remove-MgBetaUserSponsor](Remove-MgBetaUserSponsor.md)
Remove a user's sponsor.

### [Remove-MgBetaUserTodoList](Remove-MgBetaUserTodoList.md)
Deletes a todoTaskList object.
This API is available in the following national cloud deployments.

### [Remove-MgBetaUserTodoListExtension](Remove-MgBetaUserTodoListExtension.md)
Delete navigation property extensions for users

### [Remove-MgBetaUserTodoListTask](Remove-MgBetaUserTodoListTask.md)
Deletes a todoTask object.
This API is available in the following national cloud deployments.

### [Remove-MgBetaUserTodoListTaskAttachment](Remove-MgBetaUserTodoListTaskAttachment.md)
Delete a taskFileAttachment object from a todoTask resource.
This API is available in the following national cloud deployments.

### [Remove-MgBetaUserTodoListTaskAttachmentSession](Remove-MgBetaUserTodoListTaskAttachmentSession.md)
Delete navigation property attachmentSessions for users

### [Remove-MgBetaUserTodoListTaskChecklistItem](Remove-MgBetaUserTodoListTaskChecklistItem.md)
Delete a checklistItem object.
This API is available in the following national cloud deployments.

### [Remove-MgBetaUserTodoListTaskExtension](Remove-MgBetaUserTodoListTaskExtension.md)
Delete navigation property extensions for users

### [Remove-MgBetaUserTodoListTaskLinkedResource](Remove-MgBetaUserTodoListTaskLinkedResource.md)
Deletes a linkedResource object.
This API is available in the following national cloud deployments.

### [Set-MgBetaUserManagerByRef](Set-MgBetaUserManagerByRef.md)
Assign a user's manager.
This API is available in the following national cloud deployments.

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
This API is available in the following national cloud deployments.

### [Update-MgBetaUserExtension](Update-MgBetaUserExtension.md)
Update the navigation property extensions in users

### [Update-MgBetaUserInsight](Update-MgBetaUserInsight.md)
Update the navigation property insights in users

### [Update-MgBetaUserInsightShared](Update-MgBetaUserInsightShared.md)
Update the navigation property shared in users

### [Update-MgBetaUserInsightTrending](Update-MgBetaUserInsightTrending.md)
Update the navigation property trending in users

### [Update-MgBetaUserInsightUsed](Update-MgBetaUserInsightUsed.md)
Update the navigation property used in users

### [Update-MgBetaUserLicenseDetail](Update-MgBetaUserLicenseDetail.md)
Update the navigation property licenseDetails in users

### [Update-MgBetaUserMailboxSetting](Update-MgBetaUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaUserNotification](Update-MgBetaUserNotification.md)
Update the navigation property notifications in users

### [Update-MgBetaUserOutlookMasterCategory](Update-MgBetaUserOutlookMasterCategory.md)
Update the writable property, color, of the specified outlookCategory object.
You can't modify the displayName property\nonce you have created the category.
This API is available in the following national cloud deployments.

### [Update-MgBetaUserOutlookTask](Update-MgBetaUserOutlookTask.md)
Change writable properties of an Outlook task.
The completedDateTime property can be set by the complete action, or explicitly by a PATCH operation.
If you use PATCH to set completedDateTime, make sure you set status to completed as well.
By default, this operation (and the POST, GET, and complete task operations) returns date-related properties in UTC.
You can use the Prefer: outlook.timezone header to have all the date-related properties in the response represented in a time zone different than UTC.
This API is available in the following national cloud deployments.

### [Update-MgBetaUserOutlookTaskFolder](Update-MgBetaUserOutlookTaskFolder.md)
Update the writable properties of an Outlook task folder.
You cannot change the name property value of the default task folder, 'Tasks'.
This API is available in the following national cloud deployments.

### [Update-MgBetaUserOutlookTaskFolderTask](Update-MgBetaUserOutlookTaskFolderTask.md)
Update the navigation property tasks in users

### [Update-MgBetaUserOutlookTaskGroup](Update-MgBetaUserOutlookTaskGroup.md)
Update the navigation property taskGroups in users

### [Update-MgBetaUserOutlookTaskGroupTaskFolder](Update-MgBetaUserOutlookTaskGroupTaskFolder.md)
Update the navigation property taskFolders in users

### [Update-MgBetaUserOutlookTaskGroupTaskFolderTask](Update-MgBetaUserOutlookTaskGroupTaskFolderTask.md)
Update the navigation property tasks in users

### [Update-MgBetaUserPhoto](Update-MgBetaUserPhoto.md)
Update the navigation property photo in users

### [Update-MgBetaUserSetting](Update-MgBetaUserSetting.md)
Update the navigation property settings in users

### [Update-MgBetaUserSettingContactMergeSuggestion](Update-MgBetaUserSettingContactMergeSuggestion.md)
Update the properties of a contactMergeSuggestions object.
This API is available in the following national cloud deployments.

### [Update-MgBetaUserSettingItemInsight](Update-MgBetaUserSettingItemInsight.md)
Update the privacy settings for itemInsights and meeting hours insights of a user.
This API is available in the following national cloud deployments.

### [Update-MgBetaUserSettingRegionalAndLanguageSetting](Update-MgBetaUserSettingRegionalAndLanguageSetting.md)
Update some or all of the properties of a regionalAndLanguageSettings object.
This API is available in the following national cloud deployments.

### [Update-MgBetaUserSettingShiftPreference](Update-MgBetaUserSettingShiftPreference.md)
Update the properties and relationships of a shiftPreferences object.

### [Update-MgBetaUserTodoList](Update-MgBetaUserTodoList.md)
Update the properties of a todoTaskList object.
This API is available in the following national cloud deployments.

### [Update-MgBetaUserTodoListExtension](Update-MgBetaUserTodoListExtension.md)
Update the navigation property extensions in users

### [Update-MgBetaUserTodoListTask](Update-MgBetaUserTodoListTask.md)
Update the properties of a todoTask object.
This API is available in the following national cloud deployments.

### [Update-MgBetaUserTodoListTaskAttachmentSession](Update-MgBetaUserTodoListTaskAttachmentSession.md)
Update the navigation property attachmentSessions in users

### [Update-MgBetaUserTodoListTaskChecklistItem](Update-MgBetaUserTodoListTaskChecklistItem.md)
Update the properties of a checklistItem object.
This API is available in the following national cloud deployments.

### [Update-MgBetaUserTodoListTaskExtension](Update-MgBetaUserTodoListTaskExtension.md)
Update the navigation property extensions in users

### [Update-MgBetaUserTodoListTaskLinkedResource](Update-MgBetaUserTodoListTaskLinkedResource.md)
Update the properties of a linkedResource object.
This API is available in the following national cloud deployments.

