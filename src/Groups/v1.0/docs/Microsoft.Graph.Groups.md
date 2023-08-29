---
Module Name: Microsoft.Graph.Groups
Module Guid: c174dfaa-93ad-4de7-aa05-e1b06cea0c09
Download Help Link: https://learn.microsoft.com/powershell/module/microsoft.graph.groups
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Groups Module
## Description
Microsoft Graph PowerShell Cmdlets

## Microsoft.Graph.Groups Cmdlets
### [Add-MgGroupDriveListContentTypeCopy](Add-MgGroupDriveListContentTypeCopy.md)
Add a copy of a [content type][contentType] from a [site][site] to a [list][list].

### [Add-MgGroupDriveListContentTypeCopyFromContentTypeHub](Add-MgGroupDriveListContentTypeCopyFromContentTypeHub.md)
Add or sync a copy of a published content type from the content type hub to a target site or a list.
This method is part of the content type publishing changes to optimize the syncing of published content types to sites and lists, effectively switching from a 'push everywhere' to 'pull as needed' approach.
The method allows users to pull content types directly from the content type hub to a site or list.
For more information, see contentType: getCompatibleHubContentTypes and the blog post Syntex Product Updates – August 2021.

### [Add-MgGroupFavorite](Add-MgGroupFavorite.md)
Add the group to the list of the current user's favorite groups.
Supported for Microsoft 365 groups only.

### [Add-MgGroupSite](Add-MgGroupSite.md)
Follow a user's site or multiple sites.

### [Add-MgGroupSiteContentTypeCopy](Add-MgGroupSiteContentTypeCopy.md)
Add a copy of a [content type][contentType] from a [site][site] to a [list][list].

### [Add-MgGroupSiteContentTypeCopyFromContentTypeHub](Add-MgGroupSiteContentTypeCopyFromContentTypeHub.md)
Add or sync a copy of a published content type from the content type hub to a target site or a list.
This method is part of the content type publishing changes to optimize the syncing of published content types to sites and lists, effectively switching from a 'push everywhere' to 'pull as needed' approach.
The method allows users to pull content types directly from the content type hub to a site or list.
For more information, see contentType: getCompatibleHubContentTypes and the blog post Syntex Product Updates – August 2021.

### [Add-MgGroupSiteListContentTypeCopy](Add-MgGroupSiteListContentTypeCopy.md)
Add a copy of a [content type][contentType] from a [site][site] to a [list][list].

### [Add-MgGroupSiteListContentTypeCopyFromContentTypeHub](Add-MgGroupSiteListContentTypeCopyFromContentTypeHub.md)
Add or sync a copy of a published content type from the content type hub to a target site or a list.
This method is part of the content type publishing changes to optimize the syncing of published content types to sites and lists, effectively switching from a 'push everywhere' to 'pull as needed' approach.
The method allows users to pull content types directly from the content type hub to a site or list.
For more information, see contentType: getCompatibleHubContentTypes and the blog post Syntex Product Updates – August 2021.

### [Add-MgGroupToLifecyclePolicy](Add-MgGroupToLifecyclePolicy.md)
Adds specific groups to a lifecycle policy.
This action limits the group lifecycle policy to a set of groups only if the managedGroupTypes property of groupLifecyclePolicy is set to Selected.

### [Confirm-MgGroupGrantedPermissionForApp](Confirm-MgGroupGrantedPermissionForApp.md)
Invoke action checkGrantedPermissionsForApp

### [Confirm-MgGroupMemberGroup](Confirm-MgGroupMemberGroup.md)
Check for membership in a specified list of group IDs, and return from that list those groups (identified by IDs) of which the specified user, group, service principal, organizational contact, device, or directory object is a member.
This function is transitive.
You can check up to a maximum of 20 groups per request.
This function supports all groups provisioned in Azure AD.
Because Microsoft 365 groups cannot contain other groups, membership in a Microsoft 365 group is always direct.

### [Confirm-MgGroupMemberObject](Confirm-MgGroupMemberObject.md)
Invoke action checkMemberObjects

### [Confirm-MgGroupPermissionGrantMemberGroup](Confirm-MgGroupPermissionGrantMemberGroup.md)
Check for membership in a specified list of group IDs, and return from that list those groups (identified by IDs) of which the specified user, group, service principal, organizational contact, device, or directory object is a member.
This function is transitive.
You can check up to a maximum of 20 groups per request.
This function supports all groups provisioned in Azure AD.
Because Microsoft 365 groups cannot contain other groups, membership in a Microsoft 365 group is always direct.

### [Confirm-MgGroupPermissionGrantMemberObject](Confirm-MgGroupPermissionGrantMemberObject.md)
Invoke action checkMemberObjects

### [Confirm-MgGroupSettingTemplateMemberGroup](Confirm-MgGroupSettingTemplateMemberGroup.md)
Check for membership in a specified list of group IDs, and return from that list those groups (identified by IDs) of which the specified user, group, service principal, organizational contact, device, or directory object is a member.
This function is transitive.
You can check up to a maximum of 20 groups per request.
This function supports all groups provisioned in Azure AD.
Because Microsoft 365 groups cannot contain other groups, membership in a Microsoft 365 group is always direct.

### [Confirm-MgGroupSettingTemplateMemberObject](Confirm-MgGroupSettingTemplateMemberObject.md)
Invoke action checkMemberObjects

### [Copy-MgGroupDriveItem](Copy-MgGroupDriveItem.md)
Asynchronously creates a copy of an [driveItem][item-resource] (including any children), under a new parent item or with a new name.

### [Copy-MgGroupDriveListContentTypeToDefaultContentLocation](Copy-MgGroupDriveListContentTypeToDefaultContentLocation.md)
Copy a file to a default content location in a [content type][contentType].
The file can then be added as a default file or template via a POST operation.

### [Copy-MgGroupDriveRoot](Copy-MgGroupDriveRoot.md)
Asynchronously creates a copy of an [driveItem][item-resource] (including any children), under a new parent item or with a new name.

### [Copy-MgGroupOnenoteNotebook](Copy-MgGroupOnenoteNotebook.md)
For Copy operations, you follow an asynchronous calling pattern:  First call the Copy action, and then poll the operation endpoint for the result.

### [Copy-MgGroupOnenotePageToSection](Copy-MgGroupOnenotePageToSection.md)
Copy a page to a specific section.
For copy operations, you follow an asynchronous calling pattern:  First call the Copy action, and then poll the operation endpoint for the result.

### [Copy-MgGroupOnenoteSectionToNotebook](Copy-MgGroupOnenoteSectionToNotebook.md)
For Copy operations, you follow an asynchronous calling pattern:  First call the Copy action, and then poll the operation endpoint for the result.

### [Copy-MgGroupOnenoteSectionToSectionGroup](Copy-MgGroupOnenoteSectionToSectionGroup.md)
For Copy operations, you follow an asynchronous calling pattern:  First call the Copy action, and then poll the operation endpoint for the result.

### [Copy-MgGroupSiteContentTypeToDefaultContentLocation](Copy-MgGroupSiteContentTypeToDefaultContentLocation.md)
Copy a file to a default content location in a [content type][contentType].
The file can then be added as a default file or template via a POST operation.

### [Copy-MgGroupSiteListContentTypeToDefaultContentLocation](Copy-MgGroupSiteListContentTypeToDefaultContentLocation.md)
Copy a file to a default content location in a [content type][contentType].
The file can then be added as a default file or template via a POST operation.

### [Get-MgAllGroupSite](Get-MgAllGroupSite.md)
Invoke function getAllSites

### [Get-MgGroup](Get-MgGroup.md)
Get the properties and relationships of a group object.
This operation returns by default only a subset of all the available properties, as noted in the Properties section.
To get properties that are not returned by default, specify them in a $select OData query option.
The hasMembersWithLicenseErrors and isArchived properties are an exception and are not returned in the $select query.

### [Get-MgGroupAcceptedSender](Get-MgGroupAcceptedSender.md)
Users in the accepted senders list can post to conversations of the group (identified in the GET request URL).\nMake sure you do not specify the same user or group in the accepted senders and rejected senders lists, otherwise you will get an error.

### [Get-MgGroupAcceptedSenderByRef](Get-MgGroupAcceptedSenderByRef.md)
Users in the accepted senders list can post to conversations of the group (identified in the GET request URL).\nMake sure you do not specify the same user or group in the accepted senders and rejected senders lists, otherwise you will get an error.

### [Get-MgGroupAcceptedSenderCount](Get-MgGroupAcceptedSenderCount.md)
Get the number of the resource

### [Get-MgGroupById](Get-MgGroupById.md)
Return the directory objects specified in a list of IDs.
Only a subset of user properties are returned by default in v1.0.
Some common uses for this function are to:

### [Get-MgGroupCalendarEventDelta](Get-MgGroupCalendarEventDelta.md)
Get a set of event resources that have been added, deleted, or updated in a calendarView (a range of events defined by start and end dates) of the user's primary calendar.
Typically, synchronizing events in a calendarView in a local store entails a round of multiple delta function calls.
The initial call is a full synchronization, and every subsequent delta call in the same round gets the incremental changes (additions, deletions, or updates).
This allows you to maintain and synchronize a local store of events in the specified calendarView, without having to fetch all the events of that calendar from the server every time.

### [Get-MgGroupCalendarSchedule](Get-MgGroupCalendarSchedule.md)
Get the free/busy availability information for a collection of users, distributions lists, or resources (rooms or equipment) for a specified time period.

### [Get-MgGroupConversation](Get-MgGroupConversation.md)
Retrieve the properties and relationships of conversation object.

### [Get-MgGroupConversationCount](Get-MgGroupConversationCount.md)
Get the number of the resource

### [Get-MgGroupConversationThread](Get-MgGroupConversationThread.md)
A collection of all the conversation threads in the conversation.
A navigation property.
Read-only.
Nullable.

### [Get-MgGroupConversationThreadCount](Get-MgGroupConversationThreadCount.md)
Get the number of the resource

### [Get-MgGroupConversationThreadPost](Get-MgGroupConversationThreadPost.md)
Get posts from groups

### [Get-MgGroupConversationThreadPostAttachment](Get-MgGroupConversationThreadPostAttachment.md)
Read-only.
Nullable.
Supports $expand.

### [Get-MgGroupConversationThreadPostAttachmentCount](Get-MgGroupConversationThreadPostAttachmentCount.md)
Get the number of the resource

### [Get-MgGroupConversationThreadPostCount](Get-MgGroupConversationThreadPostCount.md)
Get the number of the resource

### [Get-MgGroupConversationThreadPostExtension](Get-MgGroupConversationThreadPostExtension.md)
Get an open extension (openTypeExtension object) identified by name or fully qualified name.
The table in the Permissions section lists the resources that support open extensions.
The following table lists the three scenarios where you can get an open extension from a supported resource instance.

### [Get-MgGroupConversationThreadPostExtensionCount](Get-MgGroupConversationThreadPostExtensionCount.md)
Get the number of the resource

### [Get-MgGroupConversationThreadPostInReplyToAttachment](Get-MgGroupConversationThreadPostInReplyToAttachment.md)
Read-only.
Nullable.
Supports $expand.

### [Get-MgGroupConversationThreadPostInReplyToAttachmentCount](Get-MgGroupConversationThreadPostInReplyToAttachmentCount.md)
Get the number of the resource

### [Get-MgGroupConversationThreadPostInReplyToExtension](Get-MgGroupConversationThreadPostInReplyToExtension.md)
Get an open extension (openTypeExtension object) identified by name or fully qualified name.
The table in the Permissions section lists the resources that support open extensions.
The following table lists the three scenarios where you can get an open extension from a supported resource instance.

### [Get-MgGroupConversationThreadPostInReplyToExtensionCount](Get-MgGroupConversationThreadPostInReplyToExtensionCount.md)
Get the number of the resource

### [Get-MgGroupCount](Get-MgGroupCount.md)
Get the number of the resource

### [Get-MgGroupCreatedOnBehalfOf](Get-MgGroupCreatedOnBehalfOf.md)
The user (or application) that created the group.
NOTE: This is not set if the user is an administrator.
Read-only.

### [Get-MgGroupDelta](Get-MgGroupDelta.md)
Invoke function delta

### [Get-MgGroupDriveItemActivityByInterval](Get-MgGroupDriveItemActivityByInterval.md)
Invoke function getActivitiesByInterval

### [Get-MgGroupDriveItemDelta](Get-MgGroupDriveItemDelta.md)
Invoke function delta

### [Get-MgGroupDriveItemListItemActivityByInterval](Get-MgGroupDriveItemListItemActivityByInterval.md)
Invoke function getActivitiesByInterval

### [Get-MgGroupDriveListContentTypeCompatibleHubContentType](Get-MgGroupDriveListContentTypeCompatibleHubContentType.md)
Invoke function getCompatibleHubContentTypes

### [Get-MgGroupDriveListItemActivityByInterval](Get-MgGroupDriveListItemActivityByInterval.md)
Invoke function getActivitiesByInterval

### [Get-MgGroupDriveRootActivityByInterval](Get-MgGroupDriveRootActivityByInterval.md)
Invoke function getActivitiesByInterval

### [Get-MgGroupDriveRootDelta](Get-MgGroupDriveRootDelta.md)
Invoke function delta

### [Get-MgGroupDriveRootListItemActivityByInterval](Get-MgGroupDriveRootListItemActivityByInterval.md)
Invoke function getActivitiesByInterval

### [Get-MgGroupEventDelta](Get-MgGroupEventDelta.md)
Get a set of event resources that have been added, deleted, or updated in a calendarView (a range of events defined by start and end dates) of the user's primary calendar.
Typically, synchronizing events in a calendarView in a local store entails a round of multiple delta function calls.
The initial call is a full synchronization, and every subsequent delta call in the same round gets the incremental changes (additions, deletions, or updates).
This allows you to maintain and synchronize a local store of events in the specified calendarView, without having to fetch all the events of that calendar from the server every time.

### [Get-MgGroupExtension](Get-MgGroupExtension.md)
The collection of open extensions defined for the group.
Read-only.
Nullable.

### [Get-MgGroupExtensionCount](Get-MgGroupExtensionCount.md)
Get the number of the resource

### [Get-MgGroupLifecyclePolicy](Get-MgGroupLifecyclePolicy.md)
Retrieve the properties and relationships of a groupLifecyclePolicies object.

### [Get-MgGroupLifecyclePolicyByGroup](Get-MgGroupLifecyclePolicyByGroup.md)
Retrieves a list of groupLifecyclePolicy objects to which a group belongs.

### [Get-MgGroupLifecyclePolicyCount](Get-MgGroupLifecyclePolicyCount.md)
Get the number of the resource

### [Get-MgGroupMember](Get-MgGroupMember.md)
The members of this group, who can be users, devices, other groups, or service principals.
Supports the List members, Add member, and Remove member operations.
Nullable.
Supports $expand including nested $select.
For example, /groups?$filter=startsWith(displayName,'Role')&$select=id,displayName&$expand=members($select=id,userPrincipalName,displayName).

### [Get-MgGroupMemberAsApplication](Get-MgGroupMemberAsApplication.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.application

### [Get-MgGroupMemberAsDevice](Get-MgGroupMemberAsDevice.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.device

### [Get-MgGroupMemberAsGroup](Get-MgGroupMemberAsGroup.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.group

### [Get-MgGroupMemberAsOrgContact](Get-MgGroupMemberAsOrgContact.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.orgContact

### [Get-MgGroupMemberAsServicePrincipal](Get-MgGroupMemberAsServicePrincipal.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.servicePrincipal

### [Get-MgGroupMemberAsUser](Get-MgGroupMemberAsUser.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.user

### [Get-MgGroupMemberByRef](Get-MgGroupMemberByRef.md)
The members of this group, who can be users, devices, other groups, or service principals.
Supports the List members, Add member, and Remove member operations.
Nullable.
Supports $expand including nested $select.
For example, /groups?$filter=startsWith(displayName,'Role')&$select=id,displayName&$expand=members($select=id,userPrincipalName,displayName).

### [Get-MgGroupMemberCount](Get-MgGroupMemberCount.md)
Get the number of the resource

### [Get-MgGroupMemberCountAsApplication](Get-MgGroupMemberCountAsApplication.md)
Get the number of the resource

### [Get-MgGroupMemberCountAsDevice](Get-MgGroupMemberCountAsDevice.md)
Get the number of the resource

### [Get-MgGroupMemberCountAsGroup](Get-MgGroupMemberCountAsGroup.md)
Get the number of the resource

### [Get-MgGroupMemberCountAsOrgContact](Get-MgGroupMemberCountAsOrgContact.md)
Get the number of the resource

### [Get-MgGroupMemberCountAsServicePrincipal](Get-MgGroupMemberCountAsServicePrincipal.md)
Get the number of the resource

### [Get-MgGroupMemberCountAsUser](Get-MgGroupMemberCountAsUser.md)
Get the number of the resource

### [Get-MgGroupMemberGroup](Get-MgGroupMemberGroup.md)
Return all the group IDs for the groups that the specified user, group, service principal, organizational contact, device, or directory object is a member of.
This function is transitive.
This API returns up to 11,000 group IDs.
If more than 11,000 results are available, it returns a 400 Bad Request error with the Directory_ResultSizeLimitExceeded error code.
As a workaround, use the List group transitive memberOf API.

