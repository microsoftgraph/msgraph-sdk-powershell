---
external help file:
Module Name: Microsoft.Graph.DeviceManagement
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.devicemanagement/new-mgdevicemanagementuserexperienceanalyticdevicestartuphistory
schema: 2.0.0
---

# New-MgDeviceManagementUserExperienceAnalyticDeviceStartupHistory

## SYNOPSIS
Create new navigation property to userExperienceAnalyticsDeviceStartupHistory for deviceManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementUserExperienceAnalyticDeviceStartupHistory [-AdditionalProperties <Hashtable>]
 [-CoreBootTimeInMS <Int32>] [-CoreLoginTimeInMS <Int32>] [-DeviceId <String>]
 [-FeatureUpdateBootTimeInMS <Int32>] [-GroupPolicyBootTimeInMS <Int32>] [-GroupPolicyLoginTimeInMS <Int32>]
 [-Id <String>] [-IsFeatureUpdate] [-IsFirstLogin] [-OperatingSystemVersion <String>]
 [-ResponsiveDesktopTimeInMS <Int32>]
 [-RestartCategory <UserExperienceAnalyticsOperatingSystemRestartCategory>] [-RestartFaultBucket <String>]
 [-RestartStopCode <String>] [-StartTime <DateTime>] [-TotalBootTimeInMS <Int32>]
 [-TotalLoginTimeInMS <Int32>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementUserExperienceAnalyticDeviceStartupHistory
 -BodyParameter <IMicrosoftGraphUserExperienceAnalyticsDeviceStartupHistory> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to userExperienceAnalyticsDeviceStartupHistory for deviceManagement

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```



### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```



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
The user experience analytics device startup history entity contains device boot performance history details.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsDeviceStartupHistory
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CoreBootTimeInMS
The device core boot time in milliseconds.
Supports: $select, $OrderBy.
Read-only.

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

### -CoreLoginTimeInMS
The device core login time in milliseconds.
Supports: $select, $OrderBy.
Read-only.

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

### -DeviceId
The Intune device id of the device.
Supports: $select, $OrderBy.
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

### -FeatureUpdateBootTimeInMS
The impact of device feature updates on boot time in milliseconds.
Supports: $select, $OrderBy.
Read-only.

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

### -GroupPolicyBootTimeInMS
The impact of device group policy client on boot time in milliseconds.
Supports: $select, $OrderBy.
Read-only.

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

### -GroupPolicyLoginTimeInMS
The impact of device group policy client on login time in milliseconds.
Supports: $select, $OrderBy.
Read-only.

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

### -IsFeatureUpdate
When TRUE, indicates the device boot record is associated with feature updates.
When FALSE, indicates the device boot record is not associated with feature updates.
Supports: $select, $OrderBy.
Read-only.

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

### -IsFirstLogin
When TRUE, indicates the device login is the first login after a reboot.
When FALSE, indicates the device login is not the first login after a reboot.
Supports: $select, $OrderBy.
Read-only.

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

### -OperatingSystemVersion
The user experience analytics device boot record's operating system version.
Supports: $select, $OrderBy.
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

### -ResponsiveDesktopTimeInMS
The time for desktop to become responsive during login process in milliseconds.
Supports: $select, $OrderBy.
Read-only.

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

### -RestartCategory
Operating System restart category.

```yaml
Type: Microsoft.Graph.PowerShell.Support.UserExperienceAnalyticsOperatingSystemRestartCategory
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RestartFaultBucket
OS restart fault bucket.
The fault bucket is used to find additional information about a system crash.
Supports: $select, $OrderBy.
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

### -RestartStopCode
OS restart stop code.
This shows the bug check code which can be used to look up the blue screen reason.
Supports: $select, $OrderBy.
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

### -StartTime
The device boot start time.
The value cannot be modified and is automatically populated when the device performs a reboot.
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2022 would look like this: '2022-01-01T00:00:00Z'.
Returned by default.
Read-only.

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

### -TotalBootTimeInMS
The device total boot time in milliseconds.
Supports: $select, $OrderBy.
Read-only.

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

### -TotalLoginTimeInMS
The device total login time in milliseconds.
Supports: $select, $OrderBy.
Read-only.

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsDeviceStartupHistory

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsDeviceStartupHistory

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphUserExperienceAnalyticsDeviceStartupHistory>`: The user experience analytics device startup history entity contains device boot performance history details.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[CoreBootTimeInMS <Int32?>]`: The device core boot time in milliseconds. Supports: $select, $OrderBy. Read-only.
  - `[CoreLoginTimeInMS <Int32?>]`: The device core login time in milliseconds. Supports: $select, $OrderBy. Read-only.
  - `[DeviceId <String>]`: The Intune device id of the device. Supports: $select, $OrderBy. Read-only.
  - `[FeatureUpdateBootTimeInMS <Int32?>]`: The impact of device feature updates on boot time in milliseconds. Supports: $select, $OrderBy. Read-only.
  - `[GroupPolicyBootTimeInMS <Int32?>]`: The impact of device group policy client on boot time in milliseconds. Supports: $select, $OrderBy. Read-only.
  - `[GroupPolicyLoginTimeInMS <Int32?>]`: The impact of device group policy client on login time in milliseconds. Supports: $select, $OrderBy. Read-only.
  - `[IsFeatureUpdate <Boolean?>]`: When TRUE, indicates the device boot record is associated with feature updates. When FALSE, indicates the device boot record is not associated with feature updates. Supports: $select, $OrderBy. Read-only.
  - `[IsFirstLogin <Boolean?>]`: When TRUE, indicates the device login is the first login after a reboot. When FALSE, indicates the device login is not the first login after a reboot. Supports: $select, $OrderBy. Read-only.
  - `[OperatingSystemVersion <String>]`: The user experience analytics device boot record's operating system version. Supports: $select, $OrderBy. Read-only.
  - `[ResponsiveDesktopTimeInMS <Int32?>]`: The time for desktop to become responsive during login process in milliseconds. Supports: $select, $OrderBy. Read-only.
  - `[RestartCategory <UserExperienceAnalyticsOperatingSystemRestartCategory?>]`: Operating System restart category.
  - `[RestartFaultBucket <String>]`: OS restart fault bucket. The fault bucket is used to find additional information about a system crash. Supports: $select, $OrderBy. Read-only.
  - `[RestartStopCode <String>]`: OS restart stop code. This shows the bug check code which can be used to look up the blue screen reason. Supports: $select, $OrderBy. Read-only.
  - `[StartTime <DateTime?>]`: The device boot start time. The value cannot be modified and is automatically populated when the device performs a reboot. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2022 would look like this: '2022-01-01T00:00:00Z'. Returned by default. Read-only.
  - `[TotalBootTimeInMS <Int32?>]`: The device total boot time in milliseconds. Supports: $select, $OrderBy. Read-only.
  - `[TotalLoginTimeInMS <Int32?>]`: The device total login time in milliseconds. Supports: $select, $OrderBy. Read-only.

## RELATED LINKS

