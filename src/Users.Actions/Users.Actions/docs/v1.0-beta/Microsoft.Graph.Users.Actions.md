---
Module Name: Microsoft.Graph.Users.Actions
Module Guid: 3a11d282-1e18-426a-a1ae-b29f2ab12bc9
Download Help Link: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.users.actions
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Users.Actions Module
## Description
Microsoft Graph PowerShell Cmdlets

## Microsoft.Graph.Users.Actions Cmdlets
### [Add-MgUserChatMember](Add-MgUserChatMember.md)
Add multiple members in a single request to a team.
The response provides details about which memberships could and couldn't be created.

### [Add-MgUserDriveListContentTypeCopy](Add-MgUserDriveListContentTypeCopy.md)
Add a copy of a [content type][contentType] from a [site][site] to a [list][list].

### [Add-MgUserDriveListContentTypeCopyFromContentTypeHub](Add-MgUserDriveListContentTypeCopyFromContentTypeHub.md)
Add or sync a copy of a published content type from the content type hub to a target site or a list.
This method is part of the content type publishing changes to optimize the syncing of published content types to sites and lists, effectively switching from a 'push everywhere' to 'pull as needed' approach.
The method allows users to pull content types directly from the content type hub to a site or list.
For more information, see getCompatibleHubContentTypes and the blog post Syntex Product Updates – August 2021.

### [Add-MgUserPendingAccessReviewInstanceDecision](Add-MgUserPendingAccessReviewInstanceDecision.md)
Apply review decisions on an accessReviewInstance if the decisions were not applied automatically because the autoApplyDecisionsEnabled property is `false` in the review's accessReviewScheduleSettings.
The status of the accessReviewInstance must be `Completed` to call this method.

### [Clear-MgUserAndBlockManagedApp](Clear-MgUserAndBlockManagedApp.md)
Blocks the managed app user from app check-in.

### [Clear-MgUserChatMessageReaction](Clear-MgUserChatMessageReaction.md)
Invoke action unsetReaction

### [Clear-MgUserChatMessageReplyReaction](Clear-MgUserChatMessageReplyReaction.md)
Invoke action unsetReaction

### [Clear-MgUserManagedAppRegistrationByAzureAdDeviceId](Clear-MgUserManagedAppRegistrationByAzureAdDeviceId.md)
Issues a wipe operation on an app registration with specified aad device Id.

### [Clear-MgUserManagedAppRegistrationByDeviceTag](Clear-MgUserManagedAppRegistrationByDeviceTag.md)
Issues a wipe operation on an app registration with specified device tag.

### [Clear-MgUserManagedDevice](Clear-MgUserManagedDevice.md)
Wipe a device

### [Clear-MgUserPresence](Clear-MgUserPresence.md)
Clear a presence session of an application for a user.
If it is the user's only presence session, a successful **clearPresence** changes the user's presence to `Offline/Offline`.
Read more about presence sessions and their time-out and expiration.

### [Clear-MgUserPresenceUserPreferredPresence](Clear-MgUserPresenceUserPreferredPresence.md)
Clear the preferred availability and activity status for a user.

### [Complete-MgUserOutlookTask](Complete-MgUserOutlookTask.md)
Invoke action complete

### [Complete-MgUserOutlookTaskFolderTask](Complete-MgUserOutlookTaskFolderTask.md)
Invoke action complete

### [Complete-MgUserOutlookTaskGroupTaskFolderTask](Complete-MgUserOutlookTaskGroupTaskFolderTask.md)
Invoke action complete

### [Confirm-MgUserAuthenticationMicrosoftAuthenticatorMethodDeviceMemberGroup](Confirm-MgUserAuthenticationMicrosoftAuthenticatorMethodDeviceMemberGroup.md)
Check for membership in a specified list of group IDs, and return from that list those groups (identified by IDs) of which the specified user, group, service principal, organizational contact, device, or directory object is a member.
This function is transitive.
You can check up to a maximum of 20 groups per request.
This function supports all groups provisioned in Azure AD.
Because Microsoft 365 groups cannot contain other groups, membership in a Microsoft 365 group is always direct.

### [Confirm-MgUserAuthenticationMicrosoftAuthenticatorMethodDeviceMemberObject](Confirm-MgUserAuthenticationMicrosoftAuthenticatorMethodDeviceMemberObject.md)
Invoke action checkMemberObjects

### [Confirm-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceMemberGroup](Confirm-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceMemberGroup.md)
Check for membership in a specified list of group IDs, and return from that list those groups (identified by IDs) of which the specified user, group, service principal, organizational contact, device, or directory object is a member.
This function is transitive.
You can check up to a maximum of 20 groups per request.
This function supports all groups provisioned in Azure AD.
Because Microsoft 365 groups cannot contain other groups, membership in a Microsoft 365 group is always direct.

### [Confirm-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceMemberObject](Confirm-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceMemberObject.md)
Invoke action checkMemberObjects

### [Confirm-MgUserAuthenticationWindowHelloForBusinessMethodDeviceMemberGroup](Confirm-MgUserAuthenticationWindowHelloForBusinessMethodDeviceMemberGroup.md)
Check for membership in a specified list of group IDs, and return from that list those groups (identified by IDs) of which the specified user, group, service principal, organizational contact, device, or directory object is a member.
This function is transitive.
You can check up to a maximum of 20 groups per request.
This function supports all groups provisioned in Azure AD.
Because Microsoft 365 groups cannot contain other groups, membership in a Microsoft 365 group is always direct.

### [Confirm-MgUserAuthenticationWindowHelloForBusinessMethodDeviceMemberObject](Confirm-MgUserAuthenticationWindowHelloForBusinessMethodDeviceMemberObject.md)
Invoke action checkMemberObjects

### [Confirm-MgUserChatPermissionGrantMemberGroup](Confirm-MgUserChatPermissionGrantMemberGroup.md)
Check for membership in a specified list of group IDs, and return from that list those groups (identified by IDs) of which the specified user, group, service principal, organizational contact, device, or directory object is a member.
This function is transitive.
You can check up to a maximum of 20 groups per request.
This function supports all groups provisioned in Azure AD.
Because Microsoft 365 groups cannot contain other groups, membership in a Microsoft 365 group is always direct.

### [Confirm-MgUserChatPermissionGrantMemberObject](Confirm-MgUserChatPermissionGrantMemberObject.md)
Invoke action checkMemberObjects

### [Confirm-MgUserDeviceMemberGroup](Confirm-MgUserDeviceMemberGroup.md)
Check for membership in a specified list of group IDs, and return from that list those groups (identified by IDs) of which the specified user, group, service principal, organizational contact, device, or directory object is a member.
This function is transitive.
You can check up to a maximum of 20 groups per request.
This function supports all groups provisioned in Azure AD.
Because Microsoft 365 groups cannot contain other groups, membership in a Microsoft 365 group is always direct.

### [Confirm-MgUserDeviceMemberObject](Confirm-MgUserDeviceMemberObject.md)
Invoke action checkMemberObjects

### [Confirm-MgUserInformationProtectionSignature](Confirm-MgUserInformationProtectionSignature.md)
Invoke action verifySignature

### [Confirm-MgUserMemberGroup](Confirm-MgUserMemberGroup.md)
Check for membership in a specified list of group IDs, and return from that list those groups (identified by IDs) of which the specified user, group, service principal, organizational contact, device, or directory object is a member.
This function is transitive.
You can check up to a maximum of 20 groups per request.
This function supports all groups provisioned in Azure AD.
Because Microsoft 365 groups cannot contain other groups, membership in a Microsoft 365 group is always direct.

### [Confirm-MgUserMemberObject](Confirm-MgUserMemberObject.md)
Invoke action checkMemberObjects

### [Copy-MgUserDriveItem](Copy-MgUserDriveItem.md)
Asynchronously creates a copy of an [driveItem][item-resource] (including any children), under a new parent item or with a new name.

### [Copy-MgUserDriveListContentTypeToDefaultContentLocation](Copy-MgUserDriveListContentTypeToDefaultContentLocation.md)
Copy a file to a default content location in a [content type][contentType].
The file can then be added as a default file or template via a POST operation.

### [Copy-MgUserDriveRoot](Copy-MgUserDriveRoot.md)
Asynchronously creates a copy of an [driveItem][item-resource] (including any children), under a new parent item or with a new name.

### [Copy-MgUserMailFolder](Copy-MgUserMailFolder.md)
Copy a mailfolder and its contents to another mailfolder.

### [Copy-MgUserMailFolderChildFolder](Copy-MgUserMailFolderChildFolder.md)
Copy a mailfolder and its contents to another mailfolder.

### [Copy-MgUserMailFolderChildFolderMessage](Copy-MgUserMailFolderChildFolderMessage.md)
Copy a message to a folder within the user's mailbox.

### [Copy-MgUserMailFolderMessage](Copy-MgUserMailFolderMessage.md)
Copy a message to a folder within the user's mailbox.

### [Copy-MgUserMessage](Copy-MgUserMessage.md)
Copy a message to a folder within the user's mailbox.

### [Copy-MgUserOnenoteNotebook](Copy-MgUserOnenoteNotebook.md)
Copies a notebook to the Notebooks folder in the destination Documents library.
The folder is created if it doesn't exist.
For Copy operations, you follow an asynchronous calling pattern:  First call the Copy action, and then poll the operation endpoint for the result.

### [Copy-MgUserOnenotePageToSection](Copy-MgUserOnenotePageToSection.md)
Copy a page to a specific section.
For copy operations, you follow an asynchronous calling pattern:  First call the Copy action, and then poll the operation endpoint for the result.

### [Copy-MgUserOnenoteSectionToNotebook](Copy-MgUserOnenoteSectionToNotebook.md)
Copies a section to a specific notebook.
For Copy operations, you follow an asynchronous calling pattern:  First call the Copy action, and then poll the operation endpoint for the result.

### [Copy-MgUserOnenoteSectionToSectionGroup](Copy-MgUserOnenoteSectionToSectionGroup.md)
Copies a section to a specific section group.
For Copy operations, you follow an asynchronous calling pattern:  First call the Copy action, and then poll the operation endpoint for the result.

### [Disable-MgUserAuthenticationMethodSmsSignIn](Disable-MgUserAuthenticationMethodSmsSignIn.md)
Invoke action disableSmsSignIn

