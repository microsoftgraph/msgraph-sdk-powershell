---
external help file:
Module Name: Microsoft.Graph.DeviceManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement/new-mgdevicemanagementdevicecompliancepolicy
schema: 2.0.0
---

# New-MgDeviceManagementDeviceCompliancePolicy

## SYNOPSIS
Create new navigation property to deviceCompliancePolicies for deviceManagement

## SYNTAX

### CreateExpanded1 (Default)
```
New-MgDeviceManagementDeviceCompliancePolicy [-AdditionalProperties <Hashtable>]
 [-Assignments <IMicrosoftGraphDeviceCompliancePolicyAssignment[]>] [-CreatedDateTime <DateTime>]
 [-Description <String>] [-DeviceSettingStateSummaries <IMicrosoftGraphSettingStateDeviceSummary[]>]
 [-DeviceStatuses <IMicrosoftGraphDeviceComplianceDeviceStatus[]>]
 [-DeviceStatusOverview <IMicrosoftGraphDeviceComplianceDeviceOverview>] [-DisplayName <String>]
 [-Id <String>] [-LastModifiedDateTime <DateTime>]
 [-ScheduledActionsForRule <IMicrosoftGraphDeviceComplianceScheduledActionForRule[]>]
 [-UserStatuses <IMicrosoftGraphDeviceComplianceUserStatus[]>]
 [-UserStatusOverview <IMicrosoftGraphDeviceComplianceUserOverview>] [-Version <Int32>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create1
```
New-MgDeviceManagementDeviceCompliancePolicy -BodyParameter <IMicrosoftGraphDeviceCompliancePolicy> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to deviceCompliancePolicies for deviceManagement

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Assignments
The collection of assignments for this compliance policy.
To construct, please use Get-Help -Online and see NOTES section for ASSIGNMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceCompliancePolicyAssignment[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
This is the base class for Compliance policy.
Compliance policies are platform specific and individual per-platform compliance policies inherit from here.

To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceCompliancePolicy
Parameter Sets: Create1
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
Parameter Sets: CreateExpanded1
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
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceSettingStateSummaries
Compliance Setting State Device Summary
To construct, please use Get-Help -Online and see NOTES section for DEVICESETTINGSTATESUMMARIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSettingStateDeviceSummary[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceStatuses
List of DeviceComplianceDeviceStatus.
To construct, please use Get-Help -Online and see NOTES section for DEVICESTATUSES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceComplianceDeviceStatus[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceStatusOverview
deviceComplianceDeviceOverview
To construct, please use Get-Help -Online and see NOTES section for DEVICESTATUSOVERVIEW properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceComplianceDeviceOverview
Parameter Sets: CreateExpanded1
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
Parameter Sets: CreateExpanded1
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
Parameter Sets: CreateExpanded1
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
Parameter Sets: CreateExpanded1
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceComplianceScheduledActionForRule[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserStatuses
List of DeviceComplianceUserStatus.
To construct, please use Get-Help -Online and see NOTES section for USERSTATUSES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceComplianceUserStatus[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserStatusOverview
deviceComplianceUserOverview
To construct, please use Get-Help -Online and see NOTES section for USERSTATUSOVERVIEW properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceComplianceUserOverview
Parameter Sets: CreateExpanded1
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
Parameter Sets: CreateExpanded1
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceCompliancePolicy

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceCompliancePolicy

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ASSIGNMENTS <IMicrosoftGraphDeviceCompliancePolicyAssignment[]>: The collection of assignments for this compliance policy.
  - `[Id <String>]`: 
  - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: Base type for assignment targets.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.

BODYPARAMETER <IMicrosoftGraphDeviceCompliancePolicy>: This is the base class for Compliance policy. Compliance policies are platform specific and individual per-platform compliance policies inherit from here. 
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[Assignments <IMicrosoftGraphDeviceCompliancePolicyAssignment[]>]`: The collection of assignments for this compliance policy.
    - `[Id <String>]`: 
    - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: Base type for assignment targets.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CreatedDateTime <DateTime?>]`: DateTime the object was created.
  - `[Description <String>]`: Admin provided description of the Device Configuration.
  - `[DeviceSettingStateSummaries <IMicrosoftGraphSettingStateDeviceSummary[]>]`: Compliance Setting State Device Summary
    - `[Id <String>]`: 
    - `[CompliantDeviceCount <Int32?>]`: Device Compliant count for the setting
    - `[ConflictDeviceCount <Int32?>]`: Device conflict error count for the setting
    - `[ErrorDeviceCount <Int32?>]`: Device error count for the setting
    - `[InstancePath <String>]`: Name of the InstancePath for the setting
    - `[NonCompliantDeviceCount <Int32?>]`: Device NonCompliant count for the setting
    - `[NotApplicableDeviceCount <Int32?>]`: Device Not Applicable count for the setting
    - `[RemediatedDeviceCount <Int32?>]`: Device Compliant count for the setting
    - `[SettingName <String>]`: Name of the setting
    - `[UnknownDeviceCount <Int32?>]`: Device Unkown count for the setting
  - `[DeviceStatusOverview <IMicrosoftGraphDeviceComplianceDeviceOverview>]`: deviceComplianceDeviceOverview
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[ConfigurationVersion <Int32?>]`: Version of the policy for that overview
    - `[ErrorCount <Int32?>]`: Number of error devices
    - `[FailedCount <Int32?>]`: Number of failed devices
    - `[LastUpdateDateTime <DateTime?>]`: Last update time
    - `[NotApplicableCount <Int32?>]`: Number of not applicable devices
    - `[PendingCount <Int32?>]`: Number of pending devices
    - `[SuccessCount <Int32?>]`: Number of succeeded devices
  - `[DeviceStatuses <IMicrosoftGraphDeviceComplianceDeviceStatus[]>]`: List of DeviceComplianceDeviceStatus.
    - `[Id <String>]`: 
    - `[ComplianceGracePeriodExpirationDateTime <DateTime?>]`: The DateTime when device compliance grace period expires
    - `[DeviceDisplayName <String>]`: Device name of the DevicePolicyStatus.
    - `[DeviceModel <String>]`: The device model that is being reported
    - `[LastReportedDateTime <DateTime?>]`: Last modified date time of the policy report.
    - `[Status <String>]`: complianceStatus
    - `[UserName <String>]`: The User Name that is being reported
    - `[UserPrincipalName <String>]`: UserPrincipalName.
  - `[DisplayName <String>]`: Admin provided name of the device configuration.
  - `[LastModifiedDateTime <DateTime?>]`: DateTime the object was last modified.
  - `[ScheduledActionsForRule <IMicrosoftGraphDeviceComplianceScheduledActionForRule[]>]`: The list of scheduled action for this rule
    - `[Id <String>]`: 
    - `[RuleName <String>]`: Name of the rule which this scheduled action applies to. Currently scheduled actions are created per policy instead of per rule, thus RuleName is always set to default value PasswordRequired.
    - `[ScheduledActionConfigurations <IMicrosoftGraphDeviceComplianceActionItem[]>]`: The list of scheduled action configurations for this compliance policy. Compliance policy must have one and only one block scheduled action.
      - `[Id <String>]`: 
      - `[ActionType <DeviceComplianceActionType?>]`: Scheduled Action Type Enum
      - `[GracePeriodHours <Int32?>]`: Number of hours to wait till the action will be enforced. Valid values 0 to 8760
      - `[NotificationMessageCcList <String[]>]`: A list of group IDs to speicify who to CC this notification message to.
      - `[NotificationTemplateId <String>]`: What notification Message template to use
  - `[UserStatusOverview <IMicrosoftGraphDeviceComplianceUserOverview>]`: deviceComplianceUserOverview
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[ConfigurationVersion <Int32?>]`: Version of the policy for that overview
    - `[ErrorCount <Int32?>]`: Number of error Users
    - `[FailedCount <Int32?>]`: Number of failed Users
    - `[LastUpdateDateTime <DateTime?>]`: Last update time
    - `[NotApplicableCount <Int32?>]`: Number of not applicable users
    - `[PendingCount <Int32?>]`: Number of pending Users
    - `[SuccessCount <Int32?>]`: Number of succeeded Users
  - `[UserStatuses <IMicrosoftGraphDeviceComplianceUserStatus[]>]`: List of DeviceComplianceUserStatus.
    - `[Id <String>]`: 
    - `[DevicesCount <Int32?>]`: Devices count for that user.
    - `[LastReportedDateTime <DateTime?>]`: Last modified date time of the policy report.
    - `[Status <String>]`: complianceStatus
    - `[UserDisplayName <String>]`: User name of the DevicePolicyStatus.
    - `[UserPrincipalName <String>]`: UserPrincipalName.
  - `[Version <Int32?>]`: Version of the device configuration.

DEVICESETTINGSTATESUMMARIES <IMicrosoftGraphSettingStateDeviceSummary[]>: Compliance Setting State Device Summary
  - `[Id <String>]`: 
  - `[CompliantDeviceCount <Int32?>]`: Device Compliant count for the setting
  - `[ConflictDeviceCount <Int32?>]`: Device conflict error count for the setting
  - `[ErrorDeviceCount <Int32?>]`: Device error count for the setting
  - `[InstancePath <String>]`: Name of the InstancePath for the setting
  - `[NonCompliantDeviceCount <Int32?>]`: Device NonCompliant count for the setting
  - `[NotApplicableDeviceCount <Int32?>]`: Device Not Applicable count for the setting
  - `[RemediatedDeviceCount <Int32?>]`: Device Compliant count for the setting
  - `[SettingName <String>]`: Name of the setting
  - `[UnknownDeviceCount <Int32?>]`: Device Unkown count for the setting

DEVICESTATUSES <IMicrosoftGraphDeviceComplianceDeviceStatus[]>: List of DeviceComplianceDeviceStatus.
  - `[Id <String>]`: 
  - `[ComplianceGracePeriodExpirationDateTime <DateTime?>]`: The DateTime when device compliance grace period expires
  - `[DeviceDisplayName <String>]`: Device name of the DevicePolicyStatus.
  - `[DeviceModel <String>]`: The device model that is being reported
  - `[LastReportedDateTime <DateTime?>]`: Last modified date time of the policy report.
  - `[Status <String>]`: complianceStatus
  - `[UserName <String>]`: The User Name that is being reported
  - `[UserPrincipalName <String>]`: UserPrincipalName.

DEVICESTATUSOVERVIEW <IMicrosoftGraphDeviceComplianceDeviceOverview>: deviceComplianceDeviceOverview
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[ConfigurationVersion <Int32?>]`: Version of the policy for that overview
  - `[ErrorCount <Int32?>]`: Number of error devices
  - `[FailedCount <Int32?>]`: Number of failed devices
  - `[LastUpdateDateTime <DateTime?>]`: Last update time
  - `[NotApplicableCount <Int32?>]`: Number of not applicable devices
  - `[PendingCount <Int32?>]`: Number of pending devices
  - `[SuccessCount <Int32?>]`: Number of succeeded devices

SCHEDULEDACTIONSFORRULE <IMicrosoftGraphDeviceComplianceScheduledActionForRule[]>: The list of scheduled action for this rule
  - `[Id <String>]`: 
  - `[RuleName <String>]`: Name of the rule which this scheduled action applies to. Currently scheduled actions are created per policy instead of per rule, thus RuleName is always set to default value PasswordRequired.
  - `[ScheduledActionConfigurations <IMicrosoftGraphDeviceComplianceActionItem[]>]`: The list of scheduled action configurations for this compliance policy. Compliance policy must have one and only one block scheduled action.
    - `[Id <String>]`: 
    - `[ActionType <DeviceComplianceActionType?>]`: Scheduled Action Type Enum
    - `[GracePeriodHours <Int32?>]`: Number of hours to wait till the action will be enforced. Valid values 0 to 8760
    - `[NotificationMessageCcList <String[]>]`: A list of group IDs to speicify who to CC this notification message to.
    - `[NotificationTemplateId <String>]`: What notification Message template to use

USERSTATUSES <IMicrosoftGraphDeviceComplianceUserStatus[]>: List of DeviceComplianceUserStatus.
  - `[Id <String>]`: 
  - `[DevicesCount <Int32?>]`: Devices count for that user.
  - `[LastReportedDateTime <DateTime?>]`: Last modified date time of the policy report.
  - `[Status <String>]`: complianceStatus
  - `[UserDisplayName <String>]`: User name of the DevicePolicyStatus.
  - `[UserPrincipalName <String>]`: UserPrincipalName.

USERSTATUSOVERVIEW <IMicrosoftGraphDeviceComplianceUserOverview>: deviceComplianceUserOverview
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[ConfigurationVersion <Int32?>]`: Version of the policy for that overview
  - `[ErrorCount <Int32?>]`: Number of error Users
  - `[FailedCount <Int32?>]`: Number of failed Users
  - `[LastUpdateDateTime <DateTime?>]`: Last update time
  - `[NotApplicableCount <Int32?>]`: Number of not applicable users
  - `[PendingCount <Int32?>]`: Number of pending Users
  - `[SuccessCount <Int32?>]`: Number of succeeded Users

## RELATED LINKS

