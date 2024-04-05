---
external help file:
Module Name: Microsoft.Graph.Beta.DeviceManagement
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.devicemanagement/new-mgbetadevicemanagementdeviceconfiguration
schema: 2.0.0
---

# New-MgBetaDeviceManagementDeviceConfiguration

## SYNOPSIS
Create new navigation property to deviceConfigurations for deviceManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaDeviceManagementDeviceConfiguration [-AdditionalProperties <Hashtable>]
 [-Assignments <IMicrosoftGraphDeviceConfigurationAssignment[]>] [-CreatedDateTime <DateTime>]
 [-Description <String>]
 [-DeviceManagementApplicabilityRuleDeviceMode <IMicrosoftGraphDeviceManagementApplicabilityRuleDeviceMode>]
 [-DeviceManagementApplicabilityRuleOSEdition <IMicrosoftGraphDeviceManagementApplicabilityRuleOSEdition>]
 [-DeviceManagementApplicabilityRuleOSVersion <IMicrosoftGraphDeviceManagementApplicabilityRuleOSVersion>]
 [-DeviceSettingStateSummaries <IMicrosoftGraphSettingStateDeviceSummary[]>]
 [-DeviceStatuses <IMicrosoftGraphDeviceConfigurationDeviceStatus[]>]
 [-DeviceStatusOverview <IMicrosoftGraphDeviceConfigurationDeviceOverview>] [-DisplayName <String>]
 [-GroupAssignments <IMicrosoftGraphDeviceConfigurationGroupAssignment[]>] [-Id <String>]
 [-LastModifiedDateTime <DateTime>] [-ResponseHeadersVariable <String>] [-RoleScopeTagIds <String[]>]
 [-UserStatuses <IMicrosoftGraphDeviceConfigurationUserStatus[]>]
 [-UserStatusOverview <IMicrosoftGraphDeviceConfigurationUserOverview>] [-Version <Int32>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgBetaDeviceManagementDeviceConfiguration -BodyParameter <IMicrosoftGraphDeviceConfiguration>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to deviceConfigurations for deviceManagement

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

### -Assignments
The list of assignments for the device configuration profile.
To construct, see NOTES section for ASSIGNMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDeviceConfigurationAssignment[]
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDeviceConfiguration
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
Type: System.DateTime
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
Type: System.String
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDeviceManagementApplicabilityRuleDeviceMode
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDeviceManagementApplicabilityRuleOSEdition
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDeviceManagementApplicabilityRuleOSVersion
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSettingStateDeviceSummary[]
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDeviceConfigurationDeviceStatus[]
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDeviceConfigurationDeviceOverview
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
Type: System.String
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDeviceConfigurationGroupAssignment[]
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

### -LastModifiedDateTime
DateTime the object was last modified.

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

### -UserStatuses
Device configuration installation status by user.
To construct, see NOTES section for USERSTATUSES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDeviceConfigurationUserStatus[]
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDeviceConfigurationUserOverview
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
Type: System.Int32
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDeviceConfiguration

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDeviceConfiguration

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`ASSIGNMENTS <IMicrosoftGraphDeviceConfigurationAssignment[]>`: The list of assignments for the device configuration profile.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Intent <DeviceConfigAssignmentIntent?>]`: The administrator intent for the assignment of the profile.
  - `[Source <DeviceAndAppManagementAssignmentSource?>]`: Represents source of assignment.
  - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: Base type for assignment targets.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
    - `[DeviceAndAppManagementAssignmentFilterType <DeviceAndAppManagementAssignmentFilterType?>]`: Represents type of the assignment filter.

`BODYPARAMETER <IMicrosoftGraphDeviceConfiguration>`: Device Configuration.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Assignments <IMicrosoftGraphDeviceConfigurationAssignment[]>]`: The list of assignments for the device configuration profile.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Intent <DeviceConfigAssignmentIntent?>]`: The administrator intent for the assignment of the profile.
    - `[Source <DeviceAndAppManagementAssignmentSource?>]`: Represents source of assignment.
    - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: Base type for assignment targets.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
      - `[DeviceAndAppManagementAssignmentFilterType <DeviceAndAppManagementAssignmentFilterType?>]`: Represents type of the assignment filter.
  - `[CreatedDateTime <DateTime?>]`: DateTime the object was created.
  - `[Description <String>]`: Admin provided description of the Device Configuration.
  - `[DeviceManagementApplicabilityRuleDeviceMode <IMicrosoftGraphDeviceManagementApplicabilityRuleDeviceMode>]`: deviceManagementApplicabilityRuleDeviceMode
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DeviceMode <Windows10DeviceModeType?>]`: Windows 10 Device Mode type.
    - `[Name <String>]`: Name for object.
    - `[RuleType <DeviceManagementApplicabilityRuleType?>]`: Supported Applicability rule types for Device Configuration
  - `[DeviceManagementApplicabilityRuleOSEdition <IMicrosoftGraphDeviceManagementApplicabilityRuleOSEdition>]`: deviceManagementApplicabilityRuleOsEdition
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Name <String>]`: Name for object.
    - `[OSEditionTypes <Windows10EditionType[]>]`: Applicability rule OS edition type.
    - `[RuleType <DeviceManagementApplicabilityRuleType?>]`: Supported Applicability rule types for Device Configuration
  - `[DeviceManagementApplicabilityRuleOSVersion <IMicrosoftGraphDeviceManagementApplicabilityRuleOSVersion>]`: deviceManagementApplicabilityRuleOsVersion
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[MaxOSVersion <String>]`: Max OS version for Applicability Rule.
    - `[MinOSVersion <String>]`: Min OS version for Applicability Rule.
    - `[Name <String>]`: Name for object.
    - `[RuleType <DeviceManagementApplicabilityRuleType?>]`: Supported Applicability rule types for Device Configuration
  - `[DeviceSettingStateSummaries <IMicrosoftGraphSettingStateDeviceSummary[]>]`: Device Configuration Setting State Device Summary
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[CompliantDeviceCount <Int32?>]`: Device Compliant count for the setting
    - `[ConflictDeviceCount <Int32?>]`: Device conflict error count for the setting
    - `[ErrorDeviceCount <Int32?>]`: Device error count for the setting
    - `[InstancePath <String>]`: Name of the InstancePath for the setting
    - `[NonCompliantDeviceCount <Int32?>]`: Device NonCompliant count for the setting
    - `[NotApplicableDeviceCount <Int32?>]`: Device Not Applicable count for the setting
    - `[RemediatedDeviceCount <Int32?>]`: Device Compliant count for the setting
    - `[SettingName <String>]`: Name of the setting
    - `[UnknownDeviceCount <Int32?>]`: Device Unkown count for the setting
  - `[DeviceStatusOverview <IMicrosoftGraphDeviceConfigurationDeviceOverview>]`: deviceConfigurationDeviceOverview
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[ConfigurationVersion <Int32?>]`: Version of the policy for that overview
    - `[ConflictCount <Int32?>]`: Number of devices in conflict
    - `[ErrorCount <Int32?>]`: Number of error devices
    - `[FailedCount <Int32?>]`: Number of failed devices
    - `[LastUpdateDateTime <DateTime?>]`: Last update time
    - `[NotApplicableCount <Int32?>]`: Number of not applicable devices
    - `[NotApplicablePlatformCount <Int32?>]`: Number of not applicable devices due to mismatch platform and policy
    - `[PendingCount <Int32?>]`: Number of pending devices
    - `[SuccessCount <Int32?>]`: Number of succeeded devices
  - `[DeviceStatuses <IMicrosoftGraphDeviceConfigurationDeviceStatus[]>]`: Device configuration installation status by device.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
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
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[DeviceConfiguration <IMicrosoftGraphDeviceConfiguration>]`: Device Configuration.
    - `[ExcludeGroup <Boolean?>]`: Indicates if this group is should be excluded. Defaults that the group should be included
    - `[TargetGroupId <String>]`: The Id of the AAD group we are targeting the device configuration to.
  - `[LastModifiedDateTime <DateTime?>]`: DateTime the object was last modified.
  - `[RoleScopeTagIds <String[]>]`: List of Scope Tags for this Entity instance.
  - `[UserStatusOverview <IMicrosoftGraphDeviceConfigurationUserOverview>]`: deviceConfigurationUserOverview
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[ConfigurationVersion <Int32?>]`: Version of the policy for that overview
    - `[ConflictCount <Int32?>]`: Number of users in conflict
    - `[ErrorCount <Int32?>]`: Number of error Users
    - `[FailedCount <Int32?>]`: Number of failed Users
    - `[LastUpdateDateTime <DateTime?>]`: Last update time
    - `[NotApplicableCount <Int32?>]`: Number of not applicable users
    - `[PendingCount <Int32?>]`: Number of pending Users
    - `[SuccessCount <Int32?>]`: Number of succeeded Users
  - `[UserStatuses <IMicrosoftGraphDeviceConfigurationUserStatus[]>]`: Device configuration installation status by user.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[DevicesCount <Int32?>]`: Devices count for that user.
    - `[LastReportedDateTime <DateTime?>]`: Last modified date time of the policy report.
    - `[Status <String>]`: complianceStatus
    - `[UserDisplayName <String>]`: User name of the DevicePolicyStatus.
    - `[UserPrincipalName <String>]`: UserPrincipalName.
  - `[Version <Int32?>]`: Version of the device configuration.

`DEVICEMANAGEMENTAPPLICABILITYRULEDEVICEMODE <IMicrosoftGraphDeviceManagementApplicabilityRuleDeviceMode>`: deviceManagementApplicabilityRuleDeviceMode
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DeviceMode <Windows10DeviceModeType?>]`: Windows 10 Device Mode type.
  - `[Name <String>]`: Name for object.
  - `[RuleType <DeviceManagementApplicabilityRuleType?>]`: Supported Applicability rule types for Device Configuration

