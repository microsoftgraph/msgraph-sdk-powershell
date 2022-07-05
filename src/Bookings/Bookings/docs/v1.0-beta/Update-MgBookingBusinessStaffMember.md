---
external help file:
Module Name: Microsoft.Graph.Bookings
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.bookings/update-mgbookingbusinessstaffmember
schema: 2.0.0
---

# Update-MgBookingBusinessStaffMember

## SYNOPSIS
Update the navigation property staffMembers in bookingBusinesses

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBookingBusinessStaffMember -BookingBusinessId <String> -BookingStaffMemberId <String>
 [-AdditionalProperties <Hashtable>] [-AvailabilityIsAffectedByPersonalCalendar] [-ColorIndex <Int32>]
 [-DisplayName <String>] [-EmailAddress <String>] [-Id <String>] [-IsEmailNotificationEnabled]
 [-Role <String>] [-TimeZone <String>] [-UseBusinessHours] [-WorkingHours <IMicrosoftGraphBookingWorkHours[]>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBookingBusinessStaffMember -BookingBusinessId <String> -BookingStaffMemberId <String>
 -BodyParameter <IMicrosoftGraphBookingStaffMember> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBookingBusinessStaffMember -InputObject <IBookingsIdentity>
 -BodyParameter <IMicrosoftGraphBookingStaffMember> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBookingBusinessStaffMember -InputObject <IBookingsIdentity> [-AdditionalProperties <Hashtable>]
 [-AvailabilityIsAffectedByPersonalCalendar] [-ColorIndex <Int32>] [-DisplayName <String>]
 [-EmailAddress <String>] [-Id <String>] [-IsEmailNotificationEnabled] [-Role <String>] [-TimeZone <String>]
 [-UseBusinessHours] [-WorkingHours <IMicrosoftGraphBookingWorkHours[]>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property staffMembers in bookingBusinesses

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

### -AvailabilityIsAffectedByPersonalCalendar
True means that if the staff member is a Microsoft 365 user, the Bookings API would verify the staff member's availability in their personal calendar in Microsoft 365, before making a booking.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
Represents a staff member who provides services in a business.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphBookingStaffMember
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -BookingBusinessId
key: id of bookingBusiness

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

### -BookingStaffMemberId
key: id of bookingStaffMember

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

### -ColorIndex
Identifies a color to represent the staff member.
The color corresponds to the color palette in the Staff details page in the Bookings app.

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
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

### -InputObject
Identity Parameter
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

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

### -IsEmailNotificationEnabled
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
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

### -Role
bookingStaffRole

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

### -TimeZone
The time zone of the staff member.
For a list of possible values, see dateTimeTimeZone.

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

### -UseBusinessHours
True means the staff member's availability is as specified in the businessHours property of the business.
False means the availability is determined by the staff member's workingHours property setting.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
To construct, please use Get-Help -Online and see NOTES section for WORKINGHOURS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphBookingWorkHours[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IBookingsIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphBookingStaffMember

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphBookingStaffMember>: Represents a staff member who provides services in a business.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[EmailAddress <String>]`: The email address of the person.
  - `[DisplayName <String>]`: A name for the derived entity, which interfaces with customers.
  - `[Id <String>]`: 
  - `[AvailabilityIsAffectedByPersonalCalendar <Boolean?>]`: True means that if the staff member is a Microsoft 365 user, the Bookings API would verify the staff member's availability in their personal calendar in Microsoft 365, before making a booking.
  - `[ColorIndex <Int32?>]`: Identifies a color to represent the staff member. The color corresponds to the color palette in the Staff details page in the Bookings app.
  - `[IsEmailNotificationEnabled <Boolean?>]`: 
  - `[Role <String>]`: bookingStaffRole
  - `[TimeZone <String>]`: The time zone of the staff member. For a list of possible values, see dateTimeTimeZone.
  - `[UseBusinessHours <Boolean?>]`: True means the staff member's availability is as specified in the businessHours property of the business. False means the availability is determined by the staff member's workingHours property setting.
  - `[WorkingHours <IMicrosoftGraphBookingWorkHours[]>]`: The range of hours each day of the week that the staff member is available for booking. By default, they are initialized to be the same as the businessHours property of the business.
    - `[Day <String>]`: dayOfWeek
    - `[TimeSlots <IMicrosoftGraphBookingWorkTimeSlot[]>]`: A list of start/end times during a day.
      - `[End <String>]`: The time of the day when work stops. For example, 17:00:00.0000000.
      - `[Start <String>]`: The time of the day when work starts. For example, 08:00:00.0000000.

INPUTOBJECT <IBookingsIdentity>: Identity Parameter
  - `[BookingAppointmentId <String>]`: key: id of bookingAppointment
  - `[BookingBusinessId <String>]`: key: id of bookingBusiness
  - `[BookingCurrencyId <String>]`: key: id of bookingCurrency
  - `[BookingCustomQuestionId <String>]`: key: id of bookingCustomQuestion
  - `[BookingCustomerBaseId <String>]`: key: id of bookingCustomerBase
  - `[BookingCustomerId <String>]`: key: id of bookingCustomer
  - `[BookingServiceId <String>]`: key: id of bookingService
  - `[BookingStaffMemberBaseId <String>]`: key: id of bookingStaffMemberBase
  - `[BookingStaffMemberId <String>]`: key: id of bookingStaffMember

WORKINGHOURS <IMicrosoftGraphBookingWorkHours[]>: The range of hours each day of the week that the staff member is available for booking. By default, they are initialized to be the same as the businessHours property of the business.
  - `[Day <String>]`: dayOfWeek
  - `[TimeSlots <IMicrosoftGraphBookingWorkTimeSlot[]>]`: A list of start/end times during a day.
    - `[End <String>]`: The time of the day when work stops. For example, 17:00:00.0000000.
    - `[Start <String>]`: The time of the day when work starts. For example, 08:00:00.0000000.

## RELATED LINKS

