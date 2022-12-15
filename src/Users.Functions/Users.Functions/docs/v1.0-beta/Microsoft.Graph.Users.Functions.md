---
Module Name: Microsoft.Graph.Users.Functions
Module Guid: 46532500-4dc8-4891-89a5-faa92fe9efca
Download Help Link: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.users.functions
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Users.Functions Module
## Description
Microsoft Graph PowerShell Cmdlets

## Microsoft.Graph.Users.Functions Cmdlets
### [Export-MgUserDeviceAndAppManagementData](Export-MgUserDeviceAndAppManagementData.md)
Invoke function exportDeviceAndAppManagementData

### [Find-MgUserRoom](Find-MgUserRoom.md)
Invoke function findRooms

### [Find-MgUserRoomList](Find-MgUserRoomList.md)
Get the room lists defined in a tenant, as represented by their emailAddress objects.
Tenants can organize meeting rooms into room lists.
In this API, each meeting room and room list is represented by an emailAddress instance.\nYou can get all the room lists in the tenant, get all the rooms in the tenant, or get all the rooms in a specific room list.

### [Get-MgAllUserChatMessage](Get-MgAllUserChatMessage.md)
Invoke function getAllMessages

### [Get-MgUserCalendarEventDelta](Get-MgUserCalendarEventDelta.md)
Get a set of event resources that have been added, deleted, or updated in one or more calendars.
You can get specific types of these incremental changes in the events in all the calendars of a mailbox or in a specific calendar, or in an event collection of a **calendarView** (range of events defined by start and end dates) of a calendar.
The calendar can be the default calendar or some other specified calendar of the user's.
In the case of getting incremental changes on **calendarView**, the calendar can be a group calendar as well.
Typically, synchronizing events in a calendar or **calendarView** in a local store entails a round of multiple **delta** function calls.
The initial call is a full synchronization, and every subsequent **delta** call in the same round gets the incremental changes (additions, deletions, or updates).
This allows you to maintain and synchronize a local store of events in the specified calendar, without having to fetch all the events of that calendar from the server every time.
The following table lists the differences between the **delta** function on events and the **delta** function on a **calendarView** in a calendar.

### [Get-MgUserChatMessageDelta](Get-MgUserChatMessageDelta.md)
Invoke function delta

### [Get-MgUserChatMessageReplyDelta](Get-MgUserChatMessageReplyDelta.md)
Invoke function delta

### [Get-MgUserCloudPcConnectivityHistory](Get-MgUserCloudPcConnectivityHistory.md)
Invoke function getCloudPcConnectivityHistory

### [Get-MgUserCloudPcLaunchInfo](Get-MgUserCloudPcLaunchInfo.md)
Invoke function getCloudPcLaunchInfo

### [Get-MgUserCloudPcShiftWorkCloudPcAccessState](Get-MgUserCloudPcShiftWorkCloudPcAccessState.md)
Invoke function getShiftWorkCloudPcAccessState

### [Get-MgUserCloudPcSupportedCloudPcRemoteAction](Get-MgUserCloudPcSupportedCloudPcRemoteAction.md)
Invoke function getSupportedCloudPcRemoteActions

### [Get-MgUserContactDelta](Get-MgUserContactDelta.md)
Get a set of contacts that have been added, deleted, or updated in a specified folder.
A **delta** function call for contacts in a folder is similar to a GET request, except that by appropriately \napplying state tokens in one or more of these calls, \nyou can query for incremental changes in the contacts in \nthat folder.
This allows you to maintain and synchronize a local store of a user's contacts without \nhaving to fetch the entire set of contacts from the server every time.

### [Get-MgUserContactFolderChildFolderContactDelta](Get-MgUserContactFolderChildFolderContactDelta.md)
Get a set of contacts that have been added, deleted, or updated in a specified folder.
A **delta** function call for contacts in a folder is similar to a GET request, except that by appropriately \napplying state tokens in one or more of these calls, \nyou can query for incremental changes in the contacts in \nthat folder.
This allows you to maintain and synchronize a local store of a user's contacts without \nhaving to fetch the entire set of contacts from the server every time.

