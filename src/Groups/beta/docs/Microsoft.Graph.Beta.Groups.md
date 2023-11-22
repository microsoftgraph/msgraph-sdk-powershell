---
Module Name: Microsoft.Graph.Beta.Groups
Module Guid: dd951ff9-8251-41b5-b318-0fb931ab7f60
Download Help Link: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.groups
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Beta.Groups Module
## Description
Microsoft Graph PowerShell Cmdlets

## Microsoft.Graph.Beta.Groups Cmdlets
### [Add-MgBetaGroupDriveListContentTypeCopy](Add-MgBetaGroupDriveListContentTypeCopy.md)
Add a copy of a content type][contentType] from a [site][site] to a [list][list].
This API is available in the following [national cloud deployments.

### [Add-MgBetaGroupDriveListContentTypeCopyFromContentTypeHub](Add-MgBetaGroupDriveListContentTypeCopyFromContentTypeHub.md)
Add or sync a copy of a published content type from the content type hub to a target site or a list.
This method is part of the content type publishing changes to optimize the syncing of published content types to sites and lists, effectively switching from a 'push everywhere' to 'pull as needed' approach.
The method allows users to pull content types directly from the content type hub to a site or list.
For more information, see getCompatibleHubContentTypes and the blog post Syntex Product Updates – August 2021.
This API is available in the following national cloud deployments.

### [Add-MgBetaGroupFavorite](Add-MgBetaGroupFavorite.md)
Add the group to the list of the current user's favorite groups.
Supported for Microsoft 365 groups only.
This API is available in the following national cloud deployments.

### [Add-MgBetaGroupSite](Add-MgBetaGroupSite.md)
Follow a user's site or multiple sites.

### [Add-MgBetaGroupSiteContentTypeCopy](Add-MgBetaGroupSiteContentTypeCopy.md)
Add a copy of a content type][contentType] from a [site][site] to a [list][list].
This API is available in the following [national cloud deployments.

### [Add-MgBetaGroupSiteContentTypeCopyFromContentTypeHub](Add-MgBetaGroupSiteContentTypeCopyFromContentTypeHub.md)
Add or sync a copy of a published content type from the content type hub to a target site or a list.
This method is part of the content type publishing changes to optimize the syncing of published content types to sites and lists, effectively switching from a 'push everywhere' to 'pull as needed' approach.
The method allows users to pull content types directly from the content type hub to a site or list.
For more information, see getCompatibleHubContentTypes and the blog post Syntex Product Updates – August 2021.
This API is available in the following national cloud deployments.

### [Add-MgBetaGroupSiteListContentTypeCopy](Add-MgBetaGroupSiteListContentTypeCopy.md)
Add a copy of a content type][contentType] from a [site][site] to a [list][list].
This API is available in the following [national cloud deployments.

### [Add-MgBetaGroupSiteListContentTypeCopyFromContentTypeHub](Add-MgBetaGroupSiteListContentTypeCopyFromContentTypeHub.md)
Add or sync a copy of a published content type from the content type hub to a target site or a list.
This method is part of the content type publishing changes to optimize the syncing of published content types to sites and lists, effectively switching from a 'push everywhere' to 'pull as needed' approach.
The method allows users to pull content types directly from the content type hub to a site or list.
For more information, see getCompatibleHubContentTypes and the blog post Syntex Product Updates – August 2021.
This API is available in the following national cloud deployments.

### [Add-MgBetaGroupToLifecyclePolicy](Add-MgBetaGroupToLifecyclePolicy.md)
Invoke action addGroup

### [Confirm-MgBetaGroupGrantedPermissionForApp](Confirm-MgBetaGroupGrantedPermissionForApp.md)
Invoke action checkGrantedPermissionsForApp

### [Confirm-MgBetaGroupMemberGroup](Confirm-MgBetaGroupMemberGroup.md)
Check for membership in a specified list of group IDs, and return from that list those groups (identified by IDs) of which the specified user, group, service principal, organizational contact, device, or directory object is a member.
This function is transitive.
You can check up to a maximum of 20 groups per request.
This function supports all groups provisioned in Microsoft Entra ID.
Because Microsoft 365 groups cannot contain other groups, membership in a Microsoft 365 group is always direct.
This API is available in the following national cloud deployments.

### [Confirm-MgBetaGroupMemberObject](Confirm-MgBetaGroupMemberObject.md)
Invoke action checkMemberObjects

### [Confirm-MgBetaGroupSiteInformationProtectionSignature](Confirm-MgBetaGroupSiteInformationProtectionSignature.md)
Invoke action verifySignature

### [Copy-MgBetaGroupDriveItem](Copy-MgBetaGroupDriveItem.md)
Asynchronously creates a copy of an driveItem][item-resource] (including any children), under a new parent item or with a new name.
This API is available in the following [national cloud deployments.

### [Copy-MgBetaGroupDriveListContentTypeToDefaultContentLocation](Copy-MgBetaGroupDriveListContentTypeToDefaultContentLocation.md)
Copy a file to a default content location in a content type][contentType].
The file can then be added as a default file or template via a POST operation.
This API is available in the following [national cloud deployments.

### [Copy-MgBetaGroupDriveRoot](Copy-MgBetaGroupDriveRoot.md)
Asynchronously creates a copy of an driveItem][item-resource] (including any children), under a new parent item or with a new name.
This API is available in the following [national cloud deployments.

### [Copy-MgBetaGroupOnenoteNotebook](Copy-MgBetaGroupOnenoteNotebook.md)
Copies a notebook to the Notebooks folder in the destination Documents library.
The folder is created if it doesn't exist.
For Copy operations, you follow an asynchronous calling pattern:  First call the Copy action, and then poll the operation endpoint for the result.
This API is available in the following national cloud deployments.

### [Copy-MgBetaGroupOnenotePageToSection](Copy-MgBetaGroupOnenotePageToSection.md)
Copy a page to a specific section.
For copy operations, you follow an asynchronous calling pattern:  First call the Copy action, and then poll the operation endpoint for the result.
This API is available in the following national cloud deployments.

### [Copy-MgBetaGroupOnenoteSectionToNotebook](Copy-MgBetaGroupOnenoteSectionToNotebook.md)
Copies a section to a specific notebook.
For Copy operations, you follow an asynchronous calling pattern:  First call the Copy action, and then poll the operation endpoint for the result.
This API is available in the following national cloud deployments.

### [Copy-MgBetaGroupOnenoteSectionToSectionGroup](Copy-MgBetaGroupOnenoteSectionToSectionGroup.md)
Copies a section to a specific section group.
For Copy operations, you follow an asynchronous calling pattern:  First call the Copy action, and then poll the operation endpoint for the result.
This API is available in the following national cloud deployments.

### [Copy-MgBetaGroupSiteContentTypeToDefaultContentLocation](Copy-MgBetaGroupSiteContentTypeToDefaultContentLocation.md)
Copy a file to a default content location in a content type][contentType].
The file can then be added as a default file or template via a POST operation.
This API is available in the following [national cloud deployments.

### [Copy-MgBetaGroupSiteListContentTypeToDefaultContentLocation](Copy-MgBetaGroupSiteListContentTypeToDefaultContentLocation.md)
Copy a file to a default content location in a content type][contentType].
The file can then be added as a default file or template via a POST operation.
This API is available in the following [national cloud deployments.

### [Get-MgBetaAllGroupSite](Get-MgBetaAllGroupSite.md)
Invoke function getAllSites

### [Get-MgBetaGroup](Get-MgBetaGroup.md)
Get the properties and relationships of a group object.
This operation returns by default only a subset of all the available properties, as noted in the Properties section.
To get properties that aren't_ returned by default, specify them in a $select OData query option.
The hasMembersWithLicenseErrors and isArchived properties are an exception and aren't returned in the $select query.
Because the group resource supports extensions, you can also use the GET operation to get custom properties and extension data in a group instance.
This API is available in the following national cloud deployments.

### [Get-MgBetaGroupAcceptedSender](Get-MgBetaGroupAcceptedSender.md)
Get a list of users or groups that are in the accepted-senders list for this group.
Users in the accepted senders list can post to conversations of the group (identified in the GET request URL).
Make sure you do not specify the same user or group in the accepted senders and rejected senders lists, otherwise you will get an error.
This API is available in the following national cloud deployments.

### [Get-MgBetaGroupAcceptedSenderByRef](Get-MgBetaGroupAcceptedSenderByRef.md)
Get a list of users or groups that are in the accepted-senders list for this group.
Users in the accepted senders list can post to conversations of the group (identified in the GET request URL).
Make sure you do not specify the same user or group in the accepted senders and rejected senders lists, otherwise you will get an error.
This API is available in the following national cloud deployments.

### [Get-MgBetaGroupAcceptedSenderCount](Get-MgBetaGroupAcceptedSenderCount.md)
Get the number of the resource

### [Get-MgBetaGroupById](Get-MgBetaGroupById.md)
Return the directory objects specified in a list of IDs.
Some common uses for this function are to: This API is available in the following national cloud deployments.

### [Get-MgBetaGroupByUniqueName](Get-MgBetaGroupByUniqueName.md)
Get the properties and relationships of a group object.
This operation returns by default only a subset of all the available properties, as noted in the Properties section.
To get properties that aren't_ returned by default, specify them in a $select OData query option.
The hasMembersWithLicenseErrors and isArchived properties are an exception and aren't returned in the $select query.
Because the group resource supports extensions, you can also use the GET operation to get custom properties and extension data in a group instance.
This API is available in the following national cloud deployments.

### [Get-MgBetaGroupCalendarEventDelta](Get-MgBetaGroupCalendarEventDelta.md)
Get a set of event resources that have been added, deleted, or updated in one or more calendars.
You can get specific types of these incremental changes in the events in all the calendars of a mailbox or in a specific calendar, or in an event collection of a calendarView (range of events defined by start and end dates) of a calendar.
The calendar can be the default calendar or some other specified calendar of the user's.
In the case of getting incremental changes on calendarView, the calendar can be a group calendar as well.
Typically, synchronizing events in a calendar or calendarView in a local store entails a round of multiple delta function calls.
The initial call is a full synchronization, and every subsequent delta call in the same round gets the incremental changes (additions, deletions, or updates).
This allows you to maintain and synchronize a local store of events in the specified calendar, without having to fetch all the events of that calendar from the server every time.
The following table lists the differences between the delta function on events and the delta function on a calendarView in a calendar.
This API is available in the following national cloud deployments.

### [Get-MgBetaGroupCalendarSchedule](Get-MgBetaGroupCalendarSchedule.md)
Get the free/busy availability information for a collection of users, distributions lists, or resources (rooms or equipment) for a specified time period.
This API is available in the following national cloud deployments.

### [Get-MgBetaGroupConversation](Get-MgBetaGroupConversation.md)
Get a conversation object.
This API is available in the following national cloud deployments.

### [Get-MgBetaGroupConversationCount](Get-MgBetaGroupConversationCount.md)
Get the number of the resource

### [Get-MgBetaGroupConversationThread](Get-MgBetaGroupConversationThread.md)
A collection of all the conversation threads in the conversation.
A navigation property.
Read-only.
Nullable.

### [Get-MgBetaGroupConversationThreadCount](Get-MgBetaGroupConversationThreadCount.md)
Get the number of the resource

### [Get-MgBetaGroupConversationThreadPost](Get-MgBetaGroupConversationThreadPost.md)
Get the properties and relationships of a post in a specified thread.
You can specify both the parent \nconversation and the thread, or, you can specify the thread without referencing the parent conversation.
Since the post resource supports extensions, you can also use the GET operation to get custom properties and extension data in a post instance.
This API is available in the following national cloud deployments.

### [Get-MgBetaGroupConversationThreadPostAttachment](Get-MgBetaGroupConversationThreadPostAttachment.md)
The collection of fileAttachment, itemAttachment, and referenceAttachment attachments for the post.
Read-only.
Nullable.
Supports $expand.

### [Get-MgBetaGroupConversationThreadPostAttachmentCount](Get-MgBetaGroupConversationThreadPostAttachmentCount.md)
Get the number of the resource

### [Get-MgBetaGroupConversationThreadPostCount](Get-MgBetaGroupConversationThreadPostCount.md)
Get the number of the resource

### [Get-MgBetaGroupConversationThreadPostExtension](Get-MgBetaGroupConversationThreadPostExtension.md)
Get an open extension (openTypeExtension object) identified by name or fully qualified name.
The table in the Permissions section lists the resources that support open extensions.
The following table lists the three scenarios where you can get an open extension from a supported resource instance.
This API is available in the following national cloud deployments.

### [Get-MgBetaGroupConversationThreadPostExtensionCount](Get-MgBetaGroupConversationThreadPostExtensionCount.md)
Get the number of the resource

### [Get-MgBetaGroupConversationThreadPostInReplyToAttachment](Get-MgBetaGroupConversationThreadPostInReplyToAttachment.md)
The collection of fileAttachment, itemAttachment, and referenceAttachment attachments for the post.
Read-only.
Nullable.
Supports $expand.

### [Get-MgBetaGroupConversationThreadPostInReplyToAttachmentCount](Get-MgBetaGroupConversationThreadPostInReplyToAttachmentCount.md)
Get the number of the resource

### [Get-MgBetaGroupConversationThreadPostInReplyToExtension](Get-MgBetaGroupConversationThreadPostInReplyToExtension.md)
Get an open extension (openTypeExtension object) identified by name or fully qualified name.
The table in the Permissions section lists the resources that support open extensions.
The following table lists the three scenarios where you can get an open extension from a supported resource instance.
This API is available in the following national cloud deployments.

### [Get-MgBetaGroupConversationThreadPostInReplyToExtensionCount](Get-MgBetaGroupConversationThreadPostInReplyToExtensionCount.md)
Get the number of the resource

### [Get-MgBetaGroupConversationThreadPostInReplyToMention](Get-MgBetaGroupConversationThreadPostInReplyToMention.md)
Get mentions from groups

### [Get-MgBetaGroupConversationThreadPostInReplyToMentionCount](Get-MgBetaGroupConversationThreadPostInReplyToMentionCount.md)
Get the number of the resource

### [Get-MgBetaGroupConversationThreadPostMention](Get-MgBetaGroupConversationThreadPostMention.md)
Get mentions from groups

### [Get-MgBetaGroupConversationThreadPostMentionCount](Get-MgBetaGroupConversationThreadPostMentionCount.md)
Get the number of the resource

### [Get-MgBetaGroupCount](Get-MgBetaGroupCount.md)
Get the number of the resource

### [Get-MgBetaGroupCreatedOnBehalfOf](Get-MgBetaGroupCreatedOnBehalfOf.md)
The user (or application) that created the group.
Note: This is not set if the user is an administrator.
Read-only.

### [Get-MgBetaGroupDelta](Get-MgBetaGroupDelta.md)
Invoke function delta

### [Get-MgBetaGroupDriveItemActivityByInterval](Get-MgBetaGroupDriveItemActivityByInterval.md)
Invoke function getActivitiesByInterval

### [Get-MgBetaGroupDriveItemDelta](Get-MgBetaGroupDriveItemDelta.md)
Invoke function delta

### [Get-MgBetaGroupDriveItemListItemActivityByInterval](Get-MgBetaGroupDriveItemListItemActivityByInterval.md)
Invoke function getActivitiesByInterval

### [Get-MgBetaGroupDriveListContentTypeCompatibleHubContentType](Get-MgBetaGroupDriveListContentTypeCompatibleHubContentType.md)
Invoke function getCompatibleHubContentTypes

### [Get-MgBetaGroupDriveListItemActivityByInterval](Get-MgBetaGroupDriveListItemActivityByInterval.md)
Invoke function getActivitiesByInterval

### [Get-MgBetaGroupDriveListItemDelta](Get-MgBetaGroupDriveListItemDelta.md)
Invoke function delta

### [Get-MgBetaGroupDriveRootActivityByInterval](Get-MgBetaGroupDriveRootActivityByInterval.md)
Invoke function getActivitiesByInterval

### [Get-MgBetaGroupDriveRootDelta](Get-MgBetaGroupDriveRootDelta.md)
Invoke function delta

### [Get-MgBetaGroupDriveRootListItemActivityByInterval](Get-MgBetaGroupDriveRootListItemActivityByInterval.md)
Invoke function getActivitiesByInterval

### [Get-MgBetaGroupEndpoint](Get-MgBetaGroupEndpoint.md)
Retrieve the properties and relationships of a specific endpoint object.
This API is available in the following national cloud deployments.

### [Get-MgBetaGroupEndpointCount](Get-MgBetaGroupEndpointCount.md)
Get the number of the resource

### [Get-MgBetaGroupEventDelta](Get-MgBetaGroupEventDelta.md)
Get a set of event resources that have been added, deleted, or updated in one or more calendars.
You can get specific types of these incremental changes in the events in all the calendars of a mailbox or in a specific calendar, or in an event collection of a calendarView (range of events defined by start and end dates) of a calendar.
The calendar can be the default calendar or some other specified calendar of the user's.
In the case of getting incremental changes on calendarView, the calendar can be a group calendar as well.
Typically, synchronizing events in a calendar or calendarView in a local store entails a round of multiple delta function calls.
The initial call is a full synchronization, and every subsequent delta call in the same round gets the incremental changes (additions, deletions, or updates).
This allows you to maintain and synchronize a local store of events in the specified calendar, without having to fetch all the events of that calendar from the server every time.
The following table lists the differences between the delta function on events and the delta function on a calendarView in a calendar.
This API is available in the following national cloud deployments.

### [Get-MgBetaGroupExtension](Get-MgBetaGroupExtension.md)
The collection of open extensions defined for the group.
Read-only.
Nullable.

### [Get-MgBetaGroupExtensionCount](Get-MgBetaGroupExtensionCount.md)
Get the number of the resource

### [Get-MgBetaGroupLifecyclePolicy](Get-MgBetaGroupLifecyclePolicy.md)
Retrieve the properties and relationships of a groupLifecyclePolicies object.
This API is available in the following national cloud deployments.

### [Get-MgBetaGroupLifecyclePolicyByGroup](Get-MgBetaGroupLifecyclePolicyByGroup.md)
Retrieves a list of groupLifecyclePolicy objects to which a group belongs.
This API is available in the following national cloud deployments.

### [Get-MgBetaGroupLifecyclePolicyCount](Get-MgBetaGroupLifecyclePolicyCount.md)
Get the number of the resource

### [Get-MgBetaGroupMember](Get-MgBetaGroupMember.md)
Direct members of this group, who can be users, devices, other groups, or service principals.
Supports the List members, Add member, and Remove member operations.
Nullable.
Supports $expand including nested $select.
For example, /groups?$filter=startsWith(displayName,'Role')&$select=id,displayName&$expand=members($select=id,userPrincipalName,displayName).

### [Get-MgBetaGroupMemberAsApplication](Get-MgBetaGroupMemberAsApplication.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.application

### [Get-MgBetaGroupMemberAsDevice](Get-MgBetaGroupMemberAsDevice.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.device

### [Get-MgBetaGroupMemberAsGroup](Get-MgBetaGroupMemberAsGroup.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.group

### [Get-MgBetaGroupMemberAsOrgContact](Get-MgBetaGroupMemberAsOrgContact.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.orgContact

### [Get-MgBetaGroupMemberAsServicePrincipal](Get-MgBetaGroupMemberAsServicePrincipal.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.servicePrincipal

### [Get-MgBetaGroupMemberAsUser](Get-MgBetaGroupMemberAsUser.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.user

### [Get-MgBetaGroupMemberByRef](Get-MgBetaGroupMemberByRef.md)
Direct members of this group, who can be users, devices, other groups, or service principals.
Supports the List members, Add member, and Remove member operations.
Nullable.
Supports $expand including nested $select.
For example, /groups?$filter=startsWith(displayName,'Role')&$select=id,displayName&$expand=members($select=id,userPrincipalName,displayName).

### [Get-MgBetaGroupMemberCount](Get-MgBetaGroupMemberCount.md)
Get the number of the resource

### [Get-MgBetaGroupMemberCountAsApplication](Get-MgBetaGroupMemberCountAsApplication.md)
Get the number of the resource

### [Get-MgBetaGroupMemberCountAsDevice](Get-MgBetaGroupMemberCountAsDevice.md)
Get the number of the resource

### [Get-MgBetaGroupMemberCountAsGroup](Get-MgBetaGroupMemberCountAsGroup.md)
Get the number of the resource

### [Get-MgBetaGroupMemberCountAsOrgContact](Get-MgBetaGroupMemberCountAsOrgContact.md)
Get the number of the resource

### [Get-MgBetaGroupMemberCountAsServicePrincipal](Get-MgBetaGroupMemberCountAsServicePrincipal.md)
Get the number of the resource

### [Get-MgBetaGroupMemberCountAsUser](Get-MgBetaGroupMemberCountAsUser.md)
Get the number of the resource

### [Get-MgBetaGroupMemberGroup](Get-MgBetaGroupMemberGroup.md)
Return all the group IDs for the groups that the specified user, group, service principal, organizational contact, device, or directory object is a member of.
This function is transitive.
This API returns up to 11,000 group IDs.
If more than 11,000 results are available, it returns a 400 Bad Request error with the Directory_ResultSizeLimitExceeded error code.
As a workaround, use the List group transitive memberOf API.
This API is available in the following national cloud deployments.

### [Get-MgBetaGroupMemberObject](Get-MgBetaGroupMemberObject.md)
Invoke action getMemberObjects

### [Get-MgBetaGroupMemberOf](Get-MgBetaGroupMemberOf.md)
Groups and administrative units that this group is a member of.
HTTP Methods: GET (supported for all groups).
Read-only.
Nullable.
Supports $expand.

### [Get-MgBetaGroupMemberOfAsAdministrativeUnit](Get-MgBetaGroupMemberOfAsAdministrativeUnit.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.administrativeUnit

### [Get-MgBetaGroupMemberOfAsGroup](Get-MgBetaGroupMemberOfAsGroup.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.group

### [Get-MgBetaGroupMemberOfCount](Get-MgBetaGroupMemberOfCount.md)
Get the number of the resource

### [Get-MgBetaGroupMemberOfCountAsAdministrativeUnit](Get-MgBetaGroupMemberOfCountAsAdministrativeUnit.md)
Get the number of the resource

### [Get-MgBetaGroupMemberOfCountAsGroup](Get-MgBetaGroupMemberOfCountAsGroup.md)
Get the number of the resource

### [Get-MgBetaGroupMemberWithLicenseError](Get-MgBetaGroupMemberWithLicenseError.md)
A list of group members with license errors from this group-based license assignment.
Read-only.

### [Get-MgBetaGroupMemberWithLicenseErrorAsApplication](Get-MgBetaGroupMemberWithLicenseErrorAsApplication.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.application

### [Get-MgBetaGroupMemberWithLicenseErrorAsDevice](Get-MgBetaGroupMemberWithLicenseErrorAsDevice.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.device

### [Get-MgBetaGroupMemberWithLicenseErrorAsGroup](Get-MgBetaGroupMemberWithLicenseErrorAsGroup.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.group

### [Get-MgBetaGroupMemberWithLicenseErrorAsOrgContact](Get-MgBetaGroupMemberWithLicenseErrorAsOrgContact.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.orgContact

### [Get-MgBetaGroupMemberWithLicenseErrorAsServicePrincipal](Get-MgBetaGroupMemberWithLicenseErrorAsServicePrincipal.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.servicePrincipal

### [Get-MgBetaGroupMemberWithLicenseErrorAsUser](Get-MgBetaGroupMemberWithLicenseErrorAsUser.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.user

### [Get-MgBetaGroupMemberWithLicenseErrorCount](Get-MgBetaGroupMemberWithLicenseErrorCount.md)
Get the number of the resource

### [Get-MgBetaGroupMemberWithLicenseErrorCountAsApplication](Get-MgBetaGroupMemberWithLicenseErrorCountAsApplication.md)
Get the number of the resource

### [Get-MgBetaGroupMemberWithLicenseErrorCountAsDevice](Get-MgBetaGroupMemberWithLicenseErrorCountAsDevice.md)
Get the number of the resource

### [Get-MgBetaGroupMemberWithLicenseErrorCountAsGroup](Get-MgBetaGroupMemberWithLicenseErrorCountAsGroup.md)
Get the number of the resource

### [Get-MgBetaGroupMemberWithLicenseErrorCountAsOrgContact](Get-MgBetaGroupMemberWithLicenseErrorCountAsOrgContact.md)
Get the number of the resource

### [Get-MgBetaGroupMemberWithLicenseErrorCountAsServicePrincipal](Get-MgBetaGroupMemberWithLicenseErrorCountAsServicePrincipal.md)
Get the number of the resource

### [Get-MgBetaGroupMemberWithLicenseErrorCountAsUser](Get-MgBetaGroupMemberWithLicenseErrorCountAsUser.md)
Get the number of the resource

### [Get-MgBetaGroupOnenoteNotebookFromWebUrl](Get-MgBetaGroupOnenoteNotebookFromWebUrl.md)
Retrieve the properties and relationships of a notebook object by using its URL path.
The location can be user notebooks on Microsoft 365, group notebooks, or SharePoint site-hosted team notebooks on Microsoft 365.
This API is available in the following national cloud deployments.

### [Get-MgBetaGroupOnenoteRecentNotebook](Get-MgBetaGroupOnenoteRecentNotebook.md)
Invoke function getRecentNotebooks

### [Get-MgBetaGroupOwner](Get-MgBetaGroupOwner.md)
The owners of the group who can be users or service principals.
Nullable.
If this property is not specified when creating a Microsoft 365 group, the calling user is automatically assigned as the group owner.
Supports $filter (/$count eq 0, /$count ne 0, /$count eq 1, /$count ne 1); Supports $expand including nested $select.
For example, /groups?$filter=startsWith(displayName,'Role')&$select=id,displayName&$expand=owners($select=id,userPrincipalName,displayName).

### [Get-MgBetaGroupOwnerAsApplication](Get-MgBetaGroupOwnerAsApplication.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.application

### [Get-MgBetaGroupOwnerAsDevice](Get-MgBetaGroupOwnerAsDevice.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.device

### [Get-MgBetaGroupOwnerAsGroup](Get-MgBetaGroupOwnerAsGroup.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.group

### [Get-MgBetaGroupOwnerAsOrgContact](Get-MgBetaGroupOwnerAsOrgContact.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.orgContact

### [Get-MgBetaGroupOwnerAsServicePrincipal](Get-MgBetaGroupOwnerAsServicePrincipal.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.servicePrincipal

### [Get-MgBetaGroupOwnerAsUser](Get-MgBetaGroupOwnerAsUser.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.user

### [Get-MgBetaGroupOwnerByRef](Get-MgBetaGroupOwnerByRef.md)
The owners of the group who can be users or service principals.
Nullable.
If this property is not specified when creating a Microsoft 365 group, the calling user is automatically assigned as the group owner.
Supports $filter (/$count eq 0, /$count ne 0, /$count eq 1, /$count ne 1); Supports $expand including nested $select.
For example, /groups?$filter=startsWith(displayName,'Role')&$select=id,displayName&$expand=owners($select=id,userPrincipalName,displayName).

### [Get-MgBetaGroupOwnerCount](Get-MgBetaGroupOwnerCount.md)
Get the number of the resource

### [Get-MgBetaGroupOwnerCountAsApplication](Get-MgBetaGroupOwnerCountAsApplication.md)
Get the number of the resource

### [Get-MgBetaGroupOwnerCountAsDevice](Get-MgBetaGroupOwnerCountAsDevice.md)
Get the number of the resource

### [Get-MgBetaGroupOwnerCountAsGroup](Get-MgBetaGroupOwnerCountAsGroup.md)
Get the number of the resource

### [Get-MgBetaGroupOwnerCountAsOrgContact](Get-MgBetaGroupOwnerCountAsOrgContact.md)
Get the number of the resource

### [Get-MgBetaGroupOwnerCountAsServicePrincipal](Get-MgBetaGroupOwnerCountAsServicePrincipal.md)
Get the number of the resource

### [Get-MgBetaGroupOwnerCountAsUser](Get-MgBetaGroupOwnerCountAsUser.md)
Get the number of the resource

### [Get-MgBetaGroupPermissionGrant](Get-MgBetaGroupPermissionGrant.md)
The permissions that have been granted for a group to a specific application.
Supports $expand.

### [Get-MgBetaGroupPermissionGrantCount](Get-MgBetaGroupPermissionGrantCount.md)
Get the number of the resource

### [Get-MgBetaGroupPhoto](Get-MgBetaGroupPhoto.md)
The group's profile photo.

### [Get-MgBetaGroupPhotoContent](Get-MgBetaGroupPhotoContent.md)
Get media content for the navigation property photo from groups

### [Get-MgBetaGroupPlannerPlanBucketDelta](Get-MgBetaGroupPlannerPlanBucketDelta.md)
Invoke function delta

### [Get-MgBetaGroupPlannerPlanBucketTaskDelta](Get-MgBetaGroupPlannerPlanBucketTaskDelta.md)
Invoke function delta

### [Get-MgBetaGroupPlannerPlanDelta](Get-MgBetaGroupPlannerPlanDelta.md)
Invoke function delta

### [Get-MgBetaGroupPlannerPlanTaskDelta](Get-MgBetaGroupPlannerPlanTaskDelta.md)
Invoke function delta

### [Get-MgBetaGroupRejectedSender](Get-MgBetaGroupRejectedSender.md)
Get a list of users or groups that are in the rejected-senders list for this group.
Users in the rejected senders list can't post to conversations of the group (identified in the GET request URL).
Make sure you don't specify the same user or group in the rejected senders and accepted senders lists, otherwise you get an error.
This API is available in the following national cloud deployments.

### [Get-MgBetaGroupRejectedSenderByRef](Get-MgBetaGroupRejectedSenderByRef.md)
Get a list of users or groups that are in the rejected-senders list for this group.
Users in the rejected senders list can't post to conversations of the group (identified in the GET request URL).
Make sure you don't specify the same user or group in the rejected senders and accepted senders lists, otherwise you get an error.
This API is available in the following national cloud deployments.

### [Get-MgBetaGroupRejectedSenderCount](Get-MgBetaGroupRejectedSenderCount.md)
Get the number of the resource

### [Get-MgBetaGroupSetting](Get-MgBetaGroupSetting.md)
Settings that can govern this group's behavior, like whether members can invite guest users to the group.
Nullable.

### [Get-MgBetaGroupSettingCount](Get-MgBetaGroupSettingCount.md)
Get the number of the resource

### [Get-MgBetaGroupSiteActivityByInterval](Get-MgBetaGroupSiteActivityByInterval.md)
Invoke function getActivitiesByInterval

### [Get-MgBetaGroupSiteApplicableContentTypeForList](Get-MgBetaGroupSiteApplicableContentTypeForList.md)
Invoke function getApplicableContentTypesForList

### [Get-MgBetaGroupSiteByPath](Get-MgBetaGroupSiteByPath.md)
Invoke function getByPath

### [Get-MgBetaGroupSiteContentTypeCompatibleHubContentType](Get-MgBetaGroupSiteContentTypeCompatibleHubContentType.md)
Invoke function getCompatibleHubContentTypes

### [Get-MgBetaGroupSiteDelta](Get-MgBetaGroupSiteDelta.md)
Invoke function delta

### [Get-MgBetaGroupSiteListContentTypeCompatibleHubContentType](Get-MgBetaGroupSiteListContentTypeCompatibleHubContentType.md)
Invoke function getCompatibleHubContentTypes

### [Get-MgBetaGroupSiteListItemActivityByInterval](Get-MgBetaGroupSiteListItemActivityByInterval.md)
Invoke function getActivitiesByInterval

### [Get-MgBetaGroupSiteListItemDelta](Get-MgBetaGroupSiteListItemDelta.md)
Invoke function delta

### [Get-MgBetaGroupThread](Get-MgBetaGroupThread.md)
Get a thread object.
This API is available in the following national cloud deployments.

### [Get-MgBetaGroupThreadCount](Get-MgBetaGroupThreadCount.md)
Get the number of the resource

### [Get-MgBetaGroupThreadPost](Get-MgBetaGroupThreadPost.md)
Get the properties and relationships of a post in a specified thread.
You can specify both the parent \nconversation and the thread, or, you can specify the thread without referencing the parent conversation.
Since the post resource supports extensions, you can also use the GET operation to get custom properties and extension data in a post instance.
This API is available in the following national cloud deployments.

### [Get-MgBetaGroupThreadPostAttachment](Get-MgBetaGroupThreadPostAttachment.md)
The collection of fileAttachment, itemAttachment, and referenceAttachment attachments for the post.
Read-only.
Nullable.
Supports $expand.

### [Get-MgBetaGroupThreadPostAttachmentCount](Get-MgBetaGroupThreadPostAttachmentCount.md)
Get the number of the resource

### [Get-MgBetaGroupThreadPostCount](Get-MgBetaGroupThreadPostCount.md)
Get the number of the resource

### [Get-MgBetaGroupThreadPostExtension](Get-MgBetaGroupThreadPostExtension.md)
Get an open extension (openTypeExtension object) identified by name or fully qualified name.
The table in the Permissions section lists the resources that support open extensions.
The following table lists the three scenarios where you can get an open extension from a supported resource instance.
This API is available in the following national cloud deployments.

### [Get-MgBetaGroupThreadPostExtensionCount](Get-MgBetaGroupThreadPostExtensionCount.md)
Get the number of the resource

### [Get-MgBetaGroupThreadPostInReplyToAttachment](Get-MgBetaGroupThreadPostInReplyToAttachment.md)
The collection of fileAttachment, itemAttachment, and referenceAttachment attachments for the post.
Read-only.
Nullable.
Supports $expand.

### [Get-MgBetaGroupThreadPostInReplyToAttachmentCount](Get-MgBetaGroupThreadPostInReplyToAttachmentCount.md)
Get the number of the resource

### [Get-MgBetaGroupThreadPostInReplyToExtension](Get-MgBetaGroupThreadPostInReplyToExtension.md)
Get an open extension (openTypeExtension object) identified by name or fully qualified name.
The table in the Permissions section lists the resources that support open extensions.
The following table lists the three scenarios where you can get an open extension from a supported resource instance.
This API is available in the following national cloud deployments.

### [Get-MgBetaGroupThreadPostInReplyToExtensionCount](Get-MgBetaGroupThreadPostInReplyToExtensionCount.md)
Get the number of the resource

### [Get-MgBetaGroupThreadPostInReplyToMention](Get-MgBetaGroupThreadPostInReplyToMention.md)
Get mentions from groups

### [Get-MgBetaGroupThreadPostInReplyToMentionCount](Get-MgBetaGroupThreadPostInReplyToMentionCount.md)
Get the number of the resource

### [Get-MgBetaGroupThreadPostMention](Get-MgBetaGroupThreadPostMention.md)
Get mentions from groups

### [Get-MgBetaGroupThreadPostMentionCount](Get-MgBetaGroupThreadPostMentionCount.md)
Get the number of the resource

### [Get-MgBetaGroupTransitiveMember](Get-MgBetaGroupTransitiveMember.md)
The direct and transitive members of a group.
Nullable.

### [Get-MgBetaGroupTransitiveMemberAsApplication](Get-MgBetaGroupTransitiveMemberAsApplication.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.application

### [Get-MgBetaGroupTransitiveMemberAsDevice](Get-MgBetaGroupTransitiveMemberAsDevice.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.device

### [Get-MgBetaGroupTransitiveMemberAsGroup](Get-MgBetaGroupTransitiveMemberAsGroup.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.group

### [Get-MgBetaGroupTransitiveMemberAsOrgContact](Get-MgBetaGroupTransitiveMemberAsOrgContact.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.orgContact

### [Get-MgBetaGroupTransitiveMemberAsServicePrincipal](Get-MgBetaGroupTransitiveMemberAsServicePrincipal.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.servicePrincipal

### [Get-MgBetaGroupTransitiveMemberAsUser](Get-MgBetaGroupTransitiveMemberAsUser.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.user

### [Get-MgBetaGroupTransitiveMemberCount](Get-MgBetaGroupTransitiveMemberCount.md)
Get the number of the resource

### [Get-MgBetaGroupTransitiveMemberCountAsApplication](Get-MgBetaGroupTransitiveMemberCountAsApplication.md)
Get the number of the resource

### [Get-MgBetaGroupTransitiveMemberCountAsDevice](Get-MgBetaGroupTransitiveMemberCountAsDevice.md)
Get the number of the resource

### [Get-MgBetaGroupTransitiveMemberCountAsGroup](Get-MgBetaGroupTransitiveMemberCountAsGroup.md)
Get the number of the resource

### [Get-MgBetaGroupTransitiveMemberCountAsOrgContact](Get-MgBetaGroupTransitiveMemberCountAsOrgContact.md)
Get the number of the resource

### [Get-MgBetaGroupTransitiveMemberCountAsServicePrincipal](Get-MgBetaGroupTransitiveMemberCountAsServicePrincipal.md)
Get the number of the resource

### [Get-MgBetaGroupTransitiveMemberCountAsUser](Get-MgBetaGroupTransitiveMemberCountAsUser.md)
Get the number of the resource

### [Get-MgBetaGroupTransitiveMemberOf](Get-MgBetaGroupTransitiveMemberOf.md)
The groups that a group is a member of, either directly and through nested membership.
Nullable.

### [Get-MgBetaGroupTransitiveMemberOfAsAdministrativeUnit](Get-MgBetaGroupTransitiveMemberOfAsAdministrativeUnit.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.administrativeUnit

### [Get-MgBetaGroupTransitiveMemberOfAsGroup](Get-MgBetaGroupTransitiveMemberOfAsGroup.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.group

### [Get-MgBetaGroupTransitiveMemberOfCount](Get-MgBetaGroupTransitiveMemberOfCount.md)
Get the number of the resource

### [Get-MgBetaGroupTransitiveMemberOfCountAsAdministrativeUnit](Get-MgBetaGroupTransitiveMemberOfCountAsAdministrativeUnit.md)
Get the number of the resource

### [Get-MgBetaGroupTransitiveMemberOfCountAsGroup](Get-MgBetaGroupTransitiveMemberOfCountAsGroup.md)
Get the number of the resource

### [Get-MgBetaGroupUserOwnedObject](Get-MgBetaGroupUserOwnedObject.md)
Retrieve a list of recently deleted application and group objects owned by the specified user.
This API returns up to 1,000 deleted objects owned by the user, sorted by ID, and doesn't support pagination.
This API is available in the following national cloud deployments.

### [Get-MgBetaUserJoinedGroup](Get-MgBetaUserJoinedGroup.md)
Get joinedGroups from users

### [Grant-MgBetaGroupDriveItemPermission](Grant-MgBetaGroupDriveItemPermission.md)
Grant users access to a link represented by a permission][].
This API is available in the following [national cloud deployments.

### [Grant-MgBetaGroupDriveRootPermission](Grant-MgBetaGroupDriveRootPermission.md)
Grant users access to a link represented by a permission][].
This API is available in the following [national cloud deployments.

### [Grant-MgBetaGroupSitePermission](Grant-MgBetaGroupSitePermission.md)
Grant users access to a link represented by a permission][].
This API is available in the following [national cloud deployments.

### [Invoke-MgBetaAcceptGroupCalendarEvent](Invoke-MgBetaAcceptGroupCalendarEvent.md)
Accept the specified event in a user calendar.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaAcceptGroupCalendarEventTentatively](Invoke-MgBetaAcceptGroupCalendarEventTentatively.md)
Tentatively accept the specified event in a user calendar.
If the event allows proposals for new times, on responding tentative to the event, an invitee can choose to suggest an alternative time by including the proposedNewTime parameter.
For more information on how to propose a time, and how to receive and accept a new time proposal, see Propose new meeting times.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaAcceptGroupEvent](Invoke-MgBetaAcceptGroupEvent.md)
Accept the specified event in a user calendar.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaAcceptGroupEventTentatively](Invoke-MgBetaAcceptGroupEventTentatively.md)
Tentatively accept the specified event in a user calendar.
If the event allows proposals for new times, on responding tentative to the event, an invitee can choose to suggest an alternative time by including the proposedNewTime parameter.
For more information on how to propose a time, and how to receive and accept a new time proposal, see Propose new meeting times.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaBufferGroupSiteInformationProtectionDecrypt](Invoke-MgBetaBufferGroupSiteInformationProtectionDecrypt.md)
Invoke action decryptBuffer

