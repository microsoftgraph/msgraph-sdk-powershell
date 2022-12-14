---
Module Name: Microsoft.Graph.Beta.Users.Actions
Module Guid: 4bf63061-7c8d-48a3-9409-6aa1db92615e
Download Help Link: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.Beta.users.actions
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Beta.Users.Actions Module
## Description
Microsoft.Graph.Beta PowerShell Cmdlets

## Microsoft.Graph.Beta.Users.Actions Cmdlets
### [Add-MgBetaUserChatMember](Add-MgBetaUserChatMember.md)
Add multiple members in a single request to a team.
The response provides details about which memberships could and couldn't be created.

### [Add-MgBetaUserDriveListContentTypeCopy](Add-MgBetaUserDriveListContentTypeCopy.md)
Add a copy of a [content type][contentType] from a [site][site] to a [list][list].

### [Add-MgBetaUserDriveListContentTypeCopyFromContentTypeHub](Add-MgBetaUserDriveListContentTypeCopyFromContentTypeHub.md)
Add or sync a copy of a published content type from the content type hub to a target site or a list.
This method is part of the content type publishing changes to optimize the syncing of published content types to sites and lists, effectively switching from a 'push everywhere' to 'pull as needed' approach.
The method allows users to pull content types directly from the content type hub to a site or list.
For more information, see getCompatibleHubContentTypes and the blog post Syntex Product Updates – August 2021.

### [Add-MgBetaUserPendingAccessReviewInstanceDecision](Add-MgBetaUserPendingAccessReviewInstanceDecision.md)
Apply review decisions on an accessReviewInstance if the decisions were not applied automatically because the autoApplyDecisionsEnabled property is `false` in the review's accessReviewScheduleSettings.
The status of the accessReviewInstance must be `Completed` to call this method.

### [Clear-MgBetaUserAndBlockManagedApp](Clear-MgBetaUserAndBlockManagedApp.md)
Blocks the managed app user from app check-in.

### [Clear-MgBetaUserChatMessageReaction](Clear-MgBetaUserChatMessageReaction.md)
Invoke action unsetReaction

### [Clear-MgBetaUserChatMessageReplyReaction](Clear-MgBetaUserChatMessageReplyReaction.md)
Invoke action unsetReaction

### [Clear-MgBetaUserManagedAppRegistrationByAzureAdDeviceId](Clear-MgBetaUserManagedAppRegistrationByAzureAdDeviceId.md)
Issues a wipe operation on an app registration with specified aad device Id.

### [Clear-MgBetaUserManagedAppRegistrationByDeviceTag](Clear-MgBetaUserManagedAppRegistrationByDeviceTag.md)
Issues a wipe operation on an app registration with specified device tag.

### [Clear-MgBetaUserManagedDevice](Clear-MgBetaUserManagedDevice.md)
Wipe a device

### [Clear-MgBetaUserPresence](Clear-MgBetaUserPresence.md)
Clear a presence session of an application for a user.
If it is the user's only presence session, a successful **clearPresence** changes the user's presence to `Offline/Offline`.
Read more about presence sessions and their time-out and expiration.

### [Clear-MgBetaUserPresenceUserPreferredPresence](Clear-MgBetaUserPresenceUserPreferredPresence.md)
Clear the preferred availability and activity status for a user.

### [Complete-MgBetaUserOutlookTask](Complete-MgBetaUserOutlookTask.md)
Invoke action complete

### [Complete-MgBetaUserOutlookTaskFolderTask](Complete-MgBetaUserOutlookTaskFolderTask.md)
Invoke action complete

### [Complete-MgBetaUserOutlookTaskGroupTaskFolderTask](Complete-MgBetaUserOutlookTaskGroupTaskFolderTask.md)
Invoke action complete

### [Confirm-MgBetaUserAuthenticationMicrosoftAuthenticatorMethodDeviceMemberGroup](Confirm-MgBetaUserAuthenticationMicrosoftAuthenticatorMethodDeviceMemberGroup.md)
Check for membership in a specified list of group IDs, and return from that list those groups (identified by IDs) of which the specified user, group, service principal, organizational contact, device, or directory object is a member.
This function is transitive.
You can check up to a maximum of 20 groups per request.
This function supports all groups provisioned in Azure AD.
Because Microsoft 365 groups cannot contain other groups, membership in a Microsoft 365 group is always direct.

### [Confirm-MgBetaUserAuthenticationMicrosoftAuthenticatorMethodDeviceMemberObject](Confirm-MgBetaUserAuthenticationMicrosoftAuthenticatorMethodDeviceMemberObject.md)
Invoke action checkMemberObjects

### [Confirm-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceMemberGroup](Confirm-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceMemberGroup.md)
Check for membership in a specified list of group IDs, and return from that list those groups (identified by IDs) of which the specified user, group, service principal, organizational contact, device, or directory object is a member.
This function is transitive.
You can check up to a maximum of 20 groups per request.
This function supports all groups provisioned in Azure AD.
Because Microsoft 365 groups cannot contain other groups, membership in a Microsoft 365 group is always direct.

### [Confirm-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceMemberObject](Confirm-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceMemberObject.md)
Invoke action checkMemberObjects

### [Confirm-MgBetaUserAuthenticationWindowHelloForBusinessMethodDeviceMemberGroup](Confirm-MgBetaUserAuthenticationWindowHelloForBusinessMethodDeviceMemberGroup.md)
Check for membership in a specified list of group IDs, and return from that list those groups (identified by IDs) of which the specified user, group, service principal, organizational contact, device, or directory object is a member.
This function is transitive.
You can check up to a maximum of 20 groups per request.
This function supports all groups provisioned in Azure AD.
Because Microsoft 365 groups cannot contain other groups, membership in a Microsoft 365 group is always direct.

### [Confirm-MgBetaUserAuthenticationWindowHelloForBusinessMethodDeviceMemberObject](Confirm-MgBetaUserAuthenticationWindowHelloForBusinessMethodDeviceMemberObject.md)
Invoke action checkMemberObjects

### [Confirm-MgBetaUserChatPermissionGrantMemberGroup](Confirm-MgBetaUserChatPermissionGrantMemberGroup.md)
Check for membership in a specified list of group IDs, and return from that list those groups (identified by IDs) of which the specified user, group, service principal, organizational contact, device, or directory object is a member.
This function is transitive.
You can check up to a maximum of 20 groups per request.
This function supports all groups provisioned in Azure AD.
Because Microsoft 365 groups cannot contain other groups, membership in a Microsoft 365 group is always direct.

### [Confirm-MgBetaUserChatPermissionGrantMemberObject](Confirm-MgBetaUserChatPermissionGrantMemberObject.md)
Invoke action checkMemberObjects

### [Confirm-MgBetaUserDeviceMemberGroup](Confirm-MgBetaUserDeviceMemberGroup.md)
Check for membership in a specified list of group IDs, and return from that list those groups (identified by IDs) of which the specified user, group, service principal, organizational contact, device, or directory object is a member.
This function is transitive.
You can check up to a maximum of 20 groups per request.
This function supports all groups provisioned in Azure AD.
Because Microsoft 365 groups cannot contain other groups, membership in a Microsoft 365 group is always direct.

### [Confirm-MgBetaUserDeviceMemberObject](Confirm-MgBetaUserDeviceMemberObject.md)
Invoke action checkMemberObjects

### [Confirm-MgBetaUserInformationProtectionSignature](Confirm-MgBetaUserInformationProtectionSignature.md)
Invoke action verifySignature

### [Confirm-MgBetaUserMemberGroup](Confirm-MgBetaUserMemberGroup.md)
Check for membership in a specified list of group IDs, and return from that list those groups (identified by IDs) of which the specified user, group, service principal, organizational contact, device, or directory object is a member.
This function is transitive.
You can check up to a maximum of 20 groups per request.
This function supports all groups provisioned in Azure AD.
Because Microsoft 365 groups cannot contain other groups, membership in a Microsoft 365 group is always direct.

### [Confirm-MgBetaUserMemberObject](Confirm-MgBetaUserMemberObject.md)
Invoke action checkMemberObjects

### [Copy-MgBetaUserDriveItem](Copy-MgBetaUserDriveItem.md)
Asynchronously creates a copy of an [driveItem][item-resource] (including any children), under a new parent item or with a new name.

### [Copy-MgBetaUserDriveListContentTypeToDefaultContentLocation](Copy-MgBetaUserDriveListContentTypeToDefaultContentLocation.md)
Copy a file to a default content location in a [content type][contentType].
The file can then be added as a default file or template via a POST operation.

### [Copy-MgBetaUserDriveRoot](Copy-MgBetaUserDriveRoot.md)
Asynchronously creates a copy of an [driveItem][item-resource] (including any children), under a new parent item or with a new name.

### [Copy-MgBetaUserMailFolder](Copy-MgBetaUserMailFolder.md)
Copy a mailfolder and its contents to another mailfolder.

### [Copy-MgBetaUserMailFolderChildFolder](Copy-MgBetaUserMailFolderChildFolder.md)
Copy a mailfolder and its contents to another mailfolder.

### [Copy-MgBetaUserMailFolderChildFolderMessage](Copy-MgBetaUserMailFolderChildFolderMessage.md)
Copy a message to a folder within the user's mailbox.

### [Copy-MgBetaUserMailFolderMessage](Copy-MgBetaUserMailFolderMessage.md)
Copy a message to a folder within the user's mailbox.

### [Copy-MgBetaUserMessage](Copy-MgBetaUserMessage.md)
Copy a message to a folder within the user's mailbox.

### [Copy-MgBetaUserOnenoteNotebook](Copy-MgBetaUserOnenoteNotebook.md)
Copies a notebook to the Notebooks folder in the destination Documents library.
The folder is created if it doesn't exist.
For Copy operations, you follow an asynchronous calling pattern:  First call the Copy action, and then poll the operation endpoint for the result.

### [Copy-MgBetaUserOnenotePageToSection](Copy-MgBetaUserOnenotePageToSection.md)
Copy a page to a specific section.
For copy operations, you follow an asynchronous calling pattern:  First call the Copy action, and then poll the operation endpoint for the result.

### [Copy-MgBetaUserOnenoteSectionToNotebook](Copy-MgBetaUserOnenoteSectionToNotebook.md)
Copies a section to a specific notebook.
For Copy operations, you follow an asynchronous calling pattern:  First call the Copy action, and then poll the operation endpoint for the result.

### [Copy-MgBetaUserOnenoteSectionToSectionGroup](Copy-MgBetaUserOnenoteSectionToSectionGroup.md)
Copies a section to a specific section group.
For Copy operations, you follow an asynchronous calling pattern:  First call the Copy action, and then poll the operation endpoint for the result.

### [Disable-MgBetaUserAuthenticationMethodSmsSignIn](Disable-MgBetaUserAuthenticationMethodSmsSignIn.md)
Invoke action disableSmsSignIn

