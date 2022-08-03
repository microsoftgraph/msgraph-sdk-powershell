---
external help file:
Module Name: Microsoft.Graph.DeviceManagement.Administration
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.administration/new-mgdevicemanagementvirtualendpointusersetting
schema: 2.0.0
---

# New-MgDeviceManagementVirtualEndpointUserSetting

## SYNOPSIS
Create new navigation property to userSettings for deviceManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementVirtualEndpointUserSetting [-AdditionalProperties <Hashtable>]
 [-Assignments <IMicrosoftGraphCloudPcUserSettingAssignment[]>] [-CreatedDateTime <DateTime>]
 [-DisplayName <String>] [-Id <String>] [-LastModifiedDateTime <DateTime>] [-LocalAdminEnabled]
 [-RestorePointSetting <IMicrosoftGraphCloudPcRestorePointSetting>] [-SelfServiceEnabled] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementVirtualEndpointUserSetting -BodyParameter <IMicrosoftGraphCloudPcUserSetting> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to userSettings for deviceManagement

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
Represents the set of Microsoft 365 groups and security groups in Azure AD that have cloudPCUserSetting assigned.
Returned only on $expand.
For an example, see Get cloudPcUserSettingample.
To construct, please use Get-Help -Online and see NOTES section for ASSIGNMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCloudPcUserSettingAssignment[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
cloudPcUserSetting
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCloudPcUserSetting
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedDateTime
The date and time the setting was created.
The Timestamp type represents the date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 looks like this: '2014-01-01T00:00:00Z'.

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

### -DisplayName
The setting name displayed in the user interface.

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

### -LastModifiedDateTime
The last date and time the setting was modified.
The Timestamp type represents the date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 looks like this: '2014-01-01T00:00:00Z'.

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

### -LocalAdminEnabled
Indicates whether the local admin option is enabled.
Default value is false.
To enable the local admin option, change the setting to true.
If the local admin option is enabled, the end user can be an admin of the Cloud PC device.

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

### -RestorePointSetting
cloudPcRestorePointSetting
To construct, please use Get-Help -Online and see NOTES section for RESTOREPOINTSETTING properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCloudPcRestorePointSetting
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SelfServiceEnabled
Indicates whether the self-service option is enabled.
Default value is false.
To enable the self-service option, change the setting to true. If the self-service option is enabled, the end user is allowed to perform some self-service operations, such as upgrading the Cloud PC through the end user portal.

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCloudPcUserSetting

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCloudPcUserSetting

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ASSIGNMENTS <IMicrosoftGraphCloudPcUserSettingAssignment[]>: Represents the set of Microsoft 365 groups and security groups in Azure AD that have cloudPCUserSetting assigned. Returned only on $expand. For an example, see Get cloudPcUserSettingample.
  - `[Id <String>]`: 
  - `[CreatedDateTime <DateTime?>]`: The date and time this assignment was created. The Timestamp type represents the date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 looks like this: '2014-01-01T00:00:00Z'.
  - `[Target <IMicrosoftGraphCloudPcManagementAssignmentTarget>]`: cloudPcManagementAssignmentTarget
    - `[(Any) <Object>]`: This indicates any property can be added to this object.

BODYPARAMETER <IMicrosoftGraphCloudPcUserSetting>: cloudPcUserSetting
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[Assignments <IMicrosoftGraphCloudPcUserSettingAssignment[]>]`: Represents the set of Microsoft 365 groups and security groups in Azure AD that have cloudPCUserSetting assigned. Returned only on $expand. For an example, see Get cloudPcUserSettingample.
    - `[Id <String>]`: 
    - `[CreatedDateTime <DateTime?>]`: The date and time this assignment was created. The Timestamp type represents the date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 looks like this: '2014-01-01T00:00:00Z'.
    - `[Target <IMicrosoftGraphCloudPcManagementAssignmentTarget>]`: cloudPcManagementAssignmentTarget
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CreatedDateTime <DateTime?>]`: The date and time the setting was created. The Timestamp type represents the date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 looks like this: '2014-01-01T00:00:00Z'.
  - `[DisplayName <String>]`: The setting name displayed in the user interface.
  - `[LastModifiedDateTime <DateTime?>]`: The last date and time the setting was modified. The Timestamp type represents the date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 looks like this: '2014-01-01T00:00:00Z'.
  - `[LocalAdminEnabled <Boolean?>]`: Indicates whether the local admin option is enabled. Default value is false. To enable the local admin option, change the setting to true. If the local admin option is enabled, the end user can be an admin of the Cloud PC device.
  - `[RestorePointSetting <IMicrosoftGraphCloudPcRestorePointSetting>]`: cloudPcRestorePointSetting
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[FrequencyInHours <Int32?>]`: The time interval in hours to take snapshots (restore points) of a Cloud PC automatically. Possible values are 4, 6, 12, 16, and 24. The default frequency is 12 hours.
    - `[UserRestoreEnabled <Boolean?>]`: If true, the user has the ability to use snapshots to restore Cloud PCs. If false, non-admin users cannot use snapshots to restore the Cloud PC.
  - `[SelfServiceEnabled <Boolean?>]`: Indicates whether the self-service option is enabled. Default value is false. To enable the self-service option, change the setting to true. If the self-service option is enabled, the end user is allowed to perform some self-service operations, such as upgrading the Cloud PC through the end user portal.

RESTOREPOINTSETTING <IMicrosoftGraphCloudPcRestorePointSetting>: cloudPcRestorePointSetting
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[FrequencyInHours <Int32?>]`: The time interval in hours to take snapshots (restore points) of a Cloud PC automatically. Possible values are 4, 6, 12, 16, and 24. The default frequency is 12 hours.
  - `[UserRestoreEnabled <Boolean?>]`: If true, the user has the ability to use snapshots to restore Cloud PCs. If false, non-admin users cannot use snapshots to restore the Cloud PC.

## RELATED LINKS

