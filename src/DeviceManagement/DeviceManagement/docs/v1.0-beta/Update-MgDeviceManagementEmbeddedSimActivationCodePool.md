---
external help file: Microsoft.Graph.DeviceManagement-help.xml
Module Name: Microsoft.Graph.DeviceManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement/update-mgdevicemanagementembeddedsimactivationcodepool
schema: 2.0.0
---

# Update-MgDeviceManagementEmbeddedSimActivationCodePool

## SYNOPSIS
The embedded SIM activation code pools created by this account.

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgDeviceManagementEmbeddedSimActivationCodePool -EmbeddedSimActivationCodePoolId <String>
 [-ActivationCodeCount <Int32>] [-ActivationCodes <IMicrosoftGraphEmbeddedSimActivationCode[]>]
 [-AdditionalProperties <Hashtable>] [-Assignments <IMicrosoftGraphEmbeddedSimActivationCodePoolAssignment[]>]
 [-CreatedDateTime <DateTime>] [-DeviceStates <IMicrosoftGraphEmbeddedSimDeviceState[]>]
 [-DisplayName <String>] [-Id <String>] [-ModifiedDateTime <DateTime>] [-PassThru] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### Update
```
Update-MgDeviceManagementEmbeddedSimActivationCodePool -EmbeddedSimActivationCodePoolId <String>
 -BodyParameter <IMicrosoftGraphEmbeddedSimActivationCodePool> [-PassThru] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgDeviceManagementEmbeddedSimActivationCodePool -InputObject <IDeviceManagementIdentity>
 [-ActivationCodeCount <Int32>] [-ActivationCodes <IMicrosoftGraphEmbeddedSimActivationCode[]>]
 [-AdditionalProperties <Hashtable>] [-Assignments <IMicrosoftGraphEmbeddedSimActivationCodePoolAssignment[]>]
 [-CreatedDateTime <DateTime>] [-DeviceStates <IMicrosoftGraphEmbeddedSimDeviceState[]>]
 [-DisplayName <String>] [-Id <String>] [-ModifiedDateTime <DateTime>] [-PassThru] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgDeviceManagementEmbeddedSimActivationCodePool -InputObject <IDeviceManagementIdentity>
 -BodyParameter <IMicrosoftGraphEmbeddedSimActivationCodePool> [-PassThru] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

## DESCRIPTION
The embedded SIM activation code pools created by this account.

## EXAMPLES

## PARAMETERS

### -ActivationCodeCount
The total count of activation codes which belong to this pool.

```yaml
Type: Int32
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ActivationCodes
The activation codes which belong to this pool.
This navigation property is used to post activation codes to Intune but cannot be used to read activation codes from Intune.
To construct, see NOTES section for ACTIVATIONCODES properties and create a hash table.

