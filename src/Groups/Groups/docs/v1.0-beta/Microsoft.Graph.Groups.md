---
Module Name: Microsoft.Graph.Groups
Module Guid: c45fa91e-121e-4d52-97be-dbab577d7180
Download Help Link: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.groups
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
For more information, see getCompatibleHubContentTypes and the blog post Syntex Product Updates – August 2021.

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
For more information, see getCompatibleHubContentTypes and the blog post Syntex Product Updates – August 2021.

### [Add-MgGroupSiteListContentTypeCopy](Add-MgGroupSiteListContentTypeCopy.md)
Add a copy of a [content type][contentType] from a [site][site] to a [list][list].

### [Add-MgGroupSiteListContentTypeCopyFromContentTypeHub](Add-MgGroupSiteListContentTypeCopyFromContentTypeHub.md)
Add or sync a copy of a published content type from the content type hub to a target site or a list.
This method is part of the content type publishing changes to optimize the syncing of published content types to sites and lists, effectively switching from a 'push everywhere' to 'pull as needed' approach.
The method allows users to pull content types directly from the content type hub to a site or list.
For more information, see getCompatibleHubContentTypes and the blog post Syntex Product Updates – August 2021.

### [Add-MgGroupToLifecyclePolicy](Add-MgGroupToLifecyclePolicy.md)
Invoke action addGroup

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

### [Copy-MgGroupDriveItem](Copy-MgGroupDriveItem.md)
Asynchronously creates a copy of an [driveItem][item-resource] (including any children), under a new parent item or with a new name.

### [Copy-MgGroupDriveListContentTypeToDefaultContentLocation](Copy-MgGroupDriveListContentTypeToDefaultContentLocation.md)
Copy a file to a default content location in a [content type][contentType].
The file can then be added as a default file or template via a POST operation.

### [Copy-MgGroupDriveRoot](Copy-MgGroupDriveRoot.md)
Asynchronously creates a copy of an [driveItem][item-resource] (including any children), under a new parent item or with a new name.

### [Copy-MgGroupOnenoteNotebook](Copy-MgGroupOnenoteNotebook.md)
Copies a notebook to the Notebooks folder in the destination Documents library.
The folder is created if it doesn't exist.
For Copy operations, you follow an asynchronous calling pattern:  First call the Copy action, and then poll the operation endpoint for the result.

### [Copy-MgGroupOnenotePageToSection](Copy-MgGroupOnenotePageToSection.md)
Copy a page to a specific section.
For copy operations, you follow an asynchronous calling pattern:  First call the Copy action, and then poll the operation endpoint for the result.

### [Copy-MgGroupOnenoteSectionToNotebook](Copy-MgGroupOnenoteSectionToNotebook.md)
Copies a section to a specific notebook.
For Copy operations, you follow an asynchronous calling pattern:  First call the Copy action, and then poll the operation endpoint for the result.

### [Copy-MgGroupOnenoteSectionToSectionGroup](Copy-MgGroupOnenoteSectionToSectionGroup.md)
Copies a section to a specific section group.
For Copy operations, you follow an asynchronous calling pattern:  First call the Copy action, and then poll the operation endpoint for the result.

### [Copy-MgGroupSiteContentTypeToDefaultContentLocation](Copy-MgGroupSiteContentTypeToDefaultContentLocation.md)
Copy a file to a default content location in a [content type][contentType].
The file can then be added as a default file or template via a POST operation.

### [Copy-MgGroupSiteListContentTypeToDefaultContentLocation](Copy-MgGroupSiteListContentTypeToDefaultContentLocation.md)
Copy a file to a default content location in a [content type][contentType].
The file can then be added as a default file or template via a POST operation.

### [Get-MgGroup](Get-MgGroup.md)
Get the properties and relationships of a group object.
This operation returns by default only a subset of all the available properties, as noted in the Properties section.
To get properties that are _not_ returned by default, specify them in a `$select` OData query option.
The **hasMembersWithLicenseErrors** and **isArchived** properties are an exception and are not returned in the `$select` query.
Because the **group** resource supports extensions, you can also use the `GET` operation to get custom properties and extension data in a **group** instance.

### [Get-MgGroupAcceptedSender](Get-MgGroupAcceptedSender.md)
Get a list of users or groups that are in the accepted-senders list for this group.
Users in the accepted senders list can post to conversations of the group (identified in the GET request URL).
Make sure you do not specify the same user or group in the accepted senders and rejected senders lists, otherwise you will get an error.

### [Get-MgGroupAcceptedSenderByRef](Get-MgGroupAcceptedSenderByRef.md)
Get a list of users or groups that are in the accepted-senders list for this group.
Users in the accepted senders list can post to conversations of the group (identified in the GET request URL).
Make sure you do not specify the same user or group in the accepted senders and rejected senders lists, otherwise you will get an error.

### [Get-MgGroupById](Get-MgGroupById.md)
Return the directory objects specified in a list of IDs.
Some common uses for this function are to:

### [Get-MgGroupCalendarEventDelta](Get-MgGroupCalendarEventDelta.md)
Get a set of event resources that have been added, deleted, or updated in one or more calendars.
You can get specific types of these incremental changes in the events in all the calendars of a mailbox or in a specific calendar, or in an event collection of a **calendarView** (range of events defined by start and end dates) of a calendar.
The calendar can be the default calendar or some other specified calendar of the user's.
In the case of getting incremental changes on **calendarView**, the calendar can be a group calendar as well.
Typically, synchronizing events in a calendar or **calendarView** in a local store entails a round of multiple **delta** function calls.
The initial call is a full synchronization, and every subsequent **delta** call in the same round gets the incremental changes (additions, deletions, or updates).
This allows you to maintain and synchronize a local store of events in the specified calendar, without having to fetch all the events of that calendar from the server every time.
The following table lists the differences between the **delta** function on events and the **delta** function on a **calendarView** in a calendar.

### [Get-MgGroupCalendarSchedule](Get-MgGroupCalendarSchedule.md)
Get the free/busy availability information for a collection of users, distributions lists, or resources (rooms or equipment) for a specified time period.

### [Get-MgGroupConversation](Get-MgGroupConversation.md)
The group's conversations.

### [Get-MgGroupConversationThread](Get-MgGroupConversationThread.md)
A collection of all the conversation threads in the conversation.
A navigation property.
Read-only.
Nullable.

### [Get-MgGroupConversationThreadPost](Get-MgGroupConversationThreadPost.md)
Get posts from groups

### [Get-MgGroupConversationThreadPostAttachment](Get-MgGroupConversationThreadPostAttachment.md)
The collection of fileAttachment, itemAttachment, and referenceAttachment attachments for the post.
Read-only.
Nullable.
Supports $expand.

