---
external help file:
Module Name: Microsoft.Graph.Beta.Bookings
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.bookings/update-mgbetabookingbusiness
schema: 2.0.0
---

# Update-MgBetaBookingBusiness

## SYNOPSIS
Update entity in bookingBusinesses

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaBookingBusiness -BookingBusinessId <String> [-AdditionalProperties <Hashtable>]
 [-Address <IMicrosoftGraphPhysicalAddress>] [-Appointments <IMicrosoftGraphBookingAppointment[]>]
 [-BookingPageSettings <IMicrosoftGraphBookingPageSettings>]
 [-BusinessHours <IMicrosoftGraphBookingWorkHours[]>] [-BusinessType <String>]
 [-CalendarView <IMicrosoftGraphBookingAppointment[]>] [-CreatedDateTime <DateTime>]
 [-Customers <IMicrosoftGraphBookingCustomer[]>] [-CustomQuestions <IMicrosoftGraphBookingCustomQuestion[]>]
 [-DefaultCurrencyIso <String>] [-DisplayName <String>] [-Email <String>] [-Id <String>]
 [-LanguageTag <String>] [-LastUpdatedDateTime <DateTime>] [-Phone <String>]
 [-ResponseHeadersVariable <String>] [-SchedulingPolicy <IMicrosoftGraphBookingSchedulingPolicy>]
 [-Services <IMicrosoftGraphBookingService[]>] [-StaffMembers <IMicrosoftGraphBookingStaffMember[]>]
 [-WebSiteUrl <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaBookingBusiness -BookingBusinessId <String> -BodyParameter <IMicrosoftGraphBookingBusiness>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update1
```
Update-MgBetaBookingBusiness -BookingBusinessId <String> -BodyParameter <IMicrosoftGraphBookingBusiness>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateExpanded1
```
Update-MgBetaBookingBusiness -BookingBusinessId <String> [-AdditionalProperties <Hashtable>]
 [-Address <IMicrosoftGraphPhysicalAddress>] [-Appointments <IMicrosoftGraphBookingAppointment[]>]
 [-BookingPageSettings <IMicrosoftGraphBookingPageSettings>]
 [-BusinessHours <IMicrosoftGraphBookingWorkHours[]>] [-BusinessType <String>]
 [-CalendarView <IMicrosoftGraphBookingAppointment[]>] [-CreatedDateTime <DateTime>]
 [-Customers <IMicrosoftGraphBookingCustomer[]>] [-CustomQuestions <IMicrosoftGraphBookingCustomQuestion[]>]
 [-DefaultCurrencyIso <String>] [-DisplayName <String>] [-Email <String>] [-Id <String>]
 [-LanguageTag <String>] [-LastUpdatedDateTime <DateTime>] [-Phone <String>]
 [-ResponseHeadersVariable <String>] [-SchedulingPolicy <IMicrosoftGraphBookingSchedulingPolicy>]
 [-Services <IMicrosoftGraphBookingService[]>] [-StaffMembers <IMicrosoftGraphBookingStaffMember[]>]
 [-WebSiteUrl <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBetaBookingBusiness -InputObject <IBookingsIdentity> -BodyParameter <IMicrosoftGraphBookingBusiness>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity1
```
Update-MgBetaBookingBusiness -InputObject <IBookingsIdentity> -BodyParameter <IMicrosoftGraphBookingBusiness>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBetaBookingBusiness -InputObject <IBookingsIdentity> [-AdditionalProperties <Hashtable>]
 [-Address <IMicrosoftGraphPhysicalAddress>] [-Appointments <IMicrosoftGraphBookingAppointment[]>]
 [-BookingPageSettings <IMicrosoftGraphBookingPageSettings>]
 [-BusinessHours <IMicrosoftGraphBookingWorkHours[]>] [-BusinessType <String>]
 [-CalendarView <IMicrosoftGraphBookingAppointment[]>] [-CreatedDateTime <DateTime>]
 [-Customers <IMicrosoftGraphBookingCustomer[]>] [-CustomQuestions <IMicrosoftGraphBookingCustomQuestion[]>]
 [-DefaultCurrencyIso <String>] [-DisplayName <String>] [-Email <String>] [-Id <String>]
 [-LanguageTag <String>] [-LastUpdatedDateTime <DateTime>] [-Phone <String>]
 [-ResponseHeadersVariable <String>] [-SchedulingPolicy <IMicrosoftGraphBookingSchedulingPolicy>]
 [-Services <IMicrosoftGraphBookingService[]>] [-StaffMembers <IMicrosoftGraphBookingStaffMember[]>]
 [-WebSiteUrl <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded1
```
Update-MgBetaBookingBusiness -InputObject <IBookingsIdentity> [-AdditionalProperties <Hashtable>]
 [-Address <IMicrosoftGraphPhysicalAddress>] [-Appointments <IMicrosoftGraphBookingAppointment[]>]
 [-BookingPageSettings <IMicrosoftGraphBookingPageSettings>]
 [-BusinessHours <IMicrosoftGraphBookingWorkHours[]>] [-BusinessType <String>]
 [-CalendarView <IMicrosoftGraphBookingAppointment[]>] [-CreatedDateTime <DateTime>]
 [-Customers <IMicrosoftGraphBookingCustomer[]>] [-CustomQuestions <IMicrosoftGraphBookingCustomQuestion[]>]
 [-DefaultCurrencyIso <String>] [-DisplayName <String>] [-Email <String>] [-Id <String>]
 [-LanguageTag <String>] [-LastUpdatedDateTime <DateTime>] [-Phone <String>]
 [-ResponseHeadersVariable <String>] [-SchedulingPolicy <IMicrosoftGraphBookingSchedulingPolicy>]
 [-Services <IMicrosoftGraphBookingService[]>] [-StaffMembers <IMicrosoftGraphBookingStaffMember[]>]
 [-WebSiteUrl <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update entity in bookingBusinesses

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.Bookings
$params = @{
	Email = "admin@fabrikam.com"
	SchedulingPolicy = @{
		TimeSlotInterval = "PT60M"
		MinimumLeadTime = "P1D"
		MaximumAdvance = "P30D"
		SendConfirmationsToOwner = $true
		AllowStaffSelection = $true
	}
}
Update-MgBetaBookingBusiness -BookingBusinessId $bookingBusinessId -BodyParameter $params
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

### -Address
physicalAddress
To construct, see NOTES section for ADDRESS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPhysicalAddress
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphBookingAppointment[]
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
Represents a Microsoft Bookings Business.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphBookingBusiness
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

### -BookingPageSettings
bookingPageSettings
To construct, see NOTES section for BOOKINGPAGESETTINGS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphBookingPageSettings
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BusinessHours
The hours of operation for the business.
To construct, see NOTES section for BUSINESSHOURS properties and create a hash table.

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

### -BusinessType
The type of business.

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

### -CalendarView
The set of appointments of this business in a specified date range.
Read-only.
Nullable.
To construct, see NOTES section for CALENDARVIEW properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphBookingAppointment[]
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedDateTime
The date, time and timezone when the booking business was created.

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

### -Customers
All the customers of this business.
Read-only.
Nullable.
To construct, see NOTES section for CUSTOMERS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphBookingCustomer[]
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CustomQuestions
All custom questions of this business.
To construct, see NOTES section for CUSTOMQUESTIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphBookingCustomQuestion[]
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
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

### -Email
The email address for the business.

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

### -LanguageTag
The language of the self service booking page

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

### -Phone
The telephone number for the business.
The phone property, together with address and webSiteUrl, appear in the footer of a business scheduling page.

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

### -SchedulingPolicy
This type represents the set of policies that dictate how bookings can be created in a Booking Calendar.
To construct, see NOTES section for SCHEDULINGPOLICY properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphBookingSchedulingPolicy
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphBookingService[]
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphBookingStaffMember[]
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphBookingBusiness

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphBookingBusiness

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`ADDRESS <IMicrosoftGraphPhysicalAddress>`: physicalAddress
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[City <String>]`: The city.
  - `[CountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
  - `[PostOfficeBox <String>]`: The post office box number.
  - `[PostalCode <String>]`: The postal code.
  - `[State <String>]`: The state.
  - `[Street <String>]`: The street.
  - `[Type <String>]`: physicalAddressType

`APPOINTMENTS <IMicrosoftGraphBookingAppointment[]>`: All the appointments of this business. Read-only. Nullable.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AdditionalInformation <String>]`: Additional information that is sent to the customer when an appointment is confirmed.
  - `[AnonymousJoinWebUrl <String>]`: The URL of the meeting to join anonymously.
  - `[AppointmentLabel <String>]`: The user can stamp a custom label on the appointment.
  - `[CreatedDateTime <DateTime?>]`: The date, time, and timezone when the appointment was created.
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
  - `[IsCustomerAllowedToManageBooking <Boolean?>]`: Indicates that the customer can manage bookings created by the staff. The default value is false.
  - `[IsLocationOnline <Boolean?>]`: Indicates that the appointment is held online. The default value is false.
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
  - `[SelfServiceAppointmentId <String>]`: Another tracking ID for the appointment, if the appointment was created directly by the customer on the scheduling page, as opposed to by a staff member on behalf of customer.
  - `[ServiceId <String>]`: The ID of the bookingService associated with this appointment.
  - `[ServiceLocation <IMicrosoftGraphLocation>]`: location
  - `[ServiceName <String>]`: The name of the bookingService associated with this appointment.This property is optional when creating a new appointment. If not specified, it is computed from the service associated with the appointment by the serviceId property.
  - `[ServiceNotes <String>]`: Notes from a bookingStaffMember. The value of this property is available only when reading this bookingAppointment by its ID.
  - `[SmsNotificationsEnabled <Boolean?>]`: True indicates SMS notifications will be sent to the customers for the appointment. Default value is false.
  - `[StaffMemberIds <String[]>]`: The ID of each bookingStaffMember who is scheduled in this appointment.
  - `[Start <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone

`BODYPARAMETER <IMicrosoftGraphBookingBusiness>`: Represents a Microsoft Bookings Business.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DisplayName <String>]`: A name for the derived entity, which interfaces with customers.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
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
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[AdditionalInformation <String>]`: Additional information that is sent to the customer when an appointment is confirmed.
    - `[AnonymousJoinWebUrl <String>]`: The URL of the meeting to join anonymously.
    - `[AppointmentLabel <String>]`: The user can stamp a custom label on the appointment.
    - `[CreatedDateTime <DateTime?>]`: The date, time, and timezone when the appointment was created.
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
    - `[IsCustomerAllowedToManageBooking <Boolean?>]`: Indicates that the customer can manage bookings created by the staff. The default value is false.
    - `[IsLocationOnline <Boolean?>]`: Indicates that the appointment is held online. The default value is false.
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
    - `[SelfServiceAppointmentId <String>]`: Another tracking ID for the appointment, if the appointment was created directly by the customer on the scheduling page, as opposed to by a staff member on behalf of customer.
    - `[ServiceId <String>]`: The ID of the bookingService associated with this appointment.
    - `[ServiceLocation <IMicrosoftGraphLocation>]`: location
    - `[ServiceName <String>]`: The name of the bookingService associated with this appointment.This property is optional when creating a new appointment. If not specified, it is computed from the service associated with the appointment by the serviceId property.
    - `[ServiceNotes <String>]`: Notes from a bookingStaffMember. The value of this property is available only when reading this bookingAppointment by its ID.
    - `[SmsNotificationsEnabled <Boolean?>]`: True indicates SMS notifications will be sent to the customers for the appointment. Default value is false.
    - `[StaffMemberIds <String[]>]`: The ID of each bookingStaffMember who is scheduled in this appointment.
    - `[Start <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
  - `[BookingPageSettings <IMicrosoftGraphBookingPageSettings>]`: bookingPageSettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AccessControl <String>]`: bookingPageAccessControl
    - `[BookingPageColorCode <String>]`: Custom color for the bookings page. The value should be in Hex format. Example: #123456.
    - `[BusinessTimeZone <String>]`: The time zone of the customer. For a list of possible values, see dateTimeTimeZone.
    - `[CustomerConsentMessage <String>]`: The personal data collection and usage consent message in the bookings page.
    - `[EnforceOneTimePassword <Boolean?>]`: Determines if the one-time password is required to create an appointment. The default value is false.
    - `[IsBusinessLogoDisplayEnabled <Boolean?>]`: Indicates if the business logo is displayed on the bookings page. The default value is false.
    - `[IsCustomerConsentEnabled <Boolean?>]`: Enables personal data collection and the usage consent toggle on the bookings page. The default value is false.
    - `[IsSearchEngineIndexabilityDisabled <Boolean?>]`: Ensures that the web crawlers don't index this page. The defaults value is false.
    - `[IsTimeSlotTimeZoneSetToBusinessTimeZone <Boolean?>]`: Displays the booking time slots in the business time zone. The default value is false.
    - `[PrivacyPolicyWebUrl <String>]`: RL of a webpage that provides the terms and conditions of the business. If a privacy policy isn't included, the following text appears on the bookings page as default: 'The policies and practices of <booking business's name> apply to the use of your data.
    - `[TermsAndConditionsWebUrl <String>]`: URL of a webpage that provides the terms and conditions of the business.
  - `[BusinessHours <IMicrosoftGraphBookingWorkHours[]>]`: The hours of operation for the business.
    - `[Day <String>]`: dayOfWeek
    - `[TimeSlots <IMicrosoftGraphBookingWorkTimeSlot[]>]`: A list of start/end times during a day.
      - `[End <String>]`: The time of the day when work stops. For example, 17:00:00.0000000.
      - `[Start <String>]`: The time of the day when work starts. For example, 08:00:00.0000000.
  - `[BusinessType <String>]`: The type of business.
  - `[CalendarView <IMicrosoftGraphBookingAppointment[]>]`: The set of appointments of this business in a specified date range. Read-only. Nullable.
  - `[CreatedDateTime <DateTime?>]`: The date, time and timezone when the booking business was created.
  - `[CustomQuestions <IMicrosoftGraphBookingCustomQuestion[]>]`: All custom questions of this business.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[AnswerInputType <String>]`: answerInputType
    - `[AnswerOptions <String[]>]`: List of possible answer values.
    - `[CreatedDateTime <DateTime?>]`: The date, time and timezone when the custom question was created.
    - `[DisplayName <String>]`: Display name of this entity.
    - `[LastUpdatedDateTime <DateTime?>]`: The date, time and timezone when the custom question was last updated.
  - `[Customers <IMicrosoftGraphBookingCustomer[]>]`: All the customers of this business. Read-only. Nullable.
    - `[EmailAddress <String>]`: The email address of the person.
    - `[DisplayName <String>]`: A name for the derived entity, which interfaces with customers.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Addresses <IMicrosoftGraphPhysicalAddress[]>]`: Addresses associated with the customer, including home, business and other addresses.
    - `[CreatedDateTime <DateTime?>]`: The date, time and timezone when the customer was created.
    - `[LastUpdatedDateTime <DateTime?>]`: The date, time and timezone when the customer was last updated.
    - `[Phones <IMicrosoftGraphPhone[]>]`: Phone numbers associated with the customer, including home, business and mobile numbers.
      - `[Number <String>]`: The phone number.
      - `[Type <String>]`: phoneType
  - `[DefaultCurrencyIso <String>]`: The code for the currency that the business operates in on Microsoft Bookings.
  - `[Email <String>]`: The email address for the business.
  - `[LanguageTag <String>]`: The language of the self service booking page
  - `[LastUpdatedDateTime <DateTime?>]`: The date, time and timezone when the booking business was last updated.
  - `[Phone <String>]`: The telephone number for the business. The phone property, together with address and webSiteUrl, appear in the footer of a business scheduling page.
  - `[SchedulingPolicy <IMicrosoftGraphBookingSchedulingPolicy>]`: This type represents the set of policies that dictate how bookings can be created in a Booking Calendar.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AllowStaffSelection <Boolean?>]`: True if to allow customers to choose a specific person for the booking.
    - `[CustomAvailabilities <IMicrosoftGraphBookingsAvailabilityWindow[]>]`: Custom availability of the service in a given time frame of the service.
      - `[AvailabilityType <String>]`: bookingsServiceAvailabilityType
      - `[BusinessHours <IMicrosoftGraphBookingWorkHours[]>]`: The hours of operation in a week. The business hours value is set to null if the availability type isn't customWeeklyHours.
      - `[EndDate <DateTime?>]`: End date of the availability window.
      - `[StartDate <DateTime?>]`: Start date of the availability window.
    - `[GeneralAvailability <IMicrosoftGraphBookingsAvailability>]`: bookingsAvailability
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AvailabilityType <String>]`: bookingsServiceAvailabilityType
      - `[BusinessHours <IMicrosoftGraphBookingWorkHours[]>]`: The hours of operation in a week. The business hours value is set to null if the availability type isn't customWeeklyHours.
    - `[IsMeetingInviteToCustomersEnabled <Boolean?>]`: Indicates if the meeting invite is sent to the customers. The default value is false
    - `[MaximumAdvance <TimeSpan?>]`: Maximum number of days in advance that a booking can be made. It follows the ISO 8601 format.
    - `[MinimumLeadTime <TimeSpan?>]`: The minimum amount of time before which bookings and cancellations must be made. It follows the ISO 8601 format.
    - `[SendConfirmationsToOwner <Boolean?>]`: True to notify the business via email when a booking is created or changed. Use the email address specified in the email property of the bookingBusiness entity for the business.
    - `[TimeSlotInterval <TimeSpan?>]`: Duration of each time slot, denoted in ISO 8601 format.
  - `[Services <IMicrosoftGraphBookingService[]>]`: All the services offered by this business. Read-only. Nullable.
    - `[DisplayName <String>]`: A name for the derived entity, which interfaces with customers.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[AdditionalInformation <String>]`: Additional information that is sent to the customer when an appointment is confirmed.
    - `[CreatedDateTime <DateTime?>]`: The date, time and timezone when the Service was created.
    - `[CustomQuestions <IMicrosoftGraphBookingQuestionAssignment[]>]`: Contains the set of custom questions associated with a particular service.
      - `[IsRequired <Boolean?>]`: Indicates whether it's mandatory to answer the custom question.
      - `[QuestionId <String>]`: If it's mandatory to answer the custom question.
    - `[DefaultDuration <TimeSpan?>]`: The default length of the service, represented in numbers of days, hours, minutes, and seconds. For example, P11D23H59M59.999999999999S.
    - `[DefaultLocation <IMicrosoftGraphLocation>]`: location
    - `[DefaultPrice <Double?>]`: The default monetary price for the service.
    - `[DefaultPriceType <BookingPriceType?>]`: Represents the type of pricing of a booking service.
    - `[DefaultReminders <IMicrosoftGraphBookingReminder[]>]`: The default set of reminders for an appointment of this service. The value of this property is available only when reading this bookingService by its ID.
    - `[Description <String>]`: A text description for the service.
    - `[IsAnonymousJoinEnabled <Boolean?>]`: Indicates if an anonymousJoinWebUrl(webrtcUrl) is generated for the appointment booked for this service. The default value is false.
    - `[IsCustomerAllowedToManageBooking <Boolean?>]`: Indicates that the customer can manage bookings created by the staff. The default value is false.
    - `[IsHiddenFromCustomers <Boolean?>]`: True means this service isn't available to customers for booking.
    - `[IsLocationOnline <Boolean?>]`: Indicates that the appointments for the service are held online. The default value is false.
    - `[LanguageTag <String>]`: The language of the self service booking page.
    - `[LastUpdatedDateTime <DateTime?>]`: The date, time and timezone when the Service  was last updated.
    - `[MaximumAttendeesCount <Int32?>]`: The maximum number of customers allowed in a service. If maximumAttendeesCount of the service is greater than 1, pass valid customer IDs while creating or updating an appointment.  To create a customer, use the Create bookingCustomer operation.
    - `[Notes <String>]`: Additional information about this service.
    - `[PostBuffer <TimeSpan?>]`: The time to buffer after an appointment for this service ends, and before the next customer appointment can be booked.
    - `[PreBuffer <TimeSpan?>]`: The time to buffer before an appointment for this service can start.
    - `[SchedulingPolicy <IMicrosoftGraphBookingSchedulingPolicy>]`: This type represents the set of policies that dictate how bookings can be created in a Booking Calendar.
    - `[SmsNotificationsEnabled <Boolean?>]`: True indicates SMS notifications can be sent to the customers for the appointment of the service. Default value is false.
    - `[StaffMemberIds <String[]>]`: Represents those staff members who provide this service.
  - `[StaffMembers <IMicrosoftGraphBookingStaffMember[]>]`: All the staff members that provide services in this business. Read-only. Nullable.
    - `[EmailAddress <String>]`: The email address of the person.
    - `[DisplayName <String>]`: A name for the derived entity, which interfaces with customers.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[AvailabilityIsAffectedByPersonalCalendar <Boolean?>]`: True means that if the staff member is a Microsoft 365 user, the Bookings API would verify the staff member's availability in their personal calendar in Microsoft 365, before making a booking.
    - `[ColorIndex <Int32?>]`: Identifies a color to represent the staff member. The color corresponds to the color palette in the Staff details page in the Bookings app.
    - `[CreatedDateTime <DateTime?>]`: The date, time and timezone when the staff member was created.
    - `[IsEmailNotificationEnabled <Boolean?>]`: Indicates that a staff members are  notified via email when a booking assigned to them is created or changed. The default value is true
    - `[LastUpdatedDateTime <DateTime?>]`: The date, time and timezone when the staff member was last updated.
    - `[MembershipStatus <String>]`: bookingStaffMembershipStatus
    - `[Role <String>]`: bookingStaffRole
    - `[TimeZone <String>]`: The time zone of the staff member. For a list of possible values, see dateTimeTimeZone.
    - `[UseBusinessHours <Boolean?>]`: True means the staff member's availability is as specified in the businessHours property of the business. False means the availability is determined by the staff member's workingHours property setting.
    - `[WorkingHours <IMicrosoftGraphBookingWorkHours[]>]`: The range of hours each day of the week that the staff member is available for booking. By default, they're initialized to be the same as the businessHours property of the business.
  - `[WebSiteUrl <String>]`: The URL of the business web site. The webSiteUrl property, together with address, phone, appear in the footer of a business scheduling page.

`BOOKINGPAGESETTINGS <IMicrosoftGraphBookingPageSettings>`: bookingPageSettings
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AccessControl <String>]`: bookingPageAccessControl
  - `[BookingPageColorCode <String>]`: Custom color for the bookings page. The value should be in Hex format. Example: #123456.
  - `[BusinessTimeZone <String>]`: The time zone of the customer. For a list of possible values, see dateTimeTimeZone.
  - `[CustomerConsentMessage <String>]`: The personal data collection and usage consent message in the bookings page.
  - `[EnforceOneTimePassword <Boolean?>]`: Determines if the one-time password is required to create an appointment. The default value is false.
  - `[IsBusinessLogoDisplayEnabled <Boolean?>]`: Indicates if the business logo is displayed on the bookings page. The default value is false.
  - `[IsCustomerConsentEnabled <Boolean?>]`: Enables personal data collection and the usage consent toggle on the bookings page. The default value is false.
  - `[IsSearchEngineIndexabilityDisabled <Boolean?>]`: Ensures that the web crawlers don't index this page. The defaults value is false.
  - `[IsTimeSlotTimeZoneSetToBusinessTimeZone <Boolean?>]`: Displays the booking time slots in the business time zone. The default value is false.
  - `[PrivacyPolicyWebUrl <String>]`: RL of a webpage that provides the terms and conditions of the business. If a privacy policy isn't included, the following text appears on the bookings page as default: 'The policies and practices of <booking business's name> apply to the use of your data.
  - `[TermsAndConditionsWebUrl <String>]`: URL of a webpage that provides the terms and conditions of the business.

`BUSINESSHOURS <IMicrosoftGraphBookingWorkHours[]>`: The hours of operation for the business.
  - `[Day <String>]`: dayOfWeek
  - `[TimeSlots <IMicrosoftGraphBookingWorkTimeSlot[]>]`: A list of start/end times during a day.
    - `[End <String>]`: The time of the day when work stops. For example, 17:00:00.0000000.
    - `[Start <String>]`: The time of the day when work starts. For example, 08:00:00.0000000.

`CALENDARVIEW <IMicrosoftGraphBookingAppointment[]>`: The set of appointments of this business in a specified date range. Read-only. Nullable.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AdditionalInformation <String>]`: Additional information that is sent to the customer when an appointment is confirmed.
  - `[AnonymousJoinWebUrl <String>]`: The URL of the meeting to join anonymously.
  - `[AppointmentLabel <String>]`: The user can stamp a custom label on the appointment.
  - `[CreatedDateTime <DateTime?>]`: The date, time, and timezone when the appointment was created.
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
  - `[IsCustomerAllowedToManageBooking <Boolean?>]`: Indicates that the customer can manage bookings created by the staff. The default value is false.
  - `[IsLocationOnline <Boolean?>]`: Indicates that the appointment is held online. The default value is false.
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
  - `[SelfServiceAppointmentId <String>]`: Another tracking ID for the appointment, if the appointment was created directly by the customer on the scheduling page, as opposed to by a staff member on behalf of customer.
  - `[ServiceId <String>]`: The ID of the bookingService associated with this appointment.
  - `[ServiceLocation <IMicrosoftGraphLocation>]`: location
  - `[ServiceName <String>]`: The name of the bookingService associated with this appointment.This property is optional when creating a new appointment. If not specified, it is computed from the service associated with the appointment by the serviceId property.
  - `[ServiceNotes <String>]`: Notes from a bookingStaffMember. The value of this property is available only when reading this bookingAppointment by its ID.
  - `[SmsNotificationsEnabled <Boolean?>]`: True indicates SMS notifications will be sent to the customers for the appointment. Default value is false.
  - `[StaffMemberIds <String[]>]`: The ID of each bookingStaffMember who is scheduled in this appointment.
  - `[Start <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone

`CUSTOMERS <IMicrosoftGraphBookingCustomer[]>`: All the customers of this business. Read-only. Nullable.
  - `[EmailAddress <String>]`: The email address of the person.
  - `[DisplayName <String>]`: A name for the derived entity, which interfaces with customers.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Addresses <IMicrosoftGraphPhysicalAddress[]>]`: Addresses associated with the customer, including home, business and other addresses.
    - `[City <String>]`: The city.
    - `[CountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
    - `[PostOfficeBox <String>]`: The post office box number.
    - `[PostalCode <String>]`: The postal code.
    - `[State <String>]`: The state.
    - `[Street <String>]`: The street.
    - `[Type <String>]`: physicalAddressType
  - `[CreatedDateTime <DateTime?>]`: The date, time and timezone when the customer was created.
  - `[LastUpdatedDateTime <DateTime?>]`: The date, time and timezone when the customer was last updated.
  - `[Phones <IMicrosoftGraphPhone[]>]`: Phone numbers associated with the customer, including home, business and mobile numbers.
    - `[Number <String>]`: The phone number.
    - `[Type <String>]`: phoneType

`CUSTOMQUESTIONS <IMicrosoftGraphBookingCustomQuestion[]>`: All custom questions of this business.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AnswerInputType <String>]`: answerInputType
  - `[AnswerOptions <String[]>]`: List of possible answer values.
  - `[CreatedDateTime <DateTime?>]`: The date, time and timezone when the custom question was created.
  - `[DisplayName <String>]`: Display name of this entity.
  - `[LastUpdatedDateTime <DateTime?>]`: The date, time and timezone when the custom question was last updated.

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
  - `[Email <String>]`: Alternate key of virtualEventRegistration
  - `[JoinWebUrl <String>]`: Alternate key of virtualEventSession
  - `[MeetingAttendanceReportId <String>]`: The unique identifier of meetingAttendanceReport
  - `[PlannerPlanConfigurationLocalizationId <String>]`: The unique identifier of plannerPlanConfigurationLocalization
  - `[Role <String>]`: Usage: role='{role}'
  - `[UniqueName <String>]`: Alternate key of businessScenario
  - `[UserId <String>]`: Alternate key of virtualEventRegistration
  - `[VirtualEventId <String>]`: The unique identifier of virtualEvent
  - `[VirtualEventPresenterId <String>]`: The unique identifier of virtualEventPresenter
  - `[VirtualEventRegistrationId <String>]`: The unique identifier of virtualEventRegistration
  - `[VirtualEventSessionId <String>]`: The unique identifier of virtualEventSession
  - `[VirtualEventTownhallId <String>]`: The unique identifier of virtualEventTownhall
  - `[VirtualEventWebinarId <String>]`: The unique identifier of virtualEventWebinar

`SCHEDULINGPOLICY <IMicrosoftGraphBookingSchedulingPolicy>`: This type represents the set of policies that dictate how bookings can be created in a Booking Calendar.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AllowStaffSelection <Boolean?>]`: True if to allow customers to choose a specific person for the booking.
  - `[CustomAvailabilities <IMicrosoftGraphBookingsAvailabilityWindow[]>]`: Custom availability of the service in a given time frame of the service.
    - `[AvailabilityType <String>]`: bookingsServiceAvailabilityType
    - `[BusinessHours <IMicrosoftGraphBookingWorkHours[]>]`: The hours of operation in a week. The business hours value is set to null if the availability type isn't customWeeklyHours.
      - `[Day <String>]`: dayOfWeek
      - `[TimeSlots <IMicrosoftGraphBookingWorkTimeSlot[]>]`: A list of start/end times during a day.
        - `[End <String>]`: The time of the day when work stops. For example, 17:00:00.0000000.
        - `[Start <String>]`: The time of the day when work starts. For example, 08:00:00.0000000.
    - `[EndDate <DateTime?>]`: End date of the availability window.
    - `[StartDate <DateTime?>]`: Start date of the availability window.
  - `[GeneralAvailability <IMicrosoftGraphBookingsAvailability>]`: bookingsAvailability
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AvailabilityType <String>]`: bookingsServiceAvailabilityType
    - `[BusinessHours <IMicrosoftGraphBookingWorkHours[]>]`: The hours of operation in a week. The business hours value is set to null if the availability type isn't customWeeklyHours.
  - `[IsMeetingInviteToCustomersEnabled <Boolean?>]`: Indicates if the meeting invite is sent to the customers. The default value is false
  - `[MaximumAdvance <TimeSpan?>]`: Maximum number of days in advance that a booking can be made. It follows the ISO 8601 format.
  - `[MinimumLeadTime <TimeSpan?>]`: The minimum amount of time before which bookings and cancellations must be made. It follows the ISO 8601 format.
  - `[SendConfirmationsToOwner <Boolean?>]`: True to notify the business via email when a booking is created or changed. Use the email address specified in the email property of the bookingBusiness entity for the business.
  - `[TimeSlotInterval <TimeSpan?>]`: Duration of each time slot, denoted in ISO 8601 format.

