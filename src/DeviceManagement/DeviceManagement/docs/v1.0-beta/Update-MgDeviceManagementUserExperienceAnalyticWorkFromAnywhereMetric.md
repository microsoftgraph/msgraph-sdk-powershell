---
external help file:
Module Name: Microsoft.Graph.DeviceManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement/update-mgdevicemanagementuserexperienceanalyticworkfromanywheremetric
schema: 2.0.0
---

# Update-MgDeviceManagementUserExperienceAnalyticWorkFromAnywhereMetric

## SYNOPSIS
Update the navigation property userExperienceAnalyticsWorkFromAnywhereMetrics in deviceManagement

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgDeviceManagementUserExperienceAnalyticWorkFromAnywhereMetric
 -UserExperienceAnalyticsWorkFromAnywhereMetricId <String> [-AdditionalProperties <Hashtable>] [-Id <String>]
 [-MetricDevices <IMicrosoftGraphUserExperienceAnalyticsWorkFromAnywhereDevice[]>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgDeviceManagementUserExperienceAnalyticWorkFromAnywhereMetric
 -UserExperienceAnalyticsWorkFromAnywhereMetricId <String>
 -BodyParameter <IMicrosoftGraphUserExperienceAnalyticsWorkFromAnywhereMetric> [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgDeviceManagementUserExperienceAnalyticWorkFromAnywhereMetric -InputObject <IDeviceManagementIdentity>
 -BodyParameter <IMicrosoftGraphUserExperienceAnalyticsWorkFromAnywhereMetric> [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgDeviceManagementUserExperienceAnalyticWorkFromAnywhereMetric -InputObject <IDeviceManagementIdentity>
 [-AdditionalProperties <Hashtable>] [-Id <String>]
 [-MetricDevices <IMicrosoftGraphUserExperienceAnalyticsWorkFromAnywhereDevice[]>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property userExperienceAnalyticsWorkFromAnywhereMetrics in deviceManagement

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

### -BodyParameter
The user experience analytics metric for work from anywhere report
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsWorkFromAnywhereMetric
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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
Type: Microsoft.Graph.PowerShell.Models.IDeviceManagementIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -MetricDevices
The work from anywhere metric devices.
To construct, please use Get-Help -Online and see NOTES section for METRICDEVICES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsWorkFromAnywhereDevice[]
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

### -UserExperienceAnalyticsWorkFromAnywhereMetricId
key: id of userExperienceAnalyticsWorkFromAnywhereMetric

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

### Microsoft.Graph.PowerShell.Models.IDeviceManagementIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserExperienceAnalyticsWorkFromAnywhereMetric

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphUserExperienceAnalyticsWorkFromAnywhereMetric>: The user experience analytics metric for work from anywhere report
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[MetricDevices <IMicrosoftGraphUserExperienceAnalyticsWorkFromAnywhereDevice[]>]`: The work from anywhere metric devices.
    - `[Id <String>]`: 
    - `[AutoPilotProfileAssigned <Boolean?>]`: The user experience analytics work from anywhere intune device's autopilotProfileAssigned.
    - `[AutoPilotRegistered <Boolean?>]`: The user experience work from anywhere intune device's autopilotRegistered.
    - `[AzureAdDeviceId <String>]`: The user experience work from anywhere azure Ad device Id.
    - `[AzureAdJoinType <String>]`: The user experience work from anywhere device's azure Ad joinType.
    - `[AzureAdRegistered <Boolean?>]`: The user experience work from anywhere device's azureAdRegistered.
    - `[CloudIdentityScore <Double?>]`: The user experience work from anywhere per device cloud identity score. Valid values -1.79769313486232E+308 to 1.79769313486232E+308
    - `[CloudManagementScore <Double?>]`: The user experience work from anywhere per device cloud management score. Valid values -1.79769313486232E+308 to 1.79769313486232E+308
    - `[CloudProvisioningScore <Double?>]`: The user experience work from anywhere per device cloud provisioning score. Valid values -1.79769313486232E+308 to 1.79769313486232E+308
    - `[CompliancePolicySetToIntune <Boolean?>]`: The user experience work from anywhere device's compliancePolicySetToIntune.
    - `[DeviceId <String>]`: The user experience work from anywhere device Id.
    - `[DeviceName <String>]`: The work from anywhere device's name.
    - `[HealthStatus <String>]`: userExperienceAnalyticsHealthState
    - `[IsCloudManagedGatewayEnabled <Boolean?>]`: The user experience work from anywhere device's Cloud Management Gateway for Configuration Manager is enabled.
    - `[ManagedBy <String>]`: The user experience work from anywhere management agent of the device.
    - `[Manufacturer <String>]`: The user experience work from anywhere device's manufacturer.
    - `[Model <String>]`: The user experience work from anywhere device's model.
    - `[OSCheckFailed <Boolean?>]`: The user experience work from anywhere device, Is OS check failed for device to upgrade to the latest version of windows.
    - `[OSDescription <String>]`: The user experience work from anywhere device's OS Description.
    - `[OSVersion <String>]`: The user experience work from anywhere device's OS Version.
    - `[OtherWorkloadsSetToIntune <Boolean?>]`: The user experience work from anywhere device's otherWorkloadsSetToIntune.
    - `[Ownership <String>]`: The user experience work from anywhere device's ownership.
    - `[Processor64BitCheckFailed <Boolean?>]`: The user experience work from anywhere device, Is processor hardware 64-bit architecture check failed for device to upgrade to the latest version of windows.
    - `[ProcessorCoreCountCheckFailed <Boolean?>]`: The user experience work from anywhere device, Is processor hardware core count check failed for device to upgrade to the latest version of windows.
    - `[ProcessorFamilyCheckFailed <Boolean?>]`: The user experience work from anywhere device, Is processor hardware family check failed for device to upgrade to the latest version of windows.
    - `[ProcessorSpeedCheckFailed <Boolean?>]`: The user experience work from anywhere device, Is processor hardware speed check failed for device to upgrade to the latest version of windows.
    - `[RamCheckFailed <Boolean?>]`: Is the user experience analytics work from anywhere device RAM hardware check failed for device to upgrade to the latest version of windows
    - `[SecureBootCheckFailed <Boolean?>]`: The user experience work from anywhere device, Is secure boot hardware check failed for device to upgrade to the latest version of windows.
    - `[SerialNumber <String>]`: The user experience work from anywhere device's serial number.
    - `[StorageCheckFailed <Boolean?>]`: The user experience work from anywhere device, Is storage hardware check failed for device to upgrade to the latest version of windows.
    - `[TenantAttached <Boolean?>]`: The user experience work from anywhere device's tenantAttached.
    - `[TpmCheckFailed <Boolean?>]`: The user experience work from anywhere device, Is Trusted Platform Module (TPM) hardware check failed for device to the latest version of upgrade to windows.
    - `[UpgradeEligibility <OperatingSystemUpgradeEligibility?>]`: Work From Anywhere windows device upgrade eligibility status
    - `[WindowsScore <Double?>]`: The user experience work from anywhere per device windows score. Valid values -1.79769313486232E+308 to 1.79769313486232E+308
    - `[WorkFromAnywhereScore <Double?>]`: The user experience work from anywhere per device overall score. Valid values -1.79769313486232E+308 to 1.79769313486232E+308

INPUTOBJECT <IDeviceManagementIdentity>: Identity Parameter
  - `[AdvancedThreatProtectionOnboardingDeviceSettingStateId <String>]`: key: id of advancedThreatProtectionOnboardingDeviceSettingState
  - `[AndroidForWorkAppConfigurationSchemaId <String>]`: key: id of androidForWorkAppConfigurationSchema
  - `[AndroidManagedStoreAppConfigurationSchemaId <String>]`: key: id of androidManagedStoreAppConfigurationSchema
  - `[AppLogCollectionRequestId <String>]`: key: id of appLogCollectionRequest
  - `[AssignmentFilterEvaluationStatusDetailsId <String>]`: key: id of assignmentFilterEvaluationStatusDetails
  - `[DataSharingConsentId <String>]`: key: id of dataSharingConsent
  - `[DetectedAppId <String>]`: key: id of detectedApp
  - `[DeviceAndAppManagementAssignmentFilterId <String>]`: key: id of deviceAndAppManagementAssignmentFilter
  - `[DeviceCategoryId <String>]`: key: id of deviceCategory
  - `[DeviceComplianceActionItemId <String>]`: key: id of deviceComplianceActionItem
  - `[DeviceComplianceDeviceStatusId <String>]`: key: id of deviceComplianceDeviceStatus
  - `[DeviceCompliancePolicyAssignmentId <String>]`: key: id of deviceCompliancePolicyAssignment
  - `[DeviceCompliancePolicyId <String>]`: key: id of deviceCompliancePolicy
  - `[DeviceCompliancePolicySettingStateSummaryId <String>]`: key: id of deviceCompliancePolicySettingStateSummary
  - `[DeviceCompliancePolicyStateId <String>]`: key: id of deviceCompliancePolicyState
  - `[DeviceComplianceScheduledActionForRuleId <String>]`: key: id of deviceComplianceScheduledActionForRule
  - `[DeviceComplianceSettingStateId <String>]`: key: id of deviceComplianceSettingState
  - `[DeviceComplianceUserStatusId <String>]`: key: id of deviceComplianceUserStatus
  - `[DeviceConfigurationAssignmentId <String>]`: key: id of deviceConfigurationAssignment
  - `[DeviceConfigurationConflictSummaryId <String>]`: key: id of deviceConfigurationConflictSummary
  - `[DeviceConfigurationDeviceStatusId <String>]`: key: id of deviceConfigurationDeviceStatus
  - `[DeviceConfigurationGroupAssignmentId <String>]`: key: id of deviceConfigurationGroupAssignment
  - `[DeviceConfigurationId <String>]`: key: id of deviceConfiguration
  - `[DeviceConfigurationStateId <String>]`: key: id of deviceConfigurationState
  - `[DeviceConfigurationUserStatusId <String>]`: key: id of deviceConfigurationUserStatus
  - `[DeviceHealthScriptAssignmentId <String>]`: key: id of deviceHealthScriptAssignment
  - `[DeviceHealthScriptDeviceStateId <String>]`: key: id of deviceHealthScriptDeviceState
  - `[DeviceHealthScriptId <String>]`: key: id of deviceHealthScript
  - `[DeviceLogCollectionResponseId <String>]`: key: id of deviceLogCollectionResponse
  - `[DeviceManagementComplianceActionItemId <String>]`: key: id of deviceManagementComplianceActionItem
  - `[DeviceManagementCompliancePolicyId <String>]`: key: id of deviceManagementCompliancePolicy
  - `[DeviceManagementComplianceScheduledActionForRuleId <String>]`: key: id of deviceManagementComplianceScheduledActionForRule
  - `[DeviceManagementConfigurationPolicyAssignmentId <String>]`: key: id of deviceManagementConfigurationPolicyAssignment
  - `[DeviceManagementConfigurationPolicyId <String>]`: key: id of deviceManagementConfigurationPolicy
  - `[DeviceManagementConfigurationPolicyTemplateId <String>]`: key: id of deviceManagementConfigurationPolicyTemplate
  - `[DeviceManagementConfigurationSettingDefinitionId <String>]`: key: id of deviceManagementConfigurationSettingDefinition
  - `[DeviceManagementConfigurationSettingId <String>]`: key: id of deviceManagementConfigurationSetting
  - `[DeviceManagementConfigurationSettingTemplateId <String>]`: key: id of deviceManagementConfigurationSettingTemplate
  - `[DeviceManagementDerivedCredentialSettingsId <String>]`: key: id of deviceManagementDerivedCredentialSettings
  - `[DeviceManagementIntentAssignmentId <String>]`: key: id of deviceManagementIntentAssignment
  - `[DeviceManagementIntentDeviceSettingStateSummaryId <String>]`: key: id of deviceManagementIntentDeviceSettingStateSummary
  - `[DeviceManagementIntentDeviceStateId <String>]`: key: id of deviceManagementIntentDeviceState
  - `[DeviceManagementIntentId <String>]`: key: id of deviceManagementIntent
  - `[DeviceManagementIntentSettingCategoryId <String>]`: key: id of deviceManagementIntentSettingCategory
  - `[DeviceManagementIntentUserStateId <String>]`: key: id of deviceManagementIntentUserState
  - `[DeviceManagementResourceAccessProfileAssignmentId <String>]`: key: id of deviceManagementResourceAccessProfileAssignment
  - `[DeviceManagementResourceAccessProfileBaseId <String>]`: key: id of deviceManagementResourceAccessProfileBase
  - `[DeviceManagementScriptAssignmentId <String>]`: key: id of deviceManagementScriptAssignment
  - `[DeviceManagementScriptDeviceStateId <String>]`: key: id of deviceManagementScriptDeviceState
  - `[DeviceManagementScriptGroupAssignmentId <String>]`: key: id of deviceManagementScriptGroupAssignment
  - `[DeviceManagementScriptId <String>]`: key: id of deviceManagementScript
  - `[DeviceManagementScriptUserStateId <String>]`: key: id of deviceManagementScriptUserState
  - `[DeviceManagementSettingCategoryId <String>]`: key: id of deviceManagementSettingCategory
  - `[DeviceManagementSettingDefinitionId <String>]`: key: id of deviceManagementSettingDefinition
  - `[DeviceManagementSettingInstanceId <String>]`: key: id of deviceManagementSettingInstance
  - `[DeviceManagementTemplateId <String>]`: key: id of deviceManagementTemplate
  - `[DeviceManagementTemplateId1 <String>]`: key: id of deviceManagementTemplate
  - `[DeviceManagementTemplateSettingCategoryId <String>]`: key: id of deviceManagementTemplateSettingCategory
  - `[DeviceManagementTroubleshootingEventId <String>]`: key: id of deviceManagementTroubleshootingEvent
  - `[DeviceShellScriptId <String>]`: key: id of deviceShellScript
  - `[EmbeddedSimActivationCodePoolAssignmentId <String>]`: key: id of embeddedSIMActivationCodePoolAssignment
  - `[EmbeddedSimActivationCodePoolId <String>]`: key: id of embeddedSIMActivationCodePool
  - `[EmbeddedSimDeviceStateId <String>]`: key: id of embeddedSIMDeviceState
  - `[GroupPolicyConfigurationAssignmentId <String>]`: key: id of groupPolicyConfigurationAssignment
  - `[GroupPolicyConfigurationId <String>]`: key: id of groupPolicyConfiguration
  - `[GroupPolicyDefinitionValueId <String>]`: key: id of groupPolicyDefinitionValue
  - `[GroupPolicyPresentationValueId <String>]`: key: id of groupPolicyPresentationValue
  - `[LocalizedNotificationMessageId <String>]`: key: id of localizedNotificationMessage
  - `[MacOSSoftwareUpdateAccountSummaryId <String>]`: key: id of macOSSoftwareUpdateAccountSummary
  - `[MacOSSoftwareUpdateCategorySummaryId <String>]`: key: id of macOSSoftwareUpdateCategorySummary
  - `[MacOSSoftwareUpdateStateSummaryId <String>]`: key: id of macOSSoftwareUpdateStateSummary
  - `[MalwareStateForWindowsDeviceId <String>]`: key: id of malwareStateForWindowsDevice
  - `[ManagedDeviceEncryptionStateId <String>]`: key: id of managedDeviceEncryptionState
  - `[ManagedDeviceId <String>]`: key: id of managedDevice
  - `[ManagedDeviceMobileAppConfigurationStateId <String>]`: key: id of managedDeviceMobileAppConfigurationState
  - `[MicrosoftTunnelConfigurationId <String>]`: key: id of microsoftTunnelConfiguration
  - `[MicrosoftTunnelHealthThresholdId <String>]`: key: id of microsoftTunnelHealthThreshold
  - `[MicrosoftTunnelServerId <String>]`: key: id of microsoftTunnelServer
  - `[MicrosoftTunnelServerLogCollectionResponseId <String>]`: key: id of microsoftTunnelServerLogCollectionResponse
  - `[MicrosoftTunnelSiteId <String>]`: key: id of microsoftTunnelSite
  - `[MobileAppTroubleshootingEventId <String>]`: key: id of mobileAppTroubleshootingEvent
  - `[NotificationMessageTemplateId <String>]`: key: id of notificationMessageTemplate
  - `[RemoteActionAuditId <String>]`: key: id of remoteActionAudit
  - `[SecurityBaselineSettingStateId <String>]`: key: id of securityBaselineSettingState
  - `[SecurityBaselineStateId <String>]`: key: id of securityBaselineState
  - `[SettingStateDeviceSummaryId <String>]`: key: id of settingStateDeviceSummary
  - `[UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDetailsId <String>]`: key: id of userExperienceAnalyticsAppHealthAppPerformanceByAppVersionDetails
  - `[UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId <String>]`: key: id of userExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId
  - `[UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionId <String>]`: key: id of userExperienceAnalyticsAppHealthAppPerformanceByAppVersion
  - `[UserExperienceAnalyticsAppHealthAppPerformanceByOSVersionId <String>]`: key: id of userExperienceAnalyticsAppHealthAppPerformanceByOSVersion
  - `[UserExperienceAnalyticsAppHealthApplicationPerformanceId <String>]`: key: id of userExperienceAnalyticsAppHealthApplicationPerformance
  - `[UserExperienceAnalyticsAppHealthDeviceModelPerformanceId <String>]`: key: id of userExperienceAnalyticsAppHealthDeviceModelPerformance
  - `[UserExperienceAnalyticsAppHealthDevicePerformanceDetailsId <String>]`: key: id of userExperienceAnalyticsAppHealthDevicePerformanceDetails
  - `[UserExperienceAnalyticsAppHealthDevicePerformanceId <String>]`: key: id of userExperienceAnalyticsAppHealthDevicePerformance
  - `[UserExperienceAnalyticsAppHealthOSVersionPerformanceId <String>]`: key: id of userExperienceAnalyticsAppHealthOSVersionPerformance
  - `[UserExperienceAnalyticsBaselineId <String>]`: key: id of userExperienceAnalyticsBaseline
  - `[UserExperienceAnalyticsBatteryHealthAppImpactId <String>]`: key: id of userExperienceAnalyticsBatteryHealthAppImpact
  - `[UserExperienceAnalyticsBatteryHealthDeviceAppImpactId <String>]`: key: id of userExperienceAnalyticsBatteryHealthDeviceAppImpact
  - `[UserExperienceAnalyticsBatteryHealthDevicePerformanceId <String>]`: key: id of userExperienceAnalyticsBatteryHealthDevicePerformance
  - `[UserExperienceAnalyticsBatteryHealthDeviceRuntimeHistoryId <String>]`: key: id of userExperienceAnalyticsBatteryHealthDeviceRuntimeHistory
  - `[UserExperienceAnalyticsBatteryHealthModelPerformanceId <String>]`: key: id of userExperienceAnalyticsBatteryHealthModelPerformance
  - `[UserExperienceAnalyticsBatteryHealthOSPerformanceId <String>]`: key: id of userExperienceAnalyticsBatteryHealthOsPerformance
  - `[UserExperienceAnalyticsCategoryId <String>]`: key: id of userExperienceAnalyticsCategory
  - `[UserExperienceAnalyticsDevicePerformanceId <String>]`: key: id of userExperienceAnalyticsDevicePerformance
  - `[UserExperienceAnalyticsDeviceScopeId <String>]`: key: id of userExperienceAnalyticsDeviceScope
  - `[UserExperienceAnalyticsDeviceScoresId <String>]`: key: id of userExperienceAnalyticsDeviceScores
  - `[UserExperienceAnalyticsDeviceStartupHistoryId <String>]`: key: id of userExperienceAnalyticsDeviceStartupHistory
  - `[UserExperienceAnalyticsDeviceStartupProcessId <String>]`: key: id of userExperienceAnalyticsDeviceStartupProcess
  - `[UserExperienceAnalyticsDeviceStartupProcessPerformanceId <String>]`: key: id of userExperienceAnalyticsDeviceStartupProcessPerformance
  - `[UserExperienceAnalyticsDeviceWithoutCloudIdentityId <String>]`: key: id of userExperienceAnalyticsDeviceWithoutCloudIdentity
  - `[UserExperienceAnalyticsImpactingProcessId <String>]`: key: id of userExperienceAnalyticsImpactingProcess
  - `[UserExperienceAnalyticsMetricHistoryId <String>]`: key: id of userExperienceAnalyticsMetricHistory
  - `[UserExperienceAnalyticsMetricId <String>]`: key: id of userExperienceAnalyticsMetric
  - `[UserExperienceAnalyticsModelScoresId <String>]`: key: id of userExperienceAnalyticsModelScores
  - `[UserExperienceAnalyticsNotAutopilotReadyDeviceId <String>]`: key: id of userExperienceAnalyticsNotAutopilotReadyDevice
  - `[UserExperienceAnalyticsRemoteConnectionId <String>]`: key: id of userExperienceAnalyticsRemoteConnection
  - `[UserExperienceAnalyticsResourcePerformanceId <String>]`: key: id of userExperienceAnalyticsResourcePerformance
  - `[UserExperienceAnalyticsScoreHistoryId <String>]`: key: id of userExperienceAnalyticsScoreHistory
  - `[UserExperienceAnalyticsWorkFromAnywhereDeviceId <String>]`: key: id of userExperienceAnalyticsWorkFromAnywhereDevice
  - `[UserExperienceAnalyticsWorkFromAnywhereMetricId <String>]`: key: id of userExperienceAnalyticsWorkFromAnywhereMetric
  - `[UserExperienceAnalyticsWorkFromAnywhereModelPerformanceId <String>]`: key: id of userExperienceAnalyticsWorkFromAnywhereModelPerformance
  - `[WindowsDeviceMalwareStateId <String>]`: key: id of windowsDeviceMalwareState
  - `[WindowsInformationProtectionAppLearningSummaryId <String>]`: key: id of windowsInformationProtectionAppLearningSummary
  - `[WindowsInformationProtectionNetworkLearningSummaryId <String>]`: key: id of windowsInformationProtectionNetworkLearningSummary
  - `[WindowsMalwareInformationId <String>]`: key: id of windowsMalwareInformation

METRICDEVICES <IMicrosoftGraphUserExperienceAnalyticsWorkFromAnywhereDevice[]>: The work from anywhere metric devices.
  - `[Id <String>]`: 
  - `[AutoPilotProfileAssigned <Boolean?>]`: The user experience analytics work from anywhere intune device's autopilotProfileAssigned.
  - `[AutoPilotRegistered <Boolean?>]`: The user experience work from anywhere intune device's autopilotRegistered.
  - `[AzureAdDeviceId <String>]`: The user experience work from anywhere azure Ad device Id.
  - `[AzureAdJoinType <String>]`: The user experience work from anywhere device's azure Ad joinType.
  - `[AzureAdRegistered <Boolean?>]`: The user experience work from anywhere device's azureAdRegistered.
  - `[CloudIdentityScore <Double?>]`: The user experience work from anywhere per device cloud identity score. Valid values -1.79769313486232E+308 to 1.79769313486232E+308
  - `[CloudManagementScore <Double?>]`: The user experience work from anywhere per device cloud management score. Valid values -1.79769313486232E+308 to 1.79769313486232E+308
  - `[CloudProvisioningScore <Double?>]`: The user experience work from anywhere per device cloud provisioning score. Valid values -1.79769313486232E+308 to 1.79769313486232E+308
  - `[CompliancePolicySetToIntune <Boolean?>]`: The user experience work from anywhere device's compliancePolicySetToIntune.
  - `[DeviceId <String>]`: The user experience work from anywhere device Id.
  - `[DeviceName <String>]`: The work from anywhere device's name.
  - `[HealthStatus <String>]`: userExperienceAnalyticsHealthState
  - `[IsCloudManagedGatewayEnabled <Boolean?>]`: The user experience work from anywhere device's Cloud Management Gateway for Configuration Manager is enabled.
  - `[ManagedBy <String>]`: The user experience work from anywhere management agent of the device.
  - `[Manufacturer <String>]`: The user experience work from anywhere device's manufacturer.
  - `[Model <String>]`: The user experience work from anywhere device's model.
  - `[OSCheckFailed <Boolean?>]`: The user experience work from anywhere device, Is OS check failed for device to upgrade to the latest version of windows.
  - `[OSDescription <String>]`: The user experience work from anywhere device's OS Description.
  - `[OSVersion <String>]`: The user experience work from anywhere device's OS Version.
  - `[OtherWorkloadsSetToIntune <Boolean?>]`: The user experience work from anywhere device's otherWorkloadsSetToIntune.
  - `[Ownership <String>]`: The user experience work from anywhere device's ownership.
  - `[Processor64BitCheckFailed <Boolean?>]`: The user experience work from anywhere device, Is processor hardware 64-bit architecture check failed for device to upgrade to the latest version of windows.
  - `[ProcessorCoreCountCheckFailed <Boolean?>]`: The user experience work from anywhere device, Is processor hardware core count check failed for device to upgrade to the latest version of windows.
  - `[ProcessorFamilyCheckFailed <Boolean?>]`: The user experience work from anywhere device, Is processor hardware family check failed for device to upgrade to the latest version of windows.
  - `[ProcessorSpeedCheckFailed <Boolean?>]`: The user experience work from anywhere device, Is processor hardware speed check failed for device to upgrade to the latest version of windows.
  - `[RamCheckFailed <Boolean?>]`: Is the user experience analytics work from anywhere device RAM hardware check failed for device to upgrade to the latest version of windows
  - `[SecureBootCheckFailed <Boolean?>]`: The user experience work from anywhere device, Is secure boot hardware check failed for device to upgrade to the latest version of windows.
  - `[SerialNumber <String>]`: The user experience work from anywhere device's serial number.
  - `[StorageCheckFailed <Boolean?>]`: The user experience work from anywhere device, Is storage hardware check failed for device to upgrade to the latest version of windows.
  - `[TenantAttached <Boolean?>]`: The user experience work from anywhere device's tenantAttached.
  - `[TpmCheckFailed <Boolean?>]`: The user experience work from anywhere device, Is Trusted Platform Module (TPM) hardware check failed for device to the latest version of upgrade to windows.
  - `[UpgradeEligibility <OperatingSystemUpgradeEligibility?>]`: Work From Anywhere windows device upgrade eligibility status
  - `[WindowsScore <Double?>]`: The user experience work from anywhere per device windows score. Valid values -1.79769313486232E+308 to 1.79769313486232E+308
  - `[WorkFromAnywhereScore <Double?>]`: The user experience work from anywhere per device overall score. Valid values -1.79769313486232E+308 to 1.79769313486232E+308

## RELATED LINKS