### [Get-MgGroupConversationThreadPostExtension](Get-MgGroupConversationThreadPostExtension.md)
The collection of open extensions defined for the post.
Read-only.
Nullable.
Supports $expand.

### [Get-MgGroupConversationThreadPostInReplyToAttachment](Get-MgGroupConversationThreadPostInReplyToAttachment.md)
The collection of fileAttachment, itemAttachment, and referenceAttachment attachments for the post.
Read-only.
Nullable.
Supports $expand.

### [Get-MgGroupConversationThreadPostInReplyToExtension](Get-MgGroupConversationThreadPostInReplyToExtension.md)
The collection of open extensions defined for the post.
Read-only.
Nullable.
Supports $expand.

### [Get-MgGroupConversationThreadPostInReplyToMention](Get-MgGroupConversationThreadPostInReplyToMention.md)
Get mentions from groups

### [Get-MgGroupConversationThreadPostInReplyToMultiValueExtendedProperty](Get-MgGroupConversationThreadPostInReplyToMultiValueExtendedProperty.md)
The collection of multi-value extended properties defined for the post.
Read-only.
Nullable.

### [Get-MgGroupConversationThreadPostInReplyToSingleValueExtendedProperty](Get-MgGroupConversationThreadPostInReplyToSingleValueExtendedProperty.md)
The collection of single-value extended properties defined for the post.
Read-only.
Nullable.

### [Get-MgGroupConversationThreadPostMention](Get-MgGroupConversationThreadPostMention.md)
Get mentions from groups

### [Get-MgGroupConversationThreadPostMultiValueExtendedProperty](Get-MgGroupConversationThreadPostMultiValueExtendedProperty.md)
The collection of multi-value extended properties defined for the post.
Read-only.
Nullable.

### [Get-MgGroupConversationThreadPostSingleValueExtendedProperty](Get-MgGroupConversationThreadPostSingleValueExtendedProperty.md)
The collection of single-value extended properties defined for the post.
Read-only.
Nullable.

### [Get-MgGroupCreatedOnBehalfOf](Get-MgGroupCreatedOnBehalfOf.md)
The user (or application) that created the group.
Note: This is not set if the user is an administrator.
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

### [Get-MgGroupDriveListItemDelta](Get-MgGroupDriveListItemDelta.md)
Invoke function delta

### [Get-MgGroupDriveRootActivityByInterval](Get-MgGroupDriveRootActivityByInterval.md)
Invoke function getActivitiesByInterval

### [Get-MgGroupDriveRootDelta](Get-MgGroupDriveRootDelta.md)
Invoke function delta

### [Get-MgGroupDriveRootListItemActivityByInterval](Get-MgGroupDriveRootListItemActivityByInterval.md)
Invoke function getActivitiesByInterval

### [Get-MgGroupEndpoint](Get-MgGroupEndpoint.md)
Endpoints for the group.
Read-only.
Nullable.

### [Get-MgGroupEventDelta](Get-MgGroupEventDelta.md)
Get a set of event resources that have been added, deleted, or updated in one or more calendars.
You can get specific types of these incremental changes in the events in all the calendars of a mailbox or in a specific calendar, or in an event collection of a **calendarView** (range of events defined by start and end dates) of a calendar.
The calendar can be the default calendar or some other specified calendar of the user's.
In the case of getting incremental changes on **calendarView**, the calendar can be a group calendar as well.
Typically, synchronizing events in a calendar or **calendarView** in a local store entails a round of multiple **delta** function calls.
The initial call is a full synchronization, and every subsequent **delta** call in the same round gets the incremental changes (additions, deletions, or updates).
This allows you to maintain and synchronize a local store of events in the specified calendar, without having to fetch all the events of that calendar from the server every time.
The following table lists the differences between the **delta** function on events and the **delta** function on a **calendarView** in a calendar.

### [Get-MgGroupExtension](Get-MgGroupExtension.md)
The collection of open extensions defined for the group.
Read-only.
Nullable.

### [Get-MgGroupLifecyclePolicy](Get-MgGroupLifecyclePolicy.md)
Retrieve the properties and relationships of a groupLifecyclePolicies object.

### [Get-MgGroupLifecyclePolicyByGroup](Get-MgGroupLifecyclePolicyByGroup.md)
Retrieves a list of groupLifecyclePolicy objects to which a group belongs.

### [Get-MgGroupMember](Get-MgGroupMember.md)
Direct members of this group, who can be users, devices, other groups, or service principals.
Supports the List members, Add member, and Remove member operations.
Nullable.
Supports $expand including nested $select.
For example, /groups?$filter=startsWith(displayName,'Role')&$select=id,displayName&$expand=members($select=id,userPrincipalName,displayName).

### [Get-MgGroupMemberByRef](Get-MgGroupMemberByRef.md)
Direct members of this group, who can be users, devices, other groups, or service principals.
Supports the List members, Add member, and Remove member operations.
Nullable.
Supports $expand including nested $select.
For example, /groups?$filter=startsWith(displayName,'Role')&$select=id,displayName&$expand=members($select=id,userPrincipalName,displayName).

### [Get-MgGroupMemberGroup](Get-MgGroupMemberGroup.md)
Return all the group IDs for the groups that the specified user, group, service principal, organizational contact, device, or directory object is a member of.
This function is transitive.

### [Get-MgGroupMemberObject](Get-MgGroupMemberObject.md)
Invoke action getMemberObjects

### [Get-MgGroupMemberOf](Get-MgGroupMemberOf.md)
Groups and administrative units that this group is a member of.
HTTP Methods: GET (supported for all groups).
Read-only.
Nullable.
Supports $expand.

### [Get-MgGroupMemberWithLicenseError](Get-MgGroupMemberWithLicenseError.md)
A list of group members with license errors from this group-based license assignment.
Read-only.

### [Get-MgGroupOnenoteNotebookFromWebUrl](Get-MgGroupOnenoteNotebookFromWebUrl.md)
Retrieve the properties and relationships of a notebook object by using its URL path.
The location can be user notebooks on Microsoft 365, group notebooks, or SharePoint site-hosted team notebooks on Microsoft 365.

### [Get-MgGroupOnenoteRecentNotebook](Get-MgGroupOnenoteRecentNotebook.md)
Invoke function getRecentNotebooks

### [Get-MgGroupOwner](Get-MgGroupOwner.md)
The owners of the group who can be users or service principals.
Nullable.
If this property is not specified when creating a Microsoft 365 group, the calling user is automatically assigned as the group owner.
Supports $expand including nested $select.
For example, /groups?$filter=startsWith(displayName,'Role')&$select=id,displayName&$expand=owners($select=id,userPrincipalName,displayName).

