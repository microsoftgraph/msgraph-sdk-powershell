---
external help file: Microsoft.Graph.Bookings-help.xml
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
Update-MgBookingBusiness -BookingBusinessId <String> [-AdditionalProperties <Hashtable>]
 [-Address <IMicrosoftGraphPhysicalAddress>] [-Appointments <IMicrosoftGraphBookingAppointment[]>]
 [-BusinessHours <IMicrosoftGraphBookingWorkHours[]>] [-BusinessType <String>]
 [-CalendarView <IMicrosoftGraphBookingAppointment[]>] [-Customers <IMicrosoftGraphBookingCustomer[]>]
 [-DefaultCurrencyIso <String>] [-DisplayName <String>] [-Email <String>] [-Id <String>] [-IsPublished]
 [-Phone <String>] [-PublicUrl <String>] [-SchedulingPolicy <IMicrosoftGraphBookingSchedulingPolicy>]
 [-Services <IMicrosoftGraphBookingService[]>] [-StaffMembers <IMicrosoftGraphBookingStaffMember[]>]
 [-WebSiteUrl <String>] [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Update
```
Update-MgBookingBusiness -BookingBusinessId <String> -BodyParameter <IMicrosoftGraphBookingBusiness>
 [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBookingBusiness -InputObject <IBookingsIdentity> [-AdditionalProperties <Hashtable>]
 [-Address <IMicrosoftGraphPhysicalAddress>] [-Appointments <IMicrosoftGraphBookingAppointment[]>]
 [-BusinessHours <IMicrosoftGraphBookingWorkHours[]>] [-BusinessType <String>]
 [-CalendarView <IMicrosoftGraphBookingAppointment[]>] [-Customers <IMicrosoftGraphBookingCustomer[]>]
 [-DefaultCurrencyIso <String>] [-DisplayName <String>] [-Email <String>] [-Id <String>] [-IsPublished]
 [-Phone <String>] [-PublicUrl <String>] [-SchedulingPolicy <IMicrosoftGraphBookingSchedulingPolicy>]
 [-Services <IMicrosoftGraphBookingService[]>] [-StaffMembers <IMicrosoftGraphBookingStaffMember[]>]
 [-WebSiteUrl <String>] [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBookingBusiness -InputObject <IBookingsIdentity> -BodyParameter <IMicrosoftGraphBookingBusiness>
 [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Update entity in bookingBusinesses

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

### -Address
physicalAddress
To construct, see NOTES section for ADDRESS properties and create a hash table.

```yaml
Type: IMicrosoftGraphPhysicalAddress
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
Type: IMicrosoftGraphBookingAppointment[]
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
Type: IMicrosoftGraphBookingBusiness
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

### -BusinessHours
.
To construct, see NOTES section for BUSINESSHOURS properties and create a hash table.

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

### -BusinessType
.

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

### -CalendarView
A calendar view of appointments in this business.
To construct, see NOTES section for CALENDARVIEW properties and create a hash table.

```yaml
Type: IMicrosoftGraphBookingAppointment[]
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
Type: IMicrosoftGraphBookingCustomer[]
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
Type: String
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
Type: String
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

### -IsPublished
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

### -Phone
.

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

### -PublicUrl
.

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

### -SchedulingPolicy
This type represents the set of policies that dictate how bookings can be created in a Booking Calendar.
To construct, see NOTES section for SCHEDULINGPOLICY properties and create a hash table.

```yaml
Type: IMicrosoftGraphBookingSchedulingPolicy
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
Type: IMicrosoftGraphBookingService[]
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
Type: IMicrosoftGraphBookingStaffMember[]
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
Type: String
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
### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphBookingBusiness
## OUTPUTS

### System.Boolean
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

ADDRESS \<IMicrosoftGraphPhysicalAddress\>: physicalAddress
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[City \<String\>\]: The city.
  \[CountryOrRegion \<String\>\]: The country or region.
It's a free-format string value, for example, 'United States'.
  \[PostOfficeBox \<String\>\]: 
  \[PostalCode \<String\>\]: The postal code.
  \[State \<String\>\]: The state.
  \[Street \<String\>\]: The street.
  \[Type \<String\>\]: physicalAddressType

APPOINTMENTS \<IMicrosoftGraphBookingAppointment\[\]\>: All appointments in this business.
  \[Id \<String\>\]: Read-only.
  \[AdditionalInformation \<String\>\]: 
  \[CustomerEmailAddress \<String\>\]: 
  \[CustomerId \<String\>\]: The id of the booking customer associated with this appointment.
  \[CustomerLocation \<IMicrosoftGraphLocation\>\]: location
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Address \<IMicrosoftGraphPhysicalAddress\>\]: physicalAddress
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[City \<String\>\]: The city.
      \[CountryOrRegion \<String\>\]: The country or region.