### [Disable-MgBetaUserManagedDevice](Disable-MgBetaUserManagedDevice.md)
Invoke action disable

### [Disable-MgBetaUserManagedDeviceLostMode](Disable-MgBetaUserManagedDeviceLostMode.md)
Disable lost mode

### [Enable-MgBetaUserAuthenticationMethodSmsSignIn](Enable-MgBetaUserAuthenticationMethodSmsSignIn.md)
Invoke action enableSmsSignIn

### [Enable-MgBetaUserManagedDeviceLostMode](Enable-MgBetaUserManagedDeviceLostMode.md)
Enable lost mode

### [Export-MgBetaUserPersonalData](Export-MgBetaUserPersonalData.md)
Submit a data policy operation request from a company administrator or an application to export an organizational user's data.
This data includes the user's data stored in OneDrive and their activity reports.
For more guidance about exporting data while complying with regulations, see Data Subject Requests and the GDPR and CCPA.

### [Find-MgBetaUserManagedDevice](Find-MgBetaUserManagedDevice.md)
Locate a device

### [Find-MgBetaUserMeetingTime](Find-MgBetaUserMeetingTime.md)
Suggest meeting times and locations based on organizer and attendee availability, and time or location constraints specified as parameters.
If **findMeetingTimes** cannot return any meeting suggestions, the response would indicate a reason in the **emptySuggestionsReason** property.
\nBased on this value, you can better adjust the parameters and call **findMeetingTimes** again.
The algorithm used to suggest meeting times and locations undergoes fine-tuning from time to time.
In scenarios like test environments where the input parameters and calendar data remain static, expect that the suggested results may differ over time.

### [Get-MgBetaUserAuthenticationMicrosoftAuthenticatorMethodDeviceMemberGroup](Get-MgBetaUserAuthenticationMicrosoftAuthenticatorMethodDeviceMemberGroup.md)
Return all the group IDs for the groups that the specified user, group, service principal, organizational contact, device, or directory object is a member of.
This function is transitive.

### [Get-MgBetaUserAuthenticationMicrosoftAuthenticatorMethodDeviceMemberObject](Get-MgBetaUserAuthenticationMicrosoftAuthenticatorMethodDeviceMemberObject.md)
Invoke action getMemberObjects

### [Get-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceMemberGroup](Get-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceMemberGroup.md)
Return all the group IDs for the groups that the specified user, group, service principal, organizational contact, device, or directory object is a member of.
This function is transitive.

### [Get-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceMemberObject](Get-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDeviceMemberObject.md)
Invoke action getMemberObjects

### [Get-MgBetaUserAuthenticationWindowHelloForBusinessMethodDeviceMemberGroup](Get-MgBetaUserAuthenticationWindowHelloForBusinessMethodDeviceMemberGroup.md)
Return all the group IDs for the groups that the specified user, group, service principal, organizational contact, device, or directory object is a member of.
This function is transitive.

### [Get-MgBetaUserAuthenticationWindowHelloForBusinessMethodDeviceMemberObject](Get-MgBetaUserAuthenticationWindowHelloForBusinessMethodDeviceMemberObject.md)
Invoke action getMemberObjects

### [Get-MgBetaUserById](Get-MgBetaUserById.md)
Return the directory objects specified in a list of IDs.
Some common uses for this function are to:

### [Get-MgBetaUserCalendarSchedule](Get-MgBetaUserCalendarSchedule.md)
Get the free/busy availability information for a collection of users, distributions lists, or resources (rooms or equipment) for a specified time period.

### [Get-MgBetaUserChatPermissionGrantById](Get-MgBetaUserChatPermissionGrantById.md)
Return the directory objects specified in a list of IDs.
Some common uses for this function are to:

### [Get-MgBetaUserChatPermissionGrantMemberGroup](Get-MgBetaUserChatPermissionGrantMemberGroup.md)
Return all the group IDs for the groups that the specified user, group, service principal, organizational contact, device, or directory object is a member of.
This function is transitive.

### [Get-MgBetaUserChatPermissionGrantMemberObject](Get-MgBetaUserChatPermissionGrantMemberObject.md)
Invoke action getMemberObjects

### [Get-MgBetaUserChatPermissionGrantUserOwnedObject](Get-MgBetaUserChatPermissionGrantUserOwnedObject.md)
Invoke action getUserOwnedObjects

### [Get-MgBetaUserDefaultCalendarSchedule](Get-MgBetaUserDefaultCalendarSchedule.md)
Get the free/busy availability information for a collection of users, distributions lists, or resources (rooms or equipment) for a specified time period.

### [Get-MgBetaUserDeviceById](Get-MgBetaUserDeviceById.md)
Return the directory objects specified in a list of IDs.
Some common uses for this function are to:

### [Get-MgBetaUserDeviceMemberGroup](Get-MgBetaUserDeviceMemberGroup.md)
Return all the group IDs for the groups that the specified user, group, service principal, organizational contact, device, or directory object is a member of.
This function is transitive.

### [Get-MgBetaUserDeviceMemberObject](Get-MgBetaUserDeviceMemberObject.md)
Invoke action getMemberObjects

### [Get-MgBetaUserDeviceUserOwnedObject](Get-MgBetaUserDeviceUserOwnedObject.md)
Invoke action getUserOwnedObjects

### [Get-MgBetaUserJoinedGroupById](Get-MgBetaUserJoinedGroupById.md)
Return the directory objects specified in a list of IDs.
Some common uses for this function are to:

### [Get-MgBetaUserJoinedGroupUserOwnedObject](Get-MgBetaUserJoinedGroupUserOwnedObject.md)
Invoke action getUserOwnedObjects

### [Get-MgBetaUserMailTip](Get-MgBetaUserMailTip.md)
Get the MailTips of one or more recipients as available to the signed-in user.
Note that by making a `POST` call to the `getMailTips` action, you can request specific types of MailTips to \nbe returned for more than one recipient at one time.
The requested MailTips are returned in a mailTips collection.

### [Get-MgBetaUserMemberGroup](Get-MgBetaUserMemberGroup.md)
Return all the group IDs for the groups that the specified user, group, service principal, organizational contact, device, or directory object is a member of.
This function is transitive.

### [Get-MgBetaUserMemberObject](Get-MgBetaUserMemberObject.md)
Invoke action getMemberObjects

### [Get-MgBetaUserOnenoteNotebookFromWebUrl](Get-MgBetaUserOnenoteNotebookFromWebUrl.md)
Retrieve the properties and relationships of a notebook object by using its URL path.
The location can be user notebooks on Microsoft 365, group notebooks, or SharePoint site-hosted team notebooks on Microsoft 365.

### [Get-MgBetaUserOwnedObjectByType](Get-MgBetaUserOwnedObjectByType.md)
Invoke action getUserOwnedObjects

### [Grant-MgBetaUserDriveItemPermission](Grant-MgBetaUserDriveItemPermission.md)
Grant users access to a link represented by a [permission][].

### [Grant-MgBetaUserDriveRootPermission](Grant-MgBetaUserDriveRootPermission.md)
Grant users access to a link represented by a [permission][].

### [Hide-MgBetaUserChatForUser](Hide-MgBetaUserChatForUser.md)
Hide a chat for a user.

### [Initialize-MgBetaUserManagedDeviceEsim](Initialize-MgBetaUserManagedDeviceEsim.md)
Activate eSIM on the device.

### [Initialize-MgBetaUserServicePlan](Initialize-MgBetaUserServicePlan.md)
Activate a service plan with a given `servicePlanId` and `skuId` for a given user.

### [Invoke-MgBetaAcceptUserEvent](Invoke-MgBetaAcceptUserEvent.md)
Accept the specified event in a user calendar.

### [Invoke-MgBetaAcceptUserEventInstance](Invoke-MgBetaAcceptUserEventInstance.md)
Accept the specified event in a user calendar.

### [Invoke-MgBetaAcceptUserEventInstanceTentatively](Invoke-MgBetaAcceptUserEventInstanceTentatively.md)
Tentatively accept the specified event in a user calendar.
If the event allows proposals for new times, on responding tentative to the event, an invitee can choose to suggest an alternative time by including the **proposedNewTime** parameter.
For more information on how to propose a time, and how to receive and accept a new time proposal, see Propose new meeting times.

### [Invoke-MgBetaAcceptUserEventTentatively](Invoke-MgBetaAcceptUserEventTentatively.md)
Tentatively accept the specified event in a user calendar.
If the event allows proposals for new times, on responding tentative to the event, an invitee can choose to suggest an alternative time by including the **proposedNewTime** parameter.
For more information on how to propose a time, and how to receive and accept a new time proposal, see Propose new meeting times.

### [Invoke-MgBetaAcceptUserPendingAccessReviewInstanceRecommendation](Invoke-MgBetaAcceptUserPendingAccessReviewInstanceRecommendation.md)
Allows the acceptance of recommendations on all accessReviewInstanceDecisionItem objects that have not been reviewed for an accessReviewInstance object for which the calling user is a reviewer.
Recommendations are generated if **recommendationsEnabled** is `true` on the accessReviewScheduleDefinition object.
If there is not a recommendation on an accessReviewInstanceDecisionItem object no decision will be recorded.

### [Invoke-MgBetaBatchUserPendingAccessReviewInstanceRecordDecision](Invoke-MgBetaBatchUserPendingAccessReviewInstanceRecordDecision.md)
Enables reviewers to review all accessReviewInstanceDecisionItem objects in batches by using **principalId**, **resourceId**, or neither.

### [Invoke-MgBetaBufferUserInformationProtectionDecrypt](Invoke-MgBetaBufferUserInformationProtectionDecrypt.md)
Invoke action decryptBuffer

### [Invoke-MgBetaBufferUserInformationProtectionEncrypt](Invoke-MgBetaBufferUserInformationProtectionEncrypt.md)
Invoke action encryptBuffer

### [Invoke-MgBetaBulkReprovisionUserManagedDeviceCloudPc](Invoke-MgBetaBulkReprovisionUserManagedDeviceCloudPc.md)
Bulk reprovision a set of Cloud PC devices with Intune managed device IDs.

### [Invoke-MgBetaBulkRestoreUserManagedDeviceCloudPc](Invoke-MgBetaBulkRestoreUserManagedDeviceCloudPc.md)
Restore multiple Cloud PC devices with a single request that includes the IDs of Intune managed devices and a restore point date and time.

### [Invoke-MgBetaBulkUserManagedDeviceSetCloudPcReviewStatus](Invoke-MgBetaBulkUserManagedDeviceSetCloudPcReviewStatus.md)
Set the review status of multiple Cloud PC devices with a single request that includes the IDs of Intune managed devices.

