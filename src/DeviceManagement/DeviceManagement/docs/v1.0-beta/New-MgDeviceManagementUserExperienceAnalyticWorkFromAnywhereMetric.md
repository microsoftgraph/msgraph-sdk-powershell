---
external help file:
Module Name: Microsoft.Graph.DeviceManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement/new-mgdevicemanagementuserexperienceanalyticworkfromanywheremetric
schema: 2.0.0
---

# New-MgDeviceManagementUserExperienceAnalyticWorkFromAnywhereMetric

## SYNOPSIS
Create new navigation property to userExperienceAnalyticsWorkFromAnywhereMetrics for deviceManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementUserExperienceAnalyticWorkFromAnywhereMetric [-AdditionalProperties <Hashtable>]
 [-Id <String>] [-MetricDevices <IMicrosoftGraphUserExperienceAnalyticsWorkFromAnywhereDevice[]>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementUserExperienceAnalyticWorkFromAnywhereMetric
 -BodyParameter <IMicrosoftGraphUserExperienceAnalyticsWorkFromAnywhereMetric> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to userExperienceAnalyticsWorkFromAnywhereMetrics for deviceManagement

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
The user experience analytics metric for work from anywhere report
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsWorkFromAnywhereMetric
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### -MetricDevices
The work from anywhere metric devices.
To construct, please use Get-Help -Online and see NOTES section for METRICDEVICES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsWorkFromAnywhereDevice[]
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsWorkFromAnywhereMetric

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsWorkFromAnywhereMetric

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphUserExperienceAnalyticsWorkFromAnywhereMetric>: The user experience analytics metric for work from anywhere report
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[MetricDevices <IMicrosoftGraphUserExperienceAnalyticsWorkFromAnywhereDevice[]>]`: The work from anywhere metric devices.
    - `[Id <String>]`: 
    - `[AutoPilotProfileAssigned <Boolean?>]`: The user experience analytics work from anywhere intune device's autopilotProfileAssigned.
    - `[AutoPilotRegistered <Boolean?>]`: The user experience work from anywhere intune device's autopilotRegistered.
    - `[AzureAdDeviceId <String>]`: The user experience work from anywhere azure Ad device Id.
    - `[AzureAdJoinType <String>]`: The user experience work from anywhere device's azure Ad joinType.
    - `[AzureAdRegistered <Boolean?>]`: The user experience work from anywhere device's azureAdRegistered.
    - `[CloudIdentityScore <Double?>]`: The user experience work from anywhere per device cloud identity score. Valid values -1.79769313486232E+308 to 1.79769313486232E+308
    - `[CloudManagementScore <Double?>]`: The user experience work from anywhere per device cloud management score. Valid values -1.79769313486232E+308 to 1.79769313486232E+308
    - `[CloudProvisioningScore <Double?>]`: The user experience work from anywhere per device cloud provisioning score. Valid values -1.79769313486232E+308 to 1.79769313486232E+308
    - `[CompliancePolicySetToIntune <Boolean?>]`: The user experience work from anywhere device's compliancePolicySetToIntune.
    - `[DeviceId <String>]`: The user experience work from anywhere device Id.
    - `[DeviceName <String>]`: The work from anywhere device's name.
    - `[HealthStatus <String>]`: userExperienceAnalyticsHealthState
    - `[IsCloudManagedGatewayEnabled <Boolean?>]`: The user experience work from anywhere device's Cloud Management Gateway for Configuration Manager is enabled.
    - `[ManagedBy <String>]`: The user experience work from anywhere management agent of the device.
    - `[Manufacturer <String>]`: The user experience work from anywhere device's manufacturer.
    - `[Model <String>]`: The user experience work from anywhere device's model.
    - `[OSCheckFailed <Boolean?>]`: The user experience work from anywhere device, Is OS check failed for device to upgrade to the latest version of windows.
    - `[OSDescription <String>]`: The user experience work from anywhere device's OS Description.
    - `[OSVersion <String>]`: The user experience work from anywhere device's OS Version.
    - `[OtherWorkloadsSetToIntune <Boolean?>]`: The user experience work from anywhere device's otherWorkloadsSetToIntune.
    - `[Ownership <String>]`: The user experience work from anywhere device's ownership.
    - `[Processor64BitCheckFailed <Boolean?>]`: The user experience work from anywhere device, Is processor hardware 64-bit architecture check failed for device to upgrade to the latest version of windows.
    - `[ProcessorCoreCountCheckFailed <Boolean?>]`: The user experience work from anywhere device, Is processor hardware core count check failed for device to upgrade to the latest version of windows.
    - `[ProcessorFamilyCheckFailed <Boolean?>]`: The user experience work from anywhere device, Is processor hardware family check failed for device to upgrade to the latest version of windows.
    - `[ProcessorSpeedCheckFailed <Boolean?>]`: The user experience work from anywhere device, Is processor hardware speed check failed for device to upgrade to the latest version of windows.
    - `[RamCheckFailed <Boolean?>]`: Is the user experience analytics work from anywhere device RAM hardware check failed for device to upgrade to the latest version of windows
    - `[SecureBootCheckFailed <Boolean?>]`: The user experience work from anywhere device, Is secure boot hardware check failed for device to upgrade to the latest version of windows.
    - `[SerialNumber <String>]`: The user experience work from anywhere device's serial number.
    - `[StorageCheckFailed <Boolean?>]`: The user experience work from anywhere device, Is storage hardware check failed for device to upgrade to the latest version of windows.
    - `[TenantAttached <Boolean?>]`: The user experience work from anywhere device's tenantAttached.
    - `[TpmCheckFailed <Boolean?>]`: The user experience work from anywhere device, Is Trusted Platform Module (TPM) hardware check failed for device to the latest version of upgrade to windows.
    - `[UpgradeEligibility <OperatingSystemUpgradeEligibility?>]`: Work From Anywhere windows device upgrade eligibility status
    - `[WindowsScore <Double?>]`: The user experience work from anywhere per device windows score. Valid values -1.79769313486232E+308 to 1.79769313486232E+308
    - `[WorkFromAnywhereScore <Double?>]`: The user experience work from anywhere per device overall score. Valid values -1.79769313486232E+308 to 1.79769313486232E+308

METRICDEVICES <IMicrosoftGraphUserExperienceAnalyticsWorkFromAnywhereDevice[]>: The work from anywhere metric devices.
  - `[Id <String>]`: 
  - `[AutoPilotProfileAssigned <Boolean?>]`: The user experience analytics work from anywhere intune device's autopilotProfileAssigned.
  - `[AutoPilotRegistered <Boolean?>]`: The user experience work from anywhere intune device's autopilotRegistered.
  - `[AzureAdDeviceId <String>]`: The user experience work from anywhere azure Ad device Id.
  - `[AzureAdJoinType <String>]`: The user experience work from anywhere device's azure Ad joinType.
  - `[AzureAdRegistered <Boolean?>]`: The user experience work from anywhere device's azureAdRegistered.
  - `[CloudIdentityScore <Double?>]`: The user experience work from anywhere per device cloud identity score. Valid values -1.79769313486232E+308 to 1.79769313486232E+308
  - `[CloudManagementScore <Double?>]`: The user experience work from anywhere per device cloud management score. Valid values -1.79769313486232E+308 to 1.79769313486232E+308
  - `[CloudProvisioningScore <Double?>]`: The user experience work from anywhere per device cloud provisioning score. Valid values -1.79769313486232E+308 to 1.79769313486232E+308
  - `[CompliancePolicySetToIntune <Boolean?>]`: The user experience work from anywhere device's compliancePolicySetToIntune.
  - `[DeviceId <String>]`: The user experience work from anywhere device Id.
  - `[DeviceName <String>]`: The work from anywhere device's name.
  - `[HealthStatus <String>]`: userExperienceAnalyticsHealthState
  - `[IsCloudManagedGatewayEnabled <Boolean?>]`: The user experience work from anywhere device's Cloud Management Gateway for Configuration Manager is enabled.
  - `[ManagedBy <String>]`: The user experience work from anywhere management agent of the device.
  - `[Manufacturer <String>]`: The user experience work from anywhere device's manufacturer.
  - `[Model <String>]`: The user experience work from anywhere device's model.
  - `[OSCheckFailed <Boolean?>]`: The user experience work from anywhere device, Is OS check failed for device to upgrade to the latest version of windows.
  - `[OSDescription <String>]`: The user experience work from anywhere device's OS Description.
  - `[OSVersion <String>]`: The user experience work from anywhere device's OS Version.
  - `[OtherWorkloadsSetToIntune <Boolean?>]`: The user experience work from anywhere device's otherWorkloadsSetToIntune.
  - `[Ownership <String>]`: The user experience work from anywhere device's ownership.
  - `[Processor64BitCheckFailed <Boolean?>]`: The user experience work from anywhere device, Is processor hardware 64-bit architecture check failed for device to upgrade to the latest version of windows.
  - `[ProcessorCoreCountCheckFailed <Boolean?>]`: The user experience work from anywhere device, Is processor hardware core count check failed for device to upgrade to the latest version of windows.
  - `[ProcessorFamilyCheckFailed <Boolean?>]`: The user experience work from anywhere device, Is processor hardware family check failed for device to upgrade to the latest version of windows.
  - `[ProcessorSpeedCheckFailed <Boolean?>]`: The user experience work from anywhere device, Is processor hardware speed check failed for device to upgrade to the latest version of windows.
  - `[RamCheckFailed <Boolean?>]`: Is the user experience analytics work from anywhere device RAM hardware check failed for device to upgrade to the latest version of windows
  - `[SecureBootCheckFailed <Boolean?>]`: The user experience work from anywhere device, Is secure boot hardware check failed for device to upgrade to the latest version of windows.
  - `[SerialNumber <String>]`: The user experience work from anywhere device's serial number.
  - `[StorageCheckFailed <Boolean?>]`: The user experience work from anywhere device, Is storage hardware check failed for device to upgrade to the latest version of windows.
  - `[TenantAttached <Boolean?>]`: The user experience work from anywhere device's tenantAttached.
  - `[TpmCheckFailed <Boolean?>]`: The user experience work from anywhere device, Is Trusted Platform Module (TPM) hardware check failed for device to the latest version of upgrade to windows.
  - `[UpgradeEligibility <OperatingSystemUpgradeEligibility?>]`: Work From Anywhere windows device upgrade eligibility status
  - `[WindowsScore <Double?>]`: The user experience work from anywhere per device windows score. Valid values -1.79769313486232E+308 to 1.79769313486232E+308
  - `[WorkFromAnywhereScore <Double?>]`: The user experience work from anywhere per device overall score. Valid values -1.79769313486232E+308 to 1.79769313486232E+308

## RELATED LINKS

