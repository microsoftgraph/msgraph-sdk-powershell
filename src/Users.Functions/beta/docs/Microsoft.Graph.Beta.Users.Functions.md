---
Module Name: Microsoft.Graph.Beta.Users.Functions
Module Guid: f3605f58-b195-4958-b3cc-22c2d5ff287e
Download Help Link: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.users.functions
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Beta.Users.Functions Module
## Description
Microsoft Graph PowerShell Cmdlets

## Microsoft.Graph.Beta.Users.Functions Cmdlets
### [Export-MgBetaUserDeviceAndAppManagementData](Export-MgBetaUserDeviceAndAppManagementData.md)
Invoke function exportDeviceAndAppManagementData

### [Find-MgBetaUserRoom](Find-MgBetaUserRoom.md)
Invoke function findRooms

### [Find-MgBetaUserRoomList](Find-MgBetaUserRoomList.md)
Get the room lists defined in a tenant, as represented by their emailAddress objects.
Tenants can organize meeting rooms into room lists.
In this API, each meeting room and room list is represented by an emailAddress instance.\nYou can get all the room lists in the tenant, get all the rooms in the tenant, or get all the rooms in a specific room list.

### [Get-MgBetaAllUserChatMessage](Get-MgBetaAllUserChatMessage.md)
Invoke function getAllMessages

### [Get-MgBetaAllUserOnlineMeetingRecording](Get-MgBetaAllUserOnlineMeetingRecording.md)
Invoke function getAllRecordings

### [Get-MgBetaAllUserOnlineMeetingTranscript](Get-MgBetaAllUserOnlineMeetingTranscript.md)
Invoke function getAllTranscripts

### [Get-MgBetaUserCalendarEventDelta](Get-MgBetaUserCalendarEventDelta.md)
Get a set of event resources that have been added, deleted, or updated in one or more calendars.
You can get specific types of these incremental changes in the events in all the calendars of a mailbox or in a specific calendar, or in an event collection of a calendarView (range of events defined by start and end dates) of a calendar.
The calendar can be the default calendar or some other specified calendar of the user's.
In the case of getting incremental changes on calendarView, the calendar can be a group calendar as well.
Typically, synchronizing events in a calendar or calendarView in a local store entails a round of multiple delta function calls.
The initial call is a full synchronization, and every subsequent delta call in the same round gets the incremental changes (additions, deletions, or updates).
This allows you to maintain and synchronize a local store of events in the specified calendar, without having to fetch all the events of that calendar from the server every time.
The following table lists the differences between the delta function on events and the delta function on a calendarView in a calendar.

### [Get-MgBetaUserChatMessageDelta](Get-MgBetaUserChatMessageDelta.md)
Invoke function delta

### [Get-MgBetaUserChatMessageReplyDelta](Get-MgBetaUserChatMessageReplyDelta.md)
Invoke function delta

### [Get-MgBetaUserChatRetainedMessage](Get-MgBetaUserChatRetainedMessage.md)
Invoke function getAllRetainedMessages

### [Get-MgBetaUserCloudPcConnectivityHistory](Get-MgBetaUserCloudPcConnectivityHistory.md)
Invoke function getCloudPcConnectivityHistory

### [Get-MgBetaUserCloudPcFrontlineCloudPcAccessState](Get-MgBetaUserCloudPcFrontlineCloudPcAccessState.md)
Invoke function getFrontlineCloudPcAccessState

### [Get-MgBetaUserCloudPcLaunchInfo](Get-MgBetaUserCloudPcLaunchInfo.md)
Invoke function getCloudPcLaunchInfo

### [Get-MgBetaUserCloudPcProvisionedCloudPc](Get-MgBetaUserCloudPcProvisionedCloudPc.md)
Invoke function getProvisionedCloudPCs

### [Get-MgBetaUserCloudPcShiftWorkCloudPcAccessState](Get-MgBetaUserCloudPcShiftWorkCloudPcAccessState.md)
Invoke function getShiftWorkCloudPcAccessState

### [Get-MgBetaUserCloudPcSupportedCloudPcRemoteAction](Get-MgBetaUserCloudPcSupportedCloudPcRemoteAction.md)
Invoke function getSupportedCloudPcRemoteActions

