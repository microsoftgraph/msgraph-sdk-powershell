---
external help file:
Module Name: Microsoft.Graph.Beta.CloudCommunications
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.cloudcommunications/new-mgbetacommunicationcall
schema: 2.0.0
---

# New-MgBetaCommunicationCall

## SYNOPSIS
Create call enables your bot to create a new outgoing peer-to-peer or group call, or join an existing meeting.
You will need to register the calling bot and go through the list of permissions needed.

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaCommunicationCall [-ActiveModalities <String[]>] [-AdditionalProperties <Hashtable>]
 [-AnsweredBy <IMicrosoftGraphParticipantInfo>] [-AudioRoutingGroups <IMicrosoftGraphAudioRoutingGroup[]>]
 [-CallbackUri <String>] [-CallChainId <String>] [-CallOptions <IMicrosoftGraphCallOptions>]
 [-CallRoutes <IMicrosoftGraphCallRoute[]>] [-ChatInfo <IMicrosoftGraphChatInfo>]
 [-ContentSharingSessions <IMicrosoftGraphContentSharingSession[]>] [-Direction <String>] [-Id <String>]
 [-IncomingContext <IMicrosoftGraphIncomingContext>] [-MediaConfig <IMicrosoftGraphMediaConfig>]
 [-MediaState <IMicrosoftGraphCallMediaState>] [-MeetingCapability <IMicrosoftGraphMeetingCapability>]
 [-MeetingInfo <IMicrosoftGraphMeetingInfo>] [-MyParticipantId <String>]
 [-Operations <IMicrosoftGraphCommsOperation[]>] [-Participants <IMicrosoftGraphParticipant[]>]
 [-RequestedModalities <String[]>] [-ResultInfo <IMicrosoftGraphResultInfo>]
 [-RingingTimeoutInSeconds <Int32>] [-RoutingPolicies <String[]>] [-Source <IMicrosoftGraphParticipantInfo>]
 [-State <String>] [-Subject <String>] [-Targets <IMicrosoftGraphInvitationParticipantInfo[]>]
 [-TenantId <String>] [-TerminationReason <String>] [-ToneInfo <IMicrosoftGraphToneInfo>]
 [-Transcription <IMicrosoftGraphCallTranscriptionInfo>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgBetaCommunicationCall -BodyParameter <IMicrosoftGraphCall> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create call enables your bot to create a new outgoing peer-to-peer or group call, or join an existing meeting.
You will need to register the calling bot and go through the list of permissions needed.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
```

$params = @{
	"@odata.type" = "#microsoft.graph.call"
	callbackUri = "https://bot.contoso.com/callback"
	targets = @(
		@{
			"@odata.type" = "#microsoft.graph.invitationParticipantInfo"
			identity = @{
				"@odata.type" = "#microsoft.graph.identitySet"
				user = @{
					"@odata.type" = "#microsoft.graph.identity"
					displayName = "John"
					id = "112f7296-5fa4-42ca-bae8-6a692b15d4b8"
				}
			}
		}
	)
	requestedModalities = @(
		"audio"
	)
	callOptions = @{
		"@odata.type" = "#microsoft.graph.outgoingCallOptions"
		isContentSharingNotificationEnabled = $true
	}
	mediaConfig = @{
		"@odata.type" = "#microsoft.graph.serviceHostedMediaConfig"
	}
}

New-MgBetaCommunicationCall -BodyParameter $params

### -------------------------- EXAMPLE 2 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
```

$params = @{
	"@odata.type" = "#microsoft.graph.call"
	callbackUri = "https://bot.contoso.com/callback"
	source = @{
		"@odata.type" = "#microsoft.graph.participantInfo"
		identity = @{
			"@odata.type" = "#microsoft.graph.identitySet"
			application = @{
				"@odata.type" = "#microsoft.graph.identity"
				displayName = "Calling Bot"
				id = "2891555a-92ff-42e6-80fa-6e1300c6b5c6"
			}
		}
		region = $null
		languageId = $null
	}
	targets = @(
		@{
			"@odata.type" = "#microsoft.graph.invitationParticipantInfo"
			identity = @{
				"@odata.type" = "#microsoft.graph.identitySet"
				user = @{
					"@odata.type" = "#microsoft.graph.identity"
					displayName = "John"
					id = "112f7296-5fa4-42ca-bae8-6a692b15d4b8"
				}
			}
		}
	)
	requestedModalities = @(
		"audio"
	)
	mediaConfig = @{
		"@odata.type" = "#microsoft.graph.appHostedMediaConfig"
		blob = "\<Media Session Configuration\>"
	}
}

New-MgBetaCommunicationCall -BodyParameter $params

### -------------------------- EXAMPLE 3 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
```

$params = @{
	"@odata.type" = "#microsoft.graph.call"
	direction = "outgoing"
	subject = "Create a group call with service hosted media"
	callbackUri = "https://bot.contoso.com/callback"
	source = @{
		"@odata.type" = "#microsoft.graph.participantInfo"
		identity = @{
			"@odata.type" = "#microsoft.graph.identitySet"
			application = @{
				"@odata.type" = "#microsoft.graph.identity"
				displayName = "TestBot"
				id = "dd3885da-f9ab-486b-bfae-85de3d445555"
			}
		}
	}
	targets = @(
		@{
			"@odata.type" = "#microsoft.graph.invitationParticipantInfo"
			identity = @{
				"@odata.type" = "#microsoft.graph.identitySet"
				user = @{
					"@odata.type" = "#microsoft.graph.identity"
					displayName = "user1"
					id = "98da8a1a-1b87-452c-a713-65d3f10b5555"
				}
			}
		}
		@{
			"@odata.type" = "#microsoft.graph.participantInfo"
			identity = @{
				"@odata.type" = "#microsoft.graph.identitySet"
				user = @{
					"@odata.type" = "#microsoft.graph.identity"
					displayName = "user2"
					id = "bf5aae9a-d11d-47a8-93b1-782504c95555"
				}
			}
		}
	)
	requestedModalities = @(
		"audio"
	)
	mediaConfig = @{
		"@odata.type" = "#microsoft.graph.serviceHostedMediaConfig"
		removeFromDefaultAudioGroup = $false
	}
	tenantId = "aa67bd4c-8475-432d-bd41-39f255720e0a"
}

New-MgBetaCommunicationCall -BodyParameter $params

### -------------------------- EXAMPLE 4 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
```

$params = @{
	"@odata.type" = "#microsoft.graph.call"
	direction = "outgoing"
	subject = "Create a group call with app hosted media"
	callbackUri = "https://bot.contoso.com/callback"
	source = @{
		"@odata.type" = "#microsoft.graph.participantInfo"
		identity = @{
			"@odata.type" = "#microsoft.graph.identitySet"
			application = @{
				"@odata.type" = "#microsoft.graph.identity"
				displayName = "TestBot"
				id = "dd3885da-f9ab-486b-bfae-85de3d445555"
			}
		}
	}
	targets = @(
		@{
			"@odata.type" = "#microsoft.graph.invitationParticipantInfo"
			identity = @{
				"@odata.type" = "#microsoft.graph.identitySet"
				user = @{
					"@odata.type" = "#microsoft.graph.identity"
					displayName = "user1"
					id = "98da8a1a-1b87-452c-a713-65d3f10b5555"
				}
			}
		}
		@{
			"@odata.type" = "#microsoft.graph.participantInfo"
			identity = @{
				"@odata.type" = "#microsoft.graph.identitySet"
				user = @{
					"@odata.type" = "#microsoft.graph.identity"
					displayName = "user2"
					id = "bf5aae9a-d11d-47a8-93b1-782504c95555"
				}
			}
		}
	)
	requestedModalities = @(
		"audio"
	)
	mediaConfig = @{
		"@odata.type" = "#microsoft.graph.appHostedMediaConfig"
		blob = "\<Media Session Configuration\>"
		removeFromDefaultAudioGroup = $false
	}
	tenantId = "aa67bd4c-8475-432d-bd41-39f255720e0a"
}

New-MgBetaCommunicationCall -BodyParameter $params

### -------------------------- EXAMPLE 5 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
```

$params = @{
	"@odata.type" = "#microsoft.graph.call"
	callbackUri = "https://bot.contoso.com/callback"
	requestedModalities = @(
		"audio"
	)
	mediaConfig = @{
		"@odata.type" = "#microsoft.graph.serviceHostedMediaConfig"
		preFetchMedia = @(
		)
	}
	chatInfo = @{
		"@odata.type" = "#microsoft.graph.chatInfo"
		threadId = "19:meeting_Win6Ydo4wsMijFjZS00ZGVjLTk5MGUtOTRjNWY2NmNkYTFm@thread.v2"
		messageId = "0"
	}
	meetingInfo = @{
		"@odata.type" = "#microsoft.graph.organizerMeetingInfo"
		organizer = @{
			"@odata.type" = "#microsoft.graph.identitySet"
			user = @{
				"@odata.type" = "#microsoft.graph.identity"
				id = "5810cede-f3cc-42eb-b2c1-e9bd5d53ec96"
				tenantId = "9f386a15-f9cc-445b-8106-ac85e314a07b"
				displayName = "Bob"
			}
		}
		allowConversationWithoutHost = $true
	}
	tenantId = "86dc81db-c112-4228-9222-63f3esaa1edb"
}

New-MgBetaCommunicationCall -BodyParameter $params

### -------------------------- EXAMPLE 6 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
```

$params = @{
	"@odata.type" = "#microsoft.graph.call"
	callbackUri = "https://bot.contoso.com/callback"
	requestedModalities = @(
		"audio"
	)
	mediaConfig = @{
		"@odata.type" = "#microsoft.graph.serviceHostedMediaConfig"
		preFetchMedia = @(
		)
	}
	meetingInfo = @{
		"@odata.type" = "#microsoft.graph.joinMeetingIdMeetingInfo"
		joinMeetingId = "1234567"
		passcode = "psw123"
	}
	tenantId = "86dc81db-c112-4228-9222-63f3esaa1edb"
}

New-MgBetaCommunicationCall -BodyParameter $params

### -------------------------- EXAMPLE 7 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
```

$params = @{
	"@odata.type" = "#microsoft.graph.call"
	callbackUri = "https://bot.contoso.com/callback"
	requestedModalities = @(
		"audio"
	)
	mediaConfig = @{
		"@odata.type" = "#microsoft.graph.serviceHostedMediaConfig"
		preFetchMedia = @(
		)
	}
	meetingInfo = @{
		"@odata.type" = "#microsoft.graph.joinMeetingIdMeetingInfo"
		joinMeetingId = "1234567"
		passcode = $null
	}
	tenantId = "86dc81db-c112-4228-9222-63f3esaa1edb"
}

New-MgBetaCommunicationCall -BodyParameter $params

### -------------------------- EXAMPLE 8 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
```

$params = @{
	"@odata.type" = "#microsoft.graph.call"
	direction = "outgoing"
	callbackUri = "https://bot.contoso.com/callback"
	requestedModalities = @(
		"audio"
	)
	mediaConfig = @{
		"@odata.type" = "#microsoft.graph.appHostedMediaConfig"
		blob = "\<Media Session Configuration\>"
	}
	chatInfo = @{
		"@odata.type" = "#microsoft.graph.chatInfo"
		threadId = "19:meeting_Win6Ydo4wsMijFjZS00ZGVjLTk5MGUtOTRjNWY2NmNkYTFm@thread.v2"
		messageId = "0"
	}
	meetingInfo = @{
		"@odata.type" = "#microsoft.graph.organizerMeetingInfo"
		organizer = @{
			"@odata.type" = "#microsoft.graph.identitySet"
			user = @{
				"@odata.type" = "#microsoft.graph.identity"
				id = "5810cede-f3cc-42eb-b2c1-e9bd5d53ec96"
				tenantId = "aa67bd4c-8475-432d-bd41-39f255720e0a"
				displayName = "Bob"
			}
		}
		allowConversationWithoutHost = $true
	}
	tenantId = "aa67bd4c-8475-432d-bd41-39f255720e0a"
}

New-MgBetaCommunicationCall -BodyParameter $params

### -------------------------- EXAMPLE 9 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
```

$params = @{
	"@odata.type" = "#microsoft.graph.call"
	callbackUri = "https://bot.contoso.com/callback"
	requestedModalities = @(
		"audio"
	)
	mediaConfig = @{
		"@odata.type" = "#microsoft.graph.serviceHostedMediaConfig"
		preFetchMedia = @(
		)
	}
	chatInfo = @{
		"@odata.type" = "#microsoft.graph.chatInfo"
		threadId = "19:cbee7c1c860e465f8258e3cebf7bee0d@thread.skype"
		messageId = "1533758867081"
	}
	meetingInfo = @{
		"@odata.type" = "#microsoft.graph.organizerMeetingInfo"
		organizer = @{
			"@odata.type" = "#microsoft.graph.identitySet"
			user = @{
				"@odata.type" = "#microsoft.graph.identity"
				id = "5810cede-f3cc-42eb-b2c1-e9bd5d53ec96"
				tenantId = "aa67bd4c-8475-432d-bd41-39f255720e0a"
				displayName = "Bob"
			}
		}
		allowConversationWithoutHost = $true
	}
}

New-MgBetaCommunicationCall -BodyParameter $params

### -------------------------- EXAMPLE 10 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
```

$params = @{
	"@odata.type" = "#microsoft.graph.call"
	callbackUri = "https://bot.contoso.com/callback"
	source = @{
		"@odata.type" = "#microsoft.graph.participantInfo"
		identity = @{
			"@odata.type" = "#microsoft.graph.identitySet"
			guest = @{
				"@odata.type" = "#microsoft.graph.identity"
				displayName = "Guest User"
				id = "d7a3b999-17ac-4bca-9e77-e6a730d2ec2e"
			}
		}
	}
	requestedModalities = @(
		"audio"
	)
	mediaConfig = @{
		"@odata.type" = "#microsoft.graph.serviceHostedMediaConfig"
		preFetchMedia = @(
		)
	}
	chatInfo = @{
		"@odata.type" = "#microsoft.graph.chatInfo"
		threadId = "19:cbee7c1c860e465f8258e3cebf7bee0d@thread.skype"
		messageId = "1533758867081"
	}
	meetingInfo = @{
		"@odata.type" = "#microsoft.graph.organizerMeetingInfo"
		organizer = @{
			"@odata.type" = "#microsoft.graph.identitySet"
			user = @{
				"@odata.type" = "#microsoft.graph.identity"
				id = "5810cede-f3cc-42eb-b2c1-e9bd5d53ec96"
				tenantId = "aa67bd4c-8475-432d-bd41-39f255720e0a"
				displayName = "Bob"
			}
		}
		allowConversationWithoutHost = $true
	}
}

New-MgBetaCommunicationCall -BodyParameter $params

### -------------------------- EXAMPLE 11 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
```

$params = @{
	"@odata.type" = "#microsoft.graph.call"
	callbackUri = "https://bot.contoso.com/callback"
	source = @{
		"@odata.type" = "#microsoft.graph.participantInfo"
		identity = @{
			"@odata.type" = "#microsoft.graph.identitySet"
			applicationInstance = @{
				"@odata.type" = "#microsoft.graph.identity"
				displayName = "Calling Bot"
				id = "3d913abb-aec0-4964-8fa6-3c6850c4f278"
			}
		}
		countryCode = $null
		endpointType = $null
		region = $null
		languageId = $null
	}
	targets = @(
		@{
			"@odata.type" = "#microsoft.graph.invitationParticipantInfo"
			identity = @{
				"@odata.type" = "#microsoft.graph.identitySet"
				phone = @{
					"@odata.type" = "#microsoft.graph.identity"
					id = "+12345678901"
				}
			}
		}
	)
	requestedModalities = @(
		"audio"
	)
	mediaConfig = @{
		"@odata.type" = "#microsoft.graph.serviceHostedMediaConfig"
	}
	tenantId = "aa67bd4c-8475-432d-bd41-39f255720e0a"
}

New-MgBetaCommunicationCall -BodyParameter $params

### -------------------------- EXAMPLE 12 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
```

$params = @{
	"@odata.type" = "#microsoft.graph.call"
	callbackUri = "https://bot.contoso.com/callback"
	source = @{
		"@odata.type" = "#microsoft.graph.participantInfo"
		identity = @{
			"@odata.type" = "#microsoft.graph.identitySet"
			applicationInstance = @{
				"@odata.type" = "#microsoft.graph.identity"
				displayName = "Calling Bot"
				id = "3d913abb-aec0-4964-8fa6-3c6850c4f278"
			}
		}
		countryCode = $null
		endpointType = $null
		region = $null
		languageId = $null
	}
	targets = @(
		@{
			"@odata.type" = "#microsoft.graph.invitationParticipantInfo"
			identity = @{
				"@odata.type" = "#microsoft.graph.identitySet"
				phone = @{
					"@odata.type" = "#microsoft.graph.identity"
					id = "+12345678901"
				}
			}
		}
	)
	requestedModalities = @(
		"audio"
	)
	mediaConfig = @{
		"@odata.type" = "#microsoft.graph.appHostedMediaConfig"
		blob = "\<Media Session Configuration\>"
	}
	tenantId = "aa67bd4c-8475-432d-bd41-39f255720e0a"
}

New-MgBetaCommunicationCall -BodyParameter $params

## PARAMETERS

### -ActiveModalities
The list of active modalities.
Possible values are: unknown, audio, video, videoBasedScreenSharing, data.
Read-only.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AnsweredBy
participantInfo
To construct, see NOTES section for ANSWEREDBY properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphParticipantInfo
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AudioRoutingGroups
.
To construct, see NOTES section for AUDIOROUTINGGROUPS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAudioRoutingGroup[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
call
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCall
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CallbackUri
The callback URL on which callbacks will be delivered.
Must be https.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CallChainId
A unique identifier for all the participant calls in a conference or a unique identifier for two participant calls in a P2P call.
This needs to be copied over from Microsoft.Graph.Call.CallChainId.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CallOptions
callOptions
To construct, see NOTES section for CALLOPTIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCallOptions
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CallRoutes
The routing information on how the call was retargeted.
Read-only.
To construct, see NOTES section for CALLROUTES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCallRoute[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ChatInfo
chatInfo
To construct, see NOTES section for CHATINFO properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphChatInfo
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ContentSharingSessions
.
To construct, see NOTES section for CONTENTSHARINGSESSIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphContentSharingSession[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Direction
callDirection

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
The unique identifier for an entity.
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IncomingContext
incomingContext
To construct, see NOTES section for INCOMINGCONTEXT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphIncomingContext
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MediaConfig
mediaConfig
To construct, see NOTES section for MEDIACONFIG properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphMediaConfig
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MediaState
callMediaState
To construct, see NOTES section for MEDIASTATE properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCallMediaState
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MeetingCapability
meetingCapability
To construct, see NOTES section for MEETINGCAPABILITY properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphMeetingCapability
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MeetingInfo
meetingInfo
To construct, see NOTES section for MEETINGINFO properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphMeetingInfo
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MyParticipantId
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Operations
.
To construct, see NOTES section for OPERATIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCommsOperation[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Participants
.
To construct, see NOTES section for PARTICIPANTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphParticipant[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RequestedModalities
.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResultInfo
resultInfo
To construct, see NOTES section for RESULTINFO properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphResultInfo
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RingingTimeoutInSeconds
.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RoutingPolicies
.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Source
participantInfo
To construct, see NOTES section for SOURCE properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphParticipantInfo
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -State
callState

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Subject
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Targets
.
To construct, see NOTES section for TARGETS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphInvitationParticipantInfo[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TenantId
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TerminationReason
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ToneInfo
toneInfo
To construct, see NOTES section for TONEINFO properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphToneInfo
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Transcription
callTranscriptionInfo
To construct, see NOTES section for TRANSCRIPTION properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCallTranscriptionInfo
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCall

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCall

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`ANSWEREDBY <IMicrosoftGraphParticipantInfo>`: participantInfo
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CountryCode <String>]`: The ISO 3166-1 Alpha-2 country code of the participant's best estimated physical location at the start of the call. Read-only.
  - `[EndpointType <String>]`: endpointType
  - `[Identity <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
      - `[Id <String>]`: The identifier of the identity. This property is read-only.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[LanguageId <String>]`: The language culture string. Read-only.
  - `[NonAnonymizedIdentity <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[ParticipantId <String>]`: The participant ID of the participant. Read-only.
  - `[PlatformId <String>]`: The client platform ID of the participant. Read-only.
  - `[Region <String>]`: The home region of the participant, and can be a country, a continent, or a larger geographic region. The region doesn't change based on the participant's current physical location, unlike countryCode. Read-only.

`AUDIOROUTINGGROUPS <IMicrosoftGraphAudioRoutingGroup[]>`: .
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Receivers <String[]>]`: List of receiving participant ids.
  - `[RoutingMode <String>]`: routingMode
  - `[Sources <String[]>]`: List of source participant ids.

`BODYPARAMETER <IMicrosoftGraphCall>`: call
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[ActiveModalities <String[]>]`: The list of active modalities. Possible values are: unknown, audio, video, videoBasedScreenSharing, data. Read-only.
  - `[AnsweredBy <IMicrosoftGraphParticipantInfo>]`: participantInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[CountryCode <String>]`: The ISO 3166-1 Alpha-2 country code of the participant's best estimated physical location at the start of the call. Read-only.
    - `[EndpointType <String>]`: endpointType
    - `[Identity <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Application <IMicrosoftGraphIdentity>]`: identity
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
        - `[Id <String>]`: The identifier of the identity. This property is read-only.
      - `[Device <IMicrosoftGraphIdentity>]`: identity
      - `[User <IMicrosoftGraphIdentity>]`: identity
    - `[LanguageId <String>]`: The language culture string. Read-only.
    - `[NonAnonymizedIdentity <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[ParticipantId <String>]`: The participant ID of the participant. Read-only.
    - `[PlatformId <String>]`: The client platform ID of the participant. Read-only.
    - `[Region <String>]`: The home region of the participant, and can be a country, a continent, or a larger geographic region. The region doesn't change based on the participant's current physical location, unlike countryCode. Read-only.
  - `[AudioRoutingGroups <IMicrosoftGraphAudioRoutingGroup[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Receivers <String[]>]`: List of receiving participant ids.
    - `[RoutingMode <String>]`: routingMode
    - `[Sources <String[]>]`: List of source participant ids.
  - `[CallChainId <String>]`: A unique identifier for all the participant calls in a conference or a unique identifier for two participant calls in a P2P call.  This needs to be copied over from Microsoft.Graph.Call.CallChainId.
  - `[CallOptions <IMicrosoftGraphCallOptions>]`: callOptions
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[HideBotAfterEscalation <Boolean?>]`: Indicates whether to hide the app after the call is escalated.
    - `[IsContentSharingNotificationEnabled <Boolean?>]`: Indicates whether content sharing notifications should be enabled for the call.
  - `[CallRoutes <IMicrosoftGraphCallRoute[]>]`: The routing information on how the call was retargeted. Read-only.
    - `[Final <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Original <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[RoutingType <String>]`: routingType
  - `[CallbackUri <String>]`: The callback URL on which callbacks will be delivered. Must be https.
  - `[ChatInfo <IMicrosoftGraphChatInfo>]`: chatInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[MessageId <String>]`: The unique identifier for a message in a Microsoft Teams channel.
    - `[ReplyChainMessageId <String>]`: The ID of the reply message.
    - `[ThreadId <String>]`: The unique identifier for a thread in Microsoft Teams.
  - `[ContentSharingSessions <IMicrosoftGraphContentSharingSession[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Direction <String>]`: callDirection
  - `[IncomingContext <IMicrosoftGraphIncomingContext>]`: incomingContext
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ObservedParticipantId <String>]`: The id of the participant that is under observation. Read-only.
    - `[OnBehalfOf <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[SourceParticipantId <String>]`: The id of the participant that triggered the incoming call. Read-only.
    - `[Transferor <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[MediaConfig <IMicrosoftGraphMediaConfig>]`: mediaConfig
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[RemoveFromDefaultAudioGroup <Boolean?>]`: 
  - `[MediaState <IMicrosoftGraphCallMediaState>]`: callMediaState
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Audio <String>]`: mediaState
  - `[MeetingCapability <IMicrosoftGraphMeetingCapability>]`: meetingCapability
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AllowAnonymousUsersToDialOut <Boolean?>]`: Indicates whether anonymous users dialout is allowed in a meeting.
    - `[AllowAnonymousUsersToStartMeeting <Boolean?>]`: Indicates whether anonymous users are allowed to start a meeting.
    - `[AutoAdmittedUsers <String>]`: autoAdmittedUsersType
  - `[MeetingInfo <IMicrosoftGraphMeetingInfo>]`: meetingInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AllowConversationWithoutHost <Boolean?>]`: 
  - `[MyParticipantId <String>]`: 
  - `[Operations <IMicrosoftGraphCommsOperation[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[ClientContext <String>]`: Unique Client Context string. Max limit is 256 chars.
    - `[ResultInfo <IMicrosoftGraphResultInfo>]`: resultInfo
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Code <Int32?>]`: The result code.
      - `[Message <String>]`: The message.
      - `[Subcode <Int32?>]`: The result sub-code.
    - `[Status <String>]`: operationStatus
  - `[Participants <IMicrosoftGraphParticipant[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Info <IMicrosoftGraphParticipantInfo>]`: participantInfo
    - `[IsIdentityAnonymized <Boolean?>]`: 
    - `[IsInLobby <Boolean?>]`: true if the participant is in lobby.
    - `[IsMuted <Boolean?>]`: true if the participant is muted (client or server muted).
    - `[MediaStreams <IMicrosoftGraphMediaStream[]>]`: The list of media streams.
      - `[Direction <String>]`: mediaDirection
      - `[Label <String>]`: The media stream label.
      - `[MediaType <String>]`: modality
      - `[ServerMuted <Boolean?>]`: Indicates whether the server has muted the media.
      - `[SourceId <String>]`: The source ID.
    - `[Metadata <String>]`: A blob of data provided by the participant in the roster.
    - `[PreferredDisplayName <String>]`: The participant's preferred display name that overrides the original display name.
    - `[RecordingInfo <IMicrosoftGraphRecordingInfo>]`: recordingInfo
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[InitiatedBy <IMicrosoftGraphParticipantInfo>]`: participantInfo
      - `[Initiator <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[RecordingStatus <String>]`: recordingStatus
    - `[RemovedState <IMicrosoftGraphRemovedState>]`: removedState
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Reason <String>]`: The removal reason for the participant resource.
    - `[RestrictedExperience <IMicrosoftGraphOnlineMeetingRestricted>]`: onlineMeetingRestricted
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ContentSharingDisabled <String>]`: onlineMeetingContentSharingDisabledReason
      - `[VideoDisabled <String>]`: onlineMeetingVideoDisabledReason
    - `[RosterSequenceNumber <Int64?>]`: Indicates the roster sequence number the participant was last updated in.
  - `[RequestedModalities <String[]>]`: 
  - `[ResultInfo <IMicrosoftGraphResultInfo>]`: resultInfo
  - `[RingingTimeoutInSeconds <Int32?>]`: 
  - `[RoutingPolicies <String[]>]`: 
  - `[Source <IMicrosoftGraphParticipantInfo>]`: participantInfo
  - `[State <String>]`: callState
  - `[Subject <String>]`: 
  - `[Targets <IMicrosoftGraphInvitationParticipantInfo[]>]`: 
    - `[EndpointType <String>]`: endpointType
    - `[Hidden <Boolean?>]`: Optional. Whether to hide the participant from the roster.
    - `[Identity <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[ParticipantId <String>]`: Optional. The ID of the target participant.
    - `[RemoveFromDefaultAudioRoutingGroup <Boolean?>]`: Optional. Whether to remove them from the main mixer.
    - `[ReplacesCallId <String>]`: Optional. The call which the target identity is currently a part of. For peer-to-peer case, the call will be dropped once the participant is added successfully.
  - `[TenantId <String>]`: 
  - `[TerminationReason <String>]`: 
  - `[ToneInfo <IMicrosoftGraphToneInfo>]`: toneInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[SequenceId <Int64?>]`: An incremental identifier used for ordering DTMF events.
    - `[Tone <String>]`: tone
  - `[Transcription <IMicrosoftGraphCallTranscriptionInfo>]`: callTranscriptionInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[LastModifiedDateTime <DateTime?>]`: The state modified time in UTC.
    - `[State <String>]`: callTranscriptionState

`CALLOPTIONS <IMicrosoftGraphCallOptions>`: callOptions
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[HideBotAfterEscalation <Boolean?>]`: Indicates whether to hide the app after the call is escalated.
  - `[IsContentSharingNotificationEnabled <Boolean?>]`: Indicates whether content sharing notifications should be enabled for the call.

`CALLROUTES <IMicrosoftGraphCallRoute[]>`: The routing information on how the call was retargeted. Read-only.
  - `[Final <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
      - `[Id <String>]`: The identifier of the identity. This property is read-only.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[Original <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[RoutingType <String>]`: routingType

`CHATINFO <IMicrosoftGraphChatInfo>`: chatInfo
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[MessageId <String>]`: The unique identifier for a message in a Microsoft Teams channel.
  - `[ReplyChainMessageId <String>]`: The ID of the reply message.
  - `[ThreadId <String>]`: The unique identifier for a thread in Microsoft Teams.

`CONTENTSHARINGSESSIONS <IMicrosoftGraphContentSharingSession[]>`: .
  - `[Id <String>]`: The unique identifier for an entity. Read-only.

`INCOMINGCONTEXT <IMicrosoftGraphIncomingContext>`: incomingContext
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ObservedParticipantId <String>]`: The id of the participant that is under observation. Read-only.
  - `[OnBehalfOf <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
      - `[Id <String>]`: The identifier of the identity. This property is read-only.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[SourceParticipantId <String>]`: The id of the participant that triggered the incoming call. Read-only.
  - `[Transferor <IMicrosoftGraphIdentitySet>]`: identitySet

`MEDIACONFIG <IMicrosoftGraphMediaConfig>`: mediaConfig
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[RemoveFromDefaultAudioGroup <Boolean?>]`: 

`MEDIASTATE <IMicrosoftGraphCallMediaState>`: callMediaState
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Audio <String>]`: mediaState

`MEETINGCAPABILITY <IMicrosoftGraphMeetingCapability>`: meetingCapability
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AllowAnonymousUsersToDialOut <Boolean?>]`: Indicates whether anonymous users dialout is allowed in a meeting.
  - `[AllowAnonymousUsersToStartMeeting <Boolean?>]`: Indicates whether anonymous users are allowed to start a meeting.
  - `[AutoAdmittedUsers <String>]`: autoAdmittedUsersType

`MEETINGINFO <IMicrosoftGraphMeetingInfo>`: meetingInfo
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AllowConversationWithoutHost <Boolean?>]`: 

`OPERATIONS <IMicrosoftGraphCommsOperation[]>`: .
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[ClientContext <String>]`: Unique Client Context string. Max limit is 256 chars.
  - `[ResultInfo <IMicrosoftGraphResultInfo>]`: resultInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Code <Int32?>]`: The result code.
    - `[Message <String>]`: The message.
    - `[Subcode <Int32?>]`: The result sub-code.
  - `[Status <String>]`: operationStatus

`PARTICIPANTS <IMicrosoftGraphParticipant[]>`: .
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Info <IMicrosoftGraphParticipantInfo>]`: participantInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[CountryCode <String>]`: The ISO 3166-1 Alpha-2 country code of the participant's best estimated physical location at the start of the call. Read-only.
    - `[EndpointType <String>]`: endpointType
    - `[Identity <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Application <IMicrosoftGraphIdentity>]`: identity
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
        - `[Id <String>]`: The identifier of the identity. This property is read-only.
      - `[Device <IMicrosoftGraphIdentity>]`: identity
      - `[User <IMicrosoftGraphIdentity>]`: identity
    - `[LanguageId <String>]`: The language culture string. Read-only.
    - `[NonAnonymizedIdentity <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[ParticipantId <String>]`: The participant ID of the participant. Read-only.
    - `[PlatformId <String>]`: The client platform ID of the participant. Read-only.
    - `[Region <String>]`: The home region of the participant, and can be a country, a continent, or a larger geographic region. The region doesn't change based on the participant's current physical location, unlike countryCode. Read-only.
  - `[IsIdentityAnonymized <Boolean?>]`: 
  - `[IsInLobby <Boolean?>]`: true if the participant is in lobby.
  - `[IsMuted <Boolean?>]`: true if the participant is muted (client or server muted).
  - `[MediaStreams <IMicrosoftGraphMediaStream[]>]`: The list of media streams.
    - `[Direction <String>]`: mediaDirection
    - `[Label <String>]`: The media stream label.
    - `[MediaType <String>]`: modality
    - `[ServerMuted <Boolean?>]`: Indicates whether the server has muted the media.
    - `[SourceId <String>]`: The source ID.
  - `[Metadata <String>]`: A blob of data provided by the participant in the roster.
  - `[PreferredDisplayName <String>]`: The participant's preferred display name that overrides the original display name.
  - `[RecordingInfo <IMicrosoftGraphRecordingInfo>]`: recordingInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[InitiatedBy <IMicrosoftGraphParticipantInfo>]`: participantInfo
    - `[Initiator <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[RecordingStatus <String>]`: recordingStatus
  - `[RemovedState <IMicrosoftGraphRemovedState>]`: removedState
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Reason <String>]`: The removal reason for the participant resource.
  - `[RestrictedExperience <IMicrosoftGraphOnlineMeetingRestricted>]`: onlineMeetingRestricted
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ContentSharingDisabled <String>]`: onlineMeetingContentSharingDisabledReason
    - `[VideoDisabled <String>]`: onlineMeetingVideoDisabledReason
  - `[RosterSequenceNumber <Int64?>]`: Indicates the roster sequence number the participant was last updated in.

`RESULTINFO <IMicrosoftGraphResultInfo>`: resultInfo
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Code <Int32?>]`: The result code.
  - `[Message <String>]`: The message.
  - `[Subcode <Int32?>]`: The result sub-code.

`SOURCE <IMicrosoftGraphParticipantInfo>`: participantInfo
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CountryCode <String>]`: The ISO 3166-1 Alpha-2 country code of the participant's best estimated physical location at the start of the call. Read-only.
  - `[EndpointType <String>]`: endpointType
  - `[Identity <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
      - `[Id <String>]`: The identifier of the identity. This property is read-only.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[LanguageId <String>]`: The language culture string. Read-only.
  - `[NonAnonymizedIdentity <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[ParticipantId <String>]`: The participant ID of the participant. Read-only.
  - `[PlatformId <String>]`: The client platform ID of the participant. Read-only.
  - `[Region <String>]`: The home region of the participant, and can be a country, a continent, or a larger geographic region. The region doesn't change based on the participant's current physical location, unlike countryCode. Read-only.

`TARGETS <IMicrosoftGraphInvitationParticipantInfo[]>`: .
  - `[EndpointType <String>]`: endpointType
  - `[Hidden <Boolean?>]`: Optional. Whether to hide the participant from the roster.
  - `[Identity <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
      - `[Id <String>]`: The identifier of the identity. This property is read-only.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[ParticipantId <String>]`: Optional. The ID of the target participant.
  - `[RemoveFromDefaultAudioRoutingGroup <Boolean?>]`: Optional. Whether to remove them from the main mixer.
  - `[ReplacesCallId <String>]`: Optional. The call which the target identity is currently a part of. For peer-to-peer case, the call will be dropped once the participant is added successfully.

`TONEINFO <IMicrosoftGraphToneInfo>`: toneInfo
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[SequenceId <Int64?>]`: An incremental identifier used for ordering DTMF events.
  - `[Tone <String>]`: tone

`TRANSCRIPTION <IMicrosoftGraphCallTranscriptionInfo>`: callTranscriptionInfo
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[LastModifiedDateTime <DateTime?>]`: The state modified time in UTC.
  - `[State <String>]`: callTranscriptionState

## RELATED LINKS

