---
external help file: Microsoft.Graph.Bookings-help.xml
Module Name: Microsoft.Graph.Bookings
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.bookings/update-mgbookingbusinesscalendarview
schema: 2.0.0
---

# Update-MgBookingBusinessCalendarView

## SYNOPSIS
Update the navigation property calendarView in bookingBusinesses

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBookingBusinessCalendarView -BookingAppointmentId <String> -BookingBusinessId <String>
 [-AdditionalInformation <String>] [-AdditionalProperties <Hashtable>] [-CustomerEmailAddress <String>]
 [-CustomerId <String>] [-CustomerLocation <IMicrosoftGraphLocation>] [-CustomerName <String>]
 [-CustomerNotes <String>] [-CustomerPhone <String>] [-Duration <TimeSpan>]
 [-End <IMicrosoftGraphDateTimeZone>] [-Id <String>] [-InvoiceAmount <Double>]
 [-InvoiceDate <IMicrosoftGraphDateTimeZone>] [-InvoiceId <String>] [-InvoiceStatus <String>]
 [-InvoiceUrl <String>] [-IsLocationOnline] [-OnlineMeetingUrl <String>] [-OptOutOfCustomerEmail]
 [-PostBuffer <TimeSpan>] [-PreBuffer <TimeSpan>] [-Price <Double>] [-PriceType <String>]
 [-Reminders <IMicrosoftGraphBookingReminder[]>] [-SelfServiceAppointmentId <String>] [-ServiceId <String>]
 [-ServiceLocation <IMicrosoftGraphLocation>] [-ServiceName <String>] [-ServiceNotes <String>]
 [-StaffMemberIds <String[]>] [-Start <IMicrosoftGraphDateTimeZone>] [-PassThru] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### Update
```
Update-MgBookingBusinessCalendarView -BookingAppointmentId <String> -BookingBusinessId <String>
 -BodyParameter <IMicrosoftGraphBookingAppointment> [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBookingBusinessCalendarView -InputObject <IBookingsIdentity> [-AdditionalInformation <String>]
 [-AdditionalProperties <Hashtable>] [-CustomerEmailAddress <String>] [-CustomerId <String>]
 [-CustomerLocation <IMicrosoftGraphLocation>] [-CustomerName <String>] [-CustomerNotes <String>]
 [-CustomerPhone <String>] [-Duration <TimeSpan>] [-End <IMicrosoftGraphDateTimeZone>] [-Id <String>]
 [-InvoiceAmount <Double>] [-InvoiceDate <IMicrosoftGraphDateTimeZone>] [-InvoiceId <String>]
 [-InvoiceStatus <String>] [-InvoiceUrl <String>] [-IsLocationOnline] [-OnlineMeetingUrl <String>]
 [-OptOutOfCustomerEmail] [-PostBuffer <TimeSpan>] [-PreBuffer <TimeSpan>] [-Price <Double>]
 [-PriceType <String>] [-Reminders <IMicrosoftGraphBookingReminder[]>] [-SelfServiceAppointmentId <String>]
 [-ServiceId <String>] [-ServiceLocation <IMicrosoftGraphLocation>] [-ServiceName <String>]
 [-ServiceNotes <String>] [-StaffMemberIds <String[]>] [-Start <IMicrosoftGraphDateTimeZone>] [-PassThru]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBookingBusinessCalendarView -InputObject <IBookingsIdentity>
 -BodyParameter <IMicrosoftGraphBookingAppointment> [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property calendarView in bookingBusinesses

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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
Represents a booked appointment of a service by a customer in a business.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphBookingAppointment
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -BookingAppointmentId
key: id of bookingAppointment

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

### -CustomerEmailAddress
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

### -CustomerId
The id of the booking customer associated with this appointment.

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

### -CustomerLocation
location
To construct, see NOTES section for CUSTOMERLOCATION properties and create a hash table.

```yaml
Type: IMicrosoftGraphLocation
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CustomerName
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

