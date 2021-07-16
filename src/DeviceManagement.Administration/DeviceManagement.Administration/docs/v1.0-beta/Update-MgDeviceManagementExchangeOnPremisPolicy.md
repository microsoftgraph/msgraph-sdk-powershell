---
external help file: Microsoft.Graph.DeviceManagement.Administration-help.xml
Module Name: Microsoft.Graph.DeviceManagement.Administration
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.administration/update-mgdevicemanagementexchangeonpremispolicy
schema: 2.0.0
---

# Update-MgDeviceManagementExchangeOnPremisPolicy

## SYNOPSIS
The list of Exchange On Premisis policies configured by the tenant.

## SYNTAX

### UpdateExpanded1 (Default)
```
Update-MgDeviceManagementExchangeOnPremisPolicy
 [-AccessRules <IMicrosoftGraphDeviceManagementExchangeAccessRule[]>] [-AdditionalProperties <Hashtable>]
 [-ConditionalAccessSettings <IMicrosoftGraphOnPremisesConditionalAccessSettings>]
 [-DefaultAccessLevel <String>] [-Id <String>]
 [-KnownDeviceClasses <IMicrosoftGraphDeviceManagementExchangeDeviceClass[]>]
 [-NotificationContentInputFile <String>] [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateExpanded
```
Update-MgDeviceManagementExchangeOnPremisPolicy -DeviceManagementExchangeOnPremisesPolicyId <String>
 [-AccessRules <IMicrosoftGraphDeviceManagementExchangeAccessRule[]>] [-AdditionalProperties <Hashtable>]
 [-ConditionalAccessSettings <IMicrosoftGraphOnPremisesConditionalAccessSettings>]
 [-DefaultAccessLevel <String>] [-Id <String>]
 [-KnownDeviceClasses <IMicrosoftGraphDeviceManagementExchangeDeviceClass[]>]
 [-NotificationContentInputFile <String>] [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Update
```
Update-MgDeviceManagementExchangeOnPremisPolicy -DeviceManagementExchangeOnPremisesPolicyId <String>
 -BodyParameter <IMicrosoftGraphDeviceManagementExchangeOnPremisesPolicy> [-PassThru] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgDeviceManagementExchangeOnPremisPolicy -InputObject <IDeviceManagementAdministrationIdentity>
 [-AccessRules <IMicrosoftGraphDeviceManagementExchangeAccessRule[]>] [-AdditionalProperties <Hashtable>]
 [-ConditionalAccessSettings <IMicrosoftGraphOnPremisesConditionalAccessSettings>]
 [-DefaultAccessLevel <String>] [-Id <String>]
 [-KnownDeviceClasses <IMicrosoftGraphDeviceManagementExchangeDeviceClass[]>]
 [-NotificationContentInputFile <String>] [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgDeviceManagementExchangeOnPremisPolicy -InputObject <IDeviceManagementAdministrationIdentity>
 -BodyParameter <IMicrosoftGraphDeviceManagementExchangeOnPremisesPolicy> [-PassThru] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### Update1
```
Update-MgDeviceManagementExchangeOnPremisPolicy
 -BodyParameter <IMicrosoftGraphDeviceManagementExchangeOnPremisesPolicy> [-PassThru] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

## DESCRIPTION
The list of Exchange On Premisis policies configured by the tenant.

## EXAMPLES

## PARAMETERS

### -AccessRules
The list of device access rules in Exchange.
The access rules apply globally to the entire Exchange organization
To construct, see NOTES section for ACCESSRULES properties and create a hash table.

```yaml
Type: IMicrosoftGraphDeviceManagementExchangeAccessRule[]
Parameter Sets: UpdateExpanded1, UpdateExpanded, UpdateViaIdentityExpanded
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
Type: Hashtable
Parameter Sets: UpdateExpanded1, UpdateExpanded, UpdateViaIdentityExpanded
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
Type: IMicrosoftGraphDeviceManagementExchangeOnPremisesPolicy
Parameter Sets: Update, UpdateViaIdentity, Update1
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
Type: IMicrosoftGraphOnPremisesConditionalAccessSettings
Parameter Sets: UpdateExpanded1, UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultAccessLevel
deviceManagementExchangeAccessLevel

```yaml
Type: String
Parameter Sets: UpdateExpanded1, UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceManagementExchangeOnPremisesPolicyId
key: id of deviceManagementExchangeOnPremisesPolicy

```yaml
Type: String
Parameter Sets: UpdateExpanded, Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
Read-only.

```yaml
Type: String
Parameter Sets: UpdateExpanded1, UpdateExpanded, UpdateViaIdentityExpanded
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
Type: IDeviceManagementAdministrationIdentity
Parameter Sets: UpdateViaIdentityExpanded, UpdateViaIdentity
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
Type: IMicrosoftGraphDeviceManagementExchangeDeviceClass[]
Parameter Sets: UpdateExpanded1, UpdateExpanded, UpdateViaIdentityExpanded
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
Type: String
Parameter Sets: UpdateExpanded1, UpdateExpanded, UpdateViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IDeviceManagementAdministrationIdentity
### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementExchangeOnPremisesPolicy
## OUTPUTS

### System.Boolean
## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ACCESSRULES <IMicrosoftGraphDeviceManagementExchangeAccessRule[]>: The list of device access rules in Exchange. The access rules apply globally to the entire Exchange organization
  - `[AccessLevel <String>]`: deviceManagementExchangeAccessLevel
  - `[DeviceClass <IMicrosoftGraphDeviceManagementExchangeDeviceClass>]`: Device Class in Exchange.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Name <String>]`: Name of the device class which will be impacted by this rule.
    - `[Type <String>]`: deviceManagementExchangeAccessRuleType

BODYPARAMETER <IMicrosoftGraphDeviceManagementExchangeOnPremisesPolicy>: Singleton entity which represents the Exchange OnPremises policy configured for a tenant.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[AccessRules <IMicrosoftGraphDeviceManagementExchangeAccessRule[]>]`: The list of device access rules in Exchange. The access rules apply globally to the entire Exchange organization
    - `[AccessLevel <String>]`: deviceManagementExchangeAccessLevel
    - `[DeviceClass <IMicrosoftGraphDeviceManagementExchangeDeviceClass>]`: Device Class in Exchange.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Name <String>]`: Name of the device class which will be impacted by this rule.
      - `[Type <String>]`: deviceManagementExchangeAccessRuleType
  - `[ConditionalAccessSettings <IMicrosoftGraphOnPremisesConditionalAccessSettings>]`: Singleton entity which represents the Exchange OnPremises Conditional Access Settings for a tenant.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[Enabled <Boolean?>]`: Indicates if on premises conditional access is enabled for this organization
    - `[ExcludedGroups <String[]>]`: User groups that will be exempt by on premises conditional access. All users in these groups will be exempt from the conditional access policy.
    - `[IncludedGroups <String[]>]`: User groups that will be targeted by on premises conditional access. All users in these groups will be required to have mobile device managed and compliant for mail access.
    - `[OverrideDefaultRule <Boolean?>]`: Override the default access rule when allowing a device to ensure access is granted.
  - `[DefaultAccessLevel <String>]`: deviceManagementExchangeAccessLevel
  - `[KnownDeviceClasses <IMicrosoftGraphDeviceManagementExchangeDeviceClass[]>]`: The list of device classes known to Exchange
  - `[NotificationContent <Byte[]>]`: Notification text that will be sent to users quarantined by this policy. This is UTF8 encoded byte array HTML.

