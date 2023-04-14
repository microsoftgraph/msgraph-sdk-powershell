---
external help file:
Module Name: Microsoft.Graph.CloudCommunications
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.cloudcommunications/get-mguseronlinemeetingtranscriptcontent
schema: 2.0.0
---

# Get-MgUserOnlineMeetingTranscriptContent

## SYNOPSIS
A field that represents the content of the transcript.
Read-only.

## SYNTAX

### Get (Default)
```
Get-MgUserOnlineMeetingTranscriptContent -CallTranscriptId <String> -OnlineMeetingId <String> -UserId <String>
 -OutFile <String> [-PassThru] [<CommonParameters>]
```

### GetViaIdentity
```
Get-MgUserOnlineMeetingTranscriptContent -InputObject <ICloudCommunicationsIdentity> -OutFile <String>
 [-PassThru] [<CommonParameters>]
```

## DESCRIPTION
A field that represents the content of the transcript.
Read-only.

## EXAMPLES

### Example 1: Using the Get-MgUserOnlineMeetingTranscriptContent Cmdlet
```powershell
Import-Module Microsoft.Graph.CloudCommunications
Get-MgUserOnlineMeetingTranscriptContent -UserId $userId -OnlineMeetingId $onlineMeetingId -CallTranscriptId $callTranscriptId
```

This example shows how to use the Get-MgUserOnlineMeetingTranscriptContent Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Using the Get-MgUserOnlineMeetingTranscriptContent Cmdlet
```powershell
Import-Module Microsoft.Graph.CloudCommunications
Get-MgUserOnlineMeetingTranscriptContent -UserId $userId -OnlineMeetingId $onlineMeetingId -CallTranscriptId $callTranscriptId -Format "text/vtt" 
```

This example shows how to use the Get-MgUserOnlineMeetingTranscriptContent Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 3: Using the Get-MgUserOnlineMeetingTranscriptContent Cmdlet
```powershell
Import-Module Microsoft.Graph.CloudCommunications
Get-MgUserOnlineMeetingTranscriptContent -UserId $userId -OnlineMeetingId $onlineMeetingId -CallTranscriptId $callTranscriptId -Format "text/vtt" 
```

This example shows how to use the Get-MgUserOnlineMeetingTranscriptContent Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 4: Using the Get-MgUserOnlineMeetingTranscriptContent Cmdlet
```powershell
Import-Module Microsoft.Graph.CloudCommunications
Get-MgUserOnlineMeetingTranscriptContent -UserId $userId -OnlineMeetingId $onlineMeetingId -CallTranscriptId $callTranscriptId
```

This example shows how to use the Get-MgUserOnlineMeetingTranscriptContent Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -CallTranscriptId
The unique identifier of callTranscript

```yaml
Type: System.String
Parameter Sets: Get
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
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -OnlineMeetingId
The unique identifier of onlineMeeting

```yaml
Type: System.String
Parameter Sets: Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OutFile
Path to write output file to

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
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

### -UserId
The unique identifier of user

```yaml
Type: System.String
Parameter Sets: Get
Aliases:

Required: True
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

