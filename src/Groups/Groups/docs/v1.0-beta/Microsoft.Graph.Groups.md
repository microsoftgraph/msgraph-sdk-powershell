---
Module Name: Microsoft.Graph.Groups
Module Guid: b4b1ceb4-aec4-4289-8a65-151503f0fd56
Download Help Link: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.groups
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Groups Module
## Description
Microsoft Graph PowerShell Cmdlets

## Microsoft.Graph.Groups Cmdlets
### [Add-MgGroupFavorite](Add-MgGroupFavorite.md)
Invoke action addFavorite

### [Add-MgGroupToLifecyclePolicy](Add-MgGroupToLifecyclePolicy.md)
Invoke action addGroup

### [Confirm-MgGroupGrantedPermission](Confirm-MgGroupGrantedPermission.md)
Invoke action checkGrantedPermissionsForApp

### [Confirm-MgGroupMemberGroup](Confirm-MgGroupMemberGroup.md)
Invoke action checkMemberGroups

### [Confirm-MgGroupMemberObject](Confirm-MgGroupMemberObject.md)
Invoke action checkMemberObjects

### [Copy-MgGroupOnenoteNotebook](Copy-MgGroupOnenoteNotebook.md)
Invoke action copyNotebook

### [Copy-MgGroupOnenotePageToSection](Copy-MgGroupOnenotePageToSection.md)
Invoke action copyToSection

### [Copy-MgGroupOnenoteSectionToNotebook](Copy-MgGroupOnenoteSectionToNotebook.md)
Invoke action copyToNotebook

### [Copy-MgGroupOnenoteSectionToSectionGroup](Copy-MgGroupOnenoteSectionToSectionGroup.md)
Invoke action copyToSectionGroup

### [Get-MgGroup](Get-MgGroup.md)
Get entity from groups by key

### [Get-MgGroupAcceptedSender](Get-MgGroupAcceptedSender.md)
The list of users or groups that are allowed to create post's or calendar events in this group.
If this list is non-empty then only users or groups listed here are allowed to post.

### [Get-MgGroupAcceptedSenderByRef](Get-MgGroupAcceptedSenderByRef.md)
The list of users or groups that are allowed to create post's or calendar events in this group.
If this list is non-empty then only users or groups listed here are allowed to post.

### [Get-MgGroupById](Get-MgGroupById.md)
Invoke action getByIds

### [Get-MgGroupCalendarEventDelta](Get-MgGroupCalendarEventDelta.md)
Invoke function delta

### [Get-MgGroupCalendarSchedule](Get-MgGroupCalendarSchedule.md)
Invoke action getSchedule

### [Get-MgGroupConversation](Get-MgGroupConversation.md)
The group's conversations.

### [Get-MgGroupConversationThread](Get-MgGroupConversationThread.md)
A collection of all the conversation threads in the conversation.
A navigation property.
Read-only.
Nullable.

### [Get-MgGroupConversationThreadPost](Get-MgGroupConversationThreadPost.md)
Read-only.
Nullable.

### [Get-MgGroupConversationThreadPostAttachment](Get-MgGroupConversationThreadPostAttachment.md)
Read-only.
Nullable.
Supports $expand.

### [Get-MgGroupConversationThreadPostExtension](Get-MgGroupConversationThreadPostExtension.md)
The collection of open extensions defined for the post.
Read-only.
Nullable.
Supports $expand.

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
NOTE: This is not set if the user is an administrator.
Read-only.

### [Get-MgGroupCreatedOnBehalfOfByRef](Get-MgGroupCreatedOnBehalfOfByRef.md)
The user (or application) that created the group.
NOTE: This is not set if the user is an administrator.
Read-only.

### [Get-MgGroupDelta](Get-MgGroupDelta.md)
Invoke function delta

### [Get-MgGroupEndpoint](Get-MgGroupEndpoint.md)
Endpoints for the group.
Read-only.
Nullable.

### [Get-MgGroupEventDelta](Get-MgGroupEventDelta.md)
Invoke function delta

