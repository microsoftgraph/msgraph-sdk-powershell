---
external help file:
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
 [-AdditionalProperties <Hashtable>] [-AppGroupType <TargetedManagedAppGroupType>]
 [-Apps <IMicrosoftGraphManagedMobileApp[]>]
 [-Assignments <IMicrosoftGraphTargetedManagedAppPolicyAssignment1[]>] [-CreatedDateTime <DateTime>]
 [-CustomSettings <IMicrosoftGraphKeyValuePair[]>] [-DeployedAppCount <Int32>]
 [-DeploymentSummary <IMicrosoftGraphManagedAppPolicyDeploymentSummary>] [-Description <String>]
 [-DisplayName <String>] [-Id <String>] [-IsAssigned] [-LastModifiedDateTime <DateTime>]
 [-RoleScopeTagIds <String[]>] [-Settings <IMicrosoftGraphDeviceManagementConfigurationSetting[]>]
 [-TargetedAppManagementLevels <AppManagementLevel>] [-Version <String>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgDeviceAppMgtTargetedManagedAppConfiguration -TargetedManagedAppConfigurationId <String>
 -BodyParameter <IMicrosoftGraphTargetedManagedAppConfiguration1> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgDeviceAppMgtTargetedManagedAppConfiguration -InputObject <IDevicesCorporateManagementIdentity>
 -BodyParameter <IMicrosoftGraphTargetedManagedAppConfiguration1> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgDeviceAppMgtTargetedManagedAppConfiguration -InputObject <IDevicesCorporateManagementIdentity>
 [-AdditionalProperties <Hashtable>] [-AppGroupType <TargetedManagedAppGroupType>]
 [-Apps <IMicrosoftGraphManagedMobileApp[]>]
 [-Assignments <IMicrosoftGraphTargetedManagedAppPolicyAssignment1[]>] [-CreatedDateTime <DateTime>]
 [-CustomSettings <IMicrosoftGraphKeyValuePair[]>] [-DeployedAppCount <Int32>]
 [-DeploymentSummary <IMicrosoftGraphManagedAppPolicyDeploymentSummary>] [-Description <String>]
 [-DisplayName <String>] [-Id <String>] [-IsAssigned] [-LastModifiedDateTime <DateTime>]
 [-RoleScopeTagIds <String[]>] [-Settings <IMicrosoftGraphDeviceManagementConfigurationSetting[]>]
 [-TargetedAppManagementLevels <AppManagementLevel>] [-Version <String>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property targetedManagedAppConfigurations in deviceAppManagement

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

### -AppGroupType
Indicates a collection of apps to target which can be one of several pre-defined lists of apps or a manually selected list of apps

```yaml
Type: Microsoft.Graph.PowerShell.Support.TargetedManagedAppGroupType
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
To construct, please use Get-Help -Online and see NOTES section for APPS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedMobileApp[]
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
To construct, please use Get-Help -Online and see NOTES section for ASSIGNMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTargetedManagedAppPolicyAssignment1[]
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
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTargetedManagedAppConfiguration1
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
Type: System.DateTime
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
To construct, please use Get-Help -Online and see NOTES section for CUSTOMSETTINGS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphKeyValuePair[]
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
Type: System.Int32
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeploymentSummary
The ManagedAppEntity is the base entity type for all other entity types under app management workflow.
To construct, please use Get-Help -Online and see NOTES section for DEPLOYMENTSUMMARY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedAppPolicyDeploymentSummary
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
Policy display name.

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

### -IsAssigned
Indicates if the policy is deployed to any inclusion groups or not.

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

### -LastModifiedDateTime
Last time the policy was modified.

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

### -RoleScopeTagIds
List of Scope Tags for this Entity instance.

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

### -Settings
List of settings contained in this App Configuration policy
To construct, please use Get-Help -Online and see NOTES section for SETTINGS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementConfigurationSetting[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TargetedAppManagementLevels
Management levels for apps

```yaml
Type: Microsoft.Graph.PowerShell.Support.AppManagementLevel
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TargetedManagedAppConfigurationId
The unique identifier of targetedManagedAppConfiguration

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

### -Version
Version of the entity.

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTargetedManagedAppConfiguration1

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

### Update-MgDeviceAppManagementTargetedManagedAppConfiguration

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


APPS <IMicrosoftGraphManagedMobileApp[]>: List of apps to which the policy is deployed.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[MobileAppIdentifier <IMicrosoftGraphMobileAppIdentifier>]`: The identifier for a mobile app.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Version <String>]`: Version of the entity.

ASSIGNMENTS <IMicrosoftGraphTargetedManagedAppPolicyAssignment1[]>: Navigation property to list of inclusion and exclusion groups to which the policy is deployed.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Source <DeviceAndAppManagementAssignmentSource?>]`: Represents source of assignment.
  - `[SourceId <String>]`: Identifier for resource used for deployment to a group
  - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget1>]`: Base type for assignment targets.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
    - `[DeviceAndAppManagementAssignmentFilterType <DeviceAndAppManagementAssignmentFilterType?>]`: Represents type of the assignment filter.

BODYPARAMETER <IMicrosoftGraphTargetedManagedAppConfiguration1>: Configuration used to deliver a set of custom settings as-is to all users in the targeted security group
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CustomSettings <IMicrosoftGraphKeyValuePair[]>]`: A set of string key and string value pairs to be sent to apps for users to whom the configuration is scoped, unalterned by this service
    - `[Name <String>]`: Name for this key-value pair
    - `[Value <String>]`: Value for this key-value pair
  - `[Settings <IMicrosoftGraphDeviceManagementConfigurationSetting[]>]`: List of settings contained in this App Configuration policy
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[SettingDefinitions <IMicrosoftGraphDeviceManagementConfigurationSettingDefinition[]>]`: List of related Setting Definitions. This property is read-only.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[AccessTypes <String>]`: deviceManagementConfigurationSettingAccessTypes
      - `[Applicability <IMicrosoftGraphDeviceManagementConfigurationSettingApplicability>]`: deviceManagementConfigurationSettingApplicability
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Description <String>]`: description of the setting
        - `[DeviceMode <DeviceManagementConfigurationDeviceMode?>]`: Describes applicability for the mode the device is in
        - `[Platform <DeviceManagementConfigurationPlatforms?>]`: Supported platform types.
        - `[Technologies <DeviceManagementConfigurationTechnologies?>]`: Describes which technology this setting can be deployed with
      - `[BaseUri <String>]`: Base CSP Path
      - `[CategoryId <String>]`: Specifies the area group under which the setting is configured in a specified configuration service provider (CSP)
      - `[Description <String>]`: Description of the item
      - `[DisplayName <String>]`: Display name of the item
      - `[HelpText <String>]`: Help text of the item
      - `[InfoUrls <String[]>]`: List of links more info for the setting can be found at
      - `[Keywords <String[]>]`: Tokens which to search settings on
      - `[Name <String>]`: Name of the item
      - `[Occurrence <IMicrosoftGraphDeviceManagementConfigurationSettingOccurrence>]`: deviceManagementConfigurationSettingOccurrence
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[MaxDeviceOccurrence <Int32?>]`: Maximum times setting can be set on device.
        - `[MinDeviceOccurrence <Int32?>]`: Minimum times setting can be set on device. A MinDeviceOccurrence of 0 means setting is optional
      - `[OffsetUri <String>]`: Offset CSP Path from Base
      - `[ReferredSettingInformationList <IMicrosoftGraphDeviceManagementConfigurationReferredSettingInformation[]>]`: List of referred setting information.
        - `[SettingDefinitionId <String>]`: Setting definition id that is being referred to a setting. Applicable for reusable setting
      - `[RootDefinitionId <String>]`: Root setting definition if the setting is a child setting.
      - `[SettingUsage <DeviceManagementConfigurationSettingUsage?>]`: Supported setting types
      - `[UxBehavior <DeviceManagementConfigurationControlType?>]`: Setting control type representation in the UX
      - `[Version <String>]`: Item Version
      - `[Visibility <DeviceManagementConfigurationSettingVisibility?>]`: Supported setting types
    - `[SettingInstance <IMicrosoftGraphDeviceManagementConfigurationSettingInstance>]`: Setting instance within policy
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[SettingDefinitionId <String>]`: Setting Definition Id
      - `[SettingInstanceTemplateReference <IMicrosoftGraphDeviceManagementConfigurationSettingInstanceTemplateReference>]`: Setting instance template reference information
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[SettingInstanceTemplateId <String>]`: Setting instance template id
  - `[CreatedDateTime <DateTime?>]`: The date and time the policy was created.
  - `[Description <String>]`: The policy's description.
  - `[DisplayName <String>]`: Policy display name.
  - `[LastModifiedDateTime <DateTime?>]`: Last time the policy was modified.
  - `[RoleScopeTagIds <String[]>]`: List of Scope Tags for this Entity instance.
  - `[Version <String>]`: Version of the entity.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[AppGroupType <TargetedManagedAppGroupType?>]`: Indicates a collection of apps to target which can be one of several pre-defined lists of apps or a manually selected list of apps
  - `[Apps <IMicrosoftGraphManagedMobileApp[]>]`: List of apps to which the policy is deployed.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[MobileAppIdentifier <IMicrosoftGraphMobileAppIdentifier>]`: The identifier for a mobile app.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Version <String>]`: Version of the entity.
  - `[Assignments <IMicrosoftGraphTargetedManagedAppPolicyAssignment1[]>]`: Navigation property to list of inclusion and exclusion groups to which the policy is deployed.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Source <DeviceAndAppManagementAssignmentSource?>]`: Represents source of assignment.
    - `[SourceId <String>]`: Identifier for resource used for deployment to a group
    - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget1>]`: Base type for assignment targets.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
      - `[DeviceAndAppManagementAssignmentFilterType <DeviceAndAppManagementAssignmentFilterType?>]`: Represents type of the assignment filter.
  - `[DeployedAppCount <Int32?>]`: Count of apps to which the current policy is deployed.
  - `[DeploymentSummary <IMicrosoftGraphManagedAppPolicyDeploymentSummary>]`: The ManagedAppEntity is the base entity type for all other entity types under app management workflow.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[ConfigurationDeployedUserCount <Int32?>]`: Not yet documented
    - `[ConfigurationDeploymentSummaryPerApp <IMicrosoftGraphManagedAppPolicyDeploymentSummaryPerApp[]>]`: Not yet documented
      - `[ConfigurationAppliedUserCount <Int32?>]`: Number of users the policy is applied.
      - `[MobileAppIdentifier <IMicrosoftGraphMobileAppIdentifier>]`: The identifier for a mobile app.
    - `[DisplayName <String>]`: Not yet documented
    - `[LastRefreshTime <DateTime?>]`: Not yet documented
    - `[Version <String>]`: Version of the entity.
  - `[IsAssigned <Boolean?>]`: Indicates if the policy is deployed to any inclusion groups or not.
  - `[TargetedAppManagementLevels <AppManagementLevel?>]`: Management levels for apps

CUSTOMSETTINGS <IMicrosoftGraphKeyValuePair[]>: A set of string key and string value pairs to be sent to apps for users to whom the configuration is scoped, unalterned by this service
  - `[Name <String>]`: Name for this key-value pair
  - `[Value <String>]`: Value for this key-value pair

DEPLOYMENTSUMMARY <IMicrosoftGraphManagedAppPolicyDeploymentSummary>: The ManagedAppEntity is the base entity type for all other entity types under app management workflow.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[ConfigurationDeployedUserCount <Int32?>]`: Not yet documented
  - `[ConfigurationDeploymentSummaryPerApp <IMicrosoftGraphManagedAppPolicyDeploymentSummaryPerApp[]>]`: Not yet documented
    - `[ConfigurationAppliedUserCount <Int32?>]`: Number of users the policy is applied.
    - `[MobileAppIdentifier <IMicrosoftGraphMobileAppIdentifier>]`: The identifier for a mobile app.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DisplayName <String>]`: Not yet documented
  - `[LastRefreshTime <DateTime?>]`: Not yet documented
  - `[Version <String>]`: Version of the entity.

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

SETTINGS <IMicrosoftGraphDeviceManagementConfigurationSetting[]>: List of settings contained in this App Configuration policy
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[SettingDefinitions <IMicrosoftGraphDeviceManagementConfigurationSettingDefinition[]>]`: List of related Setting Definitions. This property is read-only.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[AccessTypes <String>]`: deviceManagementConfigurationSettingAccessTypes
    - `[Applicability <IMicrosoftGraphDeviceManagementConfigurationSettingApplicability>]`: deviceManagementConfigurationSettingApplicability
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Description <String>]`: description of the setting
      - `[DeviceMode <DeviceManagementConfigurationDeviceMode?>]`: Describes applicability for the mode the device is in
      - `[Platform <DeviceManagementConfigurationPlatforms?>]`: Supported platform types.
      - `[Technologies <DeviceManagementConfigurationTechnologies?>]`: Describes which technology this setting can be deployed with
    - `[BaseUri <String>]`: Base CSP Path
    - `[CategoryId <String>]`: Specifies the area group under which the setting is configured in a specified configuration service provider (CSP)
    - `[Description <String>]`: Description of the item
    - `[DisplayName <String>]`: Display name of the item
    - `[HelpText <String>]`: Help text of the item
    - `[InfoUrls <String[]>]`: List of links more info for the setting can be found at
    - `[Keywords <String[]>]`: Tokens which to search settings on
    - `[Name <String>]`: Name of the item
    - `[Occurrence <IMicrosoftGraphDeviceManagementConfigurationSettingOccurrence>]`: deviceManagementConfigurationSettingOccurrence
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[MaxDeviceOccurrence <Int32?>]`: Maximum times setting can be set on device.
      - `[MinDeviceOccurrence <Int32?>]`: Minimum times setting can be set on device. A MinDeviceOccurrence of 0 means setting is optional
    - `[OffsetUri <String>]`: Offset CSP Path from Base
    - `[ReferredSettingInformationList <IMicrosoftGraphDeviceManagementConfigurationReferredSettingInformation[]>]`: List of referred setting information.
      - `[SettingDefinitionId <String>]`: Setting definition id that is being referred to a setting. Applicable for reusable setting
    - `[RootDefinitionId <String>]`: Root setting definition if the setting is a child setting.
    - `[SettingUsage <DeviceManagementConfigurationSettingUsage?>]`: Supported setting types
    - `[UxBehavior <DeviceManagementConfigurationControlType?>]`: Setting control type representation in the UX
    - `[Version <String>]`: Item Version
    - `[Visibility <DeviceManagementConfigurationSettingVisibility?>]`: Supported setting types
  - `[SettingInstance <IMicrosoftGraphDeviceManagementConfigurationSettingInstance>]`: Setting instance within policy
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[SettingDefinitionId <String>]`: Setting Definition Id
    - `[SettingInstanceTemplateReference <IMicrosoftGraphDeviceManagementConfigurationSettingInstanceTemplateReference>]`: Setting instance template reference information
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[SettingInstanceTemplateId <String>]`: Setting instance template id

## RELATED LINKS