### [Get-MgGroupOwnerByRef](Get-MgGroupOwnerByRef.md)
The owners of the group who can be users or service principals.
Nullable.
If this property is not specified when creating a Microsoft 365 group, the calling user is automatically assigned as the group owner.
Supports $expand including nested $select.
For example, /groups?$filter=startsWith(displayName,'Role')&$select=id,displayName&$expand=owners($select=id,userPrincipalName,displayName).

### [Get-MgGroupPermissionGrant](Get-MgGroupPermissionGrant.md)
The permissions that have been granted for a group to a specific application.
Supports $expand.

### [Get-MgGroupPermissionGrantById](Get-MgGroupPermissionGrantById.md)
Return the directory objects specified in a list of IDs.
Some common uses for this function are to:

### [Get-MgGroupPermissionGrantMemberGroup](Get-MgGroupPermissionGrantMemberGroup.md)
Return all the group IDs for the groups that the specified user, group, service principal, organizational contact, device, or directory object is a member of.
This function is transitive.

### [Get-MgGroupPermissionGrantMemberObject](Get-MgGroupPermissionGrantMemberObject.md)
Invoke action getMemberObjects

### [Get-MgGroupPermissionGrantUserOwnedObject](Get-MgGroupPermissionGrantUserOwnedObject.md)
Invoke action getUserOwnedObjects

### [Get-MgGroupPhoto](Get-MgGroupPhoto.md)
The group's profile photo.

### [Get-MgGroupPhotoContent](Get-MgGroupPhotoContent.md)
Get media content for the navigation property photo from groups

### [Get-MgGroupRejectedSender](Get-MgGroupRejectedSender.md)
Get a list of users or groups that are in the rejected-senders list for this group.
Users in the rejected senders list cannot post to conversations of the group (identified in the GET request URL).
Make sure you do not specify the same user or group in the rejected senders and accepted senders lists, otherwise you will get an error.

### [Get-MgGroupRejectedSenderByRef](Get-MgGroupRejectedSenderByRef.md)
Get a list of users or groups that are in the rejected-senders list for this group.
Users in the rejected senders list cannot post to conversations of the group (identified in the GET request URL).
Make sure you do not specify the same user or group in the rejected senders and accepted senders lists, otherwise you will get an error.

### [Get-MgGroupSetting](Get-MgGroupSetting.md)
Settings that can govern this group's behavior, like whether members can invite guest users to the group.
Nullable.

### [Get-MgGroupSiteActivityByInterval](Get-MgGroupSiteActivityByInterval.md)
Invoke function getActivitiesByInterval

### [Get-MgGroupSiteApplicableContentTypeForList](Get-MgGroupSiteApplicableContentTypeForList.md)
Invoke function getApplicableContentTypesForList

### [Get-MgGroupSiteByPath](Get-MgGroupSiteByPath.md)
Invoke function getByPath

### [Get-MgGroupSiteContentTypeCompatibleHubContentType](Get-MgGroupSiteContentTypeCompatibleHubContentType.md)
Invoke function getCompatibleHubContentTypes

### [Get-MgGroupSiteDelta](Get-MgGroupSiteDelta.md)
Invoke function delta

### [Get-MgGroupSiteListContentTypeCompatibleHubContentType](Get-MgGroupSiteListContentTypeCompatibleHubContentType.md)
Invoke function getCompatibleHubContentTypes

### [Get-MgGroupSiteListItemActivityByInterval](Get-MgGroupSiteListItemActivityByInterval.md)
Invoke function getActivitiesByInterval

### [Get-MgGroupSiteListItemDelta](Get-MgGroupSiteListItemDelta.md)
Invoke function delta

### [Get-MgGroupThread](Get-MgGroupThread.md)
The group's conversation threads.
Nullable.

### [Get-MgGroupThreadPost](Get-MgGroupThreadPost.md)
Get posts from groups

### [Get-MgGroupThreadPostAttachment](Get-MgGroupThreadPostAttachment.md)
The collection of fileAttachment, itemAttachment, and referenceAttachment attachments for the post.
Read-only.
Nullable.
Supports $expand.

### [Get-MgGroupThreadPostExtension](Get-MgGroupThreadPostExtension.md)
The collection of open extensions defined for the post.
Read-only.
Nullable.
Supports $expand.

### [Get-MgGroupThreadPostInReplyToAttachment](Get-MgGroupThreadPostInReplyToAttachment.md)
The collection of fileAttachment, itemAttachment, and referenceAttachment attachments for the post.
Read-only.
Nullable.
Supports $expand.

### [Get-MgGroupThreadPostInReplyToExtension](Get-MgGroupThreadPostInReplyToExtension.md)
The collection of open extensions defined for the post.
Read-only.
Nullable.
Supports $expand.

### [Get-MgGroupThreadPostInReplyToMention](Get-MgGroupThreadPostInReplyToMention.md)
Get mentions from groups

### [Get-MgGroupThreadPostInReplyToMultiValueExtendedProperty](Get-MgGroupThreadPostInReplyToMultiValueExtendedProperty.md)
The collection of multi-value extended properties defined for the post.
Read-only.
Nullable.

### [Get-MgGroupThreadPostInReplyToSingleValueExtendedProperty](Get-MgGroupThreadPostInReplyToSingleValueExtendedProperty.md)
The collection of single-value extended properties defined for the post.
Read-only.
Nullable.

### [Get-MgGroupThreadPostMention](Get-MgGroupThreadPostMention.md)
Get mentions from groups

### [Get-MgGroupThreadPostMultiValueExtendedProperty](Get-MgGroupThreadPostMultiValueExtendedProperty.md)
The collection of multi-value extended properties defined for the post.
Read-only.
Nullable.

### [Get-MgGroupThreadPostSingleValueExtendedProperty](Get-MgGroupThreadPostSingleValueExtendedProperty.md)
The collection of single-value extended properties defined for the post.
Read-only.
Nullable.

### [Get-MgGroupTransitiveMember](Get-MgGroupTransitiveMember.md)
The direct and transitive members of a group.
Nullable.

### [Get-MgGroupTransitiveMemberOf](Get-MgGroupTransitiveMemberOf.md)
The groups that a group is a member of, either directly and through nested membership.
Nullable.

### [Get-MgGroupUserOwnedObject](Get-MgGroupUserOwnedObject.md)
Invoke action getUserOwnedObjects

### [Get-MgUserJoinedGroup](Get-MgUserJoinedGroup.md)
Get joinedGroups from users

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
If the event allows proposals for new times, on responding tentative to the event, an invitee can choose to suggest an alternative time by including the **proposedNewTime** parameter.
For more information on how to propose a time, and how to receive and accept a new time proposal, see Propose new meeting times.

### [Invoke-MgAcceptGroupEvent](Invoke-MgAcceptGroupEvent.md)
Accept the specified event in a user calendar.

