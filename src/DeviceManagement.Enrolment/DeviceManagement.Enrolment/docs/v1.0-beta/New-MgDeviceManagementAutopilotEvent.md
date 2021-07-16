---
external help file: Microsoft.Graph.DeviceManagement.Enrolment-help.xml
Module Name: Microsoft.Graph.DeviceManagement.Enrolment
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.enrolment/new-mgdevicemanagementautopilotevent
schema: 2.0.0
---

# New-MgDeviceManagementAutopilotEvent

## SYNOPSIS
The list of autopilot events for the tenant.

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementAutopilotEvent [-AccountSetupDuration <TimeSpan>] [-AccountSetupStatus <String>]
 [-AdditionalProperties <Hashtable>] [-DeploymentDuration <TimeSpan>] [-DeploymentEndDateTime <DateTime>]
 [-DeploymentStartDateTime <DateTime>] [-DeploymentState <String>] [-DeploymentTotalDuration <TimeSpan>]
 [-DeviceId <String>] [-DevicePreparationDuration <TimeSpan>] [-DeviceRegisteredDateTime <DateTime>]
 [-DeviceSerialNumber <String>] [-DeviceSetupDuration <TimeSpan>] [-DeviceSetupStatus <String>]
 [-EnrollmentFailureDetails <String>] [-EnrollmentStartDateTime <DateTime>] [-EnrollmentState <String>]
 [-EnrollmentType <String>] [-EventDateTime <DateTime>] [-Id <String>] [-ManagedDeviceName <String>]
 [-OSVersion <String>] [-PolicyStatusDetails <IMicrosoftGraphDeviceManagementAutopilotPolicyStatusDetail[]>]
 [-TargetedAppCount <Int32>] [-TargetedPolicyCount <Int32>] [-UserPrincipalName <String>]
 [-Windows10EnrollmentCompletionPageConfigurationDisplayName <String>]
 [-Windows10EnrollmentCompletionPageConfigurationId <String>]
 [-WindowsAutopilotDeploymentProfileDisplayName <String>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementAutopilotEvent -BodyParameter <IMicrosoftGraphDeviceManagementAutopilotEvent> [-WhatIf]
 [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
The list of autopilot events for the tenant.

## EXAMPLES

## PARAMETERS

### -AccountSetupDuration
Time spent in user ESP.

```yaml
Type: TimeSpan
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AccountSetupStatus
windowsAutopilotDeploymentState

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

### -BodyParameter
Represents an Autopilot flow event.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphDeviceManagementAutopilotEvent
Parameter Sets: Create
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
Type: TimeSpan
Parameter Sets: CreateExpanded
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
Type: DateTime
Parameter Sets: CreateExpanded
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
Type: DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeploymentState
windowsAutopilotDeploymentState

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

### -DeploymentTotalDuration
Total deployment duration from enrollment to Desktop screen.

```yaml
Type: TimeSpan
Parameter Sets: CreateExpanded
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
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DevicePreparationDuration
Time spent in device enrollment.

```yaml
Type: TimeSpan
Parameter Sets: CreateExpanded
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
Type: DateTime
Parameter Sets: CreateExpanded
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
Type: String
Parameter Sets: CreateExpanded
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
Type: TimeSpan
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceSetupStatus
windowsAutopilotDeploymentState

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

### -EnrollmentFailureDetails
Enrollment failure details.

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

### -EnrollmentStartDateTime
Device enrollment start date.

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

### -EnrollmentState
.

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

### -EnrollmentType
windowsAutopilotEnrollmentType

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

### -EventDateTime
Time when the event occurred .

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

### -ManagedDeviceName
Managed device name.

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

### -OSVersion
Device operating system version.

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

### -PolicyStatusDetails
Policy and application status details for this device.
To construct, see NOTES section for POLICYSTATUSDETAILS properties and create a hash table.

```yaml
Type: IMicrosoftGraphDeviceManagementAutopilotPolicyStatusDetail[]
Parameter Sets: CreateExpanded
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
Type: Int32
Parameter Sets: CreateExpanded
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
Type: Int32
Parameter Sets: CreateExpanded
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
Type: String
Parameter Sets: CreateExpanded
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
Type: String
Parameter Sets: CreateExpanded
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
Type: String
Parameter Sets: CreateExpanded
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
Type: String
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementAutopilotEvent
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementAutopilotEvent
## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphDeviceManagementAutopilotEvent>: Represents an Autopilot flow event.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[AccountSetupDuration <TimeSpan?>]`: Time spent in user ESP.
  - `[AccountSetupStatus <String>]`: windowsAutopilotDeploymentState
  - `[DeploymentDuration <TimeSpan?>]`: Autopilot deployment duration including enrollment.
  - `[DeploymentEndDateTime <DateTime?>]`: Deployment end time.
  - `[DeploymentStartDateTime <DateTime?>]`: Deployment start time.
  - `[DeploymentState <String>]`: windowsAutopilotDeploymentState
  - `[DeploymentTotalDuration <TimeSpan?>]`: Total deployment duration from enrollment to Desktop screen.
  - `[DeviceId <String>]`: Device id associated with the object
  - `[DevicePreparationDuration <TimeSpan?>]`: Time spent in device enrollment.
  - `[DeviceRegisteredDateTime <DateTime?>]`: Device registration date.
  - `[DeviceSerialNumber <String>]`: Device serial number.
  - `[DeviceSetupDuration <TimeSpan?>]`: Time spent in device ESP.
  - `[DeviceSetupStatus <String>]`: windowsAutopilotDeploymentState
  - `[EnrollmentFailureDetails <String>]`: Enrollment failure details.
  - `[EnrollmentStartDateTime <DateTime?>]`: Device enrollment start date.
  - `[EnrollmentState <String>]`: 
  - `[EnrollmentType <String>]`: windowsAutopilotEnrollmentType
  - `[EventDateTime <DateTime?>]`: Time when the event occurred .
  - `[ManagedDeviceName <String>]`: Managed device name.
  - `[OSVersion <String>]`: Device operating system version.
  - `[PolicyStatusDetails <IMicrosoftGraphDeviceManagementAutopilotPolicyStatusDetail[]>]`: Policy and application status details for this device.
    - `[Id <String>]`: Read-only.
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

POLICYSTATUSDETAILS <IMicrosoftGraphDeviceManagementAutopilotPolicyStatusDetail[]>: Policy and application status details for this device.
  - `[Id <String>]`: Read-only.
  - `[ComplianceStatus <String>]`: deviceManagementAutopilotPolicyComplianceStatus
  - `[DisplayName <String>]`: The friendly name of the policy.
  - `[ErrorCode <Int32?>]`: The errorode associated with the compliance or enforcement status of the policy. Error code for enforcement status takes precedence if it exists.
  - `[LastReportedDateTime <DateTime?>]`: Timestamp of the reported policy status
  - `[PolicyType <String>]`: deviceManagementAutopilotPolicyType
  - `[TrackedOnEnrollmentStatus <Boolean?>]`: Indicates if this prolicy was tracked as part of the autopilot bootstrap enrollment sync session

## RELATED LINKS