```yaml
Type: IMicrosoftGraphEmbeddedSimActivationCode[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

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

### -Assignments
Navigational property to a list of targets to which this pool is assigned.
To construct, see NOTES section for ASSIGNMENTS properties and create a hash table.

```yaml
Type: IMicrosoftGraphEmbeddedSimActivationCodePoolAssignment[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
A pool represents a group of embedded SIM activation codes.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphEmbeddedSimActivationCodePool
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedDateTime
The time the embedded SIM activation code pool was created.
Generated service side.

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

### -DeviceStates
Navigational property to a list of device states for this pool.
To construct, see NOTES section for DEVICESTATES properties and create a hash table.

```yaml
Type: IMicrosoftGraphEmbeddedSimDeviceState[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
The admin defined name of the embedded SIM activation code pool.

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

### -EmbeddedSimActivationCodePoolId
key: id of embeddedSIMActivationCodePool

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
Type: IDeviceManagementIdentity
Parameter Sets: UpdateViaIdentityExpanded, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ModifiedDateTime
The time the embedded SIM activation code pool was last modified.
Updated service side.

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

### Microsoft.Graph.PowerShell.Models.IDeviceManagementIdentity
### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEmbeddedSimActivationCodePool
## OUTPUTS

### System.Boolean
## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ACTIVATIONCODES <IMicrosoftGraphEmbeddedSimActivationCode[]>: The activation codes which belong to this pool. This navigation property is used to post activation codes to Intune but cannot be used to read activation codes from Intune.
  - `[IntegratedCircuitCardIdentifier <String>]`: The Integrated Circuit Card Identifier (ICCID) for this embedded SIM activation code as provided by the mobile operator.
  - `[MatchingIdentifier <String>]`: The MatchingIdentifier (MatchingID) as specified in the GSMA Association SGP.22 RSP Technical Specification section 4.1.
  - `[SmdpPlusServerAddress <String>]`: The fully qualified domain name of the SM-DP+ server as specified in the GSM Association SPG .22 RSP Technical Specification.

ASSIGNMENTS <IMicrosoftGraphEmbeddedSimActivationCodePoolAssignment[]>: Navigational property to a list of targets to which this pool is assigned.
  - `[Id <String>]`: Read-only.
  - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget1>]`: Base type for assignment targets.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
    - `[DeviceAndAppManagementAssignmentFilterType <String>]`: deviceAndAppManagementAssignmentFilterType

BODYPARAMETER <IMicrosoftGraphEmbeddedSimActivationCodePool>: A pool represents a group of embedded SIM activation codes.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[ActivationCodeCount <Int32?>]`: The total count of activation codes which belong to this pool.
  - `[ActivationCodes <IMicrosoftGraphEmbeddedSimActivationCode[]>]`: The activation codes which belong to this pool. This navigation property is used to post activation codes to Intune but cannot be used to read activation codes from Intune.
    - `[IntegratedCircuitCardIdentifier <String>]`: The Integrated Circuit Card Identifier (ICCID) for this embedded SIM activation code as provided by the mobile operator.
    - `[MatchingIdentifier <String>]`: The MatchingIdentifier (MatchingID) as specified in the GSMA Association SGP.22 RSP Technical Specification section 4.1.
    - `[SmdpPlusServerAddress <String>]`: The fully qualified domain name of the SM-DP+ server as specified in the GSM Association SPG .22 RSP Technical Specification.
  - `[Assignments <IMicrosoftGraphEmbeddedSimActivationCodePoolAssignment[]>]`: Navigational property to a list of targets to which this pool is assigned.
    - `[Id <String>]`: Read-only.
    - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget1>]`: Base type for assignment targets.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
      - `[DeviceAndAppManagementAssignmentFilterType <String>]`: deviceAndAppManagementAssignmentFilterType
  - `[CreatedDateTime <DateTime?>]`: The time the embedded SIM activation code pool was created. Generated service side.
  - `[DeviceStates <IMicrosoftGraphEmbeddedSimDeviceState[]>]`: Navigational property to a list of device states for this pool.
    - `[Id <String>]`: Read-only.
    - `[CreatedDateTime <DateTime?>]`: The time the embedded SIM device status was created. Generated service side.
    - `[DeviceName <String>]`: Device name to which the subscription was provisioned e.g. DESKTOP-JOE
    - `[LastSyncDateTime <DateTime?>]`: The time the embedded SIM device last checked in. Updated service side.
    - `[ModifiedDateTime <DateTime?>]`: The time the embedded SIM device status was last modified. Updated service side.
    - `[State <String>]`: embeddedSIMDeviceStateValue
    - `[StateDetails <String>]`: String description of the provisioning state.
    - `[UniversalIntegratedCircuitCardIdentifier <String>]`: The Universal Integrated Circuit Card Identifier (UICCID) identifying the hardware onto which a profile is to be deployed.
    - `[UserName <String>]`: Username which the subscription was provisioned to e.g. joe@contoso.com
  - `[DisplayName <String>]`: The admin defined name of the embedded SIM activation code pool.
  - `[ModifiedDateTime <DateTime?>]`: The time the embedded SIM activation code pool was last modified. Updated service side.

DEVICESTATES <IMicrosoftGraphEmbeddedSimDeviceState[]>: Navigational property to a list of device states for this pool.
  - `[Id <String>]`: Read-only.
  - `[CreatedDateTime <DateTime?>]`: The time the embedded SIM device status was created. Generated service side.
  - `[DeviceName <String>]`: Device name to which the subscription was provisioned e.g. DESKTOP-JOE
  - `[LastSyncDateTime <DateTime?>]`: The time the embedded SIM device last checked in. Updated service side.
  - `[ModifiedDateTime <DateTime?>]`: The time the embedded SIM device status was last modified. Updated service side.
  - `[State <String>]`: embeddedSIMDeviceStateValue
  - `[StateDetails <String>]`: String description of the provisioning state.
  - `[UniversalIntegratedCircuitCardIdentifier <String>]`: The Universal Integrated Circuit Card Identifier (UICCID) identifying the hardware onto which a profile is to be deployed.
  - `[UserName <String>]`: Username which the subscription was provisioned to e.g. joe@contoso.com

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
  - `[ManagementConditionId <String>]`: key: id of managementCondition
  - `[ManagementConditionStatementId <String>]`: key: id of managementConditionStatement
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
  - `[UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionId <String>]`: key: id of userExperienceAnalyticsAppHealthAppPerformanceByAppVersion
  - `[UserExperienceAnalyticsAppHealthAppPerformanceByOSVersionId <String>]`: key: id of userExperienceAnalyticsAppHealthAppPerformanceByOSVersion
  - `[UserExperienceAnalyticsAppHealthApplicationPerformanceId <String>]`: key: id of userExperienceAnalyticsAppHealthApplicationPerformance
  - `[UserExperienceAnalyticsAppHealthDeviceModelPerformanceId <String>]`: key: id of userExperienceAnalyticsAppHealthDeviceModelPerformance
  - `[UserExperienceAnalyticsAppHealthDevicePerformanceDetailsId <String>]`: key: id of userExperienceAnalyticsAppHealthDevicePerformanceDetails
  - `[UserExperienceAnalyticsAppHealthDevicePerformanceId <String>]`: key: id of userExperienceAnalyticsAppHealthDevicePerformance
  - `[UserExperienceAnalyticsAppHealthOSVersionPerformanceId <String>]`: key: id of userExperienceAnalyticsAppHealthOSVersionPerformance
  - `[UserExperienceAnalyticsBaselineId <String>]`: key: id of userExperienceAnalyticsBaseline
  - `[UserExperienceAnalyticsCategoryId <String>]`: key: id of userExperienceAnalyticsCategory
  - `[UserExperienceAnalyticsDevicePerformanceId <String>]`: key: id of userExperienceAnalyticsDevicePerformance
  - `[UserExperienceAnalyticsDeviceScoresId <String>]`: key: id of userExperienceAnalyticsDeviceScores
  - `[UserExperienceAnalyticsDeviceStartupHistoryId <String>]`: key: id of userExperienceAnalyticsDeviceStartupHistory
  - `[UserExperienceAnalyticsDeviceStartupProcessId <String>]`: key: id of userExperienceAnalyticsDeviceStartupProcess
  - `[UserExperienceAnalyticsDeviceStartupProcessPerformanceId <String>]`: key: id of userExperienceAnalyticsDeviceStartupProcessPerformance
  - `[UserExperienceAnalyticsDeviceWithoutCloudIdentityId <String>]`: key: id of userExperienceAnalyticsDeviceWithoutCloudIdentity
  - `[UserExperienceAnalyticsImpactingProcessId <String>]`: key: id of userExperienceAnalyticsImpactingProcess
  - `[UserExperienceAnalyticsMetricHistoryId <String>]`: key: id of userExperienceAnalyticsMetricHistory
  - `[UserExperienceAnalyticsMetricId <String>]`: key: id of userExperienceAnalyticsMetric
  - `[UserExperienceAnalyticsNotAutopilotReadyDeviceId <String>]`: key: id of userExperienceAnalyticsNotAutopilotReadyDevice
  - `[UserExperienceAnalyticsRemoteConnectionId <String>]`: key: id of userExperienceAnalyticsRemoteConnection
  - `[UserExperienceAnalyticsResourcePerformanceId <String>]`: key: id of userExperienceAnalyticsResourcePerformance
  - `[UserExperienceAnalyticsScoreHistoryId <String>]`: key: id of userExperienceAnalyticsScoreHistory
  - `[UserExperienceAnalyticsWorkFromAnywhereDeviceId <String>]`: key: id of userExperienceAnalyticsWorkFromAnywhereDevice
  - `[UserExperienceAnalyticsWorkFromAnywhereMetricId <String>]`: key: id of userExperienceAnalyticsWorkFromAnywhereMetric
  - `[UserId <String>]`: key: id of user
  - `[WindowsDeviceMalwareStateId <String>]`: key: id of windowsDeviceMalwareState
  - `[WindowsInformationProtectionAppLearningSummaryId <String>]`: key: id of windowsInformationProtectionAppLearningSummary
  - `[WindowsInformationProtectionNetworkLearningSummaryId <String>]`: key: id of windowsInformationProtectionNetworkLearningSummary
  - `[WindowsMalwareInformationId <String>]`: key: id of windowsMalwareInformation

## RELATED LINKS

## RELATED LINKS