### [Invoke-MgBetaCheckinUserDriveItem](Invoke-MgBetaCheckinUserDriveItem.md)
Check in a checked out **driveItem** resource, which makes the version of the document available to others.

### [Invoke-MgBetaCheckinUserDriveRoot](Invoke-MgBetaCheckinUserDriveRoot.md)
Check in a checked out **driveItem** resource, which makes the version of the document available to others.

### [Invoke-MgBetaCheckoutUserDriveItem](Invoke-MgBetaCheckoutUserDriveItem.md)
Check out a **driveItem** resource to prevent others from editing the document, and prevent your changes from being visible until the documented is checked in.

### [Invoke-MgBetaCheckoutUserDriveRoot](Invoke-MgBetaCheckoutUserDriveRoot.md)
Check out a **driveItem** resource to prevent others from editing the document, and prevent your changes from being visible until the documented is checked in.

### [Invoke-MgBetaCleanUserManagedDeviceWindowDevice](Invoke-MgBetaCleanUserManagedDeviceWindowDevice.md)
Clean Windows device

### [Invoke-MgBetaCreateOrGetUserOnlineMeeting](Invoke-MgBetaCreateOrGetUserOnlineMeeting.md)
Create an onlineMeeting object with a custom specified external ID.
If the external ID already exists, this API will return the onlineMeeting object with that external ID.

### [Invoke-MgBetaDeclineUserEvent](Invoke-MgBetaDeclineUserEvent.md)
Decline invitation to the specified event in a user calendar.
If the event allows proposals for new times, on declining the event, an invitee can choose to suggest an alternative time by including the **proposedNewTime** parameter.
For more information on how to propose a time, and how to receive and accept a new time proposal, see Propose new meeting times.

### [Invoke-MgBetaDeclineUserEventInstance](Invoke-MgBetaDeclineUserEventInstance.md)
Decline invitation to the specified event in a user calendar.
If the event allows proposals for new times, on declining the event, an invitee can choose to suggest an alternative time by including the **proposedNewTime** parameter.
For more information on how to propose a time, and how to receive and accept a new time proposal, see Propose new meeting times.

### [Invoke-MgBetaDeprovisionUserManagedDevice](Invoke-MgBetaDeprovisionUserManagedDevice.md)
Invoke action deprovision

### [Invoke-MgBetaDismissUserEventInstanceReminder](Invoke-MgBetaDismissUserEventInstanceReminder.md)
Dismiss a reminder that has been triggered for an event in a user calendar.

### [Invoke-MgBetaDismissUserEventReminder](Invoke-MgBetaDismissUserEventReminder.md)
Dismiss a reminder that has been triggered for an event in a user calendar.

### [Invoke-MgBetaDownloadUserManagedDeviceAppDiagnostic](Invoke-MgBetaDownloadUserManagedDeviceAppDiagnostic.md)
Invoke action downloadAppDiagnostics

### [Invoke-MgBetaDownUserManagedDeviceShut](Invoke-MgBetaDownUserManagedDeviceShut.md)
Shut down device

### [Invoke-MgBetaEnrollUserManagedDeviceNowAction](Invoke-MgBetaEnrollUserManagedDeviceNowAction.md)
Trigger comanagement enrollment action on ConfigurationManager client

### [Invoke-MgBetaExecuteUserManagedDeviceAction](Invoke-MgBetaExecuteUserManagedDeviceAction.md)
Invoke action executeAction

### [Invoke-MgBetaExtractUserDriveItemSensitivityLabel](Invoke-MgBetaExtractUserDriveItemSensitivityLabel.md)
Invoke action extractSensitivityLabels

### [Invoke-MgBetaExtractUserDriveRootSensitivityLabel](Invoke-MgBetaExtractUserDriveRootSensitivityLabel.md)
Invoke action extractSensitivityLabels

### [Invoke-MgBetaExtractUserInformationProtectionPolicyLabel](Invoke-MgBetaExtractUserInformationProtectionPolicyLabel.md)
Using the metadata that exists on an already-labeled piece of information, resolve the metadata to a specific sensitivity label.
The contentInfo input is resolved to informationProtectionContentLabel.

### [Invoke-MgBetaExtractUserSecurityInformationProtectionSensitivityLabelContentLabel](Invoke-MgBetaExtractUserSecurityInformationProtectionSensitivityLabelContentLabel.md)
Invoke action extractContentLabel

### [Invoke-MgBetaFollowUserDriveItem](Invoke-MgBetaFollowUserDriveItem.md)
Follow a driveItem.

### [Invoke-MgBetaFollowUserDriveRoot](Invoke-MgBetaFollowUserDriveRoot.md)
Follow a driveItem.

### [Invoke-MgBetaForwardUserEvent](Invoke-MgBetaForwardUserEvent.md)
This action allows the organizer or attendee of a meeting event to forward the \nmeeting request to a new recipient.
If the meeting event is forwarded from an attendee's Microsoft 365 mailbox to another recipient, this action \nalso sends a message to notify the organizer of the forwarding, and adds the recipient to the organizer's \ncopy of the meeting event.
This convenience is not available when forwarding from an Outlook.com account.

### [Invoke-MgBetaForwardUserEventInstance](Invoke-MgBetaForwardUserEventInstance.md)
This action allows the organizer or attendee of a meeting event to forward the \nmeeting request to a new recipient.
If the meeting event is forwarded from an attendee's Microsoft 365 mailbox to another recipient, this action \nalso sends a message to notify the organizer of the forwarding, and adds the recipient to the organizer's \ncopy of the meeting event.
This convenience is not available when forwarding from an Outlook.com account.

### [Invoke-MgBetaForwardUserMailFolderChildFolderMessage](Invoke-MgBetaForwardUserMailFolderChildFolderMessage.md)
Forward a message using either JSON or MIME format.
When using JSON format, you can:\n- Specify either a comment or the **body** property of the `message` parameter.
Specifying both will return an HTTP 400 Bad Request error.\n- Specify either the `toRecipients` parameter or the **toRecipients** property of the `message` parameter.
Specifying both or specifying neither will return an HTTP 400 Bad Request error.
When using MIME format:\n- Provide the applicable Internet message headers and the MIME content, all encoded in **base64** format in the request body.\n- Add any attachments and S/MIME properties to the MIME content.
This method saves the message in the **Sent Items** folder.
Alternatively, create a draft to forward a message, and send it later.

### [Invoke-MgBetaForwardUserMailFolderMessage](Invoke-MgBetaForwardUserMailFolderMessage.md)
Forward a message using either JSON or MIME format.
When using JSON format, you can:\n- Specify either a comment or the **body** property of the `message` parameter.
Specifying both will return an HTTP 400 Bad Request error.\n- Specify either the `toRecipients` parameter or the **toRecipients** property of the `message` parameter.
Specifying both or specifying neither will return an HTTP 400 Bad Request error.
When using MIME format:\n- Provide the applicable Internet message headers and the MIME content, all encoded in **base64** format in the request body.\n- Add any attachments and S/MIME properties to the MIME content.
This method saves the message in the **Sent Items** folder.
Alternatively, create a draft to forward a message, and send it later.

### [Invoke-MgBetaForwardUserMessage](Invoke-MgBetaForwardUserMessage.md)
Forward a message using either JSON or MIME format.
When using JSON format, you can:\n- Specify either a comment or the **body** property of the `message` parameter.
Specifying both will return an HTTP 400 Bad Request error.\n- Specify either the `toRecipients` parameter or the **toRecipients** property of the `message` parameter.
Specifying both or specifying neither will return an HTTP 400 Bad Request error.
When using MIME format:\n- Provide the applicable Internet message headers and the MIME content, all encoded in **base64** format in the request body.\n- Add any attachments and S/MIME properties to the MIME content.
This method saves the message in the **Sent Items** folder.
Alternatively, create a draft to forward a message, and send it later.

### [Invoke-MgBetaGraphUserChat](Invoke-MgBetaGraphUserChat.md)
Unhide a chat for a user.

### [Invoke-MgBetaHasUserDeviceEnrollmentConfigurationPayloadLink](Invoke-MgBetaHasUserDeviceEnrollmentConfigurationPayloadLink.md)
Invoke action hasPayloadLinks

### [Invoke-MgBetaInitiateUserManagedDeviceMobileDeviceManagementKeyRecovery](Invoke-MgBetaInitiateUserManagedDeviceMobileDeviceManagementKeyRecovery.md)
Perform MDM key recovery and TPM attestation

### [Invoke-MgBetaInvalidateUserRefreshToken](Invoke-MgBetaInvalidateUserRefreshToken.md)
Invalidates all of the user's refresh tokens issued to applications (as well as session cookies in a user's browser), by resetting the **refreshTokensValidFromDateTime** user property to the current date-time.
Typically, this operation is performed (by the user or an administrator) if the user has a lost or stolen device.
This operation would prevent access to any of the organization's data accessed through applications on the device without the user first being required to sign in again.
In fact, this operation would force the user to sign in again for all applications that they have previously consented to, independent of device.
For developers, if the application attempts to redeem a delegated access token for this user by using an invalidated refresh token, the application will get an error.
If this happens, the application will need to acquire a new refresh token by making a request to the authorize endpoint, which will force the user to sign in.

### [Invoke-MgBetaInviteUserDriveItem](Invoke-MgBetaInviteUserDriveItem.md)
Sends a sharing invitation for a **DriveItem**.\nA sharing invitation provides permissions to the recipients and optionally sends an email to the recipients to notify them the item was shared.

### [Invoke-MgBetaInviteUserDriveRoot](Invoke-MgBetaInviteUserDriveRoot.md)
Sends a sharing invitation for a **DriveItem**.\nA sharing invitation provides permissions to the recipients and optionally sends an email to the recipients to notify them the item was shared.

### [Invoke-MgBetaLicenseUser](Invoke-MgBetaLicenseUser.md)
Reprocess all group-based license assignments for the user.
To learn more about group-based licensing, see What is group-based licensing in Azure Active Directory.
Also see Identify and resolve license assignment problems for a group in Azure Active Directory for more details.

### [Invoke-MgBetaLogoutUserManagedDeviceSharedAppleDeviceActiveUser](Invoke-MgBetaLogoutUserManagedDeviceSharedAppleDeviceActiveUser.md)
Logout shared Apple device active user

### [Invoke-MgBetaMarkUserChatReadForUser](Invoke-MgBetaMarkUserChatReadForUser.md)
Mark a chat as read for a user.

### [Invoke-MgBetaMarkUserChatUnreadForUser](Invoke-MgBetaMarkUserChatUnreadForUser.md)
Mark a chat as unread for a user.

### [Invoke-MgBetaOverrideUserManagedDeviceComplianceState](Invoke-MgBetaOverrideUserManagedDeviceComplianceState.md)
Invoke action overrideComplianceState

