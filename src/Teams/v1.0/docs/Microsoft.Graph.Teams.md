---
Module Name: Microsoft.Graph.Teams
Module Guid: 34b900c5-0e15-4846-b885-c530ee194811
Download Help Link: https://learn.microsoft.com/powershell/module/microsoft.graph.teams
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
Complete the message migration process by removing migration mode from a channel in a team.
Migration mode is a special state that prevents certain operations, like sending messages and adding members, during the data migration process.
After a completeMigration request is made, you can't import additional messages into the team.
You can add members to the team after the request returns a successful response.

### [Complete-MgTeamMigration](Complete-MgTeamMigration.md)
Complete the message migration process by removing migration mode from a team.
Migration mode is a special state where certain operations are barred, like message POST and membership operations during the data migration process.
After a completeMigration request is made, you can't import additional messages into the team.
You can add members to the team after the request returns a successful response.

### [Complete-MgTeamPrimaryChannelMigration](Complete-MgTeamPrimaryChannelMigration.md)
Complete the message migration process by removing migration mode from a channel in a team.
Migration mode is a special state that prevents certain operations, like sending messages and adding members, during the data migration process.
After a completeMigration request is made, you can't import additional messages into the team.
You can add members to the team after the request returns a successful response.

### [Complete-MgTeamworkDeletedTeamChannelMigration](Complete-MgTeamworkDeletedTeamChannelMigration.md)
Complete the message migration process by removing migration mode from a channel in a team.
Migration mode is a special state that prevents certain operations, like sending messages and adding members, during the data migration process.
After a completeMigration request is made, you can't import additional messages into the team.
You can add members to the team after the request returns a successful response.

### [Copy-MgTeam](Copy-MgTeam.md)
Create a copy of a team.
This operation also creates a copy of the corresponding group.\nYou can specify which parts of the team to clone: When tabs are cloned, they aren't configured.
The tabs are displayed on the tab bar in Microsoft Teams, and the first time a user opens them, they must go through the configuration screen.
\nIf the user who opens the tab doesn't have permission to configure apps, they'll see a message that says that the tab isn't configured.
Cloning is a long-running operation.
After the POST clone returns, you need to GET the operation returned by the Location: header to see if it's running, succeeded, or failed.
You should continue to GET until the status isn't running.
The recommended delay between GETs is 5 seconds.

### [Get-MgAllGroupTeamChannel](Get-MgAllGroupTeamChannel.md)
List of channels either hosted in or shared with the team (incoming channels).

### [Get-MgAllGroupTeamChannelCount](Get-MgAllGroupTeamChannelCount.md)
Get the number of the resource

### [Get-MgAllTeamChannel](Get-MgAllTeamChannel.md)
List of channels either hosted in or shared with the team (incoming channels).

### [Get-MgAllTeamChannelCount](Get-MgAllTeamChannelCount.md)
Get the number of the resource

### [Get-MgAllTeamMessage](Get-MgAllTeamMessage.md)
Invoke function getAllMessages

### [Get-MgAllTeamworkDeletedTeamMessage](Get-MgAllTeamworkDeletedTeamMessage.md)
Invoke function getAllMessages

### [Get-MgAppCatalogTeamApp](Get-MgAppCatalogTeamApp.md)
Get teamsApps from appCatalogs

### [Get-MgAppCatalogTeamAppCount](Get-MgAppCatalogTeamAppCount.md)
Get the number of the resource

### [Get-MgAppCatalogTeamAppDefinition](Get-MgAppCatalogTeamAppDefinition.md)
The details for each version of the app.

### [Get-MgAppCatalogTeamAppDefinitionBot](Get-MgAppCatalogTeamAppDefinitionBot.md)
Get the bot associated with a specific definition of the  TeamsApp.

### [Get-MgAppCatalogTeamAppDefinitionCount](Get-MgAppCatalogTeamAppDefinitionCount.md)
Get the number of the resource

### [Get-MgChat](Get-MgChat.md)
Retrieve a single chat (without its messages).
This method supports federation.
To access a chat, at least one chat member must belong to the tenant the request initiated from.

### [Get-MgChatCount](Get-MgChatCount.md)
Get the number of the resource

### [Get-MgChatInstalledApp](Get-MgChatInstalledApp.md)
Get an app installed in a chat.

### [Get-MgChatInstalledAppCount](Get-MgChatInstalledAppCount.md)
Get the number of the resource

### [Get-MgChatInstalledAppTeamApp](Get-MgChatInstalledAppTeamApp.md)
The app that is installed.

### [Get-MgChatInstalledAppTeamAppDefinition](Get-MgChatInstalledAppTeamAppDefinition.md)
The details of this version of the app.

### [Get-MgChatLastMessagePreview](Get-MgChatLastMessagePreview.md)
Preview of the last message sent in the chat.
Null if no messages have been sent in the chat.
Currently, only the list chats operation supports this property.

### [Get-MgChatMember](Get-MgChatMember.md)
Retrieve a conversationMember from a chat.

### [Get-MgChatMemberCount](Get-MgChatMemberCount.md)
Get the number of the resource

### [Get-MgChatMessage](Get-MgChatMessage.md)
Retrieve a single message or a message reply in a channel or a chat.

### [Get-MgChatMessageCount](Get-MgChatMessageCount.md)
Get the number of the resource

### [Get-MgChatMessageDelta](Get-MgChatMessageDelta.md)
Invoke function delta

### [Get-MgChatMessageHostedContent](Get-MgChatMessageHostedContent.md)
Retrieve the properties and relationships of chatMessageHostedContent object.

### [Get-MgChatMessageHostedContentCount](Get-MgChatMessageHostedContentCount.md)
Get the number of the resource

### [Get-MgChatMessageReply](Get-MgChatMessageReply.md)
Retrieve a single message or a message reply in a channel or a chat.

### [Get-MgChatMessageReplyCount](Get-MgChatMessageReplyCount.md)
Get the number of the resource

### [Get-MgChatMessageReplyDelta](Get-MgChatMessageReplyDelta.md)
Invoke function delta

### [Get-MgChatMessageReplyHostedContent](Get-MgChatMessageReplyHostedContent.md)
Retrieve the properties and relationships of chatMessageHostedContent object.

### [Get-MgChatMessageReplyHostedContentCount](Get-MgChatMessageReplyHostedContentCount.md)
Get the number of the resource

### [Get-MgChatPermissionGrant](Get-MgChatPermissionGrant.md)
A collection of permissions granted to apps for the chat.

### [Get-MgChatPermissionGrantCount](Get-MgChatPermissionGrantCount.md)
Get the number of the resource

### [Get-MgChatPinnedMessage](Get-MgChatPinnedMessage.md)
A collection of all the pinned messages in the chat.
Nullable.

### [Get-MgChatPinnedMessageCount](Get-MgChatPinnedMessageCount.md)
Get the number of the resource

### [Get-MgChatTab](Get-MgChatTab.md)
Retrieve the properties and relationships of the specified tab in a chat.

### [Get-MgChatTabCount](Get-MgChatTabCount.md)
Get the number of the resource

### [Get-MgChatTabTeamApp](Get-MgChatTabTeamApp.md)
The application that is linked to the tab.
This can't be changed after tab creation.

### [Get-MgGroupTeam](Get-MgGroupTeam.md)
The team associated with this group.

### [Get-MgGroupTeamChannel](Get-MgGroupTeamChannel.md)
Retrieve the properties and relationships of a channel.
This method supports federation.
Only a user who is a member of the shared channel can retrieve channel information.

### [Get-MgGroupTeamChannelCount](Get-MgGroupTeamChannelCount.md)
Get the number of the resource

### [Get-MgGroupTeamChannelFileFolder](Get-MgGroupTeamChannelFileFolder.md)
Get the metadata for the location where the files of a channel are stored.

### [Get-MgGroupTeamChannelFileFolderContent](Get-MgGroupTeamChannelFileFolderContent.md)
The content stream, if the item represents a file.

### [Get-MgGroupTeamChannelMember](Get-MgGroupTeamChannelMember.md)
Get a conversationMember from a channel.

### [Get-MgGroupTeamChannelMemberCount](Get-MgGroupTeamChannelMemberCount.md)
Get the number of the resource

### [Get-MgGroupTeamChannelMessage](Get-MgGroupTeamChannelMessage.md)
Retrieve a single message or a message reply in a channel or a chat.

### [Get-MgGroupTeamChannelMessageCount](Get-MgGroupTeamChannelMessageCount.md)
Get the number of the resource

### [Get-MgGroupTeamChannelMessageHostedContent](Get-MgGroupTeamChannelMessageHostedContent.md)
Retrieve the properties and relationships of chatMessageHostedContent object.

### [Get-MgGroupTeamChannelMessageHostedContentCount](Get-MgGroupTeamChannelMessageHostedContentCount.md)
Get the number of the resource

### [Get-MgGroupTeamChannelMessageReply](Get-MgGroupTeamChannelMessageReply.md)
Retrieve a single message or a message reply in a channel or a chat.

### [Get-MgGroupTeamChannelMessageReplyCount](Get-MgGroupTeamChannelMessageReplyCount.md)
Get the number of the resource

### [Get-MgGroupTeamChannelMessageReplyHostedContent](Get-MgGroupTeamChannelMessageReplyHostedContent.md)
Retrieve the properties and relationships of chatMessageHostedContent object.

### [Get-MgGroupTeamChannelMessageReplyHostedContentCount](Get-MgGroupTeamChannelMessageReplyHostedContentCount.md)
Get the number of the resource

### [Get-MgGroupTeamChannelSharedWithTeam](Get-MgGroupTeamChannelSharedWithTeam.md)
Get a team that has been shared with a specified channel.
This operation is allowed only for channels with a membershipType value of shared.

### [Get-MgGroupTeamChannelSharedWithTeamAllowedMember](Get-MgGroupTeamChannelSharedWithTeamAllowedMember.md)
A collection of team members who have access to the shared channel.

### [Get-MgGroupTeamChannelSharedWithTeamAllowedMemberCount](Get-MgGroupTeamChannelSharedWithTeamAllowedMemberCount.md)
Get the number of the resource

### [Get-MgGroupTeamChannelSharedWithTeamCount](Get-MgGroupTeamChannelSharedWithTeamCount.md)
Get the number of the resource

### [Get-MgGroupTeamChannelTab](Get-MgGroupTeamChannelTab.md)
Retrieve the properties and relationships of the specified tab in a channel within a team.

### [Get-MgGroupTeamChannelTabCount](Get-MgGroupTeamChannelTabCount.md)
Get the number of the resource

### [Get-MgGroupTeamChannelTabTeamApp](Get-MgGroupTeamChannelTabTeamApp.md)
The application that is linked to the tab.
This can't be changed after tab creation.

### [Get-MgGroupTeamGroup](Get-MgGroupTeamGroup.md)
Get group from groups

### [Get-MgGroupTeamGroupServiceProvisioningError](Get-MgGroupTeamGroupServiceProvisioningError.md)
Errors published by a federated service describing a non-transient, service-specific error regarding the properties or link from a group object .
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgGroupTeamGroupServiceProvisioningErrorCount](Get-MgGroupTeamGroupServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgGroupTeamIncomingChannel](Get-MgGroupTeamIncomingChannel.md)
List of channels shared with the team.

### [Get-MgGroupTeamIncomingChannelCount](Get-MgGroupTeamIncomingChannelCount.md)
Get the number of the resource

### [Get-MgGroupTeamInstalledApp](Get-MgGroupTeamInstalledApp.md)
Retrieve the app installed in the specified team.

### [Get-MgGroupTeamInstalledAppCount](Get-MgGroupTeamInstalledAppCount.md)
Get the number of the resource

### [Get-MgGroupTeamInstalledAppTeamApp](Get-MgGroupTeamInstalledAppTeamApp.md)
The app that is installed.

### [Get-MgGroupTeamInstalledAppTeamAppDefinition](Get-MgGroupTeamInstalledAppTeamAppDefinition.md)
The details of this version of the app.

### [Get-MgGroupTeamMember](Get-MgGroupTeamMember.md)
Get a conversationMember from a team.

### [Get-MgGroupTeamMemberCount](Get-MgGroupTeamMemberCount.md)
Get the number of the resource

