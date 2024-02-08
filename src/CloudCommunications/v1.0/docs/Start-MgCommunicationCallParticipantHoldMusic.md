---
external help file:
Module Name: Microsoft.Graph.CloudCommunications
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.cloudcommunications/start-mgcommunicationcallparticipantholdmusic
schema: 2.0.0
---

# Start-MgCommunicationCallParticipantHoldMusic

## SYNOPSIS
Put a participant on hold and play music in the background.

## SYNTAX

### StartExpanded (Default)
```
Start-MgCommunicationCallParticipantHoldMusic -CallId <String> -ParticipantId <String>
 [-AdditionalProperties <Hashtable>] [-ClientContext <String>] [-CustomPrompt <Hashtable>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Start
```
Start-MgCommunicationCallParticipantHoldMusic -CallId <String> -ParticipantId <String>
 -BodyParameter <IPathsKtcw9WCommunicationsCallsCallIdParticipantsParticipantIdMicrosoftGraphStartholdmusicPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### StartViaIdentity
```
Start-MgCommunicationCallParticipantHoldMusic -InputObject <ICloudCommunicationsIdentity>
 -BodyParameter <IPathsKtcw9WCommunicationsCallsCallIdParticipantsParticipantIdMicrosoftGraphStartholdmusicPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### StartViaIdentityExpanded
```
Start-MgCommunicationCallParticipantHoldMusic -InputObject <ICloudCommunicationsIdentity>
 [-AdditionalProperties <Hashtable>] [-ClientContext <String>] [-CustomPrompt <Hashtable>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Put a participant on hold and play music in the background.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	CustomPrompt = @{
		"@odata.type" = "#microsoft.graph.mediaPrompt"
		MediaInfo = @{
			"@odata.type" = "#microsoft.graph.mediaInfo"
			Uri = "https://bot.contoso.com/onHold.wav"
		}
	}
	ClientContext = "d45324c1-fcb5-430a-902c-f20af696537c"
}
Start-MgCommunicationCallParticipantHoldMusic -CallId $callId -ParticipantId $participantId -BodyParameter $params
```



## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: StartExpanded, StartViaIdentityExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IPathsKtcw9WCommunicationsCallsCallIdParticipantsParticipantIdMicrosoftGraphStartholdmusicPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Start, StartViaIdentity
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
Parameter Sets: Start, StartExpanded
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
Parameter Sets: StartExpanded, StartViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CustomPrompt
prompt

```yaml
Type: System.Collections.Hashtable
Parameter Sets: StartExpanded, StartViaIdentityExpanded
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
Parameter Sets: StartViaIdentity, StartViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ParticipantId
The unique identifier of participant

```yaml
Type: System.String
Parameter Sets: Start, StartExpanded
Aliases:

Required: True
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

### Microsoft.Graph.PowerShell.Models.IPathsKtcw9WCommunicationsCallsCallIdParticipantsParticipantIdMicrosoftGraphStartholdmusicPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphStartHoldMusicOperation

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IPathsKtcw9WCommunicationsCallsCallIdParticipantsParticipantIdMicrosoftGraphStartholdmusicPostRequestbodyContentApplicationJsonSchema>`: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ClientContext <String>]`: 
  - `[CustomPrompt <IMicrosoftGraphPrompt>]`: prompt
    - `[(Any) <Object>]`: This indicates any property can be added to this object.

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

## RELATED LINKS

