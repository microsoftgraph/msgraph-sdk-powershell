---
external help file:
Module Name: Microsoft.Graph.Bookings
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.bookings/update-mgvirtualeventwebinarregistration
schema: 2.0.0
---

# Update-MgVirtualEventWebinarRegistration

## SYNOPSIS
Update the navigation property registrations in solutions

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgVirtualEventWebinarRegistration -VirtualEventRegistrationId <String> -VirtualEventWebinarId <String>
 [-AdditionalProperties <Hashtable>] [-CancelationDateTime <DateTime>] [-Email <String>] [-FirstName <String>]
 [-Id <String>] [-LastName <String>] [-RegistrationDateTime <DateTime>]
 [-RegistrationQuestionAnswers <IMicrosoftGraphVirtualEventRegistrationQuestionAnswer[]>] [-Status <String>]
 [-UserId <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgVirtualEventWebinarRegistration -VirtualEventRegistrationId <String> -VirtualEventWebinarId <String>
 -BodyParameter <IMicrosoftGraphVirtualEventRegistration> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgVirtualEventWebinarRegistration -InputObject <IBookingsIdentity>
 -BodyParameter <IMicrosoftGraphVirtualEventRegistration> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgVirtualEventWebinarRegistration -InputObject <IBookingsIdentity> [-AdditionalProperties <Hashtable>]
 [-CancelationDateTime <DateTime>] [-Email <String>] [-FirstName <String>] [-Id <String>] [-LastName <String>]
 [-RegistrationDateTime <DateTime>]
 [-RegistrationQuestionAnswers <IMicrosoftGraphVirtualEventRegistrationQuestionAnswer[]>] [-Status <String>]
 [-UserId <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property registrations in solutions

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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
virtualEventRegistration
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphVirtualEventRegistration
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CancelationDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Email
.

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

### -FirstName
.

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
The unique identifier for an entity.
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
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IBookingsIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LastName
.

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

### -RegistrationDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RegistrationQuestionAnswers
.
To construct, see NOTES section for REGISTRATIONQUESTIONANSWERS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphVirtualEventRegistrationQuestionAnswer[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Status
virtualEventAttendeeRegistrationStatus

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

### -UserId
.

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

### -VirtualEventRegistrationId
The unique identifier of virtualEventRegistration

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

### -VirtualEventWebinarId
The unique identifier of virtualEventWebinar

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

### Microsoft.Graph.PowerShell.Models.IBookingsIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphVirtualEventRegistration

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphVirtualEventRegistration

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphVirtualEventRegistration>`: virtualEventRegistration
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[CancelationDateTime <DateTime?>]`: 
  - `[Email <String>]`: 
  - `[FirstName <String>]`: 
  - `[LastName <String>]`: 
  - `[RegistrationDateTime <DateTime?>]`: 
  - `[RegistrationQuestionAnswers <IMicrosoftGraphVirtualEventRegistrationQuestionAnswer[]>]`: 
    - `[BooleanValue <Boolean?>]`: 
    - `[DisplayName <String>]`: 
    - `[MultiChoiceValues <String[]>]`: 
    - `[QuestionId <String>]`: 
    - `[Value <String>]`: 
  - `[Status <String>]`: virtualEventAttendeeRegistrationStatus
  - `[UserId <String>]`: 

`INPUTOBJECT <IBookingsIdentity>`: Identity Parameter
  - `[AttendanceRecordId <String>]`: The unique identifier of attendanceRecord
  - `[BookingAppointmentId <String>]`: The unique identifier of bookingAppointment
  - `[BookingBusinessId <String>]`: The unique identifier of bookingBusiness
  - `[BookingCurrencyId <String>]`: The unique identifier of bookingCurrency
  - `[BookingCustomQuestionId <String>]`: The unique identifier of bookingCustomQuestion
  - `[BookingCustomerBaseId <String>]`: The unique identifier of bookingCustomerBase
  - `[BookingServiceId <String>]`: The unique identifier of bookingService
  - `[BookingStaffMemberBaseId <String>]`: The unique identifier of bookingStaffMemberBase
  - `[MeetingAttendanceReportId <String>]`: The unique identifier of meetingAttendanceReport
  - `[Role <String>]`: Usage: role='{role}'
  - `[UserId <String>]`: Usage: userId='{userId}'
  - `[VirtualEventId <String>]`: The unique identifier of virtualEvent
  - `[VirtualEventRegistrationId <String>]`: The unique identifier of virtualEventRegistration
  - `[VirtualEventSessionId <String>]`: The unique identifier of virtualEventSession
  - `[VirtualEventWebinarId <String>]`: The unique identifier of virtualEventWebinar

`REGISTRATIONQUESTIONANSWERS <IMicrosoftGraphVirtualEventRegistrationQuestionAnswer[]>`: .
  - `[BooleanValue <Boolean?>]`: 
  - `[DisplayName <String>]`: 
  - `[MultiChoiceValues <String[]>]`: 
  - `[QuestionId <String>]`: 
  - `[Value <String>]`: 

## RELATED LINKS