### [Get-MgGroupMemberObject](Get-MgGroupMemberObject.md)
Return all IDs for the groups, administrative units, and directory roles that a user, group, service principal, organizational contact, device, or directory object is a member of.
This function is transitive.
Note: Only users and role-enabled groups can be members of directory roles.

### [Get-MgGroupMemberOf](Get-MgGroupMemberOf.md)
Groups that this group is a member of.
HTTP Methods: GET (supported for all groups).
Read-only.
Nullable.
Supports $expand.

### [Get-MgGroupMemberOfAsAdministrativeUnit](Get-MgGroupMemberOfAsAdministrativeUnit.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.administrativeUnit

### [Get-MgGroupMemberOfAsGroup](Get-MgGroupMemberOfAsGroup.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.group

### [Get-MgGroupMemberOfCount](Get-MgGroupMemberOfCount.md)
Get the number of the resource

### [Get-MgGroupMemberOfCountAsAdministrativeUnit](Get-MgGroupMemberOfCountAsAdministrativeUnit.md)
Get the number of the resource

### [Get-MgGroupMemberOfCountAsGroup](Get-MgGroupMemberOfCountAsGroup.md)
Get the number of the resource

### [Get-MgGroupMemberWithLicenseError](Get-MgGroupMemberWithLicenseError.md)
A list of group members with license errors from this group-based license assignment.
Read-only.

### [Get-MgGroupMemberWithLicenseErrorAsApplication](Get-MgGroupMemberWithLicenseErrorAsApplication.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.application

### [Get-MgGroupMemberWithLicenseErrorAsDevice](Get-MgGroupMemberWithLicenseErrorAsDevice.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.device

### [Get-MgGroupMemberWithLicenseErrorAsGroup](Get-MgGroupMemberWithLicenseErrorAsGroup.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.group

### [Get-MgGroupMemberWithLicenseErrorAsOrgContact](Get-MgGroupMemberWithLicenseErrorAsOrgContact.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.orgContact

### [Get-MgGroupMemberWithLicenseErrorAsServicePrincipal](Get-MgGroupMemberWithLicenseErrorAsServicePrincipal.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.servicePrincipal

### [Get-MgGroupMemberWithLicenseErrorAsUser](Get-MgGroupMemberWithLicenseErrorAsUser.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.user

### [Get-MgGroupMemberWithLicenseErrorCount](Get-MgGroupMemberWithLicenseErrorCount.md)
Get the number of the resource

### [Get-MgGroupMemberWithLicenseErrorCountAsApplication](Get-MgGroupMemberWithLicenseErrorCountAsApplication.md)
Get the number of the resource

### [Get-MgGroupMemberWithLicenseErrorCountAsDevice](Get-MgGroupMemberWithLicenseErrorCountAsDevice.md)
Get the number of the resource

### [Get-MgGroupMemberWithLicenseErrorCountAsGroup](Get-MgGroupMemberWithLicenseErrorCountAsGroup.md)
Get the number of the resource

### [Get-MgGroupMemberWithLicenseErrorCountAsOrgContact](Get-MgGroupMemberWithLicenseErrorCountAsOrgContact.md)
Get the number of the resource

### [Get-MgGroupMemberWithLicenseErrorCountAsServicePrincipal](Get-MgGroupMemberWithLicenseErrorCountAsServicePrincipal.md)
Get the number of the resource

### [Get-MgGroupMemberWithLicenseErrorCountAsUser](Get-MgGroupMemberWithLicenseErrorCountAsUser.md)
Get the number of the resource

### [Get-MgGroupOnenoteNotebookFromWebUrl](Get-MgGroupOnenoteNotebookFromWebUrl.md)
Retrieve the properties and relationships of a notebook object by using its URL path.
The location can be user notebooks on Microsoft 365, group notebooks, or SharePoint site-hosted team notebooks on Microsoft 365.

### [Get-MgGroupOnenoteRecentNotebook](Get-MgGroupOnenoteRecentNotebook.md)
Invoke function getRecentNotebooks

### [Get-MgGroupOwner](Get-MgGroupOwner.md)
The owners of the group.
Limited to 100 owners.
Nullable.
If this property is not specified when creating a Microsoft 365 group, the calling user is automatically assigned as the group owner.
Supports $filter (/$count eq 0, /$count ne 0, /$count eq 1, /$count ne 1).
Supports $expand including nested $select.
For example, /groups?$filter=startsWith(displayName,'Role')&$select=id,displayName&$expand=owners($select=id,userPrincipalName,displayName).

### [Get-MgGroupOwnerAsApplication](Get-MgGroupOwnerAsApplication.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.application

### [Get-MgGroupOwnerAsDevice](Get-MgGroupOwnerAsDevice.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.device

### [Get-MgGroupOwnerAsGroup](Get-MgGroupOwnerAsGroup.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.group

### [Get-MgGroupOwnerAsOrgContact](Get-MgGroupOwnerAsOrgContact.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.orgContact

### [Get-MgGroupOwnerAsServicePrincipal](Get-MgGroupOwnerAsServicePrincipal.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.servicePrincipal

### [Get-MgGroupOwnerAsUser](Get-MgGroupOwnerAsUser.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.user

### [Get-MgGroupOwnerByRef](Get-MgGroupOwnerByRef.md)
The owners of the group.
Limited to 100 owners.
Nullable.
If this property is not specified when creating a Microsoft 365 group, the calling user is automatically assigned as the group owner.
Supports $filter (/$count eq 0, /$count ne 0, /$count eq 1, /$count ne 1).
Supports $expand including nested $select.
For example, /groups?$filter=startsWith(displayName,'Role')&$select=id,displayName&$expand=owners($select=id,userPrincipalName,displayName).

### [Get-MgGroupOwnerCount](Get-MgGroupOwnerCount.md)
Get the number of the resource

### [Get-MgGroupOwnerCountAsApplication](Get-MgGroupOwnerCountAsApplication.md)
Get the number of the resource

### [Get-MgGroupOwnerCountAsDevice](Get-MgGroupOwnerCountAsDevice.md)
Get the number of the resource

### [Get-MgGroupOwnerCountAsGroup](Get-MgGroupOwnerCountAsGroup.md)
Get the number of the resource

### [Get-MgGroupOwnerCountAsOrgContact](Get-MgGroupOwnerCountAsOrgContact.md)
Get the number of the resource

### [Get-MgGroupOwnerCountAsServicePrincipal](Get-MgGroupOwnerCountAsServicePrincipal.md)
Get the number of the resource

### [Get-MgGroupOwnerCountAsUser](Get-MgGroupOwnerCountAsUser.md)
Get the number of the resource

### [Get-MgGroupPermissionGrant](Get-MgGroupPermissionGrant.md)
Get permissionGrants from groups

### [Get-MgGroupPermissionGrantById](Get-MgGroupPermissionGrantById.md)
Return the directory objects specified in a list of IDs.
Only a subset of user properties are returned by default in v1.0.
Some common uses for this function are to:

### [Get-MgGroupPermissionGrantCount](Get-MgGroupPermissionGrantCount.md)
Get the number of the resource

### [Get-MgGroupPermissionGrantDelta](Get-MgGroupPermissionGrantDelta.md)
Invoke function delta

### [Get-MgGroupPermissionGrantMemberGroup](Get-MgGroupPermissionGrantMemberGroup.md)
Return all the group IDs for the groups that the specified user, group, service principal, organizational contact, device, or directory object is a member of.
This function is transitive.
This API returns up to 11,000 group IDs.
If more than 11,000 results are available, it returns a 400 Bad Request error with the Directory_ResultSizeLimitExceeded error code.
As a workaround, use the List group transitive memberOf API.

### [Get-MgGroupPermissionGrantMemberObject](Get-MgGroupPermissionGrantMemberObject.md)
Return all IDs for the groups, administrative units, and directory roles that a user, group, service principal, organizational contact, device, or directory object is a member of.
This function is transitive.
Note: Only users and role-enabled groups can be members of directory roles.

### [Get-MgGroupPhoto](Get-MgGroupPhoto.md)
The group's profile photo

### [Get-MgGroupPhotoContent](Get-MgGroupPhotoContent.md)
Get media content for the navigation property photo from groups

### [Get-MgGroupPhotoCount](Get-MgGroupPhotoCount.md)
Get the number of the resource

### [Get-MgGroupRejectedSender](Get-MgGroupRejectedSender.md)
Users in the rejected senders list cannot post to conversations of the group (identified in the GET request URL).
Make sure you do not specify the same user or group in the rejected senders and accepted senders lists, otherwise you will get an error.

