---
Module Name: Microsoft.Graph.Users.Actions
Module Guid: b9a5aecf-ef85-433d-8228-8bc335ba927a
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
For more information, see contentType: getCompatibleHubContentTypes and the blog post Syntex Product Updates – August 2021.

### [Clear-MgUserManagedAppRegistrationByDeviceTag](Clear-MgUserManagedAppRegistrationByDeviceTag.md)
Issues a wipe operation on an app registration with specified device tag.

### [Clear-MgUserManagedDevice](Clear-MgUserManagedDevice.md)
Wipe a device

### [Clear-MgUserPresence](Clear-MgUserPresence.md)
Clear the application's presence session for a user.
If it is the user's only presence session, the user's presence will change to `Offline/Offline`.
For details about presences sessions, see presence: setPresence.

### [Clear-MgUserPresenceUserPreferredPresence](Clear-MgUserPresenceUserPreferredPresence.md)
Clear the preferred availability and activity status for a user.

### [Confirm-MgUserAuthenticationMicrosoftAuthenticatorMethodDeviceMemberGroup](Confirm-MgUserAuthenticationMicrosoftAuthenticatorMethodDeviceMemberGroup.md)
Check for membership in a specified list of group IDs, and return from that list those groups (identified by IDs) of which the specified user, group, service principal, organizational contact, device, or directory object is a member.
This function is transitive.
You can check up to a maximum of 20 groups per request.
This function supports all groups provisioned in Azure AD.
Because Microsoft 365 groups cannot contain other groups, membership in a Microsoft 365 group is always direct.

### [Confirm-MgUserAuthenticationMicrosoftAuthenticatorMethodDeviceMemberObject](Confirm-MgUserAuthenticationMicrosoftAuthenticatorMethodDeviceMemberObject.md)
Invoke action checkMemberObjects

### [Confirm-MgUserAuthenticationWindowHelloForBusinessMethodDeviceMemberGroup](Confirm-MgUserAuthenticationWindowHelloForBusinessMethodDeviceMemberGroup.md)
Check for membership in a specified list of group IDs, and return from that list those groups (identified by IDs) of which the specified user, group, service principal, organizational contact, device, or directory object is a member.
This function is transitive.
You can check up to a maximum of 20 groups per request.
This function supports all groups provisioned in Azure AD.
Because Microsoft 365 groups cannot contain other groups, membership in a Microsoft 365 group is always direct.

### [Confirm-MgUserAuthenticationWindowHelloForBusinessMethodDeviceMemberObject](Confirm-MgUserAuthenticationWindowHelloForBusinessMethodDeviceMemberObject.md)
Invoke action checkMemberObjects

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
For Copy operations, you follow an asynchronous calling pattern:  First call the Copy action, and then poll the operation endpoint for the result.

### [Copy-MgUserOnenotePageToSection](Copy-MgUserOnenotePageToSection.md)
Copy a page to a specific section.
For copy operations, you follow an asynchronous calling pattern:  First call the Copy action, and then poll the operation endpoint for the result.

### [Copy-MgUserOnenoteSectionToNotebook](Copy-MgUserOnenoteSectionToNotebook.md)
For Copy operations, you follow an asynchronous calling pattern:  First call the Copy action, and then poll the operation endpoint for the result.

### [Copy-MgUserOnenoteSectionToSectionGroup](Copy-MgUserOnenoteSectionToSectionGroup.md)
For Copy operations, you follow an asynchronous calling pattern:  First call the Copy action, and then poll the operation endpoint for the result.

### [Disable-MgUserAuthenticationPhoneMethodSmSign](Disable-MgUserAuthenticationPhoneMethodSmSign.md)
Disable SMS sign-in for an existing `mobile` phone number registered to a user.
The number will no longer be available for SMS sign-in, which can prevent your user from signing in.

### [Disable-MgUserManagedDeviceLostMode](Disable-MgUserManagedDeviceLostMode.md)
Disable lost mode