### [Get-MgGroupTeamOperation](Get-MgGroupTeamOperation.md)
The async operations that ran or are running on this team.

### [Get-MgGroupTeamOperationCount](Get-MgGroupTeamOperationCount.md)
Get the number of the resource

### [Get-MgGroupTeamPermissionGrant](Get-MgGroupTeamPermissionGrant.md)
A collection of permissions granted to apps to access the team.

### [Get-MgGroupTeamPermissionGrantCount](Get-MgGroupTeamPermissionGrantCount.md)
Get the number of the resource

### [Get-MgGroupTeamPhoto](Get-MgGroupTeamPhoto.md)
Get the specified profilePhoto or its metadata (profilePhoto properties).
The supported sizes of HD photos on Microsoft 365 are as follows: 48x48, 64x64, 96x96, 120x120, 240x240,\n360x360, 432x432, 504x504, and 648x648.
Photos can be any dimension if they're stored in Microsoft Entra ID.
You can get the metadata of the largest available photo or specify a size to get the metadata for that photo size.\nIf the size you request is unavailable, you can still get a smaller size that the user has uploaded and made available.\nFor example, if the user uploads a photo that is 504x504 pixels, all but the 648x648 size of the photo is available for download.

### [Get-MgGroupTeamPhotoContent](Get-MgGroupTeamPhotoContent.md)
Get media content for the navigation property photo from groups

### [Get-MgGroupTeamPrimaryChannel](Get-MgGroupTeamPrimaryChannel.md)
Get the default channel, General, of a team.

### [Get-MgGroupTeamPrimaryChannelFileFolder](Get-MgGroupTeamPrimaryChannelFileFolder.md)
Get the metadata for the location where the files of a channel are stored.

### [Get-MgGroupTeamPrimaryChannelFileFolderContent](Get-MgGroupTeamPrimaryChannelFileFolderContent.md)
The content stream, if the item represents a file.

### [Get-MgGroupTeamPrimaryChannelMember](Get-MgGroupTeamPrimaryChannelMember.md)
Get a conversationMember from a channel.

### [Get-MgGroupTeamPrimaryChannelMemberCount](Get-MgGroupTeamPrimaryChannelMemberCount.md)
Get the number of the resource

### [Get-MgGroupTeamPrimaryChannelMessage](Get-MgGroupTeamPrimaryChannelMessage.md)
Retrieve a single message or a message reply in a channel or a chat.

### [Get-MgGroupTeamPrimaryChannelMessageCount](Get-MgGroupTeamPrimaryChannelMessageCount.md)
Get the number of the resource

### [Get-MgGroupTeamPrimaryChannelMessageHostedContent](Get-MgGroupTeamPrimaryChannelMessageHostedContent.md)
Retrieve the properties and relationships of chatMessageHostedContent object.

### [Get-MgGroupTeamPrimaryChannelMessageHostedContentCount](Get-MgGroupTeamPrimaryChannelMessageHostedContentCount.md)
Get the number of the resource

### [Get-MgGroupTeamPrimaryChannelMessageReply](Get-MgGroupTeamPrimaryChannelMessageReply.md)
Retrieve a single message or a message reply in a channel or a chat.

### [Get-MgGroupTeamPrimaryChannelMessageReplyCount](Get-MgGroupTeamPrimaryChannelMessageReplyCount.md)
Get the number of the resource

### [Get-MgGroupTeamPrimaryChannelMessageReplyHostedContent](Get-MgGroupTeamPrimaryChannelMessageReplyHostedContent.md)
Retrieve the properties and relationships of chatMessageHostedContent object.

### [Get-MgGroupTeamPrimaryChannelMessageReplyHostedContentCount](Get-MgGroupTeamPrimaryChannelMessageReplyHostedContentCount.md)
Get the number of the resource

### [Get-MgGroupTeamPrimaryChannelSharedWithTeam](Get-MgGroupTeamPrimaryChannelSharedWithTeam.md)
Get a team that has been shared with a specified channel.
This operation is allowed only for channels with a membershipType value of shared.

### [Get-MgGroupTeamPrimaryChannelSharedWithTeamAllowedMember](Get-MgGroupTeamPrimaryChannelSharedWithTeamAllowedMember.md)
A collection of team members who have access to the shared channel.

### [Get-MgGroupTeamPrimaryChannelSharedWithTeamAllowedMemberCount](Get-MgGroupTeamPrimaryChannelSharedWithTeamAllowedMemberCount.md)
Get the number of the resource

### [Get-MgGroupTeamPrimaryChannelSharedWithTeamCount](Get-MgGroupTeamPrimaryChannelSharedWithTeamCount.md)
Get the number of the resource

### [Get-MgGroupTeamPrimaryChannelTab](Get-MgGroupTeamPrimaryChannelTab.md)
Retrieve the properties and relationships of the specified tab in a channel within a team.

### [Get-MgGroupTeamPrimaryChannelTabCount](Get-MgGroupTeamPrimaryChannelTabCount.md)
Get the number of the resource

### [Get-MgGroupTeamPrimaryChannelTabTeamApp](Get-MgGroupTeamPrimaryChannelTabTeamApp.md)
The application that is linked to the tab.
This can't be changed after tab creation.

### [Get-MgGroupTeamSchedule](Get-MgGroupTeamSchedule.md)
Retrieve the properties and relationships of a schedule object.
The schedule creation process conforms to the One API guideline for resource based long running operations (RELO).\nWhen clients use the PUT method, if the schedule is provisioned, the operation updates the schedule; otherwise, the operation starts the schedule provisioning process in the background.
During schedule provisioning, clients can use the GET method to get the schedule and look at the provisionStatus property for the current state of the provisioning.
If the provisioning failed, clients can get additional information from the provisionStatusCode property.
Clients can also inspect the configuration of the schedule.

### [Get-MgGroupTeamScheduleOfferShiftRequest](Get-MgGroupTeamScheduleOfferShiftRequest.md)
Retrieve the properties and relationships of an offerShiftRequest object.

### [Get-MgGroupTeamScheduleOfferShiftRequestCount](Get-MgGroupTeamScheduleOfferShiftRequestCount.md)
Get the number of the resource

### [Get-MgGroupTeamScheduleOpenShift](Get-MgGroupTeamScheduleOpenShift.md)
Retrieve the properties and relationships of an openshift object.

### [Get-MgGroupTeamScheduleOpenShiftChangeRequest](Get-MgGroupTeamScheduleOpenShiftChangeRequest.md)
Retrieve the properties and relationships of an openShiftChangeRequest object.

### [Get-MgGroupTeamScheduleOpenShiftChangeRequestCount](Get-MgGroupTeamScheduleOpenShiftChangeRequestCount.md)
Get the number of the resource

### [Get-MgGroupTeamScheduleOpenShiftCount](Get-MgGroupTeamScheduleOpenShiftCount.md)
Get the number of the resource

### [Get-MgGroupTeamScheduleSchedulingGroup](Get-MgGroupTeamScheduleSchedulingGroup.md)
Retrieve the properties and relationships of a schedulingGroup by ID.

### [Get-MgGroupTeamScheduleSchedulingGroupCount](Get-MgGroupTeamScheduleSchedulingGroupCount.md)
Get the number of the resource

### [Get-MgGroupTeamScheduleShift](Get-MgGroupTeamScheduleShift.md)
Retrieve the properties and relationships of a shift object by ID.

### [Get-MgGroupTeamScheduleShiftCount](Get-MgGroupTeamScheduleShiftCount.md)
Get the number of the resource

### [Get-MgGroupTeamScheduleSwapShiftChangeRequest](Get-MgGroupTeamScheduleSwapShiftChangeRequest.md)
Retrieve the properties and relationships of a swapShiftsChangeRequest object.

### [Get-MgGroupTeamScheduleSwapShiftChangeRequestCount](Get-MgGroupTeamScheduleSwapShiftChangeRequestCount.md)
Get the number of the resource

### [Get-MgGroupTeamScheduleTimeOff](Get-MgGroupTeamScheduleTimeOff.md)
Retrieve the properties and relationships of a timeOff object by ID.

### [Get-MgGroupTeamScheduleTimeOffCount](Get-MgGroupTeamScheduleTimeOffCount.md)
Get the number of the resource

### [Get-MgGroupTeamScheduleTimeOffReason](Get-MgGroupTeamScheduleTimeOffReason.md)
Retrieve the properties and relationships of a timeOffReason object by ID.

### [Get-MgGroupTeamScheduleTimeOffReasonCount](Get-MgGroupTeamScheduleTimeOffReasonCount.md)
Get the number of the resource

### [Get-MgGroupTeamScheduleTimeOffRequest](Get-MgGroupTeamScheduleTimeOffRequest.md)
Retrieve the properties and relationships of a timeoffrequest object.

### [Get-MgGroupTeamScheduleTimeOffRequestCount](Get-MgGroupTeamScheduleTimeOffRequestCount.md)
Get the number of the resource

### [Get-MgGroupTeamTag](Get-MgGroupTeamTag.md)
Read the properties and relationships of a tag object.

### [Get-MgGroupTeamTagCount](Get-MgGroupTeamTagCount.md)
Get the number of the resource

### [Get-MgGroupTeamTagMember](Get-MgGroupTeamTagMember.md)
Get the properties and relationships of a member of a standard tag in a team.

### [Get-MgGroupTeamTagMemberCount](Get-MgGroupTeamTagMemberCount.md)
Get the number of the resource

### [Get-MgGroupTeamTemplate](Get-MgGroupTeamTemplate.md)
The template this team was created from.
See available templates.

### [Get-MgTeam](Get-MgTeam.md)
Retrieve the properties and relationships of the specified team.

### [Get-MgTeamChannel](Get-MgTeamChannel.md)
Retrieve the properties and relationships of a channel.
This method supports federation.
Only a user who is a member of the shared channel can retrieve channel information.

### [Get-MgTeamChannelCount](Get-MgTeamChannelCount.md)
Get the number of the resource

### [Get-MgTeamChannelFileFolder](Get-MgTeamChannelFileFolder.md)
Get the metadata for the location where the files of a channel are stored.

### [Get-MgTeamChannelFileFolderContent](Get-MgTeamChannelFileFolderContent.md)
The content stream, if the item represents a file.

### [Get-MgTeamChannelMember](Get-MgTeamChannelMember.md)
Get a conversationMember from a channel.

### [Get-MgTeamChannelMemberCount](Get-MgTeamChannelMemberCount.md)
Get the number of the resource

### [Get-MgTeamChannelMessage](Get-MgTeamChannelMessage.md)
Retrieve a single message or a message reply in a channel or a chat.

### [Get-MgTeamChannelMessageCount](Get-MgTeamChannelMessageCount.md)
Get the number of the resource

### [Get-MgTeamChannelMessageDelta](Get-MgTeamChannelMessageDelta.md)
Invoke function delta

### [Get-MgTeamChannelMessageHostedContent](Get-MgTeamChannelMessageHostedContent.md)
Retrieve the properties and relationships of chatMessageHostedContent object.

### [Get-MgTeamChannelMessageHostedContentCount](Get-MgTeamChannelMessageHostedContentCount.md)
Get the number of the resource

### [Get-MgTeamChannelMessageReply](Get-MgTeamChannelMessageReply.md)
Retrieve a single message or a message reply in a channel or a chat.

### [Get-MgTeamChannelMessageReplyCount](Get-MgTeamChannelMessageReplyCount.md)
Get the number of the resource

### [Get-MgTeamChannelMessageReplyDelta](Get-MgTeamChannelMessageReplyDelta.md)
Invoke function delta

### [Get-MgTeamChannelMessageReplyHostedContent](Get-MgTeamChannelMessageReplyHostedContent.md)
Retrieve the properties and relationships of chatMessageHostedContent object.

### [Get-MgTeamChannelMessageReplyHostedContentCount](Get-MgTeamChannelMessageReplyHostedContentCount.md)
Get the number of the resource

### [Get-MgTeamChannelSharedWithTeam](Get-MgTeamChannelSharedWithTeam.md)
Get a team that has been shared with a specified channel.
This operation is allowed only for channels with a membershipType value of shared.

### [Get-MgTeamChannelSharedWithTeamAllowedMember](Get-MgTeamChannelSharedWithTeamAllowedMember.md)
A collection of team members who have access to the shared channel.

