---
Module Name: Microsoft.Graph.Teams
Module Guid: 6a8f508a-ce85-44e3-b3b2-7a63c766b6bc
Download Help Link: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.teams
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Teams Module
## Description
Microsoft Graph PowerShell Cmdlets

## Microsoft.Graph.Teams Cmdlets
### [Add-MgChatMember](Add-MgChatMember.md)
Add multiple members in a single request to a team.
The response provides details about which memberships could and couldn't be created.

### [Add-MgTeamChannelMember](Add-MgTeamChannelMember.md)
Add multiple members in a single request to a team.
The response provides details about which memberships could and couldn't be created.

### [Add-MgTeamMember](Add-MgTeamMember.md)
Add multiple members in a single request to a team.
The response provides details about which memberships could and couldn't be created.

### [Add-MgTeamPrimaryChannelMember](Add-MgTeamPrimaryChannelMember.md)
Add multiple members in a single request to a team.
The response provides details about which memberships could and couldn't be created.

### [Complete-MgTeamChannelMigration](Complete-MgTeamChannelMigration.md)
Complete the message migration process by removing `migration mode` from a channel in a team.
`Migration mode` is a special state that prevents certain operations, like sending messages and adding members, during the data migration process.
After a **completeMigration** request is made, you cannot import additional messages into the team.
You can add members to the team after the request returns a successful response.

### [Complete-MgTeamMigration](Complete-MgTeamMigration.md)
Complete the message migration process by removing `migration mode` from a team.
`Migration mode` is a special state where certain operations are barred, like message POST and membership operations during the data migration process.
After a **completeMigration** request is made, you cannot import additional messages into the team.
You can add members to the team after the request returns a successful response.

### [Complete-MgTeamPrimaryChannelMigration](Complete-MgTeamPrimaryChannelMigration.md)
Complete the message migration process by removing `migration mode` from a channel in a team.
`Migration mode` is a special state that prevents certain operations, like sending messages and adding members, during the data migration process.
After a **completeMigration** request is made, you cannot import additional messages into the team.
You can add members to the team after the request returns a successful response.

