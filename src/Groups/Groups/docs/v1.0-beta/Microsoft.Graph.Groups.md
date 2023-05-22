---
Module Name: Microsoft.Graph.Groups
Module Guid: a3d5ccf9-d04d-4bb6-ab9c-8aa63e968018
Download Help Link: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.groups
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Groups Module
## Description
Microsoft Graph PowerShell Cmdlets

## Microsoft.Graph.Groups Cmdlets
### [Add-MgGroupDriveListContentTypeCopy](Add-MgGroupDriveListContentTypeCopy.md)
Invoke action addCopy

### [Add-MgGroupDriveListContentTypeCopyFromContentTypeHub](Add-MgGroupDriveListContentTypeCopyFromContentTypeHub.md)
Invoke action addCopyFromContentTypeHub

### [Add-MgGroupFavorite](Add-MgGroupFavorite.md)
Invoke action addFavorite

### [Add-MgGroupSite](Add-MgGroupSite.md)
Invoke action add

### [Add-MgGroupSiteContentTypeCopy](Add-MgGroupSiteContentTypeCopy.md)
Invoke action addCopy

### [Add-MgGroupSiteContentTypeCopyFromContentTypeHub](Add-MgGroupSiteContentTypeCopyFromContentTypeHub.md)
Invoke action addCopyFromContentTypeHub

### [Add-MgGroupSiteListContentTypeCopy](Add-MgGroupSiteListContentTypeCopy.md)
Invoke action addCopy

### [Add-MgGroupSiteListContentTypeCopyFromContentTypeHub](Add-MgGroupSiteListContentTypeCopyFromContentTypeHub.md)
Invoke action addCopyFromContentTypeHub

### [Add-MgGroupToLifecyclePolicy](Add-MgGroupToLifecyclePolicy.md)
Invoke action addGroup

### [Confirm-MgGroupGrantedPermissionForApp](Confirm-MgGroupGrantedPermissionForApp.md)
Invoke action checkGrantedPermissionsForApp

### [Confirm-MgGroupMemberGroup](Confirm-MgGroupMemberGroup.md)
Invoke action checkMemberGroups

### [Confirm-MgGroupMemberObject](Confirm-MgGroupMemberObject.md)
Invoke action checkMemberObjects

### [Confirm-MgGroupPermissionGrantMemberGroup](Confirm-MgGroupPermissionGrantMemberGroup.md)
Invoke action checkMemberGroups

### [Confirm-MgGroupPermissionGrantMemberObject](Confirm-MgGroupPermissionGrantMemberObject.md)
Invoke action checkMemberObjects

### [Confirm-MgGroupSiteInformationProtectionSignature](Confirm-MgGroupSiteInformationProtectionSignature.md)
Invoke action verifySignature

### [Copy-MgGroupDriveItem](Copy-MgGroupDriveItem.md)
Invoke action copy

### [Copy-MgGroupDriveListContentTypeToDefaultContentLocation](Copy-MgGroupDriveListContentTypeToDefaultContentLocation.md)
Invoke action copyToDefaultContentLocation

### [Copy-MgGroupDriveRoot](Copy-MgGroupDriveRoot.md)
Invoke action copy

### [Copy-MgGroupOnenoteNotebook](Copy-MgGroupOnenoteNotebook.md)
Invoke action copyNotebook

### [Copy-MgGroupOnenotePageToSection](Copy-MgGroupOnenotePageToSection.md)
Invoke action copyToSection

### [Copy-MgGroupOnenoteSectionToNotebook](Copy-MgGroupOnenoteSectionToNotebook.md)
Invoke action copyToNotebook

### [Copy-MgGroupOnenoteSectionToSectionGroup](Copy-MgGroupOnenoteSectionToSectionGroup.md)
Invoke action copyToSectionGroup

### [Copy-MgGroupSiteContentTypeToDefaultContentLocation](Copy-MgGroupSiteContentTypeToDefaultContentLocation.md)
Invoke action copyToDefaultContentLocation

### [Copy-MgGroupSiteListContentTypeToDefaultContentLocation](Copy-MgGroupSiteListContentTypeToDefaultContentLocation.md)
Invoke action copyToDefaultContentLocation