### [Invoke-MgBetaBufferGroupSiteInformationProtectionEncrypt](Invoke-MgBetaBufferGroupSiteInformationProtectionEncrypt.md)
Invoke action encryptBuffer

### [Invoke-MgBetaCalendarGroupCalendar](Invoke-MgBetaCalendarGroupCalendar.md)
Invoke function allowedCalendarSharingRoles

### [Invoke-MgBetaCheckinGroupDriveItem](Invoke-MgBetaCheckinGroupDriveItem.md)
Check in a checked out driveItem resource, which makes the version of the document available to others.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaCheckinGroupDriveRoot](Invoke-MgBetaCheckinGroupDriveRoot.md)
Check in a checked out driveItem resource, which makes the version of the document available to others.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaCheckoutGroupDriveItem](Invoke-MgBetaCheckoutGroupDriveItem.md)
Check out a driveItem resource to prevent others from editing the document, and prevent your changes from being visible until the documented is checked in.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaCheckoutGroupDriveRoot](Invoke-MgBetaCheckoutGroupDriveRoot.md)
Check out a driveItem resource to prevent others from editing the document, and prevent your changes from being visible until the documented is checked in.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaDeclineGroupCalendarEvent](Invoke-MgBetaDeclineGroupCalendarEvent.md)
Decline invitation to the specified event in a user calendar.
If the event allows proposals for new times, on declining the event, an invitee can choose to suggest an alternative time by including the proposedNewTime parameter.
For more information on how to propose a time, and how to receive and accept a new time proposal, see Propose new meeting times.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaDeclineGroupEvent](Invoke-MgBetaDeclineGroupEvent.md)
Decline invitation to the specified event in a user calendar.
If the event allows proposals for new times, on declining the event, an invitee can choose to suggest an alternative time by including the proposedNewTime parameter.
For more information on how to propose a time, and how to receive and accept a new time proposal, see Propose new meeting times.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaDismissGroupCalendarEventReminder](Invoke-MgBetaDismissGroupCalendarEventReminder.md)
Dismiss a reminder that has been triggered for an event in a user calendar.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaDismissGroupEventReminder](Invoke-MgBetaDismissGroupEventReminder.md)
Dismiss a reminder that has been triggered for an event in a user calendar.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaExtractGroupDriveItemSensitivityLabel](Invoke-MgBetaExtractGroupDriveItemSensitivityLabel.md)
Invoke action extractSensitivityLabels