### [Copy-MgTeam](Copy-MgTeam.md)
Create a copy of a team.
This operation also creates a copy of the corresponding group.\nYou can specify which parts of the team to clone: When tabs are cloned, they are put into an unconfigured state \n-- they are displayed on the tab bar in Microsoft Teams, and the first time you open them, you'll go through the configuration screen.
\n(If the person opening the tab does not have permission to configure apps, they will see a message explaining that the tab hasn't been configured.) Cloning is a long-running operation.\nAfter the POST clone returns, you need to GET the operation to see if it's 'running' or 'succeeded' or 'failed'.
\nYou should continue to GET until the status is not 'running'.
\nThe recommended delay between GETs is 5 seconds.

### [Get-MgAllGroupTeamChannel](Get-MgAllGroupTeamChannel.md)
List of channels either hosted in or shared with the team (incoming channels).

### [Get-MgAllTeamChannel](Get-MgAllTeamChannel.md)
List of channels either hosted in or shared with the team (incoming channels).

### [Get-MgAppCatalogTeamApp](Get-MgAppCatalogTeamApp.md)
Get teamsApps from appCatalogs

### [Get-MgAppCatalogTeamAppDefinition](Get-MgAppCatalogTeamAppDefinition.md)
The details for each version of the app.

### [Get-MgAppCatalogTeamAppDefinitionBot](Get-MgAppCatalogTeamAppDefinitionBot.md)
Get the bot associated with a specific definition of the  TeamsApp.

### [Get-MgChat](Get-MgChat.md)
Retrieve a single chat (without its messages).
This method supports federation.
To access a chat, at least one chat member must belong to the tenant the request initiated from.

### [Get-MgChatInstalledApp](Get-MgChatInstalledApp.md)
A collection of all the apps in the chat.
Nullable.

### [Get-MgChatInstalledAppTeamApp](Get-MgChatInstalledAppTeamApp.md)
The app that is installed.

### [Get-MgChatInstalledAppTeamAppDefinition](Get-MgChatInstalledAppTeamAppDefinition.md)
The details of this version of the app.

### [Get-MgChatLastMessagePreview](Get-MgChatLastMessagePreview.md)
Preview of the last message sent in the chat.
Null if no messages have been sent in the chat.
Currently, only the list chats operation supports this property.

### [Get-MgChatMember](Get-MgChatMember.md)
A collection of all the members in the chat.
Nullable.

### [Get-MgChatMessage](Get-MgChatMessage.md)
A collection of all the messages in the chat.
Nullable.

### [Get-MgChatMessageDelta](Get-MgChatMessageDelta.md)
Invoke function delta

### [Get-MgChatMessageHostedContent](Get-MgChatMessageHostedContent.md)
Content in a message hosted by Microsoft Teams - for example, images or code snippets.

### [Get-MgChatMessageReply](Get-MgChatMessageReply.md)
Replies for a specified message.
Supports $expand for channel messages.

### [Get-MgChatMessageReplyDelta](Get-MgChatMessageReplyDelta.md)
Invoke function delta

### [Get-MgChatMessageReplyHostedContent](Get-MgChatMessageReplyHostedContent.md)
Content in a message hosted by Microsoft Teams - for example, images or code snippets.

### [Get-MgChatPinnedMessage](Get-MgChatPinnedMessage.md)
A collection of all the pinned messages in the chat.
Nullable.

### [Get-MgChatTab](Get-MgChatTab.md)
A collection of all the tabs in the chat.
Nullable.

### [Get-MgChatTabTeamApp](Get-MgChatTabTeamApp.md)
The application that is linked to the tab.
This cannot be changed after tab creation.

### [Get-MgGroupTeam](Get-MgGroupTeam.md)
The team associated with this group.

### [Get-MgGroupTeamChannel](Get-MgGroupTeamChannel.md)
The collection of channels and messages associated with the team.

### [Get-MgGroupTeamChannelFileFolder](Get-MgGroupTeamChannelFileFolder.md)
Get the metadata for the location where the files of a channel are stored.

### [Get-MgGroupTeamChannelFileFolderContent](Get-MgGroupTeamChannelFileFolderContent.md)
The content stream, if the item represents a file.

### [Get-MgGroupTeamChannelMember](Get-MgGroupTeamChannelMember.md)
A collection of membership records associated with the channel.

### [Get-MgGroupTeamChannelMessage](Get-MgGroupTeamChannelMessage.md)
A collection of all the messages in the channel.
A navigation property.
Nullable.

### [Get-MgGroupTeamChannelMessageHostedContent](Get-MgGroupTeamChannelMessageHostedContent.md)
Content in a message hosted by Microsoft Teams - for example, images or code snippets.

### [Get-MgGroupTeamChannelMessageReply](Get-MgGroupTeamChannelMessageReply.md)
Replies for a specified message.
Supports $expand for channel messages.

### [Get-MgGroupTeamChannelMessageReplyHostedContent](Get-MgGroupTeamChannelMessageReplyHostedContent.md)
Content in a message hosted by Microsoft Teams - for example, images or code snippets.

### [Get-MgGroupTeamChannelSharedWithTeam](Get-MgGroupTeamChannelSharedWithTeam.md)
A collection of teams with which a channel is shared.

### [Get-MgGroupTeamChannelSharedWithTeamAllowedMember](Get-MgGroupTeamChannelSharedWithTeamAllowedMember.md)
A collection of team members who have access to the shared channel.

### [Get-MgGroupTeamChannelTab](Get-MgGroupTeamChannelTab.md)
A collection of all the tabs in the channel.
A navigation property.

### [Get-MgGroupTeamChannelTabTeamApp](Get-MgGroupTeamChannelTabTeamApp.md)
The application that is linked to the tab.
This cannot be changed after tab creation.

### [Get-MgGroupTeamGroup](Get-MgGroupTeamGroup.md)
Get group from groups

### [Get-MgGroupTeamIncomingChannel](Get-MgGroupTeamIncomingChannel.md)
List of channels shared with the team.

### [Get-MgGroupTeamInstalledApp](Get-MgGroupTeamInstalledApp.md)
The apps installed in this team.

### [Get-MgGroupTeamInstalledAppTeamApp](Get-MgGroupTeamInstalledAppTeamApp.md)
The app that is installed.

### [Get-MgGroupTeamInstalledAppTeamAppDefinition](Get-MgGroupTeamInstalledAppTeamAppDefinition.md)
The details of this version of the app.

### [Get-MgGroupTeamMember](Get-MgGroupTeamMember.md)
Members and owners of the team.

### [Get-MgGroupTeamOperation](Get-MgGroupTeamOperation.md)
The async operations that ran or are running on this team.

### [Get-MgGroupTeamPhoto](Get-MgGroupTeamPhoto.md)
The profile photo for the team.

### [Get-MgGroupTeamPhotoContent](Get-MgGroupTeamPhotoContent.md)
Get media content for the navigation property photo from groups

### [Get-MgGroupTeamPrimaryChannel](Get-MgGroupTeamPrimaryChannel.md)
Get the default channel, **General**, of a team.

### [Get-MgGroupTeamPrimaryChannelFileFolder](Get-MgGroupTeamPrimaryChannelFileFolder.md)
Get the metadata for the location where the files of a channel are stored.

### [Get-MgGroupTeamPrimaryChannelFileFolderContent](Get-MgGroupTeamPrimaryChannelFileFolderContent.md)
The content stream, if the item represents a file.

### [Get-MgGroupTeamPrimaryChannelMember](Get-MgGroupTeamPrimaryChannelMember.md)
A collection of membership records associated with the channel.

### [Get-MgGroupTeamPrimaryChannelMessage](Get-MgGroupTeamPrimaryChannelMessage.md)
A collection of all the messages in the channel.
A navigation property.
Nullable.

### [Get-MgGroupTeamPrimaryChannelMessageHostedContent](Get-MgGroupTeamPrimaryChannelMessageHostedContent.md)
Content in a message hosted by Microsoft Teams - for example, images or code snippets.

### [Get-MgGroupTeamPrimaryChannelMessageReply](Get-MgGroupTeamPrimaryChannelMessageReply.md)
Replies for a specified message.
Supports $expand for channel messages.

### [Get-MgGroupTeamPrimaryChannelMessageReplyHostedContent](Get-MgGroupTeamPrimaryChannelMessageReplyHostedContent.md)
Content in a message hosted by Microsoft Teams - for example, images or code snippets.

### [Get-MgGroupTeamPrimaryChannelSharedWithTeam](Get-MgGroupTeamPrimaryChannelSharedWithTeam.md)
A collection of teams with which a channel is shared.

### [Get-MgGroupTeamPrimaryChannelSharedWithTeamAllowedMember](Get-MgGroupTeamPrimaryChannelSharedWithTeamAllowedMember.md)
A collection of team members who have access to the shared channel.

### [Get-MgGroupTeamPrimaryChannelTab](Get-MgGroupTeamPrimaryChannelTab.md)
A collection of all the tabs in the channel.
A navigation property.

### [Get-MgGroupTeamPrimaryChannelTabTeamApp](Get-MgGroupTeamPrimaryChannelTabTeamApp.md)
The application that is linked to the tab.
This cannot be changed after tab creation.

### [Get-MgGroupTeamSchedule](Get-MgGroupTeamSchedule.md)
Retrieve the properties and relationships of a schedule object.
The schedule creation process conforms to the One API guideline for resource based long running operations (RELO).\nWhen clients use the PUT method, if the schedule is provisioned, the operation updates the schedule; otherwise, the operation starts the schedule provisioning process in the background.
During schedule provisioning, clients can use the GET method to get the schedule and look at the `provisionStatus` property for the current state of the provisioning.
If the provisioning failed, clients can get additional information from the `provisionStatusCode` property.
Clients can also inspect the configuration of the schedule.

### [Get-MgGroupTeamScheduleOfferShiftRequest](Get-MgGroupTeamScheduleOfferShiftRequest.md)
Get offerShiftRequests from groups

### [Get-MgGroupTeamScheduleOpenShift](Get-MgGroupTeamScheduleOpenShift.md)
Get openShifts from groups

### [Get-MgGroupTeamScheduleOpenShiftChangeRequest](Get-MgGroupTeamScheduleOpenShiftChangeRequest.md)
Get openShiftChangeRequests from groups

### [Get-MgGroupTeamScheduleSchedulingGroup](Get-MgGroupTeamScheduleSchedulingGroup.md)
The logical grouping of users in the schedule (usually by role).

### [Get-MgGroupTeamScheduleShift](Get-MgGroupTeamScheduleShift.md)
The shifts in the schedule.

### [Get-MgGroupTeamScheduleSwapShiftChangeRequest](Get-MgGroupTeamScheduleSwapShiftChangeRequest.md)
Get swapShiftsChangeRequests from groups

### [Get-MgGroupTeamScheduleTimeOff](Get-MgGroupTeamScheduleTimeOff.md)
The instances of times off in the schedule.

### [Get-MgGroupTeamScheduleTimeOffReason](Get-MgGroupTeamScheduleTimeOffReason.md)
The set of reasons for a time off in the schedule.

### [Get-MgGroupTeamScheduleTimeOffRequest](Get-MgGroupTeamScheduleTimeOffRequest.md)
Get timeOffRequests from groups

### [Get-MgGroupTeamTag](Get-MgGroupTeamTag.md)
The tags associated with the team.

### [Get-MgGroupTeamTagMember](Get-MgGroupTeamTagMember.md)
Users assigned to the tag.

### [Get-MgGroupTeamTemplate](Get-MgGroupTeamTemplate.md)
The template this team was created from.
See available templates.

### [Get-MgTeam](Get-MgTeam.md)
Retrieve the properties and relationships of the specified team.

### [Get-MgTeamChannel](Get-MgTeamChannel.md)
The collection of channels and messages associated with the team.

### [Get-MgTeamChannelFileFolder](Get-MgTeamChannelFileFolder.md)
Get the metadata for the location where the files of a channel are stored.

### [Get-MgTeamChannelFileFolderContent](Get-MgTeamChannelFileFolderContent.md)
The content stream, if the item represents a file.

### [Get-MgTeamChannelMember](Get-MgTeamChannelMember.md)
A collection of membership records associated with the channel.

### [Get-MgTeamChannelMessage](Get-MgTeamChannelMessage.md)
A collection of all the messages in the channel.
A navigation property.
Nullable.

### [Get-MgTeamChannelMessageDelta](Get-MgTeamChannelMessageDelta.md)
Invoke function delta

### [Get-MgTeamChannelMessageHostedContent](Get-MgTeamChannelMessageHostedContent.md)
Content in a message hosted by Microsoft Teams - for example, images or code snippets.

### [Get-MgTeamChannelMessageReply](Get-MgTeamChannelMessageReply.md)
Replies for a specified message.
Supports $expand for channel messages.

### [Get-MgTeamChannelMessageReplyDelta](Get-MgTeamChannelMessageReplyDelta.md)
Invoke function delta

### [Get-MgTeamChannelMessageReplyHostedContent](Get-MgTeamChannelMessageReplyHostedContent.md)
Content in a message hosted by Microsoft Teams - for example, images or code snippets.

### [Get-MgTeamChannelSharedWithTeam](Get-MgTeamChannelSharedWithTeam.md)
A collection of teams with which a channel is shared.

### [Get-MgTeamChannelSharedWithTeamAllowedMember](Get-MgTeamChannelSharedWithTeamAllowedMember.md)
A collection of team members who have access to the shared channel.

### [Get-MgTeamChannelTab](Get-MgTeamChannelTab.md)
A collection of all the tabs in the channel.
A navigation property.

### [Get-MgTeamChannelTabTeamApp](Get-MgTeamChannelTabTeamApp.md)
The application that is linked to the tab.
This cannot be changed after tab creation.

### [Get-MgTeamIncomingChannel](Get-MgTeamIncomingChannel.md)
List of channels shared with the team.

### [Get-MgTeamInstalledApp](Get-MgTeamInstalledApp.md)
The apps installed in this team.

### [Get-MgTeamInstalledAppTeamApp](Get-MgTeamInstalledAppTeamApp.md)
The app that is installed.

### [Get-MgTeamInstalledAppTeamAppDefinition](Get-MgTeamInstalledAppTeamAppDefinition.md)
The details of this version of the app.

### [Get-MgTeamMember](Get-MgTeamMember.md)
Members and owners of the team.

### [Get-MgTeamMessage](Get-MgTeamMessage.md)
Invoke function getAllMessages

### [Get-MgTeamOperation](Get-MgTeamOperation.md)
The async operations that ran or are running on this team.

### [Get-MgTeamPhoto](Get-MgTeamPhoto.md)
The profile photo for the team.

### [Get-MgTeamPhotoContent](Get-MgTeamPhotoContent.md)
Get media content for the navigation property photo from teams

### [Get-MgTeamPrimaryChannel](Get-MgTeamPrimaryChannel.md)
Get the default channel, **General**, of a team.

### [Get-MgTeamPrimaryChannelFileFolder](Get-MgTeamPrimaryChannelFileFolder.md)
Get the metadata for the location where the files of a channel are stored.

### [Get-MgTeamPrimaryChannelFileFolderContent](Get-MgTeamPrimaryChannelFileFolderContent.md)
The content stream, if the item represents a file.

### [Get-MgTeamPrimaryChannelMember](Get-MgTeamPrimaryChannelMember.md)
A collection of membership records associated with the channel.

### [Get-MgTeamPrimaryChannelMessage](Get-MgTeamPrimaryChannelMessage.md)
A collection of all the messages in the channel.
A navigation property.
Nullable.

### [Get-MgTeamPrimaryChannelMessageDelta](Get-MgTeamPrimaryChannelMessageDelta.md)
Invoke function delta

### [Get-MgTeamPrimaryChannelMessageHostedContent](Get-MgTeamPrimaryChannelMessageHostedContent.md)
Content in a message hosted by Microsoft Teams - for example, images or code snippets.

### [Get-MgTeamPrimaryChannelMessageReply](Get-MgTeamPrimaryChannelMessageReply.md)
Replies for a specified message.
Supports $expand for channel messages.

### [Get-MgTeamPrimaryChannelMessageReplyDelta](Get-MgTeamPrimaryChannelMessageReplyDelta.md)
Invoke function delta

### [Get-MgTeamPrimaryChannelMessageReplyHostedContent](Get-MgTeamPrimaryChannelMessageReplyHostedContent.md)
Content in a message hosted by Microsoft Teams - for example, images or code snippets.

### [Get-MgTeamPrimaryChannelSharedWithTeam](Get-MgTeamPrimaryChannelSharedWithTeam.md)
A collection of teams with which a channel is shared.

### [Get-MgTeamPrimaryChannelSharedWithTeamAllowedMember](Get-MgTeamPrimaryChannelSharedWithTeamAllowedMember.md)
A collection of team members who have access to the shared channel.

### [Get-MgTeamPrimaryChannelTab](Get-MgTeamPrimaryChannelTab.md)
A collection of all the tabs in the channel.
A navigation property.

### [Get-MgTeamPrimaryChannelTabTeamApp](Get-MgTeamPrimaryChannelTabTeamApp.md)
The application that is linked to the tab.
This cannot be changed after tab creation.

### [Get-MgTeamSchedule](Get-MgTeamSchedule.md)
Retrieve the properties and relationships of a schedule object.
The schedule creation process conforms to the One API guideline for resource based long running operations (RELO).\nWhen clients use the PUT method, if the schedule is provisioned, the operation updates the schedule; otherwise, the operation starts the schedule provisioning process in the background.
During schedule provisioning, clients can use the GET method to get the schedule and look at the `provisionStatus` property for the current state of the provisioning.
If the provisioning failed, clients can get additional information from the `provisionStatusCode` property.
Clients can also inspect the configuration of the schedule.

### [Get-MgTeamScheduleOfferShiftRequest](Get-MgTeamScheduleOfferShiftRequest.md)
Get offerShiftRequests from teams

### [Get-MgTeamScheduleOpenShift](Get-MgTeamScheduleOpenShift.md)
Get openShifts from teams

### [Get-MgTeamScheduleOpenShiftChangeRequest](Get-MgTeamScheduleOpenShiftChangeRequest.md)
Get openShiftChangeRequests from teams

### [Get-MgTeamScheduleSchedulingGroup](Get-MgTeamScheduleSchedulingGroup.md)
The logical grouping of users in the schedule (usually by role).

### [Get-MgTeamScheduleShift](Get-MgTeamScheduleShift.md)
The shifts in the schedule.

### [Get-MgTeamScheduleSwapShiftChangeRequest](Get-MgTeamScheduleSwapShiftChangeRequest.md)
Get swapShiftsChangeRequests from teams

### [Get-MgTeamScheduleTimeOff](Get-MgTeamScheduleTimeOff.md)
The instances of times off in the schedule.

### [Get-MgTeamScheduleTimeOffReason](Get-MgTeamScheduleTimeOffReason.md)
The set of reasons for a time off in the schedule.

### [Get-MgTeamScheduleTimeOffRequest](Get-MgTeamScheduleTimeOffRequest.md)
Get timeOffRequests from teams

### [Get-MgTeamTag](Get-MgTeamTag.md)
The tags associated with the team.

### [Get-MgTeamTagMember](Get-MgTeamTagMember.md)
Users assigned to the tag.

### [Get-MgTeamTemplate](Get-MgTeamTemplate.md)
The template this team was created from.
See available templates.

### [Get-MgTeamwork](Get-MgTeamwork.md)
Get teamwork

### [Get-MgTeamworkWorkforceIntegration](Get-MgTeamworkWorkforceIntegration.md)
Get workforceIntegrations from teamwork

### [Get-MgUserChat](Get-MgUserChat.md)
Get chats from users

### [Get-MgUserChatInstalledApp](Get-MgUserChatInstalledApp.md)
A collection of all the apps in the chat.
Nullable.

### [Get-MgUserChatInstalledAppTeamApp](Get-MgUserChatInstalledAppTeamApp.md)
The app that is installed.

### [Get-MgUserChatInstalledAppTeamAppDefinition](Get-MgUserChatInstalledAppTeamAppDefinition.md)
The details of this version of the app.

### [Get-MgUserChatLastMessagePreview](Get-MgUserChatLastMessagePreview.md)
Preview of the last message sent in the chat.
Null if no messages have been sent in the chat.
Currently, only the list chats operation supports this property.

### [Get-MgUserChatMember](Get-MgUserChatMember.md)
A collection of all the members in the chat.
Nullable.

### [Get-MgUserChatMessage](Get-MgUserChatMessage.md)
A collection of all the messages in the chat.
Nullable.

### [Get-MgUserChatMessageHostedContent](Get-MgUserChatMessageHostedContent.md)
Content in a message hosted by Microsoft Teams - for example, images or code snippets.

### [Get-MgUserChatMessageReply](Get-MgUserChatMessageReply.md)
Replies for a specified message.
Supports $expand for channel messages.

### [Get-MgUserChatMessageReplyHostedContent](Get-MgUserChatMessageReplyHostedContent.md)
Content in a message hosted by Microsoft Teams - for example, images or code snippets.

### [Get-MgUserChatPinnedMessage](Get-MgUserChatPinnedMessage.md)
A collection of all the pinned messages in the chat.
Nullable.

### [Get-MgUserChatTab](Get-MgUserChatTab.md)
A collection of all the tabs in the chat.
Nullable.

### [Get-MgUserChatTabTeamApp](Get-MgUserChatTabTeamApp.md)
The application that is linked to the tab.
This cannot be changed after tab creation.

### [Get-MgUserJoinedTeam](Get-MgUserJoinedTeam.md)
Get the teams in Microsoft Teams that the user is a direct member of.

### [Get-MgUserTeamwork](Get-MgUserTeamwork.md)
Get teamwork from users

### [Get-MgUserTeamworkAssociatedTeam](Get-MgUserTeamworkAssociatedTeam.md)
The list of associatedTeamInfo objects that a user is associated with.

### [Get-MgUserTeamworkInstalledApp](Get-MgUserTeamworkInstalledApp.md)
The apps installed in the personal scope of this user.

### [Get-MgUserTeamworkInstalledAppChat](Get-MgUserTeamworkInstalledAppChat.md)
Retrieve the chat of the specified user and Teams app.

### [Hide-MgChatForUser](Hide-MgChatForUser.md)
Hide a chat for a user.

### [Invoke-MgArchiveTeam](Invoke-MgArchiveTeam.md)
Archive the specified team.
\nWhen a team is archived, users can no longer send or like messages on any channel in the team, edit the team's name, description, or other settings, or in general make most changes to the team.\nMembership changes to the team continue to be allowed.
Archiving is an async operation.
A team is archived once the async operation completes successfully, which may occur subsequent to a response from this API.
To archive a team, the team and group must have an owner.
To restore a team from its archived state, use the API to unarchive.

### [Invoke-MgGraphChat](Invoke-MgGraphChat.md)
Unhide a chat for a user.

### [Invoke-MgHaveTeamChannel](Invoke-MgHaveTeamChannel.md)
Invoke function doesUserHaveAccess

### [Invoke-MgHaveTeamPrimaryChannel](Invoke-MgHaveTeamPrimaryChannel.md)
Invoke function doesUserHaveAccess

### [Invoke-MgMarkChatReadForUser](Invoke-MgMarkChatReadForUser.md)
Mark a chat as read for a user.

### [Invoke-MgMarkChatUnreadForUser](Invoke-MgMarkChatUnreadForUser.md)
Mark a chat as unread for a user.

### [Invoke-MgShareTeamSchedule](Invoke-MgShareTeamSchedule.md)
Share a schedule time range with schedule members.\nMake the collections of shift, openshift and timeOff items in the specified time range of the schedule viewable by the specified team members, including employees and managers.\nEach shift, openshift and timeOff instance in a schedule supports a draft version and a shared version of the item.
The draft version is viewable by only managers, and the shared version is viewable by employees and managers.
For each shift, openshift and timeOff instance in the specified time range, the share action updates the shared version from the draft version, so that in addition to managers, employees can also view the most current information about the item.
The **notifyTeam** parameter further specifies which employees can view the item.

### [Invoke-MgUnarchiveTeam](Invoke-MgUnarchiveTeam.md)
Restore an archived team.
This restores users' ability to send messages and edit the team, abiding by tenant and team settings.
Teams are archived using the archive API.
Unarchiving is an async operation.
A team is unarchived once the async operation completes successfully, which may occur subsequent to a response from this API.

### [New-MgAppCatalogTeamApp](New-MgAppCatalogTeamApp.md)
Publish an app to the Microsoft Teams apps catalog.\nSpecifically, this API publishes the app to your organization's catalog (the tenant app catalog);\nthe created resource will have a **distributionMethod** property value of `organization`.
The **requiresReview** property allows any user to submit an app for review by an administrator.
Admins can approve or reject these apps via this API or the Microsoft Teams admin center.

### [New-MgAppCatalogTeamAppDefinition](New-MgAppCatalogTeamAppDefinition.md)
Update an app previously published to the Microsoft Teams app catalog.
To update an app, the **distributionMethod** property for the app must be set to `organization`.
This API specifically updates an app published to your organization's app catalog (the tenant app catalog).

### [New-MgChat](New-MgChat.md)
Create a new chat object.

### [New-MgChatInstalledApp](New-MgChatInstalledApp.md)
Install a teamsApp to the specified chat.

### [New-MgChatMember](New-MgChatMember.md)
Add a conversationMember to a chat.

### [New-MgChatMessage](New-MgChatMessage.md)
Send a new chatMessage in the specified chat.
This API can't create a new chat; you must use the list chats method to retrieve the ID of an existing chat before you can create a chat message.

### [New-MgChatMessageHostedContent](New-MgChatMessageHostedContent.md)
Create new navigation property to hostedContents for chats

### [New-MgChatMessageReply](New-MgChatMessageReply.md)
Create a new reply to a chatMessage in a specified channel.

### [New-MgChatMessageReplyHostedContent](New-MgChatMessageReplyHostedContent.md)
Create new navigation property to hostedContents for chats

### [New-MgChatPinnedMessage](New-MgChatPinnedMessage.md)
Pin a chat message in the specified chat.
This API cannot create a new chat; you must use the list chats method to retrieve the ID of an existing chat before you can pin a chat message.

### [New-MgChatTab](New-MgChatTab.md)
Add (pin) a tab to the specified chat.
\nThe corresponding app must already be installed in the chat.

### [New-MgGroupTeamChannel](New-MgGroupTeamChannel.md)
Create a new channel in a team, as specified in the request body.

### [New-MgGroupTeamChannelMember](New-MgGroupTeamChannelMember.md)
Add a conversationMember to a channel.
This operation is allowed only for channels with a **membershipType** value of `private` or `shared`.

### [New-MgGroupTeamChannelMessage](New-MgGroupTeamChannelMessage.md)
Send a new chatMessage in the specified channel or a chat.

### [New-MgGroupTeamChannelMessageHostedContent](New-MgGroupTeamChannelMessageHostedContent.md)
Create new navigation property to hostedContents for groups

### [New-MgGroupTeamChannelMessageReply](New-MgGroupTeamChannelMessageReply.md)
Create a new reply to a chatMessage in a specified channel.

### [New-MgGroupTeamChannelMessageReplyHostedContent](New-MgGroupTeamChannelMessageReplyHostedContent.md)
Create new navigation property to hostedContents for groups

### [New-MgGroupTeamChannelSharedWithTeam](New-MgGroupTeamChannelSharedWithTeam.md)
Create new navigation property to sharedWithTeams for groups

### [New-MgGroupTeamChannelTab](New-MgGroupTeamChannelTab.md)
Create new navigation property to tabs for groups

### [New-MgGroupTeamInstalledApp](New-MgGroupTeamInstalledApp.md)
Install an app to the specified team.

### [New-MgGroupTeamMember](New-MgGroupTeamMember.md)
Add a new conversationMember to a team.

### [New-MgGroupTeamOperation](New-MgGroupTeamOperation.md)
Create new navigation property to operations for groups

### [New-MgGroupTeamPrimaryChannelMember](New-MgGroupTeamPrimaryChannelMember.md)
Add a conversationMember to a channel.
This operation is allowed only for channels with a **membershipType** value of `private` or `shared`.

### [New-MgGroupTeamPrimaryChannelMessage](New-MgGroupTeamPrimaryChannelMessage.md)
Send a new chatMessage in the specified channel or a chat.

### [New-MgGroupTeamPrimaryChannelMessageHostedContent](New-MgGroupTeamPrimaryChannelMessageHostedContent.md)
Create new navigation property to hostedContents for groups

### [New-MgGroupTeamPrimaryChannelMessageReply](New-MgGroupTeamPrimaryChannelMessageReply.md)
Create a new reply to a chatMessage in a specified channel.

### [New-MgGroupTeamPrimaryChannelMessageReplyHostedContent](New-MgGroupTeamPrimaryChannelMessageReplyHostedContent.md)
Create new navigation property to hostedContents for groups

### [New-MgGroupTeamPrimaryChannelSharedWithTeam](New-MgGroupTeamPrimaryChannelSharedWithTeam.md)
Create new navigation property to sharedWithTeams for groups

### [New-MgGroupTeamPrimaryChannelTab](New-MgGroupTeamPrimaryChannelTab.md)
Create new navigation property to tabs for groups

### [New-MgGroupTeamScheduleOfferShiftRequest](New-MgGroupTeamScheduleOfferShiftRequest.md)
Create new navigation property to offerShiftRequests for groups

### [New-MgGroupTeamScheduleOpenShift](New-MgGroupTeamScheduleOpenShift.md)
Create new navigation property to openShifts for groups

### [New-MgGroupTeamScheduleOpenShiftChangeRequest](New-MgGroupTeamScheduleOpenShiftChangeRequest.md)
Create instance of an openShiftChangeRequest object.

### [New-MgGroupTeamScheduleSchedulingGroup](New-MgGroupTeamScheduleSchedulingGroup.md)
Create a new schedulingGroup.

### [New-MgGroupTeamScheduleShift](New-MgGroupTeamScheduleShift.md)
Create a new shift instance in a schedule.

### [New-MgGroupTeamScheduleSwapShiftChangeRequest](New-MgGroupTeamScheduleSwapShiftChangeRequest.md)
Create an instance of a swapShiftsChangeRequest object.

### [New-MgGroupTeamScheduleTimeOff](New-MgGroupTeamScheduleTimeOff.md)
Create a new timeOff instance in a schedule.

### [New-MgGroupTeamScheduleTimeOffReason](New-MgGroupTeamScheduleTimeOffReason.md)
Create a new timeOffReason.

### [New-MgGroupTeamScheduleTimeOffRequest](New-MgGroupTeamScheduleTimeOffRequest.md)
Create new navigation property to timeOffRequests for groups

### [New-MgGroupTeamTag](New-MgGroupTeamTag.md)
Create a standard tag for members in a team.

### [New-MgGroupTeamTagMember](New-MgGroupTeamTagMember.md)
Create a new teamworkTagMember object in a team.

### [New-MgTeam](New-MgTeam.md)
Create a new team.

### [New-MgTeamChannel](New-MgTeamChannel.md)
Create a new channel in a team, as specified in the request body.

### [New-MgTeamChannelEmail](New-MgTeamChannelEmail.md)
Provision an email address for a channel.
Microsoft Teams doesn't automatically provision an email address for a **channel** by default.
To have Teams provision an email address, you can call **provisionEmail**, or through the Teams user interface, select **Get email address**, which triggers Teams to generate an email address if it has not already provisioned one.
To remove the email address of a **channel**, use the removeEmail method.

### [New-MgTeamChannelMember](New-MgTeamChannelMember.md)
Add a conversationMember to a channel.
This operation is allowed only for channels with a **membershipType** value of `private` or `shared`.

### [New-MgTeamChannelMessage](New-MgTeamChannelMessage.md)
Send a new chatMessage in the specified channel or a chat.

### [New-MgTeamChannelMessageHostedContent](New-MgTeamChannelMessageHostedContent.md)
Create new navigation property to hostedContents for teams

### [New-MgTeamChannelMessageReply](New-MgTeamChannelMessageReply.md)
Create a new reply to a chatMessage in a specified channel.

### [New-MgTeamChannelMessageReplyHostedContent](New-MgTeamChannelMessageReplyHostedContent.md)
Create new navigation property to hostedContents for teams

### [New-MgTeamChannelSharedWithTeam](New-MgTeamChannelSharedWithTeam.md)
Create new navigation property to sharedWithTeams for teams

### [New-MgTeamChannelTab](New-MgTeamChannelTab.md)
Create new navigation property to tabs for teams

### [New-MgTeamInstalledApp](New-MgTeamInstalledApp.md)
Install an app to the specified team.

### [New-MgTeamMember](New-MgTeamMember.md)
Add a new conversationMember to a team.

### [New-MgTeamOperation](New-MgTeamOperation.md)
Create new navigation property to operations for teams

### [New-MgTeamPrimaryChannelEmail](New-MgTeamPrimaryChannelEmail.md)
Provision an email address for a channel.
Microsoft Teams doesn't automatically provision an email address for a **channel** by default.
To have Teams provision an email address, you can call **provisionEmail**, or through the Teams user interface, select **Get email address**, which triggers Teams to generate an email address if it has not already provisioned one.
To remove the email address of a **channel**, use the removeEmail method.

### [New-MgTeamPrimaryChannelMember](New-MgTeamPrimaryChannelMember.md)
Add a conversationMember to a channel.
This operation is allowed only for channels with a **membershipType** value of `private` or `shared`.

### [New-MgTeamPrimaryChannelMessage](New-MgTeamPrimaryChannelMessage.md)
Send a new chatMessage in the specified channel or a chat.

### [New-MgTeamPrimaryChannelMessageHostedContent](New-MgTeamPrimaryChannelMessageHostedContent.md)
Create new navigation property to hostedContents for teams

### [New-MgTeamPrimaryChannelMessageReply](New-MgTeamPrimaryChannelMessageReply.md)
Create a new reply to a chatMessage in a specified channel.

### [New-MgTeamPrimaryChannelMessageReplyHostedContent](New-MgTeamPrimaryChannelMessageReplyHostedContent.md)
Create new navigation property to hostedContents for teams

### [New-MgTeamPrimaryChannelSharedWithTeam](New-MgTeamPrimaryChannelSharedWithTeam.md)
Create new navigation property to sharedWithTeams for teams

### [New-MgTeamPrimaryChannelTab](New-MgTeamPrimaryChannelTab.md)
Create new navigation property to tabs for teams

### [New-MgTeamScheduleOfferShiftRequest](New-MgTeamScheduleOfferShiftRequest.md)
Create new navigation property to offerShiftRequests for teams

### [New-MgTeamScheduleOpenShift](New-MgTeamScheduleOpenShift.md)
Create new navigation property to openShifts for teams

### [New-MgTeamScheduleOpenShiftChangeRequest](New-MgTeamScheduleOpenShiftChangeRequest.md)
Create instance of an openShiftChangeRequest object.

### [New-MgTeamScheduleSchedulingGroup](New-MgTeamScheduleSchedulingGroup.md)
Create a new schedulingGroup.

### [New-MgTeamScheduleShift](New-MgTeamScheduleShift.md)
Create a new shift instance in a schedule.

### [New-MgTeamScheduleSwapShiftChangeRequest](New-MgTeamScheduleSwapShiftChangeRequest.md)
Create an instance of a swapShiftsChangeRequest object.

### [New-MgTeamScheduleTimeOff](New-MgTeamScheduleTimeOff.md)
Create a new timeOff instance in a schedule.

### [New-MgTeamScheduleTimeOffReason](New-MgTeamScheduleTimeOffReason.md)
Create a new timeOffReason.

### [New-MgTeamScheduleTimeOffRequest](New-MgTeamScheduleTimeOffRequest.md)
Create new navigation property to timeOffRequests for teams

### [New-MgTeamTag](New-MgTeamTag.md)
Create a standard tag for members in a team.

### [New-MgTeamTagMember](New-MgTeamTagMember.md)
Create a new teamworkTagMember object in a team.

### [New-MgTeamworkWorkforceIntegration](New-MgTeamworkWorkforceIntegration.md)
Create a new workforceIntegration object.\nYou can set up which entities you want to receive Shifts synchronous change notifications on and set entities to configure filtering by WFM rules eligibility for, including swap requests.

### [New-MgUserChat](New-MgUserChat.md)
Create new navigation property to chats for users

### [New-MgUserChatInstalledApp](New-MgUserChatInstalledApp.md)
Install a teamsApp to the specified chat.

### [New-MgUserChatMember](New-MgUserChatMember.md)
Add a conversationMember to a chat.

### [New-MgUserChatMessage](New-MgUserChatMessage.md)
Send a new chatMessage in the specified chat.
This API can't create a new chat; you must use the list chats method to retrieve the ID of an existing chat before you can create a chat message.

### [New-MgUserChatMessageHostedContent](New-MgUserChatMessageHostedContent.md)
Create new navigation property to hostedContents for users

### [New-MgUserChatMessageReply](New-MgUserChatMessageReply.md)
Create a new reply to a chatMessage in a specified channel.

### [New-MgUserChatMessageReplyHostedContent](New-MgUserChatMessageReplyHostedContent.md)
Create new navigation property to hostedContents for users

### [New-MgUserChatPinnedMessage](New-MgUserChatPinnedMessage.md)
Pin a chat message in the specified chat.
This API cannot create a new chat; you must use the list chats method to retrieve the ID of an existing chat before you can pin a chat message.

### [New-MgUserChatTab](New-MgUserChatTab.md)
Add (pin) a tab to the specified chat.
\nThe corresponding app must already be installed in the chat.

### [New-MgUserTeamworkAssociatedTeam](New-MgUserTeamworkAssociatedTeam.md)
Create new navigation property to associatedTeams for users

### [New-MgUserTeamworkInstalledApp](New-MgUserTeamworkInstalledApp.md)
Install an app in the personal scope of the specified user.

### [Remove-MgAppCatalogTeamApp](Remove-MgAppCatalogTeamApp.md)
Delete navigation property teamsApps for appCatalogs

### [Remove-MgAppCatalogTeamAppDefinition](Remove-MgAppCatalogTeamAppDefinition.md)
Delete navigation property appDefinitions for appCatalogs

### [Remove-MgAppCatalogTeamAppDefinitionBot](Remove-MgAppCatalogTeamAppDefinitionBot.md)
Delete navigation property bot for appCatalogs

### [Remove-MgChat](Remove-MgChat.md)
Delete entity from chats

### [Remove-MgChatInstalledApp](Remove-MgChatInstalledApp.md)
Delete navigation property installedApps for chats

### [Remove-MgChatLastMessagePreview](Remove-MgChatLastMessagePreview.md)
Delete navigation property lastMessagePreview for chats

### [Remove-MgChatMember](Remove-MgChatMember.md)
Delete navigation property members for chats

### [Remove-MgChatMessageReplyHostedContent](Remove-MgChatMessageReplyHostedContent.md)
Delete navigation property hostedContents for chats

### [Remove-MgChatPinnedMessage](Remove-MgChatPinnedMessage.md)
Delete navigation property pinnedMessages for chats

### [Remove-MgChatTab](Remove-MgChatTab.md)
Delete navigation property tabs for chats

### [Remove-MgGroupTeam](Remove-MgGroupTeam.md)
Delete navigation property team for groups

### [Remove-MgGroupTeamChannel](Remove-MgGroupTeamChannel.md)
Delete navigation property channels for groups

### [Remove-MgGroupTeamChannelMember](Remove-MgGroupTeamChannelMember.md)
Delete navigation property members for groups

### [Remove-MgGroupTeamChannelMessage](Remove-MgGroupTeamChannelMessage.md)
Delete navigation property messages for groups

### [Remove-MgGroupTeamChannelMessageHostedContent](Remove-MgGroupTeamChannelMessageHostedContent.md)
Delete navigation property hostedContents for groups

### [Remove-MgGroupTeamChannelMessageReply](Remove-MgGroupTeamChannelMessageReply.md)
Delete navigation property replies for groups

### [Remove-MgGroupTeamChannelMessageReplyHostedContent](Remove-MgGroupTeamChannelMessageReplyHostedContent.md)
Delete navigation property hostedContents for groups

### [Remove-MgGroupTeamChannelSharedWithTeam](Remove-MgGroupTeamChannelSharedWithTeam.md)
Delete navigation property sharedWithTeams for groups

### [Remove-MgGroupTeamChannelTab](Remove-MgGroupTeamChannelTab.md)
Delete navigation property tabs for groups

### [Remove-MgGroupTeamInstalledApp](Remove-MgGroupTeamInstalledApp.md)
Delete navigation property installedApps for groups

### [Remove-MgGroupTeamMember](Remove-MgGroupTeamMember.md)
Delete navigation property members for groups

### [Remove-MgGroupTeamOperation](Remove-MgGroupTeamOperation.md)
Delete navigation property operations for groups

### [Remove-MgGroupTeamPhoto](Remove-MgGroupTeamPhoto.md)
Delete navigation property photo for groups

### [Remove-MgGroupTeamPrimaryChannel](Remove-MgGroupTeamPrimaryChannel.md)
Delete navigation property primaryChannel for groups

### [Remove-MgGroupTeamPrimaryChannelMember](Remove-MgGroupTeamPrimaryChannelMember.md)
Delete navigation property members for groups

### [Remove-MgGroupTeamPrimaryChannelMessage](Remove-MgGroupTeamPrimaryChannelMessage.md)
Delete navigation property messages for groups

### [Remove-MgGroupTeamPrimaryChannelMessageHostedContent](Remove-MgGroupTeamPrimaryChannelMessageHostedContent.md)
Delete navigation property hostedContents for groups

### [Remove-MgGroupTeamPrimaryChannelMessageReply](Remove-MgGroupTeamPrimaryChannelMessageReply.md)
Delete navigation property replies for groups

### [Remove-MgGroupTeamPrimaryChannelMessageReplyHostedContent](Remove-MgGroupTeamPrimaryChannelMessageReplyHostedContent.md)
Delete navigation property hostedContents for groups

### [Remove-MgGroupTeamPrimaryChannelSharedWithTeam](Remove-MgGroupTeamPrimaryChannelSharedWithTeam.md)
Delete navigation property sharedWithTeams for groups

### [Remove-MgGroupTeamPrimaryChannelTab](Remove-MgGroupTeamPrimaryChannelTab.md)
Delete navigation property tabs for groups

### [Remove-MgGroupTeamSchedule](Remove-MgGroupTeamSchedule.md)
Delete navigation property schedule for groups

### [Remove-MgGroupTeamScheduleOfferShiftRequest](Remove-MgGroupTeamScheduleOfferShiftRequest.md)
Delete navigation property offerShiftRequests for groups

### [Remove-MgGroupTeamScheduleOpenShift](Remove-MgGroupTeamScheduleOpenShift.md)
Delete navigation property openShifts for groups

### [Remove-MgGroupTeamScheduleOpenShiftChangeRequest](Remove-MgGroupTeamScheduleOpenShiftChangeRequest.md)
Delete navigation property openShiftChangeRequests for groups

### [Remove-MgGroupTeamScheduleSchedulingGroup](Remove-MgGroupTeamScheduleSchedulingGroup.md)
Delete navigation property schedulingGroups for groups

### [Remove-MgGroupTeamScheduleShift](Remove-MgGroupTeamScheduleShift.md)
Delete navigation property shifts for groups

### [Remove-MgGroupTeamScheduleSwapShiftChangeRequest](Remove-MgGroupTeamScheduleSwapShiftChangeRequest.md)
Delete navigation property swapShiftsChangeRequests for groups

### [Remove-MgGroupTeamScheduleTimeOff](Remove-MgGroupTeamScheduleTimeOff.md)
Delete navigation property timesOff for groups

### [Remove-MgGroupTeamScheduleTimeOffReason](Remove-MgGroupTeamScheduleTimeOffReason.md)
Delete navigation property timeOffReasons for groups

### [Remove-MgGroupTeamScheduleTimeOffRequest](Remove-MgGroupTeamScheduleTimeOffRequest.md)
Delete navigation property timeOffRequests for groups

### [Remove-MgGroupTeamTag](Remove-MgGroupTeamTag.md)
Delete navigation property tags for groups

### [Remove-MgGroupTeamTagMember](Remove-MgGroupTeamTagMember.md)
Delete navigation property members for groups

### [Remove-MgTeam](Remove-MgTeam.md)
Delete entity from teams

### [Remove-MgTeamChannel](Remove-MgTeamChannel.md)
Delete navigation property channels for teams

### [Remove-MgTeamChannelEmail](Remove-MgTeamChannelEmail.md)
Remove the email address of a channel.
You can remove an email address only if it was provisioned using the provisionEmail method or through the Microsoft Teams client.

### [Remove-MgTeamChannelMember](Remove-MgTeamChannelMember.md)
Delete navigation property members for teams

### [Remove-MgTeamChannelMessageReplyHostedContent](Remove-MgTeamChannelMessageReplyHostedContent.md)
Delete navigation property hostedContents for teams

### [Remove-MgTeamChannelSharedWithTeam](Remove-MgTeamChannelSharedWithTeam.md)
Delete navigation property sharedWithTeams for teams

### [Remove-MgTeamChannelTab](Remove-MgTeamChannelTab.md)
Delete navigation property tabs for teams

### [Remove-MgTeamInstalledApp](Remove-MgTeamInstalledApp.md)
Delete navigation property installedApps for teams

### [Remove-MgTeamMember](Remove-MgTeamMember.md)
Delete navigation property members for teams

### [Remove-MgTeamOperation](Remove-MgTeamOperation.md)
Delete navigation property operations for teams

### [Remove-MgTeamPhoto](Remove-MgTeamPhoto.md)
Delete navigation property photo for teams

### [Remove-MgTeamPrimaryChannel](Remove-MgTeamPrimaryChannel.md)
Delete navigation property primaryChannel for teams

### [Remove-MgTeamPrimaryChannelEmail](Remove-MgTeamPrimaryChannelEmail.md)
Remove the email address of a channel.
You can remove an email address only if it was provisioned using the provisionEmail method or through the Microsoft Teams client.

### [Remove-MgTeamPrimaryChannelMember](Remove-MgTeamPrimaryChannelMember.md)
Delete navigation property members for teams

### [Remove-MgTeamPrimaryChannelMessageReplyHostedContent](Remove-MgTeamPrimaryChannelMessageReplyHostedContent.md)
Delete navigation property hostedContents for teams

### [Remove-MgTeamPrimaryChannelSharedWithTeam](Remove-MgTeamPrimaryChannelSharedWithTeam.md)
Delete navigation property sharedWithTeams for teams

### [Remove-MgTeamPrimaryChannelTab](Remove-MgTeamPrimaryChannelTab.md)
Delete navigation property tabs for teams

### [Remove-MgTeamSchedule](Remove-MgTeamSchedule.md)
Delete navigation property schedule for teams

### [Remove-MgTeamScheduleOfferShiftRequest](Remove-MgTeamScheduleOfferShiftRequest.md)
Delete navigation property offerShiftRequests for teams

### [Remove-MgTeamScheduleOpenShift](Remove-MgTeamScheduleOpenShift.md)
Delete navigation property openShifts for teams

### [Remove-MgTeamScheduleOpenShiftChangeRequest](Remove-MgTeamScheduleOpenShiftChangeRequest.md)
Delete navigation property openShiftChangeRequests for teams

### [Remove-MgTeamScheduleSchedulingGroup](Remove-MgTeamScheduleSchedulingGroup.md)
Delete navigation property schedulingGroups for teams

### [Remove-MgTeamScheduleShift](Remove-MgTeamScheduleShift.md)
Delete navigation property shifts for teams

### [Remove-MgTeamScheduleSwapShiftChangeRequest](Remove-MgTeamScheduleSwapShiftChangeRequest.md)
Delete navigation property swapShiftsChangeRequests for teams

### [Remove-MgTeamScheduleTimeOff](Remove-MgTeamScheduleTimeOff.md)
Delete navigation property timesOff for teams

### [Remove-MgTeamScheduleTimeOffReason](Remove-MgTeamScheduleTimeOffReason.md)
Delete navigation property timeOffReasons for teams

### [Remove-MgTeamScheduleTimeOffRequest](Remove-MgTeamScheduleTimeOffRequest.md)
Delete navigation property timeOffRequests for teams

### [Remove-MgTeamTag](Remove-MgTeamTag.md)
Delete navigation property tags for teams

### [Remove-MgTeamTagMember](Remove-MgTeamTagMember.md)
Delete navigation property members for teams

### [Remove-MgTeamworkWorkforceIntegration](Remove-MgTeamworkWorkforceIntegration.md)
Delete navigation property workforceIntegrations for teamwork

### [Remove-MgUserChat](Remove-MgUserChat.md)
Delete navigation property chats for users

### [Remove-MgUserChatInstalledApp](Remove-MgUserChatInstalledApp.md)
Delete navigation property installedApps for users

### [Remove-MgUserChatLastMessagePreview](Remove-MgUserChatLastMessagePreview.md)
Delete navigation property lastMessagePreview for users

### [Remove-MgUserChatMember](Remove-MgUserChatMember.md)
Delete navigation property members for users

### [Remove-MgUserChatMessage](Remove-MgUserChatMessage.md)
Delete navigation property messages for users

### [Remove-MgUserChatMessageHostedContent](Remove-MgUserChatMessageHostedContent.md)
Delete navigation property hostedContents for users

### [Remove-MgUserChatMessageReply](Remove-MgUserChatMessageReply.md)
Delete navigation property replies for users

### [Remove-MgUserChatMessageReplyHostedContent](Remove-MgUserChatMessageReplyHostedContent.md)
Delete navigation property hostedContents for users

### [Remove-MgUserChatPinnedMessage](Remove-MgUserChatPinnedMessage.md)
Delete navigation property pinnedMessages for users

### [Remove-MgUserChatTab](Remove-MgUserChatTab.md)
Delete navigation property tabs for users

### [Remove-MgUserTeamwork](Remove-MgUserTeamwork.md)
Delete navigation property teamwork for users

### [Remove-MgUserTeamworkAssociatedTeam](Remove-MgUserTeamworkAssociatedTeam.md)
Delete navigation property associatedTeams for users

### [Remove-MgUserTeamworkInstalledApp](Remove-MgUserTeamworkInstalledApp.md)
Delete navigation property installedApps for users

### [Send-MgChatActivityNotification](Send-MgChatActivityNotification.md)
Send an activity feed notification in scope of a chat.
For more details about sending notifications and the requirements for doing so, see sending Teams activity notifications.

### [Send-MgTeamActivityNotification](Send-MgTeamActivityNotification.md)
Send an activity feed notification in the scope of a team.
For more details about sending notifications and the requirements for doing so, see\nsending Teams activity notifications.

### [Send-MgTeamworkActivityNotificationToRecipient](Send-MgTeamworkActivityNotificationToRecipient.md)
Invoke action sendActivityNotificationToRecipients

### [Set-MgGroupTeamChannelFileFolderContent](Set-MgGroupTeamChannelFileFolderContent.md)
The content stream, if the item represents a file.

### [Set-MgGroupTeamPhotoContent](Set-MgGroupTeamPhotoContent.md)
Update media content for the navigation property photo in groups

### [Set-MgGroupTeamPrimaryChannelFileFolderContent](Set-MgGroupTeamPrimaryChannelFileFolderContent.md)
The content stream, if the item represents a file.

### [Set-MgGroupTeamSchedule](Set-MgGroupTeamSchedule.md)
Update the navigation property schedule in groups

### [Set-MgTeamChannelFileFolderContent](Set-MgTeamChannelFileFolderContent.md)
The content stream, if the item represents a file.

### [Set-MgTeamPhotoContent](Set-MgTeamPhotoContent.md)
Update media content for the navigation property photo in teams

### [Set-MgTeamPrimaryChannelFileFolderContent](Set-MgTeamPrimaryChannelFileFolderContent.md)
The content stream, if the item represents a file.

### [Set-MgTeamSchedule](Set-MgTeamSchedule.md)
Update the navigation property schedule in teams

### [Update-MgAppCatalogTeamApp](Update-MgAppCatalogTeamApp.md)
Update the navigation property teamsApps in appCatalogs

### [Update-MgAppCatalogTeamAppDefinition](Update-MgAppCatalogTeamAppDefinition.md)
Update the navigation property appDefinitions in appCatalogs

### [Update-MgAppCatalogTeamAppDefinitionBot](Update-MgAppCatalogTeamAppDefinitionBot.md)
Update the navigation property bot in appCatalogs

### [Update-MgChat](Update-MgChat.md)
Update the properties of a chat object.

### [Update-MgChatInstalledApp](Update-MgChatInstalledApp.md)
Upgrade an app installation within a chat.

### [Update-MgChatLastMessagePreview](Update-MgChatLastMessagePreview.md)
Update the navigation property lastMessagePreview in chats

### [Update-MgChatMember](Update-MgChatMember.md)
Update the navigation property members in chats

### [Update-MgChatMessage](Update-MgChatMessage.md)
Update the navigation property messages in chats

### [Update-MgChatMessageReply](Update-MgChatMessageReply.md)
Update the navigation property replies in chats

### [Update-MgChatMessageReplyHostedContent](Update-MgChatMessageReplyHostedContent.md)
Update the navigation property hostedContents in chats

### [Update-MgChatPinnedMessage](Update-MgChatPinnedMessage.md)
Update the navigation property pinnedMessages in chats

### [Update-MgChatTab](Update-MgChatTab.md)
Update the navigation property tabs in chats

### [Update-MgGroupTeam](Update-MgGroupTeam.md)
Create a new team under a group.
In order to create a team, the group must have a least one owner.
If the group was created less than 15 minutes ago, it's possible for the Create team call to fail with a 404 error code due to replication delays.
\nThe recommended pattern is to retry the Create team call three times, with a 10 second delay between calls.

### [Update-MgGroupTeamChannel](Update-MgGroupTeamChannel.md)
Update the navigation property channels in groups

### [Update-MgGroupTeamChannelMember](Update-MgGroupTeamChannelMember.md)
Update the navigation property members in groups

### [Update-MgGroupTeamChannelMessage](Update-MgGroupTeamChannelMessage.md)
Update the navigation property messages in groups

### [Update-MgGroupTeamChannelMessageHostedContent](Update-MgGroupTeamChannelMessageHostedContent.md)
Update the navigation property hostedContents in groups

### [Update-MgGroupTeamChannelMessageReply](Update-MgGroupTeamChannelMessageReply.md)
Update the navigation property replies in groups

### [Update-MgGroupTeamChannelMessageReplyHostedContent](Update-MgGroupTeamChannelMessageReplyHostedContent.md)
Update the navigation property hostedContents in groups

### [Update-MgGroupTeamChannelSharedWithTeam](Update-MgGroupTeamChannelSharedWithTeam.md)
Update the navigation property sharedWithTeams in groups

### [Update-MgGroupTeamChannelTab](Update-MgGroupTeamChannelTab.md)
Update the navigation property tabs in groups

### [Update-MgGroupTeamMember](Update-MgGroupTeamMember.md)
Update the navigation property members in groups

### [Update-MgGroupTeamOperation](Update-MgGroupTeamOperation.md)
Update the navigation property operations in groups

### [Update-MgGroupTeamPhoto](Update-MgGroupTeamPhoto.md)
Update the navigation property photo in groups

### [Update-MgGroupTeamPrimaryChannel](Update-MgGroupTeamPrimaryChannel.md)
Update the navigation property primaryChannel in groups

### [Update-MgGroupTeamPrimaryChannelMember](Update-MgGroupTeamPrimaryChannelMember.md)
Update the navigation property members in groups

### [Update-MgGroupTeamPrimaryChannelMessage](Update-MgGroupTeamPrimaryChannelMessage.md)
Update the navigation property messages in groups

### [Update-MgGroupTeamPrimaryChannelMessageHostedContent](Update-MgGroupTeamPrimaryChannelMessageHostedContent.md)
Update the navigation property hostedContents in groups

### [Update-MgGroupTeamPrimaryChannelMessageReply](Update-MgGroupTeamPrimaryChannelMessageReply.md)
Update the navigation property replies in groups

### [Update-MgGroupTeamPrimaryChannelMessageReplyHostedContent](Update-MgGroupTeamPrimaryChannelMessageReplyHostedContent.md)
Update the navigation property hostedContents in groups

### [Update-MgGroupTeamPrimaryChannelSharedWithTeam](Update-MgGroupTeamPrimaryChannelSharedWithTeam.md)
Update the navigation property sharedWithTeams in groups

### [Update-MgGroupTeamPrimaryChannelTab](Update-MgGroupTeamPrimaryChannelTab.md)
Update the navigation property tabs in groups

### [Update-MgGroupTeamScheduleOfferShiftRequest](Update-MgGroupTeamScheduleOfferShiftRequest.md)
Update the navigation property offerShiftRequests in groups

### [Update-MgGroupTeamScheduleOpenShift](Update-MgGroupTeamScheduleOpenShift.md)
Update the navigation property openShifts in groups

### [Update-MgGroupTeamScheduleOpenShiftChangeRequest](Update-MgGroupTeamScheduleOpenShiftChangeRequest.md)
Update the navigation property openShiftChangeRequests in groups

### [Update-MgGroupTeamScheduleSchedulingGroup](Update-MgGroupTeamScheduleSchedulingGroup.md)
Update the navigation property schedulingGroups in groups

### [Update-MgGroupTeamScheduleShift](Update-MgGroupTeamScheduleShift.md)
Update the navigation property shifts in groups

### [Update-MgGroupTeamScheduleSwapShiftChangeRequest](Update-MgGroupTeamScheduleSwapShiftChangeRequest.md)
Update the navigation property swapShiftsChangeRequests in groups

### [Update-MgGroupTeamScheduleTimeOff](Update-MgGroupTeamScheduleTimeOff.md)
Update the navigation property timesOff in groups

### [Update-MgGroupTeamScheduleTimeOffReason](Update-MgGroupTeamScheduleTimeOffReason.md)
Update the navigation property timeOffReasons in groups

### [Update-MgGroupTeamScheduleTimeOffRequest](Update-MgGroupTeamScheduleTimeOffRequest.md)
Update the navigation property timeOffRequests in groups

### [Update-MgGroupTeamTag](Update-MgGroupTeamTag.md)
Update the navigation property tags in groups

### [Update-MgGroupTeamTagMember](Update-MgGroupTeamTagMember.md)
Update the navigation property members in groups

### [Update-MgTeam](Update-MgTeam.md)
Update the properties of the specified team.

### [Update-MgTeamChannel](Update-MgTeamChannel.md)
Update the navigation property channels in teams

### [Update-MgTeamChannelMember](Update-MgTeamChannelMember.md)
Update the navigation property members in teams

### [Update-MgTeamChannelMessage](Update-MgTeamChannelMessage.md)
Update the navigation property messages in teams

### [Update-MgTeamChannelMessageReply](Update-MgTeamChannelMessageReply.md)
Update the navigation property replies in teams

### [Update-MgTeamChannelMessageReplyHostedContent](Update-MgTeamChannelMessageReplyHostedContent.md)
Update the navigation property hostedContents in teams

### [Update-MgTeamChannelSharedWithTeam](Update-MgTeamChannelSharedWithTeam.md)
Update the navigation property sharedWithTeams in teams

### [Update-MgTeamChannelTab](Update-MgTeamChannelTab.md)
Update the navigation property tabs in teams

### [Update-MgTeamInstalledApp](Update-MgTeamInstalledApp.md)
Upgrade an app installation within a chat.

### [Update-MgTeamMember](Update-MgTeamMember.md)
Update the navigation property members in teams

### [Update-MgTeamOperation](Update-MgTeamOperation.md)
Update the navigation property operations in teams

### [Update-MgTeamPhoto](Update-MgTeamPhoto.md)
Update the navigation property photo in teams

### [Update-MgTeamPrimaryChannel](Update-MgTeamPrimaryChannel.md)
Update the navigation property primaryChannel in teams

### [Update-MgTeamPrimaryChannelMember](Update-MgTeamPrimaryChannelMember.md)
Update the navigation property members in teams

### [Update-MgTeamPrimaryChannelMessage](Update-MgTeamPrimaryChannelMessage.md)
Update the navigation property messages in teams

### [Update-MgTeamPrimaryChannelMessageReply](Update-MgTeamPrimaryChannelMessageReply.md)
Update the navigation property replies in teams

### [Update-MgTeamPrimaryChannelMessageReplyHostedContent](Update-MgTeamPrimaryChannelMessageReplyHostedContent.md)
Update the navigation property hostedContents in teams

### [Update-MgTeamPrimaryChannelSharedWithTeam](Update-MgTeamPrimaryChannelSharedWithTeam.md)
Update the navigation property sharedWithTeams in teams

### [Update-MgTeamPrimaryChannelTab](Update-MgTeamPrimaryChannelTab.md)
Update the navigation property tabs in teams

### [Update-MgTeamScheduleOfferShiftRequest](Update-MgTeamScheduleOfferShiftRequest.md)
Update the navigation property offerShiftRequests in teams

### [Update-MgTeamScheduleOpenShift](Update-MgTeamScheduleOpenShift.md)
Update the navigation property openShifts in teams

### [Update-MgTeamScheduleOpenShiftChangeRequest](Update-MgTeamScheduleOpenShiftChangeRequest.md)
Update the navigation property openShiftChangeRequests in teams

### [Update-MgTeamScheduleSchedulingGroup](Update-MgTeamScheduleSchedulingGroup.md)
Update the navigation property schedulingGroups in teams

### [Update-MgTeamScheduleShift](Update-MgTeamScheduleShift.md)
Update the navigation property shifts in teams

### [Update-MgTeamScheduleSwapShiftChangeRequest](Update-MgTeamScheduleSwapShiftChangeRequest.md)
Update the navigation property swapShiftsChangeRequests in teams

### [Update-MgTeamScheduleTimeOff](Update-MgTeamScheduleTimeOff.md)
Update the navigation property timesOff in teams

### [Update-MgTeamScheduleTimeOffReason](Update-MgTeamScheduleTimeOffReason.md)
Update the navigation property timeOffReasons in teams

### [Update-MgTeamScheduleTimeOffRequest](Update-MgTeamScheduleTimeOffRequest.md)
Update the navigation property timeOffRequests in teams

### [Update-MgTeamTag](Update-MgTeamTag.md)
Update the navigation property tags in teams

### [Update-MgTeamTagMember](Update-MgTeamTagMember.md)
Update the navigation property members in teams

### [Update-MgTeamwork](Update-MgTeamwork.md)
Update teamwork

### [Update-MgTeamworkWorkforceIntegration](Update-MgTeamworkWorkforceIntegration.md)
Update the navigation property workforceIntegrations in teamwork

### [Update-MgUserChat](Update-MgUserChat.md)
Update the navigation property chats in users

### [Update-MgUserChatLastMessagePreview](Update-MgUserChatLastMessagePreview.md)
Update the navigation property lastMessagePreview in users

### [Update-MgUserChatMember](Update-MgUserChatMember.md)
Update the navigation property members in users

### [Update-MgUserChatMessage](Update-MgUserChatMessage.md)
Update the navigation property messages in users

### [Update-MgUserChatMessageHostedContent](Update-MgUserChatMessageHostedContent.md)
Update the navigation property hostedContents in users

### [Update-MgUserChatMessageReply](Update-MgUserChatMessageReply.md)
Update the navigation property replies in users

### [Update-MgUserChatMessageReplyHostedContent](Update-MgUserChatMessageReplyHostedContent.md)
Update the navigation property hostedContents in users

### [Update-MgUserChatPinnedMessage](Update-MgUserChatPinnedMessage.md)
Update the navigation property pinnedMessages in users

### [Update-MgUserChatTab](Update-MgUserChatTab.md)
Update the navigation property tabs in users

### [Update-MgUserTeamwork](Update-MgUserTeamwork.md)
Update the navigation property teamwork in users

### [Update-MgUserTeamworkAssociatedTeam](Update-MgUserTeamworkAssociatedTeam.md)
Update the navigation property associatedTeams in users