### [Disable-MgUserManagedDevice](Disable-MgUserManagedDevice.md)
Invoke action disable

### [Disable-MgUserManagedDeviceLostMode](Disable-MgUserManagedDeviceLostMode.md)
Disable lost mode

### [Enable-MgUserAuthenticationMethodSmsSignIn](Enable-MgUserAuthenticationMethodSmsSignIn.md)
Invoke action enableSmsSignIn

### [Enable-MgUserManagedDeviceLostMode](Enable-MgUserManagedDeviceLostMode.md)
Enable lost mode

### [Export-MgUserPersonalData](Export-MgUserPersonalData.md)
Submit a data policy operation request from a company administrator or an application to export an organizational user's data.
This data includes the user's data stored in OneDrive and their activity reports.
For more guidance about exporting data while complying with regulations, see Data Subject Requests and the GDPR and CCPA.

### [Find-MgUserManagedDevice](Find-MgUserManagedDevice.md)
Locate a device

### [Find-MgUserMeetingTime](Find-MgUserMeetingTime.md)
Suggest meeting times and locations based on organizer and attendee availability, and time or location constraints specified as parameters.
If **findMeetingTimes** cannot return any meeting suggestions, the response would indicate a reason in the **emptySuggestionsReason** property.
\nBased on this value, you can better adjust the parameters and call **findMeetingTimes** again.
The algorithm used to suggest meeting times and locations undergoes fine-tuning from time to time.
In scenarios like test environments where the input parameters and calendar data remain static, expect that the suggested results may differ over time.

### [Get-MgUserAuthenticationMicrosoftAuthenticatorMethodDeviceMemberGroup](Get-MgUserAuthenticationMicrosoftAuthenticatorMethodDeviceMemberGroup.md)
Return all the group IDs for the groups that the specified user, group, service principal, organizational contact, device, or directory object is a member of.
This function is transitive.

### [Get-MgUserAuthenticationMicrosoftAuthenticatorMethodDeviceMemberObject](Get-MgUserAuthenticationMicrosoftAuthenticatorMethodDeviceMemberObject.md)
Invoke action getMemberObjects

### [Get-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceMemberGroup](Get-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceMemberGroup.md)
Return all the group IDs for the groups that the specified user, group, service principal, organizational contact, device, or directory object is a member of.
This function is transitive.

### [Get-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceMemberObject](Get-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceMemberObject.md)
Invoke action getMemberObjects

### [Get-MgUserAuthenticationWindowHelloForBusinessMethodDeviceMemberGroup](Get-MgUserAuthenticationWindowHelloForBusinessMethodDeviceMemberGroup.md)
Return all the group IDs for the groups that the specified user, group, service principal, organizational contact, device, or directory object is a member of.
This function is transitive.

### [Get-MgUserAuthenticationWindowHelloForBusinessMethodDeviceMemberObject](Get-MgUserAuthenticationWindowHelloForBusinessMethodDeviceMemberObject.md)
Invoke action getMemberObjects

### [Get-MgUserById](Get-MgUserById.md)
Return the directory objects specified in a list of IDs.
Some common uses for this function are to:

### [Get-MgUserCalendarSchedule](Get-MgUserCalendarSchedule.md)
Get the free/busy availability information for a collection of users, distributions lists, or resources (rooms or equipment) for a specified time period.

### [Get-MgUserChatPermissionGrantById](Get-MgUserChatPermissionGrantById.md)
Return the directory objects specified in a list of IDs.
Some common uses for this function are to:

### [Get-MgUserChatPermissionGrantMemberGroup](Get-MgUserChatPermissionGrantMemberGroup.md)
Return all the group IDs for the groups that the specified user, group, service principal, organizational contact, device, or directory object is a member of.
This function is transitive.

### [Get-MgUserChatPermissionGrantMemberObject](Get-MgUserChatPermissionGrantMemberObject.md)
Invoke action getMemberObjects

### [Get-MgUserChatPermissionGrantUserOwnedObject](Get-MgUserChatPermissionGrantUserOwnedObject.md)
Invoke action getUserOwnedObjects

### [Get-MgUserDefaultCalendarSchedule](Get-MgUserDefaultCalendarSchedule.md)
Get the free/busy availability information for a collection of users, distributions lists, or resources (rooms or equipment) for a specified time period.

### [Get-MgUserDeviceById](Get-MgUserDeviceById.md)
Return the directory objects specified in a list of IDs.
Some common uses for this function are to:

### [Get-MgUserDeviceMemberGroup](Get-MgUserDeviceMemberGroup.md)
Return all the group IDs for the groups that the specified user, group, service principal, organizational contact, device, or directory object is a member of.
This function is transitive.

### [Get-MgUserDeviceMemberObject](Get-MgUserDeviceMemberObject.md)
Invoke action getMemberObjects

### [Get-MgUserDeviceUserOwnedObject](Get-MgUserDeviceUserOwnedObject.md)
Invoke action getUserOwnedObjects

### [Get-MgUserJoinedGroupById](Get-MgUserJoinedGroupById.md)
Return the directory objects specified in a list of IDs.
Some common uses for this function are to:

### [Get-MgUserJoinedGroupUserOwnedObject](Get-MgUserJoinedGroupUserOwnedObject.md)
Invoke action getUserOwnedObjects

### [Get-MgUserMailTip](Get-MgUserMailTip.md)
Get the MailTips of one or more recipients as available to the signed-in user.
Note that by making a `POST` call to the `getMailTips` action, you can request specific types of MailTips to \nbe returned for more than one recipient at one time.
The requested MailTips are returned in a mailTips collection.

### [Get-MgUserMemberGroup](Get-MgUserMemberGroup.md)
Return all the group IDs for the groups that the specified user, group, service principal, organizational contact, device, or directory object is a member of.
This function is transitive.

### [Get-MgUserMemberObject](Get-MgUserMemberObject.md)
Invoke action getMemberObjects

### [Get-MgUserOnenoteNotebookFromWebUrl](Get-MgUserOnenoteNotebookFromWebUrl.md)
Retrieve the properties and relationships of a notebook object by using its URL path.
The location can be user notebooks on Microsoft 365, group notebooks, or SharePoint site-hosted team notebooks on Microsoft 365.

### [Get-MgUserOwnedObjectByType](Get-MgUserOwnedObjectByType.md)
Invoke action getUserOwnedObjects

### [Grant-MgUserDriveItemPermission](Grant-MgUserDriveItemPermission.md)
Grant users access to a link represented by a [permission][].

### [Grant-MgUserDriveRootPermission](Grant-MgUserDriveRootPermission.md)
Grant users access to a link represented by a [permission][].

### [Hide-MgUserChatForUser](Hide-MgUserChatForUser.md)
Hide a chat for a user.

### [Initialize-MgUserManagedDeviceEsim](Initialize-MgUserManagedDeviceEsim.md)
Activate eSIM on the device.

### [Initialize-MgUserServicePlan](Initialize-MgUserServicePlan.md)
Activate a service plan with a given `servicePlanId` and `skuId` for a given user.

### [Invoke-MgAcceptUserEvent](Invoke-MgAcceptUserEvent.md)
Accept the specified event in a user calendar.

### [Invoke-MgAcceptUserEventInstance](Invoke-MgAcceptUserEventInstance.md)
Accept the specified event in a user calendar.

### [Invoke-MgAcceptUserEventInstanceTentatively](Invoke-MgAcceptUserEventInstanceTentatively.md)
Tentatively accept the specified event in a user calendar.
If the event allows proposals for new times, on responding tentative to the event, an invitee can choose to suggest an alternative time by including the **proposedNewTime** parameter.
For more information on how to propose a time, and how to receive and accept a new time proposal, see Propose new meeting times.

### [Invoke-MgAcceptUserEventTentatively](Invoke-MgAcceptUserEventTentatively.md)
Tentatively accept the specified event in a user calendar.
If the event allows proposals for new times, on responding tentative to the event, an invitee can choose to suggest an alternative time by including the **proposedNewTime** parameter.
For more information on how to propose a time, and how to receive and accept a new time proposal, see Propose new meeting times.

### [Invoke-MgAcceptUserPendingAccessReviewInstanceRecommendation](Invoke-MgAcceptUserPendingAccessReviewInstanceRecommendation.md)
Allows the acceptance of recommendations on all accessReviewInstanceDecisionItem objects that have not been reviewed for an accessReviewInstance object for which the calling user is a reviewer.
Recommendations are generated if **recommendationsEnabled** is `true` on the accessReviewScheduleDefinition object.
If there is not a recommendation on an accessReviewInstanceDecisionItem object no decision will be recorded.

### [Invoke-MgBatchUserPendingAccessReviewInstanceRecordDecision](Invoke-MgBatchUserPendingAccessReviewInstanceRecordDecision.md)
Enables reviewers to review all accessReviewInstanceDecisionItem objects in batches by using **principalId**, **resourceId**, or neither.

### [Invoke-MgBufferUserInformationProtectionDecrypt](Invoke-MgBufferUserInformationProtectionDecrypt.md)
Invoke action decryptBuffer

### [Invoke-MgBufferUserInformationProtectionEncrypt](Invoke-MgBufferUserInformationProtectionEncrypt.md)
Invoke action encryptBuffer

### [Invoke-MgBulkReprovisionUserManagedDeviceCloudPc](Invoke-MgBulkReprovisionUserManagedDeviceCloudPc.md)
Bulk reprovision a set of Cloud PC devices with Intune managed device IDs.

### [Invoke-MgBulkRestoreUserManagedDeviceCloudPc](Invoke-MgBulkRestoreUserManagedDeviceCloudPc.md)
Restore multiple Cloud PC devices with a single request that includes the IDs of Intune managed devices and a restore point date and time.

### [Invoke-MgBulkUserManagedDeviceSetCloudPcReviewStatus](Invoke-MgBulkUserManagedDeviceSetCloudPcReviewStatus.md)
Set the review status of multiple Cloud PC devices with a single request that includes the IDs of Intune managed devices.

### [Invoke-MgCheckinUserDriveItem](Invoke-MgCheckinUserDriveItem.md)
Check in a checked out **driveItem** resource, which makes the version of the document available to others.

