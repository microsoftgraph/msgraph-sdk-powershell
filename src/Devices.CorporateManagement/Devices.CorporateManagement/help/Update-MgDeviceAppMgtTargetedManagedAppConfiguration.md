---
external help file: Microsoft.Graph.Devices.CorporateManagement-help.xml
Module Name: Microsoft.Graph.Devices.CorporateManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.corporatemanagement/update-mgdeviceappmgttargetedmanagedappconfiguration
schema: 2.0.0
---

# Update-MgDeviceAppMgtTargetedManagedAppConfiguration

## SYNOPSIS
Update the navigation property targetedManagedAppConfigurations in deviceAppManagement

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgDeviceAppMgtTargetedManagedAppConfiguration -TargetedManagedAppConfigurationId <String>
 [-AdditionalProperties <Hashtable>] [-Apps <IMicrosoftGraphManagedMobileApp[]>]
 [-Assignments <IMicrosoftGraphTargetedManagedAppPolicyAssignment[]>] [-CreatedDateTime <DateTime>]
 [-CustomSettings <IMicrosoftGraphKeyValuePair[]>] [-DeployedAppCount <Int32>]
 [-DeploymentSummary <IMicrosoftGraphManagedAppPolicyDeploymentSummary>] [-Description <String>]
 [-DisplayName <String>] [-Id <String>] [-IsAssigned] [-LastModifiedDateTime <DateTime>]
 [-RoleScopeTagIds <String[]>] [-Version <String>] [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Update
```
Update-MgDeviceAppMgtTargetedManagedAppConfiguration -TargetedManagedAppConfigurationId <String>
 -BodyParameter <IMicrosoftGraphTargetedManagedAppConfiguration> [-PassThru] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgDeviceAppMgtTargetedManagedAppConfiguration -InputObject <IDevicesCorporateManagementIdentity>
 [-AdditionalProperties <Hashtable>] [-Apps <IMicrosoftGraphManagedMobileApp[]>]
 [-Assignments <IMicrosoftGraphTargetedManagedAppPolicyAssignment[]>] [-CreatedDateTime <DateTime>]
 [-CustomSettings <IMicrosoftGraphKeyValuePair[]>] [-DeployedAppCount <Int32>]
 [-DeploymentSummary <IMicrosoftGraphManagedAppPolicyDeploymentSummary>] [-Description <String>]
 [-DisplayName <String>] [-Id <String>] [-IsAssigned] [-LastModifiedDateTime <DateTime>]
 [-RoleScopeTagIds <String[]>] [-Version <String>] [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgDeviceAppMgtTargetedManagedAppConfiguration -InputObject <IDevicesCorporateManagementIdentity>
 -BodyParameter <IMicrosoftGraphTargetedManagedAppConfiguration> [-PassThru] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property targetedManagedAppConfigurations in deviceAppManagement

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

### -Apps
List of apps to which the policy is deployed.
To construct, see NOTES section for APPS properties and create a hash table.

```yaml
Type: IMicrosoftGraphManagedMobileApp[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Assignments
Navigation property to list of inclusion and exclusion groups to which the policy is deployed.
To construct, see NOTES section for ASSIGNMENTS properties and create a hash table.

```yaml
Type: IMicrosoftGraphTargetedManagedAppPolicyAssignment[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
Configuration used to deliver a set of custom settings as-is to all users in the targeted security group
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphTargetedManagedAppConfiguration
Parameter Sets: Update, UpdateViaIdentity
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
Type: DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CustomSettings
A set of string key and string value pairs to be sent to apps for users to whom the configuration is scoped, unalterned by this service
To construct, see NOTES section for CUSTOMSETTINGS properties and create a hash table.

```yaml
Type: IMicrosoftGraphKeyValuePair[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeployedAppCount
Count of apps to which the current policy is deployed.

```yaml
Type: Int32
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeploymentSummary
The ManagedAppEntity is the base entity type for all other entity types under app management workflow.
To construct, see NOTES section for DEPLOYMENTSUMMARY properties and create a hash table.

```yaml
Type: IMicrosoftGraphManagedAppPolicyDeploymentSummary
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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

### -IsAssigned
Indicates if the policy is deployed to any inclusion groups or not.

```yaml
Type: SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastModifiedDateTime
Last time the policy was modified.

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

### -RoleScopeTagIds
List of Scope Tags for this Entity instance.

```yaml
Type: String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TargetedManagedAppConfigurationId
key: id of targetedManagedAppConfiguration

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

### -Version
Version of the entity.

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
### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTargetedManagedAppConfiguration
## OUTPUTS

### System.Boolean
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

APPS \<IMicrosoftGraphManagedMobileApp\[\]\>: List of apps to which the policy is deployed.
  \[Id \<String\>\]: Read-only.
  \[MobileAppIdentifier \<IMicrosoftGraphMobileAppIdentifier\>\]: The identifier for a mobile app.
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Version \<String\>\]: Version of the entity.

ASSIGNMENTS \<IMicrosoftGraphTargetedManagedAppPolicyAssignment1\[\]\>: Navigation property to list of inclusion and exclusion groups to which the policy is deployed.
  \[Id \<String\>\]: Read-only.
  \[Target \<IMicrosoftGraphDeviceAndAppManagementAssignmentTarget1\>\]: Base type for assignment targets.
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.

BODYPARAMETER \<IMicrosoftGraphTargetedManagedAppConfiguration1\>: Configuration used to deliver a set of custom settings as-is to all users in the targeted security group
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[CustomSettings \<IMicrosoftGraphKeyValuePair\[\]\>\]: A set of string key and string value pairs to be sent to apps for users to whom the configuration is scoped, unalterned by this service
    \[Name \<String\>\]: Name for this key-value pair
    \[Value \<String\>\]: Value for this key-value pair
  \[CreatedDateTime \<DateTime?\>\]: The date and time the policy was created.
  \[Description \<String\>\]: The policy's description.
  \[DisplayName \<String\>\]: Policy display name.
  \[LastModifiedDateTime \<DateTime?\>\]: Last time the policy was modified.
  \[Version \<String\>\]: Version of the entity.
  \[Id \<String\>\]: Read-only.
  \[Apps \<IMicrosoftGraphManagedMobileApp\[\]\>\]: List of apps to which the policy is deployed.
    \[Id \<String\>\]: Read-only.
    \[MobileAppIdentifier \<IMicrosoftGraphMobileAppIdentifier\>\]: The identifier for a mobile app.
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Version \<String\>\]: Version of the entity.
  \[Assignments \<IMicrosoftGraphTargetedManagedAppPolicyAssignment1\[\]\>\]: Navigation property to list of inclusion and exclusion groups to which the policy is deployed.
    \[Id \<String\>\]: Read-only.
    \[Target \<IMicrosoftGraphDeviceAndAppManagementAssignmentTarget1\>\]: Base type for assignment targets.
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[DeployedAppCount \<Int32?\>\]: Count of apps to which the current policy is deployed.
  \[DeploymentSummary \<IMicrosoftGraphManagedAppPolicyDeploymentSummary\>\]: The ManagedAppEntity is the base entity type for all other entity types under app management workflow.
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Id \<String\>\]: Read-only.
    \[ConfigurationDeployedUserCount \<Int32?\>\]: Not yet documented
    \[ConfigurationDeploymentSummaryPerApp \<IMicrosoftGraphManagedAppPolicyDeploymentSummaryPerApp\[\]\>\]: Not yet documented
      \[ConfigurationAppliedUserCount \<Int32?\>\]: Number of users the policy is applied.
      \[MobileAppIdentifier \<IMicrosoftGraphMobileAppIdentifier\>\]: The identifier for a mobile app.
    \[DisplayName \<String\>\]: Not yet documented
    \[LastRefreshTime \<DateTime?\>\]: Not yet documented
    \[Version \<String\>\]: Version of the entity.
  \[IsAssigned \<Boolean?\>\]: Indicates if the policy is deployed to any inclusion groups or not.

