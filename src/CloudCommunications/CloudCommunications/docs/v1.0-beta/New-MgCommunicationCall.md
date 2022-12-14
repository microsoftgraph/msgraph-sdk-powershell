---
external help file:
Module Name: Microsoft.Graph.Beta.CloudCommunications
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.cloudcommunications/new-mgcommunicationcall
schema: 2.0.0
---

# New-MgBetaCommunicationCall

## SYNOPSIS
Create call enables your bot to create a new outgoing peer-to-peer or group call, or join an existing meeting.
You will need to register the calling bot and go through the list of permissions needed.

## SYNTAX

### CreateExpanded1 (Default)
```
New-MgBetaCommunicationCall [-ActiveModalities <String[]>] [-AdditionalProperties <Hashtable>]
 [-AnsweredBy <IMicrosoftGraphParticipantInfo1>] [-AudioRoutingGroups <IMicrosoftGraphAudioRoutingGroup1[]>]
 [-CallbackUri <String>] [-CallChainId <String>] [-CallOptions <IMicrosoftGraphCallOptions>]
 [-CallRoutes <IMicrosoftGraphCallRoute[]>] [-ChatInfo <IMicrosoftGraphChatInfo>]
 [-ContentSharingSessions <IMicrosoftGraphContentSharingSession[]>] [-Direction <String>] [-Id <String>]
 [-IncomingContext <IMicrosoftGraphIncomingContext>] [-MediaConfig <IMicrosoftGraphMediaConfig1>]
 [-MediaState <IMicrosoftGraphCallMediaState>] [-MeetingCapability <IMicrosoftGraphMeetingCapability>]
 [-MeetingInfo <IMicrosoftGraphMeetingInfo1>] [-MyParticipantId <String>]
 [-Operations <IMicrosoftGraphCommsOperation[]>] [-Participants <IMicrosoftGraphParticipant1[]>]
 [-RequestedModalities <String[]>] [-ResultInfo <IMicrosoftGraphResultInfo>]
 [-RingingTimeoutInSeconds <Int32>] [-RoutingPolicies <String[]>] [-Source <IMicrosoftGraphParticipantInfo1>]
 [-State <String>] [-Subject <String>] [-Targets <IMicrosoftGraphInvitationParticipantInfo1[]>]
 [-TenantId <String>] [-TerminationReason <String>] [-ToneInfo <IMicrosoftGraphToneInfo>]
 [-Transcription <IMicrosoftGraphCallTranscriptionInfo>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create1
```
New-MgBetaCommunicationCall -BodyParameter <IMicrosoftGraphCall1> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create call enables your bot to create a new outgoing peer-to-peer or group call, or join an existing meeting.
You will need to register the calling bot and go through the list of permissions needed.

## EXAMPLES

### Example 1: Using the New-MgBetaCommunicationCall Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
$params = @{
	"@odata.type" = "#Microsoft.Graph.Beta.call"
	CallbackUri = "https://bot.contoso.com/callback"
	Source = @{
		"@odata.type" = "#Microsoft.Graph.Beta.participantInfo"
		Identity = @{
			"@odata.type" = "#Microsoft.Graph.Beta.identitySet"
			Application = @{
				"@odata.type" = "#Microsoft.Graph.Beta.identity"
				DisplayName = "Calling Bot"
				Id = "2891555a-92ff-42e6-80fa-6e1300c6b5c6"
			}
		}
		Region = $null
		LanguageId = $null
	}
	Targets = @(
		@{
			"@odata.type" = "#Microsoft.Graph.Beta.invitationParticipantInfo"
			Identity = @{
				"@odata.type" = "#Microsoft.Graph.Beta.identitySet"
				User = @{
					"@odata.type" = "#Microsoft.Graph.Beta.identity"
					DisplayName = "John"
					Id = "112f7296-5fa4-42ca-bae8-6a692b15d4b8"
				}
			}
		}
	)
	RequestedModalities = @(
		"audio"
	)
	MediaConfig = @{
		"@odata.type" = "#Microsoft.Graph.Beta.appHostedMediaConfig"
		Blob = "<Media Session Configuration>"
	}
}
New-MgBetaCommunicationCall -BodyParameter $params
```

This example shows how to use the New-MgBetaCommunicationCall Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Using the New-MgBetaCommunicationCall Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
$params = @{
	"@odata.type" = "#Microsoft.Graph.Beta.call"
	CallbackUri = "https://bot.contoso.com/callback"
	Targets = @(
		@{
			"@odata.type" = "#Microsoft.Graph.Beta.invitationParticipantInfo"
			Identity = @{
				"@odata.type" = "#Microsoft.Graph.Beta.identitySet"
				User = @{
					"@odata.type" = "#Microsoft.Graph.Beta.identity"
					DisplayName = "John"
					Id = "112f7296-5fa4-42ca-bae8-6a692b15d4b8"
				}
			}
		}
	)
	RequestedModalities = @(
		"audio"
	)
	CallOptions = @{
		"@odata.type" = "#Microsoft.Graph.Beta.outgoingCallOptions"
		IsContentSharingNotificationEnabled = $true
	}
	MediaConfig = @{
		"@odata.type" = "#Microsoft.Graph.Beta.serviceHostedMediaConfig"
	}
}
New-MgBetaCommunicationCall -BodyParameter $params
```

