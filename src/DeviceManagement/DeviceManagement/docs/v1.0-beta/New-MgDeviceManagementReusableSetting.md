---
external help file:
Module Name: Microsoft.Graph.DeviceManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement/new-mgdevicemanagementreusablesetting
schema: 2.0.0
---

# New-MgDeviceManagementReusableSetting

## SYNOPSIS
Create new navigation property to reusableSettings for deviceManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementReusableSetting [-AccessTypes <String>] [-AdditionalProperties <Hashtable>]
 [-Applicability <IMicrosoftGraphDeviceManagementConfigurationSettingApplicability>] [-BaseUri <String>]
 [-CategoryId <String>] [-Description <String>] [-DisplayName <String>] [-HelpText <String>] [-Id <String>]
 [-InfoUrls <String[]>] [-Keywords <String[]>] [-Name <String>]
 [-Occurrence <IMicrosoftGraphDeviceManagementConfigurationSettingOccurrence>] [-OffsetUri <String>]
 [-ReferredSettingInformationList <IMicrosoftGraphDeviceManagementConfigurationReferredSettingInformation[]>]
 [-RootDefinitionId <String>] [-SettingUsage <DeviceManagementConfigurationSettingUsage>]
 [-UxBehavior <DeviceManagementConfigurationControlType>] [-Version <String>]
 [-Visibility <DeviceManagementConfigurationSettingVisibility>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementReusableSetting
 -BodyParameter <IMicrosoftGraphDeviceManagementConfigurationSettingDefinition> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to reusableSettings for deviceManagement

## EXAMPLES

## PARAMETERS

### -AccessTypes
deviceManagementConfigurationSettingAccessTypes

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

### -Applicability
deviceManagementConfigurationSettingApplicability
To construct, please use Get-Help -Online and see NOTES section for APPLICABILITY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementConfigurationSettingApplicability
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BaseUri
Base CSP Path

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
deviceManagementConfigurationSettingDefinition
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementConfigurationSettingDefinition
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CategoryId
Specifies the area group under which the setting is configured in a specified configuration service provider (CSP)

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

### -Description
Description of the item

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
Display name of the item

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

### -HelpText
Help text of the item

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

### -InfoUrls
List of links more info for the setting can be found at

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

### -Keywords
Tokens which to search settings on

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

### -Name
Name of the item

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

### -Occurrence
deviceManagementConfigurationSettingOccurrence
To construct, please use Get-Help -Online and see NOTES section for OCCURRENCE properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementConfigurationSettingOccurrence
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OffsetUri
Offset CSP Path from Base

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

### -ReferredSettingInformationList
List of referred setting information.
To construct, please use Get-Help -Online and see NOTES section for REFERREDSETTINGINFORMATIONLIST properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementConfigurationReferredSettingInformation[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RootDefinitionId
Root setting definition if the setting is a child setting.

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

### -SettingUsage
Supported setting types

```yaml
Type: Microsoft.Graph.PowerShell.Support.DeviceManagementConfigurationSettingUsage
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UxBehavior
Setting control type representation in the UX

```yaml
Type: Microsoft.Graph.PowerShell.Support.DeviceManagementConfigurationControlType
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Version
Item Version

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

### -Visibility
Supported setting types

```yaml
Type: Microsoft.Graph.PowerShell.Support.DeviceManagementConfigurationSettingVisibility
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementConfigurationSettingDefinition

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementConfigurationSettingDefinition

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


APPLICABILITY <IMicrosoftGraphDeviceManagementConfigurationSettingApplicability>: deviceManagementConfigurationSettingApplicability
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Description <String>]`: description of the setting
  - `[DeviceMode <DeviceManagementConfigurationDeviceMode?>]`: Describes applicability for the mode the device is in
  - `[Platform <DeviceManagementConfigurationPlatforms?>]`: Supported platform types.
  - `[Technologies <DeviceManagementConfigurationTechnologies?>]`: Describes which technology this setting can be deployed with

BODYPARAMETER <IMicrosoftGraphDeviceManagementConfigurationSettingDefinition>: deviceManagementConfigurationSettingDefinition
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
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
    - `[SettingDefinitionId <String>]`: Setting definition id that is being referred to a setting. Applicable for reusable setting
  - `[RootDefinitionId <String>]`: Root setting definition if the setting is a child setting.
  - `[SettingUsage <DeviceManagementConfigurationSettingUsage?>]`: Supported setting types
  - `[UxBehavior <DeviceManagementConfigurationControlType?>]`: Setting control type representation in the UX
  - `[Version <String>]`: Item Version
  - `[Visibility <DeviceManagementConfigurationSettingVisibility?>]`: Supported setting types

OCCURRENCE <IMicrosoftGraphDeviceManagementConfigurationSettingOccurrence>: deviceManagementConfigurationSettingOccurrence
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[MaxDeviceOccurrence <Int32?>]`: Maximum times setting can be set on device.
  - `[MinDeviceOccurrence <Int32?>]`: Minimum times setting can be set on device. A MinDeviceOccurrence of 0 means setting is optional

REFERREDSETTINGINFORMATIONLIST <IMicrosoftGraphDeviceManagementConfigurationReferredSettingInformation[]>: List of referred setting information.
  - `[SettingDefinitionId <String>]`: Setting definition id that is being referred to a setting. Applicable for reusable setting

## RELATED LINKS

