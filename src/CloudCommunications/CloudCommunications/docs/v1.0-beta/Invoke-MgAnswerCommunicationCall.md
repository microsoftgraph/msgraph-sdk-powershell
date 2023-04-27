---
external help file:
Module Name: Microsoft.Graph.CloudCommunications
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.cloudcommunications/invoke-mganswercommunicationcall
schema: 2.0.0
---

# Invoke-MgAnswerCommunicationCall

## SYNOPSIS
Invoke action answer

## SYNTAX

### AnswerExpanded1 (Default)
```
Invoke-MgAnswerCommunicationCall -CallId <String> [-AcceptedModalities <String[]>]
 [-AdditionalProperties <Hashtable>] [-CallbackUri <String>] [-CallOptions <Hashtable>]
 [-MediaConfig <IMicrosoftGraphMediaConfig1>] [-ParticipantCapacity <Int32>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Answer1
```
Invoke-MgAnswerCommunicationCall -CallId <String>
 -BodyParameter <IPathsQvpqn4CommunicationsCallsCallIdMicrosoftGraphAnswerPostRequestbodyContentApplicationJsonSchema1>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### AnswerViaIdentity1
```
Invoke-MgAnswerCommunicationCall -InputObject <ICloudCommunicationsIdentity>
 -BodyParameter <IPathsQvpqn4CommunicationsCallsCallIdMicrosoftGraphAnswerPostRequestbodyContentApplicationJsonSchema1>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### AnswerViaIdentityExpanded1
```
Invoke-MgAnswerCommunicationCall -InputObject <ICloudCommunicationsIdentity> [-AcceptedModalities <String[]>]
 [-AdditionalProperties <Hashtable>] [-CallbackUri <String>] [-CallOptions <Hashtable>]
 [-MediaConfig <IMicrosoftGraphMediaConfig1>] [-ParticipantCapacity <Int32>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Invoke action answer

## EXAMPLES

### Example 1: Using the Invoke-MgAnswerCommunicationCall Cmdlet
```powershell
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	CallbackUri = "https://bot.contoso.com/api/calls"
	AcceptedModalities = @(
		"audio"
	)
	MediaConfig = @{
		"@odata.type" = "#microsoft.graph.appHostedMediaConfig"
		Blob = "<Media Session Configuration Blob>"
	}
}
Invoke-MgAnswerCommunicationCall -CallId $callId -BodyParameter $params
```

This example shows how to use the Invoke-MgAnswerCommunicationCall Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Using the Invoke-MgAnswerCommunicationCall Cmdlet
```powershell
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	CallbackUri = "callbackUri-value"
	MediaConfig = @{
		"@odata.type" = "#microsoft.graph.appHostedMediaConfig"
		Blob = "<Media Session Configuration Blob>"
	}
	AcceptedModalities = @(
		"audio"
	)
	CallOptions = @{
		"@odata.type" = "#microsoft.graph.incomingCallOptions"
		IsContentSharingNotificationEnabled = $true
	}
	ParticipantCapacity = 200
}
Invoke-MgAnswerCommunicationCall -CallId $callId -BodyParameter $params
```

This example shows how to use the Invoke-MgAnswerCommunicationCall Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -AcceptedModalities
.

```yaml
Type: System.String[]
Parameter Sets: AnswerExpanded1, AnswerViaIdentityExpanded1
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
Parameter Sets: AnswerExpanded1, AnswerViaIdentityExpanded1
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
Type: Microsoft.Graph.PowerShell.Models.IPathsQvpqn4CommunicationsCallsCallIdMicrosoftGraphAnswerPostRequestbodyContentApplicationJsonSchema1
Parameter Sets: Answer1, AnswerViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CallbackUri
.

```yaml
Type: System.String
Parameter Sets: AnswerExpanded1, AnswerViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CallId
The unique identifier of call

```yaml
Type: System.String
Parameter Sets: Answer1, AnswerExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CallOptions
incomingCallOptions

```yaml
Type: System.Collections.Hashtable
Parameter Sets: AnswerExpanded1, AnswerViaIdentityExpanded1
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
Type: Microsoft.Graph.PowerShell.Models.ICloudCommunicationsIdentity
Parameter Sets: AnswerViaIdentity1, AnswerViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -MediaConfig
mediaConfig
To construct, please use Get-Help -Online and see NOTES section for MEDIACONFIG properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMediaConfig1
Parameter Sets: AnswerExpanded1, AnswerViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ParticipantCapacity
.

```yaml
Type: System.Int32
Parameter Sets: AnswerExpanded1, AnswerViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
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

### Microsoft.Graph.PowerShell.Models.IPathsQvpqn4CommunicationsCallsCallIdMicrosoftGraphAnswerPostRequestbodyContentApplicationJsonSchema1

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPathsQvpqn4CommunicationsCallsCallIdMicrosoftGraphAnswerPostRequestbodyContentApplicationJsonSchema1>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AcceptedModalities <String[]>]`: 
  - `[CallOptions <IMicrosoftGraphIncomingCallOptions>]`: incomingCallOptions
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[HideBotAfterEscalation <Boolean?>]`: Indicates whether to hide the app after the call is escalated.
    - `[IsContentSharingNotificationEnabled <Boolean?>]`: Indicates whether content sharing notifications should be enabled for the call.
  - `[CallbackUri <String>]`: 
  - `[MediaConfig <IMicrosoftGraphMediaConfig1>]`: mediaConfig
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[RemoveFromDefaultAudioGroup <Boolean?>]`: 
  - `[ParticipantCapacity <Int32?>]`: 

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

MEDIACONFIG <IMicrosoftGraphMediaConfig1>: mediaConfig
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[RemoveFromDefaultAudioGroup <Boolean?>]`: 

## RELATED LINKS

