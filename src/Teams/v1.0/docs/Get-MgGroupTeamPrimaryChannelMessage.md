---
external help file:
Module Name: Microsoft.Graph.Teams
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.teams/get-mggroupteamprimarychannelmessage
schema: 2.0.0
---

# Get-MgGroupTeamPrimaryChannelMessage

## SYNOPSIS
Retrieve a single message or a message reply in a channel or a chat.

## SYNTAX

### List (Default)
```
Get-MgGroupTeamPrimaryChannelMessage -GroupId <String> [-ExpandProperty <String[]>] [-Filter <String>]
 [-Property <String[]>] [-Search <String>] [-Skip <Int32>] [-Sort <String[]>] [-Top <Int32>] [-All]
 [-CountVariable <String>] [-PageSize <Int32>] [<CommonParameters>]
```

### Get
```
Get-MgGroupTeamPrimaryChannelMessage -ChatMessageId <String> -GroupId <String> [-ExpandProperty <String[]>]
 [-Property <String[]>] [<CommonParameters>]
```

### GetViaIdentity
```
Get-MgGroupTeamPrimaryChannelMessage -InputObject <ITeamsIdentity> [-ExpandProperty <String[]>]
 [-Property <String[]>] [<CommonParameters>]
```

## DESCRIPTION
Retrieve a single message or a message reply in a channel or a chat.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Import-Module Microsoft.Graph.Teams
```

$params = @{
	policyViolation = @{
		policyTip = @{
			generalText = "This item has been blocked by the administrator."
			complianceUrl = "https://contoso.com/dlp-policy-page"
			matchedConditionDescriptions = @(
				"Credit Card Number"
			)
		}
		verdictDetails = "AllowOverrideWithoutJustification,AllowFalsePositiveOverride"
		dlpAction = "BlockAccess"
	}
}

Update-MgTeamChannelMessage -TeamId $teamId -ChannelId $channelId -ChatMessageId $chatMessageId -BodyParameter $params

### -------------------------- EXAMPLE 2 --------------------------
```powershell
Import-Module Microsoft.Graph.Teams
```

$params = @{
	messageType = "message"
	subject = $null
	summary = $null
	importance = "normal"
	locale = "en-us"
	from = @{
		application = $null
		device = $null
		user = @{
			id = "3b102402-813e-4e17-a6b2-f841aef1fdfc"
			displayName = "Lam Cong"
			userIdentityType = "aadUser"
		}
		conversation = $null
	}
	body = @{
		contentType = "text"
		content = "Edit text only"
	}
	attachments = @(
	)
	mentions = @(
	)
	reactions = @(
	)
}

Update-MgTeamChannelMessage -TeamId $teamId -ChannelId $channelId -ChatMessageId $chatMessageId -BodyParameter $params

### -------------------------- EXAMPLE 3 --------------------------
```powershell
Import-Module Microsoft.Graph.Teams
```

$params = @{
	messageType = "message"
	deletedDateTime = $null
	subject = $null
	summary = $null
	importance = "normal"
	locale = "en-us"
	from = @{
		application = $null
		device = $null
		conversation = $null
		user = @{
			id = "6b3f3c54-d09c-4fdd-b146-9b514a8a4f40"
			displayName = "Lam Cong"
			userIdentityType = "aadUser"
		}
	}
	body = @{
		contentType = "html"
		content = "&lt;div&gt;&lt;div&gt;
&lt;div&gt;
&lt;div&gt;
&lt;div&gt;
&lt;div&gt;&lt;at id="0"&gt;Raghav&lt;/at&gt;&lt;at id="1"&gt;TestGlobalBot&lt;/at&gt; YEAH"
	}
	attachments = @(
	)
	mentions = @(
		@{
			id = 0
			mentionText = "Raghav"
			mentioned = @{
				application = $null
				device = $null
				conversation = $null
				user = @{
					id = "f1b66449-b46d-49b0-9c3c-53c10234c818e"
					displayName = "Lam Cong"
					userIdentityType = "aadUser"
				}
			}
		}
		@{
			id = 1
			mentionText = "TestGlobalBot"
			mentioned = @{
				application = @{
					id = "03a02232-d8f5-4970-a77e-6e8c76ce7a4e"
					displayName = "TestGlobalBot"
					applicationIdentityType = "bot"
				}
				device = $null
				conversation = $null
				user = $null
			}
		}
	)
	reactions = @(
	)
}

Update-MgTeamChannelMessage -TeamId $teamId -ChannelId $channelId -ChatMessageId $chatMessageId -BodyParameter $params

### -------------------------- EXAMPLE 4 --------------------------
```powershell
Import-Module Microsoft.Graph.Teams
```

$params = @{
	messageType = "message"
	subject = $null
	summary = $null
	importance = "normal"
	locale = "en-us"
	from = @{
		application = $null
		device = $null
		user = @{
			id = "3b102402-813e-4e17-a6b2-f841aef1fdfc"
			displayName = "Lam Cong"
			userIdentityType = "aadUser"
		}
		conversation = $null
	}
	body = @{
		contentType = "html"
		content = "&lt;p&gt;&lt;em&gt;text&lt;/em&gt;&lt;/p&gt;&lt;attachment id="e8f78756199240b88448ae0fc6db112d"&gt;&lt;/attachment&gt;&lt;attachment id="638464e32834471ea202007da60a5ae6"&gt;&lt;/attachment&gt;"
	}
	attachments = @(
		@{
			id = "e8f78756199240b88448ae0fc6db112d"
			contentType = "application/vnd.microsoft.card.hero"
			contentUrl = $null
			content = "{
  "title": "*title*",
  "subtitle": "*subtitle*",
  "text": "Have you found yourself scratching your head trying to figure these questions out? Frustrated trying to access some of the goodies unique to the Microsoft Teams platform?  Well, fear not, Bot Builder SDK Extension for Teams in .NET and Node flavors is here!  Just head on over to Nuget or NPM to download our tasty helpers, sure to speed up your prep time so you can spend more time maximizing the flavor of the bots you're cooking up.Here???s a small sample of some recipes to whet your appetite.",
  "images": [
    {
      "url": "https://us-api.asm.skype.com/v1/objects/0-eus-d8-ced0c9567ee7b0b233b987bd32f9eacd/views/img_preview"
    }
  ],
  "buttons": [
    {
      "type": "openUrl",
      "image": "https://urlp.asm.skype.com/v1/url/content?url=https%3a%2f%2fcdn2.iconfinder.com%2fdata%2ficons%2fsocial-icons-33%2f128%2fTrello-128.png",
      "title": "???????? click me ????????",
      "value": "http://microsoft.com"
    },
    {
      "type": "imback",
      "title": "&amp;i am back&amp; &lt;&gt;= \"",
      "value": "&amp;i am back&amp; &lt;&gt;= \""
    },
    {
      "type": "openUrl",
      "title": "Open URL",
      "value": "http://google.com"
    }
  ]
}"
			name = $null
			thumbnailUrl = $null
		}
		@{
			id = "638464e32834471ea202007da60a5ae6"
			contentType = "application/vnd.microsoft.card.hero"
			contentUrl = $null
			content = "{
  "title": "*title*",
  "subtitle": "*subtitle*",
  "text": "Have you found yourself scratching your head trying to figure these questions out? Frustrated trying to access some of the goodies unique to the Microsoft Teams platform?  Well, fear not, Bot Builder SDK Extension for Teams in .NET and Node flavors is here!  Just head on over to Nuget or NPM to download our tasty helpers, sure to speed up your prep time so you can spend more time maximizing the flavor of the bots you're cooking up.Here???s a small sample of some recipes to whet your appetite.",
  "images": [
    {
      "url": "https://us-api.asm.skype.com/v1/objects/0-eus-d8-ced0c9567ee7b0b233b987bd32f9eacd/views/img_preview"
    }
  ],
  "buttons": [
    {
      "type": "messageBack",
      "title": "&amp;message back&amp; &lt;&gt;= \"",
      "text": "text = &amp;message back&amp; &lt;&gt;= \"",
      "displayText": "displayText = &amp;message back&amp; &lt;&gt;= \"",
      "value": {
        "text": "some text 2"
      }
    }
  ]
}"
			name = $null
			thumbnailUrl = $null
		}
	)
	mentions = @(
	)
	reactions = @(
	)
}

Update-MgTeamChannelMessage -TeamId $teamId -ChannelId $channelId -ChatMessageId $chatMessageId -BodyParameter $params

### -------------------------- EXAMPLE 5 --------------------------
```powershell
Import-Module Microsoft.Graph.Teams
```

$params = @{
	messageType = "message"
	subject = $null
	summary = $null
	importance = "normal"
	locale = "en-us"
	from = @{
		application = $null
		device = $null
		user = @{
			id = "3b102402-813e-4e17-a6b2-f841aef1fdfc"
			displayName = "Lam Cong"
			userIdentityType = "aadUser"
		}
		conversation = $null
	}
	body = @{
		contentType = "html"
		content = "&lt;p&gt;&lt;em&gt;text&lt;/em&gt;&lt;/p&gt;&lt;attachment id="e8f78756199240b88448ae0fc6db112d"&gt;&lt;/attachment&gt;&lt;attachment id="638464e32834471ea202007da60a5ae6"&gt;&lt;/attachment&gt;"
	}
	attachments = @(
		@{
			id = "e8f78756199240b88448ae0fc6db112d"
			contentType = "application/vnd.microsoft.card.hero"
			contentUrl = $null
			content = "{
  "title": "*title*",
  "subtitle": "*subtitle*",
  "text": "Have you found yourself scratching your head trying to figure these questions out? Frustrated trying to access some of the goodies unique to the Microsoft Teams platform?  Well, fear not, Bot Builder SDK Extension for Teams in .NET and Node flavors is here!  Just head on over to Nuget or NPM to download our tasty helpers, sure to speed up your prep time so you can spend more time maximizing the flavor of the bots you're cooking up.Here???s a small sample of some recipes to whet your appetite.",
  "images": [
    {
      "url": "https://us-api.asm.skype.com/v1/objects/0-eus-d8-ced0c9567ee7b0b233b987bd32f9eacd/views/img_preview"
    }
  ],
  "buttons": [
    {
      "type": "openUrl",
      "image": "https://urlp.asm.skype.com/v1/url/content?url=https%3a%2f%2fcdn2.iconfinder.com%2fdata%2ficons%2fsocial-icons-33%2f128%2fTrello-128.png",
      "title": "???????? click me ????????",
      "value": "http://microsoft.com"
    },
    {
      "type": "imback",
      "title": "&amp;i am back&amp; &lt;&gt;= \"",
      "value": "&amp;i am back&amp; &lt;&gt;= \""
    },
    {
      "type": "openUrl",
      "title": "Open URL",
      "value": "http://google.com"
    }
  ]
}"
			name = $null
			thumbnailUrl = $null
		}
		@{
			id = "638464e32834471ea202007da60a5ae6"
			contentType = "application/vnd.microsoft.card.hero"
			contentUrl = $null
			content = "{
  "title": "*title*",
  "subtitle": "*subtitle*",
  "text": "Have you found yourself scratching your head trying to figure these questions out? Frustrated trying to access some of the goodies unique to the Microsoft Teams platform?  Well, fear not, Bot Builder SDK Extension for Teams in .NET and Node flavors is here!  Just head on over to Nuget or NPM to download our tasty helpers, sure to speed up your prep time so you can spend more time maximizing the flavor of the bots you're cooking up.Here???s a small sample of some recipes to whet your appetite.",
  "images": [
    {
      "url": "https://us-api.asm.skype.com/v1/objects/0-eus-d8-ced0c9567ee7b0b233b987bd32f9eacd/views/img_preview"
    }
  ],
  "buttons": [
    {
      "type": "messageBack",
      "title": "&amp;message back&amp; &lt;&gt;= \"",
      "text": "text = &amp;message back&amp; &lt;&gt;= \"",
      "displayText": "displayText = &amp;message back&amp; &lt;&gt;= \"",
      "value": {
        "text": "some text 2"
      }
    }
  ]
}"
			name = $null
			thumbnailUrl = $null
		}
	)
	mentions = @(
	)
	reactions = @(
		@{
			reactionType = "angry"
			createdDateTime = [System.DateTime]::Parse("2018-10-21T08:10:30.489Z")
			user = @{
				application = $null
				device = $null
				user = @{
					id = "f1b66449-b46d-49b0-9c3c-53c10a5c818e"
					displayName = $null
					userIdentityType = "aadUser"
				}
			}
		}
		@{
			reactionType = "laugh"
			createdDateTime = [System.DateTime]::Parse("2018-10-21T08:10:32.489Z")
			user = @{
				application = $null
				device = $null
				user = @{
					id = "03a02232-d8f5-4970-a77e-6e8c76ce7a4e"
					displayName = $null
					userIdentityType = "aadUser"
				}
			}
		}
		@{
			reactionType = "like"
			createdDateTime = [System.DateTime]::Parse("2018-10-21T02:17:14.67Z")
			user = @{
				application = $null
				device = $null
				user = @{
					id = "f1b66449-b46d-49b0-9c3c-53c10a5c818e"
					displayName = $null
					userIdentityType = "aadUser"
				}
			}
		}
		@{
			reactionType = "like"
			createdDateTime = [System.DateTime]::Parse("2018-10-21T02:34:40.3Z")
			user = @{
				application = $null
				device = $null
				user = @{
					id = "4c9041b7-449a-40f7-8855-56da239b9fd1"
					displayName = $null
					userIdentityType = "aadUser"
				}
			}
		}
		@{
			reactionType = "like"
			createdDateTime = [System.DateTime]::Parse("2018-10-21T08:10:25.489Z")
			user = @{
				application = $null
				device = $null
				user = @{
					id = "03a02232-d8f5-4970-a77e-6e8c76ce7a4e"
					displayName = $null
					userIdentityType = "aadUser"
				}
			}
		}
		@{
			reactionType = "heart"
			createdDateTime = [System.DateTime]::Parse("2018-10-21T08:10:31.489Z")
			user = @{
				application = $null
				device = $null
				user = @{
					id = "03a02232-d8f5-4970-a77e-6e8c76ce7a4e"
					displayName = $null
					userIdentityType = "aadUser"
				}
			}
		}
		@{
			reactionType = "sad"
			createdDateTime = [System.DateTime]::Parse("2018-10-21T08:10:33.489Z")
			user = @{
				application = $null
				device = $null
				user = @{
					id = "03a02232-d8f5-4970-a77e-6e8c76ce7a4e"
					displayName = $null
					userIdentityType = "aadUser"
				}
			}
		}
		@{
			reactionType = "surprised"
			createdDateTime = [System.DateTime]::Parse("2018-10-21T08:10:34.489Z")
			user = @{
				application = $null
				device = $null
				user = @{
					id = "03a02232-d8f5-4970-a77e-6e8c76ce7a4e"
					displayName = $null
					userIdentityType = "aadUser"
				}
			}
		}
	)
}

Update-MgTeamChannelMessage -TeamId $teamId -ChannelId $channelId -ChatMessageId $chatMessageId -BodyParameter $params

## PARAMETERS

### -All
List all pages.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: List
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ChatMessageId
The unique identifier of chatMessage

```yaml
Type: System.String
Parameter Sets: Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CountVariable
Specifies a count of the total number of items in a collection.
By default, this variable will be set in the global scope.

