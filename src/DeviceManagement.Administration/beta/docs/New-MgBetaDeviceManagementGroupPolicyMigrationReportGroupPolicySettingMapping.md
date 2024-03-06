---
external help file:
Module Name: Microsoft.Graph.Beta.DeviceManagement.Administration
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.devicemanagement.administration/new-mgbetadevicemanagementgrouppolicymigrationreportgrouppolicysettingmapping
schema: 2.0.0
---

# New-MgBetaDeviceManagementGroupPolicyMigrationReportGroupPolicySettingMapping

## SYNOPSIS
Create new navigation property to groupPolicySettingMappings for deviceManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaDeviceManagementGroupPolicyMigrationReportGroupPolicySettingMapping
 -GroupPolicyMigrationReportId <String> [-AdditionalProperties <Hashtable>]
 [-AdmxSettingDefinitionId <String>] [-ChildIdList <String[]>] [-Id <String>]
 [-IntuneSettingDefinitionId <String>] [-IntuneSettingUriList <String[]>] [-IsMdmSupported]
 [-MdmCspName <String>] [-MdmMinimumOSVersion <Int32>] [-MdmSettingUri <String>]
 [-MdmSupportedState <MdmSupportedState>] [-ParentId <String>] [-ResponseHeadersVariable <String>]
 [-SettingCategory <String>] [-SettingDisplayName <String>] [-SettingDisplayValue <String>]
 [-SettingDisplayValueType <String>] [-SettingName <String>] [-SettingScope <GroupPolicySettingScope>]
 [-SettingType <GroupPolicySettingType>] [-SettingValue <String>] [-SettingValueDisplayUnits <String>]
 [-SettingValueType <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgBetaDeviceManagementGroupPolicyMigrationReportGroupPolicySettingMapping
 -GroupPolicyMigrationReportId <String> -BodyParameter <IMicrosoftGraphGroupPolicySettingMapping>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgBetaDeviceManagementGroupPolicyMigrationReportGroupPolicySettingMapping
 -InputObject <IDeviceManagementAdministrationIdentity>
 -BodyParameter <IMicrosoftGraphGroupPolicySettingMapping> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgBetaDeviceManagementGroupPolicyMigrationReportGroupPolicySettingMapping
 -InputObject <IDeviceManagementAdministrationIdentity> [-AdditionalProperties <Hashtable>]
 [-AdmxSettingDefinitionId <String>] [-ChildIdList <String[]>] [-Id <String>]
 [-IntuneSettingDefinitionId <String>] [-IntuneSettingUriList <String[]>] [-IsMdmSupported]
 [-MdmCspName <String>] [-MdmMinimumOSVersion <Int32>] [-MdmSettingUri <String>]
 [-MdmSupportedState <MdmSupportedState>] [-ParentId <String>] [-ResponseHeadersVariable <String>]
 [-SettingCategory <String>] [-SettingDisplayName <String>] [-SettingDisplayValue <String>]
 [-SettingDisplayValueType <String>] [-SettingName <String>] [-SettingScope <GroupPolicySettingScope>]
 [-SettingType <GroupPolicySettingType>] [-SettingValue <String>] [-SettingValueDisplayUnits <String>]
 [-SettingValueType <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to groupPolicySettingMappings for deviceManagement

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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AdmxSettingDefinitionId
Admx Group Policy Id

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
The Group Policy setting to MDM/Intune mapping.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphGroupPolicySettingMapping
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ChildIdList
List of Child Ids of the group policy setting.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: Create, CreateExpanded
Aliases:

Required: True
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IntuneSettingDefinitionId
The Intune Setting Definition Id

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IntuneSettingUriList
The list of Intune Setting URIs this group policy setting maps to

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsMdmSupported
Indicates if the setting is supported by Intune or not

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MdmCspName
The CSP name this group policy setting maps to.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MdmMinimumOSVersion
The minimum OS version this mdm setting supports.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MdmSettingUri
The MDM CSP URI this group policy setting maps to.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MdmSupportedState
Mdm Support Status of the setting.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Support.MdmSupportedState
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ParentId
Parent Id of the group policy setting.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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

### -SettingCategory
The category the group policy setting is in.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SettingDisplayName
The display name of this group policy setting.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SettingDisplayValue
The display value of this group policy setting.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SettingDisplayValueType
The display value type of this group policy setting.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SettingName
The name of this group policy setting.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SettingScope
Scope of the group policy setting.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Support.GroupPolicySettingScope
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SettingType
Setting type of the group policy.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Support.GroupPolicySettingType
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SettingValue
The value of this group policy setting.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SettingValueDisplayUnits
The display units of this group policy setting value

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SettingValueType
The value type of this group policy setting.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphGroupPolicySettingMapping

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphGroupPolicySettingMapping

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphGroupPolicySettingMapping>`: The Group Policy setting to MDM/Intune mapping.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
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

## RELATED LINKS

