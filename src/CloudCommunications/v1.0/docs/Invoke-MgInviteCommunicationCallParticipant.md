---
external help file:
Module Name: Microsoft.Graph.CloudCommunications
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.cloudcommunications/invoke-mginvitecommunicationcallparticipant
schema: 2.0.0
---

# Invoke-MgInviteCommunicationCallParticipant

## SYNOPSIS
Invite participants to the active call.
For more information about how to handle operations, see commsOperation.

## SYNTAX

### InviteExpanded (Default)
```
Invoke-MgInviteCommunicationCallParticipant -CallId <String> [-AdditionalProperties <Hashtable>]
 [-ClientContext <String>] [-Participants <IMicrosoftGraphInvitationParticipantInfo[]>]
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Invite
```
Invoke-MgInviteCommunicationCallParticipant -CallId <String>
 -BodyParameter <IPaths1Bh76WaCommunicationsCallsCallIdParticipantsMicrosoftGraphInvitePostRequestbodyContentApplicationJsonSchema>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### InviteViaIdentity
```
Invoke-MgInviteCommunicationCallParticipant -InputObject <ICloudCommunicationsIdentity>
 -BodyParameter <IPaths1Bh76WaCommunicationsCallsCallIdParticipantsMicrosoftGraphInvitePostRequestbodyContentApplicationJsonSchema>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### InviteViaIdentityExpanded
```
Invoke-MgInviteCommunicationCallParticipant -InputObject <ICloudCommunicationsIdentity>
 [-AdditionalProperties <Hashtable>] [-ClientContext <String>]
 [-Participants <IMicrosoftGraphInvitationParticipantInfo[]>] [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invite participants to the active call.
For more information about how to handle operations, see commsOperation.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Import-Module Microsoft.Graph.CloudCommunications
```

$params = @{
	participants = @(
		@{
			"@odata.type" = "#microsoft.graph.invitationParticipantInfo"
			replacesCallId = "a7ebfb2d-871e-419c-87af-27290b22e8db"
			identity = @{
				"@odata.type" = "#microsoft.graph.identitySet"
				user = @{
					"@odata.type" = "#microsoft.graph.identity"
					id = "278405a3-f568-4b3e-b684-009193463064"
					displayName = "string"
				}
			}
		}
	)
	clientContext = "f2fa86af-3c51-4bc2-8fc0-475452d9764f"
}

Invoke-MgInviteCommunicationCallParticipant -CallId $callId -BodyParameter $params

### -------------------------- EXAMPLE 2 --------------------------
```powershell
Import-Module Microsoft.Graph.CloudCommunications
```

$params = @{
	participants = @(
		@{
			"@odata.type" = "#microsoft.graph.invitationParticipantInfo"
			replacesCallId = "a7ebfb2d-871e-419c-87af-27290b22e8db"
			identity = @{
				"@odata.type" = "#microsoft.graph.identitySet"
				user = @{
					"@odata.type" = "#microsoft.graph.identity"
					id = "7e1b4346-85a6-4bdd-abe3-d11c5d420efe"
					displayName = "string"
				}
			}
		}
		@{
			"@odata.type" = "#microsoft.graph.invitationParticipantInfo"
			replacesCallId = "a7ebfb2d-871e-419c-87af-27290b22e8db"
			identity = @{
				"@odata.type" = "#microsoft.graph.identitySet"
				user = @{
					"@odata.type" = "#microsoft.graph.identity"
					id = "1e126418-44a0-4a94-a6f8-0efe1ad71acb"
					displayName = "string"
				}
			}
		}
	)
	clientContext = "f2fa86af-3c51-4bc2-8fc0-475452d9764f"
}

Invoke-MgInviteCommunicationCallParticipant -CallId $callId -BodyParameter $params

### -------------------------- EXAMPLE 3 --------------------------
```powershell
Import-Module Microsoft.Graph.CloudCommunications
```

$params = @{
	participants = @(
		@{
			"@odata.type" = "#microsoft.graph.invitationParticipantInfo"
			replacesCallId = "a7ebfb2d-871e-419c-87af-27290b22e8db"
			identity = @{
				"@odata.type" = "#microsoft.graph.identitySet"
				user = @{
					"@odata.type" = "#microsoft.graph.identity"
					id = "7e1b4346-85a6-4bdd-abe3-d11c5d420efe"
					displayName = "string"
				}
			}
		}
	)
	clientContext = "f2fa86af-3c51-4bc2-8fc0-475452d9764f"
}

Invoke-MgInviteCommunicationCallParticipant -CallId $callId -BodyParameter $params

### -------------------------- EXAMPLE 4 --------------------------
```powershell
Import-Module Microsoft.Graph.CloudCommunications
```

$params = @{
	participants = @(
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
	clientContext = "f2fa86af-3c51-4bc2-8fc0-475452d9764f"
}

Invoke-MgInviteCommunicationCallParticipant -CallId $callId -BodyParameter $params

### -------------------------- EXAMPLE 5 --------------------------
```powershell
Import-Module Microsoft.Graph.CloudCommunications
```

$params = @{
	participants = @(
		@{
			"@odata.type" = "#microsoft.graph.invitationParticipantInfo"
			replacesCallId = "a7ebfb2d-871e-419c-87af-27290b22e8db"
			participantId = "7d501bf1-5ee4-4605-ba92-0ae4513c611c"
			identity = @{
				"@odata.type" = "#microsoft.graph.identitySet"
				user = @{
					"@odata.type" = "#microsoft.graph.identity"
					id = "682b6c37-0729-4fab-ace6-d730d5d9137e"
					identityProvider = "AAD"
				}
			}
		}
	)
	clientContext = "f2fa86af-3c51-4bc2-8fc0-475452d9764f"
}

Invoke-MgInviteCommunicationCallParticipant -CallId $callId -BodyParameter $params

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

### -Headers
Optional headers that will be added to the request.

```yaml
Type: System.Collections.IDictionary
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### -ResponseHeadersVariable
Optional Response Headers Variable.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: RHV

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

### System.Collections.IDictionary

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
        - `[DisplayName <String>]`: The display name of the identity. The display name might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
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
  - `[CallRecordingId <String>]`: The unique identifier of callRecording
  - `[CallTranscriptId <String>]`: The unique identifier of callTranscript
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
      - `[DisplayName <String>]`: The display name of the identity. The display name might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[ParticipantId <String>]`: Optional. The ID of the target participant.
  - `[RemoveFromDefaultAudioRoutingGroup <Boolean?>]`: Optional. Whether to remove them from the main mixer.
  - `[ReplacesCallId <String>]`: Optional. The call which the target identity is currently a part of. For peer-to-peer case, the call will be dropped once the participant is added successfully.

## RELATED LINKS

