---
external help file:
Module Name: Microsoft.Graph.Beta.DeviceManagement
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.devicemanagement/new-mgbetadevicemanagementcompliancesetting
schema: 2.0.0
---

# New-MgBetaDeviceManagementComplianceSetting

## SYNOPSIS
Create new navigation property to complianceSettings for deviceManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaDeviceManagementComplianceSetting [-AccessTypes <String>] [-AdditionalProperties <Hashtable>]
 [-Applicability <IMicrosoftGraphDeviceManagementConfigurationSettingApplicability>] [-BaseUri <String>]
 [-CategoryId <String>] [-Description <String>] [-DisplayName <String>] [-HelpText <String>] [-Id <String>]
 [-InfoUrls <String[]>] [-Keywords <String[]>] [-Name <String>]
 [-Occurrence <IMicrosoftGraphDeviceManagementConfigurationSettingOccurrence>] [-OffsetUri <String>]
 [-ReferredSettingInformationList <IMicrosoftGraphDeviceManagementConfigurationReferredSettingInformation[]>]
 [-ResponseHeadersVariable <String>] [-RootDefinitionId <String>]
 [-SettingUsage <DeviceManagementConfigurationSettingUsage>]
 [-UxBehavior <DeviceManagementConfigurationControlType>] [-Version <String>]
 [-Visibility <DeviceManagementConfigurationSettingVisibility>] [-Headers <IDictionary>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgBetaDeviceManagementComplianceSetting
 -BodyParameter <IMicrosoftGraphDeviceManagementConfigurationSettingDefinition>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to complianceSettings for deviceManagement

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
To construct, see NOTES section for APPLICABILITY properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDeviceManagementConfigurationSettingApplicability
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
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDeviceManagementConfigurationSettingDefinition
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CategoryId
Specify category in which the setting is under.
Support $filters.

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
Description of the setting.

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
Name of the setting.
For example: Allow Toast.

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

### -HelpText
Help text of the setting.
Give more details of the setting.

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

### -InfoUrls
List of links more info for the setting can be found at.

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
To construct, see NOTES section for OCCURRENCE properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDeviceManagementConfigurationSettingOccurrence
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
To construct, see NOTES section for REFERREDSETTINGINFORMATIONLIST properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDeviceManagementConfigurationReferredSettingInformation[]
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

### -RootDefinitionId
Root setting definition id if the setting is a child setting.

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
Type: Microsoft.Graph.Beta.PowerShell.Support.DeviceManagementConfigurationSettingUsage
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
Type: Microsoft.Graph.Beta.PowerShell.Support.DeviceManagementConfigurationControlType
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
Type: Microsoft.Graph.Beta.PowerShell.Support.DeviceManagementConfigurationSettingVisibility
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDeviceManagementConfigurationSettingDefinition

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDeviceManagementConfigurationSettingDefinition

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`APPLICABILITY <IMicrosoftGraphDeviceManagementConfigurationSettingApplicability>`: deviceManagementConfigurationSettingApplicability
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Description <String>]`: description of the setting
  - `[DeviceMode <DeviceManagementConfigurationDeviceMode?>]`: Describes applicability for the mode the device is in
  - `[Platform <DeviceManagementConfigurationPlatforms?>]`: Supported platform types.
  - `[Technologies <DeviceManagementConfigurationTechnologies?>]`: Describes which technology this setting can be deployed with

`BODYPARAMETER <IMicrosoftGraphDeviceManagementConfigurationSettingDefinition>`: deviceManagementConfigurationSettingDefinition
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AccessTypes <String>]`: deviceManagementConfigurationSettingAccessTypes
  - `[Applicability <IMicrosoftGraphDeviceManagementConfigurationSettingApplicability>]`: deviceManagementConfigurationSettingApplicability
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Description <String>]`: description of the setting
    - `[DeviceMode <DeviceManagementConfigurationDeviceMode?>]`: Describes applicability for the mode the device is in
    - `[Platform <DeviceManagementConfigurationPlatforms?>]`: Supported platform types.
    - `[Technologies <DeviceManagementConfigurationTechnologies?>]`: Describes which technology this setting can be deployed with
  - `[BaseUri <String>]`: Base CSP Path
  - `[CategoryId <String>]`: Specify category in which the setting is under. Support $filters.
  - `[Description <String>]`: Description of the setting.
  - `[DisplayName <String>]`: Name of the setting. For example: Allow Toast.
  - `[HelpText <String>]`: Help text of the setting. Give more details of the setting.
  - `[InfoUrls <String[]>]`: List of links more info for the setting can be found at.
  - `[Keywords <String[]>]`: Tokens which to search settings on
  - `[Name <String>]`: Name of the item
  - `[Occurrence <IMicrosoftGraphDeviceManagementConfigurationSettingOccurrence>]`: deviceManagementConfigurationSettingOccurrence
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[MaxDeviceOccurrence <Int32?>]`: Maximum times setting can be set on device.
    - `[MinDeviceOccurrence <Int32?>]`: Minimum times setting can be set on device. A MinDeviceOccurrence of 0 means setting is optional
  - `[OffsetUri <String>]`: Offset CSP Path from Base
  - `[ReferredSettingInformationList <IMicrosoftGraphDeviceManagementConfigurationReferredSettingInformation[]>]`: List of referred setting information.
    - `[SettingDefinitionId <String>]`: Setting definition id that is being referred to a setting. Applicable for reusable setting
  - `[RootDefinitionId <String>]`: Root setting definition id if the setting is a child setting.
  - `[SettingUsage <DeviceManagementConfigurationSettingUsage?>]`: Supported setting types
  - `[UxBehavior <DeviceManagementConfigurationControlType?>]`: Setting control type representation in the UX
  - `[Version <String>]`: Item Version
  - `[Visibility <DeviceManagementConfigurationSettingVisibility?>]`: Supported setting types

`OCCURRENCE <IMicrosoftGraphDeviceManagementConfigurationSettingOccurrence>`: deviceManagementConfigurationSettingOccurrence
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[MaxDeviceOccurrence <Int32?>]`: Maximum times setting can be set on device.
  - `[MinDeviceOccurrence <Int32?>]`: Minimum times setting can be set on device. A MinDeviceOccurrence of 0 means setting is optional

`REFERREDSETTINGINFORMATIONLIST <IMicrosoftGraphDeviceManagementConfigurationReferredSettingInformation[]>`: List of referred setting information.
  - `[SettingDefinitionId <String>]`: Setting definition id that is being referred to a setting. Applicable for reusable setting

## RELATED LINKS

