---
external help file:
Module Name: Microsoft.Graph.DeviceManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement/new-mgdevicemanagementuserexperienceanalyticworkfromanywheremodelperformance
schema: 2.0.0
---

# New-MgDeviceManagementUserExperienceAnalyticWorkFromAnywhereModelPerformance

## SYNOPSIS
Create new navigation property to userExperienceAnalyticsWorkFromAnywhereModelPerformance for deviceManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementUserExperienceAnalyticWorkFromAnywhereModelPerformance
 [-AdditionalProperties <Hashtable>] [-CloudIdentityScore <Double>] [-CloudManagementScore <Double>]
 [-CloudProvisioningScore <Double>] [-HealthStatus <String>] [-Id <String>] [-Manufacturer <String>]
 [-Model <String>] [-ModelDeviceCount <Int32>] [-WindowsScore <Double>] [-WorkFromAnywhereScore <Double>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementUserExperienceAnalyticWorkFromAnywhereModelPerformance
 -BodyParameter <IMicrosoftGraphUserExperienceAnalyticsWorkFromAnywhereModelPerformance> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to userExperienceAnalyticsWorkFromAnywhereModelPerformance for deviceManagement

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
The user experience analytics work from anywhere model performance.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsWorkFromAnywhereModelPerformance
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CloudIdentityScore
The user experience work from anywhere's cloud identity score for the model.
Valid values -1.79769313486232E+308 to 1.79769313486232E+308

```yaml
Type: System.Double
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CloudManagementScore
The user experience work from anywhere's cloud management score for the model.
Valid values -1.79769313486232E+308 to 1.79769313486232E+308

```yaml
Type: System.Double
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CloudProvisioningScore
The user experience work from anywhere's cloud provisioning score for the model.
Valid values -1.79769313486232E+308 to 1.79769313486232E+308

```yaml
Type: System.Double
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HealthStatus
userExperienceAnalyticsHealthState

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

### -Manufacturer
The user experience work from anywhere's manufacturer name of the devices.

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

### -Model
The user experience work from anywhere's model name of the devices.

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

### -ModelDeviceCount
The user experience work from anywhere's devices count for the model.
Valid values -2147483648 to 2147483647

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

### -WindowsScore
The user experience work from anywhere windows score for the model.
Valid values -1.79769313486232E+308 to 1.79769313486232E+308

```yaml
Type: System.Double
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WorkFromAnywhereScore
The user experience work from anywhere overall score for the model.
Valid values -1.79769313486232E+308 to 1.79769313486232E+308

```yaml
Type: System.Double
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsWorkFromAnywhereModelPerformance

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsWorkFromAnywhereModelPerformance

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphUserExperienceAnalyticsWorkFromAnywhereModelPerformance>: The user experience analytics work from anywhere model performance.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[CloudIdentityScore <Double?>]`: The user experience work from anywhere's cloud identity score for the model. Valid values -1.79769313486232E+308 to 1.79769313486232E+308
  - `[CloudManagementScore <Double?>]`: The user experience work from anywhere's cloud management score for the model. Valid values -1.79769313486232E+308 to 1.79769313486232E+308
  - `[CloudProvisioningScore <Double?>]`: The user experience work from anywhere's cloud provisioning score for the model. Valid values -1.79769313486232E+308 to 1.79769313486232E+308
  - `[HealthStatus <String>]`: userExperienceAnalyticsHealthState
  - `[Manufacturer <String>]`: The user experience work from anywhere's manufacturer name of the devices.
  - `[Model <String>]`: The user experience work from anywhere's model name of the devices.
  - `[ModelDeviceCount <Int32?>]`: The user experience work from anywhere's devices count for the model. Valid values -2147483648 to 2147483647
  - `[WindowsScore <Double?>]`: The user experience work from anywhere windows score for the model. Valid values -1.79769313486232E+308 to 1.79769313486232E+308
  - `[WorkFromAnywhereScore <Double?>]`: The user experience work from anywhere overall score for the model. Valid values -1.79769313486232E+308 to 1.79769313486232E+308

## RELATED LINKS

