---
external help file: Microsoft.Graph.DeviceManagement-help.xml
Module Name: Microsoft.Graph.DeviceManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement/new-mgdevicemanagementdeviceconfiguration
schema: 2.0.0
---

# New-MgDeviceManagementDeviceConfiguration

## SYNOPSIS
The device configurations.

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementDeviceConfiguration [-AdditionalProperties <Hashtable>]
 [-Assignments <IMicrosoftGraphDeviceConfigurationAssignment1[]>] [-CreatedDateTime <DateTime>]
 [-Description <String>]
 [-DeviceManagementApplicabilityRuleDeviceMode <IMicrosoftGraphDeviceManagementApplicabilityRuleDeviceMode>]
 [-DeviceManagementApplicabilityRuleOSEdition <IMicrosoftGraphDeviceManagementApplicabilityRuleOSEdition>]
 [-DeviceManagementApplicabilityRuleOSVersion <IMicrosoftGraphDeviceManagementApplicabilityRuleOSVersion>]
 [-DeviceSettingStateSummaries <IMicrosoftGraphSettingStateDeviceSummary[]>]
 [-DeviceStatusOverview <IMicrosoftGraphDeviceConfigurationDeviceOverview1>]
 [-DeviceStatuses <IMicrosoftGraphDeviceConfigurationDeviceStatus1[]>] [-DisplayName <String>]
 [-GroupAssignments <IMicrosoftGraphDeviceConfigurationGroupAssignment[]>] [-Id <String>]
 [-LastModifiedDateTime <DateTime>] [-RoleScopeTagIds <String[]>] [-SupportsScopeTags]
 [-UserStatusOverview <IMicrosoftGraphDeviceConfigurationUserOverview1>]
 [-UserStatuses <IMicrosoftGraphDeviceConfigurationUserStatus[]>] [-Version <Int32>] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementDeviceConfiguration -BodyParameter <IMicrosoftGraphDeviceConfiguration1> [-WhatIf]
 [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
The device configurations.

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

### -Assignments
The list of assignments for the device configuration profile.
To construct, see NOTES section for ASSIGNMENTS properties and create a hash table.

```yaml
Type: IMicrosoftGraphDeviceConfigurationAssignment1[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
Device Configuration.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphDeviceConfiguration1
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedDateTime
DateTime the object was created.

```yaml
Type: DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
Admin provided description of the Device Configuration.

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

### -DeviceManagementApplicabilityRuleDeviceMode
deviceManagementApplicabilityRuleDeviceMode
To construct, see NOTES section for DEVICEMANAGEMENTAPPLICABILITYRULEDEVICEMODE properties and create a hash table.

```yaml
Type: IMicrosoftGraphDeviceManagementApplicabilityRuleDeviceMode
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceManagementApplicabilityRuleOSEdition
deviceManagementApplicabilityRuleOsEdition
To construct, see NOTES section for DEVICEMANAGEMENTAPPLICABILITYRULEOSEDITION properties and create a hash table.

```yaml
Type: IMicrosoftGraphDeviceManagementApplicabilityRuleOSEdition
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceManagementApplicabilityRuleOSVersion
deviceManagementApplicabilityRuleOsVersion
To construct, see NOTES section for DEVICEMANAGEMENTAPPLICABILITYRULEOSVERSION properties and create a hash table.

```yaml
Type: IMicrosoftGraphDeviceManagementApplicabilityRuleOSVersion
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceSettingStateSummaries
Device Configuration Setting State Device Summary
To construct, see NOTES section for DEVICESETTINGSTATESUMMARIES properties and create a hash table.

```yaml
Type: IMicrosoftGraphSettingStateDeviceSummary[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceStatuses
Device configuration installation status by device.
To construct, see NOTES section for DEVICESTATUSES properties and create a hash table.

```yaml
Type: IMicrosoftGraphDeviceConfigurationDeviceStatus1[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceStatusOverview
deviceConfigurationDeviceOverview
To construct, see NOTES section for DEVICESTATUSOVERVIEW properties and create a hash table.

```yaml
Type: IMicrosoftGraphDeviceConfigurationDeviceOverview1
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
Admin provided name of the device configuration.

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

### -GroupAssignments
The list of group assignments for the device configuration profile.
To construct, see NOTES section for GROUPASSIGNMENTS properties and create a hash table.

```yaml
Type: IMicrosoftGraphDeviceConfigurationGroupAssignment[]
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

### -LastModifiedDateTime
DateTime the object was last modified.

```yaml
Type: DateTime
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
Type: String[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SupportsScopeTags
Indicates whether or not the underlying Device Configuration supports the assignment of scope tags.
Assigning to the ScopeTags property is not allowed when this value is false and entities will not be visible to scoped users.
This occurs for Legacy policies created in Silverlight and can be resolved by deleting and recreating the policy in the Azure Portal.
This property is read-only.

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

### -UserStatuses
Device configuration installation status by user.
To construct, see NOTES section for USERSTATUSES properties and create a hash table.

```yaml
Type: IMicrosoftGraphDeviceConfigurationUserStatus[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserStatusOverview
deviceConfigurationUserOverview
To construct, see NOTES section for USERSTATUSOVERVIEW properties and create a hash table.

```yaml
Type: IMicrosoftGraphDeviceConfigurationUserOverview1
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Version
Version of the device configuration.

```yaml
Type: Int32
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceConfiguration1
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceConfiguration1
## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ASSIGNMENTS <IMicrosoftGraphDeviceConfigurationAssignment1[]>: The list of assignments for the device configuration profile.
  - `[Id <String>]`: Read-only.
  - `[Source <String>]`: deviceAndAppManagementAssignmentSource
  - `[SourceId <String>]`: The identifier of the source of the assignment. This property is read-only.
  - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget1>]`: Base type for assignment targets.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
    - `[DeviceAndAppManagementAssignmentFilterType <String>]`: deviceAndAppManagementAssignmentFilterType

BODYPARAMETER <IMicrosoftGraphDeviceConfiguration1>: Device Configuration.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[Assignments <IMicrosoftGraphDeviceConfigurationAssignment1[]>]`: The list of assignments for the device configuration profile.
    - `[Id <String>]`: Read-only.
    - `[Source <String>]`: deviceAndAppManagementAssignmentSource
    - `[SourceId <String>]`: The identifier of the source of the assignment. This property is read-only.
    - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget1>]`: Base type for assignment targets.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
      - `[DeviceAndAppManagementAssignmentFilterType <String>]`: deviceAndAppManagementAssignmentFilterType
  - `[CreatedDateTime <DateTime?>]`: DateTime the object was created.
  - `[Description <String>]`: Admin provided description of the Device Configuration.
  - `[DeviceManagementApplicabilityRuleDeviceMode <IMicrosoftGraphDeviceManagementApplicabilityRuleDeviceMode>]`: deviceManagementApplicabilityRuleDeviceMode
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DeviceMode <String>]`: windows10DeviceModeType
    - `[Name <String>]`: Name for object.
    - `[RuleType <String>]`: deviceManagementApplicabilityRuleType
  - `[DeviceManagementApplicabilityRuleOSEdition <IMicrosoftGraphDeviceManagementApplicabilityRuleOSEdition>]`: deviceManagementApplicabilityRuleOsEdition
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Name <String>]`: Name for object.
    - `[OSEditionTypes <String[]>]`: Applicability rule OS edition type.
    - `[RuleType <String>]`: deviceManagementApplicabilityRuleType
  - `[DeviceManagementApplicabilityRuleOSVersion <IMicrosoftGraphDeviceManagementApplicabilityRuleOSVersion>]`: deviceManagementApplicabilityRuleOsVersion
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[MaxOSVersion <String>]`: Max OS version for Applicability Rule.
    - `[MinOSVersion <String>]`: Min OS version for Applicability Rule.
    - `[Name <String>]`: Name for object.
    - `[RuleType <String>]`: deviceManagementApplicabilityRuleType
  - `[DeviceSettingStateSummaries <IMicrosoftGraphSettingStateDeviceSummary[]>]`: Device Configuration Setting State Device Summary
    - `[Id <String>]`: Read-only.
    - `[CompliantDeviceCount <Int32?>]`: Device Compliant count for the setting
    - `[ConflictDeviceCount <Int32?>]`: Device conflict error count for the setting
    - `[ErrorDeviceCount <Int32?>]`: Device error count for the setting
    - `[InstancePath <String>]`: Name of the InstancePath for the setting
    - `[NonCompliantDeviceCount <Int32?>]`: Device NonCompliant count for the setting
    - `[NotApplicableDeviceCount <Int32?>]`: Device Not Applicable count for the setting
    - `[RemediatedDeviceCount <Int32?>]`: Device Compliant count for the setting
    - `[SettingName <String>]`: Name of the setting
    - `[UnknownDeviceCount <Int32?>]`: Device Unkown count for the setting
  - `[DeviceStatusOverview <IMicrosoftGraphDeviceConfigurationDeviceOverview1>]`: deviceConfigurationDeviceOverview
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[ConfigurationVersion <Int32?>]`: Version of the policy for that overview
    - `[ConflictCount <Int32?>]`: Number of devices in conflict
    - `[ErrorCount <Int32?>]`: Number of error devices
    - `[FailedCount <Int32?>]`: Number of failed devices
    - `[LastUpdateDateTime <DateTime?>]`: Last update time
    - `[NotApplicableCount <Int32?>]`: Number of not applicable devices
    - `[NotApplicablePlatformCount <Int32?>]`: Number of not applicable devices due to mismatch platform and policy
    - `[PendingCount <Int32?>]`: Number of pending devices
    - `[SuccessCount <Int32?>]`: Number of succeeded devices
  - `[DeviceStatuses <IMicrosoftGraphDeviceConfigurationDeviceStatus1[]>]`: Device configuration installation status by device.
    - `[Id <String>]`: Read-only.
    - `[ComplianceGracePeriodExpirationDateTime <DateTime?>]`: The DateTime when device compliance grace period expires
    - `[DeviceDisplayName <String>]`: Device name of the DevicePolicyStatus.
    - `[DeviceModel <String>]`: The device model that is being reported
    - `[LastReportedDateTime <DateTime?>]`: Last modified date time of the policy report.
    - `[Platform <Int32?>]`: Platform of the device that is being reported
    - `[Status <String>]`: complianceStatus
    - `[UserName <String>]`: The User Name that is being reported
    - `[UserPrincipalName <String>]`: UserPrincipalName.
  - `[DisplayName <String>]`: Admin provided name of the device configuration.
  - `[GroupAssignments <IMicrosoftGraphDeviceConfigurationGroupAssignment[]>]`: The list of group assignments for the device configuration profile.
    - `[Id <String>]`: Read-only.
    - `[DeviceConfiguration <IMicrosoftGraphDeviceConfiguration1>]`: Device Configuration.
    - `[ExcludeGroup <Boolean?>]`: Indicates if this group is should be excluded. Defaults that the group should be included
    - `[TargetGroupId <String>]`: The Id of the AAD group we are targeting the device configuration to.
  - `[LastModifiedDateTime <DateTime?>]`: DateTime the object was last modified.
  - `[RoleScopeTagIds <String[]>]`: List of Scope Tags for this Entity instance.
  - `[SupportsScopeTags <Boolean?>]`: Indicates whether or not the underlying Device Configuration supports the assignment of scope tags. Assigning to the ScopeTags property is not allowed when this value is false and entities will not be visible to scoped users. This occurs for Legacy policies created in Silverlight and can be resolved by deleting and recreating the policy in the Azure Portal. This property is read-only.
  - `[UserStatusOverview <IMicrosoftGraphDeviceConfigurationUserOverview1>]`: deviceConfigurationUserOverview
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[ConfigurationVersion <Int32?>]`: Version of the policy for that overview
    - `[ConflictCount <Int32?>]`: Number of users in conflict
    - `[ErrorCount <Int32?>]`: Number of error Users
    - `[FailedCount <Int32?>]`: Number of failed Users
    - `[LastUpdateDateTime <DateTime?>]`: Last update time
    - `[NotApplicableCount <Int32?>]`: Number of not applicable users
    - `[PendingCount <Int32?>]`: Number of pending Users
    - `[SuccessCount <Int32?>]`: Number of succeeded Users
  - `[UserStatuses <IMicrosoftGraphDeviceConfigurationUserStatus[]>]`: Device configuration installation status by user.
    - `[Id <String>]`: Read-only.
    - `[DevicesCount <Int32?>]`: Devices count for that user.
    - `[LastReportedDateTime <DateTime?>]`: Last modified date time of the policy report.
    - `[Status <String>]`: complianceStatus
    - `[UserDisplayName <String>]`: User name of the DevicePolicyStatus.
    - `[UserPrincipalName <String>]`: UserPrincipalName.
  - `[Version <Int32?>]`: Version of the device configuration.

DEVICEMANAGEMENTAPPLICABILITYRULEDEVICEMODE <IMicrosoftGraphDeviceManagementApplicabilityRuleDeviceMode>: deviceManagementApplicabilityRuleDeviceMode
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DeviceMode <String>]`: windows10DeviceModeType
  - `[Name <String>]`: Name for object.
  - `[RuleType <String>]`: deviceManagementApplicabilityRuleType

DEVICEMANAGEMENTAPPLICABILITYRULEOSEDITION <IMicrosoftGraphDeviceManagementApplicabilityRuleOSEdition>: deviceManagementApplicabilityRuleOsEdition
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Name <String>]`: Name for object.
  - `[OSEditionTypes <String[]>]`: Applicability rule OS edition type.
  - `[RuleType <String>]`: deviceManagementApplicabilityRuleType

DEVICEMANAGEMENTAPPLICABILITYRULEOSVERSION <IMicrosoftGraphDeviceManagementApplicabilityRuleOSVersion>: deviceManagementApplicabilityRuleOsVersion
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[MaxOSVersion <String>]`: Max OS version for Applicability Rule.
  - `[MinOSVersion <String>]`: Min OS version for Applicability Rule.
  - `[Name <String>]`: Name for object.
  - `[RuleType <String>]`: deviceManagementApplicabilityRuleType

DEVICESETTINGSTATESUMMARIES <IMicrosoftGraphSettingStateDeviceSummary[]>: Device Configuration Setting State Device Summary
  - `[Id <String>]`: Read-only.
  - `[CompliantDeviceCount <Int32?>]`: Device Compliant count for the setting
  - `[ConflictDeviceCount <Int32?>]`: Device conflict error count for the setting
  - `[ErrorDeviceCount <Int32?>]`: Device error count for the setting
  - `[InstancePath <String>]`: Name of the InstancePath for the setting
  - `[NonCompliantDeviceCount <Int32?>]`: Device NonCompliant count for the setting
  - `[NotApplicableDeviceCount <Int32?>]`: Device Not Applicable count for the setting
  - `[RemediatedDeviceCount <Int32?>]`: Device Compliant count for the setting
  - `[SettingName <String>]`: Name of the setting
  - `[UnknownDeviceCount <Int32?>]`: Device Unkown count for the setting

DEVICESTATUSES <IMicrosoftGraphDeviceConfigurationDeviceStatus1[]>: Device configuration installation status by device.
  - `[Id <String>]`: Read-only.
  - `[ComplianceGracePeriodExpirationDateTime <DateTime?>]`: The DateTime when device compliance grace period expires
  - `[DeviceDisplayName <String>]`: Device name of the DevicePolicyStatus.
  - `[DeviceModel <String>]`: The device model that is being reported
  - `[LastReportedDateTime <DateTime?>]`: Last modified date time of the policy report.
  - `[Platform <Int32?>]`: Platform of the device that is being reported
  - `[Status <String>]`: complianceStatus
  - `[UserName <String>]`: The User Name that is being reported
  - `[UserPrincipalName <String>]`: UserPrincipalName.

DEVICESTATUSOVERVIEW <IMicrosoftGraphDeviceConfigurationDeviceOverview1>: deviceConfigurationDeviceOverview
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[ConfigurationVersion <Int32?>]`: Version of the policy for that overview
  - `[ConflictCount <Int32?>]`: Number of devices in conflict
  - `[ErrorCount <Int32?>]`: Number of error devices
  - `[FailedCount <Int32?>]`: Number of failed devices
  - `[LastUpdateDateTime <DateTime?>]`: Last update time
  - `[NotApplicableCount <Int32?>]`: Number of not applicable devices
  - `[NotApplicablePlatformCount <Int32?>]`: Number of not applicable devices due to mismatch platform and policy
  - `[PendingCount <Int32?>]`: Number of pending devices
  - `[SuccessCount <Int32?>]`: Number of succeeded devices

GROUPASSIGNMENTS <IMicrosoftGraphDeviceConfigurationGroupAssignment[]>: The list of group assignments for the device configuration profile.
  - `[Id <String>]`: Read-only.
  - `[DeviceConfiguration <IMicrosoftGraphDeviceConfiguration1>]`: Device Configuration.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[Assignments <IMicrosoftGraphDeviceConfigurationAssignment1[]>]`: The list of assignments for the device configuration profile.
      - `[Id <String>]`: Read-only.
      - `[Source <String>]`: deviceAndAppManagementAssignmentSource
      - `[SourceId <String>]`: The identifier of the source of the assignment. This property is read-only.
      - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget1>]`: Base type for assignment targets.
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
        - `[DeviceAndAppManagementAssignmentFilterType <String>]`: deviceAndAppManagementAssignmentFilterType
    - `[CreatedDateTime <DateTime?>]`: DateTime the object was created.
    - `[Description <String>]`: Admin provided description of the Device Configuration.
    - `[DeviceManagementApplicabilityRuleDeviceMode <IMicrosoftGraphDeviceManagementApplicabilityRuleDeviceMode>]`: deviceManagementApplicabilityRuleDeviceMode
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DeviceMode <String>]`: windows10DeviceModeType
      - `[Name <String>]`: Name for object.
      - `[RuleType <String>]`: deviceManagementApplicabilityRuleType
    - `[DeviceManagementApplicabilityRuleOSEdition <IMicrosoftGraphDeviceManagementApplicabilityRuleOSEdition>]`: deviceManagementApplicabilityRuleOsEdition
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Name <String>]`: Name for object.
      - `[OSEditionTypes <String[]>]`: Applicability rule OS edition type.
      - `[RuleType <String>]`: deviceManagementApplicabilityRuleType
    - `[DeviceManagementApplicabilityRuleOSVersion <IMicrosoftGraphDeviceManagementApplicabilityRuleOSVersion>]`: deviceManagementApplicabilityRuleOsVersion
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[MaxOSVersion <String>]`: Max OS version for Applicability Rule.
      - `[MinOSVersion <String>]`: Min OS version for Applicability Rule.
      - `[Name <String>]`: Name for object.
      - `[RuleType <String>]`: deviceManagementApplicabilityRuleType
    - `[DeviceSettingStateSummaries <IMicrosoftGraphSettingStateDeviceSummary[]>]`: Device Configuration Setting State Device Summary
      - `[Id <String>]`: Read-only.
      - `[CompliantDeviceCount <Int32?>]`: Device Compliant count for the setting
      - `[ConflictDeviceCount <Int32?>]`: Device conflict error count for the setting
      - `[ErrorDeviceCount <Int32?>]`: Device error count for the setting
      - `[InstancePath <String>]`: Name of the InstancePath for the setting
      - `[NonCompliantDeviceCount <Int32?>]`: Device NonCompliant count for the setting
      - `[NotApplicableDeviceCount <Int32?>]`: Device Not Applicable count for the setting
      - `[RemediatedDeviceCount <Int32?>]`: Device Compliant count for the setting
      - `[SettingName <String>]`: Name of the setting
      - `[UnknownDeviceCount <Int32?>]`: Device Unkown count for the setting
    - `[DeviceStatusOverview <IMicrosoftGraphDeviceConfigurationDeviceOverview1>]`: deviceConfigurationDeviceOverview
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[ConfigurationVersion <Int32?>]`: Version of the policy for that overview
      - `[ConflictCount <Int32?>]`: Number of devices in conflict
      - `[ErrorCount <Int32?>]`: Number of error devices
      - `[FailedCount <Int32?>]`: Number of failed devices
      - `[LastUpdateDateTime <DateTime?>]`: Last update time
      - `[NotApplicableCount <Int32?>]`: Number of not applicable devices
      - `[NotApplicablePlatformCount <Int32?>]`: Number of not applicable devices due to mismatch platform and policy
      - `[PendingCount <Int32?>]`: Number of pending devices
      - `[SuccessCount <Int32?>]`: Number of succeeded devices
    - `[DeviceStatuses <IMicrosoftGraphDeviceConfigurationDeviceStatus1[]>]`: Device configuration installation status by device.
      - `[Id <String>]`: Read-only.
      - `[ComplianceGracePeriodExpirationDateTime <DateTime?>]`: The DateTime when device compliance grace period expires
      - `[DeviceDisplayName <String>]`: Device name of the DevicePolicyStatus.
      - `[DeviceModel <String>]`: The device model that is being reported
      - `[LastReportedDateTime <DateTime?>]`: Last modified date time of the policy report.
      - `[Platform <Int32?>]`: Platform of the device that is being reported
      - `[Status <String>]`: complianceStatus
      - `[UserName <String>]`: The User Name that is being reported
      - `[UserPrincipalName <String>]`: UserPrincipalName.
    - `[DisplayName <String>]`: Admin provided name of the device configuration.
    - `[GroupAssignments <IMicrosoftGraphDeviceConfigurationGroupAssignment[]>]`: The list of group assignments for the device configuration profile.
    - `[LastModifiedDateTime <DateTime?>]`: DateTime the object was last modified.
    - `[RoleScopeTagIds <String[]>]`: List of Scope Tags for this Entity instance.
    - `[SupportsScopeTags <Boolean?>]`: Indicates whether or not the underlying Device Configuration supports the assignment of scope tags. Assigning to the ScopeTags property is not allowed when this value is false and entities will not be visible to scoped users. This occurs for Legacy policies created in Silverlight and can be resolved by deleting and recreating the policy in the Azure Portal. This property is read-only.
    - `[UserStatusOverview <IMicrosoftGraphDeviceConfigurationUserOverview1>]`: deviceConfigurationUserOverview
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[ConfigurationVersion <Int32?>]`: Version of the policy for that overview
      - `[ConflictCount <Int32?>]`: Number of users in conflict
      - `[ErrorCount <Int32?>]`: Number of error Users
      - `[FailedCount <Int32?>]`: Number of failed Users
      - `[LastUpdateDateTime <DateTime?>]`: Last update time
      - `[NotApplicableCount <Int32?>]`: Number of not applicable users
      - `[PendingCount <Int32?>]`: Number of pending Users
      - `[SuccessCount <Int32?>]`: Number of succeeded Users
    - `[UserStatuses <IMicrosoftGraphDeviceConfigurationUserStatus[]>]`: Device configuration installation status by user.
      - `[Id <String>]`: Read-only.
      - `[DevicesCount <Int32?>]`: Devices count for that user.
      - `[LastReportedDateTime <DateTime?>]`: Last modified date time of the policy report.
      - `[Status <String>]`: complianceStatus
      - `[UserDisplayName <String>]`: User name of the DevicePolicyStatus.
      - `[UserPrincipalName <String>]`: UserPrincipalName.
    - `[Version <Int32?>]`: Version of the device configuration.
  - `[ExcludeGroup <Boolean?>]`: Indicates if this group is should be excluded. Defaults that the group should be included
  - `[TargetGroupId <String>]`: The Id of the AAD group we are targeting the device configuration to.

