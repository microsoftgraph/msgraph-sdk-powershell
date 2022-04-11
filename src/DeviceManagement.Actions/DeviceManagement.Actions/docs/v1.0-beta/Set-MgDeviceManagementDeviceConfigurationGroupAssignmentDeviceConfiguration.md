---
external help file:
Module Name: Microsoft.Graph.DeviceManagement.Actions
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.actions/set-mgdevicemanagementdeviceconfigurationgroupassignmentdeviceconfiguration
schema: 2.0.0
---

# Set-MgDeviceManagementDeviceConfigurationGroupAssignmentDeviceConfiguration

## SYNOPSIS
Invoke action assign

## SYNTAX

### AssignExpanded (Default)
```
Set-MgDeviceManagementDeviceConfigurationGroupAssignmentDeviceConfiguration
 -DeviceConfigurationGroupAssignmentId <String> -DeviceConfigurationId <String>
 [-AdditionalProperties <Hashtable>] [-Assignments <IMicrosoftGraphDeviceConfigurationAssignment1[]>]
 [-DeviceConfigurationGroupAssignments <IMicrosoftGraphDeviceConfigurationGroupAssignment[]>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Assign
```
Set-MgDeviceManagementDeviceConfigurationGroupAssignmentDeviceConfiguration
 -DeviceConfigurationGroupAssignmentId <String> -DeviceConfigurationId <String>
 -BodyParameter <IPaths35Cy05DevicemanagementDeviceconfigurationsDeviceconfigurationIdGroupassignmentsDeviceconfigurationgroupassignmentIdDeviceconfigurationMicrosoftGraphAssignPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### AssignViaIdentity
