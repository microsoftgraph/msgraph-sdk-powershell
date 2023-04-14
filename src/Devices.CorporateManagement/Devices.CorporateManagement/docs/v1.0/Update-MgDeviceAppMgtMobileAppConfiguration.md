---
external help file:
Module Name: Microsoft.Graph.Devices.CorporateManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.corporatemanagement/update-mgdeviceappmgtmobileappconfiguration
schema: 2.0.0
---

# Update-MgDeviceAppMgtMobileAppConfiguration

## SYNOPSIS
Update the navigation property mobileAppConfigurations in deviceAppManagement

## SYNTAX

### UpdateExpanded1 (Default)
```
Update-MgDeviceAppMgtMobileAppConfiguration -ManagedDeviceMobileAppConfigurationId <String>
 [-AdditionalProperties <Hashtable>]
 [-Assignments <IMicrosoftGraphManagedDeviceMobileAppConfigurationAssignment[]>] [-CreatedDateTime <DateTime>]
 [-Description <String>] [-DeviceStatuses <IMicrosoftGraphManagedDeviceMobileAppConfigurationDeviceStatus[]>]
 [-DeviceStatusSummary <IMicrosoftGraphManagedDeviceMobileAppConfigurationDeviceSummary>]
 [-DisplayName <String>] [-Id <String>] [-LastModifiedDateTime <DateTime>] [-TargetedMobileApps <String[]>]
 [-UserStatuses <IMicrosoftGraphManagedDeviceMobileAppConfigurationUserStatus[]>]
 [-UserStatusSummary <IMicrosoftGraphManagedDeviceMobileAppConfigurationUserSummary>] [-Version <Int32>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update1
```
Update-MgDeviceAppMgtMobileAppConfiguration -ManagedDeviceMobileAppConfigurationId <String>
 -BodyParameter <IMicrosoftGraphManagedDeviceMobileAppConfiguration> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentity1