### [Invoke-MgBetaPlayUserManagedDeviceLostModeSound](Invoke-MgBetaPlayUserManagedDeviceLostModeSound.md)
Play lost mode sound

### [Invoke-MgBetaPreviewUserDriveItem](Invoke-MgBetaPreviewUserDriveItem.md)
Invoke action preview

### [Invoke-MgBetaPreviewUserDriveRoot](Invoke-MgBetaPreviewUserDriveRoot.md)
Invoke action preview

### [Invoke-MgBetaReauthorizeUserDriveItemSubscription](Invoke-MgBetaReauthorizeUserDriveItemSubscription.md)
Invoke action reauthorize

### [Invoke-MgBetaReauthorizeUserDriveListSubscription](Invoke-MgBetaReauthorizeUserDriveListSubscription.md)
Invoke action reauthorize

### [Invoke-MgBetaReauthorizeUserDriveRootSubscription](Invoke-MgBetaReauthorizeUserDriveRootSubscription.md)
Invoke action reauthorize

### [Invoke-MgBetaRecordUserPendingAccessReviewInstanceDecision](Invoke-MgBetaRecordUserPendingAccessReviewInstanceDecision.md)
As a reviewer of an access review, record a decision for an accessReviewInstanceDecisionItem that is assigned to you and that matches the principal or resource IDs specified.
If no IDs are specified, the decisions will apply to every **accessReviewInstanceDecisionItem** for which you are the reviewer.

### [Invoke-MgBetaReenableUserManagedDevice](Invoke-MgBetaReenableUserManagedDevice.md)
Invoke action reenable

### [Invoke-MgBetaReplyAllUserMailFolderChildFolderMessage](Invoke-MgBetaReplyAllUserMailFolderChildFolderMessage.md)
Reply to all recipients of a message using either JSON or MIME format.
When using JSON format:\n- Specify either a comment or the **body** property of the `message` parameter.
Specifying both will return an HTTP 400 Bad Request error.\n- If the original message specifies a recipient in the **replyTo** property, per Internet Message Format (RFC 2822), send the reply to the recipients in **replyTo** and not the recipient in the **from** property.
When using MIME format:\n- Provide the applicable Internet message headers and the MIME content, all encoded in **base64** format in the request body.\n- Add any attachments and S/MIME properties to the MIME content.
This method saves the message in the **Sent Items** folder.
Alternatively, create a draft to reply-all to a message, and send it later.

### [Invoke-MgBetaReplyAllUserMailFolderMessage](Invoke-MgBetaReplyAllUserMailFolderMessage.md)
Reply to all recipients of a message using either JSON or MIME format.
When using JSON format:\n- Specify either a comment or the **body** property of the `message` parameter.
Specifying both will return an HTTP 400 Bad Request error.\n- If the original message specifies a recipient in the **replyTo** property, per Internet Message Format (RFC 2822), send the reply to the recipients in **replyTo** and not the recipient in the **from** property.
When using MIME format:\n- Provide the applicable Internet message headers and the MIME content, all encoded in **base64** format in the request body.\n- Add any attachments and S/MIME properties to the MIME content.
This method saves the message in the **Sent Items** folder.
Alternatively, create a draft to reply-all to a message, and send it later.

### [Invoke-MgBetaReplyAllUserMessage](Invoke-MgBetaReplyAllUserMessage.md)
Reply to all recipients of a message using either JSON or MIME format.
When using JSON format:\n- Specify either a comment or the **body** property of the `message` parameter.
Specifying both will return an HTTP 400 Bad Request error.\n- If the original message specifies a recipient in the **replyTo** property, per Internet Message Format (RFC 2822), send the reply to the recipients in **replyTo** and not the recipient in the **from** property.
When using MIME format:\n- Provide the applicable Internet message headers and the MIME content, all encoded in **base64** format in the request body.\n- Add any attachments and S/MIME properties to the MIME content.
This method saves the message in the **Sent Items** folder.
Alternatively, create a draft to reply-all to a message, and send it later.

### [Invoke-MgBetaReplyUserMailFolderChildFolderMessage](Invoke-MgBetaReplyUserMailFolderChildFolderMessage.md)
Reply to the sender of a message using either JSON or MIME format.
When using JSON format:\n- Specify either a comment or the **body** property of the `message` parameter.
Specifying both will return an HTTP 400 Bad Request error.\n- If the original message specifies a recipient in the **replyTo** property, per Internet Message Format (RFC 2822), send the reply to the recipients in **replyTo** and not the recipient in the **from** property.
When using MIME format:\n- Provide the applicable Internet message headers and the MIME content, all encoded in **base64** format in the request body.\n- Add any attachments and S/MIME properties to the MIME content.
This method saves the message in the **Sent Items** folder.
Alternatively, create a draft to reply to a message, and send it later.

### [Invoke-MgBetaReplyUserMailFolderMessage](Invoke-MgBetaReplyUserMailFolderMessage.md)
Reply to the sender of a message using either JSON or MIME format.
When using JSON format:\n- Specify either a comment or the **body** property of the `message` parameter.
Specifying both will return an HTTP 400 Bad Request error.\n- If the original message specifies a recipient in the **replyTo** property, per Internet Message Format (RFC 2822), send the reply to the recipients in **replyTo** and not the recipient in the **from** property.
When using MIME format:\n- Provide the applicable Internet message headers and the MIME content, all encoded in **base64** format in the request body.\n- Add any attachments and S/MIME properties to the MIME content.
This method saves the message in the **Sent Items** folder.
Alternatively, create a draft to reply to a message, and send it later.

### [Invoke-MgBetaReplyUserMessage](Invoke-MgBetaReplyUserMessage.md)
Reply to the sender of a message using either JSON or MIME format.
When using JSON format:\n- Specify either a comment or the **body** property of the `message` parameter.
Specifying both will return an HTTP 400 Bad Request error.\n- If the original message specifies a recipient in the **replyTo** property, per Internet Message Format (RFC 2822), send the reply to the recipients in **replyTo** and not the recipient in the **from** property.
When using MIME format:\n- Provide the applicable Internet message headers and the MIME content, all encoded in **base64** format in the request body.\n- Add any attachments and S/MIME properties to the MIME content.
This method saves the message in the **Sent Items** folder.
Alternatively, create a draft to reply to a message, and send it later.

### [Invoke-MgBetaReprovisionUserCloudPc](Invoke-MgBetaReprovisionUserCloudPc.md)
Reprovision a specific Cloud PC.

### [Invoke-MgBetaReprovisionUserManagedDeviceCloudPc](Invoke-MgBetaReprovisionUserManagedDeviceCloudPc.md)
Reprovision a Cloud PC with an Intune managed device ID.

### [Invoke-MgBetaRetireUserManagedDevice](Invoke-MgBetaRetireUserManagedDevice.md)
Retire a device

### [Invoke-MgBetaRetryUserCloudPcPartnerAgentInstallation](Invoke-MgBetaRetryUserCloudPcPartnerAgentInstallation.md)
Invoke action retryPartnerAgentInstallation

### [Invoke-MgBetaRotateUserManagedDeviceBitLockerKey](Invoke-MgBetaRotateUserManagedDeviceBitLockerKey.md)
Rotate BitLockerKeys

### [Invoke-MgBetaRotateUserManagedDeviceFileVaultKey](Invoke-MgBetaRotateUserManagedDeviceFileVaultKey.md)
Invoke action rotateFileVaultKey

### [Invoke-MgBetaScanUserManagedDeviceWindowDefender](Invoke-MgBetaScanUserManagedDeviceWindowDefender.md)
Invoke action windowsDefenderScan

### [Invoke-MgBetaSignUserInformationProtectionDigest](Invoke-MgBetaSignUserInformationProtectionDigest.md)
Invoke action signDigest

### [Invoke-MgBetaSnoozeUserEventInstanceReminder](Invoke-MgBetaSnoozeUserEventInstanceReminder.md)
Postpone a reminder for an event in a user calendar until a new time.

### [Invoke-MgBetaSnoozeUserEventReminder](Invoke-MgBetaSnoozeUserEventReminder.md)
Postpone a reminder for an event in a user calendar until a new time.

### [Invoke-MgBetaSoftUserChatMessageDelete](Invoke-MgBetaSoftUserChatMessageDelete.md)
Delete a single message or a message reply in a channel or a chat.

### [Invoke-MgBetaSoftUserChatMessageReplyDelete](Invoke-MgBetaSoftUserChatMessageReplyDelete.md)
Delete a single message or a message reply in a channel or a chat.

### [Invoke-MgBetaTranslateUserExchangeId](Invoke-MgBetaTranslateUserExchangeId.md)
Translate identifiers of Outlook-related resources between formats.

### [Invoke-MgBetaTroubleshootUserCloudPc](Invoke-MgBetaTroubleshootUserCloudPc.md)
Troubleshoot a specific Cloud PC.
Use this API to check the health status of the Cloud PC and the session host.

### [Invoke-MgBetaUnfollowUserDriveItem](Invoke-MgBetaUnfollowUserDriveItem.md)
Unfollow a driveItem.

### [Invoke-MgBetaUnfollowUserDriveRoot](Invoke-MgBetaUnfollowUserDriveRoot.md)
Unfollow a driveItem.

### [Invoke-MgBetaUnsubscribeUserMailFolderChildFolderMessage](Invoke-MgBetaUnsubscribeUserMailFolderChildFolderMessage.md)
Submits a email request on behalf of the signed-in user to unsubscribe from an email distribution list.
Uses the information in the `List-Unsubscribe` header.
Message senders can use mailing lists in a user-friendly way by including an option for recipients to opt out.
They can do so by specifying the `List-Unsubscribe` header in each message following RFC-2369.
**Note** In particular, for the **unsubscribe** action to work, the sender must specify `mailto:` and not URL-based unsubscribe information.
Setting that header would also set the **unsubscribeEnabled** property of the message instance to `true`, and the **unsubscribeData** property to the header data.
If the **unsubscribeEnabled** property of a message is `true`, you can use the **unsubscribe** action to unsubscribe the user from similar future messages as managed by the message sender.
A successful **unsubscribe** action moves the message to the **Deleted Items** folder.
The actual exclusion of the user from future mail distribution is managed by the sender.

### [Invoke-MgBetaUnsubscribeUserMailFolderMessage](Invoke-MgBetaUnsubscribeUserMailFolderMessage.md)
Submits a email request on behalf of the signed-in user to unsubscribe from an email distribution list.
Uses the information in the `List-Unsubscribe` header.
Message senders can use mailing lists in a user-friendly way by including an option for recipients to opt out.
They can do so by specifying the `List-Unsubscribe` header in each message following RFC-2369.
**Note** In particular, for the **unsubscribe** action to work, the sender must specify `mailto:` and not URL-based unsubscribe information.
Setting that header would also set the **unsubscribeEnabled** property of the message instance to `true`, and the **unsubscribeData** property to the header data.
If the **unsubscribeEnabled** property of a message is `true`, you can use the **unsubscribe** action to unsubscribe the user from similar future messages as managed by the message sender.
A successful **unsubscribe** action moves the message to the **Deleted Items** folder.
The actual exclusion of the user from future mail distribution is managed by the sender.