### [Get-MgGroupExtension](Get-MgGroupExtension.md)
The collection of open extensions defined for the group.
Read-only.
Nullable.

### [Get-MgGroupLifecyclePolicy](Get-MgGroupLifecyclePolicy.md)
Get entity from groupLifecyclePolicies by key

### [Get-MgGroupMember](Get-MgGroupMember.md)
UMembers of this group, who can be users, devices, other groups, or service principals.
Supports the List members, Add member, and Remove member operations.
Nullable.
Supports $expand including nested $select.
For example, /groups?$filter=startsWith(displayName,'Role')&$select=id,displayName&$expand=members($select=id,userPrincipalName,displayName).

### [Get-MgGroupMemberByRef](Get-MgGroupMemberByRef.md)
UMembers of this group, who can be users, devices, other groups, or service principals.
Supports the List members, Add member, and Remove member operations.
Nullable.
Supports $expand including nested $select.
For example, /groups?$filter=startsWith(displayName,'Role')&$select=id,displayName&$expand=members($select=id,userPrincipalName,displayName).

### [Get-MgGroupMemberGroup](Get-MgGroupMemberGroup.md)
Invoke action getMemberGroups

### [Get-MgGroupMemberObject](Get-MgGroupMemberObject.md)
Invoke action getMemberObjects

### [Get-MgGroupMemberOf](Get-MgGroupMemberOf.md)
Groups that this group is a member of.
HTTP Methods: GET (supported for all groups).
Read-only.
Nullable.
Supports $expand.

### [Get-MgGroupMemberOfByRef](Get-MgGroupMemberOfByRef.md)
Groups that this group is a member of.
HTTP Methods: GET (supported for all groups).
Read-only.
Nullable.
Supports $expand.

### [Get-MgGroupMemberWithLicenseError](Get-MgGroupMemberWithLicenseError.md)
A list of group members with license errors from this group-based license assignment.
Read-only.

### [Get-MgGroupMemberWithLicenseErrorByRef](Get-MgGroupMemberWithLicenseErrorByRef.md)
A list of group members with license errors from this group-based license assignment.
Read-only.

### [Get-MgGroupOnenoteNotebookFromWebUrl](Get-MgGroupOnenoteNotebookFromWebUrl.md)
Invoke action getNotebookFromWebUrl

### [Get-MgGroupOnenoteRecentNotebook](Get-MgGroupOnenoteRecentNotebook.md)
Invoke function getRecentNotebooks

### [Get-MgGroupOwner](Get-MgGroupOwner.md)
The owners of the group.
Limited to 100 owners.
Nullable.
If this property is not specified when creating a Microsoft 365 group, the calling user is automatically assigned as the group owner.
Supports $expand including nested $select.
For example, /groups?$filter=startsWith(displayName,'Role')&$select=id,displayName&$expand=owners($select=id,userPrincipalName,displayName).

### [Get-MgGroupOwnerByRef](Get-MgGroupOwnerByRef.md)
The owners of the group.
Limited to 100 owners.
Nullable.
If this property is not specified when creating a Microsoft 365 group, the calling user is automatically assigned as the group owner.
Supports $expand including nested $select.
For example, /groups?$filter=startsWith(displayName,'Role')&$select=id,displayName&$expand=owners($select=id,userPrincipalName,displayName).

### [Get-MgGroupPermissionGrant](Get-MgGroupPermissionGrant.md)
The permission that has been granted for a group to a specific application.
Supports $expand.

### [Get-MgGroupPhoto](Get-MgGroupPhoto.md)
The group's profile photo

### [Get-MgGroupPhotoContent](Get-MgGroupPhotoContent.md)
The group's profile photo

### [Get-MgGroupRejectedSender](Get-MgGroupRejectedSender.md)
The list of users or groups that are not allowed to create posts or calendar events in this group.
Nullable

### [Get-MgGroupRejectedSenderByRef](Get-MgGroupRejectedSenderByRef.md)
The list of users or groups that are not allowed to create posts or calendar events in this group.
Nullable

### [Get-MgGroupSetting](Get-MgGroupSetting.md)
Settings that can govern this group's behavior, like whether members can invite guest users to the group.
Nullable.