### [Invoke-MgAcceptGroupEventTentatively](Invoke-MgAcceptGroupEventTentatively.md)
Tentatively accept the specified event in a user calendar.
If the event allows proposals for new times, on responding tentative to the event, an invitee can choose to suggest an alternative time by including the **proposedNewTime** parameter.
For more information on how to propose a time, and how to receive and accept a new time proposal, see Propose new meeting times.

### [Invoke-MgCalendarGroupCalendar](Invoke-MgCalendarGroupCalendar.md)
Invoke function allowedCalendarSharingRoles

### [Invoke-MgCheckinGroupDriveItem](Invoke-MgCheckinGroupDriveItem.md)
Check in a checked out **driveItem** resource, which makes the version of the document available to others.

### [Invoke-MgCheckinGroupDriveRoot](Invoke-MgCheckinGroupDriveRoot.md)
Check in a checked out **driveItem** resource, which makes the version of the document available to others.

### [Invoke-MgCheckoutGroupDriveItem](Invoke-MgCheckoutGroupDriveItem.md)
Check out a **driveItem** resource to prevent others from editing the document, and prevent your changes from being visible until the documented is checked in.

### [Invoke-MgCheckoutGroupDriveRoot](Invoke-MgCheckoutGroupDriveRoot.md)
Check out a **driveItem** resource to prevent others from editing the document, and prevent your changes from being visible until the documented is checked in.

### [Invoke-MgDeclineGroupCalendarEvent](Invoke-MgDeclineGroupCalendarEvent.md)
Decline invitation to the specified event in a user calendar.
If the event allows proposals for new times, on declining the event, an invitee can choose to suggest an alternative time by including the **proposedNewTime** parameter.
For more information on how to propose a time, and how to receive and accept a new time proposal, see Propose new meeting times.

### [Invoke-MgDeclineGroupEvent](Invoke-MgDeclineGroupEvent.md)
Decline invitation to the specified event in a user calendar.
If the event allows proposals for new times, on declining the event, an invitee can choose to suggest an alternative time by including the **proposedNewTime** parameter.
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
Calling this method will disable the current user to receive email notifications for this group about new posts, events, and files in that group.
Supported for Microsoft 365 groups only.

### [Invoke-MgGraphGroupDrive](Invoke-MgGraphGroupDrive.md)
Invoke function sharedWithMe

### [Invoke-MgInviteGroupDriveItem](Invoke-MgInviteGroupDriveItem.md)
Sends a sharing invitation for a **DriveItem**.\nA sharing invitation provides permissions to the recipients and optionally sends an email to the recipients to notify them the item was shared.

### [Invoke-MgInviteGroupDriveRoot](Invoke-MgInviteGroupDriveRoot.md)
Sends a sharing invitation for a **DriveItem**.\nA sharing invitation provides permissions to the recipients and optionally sends an email to the recipients to notify them the item was shared.

### [Invoke-MgPreviewGroupDriveItem](Invoke-MgPreviewGroupDriveItem.md)
Invoke action preview

### [Invoke-MgPreviewGroupDriveRoot](Invoke-MgPreviewGroupDriveRoot.md)
Invoke action preview

### [Invoke-MgPreviewGroupOnenotePage](Invoke-MgPreviewGroupOnenotePage.md)
Invoke function preview

### [Invoke-MgReauthorizeGroupDriveItemSubscription](Invoke-MgReauthorizeGroupDriveItemSubscription.md)
Invoke action reauthorize

### [Invoke-MgReauthorizeGroupDriveListSubscription](Invoke-MgReauthorizeGroupDriveListSubscription.md)
Invoke action reauthorize

### [Invoke-MgReauthorizeGroupDriveRootSubscription](Invoke-MgReauthorizeGroupDriveRootSubscription.md)
Invoke action reauthorize

### [Invoke-MgReauthorizeGroupSiteListSubscription](Invoke-MgReauthorizeGroupSiteListSubscription.md)
Invoke action reauthorize

### [Invoke-MgRecentGroupDrive](Invoke-MgRecentGroupDrive.md)
Invoke function recent

### [Invoke-MgRenewGroup](Invoke-MgRenewGroup.md)
Renews a group's expiration.
When a group is renewed, the group expiration is extended by the number of days defined in the policy.

### [Invoke-MgRenewGroupLifecyclePolicy](Invoke-MgRenewGroupLifecyclePolicy.md)
Renew a group's expiration.
When a group is renewed, the group expiration is extended by the number of days defined in the policy.

### [Invoke-MgReplyGroupConversationThread](Invoke-MgReplyGroupConversationThread.md)
Add an attachment when creating a group post.
This operation limits the size of the attachment you can add to under 3 MB.
An attachment can be one of the following types: All these types of attachment resources are derived from the attachment\nresource.

### [Invoke-MgReplyGroupConversationThreadPost](Invoke-MgReplyGroupConversationThreadPost.md)
Reply to a post and add a new post to the specified thread in a group conversation.
You can specify both the parent conversation and thread in the request, or, you can specify just the parent thread without the parent conversation.

### [Invoke-MgReplyGroupConversationThreadPostInReplyTo](Invoke-MgReplyGroupConversationThreadPostInReplyTo.md)
Reply to a post and add a new post to the specified thread in a group conversation.
You can specify both the parent conversation and thread in the request, or, you can specify just the parent thread without the parent conversation.

### [Invoke-MgReplyGroupThread](Invoke-MgReplyGroupThread.md)
Add an attachment when creating a group post.
This operation limits the size of the attachment you can add to under 3 MB.
An attachment can be one of the following types: All these types of attachment resources are derived from the attachment\nresource.

### [Invoke-MgReplyGroupThreadPost](Invoke-MgReplyGroupThreadPost.md)
Reply to a post and add a new post to the specified thread in a group conversation.
You can specify both the parent conversation and thread in the request, or, you can specify just the parent thread without the parent conversation.

### [Invoke-MgReplyGroupThreadPostInReplyTo](Invoke-MgReplyGroupThreadPostInReplyTo.md)
Reply to a post and add a new post to the specified thread in a group conversation.
You can specify both the parent conversation and thread in the request, or, you can specify just the parent thread without the parent conversation.

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
Associate a [content type][contentType] with a list of hub sites.

### [Join-MgGroupSiteContentTypeWithHubSite](Join-MgGroupSiteContentTypeWithHubSite.md)
Associate a [content type][contentType] with a list of hub sites.

### [Join-MgGroupSiteListContentTypeWithHubSite](Join-MgGroupSiteListContentTypeWithHubSite.md)
Associate a [content type][contentType] with a list of hub sites.

### [New-MgGroup](New-MgGroup.md)
Create a new group as specified in the request body.
You can create one of the following groups: This operation returns by default only a subset of the properties for each group.
These default properties are noted in the Properties section.
To get properties that are _not_ returned by default, do a GET operation and specify the properties in a `$select` OData query option.
**Note**: To create a team, first create a group then add a team to it, see create team.

