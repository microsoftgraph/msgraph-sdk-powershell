---
Module Name: Microsoft.Graph.Beta.Groups
Module Guid: 8818bd08-77c2-4c0a-80d1-6a465fd53c78
Download Help Link: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.Beta.groups
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Beta.Groups Module
## Description
Microsoft.Graph.Beta PowerShell Cmdlets

## Microsoft.Graph.Beta.Groups Cmdlets
### [Add-MgBetaGroupDriveListContentTypeCopy](Add-MgBetaGroupDriveListContentTypeCopy.md)
Add a copy of a [content type][contentType] from a [site][site] to a [list][list].

### [Add-MgBetaGroupDriveListContentTypeCopyFromContentTypeHub](Add-MgBetaGroupDriveListContentTypeCopyFromContentTypeHub.md)
Add or sync a copy of a published content type from the content type hub to a target site or a list.
This method is part of the content type publishing changes to optimize the syncing of published content types to sites and lists, effectively switching from a 'push everywhere' to 'pull as needed' approach.
The method allows users to pull content types directly from the content type hub to a site or list.
For more information, see getCompatibleHubContentTypes and the blog post Syntex Product Updates – August 2021.

### [Add-MgBetaGroupFavorite](Add-MgBetaGroupFavorite.md)
Add the group to the list of the current user's favorite groups.
Supported for Microsoft 365 groups only.

### [Add-MgBetaGroupSite](Add-MgBetaGroupSite.md)
Follow a user's site or multiple sites.

### [Add-MgBetaGroupSiteContentTypeCopy](Add-MgBetaGroupSiteContentTypeCopy.md)
Add a copy of a [content type][contentType] from a [site][site] to a [list][list].

### [Add-MgBetaGroupSiteContentTypeCopyFromContentTypeHub](Add-MgBetaGroupSiteContentTypeCopyFromContentTypeHub.md)
Add or sync a copy of a published content type from the content type hub to a target site or a list.
This method is part of the content type publishing changes to optimize the syncing of published content types to sites and lists, effectively switching from a 'push everywhere' to 'pull as needed' approach.
The method allows users to pull content types directly from the content type hub to a site or list.
For more information, see getCompatibleHubContentTypes and the blog post Syntex Product Updates – August 2021.

### [Add-MgBetaGroupSiteListContentTypeCopy](Add-MgBetaGroupSiteListContentTypeCopy.md)
Add a copy of a [content type][contentType] from a [site][site] to a [list][list].

### [Add-MgBetaGroupSiteListContentTypeCopyFromContentTypeHub](Add-MgBetaGroupSiteListContentTypeCopyFromContentTypeHub.md)
Add or sync a copy of a published content type from the content type hub to a target site or a list.
This method is part of the content type publishing changes to optimize the syncing of published content types to sites and lists, effectively switching from a 'push everywhere' to 'pull as needed' approach.
The method allows users to pull content types directly from the content type hub to a site or list.
For more information, see getCompatibleHubContentTypes and the blog post Syntex Product Updates – August 2021.

### [Add-MgBetaGroupToLifecyclePolicy](Add-MgBetaGroupToLifecyclePolicy.md)
Invoke action addGroup

### [Confirm-MgBetaGroupGrantedPermissionForApp](Confirm-MgBetaGroupGrantedPermissionForApp.md)
Invoke action checkGrantedPermissionsForApp

### [Confirm-MgBetaGroupMemberGroup](Confirm-MgBetaGroupMemberGroup.md)
Check for membership in a specified list of group IDs, and return from that list those groups (identified by IDs) of which the specified user, group, service principal, organizational contact, device, or directory object is a member.
This function is transitive.
You can check up to a maximum of 20 groups per request.
This function supports all groups provisioned in Azure AD.
Because Microsoft 365 groups cannot contain other groups, membership in a Microsoft 365 group is always direct.

### [Confirm-MgBetaGroupMemberObject](Confirm-MgBetaGroupMemberObject.md)
Invoke action checkMemberObjects

### [Confirm-MgBetaGroupPermissionGrantMemberGroup](Confirm-MgBetaGroupPermissionGrantMemberGroup.md)
Check for membership in a specified list of group IDs, and return from that list those groups (identified by IDs) of which the specified user, group, service principal, organizational contact, device, or directory object is a member.
This function is transitive.
You can check up to a maximum of 20 groups per request.
This function supports all groups provisioned in Azure AD.
Because Microsoft 365 groups cannot contain other groups, membership in a Microsoft 365 group is always direct.

### [Confirm-MgBetaGroupPermissionGrantMemberObject](Confirm-MgBetaGroupPermissionGrantMemberObject.md)
Invoke action checkMemberObjects

### [Copy-MgBetaGroupDriveItem](Copy-MgBetaGroupDriveItem.md)
Asynchronously creates a copy of an [driveItem][item-resource] (including any children), under a new parent item or with a new name.

### [Copy-MgBetaGroupDriveListContentTypeToDefaultContentLocation](Copy-MgBetaGroupDriveListContentTypeToDefaultContentLocation.md)
Copy a file to a default content location in a [content type][contentType].
The file can then be added as a default file or template via a POST operation.

### [Copy-MgBetaGroupDriveRoot](Copy-MgBetaGroupDriveRoot.md)
Asynchronously creates a copy of an [driveItem][item-resource] (including any children), under a new parent item or with a new name.

### [Copy-MgBetaGroupOnenoteNotebook](Copy-MgBetaGroupOnenoteNotebook.md)
Copies a notebook to the Notebooks folder in the destination Documents library.
The folder is created if it doesn't exist.
For Copy operations, you follow an asynchronous calling pattern:  First call the Copy action, and then poll the operation endpoint for the result.

### [Copy-MgBetaGroupOnenotePageToSection](Copy-MgBetaGroupOnenotePageToSection.md)
Copy a page to a specific section.
For copy operations, you follow an asynchronous calling pattern:  First call the Copy action, and then poll the operation endpoint for the result.

### [Copy-MgBetaGroupOnenoteSectionToNotebook](Copy-MgBetaGroupOnenoteSectionToNotebook.md)
Copies a section to a specific notebook.
For Copy operations, you follow an asynchronous calling pattern:  First call the Copy action, and then poll the operation endpoint for the result.

### [Copy-MgBetaGroupOnenoteSectionToSectionGroup](Copy-MgBetaGroupOnenoteSectionToSectionGroup.md)
Copies a section to a specific section group.
For Copy operations, you follow an asynchronous calling pattern:  First call the Copy action, and then poll the operation endpoint for the result.

### [Copy-MgBetaGroupSiteContentTypeToDefaultContentLocation](Copy-MgBetaGroupSiteContentTypeToDefaultContentLocation.md)
Copy a file to a default content location in a [content type][contentType].
The file can then be added as a default file or template via a POST operation.

### [Copy-MgBetaGroupSiteListContentTypeToDefaultContentLocation](Copy-MgBetaGroupSiteListContentTypeToDefaultContentLocation.md)
Copy a file to a default content location in a [content type][contentType].
The file can then be added as a default file or template via a POST operation.

### [Get-MgBetaGroup](Get-MgBetaGroup.md)
Get the properties and relationships of a group object.
This operation returns by default only a subset of all the available properties, as noted in the Properties section.
To get properties that are _not_ returned by default, specify them in a `$select` OData query option.
The **hasMembersWithLicenseErrors** and **isArchived** properties are an exception and are not returned in the `$select` query.
Because the **group** resource supports extensions, you can also use the `GET` operation to get custom properties and extension data in a **group** instance.

### [Get-MgBetaGroupAcceptedSender](Get-MgBetaGroupAcceptedSender.md)
Get a list of users or groups that are in the accepted-senders list for this group.
Users in the accepted senders list can post to conversations of the group (identified in the GET request URL).
Make sure you do not specify the same user or group in the accepted senders and rejected senders lists, otherwise you will get an error.

### [Get-MgBetaGroupAcceptedSenderByRef](Get-MgBetaGroupAcceptedSenderByRef.md)
Get a list of users or groups that are in the accepted-senders list for this group.
Users in the accepted senders list can post to conversations of the group (identified in the GET request URL).
Make sure you do not specify the same user or group in the accepted senders and rejected senders lists, otherwise you will get an error.