### [Get-MgGroupThread](Get-MgGroupThread.md)
The group's conversation threads.
Nullable.

### [Get-MgGroupThreadPost](Get-MgGroupThreadPost.md)
Read-only.
Nullable.

### [Get-MgGroupThreadPostAttachment](Get-MgGroupThreadPostAttachment.md)
Read-only.
Nullable.
Supports $expand.

### [Get-MgGroupThreadPostExtension](Get-MgGroupThreadPostExtension.md)
The collection of open extensions defined for the post.
Read-only.
Nullable.
Supports $expand.

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
Get transitiveMembers from groups

### [Get-MgGroupTransitiveMemberByRef](Get-MgGroupTransitiveMemberByRef.md)
Get ref of transitiveMembers from groups

### [Get-MgGroupTransitiveMemberOf](Get-MgGroupTransitiveMemberOf.md)
Get transitiveMemberOf from groups

### [Get-MgGroupTransitiveMemberOfByRef](Get-MgGroupTransitiveMemberOfByRef.md)
Get ref of transitiveMemberOf from groups

### [Get-MgGroupUserOwnedObject](Get-MgGroupUserOwnedObject.md)
Invoke action getUserOwnedObjects

### [Get-MgUserJoinedGroup](Get-MgUserJoinedGroup.md)
Read-only.
Nullable.

### [Invoke-MgAcceptGroupCalendarEvent](Invoke-MgAcceptGroupCalendarEvent.md)
Invoke action accept

### [Invoke-MgAcceptGroupCalendarEventTentatively](Invoke-MgAcceptGroupCalendarEventTentatively.md)
Invoke action tentativelyAccept

### [Invoke-MgAcceptGroupEvent](Invoke-MgAcceptGroupEvent.md)
Invoke action accept

### [Invoke-MgAcceptGroupEventTentatively](Invoke-MgAcceptGroupEventTentatively.md)
Invoke action tentativelyAccept

### [Invoke-MgCalendarGroupCalendar](Invoke-MgCalendarGroupCalendar.md)
Invoke function allowedCalendarSharingRoles

### [Invoke-MgDeclineGroupCalendarEvent](Invoke-MgDeclineGroupCalendarEvent.md)
Invoke action decline

### [Invoke-MgDeclineGroupEvent](Invoke-MgDeclineGroupEvent.md)
Invoke action decline

### [Invoke-MgDismissGroupCalendarEventReminder](Invoke-MgDismissGroupCalendarEventReminder.md)
Invoke action dismissReminder

### [Invoke-MgDismissGroupEventReminder](Invoke-MgDismissGroupEventReminder.md)
Invoke action dismissReminder

### [Invoke-MgForwardGroupCalendarEvent](Invoke-MgForwardGroupCalendarEvent.md)
Invoke action forward

### [Invoke-MgForwardGroupConversationThreadPost](Invoke-MgForwardGroupConversationThreadPost.md)
Invoke action forward

### [Invoke-MgForwardGroupConversationThreadPostInReplyTo](Invoke-MgForwardGroupConversationThreadPostInReplyTo.md)
Invoke action forward

### [Invoke-MgForwardGroupEvent](Invoke-MgForwardGroupEvent.md)
Invoke action forward

### [Invoke-MgForwardGroupThreadPost](Invoke-MgForwardGroupThreadPost.md)
Invoke action forward

### [Invoke-MgForwardGroupThreadPostInReplyTo](Invoke-MgForwardGroupThreadPostInReplyTo.md)
Invoke action forward

### [Invoke-MgPreviewGroupOnenotePage](Invoke-MgPreviewGroupOnenotePage.md)
Invoke function preview

### [Invoke-MgRenewGroup](Invoke-MgRenewGroup.md)
Invoke action renew

### [Invoke-MgRenewGroupLifecyclePolicy](Invoke-MgRenewGroupLifecyclePolicy.md)
Invoke action renewGroup

### [Invoke-MgReplyGroupConversationThread](Invoke-MgReplyGroupConversationThread.md)
Invoke action reply

