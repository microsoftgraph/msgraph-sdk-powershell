---
Module Name: Microsoft.Graph.Beta.Teams
Module Guid: 0f38d13f-a855-471b-9540-b06682753b5c
Download Help Link: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.Beta.teams
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Beta.Teams Module
## Description
Microsoft.Graph.Beta PowerShell Cmdlets

## Microsoft.Graph.Beta.Teams Cmdlets
### [Add-MgBetaChatMember](Add-MgBetaChatMember.md)
Add multiple members in a single request to a team.
The response provides details about which memberships could and couldn't be created.

### [Add-MgBetaTeamChannelMember](Add-MgBetaTeamChannelMember.md)
Add multiple members in a single request to a team.
The response provides details about which memberships could and couldn't be created.

### [Add-MgBetaTeamMember](Add-MgBetaTeamMember.md)
Add multiple members in a single request to a team.
The response provides details about which memberships could and couldn't be created.

### [Add-MgBetaTeamPrimaryChannelMember](Add-MgBetaTeamPrimaryChannelMember.md)
Add multiple members in a single request to a team.
The response provides details about which memberships could and couldn't be created.

### [Add-MgBetaTeamworkDeletedTeamChannelMember](Add-MgBetaTeamworkDeletedTeamChannelMember.md)
Add multiple members in a single request to a team.
The response provides details about which memberships could and couldn't be created.

### [Clear-MgBetaChatMessageReaction](Clear-MgBetaChatMessageReaction.md)
Invoke action unsetReaction

### [Clear-MgBetaChatMessageReplyReaction](Clear-MgBetaChatMessageReplyReaction.md)
Invoke action unsetReaction

### [Clear-MgBetaTeamChannelMessageReaction](Clear-MgBetaTeamChannelMessageReaction.md)
Invoke action unsetReaction

### [Clear-MgBetaTeamChannelMessageReplyReaction](Clear-MgBetaTeamChannelMessageReplyReaction.md)
Invoke action unsetReaction

### [Clear-MgBetaTeamPrimaryChannelMessageReaction](Clear-MgBetaTeamPrimaryChannelMessageReaction.md)
Invoke action unsetReaction

### [Clear-MgBetaTeamPrimaryChannelMessageReplyReaction](Clear-MgBetaTeamPrimaryChannelMessageReplyReaction.md)
Invoke action unsetReaction

### [Clear-MgBetaTeamworkDeletedTeamChannelMessageReaction](Clear-MgBetaTeamworkDeletedTeamChannelMessageReaction.md)
Invoke action unsetReaction

### [Clear-MgBetaTeamworkDeletedTeamChannelMessageReplyReaction](Clear-MgBetaTeamworkDeletedTeamChannelMessageReplyReaction.md)
Invoke action unsetReaction

### [Complete-MgBetaTeamChannelMigration](Complete-MgBetaTeamChannelMigration.md)
Complete the message migration process by removing `migration mode` from a channel in a team.
`Migration mode` is a special state that prevents certain operations, like sending messages and adding members, during the data migration process.
After a **completeMigration** request is made, you cannot import additional messages into the team.
You can add members to the team after the request returns a successful response.

### [Complete-MgBetaTeamMigration](Complete-MgBetaTeamMigration.md)
Complete the message migration process by removing `migration mode` from a team.
`Migration mode` is a special state where certain operations are barred, like message POST and membership operations during the data migration process.
After a **completeMigration** request is made, you cannot import additional messages into the team.
You can add members to the team after the request returns a successful response.

### [Complete-MgBetaTeamPrimaryChannelMigration](Complete-MgBetaTeamPrimaryChannelMigration.md)
Complete the message migration process by removing `migration mode` from a channel in a team.
`Migration mode` is a special state that prevents certain operations, like sending messages and adding members, during the data migration process.
After a **completeMigration** request is made, you cannot import additional messages into the team.
You can add members to the team after the request returns a successful response.

### [Complete-MgBetaTeamworkDeletedTeamChannelMigration](Complete-MgBetaTeamworkDeletedTeamChannelMigration.md)
Complete the message migration process by removing `migration mode` from a channel in a team.
`Migration mode` is a special state that prevents certain operations, like sending messages and adding members, during the data migration process.
After a **completeMigration** request is made, you cannot import additional messages into the team.
You can add members to the team after the request returns a successful response.

### [Confirm-MgBetaChatPermissionGrantMemberGroup](Confirm-MgBetaChatPermissionGrantMemberGroup.md)
Check for membership in a specified list of group IDs, and return from that list those groups (identified by IDs) of which the specified user, group, service principal, organizational contact, device, or directory object is a member.
This function is transitive.
You can check up to a maximum of 20 groups per request.
This function supports all groups provisioned in Azure AD.
Because Microsoft 365 groups cannot contain other groups, membership in a Microsoft 365 group is always direct.

### [Confirm-MgBetaChatPermissionGrantMemberObject](Confirm-MgBetaChatPermissionGrantMemberObject.md)
Invoke action checkMemberObjects

### [Confirm-MgBetaTeamPermissionGrantMemberGroup](Confirm-MgBetaTeamPermissionGrantMemberGroup.md)
Check for membership in a specified list of group IDs, and return from that list those groups (identified by IDs) of which the specified user, group, service principal, organizational contact, device, or directory object is a member.
This function is transitive.
You can check up to a maximum of 20 groups per request.
This function supports all groups provisioned in Azure AD.
Because Microsoft 365 groups cannot contain other groups, membership in a Microsoft 365 group is always direct.

### [Confirm-MgBetaTeamPermissionGrantMemberObject](Confirm-MgBetaTeamPermissionGrantMemberObject.md)
Invoke action checkMemberObjects

### [Confirm-MgBetaTeamScheduleTimeCard](Confirm-MgBetaTeamScheduleTimeCard.md)
Confirm a specific timeCard.

