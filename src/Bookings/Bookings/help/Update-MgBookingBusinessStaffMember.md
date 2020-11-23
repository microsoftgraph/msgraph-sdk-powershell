---
external help file: Microsoft.Graph.Bookings-help.xml
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
 [-DisplayName <String>] [-EmailAddress <String>] [-Id <String>] [-Role <String>] [-UseBusinessHours]
 [-WorkingHours <IMicrosoftGraphBookingWorkHours[]>] [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Update
```
Update-MgBookingBusinessStaffMember -BookingBusinessId <String> -BookingStaffMemberId <String>
 -BodyParameter <IMicrosoftGraphBookingStaffMember> [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBookingBusinessStaffMember -InputObject <IBookingsIdentity> [-AdditionalProperties <Hashtable>]
 [-AvailabilityIsAffectedByPersonalCalendar] [-ColorIndex <Int32>] [-DisplayName <String>]
 [-EmailAddress <String>] [-Id <String>] [-Role <String>] [-UseBusinessHours]
 [-WorkingHours <IMicrosoftGraphBookingWorkHours[]>] [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBookingBusinessStaffMember -InputObject <IBookingsIdentity>
 -BodyParameter <IMicrosoftGraphBookingStaffMember> [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property staffMembers in bookingBusinesses

## EXAMPLES

### EXAMPLE 1
```
{{ Add code here }}
```

{{ Add output here }}

### EXAMPLE 2
```
{{ Add code here }}
```

{{ Add output here }}

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AvailabilityIsAffectedByPersonalCalendar
.

```yaml
Type: SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
Represents a staff member who provides services in a business.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphBookingStaffMember
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
Type: String
Parameter Sets: UpdateExpanded, Update
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
Type: String
Parameter Sets: UpdateExpanded, Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ColorIndex
.

```yaml
Type: Int32
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
Display name of this entity.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EmailAddress
The e-mail address of this person.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
Read-only.

```yaml
Type: String
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
Type: IBookingsIdentity
Parameter Sets: UpdateViaIdentityExpanded, UpdateViaIdentity
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
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -Role
bookingStaffRole

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UseBusinessHours
.

```yaml
Type: SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -WorkingHours
.
To construct, see NOTES section for WORKINGHOURS properties and create a hash table.

```yaml
Type: IMicrosoftGraphBookingWorkHours[]
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
Type: SwitchParameter
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
Type: SwitchParameter
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
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

BODYPARAMETER \<IMicrosoftGraphBookingStaffMember\>: Represents a staff member who provides services in a business.
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[EmailAddress \<String\>\]: The e-mail address of this person.
  \[DisplayName \<String\>\]: Display name of this entity.
  \[Id \<String\>\]: Read-only.
  \[AvailabilityIsAffectedByPersonalCalendar \<Boolean?\>\]: 
  \[ColorIndex \<Int32?\>\]: 
  \[Role \<String\>\]: bookingStaffRole
  \[UseBusinessHours \<Boolean?\>\]: 
  \[WorkingHours \<IMicrosoftGraphBookingWorkHours\[\]\>\]: 
    \[Day \<String\>\]: dayOfWeek
    \[TimeSlots \<IMicrosoftGraphBookingWorkTimeSlot\[\]\>\]: A list of start/end times during a day.
      \[End \<String\>\]: 
      \[Start \<String\>\]: 

INPUTOBJECT \<IBookingsIdentity\>: Identity Parameter
  \[BookingAppointmentId \<String\>\]: key: id of bookingAppointment
  \[BookingBusinessId \<String\>\]: key: id of bookingBusiness
  \[BookingCurrencyId \<String\>\]: key: id of bookingCurrency
  \[BookingCustomerId \<String\>\]: key: id of bookingCustomer
  \[BookingServiceId \<String\>\]: key: id of bookingService
  \[BookingStaffMemberId \<String\>\]: key: id of bookingStaffMember

WORKINGHOURS \<IMicrosoftGraphBookingWorkHours\[\]\>: .
  \[Day \<String\>\]: dayOfWeek
  \[TimeSlots \<IMicrosoftGraphBookingWorkTimeSlot\[\]\>\]: A list of start/end times during a day.
    \[End \<String\>\]: 
    \[Start \<String\>\]:

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.bookings/update-mgbookingbusinessstaffmember](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.bookings/update-mgbookingbusinessstaffmember)

