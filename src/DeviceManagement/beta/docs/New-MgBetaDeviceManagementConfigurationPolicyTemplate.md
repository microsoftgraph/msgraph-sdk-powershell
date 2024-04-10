---
external help file:
Module Name: Microsoft.Graph.Beta.DeviceManagement
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.devicemanagement/new-mgbetadevicemanagementconfigurationpolicytemplate
schema: 2.0.0
---

# New-MgBetaDeviceManagementConfigurationPolicyTemplate

## SYNOPSIS
Create new navigation property to configurationPolicyTemplates for deviceManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaDeviceManagementConfigurationPolicyTemplate [-AdditionalProperties <Hashtable>]
 [-AllowUnmanagedSettings] [-BaseId <String>] [-Description <String>] [-DisplayName <String>]
 [-DisplayVersion <String>] [-Id <String>] [-LifecycleState <DeviceManagementTemplateLifecycleState>]
 [-Platforms <DeviceManagementConfigurationPlatforms>] [-ResponseHeadersVariable <String>]
 [-SettingTemplates <IMicrosoftGraphDeviceManagementConfigurationSettingTemplate[]>]
 [-Technologies <DeviceManagementConfigurationTechnologies>]
 [-TemplateFamily <DeviceManagementConfigurationTemplateFamily>] [-Headers <IDictionary>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgBetaDeviceManagementConfigurationPolicyTemplate
 -BodyParameter <IMicrosoftGraphDeviceManagementConfigurationPolicyTemplate>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to configurationPolicyTemplates for deviceManagement

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

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

### -AllowUnmanagedSettings
Allow unmanaged setting templates

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

### -BaseId
Template base identifier

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

### -BodyParameter
Device Management Configuration Policy Template
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDeviceManagementConfigurationPolicyTemplate
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Description
Template description

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
Template display name

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

### -DisplayVersion
Description of template version

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

### -Headers
Optional headers that will be added to the request.

```yaml
Type: System.Collections.IDictionary
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Id
The unique identifier for an entity.
Read-only.

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

### -LifecycleState
Describes current lifecycle state of a template

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Support.DeviceManagementTemplateLifecycleState
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Platforms
Supported platform types.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Support.DeviceManagementConfigurationPlatforms
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResponseHeadersVariable
Optional Response Headers Variable.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: RHV

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SettingTemplates
Setting templates
To construct, see NOTES section for SETTINGTEMPLATES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDeviceManagementConfigurationSettingTemplate[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Technologies
Describes which technology this setting can be deployed with

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Support.DeviceManagementConfigurationTechnologies
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TemplateFamily
Describes the TemplateFamily for the Template entity

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Support.DeviceManagementConfigurationTemplateFamily
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDeviceManagementConfigurationPolicyTemplate

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDeviceManagementConfigurationPolicyTemplate

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphDeviceManagementConfigurationPolicyTemplate>`: Device Management Configuration Policy Template
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AllowUnmanagedSettings <Boolean?>]`: Allow unmanaged setting templates
  - `[BaseId <String>]`: Template base identifier
  - `[Description <String>]`: Template description
  - `[DisplayName <String>]`: Template display name
  - `[DisplayVersion <String>]`: Description of template version
  - `[LifecycleState <DeviceManagementTemplateLifecycleState?>]`: Describes current lifecycle state of a template
  - `[Platforms <DeviceManagementConfigurationPlatforms?>]`: Supported platform types.
  - `[SettingTemplates <IMicrosoftGraphDeviceManagementConfigurationSettingTemplate[]>]`: Setting templates
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[SettingDefinitions <IMicrosoftGraphDeviceManagementConfigurationSettingDefinition[]>]`: List of related Setting Definitions
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[AccessTypes <String>]`: deviceManagementConfigurationSettingAccessTypes
      - `[Applicability <IMicrosoftGraphDeviceManagementConfigurationSettingApplicability>]`: deviceManagementConfigurationSettingApplicability
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Description <String>]`: description of the setting
        - `[DeviceMode <DeviceManagementConfigurationDeviceMode?>]`: Describes applicability for the mode the device is in
        - `[Platform <DeviceManagementConfigurationPlatforms?>]`: Supported platform types.
        - `[Technologies <DeviceManagementConfigurationTechnologies?>]`: Describes which technology this setting can be deployed with
      - `[BaseUri <String>]`: Base CSP Path
      - `[CategoryId <String>]`: Specifies the area group under which the setting is configured in a specified configuration service provider (CSP)
      - `[Description <String>]`: Description of the item
      - `[DisplayName <String>]`: Display name of the item
      - `[HelpText <String>]`: Help text of the item
      - `[InfoUrls <String[]>]`: List of links more info for the setting can be found at
      - `[Keywords <String[]>]`: Tokens which to search settings on
      - `[Name <String>]`: Name of the item
      - `[Occurrence <IMicrosoftGraphDeviceManagementConfigurationSettingOccurrence>]`: deviceManagementConfigurationSettingOccurrence
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[MaxDeviceOccurrence <Int32?>]`: Maximum times setting can be set on device.
        - `[MinDeviceOccurrence <Int32?>]`: Minimum times setting can be set on device. A MinDeviceOccurrence of 0 means setting is optional
      - `[OffsetUri <String>]`: Offset CSP Path from Base
      - `[ReferredSettingInformationList <IMicrosoftGraphDeviceManagementConfigurationReferredSettingInformation[]>]`: List of referred setting information.
        - `[SettingDefinitionId <String>]`: Setting definition id that is being referred to a setting. Applicable for reusable setting.
      - `[RootDefinitionId <String>]`: Root setting definition if the setting is a child setting.
      - `[SettingUsage <DeviceManagementConfigurationSettingUsage?>]`: Supported setting types
      - `[UxBehavior <DeviceManagementConfigurationControlType?>]`: Setting control type representation in the UX
      - `[Version <String>]`: Item Version
      - `[Visibility <DeviceManagementConfigurationSettingVisibility?>]`: Supported setting types
    - `[SettingInstanceTemplate <IMicrosoftGraphDeviceManagementConfigurationSettingInstanceTemplate>]`: Setting Instance Template
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[IsRequired <Boolean?>]`: Indicates if a policy must specify this setting.
      - `[SettingDefinitionId <String>]`: Setting Definition Id
      - `[SettingInstanceTemplateId <String>]`: Setting Instance Template Id
  - `[Technologies <DeviceManagementConfigurationTechnologies?>]`: Describes which technology this setting can be deployed with
  - `[TemplateFamily <DeviceManagementConfigurationTemplateFamily?>]`: Describes the TemplateFamily for the Template entity

