---
external help file:
Module Name: Microsoft.Graph.DeviceManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement/new-mgdevicemanagementuserexperienceanalyticdevicescope
schema: 2.0.0
---

# New-MgDeviceManagementUserExperienceAnalyticDeviceScope

## SYNOPSIS
Create new navigation property to userExperienceAnalyticsDeviceScopes for deviceManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementUserExperienceAnalyticDeviceScope [-AdditionalProperties <Hashtable>]
 [-CreatedDateTime <DateTime>] [-DeviceScopeName <String>] [-Enabled] [-Id <String>] [-IsBuiltIn]
 [-LastModifiedDateTime <DateTime>] [-Operator <DeviceScopeOperator>] [-OwnerId <String>]
 [-Parameter <DeviceScopeParameter>] [-Status <DeviceScopeStatus>] [-Value <String>] [-ValueObjectId <String>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementUserExperienceAnalyticDeviceScope
 -BodyParameter <IMicrosoftGraphUserExperienceAnalyticsDeviceScope> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to userExperienceAnalyticsDeviceScopes for deviceManagement

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
The user experience analytics device scope entity contains device scope configuration values use to apply filtering on the endpoint analytics reports.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsDeviceScope
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedDateTime
Indicates the creation date and time for the custom device scope.

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

### -DeviceScopeName
The name of the user experience analytics device Scope configuration.

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

### -Enabled
Indicates whether a device scope is enabled or disabled.
When TRUE, the device scope is enabled.
When FALSE, the device scope is disabled.
Default value is FALSE.

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

### -IsBuiltIn
Indicates whether the device scope configuration is built-in or custom.
When TRUE, the device scope configuration is built-in.
When FALSE, the device scope configuration is custom.
Default value is FALSE.

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

### -LastModifiedDateTime
Indicates the last updated date and time for the custom device scope.

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

### -Operator
Device scope configuration query operator.
Possible values are: equals, notEquals, contains, notContains, greaterThan, lessThan.
Default value: equals.

```yaml
Type: Microsoft.Graph.PowerShell.Support.DeviceScopeOperator
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OwnerId
The unique identifier of the person (admin) who created the device scope configuration.

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

### -Parameter
Device scope configuration parameter.
It will be expend in future to add more parameter.
Eg: device scope parameter can be OS version, Disk Type, Device manufacturer, device model or Scope tag.
Default value: scopeTag.

```yaml
Type: Microsoft.Graph.PowerShell.Support.DeviceScopeParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Status
Indicates the device scope status after the device scope has been enabled.
Possible values are: none, computing, insufficientData or completed.
Default value is none.

```yaml
Type: Microsoft.Graph.PowerShell.Support.DeviceScopeStatus
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Value
The device scope configuration query clause value.

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

### -ValueObjectId
The unique identifier for a user device scope tag Id used for the creation of device scope configuration.

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsDeviceScope

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsDeviceScope

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphUserExperienceAnalyticsDeviceScope>: The user experience analytics device scope entity contains device scope configuration values use to apply filtering on the endpoint analytics reports.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[CreatedDateTime <DateTime?>]`: Indicates the creation date and time for the custom device scope.
  - `[DeviceScopeName <String>]`: The name of the user experience analytics device Scope configuration.
  - `[Enabled <Boolean?>]`: Indicates whether a device scope is enabled or disabled. When TRUE, the device scope is enabled. When FALSE, the device scope is disabled. Default value is FALSE.
  - `[IsBuiltIn <Boolean?>]`: Indicates whether the device scope configuration is built-in or custom. When TRUE, the device scope configuration is built-in. When FALSE, the device scope configuration is custom. Default value is FALSE.
  - `[LastModifiedDateTime <DateTime?>]`: Indicates the last updated date and time for the custom device scope.
  - `[Operator <DeviceScopeOperator?>]`: Device scope configuration query operator. Possible values are: equals, notEquals, contains, notContains, greaterThan, lessThan. Default value: equals.
  - `[OwnerId <String>]`: The unique identifier of the person (admin) who created the device scope configuration.
  - `[Parameter <DeviceScopeParameter?>]`: Device scope configuration parameter. It will be expend in future to add more parameter. Eg: device scope parameter can be OS version, Disk Type, Device manufacturer, device model or Scope tag. Default value: scopeTag.
  - `[Status <DeviceScopeStatus?>]`: Indicates the device scope status after the device scope has been enabled. Possible values are: none, computing, insufficientData or completed. Default value is none.
  - `[Value <String>]`: The device scope configuration query clause value.
  - `[ValueObjectId <String>]`: The unique identifier for a user device scope tag Id used for the creation of device scope configuration.

## RELATED LINKS