### [Get-MgTeamChannelSharedWithTeamAllowedMemberCount](Get-MgTeamChannelSharedWithTeamAllowedMemberCount.md)
Get the number of the resource

### [Get-MgTeamChannelSharedWithTeamCount](Get-MgTeamChannelSharedWithTeamCount.md)
Get the number of the resource

### [Get-MgTeamChannelTab](Get-MgTeamChannelTab.md)
Retrieve the properties and relationships of the specified tab in a channel within a team.

### [Get-MgTeamChannelTabCount](Get-MgTeamChannelTabCount.md)
Get the number of the resource

### [Get-MgTeamChannelTabTeamApp](Get-MgTeamChannelTabTeamApp.md)
The application that is linked to the tab.
This can't be changed after tab creation.

### [Get-MgTeamCount](Get-MgTeamCount.md)
Get the number of the resource

### [Get-MgTeamGroupServiceProvisioningError](Get-MgTeamGroupServiceProvisioningError.md)
Errors published by a federated service describing a non-transient, service-specific error regarding the properties or link from a group object .
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgTeamGroupServiceProvisioningErrorCount](Get-MgTeamGroupServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgTeamIncomingChannel](Get-MgTeamIncomingChannel.md)
List of channels shared with the team.

### [Get-MgTeamIncomingChannelCount](Get-MgTeamIncomingChannelCount.md)
Get the number of the resource

### [Get-MgTeamInstalledApp](Get-MgTeamInstalledApp.md)
Retrieve the app installed in the specified team.

### [Get-MgTeamInstalledAppCount](Get-MgTeamInstalledAppCount.md)
Get the number of the resource

### [Get-MgTeamInstalledAppTeamApp](Get-MgTeamInstalledAppTeamApp.md)
The app that is installed.

### [Get-MgTeamInstalledAppTeamAppDefinition](Get-MgTeamInstalledAppTeamAppDefinition.md)
The details of this version of the app.

### [Get-MgTeamMember](Get-MgTeamMember.md)
Get a conversationMember from a team.

### [Get-MgTeamMemberCount](Get-MgTeamMemberCount.md)
Get the number of the resource

### [Get-MgTeamOperation](Get-MgTeamOperation.md)
The async operations that ran or are running on this team.

### [Get-MgTeamOperationCount](Get-MgTeamOperationCount.md)
Get the number of the resource

### [Get-MgTeamPermissionGrant](Get-MgTeamPermissionGrant.md)
A collection of permissions granted to apps to access the team.

### [Get-MgTeamPermissionGrantCount](Get-MgTeamPermissionGrantCount.md)
Get the number of the resource

### [Get-MgTeamPhoto](Get-MgTeamPhoto.md)
Get the specified profilePhoto or its metadata (profilePhoto properties).
The supported sizes of HD photos on Microsoft 365 are as follows: 48x48, 64x64, 96x96, 120x120, 240x240,\n360x360, 432x432, 504x504, and 648x648.
Photos can be any dimension if they're stored in Microsoft Entra ID.
You can get the metadata of the largest available photo or specify a size to get the metadata for that photo size.\nIf the size you request is unavailable, you can still get a smaller size that the user has uploaded and made available.\nFor example, if the user uploads a photo that is 504x504 pixels, all but the 648x648 size of the photo is available for download.

### [Get-MgTeamPhotoContent](Get-MgTeamPhotoContent.md)
Get media content for the navigation property photo from teams

### [Get-MgTeamPrimaryChannel](Get-MgTeamPrimaryChannel.md)
Get the default channel, General, of a team.

### [Get-MgTeamPrimaryChannelFileFolder](Get-MgTeamPrimaryChannelFileFolder.md)
Get the metadata for the location where the files of a channel are stored.

### [Get-MgTeamPrimaryChannelFileFolderContent](Get-MgTeamPrimaryChannelFileFolderContent.md)
The content stream, if the item represents a file.

### [Get-MgTeamPrimaryChannelMember](Get-MgTeamPrimaryChannelMember.md)
Get a conversationMember from a channel.

### [Get-MgTeamPrimaryChannelMemberCount](Get-MgTeamPrimaryChannelMemberCount.md)
Get the number of the resource

### [Get-MgTeamPrimaryChannelMessage](Get-MgTeamPrimaryChannelMessage.md)
Retrieve a single message or a message reply in a channel or a chat.

### [Get-MgTeamPrimaryChannelMessageCount](Get-MgTeamPrimaryChannelMessageCount.md)
Get the number of the resource

### [Get-MgTeamPrimaryChannelMessageDelta](Get-MgTeamPrimaryChannelMessageDelta.md)
Invoke function delta

### [Get-MgTeamPrimaryChannelMessageHostedContent](Get-MgTeamPrimaryChannelMessageHostedContent.md)
Retrieve the properties and relationships of chatMessageHostedContent object.

### [Get-MgTeamPrimaryChannelMessageHostedContentCount](Get-MgTeamPrimaryChannelMessageHostedContentCount.md)
Get the number of the resource

### [Get-MgTeamPrimaryChannelMessageReply](Get-MgTeamPrimaryChannelMessageReply.md)
Retrieve a single message or a message reply in a channel or a chat.

### [Get-MgTeamPrimaryChannelMessageReplyCount](Get-MgTeamPrimaryChannelMessageReplyCount.md)
Get the number of the resource

### [Get-MgTeamPrimaryChannelMessageReplyDelta](Get-MgTeamPrimaryChannelMessageReplyDelta.md)
Invoke function delta

### [Get-MgTeamPrimaryChannelMessageReplyHostedContent](Get-MgTeamPrimaryChannelMessageReplyHostedContent.md)
Retrieve the properties and relationships of chatMessageHostedContent object.

### [Get-MgTeamPrimaryChannelMessageReplyHostedContentCount](Get-MgTeamPrimaryChannelMessageReplyHostedContentCount.md)
Get the number of the resource

### [Get-MgTeamPrimaryChannelSharedWithTeam](Get-MgTeamPrimaryChannelSharedWithTeam.md)
Get a team that has been shared with a specified channel.
This operation is allowed only for channels with a membershipType value of shared.

### [Get-MgTeamPrimaryChannelSharedWithTeamAllowedMember](Get-MgTeamPrimaryChannelSharedWithTeamAllowedMember.md)
A collection of team members who have access to the shared channel.

### [Get-MgTeamPrimaryChannelSharedWithTeamAllowedMemberCount](Get-MgTeamPrimaryChannelSharedWithTeamAllowedMemberCount.md)
Get the number of the resource

### [Get-MgTeamPrimaryChannelSharedWithTeamCount](Get-MgTeamPrimaryChannelSharedWithTeamCount.md)
Get the number of the resource

### [Get-MgTeamPrimaryChannelTab](Get-MgTeamPrimaryChannelTab.md)
Retrieve the properties and relationships of the specified tab in a channel within a team.

### [Get-MgTeamPrimaryChannelTabCount](Get-MgTeamPrimaryChannelTabCount.md)
Get the number of the resource

### [Get-MgTeamPrimaryChannelTabTeamApp](Get-MgTeamPrimaryChannelTabTeamApp.md)
The application that is linked to the tab.
This can't be changed after tab creation.

### [Get-MgTeamSchedule](Get-MgTeamSchedule.md)
Retrieve the properties and relationships of a schedule object.
The schedule creation process conforms to the One API guideline for resource based long running operations (RELO).\nWhen clients use the PUT method, if the schedule is provisioned, the operation updates the schedule; otherwise, the operation starts the schedule provisioning process in the background.
During schedule provisioning, clients can use the GET method to get the schedule and look at the provisionStatus property for the current state of the provisioning.
If the provisioning failed, clients can get additional information from the provisionStatusCode property.
Clients can also inspect the configuration of the schedule.

### [Get-MgTeamScheduleOfferShiftRequest](Get-MgTeamScheduleOfferShiftRequest.md)
Retrieve the properties and relationships of an offerShiftRequest object.

### [Get-MgTeamScheduleOfferShiftRequestCount](Get-MgTeamScheduleOfferShiftRequestCount.md)
Get the number of the resource

### [Get-MgTeamScheduleOpenShift](Get-MgTeamScheduleOpenShift.md)
Retrieve the properties and relationships of an openshift object.

### [Get-MgTeamScheduleOpenShiftChangeRequest](Get-MgTeamScheduleOpenShiftChangeRequest.md)
Retrieve the properties and relationships of an openShiftChangeRequest object.

### [Get-MgTeamScheduleOpenShiftChangeRequestCount](Get-MgTeamScheduleOpenShiftChangeRequestCount.md)
Get the number of the resource

### [Get-MgTeamScheduleOpenShiftCount](Get-MgTeamScheduleOpenShiftCount.md)
Get the number of the resource

### [Get-MgTeamScheduleSchedulingGroup](Get-MgTeamScheduleSchedulingGroup.md)
Retrieve the properties and relationships of a schedulingGroup by ID.

### [Get-MgTeamScheduleSchedulingGroupCount](Get-MgTeamScheduleSchedulingGroupCount.md)
Get the number of the resource

### [Get-MgTeamScheduleShift](Get-MgTeamScheduleShift.md)
Retrieve the properties and relationships of a shift object by ID.

### [Get-MgTeamScheduleShiftCount](Get-MgTeamScheduleShiftCount.md)
Get the number of the resource

### [Get-MgTeamScheduleSwapShiftChangeRequest](Get-MgTeamScheduleSwapShiftChangeRequest.md)
Retrieve the properties and relationships of a swapShiftsChangeRequest object.

### [Get-MgTeamScheduleSwapShiftChangeRequestCount](Get-MgTeamScheduleSwapShiftChangeRequestCount.md)
Get the number of the resource

### [Get-MgTeamScheduleTimeOff](Get-MgTeamScheduleTimeOff.md)
Retrieve the properties and relationships of a timeOff object by ID.

### [Get-MgTeamScheduleTimeOffCount](Get-MgTeamScheduleTimeOffCount.md)
Get the number of the resource

### [Get-MgTeamScheduleTimeOffReason](Get-MgTeamScheduleTimeOffReason.md)
Retrieve the properties and relationships of a timeOffReason object by ID.

### [Get-MgTeamScheduleTimeOffReasonCount](Get-MgTeamScheduleTimeOffReasonCount.md)
Get the number of the resource

### [Get-MgTeamScheduleTimeOffRequest](Get-MgTeamScheduleTimeOffRequest.md)
Retrieve the properties and relationships of a timeoffrequest object.

### [Get-MgTeamScheduleTimeOffRequestCount](Get-MgTeamScheduleTimeOffRequestCount.md)
Get the number of the resource

### [Get-MgTeamTag](Get-MgTeamTag.md)
Read the properties and relationships of a tag object.

### [Get-MgTeamTagCount](Get-MgTeamTagCount.md)
Get the number of the resource

### [Get-MgTeamTagMember](Get-MgTeamTagMember.md)
Get the properties and relationships of a member of a standard tag in a team.

### [Get-MgTeamTagMemberCount](Get-MgTeamTagMemberCount.md)
Get the number of the resource

### [Get-MgTeamTemplate](Get-MgTeamTemplate.md)
The template this team was created from.
See available templates.

### [Get-MgTeamwork](Get-MgTeamwork.md)
Get teamwork

### [Get-MgTeamworkDeletedTeam](Get-MgTeamworkDeletedTeam.md)
The deleted team.

### [Get-MgTeamworkDeletedTeamChannel](Get-MgTeamworkDeletedTeamChannel.md)
The channels that are either shared with this deleted team or created in this deleted team.

### [Get-MgTeamworkDeletedTeamChannelCount](Get-MgTeamworkDeletedTeamChannelCount.md)
Get the number of the resource

### [Get-MgTeamworkDeletedTeamChannelFileFolder](Get-MgTeamworkDeletedTeamChannelFileFolder.md)
Get the metadata for the location where the files of a channel are stored.

### [Get-MgTeamworkDeletedTeamChannelFileFolderContent](Get-MgTeamworkDeletedTeamChannelFileFolderContent.md)
The content stream, if the item represents a file.

### [Get-MgTeamworkDeletedTeamChannelMember](Get-MgTeamworkDeletedTeamChannelMember.md)
Get a conversationMember from a channel.

