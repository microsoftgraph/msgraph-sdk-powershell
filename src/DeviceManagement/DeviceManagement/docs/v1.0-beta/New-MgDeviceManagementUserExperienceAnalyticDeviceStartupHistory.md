---
external help file:
Module Name: Microsoft.Graph.DeviceManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement/new-mgdevicemanagementuserexperienceanalyticdevicestartuphistory
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
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

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
The user experience analytics device core boot time in milliseconds.

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
The user experience analytics device core login time in milliseconds.

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
The user experience analytics device id.

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
The user experience analytics device feature update time in milliseconds.

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
The User experience analytics Device group policy boot time in milliseconds.

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
The User experience analytics Device group policy login time in milliseconds.

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

### -IsFeatureUpdate
The user experience analytics device boot record is a feature update.

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
The user experience analytics device first login.

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
The user experience analytics responsive desktop time in milliseconds.

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
Operating System restart category

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
The user experience analytics device boot start time.

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
The user experience analytics device total boot time in milliseconds.

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
The user experience analytics device total login time in milliseconds.

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


BODYPARAMETER <IMicrosoftGraphUserExperienceAnalyticsDeviceStartupHistory>: The user experience analytics device startup history entity contains device boot performance history details.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[CoreBootTimeInMS <Int32?>]`: The user experience analytics device core boot time in milliseconds.
  - `[CoreLoginTimeInMS <Int32?>]`: The user experience analytics device core login time in milliseconds.
  - `[DeviceId <String>]`: The user experience analytics device id.
  - `[FeatureUpdateBootTimeInMS <Int32?>]`: The user experience analytics device feature update time in milliseconds.
  - `[GroupPolicyBootTimeInMS <Int32?>]`: The User experience analytics Device group policy boot time in milliseconds.
  - `[GroupPolicyLoginTimeInMS <Int32?>]`: The User experience analytics Device group policy login time in milliseconds.
  - `[IsFeatureUpdate <Boolean?>]`: The user experience analytics device boot record is a feature update.
  - `[IsFirstLogin <Boolean?>]`: The user experience analytics device first login.
  - `[OperatingSystemVersion <String>]`: The user experience analytics device boot record's operating system version.
  - `[ResponsiveDesktopTimeInMS <Int32?>]`: The user experience analytics responsive desktop time in milliseconds.
  - `[RestartCategory <UserExperienceAnalyticsOperatingSystemRestartCategory?>]`: Operating System restart category
  - `[RestartFaultBucket <String>]`: OS restart fault bucket. The fault bucket is used to find additional information about a system crash.
  - `[RestartStopCode <String>]`: OS restart stop code. This shows the bug check code which can be used to look up the blue screen reason.
  - `[StartTime <DateTime?>]`: The user experience analytics device boot start time.
  - `[TotalBootTimeInMS <Int32?>]`: The user experience analytics device total boot time in milliseconds.
  - `[TotalLoginTimeInMS <Int32?>]`: The user experience analytics device total login time in milliseconds.

## RELATED LINKS

