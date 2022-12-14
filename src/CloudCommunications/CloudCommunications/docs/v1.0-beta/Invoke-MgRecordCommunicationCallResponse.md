---
external help file:
Module Name: Microsoft.Graph.Beta.CloudCommunications
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.cloudcommunications/invoke-mgrecordcommunicationcallresponse
schema: 2.0.0
---

# Invoke-MgBetaRecordCommunicationCallResponse

## SYNOPSIS
Record a short audio response from the caller.
A bot can use this to capture a voice response from a caller after they are prompted for a response.
For more information about how to handle operations, see commsOperation This action is not intended to record the entire call.
The maximum length of recording is 2 minutes.
The recording is not saved permanently by the by the Cloud Communications Platform and is discarded shortly after the call ends.
The bot must download the recording promptly after the recording operation finishes by using the recordingLocation value that's given in the completed notification.

## SYNTAX

### RecordExpanded1 (Default)
```
Invoke-MgBetaRecordCommunicationCallResponse -CallId <String> [-AdditionalProperties <Hashtable>]
 [-BargeInAllowed] [-ClientContext <String>] [-InitialSilenceTimeoutInSeconds <Int32>]
 [-MaxRecordDurationInSeconds <Int32>] [-MaxSilenceTimeoutInSeconds <Int32>] [-PlayBeep]
 [-Prompts <IMicrosoftGraphPrompt[]>] [-StopTones <String[]>] [-StreamWhileRecording] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Record1
```
Invoke-MgBetaRecordCommunicationCallResponse -CallId <String>
 -BodyParameter <IPaths14Wb7KqCommunicationsCallsCallIdMicrosoftGraphRecordresponsePostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### RecordViaIdentity1
```
Invoke-MgBetaRecordCommunicationCallResponse -InputObject <ICloudCommunicationsIdentity>
 -BodyParameter <IPaths14Wb7KqCommunicationsCallsCallIdMicrosoftGraphRecordresponsePostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### RecordViaIdentityExpanded1
```
Invoke-MgBetaRecordCommunicationCallResponse -InputObject <ICloudCommunicationsIdentity>
 [-AdditionalProperties <Hashtable>] [-BargeInAllowed] [-ClientContext <String>]
 [-InitialSilenceTimeoutInSeconds <Int32>] [-MaxRecordDurationInSeconds <Int32>]
 [-MaxSilenceTimeoutInSeconds <Int32>] [-PlayBeep] [-Prompts <IMicrosoftGraphPrompt[]>]
 [-StopTones <String[]>] [-StreamWhileRecording] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Record a short audio response from the caller.
A bot can use this to capture a voice response from a caller after they are prompted for a response.
For more information about how to handle operations, see commsOperation This action is not intended to record the entire call.
The maximum length of recording is 2 minutes.
The recording is not saved permanently by the by the Cloud Communications Platform and is discarded shortly after the call ends.
The bot must download the recording promptly after the recording operation finishes by using the recordingLocation value that's given in the completed notification.

## EXAMPLES

### Example 1: Using the Invoke-MgBetaRecordCommunicationCallResponse Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
$params = @{
	BargeInAllowed = $true
	ClientContext = "d45324c1-fcb5-430a-902c-f20af696537c"
	Prompts = @(
		@{
			"@odata.type" = "#Microsoft.Graph.Beta.mediaPrompt"
		}
	)
	MaxRecordDurationInSeconds = 10
	InitialSilenceTimeoutInSeconds = 5
	MaxSilenceTimeoutInSeconds = 2
	PlayBeep = $true
	StopTones = @(
		"#"
		"1"
		"*"
	)
}
Invoke-MgBetaRecordCommunicationCallResponse -CallId $callId -BodyParameter $params
```

This example shows how to use the Invoke-MgBetaRecordCommunicationCallResponse Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: RecordExpanded1, RecordViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BargeInAllowed
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: RecordExpanded1, RecordViaIdentityExpanded1
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IPaths14Wb7KqCommunicationsCallsCallIdMicrosoftGraphRecordresponsePostRequestbodyContentApplicationJsonSchema
Parameter Sets: Record1, RecordViaIdentity1
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
Parameter Sets: Record1, RecordExpanded1
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
Parameter Sets: RecordExpanded1, RecordViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InitialSilenceTimeoutInSeconds
.

```yaml
Type: System.Int32
Parameter Sets: RecordExpanded1, RecordViaIdentityExpanded1
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
Parameter Sets: RecordViaIdentity1, RecordViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -MaxRecordDurationInSeconds
.

```yaml
Type: System.Int32
Parameter Sets: RecordExpanded1, RecordViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MaxSilenceTimeoutInSeconds
.

```yaml
Type: System.Int32
Parameter Sets: RecordExpanded1, RecordViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PlayBeep
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: RecordExpanded1, RecordViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Prompts
.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPrompt[]
Parameter Sets: RecordExpanded1, RecordViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StopTones
.

```yaml
Type: System.String[]
Parameter Sets: RecordExpanded1, RecordViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StreamWhileRecording
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: RecordExpanded1, RecordViaIdentityExpanded1
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

### Microsoft.Graph.Beta.PowerShell.Models.IPaths14Wb7KqCommunicationsCallsCallIdMicrosoftGraphRecordresponsePostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphRecordOperation1

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths14Wb7KqCommunicationsCallsCallIdMicrosoftGraphRecordresponsePostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[BargeInAllowed <Boolean?>]`: 
  - `[ClientContext <String>]`: 
  - `[InitialSilenceTimeoutInSeconds <Int32?>]`: 
  - `[MaxRecordDurationInSeconds <Int32?>]`: 
  - `[MaxSilenceTimeoutInSeconds <Int32?>]`: 
  - `[PlayBeep <Boolean?>]`: 
  - `[Prompts <IMicrosoftGraphPrompt[]>]`: 
  - `[StopTones <String[]>]`: 
  - `[StreamWhileRecording <Boolean?>]`: 

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

## RELATED LINKS

