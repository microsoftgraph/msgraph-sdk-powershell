---
external help file:
Module Name: Microsoft.Graph.DeviceManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement/update-mgdevicemanagementgrouppolicyconfigurationdefinitionvalue
schema: 2.0.0
---

# Update-MgDeviceManagementGroupPolicyConfigurationDefinitionValue

## SYNOPSIS
Update the navigation property definitionValues in deviceManagement

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgDeviceManagementGroupPolicyConfigurationDefinitionValue -GroupPolicyConfigurationId <String>
 -GroupPolicyDefinitionValueId <String> [-AdditionalProperties <Hashtable>]
 [-ConfigurationType <GroupPolicyConfigurationType>] [-CreatedDateTime <DateTime>]
 [-Definition <IMicrosoftGraphGroupPolicyDefinition>] [-Enabled] [-Id <String>]
 [-LastModifiedDateTime <DateTime>] [-PresentationValues <IMicrosoftGraphGroupPolicyPresentationValue[]>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgDeviceManagementGroupPolicyConfigurationDefinitionValue -GroupPolicyConfigurationId <String>
 -GroupPolicyDefinitionValueId <String> -BodyParameter <IMicrosoftGraphGroupPolicyDefinitionValue> [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgDeviceManagementGroupPolicyConfigurationDefinitionValue -InputObject <IDeviceManagementIdentity>
 -BodyParameter <IMicrosoftGraphGroupPolicyDefinitionValue> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgDeviceManagementGroupPolicyConfigurationDefinitionValue -InputObject <IDeviceManagementIdentity>
 [-AdditionalProperties <Hashtable>] [-ConfigurationType <GroupPolicyConfigurationType>]
 [-CreatedDateTime <DateTime>] [-Definition <IMicrosoftGraphGroupPolicyDefinition>] [-Enabled] [-Id <String>]
 [-LastModifiedDateTime <DateTime>] [-PresentationValues <IMicrosoftGraphGroupPolicyPresentationValue[]>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property definitionValues in deviceManagement

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
The definition value entity stores the value for a single group policy definition.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphGroupPolicyDefinitionValue
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ConfigurationType
Group Policy Configuration Type

```yaml
Type: Microsoft.Graph.PowerShell.Support.GroupPolicyConfigurationType
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedDateTime
The date and time the object was created.

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

### -Definition
The entity describes all of the information about a single group policy.
To construct, please use Get-Help -Online and see NOTES section for DEFINITION properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphGroupPolicyDefinition
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Enabled
Enables or disables the associated group policy definition.

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

### -GroupPolicyConfigurationId
key: id of groupPolicyConfiguration

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

### -GroupPolicyDefinitionValueId
key: id of groupPolicyDefinitionValue

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

### -LastModifiedDateTime
The date and time the entity was last modified.

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

### -PresentationValues
The associated group policy presentation values with the definition value.
To construct, please use Get-Help -Online and see NOTES section for PRESENTATIONVALUES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphGroupPolicyPresentationValue[]
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphGroupPolicyDefinitionValue

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphGroupPolicyDefinitionValue>: The definition value entity stores the value for a single group policy definition.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[ConfigurationType <GroupPolicyConfigurationType?>]`: Group Policy Configuration Type
  - `[CreatedDateTime <DateTime?>]`: The date and time the object was created.
  - `[Definition <IMicrosoftGraphGroupPolicyDefinition>]`: The entity describes all of the information about a single group policy.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[Category <IMicrosoftGraphGroupPolicyCategory>]`: The category entity stores the category of a group policy definition
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: 
      - `[Children <IMicrosoftGraphGroupPolicyCategory[]>]`: The children categories
      - `[DefinitionFile <IMicrosoftGraphGroupPolicyDefinitionFile>]`: The entity represents an ADMX (Administrative Template) XML file. The ADMX file contains a collection of group policy definitions and their locations by category path. The group policy definition file also contains the languages supported as determined by the language dependent ADML (Administrative Template) language files.
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: 
        - `[Definitions <IMicrosoftGraphGroupPolicyDefinition[]>]`: The group policy definitions associated with the file.
        - `[Description <String>]`: The localized description of the policy settings in the ADMX file. The default value is empty.
        - `[DisplayName <String>]`: The localized friendly name of the ADMX file.
        - `[FileName <String>]`: The file name of the ADMX file without the path. For example: edge.admx
        - `[LanguageCodes <String[]>]`: The supported language codes for the ADMX file.
        - `[LastModifiedDateTime <DateTime?>]`: The date and time the entity was last modified.
        - `[PolicyType <GroupPolicyType?>]`: Type of Group Policy File or Definition.
        - `[Revision <String>]`: The revision version associated with the file.
        - `[TargetNamespace <String>]`: Specifies the URI used to identify the namespace within the ADMX file.
        - `[TargetPrefix <String>]`: Specifies the logical name that refers to the namespace within the ADMX file.
      - `[Definitions <IMicrosoftGraphGroupPolicyDefinition[]>]`: The immediate GroupPolicyDefinition children of the category
      - `[DisplayName <String>]`: The string id of the category's display name
      - `[IsRoot <Boolean?>]`: Defines if the category is a root category
      - `[LastModifiedDateTime <DateTime?>]`: The date and time the entity was last modified.
      - `[Parent <IMicrosoftGraphGroupPolicyCategory>]`: The category entity stores the category of a group policy definition
    - `[CategoryPath <String>]`: The localized full category path for the policy.
    - `[ClassType <GroupPolicyDefinitionClassType?>]`: Group Policy Definition Class Type.
    - `[DefinitionFile <IMicrosoftGraphGroupPolicyDefinitionFile>]`: The entity represents an ADMX (Administrative Template) XML file. The ADMX file contains a collection of group policy definitions and their locations by category path. The group policy definition file also contains the languages supported as determined by the language dependent ADML (Administrative Template) language files.
    - `[DisplayName <String>]`: The localized policy name.
    - `[ExplainText <String>]`: The localized explanation or help text associated with the policy. The default value is empty.
    - `[GroupPolicyCategoryId <String>]`: The category id of the parent category
    - `[HasRelatedDefinitions <Boolean?>]`: Signifies whether or not there are related definitions to this definition
    - `[LastModifiedDateTime <DateTime?>]`: The date and time the entity was last modified.
    - `[MinDeviceCspVersion <String>]`: Minimum required CSP version for device configuration in this definition
    - `[MinUserCspVersion <String>]`: Minimum required CSP version for user configuration in this definition
    - `[NextVersionDefinition <IMicrosoftGraphGroupPolicyDefinition>]`: The entity describes all of the information about a single group policy.
    - `[PolicyType <GroupPolicyType?>]`: Type of Group Policy File or Definition.
    - `[Presentations <IMicrosoftGraphGroupPolicyPresentation[]>]`: The group policy presentations associated with the definition.
      - `[Id <String>]`: 
      - `[Definition <IMicrosoftGraphGroupPolicyDefinition>]`: The entity describes all of the information about a single group policy.
      - `[Label <String>]`: Localized text label for any presentation entity. The default value is empty.
      - `[LastModifiedDateTime <DateTime?>]`: The date and time the entity was last modified.
    - `[PreviousVersionDefinition <IMicrosoftGraphGroupPolicyDefinition>]`: The entity describes all of the information about a single group policy.
    - `[SupportedOn <String>]`: Localized string used to specify what operating system or application version is affected by the policy.
    - `[Version <String>]`: Setting definition version
  - `[Enabled <Boolean?>]`: Enables or disables the associated group policy definition.
  - `[LastModifiedDateTime <DateTime?>]`: The date and time the entity was last modified.
  - `[PresentationValues <IMicrosoftGraphGroupPolicyPresentationValue[]>]`: The associated group policy presentation values with the definition value.
    - `[Id <String>]`: 
    - `[CreatedDateTime <DateTime?>]`: The date and time the object was created.
    - `[DefinitionValue <IMicrosoftGraphGroupPolicyDefinitionValue>]`: The definition value entity stores the value for a single group policy definition.
    - `[LastModifiedDateTime <DateTime?>]`: The date and time the object was last modified.
    - `[Presentation <IMicrosoftGraphGroupPolicyPresentation>]`: The base entity for the display presentation of any of the additional options in a group policy definition.

DEFINITION <IMicrosoftGraphGroupPolicyDefinition>: The entity describes all of the information about a single group policy.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[Category <IMicrosoftGraphGroupPolicyCategory>]`: The category entity stores the category of a group policy definition
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[Children <IMicrosoftGraphGroupPolicyCategory[]>]`: The children categories
    - `[DefinitionFile <IMicrosoftGraphGroupPolicyDefinitionFile>]`: The entity represents an ADMX (Administrative Template) XML file. The ADMX file contains a collection of group policy definitions and their locations by category path. The group policy definition file also contains the languages supported as determined by the language dependent ADML (Administrative Template) language files.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: 
      - `[Definitions <IMicrosoftGraphGroupPolicyDefinition[]>]`: The group policy definitions associated with the file.
      - `[Description <String>]`: The localized description of the policy settings in the ADMX file. The default value is empty.
      - `[DisplayName <String>]`: The localized friendly name of the ADMX file.
      - `[FileName <String>]`: The file name of the ADMX file without the path. For example: edge.admx
      - `[LanguageCodes <String[]>]`: The supported language codes for the ADMX file.
      - `[LastModifiedDateTime <DateTime?>]`: The date and time the entity was last modified.
      - `[PolicyType <GroupPolicyType?>]`: Type of Group Policy File or Definition.
      - `[Revision <String>]`: The revision version associated with the file.
      - `[TargetNamespace <String>]`: Specifies the URI used to identify the namespace within the ADMX file.
      - `[TargetPrefix <String>]`: Specifies the logical name that refers to the namespace within the ADMX file.
    - `[Definitions <IMicrosoftGraphGroupPolicyDefinition[]>]`: The immediate GroupPolicyDefinition children of the category
    - `[DisplayName <String>]`: The string id of the category's display name
    - `[IsRoot <Boolean?>]`: Defines if the category is a root category
    - `[LastModifiedDateTime <DateTime?>]`: The date and time the entity was last modified.
    - `[Parent <IMicrosoftGraphGroupPolicyCategory>]`: The category entity stores the category of a group policy definition
  - `[CategoryPath <String>]`: The localized full category path for the policy.
  - `[ClassType <GroupPolicyDefinitionClassType?>]`: Group Policy Definition Class Type.
  - `[DefinitionFile <IMicrosoftGraphGroupPolicyDefinitionFile>]`: The entity represents an ADMX (Administrative Template) XML file. The ADMX file contains a collection of group policy definitions and their locations by category path. The group policy definition file also contains the languages supported as determined by the language dependent ADML (Administrative Template) language files.
  - `[DisplayName <String>]`: The localized policy name.
  - `[ExplainText <String>]`: The localized explanation or help text associated with the policy. The default value is empty.
  - `[GroupPolicyCategoryId <String>]`: The category id of the parent category
  - `[HasRelatedDefinitions <Boolean?>]`: Signifies whether or not there are related definitions to this definition
  - `[LastModifiedDateTime <DateTime?>]`: The date and time the entity was last modified.
  - `[MinDeviceCspVersion <String>]`: Minimum required CSP version for device configuration in this definition
  - `[MinUserCspVersion <String>]`: Minimum required CSP version for user configuration in this definition
  - `[NextVersionDefinition <IMicrosoftGraphGroupPolicyDefinition>]`: The entity describes all of the information about a single group policy.
  - `[PolicyType <GroupPolicyType?>]`: Type of Group Policy File or Definition.
  - `[Presentations <IMicrosoftGraphGroupPolicyPresentation[]>]`: The group policy presentations associated with the definition.
    - `[Id <String>]`: 
    - `[Definition <IMicrosoftGraphGroupPolicyDefinition>]`: The entity describes all of the information about a single group policy.
    - `[Label <String>]`: Localized text label for any presentation entity. The default value is empty.
    - `[LastModifiedDateTime <DateTime?>]`: The date and time the entity was last modified.
  - `[PreviousVersionDefinition <IMicrosoftGraphGroupPolicyDefinition>]`: The entity describes all of the information about a single group policy.
  - `[SupportedOn <String>]`: Localized string used to specify what operating system or application version is affected by the policy.
  - `[Version <String>]`: Setting definition version

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

PRESENTATIONVALUES <IMicrosoftGraphGroupPolicyPresentationValue[]>: The associated group policy presentation values with the definition value.
  - `[Id <String>]`: 
  - `[CreatedDateTime <DateTime?>]`: The date and time the object was created.
  - `[DefinitionValue <IMicrosoftGraphGroupPolicyDefinitionValue>]`: The definition value entity stores the value for a single group policy definition.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[ConfigurationType <GroupPolicyConfigurationType?>]`: Group Policy Configuration Type
    - `[CreatedDateTime <DateTime?>]`: The date and time the object was created.
    - `[Definition <IMicrosoftGraphGroupPolicyDefinition>]`: The entity describes all of the information about a single group policy.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: 
      - `[Category <IMicrosoftGraphGroupPolicyCategory>]`: The category entity stores the category of a group policy definition
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: 
        - `[Children <IMicrosoftGraphGroupPolicyCategory[]>]`: The children categories
        - `[DefinitionFile <IMicrosoftGraphGroupPolicyDefinitionFile>]`: The entity represents an ADMX (Administrative Template) XML file. The ADMX file contains a collection of group policy definitions and their locations by category path. The group policy definition file also contains the languages supported as determined by the language dependent ADML (Administrative Template) language files.
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Id <String>]`: 
          - `[Definitions <IMicrosoftGraphGroupPolicyDefinition[]>]`: The group policy definitions associated with the file.
          - `[Description <String>]`: The localized description of the policy settings in the ADMX file. The default value is empty.
          - `[DisplayName <String>]`: The localized friendly name of the ADMX file.
          - `[FileName <String>]`: The file name of the ADMX file without the path. For example: edge.admx
          - `[LanguageCodes <String[]>]`: The supported language codes for the ADMX file.
          - `[LastModifiedDateTime <DateTime?>]`: The date and time the entity was last modified.
          - `[PolicyType <GroupPolicyType?>]`: Type of Group Policy File or Definition.
          - `[Revision <String>]`: The revision version associated with the file.
          - `[TargetNamespace <String>]`: Specifies the URI used to identify the namespace within the ADMX file.
          - `[TargetPrefix <String>]`: Specifies the logical name that refers to the namespace within the ADMX file.
        - `[Definitions <IMicrosoftGraphGroupPolicyDefinition[]>]`: The immediate GroupPolicyDefinition children of the category
        - `[DisplayName <String>]`: The string id of the category's display name
        - `[IsRoot <Boolean?>]`: Defines if the category is a root category
        - `[LastModifiedDateTime <DateTime?>]`: The date and time the entity was last modified.
        - `[Parent <IMicrosoftGraphGroupPolicyCategory>]`: The category entity stores the category of a group policy definition
      - `[CategoryPath <String>]`: The localized full category path for the policy.
      - `[ClassType <GroupPolicyDefinitionClassType?>]`: Group Policy Definition Class Type.
      - `[DefinitionFile <IMicrosoftGraphGroupPolicyDefinitionFile>]`: The entity represents an ADMX (Administrative Template) XML file. The ADMX file contains a collection of group policy definitions and their locations by category path. The group policy definition file also contains the languages supported as determined by the language dependent ADML (Administrative Template) language files.
      - `[DisplayName <String>]`: The localized policy name.
      - `[ExplainText <String>]`: The localized explanation or help text associated with the policy. The default value is empty.
      - `[GroupPolicyCategoryId <String>]`: The category id of the parent category
      - `[HasRelatedDefinitions <Boolean?>]`: Signifies whether or not there are related definitions to this definition
      - `[LastModifiedDateTime <DateTime?>]`: The date and time the entity was last modified.
      - `[MinDeviceCspVersion <String>]`: Minimum required CSP version for device configuration in this definition
      - `[MinUserCspVersion <String>]`: Minimum required CSP version for user configuration in this definition
      - `[NextVersionDefinition <IMicrosoftGraphGroupPolicyDefinition>]`: The entity describes all of the information about a single group policy.
      - `[PolicyType <GroupPolicyType?>]`: Type of Group Policy File or Definition.
      - `[Presentations <IMicrosoftGraphGroupPolicyPresentation[]>]`: The group policy presentations associated with the definition.
        - `[Id <String>]`: 
        - `[Definition <IMicrosoftGraphGroupPolicyDefinition>]`: The entity describes all of the information about a single group policy.
        - `[Label <String>]`: Localized text label for any presentation entity. The default value is empty.
        - `[LastModifiedDateTime <DateTime?>]`: The date and time the entity was last modified.
      - `[PreviousVersionDefinition <IMicrosoftGraphGroupPolicyDefinition>]`: The entity describes all of the information about a single group policy.
      - `[SupportedOn <String>]`: Localized string used to specify what operating system or application version is affected by the policy.
      - `[Version <String>]`: Setting definition version
    - `[Enabled <Boolean?>]`: Enables or disables the associated group policy definition.
    - `[LastModifiedDateTime <DateTime?>]`: The date and time the entity was last modified.
    - `[PresentationValues <IMicrosoftGraphGroupPolicyPresentationValue[]>]`: The associated group policy presentation values with the definition value.
  - `[LastModifiedDateTime <DateTime?>]`: The date and time the object was last modified.
  - `[Presentation <IMicrosoftGraphGroupPolicyPresentation>]`: The base entity for the display presentation of any of the additional options in a group policy definition.

## RELATED LINKS

