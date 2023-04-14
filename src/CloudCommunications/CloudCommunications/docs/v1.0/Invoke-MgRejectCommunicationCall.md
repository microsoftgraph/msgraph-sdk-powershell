---
external help file:
Module Name: Microsoft.Graph.CloudCommunications
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.cloudcommunications/invoke-mgrejectcommunicationcall
schema: 2.0.0
---

# Invoke-MgRejectCommunicationCall

## SYNOPSIS
Enable a bot to reject an incoming call.
The incoming call request can be an invite from a participant in a group call or a peer-to-peer call.
If an invite to a group call is received, the notification will contain the **chatInfo** and **meetingInfo** parameters.
The bot is expected to answer or reject the call before the call times out.
The current timeout value is 15 seconds.
This API does not end existing calls that have already been answered.
Use delete call to end a call.

## SYNTAX

### RejectExpanded (Default)
```
Invoke-MgRejectCommunicationCall -CallId <String> [-AdditionalProperties <Hashtable>] [-CallbackUri <String>]
 [-Reason <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Reject
```
Invoke-MgRejectCommunicationCall -CallId <String>
 -BodyParameter <IPaths4QrghdCommunicationsCallsCallIdMicrosoftGraphRejectPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### RejectViaIdentity
```
Invoke-MgRejectCommunicationCall -InputObject <ICloudCommunicationsIdentity>
 -BodyParameter <IPaths4QrghdCommunicationsCallsCallIdMicrosoftGraphRejectPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### RejectViaIdentityExpanded
```
Invoke-MgRejectCommunicationCall -InputObject <ICloudCommunicationsIdentity>
 [-AdditionalProperties <Hashtable>] [-CallbackUri <String>] [-Reason <String>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Enable a bot to reject an incoming call.
The incoming call request can be an invite from a participant in a group call or a peer-to-peer call.
If an invite to a group call is received, the notification will contain the **chatInfo** and **meetingInfo** parameters.
The bot is expected to answer or reject the call before the call times out.
The current timeout value is 15 seconds.
This API does not end existing calls that have already been answered.
Use delete call to end a call.

## EXAMPLES

### Example 1: Using the Invoke-MgRejectCommunicationCall Cmdlet
```powershell
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	Reason = "none"
}
Invoke-MgRejectCommunicationCall -CallId $callId -BodyParameter $params
```

This example shows how to use the Invoke-MgRejectCommunicationCall Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Using the Invoke-MgRejectCommunicationCall Cmdlet
```powershell
Import-Module Microsoft.Graph.CloudCommunications
$params = @{
	Reason = "busy"
}
Invoke-MgRejectCommunicationCall -CallId $callId -BodyParameter $params
```

This example shows how to use the Invoke-MgRejectCommunicationCall Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: RejectExpanded, RejectViaIdentityExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IPaths4QrghdCommunicationsCallsCallIdMicrosoftGraphRejectPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Reject, RejectViaIdentity
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
Parameter Sets: RejectExpanded, RejectViaIdentityExpanded
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
Parameter Sets: Reject, RejectExpanded
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
Parameter Sets: RejectViaIdentity, RejectViaIdentityExpanded
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

### -Reason
rejectReason

```yaml
Type: System.String
Parameter Sets: RejectExpanded, RejectViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IPaths4QrghdCommunicationsCallsCallIdMicrosoftGraphRejectPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths4QrghdCommunicationsCallsCallIdMicrosoftGraphRejectPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CallbackUri <String>]`: 
  - `[Reason <String>]`: rejectReason

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

