---
external help file: Microsoft.Graph.DeviceManagement.Actions-help.xml
Module Name: Microsoft.Graph.DeviceManagement.Actions
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.actions/invoke-mgdevicemanagementdeviceconfigurationassignedaccessmultimodeprofile
schema: 2.0.0
---

# Invoke-MgDeviceManagementDeviceConfigurationAssignedAccessMultiModeProfile

## SYNOPSIS
Invoke action assignedAccessMultiModeProfiles

## SYNTAX

### AccessExpanded (Default)
```
Invoke-MgDeviceManagementDeviceConfigurationAssignedAccessMultiModeProfile -DeviceConfigurationId <String>
 [-AdditionalProperties <Hashtable>]
 [-AssignedAccessMultiModeProfiles <IMicrosoftGraphWindowsAssignedAccessProfile[]>] [-PassThru] [-WhatIf]
 [-Confirm] [<CommonParameters>]
```

### Access
```
Invoke-MgDeviceManagementDeviceConfigurationAssignedAccessMultiModeProfile -DeviceConfigurationId <String>
 -BodyParameter <IPathsJifkymDevicemanagementDeviceconfigurationsDeviceconfigurationIdMicrosoftGraphAssignedaccessmultimodeprofilesPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### AccessViaIdentityExpanded
```
Invoke-MgDeviceManagementDeviceConfigurationAssignedAccessMultiModeProfile
 -InputObject <IDeviceManagementActionsIdentity> [-AdditionalProperties <Hashtable>]
 [-AssignedAccessMultiModeProfiles <IMicrosoftGraphWindowsAssignedAccessProfile[]>] [-PassThru] [-WhatIf]
 [-Confirm] [<CommonParameters>]
```

### AccessViaIdentity
```
Invoke-MgDeviceManagementDeviceConfigurationAssignedAccessMultiModeProfile
 -InputObject <IDeviceManagementActionsIdentity>
 -BodyParameter <IPathsJifkymDevicemanagementDeviceconfigurationsDeviceconfigurationIdMicrosoftGraphAssignedaccessmultimodeprofilesPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Invoke action assignedAccessMultiModeProfiles

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: AccessExpanded, AccessViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AssignedAccessMultiModeProfiles
.
To construct, see NOTES section for ASSIGNEDACCESSMULTIMODEPROFILES properties and create a hash table.

```yaml
Type: IMicrosoftGraphWindowsAssignedAccessProfile[]
Parameter Sets: AccessExpanded, AccessViaIdentityExpanded
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
Type: IPathsJifkymDevicemanagementDeviceconfigurationsDeviceconfigurationIdMicrosoftGraphAssignedaccessmultimodeprofilesPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Access, AccessViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DeviceConfigurationId
key: id of deviceConfiguration

```yaml
Type: String
Parameter Sets: AccessExpanded, Access
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
Type: IDeviceManagementActionsIdentity
Parameter Sets: AccessViaIdentityExpanded, AccessViaIdentity
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

### Microsoft.Graph.PowerShell.Models.IDeviceManagementActionsIdentity

### Microsoft.Graph.PowerShell.Models.IPathsJifkymDevicemanagementDeviceconfigurationsDeviceconfigurationIdMicrosoftGraphAssignedaccessmultimodeprofilesPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ASSIGNEDACCESSMULTIMODEPROFILES <IMicrosoftGraphWindowsAssignedAccessProfile[]>: .
  - `[Id <String>]`: Read-only.
  - `[AppUserModelIds <String[]>]`: These are the only Windows Store Apps that will be available to launch from the Start menu.
  - `[DesktopAppPaths <String[]>]`: These are the paths of the Desktop Apps that will be available on the Start menu and the only apps the user will be able to launch.
  - `[ProfileName <String>]`: This is a friendly name used to identify a group of applications, the layout of these apps on the start menu and the users to whom this kiosk configuration is assigned.
  - `[ShowTaskBar <Boolean?>]`: This setting allows the admin to specify whether the Task Bar is shown or not.
  - `[StartMenuLayoutXml <Byte[]>]`: Allows admins to override the default Start layout and prevents the user from changing it. The layout is modified by specifying an XML file based on a layout modification schema. XML needs to be in Binary format.
  - `[UserAccounts <String[]>]`: The user accounts that will be locked to this kiosk configuration.

BODYPARAMETER <IPathsJifkymDevicemanagementDeviceconfigurationsDeviceconfigurationIdMicrosoftGraphAssignedaccessmultimodeprofilesPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AssignedAccessMultiModeProfiles <IMicrosoftGraphWindowsAssignedAccessProfile[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AppUserModelIds <String[]>]`: These are the only Windows Store Apps that will be available to launch from the Start menu.
    - `[DesktopAppPaths <String[]>]`: These are the paths of the Desktop Apps that will be available on the Start menu and the only apps the user will be able to launch.
    - `[ProfileName <String>]`: This is a friendly name used to identify a group of applications, the layout of these apps on the start menu and the users to whom this kiosk configuration is assigned.
    - `[ShowTaskBar <Boolean?>]`: This setting allows the admin to specify whether the Task Bar is shown or not.
    - `[StartMenuLayoutXml <Byte[]>]`: Allows admins to override the default Start layout and prevents the user from changing it. The layout is modified by specifying an XML file based on a layout modification schema. XML needs to be in Binary format.
    - `[UserAccounts <String[]>]`: The user accounts that will be locked to this kiosk configuration.

INPUTOBJECT <IDeviceManagementActionsIdentity>: Identity Parameter
  - `[AndroidDeviceOwnerEnrollmentProfileId <String>]`: key: id of androidDeviceOwnerEnrollmentProfile
  - `[AndroidForWorkEnrollmentProfileId <String>]`: key: id of androidForWorkEnrollmentProfile
  - `[AppLogCollectionRequestId <String>]`: key: id of appLogCollectionRequest
  - `[AppleUserInitiatedEnrollmentProfileId <String>]`: key: id of appleUserInitiatedEnrollmentProfile
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
  - `[RemoteAssistancePartnerId <String>]`: key: id of remoteAssistancePartner
  - `[RoleScopeTagId <String>]`: key: id of roleScopeTag
  - `[WindowsAutopilotDeploymentProfileId <String>]`: key: id of windowsAutopilotDeploymentProfile
  - `[WindowsAutopilotDeviceIdentityId <String>]`: key: id of windowsAutopilotDeviceIdentity
  - `[WindowsFeatureUpdateProfileId <String>]`: key: id of windowsFeatureUpdateProfile
  - `[WindowsQualityUpdateProfileId <String>]`: key: id of windowsQualityUpdateProfile

## RELATED LINKS
