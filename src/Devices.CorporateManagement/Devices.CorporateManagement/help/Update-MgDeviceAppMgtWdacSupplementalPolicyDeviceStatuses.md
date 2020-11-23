---
external help file: Microsoft.Graph.Devices.CorporateManagement-help.xml
Module Name: Microsoft.Graph.Devices.CorporateManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.corporatemanagement/update-mgdeviceappmgtwdacsupplementalpolicydevicestatuses
schema: 2.0.0
---

# Update-MgDeviceAppMgtWdacSupplementalPolicyDeviceStatuses

## SYNOPSIS
Update the navigation property deviceStatuses in deviceAppManagement

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgDeviceAppMgtWdacSupplementalPolicyDeviceStatuses
 -WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatusId <String>
 -WindowsDefenderApplicationControlSupplementalPolicyId <String> [-AdditionalProperties <Hashtable>]
 [-DeploymentStatus <String>] [-DeviceId <String>] [-DeviceName <String>] [-Id <String>]
 [-LastSyncDateTime <DateTime>] [-OSDescription <String>] [-OSVersion <String>]
 [-Policy <IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicy>] [-PolicyVersion <String>]
 [-UserName <String>] [-UserPrincipalName <String>] [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Update
```
Update-MgDeviceAppMgtWdacSupplementalPolicyDeviceStatuses
 -WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatusId <String>
 -WindowsDefenderApplicationControlSupplementalPolicyId <String>
 -BodyParameter <IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus>
 [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgDeviceAppMgtWdacSupplementalPolicyDeviceStatuses -InputObject <IDevicesCorporateManagementIdentity>
 [-AdditionalProperties <Hashtable>] [-DeploymentStatus <String>] [-DeviceId <String>] [-DeviceName <String>]
 [-Id <String>] [-LastSyncDateTime <DateTime>] [-OSDescription <String>] [-OSVersion <String>]
 [-Policy <IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicy>] [-PolicyVersion <String>]
 [-UserName <String>] [-UserPrincipalName <String>] [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgDeviceAppMgtWdacSupplementalPolicyDeviceStatuses -InputObject <IDevicesCorporateManagementIdentity>
 -BodyParameter <IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus>
 [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property deviceStatuses in deviceAppManagement

## EXAMPLES

### EXAMPLE 1
```
{{ Add code here }}
```

{{ Add output here }}

### EXAMPLE 2
```
{{ Add code here }}
```

{{ Add output here }}

## PARAMETERS

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
Contains properties for the deployment state of a WindowsDefenderApplicationControl supplemental policy for a device.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DeploymentStatus
windowsDefenderApplicationControlSupplementalPolicyStatuses

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

### -DeviceId
Device ID.

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

### -DeviceName
Device name.

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
Type: IDevicesCorporateManagementIdentity
Parameter Sets: UpdateViaIdentityExpanded, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LastSyncDateTime
Last sync date time.

```yaml
Type: DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OSDescription
Windows OS Version Description.

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

### -OSVersion
Windows OS Version.

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
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -Policy
windowsDefenderApplicationControlSupplementalPolicy
To construct, see NOTES section for POLICY properties and create a hash table.

```yaml
Type: IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicy
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PolicyVersion
Human readable version of the WindowsDefenderApplicationControl supplemental policy.

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

### -UserName
The name of the user of this device.

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

### -UserPrincipalName
User Principal Name.

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

### -WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatusId
key: id of windowsDefenderApplicationControlSupplementalPolicyDeploymentStatus

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

### -WindowsDefenderApplicationControlSupplementalPolicyId
key: id of windowsDefenderApplicationControlSupplementalPolicy

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

### Microsoft.Graph.PowerShell.Models.IDevicesCorporateManagementIdentity
### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus
## OUTPUTS

### System.Boolean
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

BODYPARAMETER \<IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus\>: Contains properties for the deployment state of a WindowsDefenderApplicationControl supplemental policy for a device.
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[DeploymentStatus \<String\>\]: windowsDefenderApplicationControlSupplementalPolicyStatuses
  \[DeviceId \<String\>\]: Device ID.
  \[DeviceName \<String\>\]: Device name.
  \[LastSyncDateTime \<DateTime?\>\]: Last sync date time.
  \[OSDescription \<String\>\]: Windows OS Version Description.
  \[OSVersion \<String\>\]: Windows OS Version.
  \[Policy \<IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicy\>\]: windowsDefenderApplicationControlSupplementalPolicy
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Id \<String\>\]: Read-only.
    \[Assignments \<IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicyAssignment\[\]\>\]: The associated group assignments for this WindowsDefenderApplicationControl supplemental policy.
      \[Id \<String\>\]: Read-only.
      \[Target \<IMicrosoftGraphDeviceAndAppManagementAssignmentTarget\>\]: Base type for assignment targets.
        \[(Any) \<Object\>\]: This indicates any property can be added to this object.
        \[DeviceAndAppManagementAssignmentFilterId \<String\>\]: The Id of the filter for the target assignment.
        \[DeviceAndAppManagementAssignmentFilterType \<String\>\]: deviceAndAppManagementAssignmentFilterType
    \[Content \<Byte\[\]\>\]: The WindowsDefenderApplicationControl supplemental policy content in byte array format.
    \[ContentFileName \<String\>\]: The WindowsDefenderApplicationControl supplemental policy content's file name.
    \[CreationDateTime \<DateTime?\>\]: The date and time when the WindowsDefenderApplicationControl supplemental policy was uploaded.
    \[DeploySummary \<IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary\>\]: Contains properties for the deployment summary of a WindowsDefenderApplicationControl supplemental policy.
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[Id \<String\>\]: Read-only.
      \[DeployedDeviceCount \<Int32?\>\]: Number of Devices that have successfully deployed this WindowsDefenderApplicationControl supplemental policy.
      \[FailedDeviceCount \<Int32?\>\]: Number of Devices that have failed to deploy this WindowsDefenderApplicationControl supplemental policy.
    \[Description \<String\>\]: The description of WindowsDefenderApplicationControl supplemental policy.
    \[DeviceStatuses \<IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus\[\]\>\]: The list of device deployment states for this WindowsDefenderApplicationControl supplemental policy.
    \[DisplayName \<String\>\]: The display name of WindowsDefenderApplicationControl supplemental policy.
    \[LastModifiedDateTime \<DateTime?\>\]: The date and time when the WindowsDefenderApplicationControl supplemental policy was last modified.
    \[RoleScopeTagIds \<String\[\]\>\]: List of Scope Tags for this WindowsDefenderApplicationControl supplemental policy entity.
    \[Version \<String\>\]: The WindowsDefenderApplicationControl supplemental policy's version.
  \[PolicyVersion \<String\>\]: Human readable version of the WindowsDefenderApplicationControl supplemental policy.
  \[UserName \<String\>\]: The name of the user of this device.
  \[UserPrincipalName \<String\>\]: User Principal Name.

INPUTOBJECT \<IDevicesCorporateManagementIdentity\>: Identity Parameter
  \[AndroidManagedAppProtectionId \<String\>\]: key: id of androidManagedAppProtection
  \[AppLogCollectionRequestId \<String\>\]: key: id of appLogCollectionRequest
  \[BundleId \<String\>\]: 
  \[Count \<Int64?\>\]: 
  \[DefaultManagedAppProtectionId \<String\>\]: key: id of defaultManagedAppProtection
  \[DeviceAppManagementTaskId \<String\>\]: key: id of deviceAppManagementTask
  \[DeviceCompliancePolicyStateId \<String\>\]: key: id of deviceCompliancePolicyState
  \[DeviceConfigurationStateId \<String\>\]: key: id of deviceConfigurationState
  \[DeviceEnrollmentConfigurationId \<String\>\]: key: id of deviceEnrollmentConfiguration
  \[DeviceId \<String\>\]: 
  \[DeviceInstallStateId \<String\>\]: key: id of deviceInstallState
  \[DeviceLogCollectionResponseId \<String\>\]: key: id of deviceLogCollectionResponse
  \[DeviceManagementTroubleshootingEventId \<String\>\]: key: id of deviceManagementTroubleshootingEvent
  \[EnrollmentConfigurationAssignmentId \<String\>\]: key: id of enrollmentConfigurationAssignment
  \[EnterpriseCodeSigningCertificateId \<String\>\]: key: id of enterpriseCodeSigningCertificate
  \[IosLobAppProvisioningConfigurationAssignmentId \<String\>\]: key: id of iosLobAppProvisioningConfigurationAssignment
  \[IosLobAppProvisioningConfigurationId \<String\>\]: key: id of iosLobAppProvisioningConfiguration
  \[IosManagedAppProtectionId \<String\>\]: key: id of iosManagedAppProtection
  \[ManagedAppOperationId \<String\>\]: key: id of managedAppOperation
  \[ManagedAppPolicyId \<String\>\]: key: id of managedAppPolicy
  \[ManagedAppRegistrationId \<String\>\]: key: id of managedAppRegistration
  \[ManagedAppStatusId \<String\>\]: key: id of managedAppStatus
  \[ManagedDeviceId \<String\>\]: key: id of managedDevice
  \[ManagedDeviceMobileAppConfigurationAssignmentId \<String\>\]: key: id of managedDeviceMobileAppConfigurationAssignment
  \[ManagedDeviceMobileAppConfigurationDeviceStatusId \<String\>\]: key: id of managedDeviceMobileAppConfigurationDeviceStatus
  \[ManagedDeviceMobileAppConfigurationId \<String\>\]: key: id of managedDeviceMobileAppConfiguration
  \[ManagedDeviceMobileAppConfigurationStateId \<String\>\]: key: id of managedDeviceMobileAppConfigurationState
  \[ManagedDeviceMobileAppConfigurationUserStatusId \<String\>\]: key: id of managedDeviceMobileAppConfigurationUserStatus
  \[ManagedEBookAssignmentId \<String\>\]: key: id of managedEBookAssignment
  \[ManagedEBookCategoryId \<String\>\]: key: id of managedEBookCategory
  \[ManagedEBookId \<String\>\]: key: id of managedEBook
  \[ManagedMobileAppId \<String\>\]: key: id of managedMobileApp
  \[MdmWindowsInformationProtectionPolicyId \<String\>\]: key: id of mdmWindowsInformationProtectionPolicy
  \[MobileAppAssignmentId \<String\>\]: key: id of mobileAppAssignment
  \[MobileAppCategoryId \<String\>\]: key: id of mobileAppCategory
  \[MobileAppId \<String\>\]: key: id of mobileApp
  \[MobileAppInstallStatusId \<String\>\]: key: id of mobileAppInstallStatus
  \[MobileAppIntentAndStateId \<String\>\]: key: id of mobileAppIntentAndState
  \[MobileAppProvisioningConfigGroupAssignmentId \<String\>\]: key: id of mobileAppProvisioningConfigGroupAssignment
  \[MobileAppRelationshipId \<String\>\]: key: id of mobileAppRelationship
  \[MobileAppTroubleshootingEventId \<String\>\]: key: id of mobileAppTroubleshootingEvent
  \[OfficeClientConfigurationAssignmentId \<String\>\]: key: id of officeClientConfigurationAssignment
  \[OfficeClientConfigurationId \<String\>\]: key: id of officeClientConfiguration
  \[PolicySetAssignmentId \<String\>\]: key: id of policySetAssignment
  \[PolicySetId \<String\>\]: key: id of policySet
  \[PolicySetItemId \<String\>\]: key: id of policySetItem
  \[SecurityBaselineSettingStateId \<String\>\]: key: id of securityBaselineSettingState
  \[SecurityBaselineStateId \<String\>\]: key: id of securityBaselineState
  \[SideLoadingKeyId \<String\>\]: key: id of sideLoadingKey
  \[Status \<String\>\]: 
  \[TargetedManagedAppConfigurationId \<String\>\]: key: id of targetedManagedAppConfiguration
  \[TargetedManagedAppPolicyAssignmentId \<String\>\]: key: id of targetedManagedAppPolicyAssignment
  \[UserAppInstallStatusId \<String\>\]: key: id of userAppInstallStatus
  \[UserId \<String\>\]: key: id of user
  \[UserId1 \<String\>\]: key: id of user
  \[UserInstallStateSummaryId \<String\>\]: key: id of userInstallStateSummary
  \[UserPrincipalName \<String\>\]: 
  \[VppTokenId \<String\>\]: key: id of vppToken
  \[WindowsDefenderApplicationControlSupplementalPolicyAssignmentId \<String\>\]: key: id of windowsDefenderApplicationControlSupplementalPolicyAssignment
  \[WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatusId \<String\>\]: key: id of windowsDefenderApplicationControlSupplementalPolicyDeploymentStatus
  \[WindowsDefenderApplicationControlSupplementalPolicyId \<String\>\]: key: id of windowsDefenderApplicationControlSupplementalPolicy
  \[WindowsDeviceMalwareStateId \<String\>\]: key: id of windowsDeviceMalwareState
  \[WindowsInformationProtectionDeviceRegistrationId \<String\>\]: key: id of windowsInformationProtectionDeviceRegistration
  \[WindowsInformationProtectionPolicyId \<String\>\]: key: id of windowsInformationProtectionPolicy
  \[WindowsInformationProtectionWipeActionId \<String\>\]: key: id of windowsInformationProtectionWipeAction

POLICY \<IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicy\>: windowsDefenderApplicationControlSupplementalPolicy
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[Assignments \<IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicyAssignment\[\]\>\]: The associated group assignments for this WindowsDefenderApplicationControl supplemental policy.
    \[Id \<String\>\]: Read-only.
    \[Target \<IMicrosoftGraphDeviceAndAppManagementAssignmentTarget\>\]: Base type for assignment targets.
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[DeviceAndAppManagementAssignmentFilterId \<String\>\]: The Id of the filter for the target assignment.
      \[DeviceAndAppManagementAssignmentFilterType \<String\>\]: deviceAndAppManagementAssignmentFilterType
  \[Content \<Byte\[\]\>\]: The WindowsDefenderApplicationControl supplemental policy content in byte array format.
  \[ContentFileName \<String\>\]: The WindowsDefenderApplicationControl supplemental policy content's file name.
  \[CreationDateTime \<DateTime?\>\]: The date and time when the WindowsDefenderApplicationControl supplemental policy was uploaded.
  \[DeploySummary \<IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary\>\]: Contains properties for the deployment summary of a WindowsDefenderApplicationControl supplemental policy.
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Id \<String\>\]: Read-only.
    \[DeployedDeviceCount \<Int32?\>\]: Number of Devices that have successfully deployed this WindowsDefenderApplicationControl supplemental policy.
    \[FailedDeviceCount \<Int32?\>\]: Number of Devices that have failed to deploy this WindowsDefenderApplicationControl supplemental policy.
  \[Description \<String\>\]: The description of WindowsDefenderApplicationControl supplemental policy.
  \[DeviceStatuses \<IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus\[\]\>\]: The list of device deployment states for this WindowsDefenderApplicationControl supplemental policy.
    \[Id \<String\>\]: Read-only.
    \[DeploymentStatus \<String\>\]: windowsDefenderApplicationControlSupplementalPolicyStatuses
    \[DeviceId \<String\>\]: Device ID.
    \[DeviceName \<String\>\]: Device name.
    \[LastSyncDateTime \<DateTime?\>\]: Last sync date time.
    \[OSDescription \<String\>\]: Windows OS Version Description.
    \[OSVersion \<String\>\]: Windows OS Version.
    \[Policy \<IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicy\>\]: windowsDefenderApplicationControlSupplementalPolicy
    \[PolicyVersion \<String\>\]: Human readable version of the WindowsDefenderApplicationControl supplemental policy.
    \[UserName \<String\>\]: The name of the user of this device.
    \[UserPrincipalName \<String\>\]: User Principal Name.
  \[DisplayName \<String\>\]: The display name of WindowsDefenderApplicationControl supplemental policy.
  \[LastModifiedDateTime \<DateTime?\>\]: The date and time when the WindowsDefenderApplicationControl supplemental policy was last modified.
  \[RoleScopeTagIds \<String\[\]\>\]: List of Scope Tags for this WindowsDefenderApplicationControl supplemental policy entity.
  \[Version \<String\>\]: The WindowsDefenderApplicationControl supplemental policy's version.

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.corporatemanagement/update-mgdeviceappmgtwdacsupplementalpolicydevicestatuses](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.corporatemanagement/update-mgdeviceappmgtwdacsupplementalpolicydevicestatuses)