### [Invoke-MgCheckinUserDriveRoot](Invoke-MgCheckinUserDriveRoot.md)
Check in a checked out **driveItem** resource, which makes the version of the document available to others.

### [Invoke-MgCheckoutUserDriveItem](Invoke-MgCheckoutUserDriveItem.md)
Check out a **driveItem** resource to prevent others from editing the document, and prevent your changes from being visible until the documented is checked in.

### [Invoke-MgCheckoutUserDriveRoot](Invoke-MgCheckoutUserDriveRoot.md)
Check out a **driveItem** resource to prevent others from editing the document, and prevent your changes from being visible until the documented is checked in.

### [Invoke-MgCleanUserManagedDeviceWindowDevice](Invoke-MgCleanUserManagedDeviceWindowDevice.md)
Clean Windows device

### [Invoke-MgCreateOrGetUserOnlineMeeting](Invoke-MgCreateOrGetUserOnlineMeeting.md)
Create an onlineMeeting object with a custom specified external ID.
If the external ID already exists, this API will return the onlineMeeting object with that external ID.

### [Invoke-MgDeclineUserEvent](Invoke-MgDeclineUserEvent.md)
Decline invitation to the specified event in a user calendar.
If the event allows proposals for new times, on declining the event, an invitee can choose to suggest an alternative time by including the **proposedNewTime** parameter.
For more information on how to propose a time, and how to receive and accept a new time proposal, see Propose new meeting times.

### [Invoke-MgDeclineUserEventInstance](Invoke-MgDeclineUserEventInstance.md)
Decline invitation to the specified event in a user calendar.
If the event allows proposals for new times, on declining the event, an invitee can choose to suggest an alternative time by including the **proposedNewTime** parameter.
For more information on how to propose a time, and how to receive and accept a new time proposal, see Propose new meeting times.

### [Invoke-MgDeprovisionUserManagedDevice](Invoke-MgDeprovisionUserManagedDevice.md)
Invoke action deprovision

### [Invoke-MgDismissUserEventInstanceReminder](Invoke-MgDismissUserEventInstanceReminder.md)
Dismiss a reminder that has been triggered for an event in a user calendar.

### [Invoke-MgDismissUserEventReminder](Invoke-MgDismissUserEventReminder.md)
Dismiss a reminder that has been triggered for an event in a user calendar.

### [Invoke-MgDownloadUserManagedDeviceAppDiagnostic](Invoke-MgDownloadUserManagedDeviceAppDiagnostic.md)
Invoke action downloadAppDiagnostics

### [Invoke-MgDownUserManagedDeviceShut](Invoke-MgDownUserManagedDeviceShut.md)
Shut down device

### [Invoke-MgEnrollUserManagedDeviceNowAction](Invoke-MgEnrollUserManagedDeviceNowAction.md)
Trigger comanagement enrollment action on ConfigurationManager client

### [Invoke-MgExecuteUserManagedDeviceAction](Invoke-MgExecuteUserManagedDeviceAction.md)
Invoke action executeAction

### [Invoke-MgExtractUserDriveItemSensitivityLabel](Invoke-MgExtractUserDriveItemSensitivityLabel.md)
Invoke action extractSensitivityLabels

### [Invoke-MgExtractUserDriveRootSensitivityLabel](Invoke-MgExtractUserDriveRootSensitivityLabel.md)
Invoke action extractSensitivityLabels

### [Invoke-MgExtractUserInformationProtectionPolicyLabel](Invoke-MgExtractUserInformationProtectionPolicyLabel.md)
Using the metadata that exists on an already-labeled piece of information, resolve the metadata to a specific sensitivity label.
The contentInfo input is resolved to informationProtectionContentLabel.

### [Invoke-MgExtractUserSecurityInformationProtectionSensitivityLabelContentLabel](Invoke-MgExtractUserSecurityInformationProtectionSensitivityLabelContentLabel.md)
Invoke action extractContentLabel

### [Invoke-MgFollowUserDriveItem](Invoke-MgFollowUserDriveItem.md)
Follow a driveItem.

### [Invoke-MgFollowUserDriveRoot](Invoke-MgFollowUserDriveRoot.md)
Follow a driveItem.

### [Invoke-MgForwardUserEvent](Invoke-MgForwardUserEvent.md)
This action allows the organizer or attendee of a meeting event to forward the \nmeeting request to a new recipient.
If the meeting event is forwarded from an attendee's Microsoft 365 mailbox to another recipient, this action \nalso sends a message to notify the organizer of the forwarding, and adds the recipient to the organizer's \ncopy of the meeting event.
This convenience is not available when forwarding from an Outlook.com account.

### [Invoke-MgForwardUserEventInstance](Invoke-MgForwardUserEventInstance.md)
This action allows the organizer or attendee of a meeting event to forward the \nmeeting request to a new recipient.
If the meeting event is forwarded from an attendee's Microsoft 365 mailbox to another recipient, this action \nalso sends a message to notify the organizer of the forwarding, and adds the recipient to the organizer's \ncopy of the meeting event.
This convenience is not available when forwarding from an Outlook.com account.

### [Invoke-MgForwardUserMailFolderChildFolderMessage](Invoke-MgForwardUserMailFolderChildFolderMessage.md)
Forward a message using either JSON or MIME format.
When using JSON format, you can:\n- Specify either a comment or the **body** property of the `message` parameter.
Specifying both will return an HTTP 400 Bad Request error.\n- Specify either the `toRecipients` parameter or the **toRecipients** property of the `message` parameter.
Specifying both or specifying neither will return an HTTP 400 Bad Request error.
When using MIME format:\n- Provide the applicable Internet message headers and the MIME content, all encoded in **base64** format in the request body.\n- Add any attachments and S/MIME properties to the MIME content.
This method saves the message in the **Sent Items** folder.
Alternatively, create a draft to forward a message, and send it later.

### [Invoke-MgForwardUserMailFolderMessage](Invoke-MgForwardUserMailFolderMessage.md)
Forward a message using either JSON or MIME format.
When using JSON format, you can:\n- Specify either a comment or the **body** property of the `message` parameter.
Specifying both will return an HTTP 400 Bad Request error.\n- Specify either the `toRecipients` parameter or the **toRecipients** property of the `message` parameter.
Specifying both or specifying neither will return an HTTP 400 Bad Request error.
When using MIME format:\n- Provide the applicable Internet message headers and the MIME content, all encoded in **base64** format in the request body.\n- Add any attachments and S/MIME properties to the MIME content.
This method saves the message in the **Sent Items** folder.
Alternatively, create a draft to forward a message, and send it later.

### [Invoke-MgForwardUserMessage](Invoke-MgForwardUserMessage.md)
Forward a message using either JSON or MIME format.
When using JSON format, you can:\n- Specify either a comment or the **body** property of the `message` parameter.
Specifying both will return an HTTP 400 Bad Request error.\n- Specify either the `toRecipients` parameter or the **toRecipients** property of the `message` parameter.
Specifying both or specifying neither will return an HTTP 400 Bad Request error.
When using MIME format:\n- Provide the applicable Internet message headers and the MIME content, all encoded in **base64** format in the request body.\n- Add any attachments and S/MIME properties to the MIME content.
This method saves the message in the **Sent Items** folder.
Alternatively, create a draft to forward a message, and send it later.

### [Invoke-MgGraphUserChat](Invoke-MgGraphUserChat.md)
Unhide a chat for a user.

### [Invoke-MgHasUserDeviceEnrollmentConfigurationPayloadLink](Invoke-MgHasUserDeviceEnrollmentConfigurationPayloadLink.md)
Invoke action hasPayloadLinks

### [Invoke-MgInvalidateUserRefreshToken](Invoke-MgInvalidateUserRefreshToken.md)
Invalidates all of the user's refresh tokens issued to applications (as well as session cookies in a user's browser), by resetting the **refreshTokensValidFromDateTime** user property to the current date-time.
Typically, this operation is performed (by the user or an administrator) if the user has a lost or stolen device.
This operation would prevent access to any of the organization's data accessed through applications on the device without the user first being required to sign in again.
In fact, this operation would force the user to sign in again for all applications that they have previously consented to, independent of device.
For developers, if the application attempts to redeem a delegated access token for this user by using an invalidated refresh token, the application will get an error.
If this happens, the application will need to acquire a new refresh token by making a request to the authorize endpoint, which will force the user to sign in.

### [Invoke-MgInviteUserDriveItem](Invoke-MgInviteUserDriveItem.md)
Sends a sharing invitation for a **DriveItem**.\nA sharing invitation provides permissions to the recipients and optionally sends an email to the recipients to notify them the item was shared.

### [Invoke-MgInviteUserDriveRoot](Invoke-MgInviteUserDriveRoot.md)
Sends a sharing invitation for a **DriveItem**.\nA sharing invitation provides permissions to the recipients and optionally sends an email to the recipients to notify them the item was shared.

### [Invoke-MgLicenseUser](Invoke-MgLicenseUser.md)
Reprocess all group-based license assignments for the user.
To learn more about group-based licensing, see What is group-based licensing in Azure Active Directory.
Also see Identify and resolve license assignment problems for a group in Azure Active Directory for more details.

### [Invoke-MgLogoutUserManagedDeviceSharedAppleDeviceActiveUser](Invoke-MgLogoutUserManagedDeviceSharedAppleDeviceActiveUser.md)
Logout shared Apple device active user

### [Invoke-MgMarkUserChatReadForUser](Invoke-MgMarkUserChatReadForUser.md)
Mark a chat as read for a user.

### [Invoke-MgMarkUserChatUnreadForUser](Invoke-MgMarkUserChatUnreadForUser.md)
Mark a chat as unread for a user.

### [Invoke-MgOverrideUserManagedDeviceComplianceState](Invoke-MgOverrideUserManagedDeviceComplianceState.md)
Invoke action overrideComplianceState

### [Invoke-MgPlayUserManagedDeviceLostModeSound](Invoke-MgPlayUserManagedDeviceLostModeSound.md)
Play lost mode sound

### [Invoke-MgPreviewUserDriveItem](Invoke-MgPreviewUserDriveItem.md)
Invoke action preview

### [Invoke-MgPreviewUserDriveRoot](Invoke-MgPreviewUserDriveRoot.md)
Invoke action preview