### [Invoke-MgReplyGroupConversationThreadPost](Invoke-MgReplyGroupConversationThreadPost.md)
Invoke action reply

### [Invoke-MgReplyGroupConversationThreadPostInReplyTo](Invoke-MgReplyGroupConversationThreadPostInReplyTo.md)
Invoke action reply

### [Invoke-MgReplyGroupThread](Invoke-MgReplyGroupThread.md)
Invoke action reply

### [Invoke-MgReplyGroupThreadPost](Invoke-MgReplyGroupThreadPost.md)
Invoke action reply

### [Invoke-MgReplyGroupThreadPostInReplyTo](Invoke-MgReplyGroupThreadPostInReplyTo.md)
Invoke action reply

### [Invoke-MgSnoozeGroupCalendarEventReminder](Invoke-MgSnoozeGroupCalendarEventReminder.md)
Invoke action snoozeReminder

### [Invoke-MgSnoozeGroupEventReminder](Invoke-MgSnoozeGroupEventReminder.md)
Invoke action snoozeReminder

### [Invoke-MgSubscribeGroup](Invoke-MgSubscribeGroup.md)
Invoke action subscribeByMail

### [Invoke-MgUnsubscribeGroup](Invoke-MgUnsubscribeGroup.md)
Invoke action unsubscribeByMail

### [New-MgGroup](New-MgGroup.md)
Add new entity to groups

### [New-MgGroupAcceptedSenderByRef](New-MgGroupAcceptedSenderByRef.md)
The list of users or groups that are allowed to create post's or calendar events in this group.
If this list is non-empty then only users or groups listed here are allowed to post.

### [New-MgGroupConversation](New-MgGroupConversation.md)
The group's conversations.

### [New-MgGroupConversationThread](New-MgGroupConversationThread.md)
A collection of all the conversation threads in the conversation.
A navigation property.
Read-only.
Nullable.

### [New-MgGroupConversationThreadPost](New-MgGroupConversationThreadPost.md)
Read-only.
Nullable.

### [New-MgGroupConversationThreadPostAttachment](New-MgGroupConversationThreadPostAttachment.md)
Read-only.
Nullable.
Supports $expand.

### [New-MgGroupConversationThreadPostAttachmentUploadSession](New-MgGroupConversationThreadPostAttachmentUploadSession.md)
Invoke action createUploadSession

### [New-MgGroupConversationThreadPostExtension](New-MgGroupConversationThreadPostExtension.md)
The collection of open extensions defined for the post.
Read-only.
Nullable.
Supports $expand.

### [New-MgGroupConversationThreadPostMention](New-MgGroupConversationThreadPostMention.md)
Create new navigation property to mentions for groups

### [New-MgGroupConversationThreadPostMultiValueExtendedProperty](New-MgGroupConversationThreadPostMultiValueExtendedProperty.md)
The collection of multi-value extended properties defined for the post.
Read-only.
Nullable.

### [New-MgGroupConversationThreadPostSingleValueExtendedProperty](New-MgGroupConversationThreadPostSingleValueExtendedProperty.md)
The collection of single-value extended properties defined for the post.
Read-only.
Nullable.

### [New-MgGroupEndpoint](New-MgGroupEndpoint.md)
Endpoints for the group.
Read-only.
Nullable.

### [New-MgGroupExtension](New-MgGroupExtension.md)
The collection of open extensions defined for the group.
Read-only.
Nullable.

### [New-MgGroupLifecyclePolicy](New-MgGroupLifecyclePolicy.md)
Add new entity to groupLifecyclePolicies

### [New-MgGroupMember](New-MgGroupMember.md)
Add a member to an Office 365 group or security group through the members navigation property.

### [New-MgGroupMemberByRef](New-MgGroupMemberByRef.md)
UMembers of this group, who can be users, devices, other groups, or service principals.
Supports the List members, Add member, and Remove member operations.
Nullable.
Supports $expand including nested $select.
For example, /groups?$filter=startsWith(displayName,'Role')&$select=id,displayName&$expand=members($select=id,userPrincipalName,displayName).

