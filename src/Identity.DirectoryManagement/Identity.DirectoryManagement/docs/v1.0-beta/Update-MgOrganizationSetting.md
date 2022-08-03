---
external help file:
Module Name: Microsoft.Graph.Identity.DirectoryManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.directorymanagement/update-mgorganizationsetting
schema: 2.0.0
---

# Update-MgOrganizationSetting

## SYNOPSIS
Update the navigation property settings in organization

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgOrganizationSetting -OrganizationId <String> [-AdditionalProperties <Hashtable>] [-Id <String>]
 [-ItemInsights <IMicrosoftGraphInsightsSettings>]
 [-MicrosoftApplicationDataAccess <IMicrosoftGraphMicrosoftApplicationDataAccessSettings>]
 [-PeopleInsights <IMicrosoftGraphInsightsSettings>]
 [-ProfileCardProperties <IMicrosoftGraphProfileCardProperty[]>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgOrganizationSetting -OrganizationId <String> -BodyParameter <IMicrosoftGraphOrganizationSettings>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgOrganizationSetting -InputObject <IIdentityDirectoryManagementIdentity>
 -BodyParameter <IMicrosoftGraphOrganizationSettings> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgOrganizationSetting -InputObject <IIdentityDirectoryManagementIdentity>
 [-AdditionalProperties <Hashtable>] [-Id <String>] [-ItemInsights <IMicrosoftGraphInsightsSettings>]
 [-MicrosoftApplicationDataAccess <IMicrosoftGraphMicrosoftApplicationDataAccessSettings>]
 [-PeopleInsights <IMicrosoftGraphInsightsSettings>]
 [-ProfileCardProperties <IMicrosoftGraphProfileCardProperty[]>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property settings in organization

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
organizationSettings
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOrganizationSettings
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Id
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

### -InputObject
Identity Parameter
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IIdentityDirectoryManagementIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ItemInsights
insightsSettings
To construct, please use Get-Help -Online and see NOTES section for ITEMINSIGHTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphInsightsSettings
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MicrosoftApplicationDataAccess
microsoftApplicationDataAccessSettings
To construct, please use Get-Help -Online and see NOTES section for MICROSOFTAPPLICATIONDATAACCESS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMicrosoftApplicationDataAccessSettings
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OrganizationId
key: id of organization

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

### -PeopleInsights
insightsSettings
To construct, please use Get-Help -Online and see NOTES section for PEOPLEINSIGHTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphInsightsSettings
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProfileCardProperties
Contains a collection of the properties an administrator has defined as visible on the Microsoft 365 profile card.
Get organization settings returns the properties configured for profile cards for the organization.
To construct, please use Get-Help -Online and see NOTES section for PROFILECARDPROPERTIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphProfileCardProperty[]
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

### Microsoft.Graph.PowerShell.Models.IIdentityDirectoryManagementIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOrganizationSettings

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphOrganizationSettings>: organizationSettings
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[ItemInsights <IMicrosoftGraphInsightsSettings>]`: insightsSettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[DisabledForGroup <String>]`: The ID of an Azure Active Directory group, of which the specified type of insights are disabled for its members. Default is empty. Optional.
    - `[IsEnabledInOrganization <Boolean?>]`: true if the specified type of insights are enabled for the organization; false if the specified type of insights are disabled for all users without exceptions. Default is true. Optional.
  - `[MicrosoftApplicationDataAccess <IMicrosoftGraphMicrosoftApplicationDataAccessSettings>]`: microsoftApplicationDataAccessSettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[DisabledForGroup <String>]`: The ID of an Azure Active Directory (Azure AD) security group for which the members are allowed to access Microsoft 365 data using only Microsoft 365 apps, but not other Microsoft apps such as Edge.  This is only applicable if isEnabledForAllMicrosoftApplications is set to true.
    - `[IsEnabledForAllMicrosoftApplications <Boolean?>]`: When set to true, all users in the organization can access in a Microsoft app any Microsoft 365 data that the user has been authorized to access. The Microsoft app can be a Microsoft 365 app (for example, Excel, Outlook) or non-Microsoft 365 app (for example, Edge). The default is true.  It is possible to disable this access for a subset of users in an Azure AD security group, by specifying the group in the disabledForGroup property.  When set to false, all users can access authorized Microsoft 365 data only in a Microsoft 365 app.
  - `[PeopleInsights <IMicrosoftGraphInsightsSettings>]`: insightsSettings
  - `[ProfileCardProperties <IMicrosoftGraphProfileCardProperty[]>]`: Contains a collection of the properties an administrator has defined as visible on the Microsoft 365 profile card. Get organization settings returns the properties configured for profile cards for the organization.
    - `[Id <String>]`: 
    - `[Annotations <IMicrosoftGraphProfileCardAnnotation[]>]`: Allows an administrator to set a custom display label for the directory property and localize it for the users in their tenant.
      - `[DisplayName <String>]`: If present, the value of this field is used by the profile card as the default property label in the experience (for example, 'Cost Center').
      - `[Localizations <IMicrosoftGraphDisplayNameLocalization[]>]`: Each resource in this collection represents the localized value of the attribute name for a given language, used as the default label for that locale. For example, a user with a no-NB client gets 'Kostnads Senter' as the attribute label, rather than 'Cost Center.'
        - `[DisplayName <String>]`: If present, the value of this field contains the displayName string that has been set for the language present in the languageTag field.
        - `[LanguageTag <String>]`: Provides the language culture-code and friendly name of the language that the displayName field has been provided in.
    - `[DirectoryPropertyName <String>]`: Identifies a profileCardProperty resource in Get, Update, or Delete operations. Allows an administrator to surface hidden Azure Active Directory (Azure AD) properties on the Microsoft 365 profile card within their tenant. When present, the Azure AD field referenced in this field will be visible to all users in your tenant on the contact pane of the profile card. Allowed values for this field are: UserPrincipalName, Fax, StreetAddress, PostalCode, StateOrProvince, Alias, CustomAttribute1,  CustomAttribute2, CustomAttribute3, CustomAttribute4, CustomAttribute5, CustomAttribute6, CustomAttribute7, CustomAttribute8, CustomAttribute9, CustomAttribute10, CustomAttribute11, CustomAttribute12, CustomAttribute13, CustomAttribute14, CustomAttribute15.

INPUTOBJECT <IIdentityDirectoryManagementIdentity>: Identity Parameter
  - `[AdministrativeUnitId <String>]`: key: id of administrativeUnit
  - `[AllowedValueId <String>]`: key: id of allowedValue
  - `[AttributeSetId <String>]`: key: id of attributeSet
  - `[CommandId <String>]`: key: id of command
  - `[ContractId <String>]`: key: id of contract
  - `[CustomSecurityAttributeDefinitionId <String>]`: key: id of customSecurityAttributeDefinition
  - `[DeviceId <String>]`: key: id of device
  - `[DirectoryObjectId <String>]`: key: id of directoryObject
  - `[DirectoryRoleId <String>]`: key: id of directoryRole
  - `[DirectoryRoleTemplateId <String>]`: key: id of directoryRoleTemplate
  - `[DirectorySettingId <String>]`: key: id of directorySetting
  - `[DirectorySettingTemplateId <String>]`: key: id of directorySettingTemplate
  - `[DomainDnsRecordId <String>]`: key: id of domainDnsRecord
  - `[DomainId <String>]`: key: id of domain
  - `[ExtensionId <String>]`: key: id of extension
  - `[FeatureRolloutPolicyId <String>]`: key: id of featureRolloutPolicy
  - `[IdentityProviderBaseId <String>]`: key: id of identityProviderBase
  - `[InboundSharedUserProfileUserId <String>]`: key: userId of inboundSharedUserProfile
  - `[InternalDomainFederationId <String>]`: key: id of internalDomainFederation
  - `[OrgContactId <String>]`: key: id of orgContact
  - `[OrganizationId <String>]`: key: id of organization
  - `[OrganizationalBrandingLocalizationId <String>]`: key: id of organizationalBrandingLocalization
  - `[OutboundSharedUserProfileUserId <String>]`: key: userId of outboundSharedUserProfile
  - `[ProfileCardPropertyId <String>]`: key: id of profileCardProperty
  - `[RecommendationId <String>]`: key: id of recommendation
  - `[RecommendationResourceId <String>]`: key: id of recommendationResource
  - `[ScopedRoleMembershipId <String>]`: key: id of scopedRoleMembership
  - `[SharedEmailDomainId <String>]`: key: id of sharedEmailDomain
  - `[SharedEmailDomainInvitationId <String>]`: key: id of sharedEmailDomainInvitation
  - `[SubscribedSkuId <String>]`: key: id of subscribedSku
  - `[TenantReferenceTenantId <String>]`: key: tenantId of tenantReference
  - `[UsageRightId <String>]`: key: id of usageRight
  - `[UserId <String>]`: key: id of user

ITEMINSIGHTS <IMicrosoftGraphInsightsSettings>: insightsSettings
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[DisabledForGroup <String>]`: The ID of an Azure Active Directory group, of which the specified type of insights are disabled for its members. Default is empty. Optional.
  - `[IsEnabledInOrganization <Boolean?>]`: true if the specified type of insights are enabled for the organization; false if the specified type of insights are disabled for all users without exceptions. Default is true. Optional.

MICROSOFTAPPLICATIONDATAACCESS <IMicrosoftGraphMicrosoftApplicationDataAccessSettings>: microsoftApplicationDataAccessSettings
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[DisabledForGroup <String>]`: The ID of an Azure Active Directory (Azure AD) security group for which the members are allowed to access Microsoft 365 data using only Microsoft 365 apps, but not other Microsoft apps such as Edge.  This is only applicable if isEnabledForAllMicrosoftApplications is set to true.
  - `[IsEnabledForAllMicrosoftApplications <Boolean?>]`: When set to true, all users in the organization can access in a Microsoft app any Microsoft 365 data that the user has been authorized to access. The Microsoft app can be a Microsoft 365 app (for example, Excel, Outlook) or non-Microsoft 365 app (for example, Edge). The default is true.  It is possible to disable this access for a subset of users in an Azure AD security group, by specifying the group in the disabledForGroup property.  When set to false, all users can access authorized Microsoft 365 data only in a Microsoft 365 app.

PEOPLEINSIGHTS <IMicrosoftGraphInsightsSettings>: insightsSettings
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[DisabledForGroup <String>]`: The ID of an Azure Active Directory group, of which the specified type of insights are disabled for its members. Default is empty. Optional.
  - `[IsEnabledInOrganization <Boolean?>]`: true if the specified type of insights are enabled for the organization; false if the specified type of insights are disabled for all users without exceptions. Default is true. Optional.

PROFILECARDPROPERTIES <IMicrosoftGraphProfileCardProperty[]>: Contains a collection of the properties an administrator has defined as visible on the Microsoft 365 profile card. Get organization settings returns the properties configured for profile cards for the organization.
  - `[Id <String>]`: 
  - `[Annotations <IMicrosoftGraphProfileCardAnnotation[]>]`: Allows an administrator to set a custom display label for the directory property and localize it for the users in their tenant.
    - `[DisplayName <String>]`: If present, the value of this field is used by the profile card as the default property label in the experience (for example, 'Cost Center').
    - `[Localizations <IMicrosoftGraphDisplayNameLocalization[]>]`: Each resource in this collection represents the localized value of the attribute name for a given language, used as the default label for that locale. For example, a user with a no-NB client gets 'Kostnads Senter' as the attribute label, rather than 'Cost Center.'
      - `[DisplayName <String>]`: If present, the value of this field contains the displayName string that has been set for the language present in the languageTag field.
      - `[LanguageTag <String>]`: Provides the language culture-code and friendly name of the language that the displayName field has been provided in.
  - `[DirectoryPropertyName <String>]`: Identifies a profileCardProperty resource in Get, Update, or Delete operations. Allows an administrator to surface hidden Azure Active Directory (Azure AD) properties on the Microsoft 365 profile card within their tenant. When present, the Azure AD field referenced in this field will be visible to all users in your tenant on the contact pane of the profile card. Allowed values for this field are: UserPrincipalName, Fax, StreetAddress, PostalCode, StateOrProvince, Alias, CustomAttribute1,  CustomAttribute2, CustomAttribute3, CustomAttribute4, CustomAttribute5, CustomAttribute6, CustomAttribute7, CustomAttribute8, CustomAttribute9, CustomAttribute10, CustomAttribute11, CustomAttribute12, CustomAttribute13, CustomAttribute14, CustomAttribute15.

## RELATED LINKS