### [Invoke-MgReauthorizeUserDriveItemSubscription](Invoke-MgReauthorizeUserDriveItemSubscription.md)
Invoke action reauthorize

### [Invoke-MgReauthorizeUserDriveListSubscription](Invoke-MgReauthorizeUserDriveListSubscription.md)
Invoke action reauthorize

### [Invoke-MgReauthorizeUserDriveRootSubscription](Invoke-MgReauthorizeUserDriveRootSubscription.md)
Invoke action reauthorize

### [Invoke-MgRecordUserPendingAccessReviewInstanceDecision](Invoke-MgRecordUserPendingAccessReviewInstanceDecision.md)
As a reviewer of an access review, record a decision for an accessReviewInstanceDecisionItem that is assigned to you and that matches the principal or resource IDs specified.
If no IDs are specified, the decisions will apply to every **accessReviewInstanceDecisionItem** for which you are the reviewer.

### [Invoke-MgReenableUserManagedDevice](Invoke-MgReenableUserManagedDevice.md)
Invoke action reenable

### [Invoke-MgReplyAllUserMailFolderChildFolderMessage](Invoke-MgReplyAllUserMailFolderChildFolderMessage.md)
Reply to all recipients of a message using either JSON or MIME format.
When using JSON format:\n- Specify either a comment or the **body** property of the `message` parameter.
Specifying both will return an HTTP 400 Bad Request error.\n- If the original message specifies a recipient in the **replyTo** property, per Internet Message Format (RFC 2822), send the reply to the recipients in **replyTo** and not the recipient in the **from** property.
When using MIME format:\n- Provide the applicable Internet message headers and the MIME content, all encoded in **base64** format in the request body.\n- Add any attachments and S/MIME properties to the MIME content.
This method saves the message in the **Sent Items** folder.
Alternatively, create a draft to reply-all to a message, and send it later.

### [Invoke-MgReplyAllUserMailFolderMessage](Invoke-MgReplyAllUserMailFolderMessage.md)
Reply to all recipients of a message using either JSON or MIME format.
When using JSON format:\n- Specify either a comment or the **body** property of the `message` parameter.
Specifying both will return an HTTP 400 Bad Request error.\n- If the original message specifies a recipient in the **replyTo** property, per Internet Message Format (RFC 2822), send the reply to the recipients in **replyTo** and not the recipient in the **from** property.
When using MIME format:\n- Provide the applicable Internet message headers and the MIME content, all encoded in **base64** format in the request body.\n- Add any attachments and S/MIME properties to the MIME content.
This method saves the message in the **Sent Items** folder.
Alternatively, create a draft to reply-all to a message, and send it later.

### [Invoke-MgReplyAllUserMessage](Invoke-MgReplyAllUserMessage.md)
Reply to all recipients of a message using either JSON or MIME format.
When using JSON format:\n- Specify either a comment or the **body** property of the `message` parameter.
Specifying both will return an HTTP 400 Bad Request error.\n- If the original message specifies a recipient in the **replyTo** property, per Internet Message Format (RFC 2822), send the reply to the recipients in **replyTo** and not the recipient in the **from** property.
When using MIME format:\n- Provide the applicable Internet message headers and the MIME content, all encoded in **base64** format in the request body.\n- Add any attachments and S/MIME properties to the MIME content.
This method saves the message in the **Sent Items** folder.
Alternatively, create a draft to reply-all to a message, and send it later.

### [Invoke-MgReplyUserMailFolderChildFolderMessage](Invoke-MgReplyUserMailFolderChildFolderMessage.md)
Reply to the sender of a message using either JSON or MIME format.
When using JSON format:\n- Specify either a comment or the **body** property of the `message` parameter.
Specifying both will return an HTTP 400 Bad Request error.\n- If the original message specifies a recipient in the **replyTo** property, per Internet Message Format (RFC 2822), send the reply to the recipients in **replyTo** and not the recipient in the **from** property.
When using MIME format:\n- Provide the applicable Internet message headers and the MIME content, all encoded in **base64** format in the request body.\n- Add any attachments and S/MIME properties to the MIME content.
This method saves the message in the **Sent Items** folder.
Alternatively, create a draft to reply to a message, and send it later.

### [Invoke-MgReplyUserMailFolderMessage](Invoke-MgReplyUserMailFolderMessage.md)
Reply to the sender of a message using either JSON or MIME format.
When using JSON format:\n- Specify either a comment or the **body** property of the `message` parameter.
Specifying both will return an HTTP 400 Bad Request error.\n- If the original message specifies a recipient in the **replyTo** property, per Internet Message Format (RFC 2822), send the reply to the recipients in **replyTo** and not the recipient in the **from** property.
When using MIME format:\n- Provide the applicable Internet message headers and the MIME content, all encoded in **base64** format in the request body.\n- Add any attachments and S/MIME properties to the MIME content.
This method saves the message in the **Sent Items** folder.
Alternatively, create a draft to reply to a message, and send it later.

### [Invoke-MgReplyUserMessage](Invoke-MgReplyUserMessage.md)
Reply to the sender of a message using either JSON or MIME format.
When using JSON format:\n- Specify either a comment or the **body** property of the `message` parameter.
Specifying both will return an HTTP 400 Bad Request error.\n- If the original message specifies a recipient in the **replyTo** property, per Internet Message Format (RFC 2822), send the reply to the recipients in **replyTo** and not the recipient in the **from** property.
When using MIME format:\n- Provide the applicable Internet message headers and the MIME content, all encoded in **base64** format in the request body.\n- Add any attachments and S/MIME properties to the MIME content.
This method saves the message in the **Sent Items** folder.
Alternatively, create a draft to reply to a message, and send it later.

### [Invoke-MgReprovisionUserCloudPc](Invoke-MgReprovisionUserCloudPc.md)
Reprovision a specific Cloud PC.

### [Invoke-MgReprovisionUserManagedDeviceCloudPc](Invoke-MgReprovisionUserManagedDeviceCloudPc.md)
Reprovision a Cloud PC with an Intune managed device ID.

### [Invoke-MgRetireUserManagedDevice](Invoke-MgRetireUserManagedDevice.md)
Retire a device

### [Invoke-MgRotateUserManagedDeviceBitLockerKey](Invoke-MgRotateUserManagedDeviceBitLockerKey.md)
Rotate BitLockerKeys

### [Invoke-MgRotateUserManagedDeviceFileVaultKey](Invoke-MgRotateUserManagedDeviceFileVaultKey.md)
Invoke action rotateFileVaultKey

### [Invoke-MgScanUserManagedDeviceWindowDefender](Invoke-MgScanUserManagedDeviceWindowDefender.md)
Invoke action windowsDefenderScan

### [Invoke-MgSignUserInformationProtectionDigest](Invoke-MgSignUserInformationProtectionDigest.md)
Invoke action signDigest

### [Invoke-MgSnoozeUserEventInstanceReminder](Invoke-MgSnoozeUserEventInstanceReminder.md)
Postpone a reminder for an event in a user calendar until a new time.

### [Invoke-MgSnoozeUserEventReminder](Invoke-MgSnoozeUserEventReminder.md)
Postpone a reminder for an event in a user calendar until a new time.

### [Invoke-MgSoftUserChatMessageDelete](Invoke-MgSoftUserChatMessageDelete.md)
Delete a single message or a message reply in a channel or a chat.

### [Invoke-MgSoftUserChatMessageReplyDelete](Invoke-MgSoftUserChatMessageReplyDelete.md)
Delete a single message or a message reply in a channel or a chat.

### [Invoke-MgTranslateUserExchangeId](Invoke-MgTranslateUserExchangeId.md)
Translate identifiers of Outlook-related resources between formats.

### [Invoke-MgTroubleshootUserCloudPc](Invoke-MgTroubleshootUserCloudPc.md)
Troubleshoot a specific Cloud PC.
Use this API to check the health status of the Cloud PC and the session host.

### [Invoke-MgUnfollowUserDriveItem](Invoke-MgUnfollowUserDriveItem.md)
Unfollow a driveItem.

### [Invoke-MgUnfollowUserDriveRoot](Invoke-MgUnfollowUserDriveRoot.md)
Unfollow a driveItem.

### [Invoke-MgUnsubscribeUserMailFolderChildFolderMessage](Invoke-MgUnsubscribeUserMailFolderChildFolderMessage.md)
Submits a email request on behalf of the signed-in user to unsubscribe from an email distribution list.
Uses the information in the `List-Unsubscribe` header.
Message senders can use mailing lists in a user-friendly way by including an option for recipients to opt out.
They can do so by specifying the `List-Unsubscribe` header in each message following RFC-2369.
**Note** In particular, for the **unsubscribe** action to work, the sender must specify `mailto:` and not URL-based unsubscribe information.
Setting that header would also set the **unsubscribeEnabled** property of the message instance to `true`, and the **unsubscribeData** property to the header data.
If the **unsubscribeEnabled** property of a message is `true`, you can use the **unsubscribe** action to unsubscribe the user from similar future messages as managed by the message sender.
A successful **unsubscribe** action moves the message to the **Deleted Items** folder.
The actual exclusion of the user from future mail distribution is managed by the sender.

### [Invoke-MgUnsubscribeUserMailFolderMessage](Invoke-MgUnsubscribeUserMailFolderMessage.md)
Submits a email request on behalf of the signed-in user to unsubscribe from an email distribution list.
Uses the information in the `List-Unsubscribe` header.
Message senders can use mailing lists in a user-friendly way by including an option for recipients to opt out.
They can do so by specifying the `List-Unsubscribe` header in each message following RFC-2369.
**Note** In particular, for the **unsubscribe** action to work, the sender must specify `mailto:` and not URL-based unsubscribe information.
Setting that header would also set the **unsubscribeEnabled** property of the message instance to `true`, and the **unsubscribeData** property to the header data.
If the **unsubscribeEnabled** property of a message is `true`, you can use the **unsubscribe** action to unsubscribe the user from similar future messages as managed by the message sender.
A successful **unsubscribe** action moves the message to the **Deleted Items** folder.
The actual exclusion of the user from future mail distribution is managed by the sender.