This example shows how to use the New-MgBetaCommunicationCall Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 3: Using the New-MgBetaCommunicationCall Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
$params = @{
	"@odata.type" = "#Microsoft.Graph.Beta.call"
	CallbackUri = "https://bot.contoso.com/callback"
	Source = @{
		"@odata.type" = "#Microsoft.Graph.Beta.participantInfo"
		Identity = @{
			"@odata.type" = "#Microsoft.Graph.Beta.identitySet"
			ApplicationInstance = @{
				"@odata.type" = "#Microsoft.Graph.Beta.identity"
				DisplayName = "Calling Bot"
				Id = "3d913abb-aec0-4964-8fa6-3c6850c4f278"
			}
		}
		CountryCode = $null
		EndpointType = $null
		Region = $null
		LanguageId = $null
	}
	Targets = @(
		@{
			"@odata.type" = "#Microsoft.Graph.Beta.invitationParticipantInfo"
			Identity = @{
				"@odata.type" = "#Microsoft.Graph.Beta.identitySet"
				Phone = @{
					"@odata.type" = "#Microsoft.Graph.Beta.identity"
					Id = "+12345678901"
				}
			}
		}
	)
	RequestedModalities = @(
		"audio"
	)
	MediaConfig = @{
		"@odata.type" = "#Microsoft.Graph.Beta.serviceHostedMediaConfig"
	}
	TenantId = "aa67bd4c-8475-432d-bd41-39f255720e0a"
}
New-MgBetaCommunicationCall -BodyParameter $params
```

This example shows how to use the New-MgBetaCommunicationCall Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 4: Using the New-MgBetaCommunicationCall Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
$params = @{
	"@odata.type" = "#Microsoft.Graph.Beta.call"
	CallbackUri = "https://bot.contoso.com/callback"
	Source = @{
		"@odata.type" = "#Microsoft.Graph.Beta.participantInfo"
		Identity = @{
			"@odata.type" = "#Microsoft.Graph.Beta.identitySet"
			ApplicationInstance = @{
				"@odata.type" = "#Microsoft.Graph.Beta.identity"
				DisplayName = "Calling Bot"
				Id = "3d913abb-aec0-4964-8fa6-3c6850c4f278"
			}
		}
		CountryCode = $null
		EndpointType = $null
		Region = $null
		LanguageId = $null
	}
	Targets = @(
		@{
			"@odata.type" = "#Microsoft.Graph.Beta.invitationParticipantInfo"
			Identity = @{
				"@odata.type" = "#Microsoft.Graph.Beta.identitySet"
				Phone = @{
					"@odata.type" = "#Microsoft.Graph.Beta.identity"
					Id = "+12345678901"
				}
			}
		}
	)
	RequestedModalities = @(
		"audio"
	)
	MediaConfig = @{
		"@odata.type" = "#Microsoft.Graph.Beta.appHostedMediaConfig"
		Blob = "<Media Session Configuration>"
	}
	TenantId = "aa67bd4c-8475-432d-bd41-39f255720e0a"
}
New-MgBetaCommunicationCall -BodyParameter $params
```

