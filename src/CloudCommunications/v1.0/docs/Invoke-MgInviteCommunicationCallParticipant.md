---
external help file:
Module Name: Microsoft.Graph.CloudCommunications
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.cloudcommunications/invoke-mginvitecommunicationcallparticipant
schema: 2.0.0
---

# Invoke-MgInviteCommunicationCallParticipant

## SYNOPSIS
Delete a specific participant in a call.
In some situations, it is appropriate for an application to remove a participant from an active call.
This action can be done before or after the participant answers the call.
When an active caller is removed, they are immediately dropped from the call with no pre- or post-removal notification.
When an invited participant is removed, any outstanding add participant request is canceled.

## SYNTAX

### InviteExpanded (Default)
```
Invoke-MgInviteCommunicationCallParticipant -CallId <String> [-AdditionalProperties <Hashtable>]
 [-ClientContext <String>] [-Participants <IMicrosoftGraphInvitationParticipantInfo[]>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Invite
```
Invoke-MgInviteCommunicationCallParticipant -CallId <String>
 -BodyParameter <IPaths1Bh76WaCommunicationsCallsCallIdParticipantsMicrosoftGraphInvitePostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### InviteViaIdentity
```
Invoke-MgInviteCommunicationCallParticipant -InputObject <ICloudCommunicationsIdentity>
 -BodyParameter <IPaths1Bh76WaCommunicationsCallsCallIdParticipantsMicrosoftGraphInvitePostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### InviteViaIdentityExpanded
```
Invoke-MgInviteCommunicationCallParticipant -InputObject <ICloudCommunicationsIdentity>
 [-AdditionalProperties <Hashtable>] [-ClientContext <String>]
 [-Participants <IMicrosoftGraphInvitationParticipantInfo[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Delete a specific participant in a call.
In some situations, it is appropriate for an application to remove a participant from an active call.
This action can be done before or after the participant answers the call.
When an active caller is removed, they are immediately dropped from the call with no pre- or post-removal notification.
When an invited participant is removed, any outstanding add participant request is canceled.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	Participants = @(
		@{
			"@odata.type" = "#microsoft.graph.invitationParticipantInfo"
			ReplacesCallId = "a7ebfb2d-871e-419c-87af-27290b22e8db"
			Identity = @{
				"@odata.type" = "#microsoft.graph.identitySet"
				User = @{
					"@odata.type" = "#microsoft.graph.identity"
					Id = "278405a3-f568-4b3e-b684-009193463064"
					IdentityProvider = "AAD"
				}
			}
		}
	)
	ClientContext = "f2fa86af-3c51-4bc2-8fc0-475452d9764f"
}
Invoke-MgInviteCommunicationCallParticipant -CallId $callId -BodyParameter $params
```



### -------------------------- EXAMPLE 2 --------------------------
```powershell
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	Participants = @(
		@{
			"@odata.type" = "#microsoft.graph.invitationParticipantInfo"
			Identity = @{
				"@odata.type" = "#microsoft.graph.identitySet"
				Phone = @{
					"@odata.type" = "#microsoft.graph.identity"
					Id = "+12345678901"
				}
			}
		}
	)
	ClientContext = "f2fa86af-3c51-4bc2-8fc0-475452d9764f"
}
Invoke-MgInviteCommunicationCallParticipant -CallId $callId -BodyParameter $params
```



### -------------------------- EXAMPLE 3 --------------------------
```powershell
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	Participants = @(
		@{
			"@odata.type" = "#microsoft.graph.invitationParticipantInfo"
			ReplacesCallId = "a7ebfb2d-871e-419c-87af-27290b22e8db"
			Identity = @{
				"@odata.type" = "#microsoft.graph.identitySet"
				User = @{
					"@odata.type" = "#microsoft.graph.identity"
					Id = "7e1b4346-85a6-4bdd-abe3-d11c5d420efe"
					DisplayName = "string"
				}
			}
		}
	)
	ClientContext = "f2fa86af-3c51-4bc2-8fc0-475452d9764f"
}
Invoke-MgInviteCommunicationCallParticipant -CallId $callId -BodyParameter $params
```



### -------------------------- EXAMPLE 4 --------------------------
```powershell
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	Participants = @(
		@{
			"@odata.type" = "#microsoft.graph.invitationParticipantInfo"
			ReplacesCallId = "a7ebfb2d-871e-419c-87af-27290b22e8db"
			ParticipantId = "7d501bf1-5ee4-4605-ba92-0ae4513c611c"
			Identity = @{
				"@odata.type" = "#microsoft.graph.identitySet"
				User = @{
					"@odata.type" = "#microsoft.graph.identity"
					Id = "682b6c37-0729-4fab-ace6-d730d5d9137e"
					IdentityProvider = "AAD"
				}
			}
		}
	)
	ClientContext = "f2fa86af-3c51-4bc2-8fc0-475452d9764f"
}
Invoke-MgInviteCommunicationCallParticipant -CallId $callId -BodyParameter $params
```



### -------------------------- EXAMPLE 5 --------------------------
```powershell
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	Participants = @(
		@{
			"@odata.type" = "#microsoft.graph.invitationParticipantInfo"
			ReplacesCallId = "a7ebfb2d-871e-419c-87af-27290b22e8db"
			Identity = @{
				"@odata.type" = "#microsoft.graph.identitySet"
				User = @{
					"@odata.type" = "#microsoft.graph.identity"
					Id = "7e1b4346-85a6-4bdd-abe3-d11c5d420efe"
					DisplayName = "string"
				}
			}
		}
		@{
			"@odata.type" = "#microsoft.graph.invitationParticipantInfo"
			ReplacesCallId = "a7ebfb2d-871e-419c-87af-27290b22e8db"
			Identity = @{
				"@odata.type" = "#microsoft.graph.identitySet"
				User = @{
					"@odata.type" = "#microsoft.graph.identity"
					Id = "1e126418-44a0-4a94-a6f8-0efe1ad71acb"
					DisplayName = "string"
				}
			}
		}
	)
	ClientContext = "f2fa86af-3c51-4bc2-8fc0-475452d9764f"
}
Invoke-MgInviteCommunicationCallParticipant -CallId $callId -BodyParameter $params
```



### -------------------------- EXAMPLE 6 --------------------------
```powershell
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	Participants = @(
		@{
			"@odata.type" = "#microsoft.graph.invitationParticipantInfo"
			ReplacesCallId = "a7ebfb2d-871e-419c-87af-27290b22e8db"
			Identity = @{
				"@odata.type" = "#microsoft.graph.identitySet"
				User = @{
					"@odata.type" = "#microsoft.graph.identity"
					Id = "278405a3-f568-4b3e-b684-009193463064"
					IdentityProvider = "AAD"
				}
			}
		}
	)
	ClientContext = "f2fa86af-3c51-4bc2-8fc0-475452d9764f"
}
Invoke-MgInviteCommunicationCallParticipant -CallId $callId -BodyParameter $params
```



### -------------------------- EXAMPLE 7 --------------------------
```powershell
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	Participants = @(
		@{
			"@odata.type" = "#microsoft.graph.invitationParticipantInfo"
			ReplacesCallId = "a7ebfb2d-871e-419c-87af-27290b22e8db"
			Identity = @{
				"@odata.type" = "#microsoft.graph.identitySet"
				User = @{
					"@odata.type" = "#microsoft.graph.identity"
					Id = "278405a3-f568-4b3e-b684-009193463064"
					DisplayName = "string"
				}
			}
		}
	)
	ClientContext = "f2fa86af-3c51-4bc2-8fc0-475452d9764f"
}
Invoke-MgInviteCommunicationCallParticipant -CallId $callId -BodyParameter $params
```



## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: InviteExpanded, InviteViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IPaths1Bh76WaCommunicationsCallsCallIdParticipantsMicrosoftGraphInvitePostRequestbodyContentApplicationJsonSchema
Parameter Sets: Invite, InviteViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CallId
The unique identifier of call

```yaml
Type: System.String
Parameter Sets: Invite, InviteExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ClientContext
.