CUSTOMSETTINGS \<IMicrosoftGraphKeyValuePair\[\]\>: A set of string key and string value pairs to be sent to apps for users to whom the configuration is scoped, unalterned by this service
  \[Name \<String\>\]: Name for this key-value pair
  \[Value \<String\>\]: Value for this key-value pair

DEPLOYMENTSUMMARY \<IMicrosoftGraphManagedAppPolicyDeploymentSummary\>: The ManagedAppEntity is the base entity type for all other entity types under app management workflow.
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[ConfigurationDeployedUserCount \<Int32?\>\]: Not yet documented
  \[ConfigurationDeploymentSummaryPerApp \<IMicrosoftGraphManagedAppPolicyDeploymentSummaryPerApp\[\]\>\]: Not yet documented
    \[ConfigurationAppliedUserCount \<Int32?\>\]: Number of users the policy is applied.
    \[MobileAppIdentifier \<IMicrosoftGraphMobileAppIdentifier\>\]: The identifier for a mobile app.
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[DisplayName \<String\>\]: Not yet documented
  \[LastRefreshTime \<DateTime?\>\]: Not yet documented
  \[Version \<String\>\]: Version of the entity.

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

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.corporatemanagement/update-mgdeviceappmgttargetedmanagedappconfiguration](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.corporatemanagement/update-mgdeviceappmgttargetedmanagedappconfiguration)

## RELATED LINKS