### [Get-MgBetaUserContactDelta](Get-MgBetaUserContactDelta.md)
Get a set of contacts that have been added, deleted, or updated in a specified folder.
A delta function call for contacts in a folder is similar to a GET request, except that by appropriately \napplying state tokens in one or more of these calls, \nyou can query for incremental changes in the contacts in \nthat folder.
This allows you to maintain and synchronize a local store of a user's contacts without \nhaving to fetch the entire set of contacts from the server every time.

### [Get-MgBetaUserContactFolderChildFolderContactDelta](Get-MgBetaUserContactFolderChildFolderContactDelta.md)
Get a set of contacts that have been added, deleted, or updated in a specified folder.
A delta function call for contacts in a folder is similar to a GET request, except that by appropriately \napplying state tokens in one or more of these calls, \nyou can query for incremental changes in the contacts in \nthat folder.
This allows you to maintain and synchronize a local store of a user's contacts without \nhaving to fetch the entire set of contacts from the server every time.

### [Get-MgBetaUserContactFolderChildFolderDelta](Get-MgBetaUserContactFolderChildFolderDelta.md)
Get a set of contact folders that have been added, deleted, or removed from the user's mailbox.
A delta function call for contact folders in a mailbox is similar to a GET request, except that by appropriately \napplying state tokens in one or more of these calls, \nyou can query for incremental changes in the contact folders.
This allows you to maintain and synchronize \na local store of a user's contact folders without having to fetch all the contact folders of that mailbox from the server every time.

### [Get-MgBetaUserContactFolderContactDelta](Get-MgBetaUserContactFolderContactDelta.md)
Get a set of contacts that have been added, deleted, or updated in a specified folder.
A delta function call for contacts in a folder is similar to a GET request, except that by appropriately \napplying state tokens in one or more of these calls, \nyou can query for incremental changes in the contacts in \nthat folder.
This allows you to maintain and synchronize a local store of a user's contacts without \nhaving to fetch the entire set of contacts from the server every time.

### [Get-MgBetaUserContactFolderDelta](Get-MgBetaUserContactFolderDelta.md)
Get a set of contact folders that have been added, deleted, or removed from the user's mailbox.
A delta function call for contact folders in a mailbox is similar to a GET request, except that by appropriately \napplying state tokens in one or more of these calls, \nyou can query for incremental changes in the contact folders.
This allows you to maintain and synchronize \na local store of a user's contact folders without having to fetch all the contact folders of that mailbox from the server every time.

### [Get-MgBetaUserDelta](Get-MgBetaUserDelta.md)
Invoke function delta

### [Get-MgBetaUserDeviceDelta](Get-MgBetaUserDeviceDelta.md)
Invoke function delta

### [Get-MgBetaUserDriveItemActivityByInterval](Get-MgBetaUserDriveItemActivityByInterval.md)
Invoke function getActivitiesByInterval

### [Get-MgBetaUserDriveItemDelta](Get-MgBetaUserDriveItemDelta.md)
Invoke function delta

### [Get-MgBetaUserDriveItemListItemActivityByInterval](Get-MgBetaUserDriveItemListItemActivityByInterval.md)
Invoke function getActivitiesByInterval

### [Get-MgBetaUserDriveListContentTypeCompatibleHubContentType](Get-MgBetaUserDriveListContentTypeCompatibleHubContentType.md)
Invoke function getCompatibleHubContentTypes

### [Get-MgBetaUserDriveListItemActivityByInterval](Get-MgBetaUserDriveListItemActivityByInterval.md)
Invoke function getActivitiesByInterval

### [Get-MgBetaUserDriveListItemDelta](Get-MgBetaUserDriveListItemDelta.md)
Invoke function delta

### [Get-MgBetaUserDriveRootActivityByInterval](Get-MgBetaUserDriveRootActivityByInterval.md)
Invoke function getActivitiesByInterval

### [Get-MgBetaUserDriveRootDelta](Get-MgBetaUserDriveRootDelta.md)
Invoke function delta

