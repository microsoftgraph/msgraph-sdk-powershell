---
external help file:
Module Name: Microsoft.Graph.CloudCommunications
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.cloudcommunications/invoke-mgkeepcommunicationcallalive
schema: 2.0.0
---

# Invoke-MgKeepCommunicationCallAlive

## SYNOPSIS
Make a request to this API every 15 to 45 minutes to ensure that an ongoing call remains active.
A call that does not receive this request within 45 minutes is considered inactive and will subsequently end.
At least one successful request must be made within 45 minutes of the previous request, or the start of the call.
We recommend that you send a request in shorter time intervals (every 15 minutes).
Make sure that these requests are successful to prevent the call from timing out and ending.
Attempting to send a request to a call that has already ended will result in a 404 Not-Found error.
The resources related to the call should be cleaned up on the application side.

## SYNTAX

### Keep (Default)
```
Invoke-MgKeepCommunicationCallAlive -CallId <String> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### KeepViaIdentity
```
Invoke-MgKeepCommunicationCallAlive -InputObject <ICloudCommunicationsIdentity> [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Make a request to this API every 15 to 45 minutes to ensure that an ongoing call remains active.
A call that does not receive this request within 45 minutes is considered inactive and will subsequently end.
At least one successful request must be made within 45 minutes of the previous request, or the start of the call.
We recommend that you send a request in shorter time intervals (every 15 minutes).
Make sure that these requests are successful to prevent the call from timing out and ending.
Attempting to send a request to a call that has already ended will result in a 404 Not-Found error.
The resources related to the call should be cleaned up on the application side.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Import-Module Microsoft.Graph.CloudCommunications
```

Invoke-MgKeepCommunicationCallAlive -CallId $callId

## PARAMETERS

### -CallId
The unique identifier of call

```yaml
Type: System.String
Parameter Sets: Keep
Aliases:

Required: True
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
Parameter Sets: KeepViaIdentity
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

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


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