It's a free-format string value, for example, 'United States'.
      \[PostOfficeBox \<String\>\]: 
      \[PostalCode \<String\>\]: The postal code.
      \[State \<String\>\]: The state.
      \[Street \<String\>\]: The street.
      \[Type \<String\>\]: physicalAddressType
    \[Coordinates \<IMicrosoftGraphOutlookGeoCoordinates\>\]: outlookGeoCoordinates
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[Accuracy \<Double?\>\]: The accuracy of the latitude and longitude.
As an example, the accuracy can be measured in meters, such as the latitude and longitude are accurate to within 50 meters.
      \[Altitude \<Double?\>\]: The altitude of the location.
      \[AltitudeAccuracy \<Double?\>\]: The accuracy of the altitude.
      \[Latitude \<Double?\>\]: The latitude of the location.
      \[Longitude \<Double?\>\]: The longitude of the location.
    \[DisplayName \<String\>\]: The name associated with the location.
    \[LocationEmailAddress \<String\>\]: Optional email address of the location.
    \[LocationType \<String\>\]: locationType
    \[LocationUri \<String\>\]: Optional URI representing the location.
    \[UniqueId \<String\>\]: For internal use only.
    \[UniqueIdType \<String\>\]: locationUniqueIdType
  \[CustomerName \<String\>\]: 
  \[CustomerNotes \<String\>\]: Notes from the customer associated with this appointment.
  \[CustomerPhone \<String\>\]: 
  \[Duration \<TimeSpan?\>\]: 
  \[End \<IMicrosoftGraphDateTimeZone\>\]: dateTimeTimeZone
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[DateTime \<String\>\]: A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).
    \[TimeZone \<String\>\]: Represents a time zone, for example, 'Pacific Standard Time'.
See below for more possible values.
  \[InvoiceAmount \<Double?\>\]: 
  \[InvoiceDate \<IMicrosoftGraphDateTimeZone\>\]: dateTimeTimeZone
  \[InvoiceId \<String\>\]: 
  \[InvoiceStatus \<String\>\]: bookingInvoiceStatus
  \[InvoiceUrl \<String\>\]: 
  \[IsLocationOnline \<Boolean?\>\]: 
  \[OnlineMeetingUrl \<String\>\]: 
  \[OptOutOfCustomerEmail \<Boolean?\>\]: 
  \[PostBuffer \<TimeSpan?\>\]: 
  \[PreBuffer \<TimeSpan?\>\]: 
  \[Price \<Double?\>\]: 
  \[PriceType \<String\>\]: bookingPriceType
  \[Reminders \<IMicrosoftGraphBookingReminder\[\]\>\]: 
    \[Message \<String\>\]: Message to send.
    \[Offset \<TimeSpan?\>\]: How much time before an appointment the reminder should be sent.
    \[Recipients \<String\>\]: bookingReminderRecipients
  \[SelfServiceAppointmentId \<String\>\]: 
  \[ServiceId \<String\>\]: The id of the booking service associated with this appointment.
  \[ServiceLocation \<IMicrosoftGraphLocation\>\]: location
  \[ServiceName \<String\>\]: The name of the booking service associated with this appointment.
  \[ServiceNotes \<String\>\]: 
  \[StaffMemberIds \<String\[\]\>\]: 
  \[Start \<IMicrosoftGraphDateTimeZone\>\]: dateTimeTimeZone

BODYPARAMETER \<IMicrosoftGraphBookingBusiness\>: Represents a Microsot Bookings Business.
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[DisplayName \<String\>\]: Display name of this entity.
  \[Id \<String\>\]: Read-only.
  \[Address \<IMicrosoftGraphPhysicalAddress\>\]: physicalAddress
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[City \<String\>\]: The city.
    \[CountryOrRegion \<String\>\]: The country or region.
