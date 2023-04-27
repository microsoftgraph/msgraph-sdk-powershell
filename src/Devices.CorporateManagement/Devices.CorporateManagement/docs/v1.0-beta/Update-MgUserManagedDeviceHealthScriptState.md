---
external help file:
Module Name: Microsoft.Graph.Devices.CorporateManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.corporatemanagement/update-mgusermanageddevicehealthscriptstate
schema: 2.0.0
---

# Update-MgUserManagedDeviceHealthScriptState

## SYNOPSIS
Update the navigation property deviceHealthScriptStates in users

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgUserManagedDeviceHealthScriptState -DeviceId <String> -Id <String> -ManagedDeviceId <String>
 -PolicyId <String> -UserId <String> [-AdditionalProperties <Hashtable>] [-AssignmentFilterIds <String[]>]
 [-DetectionState <RunState>] [-DeviceId1 <String>] [-DeviceName <String>]
 [-ExpectedStateUpdateDateTime <DateTime>] [-Id1 <String>] [-LastStateUpdateDateTime <DateTime>]
 [-LastSyncDateTime <DateTime>] [-OSVersion <String>] [-PolicyId1 <String>] [-PolicyName <String>]
 [-PostRemediationDetectionScriptError <String>] [-PostRemediationDetectionScriptOutput <String>]
 [-PreRemediationDetectionScriptError <String>] [-PreRemediationDetectionScriptOutput <String>]
 [-RemediationScriptError <String>] [-RemediationState <RemediationState>] [-UserName <String>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgUserManagedDeviceHealthScriptState -DeviceId <String> -Id <String> -ManagedDeviceId <String>
 -PolicyId <String> -UserId <String> -BodyParameter <IMicrosoftGraphDeviceHealthScriptPolicyState> [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgUserManagedDeviceHealthScriptState -InputObject <IDevicesCorporateManagementIdentity>
 -BodyParameter <IMicrosoftGraphDeviceHealthScriptPolicyState> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgUserManagedDeviceHealthScriptState -InputObject <IDevicesCorporateManagementIdentity>
 [-DeviceId <String>] [-Id <String>] [-PolicyId <String>] [-AdditionalProperties <Hashtable>]
 [-AssignmentFilterIds <String[]>] [-DetectionState <RunState>] [-DeviceName <String>]
 [-ExpectedStateUpdateDateTime <DateTime>] [-LastStateUpdateDateTime <DateTime>]
 [-LastSyncDateTime <DateTime>] [-OSVersion <String>] [-PolicyName <String>]
 [-PostRemediationDetectionScriptError <String>] [-PostRemediationDetectionScriptOutput <String>]
 [-PreRemediationDetectionScriptError <String>] [-PreRemediationDetectionScriptOutput <String>]
 [-RemediationScriptError <String>] [-RemediationState <RemediationState>] [-UserName <String>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property deviceHealthScriptStates in users

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

### -AssignmentFilterIds
A list of the assignment filter ids used for health script applicability evaluation

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
Contains properties for policy run state of the device health script.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceHealthScriptPolicyState
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DetectionState
Indicates the type of execution status of the device management script.

```yaml
Type: Microsoft.Graph.PowerShell.Support.RunState
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceId
Property in multi-part unique identifier of deviceHealthScriptPolicyState

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceId1
The Intune device Id

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceName
Display name of the device

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

### -ExpectedStateUpdateDateTime
The next timestamp of when the device health script is expected to execute

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
Property in multi-part unique identifier of deviceHealthScriptPolicyState

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id1
Key of the device health script policy state is a concatenation of the MT sideCar policy Id and Intune device Id

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IDevicesCorporateManagementIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LastStateUpdateDateTime
The last timestamp of when the device health script executed

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

### -LastSyncDateTime
The last time that Intune Managment Extension synced with Intune

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

### -ManagedDeviceId
The unique identifier of managedDevice

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

### -OSVersion
Value of the OS Version in string

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

### -PolicyId
Property in multi-part unique identifier of deviceHealthScriptPolicyState

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PolicyId1
The MT sideCar policy Id

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PolicyName
Display name of the device health script

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

### -PostRemediationDetectionScriptError
Error from the detection script after remediation

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

### -PostRemediationDetectionScriptOutput
Detection script output after remediation

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

### -PreRemediationDetectionScriptError
Error from the detection script before remediation

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

### -PreRemediationDetectionScriptOutput
Output of the detection script before remediation

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

### -RemediationScriptError
Error output of the remediation script

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

### -RemediationState
Indicates the type of execution status of the device management script.

```yaml
Type: Microsoft.Graph.PowerShell.Support.RemediationState
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserId
The unique identifier of user

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

### -UserName
Name of the user whom ran the device health script

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

### Microsoft.Graph.PowerShell.Models.IDevicesCorporateManagementIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceHealthScriptPolicyState

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphDeviceHealthScriptPolicyState>: Contains properties for policy run state of the device health script.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AssignmentFilterIds <String[]>]`: A list of the assignment filter ids used for health script applicability evaluation
  - `[DetectionState <RunState?>]`: Indicates the type of execution status of the device management script.
  - `[DeviceId <String>]`: The Intune device Id
  - `[DeviceName <String>]`: Display name of the device
  - `[ExpectedStateUpdateDateTime <DateTime?>]`: The next timestamp of when the device health script is expected to execute
  - `[Id <String>]`: Key of the device health script policy state is a concatenation of the MT sideCar policy Id and Intune device Id
  - `[LastStateUpdateDateTime <DateTime?>]`: The last timestamp of when the device health script executed
  - `[LastSyncDateTime <DateTime?>]`: The last time that Intune Managment Extension synced with Intune
  - `[OSVersion <String>]`: Value of the OS Version in string
  - `[PolicyId <String>]`: The MT sideCar policy Id
  - `[PolicyName <String>]`: Display name of the device health script
  - `[PostRemediationDetectionScriptError <String>]`: Error from the detection script after remediation
  - `[PostRemediationDetectionScriptOutput <String>]`: Detection script output after remediation
  - `[PreRemediationDetectionScriptError <String>]`: Error from the detection script before remediation
  - `[PreRemediationDetectionScriptOutput <String>]`: Output of the detection script before remediation
  - `[RemediationScriptError <String>]`: Error output of the remediation script
  - `[RemediationState <RemediationState?>]`: Indicates the type of execution status of the device management script.
  - `[UserName <String>]`: Name of the user whom ran the device health script

INPUTOBJECT <IDevicesCorporateManagementIdentity>: Identity Parameter
  - `[AndroidManagedAppProtectionId <String>]`: The unique identifier of androidManagedAppProtection
  - `[AppLogCollectionRequestId <String>]`: The unique identifier of appLogCollectionRequest
  - `[AssignmentFilterEvaluationStatusDetailsId <String>]`: The unique identifier of assignmentFilterEvaluationStatusDetails
  - `[BundleId <String>]`: Usage: bundleId='{bundleId}'
  - `[Count <Int64?>]`: Usage: count={count}
  - `[DefaultManagedAppProtectionId <String>]`: The unique identifier of defaultManagedAppProtection
  - `[DetectedAppId <String>]`: The unique identifier of detectedApp
  - `[DeviceAppManagementTaskId <String>]`: The unique identifier of deviceAppManagementTask
  - `[DeviceCompliancePolicyStateId <String>]`: The unique identifier of deviceCompliancePolicyState
  - `[DeviceConfigurationStateId <String>]`: The unique identifier of deviceConfigurationState
  - `[DeviceEnrollmentConfigurationId <String>]`: The unique identifier of deviceEnrollmentConfiguration
  - `[DeviceId <String>]`: Usage: deviceId='{deviceId}'
  - `[DeviceInstallStateId <String>]`: The unique identifier of deviceInstallState
  - `[DeviceLogCollectionResponseId <String>]`: The unique identifier of deviceLogCollectionResponse
  - `[DeviceManagementTroubleshootingEventId <String>]`: The unique identifier of deviceManagementTroubleshootingEvent
  - `[EnrollmentConfigurationAssignmentId <String>]`: The unique identifier of enrollmentConfigurationAssignment
  - `[EnterpriseCodeSigningCertificateId <String>]`: The unique identifier of enterpriseCodeSigningCertificate
  - `[Id <String>]`: Property in multi-part unique identifier of deviceHealthScriptPolicyState
  - `[IosLobAppProvisioningConfigurationAssignmentId <String>]`: The unique identifier of iosLobAppProvisioningConfigurationAssignment
  - `[IosLobAppProvisioningConfigurationId <String>]`: The unique identifier of iosLobAppProvisioningConfiguration
  - `[IosManagedAppProtectionId <String>]`: The unique identifier of iosManagedAppProtection
  - `[ManagedAppOperationId <String>]`: The unique identifier of managedAppOperation
  - `[ManagedAppPolicyId <String>]`: The unique identifier of managedAppPolicy
  - `[ManagedAppRegistrationId <String>]`: The unique identifier of managedAppRegistration
  - `[ManagedAppStatusId <String>]`: The unique identifier of managedAppStatus
  - `[ManagedDeviceId <String>]`: The unique identifier of managedDevice
  - `[ManagedDeviceMobileAppConfigurationAssignmentId <String>]`: The unique identifier of managedDeviceMobileAppConfigurationAssignment
  - `[ManagedDeviceMobileAppConfigurationDeviceStatusId <String>]`: The unique identifier of managedDeviceMobileAppConfigurationDeviceStatus
  - `[ManagedDeviceMobileAppConfigurationId <String>]`: The unique identifier of managedDeviceMobileAppConfiguration
  - `[ManagedDeviceMobileAppConfigurationStateId <String>]`: The unique identifier of managedDeviceMobileAppConfigurationState
  - `[ManagedDeviceMobileAppConfigurationUserStatusId <String>]`: The unique identifier of managedDeviceMobileAppConfigurationUserStatus
  - `[ManagedEBookAssignmentId <String>]`: The unique identifier of managedEBookAssignment
  - `[ManagedEBookCategoryId <String>]`: The unique identifier of managedEBookCategory
  - `[ManagedEBookId <String>]`: The unique identifier of managedEBook
  - `[ManagedMobileAppId <String>]`: The unique identifier of managedMobileApp
  - `[MdmWindowsInformationProtectionPolicyId <String>]`: The unique identifier of mdmWindowsInformationProtectionPolicy
  - `[MobileAppAssignmentId <String>]`: The unique identifier of mobileAppAssignment
  - `[MobileAppCategoryId <String>]`: The unique identifier of mobileAppCategory
  - `[MobileAppId <String>]`: The unique identifier of mobileApp
  - `[MobileAppInstallStatusId <String>]`: The unique identifier of mobileAppInstallStatus
  - `[MobileAppIntentAndStateId <String>]`: The unique identifier of mobileAppIntentAndState
  - `[MobileAppProvisioningConfigGroupAssignmentId <String>]`: The unique identifier of mobileAppProvisioningConfigGroupAssignment
  - `[MobileAppRelationshipId <String>]`: The unique identifier of mobileAppRelationship
  - `[MobileAppTroubleshootingEventId <String>]`: The unique identifier of mobileAppTroubleshootingEvent
  - `[PolicyId <String>]`: Property in multi-part unique identifier of deviceHealthScriptPolicyState
  - `[PolicySetAssignmentId <String>]`: The unique identifier of policySetAssignment
  - `[PolicySetId <String>]`: The unique identifier of policySet
  - `[PolicySetItemId <String>]`: The unique identifier of policySetItem
  - `[SecurityBaselineSettingStateId <String>]`: The unique identifier of securityBaselineSettingState
  - `[SecurityBaselineStateId <String>]`: The unique identifier of securityBaselineState
  - `[Status <String>]`: Usage: status='{status}'
  - `[TargetedManagedAppConfigurationId <String>]`: The unique identifier of targetedManagedAppConfiguration
  - `[TargetedManagedAppPolicyAssignmentId <String>]`: The unique identifier of targetedManagedAppPolicyAssignment
  - `[UserAppInstallStatusId <String>]`: The unique identifier of userAppInstallStatus
  - `[UserId <String>]`: The unique identifier of user
  - `[UserInstallStateSummaryId <String>]`: The unique identifier of userInstallStateSummary
  - `[UserPrincipalName <String>]`: Usage: userPrincipalName='{userPrincipalName}'
  - `[VppTokenId <String>]`: The unique identifier of vppToken
  - `[WindowsDefenderApplicationControlSupplementalPolicyAssignmentId <String>]`: The unique identifier of windowsDefenderApplicationControlSupplementalPolicyAssignment
  - `[WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatusId <String>]`: The unique identifier of windowsDefenderApplicationControlSupplementalPolicyDeploymentStatus
  - `[WindowsDefenderApplicationControlSupplementalPolicyId <String>]`: The unique identifier of windowsDefenderApplicationControlSupplementalPolicy
  - `[WindowsDeviceMalwareStateId <String>]`: The unique identifier of windowsDeviceMalwareState
  - `[WindowsInformationProtectionDeviceRegistrationId <String>]`: The unique identifier of windowsInformationProtectionDeviceRegistration
  - `[WindowsInformationProtectionPolicyId <String>]`: The unique identifier of windowsInformationProtectionPolicy
  - `[WindowsInformationProtectionWipeActionId <String>]`: The unique identifier of windowsInformationProtectionWipeAction
  - `[WindowsManagedAppProtectionId <String>]`: The unique identifier of windowsManagedAppProtection

## RELATED LINKS

