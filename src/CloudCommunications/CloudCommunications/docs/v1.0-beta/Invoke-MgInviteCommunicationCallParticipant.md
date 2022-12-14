---
external help file:
Module Name: Microsoft.Graph.Beta.CloudCommunications
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.cloudcommunications/invoke-mginvitecommunicationcallparticipant
schema: 2.0.0
---

# Invoke-MgBetaInviteCommunicationCallParticipant

## SYNOPSIS
Invite participants to the active call.
For more information about how to handle operations, see commsOperation.

## SYNTAX

### InviteExpanded1 (Default)
```
Invoke-MgBetaInviteCommunicationCallParticipant -CallId <String> [-AdditionalProperties <Hashtable>]
 [-ClientContext <String>] [-Participants <IMicrosoftGraphInvitationParticipantInfo1[]>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Invite1
```
Invoke-MgBetaInviteCommunicationCallParticipant -CallId <String>
 -BodyParameter <IPaths1Bh76WaCommunicationsCallsCallIdParticipantsMicrosoftGraphInvitePostRequestbodyContentApplicationJsonSchema1>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### InviteViaIdentity1
```
Invoke-MgBetaInviteCommunicationCallParticipant -InputObject <ICloudCommunicationsIdentity>
 -BodyParameter <IPaths1Bh76WaCommunicationsCallsCallIdParticipantsMicrosoftGraphInvitePostRequestbodyContentApplicationJsonSchema1>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### InviteViaIdentityExpanded1
```
Invoke-MgBetaInviteCommunicationCallParticipant -InputObject <ICloudCommunicationsIdentity>
 [-AdditionalProperties <Hashtable>] [-ClientContext <String>]
 [-Participants <IMicrosoftGraphInvitationParticipantInfo1[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invite participants to the active call.
For more information about how to handle operations, see commsOperation.

## EXAMPLES

### Example 1: Using the Invoke-MgBetaInviteCommunicationCallParticipant Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
$params = @{
	Participants = @(
		@{
			"@odata.type" = "#Microsoft.Graph.Beta.invitationParticipantInfo"
			ReplacesCallId = "a7ebfb2d-871e-419c-87af-27290b22e8db"
			Identity = @{
				"@odata.type" = "#Microsoft.Graph.Beta.identitySet"
				User = @{
					"@odata.type" = "#Microsoft.Graph.Beta.identity"
					Id = "278405a3-f568-4b3e-b684-009193463064"
					IdentityProvider = "AAD"
				}
			}
		}
	)
	ClientContext = "f2fa86af-3c51-4bc2-8fc0-475452d9764f"
}
Invoke-MgBetaInviteCommunicationCallParticipant -CallId $callId -BodyParameter $params
```

This example shows how to use the Invoke-MgBetaInviteCommunicationCallParticipant Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Using the Invoke-MgBetaInviteCommunicationCallParticipant Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
$params = @{
	Participants = @(
		@{
			"@odata.type" = "#Microsoft.Graph.Beta.invitationParticipantInfo"
			ReplacesCallId = "a7ebfb2d-871e-419c-87af-27290b22e8db"
			Identity = @{
				"@odata.type" = "#Microsoft.Graph.Beta.identitySet"
				User = @{
					"@odata.type" = "#Microsoft.Graph.Beta.identity"
					Id = "278405a3-f568-4b3e-b684-009193463064"
					IdentityProvider = "AAD"
				}
			}
		}
	)
	ClientContext = "f2fa86af-3c51-4bc2-8fc0-475452d9764f"
}
Invoke-MgBetaInviteCommunicationCallParticipant -CallId $callId -BodyParameter $params
```

This example shows how to use the Invoke-MgBetaInviteCommunicationCallParticipant Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 3: Using the Invoke-MgBetaInviteCommunicationCallParticipant Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
$params = @{
	Participants = @(
		@{
			"@odata.type" = "#Microsoft.Graph.Beta.invitationParticipantInfo"
			ReplacesCallId = "a7ebfb2d-871e-419c-87af-27290b22e8db"
			Identity = @{
				"@odata.type" = "#Microsoft.Graph.Beta.identitySet"
				User = @{
					"@odata.type" = "#Microsoft.Graph.Beta.identity"
					Id = "278405a3-f568-4b3e-b684-009193463064"
					IdentityProvider = "AAD"
				}
			}
		}
	)
	ClientContext = "f2fa86af-3c51-4bc2-8fc0-475452d9764f"
}
Invoke-MgBetaInviteCommunicationCallParticipant -CallId $callId -BodyParameter $params
```

This example shows how to use the Invoke-MgBetaInviteCommunicationCallParticipant Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 4: Using the Invoke-MgBetaInviteCommunicationCallParticipant Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
$params = @{
	Participants = @(
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
	ClientContext = "f2fa86af-3c51-4bc2-8fc0-475452d9764f"
}
Invoke-MgBetaInviteCommunicationCallParticipant -CallId $callId -BodyParameter $params
```

This example shows how to use the Invoke-MgBetaInviteCommunicationCallParticipant Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 5: Using the Invoke-MgBetaInviteCommunicationCallParticipant Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
$params = @{
	Participants = @(
		@{
			"@odata.type" = "#Microsoft.Graph.Beta.invitationParticipantInfo"
			ReplacesCallId = "a7ebfb2d-871e-419c-87af-27290b22e8db"
			Identity = @{
				"@odata.type" = "#Microsoft.Graph.Beta.identitySet"
				User = @{
					"@odata.type" = "#Microsoft.Graph.Beta.identity"
					Id = "7e1b4346-85a6-4bdd-abe3-d11c5d420efe"
					IdentityProvider = "AAD"
				}
			}
		}
	)
	ClientContext = "f2fa86af-3c51-4bc2-8fc0-475452d9764f"
}
Invoke-MgBetaInviteCommunicationCallParticipant -CallId $callId -BodyParameter $params
```

This example shows how to use the Invoke-MgBetaInviteCommunicationCallParticipant Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 6: Using the Invoke-MgBetaInviteCommunicationCallParticipant Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
$params = @{
	Participants = @(
		@{
			"@odata.type" = "#Microsoft.Graph.Beta.invitationParticipantInfo"
			ReplacesCallId = "a7ebfb2d-871e-419c-87af-27290b22e8db"
			ParticipantId = "7d501bf1-5ee4-4605-ba92-0ae4513c611c"
			Identity = @{
				"@odata.type" = "#Microsoft.Graph.Beta.identitySet"
				User = @{
					"@odata.type" = "#Microsoft.Graph.Beta.identity"
					Id = "682b6c37-0729-4fab-ace6-d730d5d9137e"
					IdentityProvider = "AAD"
				}
			}
		}
	)
	ClientContext = "f2fa86af-3c51-4bc2-8fc0-475452d9764f"
}
Invoke-MgBetaInviteCommunicationCallParticipant -CallId $callId -BodyParameter $params
```

This example shows how to use the Invoke-MgBetaInviteCommunicationCallParticipant Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 7: Using the Invoke-MgBetaInviteCommunicationCallParticipant Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
$params = @{
	Participants = @(
		@{
			"@odata.type" = "#Microsoft.Graph.Beta.invitationParticipantInfo"
			ReplacesCallId = "a7ebfb2d-871e-419c-87af-27290b22e8db"
			Identity = @{
				"@odata.type" = "#Microsoft.Graph.Beta.identitySet"
				User = @{
					"@odata.type" = "#Microsoft.Graph.Beta.identity"
					Id = "7e1b4346-85a6-4bdd-abe3-d11c5d420efe"
					IdentityProvider = "AAD"
				}
			}
		}
		@{
			"@odata.type" = "#Microsoft.Graph.Beta.invitationParticipantInfo"
			ReplacesCallId = "a7ebfb2d-871e-419c-87af-27290b22e8db"
			Identity = @{
				"@odata.type" = "#Microsoft.Graph.Beta.identitySet"
				User = @{
					"@odata.type" = "#Microsoft.Graph.Beta.identity"
					Id = "1e126418-44a0-4a94-a6f8-0efe1ad71acb"
					IdentityProvider = "AAD"
				}
			}
		}
	)
	ClientContext = "f2fa86af-3c51-4bc2-8fc0-475452d9764f"
}
Invoke-MgBetaInviteCommunicationCallParticipant -CallId $callId -BodyParameter $params
```

This example shows how to use the Invoke-MgBetaInviteCommunicationCallParticipant Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: InviteExpanded1, InviteViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IPaths1Bh76WaCommunicationsCallsCallIdParticipantsMicrosoftGraphInvitePostRequestbodyContentApplicationJsonSchema1
Parameter Sets: Invite1, InviteViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CallId
key: id of call

```yaml
Type: System.String
Parameter Sets: Invite1, InviteExpanded1
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
Parameter Sets: InviteExpanded1, InviteViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.ICloudCommunicationsIdentity
Parameter Sets: InviteViaIdentity1, InviteViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Participants
.
To construct, please use Get-Help -Online and see NOTES section for PARTICIPANTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphInvitationParticipantInfo1[]
Parameter Sets: InviteExpanded1, InviteViaIdentityExpanded1
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

### Microsoft.Graph.Beta.PowerShell.Models.ICloudCommunicationsIdentity

### Microsoft.Graph.Beta.PowerShell.Models.IPaths1Bh76WaCommunicationsCallsCallIdParticipantsMicrosoftGraphInvitePostRequestbodyContentApplicationJsonSchema1

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphInviteParticipantsOperation1

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths1Bh76WaCommunicationsCallsCallIdParticipantsMicrosoftGraphInvitePostRequestbodyContentApplicationJsonSchema1>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ClientContext <String>]`: 
  - `[Participants <IMicrosoftGraphInvitationParticipantInfo1[]>]`: 
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

INPUTOBJECT <ICloudCommunicationsIdentity>: Identity Parameter
  - `[AttendanceRecordId <String>]`: key: id of attendanceRecord
  - `[AudioRoutingGroupId <String>]`: key: id of audioRoutingGroup
  - `[CallId <String>]`: key: id of call
  - `[CallRecordId <String>]`: key: id of callRecord
  - `[CallTranscriptId <String>]`: key: id of callTranscript
  - `[CommsOperationId <String>]`: key: id of commsOperation
  - `[ContentSharingSessionId <String>]`: key: id of contentSharingSession
  - `[MeetingAttendanceReportId <String>]`: key: id of meetingAttendanceReport
  - `[MeetingRegistrationQuestionId <String>]`: key: id of meetingRegistrationQuestion
  - `[OnlineMeetingId <String>]`: key: id of onlineMeeting
  - `[ParticipantId <String>]`: key: id of participant
  - `[PresenceId <String>]`: key: id of presence
  - `[SessionId <String>]`: key: id of session
  - `[UserId <String>]`: key: id of user

PARTICIPANTS <IMicrosoftGraphInvitationParticipantInfo1[]>: .
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

## RELATED LINKS