It's a free-format string value, for example, 'United States'.
    \[PostOfficeBox \<String\>\]: 
    \[PostalCode \<String\>\]: The postal code.
    \[State \<String\>\]: The state.
    \[Street \<String\>\]: The street.
    \[Type \<String\>\]: physicalAddressType
  \[Appointments \<IMicrosoftGraphBookingAppointment\[\]\>\]: All appointments in this business.
    \[Id \<String\>\]: Read-only.
    \[AdditionalInformation \<String\>\]: 
    \[CustomerEmailAddress \<String\>\]: 
    \[CustomerId \<String\>\]: The id of the booking customer associated with this appointment.
    \[CustomerLocation \<IMicrosoftGraphLocation\>\]: location
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[Address \<IMicrosoftGraphPhysicalAddress\>\]: physicalAddress
      \[Coordinates \<IMicrosoftGraphOutlookGeoCoordinates\>\]: outlookGeoCoordinates
        \[(Any) \<Object\>\]: This indicates any property can be added to this object.
        \[Accuracy \<Double?\>\]: The accuracy of the latitude and longitude.
As an example, the accuracy can be measured in meters, such as the latitude and longitude are accurate to within 50 meters.
        \[Altitude \<Double?\>\]: The altitude of the location.
        \[AltitudeAccuracy \<Double?\>\]: The accuracy of the altitude.
        \[Latitude \<Double?\>\]: The latitude of the location.
        \[Longitude \<Double?\>\]: The longitude of the location.
      \[DisplayName \<String\>\]: The name associated with the location.
      \[LocationEmailAddress \<String\>\]: Optional email address of the location.
      \[LocationType \<String\>\]: locationType
      \[LocationUri \<String\>\]: Optional URI representing the location.
      \[UniqueId \<String\>\]: For internal use only.
      \[UniqueIdType \<String\>\]: locationUniqueIdType
    \[CustomerName \<String\>\]: 
    \[CustomerNotes \<String\>\]: Notes from the customer associated with this appointment.
    \[CustomerPhone \<String\>\]: 
    \[Duration \<TimeSpan?\>\]: 
    \[End \<IMicrosoftGraphDateTimeZone\>\]: dateTimeTimeZone
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[DateTime \<String\>\]: A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).
      \[TimeZone \<String\>\]: Represents a time zone, for example, 'Pacific Standard Time'.
