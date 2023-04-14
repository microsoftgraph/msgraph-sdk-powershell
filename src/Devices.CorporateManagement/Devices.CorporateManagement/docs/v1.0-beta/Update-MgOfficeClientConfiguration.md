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

### -OfficeClientConfigurationId
The unique identifier of officeClientConfiguration

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
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Target <IMicrosoftGraphOfficeConfigurationAssignmentTarget>]`: officeConfigurationAssignmentTarget
    - `[(Any) <Object>]`: This indicates any property can be added to this object.

BODYPARAMETER <IMicrosoftGraphOfficeClientConfiguration>: officeClientConfiguration
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Assignments <IMicrosoftGraphOfficeClientConfigurationAssignment[]>]`: The list of group assignments for the policy.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
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

USERCHECKINSUMMARY <IMicrosoftGraphOfficeUserCheckinSummary>: officeUserCheckinSummary
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[FailedUserCount <Int32?>]`: Total failed user check ins for the last 3 months.
  - `[SucceededUserCount <Int32?>]`: Total successful user check ins for the last 3 months.

## RELATED LINKS