### [Get-MgGroupRejectedSenderByRef](Get-MgGroupRejectedSenderByRef.md)
Users in the rejected senders list cannot post to conversations of the group (identified in the GET request URL).
Make sure you do not specify the same user or group in the rejected senders and accepted senders lists, otherwise you will get an error.

### [Get-MgGroupRejectedSenderCount](Get-MgGroupRejectedSenderCount.md)
Get the number of the resource

### [Get-MgGroupSetting](Get-MgGroupSetting.md)
Retrieve the properties of a specific group setting object.
The setting can be a tenant-level or group-specific setting.

### [Get-MgGroupSettingCount](Get-MgGroupSettingCount.md)
Get the number of the resource

### [Get-MgGroupSettingTemplateById](Get-MgGroupSettingTemplateById.md)
Return the directory objects specified in a list of IDs.
Only a subset of user properties are returned by default in v1.0.
Some common uses for this function are to:

### [Get-MgGroupSettingTemplateCount](Get-MgGroupSettingTemplateCount.md)
Get the number of the resource

### [Get-MgGroupSettingTemplateDelta](Get-MgGroupSettingTemplateDelta.md)
Invoke function delta

### [Get-MgGroupSettingTemplateGroupSettingTemplate](Get-MgGroupSettingTemplateGroupSettingTemplate.md)
A group setting template represents a template of settings from which settings may be created within a tenant.
This operation allows retrieval of the properties of the groupSettingTemplate object, including the available settings and their defaults.

### [Get-MgGroupSettingTemplateMemberGroup](Get-MgGroupSettingTemplateMemberGroup.md)
Return all the group IDs for the groups that the specified user, group, service principal, organizational contact, device, or directory object is a member of.
This function is transitive.
This API returns up to 11,000 group IDs.
If more than 11,000 results are available, it returns a 400 Bad Request error with the Directory_ResultSizeLimitExceeded error code.
As a workaround, use the List group transitive memberOf API.

### [Get-MgGroupSettingTemplateMemberObject](Get-MgGroupSettingTemplateMemberObject.md)
Return all IDs for the groups, administrative units, and directory roles that a user, group, service principal, organizational contact, device, or directory object is a member of.
This function is transitive.
Note: Only users and role-enabled groups can be members of directory roles.

### [Get-MgGroupSiteActivityByInterval](Get-MgGroupSiteActivityByInterval.md)
Invoke function getActivitiesByInterval

### [Get-MgGroupSiteApplicableContentTypeForList](Get-MgGroupSiteApplicableContentTypeForList.md)
Invoke function getApplicableContentTypesForList

### [Get-MgGroupSiteByPath](Get-MgGroupSiteByPath.md)
Invoke function getByPath

### [Get-MgGroupSiteContentTypeCompatibleHubContentType](Get-MgGroupSiteContentTypeCompatibleHubContentType.md)
Invoke function getCompatibleHubContentTypes

### [Get-MgGroupSiteListContentTypeCompatibleHubContentType](Get-MgGroupSiteListContentTypeCompatibleHubContentType.md)
Invoke function getCompatibleHubContentTypes

### [Get-MgGroupSiteListItemActivityByInterval](Get-MgGroupSiteListItemActivityByInterval.md)
Invoke function getActivitiesByInterval

### [Get-MgGroupThread](Get-MgGroupThread.md)
Get a thread object.

### [Get-MgGroupThreadCount](Get-MgGroupThreadCount.md)
Get the number of the resource

### [Get-MgGroupThreadPost](Get-MgGroupThreadPost.md)
Get posts from groups

### [Get-MgGroupThreadPostAttachment](Get-MgGroupThreadPostAttachment.md)
Read-only.
Nullable.
Supports $expand.

### [Get-MgGroupThreadPostAttachmentCount](Get-MgGroupThreadPostAttachmentCount.md)
Get the number of the resource

### [Get-MgGroupThreadPostCount](Get-MgGroupThreadPostCount.md)
Get the number of the resource

### [Get-MgGroupThreadPostExtension](Get-MgGroupThreadPostExtension.md)
Get an open extension (openTypeExtension object) identified by name or fully qualified name.
The table in the Permissions section lists the resources that support open extensions.
The following table lists the three scenarios where you can get an open extension from a supported resource instance.

### [Get-MgGroupThreadPostExtensionCount](Get-MgGroupThreadPostExtensionCount.md)
Get the number of the resource

### [Get-MgGroupThreadPostInReplyToAttachment](Get-MgGroupThreadPostInReplyToAttachment.md)
Read-only.
Nullable.
Supports $expand.

### [Get-MgGroupThreadPostInReplyToAttachmentCount](Get-MgGroupThreadPostInReplyToAttachmentCount.md)
Get the number of the resource

### [Get-MgGroupThreadPostInReplyToExtension](Get-MgGroupThreadPostInReplyToExtension.md)
Get an open extension (openTypeExtension object) identified by name or fully qualified name.
The table in the Permissions section lists the resources that support open extensions.
The following table lists the three scenarios where you can get an open extension from a supported resource instance.

### [Get-MgGroupThreadPostInReplyToExtensionCount](Get-MgGroupThreadPostInReplyToExtensionCount.md)
Get the number of the resource

### [Get-MgGroupTransitiveMember](Get-MgGroupTransitiveMember.md)
The direct and transitive members of a group.
Nullable.

### [Get-MgGroupTransitiveMemberAsApplication](Get-MgGroupTransitiveMemberAsApplication.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.application

### [Get-MgGroupTransitiveMemberAsDevice](Get-MgGroupTransitiveMemberAsDevice.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.device

### [Get-MgGroupTransitiveMemberAsGroup](Get-MgGroupTransitiveMemberAsGroup.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.group

### [Get-MgGroupTransitiveMemberAsOrgContact](Get-MgGroupTransitiveMemberAsOrgContact.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.orgContact

### [Get-MgGroupTransitiveMemberAsServicePrincipal](Get-MgGroupTransitiveMemberAsServicePrincipal.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.servicePrincipal

### [Get-MgGroupTransitiveMemberAsUser](Get-MgGroupTransitiveMemberAsUser.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.user

### [Get-MgGroupTransitiveMemberCount](Get-MgGroupTransitiveMemberCount.md)
Get the number of the resource

### [Get-MgGroupTransitiveMemberCountAsApplication](Get-MgGroupTransitiveMemberCountAsApplication.md)
Get the number of the resource

### [Get-MgGroupTransitiveMemberCountAsDevice](Get-MgGroupTransitiveMemberCountAsDevice.md)
Get the number of the resource

### [Get-MgGroupTransitiveMemberCountAsGroup](Get-MgGroupTransitiveMemberCountAsGroup.md)
Get the number of the resource

### [Get-MgGroupTransitiveMemberCountAsOrgContact](Get-MgGroupTransitiveMemberCountAsOrgContact.md)
Get the number of the resource

### [Get-MgGroupTransitiveMemberCountAsServicePrincipal](Get-MgGroupTransitiveMemberCountAsServicePrincipal.md)
Get the number of the resource

### [Get-MgGroupTransitiveMemberCountAsUser](Get-MgGroupTransitiveMemberCountAsUser.md)
Get the number of the resource

### [Get-MgGroupTransitiveMemberOf](Get-MgGroupTransitiveMemberOf.md)
The groups that a group is a member of, either directly and through nested membership.
Nullable.

### [Get-MgGroupTransitiveMemberOfAsAdministrativeUnit](Get-MgGroupTransitiveMemberOfAsAdministrativeUnit.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.administrativeUnit

### [Get-MgGroupTransitiveMemberOfAsGroup](Get-MgGroupTransitiveMemberOfAsGroup.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.group

### [Get-MgGroupTransitiveMemberOfCount](Get-MgGroupTransitiveMemberOfCount.md)
Get the number of the resource

### [Get-MgGroupTransitiveMemberOfCountAsAdministrativeUnit](Get-MgGroupTransitiveMemberOfCountAsAdministrativeUnit.md)
Get the number of the resource

### [Get-MgGroupTransitiveMemberOfCountAsGroup](Get-MgGroupTransitiveMemberOfCountAsGroup.md)
Get the number of the resource

### [Grant-MgGroupDriveItemPermission](Grant-MgGroupDriveItemPermission.md)
Grant users access to a link represented by a [permission][].

### [Grant-MgGroupDriveRootPermission](Grant-MgGroupDriveRootPermission.md)
Grant users access to a link represented by a [permission][].

### [Grant-MgGroupSitePermission](Grant-MgGroupSitePermission.md)
Grant users access to a link represented by a [permission][].

### [Invoke-MgAcceptGroupCalendarEvent](Invoke-MgAcceptGroupCalendarEvent.md)
Accept the specified event in a user calendar.