See below for more possible values.
    \[InvoiceAmount \<Double?\>\]: 
    \[InvoiceDate \<IMicrosoftGraphDateTimeZone\>\]: dateTimeTimeZone
    \[InvoiceId \<String\>\]: 
    \[InvoiceStatus \<String\>\]: bookingInvoiceStatus
    \[InvoiceUrl \<String\>\]: 
    \[IsLocationOnline \<Boolean?\>\]: 
    \[OnlineMeetingUrl \<String\>\]: 
    \[OptOutOfCustomerEmail \<Boolean?\>\]: 
    \[PostBuffer \<TimeSpan?\>\]: 
    \[PreBuffer \<TimeSpan?\>\]: 
    \[Price \<Double?\>\]: 
    \[PriceType \<String\>\]: bookingPriceType
    \[Reminders \<IMicrosoftGraphBookingReminder\[\]\>\]: 
      \[Message \<String\>\]: Message to send.
      \[Offset \<TimeSpan?\>\]: How much time before an appointment the reminder should be sent.
      \[Recipients \<String\>\]: bookingReminderRecipients
    \[SelfServiceAppointmentId \<String\>\]: 
    \[ServiceId \<String\>\]: The id of the booking service associated with this appointment.
    \[ServiceLocation \<IMicrosoftGraphLocation\>\]: location
    \[ServiceName \<String\>\]: The name of the booking service associated with this appointment.
    \[ServiceNotes \<String\>\]: 
    \[StaffMemberIds \<String\[\]\>\]: 
    \[Start \<IMicrosoftGraphDateTimeZone\>\]: dateTimeTimeZone
  \[BusinessHours \<IMicrosoftGraphBookingWorkHours\[\]\>\]: 
    \[Day \<String\>\]: dayOfWeek
    \[TimeSlots \<IMicrosoftGraphBookingWorkTimeSlot\[\]\>\]: A list of start/end times during a day.
      \[End \<String\>\]: 
      \[Start \<String\>\]: 
  \[BusinessType \<String\>\]: 
  \[CalendarView \<IMicrosoftGraphBookingAppointment\[\]\>\]: A calendar view of appointments in this business.
  \[Customers \<IMicrosoftGraphBookingCustomer\[\]\>\]: All customers of this business.
    \[EmailAddress \<String\>\]: The e-mail address of this person.
    \[DisplayName \<String\>\]: Display name of this entity.
    \[Id \<String\>\]: Read-only.
  \[DefaultCurrencyIso \<String\>\]: 
  \[Email \<String\>\]: 
  \[IsPublished \<Boolean?\>\]: 
  \[Phone \<String\>\]: 
  \[PublicUrl \<String\>\]: 
  \[SchedulingPolicy \<IMicrosoftGraphBookingSchedulingPolicy\>\]: This type represents the set of policies that dictate how bookings can be created in a Booking Calendar.
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[AllowStaffSelection \<Boolean?\>\]: Allow customers to choose a specific person for the booking.
    \[MaximumAdvance \<TimeSpan?\>\]: Maximum number of days in advance that a booking can be made.
    \[MinimumLeadTime \<TimeSpan?\>\]: Minimum lead time for bookings and cancellations.
    \[SendConfirmationsToOwner \<Boolean?\>\]: Notify the business via email when a booking is created or changed.
    \[TimeSlotInterval \<TimeSpan?\>\]: Duration of each time slot.
  \[Services \<IMicrosoftGraphBookingService\[\]\>\]: All services offered by this business.
    \[DisplayName \<String\>\]: Display name of this entity.
    \[Id \<String\>\]: Read-only.
    \[AdditionalInformation \<String\>\]: 
    \[DefaultDuration \<TimeSpan?\>\]: 
    \[DefaultLocation \<IMicrosoftGraphLocation\>\]: location
    \[DefaultPrice \<Double?\>\]: 
    \[DefaultPriceType \<String\>\]: bookingPriceType
    \[DefaultReminders \<IMicrosoftGraphBookingReminder\[\]\>\]: The default reminders set in an appointment of this service.
    \[Description \<String\>\]: 
    \[IsHiddenFromCustomers \<Boolean?\>\]: 
    \[IsLocationOnline \<Boolean?\>\]: 
    \[Notes \<String\>\]: 
    \[PostBuffer \<TimeSpan?\>\]: 
    \[PreBuffer \<TimeSpan?\>\]: 
    \[SchedulingPolicy \<IMicrosoftGraphBookingSchedulingPolicy\>\]: This type represents the set of policies that dictate how bookings can be created in a Booking Calendar.
    \[StaffMemberIds \<String\[\]\>\]: 
  \[StaffMembers \<IMicrosoftGraphBookingStaffMember\[\]\>\]: All staff members that provides services in this business.
    \[EmailAddress \<String\>\]: The e-mail address of this person.
    \[DisplayName \<String\>\]: Display name of this entity.
    \[Id \<String\>\]: Read-only.
    \[AvailabilityIsAffectedByPersonalCalendar \<Boolean?\>\]: 
    \[ColorIndex \<Int32?\>\]: 
    \[Role \<String\>\]: bookingStaffRole
    \[UseBusinessHours \<Boolean?\>\]: 
    \[WorkingHours \<IMicrosoftGraphBookingWorkHours\[\]\>\]: 
  \[WebSiteUrl \<String\>\]: The URL of the business web site.

BUSINESSHOURS \<IMicrosoftGraphBookingWorkHours\[\]\>: .
  \[Day \<String\>\]: dayOfWeek
  \[TimeSlots \<IMicrosoftGraphBookingWorkTimeSlot\[\]\>\]: A list of start/end times during a day.
    \[End \<String\>\]: 
    \[Start \<String\>\]: 

CALENDARVIEW \<IMicrosoftGraphBookingAppointment\[\]\>: A calendar view of appointments in this business.
  \[Id \<String\>\]: Read-only.
  \[AdditionalInformation \<String\>\]: 
  \[CustomerEmailAddress \<String\>\]: 
  \[CustomerId \<String\>\]: The id of the booking customer associated with this appointment.
  \[CustomerLocation \<IMicrosoftGraphLocation\>\]: location
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Address \<IMicrosoftGraphPhysicalAddress\>\]: physicalAddress
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[City \<String\>\]: The city.
      \[CountryOrRegion \<String\>\]: The country or region.