CONDITIONALACCESSSETTINGS <IMicrosoftGraphOnPremisesConditionalAccessSettings>: Singleton entity which represents the Exchange OnPremises Conditional Access Settings for a tenant.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[Enabled <Boolean?>]`: Indicates if on premises conditional access is enabled for this organization
  - `[ExcludedGroups <String[]>]`: User groups that will be exempt by on premises conditional access. All users in these groups will be exempt from the conditional access policy.
  - `[IncludedGroups <String[]>]`: User groups that will be targeted by on premises conditional access. All users in these groups will be required to have mobile device managed and compliant for mail access.
  - `[OverrideDefaultRule <Boolean?>]`: Override the default access rule when allowing a device to ensure access is granted.

INPUTOBJECT <IDeviceManagementAdministrationIdentity>: Identity Parameter
  - `[AuditEventId <String>]`: key: id of auditEvent
  - `[CartToClassAssociationId <String>]`: key: id of cartToClassAssociation
  - `[CloudPcAuditEventId <String>]`: key: id of cloudPcAuditEvent
  - `[CloudPcDeviceImageId <String>]`: key: id of cloudPcDeviceImage
  - `[CloudPcId <String>]`: key: id of cloudPC
  - `[CloudPcOnPremisesConnectionId <String>]`: key: id of cloudPcOnPremisesConnection
  - `[CloudPcProvisioningPolicyAssignmentId <String>]`: key: id of cloudPcProvisioningPolicyAssignment
  - `[CloudPcProvisioningPolicyId <String>]`: key: id of cloudPcProvisioningPolicy
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

KNOWNDEVICECLASSES <IMicrosoftGraphDeviceManagementExchangeDeviceClass[]>: The list of device classes known to Exchange
  - `[Name <String>]`: Name of the device class which will be impacted by this rule.
  - `[Type <String>]`: deviceManagementExchangeAccessRuleType

## RELATED LINKS
