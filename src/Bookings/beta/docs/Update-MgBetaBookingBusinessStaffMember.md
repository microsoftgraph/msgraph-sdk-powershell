---
external help file:
Module Name: Microsoft.Graph.Beta.Bookings
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.bookings/update-mgbetabookingbusinessstaffmember
schema: 2.0.0
---

# Update-MgBetaBookingBusinessStaffMember

## SYNOPSIS
Update the properties of a bookingStaffMember in the specified bookingBusiness.

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaBookingBusinessStaffMember -BookingBusinessId <String> -BookingStaffMemberId <String>
 [-AdditionalProperties <Hashtable>] [-AvailabilityIsAffectedByPersonalCalendar] [-ColorIndex <Int32>]
 [-CreatedDateTime <DateTime>] [-DisplayName <String>] [-EmailAddress <String>] [-Id <String>]
 [-IsEmailNotificationEnabled] [-LastUpdatedDateTime <DateTime>] [-MembershipStatus <String>] [-Role <String>]
 [-TimeZone <String>] [-UseBusinessHours] [-WorkingHours <IMicrosoftGraphBookingWorkHours[]>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaBookingBusinessStaffMember -BookingBusinessId <String> -BookingStaffMemberId <String>
 -BodyParameter <IMicrosoftGraphBookingStaffMember> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update1
```
Update-MgBetaBookingBusinessStaffMember -BookingBusinessId <String> -BookingStaffMemberId <String>
 -BodyParameter <IMicrosoftGraphBookingStaffMember> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateExpanded1
```
Update-MgBetaBookingBusinessStaffMember -BookingBusinessId <String> -BookingStaffMemberId <String>
 [-AdditionalProperties <Hashtable>] [-AvailabilityIsAffectedByPersonalCalendar] [-ColorIndex <Int32>]
 [-CreatedDateTime <DateTime>] [-DisplayName <String>] [-EmailAddress <String>] [-Id <String>]
 [-IsEmailNotificationEnabled] [-LastUpdatedDateTime <DateTime>] [-MembershipStatus <String>] [-Role <String>]
 [-TimeZone <String>] [-UseBusinessHours] [-WorkingHours <IMicrosoftGraphBookingWorkHours[]>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBetaBookingBusinessStaffMember -InputObject <IBookingsIdentity>
 -BodyParameter <IMicrosoftGraphBookingStaffMember> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity1
```
Update-MgBetaBookingBusinessStaffMember -InputObject <IBookingsIdentity>
 -BodyParameter <IMicrosoftGraphBookingStaffMember> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBetaBookingBusinessStaffMember -InputObject <IBookingsIdentity> [-AdditionalProperties <Hashtable>]
 [-AvailabilityIsAffectedByPersonalCalendar] [-ColorIndex <Int32>] [-CreatedDateTime <DateTime>]
 [-DisplayName <String>] [-EmailAddress <String>] [-Id <String>] [-IsEmailNotificationEnabled]
 [-LastUpdatedDateTime <DateTime>] [-MembershipStatus <String>] [-Role <String>] [-TimeZone <String>]
 [-UseBusinessHours] [-WorkingHours <IMicrosoftGraphBookingWorkHours[]>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded1
```
Update-MgBetaBookingBusinessStaffMember -InputObject <IBookingsIdentity> [-AdditionalProperties <Hashtable>]
 [-AvailabilityIsAffectedByPersonalCalendar] [-ColorIndex <Int32>] [-CreatedDateTime <DateTime>]
 [-DisplayName <String>] [-EmailAddress <String>] [-Id <String>] [-IsEmailNotificationEnabled]
 [-LastUpdatedDateTime <DateTime>] [-MembershipStatus <String>] [-Role <String>] [-TimeZone <String>]
 [-UseBusinessHours] [-WorkingHours <IMicrosoftGraphBookingWorkHours[]>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update the properties of a bookingStaffMember in the specified bookingBusiness.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.Bookings
$params = @{
	WorkingHours = @(
		@{
			"@odata.type" = "#microsoft.graph.bookingWorkHours"
			"Day@odata.type" = "#microsoft.graph.dayOfWeek"
			Day = "monday"
			"TimeSlots@odata.type" = "#Collection(microsoft.graph.bookingWorkTimeSlot)"
			TimeSlots = @(
			)
		}
		@{
			"@odata.type" = "#microsoft.graph.bookingWorkHours"
			"Day@odata.type" = "#microsoft.graph.dayOfWeek"
			Day = "tuesday"
			"TimeSlots@odata.type" = "#Collection(microsoft.graph.bookingWorkTimeSlot)"
			TimeSlots = @(
				@{
					"@odata.type" = "#microsoft.graph.bookingWorkTimeSlot"
					End = "17:00:00.0000000"
					Start = "08:00:00.0000000"
				}
			)
		}
		@{
			"@odata.type" = "#microsoft.graph.bookingWorkHours"
			"Day@odata.type" = "#microsoft.graph.dayOfWeek"
			Day = "wednesday"
			"TimeSlots@odata.type" = "#Collection(microsoft.graph.bookingWorkTimeSlot)"
			TimeSlots = @(
				@{
					"@odata.type" = "#microsoft.graph.bookingWorkTimeSlot"
					End = "17:00:00.0000000"
					Start = "08:00:00.0000000"
				}
			)
		}
		@{
			"@odata.type" = "#microsoft.graph.bookingWorkHours"
			"Day@odata.type" = "#microsoft.graph.dayOfWeek"
			Day = "thursday"
			"TimeSlots@odata.type" = "#Collection(microsoft.graph.bookingWorkTimeSlot)"
			TimeSlots = @(
				@{
					"@odata.type" = "#microsoft.graph.bookingWorkTimeSlot"
					End = "17:00:00.0000000"
					Start = "08:00:00.0000000"
				}
			)
		}
		@{
			"@odata.type" = "#microsoft.graph.bookingWorkHours"
			"Day@odata.type" = "#microsoft.graph.dayOfWeek"
			Day = "friday"
			"TimeSlots@odata.type" = "#Collection(microsoft.graph.bookingWorkTimeSlot)"
			TimeSlots = @(
				@{
					"@odata.type" = "#microsoft.graph.bookingWorkTimeSlot"
					End = "17:00:00.0000000"
					Start = "08:00:00.0000000"
				}
			)
		}
	)
}
Update-MgBetaBookingBusinessStaffMember -BookingBusinessId $bookingBusinessId -BookingStaffMemberId $bookingStaffMemberId -BodyParameter $params
```



## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AvailabilityIsAffectedByPersonalCalendar
True means that if the staff member is a Microsoft 365 user, the Bookings API would verify the staff member's availability in their personal calendar in Microsoft 365, before making a booking.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
Represents a staff member who provides services in a business.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphBookingStaffMember
Parameter Sets: Update, Update1, UpdateViaIdentity, UpdateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -BookingBusinessId
The unique identifier of bookingBusiness

```yaml
Type: System.String
Parameter Sets: Update, Update1, UpdateExpanded, UpdateExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BookingStaffMemberId
The unique identifier of bookingStaffMember

```yaml
Type: System.String
Parameter Sets: Update, Update1, UpdateExpanded, UpdateExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ColorIndex
Identifies a color to represent the staff member.
The color corresponds to the color palette in the Staff details page in the Bookings app.

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
A name for the derived entity, which interfaces with customers.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EmailAddress
The email address of the person.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
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
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IBookingsIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentity1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IsEmailNotificationEnabled
True indicates that a staff member will be notified via email when a booking assigned to them is created or changed.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastUpdatedDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MembershipStatus
bookingStaffMembershipStatus

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Role
bookingStaffRole

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TimeZone
The time zone of the staff member.
For a list of possible values, see dateTimeTimeZone.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UseBusinessHours
True means the staff member's availability is as specified in the businessHours property of the business.
False means the availability is determined by the staff member's workingHours property setting.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WorkingHours
The range of hours each day of the week that the staff member is available for booking.
By default, they are initialized to be the same as the businessHours property of the business.
To construct, see NOTES section for WORKINGHOURS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphBookingWorkHours[]
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
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

### Microsoft.Graph.Beta.PowerShell.Models.IBookingsIdentity

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphBookingStaffMember

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphBookingStaffMember

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphBookingStaffMember>`: Represents a staff member who provides services in a business.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[EmailAddress <String>]`: The email address of the person.
  - `[DisplayName <String>]`: A name for the derived entity, which interfaces with customers.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AvailabilityIsAffectedByPersonalCalendar <Boolean?>]`: True means that if the staff member is a Microsoft 365 user, the Bookings API would verify the staff member's availability in their personal calendar in Microsoft 365, before making a booking.
  - `[ColorIndex <Int32?>]`: Identifies a color to represent the staff member. The color corresponds to the color palette in the Staff details page in the Bookings app.
  - `[CreatedDateTime <DateTime?>]`: 
  - `[IsEmailNotificationEnabled <Boolean?>]`: True indicates that a staff member will be notified via email when a booking assigned to them is created or changed.
  - `[LastUpdatedDateTime <DateTime?>]`: 
  - `[MembershipStatus <String>]`: bookingStaffMembershipStatus
  - `[Role <String>]`: bookingStaffRole
  - `[TimeZone <String>]`: The time zone of the staff member. For a list of possible values, see dateTimeTimeZone.
  - `[UseBusinessHours <Boolean?>]`: True means the staff member's availability is as specified in the businessHours property of the business. False means the availability is determined by the staff member's workingHours property setting.
  - `[WorkingHours <IMicrosoftGraphBookingWorkHours[]>]`: The range of hours each day of the week that the staff member is available for booking. By default, they are initialized to be the same as the businessHours property of the business.
    - `[Day <String>]`: dayOfWeek
    - `[TimeSlots <IMicrosoftGraphBookingWorkTimeSlot[]>]`: A list of start/end times during a day.
      - `[End <String>]`: The time of the day when work stops. For example, 17:00:00.0000000.
      - `[Start <String>]`: The time of the day when work starts. For example, 08:00:00.0000000.

`INPUTOBJECT <IBookingsIdentity>`: Identity Parameter
  - `[AttendanceRecordId <String>]`: The unique identifier of attendanceRecord
  - `[BookingAppointmentId <String>]`: The unique identifier of bookingAppointment
  - `[BookingBusinessId <String>]`: The unique identifier of bookingBusiness
  - `[BookingCurrencyId <String>]`: The unique identifier of bookingCurrency
  - `[BookingCustomQuestionId <String>]`: The unique identifier of bookingCustomQuestion
  - `[BookingCustomerId <String>]`: The unique identifier of bookingCustomer
  - `[BookingServiceId <String>]`: The unique identifier of bookingService
  - `[BookingStaffMemberId <String>]`: The unique identifier of bookingStaffMember
  - `[BusinessScenarioId <String>]`: The unique identifier of businessScenario
  - `[BusinessScenarioTaskId <String>]`: The unique identifier of businessScenarioTask
  - `[MeetingAttendanceReportId <String>]`: The unique identifier of meetingAttendanceReport
  - `[PlannerPlanConfigurationLocalizationId <String>]`: The unique identifier of plannerPlanConfigurationLocalization
  - `[Role <String>]`: Usage: role='{role}'
  - `[UserId <String>]`: Usage: userId='{userId}'
  - `[VirtualEventId <String>]`: The unique identifier of virtualEvent
  - `[VirtualEventPresenterId <String>]`: The unique identifier of virtualEventPresenter
  - `[VirtualEventRegistrationId <String>]`: The unique identifier of virtualEventRegistration
  - `[VirtualEventSessionId <String>]`: The unique identifier of virtualEventSession
  - `[VirtualEventTownhallId <String>]`: The unique identifier of virtualEventTownhall
  - `[VirtualEventWebinarId <String>]`: The unique identifier of virtualEventWebinar

`WORKINGHOURS <IMicrosoftGraphBookingWorkHours[]>`: The range of hours each day of the week that the staff member is available for booking. By default, they are initialized to be the same as the businessHours property of the business.
  - `[Day <String>]`: dayOfWeek
  - `[TimeSlots <IMicrosoftGraphBookingWorkTimeSlot[]>]`: A list of start/end times during a day.
    - `[End <String>]`: The time of the day when work stops. For example, 17:00:00.0000000.
    - `[Start <String>]`: The time of the day when work starts. For example, 08:00:00.0000000.

## RELATED LINKS

