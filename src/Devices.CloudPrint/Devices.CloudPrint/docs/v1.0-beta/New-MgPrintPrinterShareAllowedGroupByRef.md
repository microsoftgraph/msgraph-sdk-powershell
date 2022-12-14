---
external help file:
Module Name: Microsoft.Graph.Beta.Devices.CloudPrint
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.devices.cloudprint/new-mgprintprintershareallowedgroupbyref
schema: 2.0.0
---

# New-MgBetaPrintPrinterShareAllowedGroupByRef

## SYNOPSIS
Create new navigation property ref to allowedGroups for print

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaPrintPrinterShareAllowedGroupByRef -PrinterShareId <String> [-AdditionalProperties <Hashtable>]
 [-OdataId <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgBetaPrintPrinterShareAllowedGroupByRef -PrinterShareId <String> -BodyParameter <IReferenceCreate>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgBetaPrintPrinterShareAllowedGroupByRef -InputObject <IDevicesCloudPrintIdentity>
 -BodyParameter <IReferenceCreate> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgBetaPrintPrinterShareAllowedGroupByRef -InputObject <IDevicesCloudPrintIdentity>
 [-AdditionalProperties <Hashtable>] [-OdataId <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property ref to allowedGroups for print

## EXAMPLES

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

### -BodyParameter
.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IReferenceCreate
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
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IDevicesCloudPrintIdentity
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -OdataId
.

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

### -PrinterShareId
key: id of printerShare

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

### Microsoft.Graph.Beta.PowerShell.Models.IDevicesCloudPrintIdentity

### Microsoft.Graph.Beta.PowerShell.Models.IReferenceCreate

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IReferenceCreate>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[OdataId <String>]`: 

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