It's a free-format string value, for example, 'United States'.
      \[PostOfficeBox \<String\>\]: 
      \[PostalCode \<String\>\]: The postal code.
      \[State \<String\>\]: The state.
      \[Street \<String\>\]: The street.
      \[Type \<String\>\]: physicalAddressType
    \[Coordinates \<IMicrosoftGraphOutlookGeoCoordinates\>\]: outlookGeoCoordinates
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[Accuracy \<Double?\>\]: The accuracy of the latitude and longitude.
As an example, the accuracy can be measured in meters, such as the latitude and longitude are accurate to within 50 meters.
      \[Altitude \<Double?\>\]: The altitude of the location.
      \[AltitudeAccuracy \<Double?\>\]: The accuracy of the altitude.
      \[Latitude \<Double?\>\]: The latitude of the location.
      \[Longitude \<Double?\>\]: The longitude of the location.
    \[DisplayName \<String\>\]: The name associated with the location.
    \[LocationEmailAddress \<String\>\]: Optional email address of the location.
    \[LocationType \<String\>\]: locationType
    \[LocationUri \<String\>\]: Optional URI representing the location.
    \[UniqueId \<String\>\]: For internal use only.
    \[UniqueIdType \<String\>\]: locationUniqueIdType
  \[CustomerName \<String\>\]: 
  \[CustomerNotes \<String\>\]: Notes from the customer associated with this appointment.
  \[CustomerPhone \<String\>\]: 
  \[Duration \<TimeSpan?\>\]: 
  \[End \<IMicrosoftGraphDateTimeZone\>\]: dateTimeTimeZone
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[DateTime \<String\>\]: A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).
    \[TimeZone \<String\>\]: Represents a time zone, for example, 'Pacific Standard Time'.
See below for more possible values.
  \[InvoiceAmount \<Double?\>\]: 
  \[InvoiceDate \<IMicrosoftGraphDateTimeZone\>\]: dateTimeTimeZone
  \[InvoiceId \<String\>\]: 
  \[InvoiceStatus \<String\>\]: bookingInvoiceStatus
  \[InvoiceUrl \<String\>\]: 
  \[IsLocationOnline \<Boolean?\>\]: 
  \[OnlineMeetingUrl \<String\>\]: 
  \[OptOutOfCustomerEmail \<Boolean?\>\]: 
  \[PostBuffer \<TimeSpan?\>\]: 
  \[PreBuffer \<TimeSpan?\>\]: 
  \[Price \<Double?\>\]: 
  \[PriceType \<String\>\]: bookingPriceType
  \[Reminders \<IMicrosoftGraphBookingReminder\[\]\>\]: 
    \[Message \<String\>\]: Message to send.
    \[Offset \<TimeSpan?\>\]: How much time before an appointment the reminder should be sent.
    \[Recipients \<String\>\]: bookingReminderRecipients
  \[SelfServiceAppointmentId \<String\>\]: 
  \[ServiceId \<String\>\]: The id of the booking service associated with this appointment.
  \[ServiceLocation \<IMicrosoftGraphLocation\>\]: location
  \[ServiceName \<String\>\]: The name of the booking service associated with this appointment.
  \[ServiceNotes \<String\>\]: 
  \[StaffMemberIds \<String\[\]\>\]: 
  \[Start \<IMicrosoftGraphDateTimeZone\>\]: dateTimeTimeZone

CUSTOMERS \<IMicrosoftGraphBookingCustomer\[\]\>: All customers of this business.
  \[EmailAddress \<String\>\]: The e-mail address of this person.
  \[DisplayName \<String\>\]: Display name of this entity.
  \[Id \<String\>\]: Read-only.

INPUTOBJECT \<IBookingsIdentity\>: Identity Parameter
  \[BookingAppointmentId \<String\>\]: key: id of bookingAppointment
  \[BookingBusinessId \<String\>\]: key: id of bookingBusiness
  \[BookingCurrencyId \<String\>\]: key: id of bookingCurrency
  \[BookingCustomerId \<String\>\]: key: id of bookingCustomer
  \[BookingServiceId \<String\>\]: key: id of bookingService
  \[BookingStaffMemberId \<String\>\]: key: id of bookingStaffMember