This example shows how to use the New-MgBetaCommunicationCall Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 5: Using the New-MgBetaCommunicationCall Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
$params = @{
	"@odata.type" = "#Microsoft.Graph.Beta.call"
	Direction = "outgoing"
	Subject = "Create a group call with app hosted media"
	CallbackUri = "https://bot.contoso.com/callback"
	Source = @{
		"@odata.type" = "#Microsoft.Graph.Beta.participantInfo"
		Identity = @{
			"@odata.type" = "#Microsoft.Graph.Beta.identitySet"
			Application = @{
				"@odata.type" = "#Microsoft.Graph.Beta.identity"
				DisplayName = "TestBot"
				Id = "dd3885da-f9ab-486b-bfae-85de3d445555"
			}
		}
	}
	Targets = @(
		@{
			"@odata.type" = "#Microsoft.Graph.Beta.invitationParticipantInfo"
			Identity = @{
				"@odata.type" = "#Microsoft.Graph.Beta.identitySet"
				User = @{
					"@odata.type" = "#Microsoft.Graph.Beta.identity"
					DisplayName = "user1"
					Id = "98da8a1a-1b87-452c-a713-65d3f10b5555"
				}
			}
		}
		@{
			"@odata.type" = "#Microsoft.Graph.Beta.participantInfo"
			Identity = @{
				"@odata.type" = "#Microsoft.Graph.Beta.identitySet"
				User = @{
					"@odata.type" = "#Microsoft.Graph.Beta.identity"
					DisplayName = "user2"
					Id = "bf5aae9a-d11d-47a8-93b1-782504c95555"
				}
			}
		}
	)
	RequestedModalities = @(
		"audio"
	)
	MediaConfig = @{
		"@odata.type" = "#Microsoft.Graph.Beta.appHostedMediaConfig"
		Blob = "<Media Session Configuration>"
		RemoveFromDefaultAudioGroup = $false
	}
	TenantId = "aa67bd4c-8475-432d-bd41-39f255720e0a"
}
New-MgBetaCommunicationCall -BodyParameter $params
```

This example shows how to use the New-MgBetaCommunicationCall Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 6: Using the New-MgBetaCommunicationCall Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
$params = @{
	"@odata.type" = "#Microsoft.Graph.Beta.call"
	Direction = "outgoing"
	Subject = "Create a group call with service hosted media"
	CallbackUri = "https://bot.contoso.com/callback"
	Source = @{
		"@odata.type" = "#Microsoft.Graph.Beta.participantInfo"
		Identity = @{
			"@odata.type" = "#Microsoft.Graph.Beta.identitySet"
			Application = @{
				"@odata.type" = "#Microsoft.Graph.Beta.identity"
				DisplayName = "TestBot"
				Id = "dd3885da-f9ab-486b-bfae-85de3d445555"
			}
		}
	}
	Targets = @(
		@{
			"@odata.type" = "#Microsoft.Graph.Beta.invitationParticipantInfo"
			Identity = @{
				"@odata.type" = "#Microsoft.Graph.Beta.identitySet"
				User = @{
					"@odata.type" = "#Microsoft.Graph.Beta.identity"
					DisplayName = "user1"
					Id = "98da8a1a-1b87-452c-a713-65d3f10b5555"
				}
			}
		}
		@{
			"@odata.type" = "#Microsoft.Graph.Beta.participantInfo"
			Identity = @{
				"@odata.type" = "#Microsoft.Graph.Beta.identitySet"
				User = @{
					"@odata.type" = "#Microsoft.Graph.Beta.identity"
					DisplayName = "user2"
					Id = "bf5aae9a-d11d-47a8-93b1-782504c95555"
				}
			}
		}
	)
	RequestedModalities = @(
		"audio"
	)
	MediaConfig = @{
		"@odata.type" = "#Microsoft.Graph.Beta.serviceHostedMediaConfig"
		RemoveFromDefaultAudioGroup = $false
	}
	TenantId = "aa67bd4c-8475-432d-bd41-39f255720e0a"
}
New-MgBetaCommunicationCall -BodyParameter $params
```