### [New-MgGroupMemberOfByRef](New-MgGroupMemberOfByRef.md)
Groups that this group is a member of.
HTTP Methods: GET (supported for all groups).
Read-only.
Nullable.
Supports $expand.

### [New-MgGroupMemberWithLicenseErrorByRef](New-MgGroupMemberWithLicenseErrorByRef.md)
A list of group members with license errors from this group-based license assignment.
Read-only.

### [New-MgGroupOwnerByRef](New-MgGroupOwnerByRef.md)
The owners of the group.
Limited to 100 owners.
Nullable.
If this property is not specified when creating a Microsoft 365 group, the calling user is automatically assigned as the group owner.
Supports $expand including nested $select.
For example, /groups?$filter=startsWith(displayName,'Role')&$select=id,displayName&$expand=owners($select=id,userPrincipalName,displayName).

### [New-MgGroupPermissionGrant](New-MgGroupPermissionGrant.md)
The permission that has been granted for a group to a specific application.
Supports $expand.

### [New-MgGroupPhoto](New-MgGroupPhoto.md)
The profile photos owned by the group.
Read-only.
Nullable.

### [New-MgGroupRejectedSenderByRef](New-MgGroupRejectedSenderByRef.md)
The list of users or groups that are not allowed to create posts or calendar events in this group.
Nullable

### [New-MgGroupSetting](New-MgGroupSetting.md)
Settings that can govern this group's behavior, like whether members can invite guest users to the group.
Nullable.

### [New-MgGroupThread](New-MgGroupThread.md)
The group's conversation threads.
Nullable.

### [New-MgGroupThreadPost](New-MgGroupThreadPost.md)
Read-only.
Nullable.

### [New-MgGroupThreadPostAttachment](New-MgGroupThreadPostAttachment.md)
Read-only.
Nullable.
Supports $expand.

### [New-MgGroupThreadPostAttachmentUploadSession](New-MgGroupThreadPostAttachmentUploadSession.md)
Invoke action createUploadSession

### [New-MgGroupThreadPostExtension](New-MgGroupThreadPostExtension.md)
The collection of open extensions defined for the post.
Read-only.
Nullable.
Supports $expand.

### [New-MgGroupThreadPostMention](New-MgGroupThreadPostMention.md)
Create new navigation property to mentions for groups

### [New-MgGroupThreadPostMultiValueExtendedProperty](New-MgGroupThreadPostMultiValueExtendedProperty.md)
The collection of multi-value extended properties defined for the post.
Read-only.
Nullable.

### [New-MgGroupThreadPostSingleValueExtendedProperty](New-MgGroupThreadPostSingleValueExtendedProperty.md)
The collection of single-value extended properties defined for the post.
Read-only.
Nullable.

### [New-MgGroupTransitiveMemberByRef](New-MgGroupTransitiveMemberByRef.md)
Create new navigation property ref to transitiveMembers for groups

### [New-MgGroupTransitiveMemberOfByRef](New-MgGroupTransitiveMemberOfByRef.md)
Create new navigation property ref to transitiveMemberOf for groups

### [New-MgUserJoinedGroup](New-MgUserJoinedGroup.md)
Read-only.
Nullable.

### [Remove-MgGroup](Remove-MgGroup.md)
Delete entity from groups

### [Remove-MgGroupConversation](Remove-MgGroupConversation.md)
The group's conversations.

### [Remove-MgGroupConversationThread](Remove-MgGroupConversationThread.md)
A collection of all the conversation threads in the conversation.
A navigation property.
Read-only.
Nullable.

### [Remove-MgGroupConversationThreadPost](Remove-MgGroupConversationThreadPost.md)
Read-only.
Nullable.

### [Remove-MgGroupConversationThreadPostAttachment](Remove-MgGroupConversationThreadPostAttachment.md)
Read-only.
Nullable.
Supports $expand.

### [Remove-MgGroupConversationThreadPostExtension](Remove-MgGroupConversationThreadPostExtension.md)
The collection of open extensions defined for the post.
Read-only.
Nullable.
Supports $expand.