### [Invoke-MgBetaUnsubscribeUserMessage](Invoke-MgBetaUnsubscribeUserMessage.md)
Submits a email request on behalf of the signed-in user to unsubscribe from an email distribution list.
Uses the information in the `List-Unsubscribe` header.
Message senders can use mailing lists in a user-friendly way by including an option for recipients to opt out.
They can do so by specifying the `List-Unsubscribe` header in each message following RFC-2369.
**Note** In particular, for the **unsubscribe** action to work, the sender must specify `mailto:` and not URL-based unsubscribe information.
Setting that header would also set the **unsubscribeEnabled** property of the message instance to `true`, and the **unsubscribeData** property to the header data.
If the **unsubscribeEnabled** property of a message is `true`, you can use the **unsubscribe** action to unsubscribe the user from similar future messages as managed by the message sender.
A successful **unsubscribe** action moves the message to the **Deleted Items** folder.
The actual exclusion of the user from future mail distribution is managed by the sender.

### [Join-MgBetaUserDriveListContentTypeWithHubSite](Join-MgBetaUserDriveListContentTypeWithHubSite.md)
Associate a [content type][contentType] with a list of hub sites.

### [Lock-MgBetaUserManagedDeviceRemote](Lock-MgBetaUserManagedDeviceRemote.md)
Remote lock

### [Move-MgBetaUserMailFolder](Move-MgBetaUserMailFolder.md)
Move a mailfolder and its contents to another mailfolder.

### [Move-MgBetaUserMailFolderChildFolder](Move-MgBetaUserMailFolderChildFolder.md)
Move a mailfolder and its contents to another mailfolder.

### [Move-MgBetaUserMailFolderChildFolderMessage](Move-MgBetaUserMailFolderChildFolderMessage.md)
Move a message to another folder within the specified user's mailbox.
This creates a new copy of the message in the destination folder and removes the original message.

### [Move-MgBetaUserMailFolderMessage](Move-MgBetaUserMailFolderMessage.md)
Move a message to another folder within the specified user's mailbox.
This creates a new copy of the message in the destination folder and removes the original message.

### [Move-MgBetaUserManagedDeviceToOu](Move-MgBetaUserManagedDeviceToOu.md)
Invoke action moveDevicesToOU

### [Move-MgBetaUserMessage](Move-MgBetaUserMessage.md)
Move a message to another folder within the specified user's mailbox.
This creates a new copy of the message in the destination folder and removes the original message.

### [New-MgBetaUserDeviceEnrollmentConfigurationEnrollmentNotificationConfiguration](New-MgBetaUserDeviceEnrollmentConfigurationEnrollmentNotificationConfiguration.md)
Invoke action createEnrollmentNotificationConfiguration

### [New-MgBetaUserDriveItemLink](New-MgBetaUserDriveItemLink.md)
You can use **createLink** action to share a driveItem via a sharing link.
The **createLink** action will create a new sharing link if the specified link type doesn't already exist for the calling application.\nIf a sharing link of the specified type already exists for the app, the existing sharing link will be returned.
DriveItem resources inherit sharing permissions from their ancestors.

### [New-MgBetaUserDriveItemListItemLink](New-MgBetaUserDriveItemListItemLink.md)
Create a sharing link for a listItem.
The **createLink** action creates a new sharing link if the specified link type doesn't already exist for the calling application.\nIf a sharing link of the specified type already exists for the app, this action will return the existing sharing link.
**listItem** resources inherit sharing permissions from the list the item resides in.

### [New-MgBetaUserDriveItemUploadSession](New-MgBetaUserDriveItemUploadSession.md)
Create an upload session to allow your app to upload files up to the maximum file size.
An upload session allows your app to upload ranges of the file in sequential API requests, which allows the transfer to be resumed if a connection is dropped while the upload is in progress.
To upload a file using an upload session:

### [New-MgBetaUserDriveListItemLink](New-MgBetaUserDriveListItemLink.md)
Create a sharing link for a listItem.
The **createLink** action creates a new sharing link if the specified link type doesn't already exist for the calling application.\nIf a sharing link of the specified type already exists for the app, this action will return the existing sharing link.
**listItem** resources inherit sharing permissions from the list the item resides in.

### [New-MgBetaUserDriveRootLink](New-MgBetaUserDriveRootLink.md)
You can use **createLink** action to share a driveItem via a sharing link.
The **createLink** action will create a new sharing link if the specified link type doesn't already exist for the calling application.\nIf a sharing link of the specified type already exists for the app, the existing sharing link will be returned.
DriveItem resources inherit sharing permissions from their ancestors.

### [New-MgBetaUserDriveRootListItemLink](New-MgBetaUserDriveRootListItemLink.md)
Create a sharing link for a listItem.
The **createLink** action creates a new sharing link if the specified link type doesn't already exist for the calling application.\nIf a sharing link of the specified type already exists for the app, this action will return the existing sharing link.
**listItem** resources inherit sharing permissions from the list the item resides in.

### [New-MgBetaUserDriveRootUploadSession](New-MgBetaUserDriveRootUploadSession.md)
Create an upload session to allow your app to upload files up to the maximum file size.
An upload session allows your app to upload ranges of the file in sequential API requests, which allows the transfer to be resumed if a connection is dropped while the upload is in progress.
To upload a file using an upload session:

### [New-MgBetaUserEventAttachmentUploadSession](New-MgBetaUserEventAttachmentUploadSession.md)
Create an upload session that allows an app to iteratively upload ranges of a file, so as to attach the file to an Outlook item.
The item can be a message or event.
Use this approach to attach a file if the file size is between 3 MB and 150 MB.
To attach a file that's smaller than 3 MB, do a `POST` operation on the **attachments** navigation property of the Outlook item; see how to do this for a message or for an event.
As part of the response, this action returns an upload URL that you can use in subsequent sequential `PUT` queries.
Request headers for each `PUT` operation let you specify the exact range of bytes to be uploaded.
This allows transfer to be resumed, in case the network connection is dropped during upload.
The following are the steps to attach a file to an Outlook item using an upload session: See attach large files to Outlook messages or events for an example.

### [New-MgBetaUserEventInstanceAttachmentUploadSession](New-MgBetaUserEventInstanceAttachmentUploadSession.md)
Create an upload session that allows an app to iteratively upload ranges of a file, so as to attach the file to an Outlook item.
The item can be a message or event.
Use this approach to attach a file if the file size is between 3 MB and 150 MB.
To attach a file that's smaller than 3 MB, do a `POST` operation on the **attachments** navigation property of the Outlook item; see how to do this for a message or for an event.
As part of the response, this action returns an upload URL that you can use in subsequent sequential `PUT` queries.
Request headers for each `PUT` operation let you specify the exact range of bytes to be uploaded.
This allows transfer to be resumed, in case the network connection is dropped during upload.
The following are the steps to attach a file to an Outlook item using an upload session: See attach large files to Outlook messages or events for an example.

### [New-MgBetaUserMailFolderChildFolderMessageAttachmentUploadSession](New-MgBetaUserMailFolderChildFolderMessageAttachmentUploadSession.md)
Create an upload session that allows an app to iteratively upload ranges of a file, so as to attach the file to an Outlook item.
The item can be a message or event.
Use this approach to attach a file if the file size is between 3 MB and 150 MB.
To attach a file that's smaller than 3 MB, do a `POST` operation on the **attachments** navigation property of the Outlook item; see how to do this for a message or for an event.
As part of the response, this action returns an upload URL that you can use in subsequent sequential `PUT` queries.
Request headers for each `PUT` operation let you specify the exact range of bytes to be uploaded.
This allows transfer to be resumed, in case the network connection is dropped during upload.
The following are the steps to attach a file to an Outlook item using an upload session: See attach large files to Outlook messages or events for an example.

### [New-MgBetaUserMailFolderChildFolderMessageForward](New-MgBetaUserMailFolderChildFolderMessageForward.md)
Create a draft to forward an existing message, in either JSON or MIME format.
When using JSON format, you can: \n- Specify either a comment or the **body** property of the `message` parameter.
Specifying both will return an HTTP 400 Bad Request error.\n- Specify either the `toRecipients` parameter or the **toRecipients** property of the `message` parameter.
Specifying both or specifying neither will return an HTTP 400 Bad Request error.\n- Update the draft later to add content to the **body** or change other message properties.
When using MIME format:\n- Provide the applicable Internet message headers and the MIME content, all encoded in **base64** format in the request body.\n- Add any attachments and S/MIME properties to the MIME content.
Send the draft message in a subsequent operation.
Alternatively, forward a message in a single operation.

### [New-MgBetaUserMailFolderChildFolderMessageReply](New-MgBetaUserMailFolderChildFolderMessageReply.md)
Create a draft to reply to the sender of a message in either JSON or MIME format.
When using JSON format:\n- Specify either a comment or the **body** property of the `message` parameter.
Specifying both will return an HTTP 400 Bad Request error.\n- If **replyTo** is specified in the original message, per Internet Message Format (RFC 2822), you should send the reply to the recipients in **replyTo**, and not the recipients in **from**.\n- You can update the draft later to add reply content to the **body** or change other message properties.
When using MIME format:\n- Provide the applicable Internet message headers and the MIME content, all encoded in **base64** format in the request body.\n- Add any attachments and S/MIME properties to the MIME content.
Send the draft message in a subsequent operation.
Alternatively, reply to a message in a single operation.

### [New-MgBetaUserMailFolderChildFolderMessageReplyAll](New-MgBetaUserMailFolderChildFolderMessageReplyAll.md)
Create a draft to reply to the sender and all recipients of a message in either JSON or MIME format.
When using JSON format:\n- Specify either a comment or the **body** property of the `message` parameter.
Specifying both will return an HTTP 400 Bad Request error.\n- If the original message specifies a recipient in the **replyTo** property, per Internet Message Format (RFC 2822), you should send the reply to the recipients in the **replyTo** and **toRecipients** properties, and not the recipients in the **from** and **toRecipients** properties.
\n- You can update the draft message later.
When using MIME format:\n- Provide the applicable Internet message headers and the MIME content, all encoded in **base64** format in the request body.\n- Add any attachments and S/MIME properties to the MIME content.
Send the draft message in a subsequent operation.
Alternatively, reply-all to a message in a single action.