### [Enable-MgUserAuthenticationPhoneMethodSmSign](Enable-MgUserAuthenticationPhoneMethodSmSign.md)
Enable SMS sign-in for an existing `mobile` phone number registered to a user.
To be successfully enabled:

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
Return all IDs for the groups, administrative units, and directory roles that a user, group, service principal, organizational contact, device, or directory object is a member of.
This function is transitive.
**Note:** Only users and role-enabled groups can be members of directory roles.

### [Get-MgUserAuthenticationWindowHelloForBusinessMethodDeviceMemberGroup](Get-MgUserAuthenticationWindowHelloForBusinessMethodDeviceMemberGroup.md)
Return all the group IDs for the groups that the specified user, group, service principal, organizational contact, device, or directory object is a member of.
This function is transitive.

### [Get-MgUserAuthenticationWindowHelloForBusinessMethodDeviceMemberObject](Get-MgUserAuthenticationWindowHelloForBusinessMethodDeviceMemberObject.md)
Return all IDs for the groups, administrative units, and directory roles that a user, group, service principal, organizational contact, device, or directory object is a member of.
This function is transitive.
**Note:** Only users and role-enabled groups can be members of directory roles.

### [Get-MgUserById](Get-MgUserById.md)
Return the directory objects specified in a list of IDs.
Some common uses for this function are to:

### [Get-MgUserCalendarSchedule](Get-MgUserCalendarSchedule.md)
Get the free/busy availability information for a collection of users, distributions lists, or resources (rooms or equipment) for a specified time period.

### [Get-MgUserDefaultCalendarSchedule](Get-MgUserDefaultCalendarSchedule.md)
Get the free/busy availability information for a collection of users, distributions lists, or resources (rooms or equipment) for a specified time period.

### [Get-MgUserMailTip](Get-MgUserMailTip.md)
Get the MailTips of one or more recipients as available to the signed-in user.
Note that by making a `POST` call to the `getMailTips` action, you can request specific types of MailTips to \nbe returned for more than one recipient at one time.
The requested MailTips are returned in a mailTips collection.

### [Get-MgUserMemberGroup](Get-MgUserMemberGroup.md)
Return all the group IDs for the groups that the specified user, group, service principal, organizational contact, device, or directory object is a member of.
This function is transitive.

### [Get-MgUserMemberObject](Get-MgUserMemberObject.md)
Return all IDs for the groups, administrative units, and directory roles that a user, group, service principal, organizational contact, device, or directory object is a member of.
This function is transitive.
**Note:** Only users and role-enabled groups can be members of directory roles.

### [Get-MgUserOnenoteNotebookFromWebUrl](Get-MgUserOnenoteNotebookFromWebUrl.md)
Retrieve the properties and relationships of a notebook object by using its URL path.
The location can be user notebooks on Microsoft 365, group notebooks, or SharePoint site-hosted team notebooks on Microsoft 365.

### [Grant-MgUserDriveItemPermission](Grant-MgUserDriveItemPermission.md)
Grant users access to a link represented by a [permission][].

### [Grant-MgUserDriveRootPermission](Grant-MgUserDriveRootPermission.md)
Grant users access to a link represented by a [permission][].

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

### [Invoke-MgDismissUserEventInstanceReminder](Invoke-MgDismissUserEventInstanceReminder.md)
Dismiss a reminder that has been triggered for an event in a user calendar.

### [Invoke-MgDismissUserEventReminder](Invoke-MgDismissUserEventReminder.md)
Dismiss a reminder that has been triggered for an event in a user calendar.

### [Invoke-MgDownUserManagedDeviceShut](Invoke-MgDownUserManagedDeviceShut.md)
Shut down device

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

### [Invoke-MgInviteUserDriveItem](Invoke-MgInviteUserDriveItem.md)
Sends a sharing invitation for a **driveItem**.\nA sharing invitation provides permissions to the recipients and optionally sends them an email with a [sharing link][].

### [Invoke-MgInviteUserDriveRoot](Invoke-MgInviteUserDriveRoot.md)
Sends a sharing invitation for a **driveItem**.\nA sharing invitation provides permissions to the recipients and optionally sends them an email with a [sharing link][].

