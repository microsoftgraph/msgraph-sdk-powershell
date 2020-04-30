---
external help file:
Module Name: Microsoft.Graph.Bookings
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.bookings/stop-mgbookingbusinessappointment
schema: 2.0.0
---

# Stop-MgBookingBusinessAppointment

## SYNOPSIS
Invoke action cancel

## SYNTAX

### CancelExpanded (Default)
```
Stop-MgBookingBusinessAppointment -BookingAppointmentId <String> -BookingBusinessId <String>
 [-CancellationMessage <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Cancel
```
Stop-MgBookingBusinessAppointment -BookingAppointmentId <String> -BookingBusinessId <String>
 -BodyParameter <IPaths1K88Cl0BookingbusinessesBookingbusinessIdAppointmentsBookingappointmentIdMicrosoftGraphCancelPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CancelViaIdentity
```
Stop-MgBookingBusinessAppointment -InputObject <IBookingsIdentity>
 -BodyParameter <IPaths1K88Cl0BookingbusinessesBookingbusinessIdAppointmentsBookingappointmentIdMicrosoftGraphCancelPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CancelViaIdentityExpanded
```
Stop-MgBookingBusinessAppointment -InputObject <IBookingsIdentity> [-CancellationMessage <String>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action cancel

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
.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IPaths1K88Cl0BookingbusinessesBookingbusinessIdAppointmentsBookingappointmentIdMicrosoftGraphCancelPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Cancel, CancelViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -BookingAppointmentId
key: bookingAppointment-id of bookingAppointment

```yaml
Type: System.String
Parameter Sets: Cancel, CancelExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -BookingBusinessId
key: bookingBusiness-id of bookingBusiness

```yaml
Type: System.String
Parameter Sets: Cancel, CancelExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IBookingsIdentity
Parameter Sets: CancelViaIdentity, CancelViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
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
Dynamic: False
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
Dynamic: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IBookingsIdentity

### Microsoft.Graph.PowerShell.Models.IPaths1K88Cl0BookingbusinessesBookingbusinessIdAppointmentsBookingappointmentIdMicrosoftGraphCancelPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### System.Boolean

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### BODYPARAMETER <IPaths1K88Cl0BookingbusinessesBookingbusinessIdAppointmentsBookingappointmentIdMicrosoftGraphCancelPostRequestbodyContentApplicationJsonSchema>: .
  - `[CancellationMessage <String>]`: 

#### INPUTOBJECT <IBookingsIdentity>: Identity Parameter
  - `[BookingAppointmentId <String>]`: key: bookingAppointment-id of bookingAppointment
  - `[BookingBusinessId <String>]`: key: bookingBusiness-id of bookingBusiness
  - `[BookingCurrencyId <String>]`: key: bookingCurrency-id of bookingCurrency
  - `[BookingCustomerId <String>]`: key: bookingCustomer-id of bookingCustomer
  - `[BookingServiceId <String>]`: key: bookingService-id of bookingService
  - `[BookingStaffMemberId <String>]`: key: bookingStaffMember-id of bookingStaffMember

## RELATED LINKS

