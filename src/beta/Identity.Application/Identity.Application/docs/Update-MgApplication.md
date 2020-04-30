---
external help file:
Module Name: Microsoft.Graph.Identity.Application
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.application/update-mgapplication
schema: 2.0.0
---

# Update-MgApplication

## SYNOPSIS
Update entity in applications

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgApplication -ApplicationId <String> [-ApiAcceptMappedClaims] [-ApiKnownClientApplications <String[]>]
 [-ApiOauth2PermissionScopes <IMicrosoftGraphPermissionScope[]>]
 [-ApiPreAuthorizedApplications <IMicrosoftGraphPreAuthorizedApplication[]>]
 [-ApiRequestedAccessTokenVersion <Int32>] [-AppId <String>] [-AppRoles <IMicrosoftGraphAppRole[]>]
 [-ClaimsMappingPolicies <IMicrosoftGraphClaimsMappingPolicy[]>] [-CreatedDateTime <DateTime>]
 [-CreatedOnBehalfOf <IMicrosoftGraphDirectoryObject>] [-DeletedDateTime <DateTime>] [-DisplayName <String>]
 [-ExtensionProperties <IMicrosoftGraphExtensionProperty[]>] [-GroupMembershipClaims <String>]
 [-HomeRealmDiscoveryPolicies <IMicrosoftGraphHomeRealmDiscoveryPolicy[]>] [-Id <String>]
 [-IdentifierUris <String[]>] [-ImplicitGrantSettingEnableAccessTokenIssuance]
 [-ImplicitGrantSettingEnableIdTokenIssuance] [-InfoLogoUrl <String>] [-InfoMarketingUrl <String>]
 [-InfoPrivacyStatementUrl <String>] [-InfoSupportUrl <String>] [-InfoTermsOfServiceUrl <String>]
 [-IsDeviceOnlyAuthSupported] [-IsFallbackPublicClient] [-KeyCredentials <IMicrosoftGraphKeyCredential[]>]
 [-LogoInputFile <String>] [-OptionalClaimAccessToken <IMicrosoftGraphOptionalClaim[]>]
 [-OptionalClaimIdToken <IMicrosoftGraphOptionalClaim[]>]
 [-OptionalClaimSaml2Token <IMicrosoftGraphOptionalClaim[]>] [-Owners <IMicrosoftGraphDirectoryObject[]>]
 [-ParentalControlSettingCountriesBlockedForMinors <String[]>]
 [-ParentalControlSettingLegalAgeGroupRule <String>]
 [-PasswordCredentials <IMicrosoftGraphPasswordCredential[]>] [-PublicClientRedirectUris <String[]>]
 [-PublisherDomain <String>] [-RequiredResourceAccess <IMicrosoftGraphRequiredResourceAccess[]>]
 [-SignInAudience <String>] [-SynchronizationId <String>]
 [-SynchronizationJobs <IMicrosoftGraphSynchronizationJob[]>]
 [-SynchronizationSecrets <IMicrosoftGraphSynchronizationSecretKeyStringValuePair[]>]
 [-SynchronizationTemplates <IMicrosoftGraphSynchronizationTemplate[]>] [-Tags <String[]>]
 [-TokenEncryptionKeyId <String>] [-TokenIssuancePolicies <IMicrosoftGraphTokenIssuancePolicy[]>]
 [-TokenLifetimePolicies <IMicrosoftGraphTokenLifetimePolicy[]>] [-WebHomePageUrl <String>]
 [-WebLogoutUrl <String>] [-WebOauth2AllowImplicitFlow] [-WebRedirectUris <String[]>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgApplication -ApplicationId <String> -BodyParameter <IMicrosoftGraphApplication> [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgApplication -InputObject <IIdentityApplicationIdentity> -BodyParameter <IMicrosoftGraphApplication>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgApplication -InputObject <IIdentityApplicationIdentity> [-ApiAcceptMappedClaims]
 [-ApiKnownClientApplications <String[]>] [-ApiOauth2PermissionScopes <IMicrosoftGraphPermissionScope[]>]
 [-ApiPreAuthorizedApplications <IMicrosoftGraphPreAuthorizedApplication[]>]
 [-ApiRequestedAccessTokenVersion <Int32>] [-AppId <String>] [-AppRoles <IMicrosoftGraphAppRole[]>]
 [-ClaimsMappingPolicies <IMicrosoftGraphClaimsMappingPolicy[]>] [-CreatedDateTime <DateTime>]
 [-CreatedOnBehalfOf <IMicrosoftGraphDirectoryObject>] [-DeletedDateTime <DateTime>] [-DisplayName <String>]
 [-ExtensionProperties <IMicrosoftGraphExtensionProperty[]>] [-GroupMembershipClaims <String>]
 [-HomeRealmDiscoveryPolicies <IMicrosoftGraphHomeRealmDiscoveryPolicy[]>] [-Id <String>]
 [-IdentifierUris <String[]>] [-ImplicitGrantSettingEnableAccessTokenIssuance]
 [-ImplicitGrantSettingEnableIdTokenIssuance] [-InfoLogoUrl <String>] [-InfoMarketingUrl <String>]
 [-InfoPrivacyStatementUrl <String>] [-InfoSupportUrl <String>] [-InfoTermsOfServiceUrl <String>]
 [-IsDeviceOnlyAuthSupported] [-IsFallbackPublicClient] [-KeyCredentials <IMicrosoftGraphKeyCredential[]>]
 [-LogoInputFile <String>] [-OptionalClaimAccessToken <IMicrosoftGraphOptionalClaim[]>]
 [-OptionalClaimIdToken <IMicrosoftGraphOptionalClaim[]>]
 [-OptionalClaimSaml2Token <IMicrosoftGraphOptionalClaim[]>] [-Owners <IMicrosoftGraphDirectoryObject[]>]
 [-ParentalControlSettingCountriesBlockedForMinors <String[]>]
 [-ParentalControlSettingLegalAgeGroupRule <String>]
 [-PasswordCredentials <IMicrosoftGraphPasswordCredential[]>] [-PublicClientRedirectUris <String[]>]
 [-PublisherDomain <String>] [-RequiredResourceAccess <IMicrosoftGraphRequiredResourceAccess[]>]
 [-SignInAudience <String>] [-SynchronizationId <String>]
 [-SynchronizationJobs <IMicrosoftGraphSynchronizationJob[]>]
 [-SynchronizationSecrets <IMicrosoftGraphSynchronizationSecretKeyStringValuePair[]>]
 [-SynchronizationTemplates <IMicrosoftGraphSynchronizationTemplate[]>] [-Tags <String[]>]
 [-TokenEncryptionKeyId <String>] [-TokenIssuancePolicies <IMicrosoftGraphTokenIssuancePolicy[]>]
 [-TokenLifetimePolicies <IMicrosoftGraphTokenLifetimePolicy[]>] [-WebHomePageUrl <String>]
 [-WebLogoutUrl <String>] [-WebOauth2AllowImplicitFlow] [-WebRedirectUris <String[]>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update entity in applications

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

## PARAMETERS

### -ApiAcceptMappedClaims
When true, allows an application to use claims mapping without specifying a custom signing key.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ApiKnownClientApplications
Used for bundling consent if you have a solution that contains two parts: a client app and a custom web API app.
If you set the appID of the client app to this value, the user only consents once to the client app.
Azure AD knows that consenting to the client means implicitly consenting to the web API and automatically provisions service principals for both APIs at the same time.
Both the client and the web API app must be registered in the same tenant.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ApiOauth2PermissionScopes
The collection of OAuth 2.0 permission scopes that the web API (resource) application exposes to client applications.
These permission scopes may be granted to client applications during consent.
To construct, see NOTES section for APIOAUTH2PERMISSIONSCOPES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPermissionScope[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ApiPreAuthorizedApplications
Lists the client applications that are pre-authorized with the specified delegated permissions to access this application's APIs.
Users are not required to consent to any pre-authorized application (for the permissions specified).
However, any additional permissions not listed in preAuthorizedApplications (requested through incremental consent for example) will require user consent.
To construct, see NOTES section for APIPREAUTHORIZEDAPPLICATIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPreAuthorizedApplication[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ApiRequestedAccessTokenVersion
Specifies the access token version expected by this resource.
This changes the version and format of the JWT produced independent of the endpoint or client used to request the access token.
The endpoint used, v1.0 or v2.0, is chosen by the client and only impacts the version of id_tokens.
Resources need to explicitly configure requestedAccessTokenVersion to indicate the supported access token format.
Possible values for requestedAccessTokenVersion are 1, 2, or null.
If the value is null, this defaults to 1, which corresponds to the v1.0 endpoint.
If signInAudience on the application is configured as AzureADandPersonalMicrosoftAccount, the value for this property must be 2

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -AppId
The unique identifier for the application that is assigned to an application by Azure AD.
Not nullable.
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
Dynamic: False
```

### -ApplicationId
key: application-id of application

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -AppRoles
The collection of application roles that an application may declare.
These roles can be assigned to users, groups, or service principals.
Not nullable.
To construct, see NOTES section for APPROLES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAppRole[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -BodyParameter
Represents an Azure Active Directory object.
The directoryObject type is the base type for many other directory entity types.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphApplication
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -ClaimsMappingPolicies
.
To construct, see NOTES section for CLAIMSMAPPINGPOLICIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphClaimsMappingPolicy[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -CreatedDateTime
The date and time the application was registered.
Read-only.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -CreatedOnBehalfOf
Represents an Azure Active Directory object.
The directoryObject type is the base type for many other directory entity types.
To construct, see NOTES section for CREATEDONBEHALFOF properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectoryObject
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -DeletedDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -DisplayName
The display name for the application.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ExtensionProperties
Read-only.
Nullable.
To construct, see NOTES section for EXTENSIONPROPERTIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphExtensionProperty[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -GroupMembershipClaims
Configures the groups claim issued in a user or OAuth 2.0 access token that the application expects.
To set this attribute, use one of the following valid string values:NoneSecurityGroup: For security groups and Azure AD rolesAll: This will get all of the security groups, distribution groups, and Azure AD directory roles that the signed-in user is a member of

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -HomeRealmDiscoveryPolicies
.
To construct, see NOTES section for HOMEREALMDISCOVERYPOLICIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphHomeRealmDiscoveryPolicy[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Id
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
Dynamic: False
```

### -IdentifierUris
The URIs that identify the application within its Azure AD tenant, or within a verified custom domain if the application is multi-tenant.
For more information see Application Objects and Service Principal Objects.
The any operator is required for filter expressions on multi-valued properties.
Not nullable.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ImplicitGrantSettingEnableAccessTokenIssuance
Specifies whether this web application can request an access token using the OAuth 2.0 implicit flow.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ImplicitGrantSettingEnableIdTokenIssuance
Specifies whether this web application can request an ID token using the OAuth 2.0 implicit flow.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -InfoLogoUrl
CDN URL to the application's logo, Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -InfoMarketingUrl
Link to the application's marketing page.
For example, https://www.contoso.com/app/marketing

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -InfoPrivacyStatementUrl
Link to the application's privacy statement.
For example, https://www.contoso.com/app/privacy

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -InfoSupportUrl
Link to the application's support page.
For example, https://www.contoso.com/app/support

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -InfoTermsOfServiceUrl
Link to the application's terms of service statement.
For example, https://www.contoso.com/app/termsofservice

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IIdentityApplicationIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -IsDeviceOnlyAuthSupported
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -IsFallbackPublicClient
Specifies the fallback application type as public client, such as an installed application running on a mobile device.
The default value is false which means the fallback application type is confidential client such as web app.
There are certain scenarios where Azure AD cannot determine the client application type (e.g.
ROPC flow where it is configured without specifying a redirect URI).
In those cases Azure AD will interpret the application type based on the value of this property.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -KeyCredentials
The collection of key credentials associated with the application Not nullable.
To construct, see NOTES section for KEYCREDENTIALS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphKeyCredential[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -LogoInputFile
Input File for Logo (The main logo for the application.
Not nullable.)

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -OptionalClaimAccessToken
The optional claims returned in the JWT access token.
To construct, see NOTES section for OPTIONALCLAIMACCESSTOKEN properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOptionalClaim[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -OptionalClaimIdToken
The optional claims returned in the JWT ID token.
To construct, see NOTES section for OPTIONALCLAIMIDTOKEN properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOptionalClaim[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -OptionalClaimSaml2Token
The optional claims returned in the SAML token.
To construct, see NOTES section for OPTIONALCLAIMSAML2TOKEN properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOptionalClaim[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Owners
Directory objects that are owners of the application.
The owners are a set of non-admin users who are allowed to modify this object.
Requires version 2013-11-08 or newer.
Read-only.
Nullable.
To construct, see NOTES section for OWNERS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectoryObject[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ParentalControlSettingCountriesBlockedForMinors
Specifies the two-letter ISO country codes.
Access to the application will be blocked for minors from the countries specified in this list.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ParentalControlSettingLegalAgeGroupRule
Specifies the legal age group rule that applies to users of the app.
Can be set to one of the following values: ValueDescriptionAllowDefault.
Enforces the legal minimum.
This means parental consent is required for minors in the European Union and Korea.RequireConsentForPrivacyServicesEnforces the user to specify date of birth to comply with COPPA rules.
RequireConsentForMinorsRequires parental consent for ages below 18, regardless of country minor rules.RequireConsentForKidsRequires parental consent for ages below 14, regardless of country minor rules.BlockMinorsBlocks minors from using the app.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
```

### -PasswordCredentials
The collection of password credentials associated with the application.
Not nullable.
To construct, see NOTES section for PASSWORDCREDENTIALS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPasswordCredential[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -PublicClientRedirectUris
Specifies the URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -PublisherDomain
The verified publisher domain for the application.
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
Dynamic: False
```

### -RequiredResourceAccess
Specifies resources that this application requires access to and the set of OAuth permission scopes and application roles that it needs under each of those resources.
This pre-configuration of required resource access drives the consent experience.
Not nullable.
To construct, see NOTES section for REQUIREDRESOURCEACCESS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRequiredResourceAccess[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SignInAudience
Specifies what Microsoft accounts are supported for the current application.
Supported values are:AzureADMyOrg: Users with a Microsoft work or school account in my organization’s Azure AD tenant (i.e.
single tenant)AzureADMultipleOrgs: Users with a Microsoft work or school account in any organization’s Azure AD tenant (i.e.
multi-tenant) AzureADandPersonalMicrosoftAccount: Users with a personal Microsoft account, or a work or school account in any organization’s Azure AD tenant

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SynchronizationId
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
Dynamic: False
```

### -SynchronizationJobs
.
To construct, see NOTES section for SYNCHRONIZATIONJOBS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSynchronizationJob[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SynchronizationSecrets
.
To construct, see NOTES section for SYNCHRONIZATIONSECRETS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSynchronizationSecretKeyStringValuePair[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SynchronizationTemplates
.
To construct, see NOTES section for SYNCHRONIZATIONTEMPLATES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSynchronizationTemplate[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Tags
Custom strings that can be used to categorize and identify the application.
Not nullable.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -TokenEncryptionKeyId
Specifies the keyId of a public key from the keyCredentials collection.
When configured, Azure AD encrypts all the tokens it emits by using the key this property points to.
The application code that receives the encrypted token must use the matching private key to decrypt the token before it can be used for the signed-in user.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -TokenIssuancePolicies
.
To construct, see NOTES section for TOKENISSUANCEPOLICIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTokenIssuancePolicy[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -TokenLifetimePolicies
.
To construct, see NOTES section for TOKENLIFETIMEPOLICIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTokenLifetimePolicy[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -WebHomePageUrl
Home page or landing page of the application.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -WebLogoutUrl
Specifies the URL that will be used by Microsoft's authorization service to logout an user using front-channel, back-channel or SAML logout protocols.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -WebOauth2AllowImplicitFlow
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -WebRedirectUris
Specifies the URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
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
Dynamic: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IIdentityApplicationIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphApplication

## OUTPUTS

### System.Boolean

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### APIOAUTH2PERMISSIONSCOPES <IMicrosoftGraphPermissionScope[]>: The collection of OAuth 2.0 permission scopes that the web API (resource) application exposes to client applications. These permission scopes may be granted to client applications during consent.
  - `[AdminConsentDescription <String>]`: Permission help text that appears in the admin consent and app assignment experiences.
  - `[AdminConsentDisplayName <String>]`: Display name for the permission that appears in the admin consent and app assignment experiences.
  - `[Id <String>]`: Unique scope permission identifier inside the oauth2Permissions collection.
  - `[IsEnabled <Boolean?>]`: When creating or updating a permission, this property must be set to true (which is the default). To delete a permission, this property must first be set to false. At that point, in a subsequent call, the permission may be removed.
  - `[Origin <String>]`: For internal use.
  - `[Type <String>]`: Specifies whether this scope permission can be consented to by an end user, or whether it is a tenant-wide permission that must be consented to by a company administrator. Possible values are User or Admin.
  - `[UserConsentDescription <String>]`: Permission help text that appears in the end-user consent experience.
  - `[UserConsentDisplayName <String>]`: Display name for the permission that appears in the end-user consent experience.
  - `[Value <String>]`: The value of the scope claim that the resource application should expect in the OAuth 2.0 access token.

#### APIPREAUTHORIZEDAPPLICATIONS <IMicrosoftGraphPreAuthorizedApplication[]>: Lists the client applications that are pre-authorized with the specified delegated permissions to access this application's APIs. Users are not required to consent to any pre-authorized application (for the permissions specified). However, any additional permissions not listed in preAuthorizedApplications (requested through incremental consent for example) will require user consent.
  - `[AppId <String>]`: The unique identifier for the application.
  - `[PermissionIds <String[]>]`: 

#### APPROLES <IMicrosoftGraphAppRole[]>: The collection of application roles that an application may declare. These roles can be assigned to users, groups, or service principals. Not nullable.
  - `[AllowedMemberTypes <String[]>]`: Specifies whether this app role definition can be assigned to users and groups by setting to 'User', or to other applications (that are accessing this application in daemon service scenarios) by setting to 'Application', or to both.
  - `[Description <String>]`: Permission help text that appears in the admin app assignment and consent experiences.
  - `[DisplayName <String>]`: Display name for the permission that appears in the admin consent and app assignment experiences.
  - `[Id <String>]`: Unique role identifier inside the appRoles collection. When creating a new app role, a new Guid identifier must be provided.
  - `[IsEnabled <Boolean?>]`: When creating or updating an app role, this must be set to true (which is the default). To delete a role, this must first be set to false.  At that point, in a subsequent call, this role may be removed.
  - `[Origin <String>]`: Read-only. Specifies if the app role is defined on the Application object . Must not be included in any POST or PATCH requests.
  - `[Value <String>]`: Specifies the value which will be included in the roles claim in authentication and access tokens. Must not exceed 120 characters in length. Allowed characters are : ! # $ % & ' ( ) * + , - . / : ;  =  ? @ [ ] ^ + _  {  } ~, as well as characters in the ranges 0-9, A-Z and a-z. Any other character, including the space character, are not allowed.

#### BODYPARAMETER <IMicrosoftGraphApplication>: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
  - `[DeletedDateTime <DateTime?>]`: 
  - `[Id <String>]`: Read-only.
  - `[ApiAcceptMappedClaims <Boolean?>]`: When true, allows an application to use claims mapping without specifying a custom signing key.
  - `[ApiKnownClientApplications <String[]>]`: Used for bundling consent if you have a solution that contains two parts: a client app and a custom web API app. If you set the appID of the client app to this value, the user only consents once to the client app. Azure AD knows that consenting to the client means implicitly consenting to the web API and automatically provisions service principals for both APIs at the same time. Both the client and the web API app must be registered in the same tenant.
  - `[ApiOauth2PermissionScopes <IMicrosoftGraphPermissionScope[]>]`: The collection of OAuth 2.0 permission scopes that the web API (resource) application exposes to client applications. These permission scopes may be granted to client applications during consent.
    - `[AdminConsentDescription <String>]`: Permission help text that appears in the admin consent and app assignment experiences.
    - `[AdminConsentDisplayName <String>]`: Display name for the permission that appears in the admin consent and app assignment experiences.
    - `[Id <String>]`: Unique scope permission identifier inside the oauth2Permissions collection.
    - `[IsEnabled <Boolean?>]`: When creating or updating a permission, this property must be set to true (which is the default). To delete a permission, this property must first be set to false. At that point, in a subsequent call, the permission may be removed.
    - `[Origin <String>]`: For internal use.
    - `[Type <String>]`: Specifies whether this scope permission can be consented to by an end user, or whether it is a tenant-wide permission that must be consented to by a company administrator. Possible values are User or Admin.
    - `[UserConsentDescription <String>]`: Permission help text that appears in the end-user consent experience.
    - `[UserConsentDisplayName <String>]`: Display name for the permission that appears in the end-user consent experience.
    - `[Value <String>]`: The value of the scope claim that the resource application should expect in the OAuth 2.0 access token.
  - `[ApiPreAuthorizedApplications <IMicrosoftGraphPreAuthorizedApplication[]>]`: Lists the client applications that are pre-authorized with the specified delegated permissions to access this application's APIs. Users are not required to consent to any pre-authorized application (for the permissions specified). However, any additional permissions not listed in preAuthorizedApplications (requested through incremental consent for example) will require user consent.
    - `[AppId <String>]`: The unique identifier for the application.
    - `[PermissionIds <String[]>]`: 
  - `[ApiRequestedAccessTokenVersion <Int32?>]`: Specifies the access token version expected by this resource. This changes the version and format of the JWT produced independent of the endpoint or client used to request the access token.  The endpoint used, v1.0 or v2.0, is chosen by the client and only impacts the version of id_tokens. Resources need to explicitly configure requestedAccessTokenVersion to indicate the supported access token format.  Possible values for requestedAccessTokenVersion are 1, 2, or null. If the value is null, this defaults to 1, which corresponds to the v1.0 endpoint.  If signInAudience on the application is configured as AzureADandPersonalMicrosoftAccount, the value for this property must be 2
  - `[AppId <String>]`: The unique identifier for the application that is assigned to an application by Azure AD. Not nullable. Read-only.
  - `[AppRoles <IMicrosoftGraphAppRole[]>]`: The collection of application roles that an application may declare. These roles can be assigned to users, groups, or service principals. Not nullable.
    - `[AllowedMemberTypes <String[]>]`: Specifies whether this app role definition can be assigned to users and groups by setting to 'User', or to other applications (that are accessing this application in daemon service scenarios) by setting to 'Application', or to both.
    - `[Description <String>]`: Permission help text that appears in the admin app assignment and consent experiences.
    - `[DisplayName <String>]`: Display name for the permission that appears in the admin consent and app assignment experiences.
    - `[Id <String>]`: Unique role identifier inside the appRoles collection. When creating a new app role, a new Guid identifier must be provided.
    - `[IsEnabled <Boolean?>]`: When creating or updating an app role, this must be set to true (which is the default). To delete a role, this must first be set to false.  At that point, in a subsequent call, this role may be removed.
    - `[Origin <String>]`: Read-only. Specifies if the app role is defined on the Application object . Must not be included in any POST or PATCH requests.
    - `[Value <String>]`: Specifies the value which will be included in the roles claim in authentication and access tokens. Must not exceed 120 characters in length. Allowed characters are : ! # $ % & ' ( ) * + , - . / : ;  =  ? @ [ ] ^ + _  {  } ~, as well as characters in the ranges 0-9, A-Z and a-z. Any other character, including the space character, are not allowed.
  - `[ClaimsMappingPolicies <IMicrosoftGraphClaimsMappingPolicy[]>]`: 
    - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[DeletedDateTime <DateTime?>]`: 
    - `[Definition <String[]>]`: 
    - `[IsOrganizationDefault <Boolean?>]`: 
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[Id <String>]`: Read-only.
  - `[CreatedDateTime <DateTime?>]`: The date and time the application was registered. Read-only.
  - `[CreatedOnBehalfOf <IMicrosoftGraphDirectoryObject>]`: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
  - `[DisplayName <String>]`: The display name for the application.
  - `[ExtensionProperties <IMicrosoftGraphExtensionProperty[]>]`: Read-only. Nullable.
    - `[DeletedDateTime <DateTime?>]`: 
    - `[Id <String>]`: Read-only.
    - `[AppDisplayName <String>]`: Display name of the application object on which this extension property is defined. Read-only.
    - `[DataType <String>]`: Specifies the data type of the value the extension property can hold. Following values are supported. Not nullable. Binary - 256 bytes maximumBooleanDateTime - Must be specified in ISO 8601 format. Will be stored in UTC.Integer - 32-bit value.LargeInteger - 64-bit value.String - 256 characters maximum
    - `[IsSyncedFromOnPremises <Boolean?>]`: Indicates if this extension property was sycned from onpremises directory using Azure AD Connect. Read-only.
    - `[Name <String>]`: Name of the extension property. Not nullable.
    - `[TargetObjects <String[]>]`: Following values are supported. Not nullable. UserGroupOrganizationDeviceApplication
  - `[GroupMembershipClaims <String>]`: Configures the groups claim issued in a user or OAuth 2.0 access token that the application expects. To set this attribute, use one of the following valid string values:NoneSecurityGroup: For security groups and Azure AD rolesAll: This will get all of the security groups, distribution groups, and Azure AD directory roles that the signed-in user is a member of
  - `[HomeRealmDiscoveryPolicies <IMicrosoftGraphHomeRealmDiscoveryPolicy[]>]`: 
    - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[Definition <String[]>]`: 
    - `[IsOrganizationDefault <Boolean?>]`: 
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[Id <String>]`: Read-only.
  - `[IdentifierUris <String[]>]`: The URIs that identify the application within its Azure AD tenant, or within a verified custom domain if the application is multi-tenant. For more information see Application Objects and Service Principal Objects. The any operator is required for filter expressions on multi-valued properties. Not nullable.
  - `[ImplicitGrantSettingEnableAccessTokenIssuance <Boolean?>]`: Specifies whether this web application can request an access token using the OAuth 2.0 implicit flow.
  - `[ImplicitGrantSettingEnableIdTokenIssuance <Boolean?>]`: Specifies whether this web application can request an ID token using the OAuth 2.0 implicit flow.
  - `[InfoLogoUrl <String>]`: CDN URL to the application's logo, Read-only.
  - `[InfoMarketingUrl <String>]`: Link to the application's marketing page. For example, https://www.contoso.com/app/marketing
  - `[InfoPrivacyStatementUrl <String>]`: Link to the application's privacy statement. For example, https://www.contoso.com/app/privacy
  - `[InfoSupportUrl <String>]`: Link to the application's support page. For example, https://www.contoso.com/app/support
  - `[InfoTermsOfServiceUrl <String>]`: Link to the application's terms of service statement. For example, https://www.contoso.com/app/termsofservice
  - `[IsDeviceOnlyAuthSupported <Boolean?>]`: 
  - `[IsFallbackPublicClient <Boolean?>]`: Specifies the fallback application type as public client, such as an installed application running on a mobile device. The default value is false which means the fallback application type is confidential client such as web app. There are certain scenarios where Azure AD cannot determine the client application type (e.g. ROPC flow where it is configured without specifying a redirect URI). In those cases Azure AD will interpret the application type based on the value of this property.
  - `[KeyCredentials <IMicrosoftGraphKeyCredential[]>]`: The collection of key credentials associated with the application Not nullable.
    - `[CustomKeyIdentifier <Byte[]>]`: Custom key identifier
    - `[DisplayName <String>]`: Friendly name for the key. Optional.
    - `[EndDateTime <DateTime?>]`: The date and time at which the credential expires.The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
    - `[Key <Byte[]>]`: Value for the key credential. Should be a base 64 encoded value.
    - `[KeyId <String>]`: The unique identifier (GUID) for the key.
    - `[StartDateTime <DateTime?>]`: The date and time at which the credential becomes valid.The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
    - `[Type <String>]`: The type of key credential; for example, 'Symmetric'.
    - `[Usage <String>]`: A string that describes the purpose for which the key can be used; for example, 'Verify'.
  - `[Logo <Byte[]>]`: The main logo for the application. Not nullable.
  - `[OptionalClaimAccessToken <IMicrosoftGraphOptionalClaim[]>]`: The optional claims returned in the JWT access token.
    - `[AdditionalProperties <String[]>]`: Additional properties of the claim. If a property exists in this collection, it modifies the behavior of the optional claim specified in the name property.
    - `[Essential <Boolean?>]`: If the value is true, the claim specified by the client is necessary to ensure a smooth authorization experience for the specific task requested by the end user. The default value is false.
    - `[Name <String>]`: The name of the optional claim.
    - `[Source <String>]`: The source (directory object) of the claim. There are predefined claims and user-defined claims from extension properties. If the source value is null, the claim is a predefined optional claim. If the source value is user, the value in the name property is the extension property from the user object.
  - `[OptionalClaimIdToken <IMicrosoftGraphOptionalClaim[]>]`: The optional claims returned in the JWT ID token.
  - `[OptionalClaimSaml2Token <IMicrosoftGraphOptionalClaim[]>]`: The optional claims returned in the SAML token.
  - `[Owners <IMicrosoftGraphDirectoryObject[]>]`: Directory objects that are owners of the application. The owners are a set of non-admin users who are allowed to modify this object. Requires version 2013-11-08 or newer. Read-only. Nullable.
  - `[ParentalControlSettingCountriesBlockedForMinors <String[]>]`: Specifies the two-letter ISO country codes. Access to the application will be blocked for minors from the countries specified in this list.
  - `[ParentalControlSettingLegalAgeGroupRule <String>]`: Specifies the legal age group rule that applies to users of the app. Can be set to one of the following values: ValueDescriptionAllowDefault. Enforces the legal minimum. This means parental consent is required for minors in the European Union and Korea.RequireConsentForPrivacyServicesEnforces the user to specify date of birth to comply with COPPA rules. RequireConsentForMinorsRequires parental consent for ages below 18, regardless of country minor rules.RequireConsentForKidsRequires parental consent for ages below 14, regardless of country minor rules.BlockMinorsBlocks minors from using the app.
  - `[PasswordCredentials <IMicrosoftGraphPasswordCredential[]>]`: The collection of password credentials associated with the application. Not nullable.
    - `[CustomKeyIdentifier <Byte[]>]`: Do not use.
    - `[DisplayName <String>]`: Friendly name for the password. Optional.
    - `[EndDateTime <DateTime?>]`: The date and time at which the password expires represented using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Optional.
    - `[Hint <String>]`: Contains the first three characters of the password. Read-only.
    - `[KeyId <String>]`: The unique identifier for the password.
    - `[SecretText <String>]`: Read-only; Contains the strong passwords generated by Azure AD that are 16-64 characters in length. The generated password value is only returned during the initial POST request to addPassword. There is no way to retrieve this password in the future.
    - `[StartDateTime <DateTime?>]`: The date and time at which the password becomes valid. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Optional.
  - `[PublicClientRedirectUris <String[]>]`: Specifies the URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent.
  - `[PublisherDomain <String>]`: The verified publisher domain for the application. Read-only.
  - `[RequiredResourceAccess <IMicrosoftGraphRequiredResourceAccess[]>]`: Specifies resources that this application requires access to and the set of OAuth permission scopes and application roles that it needs under each of those resources. This pre-configuration of required resource access drives the consent experience. Not nullable.
    - `[ResourceAccess <IMicrosoftGraphResourceAccess[]>]`: The list of OAuth2.0 permission scopes and app roles that the application requires from the specified resource.
      - `[Id <String>]`: The unique identifier for one of the oauth2PermissionScopes or appRole instances that the resource application exposes.
      - `[Type <String>]`: Specifies whether the id property references an oauth2PermissionScopes or an appRole. Possible values are 'scope' or 'role'.
    - `[ResourceAppId <String>]`: The unique identifier for the resource that the application requires access to.  This should be equal to the appId declared on the target resource application.
  - `[SignInAudience <String>]`: Specifies what Microsoft accounts are supported for the current application. Supported values are:AzureADMyOrg: Users with a Microsoft work or school account in my organization’s Azure AD tenant (i.e. single tenant)AzureADMultipleOrgs: Users with a Microsoft work or school account in any organization’s Azure AD tenant (i.e. multi-tenant) AzureADandPersonalMicrosoftAccount: Users with a personal Microsoft account, or a work or school account in any organization’s Azure AD tenant
  - `[SynchronizationId <String>]`: Read-only.
  - `[SynchronizationJobs <IMicrosoftGraphSynchronizationJob[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[ScheduleExpiration <DateTime?>]`: 
    - `[ScheduleInterval <TimeSpan?>]`: 
    - `[ScheduleState <String>]`: synchronizationScheduleState
    - `[SchemaDirectories <IMicrosoftGraphDirectoryDefinition[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[Discoverabilities <String>]`: directoryDefinitionDiscoverabilities
      - `[DiscoveryDateTime <DateTime?>]`: 
      - `[Name <String>]`: 
      - `[Objects <IMicrosoftGraphObjectDefinition[]>]`: 
        - `[Attributes <IMicrosoftGraphAttributeDefinition[]>]`: 
          - `[Anchor <Boolean?>]`: 
          - `[ApiExpressions <IMicrosoftGraphStringKeyStringValuePair[]>]`: 
            - `[Key <String>]`: 
            - `[Value <String>]`: 
          - `[CaseExact <Boolean?>]`: 
          - `[DefaultValue <String>]`: 
          - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: 
            - `[Key <String>]`: 
            - `[Value <String>]`: 
          - `[Multivalued <Boolean?>]`: 
          - `[Mutability <String>]`: mutability
          - `[Name <String>]`: 
          - `[ReferencedObjects <IMicrosoftGraphReferencedObject[]>]`: 
            - `[ReferencedObjectName <String>]`: 
            - `[ReferencedProperty <String>]`: 
          - `[Required <Boolean?>]`: 
          - `[Type <String>]`: attributeType
        - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: 
        - `[Name <String>]`: 
        - `[SupportedApis <String[]>]`: 
      - `[ReadOnly <Boolean?>]`: 
      - `[Version <String>]`: 
    - `[SchemaId <String>]`: Read-only.
    - `[SchemaProvisioningTaskIdentifier <String>]`: 
    - `[SchemaSynchronizationRules <IMicrosoftGraphSynchronizationRule[]>]`: 
      - `[Editable <Boolean?>]`: 
      - `[Id <String>]`: 
      - `[Metadata <IMicrosoftGraphStringKeyStringValuePair[]>]`: 
      - `[Name <String>]`: 
      - `[ObjectMappings <IMicrosoftGraphObjectMapping[]>]`: 
        - `[AttributeMappings <IMicrosoftGraphAttributeMapping[]>]`: 
          - `[DefaultValue <String>]`: 
          - `[ExportMissingReferences <Boolean?>]`: 
          - `[FlowBehavior <String>]`: attributeFlowBehavior
          - `[FlowType <String>]`: attributeFlowType
          - `[MatchingPriority <Int32?>]`: 
          - `[SourceExpression <String>]`: 
          - `[SourceName <String>]`: 
          - `[SourceParameters <IMicrosoftGraphStringKeyAttributeMappingSourceValuePair[]>]`: 
            - `[Key <String>]`: 
            - `[ValueExpression <String>]`: 
            - `[ValueName <String>]`: 
            - `[ValueParameters <IMicrosoftGraphStringKeyAttributeMappingSourceValuePair[]>]`: 
            - `[ValueType <String>]`: attributeMappingSourceType
          - `[SourceType <String>]`: attributeMappingSourceType
          - `[TargetAttributeName <String>]`: 
        - `[Enabled <Boolean?>]`: 
        - `[FlowTypes <String>]`: objectFlowTypes
        - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: 
        - `[Name <String>]`: 
        - `[ScopeCategoryFilterGroups <IMicrosoftGraphFilterGroup[]>]`: 
          - `[Clauses <IMicrosoftGraphFilterClause[]>]`: 
            - `[OperatorName <String>]`: 
            - `[SourceOperandName <String>]`: 
            - `[TargetOperandValues <String[]>]`: 
          - `[Name <String>]`: 
        - `[ScopeGroups <IMicrosoftGraphFilterGroup[]>]`: 
        - `[ScopeInputFilterGroups <IMicrosoftGraphFilterGroup[]>]`: 
        - `[SourceObjectName <String>]`: 
        - `[TargetObjectName <String>]`: 
      - `[Priority <Int32?>]`: 
      - `[SourceDirectoryName <String>]`: 
      - `[TargetDirectoryName <String>]`: 
    - `[SchemaVersion <String>]`: 
    - `[Status <IMicrosoftGraphSynchronizationStatus>]`: synchronizationStatus
      - `[Code <String>]`: synchronizationStatusCode
      - `[CountSuccessiveCompleteFailures <Int64?>]`: 
      - `[EscrowsPruned <Boolean?>]`: 
      - `[LastExecutionActivityIdentifier <String>]`: 
      - `[LastExecutionCountEntitled <Int64?>]`: 
      - `[LastExecutionCountEntitledForProvisioning <Int64?>]`: 
      - `[LastExecutionCountEscrowed <Int64?>]`: 
      - `[LastExecutionCountEscrowedRaw <Int64?>]`: 
      - `[LastExecutionCountExported <Int64?>]`: 
      - `[LastExecutionCountExports <Int64?>]`: 
      - `[LastExecutionCountImported <Int64?>]`: 
      - `[LastExecutionCountImportedDeltas <Int64?>]`: 
      - `[LastExecutionCountImportedReferenceDeltas <Int64?>]`: 
      - `[LastExecutionErrorCode <String>]`: 
      - `[LastExecutionErrorMessage <String>]`: 
      - `[LastExecutionErrorTenantActionable <Boolean?>]`: 
      - `[LastExecutionState <String>]`: synchronizationTaskExecutionResult
      - `[LastExecutionTimeBegan <DateTime?>]`: 
      - `[LastExecutionTimeEnded <DateTime?>]`: 
      - `[LastSuccessfulExecutionActivityIdentifier <String>]`: 
      - `[LastSuccessfulExecutionCountEntitled <Int64?>]`: 
      - `[LastSuccessfulExecutionCountEntitledForProvisioning <Int64?>]`: 
      - `[LastSuccessfulExecutionCountEscrowed <Int64?>]`: 
      - `[LastSuccessfulExecutionCountEscrowedRaw <Int64?>]`: 
      - `[LastSuccessfulExecutionCountExported <Int64?>]`: 
      - `[LastSuccessfulExecutionCountExports <Int64?>]`: 
      - `[LastSuccessfulExecutionCountImported <Int64?>]`: 
      - `[LastSuccessfulExecutionCountImportedDeltas <Int64?>]`: 
      - `[LastSuccessfulExecutionCountImportedReferenceDeltas <Int64?>]`: 
      - `[LastSuccessfulExecutionErrorCode <String>]`: 
      - `[LastSuccessfulExecutionErrorMessage <String>]`: 
      - `[LastSuccessfulExecutionErrorTenantActionable <Boolean?>]`: 
      - `[LastSuccessfulExecutionState <String>]`: synchronizationTaskExecutionResult
      - `[LastSuccessfulExecutionTimeBegan <DateTime?>]`: 
      - `[LastSuccessfulExecutionTimeEnded <DateTime?>]`: 
      - `[LastSuccessfulExecutionWithExportActivityIdentifier <String>]`: 
      - `[LastSuccessfulExecutionWithExportCountEntitled <Int64?>]`: 
      - `[LastSuccessfulExecutionWithExportCountEntitledForProvisioning <Int64?>]`: 
      - `[LastSuccessfulExecutionWithExportCountEscrowed <Int64?>]`: 
      - `[LastSuccessfulExecutionWithExportCountEscrowedRaw <Int64?>]`: 
      - `[LastSuccessfulExecutionWithExportCountExported <Int64?>]`: 
      - `[LastSuccessfulExecutionWithExportCountExports <Int64?>]`: 
      - `[LastSuccessfulExecutionWithExportCountImported <Int64?>]`: 
      - `[LastSuccessfulExecutionWithExportCountImportedDeltas <Int64?>]`: 
      - `[LastSuccessfulExecutionWithExportCountImportedReferenceDeltas <Int64?>]`: 
      - `[LastSuccessfulExecutionWithExportState <String>]`: synchronizationTaskExecutionResult
      - `[LastSuccessfulExecutionWithExportTimeBegan <DateTime?>]`: 
      - `[LastSuccessfulExecutionWithExportTimeEnded <DateTime?>]`: 
      - `[LastSuccessfulExecutionWithExportsErrorCode <String>]`: 
      - `[LastSuccessfulExecutionWithExportsErrorMessage <String>]`: 
      - `[LastSuccessfulExecutionWithExportsErrorTenantActionable <Boolean?>]`: 
      - `[Progress <IMicrosoftGraphSynchronizationProgress[]>]`: 
        - `[CompletedUnits <Int64?>]`: 
        - `[ProgressObservationDateTime <DateTime?>]`: 
        - `[TotalUnits <Int64?>]`: 
        - `[Units <String>]`: 
      - `[QuarantineCurrentBegan <DateTime?>]`: 
      - `[QuarantineNextAttempt <DateTime?>]`: 
      - `[QuarantineReason <String>]`: quarantineReason
      - `[QuarantineSeriesBegan <DateTime?>]`: 
      - `[QuarantineSeriesCount <Int64?>]`: 
      - `[SteadyStateFirstAchievedTime <DateTime?>]`: 
      - `[SteadyStateLastAchievedTime <DateTime?>]`: 
      - `[SynchronizedEntryCountByType <IMicrosoftGraphStringKeyLongValuePair[]>]`: 
        - `[Key <String>]`: 
        - `[Value <Int64?>]`: 
      - `[TroubleshootingUrl <String>]`: 
    - `[SynchronizationJobSettings <IMicrosoftGraphKeyValuePair[]>]`: 
      - `[Name <String>]`: Name for this key-value pair
      - `[Value <String>]`: Value for this key-value pair
    - `[TemplateId <String>]`: 
  - `[SynchronizationSecrets <IMicrosoftGraphSynchronizationSecretKeyStringValuePair[]>]`: 
    - `[Key <String>]`: synchronizationSecret
    - `[Value <String>]`: 
  - `[SynchronizationTemplates <IMicrosoftGraphSynchronizationTemplate[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[ApplicationId <String>]`: 
    - `[Default <Boolean?>]`: 
    - `[Description <String>]`: 
    - `[Discoverable <Boolean?>]`: 
    - `[FactoryTag <String>]`: 
    - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: 
    - `[SchemaDirectories <IMicrosoftGraphDirectoryDefinition[]>]`: 
    - `[SchemaId <String>]`: Read-only.
    - `[SchemaProvisioningTaskIdentifier <String>]`: 
    - `[SchemaSynchronizationRules <IMicrosoftGraphSynchronizationRule[]>]`: 
    - `[SchemaVersion <String>]`: 
  - `[Tags <String[]>]`: Custom strings that can be used to categorize and identify the application. Not nullable.
  - `[TokenEncryptionKeyId <String>]`: Specifies the keyId of a public key from the keyCredentials collection. When configured, Azure AD encrypts all the tokens it emits by using the key this property points to. The application code that receives the encrypted token must use the matching private key to decrypt the token before it can be used for the signed-in user.
  - `[TokenIssuancePolicies <IMicrosoftGraphTokenIssuancePolicy[]>]`: 
    - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[Definition <String[]>]`: 
    - `[IsOrganizationDefault <Boolean?>]`: 
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[Id <String>]`: Read-only.
  - `[TokenLifetimePolicies <IMicrosoftGraphTokenLifetimePolicy[]>]`: 
    - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[Definition <String[]>]`: 
    - `[IsOrganizationDefault <Boolean?>]`: 
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[Id <String>]`: Read-only.
  - `[WebHomePageUrl <String>]`: Home page or landing page of the application.
  - `[WebLogoutUrl <String>]`: Specifies the URL that will be used by Microsoft's authorization service to logout an user using front-channel, back-channel or SAML logout protocols.
  - `[WebOauth2AllowImplicitFlow <Boolean?>]`: 
  - `[WebRedirectUris <String[]>]`: Specifies the URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent.

#### CLAIMSMAPPINGPOLICIES <IMicrosoftGraphClaimsMappingPolicy[]>: .
  - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[DeletedDateTime <DateTime?>]`: 
  - `[Definition <String[]>]`: 
  - `[IsOrganizationDefault <Boolean?>]`: 
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: 
  - `[Id <String>]`: Read-only.

#### CREATEDONBEHALFOF <IMicrosoftGraphDirectoryObject>: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
  - `[Id <String>]`: Read-only.
  - `[DeletedDateTime <DateTime?>]`: 

#### EXTENSIONPROPERTIES <IMicrosoftGraphExtensionProperty[]>: Read-only. Nullable.
  - `[DeletedDateTime <DateTime?>]`: 
  - `[Id <String>]`: Read-only.
  - `[AppDisplayName <String>]`: Display name of the application object on which this extension property is defined. Read-only.
  - `[DataType <String>]`: Specifies the data type of the value the extension property can hold. Following values are supported. Not nullable. Binary - 256 bytes maximumBooleanDateTime - Must be specified in ISO 8601 format. Will be stored in UTC.Integer - 32-bit value.LargeInteger - 64-bit value.String - 256 characters maximum
  - `[IsSyncedFromOnPremises <Boolean?>]`: Indicates if this extension property was sycned from onpremises directory using Azure AD Connect. Read-only.
  - `[Name <String>]`: Name of the extension property. Not nullable.
  - `[TargetObjects <String[]>]`: Following values are supported. Not nullable. UserGroupOrganizationDeviceApplication

#### HOMEREALMDISCOVERYPOLICIES <IMicrosoftGraphHomeRealmDiscoveryPolicy[]>: .
  - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[DeletedDateTime <DateTime?>]`: 
  - `[Definition <String[]>]`: 
  - `[IsOrganizationDefault <Boolean?>]`: 
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: 
  - `[Id <String>]`: Read-only.

#### INPUTOBJECT <IIdentityApplicationIdentity>: Identity Parameter
  - `[ApplicationId <String>]`: key: application-id of application
  - `[ApplicationTemplateId <String>]`: key: applicationTemplate-id of applicationTemplate
  - `[ClaimsMappingPolicyId <String>]`: key: claimsMappingPolicy-id of claimsMappingPolicy
  - `[DirectoryDefinitionId <String>]`: key: directoryDefinition-id of directoryDefinition
  - `[DirectoryObjectId <String>]`: key: directoryObject-id of directoryObject
  - `[ExtensionPropertyId <String>]`: key: extensionProperty-id of extensionProperty
  - `[HomeRealmDiscoveryPolicyId <String>]`: key: homeRealmDiscoveryPolicy-id of homeRealmDiscoveryPolicy
  - `[SynchronizationJobId <String>]`: key: synchronizationJob-id of synchronizationJob
  - `[SynchronizationTemplateId <String>]`: key: synchronizationTemplate-id of synchronizationTemplate
  - `[TokenIssuancePolicyId <String>]`: key: tokenIssuancePolicy-id of tokenIssuancePolicy
  - `[TokenLifetimePolicyId <String>]`: key: tokenLifetimePolicy-id of tokenLifetimePolicy

#### KEYCREDENTIALS <IMicrosoftGraphKeyCredential[]>: The collection of key credentials associated with the application Not nullable.
  - `[CustomKeyIdentifier <Byte[]>]`: Custom key identifier
  - `[DisplayName <String>]`: Friendly name for the key. Optional.
  - `[EndDateTime <DateTime?>]`: The date and time at which the credential expires.The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
  - `[Key <Byte[]>]`: Value for the key credential. Should be a base 64 encoded value.
  - `[KeyId <String>]`: The unique identifier (GUID) for the key.
  - `[StartDateTime <DateTime?>]`: The date and time at which the credential becomes valid.The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
  - `[Type <String>]`: The type of key credential; for example, 'Symmetric'.
  - `[Usage <String>]`: A string that describes the purpose for which the key can be used; for example, 'Verify'.

#### OPTIONALCLAIMACCESSTOKEN <IMicrosoftGraphOptionalClaim[]>: The optional claims returned in the JWT access token.
  - `[AdditionalProperties <String[]>]`: Additional properties of the claim. If a property exists in this collection, it modifies the behavior of the optional claim specified in the name property.
  - `[Essential <Boolean?>]`: If the value is true, the claim specified by the client is necessary to ensure a smooth authorization experience for the specific task requested by the end user. The default value is false.
  - `[Name <String>]`: The name of the optional claim.
  - `[Source <String>]`: The source (directory object) of the claim. There are predefined claims and user-defined claims from extension properties. If the source value is null, the claim is a predefined optional claim. If the source value is user, the value in the name property is the extension property from the user object.

#### OPTIONALCLAIMIDTOKEN <IMicrosoftGraphOptionalClaim[]>: The optional claims returned in the JWT ID token.
  - `[AdditionalProperties <String[]>]`: Additional properties of the claim. If a property exists in this collection, it modifies the behavior of the optional claim specified in the name property.
  - `[Essential <Boolean?>]`: If the value is true, the claim specified by the client is necessary to ensure a smooth authorization experience for the specific task requested by the end user. The default value is false.
  - `[Name <String>]`: The name of the optional claim.
  - `[Source <String>]`: The source (directory object) of the claim. There are predefined claims and user-defined claims from extension properties. If the source value is null, the claim is a predefined optional claim. If the source value is user, the value in the name property is the extension property from the user object.

#### OPTIONALCLAIMSAML2TOKEN <IMicrosoftGraphOptionalClaim[]>: The optional claims returned in the SAML token.
  - `[AdditionalProperties <String[]>]`: Additional properties of the claim. If a property exists in this collection, it modifies the behavior of the optional claim specified in the name property.
  - `[Essential <Boolean?>]`: If the value is true, the claim specified by the client is necessary to ensure a smooth authorization experience for the specific task requested by the end user. The default value is false.
  - `[Name <String>]`: The name of the optional claim.
  - `[Source <String>]`: The source (directory object) of the claim. There are predefined claims and user-defined claims from extension properties. If the source value is null, the claim is a predefined optional claim. If the source value is user, the value in the name property is the extension property from the user object.

#### OWNERS <IMicrosoftGraphDirectoryObject[]>: Directory objects that are owners of the application. The owners are a set of non-admin users who are allowed to modify this object. Requires version 2013-11-08 or newer. Read-only. Nullable.
  - `[Id <String>]`: Read-only.
  - `[DeletedDateTime <DateTime?>]`: 

#### PASSWORDCREDENTIALS <IMicrosoftGraphPasswordCredential[]>: The collection of password credentials associated with the application. Not nullable.
  - `[CustomKeyIdentifier <Byte[]>]`: Do not use.
  - `[DisplayName <String>]`: Friendly name for the password. Optional.
  - `[EndDateTime <DateTime?>]`: The date and time at which the password expires represented using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Optional.
  - `[Hint <String>]`: Contains the first three characters of the password. Read-only.
  - `[KeyId <String>]`: The unique identifier for the password.
  - `[SecretText <String>]`: Read-only; Contains the strong passwords generated by Azure AD that are 16-64 characters in length. The generated password value is only returned during the initial POST request to addPassword. There is no way to retrieve this password in the future.
  - `[StartDateTime <DateTime?>]`: The date and time at which the password becomes valid. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Optional.

#### REQUIREDRESOURCEACCESS <IMicrosoftGraphRequiredResourceAccess[]>: Specifies resources that this application requires access to and the set of OAuth permission scopes and application roles that it needs under each of those resources. This pre-configuration of required resource access drives the consent experience. Not nullable.
  - `[ResourceAccess <IMicrosoftGraphResourceAccess[]>]`: The list of OAuth2.0 permission scopes and app roles that the application requires from the specified resource.
    - `[Id <String>]`: The unique identifier for one of the oauth2PermissionScopes or appRole instances that the resource application exposes.
    - `[Type <String>]`: Specifies whether the id property references an oauth2PermissionScopes or an appRole. Possible values are 'scope' or 'role'.
  - `[ResourceAppId <String>]`: The unique identifier for the resource that the application requires access to.  This should be equal to the appId declared on the target resource application.

#### SYNCHRONIZATIONJOBS <IMicrosoftGraphSynchronizationJob[]>: .
  - `[Id <String>]`: Read-only.
  - `[ScheduleExpiration <DateTime?>]`: 
  - `[ScheduleInterval <TimeSpan?>]`: 
  - `[ScheduleState <String>]`: synchronizationScheduleState
  - `[SchemaDirectories <IMicrosoftGraphDirectoryDefinition[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Discoverabilities <String>]`: directoryDefinitionDiscoverabilities
    - `[DiscoveryDateTime <DateTime?>]`: 
    - `[Name <String>]`: 
    - `[Objects <IMicrosoftGraphObjectDefinition[]>]`: 
      - `[Attributes <IMicrosoftGraphAttributeDefinition[]>]`: 
        - `[Anchor <Boolean?>]`: 
        - `[ApiExpressions <IMicrosoftGraphStringKeyStringValuePair[]>]`: 
          - `[Key <String>]`: 
          - `[Value <String>]`: 
        - `[CaseExact <Boolean?>]`: 
        - `[DefaultValue <String>]`: 
        - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: 
          - `[Key <String>]`: 
          - `[Value <String>]`: 
        - `[Multivalued <Boolean?>]`: 
        - `[Mutability <String>]`: mutability
        - `[Name <String>]`: 
        - `[ReferencedObjects <IMicrosoftGraphReferencedObject[]>]`: 
          - `[ReferencedObjectName <String>]`: 
          - `[ReferencedProperty <String>]`: 
        - `[Required <Boolean?>]`: 
        - `[Type <String>]`: attributeType
      - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: 
      - `[Name <String>]`: 
      - `[SupportedApis <String[]>]`: 
    - `[ReadOnly <Boolean?>]`: 
    - `[Version <String>]`: 
  - `[SchemaId <String>]`: Read-only.
  - `[SchemaProvisioningTaskIdentifier <String>]`: 
  - `[SchemaSynchronizationRules <IMicrosoftGraphSynchronizationRule[]>]`: 
    - `[Editable <Boolean?>]`: 
    - `[Id <String>]`: 
    - `[Metadata <IMicrosoftGraphStringKeyStringValuePair[]>]`: 
    - `[Name <String>]`: 
    - `[ObjectMappings <IMicrosoftGraphObjectMapping[]>]`: 
      - `[AttributeMappings <IMicrosoftGraphAttributeMapping[]>]`: 
        - `[DefaultValue <String>]`: 
        - `[ExportMissingReferences <Boolean?>]`: 
        - `[FlowBehavior <String>]`: attributeFlowBehavior
        - `[FlowType <String>]`: attributeFlowType
        - `[MatchingPriority <Int32?>]`: 
        - `[SourceExpression <String>]`: 
        - `[SourceName <String>]`: 
        - `[SourceParameters <IMicrosoftGraphStringKeyAttributeMappingSourceValuePair[]>]`: 
          - `[Key <String>]`: 
          - `[ValueExpression <String>]`: 
          - `[ValueName <String>]`: 
          - `[ValueParameters <IMicrosoftGraphStringKeyAttributeMappingSourceValuePair[]>]`: 
          - `[ValueType <String>]`: attributeMappingSourceType
        - `[SourceType <String>]`: attributeMappingSourceType
        - `[TargetAttributeName <String>]`: 
      - `[Enabled <Boolean?>]`: 
      - `[FlowTypes <String>]`: objectFlowTypes
      - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: 
      - `[Name <String>]`: 
      - `[ScopeCategoryFilterGroups <IMicrosoftGraphFilterGroup[]>]`: 
        - `[Clauses <IMicrosoftGraphFilterClause[]>]`: 
          - `[OperatorName <String>]`: 
          - `[SourceOperandName <String>]`: 
          - `[TargetOperandValues <String[]>]`: 
        - `[Name <String>]`: 
      - `[ScopeGroups <IMicrosoftGraphFilterGroup[]>]`: 
      - `[ScopeInputFilterGroups <IMicrosoftGraphFilterGroup[]>]`: 
      - `[SourceObjectName <String>]`: 
      - `[TargetObjectName <String>]`: 
    - `[Priority <Int32?>]`: 
    - `[SourceDirectoryName <String>]`: 
    - `[TargetDirectoryName <String>]`: 
  - `[SchemaVersion <String>]`: 
  - `[Status <IMicrosoftGraphSynchronizationStatus>]`: synchronizationStatus
    - `[Code <String>]`: synchronizationStatusCode
    - `[CountSuccessiveCompleteFailures <Int64?>]`: 
    - `[EscrowsPruned <Boolean?>]`: 
    - `[LastExecutionActivityIdentifier <String>]`: 
    - `[LastExecutionCountEntitled <Int64?>]`: 
    - `[LastExecutionCountEntitledForProvisioning <Int64?>]`: 
    - `[LastExecutionCountEscrowed <Int64?>]`: 
    - `[LastExecutionCountEscrowedRaw <Int64?>]`: 
    - `[LastExecutionCountExported <Int64?>]`: 
    - `[LastExecutionCountExports <Int64?>]`: 
    - `[LastExecutionCountImported <Int64?>]`: 
    - `[LastExecutionCountImportedDeltas <Int64?>]`: 
    - `[LastExecutionCountImportedReferenceDeltas <Int64?>]`: 
    - `[LastExecutionErrorCode <String>]`: 
    - `[LastExecutionErrorMessage <String>]`: 
    - `[LastExecutionErrorTenantActionable <Boolean?>]`: 
    - `[LastExecutionState <String>]`: synchronizationTaskExecutionResult
    - `[LastExecutionTimeBegan <DateTime?>]`: 
    - `[LastExecutionTimeEnded <DateTime?>]`: 
    - `[LastSuccessfulExecutionActivityIdentifier <String>]`: 
    - `[LastSuccessfulExecutionCountEntitled <Int64?>]`: 
    - `[LastSuccessfulExecutionCountEntitledForProvisioning <Int64?>]`: 
    - `[LastSuccessfulExecutionCountEscrowed <Int64?>]`: 
    - `[LastSuccessfulExecutionCountEscrowedRaw <Int64?>]`: 
    - `[LastSuccessfulExecutionCountExported <Int64?>]`: 
    - `[LastSuccessfulExecutionCountExports <Int64?>]`: 
    - `[LastSuccessfulExecutionCountImported <Int64?>]`: 
    - `[LastSuccessfulExecutionCountImportedDeltas <Int64?>]`: 
    - `[LastSuccessfulExecutionCountImportedReferenceDeltas <Int64?>]`: 
    - `[LastSuccessfulExecutionErrorCode <String>]`: 
    - `[LastSuccessfulExecutionErrorMessage <String>]`: 
    - `[LastSuccessfulExecutionErrorTenantActionable <Boolean?>]`: 
    - `[LastSuccessfulExecutionState <String>]`: synchronizationTaskExecutionResult
    - `[LastSuccessfulExecutionTimeBegan <DateTime?>]`: 
    - `[LastSuccessfulExecutionTimeEnded <DateTime?>]`: 
    - `[LastSuccessfulExecutionWithExportActivityIdentifier <String>]`: 
    - `[LastSuccessfulExecutionWithExportCountEntitled <Int64?>]`: 
    - `[LastSuccessfulExecutionWithExportCountEntitledForProvisioning <Int64?>]`: 
    - `[LastSuccessfulExecutionWithExportCountEscrowed <Int64?>]`: 
    - `[LastSuccessfulExecutionWithExportCountEscrowedRaw <Int64?>]`: 
    - `[LastSuccessfulExecutionWithExportCountExported <Int64?>]`: 
    - `[LastSuccessfulExecutionWithExportCountExports <Int64?>]`: 
    - `[LastSuccessfulExecutionWithExportCountImported <Int64?>]`: 
    - `[LastSuccessfulExecutionWithExportCountImportedDeltas <Int64?>]`: 
    - `[LastSuccessfulExecutionWithExportCountImportedReferenceDeltas <Int64?>]`: 
    - `[LastSuccessfulExecutionWithExportState <String>]`: synchronizationTaskExecutionResult
    - `[LastSuccessfulExecutionWithExportTimeBegan <DateTime?>]`: 
    - `[LastSuccessfulExecutionWithExportTimeEnded <DateTime?>]`: 
    - `[LastSuccessfulExecutionWithExportsErrorCode <String>]`: 
    - `[LastSuccessfulExecutionWithExportsErrorMessage <String>]`: 
    - `[LastSuccessfulExecutionWithExportsErrorTenantActionable <Boolean?>]`: 
    - `[Progress <IMicrosoftGraphSynchronizationProgress[]>]`: 
      - `[CompletedUnits <Int64?>]`: 
      - `[ProgressObservationDateTime <DateTime?>]`: 
      - `[TotalUnits <Int64?>]`: 
      - `[Units <String>]`: 
    - `[QuarantineCurrentBegan <DateTime?>]`: 
    - `[QuarantineNextAttempt <DateTime?>]`: 
    - `[QuarantineReason <String>]`: quarantineReason
    - `[QuarantineSeriesBegan <DateTime?>]`: 
    - `[QuarantineSeriesCount <Int64?>]`: 
    - `[SteadyStateFirstAchievedTime <DateTime?>]`: 
    - `[SteadyStateLastAchievedTime <DateTime?>]`: 
    - `[SynchronizedEntryCountByType <IMicrosoftGraphStringKeyLongValuePair[]>]`: 
      - `[Key <String>]`: 
      - `[Value <Int64?>]`: 
    - `[TroubleshootingUrl <String>]`: 
  - `[SynchronizationJobSettings <IMicrosoftGraphKeyValuePair[]>]`: 
    - `[Name <String>]`: Name for this key-value pair
    - `[Value <String>]`: Value for this key-value pair
  - `[TemplateId <String>]`: 

#### SYNCHRONIZATIONSECRETS <IMicrosoftGraphSynchronizationSecretKeyStringValuePair[]>: .
  - `[Key <String>]`: synchronizationSecret
  - `[Value <String>]`: 

#### SYNCHRONIZATIONTEMPLATES <IMicrosoftGraphSynchronizationTemplate[]>: .
  - `[Id <String>]`: Read-only.
  - `[ApplicationId <String>]`: 
  - `[Default <Boolean?>]`: 
  - `[Description <String>]`: 
  - `[Discoverable <Boolean?>]`: 
  - `[FactoryTag <String>]`: 
  - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: 
    - `[Key <String>]`: 
    - `[Value <String>]`: 
  - `[SchemaDirectories <IMicrosoftGraphDirectoryDefinition[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Discoverabilities <String>]`: directoryDefinitionDiscoverabilities
    - `[DiscoveryDateTime <DateTime?>]`: 
    - `[Name <String>]`: 
    - `[Objects <IMicrosoftGraphObjectDefinition[]>]`: 
      - `[Attributes <IMicrosoftGraphAttributeDefinition[]>]`: 
        - `[Anchor <Boolean?>]`: 
        - `[ApiExpressions <IMicrosoftGraphStringKeyStringValuePair[]>]`: 
          - `[Key <String>]`: 
          - `[Value <String>]`: 
        - `[CaseExact <Boolean?>]`: 
        - `[DefaultValue <String>]`: 
        - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: 
        - `[Multivalued <Boolean?>]`: 
        - `[Mutability <String>]`: mutability
        - `[Name <String>]`: 
        - `[ReferencedObjects <IMicrosoftGraphReferencedObject[]>]`: 
          - `[ReferencedObjectName <String>]`: 
          - `[ReferencedProperty <String>]`: 
        - `[Required <Boolean?>]`: 
        - `[Type <String>]`: attributeType
      - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: 
      - `[Name <String>]`: 
      - `[SupportedApis <String[]>]`: 
    - `[ReadOnly <Boolean?>]`: 
    - `[Version <String>]`: 
  - `[SchemaId <String>]`: Read-only.
  - `[SchemaProvisioningTaskIdentifier <String>]`: 
  - `[SchemaSynchronizationRules <IMicrosoftGraphSynchronizationRule[]>]`: 
    - `[Editable <Boolean?>]`: 
    - `[Id <String>]`: 
    - `[Metadata <IMicrosoftGraphStringKeyStringValuePair[]>]`: 
    - `[Name <String>]`: 
    - `[ObjectMappings <IMicrosoftGraphObjectMapping[]>]`: 
      - `[AttributeMappings <IMicrosoftGraphAttributeMapping[]>]`: 
        - `[DefaultValue <String>]`: 
        - `[ExportMissingReferences <Boolean?>]`: 
        - `[FlowBehavior <String>]`: attributeFlowBehavior
        - `[FlowType <String>]`: attributeFlowType
        - `[MatchingPriority <Int32?>]`: 
        - `[SourceExpression <String>]`: 
        - `[SourceName <String>]`: 
        - `[SourceParameters <IMicrosoftGraphStringKeyAttributeMappingSourceValuePair[]>]`: 
          - `[Key <String>]`: 
          - `[ValueExpression <String>]`: 
          - `[ValueName <String>]`: 
          - `[ValueParameters <IMicrosoftGraphStringKeyAttributeMappingSourceValuePair[]>]`: 
          - `[ValueType <String>]`: attributeMappingSourceType
        - `[SourceType <String>]`: attributeMappingSourceType
        - `[TargetAttributeName <String>]`: 
      - `[Enabled <Boolean?>]`: 
      - `[FlowTypes <String>]`: objectFlowTypes
      - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: 
      - `[Name <String>]`: 
      - `[ScopeCategoryFilterGroups <IMicrosoftGraphFilterGroup[]>]`: 
        - `[Clauses <IMicrosoftGraphFilterClause[]>]`: 
          - `[OperatorName <String>]`: 
          - `[SourceOperandName <String>]`: 
          - `[TargetOperandValues <String[]>]`: 
        - `[Name <String>]`: 
      - `[ScopeGroups <IMicrosoftGraphFilterGroup[]>]`: 
      - `[ScopeInputFilterGroups <IMicrosoftGraphFilterGroup[]>]`: 
      - `[SourceObjectName <String>]`: 
      - `[TargetObjectName <String>]`: 
    - `[Priority <Int32?>]`: 
    - `[SourceDirectoryName <String>]`: 
    - `[TargetDirectoryName <String>]`: 
  - `[SchemaVersion <String>]`: 

#### TOKENISSUANCEPOLICIES <IMicrosoftGraphTokenIssuancePolicy[]>: .
  - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[DeletedDateTime <DateTime?>]`: 
  - `[Definition <String[]>]`: 
  - `[IsOrganizationDefault <Boolean?>]`: 
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: 
  - `[Id <String>]`: Read-only.

#### TOKENLIFETIMEPOLICIES <IMicrosoftGraphTokenLifetimePolicy[]>: .
  - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[DeletedDateTime <DateTime?>]`: 
  - `[Definition <String[]>]`: 
  - `[IsOrganizationDefault <Boolean?>]`: 
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: 
  - `[Id <String>]`: Read-only.

## RELATED LINKS

