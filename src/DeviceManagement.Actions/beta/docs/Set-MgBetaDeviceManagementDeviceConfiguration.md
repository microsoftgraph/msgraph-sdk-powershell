---
external help file:
Module Name: Microsoft.Graph.Beta.DeviceManagement.Actions
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.devicemanagement.actions/set-mgbetadevicemanagementdeviceconfiguration
schema: 2.0.0
---

# Set-MgBetaDeviceManagementDeviceConfiguration

## SYNOPSIS
Invoke action assign

## SYNTAX

### AssignExpanded (Default)
```
Set-MgBetaDeviceManagementDeviceConfiguration -DeviceConfigurationId <String>
 [-AdditionalProperties <Hashtable>] [-Assignments <IMicrosoftGraphDeviceConfigurationAssignment[]>]
 [-DeviceConfigurationGroupAssignments <IMicrosoftGraphDeviceConfigurationGroupAssignment[]>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Assign
```
Set-MgBetaDeviceManagementDeviceConfiguration -DeviceConfigurationId <String>
 -BodyParameter <IPathsKq4LptDevicemanagementDeviceconfigurationsDeviceconfigurationIdMicrosoftGraphAssignPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### AssignViaIdentity
```
Set-MgBetaDeviceManagementDeviceConfiguration -InputObject <IDeviceManagementActionsIdentity>
 -BodyParameter <IPathsKq4LptDevicemanagementDeviceconfigurationsDeviceconfigurationIdMicrosoftGraphAssignPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### AssignViaIdentityExpanded
```
Set-MgBetaDeviceManagementDeviceConfiguration -InputObject <IDeviceManagementActionsIdentity>
 [-AdditionalProperties <Hashtable>] [-Assignments <IMicrosoftGraphDeviceConfigurationAssignment[]>]
 [-DeviceConfigurationGroupAssignments <IMicrosoftGraphDeviceConfigurationGroupAssignment[]>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action assign

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
Parameter Sets: AssignExpanded, AssignViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Assignments
.
To construct, see NOTES section for ASSIGNMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDeviceConfigurationAssignment[]
Parameter Sets: AssignExpanded, AssignViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IPathsKq4LptDevicemanagementDeviceconfigurationsDeviceconfigurationIdMicrosoftGraphAssignPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Assign, AssignViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DeviceConfigurationGroupAssignments
.
To construct, see NOTES section for DEVICECONFIGURATIONGROUPASSIGNMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDeviceConfigurationGroupAssignment[]
Parameter Sets: AssignExpanded, AssignViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceConfigurationId
The unique identifier of deviceConfiguration

```yaml
Type: System.String
Parameter Sets: Assign, AssignExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IDeviceManagementActionsIdentity
Parameter Sets: AssignViaIdentity, AssignViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### Microsoft.Graph.Beta.PowerShell.Models.IDeviceManagementActionsIdentity

### Microsoft.Graph.Beta.PowerShell.Models.IPathsKq4LptDevicemanagementDeviceconfigurationsDeviceconfigurationIdMicrosoftGraphAssignPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDeviceConfigurationAssignment

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`ASSIGNMENTS <IMicrosoftGraphDeviceConfigurationAssignment[]>`: .
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Intent <DeviceConfigAssignmentIntent?>]`: The administrator intent for the assignment of the profile.
  - `[Source <DeviceAndAppManagementAssignmentSource?>]`: Represents source of assignment.
  - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: Base type for assignment targets.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
    - `[DeviceAndAppManagementAssignmentFilterType <DeviceAndAppManagementAssignmentFilterType?>]`: Represents type of the assignment filter.

`BODYPARAMETER <IPathsKq4LptDevicemanagementDeviceconfigurationsDeviceconfigurationIdMicrosoftGraphAssignPostRequestbodyContentApplicationJsonSchema>`: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Assignments <IMicrosoftGraphDeviceConfigurationAssignment[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Intent <DeviceConfigAssignmentIntent?>]`: The administrator intent for the assignment of the profile.
    - `[Source <DeviceAndAppManagementAssignmentSource?>]`: Represents source of assignment.
    - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: Base type for assignment targets.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
      - `[DeviceAndAppManagementAssignmentFilterType <DeviceAndAppManagementAssignmentFilterType?>]`: Represents type of the assignment filter.
  - `[DeviceConfigurationGroupAssignments <IMicrosoftGraphDeviceConfigurationGroupAssignment[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[DeviceConfiguration <IMicrosoftGraphDeviceConfiguration>]`: Device Configuration.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Assignments <IMicrosoftGraphDeviceConfigurationAssignment[]>]`: The list of assignments for the device configuration profile.
      - `[CreatedDateTime <DateTime?>]`: DateTime the object was created.
      - `[Description <String>]`: Admin provided description of the Device Configuration.
      - `[DeviceManagementApplicabilityRuleDeviceMode <IMicrosoftGraphDeviceManagementApplicabilityRuleDeviceMode>]`: deviceManagementApplicabilityRuleDeviceMode
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DeviceMode <Windows10DeviceModeType?>]`: Windows 10 Device Mode type.
        - `[Name <String>]`: Name for object.
        - `[RuleType <DeviceManagementApplicabilityRuleType?>]`: Supported Applicability rule types for Device Configuration
      - `[DeviceManagementApplicabilityRuleOSEdition <IMicrosoftGraphDeviceManagementApplicabilityRuleOSEdition>]`: deviceManagementApplicabilityRuleOsEdition
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Name <String>]`: Name for object.
        - `[OSEditionTypes <Windows10EditionType[]>]`: Applicability rule OS edition type.
        - `[RuleType <DeviceManagementApplicabilityRuleType?>]`: Supported Applicability rule types for Device Configuration
      - `[DeviceManagementApplicabilityRuleOSVersion <IMicrosoftGraphDeviceManagementApplicabilityRuleOSVersion>]`: deviceManagementApplicabilityRuleOsVersion
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[MaxOSVersion <String>]`: Max OS version for Applicability Rule.
        - `[MinOSVersion <String>]`: Min OS version for Applicability Rule.
        - `[Name <String>]`: Name for object.
        - `[RuleType <DeviceManagementApplicabilityRuleType?>]`: Supported Applicability rule types for Device Configuration
      - `[DeviceSettingStateSummaries <IMicrosoftGraphSettingStateDeviceSummary[]>]`: Device Configuration Setting State Device Summary
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
      - `[DeviceStatusOverview <IMicrosoftGraphDeviceConfigurationDeviceOverview>]`: deviceConfigurationDeviceOverview
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
      - `[DeviceStatuses <IMicrosoftGraphDeviceConfigurationDeviceStatus[]>]`: Device configuration installation status by device.
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
      - `[GroupAssignments <IMicrosoftGraphDeviceConfigurationGroupAssignment[]>]`: The list of group assignments for the device configuration profile.
      - `[LastModifiedDateTime <DateTime?>]`: DateTime the object was last modified.
      - `[RoleScopeTagIds <String[]>]`: List of Scope Tags for this Entity instance.
      - `[UserStatusOverview <IMicrosoftGraphDeviceConfigurationUserOverview>]`: deviceConfigurationUserOverview
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
      - `[UserStatuses <IMicrosoftGraphDeviceConfigurationUserStatus[]>]`: Device configuration installation status by user.
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
        - `[DevicesCount <Int32?>]`: Devices count for that user.
        - `[LastReportedDateTime <DateTime?>]`: Last modified date time of the policy report.
        - `[Status <String>]`: complianceStatus
        - `[UserDisplayName <String>]`: User name of the DevicePolicyStatus.
        - `[UserPrincipalName <String>]`: UserPrincipalName.
      - `[Version <Int32?>]`: Version of the device configuration.
    - `[ExcludeGroup <Boolean?>]`: Indicates if this group is should be excluded. Defaults that the group should be included
    - `[TargetGroupId <String>]`: The Id of the AAD group we are targeting the device configuration to.

`DEVICECONFIGURATIONGROUPASSIGNMENTS <IMicrosoftGraphDeviceConfigurationGroupAssignment[]>`: .
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[DeviceConfiguration <IMicrosoftGraphDeviceConfiguration>]`: Device Configuration.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Assignments <IMicrosoftGraphDeviceConfigurationAssignment[]>]`: The list of assignments for the device configuration profile.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Intent <DeviceConfigAssignmentIntent?>]`: The administrator intent for the assignment of the profile.
      - `[Source <DeviceAndAppManagementAssignmentSource?>]`: Represents source of assignment.
      - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: Base type for assignment targets.
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
        - `[DeviceAndAppManagementAssignmentFilterType <DeviceAndAppManagementAssignmentFilterType?>]`: Represents type of the assignment filter.
    - `[CreatedDateTime <DateTime?>]`: DateTime the object was created.
    - `[Description <String>]`: Admin provided description of the Device Configuration.
    - `[DeviceManagementApplicabilityRuleDeviceMode <IMicrosoftGraphDeviceManagementApplicabilityRuleDeviceMode>]`: deviceManagementApplicabilityRuleDeviceMode
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DeviceMode <Windows10DeviceModeType?>]`: Windows 10 Device Mode type.
      - `[Name <String>]`: Name for object.
      - `[RuleType <DeviceManagementApplicabilityRuleType?>]`: Supported Applicability rule types for Device Configuration
    - `[DeviceManagementApplicabilityRuleOSEdition <IMicrosoftGraphDeviceManagementApplicabilityRuleOSEdition>]`: deviceManagementApplicabilityRuleOsEdition
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Name <String>]`: Name for object.
      - `[OSEditionTypes <Windows10EditionType[]>]`: Applicability rule OS edition type.
      - `[RuleType <DeviceManagementApplicabilityRuleType?>]`: Supported Applicability rule types for Device Configuration
    - `[DeviceManagementApplicabilityRuleOSVersion <IMicrosoftGraphDeviceManagementApplicabilityRuleOSVersion>]`: deviceManagementApplicabilityRuleOsVersion
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[MaxOSVersion <String>]`: Max OS version for Applicability Rule.
      - `[MinOSVersion <String>]`: Min OS version for Applicability Rule.
      - `[Name <String>]`: Name for object.
      - `[RuleType <DeviceManagementApplicabilityRuleType?>]`: Supported Applicability rule types for Device Configuration
    - `[DeviceSettingStateSummaries <IMicrosoftGraphSettingStateDeviceSummary[]>]`: Device Configuration Setting State Device Summary
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
    - `[DeviceStatusOverview <IMicrosoftGraphDeviceConfigurationDeviceOverview>]`: deviceConfigurationDeviceOverview
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
    - `[DeviceStatuses <IMicrosoftGraphDeviceConfigurationDeviceStatus[]>]`: Device configuration installation status by device.
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
    - `[GroupAssignments <IMicrosoftGraphDeviceConfigurationGroupAssignment[]>]`: The list of group assignments for the device configuration profile.
    - `[LastModifiedDateTime <DateTime?>]`: DateTime the object was last modified.
    - `[RoleScopeTagIds <String[]>]`: List of Scope Tags for this Entity instance.
    - `[UserStatusOverview <IMicrosoftGraphDeviceConfigurationUserOverview>]`: deviceConfigurationUserOverview
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
    - `[UserStatuses <IMicrosoftGraphDeviceConfigurationUserStatus[]>]`: Device configuration installation status by user.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[DevicesCount <Int32?>]`: Devices count for that user.
      - `[LastReportedDateTime <DateTime?>]`: Last modified date time of the policy report.
      - `[Status <String>]`: complianceStatus
      - `[UserDisplayName <String>]`: User name of the DevicePolicyStatus.
      - `[UserPrincipalName <String>]`: UserPrincipalName.
    - `[Version <Int32?>]`: Version of the device configuration.
  - `[ExcludeGroup <Boolean?>]`: Indicates if this group is should be excluded. Defaults that the group should be included
  - `[TargetGroupId <String>]`: The Id of the AAD group we are targeting the device configuration to.