This example shows how to use the New-MgBetaCommunicationCall Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 7: Using the New-MgBetaCommunicationCall Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
$params = @{
	"@odata.type" = "#Microsoft.Graph.Beta.call"
	CallbackUri = "https://bot.contoso.com/callback"
	Source = @{
		"@odata.type" = "#Microsoft.Graph.Beta.participantInfo"
		Identity = @{
			"@odata.type" = "#Microsoft.Graph.Beta.identitySet"
			Guest = @{
				"@odata.type" = "#Microsoft.Graph.Beta.identity"
				DisplayName = "Guest User"
				Id = "d7a3b999-17ac-4bca-9e77-e6a730d2ec2e"
			}
		}
	}
	RequestedModalities = @(
		"audio"
	)
	MediaConfig = @{
		"@odata.type" = "#Microsoft.Graph.Beta.serviceHostedMediaConfig"
		PreFetchMedia = @(
		)
	}
	ChatInfo = @{
		"@odata.type" = "#Microsoft.Graph.Beta.chatInfo"
		ThreadId = "19:cbee7c1c860e465f8258e3cebf7bee0d@thread.skype"
		MessageId = "1533758867081"
	}
	MeetingInfo = @{
		"@odata.type" = "#Microsoft.Graph.Beta.organizerMeetingInfo"
		Organizer = @{
			"@odata.type" = "#Microsoft.Graph.Beta.identitySet"
			User = @{
				"@odata.type" = "#Microsoft.Graph.Beta.identity"
				Id = "5810cede-f3cc-42eb-b2c1-e9bd5d53ec96"
				TenantId = "aa67bd4c-8475-432d-bd41-39f255720e0a"
				DisplayName = "Bob"
			}
		}
		AllowConversationWithoutHost = $true
	}
}
New-MgBetaCommunicationCall -BodyParameter $params
```

This example shows how to use the New-MgBetaCommunicationCall Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 8: Using the New-MgBetaCommunicationCall Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
$params = @{
	"@odata.type" = "#Microsoft.Graph.Beta.call"
	CallbackUri = "https://bot.contoso.com/callback"
	RequestedModalities = @(
		"audio"
	)
	MediaConfig = @{
		"@odata.type" = "#Microsoft.Graph.Beta.serviceHostedMediaConfig"
		PreFetchMedia = @(
		)
	}
	ChatInfo = @{
		"@odata.type" = "#Microsoft.Graph.Beta.chatInfo"
		ThreadId = "19:cbee7c1c860e465f8258e3cebf7bee0d@thread.skype"
		MessageId = "1533758867081"
	}
	MeetingInfo = @{
		"@odata.type" = "#Microsoft.Graph.Beta.organizerMeetingInfo"
		Organizer = @{
			"@odata.type" = "#Microsoft.Graph.Beta.identitySet"
			User = @{
				"@odata.type" = "#Microsoft.Graph.Beta.identity"
				Id = "5810cede-f3cc-42eb-b2c1-e9bd5d53ec96"
				TenantId = "aa67bd4c-8475-432d-bd41-39f255720e0a"
				DisplayName = "Bob"
			}
		}
		AllowConversationWithoutHost = $true
	}
}
New-MgBetaCommunicationCall -BodyParameter $params
```

This example shows how to use the New-MgBetaCommunicationCall Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 9: Using the New-MgBetaCommunicationCall Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
$params = @{
	"@odata.type" = "#Microsoft.Graph.Beta.call"
	Direction = "outgoing"
	CallbackUri = "https://bot.contoso.com/callback"
	RequestedModalities = @(
		"audio"
	)
	MediaConfig = @{
		"@odata.type" = "#Microsoft.Graph.Beta.appHostedMediaConfig"
		Blob = "<Media Session Configuration>"
	}
	ChatInfo = @{
		"@odata.type" = "#Microsoft.Graph.Beta.chatInfo"
		ThreadId = "19:meeting_Win6Ydo4wsMijFjZS00ZGVjLTk5MGUtOTRjNWY2NmNkYTFm@thread.v2"
		MessageId = "0"
	}
	MeetingInfo = @{
		"@odata.type" = "#Microsoft.Graph.Beta.organizerMeetingInfo"
		Organizer = @{
			"@odata.type" = "#Microsoft.Graph.Beta.identitySet"
			User = @{
				"@odata.type" = "#Microsoft.Graph.Beta.identity"
				Id = "5810cede-f3cc-42eb-b2c1-e9bd5d53ec96"
				TenantId = "aa67bd4c-8475-432d-bd41-39f255720e0a"
				DisplayName = "Bob"
			}
		}
		AllowConversationWithoutHost = $true
	}
	TenantId = "aa67bd4c-8475-432d-bd41-39f255720e0a"
}
New-MgBetaCommunicationCall -BodyParameter $params
```

This example shows how to use the New-MgBetaCommunicationCall Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 10: Using the New-MgBetaCommunicationCall Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
$params = @{
	"@odata.type" = "#Microsoft.Graph.Beta.call"
	CallbackUri = "https://bot.contoso.com/callback"
	RequestedModalities = @(
		"audio"
	)
	MediaConfig = @{
		"@odata.type" = "#Microsoft.Graph.Beta.serviceHostedMediaConfig"
		PreFetchMedia = @(
		)
	}
	ChatInfo = @{
		"@odata.type" = "#Microsoft.Graph.Beta.chatInfo"
		ThreadId = "19:meeting_Win6Ydo4wsMijFjZS00ZGVjLTk5MGUtOTRjNWY2NmNkYTFm@thread.v2"
		MessageId = "0"
	}
	MeetingInfo = @{
		"@odata.type" = "#Microsoft.Graph.Beta.organizerMeetingInfo"
		Organizer = @{
			"@odata.type" = "#Microsoft.Graph.Beta.identitySet"
			User = @{
				"@odata.type" = "#Microsoft.Graph.Beta.identity"
				Id = "5810cede-f3cc-42eb-b2c1-e9bd5d53ec96"
				TenantId = "9f386a15-f9cc-445b-8106-ac85e314a07b"
				DisplayName = "Bob"
			}
		}
		AllowConversationWithoutHost = $true
	}
	TenantId = "86dc81db-c112-4228-9222-63f3esaa1edb"
}
New-MgBetaCommunicationCall -BodyParameter $params
```

