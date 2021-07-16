---
external help file: Microsoft.Graph.DeviceManagement-help.xml
Module Name: Microsoft.Graph.DeviceManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement/new-mgdevicemanagementdeviceconfigurationgroupassignment
schema: 2.0.0
---

# New-MgDeviceManagementDeviceConfigurationGroupAssignment

## SYNOPSIS
The list of group assignments for the device configuration profile.

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementDeviceConfigurationGroupAssignment -DeviceConfigurationId <String>
 [-AdditionalProperties <Hashtable>] [-DeviceConfiguration <IMicrosoftGraphDeviceConfiguration1>]
 [-ExcludeGroup] [-Id <String>] [-TargetGroupId <String>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementDeviceConfigurationGroupAssignment -DeviceConfigurationId <String>
 -BodyParameter <IMicrosoftGraphDeviceConfigurationGroupAssignment> [-WhatIf] [-Confirm] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgDeviceManagementDeviceConfigurationGroupAssignment -InputObject <IDeviceManagementIdentity>
 [-AdditionalProperties <Hashtable>] [-DeviceConfiguration <IMicrosoftGraphDeviceConfiguration1>]
 [-ExcludeGroup] [-Id <String>] [-TargetGroupId <String>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgDeviceManagementDeviceConfigurationGroupAssignment -InputObject <IDeviceManagementIdentity>
 -BodyParameter <IMicrosoftGraphDeviceConfigurationGroupAssignment> [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
The list of group assignments for the device configuration profile.

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
Device configuration group assignment.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphDeviceConfigurationGroupAssignment
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DeviceConfiguration
Device Configuration.
To construct, see NOTES section for DEVICECONFIGURATION properties and create a hash table.

```yaml
Type: IMicrosoftGraphDeviceConfiguration1
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceConfigurationId
key: id of deviceConfiguration

```yaml
Type: String
Parameter Sets: CreateExpanded, Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExcludeGroup
Indicates if this group is should be excluded.
Defaults that the group should be included

```yaml
Type: SwitchParameter
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateViaIdentityExpanded, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -TargetGroupId
The Id of the AAD group we are targeting the device configuration to.

```yaml
Type: String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceConfigurationGroupAssignment
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceConfigurationGroupAssignment
## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphDeviceConfigurationGroupAssignment>: Device configuration group assignment.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[DeviceConfiguration <IMicrosoftGraphDeviceConfiguration1>]`: Device Configuration.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[Assignments <IMicrosoftGraphDeviceConfigurationAssignment1[]>]`: The list of assignments for the device configuration profile.
      - `[Id <String>]`: Read-only.
      - `[Source <String>]`: deviceAndAppManagementAssignmentSource
      - `[SourceId <String>]`: The identifier of the source of the assignment. This property is read-only.
      - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget1>]`: Base type for assignment targets.
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
        - `[DeviceAndAppManagementAssignmentFilterType <String>]`: deviceAndAppManagementAssignmentFilterType
    - `[CreatedDateTime <DateTime?>]`: DateTime the object was created.
    - `[Description <String>]`: Admin provided description of the Device Configuration.
    - `[DeviceManagementApplicabilityRuleDeviceMode <IMicrosoftGraphDeviceManagementApplicabilityRuleDeviceMode>]`: deviceManagementApplicabilityRuleDeviceMode
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DeviceMode <String>]`: windows10DeviceModeType
      - `[Name <String>]`: Name for object.
      - `[RuleType <String>]`: deviceManagementApplicabilityRuleType
    - `[DeviceManagementApplicabilityRuleOSEdition <IMicrosoftGraphDeviceManagementApplicabilityRuleOSEdition>]`: deviceManagementApplicabilityRuleOsEdition
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Name <String>]`: Name for object.
      - `[OSEditionTypes <String[]>]`: Applicability rule OS edition type.
      - `[RuleType <String>]`: deviceManagementApplicabilityRuleType
    - `[DeviceManagementApplicabilityRuleOSVersion <IMicrosoftGraphDeviceManagementApplicabilityRuleOSVersion>]`: deviceManagementApplicabilityRuleOsVersion
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[MaxOSVersion <String>]`: Max OS version for Applicability Rule.
      - `[MinOSVersion <String>]`: Min OS version for Applicability Rule.
      - `[Name <String>]`: Name for object.
      - `[RuleType <String>]`: deviceManagementApplicabilityRuleType
    - `[DeviceSettingStateSummaries <IMicrosoftGraphSettingStateDeviceSummary[]>]`: Device Configuration Setting State Device Summary
      - `[Id <String>]`: Read-only.
      - `[CompliantDeviceCount <Int32?>]`: Device Compliant count for the setting
      - `[ConflictDeviceCount <Int32?>]`: Device conflict error count for the setting
      - `[ErrorDeviceCount <Int32?>]`: Device error count for the setting
      - `[InstancePath <String>]`: Name of the InstancePath for the setting
      - `[NonCompliantDeviceCount <Int32?>]`: Device NonCompliant count for the setting
      - `[NotApplicableDeviceCount <Int32?>]`: Device Not Applicable count for the setting
      - `[RemediatedDeviceCount <Int32?>]`: Device Compliant count for the setting
      - `[SettingName <String>]`: Name of the setting
      - `[UnknownDeviceCount <Int32?>]`: Device Unkown count for the setting
    - `[DeviceStatusOverview <IMicrosoftGraphDeviceConfigurationDeviceOverview1>]`: deviceConfigurationDeviceOverview
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[ConfigurationVersion <Int32?>]`: Version of the policy for that overview
      - `[ConflictCount <Int32?>]`: Number of devices in conflict
      - `[ErrorCount <Int32?>]`: Number of error devices
      - `[FailedCount <Int32?>]`: Number of failed devices
      - `[LastUpdateDateTime <DateTime?>]`: Last update time
      - `[NotApplicableCount <Int32?>]`: Number of not applicable devices
      - `[NotApplicablePlatformCount <Int32?>]`: Number of not applicable devices due to mismatch platform and policy
      - `[PendingCount <Int32?>]`: Number of pending devices
      - `[SuccessCount <Int32?>]`: Number of succeeded devices
    - `[DeviceStatuses <IMicrosoftGraphDeviceConfigurationDeviceStatus1[]>]`: Device configuration installation status by device.
      - `[Id <String>]`: Read-only.
      - `[ComplianceGracePeriodExpirationDateTime <DateTime?>]`: The DateTime when device compliance grace period expires
      - `[DeviceDisplayName <String>]`: Device name of the DevicePolicyStatus.
      - `[DeviceModel <String>]`: The device model that is being reported
      - `[LastReportedDateTime <DateTime?>]`: Last modified date time of the policy report.
      - `[Platform <Int32?>]`: Platform of the device that is being reported
      - `[Status <String>]`: complianceStatus
      - `[UserName <String>]`: The User Name that is being reported
      - `[UserPrincipalName <String>]`: UserPrincipalName.
    - `[DisplayName <String>]`: Admin provided name of the device configuration.
    - `[GroupAssignments <IMicrosoftGraphDeviceConfigurationGroupAssignment[]>]`: The list of group assignments for the device configuration profile.
    - `[LastModifiedDateTime <DateTime?>]`: DateTime the object was last modified.
    - `[RoleScopeTagIds <String[]>]`: List of Scope Tags for this Entity instance.
    - `[SupportsScopeTags <Boolean?>]`: Indicates whether or not the underlying Device Configuration supports the assignment of scope tags. Assigning to the ScopeTags property is not allowed when this value is false and entities will not be visible to scoped users. This occurs for Legacy policies created in Silverlight and can be resolved by deleting and recreating the policy in the Azure Portal. This property is read-only.
    - `[UserStatusOverview <IMicrosoftGraphDeviceConfigurationUserOverview1>]`: deviceConfigurationUserOverview
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[ConfigurationVersion <Int32?>]`: Version of the policy for that overview
      - `[ConflictCount <Int32?>]`: Number of users in conflict
      - `[ErrorCount <Int32?>]`: Number of error Users
      - `[FailedCount <Int32?>]`: Number of failed Users
      - `[LastUpdateDateTime <DateTime?>]`: Last update time
      - `[NotApplicableCount <Int32?>]`: Number of not applicable users
      - `[PendingCount <Int32?>]`: Number of pending Users
      - `[SuccessCount <Int32?>]`: Number of succeeded Users
    - `[UserStatuses <IMicrosoftGraphDeviceConfigurationUserStatus[]>]`: Device configuration installation status by user.
      - `[Id <String>]`: Read-only.
      - `[DevicesCount <Int32?>]`: Devices count for that user.
      - `[LastReportedDateTime <DateTime?>]`: Last modified date time of the policy report.
      - `[Status <String>]`: complianceStatus
      - `[UserDisplayName <String>]`: User name of the DevicePolicyStatus.
      - `[UserPrincipalName <String>]`: UserPrincipalName.
    - `[Version <Int32?>]`: Version of the device configuration.
  - `[ExcludeGroup <Boolean?>]`: Indicates if this group is should be excluded. Defaults that the group should be included
  - `[TargetGroupId <String>]`: The Id of the AAD group we are targeting the device configuration to.

DEVICECONFIGURATION <IMicrosoftGraphDeviceConfiguration1>: Device Configuration.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[Assignments <IMicrosoftGraphDeviceConfigurationAssignment1[]>]`: The list of assignments for the device configuration profile.
    - `[Id <String>]`: Read-only.
    - `[Source <String>]`: deviceAndAppManagementAssignmentSource
    - `[SourceId <String>]`: The identifier of the source of the assignment. This property is read-only.
    - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget1>]`: Base type for assignment targets.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
      - `[DeviceAndAppManagementAssignmentFilterType <String>]`: deviceAndAppManagementAssignmentFilterType
  - `[CreatedDateTime <DateTime?>]`: DateTime the object was created.
  - `[Description <String>]`: Admin provided description of the Device Configuration.
  - `[DeviceManagementApplicabilityRuleDeviceMode <IMicrosoftGraphDeviceManagementApplicabilityRuleDeviceMode>]`: deviceManagementApplicabilityRuleDeviceMode
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DeviceMode <String>]`: windows10DeviceModeType
    - `[Name <String>]`: Name for object.
    - `[RuleType <String>]`: deviceManagementApplicabilityRuleType
  - `[DeviceManagementApplicabilityRuleOSEdition <IMicrosoftGraphDeviceManagementApplicabilityRuleOSEdition>]`: deviceManagementApplicabilityRuleOsEdition
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Name <String>]`: Name for object.
    - `[OSEditionTypes <String[]>]`: Applicability rule OS edition type.
    - `[RuleType <String>]`: deviceManagementApplicabilityRuleType
  - `[DeviceManagementApplicabilityRuleOSVersion <IMicrosoftGraphDeviceManagementApplicabilityRuleOSVersion>]`: deviceManagementApplicabilityRuleOsVersion
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[MaxOSVersion <String>]`: Max OS version for Applicability Rule.
    - `[MinOSVersion <String>]`: Min OS version for Applicability Rule.
    - `[Name <String>]`: Name for object.
    - `[RuleType <String>]`: deviceManagementApplicabilityRuleType
  - `[DeviceSettingStateSummaries <IMicrosoftGraphSettingStateDeviceSummary[]>]`: Device Configuration Setting State Device Summary
    - `[Id <String>]`: Read-only.
    - `[CompliantDeviceCount <Int32?>]`: Device Compliant count for the setting
    - `[ConflictDeviceCount <Int32?>]`: Device conflict error count for the setting
    - `[ErrorDeviceCount <Int32?>]`: Device error count for the setting
    - `[InstancePath <String>]`: Name of the InstancePath for the setting
    - `[NonCompliantDeviceCount <Int32?>]`: Device NonCompliant count for the setting
    - `[NotApplicableDeviceCount <Int32?>]`: Device Not Applicable count for the setting
    - `[RemediatedDeviceCount <Int32?>]`: Device Compliant count for the setting
    - `[SettingName <String>]`: Name of the setting
    - `[UnknownDeviceCount <Int32?>]`: Device Unkown count for the setting
  - `[DeviceStatusOverview <IMicrosoftGraphDeviceConfigurationDeviceOverview1>]`: deviceConfigurationDeviceOverview
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[ConfigurationVersion <Int32?>]`: Version of the policy for that overview
    - `[ConflictCount <Int32?>]`: Number of devices in conflict
    - `[ErrorCount <Int32?>]`: Number of error devices
    - `[FailedCount <Int32?>]`: Number of failed devices
    - `[LastUpdateDateTime <DateTime?>]`: Last update time
    - `[NotApplicableCount <Int32?>]`: Number of not applicable devices
    - `[NotApplicablePlatformCount <Int32?>]`: Number of not applicable devices due to mismatch platform and policy
    - `[PendingCount <Int32?>]`: Number of pending devices
    - `[SuccessCount <Int32?>]`: Number of succeeded devices
  - `[DeviceStatuses <IMicrosoftGraphDeviceConfigurationDeviceStatus1[]>]`: Device configuration installation status by device.
    - `[Id <String>]`: Read-only.
    - `[ComplianceGracePeriodExpirationDateTime <DateTime?>]`: The DateTime when device compliance grace period expires
    - `[DeviceDisplayName <String>]`: Device name of the DevicePolicyStatus.
    - `[DeviceModel <String>]`: The device model that is being reported
    - `[LastReportedDateTime <DateTime?>]`: Last modified date time of the policy report.
    - `[Platform <Int32?>]`: Platform of the device that is being reported
    - `[Status <String>]`: complianceStatus
    - `[UserName <String>]`: The User Name that is being reported
    - `[UserPrincipalName <String>]`: UserPrincipalName.
  - `[DisplayName <String>]`: Admin provided name of the device configuration.
  - `[GroupAssignments <IMicrosoftGraphDeviceConfigurationGroupAssignment[]>]`: The list of group assignments for the device configuration profile.
    - `[Id <String>]`: Read-only.
    - `[DeviceConfiguration <IMicrosoftGraphDeviceConfiguration1>]`: Device Configuration.
    - `[ExcludeGroup <Boolean?>]`: Indicates if this group is should be excluded. Defaults that the group should be included
    - `[TargetGroupId <String>]`: The Id of the AAD group we are targeting the device configuration to.
  - `[LastModifiedDateTime <DateTime?>]`: DateTime the object was last modified.
  - `[RoleScopeTagIds <String[]>]`: List of Scope Tags for this Entity instance.
  - `[SupportsScopeTags <Boolean?>]`: Indicates whether or not the underlying Device Configuration supports the assignment of scope tags. Assigning to the ScopeTags property is not allowed when this value is false and entities will not be visible to scoped users. This occurs for Legacy policies created in Silverlight and can be resolved by deleting and recreating the policy in the Azure Portal. This property is read-only.
  - `[UserStatusOverview <IMicrosoftGraphDeviceConfigurationUserOverview1>]`: deviceConfigurationUserOverview
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[ConfigurationVersion <Int32?>]`: Version of the policy for that overview
    - `[ConflictCount <Int32?>]`: Number of users in conflict
    - `[ErrorCount <Int32?>]`: Number of error Users
    - `[FailedCount <Int32?>]`: Number of failed Users
    - `[LastUpdateDateTime <DateTime?>]`: Last update time
    - `[NotApplicableCount <Int32?>]`: Number of not applicable users
    - `[PendingCount <Int32?>]`: Number of pending Users
    - `[SuccessCount <Int32?>]`: Number of succeeded Users
  - `[UserStatuses <IMicrosoftGraphDeviceConfigurationUserStatus[]>]`: Device configuration installation status by user.
    - `[Id <String>]`: Read-only.
    - `[DevicesCount <Int32?>]`: Devices count for that user.
    - `[LastReportedDateTime <DateTime?>]`: Last modified date time of the policy report.
    - `[Status <String>]`: complianceStatus
    - `[UserDisplayName <String>]`: User name of the DevicePolicyStatus.
    - `[UserPrincipalName <String>]`: UserPrincipalName.
  - `[Version <Int32?>]`: Version of the device configuration.

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
