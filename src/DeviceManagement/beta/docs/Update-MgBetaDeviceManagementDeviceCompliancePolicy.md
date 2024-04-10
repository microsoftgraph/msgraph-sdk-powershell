---
external help file:
Module Name: Microsoft.Graph.Beta.DeviceManagement
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.devicemanagement/update-mgbetadevicemanagementdevicecompliancepolicy
schema: 2.0.0
---

# Update-MgBetaDeviceManagementDeviceCompliancePolicy

## SYNOPSIS
Update the navigation property deviceCompliancePolicies in deviceManagement

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaDeviceManagementDeviceCompliancePolicy -DeviceCompliancePolicyId <String>
 [-AdditionalProperties <Hashtable>] [-Assignments <IMicrosoftGraphDeviceCompliancePolicyAssignment[]>]
 [-CreatedDateTime <DateTime>] [-Description <String>]
 [-DeviceSettingStateSummaries <IMicrosoftGraphSettingStateDeviceSummary[]>]
 [-DeviceStatuses <IMicrosoftGraphDeviceComplianceDeviceStatus[]>]
 [-DeviceStatusOverview <IMicrosoftGraphDeviceComplianceDeviceOverview>] [-DisplayName <String>]
 [-Id <String>] [-LastModifiedDateTime <DateTime>] [-ResponseHeadersVariable <String>]
 [-RoleScopeTagIds <String[]>]
 [-ScheduledActionsForRule <IMicrosoftGraphDeviceComplianceScheduledActionForRule[]>]
 [-UserStatuses <IMicrosoftGraphDeviceComplianceUserStatus[]>]
 [-UserStatusOverview <IMicrosoftGraphDeviceComplianceUserOverview>] [-Version <Int32>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaDeviceManagementDeviceCompliancePolicy -DeviceCompliancePolicyId <String>
 -BodyParameter <IMicrosoftGraphDeviceCompliancePolicy> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBetaDeviceManagementDeviceCompliancePolicy -InputObject <IDeviceManagementIdentity>
 -BodyParameter <IMicrosoftGraphDeviceCompliancePolicy> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBetaDeviceManagementDeviceCompliancePolicy -InputObject <IDeviceManagementIdentity>
 [-AdditionalProperties <Hashtable>] [-Assignments <IMicrosoftGraphDeviceCompliancePolicyAssignment[]>]
 [-CreatedDateTime <DateTime>] [-Description <String>]
 [-DeviceSettingStateSummaries <IMicrosoftGraphSettingStateDeviceSummary[]>]
 [-DeviceStatuses <IMicrosoftGraphDeviceComplianceDeviceStatus[]>]
 [-DeviceStatusOverview <IMicrosoftGraphDeviceComplianceDeviceOverview>] [-DisplayName <String>]
 [-Id <String>] [-LastModifiedDateTime <DateTime>] [-ResponseHeadersVariable <String>]
 [-RoleScopeTagIds <String[]>]
 [-ScheduledActionsForRule <IMicrosoftGraphDeviceComplianceScheduledActionForRule[]>]
 [-UserStatuses <IMicrosoftGraphDeviceComplianceUserStatus[]>]
 [-UserStatusOverview <IMicrosoftGraphDeviceComplianceUserOverview>] [-Version <Int32>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property deviceCompliancePolicies in deviceManagement

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

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

### -Assignments
The collection of assignments for this compliance policy.
To construct, see NOTES section for ASSIGNMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDeviceCompliancePolicyAssignment[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
This is the base class for Compliance policy.
Compliance policies are platform specific and individual per-platform compliance policies inherit from here.

To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDeviceCompliancePolicy
Parameter Sets: Update, UpdateViaIdentity
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceCompliancePolicyId
The unique identifier of deviceCompliancePolicy

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

### -DeviceSettingStateSummaries
Compliance Setting State Device Summary
To construct, see NOTES section for DEVICESETTINGSTATESUMMARIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSettingStateDeviceSummary[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceStatuses
List of DeviceComplianceDeviceStatus.
To construct, see NOTES section for DEVICESTATUSES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDeviceComplianceDeviceStatus[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceStatusOverview
deviceComplianceDeviceOverview
To construct, see NOTES section for DEVICESTATUSOVERVIEW properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDeviceComplianceDeviceOverview
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Headers
Optional headers that will be added to the request.

```yaml
Type: System.Collections.IDictionary
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Id
The unique identifier for an entity.
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
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IDeviceManagementIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResponseHeadersVariable
Optional Response Headers Variable.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: RHV

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

### -ScheduledActionsForRule
The list of scheduled action per rule for this compliance policy.
This is a required property when creating any individual per-platform compliance policies.
To construct, see NOTES section for SCHEDULEDACTIONSFORRULE properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDeviceComplianceScheduledActionForRule[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserStatuses
List of DeviceComplianceUserStatus.
To construct, see NOTES section for USERSTATUSES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDeviceComplianceUserStatus[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserStatusOverview
deviceComplianceUserOverview
To construct, see NOTES section for USERSTATUSOVERVIEW properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDeviceComplianceUserOverview
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IDeviceManagementIdentity

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDeviceCompliancePolicy

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDeviceCompliancePolicy

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`ASSIGNMENTS <IMicrosoftGraphDeviceCompliancePolicyAssignment[]>`: The collection of assignments for this compliance policy.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Source <DeviceAndAppManagementAssignmentSource?>]`: Represents source of assignment.
  - `[SourceId <String>]`: The identifier of the source of the assignment.
  - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: Base type for assignment targets.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
    - `[DeviceAndAppManagementAssignmentFilterType <DeviceAndAppManagementAssignmentFilterType?>]`: Represents type of the assignment filter.

`BODYPARAMETER <IMicrosoftGraphDeviceCompliancePolicy>`: This is the base class for Compliance policy. Compliance policies are platform specific and individual per-platform compliance policies inherit from here. 
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Assignments <IMicrosoftGraphDeviceCompliancePolicyAssignment[]>]`: The collection of assignments for this compliance policy.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Source <DeviceAndAppManagementAssignmentSource?>]`: Represents source of assignment.
    - `[SourceId <String>]`: The identifier of the source of the assignment.
    - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: Base type for assignment targets.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
      - `[DeviceAndAppManagementAssignmentFilterType <DeviceAndAppManagementAssignmentFilterType?>]`: Represents type of the assignment filter.
  - `[CreatedDateTime <DateTime?>]`: DateTime the object was created.
  - `[Description <String>]`: Admin provided description of the Device Configuration.
  - `[DeviceSettingStateSummaries <IMicrosoftGraphSettingStateDeviceSummary[]>]`: Compliance Setting State Device Summary
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[CompliantDeviceCount <Int32?>]`: Device Compliant count for the setting
    - `[ConflictDeviceCount <Int32?>]`: Device conflict error count for the setting
    - `[ErrorDeviceCount <Int32?>]`: Device error count for the setting
    - `[InstancePath <String>]`: Name of the InstancePath for the setting
    - `[NonCompliantDeviceCount <Int32?>]`: Device NonCompliant count for the setting
    - `[NotApplicableDeviceCount <Int32?>]`: Device Not Applicable count for the setting
    - `[RemediatedDeviceCount <Int32?>]`: Device Compliant count for the setting
    - `[SettingName <String>]`: Name of the setting
    - `[UnknownDeviceCount <Int32?>]`: Device Unkown count for the setting
  - `[DeviceStatusOverview <IMicrosoftGraphDeviceComplianceDeviceOverview>]`: deviceComplianceDeviceOverview
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[ConfigurationVersion <Int32?>]`: Version of the policy for that overview
    - `[ConflictCount <Int32?>]`: Number of devices in conflict
    - `[ErrorCount <Int32?>]`: Number of error devices
    - `[FailedCount <Int32?>]`: Number of failed devices
    - `[LastUpdateDateTime <DateTime?>]`: Last update time
    - `[NotApplicableCount <Int32?>]`: Number of not applicable devices
    - `[NotApplicablePlatformCount <Int32?>]`: Number of not applicable devices due to mismatch platform and policy
    - `[PendingCount <Int32?>]`: Number of pending devices
    - `[SuccessCount <Int32?>]`: Number of succeeded devices
  - `[DeviceStatuses <IMicrosoftGraphDeviceComplianceDeviceStatus[]>]`: List of DeviceComplianceDeviceStatus.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[ComplianceGracePeriodExpirationDateTime <DateTime?>]`: The DateTime when device compliance grace period expires
    - `[DeviceDisplayName <String>]`: Device name of the DevicePolicyStatus.
    - `[DeviceModel <String>]`: The device model that is being reported
    - `[LastReportedDateTime <DateTime?>]`: Last modified date time of the policy report.
    - `[Platform <Int32?>]`: Platform of the device that is being reported
    - `[Status <String>]`: complianceStatus
    - `[UserName <String>]`: The User Name that is being reported
    - `[UserPrincipalName <String>]`: UserPrincipalName.
  - `[DisplayName <String>]`: Admin provided name of the device configuration.
  - `[LastModifiedDateTime <DateTime?>]`: DateTime the object was last modified.
  - `[RoleScopeTagIds <String[]>]`: List of Scope Tags for this Entity instance.
  - `[ScheduledActionsForRule <IMicrosoftGraphDeviceComplianceScheduledActionForRule[]>]`: The list of scheduled action per rule for this compliance policy. This is a required property when creating any individual per-platform compliance policies.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[RuleName <String>]`: Name of the rule which this scheduled action applies to. Currently scheduled actions are created per policy instead of per rule, thus RuleName is always set to default value PasswordRequired.
    - `[ScheduledActionConfigurations <IMicrosoftGraphDeviceComplianceActionItem[]>]`: The list of scheduled action configurations for this compliance policy. Compliance policy must have one and only one block scheduled action.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[ActionType <DeviceComplianceActionType?>]`: Scheduled Action Type Enum
      - `[GracePeriodHours <Int32?>]`: Number of hours to wait till the action will be enforced. Valid values 0 to 8760
      - `[NotificationMessageCcList <String[]>]`: A list of group IDs to speicify who to CC this notification message to.
      - `[NotificationTemplateId <String>]`: What notification Message template to use
  - `[UserStatusOverview <IMicrosoftGraphDeviceComplianceUserOverview>]`: deviceComplianceUserOverview
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[ConfigurationVersion <Int32?>]`: Version of the policy for that overview
    - `[ConflictCount <Int32?>]`: Number of users in conflict
    - `[ErrorCount <Int32?>]`: Number of error Users
    - `[FailedCount <Int32?>]`: Number of failed Users
    - `[LastUpdateDateTime <DateTime?>]`: Last update time
    - `[NotApplicableCount <Int32?>]`: Number of not applicable users
    - `[PendingCount <Int32?>]`: Number of pending Users
    - `[SuccessCount <Int32?>]`: Number of succeeded Users
  - `[UserStatuses <IMicrosoftGraphDeviceComplianceUserStatus[]>]`: List of DeviceComplianceUserStatus.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[DevicesCount <Int32?>]`: Devices count for that user.
    - `[LastReportedDateTime <DateTime?>]`: Last modified date time of the policy report.
    - `[Status <String>]`: complianceStatus
    - `[UserDisplayName <String>]`: User name of the DevicePolicyStatus.
    - `[UserPrincipalName <String>]`: UserPrincipalName.
  - `[Version <Int32?>]`: Version of the device configuration.

`DEVICESETTINGSTATESUMMARIES <IMicrosoftGraphSettingStateDeviceSummary[]>`: Compliance Setting State Device Summary
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[CompliantDeviceCount <Int32?>]`: Device Compliant count for the setting
  - `[ConflictDeviceCount <Int32?>]`: Device conflict error count for the setting
  - `[ErrorDeviceCount <Int32?>]`: Device error count for the setting
  - `[InstancePath <String>]`: Name of the InstancePath for the setting
  - `[NonCompliantDeviceCount <Int32?>]`: Device NonCompliant count for the setting
  - `[NotApplicableDeviceCount <Int32?>]`: Device Not Applicable count for the setting
  - `[RemediatedDeviceCount <Int32?>]`: Device Compliant count for the setting
  - `[SettingName <String>]`: Name of the setting
  - `[UnknownDeviceCount <Int32?>]`: Device Unkown count for the setting

`DEVICESTATUSES <IMicrosoftGraphDeviceComplianceDeviceStatus[]>`: List of DeviceComplianceDeviceStatus.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[ComplianceGracePeriodExpirationDateTime <DateTime?>]`: The DateTime when device compliance grace period expires
  - `[DeviceDisplayName <String>]`: Device name of the DevicePolicyStatus.
  - `[DeviceModel <String>]`: The device model that is being reported
  - `[LastReportedDateTime <DateTime?>]`: Last modified date time of the policy report.
  - `[Platform <Int32?>]`: Platform of the device that is being reported
  - `[Status <String>]`: complianceStatus
  - `[UserName <String>]`: The User Name that is being reported
  - `[UserPrincipalName <String>]`: UserPrincipalName.

`DEVICESTATUSOVERVIEW <IMicrosoftGraphDeviceComplianceDeviceOverview>`: deviceComplianceDeviceOverview
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[ConfigurationVersion <Int32?>]`: Version of the policy for that overview
  - `[ConflictCount <Int32?>]`: Number of devices in conflict
  - `[ErrorCount <Int32?>]`: Number of error devices
  - `[FailedCount <Int32?>]`: Number of failed devices
  - `[LastUpdateDateTime <DateTime?>]`: Last update time
  - `[NotApplicableCount <Int32?>]`: Number of not applicable devices
  - `[NotApplicablePlatformCount <Int32?>]`: Number of not applicable devices due to mismatch platform and policy
  - `[PendingCount <Int32?>]`: Number of pending devices
  - `[SuccessCount <Int32?>]`: Number of succeeded devices

`INPUTOBJECT <IDeviceManagementIdentity>`: Identity Parameter
  - `[AdvancedThreatProtectionOnboardingDeviceSettingStateId <String>]`: The unique identifier of advancedThreatProtectionOnboardingDeviceSettingState
  - `[AlertRecordId <String>]`: The unique identifier of alertRecord
  - `[AlertRuleId <String>]`: The unique identifier of alertRule
  - `[AndroidForWorkAppConfigurationSchemaId <String>]`: The unique identifier of androidForWorkAppConfigurationSchema
  - `[AndroidManagedStoreAppConfigurationSchemaId <String>]`: The unique identifier of androidManagedStoreAppConfigurationSchema
  - `[AppLogCollectionRequestId <String>]`: The unique identifier of appLogCollectionRequest
  - `[AssignmentFilterEvaluationStatusDetailsId <String>]`: The unique identifier of assignmentFilterEvaluationStatusDetails
  - `[BrowserSharedCookieId <String>]`: The unique identifier of browserSharedCookie
  - `[BrowserSiteId <String>]`: The unique identifier of browserSite
  - `[BrowserSiteListId <String>]`: The unique identifier of browserSiteList
  - `[DataSharingConsentId <String>]`: The unique identifier of dataSharingConsent
  - `[DetectedAppId <String>]`: The unique identifier of detectedApp
  - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The unique identifier of deviceAndAppManagementAssignmentFilter
  - `[DeviceCategoryId <String>]`: The unique identifier of deviceCategory
  - `[DeviceComplianceActionItemId <String>]`: The unique identifier of deviceComplianceActionItem
  - `[DeviceComplianceDeviceStatusId <String>]`: The unique identifier of deviceComplianceDeviceStatus
  - `[DeviceCompliancePolicyAssignmentId <String>]`: The unique identifier of deviceCompliancePolicyAssignment
  - `[DeviceCompliancePolicyId <String>]`: The unique identifier of deviceCompliancePolicy
  - `[DeviceCompliancePolicySettingStateSummaryId <String>]`: The unique identifier of deviceCompliancePolicySettingStateSummary
  - `[DeviceCompliancePolicyStateId <String>]`: The unique identifier of deviceCompliancePolicyState
  - `[DeviceComplianceScheduledActionForRuleId <String>]`: The unique identifier of deviceComplianceScheduledActionForRule
  - `[DeviceComplianceSettingStateId <String>]`: The unique identifier of deviceComplianceSettingState
  - `[DeviceComplianceUserStatusId <String>]`: The unique identifier of deviceComplianceUserStatus
  - `[DeviceConfigurationAssignmentId <String>]`: The unique identifier of deviceConfigurationAssignment
  - `[DeviceConfigurationConflictSummaryId <String>]`: The unique identifier of deviceConfigurationConflictSummary
  - `[DeviceConfigurationDeviceStatusId <String>]`: The unique identifier of deviceConfigurationDeviceStatus
  - `[DeviceConfigurationGroupAssignmentId <String>]`: The unique identifier of deviceConfigurationGroupAssignment
  - `[DeviceConfigurationId <String>]`: The unique identifier of deviceConfiguration
  - `[DeviceConfigurationStateId <String>]`: The unique identifier of deviceConfigurationState
  - `[DeviceConfigurationUserStatusId <String>]`: The unique identifier of deviceConfigurationUserStatus
  - `[DeviceHealthScriptAssignmentId <String>]`: The unique identifier of deviceHealthScriptAssignment
  - `[DeviceHealthScriptDeviceStateId <String>]`: The unique identifier of deviceHealthScriptDeviceState
  - `[DeviceHealthScriptId <String>]`: The unique identifier of deviceHealthScript
  - `[DeviceId <String>]`: Property in multi-part unique identifier of deviceHealthScriptPolicyState
  - `[DeviceLogCollectionResponseId <String>]`: The unique identifier of deviceLogCollectionResponse
  - `[DeviceManagementComplianceActionItemId <String>]`: The unique identifier of deviceManagementComplianceActionItem
  - `[DeviceManagementCompliancePolicyId <String>]`: The unique identifier of deviceManagementCompliancePolicy
  - `[DeviceManagementComplianceScheduledActionForRuleId <String>]`: The unique identifier of deviceManagementComplianceScheduledActionForRule
  - `[DeviceManagementConfigurationPolicyAssignmentId <String>]`: The unique identifier of deviceManagementConfigurationPolicyAssignment
  - `[DeviceManagementConfigurationPolicyId <String>]`: The unique identifier of deviceManagementConfigurationPolicy
  - `[DeviceManagementConfigurationPolicyTemplateId <String>]`: The unique identifier of deviceManagementConfigurationPolicyTemplate
  - `[DeviceManagementConfigurationSettingDefinitionId <String>]`: The unique identifier of deviceManagementConfigurationSettingDefinition
  - `[DeviceManagementConfigurationSettingId <String>]`: The unique identifier of deviceManagementConfigurationSetting
  - `[DeviceManagementConfigurationSettingTemplateId <String>]`: The unique identifier of deviceManagementConfigurationSettingTemplate
  - `[DeviceManagementDerivedCredentialSettingsId <String>]`: The unique identifier of deviceManagementDerivedCredentialSettings
  - `[DeviceManagementIntentAssignmentId <String>]`: The unique identifier of deviceManagementIntentAssignment
  - `[DeviceManagementIntentDeviceSettingStateSummaryId <String>]`: The unique identifier of deviceManagementIntentDeviceSettingStateSummary
  - `[DeviceManagementIntentDeviceStateId <String>]`: The unique identifier of deviceManagementIntentDeviceState
  - `[DeviceManagementIntentId <String>]`: The unique identifier of deviceManagementIntent
  - `[DeviceManagementIntentSettingCategoryId <String>]`: The unique identifier of deviceManagementIntentSettingCategory
  - `[DeviceManagementIntentUserStateId <String>]`: The unique identifier of deviceManagementIntentUserState
  - `[DeviceManagementResourceAccessProfileAssignmentId <String>]`: The unique identifier of deviceManagementResourceAccessProfileAssignment
  - `[DeviceManagementResourceAccessProfileBaseId <String>]`: The unique identifier of deviceManagementResourceAccessProfileBase
  - `[DeviceManagementScriptAssignmentId <String>]`: The unique identifier of deviceManagementScriptAssignment
  - `[DeviceManagementScriptDeviceStateId <String>]`: The unique identifier of deviceManagementScriptDeviceState
  - `[DeviceManagementScriptGroupAssignmentId <String>]`: The unique identifier of deviceManagementScriptGroupAssignment
  - `[DeviceManagementScriptId <String>]`: The unique identifier of deviceManagementScript
  - `[DeviceManagementScriptUserStateId <String>]`: The unique identifier of deviceManagementScriptUserState
  - `[DeviceManagementSettingCategoryId <String>]`: The unique identifier of deviceManagementSettingCategory
  - `[DeviceManagementSettingDefinitionId <String>]`: The unique identifier of deviceManagementSettingDefinition
  - `[DeviceManagementSettingInstanceId <String>]`: The unique identifier of deviceManagementSettingInstance
  - `[DeviceManagementTemplateId <String>]`: The unique identifier of deviceManagementTemplate
  - `[DeviceManagementTemplateId1 <String>]`: The unique identifier of deviceManagementTemplate
  - `[DeviceManagementTemplateSettingCategoryId <String>]`: The unique identifier of deviceManagementTemplateSettingCategory
  - `[DeviceManagementTroubleshootingEventId <String>]`: The unique identifier of deviceManagementTroubleshootingEvent
  - `[DeviceShellScriptId <String>]`: The unique identifier of deviceShellScript
  - `[EmbeddedSimActivationCodePoolAssignmentId <String>]`: The unique identifier of embeddedSIMActivationCodePoolAssignment
  - `[EmbeddedSimActivationCodePoolId <String>]`: The unique identifier of embeddedSIMActivationCodePool
  - `[EmbeddedSimDeviceStateId <String>]`: The unique identifier of embeddedSIMDeviceState
  - `[GroupPolicyConfigurationAssignmentId <String>]`: The unique identifier of groupPolicyConfigurationAssignment
  - `[GroupPolicyConfigurationId <String>]`: The unique identifier of groupPolicyConfiguration
  - `[GroupPolicyDefinitionValueId <String>]`: The unique identifier of groupPolicyDefinitionValue
  - `[GroupPolicyPresentationValueId <String>]`: The unique identifier of groupPolicyPresentationValue
  - `[Id <String>]`: Property in multi-part unique identifier of deviceHealthScriptPolicyState
  - `[LocalizedNotificationMessageId <String>]`: The unique identifier of localizedNotificationMessage
  - `[MacOSSoftwareUpdateAccountSummaryId <String>]`: The unique identifier of macOSSoftwareUpdateAccountSummary
  - `[MacOSSoftwareUpdateCategorySummaryId <String>]`: The unique identifier of macOSSoftwareUpdateCategorySummary
  - `[MacOSSoftwareUpdateStateSummaryId <String>]`: The unique identifier of macOSSoftwareUpdateStateSummary
  - `[MalwareStateForWindowsDeviceId <String>]`: The unique identifier of malwareStateForWindowsDevice
  - `[ManagedDeviceCleanupRuleId <String>]`: The unique identifier of managedDeviceCleanupRule
  - `[ManagedDeviceEncryptionStateId <String>]`: The unique identifier of managedDeviceEncryptionState
  - `[ManagedDeviceId <String>]`: The unique identifier of managedDevice
  - `[ManagedDeviceMobileAppConfigurationStateId <String>]`: The unique identifier of managedDeviceMobileAppConfigurationState
  - `[MicrosoftTunnelConfigurationId <String>]`: The unique identifier of microsoftTunnelConfiguration
  - `[MicrosoftTunnelHealthThresholdId <String>]`: The unique identifier of microsoftTunnelHealthThreshold
  - `[MicrosoftTunnelServerId <String>]`: The unique identifier of microsoftTunnelServer
  - `[MicrosoftTunnelServerLogCollectionResponseId <String>]`: The unique identifier of microsoftTunnelServerLogCollectionResponse
  - `[MicrosoftTunnelSiteId <String>]`: The unique identifier of microsoftTunnelSite
  - `[MobileAppTroubleshootingEventId <String>]`: The unique identifier of mobileAppTroubleshootingEvent
  - `[NotificationMessageTemplateId <String>]`: The unique identifier of notificationMessageTemplate
  - `[PolicyId <String>]`: Property in multi-part unique identifier of deviceHealthScriptPolicyState
  - `[RemoteActionAuditId <String>]`: The unique identifier of remoteActionAudit
  - `[SecurityBaselineSettingStateId <String>]`: The unique identifier of securityBaselineSettingState
  - `[SecurityBaselineStateId <String>]`: The unique identifier of securityBaselineState
  - `[SettingStateDeviceSummaryId <String>]`: The unique identifier of settingStateDeviceSummary
  - `[UserExperienceAnalyticsAnomalyCorrelationGroupOverviewId <String>]`: The unique identifier of userExperienceAnalyticsAnomalyCorrelationGroupOverview
  - `[UserExperienceAnalyticsAnomalyDeviceId <String>]`: The unique identifier of userExperienceAnalyticsAnomalyDevice
  - `[UserExperienceAnalyticsAnomalyId <String>]`: The unique identifier of userExperienceAnalyticsAnomaly
  - `[UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDetailsId <String>]`: The unique identifier of userExperienceAnalyticsAppHealthAppPerformanceByAppVersionDetails
  - `[UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId <String>]`: The unique identifier of userExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId
  - `[UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionId <String>]`: The unique identifier of userExperienceAnalyticsAppHealthAppPerformanceByAppVersion
  - `[UserExperienceAnalyticsAppHealthAppPerformanceByOSVersionId <String>]`: The unique identifier of userExperienceAnalyticsAppHealthAppPerformanceByOSVersion
  - `[UserExperienceAnalyticsAppHealthApplicationPerformanceId <String>]`: The unique identifier of userExperienceAnalyticsAppHealthApplicationPerformance
  - `[UserExperienceAnalyticsAppHealthDeviceModelPerformanceId <String>]`: The unique identifier of userExperienceAnalyticsAppHealthDeviceModelPerformance
  - `[UserExperienceAnalyticsAppHealthDevicePerformanceDetailsId <String>]`: The unique identifier of userExperienceAnalyticsAppHealthDevicePerformanceDetails
  - `[UserExperienceAnalyticsAppHealthDevicePerformanceId <String>]`: The unique identifier of userExperienceAnalyticsAppHealthDevicePerformance
  - `[UserExperienceAnalyticsAppHealthOSVersionPerformanceId <String>]`: The unique identifier of userExperienceAnalyticsAppHealthOSVersionPerformance
  - `[UserExperienceAnalyticsBaselineId <String>]`: The unique identifier of userExperienceAnalyticsBaseline
  - `[UserExperienceAnalyticsBatteryHealthAppImpactId <String>]`: The unique identifier of userExperienceAnalyticsBatteryHealthAppImpact
  - `[UserExperienceAnalyticsBatteryHealthDeviceAppImpactId <String>]`: The unique identifier of userExperienceAnalyticsBatteryHealthDeviceAppImpact
  - `[UserExperienceAnalyticsBatteryHealthDevicePerformanceId <String>]`: The unique identifier of userExperienceAnalyticsBatteryHealthDevicePerformance
  - `[UserExperienceAnalyticsBatteryHealthDeviceRuntimeHistoryId <String>]`: The unique identifier of userExperienceAnalyticsBatteryHealthDeviceRuntimeHistory
  - `[UserExperienceAnalyticsBatteryHealthModelPerformanceId <String>]`: The unique identifier of userExperienceAnalyticsBatteryHealthModelPerformance
  - `[UserExperienceAnalyticsBatteryHealthOSPerformanceId <String>]`: The unique identifier of userExperienceAnalyticsBatteryHealthOsPerformance
  - `[UserExperienceAnalyticsCategoryId <String>]`: The unique identifier of userExperienceAnalyticsCategory
  - `[UserExperienceAnalyticsDevicePerformanceId <String>]`: The unique identifier of userExperienceAnalyticsDevicePerformance
  - `[UserExperienceAnalyticsDeviceScopeId <String>]`: The unique identifier of userExperienceAnalyticsDeviceScope
  - `[UserExperienceAnalyticsDeviceScoresId <String>]`: The unique identifier of userExperienceAnalyticsDeviceScores
  - `[UserExperienceAnalyticsDeviceStartupHistoryId <String>]`: The unique identifier of userExperienceAnalyticsDeviceStartupHistory
  - `[UserExperienceAnalyticsDeviceStartupProcessId <String>]`: The unique identifier of userExperienceAnalyticsDeviceStartupProcess
  - `[UserExperienceAnalyticsDeviceStartupProcessPerformanceId <String>]`: The unique identifier of userExperienceAnalyticsDeviceStartupProcessPerformance
  - `[UserExperienceAnalyticsDeviceTimelineEventId <String>]`: The unique identifier of userExperienceAnalyticsDeviceTimelineEvent
  - `[UserExperienceAnalyticsDeviceWithoutCloudIdentityId <String>]`: The unique identifier of userExperienceAnalyticsDeviceWithoutCloudIdentity
  - `[UserExperienceAnalyticsImpactingProcessId <String>]`: The unique identifier of userExperienceAnalyticsImpactingProcess
  - `[UserExperienceAnalyticsMetricHistoryId <String>]`: The unique identifier of userExperienceAnalyticsMetricHistory
  - `[UserExperienceAnalyticsMetricId <String>]`: The unique identifier of userExperienceAnalyticsMetric
  - `[UserExperienceAnalyticsModelScoresId <String>]`: The unique identifier of userExperienceAnalyticsModelScores
  - `[UserExperienceAnalyticsNotAutopilotReadyDeviceId <String>]`: The unique identifier of userExperienceAnalyticsNotAutopilotReadyDevice
  - `[UserExperienceAnalyticsRemoteConnectionId <String>]`: The unique identifier of userExperienceAnalyticsRemoteConnection
  - `[UserExperienceAnalyticsResourcePerformanceId <String>]`: The unique identifier of userExperienceAnalyticsResourcePerformance
  - `[UserExperienceAnalyticsScoreHistoryId <String>]`: The unique identifier of userExperienceAnalyticsScoreHistory
  - `[UserExperienceAnalyticsWorkFromAnywhereDeviceId <String>]`: The unique identifier of userExperienceAnalyticsWorkFromAnywhereDevice
  - `[UserExperienceAnalyticsWorkFromAnywhereMetricId <String>]`: The unique identifier of userExperienceAnalyticsWorkFromAnywhereMetric
  - `[UserExperienceAnalyticsWorkFromAnywhereModelPerformanceId <String>]`: The unique identifier of userExperienceAnalyticsWorkFromAnywhereModelPerformance
  - `[WindowsDeviceMalwareStateId <String>]`: The unique identifier of windowsDeviceMalwareState
  - `[WindowsInformationProtectionAppLearningSummaryId <String>]`: The unique identifier of windowsInformationProtectionAppLearningSummary
  - `[WindowsInformationProtectionNetworkLearningSummaryId <String>]`: The unique identifier of windowsInformationProtectionNetworkLearningSummary
  - `[WindowsMalwareInformationId <String>]`: The unique identifier of windowsMalwareInformation
  - `[WindowsQualityUpdateProfileAssignmentId <String>]`: The unique identifier of windowsQualityUpdateProfileAssignment
  - `[WindowsQualityUpdateProfileId <String>]`: The unique identifier of windowsQualityUpdateProfile

`SCHEDULEDACTIONSFORRULE <IMicrosoftGraphDeviceComplianceScheduledActionForRule[]>`: The list of scheduled action per rule for this compliance policy. This is a required property when creating any individual per-platform compliance policies.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[RuleName <String>]`: Name of the rule which this scheduled action applies to. Currently scheduled actions are created per policy instead of per rule, thus RuleName is always set to default value PasswordRequired.
  - `[ScheduledActionConfigurations <IMicrosoftGraphDeviceComplianceActionItem[]>]`: The list of scheduled action configurations for this compliance policy. Compliance policy must have one and only one block scheduled action.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[ActionType <DeviceComplianceActionType?>]`: Scheduled Action Type Enum
    - `[GracePeriodHours <Int32?>]`: Number of hours to wait till the action will be enforced. Valid values 0 to 8760
    - `[NotificationMessageCcList <String[]>]`: A list of group IDs to speicify who to CC this notification message to.
    - `[NotificationTemplateId <String>]`: What notification Message template to use

`USERSTATUSES <IMicrosoftGraphDeviceComplianceUserStatus[]>`: List of DeviceComplianceUserStatus.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[DevicesCount <Int32?>]`: Devices count for that user.
  - `[LastReportedDateTime <DateTime?>]`: Last modified date time of the policy report.
  - `[Status <String>]`: complianceStatus
  - `[UserDisplayName <String>]`: User name of the DevicePolicyStatus.
  - `[UserPrincipalName <String>]`: UserPrincipalName.

`USERSTATUSOVERVIEW <IMicrosoftGraphDeviceComplianceUserOverview>`: deviceComplianceUserOverview
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[ConfigurationVersion <Int32?>]`: Version of the policy for that overview
  - `[ConflictCount <Int32?>]`: Number of users in conflict
  - `[ErrorCount <Int32?>]`: Number of error Users
  - `[FailedCount <Int32?>]`: Number of failed Users
  - `[LastUpdateDateTime <DateTime?>]`: Last update time
  - `[NotApplicableCount <Int32?>]`: Number of not applicable users
  - `[PendingCount <Int32?>]`: Number of pending Users
  - `[SuccessCount <Int32?>]`: Number of succeeded Users

## RELATED LINKS

