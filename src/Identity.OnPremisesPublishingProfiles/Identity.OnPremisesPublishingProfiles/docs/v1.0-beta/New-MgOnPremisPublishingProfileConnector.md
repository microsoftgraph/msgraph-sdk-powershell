---
external help file:
Module Name: Microsoft.Graph.Identity.OnPremisesPublishingProfiles
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.onpremisespublishingprofiles/new-mgonpremispublishingprofileconnector
schema: 2.0.0
---

# New-MgOnPremisPublishingProfileConnector

## SYNOPSIS
Create new navigation property to connectors for onPremisesPublishingProfiles

## SYNTAX

### CreateExpanded (Default)
```
New-MgOnPremisPublishingProfileConnector -OnPremisesPublishingProfileId <String> [-ExternalIP <String>]
 [-Id <String>] [-MachineName <String>] [-MemberOf <IMicrosoftGraphConnectorGroup[]>] [-Status <String>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgOnPremisPublishingProfileConnector -OnPremisesPublishingProfileId <String>
 -BodyParameter <IMicrosoftGraphConnector> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgOnPremisPublishingProfileConnector -InputObject <IIdentityOnPremisesPublishingProfilesIdentity>
 -BodyParameter <IMicrosoftGraphConnector> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgOnPremisPublishingProfileConnector -InputObject <IIdentityOnPremisesPublishingProfilesIdentity>
 [-ExternalIP <String>] [-Id <String>] [-MachineName <String>] [-MemberOf <IMicrosoftGraphConnectorGroup[]>]
 [-Status <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to connectors for onPremisesPublishingProfiles

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

### -BodyParameter
connector
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphConnector
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ExternalIP
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

### -Id
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
Type: Microsoft.Graph.PowerShell.Models.IIdentityOnPremisesPublishingProfilesIdentity
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -MachineName
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

### -MemberOf
.
To construct, see NOTES section for MEMBEROF properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphConnectorGroup[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OnPremisesPublishingProfileId
key: onPremisesPublishingProfile-id of onPremisesPublishingProfile

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

### -Status
connectorStatus

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

### Microsoft.Graph.PowerShell.Models.IIdentityOnPremisesPublishingProfilesIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphConnector

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphConnector

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphConnector>: connector
  - `[Id <String>]`: Read-only.
  - `[ExternalIP <String>]`: 
  - `[MachineName <String>]`: 
  - `[MemberOf <IMicrosoftGraphConnectorGroup[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Applications <IMicrosoftGraphApplication[]>]`: 
      - `[DeletedDateTime <DateTime?>]`: 
      - `[Id <String>]`: Read-only.
      - `[ApiAcceptMappedClaims <Boolean?>]`: When true, allows an application to use claims mapping without specifying a custom signing key.
      - `[ApiKnownClientApplications <String[]>]`: Used for bundling consent if you have a solution that contains two parts: a client app and a custom web API app. If you set the appID of the client app to this value, the user only consents once to the client app. Azure AD knows that consenting to the client means implicitly consenting to the web API and automatically provisions service principals for both APIs at the same time. Both the client and the web API app must be registered in the same tenant.
      - `[ApiOauth2PermissionScopes <IMicrosoftGraphPermissionScope[]>]`: The definition of the delegated permissions exposed by the web API represented by this application registration. These delegated permissions may be requested by a client application, and may be granted by users or administrators during consent. Delegated permissions are sometimes referred to as OAuth 2.0 scopes.
        - `[AdminConsentDescription <String>]`: A description of the delegated permissions, intended to be read by an administrator granting the permission on behalf of all users. This text appears in tenant-wide admin consent experiences.
        - `[AdminConsentDisplayName <String>]`: The permission's title, intended to be read by an administrator granting the permission on behalf of all users.
        - `[Id <String>]`: Unique delegated permission identifier inside the collection of delegated permissions defined for a resource application.
        - `[IsEnabled <Boolean?>]`: When creating or updating a permission, this property must be set to true (which is the default). To delete a permission, this property must first be set to false.  At that point, in a subsequent call, the permission may be removed.
        - `[Origin <String>]`: 
        - `[Type <String>]`: Specifies whether this delegated permission should be considered safe for non-admin users to consent to on behalf of themselves, or whether an administrator should be required for consent to the permissions. This will be the default behavior, but each customer can choose to customize the behavior in their organization (by allowing, restricting or limiting user consent to this delegated permission.)
        - `[UserConsentDescription <String>]`: A description of the delegated permissions, intended to be read by a user granting the permission on their own behalf. This text appears in consent experiences where the user is consenting only on behalf of themselves.
        - `[UserConsentDisplayName <String>]`: A title for the permission, intended to be read by a user granting the permission on their own behalf. This text appears in consent experiences where the user is consenting only on behalf of themselves.
        - `[Value <String>]`: Specifies the value to include in the scp (scope) claim in access tokens. Must not exceed 120 characters in length. Allowed characters are : ! # $ % & ' ( ) * + , - . / : ;  =  ? @ [ ] ^ + _  {  } ~, as well as characters in the ranges 0-9, A-Z and a-z. Any other character, including the space character, are not allowed.
      - `[ApiPreAuthorizedApplications <IMicrosoftGraphPreAuthorizedApplication[]>]`: Lists the client applications that are pre-authorized with the specified delegated permissions to access this application's APIs. Users are not required to consent to any pre-authorized application (for the permissions specified). However, any additional permissions not listed in preAuthorizedApplications (requested through incremental consent for example) will require user consent.
        - `[AppId <String>]`: The unique identifier for the application.
        - `[PermissionIds <String[]>]`: 
      - `[ApiRequestedAccessTokenVersion <Int32?>]`: Specifies the access token version expected by this resource. This changes the version and format of the JWT produced independent of the endpoint or client used to request the access token.  The endpoint used, v1.0 or v2.0, is chosen by the client and only impacts the version of id_tokens. Resources need to explicitly configure requestedAccessTokenVersion to indicate the supported access token format.  Possible values for requestedAccessTokenVersion are 1, 2, or null. If the value is null, this defaults to 1, which corresponds to the v1.0 endpoint.  If signInAudience on the application is configured as AzureADandPersonalMicrosoftAccount, the value for this property must be 2
      - `[AppId <String>]`: The unique identifier for the application that is assigned to an application by Azure AD. Not nullable. Read-only.
      - `[AppRoles <IMicrosoftGraphAppRole[]>]`: The collection of roles the application declares. With app role assignments, these roles can be assigned to users, groups, or other applications' service principals. Not nullable.
        - `[AllowedMemberTypes <String[]>]`: Specifies whether this app role can be assigned to users and groups (by setting to ['User']), to other application's (by setting to ['Application'], or both (by setting to ['User', 'Application']). App roles supporting assignment of other applications' service principals are also known as application permissions.
        - `[Description <String>]`: The description for the app role. This is displayed when the app role is being assigned and, if the app role functions as an application permission, during  consent experiences.
        - `[DisplayName <String>]`: Display name for the permission that appears in the app role assignment and consent experiences.
        - `[Id <String>]`: Unique role identifier inside the appRoles collection. When creating a new app role, a new Guid identifier must be provided.
        - `[IsEnabled <Boolean?>]`: When creating or updating an app role, this must be set to true (which is the default). To delete a role, this must first be set to false.  At that point, in a subsequent call, this role may be removed.
        - `[Origin <String>]`: Specifies if the app role is defined on the application object or on the servicePrincipal entity. Must not be included in any POST or PATCH requests. Read-only.
        - `[Value <String>]`: Specifies the value to include in the roles claim in ID tokens and access tokens authenticating an assigned user or service principal. Must not exceed 120 characters in length. Allowed characters are : ! # $ % & ' ( ) * + , - . / : ;  =  ? @ [ ] ^ + _  {  } ~, as well as characters in the ranges 0-9, A-Z and a-z. Any other character, including the space character, are not allowed.
      - `[ClaimsMappingPolicies <IMicrosoftGraphClaimsMappingPolicy[]>]`: 
        - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
          - `[Id <String>]`: Read-only.
          - `[DeletedDateTime <DateTime?>]`: 
        - `[Definition <String[]>]`: A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.
        - `[IsOrganizationDefault <Boolean?>]`: If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.
        - `[Description <String>]`: Description for this policy.
        - `[DisplayName <String>]`: Display name for this policy.
        - `[DeletedDateTime <DateTime?>]`: 
        - `[Id <String>]`: Read-only.
      - `[ConnectorGroupApplications <IMicrosoftGraphApplication[]>]`: 
      - `[ConnectorGroupId <String>]`: Read-only.
      - `[ConnectorGroupIsDefault <Boolean?>]`: 
      - `[ConnectorGroupMembers <IMicrosoftGraphConnector[]>]`: 
      - `[ConnectorGroupName <String>]`: 
      - `[ConnectorGroupRegion <String>]`: connectorGroupRegion
      - `[ConnectorGroupType <String>]`: connectorGroupType
      - `[CreatedDateTime <DateTime?>]`: The date and time the application was registered. Read-only.
      - `[CreatedOnBehalfOf <IMicrosoftGraphDirectoryObject>]`: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
      - `[Description <String>]`: 
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
        - `[Definition <String[]>]`: A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.
        - `[IsOrganizationDefault <Boolean?>]`: If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.
        - `[Description <String>]`: Description for this policy.
        - `[DisplayName <String>]`: Display name for this policy.
        - `[DeletedDateTime <DateTime?>]`: 
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
      - `[Notes <String>]`: 
      - `[OnPremisesPublishing <IMicrosoftGraphOnPremisesPublishing>]`: onPremisesPublishing
        - `[AlternateUrl <String>]`: 
        - `[ApplicationServerTimeout <String>]`: 
        - `[ApplicationType <String>]`: 
        - `[ExternalAuthenticationType <String>]`: externalAuthenticationType
        - `[ExternalUrl <String>]`: 
        - `[InternalUrl <String>]`: 
        - `[IsHttpOnlyCookieEnabled <Boolean?>]`: 
        - `[IsOnPremPublishingEnabled <Boolean?>]`: 
        - `[IsPersistentCookieEnabled <Boolean?>]`: 
        - `[IsSecureCookieEnabled <Boolean?>]`: 
        - `[IsTranslateHostHeaderEnabled <Boolean?>]`: 
        - `[IsTranslateLinksInBodyEnabled <Boolean?>]`: 
        - `[KerberoSignOnSettingKerberosServicePrincipalName <String>]`: 
        - `[KerberoSignOnSettingKerberosSignOnMappingAttributeType <String>]`: kerberosSignOnMappingAttributeType
        - `[SingleSignOnSettingSingleSignOnMode <String>]`: singleSignOnMode
        - `[UseAlternateUrlForTranslationAndRedirect <Boolean?>]`: 
        - `[VerifiedCustomDomainCertificateMetadataExpiryDate <DateTime?>]`: 
        - `[VerifiedCustomDomainCertificateMetadataIssueDate <DateTime?>]`: 
        - `[VerifiedCustomDomainCertificateMetadataIssuerName <String>]`: 
        - `[VerifiedCustomDomainCertificateMetadataSubjectName <String>]`: 
        - `[VerifiedCustomDomainCertificateMetadataThumbprint <String>]`: 
        - `[VerifiedCustomDomainKeyCredentialCustomKeyIdentifier <Byte[]>]`: Custom key identifier
        - `[VerifiedCustomDomainKeyCredentialDisplayName <String>]`: Friendly name for the key. Optional.
        - `[VerifiedCustomDomainKeyCredentialEndDateTime <DateTime?>]`: The date and time at which the credential expires.The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
        - `[VerifiedCustomDomainKeyCredentialKey <Byte[]>]`: Value for the key credential. Should be a base 64 encoded value.
        - `[VerifiedCustomDomainKeyCredentialKeyId <String>]`: The unique identifier (GUID) for the key.
        - `[VerifiedCustomDomainKeyCredentialStartDateTime <DateTime?>]`: The date and time at which the credential becomes valid.The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
        - `[VerifiedCustomDomainKeyCredentialType <String>]`: The type of key credential; for example, 'Symmetric'.
        - `[VerifiedCustomDomainKeyCredentialUsage <String>]`: A string that describes the purpose for which the key can be used; for example, 'Verify'.
        - `[VerifiedCustomDomainPasswordCredentialCustomKeyIdentifier <Byte[]>]`: Do not use.
        - `[VerifiedCustomDomainPasswordCredentialDisplayName <String>]`: Friendly name for the password. Optional.
        - `[VerifiedCustomDomainPasswordCredentialEndDateTime <DateTime?>]`: The date and time at which the password expires represented using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Optional.
        - `[VerifiedCustomDomainPasswordCredentialHint <String>]`: Contains the first three characters of the password. Read-only.
        - `[VerifiedCustomDomainPasswordCredentialKeyId <String>]`: The unique identifier for the password.
        - `[VerifiedCustomDomainPasswordCredentialSecretText <String>]`: Read-only; Contains the strong passwords generated by Azure AD that are 16-64 characters in length. The generated password value is only returned during the initial POST request to addPassword. There is no way to retrieve this password in the future.
        - `[VerifiedCustomDomainPasswordCredentialStartDateTime <DateTime?>]`: The date and time at which the password becomes valid. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Optional.
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
          - `[Type <String>]`: Specifies whether the id property references an oauth2PermissionScopes or an appRole. Possible values are Scope or Role.
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
          - `[QuarantineErrorCode <String>]`: 
          - `[QuarantineErrorMessage <String>]`: 
          - `[QuarantineErrorTenantActionable <Boolean?>]`: 
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
        - `[SchemaSynchronizationRules <IMicrosoftGraphSynchronizationRule[]>]`: 
        - `[SchemaVersion <String>]`: 
      - `[Tags <String[]>]`: Custom strings that can be used to categorize and identify the application. Not nullable.
      - `[TokenEncryptionKeyId <String>]`: Specifies the keyId of a public key from the keyCredentials collection. When configured, Azure AD encrypts all the tokens it emits by using the key this property points to. The application code that receives the encrypted token must use the matching private key to decrypt the token before it can be used for the signed-in user.
      - `[TokenIssuancePolicies <IMicrosoftGraphTokenIssuancePolicy[]>]`: 
        - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
        - `[Definition <String[]>]`: A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.
        - `[IsOrganizationDefault <Boolean?>]`: If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.
        - `[Description <String>]`: Description for this policy.
        - `[DisplayName <String>]`: Display name for this policy.
        - `[DeletedDateTime <DateTime?>]`: 
        - `[Id <String>]`: Read-only.
      - `[TokenLifetimePolicies <IMicrosoftGraphTokenLifetimePolicy[]>]`: 
        - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
        - `[Definition <String[]>]`: A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.
        - `[IsOrganizationDefault <Boolean?>]`: If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.
        - `[Description <String>]`: Description for this policy.
        - `[DisplayName <String>]`: Display name for this policy.
        - `[DeletedDateTime <DateTime?>]`: 
        - `[Id <String>]`: Read-only.
      - `[WebHomePageUrl <String>]`: Home page or landing page of the application.
      - `[WebLogoutUrl <String>]`: Specifies the URL that will be used by Microsoft's authorization service to logout an user using front-channel, back-channel or SAML logout protocols.
      - `[WebOauth2AllowImplicitFlow <Boolean?>]`: 
      - `[WebRedirectUris <String[]>]`: Specifies the URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent.
    - `[ConnectorGroupType <String>]`: connectorGroupType
    - `[IsDefault <Boolean?>]`: 
    - `[Members <IMicrosoftGraphConnector[]>]`: 
    - `[Name <String>]`: 
    - `[Region <String>]`: connectorGroupRegion
  - `[Status <String>]`: connectorStatus

INPUTOBJECT <IIdentityOnPremisesPublishingProfilesIdentity>: Identity Parameter
  - `[ConnectorGroupId <String>]`: key: connectorGroup-id of connectorGroup
  - `[ConnectorId <String>]`: key: connector-id of connector
  - `[OnPremisesAgentGroupId <String>]`: key: onPremisesAgentGroup-id of onPremisesAgentGroup
  - `[OnPremisesAgentGroupId1 <String>]`: key: onPremisesAgentGroup-id of onPremisesAgentGroup
  - `[OnPremisesAgentId <String>]`: key: onPremisesAgent-id of onPremisesAgent
  - `[OnPremisesAgentId1 <String>]`: key: onPremisesAgent-id of onPremisesAgent
  - `[OnPremisesPublishingProfileId <String>]`: key: onPremisesPublishingProfile-id of onPremisesPublishingProfile
  - `[PublishedResourceId <String>]`: key: publishedResource-id of publishedResource
  - `[PublishedResourceId1 <String>]`: key: publishedResource-id of publishedResource

MEMBEROF <IMicrosoftGraphConnectorGroup[]>: .
  - `[Id <String>]`: Read-only.
  - `[Applications <IMicrosoftGraphApplication[]>]`: 
    - `[DeletedDateTime <DateTime?>]`: 
    - `[Id <String>]`: Read-only.
    - `[ApiAcceptMappedClaims <Boolean?>]`: When true, allows an application to use claims mapping without specifying a custom signing key.
    - `[ApiKnownClientApplications <String[]>]`: Used for bundling consent if you have a solution that contains two parts: a client app and a custom web API app. If you set the appID of the client app to this value, the user only consents once to the client app. Azure AD knows that consenting to the client means implicitly consenting to the web API and automatically provisions service principals for both APIs at the same time. Both the client and the web API app must be registered in the same tenant.
    - `[ApiOauth2PermissionScopes <IMicrosoftGraphPermissionScope[]>]`: The definition of the delegated permissions exposed by the web API represented by this application registration. These delegated permissions may be requested by a client application, and may be granted by users or administrators during consent. Delegated permissions are sometimes referred to as OAuth 2.0 scopes.
      - `[AdminConsentDescription <String>]`: A description of the delegated permissions, intended to be read by an administrator granting the permission on behalf of all users. This text appears in tenant-wide admin consent experiences.
      - `[AdminConsentDisplayName <String>]`: The permission's title, intended to be read by an administrator granting the permission on behalf of all users.
      - `[Id <String>]`: Unique delegated permission identifier inside the collection of delegated permissions defined for a resource application.
      - `[IsEnabled <Boolean?>]`: When creating or updating a permission, this property must be set to true (which is the default). To delete a permission, this property must first be set to false.  At that point, in a subsequent call, the permission may be removed.
      - `[Origin <String>]`: 
      - `[Type <String>]`: Specifies whether this delegated permission should be considered safe for non-admin users to consent to on behalf of themselves, or whether an administrator should be required for consent to the permissions. This will be the default behavior, but each customer can choose to customize the behavior in their organization (by allowing, restricting or limiting user consent to this delegated permission.)
      - `[UserConsentDescription <String>]`: A description of the delegated permissions, intended to be read by a user granting the permission on their own behalf. This text appears in consent experiences where the user is consenting only on behalf of themselves.
      - `[UserConsentDisplayName <String>]`: A title for the permission, intended to be read by a user granting the permission on their own behalf. This text appears in consent experiences where the user is consenting only on behalf of themselves.
      - `[Value <String>]`: Specifies the value to include in the scp (scope) claim in access tokens. Must not exceed 120 characters in length. Allowed characters are : ! # $ % & ' ( ) * + , - . / : ;  =  ? @ [ ] ^ + _  {  } ~, as well as characters in the ranges 0-9, A-Z and a-z. Any other character, including the space character, are not allowed.
    - `[ApiPreAuthorizedApplications <IMicrosoftGraphPreAuthorizedApplication[]>]`: Lists the client applications that are pre-authorized with the specified delegated permissions to access this application's APIs. Users are not required to consent to any pre-authorized application (for the permissions specified). However, any additional permissions not listed in preAuthorizedApplications (requested through incremental consent for example) will require user consent.
      - `[AppId <String>]`: The unique identifier for the application.
      - `[PermissionIds <String[]>]`: 
    - `[ApiRequestedAccessTokenVersion <Int32?>]`: Specifies the access token version expected by this resource. This changes the version and format of the JWT produced independent of the endpoint or client used to request the access token.  The endpoint used, v1.0 or v2.0, is chosen by the client and only impacts the version of id_tokens. Resources need to explicitly configure requestedAccessTokenVersion to indicate the supported access token format.  Possible values for requestedAccessTokenVersion are 1, 2, or null. If the value is null, this defaults to 1, which corresponds to the v1.0 endpoint.  If signInAudience on the application is configured as AzureADandPersonalMicrosoftAccount, the value for this property must be 2
    - `[AppId <String>]`: The unique identifier for the application that is assigned to an application by Azure AD. Not nullable. Read-only.
    - `[AppRoles <IMicrosoftGraphAppRole[]>]`: The collection of roles the application declares. With app role assignments, these roles can be assigned to users, groups, or other applications' service principals. Not nullable.
      - `[AllowedMemberTypes <String[]>]`: Specifies whether this app role can be assigned to users and groups (by setting to ['User']), to other application's (by setting to ['Application'], or both (by setting to ['User', 'Application']). App roles supporting assignment of other applications' service principals are also known as application permissions.
      - `[Description <String>]`: The description for the app role. This is displayed when the app role is being assigned and, if the app role functions as an application permission, during  consent experiences.
      - `[DisplayName <String>]`: Display name for the permission that appears in the app role assignment and consent experiences.
      - `[Id <String>]`: Unique role identifier inside the appRoles collection. When creating a new app role, a new Guid identifier must be provided.
      - `[IsEnabled <Boolean?>]`: When creating or updating an app role, this must be set to true (which is the default). To delete a role, this must first be set to false.  At that point, in a subsequent call, this role may be removed.
      - `[Origin <String>]`: Specifies if the app role is defined on the application object or on the servicePrincipal entity. Must not be included in any POST or PATCH requests. Read-only.
      - `[Value <String>]`: Specifies the value to include in the roles claim in ID tokens and access tokens authenticating an assigned user or service principal. Must not exceed 120 characters in length. Allowed characters are : ! # $ % & ' ( ) * + , - . / : ;  =  ? @ [ ] ^ + _  {  } ~, as well as characters in the ranges 0-9, A-Z and a-z. Any other character, including the space character, are not allowed.
    - `[ClaimsMappingPolicies <IMicrosoftGraphClaimsMappingPolicy[]>]`: 
      - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
        - `[Id <String>]`: Read-only.
        - `[DeletedDateTime <DateTime?>]`: 
      - `[Definition <String[]>]`: A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.
      - `[IsOrganizationDefault <Boolean?>]`: If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.
      - `[Description <String>]`: Description for this policy.
      - `[DisplayName <String>]`: Display name for this policy.
      - `[DeletedDateTime <DateTime?>]`: 
      - `[Id <String>]`: Read-only.
    - `[ConnectorGroupApplications <IMicrosoftGraphApplication[]>]`: 
    - `[ConnectorGroupId <String>]`: Read-only.
    - `[ConnectorGroupIsDefault <Boolean?>]`: 
    - `[ConnectorGroupMembers <IMicrosoftGraphConnector[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[ExternalIP <String>]`: 
      - `[MachineName <String>]`: 
      - `[MemberOf <IMicrosoftGraphConnectorGroup[]>]`: 
      - `[Status <String>]`: connectorStatus
    - `[ConnectorGroupName <String>]`: 
    - `[ConnectorGroupRegion <String>]`: connectorGroupRegion
    - `[ConnectorGroupType <String>]`: connectorGroupType
    - `[CreatedDateTime <DateTime?>]`: The date and time the application was registered. Read-only.
    - `[CreatedOnBehalfOf <IMicrosoftGraphDirectoryObject>]`: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
    - `[Description <String>]`: 
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
      - `[Definition <String[]>]`: A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.
      - `[IsOrganizationDefault <Boolean?>]`: If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.
      - `[Description <String>]`: Description for this policy.
      - `[DisplayName <String>]`: Display name for this policy.
      - `[DeletedDateTime <DateTime?>]`: 
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
    - `[Notes <String>]`: 
    - `[OnPremisesPublishing <IMicrosoftGraphOnPremisesPublishing>]`: onPremisesPublishing
      - `[AlternateUrl <String>]`: 
      - `[ApplicationServerTimeout <String>]`: 
      - `[ApplicationType <String>]`: 
      - `[ExternalAuthenticationType <String>]`: externalAuthenticationType
      - `[ExternalUrl <String>]`: 
      - `[InternalUrl <String>]`: 
      - `[IsHttpOnlyCookieEnabled <Boolean?>]`: 
      - `[IsOnPremPublishingEnabled <Boolean?>]`: 
      - `[IsPersistentCookieEnabled <Boolean?>]`: 
      - `[IsSecureCookieEnabled <Boolean?>]`: 
      - `[IsTranslateHostHeaderEnabled <Boolean?>]`: 
      - `[IsTranslateLinksInBodyEnabled <Boolean?>]`: 
      - `[KerberoSignOnSettingKerberosServicePrincipalName <String>]`: 
      - `[KerberoSignOnSettingKerberosSignOnMappingAttributeType <String>]`: kerberosSignOnMappingAttributeType
      - `[SingleSignOnSettingSingleSignOnMode <String>]`: singleSignOnMode
      - `[UseAlternateUrlForTranslationAndRedirect <Boolean?>]`: 
      - `[VerifiedCustomDomainCertificateMetadataExpiryDate <DateTime?>]`: 
      - `[VerifiedCustomDomainCertificateMetadataIssueDate <DateTime?>]`: 
      - `[VerifiedCustomDomainCertificateMetadataIssuerName <String>]`: 
      - `[VerifiedCustomDomainCertificateMetadataSubjectName <String>]`: 
      - `[VerifiedCustomDomainCertificateMetadataThumbprint <String>]`: 
      - `[VerifiedCustomDomainKeyCredentialCustomKeyIdentifier <Byte[]>]`: Custom key identifier
      - `[VerifiedCustomDomainKeyCredentialDisplayName <String>]`: Friendly name for the key. Optional.
      - `[VerifiedCustomDomainKeyCredentialEndDateTime <DateTime?>]`: The date and time at which the credential expires.The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
      - `[VerifiedCustomDomainKeyCredentialKey <Byte[]>]`: Value for the key credential. Should be a base 64 encoded value.
      - `[VerifiedCustomDomainKeyCredentialKeyId <String>]`: The unique identifier (GUID) for the key.
      - `[VerifiedCustomDomainKeyCredentialStartDateTime <DateTime?>]`: The date and time at which the credential becomes valid.The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
      - `[VerifiedCustomDomainKeyCredentialType <String>]`: The type of key credential; for example, 'Symmetric'.
      - `[VerifiedCustomDomainKeyCredentialUsage <String>]`: A string that describes the purpose for which the key can be used; for example, 'Verify'.
      - `[VerifiedCustomDomainPasswordCredentialCustomKeyIdentifier <Byte[]>]`: Do not use.
      - `[VerifiedCustomDomainPasswordCredentialDisplayName <String>]`: Friendly name for the password. Optional.
      - `[VerifiedCustomDomainPasswordCredentialEndDateTime <DateTime?>]`: The date and time at which the password expires represented using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Optional.
      - `[VerifiedCustomDomainPasswordCredentialHint <String>]`: Contains the first three characters of the password. Read-only.
      - `[VerifiedCustomDomainPasswordCredentialKeyId <String>]`: The unique identifier for the password.
      - `[VerifiedCustomDomainPasswordCredentialSecretText <String>]`: Read-only; Contains the strong passwords generated by Azure AD that are 16-64 characters in length. The generated password value is only returned during the initial POST request to addPassword. There is no way to retrieve this password in the future.
      - `[VerifiedCustomDomainPasswordCredentialStartDateTime <DateTime?>]`: The date and time at which the password becomes valid. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Optional.
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
        - `[Type <String>]`: Specifies whether the id property references an oauth2PermissionScopes or an appRole. Possible values are Scope or Role.
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
        - `[QuarantineErrorCode <String>]`: 
        - `[QuarantineErrorMessage <String>]`: 
        - `[QuarantineErrorTenantActionable <Boolean?>]`: 
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
      - `[SchemaSynchronizationRules <IMicrosoftGraphSynchronizationRule[]>]`: 
      - `[SchemaVersion <String>]`: 
    - `[Tags <String[]>]`: Custom strings that can be used to categorize and identify the application. Not nullable.
    - `[TokenEncryptionKeyId <String>]`: Specifies the keyId of a public key from the keyCredentials collection. When configured, Azure AD encrypts all the tokens it emits by using the key this property points to. The application code that receives the encrypted token must use the matching private key to decrypt the token before it can be used for the signed-in user.
    - `[TokenIssuancePolicies <IMicrosoftGraphTokenIssuancePolicy[]>]`: 
      - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
      - `[Definition <String[]>]`: A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.
      - `[IsOrganizationDefault <Boolean?>]`: If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.
      - `[Description <String>]`: Description for this policy.
      - `[DisplayName <String>]`: Display name for this policy.
      - `[DeletedDateTime <DateTime?>]`: 
      - `[Id <String>]`: Read-only.
    - `[TokenLifetimePolicies <IMicrosoftGraphTokenLifetimePolicy[]>]`: 
      - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
      - `[Definition <String[]>]`: A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.
      - `[IsOrganizationDefault <Boolean?>]`: If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.
      - `[Description <String>]`: Description for this policy.
      - `[DisplayName <String>]`: Display name for this policy.
      - `[DeletedDateTime <DateTime?>]`: 
      - `[Id <String>]`: Read-only.
    - `[WebHomePageUrl <String>]`: Home page or landing page of the application.
    - `[WebLogoutUrl <String>]`: Specifies the URL that will be used by Microsoft's authorization service to logout an user using front-channel, back-channel or SAML logout protocols.
    - `[WebOauth2AllowImplicitFlow <Boolean?>]`: 
    - `[WebRedirectUris <String[]>]`: Specifies the URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent.
  - `[ConnectorGroupType <String>]`: connectorGroupType
  - `[IsDefault <Boolean?>]`: 
  - `[Members <IMicrosoftGraphConnector[]>]`: 
  - `[Name <String>]`: 
  - `[Region <String>]`: connectorGroupRegion

## RELATED LINKS