`DEVICEMANAGEMENTAPPLICABILITYRULEOSEDITION <IMicrosoftGraphDeviceManagementApplicabilityRuleOSEdition>`: deviceManagementApplicabilityRuleOsEdition
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Name <String>]`: Name for object.
  - `[OSEditionTypes <Windows10EditionType[]>]`: Applicability rule OS edition type.
  - `[RuleType <DeviceManagementApplicabilityRuleType?>]`: Supported Applicability rule types for Device Configuration

`DEVICEMANAGEMENTAPPLICABILITYRULEOSVERSION <IMicrosoftGraphDeviceManagementApplicabilityRuleOSVersion>`: deviceManagementApplicabilityRuleOsVersion
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[MaxOSVersion <String>]`: Max OS version for Applicability Rule.
  - `[MinOSVersion <String>]`: Min OS version for Applicability Rule.
  - `[Name <String>]`: Name for object.
  - `[RuleType <DeviceManagementApplicabilityRuleType?>]`: Supported Applicability rule types for Device Configuration

`DEVICESETTINGSTATESUMMARIES <IMicrosoftGraphSettingStateDeviceSummary[]>`: Device Configuration Setting State Device Summary
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[CompliantDeviceCount <Int32?>]`: Device Compliant count for the setting
  - `[ConflictDeviceCount <Int32?>]`: Device conflict error count for the setting
  - `[ErrorDeviceCount <Int32?>]`: Device error count for the setting
  - `[InstancePath <String>]`: Name of the InstancePath for the setting
  - `[NonCompliantDeviceCount <Int32?>]`: Device NonCompliant count for the setting
  - `[NotApplicableDeviceCount <Int32?>]`: Device Not Applicable count for the setting
  - `[RemediatedDeviceCount <Int32?>]`: Device Compliant count for the setting
  - `[SettingName <String>]`: Name of the setting
  - `[UnknownDeviceCount <Int32?>]`: Device Unkown count for the setting

`DEVICESTATUSES <IMicrosoftGraphDeviceConfigurationDeviceStatus[]>`: Device configuration installation status by device.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[ComplianceGracePeriodExpirationDateTime <DateTime?>]`: The DateTime when device compliance grace period expires
  - `[DeviceDisplayName <String>]`: Device name of the DevicePolicyStatus.
  - `[DeviceModel <String>]`: The device model that is being reported
  - `[LastReportedDateTime <DateTime?>]`: Last modified date time of the policy report.
  - `[Platform <Int32?>]`: Platform of the device that is being reported
  - `[Status <String>]`: complianceStatus
  - `[UserName <String>]`: The User Name that is being reported
  - `[UserPrincipalName <String>]`: UserPrincipalName.

