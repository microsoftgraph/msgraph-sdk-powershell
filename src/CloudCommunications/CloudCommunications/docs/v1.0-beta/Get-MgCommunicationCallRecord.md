---
external help file:
Module Name: Microsoft.Graph.Beta.CloudCommunications
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.cloudcommunications/get-mgcommunicationcallrecord
schema: 2.0.0
---

# Get-MgBetaCommunicationCallRecord

## SYNOPSIS
Get callRecords from communications

## SYNTAX

### Get (Default)
```
Get-MgBetaCommunicationCallRecord -CallRecordId <String> [-ExpandProperty <String[]>] [-Property <String[]>]
 [<CommonParameters>]
```

### GetViaIdentity
```
Get-MgBetaCommunicationCallRecord -InputObject <ICloudCommunicationsIdentity> [-ExpandProperty <String[]>]
 [-Property <String[]>] [<CommonParameters>]
```

## DESCRIPTION
Get callRecords from communications

## EXAMPLES

### Example 1: Using the Get-MgBetaCommunicationCallRecord Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
Get-MgBetaCommunicationCallRecord -CallRecordId $callRecordId
```

This example shows how to use the Get-MgBetaCommunicationCallRecord Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Using the Get-MgBetaCommunicationCallRecord Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
Get-MgBetaCommunicationCallRecord -CallRecordId $callRecordId
```

This example shows how to use the Get-MgBetaCommunicationCallRecord Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 3: Using the Get-MgBetaCommunicationCallRecord Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
Get-MgBetaCommunicationCallRecord -CallRecordId $callRecordId -ExpandProperty "sessions(`$expand=segments)" 
```

This example shows how to use the Get-MgBetaCommunicationCallRecord Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 4: Using the Get-MgBetaCommunicationCallRecord Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
Get-MgBetaCommunicationCallRecord -CallRecordId $callRecordId
```

This example shows how to use the Get-MgBetaCommunicationCallRecord Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -CallRecordId
key: id of callRecord

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

### -ExpandProperty
Expand related entities

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases: Expand

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
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Property
Select properties to be returned

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases: Select

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

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCallRecordsCallRecord

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


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

