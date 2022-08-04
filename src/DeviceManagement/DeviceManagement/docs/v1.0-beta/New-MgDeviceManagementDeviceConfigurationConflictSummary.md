---
external help file:
Module Name: Microsoft.Graph.DeviceManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement/new-mgdevicemanagementdeviceconfigurationconflictsummary
schema: 2.0.0
---

# New-MgDeviceManagementDeviceConfigurationConflictSummary

## SYNOPSIS
Create new navigation property to deviceConfigurationConflictSummary for deviceManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementDeviceConfigurationConflictSummary [-AdditionalProperties <Hashtable>]
 [-ConflictingDeviceConfigurations <IMicrosoftGraphSettingSource[]>] [-ContributingSettings <String[]>]
 [-DeviceCheckinsImpacted <Int32>] [-Id <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementDeviceConfigurationConflictSummary
 -BodyParameter <IMicrosoftGraphDeviceConfigurationConflictSummary> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to deviceConfigurationConflictSummary for deviceManagement

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
Conflict summary for a set of device configuration policies.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceConfigurationConflictSummary
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ConflictingDeviceConfigurations
The set of policies in conflict with the given setting
To construct, please use Get-Help -Online and see NOTES section for CONFLICTINGDEVICECONFIGURATIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSettingSource[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ContributingSettings
The set of settings in conflict with the given policies

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceCheckinsImpacted
The count of checkins impacted by the conflicting policies and settings

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
.

```yaml
Type: System.String
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceConfigurationConflictSummary

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceConfigurationConflictSummary

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphDeviceConfigurationConflictSummary>: Conflict summary for a set of device configuration policies.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[ConflictingDeviceConfigurations <IMicrosoftGraphSettingSource[]>]`: The set of policies in conflict with the given setting
    - `[DisplayName <String>]`: Not yet documented
    - `[Id <String>]`: Not yet documented
    - `[SourceType <String>]`: settingSourceType
  - `[ContributingSettings <String[]>]`: The set of settings in conflict with the given policies
  - `[DeviceCheckinsImpacted <Int32?>]`: The count of checkins impacted by the conflicting policies and settings

CONFLICTINGDEVICECONFIGURATIONS <IMicrosoftGraphSettingSource[]>: The set of policies in conflict with the given setting
  - `[DisplayName <String>]`: Not yet documented
  - `[Id <String>]`: Not yet documented
  - `[SourceType <String>]`: settingSourceType

## RELATED LINKS