### -CustomerNotes
Notes from the customer associated with this appointment.

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

### -CustomerPhone
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

### -Duration
.

```yaml
Type: TimeSpan
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -End
dateTimeTimeZone
To construct, see NOTES section for END properties and create a hash table.

```yaml
Type: IMicrosoftGraphDateTimeZone
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

### -InvoiceAmount
.

```yaml
Type: Double
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -InvoiceDate
dateTimeTimeZone
To construct, see NOTES section for INVOICEDATE properties and create a hash table.

```yaml
Type: IMicrosoftGraphDateTimeZone
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InvoiceId
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

### -InvoiceStatus
bookingInvoiceStatus

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

### -InvoiceUrl
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

### -IsLocationOnline
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

### -OnlineMeetingUrl
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

### -OptOutOfCustomerEmail
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

### -PostBuffer
.

```yaml
Type: TimeSpan
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Price
.

```yaml
Type: Double
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -PriceType
bookingPriceType

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

### -Reminders
.
To construct, see NOTES section for REMINDERS properties and create a hash table.

```yaml
Type: IMicrosoftGraphBookingReminder[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SelfServiceAppointmentId
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

### -ServiceId
The id of the booking service associated with this appointment.

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

### -ServiceLocation
location
To construct, see NOTES section for SERVICELOCATION properties and create a hash table.

```yaml
Type: IMicrosoftGraphLocation
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ServiceName
The name of the booking service associated with this appointment.

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

### -ServiceNotes
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

### -StaffMemberIds
.

```yaml
Type: String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Start
dateTimeTimeZone
To construct, see NOTES section for START properties and create a hash table.

```yaml
Type: IMicrosoftGraphDateTimeZone
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
### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphBookingAppointment
## OUTPUTS

### System.Boolean
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

BODYPARAMETER \<IMicrosoftGraphBookingAppointment\>: Represents a booked appointment of a service by a customer in a business.
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
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

CUSTOMERLOCATION \<IMicrosoftGraphLocation\>: location
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

END \<IMicrosoftGraphDateTimeZone\>: dateTimeTimeZone
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[DateTime \<String\>\]: A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).
  \[TimeZone \<String\>\]: Represents a time zone, for example, 'Pacific Standard Time'.
See below for more possible values.

INPUTOBJECT \<IBookingsIdentity\>: Identity Parameter
  \[BookingAppointmentId \<String\>\]: key: id of bookingAppointment
  \[BookingBusinessId \<String\>\]: key: id of bookingBusiness
  \[BookingCurrencyId \<String\>\]: key: id of bookingCurrency
  \[BookingCustomerId \<String\>\]: key: id of bookingCustomer
  \[BookingServiceId \<String\>\]: key: id of bookingService
  \[BookingStaffMemberId \<String\>\]: key: id of bookingStaffMember

INVOICEDATE \<IMicrosoftGraphDateTimeZone\>: dateTimeTimeZone
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[DateTime \<String\>\]: A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).
  \[TimeZone \<String\>\]: Represents a time zone, for example, 'Pacific Standard Time'.
See below for more possible values.

REMINDERS \<IMicrosoftGraphBookingReminder\[\]\>: .
  \[Message \<String\>\]: Message to send.
  \[Offset \<TimeSpan?\>\]: How much time before an appointment the reminder should be sent.
  \[Recipients \<String\>\]: bookingReminderRecipients

SERVICELOCATION \<IMicrosoftGraphLocation\>: location
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

START \<IMicrosoftGraphDateTimeZone\>: dateTimeTimeZone
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[DateTime \<String\>\]: A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).
  \[TimeZone \<String\>\]: Represents a time zone, for example, 'Pacific Standard Time'.
See below for more possible values.

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.bookings/update-mgbookingbusinesscalendarview](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.bookings/update-mgbookingbusinesscalendarview)