### [Get-MgGroup](Get-MgGroup.md)
Get the properties and relationships of a group object.
This operation returns by default only a subset of all the available properties, as noted in the Properties section.
To get properties that are _not_ returned by default, specify them in a `$select` OData query option.
The **hasMembersWithLicenseErrors** and **isArchived** properties are an exception and are not returned in the `$select` query.
Because the **group** resource supports extensions, you can also use the `GET` operation to get custom properties and extension data in a **group** instance.

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
Invoke function delta

### [Get-MgGroupExtension](Get-MgGroupExtension.md)
The collection of open extensions defined for the group.
Read-only.
Nullable.

### [Get-MgGroupLifecyclePolicy](Get-MgGroupLifecyclePolicy.md)
Retrieve the properties and relationships of a groupLifecyclePolicies object.

### [Get-MgGroupLifecyclePolicyByGroup](Get-MgGroupLifecyclePolicyByGroup.md)
The collection of lifecycle policies for this group.
Read-only.
Nullable.

### [Get-MgGroupMember](Get-MgGroupMember.md)
Direct members of this group, who can be users, devices, other groups, or service principals.
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
Direct members of this group, who can be users, devices, other groups, or service principals.
Supports the List members, Add member, and Remove member operations.
Nullable.
Supports $expand including nested $select.
For example, /groups?$filter=startsWith(displayName,'Role')&$select=id,displayName&$expand=members($select=id,userPrincipalName,displayName).

### [Get-MgGroupMemberGroup](Get-MgGroupMemberGroup.md)
Invoke action getMemberGroups

### [Get-MgGroupMemberObject](Get-MgGroupMemberObject.md)
Invoke action getMemberObjects

### [Get-MgGroupMemberOf](Get-MgGroupMemberOf.md)
Groups and administrative units that this group is a member of.
HTTP Methods: GET (supported for all groups).
Read-only.
Nullable.
Supports $expand.

### [Get-MgGroupMemberOfAsAdministrativeUnit](Get-MgGroupMemberOfAsAdministrativeUnit.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.administrativeUnit

### [Get-MgGroupMemberOfAsGroup](Get-MgGroupMemberOfAsGroup.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.group

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

### [Get-MgGroupOnenoteNotebookFromWebUrl](Get-MgGroupOnenoteNotebookFromWebUrl.md)
Invoke action getNotebookFromWebUrl

### [Get-MgGroupOnenoteRecentNotebook](Get-MgGroupOnenoteRecentNotebook.md)
Invoke function getRecentNotebooks

### [Get-MgGroupOwner](Get-MgGroupOwner.md)
The owners of the group who can be users or service principals.
Nullable.
If this property is not specified when creating a Microsoft 365 group, the calling user is automatically assigned as the group owner.
Supports $filter (/$count eq 0, /$count ne 0, /$count eq 1, /$count ne 1); Supports $expand including nested $select.
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
The owners of the group who can be users or service principals.
Nullable.
If this property is not specified when creating a Microsoft 365 group, the calling user is automatically assigned as the group owner.
Supports $filter (/$count eq 0, /$count ne 0, /$count eq 1, /$count ne 1); Supports $expand including nested $select.
For example, /groups?$filter=startsWith(displayName,'Role')&$select=id,displayName&$expand=owners($select=id,userPrincipalName,displayName).

### [Get-MgGroupPermissionGrant](Get-MgGroupPermissionGrant.md)
The permissions that have been granted for a group to a specific application.
Supports $expand.

### [Get-MgGroupPermissionGrantById](Get-MgGroupPermissionGrantById.md)
Invoke action getByIds

### [Get-MgGroupPermissionGrantDelta](Get-MgGroupPermissionGrantDelta.md)
Invoke function delta

### [Get-MgGroupPermissionGrantMemberGroup](Get-MgGroupPermissionGrantMemberGroup.md)
Invoke action getMemberGroups

### [Get-MgGroupPermissionGrantMemberObject](Get-MgGroupPermissionGrantMemberObject.md)
Invoke action getMemberObjects

### [Get-MgGroupPermissionGrantUserOwnedObject](Get-MgGroupPermissionGrantUserOwnedObject.md)
Invoke action getUserOwnedObjects

### [Get-MgGroupPhoto](Get-MgGroupPhoto.md)
The group's profile photo.

### [Get-MgGroupPhotoContent](Get-MgGroupPhotoContent.md)
Get media content for the navigation property photo from groups

### [Get-MgGroupPlannerPlanBucketDelta](Get-MgGroupPlannerPlanBucketDelta.md)
Invoke function delta

