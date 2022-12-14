---
external help file:
Module Name: Microsoft.Graph.Beta.DeviceManagement.Actions
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.devicemanagement.actions/new-mgdevicemanagementdeviceenrollmentconfigurationenrollmentnotificationconfiguration
schema: 2.0.0
---

# New-MgBetaDeviceManagementDeviceEnrollmentConfigurationEnrollmentNotificationConfiguration

## SYNOPSIS
Invoke action createEnrollmentNotificationConfiguration

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaDeviceManagementDeviceEnrollmentConfigurationEnrollmentNotificationConfiguration
 [-AdditionalProperties <Hashtable>]
 [-DeviceEnrollmentNotificationConfigurations <IMicrosoftGraphDeviceEnrollmentConfiguration[]>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgBetaDeviceManagementDeviceEnrollmentConfigurationEnrollmentNotificationConfiguration
 -BodyParameter <IPaths7Rv6Q9DevicemanagementDeviceenrollmentconfigurationsMicrosoftGraphCreateenrollmentnotificationconfigurationPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action createEnrollmentNotificationConfiguration

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
.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IPaths7Rv6Q9DevicemanagementDeviceenrollmentconfigurationsMicrosoftGraphCreateenrollmentnotificationconfigurationPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DeviceEnrollmentNotificationConfigurations
.
To construct, please use Get-Help -Online and see NOTES section for DEVICEENROLLMENTNOTIFICATIONCONFIGURATIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDeviceEnrollmentConfiguration[]
Parameter Sets: CreateExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IPaths7Rv6Q9DevicemanagementDeviceenrollmentconfigurationsMicrosoftGraphCreateenrollmentnotificationconfigurationPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths7Rv6Q9DevicemanagementDeviceenrollmentconfigurationsMicrosoftGraphCreateenrollmentnotificationconfigurationPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DeviceEnrollmentNotificationConfigurations <IMicrosoftGraphDeviceEnrollmentConfiguration[]>]`: 
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Assignments <IMicrosoftGraphEnrollmentConfigurationAssignment1[]>]`: The list of group assignments for the device configuration profile
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[Source <DeviceAndAppManagementAssignmentSource?>]`: Represents source of assignment.
      - `[SourceId <String>]`: Identifier for resource used for deployment to a group
      - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget1>]`: Base type for assignment targets.
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
        - `[DeviceAndAppManagementAssignmentFilterType <DeviceAndAppManagementAssignmentFilterType?>]`: Represents type of the assignment filter.
    - `[CreatedDateTime <DateTime?>]`: Created date time in UTC of the device enrollment configuration
    - `[Description <String>]`: The description of the device enrollment configuration
    - `[DeviceEnrollmentConfigurationType <DeviceEnrollmentConfigurationType?>]`: Describes the TemplateFamily for the Template entity
    - `[DisplayName <String>]`: The display name of the device enrollment configuration
    - `[LastModifiedDateTime <DateTime?>]`: Last modified date time in UTC of the device enrollment configuration
    - `[Priority <Int32?>]`: Priority is used when a user exists in multiple groups that are assigned enrollment configuration. Users are subject only to the configuration with the lowest priority value.
    - `[RoleScopeTagIds <String[]>]`: Optional role scope tags for the enrollment restrictions.
    - `[Version <Int32?>]`: The version of the device enrollment configuration

DEVICEENROLLMENTNOTIFICATIONCONFIGURATIONS <IMicrosoftGraphDeviceEnrollmentConfiguration[]>: .
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Assignments <IMicrosoftGraphEnrollmentConfigurationAssignment1[]>]`: The list of group assignments for the device configuration profile
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Source <DeviceAndAppManagementAssignmentSource?>]`: Represents source of assignment.
    - `[SourceId <String>]`: Identifier for resource used for deployment to a group
    - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget1>]`: Base type for assignment targets.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
      - `[DeviceAndAppManagementAssignmentFilterType <DeviceAndAppManagementAssignmentFilterType?>]`: Represents type of the assignment filter.
  - `[CreatedDateTime <DateTime?>]`: Created date time in UTC of the device enrollment configuration
  - `[Description <String>]`: The description of the device enrollment configuration
  - `[DeviceEnrollmentConfigurationType <DeviceEnrollmentConfigurationType?>]`: Describes the TemplateFamily for the Template entity
  - `[DisplayName <String>]`: The display name of the device enrollment configuration
  - `[LastModifiedDateTime <DateTime?>]`: Last modified date time in UTC of the device enrollment configuration
  - `[Priority <Int32?>]`: Priority is used when a user exists in multiple groups that are assigned enrollment configuration. Users are subject only to the configuration with the lowest priority value.
  - `[RoleScopeTagIds <String[]>]`: Optional role scope tags for the enrollment restrictions.
  - `[Version <Int32?>]`: The version of the device enrollment configuration

## RELATED LINKS

