---
external help file: Microsoft.Graph.Devices.CloudPrint-help.xml
Module Name: Microsoft.Graph.Devices.CloudPrint
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.cloudprint/new-mgprintprintersharebyref
schema: 2.0.0
---

# New-MgPrintPrinterShareByRef

## SYNOPSIS
Create new navigation property ref to shares for print

## SYNTAX

### CreateExpanded (Default)
```
New-MgPrintPrinterShareByRef -PrinterId <String> [-AdditionalProperties <Hashtable>] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### Create
```
New-MgPrintPrinterShareByRef -PrinterId <String> -BodyParameter <Hashtable> [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgPrintPrinterShareByRef -InputObject <IDevicesCloudPrintIdentity> [-AdditionalProperties <Hashtable>]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgPrintPrinterShareByRef -InputObject <IDevicesCloudPrintIdentity> -BodyParameter <Hashtable> [-WhatIf]
 [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property ref to shares for print

## EXAMPLES

### EXAMPLE 1
```
{{ Add code here }}
```

{{ Add output here }}

### EXAMPLE 2
```
{{ Add code here }}
```

{{ Add output here }}

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
.

```yaml
Type: Hashtable
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: IDevicesCloudPrintIdentity
Parameter Sets: CreateViaIdentityExpanded, CreateViaIdentity
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
Type: String
Parameter Sets: CreateExpanded, Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: SwitchParameter
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
Type: SwitchParameter
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

### Microsoft.Graph.PowerShell.Models.IDevicesCloudPrintIdentity
### System.Collections.Hashtable
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IPaths12CppzkPrintPrintersPrinterIdSharesRefPostResponses201ContentApplicationJsonSchema
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT \<IDevicesCloudPrintIdentity\>: Identity Parameter
  \[GroupId \<String\>\]: 
  \[PeriodEnd \<DateTime?\>\]: 
  \[PeriodStart \<DateTime?\>\]: 
  \[PrintConnectorId \<String\>\]: key: id of printConnector
  \[PrintIdentityId \<String\>\]: key: id of printIdentity
  \[PrintOperationId \<String\>\]: key: id of printOperation
  \[PrintServiceEndpointId \<String\>\]: key: id of printServiceEndpoint
  \[PrintServiceId \<String\>\]: key: id of printService
  \[PrintTaskDefinitionId \<String\>\]: key: id of printTaskDefinition
  \[PrintTaskId \<String\>\]: key: id of printTask
  \[PrintTaskTriggerId \<String\>\]: key: id of printTaskTrigger
  \[PrintUserIdentityId \<String\>\]: key: id of printUserIdentity
  \[PrinterId \<String\>\]: key: id of printer
  \[PrinterId1 \<String\>\]: 
  \[PrinterShareId \<String\>\]: key: id of printerShare
  \[ReportRootId \<String\>\]: key: id of reportRoot
  \[TimeSpanInMinutes \<Int32?\>\]: 
  \[TopListsSize \<Int32?\>\]: 
  \[UserId \<String\>\]:

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.cloudprint/new-mgprintprintersharebyref](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.cloudprint/new-mgprintprintersharebyref)

