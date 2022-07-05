---
external help file:
Module Name: Microsoft.Graph.DeviceManagement.Administration
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.administration/new-mgdevicemanagementdeviceconfigurationrestrictedappviolation
schema: 2.0.0
---

# New-MgDeviceManagementDeviceConfigurationRestrictedAppViolation

## SYNOPSIS
Create new navigation property to deviceConfigurationRestrictedAppsViolations for deviceManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementDeviceConfigurationRestrictedAppViolation [-AdditionalProperties <Hashtable>]
 [-DeviceConfigurationId <String>] [-DeviceConfigurationName <String>] [-DeviceName <String>] [-Id <String>]
 [-ManagedDeviceId <String>] [-PlatformType <PolicyPlatformType>]
 [-RestrictedApps <IMicrosoftGraphManagedDeviceReportedApp[]>] [-RestrictedAppsState <RestrictedAppsState>]
 [-UserId <String>] [-UserName <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementDeviceConfigurationRestrictedAppViolation
 -BodyParameter <IMicrosoftGraphRestrictedAppsViolation> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to deviceConfigurationRestrictedAppsViolations for deviceManagement

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
Violation of restricted apps configuration profile per device per user
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRestrictedAppsViolation
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DeviceConfigurationId
Device configuration profile unique identifier, must be Guid

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

### -DeviceConfigurationName
Device configuration profile name

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

### -DeviceName
Device name

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

### -ManagedDeviceId
Managed device unique identifier, must be Guid

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

### -PlatformType
Supported platform types for policies.

```yaml
Type: Microsoft.Graph.PowerShell.Support.PolicyPlatformType
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RestrictedApps
List of violated restricted apps
To construct, please use Get-Help -Online and see NOTES section for RESTRICTEDAPPS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedDeviceReportedApp[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RestrictedAppsState
Restricted apps state

```yaml
Type: Microsoft.Graph.PowerShell.Support.RestrictedAppsState
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserId
User unique identifier, must be Guid

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

### -UserName
User name

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRestrictedAppsViolation

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRestrictedAppsViolation

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphRestrictedAppsViolation>: Violation of restricted apps configuration profile per device per user
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[DeviceConfigurationId <String>]`: Device configuration profile unique identifier, must be Guid
  - `[DeviceConfigurationName <String>]`: Device configuration profile name
  - `[DeviceName <String>]`: Device name
  - `[ManagedDeviceId <String>]`: Managed device unique identifier, must be Guid
  - `[PlatformType <PolicyPlatformType?>]`: Supported platform types for policies.
  - `[RestrictedApps <IMicrosoftGraphManagedDeviceReportedApp[]>]`: List of violated restricted apps
    - `[AppId <String>]`: The application or bundle identifier of the application
  - `[RestrictedAppsState <RestrictedAppsState?>]`: Restricted apps state
  - `[UserId <String>]`: User unique identifier, must be Guid
  - `[UserName <String>]`: User name

RESTRICTEDAPPS <IMicrosoftGraphManagedDeviceReportedApp[]>: List of violated restricted apps
  - `[AppId <String>]`: The application or bundle identifier of the application

## RELATED LINKS

