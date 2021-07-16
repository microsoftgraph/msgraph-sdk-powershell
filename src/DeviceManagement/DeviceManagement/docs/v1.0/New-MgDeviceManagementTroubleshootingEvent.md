---
external help file: Microsoft.Graph.DeviceManagement-help.xml
Module Name: Microsoft.Graph.DeviceManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement/new-mgdevicemanagementtroubleshootingevent
schema: 2.0.0
---

# New-MgDeviceManagementTroubleshootingEvent

## SYNOPSIS
The list of troubleshooting events for the tenant.

## SYNTAX

### CreateExpanded1 (Default)
```
New-MgDeviceManagementTroubleshootingEvent [-AdditionalProperties <Hashtable>] [-CorrelationId <String>]
 [-EventDateTime <DateTime>] [-Id <String>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Create1
```
New-MgDeviceManagementTroubleshootingEvent -BodyParameter <IMicrosoftGraphDeviceManagementTroubleshootingEvent>
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
The list of troubleshooting events for the tenant.

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
Event representing an general failure.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphDeviceManagementTroubleshootingEvent
Parameter Sets: Create1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CorrelationId
Id used for tracing the failure in the service.

```yaml
Type: String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EventDateTime
Time when the event occurred .

```yaml
Type: DateTime
Parameter Sets: CreateExpanded1
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
Parameter Sets: CreateExpanded1
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementTroubleshootingEvent
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementTroubleshootingEvent
## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphDeviceManagementTroubleshootingEvent>: Event representing an general failure.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[CorrelationId <String>]`: Id used for tracing the failure in the service.
  - `[EventDateTime <DateTime?>]`: Time when the event occurred .

## RELATED LINKS