### [Get-MgBetaGroupById](Get-MgBetaGroupById.md)
Return the directory objects specified in a list of IDs.
Some common uses for this function are to:

### [Get-MgBetaGroupCalendarEventDelta](Get-MgBetaGroupCalendarEventDelta.md)
Get a set of event resources that have been added, deleted, or updated in one or more calendars.
You can get specific types of these incremental changes in the events in all the calendars of a mailbox or in a specific calendar, or in an event collection of a **calendarView** (range of events defined by start and end dates) of a calendar.
The calendar can be the default calendar or some other specified calendar of the user's.
In the case of getting incremental changes on **calendarView**, the calendar can be a group calendar as well.
Typically, synchronizing events in a calendar or **calendarView** in a local store entails a round of multiple **delta** function calls.
The initial call is a full synchronization, and every subsequent **delta** call in the same round gets the incremental changes (additions, deletions, or updates).
This allows you to maintain and synchronize a local store of events in the specified calendar, without having to fetch all the events of that calendar from the server every time.
The following table lists the differences between the **delta** function on events and the **delta** function on a **calendarView** in a calendar.

### [Get-MgBetaGroupCalendarSchedule](Get-MgBetaGroupCalendarSchedule.md)
Get the free/busy availability information for a collection of users, distributions lists, or resources (rooms or equipment) for a specified time period.

### [Get-MgBetaGroupConversation](Get-MgBetaGroupConversation.md)
The group's conversations.

### [Get-MgBetaGroupConversationThread](Get-MgBetaGroupConversationThread.md)
A collection of all the conversation threads in the conversation.
A navigation property.
Read-only.
Nullable.

### [Get-MgBetaGroupConversationThreadPost](Get-MgBetaGroupConversationThreadPost.md)
Get posts from groups

### [Get-MgBetaGroupConversationThreadPostAttachment](Get-MgBetaGroupConversationThreadPostAttachment.md)
The collection of fileAttachment, itemAttachment, and referenceAttachment attachments for the post.
Read-only.
Nullable.
Supports $expand.

### [Get-MgBetaGroupConversationThreadPostExtension](Get-MgBetaGroupConversationThreadPostExtension.md)
The collection of open extensions defined for the post.
Read-only.
Nullable.
Supports $expand.

### [Get-MgBetaGroupConversationThreadPostInReplyToAttachment](Get-MgBetaGroupConversationThreadPostInReplyToAttachment.md)
The collection of fileAttachment, itemAttachment, and referenceAttachment attachments for the post.
Read-only.
Nullable.
Supports $expand.

### [Get-MgBetaGroupConversationThreadPostInReplyToExtension](Get-MgBetaGroupConversationThreadPostInReplyToExtension.md)
The collection of open extensions defined for the post.
Read-only.
Nullable.
Supports $expand.

### [Get-MgBetaGroupConversationThreadPostInReplyToMention](Get-MgBetaGroupConversationThreadPostInReplyToMention.md)
Get mentions from groups

### [Get-MgBetaGroupConversationThreadPostInReplyToMultiValueExtendedProperty](Get-MgBetaGroupConversationThreadPostInReplyToMultiValueExtendedProperty.md)
The collection of multi-value extended properties defined for the post.
Read-only.
Nullable.

### [Get-MgBetaGroupConversationThreadPostInReplyToSingleValueExtendedProperty](Get-MgBetaGroupConversationThreadPostInReplyToSingleValueExtendedProperty.md)
The collection of single-value extended properties defined for the post.
Read-only.
Nullable.

### [Get-MgBetaGroupConversationThreadPostMention](Get-MgBetaGroupConversationThreadPostMention.md)
Get mentions from groups

### [Get-MgBetaGroupConversationThreadPostMultiValueExtendedProperty](Get-MgBetaGroupConversationThreadPostMultiValueExtendedProperty.md)
The collection of multi-value extended properties defined for the post.
Read-only.
Nullable.

### [Get-MgBetaGroupConversationThreadPostSingleValueExtendedProperty](Get-MgBetaGroupConversationThreadPostSingleValueExtendedProperty.md)
The collection of single-value extended properties defined for the post.
Read-only.
Nullable.

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
Endpoints for the group.
Read-only.
Nullable.

### [Get-MgBetaGroupEventDelta](Get-MgBetaGroupEventDelta.md)
Get a set of event resources that have been added, deleted, or updated in one or more calendars.
You can get specific types of these incremental changes in the events in all the calendars of a mailbox or in a specific calendar, or in an event collection of a **calendarView** (range of events defined by start and end dates) of a calendar.
The calendar can be the default calendar or some other specified calendar of the user's.
In the case of getting incremental changes on **calendarView**, the calendar can be a group calendar as well.
Typically, synchronizing events in a calendar or **calendarView** in a local store entails a round of multiple **delta** function calls.
The initial call is a full synchronization, and every subsequent **delta** call in the same round gets the incremental changes (additions, deletions, or updates).
This allows you to maintain and synchronize a local store of events in the specified calendar, without having to fetch all the events of that calendar from the server every time.
The following table lists the differences between the **delta** function on events and the **delta** function on a **calendarView** in a calendar.

### [Get-MgBetaGroupExtension](Get-MgBetaGroupExtension.md)
The collection of open extensions defined for the group.
Read-only.
Nullable.

### [Get-MgBetaGroupLifecyclePolicy](Get-MgBetaGroupLifecyclePolicy.md)
Retrieve the properties and relationships of a groupLifecyclePolicies object.

### [Get-MgBetaGroupLifecyclePolicyByGroup](Get-MgBetaGroupLifecyclePolicyByGroup.md)
Retrieves a list of groupLifecyclePolicy objects to which a group belongs.

### [Get-MgBetaGroupMember](Get-MgBetaGroupMember.md)
Direct members of this group, who can be users, devices, other groups, or service principals.
Supports the List members, Add member, and Remove member operations.
Nullable.
Supports $expand including nested $select.
For example, /groups?$filter=startsWith(displayName,'Role')&$select=id,displayName&$expand=members($select=id,userPrincipalName,displayName).

### [Get-MgBetaGroupMemberByRef](Get-MgBetaGroupMemberByRef.md)
Direct members of this group, who can be users, devices, other groups, or service principals.
Supports the List members, Add member, and Remove member operations.
Nullable.
Supports $expand including nested $select.
For example, /groups?$filter=startsWith(displayName,'Role')&$select=id,displayName&$expand=members($select=id,userPrincipalName,displayName).

### [Get-MgBetaGroupMemberGroup](Get-MgBetaGroupMemberGroup.md)
Return all the group IDs for the groups that the specified user, group, service principal, organizational contact, device, or directory object is a member of.
This function is transitive.

### [Get-MgBetaGroupMemberObject](Get-MgBetaGroupMemberObject.md)
Invoke action getMemberObjects

### [Get-MgBetaGroupMemberOf](Get-MgBetaGroupMemberOf.md)
Groups and administrative units that this group is a member of.
HTTP Methods: GET (supported for all groups).
Read-only.
Nullable.
Supports $expand.

### [Get-MgBetaGroupMemberWithLicenseError](Get-MgBetaGroupMemberWithLicenseError.md)
A list of group members with license errors from this group-based license assignment.
Read-only.

### [Get-MgBetaGroupOnenoteNotebookFromWebUrl](Get-MgBetaGroupOnenoteNotebookFromWebUrl.md)
Retrieve the properties and relationships of a notebook object by using its URL path.
The location can be user notebooks on Microsoft 365, group notebooks, or SharePoint site-hosted team notebooks on Microsoft 365.

### [Get-MgBetaGroupOnenoteRecentNotebook](Get-MgBetaGroupOnenoteRecentNotebook.md)
Invoke function getRecentNotebooks

### [Get-MgBetaGroupOwner](Get-MgBetaGroupOwner.md)
The owners of the group who can be users or service principals.
Nullable.
If this property is not specified when creating a Microsoft 365 group, the calling user is automatically assigned as the group owner.
Supports $filter (/$count eq 0, /$count ne 0, /$count eq 1, /$count ne 1); Supports $expand including nested $select.
For example, /groups?$filter=startsWith(displayName,'Role')&$select=id,displayName&$expand=owners($select=id,userPrincipalName,displayName).

