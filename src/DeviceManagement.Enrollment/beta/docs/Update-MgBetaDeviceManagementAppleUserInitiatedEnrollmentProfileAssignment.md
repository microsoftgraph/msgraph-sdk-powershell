---
external help file:
Module Name: Microsoft.Graph.Beta.DeviceManagement.Enrollment
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.devicemanagement.enrollment/update-mgbetadevicemanagementappleuserinitiatedenrollmentprofileassignment
schema: 2.0.0
---

# Update-MgBetaDeviceManagementAppleUserInitiatedEnrollmentProfileAssignment

## SYNOPSIS
Update the navigation property assignments in deviceManagement

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaDeviceManagementAppleUserInitiatedEnrollmentProfileAssignment
 -AppleEnrollmentProfileAssignmentId <String> -AppleUserInitiatedEnrollmentProfileId <String>
 [-AdditionalProperties <Hashtable>] [-Id <String>]
 [-Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaDeviceManagementAppleUserInitiatedEnrollmentProfileAssignment
 -AppleEnrollmentProfileAssignmentId <String> -AppleUserInitiatedEnrollmentProfileId <String>
 -BodyParameter <IMicrosoftGraphAppleEnrollmentProfileAssignment> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBetaDeviceManagementAppleUserInitiatedEnrollmentProfileAssignment
 -InputObject <IDeviceManagementEnrollmentIdentity>
 -BodyParameter <IMicrosoftGraphAppleEnrollmentProfileAssignment> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBetaDeviceManagementAppleUserInitiatedEnrollmentProfileAssignment
 -InputObject <IDeviceManagementEnrollmentIdentity> [-AdditionalProperties <Hashtable>] [-Id <String>]
 [-Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property assignments in deviceManagement

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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AppleEnrollmentProfileAssignmentId
The unique identifier of appleEnrollmentProfileAssignment

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AppleUserInitiatedEnrollmentProfileId
The unique identifier of appleUserInitiatedEnrollmentProfile

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
An assignment of an Apple profile.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAppleEnrollmentProfileAssignment
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Id
The unique identifier for an entity.
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IDeviceManagementEnrollmentIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Target
Base type for assignment targets.
To construct, see NOTES section for TARGET properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDeviceAndAppManagementAssignmentTarget
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IDeviceManagementEnrollmentIdentity

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAppleEnrollmentProfileAssignment

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAppleEnrollmentProfileAssignment

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphAppleEnrollmentProfileAssignment>`: An assignment of an Apple profile.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: Base type for assignment targets.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
    - `[DeviceAndAppManagementAssignmentFilterType <DeviceAndAppManagementAssignmentFilterType?>]`: Represents type of the assignment filter.

`INPUTOBJECT <IDeviceManagementEnrollmentIdentity>`: Identity Parameter
  - `[AndroidDeviceOwnerEnrollmentProfileId <String>]`: The unique identifier of androidDeviceOwnerEnrollmentProfile
  - `[AndroidForWorkEnrollmentProfileId <String>]`: The unique identifier of androidForWorkEnrollmentProfile
  - `[AppScopeId <String>]`: The unique identifier of appScope
  - `[AppleEnrollmentProfileAssignmentId <String>]`: The unique identifier of appleEnrollmentProfileAssignment
  - `[AppleUserInitiatedEnrollmentProfileId <String>]`: The unique identifier of appleUserInitiatedEnrollmentProfile
  - `[DepOnboardingSettingId <String>]`: The unique identifier of depOnboardingSetting
  - `[DeviceEnrollmentConfigurationId <String>]`: The unique identifier of deviceEnrollmentConfiguration
  - `[DeviceManagementAutopilotEventId <String>]`: The unique identifier of deviceManagementAutopilotEvent
  - `[DeviceManagementAutopilotPolicyStatusDetailId <String>]`: The unique identifier of deviceManagementAutopilotPolicyStatusDetail
  - `[DirectoryObjectId <String>]`: The unique identifier of directoryObject
  - `[EnrollmentConfigurationAssignmentId <String>]`: The unique identifier of enrollmentConfigurationAssignment
  - `[EnrollmentProfileId <String>]`: The unique identifier of enrollmentProfile
  - `[ImportedAppleDeviceIdentityId <String>]`: The unique identifier of importedAppleDeviceIdentity
  - `[ImportedDeviceIdentityId <String>]`: The unique identifier of importedDeviceIdentity
  - `[ImportedWindowsAutopilotDeviceIdentityId <String>]`: The unique identifier of importedWindowsAutopilotDeviceIdentity
  - `[UnifiedRbacResourceActionId <String>]`: The unique identifier of unifiedRbacResourceAction
  - `[UnifiedRbacResourceNamespaceId <String>]`: The unique identifier of unifiedRbacResourceNamespace
  - `[UnifiedRoleAssignmentMultipleId <String>]`: The unique identifier of unifiedRoleAssignmentMultiple
  - `[UnifiedRoleDefinitionId <String>]`: The unique identifier of unifiedRoleDefinition
  - `[UnifiedRoleDefinitionId1 <String>]`: The unique identifier of unifiedRoleDefinition
  - `[WindowsAutopilotDeploymentProfileAssignmentId <String>]`: The unique identifier of windowsAutopilotDeploymentProfileAssignment
  - `[WindowsAutopilotDeploymentProfileId <String>]`: The unique identifier of windowsAutopilotDeploymentProfile
  - `[WindowsAutopilotDeviceIdentityId <String>]`: The unique identifier of windowsAutopilotDeviceIdentity
  - `[WindowsFeatureUpdateProfileAssignmentId <String>]`: The unique identifier of windowsFeatureUpdateProfileAssignment
  - `[WindowsFeatureUpdateProfileId <String>]`: The unique identifier of windowsFeatureUpdateProfile

`TARGET <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>`: Base type for assignment targets.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
  - `[DeviceAndAppManagementAssignmentFilterType <DeviceAndAppManagementAssignmentFilterType?>]`: Represents type of the assignment filter.

## RELATED LINKS

