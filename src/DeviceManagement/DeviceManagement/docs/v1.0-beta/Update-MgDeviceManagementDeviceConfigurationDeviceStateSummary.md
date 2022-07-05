---
external help file:
Module Name: Microsoft.Graph.DeviceManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement/update-mgdevicemanagementdeviceconfigurationdevicestatesummary
schema: 2.0.0
---

# Update-MgDeviceManagementDeviceConfigurationDeviceStateSummary

## SYNOPSIS
Update the navigation property deviceConfigurationDeviceStateSummaries in deviceManagement

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgDeviceManagementDeviceConfigurationDeviceStateSummary [-AdditionalProperties <Hashtable>]
 [-CompliantDeviceCount <Int32>] [-ConflictDeviceCount <Int32>] [-ErrorDeviceCount <Int32>] [-Id <String>]
 [-NonCompliantDeviceCount <Int32>] [-NotApplicableDeviceCount <Int32>] [-RemediatedDeviceCount <Int32>]
 [-UnknownDeviceCount <Int32>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgDeviceManagementDeviceConfigurationDeviceStateSummary
 -BodyParameter <IMicrosoftGraphDeviceConfigurationDeviceStateSummary> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property deviceConfigurationDeviceStateSummaries in deviceManagement

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
deviceConfigurationDeviceStateSummary
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceConfigurationDeviceStateSummary
Parameter Sets: Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CompliantDeviceCount
Number of compliant devices

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

### -ConflictDeviceCount
Number of conflict devices

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

### -ErrorDeviceCount
Number of error devices

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

### -NonCompliantDeviceCount
Number of NonCompliant devices

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

### -NotApplicableDeviceCount
Number of not applicable devices

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

### -RemediatedDeviceCount
Number of remediated devices

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

### -UnknownDeviceCount
Number of unknown devices

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceConfigurationDeviceStateSummary

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphDeviceConfigurationDeviceStateSummary>: deviceConfigurationDeviceStateSummary
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[CompliantDeviceCount <Int32?>]`: Number of compliant devices
  - `[ConflictDeviceCount <Int32?>]`: Number of conflict devices
  - `[ErrorDeviceCount <Int32?>]`: Number of error devices
  - `[NonCompliantDeviceCount <Int32?>]`: Number of NonCompliant devices
  - `[NotApplicableDeviceCount <Int32?>]`: Number of not applicable devices
  - `[RemediatedDeviceCount <Int32?>]`: Number of remediated devices
  - `[UnknownDeviceCount <Int32?>]`: Number of unknown devices

## RELATED LINKS