### [Get-MgBetaGroupOwnerByRef](Get-MgBetaGroupOwnerByRef.md)
The owners of the group who can be users or service principals.
Nullable.
If this property is not specified when creating a Microsoft 365 group, the calling user is automatically assigned as the group owner.
Supports $filter (/$count eq 0, /$count ne 0, /$count eq 1, /$count ne 1); Supports $expand including nested $select.
For example, /groups?$filter=startsWith(displayName,'Role')&$select=id,displayName&$expand=owners($select=id,userPrincipalName,displayName).

### [Get-MgBetaGroupPermissionGrant](Get-MgBetaGroupPermissionGrant.md)
The permissions that have been granted for a group to a specific application.
Supports $expand.

### [Get-MgBetaGroupPermissionGrantById](Get-MgBetaGroupPermissionGrantById.md)
Return the directory objects specified in a list of IDs.
Some common uses for this function are to:

### [Get-MgBetaGroupPermissionGrantMemberGroup](Get-MgBetaGroupPermissionGrantMemberGroup.md)
Return all the group IDs for the groups that the specified user, group, service principal, organizational contact, device, or directory object is a member of.
This function is transitive.

### [Get-MgBetaGroupPermissionGrantMemberObject](Get-MgBetaGroupPermissionGrantMemberObject.md)
Invoke action getMemberObjects

### [Get-MgBetaGroupPermissionGrantUserOwnedObject](Get-MgBetaGroupPermissionGrantUserOwnedObject.md)
Invoke action getUserOwnedObjects

### [Get-MgBetaGroupPhoto](Get-MgBetaGroupPhoto.md)
The group's profile photo.

### [Get-MgBetaGroupPhotoContent](Get-MgBetaGroupPhotoContent.md)
Get media content for the navigation property photo from groups

### [Get-MgBetaGroupRejectedSender](Get-MgBetaGroupRejectedSender.md)
Get a list of users or groups that are in the rejected-senders list for this group.
Users in the rejected senders list cannot post to conversations of the group (identified in the GET request URL).
Make sure you do not specify the same user or group in the rejected senders and accepted senders lists, otherwise you will get an error.

### [Get-MgBetaGroupRejectedSenderByRef](Get-MgBetaGroupRejectedSenderByRef.md)
Get a list of users or groups that are in the rejected-senders list for this group.
Users in the rejected senders list cannot post to conversations of the group (identified in the GET request URL).
Make sure you do not specify the same user or group in the rejected senders and accepted senders lists, otherwise you will get an error.

### [Get-MgBetaGroupSetting](Get-MgBetaGroupSetting.md)
Settings that can govern this group's behavior, like whether members can invite guest users to the group.
Nullable.

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
The group's conversation threads.
Nullable.

### [Get-MgBetaGroupThreadPost](Get-MgBetaGroupThreadPost.md)
Get posts from groups

### [Get-MgBetaGroupThreadPostAttachment](Get-MgBetaGroupThreadPostAttachment.md)
The collection of fileAttachment, itemAttachment, and referenceAttachment attachments for the post.
Read-only.
Nullable.
Supports $expand.

### [Get-MgBetaGroupThreadPostExtension](Get-MgBetaGroupThreadPostExtension.md)
The collection of open extensions defined for the post.
Read-only.
Nullable.
Supports $expand.

### [Get-MgBetaGroupThreadPostInReplyToAttachment](Get-MgBetaGroupThreadPostInReplyToAttachment.md)
The collection of fileAttachment, itemAttachment, and referenceAttachment attachments for the post.
Read-only.
Nullable.
Supports $expand.

### [Get-MgBetaGroupThreadPostInReplyToExtension](Get-MgBetaGroupThreadPostInReplyToExtension.md)
The collection of open extensions defined for the post.
Read-only.
Nullable.
Supports $expand.

### [Get-MgBetaGroupThreadPostInReplyToMention](Get-MgBetaGroupThreadPostInReplyToMention.md)
Get mentions from groups

### [Get-MgBetaGroupThreadPostInReplyToMultiValueExtendedProperty](Get-MgBetaGroupThreadPostInReplyToMultiValueExtendedProperty.md)
The collection of multi-value extended properties defined for the post.
Read-only.
Nullable.

### [Get-MgBetaGroupThreadPostInReplyToSingleValueExtendedProperty](Get-MgBetaGroupThreadPostInReplyToSingleValueExtendedProperty.md)
The collection of single-value extended properties defined for the post.
Read-only.
Nullable.

### [Get-MgBetaGroupThreadPostMention](Get-MgBetaGroupThreadPostMention.md)
Get mentions from groups

### [Get-MgBetaGroupThreadPostMultiValueExtendedProperty](Get-MgBetaGroupThreadPostMultiValueExtendedProperty.md)
The collection of multi-value extended properties defined for the post.
Read-only.
Nullable.

### [Get-MgBetaGroupThreadPostSingleValueExtendedProperty](Get-MgBetaGroupThreadPostSingleValueExtendedProperty.md)
The collection of single-value extended properties defined for the post.
Read-only.
Nullable.

### [Get-MgBetaGroupTransitiveMember](Get-MgBetaGroupTransitiveMember.md)
The direct and transitive members of a group.
Nullable.

### [Get-MgBetaGroupTransitiveMemberOf](Get-MgBetaGroupTransitiveMemberOf.md)
The groups that a group is a member of, either directly and through nested membership.
Nullable.

### [Get-MgBetaGroupUserOwnedObject](Get-MgBetaGroupUserOwnedObject.md)
Invoke action getUserOwnedObjects

### [Get-MgBetaUserJoinedGroup](Get-MgBetaUserJoinedGroup.md)
Get joinedGroups from users

### [Grant-MgBetaGroupDriveItemPermission](Grant-MgBetaGroupDriveItemPermission.md)
Grant users access to a link represented by a [permission][].

### [Grant-MgBetaGroupDriveRootPermission](Grant-MgBetaGroupDriveRootPermission.md)
Grant users access to a link represented by a [permission][].

### [Grant-MgBetaGroupSitePermission](Grant-MgBetaGroupSitePermission.md)
Grant users access to a link represented by a [permission][].

### [Invoke-MgBetaAcceptGroupCalendarEvent](Invoke-MgBetaAcceptGroupCalendarEvent.md)
Accept the specified event in a user calendar.

### [Invoke-MgBetaAcceptGroupCalendarEventTentatively](Invoke-MgBetaAcceptGroupCalendarEventTentatively.md)
Tentatively accept the specified event in a user calendar.
If the event allows proposals for new times, on responding tentative to the event, an invitee can choose to suggest an alternative time by including the **proposedNewTime** parameter.
For more information on how to propose a time, and how to receive and accept a new time proposal, see Propose new meeting times.

### [Invoke-MgBetaAcceptGroupEvent](Invoke-MgBetaAcceptGroupEvent.md)
Accept the specified event in a user calendar.

### [Invoke-MgBetaAcceptGroupEventTentatively](Invoke-MgBetaAcceptGroupEventTentatively.md)
Tentatively accept the specified event in a user calendar.
If the event allows proposals for new times, on responding tentative to the event, an invitee can choose to suggest an alternative time by including the **proposedNewTime** parameter.
For more information on how to propose a time, and how to receive and accept a new time proposal, see Propose new meeting times.

### [Invoke-MgBetaCalendarGroupCalendar](Invoke-MgBetaCalendarGroupCalendar.md)
Invoke function allowedCalendarSharingRoles

### [Invoke-MgBetaCheckinGroupDriveItem](Invoke-MgBetaCheckinGroupDriveItem.md)
Check in a checked out **driveItem** resource, which makes the version of the document available to others.

### [Invoke-MgBetaCheckinGroupDriveRoot](Invoke-MgBetaCheckinGroupDriveRoot.md)
Check in a checked out **driveItem** resource, which makes the version of the document available to others.