### [New-MgBetaUserMailFolderMessageAttachmentUploadSession](New-MgBetaUserMailFolderMessageAttachmentUploadSession.md)
Create an upload session that allows an app to iteratively upload ranges of a file, so as to attach the file to an Outlook item.
The item can be a message or event.
Use this approach to attach a file if the file size is between 3 MB and 150 MB.
To attach a file that's smaller than 3 MB, do a `POST` operation on the **attachments** navigation property of the Outlook item; see how to do this for a message or for an event.
As part of the response, this action returns an upload URL that you can use in subsequent sequential `PUT` queries.
Request headers for each `PUT` operation let you specify the exact range of bytes to be uploaded.
This allows transfer to be resumed, in case the network connection is dropped during upload.
The following are the steps to attach a file to an Outlook item using an upload session: See attach large files to Outlook messages or events for an example.

### [New-MgBetaUserMailFolderMessageForward](New-MgBetaUserMailFolderMessageForward.md)
Create a draft to forward an existing message, in either JSON or MIME format.
When using JSON format, you can: \n- Specify either a comment or the **body** property of the `message` parameter.
Specifying both will return an HTTP 400 Bad Request error.\n- Specify either the `toRecipients` parameter or the **toRecipients** property of the `message` parameter.
Specifying both or specifying neither will return an HTTP 400 Bad Request error.\n- Update the draft later to add content to the **body** or change other message properties.
When using MIME format:\n- Provide the applicable Internet message headers and the MIME content, all encoded in **base64** format in the request body.\n- Add any attachments and S/MIME properties to the MIME content.
Send the draft message in a subsequent operation.
Alternatively, forward a message in a single operation.

### [New-MgBetaUserMailFolderMessageReply](New-MgBetaUserMailFolderMessageReply.md)
Create a draft to reply to the sender of a message in either JSON or MIME format.
When using JSON format:\n- Specify either a comment or the **body** property of the `message` parameter.
Specifying both will return an HTTP 400 Bad Request error.\n- If **replyTo** is specified in the original message, per Internet Message Format (RFC 2822), you should send the reply to the recipients in **replyTo**, and not the recipients in **from**.\n- You can update the draft later to add reply content to the **body** or change other message properties.
When using MIME format:\n- Provide the applicable Internet message headers and the MIME content, all encoded in **base64** format in the request body.\n- Add any attachments and S/MIME properties to the MIME content.
Send the draft message in a subsequent operation.
Alternatively, reply to a message in a single operation.

### [New-MgBetaUserMailFolderMessageReplyAll](New-MgBetaUserMailFolderMessageReplyAll.md)
Create a draft to reply to the sender and all recipients of a message in either JSON or MIME format.
When using JSON format:\n- Specify either a comment or the **body** property of the `message` parameter.
Specifying both will return an HTTP 400 Bad Request error.\n- If the original message specifies a recipient in the **replyTo** property, per Internet Message Format (RFC 2822), you should send the reply to the recipients in the **replyTo** and **toRecipients** properties, and not the recipients in the **from** and **toRecipients** properties.
\n- You can update the draft message later.
When using MIME format:\n- Provide the applicable Internet message headers and the MIME content, all encoded in **base64** format in the request body.\n- Add any attachments and S/MIME properties to the MIME content.
Send the draft message in a subsequent operation.
Alternatively, reply-all to a message in a single action.

### [New-MgBetaUserManagedDeviceLogCollectionRequest](New-MgBetaUserManagedDeviceLogCollectionRequest.md)
Invoke action createDeviceLogCollectionRequest

### [New-MgBetaUserManagedDeviceLogCollectionResponseDownloadUrl](New-MgBetaUserManagedDeviceLogCollectionResponseDownloadUrl.md)
Invoke action createDownloadUrl

### [New-MgBetaUserManagedDeviceRemoteHelpSession](New-MgBetaUserManagedDeviceRemoteHelpSession.md)
Remote help - Create session with a specific device

### [New-MgBetaUserManagedDeviceWindowsDefenderUpdateSignature](New-MgBetaUserManagedDeviceWindowsDefenderUpdateSignature.md)
Invoke action windowsDefenderUpdateSignatures

### [New-MgBetaUserMessageAttachmentUploadSession](New-MgBetaUserMessageAttachmentUploadSession.md)
Create an upload session that allows an app to iteratively upload ranges of a file, so as to attach the file to an Outlook item.
The item can be a message or event.
Use this approach to attach a file if the file size is between 3 MB and 150 MB.
To attach a file that's smaller than 3 MB, do a `POST` operation on the **attachments** navigation property of the Outlook item; see how to do this for a message or for an event.
As part of the response, this action returns an upload URL that you can use in subsequent sequential `PUT` queries.
Request headers for each `PUT` operation let you specify the exact range of bytes to be uploaded.
This allows transfer to be resumed, in case the network connection is dropped during upload.
The following are the steps to attach a file to an Outlook item using an upload session: See attach large files to Outlook messages or events for an example.

### [New-MgBetaUserMessageForward](New-MgBetaUserMessageForward.md)
Create a draft to forward an existing message, in either JSON or MIME format.
When using JSON format, you can: \n- Specify either a comment or the **body** property of the `message` parameter.
Specifying both will return an HTTP 400 Bad Request error.\n- Specify either the `toRecipients` parameter or the **toRecipients** property of the `message` parameter.
Specifying both or specifying neither will return an HTTP 400 Bad Request error.\n- Update the draft later to add content to the **body** or change other message properties.
When using MIME format:\n- Provide the applicable Internet message headers and the MIME content, all encoded in **base64** format in the request body.\n- Add any attachments and S/MIME properties to the MIME content.
Send the draft message in a subsequent operation.
Alternatively, forward a message in a single operation.

### [New-MgBetaUserMessageReply](New-MgBetaUserMessageReply.md)
Create a draft to reply to the sender of a message in either JSON or MIME format.
When using JSON format:\n- Specify either a comment or the **body** property of the `message` parameter.
Specifying both will return an HTTP 400 Bad Request error.\n- If **replyTo** is specified in the original message, per Internet Message Format (RFC 2822), you should send the reply to the recipients in **replyTo**, and not the recipients in **from**.\n- You can update the draft later to add reply content to the **body** or change other message properties.
When using MIME format:\n- Provide the applicable Internet message headers and the MIME content, all encoded in **base64** format in the request body.\n- Add any attachments and S/MIME properties to the MIME content.
Send the draft message in a subsequent operation.
Alternatively, reply to a message in a single operation.

### [New-MgBetaUserMessageReplyAll](New-MgBetaUserMessageReplyAll.md)
Create a draft to reply to the sender and all recipients of a message in either JSON or MIME format.
When using JSON format:\n- Specify either a comment or the **body** property of the `message` parameter.
Specifying both will return an HTTP 400 Bad Request error.\n- If the original message specifies a recipient in the **replyTo** property, per Internet Message Format (RFC 2822), you should send the reply to the recipients in the **replyTo** and **toRecipients** properties, and not the recipients in the **from** and **toRecipients** properties.
\n- You can update the draft message later.
When using MIME format:\n- Provide the applicable Internet message headers and the MIME content, all encoded in **base64** format in the request body.\n- Add any attachments and S/MIME properties to the MIME content.
Send the draft message in a subsequent operation.
Alternatively, reply-all to a message in a single action.

### [New-MgBetaUserMobileAppTroubleshootingEventAppLogCollectionRequestDownloadUrl](New-MgBetaUserMobileAppTroubleshootingEventAppLogCollectionRequestDownloadUrl.md)
Invoke action createDownloadUrl

### [New-MgBetaUserOutlookTaskAttachmentUploadSession](New-MgBetaUserOutlookTaskAttachmentUploadSession.md)
Create an upload session that allows an app to iteratively upload ranges of a file, so as to attach the file to an Outlook item.
The item can be a message or event.
Use this approach to attach a file if the file size is between 3 MB and 150 MB.
To attach a file that's smaller than 3 MB, do a `POST` operation on the **attachments** navigation property of the Outlook item; see how to do this for a message or for an event.
As part of the response, this action returns an upload URL that you can use in subsequent sequential `PUT` queries.
Request headers for each `PUT` operation let you specify the exact range of bytes to be uploaded.
This allows transfer to be resumed, in case the network connection is dropped during upload.
The following are the steps to attach a file to an Outlook item using an upload session: See attach large files to Outlook messages or events for an example.

### [New-MgBetaUserOutlookTaskFolderTaskAttachmentUploadSession](New-MgBetaUserOutlookTaskFolderTaskAttachmentUploadSession.md)
Create an upload session that allows an app to iteratively upload ranges of a file, so as to attach the file to an Outlook item.
The item can be a message or event.
Use this approach to attach a file if the file size is between 3 MB and 150 MB.
To attach a file that's smaller than 3 MB, do a `POST` operation on the **attachments** navigation property of the Outlook item; see how to do this for a message or for an event.
As part of the response, this action returns an upload URL that you can use in subsequent sequential `PUT` queries.
Request headers for each `PUT` operation let you specify the exact range of bytes to be uploaded.
This allows transfer to be resumed, in case the network connection is dropped during upload.
The following are the steps to attach a file to an Outlook item using an upload session: See attach large files to Outlook messages or events for an example.

### [New-MgBetaUserOutlookTaskGroupTaskFolderTaskAttachmentUploadSession](New-MgBetaUserOutlookTaskGroupTaskFolderTaskAttachmentUploadSession.md)
Create an upload session that allows an app to iteratively upload ranges of a file, so as to attach the file to an Outlook item.
The item can be a message or event.
Use this approach to attach a file if the file size is between 3 MB and 150 MB.
To attach a file that's smaller than 3 MB, do a `POST` operation on the **attachments** navigation property of the Outlook item; see how to do this for a message or for an event.
As part of the response, this action returns an upload URL that you can use in subsequent sequential `PUT` queries.
Request headers for each `PUT` operation let you specify the exact range of bytes to be uploaded.
This allows transfer to be resumed, in case the network connection is dropped during upload.
The following are the steps to attach a file to an Outlook item using an upload session: See attach large files to Outlook messages or events for an example.

### [New-MgBetaUserTodoListTaskAttachmentUploadSession](New-MgBetaUserTodoListTaskAttachmentUploadSession.md)
Create an upload session to iteratively upload ranges of a file as an attachment to a todoTask.
As part of the response, this action returns an upload URL that you can use in subsequent sequential `PUT` queries.
The request headers for each `PUT` operation let you specify the exact range of bytes to be uploaded.
This allows the transfer to be resumed, in case the network connection is dropped during the upload.
The following are the steps to attach a file to a Microsoft To Do task using an upload session: For an example that describes the end-to-end attachment process, see attach files to a To Do task.

### [Publish-MgBetaUserDriveListContentType](Publish-MgBetaUserDriveListContentType.md)
Publishes a [contentType][] present in a content type hub site.

### [Remove-MgBetaUserDeviceFromManagement](Remove-MgBetaUserDeviceFromManagement.md)
Retire all devices from management for this user