### [Get-MgTeamworkDeletedTeamChannelMemberCount](Get-MgTeamworkDeletedTeamChannelMemberCount.md)
Get the number of the resource

### [Get-MgTeamworkDeletedTeamChannelMessage](Get-MgTeamworkDeletedTeamChannelMessage.md)
Retrieve a single message or a message reply in a channel or a chat.

### [Get-MgTeamworkDeletedTeamChannelMessageCount](Get-MgTeamworkDeletedTeamChannelMessageCount.md)
Get the number of the resource

### [Get-MgTeamworkDeletedTeamChannelMessageDelta](Get-MgTeamworkDeletedTeamChannelMessageDelta.md)
Invoke function delta

### [Get-MgTeamworkDeletedTeamChannelMessageHostedContent](Get-MgTeamworkDeletedTeamChannelMessageHostedContent.md)
Retrieve the properties and relationships of chatMessageHostedContent object.

### [Get-MgTeamworkDeletedTeamChannelMessageHostedContentCount](Get-MgTeamworkDeletedTeamChannelMessageHostedContentCount.md)
Get the number of the resource

### [Get-MgTeamworkDeletedTeamChannelMessageReply](Get-MgTeamworkDeletedTeamChannelMessageReply.md)
Retrieve a single message or a message reply in a channel or a chat.

### [Get-MgTeamworkDeletedTeamChannelMessageReplyCount](Get-MgTeamworkDeletedTeamChannelMessageReplyCount.md)
Get the number of the resource

### [Get-MgTeamworkDeletedTeamChannelMessageReplyDelta](Get-MgTeamworkDeletedTeamChannelMessageReplyDelta.md)
Invoke function delta

### [Get-MgTeamworkDeletedTeamChannelMessageReplyHostedContent](Get-MgTeamworkDeletedTeamChannelMessageReplyHostedContent.md)
Retrieve the properties and relationships of chatMessageHostedContent object.

### [Get-MgTeamworkDeletedTeamChannelMessageReplyHostedContentCount](Get-MgTeamworkDeletedTeamChannelMessageReplyHostedContentCount.md)
Get the number of the resource

### [Get-MgTeamworkDeletedTeamChannelSharedWithTeam](Get-MgTeamworkDeletedTeamChannelSharedWithTeam.md)
Get a team that has been shared with a specified channel.
This operation is allowed only for channels with a membershipType value of shared.

### [Get-MgTeamworkDeletedTeamChannelSharedWithTeamAllowedMember](Get-MgTeamworkDeletedTeamChannelSharedWithTeamAllowedMember.md)
A collection of team members who have access to the shared channel.

### [Get-MgTeamworkDeletedTeamChannelSharedWithTeamAllowedMemberCount](Get-MgTeamworkDeletedTeamChannelSharedWithTeamAllowedMemberCount.md)
Get the number of the resource

### [Get-MgTeamworkDeletedTeamChannelSharedWithTeamCount](Get-MgTeamworkDeletedTeamChannelSharedWithTeamCount.md)
Get the number of the resource

### [Get-MgTeamworkDeletedTeamChannelTab](Get-MgTeamworkDeletedTeamChannelTab.md)
Retrieve the properties and relationships of the specified tab in a channel within a team.

### [Get-MgTeamworkDeletedTeamChannelTabCount](Get-MgTeamworkDeletedTeamChannelTabCount.md)
Get the number of the resource

### [Get-MgTeamworkDeletedTeamChannelTabTeamApp](Get-MgTeamworkDeletedTeamChannelTabTeamApp.md)
The application that is linked to the tab.
This can't be changed after tab creation.

### [Get-MgTeamworkDeletedTeamCount](Get-MgTeamworkDeletedTeamCount.md)
Get the number of the resource

### [Get-MgTeamworkTeamAppSetting](Get-MgTeamworkTeamAppSetting.md)
Get the tenant-wide teamsAppSettings for all Teams apps in the tenant.

### [Get-MgTeamworkWorkforceIntegration](Get-MgTeamworkWorkforceIntegration.md)
Retrieve the properties and relationships of a workforceIntegration object.

### [Get-MgTeamworkWorkforceIntegrationCount](Get-MgTeamworkWorkforceIntegrationCount.md)
Get the number of the resource

### [Get-MgUserChat](Get-MgUserChat.md)
Retrieve a single chat (without its messages).
This method supports federation.
To access a chat, at least one chat member must belong to the tenant the request initiated from.

### [Get-MgUserChatCount](Get-MgUserChatCount.md)
Get the number of the resource

### [Get-MgUserChatInstalledApp](Get-MgUserChatInstalledApp.md)
Get an app installed in a chat.

### [Get-MgUserChatInstalledAppCount](Get-MgUserChatInstalledAppCount.md)
Get the number of the resource

### [Get-MgUserChatInstalledAppTeamApp](Get-MgUserChatInstalledAppTeamApp.md)
The app that is installed.

### [Get-MgUserChatInstalledAppTeamAppDefinition](Get-MgUserChatInstalledAppTeamAppDefinition.md)
The details of this version of the app.

### [Get-MgUserChatLastMessagePreview](Get-MgUserChatLastMessagePreview.md)
Preview of the last message sent in the chat.
Null if no messages have been sent in the chat.
Currently, only the list chats operation supports this property.

### [Get-MgUserChatMember](Get-MgUserChatMember.md)
Retrieve a conversationMember from a chat.

### [Get-MgUserChatMemberCount](Get-MgUserChatMemberCount.md)
Get the number of the resource

### [Get-MgUserChatMessage](Get-MgUserChatMessage.md)
Retrieve a single message or a message reply in a channel or a chat.

### [Get-MgUserChatMessageCount](Get-MgUserChatMessageCount.md)
Get the number of the resource

### [Get-MgUserChatMessageHostedContent](Get-MgUserChatMessageHostedContent.md)
Retrieve the properties and relationships of chatMessageHostedContent object.

### [Get-MgUserChatMessageHostedContentCount](Get-MgUserChatMessageHostedContentCount.md)
Get the number of the resource

### [Get-MgUserChatMessageReply](Get-MgUserChatMessageReply.md)
Retrieve a single message or a message reply in a channel or a chat.

### [Get-MgUserChatMessageReplyCount](Get-MgUserChatMessageReplyCount.md)
Get the number of the resource

### [Get-MgUserChatMessageReplyHostedContent](Get-MgUserChatMessageReplyHostedContent.md)
Retrieve the properties and relationships of chatMessageHostedContent object.

### [Get-MgUserChatMessageReplyHostedContentCount](Get-MgUserChatMessageReplyHostedContentCount.md)
Get the number of the resource

### [Get-MgUserChatPermissionGrant](Get-MgUserChatPermissionGrant.md)
A collection of permissions granted to apps for the chat.

### [Get-MgUserChatPermissionGrantCount](Get-MgUserChatPermissionGrantCount.md)
Get the number of the resource

### [Get-MgUserChatPinnedMessage](Get-MgUserChatPinnedMessage.md)
A collection of all the pinned messages in the chat.
Nullable.

### [Get-MgUserChatPinnedMessageCount](Get-MgUserChatPinnedMessageCount.md)
Get the number of the resource

### [Get-MgUserChatTab](Get-MgUserChatTab.md)
Retrieve the properties and relationships of the specified tab in a chat.

### [Get-MgUserChatTabCount](Get-MgUserChatTabCount.md)
Get the number of the resource

### [Get-MgUserChatTabTeamApp](Get-MgUserChatTabTeamApp.md)
The application that is linked to the tab.
This can't be changed after tab creation.

### [Get-MgUserJoinedTeam](Get-MgUserJoinedTeam.md)
Get the teams in Microsoft Teams that the user is a direct member of.

### [Get-MgUserTeamwork](Get-MgUserTeamwork.md)
A container for Microsoft Teams features available for the user.
Read-only.
Nullable.

### [Get-MgUserTeamworkAssociatedTeam](Get-MgUserTeamworkAssociatedTeam.md)
The list of associatedTeamInfo objects that a user is associated with.

### [Get-MgUserTeamworkAssociatedTeamCount](Get-MgUserTeamworkAssociatedTeamCount.md)
Get the number of the resource

### [Get-MgUserTeamworkInstalledApp](Get-MgUserTeamworkInstalledApp.md)
Retrieve the app installed in the personal scope of the specified user.

### [Get-MgUserTeamworkInstalledAppChat](Get-MgUserTeamworkInstalledAppChat.md)
Retrieve the chat of the specified user and Teams app.

### [Get-MgUserTeamworkInstalledAppCount](Get-MgUserTeamworkInstalledAppCount.md)
Get the number of the resource

### [Get-MgUserTeamworkInstalledAppTeamApp](Get-MgUserTeamworkInstalledAppTeamApp.md)
The app that is installed.

### [Get-MgUserTeamworkInstalledAppTeamAppDefinition](Get-MgUserTeamworkInstalledAppTeamAppDefinition.md)
The details of this version of the app.

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

### [Invoke-MgHaveTeamworkDeletedTeamChannel](Invoke-MgHaveTeamworkDeletedTeamChannel.md)
Invoke function doesUserHaveAccess

### [Invoke-MgMarkChatReadForUser](Invoke-MgMarkChatReadForUser.md)
Mark a chat as read for a user.

### [Invoke-MgMarkChatUnreadForUser](Invoke-MgMarkChatUnreadForUser.md)
Mark a chat as unread for a user.

### [Invoke-MgShareTeamSchedule](Invoke-MgShareTeamSchedule.md)
Share a schedule time range with schedule members.
This action makes the collections of shift, openshift and timeOff items in the specified time range of the schedule viewable by the specified team members, including employees and managers.
Each shift, openshift and timeOff instance in a schedule supports a draft version and a shared version of the item.
The draft version is viewable by only managers, and the shared version is viewable by employees and managers.
For each shift, openshift and timeOff instance in the specified time range, the share action updates the shared version from the draft version, so that in addition to managers, employees can also view the most current information about the item.
The notifyTeam parameter further specifies which employees can view the item.

### [Invoke-MgSoftChatMessageDelete](Invoke-MgSoftChatMessageDelete.md)
Delete a single chatMessage or a chat message reply in a channel or a chat.

### [Invoke-MgSoftChatMessageReplyDelete](Invoke-MgSoftChatMessageReplyDelete.md)
Delete a single chatMessage or a chat message reply in a channel or a chat.

### [Invoke-MgSoftTeamChannelMessageDelete](Invoke-MgSoftTeamChannelMessageDelete.md)
Delete a single chatMessage or a chat message reply in a channel or a chat.

### [Invoke-MgSoftTeamChannelMessageReplyDelete](Invoke-MgSoftTeamChannelMessageReplyDelete.md)
Delete a single chatMessage or a chat message reply in a channel or a chat.

### [Invoke-MgSoftTeamPrimaryChannelMessageDelete](Invoke-MgSoftTeamPrimaryChannelMessageDelete.md)
Delete a single chatMessage or a chat message reply in a channel or a chat.

### [Invoke-MgSoftTeamPrimaryChannelMessageReplyDelete](Invoke-MgSoftTeamPrimaryChannelMessageReplyDelete.md)
Delete a single chatMessage or a chat message reply in a channel or a chat.

### [Invoke-MgSoftTeamworkDeletedTeamChannelMessageDelete](Invoke-MgSoftTeamworkDeletedTeamChannelMessageDelete.md)
Delete a single chatMessage or a chat message reply in a channel or a chat.

### [Invoke-MgSoftTeamworkDeletedTeamChannelMessageReplyDelete](Invoke-MgSoftTeamworkDeletedTeamChannelMessageReplyDelete.md)
Delete a single chatMessage or a chat message reply in a channel or a chat.

### [Invoke-MgUnarchiveTeam](Invoke-MgUnarchiveTeam.md)
Restore an archived team.
This restores users' ability to send messages and edit the team, abiding by tenant and team settings.
A Team is archived using the archive API.
Unarchiving is an async operation.
A team is unarchived once the async operation completes successfully, which may occur subsequent to a response from this API.

### [New-MgAppCatalogTeamApp](New-MgAppCatalogTeamApp.md)
Publish an app to the Microsoft Teams app catalog.\nSpecifically, this API publishes the app to your organization's catalog (the tenant app catalog);\nthe created resource has a distributionMethod property value of organization.
The requiresReview property allows any user to submit an app for review by an administrator.
Admins can approve or reject these apps via this API or the Microsoft Teams admin center.

