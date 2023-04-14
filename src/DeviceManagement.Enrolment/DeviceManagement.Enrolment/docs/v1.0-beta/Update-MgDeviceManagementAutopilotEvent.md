---
external help file:
Module Name: Microsoft.Graph.DeviceManagement.Enrolment
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.enrolment/update-mgdevicemanagementautopilotevent
schema: 2.0.0
---

# Update-MgDeviceManagementAutopilotEvent

## SYNOPSIS
Update the navigation property autopilotEvents in deviceManagement

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgDeviceManagementAutopilotEvent -DeviceManagementAutopilotEventId <String>
 [-AccountSetupDuration <TimeSpan>] [-AccountSetupStatus <WindowsAutopilotDeploymentState>]
 [-AdditionalProperties <Hashtable>] [-DeploymentDuration <TimeSpan>] [-DeploymentEndDateTime <DateTime>]
 [-DeploymentStartDateTime <DateTime>] [-DeploymentState <WindowsAutopilotDeploymentState>]
 [-DeploymentTotalDuration <TimeSpan>] [-DeviceId <String>] [-DevicePreparationDuration <TimeSpan>]
 [-DeviceRegisteredDateTime <DateTime>] [-DeviceSerialNumber <String>] [-DeviceSetupDuration <TimeSpan>]
 [-DeviceSetupStatus <WindowsAutopilotDeploymentState>] [-EnrollmentFailureDetails <String>]
 [-EnrollmentStartDateTime <DateTime>] [-EnrollmentState <EnrollmentState>] [-EnrollmentType <String>]
 [-EventDateTime <DateTime>] [-Id <String>] [-ManagedDeviceName <String>] [-OSVersion <String>]
 [-PolicyStatusDetails <IMicrosoftGraphDeviceManagementAutopilotPolicyStatusDetail[]>]
 [-TargetedAppCount <Int32>] [-TargetedPolicyCount <Int32>] [-UserPrincipalName <String>]
 [-Windows10EnrollmentCompletionPageConfigurationDisplayName <String>]
 [-Windows10EnrollmentCompletionPageConfigurationId <String>]
 [-WindowsAutopilotDeploymentProfileDisplayName <String>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgDeviceManagementAutopilotEvent -DeviceManagementAutopilotEventId <String>
 -BodyParameter <IMicrosoftGraphDeviceManagementAutopilotEvent> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgDeviceManagementAutopilotEvent -InputObject <IDeviceManagementEnrolmentIdentity>
 -BodyParameter <IMicrosoftGraphDeviceManagementAutopilotEvent> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgDeviceManagementAutopilotEvent -InputObject <IDeviceManagementEnrolmentIdentity>
 [-AccountSetupDuration <TimeSpan>] [-AccountSetupStatus <WindowsAutopilotDeploymentState>]
 [-AdditionalProperties <Hashtable>] [-DeploymentDuration <TimeSpan>] [-DeploymentEndDateTime <DateTime>]
 [-DeploymentStartDateTime <DateTime>] [-DeploymentState <WindowsAutopilotDeploymentState>]
 [-DeploymentTotalDuration <TimeSpan>] [-DeviceId <String>] [-DevicePreparationDuration <TimeSpan>]
 [-DeviceRegisteredDateTime <DateTime>] [-DeviceSerialNumber <String>] [-DeviceSetupDuration <TimeSpan>]
 [-DeviceSetupStatus <WindowsAutopilotDeploymentState>] [-EnrollmentFailureDetails <String>]
 [-EnrollmentStartDateTime <DateTime>] [-EnrollmentState <EnrollmentState>] [-EnrollmentType <String>]
 [-EventDateTime <DateTime>] [-Id <String>] [-ManagedDeviceName <String>] [-OSVersion <String>]
 [-PolicyStatusDetails <IMicrosoftGraphDeviceManagementAutopilotPolicyStatusDetail[]>]
 [-TargetedAppCount <Int32>] [-TargetedPolicyCount <Int32>] [-UserPrincipalName <String>]
 [-Windows10EnrollmentCompletionPageConfigurationDisplayName <String>]
 [-Windows10EnrollmentCompletionPageConfigurationId <String>]
 [-WindowsAutopilotDeploymentProfileDisplayName <String>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property autopilotEvents in deviceManagement

## EXAMPLES

## PARAMETERS

### -AccountSetupDuration
Time spent in user ESP.

```yaml
Type: System.TimeSpan
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AccountSetupStatus
Deployment states for Autopilot devices

```yaml
Type: Microsoft.Graph.PowerShell.Support.WindowsAutopilotDeploymentState
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
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
Represents an Autopilot flow event.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementAutopilotEvent
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DeploymentDuration
Autopilot deployment duration including enrollment.

```yaml
Type: System.TimeSpan
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeploymentEndDateTime
Deployment end time.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeploymentStartDateTime
Deployment start time.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeploymentState
Deployment states for Autopilot devices

```yaml
Type: Microsoft.Graph.PowerShell.Support.WindowsAutopilotDeploymentState
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeploymentTotalDuration
Total deployment duration from enrollment to Desktop screen.

```yaml
Type: System.TimeSpan
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceId
Device id associated with the object

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

### -DeviceManagementAutopilotEventId
The unique identifier of deviceManagementAutopilotEvent

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

### -DevicePreparationDuration
Time spent in device enrollment.

```yaml
Type: System.TimeSpan
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceRegisteredDateTime
Device registration date.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceSerialNumber
Device serial number.

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

### -DeviceSetupDuration
Time spent in device ESP.

```yaml
Type: System.TimeSpan
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceSetupStatus
Deployment states for Autopilot devices

```yaml
Type: Microsoft.Graph.PowerShell.Support.WindowsAutopilotDeploymentState
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EnrollmentFailureDetails
Enrollment failure details.

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

### -EnrollmentStartDateTime
Device enrollment start date.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EnrollmentState
.

```yaml
Type: Microsoft.Graph.PowerShell.Support.EnrollmentState
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EnrollmentType
windowsAutopilotEnrollmentType

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

### -EventDateTime
Time when the event occurred .

```yaml
Type: System.DateTime
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

### -ManagedDeviceName
Managed device name.

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

### -OSVersion
Device operating system version.

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

### -PolicyStatusDetails
Policy and application status details for this device.
To construct, please use Get-Help -Online and see NOTES section for POLICYSTATUSDETAILS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementAutopilotPolicyStatusDetail[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TargetedAppCount
Count of applications targeted.

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TargetedPolicyCount
Count of policies targeted.

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserPrincipalName
User principal name used to enroll the device.

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

### -Windows10EnrollmentCompletionPageConfigurationDisplayName
Enrollment Status Page profile name

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

### -Windows10EnrollmentCompletionPageConfigurationId
Enrollment Status Page profile ID

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

### -WindowsAutopilotDeploymentProfileDisplayName
Autopilot profile name.

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementAutopilotEvent

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphDeviceManagementAutopilotEvent>: Represents an Autopilot flow event.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[AccountSetupDuration <TimeSpan?>]`: Time spent in user ESP.
  - `[AccountSetupStatus <WindowsAutopilotDeploymentState?>]`: Deployment states for Autopilot devices
  - `[DeploymentDuration <TimeSpan?>]`: Autopilot deployment duration including enrollment.
  - `[DeploymentEndDateTime <DateTime?>]`: Deployment end time.
  - `[DeploymentStartDateTime <DateTime?>]`: Deployment start time.
  - `[DeploymentState <WindowsAutopilotDeploymentState?>]`: Deployment states for Autopilot devices
  - `[DeploymentTotalDuration <TimeSpan?>]`: Total deployment duration from enrollment to Desktop screen.
  - `[DeviceId <String>]`: Device id associated with the object
  - `[DevicePreparationDuration <TimeSpan?>]`: Time spent in device enrollment.
  - `[DeviceRegisteredDateTime <DateTime?>]`: Device registration date.
  - `[DeviceSerialNumber <String>]`: Device serial number.
  - `[DeviceSetupDuration <TimeSpan?>]`: Time spent in device ESP.
  - `[DeviceSetupStatus <WindowsAutopilotDeploymentState?>]`: Deployment states for Autopilot devices
  - `[EnrollmentFailureDetails <String>]`: Enrollment failure details.
  - `[EnrollmentStartDateTime <DateTime?>]`: Device enrollment start date.
  - `[EnrollmentState <EnrollmentState?>]`: 
  - `[EnrollmentType <String>]`: windowsAutopilotEnrollmentType
  - `[EventDateTime <DateTime?>]`: Time when the event occurred .
  - `[ManagedDeviceName <String>]`: Managed device name.
  - `[OSVersion <String>]`: Device operating system version.
  - `[PolicyStatusDetails <IMicrosoftGraphDeviceManagementAutopilotPolicyStatusDetail[]>]`: Policy and application status details for this device.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[ComplianceStatus <String>]`: deviceManagementAutopilotPolicyComplianceStatus
    - `[DisplayName <String>]`: The friendly name of the policy.
    - `[ErrorCode <Int32?>]`: The errorode associated with the compliance or enforcement status of the policy. Error code for enforcement status takes precedence if it exists.
    - `[LastReportedDateTime <DateTime?>]`: Timestamp of the reported policy status
    - `[PolicyType <String>]`: deviceManagementAutopilotPolicyType
    - `[TrackedOnEnrollmentStatus <Boolean?>]`: Indicates if this prolicy was tracked as part of the autopilot bootstrap enrollment sync session
  - `[TargetedAppCount <Int32?>]`: Count of applications targeted.
  - `[TargetedPolicyCount <Int32?>]`: Count of policies targeted.
  - `[UserPrincipalName <String>]`: User principal name used to enroll the device.
  - `[Windows10EnrollmentCompletionPageConfigurationDisplayName <String>]`: Enrollment Status Page profile name
  - `[Windows10EnrollmentCompletionPageConfigurationId <String>]`: Enrollment Status Page profile ID
  - `[WindowsAutopilotDeploymentProfileDisplayName <String>]`: Autopilot profile name.

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

POLICYSTATUSDETAILS <IMicrosoftGraphDeviceManagementAutopilotPolicyStatusDetail[]>: Policy and application status details for this device.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[ComplianceStatus <String>]`: deviceManagementAutopilotPolicyComplianceStatus
  - `[DisplayName <String>]`: The friendly name of the policy.
  - `[ErrorCode <Int32?>]`: The errorode associated with the compliance or enforcement status of the policy. Error code for enforcement status takes precedence if it exists.
  - `[LastReportedDateTime <DateTime?>]`: Timestamp of the reported policy status
  - `[PolicyType <String>]`: deviceManagementAutopilotPolicyType
  - `[TrackedOnEnrollmentStatus <Boolean?>]`: Indicates if this prolicy was tracked as part of the autopilot bootstrap enrollment sync session

## RELATED LINKS