### [New-MgGroupAcceptedSenderByRef](New-MgGroupAcceptedSenderByRef.md)
Create new navigation property ref to acceptedSenders for groups

### [New-MgGroupConversation](New-MgGroupConversation.md)
Create an open extension (openTypeExtension object) and add custom properties in a new or existing instance of a resource.
You can create an open extension in a resource instance and store custom data to it all in the same operation, except for specific resources.
See known limitations of open extensions for more information.
The table in the Permissions section lists the resources that support open extensions.

### [New-MgGroupConversationThread](New-MgGroupConversationThread.md)
Create new navigation property to threads for groups

### [New-MgGroupConversationThreadPostAttachment](New-MgGroupConversationThreadPostAttachment.md)
Create new navigation property to attachments for groups

### [New-MgGroupConversationThreadPostAttachmentUploadSession](New-MgGroupConversationThreadPostAttachmentUploadSession.md)
Create an upload session that allows an app to iteratively upload ranges of a file, so as to attach the file to an Outlook item.
The item can be a message or event.
Use this approach to attach a file if the file size is between 3 MB and 150 MB.
To attach a file that's smaller than 3 MB, do a `POST` operation on the **attachments** navigation property of the Outlook item; see how to do this for a message or for an event.
As part of the response, this action returns an upload URL that you can use in subsequent sequential `PUT` queries.
Request headers for each `PUT` operation let you specify the exact range of bytes to be uploaded.
This allows transfer to be resumed, in case the network connection is dropped during upload.
The following are the steps to attach a file to an Outlook item using an upload session: See attach large files to Outlook messages or events for an example.

### [New-MgGroupConversationThreadPostExtension](New-MgGroupConversationThreadPostExtension.md)
Create new navigation property to extensions for groups

### [New-MgGroupConversationThreadPostInReplyToAttachment](New-MgGroupConversationThreadPostInReplyToAttachment.md)
Create new navigation property to attachments for groups

### [New-MgGroupConversationThreadPostInReplyToAttachmentUploadSession](New-MgGroupConversationThreadPostInReplyToAttachmentUploadSession.md)
Create an upload session that allows an app to iteratively upload ranges of a file, so as to attach the file to an Outlook item.
The item can be a message or event.
Use this approach to attach a file if the file size is between 3 MB and 150 MB.
To attach a file that's smaller than 3 MB, do a `POST` operation on the **attachments** navigation property of the Outlook item; see how to do this for a message or for an event.
As part of the response, this action returns an upload URL that you can use in subsequent sequential `PUT` queries.
Request headers for each `PUT` operation let you specify the exact range of bytes to be uploaded.
This allows transfer to be resumed, in case the network connection is dropped during upload.
The following are the steps to attach a file to an Outlook item using an upload session: See attach large files to Outlook messages or events for an example.

### [New-MgGroupConversationThreadPostInReplyToExtension](New-MgGroupConversationThreadPostInReplyToExtension.md)
Create new navigation property to extensions for groups

### [New-MgGroupConversationThreadPostInReplyToMention](New-MgGroupConversationThreadPostInReplyToMention.md)
Create new navigation property to mentions for groups

### [New-MgGroupConversationThreadPostInReplyToMultiValueExtendedProperty](New-MgGroupConversationThreadPostInReplyToMultiValueExtendedProperty.md)
Create new navigation property to multiValueExtendedProperties for groups

### [New-MgGroupConversationThreadPostInReplyToSingleValueExtendedProperty](New-MgGroupConversationThreadPostInReplyToSingleValueExtendedProperty.md)
Create new navigation property to singleValueExtendedProperties for groups

### [New-MgGroupConversationThreadPostMention](New-MgGroupConversationThreadPostMention.md)
Create new navigation property to mentions for groups

### [New-MgGroupConversationThreadPostMultiValueExtendedProperty](New-MgGroupConversationThreadPostMultiValueExtendedProperty.md)
Create new navigation property to multiValueExtendedProperties for groups

### [New-MgGroupConversationThreadPostSingleValueExtendedProperty](New-MgGroupConversationThreadPostSingleValueExtendedProperty.md)
Create new navigation property to singleValueExtendedProperties for groups

### [New-MgGroupDriveItemLink](New-MgGroupDriveItemLink.md)
You can use **createLink** action to share a driveItem via a sharing link.
The **createLink** action will create a new sharing link if the specified link type doesn't already exist for the calling application.\nIf a sharing link of the specified type already exists for the app, the existing sharing link will be returned.
DriveItem resources inherit sharing permissions from their ancestors.

### [New-MgGroupDriveItemListItemLink](New-MgGroupDriveItemListItemLink.md)
Create a sharing link for a listItem.
The **createLink** action creates a new sharing link if the specified link type doesn't already exist for the calling application.\nIf a sharing link of the specified type already exists for the app, this action will return the existing sharing link.
**listItem** resources inherit sharing permissions from the list the item resides in.

### [New-MgGroupDriveItemUploadSession](New-MgGroupDriveItemUploadSession.md)
Create an upload session to allow your app to upload files up to the maximum file size.
An upload session allows your app to upload ranges of the file in sequential API requests, which allows the transfer to be resumed if a connection is dropped while the upload is in progress.
To upload a file using an upload session:

### [New-MgGroupDriveListItemLink](New-MgGroupDriveListItemLink.md)
Create a sharing link for a listItem.
The **createLink** action creates a new sharing link if the specified link type doesn't already exist for the calling application.\nIf a sharing link of the specified type already exists for the app, this action will return the existing sharing link.
**listItem** resources inherit sharing permissions from the list the item resides in.

### [New-MgGroupDriveRootLink](New-MgGroupDriveRootLink.md)
You can use **createLink** action to share a driveItem via a sharing link.
The **createLink** action will create a new sharing link if the specified link type doesn't already exist for the calling application.\nIf a sharing link of the specified type already exists for the app, the existing sharing link will be returned.
DriveItem resources inherit sharing permissions from their ancestors.

### [New-MgGroupDriveRootListItemLink](New-MgGroupDriveRootListItemLink.md)
Create a sharing link for a listItem.
The **createLink** action creates a new sharing link if the specified link type doesn't already exist for the calling application.\nIf a sharing link of the specified type already exists for the app, this action will return the existing sharing link.
**listItem** resources inherit sharing permissions from the list the item resides in.

### [New-MgGroupDriveRootUploadSession](New-MgGroupDriveRootUploadSession.md)
Create an upload session to allow your app to upload files up to the maximum file size.
An upload session allows your app to upload ranges of the file in sequential API requests, which allows the transfer to be resumed if a connection is dropped while the upload is in progress.
To upload a file using an upload session:

### [New-MgGroupEndpoint](New-MgGroupEndpoint.md)
Create new navigation property to endpoints for groups

### [New-MgGroupExtension](New-MgGroupExtension.md)
Create new navigation property to extensions for groups

### [New-MgGroupLifecyclePolicy](New-MgGroupLifecyclePolicy.md)
Creates a new groupLifecyclePolicy.

### [New-MgGroupMember](New-MgGroupMember.md)
Add a member to an Office 365 group or security group through the members navigation property.

### [New-MgGroupMemberByRef](New-MgGroupMemberByRef.md)
Create new navigation property ref to members for groups

### [New-MgGroupOwner](New-MgGroupOwner.md)
Add an owner to an Office 365 group or security group through the owners navigation property.

### [New-MgGroupOwnerByRef](New-MgGroupOwnerByRef.md)
Create new navigation property ref to owners for groups

### [New-MgGroupPermissionGrant](New-MgGroupPermissionGrant.md)
Create new navigation property to permissionGrants for groups

### [New-MgGroupRejectedSenderByRef](New-MgGroupRejectedSenderByRef.md)
Create new navigation property ref to rejectedSenders for groups

### [New-MgGroupSetting](New-MgGroupSetting.md)
Create a new setting based on the templates available in directorySettingTemplates.
These settings can be at the tenant-level or at the group level.
Group settings apply to only Microsoft 365 groups.
The template named `Group.Unified` can be used to configure tenant-wide Microsoft 365 group settings, while the template named `Group.Unified.Guest` can be used to configure group-specific settings.

### [New-MgGroupSiteListItemLink](New-MgGroupSiteListItemLink.md)
Create a sharing link for a listItem.
The **createLink** action creates a new sharing link if the specified link type doesn't already exist for the calling application.\nIf a sharing link of the specified type already exists for the app, this action will return the existing sharing link.
**listItem** resources inherit sharing permissions from the list the item resides in.

### [New-MgGroupThread](New-MgGroupThread.md)
Start a new group conversation by first creating a thread.
A new conversation, conversation thread, and post are created in the group.
Use reply thread or reply post to further post to that thread.
Note: You can also start a new thread in an existing conversation.

### [New-MgGroupThreadPostAttachment](New-MgGroupThreadPostAttachment.md)
Create new navigation property to attachments for groups

### [New-MgGroupThreadPostAttachmentUploadSession](New-MgGroupThreadPostAttachmentUploadSession.md)
Create an upload session that allows an app to iteratively upload ranges of a file, so as to attach the file to an Outlook item.
The item can be a message or event.
Use this approach to attach a file if the file size is between 3 MB and 150 MB.
To attach a file that's smaller than 3 MB, do a `POST` operation on the **attachments** navigation property of the Outlook item; see how to do this for a message or for an event.
As part of the response, this action returns an upload URL that you can use in subsequent sequential `PUT` queries.
Request headers for each `PUT` operation let you specify the exact range of bytes to be uploaded.
This allows transfer to be resumed, in case the network connection is dropped during upload.
The following are the steps to attach a file to an Outlook item using an upload session: See attach large files to Outlook messages or events for an example.

### [New-MgGroupThreadPostExtension](New-MgGroupThreadPostExtension.md)
Create new navigation property to extensions for groups

### [New-MgGroupThreadPostInReplyToAttachment](New-MgGroupThreadPostInReplyToAttachment.md)
Create new navigation property to attachments for groups

### [New-MgGroupThreadPostInReplyToAttachmentUploadSession](New-MgGroupThreadPostInReplyToAttachmentUploadSession.md)
Create an upload session that allows an app to iteratively upload ranges of a file, so as to attach the file to an Outlook item.
The item can be a message or event.
Use this approach to attach a file if the file size is between 3 MB and 150 MB.
To attach a file that's smaller than 3 MB, do a `POST` operation on the **attachments** navigation property of the Outlook item; see how to do this for a message or for an event.
As part of the response, this action returns an upload URL that you can use in subsequent sequential `PUT` queries.
Request headers for each `PUT` operation let you specify the exact range of bytes to be uploaded.
This allows transfer to be resumed, in case the network connection is dropped during upload.
The following are the steps to attach a file to an Outlook item using an upload session: See attach large files to Outlook messages or events for an example.

### [New-MgGroupThreadPostInReplyToExtension](New-MgGroupThreadPostInReplyToExtension.md)
Create new navigation property to extensions for groups

### [New-MgGroupThreadPostInReplyToMention](New-MgGroupThreadPostInReplyToMention.md)
Create new navigation property to mentions for groups

### [New-MgGroupThreadPostInReplyToMultiValueExtendedProperty](New-MgGroupThreadPostInReplyToMultiValueExtendedProperty.md)
Create new navigation property to multiValueExtendedProperties for groups

### [New-MgGroupThreadPostInReplyToSingleValueExtendedProperty](New-MgGroupThreadPostInReplyToSingleValueExtendedProperty.md)
Create new navigation property to singleValueExtendedProperties for groups

### [New-MgGroupThreadPostMention](New-MgGroupThreadPostMention.md)
Create new navigation property to mentions for groups

### [New-MgGroupThreadPostMultiValueExtendedProperty](New-MgGroupThreadPostMultiValueExtendedProperty.md)
Create new navigation property to multiValueExtendedProperties for groups

### [New-MgGroupThreadPostSingleValueExtendedProperty](New-MgGroupThreadPostSingleValueExtendedProperty.md)
Create new navigation property to singleValueExtendedProperties for groups

### [Publish-MgGroupDriveListContentType](Publish-MgGroupDriveListContentType.md)
Publishes a [contentType][] present in a content type hub site.

### [Publish-MgGroupSiteContentType](Publish-MgGroupSiteContentType.md)
Publishes a [contentType][] present in a content type hub site.

### [Publish-MgGroupSiteListContentType](Publish-MgGroupSiteListContentType.md)
Publishes a [contentType][] present in a content type hub site.

### [Publish-MgGroupSitePage](Publish-MgGroupSitePage.md)
Invoke action publish

### [Remove-MgGroup](Remove-MgGroup.md)
Deletes a group.
When deleted, Microsoft 365 groups are moved to a temporary container and can be restored within 30 days.
After that time, they are permanently deleted.
This isn't applicable to Security groups and Distribution groups which are permanently deleted immediately.
To learn more, see deletedItems.

### [Remove-MgGroupAcceptedSenderByRef](Remove-MgGroupAcceptedSenderByRef.md)
Delete ref of navigation property acceptedSenders for groups

### [Remove-MgGroupConversation](Remove-MgGroupConversation.md)
Delete navigation property conversations for groups

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