`SETTINGTEMPLATES <IMicrosoftGraphDeviceManagementConfigurationSettingTemplate[]>`: Setting templates
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[SettingDefinitions <IMicrosoftGraphDeviceManagementConfigurationSettingDefinition[]>]`: List of related Setting Definitions
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[AccessTypes <String>]`: deviceManagementConfigurationSettingAccessTypes
    - `[Applicability <IMicrosoftGraphDeviceManagementConfigurationSettingApplicability>]`: deviceManagementConfigurationSettingApplicability
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Description <String>]`: description of the setting
      - `[DeviceMode <DeviceManagementConfigurationDeviceMode?>]`: Describes applicability for the mode the device is in
      - `[Platform <DeviceManagementConfigurationPlatforms?>]`: Supported platform types.
      - `[Technologies <DeviceManagementConfigurationTechnologies?>]`: Describes which technology this setting can be deployed with
    - `[BaseUri <String>]`: Base CSP Path
    - `[CategoryId <String>]`: Specifies the area group under which the setting is configured in a specified configuration service provider (CSP)
    - `[Description <String>]`: Description of the item
    - `[DisplayName <String>]`: Display name of the item
    - `[HelpText <String>]`: Help text of the item
    - `[InfoUrls <String[]>]`: List of links more info for the setting can be found at
    - `[Keywords <String[]>]`: Tokens which to search settings on
    - `[Name <String>]`: Name of the item
    - `[Occurrence <IMicrosoftGraphDeviceManagementConfigurationSettingOccurrence>]`: deviceManagementConfigurationSettingOccurrence
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[MaxDeviceOccurrence <Int32?>]`: Maximum times setting can be set on device.
      - `[MinDeviceOccurrence <Int32?>]`: Minimum times setting can be set on device. A MinDeviceOccurrence of 0 means setting is optional
    - `[OffsetUri <String>]`: Offset CSP Path from Base
    - `[ReferredSettingInformationList <IMicrosoftGraphDeviceManagementConfigurationReferredSettingInformation[]>]`: List of referred setting information.
      - `[SettingDefinitionId <String>]`: Setting definition id that is being referred to a setting. Applicable for reusable setting.
    - `[RootDefinitionId <String>]`: Root setting definition if the setting is a child setting.
    - `[SettingUsage <DeviceManagementConfigurationSettingUsage?>]`: Supported setting types
    - `[UxBehavior <DeviceManagementConfigurationControlType?>]`: Setting control type representation in the UX
    - `[Version <String>]`: Item Version
    - `[Visibility <DeviceManagementConfigurationSettingVisibility?>]`: Supported setting types
  - `[SettingInstanceTemplate <IMicrosoftGraphDeviceManagementConfigurationSettingInstanceTemplate>]`: Setting Instance Template
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[IsRequired <Boolean?>]`: Indicates if a policy must specify this setting.
    - `[SettingDefinitionId <String>]`: Setting Definition Id
    - `[SettingInstanceTemplateId <String>]`: Setting Instance Template Id

## RELATED LINKS