### [Invoke-MgUnsubscribeUserMessage](Invoke-MgUnsubscribeUserMessage.md)
Submits a email request on behalf of the signed-in user to unsubscribe from an email distribution list.
Uses the information in the `List-Unsubscribe` header.
Message senders can use mailing lists in a user-friendly way by including an option for recipients to opt out.
They can do so by specifying the `List-Unsubscribe` header in each message following RFC-2369.
**Note** In particular, for the **unsubscribe** action to work, the sender must specify `mailto:` and not URL-based unsubscribe information.
Setting that header would also set the **unsubscribeEnabled** property of the message instance to `true`, and the **unsubscribeData** property to the header data.
If the **unsubscribeEnabled** property of a message is `true`, you can use the **unsubscribe** action to unsubscribe the user from similar future messages as managed by the message sender.
A successful **unsubscribe** action moves the message to the **Deleted Items** folder.
The actual exclusion of the user from future mail distribution is managed by the sender.

### [Join-MgUserDriveListContentTypeWithHubSite](Join-MgUserDriveListContentTypeWithHubSite.md)
Associate a [content type][contentType] with a list of hub sites.

### [Lock-MgUserManagedDeviceRemote](Lock-MgUserManagedDeviceRemote.md)
Remote lock

### [Move-MgUserMailFolder](Move-MgUserMailFolder.md)
Move a mailfolder and its contents to another mailfolder.

### [Move-MgUserMailFolderChildFolder](Move-MgUserMailFolderChildFolder.md)
Move a mailfolder and its contents to another mailfolder.

### [Move-MgUserMailFolderChildFolderMessage](Move-MgUserMailFolderChildFolderMessage.md)
Move a message to another folder within the specified user's mailbox.
This creates a new copy of the message in the destination folder and removes the original message.

### [Move-MgUserMailFolderMessage](Move-MgUserMailFolderMessage.md)
Move a message to another folder within the specified user's mailbox.
This creates a new copy of the message in the destination folder and removes the original message.

### [Move-MgUserManagedDeviceToOu](Move-MgUserManagedDeviceToOu.md)
Invoke action moveDevicesToOU

### [Move-MgUserMessage](Move-MgUserMessage.md)
Move a message to another folder within the specified user's mailbox.
This creates a new copy of the message in the destination folder and removes the original message.

### [Move-MgUserTaskAlltask](Move-MgUserTaskAlltask.md)
Move a baseTask object from one baseTaskList to another.

### [Move-MgUserTaskListTask](Move-MgUserTaskListTask.md)
Move a baseTask object from one baseTaskList to another.

### [New-MgUserDeviceEnrollmentConfigurationEnrollmentNotificationConfiguration](New-MgUserDeviceEnrollmentConfigurationEnrollmentNotificationConfiguration.md)
Invoke action createEnrollmentNotificationConfiguration

### [New-MgUserDriveItemLink](New-MgUserDriveItemLink.md)
You can use **createLink** action to share a driveItem via a sharing link.
The **createLink** action will create a new sharing link if the specified link type doesn't already exist for the calling application.\nIf a sharing link of the specified type already exists for the app, the existing sharing link will be returned.
DriveItem resources inherit sharing permissions from their ancestors.

### [New-MgUserDriveItemListItemLink](New-MgUserDriveItemListItemLink.md)
Create a sharing link for a listItem.
The **createLink** action creates a new sharing link if the specified link type doesn't already exist for the calling application.\nIf a sharing link of the specified type already exists for the app, this action will return the existing sharing link.
**listItem** resources inherit sharing permissions from the list the item resides in.

### [New-MgUserDriveItemUploadSession](New-MgUserDriveItemUploadSession.md)
Create an upload session to allow your app to upload files up to the maximum file size.
An upload session allows your app to upload ranges of the file in sequential API requests, which allows the transfer to be resumed if a connection is dropped while the upload is in progress.
To upload a file using an upload session:

### [New-MgUserDriveListItemLink](New-MgUserDriveListItemLink.md)
Create a sharing link for a listItem.
The **createLink** action creates a new sharing link if the specified link type doesn't already exist for the calling application.\nIf a sharing link of the specified type already exists for the app, this action will return the existing sharing link.
**listItem** resources inherit sharing permissions from the list the item resides in.

### [New-MgUserDriveRootLink](New-MgUserDriveRootLink.md)
You can use **createLink** action to share a driveItem via a sharing link.
The **createLink** action will create a new sharing link if the specified link type doesn't already exist for the calling application.\nIf a sharing link of the specified type already exists for the app, the existing sharing link will be returned.
DriveItem resources inherit sharing permissions from their ancestors.

### [New-MgUserDriveRootListItemLink](New-MgUserDriveRootListItemLink.md)
Create a sharing link for a listItem.
The **createLink** action creates a new sharing link if the specified link type doesn't already exist for the calling application.\nIf a sharing link of the specified type already exists for the app, this action will return the existing sharing link.
**listItem** resources inherit sharing permissions from the list the item resides in.

### [New-MgUserDriveRootUploadSession](New-MgUserDriveRootUploadSession.md)
Create an upload session to allow your app to upload files up to the maximum file size.
An upload session allows your app to upload ranges of the file in sequential API requests, which allows the transfer to be resumed if a connection is dropped while the upload is in progress.
To upload a file using an upload session:

### [New-MgUserEventAttachmentUploadSession](New-MgUserEventAttachmentUploadSession.md)
Create an upload session that allows an app to iteratively upload ranges of a file, so as to attach the file to an Outlook item.
The item can be a message or event.
Use this approach to attach a file if the file size is between 3 MB and 150 MB.
To attach a file that's smaller than 3 MB, do a `POST` operation on the **attachments** navigation property of the Outlook item; see how to do this for a message or for an event.
As part of the response, this action returns an upload URL that you can use in subsequent sequential `PUT` queries.
Request headers for each `PUT` operation let you specify the exact range of bytes to be uploaded.
This allows transfer to be resumed, in case the network connection is dropped during upload.
The following are the steps to attach a file to an Outlook item using an upload session: See attach large files to Outlook messages or events for an example.

### [New-MgUserEventInstanceAttachmentUploadSession](New-MgUserEventInstanceAttachmentUploadSession.md)
Create an upload session that allows an app to iteratively upload ranges of a file, so as to attach the file to an Outlook item.
The item can be a message or event.
Use this approach to attach a file if the file size is between 3 MB and 150 MB.
To attach a file that's smaller than 3 MB, do a `POST` operation on the **attachments** navigation property of the Outlook item; see how to do this for a message or for an event.
As part of the response, this action returns an upload URL that you can use in subsequent sequential `PUT` queries.
Request headers for each `PUT` operation let you specify the exact range of bytes to be uploaded.
This allows transfer to be resumed, in case the network connection is dropped during upload.
The following are the steps to attach a file to an Outlook item using an upload session: See attach large files to Outlook messages or events for an example.

### [New-MgUserMailFolderChildFolderMessageAttachmentUploadSession](New-MgUserMailFolderChildFolderMessageAttachmentUploadSession.md)
Create an upload session that allows an app to iteratively upload ranges of a file, so as to attach the file to an Outlook item.
The item can be a message or event.
Use this approach to attach a file if the file size is between 3 MB and 150 MB.
To attach a file that's smaller than 3 MB, do a `POST` operation on the **attachments** navigation property of the Outlook item; see how to do this for a message or for an event.
As part of the response, this action returns an upload URL that you can use in subsequent sequential `PUT` queries.
Request headers for each `PUT` operation let you specify the exact range of bytes to be uploaded.
This allows transfer to be resumed, in case the network connection is dropped during upload.
The following are the steps to attach a file to an Outlook item using an upload session: See attach large files to Outlook messages or events for an example.

### [New-MgUserMailFolderChildFolderMessageForward](New-MgUserMailFolderChildFolderMessageForward.md)
Create a draft to forward an existing message, in either JSON or MIME format.
When using JSON format, you can: \n- Specify either a comment or the **body** property of the `message` parameter.
Specifying both will return an HTTP 400 Bad Request error.\n- Specify either the `toRecipients` parameter or the **toRecipients** property of the `message` parameter.
Specifying both or specifying neither will return an HTTP 400 Bad Request error.\n- Update the draft later to add content to the **body** or change other message properties.
When using MIME format:\n- Provide the applicable Internet message headers and the MIME content, all encoded in **base64** format in the request body.\n- Add any attachments and S/MIME properties to the MIME content.
Send the draft message in a subsequent operation.
Alternatively, forward a message in a single operation.

### [New-MgUserMailFolderChildFolderMessageReply](New-MgUserMailFolderChildFolderMessageReply.md)
Create a draft to reply to the sender of a message in either JSON or MIME format.
When using JSON format:\n- Specify either a comment or the **body** property of the `message` parameter.
Specifying both will return an HTTP 400 Bad Request error.\n- If **replyTo** is specified in the original message, per Internet Message Format (RFC 2822), you should send the reply to the recipients in **replyTo**, and not the recipients in **from**.\n- You can update the draft later to add reply content to the **body** or change other message properties.
When using MIME format:\n- Provide the applicable Internet message headers and the MIME content, all encoded in **base64** format in the request body.\n- Add any attachments and S/MIME properties to the MIME content.
Send the draft message in a subsequent operation.
Alternatively, reply to a message in a single operation.

### [New-MgUserMailFolderChildFolderMessageReplyAll](New-MgUserMailFolderChildFolderMessageReplyAll.md)
Create a draft to reply to the sender and all recipients of a message in either JSON or MIME format.
When using JSON format:\n- Specify either a comment or the **body** property of the `message` parameter.
Specifying both will return an HTTP 400 Bad Request error.\n- If the original message specifies a recipient in the **replyTo** property, per Internet Message Format (RFC 2822), you should send the reply to the recipients in the **replyTo** and **toRecipients** properties, and not the recipients in the **from** and **toRecipients** properties.
\n- You can update the draft message later.
When using MIME format:\n- Provide the applicable Internet message headers and the MIME content, all encoded in **base64** format in the request body.\n- Add any attachments and S/MIME properties to the MIME content.
Send the draft message in a subsequent operation.
Alternatively, reply-all to a message in a single action.

