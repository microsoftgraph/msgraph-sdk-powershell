---
external help file:
Module Name: Microsoft.Graph.DeviceManagement.Actions
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.actions/import-mgdevicemanagementdeponboardingsettingimportedappledeviceidentityappledeviceidentitylist
schema: 2.0.0
---

# Import-MgDeviceManagementDepOnboardingSettingImportedAppleDeviceIdentityAppleDeviceIdentityList

## SYNOPSIS
Invoke action importAppleDeviceIdentityList

## SYNTAX

### ImportExpanded (Default)
```
Import-MgDeviceManagementDepOnboardingSettingImportedAppleDeviceIdentityAppleDeviceIdentityList
 -DepOnboardingSettingId <String> [-AdditionalProperties <Hashtable>]
 [-ImportedAppleDeviceIdentities <IMicrosoftGraphImportedAppleDeviceIdentity[]>]
 [-OverwriteImportedDeviceIdentities] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Import
```
Import-MgDeviceManagementDepOnboardingSettingImportedAppleDeviceIdentityAppleDeviceIdentityList
 -DepOnboardingSettingId <String>
 -BodyParameter <IPaths1Ad4X1ZDevicemanagementDeponboardingsettingsDeponboardingsettingIdImportedappledeviceidentitiesMicrosoftGraphImportappledeviceidentitylistPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ImportViaIdentity
```
Import-MgDeviceManagementDepOnboardingSettingImportedAppleDeviceIdentityAppleDeviceIdentityList
 -InputObject <IDeviceManagementActionsIdentity>
 -BodyParameter <IPaths1Ad4X1ZDevicemanagementDeponboardingsettingsDeponboardingsettingIdImportedappledeviceidentitiesMicrosoftGraphImportappledeviceidentitylistPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ImportViaIdentityExpanded
```
Import-MgDeviceManagementDepOnboardingSettingImportedAppleDeviceIdentityAppleDeviceIdentityList
 -InputObject <IDeviceManagementActionsIdentity> [-AdditionalProperties <Hashtable>]
 [-ImportedAppleDeviceIdentities <IMicrosoftGraphImportedAppleDeviceIdentity[]>]
 [-OverwriteImportedDeviceIdentities] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action importAppleDeviceIdentityList

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: ImportExpanded, ImportViaIdentityExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IPaths1Ad4X1ZDevicemanagementDeponboardingsettingsDeponboardingsettingIdImportedappledeviceidentitiesMicrosoftGraphImportappledeviceidentitylistPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Import, ImportViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DepOnboardingSettingId
key: id of depOnboardingSetting

```yaml
Type: System.String
Parameter Sets: Import, ImportExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ImportedAppleDeviceIdentities
.
To construct, please use Get-Help -Online and see NOTES section for IMPORTEDAPPLEDEVICEIDENTITIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphImportedAppleDeviceIdentity[]
Parameter Sets: ImportExpanded, ImportViaIdentityExpanded
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
Parameter Sets: ImportViaIdentity, ImportViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -OverwriteImportedDeviceIdentities
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: ImportExpanded, ImportViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IPaths1Ad4X1ZDevicemanagementDeponboardingsettingsDeponboardingsettingIdImportedappledeviceidentitiesMicrosoftGraphImportappledeviceidentitylistPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphImportedAppleDeviceIdentityResult

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths1Ad4X1ZDevicemanagementDeponboardingsettingsDeponboardingsettingIdImportedappledeviceidentitiesMicrosoftGraphImportappledeviceidentitylistPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ImportedAppleDeviceIdentities <IMicrosoftGraphImportedAppleDeviceIdentity[]>]`: 
    - `[Id <String>]`: 
    - `[CreatedDateTime <DateTime?>]`: Created Date Time of the device
    - `[Description <String>]`: The description of the device
    - `[DiscoverySource <DiscoverySource?>]`: discoverySource
    - `[EnrollmentState <EnrollmentState?>]`: enrollmentState
    - `[IsDeleted <Boolean?>]`: Indicates if the device is deleted from Apple Business Manager
    - `[IsSupervised <Boolean?>]`: Indicates if the Apple device is supervised. More information is at: https://support.apple.com/en-us/HT202837
    - `[LastContactedDateTime <DateTime?>]`: Last Contacted Date Time of the device
    - `[Platform <Platform?>]`: platform
    - `[RequestedEnrollmentProfileAssignmentDateTime <DateTime?>]`: The time enrollment profile was assigned to the device
    - `[RequestedEnrollmentProfileId <String>]`: Enrollment profile Id admin intends to apply to the device during next enrollment
    - `[SerialNumber <String>]`: Device serial number
  - `[OverwriteImportedDeviceIdentities <Boolean?>]`: 

IMPORTEDAPPLEDEVICEIDENTITIES <IMicrosoftGraphImportedAppleDeviceIdentity[]>: .
  - `[Id <String>]`: 
  - `[CreatedDateTime <DateTime?>]`: Created Date Time of the device
  - `[Description <String>]`: The description of the device
  - `[DiscoverySource <DiscoverySource?>]`: discoverySource
  - `[EnrollmentState <EnrollmentState?>]`: enrollmentState
  - `[IsDeleted <Boolean?>]`: Indicates if the device is deleted from Apple Business Manager
  - `[IsSupervised <Boolean?>]`: Indicates if the Apple device is supervised. More information is at: https://support.apple.com/en-us/HT202837
  - `[LastContactedDateTime <DateTime?>]`: Last Contacted Date Time of the device
  - `[Platform <Platform?>]`: platform
  - `[RequestedEnrollmentProfileAssignmentDateTime <DateTime?>]`: The time enrollment profile was assigned to the device
  - `[RequestedEnrollmentProfileId <String>]`: Enrollment profile Id admin intends to apply to the device during next enrollment
  - `[SerialNumber <String>]`: Device serial number

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

