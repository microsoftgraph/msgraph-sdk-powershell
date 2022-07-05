---
external help file:
Module Name: Microsoft.Graph.DeviceManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement/new-mgdevicemanagementcompliancepolicy
schema: 2.0.0
---

# New-MgDeviceManagementCompliancePolicy

## SYNOPSIS
Create new navigation property to compliancePolicies for deviceManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementCompliancePolicy [-AdditionalProperties <Hashtable>]
 [-Assignments <IMicrosoftGraphDeviceManagementConfigurationPolicyAssignment[]>] [-CreatedDateTime <DateTime>]
 [-CreationSource <String>] [-Description <String>] [-Id <String>] [-IsAssigned]
 [-LastModifiedDateTime <DateTime>] [-Name <String>] [-Platforms <DeviceManagementConfigurationPlatforms>]
 [-RoleScopeTagIds <String[]>]
 [-ScheduledActionsForRule <IMicrosoftGraphDeviceManagementComplianceScheduledActionForRule[]>]
 [-SettingCount <Int32>] [-Settings <IMicrosoftGraphDeviceManagementConfigurationSetting[]>]
 [-Technologies <DeviceManagementConfigurationTechnologies>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementCompliancePolicy -BodyParameter <IMicrosoftGraphDeviceManagementCompliancePolicy>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to compliancePolicies for deviceManagement

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

### -Assignments
Policy assignments
To construct, please use Get-Help -Online and see NOTES section for ASSIGNMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementConfigurationPolicyAssignment[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
Device Management Compliance Policy
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementCompliancePolicy
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedDateTime
Policy creation date and time.
This property is read-only.

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

### -CreationSource
Policy creation source

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
Policy description

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

### -IsAssigned
Policy assignment status.
This property is read-only.

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

### -LastModifiedDateTime
Policy last modification date and time.
This property is read-only.

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

### -Name
Policy name

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

### -Platforms
Supported platform types.

```yaml
Type: Microsoft.Graph.PowerShell.Support.DeviceManagementConfigurationPlatforms
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RoleScopeTagIds
List of Scope Tags for this Entity instance.

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

### -ScheduledActionsForRule
The list of scheduled action for this rule
To construct, please use Get-Help -Online and see NOTES section for SCHEDULEDACTIONSFORRULE properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementComplianceScheduledActionForRule[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SettingCount
Number of settings.
This property is read-only.

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

### -Settings
Policy settings
To construct, please use Get-Help -Online and see NOTES section for SETTINGS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementConfigurationSetting[]
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
Type: Microsoft.Graph.PowerShell.Support.DeviceManagementConfigurationTechnologies
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementCompliancePolicy

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementCompliancePolicy

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ASSIGNMENTS <IMicrosoftGraphDeviceManagementConfigurationPolicyAssignment[]>: Policy assignments
  - `[Id <String>]`: 
  - `[Source <DeviceAndAppManagementAssignmentSource?>]`: Represents source of assignment.
  - `[SourceId <String>]`: The identifier of the source of the assignment.
  - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget1>]`: Base type for assignment targets.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
    - `[DeviceAndAppManagementAssignmentFilterType <DeviceAndAppManagementAssignmentFilterType?>]`: Represents type of the assignment filter.

BODYPARAMETER <IMicrosoftGraphDeviceManagementCompliancePolicy>: Device Management Compliance Policy
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[Assignments <IMicrosoftGraphDeviceManagementConfigurationPolicyAssignment[]>]`: Policy assignments
    - `[Id <String>]`: 
    - `[Source <DeviceAndAppManagementAssignmentSource?>]`: Represents source of assignment.
    - `[SourceId <String>]`: The identifier of the source of the assignment.
    - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget1>]`: Base type for assignment targets.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
      - `[DeviceAndAppManagementAssignmentFilterType <DeviceAndAppManagementAssignmentFilterType?>]`: Represents type of the assignment filter.
  - `[CreatedDateTime <DateTime?>]`: Policy creation date and time. This property is read-only.
  - `[CreationSource <String>]`: Policy creation source
  - `[Description <String>]`: Policy description
  - `[IsAssigned <Boolean?>]`: Policy assignment status. This property is read-only.
  - `[LastModifiedDateTime <DateTime?>]`: Policy last modification date and time. This property is read-only.
  - `[Name <String>]`: Policy name
  - `[Platforms <DeviceManagementConfigurationPlatforms?>]`: Supported platform types.
  - `[RoleScopeTagIds <String[]>]`: List of Scope Tags for this Entity instance.
  - `[ScheduledActionsForRule <IMicrosoftGraphDeviceManagementComplianceScheduledActionForRule[]>]`: The list of scheduled action for this rule
    - `[Id <String>]`: 
    - `[RuleName <String>]`: Name of the rule which this scheduled action applies to.
    - `[ScheduledActionConfigurations <IMicrosoftGraphDeviceManagementComplianceActionItem[]>]`: The list of scheduled action configurations for this compliance policy. This collection can contain a maximum of 100 elements.
      - `[Id <String>]`: 
      - `[ActionType <DeviceManagementComplianceActionType?>]`: Scheduled Action Type Enum
      - `[GracePeriodHours <Int32?>]`: Number of hours to wait till the action will be enforced. Valid values 0 to 8760
      - `[NotificationMessageCcList <String[]>]`: A list of group IDs to speicify who to CC this notification message to. This collection can contain a maximum of 100 elements.
      - `[NotificationTemplateId <String>]`: What notification Message template to use
  - `[SettingCount <Int32?>]`: Number of settings. This property is read-only.
  - `[Settings <IMicrosoftGraphDeviceManagementConfigurationSetting[]>]`: Policy settings
    - `[Id <String>]`: 
    - `[SettingDefinitions <IMicrosoftGraphDeviceManagementConfigurationSettingDefinition[]>]`: List of related Setting Definitions. This property is read-only.
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
    - `[SettingInstance <IMicrosoftGraphDeviceManagementConfigurationSettingInstance>]`: Setting instance within policy
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[SettingDefinitionId <String>]`: Setting Definition Id
      - `[SettingInstanceTemplateReference <IMicrosoftGraphDeviceManagementConfigurationSettingInstanceTemplateReference>]`: Setting instance template reference information
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[SettingInstanceTemplateId <String>]`: Setting instance template id
  - `[Technologies <DeviceManagementConfigurationTechnologies?>]`: Describes which technology this setting can be deployed with

SCHEDULEDACTIONSFORRULE <IMicrosoftGraphDeviceManagementComplianceScheduledActionForRule[]>: The list of scheduled action for this rule
  - `[Id <String>]`: 
  - `[RuleName <String>]`: Name of the rule which this scheduled action applies to.
  - `[ScheduledActionConfigurations <IMicrosoftGraphDeviceManagementComplianceActionItem[]>]`: The list of scheduled action configurations for this compliance policy. This collection can contain a maximum of 100 elements.
    - `[Id <String>]`: 
    - `[ActionType <DeviceManagementComplianceActionType?>]`: Scheduled Action Type Enum
    - `[GracePeriodHours <Int32?>]`: Number of hours to wait till the action will be enforced. Valid values 0 to 8760
    - `[NotificationMessageCcList <String[]>]`: A list of group IDs to speicify who to CC this notification message to. This collection can contain a maximum of 100 elements.
    - `[NotificationTemplateId <String>]`: What notification Message template to use

SETTINGS <IMicrosoftGraphDeviceManagementConfigurationSetting[]>: Policy settings
  - `[Id <String>]`: 
  - `[SettingDefinitions <IMicrosoftGraphDeviceManagementConfigurationSettingDefinition[]>]`: List of related Setting Definitions. This property is read-only.
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
  - `[SettingInstance <IMicrosoftGraphDeviceManagementConfigurationSettingInstance>]`: Setting instance within policy
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[SettingDefinitionId <String>]`: Setting Definition Id
    - `[SettingInstanceTemplateReference <IMicrosoftGraphDeviceManagementConfigurationSettingInstanceTemplateReference>]`: Setting instance template reference information
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[SettingInstanceTemplateId <String>]`: Setting instance template id

## RELATED LINKS

