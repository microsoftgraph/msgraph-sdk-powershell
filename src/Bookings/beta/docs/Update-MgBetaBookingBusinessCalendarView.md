---
external help file:
Module Name: Microsoft.Graph.Beta.Bookings
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.bookings/update-mgbetabookingbusinesscalendarview
schema: 2.0.0
---

# Update-MgBetaBookingBusinessCalendarView

## SYNOPSIS
Update the navigation property calendarView in bookingBusinesses

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaBookingBusinessCalendarView -BookingAppointmentId <String> -BookingBusinessId <String>
 [-AdditionalInformation <String>] [-AdditionalProperties <Hashtable>] [-AnonymousJoinWebUrl <String>]
 [-AppointmentLabel <String>] [-CreatedDateTime <DateTime>] [-CustomerEmailAddress <String>]
 [-CustomerId <String>] [-CustomerLocation <IMicrosoftGraphLocation>] [-CustomerName <String>]
 [-CustomerNotes <String>] [-CustomerPhone <String>]
 [-Customers <IMicrosoftGraphBookingCustomerInformationBase[]>] [-CustomerTimeZone <String>]
 [-End <IMicrosoftGraphDateTimeZone>] [-Id <String>] [-InvoiceAmount <Double>]
 [-InvoiceDate <IMicrosoftGraphDateTimeZone>] [-InvoiceId <String>] [-InvoiceStatus <String>]
 [-InvoiceUrl <String>] [-IsLocationOnline] [-JoinWebUrl <String>] [-LastUpdatedDateTime <DateTime>]
 [-MaximumAttendeesCount <Int32>] [-OnlineMeetingUrl <String>] [-OptOutOfCustomerEmail]
 [-PostBuffer <TimeSpan>] [-PreBuffer <TimeSpan>] [-Price <Double>] [-PriceType <BookingPriceType>]
 [-Reminders <IMicrosoftGraphBookingReminder[]>] [-ResponseHeadersVariable <String>]
 [-SelfServiceAppointmentId <String>] [-ServiceId <String>] [-ServiceLocation <IMicrosoftGraphLocation>]
 [-ServiceName <String>] [-ServiceNotes <String>] [-SmsNotificationsEnabled] [-StaffMemberIds <String[]>]
 [-Start <IMicrosoftGraphDateTimeZone>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaBookingBusinessCalendarView -BookingAppointmentId <String> -BookingBusinessId <String>
 -BodyParameter <IMicrosoftGraphBookingAppointment> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update1
```
Update-MgBetaBookingBusinessCalendarView -BookingAppointmentId <String> -BookingBusinessId <String>
 -BodyParameter <IMicrosoftGraphBookingAppointment> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateExpanded1
```
Update-MgBetaBookingBusinessCalendarView -BookingAppointmentId <String> -BookingBusinessId <String>
 [-AdditionalInformation <String>] [-AdditionalProperties <Hashtable>] [-AnonymousJoinWebUrl <String>]
 [-AppointmentLabel <String>] [-CreatedDateTime <DateTime>] [-CustomerEmailAddress <String>]
 [-CustomerId <String>] [-CustomerLocation <IMicrosoftGraphLocation>] [-CustomerName <String>]
 [-CustomerNotes <String>] [-CustomerPhone <String>]
 [-Customers <IMicrosoftGraphBookingCustomerInformationBase[]>] [-CustomerTimeZone <String>]
 [-End <IMicrosoftGraphDateTimeZone>] [-Id <String>] [-InvoiceAmount <Double>]
 [-InvoiceDate <IMicrosoftGraphDateTimeZone>] [-InvoiceId <String>] [-InvoiceStatus <String>]
 [-InvoiceUrl <String>] [-IsLocationOnline] [-JoinWebUrl <String>] [-LastUpdatedDateTime <DateTime>]
 [-MaximumAttendeesCount <Int32>] [-OnlineMeetingUrl <String>] [-OptOutOfCustomerEmail]
 [-PostBuffer <TimeSpan>] [-PreBuffer <TimeSpan>] [-Price <Double>] [-PriceType <BookingPriceType>]
 [-Reminders <IMicrosoftGraphBookingReminder[]>] [-ResponseHeadersVariable <String>]
 [-SelfServiceAppointmentId <String>] [-ServiceId <String>] [-ServiceLocation <IMicrosoftGraphLocation>]
 [-ServiceName <String>] [-ServiceNotes <String>] [-SmsNotificationsEnabled] [-StaffMemberIds <String[]>]
 [-Start <IMicrosoftGraphDateTimeZone>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBetaBookingBusinessCalendarView -InputObject <IBookingsIdentity>
 -BodyParameter <IMicrosoftGraphBookingAppointment> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity1
```
Update-MgBetaBookingBusinessCalendarView -InputObject <IBookingsIdentity>
 -BodyParameter <IMicrosoftGraphBookingAppointment> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBetaBookingBusinessCalendarView -InputObject <IBookingsIdentity> [-AdditionalInformation <String>]
 [-AdditionalProperties <Hashtable>] [-AnonymousJoinWebUrl <String>] [-AppointmentLabel <String>]
 [-CreatedDateTime <DateTime>] [-CustomerEmailAddress <String>] [-CustomerId <String>]
 [-CustomerLocation <IMicrosoftGraphLocation>] [-CustomerName <String>] [-CustomerNotes <String>]
 [-CustomerPhone <String>] [-Customers <IMicrosoftGraphBookingCustomerInformationBase[]>]
 [-CustomerTimeZone <String>] [-End <IMicrosoftGraphDateTimeZone>] [-Id <String>] [-InvoiceAmount <Double>]
 [-InvoiceDate <IMicrosoftGraphDateTimeZone>] [-InvoiceId <String>] [-InvoiceStatus <String>]
 [-InvoiceUrl <String>] [-IsLocationOnline] [-JoinWebUrl <String>] [-LastUpdatedDateTime <DateTime>]
 [-MaximumAttendeesCount <Int32>] [-OnlineMeetingUrl <String>] [-OptOutOfCustomerEmail]
 [-PostBuffer <TimeSpan>] [-PreBuffer <TimeSpan>] [-Price <Double>] [-PriceType <BookingPriceType>]
 [-Reminders <IMicrosoftGraphBookingReminder[]>] [-ResponseHeadersVariable <String>]
 [-SelfServiceAppointmentId <String>] [-ServiceId <String>] [-ServiceLocation <IMicrosoftGraphLocation>]
 [-ServiceName <String>] [-ServiceNotes <String>] [-SmsNotificationsEnabled] [-StaffMemberIds <String[]>]
 [-Start <IMicrosoftGraphDateTimeZone>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded1
```
Update-MgBetaBookingBusinessCalendarView -InputObject <IBookingsIdentity> [-AdditionalInformation <String>]
 [-AdditionalProperties <Hashtable>] [-AnonymousJoinWebUrl <String>] [-AppointmentLabel <String>]
 [-CreatedDateTime <DateTime>] [-CustomerEmailAddress <String>] [-CustomerId <String>]
 [-CustomerLocation <IMicrosoftGraphLocation>] [-CustomerName <String>] [-CustomerNotes <String>]
 [-CustomerPhone <String>] [-Customers <IMicrosoftGraphBookingCustomerInformationBase[]>]
 [-CustomerTimeZone <String>] [-End <IMicrosoftGraphDateTimeZone>] [-Id <String>] [-InvoiceAmount <Double>]
 [-InvoiceDate <IMicrosoftGraphDateTimeZone>] [-InvoiceId <String>] [-InvoiceStatus <String>]
 [-InvoiceUrl <String>] [-IsLocationOnline] [-JoinWebUrl <String>] [-LastUpdatedDateTime <DateTime>]
 [-MaximumAttendeesCount <Int32>] [-OnlineMeetingUrl <String>] [-OptOutOfCustomerEmail]
 [-PostBuffer <TimeSpan>] [-PreBuffer <TimeSpan>] [-Price <Double>] [-PriceType <BookingPriceType>]
 [-Reminders <IMicrosoftGraphBookingReminder[]>] [-ResponseHeadersVariable <String>]
 [-SelfServiceAppointmentId <String>] [-ServiceId <String>] [-ServiceLocation <IMicrosoftGraphLocation>]
 [-ServiceName <String>] [-ServiceNotes <String>] [-SmsNotificationsEnabled] [-StaffMemberIds <String[]>]
 [-Start <IMicrosoftGraphDateTimeZone>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property calendarView in bookingBusinesses

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

## PARAMETERS

### -AdditionalInformation
Additional information that is sent to the customer when an appointment is confirmed.

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

### -AnonymousJoinWebUrl
The URL of the meeting to join anonymously.

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

### -AppointmentLabel
Custom label that can be stamped on this appointment by the user.

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

### -BodyParameter
Represents a booked appointment of a service by a customer in a business.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphBookingAppointment
Parameter Sets: Update, Update1, UpdateViaIdentity, UpdateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -BookingAppointmentId
The unique identifier of bookingAppointment

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

### -CreatedDateTime
The date, time and timezone when the appointment was created.

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

### -CustomerEmailAddress
The SMTP address of the bookingCustomer who is booking the appointment.

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

### -CustomerId
The ID of the bookingCustomer for this appointment.
If no ID is specified when an appointment is created, then a new bookingCustomer object is created.
Once set, you should consider the customerId immutable.

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

### -CustomerLocation
location
To construct, see NOTES section for CUSTOMERLOCATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphLocation
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CustomerName
The customer's name.

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

### -CustomerNotes
Notes from the customer associated with this appointment.
You can get the value only when reading this bookingAppointment by its ID.
You can set this property only when initially creating an appointment with a new customer.
After that point, the value is computed from the customer represented by customerId.

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

### -CustomerPhone
The customer's phone number.

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

### -Customers
A collection of the customer properties for an appointment.
An appointment will contain a list of customer information and each unit will indicate the properties of a customer who is part of that appointment.
Optional.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphBookingCustomerInformationBase[]
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CustomerTimeZone
The time zone of the customer.
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

### -End
dateTimeTimeZone
To construct, see NOTES section for END properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDateTimeZone
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Headers
Optional headers that will be added to the request.

```yaml
Type: System.Collections.IDictionary
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### -InvoiceAmount
The billed amount on the invoice.

```yaml
Type: System.Double
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InvoiceDate
dateTimeTimeZone
To construct, see NOTES section for INVOICEDATE properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDateTimeZone
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InvoiceId
The ID of the invoice.

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

### -InvoiceStatus
bookingInvoiceStatus

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

### -InvoiceUrl
The URL of the invoice in Microsoft Bookings.

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

### -IsLocationOnline
True indicates that the appointment will be held online.
Default value is false.

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

### -JoinWebUrl
The URL of the online meeting for the appointment.

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

### -LastUpdatedDateTime
The date, time and timezone when the booking business was last updated.

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

### -MaximumAttendeesCount
The maximum number of customers allowed in an appointment.
If maximumAttendeesCount of the service is greater than 1, pass valid customer IDs while creating or updating an appointment.
To create a customer, use the Create bookingCustomer operation.

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

### -OnlineMeetingUrl
.

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

### -OptOutOfCustomerEmail
True indicates that the bookingCustomer for this appointment does not wish to receive a confirmation for this appointment.

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

### -PostBuffer
The amount of time to reserve after the appointment ends, for cleaning up, as an example.
The value is expressed in ISO8601 format.

```yaml
Type: System.TimeSpan
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PreBuffer
The amount of time to reserve before the appointment begins, for preparation, as an example.
The value is expressed in ISO8601 format.

```yaml
Type: System.TimeSpan
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Price
The regular price for an appointment for the specified bookingService.

```yaml
Type: System.Double
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PriceType
Represents the type of pricing of a booking service.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Support.BookingPriceType
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Reminders
The collection of customer reminders sent for this appointment.
The value of this property is available only when reading this bookingAppointment by its ID.
To construct, see NOTES section for REMINDERS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphBookingReminder[]
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResponseHeadersVariable
Optional Response Headers Variable.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: RHV

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SelfServiceAppointmentId
An additional tracking ID for the appointment, if the appointment has been created directly by the customer on the scheduling page, as opposed to by a staff member on the behalf of the customer.

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

### -ServiceId
The ID of the bookingService associated with this appointment.

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

### -ServiceLocation
location
To construct, see NOTES section for SERVICELOCATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphLocation
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ServiceName
The name of the bookingService associated with this appointment.This property is optional when creating a new appointment.
If not specified, it is computed from the service associated with the appointment by the serviceId property.

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

### -ServiceNotes
Notes from a bookingStaffMember.
The value of this property is available only when reading this bookingAppointment by its ID.

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

### -SmsNotificationsEnabled
True indicates SMS notifications will be sent to the customers for the appointment.
Default value is false.

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

### -StaffMemberIds
The ID of each bookingStaffMember who is scheduled in this appointment.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDateTimeZone
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphBookingAppointment

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphBookingAppointment

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphBookingAppointment>`: Represents a booked appointment of a service by a customer in a business.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AdditionalInformation <String>]`: Additional information that is sent to the customer when an appointment is confirmed.
  - `[AnonymousJoinWebUrl <String>]`: The URL of the meeting to join anonymously.
  - `[AppointmentLabel <String>]`: Custom label that can be stamped on this appointment by the user.
  - `[CreatedDateTime <DateTime?>]`: The date, time and timezone when the appointment was created.
  - `[CustomerEmailAddress <String>]`: The SMTP address of the bookingCustomer who is booking the appointment.
  - `[CustomerId <String>]`: The ID of the bookingCustomer for this appointment. If no ID is specified when an appointment is created, then a new bookingCustomer object is created. Once set, you should consider the customerId immutable.
  - `[CustomerLocation <IMicrosoftGraphLocation>]`: location
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Address <IMicrosoftGraphPhysicalAddress>]`: physicalAddress
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[City <String>]`: The city.
      - `[CountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
      - `[PostOfficeBox <String>]`: The post office box number.
      - `[PostalCode <String>]`: The postal code.
      - `[State <String>]`: The state.
      - `[Street <String>]`: The street.
      - `[Type <String>]`: physicalAddressType
    - `[Coordinates <IMicrosoftGraphOutlookGeoCoordinates>]`: outlookGeoCoordinates
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Accuracy <Double?>]`: The accuracy of the latitude and longitude. As an example, the accuracy can be measured in meters, such as the latitude and longitude are accurate to within 50 meters.
      - `[Altitude <Double?>]`: The altitude of the location.
      - `[AltitudeAccuracy <Double?>]`: The accuracy of the altitude.
      - `[Latitude <Double?>]`: The latitude of the location.
      - `[Longitude <Double?>]`: The longitude of the location.
    - `[DisplayName <String>]`: The name associated with the location.
    - `[LocationEmailAddress <String>]`: Optional email address of the location.
    - `[LocationType <String>]`: locationType
    - `[LocationUri <String>]`: Optional URI representing the location.
    - `[UniqueId <String>]`: For internal use only.
    - `[UniqueIdType <String>]`: locationUniqueIdType
  - `[CustomerName <String>]`: The customer's name.
  - `[CustomerNotes <String>]`: Notes from the customer associated with this appointment. You can get the value only when reading this bookingAppointment by its ID.  You can set this property only when initially creating an appointment with a new customer. After that point, the value is computed from the customer represented by customerId.
  - `[CustomerPhone <String>]`: The customer's phone number.
  - `[CustomerTimeZone <String>]`: The time zone of the customer. For a list of possible values, see dateTimeTimeZone.
  - `[Customers <IMicrosoftGraphBookingCustomerInformationBase[]>]`: A collection of the customer properties for an appointment. An appointment will contain a list of customer information and each unit will indicate the properties of a customer who is part of that appointment. Optional.
  - `[End <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}). For example, '2019-04-16T09:00:00'.
    - `[TimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for possible values.
  - `[InvoiceAmount <Double?>]`: The billed amount on the invoice.
  - `[InvoiceDate <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
  - `[InvoiceId <String>]`: The ID of the invoice.
  - `[InvoiceStatus <String>]`: bookingInvoiceStatus
  - `[InvoiceUrl <String>]`: The URL of the invoice in Microsoft Bookings.
  - `[IsLocationOnline <Boolean?>]`: True indicates that the appointment will be held online. Default value is false.
  - `[JoinWebUrl <String>]`: The URL of the online meeting for the appointment.
  - `[LastUpdatedDateTime <DateTime?>]`: The date, time and timezone when the booking business was last updated.
  - `[MaximumAttendeesCount <Int32?>]`: The maximum number of customers allowed in an appointment. If maximumAttendeesCount of the service is greater than 1, pass valid customer IDs while creating or updating an appointment. To create a customer, use the Create bookingCustomer operation.
  - `[OnlineMeetingUrl <String>]`: 
  - `[OptOutOfCustomerEmail <Boolean?>]`: True indicates that the bookingCustomer for this appointment does not wish to receive a confirmation for this appointment.
  - `[PostBuffer <TimeSpan?>]`: The amount of time to reserve after the appointment ends, for cleaning up, as an example. The value is expressed in ISO8601 format.
  - `[PreBuffer <TimeSpan?>]`: The amount of time to reserve before the appointment begins, for preparation, as an example. The value is expressed in ISO8601 format.
  - `[Price <Double?>]`: The regular price for an appointment for the specified bookingService.
  - `[PriceType <BookingPriceType?>]`: Represents the type of pricing of a booking service.
  - `[Reminders <IMicrosoftGraphBookingReminder[]>]`: The collection of customer reminders sent for this appointment. The value of this property is available only when reading this bookingAppointment by its ID.
    - `[Message <String>]`: The message in the reminder.
    - `[Offset <TimeSpan?>]`: The amount of time before the start of an appointment that the reminder should be sent. It's denoted in ISO 8601 format.
    - `[Recipients <String>]`: bookingReminderRecipients
  - `[SelfServiceAppointmentId <String>]`: An additional tracking ID for the appointment, if the appointment has been created directly by the customer on the scheduling page, as opposed to by a staff member on the behalf of the customer.
  - `[ServiceId <String>]`: The ID of the bookingService associated with this appointment.
  - `[ServiceLocation <IMicrosoftGraphLocation>]`: location
  - `[ServiceName <String>]`: The name of the bookingService associated with this appointment.This property is optional when creating a new appointment. If not specified, it is computed from the service associated with the appointment by the serviceId property.
  - `[ServiceNotes <String>]`: Notes from a bookingStaffMember. The value of this property is available only when reading this bookingAppointment by its ID.
  - `[SmsNotificationsEnabled <Boolean?>]`: True indicates SMS notifications will be sent to the customers for the appointment. Default value is false.
  - `[StaffMemberIds <String[]>]`: The ID of each bookingStaffMember who is scheduled in this appointment.
  - `[Start <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone

`CUSTOMERLOCATION <IMicrosoftGraphLocation>`: location
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Address <IMicrosoftGraphPhysicalAddress>]`: physicalAddress
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[City <String>]`: The city.
    - `[CountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
    - `[PostOfficeBox <String>]`: The post office box number.
    - `[PostalCode <String>]`: The postal code.
    - `[State <String>]`: The state.
    - `[Street <String>]`: The street.
    - `[Type <String>]`: physicalAddressType
  - `[Coordinates <IMicrosoftGraphOutlookGeoCoordinates>]`: outlookGeoCoordinates
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Accuracy <Double?>]`: The accuracy of the latitude and longitude. As an example, the accuracy can be measured in meters, such as the latitude and longitude are accurate to within 50 meters.
    - `[Altitude <Double?>]`: The altitude of the location.
    - `[AltitudeAccuracy <Double?>]`: The accuracy of the altitude.
    - `[Latitude <Double?>]`: The latitude of the location.
    - `[Longitude <Double?>]`: The longitude of the location.
  - `[DisplayName <String>]`: The name associated with the location.
  - `[LocationEmailAddress <String>]`: Optional email address of the location.
  - `[LocationType <String>]`: locationType
  - `[LocationUri <String>]`: Optional URI representing the location.
  - `[UniqueId <String>]`: For internal use only.
  - `[UniqueIdType <String>]`: locationUniqueIdType

`END <IMicrosoftGraphDateTimeZone>`: dateTimeTimeZone
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}). For example, '2019-04-16T09:00:00'.
  - `[TimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for possible values.

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
  - `[JoinWebUrl <String>]`: Alternate key of virtualEventSession
  - `[MeetingAttendanceReportId <String>]`: The unique identifier of meetingAttendanceReport
  - `[PlannerPlanConfigurationLocalizationId <String>]`: The unique identifier of plannerPlanConfigurationLocalization
  - `[Role <String>]`: Usage: role='{role}'
  - `[UniqueName <String>]`: Alternate key of businessScenario
  - `[UserId <String>]`: Usage: userId='{userId}'
  - `[VirtualEventId <String>]`: The unique identifier of virtualEvent
  - `[VirtualEventPresenterId <String>]`: The unique identifier of virtualEventPresenter
  - `[VirtualEventRegistrationId <String>]`: The unique identifier of virtualEventRegistration
  - `[VirtualEventSessionId <String>]`: The unique identifier of virtualEventSession
  - `[VirtualEventTownhallId <String>]`: The unique identifier of virtualEventTownhall
  - `[VirtualEventWebinarId <String>]`: The unique identifier of virtualEventWebinar

`INVOICEDATE <IMicrosoftGraphDateTimeZone>`: dateTimeTimeZone
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}). For example, '2019-04-16T09:00:00'.
  - `[TimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for possible values.

`REMINDERS <IMicrosoftGraphBookingReminder[]>`: The collection of customer reminders sent for this appointment. The value of this property is available only when reading this bookingAppointment by its ID.
  - `[Message <String>]`: The message in the reminder.
  - `[Offset <TimeSpan?>]`: The amount of time before the start of an appointment that the reminder should be sent. It's denoted in ISO 8601 format.
  - `[Recipients <String>]`: bookingReminderRecipients

`SERVICELOCATION <IMicrosoftGraphLocation>`: location
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Address <IMicrosoftGraphPhysicalAddress>]`: physicalAddress
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[City <String>]`: The city.
    - `[CountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
    - `[PostOfficeBox <String>]`: The post office box number.
    - `[PostalCode <String>]`: The postal code.
    - `[State <String>]`: The state.
    - `[Street <String>]`: The street.
    - `[Type <String>]`: physicalAddressType
  - `[Coordinates <IMicrosoftGraphOutlookGeoCoordinates>]`: outlookGeoCoordinates
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Accuracy <Double?>]`: The accuracy of the latitude and longitude. As an example, the accuracy can be measured in meters, such as the latitude and longitude are accurate to within 50 meters.
    - `[Altitude <Double?>]`: The altitude of the location.
    - `[AltitudeAccuracy <Double?>]`: The accuracy of the altitude.
    - `[Latitude <Double?>]`: The latitude of the location.
    - `[Longitude <Double?>]`: The longitude of the location.
  - `[DisplayName <String>]`: The name associated with the location.
  - `[LocationEmailAddress <String>]`: Optional email address of the location.
  - `[LocationType <String>]`: locationType
  - `[LocationUri <String>]`: Optional URI representing the location.
  - `[UniqueId <String>]`: For internal use only.
  - `[UniqueIdType <String>]`: locationUniqueIdType

`START <IMicrosoftGraphDateTimeZone>`: dateTimeTimeZone
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}). For example, '2019-04-16T09:00:00'.
  - `[TimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for possible values.

## RELATED LINKS

