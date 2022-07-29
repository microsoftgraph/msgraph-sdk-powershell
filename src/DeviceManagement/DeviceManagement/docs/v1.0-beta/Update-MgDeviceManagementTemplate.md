---
external help file:
Module Name: Microsoft.Graph.DeviceManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement/update-mgdevicemanagementtemplate
schema: 2.0.0
---

# Update-MgDeviceManagementTemplate

## SYNOPSIS
Update the navigation property templates in deviceManagement

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgDeviceManagementTemplate -DeviceManagementTemplateId <String> [-AdditionalProperties <Hashtable>]
 [-Categories <IMicrosoftGraphDeviceManagementTemplateSettingCategory[]>] [-Description <String>]
 [-DisplayName <String>] [-Id <String>] [-IntentCount <Int32>] [-IsDeprecated]
 [-MigratableTo <IMicrosoftGraphDeviceManagementTemplate[]>] [-PlatformType <PolicyPlatformType>]
 [-PublishedDateTime <DateTime>] [-Settings <IMicrosoftGraphDeviceManagementSettingInstance[]>]
 [-TemplateSubtype <DeviceManagementTemplateSubtype>] [-TemplateType <DeviceManagementTemplateType>]
 [-VersionInfo <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgDeviceManagementTemplate -DeviceManagementTemplateId <String>
 -BodyParameter <IMicrosoftGraphDeviceManagementTemplate> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgDeviceManagementTemplate -InputObject <IDeviceManagementIdentity>
 -BodyParameter <IMicrosoftGraphDeviceManagementTemplate> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgDeviceManagementTemplate -InputObject <IDeviceManagementIdentity> [-AdditionalProperties <Hashtable>]
 [-Categories <IMicrosoftGraphDeviceManagementTemplateSettingCategory[]>] [-Description <String>]
 [-DisplayName <String>] [-Id <String>] [-IntentCount <Int32>] [-IsDeprecated]
 [-MigratableTo <IMicrosoftGraphDeviceManagementTemplate[]>] [-PlatformType <PolicyPlatformType>]
 [-PublishedDateTime <DateTime>] [-Settings <IMicrosoftGraphDeviceManagementSettingInstance[]>]
 [-TemplateSubtype <DeviceManagementTemplateSubtype>] [-TemplateType <DeviceManagementTemplateType>]
 [-VersionInfo <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property templates in deviceManagement

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
Entity that represents a defined collection of device settings
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementTemplate
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Categories
Collection of setting categories within the template
To construct, please use Get-Help -Online and see NOTES section for CATEGORIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementTemplateSettingCategory[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
The template's description

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

### -DeviceManagementTemplateId
key: id of deviceManagementTemplate

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

### -DisplayName
The template's display name

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
Type: Microsoft.Graph.PowerShell.Models.IDeviceManagementIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IntentCount
Number of Intents created from this template.

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

### -IsDeprecated
The template is deprecated or not.
Intents cannot be created from a deprecated template.

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

### -MigratableTo
Collection of templates this template can migrate to
To construct, please use Get-Help -Online and see NOTES section for MIGRATABLETO properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementTemplate[]
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

### -PlatformType
Supported platform types for policies.

```yaml
Type: Microsoft.Graph.PowerShell.Support.PolicyPlatformType
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PublishedDateTime
When the template was published

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

### -Settings
Collection of all settings this template has
To construct, please use Get-Help -Online and see NOTES section for SETTINGS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementSettingInstance[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TemplateSubtype
Template subtype

```yaml
Type: Microsoft.Graph.PowerShell.Support.DeviceManagementTemplateSubtype
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TemplateType
Template type

```yaml
Type: Microsoft.Graph.PowerShell.Support.DeviceManagementTemplateType
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VersionInfo
The template's version information

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

### Microsoft.Graph.PowerShell.Models.IDeviceManagementIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementTemplate

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphDeviceManagementTemplate>: Entity that represents a defined collection of device settings
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[Categories <IMicrosoftGraphDeviceManagementTemplateSettingCategory[]>]`: Collection of setting categories within the template
    - `[DisplayName <String>]`: The category name
    - `[HasRequiredSetting <Boolean?>]`: The category contains top level required setting
    - `[SettingDefinitions <IMicrosoftGraphDeviceManagementSettingDefinition[]>]`: The setting definitions this category contains
      - `[Id <String>]`: 
      - `[Constraints <IMicrosoftGraphDeviceManagementConstraint[]>]`: Collection of constraints for the setting value
      - `[Dependencies <IMicrosoftGraphDeviceManagementSettingDependency[]>]`: Collection of dependencies on other settings
        - `[Constraints <IMicrosoftGraphDeviceManagementConstraint[]>]`: Collection of constraints for the dependency setting value
        - `[DefinitionId <String>]`: The setting definition ID of the setting depended on
      - `[Description <String>]`: The setting's description
      - `[DisplayName <String>]`: The setting's display name
      - `[DocumentationUrl <String>]`: Url to setting documentation
      - `[HeaderSubtitle <String>]`: subtitle of the setting header for more details about the category/section
      - `[HeaderTitle <String>]`: title of the setting header represents a category/section of a setting/settings
      - `[IsTopLevel <Boolean?>]`: If the setting is top level, it can be configured without the need to be wrapped in a collection or complex setting
      - `[Keywords <String[]>]`: Keywords associated with the setting
      - `[PlaceholderText <String>]`: Placeholder text as an example of valid input
      - `[ValueType <DeviceManangementIntentValueType?>]`: deviceManangementIntentValueType
    - `[Id <String>]`: 
    - `[RecommendedSettings <IMicrosoftGraphDeviceManagementSettingInstance[]>]`: The settings this category contains
      - `[Id <String>]`: 
      - `[DefinitionId <String>]`: The ID of the setting definition for this instance
      - `[ValueJson <String>]`: JSON representation of the value
  - `[Description <String>]`: The template's description
  - `[DisplayName <String>]`: The template's display name
  - `[IntentCount <Int32?>]`: Number of Intents created from this template.
  - `[IsDeprecated <Boolean?>]`: The template is deprecated or not. Intents cannot be created from a deprecated template.
  - `[MigratableTo <IMicrosoftGraphDeviceManagementTemplate[]>]`: Collection of templates this template can migrate to
  - `[PlatformType <PolicyPlatformType?>]`: Supported platform types for policies.
  - `[PublishedDateTime <DateTime?>]`: When the template was published
  - `[Settings <IMicrosoftGraphDeviceManagementSettingInstance[]>]`: Collection of all settings this template has
  - `[TemplateSubtype <DeviceManagementTemplateSubtype?>]`: Template subtype
  - `[TemplateType <DeviceManagementTemplateType?>]`: Template type
  - `[VersionInfo <String>]`: The template's version information

CATEGORIES <IMicrosoftGraphDeviceManagementTemplateSettingCategory[]>: Collection of setting categories within the template
  - `[DisplayName <String>]`: The category name
  - `[HasRequiredSetting <Boolean?>]`: The category contains top level required setting
  - `[SettingDefinitions <IMicrosoftGraphDeviceManagementSettingDefinition[]>]`: The setting definitions this category contains
    - `[Id <String>]`: 
    - `[Constraints <IMicrosoftGraphDeviceManagementConstraint[]>]`: Collection of constraints for the setting value
    - `[Dependencies <IMicrosoftGraphDeviceManagementSettingDependency[]>]`: Collection of dependencies on other settings
      - `[Constraints <IMicrosoftGraphDeviceManagementConstraint[]>]`: Collection of constraints for the dependency setting value
      - `[DefinitionId <String>]`: The setting definition ID of the setting depended on
    - `[Description <String>]`: The setting's description
    - `[DisplayName <String>]`: The setting's display name
    - `[DocumentationUrl <String>]`: Url to setting documentation
    - `[HeaderSubtitle <String>]`: subtitle of the setting header for more details about the category/section
    - `[HeaderTitle <String>]`: title of the setting header represents a category/section of a setting/settings
    - `[IsTopLevel <Boolean?>]`: If the setting is top level, it can be configured without the need to be wrapped in a collection or complex setting
    - `[Keywords <String[]>]`: Keywords associated with the setting
    - `[PlaceholderText <String>]`: Placeholder text as an example of valid input
    - `[ValueType <DeviceManangementIntentValueType?>]`: deviceManangementIntentValueType
  - `[Id <String>]`: 
  - `[RecommendedSettings <IMicrosoftGraphDeviceManagementSettingInstance[]>]`: The settings this category contains
    - `[Id <String>]`: 
    - `[DefinitionId <String>]`: The ID of the setting definition for this instance
    - `[ValueJson <String>]`: JSON representation of the value

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

MIGRATABLETO <IMicrosoftGraphDeviceManagementTemplate[]>: Collection of templates this template can migrate to
  - `[Id <String>]`: 
  - `[Categories <IMicrosoftGraphDeviceManagementTemplateSettingCategory[]>]`: Collection of setting categories within the template
    - `[DisplayName <String>]`: The category name
    - `[HasRequiredSetting <Boolean?>]`: The category contains top level required setting
    - `[SettingDefinitions <IMicrosoftGraphDeviceManagementSettingDefinition[]>]`: The setting definitions this category contains
      - `[Id <String>]`: 
      - `[Constraints <IMicrosoftGraphDeviceManagementConstraint[]>]`: Collection of constraints for the setting value
      - `[Dependencies <IMicrosoftGraphDeviceManagementSettingDependency[]>]`: Collection of dependencies on other settings
        - `[Constraints <IMicrosoftGraphDeviceManagementConstraint[]>]`: Collection of constraints for the dependency setting value
        - `[DefinitionId <String>]`: The setting definition ID of the setting depended on
      - `[Description <String>]`: The setting's description
      - `[DisplayName <String>]`: The setting's display name
      - `[DocumentationUrl <String>]`: Url to setting documentation
      - `[HeaderSubtitle <String>]`: subtitle of the setting header for more details about the category/section
      - `[HeaderTitle <String>]`: title of the setting header represents a category/section of a setting/settings
      - `[IsTopLevel <Boolean?>]`: If the setting is top level, it can be configured without the need to be wrapped in a collection or complex setting
      - `[Keywords <String[]>]`: Keywords associated with the setting
      - `[PlaceholderText <String>]`: Placeholder text as an example of valid input
      - `[ValueType <DeviceManangementIntentValueType?>]`: deviceManangementIntentValueType
    - `[Id <String>]`: 
    - `[RecommendedSettings <IMicrosoftGraphDeviceManagementSettingInstance[]>]`: The settings this category contains
      - `[Id <String>]`: 
      - `[DefinitionId <String>]`: The ID of the setting definition for this instance
      - `[ValueJson <String>]`: JSON representation of the value
  - `[Description <String>]`: The template's description
  - `[DisplayName <String>]`: The template's display name
  - `[IntentCount <Int32?>]`: Number of Intents created from this template.
  - `[IsDeprecated <Boolean?>]`: The template is deprecated or not. Intents cannot be created from a deprecated template.
  - `[MigratableTo <IMicrosoftGraphDeviceManagementTemplate[]>]`: Collection of templates this template can migrate to
  - `[PlatformType <PolicyPlatformType?>]`: Supported platform types for policies.
  - `[PublishedDateTime <DateTime?>]`: When the template was published
  - `[Settings <IMicrosoftGraphDeviceManagementSettingInstance[]>]`: Collection of all settings this template has
  - `[TemplateSubtype <DeviceManagementTemplateSubtype?>]`: Template subtype
  - `[TemplateType <DeviceManagementTemplateType?>]`: Template type
  - `[VersionInfo <String>]`: The template's version information

SETTINGS <IMicrosoftGraphDeviceManagementSettingInstance[]>: Collection of all settings this template has
  - `[Id <String>]`: 
  - `[DefinitionId <String>]`: The ID of the setting definition for this instance
  - `[ValueJson <String>]`: JSON representation of the value

## RELATED LINKS