### [Invoke-MgBetaExtractGroupDriveRootSensitivityLabel](Invoke-MgBetaExtractGroupDriveRootSensitivityLabel.md)
Invoke action extractSensitivityLabels

### [Invoke-MgBetaExtractGroupSiteInformationProtectionPolicyLabel](Invoke-MgBetaExtractGroupSiteInformationProtectionPolicyLabel.md)
Using the metadata that exists on an already-labeled piece of information, resolve the metadata to a specific sensitivity label.
The contentInfo input is resolved to informationProtectionContentLabel.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaFollowGroupDriveItem](Invoke-MgBetaFollowGroupDriveItem.md)
Follow a driveItem.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaFollowGroupDriveRoot](Invoke-MgBetaFollowGroupDriveRoot.md)
Follow a driveItem.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaForwardGroupCalendarEvent](Invoke-MgBetaForwardGroupCalendarEvent.md)
This action allows the organizer or attendee of a meeting event to forward the \nmeeting request to a new recipient.
If the meeting event is forwarded from an attendee's Microsoft 365 mailbox to another recipient, this action \nalso sends a message to notify the organizer of the forwarding, and adds the recipient to the organizer's \ncopy of the meeting event.
This convenience is not available when forwarding from an Outlook.com account.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaForwardGroupConversationThreadPost](Invoke-MgBetaForwardGroupConversationThreadPost.md)
Forward a post to a recipient.
You can specify both the parent conversation and thread in the request, \nor, you can specify just the parent thread without the parent conversation.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaForwardGroupConversationThreadPostInReplyTo](Invoke-MgBetaForwardGroupConversationThreadPostInReplyTo.md)
Forward a post to a recipient.
You can specify both the parent conversation and thread in the request, \nor, you can specify just the parent thread without the parent conversation.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaForwardGroupEvent](Invoke-MgBetaForwardGroupEvent.md)
This action allows the organizer or attendee of a meeting event to forward the \nmeeting request to a new recipient.
If the meeting event is forwarded from an attendee's Microsoft 365 mailbox to another recipient, this action \nalso sends a message to notify the organizer of the forwarding, and adds the recipient to the organizer's \ncopy of the meeting event.
This convenience is not available when forwarding from an Outlook.com account.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaForwardGroupThreadPost](Invoke-MgBetaForwardGroupThreadPost.md)
Forward a post to a recipient.
You can specify both the parent conversation and thread in the request, \nor, you can specify just the parent thread without the parent conversation.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaForwardGroupThreadPostInReplyTo](Invoke-MgBetaForwardGroupThreadPostInReplyTo.md)
Forward a post to a recipient.
You can specify both the parent conversation and thread in the request, \nor, you can specify just the parent thread without the parent conversation.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaGraphGroup](Invoke-MgBetaGraphGroup.md)
Calling this method disables the current user to receive email notifications for this group about new posts, events, and files in that group.
Supported for Microsoft 365 groups only.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaGraphGroupDrive](Invoke-MgBetaGraphGroupDrive.md)
Invoke function sharedWithMe

