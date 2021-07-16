---
Module Name: Microsoft.Graph.Groups
Module Guid: 2b650142-1cc1-498b-b61e-748264ce842b
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
Represents an Azure Active Directory object.
The directoryObject type is the base type for many other directory entity types.

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
The collection of fileAttachment, itemAttachment, and referenceAttachment attachments for the post.
Read-only.
Nullable.

### [Get-MgGroupConversationThreadPostExtension](Get-MgGroupConversationThreadPostExtension.md)
The collection of open extensions defined for the post.
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

### [Get-MgGroupCreatedOnBehalfOfByRef](Get-MgGroupCreatedOnBehalfOfByRef.md)
The user (or application) that created the group.
Note: This is not set if the user is an administrator.
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
Users, contacts, and groups that are members of this group.
HTTP Methods: GET (supported for all groups), POST (supported for security groups and mail-enabled security groups), DELETE (supported only for security groups) Read-only.
Nullable.

### [Get-MgGroupMemberByRef](Get-MgGroupMemberByRef.md)
A list of group members with license errors from this group-based license assignment.
Read-only.

### [Get-MgGroupMemberGroup](Get-MgGroupMemberGroup.md)
Invoke action getMemberGroups

### [Get-MgGroupMemberObject](Get-MgGroupMemberObject.md)
Invoke action getMemberObjects

### [Get-MgGroupMemberOf](Get-MgGroupMemberOf.md)
Groups and administrative units that this group is a member of.
HTTP Methods: GET (supported for all groups).
Read-only.
Nullable.

### [Get-MgGroupMemberOfByRef](Get-MgGroupMemberOfByRef.md)
Users, contacts, and groups that are members of this group.
HTTP Methods: GET (supported for all groups), POST (supported for security groups and mail-enabled security groups), DELETE (supported only for security groups) Read-only.
Nullable.

### [Get-MgGroupMemberWithLicenseError](Get-MgGroupMemberWithLicenseError.md)
A list of group members with license errors from this group-based license assignment.
Read-only.

### [Get-MgGroupMemberWithLicenseErrorByRef](Get-MgGroupMemberWithLicenseErrorByRef.md)
Groups and administrative units that this group is a member of.
HTTP Methods: GET (supported for all groups).
Read-only.
Nullable.

### [Get-MgGroupOnenoteNotebookFromWebUrl](Get-MgGroupOnenoteNotebookFromWebUrl.md)
Invoke action getNotebookFromWebUrl

### [Get-MgGroupOnenoteRecentNotebook](Get-MgGroupOnenoteRecentNotebook.md)
Invoke function getRecentNotebooks

### [Get-MgGroupOwner](Get-MgGroupOwner.md)
The owners of the group.
The owners are a set of non-admin users who are allowed to modify this object.
HTTP Methods: GET (supported for all groups), POST (supported for security groups and mail-enabled security groups), DELETE (supported only for security groups) Read-only.
Nullable.

### [Get-MgGroupOwnerByRef](Get-MgGroupOwnerByRef.md)
The owners of the group.
The owners are a set of non-admin users who are allowed to modify this object.
HTTP Methods: GET (supported for all groups), POST (supported for security groups and mail-enabled security groups), DELETE (supported only for security groups) Read-only.
Nullable.

### [Get-MgGroupPermissionGrant](Get-MgGroupPermissionGrant.md)
The permissions that have been granted for a group to a specific application.

### [Get-MgGroupPhoto](Get-MgGroupPhoto.md)
The group's profile photo.

### [Get-MgGroupPhotoContent](Get-MgGroupPhotoContent.md)
The group's profile photo.

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
The collection of fileAttachment, itemAttachment, and referenceAttachment attachments for the post.
Read-only.
Nullable.

### [Get-MgGroupThreadPostExtension](Get-MgGroupThreadPostExtension.md)
The collection of open extensions defined for the post.
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
The collection of fileAttachment, itemAttachment, and referenceAttachment attachments for the post.
Read-only.
Nullable.

### [New-MgGroupConversationThreadPostAttachmentUploadSession](New-MgGroupConversationThreadPostAttachmentUploadSession.md)
Invoke action createUploadSession

### [New-MgGroupConversationThreadPostExtension](New-MgGroupConversationThreadPostExtension.md)
The collection of open extensions defined for the post.
Read-only.
Nullable.

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
A list of group members with license errors from this group-based license assignment.
Read-only.

