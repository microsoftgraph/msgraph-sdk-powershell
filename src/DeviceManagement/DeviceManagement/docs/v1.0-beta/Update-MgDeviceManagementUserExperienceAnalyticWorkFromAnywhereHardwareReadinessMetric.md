---
external help file:
Module Name: Microsoft.Graph.DeviceManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement/update-mgdevicemanagementuserexperienceanalyticworkfromanywherehardwarereadinessmetric
schema: 2.0.0
---

# Update-MgDeviceManagementUserExperienceAnalyticWorkFromAnywhereHardwareReadinessMetric

## SYNOPSIS
Update the navigation property userExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric in deviceManagement

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgDeviceManagementUserExperienceAnalyticWorkFromAnywhereHardwareReadinessMetric
 [-AdditionalProperties <Hashtable>] [-Id <String>] [-OSCheckFailedPercentage <Double>]
 [-Processor64BitCheckFailedPercentage <Double>] [-ProcessorCoreCountCheckFailedPercentage <Double>]
 [-ProcessorFamilyCheckFailedPercentage <Double>] [-ProcessorSpeedCheckFailedPercentage <Double>]
 [-RamCheckFailedPercentage <Double>] [-SecureBootCheckFailedPercentage <Double>]
 [-StorageCheckFailedPercentage <Double>] [-TotalDeviceCount <Int32>] [-TpmCheckFailedPercentage <Double>]
 [-UpgradeEligibleDeviceCount <Int32>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgDeviceManagementUserExperienceAnalyticWorkFromAnywhereHardwareReadinessMetric
 -BodyParameter <IMicrosoftGraphUserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric> [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property userExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric in deviceManagement

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
The user experience analytics hardware readiness entity contains account level information about hardware blockers for windows upgrade.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric
Parameter Sets: Update
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
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OSCheckFailedPercentage
The percentage of devices for which OS check has failed.
Valid values -1.79769313486232E+308 to 1.79769313486232E+308

```yaml
Type: System.Double
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PassThru
Returns true when the command succeeds

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Processor64BitCheckFailedPercentage
The percentage of devices for which processor hardware 64-bit architecture check has failed.
Valid values -1.79769313486232E+308 to 1.79769313486232E+308

```yaml
Type: System.Double
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProcessorCoreCountCheckFailedPercentage
The percentage of devices for which processor hardware core count check has failed.
Valid values -1.79769313486232E+308 to 1.79769313486232E+308

```yaml
Type: System.Double
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProcessorFamilyCheckFailedPercentage
The percentage of devices for which processor hardware family check has failed.
Valid values -1.79769313486232E+308 to 1.79769313486232E+308

```yaml
Type: System.Double
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProcessorSpeedCheckFailedPercentage
The percentage of devices for which processor hardware speed check has failed.
Valid values -1.79769313486232E+308 to 1.79769313486232E+308

```yaml
Type: System.Double
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RamCheckFailedPercentage
The percentage of devices for which RAM hardware check has failed.
Valid values -1.79769313486232E+308 to 1.79769313486232E+308

```yaml
Type: System.Double
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SecureBootCheckFailedPercentage
The percentage of devices for which secure boot hardware check has failed.
Valid values -1.79769313486232E+308 to 1.79769313486232E+308

```yaml
Type: System.Double
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StorageCheckFailedPercentage
The percentage of devices for which storage hardware check has failed.
Valid values -1.79769313486232E+308 to 1.79769313486232E+308

```yaml
Type: System.Double
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TotalDeviceCount
The count of total devices in an organization.
Valid values -2147483648 to 2147483647

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TpmCheckFailedPercentage
The percentage of devices for which Trusted Platform Module (TPM) hardware check has failed.
Valid values -1.79769313486232E+308 to 1.79769313486232E+308

```yaml
Type: System.Double
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UpgradeEligibleDeviceCount
The count of devices in an organization eligible for windows upgrade.
Valid values -2147483648 to 2147483647

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphUserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric>: The user experience analytics hardware readiness entity contains account level information about hardware blockers for windows upgrade.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[OSCheckFailedPercentage <Double?>]`: The percentage of devices for which OS check has failed. Valid values -1.79769313486232E+308 to 1.79769313486232E+308
  - `[Processor64BitCheckFailedPercentage <Double?>]`: The percentage of devices for which processor hardware 64-bit architecture check has failed. Valid values -1.79769313486232E+308 to 1.79769313486232E+308
  - `[ProcessorCoreCountCheckFailedPercentage <Double?>]`: The percentage of devices for which processor hardware core count check has failed. Valid values -1.79769313486232E+308 to 1.79769313486232E+308
  - `[ProcessorFamilyCheckFailedPercentage <Double?>]`: The percentage of devices for which processor hardware family check has failed. Valid values -1.79769313486232E+308 to 1.79769313486232E+308
  - `[ProcessorSpeedCheckFailedPercentage <Double?>]`: The percentage of devices for which processor hardware speed check has failed. Valid values -1.79769313486232E+308 to 1.79769313486232E+308
  - `[RamCheckFailedPercentage <Double?>]`: The percentage of devices for which RAM hardware check has failed. Valid values -1.79769313486232E+308 to 1.79769313486232E+308
  - `[SecureBootCheckFailedPercentage <Double?>]`: The percentage of devices for which secure boot hardware check has failed. Valid values -1.79769313486232E+308 to 1.79769313486232E+308
  - `[StorageCheckFailedPercentage <Double?>]`: The percentage of devices for which storage hardware check has failed. Valid values -1.79769313486232E+308 to 1.79769313486232E+308
  - `[TotalDeviceCount <Int32?>]`: The count of total devices in an organization. Valid values -2147483648 to 2147483647
  - `[TpmCheckFailedPercentage <Double?>]`: The percentage of devices for which Trusted Platform Module (TPM) hardware check has failed. Valid values -1.79769313486232E+308 to 1.79769313486232E+308
  - `[UpgradeEligibleDeviceCount <Int32?>]`: The count of devices in an organization eligible for windows upgrade. Valid values -2147483648 to 2147483647

## RELATED LINKS