### [Get-MgUserContactFolderChildFolderDelta](Get-MgUserContactFolderChildFolderDelta.md)
Get a set of contact folders that have been added, deleted, or removed from the user's mailbox.
A **delta** function call for contact folders in a mailbox is similar to a GET request, except that by appropriately \napplying state tokens in one or more of these calls, \nyou can query for incremental changes in the contact folders.
This allows you to maintain and synchronize \na local store of a user's contact folders without having to fetch all the contact folders of that mailbox from the server every time.

### [Get-MgUserContactFolderContactDelta](Get-MgUserContactFolderContactDelta.md)
Get a set of contacts that have been added, deleted, or updated in a specified folder.
A **delta** function call for contacts in a folder is similar to a GET request, except that by appropriately \napplying state tokens in one or more of these calls, \nyou can query for incremental changes in the contacts in \nthat folder.
This allows you to maintain and synchronize a local store of a user's contacts without \nhaving to fetch the entire set of contacts from the server every time.

### [Get-MgUserContactFolderDelta](Get-MgUserContactFolderDelta.md)
Get a set of contact folders that have been added, deleted, or removed from the user's mailbox.
A **delta** function call for contact folders in a mailbox is similar to a GET request, except that by appropriately \napplying state tokens in one or more of these calls, \nyou can query for incremental changes in the contact folders.
This allows you to maintain and synchronize \na local store of a user's contact folders without having to fetch all the contact folders of that mailbox from the server every time.

### [Get-MgUserDelta](Get-MgUserDelta.md)
Invoke function delta

### [Get-MgUserDeviceDelta](Get-MgUserDeviceDelta.md)
Invoke function delta

### [Get-MgUserDriveItemActivityByInterval](Get-MgUserDriveItemActivityByInterval.md)
Invoke function getActivitiesByInterval

### [Get-MgUserDriveItemDelta](Get-MgUserDriveItemDelta.md)
Invoke function delta

### [Get-MgUserDriveItemListItemActivityByInterval](Get-MgUserDriveItemListItemActivityByInterval.md)
Invoke function getActivitiesByInterval

### [Get-MgUserDriveListContentTypeCompatibleHubContentType](Get-MgUserDriveListContentTypeCompatibleHubContentType.md)
Invoke function getCompatibleHubContentTypes

### [Get-MgUserDriveListItemActivityByInterval](Get-MgUserDriveListItemActivityByInterval.md)
Invoke function getActivitiesByInterval

### [Get-MgUserDriveListItemDelta](Get-MgUserDriveListItemDelta.md)
Invoke function delta

### [Get-MgUserDriveRootActivityByInterval](Get-MgUserDriveRootActivityByInterval.md)
Invoke function getActivitiesByInterval

### [Get-MgUserDriveRootDelta](Get-MgUserDriveRootDelta.md)
Invoke function delta

### [Get-MgUserDriveRootListItemActivityByInterval](Get-MgUserDriveRootListItemActivityByInterval.md)
Invoke function getActivitiesByInterval

### [Get-MgUserEffectiveDeviceEnrollmentConfiguration](Get-MgUserEffectiveDeviceEnrollmentConfiguration.md)
Invoke function getEffectiveDeviceEnrollmentConfigurations

### [Get-MgUserEventDelta](Get-MgUserEventDelta.md)
Get a set of event resources that have been added, deleted, or updated in one or more calendars.
You can get specific types of these incremental changes in the events in all the calendars of a mailbox or in a specific calendar, or in an event collection of a **calendarView** (range of events defined by start and end dates) of a calendar.
The calendar can be the default calendar or some other specified calendar of the user's.
In the case of getting incremental changes on **calendarView**, the calendar can be a group calendar as well.
Typically, synchronizing events in a calendar or **calendarView** in a local store entails a round of multiple **delta** function calls.
The initial call is a full synchronization, and every subsequent **delta** call in the same round gets the incremental changes (additions, deletions, or updates).
This allows you to maintain and synchronize a local store of events in the specified calendar, without having to fetch all the events of that calendar from the server every time.
The following table lists the differences between the **delta** function on events and the **delta** function on a **calendarView** in a calendar.

