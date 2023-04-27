---
external help file:
Module Name: Microsoft.Graph.Bookings
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.bookings/new-mgbookingbusinessappointment
schema: 2.0.0
---

# New-MgBookingBusinessAppointment

## SYNOPSIS
Create new navigation property to appointments for solutions

## SYNTAX

### CreateExpanded1 (Default)
```
New-MgBookingBusinessAppointment -BookingBusinessId <String> [-AdditionalInformation <String>]
 [-AdditionalProperties <Hashtable>] [-AnonymousJoinWebUrl <String>]
 [-Customers <IMicrosoftGraphBookingCustomerInformationBase[]>] [-CustomerTimeZone <String>]
 [-EndDateTime <IMicrosoftGraphDateTimeZone>] [-Id <String>] [-IsLocationOnline] [-JoinWebUrl <String>]
 [-MaximumAttendeesCount <Int32>] [-OptOutOfCustomerEmail] [-PostBuffer <TimeSpan>] [-PreBuffer <TimeSpan>]
 [-Price <Double>] [-PriceType <BookingPriceType>] [-Reminders <IMicrosoftGraphBookingReminder[]>]
 [-SelfServiceAppointmentId <String>] [-ServiceId <String>] [-ServiceLocation <IMicrosoftGraphLocation>]
 [-ServiceName <String>] [-ServiceNotes <String>] [-SmsNotificationsEnabled] [-StaffMemberIds <String[]>]
 [-StartDateTime <IMicrosoftGraphDateTimeZone>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create1
```
New-MgBookingBusinessAppointment -BookingBusinessId <String>
 -BodyParameter <IMicrosoftGraphBookingAppointment> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity1
