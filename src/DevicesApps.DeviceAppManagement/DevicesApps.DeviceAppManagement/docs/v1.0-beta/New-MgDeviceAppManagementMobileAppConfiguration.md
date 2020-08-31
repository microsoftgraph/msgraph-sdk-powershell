---
external help file:
Module Name: Microsoft.Graph.DevicesApps.DeviceAppManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicesapps.deviceappmanagement/new-mgdeviceappmanagementmobileappconfiguration
schema: 2.0.0
---

# New-MgDeviceAppManagementMobileAppConfiguration

## SYNOPSIS
Create new navigation property to mobileAppConfigurations for deviceAppManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceAppManagementMobileAppConfiguration
 [-Assignments <IMicrosoftGraphManagedDeviceMobileAppConfigurationAssignment[]>] [-CreatedDateTime <DateTime>]
 [-Description <String>] [-DeviceStatuses <IMicrosoftGraphManagedDeviceMobileAppConfigurationDeviceStatus1[]>]
 [-DeviceStatusSummaryConfigurationVersion <Int32>] [-DeviceStatusSummaryConflictCount <Int32>]
 [-DeviceStatusSummaryErrorCount <Int32>] [-DeviceStatusSummaryFailedCount <Int32>]
 [-DeviceStatusSummaryId <String>] [-DeviceStatusSummaryLastUpdateDateTime <DateTime>]
 [-DeviceStatusSummaryNotApplicableCount <Int32>] [-DeviceStatusSummaryNotApplicablePlatformCount <Int32>]
 [-DeviceStatusSummaryPendingCount <Int32>] [-DeviceStatusSummarySuccessCount <Int32>] [-DisplayName <String>]
 [-Id <String>] [-LastModifiedDateTime <DateTime>] [-RoleScopeTagIds <String[]>]
 [-TargetedMobileApps <String[]>]
 [-UserStatuses <IMicrosoftGraphManagedDeviceMobileAppConfigurationUserStatus[]>]
 [-UserStatusSummaryConfigurationVersion <Int32>] [-UserStatusSummaryConflictCount <Int32>]
 [-UserStatusSummaryErrorCount <Int32>] [-UserStatusSummaryFailedCount <Int32>]
 [-UserStatusSummaryId <String>] [-UserStatusSummaryLastUpdateDateTime <DateTime>]
 [-UserStatusSummaryNotApplicableCount <Int32>] [-UserStatusSummaryPendingCount <Int32>]
 [-UserStatusSummarySuccessCount <Int32>] [-Version <Int32>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgDeviceAppManagementMobileAppConfiguration
 -BodyParameter <IMicrosoftGraphManagedDeviceMobileAppConfiguration1> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to mobileAppConfigurations for deviceAppManagement

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

## PARAMETERS

### -Assignments
The list of group assignemenets for app configration.
To construct, see NOTES section for ASSIGNMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedDeviceMobileAppConfigurationAssignment[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
An abstract class for Mobile app configuration for enrolled devices.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedDeviceMobileAppConfiguration1
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

### -DeviceStatuses
List of ManagedDeviceMobileAppConfigurationDeviceStatus.
To construct, see NOTES section for DEVICESTATUSES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedDeviceMobileAppConfigurationDeviceStatus1[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceStatusSummaryConfigurationVersion
Version of the policy for that overview

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

### -DeviceStatusSummaryConflictCount
Number of devices in conflict

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

### -DeviceStatusSummaryErrorCount
Number of error devices

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

### -DeviceStatusSummaryFailedCount
Number of failed devices

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

### -DeviceStatusSummaryId
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

### -DeviceStatusSummaryLastUpdateDateTime
Last update time

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

### -DeviceStatusSummaryNotApplicableCount
Number of not applicable devices

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

### -DeviceStatusSummaryNotApplicablePlatformCount
Number of not applicable devices due to mismatch platform and policy

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

### -DeviceStatusSummaryPendingCount
Number of pending devices

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

### -DeviceStatusSummarySuccessCount
Number of succeeded devices

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

### -Id
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

### -RoleScopeTagIds
List of Scope Tags for this App configuration entity.

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

### -TargetedMobileApps
the associated app.

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
List of ManagedDeviceMobileAppConfigurationUserStatus.
To construct, see NOTES section for USERSTATUSES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedDeviceMobileAppConfigurationUserStatus[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserStatusSummaryConfigurationVersion
Version of the policy for that overview

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

### -UserStatusSummaryConflictCount
Number of users in conflict

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

### -UserStatusSummaryErrorCount
Number of error Users

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

### -UserStatusSummaryFailedCount
Number of failed Users

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

### -UserStatusSummaryId
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

### -UserStatusSummaryLastUpdateDateTime
Last update time

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

### -UserStatusSummaryNotApplicableCount
Number of not applicable users

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

### -UserStatusSummaryPendingCount
Number of pending Users

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

### -UserStatusSummarySuccessCount
Number of succeeded Users

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedDeviceMobileAppConfiguration1

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedDeviceMobileAppConfiguration1

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ASSIGNMENTS <IMicrosoftGraphManagedDeviceMobileAppConfigurationAssignment[]>: The list of group assignemenets for app configration.
  - `[Id <String>]`: Read-only.
  - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: deviceAndAppManagementAssignmentTarget

BODYPARAMETER <IMicrosoftGraphManagedDeviceMobileAppConfiguration1>: An abstract class for Mobile app configuration for enrolled devices.
  - `[Id <String>]`: Read-only.
  - `[Assignments <IMicrosoftGraphManagedDeviceMobileAppConfigurationAssignment[]>]`: The list of group assignemenets for app configration.
    - `[Id <String>]`: Read-only.
    - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: deviceAndAppManagementAssignmentTarget
  - `[CreatedDateTime <DateTime?>]`: DateTime the object was created.
  - `[Description <String>]`: Admin provided description of the Device Configuration.
  - `[DeviceStatusSummaryConfigurationVersion <Int32?>]`: Version of the policy for that overview
  - `[DeviceStatusSummaryConflictCount <Int32?>]`: Number of devices in conflict
  - `[DeviceStatusSummaryErrorCount <Int32?>]`: Number of error devices
  - `[DeviceStatusSummaryFailedCount <Int32?>]`: Number of failed devices
  - `[DeviceStatusSummaryId <String>]`: Read-only.
  - `[DeviceStatusSummaryLastUpdateDateTime <DateTime?>]`: Last update time
  - `[DeviceStatusSummaryNotApplicableCount <Int32?>]`: Number of not applicable devices
  - `[DeviceStatusSummaryNotApplicablePlatformCount <Int32?>]`: Number of not applicable devices due to mismatch platform and policy
  - `[DeviceStatusSummaryPendingCount <Int32?>]`: Number of pending devices
  - `[DeviceStatusSummarySuccessCount <Int32?>]`: Number of succeeded devices
  - `[DeviceStatuses <IMicrosoftGraphManagedDeviceMobileAppConfigurationDeviceStatus1[]>]`: List of ManagedDeviceMobileAppConfigurationDeviceStatus.
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
  - `[LastModifiedDateTime <DateTime?>]`: DateTime the object was last modified.
  - `[RoleScopeTagIds <String[]>]`: List of Scope Tags for this App configuration entity.
  - `[TargetedMobileApps <String[]>]`: the associated app.
  - `[UserStatusSummaryConfigurationVersion <Int32?>]`: Version of the policy for that overview
  - `[UserStatusSummaryConflictCount <Int32?>]`: Number of users in conflict
  - `[UserStatusSummaryErrorCount <Int32?>]`: Number of error Users
  - `[UserStatusSummaryFailedCount <Int32?>]`: Number of failed Users
  - `[UserStatusSummaryId <String>]`: Read-only.
  - `[UserStatusSummaryLastUpdateDateTime <DateTime?>]`: Last update time
  - `[UserStatusSummaryNotApplicableCount <Int32?>]`: Number of not applicable users
  - `[UserStatusSummaryPendingCount <Int32?>]`: Number of pending Users
  - `[UserStatusSummarySuccessCount <Int32?>]`: Number of succeeded Users
  - `[UserStatuses <IMicrosoftGraphManagedDeviceMobileAppConfigurationUserStatus[]>]`: List of ManagedDeviceMobileAppConfigurationUserStatus.
    - `[Id <String>]`: Read-only.
    - `[DevicesCount <Int32?>]`: Devices count for that user.
    - `[LastReportedDateTime <DateTime?>]`: Last modified date time of the policy report.
    - `[Status <String>]`: complianceStatus
    - `[UserDisplayName <String>]`: User name of the DevicePolicyStatus.
    - `[UserPrincipalName <String>]`: UserPrincipalName.
  - `[Version <Int32?>]`: Version of the device configuration.

DEVICESTATUSES <IMicrosoftGraphManagedDeviceMobileAppConfigurationDeviceStatus1[]>: List of ManagedDeviceMobileAppConfigurationDeviceStatus.
  - `[Id <String>]`: Read-only.
  - `[ComplianceGracePeriodExpirationDateTime <DateTime?>]`: The DateTime when device compliance grace period expires
  - `[DeviceDisplayName <String>]`: Device name of the DevicePolicyStatus.
  - `[DeviceModel <String>]`: The device model that is being reported
  - `[LastReportedDateTime <DateTime?>]`: Last modified date time of the policy report.
  - `[Platform <Int32?>]`: Platform of the device that is being reported
  - `[Status <String>]`: complianceStatus
  - `[UserName <String>]`: The User Name that is being reported
  - `[UserPrincipalName <String>]`: UserPrincipalName.

USERSTATUSES <IMicrosoftGraphManagedDeviceMobileAppConfigurationUserStatus[]>: List of ManagedDeviceMobileAppConfigurationUserStatus.
  - `[Id <String>]`: Read-only.
  - `[DevicesCount <Int32?>]`: Devices count for that user.
  - `[LastReportedDateTime <DateTime?>]`: Last modified date time of the policy report.
  - `[Status <String>]`: complianceStatus
  - `[UserDisplayName <String>]`: User name of the DevicePolicyStatus.
  - `[UserPrincipalName <String>]`: UserPrincipalName.

## RELATED LINKS