### [Get-MgBetaUserDriveRootListItemActivityByInterval](Get-MgBetaUserDriveRootListItemActivityByInterval.md)
Invoke function getActivitiesByInterval

### [Get-MgBetaUserEffectiveDeviceEnrollmentConfiguration](Get-MgBetaUserEffectiveDeviceEnrollmentConfiguration.md)
Invoke function getEffectiveDeviceEnrollmentConfigurations

### [Get-MgBetaUserEventDelta](Get-MgBetaUserEventDelta.md)
Get a set of event resources that have been added, deleted, or updated in one or more calendars.
You can get specific types of these incremental changes in the events in all the calendars of a mailbox or in a specific calendar, or in an event collection of a calendarView (range of events defined by start and end dates) of a calendar.
The calendar can be the default calendar or some other specified calendar of the user's.
In the case of getting incremental changes on calendarView, the calendar can be a group calendar as well.
Typically, synchronizing events in a calendar or calendarView in a local store entails a round of multiple delta function calls.
The initial call is a full synchronization, and every subsequent delta call in the same round gets the incremental changes (additions, deletions, or updates).
This allows you to maintain and synchronize a local store of events in the specified calendar, without having to fetch all the events of that calendar from the server every time.
The following table lists the differences between the delta function on events and the delta function on a calendarView in a calendar.

### [Get-MgBetaUserEventInstanceDelta](Get-MgBetaUserEventInstanceDelta.md)
Get a set of event resources that have been added, deleted, or updated in one or more calendars.
You can get specific types of these incremental changes in the events in all the calendars of a mailbox or in a specific calendar, or in an event collection of a calendarView (range of events defined by start and end dates) of a calendar.
The calendar can be the default calendar or some other specified calendar of the user's.
In the case of getting incremental changes on calendarView, the calendar can be a group calendar as well.
Typically, synchronizing events in a calendar or calendarView in a local store entails a round of multiple delta function calls.
The initial call is a full synchronization, and every subsequent delta call in the same round gets the incremental changes (additions, deletions, or updates).
This allows you to maintain and synchronize a local store of events in the specified calendar, without having to fetch all the events of that calendar from the server every time.
The following table lists the differences between the delta function on events and the delta function on a calendarView in a calendar.

### [Get-MgBetaUserLicenseDetailTeamLicensingDetail](Get-MgBetaUserLicenseDetailTeamLicensingDetail.md)
Invoke function getTeamsLicensingDetails

### [Get-MgBetaUserLoggedOnManagedDevice](Get-MgBetaUserLoggedOnManagedDevice.md)
Invoke function getLoggedOnManagedDevices

### [Get-MgBetaUserMailFolderChildFolderDelta](Get-MgBetaUserMailFolderChildFolderDelta.md)
Get a set of mail folders that have been added, deleted, or removed from the user's mailbox.
A delta function call for mail folders in a mailbox is similar to a GET request, except that by appropriately\napplying state tokens in one or more of these calls,\nyou can query for incremental changes in the mail folders.
This allows you to maintain and synchronize\na local store of a user's mail folders without having to fetch all the mail folders of that mailbox from the server every time.

### [Get-MgBetaUserMailFolderChildFolderMessageDelta](Get-MgBetaUserMailFolderChildFolderMessageDelta.md)
Get a set of messages that have been added, deleted, or updated in a specified folder.
A delta function call for messages in a folder is similar to a GET request, except that by appropriately\napplying state tokens in one or more of these calls, you can [query for incremental changes in the messages in\nthat folder](/graph/delta-query-messages).
This allows you to maintain and synchronize a local store of a user's messages without\nhaving to fetch the entire set of messages from the server every time.

### [Get-MgBetaUserMailFolderDelta](Get-MgBetaUserMailFolderDelta.md)
Get a set of mail folders that have been added, deleted, or removed from the user's mailbox.
A delta function call for mail folders in a mailbox is similar to a GET request, except that by appropriately\napplying state tokens in one or more of these calls,\nyou can query for incremental changes in the mail folders.
This allows you to maintain and synchronize\na local store of a user's mail folders without having to fetch all the mail folders of that mailbox from the server every time.

