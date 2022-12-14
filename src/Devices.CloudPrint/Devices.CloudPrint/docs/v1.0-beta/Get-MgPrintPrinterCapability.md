---
external help file:
Module Name: Microsoft.Graph.Beta.Devices.CloudPrint
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.devices.cloudprint/get-mgprintprintercapability
schema: 2.0.0
---

# Get-MgBetaPrintPrinterCapability

## SYNOPSIS
Invoke function getCapabilities

## SYNTAX

### Get (Default)
```
Get-MgBetaPrintPrinterCapability -PrinterId <String> [<CommonParameters>]
```

### GetViaIdentity
```
Get-MgBetaPrintPrinterCapability -InputObject <IDevicesCloudPrintIdentity> [<CommonParameters>]
```

## DESCRIPTION
Invoke function getCapabilities

## EXAMPLES

### Example 1: Using the Get-MgBetaPrintPrinterCapability Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Devices.CloudPrint
Get-MgBetaPrintPrinterCapability -PrinterId $printerId
```

This example shows how to use the Get-MgBetaPrintPrinterCapability Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -InputObject
Identity Parameter
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IDevicesCloudPrintIdentity
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -PrinterId
key: id of printer

```yaml
Type: System.String
Parameter Sets: Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IDevicesCloudPrintIdentity

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPrinterCapabilities1

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


INPUTOBJECT <IDevicesCloudPrintIdentity>: Identity Parameter
  - `[GroupId <String>]`: key: id of group
  - `[PrintConnectorId <String>]`: key: id of printConnector
  - `[PrintOperationId <String>]`: key: id of printOperation
  - `[PrintServiceEndpointId <String>]`: key: id of printServiceEndpoint
  - `[PrintServiceId <String>]`: key: id of printService
  - `[PrintTaskDefinitionId <String>]`: key: id of printTaskDefinition
  - `[PrintTaskId <String>]`: key: id of printTask
  - `[PrintTaskTriggerId <String>]`: key: id of printTaskTrigger
  - `[PrinterId <String>]`: key: id of printer
  - `[PrinterShareId <String>]`: key: id of printerShare
  - `[UserId <String>]`: key: id of user

## RELATED LINKS