### [Invoke-MgBetaCheckoutGroupDriveItem](Invoke-MgBetaCheckoutGroupDriveItem.md)
Check out a **driveItem** resource to prevent others from editing the document, and prevent your changes from being visible until the documented is checked in.

### [Invoke-MgBetaCheckoutGroupDriveRoot](Invoke-MgBetaCheckoutGroupDriveRoot.md)
Check out a **driveItem** resource to prevent others from editing the document, and prevent your changes from being visible until the documented is checked in.

### [Invoke-MgBetaDeclineGroupCalendarEvent](Invoke-MgBetaDeclineGroupCalendarEvent.md)
Decline invitation to the specified event in a user calendar.
If the event allows proposals for new times, on declining the event, an invitee can choose to suggest an alternative time by including the **proposedNewTime** parameter.
For more information on how to propose a time, and how to receive and accept a new time proposal, see Propose new meeting times.

### [Invoke-MgBetaDeclineGroupEvent](Invoke-MgBetaDeclineGroupEvent.md)
Decline invitation to the specified event in a user calendar.
If the event allows proposals for new times, on declining the event, an invitee can choose to suggest an alternative time by including the **proposedNewTime** parameter.
For more information on how to propose a time, and how to receive and accept a new time proposal, see Propose new meeting times.

### [Invoke-MgBetaDismissGroupCalendarEventReminder](Invoke-MgBetaDismissGroupCalendarEventReminder.md)
Dismiss a reminder that has been triggered for an event in a user calendar.

### [Invoke-MgBetaDismissGroupEventReminder](Invoke-MgBetaDismissGroupEventReminder.md)
Dismiss a reminder that has been triggered for an event in a user calendar.

### [Invoke-MgBetaExtractGroupDriveItemSensitivityLabel](Invoke-MgBetaExtractGroupDriveItemSensitivityLabel.md)
Invoke action extractSensitivityLabels

### [Invoke-MgBetaExtractGroupDriveRootSensitivityLabel](Invoke-MgBetaExtractGroupDriveRootSensitivityLabel.md)
Invoke action extractSensitivityLabels

### [Invoke-MgBetaFollowGroupDriveItem](Invoke-MgBetaFollowGroupDriveItem.md)
Follow a driveItem.

### [Invoke-MgBetaFollowGroupDriveRoot](Invoke-MgBetaFollowGroupDriveRoot.md)
Follow a driveItem.

### [Invoke-MgBetaForwardGroupCalendarEvent](Invoke-MgBetaForwardGroupCalendarEvent.md)
This action allows the organizer or attendee of a meeting event to forward the \nmeeting request to a new recipient.
If the meeting event is forwarded from an attendee's Microsoft 365 mailbox to another recipient, this action \nalso sends a message to notify the organizer of the forwarding, and adds the recipient to the organizer's \ncopy of the meeting event.
This convenience is not available when forwarding from an Outlook.com account.

### [Invoke-MgBetaForwardGroupConversationThreadPost](Invoke-MgBetaForwardGroupConversationThreadPost.md)
Forward a post to a recipient.
You can specify both the parent conversation and thread in the request, \nor, you can specify just the parent thread without the parent conversation.

### [Invoke-MgBetaForwardGroupConversationThreadPostInReplyTo](Invoke-MgBetaForwardGroupConversationThreadPostInReplyTo.md)
Forward a post to a recipient.
You can specify both the parent conversation and thread in the request, \nor, you can specify just the parent thread without the parent conversation.

### [Invoke-MgBetaForwardGroupEvent](Invoke-MgBetaForwardGroupEvent.md)
This action allows the organizer or attendee of a meeting event to forward the \nmeeting request to a new recipient.
If the meeting event is forwarded from an attendee's Microsoft 365 mailbox to another recipient, this action \nalso sends a message to notify the organizer of the forwarding, and adds the recipient to the organizer's \ncopy of the meeting event.
This convenience is not available when forwarding from an Outlook.com account.

### [Invoke-MgBetaForwardGroupThreadPost](Invoke-MgBetaForwardGroupThreadPost.md)
Forward a post to a recipient.
You can specify both the parent conversation and thread in the request, \nor, you can specify just the parent thread without the parent conversation.

### [Invoke-MgBetaForwardGroupThreadPostInReplyTo](Invoke-MgBetaForwardGroupThreadPostInReplyTo.md)
Forward a post to a recipient.
You can specify both the parent conversation and thread in the request, \nor, you can specify just the parent thread without the parent conversation.

### [Invoke-MgBetaGraphGroup](Invoke-MgBetaGraphGroup.md)
Calling this method will disable the current user to receive email notifications for this group about new posts, events, and files in that group.
Supported for Microsoft 365 groups only.

### [Invoke-MgBetaGraphGroupDrive](Invoke-MgBetaGraphGroupDrive.md)
Invoke function sharedWithMe

### [Invoke-MgBetaInviteGroupDriveItem](Invoke-MgBetaInviteGroupDriveItem.md)
Sends a sharing invitation for a **DriveItem**.\nA sharing invitation provides permissions to the recipients and optionally sends an email to the recipients to notify them the item was shared.

### [Invoke-MgBetaInviteGroupDriveRoot](Invoke-MgBetaInviteGroupDriveRoot.md)
Sends a sharing invitation for a **DriveItem**.\nA sharing invitation provides permissions to the recipients and optionally sends an email to the recipients to notify them the item was shared.

### [Invoke-MgBetaPreviewGroupDriveItem](Invoke-MgBetaPreviewGroupDriveItem.md)
Invoke action preview

### [Invoke-MgBetaPreviewGroupDriveRoot](Invoke-MgBetaPreviewGroupDriveRoot.md)
Invoke action preview

### [Invoke-MgBetaPreviewGroupOnenotePage](Invoke-MgBetaPreviewGroupOnenotePage.md)
Invoke function preview

### [Invoke-MgBetaReauthorizeGroupDriveItemSubscription](Invoke-MgBetaReauthorizeGroupDriveItemSubscription.md)
Invoke action reauthorize

### [Invoke-MgBetaReauthorizeGroupDriveListSubscription](Invoke-MgBetaReauthorizeGroupDriveListSubscription.md)
Invoke action reauthorize

### [Invoke-MgBetaReauthorizeGroupDriveRootSubscription](Invoke-MgBetaReauthorizeGroupDriveRootSubscription.md)
Invoke action reauthorize

### [Invoke-MgBetaReauthorizeGroupSiteListSubscription](Invoke-MgBetaReauthorizeGroupSiteListSubscription.md)
Invoke action reauthorize

### [Invoke-MgBetaRecentGroupDrive](Invoke-MgBetaRecentGroupDrive.md)
Invoke function recent

### [Invoke-MgBetaRenewGroup](Invoke-MgBetaRenewGroup.md)
Renews a group's expiration.
When a group is renewed, the group expiration is extended by the number of days defined in the policy.

### [Invoke-MgBetaRenewGroupLifecyclePolicy](Invoke-MgBetaRenewGroupLifecyclePolicy.md)
Renew a group's expiration.
When a group is renewed, the group expiration is extended by the number of days defined in the policy.

### [Invoke-MgBetaReplyGroupConversationThread](Invoke-MgBetaReplyGroupConversationThread.md)
Add an attachment when creating a group post.
This operation limits the size of the attachment you can add to under 3 MB.
An attachment can be one of the following types: All these types of attachment resources are derived from the attachment\nresource.

### [Invoke-MgBetaReplyGroupConversationThreadPost](Invoke-MgBetaReplyGroupConversationThreadPost.md)
Reply to a post and add a new post to the specified thread in a group conversation.
You can specify both the parent conversation and thread in the request, or, you can specify just the parent thread without the parent conversation.

### [Invoke-MgBetaReplyGroupConversationThreadPostInReplyTo](Invoke-MgBetaReplyGroupConversationThreadPostInReplyTo.md)
Reply to a post and add a new post to the specified thread in a group conversation.
You can specify both the parent conversation and thread in the request, or, you can specify just the parent thread without the parent conversation.

### [Invoke-MgBetaReplyGroupThread](Invoke-MgBetaReplyGroupThread.md)
Add an attachment when creating a group post.
This operation limits the size of the attachment you can add to under 3 MB.
An attachment can be one of the following types: All these types of attachment resources are derived from the attachment\nresource.