```yaml
Type: System.String
Parameter Sets: List
Aliases: CV

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExpandProperty
Expand related entities

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases: Expand

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Filter
Filter items by property values

```yaml
Type: System.String
Parameter Sets: List
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GroupId
The unique identifier of group

```yaml
Type: System.String
Parameter Sets: Get, List
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.ITeamsIdentity
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -PageSize
Sets the page size of results.

```yaml
Type: System.Int32
Parameter Sets: List
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Property
Select properties to be returned

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases: Select

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Search
Search items by search phrases

```yaml
Type: System.String
Parameter Sets: List
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Skip
Skip the first n items

```yaml
Type: System.Int32
Parameter Sets: List
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Sort
Order items by property values

```yaml
Type: System.String[]
Parameter Sets: List
Aliases: OrderBy

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Top
Show only the first n items

```yaml
Type: System.Int32
Parameter Sets: List
Aliases: Limit

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.ITeamsIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphChatMessage

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`INPUTOBJECT <ITeamsIdentity>`: Identity Parameter
  - `[AssociatedTeamInfoId <String>]`: The unique identifier of associatedTeamInfo
  - `[ChannelId <String>]`: The unique identifier of channel
  - `[ChatId <String>]`: The unique identifier of chat
  - `[ChatMessageHostedContentId <String>]`: The unique identifier of chatMessageHostedContent
  - `[ChatMessageId <String>]`: The unique identifier of chatMessage
  - `[ChatMessageId1 <String>]`: The unique identifier of chatMessage
  - `[ConversationMemberId <String>]`: The unique identifier of conversationMember
  - `[DeletedTeamId <String>]`: The unique identifier of deletedTeam
  - `[GroupId <String>]`: The unique identifier of group
  - `[OfferShiftRequestId <String>]`: The unique identifier of offerShiftRequest
  - `[OpenShiftChangeRequestId <String>]`: The unique identifier of openShiftChangeRequest
  - `[OpenShiftId <String>]`: The unique identifier of openShift
  - `[PinnedChatMessageInfoId <String>]`: The unique identifier of pinnedChatMessageInfo
  - `[SchedulingGroupId <String>]`: The unique identifier of schedulingGroup
  - `[SharedWithChannelTeamInfoId <String>]`: The unique identifier of sharedWithChannelTeamInfo
  - `[ShiftId <String>]`: The unique identifier of shift
  - `[SwapShiftsChangeRequestId <String>]`: The unique identifier of swapShiftsChangeRequest
  - `[TeamId <String>]`: The unique identifier of team
  - `[TeamsAppDefinitionId <String>]`: The unique identifier of teamsAppDefinition
  - `[TeamsAppId <String>]`: The unique identifier of teamsApp
  - `[TeamsAppInstallationId <String>]`: The unique identifier of teamsAppInstallation
  - `[TeamsAsyncOperationId <String>]`: The unique identifier of teamsAsyncOperation
  - `[TeamsTabId <String>]`: The unique identifier of teamsTab
  - `[TeamworkTagId <String>]`: The unique identifier of teamworkTag
  - `[TeamworkTagMemberId <String>]`: The unique identifier of teamworkTagMember
  - `[TimeOffId <String>]`: The unique identifier of timeOff
  - `[TimeOffReasonId <String>]`: The unique identifier of timeOffReason
  - `[TimeOffRequestId <String>]`: The unique identifier of timeOffRequest
  - `[UserId <String>]`: The unique identifier of user
  - `[UserScopeTeamsAppInstallationId <String>]`: The unique identifier of userScopeTeamsAppInstallation
  - `[WorkforceIntegrationId <String>]`: The unique identifier of workforceIntegration

## RELATED LINKS

