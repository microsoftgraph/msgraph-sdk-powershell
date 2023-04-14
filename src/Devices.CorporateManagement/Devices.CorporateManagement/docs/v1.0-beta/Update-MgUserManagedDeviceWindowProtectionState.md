---
external help file:
Module Name: Microsoft.Graph.Devices.CorporateManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.corporatemanagement/update-mgusermanageddevicewindowprotectionstate
schema: 2.0.0
---

# Update-MgUserManagedDeviceWindowProtectionState

## SYNOPSIS
Update the navigation property windowsProtectionState in users

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgUserManagedDeviceWindowProtectionState -ManagedDeviceId <String> -UserId <String>
 [-AdditionalProperties <Hashtable>] [-AntiMalwareVersion <String>]
 [-DetectedMalwareState <IMicrosoftGraphWindowsDeviceMalwareState[]>]
 [-DeviceState <WindowsDeviceHealthState>] [-EngineVersion <String>] [-FullScanOverdue] [-FullScanRequired]
 [-Id <String>] [-IsVirtualMachine] [-LastFullScanDateTime <DateTime>]
 [-LastFullScanSignatureVersion <String>] [-LastQuickScanDateTime <DateTime>]
 [-LastQuickScanSignatureVersion <String>] [-LastReportedDateTime <DateTime>] [-MalwareProtectionEnabled]
 [-NetworkInspectionSystemEnabled] [-ProductStatus <WindowsDefenderProductStatus>] [-QuickScanOverdue]
 [-RealTimeProtectionEnabled] [-RebootRequired] [-SignatureUpdateOverdue] [-SignatureVersion <String>]
 [-TamperProtectionEnabled] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgUserManagedDeviceWindowProtectionState -ManagedDeviceId <String> -UserId <String>
 -BodyParameter <IMicrosoftGraphWindowsProtectionState> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgUserManagedDeviceWindowProtectionState -InputObject <IDevicesCorporateManagementIdentity>
 -BodyParameter <IMicrosoftGraphWindowsProtectionState> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgUserManagedDeviceWindowProtectionState -InputObject <IDevicesCorporateManagementIdentity>
 [-AdditionalProperties <Hashtable>] [-AntiMalwareVersion <String>]
 [-DetectedMalwareState <IMicrosoftGraphWindowsDeviceMalwareState[]>]
 [-DeviceState <WindowsDeviceHealthState>] [-EngineVersion <String>] [-FullScanOverdue] [-FullScanRequired]
 [-Id <String>] [-IsVirtualMachine] [-LastFullScanDateTime <DateTime>]
 [-LastFullScanSignatureVersion <String>] [-LastQuickScanDateTime <DateTime>]
 [-LastQuickScanSignatureVersion <String>] [-LastReportedDateTime <DateTime>] [-MalwareProtectionEnabled]
 [-NetworkInspectionSystemEnabled] [-ProductStatus <WindowsDefenderProductStatus>] [-QuickScanOverdue]
 [-RealTimeProtectionEnabled] [-RebootRequired] [-SignatureUpdateOverdue] [-SignatureVersion <String>]
 [-TamperProtectionEnabled] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property windowsProtectionState in users

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

