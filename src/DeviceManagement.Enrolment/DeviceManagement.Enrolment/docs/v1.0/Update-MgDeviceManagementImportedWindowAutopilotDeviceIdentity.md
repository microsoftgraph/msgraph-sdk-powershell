---
external help file:
Module Name: Microsoft.Graph.DeviceManagement.Enrolment
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.enrolment/update-mgdevicemanagementimportedwindowautopilotdeviceidentity
schema: 2.0.0
---

# Update-MgDeviceManagementImportedWindowAutopilotDeviceIdentity

## SYNOPSIS
Update the navigation property importedWindowsAutopilotDeviceIdentities in deviceManagement

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgDeviceManagementImportedWindowAutopilotDeviceIdentity
 -ImportedWindowsAutopilotDeviceIdentityId <String> [-AdditionalProperties <Hashtable>]
 [-AssignedUserPrincipalName <String>] [-GroupTag <String>] [-HardwareIdentifierInputFile <String>]
 [-Id <String>] [-ImportId <String>] [-ProductKey <String>] [-SerialNumber <String>]
 [-State <IMicrosoftGraphImportedWindowsAutopilotDeviceIdentityState>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgDeviceManagementImportedWindowAutopilotDeviceIdentity
 -ImportedWindowsAutopilotDeviceIdentityId <String>
 -BodyParameter <IMicrosoftGraphImportedWindowsAutopilotDeviceIdentity> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgDeviceManagementImportedWindowAutopilotDeviceIdentity
 -InputObject <IDeviceManagementEnrolmentIdentity>
 -BodyParameter <IMicrosoftGraphImportedWindowsAutopilotDeviceIdentity> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgDeviceManagementImportedWindowAutopilotDeviceIdentity
 -InputObject <IDeviceManagementEnrolmentIdentity> [-AdditionalProperties <Hashtable>]
 [-AssignedUserPrincipalName <String>] [-GroupTag <String>] [-HardwareIdentifierInputFile <String>]
 [-Id <String>] [-ImportId <String>] [-ProductKey <String>] [-SerialNumber <String>]
 [-State <IMicrosoftGraphImportedWindowsAutopilotDeviceIdentityState>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property importedWindowsAutopilotDeviceIdentities in deviceManagement

## EXAMPLES

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

### -AssignedUserPrincipalName
UPN of the user the device will be assigned

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

### -BodyParameter
Imported windows autopilot devices.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphImportedWindowsAutopilotDeviceIdentity
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -GroupTag
Group Tag of the Windows autopilot device.

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

### -HardwareIdentifierInputFile
Input File for HardwareIdentifier (Hardware Blob of the Windows autopilot device.)

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

### -Id
The unique idenfier for an entity.
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

### -ImportedWindowsAutopilotDeviceIdentityId
The unique identifier of importedWindowsAutopilotDeviceIdentity

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

### -ImportId
The Import Id of the Windows autopilot device.

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
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IDeviceManagementEnrolmentIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### -ProductKey
Product Key of the Windows autopilot device.

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

### -SerialNumber
Serial number of the Windows autopilot device.

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

### -State
importedWindowsAutopilotDeviceIdentityState
To construct, please use Get-Help -Online and see NOTES section for STATE properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphImportedWindowsAutopilotDeviceIdentityState
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

### Microsoft.Graph.PowerShell.Models.IDeviceManagementEnrolmentIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphImportedWindowsAutopilotDeviceIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphImportedWindowsAutopilotDeviceIdentity>: Imported windows autopilot devices.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[AssignedUserPrincipalName <String>]`: UPN of the user the device will be assigned
  - `[GroupTag <String>]`: Group Tag of the Windows autopilot device.
  - `[HardwareIdentifier <Byte[]>]`: Hardware Blob of the Windows autopilot device.
  - `[ImportId <String>]`: The Import Id of the Windows autopilot device.
  - `[ProductKey <String>]`: Product Key of the Windows autopilot device.
  - `[SerialNumber <String>]`: Serial number of the Windows autopilot device.
  - `[State <IMicrosoftGraphImportedWindowsAutopilotDeviceIdentityState>]`: importedWindowsAutopilotDeviceIdentityState
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DeviceErrorCode <Int32?>]`: Device error code reported by Device Directory Service(DDS).
    - `[DeviceErrorName <String>]`: Device error name reported by Device Directory Service(DDS).
    - `[DeviceImportStatus <ImportedWindowsAutopilotDeviceIdentityImportStatus?>]`: importedWindowsAutopilotDeviceIdentityImportStatus
    - `[DeviceRegistrationId <String>]`: Device Registration ID for successfully added device reported by Device Directory Service(DDS).

INPUTOBJECT <IDeviceManagementEnrolmentIdentity>: Identity Parameter
  - `[AndroidDeviceOwnerEnrollmentProfileId <String>]`: The unique identifier of androidDeviceOwnerEnrollmentProfile
  - `[AndroidForWorkEnrollmentProfileId <String>]`: The unique identifier of androidForWorkEnrollmentProfile
  - `[AppScopeId <String>]`: The unique identifier of appScope
  - `[AppleEnrollmentProfileAssignmentId <String>]`: The unique identifier of appleEnrollmentProfileAssignment
  - `[AppleUserInitiatedEnrollmentProfileId <String>]`: The unique identifier of appleUserInitiatedEnrollmentProfile
  - `[ApprovalId <String>]`: The unique identifier of approval
  - `[ApprovalStepId <String>]`: The unique identifier of approvalStep
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
  - `[On <String>]`: Usage: on='{on}'
  - `[UnifiedRbacResourceActionId <String>]`: The unique identifier of unifiedRbacResourceAction
  - `[UnifiedRbacResourceNamespaceId <String>]`: The unique identifier of unifiedRbacResourceNamespace
  - `[UnifiedRoleAssignmentId <String>]`: The unique identifier of unifiedRoleAssignment
  - `[UnifiedRoleAssignmentMultipleId <String>]`: The unique identifier of unifiedRoleAssignmentMultiple
  - `[UnifiedRoleAssignmentScheduleId <String>]`: The unique identifier of unifiedRoleAssignmentSchedule
  - `[UnifiedRoleAssignmentScheduleInstanceId <String>]`: The unique identifier of unifiedRoleAssignmentScheduleInstance
  - `[UnifiedRoleAssignmentScheduleRequestId <String>]`: The unique identifier of unifiedRoleAssignmentScheduleRequest
  - `[UnifiedRoleDefinitionId <String>]`: The unique identifier of unifiedRoleDefinition
  - `[UnifiedRoleDefinitionId1 <String>]`: The unique identifier of unifiedRoleDefinition
  - `[UnifiedRoleEligibilityScheduleId <String>]`: The unique identifier of unifiedRoleEligibilitySchedule
  - `[UnifiedRoleEligibilityScheduleInstanceId <String>]`: The unique identifier of unifiedRoleEligibilityScheduleInstance
  - `[UnifiedRoleEligibilityScheduleRequestId <String>]`: The unique identifier of unifiedRoleEligibilityScheduleRequest
  - `[WindowsAutopilotDeploymentProfileAssignmentId <String>]`: The unique identifier of windowsAutopilotDeploymentProfileAssignment
  - `[WindowsAutopilotDeploymentProfileId <String>]`: The unique identifier of windowsAutopilotDeploymentProfile
  - `[WindowsAutopilotDeviceIdentityId <String>]`: The unique identifier of windowsAutopilotDeviceIdentity
  - `[WindowsFeatureUpdateProfileAssignmentId <String>]`: The unique identifier of windowsFeatureUpdateProfileAssignment
  - `[WindowsFeatureUpdateProfileId <String>]`: The unique identifier of windowsFeatureUpdateProfile

STATE <IMicrosoftGraphImportedWindowsAutopilotDeviceIdentityState>: importedWindowsAutopilotDeviceIdentityState
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DeviceErrorCode <Int32?>]`: Device error code reported by Device Directory Service(DDS).
  - `[DeviceErrorName <String>]`: Device error name reported by Device Directory Service(DDS).
  - `[DeviceImportStatus <ImportedWindowsAutopilotDeviceIdentityImportStatus?>]`: importedWindowsAutopilotDeviceIdentityImportStatus
  - `[DeviceRegistrationId <String>]`: Device Registration ID for successfully added device reported by Device Directory Service(DDS).

## RELATED LINKS

