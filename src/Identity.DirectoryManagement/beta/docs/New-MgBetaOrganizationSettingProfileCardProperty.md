---
external help file:
Module Name: Microsoft.Graph.Beta.Identity.DirectoryManagement
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.identity.directorymanagement/new-mgbetaorganizationsettingprofilecardproperty
schema: 2.0.0
---

# New-MgBetaOrganizationSettingProfileCardProperty

## SYNOPSIS
Create new navigation property to profileCardProperties for organization

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaOrganizationSettingProfileCardProperty -OrganizationId <String> [-AdditionalProperties <Hashtable>]
 [-Annotations <IMicrosoftGraphProfileCardAnnotation[]>] [-DirectoryPropertyName <String>] [-Id <String>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgBetaOrganizationSettingProfileCardProperty -OrganizationId <String>
 -BodyParameter <IMicrosoftGraphProfileCardProperty> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgBetaOrganizationSettingProfileCardProperty -InputObject <IIdentityDirectoryManagementIdentity>
 -BodyParameter <IMicrosoftGraphProfileCardProperty> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgBetaOrganizationSettingProfileCardProperty -InputObject <IIdentityDirectoryManagementIdentity>
 [-AdditionalProperties <Hashtable>] [-Annotations <IMicrosoftGraphProfileCardAnnotation[]>]
 [-DirectoryPropertyName <String>] [-Id <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to profileCardProperties for organization

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement
$params = @{
	DirectoryPropertyName = "CustomAttribute1"
	Annotations = @(
		@{
			DisplayName = "Cost Center"
			Localizations = @(
				@{
					LanguageTag = "ru-RU"
					DisplayName = "центр затрат"
				}
			)
		}
	)
}
New-MgBetaOrganizationSettingProfileCardProperty -OrganizationId $organizationId -BodyParameter $params
```



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

### -Annotations
Allows an administrator to set a custom display label for the directory property and localize it for the users in their tenant.
To construct, see NOTES section for ANNOTATIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphProfileCardAnnotation[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
profileCardProperty
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphProfileCardProperty
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DirectoryPropertyName
Identifies a profileCardProperty resource in Get, Update, or Delete operations.
Allows an administrator to surface hidden Azure Active Directory (Azure AD) properties on the Microsoft 365 profile card within their tenant.
When present, the Azure AD field referenced in this field will be visible to all users in your tenant on the contact pane of the profile card.
Allowed values for this field are: UserPrincipalName, Fax, StreetAddress, PostalCode, StateOrProvince, Alias, CustomAttribute1, CustomAttribute2, CustomAttribute3, CustomAttribute4, CustomAttribute5, CustomAttribute6, CustomAttribute7, CustomAttribute8, CustomAttribute9, CustomAttribute10, CustomAttribute11, CustomAttribute12, CustomAttribute13, CustomAttribute14, CustomAttribute15.

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
Type: Microsoft.Graph.Beta.PowerShell.Models.IIdentityDirectoryManagementIdentity
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -OrganizationId
The unique identifier of organization

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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphProfileCardProperty

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphProfileCardProperty

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`ANNOTATIONS <IMicrosoftGraphProfileCardAnnotation[]>`: Allows an administrator to set a custom display label for the directory property and localize it for the users in their tenant.
  - `[DisplayName <String>]`: If present, the value of this field is used by the profile card as the default property label in the experience (for example, 'Cost Center').
  - `[Localizations <IMicrosoftGraphDisplayNameLocalization[]>]`: Each resource in this collection represents the localized value of the attribute name for a given language, used as the default label for that locale. For example, a user with a no-NB client gets 'Kostnads Senter' as the attribute label, rather than 'Cost Center.'
    - `[DisplayName <String>]`: If present, the value of this field contains the displayName string that has been set for the language present in the languageTag field.
    - `[LanguageTag <String>]`: Provides the language culture-code and friendly name of the language that the displayName field has been provided in.

`BODYPARAMETER <IMicrosoftGraphProfileCardProperty>`: profileCardProperty
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Annotations <IMicrosoftGraphProfileCardAnnotation[]>]`: Allows an administrator to set a custom display label for the directory property and localize it for the users in their tenant.
    - `[DisplayName <String>]`: If present, the value of this field is used by the profile card as the default property label in the experience (for example, 'Cost Center').
    - `[Localizations <IMicrosoftGraphDisplayNameLocalization[]>]`: Each resource in this collection represents the localized value of the attribute name for a given language, used as the default label for that locale. For example, a user with a no-NB client gets 'Kostnads Senter' as the attribute label, rather than 'Cost Center.'
      - `[DisplayName <String>]`: If present, the value of this field contains the displayName string that has been set for the language present in the languageTag field.
      - `[LanguageTag <String>]`: Provides the language culture-code and friendly name of the language that the displayName field has been provided in.
  - `[DirectoryPropertyName <String>]`: Identifies a profileCardProperty resource in Get, Update, or Delete operations. Allows an administrator to surface hidden Azure Active Directory (Azure AD) properties on the Microsoft 365 profile card within their tenant. When present, the Azure AD field referenced in this field will be visible to all users in your tenant on the contact pane of the profile card. Allowed values for this field are: UserPrincipalName, Fax, StreetAddress, PostalCode, StateOrProvince, Alias, CustomAttribute1,  CustomAttribute2, CustomAttribute3, CustomAttribute4, CustomAttribute5, CustomAttribute6, CustomAttribute7, CustomAttribute8, CustomAttribute9, CustomAttribute10, CustomAttribute11, CustomAttribute12, CustomAttribute13, CustomAttribute14, CustomAttribute15.

`INPUTOBJECT <IIdentityDirectoryManagementIdentity>`: Identity Parameter
  - `[AdministrativeUnitId <String>]`: The unique identifier of administrativeUnit
  - `[AllowedValueId <String>]`: The unique identifier of allowedValue
  - `[AttributeSetId <String>]`: The unique identifier of attributeSet
  - `[CertificateAuthorityAsEntityId <String>]`: The unique identifier of certificateAuthorityAsEntity
  - `[CertificateBasedApplicationConfigurationId <String>]`: The unique identifier of certificateBasedApplicationConfiguration
  - `[CommandId <String>]`: The unique identifier of command
  - `[CompanySubscriptionId <String>]`: The unique identifier of companySubscription
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
  - `[ManagedTenantAlertId <String>]`: The unique identifier of managedTenantAlert
  - `[ManagementActionId <String>]`: The unique identifier of managementAction
  - `[OnPremisesDirectorySynchronizationId <String>]`: The unique identifier of onPremisesDirectorySynchronization
  - `[OrgContactId <String>]`: The unique identifier of orgContact
  - `[OrganizationId <String>]`: The unique identifier of organization
  - `[OrganizationalBrandingLocalizationId <String>]`: The unique identifier of organizationalBrandingLocalization
  - `[OutboundSharedUserProfileUserId <String>]`: The unique identifier of outboundSharedUserProfile
  - `[ProfileCardPropertyId <String>]`: The unique identifier of profileCardProperty
  - `[RecommendationId <String>]`: The unique identifier of recommendation
  - `[RoleTemplateId <String>]`: Alternate key of directoryRole
  - `[ScopedRoleMembershipId <String>]`: The unique identifier of scopedRoleMembership
  - `[SharedEmailDomainId <String>]`: The unique identifier of sharedEmailDomain
  - `[SharedEmailDomainInvitationId <String>]`: The unique identifier of sharedEmailDomainInvitation
  - `[SubscribedSkuId <String>]`: The unique identifier of subscribedSku
  - `[TenantId <String>]`: The unique identifier of tenant
  - `[TenantReferenceTenantId <String>]`: The unique identifier of tenantReference
  - `[TenantTagId <String>]`: The unique identifier of tenantTag
  - `[UsageRightId <String>]`: The unique identifier of usageRight
  - `[UserId <String>]`: The unique identifier of user

## RELATED LINKS