`SERVICES <IMicrosoftGraphBookingService[]>`: All the services offered by this business. Read-only. Nullable.
  - `[DisplayName <String>]`: A name for the derived entity, which interfaces with customers.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AdditionalInformation <String>]`: Additional information that is sent to the customer when an appointment is confirmed.
  - `[CreatedDateTime <DateTime?>]`: The date, time and timezone when the Service was created.
  - `[CustomQuestions <IMicrosoftGraphBookingQuestionAssignment[]>]`: Contains the set of custom questions associated with a particular service.
    - `[IsRequired <Boolean?>]`: Indicates whether it's mandatory to answer the custom question.
    - `[QuestionId <String>]`: If it's mandatory to answer the custom question.
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
  - `[DefaultPriceType <BookingPriceType?>]`: Represents the type of pricing of a booking service.
  - `[DefaultReminders <IMicrosoftGraphBookingReminder[]>]`: The default set of reminders for an appointment of this service. The value of this property is available only when reading this bookingService by its ID.
    - `[Message <String>]`: The message in the reminder.
    - `[Offset <TimeSpan?>]`: The amount of time before the start of an appointment that the reminder should be sent. It's denoted in ISO 8601 format.
    - `[Recipients <String>]`: bookingReminderRecipients
  - `[Description <String>]`: A text description for the service.
  - `[IsAnonymousJoinEnabled <Boolean?>]`: Indicates if an anonymousJoinWebUrl(webrtcUrl) is generated for the appointment booked for this service. The default value is false.
  - `[IsCustomerAllowedToManageBooking <Boolean?>]`: Indicates that the customer can manage bookings created by the staff. The default value is false.
  - `[IsHiddenFromCustomers <Boolean?>]`: True means this service isn't available to customers for booking.
  - `[IsLocationOnline <Boolean?>]`: Indicates that the appointments for the service are held online. The default value is false.
  - `[LanguageTag <String>]`: The language of the self service booking page.
  - `[LastUpdatedDateTime <DateTime?>]`: The date, time and timezone when the Service  was last updated.
  - `[MaximumAttendeesCount <Int32?>]`: The maximum number of customers allowed in a service. If maximumAttendeesCount of the service is greater than 1, pass valid customer IDs while creating or updating an appointment.  To create a customer, use the Create bookingCustomer operation.
  - `[Notes <String>]`: Additional information about this service.
  - `[PostBuffer <TimeSpan?>]`: The time to buffer after an appointment for this service ends, and before the next customer appointment can be booked.
  - `[PreBuffer <TimeSpan?>]`: The time to buffer before an appointment for this service can start.
  - `[SchedulingPolicy <IMicrosoftGraphBookingSchedulingPolicy>]`: This type represents the set of policies that dictate how bookings can be created in a Booking Calendar.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AllowStaffSelection <Boolean?>]`: True if to allow customers to choose a specific person for the booking.
    - `[CustomAvailabilities <IMicrosoftGraphBookingsAvailabilityWindow[]>]`: Custom availability of the service in a given time frame of the service.
      - `[AvailabilityType <String>]`: bookingsServiceAvailabilityType
      - `[BusinessHours <IMicrosoftGraphBookingWorkHours[]>]`: The hours of operation in a week. The business hours value is set to null if the availability type isn't customWeeklyHours.
        - `[Day <String>]`: dayOfWeek
        - `[TimeSlots <IMicrosoftGraphBookingWorkTimeSlot[]>]`: A list of start/end times during a day.
          - `[End <String>]`: The time of the day when work stops. For example, 17:00:00.0000000.
          - `[Start <String>]`: The time of the day when work starts. For example, 08:00:00.0000000.
      - `[EndDate <DateTime?>]`: End date of the availability window.
      - `[StartDate <DateTime?>]`: Start date of the availability window.
    - `[GeneralAvailability <IMicrosoftGraphBookingsAvailability>]`: bookingsAvailability
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AvailabilityType <String>]`: bookingsServiceAvailabilityType
      - `[BusinessHours <IMicrosoftGraphBookingWorkHours[]>]`: The hours of operation in a week. The business hours value is set to null if the availability type isn't customWeeklyHours.
    - `[IsMeetingInviteToCustomersEnabled <Boolean?>]`: Indicates if the meeting invite is sent to the customers. The default value is false
    - `[MaximumAdvance <TimeSpan?>]`: Maximum number of days in advance that a booking can be made. It follows the ISO 8601 format.
    - `[MinimumLeadTime <TimeSpan?>]`: The minimum amount of time before which bookings and cancellations must be made. It follows the ISO 8601 format.
    - `[SendConfirmationsToOwner <Boolean?>]`: True to notify the business via email when a booking is created or changed. Use the email address specified in the email property of the bookingBusiness entity for the business.
    - `[TimeSlotInterval <TimeSpan?>]`: Duration of each time slot, denoted in ISO 8601 format.
  - `[SmsNotificationsEnabled <Boolean?>]`: True indicates SMS notifications can be sent to the customers for the appointment of the service. Default value is false.
  - `[StaffMemberIds <String[]>]`: Represents those staff members who provide this service.

`STAFFMEMBERS <IMicrosoftGraphBookingStaffMember[]>`: All the staff members that provide services in this business. Read-only. Nullable.
  - `[EmailAddress <String>]`: The email address of the person.
  - `[DisplayName <String>]`: A name for the derived entity, which interfaces with customers.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AvailabilityIsAffectedByPersonalCalendar <Boolean?>]`: True means that if the staff member is a Microsoft 365 user, the Bookings API would verify the staff member's availability in their personal calendar in Microsoft 365, before making a booking.
  - `[ColorIndex <Int32?>]`: Identifies a color to represent the staff member. The color corresponds to the color palette in the Staff details page in the Bookings app.
  - `[CreatedDateTime <DateTime?>]`: The date, time and timezone when the staff member was created.
  - `[IsEmailNotificationEnabled <Boolean?>]`: Indicates that a staff members are  notified via email when a booking assigned to them is created or changed. The default value is true
  - `[LastUpdatedDateTime <DateTime?>]`: The date, time and timezone when the staff member was last updated.
  - `[MembershipStatus <String>]`: bookingStaffMembershipStatus
  - `[Role <String>]`: bookingStaffRole
  - `[TimeZone <String>]`: The time zone of the staff member. For a list of possible values, see dateTimeTimeZone.
  - `[UseBusinessHours <Boolean?>]`: True means the staff member's availability is as specified in the businessHours property of the business. False means the availability is determined by the staff member's workingHours property setting.
  - `[WorkingHours <IMicrosoftGraphBookingWorkHours[]>]`: The range of hours each day of the week that the staff member is available for booking. By default, they're initialized to be the same as the businessHours property of the business.
    - `[Day <String>]`: dayOfWeek
    - `[TimeSlots <IMicrosoftGraphBookingWorkTimeSlot[]>]`: A list of start/end times during a day.
      - `[End <String>]`: The time of the day when work stops. For example, 17:00:00.0000000.
      - `[Start <String>]`: The time of the day when work starts. For example, 08:00:00.0000000.

## RELATED LINKS

