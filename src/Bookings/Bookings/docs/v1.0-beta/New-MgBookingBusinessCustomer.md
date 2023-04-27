---
external help file:
Module Name: Microsoft.Graph.Bookings
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.bookings/new-mgbookingbusinesscustomer
schema: 2.0.0
---

# New-MgBookingBusinessCustomer

## SYNOPSIS
Create new navigation property to customers for bookingBusinesses

## SYNTAX

### CreateExpanded (Default)
```
New-MgBookingBusinessCustomer -BookingBusinessId <String> [-AdditionalProperties <Hashtable>]
 [-Addresses <IMicrosoftGraphPhysicalAddress1[]>] [-DisplayName <String>] [-EmailAddress <String>]
 [-Id <String>] [-Phones <IMicrosoftGraphPhone[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgBookingBusinessCustomer -BookingBusinessId <String> -BodyParameter <IMicrosoftGraphBookingCustomer>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgBookingBusinessCustomer -InputObject <IBookingsIdentity> -BodyParameter <IMicrosoftGraphBookingCustomer>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgBookingBusinessCustomer -InputObject <IBookingsIdentity> [-AdditionalProperties <Hashtable>]
 [-Addresses <IMicrosoftGraphPhysicalAddress1[]>] [-DisplayName <String>] [-EmailAddress <String>]
 [-Id <String>] [-Phones <IMicrosoftGraphPhone[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to customers for bookingBusinesses

## EXAMPLES

### Example 1: Using the New-MgBookingBusinessCustomer Cmdlet
```powershell
Import-Module Microsoft.Graph.Bookings
$params = @{
	DisplayName = "Joni Sherman"
	EmailAddress = "jonis@relecloud.com"
	Addresses = @(
		@{
			PostOfficeBox = ""
			Street = "4567 Main Street"
			City = "Buffalo"
			State = "NY"
			CountryOrRegion = "USA"
			PostalCode = "98052"
			Type = "home"
		}
		@{
			PostOfficeBox = ""
			Street = "4570 Main Street"
			City = "Buffalo"
			State = "NY"
			CountryOrRegion = "USA"
			PostalCode = "98054"
			Type = "business"
		}
	)
	Phones = @(
		@{
			Number = "206-555-0100"
			Type = "home"
		}
		@{
			Number = "206-555-0200"
			Type = "business"
		}
	)
}
New-MgBookingBusinessCustomer -BookingBusinessId $bookingBusinessId -BodyParameter $params
```

This example shows how to use the New-MgBookingBusinessCustomer Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Addresses
Addresses associated with the customer, including home, business and other addresses.
To construct, please use Get-Help -Online and see NOTES section for ADDRESSES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPhysicalAddress1[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
Represents a customer of the business.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphBookingCustomer
Parameter Sets: Create, CreateViaIdentity
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
Parameter Sets: Create, CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
A name for the derived entity, which interfaces with customers.

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

### -EmailAddress
The email address of the person.

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
The unique idenfier for an entity.
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
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

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

### -Phones
Phone numbers associated with the customer, including home, business and mobile numbers.
To construct, please use Get-Help -Online and see NOTES section for PHONES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPhone[]
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphBookingCustomer

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphBookingCustomer

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ADDRESSES <IMicrosoftGraphPhysicalAddress1[]>: Addresses associated with the customer, including home, business and other addresses.
  - `[City <String>]`: The city.
  - `[CountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
  - `[PostOfficeBox <String>]`: The post office box number.
  - `[PostalCode <String>]`: The postal code.
  - `[State <String>]`: The state.
  - `[Street <String>]`: The street.
  - `[Type <String>]`: physicalAddressType

BODYPARAMETER <IMicrosoftGraphBookingCustomer>: Represents a customer of the business.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[EmailAddress <String>]`: The email address of the person.
  - `[DisplayName <String>]`: A name for the derived entity, which interfaces with customers.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Addresses <IMicrosoftGraphPhysicalAddress1[]>]`: Addresses associated with the customer, including home, business and other addresses.
    - `[City <String>]`: The city.
    - `[CountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
    - `[PostOfficeBox <String>]`: The post office box number.
    - `[PostalCode <String>]`: The postal code.
    - `[State <String>]`: The state.
    - `[Street <String>]`: The street.
    - `[Type <String>]`: physicalAddressType
  - `[Phones <IMicrosoftGraphPhone[]>]`: Phone numbers associated with the customer, including home, business and mobile numbers.
    - `[Number <String>]`: The phone number.
    - `[Type <String>]`: phoneType

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

PHONES <IMicrosoftGraphPhone[]>: Phone numbers associated with the customer, including home, business and mobile numbers.
  - `[Number <String>]`: The phone number.
  - `[Type <String>]`: phoneType

## RELATED LINKS