SCHEDULINGPOLICY \<IMicrosoftGraphBookingSchedulingPolicy\>: This type represents the set of policies that dictate how bookings can be created in a Booking Calendar.
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[AllowStaffSelection \<Boolean?\>\]: Allow customers to choose a specific person for the booking.
  \[MaximumAdvance \<TimeSpan?\>\]: Maximum number of days in advance that a booking can be made.
  \[MinimumLeadTime \<TimeSpan?\>\]: Minimum lead time for bookings and cancellations.
  \[SendConfirmationsToOwner \<Boolean?\>\]: Notify the business via email when a booking is created or changed.
  \[TimeSlotInterval \<TimeSpan?\>\]: Duration of each time slot.

SERVICES \<IMicrosoftGraphBookingService\[\]\>: All services offered by this business.
  \[DisplayName \<String\>\]: Display name of this entity.
  \[Id \<String\>\]: Read-only.
  \[AdditionalInformation \<String\>\]: 
  \[DefaultDuration \<TimeSpan?\>\]: 
  \[DefaultLocation \<IMicrosoftGraphLocation\>\]: location
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Address \<IMicrosoftGraphPhysicalAddress\>\]: physicalAddress
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[City \<String\>\]: The city.
      \[CountryOrRegion \<String\>\]: The country or region.
It's a free-format string value, for example, 'United States'.
      \[PostOfficeBox \<String\>\]: 
      \[PostalCode \<String\>\]: The postal code.
      \[State \<String\>\]: The state.
      \[Street \<String\>\]: The street.
      \[Type \<String\>\]: physicalAddressType
    \[Coordinates \<IMicrosoftGraphOutlookGeoCoordinates\>\]: outlookGeoCoordinates
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[Accuracy \<Double?\>\]: The accuracy of the latitude and longitude.
As an example, the accuracy can be measured in meters, such as the latitude and longitude are accurate to within 50 meters.
      \[Altitude \<Double?\>\]: The altitude of the location.
      \[AltitudeAccuracy \<Double?\>\]: The accuracy of the altitude.
      \[Latitude \<Double?\>\]: The latitude of the location.
      \[Longitude \<Double?\>\]: The longitude of the location.
    \[DisplayName \<String\>\]: The name associated with the location.
    \[LocationEmailAddress \<String\>\]: Optional email address of the location.
    \[LocationType \<String\>\]: locationType
    \[LocationUri \<String\>\]: Optional URI representing the location.
    \[UniqueId \<String\>\]: For internal use only.
    \[UniqueIdType \<String\>\]: locationUniqueIdType
  \[DefaultPrice \<Double?\>\]: 
  \[DefaultPriceType \<String\>\]: bookingPriceType
  \[DefaultReminders \<IMicrosoftGraphBookingReminder\[\]\>\]: The default reminders set in an appointment of this service.
    \[Message \<String\>\]: Message to send.
    \[Offset \<TimeSpan?\>\]: How much time before an appointment the reminder should be sent.
    \[Recipients \<String\>\]: bookingReminderRecipients
  \[Description \<String\>\]: 
  \[IsHiddenFromCustomers \<Boolean?\>\]: 
  \[IsLocationOnline \<Boolean?\>\]: 
  \[Notes \<String\>\]: 
  \[PostBuffer \<TimeSpan?\>\]: 
  \[PreBuffer \<TimeSpan?\>\]: 
  \[SchedulingPolicy \<IMicrosoftGraphBookingSchedulingPolicy\>\]: This type represents the set of policies that dictate how bookings can be created in a Booking Calendar.
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[AllowStaffSelection \<Boolean?\>\]: Allow customers to choose a specific person for the booking.
    \[MaximumAdvance \<TimeSpan?\>\]: Maximum number of days in advance that a booking can be made.
    \[MinimumLeadTime \<TimeSpan?\>\]: Minimum lead time for bookings and cancellations.
    \[SendConfirmationsToOwner \<Boolean?\>\]: Notify the business via email when a booking is created or changed.
    \[TimeSlotInterval \<TimeSpan?\>\]: Duration of each time slot.
  \[StaffMemberIds \<String\[\]\>\]: 

STAFFMEMBERS \<IMicrosoftGraphBookingStaffMember\[\]\>: All staff members that provides services in this business.
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

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.bookings/update-mgbookingbusiness](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.bookings/update-mgbookingbusiness)