### [Get-MgUserEventInstanceDelta](Get-MgUserEventInstanceDelta.md)
Get a set of event resources that have been added, deleted, or updated in one or more calendars.
You can get specific types of these incremental changes in the events in all the calendars of a mailbox or in a specific calendar, or in an event collection of a **calendarView** (range of events defined by start and end dates) of a calendar.
The calendar can be the default calendar or some other specified calendar of the user's.
In the case of getting incremental changes on **calendarView**, the calendar can be a group calendar as well.
Typically, synchronizing events in a calendar or **calendarView** in a local store entails a round of multiple **delta** function calls.
The initial call is a full synchronization, and every subsequent **delta** call in the same round gets the incremental changes (additions, deletions, or updates).
This allows you to maintain and synchronize a local store of events in the specified calendar, without having to fetch all the events of that calendar from the server every time.
The following table lists the differences between the **delta** function on events and the **delta** function on a **calendarView** in a calendar.

### [Get-MgUserLoggedOnManagedDevice](Get-MgUserLoggedOnManagedDevice.md)
Invoke function getLoggedOnManagedDevices

### [Get-MgUserMailFolderChildFolderDelta](Get-MgUserMailFolderChildFolderDelta.md)
Get a set of mail folders that have been added, deleted, or removed from the user's mailbox.
A **delta** function call for mail folders in a mailbox is similar to a GET request, except that by appropriately \napplying state tokens in one or more of these calls, \nyou can query for incremental changes in the mail folders.
This allows you to maintain and synchronize \na local store of a user's mail folders without having to fetch all the mail folders of that mailbox from the server every time.

### [Get-MgUserMailFolderChildFolderMessageDelta](Get-MgUserMailFolderChildFolderMessageDelta.md)
Get a set of messages that have been added, deleted, or updated in a specified folder.
A **delta** function call for messages in a folder is similar to a GET request, except that by appropriately \napplying state tokens in one or more of these calls, you can [query for incremental changes in the messages in \nthat folder](/graph/delta-query-messages).
This allows you to maintain and synchronize a local store of a user's messages without \nhaving to fetch the entire set of messages from the server every time.

### [Get-MgUserMailFolderDelta](Get-MgUserMailFolderDelta.md)
Get a set of mail folders that have been added, deleted, or removed from the user's mailbox.
A **delta** function call for mail folders in a mailbox is similar to a GET request, except that by appropriately \napplying state tokens in one or more of these calls, \nyou can query for incremental changes in the mail folders.
This allows you to maintain and synchronize \na local store of a user's mail folders without having to fetch all the mail folders of that mailbox from the server every time.

### [Get-MgUserMailFolderMessageDelta](Get-MgUserMailFolderMessageDelta.md)
Get a set of messages that have been added, deleted, or updated in a specified folder.
A **delta** function call for messages in a folder is similar to a GET request, except that by appropriately \napplying state tokens in one or more of these calls, you can [query for incremental changes in the messages in \nthat folder](/graph/delta-query-messages).
This allows you to maintain and synchronize a local store of a user's messages without \nhaving to fetch the entire set of messages from the server every time.

### [Get-MgUserManagedAppBlockedUser](Get-MgUserManagedAppBlockedUser.md)
Invoke function getManagedAppBlockedUsers

### [Get-MgUserManagedAppDiagnosticStatuses](Get-MgUserManagedAppDiagnosticStatuses.md)
Gets diagnostics validation status for a given user.

### [Get-MgUserManagedAppPolicy](Get-MgUserManagedAppPolicy.md)
Gets app restrictions for a given user.

### [Get-MgUserManagedDeviceCloudPcRemoteActionResult](Get-MgUserManagedDeviceCloudPcRemoteActionResult.md)
Invoke function getCloudPcRemoteActionResults

### [Get-MgUserManagedDeviceCloudPcReviewStatus](Get-MgUserManagedDeviceCloudPcReviewStatus.md)
Invoke function getCloudPcReviewStatus

### [Get-MgUserManagedDeviceFileVaultKey](Get-MgUserManagedDeviceFileVaultKey.md)
Invoke function getFileVaultKey

### [Get-MgUserManagedDeviceNonCompliantSetting](Get-MgUserManagedDeviceNonCompliantSetting.md)
Invoke function getNonCompliantSettings

### [Get-MgUserManagedDeviceOemWarranty](Get-MgUserManagedDeviceOemWarranty.md)
Invoke function getOemWarranty

### [Get-MgUserManagedDeviceRemoteHelpSession](Get-MgUserManagedDeviceRemoteHelpSession.md)
Invoke function retrieveRemoteHelpSession

### [Get-MgUserManagedDeviceWithAppFailure](Get-MgUserManagedDeviceWithAppFailure.md)
Retrieves the list of devices with failed apps

