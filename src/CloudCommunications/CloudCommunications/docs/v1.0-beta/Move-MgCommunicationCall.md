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

### TransferExpanded1 (Default)
```
Move-MgCommunicationCall -CallId <String> [-AdditionalProperties <Hashtable>]
 [-Transferee <IMicrosoftGraphParticipantInfo1>] [-TransferTarget <IMicrosoftGraphInvitationParticipantInfo1>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Transfer1
```
Move-MgCommunicationCall -CallId <String>
 -BodyParameter <IPaths4Zbm7LCommunicationsCallsCallIdMicrosoftGraphTransferPostRequestbodyContentApplicationJsonSchema1>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### TransferViaIdentity1
```
Move-MgCommunicationCall -InputObject <ICloudCommunicationsIdentity>
 -BodyParameter <IPaths4Zbm7LCommunicationsCallsCallIdMicrosoftGraphTransferPostRequestbodyContentApplicationJsonSchema1>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### TransferViaIdentityExpanded1
```
Move-MgCommunicationCall -InputObject <ICloudCommunicationsIdentity> [-AdditionalProperties <Hashtable>]
 [-Transferee <IMicrosoftGraphParticipantInfo1>] [-TransferTarget <IMicrosoftGraphInvitationParticipantInfo1>]
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
				TenantId = "72f988bf-86f1-41af-91ab-2d7cd011db47"
				DisplayName = "Heidi Steen"
			}
		}
		LanguageId = "languageId-value"
		Region = "region-value"
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
				TenantId = "72f988bf-86f1-41af-91ab-2d7cd011db47"
				DisplayName = "Heidi Steen"
			}
		}
		LanguageId = "en-us"
		Region = "amer"
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
				TenantId = "72f988bf-86f1-41af-91ab-2d7cd011db47"
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
	LanguageId = "languageId-value"
	Region = "region-value"
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
Parameter Sets: TransferExpanded1, TransferViaIdentityExpanded1
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
Type: Microsoft.Graph.PowerShell.Models.IPaths4Zbm7LCommunicationsCallsCallIdMicrosoftGraphTransferPostRequestbodyContentApplicationJsonSchema1
Parameter Sets: Transfer1, TransferViaIdentity1
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
Parameter Sets: Transfer1, TransferExpanded1
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
Parameter Sets: TransferViaIdentity1, TransferViaIdentityExpanded1
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphParticipantInfo1
Parameter Sets: TransferExpanded1, TransferViaIdentityExpanded1
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphInvitationParticipantInfo1
Parameter Sets: TransferExpanded1, TransferViaIdentityExpanded1
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

### Microsoft.Graph.PowerShell.Models.IPaths4Zbm7LCommunicationsCallsCallIdMicrosoftGraphTransferPostRequestbodyContentApplicationJsonSchema1

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths4Zbm7LCommunicationsCallsCallIdMicrosoftGraphTransferPostRequestbodyContentApplicationJsonSchema1>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[TransferTarget <IMicrosoftGraphInvitationParticipantInfo1>]`: invitationParticipantInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[EndpointType <String>]`: endpointType
    - `[Hidden <Boolean?>]`: 
    - `[Identity <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Application <IMicrosoftGraphIdentity>]`: identity
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
        - `[Id <String>]`: Unique identifier for the identity.
      - `[Device <IMicrosoftGraphIdentity>]`: identity
      - `[User <IMicrosoftGraphIdentity>]`: identity
    - `[ParticipantId <String>]`: Optional. The ID of the target participant.
    - `[RemoveFromDefaultAudioRoutingGroup <Boolean?>]`: 
    - `[ReplacesCallId <String>]`: Optional. The call which the target identity is currently a part of. For peer-to-peer case, the call will be dropped once the participant is added successfully.
  - `[Transferee <IMicrosoftGraphParticipantInfo1>]`: participantInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[CountryCode <String>]`: The ISO 3166-1 Alpha-2 country code of the participant's best estimated physical location at the start of the call. Read-only.
    - `[EndpointType <String>]`: endpointType
    - `[Identity <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LanguageId <String>]`: The language culture string. Read-only.
    - `[NonAnonymizedIdentity <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[ParticipantId <String>]`: The participant ID of the participant. Read-only.
    - `[PlatformId <String>]`: The client platform ID of the participant. Read-only.
    - `[Region <String>]`: The home region of the participant. This can be a country, a continent, or a larger geographic region. This does not change based on the participant's current physical location, unlike countryCode. Read-only.

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

TRANSFEREE <IMicrosoftGraphParticipantInfo1>: participantInfo
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

TRANSFERTARGET <IMicrosoftGraphInvitationParticipantInfo1>: invitationParticipantInfo
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[EndpointType <String>]`: endpointType
  - `[Hidden <Boolean?>]`: 
  - `[Identity <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[ParticipantId <String>]`: Optional. The ID of the target participant.
  - `[RemoveFromDefaultAudioRoutingGroup <Boolean?>]`: 
  - `[ReplacesCallId <String>]`: Optional. The call which the target identity is currently a part of. For peer-to-peer case, the call will be dropped once the participant is added successfully.

## RELATED LINKS