### [Remove-MgGroupConversationThreadPostMention](Remove-MgGroupConversationThreadPostMention.md)
Delete navigation property mentions for groups

### [Remove-MgGroupConversationThreadPostMultiValueExtendedProperty](Remove-MgGroupConversationThreadPostMultiValueExtendedProperty.md)
The collection of multi-value extended properties defined for the post.
Read-only.
Nullable.

### [Remove-MgGroupConversationThreadPostSingleValueExtendedProperty](Remove-MgGroupConversationThreadPostSingleValueExtendedProperty.md)
The collection of single-value extended properties defined for the post.
Read-only.
Nullable.

### [Remove-MgGroupCreatedOnBehalfOfByRef](Remove-MgGroupCreatedOnBehalfOfByRef.md)
The user (or application) that created the group.
NOTE: This is not set if the user is an administrator.
Read-only.

### [Remove-MgGroupEndpoint](Remove-MgGroupEndpoint.md)
Endpoints for the group.
Read-only.
Nullable.

### [Remove-MgGroupExtension](Remove-MgGroupExtension.md)
The collection of open extensions defined for the group.
Read-only.
Nullable.

### [Remove-MgGroupFavorite](Remove-MgGroupFavorite.md)
Invoke action removeFavorite

### [Remove-MgGroupFromLifecyclePolicy](Remove-MgGroupFromLifecyclePolicy.md)
Invoke action removeGroup

### [Remove-MgGroupLifecyclePolicy](Remove-MgGroupLifecyclePolicy.md)
Delete entity from groupLifecyclePolicies

### [Remove-MgGroupPermissionGrant](Remove-MgGroupPermissionGrant.md)
The permission that has been granted for a group to a specific application.
Supports $expand.

### [Remove-MgGroupPhoto](Remove-MgGroupPhoto.md)
The group's profile photo

### [Remove-MgGroupSetting](Remove-MgGroupSetting.md)
Settings that can govern this group's behavior, like whether members can invite guest users to the group.
Nullable.

### [Remove-MgGroupThread](Remove-MgGroupThread.md)
The group's conversation threads.
Nullable.

### [Remove-MgGroupThreadPost](Remove-MgGroupThreadPost.md)
Read-only.
Nullable.

### [Remove-MgGroupThreadPostAttachment](Remove-MgGroupThreadPostAttachment.md)
Read-only.
Nullable.
Supports $expand.

### [Remove-MgGroupThreadPostExtension](Remove-MgGroupThreadPostExtension.md)
The collection of open extensions defined for the post.
Read-only.
Nullable.
Supports $expand.

### [Remove-MgGroupThreadPostMention](Remove-MgGroupThreadPostMention.md)
Delete navigation property mentions for groups

### [Remove-MgGroupThreadPostMultiValueExtendedProperty](Remove-MgGroupThreadPostMultiValueExtendedProperty.md)
The collection of multi-value extended properties defined for the post.
Read-only.
Nullable.

### [Remove-MgGroupThreadPostSingleValueExtendedProperty](Remove-MgGroupThreadPostSingleValueExtendedProperty.md)
The collection of single-value extended properties defined for the post.
Read-only.
Nullable.

### [Remove-MgUserJoinedGroup](Remove-MgUserJoinedGroup.md)
Read-only.
Nullable.

### [Reset-MgGroupUnseenCount](Reset-MgGroupUnseenCount.md)
Invoke action resetUnseenCount

### [Restore-MgGroup](Restore-MgGroup.md)
Invoke action restore

### [Set-MgGroupCreatedOnBehalfOfByRef](Set-MgGroupCreatedOnBehalfOfByRef.md)
The user (or application) that created the group.
NOTE: This is not set if the user is an administrator.
Read-only.

### [Set-MgGroupLicense](Set-MgGroupLicense.md)
Invoke action assignLicense

### [Set-MgGroupPhotoContent](Set-MgGroupPhotoContent.md)
The group's profile photo

### [Stop-MgGroupCalendarEvent](Stop-MgGroupCalendarEvent.md)
Invoke action cancel

