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
### [Get-MgAllUserChatMessage](Get-MgAllUserChatMessage.md)
Invoke function getAllMessages

### [Get-MgUserCalendarEventDelta](Get-MgUserCalendarEventDelta.md)
Get a set of event resources that have been added, deleted, or updated in a **calendarView** (a range of events defined by start and end dates) of the user's primary calendar.
Typically, synchronizing events in a **calendarView** in a local store entails a round of multiple **delta** function calls.
The initial call is a full synchronization, and every subsequent **delta** call in the same round gets the incremental changes (additions, deletions, or updates).
This allows you to maintain and synchronize a local store of events in the specified **calendarView**, without having to fetch all the events of that calendar from the server every time.

### [Get-MgUserChatMessageDelta](Get-MgUserChatMessageDelta.md)
Invoke function delta

### [Get-MgUserChatMessageReplyDelta](Get-MgUserChatMessageReplyDelta.md)
Invoke function delta

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

### [Get-MgUserDriveRootActivityByInterval](Get-MgUserDriveRootActivityByInterval.md)
Invoke function getActivitiesByInterval

### [Get-MgUserDriveRootDelta](Get-MgUserDriveRootDelta.md)
Invoke function delta

### [Get-MgUserDriveRootListItemActivityByInterval](Get-MgUserDriveRootListItemActivityByInterval.md)
Invoke function getActivitiesByInterval

### [Get-MgUserEventDelta](Get-MgUserEventDelta.md)
Get a set of event resources that have been added, deleted, or updated in a **calendarView** (a range of events defined by start and end dates) of the user's primary calendar.
Typically, synchronizing events in a **calendarView** in a local store entails a round of multiple **delta** function calls.
The initial call is a full synchronization, and every subsequent **delta** call in the same round gets the incremental changes (additions, deletions, or updates).
This allows you to maintain and synchronize a local store of events in the specified **calendarView**, without having to fetch all the events of that calendar from the server every time.

### [Get-MgUserEventInstanceDelta](Get-MgUserEventInstanceDelta.md)
Get a set of event resources that have been added, deleted, or updated in a **calendarView** (a range of events defined by start and end dates) of the user's primary calendar.
Typically, synchronizing events in a **calendarView** in a local store entails a round of multiple **delta** function calls.
The initial call is a full synchronization, and every subsequent **delta** call in the same round gets the incremental changes (additions, deletions, or updates).
This allows you to maintain and synchronize a local store of events in the specified **calendarView**, without having to fetch all the events of that calendar from the server every time.

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

### [Get-MgUserManagedAppDiagnosticStatuses](Get-MgUserManagedAppDiagnosticStatuses.md)
Gets diagnostics validation status for a given user.

### [Get-MgUserManagedAppPolicy](Get-MgUserManagedAppPolicy.md)
Gets app restrictions for a given user.

### [Get-MgUserMessageDelta](Get-MgUserMessageDelta.md)
Get a set of messages that have been added, deleted, or updated in a specified folder.
A **delta** function call for messages in a folder is similar to a GET request, except that by appropriately \napplying state tokens in one or more of these calls, you can [query for incremental changes in the messages in \nthat folder](/graph/delta-query-messages).
This allows you to maintain and synchronize a local store of a user's messages without \nhaving to fetch the entire set of messages from the server every time.

### [Get-MgUserOnenoteRecentNotebook](Get-MgUserOnenoteRecentNotebook.md)
Invoke function getRecentNotebooks

### [Get-MgUserTodoListDelta](Get-MgUserTodoListDelta.md)
Invoke function delta

### [Get-MgUserTodoListTaskDelta](Get-MgUserTodoListTaskDelta.md)
Invoke function delta

### [Invoke-MgCalendarUserCalendarAllowedCalendarSharingRoles](Invoke-MgCalendarUserCalendarAllowedCalendarSharingRoles.md)
Invoke function allowedCalendarSharingRoles

### [Invoke-MgGraphUserDrive](Invoke-MgGraphUserDrive.md)
Invoke function sharedWithMe

### [Invoke-MgPreviewUserOnenotePage](Invoke-MgPreviewUserOnenotePage.md)
Invoke function preview

### [Invoke-MgRecentUserActivity](Invoke-MgRecentUserActivity.md)
Get recent activities for a given user.
This OData function has some default behaviors included to make it operate like a 'most recently used' API.
The service will query for the most recent historyItems, and then pull those related activities.
Activities will be sorted according to the most recent **lastModified** on the **historyItem**.
This means that activities without **historyItems** will not be included in the response.
The UserActivity.ReadWrite.CreatedByApp permission will also apply extra filtering to the response, so that only activities created by your application are returned.
This server-side filtering might result in empty pages if the user is particularly active and other applications have created more recent activities.
To get your application's activities, use the **nextLink** property to paginate.

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