### [Invoke-MgLicenseUser](Invoke-MgLicenseUser.md)
Reprocess all group-based license assignments for the user.
To learn more about group-based licensing, see What is group-based licensing in Azure Active Directory.
Also see Identify and resolve license assignment problems for a group in Azure Active Directory for more details.

### [Invoke-MgLogoutUserManagedDeviceSharedAppleDeviceActiveUser](Invoke-MgLogoutUserManagedDeviceSharedAppleDeviceActiveUser.md)
Logout shared Apple device active user

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

### [Invoke-MgReplyAllUserMailFolderChildFolderMessage](Invoke-MgReplyAllUserMailFolderChildFolderMessage.md)
Reply to all recipients of a message using either JSON or MIME format.
When using JSON format:\n- Specify either a comment or the **body** property of the `message` parameter.
Specifying both will return an HTTP 400 Bad Request error.\n- If the original message specifies a recipient in the **replyTo** property, per Internet Message Format (RFC 2822), send the reply to the recipients in **replyTo** and not the recipient in the **from** property.
When using MIME format:\n- Provide the applicable Internet message headers and the MIME content, all encoded in **base64** format in the request body.\n- Add any attachments and S/MIME properties to the MIME content.
This method saves the message in the **Sent Items** folder.
Alternatively, create a draft to reply-all to a message and send it later.

### [Invoke-MgReplyAllUserMailFolderMessage](Invoke-MgReplyAllUserMailFolderMessage.md)
Reply to all recipients of a message using either JSON or MIME format.
When using JSON format:\n- Specify either a comment or the **body** property of the `message` parameter.
Specifying both will return an HTTP 400 Bad Request error.\n- If the original message specifies a recipient in the **replyTo** property, per Internet Message Format (RFC 2822), send the reply to the recipients in **replyTo** and not the recipient in the **from** property.
When using MIME format:\n- Provide the applicable Internet message headers and the MIME content, all encoded in **base64** format in the request body.\n- Add any attachments and S/MIME properties to the MIME content.
This method saves the message in the **Sent Items** folder.
Alternatively, create a draft to reply-all to a message and send it later.

### [Invoke-MgReplyAllUserMessage](Invoke-MgReplyAllUserMessage.md)
Reply to all recipients of a message using either JSON or MIME format.
When using JSON format:\n- Specify either a comment or the **body** property of the `message` parameter.
Specifying both will return an HTTP 400 Bad Request error.\n- If the original message specifies a recipient in the **replyTo** property, per Internet Message Format (RFC 2822), send the reply to the recipients in **replyTo** and not the recipient in the **from** property.
When using MIME format:\n- Provide the applicable Internet message headers and the MIME content, all encoded in **base64** format in the request body.\n- Add any attachments and S/MIME properties to the MIME content.
This method saves the message in the **Sent Items** folder.
Alternatively, create a draft to reply-all to a message and send it later.

### [Invoke-MgReplyUserMailFolderChildFolderMessage](Invoke-MgReplyUserMailFolderChildFolderMessage.md)
Reply to the sender of a message using either JSON or MIME format.
When using JSON format:\n- Specify either a comment or the **body** property of the `message` parameter.
Specifying both will return an HTTP 400 Bad Request error.\n- If the original message specifies a recipient in the **replyTo** property, per Internet Message Format (RFC 2822), send the reply to the recipients in **replyTo** and not the recipient in the **from** property.
When using MIME format:\n- Provide the applicable Internet message headers and the MIME content, all encoded in **base64** format in the request body.\n- Add any attachments and S/MIME properties to the MIME content.
This method saves the message in the **Sent Items** folder.
Alternatively, create a draft to reply to an existing message and send it later.

### [Invoke-MgReplyUserMailFolderMessage](Invoke-MgReplyUserMailFolderMessage.md)
Reply to the sender of a message using either JSON or MIME format.
When using JSON format:\n- Specify either a comment or the **body** property of the `message` parameter.
Specifying both will return an HTTP 400 Bad Request error.\n- If the original message specifies a recipient in the **replyTo** property, per Internet Message Format (RFC 2822), send the reply to the recipients in **replyTo** and not the recipient in the **from** property.
When using MIME format:\n- Provide the applicable Internet message headers and the MIME content, all encoded in **base64** format in the request body.\n- Add any attachments and S/MIME properties to the MIME content.
This method saves the message in the **Sent Items** folder.
Alternatively, create a draft to reply to an existing message and send it later.