### [Get-MgBetaUserMailFolderMessageDelta](Get-MgBetaUserMailFolderMessageDelta.md)
Get a set of messages that have been added, deleted, or updated in a specified folder.
A delta function call for messages in a folder is similar to a GET request, except that by appropriately\napplying state tokens in one or more of these calls, you can [query for incremental changes in the messages in\nthat folder](/graph/delta-query-messages).
This allows you to maintain and synchronize a local store of a user's messages without\nhaving to fetch the entire set of messages from the server every time.

### [Get-MgBetaUserManagedAppBlockedUser](Get-MgBetaUserManagedAppBlockedUser.md)
Invoke function getManagedAppBlockedUsers

### [Get-MgBetaUserManagedAppDiagnosticStatus](Get-MgBetaUserManagedAppDiagnosticStatus.md)
Gets diagnostics validation status for a given user.

### [Get-MgBetaUserManagedAppPolicy](Get-MgBetaUserManagedAppPolicy.md)
Gets app restrictions for a given user.

### [Get-MgBetaUserManagedDeviceCloudPcRemoteActionResult](Get-MgBetaUserManagedDeviceCloudPcRemoteActionResult.md)
Invoke function getCloudPcRemoteActionResults

### [Get-MgBetaUserManagedDeviceCloudPcReviewStatus](Get-MgBetaUserManagedDeviceCloudPcReviewStatus.md)
Invoke function getCloudPcReviewStatus

### [Get-MgBetaUserManagedDeviceFileVaultKey](Get-MgBetaUserManagedDeviceFileVaultKey.md)
Invoke function getFileVaultKey

### [Get-MgBetaUserManagedDeviceNonCompliantSetting](Get-MgBetaUserManagedDeviceNonCompliantSetting.md)
Invoke function getNonCompliantSettings

### [Get-MgBetaUserManagedDeviceWithAppFailure](Get-MgBetaUserManagedDeviceWithAppFailure.md)
Retrieves the list of devices with failed apps

### [Get-MgBetaUserManagedDeviceWithFailedApp](Get-MgBetaUserManagedDeviceWithFailedApp.md)
Retrieves the list of devices with failed or pending apps

### [Get-MgBetaUserMessageDelta](Get-MgBetaUserMessageDelta.md)
Get a set of messages that have been added, deleted, or updated in a specified folder.
A delta function call for messages in a folder is similar to a GET request, except that by appropriately\napplying state tokens in one or more of these calls, you can [query for incremental changes in the messages in\nthat folder](/graph/delta-query-messages).
This allows you to maintain and synchronize a local store of a user's messages without\nhaving to fetch the entire set of messages from the server every time.

### [Get-MgBetaUserOnenoteRecentNotebook](Get-MgBetaUserOnenoteRecentNotebook.md)
Invoke function getRecentNotebooks

### [Get-MgBetaUserOnlineMeetingJoinWebUrlVirtualAppointmentJoinWebUrl](Get-MgBetaUserOnlineMeetingJoinWebUrlVirtualAppointmentJoinWebUrl.md)
Invoke function getVirtualAppointmentJoinWebUrl

### [Get-MgBetaUserOnlineMeetingRecordingDelta](Get-MgBetaUserOnlineMeetingRecordingDelta.md)
Invoke function delta

### [Get-MgBetaUserOnlineMeetingTranscriptDelta](Get-MgBetaUserOnlineMeetingTranscriptDelta.md)
Invoke function delta

### [Get-MgBetaUserOnlineMeetingVirtualAppointmentJoinWebUrl](Get-MgBetaUserOnlineMeetingVirtualAppointmentJoinWebUrl.md)
Invoke function getVirtualAppointmentJoinWebUrl

### [Get-MgBetaUserPlannerAllDelta](Get-MgBetaUserPlannerAllDelta.md)
Invoke function delta

### [Get-MgBetaUserPlannerPlanBucketDelta](Get-MgBetaUserPlannerPlanBucketDelta.md)
Invoke function delta

### [Get-MgBetaUserPlannerPlanBucketTaskDelta](Get-MgBetaUserPlannerPlanBucketTaskDelta.md)
Invoke function delta