### [New-MgAppCatalogTeamAppDefinition](New-MgAppCatalogTeamAppDefinition.md)
Update an app previously published to the Microsoft Teams app catalog.
To update an app, the distributionMethod property for the app must be set to organization.
This API specifically updates an app published to your organization's app catalog (the tenant app catalog).

### [New-MgChat](New-MgChat.md)
Create a new chat object.

### [New-MgChatInstalledApp](New-MgChatInstalledApp.md)
Install a teamsApp to the specified chat.

### [New-MgChatMember](New-MgChatMember.md)
Add a conversationMember to a chat.

### [New-MgChatMessage](New-MgChatMessage.md)
Send a new chatMessage in the specified channel or a chat.

### [New-MgChatMessageHostedContent](New-MgChatMessageHostedContent.md)
Create new navigation property to hostedContents for chats

### [New-MgChatMessageReply](New-MgChatMessageReply.md)
Create a new reply to a chatMessage in a specified channel.

### [New-MgChatMessageReplyHostedContent](New-MgChatMessageReplyHostedContent.md)
Create new navigation property to hostedContents for chats

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
When you create a channel, the maximum length of the channel's displayName is 50 characters.
This is the name that appears to the user in Microsoft Teams.
If you're creating a private channel, you can add a maximum of 200 members.

### [New-MgGroupTeamChannelMember](New-MgGroupTeamChannelMember.md)
Add a conversationMember to a channel.

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
Add (pin) a tab to the specified channel within a team.
The app must be preinstalled in the team and have the configurableTabs property defined in the app manifest.

### [New-MgGroupTeamInstalledApp](New-MgGroupTeamInstalledApp.md)
Install an app to the specified team.

### [New-MgGroupTeamMember](New-MgGroupTeamMember.md)
Add a new conversationMember to a team.

### [New-MgGroupTeamOperation](New-MgGroupTeamOperation.md)
Create new navigation property to operations for groups

### [New-MgGroupTeamPermissionGrant](New-MgGroupTeamPermissionGrant.md)
Create new navigation property to permissionGrants for groups

### [New-MgGroupTeamPrimaryChannelMember](New-MgGroupTeamPrimaryChannelMember.md)
Add a conversationMember to a channel.

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
Add (pin) a tab to the specified channel within a team.
The app must be preinstalled in the team and have the configurableTabs property defined in the app manifest.

### [New-MgGroupTeamScheduleOfferShiftRequest](New-MgGroupTeamScheduleOfferShiftRequest.md)
Create an instance of an offerShiftRequest.

### [New-MgGroupTeamScheduleOpenShift](New-MgGroupTeamScheduleOpenShift.md)
Create an instance of an openShift object.

### [New-MgGroupTeamScheduleOpenShiftChangeRequest](New-MgGroupTeamScheduleOpenShiftChangeRequest.md)
Create instance of an openShiftChangeRequest object.

### [New-MgGroupTeamScheduleSchedulingGroup](New-MgGroupTeamScheduleSchedulingGroup.md)
Create a new schedulingGroup.

### [New-MgGroupTeamScheduleShift](New-MgGroupTeamScheduleShift.md)
Create a new shift instance in a schedule.
The duration of a shift cannot be less than 1 minute or longer than 24 hours.

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
When you create a channel, the maximum length of the channel's displayName is 50 characters.
This is the name that appears to the user in Microsoft Teams.
If you're creating a private channel, you can add a maximum of 200 members.

### [New-MgTeamChannelEmail](New-MgTeamChannelEmail.md)
Provision an email address for a channel.
Microsoft Teams doesn't automatically provision an email address for a channel by default.
To have Teams provision an email address, you can call provisionEmail, or through the Teams user interface, select Get email address, which triggers Teams to generate an email address if it has not already provisioned one.
To remove the email address of a channel, use the removeEmail method.

### [New-MgTeamChannelMember](New-MgTeamChannelMember.md)
Add a conversationMember to a channel.

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
Add (pin) a tab to the specified channel within a team.
The app must be preinstalled in the team and have the configurableTabs property defined in the app manifest.

### [New-MgTeamInstalledApp](New-MgTeamInstalledApp.md)
Install an app to the specified team.

### [New-MgTeamMember](New-MgTeamMember.md)
Add a new conversationMember to a team.

### [New-MgTeamOperation](New-MgTeamOperation.md)
Create new navigation property to operations for teams

### [New-MgTeamPermissionGrant](New-MgTeamPermissionGrant.md)
Create new navigation property to permissionGrants for teams

### [New-MgTeamPrimaryChannelEmail](New-MgTeamPrimaryChannelEmail.md)
Provision an email address for a channel.
Microsoft Teams doesn't automatically provision an email address for a channel by default.
To have Teams provision an email address, you can call provisionEmail, or through the Teams user interface, select Get email address, which triggers Teams to generate an email address if it has not already provisioned one.
To remove the email address of a channel, use the removeEmail method.

### [New-MgTeamPrimaryChannelMember](New-MgTeamPrimaryChannelMember.md)
Add a conversationMember to a channel.

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
Add (pin) a tab to the specified channel within a team.
The app must be preinstalled in the team and have the configurableTabs property defined in the app manifest.

### [New-MgTeamScheduleOfferShiftRequest](New-MgTeamScheduleOfferShiftRequest.md)
Create an instance of an offerShiftRequest.

### [New-MgTeamScheduleOpenShift](New-MgTeamScheduleOpenShift.md)
Create an instance of an openShift object.

### [New-MgTeamScheduleOpenShiftChangeRequest](New-MgTeamScheduleOpenShiftChangeRequest.md)
Create instance of an openShiftChangeRequest object.

### [New-MgTeamScheduleSchedulingGroup](New-MgTeamScheduleSchedulingGroup.md)
Create a new schedulingGroup.

### [New-MgTeamScheduleShift](New-MgTeamScheduleShift.md)
Create a new shift instance in a schedule.
The duration of a shift cannot be less than 1 minute or longer than 24 hours.

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

### [New-MgTeamworkDeletedTeam](New-MgTeamworkDeletedTeam.md)
Create new navigation property to deletedTeams for teamwork

### [New-MgTeamworkDeletedTeamChannel](New-MgTeamworkDeletedTeamChannel.md)
Create new navigation property to channels for teamwork

### [New-MgTeamworkDeletedTeamChannelEmail](New-MgTeamworkDeletedTeamChannelEmail.md)
Provision an email address for a channel.
Microsoft Teams doesn't automatically provision an email address for a channel by default.
To have Teams provision an email address, you can call provisionEmail, or through the Teams user interface, select Get email address, which triggers Teams to generate an email address if it has not already provisioned one.
To remove the email address of a channel, use the removeEmail method.

### [New-MgTeamworkDeletedTeamChannelMember](New-MgTeamworkDeletedTeamChannelMember.md)
Add a conversationMember to a channel.

### [New-MgTeamworkDeletedTeamChannelMessage](New-MgTeamworkDeletedTeamChannelMessage.md)
Send a new chatMessage in the specified channel or a chat.

### [New-MgTeamworkDeletedTeamChannelMessageHostedContent](New-MgTeamworkDeletedTeamChannelMessageHostedContent.md)
Create new navigation property to hostedContents for teamwork

### [New-MgTeamworkDeletedTeamChannelMessageReply](New-MgTeamworkDeletedTeamChannelMessageReply.md)
Create a new reply to a chatMessage in a specified channel.

### [New-MgTeamworkDeletedTeamChannelMessageReplyHostedContent](New-MgTeamworkDeletedTeamChannelMessageReplyHostedContent.md)
Create new navigation property to hostedContents for teamwork

### [New-MgTeamworkDeletedTeamChannelSharedWithTeam](New-MgTeamworkDeletedTeamChannelSharedWithTeam.md)
Create new navigation property to sharedWithTeams for teamwork

### [New-MgTeamworkDeletedTeamChannelTab](New-MgTeamworkDeletedTeamChannelTab.md)
Add (pin) a tab to the specified channel within a team.
The app must be preinstalled in the team and have the configurableTabs property defined in the app manifest.

### [New-MgTeamworkWorkforceIntegration](New-MgTeamworkWorkforceIntegration.md)
Create a new workforceIntegration object.\nYou can set up which entities you want to receive Shifts synchronous change notifications on and set entities to configure filtering by WFM rules eligibility for, including swap requests.

### [New-MgUserChat](New-MgUserChat.md)
Create new navigation property to chats for users

### [New-MgUserChatInstalledApp](New-MgUserChatInstalledApp.md)
Install a teamsApp to the specified chat.

### [New-MgUserChatMember](New-MgUserChatMember.md)
Add a conversationMember to a chat.

### [New-MgUserChatMessage](New-MgUserChatMessage.md)
Send a new chatMessage in the specified channel or a chat.

### [New-MgUserChatMessageHostedContent](New-MgUserChatMessageHostedContent.md)
Create new navigation property to hostedContents for users

### [New-MgUserChatMessageReply](New-MgUserChatMessageReply.md)
Create a new reply to a chatMessage in a specified channel.

### [New-MgUserChatMessageReplyHostedContent](New-MgUserChatMessageReplyHostedContent.md)
Create new navigation property to hostedContents for users

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
Delete an app from an organization's app catalog (the tenant app catalog).
To delete an app, the distributionMethod property for the app must be set to organization.
You can also use this API to remove a submitted app from the review process.

### [Remove-MgAppCatalogTeamAppDefinition](Remove-MgAppCatalogTeamAppDefinition.md)
Delete navigation property appDefinitions for appCatalogs

### [Remove-MgAppCatalogTeamAppDefinitionBot](Remove-MgAppCatalogTeamAppDefinitionBot.md)
Delete navigation property bot for appCatalogs

### [Remove-MgChat](Remove-MgChat.md)
Delete entity from chats

### [Remove-MgChatInstalledApp](Remove-MgChatInstalledApp.md)
Uninstall an app installed within a chat.

### [Remove-MgChatLastMessagePreview](Remove-MgChatLastMessagePreview.md)
Delete navigation property lastMessagePreview for chats

### [Remove-MgChatMember](Remove-MgChatMember.md)
Remove a conversationMember from a chat.

### [Remove-MgChatMessageReplyHostedContent](Remove-MgChatMessageReplyHostedContent.md)
Delete navigation property hostedContents for chats

### [Remove-MgChatPermissionGrant](Remove-MgChatPermissionGrant.md)
Delete navigation property permissionGrants for chats

### [Remove-MgChatPinnedMessage](Remove-MgChatPinnedMessage.md)
Unpin a message from a chat.

### [Remove-MgChatTab](Remove-MgChatTab.md)
Remove (unpin) a tab from the specified chat.

### [Remove-MgGroupTeam](Remove-MgGroupTeam.md)
Delete navigation property team for groups

### [Remove-MgGroupTeamChannel](Remove-MgGroupTeamChannel.md)
Delete the channel.

### [Remove-MgGroupTeamChannelMember](Remove-MgGroupTeamChannelMember.md)
Delete a conversationMember from a channel.

### [Remove-MgGroupTeamChannelMessage](Remove-MgGroupTeamChannelMessage.md)
Delete navigation property messages for groups

### [Remove-MgGroupTeamChannelMessageHostedContent](Remove-MgGroupTeamChannelMessageHostedContent.md)
Delete navigation property hostedContents for groups

### [Remove-MgGroupTeamChannelMessageReply](Remove-MgGroupTeamChannelMessageReply.md)
Delete navigation property replies for groups

### [Remove-MgGroupTeamChannelMessageReplyHostedContent](Remove-MgGroupTeamChannelMessageReplyHostedContent.md)
Delete navigation property hostedContents for groups

### [Remove-MgGroupTeamChannelSharedWithTeam](Remove-MgGroupTeamChannelSharedWithTeam.md)
Unshare a channel with a team by deleting the corresponding sharedWithChannelTeamInfo resource.
This operation is allowed only for channels with a membershipType value of shared.

### [Remove-MgGroupTeamChannelTab](Remove-MgGroupTeamChannelTab.md)
Removes (unpins) a tab from the specified channel within a team.