### [Get-MgUserManagedDeviceWithFailedApp](Get-MgUserManagedDeviceWithFailedApp.md)
Retrieves the list of devices with failed or pending apps

### [Get-MgUserMessageDelta](Get-MgUserMessageDelta.md)
Get a set of messages that have been added, deleted, or updated in a specified folder.
A **delta** function call for messages in a folder is similar to a GET request, except that by appropriately \napplying state tokens in one or more of these calls, you can [query for incremental changes in the messages in \nthat folder](/graph/delta-query-messages).
This allows you to maintain and synchronize a local store of a user's messages without \nhaving to fetch the entire set of messages from the server every time.

### [Get-MgUserOnenoteRecentNotebook](Get-MgUserOnenoteRecentNotebook.md)
Invoke function getRecentNotebooks

### [Get-MgUserPlannerAllDelta](Get-MgUserPlannerAllDelta.md)
Invoke function delta

### [Get-MgUserTodoListDelta](Get-MgUserTodoListDelta.md)
Invoke function delta

### [Get-MgUserTodoListTaskDelta](Get-MgUserTodoListTaskDelta.md)
Invoke function delta

### [Invoke-MgAppUserManagedDeviceDiagnostic](Invoke-MgAppUserManagedDeviceDiagnostic.md)
Invoke function appDiagnostics

### [Invoke-MgCalendarUserCalendarAllowedCalendarSharingRoles](Invoke-MgCalendarUserCalendarAllowedCalendarSharingRoles.md)
Invoke function allowedCalendarSharingRoles

### [Invoke-MgFilterUserAppConsentRequestForApprovalByCurrentUser](Invoke-MgFilterUserAppConsentRequestForApprovalByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterUserAppConsentRequestForApprovalUserConsentRequestByCurrentUser](Invoke-MgFilterUserAppConsentRequestForApprovalUserConsentRequestByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterUserApprovalByCurrentUser](Invoke-MgFilterUserApprovalByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterUserPendingAccessReviewInstanceByCurrentUser](Invoke-MgFilterUserPendingAccessReviewInstanceByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterUserPendingAccessReviewInstanceDecisionByCurrentUser](Invoke-MgFilterUserPendingAccessReviewInstanceDecisionByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterUserPendingAccessReviewInstanceStageByCurrentUser](Invoke-MgFilterUserPendingAccessReviewInstanceStageByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgGraphUserDrive](Invoke-MgGraphUserDrive.md)
Invoke function sharedWithMe

### [Invoke-MgMessageUserChat](Invoke-MgMessageUserChat.md)
Invoke function allMessages

### [Invoke-MgPendingUserApp](Invoke-MgPendingUserApp.md)
Retrieves the list of devices with failed or pending apps

### [Invoke-MgPreviewUserOnenotePage](Invoke-MgPreviewUserOnenotePage.md)
Invoke function preview

### [Invoke-MgRecentUserActivity](Invoke-MgRecentUserActivity.md)
Invoke function recent

### [Invoke-MgRecentUserDrive](Invoke-MgRecentUserDrive.md)
Invoke function recent

### [Invoke-MgSupportedUserOutlookLanguage](Invoke-MgSupportedUserOutlookLanguage.md)
Get the list of locales and languages that are supported for the user, as configured on the user's mailbox server.
When setting up an Outlook client, the user selects the preferred language from this supported list.
You can subsequently get the preferred language by \ngetting the user's mailbox settings.

### [Invoke-MgTimeUserOutlook](Invoke-MgTimeUserOutlook.md)
Invoke function supportedTimeZones

### [Invoke-MgViewUserReminder](Invoke-MgViewUserReminder.md)
Invoke function reminderView

### [Search-MgUserDrive](Search-MgUserDrive.md)
Invoke function search

### [Search-MgUserDriveItem](Search-MgUserDriveItem.md)
Invoke function search

### [Search-MgUserDriveRoot](Search-MgUserDriveRoot.md)
Invoke function search

### [Test-MgUserDriveListContentTypePublished](Test-MgUserDriveListContentTypePublished.md)
Invoke function isPublished

### [Test-MgUserManagedAppUserBlocked](Test-MgUserManagedAppUserBlocked.md)
Gets the blocked state of a managed app user.