### [Invoke-MgBetaInviteGroupDriveItem](Invoke-MgBetaInviteGroupDriveItem.md)
Sends a sharing invitation for a DriveItem.\nA sharing invitation provides permissions to the recipients and optionally sends an email to the recipients to notify them the item was shared.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaInviteGroupDriveRoot](Invoke-MgBetaInviteGroupDriveRoot.md)
Sends a sharing invitation for a DriveItem.\nA sharing invitation provides permissions to the recipients and optionally sends an email to the recipients to notify them the item was shared.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaPreviewGroupDriveItem](Invoke-MgBetaPreviewGroupDriveItem.md)
Invoke action preview

### [Invoke-MgBetaPreviewGroupDriveRoot](Invoke-MgBetaPreviewGroupDriveRoot.md)
Invoke action preview

### [Invoke-MgBetaPreviewGroupOnenotePage](Invoke-MgBetaPreviewGroupOnenotePage.md)
Invoke function preview

### [Invoke-MgBetaReauthorizeGroupDriveItemSubscription](Invoke-MgBetaReauthorizeGroupDriveItemSubscription.md)
Reauthorize a subscription when you receive a reauthorizationRequired challenge.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaReauthorizeGroupDriveListSubscription](Invoke-MgBetaReauthorizeGroupDriveListSubscription.md)
Reauthorize a subscription when you receive a reauthorizationRequired challenge.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaReauthorizeGroupDriveRootSubscription](Invoke-MgBetaReauthorizeGroupDriveRootSubscription.md)
Reauthorize a subscription when you receive a reauthorizationRequired challenge.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaReauthorizeGroupSiteListSubscription](Invoke-MgBetaReauthorizeGroupSiteListSubscription.md)
Reauthorize a subscription when you receive a reauthorizationRequired challenge.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaRecentGroupDrive](Invoke-MgBetaRecentGroupDrive.md)
Invoke function recent

