---
external help file:
Module Name: Microsoft.Graph.DeviceManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement/new-mgdevicemanagementintent
schema: 2.0.0
---

# New-MgDeviceManagementIntent

## SYNOPSIS
Create new navigation property to intents for deviceManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementIntent [-AdditionalProperties <Hashtable>]
 [-Assignments <IMicrosoftGraphDeviceManagementIntentAssignment[]>]
 [-Categories <IMicrosoftGraphDeviceManagementIntentSettingCategory[]>] [-Description <String>]
 [-DeviceSettingStateSummaries <IMicrosoftGraphDeviceManagementIntentDeviceSettingStateSummary[]>]
 [-DeviceStates <IMicrosoftGraphDeviceManagementIntentDeviceState[]>]
 [-DeviceStateSummary <IMicrosoftGraphDeviceManagementIntentDeviceStateSummary>] [-DisplayName <String>]
 [-Id <String>] [-IsAssigned] [-LastModifiedDateTime <DateTime>] [-RoleScopeTagIds <String[]>]
 [-Settings <IMicrosoftGraphDeviceManagementSettingInstance[]>] [-TemplateId <String>]
 [-UserStates <IMicrosoftGraphDeviceManagementIntentUserState[]>]
 [-UserStateSummary <IMicrosoftGraphDeviceManagementIntentUserStateSummary>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementIntent -BodyParameter <IMicrosoftGraphDeviceManagementIntent> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to intents for deviceManagement

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
Collection of assignments
To construct, please use Get-Help -Online and see NOTES section for ASSIGNMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementIntentAssignment[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
Entity that represents an intent to apply settings to a device
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementIntent
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Categories
Collection of setting categories within the intent
To construct, please use Get-Help -Online and see NOTES section for CATEGORIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementIntentSettingCategory[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
The user given description

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

### -DeviceSettingStateSummaries
Collection of settings and their states and counts of devices that belong to corresponding state for all settings within the intent
To construct, please use Get-Help -Online and see NOTES section for DEVICESETTINGSTATESUMMARIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementIntentDeviceSettingStateSummary[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceStates
Collection of states of all devices that the intent is applied to
To construct, please use Get-Help -Online and see NOTES section for DEVICESTATES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementIntentDeviceState[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceStateSummary
Entity that represents device state summary for an intent
To construct, please use Get-Help -Online and see NOTES section for DEVICESTATESUMMARY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementIntentDeviceStateSummary
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
The user given display name

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
Signifies whether or not the intent is assigned to users

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
When the intent was last modified

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

### -Settings
Collection of all settings to be applied
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

### -TemplateId
The ID of the template this intent was created from (if any)

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

### -UserStates
Collection of states of all users that the intent is applied to
To construct, please use Get-Help -Online and see NOTES section for USERSTATES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementIntentUserState[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserStateSummary
Entity that represents user state summary for an intent
To construct, please use Get-Help -Online and see NOTES section for USERSTATESUMMARY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementIntentUserStateSummary
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementIntent

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementIntent

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ASSIGNMENTS <IMicrosoftGraphDeviceManagementIntentAssignment[]>: Collection of assignments
  - `[Id <String>]`: 
  - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget1>]`: Base type for assignment targets.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
    - `[DeviceAndAppManagementAssignmentFilterType <DeviceAndAppManagementAssignmentFilterType?>]`: Represents type of the assignment filter.

BODYPARAMETER <IMicrosoftGraphDeviceManagementIntent>: Entity that represents an intent to apply settings to a device
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[Assignments <IMicrosoftGraphDeviceManagementIntentAssignment[]>]`: Collection of assignments
    - `[Id <String>]`: 
    - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget1>]`: Base type for assignment targets.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
      - `[DeviceAndAppManagementAssignmentFilterType <DeviceAndAppManagementAssignmentFilterType?>]`: Represents type of the assignment filter.
  - `[Categories <IMicrosoftGraphDeviceManagementIntentSettingCategory[]>]`: Collection of setting categories within the intent
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
    - `[Settings <IMicrosoftGraphDeviceManagementSettingInstance[]>]`: The settings this category contains
      - `[Id <String>]`: 
      - `[DefinitionId <String>]`: The ID of the setting definition for this instance
      - `[ValueJson <String>]`: JSON representation of the value
  - `[Description <String>]`: The user given description
  - `[DeviceSettingStateSummaries <IMicrosoftGraphDeviceManagementIntentDeviceSettingStateSummary[]>]`: Collection of settings and their states and counts of devices that belong to corresponding state for all settings within the intent
    - `[Id <String>]`: 
    - `[CompliantCount <Int32?>]`: Number of compliant devices
    - `[ConflictCount <Int32?>]`: Number of devices in conflict
    - `[ErrorCount <Int32?>]`: Number of error devices
    - `[NonCompliantCount <Int32?>]`: Number of non compliant devices
    - `[NotApplicableCount <Int32?>]`: Number of not applicable devices
    - `[RemediatedCount <Int32?>]`: Number of remediated devices
    - `[SettingName <String>]`: Name of a setting
  - `[DeviceStateSummary <IMicrosoftGraphDeviceManagementIntentDeviceStateSummary>]`: Entity that represents device state summary for an intent
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[ConflictCount <Int32?>]`: Number of devices in conflict
    - `[ErrorCount <Int32?>]`: Number of error devices
    - `[FailedCount <Int32?>]`: Number of failed devices
    - `[NotApplicableCount <Int32?>]`: Number of not applicable devices
    - `[NotApplicablePlatformCount <Int32?>]`: Number of not applicable devices due to mismatch platform and policy
    - `[SuccessCount <Int32?>]`: Number of succeeded devices
  - `[DeviceStates <IMicrosoftGraphDeviceManagementIntentDeviceState[]>]`: Collection of states of all devices that the intent is applied to
    - `[Id <String>]`: 
    - `[DeviceDisplayName <String>]`: Device name that is being reported
    - `[DeviceId <String>]`: Device id that is being reported
    - `[LastReportedDateTime <DateTime?>]`: Last modified date time of an intent report
    - `[State <String>]`: complianceStatus
    - `[UserName <String>]`: The user name that is being reported on a device
    - `[UserPrincipalName <String>]`: The user principal name that is being reported on a device
  - `[DisplayName <String>]`: The user given display name
  - `[IsAssigned <Boolean?>]`: Signifies whether or not the intent is assigned to users
  - `[LastModifiedDateTime <DateTime?>]`: When the intent was last modified
  - `[RoleScopeTagIds <String[]>]`: List of Scope Tags for this Entity instance.
  - `[Settings <IMicrosoftGraphDeviceManagementSettingInstance[]>]`: Collection of all settings to be applied
  - `[TemplateId <String>]`: The ID of the template this intent was created from (if any)
  - `[UserStateSummary <IMicrosoftGraphDeviceManagementIntentUserStateSummary>]`: Entity that represents user state summary for an intent
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[ConflictCount <Int32?>]`: Number of users in conflict
    - `[ErrorCount <Int32?>]`: Number of error users
    - `[FailedCount <Int32?>]`: Number of failed users
    - `[NotApplicableCount <Int32?>]`: Number of not applicable users
    - `[SuccessCount <Int32?>]`: Number of succeeded users
  - `[UserStates <IMicrosoftGraphDeviceManagementIntentUserState[]>]`: Collection of states of all users that the intent is applied to
    - `[Id <String>]`: 
    - `[DeviceCount <Int32?>]`: Count of Devices that belongs to a user for an intent
    - `[LastReportedDateTime <DateTime?>]`: Last modified date time of an intent report
    - `[State <String>]`: complianceStatus
    - `[UserName <String>]`: The user name that is being reported on a device
    - `[UserPrincipalName <String>]`: The user principal name that is being reported on a device

CATEGORIES <IMicrosoftGraphDeviceManagementIntentSettingCategory[]>: Collection of setting categories within the intent
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
  - `[Settings <IMicrosoftGraphDeviceManagementSettingInstance[]>]`: The settings this category contains
    - `[Id <String>]`: 
    - `[DefinitionId <String>]`: The ID of the setting definition for this instance
    - `[ValueJson <String>]`: JSON representation of the value

DEVICESETTINGSTATESUMMARIES <IMicrosoftGraphDeviceManagementIntentDeviceSettingStateSummary[]>: Collection of settings and their states and counts of devices that belong to corresponding state for all settings within the intent
  - `[Id <String>]`: 
  - `[CompliantCount <Int32?>]`: Number of compliant devices
  - `[ConflictCount <Int32?>]`: Number of devices in conflict
  - `[ErrorCount <Int32?>]`: Number of error devices
  - `[NonCompliantCount <Int32?>]`: Number of non compliant devices
  - `[NotApplicableCount <Int32?>]`: Number of not applicable devices
  - `[RemediatedCount <Int32?>]`: Number of remediated devices
  - `[SettingName <String>]`: Name of a setting

DEVICESTATES <IMicrosoftGraphDeviceManagementIntentDeviceState[]>: Collection of states of all devices that the intent is applied to
  - `[Id <String>]`: 
  - `[DeviceDisplayName <String>]`: Device name that is being reported
  - `[DeviceId <String>]`: Device id that is being reported
  - `[LastReportedDateTime <DateTime?>]`: Last modified date time of an intent report
  - `[State <String>]`: complianceStatus
  - `[UserName <String>]`: The user name that is being reported on a device
  - `[UserPrincipalName <String>]`: The user principal name that is being reported on a device

DEVICESTATESUMMARY <IMicrosoftGraphDeviceManagementIntentDeviceStateSummary>: Entity that represents device state summary for an intent
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[ConflictCount <Int32?>]`: Number of devices in conflict
  - `[ErrorCount <Int32?>]`: Number of error devices
  - `[FailedCount <Int32?>]`: Number of failed devices
  - `[NotApplicableCount <Int32?>]`: Number of not applicable devices
  - `[NotApplicablePlatformCount <Int32?>]`: Number of not applicable devices due to mismatch platform and policy
  - `[SuccessCount <Int32?>]`: Number of succeeded devices

SETTINGS <IMicrosoftGraphDeviceManagementSettingInstance[]>: Collection of all settings to be applied
  - `[Id <String>]`: 
  - `[DefinitionId <String>]`: The ID of the setting definition for this instance
  - `[ValueJson <String>]`: JSON representation of the value

USERSTATES <IMicrosoftGraphDeviceManagementIntentUserState[]>: Collection of states of all users that the intent is applied to
  - `[Id <String>]`: 
  - `[DeviceCount <Int32?>]`: Count of Devices that belongs to a user for an intent
  - `[LastReportedDateTime <DateTime?>]`: Last modified date time of an intent report
  - `[State <String>]`: complianceStatus
  - `[UserName <String>]`: The user name that is being reported on a device
  - `[UserPrincipalName <String>]`: The user principal name that is being reported on a device

USERSTATESUMMARY <IMicrosoftGraphDeviceManagementIntentUserStateSummary>: Entity that represents user state summary for an intent
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[ConflictCount <Int32?>]`: Number of users in conflict
  - `[ErrorCount <Int32?>]`: Number of error users
  - `[FailedCount <Int32?>]`: Number of failed users
  - `[NotApplicableCount <Int32?>]`: Number of not applicable users
  - `[SuccessCount <Int32?>]`: Number of succeeded users

## RELATED LINKS

