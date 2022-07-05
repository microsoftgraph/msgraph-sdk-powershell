---
external help file:
Module Name: Microsoft.Graph.Devices.CorporateManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.corporatemanagement/new-mgdeviceappmgtmanagedappregistrationintendedpolicy
schema: 2.0.0
---

# New-MgDeviceAppMgtManagedAppRegistrationIntendedPolicy

## SYNOPSIS
Create new navigation property to intendedPolicies for deviceAppManagement

## SYNTAX

### CreateExpanded1 (Default)
```
New-MgDeviceAppMgtManagedAppRegistrationIntendedPolicy -ManagedAppRegistrationId <String>
 [-AdditionalProperties <Hashtable>] [-CreatedDateTime <DateTime>] [-Description <String>]
 [-DisplayName <String>] [-Id <String>] [-LastModifiedDateTime <DateTime>] [-RoleScopeTagIds <String[]>]
 [-Version <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create1
```
New-MgDeviceAppMgtManagedAppRegistrationIntendedPolicy -ManagedAppRegistrationId <String>
 -BodyParameter <IMicrosoftGraphManagedAppPolicy> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity1
```
New-MgDeviceAppMgtManagedAppRegistrationIntendedPolicy -InputObject <IDevicesCorporateManagementIdentity>
 -BodyParameter <IMicrosoftGraphManagedAppPolicy> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded1
```
New-MgDeviceAppMgtManagedAppRegistrationIntendedPolicy -InputObject <IDevicesCorporateManagementIdentity>
 [-AdditionalProperties <Hashtable>] [-CreatedDateTime <DateTime>] [-Description <String>]
 [-DisplayName <String>] [-Id <String>] [-LastModifiedDateTime <DateTime>] [-RoleScopeTagIds <String[]>]
 [-Version <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to intendedPolicies for deviceAppManagement

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
The ManagedAppPolicy resource represents a base type for platform specific policies.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedAppPolicy
Parameter Sets: Create1, CreateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedDateTime
The date and time the policy was created.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
The policy's description.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
Policy display name.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
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
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
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
Parameter Sets: CreateViaIdentity1, CreateViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LastModifiedDateTime
Last time the policy was modified.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ManagedAppRegistrationId
key: id of managedAppRegistration

```yaml
Type: System.String
Parameter Sets: Create1, CreateExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RoleScopeTagIds
List of Scope Tags for this Entity instance.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Version
Version of the entity.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedAppPolicy

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedAppPolicy

## NOTES

ALIASES

### New-MgDeviceAppManagementManagedAppRegistrationIntendedPolicy

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphManagedAppPolicy>: The ManagedAppPolicy resource represents a base type for platform specific policies.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[CreatedDateTime <DateTime?>]`: The date and time the policy was created.
  - `[Description <String>]`: The policy's description.
  - `[DisplayName <String>]`: Policy display name.
  - `[LastModifiedDateTime <DateTime?>]`: Last time the policy was modified.
  - `[RoleScopeTagIds <String[]>]`: List of Scope Tags for this Entity instance.
  - `[Version <String>]`: Version of the entity.

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

## RELATED LINKS