### [Invoke-MgBetaReplyGroupThreadPost](Invoke-MgBetaReplyGroupThreadPost.md)
Reply to a post and add a new post to the specified thread in a group conversation.
You can specify both the parent conversation and thread in the request, or, you can specify just the parent thread without the parent conversation.

### [Invoke-MgBetaReplyGroupThreadPostInReplyTo](Invoke-MgBetaReplyGroupThreadPostInReplyTo.md)
Reply to a post and add a new post to the specified thread in a group conversation.
You can specify both the parent conversation and thread in the request, or, you can specify just the parent thread without the parent conversation.

### [Invoke-MgBetaSnoozeGroupCalendarEventReminder](Invoke-MgBetaSnoozeGroupCalendarEventReminder.md)
Postpone a reminder for an event in a user calendar until a new time.

### [Invoke-MgBetaSnoozeGroupEventReminder](Invoke-MgBetaSnoozeGroupEventReminder.md)
Postpone a reminder for an event in a user calendar until a new time.

### [Invoke-MgBetaSubscribeGroupByMail](Invoke-MgBetaSubscribeGroupByMail.md)
Calling this method will enable the current user to receive email notifications for this group, about new posts, events, and files in that group.
Supported for Microsoft 365 groups only.

### [Invoke-MgBetaUnfollowGroupDriveItem](Invoke-MgBetaUnfollowGroupDriveItem.md)
Unfollow a driveItem.

### [Invoke-MgBetaUnfollowGroupDriveRoot](Invoke-MgBetaUnfollowGroupDriveRoot.md)
Unfollow a driveItem.

### [Join-MgBetaGroupDriveListContentTypeWithHubSite](Join-MgBetaGroupDriveListContentTypeWithHubSite.md)
Associate a [content type][contentType] with a list of hub sites.

### [Join-MgBetaGroupSiteContentTypeWithHubSite](Join-MgBetaGroupSiteContentTypeWithHubSite.md)
Associate a [content type][contentType] with a list of hub sites.

### [Join-MgBetaGroupSiteListContentTypeWithHubSite](Join-MgBetaGroupSiteListContentTypeWithHubSite.md)
Associate a [content type][contentType] with a list of hub sites.

### [New-MgBetaGroup](New-MgBetaGroup.md)
Create a new group as specified in the request body.
You can create one of the following groups: This operation returns by default only a subset of the properties for each group.
These default properties are noted in the Properties section.
To get properties that are _not_ returned by default, do a GET operation and specify the properties in a `$select` OData query option.
**Note**: To create a team, first create a group then add a team to it, see create team.

### [New-MgBetaGroupAcceptedSenderByRef](New-MgBetaGroupAcceptedSenderByRef.md)
Create new navigation property ref to acceptedSenders for groups

### [New-MgBetaGroupConversation](New-MgBetaGroupConversation.md)
Create an open extension (openTypeExtension object) and add custom properties in a new or existing instance of a resource.
You can create an open extension in a resource instance and store custom data to it all in the same operation, except for specific resources.
See known limitations of open extensions for more information.
The table in the Permissions section lists the resources that support open extensions.

### [New-MgBetaGroupConversationThread](New-MgBetaGroupConversationThread.md)
Create new navigation property to threads for groups

### [New-MgBetaGroupConversationThreadPostAttachment](New-MgBetaGroupConversationThreadPostAttachment.md)
Create new navigation property to attachments for groups

### [New-MgBetaGroupConversationThreadPostAttachmentUploadSession](New-MgBetaGroupConversationThreadPostAttachmentUploadSession.md)
Create an upload session that allows an app to iteratively upload ranges of a file, so as to attach the file to an Outlook item.
The item can be a message or event.
Use this approach to attach a file if the file size is between 3 MB and 150 MB.
To attach a file that's smaller than 3 MB, do a `POST` operation on the **attachments** navigation property of the Outlook item; see how to do this for a message or for an event.
As part of the response, this action returns an upload URL that you can use in subsequent sequential `PUT` queries.
Request headers for each `PUT` operation let you specify the exact range of bytes to be uploaded.
This allows transfer to be resumed, in case the network connection is dropped during upload.
The following are the steps to attach a file to an Outlook item using an upload session: See attach large files to Outlook messages or events for an example.

### [New-MgBetaGroupConversationThreadPostExtension](New-MgBetaGroupConversationThreadPostExtension.md)
Create new navigation property to extensions for groups

### [New-MgBetaGroupConversationThreadPostInReplyToAttachment](New-MgBetaGroupConversationThreadPostInReplyToAttachment.md)
Create new navigation property to attachments for groups

### [New-MgBetaGroupConversationThreadPostInReplyToAttachmentUploadSession](New-MgBetaGroupConversationThreadPostInReplyToAttachmentUploadSession.md)
Create an upload session that allows an app to iteratively upload ranges of a file, so as to attach the file to an Outlook item.
The item can be a message or event.
Use this approach to attach a file if the file size is between 3 MB and 150 MB.
To attach a file that's smaller than 3 MB, do a `POST` operation on the **attachments** navigation property of the Outlook item; see how to do this for a message or for an event.
As part of the response, this action returns an upload URL that you can use in subsequent sequential `PUT` queries.
Request headers for each `PUT` operation let you specify the exact range of bytes to be uploaded.
This allows transfer to be resumed, in case the network connection is dropped during upload.
The following are the steps to attach a file to an Outlook item using an upload session: See attach large files to Outlook messages or events for an example.

### [New-MgBetaGroupConversationThreadPostInReplyToExtension](New-MgBetaGroupConversationThreadPostInReplyToExtension.md)
Create new navigation property to extensions for groups

### [New-MgBetaGroupConversationThreadPostInReplyToMention](New-MgBetaGroupConversationThreadPostInReplyToMention.md)
Create new navigation property to mentions for groups

### [New-MgBetaGroupConversationThreadPostInReplyToMultiValueExtendedProperty](New-MgBetaGroupConversationThreadPostInReplyToMultiValueExtendedProperty.md)
Create new navigation property to multiValueExtendedProperties for groups

### [New-MgBetaGroupConversationThreadPostInReplyToSingleValueExtendedProperty](New-MgBetaGroupConversationThreadPostInReplyToSingleValueExtendedProperty.md)
Create new navigation property to singleValueExtendedProperties for groups

### [New-MgBetaGroupConversationThreadPostMention](New-MgBetaGroupConversationThreadPostMention.md)
Create new navigation property to mentions for groups

### [New-MgBetaGroupConversationThreadPostMultiValueExtendedProperty](New-MgBetaGroupConversationThreadPostMultiValueExtendedProperty.md)
Create new navigation property to multiValueExtendedProperties for groups

### [New-MgBetaGroupConversationThreadPostSingleValueExtendedProperty](New-MgBetaGroupConversationThreadPostSingleValueExtendedProperty.md)
Create new navigation property to singleValueExtendedProperties for groups

### [New-MgBetaGroupDriveItemLink](New-MgBetaGroupDriveItemLink.md)
You can use **createLink** action to share a driveItem via a sharing link.
The **createLink** action will create a new sharing link if the specified link type doesn't already exist for the calling application.\nIf a sharing link of the specified type already exists for the app, the existing sharing link will be returned.
DriveItem resources inherit sharing permissions from their ancestors.

### [New-MgBetaGroupDriveItemListItemLink](New-MgBetaGroupDriveItemListItemLink.md)
Create a sharing link for a listItem.
The **createLink** action creates a new sharing link if the specified link type doesn't already exist for the calling application.\nIf a sharing link of the specified type already exists for the app, this action will return the existing sharing link.
**listItem** resources inherit sharing permissions from the list the item resides in.

### [New-MgBetaGroupDriveItemUploadSession](New-MgBetaGroupDriveItemUploadSession.md)
Create an upload session to allow your app to upload files up to the maximum file size.
An upload session allows your app to upload ranges of the file in sequential API requests, which allows the transfer to be resumed if a connection is dropped while the upload is in progress.
To upload a file using an upload session:

### [New-MgBetaGroupDriveListItemLink](New-MgBetaGroupDriveListItemLink.md)
Create a sharing link for a listItem.
The **createLink** action creates a new sharing link if the specified link type doesn't already exist for the calling application.\nIf a sharing link of the specified type already exists for the app, this action will return the existing sharing link.
**listItem** resources inherit sharing permissions from the list the item resides in.

### [New-MgBetaGroupDriveRootLink](New-MgBetaGroupDriveRootLink.md)
You can use **createLink** action to share a driveItem via a sharing link.
The **createLink** action will create a new sharing link if the specified link type doesn't already exist for the calling application.\nIf a sharing link of the specified type already exists for the app, the existing sharing link will be returned.
DriveItem resources inherit sharing permissions from their ancestors.

### [New-MgBetaGroupDriveRootListItemLink](New-MgBetaGroupDriveRootListItemLink.md)
Create a sharing link for a listItem.
The **createLink** action creates a new sharing link if the specified link type doesn't already exist for the calling application.\nIf a sharing link of the specified type already exists for the app, this action will return the existing sharing link.
**listItem** resources inherit sharing permissions from the list the item resides in.

### [New-MgBetaGroupDriveRootUploadSession](New-MgBetaGroupDriveRootUploadSession.md)
Create an upload session to allow your app to upload files up to the maximum file size.
An upload session allows your app to upload ranges of the file in sequential API requests, which allows the transfer to be resumed if a connection is dropped while the upload is in progress.
To upload a file using an upload session:

### [New-MgBetaGroupEndpoint](New-MgBetaGroupEndpoint.md)
Create new navigation property to endpoints for groups

### [New-MgBetaGroupExtension](New-MgBetaGroupExtension.md)
Create new navigation property to extensions for groups

### [New-MgBetaGroupLifecyclePolicy](New-MgBetaGroupLifecyclePolicy.md)
Creates a new groupLifecyclePolicy.

### [New-MgBetaGroupMember](New-MgBetaGroupMember.md)
Add a member to an Office 365 group or security group through the members navigation property.

### [New-MgBetaGroupMemberByRef](New-MgBetaGroupMemberByRef.md)
Create new navigation property ref to members for groups

### [New-MgBetaGroupOwner](New-MgBetaGroupOwner.md)
Add an owner to an Office 365 group or security group through the owners navigation property.

### [New-MgBetaGroupOwnerByRef](New-MgBetaGroupOwnerByRef.md)
Create new navigation property ref to owners for groups

### [New-MgBetaGroupPermissionGrant](New-MgBetaGroupPermissionGrant.md)
Create new navigation property to permissionGrants for groups

### [New-MgBetaGroupRejectedSenderByRef](New-MgBetaGroupRejectedSenderByRef.md)
Create new navigation property ref to rejectedSenders for groups

### [New-MgBetaGroupSetting](New-MgBetaGroupSetting.md)
Create a new setting based on the templates available in directorySettingTemplates.
These settings can be at the tenant-level or at the group level.
Group settings apply to only Microsoft 365 groups.
The template named `Group.Unified` can be used to configure tenant-wide Microsoft 365 group settings, while the template named `Group.Unified.Guest` can be used to configure group-specific settings.

### [New-MgBetaGroupSiteListItemLink](New-MgBetaGroupSiteListItemLink.md)
Create a sharing link for a listItem.
The **createLink** action creates a new sharing link if the specified link type doesn't already exist for the calling application.\nIf a sharing link of the specified type already exists for the app, this action will return the existing sharing link.
**listItem** resources inherit sharing permissions from the list the item resides in.

### [New-MgBetaGroupThread](New-MgBetaGroupThread.md)
Start a new group conversation by first creating a thread.
A new conversation, conversation thread, and post are created in the group.
Use reply thread or reply post to further post to that thread.
Note: You can also start a new thread in an existing conversation.

### [New-MgBetaGroupThreadPostAttachment](New-MgBetaGroupThreadPostAttachment.md)
Create new navigation property to attachments for groups

### [New-MgBetaGroupThreadPostAttachmentUploadSession](New-MgBetaGroupThreadPostAttachmentUploadSession.md)
Create an upload session that allows an app to iteratively upload ranges of a file, so as to attach the file to an Outlook item.
The item can be a message or event.
Use this approach to attach a file if the file size is between 3 MB and 150 MB.
To attach a file that's smaller than 3 MB, do a `POST` operation on the **attachments** navigation property of the Outlook item; see how to do this for a message or for an event.
As part of the response, this action returns an upload URL that you can use in subsequent sequential `PUT` queries.
Request headers for each `PUT` operation let you specify the exact range of bytes to be uploaded.
This allows transfer to be resumed, in case the network connection is dropped during upload.
The following are the steps to attach a file to an Outlook item using an upload session: See attach large files to Outlook messages or events for an example.

### [New-MgBetaGroupThreadPostExtension](New-MgBetaGroupThreadPostExtension.md)
Create new navigation property to extensions for groups

### [New-MgBetaGroupThreadPostInReplyToAttachment](New-MgBetaGroupThreadPostInReplyToAttachment.md)
Create new navigation property to attachments for groups

### [New-MgBetaGroupThreadPostInReplyToAttachmentUploadSession](New-MgBetaGroupThreadPostInReplyToAttachmentUploadSession.md)
Create an upload session that allows an app to iteratively upload ranges of a file, so as to attach the file to an Outlook item.
The item can be a message or event.
Use this approach to attach a file if the file size is between 3 MB and 150 MB.
To attach a file that's smaller than 3 MB, do a `POST` operation on the **attachments** navigation property of the Outlook item; see how to do this for a message or for an event.
As part of the response, this action returns an upload URL that you can use in subsequent sequential `PUT` queries.
Request headers for each `PUT` operation let you specify the exact range of bytes to be uploaded.
This allows transfer to be resumed, in case the network connection is dropped during upload.
The following are the steps to attach a file to an Outlook item using an upload session: See attach large files to Outlook messages or events for an example.

### [New-MgBetaGroupThreadPostInReplyToExtension](New-MgBetaGroupThreadPostInReplyToExtension.md)
Create new navigation property to extensions for groups

### [New-MgBetaGroupThreadPostInReplyToMention](New-MgBetaGroupThreadPostInReplyToMention.md)
Create new navigation property to mentions for groups

### [New-MgBetaGroupThreadPostInReplyToMultiValueExtendedProperty](New-MgBetaGroupThreadPostInReplyToMultiValueExtendedProperty.md)
Create new navigation property to multiValueExtendedProperties for groups

### [New-MgBetaGroupThreadPostInReplyToSingleValueExtendedProperty](New-MgBetaGroupThreadPostInReplyToSingleValueExtendedProperty.md)
Create new navigation property to singleValueExtendedProperties for groups

### [New-MgBetaGroupThreadPostMention](New-MgBetaGroupThreadPostMention.md)
Create new navigation property to mentions for groups

### [New-MgBetaGroupThreadPostMultiValueExtendedProperty](New-MgBetaGroupThreadPostMultiValueExtendedProperty.md)
Create new navigation property to multiValueExtendedProperties for groups

### [New-MgBetaGroupThreadPostSingleValueExtendedProperty](New-MgBetaGroupThreadPostSingleValueExtendedProperty.md)
Create new navigation property to singleValueExtendedProperties for groups

### [Publish-MgBetaGroupDriveListContentType](Publish-MgBetaGroupDriveListContentType.md)
Publishes a [contentType][] present in a content type hub site.

### [Publish-MgBetaGroupSiteContentType](Publish-MgBetaGroupSiteContentType.md)
Publishes a [contentType][] present in a content type hub site.

### [Publish-MgBetaGroupSiteListContentType](Publish-MgBetaGroupSiteListContentType.md)
Publishes a [contentType][] present in a content type hub site.

### [Publish-MgBetaGroupSitePage](Publish-MgBetaGroupSitePage.md)
Invoke action publish

### [Remove-MgBetaGroup](Remove-MgBetaGroup.md)
Deletes a group.
When deleted, Microsoft 365 groups are moved to a temporary container and can be restored within 30 days.
After that time, they are permanently deleted.
This isn't applicable to Security groups and Distribution groups which are permanently deleted immediately.
To learn more, see deletedItems.