```
Update-MgDeviceAppMgtMobileAppConfiguration -InputObject <IDevicesCorporateManagementIdentity>
 -BodyParameter <IMicrosoftGraphManagedDeviceMobileAppConfiguration> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded1
```
Update-MgDeviceAppMgtMobileAppConfiguration -InputObject <IDevicesCorporateManagementIdentity>
 [-AdditionalProperties <Hashtable>]
 [-Assignments <IMicrosoftGraphManagedDeviceMobileAppConfigurationAssignment[]>] [-CreatedDateTime <DateTime>]
 [-Description <String>] [-DeviceStatuses <IMicrosoftGraphManagedDeviceMobileAppConfigurationDeviceStatus[]>]
 [-DeviceStatusSummary <IMicrosoftGraphManagedDeviceMobileAppConfigurationDeviceSummary>]
 [-DisplayName <String>] [-Id <String>] [-LastModifiedDateTime <DateTime>] [-TargetedMobileApps <String[]>]
 [-UserStatuses <IMicrosoftGraphManagedDeviceMobileAppConfigurationUserStatus[]>]
 [-UserStatusSummary <IMicrosoftGraphManagedDeviceMobileAppConfigurationUserSummary>] [-Version <Int32>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property mobileAppConfigurations in deviceAppManagement

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Assignments
The list of group assignemenets for app configration.
To construct, please use Get-Help -Online and see NOTES section for ASSIGNMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedDeviceMobileAppConfigurationAssignment[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
An abstract class for Mobile app configuration for enrolled devices.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedDeviceMobileAppConfiguration
Parameter Sets: Update1, UpdateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedDateTime
DateTime the object was created.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
Admin provided description of the Device Configuration.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceStatuses
List of ManagedDeviceMobileAppConfigurationDeviceStatus.
To construct, please use Get-Help -Online and see NOTES section for DEVICESTATUSES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedDeviceMobileAppConfigurationDeviceStatus[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceStatusSummary
Contains properties, inherited properties and actions for an MDM mobile app configuration device status summary.
To construct, please use Get-Help -Online and see NOTES section for DEVICESTATUSSUMMARY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedDeviceMobileAppConfigurationDeviceSummary
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
Admin provided name of the device configuration.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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
Parameter Sets: UpdateViaIdentity1, UpdateViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LastModifiedDateTime
DateTime the object was last modified.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ManagedDeviceMobileAppConfigurationId
The unique identifier of managedDeviceMobileAppConfiguration

```yaml
Type: System.String
Parameter Sets: Update1, UpdateExpanded1
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

### -TargetedMobileApps
the associated app.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserStatuses
List of ManagedDeviceMobileAppConfigurationUserStatus.
To construct, please use Get-Help -Online and see NOTES section for USERSTATUSES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedDeviceMobileAppConfigurationUserStatus[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserStatusSummary
Contains properties, inherited properties and actions for an MDM mobile app configuration user status summary.
To construct, please use Get-Help -Online and see NOTES section for USERSTATUSSUMMARY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedDeviceMobileAppConfigurationUserSummary
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Version
Version of the device configuration.

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedDeviceMobileAppConfiguration

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

### Update-MgDeviceAppManagementMobileAppConfiguration

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ASSIGNMENTS <IMicrosoftGraphManagedDeviceMobileAppConfigurationAssignment[]>: The list of group assignemenets for app configration.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: Base type for assignment targets.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.

BODYPARAMETER <IMicrosoftGraphManagedDeviceMobileAppConfiguration>: An abstract class for Mobile app configuration for enrolled devices.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Assignments <IMicrosoftGraphManagedDeviceMobileAppConfigurationAssignment[]>]`: The list of group assignemenets for app configration.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: Base type for assignment targets.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CreatedDateTime <DateTime?>]`: DateTime the object was created.
  - `[Description <String>]`: Admin provided description of the Device Configuration.
  - `[DeviceStatusSummary <IMicrosoftGraphManagedDeviceMobileAppConfigurationDeviceSummary>]`: Contains properties, inherited properties and actions for an MDM mobile app configuration device status summary.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[ConfigurationVersion <Int32?>]`: Version of the policy for that overview
    - `[ErrorCount <Int32?>]`: Number of error devices
    - `[FailedCount <Int32?>]`: Number of failed devices
    - `[LastUpdateDateTime <DateTime?>]`: Last update time
    - `[NotApplicableCount <Int32?>]`: Number of not applicable devices
    - `[PendingCount <Int32?>]`: Number of pending devices
    - `[SuccessCount <Int32?>]`: Number of succeeded devices
  - `[DeviceStatuses <IMicrosoftGraphManagedDeviceMobileAppConfigurationDeviceStatus[]>]`: List of ManagedDeviceMobileAppConfigurationDeviceStatus.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[ComplianceGracePeriodExpirationDateTime <DateTime?>]`: The DateTime when device compliance grace period expires
    - `[DeviceDisplayName <String>]`: Device name of the DevicePolicyStatus.
    - `[DeviceModel <String>]`: The device model that is being reported
    - `[LastReportedDateTime <DateTime?>]`: Last modified date time of the policy report.
    - `[Status <String>]`: complianceStatus
    - `[UserName <String>]`: The User Name that is being reported
    - `[UserPrincipalName <String>]`: UserPrincipalName.
  - `[DisplayName <String>]`: Admin provided name of the device configuration.
  - `[LastModifiedDateTime <DateTime?>]`: DateTime the object was last modified.
  - `[TargetedMobileApps <String[]>]`: the associated app.
  - `[UserStatusSummary <IMicrosoftGraphManagedDeviceMobileAppConfigurationUserSummary>]`: Contains properties, inherited properties and actions for an MDM mobile app configuration user status summary.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[ConfigurationVersion <Int32?>]`: Version of the policy for that overview
    - `[ErrorCount <Int32?>]`: Number of error Users
    - `[FailedCount <Int32?>]`: Number of failed Users
    - `[LastUpdateDateTime <DateTime?>]`: Last update time
    - `[NotApplicableCount <Int32?>]`: Number of not applicable users
    - `[PendingCount <Int32?>]`: Number of pending Users
    - `[SuccessCount <Int32?>]`: Number of succeeded Users
  - `[UserStatuses <IMicrosoftGraphManagedDeviceMobileAppConfigurationUserStatus[]>]`: List of ManagedDeviceMobileAppConfigurationUserStatus.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[DevicesCount <Int32?>]`: Devices count for that user.
    - `[LastReportedDateTime <DateTime?>]`: Last modified date time of the policy report.
    - `[Status <String>]`: complianceStatus
    - `[UserDisplayName <String>]`: User name of the DevicePolicyStatus.
    - `[UserPrincipalName <String>]`: UserPrincipalName.
  - `[Version <Int32?>]`: Version of the device configuration.

DEVICESTATUSES <IMicrosoftGraphManagedDeviceMobileAppConfigurationDeviceStatus[]>: List of ManagedDeviceMobileAppConfigurationDeviceStatus.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[ComplianceGracePeriodExpirationDateTime <DateTime?>]`: The DateTime when device compliance grace period expires
  - `[DeviceDisplayName <String>]`: Device name of the DevicePolicyStatus.
  - `[DeviceModel <String>]`: The device model that is being reported
  - `[LastReportedDateTime <DateTime?>]`: Last modified date time of the policy report.
  - `[Status <String>]`: complianceStatus
  - `[UserName <String>]`: The User Name that is being reported
  - `[UserPrincipalName <String>]`: UserPrincipalName.

DEVICESTATUSSUMMARY <IMicrosoftGraphManagedDeviceMobileAppConfigurationDeviceSummary>: Contains properties, inherited properties and actions for an MDM mobile app configuration device status summary.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[ConfigurationVersion <Int32?>]`: Version of the policy for that overview
  - `[ErrorCount <Int32?>]`: Number of error devices
  - `[FailedCount <Int32?>]`: Number of failed devices
  - `[LastUpdateDateTime <DateTime?>]`: Last update time
  - `[NotApplicableCount <Int32?>]`: Number of not applicable devices
  - `[PendingCount <Int32?>]`: Number of pending devices
  - `[SuccessCount <Int32?>]`: Number of succeeded devices

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

USERSTATUSES <IMicrosoftGraphManagedDeviceMobileAppConfigurationUserStatus[]>: List of ManagedDeviceMobileAppConfigurationUserStatus.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[DevicesCount <Int32?>]`: Devices count for that user.
  - `[LastReportedDateTime <DateTime?>]`: Last modified date time of the policy report.
  - `[Status <String>]`: complianceStatus
  - `[UserDisplayName <String>]`: User name of the DevicePolicyStatus.
  - `[UserPrincipalName <String>]`: UserPrincipalName.

USERSTATUSSUMMARY <IMicrosoftGraphManagedDeviceMobileAppConfigurationUserSummary>: Contains properties, inherited properties and actions for an MDM mobile app configuration user status summary.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[ConfigurationVersion <Int32?>]`: Version of the policy for that overview
  - `[ErrorCount <Int32?>]`: Number of error Users
  - `[FailedCount <Int32?>]`: Number of failed Users
  - `[LastUpdateDateTime <DateTime?>]`: Last update time
  - `[NotApplicableCount <Int32?>]`: Number of not applicable users
  - `[PendingCount <Int32?>]`: Number of pending Users
  - `[SuccessCount <Int32?>]`: Number of succeeded Users

## RELATED LINKS