### [Invoke-MgReplyUserMessage](Invoke-MgReplyUserMessage.md)
Reply to the sender of a message using either JSON or MIME format.
When using JSON format:\n- Specify either a comment or the **body** property of the `message` parameter.
Specifying both will return an HTTP 400 Bad Request error.\n- If the original message specifies a recipient in the **replyTo** property, per Internet Message Format (RFC 2822), send the reply to the recipients in **replyTo** and not the recipient in the **from** property.
When using MIME format:\n- Provide the applicable Internet message headers and the MIME content, all encoded in **base64** format in the request body.\n- Add any attachments and S/MIME properties to the MIME content.
This method saves the message in the **Sent Items** folder.
Alternatively, create a draft to reply to an existing message and send it later.

### [Invoke-MgRetireUserManagedDevice](Invoke-MgRetireUserManagedDevice.md)
Retire a device

### [Invoke-MgScanUserManagedDeviceWindowDefender](Invoke-MgScanUserManagedDeviceWindowDefender.md)
Invoke action windowsDefenderScan

### [Invoke-MgSnoozeUserEventInstanceReminder](Invoke-MgSnoozeUserEventInstanceReminder.md)
Postpone a reminder for an event in a user calendar until a new time.

### [Invoke-MgSnoozeUserEventReminder](Invoke-MgSnoozeUserEventReminder.md)
Postpone a reminder for an event in a user calendar until a new time.

### [Invoke-MgTranslateUserExchangeId](Invoke-MgTranslateUserExchangeId.md)
Translate identifiers of Outlook-related resources between formats.

### [Invoke-MgUnfollowUserDriveItem](Invoke-MgUnfollowUserDriveItem.md)
Unfollow a driveItem.

### [Invoke-MgUnfollowUserDriveRoot](Invoke-MgUnfollowUserDriveRoot.md)
Unfollow a driveItem.

### [Join-MgUserDriveListContentTypeWithHubSite](Join-MgUserDriveListContentTypeWithHubSite.md)
Associate a published [content type][contentType] present in a content type hub with a list of hub sites.

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

### [Move-MgUserMessage](Move-MgUserMessage.md)
Move a message to another folder within the specified user's mailbox.
This creates a new copy of the message in the destination folder and removes the original message.

### [New-MgUserDriveItemLink](New-MgUserDriveItemLink.md)
You can use **createLink** action to share a DriveItem via a sharing link.
The **createLink** action will create a new sharing link if the specified link type doesn't already exist for the calling application.\nIf a sharing link of the specified type already exists for the app, the existing sharing link will be returned.
DriveItem resources inherit sharing permissions from their ancestors.

### [New-MgUserDriveItemUploadSession](New-MgUserDriveItemUploadSession.md)
Create an upload session to allow your app to upload files up to the maximum file size.\nAn upload session allows your app to upload ranges of the file in sequential API requests, which allows the transfer to be resumed if a connection is dropped while the upload is in progress.
To upload a file using an upload session, there are two steps:

### [New-MgUserDriveRootLink](New-MgUserDriveRootLink.md)
You can use **createLink** action to share a DriveItem via a sharing link.
The **createLink** action will create a new sharing link if the specified link type doesn't already exist for the calling application.\nIf a sharing link of the specified type already exists for the app, the existing sharing link will be returned.
DriveItem resources inherit sharing permissions from their ancestors.

### [New-MgUserDriveRootUploadSession](New-MgUserDriveRootUploadSession.md)
Create an upload session to allow your app to upload files up to the maximum file size.\nAn upload session allows your app to upload ranges of the file in sequential API requests, which allows the transfer to be resumed if a connection is dropped while the upload is in progress.
To upload a file using an upload session, there are two steps:

### [New-MgUserEventAttachmentUploadSession](New-MgUserEventAttachmentUploadSession.md)
Create an upload session that allows an app to iteratively upload ranges of a file, so as to attach the file to the specified Outlook item.
The item can be a message or event.
Use this approach to attach a file if the file size is between 3 MB and 150 MB.
To attach a file that's smaller than 3 MB, do a `POST` operation on the **attachments** navigation property of the Outlook item; see how to do this for a message or for an event.
As part of the response, this action returns an upload URL that you can use in subsequent sequential `PUT` queries.
Request headers for each `PUT` operation let you specify the exact range of bytes to be uploaded.
This allows transfer to be resumed, in case the network connection is dropped during upload.
The following are the steps to attach a file to an Outlook item using an upload session: See attach large files to Outlook messages or events for an example.

### [New-MgUserEventInstanceAttachmentUploadSession](New-MgUserEventInstanceAttachmentUploadSession.md)
Create an upload session that allows an app to iteratively upload ranges of a file, so as to attach the file to the specified Outlook item.
The item can be a message or event.
Use this approach to attach a file if the file size is between 3 MB and 150 MB.
To attach a file that's smaller than 3 MB, do a `POST` operation on the **attachments** navigation property of the Outlook item; see how to do this for a message or for an event.
As part of the response, this action returns an upload URL that you can use in subsequent sequential `PUT` queries.
Request headers for each `PUT` operation let you specify the exact range of bytes to be uploaded.
This allows transfer to be resumed, in case the network connection is dropped during upload.
The following are the steps to attach a file to an Outlook item using an upload session: See attach large files to Outlook messages or events for an example.

### [New-MgUserMailFolderChildFolderMessageAttachmentUploadSession](New-MgUserMailFolderChildFolderMessageAttachmentUploadSession.md)
Create an upload session that allows an app to iteratively upload ranges of a file, so as to attach the file to the specified Outlook item.
The item can be a message or event.
Use this approach to attach a file if the file size is between 3 MB and 150 MB.
To attach a file that's smaller than 3 MB, do a `POST` operation on the **attachments** navigation property of the Outlook item; see how to do this for a message or for an event.
As part of the response, this action returns an upload URL that you can use in subsequent sequential `PUT` queries.
Request headers for each `PUT` operation let you specify the exact range of bytes to be uploaded.
This allows transfer to be resumed, in case the network connection is dropped during upload.
The following are the steps to attach a file to an Outlook item using an upload session: See attach large files to Outlook messages or events for an example.

### [New-MgUserMailFolderChildFolderMessageForward](New-MgUserMailFolderChildFolderMessageForward.md)
Create a draft to forward an existing message, in either JSON or MIME format.
When using JSON format, you can:\n- Specify either a comment or the **body** property of the `message` parameter.
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
\n- You can update the draft later to add reply content to the **body** or change other message properties.
When using MIME format:\n- Provide the applicable Internet message headers and the MIME content, all encoded in **base64** format in the request body.\n- Add any attachments and S/MIME properties to the MIME content.
Send the draft message in a subsequent operation.
Alternatively, reply-all to a message in a single action.

### [New-MgUserMailFolderMessageAttachmentUploadSession](New-MgUserMailFolderMessageAttachmentUploadSession.md)
Create an upload session that allows an app to iteratively upload ranges of a file, so as to attach the file to the specified Outlook item.
The item can be a message or event.
Use this approach to attach a file if the file size is between 3 MB and 150 MB.
To attach a file that's smaller than 3 MB, do a `POST` operation on the **attachments** navigation property of the Outlook item; see how to do this for a message or for an event.
As part of the response, this action returns an upload URL that you can use in subsequent sequential `PUT` queries.
Request headers for each `PUT` operation let you specify the exact range of bytes to be uploaded.
This allows transfer to be resumed, in case the network connection is dropped during upload.
The following are the steps to attach a file to an Outlook item using an upload session: See attach large files to Outlook messages or events for an example.