### [Invoke-MgBetaRenewGroup](Invoke-MgBetaRenewGroup.md)
Renews a group's expiration.
When a group is renewed, the group expiration is extended by the number of days defined in the policy.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaRenewGroupLifecyclePolicy](Invoke-MgBetaRenewGroupLifecyclePolicy.md)
Renew a group's expiration.
When a group is renewed, the group expiration is extended by the number of days defined in the policy.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaReplyGroupConversationThread](Invoke-MgBetaReplyGroupConversationThread.md)
Reply to a thread in a group conversation and add a new post to it.
You can specify the parent conversation \nin the request, or, you can specify just the thread without the parent conversation.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaReplyGroupConversationThreadPost](Invoke-MgBetaReplyGroupConversationThreadPost.md)
Reply to a post and add a new post to the specified thread in a group conversation.
You can specify both the parent conversation and thread in the request, or, you can specify just the parent thread without the parent conversation.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaReplyGroupConversationThreadPostInReplyTo](Invoke-MgBetaReplyGroupConversationThreadPostInReplyTo.md)
Reply to a post and add a new post to the specified thread in a group conversation.
You can specify both the parent conversation and thread in the request, or, you can specify just the parent thread without the parent conversation.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaReplyGroupThread](Invoke-MgBetaReplyGroupThread.md)
Reply to a thread in a group conversation and add a new post to it.
You can specify the parent conversation \nin the request, or, you can specify just the thread without the parent conversation.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaReplyGroupThreadPost](Invoke-MgBetaReplyGroupThreadPost.md)
Reply to a post and add a new post to the specified thread in a group conversation.
You can specify both the parent conversation and thread in the request, or, you can specify just the parent thread without the parent conversation.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaReplyGroupThreadPostInReplyTo](Invoke-MgBetaReplyGroupThreadPostInReplyTo.md)
Reply to a post and add a new post to the specified thread in a group conversation.
You can specify both the parent conversation and thread in the request, or, you can specify just the parent thread without the parent conversation.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaRetryGroupServiceProvisioning](Invoke-MgBetaRetryGroupServiceProvisioning.md)
Retry the group service provisioning.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaSignGroupSiteInformationProtectionDigest](Invoke-MgBetaSignGroupSiteInformationProtectionDigest.md)
Invoke action signDigest

### [Invoke-MgBetaSnoozeGroupCalendarEventReminder](Invoke-MgBetaSnoozeGroupCalendarEventReminder.md)
Postpone a reminder for an event in a user calendar until a new time.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaSnoozeGroupEventReminder](Invoke-MgBetaSnoozeGroupEventReminder.md)
Postpone a reminder for an event in a user calendar until a new time.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaSubscribeGroupByMail](Invoke-MgBetaSubscribeGroupByMail.md)
Calling this method will enable the current user to receive email notifications for this group, about new posts, events, and files in that group.
Supported for Microsoft 365 groups only.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaUnfollowGroupDriveItem](Invoke-MgBetaUnfollowGroupDriveItem.md)
Unfollow a driveItem.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaUnfollowGroupDriveRoot](Invoke-MgBetaUnfollowGroupDriveRoot.md)
Unfollow a driveItem.
This API is available in the following national cloud deployments.

