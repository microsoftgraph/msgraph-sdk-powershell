---
external help file: Microsoft.Graph.DeviceManagement.Enrolment-help.xml
Module Name: Microsoft.Graph.DeviceManagement.Enrolment
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.enrolment/update-mgrolemanagementcloudpcresourcenamespaceresourceaction
schema: 2.0.0
---

# Update-MgRoleManagementCloudPcResourceNamespaceResourceAction

## SYNOPSIS
Update the navigation property resourceActions in roleManagement

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgRoleManagementCloudPcResourceNamespaceResourceAction -UnifiedRbacResourceActionId <String>
 -UnifiedRbacResourceNamespaceId <String> [-ActionVerb <String>] [-AdditionalProperties <Hashtable>]
 [-Description <String>] [-Id <String>] [-Name <String>]
 [-ResourceScope <IMicrosoftGraphUnifiedRbacResourceScope>] [-ResourceScopeId <String>] [-PassThru] [-WhatIf]
 [-Confirm] [<CommonParameters>]
```

### Update
```
Update-MgRoleManagementCloudPcResourceNamespaceResourceAction -UnifiedRbacResourceActionId <String>
 -UnifiedRbacResourceNamespaceId <String> -BodyParameter <IMicrosoftGraphUnifiedRbacResourceAction> [-PassThru]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgRoleManagementCloudPcResourceNamespaceResourceAction -InputObject <IDeviceManagementEnrolmentIdentity>
 [-ActionVerb <String>] [-AdditionalProperties <Hashtable>] [-Description <String>] [-Id <String>]
 [-Name <String>] [-ResourceScope <IMicrosoftGraphUnifiedRbacResourceScope>] [-ResourceScopeId <String>]
 [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgRoleManagementCloudPcResourceNamespaceResourceAction -InputObject <IDeviceManagementEnrolmentIdentity>
 -BodyParameter <IMicrosoftGraphUnifiedRbacResourceAction> [-PassThru] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property resourceActions in roleManagement

## EXAMPLES

## PARAMETERS

### -ActionVerb
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
unifiedRbacResourceAction
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphUnifiedRbacResourceAction
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Description
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: IDeviceManagementEnrolmentIdentity
Parameter Sets: UpdateViaIdentityExpanded, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Name
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceScope
unifiedRbacResourceScope
To construct, see NOTES section for RESOURCESCOPE properties and create a hash table.

```yaml
Type: IMicrosoftGraphUnifiedRbacResourceScope
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceScopeId
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UnifiedRbacResourceActionId
key: id of unifiedRbacResourceAction

```yaml
Type: String
Parameter Sets: UpdateExpanded, Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UnifiedRbacResourceNamespaceId
key: id of unifiedRbacResourceNamespace

```yaml
Type: String
Parameter Sets: UpdateExpanded, Update
Aliases:

Required: True
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

### Microsoft.Graph.PowerShell.Models.IDeviceManagementEnrolmentIdentity
### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUnifiedRbacResourceAction
## OUTPUTS

### System.Boolean
## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphUnifiedRbacResourceAction>: unifiedRbacResourceAction
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[ActionVerb <String>]`: 
  - `[Description <String>]`: 
  - `[Name <String>]`: 
  - `[ResourceScope <IMicrosoftGraphUnifiedRbacResourceScope>]`: unifiedRbacResourceScope
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[DisplayName <String>]`: 
    - `[Scope <String>]`: 
    - `[Type <String>]`: 
  - `[ResourceScopeId <String>]`: 

INPUTOBJECT <IDeviceManagementEnrolmentIdentity>: Identity Parameter
  - `[AndroidDeviceOwnerEnrollmentProfileId <String>]`: key: id of androidDeviceOwnerEnrollmentProfile
  - `[AndroidForWorkEnrollmentProfileId <String>]`: key: id of androidForWorkEnrollmentProfile
  - `[AppScopeId <String>]`: key: id of appScope
  - `[AppScopeId1 <String>]`: Usage: appScopeId={appScopeId}
  - `[AppleEnrollmentProfileAssignmentId <String>]`: key: id of appleEnrollmentProfileAssignment
  - `[AppleUserInitiatedEnrollmentProfileId <String>]`: key: id of appleUserInitiatedEnrollmentProfile
  - `[ApprovalId <String>]`: key: id of approval
  - `[ApprovalStepId <String>]`: key: id of approvalStep
  - `[DepOnboardingSettingId <String>]`: key: id of depOnboardingSetting
  - `[DeviceEnrollmentConfigurationId <String>]`: key: id of deviceEnrollmentConfiguration
  - `[DeviceManagementAutopilotEventId <String>]`: key: id of deviceManagementAutopilotEvent
  - `[DeviceManagementAutopilotPolicyStatusDetailId <String>]`: key: id of deviceManagementAutopilotPolicyStatusDetail
  - `[DirectoryScopeId <String>]`: Usage: directoryScopeId={directoryScopeId}
  - `[EnrollmentConfigurationAssignmentId <String>]`: key: id of enrollmentConfigurationAssignment
  - `[EnrollmentProfileId <String>]`: key: id of enrollmentProfile
  - `[ImportedAppleDeviceIdentityId <String>]`: key: id of importedAppleDeviceIdentity
  - `[ImportedDeviceIdentityId <String>]`: key: id of importedDeviceIdentity
  - `[ImportedWindowsAutopilotDeviceIdentityId <String>]`: key: id of importedWindowsAutopilotDeviceIdentity
  - `[On <String>]`: Usage: on={on}
  - `[PrincipalId <String>]`: Usage: principalId={principalId}
  - `[RoleDefinitionId <String>]`: Usage: roleDefinitionId={roleDefinitionId}
  - `[UnifiedRbacResourceActionId <String>]`: key: id of unifiedRbacResourceAction
  - `[UnifiedRbacResourceNamespaceId <String>]`: key: id of unifiedRbacResourceNamespace
  - `[UnifiedRoleAssignmentId <String>]`: key: id of unifiedRoleAssignment
  - `[UnifiedRoleAssignmentMultipleId <String>]`: key: id of unifiedRoleAssignmentMultiple
  - `[UnifiedRoleAssignmentScheduleId <String>]`: key: id of unifiedRoleAssignmentSchedule
  - `[UnifiedRoleAssignmentScheduleInstanceId <String>]`: key: id of unifiedRoleAssignmentScheduleInstance
  - `[UnifiedRoleAssignmentScheduleRequestId <String>]`: key: id of unifiedRoleAssignmentScheduleRequest
  - `[UnifiedRoleDefinitionId <String>]`: key: id of unifiedRoleDefinition
  - `[UnifiedRoleDefinitionId1 <String>]`: key: id of unifiedRoleDefinition
  - `[UnifiedRoleEligibilityScheduleId <String>]`: key: id of unifiedRoleEligibilitySchedule
  - `[UnifiedRoleEligibilityScheduleInstanceId <String>]`: key: id of unifiedRoleEligibilityScheduleInstance
  - `[UnifiedRoleEligibilityScheduleRequestId <String>]`: key: id of unifiedRoleEligibilityScheduleRequest
  - `[WindowsAutopilotDeploymentProfileAssignmentId <String>]`: key: id of windowsAutopilotDeploymentProfileAssignment
  - `[WindowsAutopilotDeploymentProfileId <String>]`: key: id of windowsAutopilotDeploymentProfile
  - `[WindowsAutopilotDeviceIdentityId <String>]`: key: id of windowsAutopilotDeviceIdentity
  - `[WindowsFeatureUpdateProfileAssignmentId <String>]`: key: id of windowsFeatureUpdateProfileAssignment
  - `[WindowsFeatureUpdateProfileId <String>]`: key: id of windowsFeatureUpdateProfile
  - `[WindowsUpdateStateId <String>]`: key: id of windowsUpdateState

RESOURCESCOPE <IMicrosoftGraphUnifiedRbacResourceScope>: unifiedRbacResourceScope
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[DisplayName <String>]`: 
  - `[Scope <String>]`: 
  - `[Type <String>]`: 

## RELATED LINKS