### [Remove-MgBetaUserManagedDeviceFirmwareConfigurationInterfaceManagement](Remove-MgBetaUserManagedDeviceFirmwareConfigurationInterfaceManagement.md)
Remove device from Device Firmware Configuration Interface management

### [Remove-MgBetaUserManagedDeviceUserFromSharedAppleDevice](Remove-MgBetaUserManagedDeviceUserFromSharedAppleDevice.md)
Delete user from shared Apple device

### [Rename-MgBetaUserCloudPc](Rename-MgBetaUserCloudPc.md)
Rename a specific Cloud PC.
Use this API to update the **displayName** for the Cloud PC entity.

### [Rename-MgBetaUserCloudPcUserAccountType](Rename-MgBetaUserCloudPcUserAccountType.md)
Change the account type of the user on a specific Cloud PC.

### [Request-MgBetaUserManagedDeviceRemoteAssistance](Request-MgBetaUserManagedDeviceRemoteAssistance.md)
Request remote assistance

### [Request-MgBetaUserManagedDeviceRemoteHelpSessionAccess](Request-MgBetaUserManagedDeviceRemoteHelpSessionAccess.md)
Remote help - Request Remote help session access permission for an existing session

### [Reset-MgBetaUserAuthenticationMethodPassword](Reset-MgBetaUserAuthenticationMethodPassword.md)
Invoke action resetPassword

### [Reset-MgBetaUserManagedDevicePasscode](Reset-MgBetaUserManagedDevicePasscode.md)
Reset passcode

### [Reset-MgBetaUserPendingAccessReviewInstanceDecision](Reset-MgBetaUserPendingAccessReviewInstanceDecision.md)
Resets decisions of all accessReviewInstanceDecisionItem objects on an accessReviewInstance to `notReviewed`.

### [Resize-MgBetaUserManagedDeviceCloudPc](Resize-MgBetaUserManagedDeviceCloudPc.md)
Upgrade or downgrade an existing Cloud PC to another configuration with a new virtual CPU (vCPU) and storage size.

### [Restart-MgBetaUserCloudPc](Restart-MgBetaUserCloudPc.md)
Reboot a specific Cloud PC.

### [Restart-MgBetaUserManagedDeviceNow](Restart-MgBetaUserManagedDeviceNow.md)
Reboot device

### [Restore-MgBetaUserAuthenticationWindowHelloForBusinessMethodDevice](Restore-MgBetaUserAuthenticationWindowHelloForBusinessMethodDevice.md)
Restore a recently deleted application, group, servicePrincipal, administrative unit, or user object from deleted items.
If an item was accidentally deleted, you can fully restore the item.
This is not applicable to security groups, which are deleted permanently.
A recently deleted item will remain available for up to 30 days.
After 30 days, the item is permanently deleted.

### [Restore-MgBetaUserCloudPc](Restore-MgBetaUserCloudPc.md)
Restore a specific Cloud PC.
Use this API to trigger a remote action that restores a Cloud PC device to a previous state.

### [Restore-MgBetaUserDriveItem](Restore-MgBetaUserDriveItem.md)
Restore a driveItem that has been deleted and is currently in the recycle bin.

### [Restore-MgBetaUserDriveItemListItemDocumentSetVersion](Restore-MgBetaUserDriveItemListItemDocumentSetVersion.md)
Restore a document set version.

### [Restore-MgBetaUserDriveItemListItemVersion](Restore-MgBetaUserDriveItemListItemVersion.md)
Invoke action restoreVersion

### [Restore-MgBetaUserDriveItemVersion](Restore-MgBetaUserDriveItemVersion.md)
Restore a previous version of a DriveItem to be the current version.
This will create a new version with the contents of the previous version, but preserves all existing versions of the file.

### [Restore-MgBetaUserDriveListItemDocumentSetVersion](Restore-MgBetaUserDriveListItemDocumentSetVersion.md)
Restore a document set version.

### [Restore-MgBetaUserDriveListItemVersion](Restore-MgBetaUserDriveListItemVersion.md)
Invoke action restoreVersion

### [Restore-MgBetaUserDriveRoot](Restore-MgBetaUserDriveRoot.md)
Restore a driveItem that has been deleted and is currently in the recycle bin.

### [Restore-MgBetaUserDriveRootListItemDocumentSetVersion](Restore-MgBetaUserDriveRootListItemDocumentSetVersion.md)
Restore a document set version.

### [Restore-MgBetaUserDriveRootListItemVersion](Restore-MgBetaUserDriveRootListItemVersion.md)
Invoke action restoreVersion

### [Restore-MgBetaUserDriveRootVersion](Restore-MgBetaUserDriveRootVersion.md)
Restore a previous version of a DriveItem to be the current version.
This will create a new version with the contents of the previous version, but preserves all existing versions of the file.

### [Restore-MgBetaUserManagedDeviceCloudPc](Restore-MgBetaUserManagedDeviceCloudPc.md)
Restore a Cloud PC device to a previous state with an Intune managed device ID.

### [Restore-MgBetaUserManagedDevicePasscode](Restore-MgBetaUserManagedDevicePasscode.md)
Recover passcode

### [Revoke-MgBetaUserDriveItemPermissionGrant](Revoke-MgBetaUserDriveItemPermissionGrant.md)
Revoke access to a [listItem][] or [driveItem][] granted via a sharing link by removing the specified [recipient][] from the link.

### [Revoke-MgBetaUserDriveRootPermissionGrant](Revoke-MgBetaUserDriveRootPermissionGrant.md)
Revoke access to a [listItem][] or [driveItem][] granted via a sharing link by removing the specified [recipient][] from the link.

### [Revoke-MgBetaUserManagedDeviceAppleVppLicense](Revoke-MgBetaUserManagedDeviceAppleVppLicense.md)
Revoke all Apple Vpp licenses for a device

### [Revoke-MgBetaUserSignInSession](Revoke-MgBetaUserSignInSession.md)
Invoke action revokeSignInSessions

### [Send-MgBetaUserChatActivityNotification](Send-MgBetaUserChatActivityNotification.md)
Send an activity feed notification in scope of a chat.
For more details about sending notifications and the requirements for doing so, see sending Teams activity notifications.

### [Send-MgBetaUserMail](Send-MgBetaUserMail.md)
Send the message specified in the request body using either JSON or MIME format.
When using JSON format you can include an attachment and use a mention to call out another user in the new message.
When using MIME format:\n- Provide the applicable Internet message headers and the MIME content, all encoded in **base64** format in the request body.\n- Add any attachments and S/MIME properties to the MIME content.
This method saves the message in the **Sent Items** folder.
Alternatively, create a draft message to send later.
To learn more about the steps involved in the backend before a mail is delivered to recipients, see here.

### [Send-MgBetaUserMailFolderChildFolderMessage](Send-MgBetaUserMailFolderChildFolderMessage.md)
Send an existing draft message.
The draft message can be a new message draft, reply draft, reply-all draft, or a forward draft.
This method saves the message in the **Sent Items** folder.
Alternatively, send a new message in a single operation.

### [Send-MgBetaUserMailFolderMessage](Send-MgBetaUserMailFolderMessage.md)
Send an existing draft message.
The draft message can be a new message draft, reply draft, reply-all draft, or a forward draft.
This method saves the message in the **Sent Items** folder.
Alternatively, send a new message in a single operation.

### [Send-MgBetaUserManagedDeviceCustomNotificationToCompanyPortal](Send-MgBetaUserManagedDeviceCustomNotificationToCompanyPortal.md)
Invoke action sendCustomNotificationToCompanyPortal

### [Send-MgBetaUserMessage](Send-MgBetaUserMessage.md)
Send an existing draft message.
The draft message can be a new message draft, reply draft, reply-all draft, or a forward draft.
This method saves the message in the **Sent Items** folder.
Alternatively, send a new message in a single operation.

### [Send-MgBetaUserPendingAccessReviewInstanceReminder](Send-MgBetaUserPendingAccessReviewInstanceReminder.md)
Send a reminder to the reviewers of a currently active accessReviewInstance.

### [Send-MgBetaUserTeamworkActivityNotification](Send-MgBetaUserTeamworkActivityNotification.md)
Send an activity feed notification to a user.
For more details about sending notifications and the requirements for doing so, see sending Teams activity notifications.

### [Set-MgBetaUserChatMessageReaction](Set-MgBetaUserChatMessageReaction.md)
Invoke action setReaction

### [Set-MgBetaUserChatMessageReplyReaction](Set-MgBetaUserChatMessageReplyReaction.md)
Invoke action setReaction

### [Set-MgBetaUserDeviceEnrollmentConfiguration](Set-MgBetaUserDeviceEnrollmentConfiguration.md)
Invoke action assign

### [Set-MgBetaUserDeviceEnrollmentConfigurationPriority](Set-MgBetaUserDeviceEnrollmentConfigurationPriority.md)
Invoke action setPriority

### [Set-MgBetaUserDriveItemSensitivityLabel](Set-MgBetaUserDriveItemSensitivityLabel.md)
Invoke action assignSensitivityLabel

### [Set-MgBetaUserDriveRootSensitivityLabel](Set-MgBetaUserDriveRootSensitivityLabel.md)
Invoke action assignSensitivityLabel

### [Set-MgBetaUserLicense](Set-MgBetaUserLicense.md)
Add or remove licenses for the user to enable or disable their use of Microsoft cloud offerings.
For example, an organization can have a Microsoft 365 Enterprise E3 subscription with 100 licenses, and this request assigns one of those licenses to a specific user.
You can also enable and disable specific plans associated with a subscription.
To learn more about subscriptions and licenses, see this Technet article.
To get the subscriptions available in the directory, perform a GET subscribedSkus request.

### [Set-MgBetaUserManagedDeviceCloudPcReviewStatus](Set-MgBetaUserManagedDeviceCloudPcReviewStatus.md)
Set the review status of a specific Cloud PC device.
Use this API to set the review status of a Cloud PC to in review if you consider a Cloud PC as suspicious.
After the review is completed, use this API again to set the Cloud PC back to a normal state.

### [Set-MgBetaUserManagedDeviceName](Set-MgBetaUserManagedDeviceName.md)
Set device name of the device.

### [Set-MgBetaUserPresence](Set-MgBetaUserPresence.md)
Set the availability and activity status in a presence session of an application for a user.

### [Set-MgBetaUserPresenceUserPreferredPresence](Set-MgBetaUserPresenceUserPreferredPresence.md)
Set the preferred availability and activity status for a user.
If the preferred presence of a user is set, the user's presence is the preferred presence.
Preferred presence takes effect only when there is at least one presence session of the user.
Otherwise, the user's presence stays as Offline.
A presence session can be created as a result of a successful setPresence operation, or if the user is signed in on a Teams client.
Read more about presence sessions and their time-out and expiration.