### [Stop-MgGroupEvent](Stop-MgGroupEvent.md)
Invoke action cancel

### [Test-MgGroupDynamicMembership](Test-MgGroupDynamicMembership.md)
Invoke action evaluateDynamicMembership

### [Test-MgGroupProperty](Test-MgGroupProperty.md)
Invoke action validateProperties

### [Update-MgGroup](Update-MgGroup.md)
Update entity in groups

### [Update-MgGroupConversation](Update-MgGroupConversation.md)
The group's conversations.

### [Update-MgGroupConversationThread](Update-MgGroupConversationThread.md)
A collection of all the conversation threads in the conversation.
A navigation property.
Read-only.
Nullable.

### [Update-MgGroupConversationThreadPost](Update-MgGroupConversationThreadPost.md)
Read-only.
Nullable.

### [Update-MgGroupConversationThreadPostAttachment](Update-MgGroupConversationThreadPostAttachment.md)
Read-only.
Nullable.
Supports $expand.

### [Update-MgGroupConversationThreadPostExtension](Update-MgGroupConversationThreadPostExtension.md)
The collection of open extensions defined for the post.
Read-only.
Nullable.
Supports $expand.

### [Update-MgGroupConversationThreadPostMention](Update-MgGroupConversationThreadPostMention.md)
Update the navigation property mentions in groups

### [Update-MgGroupConversationThreadPostMultiValueExtendedProperty](Update-MgGroupConversationThreadPostMultiValueExtendedProperty.md)
The collection of multi-value extended properties defined for the post.
Read-only.
Nullable.

### [Update-MgGroupConversationThreadPostSingleValueExtendedProperty](Update-MgGroupConversationThreadPostSingleValueExtendedProperty.md)
The collection of single-value extended properties defined for the post.
Read-only.
Nullable.

### [Update-MgGroupEndpoint](Update-MgGroupEndpoint.md)
Endpoints for the group.
Read-only.
Nullable.

### [Update-MgGroupExtension](Update-MgGroupExtension.md)
The collection of open extensions defined for the group.
Read-only.
Nullable.

### [Update-MgGroupLifecyclePolicy](Update-MgGroupLifecyclePolicy.md)
Update entity in groupLifecyclePolicies

### [Update-MgGroupOnenotePageContent](Update-MgGroupOnenotePageContent.md)
Invoke action onenotePatchContent

### [Update-MgGroupPermissionGrant](Update-MgGroupPermissionGrant.md)
The permission that has been granted for a group to a specific application.
Supports $expand.

### [Update-MgGroupPhoto](Update-MgGroupPhoto.md)
The group's profile photo

### [Update-MgGroupSetting](Update-MgGroupSetting.md)
Settings that can govern this group's behavior, like whether members can invite guest users to the group.
Nullable.

### [Update-MgGroupThread](Update-MgGroupThread.md)
The group's conversation threads.
Nullable.

### [Update-MgGroupThreadPost](Update-MgGroupThreadPost.md)
Read-only.
Nullable.

### [Update-MgGroupThreadPostAttachment](Update-MgGroupThreadPostAttachment.md)
Read-only.
Nullable.
Supports $expand.

### [Update-MgGroupThreadPostExtension](Update-MgGroupThreadPostExtension.md)
The collection of open extensions defined for the post.
Read-only.
Nullable.
Supports $expand.

### [Update-MgGroupThreadPostMention](Update-MgGroupThreadPostMention.md)
Update the navigation property mentions in groups

### [Update-MgGroupThreadPostMultiValueExtendedProperty](Update-MgGroupThreadPostMultiValueExtendedProperty.md)
The collection of multi-value extended properties defined for the post.
Read-only.
Nullable.

### [Update-MgGroupThreadPostSingleValueExtendedProperty](Update-MgGroupThreadPostSingleValueExtendedProperty.md)
The collection of single-value extended properties defined for the post.
Read-only.
Nullable.

### [Update-MgUserJoinedGroup](Update-MgUserJoinedGroup.md)
Read-only.
Nullable.