This example shows how to use the New-MgBetaCommunicationCall Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 11: Using the New-MgBetaCommunicationCall Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
$params = @{
	"@odata.type" = "#Microsoft.Graph.Beta.call"
	CallbackUri = "https://bot.contoso.com/callback"
	RequestedModalities = @(
		"audio"
	)
	MediaConfig = @{
		"@odata.type" = "#Microsoft.Graph.Beta.serviceHostedMediaConfig"
		PreFetchMedia = @(
		)
	}
	MeetingInfo = @{
		"@odata.type" = "#Microsoft.Graph.Beta.joinMeetingIdMeetingInfo"
		JoinMeetingId = "1234567"
		Passcode = "psw123"
	}
	TenantId = "86dc81db-c112-4228-9222-63f3esaa1edb"
}
New-MgBetaCommunicationCall -BodyParameter $params
```

This example shows how to use the New-MgBetaCommunicationCall Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 12: Using the New-MgBetaCommunicationCall Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
$params = @{
	"@odata.type" = "#Microsoft.Graph.Beta.call"
	CallbackUri = "https://bot.contoso.com/callback"
	RequestedModalities = @(
		"audio"
	)
	MediaConfig = @{
		"@odata.type" = "#Microsoft.Graph.Beta.serviceHostedMediaConfig"
		PreFetchMedia = @(
		)
	}
	MeetingInfo = @{
		"@odata.type" = "#Microsoft.Graph.Beta.joinMeetingIdMeetingInfo"
		JoinMeetingId = "1234567"
		Passcode = $null
	}
	TenantId = "86dc81db-c112-4228-9222-63f3esaa1edb"
}
New-MgBetaCommunicationCall -BodyParameter $params
```