```
Set-MgDeviceManagementDeviceConfigurationGroupAssignmentDeviceConfiguration
 -InputObject <IDeviceManagementActionsIdentity>
 -BodyParameter <IPaths35Cy05DevicemanagementDeviceconfigurationsDeviceconfigurationIdGroupassignmentsDeviceconfigurationgroupassignmentIdDeviceconfigurationMicrosoftGraphAssignPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### AssignViaIdentityExpanded
```
Set-MgDeviceManagementDeviceConfigurationGroupAssignmentDeviceConfiguration
 -InputObject <IDeviceManagementActionsIdentity> [-AdditionalProperties <Hashtable>]
 [-Assignments <IMicrosoftGraphDeviceConfigurationAssignment1[]>]
 [-DeviceConfigurationGroupAssignments <IMicrosoftGraphDeviceConfigurationGroupAssignment[]>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action assign

## EXAMPLES

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
To construct, please use Get-Help -Online and see NOTES section for ASSIGNMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceConfigurationAssignment1[]
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
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IPaths35Cy05DevicemanagementDeviceconfigurationsDeviceconfigurationIdGroupassignmentsDeviceconfigurationgroupassignmentIdDeviceconfigurationMicrosoftGraphAssignPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Assign, AssignViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DeviceConfigurationGroupAssignmentId
key: id of deviceConfigurationGroupAssignment

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

### -DeviceConfigurationGroupAssignments
.
To construct, please use Get-Help -Online and see NOTES section for DEVICECONFIGURATIONGROUPASSIGNMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceConfigurationGroupAssignment[]
Parameter Sets: AssignExpanded, AssignViaIdentityExpanded
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
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IDeviceManagementActionsIdentity
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

### Microsoft.Graph.PowerShell.Models.IDeviceManagementActionsIdentity

### Microsoft.Graph.PowerShell.Models.IPaths35Cy05DevicemanagementDeviceconfigurationsDeviceconfigurationIdGroupassignmentsDeviceconfigurationgroupassignmentIdDeviceconfigurationMicrosoftGraphAssignPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceConfigurationAssignment1

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ASSIGNMENTS <IMicrosoftGraphDeviceConfigurationAssignment1[]>: .
  - `[Id <String>]`: Read-only.
  - `[Intent <String>]`: The administrator intent for the assignment of the profile.
  - `[Source <String>]`: Represents source of assignment.
  - `[SourceId <String>]`: The identifier of the source of the assignment. This property is read-only.
  - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget1>]`: Base type for assignment targets.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
    - `[DeviceAndAppManagementAssignmentFilterType <String>]`: Represents type of the assignment filter.

BODYPARAMETER <IPaths35Cy05DevicemanagementDeviceconfigurationsDeviceconfigurationIdGroupassignmentsDeviceconfigurationgroupassignmentIdDeviceconfigurationMicrosoftGraphAssignPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Assignments <IMicrosoftGraphDeviceConfigurationAssignment1[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Intent <String>]`: The administrator intent for the assignment of the profile.
    - `[Source <String>]`: Represents source of assignment.
    - `[SourceId <String>]`: The identifier of the source of the assignment. This property is read-only.
    - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget1>]`: Base type for assignment targets.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
      - `[DeviceAndAppManagementAssignmentFilterType <String>]`: Represents type of the assignment filter.
  - `[DeviceConfigurationGroupAssignments <IMicrosoftGraphDeviceConfigurationGroupAssignment[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[DeviceConfiguration <IMicrosoftGraphDeviceConfiguration>]`: Device Configuration.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[Assignments <IMicrosoftGraphDeviceConfigurationAssignment1[]>]`: The list of assignments for the device configuration profile.
      - `[CreatedDateTime <DateTime?>]`: DateTime the object was created.
      - `[Description <String>]`: Admin provided description of the Device Configuration.
      - `[DeviceManagementApplicabilityRuleDeviceMode <IMicrosoftGraphDeviceManagementApplicabilityRuleDeviceMode>]`: deviceManagementApplicabilityRuleDeviceMode
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DeviceMode <String>]`: Windows 10 Device Mode type.
        - `[Name <String>]`: Name for object.
        - `[RuleType <String>]`: Supported Applicability rule types for Device Configuration
      - `[DeviceManagementApplicabilityRuleOSEdition <IMicrosoftGraphDeviceManagementApplicabilityRuleOSEdition>]`: deviceManagementApplicabilityRuleOsEdition
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Name <String>]`: Name for object.
        - `[OSEditionTypes <String[]>]`: Applicability rule OS edition type.
        - `[RuleType <String>]`: Supported Applicability rule types for Device Configuration
      - `[DeviceManagementApplicabilityRuleOSVersion <IMicrosoftGraphDeviceManagementApplicabilityRuleOSVersion>]`: deviceManagementApplicabilityRuleOsVersion
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[MaxOSVersion <String>]`: Max OS version for Applicability Rule.
        - `[MinOSVersion <String>]`: Min OS version for Applicability Rule.
        - `[Name <String>]`: Name for object.
        - `[RuleType <String>]`: Supported Applicability rule types for Device Configuration
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
      - `[DeviceStatusOverview <IMicrosoftGraphDeviceConfigurationDeviceOverview>]`: deviceConfigurationDeviceOverview
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
      - `[DeviceStatuses <IMicrosoftGraphDeviceConfigurationDeviceStatus[]>]`: Device configuration installation status by device.
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
      - `[UserStatusOverview <IMicrosoftGraphDeviceConfigurationUserOverview>]`: deviceConfigurationUserOverview
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

DEVICECONFIGURATIONGROUPASSIGNMENTS <IMicrosoftGraphDeviceConfigurationGroupAssignment[]>: .
  - `[Id <String>]`: Read-only.
  - `[DeviceConfiguration <IMicrosoftGraphDeviceConfiguration>]`: Device Configuration.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[Assignments <IMicrosoftGraphDeviceConfigurationAssignment1[]>]`: The list of assignments for the device configuration profile.
      - `[Id <String>]`: Read-only.
      - `[Intent <String>]`: The administrator intent for the assignment of the profile.
      - `[Source <String>]`: Represents source of assignment.
      - `[SourceId <String>]`: The identifier of the source of the assignment. This property is read-only.
      - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget1>]`: Base type for assignment targets.
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
        - `[DeviceAndAppManagementAssignmentFilterType <String>]`: Represents type of the assignment filter.
    - `[CreatedDateTime <DateTime?>]`: DateTime the object was created.
    - `[Description <String>]`: Admin provided description of the Device Configuration.
    - `[DeviceManagementApplicabilityRuleDeviceMode <IMicrosoftGraphDeviceManagementApplicabilityRuleDeviceMode>]`: deviceManagementApplicabilityRuleDeviceMode
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DeviceMode <String>]`: Windows 10 Device Mode type.
      - `[Name <String>]`: Name for object.
      - `[RuleType <String>]`: Supported Applicability rule types for Device Configuration
    - `[DeviceManagementApplicabilityRuleOSEdition <IMicrosoftGraphDeviceManagementApplicabilityRuleOSEdition>]`: deviceManagementApplicabilityRuleOsEdition
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Name <String>]`: Name for object.
      - `[OSEditionTypes <String[]>]`: Applicability rule OS edition type.
      - `[RuleType <String>]`: Supported Applicability rule types for Device Configuration
    - `[DeviceManagementApplicabilityRuleOSVersion <IMicrosoftGraphDeviceManagementApplicabilityRuleOSVersion>]`: deviceManagementApplicabilityRuleOsVersion
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[MaxOSVersion <String>]`: Max OS version for Applicability Rule.
      - `[MinOSVersion <String>]`: Min OS version for Applicability Rule.
      - `[Name <String>]`: Name for object.
      - `[RuleType <String>]`: Supported Applicability rule types for Device Configuration
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
    - `[DeviceStatusOverview <IMicrosoftGraphDeviceConfigurationDeviceOverview>]`: deviceConfigurationDeviceOverview
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
    - `[DeviceStatuses <IMicrosoftGraphDeviceConfigurationDeviceStatus[]>]`: Device configuration installation status by device.
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
    - `[UserStatusOverview <IMicrosoftGraphDeviceConfigurationUserOverview>]`: deviceConfigurationUserOverview
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

