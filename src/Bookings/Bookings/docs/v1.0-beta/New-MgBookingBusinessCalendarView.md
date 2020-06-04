---
external help file:
Module Name: Microsoft.Graph.Bookings
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.bookings/new-mgbookingbusinesscalendarview
schema: 2.0.0
---

# New-MgBookingBusinessCalendarView

## SYNOPSIS
Create new navigation property to calendarView for bookingBusinesses

## SYNTAX

### CreateExpanded (Default)
```
New-MgBookingBusinessCalendarView -BookingBusinessId <String> [-CustomerEmailAddress <String>]
 [-CustomerId <String>] [-CustomerLocationAddressCity <String>]
 [-CustomerLocationAddressCountryOrRegion <String>] [-CustomerLocationAddressPostalCode <String>]
 [-CustomerLocationAddressPostOfficeBox <String>] [-CustomerLocationAddressState <String>]
 [-CustomerLocationAddressStreet <String>] [-CustomerLocationAddressType <String>]
 [-CustomerLocationCoordinatesAccuracy <Double>] [-CustomerLocationCoordinatesAltitude <Double>]
 [-CustomerLocationCoordinatesAltitudeAccuracy <Double>] [-CustomerLocationCoordinatesLatitude <Double>]
 [-CustomerLocationCoordinatesLongitude <Double>] [-CustomerLocationDisplayName <String>]
 [-CustomerLocationEmailAddress <String>] [-CustomerLocationType <String>]
 [-CustomerLocationUniqueId <String>] [-CustomerLocationUniqueIdType <String>] [-CustomerLocationUri <String>]
 [-CustomerName <String>] [-CustomerNotes <String>] [-CustomerPhone <String>] [-Duration <TimeSpan>]
 [-EndDateTime <String>] [-EndTimeZone <String>] [-Id <String>] [-InvoiceAmount <Double>]
 [-InvoiceDateTime <String>] [-InvoiceDateTimeZone <String>] [-InvoiceId <String>] [-InvoiceStatus <String>]
 [-InvoiceUrl <String>] [-OptOutOfCustomerEmail] [-PostBuffer <TimeSpan>] [-PreBuffer <TimeSpan>]
 [-Price <Double>] [-PriceType <String>] [-Reminders <IMicrosoftGraphBookingReminder[]>]
 [-SelfServiceAppointmentId <String>] [-ServiceId <String>] [-ServiceLocationAddressCity <String>]
 [-ServiceLocationAddressCountryOrRegion <String>] [-ServiceLocationAddressPostalCode <String>]
 [-ServiceLocationAddressPostOfficeBox <String>] [-ServiceLocationAddressState <String>]
 [-ServiceLocationAddressStreet <String>] [-ServiceLocationAddressType <String>]
 [-ServiceLocationCoordinatesAccuracy <Double>] [-ServiceLocationCoordinatesAltitude <Double>]
 [-ServiceLocationCoordinatesAltitudeAccuracy <Double>] [-ServiceLocationCoordinatesLatitude <Double>]
 [-ServiceLocationCoordinatesLongitude <Double>] [-ServiceLocationDisplayName <String>]
 [-ServiceLocationEmailAddress <String>] [-ServiceLocationType <String>] [-ServiceLocationUniqueId <String>]
 [-ServiceLocationUniqueIdType <String>] [-ServiceLocationUri <String>] [-ServiceName <String>]
 [-ServiceNotes <String>] [-StaffMemberIds <String[]>] [-StartDateTime <String>] [-StartTimeZone <String>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgBookingBusinessCalendarView -BookingBusinessId <String>
 -BodyParameter <IMicrosoftGraphBookingAppointment> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgBookingBusinessCalendarView -InputObject <IBookingsIdentity>
 -BodyParameter <IMicrosoftGraphBookingAppointment> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgBookingBusinessCalendarView -InputObject <IBookingsIdentity> [-CustomerEmailAddress <String>]
 [-CustomerId <String>] [-CustomerLocationAddressCity <String>]
 [-CustomerLocationAddressCountryOrRegion <String>] [-CustomerLocationAddressPostalCode <String>]
 [-CustomerLocationAddressPostOfficeBox <String>] [-CustomerLocationAddressState <String>]
 [-CustomerLocationAddressStreet <String>] [-CustomerLocationAddressType <String>]
 [-CustomerLocationCoordinatesAccuracy <Double>] [-CustomerLocationCoordinatesAltitude <Double>]
 [-CustomerLocationCoordinatesAltitudeAccuracy <Double>] [-CustomerLocationCoordinatesLatitude <Double>]
 [-CustomerLocationCoordinatesLongitude <Double>] [-CustomerLocationDisplayName <String>]
 [-CustomerLocationEmailAddress <String>] [-CustomerLocationType <String>]
 [-CustomerLocationUniqueId <String>] [-CustomerLocationUniqueIdType <String>] [-CustomerLocationUri <String>]
 [-CustomerName <String>] [-CustomerNotes <String>] [-CustomerPhone <String>] [-Duration <TimeSpan>]
 [-EndDateTime <String>] [-EndTimeZone <String>] [-Id <String>] [-InvoiceAmount <Double>]
 [-InvoiceDateTime <String>] [-InvoiceDateTimeZone <String>] [-InvoiceId <String>] [-InvoiceStatus <String>]
 [-InvoiceUrl <String>] [-OptOutOfCustomerEmail] [-PostBuffer <TimeSpan>] [-PreBuffer <TimeSpan>]
 [-Price <Double>] [-PriceType <String>] [-Reminders <IMicrosoftGraphBookingReminder[]>]
 [-SelfServiceAppointmentId <String>] [-ServiceId <String>] [-ServiceLocationAddressCity <String>]
 [-ServiceLocationAddressCountryOrRegion <String>] [-ServiceLocationAddressPostalCode <String>]
 [-ServiceLocationAddressPostOfficeBox <String>] [-ServiceLocationAddressState <String>]
 [-ServiceLocationAddressStreet <String>] [-ServiceLocationAddressType <String>]
 [-ServiceLocationCoordinatesAccuracy <Double>] [-ServiceLocationCoordinatesAltitude <Double>]
 [-ServiceLocationCoordinatesAltitudeAccuracy <Double>] [-ServiceLocationCoordinatesLatitude <Double>]
 [-ServiceLocationCoordinatesLongitude <Double>] [-ServiceLocationDisplayName <String>]
 [-ServiceLocationEmailAddress <String>] [-ServiceLocationType <String>] [-ServiceLocationUniqueId <String>]
 [-ServiceLocationUniqueIdType <String>] [-ServiceLocationUri <String>] [-ServiceName <String>]
 [-ServiceNotes <String>] [-StaffMemberIds <String[]>] [-StartDateTime <String>] [-StartTimeZone <String>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to calendarView for bookingBusinesses

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

### -BodyParameter
Represents a booked appointment of a service by a customer in a business.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphBookingAppointment
Parameter Sets: Create, CreateViaIdentity
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
Parameter Sets: Create, CreateExpanded
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
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CustomerLocationAddressCity
The city.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CustomerLocationAddressCountryOrRegion
The country or region.
It's a free-format string value, for example, 'United States'.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CustomerLocationAddressPostalCode
The postal code.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CustomerLocationAddressPostOfficeBox
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CustomerLocationAddressState
The state.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CustomerLocationAddressStreet
The street.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CustomerLocationAddressType
physicalAddressType

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CustomerLocationCoordinatesAccuracy
The accuracy of the latitude and longitude.
As an example, the accuracy can be measured in meters, such as the latitude and longitude are accurate to within 50 meters.

```yaml
Type: System.Double
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CustomerLocationCoordinatesAltitude
The altitude of the location.