### [Remove-MgGroupConversationThreadPostInReplyToMention](Remove-MgGroupConversationThreadPostInReplyToMention.md)
Delete navigation property mentions for groups

### [Remove-MgGroupConversationThreadPostInReplyToMultiValueExtendedProperty](Remove-MgGroupConversationThreadPostInReplyToMultiValueExtendedProperty.md)
Delete navigation property multiValueExtendedProperties for groups

### [Remove-MgGroupConversationThreadPostInReplyToSingleValueExtendedProperty](Remove-MgGroupConversationThreadPostInReplyToSingleValueExtendedProperty.md)
Delete navigation property singleValueExtendedProperties for groups

### [Remove-MgGroupConversationThreadPostMention](Remove-MgGroupConversationThreadPostMention.md)
Delete navigation property mentions for groups

### [Remove-MgGroupConversationThreadPostMultiValueExtendedProperty](Remove-MgGroupConversationThreadPostMultiValueExtendedProperty.md)
Delete navigation property multiValueExtendedProperties for groups

### [Remove-MgGroupConversationThreadPostSingleValueExtendedProperty](Remove-MgGroupConversationThreadPostSingleValueExtendedProperty.md)
Delete navigation property singleValueExtendedProperties for groups

### [Remove-MgGroupEndpoint](Remove-MgGroupEndpoint.md)
Delete navigation property endpoints for groups

### [Remove-MgGroupExtension](Remove-MgGroupExtension.md)
Delete navigation property extensions for groups

### [Remove-MgGroupFavorite](Remove-MgGroupFavorite.md)
Remove the group from the list of the current user's favorite groups.
Supported for Microsoft 365 groups only.

### [Remove-MgGroupFromLifecyclePolicy](Remove-MgGroupFromLifecyclePolicy.md)
Invoke action removeGroup

### [Remove-MgGroupLifecyclePolicy](Remove-MgGroupLifecyclePolicy.md)
Delete a groupLifecyclePolicy.

### [Remove-MgGroupMemberByRef](Remove-MgGroupMemberByRef.md)
Delete ref of navigation property members for groups

### [Remove-MgGroupOwnerByRef](Remove-MgGroupOwnerByRef.md)
Delete ref of navigation property owners for groups

### [Remove-MgGroupPermissionGrant](Remove-MgGroupPermissionGrant.md)
Delete navigation property permissionGrants for groups

### [Remove-MgGroupRejectedSenderByRef](Remove-MgGroupRejectedSenderByRef.md)
Delete ref of navigation property rejectedSenders for groups

### [Remove-MgGroupSetting](Remove-MgGroupSetting.md)
Delete navigation property settings for groups

### [Remove-MgGroupSite](Remove-MgGroupSite.md)
Unfollow a user's site or multiple sites.

### [Remove-MgGroupThread](Remove-MgGroupThread.md)
Delete navigation property threads for groups

### [Remove-MgGroupThreadPostAttachment](Remove-MgGroupThreadPostAttachment.md)
Delete navigation property attachments for groups

### [Remove-MgGroupThreadPostExtension](Remove-MgGroupThreadPostExtension.md)
Delete navigation property extensions for groups

### [Remove-MgGroupThreadPostInReplyToAttachment](Remove-MgGroupThreadPostInReplyToAttachment.md)
Delete navigation property attachments for groups

### [Remove-MgGroupThreadPostInReplyToExtension](Remove-MgGroupThreadPostInReplyToExtension.md)
Delete navigation property extensions for groups

### [Remove-MgGroupThreadPostInReplyToMention](Remove-MgGroupThreadPostInReplyToMention.md)
Delete navigation property mentions for groups

### [Remove-MgGroupThreadPostInReplyToMultiValueExtendedProperty](Remove-MgGroupThreadPostInReplyToMultiValueExtendedProperty.md)
Delete navigation property multiValueExtendedProperties for groups

### [Remove-MgGroupThreadPostInReplyToSingleValueExtendedProperty](Remove-MgGroupThreadPostInReplyToSingleValueExtendedProperty.md)
Delete navigation property singleValueExtendedProperties for groups

### [Remove-MgGroupThreadPostMention](Remove-MgGroupThreadPostMention.md)
Delete navigation property mentions for groups

### [Remove-MgGroupThreadPostMultiValueExtendedProperty](Remove-MgGroupThreadPostMultiValueExtendedProperty.md)
Delete navigation property multiValueExtendedProperties for groups

### [Remove-MgGroupThreadPostSingleValueExtendedProperty](Remove-MgGroupThreadPostSingleValueExtendedProperty.md)
Delete navigation property singleValueExtendedProperties for groups

### [Reset-MgGroupUnseenCount](Reset-MgGroupUnseenCount.md)
Reset the unseenCount of all the posts that the current user has not seen since their last visit.
Supported for Microsoft 365 groups only.

### [Restore-MgGroupDriveItem](Restore-MgGroupDriveItem.md)
Restore a driveItem that has been deleted and is currently in the recycle bin.

### [Restore-MgGroupDriveItemListItemDocumentSetVersion](Restore-MgGroupDriveItemListItemDocumentSetVersion.md)
Restore a document set version.

### [Restore-MgGroupDriveItemListItemVersion](Restore-MgGroupDriveItemListItemVersion.md)
Invoke action restoreVersion

### [Restore-MgGroupDriveItemVersion](Restore-MgGroupDriveItemVersion.md)
Restore a previous version of a DriveItem to be the current version.
This will create a new version with the contents of the previous version, but preserves all existing versions of the file.

### [Restore-MgGroupDriveListItemDocumentSetVersion](Restore-MgGroupDriveListItemDocumentSetVersion.md)
Restore a document set version.

### [Restore-MgGroupDriveListItemVersion](Restore-MgGroupDriveListItemVersion.md)
Invoke action restoreVersion

### [Restore-MgGroupDriveRoot](Restore-MgGroupDriveRoot.md)
Restore a driveItem that has been deleted and is currently in the recycle bin.

### [Restore-MgGroupDriveRootListItemDocumentSetVersion](Restore-MgGroupDriveRootListItemDocumentSetVersion.md)
Restore a document set version.

### [Restore-MgGroupDriveRootListItemVersion](Restore-MgGroupDriveRootListItemVersion.md)
Invoke action restoreVersion

### [Restore-MgGroupDriveRootVersion](Restore-MgGroupDriveRootVersion.md)
Restore a previous version of a DriveItem to be the current version.
This will create a new version with the contents of the previous version, but preserves all existing versions of the file.

### [Restore-MgGroupSiteListItemDocumentSetVersion](Restore-MgGroupSiteListItemDocumentSetVersion.md)
Restore a document set version.

### [Restore-MgGroupSiteListItemVersion](Restore-MgGroupSiteListItemVersion.md)
Invoke action restoreVersion

