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

### [Add-MgTeamworkDeletedTeamChannelMember](Add-MgTeamworkDeletedTeamChannelMember.md)
Add multiple members in a single request to a team.
The response provides details about which memberships could and couldn't be created.

### [Clear-MgChatMessageReaction](Clear-MgChatMessageReaction.md)
Invoke action unsetReaction

### [Clear-MgChatMessageReplyReaction](Clear-MgChatMessageReplyReaction.md)
Invoke action unsetReaction

### [Clear-MgTeamChannelMessageReaction](Clear-MgTeamChannelMessageReaction.md)
Invoke action unsetReaction

### [Clear-MgTeamChannelMessageReplyReaction](Clear-MgTeamChannelMessageReplyReaction.md)
Invoke action unsetReaction

### [Clear-MgTeamPrimaryChannelMessageReaction](Clear-MgTeamPrimaryChannelMessageReaction.md)
Invoke action unsetReaction

### [Clear-MgTeamPrimaryChannelMessageReplyReaction](Clear-MgTeamPrimaryChannelMessageReplyReaction.md)
Invoke action unsetReaction

### [Clear-MgTeamworkDeletedTeamChannelMessageReaction](Clear-MgTeamworkDeletedTeamChannelMessageReaction.md)
Invoke action unsetReaction

### [Clear-MgTeamworkDeletedTeamChannelMessageReplyReaction](Clear-MgTeamworkDeletedTeamChannelMessageReplyReaction.md)
Invoke action unsetReaction

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

### [Complete-MgTeamworkDeletedTeamChannelMigration](Complete-MgTeamworkDeletedTeamChannelMigration.md)
Complete the message migration process by removing `migration mode` from a channel in a team.
`Migration mode` is a special state that prevents certain operations, like sending messages and adding members, during the data migration process.
After a **completeMigration** request is made, you cannot import additional messages into the team.
You can add members to the team after the request returns a successful response.

### [Confirm-MgChatPermissionGrantMemberGroup](Confirm-MgChatPermissionGrantMemberGroup.md)
Check for membership in a specified list of group IDs, and return from that list those groups (identified by IDs) of which the specified user, group, service principal, organizational contact, device, or directory object is a member.
This function is transitive.
You can check up to a maximum of 20 groups per request.
This function supports all groups provisioned in Azure AD.
Because Microsoft 365 groups cannot contain other groups, membership in a Microsoft 365 group is always direct.

### [Confirm-MgChatPermissionGrantMemberObject](Confirm-MgChatPermissionGrantMemberObject.md)
Invoke action checkMemberObjects

### [Confirm-MgTeamPermissionGrantMemberGroup](Confirm-MgTeamPermissionGrantMemberGroup.md)
Check for membership in a specified list of group IDs, and return from that list those groups (identified by IDs) of which the specified user, group, service principal, organizational contact, device, or directory object is a member.
This function is transitive.
You can check up to a maximum of 20 groups per request.
This function supports all groups provisioned in Azure AD.
Because Microsoft 365 groups cannot contain other groups, membership in a Microsoft 365 group is always direct.

### [Confirm-MgTeamPermissionGrantMemberObject](Confirm-MgTeamPermissionGrantMemberObject.md)
Invoke action checkMemberObjects

### [Confirm-MgTeamScheduleTimeCard](Confirm-MgTeamScheduleTimeCard.md)
Confirm a specific timeCard.

