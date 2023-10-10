---
external help file:
Module Name: Microsoft.Graph.Beta.DeviceManagement.Administration
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.devicemanagement.administration/update-mgbetadevicemanagementexchangeonpremisepolicy
schema: 2.0.0
---

# Update-MgBetaDeviceManagementExchangeOnPremisePolicy

## SYNOPSIS
Update the navigation property exchangeOnPremisesPolicies in deviceManagement

## SYNTAX

### UpdateExpanded1 (Default)
```
Update-MgBetaDeviceManagementExchangeOnPremisePolicy
 [-AccessRules <IMicrosoftGraphDeviceManagementExchangeAccessRule[]>] [-AdditionalProperties <Hashtable>]
 [-ConditionalAccessSettings <IMicrosoftGraphOnPremisesConditionalAccessSettings>]
 [-DefaultAccessLevel <DeviceManagementExchangeAccessLevel>] [-Id <String>]
 [-KnownDeviceClasses <IMicrosoftGraphDeviceManagementExchangeDeviceClass[]>]
 [-NotificationContentInputFile <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaDeviceManagementExchangeOnPremisePolicy -DeviceManagementExchangeOnPremisesPolicyId <String>
 -BodyParameter <IMicrosoftGraphDeviceManagementExchangeOnPremisesPolicy> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update1
```
Update-MgBetaDeviceManagementExchangeOnPremisePolicy
 -BodyParameter <IMicrosoftGraphDeviceManagementExchangeOnPremisesPolicy> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateExpanded
```
Update-MgBetaDeviceManagementExchangeOnPremisePolicy -DeviceManagementExchangeOnPremisesPolicyId <String>
 [-AccessRules <IMicrosoftGraphDeviceManagementExchangeAccessRule[]>] [-AdditionalProperties <Hashtable>]
 [-ConditionalAccessSettings <IMicrosoftGraphOnPremisesConditionalAccessSettings>]
 [-DefaultAccessLevel <DeviceManagementExchangeAccessLevel>] [-Id <String>]
 [-KnownDeviceClasses <IMicrosoftGraphDeviceManagementExchangeDeviceClass[]>]
 [-NotificationContentInputFile <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBetaDeviceManagementExchangeOnPremisePolicy -InputObject <IDeviceManagementAdministrationIdentity>
 -BodyParameter <IMicrosoftGraphDeviceManagementExchangeOnPremisesPolicy> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBetaDeviceManagementExchangeOnPremisePolicy -InputObject <IDeviceManagementAdministrationIdentity>
 [-AccessRules <IMicrosoftGraphDeviceManagementExchangeAccessRule[]>] [-AdditionalProperties <Hashtable>]
 [-ConditionalAccessSettings <IMicrosoftGraphOnPremisesConditionalAccessSettings>]
 [-DefaultAccessLevel <DeviceManagementExchangeAccessLevel>] [-Id <String>]
 [-KnownDeviceClasses <IMicrosoftGraphDeviceManagementExchangeDeviceClass[]>]
 [-NotificationContentInputFile <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property exchangeOnPremisesPolicies in deviceManagement

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```



### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```



## PARAMETERS

### -AccessRules
The list of device access rules in Exchange.
The access rules apply globally to the entire Exchange organization
To construct, see NOTES section for ACCESSRULES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDeviceManagementExchangeAccessRule[]
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
Singleton entity which represents the Exchange OnPremises policy configured for a tenant.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDeviceManagementExchangeOnPremisesPolicy
Parameter Sets: Update, Update1, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ConditionalAccessSettings
Singleton entity which represents the Exchange OnPremises Conditional Access Settings for a tenant.
To construct, see NOTES section for CONDITIONALACCESSSETTINGS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphOnPremisesConditionalAccessSettings
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultAccessLevel
Access Level in Exchange.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Support.DeviceManagementExchangeAccessLevel
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceManagementExchangeOnPremisesPolicyId
The unique identifier of deviceManagementExchangeOnPremisesPolicy

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
The unique identifier for an entity.
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded
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