USERSTATUSES <IMicrosoftGraphDeviceConfigurationUserStatus[]>: Device configuration installation status by user.
  - `[Id <String>]`: Read-only.
  - `[DevicesCount <Int32?>]`: Devices count for that user.
  - `[LastReportedDateTime <DateTime?>]`: Last modified date time of the policy report.
  - `[Status <String>]`: complianceStatus
  - `[UserDisplayName <String>]`: User name of the DevicePolicyStatus.
  - `[UserPrincipalName <String>]`: UserPrincipalName.

USERSTATUSOVERVIEW <IMicrosoftGraphDeviceConfigurationUserOverview1>: deviceConfigurationUserOverview
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[ConfigurationVersion <Int32?>]`: Version of the policy for that overview
  - `[ConflictCount <Int32?>]`: Number of users in conflict
  - `[ErrorCount <Int32?>]`: Number of error Users
  - `[FailedCount <Int32?>]`: Number of failed Users
  - `[LastUpdateDateTime <DateTime?>]`: Last update time
  - `[NotApplicableCount <Int32?>]`: Number of not applicable users
  - `[PendingCount <Int32?>]`: Number of pending Users
  - `[SuccessCount <Int32?>]`: Number of succeeded Users

## RELATED LINKS

## RELATED LINKS