### [Get-MgGroupPlannerPlanBucketTaskDelta](Get-MgGroupPlannerPlanBucketTaskDelta.md)
Invoke function delta

### [Get-MgGroupPlannerPlanDelta](Get-MgGroupPlannerPlanDelta.md)
Invoke function delta

### [Get-MgGroupPlannerPlanTaskDelta](Get-MgGroupPlannerPlanTaskDelta.md)
Invoke function delta

### [Get-MgGroupRejectedSender](Get-MgGroupRejectedSender.md)
The list of users or groups that are not allowed to create posts or calendar events in this group.
Nullable

### [Get-MgGroupRejectedSenderByRef](Get-MgGroupRejectedSenderByRef.md)
The list of users or groups that are not allowed to create posts or calendar events in this group.
Nullable

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

### [Get-MgGroupSitePageCanvaLayoutHorizontalSectionColumnWebpartPositionOfWebPart](Get-MgGroupSitePageCanvaLayoutHorizontalSectionColumnWebpartPositionOfWebPart.md)
Invoke action getPositionOfWebPart

### [Get-MgGroupSitePageCanvaLayoutVerticalSectionWebpartPositionOfWebPart](Get-MgGroupSitePageCanvaLayoutVerticalSectionWebpartPositionOfWebPart.md)
Invoke action getPositionOfWebPart

### [Get-MgGroupSitePageWebPartByPosition](Get-MgGroupSitePageWebPartByPosition.md)
Invoke action getWebPartsByPosition

### [Get-MgGroupSitePageWebPartPositionOfWebPart](Get-MgGroupSitePageWebPartPositionOfWebPart.md)
Invoke action getPositionOfWebPart

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

### [Get-MgGroupTransitiveMemberOf](Get-MgGroupTransitiveMemberOf.md)
The groups that a group is a member of, either directly and through nested membership.
Nullable.

### [Get-MgGroupTransitiveMemberOfAsAdministrativeUnit](Get-MgGroupTransitiveMemberOfAsAdministrativeUnit.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.administrativeUnit

### [Get-MgGroupTransitiveMemberOfAsGroup](Get-MgGroupTransitiveMemberOfAsGroup.md)
Get the item of type microsoft.graph.directoryObject as microsoft.graph.group

### [Get-MgGroupUserOwnedObject](Get-MgGroupUserOwnedObject.md)
Invoke action getUserOwnedObjects

### [Get-MgUserJoinedGroup](Get-MgUserJoinedGroup.md)
Get joinedGroups from users

### [Grant-MgGroupDriveItemPermission](Grant-MgGroupDriveItemPermission.md)
Invoke action grant

### [Grant-MgGroupDriveRootPermission](Grant-MgGroupDriveRootPermission.md)
Invoke action grant

### [Grant-MgGroupSitePermission](Grant-MgGroupSitePermission.md)
Invoke action grant

### [Invoke-MgAcceptGroupCalendarEvent](Invoke-MgAcceptGroupCalendarEvent.md)
Invoke action accept

### [Invoke-MgAcceptGroupCalendarEventTentatively](Invoke-MgAcceptGroupCalendarEventTentatively.md)
Invoke action tentativelyAccept

### [Invoke-MgAcceptGroupEvent](Invoke-MgAcceptGroupEvent.md)
Invoke action accept

### [Invoke-MgAcceptGroupEventTentatively](Invoke-MgAcceptGroupEventTentatively.md)
Invoke action tentativelyAccept

### [Invoke-MgBufferGroupSiteInformationProtectionDecrypt](Invoke-MgBufferGroupSiteInformationProtectionDecrypt.md)
Invoke action decryptBuffer

### [Invoke-MgBufferGroupSiteInformationProtectionEncrypt](Invoke-MgBufferGroupSiteInformationProtectionEncrypt.md)
Invoke action encryptBuffer

### [Invoke-MgCalendarGroupCalendar](Invoke-MgCalendarGroupCalendar.md)
Invoke function allowedCalendarSharingRoles

### [Invoke-MgCheckinGroupDriveItem](Invoke-MgCheckinGroupDriveItem.md)
Invoke action checkin

### [Invoke-MgCheckinGroupDriveRoot](Invoke-MgCheckinGroupDriveRoot.md)
Invoke action checkin

### [Invoke-MgCheckoutGroupDriveItem](Invoke-MgCheckoutGroupDriveItem.md)
Invoke action checkout

