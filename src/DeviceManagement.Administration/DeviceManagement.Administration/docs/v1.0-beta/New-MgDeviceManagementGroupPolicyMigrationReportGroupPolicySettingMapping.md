---
external help file:
Module Name: Microsoft.Graph.DeviceManagement.Administration
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.administration/new-mgdevicemanagementgrouppolicymigrationreportgrouppolicysettingmapping
schema: 2.0.0
---

# New-MgDeviceManagementGroupPolicyMigrationReportGroupPolicySettingMapping

## SYNOPSIS
Create new navigation property to groupPolicySettingMappings for deviceManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementGroupPolicyMigrationReportGroupPolicySettingMapping
 -GroupPolicyMigrationReportId <String> [-AdditionalProperties <Hashtable>]
 [-AdmxSettingDefinitionId <String>] [-ChildIdList <String[]>] [-Id <String>]
 [-IntuneSettingDefinitionId <String>] [-IntuneSettingUriList <String[]>] [-IsMdmSupported]
 [-MdmCspName <String>] [-MdmMinimumOSVersion <Int32>] [-MdmSettingUri <String>]
 [-MdmSupportedState <MdmSupportedState>] [-ParentId <String>] [-SettingCategory <String>]
 [-SettingDisplayName <String>] [-SettingDisplayValue <String>] [-SettingDisplayValueType <String>]
 [-SettingName <String>] [-SettingScope <GroupPolicySettingScope>] [-SettingType <GroupPolicySettingType>]
 [-SettingValue <String>] [-SettingValueDisplayUnits <String>] [-SettingValueType <String>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementGroupPolicyMigrationReportGroupPolicySettingMapping
 -GroupPolicyMigrationReportId <String> -BodyParameter <IMicrosoftGraphGroupPolicySettingMapping> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgDeviceManagementGroupPolicyMigrationReportGroupPolicySettingMapping
 -InputObject <IDeviceManagementAdministrationIdentity>
 -BodyParameter <IMicrosoftGraphGroupPolicySettingMapping> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgDeviceManagementGroupPolicyMigrationReportGroupPolicySettingMapping
 -InputObject <IDeviceManagementAdministrationIdentity> [-AdditionalProperties <Hashtable>]
 [-AdmxSettingDefinitionId <String>] [-ChildIdList <String[]>] [-Id <String>]
 [-IntuneSettingDefinitionId <String>] [-IntuneSettingUriList <String[]>] [-IsMdmSupported]
 [-MdmCspName <String>] [-MdmMinimumOSVersion <Int32>] [-MdmSettingUri <String>]
 [-MdmSupportedState <MdmSupportedState>] [-ParentId <String>] [-SettingCategory <String>]
 [-SettingDisplayName <String>] [-SettingDisplayValue <String>] [-SettingDisplayValueType <String>]
 [-SettingName <String>] [-SettingScope <GroupPolicySettingScope>] [-SettingType <GroupPolicySettingType>]
 [-SettingValue <String>] [-SettingValueDisplayUnits <String>] [-SettingValueType <String>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to groupPolicySettingMappings for deviceManagement

## EXAMPLES

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
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphGroupPolicySettingMapping
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
key: id of groupPolicyMigrationReport

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

### -Id
.

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
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IDeviceManagementAdministrationIdentity
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
Type: Microsoft.Graph.PowerShell.Support.MdmSupportedState
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
Type: Microsoft.Graph.PowerShell.Support.GroupPolicySettingScope
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
Type: Microsoft.Graph.PowerShell.Support.GroupPolicySettingType
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

### Microsoft.Graph.PowerShell.Models.IDeviceManagementAdministrationIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphGroupPolicySettingMapping

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphGroupPolicySettingMapping

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphGroupPolicySettingMapping>: The Group Policy setting to MDM/Intune mapping.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
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

INPUTOBJECT <IDeviceManagementAdministrationIdentity>: Identity Parameter
  - `[AuditEventId <String>]`: key: id of auditEvent
  - `[CartToClassAssociationId <String>]`: key: id of cartToClassAssociation
  - `[CloudPcAuditEventId <String>]`: key: id of cloudPcAuditEvent
  - `[CloudPcDeviceImageId <String>]`: key: id of cloudPcDeviceImage
  - `[CloudPcGalleryImageId <String>]`: key: id of cloudPcGalleryImage
  - `[CloudPcId <String>]`: key: id of cloudPC
  - `[CloudPcOnPremisesConnectionId <String>]`: key: id of cloudPcOnPremisesConnection
  - `[CloudPcProvisioningPolicyAssignmentId <String>]`: key: id of cloudPcProvisioningPolicyAssignment
  - `[CloudPcProvisioningPolicyId <String>]`: key: id of cloudPcProvisioningPolicy
  - `[CloudPcServicePlanId <String>]`: key: id of cloudPcServicePlan
  - `[CloudPcSnapshotId <String>]`: key: id of cloudPcSnapshot
  - `[CloudPcSupportedRegionId <String>]`: key: id of cloudPcSupportedRegion
  - `[CloudPcUserSettingAssignmentId <String>]`: key: id of cloudPcUserSettingAssignment
  - `[CloudPcUserSettingId <String>]`: key: id of cloudPcUserSetting
  - `[ComanagementEligibleDeviceId <String>]`: key: id of comanagementEligibleDevice
  - `[ComplianceManagementPartnerId <String>]`: key: id of complianceManagementPartner
  - `[DeviceAndAppManagementRoleAssignmentId <String>]`: key: id of deviceAndAppManagementRoleAssignment
  - `[DeviceManagementDomainJoinConnectorId <String>]`: key: id of deviceManagementDomainJoinConnector
  - `[DeviceManagementExchangeConnectorId <String>]`: key: id of deviceManagementExchangeConnector
  - `[DeviceManagementExchangeOnPremisesPolicyId <String>]`: key: id of deviceManagementExchangeOnPremisesPolicy
  - `[DeviceManagementPartnerId <String>]`: key: id of deviceManagementPartner
  - `[GroupPolicyCategoryId <String>]`: key: id of groupPolicyCategory
  - `[GroupPolicyCategoryId1 <String>]`: key: id of groupPolicyCategory
  - `[GroupPolicyDefinitionFileId <String>]`: key: id of groupPolicyDefinitionFile
  - `[GroupPolicyDefinitionId <String>]`: key: id of groupPolicyDefinition
  - `[GroupPolicyMigrationReportId <String>]`: key: id of groupPolicyMigrationReport
  - `[GroupPolicyObjectFileId <String>]`: key: id of groupPolicyObjectFile
  - `[GroupPolicyOperationId <String>]`: key: id of groupPolicyOperation
  - `[GroupPolicyPresentationId <String>]`: key: id of groupPolicyPresentation
  - `[GroupPolicySettingMappingId <String>]`: key: id of groupPolicySettingMapping
  - `[GroupPolicyUploadedDefinitionFileId <String>]`: key: id of groupPolicyUploadedDefinitionFile
  - `[IntuneBrandingProfileAssignmentId <String>]`: key: id of intuneBrandingProfileAssignment
  - `[IntuneBrandingProfileId <String>]`: key: id of intuneBrandingProfile
  - `[IosUpdateDeviceStatusId <String>]`: key: id of iosUpdateDeviceStatus
  - `[ManagedAllDeviceCertificateStateId <String>]`: key: id of managedAllDeviceCertificateState
  - `[MobileThreatDefenseConnectorId <String>]`: key: id of mobileThreatDefenseConnector
  - `[NdesConnectorId <String>]`: key: id of ndesConnector
  - `[RemoteAssistancePartnerId <String>]`: key: id of remoteAssistancePartner
  - `[ResourceOperationId <String>]`: key: id of resourceOperation
  - `[RestrictedAppsViolationId <String>]`: key: id of restrictedAppsViolation
  - `[RoleAssignmentId <String>]`: key: id of roleAssignment
  - `[RoleDefinitionId <String>]`: key: id of roleDefinition
  - `[RoleScopeTagAutoAssignmentId <String>]`: key: id of roleScopeTagAutoAssignment
  - `[RoleScopeTagId <String>]`: key: id of roleScopeTag
  - `[TelecomExpenseManagementPartnerId <String>]`: key: id of telecomExpenseManagementPartner
  - `[TermsAndConditionsAcceptanceStatusId <String>]`: key: id of termsAndConditionsAcceptanceStatus
  - `[TermsAndConditionsAssignmentId <String>]`: key: id of termsAndConditionsAssignment
  - `[TermsAndConditionsGroupAssignmentId <String>]`: key: id of termsAndConditionsGroupAssignment
  - `[TermsAndConditionsId <String>]`: key: id of termsAndConditions
  - `[UnsupportedGroupPolicyExtensionId <String>]`: key: id of unsupportedGroupPolicyExtension
  - `[UserPfxCertificateId <String>]`: key: id of userPFXCertificate

## RELATED LINKS

