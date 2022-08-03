---
external help file:
Module Name: Microsoft.Graph.DeviceManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement/new-mgdevicemanagementuserexperienceanalyticapphealthapplicationperformancebyappversiondetail
schema: 2.0.0
---

# New-MgDeviceManagementUserExperienceAnalyticAppHealthApplicationPerformanceByAppVersionDetail

## SYNOPSIS
Create new navigation property to userExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDetails for deviceManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementUserExperienceAnalyticAppHealthApplicationPerformanceByAppVersionDetail
 [-AdditionalProperties <Hashtable>] [-AppCrashCount <Int32>] [-AppDisplayName <String>] [-AppName <String>]
 [-AppPublisher <String>] [-AppVersion <String>] [-DeviceCountWithCrashes <Int32>] [-Id <String>]
 [-IsLatestUsedVersion] [-IsMostUsedVersion] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementUserExperienceAnalyticAppHealthApplicationPerformanceByAppVersionDetail
 -BodyParameter <IMicrosoftGraphUserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDetails> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to userExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDetails for deviceManagement

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

### -AppCrashCount
The number of crashes for the app.
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

### -AppDisplayName
The friendly name of the application.

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

### -AppName
The name of the application.

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

### -AppPublisher
The publisher of the application.

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

### -AppVersion
The version of the application.

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

### -BodyParameter
The user experience analytics application performance entity contains app performance by app version details.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDetails
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DeviceCountWithCrashes
The total number of devices that have reported one or more application crashes for this application and version.
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

### -IsLatestUsedVersion
Is the version of application the latest version for that app that is in use.

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

### -IsMostUsedVersion
Is the version of application the most used version for that app.

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDetails

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDetails

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphUserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDetails>: The user experience analytics application performance entity contains app performance by app version details.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[AppCrashCount <Int32?>]`: The number of crashes for the app. Valid values -2147483648 to 2147483647
  - `[AppDisplayName <String>]`: The friendly name of the application.
  - `[AppName <String>]`: The name of the application.
  - `[AppPublisher <String>]`: The publisher of the application.
  - `[AppVersion <String>]`: The version of the application.
  - `[DeviceCountWithCrashes <Int32?>]`: The total number of devices that have reported one or more application crashes for this application and version. Valid values -2147483648 to 2147483647
  - `[IsLatestUsedVersion <Boolean?>]`: Is the version of application the latest version for that app that is in use.
  - `[IsMostUsedVersion <Boolean?>]`: Is the version of application the most used version for that app.

## RELATED LINKS

