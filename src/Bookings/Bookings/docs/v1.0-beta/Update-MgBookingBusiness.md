---
external help file:
Module Name: Microsoft.Graph.Bookings
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.bookings/update-mgbookingbusiness
schema: 2.0.0
---

# Update-MgBookingBusiness

## SYNOPSIS
Represents a Microsot Bookings Business.

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
 [-WebSiteUrl <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
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
Update-MgBookingBusiness -InputObject <IBookingsIdentity> [-AdditionalProperties <Hashtable>]
 [-Address <IMicrosoftGraphPhysicalAddress>] [-Appointments <IMicrosoftGraphBookingAppointment[]>]
 [-BusinessHours <IMicrosoftGraphBookingWorkHours[]>] [-BusinessType <String>]
 [-CalendarView <IMicrosoftGraphBookingAppointment[]>] [-Customers <IMicrosoftGraphBookingCustomer[]>]
 [-DefaultCurrencyIso <String>] [-DisplayName <String>] [-Email <String>] [-Id <String>] [-IsPublished]
 [-Phone <String>] [-PublicUrl <String>] [-SchedulingPolicy <IMicrosoftGraphBookingSchedulingPolicy>]
 [-Services <IMicrosoftGraphBookingService[]>] [-StaffMembers <IMicrosoftGraphBookingStaffMember[]>]
 [-WebSiteUrl <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Represents a Microsot Bookings Business.

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

### -Address
physicalAddress
To construct, see NOTES section for ADDRESS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPhysicalAddress
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Appointments
All the appointments of this business.
Read-only.
Nullable.
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

### -BusinessHours
The hours of operation for the business.
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
The type of business.

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
The set of appointments of this business in a specified date range.
Read-only.
Nullable.
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
All the customers of this business.
Read-only.
Nullable.
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
The code for the currency that the business operates in on Microsoft Bookings.

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

### -Email
The email address for the business.

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
The scheduling page has been made available to external customers.
Use the publish and unpublish actions to set this property.
Read-only.

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
The telephone number for the business.
The phone property, together with address and webSiteUrl, appear in the footer of a business scheduling page.

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
The URL for the scheduling page, which is set after you publish or unpublish the page.
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

### -SchedulingPolicy
This type represents the set of policies that dictate how bookings can be created in a Booking Calendar.
To construct, see NOTES section for SCHEDULINGPOLICY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphBookingSchedulingPolicy
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Services
All the services offered by this business.
Read-only.
Nullable.
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
All the staff members that provide services in this business.
Read-only.
Nullable.
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
The webSiteUrl property, together with address, phone, appear in the footer of a business scheduling page.

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


ADDRESS <IMicrosoftGraphPhysicalAddress>: physicalAddress
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[City <String>]`: The city.
  - `[CountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
  - `[PostOfficeBox <String>]`: The post office box number.
  - `[PostalCode <String>]`: The postal code.
  - `[State <String>]`: The state.
  - `[Street <String>]`: The street.
  - `[Type <String>]`: physicalAddressType

APPOINTMENTS <IMicrosoftGraphBookingAppointment[]>: All the appointments of this business. Read-only. Nullable.
  - `[Id <String>]`: Read-only.
  - `[AdditionalInformation <String>]`: 
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
  - `[Duration <TimeSpan?>]`: The length of the appointment, denoted in ISO8601 format.
  - `[End <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}). For example, '2019-04-16T09:00:00'.
    - `[TimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for possible values.
  - `[InvoiceAmount <Double?>]`: The billed amount on the invoice.
  - `[InvoiceDate <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
  - `[InvoiceId <String>]`: The ID of the invoice.
  - `[InvoiceStatus <String>]`: bookingInvoiceStatus
  - `[InvoiceUrl <String>]`: The URL of the invoice in Microsoft Bookings.
  - `[IsLocationOnline <Boolean?>]`: 
  - `[OnlineMeetingUrl <String>]`: 
  - `[OptOutOfCustomerEmail <Boolean?>]`: True indicates that the bookingCustomer for this appointment does not wish to receive a confirmation for this appointment.
  - `[PostBuffer <TimeSpan?>]`: The amount of time to reserve after the appointment ends, for cleaning up, as an example. The value is expressed in ISO8601 format.
  - `[PreBuffer <TimeSpan?>]`: The amount of time to reserve before the appointment begins, for preparation, as an example. The value is expressed in ISO8601 format.
  - `[Price <Double?>]`: The regular price for an appointment for the specified bookingService.
  - `[PriceType <String>]`: bookingPriceType
  - `[Reminders <IMicrosoftGraphBookingReminder[]>]`: The collection of customer reminders sent for this appointment. The value of this property is available only when reading this bookingAppointment by its ID.
    - `[Message <String>]`: The message in the reminder.
    - `[Offset <TimeSpan?>]`: The amount of time before the start of an appointment that the reminder should be sent. It's denoted in ISO 8601 format.
    - `[Recipients <String>]`: bookingReminderRecipients
  - `[SelfServiceAppointmentId <String>]`: An additional tracking ID for the appointment, if the appointment has been created directly by the customer on the scheduling page, as opposed to by a staff member on the behalf of the customer.
  - `[ServiceId <String>]`: The ID of the bookingService associated with this appointment.
  - `[ServiceLocation <IMicrosoftGraphLocation>]`: location
  - `[ServiceName <String>]`: The name of the bookingService associated with this appointment.This property is optional when creating a new appointment. If not specified, it is computed from the service associated with the appointment by the serviceId property.
  - `[ServiceNotes <String>]`: Notes from a bookingStaffMember. The value of this property is available only when reading this bookingAppointment by its ID.
  - `[StaffMemberIds <String[]>]`: The ID of each bookingStaffMember who is scheduled in this appointment.
  - `[Start <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone

BODYPARAMETER <IMicrosoftGraphBookingBusiness>: Represents a Microsot Bookings Business.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DisplayName <String>]`: A name for the derived entity, which interfaces with customers.
  - `[Id <String>]`: Read-only.
  - `[Address <IMicrosoftGraphPhysicalAddress>]`: physicalAddress
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[City <String>]`: The city.
    - `[CountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
    - `[PostOfficeBox <String>]`: The post office box number.
    - `[PostalCode <String>]`: The postal code.
    - `[State <String>]`: The state.
    - `[Street <String>]`: The street.
    - `[Type <String>]`: physicalAddressType
  - `[Appointments <IMicrosoftGraphBookingAppointment[]>]`: All the appointments of this business. Read-only. Nullable.
    - `[Id <String>]`: Read-only.
    - `[AdditionalInformation <String>]`: 
    - `[CustomerEmailAddress <String>]`: The SMTP address of the bookingCustomer who is booking the appointment.
    - `[CustomerId <String>]`: The ID of the bookingCustomer for this appointment. If no ID is specified when an appointment is created, then a new bookingCustomer object is created. Once set, you should consider the customerId immutable.
    - `[CustomerLocation <IMicrosoftGraphLocation>]`: location
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Address <IMicrosoftGraphPhysicalAddress>]`: physicalAddress
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
    - `[Duration <TimeSpan?>]`: The length of the appointment, denoted in ISO8601 format.
    - `[End <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}). For example, '2019-04-16T09:00:00'.
      - `[TimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for possible values.
    - `[InvoiceAmount <Double?>]`: The billed amount on the invoice.
    - `[InvoiceDate <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
    - `[InvoiceId <String>]`: The ID of the invoice.
    - `[InvoiceStatus <String>]`: bookingInvoiceStatus
    - `[InvoiceUrl <String>]`: The URL of the invoice in Microsoft Bookings.
    - `[IsLocationOnline <Boolean?>]`: 
    - `[OnlineMeetingUrl <String>]`: 
    - `[OptOutOfCustomerEmail <Boolean?>]`: True indicates that the bookingCustomer for this appointment does not wish to receive a confirmation for this appointment.
    - `[PostBuffer <TimeSpan?>]`: The amount of time to reserve after the appointment ends, for cleaning up, as an example. The value is expressed in ISO8601 format.
    - `[PreBuffer <TimeSpan?>]`: The amount of time to reserve before the appointment begins, for preparation, as an example. The value is expressed in ISO8601 format.
    - `[Price <Double?>]`: The regular price for an appointment for the specified bookingService.
    - `[PriceType <String>]`: bookingPriceType
    - `[Reminders <IMicrosoftGraphBookingReminder[]>]`: The collection of customer reminders sent for this appointment. The value of this property is available only when reading this bookingAppointment by its ID.
      - `[Message <String>]`: The message in the reminder.
      - `[Offset <TimeSpan?>]`: The amount of time before the start of an appointment that the reminder should be sent. It's denoted in ISO 8601 format.
      - `[Recipients <String>]`: bookingReminderRecipients
    - `[SelfServiceAppointmentId <String>]`: An additional tracking ID for the appointment, if the appointment has been created directly by the customer on the scheduling page, as opposed to by a staff member on the behalf of the customer.
    - `[ServiceId <String>]`: The ID of the bookingService associated with this appointment.
    - `[ServiceLocation <IMicrosoftGraphLocation>]`: location
    - `[ServiceName <String>]`: The name of the bookingService associated with this appointment.This property is optional when creating a new appointment. If not specified, it is computed from the service associated with the appointment by the serviceId property.
    - `[ServiceNotes <String>]`: Notes from a bookingStaffMember. The value of this property is available only when reading this bookingAppointment by its ID.
    - `[StaffMemberIds <String[]>]`: The ID of each bookingStaffMember who is scheduled in this appointment.
    - `[Start <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
  - `[BusinessHours <IMicrosoftGraphBookingWorkHours[]>]`: The hours of operation for the business.
    - `[Day <String>]`: dayOfWeek
    - `[TimeSlots <IMicrosoftGraphBookingWorkTimeSlot[]>]`: A list of start/end times during a day.
      - `[End <String>]`: The time of the day that work starts. For example, 08:00:00.0000000.
      - `[Start <String>]`: The time of the day that work stops. For example, 17:00:00.0000000.
  - `[BusinessType <String>]`: The type of business.
  - `[CalendarView <IMicrosoftGraphBookingAppointment[]>]`: The set of appointments of this business in a specified date range. Read-only. Nullable.
  - `[Customers <IMicrosoftGraphBookingCustomer[]>]`: All the customers of this business. Read-only. Nullable.
    - `[EmailAddress <String>]`: The email address of the person.
    - `[DisplayName <String>]`: A name for the derived entity, which interfaces with customers.
    - `[Id <String>]`: Read-only.
  - `[DefaultCurrencyIso <String>]`: The code for the currency that the business operates in on Microsoft Bookings.
  - `[Email <String>]`: The email address for the business.
  - `[IsPublished <Boolean?>]`: The scheduling page has been made available to external customers. Use the publish and unpublish actions to set this property. Read-only.
  - `[Phone <String>]`: The telephone number for the business. The phone property, together with address and webSiteUrl, appear in the footer of a business scheduling page.
  - `[PublicUrl <String>]`: The URL for the scheduling page, which is set after you publish or unpublish the page. Read-only.
  - `[SchedulingPolicy <IMicrosoftGraphBookingSchedulingPolicy>]`: This type represents the set of policies that dictate how bookings can be created in a Booking Calendar.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AllowStaffSelection <Boolean?>]`: True if to allow customers to choose a specific person for the booking.
    - `[MaximumAdvance <TimeSpan?>]`: Maximum number of days in advance that a booking can be made. It follows the ISO 8601 format.
    - `[MinimumLeadTime <TimeSpan?>]`: The minimum amount of time before which bookings and cancellations must be made. It follows the ISO 8601 format.
    - `[SendConfirmationsToOwner <Boolean?>]`: True to notify the business via email when a booking is created or changed. Use the email address specified in the email property of the bookingBusiness entity for the business.
    - `[TimeSlotInterval <TimeSpan?>]`: Duration of each time slot, denoted in ISO 8601 format.
  - `[Services <IMicrosoftGraphBookingService[]>]`: All the services offered by this business. Read-only. Nullable.
    - `[DisplayName <String>]`: A name for the derived entity, which interfaces with customers.
    - `[Id <String>]`: Read-only.
    - `[AdditionalInformation <String>]`: 
    - `[DefaultDuration <TimeSpan?>]`: The default length of the service, represented in numbers of days, hours, minutes, and seconds. For example, P11D23H59M59.999999999999S.
    - `[DefaultLocation <IMicrosoftGraphLocation>]`: location
    - `[DefaultPrice <Double?>]`: The default monetary price for the service.
    - `[DefaultPriceType <String>]`: bookingPriceType
    - `[DefaultReminders <IMicrosoftGraphBookingReminder[]>]`: The default set of reminders for an appointment of this service. The value of this property is available only when reading this bookingService by its ID.
    - `[Description <String>]`: A text description for the service.
    - `[IsHiddenFromCustomers <Boolean?>]`: True means this service is not available to customers for booking.
    - `[IsLocationOnline <Boolean?>]`: 
    - `[Notes <String>]`: Additional information about this service.
    - `[PostBuffer <TimeSpan?>]`: The time to buffer after an appointment for this service ends, and before the next customer appointment can be booked.
    - `[PreBuffer <TimeSpan?>]`: The time to buffer before an appointment for this service can start.
    - `[SchedulingPolicy <IMicrosoftGraphBookingSchedulingPolicy>]`: This type represents the set of policies that dictate how bookings can be created in a Booking Calendar.
    - `[StaffMemberIds <String[]>]`: Represents those staff members who provide this service.
  - `[StaffMembers <IMicrosoftGraphBookingStaffMember[]>]`: All the staff members that provide services in this business. Read-only. Nullable.
    - `[EmailAddress <String>]`: The email address of the person.
    - `[DisplayName <String>]`: A name for the derived entity, which interfaces with customers.
    - `[Id <String>]`: Read-only.
    - `[AvailabilityIsAffectedByPersonalCalendar <Boolean?>]`: True means that if the staff member is a Microsoft 365 user, the Bookings API would verify the staff member's availability in their personal calendar in Microsoft 365, before making a booking.
    - `[ColorIndex <Int32?>]`: Identifies a color to represent the staff member. The color corresponds to the color palette in the Staff details page in the Bookings app.
    - `[Role <String>]`: bookingStaffRole
    - `[UseBusinessHours <Boolean?>]`: True means the staff member's availability is as specified in the businessHours property of the business. False means the availability is determined by the staff member's workingHours property setting.
    - `[WorkingHours <IMicrosoftGraphBookingWorkHours[]>]`: The range of hours each day of the week that the staff member is available for booking. By default, they are initialized to be the same as the businessHours property of the business.
  - `[WebSiteUrl <String>]`: The URL of the business web site. The webSiteUrl property, together with address, phone, appear in the footer of a business scheduling page.

BUSINESSHOURS <IMicrosoftGraphBookingWorkHours[]>: The hours of operation for the business.
  - `[Day <String>]`: dayOfWeek
  - `[TimeSlots <IMicrosoftGraphBookingWorkTimeSlot[]>]`: A list of start/end times during a day.
    - `[End <String>]`: The time of the day that work starts. For example, 08:00:00.0000000.
    - `[Start <String>]`: The time of the day that work stops. For example, 17:00:00.0000000.

CALENDARVIEW <IMicrosoftGraphBookingAppointment[]>: The set of appointments of this business in a specified date range. Read-only. Nullable.
  - `[Id <String>]`: Read-only.
  - `[AdditionalInformation <String>]`: 
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
  - `[Duration <TimeSpan?>]`: The length of the appointment, denoted in ISO8601 format.
  - `[End <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}). For example, '2019-04-16T09:00:00'.
    - `[TimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for possible values.
  - `[InvoiceAmount <Double?>]`: The billed amount on the invoice.
  - `[InvoiceDate <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
  - `[InvoiceId <String>]`: The ID of the invoice.
  - `[InvoiceStatus <String>]`: bookingInvoiceStatus
  - `[InvoiceUrl <String>]`: The URL of the invoice in Microsoft Bookings.
  - `[IsLocationOnline <Boolean?>]`: 
  - `[OnlineMeetingUrl <String>]`: 
  - `[OptOutOfCustomerEmail <Boolean?>]`: True indicates that the bookingCustomer for this appointment does not wish to receive a confirmation for this appointment.
  - `[PostBuffer <TimeSpan?>]`: The amount of time to reserve after the appointment ends, for cleaning up, as an example. The value is expressed in ISO8601 format.
  - `[PreBuffer <TimeSpan?>]`: The amount of time to reserve before the appointment begins, for preparation, as an example. The value is expressed in ISO8601 format.
  - `[Price <Double?>]`: The regular price for an appointment for the specified bookingService.
  - `[PriceType <String>]`: bookingPriceType
  - `[Reminders <IMicrosoftGraphBookingReminder[]>]`: The collection of customer reminders sent for this appointment. The value of this property is available only when reading this bookingAppointment by its ID.
    - `[Message <String>]`: The message in the reminder.
    - `[Offset <TimeSpan?>]`: The amount of time before the start of an appointment that the reminder should be sent. It's denoted in ISO 8601 format.
    - `[Recipients <String>]`: bookingReminderRecipients
  - `[SelfServiceAppointmentId <String>]`: An additional tracking ID for the appointment, if the appointment has been created directly by the customer on the scheduling page, as opposed to by a staff member on the behalf of the customer.
  - `[ServiceId <String>]`: The ID of the bookingService associated with this appointment.
  - `[ServiceLocation <IMicrosoftGraphLocation>]`: location
  - `[ServiceName <String>]`: The name of the bookingService associated with this appointment.This property is optional when creating a new appointment. If not specified, it is computed from the service associated with the appointment by the serviceId property.
  - `[ServiceNotes <String>]`: Notes from a bookingStaffMember. The value of this property is available only when reading this bookingAppointment by its ID.
  - `[StaffMemberIds <String[]>]`: The ID of each bookingStaffMember who is scheduled in this appointment.
  - `[Start <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone

CUSTOMERS <IMicrosoftGraphBookingCustomer[]>: All the customers of this business. Read-only. Nullable.
  - `[EmailAddress <String>]`: The email address of the person.
  - `[DisplayName <String>]`: A name for the derived entity, which interfaces with customers.
  - `[Id <String>]`: Read-only.

INPUTOBJECT <IBookingsIdentity>: Identity Parameter
  - `[BookingAppointmentId <String>]`: key: id of bookingAppointment
  - `[BookingBusinessId <String>]`: key: id of bookingBusiness
  - `[BookingCurrencyId <String>]`: key: id of bookingCurrency
  - `[BookingCustomerId <String>]`: key: id of bookingCustomer
  - `[BookingServiceId <String>]`: key: id of bookingService
  - `[BookingStaffMemberId <String>]`: key: id of bookingStaffMember

SCHEDULINGPOLICY <IMicrosoftGraphBookingSchedulingPolicy>: This type represents the set of policies that dictate how bookings can be created in a Booking Calendar.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AllowStaffSelection <Boolean?>]`: True if to allow customers to choose a specific person for the booking.
  - `[MaximumAdvance <TimeSpan?>]`: Maximum number of days in advance that a booking can be made. It follows the ISO 8601 format.
  - `[MinimumLeadTime <TimeSpan?>]`: The minimum amount of time before which bookings and cancellations must be made. It follows the ISO 8601 format.
  - `[SendConfirmationsToOwner <Boolean?>]`: True to notify the business via email when a booking is created or changed. Use the email address specified in the email property of the bookingBusiness entity for the business.
  - `[TimeSlotInterval <TimeSpan?>]`: Duration of each time slot, denoted in ISO 8601 format.

SERVICES <IMicrosoftGraphBookingService[]>: All the services offered by this business. Read-only. Nullable.
  - `[DisplayName <String>]`: A name for the derived entity, which interfaces with customers.
  - `[Id <String>]`: Read-only.
  - `[AdditionalInformation <String>]`: 
  - `[DefaultDuration <TimeSpan?>]`: The default length of the service, represented in numbers of days, hours, minutes, and seconds. For example, P11D23H59M59.999999999999S.
  - `[DefaultLocation <IMicrosoftGraphLocation>]`: location
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
  - `[DefaultPrice <Double?>]`: The default monetary price for the service.
  - `[DefaultPriceType <String>]`: bookingPriceType
  - `[DefaultReminders <IMicrosoftGraphBookingReminder[]>]`: The default set of reminders for an appointment of this service. The value of this property is available only when reading this bookingService by its ID.
    - `[Message <String>]`: The message in the reminder.
    - `[Offset <TimeSpan?>]`: The amount of time before the start of an appointment that the reminder should be sent. It's denoted in ISO 8601 format.
    - `[Recipients <String>]`: bookingReminderRecipients
  - `[Description <String>]`: A text description for the service.
  - `[IsHiddenFromCustomers <Boolean?>]`: True means this service is not available to customers for booking.
  - `[IsLocationOnline <Boolean?>]`: 
  - `[Notes <String>]`: Additional information about this service.
  - `[PostBuffer <TimeSpan?>]`: The time to buffer after an appointment for this service ends, and before the next customer appointment can be booked.
  - `[PreBuffer <TimeSpan?>]`: The time to buffer before an appointment for this service can start.
  - `[SchedulingPolicy <IMicrosoftGraphBookingSchedulingPolicy>]`: This type represents the set of policies that dictate how bookings can be created in a Booking Calendar.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AllowStaffSelection <Boolean?>]`: True if to allow customers to choose a specific person for the booking.
    - `[MaximumAdvance <TimeSpan?>]`: Maximum number of days in advance that a booking can be made. It follows the ISO 8601 format.
    - `[MinimumLeadTime <TimeSpan?>]`: The minimum amount of time before which bookings and cancellations must be made. It follows the ISO 8601 format.
    - `[SendConfirmationsToOwner <Boolean?>]`: True to notify the business via email when a booking is created or changed. Use the email address specified in the email property of the bookingBusiness entity for the business.
    - `[TimeSlotInterval <TimeSpan?>]`: Duration of each time slot, denoted in ISO 8601 format.
  - `[StaffMemberIds <String[]>]`: Represents those staff members who provide this service.

STAFFMEMBERS <IMicrosoftGraphBookingStaffMember[]>: All the staff members that provide services in this business. Read-only. Nullable.
  - `[EmailAddress <String>]`: The email address of the person.
  - `[DisplayName <String>]`: A name for the derived entity, which interfaces with customers.
  - `[Id <String>]`: Read-only.
  - `[AvailabilityIsAffectedByPersonalCalendar <Boolean?>]`: True means that if the staff member is a Microsoft 365 user, the Bookings API would verify the staff member's availability in their personal calendar in Microsoft 365, before making a booking.
  - `[ColorIndex <Int32?>]`: Identifies a color to represent the staff member. The color corresponds to the color palette in the Staff details page in the Bookings app.
  - `[Role <String>]`: bookingStaffRole
  - `[UseBusinessHours <Boolean?>]`: True means the staff member's availability is as specified in the businessHours property of the business. False means the availability is determined by the staff member's workingHours property setting.
  - `[WorkingHours <IMicrosoftGraphBookingWorkHours[]>]`: The range of hours each day of the week that the staff member is available for booking. By default, they are initialized to be the same as the businessHours property of the business.
    - `[Day <String>]`: dayOfWeek
    - `[TimeSlots <IMicrosoftGraphBookingWorkTimeSlot[]>]`: A list of start/end times during a day.
      - `[End <String>]`: The time of the day that work starts. For example, 08:00:00.0000000.
      - `[Start <String>]`: The time of the day that work stops. For example, 17:00:00.0000000.

## RELATED LINKS