### [Copy-MgBetaTeam](Copy-MgBetaTeam.md)
Create a copy of a team.
This operation also creates a copy of the corresponding group.\nYou can specify which parts of the team to clone: When tabs are cloned, they are put into an unconfigured state \n-- they are displayed on the tab bar in Microsoft Teams, and the first time you open them, you'll go through the configuration screen.
\n(If the person opening the tab does not have permission to configure apps, they will see a message explaining that the tab hasn't been configured.) Cloning is a long-running operation.\nAfter the POST clone returns, you need to GET the operation \nreturned by the Location: header to see if it's 'running' or 'succeeded' or 'failed'.
\nYou should continue to GET until the status is not 'running'.
\nThe recommended delay between GETs is 5 seconds.

### [Get-MgBetaAllGroupTeamChannel](Get-MgBetaAllGroupTeamChannel.md)
List of channels either hosted in or shared with the team (incoming channels).

### [Get-MgBetaAllTeamChannel](Get-MgBetaAllTeamChannel.md)
List of channels either hosted in or shared with the team (incoming channels).

### [Get-MgBetaAppCatalogTeamApp](Get-MgBetaAppCatalogTeamApp.md)
Get teamsApps from appCatalogs

### [Get-MgBetaAppCatalogTeamAppDefinition](Get-MgBetaAppCatalogTeamAppDefinition.md)
The details for each version of the app.

### [Get-MgBetaAppCatalogTeamAppDefinitionBot](Get-MgBetaAppCatalogTeamAppDefinitionBot.md)
Get the bot associated with a specific definition of the  TeamsApp.

### [Get-MgBetaAppCatalogTeamAppDefinitionColorIcon](Get-MgBetaAppCatalogTeamAppDefinitionColorIcon.md)
Retrieve a Teams app icon associated with a specific definition of an app.

### [Get-MgBetaAppCatalogTeamAppDefinitionColorIconHostedContent](Get-MgBetaAppCatalogTeamAppDefinitionColorIconHostedContent.md)
Retrieve the hosted content in an app's icon.

### [Get-MgBetaAppCatalogTeamAppDefinitionOutlineIcon](Get-MgBetaAppCatalogTeamAppDefinitionOutlineIcon.md)
Retrieve a Teams app icon associated with a specific definition of an app.

### [Get-MgBetaAppCatalogTeamAppDefinitionOutlineIconHostedContent](Get-MgBetaAppCatalogTeamAppDefinitionOutlineIconHostedContent.md)
Retrieve the hosted content in an app's icon.

### [Get-MgBetaChat](Get-MgBetaChat.md)
Retrieve a single chat (without its messages).
This method supports federation.
To access a chat, at least one chat member must belong to the tenant the request initiated from.

### [Get-MgBetaChatInstalledApp](Get-MgBetaChatInstalledApp.md)
A collection of all the apps in the chat.
Nullable.

### [Get-MgBetaChatInstalledAppTeamApp](Get-MgBetaChatInstalledAppTeamApp.md)
The app that is installed.

### [Get-MgBetaChatInstalledAppTeamAppDefinition](Get-MgBetaChatInstalledAppTeamAppDefinition.md)
The details of this version of the app.

### [Get-MgBetaChatLastMessagePreview](Get-MgBetaChatLastMessagePreview.md)
Preview of the last message sent in the chat.
Null if no messages have been sent in the chat.
Currently, only the list chats operation supports this property.

### [Get-MgBetaChatMember](Get-MgBetaChatMember.md)
A collection of all the members in the chat.
Nullable.

### [Get-MgBetaChatMessage](Get-MgBetaChatMessage.md)
Invoke function getAllMessages

### [Get-MgBetaChatMessageDelta](Get-MgBetaChatMessageDelta.md)
Invoke function delta

### [Get-MgBetaChatMessageHostedContent](Get-MgBetaChatMessageHostedContent.md)
Content in a message hosted by Microsoft Teams - for example, images or code snippets.

### [Get-MgBetaChatMessageReply](Get-MgBetaChatMessageReply.md)
Replies for a specified message.
Supports $expand for channel messages.

### [Get-MgBetaChatMessageReplyDelta](Get-MgBetaChatMessageReplyDelta.md)
Invoke function delta

### [Get-MgBetaChatMessageReplyHostedContent](Get-MgBetaChatMessageReplyHostedContent.md)
Content in a message hosted by Microsoft Teams - for example, images or code snippets.

### [Get-MgBetaChatOperation](Get-MgBetaChatOperation.md)
A collection of all the Teams async operations that ran or are running on the chat.
Nullable.

### [Get-MgBetaChatPermissionGrant](Get-MgBetaChatPermissionGrant.md)
A collection of permissions granted to apps for the chat.

### [Get-MgBetaChatPermissionGrantById](Get-MgBetaChatPermissionGrantById.md)
Return the directory objects specified in a list of IDs.
Some common uses for this function are to:

### [Get-MgBetaChatPermissionGrantMemberGroup](Get-MgBetaChatPermissionGrantMemberGroup.md)
Return all the group IDs for the groups that the specified user, group, service principal, organizational contact, device, or directory object is a member of.
This function is transitive.

### [Get-MgBetaChatPermissionGrantMemberObject](Get-MgBetaChatPermissionGrantMemberObject.md)
Invoke action getMemberObjects

### [Get-MgBetaChatPermissionGrantUserOwnedObject](Get-MgBetaChatPermissionGrantUserOwnedObject.md)
Invoke action getUserOwnedObjects

### [Get-MgBetaChatPinnedMessage](Get-MgBetaChatPinnedMessage.md)
A collection of all the pinned messages in the chat.
Nullable.

### [Get-MgBetaChatTab](Get-MgBetaChatTab.md)
A collection of all the tabs in the chat.
Nullable.

### [Get-MgBetaChatTabTeamApp](Get-MgBetaChatTabTeamApp.md)
The application that is linked to the tab.

### [Get-MgBetaGroupTeam](Get-MgBetaGroupTeam.md)
The team associated with this group.

### [Get-MgBetaGroupTeamChannel](Get-MgBetaGroupTeamChannel.md)
The collection of channels and messages associated with the team.

### [Get-MgBetaGroupTeamChannelFileFolder](Get-MgBetaGroupTeamChannelFileFolder.md)
Get the metadata for the location where the files of a channel are stored.

### [Get-MgBetaGroupTeamChannelFileFolderContent](Get-MgBetaGroupTeamChannelFileFolderContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaGroupTeamChannelMember](Get-MgBetaGroupTeamChannelMember.md)
A collection of membership records associated with the channel.

### [Get-MgBetaGroupTeamChannelMessage](Get-MgBetaGroupTeamChannelMessage.md)
A collection of all the messages in the channel.
A navigation property.
Nullable.

### [Get-MgBetaGroupTeamChannelMessageHostedContent](Get-MgBetaGroupTeamChannelMessageHostedContent.md)
Content in a message hosted by Microsoft Teams - for example, images or code snippets.

### [Get-MgBetaGroupTeamChannelMessageReply](Get-MgBetaGroupTeamChannelMessageReply.md)
Replies for a specified message.
Supports $expand for channel messages.

### [Get-MgBetaGroupTeamChannelMessageReplyHostedContent](Get-MgBetaGroupTeamChannelMessageReplyHostedContent.md)
Content in a message hosted by Microsoft Teams - for example, images or code snippets.

### [Get-MgBetaGroupTeamChannelSharedWithTeam](Get-MgBetaGroupTeamChannelSharedWithTeam.md)
A collection of teams with which a channel is shared.

### [Get-MgBetaGroupTeamChannelSharedWithTeamAllowedMember](Get-MgBetaGroupTeamChannelSharedWithTeamAllowedMember.md)
A collection of team members who have access to the shared channel.

### [Get-MgBetaGroupTeamChannelTab](Get-MgBetaGroupTeamChannelTab.md)
A collection of all the tabs in the channel.
A navigation property.

### [Get-MgBetaGroupTeamChannelTabTeamApp](Get-MgBetaGroupTeamChannelTabTeamApp.md)
The application that is linked to the tab.

### [Get-MgBetaGroupTeamGroup](Get-MgBetaGroupTeamGroup.md)
Get group from groups

### [Get-MgBetaGroupTeamIncomingChannel](Get-MgBetaGroupTeamIncomingChannel.md)
List of channels shared with the team.

### [Get-MgBetaGroupTeamInstalledApp](Get-MgBetaGroupTeamInstalledApp.md)
The apps installed in this team.

### [Get-MgBetaGroupTeamInstalledAppTeamApp](Get-MgBetaGroupTeamInstalledAppTeamApp.md)
The app that is installed.

### [Get-MgBetaGroupTeamInstalledAppTeamAppDefinition](Get-MgBetaGroupTeamInstalledAppTeamAppDefinition.md)
The details of this version of the app.

### [Get-MgBetaGroupTeamMember](Get-MgBetaGroupTeamMember.md)
Members and owners of the team.

### [Get-MgBetaGroupTeamOperation](Get-MgBetaGroupTeamOperation.md)
The async operations that ran or are running on this team.

### [Get-MgBetaGroupTeamOwner](Get-MgBetaGroupTeamOwner.md)
The list of this team's owners.
Currently, when creating a team using application permissions, exactly one owner must be specified.
When using user delegated permissions, no owner can be specified (the current user is the owner).
Owner must be specified as an object ID (GUID), not a UPN.

### [Get-MgBetaGroupTeamPermissionGrant](Get-MgBetaGroupTeamPermissionGrant.md)
A collection of permissions granted to apps to access the team.

### [Get-MgBetaGroupTeamPhoto](Get-MgBetaGroupTeamPhoto.md)
The team photo.

### [Get-MgBetaGroupTeamPhotoContent](Get-MgBetaGroupTeamPhotoContent.md)
Get media content for the navigation property photo from groups

### [Get-MgBetaGroupTeamPrimaryChannel](Get-MgBetaGroupTeamPrimaryChannel.md)
Get the default channel, **General**, of a team.

### [Get-MgBetaGroupTeamPrimaryChannelFileFolder](Get-MgBetaGroupTeamPrimaryChannelFileFolder.md)
Get the metadata for the location where the files of a channel are stored.

### [Get-MgBetaGroupTeamPrimaryChannelFileFolderContent](Get-MgBetaGroupTeamPrimaryChannelFileFolderContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaGroupTeamPrimaryChannelMember](Get-MgBetaGroupTeamPrimaryChannelMember.md)
A collection of membership records associated with the channel.

### [Get-MgBetaGroupTeamPrimaryChannelMessage](Get-MgBetaGroupTeamPrimaryChannelMessage.md)
A collection of all the messages in the channel.
A navigation property.
Nullable.

### [Get-MgBetaGroupTeamPrimaryChannelMessageHostedContent](Get-MgBetaGroupTeamPrimaryChannelMessageHostedContent.md)
Content in a message hosted by Microsoft Teams - for example, images or code snippets.

### [Get-MgBetaGroupTeamPrimaryChannelMessageReply](Get-MgBetaGroupTeamPrimaryChannelMessageReply.md)
Replies for a specified message.
Supports $expand for channel messages.

### [Get-MgBetaGroupTeamPrimaryChannelMessageReplyHostedContent](Get-MgBetaGroupTeamPrimaryChannelMessageReplyHostedContent.md)
Content in a message hosted by Microsoft Teams - for example, images or code snippets.

### [Get-MgBetaGroupTeamPrimaryChannelSharedWithTeam](Get-MgBetaGroupTeamPrimaryChannelSharedWithTeam.md)
A collection of teams with which a channel is shared.

### [Get-MgBetaGroupTeamPrimaryChannelSharedWithTeamAllowedMember](Get-MgBetaGroupTeamPrimaryChannelSharedWithTeamAllowedMember.md)
A collection of team members who have access to the shared channel.

### [Get-MgBetaGroupTeamPrimaryChannelTab](Get-MgBetaGroupTeamPrimaryChannelTab.md)
A collection of all the tabs in the channel.
A navigation property.

### [Get-MgBetaGroupTeamPrimaryChannelTabTeamApp](Get-MgBetaGroupTeamPrimaryChannelTabTeamApp.md)
The application that is linked to the tab.

### [Get-MgBetaGroupTeamSchedule](Get-MgBetaGroupTeamSchedule.md)
Retrieve the properties and relationships of a schedule object.
The schedule creation process conforms to the One API guideline for resource based long running operations (RELO).\nWhen clients use the PUT method, if the schedule is provisioned, the operation updates the schedule; otherwise, the operation starts the schedule provisioning process in the background.
During schedule provisioning, clients can use the GET method to get the schedule and look at the `provisionStatus` property for the current state of the provisioning.
If the provisioning failed, clients can get additional information from the `provisionStatusCode` property.
Clients can also inspect the configuration of the schedule.

### [Get-MgBetaGroupTeamScheduleOfferShiftRequest](Get-MgBetaGroupTeamScheduleOfferShiftRequest.md)
Get offerShiftRequests from groups

### [Get-MgBetaGroupTeamScheduleOpenShift](Get-MgBetaGroupTeamScheduleOpenShift.md)
Get openShifts from groups

### [Get-MgBetaGroupTeamScheduleOpenShiftChangeRequest](Get-MgBetaGroupTeamScheduleOpenShiftChangeRequest.md)
Get openShiftChangeRequests from groups

### [Get-MgBetaGroupTeamScheduleSchedulingGroup](Get-MgBetaGroupTeamScheduleSchedulingGroup.md)
The logical grouping of users in the schedule (usually by role).

### [Get-MgBetaGroupTeamScheduleShift](Get-MgBetaGroupTeamScheduleShift.md)
The shifts in the schedule.

### [Get-MgBetaGroupTeamScheduleSwapShiftChangeRequest](Get-MgBetaGroupTeamScheduleSwapShiftChangeRequest.md)
Get swapShiftsChangeRequests from groups

### [Get-MgBetaGroupTeamScheduleTimeCard](Get-MgBetaGroupTeamScheduleTimeCard.md)
Get timeCards from groups

### [Get-MgBetaGroupTeamScheduleTimeOff](Get-MgBetaGroupTeamScheduleTimeOff.md)
The instances of times off in the schedule.

### [Get-MgBetaGroupTeamScheduleTimeOffReason](Get-MgBetaGroupTeamScheduleTimeOffReason.md)
The set of reasons for a time off in the schedule.

### [Get-MgBetaGroupTeamScheduleTimeOffRequest](Get-MgBetaGroupTeamScheduleTimeOffRequest.md)
Get timeOffRequests from groups

### [Get-MgBetaGroupTeamTag](Get-MgBetaGroupTeamTag.md)
The tags associated with the team.

### [Get-MgBetaGroupTeamTagMember](Get-MgBetaGroupTeamTagMember.md)
Users assigned to the tag.

### [Get-MgBetaGroupTeamTemplate](Get-MgBetaGroupTeamTemplate.md)
The template this team was created from.
See available templates.

### [Get-MgBetaGroupTeamTemplateDefinition](Get-MgBetaGroupTeamTemplateDefinition.md)
Get templateDefinition from groups

### [Get-MgBetaTeam](Get-MgBetaTeam.md)
Retrieve the properties and relationships of the specified team.

### [Get-MgBetaTeamChannel](Get-MgBetaTeamChannel.md)
The collection of channels and messages associated with the team.

### [Get-MgBetaTeamChannelFileFolder](Get-MgBetaTeamChannelFileFolder.md)
Get the metadata for the location where the files of a channel are stored.

### [Get-MgBetaTeamChannelFileFolderContent](Get-MgBetaTeamChannelFileFolderContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaTeamChannelMember](Get-MgBetaTeamChannelMember.md)
A collection of membership records associated with the channel.

### [Get-MgBetaTeamChannelMessage](Get-MgBetaTeamChannelMessage.md)
A collection of all the messages in the channel.
A navigation property.
Nullable.

### [Get-MgBetaTeamChannelMessageDelta](Get-MgBetaTeamChannelMessageDelta.md)
Invoke function delta

### [Get-MgBetaTeamChannelMessageHostedContent](Get-MgBetaTeamChannelMessageHostedContent.md)
Content in a message hosted by Microsoft Teams - for example, images or code snippets.

### [Get-MgBetaTeamChannelMessageReply](Get-MgBetaTeamChannelMessageReply.md)
Replies for a specified message.
Supports $expand for channel messages.

### [Get-MgBetaTeamChannelMessageReplyDelta](Get-MgBetaTeamChannelMessageReplyDelta.md)
Invoke function delta

### [Get-MgBetaTeamChannelMessageReplyHostedContent](Get-MgBetaTeamChannelMessageReplyHostedContent.md)
Content in a message hosted by Microsoft Teams - for example, images or code snippets.

### [Get-MgBetaTeamChannelSharedWithTeam](Get-MgBetaTeamChannelSharedWithTeam.md)
A collection of teams with which a channel is shared.

### [Get-MgBetaTeamChannelSharedWithTeamAllowedMember](Get-MgBetaTeamChannelSharedWithTeamAllowedMember.md)
A collection of team members who have access to the shared channel.

### [Get-MgBetaTeamChannelTab](Get-MgBetaTeamChannelTab.md)
A collection of all the tabs in the channel.
A navigation property.

### [Get-MgBetaTeamChannelTabTeamApp](Get-MgBetaTeamChannelTabTeamApp.md)
The application that is linked to the tab.

### [Get-MgBetaTeamIncomingChannel](Get-MgBetaTeamIncomingChannel.md)
List of channels shared with the team.

### [Get-MgBetaTeamInstalledApp](Get-MgBetaTeamInstalledApp.md)
The apps installed in this team.

### [Get-MgBetaTeamInstalledAppTeamApp](Get-MgBetaTeamInstalledAppTeamApp.md)
The app that is installed.

### [Get-MgBetaTeamInstalledAppTeamAppDefinition](Get-MgBetaTeamInstalledAppTeamAppDefinition.md)
The details of this version of the app.

### [Get-MgBetaTeamMember](Get-MgBetaTeamMember.md)
Members and owners of the team.

### [Get-MgBetaTeamMessage](Get-MgBetaTeamMessage.md)
Invoke function getAllMessages

### [Get-MgBetaTeamOperation](Get-MgBetaTeamOperation.md)
The async operations that ran or are running on this team.

### [Get-MgBetaTeamOwner](Get-MgBetaTeamOwner.md)
The list of this team's owners.
Currently, when creating a team using application permissions, exactly one owner must be specified.
When using user delegated permissions, no owner can be specified (the current user is the owner).
Owner must be specified as an object ID (GUID), not a UPN.

### [Get-MgBetaTeamPermissionGrant](Get-MgBetaTeamPermissionGrant.md)
A collection of permissions granted to apps to access the team.

### [Get-MgBetaTeamPermissionGrantById](Get-MgBetaTeamPermissionGrantById.md)
Return the directory objects specified in a list of IDs.
Some common uses for this function are to:

### [Get-MgBetaTeamPermissionGrantMemberGroup](Get-MgBetaTeamPermissionGrantMemberGroup.md)
Return all the group IDs for the groups that the specified user, group, service principal, organizational contact, device, or directory object is a member of.
This function is transitive.

### [Get-MgBetaTeamPermissionGrantMemberObject](Get-MgBetaTeamPermissionGrantMemberObject.md)
Invoke action getMemberObjects

### [Get-MgBetaTeamPermissionGrantUserOwnedObject](Get-MgBetaTeamPermissionGrantUserOwnedObject.md)
Invoke action getUserOwnedObjects

### [Get-MgBetaTeamPhoto](Get-MgBetaTeamPhoto.md)
The team photo.

### [Get-MgBetaTeamPhotoContent](Get-MgBetaTeamPhotoContent.md)
Get media content for the navigation property photo from teams

### [Get-MgBetaTeamPrimaryChannel](Get-MgBetaTeamPrimaryChannel.md)
Get the default channel, **General**, of a team.

### [Get-MgBetaTeamPrimaryChannelFileFolder](Get-MgBetaTeamPrimaryChannelFileFolder.md)
Get the metadata for the location where the files of a channel are stored.

### [Get-MgBetaTeamPrimaryChannelFileFolderContent](Get-MgBetaTeamPrimaryChannelFileFolderContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaTeamPrimaryChannelMember](Get-MgBetaTeamPrimaryChannelMember.md)
A collection of membership records associated with the channel.

### [Get-MgBetaTeamPrimaryChannelMessage](Get-MgBetaTeamPrimaryChannelMessage.md)
A collection of all the messages in the channel.
A navigation property.
Nullable.

### [Get-MgBetaTeamPrimaryChannelMessageDelta](Get-MgBetaTeamPrimaryChannelMessageDelta.md)
Invoke function delta

### [Get-MgBetaTeamPrimaryChannelMessageHostedContent](Get-MgBetaTeamPrimaryChannelMessageHostedContent.md)
Content in a message hosted by Microsoft Teams - for example, images or code snippets.

### [Get-MgBetaTeamPrimaryChannelMessageReply](Get-MgBetaTeamPrimaryChannelMessageReply.md)
Replies for a specified message.
Supports $expand for channel messages.

### [Get-MgBetaTeamPrimaryChannelMessageReplyDelta](Get-MgBetaTeamPrimaryChannelMessageReplyDelta.md)
Invoke function delta

### [Get-MgBetaTeamPrimaryChannelMessageReplyHostedContent](Get-MgBetaTeamPrimaryChannelMessageReplyHostedContent.md)
Content in a message hosted by Microsoft Teams - for example, images or code snippets.

### [Get-MgBetaTeamPrimaryChannelSharedWithTeam](Get-MgBetaTeamPrimaryChannelSharedWithTeam.md)
A collection of teams with which a channel is shared.

### [Get-MgBetaTeamPrimaryChannelSharedWithTeamAllowedMember](Get-MgBetaTeamPrimaryChannelSharedWithTeamAllowedMember.md)
A collection of team members who have access to the shared channel.

### [Get-MgBetaTeamPrimaryChannelTab](Get-MgBetaTeamPrimaryChannelTab.md)
A collection of all the tabs in the channel.
A navigation property.

### [Get-MgBetaTeamPrimaryChannelTabTeamApp](Get-MgBetaTeamPrimaryChannelTabTeamApp.md)
The application that is linked to the tab.

### [Get-MgBetaTeamSchedule](Get-MgBetaTeamSchedule.md)
Retrieve the properties and relationships of a schedule object.
The schedule creation process conforms to the One API guideline for resource based long running operations (RELO).\nWhen clients use the PUT method, if the schedule is provisioned, the operation updates the schedule; otherwise, the operation starts the schedule provisioning process in the background.
During schedule provisioning, clients can use the GET method to get the schedule and look at the `provisionStatus` property for the current state of the provisioning.
If the provisioning failed, clients can get additional information from the `provisionStatusCode` property.
Clients can also inspect the configuration of the schedule.

### [Get-MgBetaTeamScheduleOfferShiftRequest](Get-MgBetaTeamScheduleOfferShiftRequest.md)
Get offerShiftRequests from teams

### [Get-MgBetaTeamScheduleOpenShift](Get-MgBetaTeamScheduleOpenShift.md)
Get openShifts from teams

### [Get-MgBetaTeamScheduleOpenShiftChangeRequest](Get-MgBetaTeamScheduleOpenShiftChangeRequest.md)
Get openShiftChangeRequests from teams

### [Get-MgBetaTeamScheduleSchedulingGroup](Get-MgBetaTeamScheduleSchedulingGroup.md)
The logical grouping of users in the schedule (usually by role).

### [Get-MgBetaTeamScheduleShift](Get-MgBetaTeamScheduleShift.md)
The shifts in the schedule.

### [Get-MgBetaTeamScheduleSwapShiftChangeRequest](Get-MgBetaTeamScheduleSwapShiftChangeRequest.md)
Get swapShiftsChangeRequests from teams

### [Get-MgBetaTeamScheduleTimeCard](Get-MgBetaTeamScheduleTimeCard.md)
Get timeCards from teams

### [Get-MgBetaTeamScheduleTimeOff](Get-MgBetaTeamScheduleTimeOff.md)
The instances of times off in the schedule.

### [Get-MgBetaTeamScheduleTimeOffReason](Get-MgBetaTeamScheduleTimeOffReason.md)
The set of reasons for a time off in the schedule.

### [Get-MgBetaTeamScheduleTimeOffRequest](Get-MgBetaTeamScheduleTimeOffRequest.md)
Get timeOffRequests from teams

### [Get-MgBetaTeamTag](Get-MgBetaTeamTag.md)
The tags associated with the team.

### [Get-MgBetaTeamTagMember](Get-MgBetaTeamTagMember.md)
Users assigned to the tag.

### [Get-MgBetaTeamTemplate](Get-MgBetaTeamTemplate.md)
The template this team was created from.
See available templates.

### [Get-MgBetaTeamTemplateDefinition](Get-MgBetaTeamTemplateDefinition.md)
Get templateDefinition from teams

### [Get-MgBetaTeamwork](Get-MgBetaTeamwork.md)
Get teamwork

### [Get-MgBetaTeamworkDeletedTeam](Get-MgBetaTeamworkDeletedTeam.md)
A collection of deleted teams.

### [Get-MgBetaTeamworkDeletedTeamChannel](Get-MgBetaTeamworkDeletedTeamChannel.md)
The channels those are either shared with this deleted team or created in this deleted team.

### [Get-MgBetaTeamworkDeletedTeamChannelFileFolder](Get-MgBetaTeamworkDeletedTeamChannelFileFolder.md)
Get the metadata for the location where the files of a channel are stored.

### [Get-MgBetaTeamworkDeletedTeamChannelFileFolderContent](Get-MgBetaTeamworkDeletedTeamChannelFileFolderContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaTeamworkDeletedTeamChannelMember](Get-MgBetaTeamworkDeletedTeamChannelMember.md)
A collection of membership records associated with the channel.

### [Get-MgBetaTeamworkDeletedTeamChannelMessage](Get-MgBetaTeamworkDeletedTeamChannelMessage.md)
A collection of all the messages in the channel.
A navigation property.
Nullable.

### [Get-MgBetaTeamworkDeletedTeamChannelMessageDelta](Get-MgBetaTeamworkDeletedTeamChannelMessageDelta.md)
Invoke function delta

### [Get-MgBetaTeamworkDeletedTeamChannelMessageHostedContent](Get-MgBetaTeamworkDeletedTeamChannelMessageHostedContent.md)
Content in a message hosted by Microsoft Teams - for example, images or code snippets.

### [Get-MgBetaTeamworkDeletedTeamChannelMessageReply](Get-MgBetaTeamworkDeletedTeamChannelMessageReply.md)
Replies for a specified message.
Supports $expand for channel messages.

### [Get-MgBetaTeamworkDeletedTeamChannelMessageReplyDelta](Get-MgBetaTeamworkDeletedTeamChannelMessageReplyDelta.md)
Invoke function delta

### [Get-MgBetaTeamworkDeletedTeamChannelMessageReplyHostedContent](Get-MgBetaTeamworkDeletedTeamChannelMessageReplyHostedContent.md)
Content in a message hosted by Microsoft Teams - for example, images or code snippets.

### [Get-MgBetaTeamworkDeletedTeamChannelSharedWithTeam](Get-MgBetaTeamworkDeletedTeamChannelSharedWithTeam.md)
A collection of teams with which a channel is shared.

### [Get-MgBetaTeamworkDeletedTeamChannelSharedWithTeamAllowedMember](Get-MgBetaTeamworkDeletedTeamChannelSharedWithTeamAllowedMember.md)
A collection of team members who have access to the shared channel.

### [Get-MgBetaTeamworkDeletedTeamChannelTab](Get-MgBetaTeamworkDeletedTeamChannelTab.md)
A collection of all the tabs in the channel.
A navigation property.

### [Get-MgBetaTeamworkDeletedTeamChannelTabTeamApp](Get-MgBetaTeamworkDeletedTeamChannelTabTeamApp.md)
The application that is linked to the tab.

### [Get-MgBetaTeamworkDeletedTeamMessage](Get-MgBetaTeamworkDeletedTeamMessage.md)
Invoke function getAllMessages

### [Get-MgBetaTeamworkDevice](Get-MgBetaTeamworkDevice.md)
The Teams devices provisioned for the tenant.

### [Get-MgBetaTeamworkDeviceActivity](Get-MgBetaTeamworkDeviceActivity.md)
Get the activity status of a Microsoft Teams-enabled device.

### [Get-MgBetaTeamworkDeviceConfiguration](Get-MgBetaTeamworkDeviceConfiguration.md)
Get the configuration details of a Microsoft Teams-enabled device, including software versions, peripheral device configuration (for example, camera, display, microphone, and speaker), hardware configuration, and Microsoft Teams client configuration.

### [Get-MgBetaTeamworkDeviceHealth](Get-MgBetaTeamworkDeviceHealth.md)
Get the health details of a Microsoft Teams-enabled device.
Device health is calculated based on the device configuration and other device parameters.

### [Get-MgBetaTeamworkDeviceOperation](Get-MgBetaTeamworkDeviceOperation.md)
The async operations on the device.

### [Get-MgBetaTeamworkTeamAppSetting](Get-MgBetaTeamworkTeamAppSetting.md)
Read the properties and relationships of a teamsAppSettings object.

### [Get-MgBetaTeamworkTeamTemplate](Get-MgBetaTeamworkTeamTemplate.md)
The templates associated with a team.

### [Get-MgBetaTeamworkTeamTemplateDefinition](Get-MgBetaTeamworkTeamTemplateDefinition.md)
Get definitions from teamwork

### [Get-MgBetaTeamworkTeamTemplateDefinitionTeamDefinition](Get-MgBetaTeamworkTeamTemplateDefinitionTeamDefinition.md)
Get the properties of the team associated with a teamTemplateDefinition object.

### [Get-MgBetaTeamworkWorkforceIntegration](Get-MgBetaTeamworkWorkforceIntegration.md)
A workforce integration with shifts.

### [Get-MgBetaUserChat](Get-MgBetaUserChat.md)
Get chats from users

### [Get-MgBetaUserChatInstalledApp](Get-MgBetaUserChatInstalledApp.md)
A collection of all the apps in the chat.
Nullable.

### [Get-MgBetaUserChatInstalledAppTeamApp](Get-MgBetaUserChatInstalledAppTeamApp.md)
The app that is installed.

### [Get-MgBetaUserChatInstalledAppTeamAppDefinition](Get-MgBetaUserChatInstalledAppTeamAppDefinition.md)
The details of this version of the app.

### [Get-MgBetaUserChatLastMessagePreview](Get-MgBetaUserChatLastMessagePreview.md)
Preview of the last message sent in the chat.
Null if no messages have been sent in the chat.
Currently, only the list chats operation supports this property.

### [Get-MgBetaUserChatMember](Get-MgBetaUserChatMember.md)
A collection of all the members in the chat.
Nullable.

### [Get-MgBetaUserChatMessage](Get-MgBetaUserChatMessage.md)
A collection of all the messages in the chat.
Nullable.

### [Get-MgBetaUserChatMessageHostedContent](Get-MgBetaUserChatMessageHostedContent.md)
Content in a message hosted by Microsoft Teams - for example, images or code snippets.

### [Get-MgBetaUserChatMessageReply](Get-MgBetaUserChatMessageReply.md)
Replies for a specified message.
Supports $expand for channel messages.

### [Get-MgBetaUserChatMessageReplyHostedContent](Get-MgBetaUserChatMessageReplyHostedContent.md)
Content in a message hosted by Microsoft Teams - for example, images or code snippets.

### [Get-MgBetaUserChatOperation](Get-MgBetaUserChatOperation.md)
A collection of all the Teams async operations that ran or are running on the chat.
Nullable.

### [Get-MgBetaUserChatPermissionGrant](Get-MgBetaUserChatPermissionGrant.md)
A collection of permissions granted to apps for the chat.

### [Get-MgBetaUserChatPinnedMessage](Get-MgBetaUserChatPinnedMessage.md)
A collection of all the pinned messages in the chat.
Nullable.

### [Get-MgBetaUserChatTab](Get-MgBetaUserChatTab.md)
A collection of all the tabs in the chat.
Nullable.

### [Get-MgBetaUserChatTabTeamApp](Get-MgBetaUserChatTabTeamApp.md)
The application that is linked to the tab.

### [Get-MgBetaUserJoinedTeam](Get-MgBetaUserJoinedTeam.md)
Get the teams in Microsoft Teams that the user is a direct member of.

### [Get-MgBetaUserTeamwork](Get-MgBetaUserTeamwork.md)
A container for Microsoft Teams features available for the user.
Read-only.
Nullable.

### [Get-MgBetaUserTeamworkAssociatedTeam](Get-MgBetaUserTeamworkAssociatedTeam.md)
The list of associatedTeamInfo objects that a user is associated with.

### [Get-MgBetaUserTeamworkInstalledApp](Get-MgBetaUserTeamworkInstalledApp.md)
The apps installed in the personal scope of this user.

### [Get-MgBetaUserTeamworkInstalledAppChat](Get-MgBetaUserTeamworkInstalledAppChat.md)
Retrieve the chat of the specified user and Teams app.

### [Hide-MgBetaChatForUser](Hide-MgBetaChatForUser.md)
Hide a chat for a user.

### [Invoke-MgBetaArchiveTeam](Invoke-MgBetaArchiveTeam.md)
Archive the specified team.
\nWhen a team is archived, users can no longer send or like messages on any channel in the team, edit the team's name, description, or other settings, or in general make most changes to the team.\nMembership changes to the team continue to be allowed.
Archiving is an async operation.
A team is archived once the async operation completes successfully, which may occur subsequent to a response from this API.
To archive a team, the team and group must have an owner.
To restore a team from its archived state, use the API to unarchive.

### [Invoke-MgBetaClockTeamScheduleTimeCardIn](Invoke-MgBetaClockTeamScheduleTimeCardIn.md)
Clock in to start a timeCard.

### [Invoke-MgBetaClockTeamScheduleTimeCardOut](Invoke-MgBetaClockTeamScheduleTimeCardOut.md)
Clock out to end an open timeCard.

### [Invoke-MgBetaGraphChat](Invoke-MgBetaGraphChat.md)
Unhide a chat for a user.

### [Invoke-MgBetaHaveTeamChannel](Invoke-MgBetaHaveTeamChannel.md)
Invoke function doesUserHaveAccess

### [Invoke-MgBetaHaveTeamPrimaryChannel](Invoke-MgBetaHaveTeamPrimaryChannel.md)
Invoke function doesUserHaveAccess

### [Invoke-MgBetaHaveTeamworkDeletedTeamChannel](Invoke-MgBetaHaveTeamworkDeletedTeamChannel.md)
Invoke function doesUserHaveAccess

### [Invoke-MgBetaMarkChatReadForUser](Invoke-MgBetaMarkChatReadForUser.md)
Mark a chat as read for a user.

### [Invoke-MgBetaMarkChatUnreadForUser](Invoke-MgBetaMarkChatUnreadForUser.md)
Mark a chat as unread for a user.

### [Invoke-MgBetaMessageChat](Invoke-MgBetaMessageChat.md)
Invoke function allMessages

### [Invoke-MgBetaMessageTeam](Invoke-MgBetaMessageTeam.md)
Invoke function allMessages

### [Invoke-MgBetaMessageTeamChannel](Invoke-MgBetaMessageTeamChannel.md)
Invoke function allMessages

### [Invoke-MgBetaMessageTeamworkDeletedTeamChannel](Invoke-MgBetaMessageTeamworkDeletedTeamChannel.md)
Invoke function allMessages

### [Invoke-MgBetaShareTeamSchedule](Invoke-MgBetaShareTeamSchedule.md)
Share a schedule time range with schedule members.\nMake the collections of shift, openshift and timeOff items in the specified time range of the schedule viewable by the specified team members, including employees and managers.\nEach shift, openshift and timeOff instance in a schedule supports a draft version and a shared version of the item.
The draft version is viewable by only managers, and the shared version is viewable by employees and managers.
For each shift, openshift and timeOff instance in the specified time range, the share action updates the shared version from the draft version, so that in addition to managers, employees can also view the most current information about the item.
The **notifyTeam** parameter further specifies which employees can view the item.

### [Invoke-MgBetaSoftChatMessageDelete](Invoke-MgBetaSoftChatMessageDelete.md)
Delete a single message or a message reply in a channel or a chat.

### [Invoke-MgBetaSoftChatMessageReplyDelete](Invoke-MgBetaSoftChatMessageReplyDelete.md)
Delete a single message or a message reply in a channel or a chat.

### [Invoke-MgBetaSoftTeamChannelMessageDelete](Invoke-MgBetaSoftTeamChannelMessageDelete.md)
Delete a single message or a message reply in a channel or a chat.

### [Invoke-MgBetaSoftTeamChannelMessageReplyDelete](Invoke-MgBetaSoftTeamChannelMessageReplyDelete.md)
Delete a single message or a message reply in a channel or a chat.

### [Invoke-MgBetaSoftTeamPrimaryChannelMessageDelete](Invoke-MgBetaSoftTeamPrimaryChannelMessageDelete.md)
Delete a single message or a message reply in a channel or a chat.

### [Invoke-MgBetaSoftTeamPrimaryChannelMessageReplyDelete](Invoke-MgBetaSoftTeamPrimaryChannelMessageReplyDelete.md)
Delete a single message or a message reply in a channel or a chat.

### [Invoke-MgBetaSoftTeamworkDeletedTeamChannelMessageDelete](Invoke-MgBetaSoftTeamworkDeletedTeamChannelMessageDelete.md)
Delete a single message or a message reply in a channel or a chat.

### [Invoke-MgBetaSoftTeamworkDeletedTeamChannelMessageReplyDelete](Invoke-MgBetaSoftTeamworkDeletedTeamChannelMessageReplyDelete.md)
Delete a single message or a message reply in a channel or a chat.

### [Invoke-MgBetaUnarchiveTeam](Invoke-MgBetaUnarchiveTeam.md)
Restore an archived team.
This restores users' ability to send messages and edit the team, abiding by tenant and team settings.
Teams are archived using the archive API.
Unarchiving is an async operation.
A team is unarchived once the async operation completes successfully, which may occur subsequent to a response from this API.

### [New-MgBetaAppCatalogTeamApp](New-MgBetaAppCatalogTeamApp.md)
Publish an app to the Microsoft Teams app catalog.\nSpecifically, this API publishes the app to your organization's catalog (the tenant app catalog);\nthe created resource will have a **distributionMethod** property value of `organization`.
The **requiresReview** property allows any user to submit an app for review by an administrator.
Admins can approve or reject these apps via this API or the Microsoft Teams admin center.

### [New-MgBetaAppCatalogTeamAppDefinition](New-MgBetaAppCatalogTeamAppDefinition.md)
Update an app previously published to the Microsoft Teams app catalog.
To update an app, the **distributionMethod** property for the app must be set to `organization`.
This API specifically updates an app published to your organization's app catalog (the tenant app catalog).

### [New-MgBetaChat](New-MgBetaChat.md)
Create a new chat object.

### [New-MgBetaChatInstalledApp](New-MgBetaChatInstalledApp.md)
Install a teamsApp to the specified chat.

### [New-MgBetaChatMember](New-MgBetaChatMember.md)
Add a conversationMember to a chat.

### [New-MgBetaChatMessage](New-MgBetaChatMessage.md)
Send a new chatMessage in the specified chat.
This API cannot create a new chat; you must use the list chats method to retrieve the ID of an existing chat before creating a chat message.

### [New-MgBetaChatMessageHostedContent](New-MgBetaChatMessageHostedContent.md)
Create new navigation property to hostedContents for chats

### [New-MgBetaChatMessageReply](New-MgBetaChatMessageReply.md)
Send a new reply to a chatMessage in a specified channel.

### [New-MgBetaChatMessageReplyHostedContent](New-MgBetaChatMessageReplyHostedContent.md)
Create new navigation property to hostedContents for chats

### [New-MgBetaChatOperation](New-MgBetaChatOperation.md)
Create new navigation property to operations for chats

### [New-MgBetaChatPermissionGrant](New-MgBetaChatPermissionGrant.md)
Create new navigation property to permissionGrants for chats

### [New-MgBetaChatPinnedMessage](New-MgBetaChatPinnedMessage.md)
Pin a chat message in the specified chat.
This API cannot create a new chat; you must use the list chats method to retrieve the ID of an existing chat before you can pin a chat message.

### [New-MgBetaChatTab](New-MgBetaChatTab.md)
Add (pin) a tab to the specified chat.
\nThe corresponding app must already be installed in the chat.

### [New-MgBetaGroupTeamChannel](New-MgBetaGroupTeamChannel.md)
Create a new channel in a team, as specified in the request body.

### [New-MgBetaGroupTeamChannelMember](New-MgBetaGroupTeamChannelMember.md)
Add a conversationMember to a channel.
This operation is allowed only for channels with a **membershipType** value of `private` or `shared`.

### [New-MgBetaGroupTeamChannelMessage](New-MgBetaGroupTeamChannelMessage.md)
Send a new chatMessage in the specified channel or a chat.

### [New-MgBetaGroupTeamChannelMessageHostedContent](New-MgBetaGroupTeamChannelMessageHostedContent.md)
Create new navigation property to hostedContents for groups

### [New-MgBetaGroupTeamChannelMessageReply](New-MgBetaGroupTeamChannelMessageReply.md)
Send a new reply to a chatMessage in a specified channel.

### [New-MgBetaGroupTeamChannelMessageReplyHostedContent](New-MgBetaGroupTeamChannelMessageReplyHostedContent.md)
Create new navigation property to hostedContents for groups

### [New-MgBetaGroupTeamChannelSharedWithTeam](New-MgBetaGroupTeamChannelSharedWithTeam.md)
Create new navigation property to sharedWithTeams for groups

### [New-MgBetaGroupTeamChannelTab](New-MgBetaGroupTeamChannelTab.md)
Create new navigation property to tabs for groups

### [New-MgBetaGroupTeamInstalledApp](New-MgBetaGroupTeamInstalledApp.md)
Install an app to the specified team.

### [New-MgBetaGroupTeamMember](New-MgBetaGroupTeamMember.md)
Add a new conversation member to a team.

### [New-MgBetaGroupTeamOperation](New-MgBetaGroupTeamOperation.md)
Create new navigation property to operations for groups

### [New-MgBetaGroupTeamPermissionGrant](New-MgBetaGroupTeamPermissionGrant.md)
Create new navigation property to permissionGrants for groups

### [New-MgBetaGroupTeamPrimaryChannelMember](New-MgBetaGroupTeamPrimaryChannelMember.md)
Add a conversationMember to a channel.
This operation is allowed only for channels with a **membershipType** value of `private` or `shared`.

### [New-MgBetaGroupTeamPrimaryChannelMessage](New-MgBetaGroupTeamPrimaryChannelMessage.md)
Send a new chatMessage in the specified channel or a chat.

### [New-MgBetaGroupTeamPrimaryChannelMessageHostedContent](New-MgBetaGroupTeamPrimaryChannelMessageHostedContent.md)
Create new navigation property to hostedContents for groups

### [New-MgBetaGroupTeamPrimaryChannelMessageReply](New-MgBetaGroupTeamPrimaryChannelMessageReply.md)
Send a new reply to a chatMessage in a specified channel.

### [New-MgBetaGroupTeamPrimaryChannelMessageReplyHostedContent](New-MgBetaGroupTeamPrimaryChannelMessageReplyHostedContent.md)
Create new navigation property to hostedContents for groups

### [New-MgBetaGroupTeamPrimaryChannelSharedWithTeam](New-MgBetaGroupTeamPrimaryChannelSharedWithTeam.md)
Create new navigation property to sharedWithTeams for groups

### [New-MgBetaGroupTeamPrimaryChannelTab](New-MgBetaGroupTeamPrimaryChannelTab.md)
Create new navigation property to tabs for groups

### [New-MgBetaGroupTeamScheduleOfferShiftRequest](New-MgBetaGroupTeamScheduleOfferShiftRequest.md)
Create new navigation property to offerShiftRequests for groups

### [New-MgBetaGroupTeamScheduleOpenShift](New-MgBetaGroupTeamScheduleOpenShift.md)
Create new navigation property to openShifts for groups

### [New-MgBetaGroupTeamScheduleOpenShiftChangeRequest](New-MgBetaGroupTeamScheduleOpenShiftChangeRequest.md)
Create instance of an openShiftChangeRequest object.

### [New-MgBetaGroupTeamScheduleSchedulingGroup](New-MgBetaGroupTeamScheduleSchedulingGroup.md)
Create a new schedulingGroup.

### [New-MgBetaGroupTeamScheduleShift](New-MgBetaGroupTeamScheduleShift.md)
Create a new shift instance in a schedule.

### [New-MgBetaGroupTeamScheduleSwapShiftChangeRequest](New-MgBetaGroupTeamScheduleSwapShiftChangeRequest.md)
Create an instance of a swapShiftsChangeRequest object.

### [New-MgBetaGroupTeamScheduleTimeCard](New-MgBetaGroupTeamScheduleTimeCard.md)
Create new navigation property to timeCards for groups

### [New-MgBetaGroupTeamScheduleTimeOff](New-MgBetaGroupTeamScheduleTimeOff.md)
Create a new timeOff instance in a schedule.

### [New-MgBetaGroupTeamScheduleTimeOffReason](New-MgBetaGroupTeamScheduleTimeOffReason.md)
Create a new timeOffReason.

### [New-MgBetaGroupTeamScheduleTimeOffRequest](New-MgBetaGroupTeamScheduleTimeOffRequest.md)
Create new navigation property to timeOffRequests for groups

### [New-MgBetaGroupTeamTag](New-MgBetaGroupTeamTag.md)
Create a standard tag for members in the team.

### [New-MgBetaGroupTeamTagMember](New-MgBetaGroupTeamTagMember.md)
Create a new teamworkTagMember object in a team.

### [New-MgBetaTeam](New-MgBetaTeam.md)
Create a new team.

### [New-MgBetaTeamChannel](New-MgBetaTeamChannel.md)
Create a new channel in a team, as specified in the request body.

### [New-MgBetaTeamChannelEmail](New-MgBetaTeamChannelEmail.md)
Provision an email address for a channel.
Microsoft Teams doesn't automatically provision an email address for a **channel** by default.
To have Teams provision an email address, you can call **provisionEmail**, or through the Teams user interface, select **Get email address**, which triggers Teams to generate an email address if it has not already provisioned one.
To remove the email address of a **channel**, use the removeEmail method.

### [New-MgBetaTeamChannelMember](New-MgBetaTeamChannelMember.md)
Add a conversationMember to a channel.
This operation is allowed only for channels with a **membershipType** value of `private` or `shared`.

### [New-MgBetaTeamChannelMessage](New-MgBetaTeamChannelMessage.md)
Send a new chatMessage in the specified channel or a chat.

### [New-MgBetaTeamChannelMessageHostedContent](New-MgBetaTeamChannelMessageHostedContent.md)
Create new navigation property to hostedContents for teams

### [New-MgBetaTeamChannelMessageReply](New-MgBetaTeamChannelMessageReply.md)
Send a new reply to a chatMessage in a specified channel.

### [New-MgBetaTeamChannelMessageReplyHostedContent](New-MgBetaTeamChannelMessageReplyHostedContent.md)
Create new navigation property to hostedContents for teams

### [New-MgBetaTeamChannelSharedWithTeam](New-MgBetaTeamChannelSharedWithTeam.md)
Create new navigation property to sharedWithTeams for teams

### [New-MgBetaTeamChannelTab](New-MgBetaTeamChannelTab.md)
Create new navigation property to tabs for teams

### [New-MgBetaTeamInstalledApp](New-MgBetaTeamInstalledApp.md)
Install an app to the specified team.

### [New-MgBetaTeamMember](New-MgBetaTeamMember.md)
Add a new conversation member to a team.

### [New-MgBetaTeamOperation](New-MgBetaTeamOperation.md)
Create new navigation property to operations for teams

### [New-MgBetaTeamPermissionGrant](New-MgBetaTeamPermissionGrant.md)
Create new navigation property to permissionGrants for teams

### [New-MgBetaTeamPrimaryChannelEmail](New-MgBetaTeamPrimaryChannelEmail.md)
Provision an email address for a channel.
Microsoft Teams doesn't automatically provision an email address for a **channel** by default.
To have Teams provision an email address, you can call **provisionEmail**, or through the Teams user interface, select **Get email address**, which triggers Teams to generate an email address if it has not already provisioned one.
To remove the email address of a **channel**, use the removeEmail method.

### [New-MgBetaTeamPrimaryChannelMember](New-MgBetaTeamPrimaryChannelMember.md)
Add a conversationMember to a channel.
This operation is allowed only for channels with a **membershipType** value of `private` or `shared`.

### [New-MgBetaTeamPrimaryChannelMessage](New-MgBetaTeamPrimaryChannelMessage.md)
Send a new chatMessage in the specified channel or a chat.

### [New-MgBetaTeamPrimaryChannelMessageHostedContent](New-MgBetaTeamPrimaryChannelMessageHostedContent.md)
Create new navigation property to hostedContents for teams

### [New-MgBetaTeamPrimaryChannelMessageReply](New-MgBetaTeamPrimaryChannelMessageReply.md)
Send a new reply to a chatMessage in a specified channel.

### [New-MgBetaTeamPrimaryChannelMessageReplyHostedContent](New-MgBetaTeamPrimaryChannelMessageReplyHostedContent.md)
Create new navigation property to hostedContents for teams

### [New-MgBetaTeamPrimaryChannelSharedWithTeam](New-MgBetaTeamPrimaryChannelSharedWithTeam.md)
Create new navigation property to sharedWithTeams for teams

### [New-MgBetaTeamPrimaryChannelTab](New-MgBetaTeamPrimaryChannelTab.md)
Create new navigation property to tabs for teams

### [New-MgBetaTeamScheduleOfferShiftRequest](New-MgBetaTeamScheduleOfferShiftRequest.md)
Create new navigation property to offerShiftRequests for teams

### [New-MgBetaTeamScheduleOpenShift](New-MgBetaTeamScheduleOpenShift.md)
Create new navigation property to openShifts for teams

### [New-MgBetaTeamScheduleOpenShiftChangeRequest](New-MgBetaTeamScheduleOpenShiftChangeRequest.md)
Create instance of an openShiftChangeRequest object.

### [New-MgBetaTeamScheduleSchedulingGroup](New-MgBetaTeamScheduleSchedulingGroup.md)
Create a new schedulingGroup.

### [New-MgBetaTeamScheduleShift](New-MgBetaTeamScheduleShift.md)
Create a new shift instance in a schedule.

### [New-MgBetaTeamScheduleSwapShiftChangeRequest](New-MgBetaTeamScheduleSwapShiftChangeRequest.md)
Create an instance of a swapShiftsChangeRequest object.

### [New-MgBetaTeamScheduleTimeCard](New-MgBetaTeamScheduleTimeCard.md)
Create new navigation property to timeCards for teams

### [New-MgBetaTeamScheduleTimeOff](New-MgBetaTeamScheduleTimeOff.md)
Create a new timeOff instance in a schedule.

### [New-MgBetaTeamScheduleTimeOffReason](New-MgBetaTeamScheduleTimeOffReason.md)
Create a new timeOffReason.

### [New-MgBetaTeamScheduleTimeOffRequest](New-MgBetaTeamScheduleTimeOffRequest.md)
Create new navigation property to timeOffRequests for teams

### [New-MgBetaTeamTag](New-MgBetaTeamTag.md)
Create a standard tag for members in the team.

### [New-MgBetaTeamTagMember](New-MgBetaTeamTagMember.md)
Create a new teamworkTagMember object in a team.

### [New-MgBetaTeamworkDeletedTeam](New-MgBetaTeamworkDeletedTeam.md)
Create new navigation property to deletedTeams for teamwork

### [New-MgBetaTeamworkDeletedTeamChannel](New-MgBetaTeamworkDeletedTeamChannel.md)
Create new navigation property to channels for teamwork

### [New-MgBetaTeamworkDeletedTeamChannelEmail](New-MgBetaTeamworkDeletedTeamChannelEmail.md)
Provision an email address for a channel.
Microsoft Teams doesn't automatically provision an email address for a **channel** by default.
To have Teams provision an email address, you can call **provisionEmail**, or through the Teams user interface, select **Get email address**, which triggers Teams to generate an email address if it has not already provisioned one.
To remove the email address of a **channel**, use the removeEmail method.

### [New-MgBetaTeamworkDeletedTeamChannelMember](New-MgBetaTeamworkDeletedTeamChannelMember.md)
Add a conversationMember to a channel.
This operation is allowed only for channels with a **membershipType** value of `private` or `shared`.

### [New-MgBetaTeamworkDeletedTeamChannelMessage](New-MgBetaTeamworkDeletedTeamChannelMessage.md)
Send a new chatMessage in the specified channel or a chat.

### [New-MgBetaTeamworkDeletedTeamChannelMessageHostedContent](New-MgBetaTeamworkDeletedTeamChannelMessageHostedContent.md)
Create new navigation property to hostedContents for teamwork

### [New-MgBetaTeamworkDeletedTeamChannelMessageReply](New-MgBetaTeamworkDeletedTeamChannelMessageReply.md)
Send a new reply to a chatMessage in a specified channel.

### [New-MgBetaTeamworkDeletedTeamChannelMessageReplyHostedContent](New-MgBetaTeamworkDeletedTeamChannelMessageReplyHostedContent.md)
Create new navigation property to hostedContents for teamwork

### [New-MgBetaTeamworkDeletedTeamChannelSharedWithTeam](New-MgBetaTeamworkDeletedTeamChannelSharedWithTeam.md)
Create new navigation property to sharedWithTeams for teamwork

### [New-MgBetaTeamworkDeletedTeamChannelTab](New-MgBetaTeamworkDeletedTeamChannelTab.md)
Create new navigation property to tabs for teamwork

### [New-MgBetaTeamworkDevice](New-MgBetaTeamworkDevice.md)
Create new navigation property to devices for teamwork

### [New-MgBetaTeamworkDeviceOperation](New-MgBetaTeamworkDeviceOperation.md)
Create new navigation property to operations for teamwork

### [New-MgBetaTeamworkTeamTemplate](New-MgBetaTeamworkTeamTemplate.md)
Create new navigation property to teamTemplates for teamwork

### [New-MgBetaTeamworkTeamTemplateDefinition](New-MgBetaTeamworkTeamTemplateDefinition.md)
Create new navigation property to definitions for teamwork

### [New-MgBetaTeamworkWorkforceIntegration](New-MgBetaTeamworkWorkforceIntegration.md)
Create a new workforceIntegration object.

### [New-MgBetaUserChat](New-MgBetaUserChat.md)
Create new navigation property to chats for users

### [New-MgBetaUserChatInstalledApp](New-MgBetaUserChatInstalledApp.md)
Install a teamsApp to the specified chat.

### [New-MgBetaUserChatMember](New-MgBetaUserChatMember.md)
Add a conversationMember to a chat.

### [New-MgBetaUserChatMessage](New-MgBetaUserChatMessage.md)
Send a new chatMessage in the specified chat.
This API cannot create a new chat; you must use the list chats method to retrieve the ID of an existing chat before creating a chat message.

### [New-MgBetaUserChatMessageHostedContent](New-MgBetaUserChatMessageHostedContent.md)
Create new navigation property to hostedContents for users

### [New-MgBetaUserChatMessageReply](New-MgBetaUserChatMessageReply.md)
Send a new reply to a chatMessage in a specified channel.

### [New-MgBetaUserChatMessageReplyHostedContent](New-MgBetaUserChatMessageReplyHostedContent.md)
Create new navigation property to hostedContents for users

### [New-MgBetaUserChatOperation](New-MgBetaUserChatOperation.md)
Create new navigation property to operations for users

### [New-MgBetaUserChatPermissionGrant](New-MgBetaUserChatPermissionGrant.md)
Create new navigation property to permissionGrants for users

### [New-MgBetaUserChatPinnedMessage](New-MgBetaUserChatPinnedMessage.md)
Pin a chat message in the specified chat.
This API cannot create a new chat; you must use the list chats method to retrieve the ID of an existing chat before you can pin a chat message.

### [New-MgBetaUserChatTab](New-MgBetaUserChatTab.md)
Add (pin) a tab to the specified chat.
\nThe corresponding app must already be installed in the chat.

### [New-MgBetaUserTeamworkAssociatedTeam](New-MgBetaUserTeamworkAssociatedTeam.md)
Create new navigation property to associatedTeams for users

### [New-MgBetaUserTeamworkInstalledApp](New-MgBetaUserTeamworkInstalledApp.md)
Install an app in the personal scope of the specified user.

### [Remove-MgBetaAppCatalogTeamApp](Remove-MgBetaAppCatalogTeamApp.md)
Delete navigation property teamsApps for appCatalogs

### [Remove-MgBetaAppCatalogTeamAppDefinition](Remove-MgBetaAppCatalogTeamAppDefinition.md)
Delete navigation property appDefinitions for appCatalogs

### [Remove-MgBetaAppCatalogTeamAppDefinitionBot](Remove-MgBetaAppCatalogTeamAppDefinitionBot.md)
Delete navigation property bot for appCatalogs

### [Remove-MgBetaAppCatalogTeamAppDefinitionColorIcon](Remove-MgBetaAppCatalogTeamAppDefinitionColorIcon.md)
Delete navigation property colorIcon for appCatalogs

### [Remove-MgBetaAppCatalogTeamAppDefinitionColorIconHostedContent](Remove-MgBetaAppCatalogTeamAppDefinitionColorIconHostedContent.md)
Delete navigation property hostedContent for appCatalogs

### [Remove-MgBetaAppCatalogTeamAppDefinitionOutlineIcon](Remove-MgBetaAppCatalogTeamAppDefinitionOutlineIcon.md)
Delete navigation property outlineIcon for appCatalogs

### [Remove-MgBetaAppCatalogTeamAppDefinitionOutlineIconHostedContent](Remove-MgBetaAppCatalogTeamAppDefinitionOutlineIconHostedContent.md)
Delete navigation property hostedContent for appCatalogs

### [Remove-MgBetaChat](Remove-MgBetaChat.md)
Delete entity from chats

### [Remove-MgBetaChatInstalledApp](Remove-MgBetaChatInstalledApp.md)
Delete navigation property installedApps for chats

### [Remove-MgBetaChatLastMessagePreview](Remove-MgBetaChatLastMessagePreview.md)
Delete navigation property lastMessagePreview for chats

### [Remove-MgBetaChatMember](Remove-MgBetaChatMember.md)
Delete navigation property members for chats

### [Remove-MgBetaChatMessageReplyHostedContent](Remove-MgBetaChatMessageReplyHostedContent.md)
Delete navigation property hostedContents for chats

### [Remove-MgBetaChatOperation](Remove-MgBetaChatOperation.md)
Delete navigation property operations for chats

### [Remove-MgBetaChatPermissionGrant](Remove-MgBetaChatPermissionGrant.md)
Delete navigation property permissionGrants for chats

### [Remove-MgBetaChatPinnedMessage](Remove-MgBetaChatPinnedMessage.md)
Delete navigation property pinnedMessages for chats

### [Remove-MgBetaChatTab](Remove-MgBetaChatTab.md)
Delete navigation property tabs for chats

### [Remove-MgBetaGroupTeam](Remove-MgBetaGroupTeam.md)
Delete navigation property team for groups

### [Remove-MgBetaGroupTeamChannel](Remove-MgBetaGroupTeamChannel.md)
Delete navigation property channels for groups

### [Remove-MgBetaGroupTeamChannelMember](Remove-MgBetaGroupTeamChannelMember.md)
Delete navigation property members for groups

### [Remove-MgBetaGroupTeamChannelMessage](Remove-MgBetaGroupTeamChannelMessage.md)
Delete navigation property messages for groups

### [Remove-MgBetaGroupTeamChannelMessageHostedContent](Remove-MgBetaGroupTeamChannelMessageHostedContent.md)
Delete navigation property hostedContents for groups

### [Remove-MgBetaGroupTeamChannelMessageReply](Remove-MgBetaGroupTeamChannelMessageReply.md)
Delete navigation property replies for groups

### [Remove-MgBetaGroupTeamChannelMessageReplyHostedContent](Remove-MgBetaGroupTeamChannelMessageReplyHostedContent.md)
Delete navigation property hostedContents for groups

### [Remove-MgBetaGroupTeamChannelSharedWithTeam](Remove-MgBetaGroupTeamChannelSharedWithTeam.md)
Delete navigation property sharedWithTeams for groups

### [Remove-MgBetaGroupTeamChannelTab](Remove-MgBetaGroupTeamChannelTab.md)
Delete navigation property tabs for groups

### [Remove-MgBetaGroupTeamInstalledApp](Remove-MgBetaGroupTeamInstalledApp.md)
Delete navigation property installedApps for groups

### [Remove-MgBetaGroupTeamMember](Remove-MgBetaGroupTeamMember.md)
Delete navigation property members for groups

### [Remove-MgBetaGroupTeamOperation](Remove-MgBetaGroupTeamOperation.md)
Delete navigation property operations for groups

### [Remove-MgBetaGroupTeamPermissionGrant](Remove-MgBetaGroupTeamPermissionGrant.md)
Delete navigation property permissionGrants for groups

### [Remove-MgBetaGroupTeamPhoto](Remove-MgBetaGroupTeamPhoto.md)
Delete navigation property photo for groups

### [Remove-MgBetaGroupTeamPrimaryChannel](Remove-MgBetaGroupTeamPrimaryChannel.md)
Delete navigation property primaryChannel for groups

### [Remove-MgBetaGroupTeamPrimaryChannelMember](Remove-MgBetaGroupTeamPrimaryChannelMember.md)
Delete navigation property members for groups

### [Remove-MgBetaGroupTeamPrimaryChannelMessage](Remove-MgBetaGroupTeamPrimaryChannelMessage.md)
Delete navigation property messages for groups

### [Remove-MgBetaGroupTeamPrimaryChannelMessageHostedContent](Remove-MgBetaGroupTeamPrimaryChannelMessageHostedContent.md)
Delete navigation property hostedContents for groups

### [Remove-MgBetaGroupTeamPrimaryChannelMessageReply](Remove-MgBetaGroupTeamPrimaryChannelMessageReply.md)
Delete navigation property replies for groups

### [Remove-MgBetaGroupTeamPrimaryChannelMessageReplyHostedContent](Remove-MgBetaGroupTeamPrimaryChannelMessageReplyHostedContent.md)
Delete navigation property hostedContents for groups

### [Remove-MgBetaGroupTeamPrimaryChannelSharedWithTeam](Remove-MgBetaGroupTeamPrimaryChannelSharedWithTeam.md)
Delete navigation property sharedWithTeams for groups

### [Remove-MgBetaGroupTeamPrimaryChannelTab](Remove-MgBetaGroupTeamPrimaryChannelTab.md)
Delete navigation property tabs for groups

### [Remove-MgBetaGroupTeamSchedule](Remove-MgBetaGroupTeamSchedule.md)
Delete navigation property schedule for groups

### [Remove-MgBetaGroupTeamScheduleOfferShiftRequest](Remove-MgBetaGroupTeamScheduleOfferShiftRequest.md)
Delete navigation property offerShiftRequests for groups

### [Remove-MgBetaGroupTeamScheduleOpenShift](Remove-MgBetaGroupTeamScheduleOpenShift.md)
Delete navigation property openShifts for groups

### [Remove-MgBetaGroupTeamScheduleOpenShiftChangeRequest](Remove-MgBetaGroupTeamScheduleOpenShiftChangeRequest.md)
Delete navigation property openShiftChangeRequests for groups

### [Remove-MgBetaGroupTeamScheduleSchedulingGroup](Remove-MgBetaGroupTeamScheduleSchedulingGroup.md)
Delete navigation property schedulingGroups for groups

### [Remove-MgBetaGroupTeamScheduleShift](Remove-MgBetaGroupTeamScheduleShift.md)
Delete navigation property shifts for groups

### [Remove-MgBetaGroupTeamScheduleSwapShiftChangeRequest](Remove-MgBetaGroupTeamScheduleSwapShiftChangeRequest.md)
Delete navigation property swapShiftsChangeRequests for groups

### [Remove-MgBetaGroupTeamScheduleTimeCard](Remove-MgBetaGroupTeamScheduleTimeCard.md)
Delete navigation property timeCards for groups

### [Remove-MgBetaGroupTeamScheduleTimeOff](Remove-MgBetaGroupTeamScheduleTimeOff.md)
Delete navigation property timesOff for groups

### [Remove-MgBetaGroupTeamScheduleTimeOffReason](Remove-MgBetaGroupTeamScheduleTimeOffReason.md)
Delete navigation property timeOffReasons for groups

### [Remove-MgBetaGroupTeamScheduleTimeOffRequest](Remove-MgBetaGroupTeamScheduleTimeOffRequest.md)
Delete navigation property timeOffRequests for groups

### [Remove-MgBetaGroupTeamTag](Remove-MgBetaGroupTeamTag.md)
Delete navigation property tags for groups

### [Remove-MgBetaGroupTeamTagMember](Remove-MgBetaGroupTeamTagMember.md)
Delete navigation property members for groups

### [Remove-MgBetaTeam](Remove-MgBetaTeam.md)
Delete entity from teams

### [Remove-MgBetaTeamChannel](Remove-MgBetaTeamChannel.md)
Delete navigation property channels for teams

### [Remove-MgBetaTeamChannelEmail](Remove-MgBetaTeamChannelEmail.md)
Remove the email address of a channel.
You can remove an email address only if it was provisioned using the provisionEmail method or through the Microsoft Teams client.

### [Remove-MgBetaTeamChannelMember](Remove-MgBetaTeamChannelMember.md)
Delete navigation property members for teams

### [Remove-MgBetaTeamChannelMessageReplyHostedContent](Remove-MgBetaTeamChannelMessageReplyHostedContent.md)
Delete navigation property hostedContents for teams

### [Remove-MgBetaTeamChannelSharedWithTeam](Remove-MgBetaTeamChannelSharedWithTeam.md)
Delete navigation property sharedWithTeams for teams

### [Remove-MgBetaTeamChannelTab](Remove-MgBetaTeamChannelTab.md)
Delete navigation property tabs for teams

### [Remove-MgBetaTeamInstalledApp](Remove-MgBetaTeamInstalledApp.md)
Delete navigation property installedApps for teams

### [Remove-MgBetaTeamMember](Remove-MgBetaTeamMember.md)
Delete navigation property members for teams

### [Remove-MgBetaTeamOperation](Remove-MgBetaTeamOperation.md)
Delete navigation property operations for teams

### [Remove-MgBetaTeamPermissionGrant](Remove-MgBetaTeamPermissionGrant.md)
Delete navigation property permissionGrants for teams

### [Remove-MgBetaTeamPhoto](Remove-MgBetaTeamPhoto.md)
Delete navigation property photo for teams

### [Remove-MgBetaTeamPrimaryChannel](Remove-MgBetaTeamPrimaryChannel.md)
Delete navigation property primaryChannel for teams

### [Remove-MgBetaTeamPrimaryChannelEmail](Remove-MgBetaTeamPrimaryChannelEmail.md)
Remove the email address of a channel.
You can remove an email address only if it was provisioned using the provisionEmail method or through the Microsoft Teams client.

### [Remove-MgBetaTeamPrimaryChannelMember](Remove-MgBetaTeamPrimaryChannelMember.md)
Delete navigation property members for teams

### [Remove-MgBetaTeamPrimaryChannelMessageReplyHostedContent](Remove-MgBetaTeamPrimaryChannelMessageReplyHostedContent.md)
Delete navigation property hostedContents for teams

### [Remove-MgBetaTeamPrimaryChannelSharedWithTeam](Remove-MgBetaTeamPrimaryChannelSharedWithTeam.md)
Delete navigation property sharedWithTeams for teams

### [Remove-MgBetaTeamPrimaryChannelTab](Remove-MgBetaTeamPrimaryChannelTab.md)
Delete navigation property tabs for teams

### [Remove-MgBetaTeamSchedule](Remove-MgBetaTeamSchedule.md)
Delete navigation property schedule for teams

### [Remove-MgBetaTeamScheduleOfferShiftRequest](Remove-MgBetaTeamScheduleOfferShiftRequest.md)
Delete navigation property offerShiftRequests for teams

### [Remove-MgBetaTeamScheduleOpenShift](Remove-MgBetaTeamScheduleOpenShift.md)
Delete navigation property openShifts for teams

### [Remove-MgBetaTeamScheduleOpenShiftChangeRequest](Remove-MgBetaTeamScheduleOpenShiftChangeRequest.md)
Delete navigation property openShiftChangeRequests for teams

### [Remove-MgBetaTeamScheduleSchedulingGroup](Remove-MgBetaTeamScheduleSchedulingGroup.md)
Delete navigation property schedulingGroups for teams

### [Remove-MgBetaTeamScheduleShift](Remove-MgBetaTeamScheduleShift.md)
Delete navigation property shifts for teams

### [Remove-MgBetaTeamScheduleSwapShiftChangeRequest](Remove-MgBetaTeamScheduleSwapShiftChangeRequest.md)
Delete navigation property swapShiftsChangeRequests for teams

### [Remove-MgBetaTeamScheduleTimeCard](Remove-MgBetaTeamScheduleTimeCard.md)
Delete navigation property timeCards for teams

### [Remove-MgBetaTeamScheduleTimeOff](Remove-MgBetaTeamScheduleTimeOff.md)
Delete navigation property timesOff for teams

### [Remove-MgBetaTeamScheduleTimeOffReason](Remove-MgBetaTeamScheduleTimeOffReason.md)
Delete navigation property timeOffReasons for teams

### [Remove-MgBetaTeamScheduleTimeOffRequest](Remove-MgBetaTeamScheduleTimeOffRequest.md)
Delete navigation property timeOffRequests for teams

### [Remove-MgBetaTeamTag](Remove-MgBetaTeamTag.md)
Delete navigation property tags for teams

### [Remove-MgBetaTeamTagMember](Remove-MgBetaTeamTagMember.md)
Delete navigation property members for teams

### [Remove-MgBetaTeamworkDeletedTeam](Remove-MgBetaTeamworkDeletedTeam.md)
Delete navigation property deletedTeams for teamwork

### [Remove-MgBetaTeamworkDeletedTeamChannel](Remove-MgBetaTeamworkDeletedTeamChannel.md)
Delete navigation property channels for teamwork

### [Remove-MgBetaTeamworkDeletedTeamChannelEmail](Remove-MgBetaTeamworkDeletedTeamChannelEmail.md)
Remove the email address of a channel.
You can remove an email address only if it was provisioned using the provisionEmail method or through the Microsoft Teams client.

### [Remove-MgBetaTeamworkDeletedTeamChannelMember](Remove-MgBetaTeamworkDeletedTeamChannelMember.md)
Delete navigation property members for teamwork

### [Remove-MgBetaTeamworkDeletedTeamChannelMessage](Remove-MgBetaTeamworkDeletedTeamChannelMessage.md)
Delete navigation property messages for teamwork

### [Remove-MgBetaTeamworkDeletedTeamChannelMessageHostedContent](Remove-MgBetaTeamworkDeletedTeamChannelMessageHostedContent.md)
Delete navigation property hostedContents for teamwork

### [Remove-MgBetaTeamworkDeletedTeamChannelMessageReply](Remove-MgBetaTeamworkDeletedTeamChannelMessageReply.md)
Delete navigation property replies for teamwork

### [Remove-MgBetaTeamworkDeletedTeamChannelMessageReplyHostedContent](Remove-MgBetaTeamworkDeletedTeamChannelMessageReplyHostedContent.md)
Delete navigation property hostedContents for teamwork

### [Remove-MgBetaTeamworkDeletedTeamChannelSharedWithTeam](Remove-MgBetaTeamworkDeletedTeamChannelSharedWithTeam.md)
Delete navigation property sharedWithTeams for teamwork

### [Remove-MgBetaTeamworkDeletedTeamChannelTab](Remove-MgBetaTeamworkDeletedTeamChannelTab.md)
Delete navigation property tabs for teamwork

### [Remove-MgBetaTeamworkDevice](Remove-MgBetaTeamworkDevice.md)
Delete navigation property devices for teamwork

### [Remove-MgBetaTeamworkDeviceActivity](Remove-MgBetaTeamworkDeviceActivity.md)
Delete navigation property activity for teamwork

### [Remove-MgBetaTeamworkDeviceConfiguration](Remove-MgBetaTeamworkDeviceConfiguration.md)
Delete navigation property configuration for teamwork

### [Remove-MgBetaTeamworkDeviceHealth](Remove-MgBetaTeamworkDeviceHealth.md)
Delete navigation property health for teamwork

### [Remove-MgBetaTeamworkDeviceOperation](Remove-MgBetaTeamworkDeviceOperation.md)
Delete navigation property operations for teamwork

### [Remove-MgBetaTeamworkTeamAppSetting](Remove-MgBetaTeamworkTeamAppSetting.md)
Delete navigation property teamsAppSettings for teamwork

### [Remove-MgBetaTeamworkTeamTemplate](Remove-MgBetaTeamworkTeamTemplate.md)
Delete navigation property teamTemplates for teamwork

### [Remove-MgBetaTeamworkTeamTemplateDefinition](Remove-MgBetaTeamworkTeamTemplateDefinition.md)
Delete navigation property definitions for teamwork

### [Remove-MgBetaTeamworkTeamTemplateDefinitionTeamDefinition](Remove-MgBetaTeamworkTeamTemplateDefinitionTeamDefinition.md)
Delete navigation property teamDefinition for teamwork

### [Remove-MgBetaTeamworkWorkforceIntegration](Remove-MgBetaTeamworkWorkforceIntegration.md)
Delete navigation property workforceIntegrations for teamwork

### [Remove-MgBetaUserChat](Remove-MgBetaUserChat.md)
Delete navigation property chats for users

### [Remove-MgBetaUserChatInstalledApp](Remove-MgBetaUserChatInstalledApp.md)
Delete navigation property installedApps for users

### [Remove-MgBetaUserChatLastMessagePreview](Remove-MgBetaUserChatLastMessagePreview.md)
Delete navigation property lastMessagePreview for users

### [Remove-MgBetaUserChatMember](Remove-MgBetaUserChatMember.md)
Delete navigation property members for users

### [Remove-MgBetaUserChatMessage](Remove-MgBetaUserChatMessage.md)
Delete navigation property messages for users

### [Remove-MgBetaUserChatMessageHostedContent](Remove-MgBetaUserChatMessageHostedContent.md)
Delete navigation property hostedContents for users

### [Remove-MgBetaUserChatMessageReply](Remove-MgBetaUserChatMessageReply.md)
Delete navigation property replies for users

### [Remove-MgBetaUserChatMessageReplyHostedContent](Remove-MgBetaUserChatMessageReplyHostedContent.md)
Delete navigation property hostedContents for users

### [Remove-MgBetaUserChatOperation](Remove-MgBetaUserChatOperation.md)
Delete navigation property operations for users

### [Remove-MgBetaUserChatPermissionGrant](Remove-MgBetaUserChatPermissionGrant.md)
Delete navigation property permissionGrants for users

### [Remove-MgBetaUserChatPinnedMessage](Remove-MgBetaUserChatPinnedMessage.md)
Delete navigation property pinnedMessages for users

### [Remove-MgBetaUserChatTab](Remove-MgBetaUserChatTab.md)
Delete navigation property tabs for users

### [Remove-MgBetaUserTeamwork](Remove-MgBetaUserTeamwork.md)
Delete navigation property teamwork for users

### [Remove-MgBetaUserTeamworkAssociatedTeam](Remove-MgBetaUserTeamworkAssociatedTeam.md)
Delete navigation property associatedTeams for users

### [Remove-MgBetaUserTeamworkInstalledApp](Remove-MgBetaUserTeamworkInstalledApp.md)
Delete navigation property installedApps for users

### [Restart-MgBetaTeamworkDevice](Restart-MgBetaTeamworkDevice.md)
Restart the specified Microsoft Teams-enabled device asynchronously.
A device is restarted after the async operation completes successfully, which might occur subsequent to a response from this API.

### [Send-MgBetaChatActivityNotification](Send-MgBetaChatActivityNotification.md)
Send an activity feed notification in scope of a chat.
For more details about sending notifications and the requirements for doing so, see sending Teams activity notifications.

### [Send-MgBetaTeamActivityNotification](Send-MgBetaTeamActivityNotification.md)
Send an activity feed notification in the scope of a team.
For more details about sending notifications and the requirements for doing so, see\nsending Teams activity notifications.

### [Send-MgBetaTeamworkActivityNotificationToRecipient](Send-MgBetaTeamworkActivityNotificationToRecipient.md)
Send activity feed notifications to multiple users, in bulk.
For more details about sending notifications and the requirements for doing so, see\nsending Teams activity notifications.

### [Set-MgBetaAppCatalogTeamAppDefinitionColorIconHostedContent](Set-MgBetaAppCatalogTeamAppDefinitionColorIconHostedContent.md)
Update media content for the navigation property hostedContent in appCatalogs

### [Set-MgBetaAppCatalogTeamAppDefinitionOutlineIconHostedContent](Set-MgBetaAppCatalogTeamAppDefinitionOutlineIconHostedContent.md)
Update media content for the navigation property hostedContent in appCatalogs

### [Set-MgBetaChatMessageReaction](Set-MgBetaChatMessageReaction.md)
Invoke action setReaction

### [Set-MgBetaChatMessageReplyReaction](Set-MgBetaChatMessageReplyReaction.md)
Invoke action setReaction

### [Set-MgBetaGroupTeamChannelFileFolderContent](Set-MgBetaGroupTeamChannelFileFolderContent.md)
The content stream, if the item represents a file.

### [Set-MgBetaGroupTeamPhotoContent](Set-MgBetaGroupTeamPhotoContent.md)
Update media content for the navigation property photo in groups

### [Set-MgBetaGroupTeamPrimaryChannelFileFolderContent](Set-MgBetaGroupTeamPrimaryChannelFileFolderContent.md)
The content stream, if the item represents a file.

### [Set-MgBetaGroupTeamSchedule](Set-MgBetaGroupTeamSchedule.md)
Update the navigation property schedule in groups

### [Set-MgBetaTeamChannelFileFolderContent](Set-MgBetaTeamChannelFileFolderContent.md)
The content stream, if the item represents a file.

### [Set-MgBetaTeamChannelMessageReaction](Set-MgBetaTeamChannelMessageReaction.md)
Invoke action setReaction

### [Set-MgBetaTeamChannelMessageReplyReaction](Set-MgBetaTeamChannelMessageReplyReaction.md)
Invoke action setReaction

### [Set-MgBetaTeamPhotoContent](Set-MgBetaTeamPhotoContent.md)
Update media content for the navigation property photo in teams

### [Set-MgBetaTeamPrimaryChannelFileFolderContent](Set-MgBetaTeamPrimaryChannelFileFolderContent.md)
The content stream, if the item represents a file.

### [Set-MgBetaTeamPrimaryChannelMessageReaction](Set-MgBetaTeamPrimaryChannelMessageReaction.md)
Invoke action setReaction

### [Set-MgBetaTeamPrimaryChannelMessageReplyReaction](Set-MgBetaTeamPrimaryChannelMessageReplyReaction.md)
Invoke action setReaction

### [Set-MgBetaTeamSchedule](Set-MgBetaTeamSchedule.md)
Update the navigation property schedule in teams

### [Set-MgBetaTeamworkDeletedTeamChannelFileFolderContent](Set-MgBetaTeamworkDeletedTeamChannelFileFolderContent.md)
The content stream, if the item represents a file.

### [Set-MgBetaTeamworkDeletedTeamChannelMessageReaction](Set-MgBetaTeamworkDeletedTeamChannelMessageReaction.md)
Invoke action setReaction

### [Set-MgBetaTeamworkDeletedTeamChannelMessageReplyReaction](Set-MgBetaTeamworkDeletedTeamChannelMessageReplyReaction.md)
Invoke action setReaction

### [Start-MgBetaTeamScheduleTimeCardBreak](Start-MgBetaTeamScheduleTimeCardBreak.md)
Start a break in a specific timeCard.

### [Start-MgBetaTeamworkDeviceDiagnostic](Start-MgBetaTeamworkDeviceDiagnostic.md)
Run and generate diagnostic logs for the specified Microsoft Teams-enabled device.
This API triggers a long-running operation used to generate logs for a device.

### [Stop-MgBetaTeamScheduleTimeCardBreak](Stop-MgBetaTeamScheduleTimeCardBreak.md)
End the open break in a specific timeCard.

### [Test-MgBetaChatPermissionGrantProperty](Test-MgBetaChatPermissionGrantProperty.md)
Validate that a Microsoft 365 group's display name or mail nickname complies with naming policies.
Clients can use this API to determine whether a display name or mail nickname is valid before trying to **create** a Microsoft 365 group.
For validating properties of an existing group, use the validateProperties function for groups.
The following validations are performed for the display name and mail nickname properties: \n1.
Validate the prefix and suffix naming policy\n2.
Validate the custom banned words policy\n3.
Validate the mail nickname is unique This API returns with the first failure encountered.
If one or more properties fail multiple validations, only the property with the first validation failure is returned.
However, you can validate both the mail nickname and the display name and receive a collection of validation errors if you are only validating the prefix and suffix naming policy.

### [Test-MgBetaTeamPermissionGrantProperty](Test-MgBetaTeamPermissionGrantProperty.md)
Validate that a Microsoft 365 group's display name or mail nickname complies with naming policies.
Clients can use this API to determine whether a display name or mail nickname is valid before trying to **create** a Microsoft 365 group.
For validating properties of an existing group, use the validateProperties function for groups.
The following validations are performed for the display name and mail nickname properties: \n1.
Validate the prefix and suffix naming policy\n2.
Validate the custom banned words policy\n3.
Validate the mail nickname is unique This API returns with the first failure encountered.
If one or more properties fail multiple validations, only the property with the first validation failure is returned.
However, you can validate both the mail nickname and the display name and receive a collection of validation errors if you are only validating the prefix and suffix naming policy.

### [Undo-MgBetaChatMessageReplySoftDelete](Undo-MgBetaChatMessageReplySoftDelete.md)
Undo soft deletion of a single message or a message reply in a channel or a chat.

### [Undo-MgBetaChatMessageSoftDelete](Undo-MgBetaChatMessageSoftDelete.md)
Undo soft deletion of a single message or a message reply in a channel or a chat.

### [Undo-MgBetaTeamChannelMessageReplySoftDelete](Undo-MgBetaTeamChannelMessageReplySoftDelete.md)
Undo soft deletion of a single message or a message reply in a channel or a chat.

### [Undo-MgBetaTeamChannelMessageSoftDelete](Undo-MgBetaTeamChannelMessageSoftDelete.md)
Undo soft deletion of a single message or a message reply in a channel or a chat.

### [Undo-MgBetaTeamPrimaryChannelMessageReplySoftDelete](Undo-MgBetaTeamPrimaryChannelMessageReplySoftDelete.md)
Undo soft deletion of a single message or a message reply in a channel or a chat.

### [Undo-MgBetaTeamPrimaryChannelMessageSoftDelete](Undo-MgBetaTeamPrimaryChannelMessageSoftDelete.md)
Undo soft deletion of a single message or a message reply in a channel or a chat.

### [Undo-MgBetaTeamworkDeletedTeamChannelMessageReplySoftDelete](Undo-MgBetaTeamworkDeletedTeamChannelMessageReplySoftDelete.md)
Undo soft deletion of a single message or a message reply in a channel or a chat.

### [Undo-MgBetaTeamworkDeletedTeamChannelMessageSoftDelete](Undo-MgBetaTeamworkDeletedTeamChannelMessageSoftDelete.md)
Undo soft deletion of a single message or a message reply in a channel or a chat.

### [Update-MgBetaAppCatalogTeamApp](Update-MgBetaAppCatalogTeamApp.md)
Update the navigation property teamsApps in appCatalogs

### [Update-MgBetaAppCatalogTeamAppDefinition](Update-MgBetaAppCatalogTeamAppDefinition.md)
Update the navigation property appDefinitions in appCatalogs

### [Update-MgBetaAppCatalogTeamAppDefinitionBot](Update-MgBetaAppCatalogTeamAppDefinitionBot.md)
Update the navigation property bot in appCatalogs

### [Update-MgBetaAppCatalogTeamAppDefinitionColorIcon](Update-MgBetaAppCatalogTeamAppDefinitionColorIcon.md)
Update the navigation property colorIcon in appCatalogs

### [Update-MgBetaAppCatalogTeamAppDefinitionColorIconHostedContent](Update-MgBetaAppCatalogTeamAppDefinitionColorIconHostedContent.md)
Update the navigation property hostedContent in appCatalogs

### [Update-MgBetaAppCatalogTeamAppDefinitionOutlineIcon](Update-MgBetaAppCatalogTeamAppDefinitionOutlineIcon.md)
Update the navigation property outlineIcon in appCatalogs

### [Update-MgBetaAppCatalogTeamAppDefinitionOutlineIconHostedContent](Update-MgBetaAppCatalogTeamAppDefinitionOutlineIconHostedContent.md)
Update the navigation property hostedContent in appCatalogs

### [Update-MgBetaChat](Update-MgBetaChat.md)
Update the properties of a chat object.

### [Update-MgBetaChatInstalledApp](Update-MgBetaChatInstalledApp.md)
Upgrade an app installation within a chat.

### [Update-MgBetaChatLastMessagePreview](Update-MgBetaChatLastMessagePreview.md)
Update the navigation property lastMessagePreview in chats

### [Update-MgBetaChatMember](Update-MgBetaChatMember.md)
Update the navigation property members in chats

### [Update-MgBetaChatMessage](Update-MgBetaChatMessage.md)
Update the navigation property messages in chats

### [Update-MgBetaChatMessageReply](Update-MgBetaChatMessageReply.md)
Update the navigation property replies in chats

### [Update-MgBetaChatMessageReplyHostedContent](Update-MgBetaChatMessageReplyHostedContent.md)
Update the navigation property hostedContents in chats

### [Update-MgBetaChatOperation](Update-MgBetaChatOperation.md)
Update the navigation property operations in chats

### [Update-MgBetaChatPermissionGrant](Update-MgBetaChatPermissionGrant.md)
Update the navigation property permissionGrants in chats

### [Update-MgBetaChatPinnedMessage](Update-MgBetaChatPinnedMessage.md)
Update the navigation property pinnedMessages in chats

### [Update-MgBetaChatTab](Update-MgBetaChatTab.md)
Update the navigation property tabs in chats

### [Update-MgBetaGroupTeam](Update-MgBetaGroupTeam.md)
Create a new team from a group.
In order to create a team, the group must have a least one owner.
If the group was created less than 15 minutes ago, it's possible for the Create team call to fail with a 404 error code due to replication delays.\nThe recommended pattern is to retry the Create team call three times, with a 10 second delay between calls.

### [Update-MgBetaGroupTeamChannel](Update-MgBetaGroupTeamChannel.md)
Update the navigation property channels in groups

### [Update-MgBetaGroupTeamChannelMember](Update-MgBetaGroupTeamChannelMember.md)
Update the navigation property members in groups

### [Update-MgBetaGroupTeamChannelMessage](Update-MgBetaGroupTeamChannelMessage.md)
Update the navigation property messages in groups

### [Update-MgBetaGroupTeamChannelMessageHostedContent](Update-MgBetaGroupTeamChannelMessageHostedContent.md)
Update the navigation property hostedContents in groups

### [Update-MgBetaGroupTeamChannelMessageReply](Update-MgBetaGroupTeamChannelMessageReply.md)
Update the navigation property replies in groups

### [Update-MgBetaGroupTeamChannelMessageReplyHostedContent](Update-MgBetaGroupTeamChannelMessageReplyHostedContent.md)
Update the navigation property hostedContents in groups

### [Update-MgBetaGroupTeamChannelSharedWithTeam](Update-MgBetaGroupTeamChannelSharedWithTeam.md)
Update the navigation property sharedWithTeams in groups

### [Update-MgBetaGroupTeamChannelTab](Update-MgBetaGroupTeamChannelTab.md)
Update the navigation property tabs in groups

### [Update-MgBetaGroupTeamMember](Update-MgBetaGroupTeamMember.md)
Update the navigation property members in groups

### [Update-MgBetaGroupTeamOperation](Update-MgBetaGroupTeamOperation.md)
Update the navigation property operations in groups

### [Update-MgBetaGroupTeamPermissionGrant](Update-MgBetaGroupTeamPermissionGrant.md)
Update the navigation property permissionGrants in groups

### [Update-MgBetaGroupTeamPhoto](Update-MgBetaGroupTeamPhoto.md)
Update the navigation property photo in groups

### [Update-MgBetaGroupTeamPrimaryChannel](Update-MgBetaGroupTeamPrimaryChannel.md)
Update the navigation property primaryChannel in groups

### [Update-MgBetaGroupTeamPrimaryChannelMember](Update-MgBetaGroupTeamPrimaryChannelMember.md)
Update the navigation property members in groups

### [Update-MgBetaGroupTeamPrimaryChannelMessage](Update-MgBetaGroupTeamPrimaryChannelMessage.md)
Update the navigation property messages in groups

### [Update-MgBetaGroupTeamPrimaryChannelMessageHostedContent](Update-MgBetaGroupTeamPrimaryChannelMessageHostedContent.md)
Update the navigation property hostedContents in groups

### [Update-MgBetaGroupTeamPrimaryChannelMessageReply](Update-MgBetaGroupTeamPrimaryChannelMessageReply.md)
Update the navigation property replies in groups

### [Update-MgBetaGroupTeamPrimaryChannelMessageReplyHostedContent](Update-MgBetaGroupTeamPrimaryChannelMessageReplyHostedContent.md)
Update the navigation property hostedContents in groups

### [Update-MgBetaGroupTeamPrimaryChannelSharedWithTeam](Update-MgBetaGroupTeamPrimaryChannelSharedWithTeam.md)
Update the navigation property sharedWithTeams in groups

### [Update-MgBetaGroupTeamPrimaryChannelTab](Update-MgBetaGroupTeamPrimaryChannelTab.md)
Update the navigation property tabs in groups

### [Update-MgBetaGroupTeamScheduleOfferShiftRequest](Update-MgBetaGroupTeamScheduleOfferShiftRequest.md)
Update the navigation property offerShiftRequests in groups

### [Update-MgBetaGroupTeamScheduleOpenShift](Update-MgBetaGroupTeamScheduleOpenShift.md)
Update the navigation property openShifts in groups

### [Update-MgBetaGroupTeamScheduleOpenShiftChangeRequest](Update-MgBetaGroupTeamScheduleOpenShiftChangeRequest.md)
Update the navigation property openShiftChangeRequests in groups

### [Update-MgBetaGroupTeamScheduleSchedulingGroup](Update-MgBetaGroupTeamScheduleSchedulingGroup.md)
Update the navigation property schedulingGroups in groups

### [Update-MgBetaGroupTeamScheduleShift](Update-MgBetaGroupTeamScheduleShift.md)
Update the navigation property shifts in groups

### [Update-MgBetaGroupTeamScheduleSwapShiftChangeRequest](Update-MgBetaGroupTeamScheduleSwapShiftChangeRequest.md)
Update the navigation property swapShiftsChangeRequests in groups

### [Update-MgBetaGroupTeamScheduleTimeCard](Update-MgBetaGroupTeamScheduleTimeCard.md)
Update the navigation property timeCards in groups

### [Update-MgBetaGroupTeamScheduleTimeOff](Update-MgBetaGroupTeamScheduleTimeOff.md)
Update the navigation property timesOff in groups

### [Update-MgBetaGroupTeamScheduleTimeOffReason](Update-MgBetaGroupTeamScheduleTimeOffReason.md)
Update the navigation property timeOffReasons in groups

### [Update-MgBetaGroupTeamScheduleTimeOffRequest](Update-MgBetaGroupTeamScheduleTimeOffRequest.md)
Update the navigation property timeOffRequests in groups

### [Update-MgBetaGroupTeamTag](Update-MgBetaGroupTeamTag.md)
Update the navigation property tags in groups

### [Update-MgBetaGroupTeamTagMember](Update-MgBetaGroupTeamTagMember.md)
Update the navigation property members in groups

### [Update-MgBetaTeam](Update-MgBetaTeam.md)
Update the properties of the specified team.

### [Update-MgBetaTeamChannel](Update-MgBetaTeamChannel.md)
Update the navigation property channels in teams

### [Update-MgBetaTeamChannelMember](Update-MgBetaTeamChannelMember.md)
Update the navigation property members in teams

### [Update-MgBetaTeamChannelMessage](Update-MgBetaTeamChannelMessage.md)
Update the navigation property messages in teams

### [Update-MgBetaTeamChannelMessageReply](Update-MgBetaTeamChannelMessageReply.md)
Update the navigation property replies in teams

### [Update-MgBetaTeamChannelMessageReplyHostedContent](Update-MgBetaTeamChannelMessageReplyHostedContent.md)
Update the navigation property hostedContents in teams

### [Update-MgBetaTeamChannelSharedWithTeam](Update-MgBetaTeamChannelSharedWithTeam.md)
Update the navigation property sharedWithTeams in teams

### [Update-MgBetaTeamChannelTab](Update-MgBetaTeamChannelTab.md)
Update the navigation property tabs in teams

### [Update-MgBetaTeamInstalledApp](Update-MgBetaTeamInstalledApp.md)
Upgrade an app installation within a chat.

### [Update-MgBetaTeamMember](Update-MgBetaTeamMember.md)
Update the navigation property members in teams

### [Update-MgBetaTeamOperation](Update-MgBetaTeamOperation.md)
Update the navigation property operations in teams

### [Update-MgBetaTeamPermissionGrant](Update-MgBetaTeamPermissionGrant.md)
Update the navigation property permissionGrants in teams

### [Update-MgBetaTeamPhoto](Update-MgBetaTeamPhoto.md)
Update the navigation property photo in teams

### [Update-MgBetaTeamPrimaryChannel](Update-MgBetaTeamPrimaryChannel.md)
Update the navigation property primaryChannel in teams

### [Update-MgBetaTeamPrimaryChannelMember](Update-MgBetaTeamPrimaryChannelMember.md)
Update the navigation property members in teams

### [Update-MgBetaTeamPrimaryChannelMessage](Update-MgBetaTeamPrimaryChannelMessage.md)
Update the navigation property messages in teams

### [Update-MgBetaTeamPrimaryChannelMessageReply](Update-MgBetaTeamPrimaryChannelMessageReply.md)
Update the navigation property replies in teams

### [Update-MgBetaTeamPrimaryChannelMessageReplyHostedContent](Update-MgBetaTeamPrimaryChannelMessageReplyHostedContent.md)
Update the navigation property hostedContents in teams

### [Update-MgBetaTeamPrimaryChannelSharedWithTeam](Update-MgBetaTeamPrimaryChannelSharedWithTeam.md)
Update the navigation property sharedWithTeams in teams

### [Update-MgBetaTeamPrimaryChannelTab](Update-MgBetaTeamPrimaryChannelTab.md)
Update the navigation property tabs in teams

### [Update-MgBetaTeamScheduleOfferShiftRequest](Update-MgBetaTeamScheduleOfferShiftRequest.md)
Update the navigation property offerShiftRequests in teams

### [Update-MgBetaTeamScheduleOpenShift](Update-MgBetaTeamScheduleOpenShift.md)
Update the navigation property openShifts in teams

### [Update-MgBetaTeamScheduleOpenShiftChangeRequest](Update-MgBetaTeamScheduleOpenShiftChangeRequest.md)
Update the navigation property openShiftChangeRequests in teams

### [Update-MgBetaTeamScheduleSchedulingGroup](Update-MgBetaTeamScheduleSchedulingGroup.md)
Update the navigation property schedulingGroups in teams

### [Update-MgBetaTeamScheduleShift](Update-MgBetaTeamScheduleShift.md)
Update the navigation property shifts in teams

### [Update-MgBetaTeamScheduleSwapShiftChangeRequest](Update-MgBetaTeamScheduleSwapShiftChangeRequest.md)
Update the navigation property swapShiftsChangeRequests in teams

### [Update-MgBetaTeamScheduleTimeCard](Update-MgBetaTeamScheduleTimeCard.md)
Update the navigation property timeCards in teams

### [Update-MgBetaTeamScheduleTimeOff](Update-MgBetaTeamScheduleTimeOff.md)
Update the navigation property timesOff in teams

### [Update-MgBetaTeamScheduleTimeOffReason](Update-MgBetaTeamScheduleTimeOffReason.md)
Update the navigation property timeOffReasons in teams

### [Update-MgBetaTeamScheduleTimeOffRequest](Update-MgBetaTeamScheduleTimeOffRequest.md)
Update the navigation property timeOffRequests in teams

### [Update-MgBetaTeamTag](Update-MgBetaTeamTag.md)
Update the navigation property tags in teams

### [Update-MgBetaTeamTagMember](Update-MgBetaTeamTagMember.md)
Update the navigation property members in teams

### [Update-MgBetaTeamwork](Update-MgBetaTeamwork.md)
Update teamwork

### [Update-MgBetaTeamworkDeletedTeam](Update-MgBetaTeamworkDeletedTeam.md)
Update the navigation property deletedTeams in teamwork

### [Update-MgBetaTeamworkDeletedTeamChannel](Update-MgBetaTeamworkDeletedTeamChannel.md)
Update the navigation property channels in teamwork

### [Update-MgBetaTeamworkDeletedTeamChannelMember](Update-MgBetaTeamworkDeletedTeamChannelMember.md)
Update the navigation property members in teamwork

### [Update-MgBetaTeamworkDeletedTeamChannelMessage](Update-MgBetaTeamworkDeletedTeamChannelMessage.md)
Update the navigation property messages in teamwork

### [Update-MgBetaTeamworkDeletedTeamChannelMessageHostedContent](Update-MgBetaTeamworkDeletedTeamChannelMessageHostedContent.md)
Update the navigation property hostedContents in teamwork

### [Update-MgBetaTeamworkDeletedTeamChannelMessageReply](Update-MgBetaTeamworkDeletedTeamChannelMessageReply.md)
Update the navigation property replies in teamwork

### [Update-MgBetaTeamworkDeletedTeamChannelMessageReplyHostedContent](Update-MgBetaTeamworkDeletedTeamChannelMessageReplyHostedContent.md)
Update the navigation property hostedContents in teamwork

### [Update-MgBetaTeamworkDeletedTeamChannelSharedWithTeam](Update-MgBetaTeamworkDeletedTeamChannelSharedWithTeam.md)
Update the navigation property sharedWithTeams in teamwork

### [Update-MgBetaTeamworkDeletedTeamChannelTab](Update-MgBetaTeamworkDeletedTeamChannelTab.md)
Update the navigation property tabs in teamwork

### [Update-MgBetaTeamworkDevice](Update-MgBetaTeamworkDevice.md)
Update the navigation property devices in teamwork

### [Update-MgBetaTeamworkDeviceActivity](Update-MgBetaTeamworkDeviceActivity.md)
Update the navigation property activity in teamwork

### [Update-MgBetaTeamworkDeviceConfiguration](Update-MgBetaTeamworkDeviceConfiguration.md)
Update the navigation property configuration in teamwork

### [Update-MgBetaTeamworkDeviceHealth](Update-MgBetaTeamworkDeviceHealth.md)
Update the navigation property health in teamwork

### [Update-MgBetaTeamworkDeviceOperation](Update-MgBetaTeamworkDeviceOperation.md)
Update the navigation property operations in teamwork

### [Update-MgBetaTeamworkDeviceSoftware](Update-MgBetaTeamworkDeviceSoftware.md)
Update the software for a Microsoft Teams-enabled device.
This API triggers a long-running operation.

### [Update-MgBetaTeamworkTeamAppSetting](Update-MgBetaTeamworkTeamAppSetting.md)
Update the properties of a teamsAppSettings object.

### [Update-MgBetaTeamworkTeamTemplate](Update-MgBetaTeamworkTeamTemplate.md)
Update the navigation property teamTemplates in teamwork

### [Update-MgBetaTeamworkTeamTemplateDefinition](Update-MgBetaTeamworkTeamTemplateDefinition.md)
Update the navigation property definitions in teamwork

### [Update-MgBetaTeamworkTeamTemplateDefinitionTeamDefinition](Update-MgBetaTeamworkTeamTemplateDefinitionTeamDefinition.md)
Update the navigation property teamDefinition in teamwork

### [Update-MgBetaTeamworkWorkforceIntegration](Update-MgBetaTeamworkWorkforceIntegration.md)
Update the navigation property workforceIntegrations in teamwork

### [Update-MgBetaUserChat](Update-MgBetaUserChat.md)
Update the navigation property chats in users

### [Update-MgBetaUserChatLastMessagePreview](Update-MgBetaUserChatLastMessagePreview.md)
Update the navigation property lastMessagePreview in users

### [Update-MgBetaUserChatMember](Update-MgBetaUserChatMember.md)
Update the navigation property members in users

### [Update-MgBetaUserChatMessage](Update-MgBetaUserChatMessage.md)
Update the navigation property messages in users

### [Update-MgBetaUserChatMessageHostedContent](Update-MgBetaUserChatMessageHostedContent.md)
Update the navigation property hostedContents in users

### [Update-MgBetaUserChatMessageReply](Update-MgBetaUserChatMessageReply.md)
Update the navigation property replies in users

### [Update-MgBetaUserChatMessageReplyHostedContent](Update-MgBetaUserChatMessageReplyHostedContent.md)
Update the navigation property hostedContents in users

### [Update-MgBetaUserChatOperation](Update-MgBetaUserChatOperation.md)
Update the navigation property operations in users

### [Update-MgBetaUserChatPermissionGrant](Update-MgBetaUserChatPermissionGrant.md)
Update the navigation property permissionGrants in users

### [Update-MgBetaUserChatPinnedMessage](Update-MgBetaUserChatPinnedMessage.md)
Update the navigation property pinnedMessages in users

### [Update-MgBetaUserChatTab](Update-MgBetaUserChatTab.md)
Update the navigation property tabs in users

### [Update-MgBetaUserTeamwork](Update-MgBetaUserTeamwork.md)
Update the navigation property teamwork in users

### [Update-MgBetaUserTeamworkAssociatedTeam](Update-MgBetaUserTeamworkAssociatedTeam.md)
Update the navigation property associatedTeams in users

