---
external help file:
Module Name: Microsoft.Graph.CloudCommunications
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.cloudcommunications/send-mgcommunicationonlinemeetingvirtualappointmentremindersm
schema: 2.0.0
---

# Send-MgCommunicationOnlineMeetingVirtualAppointmentReminderSm

## SYNOPSIS
Send an SMS reminder to external attendees for a Teams virtual appointment.
This feature requires Teams premium and attendees must have a valid United States phone number to receive SMS notifications.

## SYNTAX

### SendExpanded (Default)
```
Send-MgCommunicationOnlineMeetingVirtualAppointmentReminderSm -OnlineMeetingId <String>
 [-AdditionalProperties <Hashtable>] [-Attendees <IMicrosoftGraphAttendeeNotificationInfo[]>]
 [-RemindBeforeTimeInMinutesType <String>] [-ResponseHeadersVariable <String>] [-Headers <IDictionary>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Send
```
Send-MgCommunicationOnlineMeetingVirtualAppointmentReminderSm -OnlineMeetingId <String>
 -BodyParameter <IPaths1Hwkb04CommunicationsOnlinemeetingsOnlinemeetingIdMicrosoftGraphSendvirtualappointmentremindersmsPostRequestbodyContentApplicationJsonSchema>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### SendViaIdentity
```
Send-MgCommunicationOnlineMeetingVirtualAppointmentReminderSm -InputObject <ICloudCommunicationsIdentity>
 -BodyParameter <IPaths1Hwkb04CommunicationsOnlinemeetingsOnlinemeetingIdMicrosoftGraphSendvirtualappointmentremindersmsPostRequestbodyContentApplicationJsonSchema>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### SendViaIdentityExpanded
```
Send-MgCommunicationOnlineMeetingVirtualAppointmentReminderSm -InputObject <ICloudCommunicationsIdentity>
 [-AdditionalProperties <Hashtable>] [-Attendees <IMicrosoftGraphAttendeeNotificationInfo[]>]
 [-RemindBeforeTimeInMinutesType <String>] [-ResponseHeadersVariable <String>] [-Headers <IDictionary>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Send an SMS reminder to external attendees for a Teams virtual appointment.
This feature requires Teams premium and attendees must have a valid United States phone number to receive SMS notifications.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```



### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```



## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: SendExpanded, SendViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Attendees
.
To construct, see NOTES section for ATTENDEES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAttendeeNotificationInfo[]
Parameter Sets: SendExpanded, SendViaIdentityExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IPaths1Hwkb04CommunicationsOnlinemeetingsOnlinemeetingIdMicrosoftGraphSendvirtualappointmentremindersmsPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Send, SendViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Headers
Optional headers that will be added to the request.

```yaml
Type: System.Collections.IDictionary
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.ICloudCommunicationsIdentity
Parameter Sets: SendViaIdentity, SendViaIdentityExpanded
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
Parameter Sets: Send, SendExpanded
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

### -RemindBeforeTimeInMinutesType
remindBeforeTimeInMinutesType

```yaml
Type: System.String
Parameter Sets: SendExpanded, SendViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResponseHeadersVariable
Optional Response Headers Variable.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: RHV

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

### Microsoft.Graph.PowerShell.Models.IPaths1Hwkb04CommunicationsOnlinemeetingsOnlinemeetingIdMicrosoftGraphSendvirtualappointmentremindersmsPostRequestbodyContentApplicationJsonSchema

### System.Collections.IDictionary

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`ATTENDEES <IMicrosoftGraphAttendeeNotificationInfo[]>`: .
  - `[PhoneNumber <String>]`: The phone number of the external attendee. Required.
  - `[TimeZone <String>]`: The time zone of the external attendee. The timeZone property can be set to any of the time zones currently supported by Windows. Required.

`BODYPARAMETER <IPaths1Hwkb04CommunicationsOnlinemeetingsOnlinemeetingIdMicrosoftGraphSendvirtualappointmentremindersmsPostRequestbodyContentApplicationJsonSchema>`: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Attendees <IMicrosoftGraphAttendeeNotificationInfo[]>]`: 
    - `[PhoneNumber <String>]`: The phone number of the external attendee. Required.
    - `[TimeZone <String>]`: The time zone of the external attendee. The timeZone property can be set to any of the time zones currently supported by Windows. Required.
  - `[RemindBeforeTimeInMinutesType <String>]`: remindBeforeTimeInMinutesType

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