`INPUTOBJECT <IDeviceManagementActionsIdentity>`: Identity Parameter
  - `[AlertRecordId <String>]`: The unique identifier of alertRecord
  - `[AndroidDeviceOwnerEnrollmentProfileId <String>]`: The unique identifier of androidDeviceOwnerEnrollmentProfile
  - `[AndroidForWorkEnrollmentProfileId <String>]`: The unique identifier of androidForWorkEnrollmentProfile
  - `[AppLogCollectionRequestId <String>]`: The unique identifier of appLogCollectionRequest
  - `[AppleUserInitiatedEnrollmentProfileId <String>]`: The unique identifier of appleUserInitiatedEnrollmentProfile
  - `[CertificateConnectorDetailsId <String>]`: The unique identifier of certificateConnectorDetails
  - `[CloudPcDeviceImageId <String>]`: The unique identifier of cloudPcDeviceImage
  - `[CloudPcId <String>]`: The unique identifier of cloudPC
  - `[CloudPcOnPremisesConnectionId <String>]`: The unique identifier of cloudPcOnPremisesConnection
  - `[CloudPcProvisioningPolicyId <String>]`: The unique identifier of cloudPcProvisioningPolicy
  - `[CloudPcUserSettingId <String>]`: The unique identifier of cloudPcUserSetting
  - `[DataSharingConsentId <String>]`: The unique identifier of dataSharingConsent
  - `[DepOnboardingSettingId <String>]`: The unique identifier of depOnboardingSetting
  - `[DeviceCompliancePolicyId <String>]`: The unique identifier of deviceCompliancePolicy
  - `[DeviceComplianceScriptId <String>]`: The unique identifier of deviceComplianceScript
  - `[DeviceConfigurationId <String>]`: The unique identifier of deviceConfiguration
  - `[DeviceCustomAttributeShellScriptId <String>]`: The unique identifier of deviceCustomAttributeShellScript
  - `[DeviceEnrollmentConfigurationId <String>]`: The unique identifier of deviceEnrollmentConfiguration
  - `[DeviceHealthScriptId <String>]`: The unique identifier of deviceHealthScript
  - `[DeviceLogCollectionResponseId <String>]`: The unique identifier of deviceLogCollectionResponse
  - `[DeviceManagementCompliancePolicyId <String>]`: The unique identifier of deviceManagementCompliancePolicy
  - `[DeviceManagementConfigurationPolicyId <String>]`: The unique identifier of deviceManagementConfigurationPolicy
  - `[DeviceManagementExchangeConnectorId <String>]`: The unique identifier of deviceManagementExchangeConnector
  - `[DeviceManagementIntentId <String>]`: The unique identifier of deviceManagementIntent
  - `[DeviceManagementPartnerId <String>]`: The unique identifier of deviceManagementPartner
  - `[DeviceManagementResourceAccessProfileBaseId <String>]`: The unique identifier of deviceManagementResourceAccessProfileBase
  - `[DeviceManagementReusablePolicySettingId <String>]`: The unique identifier of deviceManagementReusablePolicySetting
  - `[DeviceManagementScriptId <String>]`: The unique identifier of deviceManagementScript
  - `[DeviceManagementTemplateId <String>]`: The unique identifier of deviceManagementTemplate
  - `[DeviceManagementTemplateId1 <String>]`: The unique identifier of deviceManagementTemplate
  - `[DeviceShellScriptId <String>]`: The unique identifier of deviceShellScript
  - `[EmbeddedSimActivationCodePoolId <String>]`: The unique identifier of embeddedSIMActivationCodePool
  - `[EnrollmentProfileId <String>]`: The unique identifier of enrollmentProfile
  - `[GroupPolicyConfigurationId <String>]`: The unique identifier of groupPolicyConfiguration
  - `[GroupPolicyMigrationReportId <String>]`: The unique identifier of groupPolicyMigrationReport
  - `[GroupPolicyUploadedDefinitionFileId <String>]`: The unique identifier of groupPolicyUploadedDefinitionFile
  - `[IntuneBrandingProfileId <String>]`: The unique identifier of intuneBrandingProfile
  - `[ManagedDeviceId <String>]`: The unique identifier of managedDevice
  - `[MicrosoftTunnelServerId <String>]`: The unique identifier of microsoftTunnelServer
  - `[MicrosoftTunnelServerLogCollectionResponseId <String>]`: The unique identifier of microsoftTunnelServerLogCollectionResponse
  - `[MicrosoftTunnelSiteId <String>]`: The unique identifier of microsoftTunnelSite
  - `[MobileAppTroubleshootingEventId <String>]`: The unique identifier of mobileAppTroubleshootingEvent
  - `[NotificationMessageTemplateId <String>]`: The unique identifier of notificationMessageTemplate
  - `[RemoteAssistancePartnerId <String>]`: The unique identifier of remoteAssistancePartner
  - `[RoleScopeTagId <String>]`: The unique identifier of roleScopeTag
  - `[WindowsAutopilotDeploymentProfileId <String>]`: The unique identifier of windowsAutopilotDeploymentProfile
  - `[WindowsAutopilotDeviceIdentityId <String>]`: The unique identifier of windowsAutopilotDeviceIdentity
  - `[WindowsDriverUpdateProfileId <String>]`: The unique identifier of windowsDriverUpdateProfile
  - `[WindowsFeatureUpdateProfileId <String>]`: The unique identifier of windowsFeatureUpdateProfile
  - `[WindowsQualityUpdateProfileId <String>]`: The unique identifier of windowsQualityUpdateProfile
  - `[ZebraFotaDeploymentId <String>]`: The unique identifier of zebraFotaDeployment

## RELATED LINKS