### [Invoke-MgAcceptGroupCalendarEventTentatively](Invoke-MgAcceptGroupCalendarEventTentatively.md)
Tentatively accept the specified event in a user calendar.
If the event allows proposals for new times, on responding tentative to the event, an invitee can choose to suggest an alternative time by including the proposedNewTime parameter.
For more information on how to propose a time, and how to receive and accept a new time proposal, see Propose new meeting times.

### [Invoke-MgAcceptGroupEvent](Invoke-MgAcceptGroupEvent.md)
Accept the specified event in a user calendar.

### [Invoke-MgAcceptGroupEventTentatively](Invoke-MgAcceptGroupEventTentatively.md)
Tentatively accept the specified event in a user calendar.
If the event allows proposals for new times, on responding tentative to the event, an invitee can choose to suggest an alternative time by including the proposedNewTime parameter.
For more information on how to propose a time, and how to receive and accept a new time proposal, see Propose new meeting times.

### [Invoke-MgCalendarGroupCalendar](Invoke-MgCalendarGroupCalendar.md)
Invoke function allowedCalendarSharingRoles

### [Invoke-MgCheckinGroupDriveItem](Invoke-MgCheckinGroupDriveItem.md)
Check in a checked out driveItem resource, which makes the version of the document available to others.

### [Invoke-MgCheckinGroupDriveRoot](Invoke-MgCheckinGroupDriveRoot.md)
Check in a checked out driveItem resource, which makes the version of the document available to others.

### [Invoke-MgCheckoutGroupDriveItem](Invoke-MgCheckoutGroupDriveItem.md)
Check out a driveItem resource to prevent others from editing the document, and prevent your changes from being visible until the documented is checked in.

### [Invoke-MgCheckoutGroupDriveRoot](Invoke-MgCheckoutGroupDriveRoot.md)
Check out a driveItem resource to prevent others from editing the document, and prevent your changes from being visible until the documented is checked in.

### [Invoke-MgDeclineGroupCalendarEvent](Invoke-MgDeclineGroupCalendarEvent.md)
Decline invitation to the specified event in a user calendar.
If the event allows proposals for new times, on declining the event, an invitee can choose to suggest an alternative time by including the proposedNewTime parameter.
For more information on how to propose a time, and how to receive and accept a new time proposal, see Propose new meeting times.

### [Invoke-MgDeclineGroupEvent](Invoke-MgDeclineGroupEvent.md)
Decline invitation to the specified event in a user calendar.
If the event allows proposals for new times, on declining the event, an invitee can choose to suggest an alternative time by including the proposedNewTime parameter.
For more information on how to propose a time, and how to receive and accept a new time proposal, see Propose new meeting times.

### [Invoke-MgDismissGroupCalendarEventReminder](Invoke-MgDismissGroupCalendarEventReminder.md)
Dismiss a reminder that has been triggered for an event in a user calendar.

### [Invoke-MgDismissGroupEventReminder](Invoke-MgDismissGroupEventReminder.md)
Dismiss a reminder that has been triggered for an event in a user calendar.

### [Invoke-MgExtractGroupDriveItemSensitivityLabel](Invoke-MgExtractGroupDriveItemSensitivityLabel.md)
Invoke action extractSensitivityLabels

### [Invoke-MgExtractGroupDriveRootSensitivityLabel](Invoke-MgExtractGroupDriveRootSensitivityLabel.md)
Invoke action extractSensitivityLabels

### [Invoke-MgFollowGroupDriveItem](Invoke-MgFollowGroupDriveItem.md)
Follow a driveItem.

### [Invoke-MgFollowGroupDriveRoot](Invoke-MgFollowGroupDriveRoot.md)
Follow a driveItem.

### [Invoke-MgForwardGroupCalendarEvent](Invoke-MgForwardGroupCalendarEvent.md)
This action allows the organizer or attendee of a meeting event to forward the \nmeeting request to a new recipient.
If the meeting event is forwarded from an attendee's Microsoft 365 mailbox to another recipient, this action \nalso sends a message to notify the organizer of the forwarding, and adds the recipient to the organizer's \ncopy of the meeting event.
This convenience is not available when forwarding from an Outlook.com account.

### [Invoke-MgForwardGroupConversationThreadPost](Invoke-MgForwardGroupConversationThreadPost.md)
Forward a post to a recipient.
You can specify both the parent conversation and thread in the request, \nor, you can specify just the parent thread without the parent conversation.

### [Invoke-MgForwardGroupConversationThreadPostInReplyTo](Invoke-MgForwardGroupConversationThreadPostInReplyTo.md)
Forward a post to a recipient.
You can specify both the parent conversation and thread in the request, \nor, you can specify just the parent thread without the parent conversation.

### [Invoke-MgForwardGroupEvent](Invoke-MgForwardGroupEvent.md)
This action allows the organizer or attendee of a meeting event to forward the \nmeeting request to a new recipient.
If the meeting event is forwarded from an attendee's Microsoft 365 mailbox to another recipient, this action \nalso sends a message to notify the organizer of the forwarding, and adds the recipient to the organizer's \ncopy of the meeting event.
This convenience is not available when forwarding from an Outlook.com account.

### [Invoke-MgForwardGroupThreadPost](Invoke-MgForwardGroupThreadPost.md)
Forward a post to a recipient.
You can specify both the parent conversation and thread in the request, \nor, you can specify just the parent thread without the parent conversation.

### [Invoke-MgForwardGroupThreadPostInReplyTo](Invoke-MgForwardGroupThreadPostInReplyTo.md)
Forward a post to a recipient.
You can specify both the parent conversation and thread in the request, \nor, you can specify just the parent thread without the parent conversation.

### [Invoke-MgGraphGroup](Invoke-MgGraphGroup.md)
Calling this method will prevent the current user from receiving email notifications for this group about new posts, events, and files in that group.
Supported for Microsoft 365 groups only.

### [Invoke-MgGraphGroupDrive](Invoke-MgGraphGroupDrive.md)
Invoke function sharedWithMe

### [Invoke-MgInviteGroupDriveItem](Invoke-MgInviteGroupDriveItem.md)
Sends a sharing invitation for a driveItem.\nA sharing invitation provides permissions to the recipients and optionally sends them an email with a [sharing link][].

### [Invoke-MgInviteGroupDriveRoot](Invoke-MgInviteGroupDriveRoot.md)
Sends a sharing invitation for a driveItem.\nA sharing invitation provides permissions to the recipients and optionally sends them an email with a [sharing link][].

### [Invoke-MgPreviewGroupDriveItem](Invoke-MgPreviewGroupDriveItem.md)
Invoke action preview

### [Invoke-MgPreviewGroupDriveRoot](Invoke-MgPreviewGroupDriveRoot.md)
Invoke action preview

### [Invoke-MgPreviewGroupOnenotePage](Invoke-MgPreviewGroupOnenotePage.md)
Invoke function preview

### [Invoke-MgReauthorizeGroupDriveItemSubscription](Invoke-MgReauthorizeGroupDriveItemSubscription.md)
Reauthorize a subscription when you receive a reauthorizationRequired challenge.

### [Invoke-MgReauthorizeGroupDriveListSubscription](Invoke-MgReauthorizeGroupDriveListSubscription.md)
Reauthorize a subscription when you receive a reauthorizationRequired challenge.

### [Invoke-MgReauthorizeGroupDriveRootSubscription](Invoke-MgReauthorizeGroupDriveRootSubscription.md)
Reauthorize a subscription when you receive a reauthorizationRequired challenge.

### [Invoke-MgReauthorizeGroupSiteListSubscription](Invoke-MgReauthorizeGroupSiteListSubscription.md)
Reauthorize a subscription when you receive a reauthorizationRequired challenge.

### [Invoke-MgRecentGroupDrive](Invoke-MgRecentGroupDrive.md)
Invoke function recent

### [Invoke-MgRenewGroup](Invoke-MgRenewGroup.md)
Renews a group's expiration.
When a group is renewed, the group expiration is extended by the number of days defined in the policy.

### [Invoke-MgReplyGroupConversationThread](Invoke-MgReplyGroupConversationThread.md)
Reply to a thread in a group conversation and add a new post to it.
You can specify the parent conversation \nin the request, or, you can specify just the thread without the parent conversation.

### [Invoke-MgReplyGroupConversationThreadPost](Invoke-MgReplyGroupConversationThreadPost.md)
Create an open extension (openTypeExtension object) and add custom properties in a new or existing instance of a resource.
You can create an open extension in a resource instance and store custom data to it all in the same operation, except for specific resources.
The table in the Permissions section lists the resources that support open extensions.

