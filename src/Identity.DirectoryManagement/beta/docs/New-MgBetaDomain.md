---
external help file:
Module Name: Microsoft.Graph.Beta.Identity.DirectoryManagement
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.identity.directorymanagement/new-mgbetadomain
schema: 2.0.0
---

# New-MgBetaDomain

## SYNOPSIS
Adds a domain to the tenant.
Important: You cannot use an associated domain with your Microsoft Entra tenant until ownership is verified.
See List verificationDnsRecords for details.
Root domains require verification.
For example, contoso.com requires verification.
If a root domain is verified, subdomains of the root domain are automatically verified.
For example, subdomain.contoso.com is automatically be verified if contoso.com has been verified.

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaDomain [-AdditionalProperties <Hashtable>] [-AuthenticationType <String>]
 [-AvailabilityStatus <String>] [-DomainNameReferences <IMicrosoftGraphDirectoryObject[]>]
 [-FederationConfiguration <IMicrosoftGraphInternalDomainFederation[]>] [-Id <String>] [-IsAdminManaged]
 [-IsDefault] [-IsInitial] [-IsRoot] [-IsVerified] [-PasswordNotificationWindowInDays <Int32>]
 [-PasswordValidityPeriodInDays <Int32>] [-ResponseHeadersVariable <String>]
 [-ServiceConfigurationRecords <IMicrosoftGraphDomainDnsRecord[]>]
 [-SharedEmailDomainInvitations <IMicrosoftGraphSharedEmailDomainInvitation[]>]
 [-State <IMicrosoftGraphDomainState>] [-SupportedServices <String[]>]
 [-VerificationDnsRecords <IMicrosoftGraphDomainDnsRecord[]>] [-Headers <IDictionary>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgBetaDomain -BodyParameter <IMicrosoftGraphDomain> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Adds a domain to the tenant.
Important: You cannot use an associated domain with your Microsoft Entra tenant until ownership is verified.
See List verificationDnsRecords for details.
Root domains require verification.
For example, contoso.com requires verification.
If a root domain is verified, subdomains of the root domain are automatically verified.
For example, subdomain.contoso.com is automatically be verified if contoso.com has been verified.

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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AuthenticationType
Indicates the configured authentication type for the domain.
The value is either Managed or Federated.
Managed indicates a cloud managed domain where Microsoft Entra ID performs user authentication.
Federated indicates authentication is federated with an identity provider such as the tenant's on-premises Active Directory via Active Directory Federation Services.
Not nullable.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AvailabilityStatus
This property is always null except when the verify action is used.
When the verify action is used, a domain entity is returned in the response.
The availabilityStatus property of the domain entity in the response is either AvailableImmediately or EmailVerifiedDomainTakeoverScheduled.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
domain
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDomain
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DomainNameReferences
The objects such as users and groups that reference the domain ID.
Read-only, Nullable.
Supports $expand and $filter by the OData type of objects returned.
For example /domains/{domainId}/domainNameReferences/microsoft.graph.user and /domains/{domainId}/domainNameReferences/microsoft.graph.group.
To construct, see NOTES section for DOMAINNAMEREFERENCES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDirectoryObject[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FederationConfiguration
Domain settings configured by customer when federated with Microsoft Entra ID.
Supports $expand.
To construct, see NOTES section for FEDERATIONCONFIGURATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphInternalDomainFederation[]
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsAdminManaged
The value of the property is false if the DNS record management of the domain has been delegated to Microsoft 365.
Otherwise, the value is true.
Not nullable

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsDefault
true if this is the default domain that is used for user creation.
There is only one default domain per company.
Not nullable

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsInitial
true if this is the initial domain created by Microsoft Online Services (contoso.com).
There is only one initial domain per company.
Not nullable

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsRoot
true if the domain is a verified root domain.
Otherwise, false if the domain is a subdomain or unverified.
Not nullable

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsVerified
true if the domain has completed domain ownership verification.
Not nullable

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PasswordNotificationWindowInDays
Specifies the number of days before a user receives notification that their password will expire.
If the property is not set, a default value of 14 days will be used.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PasswordValidityPeriodInDays
Specifies the length of time that a password is valid before it must be changed.
If the property is not set, a default value of 90 days will be used.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded
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

### -ServiceConfigurationRecords
DNS records the customer adds to the DNS zone file of the domain before the domain can be used by Microsoft Online services.
Read-only, Nullable.
Supports $expand.
To construct, see NOTES section for SERVICECONFIGURATIONRECORDS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDomainDnsRecord[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SharedEmailDomainInvitations
.
To construct, see NOTES section for SHAREDEMAILDOMAININVITATIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSharedEmailDomainInvitation[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -State
domainState
To construct, see NOTES section for STATE properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDomainState
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SupportedServices
The capabilities assigned to the domain.
Can include 0, 1 or more of following values: Email, Sharepoint, EmailInternalRelayOnly, OfficeCommunicationsOnline,SharePointDefaultDomain, FullRedelegation, SharePointPublic, OrgIdAuthentication, Yammer, Intune.
The values which you can add/remove using Graph API include: Email, OfficeCommunicationsOnline, Yammer.
Not nullable.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VerificationDnsRecords
DNS records that the customer adds to the DNS zone file of the domain before the customer can complete domain ownership verification with Microsoft Entra ID.
Read-only, Nullable.
Supports $expand.
To construct, see NOTES section for VERIFICATIONDNSRECORDS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDomainDnsRecord[]
Parameter Sets: CreateExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDomain

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDomain

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphDomain>`: domain
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AuthenticationType <String>]`: Indicates the configured authentication type for the domain. The value is either Managed or Federated. Managed indicates a cloud managed domain where Microsoft Entra ID performs user authentication. Federated indicates authentication is federated with an identity provider such as the tenant's on-premises Active Directory via Active Directory Federation Services. Not nullable.
  - `[AvailabilityStatus <String>]`: This property is always null except when the verify action is used. When the verify action is used, a domain entity is returned in the response. The availabilityStatus property of the domain entity in the response is either AvailableImmediately or EmailVerifiedDomainTakeoverScheduled.
  - `[DomainNameReferences <IMicrosoftGraphDirectoryObject[]>]`: The objects such as users and groups that reference the domain ID. Read-only, Nullable. Supports $expand and $filter by the OData type of objects returned. For example /domains/{domainId}/domainNameReferences/microsoft.graph.user and /domains/{domainId}/domainNameReferences/microsoft.graph.group.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
  - `[FederationConfiguration <IMicrosoftGraphInternalDomainFederation[]>]`: Domain settings configured by customer when federated with Microsoft Entra ID. Supports $expand.
    - `[IssuerUri <String>]`: Issuer URI of the federation server.
    - `[MetadataExchangeUri <String>]`: URI of the metadata exchange endpoint used for authentication from rich client applications.
    - `[PassiveSignInUri <String>]`: URI that web-based clients are directed to when signing in to Microsoft Entra services.
    - `[PreferredAuthenticationProtocol <String>]`: authenticationProtocol
    - `[SigningCertificate <String>]`: Current certificate used to sign tokens passed to the Microsoft identity platform. The certificate is formatted as a Base64 encoded string of the public portion of the federated IdP's token signing certificate and must be compatible with the X509Certificate2 class.   This property is used in the following scenarios:  if a rollover is required outside of the autorollover update a new federation service is being set up  if the new token signing certificate isn't present in the federation properties after the federation service certificate has been updated.   Microsoft Entra ID updates certificates via an autorollover process in which it attempts to retrieve a new certificate from the federation service metadata, 30 days before expiry of the current certificate. If a new certificate isn't available, Microsoft Entra ID monitors the metadata daily and will update the federation settings for the domain when a new certificate is available.
    - `[DisplayName <String>]`: The display name of the identity provider.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[ActiveSignInUri <String>]`: URL of the endpoint used by active clients when authenticating with federated domains set up for single sign-on in Microsoft Entra ID. Corresponds to the ActiveLogOnUri property of the Set-MsolDomainFederationSettings MSOnline v1 PowerShell cmdlet.
    - `[FederatedIdpMfaBehavior <String>]`: federatedIdpMfaBehavior
    - `[IsSignedAuthenticationRequestRequired <Boolean?>]`: If true, when SAML authentication requests are sent to the federated SAML IdP, Microsoft Entra ID will sign those requests using the OrgID signing key. If false (default), the SAML authentication requests sent to the federated IdP aren't signed.
    - `[NextSigningCertificate <String>]`: Fallback token signing certificate that can also be used to sign tokens, for example when the primary signing certificate expires. Formatted as Base64 encoded strings of the public portion of the federated IdP's token signing certificate. Needs to be compatible with the X509Certificate2 class. Much like the signingCertificate, the nextSigningCertificate property is used if a rollover is required outside of the auto-rollover update, a new federation service is being set up, or if the new token signing certificate isn't present in the federation properties after the federation service certificate has been updated.
    - `[PromptLoginBehavior <String>]`: promptLoginBehavior
    - `[SignOutUri <String>]`: URI that clients are redirected to when they sign out of Microsoft Entra services. Corresponds to the LogOffUri property of the Set-MsolDomainFederationSettings MSOnline v1 PowerShell cmdlet.
    - `[SigningCertificateUpdateStatus <IMicrosoftGraphSigningCertificateUpdateStatus>]`: signingCertificateUpdateStatus
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[CertificateUpdateResult <String>]`: Status of the last certificate update. Read-only. For a list of statuses, see certificateUpdateResult status.
      - `[LastRunDateTime <DateTime?>]`: Date and time in ISO 8601 format and in UTC time when the certificate was last updated. Read-only.
  - `[IsAdminManaged <Boolean?>]`: The value of the property is false if the DNS record management of the domain has been delegated to Microsoft 365. Otherwise, the value is true. Not nullable
  - `[IsDefault <Boolean?>]`: true if this is the default domain that is used for user creation. There is only one default domain per company. Not nullable
  - `[IsInitial <Boolean?>]`: true if this is the initial domain created by Microsoft Online Services (contoso.com). There is only one initial domain per company. Not nullable
  - `[IsRoot <Boolean?>]`: true if the domain is a verified root domain. Otherwise, false if the domain is a subdomain or unverified. Not nullable
  - `[IsVerified <Boolean?>]`: true if the domain has completed domain ownership verification. Not nullable
  - `[PasswordNotificationWindowInDays <Int32?>]`: Specifies the number of days before a user receives notification that their password will expire. If the property is not set, a default value of 14 days will be used.
  - `[PasswordValidityPeriodInDays <Int32?>]`: Specifies the length of time that a password is valid before it must be changed. If the property is not set, a default value of 90 days will be used.
  - `[ServiceConfigurationRecords <IMicrosoftGraphDomainDnsRecord[]>]`: DNS records the customer adds to the DNS zone file of the domain before the domain can be used by Microsoft Online services. Read-only, Nullable. Supports $expand.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[IsOptional <Boolean?>]`: If false, this record must be configured by the customer at the DNS host for Microsoft Online Services to operate correctly with the domain.
    - `[Label <String>]`: Value used when configuring the name of the DNS record at the DNS host.
    - `[RecordType <String>]`: Indicates what type of DNS record this entity represents. The value can be one of the following: CName, Mx, Srv, Txt.
    - `[SupportedService <String>]`: Microsoft Online Service or feature that has a dependency on this DNS record. Can be one of the following values: null, Email, Sharepoint, EmailInternalRelayOnly, OfficeCommunicationsOnline, SharePointDefaultDomain, FullRedelegation, SharePointPublic, OrgIdAuthentication, Yammer, Intune.
    - `[Ttl <Int32?>]`: Value to use when configuring the time-to-live (ttl) property of the DNS record at the DNS host. Not nullable.
  - `[SharedEmailDomainInvitations <IMicrosoftGraphSharedEmailDomainInvitation[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[ExpiryTime <DateTime?>]`: 
    - `[InvitationDomain <String>]`: 
    - `[InvitationStatus <String>]`: 
  - `[State <IMicrosoftGraphDomainState>]`: domainState
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[LastActionDateTime <DateTime?>]`: Timestamp for when the last activity occurred. The value is updated when an operation is scheduled, the asynchronous task starts, and when the operation completes.
    - `[Operation <String>]`: Type of asynchronous operation. The values can be ForceDelete or Verification
    - `[Status <String>]`: Current status of the operation.  Scheduled - Operation has been scheduled but has not started.  InProgress - Task has started and is in progress.  Failed - Operation has failed.
  - `[SupportedServices <String[]>]`: The capabilities assigned to the domain. Can include 0, 1 or more of following values: Email, Sharepoint, EmailInternalRelayOnly, OfficeCommunicationsOnline,SharePointDefaultDomain, FullRedelegation, SharePointPublic, OrgIdAuthentication, Yammer, Intune. The values which you can add/remove using Graph API include: Email, OfficeCommunicationsOnline, Yammer. Not nullable.
  - `[VerificationDnsRecords <IMicrosoftGraphDomainDnsRecord[]>]`: DNS records that the customer adds to the DNS zone file of the domain before the customer can complete domain ownership verification with Microsoft Entra ID. Read-only, Nullable. Supports $expand.

`DOMAINNAMEREFERENCES <IMicrosoftGraphDirectoryObject[]>`: The objects such as users and groups that reference the domain ID. Read-only, Nullable. Supports $expand and $filter by the OData type of objects returned. For example /domains/{domainId}/domainNameReferences/microsoft.graph.user and /domains/{domainId}/domainNameReferences/microsoft.graph.group.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.

`FEDERATIONCONFIGURATION <IMicrosoftGraphInternalDomainFederation[]>`: Domain settings configured by customer when federated with Microsoft Entra ID. Supports $expand.
  - `[IssuerUri <String>]`: Issuer URI of the federation server.
  - `[MetadataExchangeUri <String>]`: URI of the metadata exchange endpoint used for authentication from rich client applications.
  - `[PassiveSignInUri <String>]`: URI that web-based clients are directed to when signing in to Microsoft Entra services.
  - `[PreferredAuthenticationProtocol <String>]`: authenticationProtocol
  - `[SigningCertificate <String>]`: Current certificate used to sign tokens passed to the Microsoft identity platform. The certificate is formatted as a Base64 encoded string of the public portion of the federated IdP's token signing certificate and must be compatible with the X509Certificate2 class.   This property is used in the following scenarios:  if a rollover is required outside of the autorollover update a new federation service is being set up  if the new token signing certificate isn't present in the federation properties after the federation service certificate has been updated.   Microsoft Entra ID updates certificates via an autorollover process in which it attempts to retrieve a new certificate from the federation service metadata, 30 days before expiry of the current certificate. If a new certificate isn't available, Microsoft Entra ID monitors the metadata daily and will update the federation settings for the domain when a new certificate is available.
  - `[DisplayName <String>]`: The display name of the identity provider.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[ActiveSignInUri <String>]`: URL of the endpoint used by active clients when authenticating with federated domains set up for single sign-on in Microsoft Entra ID. Corresponds to the ActiveLogOnUri property of the Set-MsolDomainFederationSettings MSOnline v1 PowerShell cmdlet.
  - `[FederatedIdpMfaBehavior <String>]`: federatedIdpMfaBehavior
  - `[IsSignedAuthenticationRequestRequired <Boolean?>]`: If true, when SAML authentication requests are sent to the federated SAML IdP, Microsoft Entra ID will sign those requests using the OrgID signing key. If false (default), the SAML authentication requests sent to the federated IdP aren't signed.
  - `[NextSigningCertificate <String>]`: Fallback token signing certificate that can also be used to sign tokens, for example when the primary signing certificate expires. Formatted as Base64 encoded strings of the public portion of the federated IdP's token signing certificate. Needs to be compatible with the X509Certificate2 class. Much like the signingCertificate, the nextSigningCertificate property is used if a rollover is required outside of the auto-rollover update, a new federation service is being set up, or if the new token signing certificate isn't present in the federation properties after the federation service certificate has been updated.
  - `[PromptLoginBehavior <String>]`: promptLoginBehavior
  - `[SignOutUri <String>]`: URI that clients are redirected to when they sign out of Microsoft Entra services. Corresponds to the LogOffUri property of the Set-MsolDomainFederationSettings MSOnline v1 PowerShell cmdlet.
  - `[SigningCertificateUpdateStatus <IMicrosoftGraphSigningCertificateUpdateStatus>]`: signingCertificateUpdateStatus
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[CertificateUpdateResult <String>]`: Status of the last certificate update. Read-only. For a list of statuses, see certificateUpdateResult status.
    - `[LastRunDateTime <DateTime?>]`: Date and time in ISO 8601 format and in UTC time when the certificate was last updated. Read-only.

`SERVICECONFIGURATIONRECORDS <IMicrosoftGraphDomainDnsRecord[]>`: DNS records the customer adds to the DNS zone file of the domain before the domain can be used by Microsoft Online services. Read-only, Nullable. Supports $expand.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[IsOptional <Boolean?>]`: If false, this record must be configured by the customer at the DNS host for Microsoft Online Services to operate correctly with the domain.
  - `[Label <String>]`: Value used when configuring the name of the DNS record at the DNS host.
  - `[RecordType <String>]`: Indicates what type of DNS record this entity represents. The value can be one of the following: CName, Mx, Srv, Txt.
  - `[SupportedService <String>]`: Microsoft Online Service or feature that has a dependency on this DNS record. Can be one of the following values: null, Email, Sharepoint, EmailInternalRelayOnly, OfficeCommunicationsOnline, SharePointDefaultDomain, FullRedelegation, SharePointPublic, OrgIdAuthentication, Yammer, Intune.
  - `[Ttl <Int32?>]`: Value to use when configuring the time-to-live (ttl) property of the DNS record at the DNS host. Not nullable.

`SHAREDEMAILDOMAININVITATIONS <IMicrosoftGraphSharedEmailDomainInvitation[]>`: .
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[ExpiryTime <DateTime?>]`: 
  - `[InvitationDomain <String>]`: 
  - `[InvitationStatus <String>]`: 

`STATE <IMicrosoftGraphDomainState>`: domainState
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[LastActionDateTime <DateTime?>]`: Timestamp for when the last activity occurred. The value is updated when an operation is scheduled, the asynchronous task starts, and when the operation completes.
  - `[Operation <String>]`: Type of asynchronous operation. The values can be ForceDelete or Verification
  - `[Status <String>]`: Current status of the operation.  Scheduled - Operation has been scheduled but has not started.  InProgress - Task has started and is in progress.  Failed - Operation has failed.

`VERIFICATIONDNSRECORDS <IMicrosoftGraphDomainDnsRecord[]>`: DNS records that the customer adds to the DNS zone file of the domain before the customer can complete domain ownership verification with Microsoft Entra ID. Read-only, Nullable. Supports $expand.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[IsOptional <Boolean?>]`: If false, this record must be configured by the customer at the DNS host for Microsoft Online Services to operate correctly with the domain.
  - `[Label <String>]`: Value used when configuring the name of the DNS record at the DNS host.
  - `[RecordType <String>]`: Indicates what type of DNS record this entity represents. The value can be one of the following: CName, Mx, Srv, Txt.
  - `[SupportedService <String>]`: Microsoft Online Service or feature that has a dependency on this DNS record. Can be one of the following values: null, Email, Sharepoint, EmailInternalRelayOnly, OfficeCommunicationsOnline, SharePointDefaultDomain, FullRedelegation, SharePointPublic, OrgIdAuthentication, Yammer, Intune.
  - `[Ttl <Int32?>]`: Value to use when configuring the time-to-live (ttl) property of the DNS record at the DNS host. Not nullable.

## RELATED LINKS