```yaml
Type: System.String
Parameter Sets: InviteExpanded, InviteViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.ICloudCommunicationsIdentity
Parameter Sets: InviteViaIdentity, InviteViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Participants
.
To construct, see NOTES section for PARTICIPANTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphInvitationParticipantInfo[]
Parameter Sets: InviteExpanded, InviteViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.ICloudCommunicationsIdentity

### Microsoft.Graph.PowerShell.Models.IPaths1Bh76WaCommunicationsCallsCallIdParticipantsMicrosoftGraphInvitePostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphInviteParticipantsOperation

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IPaths1Bh76WaCommunicationsCallsCallIdParticipantsMicrosoftGraphInvitePostRequestbodyContentApplicationJsonSchema>`: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ClientContext <String>]`: 
  - `[Participants <IMicrosoftGraphInvitationParticipantInfo[]>]`: 
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

`INPUTOBJECT <ICloudCommunicationsIdentity>`: Identity Parameter
  - `[AttendanceRecordId <String>]`: The unique identifier of attendanceRecord
  - `[AudioRoutingGroupId <String>]`: The unique identifier of audioRoutingGroup
  - `[CallId <String>]`: The unique identifier of call
  - `[CallRecordId <String>]`: The unique identifier of callRecord
  - `[CommsOperationId <String>]`: The unique identifier of commsOperation
  - `[ContentSharingSessionId <String>]`: The unique identifier of contentSharingSession
  - `[MeetingAttendanceReportId <String>]`: The unique identifier of meetingAttendanceReport
  - `[OnlineMeetingId <String>]`: The unique identifier of onlineMeeting
  - `[ParticipantId <String>]`: The unique identifier of participant
  - `[PresenceId <String>]`: The unique identifier of presence
  - `[SessionId <String>]`: The unique identifier of session
  - `[UserId <String>]`: The unique identifier of user

`PARTICIPANTS <IMicrosoftGraphInvitationParticipantInfo[]>`: .
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

## RELATED LINKS

