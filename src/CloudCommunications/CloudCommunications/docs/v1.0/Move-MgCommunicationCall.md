---
external help file:
Module Name: Microsoft.Graph.CloudCommunications
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.cloudcommunications/move-mgcommunicationcall
schema: 2.0.0
---

# Move-MgCommunicationCall

## SYNOPSIS
Transfer an active peer-to-peer call or group call.
A consultative transfer means that the transferor can inform the person they want to transfer the call to (the transferee), before the transfer is made.
This is opposed to transfering the call directly.

## SYNTAX

### TransferExpanded (Default)
```
Move-MgCommunicationCall -CallId <String> [-AdditionalProperties <Hashtable>]
 [-Transferee <IMicrosoftGraphParticipantInfo>] [-TransferTarget <IMicrosoftGraphInvitationParticipantInfo>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Transfer
```
Move-MgCommunicationCall -CallId <String>
 -BodyParameter <IPaths4Zbm7LCommunicationsCallsCallIdMicrosoftGraphTransferPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### TransferViaIdentity
```
Move-MgCommunicationCall -InputObject <ICloudCommunicationsIdentity>
 -BodyParameter <IPaths4Zbm7LCommunicationsCallsCallIdMicrosoftGraphTransferPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### TransferViaIdentityExpanded
```
Move-MgCommunicationCall -InputObject <ICloudCommunicationsIdentity> [-AdditionalProperties <Hashtable>]
 [-Transferee <IMicrosoftGraphParticipantInfo>] [-TransferTarget <IMicrosoftGraphInvitationParticipantInfo>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Transfer an active peer-to-peer call or group call.
A consultative transfer means that the transferor can inform the person they want to transfer the call to (the transferee), before the transfer is made.
This is opposed to transfering the call directly.

## EXAMPLES

### Example 1: Using the Move-MgCommunicationCall Cmdlet
```powershell
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	TransferTarget = @{
		EndpointType = "default"
		Identity = @{
			User = @{
				Id = "550fae72-d251-43ec-868c-373732c2704f"
				DisplayName = "Heidi Steen"
			}
		}
	}
}
Move-MgCommunicationCall -CallId $callId -BodyParameter $params
```

This example shows how to use the Move-MgCommunicationCall Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Using the Move-MgCommunicationCall Cmdlet
```powershell
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	TransferTarget = @{
		"@odata.type" = "#microsoft.graph.invitationParticipantInfo"
		EndpointType = "default"
		Identity = @{
			"@odata.type" = "#microsoft.graph.identitySet"
			User = @{
				"@odata.type" = "#microsoft.graph.identity"
				Id = "550fae72-d251-43ec-868c-373732c2704f"
				DisplayName = "Heidi Steen"
			}
		}
		ReplacesCallId = "e5d39592-99bd-4db8-bca8-30fb894ec51d"
	}
}
Move-MgCommunicationCall -CallId $callId -BodyParameter $params
```

This example shows how to use the Move-MgCommunicationCall Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 3: Using the Move-MgCommunicationCall Cmdlet
```powershell
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	TransferTarget = @{
		EndpointType = "default"
		Identity = @{
			Phone = @{
				"@odata.type" = "#microsoft.graph.identity"
				Id = "+12345678901"
			}
		}
		LanguageId = "languageId-value"
		Region = "region-value"
	}
	ClientContext = "9e90d1c1-f61e-43e7-9f75-d420159aae08"
}
Move-MgCommunicationCall -CallId $callId -BodyParameter $params
```

This example shows how to use the Move-MgCommunicationCall Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 4: Using the Move-MgCommunicationCall Cmdlet
```powershell
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	TransferTarget = @{
		"@odata.type" = "#microsoft.graph.invitationParticipantInfo"
		EndpointType = "default"
		Identity = @{
			"@odata.type" = "#microsoft.graph.identitySet"
			Phone = @{
				"@odata.type" = "#microsoft.graph.identity"
				Id = "+12345678901"
			}
		}
		LanguageId = "en-us"
		Region = "amer"
		ReplacesCallId = "e5d39592-99bd-4db8-bca8-30fb894ec51d"
	}
	ClientContext = "9e90d1c1-f61e-43e7-9f75-d420159aae08"
}
Move-MgCommunicationCall -CallId $callId -BodyParameter $params
```

This example shows how to use the Move-MgCommunicationCall Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 5: Using the Move-MgCommunicationCall Cmdlet
```powershell
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	TransferTarget = @{
		EndpointType = "default"
		Identity = @{
			User = @{
				Id = "550fae72-d251-43ec-868c-373732c2704f"
				DisplayName = "Heidi Steen"
			}
		}
	}
	Transferee = @{
		Identity = @{
			User = @{
				Id = "751f6800-3180-414d-bd94-333364659951"
				TenantId = "72f988bf-86f1-41af-91ab-2d7cd011db47"
			}
		}
		ParticipantId = "909c6581-5130-43e9-88f3-fcb3582cde37"
	}
}
Move-MgCommunicationCall -CallId $callId -BodyParameter $params
```

This example shows how to use the Move-MgCommunicationCall Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: TransferExpanded, TransferViaIdentityExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IPaths4Zbm7LCommunicationsCallsCallIdMicrosoftGraphTransferPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Transfer, TransferViaIdentity
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
Parameter Sets: Transfer, TransferExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.ICloudCommunicationsIdentity
Parameter Sets: TransferViaIdentity, TransferViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -PassThru
Returns true when the command succeeds

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Transferee
participantInfo
To construct, please use Get-Help -Online and see NOTES section for TRANSFEREE properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphParticipantInfo
Parameter Sets: TransferExpanded, TransferViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TransferTarget
invitationParticipantInfo
To construct, please use Get-Help -Online and see NOTES section for TRANSFERTARGET properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphInvitationParticipantInfo
Parameter Sets: TransferExpanded, TransferViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IPaths4Zbm7LCommunicationsCallsCallIdMicrosoftGraphTransferPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths4Zbm7LCommunicationsCallsCallIdMicrosoftGraphTransferPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[TransferTarget <IMicrosoftGraphInvitationParticipantInfo>]`: invitationParticipantInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
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
  - `[Transferee <IMicrosoftGraphParticipantInfo>]`: participantInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[CountryCode <String>]`: The ISO 3166-1 Alpha-2 country code of the participant's best estimated physical location at the start of the call. Read-only.
    - `[EndpointType <String>]`: endpointType
    - `[Identity <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LanguageId <String>]`: The language culture string. Read-only.
    - `[ParticipantId <String>]`: The participant ID of the participant. Read-only.
    - `[Region <String>]`: The home region of the participant. This can be a country, a continent, or a larger geographic region. This does not change based on the participant's current physical location. Read-only.

INPUTOBJECT <ICloudCommunicationsIdentity>: Identity Parameter
  - `[AttendanceRecordId <String>]`: The unique identifier of attendanceRecord
  - `[AudioRoutingGroupId <String>]`: The unique identifier of audioRoutingGroup
  - `[CallId <String>]`: The unique identifier of call
  - `[CallRecordId <String>]`: The unique identifier of callRecord
  - `[CallTranscriptId <String>]`: The unique identifier of callTranscript
  - `[CommsOperationId <String>]`: The unique identifier of commsOperation
  - `[ContentSharingSessionId <String>]`: The unique identifier of contentSharingSession
  - `[FromDateTime <DateTime?>]`: Usage: fromDateTime={fromDateTime}
  - `[MeetingAttendanceReportId <String>]`: The unique identifier of meetingAttendanceReport
  - `[MeetingRegistrationQuestionId <String>]`: The unique identifier of meetingRegistrationQuestion
  - `[OnlineMeetingId <String>]`: The unique identifier of onlineMeeting
  - `[ParticipantId <String>]`: The unique identifier of participant
  - `[PresenceId <String>]`: The unique identifier of presence
  - `[SessionId <String>]`: The unique identifier of session
  - `[ToDateTime <DateTime?>]`: Usage: toDateTime={toDateTime}
  - `[UserId <String>]`: The unique identifier of user

TRANSFEREE <IMicrosoftGraphParticipantInfo>: participantInfo
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
  - `[ParticipantId <String>]`: The participant ID of the participant. Read-only.
  - `[Region <String>]`: The home region of the participant. This can be a country, a continent, or a larger geographic region. This does not change based on the participant's current physical location. Read-only.

TRANSFERTARGET <IMicrosoftGraphInvitationParticipantInfo>: invitationParticipantInfo
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
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