### [New-MgUserMailFolderMessageAttachmentUploadSession](New-MgUserMailFolderMessageAttachmentUploadSession.md)
Create an upload session that allows an app to iteratively upload ranges of a file, so as to attach the file to an Outlook item.
The item can be a message or event.
Use this approach to attach a file if the file size is between 3 MB and 150 MB.
To attach a file that's smaller than 3 MB, do a `POST` operation on the **attachments** navigation property of the Outlook item; see how to do this for a message or for an event.
As part of the response, this action returns an upload URL that you can use in subsequent sequential `PUT` queries.
Request headers for each `PUT` operation let you specify the exact range of bytes to be uploaded.
This allows transfer to be resumed, in case the network connection is dropped during upload.
The following are the steps to attach a file to an Outlook item using an upload session: See attach large files to Outlook messages or events for an example.

### [New-MgUserMailFolderMessageForward](New-MgUserMailFolderMessageForward.md)
Create a draft to forward an existing message, in either JSON or MIME format.
When using JSON format, you can: \n- Specify either a comment or the **body** property of the `message` parameter.
Specifying both will return an HTTP 400 Bad Request error.\n- Specify either the `toRecipients` parameter or the **toRecipients** property of the `message` parameter.
Specifying both or specifying neither will return an HTTP 400 Bad Request error.\n- Update the draft later to add content to the **body** or change other message properties.
When using MIME format:\n- Provide the applicable Internet message headers and the MIME content, all encoded in **base64** format in the request body.\n- Add any attachments and S/MIME properties to the MIME content.
Send the draft message in a subsequent operation.
Alternatively, forward a message in a single operation.

### [New-MgUserMailFolderMessageReply](New-MgUserMailFolderMessageReply.md)
Create a draft to reply to the sender of a message in either JSON or MIME format.
When using JSON format:\n- Specify either a comment or the **body** property of the `message` parameter.
Specifying both will return an HTTP 400 Bad Request error.\n- If **replyTo** is specified in the original message, per Internet Message Format (RFC 2822), you should send the reply to the recipients in **replyTo**, and not the recipients in **from**.\n- You can update the draft later to add reply content to the **body** or change other message properties.
When using MIME format:\n- Provide the applicable Internet message headers and the MIME content, all encoded in **base64** format in the request body.\n- Add any attachments and S/MIME properties to the MIME content.
Send the draft message in a subsequent operation.
Alternatively, reply to a message in a single operation.

### [New-MgUserMailFolderMessageReplyAll](New-MgUserMailFolderMessageReplyAll.md)
Create a draft to reply to the sender and all recipients of a message in either JSON or MIME format.
When using JSON format:\n- Specify either a comment or the **body** property of the `message` parameter.
Specifying both will return an HTTP 400 Bad Request error.\n- If the original message specifies a recipient in the **replyTo** property, per Internet Message Format (RFC 2822), you should send the reply to the recipients in the **replyTo** and **toRecipients** properties, and not the recipients in the **from** and **toRecipients** properties.
\n- You can update the draft message later.
When using MIME format:\n- Provide the applicable Internet message headers and the MIME content, all encoded in **base64** format in the request body.\n- Add any attachments and S/MIME properties to the MIME content.
Send the draft message in a subsequent operation.
Alternatively, reply-all to a message in a single action.

### [New-MgUserManagedDeviceLogCollectionRequest](New-MgUserManagedDeviceLogCollectionRequest.md)
Invoke action createDeviceLogCollectionRequest

### [New-MgUserManagedDeviceLogCollectionResponseDownloadUrl](New-MgUserManagedDeviceLogCollectionResponseDownloadUrl.md)
Invoke action createDownloadUrl

### [New-MgUserManagedDeviceRemoteHelpSession](New-MgUserManagedDeviceRemoteHelpSession.md)
Remote help - Create session with a specific device

### [New-MgUserManagedDeviceWindowsDefenderUpdateSignature](New-MgUserManagedDeviceWindowsDefenderUpdateSignature.md)
Invoke action windowsDefenderUpdateSignatures

### [New-MgUserMessageAttachmentUploadSession](New-MgUserMessageAttachmentUploadSession.md)
Create an upload session that allows an app to iteratively upload ranges of a file, so as to attach the file to an Outlook item.
The item can be a message or event.
Use this approach to attach a file if the file size is between 3 MB and 150 MB.
To attach a file that's smaller than 3 MB, do a `POST` operation on the **attachments** navigation property of the Outlook item; see how to do this for a message or for an event.
As part of the response, this action returns an upload URL that you can use in subsequent sequential `PUT` queries.
Request headers for each `PUT` operation let you specify the exact range of bytes to be uploaded.
This allows transfer to be resumed, in case the network connection is dropped during upload.
The following are the steps to attach a file to an Outlook item using an upload session: See attach large files to Outlook messages or events for an example.

### [New-MgUserMessageForward](New-MgUserMessageForward.md)
Create a draft to forward an existing message, in either JSON or MIME format.
When using JSON format, you can: \n- Specify either a comment or the **body** property of the `message` parameter.
Specifying both will return an HTTP 400 Bad Request error.\n- Specify either the `toRecipients` parameter or the **toRecipients** property of the `message` parameter.
Specifying both or specifying neither will return an HTTP 400 Bad Request error.\n- Update the draft later to add content to the **body** or change other message properties.
When using MIME format:\n- Provide the applicable Internet message headers and the MIME content, all encoded in **base64** format in the request body.\n- Add any attachments and S/MIME properties to the MIME content.
Send the draft message in a subsequent operation.
Alternatively, forward a message in a single operation.

### [New-MgUserMessageReply](New-MgUserMessageReply.md)
Create a draft to reply to the sender of a message in either JSON or MIME format.
When using JSON format:\n- Specify either a comment or the **body** property of the `message` parameter.
Specifying both will return an HTTP 400 Bad Request error.\n- If **replyTo** is specified in the original message, per Internet Message Format (RFC 2822), you should send the reply to the recipients in **replyTo**, and not the recipients in **from**.\n- You can update the draft later to add reply content to the **body** or change other message properties.
When using MIME format:\n- Provide the applicable Internet message headers and the MIME content, all encoded in **base64** format in the request body.\n- Add any attachments and S/MIME properties to the MIME content.
Send the draft message in a subsequent operation.
Alternatively, reply to a message in a single operation.

### [New-MgUserMessageReplyAll](New-MgUserMessageReplyAll.md)
Create a draft to reply to the sender and all recipients of a message in either JSON or MIME format.
When using JSON format:\n- Specify either a comment or the **body** property of the `message` parameter.
Specifying both will return an HTTP 400 Bad Request error.\n- If the original message specifies a recipient in the **replyTo** property, per Internet Message Format (RFC 2822), you should send the reply to the recipients in the **replyTo** and **toRecipients** properties, and not the recipients in the **from** and **toRecipients** properties.
\n- You can update the draft message later.
When using MIME format:\n- Provide the applicable Internet message headers and the MIME content, all encoded in **base64** format in the request body.\n- Add any attachments and S/MIME properties to the MIME content.
Send the draft message in a subsequent operation.
Alternatively, reply-all to a message in a single action.

### [New-MgUserMobileAppTroubleshootingEventAppLogCollectionRequestDownloadUrl](New-MgUserMobileAppTroubleshootingEventAppLogCollectionRequestDownloadUrl.md)
Invoke action createDownloadUrl

### [New-MgUserOutlookTaskAttachmentUploadSession](New-MgUserOutlookTaskAttachmentUploadSession.md)
Create an upload session that allows an app to iteratively upload ranges of a file, so as to attach the file to an Outlook item.
The item can be a message or event.
Use this approach to attach a file if the file size is between 3 MB and 150 MB.
To attach a file that's smaller than 3 MB, do a `POST` operation on the **attachments** navigation property of the Outlook item; see how to do this for a message or for an event.
As part of the response, this action returns an upload URL that you can use in subsequent sequential `PUT` queries.
Request headers for each `PUT` operation let you specify the exact range of bytes to be uploaded.
This allows transfer to be resumed, in case the network connection is dropped during upload.
The following are the steps to attach a file to an Outlook item using an upload session: See attach large files to Outlook messages or events for an example.

### [New-MgUserOutlookTaskFolderTaskAttachmentUploadSession](New-MgUserOutlookTaskFolderTaskAttachmentUploadSession.md)
Create an upload session that allows an app to iteratively upload ranges of a file, so as to attach the file to an Outlook item.
The item can be a message or event.
Use this approach to attach a file if the file size is between 3 MB and 150 MB.
To attach a file that's smaller than 3 MB, do a `POST` operation on the **attachments** navigation property of the Outlook item; see how to do this for a message or for an event.
As part of the response, this action returns an upload URL that you can use in subsequent sequential `PUT` queries.
Request headers for each `PUT` operation let you specify the exact range of bytes to be uploaded.
This allows transfer to be resumed, in case the network connection is dropped during upload.
The following are the steps to attach a file to an Outlook item using an upload session: See attach large files to Outlook messages or events for an example.

### [New-MgUserOutlookTaskGroupTaskFolderTaskAttachmentUploadSession](New-MgUserOutlookTaskGroupTaskFolderTaskAttachmentUploadSession.md)
Create an upload session that allows an app to iteratively upload ranges of a file, so as to attach the file to an Outlook item.
The item can be a message or event.
Use this approach to attach a file if the file size is between 3 MB and 150 MB.
To attach a file that's smaller than 3 MB, do a `POST` operation on the **attachments** navigation property of the Outlook item; see how to do this for a message or for an event.
As part of the response, this action returns an upload URL that you can use in subsequent sequential `PUT` queries.
Request headers for each `PUT` operation let you specify the exact range of bytes to be uploaded.
This allows transfer to be resumed, in case the network connection is dropped during upload.
The following are the steps to attach a file to an Outlook item using an upload session: See attach large files to Outlook messages or events for an example.

### [New-MgUserTodoListTaskAttachmentUploadSession](New-MgUserTodoListTaskAttachmentUploadSession.md)
Create an upload session to iteratively upload ranges of a file as an attachment to a todoTask.
As part of the response, this action returns an upload URL that you can use in subsequent sequential `PUT` queries.
The request headers for each `PUT` operation let you specify the exact range of bytes to be uploaded.
This allows the transfer to be resumed, in case the network connection is dropped during the upload.
The following are the steps to attach a file to a Microsoft To Do task using an upload session: For an example that describes the end-to-end attachment process, see attach files to a To Do task.