### [Join-MgBetaGroupDriveListContentTypeWithHubSite](Join-MgBetaGroupDriveListContentTypeWithHubSite.md)
Associate a content type][contentType] with a list of hub sites.
This API is available in the following [national cloud deployments.

### [Join-MgBetaGroupSiteContentTypeWithHubSite](Join-MgBetaGroupSiteContentTypeWithHubSite.md)
Associate a content type][contentType] with a list of hub sites.
This API is available in the following [national cloud deployments.

### [Join-MgBetaGroupSiteListContentTypeWithHubSite](Join-MgBetaGroupSiteListContentTypeWithHubSite.md)
Associate a content type][contentType] with a list of hub sites.
This API is available in the following [national cloud deployments.

### [Move-MgBetaGroupPlannerPlanToContainer](Move-MgBetaGroupPlannerPlanToContainer.md)
Invoke action moveToContainer

### [New-MgBetaGroup](New-MgBetaGroup.md)
Create a new group as specified in the request body.
You can create one of the following groups: This operation returns by default only a subset of the properties for each group.
These default properties are noted in the Properties section.
To get properties that are not returned by default, do a GET operation and specify the properties in a $select OData query option.
Note: To create a team, first create a group then add a team to it, see create team.
This API is available in the following national cloud deployments.

### [New-MgBetaGroupAcceptedSenderByRef](New-MgBetaGroupAcceptedSenderByRef.md)
Add a new user or group to the acceptedSender list.
Specify the user or group in @odata.id in the request body.
Users in the accepted senders list can post to conversations of the group.
Make sure you don't specify the same user or group in the accepted senders and rejected senders lists, otherwise you'll get an error.
This API is available in the following national cloud deployments.

### [New-MgBetaGroupConversation](New-MgBetaGroupConversation.md)
Create a new conversation by including a thread and a post.
Use reply thread or reply post to further post to that conversation.
This API is available in the following national cloud deployments.

### [New-MgBetaGroupConversationThread](New-MgBetaGroupConversationThread.md)
Create a new thread in the specified conversation.
A thread and post are created as specified.
Use reply thread to further post\nto that thread.
Or, if you get the post ID, you can also reply to that post in that thread.
Note: You can also start a new conversation by first creating a thread.
This API is available in the following national cloud deployments.

### [New-MgBetaGroupConversationThreadPostAttachment](New-MgBetaGroupConversationThreadPostAttachment.md)
Create new navigation property to attachments for groups

### [New-MgBetaGroupConversationThreadPostAttachmentUploadSession](New-MgBetaGroupConversationThreadPostAttachmentUploadSession.md)
Create an upload session that allows an app to iteratively upload ranges of a file, so as to attach the file to an Outlook item.
The item can be a message or event.
Use this approach to attach a file if the file size is between 3 MB and 150 MB.
To attach a file that's smaller than 3 MB, do a POST operation on the attachments navigation property of the Outlook item; see how to do this for a message or for an event.
As part of the response, this action returns an upload URL that you can use in subsequent sequential PUT queries.
Request headers for each PUT operation let you specify the exact range of bytes to be uploaded.
This allows transfer to be resumed, in case the network connection is dropped during upload.
The following are the steps to attach a file to an Outlook item using an upload session: See attach large files to Outlook messages or events for an example.
This API is available in the following national cloud deployments.

### [New-MgBetaGroupConversationThreadPostExtension](New-MgBetaGroupConversationThreadPostExtension.md)
Create new navigation property to extensions for groups

### [New-MgBetaGroupConversationThreadPostInReplyToAttachment](New-MgBetaGroupConversationThreadPostInReplyToAttachment.md)
Create new navigation property to attachments for groups

### [New-MgBetaGroupConversationThreadPostInReplyToAttachmentUploadSession](New-MgBetaGroupConversationThreadPostInReplyToAttachmentUploadSession.md)
Create an upload session that allows an app to iteratively upload ranges of a file, so as to attach the file to an Outlook item.
The item can be a message or event.
Use this approach to attach a file if the file size is between 3 MB and 150 MB.
To attach a file that's smaller than 3 MB, do a POST operation on the attachments navigation property of the Outlook item; see how to do this for a message or for an event.
As part of the response, this action returns an upload URL that you can use in subsequent sequential PUT queries.
Request headers for each PUT operation let you specify the exact range of bytes to be uploaded.
This allows transfer to be resumed, in case the network connection is dropped during upload.
The following are the steps to attach a file to an Outlook item using an upload session: See attach large files to Outlook messages or events for an example.
This API is available in the following national cloud deployments.

### [New-MgBetaGroupConversationThreadPostInReplyToExtension](New-MgBetaGroupConversationThreadPostInReplyToExtension.md)
Create new navigation property to extensions for groups

### [New-MgBetaGroupConversationThreadPostInReplyToMention](New-MgBetaGroupConversationThreadPostInReplyToMention.md)
Create new navigation property to mentions for groups

### [New-MgBetaGroupConversationThreadPostMention](New-MgBetaGroupConversationThreadPostMention.md)
Create new navigation property to mentions for groups

### [New-MgBetaGroupDriveItemLink](New-MgBetaGroupDriveItemLink.md)
You can use createLink action to share a driveItem via a sharing link.
The createLink action will create a new sharing link if the specified link type doesn't already exist for the calling application.\nIf a sharing link of the specified type already exists for the app, the existing sharing link will be returned.
DriveItem resources inherit sharing permissions from their ancestors.
This API is available in the following national cloud deployments.

### [New-MgBetaGroupDriveItemListItemLink](New-MgBetaGroupDriveItemListItemLink.md)
Create a sharing link for a listItem.
The createLink action creates a new sharing link if the specified link type doesn't already exist for the calling application.\nIf a sharing link of the specified type already exists for the app, this action will return the existing sharing link.
listItem resources inherit sharing permissions from the list the item resides in.
This API is available in the following national cloud deployments.

### [New-MgBetaGroupDriveItemUploadSession](New-MgBetaGroupDriveItemUploadSession.md)
Invoke action createUploadSession

### [New-MgBetaGroupDriveListItemLink](New-MgBetaGroupDriveListItemLink.md)
Create a sharing link for a listItem.
The createLink action creates a new sharing link if the specified link type doesn't already exist for the calling application.\nIf a sharing link of the specified type already exists for the app, this action will return the existing sharing link.
listItem resources inherit sharing permissions from the list the item resides in.
This API is available in the following national cloud deployments.

### [New-MgBetaGroupDriveRootLink](New-MgBetaGroupDriveRootLink.md)
You can use createLink action to share a driveItem via a sharing link.
The createLink action will create a new sharing link if the specified link type doesn't already exist for the calling application.\nIf a sharing link of the specified type already exists for the app, the existing sharing link will be returned.
DriveItem resources inherit sharing permissions from their ancestors.
This API is available in the following national cloud deployments.

### [New-MgBetaGroupDriveRootListItemLink](New-MgBetaGroupDriveRootListItemLink.md)
Create a sharing link for a listItem.
The createLink action creates a new sharing link if the specified link type doesn't already exist for the calling application.\nIf a sharing link of the specified type already exists for the app, this action will return the existing sharing link.
listItem resources inherit sharing permissions from the list the item resides in.
This API is available in the following national cloud deployments.

### [New-MgBetaGroupDriveRootUploadSession](New-MgBetaGroupDriveRootUploadSession.md)
Invoke action createUploadSession

### [New-MgBetaGroupEndpoint](New-MgBetaGroupEndpoint.md)
Create new navigation property to endpoints for groups

### [New-MgBetaGroupExtension](New-MgBetaGroupExtension.md)
Create new navigation property to extensions for groups

### [New-MgBetaGroupLifecyclePolicy](New-MgBetaGroupLifecyclePolicy.md)
Creates a new groupLifecyclePolicy.
This API is available in the following national cloud deployments.

### [New-MgBetaGroupMember](New-MgBetaGroupMember.md)
Add a member to an Office 365 group or security group through the members navigation property.

### [New-MgBetaGroupMemberByRef](New-MgBetaGroupMemberByRef.md)
Add a member to a security or Microsoft 365 group through the members navigation property.
The following table shows the types of members that can be added to either security groups or Microsoft 365 groups.
This API is available in the following national cloud deployments.

### [New-MgBetaGroupOwner](New-MgBetaGroupOwner.md)
Add an owner to an Office 365 group or security group through the owners navigation property.

### [New-MgBetaGroupOwnerByRef](New-MgBetaGroupOwnerByRef.md)
Add a user or service principal to a Microsoft 365 or security group's owners.
The owners are a set of users or service principals who are allowed to modify the group object.
This API is available in the following national cloud deployments.

### [New-MgBetaGroupPermissionGrant](New-MgBetaGroupPermissionGrant.md)
Create new navigation property to permissionGrants for groups

### [New-MgBetaGroupRejectedSenderByRef](New-MgBetaGroupRejectedSenderByRef.md)
Add a new user or group to the rejectedSender list.
Specify the user or group in @odata.id in the request body.
Users in the rejected senders list can't post to conversations of the group (identified in the POST request URL).
Make sure you don't specify the same user or group in the rejected senders and accepted senders lists, otherwise you'll get an error.
This API is available in the following national cloud deployments.

### [New-MgBetaGroupSetting](New-MgBetaGroupSetting.md)
Create a new setting based on the templates available in directorySettingTemplates.
These settings can be at the tenant-level or at the group level.
Group settings apply to only Microsoft 365 groups.
The template named Group.Unified can be used to configure tenant-wide Microsoft 365 group settings, while the template named Group.Unified.Guest can be used to configure group-specific settings.
This API is available in the following national cloud deployments.

### [New-MgBetaGroupSiteListItemLink](New-MgBetaGroupSiteListItemLink.md)
Create a sharing link for a listItem.
The createLink action creates a new sharing link if the specified link type doesn't already exist for the calling application.\nIf a sharing link of the specified type already exists for the app, this action will return the existing sharing link.
listItem resources inherit sharing permissions from the list the item resides in.
This API is available in the following national cloud deployments.

### [New-MgBetaGroupThread](New-MgBetaGroupThread.md)
Start a new group conversation by first creating a thread.
A new conversation, conversation thread, and post are created in the group.
Use reply thread or reply post to further post to that thread.
Note: You can also start a new thread in an existing conversation.
This API is available in the following national cloud deployments.

### [New-MgBetaGroupThreadPostAttachment](New-MgBetaGroupThreadPostAttachment.md)
Create new navigation property to attachments for groups

### [New-MgBetaGroupThreadPostAttachmentUploadSession](New-MgBetaGroupThreadPostAttachmentUploadSession.md)
Create an upload session that allows an app to iteratively upload ranges of a file, so as to attach the file to an Outlook item.
The item can be a message or event.
Use this approach to attach a file if the file size is between 3 MB and 150 MB.
To attach a file that's smaller than 3 MB, do a POST operation on the attachments navigation property of the Outlook item; see how to do this for a message or for an event.
As part of the response, this action returns an upload URL that you can use in subsequent sequential PUT queries.
Request headers for each PUT operation let you specify the exact range of bytes to be uploaded.
This allows transfer to be resumed, in case the network connection is dropped during upload.
The following are the steps to attach a file to an Outlook item using an upload session: See attach large files to Outlook messages or events for an example.
This API is available in the following national cloud deployments.

### [New-MgBetaGroupThreadPostExtension](New-MgBetaGroupThreadPostExtension.md)
Create new navigation property to extensions for groups

### [New-MgBetaGroupThreadPostInReplyToAttachment](New-MgBetaGroupThreadPostInReplyToAttachment.md)
Create new navigation property to attachments for groups

### [New-MgBetaGroupThreadPostInReplyToAttachmentUploadSession](New-MgBetaGroupThreadPostInReplyToAttachmentUploadSession.md)
Create an upload session that allows an app to iteratively upload ranges of a file, so as to attach the file to an Outlook item.
The item can be a message or event.
Use this approach to attach a file if the file size is between 3 MB and 150 MB.
To attach a file that's smaller than 3 MB, do a POST operation on the attachments navigation property of the Outlook item; see how to do this for a message or for an event.
As part of the response, this action returns an upload URL that you can use in subsequent sequential PUT queries.
Request headers for each PUT operation let you specify the exact range of bytes to be uploaded.
This allows transfer to be resumed, in case the network connection is dropped during upload.
The following are the steps to attach a file to an Outlook item using an upload session: See attach large files to Outlook messages or events for an example.
This API is available in the following national cloud deployments.

### [New-MgBetaGroupThreadPostInReplyToExtension](New-MgBetaGroupThreadPostInReplyToExtension.md)
Create new navigation property to extensions for groups

### [New-MgBetaGroupThreadPostInReplyToMention](New-MgBetaGroupThreadPostInReplyToMention.md)
Create new navigation property to mentions for groups

### [New-MgBetaGroupThreadPostMention](New-MgBetaGroupThreadPostMention.md)
Create new navigation property to mentions for groups

### [Publish-MgBetaGroupDriveListContentType](Publish-MgBetaGroupDriveListContentType.md)
Publishes a contentType][] present in a content type hub site.
This API is available in the following [national cloud deployments.

### [Publish-MgBetaGroupSiteContentType](Publish-MgBetaGroupSiteContentType.md)
Publishes a contentType][] present in a content type hub site.
This API is available in the following [national cloud deployments.

### [Publish-MgBetaGroupSiteListContentType](Publish-MgBetaGroupSiteListContentType.md)
Publishes a contentType][] present in a content type hub site.
This API is available in the following [national cloud deployments.

### [Remove-MgBetaGroup](Remove-MgBetaGroup.md)
Deletes a group.
When deleted, Microsoft 365 groups are moved to a temporary container and can be restored within 30 days.
After that time, they are permanently deleted.
This isn't applicable to Security groups and Distribution groups that are permanently deleted immediately.
To learn more, see deletedItems.
This API is available in the following national cloud deployments.

### [Remove-MgBetaGroupAcceptedSenderByRef](Remove-MgBetaGroupAcceptedSenderByRef.md)
Remove a user or group from the accepted-senders list of the specified group.

### [Remove-MgBetaGroupByUniqueName](Remove-MgBetaGroupByUniqueName.md)
Deletes a group.
When deleted, Microsoft 365 groups are moved to a temporary container and can be restored within 30 days.
After that time, they are permanently deleted.
This isn't applicable to Security groups and Distribution groups that are permanently deleted immediately.
To learn more, see deletedItems.
This API is available in the following national cloud deployments.

### [Remove-MgBetaGroupConversation](Remove-MgBetaGroupConversation.md)
Delete conversation.
This API is available in the following national cloud deployments.

### [Remove-MgBetaGroupConversationThread](Remove-MgBetaGroupConversationThread.md)
Delete navigation property threads for groups

### [Remove-MgBetaGroupConversationThreadPostAttachment](Remove-MgBetaGroupConversationThreadPostAttachment.md)
Delete navigation property attachments for groups

### [Remove-MgBetaGroupConversationThreadPostExtension](Remove-MgBetaGroupConversationThreadPostExtension.md)
Delete navigation property extensions for groups

### [Remove-MgBetaGroupConversationThreadPostInReplyToAttachment](Remove-MgBetaGroupConversationThreadPostInReplyToAttachment.md)
Delete navigation property attachments for groups

### [Remove-MgBetaGroupConversationThreadPostInReplyToExtension](Remove-MgBetaGroupConversationThreadPostInReplyToExtension.md)
Delete navigation property extensions for groups

### [Remove-MgBetaGroupConversationThreadPostInReplyToMention](Remove-MgBetaGroupConversationThreadPostInReplyToMention.md)
Delete navigation property mentions for groups

### [Remove-MgBetaGroupConversationThreadPostMention](Remove-MgBetaGroupConversationThreadPostMention.md)
Delete navigation property mentions for groups

### [Remove-MgBetaGroupDriveItemPermanent](Remove-MgBetaGroupDriveItemPermanent.md)
Invoke action permanentDelete

### [Remove-MgBetaGroupDriveRootPermanent](Remove-MgBetaGroupDriveRootPermanent.md)
Invoke action permanentDelete

### [Remove-MgBetaGroupEndpoint](Remove-MgBetaGroupEndpoint.md)
Delete navigation property endpoints for groups

### [Remove-MgBetaGroupExtension](Remove-MgBetaGroupExtension.md)
Delete navigation property extensions for groups

### [Remove-MgBetaGroupFavorite](Remove-MgBetaGroupFavorite.md)
Remove the group from the list of the current user's favorite groups.
Supported for Microsoft 365 groups only.
This API is available in the following national cloud deployments.

### [Remove-MgBetaGroupFromLifecyclePolicy](Remove-MgBetaGroupFromLifecyclePolicy.md)
Invoke action removeGroup

### [Remove-MgBetaGroupLifecyclePolicy](Remove-MgBetaGroupLifecyclePolicy.md)
Delete a groupLifecyclePolicy.
This API is available in the following national cloud deployments.

### [Remove-MgBetaGroupMemberByRef](Remove-MgBetaGroupMemberByRef.md)
Remove a member from a group via the members navigation property.
You can't remove a member from groups with dynamic memberships.
This API is available in the following national cloud deployments.

### [Remove-MgBetaGroupOwnerByRef](Remove-MgBetaGroupOwnerByRef.md)
Use this API to remove an owner from a Microsoft 365 group or a security group through the owners navigation property.
When owners are assigned to a group, the last owner (a user object) of the group cannot be removed.
This API is available in the following national cloud deployments.

### [Remove-MgBetaGroupPermissionGrant](Remove-MgBetaGroupPermissionGrant.md)
Delete navigation property permissionGrants for groups

### [Remove-MgBetaGroupPhoto](Remove-MgBetaGroupPhoto.md)
Delete navigation property photo for groups

### [Remove-MgBetaGroupRejectedSenderByRef](Remove-MgBetaGroupRejectedSenderByRef.md)
Remove a user or group from the rejected-senders list of the specified group.

### [Remove-MgBetaGroupSetting](Remove-MgBetaGroupSetting.md)
Delete navigation property settings for groups

### [Remove-MgBetaGroupSite](Remove-MgBetaGroupSite.md)
Unfollow a user's site or multiple sites.

### [Remove-MgBetaGroupThread](Remove-MgBetaGroupThread.md)
Delete conversationThread.
This API is available in the following national cloud deployments.

### [Remove-MgBetaGroupThreadPostAttachment](Remove-MgBetaGroupThreadPostAttachment.md)
Delete navigation property attachments for groups

### [Remove-MgBetaGroupThreadPostExtension](Remove-MgBetaGroupThreadPostExtension.md)
Delete navigation property extensions for groups

### [Remove-MgBetaGroupThreadPostInReplyToAttachment](Remove-MgBetaGroupThreadPostInReplyToAttachment.md)
Delete navigation property attachments for groups

### [Remove-MgBetaGroupThreadPostInReplyToExtension](Remove-MgBetaGroupThreadPostInReplyToExtension.md)
Delete navigation property extensions for groups

### [Remove-MgBetaGroupThreadPostInReplyToMention](Remove-MgBetaGroupThreadPostInReplyToMention.md)
Delete navigation property mentions for groups

### [Remove-MgBetaGroupThreadPostMention](Remove-MgBetaGroupThreadPostMention.md)
Delete navigation property mentions for groups

### [Reset-MgBetaGroupUnseenCount](Reset-MgBetaGroupUnseenCount.md)
Reset the unseenCount of all the posts that the current user hasn't seen since their last visit.
Supported for Microsoft 365 groups only.
This API is available in the following national cloud deployments.

### [Restore-MgBetaGroupDriveItem](Restore-MgBetaGroupDriveItem.md)
Restore a driveItem that has been deleted and is currently in the recycle bin.
This API is available in the following national cloud deployments.

### [Restore-MgBetaGroupDriveItemListItemDocumentSetVersion](Restore-MgBetaGroupDriveItemListItemDocumentSetVersion.md)
Restore a document set version.
This API is available in the following national cloud deployments.

### [Restore-MgBetaGroupDriveItemListItemVersion](Restore-MgBetaGroupDriveItemListItemVersion.md)
Invoke action restoreVersion

### [Restore-MgBetaGroupDriveItemVersion](Restore-MgBetaGroupDriveItemVersion.md)
Restore a previous version of a DriveItem to be the current version.
This will create a new version with the contents of the previous version, but preserves all existing versions of the file.
This API is available in the following national cloud deployments.

### [Restore-MgBetaGroupDriveListItemDocumentSetVersion](Restore-MgBetaGroupDriveListItemDocumentSetVersion.md)
Restore a document set version.
This API is available in the following national cloud deployments.

### [Restore-MgBetaGroupDriveListItemVersion](Restore-MgBetaGroupDriveListItemVersion.md)
Invoke action restoreVersion

### [Restore-MgBetaGroupDriveRoot](Restore-MgBetaGroupDriveRoot.md)
Restore a driveItem that has been deleted and is currently in the recycle bin.
This API is available in the following national cloud deployments.

### [Restore-MgBetaGroupDriveRootListItemDocumentSetVersion](Restore-MgBetaGroupDriveRootListItemDocumentSetVersion.md)
Restore a document set version.
This API is available in the following national cloud deployments.

### [Restore-MgBetaGroupDriveRootListItemVersion](Restore-MgBetaGroupDriveRootListItemVersion.md)
Invoke action restoreVersion

### [Restore-MgBetaGroupDriveRootVersion](Restore-MgBetaGroupDriveRootVersion.md)
Restore a previous version of a DriveItem to be the current version.
This will create a new version with the contents of the previous version, but preserves all existing versions of the file.
This API is available in the following national cloud deployments.

### [Restore-MgBetaGroupSiteListItemDocumentSetVersion](Restore-MgBetaGroupSiteListItemDocumentSetVersion.md)
Restore a document set version.
This API is available in the following national cloud deployments.

### [Restore-MgBetaGroupSiteListItemVersion](Restore-MgBetaGroupSiteListItemVersion.md)
Invoke action restoreVersion

### [Revoke-MgBetaGroupDriveItemPermissionGrant](Revoke-MgBetaGroupDriveItemPermissionGrant.md)
Revoke access to a listItem][] or [driveItem][] granted via a sharing link by removing the specified [recipient][] from the link.
This API is available in the following [national cloud deployments.

### [Revoke-MgBetaGroupDriveRootPermissionGrant](Revoke-MgBetaGroupDriveRootPermissionGrant.md)
Revoke access to a listItem][] or [driveItem][] granted via a sharing link by removing the specified [recipient][] from the link.
This API is available in the following [national cloud deployments.

### [Revoke-MgBetaGroupSitePermissionGrant](Revoke-MgBetaGroupSitePermissionGrant.md)
Revoke access to a listItem][] or [driveItem][] granted via a sharing link by removing the specified [recipient][] from the link.
This API is available in the following [national cloud deployments.

### [Search-MgBetaGroupDrive](Search-MgBetaGroupDrive.md)
Invoke function search

### [Search-MgBetaGroupDriveItem](Search-MgBetaGroupDriveItem.md)
Invoke function search

### [Search-MgBetaGroupDriveRoot](Search-MgBetaGroupDriveRoot.md)
Invoke function search

### [Set-MgBetaGroupDriveItemSensitivityLabel](Set-MgBetaGroupDriveItemSensitivityLabel.md)
Invoke action assignSensitivityLabel

### [Set-MgBetaGroupDriveRootSensitivityLabel](Set-MgBetaGroupDriveRootSensitivityLabel.md)
Invoke action assignSensitivityLabel

### [Set-MgBetaGroupLicense](Set-MgBetaGroupLicense.md)
Add or remove licenses on the group.
Licenses assigned to the group will be assigned to all users in the group.
To learn more about group-based licensing, see What is group-based licensing in Microsoft Entra ID.
To get the subscriptions available in the directory, perform a GET subscribedSkus request.
This API is available in the following national cloud deployments.

### [Set-MgBetaGroupPhotoContent](Set-MgBetaGroupPhotoContent.md)
Update media content for the navigation property photo in groups

### [Stop-MgBetaGroupCalendarEvent](Stop-MgBetaGroupCalendarEvent.md)
This action allows the organizer of a meeting to send a cancellation message and cancel the event.
The action moves the event to the Deleted Items folder.
The organizer can also cancel an occurrence of a recurring meeting \nby providing the occurrence event ID.
An attendee calling this action gets an error (HTTP 400 Bad Request), with the following\nerror message: 'Your request can't be completed.
You need to be an organizer to cancel a meeting.' This action differs from Delete in that Cancel is available to only the organizer, and lets\nthe organizer send a custom message to the attendees about the cancellation.
This API is available in the following national cloud deployments.

### [Stop-MgBetaGroupEvent](Stop-MgBetaGroupEvent.md)
This action allows the organizer of a meeting to send a cancellation message and cancel the event.
The action moves the event to the Deleted Items folder.
The organizer can also cancel an occurrence of a recurring meeting \nby providing the occurrence event ID.
An attendee calling this action gets an error (HTTP 400 Bad Request), with the following\nerror message: 'Your request can't be completed.
You need to be an organizer to cancel a meeting.' This action differs from Delete in that Cancel is available to only the organizer, and lets\nthe organizer send a custom message to the attendees about the cancellation.
This API is available in the following national cloud deployments.

### [Test-MgBetaGroupDriveItemPermission](Test-MgBetaGroupDriveItemPermission.md)
Invoke action validatePermission

### [Test-MgBetaGroupDriveListContentTypePublished](Test-MgBetaGroupDriveListContentTypePublished.md)
Invoke function isPublished

### [Test-MgBetaGroupDriveRootPermission](Test-MgBetaGroupDriveRootPermission.md)
Invoke action validatePermission

### [Test-MgBetaGroupDynamicMembership](Test-MgBetaGroupDynamicMembership.md)
Evaluate whether a user or device is or would be a member of a dynamic group.
The membership rule is returned along with other details that were used in the evaluation.
You can complete this operation in the following ways: This API is available in the following national cloud deployments.

### [Test-MgBetaGroupDynamicMembershipRule](Test-MgBetaGroupDynamicMembershipRule.md)
Invoke action evaluateDynamicMembership

### [Test-MgBetaGroupProperty](Test-MgBetaGroupProperty.md)
Validate if a Microsoft 365 group's display name or mail nickname complies with naming policies.
Clients can use the API to determine if a display name or mail nickname is valid before trying to update a Microsoft 365 group.
For validating properties before creating a group, use the validateProperties function for directory objects.
The following validations are performed for the display name and mail nickname properties: This API returns with the first failure encountered.
If one or more properties fail multiple validations, only the property with the first validation failure is returned.
However, you can validate both the mail nickname and the display name and receive a collection of validation errors if you are only validating the prefix and suffix naming policy.
This API is available in the following national cloud deployments.

### [Test-MgBetaGroupSiteContentTypePublished](Test-MgBetaGroupSiteContentTypePublished.md)
Invoke function isPublished

### [Test-MgBetaGroupSiteInformationProtectionDataLossPreventionPolicy](Test-MgBetaGroupSiteInformationProtectionDataLossPreventionPolicy.md)
Invoke action evaluate

### [Test-MgBetaGroupSiteInformationProtectionPolicyLabelApplication](Test-MgBetaGroupSiteInformationProtectionPolicyLabelApplication.md)
Compute the information protection label that should be applied and return the set of actions that must be taken to correctly label the information.
This API is useful when a label should be set manually or explicitly by a user or service, rather than automatically based on file contents.
Given contentInfo, which includes existing content metadata key/value pairs, and labelingOptions as an input, the API returns an informationProtectionAction object that contains one of more of the following:  This API is available in the following national cloud deployments.

### [Test-MgBetaGroupSiteInformationProtectionPolicyLabelClassificationResult](Test-MgBetaGroupSiteInformationProtectionPolicyLabelClassificationResult.md)
Using classification results, compute the information protection label that should be applied and return the set of actions that must be taken to correctly label the information.
This API is useful when a label should be set automatically based on classification of the file contents, rather than labeled directly by a user or service.
To evaluate based on classification results, provide contentInfo, which includes existing content metadata key/value pairs, and classification results.
The API returns an informationProtectionAction that contains one of more of the following: This API is available in the following national cloud deployments.

### [Test-MgBetaGroupSiteInformationProtectionPolicyLabelRemoval](Test-MgBetaGroupSiteInformationProtectionPolicyLabelRemoval.md)
Indicate to the consuming application what actions it should take to remove the label information.
Given contentInfo as an input, which includes existing content metadata key/value pairs, the API returns an informationProtectionAction that contains some combination of one of more of the following:  This API is available in the following national cloud deployments.

### [Test-MgBetaGroupSiteInformationProtectionSensitivityLabel](Test-MgBetaGroupSiteInformationProtectionSensitivityLabel.md)
Invoke action evaluate

### [Test-MgBetaGroupSiteInformationProtectionSensitivityLabelSublabel](Test-MgBetaGroupSiteInformationProtectionSensitivityLabelSublabel.md)
Invoke action evaluate

### [Test-MgBetaGroupSiteListContentTypePublished](Test-MgBetaGroupSiteListContentTypePublished.md)
Invoke function isPublished

### [Unpublish-MgBetaGroupDriveListContentType](Unpublish-MgBetaGroupDriveListContentType.md)
Unpublish a contentType][] from a content type hub site.
This API is available in the following [national cloud deployments.

### [Unpublish-MgBetaGroupSiteContentType](Unpublish-MgBetaGroupSiteContentType.md)
Unpublish a contentType][] from a content type hub site.
This API is available in the following [national cloud deployments.

### [Unpublish-MgBetaGroupSiteListContentType](Unpublish-MgBetaGroupSiteListContentType.md)
Unpublish a contentType][] from a content type hub site.
This API is available in the following [national cloud deployments.

### [Update-MgBetaGroup](Update-MgBetaGroup.md)
Update the properties of a group object.
This API is available in the following national cloud deployments.

### [Update-MgBetaGroupByUniqueName](Update-MgBetaGroupByUniqueName.md)
Update the properties of a group object.
This API is available in the following national cloud deployments.

### [Update-MgBetaGroupConversationThread](Update-MgBetaGroupConversationThread.md)
Update the navigation property threads in groups

### [Update-MgBetaGroupConversationThreadPost](Update-MgBetaGroupConversationThreadPost.md)
Update the navigation property posts in groups

### [Update-MgBetaGroupConversationThreadPostExtension](Update-MgBetaGroupConversationThreadPostExtension.md)
Update an open extension (openTypeExtension object) with the properties in the request body: The data in an extension can be primitive types, or arrays of primitive types.
See the table in the Permissions section for the list of resources that support open extensions.
This API is available in the following national cloud deployments.

### [Update-MgBetaGroupConversationThreadPostInReplyToExtension](Update-MgBetaGroupConversationThreadPostInReplyToExtension.md)
Update an open extension (openTypeExtension object) with the properties in the request body: The data in an extension can be primitive types, or arrays of primitive types.
See the table in the Permissions section for the list of resources that support open extensions.
This API is available in the following national cloud deployments.

### [Update-MgBetaGroupEndpoint](Update-MgBetaGroupEndpoint.md)
Update the navigation property endpoints in groups

### [Update-MgBetaGroupExtension](Update-MgBetaGroupExtension.md)
Update the navigation property extensions in groups

### [Update-MgBetaGroupLifecyclePolicy](Update-MgBetaGroupLifecyclePolicy.md)
Update the properties of a groupLifecyclePolicygroupLifecyclePolicy resource type object.
This API is available in the following national cloud deployments.

### [Update-MgBetaGroupOnenotePageContent](Update-MgBetaGroupOnenotePageContent.md)
Invoke action onenotePatchContent

### [Update-MgBetaGroupPermissionGrant](Update-MgBetaGroupPermissionGrant.md)
Update the navigation property permissionGrants in groups

### [Update-MgBetaGroupSetting](Update-MgBetaGroupSetting.md)
Update the navigation property settings in groups

### [Update-MgBetaGroupThread](Update-MgBetaGroupThread.md)
Update a thread object.
This API is available in the following national cloud deployments.

### [Update-MgBetaGroupThreadPost](Update-MgBetaGroupThreadPost.md)
Update the navigation property posts in groups

### [Update-MgBetaGroupThreadPostExtension](Update-MgBetaGroupThreadPostExtension.md)
Update an open extension (openTypeExtension object) with the properties in the request body: The data in an extension can be primitive types, or arrays of primitive types.
See the table in the Permissions section for the list of resources that support open extensions.
This API is available in the following national cloud deployments.

### [Update-MgBetaGroupThreadPostInReplyToExtension](Update-MgBetaGroupThreadPostInReplyToExtension.md)
Update an open extension (openTypeExtension object) with the properties in the request body: The data in an extension can be primitive types, or arrays of primitive types.
See the table in the Permissions section for the list of resources that support open extensions.
This API is available in the following national cloud deployments.