```
New-MgBookingBusinessAppointment -InputObject <IBookingsIdentity>
 -BodyParameter <IMicrosoftGraphBookingAppointment> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded1
```
New-MgBookingBusinessAppointment -InputObject <IBookingsIdentity> [-AdditionalInformation <String>]
 [-AdditionalProperties <Hashtable>] [-AnonymousJoinWebUrl <String>]
 [-Customers <IMicrosoftGraphBookingCustomerInformationBase[]>] [-CustomerTimeZone <String>]
 [-EndDateTime <IMicrosoftGraphDateTimeZone>] [-Id <String>] [-IsLocationOnline] [-JoinWebUrl <String>]
 [-MaximumAttendeesCount <Int32>] [-OptOutOfCustomerEmail] [-PostBuffer <TimeSpan>] [-PreBuffer <TimeSpan>]
 [-Price <Double>] [-PriceType <BookingPriceType>] [-Reminders <IMicrosoftGraphBookingReminder[]>]
 [-SelfServiceAppointmentId <String>] [-ServiceId <String>] [-ServiceLocation <IMicrosoftGraphLocation>]
 [-ServiceName <String>] [-ServiceNotes <String>] [-SmsNotificationsEnabled] [-StaffMemberIds <String[]>]
 [-StartDateTime <IMicrosoftGraphDateTimeZone>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to appointments for solutions

## EXAMPLES

### Example 1: Using the New-MgBookingBusinessAppointment Cmdlet
```powershell
Import-Module Microsoft.Graph.Bookings
$params = @{
	"@odata.type" = "#microsoft.graph.bookingAppointment"
	CustomerTimeZone = "America/Chicago"
	SmsNotificationsEnabled = $true
	EndDateTime = @{
		"@odata.type" = "#microsoft.graph.dateTimeTimeZone"
		DateTime = "2018-05-01T12:30:00.0000000+00:00"
		TimeZone = "UTC"
	}
	IsLocationOnline = $true
	OptOutOfCustomerEmail = $false
	PostBuffer = "PT10M"
	PreBuffer = "PT5M"
	Price = 10
	"PriceType@odata.type" = "#microsoft.graph.bookingPriceType"
	PriceType = "fixedPrice"
	"Reminders@odata.type" = "#Collection(microsoft.graph.bookingReminder)"
	Reminders = @(
		@{
			"@odata.type" = "#microsoft.graph.bookingReminder"
			Message = "This service is tomorrow"
			Offset = "P1D"
			"Recipients@odata.type" = "#microsoft.graph.bookingReminderRecipients"
			Recipients = "allAttendees"
		}
		@{
			"@odata.type" = "#microsoft.graph.bookingReminder"
			Message = "Please be available to enjoy your lunch service."
			Offset = "PT1H"
			"Recipients@odata.type" = "#microsoft.graph.bookingReminderRecipients"
			Recipients = "customer"
		}
		@{
			"@odata.type" = "#microsoft.graph.bookingReminder"
			Message = "Please check traffic for next cater."
			Offset = "PT2H"
			"Recipients@odata.type" = "#microsoft.graph.bookingReminderRecipients"
			Recipients = "staff"
		}
	)
	ServiceId = "57da6774-a087-4d69-b0e6-6fb82c339976"
	ServiceLocation = @{
		"@odata.type" = "#microsoft.graph.location"
		Address = @{
			"@odata.type" = "#microsoft.graph.physicalAddress"
			City = "Buffalo"
			CountryOrRegion = "USA"
			PostalCode = "98052"
			PostOfficeBox = $null
			State = "NY"
			Street = "123 First Avenue"
			"Type@odata.type" = "#microsoft.graph.physicalAddressType"
			Type = $null
		}
		Coordinates = $null
		DisplayName = "Customer location"
		LocationEmailAddress = $null
		"LocationType@odata.type" = "#microsoft.graph.locationType"
		LocationType = $null
		LocationUri = $null
		UniqueId = $null
		"UniqueIdType@odata.type" = "#microsoft.graph.locationUniqueIdType"
		UniqueIdType = $null
	}
	ServiceName = "Catered bento"
	ServiceNotes = "Customer requires punctual service."
	StartDateTime = @{
		"@odata.type" = "#microsoft.graph.dateTimeTimeZone"
		DateTime = "2018-05-01T12:00:00.0000000+00:00"
		TimeZone = "UTC"
	}
	MaximumAttendeesCount = 5
	FilledAttendeesCount = 1
	"Customers@odata.type" = "#Collection(microsoft.graph.bookingCustomerInformation)"
	Customers = @(
		@{
			"@odata.type" = "#microsoft.graph.bookingCustomerInformation"
			CustomerId = "7ed53fa5-9ef2-4f2f-975b-27447440bc09"
			Name = "Jordan Miller"
			EmailAddress = "jordanm@contoso.com"
			Phone = "213-555-0199"
			Notes = $null
			Location = @{
				"@odata.type" = "#microsoft.graph.location"
				DisplayName = "Customer"
				LocationEmailAddress = $null
				LocationUri = ""
				LocationType = $null
				UniqueId = $null
				UniqueIdType = $null
				Address = @{
					"@odata.type" = "#microsoft.graph.physicalAddress"
					Street = ""
					City = ""
					State = ""
					CountryOrRegion = ""
					PostalCode = ""
				}
			}
			TimeZone = "America/Chicago"
			CustomQuestionAnswers = @(
			)
		}
	)
}
New-MgBookingBusinessAppointment -BookingBusinessId $bookingBusinessId -BodyParameter $params
```

This example shows how to use the New-MgBookingBusinessAppointment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -AdditionalInformation
Additional information that is sent to the customer when an appointment is confirmed.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
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
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
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
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
Represents a booked appointment of a service by a customer in a business.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphBookingAppointment
Parameter Sets: Create1, CreateViaIdentity1
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
Parameter Sets: Create1, CreateExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Customers
A collection of customer properties for an appointment.
An appointment will contain a list of customer information and each unit will indicate the properties of a customer who is part of that appointment.
Optional.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphBookingCustomerInformationBase[]
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
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
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EndDateTime
dateTimeTimeZone
To construct, please use Get-Help -Online and see NOTES section for ENDDATETIME properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDateTimeZone
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
The unique idenfier for an entity.
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
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
Parameter Sets: CreateViaIdentity1, CreateViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IsLocationOnline
If true, indicates that the appointment will be held online.
Default value is false.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
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
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
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
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OptOutOfCustomerEmail
If true indicates that the bookingCustomer for this appointment does not wish to receive a confirmation for this appointment.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
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
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
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
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
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
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
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
Type: Microsoft.Graph.PowerShell.Support.BookingPriceType
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
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
To construct, please use Get-Help -Online and see NOTES section for REMINDERS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphBookingReminder[]
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SelfServiceAppointmentId
An additional tracking ID for the appointment, if the appointment has been created directly by the customer on the scheduling page, as opposed to by a staff member on the behalf of the customer.
Only supported for appointment if maxAttendeeCount is 1.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
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
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ServiceLocation
location
To construct, please use Get-Help -Online and see NOTES section for SERVICELOCATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphLocation
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
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
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
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
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SmsNotificationsEnabled
If true, indicates SMS notifications will be sent to the customers for the appointment.
Default value is false.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
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
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StartDateTime
dateTimeTimeZone
To construct, please use Get-Help -Online and see NOTES section for STARTDATETIME properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDateTimeZone
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
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
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[AdditionalInformation <String>]`: Additional information that is sent to the customer when an appointment is confirmed.
  - `[AnonymousJoinWebUrl <String>]`: The URL of the meeting to join anonymously.
  - `[CustomerTimeZone <String>]`: The time zone of the customer. For a list of possible values, see dateTimeTimeZone.
  - `[Customers <IMicrosoftGraphBookingCustomerInformationBase[]>]`: A collection of customer properties for an appointment. An appointment will contain a list of customer information and each unit will indicate the properties of a customer who is part of that appointment. Optional.
  - `[EndDateTime <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).
    - `[TimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for more possible values.
  - `[IsLocationOnline <Boolean?>]`: If true, indicates that the appointment will be held online. Default value is false.
  - `[JoinWebUrl <String>]`: The URL of the online meeting for the appointment.
  - `[MaximumAttendeesCount <Int32?>]`: The maximum number of customers allowed in an appointment. If maximumAttendeesCount of the service is greater than 1, pass valid customer IDs while creating or updating an appointment. To create a customer, use the Create bookingCustomer operation.
  - `[OptOutOfCustomerEmail <Boolean?>]`: If true indicates that the bookingCustomer for this appointment does not wish to receive a confirmation for this appointment.
  - `[PostBuffer <TimeSpan?>]`: The amount of time to reserve after the appointment ends, for cleaning up, as an example. The value is expressed in ISO8601 format.
  - `[PreBuffer <TimeSpan?>]`: The amount of time to reserve before the appointment begins, for preparation, as an example. The value is expressed in ISO8601 format.
  - `[Price <Double?>]`: The regular price for an appointment for the specified bookingService.
  - `[PriceType <BookingPriceType?>]`: Represents the type of pricing of a booking service.
  - `[Reminders <IMicrosoftGraphBookingReminder[]>]`: The collection of customer reminders sent for this appointment. The value of this property is available only when reading this bookingAppointment by its ID.
    - `[Message <String>]`: The message in the reminder.
    - `[Offset <TimeSpan?>]`: The amount of time before the start of an appointment that the reminder should be sent. It's denoted in ISO 8601 format.
    - `[Recipients <String>]`: 
  - `[SelfServiceAppointmentId <String>]`: An additional tracking ID for the appointment, if the appointment has been created directly by the customer on the scheduling page, as opposed to by a staff member on the behalf of the customer. Only supported for appointment if maxAttendeeCount is 1.
  - `[ServiceId <String>]`: The ID of the bookingService associated with this appointment.
  - `[ServiceLocation <IMicrosoftGraphLocation>]`: location
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Address <IMicrosoftGraphPhysicalAddress>]`: physicalAddress
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[City <String>]`: The city.
      - `[CountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
      - `[PostalCode <String>]`: The postal code.
      - `[State <String>]`: The state.
      - `[Street <String>]`: The street.
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
  - `[ServiceName <String>]`: The name of the bookingService associated with this appointment.This property is optional when creating a new appointment. If not specified, it is computed from the service associated with the appointment by the serviceId property.
  - `[ServiceNotes <String>]`: Notes from a bookingStaffMember. The value of this property is available only when reading this bookingAppointment by its ID.
  - `[SmsNotificationsEnabled <Boolean?>]`: If true, indicates SMS notifications will be sent to the customers for the appointment. Default value is false.
  - `[StaffMemberIds <String[]>]`: The ID of each bookingStaffMember who is scheduled in this appointment.
  - `[StartDateTime <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone

ENDDATETIME <IMicrosoftGraphDateTimeZone>: dateTimeTimeZone
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).
  - `[TimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for more possible values.

INPUTOBJECT <IBookingsIdentity>: Identity Parameter
  - `[BookingAppointmentId <String>]`: The unique identifier of bookingAppointment
  - `[BookingBusinessId <String>]`: The unique identifier of bookingBusiness
  - `[BookingCurrencyId <String>]`: The unique identifier of bookingCurrency
  - `[BookingCustomQuestionId <String>]`: The unique identifier of bookingCustomQuestion
  - `[BookingCustomerBaseId <String>]`: The unique identifier of bookingCustomerBase
  - `[BookingCustomerId <String>]`: The unique identifier of bookingCustomer
  - `[BookingServiceId <String>]`: The unique identifier of bookingService
  - `[BookingStaffMemberBaseId <String>]`: The unique identifier of bookingStaffMemberBase
  - `[BookingStaffMemberId <String>]`: The unique identifier of bookingStaffMember
  - `[BusinessScenarioId <String>]`: The unique identifier of businessScenario
  - `[BusinessScenarioTaskId <String>]`: The unique identifier of businessScenarioTask
  - `[PlannerPlanConfigurationLocalizationId <String>]`: The unique identifier of plannerPlanConfigurationLocalization

REMINDERS <IMicrosoftGraphBookingReminder[]>: The collection of customer reminders sent for this appointment. The value of this property is available only when reading this bookingAppointment by its ID.
  - `[Message <String>]`: The message in the reminder.
  - `[Offset <TimeSpan?>]`: The amount of time before the start of an appointment that the reminder should be sent. It's denoted in ISO 8601 format.
  - `[Recipients <String>]`: 

SERVICELOCATION <IMicrosoftGraphLocation>: location
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Address <IMicrosoftGraphPhysicalAddress>]`: physicalAddress
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[City <String>]`: The city.
    - `[CountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
    - `[PostalCode <String>]`: The postal code.
    - `[State <String>]`: The state.
    - `[Street <String>]`: The street.
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

STARTDATETIME <IMicrosoftGraphDateTimeZone>: dateTimeTimeZone
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).
  - `[TimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for more possible values.

## RELATED LINKS

