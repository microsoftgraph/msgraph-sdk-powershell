---
external help file: Microsoft.Graph.Devices.CloudPrint-help.xml
Module Name: Microsoft.Graph.Devices.CloudPrint
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.cloudprint/new-mgprintoperation
schema: 2.0.0
---

# New-MgPrintOperation

## SYNOPSIS
Create new navigation property to operations for print

## SYNTAX

### CreateExpanded (Default)
```
New-MgPrintOperation [-AdditionalProperties <Hashtable>] [-CreatedDateTime <DateTime>] [-Id <String>]
 [-Status <IMicrosoftGraphPrintOperationStatus>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Create
```
New-MgPrintOperation -BodyParameter <IMicrosoftGraphPrintOperation> [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to operations for print

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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
printOperation
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphPrintOperation
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedDateTime
.

```yaml
Type: DateTime
Parameter Sets: CreateExpanded
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
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Status
printOperationStatus
To construct, see NOTES section for STATUS properties and create a hash table.

```yaml
Type: IMicrosoftGraphPrintOperationStatus
Parameter Sets: CreateExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrintOperation
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrintOperation
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

BODYPARAMETER \<IMicrosoftGraphPrintOperation\>: printOperation
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[CreatedDateTime \<DateTime?\>\]: 
  \[Status \<IMicrosoftGraphPrintOperationStatus\>\]: printOperationStatus
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Description \<String\>\]: 
    \[State \<String\>\]: printOperationProcessingState

STATUS \<IMicrosoftGraphPrintOperationStatus\>: printOperationStatus
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Description \<String\>\]: 
  \[State \<String\>\]: printOperationProcessingState

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.cloudprint/new-mgprintoperation](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.cloudprint/new-mgprintoperation)