INPUTOBJECT <IDeviceManagementActionsIdentity>: Identity Parameter
  - `[AndroidDeviceOwnerEnrollmentProfileId <String>]`: key: id of androidDeviceOwnerEnrollmentProfile
  - `[AndroidForWorkEnrollmentProfileId <String>]`: key: id of androidForWorkEnrollmentProfile
  - `[AppLogCollectionRequestId <String>]`: key: id of appLogCollectionRequest
  - `[AppleUserInitiatedEnrollmentProfileId <String>]`: key: id of appleUserInitiatedEnrollmentProfile
  - `[CertificateConnectorDetailsId <String>]`: key: id of certificateConnectorDetails
  - `[CloudPcDeviceImageId <String>]`: key: id of cloudPcDeviceImage
  - `[CloudPcId <String>]`: key: id of cloudPC
  - `[CloudPcOnPremisesConnectionId <String>]`: key: id of cloudPcOnPremisesConnection
  - `[CloudPcProvisioningPolicyId <String>]`: key: id of cloudPcProvisioningPolicy
  - `[CloudPcUserSettingId <String>]`: key: id of cloudPcUserSetting
  - `[DataSharingConsentId <String>]`: key: id of dataSharingConsent
  - `[DepOnboardingSettingId <String>]`: key: id of depOnboardingSetting
  - `[DetectedAppId <String>]`: key: id of detectedApp
  - `[DeviceAndAppManagementRoleAssignmentId <String>]`: key: id of deviceAndAppManagementRoleAssignment
  - `[DeviceCompliancePolicyId <String>]`: key: id of deviceCompliancePolicy
  - `[DeviceComplianceScriptId <String>]`: key: id of deviceComplianceScript
  - `[DeviceConfigurationGroupAssignmentId <String>]`: key: id of deviceConfigurationGroupAssignment
  - `[DeviceConfigurationId <String>]`: key: id of deviceConfiguration
  - `[DeviceCustomAttributeShellScriptId <String>]`: key: id of deviceCustomAttributeShellScript
  - `[DeviceEnrollmentConfigurationId <String>]`: key: id of deviceEnrollmentConfiguration
  - `[DeviceHealthScriptDeviceStateId <String>]`: key: id of deviceHealthScriptDeviceState
  - `[DeviceHealthScriptId <String>]`: key: id of deviceHealthScript
  - `[DeviceLogCollectionResponseId <String>]`: key: id of deviceLogCollectionResponse
  - `[DeviceManagementCompliancePolicyId <String>]`: key: id of deviceManagementCompliancePolicy
  - `[DeviceManagementConfigurationPolicyId <String>]`: key: id of deviceManagementConfigurationPolicy
  - `[DeviceManagementExchangeConnectorId <String>]`: key: id of deviceManagementExchangeConnector
  - `[DeviceManagementIntentId <String>]`: key: id of deviceManagementIntent
  - `[DeviceManagementResourceAccessProfileBaseId <String>]`: key: id of deviceManagementResourceAccessProfileBase
  - `[DeviceManagementReusablePolicySettingId <String>]`: key: id of deviceManagementReusablePolicySetting
  - `[DeviceManagementScriptDeviceStateId <String>]`: key: id of deviceManagementScriptDeviceState
  - `[DeviceManagementScriptId <String>]`: key: id of deviceManagementScript
  - `[DeviceManagementTemplateId <String>]`: key: id of deviceManagementTemplate
  - `[DeviceManagementTemplateId1 <String>]`: key: id of deviceManagementTemplate
  - `[DeviceShellScriptId <String>]`: key: id of deviceShellScript
  - `[EmbeddedSimActivationCodePoolId <String>]`: key: id of embeddedSIMActivationCodePool
  - `[EnrollmentProfileId <String>]`: key: id of enrollmentProfile
  - `[GroupPolicyConfigurationId <String>]`: key: id of groupPolicyConfiguration
  - `[GroupPolicyUploadedDefinitionFileId <String>]`: key: id of groupPolicyUploadedDefinitionFile
  - `[IntuneBrandingProfileId <String>]`: key: id of intuneBrandingProfile
  - `[ManagedDeviceId <String>]`: key: id of managedDevice
  - `[MicrosoftTunnelServerId <String>]`: key: id of microsoftTunnelServer
  - `[MicrosoftTunnelServerLogCollectionResponseId <String>]`: key: id of microsoftTunnelServerLogCollectionResponse
  - `[MicrosoftTunnelSiteId <String>]`: key: id of microsoftTunnelSite
  - `[MobileAppTroubleshootingEventId <String>]`: key: id of mobileAppTroubleshootingEvent
  - `[NotificationMessageTemplateId <String>]`: key: id of notificationMessageTemplate
  - `[OemWarrantyInformationOnboardingId <String>]`: key: id of oemWarrantyInformationOnboarding
  - `[RemoteAssistancePartnerId <String>]`: key: id of remoteAssistancePartner
  - `[RoleScopeTagId <String>]`: key: id of roleScopeTag
  - `[WindowsAutopilotDeploymentProfileId <String>]`: key: id of windowsAutopilotDeploymentProfile
  - `[WindowsAutopilotDeviceIdentityId <String>]`: key: id of windowsAutopilotDeviceIdentity
  - `[WindowsDriverUpdateProfileId <String>]`: key: id of windowsDriverUpdateProfile
  - `[WindowsFeatureUpdateProfileId <String>]`: key: id of windowsFeatureUpdateProfile
  - `[WindowsQualityUpdateProfileId <String>]`: key: id of windowsQualityUpdateProfile

## RELATED LINKS