```yaml
Type: System.Double
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CustomerLocationCoordinatesAltitudeAccuracy
The accuracy of the altitude.

```yaml
Type: System.Double
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CustomerLocationCoordinatesLatitude
The latitude of the location.

```yaml
Type: System.Double
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CustomerLocationCoordinatesLongitude
The longitude of the location.

```yaml
Type: System.Double
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CustomerLocationDisplayName
The name associated with the location.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CustomerLocationEmailAddress
Optional email address of the location.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CustomerLocationType
locationType

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CustomerLocationUniqueId
For internal use only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CustomerLocationUniqueIdType
locationUniqueIdType

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CustomerLocationUri
Optional URI representing the location.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Type: System.TimeSpan
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EndDateTime
A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EndTimeZone
Represents a time zone, for example, 'Pacific Standard Time'.
See below for more possible values.

```yaml
Type: System.String
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
Type: System.String
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
Type: Microsoft.Graph.PowerShell.Models.IBookingsIdentity
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
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
Type: System.Double
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InvoiceDateTime
A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InvoiceDateTimeZone
Represents a time zone, for example, 'Pacific Standard Time'.
See below for more possible values.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Type: System.Management.Automation.SwitchParameter
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
Type: System.TimeSpan
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
Type: System.TimeSpan
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Type: System.Double
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PriceType
bookingPriceType

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphBookingReminder[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ServiceLocationAddressCity
The city.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ServiceLocationAddressCountryOrRegion
The country or region.
It's a free-format string value, for example, 'United States'.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ServiceLocationAddressPostalCode
The postal code.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ServiceLocationAddressPostOfficeBox
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ServiceLocationAddressState
The state.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ServiceLocationAddressStreet
The street.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ServiceLocationAddressType
physicalAddressType

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ServiceLocationCoordinatesAccuracy
The accuracy of the latitude and longitude.
As an example, the accuracy can be measured in meters, such as the latitude and longitude are accurate to within 50 meters.

```yaml
Type: System.Double
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ServiceLocationCoordinatesAltitude
The altitude of the location.

