---
external help file:
Module Name: Microsoft.Graph.Bookings
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.bookings/update-mgbookingbusinessservice
schema: 2.0.0
---

# Update-MgBookingBusinessService

## SYNOPSIS
Update the navigation property services in bookingBusinesses

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBookingBusinessService -BookingBusinessId <String> -BookingServiceId <String>
 [-AdditionalProperties <Hashtable>] [-DefaultDuration <TimeSpan>]
 [-DefaultLocation <IMicrosoftGraphLocation>] [-DefaultPrice <Double>] [-DefaultPriceType <String>]
 [-DefaultReminders <IMicrosoftGraphBookingReminder[]>] [-Description <String>] [-DisplayName <String>]
 [-Id <String>] [-IsHiddenFromCustomers] [-Notes <String>] [-PostBuffer <TimeSpan>] [-PreBuffer <TimeSpan>]
 [-SchedulingPolicy <IMicrosoftGraphBookingSchedulingPolicy>] [-StaffMemberIds <String[]>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBookingBusinessService -BookingBusinessId <String> -BookingServiceId <String>
 -BodyParameter <IMicrosoftGraphBookingService> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBookingBusinessService -InputObject <IBookingsIdentity>
 -BodyParameter <IMicrosoftGraphBookingService> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBookingBusinessService -InputObject <IBookingsIdentity> [-AdditionalProperties <Hashtable>]
 [-DefaultDuration <TimeSpan>] [-DefaultLocation <IMicrosoftGraphLocation>] [-DefaultPrice <Double>]
 [-DefaultPriceType <String>] [-DefaultReminders <IMicrosoftGraphBookingReminder[]>] [-Description <String>]
 [-DisplayName <String>] [-Id <String>] [-IsHiddenFromCustomers] [-Notes <String>] [-PostBuffer <TimeSpan>]
 [-PreBuffer <TimeSpan>] [-SchedulingPolicy <IMicrosoftGraphBookingSchedulingPolicy>]
 [-StaffMemberIds <String[]>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property services in bookingBusinesses

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

### -BodyParameter
Represents a particular service offered by a booking business.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphBookingService
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

### -BookingServiceId
key: id of bookingService

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

### -DefaultDuration
.

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

### -DefaultLocation
location
To construct, see NOTES section for DEFAULTLOCATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphLocation
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: System.Double
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultPriceType
bookingPriceType

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

### -DefaultReminders
The default reminders set in an appointment of this service.
To construct, see NOTES section for DEFAULTREMINDERS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphBookingReminder[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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

### -IsHiddenFromCustomers
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

### -Notes
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

### -PostBuffer
.

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

### -PreBuffer
.

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

### -StaffMemberIds
.

```yaml
Type: System.String[]
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphBookingService

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphBookingService>: Represents a particular service offered by a booking business.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DisplayName <String>]`: Display name of this entity.
  - `[Id <String>]`: Read-only.
  - `[DefaultDuration <TimeSpan?>]`: 
  - `[DefaultLocation <IMicrosoftGraphLocation>]`: location
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Address <IMicrosoftGraphPhysicalAddress>]`: physicalAddress
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[City <String>]`: The city.
      - `[CountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
      - `[PostOfficeBox <String>]`: 
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
  - `[SchedulingPolicy <IMicrosoftGraphBookingSchedulingPolicy>]`: This type represents the set of policies that dictate how bookings can be created in a Booking Calendar.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AllowStaffSelection <Boolean?>]`: Allow customers to choose a specific person for the booking.
    - `[MaximumAdvance <TimeSpan?>]`: Maximum number of days in advance that a booking can be made.
    - `[MinimumLeadTime <TimeSpan?>]`: Minimum lead time for bookings and cancellations.
    - `[SendConfirmationsToOwner <Boolean?>]`: Notify the business via email when a booking is created or changed.
    - `[TimeSlotInterval <TimeSpan?>]`: Duration of each time slot.
  - `[StaffMemberIds <String[]>]`: 

DEFAULTLOCATION <IMicrosoftGraphLocation>: location
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Address <IMicrosoftGraphPhysicalAddress>]`: physicalAddress
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[City <String>]`: The city.
    - `[CountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
    - `[PostOfficeBox <String>]`: 
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

DEFAULTREMINDERS <IMicrosoftGraphBookingReminder[]>: The default reminders set in an appointment of this service.
  - `[Message <String>]`: Message to send.
  - `[Offset <TimeSpan?>]`: How much time before an appointment the reminder should be sent.
  - `[Recipients <String>]`: bookingReminderRecipients

INPUTOBJECT <IBookingsIdentity>: Identity Parameter
  - `[BookingAppointmentId <String>]`: key: id of bookingAppointment
  - `[BookingBusinessId <String>]`: key: id of bookingBusiness
  - `[BookingCurrencyId <String>]`: key: id of bookingCurrency
  - `[BookingCustomerId <String>]`: key: id of bookingCustomer
  - `[BookingServiceId <String>]`: key: id of bookingService
  - `[BookingStaffMemberId <String>]`: key: id of bookingStaffMember

SCHEDULINGPOLICY <IMicrosoftGraphBookingSchedulingPolicy>: This type represents the set of policies that dictate how bookings can be created in a Booking Calendar.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AllowStaffSelection <Boolean?>]`: Allow customers to choose a specific person for the booking.
  - `[MaximumAdvance <TimeSpan?>]`: Maximum number of days in advance that a booking can be made.
  - `[MinimumLeadTime <TimeSpan?>]`: Minimum lead time for bookings and cancellations.
  - `[SendConfirmationsToOwner <Boolean?>]`: Notify the business via email when a booking is created or changed.
  - `[TimeSlotInterval <TimeSpan?>]`: Duration of each time slot.

## RELATED LINKS

