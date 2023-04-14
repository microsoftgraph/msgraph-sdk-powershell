---
external help file:
Module Name: Microsoft.Graph.DeviceManagement.Administration
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.administration/update-mgdevicemanagementgrouppolicydefinitionfile
schema: 2.0.0
---

# Update-MgDeviceManagementGroupPolicyDefinitionFile

## SYNOPSIS
Update the navigation property groupPolicyDefinitionFiles in deviceManagement

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgDeviceManagementGroupPolicyDefinitionFile -GroupPolicyDefinitionFileId <String>
 [-AdditionalProperties <Hashtable>] [-Definitions <IMicrosoftGraphGroupPolicyDefinition[]>]
 [-Description <String>] [-DisplayName <String>] [-FileName <String>] [-Id <String>]
 [-LanguageCodes <String[]>] [-LastModifiedDateTime <DateTime>] [-PolicyType <GroupPolicyType>]
 [-Revision <String>] [-TargetNamespace <String>] [-TargetPrefix <String>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgDeviceManagementGroupPolicyDefinitionFile -GroupPolicyDefinitionFileId <String>
 -BodyParameter <IMicrosoftGraphGroupPolicyDefinitionFile> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgDeviceManagementGroupPolicyDefinitionFile -InputObject <IDeviceManagementAdministrationIdentity>
 -BodyParameter <IMicrosoftGraphGroupPolicyDefinitionFile> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgDeviceManagementGroupPolicyDefinitionFile -InputObject <IDeviceManagementAdministrationIdentity>
 [-AdditionalProperties <Hashtable>] [-Definitions <IMicrosoftGraphGroupPolicyDefinition[]>]
 [-Description <String>] [-DisplayName <String>] [-FileName <String>] [-Id <String>]
 [-LanguageCodes <String[]>] [-LastModifiedDateTime <DateTime>] [-PolicyType <GroupPolicyType>]
 [-Revision <String>] [-TargetNamespace <String>] [-TargetPrefix <String>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property groupPolicyDefinitionFiles in deviceManagement

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
The entity represents an ADMX (Administrative Template) XML file.
The ADMX file contains a collection of group policy definitions and their locations by category path.
The group policy definition file also contains the languages supported as determined by the language dependent ADML (Administrative Template) language files.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphGroupPolicyDefinitionFile
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Definitions
The group policy definitions associated with the file.
To construct, please use Get-Help -Online and see NOTES section for DEFINITIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphGroupPolicyDefinition[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
The localized description of the policy settings in the ADMX file.
The default value is empty.

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

### -DisplayName
The localized friendly name of the ADMX file.

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

### -FileName
The file name of the ADMX file without the path.
For example: edge.admx

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

### -GroupPolicyDefinitionFileId
The unique identifier of groupPolicyDefinitionFile

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
The unique idenfier for an entity.
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
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IDeviceManagementAdministrationIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LanguageCodes
The supported language codes for the ADMX file.

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

### -PolicyType
Type of Group Policy File or Definition.

```yaml
Type: Microsoft.Graph.PowerShell.Support.GroupPolicyType
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Revision
The revision version associated with the file.

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

### -TargetNamespace
Specifies the URI used to identify the namespace within the ADMX file.

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

### -TargetPrefix
Specifies the logical name that refers to the namespace within the ADMX file.

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

### Microsoft.Graph.PowerShell.Models.IDeviceManagementAdministrationIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphGroupPolicyDefinitionFile

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphGroupPolicyDefinitionFile>: The entity represents an ADMX (Administrative Template) XML file. The ADMX file contains a collection of group policy definitions and their locations by category path. The group policy definition file also contains the languages supported as determined by the language dependent ADML (Administrative Template) language files.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Definitions <IMicrosoftGraphGroupPolicyDefinition[]>]`: The group policy definitions associated with the file.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Category <IMicrosoftGraphGroupPolicyCategory>]`: The category entity stores the category of a group policy definition
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[Children <IMicrosoftGraphGroupPolicyCategory[]>]`: The children categories
      - `[DefinitionFile <IMicrosoftGraphGroupPolicyDefinitionFile>]`: The entity represents an ADMX (Administrative Template) XML file. The ADMX file contains a collection of group policy definitions and their locations by category path. The group policy definition file also contains the languages supported as determined by the language dependent ADML (Administrative Template) language files.
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
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[Definition <IMicrosoftGraphGroupPolicyDefinition>]`: The entity describes all of the information about a single group policy.
      - `[Label <String>]`: Localized text label for any presentation entity. The default value is empty.
      - `[LastModifiedDateTime <DateTime?>]`: The date and time the entity was last modified.
    - `[PreviousVersionDefinition <IMicrosoftGraphGroupPolicyDefinition>]`: The entity describes all of the information about a single group policy.
    - `[SupportedOn <String>]`: Localized string used to specify what operating system or application version is affected by the policy.
    - `[Version <String>]`: Setting definition version
  - `[Description <String>]`: The localized description of the policy settings in the ADMX file. The default value is empty.
  - `[DisplayName <String>]`: The localized friendly name of the ADMX file.
  - `[FileName <String>]`: The file name of the ADMX file without the path. For example: edge.admx
  - `[LanguageCodes <String[]>]`: The supported language codes for the ADMX file.
  - `[LastModifiedDateTime <DateTime?>]`: The date and time the entity was last modified.
  - `[PolicyType <GroupPolicyType?>]`: Type of Group Policy File or Definition.
  - `[Revision <String>]`: The revision version associated with the file.
  - `[TargetNamespace <String>]`: Specifies the URI used to identify the namespace within the ADMX file.
  - `[TargetPrefix <String>]`: Specifies the logical name that refers to the namespace within the ADMX file.

DEFINITIONS <IMicrosoftGraphGroupPolicyDefinition[]>: The group policy definitions associated with the file.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Category <IMicrosoftGraphGroupPolicyCategory>]`: The category entity stores the category of a group policy definition
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Children <IMicrosoftGraphGroupPolicyCategory[]>]`: The children categories
    - `[DefinitionFile <IMicrosoftGraphGroupPolicyDefinitionFile>]`: The entity represents an ADMX (Administrative Template) XML file. The ADMX file contains a collection of group policy definitions and their locations by category path. The group policy definition file also contains the languages supported as determined by the language dependent ADML (Administrative Template) language files.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
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
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Definition <IMicrosoftGraphGroupPolicyDefinition>]`: The entity describes all of the information about a single group policy.
    - `[Label <String>]`: Localized text label for any presentation entity. The default value is empty.
    - `[LastModifiedDateTime <DateTime?>]`: The date and time the entity was last modified.
  - `[PreviousVersionDefinition <IMicrosoftGraphGroupPolicyDefinition>]`: The entity describes all of the information about a single group policy.
  - `[SupportedOn <String>]`: Localized string used to specify what operating system or application version is affected by the policy.
  - `[Version <String>]`: Setting definition version

INPUTOBJECT <IDeviceManagementAdministrationIdentity>: Identity Parameter
  - `[AuditEventId <String>]`: The unique identifier of auditEvent
  - `[CartToClassAssociationId <String>]`: The unique identifier of cartToClassAssociation
  - `[CloudPcAuditEventId <String>]`: The unique identifier of cloudPcAuditEvent
  - `[CloudPcDeviceImageId <String>]`: The unique identifier of cloudPcDeviceImage
  - `[CloudPcExportJobId <String>]`: The unique identifier of cloudPcExportJob
  - `[CloudPcExternalPartnerSettingId <String>]`: The unique identifier of cloudPcExternalPartnerSetting
  - `[CloudPcGalleryImageId <String>]`: The unique identifier of cloudPcGalleryImage
  - `[CloudPcId <String>]`: The unique identifier of cloudPC
  - `[CloudPcOnPremisesConnectionId <String>]`: The unique identifier of cloudPcOnPremisesConnection
  - `[CloudPcProvisioningPolicyAssignmentId <String>]`: The unique identifier of cloudPcProvisioningPolicyAssignment
  - `[CloudPcProvisioningPolicyId <String>]`: The unique identifier of cloudPcProvisioningPolicy
  - `[CloudPcServicePlanId <String>]`: The unique identifier of cloudPcServicePlan
  - `[CloudPcSharedUseServicePlanId <String>]`: The unique identifier of cloudPcSharedUseServicePlan
  - `[CloudPcSnapshotId <String>]`: The unique identifier of cloudPcSnapshot
  - `[CloudPcSupportedRegionId <String>]`: The unique identifier of cloudPcSupportedRegion
  - `[CloudPcUserSettingAssignmentId <String>]`: The unique identifier of cloudPcUserSettingAssignment
  - `[CloudPcUserSettingId <String>]`: The unique identifier of cloudPcUserSetting
  - `[ComanagementEligibleDeviceId <String>]`: The unique identifier of comanagementEligibleDevice
  - `[ComplianceManagementPartnerId <String>]`: The unique identifier of complianceManagementPartner
  - `[DeviceAndAppManagementRoleAssignmentId <String>]`: The unique identifier of deviceAndAppManagementRoleAssignment
  - `[DeviceManagementDomainJoinConnectorId <String>]`: The unique identifier of deviceManagementDomainJoinConnector
  - `[DeviceManagementExchangeConnectorId <String>]`: The unique identifier of deviceManagementExchangeConnector
  - `[DeviceManagementExchangeOnPremisesPolicyId <String>]`: The unique identifier of deviceManagementExchangeOnPremisesPolicy
  - `[DeviceManagementPartnerId <String>]`: The unique identifier of deviceManagementPartner
  - `[GroupPolicyCategoryId <String>]`: The unique identifier of groupPolicyCategory
  - `[GroupPolicyCategoryId1 <String>]`: The unique identifier of groupPolicyCategory
  - `[GroupPolicyDefinitionFileId <String>]`: The unique identifier of groupPolicyDefinitionFile
  - `[GroupPolicyDefinitionId <String>]`: The unique identifier of groupPolicyDefinition
  - `[GroupPolicyMigrationReportId <String>]`: The unique identifier of groupPolicyMigrationReport
  - `[GroupPolicyObjectFileId <String>]`: The unique identifier of groupPolicyObjectFile
  - `[GroupPolicyOperationId <String>]`: The unique identifier of groupPolicyOperation
  - `[GroupPolicyPresentationId <String>]`: The unique identifier of groupPolicyPresentation
  - `[GroupPolicySettingMappingId <String>]`: The unique identifier of groupPolicySettingMapping
  - `[GroupPolicyUploadedDefinitionFileId <String>]`: The unique identifier of groupPolicyUploadedDefinitionFile
  - `[IntuneBrandingProfileAssignmentId <String>]`: The unique identifier of intuneBrandingProfileAssignment
  - `[IntuneBrandingProfileId <String>]`: The unique identifier of intuneBrandingProfile
  - `[IosUpdateDeviceStatusId <String>]`: The unique identifier of iosUpdateDeviceStatus
  - `[ManagedAllDeviceCertificateStateId <String>]`: The unique identifier of managedAllDeviceCertificateState
  - `[MobileThreatDefenseConnectorId <String>]`: The unique identifier of mobileThreatDefenseConnector
  - `[NdesConnectorId <String>]`: The unique identifier of ndesConnector
  - `[RemoteAssistancePartnerId <String>]`: The unique identifier of remoteAssistancePartner
  - `[ResourceOperationId <String>]`: The unique identifier of resourceOperation
  - `[RestrictedAppsViolationId <String>]`: The unique identifier of restrictedAppsViolation
  - `[RoleAssignmentId <String>]`: The unique identifier of roleAssignment
  - `[RoleDefinitionId <String>]`: The unique identifier of roleDefinition
  - `[RoleScopeTagAutoAssignmentId <String>]`: The unique identifier of roleScopeTagAutoAssignment
  - `[RoleScopeTagId <String>]`: The unique identifier of roleScopeTag
  - `[TelecomExpenseManagementPartnerId <String>]`: The unique identifier of telecomExpenseManagementPartner
  - `[TermsAndConditionsAcceptanceStatusId <String>]`: The unique identifier of termsAndConditionsAcceptanceStatus
  - `[TermsAndConditionsAssignmentId <String>]`: The unique identifier of termsAndConditionsAssignment
  - `[TermsAndConditionsGroupAssignmentId <String>]`: The unique identifier of termsAndConditionsGroupAssignment
  - `[TermsAndConditionsId <String>]`: The unique identifier of termsAndConditions
  - `[UnsupportedGroupPolicyExtensionId <String>]`: The unique identifier of unsupportedGroupPolicyExtension
  - `[UserId <String>]`: The unique identifier of user
  - `[UserPfxCertificateId <String>]`: The unique identifier of userPFXCertificate

## RELATED LINKS