### [Invoke-MgCheckoutGroupDriveRoot](Invoke-MgCheckoutGroupDriveRoot.md)
Invoke action checkout

### [Invoke-MgDeclineGroupCalendarEvent](Invoke-MgDeclineGroupCalendarEvent.md)
Invoke action decline

### [Invoke-MgDeclineGroupEvent](Invoke-MgDeclineGroupEvent.md)
Invoke action decline

### [Invoke-MgDismissGroupCalendarEventReminder](Invoke-MgDismissGroupCalendarEventReminder.md)
Invoke action dismissReminder

### [Invoke-MgDismissGroupEventReminder](Invoke-MgDismissGroupEventReminder.md)
Invoke action dismissReminder

### [Invoke-MgExtractGroupDriveItemSensitivityLabel](Invoke-MgExtractGroupDriveItemSensitivityLabel.md)
Invoke action extractSensitivityLabels

### [Invoke-MgExtractGroupDriveRootSensitivityLabel](Invoke-MgExtractGroupDriveRootSensitivityLabel.md)
Invoke action extractSensitivityLabels

### [Invoke-MgExtractGroupSiteInformationProtectionPolicyLabel](Invoke-MgExtractGroupSiteInformationProtectionPolicyLabel.md)
Invoke action extractLabel

### [Invoke-MgFollowGroupDriveItem](Invoke-MgFollowGroupDriveItem.md)
Invoke action follow

### [Invoke-MgFollowGroupDriveRoot](Invoke-MgFollowGroupDriveRoot.md)
Invoke action follow

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

### [Invoke-MgGraphGroup](Invoke-MgGraphGroup.md)
Invoke action unsubscribeByMail

### [Invoke-MgGraphGroupDrive](Invoke-MgGraphGroupDrive.md)
Invoke function sharedWithMe

### [Invoke-MgInviteGroupDriveItem](Invoke-MgInviteGroupDriveItem.md)
Invoke action invite

### [Invoke-MgInviteGroupDriveRoot](Invoke-MgInviteGroupDriveRoot.md)
Invoke action invite

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

### [Invoke-MgRetryGroupServiceProvisioning](Invoke-MgRetryGroupServiceProvisioning.md)
Invoke action retryServiceProvisioning

### [Invoke-MgSignGroupSiteInformationProtectionDigest](Invoke-MgSignGroupSiteInformationProtectionDigest.md)
Invoke action signDigest

### [Invoke-MgSnoozeGroupCalendarEventReminder](Invoke-MgSnoozeGroupCalendarEventReminder.md)
Invoke action snoozeReminder

### [Invoke-MgSnoozeGroupEventReminder](Invoke-MgSnoozeGroupEventReminder.md)
Invoke action snoozeReminder

### [Invoke-MgSubscribeGroupByMail](Invoke-MgSubscribeGroupByMail.md)
Invoke action subscribeByMail

### [Invoke-MgUnfollowGroupDriveItem](Invoke-MgUnfollowGroupDriveItem.md)
Invoke action unfollow

### [Invoke-MgUnfollowGroupDriveRoot](Invoke-MgUnfollowGroupDriveRoot.md)
Invoke action unfollow

### [Join-MgGroupDriveListContentTypeWithHubSite](Join-MgGroupDriveListContentTypeWithHubSite.md)
Invoke action associateWithHubSites

### [Join-MgGroupSiteContentTypeWithHubSite](Join-MgGroupSiteContentTypeWithHubSite.md)
Invoke action associateWithHubSites

### [Join-MgGroupSiteListContentTypeWithHubSite](Join-MgGroupSiteListContentTypeWithHubSite.md)
Invoke action associateWithHubSites

### [New-MgGroup](New-MgGroup.md)
Create a new group as specified in the request body.
You can create one of the following groups: This operation returns by default only a subset of the properties for each group.
These default properties are noted in the Properties section.
To get properties that are _not_ returned by default, do a GET operation and specify the properties in a `$select` OData query option.
**Note**: To create a team, first create a group then add a team to it, see create team.

### [New-MgGroupAcceptedSenderByRef](New-MgGroupAcceptedSenderByRef.md)
Create new navigation property ref to acceptedSenders for groups

### [New-MgGroupConversation](New-MgGroupConversation.md)
Create new navigation property to conversations for groups

### [New-MgGroupConversationThread](New-MgGroupConversationThread.md)
Create new navigation property to threads for groups