This example shows how to use the New-MgBetaCommunicationCall Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -ActiveModalities
The list of active modalities.
Possible values are: unknown, audio, video, videoBasedScreenSharing, data.
Read-only.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded1
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
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AnsweredBy
participantInfo
To construct, please use Get-Help -Online and see NOTES section for ANSWEREDBY properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphParticipantInfo1
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AudioRoutingGroups
.
To construct, please use Get-Help -Online and see NOTES section for AUDIOROUTINGGROUPS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAudioRoutingGroup1[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
call
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCall1
Parameter Sets: Create1
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
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CallChainId
A unique identifier for all the participant calls in a conference or a unique identifier for two participant calls in a P2P call.
This needs to be copied over from Microsoft.Graph.Beta.Call.CallChainId.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CallOptions
callOptions
To construct, please use Get-Help -Online and see NOTES section for CALLOPTIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCallOptions
Parameter Sets: CreateExpanded1
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
To construct, please use Get-Help -Online and see NOTES section for CALLROUTES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCallRoute[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ChatInfo
chatInfo
To construct, please use Get-Help -Online and see NOTES section for CHATINFO properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphChatInfo
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ContentSharingSessions
.
To construct, please use Get-Help -Online and see NOTES section for CONTENTSHARINGSESSIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphContentSharingSession[]
Parameter Sets: CreateExpanded1
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
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
The unique idenfier for an entity.
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IncomingContext
incomingContext
To construct, please use Get-Help -Online and see NOTES section for INCOMINGCONTEXT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphIncomingContext
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MediaConfig
mediaConfig
To construct, please use Get-Help -Online and see NOTES section for MEDIACONFIG properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphMediaConfig1
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MediaState
callMediaState
To construct, please use Get-Help -Online and see NOTES section for MEDIASTATE properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCallMediaState
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MeetingCapability
meetingCapability
To construct, please use Get-Help -Online and see NOTES section for MEETINGCAPABILITY properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphMeetingCapability
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MeetingInfo
meetingInfo
To construct, please use Get-Help -Online and see NOTES section for MEETINGINFO properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphMeetingInfo1
Parameter Sets: CreateExpanded1
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
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Operations
.
To construct, please use Get-Help -Online and see NOTES section for OPERATIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCommsOperation[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Participants
.
To construct, please use Get-Help -Online and see NOTES section for PARTICIPANTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphParticipant1[]
Parameter Sets: CreateExpanded1
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
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResultInfo
resultInfo
To construct, please use Get-Help -Online and see NOTES section for RESULTINFO properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphResultInfo
Parameter Sets: CreateExpanded1
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
Parameter Sets: CreateExpanded1
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
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Source
participantInfo
To construct, please use Get-Help -Online and see NOTES section for SOURCE properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphParticipantInfo1
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -State
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Subject
The subject of the conversation.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Targets
.
To construct, please use Get-Help -Online and see NOTES section for TARGETS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphInvitationParticipantInfo1[]
Parameter Sets: CreateExpanded1
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
Parameter Sets: CreateExpanded1
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
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ToneInfo
toneInfo
To construct, please use Get-Help -Online and see NOTES section for TONEINFO properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphToneInfo
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Transcription
callTranscriptionInfo
To construct, please use Get-Help -Online and see NOTES section for TRANSCRIPTION properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCallTranscriptionInfo
Parameter Sets: CreateExpanded1
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCall1

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCall1

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ANSWEREDBY <IMicrosoftGraphParticipantInfo1>: participantInfo
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CountryCode <String>]`: The ISO 3166-1 Alpha-2 country code of the participant's best estimated physical location at the start of the call. Read-only.
  - `[EndpointType <String>]`: endpointType
  - `[Identity <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[LanguageId <String>]`: The language culture string. Read-only.
  - `[NonAnonymizedIdentity <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[ParticipantId <String>]`: The participant ID of the participant. Read-only.
  - `[PlatformId <String>]`: The client platform ID of the participant. Read-only.
  - `[Region <String>]`: The home region of the participant. This can be a country, a continent, or a larger geographic region. This does not change based on the participant's current physical location, unlike countryCode. Read-only.

AUDIOROUTINGGROUPS <IMicrosoftGraphAudioRoutingGroup1[]>: .
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Receivers <String[]>]`: List of receiving participant ids.
  - `[RoutingMode <String>]`: 
  - `[Sources <String[]>]`: List of source participant ids.

BODYPARAMETER <IMicrosoftGraphCall1>: call
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[ActiveModalities <String[]>]`: The list of active modalities. Possible values are: unknown, audio, video, videoBasedScreenSharing, data. Read-only.
  - `[AnsweredBy <IMicrosoftGraphParticipantInfo1>]`: participantInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[CountryCode <String>]`: The ISO 3166-1 Alpha-2 country code of the participant's best estimated physical location at the start of the call. Read-only.
    - `[EndpointType <String>]`: endpointType
    - `[Identity <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Application <IMicrosoftGraphIdentity>]`: identity
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
        - `[Id <String>]`: Unique identifier for the identity.
      - `[Device <IMicrosoftGraphIdentity>]`: identity
      - `[User <IMicrosoftGraphIdentity>]`: identity
    - `[LanguageId <String>]`: The language culture string. Read-only.
    - `[NonAnonymizedIdentity <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[ParticipantId <String>]`: The participant ID of the participant. Read-only.
    - `[PlatformId <String>]`: The client platform ID of the participant. Read-only.
    - `[Region <String>]`: The home region of the participant. This can be a country, a continent, or a larger geographic region. This does not change based on the participant's current physical location, unlike countryCode. Read-only.
  - `[AudioRoutingGroups <IMicrosoftGraphAudioRoutingGroup1[]>]`: 
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Receivers <String[]>]`: List of receiving participant ids.
    - `[RoutingMode <String>]`: 
    - `[Sources <String[]>]`: List of source participant ids.
  - `[CallChainId <String>]`: A unique identifier for all the participant calls in a conference or a unique identifier for two participant calls in a P2P call.  This needs to be copied over from Microsoft.Graph.Beta.Call.CallChainId.
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
    - `[MessageId <String>]`: The unique identifier of a message in a Microsoft Teams channel.
    - `[ReplyChainMessageId <String>]`: The ID of the reply message.
    - `[ThreadId <String>]`: The unique identifier for a thread in Microsoft Teams.
  - `[ContentSharingSessions <IMicrosoftGraphContentSharingSession[]>]`: 
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Direction <String>]`: callDirection
  - `[IncomingContext <IMicrosoftGraphIncomingContext>]`: incomingContext
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ObservedParticipantId <String>]`: The ID of the participant that is under observation. Read-only.
    - `[OnBehalfOf <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[SourceParticipantId <String>]`: The ID of the participant that triggered the incoming call. Read-only.
    - `[Transferor <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[MediaConfig <IMicrosoftGraphMediaConfig1>]`: mediaConfig
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
  - `[MeetingInfo <IMicrosoftGraphMeetingInfo1>]`: meetingInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AllowConversationWithoutHost <Boolean?>]`: 
  - `[MyParticipantId <String>]`: 
  - `[Operations <IMicrosoftGraphCommsOperation[]>]`: 
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[ClientContext <String>]`: Unique Client Context string. Max limit is 256 chars.
    - `[ResultInfo <IMicrosoftGraphResultInfo>]`: resultInfo
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Code <Int32?>]`: The result code.
      - `[Message <String>]`: The message.
      - `[Subcode <Int32?>]`: The result sub-code.
    - `[Status <String>]`: operationStatus
  - `[Participants <IMicrosoftGraphParticipant1[]>]`: 
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Info <IMicrosoftGraphParticipantInfo1>]`: participantInfo
    - `[IsIdentityAnonymized <Boolean?>]`: 
    - `[IsInLobby <Boolean?>]`: true if the participant is in lobby.
    - `[IsMuted <Boolean?>]`: true if the participant is muted (client or server muted).
    - `[MediaStreams <IMicrosoftGraphMediaStream1[]>]`: The list of media streams.
      - `[Direction <String>]`: mediaDirection
      - `[Label <String>]`: The media stream label.
      - `[MediaType <String>]`: 
      - `[ServerMuted <Boolean?>]`: Indicates whether the media is muted by the server.
      - `[SourceId <String>]`: The source ID.
    - `[Metadata <String>]`: A blob of data provided by the participant in the roster.
    - `[RecordingInfo <IMicrosoftGraphRecordingInfo1>]`: recordingInfo
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[InitiatedBy <IMicrosoftGraphParticipantInfo1>]`: participantInfo
      - `[Initiator <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[RecordingStatus <String>]`: recordingStatus
  - `[RequestedModalities <String[]>]`: 
  - `[ResultInfo <IMicrosoftGraphResultInfo>]`: resultInfo
  - `[RingingTimeoutInSeconds <Int32?>]`: 
  - `[RoutingPolicies <String[]>]`: 
  - `[Source <IMicrosoftGraphParticipantInfo1>]`: participantInfo
  - `[State <String>]`: 
  - `[Subject <String>]`: The subject of the conversation.
  - `[Targets <IMicrosoftGraphInvitationParticipantInfo1[]>]`: 
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

CALLOPTIONS <IMicrosoftGraphCallOptions>: callOptions
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[HideBotAfterEscalation <Boolean?>]`: Indicates whether to hide the app after the call is escalated.
  - `[IsContentSharingNotificationEnabled <Boolean?>]`: Indicates whether content sharing notifications should be enabled for the call.

CALLROUTES <IMicrosoftGraphCallRoute[]>: The routing information on how the call was retargeted. Read-only.
  - `[Final <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[Original <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[RoutingType <String>]`: routingType

CHATINFO <IMicrosoftGraphChatInfo>: chatInfo
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[MessageId <String>]`: The unique identifier of a message in a Microsoft Teams channel.
  - `[ReplyChainMessageId <String>]`: The ID of the reply message.
  - `[ThreadId <String>]`: The unique identifier for a thread in Microsoft Teams.

CONTENTSHARINGSESSIONS <IMicrosoftGraphContentSharingSession[]>: .
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.

INCOMINGCONTEXT <IMicrosoftGraphIncomingContext>: incomingContext
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ObservedParticipantId <String>]`: The ID of the participant that is under observation. Read-only.
  - `[OnBehalfOf <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[SourceParticipantId <String>]`: The ID of the participant that triggered the incoming call. Read-only.
  - `[Transferor <IMicrosoftGraphIdentitySet>]`: identitySet

MEDIACONFIG <IMicrosoftGraphMediaConfig1>: mediaConfig
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[RemoveFromDefaultAudioGroup <Boolean?>]`: 

MEDIASTATE <IMicrosoftGraphCallMediaState>: callMediaState
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Audio <String>]`: mediaState

MEETINGCAPABILITY <IMicrosoftGraphMeetingCapability>: meetingCapability
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AllowAnonymousUsersToDialOut <Boolean?>]`: Indicates whether anonymous users dialout is allowed in a meeting.
  - `[AllowAnonymousUsersToStartMeeting <Boolean?>]`: Indicates whether anonymous users are allowed to start a meeting.
  - `[AutoAdmittedUsers <String>]`: autoAdmittedUsersType

MEETINGINFO <IMicrosoftGraphMeetingInfo1>: meetingInfo
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AllowConversationWithoutHost <Boolean?>]`: 

OPERATIONS <IMicrosoftGraphCommsOperation[]>: .
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[ClientContext <String>]`: Unique Client Context string. Max limit is 256 chars.
  - `[ResultInfo <IMicrosoftGraphResultInfo>]`: resultInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Code <Int32?>]`: The result code.
    - `[Message <String>]`: The message.
    - `[Subcode <Int32?>]`: The result sub-code.
  - `[Status <String>]`: operationStatus

PARTICIPANTS <IMicrosoftGraphParticipant1[]>: .
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Info <IMicrosoftGraphParticipantInfo1>]`: participantInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[CountryCode <String>]`: The ISO 3166-1 Alpha-2 country code of the participant's best estimated physical location at the start of the call. Read-only.
    - `[EndpointType <String>]`: endpointType
    - `[Identity <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Application <IMicrosoftGraphIdentity>]`: identity
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
        - `[Id <String>]`: Unique identifier for the identity.
      - `[Device <IMicrosoftGraphIdentity>]`: identity
      - `[User <IMicrosoftGraphIdentity>]`: identity
    - `[LanguageId <String>]`: The language culture string. Read-only.
    - `[NonAnonymizedIdentity <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[ParticipantId <String>]`: The participant ID of the participant. Read-only.
    - `[PlatformId <String>]`: The client platform ID of the participant. Read-only.
    - `[Region <String>]`: The home region of the participant. This can be a country, a continent, or a larger geographic region. This does not change based on the participant's current physical location, unlike countryCode. Read-only.
  - `[IsIdentityAnonymized <Boolean?>]`: 
  - `[IsInLobby <Boolean?>]`: true if the participant is in lobby.
  - `[IsMuted <Boolean?>]`: true if the participant is muted (client or server muted).
  - `[MediaStreams <IMicrosoftGraphMediaStream1[]>]`: The list of media streams.
    - `[Direction <String>]`: mediaDirection
    - `[Label <String>]`: The media stream label.
    - `[MediaType <String>]`: 
    - `[ServerMuted <Boolean?>]`: Indicates whether the media is muted by the server.
    - `[SourceId <String>]`: The source ID.
  - `[Metadata <String>]`: A blob of data provided by the participant in the roster.
  - `[RecordingInfo <IMicrosoftGraphRecordingInfo1>]`: recordingInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[InitiatedBy <IMicrosoftGraphParticipantInfo1>]`: participantInfo
    - `[Initiator <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[RecordingStatus <String>]`: recordingStatus

RESULTINFO <IMicrosoftGraphResultInfo>: resultInfo
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Code <Int32?>]`: The result code.
  - `[Message <String>]`: The message.
  - `[Subcode <Int32?>]`: The result sub-code.

SOURCE <IMicrosoftGraphParticipantInfo1>: participantInfo
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CountryCode <String>]`: The ISO 3166-1 Alpha-2 country code of the participant's best estimated physical location at the start of the call. Read-only.
  - `[EndpointType <String>]`: endpointType
  - `[Identity <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[LanguageId <String>]`: The language culture string. Read-only.
  - `[NonAnonymizedIdentity <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[ParticipantId <String>]`: The participant ID of the participant. Read-only.
  - `[PlatformId <String>]`: The client platform ID of the participant. Read-only.
  - `[Region <String>]`: The home region of the participant. This can be a country, a continent, or a larger geographic region. This does not change based on the participant's current physical location, unlike countryCode. Read-only.

TARGETS <IMicrosoftGraphInvitationParticipantInfo1[]>: .
  - `[EndpointType <String>]`: endpointType
  - `[Hidden <Boolean?>]`: Optional. Whether to hide the participant from the roster.
  - `[Identity <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[ParticipantId <String>]`: Optional. The ID of the target participant.
  - `[RemoveFromDefaultAudioRoutingGroup <Boolean?>]`: Optional. Whether to remove them from the main mixer.
  - `[ReplacesCallId <String>]`: Optional. The call which the target identity is currently a part of. For peer-to-peer case, the call will be dropped once the participant is added successfully.

TONEINFO <IMicrosoftGraphToneInfo>: toneInfo
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[SequenceId <Int64?>]`: An incremental identifier used for ordering DTMF events.
  - `[Tone <String>]`: tone

TRANSCRIPTION <IMicrosoftGraphCallTranscriptionInfo>: callTranscriptionInfo
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[LastModifiedDateTime <DateTime?>]`: The state modified time in UTC.
  - `[State <String>]`: callTranscriptionState

## RELATED LINKS