### [Copy-MgTeam](Copy-MgTeam.md)
Create a copy of a team.
This operation also creates a copy of the corresponding group.\nYou can specify which parts of the team to clone: When tabs are cloned, they are put into an unconfigured state \n-- they are displayed on the tab bar in Microsoft Teams, and the first time you open them, you'll go through the configuration screen.
\n(If the person opening the tab does not have permission to configure apps, they will see a message explaining that the tab hasn't been configured.) Cloning is a long-running operation.\nAfter the POST clone returns, you need to GET the operation \nreturned by the Location: header to see if it's 'running' or 'succeeded' or 'failed'.
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

### [Get-MgAppCatalogTeamAppDefinitionColorIcon](Get-MgAppCatalogTeamAppDefinitionColorIcon.md)
Retrieve a Teams app icon associated with a specific definition of an app.

### [Get-MgAppCatalogTeamAppDefinitionColorIconHostedContent](Get-MgAppCatalogTeamAppDefinitionColorIconHostedContent.md)
Retrieve the hosted content in an app's icon.

### [Get-MgAppCatalogTeamAppDefinitionOutlineIcon](Get-MgAppCatalogTeamAppDefinitionOutlineIcon.md)
Retrieve a Teams app icon associated with a specific definition of an app.

### [Get-MgAppCatalogTeamAppDefinitionOutlineIconHostedContent](Get-MgAppCatalogTeamAppDefinitionOutlineIconHostedContent.md)
Retrieve the hosted content in an app's icon.

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
Invoke function getAllMessages

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

### [Get-MgChatOperation](Get-MgChatOperation.md)
A collection of all the Teams async operations that ran or are running on the chat.
Nullable.

### [Get-MgChatPermissionGrant](Get-MgChatPermissionGrant.md)
A collection of permissions granted to apps for the chat.

### [Get-MgChatPermissionGrantById](Get-MgChatPermissionGrantById.md)
Return the directory objects specified in a list of IDs.
Some common uses for this function are to:

### [Get-MgChatPermissionGrantMemberGroup](Get-MgChatPermissionGrantMemberGroup.md)
Return all the group IDs for the groups that the specified user, group, service principal, organizational contact, device, or directory object is a member of.
This function is transitive.

### [Get-MgChatPermissionGrantMemberObject](Get-MgChatPermissionGrantMemberObject.md)
Invoke action getMemberObjects

### [Get-MgChatPermissionGrantUserOwnedObject](Get-MgChatPermissionGrantUserOwnedObject.md)
Invoke action getUserOwnedObjects

### [Get-MgChatPinnedMessage](Get-MgChatPinnedMessage.md)
A collection of all the pinned messages in the chat.
Nullable.

### [Get-MgChatTab](Get-MgChatTab.md)
A collection of all the tabs in the chat.
Nullable.

### [Get-MgChatTabTeamApp](Get-MgChatTabTeamApp.md)
The application that is linked to the tab.

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

### [Get-MgGroupTeamOwner](Get-MgGroupTeamOwner.md)
The list of this team's owners.
Currently, when creating a team using application permissions, exactly one owner must be specified.
When using user delegated permissions, no owner can be specified (the current user is the owner).
Owner must be specified as an object ID (GUID), not a UPN.

### [Get-MgGroupTeamPermissionGrant](Get-MgGroupTeamPermissionGrant.md)
A collection of permissions granted to apps to access the team.

### [Get-MgGroupTeamPhoto](Get-MgGroupTeamPhoto.md)
The team photo.

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

### [Get-MgGroupTeamScheduleTimeCard](Get-MgGroupTeamScheduleTimeCard.md)
Get timeCards from groups

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

### [Get-MgGroupTeamTemplateDefinition](Get-MgGroupTeamTemplateDefinition.md)
Get templateDefinition from groups

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

### [Get-MgTeamOwner](Get-MgTeamOwner.md)
The list of this team's owners.
Currently, when creating a team using application permissions, exactly one owner must be specified.
When using user delegated permissions, no owner can be specified (the current user is the owner).
Owner must be specified as an object ID (GUID), not a UPN.

### [Get-MgTeamPermissionGrant](Get-MgTeamPermissionGrant.md)
A collection of permissions granted to apps to access the team.

### [Get-MgTeamPermissionGrantById](Get-MgTeamPermissionGrantById.md)
Return the directory objects specified in a list of IDs.
Some common uses for this function are to:

### [Get-MgTeamPermissionGrantMemberGroup](Get-MgTeamPermissionGrantMemberGroup.md)
Return all the group IDs for the groups that the specified user, group, service principal, organizational contact, device, or directory object is a member of.
This function is transitive.

### [Get-MgTeamPermissionGrantMemberObject](Get-MgTeamPermissionGrantMemberObject.md)
Invoke action getMemberObjects

### [Get-MgTeamPermissionGrantUserOwnedObject](Get-MgTeamPermissionGrantUserOwnedObject.md)
Invoke action getUserOwnedObjects

### [Get-MgTeamPhoto](Get-MgTeamPhoto.md)
The team photo.

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

### [Get-MgTeamScheduleTimeCard](Get-MgTeamScheduleTimeCard.md)
Get timeCards from teams

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

### [Get-MgTeamTemplateDefinition](Get-MgTeamTemplateDefinition.md)
Get templateDefinition from teams

### [Get-MgTeamwork](Get-MgTeamwork.md)
Get teamwork

### [Get-MgTeamworkDeletedTeam](Get-MgTeamworkDeletedTeam.md)
A collection of deleted teams.

### [Get-MgTeamworkDeletedTeamChannel](Get-MgTeamworkDeletedTeamChannel.md)
The channels those are either shared with this deleted team or created in this deleted team.

### [Get-MgTeamworkDeletedTeamChannelFileFolder](Get-MgTeamworkDeletedTeamChannelFileFolder.md)
Get the metadata for the location where the files of a channel are stored.

### [Get-MgTeamworkDeletedTeamChannelFileFolderContent](Get-MgTeamworkDeletedTeamChannelFileFolderContent.md)
The content stream, if the item represents a file.

### [Get-MgTeamworkDeletedTeamChannelMember](Get-MgTeamworkDeletedTeamChannelMember.md)
A collection of membership records associated with the channel.

### [Get-MgTeamworkDeletedTeamChannelMessage](Get-MgTeamworkDeletedTeamChannelMessage.md)
A collection of all the messages in the channel.
A navigation property.
Nullable.

### [Get-MgTeamworkDeletedTeamChannelMessageDelta](Get-MgTeamworkDeletedTeamChannelMessageDelta.md)
Invoke function delta

### [Get-MgTeamworkDeletedTeamChannelMessageHostedContent](Get-MgTeamworkDeletedTeamChannelMessageHostedContent.md)
Content in a message hosted by Microsoft Teams - for example, images or code snippets.

### [Get-MgTeamworkDeletedTeamChannelMessageReply](Get-MgTeamworkDeletedTeamChannelMessageReply.md)
Replies for a specified message.
Supports $expand for channel messages.

### [Get-MgTeamworkDeletedTeamChannelMessageReplyDelta](Get-MgTeamworkDeletedTeamChannelMessageReplyDelta.md)
Invoke function delta

### [Get-MgTeamworkDeletedTeamChannelMessageReplyHostedContent](Get-MgTeamworkDeletedTeamChannelMessageReplyHostedContent.md)
Content in a message hosted by Microsoft Teams - for example, images or code snippets.

### [Get-MgTeamworkDeletedTeamChannelSharedWithTeam](Get-MgTeamworkDeletedTeamChannelSharedWithTeam.md)
A collection of teams with which a channel is shared.

### [Get-MgTeamworkDeletedTeamChannelSharedWithTeamAllowedMember](Get-MgTeamworkDeletedTeamChannelSharedWithTeamAllowedMember.md)
A collection of team members who have access to the shared channel.

### [Get-MgTeamworkDeletedTeamChannelTab](Get-MgTeamworkDeletedTeamChannelTab.md)
A collection of all the tabs in the channel.
A navigation property.

### [Get-MgTeamworkDeletedTeamChannelTabTeamApp](Get-MgTeamworkDeletedTeamChannelTabTeamApp.md)
The application that is linked to the tab.

### [Get-MgTeamworkDeletedTeamMessage](Get-MgTeamworkDeletedTeamMessage.md)
Invoke function getAllMessages

### [Get-MgTeamworkDevice](Get-MgTeamworkDevice.md)
The Teams devices provisioned for the tenant.

### [Get-MgTeamworkDeviceActivity](Get-MgTeamworkDeviceActivity.md)
Get the activity status of a Microsoft Teams-enabled device.

### [Get-MgTeamworkDeviceConfiguration](Get-MgTeamworkDeviceConfiguration.md)
Get the configuration details of a Microsoft Teams-enabled device, including software versions, peripheral device configuration (for example, camera, display, microphone, and speaker), hardware configuration, and Microsoft Teams client configuration.

### [Get-MgTeamworkDeviceHealth](Get-MgTeamworkDeviceHealth.md)
Get the health details of a Microsoft Teams-enabled device.
Device health is calculated based on the device configuration and other device parameters.

### [Get-MgTeamworkDeviceOperation](Get-MgTeamworkDeviceOperation.md)
The async operations on the device.

### [Get-MgTeamworkTeamAppSetting](Get-MgTeamworkTeamAppSetting.md)
Read the properties and relationships of a teamsAppSettings object.

### [Get-MgTeamworkTeamTemplate](Get-MgTeamworkTeamTemplate.md)
The templates associated with a team.

### [Get-MgTeamworkTeamTemplateDefinition](Get-MgTeamworkTeamTemplateDefinition.md)
Get definitions from teamwork

### [Get-MgTeamworkTeamTemplateDefinitionTeamDefinition](Get-MgTeamworkTeamTemplateDefinitionTeamDefinition.md)
Get the properties of the team associated with a teamTemplateDefinition object.

### [Get-MgTeamworkWorkforceIntegration](Get-MgTeamworkWorkforceIntegration.md)
A workforce integration with shifts.

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

### [Get-MgUserChatOperation](Get-MgUserChatOperation.md)
A collection of all the Teams async operations that ran or are running on the chat.
Nullable.

### [Get-MgUserChatPermissionGrant](Get-MgUserChatPermissionGrant.md)
A collection of permissions granted to apps for the chat.

### [Get-MgUserChatPinnedMessage](Get-MgUserChatPinnedMessage.md)
A collection of all the pinned messages in the chat.
Nullable.

### [Get-MgUserChatTab](Get-MgUserChatTab.md)
A collection of all the tabs in the chat.
Nullable.

### [Get-MgUserChatTabTeamApp](Get-MgUserChatTabTeamApp.md)
The application that is linked to the tab.

### [Get-MgUserJoinedTeam](Get-MgUserJoinedTeam.md)
Get the teams in Microsoft Teams that the user is a direct member of.

### [Get-MgUserTeamwork](Get-MgUserTeamwork.md)
A container for Microsoft Teams features available for the user.
Read-only.
Nullable.

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

### [Invoke-MgClockTeamScheduleTimeCardIn](Invoke-MgClockTeamScheduleTimeCardIn.md)
Clock in to start a timeCard.

### [Invoke-MgClockTeamScheduleTimeCardOut](Invoke-MgClockTeamScheduleTimeCardOut.md)
Clock out to end an open timeCard.

### [Invoke-MgGraphChat](Invoke-MgGraphChat.md)
Unhide a chat for a user.

### [Invoke-MgHaveTeamChannel](Invoke-MgHaveTeamChannel.md)
Invoke function doesUserHaveAccess

### [Invoke-MgHaveTeamPrimaryChannel](Invoke-MgHaveTeamPrimaryChannel.md)
Invoke function doesUserHaveAccess

### [Invoke-MgHaveTeamworkDeletedTeamChannel](Invoke-MgHaveTeamworkDeletedTeamChannel.md)
Invoke function doesUserHaveAccess

### [Invoke-MgMarkChatReadForUser](Invoke-MgMarkChatReadForUser.md)
Mark a chat as read for a user.

### [Invoke-MgMarkChatUnreadForUser](Invoke-MgMarkChatUnreadForUser.md)
Mark a chat as unread for a user.

### [Invoke-MgMessageChat](Invoke-MgMessageChat.md)
Invoke function allMessages

### [Invoke-MgMessageTeam](Invoke-MgMessageTeam.md)
Invoke function allMessages

### [Invoke-MgMessageTeamChannel](Invoke-MgMessageTeamChannel.md)
Invoke function allMessages

### [Invoke-MgMessageTeamworkDeletedTeamChannel](Invoke-MgMessageTeamworkDeletedTeamChannel.md)
Invoke function allMessages

### [Invoke-MgShareTeamSchedule](Invoke-MgShareTeamSchedule.md)
Share a schedule time range with schedule members.\nMake the collections of shift, openshift and timeOff items in the specified time range of the schedule viewable by the specified team members, including employees and managers.\nEach shift, openshift and timeOff instance in a schedule supports a draft version and a shared version of the item.
The draft version is viewable by only managers, and the shared version is viewable by employees and managers.
For each shift, openshift and timeOff instance in the specified time range, the share action updates the shared version from the draft version, so that in addition to managers, employees can also view the most current information about the item.
The **notifyTeam** parameter further specifies which employees can view the item.

### [Invoke-MgSoftChatMessageDelete](Invoke-MgSoftChatMessageDelete.md)
Delete a single message or a message reply in a channel or a chat.

### [Invoke-MgSoftChatMessageReplyDelete](Invoke-MgSoftChatMessageReplyDelete.md)
Delete a single message or a message reply in a channel or a chat.

### [Invoke-MgSoftTeamChannelMessageDelete](Invoke-MgSoftTeamChannelMessageDelete.md)
Delete a single message or a message reply in a channel or a chat.

### [Invoke-MgSoftTeamChannelMessageReplyDelete](Invoke-MgSoftTeamChannelMessageReplyDelete.md)
Delete a single message or a message reply in a channel or a chat.

### [Invoke-MgSoftTeamPrimaryChannelMessageDelete](Invoke-MgSoftTeamPrimaryChannelMessageDelete.md)
Delete a single message or a message reply in a channel or a chat.

### [Invoke-MgSoftTeamPrimaryChannelMessageReplyDelete](Invoke-MgSoftTeamPrimaryChannelMessageReplyDelete.md)
Delete a single message or a message reply in a channel or a chat.

### [Invoke-MgSoftTeamworkDeletedTeamChannelMessageDelete](Invoke-MgSoftTeamworkDeletedTeamChannelMessageDelete.md)
Delete a single message or a message reply in a channel or a chat.

### [Invoke-MgSoftTeamworkDeletedTeamChannelMessageReplyDelete](Invoke-MgSoftTeamworkDeletedTeamChannelMessageReplyDelete.md)
Delete a single message or a message reply in a channel or a chat.

### [Invoke-MgUnarchiveTeam](Invoke-MgUnarchiveTeam.md)
Restore an archived team.
This restores users' ability to send messages and edit the team, abiding by tenant and team settings.
Teams are archived using the archive API.
Unarchiving is an async operation.
A team is unarchived once the async operation completes successfully, which may occur subsequent to a response from this API.

### [New-MgAppCatalogTeamApp](New-MgAppCatalogTeamApp.md)
Publish an app to the Microsoft Teams app catalog.\nSpecifically, this API publishes the app to your organization's catalog (the tenant app catalog);\nthe created resource will have a **distributionMethod** property value of `organization`.
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
This API cannot create a new chat; you must use the list chats method to retrieve the ID of an existing chat before creating a chat message.

### [New-MgChatMessageHostedContent](New-MgChatMessageHostedContent.md)
Create new navigation property to hostedContents for chats

### [New-MgChatMessageReply](New-MgChatMessageReply.md)
Send a new reply to a chatMessage in a specified channel.

### [New-MgChatMessageReplyHostedContent](New-MgChatMessageReplyHostedContent.md)
Create new navigation property to hostedContents for chats

### [New-MgChatOperation](New-MgChatOperation.md)
Create new navigation property to operations for chats

### [New-MgChatPermissionGrant](New-MgChatPermissionGrant.md)
Create new navigation property to permissionGrants for chats

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
Send a new reply to a chatMessage in a specified channel.

### [New-MgGroupTeamChannelMessageReplyHostedContent](New-MgGroupTeamChannelMessageReplyHostedContent.md)
Create new navigation property to hostedContents for groups

### [New-MgGroupTeamChannelSharedWithTeam](New-MgGroupTeamChannelSharedWithTeam.md)
Create new navigation property to sharedWithTeams for groups

### [New-MgGroupTeamChannelTab](New-MgGroupTeamChannelTab.md)
Create new navigation property to tabs for groups

### [New-MgGroupTeamInstalledApp](New-MgGroupTeamInstalledApp.md)
Install an app to the specified team.

### [New-MgGroupTeamMember](New-MgGroupTeamMember.md)
Add a new conversation member to a team.

### [New-MgGroupTeamOperation](New-MgGroupTeamOperation.md)
Create new navigation property to operations for groups

### [New-MgGroupTeamPermissionGrant](New-MgGroupTeamPermissionGrant.md)
Create new navigation property to permissionGrants for groups

### [New-MgGroupTeamPrimaryChannelMember](New-MgGroupTeamPrimaryChannelMember.md)
Add a conversationMember to a channel.
This operation is allowed only for channels with a **membershipType** value of `private` or `shared`.

### [New-MgGroupTeamPrimaryChannelMessage](New-MgGroupTeamPrimaryChannelMessage.md)
Send a new chatMessage in the specified channel or a chat.

### [New-MgGroupTeamPrimaryChannelMessageHostedContent](New-MgGroupTeamPrimaryChannelMessageHostedContent.md)
Create new navigation property to hostedContents for groups

### [New-MgGroupTeamPrimaryChannelMessageReply](New-MgGroupTeamPrimaryChannelMessageReply.md)
Send a new reply to a chatMessage in a specified channel.

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

### [New-MgGroupTeamScheduleTimeCard](New-MgGroupTeamScheduleTimeCard.md)
Create new navigation property to timeCards for groups

### [New-MgGroupTeamScheduleTimeOff](New-MgGroupTeamScheduleTimeOff.md)
Create a new timeOff instance in a schedule.

### [New-MgGroupTeamScheduleTimeOffReason](New-MgGroupTeamScheduleTimeOffReason.md)
Create a new timeOffReason.

### [New-MgGroupTeamScheduleTimeOffRequest](New-MgGroupTeamScheduleTimeOffRequest.md)
Create new navigation property to timeOffRequests for groups

### [New-MgGroupTeamTag](New-MgGroupTeamTag.md)
Create a standard tag for members in the team.

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
Send a new reply to a chatMessage in a specified channel.

### [New-MgTeamChannelMessageReplyHostedContent](New-MgTeamChannelMessageReplyHostedContent.md)
Create new navigation property to hostedContents for teams

### [New-MgTeamChannelSharedWithTeam](New-MgTeamChannelSharedWithTeam.md)
Create new navigation property to sharedWithTeams for teams

### [New-MgTeamChannelTab](New-MgTeamChannelTab.md)
Create new navigation property to tabs for teams

### [New-MgTeamInstalledApp](New-MgTeamInstalledApp.md)
Install an app to the specified team.

### [New-MgTeamMember](New-MgTeamMember.md)
Add a new conversation member to a team.

### [New-MgTeamOperation](New-MgTeamOperation.md)
Create new navigation property to operations for teams

### [New-MgTeamPermissionGrant](New-MgTeamPermissionGrant.md)
Create new navigation property to permissionGrants for teams

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
Send a new reply to a chatMessage in a specified channel.

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

### [New-MgTeamScheduleTimeCard](New-MgTeamScheduleTimeCard.md)
Create new navigation property to timeCards for teams

### [New-MgTeamScheduleTimeOff](New-MgTeamScheduleTimeOff.md)
Create a new timeOff instance in a schedule.

### [New-MgTeamScheduleTimeOffReason](New-MgTeamScheduleTimeOffReason.md)
Create a new timeOffReason.

### [New-MgTeamScheduleTimeOffRequest](New-MgTeamScheduleTimeOffRequest.md)
Create new navigation property to timeOffRequests for teams

### [New-MgTeamTag](New-MgTeamTag.md)
Create a standard tag for members in the team.

### [New-MgTeamTagMember](New-MgTeamTagMember.md)
Create a new teamworkTagMember object in a team.

### [New-MgTeamworkDeletedTeam](New-MgTeamworkDeletedTeam.md)
Create new navigation property to deletedTeams for teamwork

### [New-MgTeamworkDeletedTeamChannel](New-MgTeamworkDeletedTeamChannel.md)
Create new navigation property to channels for teamwork

### [New-MgTeamworkDeletedTeamChannelEmail](New-MgTeamworkDeletedTeamChannelEmail.md)
Provision an email address for a channel.
Microsoft Teams doesn't automatically provision an email address for a **channel** by default.
To have Teams provision an email address, you can call **provisionEmail**, or through the Teams user interface, select **Get email address**, which triggers Teams to generate an email address if it has not already provisioned one.
To remove the email address of a **channel**, use the removeEmail method.

### [New-MgTeamworkDeletedTeamChannelMember](New-MgTeamworkDeletedTeamChannelMember.md)
Add a conversationMember to a channel.
This operation is allowed only for channels with a **membershipType** value of `private` or `shared`.

### [New-MgTeamworkDeletedTeamChannelMessage](New-MgTeamworkDeletedTeamChannelMessage.md)
Send a new chatMessage in the specified channel or a chat.

### [New-MgTeamworkDeletedTeamChannelMessageHostedContent](New-MgTeamworkDeletedTeamChannelMessageHostedContent.md)
Create new navigation property to hostedContents for teamwork

### [New-MgTeamworkDeletedTeamChannelMessageReply](New-MgTeamworkDeletedTeamChannelMessageReply.md)
Send a new reply to a chatMessage in a specified channel.

### [New-MgTeamworkDeletedTeamChannelMessageReplyHostedContent](New-MgTeamworkDeletedTeamChannelMessageReplyHostedContent.md)
Create new navigation property to hostedContents for teamwork

### [New-MgTeamworkDeletedTeamChannelSharedWithTeam](New-MgTeamworkDeletedTeamChannelSharedWithTeam.md)
Create new navigation property to sharedWithTeams for teamwork

### [New-MgTeamworkDeletedTeamChannelTab](New-MgTeamworkDeletedTeamChannelTab.md)
Create new navigation property to tabs for teamwork

### [New-MgTeamworkDevice](New-MgTeamworkDevice.md)
Create new navigation property to devices for teamwork

### [New-MgTeamworkDeviceOperation](New-MgTeamworkDeviceOperation.md)
Create new navigation property to operations for teamwork

### [New-MgTeamworkTeamTemplate](New-MgTeamworkTeamTemplate.md)
Create new navigation property to teamTemplates for teamwork

### [New-MgTeamworkTeamTemplateDefinition](New-MgTeamworkTeamTemplateDefinition.md)
Create new navigation property to definitions for teamwork

### [New-MgTeamworkWorkforceIntegration](New-MgTeamworkWorkforceIntegration.md)
Create a new workforceIntegration object.

### [New-MgUserChat](New-MgUserChat.md)
Create new navigation property to chats for users

### [New-MgUserChatInstalledApp](New-MgUserChatInstalledApp.md)
Install a teamsApp to the specified chat.

### [New-MgUserChatMember](New-MgUserChatMember.md)
Add a conversationMember to a chat.

### [New-MgUserChatMessage](New-MgUserChatMessage.md)
Send a new chatMessage in the specified chat.
This API cannot create a new chat; you must use the list chats method to retrieve the ID of an existing chat before creating a chat message.

### [New-MgUserChatMessageHostedContent](New-MgUserChatMessageHostedContent.md)
Create new navigation property to hostedContents for users

### [New-MgUserChatMessageReply](New-MgUserChatMessageReply.md)
Send a new reply to a chatMessage in a specified channel.

### [New-MgUserChatMessageReplyHostedContent](New-MgUserChatMessageReplyHostedContent.md)
Create new navigation property to hostedContents for users

### [New-MgUserChatOperation](New-MgUserChatOperation.md)
Create new navigation property to operations for users

### [New-MgUserChatPermissionGrant](New-MgUserChatPermissionGrant.md)
Create new navigation property to permissionGrants for users

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

### [Remove-MgAppCatalogTeamAppDefinitionColorIcon](Remove-MgAppCatalogTeamAppDefinitionColorIcon.md)
Delete navigation property colorIcon for appCatalogs

### [Remove-MgAppCatalogTeamAppDefinitionColorIconHostedContent](Remove-MgAppCatalogTeamAppDefinitionColorIconHostedContent.md)
Delete navigation property hostedContent for appCatalogs

### [Remove-MgAppCatalogTeamAppDefinitionOutlineIcon](Remove-MgAppCatalogTeamAppDefinitionOutlineIcon.md)
Delete navigation property outlineIcon for appCatalogs

### [Remove-MgAppCatalogTeamAppDefinitionOutlineIconHostedContent](Remove-MgAppCatalogTeamAppDefinitionOutlineIconHostedContent.md)
Delete navigation property hostedContent for appCatalogs

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

### [Remove-MgChatOperation](Remove-MgChatOperation.md)
Delete navigation property operations for chats

### [Remove-MgChatPermissionGrant](Remove-MgChatPermissionGrant.md)
Delete navigation property permissionGrants for chats

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

### [Remove-MgGroupTeamPermissionGrant](Remove-MgGroupTeamPermissionGrant.md)
Delete navigation property permissionGrants for groups

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

### [Remove-MgGroupTeamScheduleTimeCard](Remove-MgGroupTeamScheduleTimeCard.md)
Delete navigation property timeCards for groups

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

### [Remove-MgTeamPermissionGrant](Remove-MgTeamPermissionGrant.md)
Delete navigation property permissionGrants for teams

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

### [Remove-MgTeamScheduleTimeCard](Remove-MgTeamScheduleTimeCard.md)
Delete navigation property timeCards for teams

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

### [Remove-MgTeamworkDeletedTeam](Remove-MgTeamworkDeletedTeam.md)
Delete navigation property deletedTeams for teamwork

### [Remove-MgTeamworkDeletedTeamChannel](Remove-MgTeamworkDeletedTeamChannel.md)
Delete navigation property channels for teamwork

### [Remove-MgTeamworkDeletedTeamChannelEmail](Remove-MgTeamworkDeletedTeamChannelEmail.md)
Remove the email address of a channel.
You can remove an email address only if it was provisioned using the provisionEmail method or through the Microsoft Teams client.

### [Remove-MgTeamworkDeletedTeamChannelMember](Remove-MgTeamworkDeletedTeamChannelMember.md)
Delete navigation property members for teamwork

### [Remove-MgTeamworkDeletedTeamChannelMessage](Remove-MgTeamworkDeletedTeamChannelMessage.md)
Delete navigation property messages for teamwork

### [Remove-MgTeamworkDeletedTeamChannelMessageHostedContent](Remove-MgTeamworkDeletedTeamChannelMessageHostedContent.md)
Delete navigation property hostedContents for teamwork

### [Remove-MgTeamworkDeletedTeamChannelMessageReply](Remove-MgTeamworkDeletedTeamChannelMessageReply.md)
Delete navigation property replies for teamwork

### [Remove-MgTeamworkDeletedTeamChannelMessageReplyHostedContent](Remove-MgTeamworkDeletedTeamChannelMessageReplyHostedContent.md)
Delete navigation property hostedContents for teamwork

### [Remove-MgTeamworkDeletedTeamChannelSharedWithTeam](Remove-MgTeamworkDeletedTeamChannelSharedWithTeam.md)
Delete navigation property sharedWithTeams for teamwork

### [Remove-MgTeamworkDeletedTeamChannelTab](Remove-MgTeamworkDeletedTeamChannelTab.md)
Delete navigation property tabs for teamwork

### [Remove-MgTeamworkDevice](Remove-MgTeamworkDevice.md)
Delete navigation property devices for teamwork

### [Remove-MgTeamworkDeviceActivity](Remove-MgTeamworkDeviceActivity.md)
Delete navigation property activity for teamwork

### [Remove-MgTeamworkDeviceConfiguration](Remove-MgTeamworkDeviceConfiguration.md)
Delete navigation property configuration for teamwork

### [Remove-MgTeamworkDeviceHealth](Remove-MgTeamworkDeviceHealth.md)
Delete navigation property health for teamwork

### [Remove-MgTeamworkDeviceOperation](Remove-MgTeamworkDeviceOperation.md)
Delete navigation property operations for teamwork

### [Remove-MgTeamworkTeamAppSetting](Remove-MgTeamworkTeamAppSetting.md)
Delete navigation property teamsAppSettings for teamwork

### [Remove-MgTeamworkTeamTemplate](Remove-MgTeamworkTeamTemplate.md)
Delete navigation property teamTemplates for teamwork

### [Remove-MgTeamworkTeamTemplateDefinition](Remove-MgTeamworkTeamTemplateDefinition.md)
Delete navigation property definitions for teamwork

### [Remove-MgTeamworkTeamTemplateDefinitionTeamDefinition](Remove-MgTeamworkTeamTemplateDefinitionTeamDefinition.md)
Delete navigation property teamDefinition for teamwork

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

### [Remove-MgUserChatOperation](Remove-MgUserChatOperation.md)
Delete navigation property operations for users

### [Remove-MgUserChatPermissionGrant](Remove-MgUserChatPermissionGrant.md)
Delete navigation property permissionGrants for users

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

### [Restart-MgTeamworkDevice](Restart-MgTeamworkDevice.md)
Restart the specified Microsoft Teams-enabled device asynchronously.
A device is restarted after the async operation completes successfully, which might occur subsequent to a response from this API.

### [Send-MgChatActivityNotification](Send-MgChatActivityNotification.md)
Send an activity feed notification in scope of a chat.
For more details about sending notifications and the requirements for doing so, see sending Teams activity notifications.

### [Send-MgTeamActivityNotification](Send-MgTeamActivityNotification.md)
Send an activity feed notification in the scope of a team.
For more details about sending notifications and the requirements for doing so, see\nsending Teams activity notifications.

### [Send-MgTeamworkActivityNotificationToRecipient](Send-MgTeamworkActivityNotificationToRecipient.md)
Send activity feed notifications to multiple users, in bulk.
For more details about sending notifications and the requirements for doing so, see\nsending Teams activity notifications.

### [Set-MgAppCatalogTeamAppDefinitionColorIconHostedContent](Set-MgAppCatalogTeamAppDefinitionColorIconHostedContent.md)
Update media content for the navigation property hostedContent in appCatalogs

### [Set-MgAppCatalogTeamAppDefinitionOutlineIconHostedContent](Set-MgAppCatalogTeamAppDefinitionOutlineIconHostedContent.md)
Update media content for the navigation property hostedContent in appCatalogs

### [Set-MgChatMessageReaction](Set-MgChatMessageReaction.md)
Invoke action setReaction

### [Set-MgChatMessageReplyReaction](Set-MgChatMessageReplyReaction.md)
Invoke action setReaction

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

### [Set-MgTeamChannelMessageReaction](Set-MgTeamChannelMessageReaction.md)
Invoke action setReaction

### [Set-MgTeamChannelMessageReplyReaction](Set-MgTeamChannelMessageReplyReaction.md)
Invoke action setReaction

### [Set-MgTeamPhotoContent](Set-MgTeamPhotoContent.md)
Update media content for the navigation property photo in teams

### [Set-MgTeamPrimaryChannelFileFolderContent](Set-MgTeamPrimaryChannelFileFolderContent.md)
The content stream, if the item represents a file.

### [Set-MgTeamPrimaryChannelMessageReaction](Set-MgTeamPrimaryChannelMessageReaction.md)
Invoke action setReaction

### [Set-MgTeamPrimaryChannelMessageReplyReaction](Set-MgTeamPrimaryChannelMessageReplyReaction.md)
Invoke action setReaction

### [Set-MgTeamSchedule](Set-MgTeamSchedule.md)
Update the navigation property schedule in teams

### [Set-MgTeamworkDeletedTeamChannelFileFolderContent](Set-MgTeamworkDeletedTeamChannelFileFolderContent.md)
The content stream, if the item represents a file.

### [Set-MgTeamworkDeletedTeamChannelMessageReaction](Set-MgTeamworkDeletedTeamChannelMessageReaction.md)
Invoke action setReaction

### [Set-MgTeamworkDeletedTeamChannelMessageReplyReaction](Set-MgTeamworkDeletedTeamChannelMessageReplyReaction.md)
Invoke action setReaction

### [Start-MgTeamScheduleTimeCardBreak](Start-MgTeamScheduleTimeCardBreak.md)
Start a break in a specific timeCard.

### [Start-MgTeamworkDeviceDiagnostic](Start-MgTeamworkDeviceDiagnostic.md)
Run and generate diagnostic logs for the specified Microsoft Teams-enabled device.
This API triggers a long-running operation used to generate logs for a device.

### [Stop-MgTeamScheduleTimeCardBreak](Stop-MgTeamScheduleTimeCardBreak.md)
End the open break in a specific timeCard.

### [Test-MgChatPermissionGrantProperty](Test-MgChatPermissionGrantProperty.md)
Validate that a Microsoft 365 group's display name or mail nickname complies with naming policies.
Clients can use this API to determine whether a display name or mail nickname is valid before trying to **create** a Microsoft 365 group.
For validating properties of an existing group, use the validateProperties function for groups.
The following validations are performed for the display name and mail nickname properties: \n1.
Validate the prefix and suffix naming policy\n2.
Validate the custom banned words policy\n3.
Validate the mail nickname is unique This API returns with the first failure encountered.
If one or more properties fail multiple validations, only the property with the first validation failure is returned.
However, you can validate both the mail nickname and the display name and receive a collection of validation errors if you are only validating the prefix and suffix naming policy.

### [Test-MgTeamPermissionGrantProperty](Test-MgTeamPermissionGrantProperty.md)
Validate that a Microsoft 365 group's display name or mail nickname complies with naming policies.
Clients can use this API to determine whether a display name or mail nickname is valid before trying to **create** a Microsoft 365 group.
For validating properties of an existing group, use the validateProperties function for groups.
The following validations are performed for the display name and mail nickname properties: \n1.
Validate the prefix and suffix naming policy\n2.
Validate the custom banned words policy\n3.
Validate the mail nickname is unique This API returns with the first failure encountered.
If one or more properties fail multiple validations, only the property with the first validation failure is returned.
However, you can validate both the mail nickname and the display name and receive a collection of validation errors if you are only validating the prefix and suffix naming policy.

### [Undo-MgChatMessageReplySoftDelete](Undo-MgChatMessageReplySoftDelete.md)
Undo soft deletion of a single message or a message reply in a channel or a chat.

### [Undo-MgChatMessageSoftDelete](Undo-MgChatMessageSoftDelete.md)
Undo soft deletion of a single message or a message reply in a channel or a chat.

### [Undo-MgTeamChannelMessageReplySoftDelete](Undo-MgTeamChannelMessageReplySoftDelete.md)
Undo soft deletion of a single message or a message reply in a channel or a chat.

### [Undo-MgTeamChannelMessageSoftDelete](Undo-MgTeamChannelMessageSoftDelete.md)
Undo soft deletion of a single message or a message reply in a channel or a chat.

### [Undo-MgTeamPrimaryChannelMessageReplySoftDelete](Undo-MgTeamPrimaryChannelMessageReplySoftDelete.md)
Undo soft deletion of a single message or a message reply in a channel or a chat.

### [Undo-MgTeamPrimaryChannelMessageSoftDelete](Undo-MgTeamPrimaryChannelMessageSoftDelete.md)
Undo soft deletion of a single message or a message reply in a channel or a chat.

### [Undo-MgTeamworkDeletedTeamChannelMessageReplySoftDelete](Undo-MgTeamworkDeletedTeamChannelMessageReplySoftDelete.md)
Undo soft deletion of a single message or a message reply in a channel or a chat.

### [Undo-MgTeamworkDeletedTeamChannelMessageSoftDelete](Undo-MgTeamworkDeletedTeamChannelMessageSoftDelete.md)
Undo soft deletion of a single message or a message reply in a channel or a chat.

### [Update-MgAppCatalogTeamApp](Update-MgAppCatalogTeamApp.md)
Update the navigation property teamsApps in appCatalogs

### [Update-MgAppCatalogTeamAppDefinition](Update-MgAppCatalogTeamAppDefinition.md)
Update the navigation property appDefinitions in appCatalogs

### [Update-MgAppCatalogTeamAppDefinitionBot](Update-MgAppCatalogTeamAppDefinitionBot.md)
Update the navigation property bot in appCatalogs

### [Update-MgAppCatalogTeamAppDefinitionColorIcon](Update-MgAppCatalogTeamAppDefinitionColorIcon.md)
Update the navigation property colorIcon in appCatalogs

### [Update-MgAppCatalogTeamAppDefinitionColorIconHostedContent](Update-MgAppCatalogTeamAppDefinitionColorIconHostedContent.md)
Update the navigation property hostedContent in appCatalogs

### [Update-MgAppCatalogTeamAppDefinitionOutlineIcon](Update-MgAppCatalogTeamAppDefinitionOutlineIcon.md)
Update the navigation property outlineIcon in appCatalogs

### [Update-MgAppCatalogTeamAppDefinitionOutlineIconHostedContent](Update-MgAppCatalogTeamAppDefinitionOutlineIconHostedContent.md)
Update the navigation property hostedContent in appCatalogs

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

### [Update-MgChatOperation](Update-MgChatOperation.md)
Update the navigation property operations in chats

### [Update-MgChatPermissionGrant](Update-MgChatPermissionGrant.md)
Update the navigation property permissionGrants in chats

### [Update-MgChatPinnedMessage](Update-MgChatPinnedMessage.md)
Update the navigation property pinnedMessages in chats

### [Update-MgChatTab](Update-MgChatTab.md)
Update the navigation property tabs in chats

### [Update-MgGroupTeam](Update-MgGroupTeam.md)
Create a new team from a group.
In order to create a team, the group must have a least one owner.
If the group was created less than 15 minutes ago, it's possible for the Create team call to fail with a 404 error code due to replication delays.\nThe recommended pattern is to retry the Create team call three times, with a 10 second delay between calls.

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

### [Update-MgGroupTeamPermissionGrant](Update-MgGroupTeamPermissionGrant.md)
Update the navigation property permissionGrants in groups

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

### [Update-MgGroupTeamScheduleTimeCard](Update-MgGroupTeamScheduleTimeCard.md)
Update the navigation property timeCards in groups

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

### [Update-MgTeamPermissionGrant](Update-MgTeamPermissionGrant.md)
Update the navigation property permissionGrants in teams

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

### [Update-MgTeamScheduleTimeCard](Update-MgTeamScheduleTimeCard.md)
Update the navigation property timeCards in teams

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

### [Update-MgTeamworkDeletedTeam](Update-MgTeamworkDeletedTeam.md)
Update the navigation property deletedTeams in teamwork

### [Update-MgTeamworkDeletedTeamChannel](Update-MgTeamworkDeletedTeamChannel.md)
Update the navigation property channels in teamwork

### [Update-MgTeamworkDeletedTeamChannelMember](Update-MgTeamworkDeletedTeamChannelMember.md)
Update the navigation property members in teamwork

### [Update-MgTeamworkDeletedTeamChannelMessage](Update-MgTeamworkDeletedTeamChannelMessage.md)
Update the navigation property messages in teamwork

### [Update-MgTeamworkDeletedTeamChannelMessageHostedContent](Update-MgTeamworkDeletedTeamChannelMessageHostedContent.md)
Update the navigation property hostedContents in teamwork

### [Update-MgTeamworkDeletedTeamChannelMessageReply](Update-MgTeamworkDeletedTeamChannelMessageReply.md)
Update the navigation property replies in teamwork

### [Update-MgTeamworkDeletedTeamChannelMessageReplyHostedContent](Update-MgTeamworkDeletedTeamChannelMessageReplyHostedContent.md)
Update the navigation property hostedContents in teamwork

### [Update-MgTeamworkDeletedTeamChannelSharedWithTeam](Update-MgTeamworkDeletedTeamChannelSharedWithTeam.md)
Update the navigation property sharedWithTeams in teamwork

### [Update-MgTeamworkDeletedTeamChannelTab](Update-MgTeamworkDeletedTeamChannelTab.md)
Update the navigation property tabs in teamwork

### [Update-MgTeamworkDevice](Update-MgTeamworkDevice.md)
Update the navigation property devices in teamwork

### [Update-MgTeamworkDeviceActivity](Update-MgTeamworkDeviceActivity.md)
Update the navigation property activity in teamwork

### [Update-MgTeamworkDeviceConfiguration](Update-MgTeamworkDeviceConfiguration.md)
Update the navigation property configuration in teamwork

### [Update-MgTeamworkDeviceHealth](Update-MgTeamworkDeviceHealth.md)
Update the navigation property health in teamwork

### [Update-MgTeamworkDeviceOperation](Update-MgTeamworkDeviceOperation.md)
Update the navigation property operations in teamwork

### [Update-MgTeamworkDeviceSoftware](Update-MgTeamworkDeviceSoftware.md)
Update the software for a Microsoft Teams-enabled device.
This API triggers a long-running operation.

### [Update-MgTeamworkTeamAppSetting](Update-MgTeamworkTeamAppSetting.md)
Update the properties of a teamsAppSettings object.

### [Update-MgTeamworkTeamTemplate](Update-MgTeamworkTeamTemplate.md)
Update the navigation property teamTemplates in teamwork

### [Update-MgTeamworkTeamTemplateDefinition](Update-MgTeamworkTeamTemplateDefinition.md)
Update the navigation property definitions in teamwork

### [Update-MgTeamworkTeamTemplateDefinitionTeamDefinition](Update-MgTeamworkTeamTemplateDefinitionTeamDefinition.md)
Update the navigation property teamDefinition in teamwork

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

### [Update-MgUserChatOperation](Update-MgUserChatOperation.md)
Update the navigation property operations in users

### [Update-MgUserChatPermissionGrant](Update-MgUserChatPermissionGrant.md)
Update the navigation property permissionGrants in users

### [Update-MgUserChatPinnedMessage](Update-MgUserChatPinnedMessage.md)
Update the navigation property pinnedMessages in users

### [Update-MgUserChatTab](Update-MgUserChatTab.md)
Update the navigation property tabs in users

### [Update-MgUserTeamwork](Update-MgUserTeamwork.md)
Update the navigation property teamwork in users

### [Update-MgUserTeamworkAssociatedTeam](Update-MgUserTeamworkAssociatedTeam.md)
Update the navigation property associatedTeams in users