### [Invoke-MgReplyGroupConversationThreadPostInReplyTo](Invoke-MgReplyGroupConversationThreadPostInReplyTo.md)
Create an open extension (openTypeExtension object) and add custom properties in a new or existing instance of a resource.
You can create an open extension in a resource instance and store custom data to it all in the same operation, except for specific resources.
The table in the Permissions section lists the resources that support open extensions.

### [Invoke-MgReplyGroupThread](Invoke-MgReplyGroupThread.md)
Reply to a thread in a group conversation and add a new post to it.
You can specify the parent conversation \nin the request, or, you can specify just the thread without the parent conversation.

### [Invoke-MgReplyGroupThreadPost](Invoke-MgReplyGroupThreadPost.md)
Create an open extension (openTypeExtension object) and add custom properties in a new or existing instance of a resource.
You can create an open extension in a resource instance and store custom data to it all in the same operation, except for specific resources.
The table in the Permissions section lists the resources that support open extensions.

### [Invoke-MgReplyGroupThreadPostInReplyTo](Invoke-MgReplyGroupThreadPostInReplyTo.md)
Create an open extension (openTypeExtension object) and add custom properties in a new or existing instance of a resource.
You can create an open extension in a resource instance and store custom data to it all in the same operation, except for specific resources.
The table in the Permissions section lists the resources that support open extensions.

### [Invoke-MgRetryGroupServiceProvisioning](Invoke-MgRetryGroupServiceProvisioning.md)
Invoke action retryServiceProvisioning

### [Invoke-MgSnoozeGroupCalendarEventReminder](Invoke-MgSnoozeGroupCalendarEventReminder.md)
Postpone a reminder for an event in a user calendar until a new time.

### [Invoke-MgSnoozeGroupEventReminder](Invoke-MgSnoozeGroupEventReminder.md)
Postpone a reminder for an event in a user calendar until a new time.

### [Invoke-MgSubscribeGroupByMail](Invoke-MgSubscribeGroupByMail.md)
Calling this method will enable the current user to receive email notifications for this group, about new posts, events, and files in that group.
Supported for Microsoft 365 groups only.

### [Invoke-MgUnfollowGroupDriveItem](Invoke-MgUnfollowGroupDriveItem.md)
Unfollow a driveItem.

### [Invoke-MgUnfollowGroupDriveRoot](Invoke-MgUnfollowGroupDriveRoot.md)
Unfollow a driveItem.

### [Join-MgGroupDriveListContentTypeWithHubSite](Join-MgGroupDriveListContentTypeWithHubSite.md)
Associate a published [content type][contentType] present in a content type hub with a list of hub sites.

### [Join-MgGroupSiteContentTypeWithHubSite](Join-MgGroupSiteContentTypeWithHubSite.md)
Associate a published [content type][contentType] present in a content type hub with a list of hub sites.

### [Join-MgGroupSiteListContentTypeWithHubSite](Join-MgGroupSiteListContentTypeWithHubSite.md)
Associate a published [content type][contentType] present in a content type hub with a list of hub sites.

### [New-MgGroup](New-MgGroup.md)
Create a new group as specified in the request body.
You can create the following types of groups: This operation returns by default only a subset of the properties for each group.
These default properties are noted in the Properties section.
To get properties that are not returned by default, do a GET operation and specify the properties in a $select OData query option.

### [New-MgGroupAcceptedSenderByRef](New-MgGroupAcceptedSenderByRef.md)
Specify the user or group in @odata.id in the request body.
Users in the accepted senders list can post to conversations of the group .
Make sure you do not specify the same user or group in the accepted senders and rejected senders lists, otherwise you will get an error.

### [New-MgGroupConversation](New-MgGroupConversation.md)
Create an open extension (openTypeExtension object) and add custom properties in a new or existing instance of a resource.
You can create an open extension in a resource instance and store custom data to it all in the same operation, except for specific resources.
The table in the Permissions section lists the resources that support open extensions.

### [New-MgGroupConversationThread](New-MgGroupConversationThread.md)
Create a new thread in the specified conversation.
A thread and post are created as specified.
Use reply thread to further post \nto that thread.
Or, if you get the post ID, you can also reply to that post in that thread.
Note: You can also start a new conversation by first creating a thread.

### [New-MgGroupConversationThreadPostAttachment](New-MgGroupConversationThreadPostAttachment.md)
Create new navigation property to attachments for groups

### [New-MgGroupConversationThreadPostAttachmentUploadSession](New-MgGroupConversationThreadPostAttachmentUploadSession.md)
Create an upload session that allows an app to iteratively upload ranges of a file, so as to attach the file to the specified Outlook item.
The item can be a message or event.
Use this approach to attach a file if the file size is between 3 MB and 150 MB.
To attach a file that's smaller than 3 MB, do a POST operation on the attachments navigation property of the Outlook item; see how to do this for a message or for an event.
As part of the response, this action returns an upload URL that you can use in subsequent sequential PUT queries.
Request headers for each PUT operation let you specify the exact range of bytes to be uploaded.
This allows transfer to be resumed, in case the network connection is dropped during upload.
The following are the steps to attach a file to an Outlook item using an upload session: See attach large files to Outlook messages or events for an example.

### [New-MgGroupConversationThreadPostExtension](New-MgGroupConversationThreadPostExtension.md)
Create new navigation property to extensions for groups

### [New-MgGroupConversationThreadPostInReplyToAttachment](New-MgGroupConversationThreadPostInReplyToAttachment.md)
Create new navigation property to attachments for groups

### [New-MgGroupConversationThreadPostInReplyToAttachmentUploadSession](New-MgGroupConversationThreadPostInReplyToAttachmentUploadSession.md)
Create an upload session that allows an app to iteratively upload ranges of a file, so as to attach the file to the specified Outlook item.
The item can be a message or event.
Use this approach to attach a file if the file size is between 3 MB and 150 MB.
To attach a file that's smaller than 3 MB, do a POST operation on the attachments navigation property of the Outlook item; see how to do this for a message or for an event.
As part of the response, this action returns an upload URL that you can use in subsequent sequential PUT queries.
Request headers for each PUT operation let you specify the exact range of bytes to be uploaded.
This allows transfer to be resumed, in case the network connection is dropped during upload.
The following are the steps to attach a file to an Outlook item using an upload session: See attach large files to Outlook messages or events for an example.

### [New-MgGroupConversationThreadPostInReplyToExtension](New-MgGroupConversationThreadPostInReplyToExtension.md)
Create new navigation property to extensions for groups

### [New-MgGroupDriveItemLink](New-MgGroupDriveItemLink.md)
You can use createLink action to share a DriveItem via a sharing link.
The createLink action will create a new sharing link if the specified link type doesn't already exist for the calling application.\nIf a sharing link of the specified type already exists for the app, the existing sharing link will be returned.
DriveItem resources inherit sharing permissions from their ancestors.

### [New-MgGroupDriveItemUploadSession](New-MgGroupDriveItemUploadSession.md)
Invoke action createUploadSession

### [New-MgGroupDriveRootLink](New-MgGroupDriveRootLink.md)
You can use createLink action to share a DriveItem via a sharing link.
The createLink action will create a new sharing link if the specified link type doesn't already exist for the calling application.\nIf a sharing link of the specified type already exists for the app, the existing sharing link will be returned.
DriveItem resources inherit sharing permissions from their ancestors.

### [New-MgGroupDriveRootUploadSession](New-MgGroupDriveRootUploadSession.md)
Invoke action createUploadSession

### [New-MgGroupExtension](New-MgGroupExtension.md)
Create new navigation property to extensions for groups

### [New-MgGroupLifecyclePolicy](New-MgGroupLifecyclePolicy.md)
Creates a new groupLifecyclePolicy.

### [New-MgGroupMember](New-MgGroupMember.md)
Add a member to an Office 365 group or security group through the members navigation property.

### [New-MgGroupMemberByRef](New-MgGroupMemberByRef.md)
Add a member to a security or Microsoft 365 group through the members navigation property.
The following table shows the types of members that can be added to either security groups or Microsoft 365 groups.

### [New-MgGroupOwner](New-MgGroupOwner.md)
Add an owner to an Office 365 group or security group through the owners navigation property.

### [New-MgGroupOwnerByRef](New-MgGroupOwnerByRef.md)
Add a user or service principal to a Microsoft 365 or security group's owners.
The owners are a set of users or service principals who are allowed to modify the group object.

### [New-MgGroupPermissionGrant](New-MgGroupPermissionGrant.md)
Create new navigation property to permissionGrants for groups

### [New-MgGroupRejectedSenderByRef](New-MgGroupRejectedSenderByRef.md)
Specify the user or group in @odata.id in the request body.
Users in the rejected senders list cannot post to conversations of the group (identified in the POST request URL).
Make sure you do not specify the same user or group in the rejected senders and accepted senders lists, otherwise you will get an error.

