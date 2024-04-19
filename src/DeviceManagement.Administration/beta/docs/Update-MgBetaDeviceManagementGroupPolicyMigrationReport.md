---
external help file:
Module Name: Microsoft.Graph.Beta.DeviceManagement.Administration
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.devicemanagement.administration/update-mgbetadevicemanagementgrouppolicymigrationreport
schema: 2.0.0
---

# Update-MgBetaDeviceManagementGroupPolicyMigrationReport

## SYNOPSIS
Update the navigation property groupPolicyMigrationReports in deviceManagement

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaDeviceManagementGroupPolicyMigrationReport -GroupPolicyMigrationReportId <String>
 [-AdditionalProperties <Hashtable>] [-CreatedDateTime <DateTime>] [-DisplayName <String>]
 [-GroupPolicyCreatedDateTime <DateTime>] [-GroupPolicyLastModifiedDateTime <DateTime>]
 [-GroupPolicyObjectId <String>] [-GroupPolicySettingMappings <IMicrosoftGraphGroupPolicySettingMapping[]>]
 [-Id <String>] [-LastModifiedDateTime <DateTime>] [-MigrationReadiness <GroupPolicyMigrationReadiness>]
 [-OuDistinguishedName <String>] [-ResponseHeadersVariable <String>] [-RoleScopeTagIds <String[]>]
 [-SupportedSettingsCount <Int32>] [-SupportedSettingsPercent <Int32>] [-TargetedInActiveDirectory]
 [-TotalSettingsCount <Int32>]
 [-UnsupportedGroupPolicyExtensions <IMicrosoftGraphUnsupportedGroupPolicyExtension[]>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaDeviceManagementGroupPolicyMigrationReport -GroupPolicyMigrationReportId <String>
 -BodyParameter <IMicrosoftGraphGroupPolicyMigrationReport> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBetaDeviceManagementGroupPolicyMigrationReport -InputObject <IDeviceManagementAdministrationIdentity>
 -BodyParameter <IMicrosoftGraphGroupPolicyMigrationReport> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBetaDeviceManagementGroupPolicyMigrationReport -InputObject <IDeviceManagementAdministrationIdentity>
 [-AdditionalProperties <Hashtable>] [-CreatedDateTime <DateTime>] [-DisplayName <String>]
 [-GroupPolicyCreatedDateTime <DateTime>] [-GroupPolicyLastModifiedDateTime <DateTime>]
 [-GroupPolicyObjectId <String>] [-GroupPolicySettingMappings <IMicrosoftGraphGroupPolicySettingMapping[]>]
 [-Id <String>] [-LastModifiedDateTime <DateTime>] [-MigrationReadiness <GroupPolicyMigrationReadiness>]
 [-OuDistinguishedName <String>] [-ResponseHeadersVariable <String>] [-RoleScopeTagIds <String[]>]
 [-SupportedSettingsCount <Int32>] [-SupportedSettingsPercent <Int32>] [-TargetedInActiveDirectory]
 [-TotalSettingsCount <Int32>]
 [-UnsupportedGroupPolicyExtensions <IMicrosoftGraphUnsupportedGroupPolicyExtension[]>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property groupPolicyMigrationReports in deviceManagement

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

### -BodyParameter
The Group Policy migration report.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphGroupPolicyMigrationReport
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedDateTime
The date and time at which the GroupPolicyMigrationReport was created.

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

### -DisplayName
The name of Group Policy Object from the GPO Xml Content

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

### -GroupPolicyCreatedDateTime
The date and time at which the GroupPolicyMigrationReport was created.

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

### -GroupPolicyLastModifiedDateTime
The date and time at which the GroupPolicyMigrationReport was last modified.

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

### -GroupPolicyMigrationReportId
The unique identifier of groupPolicyMigrationReport

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

### -GroupPolicyObjectId
The Group Policy Object GUID from GPO Xml content

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

### -GroupPolicySettingMappings
A list of group policy settings to MDM/Intune mappings.
To construct, see NOTES section for GROUPPOLICYSETTINGMAPPINGS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphGroupPolicySettingMapping[]
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IDeviceManagementAdministrationIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LastModifiedDateTime
The date and time at which the GroupPolicyMigrationReport was last modified.

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

### -MigrationReadiness
Indicates if the Group Policy Object file is covered and ready for Intune migration.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Support.GroupPolicyMigrationReadiness
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OuDistinguishedName
The distinguished name of the OU.

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
The list of scope tags for the configuration.

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

### -SupportedSettingsCount
The number of Group Policy Settings supported by Intune.

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

### -SupportedSettingsPercent
The Percentage of Group Policy Settings supported by Intune.

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

### -TargetedInActiveDirectory
The Targeted in AD property from GPO Xml Content

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TotalSettingsCount
The total number of Group Policy Settings from GPO file.

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

### -UnsupportedGroupPolicyExtensions
A list of unsupported group policy extensions inside the Group Policy Object.
To construct, see NOTES section for UNSUPPORTEDGROUPPOLICYEXTENSIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphUnsupportedGroupPolicyExtension[]
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

### Microsoft.Graph.Beta.PowerShell.Models.IDeviceManagementAdministrationIdentity

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphGroupPolicyMigrationReport

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphGroupPolicyMigrationReport

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphGroupPolicyMigrationReport>`: The Group Policy migration report.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[CreatedDateTime <DateTime?>]`: The date and time at which the GroupPolicyMigrationReport was created.
  - `[DisplayName <String>]`: The name of Group Policy Object from the GPO Xml Content
  - `[GroupPolicyCreatedDateTime <DateTime?>]`: The date and time at which the GroupPolicyMigrationReport was created.
  - `[GroupPolicyLastModifiedDateTime <DateTime?>]`: The date and time at which the GroupPolicyMigrationReport was last modified.
  - `[GroupPolicyObjectId <String>]`: The Group Policy Object GUID from GPO Xml content
  - `[GroupPolicySettingMappings <IMicrosoftGraphGroupPolicySettingMapping[]>]`: A list of group policy settings to MDM/Intune mappings.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[AdmxSettingDefinitionId <String>]`: Admx Group Policy Id
    - `[ChildIdList <String[]>]`: List of Child Ids of the group policy setting.
    - `[IntuneSettingDefinitionId <String>]`: The Intune Setting Definition Id
    - `[IntuneSettingUriList <String[]>]`: The list of Intune Setting URIs this group policy setting maps to
    - `[IsMdmSupported <Boolean?>]`: Indicates if the setting is supported by Intune or not
    - `[MdmCspName <String>]`: The CSP name this group policy setting maps to.
    - `[MdmMinimumOSVersion <Int32?>]`: The minimum OS version this mdm setting supports.
    - `[MdmSettingUri <String>]`: The MDM CSP URI this group policy setting maps to.
    - `[MdmSupportedState <MdmSupportedState?>]`: Mdm Support Status of the setting.
    - `[ParentId <String>]`: Parent Id of the group policy setting.
    - `[SettingCategory <String>]`: The category the group policy setting is in.
    - `[SettingDisplayName <String>]`: The display name of this group policy setting.
    - `[SettingDisplayValue <String>]`: The display value of this group policy setting.
    - `[SettingDisplayValueType <String>]`: The display value type of this group policy setting.
    - `[SettingName <String>]`: The name of this group policy setting.
    - `[SettingScope <GroupPolicySettingScope?>]`: Scope of the group policy setting.
    - `[SettingType <GroupPolicySettingType?>]`: Setting type of the group policy.
    - `[SettingValue <String>]`: The value of this group policy setting.
    - `[SettingValueDisplayUnits <String>]`: The display units of this group policy setting value
    - `[SettingValueType <String>]`: The value type of this group policy setting.
  - `[LastModifiedDateTime <DateTime?>]`: The date and time at which the GroupPolicyMigrationReport was last modified.
  - `[MigrationReadiness <GroupPolicyMigrationReadiness?>]`: Indicates if the Group Policy Object file is covered and ready for Intune migration.
  - `[OuDistinguishedName <String>]`: The distinguished name of the OU.
  - `[RoleScopeTagIds <String[]>]`: The list of scope tags for the configuration.
  - `[SupportedSettingsCount <Int32?>]`: The number of Group Policy Settings supported by Intune.
  - `[SupportedSettingsPercent <Int32?>]`: The Percentage of Group Policy Settings supported by Intune.
  - `[TargetedInActiveDirectory <Boolean?>]`: The Targeted in AD property from GPO Xml Content
  - `[TotalSettingsCount <Int32?>]`: The total number of Group Policy Settings from GPO file.
  - `[UnsupportedGroupPolicyExtensions <IMicrosoftGraphUnsupportedGroupPolicyExtension[]>]`: A list of unsupported group policy extensions inside the Group Policy Object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[ExtensionType <String>]`: ExtensionType of the unsupported extension.
    - `[NamespaceUrl <String>]`: Namespace Url of the unsupported extension.
    - `[NodeName <String>]`: Node name of the unsupported extension.
    - `[SettingScope <GroupPolicySettingScope?>]`: Scope of the group policy setting.

`GROUPPOLICYSETTINGMAPPINGS <IMicrosoftGraphGroupPolicySettingMapping[]>`: A list of group policy settings to MDM/Intune mappings.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AdmxSettingDefinitionId <String>]`: Admx Group Policy Id
  - `[ChildIdList <String[]>]`: List of Child Ids of the group policy setting.
  - `[IntuneSettingDefinitionId <String>]`: The Intune Setting Definition Id
  - `[IntuneSettingUriList <String[]>]`: The list of Intune Setting URIs this group policy setting maps to
  - `[IsMdmSupported <Boolean?>]`: Indicates if the setting is supported by Intune or not
  - `[MdmCspName <String>]`: The CSP name this group policy setting maps to.
  - `[MdmMinimumOSVersion <Int32?>]`: The minimum OS version this mdm setting supports.
  - `[MdmSettingUri <String>]`: The MDM CSP URI this group policy setting maps to.
  - `[MdmSupportedState <MdmSupportedState?>]`: Mdm Support Status of the setting.
  - `[ParentId <String>]`: Parent Id of the group policy setting.
  - `[SettingCategory <String>]`: The category the group policy setting is in.
  - `[SettingDisplayName <String>]`: The display name of this group policy setting.
  - `[SettingDisplayValue <String>]`: The display value of this group policy setting.
  - `[SettingDisplayValueType <String>]`: The display value type of this group policy setting.
  - `[SettingName <String>]`: The name of this group policy setting.
  - `[SettingScope <GroupPolicySettingScope?>]`: Scope of the group policy setting.
  - `[SettingType <GroupPolicySettingType?>]`: Setting type of the group policy.
  - `[SettingValue <String>]`: The value of this group policy setting.
  - `[SettingValueDisplayUnits <String>]`: The display units of this group policy setting value
  - `[SettingValueType <String>]`: The value type of this group policy setting.

`INPUTOBJECT <IDeviceManagementAdministrationIdentity>`: Identity Parameter
  - `[AuditEventId <String>]`: The unique identifier of auditEvent
  - `[CartToClassAssociationId <String>]`: The unique identifier of cartToClassAssociation
  - `[CloudPcAuditEventId <String>]`: The unique identifier of cloudPcAuditEvent
  - `[CloudPcBulkActionId <String>]`: The unique identifier of cloudPcBulkAction
  - `[CloudPcDeviceImageId <String>]`: The unique identifier of cloudPcDeviceImage
  - `[CloudPcExportJobId <String>]`: The unique identifier of cloudPcExportJob
  - `[CloudPcExternalPartnerSettingId <String>]`: The unique identifier of cloudPcExternalPartnerSetting
  - `[CloudPcFrontLineServicePlanId <String>]`: The unique identifier of cloudPcFrontLineServicePlan
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

`UNSUPPORTEDGROUPPOLICYEXTENSIONS <IMicrosoftGraphUnsupportedGroupPolicyExtension[]>`: A list of unsupported group policy extensions inside the Group Policy Object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[ExtensionType <String>]`: ExtensionType of the unsupported extension.
  - `[NamespaceUrl <String>]`: Namespace Url of the unsupported extension.
  - `[NodeName <String>]`: Node name of the unsupported extension.
  - `[SettingScope <GroupPolicySettingScope?>]`: Scope of the group policy setting.

## RELATED LINKS