### [Remove-MgGroupTeamInstalledApp](Remove-MgGroupTeamInstalledApp.md)
Uninstalls an app from the specified team.

### [Remove-MgGroupTeamMember](Remove-MgGroupTeamMember.md)
Remove a conversationMember from a team.

### [Remove-MgGroupTeamOperation](Remove-MgGroupTeamOperation.md)
Delete navigation property operations for groups

### [Remove-MgGroupTeamPermissionGrant](Remove-MgGroupTeamPermissionGrant.md)
Delete navigation property permissionGrants for groups

### [Remove-MgGroupTeamPrimaryChannel](Remove-MgGroupTeamPrimaryChannel.md)
Delete navigation property primaryChannel for groups

### [Remove-MgGroupTeamPrimaryChannelMember](Remove-MgGroupTeamPrimaryChannelMember.md)
Delete a conversationMember from a channel.

### [Remove-MgGroupTeamPrimaryChannelMessage](Remove-MgGroupTeamPrimaryChannelMessage.md)
Delete navigation property messages for groups

### [Remove-MgGroupTeamPrimaryChannelMessageHostedContent](Remove-MgGroupTeamPrimaryChannelMessageHostedContent.md)
Delete navigation property hostedContents for groups

### [Remove-MgGroupTeamPrimaryChannelMessageReply](Remove-MgGroupTeamPrimaryChannelMessageReply.md)
Delete navigation property replies for groups

### [Remove-MgGroupTeamPrimaryChannelMessageReplyHostedContent](Remove-MgGroupTeamPrimaryChannelMessageReplyHostedContent.md)
Delete navigation property hostedContents for groups

### [Remove-MgGroupTeamPrimaryChannelSharedWithTeam](Remove-MgGroupTeamPrimaryChannelSharedWithTeam.md)
Unshare a channel with a team by deleting the corresponding sharedWithChannelTeamInfo resource.
This operation is allowed only for channels with a membershipType value of shared.

### [Remove-MgGroupTeamPrimaryChannelTab](Remove-MgGroupTeamPrimaryChannelTab.md)
Removes (unpins) a tab from the specified channel within a team.

### [Remove-MgGroupTeamSchedule](Remove-MgGroupTeamSchedule.md)
Delete navigation property schedule for groups

### [Remove-MgGroupTeamScheduleOfferShiftRequest](Remove-MgGroupTeamScheduleOfferShiftRequest.md)
Delete navigation property offerShiftRequests for groups

### [Remove-MgGroupTeamScheduleOpenShift](Remove-MgGroupTeamScheduleOpenShift.md)
Delete an openShift object.

### [Remove-MgGroupTeamScheduleOpenShiftChangeRequest](Remove-MgGroupTeamScheduleOpenShiftChangeRequest.md)
Delete navigation property openShiftChangeRequests for groups

### [Remove-MgGroupTeamScheduleSchedulingGroup](Remove-MgGroupTeamScheduleSchedulingGroup.md)
Mark a schedulingGroup as inactive by setting its isActive property.\nThis method does not remove the schedulingGroup from the schedule.
Existing shift instances assigned to the scheduling group remain part of the group.

### [Remove-MgGroupTeamScheduleShift](Remove-MgGroupTeamScheduleShift.md)
Delete a shift from the schedule.

### [Remove-MgGroupTeamScheduleSwapShiftChangeRequest](Remove-MgGroupTeamScheduleSwapShiftChangeRequest.md)
Delete navigation property swapShiftsChangeRequests for groups

### [Remove-MgGroupTeamScheduleTimeOff](Remove-MgGroupTeamScheduleTimeOff.md)
Delete a timeOff instance from a schedule.

### [Remove-MgGroupTeamScheduleTimeOffReason](Remove-MgGroupTeamScheduleTimeOffReason.md)
Mark a timeOffReason as inactive by setting the isActive property.
Every team must include at least one timeoff reason.
This method doesn't remove the specified timeOffReason instance.
timeOffItem instances that have been assigned this reason remain assigned to this reason.

### [Remove-MgGroupTeamScheduleTimeOffRequest](Remove-MgGroupTeamScheduleTimeOffRequest.md)
Delete a timeOffRequest object.

### [Remove-MgGroupTeamTag](Remove-MgGroupTeamTag.md)
Delete a tag object permanently.

### [Remove-MgGroupTeamTagMember](Remove-MgGroupTeamTagMember.md)
Delete a member from a standard tag in a team.

### [Remove-MgTeam](Remove-MgTeam.md)
Delete entity from teams

### [Remove-MgTeamChannel](Remove-MgTeamChannel.md)
Delete the channel.

### [Remove-MgTeamChannelEmail](Remove-MgTeamChannelEmail.md)
Remove the email address of a channel.
You can remove an email address only if it was provisioned using the provisionEmail method or through the Microsoft Teams client.

### [Remove-MgTeamChannelMember](Remove-MgTeamChannelMember.md)
Delete a conversationMember from a channel.

### [Remove-MgTeamChannelMessageReplyHostedContent](Remove-MgTeamChannelMessageReplyHostedContent.md)
Delete navigation property hostedContents for teams

### [Remove-MgTeamChannelSharedWithTeam](Remove-MgTeamChannelSharedWithTeam.md)
Unshare a channel with a team by deleting the corresponding sharedWithChannelTeamInfo resource.
This operation is allowed only for channels with a membershipType value of shared.

### [Remove-MgTeamChannelTab](Remove-MgTeamChannelTab.md)
Removes (unpins) a tab from the specified channel within a team.

### [Remove-MgTeamInstalledApp](Remove-MgTeamInstalledApp.md)
Uninstalls an app from the specified team.

### [Remove-MgTeamMember](Remove-MgTeamMember.md)
Remove a conversationMember from a team.

### [Remove-MgTeamOperation](Remove-MgTeamOperation.md)
Delete navigation property operations for teams

### [Remove-MgTeamPermissionGrant](Remove-MgTeamPermissionGrant.md)
Delete navigation property permissionGrants for teams

### [Remove-MgTeamPrimaryChannel](Remove-MgTeamPrimaryChannel.md)
Delete navigation property primaryChannel for teams

### [Remove-MgTeamPrimaryChannelEmail](Remove-MgTeamPrimaryChannelEmail.md)
Remove the email address of a channel.
You can remove an email address only if it was provisioned using the provisionEmail method or through the Microsoft Teams client.

### [Remove-MgTeamPrimaryChannelMember](Remove-MgTeamPrimaryChannelMember.md)
Delete a conversationMember from a channel.

### [Remove-MgTeamPrimaryChannelMessageReplyHostedContent](Remove-MgTeamPrimaryChannelMessageReplyHostedContent.md)
Delete navigation property hostedContents for teams

### [Remove-MgTeamPrimaryChannelSharedWithTeam](Remove-MgTeamPrimaryChannelSharedWithTeam.md)
Unshare a channel with a team by deleting the corresponding sharedWithChannelTeamInfo resource.
This operation is allowed only for channels with a membershipType value of shared.

### [Remove-MgTeamPrimaryChannelTab](Remove-MgTeamPrimaryChannelTab.md)
Removes (unpins) a tab from the specified channel within a team.

### [Remove-MgTeamSchedule](Remove-MgTeamSchedule.md)
Delete navigation property schedule for teams

### [Remove-MgTeamScheduleOfferShiftRequest](Remove-MgTeamScheduleOfferShiftRequest.md)
Delete navigation property offerShiftRequests for teams

### [Remove-MgTeamScheduleOpenShift](Remove-MgTeamScheduleOpenShift.md)
Delete an openShift object.

### [Remove-MgTeamScheduleOpenShiftChangeRequest](Remove-MgTeamScheduleOpenShiftChangeRequest.md)
Delete navigation property openShiftChangeRequests for teams

### [Remove-MgTeamScheduleSchedulingGroup](Remove-MgTeamScheduleSchedulingGroup.md)
Mark a schedulingGroup as inactive by setting its isActive property.\nThis method does not remove the schedulingGroup from the schedule.
Existing shift instances assigned to the scheduling group remain part of the group.

### [Remove-MgTeamScheduleShift](Remove-MgTeamScheduleShift.md)
Delete a shift from the schedule.

### [Remove-MgTeamScheduleSwapShiftChangeRequest](Remove-MgTeamScheduleSwapShiftChangeRequest.md)
Delete navigation property swapShiftsChangeRequests for teams

### [Remove-MgTeamScheduleTimeOff](Remove-MgTeamScheduleTimeOff.md)
Delete a timeOff instance from a schedule.

### [Remove-MgTeamScheduleTimeOffReason](Remove-MgTeamScheduleTimeOffReason.md)
Mark a timeOffReason as inactive by setting the isActive property.
Every team must include at least one timeoff reason.
This method doesn't remove the specified timeOffReason instance.
timeOffItem instances that have been assigned this reason remain assigned to this reason.

### [Remove-MgTeamScheduleTimeOffRequest](Remove-MgTeamScheduleTimeOffRequest.md)
Delete a timeOffRequest object.

### [Remove-MgTeamTag](Remove-MgTeamTag.md)
Delete a tag object permanently.

### [Remove-MgTeamTagMember](Remove-MgTeamTagMember.md)
Delete a member from a standard tag in a team.

### [Remove-MgTeamworkDeletedTeam](Remove-MgTeamworkDeletedTeam.md)
Delete navigation property deletedTeams for teamwork

### [Remove-MgTeamworkDeletedTeamChannel](Remove-MgTeamworkDeletedTeamChannel.md)
Delete navigation property channels for teamwork

### [Remove-MgTeamworkDeletedTeamChannelEmail](Remove-MgTeamworkDeletedTeamChannelEmail.md)
Remove the email address of a channel.
You can remove an email address only if it was provisioned using the provisionEmail method or through the Microsoft Teams client.

### [Remove-MgTeamworkDeletedTeamChannelMember](Remove-MgTeamworkDeletedTeamChannelMember.md)
Delete a conversationMember from a channel.

### [Remove-MgTeamworkDeletedTeamChannelMessage](Remove-MgTeamworkDeletedTeamChannelMessage.md)
Delete navigation property messages for teamwork

### [Remove-MgTeamworkDeletedTeamChannelMessageHostedContent](Remove-MgTeamworkDeletedTeamChannelMessageHostedContent.md)
Delete navigation property hostedContents for teamwork

### [Remove-MgTeamworkDeletedTeamChannelMessageReply](Remove-MgTeamworkDeletedTeamChannelMessageReply.md)
Delete navigation property replies for teamwork

### [Remove-MgTeamworkDeletedTeamChannelMessageReplyHostedContent](Remove-MgTeamworkDeletedTeamChannelMessageReplyHostedContent.md)
Delete navigation property hostedContents for teamwork

### [Remove-MgTeamworkDeletedTeamChannelSharedWithTeam](Remove-MgTeamworkDeletedTeamChannelSharedWithTeam.md)
Unshare a channel with a team by deleting the corresponding sharedWithChannelTeamInfo resource.
This operation is allowed only for channels with a membershipType value of shared.

### [Remove-MgTeamworkDeletedTeamChannelTab](Remove-MgTeamworkDeletedTeamChannelTab.md)
Removes (unpins) a tab from the specified channel within a team.

### [Remove-MgTeamworkTeamAppSetting](Remove-MgTeamworkTeamAppSetting.md)
Delete navigation property teamsAppSettings for teamwork

### [Remove-MgTeamworkWorkforceIntegration](Remove-MgTeamworkWorkforceIntegration.md)
Delete an instance of a workforceIntegration.

### [Remove-MgUserChat](Remove-MgUserChat.md)
Delete navigation property chats for users

### [Remove-MgUserChatInstalledApp](Remove-MgUserChatInstalledApp.md)
Uninstall an app installed within a chat.

### [Remove-MgUserChatLastMessagePreview](Remove-MgUserChatLastMessagePreview.md)
Delete navigation property lastMessagePreview for users

### [Remove-MgUserChatMember](Remove-MgUserChatMember.md)
Remove a conversationMember from a chat.

### [Remove-MgUserChatMessage](Remove-MgUserChatMessage.md)
Delete navigation property messages for users

### [Remove-MgUserChatMessageHostedContent](Remove-MgUserChatMessageHostedContent.md)
Delete navigation property hostedContents for users