```yaml
Type: System.Double
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ServiceLocationCoordinatesAltitudeAccuracy
The accuracy of the altitude.

```yaml
Type: System.Double
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ServiceLocationCoordinatesLatitude
The latitude of the location.

```yaml
Type: System.Double
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ServiceLocationCoordinatesLongitude
The longitude of the location.

```yaml
Type: System.Double
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ServiceLocationDisplayName
The name associated with the location.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ServiceLocationEmailAddress
Optional email address of the location.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ServiceLocationType
locationType

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ServiceLocationUniqueId
For internal use only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ServiceLocationUniqueIdType
locationUniqueIdType

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ServiceLocationUri
Optional URI representing the location.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Type: System.String
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
Type: System.String[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StartDateTime
A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StartTimeZone
Represents a time zone, for example, 'Pacific Standard Time'.
See below for more possible values.

```yaml
Type: System.String
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphBookingAppointment

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphBookingAppointment

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphBookingAppointment>: Represents a booked appointment of a service by a customer in a business.
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

INPUTOBJECT <IBookingsIdentity>: Identity Parameter
  - `[BookingAppointmentId <String>]`: key: bookingAppointment-id of bookingAppointment
  - `[BookingBusinessId <String>]`: key: bookingBusiness-id of bookingBusiness
  - `[BookingCurrencyId <String>]`: key: bookingCurrency-id of bookingCurrency
  - `[BookingCustomerId <String>]`: key: bookingCustomer-id of bookingCustomer
  - `[BookingServiceId <String>]`: key: bookingService-id of bookingService
  - `[BookingStaffMemberId <String>]`: key: bookingStaffMember-id of bookingStaffMember

REMINDERS <IMicrosoftGraphBookingReminder[]>: .
  - `[Message <String>]`: Message to send.
  - `[Offset <TimeSpan?>]`: How much time before an appointment the reminder should be sent.
  - `[Recipients <String>]`: bookingReminderRecipients

## RELATED LINKS

