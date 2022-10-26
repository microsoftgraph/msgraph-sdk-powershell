---
external help file:
Module Name: Microsoft.Graph.CloudCommunications
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.cloudcommunications/update-mguseronlinemeetingvirtualappointment
schema: 2.0.0
---

# Update-MgUserOnlineMeetingVirtualAppointment

## SYNOPSIS
Update the navigation property virtualAppointment in users

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgUserOnlineMeetingVirtualAppointment -OnlineMeetingId <String> -UserId <String>
 [-AdditionalProperties <Hashtable>] [-AppointmentClientJoinWebUrl <String>]
 [-AppointmentClients <IMicrosoftGraphVirtualAppointmentUser[]>] [-ExternalAppointmentId <String>]
 [-ExternalAppointmentUrl <String>] [-Id <String>] [-Settings <IMicrosoftGraphVirtualAppointmentSettings>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgUserOnlineMeetingVirtualAppointment -OnlineMeetingId <String> -UserId <String>
 -BodyParameter <IMicrosoftGraphVirtualAppointment> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgUserOnlineMeetingVirtualAppointment -InputObject <ICloudCommunicationsIdentity>
 -BodyParameter <IMicrosoftGraphVirtualAppointment> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgUserOnlineMeetingVirtualAppointment -InputObject <ICloudCommunicationsIdentity>
 [-AdditionalProperties <Hashtable>] [-AppointmentClientJoinWebUrl <String>]
 [-AppointmentClients <IMicrosoftGraphVirtualAppointmentUser[]>] [-ExternalAppointmentId <String>]
 [-ExternalAppointmentUrl <String>] [-Id <String>] [-Settings <IMicrosoftGraphVirtualAppointmentSettings>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property virtualAppointment in users

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AppointmentClientJoinWebUrl
The join web URL of the virtual appointment for clients with waiting room and browser join.
Optional.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AppointmentClients
The client information for the virtual appointment, including name, email, and SMS phone number.
Optional.
To construct, please use Get-Help -Online and see NOTES section for APPOINTMENTCLIENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphVirtualAppointmentUser[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
virtualAppointment
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphVirtualAppointment
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ExternalAppointmentId
The identifier of the appointment from the scheduling system, associated with the current virtual appointment.
Optional.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExternalAppointmentUrl
The URL of the appointment resource from the scheduling system, associated with the current virtual appointment.
Optional.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
The unique idenfier for an entity.
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -OnlineMeetingId
key: id of onlineMeeting

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
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

### -Settings
virtualAppointmentSettings
To construct, please use Get-Help -Online and see NOTES section for SETTINGS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphVirtualAppointmentSettings
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserId
key: id of user

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphVirtualAppointment

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


APPOINTMENTCLIENTS <IMicrosoftGraphVirtualAppointmentUser[]>: The client information for the virtual appointment, including name, email, and SMS phone number. Optional.
  - `[DisplayName <String>]`: The display name of the user who participates in a virtual appointment. Optional.
  - `[EmailAddress <String>]`: The email address of the user who participates in a virtual appointment. Optional.
  - `[SmsCapablePhoneNumber <String>]`: The phone number for sending SMS texts for the user who participates in a virtual appointment. Optional.

BODYPARAMETER <IMicrosoftGraphVirtualAppointment>: virtualAppointment
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[AppointmentClientJoinWebUrl <String>]`: The join web URL of the virtual appointment for clients with waiting room and browser join. Optional.
  - `[AppointmentClients <IMicrosoftGraphVirtualAppointmentUser[]>]`: The client information for the virtual appointment, including name, email, and SMS phone number. Optional.
    - `[DisplayName <String>]`: The display name of the user who participates in a virtual appointment. Optional.
    - `[EmailAddress <String>]`: The email address of the user who participates in a virtual appointment. Optional.
    - `[SmsCapablePhoneNumber <String>]`: The phone number for sending SMS texts for the user who participates in a virtual appointment. Optional.
  - `[ExternalAppointmentId <String>]`: The identifier of the appointment from the scheduling system, associated with the current virtual appointment. Optional.
  - `[ExternalAppointmentUrl <String>]`: The URL of the appointment resource from the scheduling system, associated with the current virtual appointment. Optional.
  - `[Settings <IMicrosoftGraphVirtualAppointmentSettings>]`: virtualAppointmentSettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AllowClientToJoinUsingBrowser <Boolean?>]`: Indicates whether the client can use the browser to join a virtual appointment. If set to false, the client can only use Microsoft Teams to join. Optional.

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

SETTINGS <IMicrosoftGraphVirtualAppointmentSettings>: virtualAppointmentSettings
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AllowClientToJoinUsingBrowser <Boolean?>]`: Indicates whether the client can use the browser to join a virtual appointment. If set to false, the client can only use Microsoft Teams to join. Optional.

## RELATED LINKS