### [New-MgUserMailFolderMessageForward](New-MgUserMailFolderMessageForward.md)
Create a draft to forward an existing message, in either JSON or MIME format.
When using JSON format, you can:\n- Specify either a comment or the **body** property of the `message` parameter.
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
\n- You can update the draft later to add reply content to the **body** or change other message properties.
When using MIME format:\n- Provide the applicable Internet message headers and the MIME content, all encoded in **base64** format in the request body.\n- Add any attachments and S/MIME properties to the MIME content.
Send the draft message in a subsequent operation.
Alternatively, reply-all to a message in a single action.

### [New-MgUserManagedDeviceWindowsDefenderUpdateSignature](New-MgUserManagedDeviceWindowsDefenderUpdateSignature.md)
Invoke action windowsDefenderUpdateSignatures

### [New-MgUserMessageAttachmentUploadSession](New-MgUserMessageAttachmentUploadSession.md)
Create an upload session that allows an app to iteratively upload ranges of a file, so as to attach the file to the specified Outlook item.
The item can be a message or event.
Use this approach to attach a file if the file size is between 3 MB and 150 MB.
To attach a file that's smaller than 3 MB, do a `POST` operation on the **attachments** navigation property of the Outlook item; see how to do this for a message or for an event.
As part of the response, this action returns an upload URL that you can use in subsequent sequential `PUT` queries.
Request headers for each `PUT` operation let you specify the exact range of bytes to be uploaded.
This allows transfer to be resumed, in case the network connection is dropped during upload.
The following are the steps to attach a file to an Outlook item using an upload session: See attach large files to Outlook messages or events for an example.

### [New-MgUserMessageForward](New-MgUserMessageForward.md)
Create a draft to forward an existing message, in either JSON or MIME format.
When using JSON format, you can:\n- Specify either a comment or the **body** property of the `message` parameter.
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
\n- You can update the draft later to add reply content to the **body** or change other message properties.
When using MIME format:\n- Provide the applicable Internet message headers and the MIME content, all encoded in **base64** format in the request body.\n- Add any attachments and S/MIME properties to the MIME content.
Send the draft message in a subsequent operation.
Alternatively, reply-all to a message in a single action.

### [New-MgUserTodoListTaskAttachmentUploadSession](New-MgUserTodoListTaskAttachmentUploadSession.md)
Invoke action createUploadSession

### [Publish-MgUserDriveListContentType](Publish-MgUserDriveListContentType.md)
Publishes a [contentType][] present in the content type hub site.

### [Remove-MgUserDeviceFromManagement](Remove-MgUserDeviceFromManagement.md)
Retire all devices from management for this user

### [Remove-MgUserManagedDeviceUserFromSharedAppleDevice](Remove-MgUserManagedDeviceUserFromSharedAppleDevice.md)
Delete user from shared Apple device

### [Request-MgUserManagedDeviceRemoteAssistance](Request-MgUserManagedDeviceRemoteAssistance.md)
Request remote assistance

### [Reset-MgUserAuthenticationMethodPassword](Reset-MgUserAuthenticationMethodPassword.md)
Invoke action resetPassword

### [Reset-MgUserManagedDevicePasscode](Reset-MgUserManagedDevicePasscode.md)
Reset passcode

### [Restart-MgUserManagedDeviceNow](Restart-MgUserManagedDeviceNow.md)
Reboot device

### [Restore-MgUserAuthenticationWindowHelloForBusinessMethodDevice](Restore-MgUserAuthenticationWindowHelloForBusinessMethodDevice.md)
Restore a recently deleted application, group, servicePrincipal, or user object from deleted items.
If an item was accidentally deleted, you can fully restore the item.
This is not applicable to security groups, which are deleted permanently.
A recently deleted item will remain available for up to 30 days.
After 30 days, the item is permanently deleted.

### [Restore-MgUserDriveItem](Restore-MgUserDriveItem.md)
Restore a driveItem that has been deleted and is currently in the recycle bin.
**NOTE**: This functionality is currently only available for OneDrive Personal.

### [Restore-MgUserDriveItemListItemDocumentSetVersion](Restore-MgUserDriveItemListItemDocumentSetVersion.md)
Restore a document set version.

