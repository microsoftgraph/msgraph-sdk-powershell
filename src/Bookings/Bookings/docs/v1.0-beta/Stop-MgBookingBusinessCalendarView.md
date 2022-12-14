---
external help file:
Module Name: Microsoft.Graph.Beta.Bookings
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.bookings/stop-mgbookingbusinesscalendarview
schema: 2.0.0
---

# Stop-MgBetaBookingBusinessCalendarView

## SYNOPSIS
Cancel the specified bookingAppointment in the specified bookingBusiness, and send a message to the involved customer and staff members.

## SYNTAX

### CancelExpanded (Default)
```
Stop-MgBetaBookingBusinessCalendarView -BookingAppointmentId <String> -BookingBusinessId <String>
 [-AdditionalProperties <Hashtable>] [-CancellationMessage <String>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Cancel
```
Stop-MgBetaBookingBusinessCalendarView -BookingAppointmentId <String> -BookingBusinessId <String>
 -BodyParameter <IPaths1Bomg32BookingbusinessesBookingbusinessIdCalendarviewBookingappointmentIdMicrosoftGraphCancelPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CancelViaIdentity
```
Stop-MgBetaBookingBusinessCalendarView -InputObject <IBookingsIdentity>
 -BodyParameter <IPaths1Bomg32BookingbusinessesBookingbusinessIdCalendarviewBookingappointmentIdMicrosoftGraphCancelPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CancelViaIdentityExpanded
```
Stop-MgBetaBookingBusinessCalendarView -InputObject <IBookingsIdentity> [-AdditionalProperties <Hashtable>]
 [-CancellationMessage <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Cancel the specified bookingAppointment in the specified bookingBusiness, and send a message to the involved customer and staff members.

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CancelExpanded, CancelViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IPaths1Bomg32BookingbusinessesBookingbusinessIdCalendarviewBookingappointmentIdMicrosoftGraphCancelPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Cancel, CancelViaIdentity
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
Type: System.String
Parameter Sets: Cancel, CancelExpanded
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
Type: System.String
Parameter Sets: Cancel, CancelExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CancellationMessage
.

```yaml
Type: System.String
Parameter Sets: CancelExpanded, CancelViaIdentityExpanded
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IBookingsIdentity
Parameter Sets: CancelViaIdentity, CancelViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### Microsoft.Graph.Beta.PowerShell.Models.IPaths1Bomg32BookingbusinessesBookingbusinessIdCalendarviewBookingappointmentIdMicrosoftGraphCancelPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths1Bomg32BookingbusinessesBookingbusinessIdCalendarviewBookingappointmentIdMicrosoftGraphCancelPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CancellationMessage <String>]`: 

INPUTOBJECT <IBookingsIdentity>: Identity Parameter
  - `[BookingAppointmentId <String>]`: key: id of bookingAppointment
  - `[BookingBusinessId <String>]`: key: id of bookingBusiness
  - `[BookingCurrencyId <String>]`: key: id of bookingCurrency
  - `[BookingCustomQuestionId <String>]`: key: id of bookingCustomQuestion
  - `[BookingCustomerBaseId <String>]`: key: id of bookingCustomerBase
  - `[BookingCustomerId <String>]`: key: id of bookingCustomer
  - `[BookingServiceId <String>]`: key: id of bookingService
  - `[BookingStaffMemberBaseId <String>]`: key: id of bookingStaffMemberBase
  - `[BookingStaffMemberId <String>]`: key: id of bookingStaffMember
  - `[BusinessScenarioId <String>]`: key: id of businessScenario
  - `[BusinessScenarioTaskId <String>]`: key: id of businessScenarioTask
  - `[PlannerPlanConfigurationLocalizationId <String>]`: key: id of plannerPlanConfigurationLocalization

## RELATED LINKS