### [Remove-MgUserChatMessageReply](Remove-MgUserChatMessageReply.md)
Delete navigation property replies for users

### [Remove-MgUserChatMessageReplyHostedContent](Remove-MgUserChatMessageReplyHostedContent.md)
Delete navigation property hostedContents for users

### [Remove-MgUserChatPermissionGrant](Remove-MgUserChatPermissionGrant.md)
Delete navigation property permissionGrants for users

### [Remove-MgUserChatPinnedMessage](Remove-MgUserChatPinnedMessage.md)
Unpin a message from a chat.

### [Remove-MgUserChatTab](Remove-MgUserChatTab.md)
Remove (unpin) a tab from the specified chat.

### [Remove-MgUserTeamwork](Remove-MgUserTeamwork.md)
Delete navigation property teamwork for users

### [Remove-MgUserTeamworkAssociatedTeam](Remove-MgUserTeamworkAssociatedTeam.md)
Delete navigation property associatedTeams for users

### [Remove-MgUserTeamworkInstalledApp](Remove-MgUserTeamworkInstalledApp.md)
Uninstall an app from the personal scope of the specified user.

### [Send-MgChatActivityNotification](Send-MgChatActivityNotification.md)
Send an activity feed notification in scope of a chat.
For more information about sending notifications and the requirements for doing so, see sending Teams activity notifications.

### [Send-MgTeamActivityNotification](Send-MgTeamActivityNotification.md)
Send an activity feed notification in the scope of a team.
For more information about sending notifications and the requirements for doing so, see\nsending Teams activity notifications.

### [Send-MgTeamworkActivityNotificationToRecipient](Send-MgTeamworkActivityNotificationToRecipient.md)
Send activity feed notifications to multiple users, in bulk.
For more information, see sending Teams activity notifications.

### [Set-MgChatMessageHostedContent](Set-MgChatMessageHostedContent.md)
Update media content for the navigation property hostedContents in chats

### [Set-MgChatMessageReaction](Set-MgChatMessageReaction.md)
Invoke action setReaction

### [Set-MgChatMessageReplyHostedContent](Set-MgChatMessageReplyHostedContent.md)
Update media content for the navigation property hostedContents in chats

### [Set-MgChatMessageReplyReaction](Set-MgChatMessageReplyReaction.md)
Invoke action setReaction

### [Set-MgGroupTeam](Set-MgGroupTeam.md)
Update the navigation property team in groups

### [Set-MgGroupTeamChannelFileFolderContent](Set-MgGroupTeamChannelFileFolderContent.md)
The content stream, if the item represents a file.

### [Set-MgGroupTeamChannelMessageHostedContent](Set-MgGroupTeamChannelMessageHostedContent.md)
Update media content for the navigation property hostedContents in groups

### [Set-MgGroupTeamChannelMessageReplyHostedContent](Set-MgGroupTeamChannelMessageReplyHostedContent.md)
Update media content for the navigation property hostedContents in groups

### [Set-MgGroupTeamPhotoContent](Set-MgGroupTeamPhotoContent.md)
Update media content for the navigation property photo in groups

### [Set-MgGroupTeamPrimaryChannelFileFolderContent](Set-MgGroupTeamPrimaryChannelFileFolderContent.md)
The content stream, if the item represents a file.

### [Set-MgGroupTeamPrimaryChannelMessageHostedContent](Set-MgGroupTeamPrimaryChannelMessageHostedContent.md)
Update media content for the navigation property hostedContents in groups

### [Set-MgGroupTeamPrimaryChannelMessageReplyHostedContent](Set-MgGroupTeamPrimaryChannelMessageReplyHostedContent.md)
Update media content for the navigation property hostedContents in groups

### [Set-MgGroupTeamSchedule](Set-MgGroupTeamSchedule.md)
Update the navigation property schedule in groups

### [Set-MgTeamChannelFileFolderContent](Set-MgTeamChannelFileFolderContent.md)
The content stream, if the item represents a file.

### [Set-MgTeamChannelMessageHostedContent](Set-MgTeamChannelMessageHostedContent.md)
Update media content for the navigation property hostedContents in teams

### [Set-MgTeamChannelMessageReaction](Set-MgTeamChannelMessageReaction.md)
Invoke action setReaction

### [Set-MgTeamChannelMessageReplyHostedContent](Set-MgTeamChannelMessageReplyHostedContent.md)
Update media content for the navigation property hostedContents in teams

### [Set-MgTeamChannelMessageReplyReaction](Set-MgTeamChannelMessageReplyReaction.md)
Invoke action setReaction

### [Set-MgTeamPhotoContent](Set-MgTeamPhotoContent.md)
Update media content for the navigation property photo in teams

### [Set-MgTeamPrimaryChannelFileFolderContent](Set-MgTeamPrimaryChannelFileFolderContent.md)
The content stream, if the item represents a file.

### [Set-MgTeamPrimaryChannelMessageHostedContent](Set-MgTeamPrimaryChannelMessageHostedContent.md)
Update media content for the navigation property hostedContents in teams

### [Set-MgTeamPrimaryChannelMessageReaction](Set-MgTeamPrimaryChannelMessageReaction.md)
Invoke action setReaction

### [Set-MgTeamPrimaryChannelMessageReplyHostedContent](Set-MgTeamPrimaryChannelMessageReplyHostedContent.md)
Update media content for the navigation property hostedContents in teams

### [Set-MgTeamPrimaryChannelMessageReplyReaction](Set-MgTeamPrimaryChannelMessageReplyReaction.md)
Invoke action setReaction

### [Set-MgTeamSchedule](Set-MgTeamSchedule.md)
Update the navigation property schedule in teams

### [Set-MgTeamworkDeletedTeamChannelFileFolderContent](Set-MgTeamworkDeletedTeamChannelFileFolderContent.md)
The content stream, if the item represents a file.

### [Set-MgTeamworkDeletedTeamChannelMessageHostedContent](Set-MgTeamworkDeletedTeamChannelMessageHostedContent.md)
Update media content for the navigation property hostedContents in teamwork

### [Set-MgTeamworkDeletedTeamChannelMessageReaction](Set-MgTeamworkDeletedTeamChannelMessageReaction.md)
Invoke action setReaction

### [Set-MgTeamworkDeletedTeamChannelMessageReplyHostedContent](Set-MgTeamworkDeletedTeamChannelMessageReplyHostedContent.md)
Update media content for the navigation property hostedContents in teamwork

### [Set-MgTeamworkDeletedTeamChannelMessageReplyReaction](Set-MgTeamworkDeletedTeamChannelMessageReplyReaction.md)
Invoke action setReaction

### [Set-MgUserChatMessageHostedContent](Set-MgUserChatMessageHostedContent.md)
Update media content for the navigation property hostedContents in users

### [Set-MgUserChatMessageReplyHostedContent](Set-MgUserChatMessageReplyHostedContent.md)
Update media content for the navigation property hostedContents in users

### [Undo-MgChatMessageReplySoftDelete](Undo-MgChatMessageReplySoftDelete.md)
Undo soft deletion of a single chatMessage or a chat message reply in a channel or a chat.

### [Undo-MgChatMessageSoftDelete](Undo-MgChatMessageSoftDelete.md)
Undo soft deletion of a single chatMessage or a chat message reply in a channel or a chat.

### [Undo-MgTeamChannelMessageReplySoftDelete](Undo-MgTeamChannelMessageReplySoftDelete.md)
Undo soft deletion of a single chatMessage or a chat message reply in a channel or a chat.

### [Undo-MgTeamChannelMessageSoftDelete](Undo-MgTeamChannelMessageSoftDelete.md)
Undo soft deletion of a single chatMessage or a chat message reply in a channel or a chat.

### [Undo-MgTeamPrimaryChannelMessageReplySoftDelete](Undo-MgTeamPrimaryChannelMessageReplySoftDelete.md)
Undo soft deletion of a single chatMessage or a chat message reply in a channel or a chat.

### [Undo-MgTeamPrimaryChannelMessageSoftDelete](Undo-MgTeamPrimaryChannelMessageSoftDelete.md)
Undo soft deletion of a single chatMessage or a chat message reply in a channel or a chat.

### [Undo-MgTeamworkDeletedTeamChannelMessageReplySoftDelete](Undo-MgTeamworkDeletedTeamChannelMessageReplySoftDelete.md)
Undo soft deletion of a single chatMessage or a chat message reply in a channel or a chat.

### [Undo-MgTeamworkDeletedTeamChannelMessageSoftDelete](Undo-MgTeamworkDeletedTeamChannelMessageSoftDelete.md)
Undo soft deletion of a single chatMessage or a chat message reply in a channel or a chat.

### [Update-MgAppCatalogTeamApp](Update-MgAppCatalogTeamApp.md)
Update the navigation property teamsApps in appCatalogs

### [Update-MgAppCatalogTeamAppDefinition](Update-MgAppCatalogTeamAppDefinition.md)
Publish an app to the Microsoft Teams app catalog.\nSpecifically, this API publishes the app to your organization's catalog (the tenant app catalog);\nthe created resource has a distributionMethod property value of organization.
The requiresReview property allows any user to submit an app for review by an administrator.
Admins can approve or reject these apps via this API or the Microsoft Teams admin center.

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

### [Update-MgChatPermissionGrant](Update-MgChatPermissionGrant.md)
Update the navigation property permissionGrants in chats

### [Update-MgChatPinnedMessage](Update-MgChatPinnedMessage.md)
Update the navigation property pinnedMessages in chats

### [Update-MgChatTab](Update-MgChatTab.md)
Update the properties of the specified tab in a chat.
\nThis can be used to configure the content of the tab.

### [Update-MgGroupTeamChannel](Update-MgGroupTeamChannel.md)
Update the properties of the specified channel.

### [Update-MgGroupTeamChannelMember](Update-MgGroupTeamChannelMember.md)
Update the role of a conversationMember in a channel.
This operation is allowed only for channels with a membershipType value of private or shared.

### [Update-MgGroupTeamChannelMessage](Update-MgGroupTeamChannelMessage.md)
Update a chatMessage object.
\nWith the exception of the policyViolation property, all properties of a chatMessage can be updated in delegated permissions scenarios.\nOnly the policyViolation property of a chatMessage can be updated in application permissions scenarios.
The update only works for chats where members are Microsoft Teams users.
If one of the participants is using Skype, the operation will fail.
This method does not support federation.
Only the user in the tenant who sent the message can perform data loss prevention (DLP) updates on the specified chat message.

### [Update-MgGroupTeamChannelMessageHostedContent](Update-MgGroupTeamChannelMessageHostedContent.md)
Update the navigation property hostedContents in groups

### [Update-MgGroupTeamChannelMessageReply](Update-MgGroupTeamChannelMessageReply.md)
Update the navigation property replies in groups

### [Update-MgGroupTeamChannelMessageReplyHostedContent](Update-MgGroupTeamChannelMessageReplyHostedContent.md)
Update the navigation property hostedContents in groups

### [Update-MgGroupTeamChannelSharedWithTeam](Update-MgGroupTeamChannelSharedWithTeam.md)
Update the navigation property sharedWithTeams in groups

### [Update-MgGroupTeamChannelTab](Update-MgGroupTeamChannelTab.md)
Update the properties of the specified tab.\nThis can be used to configure the content of the tab.

### [Update-MgGroupTeamMember](Update-MgGroupTeamMember.md)
Update the role of a conversationMember in a team.

### [Update-MgGroupTeamOperation](Update-MgGroupTeamOperation.md)
Update the navigation property operations in groups

### [Update-MgGroupTeamPermissionGrant](Update-MgGroupTeamPermissionGrant.md)
Update the navigation property permissionGrants in groups

### [Update-MgGroupTeamPhoto](Update-MgGroupTeamPhoto.md)
Update the navigation property photo in groups

### [Update-MgGroupTeamPrimaryChannel](Update-MgGroupTeamPrimaryChannel.md)
Update the navigation property primaryChannel in groups

### [Update-MgGroupTeamPrimaryChannelMember](Update-MgGroupTeamPrimaryChannelMember.md)
Update the role of a conversationMember in a channel.
This operation is allowed only for channels with a membershipType value of private or shared.