### [Skip-MgBetaUserManagedDeviceActivationLock](Skip-MgBetaUserManagedDeviceActivationLock.md)
Bypass activation lock

### [Start-MgBetaUserManagedDeviceConfigurationManagerAction](Start-MgBetaUserManagedDeviceConfigurationManagerAction.md)
Trigger action on ConfigurationManager client

### [Stop-MgBetaUserCloudPcGracePeriod](Stop-MgBetaUserCloudPcGracePeriod.md)
End the grace period for a specific Cloud PC.
The grace period is triggered when the Cloud PC license is removed or the provisioning policy is unassigned.
It allows users to access Cloud PCs for up to seven days before de-provisioning occurs.
Ending the grace period immediately deprovisions the Cloud PC without waiting the seven days.

### [Stop-MgBetaUserEvent](Stop-MgBetaUserEvent.md)
This action allows the organizer of a meeting to send a cancellation message and cancel the event.
The action moves the event to the Deleted Items folder.
The organizer can also cancel an occurrence of a recurring meeting \nby providing the occurrence event ID.
An attendee calling this action gets an error (HTTP 400 Bad Request), with the following\nerror message: 'Your request can't be completed.
You need to be an organizer to cancel a meeting.' This action differs from Delete in that **Cancel** is available to only the organizer, and lets\nthe organizer send a custom message to the attendees about the cancellation.

### [Stop-MgBetaUserEventInstance](Stop-MgBetaUserEventInstance.md)
This action allows the organizer of a meeting to send a cancellation message and cancel the event.
The action moves the event to the Deleted Items folder.
The organizer can also cancel an occurrence of a recurring meeting \nby providing the occurrence event ID.
An attendee calling this action gets an error (HTTP 400 Bad Request), with the following\nerror message: 'Your request can't be completed.
You need to be an organizer to cancel a meeting.' This action differs from Delete in that **Cancel** is available to only the organizer, and lets\nthe organizer send a custom message to the attendees about the cancellation.

### [Stop-MgBetaUserManagedDeviceRemoteHelpSession](Stop-MgBetaUserManagedDeviceRemoteHelpSession.md)
Remote help - End ACS session, Pubsub session and delete Remote help session

### [Stop-MgBetaUserPendingAccessReviewInstance](Stop-MgBetaUserPendingAccessReviewInstance.md)
Stop a currently active accessReviewInstance.
After the access review instance stops, the instance status will be `Completed`, the reviewers can no longer give input, and the access review decisions can be applied.
Stopping an instance will not effect future instances.
To prevent a recurring access review from starting future instances, update the schedule definition to change its scheduled end date.

### [Stop-MgBetaUserPendingAccessReviewInstanceStage](Stop-MgBetaUserPendingAccessReviewInstanceStage.md)
Stop an access review stage that is `inProgress`.
After the access review stage stops, the stage **status** will be `Completed` and the reviewers can no longer give input.
If there are subsequent stages that depend on the completed stage, the next stage will be created.
The accessReviewInstanceDecisionItem objects will always reflect the last decisions recorded across all stages at that given time, regardless of the status of the stages.

### [Sync-MgBetaUserManagedDevice](Sync-MgBetaUserManagedDevice.md)
Invoke action syncDevice

### [Test-MgBetaUserChatPermissionGrantProperty](Test-MgBetaUserChatPermissionGrantProperty.md)
Validate that a Microsoft 365 group's display name or mail nickname complies with naming policies.
Clients can use this API to determine whether a display name or mail nickname is valid before trying to **create** a Microsoft 365 group.
For validating properties of an existing group, use the validateProperties function for groups.
The following validations are performed for the display name and mail nickname properties: \n1.
Validate the prefix and suffix naming policy\n2.
Validate the custom banned words policy\n3.
Validate the mail nickname is unique This API returns with the first failure encountered.
If one or more properties fail multiple validations, only the property with the first validation failure is returned.
However, you can validate both the mail nickname and the display name and receive a collection of validation errors if you are only validating the prefix and suffix naming policy.

### [Test-MgBetaUserDeviceProperty](Test-MgBetaUserDeviceProperty.md)
Validate that a Microsoft 365 group's display name or mail nickname complies with naming policies.
Clients can use this API to determine whether a display name or mail nickname is valid before trying to **create** a Microsoft 365 group.
For validating properties of an existing group, use the validateProperties function for groups.
The following validations are performed for the display name and mail nickname properties: \n1.
Validate the prefix and suffix naming policy\n2.
Validate the custom banned words policy\n3.
Validate the mail nickname is unique This API returns with the first failure encountered.
If one or more properties fail multiple validations, only the property with the first validation failure is returned.
However, you can validate both the mail nickname and the display name and receive a collection of validation errors if you are only validating the prefix and suffix naming policy.

### [Test-MgBetaUserDriveItemPermission](Test-MgBetaUserDriveItemPermission.md)
Invoke action validatePermission

### [Test-MgBetaUserDriveRootPermission](Test-MgBetaUserDriveRootPermission.md)
Invoke action validatePermission

### [Test-MgBetaUserInformationProtectionDataLossPreventionPolicy](Test-MgBetaUserInformationProtectionDataLossPreventionPolicy.md)
Invoke action evaluate

### [Test-MgBetaUserInformationProtectionPolicyLabelApplication](Test-MgBetaUserInformationProtectionPolicyLabelApplication.md)
Compute the information protection label that should be applied and return the set of actions that must be taken to correctly label the information.
This API is useful when a label should be set manually or explicitly by a user or service, rather than automatically based on file contents.
Given contentInfo, which includes existing content metadata key/value pairs, and labelingOptions as an input, the API returns an informationProtectionAction object that contains one of more of the following:

### [Test-MgBetaUserInformationProtectionPolicyLabelClassificationResult](Test-MgBetaUserInformationProtectionPolicyLabelClassificationResult.md)
Using classification results, compute the information protection label that should be applied and return the set of actions that must be taken to correctly label the information.
This API is useful when a label should be set automatically based on classification of the file contents, rather than labeled directly by a user or service.
To evaluate based on classification results, provide contentInfo, which includes existing content metadata key/value pairs, and classification results.
The API returns an informationProtectionAction that contains one of more of the following:

### [Test-MgBetaUserInformationProtectionPolicyLabelRemoval](Test-MgBetaUserInformationProtectionPolicyLabelRemoval.md)
Indicate to the consuming application what actions it should take to remove the label information.
Given contentInfo as an input, which includes existing content metadata key/value pairs, the API returns an informationProtectionAction that contains some combination of one of more of the following:

### [Test-MgBetaUserInformationProtectionSensitivityLabel](Test-MgBetaUserInformationProtectionSensitivityLabel.md)
Invoke action evaluate

### [Test-MgBetaUserInformationProtectionSensitivityLabelSublabel](Test-MgBetaUserInformationProtectionSensitivityLabelSublabel.md)
Invoke action evaluate

### [Test-MgBetaUserJoinedGroupDynamicMembership](Test-MgBetaUserJoinedGroupDynamicMembership.md)
Evaluate whether a user or device is or would be a member of a dynamic group.
The membership rule is returned along with other details that were used in the evaluation.
You can complete this operation in the following ways:

### [Test-MgBetaUserJoinedGroupProperty](Test-MgBetaUserJoinedGroupProperty.md)
Validate that a Microsoft 365 group's display name or mail nickname complies with naming policies.
Clients can use this API to determine whether a display name or mail nickname is valid before trying to **create** a Microsoft 365 group.
For validating properties of an existing group, use the validateProperties function for groups.
The following validations are performed for the display name and mail nickname properties: \n1.
Validate the prefix and suffix naming policy\n2.
Validate the custom banned words policy\n3.
Validate the mail nickname is unique This API returns with the first failure encountered.
If one or more properties fail multiple validations, only the property with the first validation failure is returned.
However, you can validate both the mail nickname and the display name and receive a collection of validation errors if you are only validating the prefix and suffix naming policy.

### [Test-MgBetaUserPassword](Test-MgBetaUserPassword.md)
Check a user's password against the organization's password validation policy and report whether the password is valid.
Use this action to provide real-time feedback on password strength while the user types their password.

### [Test-MgBetaUserProperty](Test-MgBetaUserProperty.md)
Validate that a Microsoft 365 group's display name or mail nickname complies with naming policies.
Clients can use this API to determine whether a display name or mail nickname is valid before trying to **create** a Microsoft 365 group.
For validating properties of an existing group, use the validateProperties function for groups.
The following validations are performed for the display name and mail nickname properties: \n1.
Validate the prefix and suffix naming policy\n2.
Validate the custom banned words policy\n3.
Validate the mail nickname is unique This API returns with the first failure encountered.
If one or more properties fail multiple validations, only the property with the first validation failure is returned.
However, you can validate both the mail nickname and the display name and receive a collection of validation errors if you are only validating the prefix and suffix naming policy.

### [Test-MgBetaUserSecurityInformationProtectionSensitivityLabelApplication](Test-MgBetaUserSecurityInformationProtectionSensitivityLabelApplication.md)
Invoke action evaluateApplication

### [Test-MgBetaUserSecurityInformationProtectionSensitivityLabelClassificationResult](Test-MgBetaUserSecurityInformationProtectionSensitivityLabelClassificationResult.md)
Invoke action evaluateClassificationResults

### [Test-MgBetaUserSecurityInformationProtectionSensitivityLabelRemoval](Test-MgBetaUserSecurityInformationProtectionSensitivityLabelRemoval.md)
Invoke action evaluateRemoval

### [Unblock-MgBetaUserManagedApp](Unblock-MgBetaUserManagedApp.md)
Unblocks the managed app user from app check-in.

### [Undo-MgBetaUserChatMessageReplySoftDelete](Undo-MgBetaUserChatMessageReplySoftDelete.md)
Undo soft deletion of a single message or a message reply in a channel or a chat.

### [Undo-MgBetaUserChatMessageSoftDelete](Undo-MgBetaUserChatMessageSoftDelete.md)
Undo soft deletion of a single message or a message reply in a channel or a chat.

### [Unpublish-MgBetaUserDriveListContentType](Unpublish-MgBetaUserDriveListContentType.md)
Unpublish a [contentType][] from a content type hub site.

### [Update-MgBetaUserChatInstalledApp](Update-MgBetaUserChatInstalledApp.md)
Upgrade an app installation within a chat.

### [Update-MgBetaUserManagedDeviceWindowDeviceAccount](Update-MgBetaUserManagedDeviceWindowDeviceAccount.md)
Invoke action updateWindowsDeviceAccount

### [Update-MgBetaUserOnenotePageContent](Update-MgBetaUserOnenotePageContent.md)
Invoke action onenotePatchContent

### [Update-MgBetaUserPassword](Update-MgBetaUserPassword.md)
Enable the user to update their password.
Any user can update their password without belonging to any administrator role.