### [New-MgGroupConversationThreadPostAttachment](New-MgGroupConversationThreadPostAttachment.md)
Create new navigation property to attachments for groups

### [New-MgGroupConversationThreadPostAttachmentUploadSession](New-MgGroupConversationThreadPostAttachmentUploadSession.md)
Invoke action createUploadSession

### [New-MgGroupConversationThreadPostExtension](New-MgGroupConversationThreadPostExtension.md)
Create new navigation property to extensions for groups

### [New-MgGroupConversationThreadPostInReplyToAttachment](New-MgGroupConversationThreadPostInReplyToAttachment.md)
Create new navigation property to attachments for groups

### [New-MgGroupConversationThreadPostInReplyToAttachmentUploadSession](New-MgGroupConversationThreadPostInReplyToAttachmentUploadSession.md)
Invoke action createUploadSession

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
Invoke action createLink

### [New-MgGroupDriveItemListItemLink](New-MgGroupDriveItemListItemLink.md)
Invoke action createLink

### [New-MgGroupDriveItemUploadSession](New-MgGroupDriveItemUploadSession.md)
Invoke action createUploadSession

### [New-MgGroupDriveListItemLink](New-MgGroupDriveListItemLink.md)
Invoke action createLink

### [New-MgGroupDriveRootLink](New-MgGroupDriveRootLink.md)
Invoke action createLink

### [New-MgGroupDriveRootListItemLink](New-MgGroupDriveRootListItemLink.md)
Invoke action createLink

### [New-MgGroupDriveRootUploadSession](New-MgGroupDriveRootUploadSession.md)
Invoke action createUploadSession

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
Create new navigation property to settings for groups

### [New-MgGroupSiteListItemLink](New-MgGroupSiteListItemLink.md)
Invoke action createLink

### [New-MgGroupThread](New-MgGroupThread.md)
Create new navigation property to threads for groups

### [New-MgGroupThreadPostAttachment](New-MgGroupThreadPostAttachment.md)
Create new navigation property to attachments for groups

### [New-MgGroupThreadPostAttachmentUploadSession](New-MgGroupThreadPostAttachmentUploadSession.md)
Invoke action createUploadSession

### [New-MgGroupThreadPostExtension](New-MgGroupThreadPostExtension.md)
Create new navigation property to extensions for groups

### [New-MgGroupThreadPostInReplyToAttachment](New-MgGroupThreadPostInReplyToAttachment.md)
Create new navigation property to attachments for groups

### [New-MgGroupThreadPostInReplyToAttachmentUploadSession](New-MgGroupThreadPostInReplyToAttachmentUploadSession.md)
Invoke action createUploadSession

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
Invoke action publish

### [Publish-MgGroupSiteContentType](Publish-MgGroupSiteContentType.md)
Invoke action publish

### [Publish-MgGroupSiteListContentType](Publish-MgGroupSiteListContentType.md)
Invoke action publish

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
Invoke action removeFavorite

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

### [Remove-MgGroupPhoto](Remove-MgGroupPhoto.md)
Delete navigation property photo for groups

### [Remove-MgGroupRejectedSenderByRef](Remove-MgGroupRejectedSenderByRef.md)
Delete ref of navigation property rejectedSenders for groups

### [Remove-MgGroupSetting](Remove-MgGroupSetting.md)
Delete navigation property settings for groups

### [Remove-MgGroupSite](Remove-MgGroupSite.md)
Invoke action remove

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
Invoke action resetUnseenCount

### [Restore-MgGroupDriveItem](Restore-MgGroupDriveItem.md)
Invoke action restore

### [Restore-MgGroupDriveItemListItemDocumentSetVersion](Restore-MgGroupDriveItemListItemDocumentSetVersion.md)
Invoke action restore

### [Restore-MgGroupDriveItemListItemVersion](Restore-MgGroupDriveItemListItemVersion.md)
Invoke action restoreVersion

### [Restore-MgGroupDriveItemVersion](Restore-MgGroupDriveItemVersion.md)
Invoke action restoreVersion

### [Restore-MgGroupDriveListItemDocumentSetVersion](Restore-MgGroupDriveListItemDocumentSetVersion.md)
Invoke action restore

### [Restore-MgGroupDriveListItemVersion](Restore-MgGroupDriveListItemVersion.md)
Invoke action restoreVersion

### [Restore-MgGroupDriveRoot](Restore-MgGroupDriveRoot.md)
Invoke action restore

