---
external help file:
Module Name: Microsoft.Graph.Beta.DeviceManagement.Actions
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.devicemanagement.actions/update-mgbetadevicemanagementgrouppolicyconfigurationmultipledefinitionvalue
schema: 2.0.0
---

# Update-MgBetaDeviceManagementGroupPolicyConfigurationMultipleDefinitionValue

## SYNOPSIS
Invoke action updateDefinitionValues

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaDeviceManagementGroupPolicyConfigurationMultipleDefinitionValue
 -GroupPolicyConfigurationId <String> [-Added <IMicrosoftGraphGroupPolicyDefinitionValue[]>]
 [-AdditionalProperties <Hashtable>] [-DeletedIds <String[]>]
 [-Updated <IMicrosoftGraphGroupPolicyDefinitionValue[]>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgBetaDeviceManagementGroupPolicyConfigurationMultipleDefinitionValue
 -GroupPolicyConfigurationId <String>
 -BodyParameter <IPaths1A7K11RDevicemanagementGrouppolicyconfigurationsGrouppolicyconfigurationIdMicrosoftGraphUpdatedefinitionvaluesPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBetaDeviceManagementGroupPolicyConfigurationMultipleDefinitionValue
 -InputObject <IDeviceManagementActionsIdentity>
 -BodyParameter <IPaths1A7K11RDevicemanagementGrouppolicyconfigurationsGrouppolicyconfigurationIdMicrosoftGraphUpdatedefinitionvaluesPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBetaDeviceManagementGroupPolicyConfigurationMultipleDefinitionValue
 -InputObject <IDeviceManagementActionsIdentity> [-Added <IMicrosoftGraphGroupPolicyDefinitionValue[]>]
 [-AdditionalProperties <Hashtable>] [-DeletedIds <String[]>]
 [-Updated <IMicrosoftGraphGroupPolicyDefinitionValue[]>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Invoke action updateDefinitionValues

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

### -Added
.
To construct, see NOTES section for ADDED properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphGroupPolicyDefinitionValue[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

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
.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IPaths1A7K11RDevicemanagementGrouppolicyconfigurationsGrouppolicyconfigurationIdMicrosoftGraphUpdatedefinitionvaluesPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DeletedIds
.

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

### -GroupPolicyConfigurationId
The unique identifier of groupPolicyConfiguration

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

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IDeviceManagementActionsIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
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

### -Updated
.
To construct, see NOTES section for UPDATED properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphGroupPolicyDefinitionValue[]
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

### Microsoft.Graph.Beta.PowerShell.Models.IDeviceManagementActionsIdentity

### Microsoft.Graph.Beta.PowerShell.Models.IPaths1A7K11RDevicemanagementGrouppolicyconfigurationsGrouppolicyconfigurationIdMicrosoftGraphUpdatedefinitionvaluesPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`ADDED <IMicrosoftGraphGroupPolicyDefinitionValue[]>`: .
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[ConfigurationType <GroupPolicyConfigurationType?>]`: Group Policy Configuration Type
  - `[CreatedDateTime <DateTime?>]`: The date and time the object was created.
  - `[Definition <IMicrosoftGraphGroupPolicyDefinition>]`: The entity describes all of the information about a single group policy.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Category <IMicrosoftGraphGroupPolicyCategory>]`: The category entity stores the category of a group policy definition
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Children <IMicrosoftGraphGroupPolicyCategory[]>]`: The children categories
      - `[DefinitionFile <IMicrosoftGraphGroupPolicyDefinitionFile>]`: The entity represents an ADMX (Administrative Template) XML file. The ADMX file contains a collection of group policy definitions and their locations by category path. The group policy definition file also contains the languages supported as determined by the language dependent ADML (Administrative Template) language files.
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
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
      - `[IngestionSource <IngestionSource?>]`: Category Ingestion source
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
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Definition <IMicrosoftGraphGroupPolicyDefinition>]`: The entity describes all of the information about a single group policy.
      - `[Label <String>]`: Localized text label for any presentation entity. The default value is empty.
      - `[LastModifiedDateTime <DateTime?>]`: The date and time the entity was last modified.
    - `[PreviousVersionDefinition <IMicrosoftGraphGroupPolicyDefinition>]`: The entity describes all of the information about a single group policy.
    - `[SupportedOn <String>]`: Localized string used to specify what operating system or application version is affected by the policy.
    - `[Version <String>]`: Setting definition version
  - `[Enabled <Boolean?>]`: Enables or disables the associated group policy definition.
  - `[LastModifiedDateTime <DateTime?>]`: The date and time the entity was last modified.
  - `[PresentationValues <IMicrosoftGraphGroupPolicyPresentationValue[]>]`: The associated group policy presentation values with the definition value.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[CreatedDateTime <DateTime?>]`: The date and time the object was created.
    - `[DefinitionValue <IMicrosoftGraphGroupPolicyDefinitionValue>]`: The definition value entity stores the value for a single group policy definition.
    - `[LastModifiedDateTime <DateTime?>]`: The date and time the object was last modified.
    - `[Presentation <IMicrosoftGraphGroupPolicyPresentation>]`: The base entity for the display presentation of any of the additional options in a group policy definition.

`BODYPARAMETER <IPaths1A7K11RDevicemanagementGrouppolicyconfigurationsGrouppolicyconfigurationIdMicrosoftGraphUpdatedefinitionvaluesPostRequestbodyContentApplicationJsonSchema>`: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Added <IMicrosoftGraphGroupPolicyDefinitionValue[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[ConfigurationType <GroupPolicyConfigurationType?>]`: Group Policy Configuration Type
    - `[CreatedDateTime <DateTime?>]`: The date and time the object was created.
    - `[Definition <IMicrosoftGraphGroupPolicyDefinition>]`: The entity describes all of the information about a single group policy.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Category <IMicrosoftGraphGroupPolicyCategory>]`: The category entity stores the category of a group policy definition
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
        - `[Children <IMicrosoftGraphGroupPolicyCategory[]>]`: The children categories
        - `[DefinitionFile <IMicrosoftGraphGroupPolicyDefinitionFile>]`: The entity represents an ADMX (Administrative Template) XML file. The ADMX file contains a collection of group policy definitions and their locations by category path. The group policy definition file also contains the languages supported as determined by the language dependent ADML (Administrative Template) language files.
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Id <String>]`: The unique identifier for an entity. Read-only.
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
        - `[IngestionSource <IngestionSource?>]`: Category Ingestion source
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
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
        - `[Definition <IMicrosoftGraphGroupPolicyDefinition>]`: The entity describes all of the information about a single group policy.
        - `[Label <String>]`: Localized text label for any presentation entity. The default value is empty.
        - `[LastModifiedDateTime <DateTime?>]`: The date and time the entity was last modified.
      - `[PreviousVersionDefinition <IMicrosoftGraphGroupPolicyDefinition>]`: The entity describes all of the information about a single group policy.
      - `[SupportedOn <String>]`: Localized string used to specify what operating system or application version is affected by the policy.
      - `[Version <String>]`: Setting definition version
    - `[Enabled <Boolean?>]`: Enables or disables the associated group policy definition.
    - `[LastModifiedDateTime <DateTime?>]`: The date and time the entity was last modified.
    - `[PresentationValues <IMicrosoftGraphGroupPolicyPresentationValue[]>]`: The associated group policy presentation values with the definition value.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[CreatedDateTime <DateTime?>]`: The date and time the object was created.
      - `[DefinitionValue <IMicrosoftGraphGroupPolicyDefinitionValue>]`: The definition value entity stores the value for a single group policy definition.
      - `[LastModifiedDateTime <DateTime?>]`: The date and time the object was last modified.
      - `[Presentation <IMicrosoftGraphGroupPolicyPresentation>]`: The base entity for the display presentation of any of the additional options in a group policy definition.
  - `[DeletedIds <String[]>]`: 
  - `[Updated <IMicrosoftGraphGroupPolicyDefinitionValue[]>]`: 

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
  - `[PrivilegeManagementElevationRequestId <String>]`: The unique identifier of privilegeManagementElevationRequest
  - `[RemoteAssistancePartnerId <String>]`: The unique identifier of remoteAssistancePartner
  - `[RoleScopeTagId <String>]`: The unique identifier of roleScopeTag
  - `[WindowsAutopilotDeploymentProfileId <String>]`: The unique identifier of windowsAutopilotDeploymentProfile
  - `[WindowsAutopilotDeviceIdentityId <String>]`: The unique identifier of windowsAutopilotDeviceIdentity
  - `[WindowsDriverUpdateProfileId <String>]`: The unique identifier of windowsDriverUpdateProfile
  - `[WindowsFeatureUpdateProfileId <String>]`: The unique identifier of windowsFeatureUpdateProfile
  - `[WindowsQualityUpdateProfileId <String>]`: The unique identifier of windowsQualityUpdateProfile
  - `[ZebraFotaDeploymentId <String>]`: The unique identifier of zebraFotaDeployment

`UPDATED <IMicrosoftGraphGroupPolicyDefinitionValue[]>`: .
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[ConfigurationType <GroupPolicyConfigurationType?>]`: Group Policy Configuration Type
  - `[CreatedDateTime <DateTime?>]`: The date and time the object was created.
  - `[Definition <IMicrosoftGraphGroupPolicyDefinition>]`: The entity describes all of the information about a single group policy.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Category <IMicrosoftGraphGroupPolicyCategory>]`: The category entity stores the category of a group policy definition
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Children <IMicrosoftGraphGroupPolicyCategory[]>]`: The children categories
      - `[DefinitionFile <IMicrosoftGraphGroupPolicyDefinitionFile>]`: The entity represents an ADMX (Administrative Template) XML file. The ADMX file contains a collection of group policy definitions and their locations by category path. The group policy definition file also contains the languages supported as determined by the language dependent ADML (Administrative Template) language files.
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
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
      - `[IngestionSource <IngestionSource?>]`: Category Ingestion source
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
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Definition <IMicrosoftGraphGroupPolicyDefinition>]`: The entity describes all of the information about a single group policy.
      - `[Label <String>]`: Localized text label for any presentation entity. The default value is empty.
      - `[LastModifiedDateTime <DateTime?>]`: The date and time the entity was last modified.
    - `[PreviousVersionDefinition <IMicrosoftGraphGroupPolicyDefinition>]`: The entity describes all of the information about a single group policy.
    - `[SupportedOn <String>]`: Localized string used to specify what operating system or application version is affected by the policy.
    - `[Version <String>]`: Setting definition version
  - `[Enabled <Boolean?>]`: Enables or disables the associated group policy definition.
  - `[LastModifiedDateTime <DateTime?>]`: The date and time the entity was last modified.
  - `[PresentationValues <IMicrosoftGraphGroupPolicyPresentationValue[]>]`: The associated group policy presentation values with the definition value.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[CreatedDateTime <DateTime?>]`: The date and time the object was created.
    - `[DefinitionValue <IMicrosoftGraphGroupPolicyDefinitionValue>]`: The definition value entity stores the value for a single group policy definition.
    - `[LastModifiedDateTime <DateTime?>]`: The date and time the object was last modified.
    - `[Presentation <IMicrosoftGraphGroupPolicyPresentation>]`: The base entity for the display presentation of any of the additional options in a group policy definition.

## RELATED LINKS