### [Remove-MgBetaGroupAcceptedSenderByRef](Remove-MgBetaGroupAcceptedSenderByRef.md)
Delete ref of navigation property acceptedSenders for groups

### [Remove-MgBetaGroupConversation](Remove-MgBetaGroupConversation.md)
Delete navigation property conversations for groups

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

### [Remove-MgBetaGroupConversationThreadPostInReplyToMultiValueExtendedProperty](Remove-MgBetaGroupConversationThreadPostInReplyToMultiValueExtendedProperty.md)
Delete navigation property multiValueExtendedProperties for groups

### [Remove-MgBetaGroupConversationThreadPostInReplyToSingleValueExtendedProperty](Remove-MgBetaGroupConversationThreadPostInReplyToSingleValueExtendedProperty.md)
Delete navigation property singleValueExtendedProperties for groups

### [Remove-MgBetaGroupConversationThreadPostMention](Remove-MgBetaGroupConversationThreadPostMention.md)
Delete navigation property mentions for groups

### [Remove-MgBetaGroupConversationThreadPostMultiValueExtendedProperty](Remove-MgBetaGroupConversationThreadPostMultiValueExtendedProperty.md)
Delete navigation property multiValueExtendedProperties for groups

### [Remove-MgBetaGroupConversationThreadPostSingleValueExtendedProperty](Remove-MgBetaGroupConversationThreadPostSingleValueExtendedProperty.md)
Delete navigation property singleValueExtendedProperties for groups

### [Remove-MgBetaGroupEndpoint](Remove-MgBetaGroupEndpoint.md)
Delete navigation property endpoints for groups

### [Remove-MgBetaGroupExtension](Remove-MgBetaGroupExtension.md)
Delete navigation property extensions for groups

### [Remove-MgBetaGroupFavorite](Remove-MgBetaGroupFavorite.md)
Remove the group from the list of the current user's favorite groups.
Supported for Microsoft 365 groups only.

### [Remove-MgBetaGroupFromLifecyclePolicy](Remove-MgBetaGroupFromLifecyclePolicy.md)
Invoke action removeGroup

### [Remove-MgBetaGroupLifecyclePolicy](Remove-MgBetaGroupLifecyclePolicy.md)
Delete a groupLifecyclePolicy.

### [Remove-MgBetaGroupMemberByRef](Remove-MgBetaGroupMemberByRef.md)
Delete ref of navigation property members for groups

### [Remove-MgBetaGroupOwnerByRef](Remove-MgBetaGroupOwnerByRef.md)
Delete ref of navigation property owners for groups

### [Remove-MgBetaGroupPermissionGrant](Remove-MgBetaGroupPermissionGrant.md)
Delete navigation property permissionGrants for groups

### [Remove-MgBetaGroupRejectedSenderByRef](Remove-MgBetaGroupRejectedSenderByRef.md)
Delete ref of navigation property rejectedSenders for groups

### [Remove-MgBetaGroupSetting](Remove-MgBetaGroupSetting.md)
Delete navigation property settings for groups

### [Remove-MgBetaGroupSite](Remove-MgBetaGroupSite.md)
Unfollow a user's site or multiple sites.

### [Remove-MgBetaGroupThread](Remove-MgBetaGroupThread.md)
Delete navigation property threads for groups

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

### [Remove-MgBetaGroupThreadPostInReplyToMultiValueExtendedProperty](Remove-MgBetaGroupThreadPostInReplyToMultiValueExtendedProperty.md)
Delete navigation property multiValueExtendedProperties for groups

### [Remove-MgBetaGroupThreadPostInReplyToSingleValueExtendedProperty](Remove-MgBetaGroupThreadPostInReplyToSingleValueExtendedProperty.md)
Delete navigation property singleValueExtendedProperties for groups

### [Remove-MgBetaGroupThreadPostMention](Remove-MgBetaGroupThreadPostMention.md)
Delete navigation property mentions for groups

### [Remove-MgBetaGroupThreadPostMultiValueExtendedProperty](Remove-MgBetaGroupThreadPostMultiValueExtendedProperty.md)
Delete navigation property multiValueExtendedProperties for groups

### [Remove-MgBetaGroupThreadPostSingleValueExtendedProperty](Remove-MgBetaGroupThreadPostSingleValueExtendedProperty.md)
Delete navigation property singleValueExtendedProperties for groups

### [Reset-MgBetaGroupUnseenCount](Reset-MgBetaGroupUnseenCount.md)
Reset the unseenCount of all the posts that the current user has not seen since their last visit.
Supported for Microsoft 365 groups only.

### [Restore-MgBetaGroupDriveItem](Restore-MgBetaGroupDriveItem.md)
Restore a driveItem that has been deleted and is currently in the recycle bin.

### [Restore-MgBetaGroupDriveItemListItemDocumentSetVersion](Restore-MgBetaGroupDriveItemListItemDocumentSetVersion.md)
Restore a document set version.

### [Restore-MgBetaGroupDriveItemListItemVersion](Restore-MgBetaGroupDriveItemListItemVersion.md)
Invoke action restoreVersion

### [Restore-MgBetaGroupDriveItemVersion](Restore-MgBetaGroupDriveItemVersion.md)
Restore a previous version of a DriveItem to be the current version.
This will create a new version with the contents of the previous version, but preserves all existing versions of the file.

### [Restore-MgBetaGroupDriveListItemDocumentSetVersion](Restore-MgBetaGroupDriveListItemDocumentSetVersion.md)
Restore a document set version.

### [Restore-MgBetaGroupDriveListItemVersion](Restore-MgBetaGroupDriveListItemVersion.md)
Invoke action restoreVersion

### [Restore-MgBetaGroupDriveRoot](Restore-MgBetaGroupDriveRoot.md)
Restore a driveItem that has been deleted and is currently in the recycle bin.

### [Restore-MgBetaGroupDriveRootListItemDocumentSetVersion](Restore-MgBetaGroupDriveRootListItemDocumentSetVersion.md)
Restore a document set version.

### [Restore-MgBetaGroupDriveRootListItemVersion](Restore-MgBetaGroupDriveRootListItemVersion.md)
Invoke action restoreVersion

### [Restore-MgBetaGroupDriveRootVersion](Restore-MgBetaGroupDriveRootVersion.md)
Restore a previous version of a DriveItem to be the current version.
This will create a new version with the contents of the previous version, but preserves all existing versions of the file.

### [Restore-MgBetaGroupSiteListItemDocumentSetVersion](Restore-MgBetaGroupSiteListItemDocumentSetVersion.md)
Restore a document set version.

### [Restore-MgBetaGroupSiteListItemVersion](Restore-MgBetaGroupSiteListItemVersion.md)
Invoke action restoreVersion

### [Revoke-MgBetaGroupDriveItemPermissionGrant](Revoke-MgBetaGroupDriveItemPermissionGrant.md)
Revoke access to a [listItem][] or [driveItem][] granted via a sharing link by removing the specified [recipient][] from the link.

### [Revoke-MgBetaGroupDriveRootPermissionGrant](Revoke-MgBetaGroupDriveRootPermissionGrant.md)
Revoke access to a [listItem][] or [driveItem][] granted via a sharing link by removing the specified [recipient][] from the link.

### [Revoke-MgBetaGroupSitePermissionGrant](Revoke-MgBetaGroupSitePermissionGrant.md)
Revoke access to a [listItem][] or [driveItem][] granted via a sharing link by removing the specified [recipient][] from the link.

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
To learn more about group-based licensing, see What is group-based licensing in Azure Active Directory.
To get the subscriptions available in the directory, perform a GET subscribedSkus request.

### [Set-MgBetaGroupPhotoContent](Set-MgBetaGroupPhotoContent.md)
Update media content for the navigation property photo in groups

### [Stop-MgBetaGroupCalendarEvent](Stop-MgBetaGroupCalendarEvent.md)
This action allows the organizer of a meeting to send a cancellation message and cancel the event.
The action moves the event to the Deleted Items folder.
The organizer can also cancel an occurrence of a recurring meeting \nby providing the occurrence event ID.
An attendee calling this action gets an error (HTTP 400 Bad Request), with the following\nerror message: 'Your request can't be completed.
You need to be an organizer to cancel a meeting.' This action differs from Delete in that **Cancel** is available to only the organizer, and lets\nthe organizer send a custom message to the attendees about the cancellation.

