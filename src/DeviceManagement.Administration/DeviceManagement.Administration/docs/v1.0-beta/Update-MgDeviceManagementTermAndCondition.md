---
external help file:
Module Name: Microsoft.Graph.DeviceManagement.Administration
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.administration/update-mgdevicemanagementtermandcondition
schema: 2.0.0
---

# Update-MgDeviceManagementTermAndCondition

## SYNOPSIS
Update the navigation property termsAndConditions in deviceManagement

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgDeviceManagementTermAndCondition -TermsAndConditionsId <String> [-AcceptanceStatement <String>]
 [-AcceptanceStatuses <IMicrosoftGraphTermsAndConditionsAcceptanceStatus[]>]
 [-AdditionalProperties <Hashtable>] [-Assignments <IMicrosoftGraphTermsAndConditionsAssignment1[]>]
 [-BodyText <String>] [-CreatedDateTime <DateTime>] [-Description <String>] [-DisplayName <String>]
 [-GroupAssignments <IMicrosoftGraphTermsAndConditionsGroupAssignment[]>] [-Id <String>]
 [-LastModifiedDateTime <DateTime>] [-ModifiedDateTime <DateTime>] [-RoleScopeTagIds <String[]>]
 [-Title <String>] [-Version <Int32>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgDeviceManagementTermAndCondition -TermsAndConditionsId <String>
 -BodyParameter <IMicrosoftGraphTermsAndConditions> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgDeviceManagementTermAndCondition -InputObject <IDeviceManagementAdministrationIdentity>
 -BodyParameter <IMicrosoftGraphTermsAndConditions> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgDeviceManagementTermAndCondition -InputObject <IDeviceManagementAdministrationIdentity>
 [-AcceptanceStatement <String>] [-AcceptanceStatuses <IMicrosoftGraphTermsAndConditionsAcceptanceStatus[]>]
 [-AdditionalProperties <Hashtable>] [-Assignments <IMicrosoftGraphTermsAndConditionsAssignment1[]>]
 [-BodyText <String>] [-CreatedDateTime <DateTime>] [-Description <String>] [-DisplayName <String>]
 [-GroupAssignments <IMicrosoftGraphTermsAndConditionsGroupAssignment[]>] [-Id <String>]
 [-LastModifiedDateTime <DateTime>] [-ModifiedDateTime <DateTime>] [-RoleScopeTagIds <String[]>]
 [-Title <String>] [-Version <Int32>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property termsAndConditions in deviceManagement

## EXAMPLES

## PARAMETERS

### -AcceptanceStatement
Administrator-supplied explanation of the terms and conditions, typically describing what it means to accept the terms and conditions set out in the T&C policy.
This is shown to the user on prompts to accept the T&C policy.

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

### -AcceptanceStatuses
The list of acceptance statuses for this T&C policy.
To construct, please use Get-Help -Online and see NOTES section for ACCEPTANCESTATUSES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTermsAndConditionsAcceptanceStatus[]
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

### -Assignments
The list of assignments for this T&C policy.
To construct, please use Get-Help -Online and see NOTES section for ASSIGNMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTermsAndConditionsAssignment1[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
A termsAndConditions entity represents the metadata and contents of a given Terms and Conditions (T&C) policy.
T&C policies’ contents are presented to users upon their first attempt to enroll into Intune and subsequently upon edits where an administrator has required re-acceptance.
They enable administrators to communicate the provisions to which a user must agree in order to have devices enrolled into Intune.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTermsAndConditions
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -BodyText
Administrator-supplied body text of the terms and conditions, typically the terms themselves.
This is shown to the user on prompts to accept the T&C policy.

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

### -CreatedDateTime
DateTime the object was created.

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

### -Description
Administrator-supplied description of the T&C policy.

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
Administrator-supplied name for the T&C policy.

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

### -GroupAssignments
The list of group assignments for this T&C policy.
To construct, please use Get-Help -Online and see NOTES section for GROUPASSIGNMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTermsAndConditionsGroupAssignment[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
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

### -LastModifiedDateTime
DateTime the object was last modified.

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

### -ModifiedDateTime
DateTime the object was last modified.

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

### -RoleScopeTagIds
List of Scope Tags for this Entity instance.

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

### -TermsAndConditionsId
The unique identifier of termsAndConditions

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

### -Title
Administrator-supplied title of the terms and conditions.
This is shown to the user on prompts to accept the T&C policy.

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

### -Version
Integer indicating the current version of the terms.
Incremented when an administrator makes a change to the terms and wishes to require users to re-accept the modified T&C policy.

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTermsAndConditions

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ACCEPTANCESTATUSES <IMicrosoftGraphTermsAndConditionsAcceptanceStatus[]>: The list of acceptance statuses for this T&C policy.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[AcceptedDateTime <DateTime?>]`: DateTime when the terms were last accepted by the user.
  - `[AcceptedVersion <Int32?>]`: Most recent version number of the T&C accepted by the user.
  - `[TermsAndConditions <IMicrosoftGraphTermsAndConditions>]`: A termsAndConditions entity represents the metadata and contents of a given Terms and Conditions (T&C) policy. T&C policies’ contents are presented to users upon their first attempt to enroll into Intune and subsequently upon edits where an administrator has required re-acceptance. They enable administrators to communicate the provisions to which a user must agree in order to have devices enrolled into Intune.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[AcceptanceStatement <String>]`: Administrator-supplied explanation of the terms and conditions, typically describing what it means to accept the terms and conditions set out in the T&C policy. This is shown to the user on prompts to accept the T&C policy.
    - `[AcceptanceStatuses <IMicrosoftGraphTermsAndConditionsAcceptanceStatus[]>]`: The list of acceptance statuses for this T&C policy.
    - `[Assignments <IMicrosoftGraphTermsAndConditionsAssignment1[]>]`: The list of assignments for this T&C policy.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget1>]`: Base type for assignment targets.
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
        - `[DeviceAndAppManagementAssignmentFilterType <DeviceAndAppManagementAssignmentFilterType?>]`: Represents type of the assignment filter.
    - `[BodyText <String>]`: Administrator-supplied body text of the terms and conditions, typically the terms themselves. This is shown to the user on prompts to accept the T&C policy.
    - `[CreatedDateTime <DateTime?>]`: DateTime the object was created.
    - `[Description <String>]`: Administrator-supplied description of the T&C policy.
    - `[DisplayName <String>]`: Administrator-supplied name for the T&C policy.
    - `[GroupAssignments <IMicrosoftGraphTermsAndConditionsGroupAssignment[]>]`: The list of group assignments for this T&C policy.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[TargetGroupId <String>]`: Unique identifier of a group that the T&C policy is assigned to.
      - `[TermsAndConditions <IMicrosoftGraphTermsAndConditions>]`: A termsAndConditions entity represents the metadata and contents of a given Terms and Conditions (T&C) policy. T&C policies’ contents are presented to users upon their first attempt to enroll into Intune and subsequently upon edits where an administrator has required re-acceptance. They enable administrators to communicate the provisions to which a user must agree in order to have devices enrolled into Intune.
    - `[LastModifiedDateTime <DateTime?>]`: DateTime the object was last modified.
    - `[ModifiedDateTime <DateTime?>]`: DateTime the object was last modified.
    - `[RoleScopeTagIds <String[]>]`: List of Scope Tags for this Entity instance.
    - `[Title <String>]`: Administrator-supplied title of the terms and conditions. This is shown to the user on prompts to accept the T&C policy.
    - `[Version <Int32?>]`: Integer indicating the current version of the terms. Incremented when an administrator makes a change to the terms and wishes to require users to re-accept the modified T&C policy.
  - `[UserDisplayName <String>]`: Display name of the user whose acceptance the entity represents.
  - `[UserPrincipalName <String>]`: The userPrincipalName of the User that accepted the term.

ASSIGNMENTS <IMicrosoftGraphTermsAndConditionsAssignment1[]>: The list of assignments for this T&C policy.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget1>]`: Base type for assignment targets.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
    - `[DeviceAndAppManagementAssignmentFilterType <DeviceAndAppManagementAssignmentFilterType?>]`: Represents type of the assignment filter.

BODYPARAMETER <IMicrosoftGraphTermsAndConditions>: A termsAndConditions entity represents the metadata and contents of a given Terms and Conditions (T&C) policy. T&C policies’ contents are presented to users upon their first attempt to enroll into Intune and subsequently upon edits where an administrator has required re-acceptance. They enable administrators to communicate the provisions to which a user must agree in order to have devices enrolled into Intune.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[AcceptanceStatement <String>]`: Administrator-supplied explanation of the terms and conditions, typically describing what it means to accept the terms and conditions set out in the T&C policy. This is shown to the user on prompts to accept the T&C policy.
  - `[AcceptanceStatuses <IMicrosoftGraphTermsAndConditionsAcceptanceStatus[]>]`: The list of acceptance statuses for this T&C policy.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[AcceptedDateTime <DateTime?>]`: DateTime when the terms were last accepted by the user.
    - `[AcceptedVersion <Int32?>]`: Most recent version number of the T&C accepted by the user.
    - `[TermsAndConditions <IMicrosoftGraphTermsAndConditions>]`: A termsAndConditions entity represents the metadata and contents of a given Terms and Conditions (T&C) policy. T&C policies’ contents are presented to users upon their first attempt to enroll into Intune and subsequently upon edits where an administrator has required re-acceptance. They enable administrators to communicate the provisions to which a user must agree in order to have devices enrolled into Intune.
    - `[UserDisplayName <String>]`: Display name of the user whose acceptance the entity represents.
    - `[UserPrincipalName <String>]`: The userPrincipalName of the User that accepted the term.
  - `[Assignments <IMicrosoftGraphTermsAndConditionsAssignment1[]>]`: The list of assignments for this T&C policy.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget1>]`: Base type for assignment targets.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
      - `[DeviceAndAppManagementAssignmentFilterType <DeviceAndAppManagementAssignmentFilterType?>]`: Represents type of the assignment filter.
  - `[BodyText <String>]`: Administrator-supplied body text of the terms and conditions, typically the terms themselves. This is shown to the user on prompts to accept the T&C policy.
  - `[CreatedDateTime <DateTime?>]`: DateTime the object was created.
  - `[Description <String>]`: Administrator-supplied description of the T&C policy.
  - `[DisplayName <String>]`: Administrator-supplied name for the T&C policy.
  - `[GroupAssignments <IMicrosoftGraphTermsAndConditionsGroupAssignment[]>]`: The list of group assignments for this T&C policy.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[TargetGroupId <String>]`: Unique identifier of a group that the T&C policy is assigned to.
    - `[TermsAndConditions <IMicrosoftGraphTermsAndConditions>]`: A termsAndConditions entity represents the metadata and contents of a given Terms and Conditions (T&C) policy. T&C policies’ contents are presented to users upon their first attempt to enroll into Intune and subsequently upon edits where an administrator has required re-acceptance. They enable administrators to communicate the provisions to which a user must agree in order to have devices enrolled into Intune.
  - `[LastModifiedDateTime <DateTime?>]`: DateTime the object was last modified.
  - `[ModifiedDateTime <DateTime?>]`: DateTime the object was last modified.
  - `[RoleScopeTagIds <String[]>]`: List of Scope Tags for this Entity instance.
  - `[Title <String>]`: Administrator-supplied title of the terms and conditions. This is shown to the user on prompts to accept the T&C policy.
  - `[Version <Int32?>]`: Integer indicating the current version of the terms. Incremented when an administrator makes a change to the terms and wishes to require users to re-accept the modified T&C policy.

GROUPASSIGNMENTS <IMicrosoftGraphTermsAndConditionsGroupAssignment[]>: The list of group assignments for this T&C policy.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[TargetGroupId <String>]`: Unique identifier of a group that the T&C policy is assigned to.
  - `[TermsAndConditions <IMicrosoftGraphTermsAndConditions>]`: A termsAndConditions entity represents the metadata and contents of a given Terms and Conditions (T&C) policy. T&C policies’ contents are presented to users upon their first attempt to enroll into Intune and subsequently upon edits where an administrator has required re-acceptance. They enable administrators to communicate the provisions to which a user must agree in order to have devices enrolled into Intune.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[AcceptanceStatement <String>]`: Administrator-supplied explanation of the terms and conditions, typically describing what it means to accept the terms and conditions set out in the T&C policy. This is shown to the user on prompts to accept the T&C policy.
    - `[AcceptanceStatuses <IMicrosoftGraphTermsAndConditionsAcceptanceStatus[]>]`: The list of acceptance statuses for this T&C policy.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[AcceptedDateTime <DateTime?>]`: DateTime when the terms were last accepted by the user.
      - `[AcceptedVersion <Int32?>]`: Most recent version number of the T&C accepted by the user.
      - `[TermsAndConditions <IMicrosoftGraphTermsAndConditions>]`: A termsAndConditions entity represents the metadata and contents of a given Terms and Conditions (T&C) policy. T&C policies’ contents are presented to users upon their first attempt to enroll into Intune and subsequently upon edits where an administrator has required re-acceptance. They enable administrators to communicate the provisions to which a user must agree in order to have devices enrolled into Intune.
      - `[UserDisplayName <String>]`: Display name of the user whose acceptance the entity represents.
      - `[UserPrincipalName <String>]`: The userPrincipalName of the User that accepted the term.
    - `[Assignments <IMicrosoftGraphTermsAndConditionsAssignment1[]>]`: The list of assignments for this T&C policy.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget1>]`: Base type for assignment targets.
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
        - `[DeviceAndAppManagementAssignmentFilterType <DeviceAndAppManagementAssignmentFilterType?>]`: Represents type of the assignment filter.
    - `[BodyText <String>]`: Administrator-supplied body text of the terms and conditions, typically the terms themselves. This is shown to the user on prompts to accept the T&C policy.
    - `[CreatedDateTime <DateTime?>]`: DateTime the object was created.
    - `[Description <String>]`: Administrator-supplied description of the T&C policy.
    - `[DisplayName <String>]`: Administrator-supplied name for the T&C policy.
    - `[GroupAssignments <IMicrosoftGraphTermsAndConditionsGroupAssignment[]>]`: The list of group assignments for this T&C policy.
    - `[LastModifiedDateTime <DateTime?>]`: DateTime the object was last modified.
    - `[ModifiedDateTime <DateTime?>]`: DateTime the object was last modified.
    - `[RoleScopeTagIds <String[]>]`: List of Scope Tags for this Entity instance.
    - `[Title <String>]`: Administrator-supplied title of the terms and conditions. This is shown to the user on prompts to accept the T&C policy.
    - `[Version <Int32?>]`: Integer indicating the current version of the terms. Incremented when an administrator makes a change to the terms and wishes to require users to re-accept the modified T&C policy.

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