### [New-MgGroupSetting](New-MgGroupSetting.md)
Create a new setting based on the templates available in groupSettingTemplates.
These settings can be at the tenant-level or at the group level.
Group settings apply to only Microsoft 365 groups.
The template named Group.Unified can be used to configure tenant-wide Microsoft 365 group settings, while the template named Group.Unified.Guest can be used to configure group-specific settings.

### [New-MgGroupSettingTemplateGroupSettingTemplate](New-MgGroupSettingTemplateGroupSettingTemplate.md)
Add new entity to groupSettingTemplates

### [New-MgGroupThread](New-MgGroupThread.md)
Start a new group conversation by first creating a thread.
A new conversation, conversation thread, and post are created in the group.\nUse reply thread or reply post to further post to that thread.
Note: You can also start a new thread in an existing conversation.

### [New-MgGroupThreadPostAttachment](New-MgGroupThreadPostAttachment.md)
Create new navigation property to attachments for groups

### [New-MgGroupThreadPostAttachmentUploadSession](New-MgGroupThreadPostAttachmentUploadSession.md)
Create an upload session that allows an app to iteratively upload ranges of a file, so as to attach the file to the specified Outlook item.
The item can be a message or event.
Use this approach to attach a file if the file size is between 3 MB and 150 MB.
To attach a file that's smaller than 3 MB, do a POST operation on the attachments navigation property of the Outlook item; see how to do this for a message or for an event.
As part of the response, this action returns an upload URL that you can use in subsequent sequential PUT queries.
Request headers for each PUT operation let you specify the exact range of bytes to be uploaded.
This allows transfer to be resumed, in case the network connection is dropped during upload.
The following are the steps to attach a file to an Outlook item using an upload session: See attach large files to Outlook messages or events for an example.

### [New-MgGroupThreadPostExtension](New-MgGroupThreadPostExtension.md)
Create new navigation property to extensions for groups

### [New-MgGroupThreadPostInReplyToAttachment](New-MgGroupThreadPostInReplyToAttachment.md)
Create new navigation property to attachments for groups

### [New-MgGroupThreadPostInReplyToAttachmentUploadSession](New-MgGroupThreadPostInReplyToAttachmentUploadSession.md)
Create an upload session that allows an app to iteratively upload ranges of a file, so as to attach the file to the specified Outlook item.
The item can be a message or event.
Use this approach to attach a file if the file size is between 3 MB and 150 MB.
To attach a file that's smaller than 3 MB, do a POST operation on the attachments navigation property of the Outlook item; see how to do this for a message or for an event.
As part of the response, this action returns an upload URL that you can use in subsequent sequential PUT queries.
Request headers for each PUT operation let you specify the exact range of bytes to be uploaded.
This allows transfer to be resumed, in case the network connection is dropped during upload.
The following are the steps to attach a file to an Outlook item using an upload session: See attach large files to Outlook messages or events for an example.

### [New-MgGroupThreadPostInReplyToExtension](New-MgGroupThreadPostInReplyToExtension.md)
Create new navigation property to extensions for groups

### [Publish-MgGroupDriveListContentType](Publish-MgGroupDriveListContentType.md)
Publishes a [contentType][] present in the content type hub site.

### [Publish-MgGroupSiteContentType](Publish-MgGroupSiteContentType.md)
Publishes a [contentType][] present in the content type hub site.

### [Publish-MgGroupSiteListContentType](Publish-MgGroupSiteListContentType.md)
Publishes a [contentType][] present in the content type hub site.

### [Remove-MgGroup](Remove-MgGroup.md)
Delete group.
When deleted, Microsoft 365 groups are moved to a temporary container and can be restored within 30 days.
After that time, they're permanently deleted.
This isn't applicable to Security groups and Distribution groups which are permanently deleted immediately.
To learn more, see deletedItems.

### [Remove-MgGroupAcceptedSenderByRef](Remove-MgGroupAcceptedSenderByRef.md)
Remove acceptedSender

### [Remove-MgGroupConversation](Remove-MgGroupConversation.md)
Delete conversation.

### [Remove-MgGroupConversationThread](Remove-MgGroupConversationThread.md)
Delete navigation property threads for groups

### [Remove-MgGroupConversationThreadPostAttachment](Remove-MgGroupConversationThreadPostAttachment.md)
Delete navigation property attachments for groups

### [Remove-MgGroupConversationThreadPostExtension](Remove-MgGroupConversationThreadPostExtension.md)
Delete navigation property extensions for groups

### [Remove-MgGroupConversationThreadPostInReplyToAttachment](Remove-MgGroupConversationThreadPostInReplyToAttachment.md)
Delete navigation property attachments for groups

### [Remove-MgGroupConversationThreadPostInReplyToExtension](Remove-MgGroupConversationThreadPostInReplyToExtension.md)
Delete navigation property extensions for groups

### [Remove-MgGroupDriveItemPermanent](Remove-MgGroupDriveItemPermanent.md)
Invoke action permanentDelete

### [Remove-MgGroupDriveRootPermanent](Remove-MgGroupDriveRootPermanent.md)
Invoke action permanentDelete

### [Remove-MgGroupExtension](Remove-MgGroupExtension.md)
Delete navigation property extensions for groups

### [Remove-MgGroupFavorite](Remove-MgGroupFavorite.md)
Remove the group from the list of the current user's favorite groups.
Supported for Microsoft 365 groups only.

### [Remove-MgGroupFromLifecyclePolicy](Remove-MgGroupFromLifecyclePolicy.md)
Removes a group from a lifecycle policy.

### [Remove-MgGroupLifecyclePolicy](Remove-MgGroupLifecyclePolicy.md)
Delete a groupLifecyclePolicy.

### [Remove-MgGroupMemberByRef](Remove-MgGroupMemberByRef.md)
Remove a member from a group via the members navigation property.
You can't remove a member from groups with dynamic memberships.

### [Remove-MgGroupOwnerByRef](Remove-MgGroupOwnerByRef.md)
Remove an owner from a Microsoft 365 group or a security group through the owners navigation property.
Once owners are assigned to a group, the last owner (a user object) of the group cannot be removed.

### [Remove-MgGroupPermissionGrant](Remove-MgGroupPermissionGrant.md)
Delete navigation property permissionGrants for groups

### [Remove-MgGroupPhoto](Remove-MgGroupPhoto.md)
Delete navigation property photo for groups

### [Remove-MgGroupRejectedSenderByRef](Remove-MgGroupRejectedSenderByRef.md)
Remove rejectedSender

### [Remove-MgGroupSetting](Remove-MgGroupSetting.md)
Delete navigation property settings for groups

### [Remove-MgGroupSettingTemplateGroupSettingTemplate](Remove-MgGroupSettingTemplateGroupSettingTemplate.md)
Delete entity from groupSettingTemplates

### [Remove-MgGroupSite](Remove-MgGroupSite.md)
Unfollow a user's site or multiple sites.

### [Remove-MgGroupThread](Remove-MgGroupThread.md)
Delete conversationThread.

### [Remove-MgGroupThreadPostAttachment](Remove-MgGroupThreadPostAttachment.md)
Delete navigation property attachments for groups

### [Remove-MgGroupThreadPostExtension](Remove-MgGroupThreadPostExtension.md)
Delete navigation property extensions for groups

### [Remove-MgGroupThreadPostInReplyToAttachment](Remove-MgGroupThreadPostInReplyToAttachment.md)
Delete navigation property attachments for groups

### [Remove-MgGroupThreadPostInReplyToExtension](Remove-MgGroupThreadPostInReplyToExtension.md)
Delete navigation property extensions for groups

### [Reset-MgGroupUnseenCount](Reset-MgGroupUnseenCount.md)
Reset the unseenCount of all the posts that the current user has not seen since their last visit.
Supported for Microsoft 365 groups only.

### [Restore-MgGroupDriveItem](Restore-MgGroupDriveItem.md)
Restore a driveItem that has been deleted and is currently in the recycle bin.
NOTE: This functionality is currently only available for OneDrive Personal.

### [Restore-MgGroupDriveItemListItemDocumentSetVersion](Restore-MgGroupDriveItemListItemDocumentSetVersion.md)
Restore a document set version.

### [Restore-MgGroupDriveItemListItemVersion](Restore-MgGroupDriveItemListItemVersion.md)
Restore a previous version of a ListItem to be the current version.
This will create a new version with the contents of the previous version, but preserves all existing versions of the item.

### [Restore-MgGroupDriveItemVersion](Restore-MgGroupDriveItemVersion.md)
Restore a previous version of a DriveItem to be the current version.
This will create a new version with the contents of the previous version, but preserves all existing versions of the file.

### [Restore-MgGroupDriveListItemDocumentSetVersion](Restore-MgGroupDriveListItemDocumentSetVersion.md)
Restore a document set version.

