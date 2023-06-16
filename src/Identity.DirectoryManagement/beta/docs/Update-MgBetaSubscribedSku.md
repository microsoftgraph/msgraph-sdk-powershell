---
external help file:
Module Name: Microsoft.Graph.Beta.Identity.DirectoryManagement
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.identity.directorymanagement/update-mgbetasubscribedsku
schema: 2.0.0
---

# Update-MgBetaSubscribedSku

## SYNOPSIS
Update entity in subscribedSkus

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaSubscribedSku -SubscribedSkuId <String> [-AccountId <String>] [-AccountName <String>]
 [-AdditionalProperties <Hashtable>] [-AppliesTo <String>] [-CapabilityStatus <String>]
 [-ConsumedUnits <Int32>] [-Id <String>] [-PrepaidUnits <IMicrosoftGraphLicenseUnitsDetail>]
 [-ServicePlans <IMicrosoftGraphServicePlanInfo[]>] [-SkuId <String>] [-SkuPartNumber <String>]
 [-SubscriptionIds <String[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaSubscribedSku -SubscribedSkuId <String> -BodyParameter <IMicrosoftGraphSubscribedSku> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBetaSubscribedSku -InputObject <IIdentityDirectoryManagementIdentity>
 -BodyParameter <IMicrosoftGraphSubscribedSku> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBetaSubscribedSku -InputObject <IIdentityDirectoryManagementIdentity> [-AccountId <String>]
 [-AccountName <String>] [-AdditionalProperties <Hashtable>] [-AppliesTo <String>]
 [-CapabilityStatus <String>] [-ConsumedUnits <Int32>] [-Id <String>]
 [-PrepaidUnits <IMicrosoftGraphLicenseUnitsDetail>] [-ServicePlans <IMicrosoftGraphServicePlanInfo[]>]
 [-SkuId <String>] [-SkuPartNumber <String>] [-SubscriptionIds <String[]>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update entity in subscribedSkus

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement
```

Get-MgBetaSubscribedSku -SubscribedSkuId $subscribedSkuId

## PARAMETERS

### -AccountId
.

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

### -AccountName
.

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

### -AppliesTo
For example, 'User' or 'Company'.

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

### -BodyParameter
subscribedSku
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSubscribedSku
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CapabilityStatus
Possible values are: Enabled, Warning, Suspended, Deleted, LockedOut.
The capabilityStatus is Enabled if the prepaidUnits property has at least 1 unit that is enabled, and LockedOut if the customer cancelled their subscription.

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

### -ConsumedUnits
The number of licenses that have been assigned.

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
Type: Microsoft.Graph.Beta.PowerShell.Models.IIdentityDirectoryManagementIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -PrepaidUnits
licenseUnitsDetail
To construct, see NOTES section for PREPAIDUNITS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphLicenseUnitsDetail
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ServicePlans
Information about the service plans that are available with the SKU.
Not nullable
To construct, see NOTES section for SERVICEPLANS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphServicePlanInfo[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SkuId
The unique identifier (GUID) for the service SKU.

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

### -SkuPartNumber
The SKU part number; for example: 'AAD_PREMIUM' or 'RMSBASIC'.
To get a list of commercial subscriptions that an organization has acquired, see List subscribedSkus.

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

### -SubscribedSkuId
The unique identifier of subscribedSku

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

### -SubscriptionIds
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

### Microsoft.Graph.Beta.PowerShell.Models.IIdentityDirectoryManagementIdentity

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSubscribedSku

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSubscribedSku

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphSubscribedSku>`: subscribedSku
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AccountId <String>]`: 
  - `[AccountName <String>]`: 
  - `[AppliesTo <String>]`: For example, 'User' or 'Company'.
  - `[CapabilityStatus <String>]`: Possible values are: Enabled, Warning, Suspended, Deleted, LockedOut. The capabilityStatus is Enabled if the prepaidUnits property has at least 1 unit that is enabled, and LockedOut if the customer cancelled their subscription.
  - `[ConsumedUnits <Int32?>]`: The number of licenses that have been assigned.
  - `[PrepaidUnits <IMicrosoftGraphLicenseUnitsDetail>]`: licenseUnitsDetail
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Enabled <Int32?>]`: The number of units that are enabled for the active subscription of the service SKU.
    - `[LockedOut <Int32?>]`: 
    - `[Suspended <Int32?>]`: The number of units that are suspended because the subscription of the service SKU has been cancelled. The units cannot be assigned but can still be reactivated before they are deleted.
    - `[Warning <Int32?>]`: The number of units that are in warning status. When the subscription of the service SKU has expired, the customer has a grace period to renew their subscription before it is cancelled (moved to a suspended state).
  - `[ServicePlans <IMicrosoftGraphServicePlanInfo[]>]`: Information about the service plans that are available with the SKU. Not nullable
    - `[AppliesTo <String>]`: The object the service plan can be assigned to. The possible values are:User - service plan can be assigned to individual users.Company - service plan can be assigned to the entire tenant.
    - `[ProvisioningStatus <String>]`: The provisioning status of the service plan. The possible values are:Success - Service is fully provisioned.Disabled - Service has been disabled.ErrorStatus - The service plan has not been provisioned and is in an error state.PendingInput - Service is not yet provisioned; awaiting service confirmation.PendingActivation - Service is provisioned but requires explicit activation by administrator (for example, Intune_O365 service plan)PendingProvisioning - Microsoft has added a new service to the product SKU and it has not been activated in the tenant, yet.
    - `[ServicePlanId <String>]`: The unique identifier of the service plan.
    - `[ServicePlanName <String>]`: The name of the service plan.
  - `[SkuId <String>]`: The unique identifier (GUID) for the service SKU.
  - `[SkuPartNumber <String>]`: The SKU part number; for example: 'AAD_PREMIUM' or 'RMSBASIC'. To get a list of commercial subscriptions that an organization has acquired, see List subscribedSkus.
  - `[SubscriptionIds <String[]>]`: 

`INPUTOBJECT <IIdentityDirectoryManagementIdentity>`: Identity Parameter
  - `[AdministrativeUnitId <String>]`: The unique identifier of administrativeUnit
  - `[AllowedValueId <String>]`: The unique identifier of allowedValue
  - `[AttributeSetId <String>]`: The unique identifier of attributeSet
  - `[CertificateAuthorityAsEntityId <String>]`: The unique identifier of certificateAuthorityAsEntity
  - `[CertificateBasedApplicationConfigurationId <String>]`: The unique identifier of certificateBasedApplicationConfiguration
  - `[CommandId <String>]`: The unique identifier of command
  - `[ContractId <String>]`: The unique identifier of contract
  - `[CustomSecurityAttributeDefinitionId <String>]`: The unique identifier of customSecurityAttributeDefinition
  - `[DeviceId <String>]`: The unique identifier of device
  - `[DirectoryObjectId <String>]`: The unique identifier of directoryObject
  - `[DirectoryRoleId <String>]`: The unique identifier of directoryRole
  - `[DirectoryRoleTemplateId <String>]`: The unique identifier of directoryRoleTemplate
  - `[DirectorySettingId <String>]`: The unique identifier of directorySetting
  - `[DirectorySettingTemplateId <String>]`: The unique identifier of directorySettingTemplate
  - `[DomainDnsRecordId <String>]`: The unique identifier of domainDnsRecord
  - `[DomainId <String>]`: The unique identifier of domain
  - `[ExtensionId <String>]`: The unique identifier of extension
  - `[FeatureRolloutPolicyId <String>]`: The unique identifier of featureRolloutPolicy
  - `[IdentityProviderBaseId <String>]`: The unique identifier of identityProviderBase
  - `[ImpactedResourceId <String>]`: The unique identifier of impactedResource
  - `[InboundSharedUserProfileUserId <String>]`: The unique identifier of inboundSharedUserProfile
  - `[InternalDomainFederationId <String>]`: The unique identifier of internalDomainFederation
  - `[OnPremisesDirectorySynchronizationId <String>]`: The unique identifier of onPremisesDirectorySynchronization
  - `[OrgContactId <String>]`: The unique identifier of orgContact
  - `[OrganizationId <String>]`: The unique identifier of organization
  - `[OrganizationalBrandingLocalizationId <String>]`: The unique identifier of organizationalBrandingLocalization
  - `[OutboundSharedUserProfileUserId <String>]`: The unique identifier of outboundSharedUserProfile
  - `[ProfileCardPropertyId <String>]`: The unique identifier of profileCardProperty
  - `[RecommendationId <String>]`: The unique identifier of recommendation
  - `[ScopedRoleMembershipId <String>]`: The unique identifier of scopedRoleMembership
  - `[SharedEmailDomainId <String>]`: The unique identifier of sharedEmailDomain
  - `[SharedEmailDomainInvitationId <String>]`: The unique identifier of sharedEmailDomainInvitation
  - `[SubscribedSkuId <String>]`: The unique identifier of subscribedSku
  - `[TenantReferenceTenantId <String>]`: The unique identifier of tenantReference
  - `[UsageRightId <String>]`: The unique identifier of usageRight
  - `[UserId <String>]`: The unique identifier of user

`PREPAIDUNITS <IMicrosoftGraphLicenseUnitsDetail>`: licenseUnitsDetail
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Enabled <Int32?>]`: The number of units that are enabled for the active subscription of the service SKU.
  - `[LockedOut <Int32?>]`: 
  - `[Suspended <Int32?>]`: The number of units that are suspended because the subscription of the service SKU has been cancelled. The units cannot be assigned but can still be reactivated before they are deleted.
  - `[Warning <Int32?>]`: The number of units that are in warning status. When the subscription of the service SKU has expired, the customer has a grace period to renew their subscription before it is cancelled (moved to a suspended state).

`SERVICEPLANS <IMicrosoftGraphServicePlanInfo[]>`: Information about the service plans that are available with the SKU. Not nullable
  - `[AppliesTo <String>]`: The object the service plan can be assigned to. The possible values are:User - service plan can be assigned to individual users.Company - service plan can be assigned to the entire tenant.
  - `[ProvisioningStatus <String>]`: The provisioning status of the service plan. The possible values are:Success - Service is fully provisioned.Disabled - Service has been disabled.ErrorStatus - The service plan has not been provisioned and is in an error state.PendingInput - Service is not yet provisioned; awaiting service confirmation.PendingActivation - Service is provisioned but requires explicit activation by administrator (for example, Intune_O365 service plan)PendingProvisioning - Microsoft has added a new service to the product SKU and it has not been activated in the tenant, yet.
  - `[ServicePlanId <String>]`: The unique identifier of the service plan.
  - `[ServicePlanName <String>]`: The name of the service plan.

## RELATED LINKS

