---
external help file:
Module Name: Microsoft.Graph.DeviceManagement.Enrolment
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.enrolment/new-mgdevicemanagementdeviceenrollmentconfiguration
schema: 2.0.0
---

# New-MgDeviceManagementDeviceEnrollmentConfiguration

## SYNOPSIS
The list of device enrollment configurations

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementDeviceEnrollmentConfiguration [-AdditionalProperties <Hashtable>]
 [-Assignments <IMicrosoftGraphEnrollmentConfigurationAssignment[]>] [-CreatedDateTime <DateTime>]
 [-Description <String>] [-DisplayName <String>] [-Id <String>] [-LastModifiedDateTime <DateTime>]
 [-Priority <Int32>] [-Version <Int32>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementDeviceEnrollmentConfiguration
 -BodyParameter <IMicrosoftGraphDeviceEnrollmentConfiguration> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
The list of device enrollment configurations

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

### -Assignments
The list of group assignments for the device configuration profile
To construct, please use Get-Help -Online and see NOTES section for ASSIGNMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEnrollmentConfigurationAssignment[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
The Base Class of Device Enrollment Configuration
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceEnrollmentConfiguration
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedDateTime
Created date time in UTC of the device enrollment configuration

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
The description of the device enrollment configuration

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

### -DisplayName
The display name of the device enrollment configuration

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
Last modified date time in UTC of the device enrollment configuration

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

### -Priority
Priority is used when a user exists in multiple groups that are assigned enrollment configuration.
Users are subject only to the configuration with the lowest priority value.

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
The version of the device enrollment configuration

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceEnrollmentConfiguration

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceEnrollmentConfiguration

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ASSIGNMENTS <IMicrosoftGraphEnrollmentConfigurationAssignment[]>: The list of group assignments for the device configuration profile
  - `[Id <String>]`: Read-only.
  - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: Base type for assignment targets.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.

BODYPARAMETER <IMicrosoftGraphDeviceEnrollmentConfiguration>: The Base Class of Device Enrollment Configuration
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[Assignments <IMicrosoftGraphEnrollmentConfigurationAssignment[]>]`: The list of group assignments for the device configuration profile
    - `[Id <String>]`: Read-only.
    - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: Base type for assignment targets.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CreatedDateTime <DateTime?>]`: Created date time in UTC of the device enrollment configuration
  - `[Description <String>]`: The description of the device enrollment configuration
  - `[DisplayName <String>]`: The display name of the device enrollment configuration
  - `[LastModifiedDateTime <DateTime?>]`: Last modified date time in UTC of the device enrollment configuration
  - `[Priority <Int32?>]`: Priority is used when a user exists in multiple groups that are assigned enrollment configuration. Users are subject only to the configuration with the lowest priority value.
  - `[Version <Int32?>]`: The version of the device enrollment configuration

## RELATED LINKS