### [Restore-MgUserDriveItemListItemVersion](Restore-MgUserDriveItemListItemVersion.md)
Restore a previous version of a ListItem to be the current version.
This will create a new version with the contents of the previous version, but preserves all existing versions of the item.

### [Restore-MgUserDriveItemVersion](Restore-MgUserDriveItemVersion.md)
Restore a previous version of a DriveItem to be the current version.
This will create a new version with the contents of the previous version, but preserves all existing versions of the file.

### [Restore-MgUserDriveListItemDocumentSetVersion](Restore-MgUserDriveListItemDocumentSetVersion.md)
Restore a document set version.

### [Restore-MgUserDriveListItemVersion](Restore-MgUserDriveListItemVersion.md)
Restore a previous version of a ListItem to be the current version.
This will create a new version with the contents of the previous version, but preserves all existing versions of the item.

### [Restore-MgUserDriveRoot](Restore-MgUserDriveRoot.md)
Restore a driveItem that has been deleted and is currently in the recycle bin.
**NOTE**: This functionality is currently only available for OneDrive Personal.

### [Restore-MgUserDriveRootListItemDocumentSetVersion](Restore-MgUserDriveRootListItemDocumentSetVersion.md)
Restore a document set version.

### [Restore-MgUserDriveRootListItemVersion](Restore-MgUserDriveRootListItemVersion.md)
Restore a previous version of a ListItem to be the current version.
This will create a new version with the contents of the previous version, but preserves all existing versions of the item.

### [Restore-MgUserDriveRootVersion](Restore-MgUserDriveRootVersion.md)
Restore a previous version of a DriveItem to be the current version.
This will create a new version with the contents of the previous version, but preserves all existing versions of the file.

### [Restore-MgUserManagedDevicePasscode](Restore-MgUserManagedDevicePasscode.md)
Recover passcode

### [Revoke-MgUserSignInSession](Revoke-MgUserSignInSession.md)
Invoke action revokeSignInSessions

### [Send-MgUserChatActivityNotification](Send-MgUserChatActivityNotification.md)
Send an activity feed notification in scope of a chat.
For more details about sending notifications and the requirements for doing so, see sending Teams activity notifications.

### [Send-MgUserMail](Send-MgUserMail.md)
Send the message specified in the request body using either JSON or MIME format.
When using JSON format you can include a file attachment in the same **sendMail** action call.
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

### [Send-MgUserMessage](Send-MgUserMessage.md)
Send an existing draft message.
The draft message can be a new message draft, reply draft, reply-all draft, or a forward draft.
This method saves the message in the **Sent Items** folder.
Alternatively, send a new message in a single operation.

### [Send-MgUserTeamworkActivityNotification](Send-MgUserTeamworkActivityNotification.md)
Send an activity feed notification to a user.
For more details about sending notifications and the requirements for doing so, see sending Teams activity notifications.

### [Set-MgUserLicense](Set-MgUserLicense.md)
Invoke action assignLicense

### [Set-MgUserPresence](Set-MgUserPresence.md)
Set the state of a user's presence session as an application.

### [Set-MgUserPresenceUserPreferredPresence](Set-MgUserPresenceUserPreferredPresence.md)
Set the preferred availability and activity status for a user.
If the preferred presence of a user is set, the user's presence shows as the preferred status.
Preferred presence takes effect only when at least one presence session exists for the user.
Otherwise, the user's presence shows as `Offline`.
A presence session is created as a result of a successful setPresence operation, or if the user is signed in on a Microsoft Teams client.
For more details, see presence sessions and time-out and expiration.

### [Skip-MgUserManagedDeviceActivationLock](Skip-MgUserManagedDeviceActivationLock.md)
Bypass activation lock

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

### [Sync-MgUserManagedDevice](Sync-MgUserManagedDevice.md)
Invoke action syncDevice

### [Test-MgUserDriveItemPermission](Test-MgUserDriveItemPermission.md)
Invoke action validatePermission

### [Test-MgUserDriveRootPermission](Test-MgUserDriveRootPermission.md)
Invoke action validatePermission

### [Test-MgUserProperty](Test-MgUserProperty.md)
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