### [New-MgGroupMemberOfByRef](New-MgGroupMemberOfByRef.md)
Users, contacts, and groups that are members of this group.
HTTP Methods: GET (supported for all groups), POST (supported for security groups and mail-enabled security groups), DELETE (supported only for security groups) Read-only.
Nullable.

### [New-MgGroupMemberWithLicenseErrorByRef](New-MgGroupMemberWithLicenseErrorByRef.md)
Groups and administrative units that this group is a member of.
HTTP Methods: GET (supported for all groups).
Read-only.
Nullable.

### [New-MgGroupOwnerByRef](New-MgGroupOwnerByRef.md)
The owners of the group.
The owners are a set of non-admin users who are allowed to modify this object.
HTTP Methods: GET (supported for all groups), POST (supported for security groups and mail-enabled security groups), DELETE (supported only for security groups) Read-only.
Nullable.

### [New-MgGroupPermissionGrant](New-MgGroupPermissionGrant.md)
The permissions that have been granted for a group to a specific application.

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
The collection of fileAttachment, itemAttachment, and referenceAttachment attachments for the post.
Read-only.
Nullable.

### [New-MgGroupThreadPostAttachmentUploadSession](New-MgGroupThreadPostAttachmentUploadSession.md)
Invoke action createUploadSession

### [New-MgGroupThreadPostExtension](New-MgGroupThreadPostExtension.md)
The collection of open extensions defined for the post.
Read-only.
Nullable.

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
Create new navigation property ref to transitiveMemberOf for groups

### [New-MgUserJoinedGroup](New-MgUserJoinedGroup.md)
Read-only.
Nullable.

### [Remove-MgGroup](Remove-MgGroup.md)
Represents an Azure Active Directory object.
The directoryObject type is the base type for many other directory entity types.

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
The collection of fileAttachment, itemAttachment, and referenceAttachment attachments for the post.
Read-only.
Nullable.

### [Remove-MgGroupConversationThreadPostExtension](Remove-MgGroupConversationThreadPostExtension.md)
The collection of open extensions defined for the post.
Read-only.
Nullable.

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
Note: This is not set if the user is an administrator.
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
The permissions that have been granted for a group to a specific application.

### [Remove-MgGroupPhoto](Remove-MgGroupPhoto.md)
The group's profile photo.

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
The collection of fileAttachment, itemAttachment, and referenceAttachment attachments for the post.
Read-only.
Nullable.

### [Remove-MgGroupThreadPostExtension](Remove-MgGroupThreadPostExtension.md)
The collection of open extensions defined for the post.
Read-only.
Nullable.

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
Note: This is not set if the user is an administrator.
Read-only.

### [Set-MgGroupLicense](Set-MgGroupLicense.md)
Invoke action assignLicense

### [Set-MgGroupPhotoContent](Set-MgGroupPhotoContent.md)
The group's profile photo.

### [Stop-MgGroupCalendarEvent](Stop-MgGroupCalendarEvent.md)
Invoke action cancel

### [Stop-MgGroupEvent](Stop-MgGroupEvent.md)
Invoke action cancel

### [Test-MgGroupDynamicMembership](Test-MgGroupDynamicMembership.md)
Invoke action evaluateDynamicMembership

### [Test-MgGroupProperty](Test-MgGroupProperty.md)
Invoke action validateProperties

### [Update-MgGroup](Update-MgGroup.md)
Represents an Azure Active Directory object.
The directoryObject type is the base type for many other directory entity types.

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
The collection of fileAttachment, itemAttachment, and referenceAttachment attachments for the post.
Read-only.
Nullable.

### [Update-MgGroupConversationThreadPostExtension](Update-MgGroupConversationThreadPostExtension.md)
The collection of open extensions defined for the post.
Read-only.
Nullable.

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
The permissions that have been granted for a group to a specific application.

### [Update-MgGroupPhoto](Update-MgGroupPhoto.md)
The group's profile photo.

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
The collection of fileAttachment, itemAttachment, and referenceAttachment attachments for the post.
Read-only.
Nullable.

### [Update-MgGroupThreadPostExtension](Update-MgGroupThreadPostExtension.md)
The collection of open extensions defined for the post.
Read-only.
Nullable.

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

