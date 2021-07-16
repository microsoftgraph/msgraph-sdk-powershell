---
external help file: Microsoft.Graph.DeviceManagement.Enrolment-help.xml
Module Name: Microsoft.Graph.DeviceManagement.Enrolment
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.enrolment/new-mgdevicemanagementappleuserinitiatedenrollmentprofile
schema: 2.0.0
---

# New-MgDeviceManagementAppleUserInitiatedEnrollmentProfile

## SYNOPSIS
Apple user initiated enrollment profiles

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementAppleUserInitiatedEnrollmentProfile [-AdditionalProperties <Hashtable>]
 [-Assignments <IMicrosoftGraphAppleEnrollmentProfileAssignment[]>]
 [-AvailableEnrollmentTypeOptions <IMicrosoftGraphAppleOwnerTypeEnrollmentType[]>]
 [-CreatedDateTime <DateTime>] [-DefaultEnrollmentType <String>] [-Description <String>]
 [-DisplayName <String>] [-Id <String>] [-LastModifiedDateTime <DateTime>] [-Platform <String>]
 [-Priority <Int32>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementAppleUserInitiatedEnrollmentProfile
 -BodyParameter <IMicrosoftGraphAppleUserInitiatedEnrollmentProfile> [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Apple user initiated enrollment profiles

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Assignments
The list of assignments for this profile.
To construct, see NOTES section for ASSIGNMENTS properties and create a hash table.

```yaml
Type: IMicrosoftGraphAppleEnrollmentProfileAssignment[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AvailableEnrollmentTypeOptions
List of available enrollment type options
To construct, see NOTES section for AVAILABLEENROLLMENTTYPEOPTIONS properties and create a hash table.

```yaml
Type: IMicrosoftGraphAppleOwnerTypeEnrollmentType[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
The enrollmentProfile resource represents a collection of configurations which must be provided pre-enrollment to enable enrolling certain devices whose identities have been pre-staged.
Pre-staged device identities are assigned to this type of profile to apply the profile's configurations at enrollment of the corresponding device.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphAppleUserInitiatedEnrollmentProfile
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedDateTime
Profile creation time

```yaml
Type: DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultEnrollmentType
appleUserInitiatedEnrollmentType

```yaml
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
Description of the profile

```yaml
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
Name of the profile

```yaml
Type: String
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
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastModifiedDateTime
Profile last modified time

```yaml
Type: DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Platform
devicePlatformType

```yaml
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Priority
Priority, 0 is highest

```yaml
Type: Int32
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
Type: SwitchParameter
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
Type: SwitchParameter
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAppleUserInitiatedEnrollmentProfile
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAppleUserInitiatedEnrollmentProfile
## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ASSIGNMENTS <IMicrosoftGraphAppleEnrollmentProfileAssignment[]>: The list of assignments for this profile.
  - `[Id <String>]`: Read-only.
  - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget1>]`: Base type for assignment targets.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
    - `[DeviceAndAppManagementAssignmentFilterType <String>]`: deviceAndAppManagementAssignmentFilterType

AVAILABLEENROLLMENTTYPEOPTIONS <IMicrosoftGraphAppleOwnerTypeEnrollmentType[]>: List of available enrollment type options
  - `[EnrollmentType <String>]`: appleUserInitiatedEnrollmentType
  - `[OwnerType <String>]`: managedDeviceOwnerType

BODYPARAMETER <IMicrosoftGraphAppleUserInitiatedEnrollmentProfile>: The enrollmentProfile resource represents a collection of configurations which must be provided pre-enrollment to enable enrolling certain devices whose identities have been pre-staged. Pre-staged device identities are assigned to this type of profile to apply the profile's configurations at enrollment of the corresponding device.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[Assignments <IMicrosoftGraphAppleEnrollmentProfileAssignment[]>]`: The list of assignments for this profile.
    - `[Id <String>]`: Read-only.
    - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget1>]`: Base type for assignment targets.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
      - `[DeviceAndAppManagementAssignmentFilterType <String>]`: deviceAndAppManagementAssignmentFilterType
  - `[AvailableEnrollmentTypeOptions <IMicrosoftGraphAppleOwnerTypeEnrollmentType[]>]`: List of available enrollment type options
    - `[EnrollmentType <String>]`: appleUserInitiatedEnrollmentType
    - `[OwnerType <String>]`: managedDeviceOwnerType
  - `[CreatedDateTime <DateTime?>]`: Profile creation time
  - `[DefaultEnrollmentType <String>]`: appleUserInitiatedEnrollmentType
  - `[Description <String>]`: Description of the profile
  - `[DisplayName <String>]`: Name of the profile
  - `[LastModifiedDateTime <DateTime?>]`: Profile last modified time
  - `[Platform <String>]`: devicePlatformType
  - `[Priority <Int32?>]`: Priority, 0 is highest

## RELATED LINKS
