---
external help file:
Module Name: Microsoft.Graph.Beta.CloudCommunications
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.cloudcommunications/invoke-mgrejectcommunicationcall
schema: 2.0.0
---

# Invoke-MgBetaRejectCommunicationCall

## SYNOPSIS
Enable a bot to reject an incoming call.
The incoming call request can be an invite from a participant in a group call or a peer-to-peer call.
If an invite to a group call is received, the notification will contain the **chatInfo** and **meetingInfo** parameters.
The bot is expected to answer or reject the call before the call times out.
The current timeout value is 15 seconds.
This API does not end existing calls that have already been answered.
Use delete call to end a call.

## SYNTAX

### RejectExpanded1 (Default)
```
Invoke-MgBetaRejectCommunicationCall -CallId <String> [-AdditionalProperties <Hashtable>] [-CallbackUri <String>]
 [-Reason <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Reject1
```
Invoke-MgBetaRejectCommunicationCall -CallId <String>
 -BodyParameter <IPaths4QrghdCommunicationsCallsCallIdMicrosoftGraphRejectPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### RejectViaIdentity1
```
Invoke-MgBetaRejectCommunicationCall -InputObject <ICloudCommunicationsIdentity>
 -BodyParameter <IPaths4QrghdCommunicationsCallsCallIdMicrosoftGraphRejectPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### RejectViaIdentityExpanded1
```
Invoke-MgBetaRejectCommunicationCall -InputObject <ICloudCommunicationsIdentity>
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

### Example 1: Using the Invoke-MgBetaRejectCommunicationCall Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
$params = @{
	Reason = "none"
}
Invoke-MgBetaRejectCommunicationCall -CallId $callId -BodyParameter $params
```

This example shows how to use the Invoke-MgBetaRejectCommunicationCall Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Using the Invoke-MgBetaRejectCommunicationCall Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
$params = @{
	Reason = "busy"
}
Invoke-MgBetaRejectCommunicationCall -CallId $callId -BodyParameter $params
```

This example shows how to use the Invoke-MgBetaRejectCommunicationCall Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: RejectExpanded1, RejectViaIdentityExpanded1
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IPaths4QrghdCommunicationsCallsCallIdMicrosoftGraphRejectPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Reject1, RejectViaIdentity1
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
Parameter Sets: RejectExpanded1, RejectViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CallId
key: id of call

```yaml
Type: System.String
Parameter Sets: Reject1, RejectExpanded1
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
Type: Microsoft.Graph.Beta.PowerShell.Models.ICloudCommunicationsIdentity
Parameter Sets: RejectViaIdentity1, RejectViaIdentityExpanded1
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
Parameter Sets: RejectExpanded1, RejectViaIdentityExpanded1
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

### Microsoft.Graph.Beta.PowerShell.Models.IPaths4QrghdCommunicationsCallsCallIdMicrosoftGraphRejectPostRequestbodyContentApplicationJsonSchema

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