### -KnownDeviceClasses
The list of device classes known to Exchange
To construct, see NOTES section for KNOWNDEVICECLASSES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDeviceManagementExchangeDeviceClass[]
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NotificationContentInputFile
Input File for NotificationContent (Notification text that will be sent to users quarantined by this policy.
This is UTF8 encoded byte array HTML.)

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDeviceManagementExchangeOnPremisesPolicy

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDeviceManagementExchangeOnPremisesPolicy

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`ACCESSRULES <IMicrosoftGraphDeviceManagementExchangeAccessRule[]>`: The list of device access rules in Exchange. The access rules apply globally to the entire Exchange organization
  - `[AccessLevel <DeviceManagementExchangeAccessLevel?>]`: Access Level in Exchange.
  - `[DeviceClass <IMicrosoftGraphDeviceManagementExchangeDeviceClass>]`: Device Class in Exchange.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Name <String>]`: Name of the device class which will be impacted by this rule.
    - `[Type <DeviceManagementExchangeAccessRuleType?>]`: Criteria which defines the type of device this access rule will apply to

`BODYPARAMETER <IMicrosoftGraphDeviceManagementExchangeOnPremisesPolicy>`: Singleton entity which represents the Exchange OnPremises policy configured for a tenant.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AccessRules <IMicrosoftGraphDeviceManagementExchangeAccessRule[]>]`: The list of device access rules in Exchange. The access rules apply globally to the entire Exchange organization
    - `[AccessLevel <DeviceManagementExchangeAccessLevel?>]`: Access Level in Exchange.
    - `[DeviceClass <IMicrosoftGraphDeviceManagementExchangeDeviceClass>]`: Device Class in Exchange.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Name <String>]`: Name of the device class which will be impacted by this rule.
      - `[Type <DeviceManagementExchangeAccessRuleType?>]`: Criteria which defines the type of device this access rule will apply to
  - `[ConditionalAccessSettings <IMicrosoftGraphOnPremisesConditionalAccessSettings>]`: Singleton entity which represents the Exchange OnPremises Conditional Access Settings for a tenant.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Enabled <Boolean?>]`: Indicates if on premises conditional access is enabled for this organization
    - `[ExcludedGroups <String[]>]`: User groups that will be exempt by on premises conditional access. All users in these groups will be exempt from the conditional access policy.
    - `[IncludedGroups <String[]>]`: User groups that will be targeted by on premises conditional access. All users in these groups will be required to have mobile device managed and compliant for mail access.
    - `[OverrideDefaultRule <Boolean?>]`: Override the default access rule when allowing a device to ensure access is granted.
  - `[DefaultAccessLevel <DeviceManagementExchangeAccessLevel?>]`: Access Level in Exchange.
  - `[KnownDeviceClasses <IMicrosoftGraphDeviceManagementExchangeDeviceClass[]>]`: The list of device classes known to Exchange
  - `[NotificationContent <Byte[]>]`: Notification text that will be sent to users quarantined by this policy. This is UTF8 encoded byte array HTML.

`CONDITIONALACCESSSETTINGS <IMicrosoftGraphOnPremisesConditionalAccessSettings>`: Singleton entity which represents the Exchange OnPremises Conditional Access Settings for a tenant.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Enabled <Boolean?>]`: Indicates if on premises conditional access is enabled for this organization
  - `[ExcludedGroups <String[]>]`: User groups that will be exempt by on premises conditional access. All users in these groups will be exempt from the conditional access policy.
  - `[IncludedGroups <String[]>]`: User groups that will be targeted by on premises conditional access. All users in these groups will be required to have mobile device managed and compliant for mail access.
  - `[OverrideDefaultRule <Boolean?>]`: Override the default access rule when allowing a device to ensure access is granted.

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

`KNOWNDEVICECLASSES <IMicrosoftGraphDeviceManagementExchangeDeviceClass[]>`: The list of device classes known to Exchange
  - `[Name <String>]`: Name of the device class which will be impacted by this rule.
  - `[Type <DeviceManagementExchangeAccessRuleType?>]`: Criteria which defines the type of device this access rule will apply to

## RELATED LINKS