### [Publish-MgUserDriveListContentType](Publish-MgUserDriveListContentType.md)
Publishes a [contentType][] present in a content type hub site.

### [Remove-MgUserDeviceFromManagement](Remove-MgUserDeviceFromManagement.md)
Retire all devices from management for this user

### [Remove-MgUserManagedDeviceFirmwareConfigurationInterfaceManagement](Remove-MgUserManagedDeviceFirmwareConfigurationInterfaceManagement.md)
Remove device from Device Firmware Configuration Interface management

### [Remove-MgUserManagedDeviceUserFromSharedAppleDevice](Remove-MgUserManagedDeviceUserFromSharedAppleDevice.md)
Delete user from shared Apple device

### [Rename-MgUserCloudPc](Rename-MgUserCloudPc.md)
Rename a specific Cloud PC.
Use this API to update the **displayName** for the Cloud PC entity.

### [Rename-MgUserCloudPcUserAccountType](Rename-MgUserCloudPcUserAccountType.md)
Change the account type of the user on a specific Cloud PC.

### [Request-MgUserManagedDeviceRemoteAssistance](Request-MgUserManagedDeviceRemoteAssistance.md)
Request remote assistance

### [Request-MgUserManagedDeviceRemoteHelpSessionAccess](Request-MgUserManagedDeviceRemoteHelpSessionAccess.md)
Remote help - Request Remote help session access permission for an existing session

### [Reset-MgUserAuthenticationMethodPassword](Reset-MgUserAuthenticationMethodPassword.md)
Invoke action resetPassword

### [Reset-MgUserManagedDevicePasscode](Reset-MgUserManagedDevicePasscode.md)
Reset passcode

### [Reset-MgUserPendingAccessReviewInstanceDecision](Reset-MgUserPendingAccessReviewInstanceDecision.md)
Resets decisions of all accessReviewInstanceDecisionItem objects on an accessReviewInstance to `notReviewed`.

### [Resize-MgUserManagedDeviceCloudPc](Resize-MgUserManagedDeviceCloudPc.md)
Upgrade or downgrade an existing Cloud PC to another configuration with a new virtual CPU (vCPU) and storage size.

### [Restart-MgUserCloudPc](Restart-MgUserCloudPc.md)
Reboot a specific Cloud PC.

### [Restart-MgUserManagedDeviceNow](Restart-MgUserManagedDeviceNow.md)
Reboot device

### [Restore-MgUserAuthenticationWindowHelloForBusinessMethodDevice](Restore-MgUserAuthenticationWindowHelloForBusinessMethodDevice.md)
Restore a recently deleted application, group, servicePrincipal, or user object from deleted items.
If an item was accidentally deleted, you can fully restore the item.
This is not applicable to security groups, which are deleted permanently.
A recently deleted item will remain available for up to 30 days.
After 30 days, the item is permanently deleted.

### [Restore-MgUserCloudPc](Restore-MgUserCloudPc.md)
Restore a specific Cloud PC.
Use this API to trigger a remote action that restores a Cloud PC device to a previous state.

### [Restore-MgUserDriveItem](Restore-MgUserDriveItem.md)
Restore a driveItem that has been deleted and is currently in the recycle bin.

### [Restore-MgUserDriveItemListItemDocumentSetVersion](Restore-MgUserDriveItemListItemDocumentSetVersion.md)
Restore a document set version.

### [Restore-MgUserDriveItemListItemVersion](Restore-MgUserDriveItemListItemVersion.md)
Invoke action restoreVersion

### [Restore-MgUserDriveItemVersion](Restore-MgUserDriveItemVersion.md)
Restore a previous version of a DriveItem to be the current version.
This will create a new version with the contents of the previous version, but preserves all existing versions of the file.

### [Restore-MgUserDriveListItemDocumentSetVersion](Restore-MgUserDriveListItemDocumentSetVersion.md)
Restore a document set version.

### [Restore-MgUserDriveListItemVersion](Restore-MgUserDriveListItemVersion.md)
Invoke action restoreVersion

### [Restore-MgUserDriveRoot](Restore-MgUserDriveRoot.md)
Restore a driveItem that has been deleted and is currently in the recycle bin.

### [Restore-MgUserDriveRootListItemDocumentSetVersion](Restore-MgUserDriveRootListItemDocumentSetVersion.md)
Restore a document set version.

### [Restore-MgUserDriveRootListItemVersion](Restore-MgUserDriveRootListItemVersion.md)
Invoke action restoreVersion

### [Restore-MgUserDriveRootVersion](Restore-MgUserDriveRootVersion.md)
Restore a previous version of a DriveItem to be the current version.
This will create a new version with the contents of the previous version, but preserves all existing versions of the file.

### [Restore-MgUserManagedDeviceCloudPc](Restore-MgUserManagedDeviceCloudPc.md)
Restore a Cloud PC device to a previous state with an Intune managed device ID.

### [Restore-MgUserManagedDevicePasscode](Restore-MgUserManagedDevicePasscode.md)
Recover passcode

### [Revoke-MgUserDriveItemPermissionGrant](Revoke-MgUserDriveItemPermissionGrant.md)
Revoke access to a [listItem][] or [driveItem][] granted via a sharing link by removing the specified [recipient][] from the link.

### [Revoke-MgUserDriveRootPermissionGrant](Revoke-MgUserDriveRootPermissionGrant.md)
Revoke access to a [listItem][] or [driveItem][] granted via a sharing link by removing the specified [recipient][] from the link.

### [Revoke-MgUserManagedDeviceAppleVppLicense](Revoke-MgUserManagedDeviceAppleVppLicense.md)
Revoke all Apple Vpp licenses for a device

### [Revoke-MgUserSignInSession](Revoke-MgUserSignInSession.md)
Invoke action revokeSignInSessions

### [Send-MgUserChatActivityNotification](Send-MgUserChatActivityNotification.md)
Send an activity feed notification in scope of a chat.
For more details about sending notifications and the requirements for doing so, see sending Teams activity notifications.

### [Send-MgUserMail](Send-MgUserMail.md)
Send the message specified in the request body using either JSON or MIME format.
When using JSON format you can include an attachment and use a mention to call out another user in the new message.
When using MIME format:\n- Provide the applicable Internet message headers and the MIME content, all encoded in **base64** format in the request body.\n- Add any attachments and S/MIME properties to the MIME content.
This method saves the message in the **Sent Items** folder.
Alternatively, create a draft message to send later.
To learn more about the steps involved in the backend before a mail is delivered to recipients, see here.

### [Send-MgUserMailFolderChildFolderMessage](Send-MgUserMailFolderChildFolderMessage.md)
Send an existing draft message.
The draft message can be a new message draft, reply draft, reply-all draft, or a forward draft.
This method saves the message in the **Sent Items** folder.
Alternatively, send a new message in a single operation.

### [Send-MgUserMailFolderMessage](Send-MgUserMailFolderMessage.md)
Send an existing draft message.
The draft message can be a new message draft, reply draft, reply-all draft, or a forward draft.
This method saves the message in the **Sent Items** folder.
Alternatively, send a new message in a single operation.

### [Send-MgUserManagedDeviceCustomNotificationToCompanyPortal](Send-MgUserManagedDeviceCustomNotificationToCompanyPortal.md)
Invoke action sendCustomNotificationToCompanyPortal

### [Send-MgUserMessage](Send-MgUserMessage.md)
Send an existing draft message.
The draft message can be a new message draft, reply draft, reply-all draft, or a forward draft.
This method saves the message in the **Sent Items** folder.
Alternatively, send a new message in a single operation.

### [Send-MgUserPendingAccessReviewInstanceReminder](Send-MgUserPendingAccessReviewInstanceReminder.md)
Send a reminder to the reviewers of a currently active accessReviewInstance.

### [Send-MgUserTeamworkActivityNotification](Send-MgUserTeamworkActivityNotification.md)
Send an activity feed notification to a user.
For more details about sending notifications and the requirements for doing so, see sending Teams activity notifications.

### [Set-MgUserChatMessageReaction](Set-MgUserChatMessageReaction.md)
Invoke action setReaction

### [Set-MgUserChatMessageReplyReaction](Set-MgUserChatMessageReplyReaction.md)
Invoke action setReaction

### [Set-MgUserDeviceEnrollmentConfiguration](Set-MgUserDeviceEnrollmentConfiguration.md)
Invoke action assign

### [Set-MgUserDeviceEnrollmentConfigurationPriority](Set-MgUserDeviceEnrollmentConfigurationPriority.md)
Invoke action setPriority

### [Set-MgUserDriveItemSensitivityLabel](Set-MgUserDriveItemSensitivityLabel.md)
Invoke action assignSensitivityLabel

### [Set-MgUserDriveRootSensitivityLabel](Set-MgUserDriveRootSensitivityLabel.md)
Invoke action assignSensitivityLabel

### [Set-MgUserLicense](Set-MgUserLicense.md)
Add or remove licenses for the user to enable or disable their use of Microsoft cloud offerings.
For example, an organization can have a Microsoft 365 Enterprise E3 subscription with 100 licenses, and this request assigns one of those licenses to a specific user.
You can also enable and disable specific plans associated with a subscription.
To learn more about subscriptions and licenses, see this Technet article.
To get the subscriptions available in the directory, perform a GET subscribedSkus request.

### [Set-MgUserManagedDeviceCloudPcReviewStatus](Set-MgUserManagedDeviceCloudPcReviewStatus.md)
Set the review status of a specific Cloud PC device.
Use this API to set the review status of a Cloud PC to in review if you consider a Cloud PC as suspicious.
After the review is completed, use this API again to set the Cloud PC back to a normal state.

### [Set-MgUserManagedDeviceName](Set-MgUserManagedDeviceName.md)
Set device name of the device.

### [Set-MgUserPresence](Set-MgUserPresence.md)
Set the availability and activity status in a presence session of an application for a user.

### [Set-MgUserPresenceUserPreferredPresence](Set-MgUserPresenceUserPreferredPresence.md)
Set the preferred availability and activity status for a user.
If the preferred presence of a user is set, the user's presence is the preferred presence.
Preferred presence takes effect only when there is at least one presence session of the user.
Otherwise, the user's presence stays as Offline.
A presence session can be created as a result of a successful setPresence operation, or if the user is signed in on a Teams client.
Read more about presence sessions and their time-out and expiration.