`DEVICESTATUSOVERVIEW <IMicrosoftGraphDeviceConfigurationDeviceOverview>`: deviceConfigurationDeviceOverview
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[ConfigurationVersion <Int32?>]`: Version of the policy for that overview
  - `[ConflictCount <Int32?>]`: Number of devices in conflict
  - `[ErrorCount <Int32?>]`: Number of error devices
  - `[FailedCount <Int32?>]`: Number of failed devices
  - `[LastUpdateDateTime <DateTime?>]`: Last update time
  - `[NotApplicableCount <Int32?>]`: Number of not applicable devices
  - `[NotApplicablePlatformCount <Int32?>]`: Number of not applicable devices due to mismatch platform and policy
  - `[PendingCount <Int32?>]`: Number of pending devices
  - `[SuccessCount <Int32?>]`: Number of succeeded devices

`GROUPASSIGNMENTS <IMicrosoftGraphDeviceConfigurationGroupAssignment[]>`: The list of group assignments for the device configuration profile.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[DeviceConfiguration <IMicrosoftGraphDeviceConfiguration>]`: Device Configuration.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Assignments <IMicrosoftGraphDeviceConfigurationAssignment[]>]`: The list of assignments for the device configuration profile.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Intent <DeviceConfigAssignmentIntent?>]`: The administrator intent for the assignment of the profile.
      - `[Source <DeviceAndAppManagementAssignmentSource?>]`: Represents source of assignment.
      - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: Base type for assignment targets.
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
        - `[DeviceAndAppManagementAssignmentFilterType <DeviceAndAppManagementAssignmentFilterType?>]`: Represents type of the assignment filter.
    - `[CreatedDateTime <DateTime?>]`: DateTime the object was created.
    - `[Description <String>]`: Admin provided description of the Device Configuration.
    - `[DeviceManagementApplicabilityRuleDeviceMode <IMicrosoftGraphDeviceManagementApplicabilityRuleDeviceMode>]`: deviceManagementApplicabilityRuleDeviceMode
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DeviceMode <Windows10DeviceModeType?>]`: Windows 10 Device Mode type.
      - `[Name <String>]`: Name for object.
      - `[RuleType <DeviceManagementApplicabilityRuleType?>]`: Supported Applicability rule types for Device Configuration
    - `[DeviceManagementApplicabilityRuleOSEdition <IMicrosoftGraphDeviceManagementApplicabilityRuleOSEdition>]`: deviceManagementApplicabilityRuleOsEdition
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Name <String>]`: Name for object.
      - `[OSEditionTypes <Windows10EditionType[]>]`: Applicability rule OS edition type.
      - `[RuleType <DeviceManagementApplicabilityRuleType?>]`: Supported Applicability rule types for Device Configuration
    - `[DeviceManagementApplicabilityRuleOSVersion <IMicrosoftGraphDeviceManagementApplicabilityRuleOSVersion>]`: deviceManagementApplicabilityRuleOsVersion
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[MaxOSVersion <String>]`: Max OS version for Applicability Rule.
      - `[MinOSVersion <String>]`: Min OS version for Applicability Rule.
      - `[Name <String>]`: Name for object.
      - `[RuleType <DeviceManagementApplicabilityRuleType?>]`: Supported Applicability rule types for Device Configuration
    - `[DeviceSettingStateSummaries <IMicrosoftGraphSettingStateDeviceSummary[]>]`: Device Configuration Setting State Device Summary
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[CompliantDeviceCount <Int32?>]`: Device Compliant count for the setting
      - `[ConflictDeviceCount <Int32?>]`: Device conflict error count for the setting
      - `[ErrorDeviceCount <Int32?>]`: Device error count for the setting
      - `[InstancePath <String>]`: Name of the InstancePath for the setting
      - `[NonCompliantDeviceCount <Int32?>]`: Device NonCompliant count for the setting
      - `[NotApplicableDeviceCount <Int32?>]`: Device Not Applicable count for the setting
      - `[RemediatedDeviceCount <Int32?>]`: Device Compliant count for the setting
      - `[SettingName <String>]`: Name of the setting
      - `[UnknownDeviceCount <Int32?>]`: Device Unkown count for the setting
    - `[DeviceStatusOverview <IMicrosoftGraphDeviceConfigurationDeviceOverview>]`: deviceConfigurationDeviceOverview
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[ConfigurationVersion <Int32?>]`: Version of the policy for that overview
      - `[ConflictCount <Int32?>]`: Number of devices in conflict
      - `[ErrorCount <Int32?>]`: Number of error devices
      - `[FailedCount <Int32?>]`: Number of failed devices
      - `[LastUpdateDateTime <DateTime?>]`: Last update time
      - `[NotApplicableCount <Int32?>]`: Number of not applicable devices
      - `[NotApplicablePlatformCount <Int32?>]`: Number of not applicable devices due to mismatch platform and policy
      - `[PendingCount <Int32?>]`: Number of pending devices
      - `[SuccessCount <Int32?>]`: Number of succeeded devices
    - `[DeviceStatuses <IMicrosoftGraphDeviceConfigurationDeviceStatus[]>]`: Device configuration installation status by device.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
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
    - `[UserStatusOverview <IMicrosoftGraphDeviceConfigurationUserOverview>]`: deviceConfigurationUserOverview
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[ConfigurationVersion <Int32?>]`: Version of the policy for that overview
      - `[ConflictCount <Int32?>]`: Number of users in conflict
      - `[ErrorCount <Int32?>]`: Number of error Users
      - `[FailedCount <Int32?>]`: Number of failed Users
      - `[LastUpdateDateTime <DateTime?>]`: Last update time
      - `[NotApplicableCount <Int32?>]`: Number of not applicable users
      - `[PendingCount <Int32?>]`: Number of pending Users
      - `[SuccessCount <Int32?>]`: Number of succeeded Users
    - `[UserStatuses <IMicrosoftGraphDeviceConfigurationUserStatus[]>]`: Device configuration installation status by user.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[DevicesCount <Int32?>]`: Devices count for that user.
      - `[LastReportedDateTime <DateTime?>]`: Last modified date time of the policy report.
      - `[Status <String>]`: complianceStatus
      - `[UserDisplayName <String>]`: User name of the DevicePolicyStatus.
      - `[UserPrincipalName <String>]`: UserPrincipalName.
    - `[Version <Int32?>]`: Version of the device configuration.
  - `[ExcludeGroup <Boolean?>]`: Indicates if this group is should be excluded. Defaults that the group should be included
  - `[TargetGroupId <String>]`: The Id of the AAD group we are targeting the device configuration to.

`USERSTATUSES <IMicrosoftGraphDeviceConfigurationUserStatus[]>`: Device configuration installation status by user.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[DevicesCount <Int32?>]`: Devices count for that user.
  - `[LastReportedDateTime <DateTime?>]`: Last modified date time of the policy report.
  - `[Status <String>]`: complianceStatus
  - `[UserDisplayName <String>]`: User name of the DevicePolicyStatus.
  - `[UserPrincipalName <String>]`: UserPrincipalName.

`USERSTATUSOVERVIEW <IMicrosoftGraphDeviceConfigurationUserOverview>`: deviceConfigurationUserOverview
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[ConfigurationVersion <Int32?>]`: Version of the policy for that overview
  - `[ConflictCount <Int32?>]`: Number of users in conflict
  - `[ErrorCount <Int32?>]`: Number of error Users
  - `[FailedCount <Int32?>]`: Number of failed Users
  - `[LastUpdateDateTime <DateTime?>]`: Last update time
  - `[NotApplicableCount <Int32?>]`: Number of not applicable users
  - `[PendingCount <Int32?>]`: Number of pending Users
  - `[SuccessCount <Int32?>]`: Number of succeeded Users

## RELATED LINKS