### [Restore-MgGroupDriveListItemVersion](Restore-MgGroupDriveListItemVersion.md)
Restore a previous version of a ListItem to be the current version.
This will create a new version with the contents of the previous version, but preserves all existing versions of the item.

### [Restore-MgGroupDriveRoot](Restore-MgGroupDriveRoot.md)
Restore a driveItem that has been deleted and is currently in the recycle bin.
NOTE: This functionality is currently only available for OneDrive Personal.

### [Restore-MgGroupDriveRootListItemDocumentSetVersion](Restore-MgGroupDriveRootListItemDocumentSetVersion.md)
Restore a document set version.

### [Restore-MgGroupDriveRootListItemVersion](Restore-MgGroupDriveRootListItemVersion.md)
Restore a previous version of a ListItem to be the current version.
This will create a new version with the contents of the previous version, but preserves all existing versions of the item.

### [Restore-MgGroupDriveRootVersion](Restore-MgGroupDriveRootVersion.md)
Restore a previous version of a DriveItem to be the current version.
This will create a new version with the contents of the previous version, but preserves all existing versions of the file.

### [Restore-MgGroupSettingTemplate](Restore-MgGroupSettingTemplate.md)
Restore a recently deleted application, group, servicePrincipal, administrative unit, or user object from deleted items.
If an item was accidentally deleted, you can fully restore the item.
This is not applicable to security groups, which are deleted permanently.
A recently deleted item will remain available for up to 30 days.
After 30 days, the item is permanently deleted.

### [Restore-MgGroupSiteListItemDocumentSetVersion](Restore-MgGroupSiteListItemDocumentSetVersion.md)
Restore a document set version.

### [Restore-MgGroupSiteListItemVersion](Restore-MgGroupSiteListItemVersion.md)
Restore a previous version of a ListItem to be the current version.
This will create a new version with the contents of the previous version, but preserves all existing versions of the item.

### [Search-MgGroupDrive](Search-MgGroupDrive.md)
Invoke function search

### [Search-MgGroupDriveItem](Search-MgGroupDriveItem.md)
Invoke function search

### [Search-MgGroupDriveRoot](Search-MgGroupDriveRoot.md)
Invoke function search

### [Set-MgGroupDriveItemSensitivityLabel](Set-MgGroupDriveItemSensitivityLabel.md)
Invoke action assignSensitivityLabel

### [Set-MgGroupDriveRootSensitivityLabel](Set-MgGroupDriveRootSensitivityLabel.md)
Invoke action assignSensitivityLabel

### [Set-MgGroupLicense](Set-MgGroupLicense.md)
Add or remove licenses on the group.
Licenses assigned to the group will be assigned to all users in the group.
To learn more about group-based licensing, see What is group-based licensing in Azure Active Directory.
To get the subscriptions available in the directory, perform a GET subscribedSkus request.

### [Set-MgGroupPhotoContent](Set-MgGroupPhotoContent.md)
Update media content for the navigation property photo in groups

### [Stop-MgGroupCalendarEvent](Stop-MgGroupCalendarEvent.md)
This action allows the organizer of a meeting to send a cancellation message and cancel the event.
The action moves the event to the Deleted Items folder.
The organizer can also cancel an occurrence of a recurring meeting \nby providing the occurrence event ID.
An attendee calling this action gets an error (HTTP 400 Bad Request), with the following\nerror message: 'Your request can't be completed.
You need to be an organizer to cancel a meeting.' This action differs from Delete in that Cancel is available to only the organizer, and lets\nthe organizer send a custom message to the attendees about the cancellation.

### [Stop-MgGroupEvent](Stop-MgGroupEvent.md)
This action allows the organizer of a meeting to send a cancellation message and cancel the event.
The action moves the event to the Deleted Items folder.
The organizer can also cancel an occurrence of a recurring meeting \nby providing the occurrence event ID.
An attendee calling this action gets an error (HTTP 400 Bad Request), with the following\nerror message: 'Your request can't be completed.
You need to be an organizer to cancel a meeting.' This action differs from Delete in that Cancel is available to only the organizer, and lets\nthe organizer send a custom message to the attendees about the cancellation.

### [Test-MgGroupDriveItemPermission](Test-MgGroupDriveItemPermission.md)
Invoke action validatePermission

### [Test-MgGroupDriveListContentTypePublished](Test-MgGroupDriveListContentTypePublished.md)
Invoke function isPublished

### [Test-MgGroupDriveRootPermission](Test-MgGroupDriveRootPermission.md)
Invoke action validatePermission

### [Test-MgGroupPermissionGrantProperty](Test-MgGroupPermissionGrantProperty.md)
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

### [Test-MgGroupProperty](Test-MgGroupProperty.md)
Validate that a Microsoft 365 group's display name or mail nickname complies with naming policies.
Clients can use this API to determine whether a display name or mail nickname is valid before trying to update a Microsoft 365 group.
To validate the properties before creating a group, use the directoryobject:validateProperties function.
The following policy validations are performed for the display name and mail nickname properties: This API only returns the first validation failure that is encountered.
If the properties fail multiple validations, only the first validation failure is returned.
However, you can validate both the mail nickname and the display name and receive a collection of validation errors if you are only validating the prefix and suffix naming policy.
To learn more about configuring naming policies, see Configure naming policy.

### [Test-MgGroupSettingTemplateProperty](Test-MgGroupSettingTemplateProperty.md)
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

### [Test-MgGroupSiteContentTypePublished](Test-MgGroupSiteContentTypePublished.md)
Invoke function isPublished

### [Test-MgGroupSiteListContentTypePublished](Test-MgGroupSiteListContentTypePublished.md)
Invoke function isPublished

### [Unpublish-MgGroupDriveListContentType](Unpublish-MgGroupDriveListContentType.md)
Unpublish a [contentType][] from a content type hub site.

### [Unpublish-MgGroupSiteContentType](Unpublish-MgGroupSiteContentType.md)
Unpublish a [contentType][] from a content type hub site.

### [Unpublish-MgGroupSiteListContentType](Unpublish-MgGroupSiteListContentType.md)
Unpublish a [contentType][] from a content type hub site.

### [Update-MgGroup](Update-MgGroup.md)
Add a member to a security or Microsoft 365 group through the members navigation property.
The following table shows the types of members that can be added to either security groups or Microsoft 365 groups.

### [Update-MgGroupConversationThread](Update-MgGroupConversationThread.md)
Update the navigation property threads in groups

### [Update-MgGroupConversationThreadPostExtension](Update-MgGroupConversationThreadPostExtension.md)
Update an open extension (openTypeExtension object) with the properties in the request body: The data in an extension can be primitive types, or arrays of primitive types.
See the table in the Permissions section for the list of resources that support open extensions.

### [Update-MgGroupConversationThreadPostInReplyToExtension](Update-MgGroupConversationThreadPostInReplyToExtension.md)
Update an open extension (openTypeExtension object) with the properties in the request body: The data in an extension can be primitive types, or arrays of primitive types.
See the table in the Permissions section for the list of resources that support open extensions.

### [Update-MgGroupExtension](Update-MgGroupExtension.md)
Update the navigation property extensions in groups

### [Update-MgGroupLifecyclePolicy](Update-MgGroupLifecyclePolicy.md)
Update the properties of a groupLifecyclePolicygroupLifecyclePolicy resource type object.

### [Update-MgGroupOnenotePageContent](Update-MgGroupOnenotePageContent.md)
Invoke action onenotePatchContent

### [Update-MgGroupPermissionGrant](Update-MgGroupPermissionGrant.md)
Update the navigation property permissionGrants in groups

### [Update-MgGroupPhoto](Update-MgGroupPhoto.md)
Update the navigation property photo in groups

### [Update-MgGroupSetting](Update-MgGroupSetting.md)
Update the properties of a groupSetting object for tenant-wide group settings or a specific group setting.

### [Update-MgGroupSettingTemplateGroupSettingTemplate](Update-MgGroupSettingTemplateGroupSettingTemplate.md)
Update entity in groupSettingTemplates

### [Update-MgGroupThread](Update-MgGroupThread.md)
Update conversation thread

### [Update-MgGroupThreadPostExtension](Update-MgGroupThreadPostExtension.md)
Update an open extension (openTypeExtension object) with the properties in the request body: The data in an extension can be primitive types, or arrays of primitive types.
See the table in the Permissions section for the list of resources that support open extensions.

### [Update-MgGroupThreadPostInReplyToExtension](Update-MgGroupThreadPostInReplyToExtension.md)
Update an open extension (openTypeExtension object) with the properties in the request body: The data in an extension can be primitive types, or arrays of primitive types.
See the table in the Permissions section for the list of resources that support open extensions.