### [Restore-MgGroupDriveRootListItemDocumentSetVersion](Restore-MgGroupDriveRootListItemDocumentSetVersion.md)
Invoke action restore

### [Restore-MgGroupDriveRootListItemVersion](Restore-MgGroupDriveRootListItemVersion.md)
Invoke action restoreVersion

### [Restore-MgGroupDriveRootVersion](Restore-MgGroupDriveRootVersion.md)
Invoke action restoreVersion

### [Restore-MgGroupSiteListItemDocumentSetVersion](Restore-MgGroupSiteListItemDocumentSetVersion.md)
Invoke action restore

### [Restore-MgGroupSiteListItemVersion](Restore-MgGroupSiteListItemVersion.md)
Invoke action restoreVersion

### [Revoke-MgGroupDriveItemPermissionGrant](Revoke-MgGroupDriveItemPermissionGrant.md)
Invoke action revokeGrants

### [Revoke-MgGroupDriveRootPermissionGrant](Revoke-MgGroupDriveRootPermissionGrant.md)
Invoke action revokeGrants

### [Revoke-MgGroupSitePermissionGrant](Revoke-MgGroupSitePermissionGrant.md)
Invoke action revokeGrants

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
Invoke action assignLicense

### [Set-MgGroupPhotoContent](Set-MgGroupPhotoContent.md)
Update media content for the navigation property photo in groups

### [Stop-MgGroupCalendarEvent](Stop-MgGroupCalendarEvent.md)
Invoke action cancel

### [Stop-MgGroupEvent](Stop-MgGroupEvent.md)
Invoke action cancel

### [Test-MgGroupDriveItemPermission](Test-MgGroupDriveItemPermission.md)
Invoke action validatePermission

### [Test-MgGroupDriveListContentTypePublished](Test-MgGroupDriveListContentTypePublished.md)
Invoke function isPublished

### [Test-MgGroupDriveRootPermission](Test-MgGroupDriveRootPermission.md)
Invoke action validatePermission

### [Test-MgGroupDynamicMembership](Test-MgGroupDynamicMembership.md)
Invoke action evaluateDynamicMembership

### [Test-MgGroupDynamicMembershipRule](Test-MgGroupDynamicMembershipRule.md)
Invoke action evaluateDynamicMembership

### [Test-MgGroupPermissionGrantProperty](Test-MgGroupPermissionGrantProperty.md)
Invoke action validateProperties

### [Test-MgGroupProperty](Test-MgGroupProperty.md)
Invoke action validateProperties

### [Test-MgGroupSiteContentTypePublished](Test-MgGroupSiteContentTypePublished.md)
Invoke function isPublished

### [Test-MgGroupSiteInformationProtectionDataLossPreventionPolicy](Test-MgGroupSiteInformationProtectionDataLossPreventionPolicy.md)
Invoke action evaluate

### [Test-MgGroupSiteInformationProtectionPolicyLabelApplication](Test-MgGroupSiteInformationProtectionPolicyLabelApplication.md)
Invoke action evaluateApplication

### [Test-MgGroupSiteInformationProtectionPolicyLabelClassificationResult](Test-MgGroupSiteInformationProtectionPolicyLabelClassificationResult.md)
Invoke action evaluateClassificationResults

### [Test-MgGroupSiteInformationProtectionPolicyLabelRemoval](Test-MgGroupSiteInformationProtectionPolicyLabelRemoval.md)
Invoke action evaluateRemoval

### [Test-MgGroupSiteInformationProtectionSensitivityLabel](Test-MgGroupSiteInformationProtectionSensitivityLabel.md)
Invoke action evaluate

### [Test-MgGroupSiteInformationProtectionSensitivityLabelSublabel](Test-MgGroupSiteInformationProtectionSensitivityLabelSublabel.md)
Invoke action evaluate

### [Test-MgGroupSiteListContentTypePublished](Test-MgGroupSiteListContentTypePublished.md)
Invoke function isPublished

### [Unpublish-MgGroupDriveListContentType](Unpublish-MgGroupDriveListContentType.md)
Invoke action unpublish

### [Unpublish-MgGroupSiteContentType](Unpublish-MgGroupSiteContentType.md)
Invoke action unpublish

### [Unpublish-MgGroupSiteListContentType](Unpublish-MgGroupSiteListContentType.md)
Invoke action unpublish

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

