---
external help file:
Module Name: Microsoft.Graph.Beta.Identity.DirectoryManagement
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.identity.directorymanagement/update-mgbetadomainfederationconfiguration
schema: 2.0.0
---

# Update-MgBetaDomainFederationConfiguration

## SYNOPSIS
Update the properties of an internalDomainFederation object.

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaDomainFederationConfiguration -DomainId <String> -InternalDomainFederationId <String>
 [-ActiveSignInUri <String>] [-AdditionalProperties <Hashtable>] [-DisplayName <String>]
 [-FederatedIdpMfaBehavior <String>] [-Id <String>] [-IsSignedAuthenticationRequestRequired]
 [-IssuerUri <String>] [-MetadataExchangeUri <String>] [-NextSigningCertificate <String>]
 [-PassiveSignInUri <String>] [-PreferredAuthenticationProtocol <String>] [-PromptLoginBehavior <String>]
 [-SigningCertificate <String>]
 [-SigningCertificateUpdateStatus <IMicrosoftGraphSigningCertificateUpdateStatus>] [-SignOutUri <String>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaDomainFederationConfiguration -DomainId <String> -InternalDomainFederationId <String>
 -BodyParameter <IMicrosoftGraphInternalDomainFederation> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBetaDomainFederationConfiguration -InputObject <IIdentityDirectoryManagementIdentity>
 -BodyParameter <IMicrosoftGraphInternalDomainFederation> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBetaDomainFederationConfiguration -InputObject <IIdentityDirectoryManagementIdentity>
 [-ActiveSignInUri <String>] [-AdditionalProperties <Hashtable>] [-DisplayName <String>]
 [-FederatedIdpMfaBehavior <String>] [-Id <String>] [-IsSignedAuthenticationRequestRequired]
 [-IssuerUri <String>] [-MetadataExchangeUri <String>] [-NextSigningCertificate <String>]
 [-PassiveSignInUri <String>] [-PreferredAuthenticationProtocol <String>] [-PromptLoginBehavior <String>]
 [-SigningCertificate <String>]
 [-SigningCertificateUpdateStatus <IMicrosoftGraphSigningCertificateUpdateStatus>] [-SignOutUri <String>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the properties of an internalDomainFederation object.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Update-MgBetaDomainFederationConfiguration -DomainId 'contoso.com' -InternalDomainFederationId '2a8ce608-bb34-473f-9e0f-f373ee4cbc5a' -DisplayName "Contoso name change"
```



## PARAMETERS

### -ActiveSignInUri
URL of the endpoint used by active clients when authenticating with federated domains set up for single sign-on in Azure Active Directory (Azure AD).
Corresponds to the ActiveLogOnUri property of the Set-MsolDomainFederationSettings MSOnline v1 PowerShell cmdlet.

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

### -BodyParameter
internalDomainFederation
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphInternalDomainFederation
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DisplayName
The display name of the identity provider.

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

### -DomainId
The unique identifier of domain

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

### -FederatedIdpMfaBehavior
federatedIdpMfaBehavior

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

### -InternalDomainFederationId
The unique identifier of internalDomainFederation

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

### -IsSignedAuthenticationRequestRequired
If true, when SAML authentication requests are sent to the federated SAML IdP, Azure AD will sign those requests using the OrgID signing key.
If false (default), the SAML authentication requests sent to the federated IdP are not signed.

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

### -IssuerUri
Issuer URI of the federation server.

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

### -MetadataExchangeUri
URI of the metadata exchange endpoint used for authentication from rich client applications.

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

### -NextSigningCertificate
Fallback token signing certificate that is used to sign tokens when the primary signing certificate expires.
Formatted as Base64 encoded strings of the public portion of the federated IdP's token signing certificate.
Needs to be compatible with the X509Certificate2 class.
Much like the signingCertificate, the nextSigningCertificate property is used if a rollover is required outside of the auto-rollover update, a new federation service is being set up, or if the new token signing certificate is not present in the federation properties after the federation service certificate has been updated.

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

### -PassiveSignInUri
URI that web-based clients are directed to when signing in to Azure Active Directory (Azure AD) services.

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

### -PreferredAuthenticationProtocol
authenticationProtocol

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

### -PromptLoginBehavior
promptLoginBehavior

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

### -SigningCertificate
Current certificate used to sign tokens passed to the Microsoft identity platform.
The certificate is formatted as a Base64 encoded string of the public portion of the federated IdP's token signing certificate and must be compatible with the X509Certificate2 class.
This property is used in the following scenarios: if a rollover is required outside of the autorollover update a new federation service is being set up if the new token signing certificate isn't present in the federation properties after the federation service certificate has been updated.
Azure AD updates certificates via an autorollover process in which it attempts to retrieve a new certificate from the federation service metadata, 30 days before expiry of the current certificate.
If a new certificate isn't available, Azure AD monitors the metadata daily and will update the federation settings for the domain when a new certificate is available.

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

### -SigningCertificateUpdateStatus
signingCertificateUpdateStatus
To construct, see NOTES section for SIGNINGCERTIFICATEUPDATESTATUS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSigningCertificateUpdateStatus
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SignOutUri
URI that clients are redirected to when they sign out of Azure AD services.
Corresponds to the LogOffUri property of the Set-MsolDomainFederationSettings MSOnline v1 PowerShell cmdlet.

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

### Microsoft.Graph.Beta.PowerShell.Models.IIdentityDirectoryManagementIdentity

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphInternalDomainFederation

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphInternalDomainFederation

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphInternalDomainFederation>`: internalDomainFederation
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[IssuerUri <String>]`: Issuer URI of the federation server.
  - `[MetadataExchangeUri <String>]`: URI of the metadata exchange endpoint used for authentication from rich client applications.
  - `[PassiveSignInUri <String>]`: URI that web-based clients are directed to when signing in to Azure Active Directory (Azure AD) services.
  - `[PreferredAuthenticationProtocol <String>]`: authenticationProtocol
  - `[SigningCertificate <String>]`: Current certificate used to sign tokens passed to the Microsoft identity platform. The certificate is formatted as a Base64 encoded string of the public portion of the federated IdP's token signing certificate and must be compatible with the X509Certificate2 class.   This property is used in the following scenarios:  if a rollover is required outside of the autorollover update a new federation service is being set up  if the new token signing certificate isn't present in the federation properties after the federation service certificate has been updated.   Azure AD updates certificates via an autorollover process in which it attempts to retrieve a new certificate from the federation service metadata, 30 days before expiry of the current certificate. If a new certificate isn't available, Azure AD monitors the metadata daily and will update the federation settings for the domain when a new certificate is available.
  - `[DisplayName <String>]`: The display name of the identity provider.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[ActiveSignInUri <String>]`: URL of the endpoint used by active clients when authenticating with federated domains set up for single sign-on in Azure Active Directory (Azure AD). Corresponds to the ActiveLogOnUri property of the Set-MsolDomainFederationSettings MSOnline v1 PowerShell cmdlet.
  - `[FederatedIdpMfaBehavior <String>]`: federatedIdpMfaBehavior
  - `[IsSignedAuthenticationRequestRequired <Boolean?>]`: If true, when SAML authentication requests are sent to the federated SAML IdP, Azure AD will sign those requests using the OrgID signing key. If false (default), the SAML authentication requests sent to the federated IdP are not signed.
  - `[NextSigningCertificate <String>]`: Fallback token signing certificate that is used to sign tokens when the primary signing certificate expires. Formatted as Base64 encoded strings of the public portion of the federated IdP's token signing certificate. Needs to be compatible with the X509Certificate2 class. Much like the signingCertificate, the nextSigningCertificate property is used if a rollover is required outside of the auto-rollover update, a new federation service is being set up, or if the new token signing certificate is not present in the federation properties after the federation service certificate has been updated.
  - `[PromptLoginBehavior <String>]`: promptLoginBehavior
  - `[SignOutUri <String>]`: URI that clients are redirected to when they sign out of Azure AD services. Corresponds to the LogOffUri property of the Set-MsolDomainFederationSettings MSOnline v1 PowerShell cmdlet.
  - `[SigningCertificateUpdateStatus <IMicrosoftGraphSigningCertificateUpdateStatus>]`: signingCertificateUpdateStatus
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[CertificateUpdateResult <String>]`: Status of the last certificate update. Read-only. For a list of statuses, see certificateUpdateResult status.
    - `[LastRunDateTime <DateTime?>]`: Date and time in ISO 8601 format and in UTC time when the certificate was last updated. Read-only.

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

`SIGNINGCERTIFICATEUPDATESTATUS <IMicrosoftGraphSigningCertificateUpdateStatus>`: signingCertificateUpdateStatus
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CertificateUpdateResult <String>]`: Status of the last certificate update. Read-only. For a list of statuses, see certificateUpdateResult status.
  - `[LastRunDateTime <DateTime?>]`: Date and time in ISO 8601 format and in UTC time when the certificate was last updated. Read-only.

## RELATED LINKS