### [Skip-MgUserManagedDeviceActivationLock](Skip-MgUserManagedDeviceActivationLock.md)
Bypass activation lock

### [Start-MgUserManagedDeviceConfigurationManagerAction](Start-MgUserManagedDeviceConfigurationManagerAction.md)
Trigger action on ConfigurationManager client

### [Stop-MgUserCloudPcGracePeriod](Stop-MgUserCloudPcGracePeriod.md)
End the grace period for a specific Cloud PC.
The grace period is triggered when the Cloud PC license is removed or the provisioning policy is unassigned.
It allows users to access Cloud PCs for up to seven days before de-provisioning occurs.
Ending the grace period immediately deprovisions the Cloud PC without waiting the seven days.

### [Stop-MgUserEvent](Stop-MgUserEvent.md)
This action allows the organizer of a meeting to send a cancellation message and cancel the event.
The action moves the event to the Deleted Items folder.
The organizer can also cancel an occurrence of a recurring meeting \nby providing the occurrence event ID.
An attendee calling this action gets an error (HTTP 400 Bad Request), with the following\nerror message: 'Your request can't be completed.
You need to be an organizer to cancel a meeting.' This action differs from Delete in that **Cancel** is available to only the organizer, and lets\nthe organizer send a custom message to the attendees about the cancellation.

### [Stop-MgUserEventInstance](Stop-MgUserEventInstance.md)
This action allows the organizer of a meeting to send a cancellation message and cancel the event.
The action moves the event to the Deleted Items folder.
The organizer can also cancel an occurrence of a recurring meeting \nby providing the occurrence event ID.
An attendee calling this action gets an error (HTTP 400 Bad Request), with the following\nerror message: 'Your request can't be completed.
You need to be an organizer to cancel a meeting.' This action differs from Delete in that **Cancel** is available to only the organizer, and lets\nthe organizer send a custom message to the attendees about the cancellation.

### [Stop-MgUserPendingAccessReviewInstance](Stop-MgUserPendingAccessReviewInstance.md)
Stop a currently active accessReviewInstance.
After the access review instance stops, the instance status will be `Completed`, the reviewers can no longer give input, and the access review decisions can be applied.
Stopping an instance will not effect future instances.
To prevent a recurring access review from starting future instances, update the schedule definition to change its scheduled end date.

### [Stop-MgUserPendingAccessReviewInstanceStage](Stop-MgUserPendingAccessReviewInstanceStage.md)
Stop an access review stage that is `inProgress`.
After the access review stage stops, the stage **status** will be `Completed` and the reviewers can no longer give input.
If there are subsequent stages that depend on the completed stage, the next stage will be created.
The accessReviewInstanceDecisionItem objects will always reflect the last decisions recorded across all stages at that given time, regardless of the status of the stages.

### [Sync-MgUserManagedDevice](Sync-MgUserManagedDevice.md)
Invoke action syncDevice

### [Test-MgUserChatPermissionGrantProperty](Test-MgUserChatPermissionGrantProperty.md)
Validate that a Microsoft 365 group's display name or mail nickname complies with naming policies.
Clients can use this API to determine whether a display name or mail nickname is valid before trying to **create** a Microsoft 365 group.
For validating properties of an existing group, use the validateProperties function for groups.
The following validations are performed for the display name and mail nickname properties: \n1.
Validate the prefix and suffix naming policy\n2.
Validate the custom banned words policy\n3.
Validate the mail nickname is unique This API returns with the first failure encountered.
If one or more properties fail multiple validations, only the property with the first validation failure is returned.
However, you can validate both the mail nickname and the display name and receive a collection of validation errors if you are only validating the prefix and suffix naming policy.

### [Test-MgUserDeviceProperty](Test-MgUserDeviceProperty.md)
Validate that a Microsoft 365 group's display name or mail nickname complies with naming policies.
Clients can use this API to determine whether a display name or mail nickname is valid before trying to **create** a Microsoft 365 group.
For validating properties of an existing group, use the validateProperties function for groups.
The following validations are performed for the display name and mail nickname properties: \n1.
Validate the prefix and suffix naming policy\n2.
Validate the custom banned words policy\n3.
Validate the mail nickname is unique This API returns with the first failure encountered.
If one or more properties fail multiple validations, only the property with the first validation failure is returned.
However, you can validate both the mail nickname and the display name and receive a collection of validation errors if you are only validating the prefix and suffix naming policy.

### [Test-MgUserDriveItemPermission](Test-MgUserDriveItemPermission.md)
Invoke action validatePermission

### [Test-MgUserDriveRootPermission](Test-MgUserDriveRootPermission.md)
Invoke action validatePermission

### [Test-MgUserInformationProtectionDataLossPreventionPolicy](Test-MgUserInformationProtectionDataLossPreventionPolicy.md)
Invoke action evaluate

### [Test-MgUserInformationProtectionPolicyLabelApplication](Test-MgUserInformationProtectionPolicyLabelApplication.md)
Compute the information protection label that should be applied and return the set of actions that must be taken to correctly label the information.
This API is useful when a label should be set manually or explicitly by a user or service, rather than automatically based on file contents.
Given contentInfo, which includes existing content metadata key/value pairs, and labelingOptions as an input, the API returns an informationProtectionAction object that contains one of more of the following:

### [Test-MgUserInformationProtectionPolicyLabelClassificationResult](Test-MgUserInformationProtectionPolicyLabelClassificationResult.md)
Using classification results, compute the information protection label that should be applied and return the set of actions that must be taken to correctly label the information.
This API is useful when a label should be set automatically based on classification of the file contents, rather than labeled directly by a user or service.
To evaluate based on classification results, provide contentInfo, which includes existing content metadata key/value pairs, and classification results.
The API returns an informationProtectionAction that contains one of more of the following:

### [Test-MgUserInformationProtectionPolicyLabelRemoval](Test-MgUserInformationProtectionPolicyLabelRemoval.md)
Indicate to the consuming application what actions it should take to remove the label information.
Given contentInfo as an input, which includes existing content metadata key/value pairs, the API returns an informationProtectionAction that contains some combination of one of more of the following:

### [Test-MgUserInformationProtectionSensitivityLabel](Test-MgUserInformationProtectionSensitivityLabel.md)
Invoke action evaluate

### [Test-MgUserInformationProtectionSensitivityLabelSublabel](Test-MgUserInformationProtectionSensitivityLabelSublabel.md)
Invoke action evaluate

### [Test-MgUserJoinedGroupDynamicMembership](Test-MgUserJoinedGroupDynamicMembership.md)
Evaluate whether a user or device is or would be a member of a dynamic group.
The membership rule is returned along with other details that were used in the evaluation.
You can complete this operation in the following ways:

### [Test-MgUserJoinedGroupProperty](Test-MgUserJoinedGroupProperty.md)
Validate that a Microsoft 365 group's display name or mail nickname complies with naming policies.
Clients can use this API to determine whether a display name or mail nickname is valid before trying to **create** a Microsoft 365 group.
For validating properties of an existing group, use the validateProperties function for groups.
The following validations are performed for the display name and mail nickname properties: \n1.
Validate the prefix and suffix naming policy\n2.
Validate the custom banned words policy\n3.
Validate the mail nickname is unique This API returns with the first failure encountered.
If one or more properties fail multiple validations, only the property with the first validation failure is returned.
However, you can validate both the mail nickname and the display name and receive a collection of validation errors if you are only validating the prefix and suffix naming policy.

### [Test-MgUserPassword](Test-MgUserPassword.md)
Check a user's password against the organization's password validation policy and report whether the password is valid.
Use this action to provide real-time feedback on password strength while the user types their password.

### [Test-MgUserProperty](Test-MgUserProperty.md)
Validate that a Microsoft 365 group's display name or mail nickname complies with naming policies.
Clients can use this API to determine whether a display name or mail nickname is valid before trying to **create** a Microsoft 365 group.
For validating properties of an existing group, use the validateProperties function for groups.
The following validations are performed for the display name and mail nickname properties: \n1.
Validate the prefix and suffix naming policy\n2.
Validate the custom banned words policy\n3.
Validate the mail nickname is unique This API returns with the first failure encountered.
If one or more properties fail multiple validations, only the property with the first validation failure is returned.
However, you can validate both the mail nickname and the display name and receive a collection of validation errors if you are only validating the prefix and suffix naming policy.

### [Test-MgUserSecurityInformationProtectionSensitivityLabelApplication](Test-MgUserSecurityInformationProtectionSensitivityLabelApplication.md)
Invoke action evaluateApplication

### [Test-MgUserSecurityInformationProtectionSensitivityLabelClassificationResult](Test-MgUserSecurityInformationProtectionSensitivityLabelClassificationResult.md)
Invoke action evaluateClassificationResults

### [Test-MgUserSecurityInformationProtectionSensitivityLabelRemoval](Test-MgUserSecurityInformationProtectionSensitivityLabelRemoval.md)
Invoke action evaluateRemoval

### [Unblock-MgUserManagedApp](Unblock-MgUserManagedApp.md)
Unblocks the managed app user from app check-in.

### [Undo-MgUserChatMessageReplySoftDelete](Undo-MgUserChatMessageReplySoftDelete.md)
Undo soft deletion of a single message or a message reply in a channel or a chat.

### [Undo-MgUserChatMessageSoftDelete](Undo-MgUserChatMessageSoftDelete.md)
Undo soft deletion of a single message or a message reply in a channel or a chat.

### [Unpublish-MgUserDriveListContentType](Unpublish-MgUserDriveListContentType.md)
Unpublish a [contentType][] from a content type hub site.

### [Update-MgUserChatInstalledApp](Update-MgUserChatInstalledApp.md)
Upgrade an app installation within a chat.

### [Update-MgUserManagedDeviceWindowDeviceAccount](Update-MgUserManagedDeviceWindowDeviceAccount.md)
Invoke action updateWindowsDeviceAccount

### [Update-MgUserOnenotePageContent](Update-MgUserOnenotePageContent.md)
Invoke action onenotePatchContent

### [Update-MgUserPassword](Update-MgUserPassword.md)
Enable the user to update their password.
Any user can update their password without belonging to any administrator role.