### [Stop-MgBetaGroupEvent](Stop-MgBetaGroupEvent.md)
This action allows the organizer of a meeting to send a cancellation message and cancel the event.
The action moves the event to the Deleted Items folder.
The organizer can also cancel an occurrence of a recurring meeting \nby providing the occurrence event ID.
An attendee calling this action gets an error (HTTP 400 Bad Request), with the following\nerror message: 'Your request can't be completed.
You need to be an organizer to cancel a meeting.' This action differs from Delete in that **Cancel** is available to only the organizer, and lets\nthe organizer send a custom message to the attendees about the cancellation.

### [Test-MgBetaGroupDriveItemPermission](Test-MgBetaGroupDriveItemPermission.md)
Invoke action validatePermission

### [Test-MgBetaGroupDriveListContentTypePublished](Test-MgBetaGroupDriveListContentTypePublished.md)
Invoke function isPublished

### [Test-MgBetaGroupDriveRootPermission](Test-MgBetaGroupDriveRootPermission.md)
Invoke action validatePermission

### [Test-MgBetaGroupDynamicMembership](Test-MgBetaGroupDynamicMembership.md)
Evaluate whether a user or device is or would be a member of a dynamic group.
The membership rule is returned along with other details that were used in the evaluation.
You can complete this operation in the following ways:

### [Test-MgBetaGroupDynamicMembershipRule](Test-MgBetaGroupDynamicMembershipRule.md)
Evaluate whether a user or device is or would be a member of a dynamic group.
The membership rule is returned along with other details that were used in the evaluation.
You can complete this operation in the following ways:

### [Test-MgBetaGroupPermissionGrantProperty](Test-MgBetaGroupPermissionGrantProperty.md)
Validate that a Microsoft 365 group's display name or mail nickname complies with naming policies.
Clients can use this API to determine whether a display name or mail nickname is valid before trying to **create** a Microsoft 365 group.
For validating properties of an existing group, use the validateProperties function for groups.
The following validations are performed for the display name and mail nickname properties: \n1.
Validate the prefix and suffix naming policy\n2.
Validate the custom banned words policy\n3.
Validate the mail nickname is unique This API returns with the first failure encountered.
If one or more properties fail multiple validations, only the property with the first validation failure is returned.
However, you can validate both the mail nickname and the display name and receive a collection of validation errors if you are only validating the prefix and suffix naming policy.

### [Test-MgBetaGroupProperty](Test-MgBetaGroupProperty.md)
Validate if a Microsoft 365 group's display name or mail nickname complies with naming policies.
Clients can use the API to determine if a display name or mail nickname is valid before trying to **update** a Microsoft 365 group.
For validating properties before creating a group, use the validateProperties function for directory objects.
The following validations are performed for the display name and mail nickname properties: This API returns with the first failure encountered.
If one or more properties fail multiple validations, only the property with the first validation failure is returned.
However, you can validate both the mail nickname and the display name and receive a collection of validation errors if you are only validating the prefix and suffix naming policy.

### [Test-MgBetaGroupSiteContentTypePublished](Test-MgBetaGroupSiteContentTypePublished.md)
Invoke function isPublished

### [Test-MgBetaGroupSiteListContentTypePublished](Test-MgBetaGroupSiteListContentTypePublished.md)
Invoke function isPublished

### [Unpublish-MgBetaGroupDriveListContentType](Unpublish-MgBetaGroupDriveListContentType.md)
Unpublish a [contentType][] from a content type hub site.

### [Unpublish-MgBetaGroupSiteContentType](Unpublish-MgBetaGroupSiteContentType.md)
Unpublish a [contentType][] from a content type hub site.

### [Unpublish-MgBetaGroupSiteListContentType](Unpublish-MgBetaGroupSiteListContentType.md)
Unpublish a [contentType][] from a content type hub site.

### [Update-MgBetaGroup](Update-MgBetaGroup.md)
Update the properties of a group object.

### [Update-MgBetaGroupConversationThread](Update-MgBetaGroupConversationThread.md)
Update the navigation property threads in groups

### [Update-MgBetaGroupConversationThreadPost](Update-MgBetaGroupConversationThreadPost.md)
Update the navigation property posts in groups

### [Update-MgBetaGroupConversationThreadPostExtension](Update-MgBetaGroupConversationThreadPostExtension.md)
Update the navigation property extensions in groups

### [Update-MgBetaGroupConversationThreadPostInReplyToExtension](Update-MgBetaGroupConversationThreadPostInReplyToExtension.md)
Update the navigation property extensions in groups

### [Update-MgBetaGroupConversationThreadPostInReplyToMultiValueExtendedProperty](Update-MgBetaGroupConversationThreadPostInReplyToMultiValueExtendedProperty.md)
Update the navigation property multiValueExtendedProperties in groups

### [Update-MgBetaGroupConversationThreadPostInReplyToSingleValueExtendedProperty](Update-MgBetaGroupConversationThreadPostInReplyToSingleValueExtendedProperty.md)
Update the navigation property singleValueExtendedProperties in groups

### [Update-MgBetaGroupConversationThreadPostMultiValueExtendedProperty](Update-MgBetaGroupConversationThreadPostMultiValueExtendedProperty.md)
Update the navigation property multiValueExtendedProperties in groups

### [Update-MgBetaGroupConversationThreadPostSingleValueExtendedProperty](Update-MgBetaGroupConversationThreadPostSingleValueExtendedProperty.md)
Update the navigation property singleValueExtendedProperties in groups

### [Update-MgBetaGroupEndpoint](Update-MgBetaGroupEndpoint.md)
Update the navigation property endpoints in groups

### [Update-MgBetaGroupExtension](Update-MgBetaGroupExtension.md)
Update the navigation property extensions in groups

### [Update-MgBetaGroupLifecyclePolicy](Update-MgBetaGroupLifecyclePolicy.md)
Update the properties of a groupLifecyclePolicygroupLifecyclePolicy resource type object.

### [Update-MgBetaGroupOnenotePageContent](Update-MgBetaGroupOnenotePageContent.md)
Invoke action onenotePatchContent

### [Update-MgBetaGroupPermissionGrant](Update-MgBetaGroupPermissionGrant.md)
Update the navigation property permissionGrants in groups

### [Update-MgBetaGroupPhoto](Update-MgBetaGroupPhoto.md)
Update the navigation property photo in groups

### [Update-MgBetaGroupSetting](Update-MgBetaGroupSetting.md)
Update the navigation property settings in groups

### [Update-MgBetaGroupThread](Update-MgBetaGroupThread.md)
Update the navigation property threads in groups

### [Update-MgBetaGroupThreadPost](Update-MgBetaGroupThreadPost.md)
Update the navigation property posts in groups

### [Update-MgBetaGroupThreadPostExtension](Update-MgBetaGroupThreadPostExtension.md)
Update the navigation property extensions in groups

### [Update-MgBetaGroupThreadPostInReplyToExtension](Update-MgBetaGroupThreadPostInReplyToExtension.md)
Update the navigation property extensions in groups

### [Update-MgBetaGroupThreadPostInReplyToMultiValueExtendedProperty](Update-MgBetaGroupThreadPostInReplyToMultiValueExtendedProperty.md)
Update the navigation property multiValueExtendedProperties in groups

### [Update-MgBetaGroupThreadPostInReplyToSingleValueExtendedProperty](Update-MgBetaGroupThreadPostInReplyToSingleValueExtendedProperty.md)
Update the navigation property singleValueExtendedProperties in groups

### [Update-MgBetaGroupThreadPostMultiValueExtendedProperty](Update-MgBetaGroupThreadPostMultiValueExtendedProperty.md)
Update the navigation property multiValueExtendedProperties in groups

### [Update-MgBetaGroupThreadPostSingleValueExtendedProperty](Update-MgBetaGroupThreadPostSingleValueExtendedProperty.md)
Update the navigation property singleValueExtendedProperties in groups

