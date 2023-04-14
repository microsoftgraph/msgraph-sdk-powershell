---
external help file:
Module Name: Microsoft.Graph.CloudCommunications
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.cloudcommunications/stop-mgcommunicationcallmediaprocessing
schema: 2.0.0
---

# Stop-MgCommunicationCallMediaProcessing

## SYNOPSIS
Cancels processing for any in-progress media operations.
Media operations refer to the IVR operations playPrompt and recordResponse, which are by default queued to process in order.
The **cancelMediaProcessing** method cancels any operation that is in-process as well as operations that are queued.
For example, this API can be used to clean up the IVR operation queue for a new media operation.
However, it will not cancel a **ubscribeToTone** operation because it operates independent of any operation queue.

## SYNTAX

### CancelExpanded1 (Default)
```
Stop-MgCommunicationCallMediaProcessing -CallId <String> [-AdditionalProperties <Hashtable>]
 [-ClientContext <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Cancel1
```
Stop-MgCommunicationCallMediaProcessing -CallId <String>
 -BodyParameter <IPathsYp37FjCommunicationsCallsCallIdMicrosoftGraphCancelmediaprocessingPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CancelViaIdentity1
```
Stop-MgCommunicationCallMediaProcessing -InputObject <ICloudCommunicationsIdentity>
 -BodyParameter <IPathsYp37FjCommunicationsCallsCallIdMicrosoftGraphCancelmediaprocessingPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CancelViaIdentityExpanded1
```
Stop-MgCommunicationCallMediaProcessing -InputObject <ICloudCommunicationsIdentity>
 [-AdditionalProperties <Hashtable>] [-ClientContext <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Cancels processing for any in-progress media operations.
Media operations refer to the IVR operations playPrompt and recordResponse, which are by default queued to process in order.
The **cancelMediaProcessing** method cancels any operation that is in-process as well as operations that are queued.
For example, this API can be used to clean up the IVR operation queue for a new media operation.
However, it will not cancel a **ubscribeToTone** operation because it operates independent of any operation queue.

## EXAMPLES

### Example 1: Using the Stop-MgCommunicationCallMediaProcessing Cmdlet
```powershell
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	ClientContext = "clientContext-value"
}
Stop-MgCommunicationCallMediaProcessing -CallId $callId -BodyParameter $params
```

This example shows how to use the Stop-MgCommunicationCallMediaProcessing Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CancelExpanded1, CancelViaIdentityExpanded1
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
Type: Microsoft.Graph.PowerShell.Models.IPathsYp37FjCommunicationsCallsCallIdMicrosoftGraphCancelmediaprocessingPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Cancel1, CancelViaIdentity1
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
Parameter Sets: Cancel1, CancelExpanded1
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
Parameter Sets: CancelExpanded1, CancelViaIdentityExpanded1
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
Parameter Sets: CancelViaIdentity1, CancelViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### Microsoft.Graph.PowerShell.Models.IPathsYp37FjCommunicationsCallsCallIdMicrosoftGraphCancelmediaprocessingPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCancelMediaProcessingOperation

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPathsYp37FjCommunicationsCallsCallIdMicrosoftGraphCancelmediaprocessingPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ClientContext <String>]`: 

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

## RELATED LINKS

