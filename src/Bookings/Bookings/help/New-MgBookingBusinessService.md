---
external help file: Microsoft.Graph.Bookings-help.xml
Module Name: Microsoft.Graph.Bookings
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.bookings/new-mgbookingbusinessservice
schema: 2.0.0
---

# New-MgBookingBusinessService

## SYNOPSIS
Create new navigation property to services for bookingBusinesses

## SYNTAX

### CreateExpanded (Default)
```
New-MgBookingBusinessService -BookingBusinessId <String> [-AdditionalInformation <String>]
 [-AdditionalProperties <Hashtable>] [-DefaultDuration <TimeSpan>] [-DefaultLocation <IMicrosoftGraphLocation>]
 [-DefaultPrice <Double>] [-DefaultPriceType <String>] [-DefaultReminders <IMicrosoftGraphBookingReminder[]>]
 [-Description <String>] [-DisplayName <String>] [-Id <String>] [-IsHiddenFromCustomers] [-IsLocationOnline]
 [-Notes <String>] [-PostBuffer <TimeSpan>] [-PreBuffer <TimeSpan>]
 [-SchedulingPolicy <IMicrosoftGraphBookingSchedulingPolicy>] [-StaffMemberIds <String[]>] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### Create
```
New-MgBookingBusinessService -BookingBusinessId <String> -BodyParameter <IMicrosoftGraphBookingService>
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgBookingBusinessService -InputObject <IBookingsIdentity> [-AdditionalInformation <String>]
 [-AdditionalProperties <Hashtable>] [-DefaultDuration <TimeSpan>] [-DefaultLocation <IMicrosoftGraphLocation>]
 [-DefaultPrice <Double>] [-DefaultPriceType <String>] [-DefaultReminders <IMicrosoftGraphBookingReminder[]>]
 [-Description <String>] [-DisplayName <String>] [-Id <String>] [-IsHiddenFromCustomers] [-IsLocationOnline]
 [-Notes <String>] [-PostBuffer <TimeSpan>] [-PreBuffer <TimeSpan>]
 [-SchedulingPolicy <IMicrosoftGraphBookingSchedulingPolicy>] [-StaffMemberIds <String[]>] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgBookingBusinessService -InputObject <IBookingsIdentity> -BodyParameter <IMicrosoftGraphBookingService>
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to services for bookingBusinesses

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

### -AdditionalInformation
.

```yaml
Type: String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
Represents a particular service offered by a booking business.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphBookingService
Parameter Sets: Create, CreateViaIdentity
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
Parameter Sets: CreateExpanded, Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultDuration
.

```yaml
Type: TimeSpan
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultLocation
location
To construct, see NOTES section for DEFAULTLOCATION properties and create a hash table.

```yaml
Type: IMicrosoftGraphLocation
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultPrice
.

```yaml
Type: Double
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultPriceType
bookingPriceType

```yaml
Type: String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultReminders
The default reminders set in an appointment of this service.
To construct, see NOTES section for DEFAULTREMINDERS properties and create a hash table.

```yaml
Type: IMicrosoftGraphBookingReminder[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
.

```yaml
Type: String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateViaIdentityExpanded, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IsHiddenFromCustomers
.

```yaml
Type: SwitchParameter
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsLocationOnline
.

```yaml
Type: SwitchParameter
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -Notes
.

```yaml
Type: String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PostBuffer
.

```yaml
Type: TimeSpan
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PreBuffer
.

```yaml
Type: TimeSpan
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StaffMemberIds
.

```yaml
Type: String[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphBookingService
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphBookingService
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

BODYPARAMETER \<IMicrosoftGraphBookingService\>: Represents a particular service offered by a booking business.
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
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

DEFAULTLOCATION \<IMicrosoftGraphLocation\>: location
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

DEFAULTREMINDERS \<IMicrosoftGraphBookingReminder\[\]\>: The default reminders set in an appointment of this service.
  \[Message \<String\>\]: Message to send.
  \[Offset \<TimeSpan?\>\]: How much time before an appointment the reminder should be sent.
  \[Recipients \<String\>\]: bookingReminderRecipients

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

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.bookings/new-mgbookingbusinessservice](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.bookings/new-mgbookingbusinessservice)