### [Update-MgGroupTeamPrimaryChannelMessage](Update-MgGroupTeamPrimaryChannelMessage.md)
Update a chatMessage object.
\nWith the exception of the policyViolation property, all properties of a chatMessage can be updated in delegated permissions scenarios.\nOnly the policyViolation property of a chatMessage can be updated in application permissions scenarios.
The update only works for chats where members are Microsoft Teams users.
If one of the participants is using Skype, the operation will fail.
This method does not support federation.
Only the user in the tenant who sent the message can perform data loss prevention (DLP) updates on the specified chat message.

### [Update-MgGroupTeamPrimaryChannelMessageHostedContent](Update-MgGroupTeamPrimaryChannelMessageHostedContent.md)
Update the navigation property hostedContents in groups

### [Update-MgGroupTeamPrimaryChannelMessageReply](Update-MgGroupTeamPrimaryChannelMessageReply.md)
Update the navigation property replies in groups

### [Update-MgGroupTeamPrimaryChannelMessageReplyHostedContent](Update-MgGroupTeamPrimaryChannelMessageReplyHostedContent.md)
Update the navigation property hostedContents in groups

### [Update-MgGroupTeamPrimaryChannelSharedWithTeam](Update-MgGroupTeamPrimaryChannelSharedWithTeam.md)
Update the navigation property sharedWithTeams in groups

### [Update-MgGroupTeamPrimaryChannelTab](Update-MgGroupTeamPrimaryChannelTab.md)
Update the properties of the specified tab.\nThis can be used to configure the content of the tab.

### [Update-MgGroupTeamScheduleOfferShiftRequest](Update-MgGroupTeamScheduleOfferShiftRequest.md)
Update the navigation property offerShiftRequests in groups

### [Update-MgGroupTeamScheduleOpenShift](Update-MgGroupTeamScheduleOpenShift.md)
Update the properties of an openShift object.

### [Update-MgGroupTeamScheduleOpenShiftChangeRequest](Update-MgGroupTeamScheduleOpenShiftChangeRequest.md)
Update the navigation property openShiftChangeRequests in groups

### [Update-MgGroupTeamScheduleSchedulingGroup](Update-MgGroupTeamScheduleSchedulingGroup.md)
Replace an existing schedulingGroup.
If the specified schedulingGroup doesn't exist, this method returns 404 Not found.

### [Update-MgGroupTeamScheduleShift](Update-MgGroupTeamScheduleShift.md)
Replace an existing shift.
If the specified shift doesn't exist, this method returns 404 Not found.
The duration of a shift can't be less than 1 minute or longer than 24 hours.

### [Update-MgGroupTeamScheduleSwapShiftChangeRequest](Update-MgGroupTeamScheduleSwapShiftChangeRequest.md)
Update the navigation property swapShiftsChangeRequests in groups

### [Update-MgGroupTeamScheduleTimeOff](Update-MgGroupTeamScheduleTimeOff.md)
Replace an existing timeOff object.
If the specified timeOff object doesn't exist, this method returns 404 Not found.

### [Update-MgGroupTeamScheduleTimeOffReason](Update-MgGroupTeamScheduleTimeOffReason.md)
Replace an existing timeOffReason.
If the specified timeOffReason doesn't exist, this method returns 404 Not found.

### [Update-MgGroupTeamScheduleTimeOffRequest](Update-MgGroupTeamScheduleTimeOffRequest.md)
Update the navigation property timeOffRequests in groups

### [Update-MgGroupTeamTag](Update-MgGroupTeamTag.md)
Update the properties of a tag object.

### [Update-MgGroupTeamTagMember](Update-MgGroupTeamTagMember.md)
Update the navigation property members in groups

### [Update-MgTeam](Update-MgTeam.md)
Update the properties of the specified team.

### [Update-MgTeamChannel](Update-MgTeamChannel.md)
Update the properties of the specified channel.

### [Update-MgTeamChannelMember](Update-MgTeamChannelMember.md)
Update the role of a conversationMember in a channel.
This operation is allowed only for channels with a membershipType value of private or shared.

### [Update-MgTeamChannelMessage](Update-MgTeamChannelMessage.md)
Update a chatMessage object.
\nWith the exception of the policyViolation property, all properties of a chatMessage can be updated in delegated permissions scenarios.\nOnly the policyViolation property of a chatMessage can be updated in application permissions scenarios.
The update only works for chats where members are Microsoft Teams users.
If one of the participants is using Skype, the operation will fail.
This method does not support federation.
Only the user in the tenant who sent the message can perform data loss prevention (DLP) updates on the specified chat message.

### [Update-MgTeamChannelMessageReply](Update-MgTeamChannelMessageReply.md)
Update the navigation property replies in teams

### [Update-MgTeamChannelMessageReplyHostedContent](Update-MgTeamChannelMessageReplyHostedContent.md)
Update the navigation property hostedContents in teams

### [Update-MgTeamChannelSharedWithTeam](Update-MgTeamChannelSharedWithTeam.md)
Update the navigation property sharedWithTeams in teams

### [Update-MgTeamChannelTab](Update-MgTeamChannelTab.md)
Update the properties of the specified tab.\nThis can be used to configure the content of the tab.

### [Update-MgTeamInstalledApp](Update-MgTeamInstalledApp.md)
Upgrade an app installation within a chat.

### [Update-MgTeamMember](Update-MgTeamMember.md)
Update the role of a conversationMember in a team.

### [Update-MgTeamOperation](Update-MgTeamOperation.md)
Update the navigation property operations in teams

### [Update-MgTeamPermissionGrant](Update-MgTeamPermissionGrant.md)
Update the navigation property permissionGrants in teams

### [Update-MgTeamPhoto](Update-MgTeamPhoto.md)
Update the navigation property photo in teams

### [Update-MgTeamPrimaryChannel](Update-MgTeamPrimaryChannel.md)
Update the navigation property primaryChannel in teams

### [Update-MgTeamPrimaryChannelMember](Update-MgTeamPrimaryChannelMember.md)
Update the role of a conversationMember in a channel.
This operation is allowed only for channels with a membershipType value of private or shared.

### [Update-MgTeamPrimaryChannelMessage](Update-MgTeamPrimaryChannelMessage.md)
Update a chatMessage object.
\nWith the exception of the policyViolation property, all properties of a chatMessage can be updated in delegated permissions scenarios.\nOnly the policyViolation property of a chatMessage can be updated in application permissions scenarios.
The update only works for chats where members are Microsoft Teams users.
If one of the participants is using Skype, the operation will fail.
This method does not support federation.
Only the user in the tenant who sent the message can perform data loss prevention (DLP) updates on the specified chat message.

### [Update-MgTeamPrimaryChannelMessageReply](Update-MgTeamPrimaryChannelMessageReply.md)
Update the navigation property replies in teams

### [Update-MgTeamPrimaryChannelMessageReplyHostedContent](Update-MgTeamPrimaryChannelMessageReplyHostedContent.md)
Update the navigation property hostedContents in teams

### [Update-MgTeamPrimaryChannelSharedWithTeam](Update-MgTeamPrimaryChannelSharedWithTeam.md)
Update the navigation property sharedWithTeams in teams

### [Update-MgTeamPrimaryChannelTab](Update-MgTeamPrimaryChannelTab.md)
Update the properties of the specified tab.\nThis can be used to configure the content of the tab.

### [Update-MgTeamScheduleOfferShiftRequest](Update-MgTeamScheduleOfferShiftRequest.md)
Update the navigation property offerShiftRequests in teams

### [Update-MgTeamScheduleOpenShift](Update-MgTeamScheduleOpenShift.md)
Update the properties of an openShift object.

### [Update-MgTeamScheduleOpenShiftChangeRequest](Update-MgTeamScheduleOpenShiftChangeRequest.md)
Update the navigation property openShiftChangeRequests in teams

### [Update-MgTeamScheduleSchedulingGroup](Update-MgTeamScheduleSchedulingGroup.md)
Replace an existing schedulingGroup.
If the specified schedulingGroup doesn't exist, this method returns 404 Not found.

### [Update-MgTeamScheduleShift](Update-MgTeamScheduleShift.md)
Replace an existing shift.
If the specified shift doesn't exist, this method returns 404 Not found.
The duration of a shift can't be less than 1 minute or longer than 24 hours.

### [Update-MgTeamScheduleSwapShiftChangeRequest](Update-MgTeamScheduleSwapShiftChangeRequest.md)
Update the navigation property swapShiftsChangeRequests in teams

### [Update-MgTeamScheduleTimeOff](Update-MgTeamScheduleTimeOff.md)
Replace an existing timeOff object.
If the specified timeOff object doesn't exist, this method returns 404 Not found.

### [Update-MgTeamScheduleTimeOffReason](Update-MgTeamScheduleTimeOffReason.md)
Replace an existing timeOffReason.
If the specified timeOffReason doesn't exist, this method returns 404 Not found.

### [Update-MgTeamScheduleTimeOffRequest](Update-MgTeamScheduleTimeOffRequest.md)
Update the navigation property timeOffRequests in teams

### [Update-MgTeamTag](Update-MgTeamTag.md)
Update the properties of a tag object.

### [Update-MgTeamTagMember](Update-MgTeamTagMember.md)
Update the navigation property members in teams

### [Update-MgTeamwork](Update-MgTeamwork.md)
Update teamwork

### [Update-MgTeamworkDeletedTeam](Update-MgTeamworkDeletedTeam.md)
Update the navigation property deletedTeams in teamwork

### [Update-MgTeamworkDeletedTeamChannel](Update-MgTeamworkDeletedTeamChannel.md)
Update the navigation property channels in teamwork

### [Update-MgTeamworkDeletedTeamChannelMember](Update-MgTeamworkDeletedTeamChannelMember.md)
Update the role of a conversationMember in a channel.
This operation is allowed only for channels with a membershipType value of private or shared.

### [Update-MgTeamworkDeletedTeamChannelMessage](Update-MgTeamworkDeletedTeamChannelMessage.md)
Update a chatMessage object.
\nWith the exception of the policyViolation property, all properties of a chatMessage can be updated in delegated permissions scenarios.\nOnly the policyViolation property of a chatMessage can be updated in application permissions scenarios.
The update only works for chats where members are Microsoft Teams users.
If one of the participants is using Skype, the operation will fail.
This method does not support federation.
Only the user in the tenant who sent the message can perform data loss prevention (DLP) updates on the specified chat message.

### [Update-MgTeamworkDeletedTeamChannelMessageHostedContent](Update-MgTeamworkDeletedTeamChannelMessageHostedContent.md)
Update the navigation property hostedContents in teamwork

### [Update-MgTeamworkDeletedTeamChannelMessageReply](Update-MgTeamworkDeletedTeamChannelMessageReply.md)
Update the navigation property replies in teamwork

### [Update-MgTeamworkDeletedTeamChannelMessageReplyHostedContent](Update-MgTeamworkDeletedTeamChannelMessageReplyHostedContent.md)
Update the navigation property hostedContents in teamwork

### [Update-MgTeamworkDeletedTeamChannelSharedWithTeam](Update-MgTeamworkDeletedTeamChannelSharedWithTeam.md)
Update the navigation property sharedWithTeams in teamwork

### [Update-MgTeamworkDeletedTeamChannelTab](Update-MgTeamworkDeletedTeamChannelTab.md)
Update the properties of the specified tab.\nThis can be used to configure the content of the tab.

### [Update-MgTeamworkTeamAppSetting](Update-MgTeamworkTeamAppSetting.md)
Update the tenant-wide teamsAppSettings for all Teams apps in the tenant.

### [Update-MgTeamworkWorkforceIntegration](Update-MgTeamworkWorkforceIntegration.md)
Update the properties of a workforceIntegration object.

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

### [Update-MgUserChatPermissionGrant](Update-MgUserChatPermissionGrant.md)
Update the navigation property permissionGrants in users

### [Update-MgUserChatPinnedMessage](Update-MgUserChatPinnedMessage.md)
Update the navigation property pinnedMessages in users

### [Update-MgUserChatTab](Update-MgUserChatTab.md)
Update the properties of the specified tab in a chat.
\nThis can be used to configure the content of the tab.

### [Update-MgUserTeamwork](Update-MgUserTeamwork.md)
Update the navigation property teamwork in users

### [Update-MgUserTeamworkAssociatedTeam](Update-MgUserTeamworkAssociatedTeam.md)
Update the navigation property associatedTeams in users

