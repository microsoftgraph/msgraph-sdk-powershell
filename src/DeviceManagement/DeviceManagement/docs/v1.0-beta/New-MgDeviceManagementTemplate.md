---
external help file:
Module Name: Microsoft.Graph.DeviceManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement/new-mgdevicemanagementtemplate
schema: 2.0.0
---

# New-MgDeviceManagementTemplate

## SYNOPSIS
Create new navigation property to templates for deviceManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementTemplate [-AdditionalProperties <Hashtable>]
 [-Categories <IMicrosoftGraphDeviceManagementTemplateSettingCategory[]>] [-Description <String>]
 [-DisplayName <String>] [-Id <String>] [-IntentCount <Int32>] [-IsDeprecated]
 [-MigratableTo <IMicrosoftGraphDeviceManagementTemplate[]>] [-PlatformType <PolicyPlatformType>]
 [-PublishedDateTime <DateTime>] [-Settings <IMicrosoftGraphDeviceManagementSettingInstance[]>]
 [-TemplateSubtype <DeviceManagementTemplateSubtype>] [-TemplateType <DeviceManagementTemplateType>]
 [-VersionInfo <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementTemplate -BodyParameter <IMicrosoftGraphDeviceManagementTemplate> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to templates for deviceManagement

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
Entity that represents a defined collection of device settings
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementTemplate
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Categories
Collection of setting categories within the template
To construct, please use Get-Help -Online and see NOTES section for CATEGORIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementTemplateSettingCategory[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
The template's description

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

### -DisplayName
The template's display name

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

### -IntentCount
Number of Intents created from this template.

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

### -IsDeprecated
The template is deprecated or not.
Intents cannot be created from a deprecated template.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MigratableTo
Collection of templates this template can migrate to
To construct, please use Get-Help -Online and see NOTES section for MIGRATABLETO properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementTemplate[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PlatformType
Supported platform types for policies.

```yaml
Type: Microsoft.Graph.PowerShell.Support.PolicyPlatformType
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PublishedDateTime
When the template was published

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Settings
Collection of all settings this template has
To construct, please use Get-Help -Online and see NOTES section for SETTINGS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementSettingInstance[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TemplateSubtype
Template subtype

```yaml
Type: Microsoft.Graph.PowerShell.Support.DeviceManagementTemplateSubtype
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TemplateType
Template type

```yaml
Type: Microsoft.Graph.PowerShell.Support.DeviceManagementTemplateType
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VersionInfo
The template's version information

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementTemplate

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementTemplate

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphDeviceManagementTemplate>: Entity that represents a defined collection of device settings
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[Categories <IMicrosoftGraphDeviceManagementTemplateSettingCategory[]>]`: Collection of setting categories within the template
    - `[DisplayName <String>]`: The category name
    - `[HasRequiredSetting <Boolean?>]`: The category contains top level required setting
    - `[SettingDefinitions <IMicrosoftGraphDeviceManagementSettingDefinition[]>]`: The setting definitions this category contains
      - `[Id <String>]`: 
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
      - `[ValueType <DeviceManangementIntentValueType?>]`: deviceManangementIntentValueType
    - `[Id <String>]`: 
    - `[RecommendedSettings <IMicrosoftGraphDeviceManagementSettingInstance[]>]`: The settings this category contains
      - `[Id <String>]`: 
      - `[DefinitionId <String>]`: The ID of the setting definition for this instance
      - `[ValueJson <String>]`: JSON representation of the value
  - `[Description <String>]`: The template's description
  - `[DisplayName <String>]`: The template's display name
  - `[IntentCount <Int32?>]`: Number of Intents created from this template.
  - `[IsDeprecated <Boolean?>]`: The template is deprecated or not. Intents cannot be created from a deprecated template.
  - `[MigratableTo <IMicrosoftGraphDeviceManagementTemplate[]>]`: Collection of templates this template can migrate to
  - `[PlatformType <PolicyPlatformType?>]`: Supported platform types for policies.
  - `[PublishedDateTime <DateTime?>]`: When the template was published
  - `[Settings <IMicrosoftGraphDeviceManagementSettingInstance[]>]`: Collection of all settings this template has
  - `[TemplateSubtype <DeviceManagementTemplateSubtype?>]`: Template subtype
  - `[TemplateType <DeviceManagementTemplateType?>]`: Template type
  - `[VersionInfo <String>]`: The template's version information

CATEGORIES <IMicrosoftGraphDeviceManagementTemplateSettingCategory[]>: Collection of setting categories within the template
  - `[DisplayName <String>]`: The category name
  - `[HasRequiredSetting <Boolean?>]`: The category contains top level required setting
  - `[SettingDefinitions <IMicrosoftGraphDeviceManagementSettingDefinition[]>]`: The setting definitions this category contains
    - `[Id <String>]`: 
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
    - `[ValueType <DeviceManangementIntentValueType?>]`: deviceManangementIntentValueType
  - `[Id <String>]`: 
  - `[RecommendedSettings <IMicrosoftGraphDeviceManagementSettingInstance[]>]`: The settings this category contains
    - `[Id <String>]`: 
    - `[DefinitionId <String>]`: The ID of the setting definition for this instance
    - `[ValueJson <String>]`: JSON representation of the value

MIGRATABLETO <IMicrosoftGraphDeviceManagementTemplate[]>: Collection of templates this template can migrate to
  - `[Id <String>]`: 
  - `[Categories <IMicrosoftGraphDeviceManagementTemplateSettingCategory[]>]`: Collection of setting categories within the template
    - `[DisplayName <String>]`: The category name
    - `[HasRequiredSetting <Boolean?>]`: The category contains top level required setting
    - `[SettingDefinitions <IMicrosoftGraphDeviceManagementSettingDefinition[]>]`: The setting definitions this category contains
      - `[Id <String>]`: 
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
      - `[ValueType <DeviceManangementIntentValueType?>]`: deviceManangementIntentValueType
    - `[Id <String>]`: 
    - `[RecommendedSettings <IMicrosoftGraphDeviceManagementSettingInstance[]>]`: The settings this category contains
      - `[Id <String>]`: 
      - `[DefinitionId <String>]`: The ID of the setting definition for this instance
      - `[ValueJson <String>]`: JSON representation of the value
  - `[Description <String>]`: The template's description
  - `[DisplayName <String>]`: The template's display name
  - `[IntentCount <Int32?>]`: Number of Intents created from this template.
  - `[IsDeprecated <Boolean?>]`: The template is deprecated or not. Intents cannot be created from a deprecated template.
  - `[MigratableTo <IMicrosoftGraphDeviceManagementTemplate[]>]`: Collection of templates this template can migrate to
  - `[PlatformType <PolicyPlatformType?>]`: Supported platform types for policies.
  - `[PublishedDateTime <DateTime?>]`: When the template was published
  - `[Settings <IMicrosoftGraphDeviceManagementSettingInstance[]>]`: Collection of all settings this template has
  - `[TemplateSubtype <DeviceManagementTemplateSubtype?>]`: Template subtype
  - `[TemplateType <DeviceManagementTemplateType?>]`: Template type
  - `[VersionInfo <String>]`: The template's version information

SETTINGS <IMicrosoftGraphDeviceManagementSettingInstance[]>: Collection of all settings this template has
  - `[Id <String>]`: 
  - `[DefinitionId <String>]`: The ID of the setting definition for this instance
  - `[ValueJson <String>]`: JSON representation of the value

## RELATED LINKS