### -AntiMalwareVersion
Current anti malware version

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
Device protection status entity.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsProtectionState
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DetectedMalwareState
Device malware list
To construct, please use Get-Help -Online and see NOTES section for DETECTEDMALWARESTATE properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsDeviceMalwareState[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceState
Computer endpoint protection state

```yaml
Type: Microsoft.Graph.PowerShell.Support.WindowsDeviceHealthState
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EngineVersion
Current endpoint protection engine's version

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

### -FullScanOverdue
Full scan overdue or not

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FullScanRequired
Full scan required or not

```yaml
Type: System.Management.Automation.SwitchParameter
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
Type: Microsoft.Graph.PowerShell.Models.IDevicesCorporateManagementIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IsVirtualMachine
Indicates whether the device is a virtual machine.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastFullScanDateTime
Last quick scan datetime

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

### -LastFullScanSignatureVersion
Last full scan signature version

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

### -LastQuickScanDateTime
Last quick scan datetime

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

### -LastQuickScanSignatureVersion
Last quick scan signature version

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

### -LastReportedDateTime
Last device health status reported time

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

### -MalwareProtectionEnabled
Anti malware is enabled or not

```yaml
Type: System.Management.Automation.SwitchParameter
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

### -NetworkInspectionSystemEnabled
Network inspection system enabled or not

```yaml
Type: System.Management.Automation.SwitchParameter
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

### -ProductStatus
Product Status of Windows Defender

```yaml
Type: Microsoft.Graph.PowerShell.Support.WindowsDefenderProductStatus
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -QuickScanOverdue
Quick scan overdue or not

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RealTimeProtectionEnabled
Real time protection is enabled or not

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RebootRequired
Reboot required or not

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SignatureUpdateOverdue
Signature out of date or not

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SignatureVersion
Current malware definitions version

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

### -TamperProtectionEnabled
Indicates whether the Windows Defender tamper protection feature is enabled.

```yaml
Type: System.Management.Automation.SwitchParameter
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsProtectionState

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphWindowsProtectionState>: Device protection status entity.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[AntiMalwareVersion <String>]`: Current anti malware version
  - `[DetectedMalwareState <IMicrosoftGraphWindowsDeviceMalwareState[]>]`: Device malware list
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[AdditionalInformationUrl <String>]`: Information URL to learn more about the malware
    - `[Category <WindowsMalwareCategory?>]`: Malware category id
    - `[DetectionCount <Int32?>]`: Number of times the malware is detected
    - `[DisplayName <String>]`: Malware name
    - `[ExecutionState <WindowsMalwareExecutionState?>]`: Malware execution status
    - `[InitialDetectionDateTime <DateTime?>]`: Initial detection datetime of the malware
    - `[LastStateChangeDateTime <DateTime?>]`: The last time this particular threat was changed
    - `[Severity <WindowsMalwareSeverity?>]`: Malware severity
    - `[State <WindowsMalwareState?>]`: Malware current status
    - `[ThreatState <WindowsMalwareThreatState?>]`: Malware threat status
  - `[DeviceState <WindowsDeviceHealthState?>]`: Computer endpoint protection state
  - `[EngineVersion <String>]`: Current endpoint protection engine's version
  - `[FullScanOverdue <Boolean?>]`: Full scan overdue or not?
  - `[FullScanRequired <Boolean?>]`: Full scan required or not?
  - `[IsVirtualMachine <Boolean?>]`: Indicates whether the device is a virtual machine.
  - `[LastFullScanDateTime <DateTime?>]`: Last quick scan datetime
  - `[LastFullScanSignatureVersion <String>]`: Last full scan signature version
  - `[LastQuickScanDateTime <DateTime?>]`: Last quick scan datetime
  - `[LastQuickScanSignatureVersion <String>]`: Last quick scan signature version
  - `[LastReportedDateTime <DateTime?>]`: Last device health status reported time
  - `[MalwareProtectionEnabled <Boolean?>]`: Anti malware is enabled or not
  - `[NetworkInspectionSystemEnabled <Boolean?>]`: Network inspection system enabled or not?
  - `[ProductStatus <WindowsDefenderProductStatus?>]`: Product Status of Windows Defender
  - `[QuickScanOverdue <Boolean?>]`: Quick scan overdue or not?
  - `[RealTimeProtectionEnabled <Boolean?>]`: Real time protection is enabled or not?
  - `[RebootRequired <Boolean?>]`: Reboot required or not?
  - `[SignatureUpdateOverdue <Boolean?>]`: Signature out of date or not?
  - `[SignatureVersion <String>]`: Current malware definitions version
  - `[TamperProtectionEnabled <Boolean?>]`: Indicates whether the Windows Defender tamper protection feature is enabled.

DETECTEDMALWARESTATE <IMicrosoftGraphWindowsDeviceMalwareState[]>: Device malware list
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[AdditionalInformationUrl <String>]`: Information URL to learn more about the malware
  - `[Category <WindowsMalwareCategory?>]`: Malware category id
  - `[DetectionCount <Int32?>]`: Number of times the malware is detected
  - `[DisplayName <String>]`: Malware name
  - `[ExecutionState <WindowsMalwareExecutionState?>]`: Malware execution status
  - `[InitialDetectionDateTime <DateTime?>]`: Initial detection datetime of the malware
  - `[LastStateChangeDateTime <DateTime?>]`: The last time this particular threat was changed
  - `[Severity <WindowsMalwareSeverity?>]`: Malware severity
  - `[State <WindowsMalwareState?>]`: Malware current status
  - `[ThreatState <WindowsMalwareThreatState?>]`: Malware threat status

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
  - `[OfficeClientConfigurationAssignmentId <String>]`: The unique identifier of officeClientConfigurationAssignment
  - `[OfficeClientConfigurationId <String>]`: The unique identifier of officeClientConfiguration
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