### [Revoke-MgGroupDriveItemPermissionGrant](Revoke-MgGroupDriveItemPermissionGrant.md)
Revoke access to a [listItem][] or [driveItem][] granted via a sharing link by removing the specified [recipient][] from the link.

### [Revoke-MgGroupDriveRootPermissionGrant](Revoke-MgGroupDriveRootPermissionGrant.md)
Revoke access to a [listItem][] or [driveItem][] granted via a sharing link by removing the specified [recipient][] from the link.

### [Revoke-MgGroupSitePermissionGrant](Revoke-MgGroupSitePermissionGrant.md)
Revoke access to a [listItem][] or [driveItem][] granted via a sharing link by removing the specified [recipient][] from the link.

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
You need to be an organizer to cancel a meeting.' This action differs from Delete in that **Cancel** is available to only the organizer, and lets\nthe organizer send a custom message to the attendees about the cancellation.

### [Stop-MgGroupEvent](Stop-MgGroupEvent.md)
This action allows the organizer of a meeting to send a cancellation message and cancel the event.
The action moves the event to the Deleted Items folder.
The organizer can also cancel an occurrence of a recurring meeting \nby providing the occurrence event ID.
An attendee calling this action gets an error (HTTP 400 Bad Request), with the following\nerror message: 'Your request can't be completed.
You need to be an organizer to cancel a meeting.' This action differs from Delete in that **Cancel** is available to only the organizer, and lets\nthe organizer send a custom message to the attendees about the cancellation.

### [Test-MgGroupDriveItemPermission](Test-MgGroupDriveItemPermission.md)
Invoke action validatePermission

### [Test-MgGroupDriveListContentTypePublished](Test-MgGroupDriveListContentTypePublished.md)
Invoke function isPublished

### [Test-MgGroupDriveRootPermission](Test-MgGroupDriveRootPermission.md)
Invoke action validatePermission

### [Test-MgGroupDynamicMembership](Test-MgGroupDynamicMembership.md)
Evaluate whether a user or device is or would be a member of a dynamic group.
The membership rule is returned along with other details that were used in the evaluation.
You can complete this operation in the following ways:

### [Test-MgGroupDynamicMembershipRule](Test-MgGroupDynamicMembershipRule.md)
Evaluate whether a user or device is or would be a member of a dynamic group.
The membership rule is returned along with other details that were used in the evaluation.
You can complete this operation in the following ways:

### [Test-MgGroupPermissionGrantProperty](Test-MgGroupPermissionGrantProperty.md)
Validate that a Microsoft 365 group's display name or mail nickname complies with naming policies.
Clients can use this API to determine whether a display name or mail nickname is valid before trying to **create** a Microsoft 365 group.
For validating properties of an existing group, use the validateProperties function for groups.
The following validations are performed for the display name and mail nickname properties: \n1.
Validate the prefix and suffix naming policy\n2.
Validate the custom banned words policy\n3.
Validate the mail nickname is unique This API returns with the first failure encountered.
If one or more properties fail multiple validations, only the property with the first validation failure is returned.
However, you can validate both the mail nickname and the display name and receive a collection of validation errors if you are only validating the prefix and suffix naming policy.

### [Test-MgGroupProperty](Test-MgGroupProperty.md)
Validate if a Microsoft 365 group's display name or mail nickname complies with naming policies.
Clients can use the API to determine if a display name or mail nickname is valid before trying to **update** a Microsoft 365 group.
For validating properties before creating a group, use the validateProperties function for directory objects.
The following validations are performed for the display name and mail nickname properties: This API returns with the first failure encountered.
If one or more properties fail multiple validations, only the property with the first validation failure is returned.
However, you can validate both the mail nickname and the display name and receive a collection of validation errors if you are only validating the prefix and suffix naming policy.

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
Update the properties of a group object.

### [Update-MgGroupConversationThread](Update-MgGroupConversationThread.md)
Update the navigation property threads in groups

### [Update-MgGroupConversationThreadPost](Update-MgGroupConversationThreadPost.md)
Update the navigation property posts in groups

### [Update-MgGroupConversationThreadPostExtension](Update-MgGroupConversationThreadPostExtension.md)
Update the navigation property extensions in groups

### [Update-MgGroupConversationThreadPostInReplyToExtension](Update-MgGroupConversationThreadPostInReplyToExtension.md)
Update the navigation property extensions in groups

### [Update-MgGroupConversationThreadPostInReplyToMultiValueExtendedProperty](Update-MgGroupConversationThreadPostInReplyToMultiValueExtendedProperty.md)
Update the navigation property multiValueExtendedProperties in groups

### [Update-MgGroupConversationThreadPostInReplyToSingleValueExtendedProperty](Update-MgGroupConversationThreadPostInReplyToSingleValueExtendedProperty.md)
Update the navigation property singleValueExtendedProperties in groups

### [Update-MgGroupConversationThreadPostMultiValueExtendedProperty](Update-MgGroupConversationThreadPostMultiValueExtendedProperty.md)
Update the navigation property multiValueExtendedProperties in groups

### [Update-MgGroupConversationThreadPostSingleValueExtendedProperty](Update-MgGroupConversationThreadPostSingleValueExtendedProperty.md)
Update the navigation property singleValueExtendedProperties in groups

### [Update-MgGroupEndpoint](Update-MgGroupEndpoint.md)
Update the navigation property endpoints in groups

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
Update the navigation property settings in groups

### [Update-MgGroupThread](Update-MgGroupThread.md)
Update the navigation property threads in groups

### [Update-MgGroupThreadPost](Update-MgGroupThreadPost.md)
Update the navigation property posts in groups

### [Update-MgGroupThreadPostExtension](Update-MgGroupThreadPostExtension.md)
Update the navigation property extensions in groups

### [Update-MgGroupThreadPostInReplyToExtension](Update-MgGroupThreadPostInReplyToExtension.md)
Update the navigation property extensions in groups

### [Update-MgGroupThreadPostInReplyToMultiValueExtendedProperty](Update-MgGroupThreadPostInReplyToMultiValueExtendedProperty.md)
Update the navigation property multiValueExtendedProperties in groups

### [Update-MgGroupThreadPostInReplyToSingleValueExtendedProperty](Update-MgGroupThreadPostInReplyToSingleValueExtendedProperty.md)
Update the navigation property singleValueExtendedProperties in groups

### [Update-MgGroupThreadPostMultiValueExtendedProperty](Update-MgGroupThreadPostMultiValueExtendedProperty.md)
Update the navigation property multiValueExtendedProperties in groups

### [Update-MgGroupThreadPostSingleValueExtendedProperty](Update-MgGroupThreadPostSingleValueExtendedProperty.md)
Update the navigation property singleValueExtendedProperties in groups

