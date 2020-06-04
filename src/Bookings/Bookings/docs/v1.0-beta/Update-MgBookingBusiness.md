---
external help file:
Module Name: Microsoft.Graph.Bookings
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.bookings/update-mgbookingbusiness
schema: 2.0.0
---

# Update-MgBookingBusiness

## SYNOPSIS
Update entity in bookingBusinesses

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBookingBusiness -BookingBusinessId <String> [-AddressCity <String>]
 [-AddressCountryOrRegion <String>] [-AddressPostalCode <String>] [-AddressPostOfficeBox <String>]
 [-AddressState <String>] [-AddressStreet <String>] [-AddressType <String>]
 [-Appointments <IMicrosoftGraphBookingAppointment[]>] [-BusinessHours <IMicrosoftGraphBookingWorkHours[]>]
 [-BusinessType <String>] [-CalendarView <IMicrosoftGraphBookingAppointment[]>]
 [-Customers <IMicrosoftGraphBookingCustomer[]>] [-DefaultCurrencyIso <String>] [-DisplayName <String>]
 [-Email <String>] [-Id <String>] [-IsPublished] [-Phone <String>] [-PublicUrl <String>]
 [-SchedulingPolicyAllowStaffSelection] [-SchedulingPolicyMaximumAdvance <TimeSpan>]
 [-SchedulingPolicyMinimumLeadTime <TimeSpan>] [-SchedulingPolicySendConfirmationsToOwner]
 [-SchedulingPolicyTimeSlotInterval <TimeSpan>] [-Services <IMicrosoftGraphBookingService[]>]
 [-StaffMembers <IMicrosoftGraphBookingStaffMember[]>] [-WebSiteUrl <String>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgBookingBusiness -BookingBusinessId <String> -BodyParameter <IMicrosoftGraphBookingBusiness>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBookingBusiness -InputObject <IBookingsIdentity> -BodyParameter <IMicrosoftGraphBookingBusiness>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBookingBusiness -InputObject <IBookingsIdentity> [-AddressCity <String>]
 [-AddressCountryOrRegion <String>] [-AddressPostalCode <String>] [-AddressPostOfficeBox <String>]
 [-AddressState <String>] [-AddressStreet <String>] [-AddressType <String>]
 [-Appointments <IMicrosoftGraphBookingAppointment[]>] [-BusinessHours <IMicrosoftGraphBookingWorkHours[]>]
 [-BusinessType <String>] [-CalendarView <IMicrosoftGraphBookingAppointment[]>]
 [-Customers <IMicrosoftGraphBookingCustomer[]>] [-DefaultCurrencyIso <String>] [-DisplayName <String>]
 [-Email <String>] [-Id <String>] [-IsPublished] [-Phone <String>] [-PublicUrl <String>]
 [-SchedulingPolicyAllowStaffSelection] [-SchedulingPolicyMaximumAdvance <TimeSpan>]
 [-SchedulingPolicyMinimumLeadTime <TimeSpan>] [-SchedulingPolicySendConfirmationsToOwner]
 [-SchedulingPolicyTimeSlotInterval <TimeSpan>] [-Services <IMicrosoftGraphBookingService[]>]
 [-StaffMembers <IMicrosoftGraphBookingStaffMember[]>] [-WebSiteUrl <String>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update entity in bookingBusinesses

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

## PARAMETERS

### -AddressCity
The city.

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

### -AddressCountryOrRegion
The country or region.
It's a free-format string value, for example, 'United States'.

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

### -AddressPostalCode
The postal code.

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

### -AddressPostOfficeBox
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

### -AddressState
The state.

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

### -AddressStreet
The street.

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

### -AddressType
physicalAddressType

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

### -Appointments
All appointments in this business.
To construct, see NOTES section for APPOINTMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphBookingAppointment[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
Represents a Microsot Bookings Business.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphBookingBusiness
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -BookingBusinessId
key: bookingBusiness-id of bookingBusiness

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

### -BusinessHours
.
To construct, see NOTES section for BUSINESSHOURS properties and create a hash table.

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

### -BusinessType
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

### -CalendarView
A calendar view of appointments in this business.
To construct, see NOTES section for CALENDARVIEW properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphBookingAppointment[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Customers
All customers of this business.
To construct, see NOTES section for CUSTOMERS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphBookingCustomer[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultCurrencyIso
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

### -DisplayName
Display name of this entity.

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

### -Id
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

### -IsPublished
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

### -Phone
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

### -PublicUrl
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

### -SchedulingPolicyAllowStaffSelection
Allow customers to choose a specific person for the booking.

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

### -SchedulingPolicyMaximumAdvance
Maximum number of days in advance that a booking can be made.

```yaml
Type: System.TimeSpan
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SchedulingPolicyMinimumLeadTime
Minimum lead time for bookings and cancellations.

```yaml
Type: System.TimeSpan
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SchedulingPolicySendConfirmationsToOwner
Notify the business via email when a booking is created or changed.

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

### -SchedulingPolicyTimeSlotInterval
Duration of each time slot.

```yaml
Type: System.TimeSpan
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Services
All services offered by this business.
To construct, see NOTES section for SERVICES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphBookingService[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StaffMembers
All staff members that provides services in this business.
To construct, see NOTES section for STAFFMEMBERS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphBookingStaffMember[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WebSiteUrl
The URL of the business web site.

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphBookingBusiness

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


APPOINTMENTS <IMicrosoftGraphBookingAppointment[]>: All appointments in this business.
  - `[Id <String>]`: Read-only.
  - `[CustomerEmailAddress <String>]`: 
  - `[CustomerId <String>]`: The id of the booking customer associated with this appointment.
  - `[CustomerLocationAddressCity <String>]`: The city.
  - `[CustomerLocationAddressCountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
  - `[CustomerLocationAddressPostOfficeBox <String>]`: 
  - `[CustomerLocationAddressPostalCode <String>]`: The postal code.
  - `[CustomerLocationAddressState <String>]`: The state.
  - `[CustomerLocationAddressStreet <String>]`: The street.
  - `[CustomerLocationAddressType <String>]`: physicalAddressType
  - `[CustomerLocationCoordinatesAccuracy <Double?>]`: The accuracy of the latitude and longitude. As an example, the accuracy can be measured in meters, such as the latitude and longitude are accurate to within 50 meters.
  - `[CustomerLocationCoordinatesAltitude <Double?>]`: The altitude of the location.
  - `[CustomerLocationCoordinatesAltitudeAccuracy <Double?>]`: The accuracy of the altitude.
  - `[CustomerLocationCoordinatesLatitude <Double?>]`: The latitude of the location.
  - `[CustomerLocationCoordinatesLongitude <Double?>]`: The longitude of the location.
  - `[CustomerLocationDisplayName <String>]`: The name associated with the location.
  - `[CustomerLocationEmailAddress <String>]`: Optional email address of the location.
  - `[CustomerLocationType <String>]`: locationType
  - `[CustomerLocationUniqueId <String>]`: For internal use only.
  - `[CustomerLocationUniqueIdType <String>]`: locationUniqueIdType
  - `[CustomerLocationUri <String>]`: Optional URI representing the location.
  - `[CustomerName <String>]`: 
  - `[CustomerNotes <String>]`: Notes from the customer associated with this appointment.
  - `[CustomerPhone <String>]`: 
  - `[Duration <TimeSpan?>]`: 
  - `[EndDateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).
  - `[EndTimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for more possible values.
  - `[InvoiceAmount <Double?>]`: 
  - `[InvoiceDateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).
  - `[InvoiceDateTimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for more possible values.
  - `[InvoiceId <String>]`: 
  - `[InvoiceStatus <String>]`: bookingInvoiceStatus
  - `[InvoiceUrl <String>]`: 
  - `[OptOutOfCustomerEmail <Boolean?>]`: 
  - `[PostBuffer <TimeSpan?>]`: 
  - `[PreBuffer <TimeSpan?>]`: 
  - `[Price <Double?>]`: 
  - `[PriceType <String>]`: bookingPriceType
  - `[Reminders <IMicrosoftGraphBookingReminder[]>]`: 
    - `[Message <String>]`: Message to send.
    - `[Offset <TimeSpan?>]`: How much time before an appointment the reminder should be sent.
    - `[Recipients <String>]`: bookingReminderRecipients
  - `[SelfServiceAppointmentId <String>]`: 
  - `[ServiceId <String>]`: The id of the booking service associated with this appointment.
  - `[ServiceLocationAddressCity <String>]`: The city.
  - `[ServiceLocationAddressCountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
  - `[ServiceLocationAddressPostOfficeBox <String>]`: 
  - `[ServiceLocationAddressPostalCode <String>]`: The postal code.
  - `[ServiceLocationAddressState <String>]`: The state.
  - `[ServiceLocationAddressStreet <String>]`: The street.
  - `[ServiceLocationAddressType <String>]`: physicalAddressType
  - `[ServiceLocationCoordinatesAccuracy <Double?>]`: The accuracy of the latitude and longitude. As an example, the accuracy can be measured in meters, such as the latitude and longitude are accurate to within 50 meters.
  - `[ServiceLocationCoordinatesAltitude <Double?>]`: The altitude of the location.
  - `[ServiceLocationCoordinatesAltitudeAccuracy <Double?>]`: The accuracy of the altitude.
  - `[ServiceLocationCoordinatesLatitude <Double?>]`: The latitude of the location.
  - `[ServiceLocationCoordinatesLongitude <Double?>]`: The longitude of the location.
  - `[ServiceLocationDisplayName <String>]`: The name associated with the location.
  - `[ServiceLocationEmailAddress <String>]`: Optional email address of the location.
  - `[ServiceLocationType <String>]`: locationType
  - `[ServiceLocationUniqueId <String>]`: For internal use only.
  - `[ServiceLocationUniqueIdType <String>]`: locationUniqueIdType
  - `[ServiceLocationUri <String>]`: Optional URI representing the location.
  - `[ServiceName <String>]`: The name of the booking service associated with this appointment.
  - `[ServiceNotes <String>]`: 
  - `[StaffMemberIds <String[]>]`: 
  - `[StartDateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).
  - `[StartTimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for more possible values.

BODYPARAMETER <IMicrosoftGraphBookingBusiness>: Represents a Microsot Bookings Business.
  - `[DisplayName <String>]`: Display name of this entity.
  - `[Id <String>]`: Read-only.
  - `[AddressCity <String>]`: The city.
  - `[AddressCountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
  - `[AddressPostOfficeBox <String>]`: 
  - `[AddressPostalCode <String>]`: The postal code.
  - `[AddressState <String>]`: The state.
  - `[AddressStreet <String>]`: The street.
  - `[AddressType <String>]`: physicalAddressType
  - `[Appointments <IMicrosoftGraphBookingAppointment[]>]`: All appointments in this business.
    - `[Id <String>]`: Read-only.
    - `[CustomerEmailAddress <String>]`: 
    - `[CustomerId <String>]`: The id of the booking customer associated with this appointment.
    - `[CustomerLocationAddressCity <String>]`: The city.
    - `[CustomerLocationAddressCountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
    - `[CustomerLocationAddressPostOfficeBox <String>]`: 
    - `[CustomerLocationAddressPostalCode <String>]`: The postal code.
    - `[CustomerLocationAddressState <String>]`: The state.
    - `[CustomerLocationAddressStreet <String>]`: The street.
    - `[CustomerLocationAddressType <String>]`: physicalAddressType
    - `[CustomerLocationCoordinatesAccuracy <Double?>]`: The accuracy of the latitude and longitude. As an example, the accuracy can be measured in meters, such as the latitude and longitude are accurate to within 50 meters.
    - `[CustomerLocationCoordinatesAltitude <Double?>]`: The altitude of the location.
    - `[CustomerLocationCoordinatesAltitudeAccuracy <Double?>]`: The accuracy of the altitude.
    - `[CustomerLocationCoordinatesLatitude <Double?>]`: The latitude of the location.
    - `[CustomerLocationCoordinatesLongitude <Double?>]`: The longitude of the location.
    - `[CustomerLocationDisplayName <String>]`: The name associated with the location.
    - `[CustomerLocationEmailAddress <String>]`: Optional email address of the location.
    - `[CustomerLocationType <String>]`: locationType
    - `[CustomerLocationUniqueId <String>]`: For internal use only.
    - `[CustomerLocationUniqueIdType <String>]`: locationUniqueIdType
    - `[CustomerLocationUri <String>]`: Optional URI representing the location.
    - `[CustomerName <String>]`: 
    - `[CustomerNotes <String>]`: Notes from the customer associated with this appointment.
    - `[CustomerPhone <String>]`: 
    - `[Duration <TimeSpan?>]`: 
    - `[EndDateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).
    - `[EndTimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for more possible values.
    - `[InvoiceAmount <Double?>]`: 
    - `[InvoiceDateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).
    - `[InvoiceDateTimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for more possible values.
    - `[InvoiceId <String>]`: 
    - `[InvoiceStatus <String>]`: bookingInvoiceStatus
    - `[InvoiceUrl <String>]`: 
    - `[OptOutOfCustomerEmail <Boolean?>]`: 
    - `[PostBuffer <TimeSpan?>]`: 
    - `[PreBuffer <TimeSpan?>]`: 
    - `[Price <Double?>]`: 
    - `[PriceType <String>]`: bookingPriceType
    - `[Reminders <IMicrosoftGraphBookingReminder[]>]`: 
      - `[Message <String>]`: Message to send.
      - `[Offset <TimeSpan?>]`: How much time before an appointment the reminder should be sent.
      - `[Recipients <String>]`: bookingReminderRecipients
    - `[SelfServiceAppointmentId <String>]`: 
    - `[ServiceId <String>]`: The id of the booking service associated with this appointment.
    - `[ServiceLocationAddressCity <String>]`: The city.
    - `[ServiceLocationAddressCountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
    - `[ServiceLocationAddressPostOfficeBox <String>]`: 
    - `[ServiceLocationAddressPostalCode <String>]`: The postal code.
    - `[ServiceLocationAddressState <String>]`: The state.
    - `[ServiceLocationAddressStreet <String>]`: The street.
    - `[ServiceLocationAddressType <String>]`: physicalAddressType
    - `[ServiceLocationCoordinatesAccuracy <Double?>]`: The accuracy of the latitude and longitude. As an example, the accuracy can be measured in meters, such as the latitude and longitude are accurate to within 50 meters.
    - `[ServiceLocationCoordinatesAltitude <Double?>]`: The altitude of the location.
    - `[ServiceLocationCoordinatesAltitudeAccuracy <Double?>]`: The accuracy of the altitude.
    - `[ServiceLocationCoordinatesLatitude <Double?>]`: The latitude of the location.
    - `[ServiceLocationCoordinatesLongitude <Double?>]`: The longitude of the location.
    - `[ServiceLocationDisplayName <String>]`: The name associated with the location.
    - `[ServiceLocationEmailAddress <String>]`: Optional email address of the location.
    - `[ServiceLocationType <String>]`: locationType
    - `[ServiceLocationUniqueId <String>]`: For internal use only.
    - `[ServiceLocationUniqueIdType <String>]`: locationUniqueIdType
    - `[ServiceLocationUri <String>]`: Optional URI representing the location.
    - `[ServiceName <String>]`: The name of the booking service associated with this appointment.
    - `[ServiceNotes <String>]`: 
    - `[StaffMemberIds <String[]>]`: 
    - `[StartDateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).
    - `[StartTimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for more possible values.
  - `[BusinessHours <IMicrosoftGraphBookingWorkHours[]>]`: 
    - `[Day <String>]`: dayOfWeek
    - `[TimeSlots <IMicrosoftGraphBookingWorkTimeSlot[]>]`: A list of start/end times during a day.
      - `[End <String>]`: 
      - `[Start <String>]`: 
  - `[BusinessType <String>]`: 
  - `[CalendarView <IMicrosoftGraphBookingAppointment[]>]`: A calendar view of appointments in this business.
  - `[Customers <IMicrosoftGraphBookingCustomer[]>]`: All customers of this business.
    - `[EmailAddress <String>]`: The e-mail address of this person.
    - `[DisplayName <String>]`: Display name of this entity.
    - `[Id <String>]`: Read-only.
  - `[DefaultCurrencyIso <String>]`: 
  - `[Email <String>]`: 
  - `[IsPublished <Boolean?>]`: 
  - `[Phone <String>]`: 
  - `[PublicUrl <String>]`: 
  - `[SchedulingPolicyAllowStaffSelection <Boolean?>]`: Allow customers to choose a specific person for the booking.
  - `[SchedulingPolicyMaximumAdvance <TimeSpan?>]`: Maximum number of days in advance that a booking can be made.
  - `[SchedulingPolicyMinimumLeadTime <TimeSpan?>]`: Minimum lead time for bookings and cancellations.
  - `[SchedulingPolicySendConfirmationsToOwner <Boolean?>]`: Notify the business via email when a booking is created or changed.
  - `[SchedulingPolicyTimeSlotInterval <TimeSpan?>]`: Duration of each time slot.
  - `[Services <IMicrosoftGraphBookingService[]>]`: All services offered by this business.
    - `[DisplayName <String>]`: Display name of this entity.
    - `[Id <String>]`: Read-only.
    - `[AddressCity <String>]`: The city.
    - `[AddressCountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
    - `[AddressPostOfficeBox <String>]`: 
    - `[AddressPostalCode <String>]`: The postal code.
    - `[AddressState <String>]`: The state.
    - `[AddressStreet <String>]`: The street.
    - `[AddressType <String>]`: physicalAddressType
    - `[CoordinateAccuracy <Double?>]`: The accuracy of the latitude and longitude. As an example, the accuracy can be measured in meters, such as the latitude and longitude are accurate to within 50 meters.
    - `[CoordinateAltitude <Double?>]`: The altitude of the location.
    - `[CoordinateAltitudeAccuracy <Double?>]`: The accuracy of the altitude.
    - `[CoordinateLatitude <Double?>]`: The latitude of the location.
    - `[CoordinateLongitude <Double?>]`: The longitude of the location.
    - `[DefaultDuration <TimeSpan?>]`: 
    - `[DefaultLocationDisplayName <String>]`: The name associated with the location.
    - `[DefaultLocationEmailAddress <String>]`: Optional email address of the location.
    - `[DefaultLocationType <String>]`: locationType
    - `[DefaultLocationUniqueId <String>]`: For internal use only.
    - `[DefaultLocationUniqueIdType <String>]`: locationUniqueIdType
    - `[DefaultLocationUri <String>]`: Optional URI representing the location.
    - `[DefaultPrice <Double?>]`: 
    - `[DefaultPriceType <String>]`: bookingPriceType
    - `[DefaultReminders <IMicrosoftGraphBookingReminder[]>]`: The default reminders set in an appointment of this service.
    - `[Description <String>]`: 
    - `[IsHiddenFromCustomers <Boolean?>]`: 
    - `[Notes <String>]`: 
    - `[PostBuffer <TimeSpan?>]`: 
    - `[PreBuffer <TimeSpan?>]`: 
    - `[SchedulingPolicyAllowStaffSelection <Boolean?>]`: Allow customers to choose a specific person for the booking.
    - `[SchedulingPolicyMaximumAdvance <TimeSpan?>]`: Maximum number of days in advance that a booking can be made.
    - `[SchedulingPolicyMinimumLeadTime <TimeSpan?>]`: Minimum lead time for bookings and cancellations.
    - `[SchedulingPolicySendConfirmationsToOwner <Boolean?>]`: Notify the business via email when a booking is created or changed.
    - `[SchedulingPolicyTimeSlotInterval <TimeSpan?>]`: Duration of each time slot.
    - `[StaffMemberIds <String[]>]`: 
  - `[StaffMembers <IMicrosoftGraphBookingStaffMember[]>]`: All staff members that provides services in this business.
    - `[EmailAddress <String>]`: The e-mail address of this person.
    - `[DisplayName <String>]`: Display name of this entity.
    - `[Id <String>]`: Read-only.
    - `[AvailabilityIsAffectedByPersonalCalendar <Boolean?>]`: 
    - `[ColorIndex <Int32?>]`: 
    - `[Role <String>]`: bookingStaffRole
    - `[UseBusinessHours <Boolean?>]`: 
    - `[WorkingHours <IMicrosoftGraphBookingWorkHours[]>]`: 
  - `[WebSiteUrl <String>]`: The URL of the business web site.

BUSINESSHOURS <IMicrosoftGraphBookingWorkHours[]>: .
  - `[Day <String>]`: dayOfWeek
  - `[TimeSlots <IMicrosoftGraphBookingWorkTimeSlot[]>]`: A list of start/end times during a day.
    - `[End <String>]`: 
    - `[Start <String>]`: 

CALENDARVIEW <IMicrosoftGraphBookingAppointment[]>: A calendar view of appointments in this business.
  - `[Id <String>]`: Read-only.
  - `[CustomerEmailAddress <String>]`: 
  - `[CustomerId <String>]`: The id of the booking customer associated with this appointment.
  - `[CustomerLocationAddressCity <String>]`: The city.
  - `[CustomerLocationAddressCountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
  - `[CustomerLocationAddressPostOfficeBox <String>]`: 
  - `[CustomerLocationAddressPostalCode <String>]`: The postal code.
  - `[CustomerLocationAddressState <String>]`: The state.
  - `[CustomerLocationAddressStreet <String>]`: The street.
  - `[CustomerLocationAddressType <String>]`: physicalAddressType
  - `[CustomerLocationCoordinatesAccuracy <Double?>]`: The accuracy of the latitude and longitude. As an example, the accuracy can be measured in meters, such as the latitude and longitude are accurate to within 50 meters.
  - `[CustomerLocationCoordinatesAltitude <Double?>]`: The altitude of the location.
  - `[CustomerLocationCoordinatesAltitudeAccuracy <Double?>]`: The accuracy of the altitude.
  - `[CustomerLocationCoordinatesLatitude <Double?>]`: The latitude of the location.
  - `[CustomerLocationCoordinatesLongitude <Double?>]`: The longitude of the location.
  - `[CustomerLocationDisplayName <String>]`: The name associated with the location.
  - `[CustomerLocationEmailAddress <String>]`: Optional email address of the location.
  - `[CustomerLocationType <String>]`: locationType
  - `[CustomerLocationUniqueId <String>]`: For internal use only.
  - `[CustomerLocationUniqueIdType <String>]`: locationUniqueIdType
  - `[CustomerLocationUri <String>]`: Optional URI representing the location.
  - `[CustomerName <String>]`: 
  - `[CustomerNotes <String>]`: Notes from the customer associated with this appointment.
  - `[CustomerPhone <String>]`: 
  - `[Duration <TimeSpan?>]`: 
  - `[EndDateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).
  - `[EndTimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for more possible values.
  - `[InvoiceAmount <Double?>]`: 
  - `[InvoiceDateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).
  - `[InvoiceDateTimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for more possible values.
  - `[InvoiceId <String>]`: 
  - `[InvoiceStatus <String>]`: bookingInvoiceStatus
  - `[InvoiceUrl <String>]`: 
  - `[OptOutOfCustomerEmail <Boolean?>]`: 
  - `[PostBuffer <TimeSpan?>]`: 
  - `[PreBuffer <TimeSpan?>]`: 
  - `[Price <Double?>]`: 
  - `[PriceType <String>]`: bookingPriceType
  - `[Reminders <IMicrosoftGraphBookingReminder[]>]`: 
    - `[Message <String>]`: Message to send.
    - `[Offset <TimeSpan?>]`: How much time before an appointment the reminder should be sent.
    - `[Recipients <String>]`: bookingReminderRecipients
  - `[SelfServiceAppointmentId <String>]`: 
  - `[ServiceId <String>]`: The id of the booking service associated with this appointment.
  - `[ServiceLocationAddressCity <String>]`: The city.
  - `[ServiceLocationAddressCountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
  - `[ServiceLocationAddressPostOfficeBox <String>]`: 
  - `[ServiceLocationAddressPostalCode <String>]`: The postal code.
  - `[ServiceLocationAddressState <String>]`: The state.
  - `[ServiceLocationAddressStreet <String>]`: The street.
  - `[ServiceLocationAddressType <String>]`: physicalAddressType
  - `[ServiceLocationCoordinatesAccuracy <Double?>]`: The accuracy of the latitude and longitude. As an example, the accuracy can be measured in meters, such as the latitude and longitude are accurate to within 50 meters.
  - `[ServiceLocationCoordinatesAltitude <Double?>]`: The altitude of the location.
  - `[ServiceLocationCoordinatesAltitudeAccuracy <Double?>]`: The accuracy of the altitude.
  - `[ServiceLocationCoordinatesLatitude <Double?>]`: The latitude of the location.
  - `[ServiceLocationCoordinatesLongitude <Double?>]`: The longitude of the location.
  - `[ServiceLocationDisplayName <String>]`: The name associated with the location.
  - `[ServiceLocationEmailAddress <String>]`: Optional email address of the location.
  - `[ServiceLocationType <String>]`: locationType
  - `[ServiceLocationUniqueId <String>]`: For internal use only.
  - `[ServiceLocationUniqueIdType <String>]`: locationUniqueIdType
  - `[ServiceLocationUri <String>]`: Optional URI representing the location.
  - `[ServiceName <String>]`: The name of the booking service associated with this appointment.
  - `[ServiceNotes <String>]`: 
  - `[StaffMemberIds <String[]>]`: 
  - `[StartDateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).
  - `[StartTimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for more possible values.

CUSTOMERS <IMicrosoftGraphBookingCustomer[]>: All customers of this business.
  - `[EmailAddress <String>]`: The e-mail address of this person.
  - `[DisplayName <String>]`: Display name of this entity.
  - `[Id <String>]`: Read-only.

INPUTOBJECT <IBookingsIdentity>: Identity Parameter
  - `[BookingAppointmentId <String>]`: key: bookingAppointment-id of bookingAppointment
  - `[BookingBusinessId <String>]`: key: bookingBusiness-id of bookingBusiness
  - `[BookingCurrencyId <String>]`: key: bookingCurrency-id of bookingCurrency
  - `[BookingCustomerId <String>]`: key: bookingCustomer-id of bookingCustomer
  - `[BookingServiceId <String>]`: key: bookingService-id of bookingService
  - `[BookingStaffMemberId <String>]`: key: bookingStaffMember-id of bookingStaffMember

SERVICES <IMicrosoftGraphBookingService[]>: All services offered by this business.
  - `[DisplayName <String>]`: Display name of this entity.
  - `[Id <String>]`: Read-only.
  - `[AddressCity <String>]`: The city.
  - `[AddressCountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
  - `[AddressPostOfficeBox <String>]`: 
  - `[AddressPostalCode <String>]`: The postal code.
  - `[AddressState <String>]`: The state.
  - `[AddressStreet <String>]`: The street.
  - `[AddressType <String>]`: physicalAddressType
  - `[CoordinateAccuracy <Double?>]`: The accuracy of the latitude and longitude. As an example, the accuracy can be measured in meters, such as the latitude and longitude are accurate to within 50 meters.
  - `[CoordinateAltitude <Double?>]`: The altitude of the location.
  - `[CoordinateAltitudeAccuracy <Double?>]`: The accuracy of the altitude.
  - `[CoordinateLatitude <Double?>]`: The latitude of the location.
  - `[CoordinateLongitude <Double?>]`: The longitude of the location.
  - `[DefaultDuration <TimeSpan?>]`: 
  - `[DefaultLocationDisplayName <String>]`: The name associated with the location.
  - `[DefaultLocationEmailAddress <String>]`: Optional email address of the location.
  - `[DefaultLocationType <String>]`: locationType
  - `[DefaultLocationUniqueId <String>]`: For internal use only.
  - `[DefaultLocationUniqueIdType <String>]`: locationUniqueIdType
  - `[DefaultLocationUri <String>]`: Optional URI representing the location.
  - `[DefaultPrice <Double?>]`: 
  - `[DefaultPriceType <String>]`: bookingPriceType
  - `[DefaultReminders <IMicrosoftGraphBookingReminder[]>]`: The default reminders set in an appointment of this service.
    - `[Message <String>]`: Message to send.
    - `[Offset <TimeSpan?>]`: How much time before an appointment the reminder should be sent.
    - `[Recipients <String>]`: bookingReminderRecipients
  - `[Description <String>]`: 
  - `[IsHiddenFromCustomers <Boolean?>]`: 
  - `[Notes <String>]`: 
  - `[PostBuffer <TimeSpan?>]`: 
  - `[PreBuffer <TimeSpan?>]`: 
  - `[SchedulingPolicyAllowStaffSelection <Boolean?>]`: Allow customers to choose a specific person for the booking.
  - `[SchedulingPolicyMaximumAdvance <TimeSpan?>]`: Maximum number of days in advance that a booking can be made.
  - `[SchedulingPolicyMinimumLeadTime <TimeSpan?>]`: Minimum lead time for bookings and cancellations.
  - `[SchedulingPolicySendConfirmationsToOwner <Boolean?>]`: Notify the business via email when a booking is created or changed.
  - `[SchedulingPolicyTimeSlotInterval <TimeSpan?>]`: Duration of each time slot.
  - `[StaffMemberIds <String[]>]`: 

STAFFMEMBERS <IMicrosoftGraphBookingStaffMember[]>: All staff members that provides services in this business.
  - `[EmailAddress <String>]`: The e-mail address of this person.
  - `[DisplayName <String>]`: Display name of this entity.
  - `[Id <String>]`: Read-only.
  - `[AvailabilityIsAffectedByPersonalCalendar <Boolean?>]`: 
  - `[ColorIndex <Int32?>]`: 
  - `[Role <String>]`: bookingStaffRole
  - `[UseBusinessHours <Boolean?>]`: 
  - `[WorkingHours <IMicrosoftGraphBookingWorkHours[]>]`: 
    - `[Day <String>]`: dayOfWeek
    - `[TimeSlots <IMicrosoftGraphBookingWorkTimeSlot[]>]`: A list of start/end times during a day.
      - `[End <String>]`: 
      - `[Start <String>]`: 

## RELATED LINKS

