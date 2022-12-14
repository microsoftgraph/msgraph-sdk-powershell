---
external help file:
Module Name: Microsoft.Graph.Beta.DeviceManagement.Actions
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.devicemanagement.actions/clear-mgdevicemanagementcomanageddevice
schema: 2.0.0
---

# Clear-MgBetaDeviceManagementComanagedDevice

## SYNOPSIS
Wipe a device

## SYNTAX

### WipeExpanded (Default)
```
Clear-MgBetaDeviceManagementComanagedDevice -ManagedDeviceId <String> [-AdditionalProperties <Hashtable>]
 [-KeepEnrollmentData] [-KeepUserData] [-MacOSUnlockCode <String>] [-PersistEsimDataPlan] [-UseProtectedWipe]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Wipe
```
Clear-MgBetaDeviceManagementComanagedDevice -ManagedDeviceId <String>
 -BodyParameter <IPaths7IuefzDevicemanagementComanageddevicesManageddeviceIdMicrosoftGraphWipePostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### WipeViaIdentity
```
Clear-MgBetaDeviceManagementComanagedDevice -InputObject <IDeviceManagementActionsIdentity>
 -BodyParameter <IPaths7IuefzDevicemanagementComanageddevicesManageddeviceIdMicrosoftGraphWipePostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### WipeViaIdentityExpanded
```
Clear-MgBetaDeviceManagementComanagedDevice -InputObject <IDeviceManagementActionsIdentity>
 [-AdditionalProperties <Hashtable>] [-KeepEnrollmentData] [-KeepUserData] [-MacOSUnlockCode <String>]
 [-PersistEsimDataPlan] [-UseProtectedWipe] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Wipe a device

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: WipeExpanded, WipeViaIdentityExpanded
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IPaths7IuefzDevicemanagementComanageddevicesManageddeviceIdMicrosoftGraphWipePostRequestbodyContentApplicationJsonSchema
Parameter Sets: Wipe, WipeViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IDeviceManagementActionsIdentity
Parameter Sets: WipeViaIdentity, WipeViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -KeepEnrollmentData
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: WipeExpanded, WipeViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -KeepUserData
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: WipeExpanded, WipeViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MacOSUnlockCode
.

```yaml
Type: System.String
Parameter Sets: WipeExpanded, WipeViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ManagedDeviceId
key: id of managedDevice

```yaml
Type: System.String
Parameter Sets: Wipe, WipeExpanded
Aliases:

Required: True
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

### -PersistEsimDataPlan
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: WipeExpanded, WipeViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UseProtectedWipe
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: WipeExpanded, WipeViaIdentityExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IDeviceManagementActionsIdentity

### Microsoft.Graph.Beta.PowerShell.Models.IPaths7IuefzDevicemanagementComanageddevicesManageddeviceIdMicrosoftGraphWipePostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths7IuefzDevicemanagementComanageddevicesManageddeviceIdMicrosoftGraphWipePostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[KeepEnrollmentData <Boolean?>]`: 
  - `[KeepUserData <Boolean?>]`: 
  - `[MacOSUnlockCode <String>]`: 
  - `[PersistEsimDataPlan <Boolean?>]`: 
  - `[UseProtectedWipe <Boolean?>]`: 

INPUTOBJECT <IDeviceManagementActionsIdentity>: Identity Parameter
  - `[AlertRecordId <String>]`: key: id of alertRecord
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
  - `[DeviceManagementPartnerId <String>]`: key: id of deviceManagementPartner
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