### [Get-MgBetaUserPlannerPlanDelta](Get-MgBetaUserPlannerPlanDelta.md)
Invoke function delta

### [Get-MgBetaUserPlannerPlanTaskDelta](Get-MgBetaUserPlannerPlanTaskDelta.md)
Invoke function delta

### [Get-MgBetaUserPlannerTaskDelta](Get-MgBetaUserPlannerTaskDelta.md)
Invoke function delta

### [Get-MgBetaUserTodoListDelta](Get-MgBetaUserTodoListDelta.md)
Invoke function delta

### [Get-MgBetaUserTodoTaskDelta](Get-MgBetaUserTodoTaskDelta.md)
Invoke function delta

### [Invoke-MgBetaAppUserManagedDeviceDiagnostic](Invoke-MgBetaAppUserManagedDeviceDiagnostic.md)
Invoke function appDiagnostics

### [Invoke-MgBetaCalendarUserCalendarAllowedCalendarSharingRoles](Invoke-MgBetaCalendarUserCalendarAllowedCalendarSharingRoles.md)
Invoke function allowedCalendarSharingRoles

### [Invoke-MgBetaFilterUserAppConsentRequestForApprovalByCurrentUser](Invoke-MgBetaFilterUserAppConsentRequestForApprovalByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgBetaFilterUserAppConsentRequestForApprovalUserConsentRequestByCurrentUser](Invoke-MgBetaFilterUserAppConsentRequestForApprovalUserConsentRequestByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgBetaFilterUserApprovalByCurrentUser](Invoke-MgBetaFilterUserApprovalByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgBetaFilterUserPendingAccessReviewInstanceByCurrentUser](Invoke-MgBetaFilterUserPendingAccessReviewInstanceByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgBetaFilterUserPendingAccessReviewInstanceDecisionByCurrentUser](Invoke-MgBetaFilterUserPendingAccessReviewInstanceDecisionByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgBetaFilterUserPendingAccessReviewInstanceStageByCurrentUser](Invoke-MgBetaFilterUserPendingAccessReviewInstanceStageByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgBetaGraphUserDrive](Invoke-MgBetaGraphUserDrive.md)
Invoke function sharedWithMe

### [Invoke-MgBetaMessageUserChat](Invoke-MgBetaMessageUserChat.md)
Invoke function allMessages

### [Invoke-MgBetaPendingUserApp](Invoke-MgBetaPendingUserApp.md)
Retrieves the list of devices with failed or pending apps

### [Invoke-MgBetaPreviewUserOnenotePage](Invoke-MgBetaPreviewUserOnenotePage.md)
Invoke function preview

### [Invoke-MgBetaRecentUserActivity](Invoke-MgBetaRecentUserActivity.md)
Invoke function recent

### [Invoke-MgBetaRecentUserDrive](Invoke-MgBetaRecentUserDrive.md)
Invoke function recent

### [Invoke-MgBetaSupportedUserOutlookLanguage](Invoke-MgBetaSupportedUserOutlookLanguage.md)
Get the list of locales and languages that are supported for the user, as configured on the user's mailbox server.
When setting up an Outlook client, the user selects the preferred language from this supported list.
You can subsequently get the preferred language by\ngetting the user's mailbox settings.

### [Invoke-MgBetaTimeUserOutlook](Invoke-MgBetaTimeUserOutlook.md)
Invoke function supportedTimeZones

### [Invoke-MgBetaViewUserReminder](Invoke-MgBetaViewUserReminder.md)
Invoke function reminderView

### [Search-MgBetaUserDrive](Search-MgBetaUserDrive.md)
Invoke function search

### [Search-MgBetaUserDriveItem](Search-MgBetaUserDriveItem.md)
Invoke function search

### [Search-MgBetaUserDriveRoot](Search-MgBetaUserDriveRoot.md)
Invoke function search

### [Test-MgBetaUserDriveListContentTypePublished](Test-MgBetaUserDriveListContentTypePublished.md)
Invoke function isPublished

### [Test-MgBetaUserManagedAppUserBlocked](Test-MgBetaUserManagedAppUserBlocked.md)
Gets the blocked state of a managed app user.

