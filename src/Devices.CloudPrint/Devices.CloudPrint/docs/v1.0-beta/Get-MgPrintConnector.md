---
external help file:
Module Name: Microsoft.Graph.Beta.Devices.CloudPrint
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.devices.cloudprint/get-mgprintconnector
schema: 2.0.0
---

# Get-MgBetaPrintConnector

## SYNOPSIS
The list of available print connectors.

## SYNTAX

### List (Default)
```
Get-MgBetaPrintConnector [-ExpandProperty <String[]>] [-Filter <String>] [-Property <String[]>] [-Search <String>]
 [-Skip <Int32>] [-Sort <String[]>] [-Top <Int32>] [-All] [-CountVariable <String>] [-PageSize <Int32>]
 [<CommonParameters>]
```

### Get
```
Get-MgBetaPrintConnector -PrintConnectorId <String> [-ExpandProperty <String[]>] [-Property <String[]>]
 [<CommonParameters>]
```

### GetViaIdentity
```
Get-MgBetaPrintConnector -InputObject <IDevicesCloudPrintIdentity> [-ExpandProperty <String[]>]
 [-Property <String[]>] [<CommonParameters>]
```

## DESCRIPTION
The list of available print connectors.

## EXAMPLES

### Example 1: Using the Get-MgBetaPrintConnector Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Devices.CloudPrint
Get-MgBetaPrintConnector -PrintConnectorId $printConnectorId
```

This example shows how to use the Get-MgBetaPrintConnector Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Using the Get-MgBetaPrintConnector Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Devices.CloudPrint
Get-MgBetaPrintConnector
```

This example shows how to use the Get-MgBetaPrintConnector Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -All
List all pages.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: List
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CountVariable
Specifies a count of the total number of items in a collection.
By default, this variable will be set in the global scope.

```yaml
Type: System.String
Parameter Sets: List
Aliases: CV

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExpandProperty
Expand related entities

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases: Expand

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Filter
Filter items by property values

```yaml
Type: System.String
Parameter Sets: List
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IDevicesCloudPrintIdentity
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -PageSize
Sets the page size of results.

```yaml
Type: System.Int32
Parameter Sets: List
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PrintConnectorId
key: id of printConnector

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

### -Property
Select properties to be returned

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases: Select

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Search
Search items by search phrases

```yaml
Type: System.String
Parameter Sets: List
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Skip
Skip the first n items

```yaml
Type: System.Int32
Parameter Sets: List
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Sort
Order items by property values

```yaml
Type: System.String[]
Parameter Sets: List
Aliases: OrderBy

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Top
Show only the first n items

```yaml
Type: System.Int32
Parameter Sets: List
Aliases: Limit

Required: False
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPrintConnector

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

