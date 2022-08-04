---
external help file:
Module Name: Microsoft.Graph.DeviceManagement.Actions
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.actions/invoke-mgscheduledevicemanagementdevicecompliancepolicyactionforrule
schema: 2.0.0
---

# Invoke-MgScheduleDeviceManagementDeviceCompliancePolicyActionForRule

## SYNOPSIS
Invoke action scheduleActionsForRules

## SYNTAX

### ScheduleExpanded1 (Default)
```
Invoke-MgScheduleDeviceManagementDeviceCompliancePolicyActionForRule -DeviceCompliancePolicyId <String>
 [-AdditionalProperties <Hashtable>]
 [-DeviceComplianceScheduledActionForRules <IMicrosoftGraphDeviceComplianceScheduledActionForRule1[]>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Schedule1
```
Invoke-MgScheduleDeviceManagementDeviceCompliancePolicyActionForRule -DeviceCompliancePolicyId <String>
 -BodyParameter <IPathsY039HhDevicemanagementDevicecompliancepoliciesDevicecompliancepolicyIdMicrosoftGraphScheduleactionsforrulesPostRequestbodyContentApplicationJsonSchema1>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ScheduleViaIdentity1
```
Invoke-MgScheduleDeviceManagementDeviceCompliancePolicyActionForRule
 -InputObject <IDeviceManagementActionsIdentity>
 -BodyParameter <IPathsY039HhDevicemanagementDevicecompliancepoliciesDevicecompliancepolicyIdMicrosoftGraphScheduleactionsforrulesPostRequestbodyContentApplicationJsonSchema1>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ScheduleViaIdentityExpanded1
```
Invoke-MgScheduleDeviceManagementDeviceCompliancePolicyActionForRule
 -InputObject <IDeviceManagementActionsIdentity> [-AdditionalProperties <Hashtable>]
 [-DeviceComplianceScheduledActionForRules <IMicrosoftGraphDeviceComplianceScheduledActionForRule1[]>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action scheduleActionsForRules

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: ScheduleExpanded1, ScheduleViaIdentityExpanded1
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
Type: Microsoft.Graph.PowerShell.Models.IPathsY039HhDevicemanagementDevicecompliancepoliciesDevicecompliancepolicyIdMicrosoftGraphScheduleactionsforrulesPostRequestbodyContentApplicationJsonSchema1
Parameter Sets: Schedule1, ScheduleViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DeviceCompliancePolicyId
key: id of deviceCompliancePolicy

```yaml
Type: System.String
Parameter Sets: Schedule1, ScheduleExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceComplianceScheduledActionForRules
.
To construct, please use Get-Help -Online and see NOTES section for DEVICECOMPLIANCESCHEDULEDACTIONFORRULES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceComplianceScheduledActionForRule1[]
Parameter Sets: ScheduleExpanded1, ScheduleViaIdentityExpanded1
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
Type: Microsoft.Graph.PowerShell.Models.IDeviceManagementActionsIdentity
Parameter Sets: ScheduleViaIdentity1, ScheduleViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### Microsoft.Graph.PowerShell.Models.IPathsY039HhDevicemanagementDevicecompliancepoliciesDevicecompliancepolicyIdMicrosoftGraphScheduleactionsforrulesPostRequestbodyContentApplicationJsonSchema1

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPathsY039HhDevicemanagementDevicecompliancepoliciesDevicecompliancepolicyIdMicrosoftGraphScheduleactionsforrulesPostRequestbodyContentApplicationJsonSchema1>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DeviceComplianceScheduledActionForRules <IMicrosoftGraphDeviceComplianceScheduledActionForRule1[]>]`: 
    - `[Id <String>]`: 
    - `[RuleName <String>]`: Name of the rule which this scheduled action applies to. Currently scheduled actions are created per policy instead of per rule, thus RuleName is always set to default value PasswordRequired.
    - `[ScheduledActionConfigurations <IMicrosoftGraphDeviceComplianceActionItem1[]>]`: The list of scheduled action configurations for this compliance policy. Compliance policy must have one and only one block scheduled action.
      - `[Id <String>]`: 
      - `[ActionType <DeviceComplianceActionType?>]`: Scheduled Action Type Enum
      - `[GracePeriodHours <Int32?>]`: Number of hours to wait till the action will be enforced. Valid values 0 to 8760
      - `[NotificationMessageCcList <String[]>]`: A list of group IDs to speicify who to CC this notification message to.
      - `[NotificationTemplateId <String>]`: What notification Message template to use

DEVICECOMPLIANCESCHEDULEDACTIONFORRULES <IMicrosoftGraphDeviceComplianceScheduledActionForRule1[]>: .
  - `[Id <String>]`: 
  - `[RuleName <String>]`: Name of the rule which this scheduled action applies to. Currently scheduled actions are created per policy instead of per rule, thus RuleName is always set to default value PasswordRequired.
  - `[ScheduledActionConfigurations <IMicrosoftGraphDeviceComplianceActionItem1[]>]`: The list of scheduled action configurations for this compliance policy. Compliance policy must have one and only one block scheduled action.
    - `[Id <String>]`: 
    - `[ActionType <DeviceComplianceActionType?>]`: Scheduled Action Type Enum
    - `[GracePeriodHours <Int32?>]`: Number of hours to wait till the action will be enforced. Valid values 0 to 8760
    - `[NotificationMessageCcList <String[]>]`: A list of group IDs to speicify who to CC this notification message to.
    - `[NotificationTemplateId <String>]`: What notification Message template to use

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
  - `[DeviceCompliancePolicyId <String>]`: key: id of deviceCompliancePolicy
  - `[DeviceComplianceScriptId <String>]`: key: id of deviceComplianceScript
  - `[DeviceConfigurationId <String>]`: key: id of deviceConfiguration
  - `[DeviceCustomAttributeShellScriptId <String>]`: key: id of deviceCustomAttributeShellScript
  - `[DeviceEnrollmentConfigurationId <String>]`: key: id of deviceEnrollmentConfiguration
  - `[DeviceHealthScriptId <String>]`: key: id of deviceHealthScript
  - `[DeviceLogCollectionResponseId <String>]`: key: id of deviceLogCollectionResponse
  - `[DeviceManagementCompliancePolicyId <String>]`: key: id of deviceManagementCompliancePolicy
  - `[DeviceManagementConfigurationPolicyId <String>]`: key: id of deviceManagementConfigurationPolicy
  - `[DeviceManagementExchangeConnectorId <String>]`: key: id of deviceManagementExchangeConnector
  - `[DeviceManagementIntentId <String>]`: key: id of deviceManagementIntent
  - `[DeviceManagementResourceAccessProfileBaseId <String>]`: key: id of deviceManagementResourceAccessProfileBase
  - `[DeviceManagementReusablePolicySettingId <String>]`: key: id of deviceManagementReusablePolicySetting
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
  - `[ZebraFotaDeploymentId <String>]`: key: id of zebraFotaDeployment

## RELATED LINKS

