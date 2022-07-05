---
external help file:
Module Name: Microsoft.Graph.Devices.CorporateManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.corporatemanagement/update-mgofficeclientconfiguration
schema: 2.0.0
---

# Update-MgOfficeClientConfiguration

## SYNOPSIS
Update the navigation property clientConfigurations in officeConfiguration

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgOfficeClientConfiguration -OfficeClientConfigurationId <String> [-AdditionalProperties <Hashtable>]
 [-Assignments <IMicrosoftGraphOfficeClientConfigurationAssignment[]>]
 [-CheckinStatuses <IMicrosoftGraphOfficeClientCheckinStatus[]>] [-Description <String>]
 [-DisplayName <String>] [-Id <String>] [-PolicyPayloadInputFile <String>] [-Priority <Int32>]
 [-UserCheckinSummary <IMicrosoftGraphOfficeUserCheckinSummary>] [-UserPreferencePayloadInputFile <String>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgOfficeClientConfiguration -OfficeClientConfigurationId <String>
 -BodyParameter <IMicrosoftGraphOfficeClientConfiguration> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgOfficeClientConfiguration -InputObject <IDevicesCorporateManagementIdentity>
 -BodyParameter <IMicrosoftGraphOfficeClientConfiguration> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgOfficeClientConfiguration -InputObject <IDevicesCorporateManagementIdentity>
 [-AdditionalProperties <Hashtable>] [-Assignments <IMicrosoftGraphOfficeClientConfigurationAssignment[]>]
 [-CheckinStatuses <IMicrosoftGraphOfficeClientCheckinStatus[]>] [-Description <String>]
 [-DisplayName <String>] [-Id <String>] [-PolicyPayloadInputFile <String>] [-Priority <Int32>]
 [-UserCheckinSummary <IMicrosoftGraphOfficeUserCheckinSummary>] [-UserPreferencePayloadInputFile <String>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property clientConfigurations in officeConfiguration

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

### -Assignments
The list of group assignments for the policy.
To construct, please use Get-Help -Online and see NOTES section for ASSIGNMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOfficeClientConfigurationAssignment[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
officeClientConfiguration
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOfficeClientConfiguration
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CheckinStatuses
List of office Client check-in status.
To construct, please use Get-Help -Online and see NOTES section for CHECKINSTATUSES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOfficeClientCheckinStatus[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
Not yet documented

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

### -DisplayName
Admin provided description of the office client configuration policy.

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
.

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

### -OfficeClientConfigurationId
key: id of officeClientConfiguration

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

### -PolicyPayloadInputFile
Input File for PolicyPayload (Policy settings JSON string in binary format, these values cannot be changed by the user.)

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

### -Priority
Priority value should be unique value for each policy under a tenant and will be used for conflict resolution, lower values mean priority is high.

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

### -UserCheckinSummary
officeUserCheckinSummary
To construct, please use Get-Help -Online and see NOTES section for USERCHECKINSUMMARY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOfficeUserCheckinSummary
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserPreferencePayloadInputFile
Input File for UserPreferencePayload (Preference settings JSON string in binary format, these values can be overridden by the user.)

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOfficeClientConfiguration

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ASSIGNMENTS <IMicrosoftGraphOfficeClientConfigurationAssignment[]>: The list of group assignments for the policy.
  - `[Id <String>]`: 
  - `[Target <IMicrosoftGraphOfficeConfigurationAssignmentTarget>]`: officeConfigurationAssignmentTarget
    - `[(Any) <Object>]`: This indicates any property can be added to this object.

BODYPARAMETER <IMicrosoftGraphOfficeClientConfiguration>: officeClientConfiguration
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[Assignments <IMicrosoftGraphOfficeClientConfigurationAssignment[]>]`: The list of group assignments for the policy.
    - `[Id <String>]`: 
    - `[Target <IMicrosoftGraphOfficeConfigurationAssignmentTarget>]`: officeConfigurationAssignmentTarget
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CheckinStatuses <IMicrosoftGraphOfficeClientCheckinStatus[]>]`: List of office Client check-in status.
    - `[AppliedPolicies <String[]>]`: List of policies delivered to the device as last checkin.
    - `[CheckinDateTime <DateTime?>]`: Last device check-in time in UTC.
    - `[DeviceName <String>]`: Device name trying to check-in.
    - `[DevicePlatform <String>]`: Device platform trying to check-in.
    - `[DevicePlatformVersion <String>]`: Device platform version trying to check-in.
    - `[ErrorMessage <String>]`: Error message if any associated for the last checkin.
    - `[UserId <String>]`: User identifier using the device.
    - `[UserPrincipalName <String>]`: User principal name using the device.
    - `[WasSuccessful <Boolean?>]`: If the last checkin was successful.
  - `[Description <String>]`: Not yet documented
  - `[DisplayName <String>]`: Admin provided description of the office client configuration policy.
  - `[PolicyPayload <Byte[]>]`: Policy settings JSON string in binary format, these values cannot be changed by the user.
  - `[Priority <Int32?>]`: Priority value should be unique value for each policy under a tenant and will be used for conflict resolution, lower values mean priority is high.
  - `[UserCheckinSummary <IMicrosoftGraphOfficeUserCheckinSummary>]`: officeUserCheckinSummary
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[FailedUserCount <Int32?>]`: Total failed user check ins for the last 3 months.
    - `[SucceededUserCount <Int32?>]`: Total successful user check ins for the last 3 months.
  - `[UserPreferencePayload <Byte[]>]`: Preference settings JSON string in binary format, these values can be overridden by the user.

CHECKINSTATUSES <IMicrosoftGraphOfficeClientCheckinStatus[]>: List of office Client check-in status.
  - `[AppliedPolicies <String[]>]`: List of policies delivered to the device as last checkin.
  - `[CheckinDateTime <DateTime?>]`: Last device check-in time in UTC.
  - `[DeviceName <String>]`: Device name trying to check-in.
  - `[DevicePlatform <String>]`: Device platform trying to check-in.
  - `[DevicePlatformVersion <String>]`: Device platform version trying to check-in.
  - `[ErrorMessage <String>]`: Error message if any associated for the last checkin.
  - `[UserId <String>]`: User identifier using the device.
  - `[UserPrincipalName <String>]`: User principal name using the device.
  - `[WasSuccessful <Boolean?>]`: If the last checkin was successful.

INPUTOBJECT <IDevicesCorporateManagementIdentity>: Identity Parameter
  - `[AndroidManagedAppProtectionId <String>]`: key: id of androidManagedAppProtection
  - `[AppLogCollectionRequestId <String>]`: key: id of appLogCollectionRequest
  - `[AssignmentFilterEvaluationStatusDetailsId <String>]`: key: id of assignmentFilterEvaluationStatusDetails
  - `[BundleId <String>]`: Usage: bundleId='{bundleId}'
  - `[Count <Int64?>]`: Usage: count={count}
  - `[DefaultManagedAppProtectionId <String>]`: key: id of defaultManagedAppProtection
  - `[DetectedAppId <String>]`: key: id of detectedApp
  - `[DeviceAppManagementTaskId <String>]`: key: id of deviceAppManagementTask
  - `[DeviceCompliancePolicyStateId <String>]`: key: id of deviceCompliancePolicyState
  - `[DeviceConfigurationStateId <String>]`: key: id of deviceConfigurationState
  - `[DeviceEnrollmentConfigurationId <String>]`: key: id of deviceEnrollmentConfiguration
  - `[DeviceId <String>]`: Usage: deviceId='{deviceId}'
  - `[DeviceInstallStateId <String>]`: key: id of deviceInstallState
  - `[DeviceLogCollectionResponseId <String>]`: key: id of deviceLogCollectionResponse
  - `[DeviceManagementTroubleshootingEventId <String>]`: key: id of deviceManagementTroubleshootingEvent
  - `[EnrollmentConfigurationAssignmentId <String>]`: key: id of enrollmentConfigurationAssignment
  - `[EnterpriseCodeSigningCertificateId <String>]`: key: id of enterpriseCodeSigningCertificate
  - `[IosLobAppProvisioningConfigurationAssignmentId <String>]`: key: id of iosLobAppProvisioningConfigurationAssignment
  - `[IosLobAppProvisioningConfigurationId <String>]`: key: id of iosLobAppProvisioningConfiguration
  - `[IosManagedAppProtectionId <String>]`: key: id of iosManagedAppProtection
  - `[ManagedAppOperationId <String>]`: key: id of managedAppOperation
  - `[ManagedAppPolicyId <String>]`: key: id of managedAppPolicy
  - `[ManagedAppRegistrationId <String>]`: key: id of managedAppRegistration
  - `[ManagedAppStatusId <String>]`: key: id of managedAppStatus
  - `[ManagedDeviceId <String>]`: key: id of managedDevice
  - `[ManagedDeviceMobileAppConfigurationAssignmentId <String>]`: key: id of managedDeviceMobileAppConfigurationAssignment
  - `[ManagedDeviceMobileAppConfigurationDeviceStatusId <String>]`: key: id of managedDeviceMobileAppConfigurationDeviceStatus
  - `[ManagedDeviceMobileAppConfigurationId <String>]`: key: id of managedDeviceMobileAppConfiguration
  - `[ManagedDeviceMobileAppConfigurationStateId <String>]`: key: id of managedDeviceMobileAppConfigurationState
  - `[ManagedDeviceMobileAppConfigurationUserStatusId <String>]`: key: id of managedDeviceMobileAppConfigurationUserStatus
  - `[ManagedEBookAssignmentId <String>]`: key: id of managedEBookAssignment
  - `[ManagedEBookCategoryId <String>]`: key: id of managedEBookCategory
  - `[ManagedEBookId <String>]`: key: id of managedEBook
  - `[ManagedMobileAppId <String>]`: key: id of managedMobileApp
  - `[MdmWindowsInformationProtectionPolicyId <String>]`: key: id of mdmWindowsInformationProtectionPolicy
  - `[MobileAppAssignmentId <String>]`: key: id of mobileAppAssignment
  - `[MobileAppCategoryId <String>]`: key: id of mobileAppCategory
  - `[MobileAppId <String>]`: key: id of mobileApp
  - `[MobileAppInstallStatusId <String>]`: key: id of mobileAppInstallStatus
  - `[MobileAppIntentAndStateId <String>]`: key: id of mobileAppIntentAndState
  - `[MobileAppProvisioningConfigGroupAssignmentId <String>]`: key: id of mobileAppProvisioningConfigGroupAssignment
  - `[MobileAppRelationshipId <String>]`: key: id of mobileAppRelationship
  - `[MobileAppTroubleshootingEventId <String>]`: key: id of mobileAppTroubleshootingEvent
  - `[OfficeClientConfigurationAssignmentId <String>]`: key: id of officeClientConfigurationAssignment
  - `[OfficeClientConfigurationId <String>]`: key: id of officeClientConfiguration
  - `[PolicySetAssignmentId <String>]`: key: id of policySetAssignment
  - `[PolicySetId <String>]`: key: id of policySet
  - `[PolicySetItemId <String>]`: key: id of policySetItem
  - `[SecurityBaselineSettingStateId <String>]`: key: id of securityBaselineSettingState
  - `[SecurityBaselineStateId <String>]`: key: id of securityBaselineState
  - `[SideLoadingKeyId <String>]`: key: id of sideLoadingKey
  - `[Status <String>]`: Usage: status='{status}'
  - `[TargetedManagedAppConfigurationId <String>]`: key: id of targetedManagedAppConfiguration
  - `[TargetedManagedAppPolicyAssignmentId <String>]`: key: id of targetedManagedAppPolicyAssignment
  - `[UserAppInstallStatusId <String>]`: key: id of userAppInstallStatus
  - `[UserId <String>]`: key: id of user
  - `[UserInstallStateSummaryId <String>]`: key: id of userInstallStateSummary
  - `[UserPrincipalName <String>]`: Usage: userPrincipalName='{userPrincipalName}'
  - `[VppTokenId <String>]`: key: id of vppToken
  - `[WindowsDefenderApplicationControlSupplementalPolicyAssignmentId <String>]`: key: id of windowsDefenderApplicationControlSupplementalPolicyAssignment
  - `[WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatusId <String>]`: key: id of windowsDefenderApplicationControlSupplementalPolicyDeploymentStatus
  - `[WindowsDefenderApplicationControlSupplementalPolicyId <String>]`: key: id of windowsDefenderApplicationControlSupplementalPolicy
  - `[WindowsDeviceMalwareStateId <String>]`: key: id of windowsDeviceMalwareState
  - `[WindowsInformationProtectionDeviceRegistrationId <String>]`: key: id of windowsInformationProtectionDeviceRegistration
  - `[WindowsInformationProtectionPolicyId <String>]`: key: id of windowsInformationProtectionPolicy
  - `[WindowsInformationProtectionWipeActionId <String>]`: key: id of windowsInformationProtectionWipeAction
  - `[WindowsManagedAppProtectionId <String>]`: key: id of windowsManagedAppProtection

USERCHECKINSUMMARY <IMicrosoftGraphOfficeUserCheckinSummary>: officeUserCheckinSummary
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[FailedUserCount <Int32?>]`: Total failed user check ins for the last 3 months.
  - `[SucceededUserCount <Int32?>]`: Total successful user check ins for the last 3 months.

## RELATED LINKS

