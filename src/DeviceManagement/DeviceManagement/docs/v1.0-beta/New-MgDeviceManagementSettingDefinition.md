---
external help file: Microsoft.Graph.DeviceManagement-help.xml
Module Name: Microsoft.Graph.DeviceManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement/new-mgdevicemanagementsettingdefinition
schema: 2.0.0
---

# New-MgDeviceManagementSettingDefinition

## SYNOPSIS
The device management intent setting definitions

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementSettingDefinition [-AdditionalProperties <Hashtable>]
 [-Constraints <IMicrosoftGraphDeviceManagementConstraint[]>]
 [-Dependencies <IMicrosoftGraphDeviceManagementSettingDependency[]>] [-Description <String>]
 [-DisplayName <String>] [-DocumentationUrl <String>] [-HeaderSubtitle <String>] [-HeaderTitle <String>]
 [-Id <String>] [-IsTopLevel] [-Keywords <String[]>] [-PlaceholderText <String>] [-ValueType <String>]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementSettingDefinition -BodyParameter <IMicrosoftGraphDeviceManagementSettingDefinition>
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
The device management intent setting definitions

## EXAMPLES

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
Entity representing the defintion for a given setting
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphDeviceManagementSettingDefinition
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Constraints
Collection of constraints for the setting value

```yaml
Type: IMicrosoftGraphDeviceManagementConstraint[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Dependencies
Collection of dependencies on other settings
To construct, see NOTES section for DEPENDENCIES properties and create a hash table.

```yaml
Type: IMicrosoftGraphDeviceManagementSettingDependency[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
The setting's description

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

### -DisplayName
The setting's display name

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

### -DocumentationUrl
Url to setting documentation

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

### -HeaderSubtitle
subtitle of the setting header for more details about the category/section

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

### -HeaderTitle
title of the setting header represents a category/section of a setting/settings

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

### -IsTopLevel
If the setting is top level, it can be configured without the need to be wrapped in a collection or complex setting

```yaml
Type: SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Keywords
Keywords associated with the setting

```yaml
Type: String[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PlaceholderText
Placeholder text as an example of valid input

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

### -ValueType
deviceManangementIntentValueType

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementSettingDefinition
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementSettingDefinition
## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphDeviceManagementSettingDefinition>: Entity representing the defintion for a given setting
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[Constraints <IMicrosoftGraphDeviceManagementConstraint[]>]`: Collection of constraints for the setting value
  - `[Dependencies <IMicrosoftGraphDeviceManagementSettingDependency[]>]`: Collection of dependencies on other settings
    - `[Constraints <IMicrosoftGraphDeviceManagementConstraint[]>]`: Collection of constraints for the dependency setting value
    - `[DefinitionId <String>]`: The setting definition ID of the setting depended on
  - `[Description <String>]`: The setting's description
  - `[DisplayName <String>]`: The setting's display name
  - `[DocumentationUrl <String>]`: Url to setting documentation
  - `[HeaderSubtitle <String>]`: subtitle of the setting header for more details about the category/section
  - `[HeaderTitle <String>]`: title of the setting header represents a category/section of a setting/settings
  - `[IsTopLevel <Boolean?>]`: If the setting is top level, it can be configured without the need to be wrapped in a collection or complex setting
  - `[Keywords <String[]>]`: Keywords associated with the setting
  - `[PlaceholderText <String>]`: Placeholder text as an example of valid input
  - `[ValueType <String>]`: deviceManangementIntentValueType

DEPENDENCIES <IMicrosoftGraphDeviceManagementSettingDependency[]>: Collection of dependencies on other settings
  - `[Constraints <IMicrosoftGraphDeviceManagementConstraint[]>]`: Collection of constraints for the dependency setting value
  - `[DefinitionId <String>]`: The setting definition ID of the setting depended on

## RELATED LINKS
