---
external help file:
Module Name: Microsoft.Graph.Applications
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.applications/new-mgapplication
schema: 2.0.0
---

# New-MgApplication

## SYNOPSIS
Create a new application object.

## SYNTAX

### CreateExpanded (Default)
```
New-MgApplication [-AddIns <IMicrosoftGraphAddIn[]>] [-AdditionalProperties <Hashtable>]
 [-Api <IMicrosoftGraphApiApplication>] [-AppId <String>] [-ApplicationTemplateId <String>]
 [-AppManagementPolicies <IMicrosoftGraphAppManagementPolicy[]>] [-AppRoles <IMicrosoftGraphAppRole[]>]
 [-Certification <IMicrosoftGraphCertification>] [-CreatedDateTime <DateTime>]
 [-CreatedOnBehalfOf <IMicrosoftGraphDirectoryObject>] [-DefaultRedirectUri <String>]
 [-DeletedDateTime <DateTime>] [-Description <String>] [-DisabledByMicrosoftStatus <String>]
 [-DisplayName <String>] [-ExtensionProperties <IMicrosoftGraphExtensionProperty[]>]
 [-FederatedIdentityCredentials <IMicrosoftGraphFederatedIdentityCredential[]>]
 [-GroupMembershipClaims <String>] [-HomeRealmDiscoveryPolicies <IMicrosoftGraphHomeRealmDiscoveryPolicy[]>]
 [-Id <String>] [-IdentifierUris <String[]>] [-Info <IMicrosoftGraphInformationalUrl>]
 [-IsDeviceOnlyAuthSupported] [-IsFallbackPublicClient] [-KeyCredentials <IMicrosoftGraphKeyCredential[]>]
 [-LogoInputFile <String>] [-Notes <String>] [-Oauth2RequirePostResponse]
 [-OptionalClaims <IMicrosoftGraphOptionalClaims>] [-Owners <IMicrosoftGraphDirectoryObject[]>]
 [-ParentalControlSettings <IMicrosoftGraphParentalControlSettings>]
 [-PasswordCredentials <IMicrosoftGraphPasswordCredential[]>]
 [-PublicClient <IMicrosoftGraphPublicClientApplication>] [-PublisherDomain <String>]
 [-RequestSignatureVerification <IMicrosoftGraphRequestSignatureVerification>]
 [-RequiredResourceAccess <IMicrosoftGraphRequiredResourceAccess[]>] [-ResponseHeadersVariable <String>]
 [-SamlMetadataUrl <String>] [-ServiceManagementReference <String>]
 [-ServicePrincipalLockConfiguration <IMicrosoftGraphServicePrincipalLockConfiguration>]
 [-SignInAudience <String>] [-Spa <IMicrosoftGraphSpaApplication>]
 [-Synchronization <IMicrosoftGraphSynchronization>] [-Tags <String[]>] [-TokenEncryptionKeyId <String>]
 [-TokenIssuancePolicies <IMicrosoftGraphTokenIssuancePolicy[]>]
 [-TokenLifetimePolicies <IMicrosoftGraphTokenLifetimePolicy[]>] [-UniqueName <String>]
 [-VerifiedPublisher <IMicrosoftGraphVerifiedPublisher>] [-Web <IMicrosoftGraphWebApplication>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgApplication -BodyParameter <IMicrosoftGraphApplication> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create a new application object.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
New-MgApplication -DisplayName 'New app' | 
  Format-List Id, DisplayName, AppId, SignInAudience, PublisherDomain
```

Id              : 0f0aec7b-ac5b-4f89-9fac-e9044ba5a309
DisplayName     : New app
AppId           : c678b75d-1012-4466-8655-1672192232b4
SignInAudience  : AzureADandPersonalMicrosoftAccount
PublisherDomain : M365B977454.onmicrosoft.com

## PARAMETERS

### -AddIns
Defines custom behavior that a consuming service can use to call an app in specific contexts.
For example, applications that can render file streams can set the addIns property for its 'FileHandler' functionality.
This lets services like Microsoft 365 call the application in the context of a document the user is working on.
To construct, see NOTES section for ADDINS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAddIn[]
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Api
apiApplication
To construct, see NOTES section for API properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphApiApplication
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AppId
The unique identifier for the application that is assigned to an application by Microsoft Entra ID.
Not nullable.
Read-only.
Alternate key.
Supports $filter (eq).

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

### -ApplicationTemplateId
Unique identifier of the applicationTemplate.
Supports $filter (eq, not, ne).
Read-only.
null if the app wasn't created from an application template.

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

### -AppManagementPolicies
The appManagementPolicy applied to this application.
To construct, see NOTES section for APPMANAGEMENTPOLICIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAppManagementPolicy[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AppRoles
The collection of roles defined for the application.
With app role assignments, these roles can be assigned to users, groups, or service principals associated with other applications.
Not nullable.
To construct, see NOTES section for APPROLES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAppRole[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
application
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphApplication
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Certification
certification
To construct, see NOTES section for CERTIFICATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCertification
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedDateTime
The date and time the application was registered.
The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
Read-only.
Supports $filter (eq, ne, not, ge, le, in, and eq on null values) and $orderby.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedOnBehalfOf
directoryObject
To construct, see NOTES section for CREATEDONBEHALFOF properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectoryObject
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultRedirectUri
.

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

### -DeletedDateTime
Date and time when this object was deleted.
Always null when the object hasn't been deleted.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
Free text field to provide a description of the application object to end users.
The maximum allowed size is 1,024 characters.
Supports $filter (eq, ne, not, ge, le, startsWith) and $search.

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

### -DisabledByMicrosoftStatus
Specifies whether Microsoft has disabled the registered application.
Possible values are: null (default value), NotDisabled, and DisabledDueToViolationOfServicesAgreement (reasons include suspicious, abusive, or malicious activity, or a violation of the Microsoft Services Agreement).
Supports $filter (eq, ne, not).

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

### -DisplayName
The display name for the application.
Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values), $search, and $orderby.

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

### -ExtensionProperties
Read-only.
Nullable.
Supports $expand and $filter (/$count eq 0, /$count ne 0).
To construct, see NOTES section for EXTENSIONPROPERTIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphExtensionProperty[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FederatedIdentityCredentials
Federated identities for applications.
Supports $expand and $filter (startsWith, /$count eq 0, /$count ne 0).
To construct, see NOTES section for FEDERATEDIDENTITYCREDENTIALS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphFederatedIdentityCredential[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GroupMembershipClaims
Configures the groups claim issued in a user or OAuth 2.0 access token that the application expects.
To set this attribute, use one of the following valid string values: None, SecurityGroup (for security groups and Microsoft Entra roles), All (this gets all of the security groups, distribution groups, and Microsoft Entra directory roles that the signed-in user is a member of).

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

### -HomeRealmDiscoveryPolicies
.
To construct, see NOTES section for HOMEREALMDISCOVERYPOLICIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphHomeRealmDiscoveryPolicy[]
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IdentifierUris
Also known as App ID URI, this value is set when an application is used as a resource app.
The identifierUris acts as the prefix for the scopes you reference in your API's code, and it must be globally unique.
You can use the default value provided, which is in the form api://\<application-client-id\>, or specify a more readable URI like https://contoso.com/api.
For more information on valid identifierUris patterns and best practices, see Microsoft Entra application registration security best practices.
Not nullable.
Supports $filter (eq, ne, ge, le, startsWith).

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

### -Info
informationalUrl
To construct, see NOTES section for INFO properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphInformationalUrl
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsDeviceOnlyAuthSupported
Specifies whether this application supports device authentication without a user.
The default is false.

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

### -IsFallbackPublicClient
Specifies the fallback application type as public client, such as an installed application running on a mobile device.
The default value is false, which means the fallback application type is confidential client such as a web app.
There are certain scenarios where Microsoft Entra ID can't determine the client application type.
For example, the ROPC flow where it's configured without specifying a redirect URI.
In those cases, Microsoft Entra ID interprets the application type based on the value of this property.

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

### -KeyCredentials
The collection of key credentials associated with the application.
Not nullable.
Supports $filter (eq, not, ge, le).
To construct, see NOTES section for KEYCREDENTIALS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphKeyCredential[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LogoInputFile
Input File for Logo (The main logo for the application.
Not nullable.)

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

### -Notes
Notes relevant for the management of the application.

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

### -Oauth2RequirePostResponse
.

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

### -OptionalClaims
optionalClaims
To construct, see NOTES section for OPTIONALCLAIMS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOptionalClaims
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Owners
Directory objects that are owners of the application.
Read-only.
Nullable.
Supports $expand, $filter (/$count eq 0, /$count ne 0, /$count eq 1, /$count ne 1), and $select nested in $expand.
To construct, see NOTES section for OWNERS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectoryObject[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ParentalControlSettings
parentalControlSettings
To construct, see NOTES section for PARENTALCONTROLSETTINGS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphParentalControlSettings
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PasswordCredentials
The collection of password credentials associated with the application.
Not nullable.
To construct, see NOTES section for PASSWORDCREDENTIALS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPasswordCredential[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PublicClient
publicClientApplication
To construct, see NOTES section for PUBLICCLIENT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPublicClientApplication
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PublisherDomain
The verified publisher domain for the application.
Read-only.
For more information, see How to: Configure an application's publisher domain.
Supports $filter (eq, ne, ge, le, startsWith).

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

### -RequestSignatureVerification
requestSignatureVerification
To construct, see NOTES section for REQUESTSIGNATUREVERIFICATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRequestSignatureVerification
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RequiredResourceAccess
Specifies the resources that the application needs to access.
This property also specifies the set of delegated permissions and application roles that it needs for each of those resources.
This configuration of access to the required resources drives the consent experience.
No more than 50 resource services (APIs) can be configured.
Beginning mid-October 2021, the total number of required permissions must not exceed 400.
For more information, see Limits on requested permissions per app.
Not nullable.
Supports $filter (eq, not, ge, le).
To construct, see NOTES section for REQUIREDRESOURCEACCESS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRequiredResourceAccess[]
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

### -SamlMetadataUrl
The URL where the service exposes SAML metadata for federation.
This property is valid only for single-tenant applications.
Nullable.

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

### -ServiceManagementReference
References application or service contact information from a Service or Asset Management database.
Nullable.

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

### -ServicePrincipalLockConfiguration
servicePrincipalLockConfiguration
To construct, see NOTES section for SERVICEPRINCIPALLOCKCONFIGURATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphServicePrincipalLockConfiguration
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SignInAudience
Specifies the Microsoft accounts that are supported for the current application.
The possible values are: AzureADMyOrg (default), AzureADMultipleOrgs, AzureADandPersonalMicrosoftAccount, and PersonalMicrosoftAccount.
See more in the table.
The value of this object also limits the number of permissions an app can request.
For more information, see Limits on requested permissions per app.
The value for this property has implications on other app object properties.
As a result, if you change this property, you might need to change other properties first.
For more information, see Validation differences for signInAudience.Supports $filter (eq, ne, not).

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

### -Spa
spaApplication
To construct, see NOTES section for SPA properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSpaApplication
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Synchronization
synchronization
To construct, see NOTES section for SYNCHRONIZATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSynchronization
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Tags
Custom strings that can be used to categorize and identify the application.
Not nullable.
Strings added here will also appear in the tags property of any associated service principals.Supports $filter (eq, not, ge, le, startsWith) and $search.

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

### -TokenEncryptionKeyId
Specifies the keyId of a public key from the keyCredentials collection.
When configured, Microsoft Entra ID encrypts all the tokens it emits by using the key this property points to.
The application code that receives the encrypted token must use the matching private key to decrypt the token before it can be used for the signed-in user.

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

### -TokenIssuancePolicies
.
To construct, see NOTES section for TOKENISSUANCEPOLICIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTokenIssuancePolicy[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TokenLifetimePolicies
.
To construct, see NOTES section for TOKENLIFETIMEPOLICIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTokenLifetimePolicy[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UniqueName
.

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

### -VerifiedPublisher
verifiedPublisher
To construct, see NOTES section for VERIFIEDPUBLISHER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphVerifiedPublisher
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Web
webApplication
To construct, see NOTES section for WEB properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWebApplication
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphApplication

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphApplication

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`ADDINS <IMicrosoftGraphAddIn[]>`: Defines custom behavior that a consuming service can use to call an app in specific contexts. For example, applications that can render file streams can set the addIns property for its 'FileHandler' functionality. This lets services like Microsoft 365 call the application in the context of a document the user is working on.
  - `[Id <String>]`: 
  - `[Properties <IMicrosoftGraphKeyValue[]>]`: 
    - `[Key <String>]`: Key for the key-value pair.
    - `[Value <String>]`: Value for the key-value pair.
  - `[Type <String>]`: 

`API <IMicrosoftGraphApiApplication>`: apiApplication
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AcceptMappedClaims <Boolean?>]`: When true, allows an application to use claims mapping without specifying a custom signing key.
  - `[KnownClientApplications <String[]>]`: Used for bundling consent if you have a solution that contains two parts: a client app and a custom web API app. If you set the appID of the client app to this value, the user only consents once to the client app. Microsoft Entra ID knows that consenting to the client means implicitly consenting to the web API and automatically provisions service principals for both APIs at the same time. Both the client and the web API app must be registered in the same tenant.
  - `[Oauth2PermissionScopes <IMicrosoftGraphPermissionScope[]>]`: The definition of the delegated permissions exposed by the web API represented by this application registration. These delegated permissions may be requested by a client application, and may be granted by users or administrators during consent. Delegated permissions are sometimes referred to as OAuth 2.0 scopes.
    - `[AdminConsentDescription <String>]`: A description of the delegated permissions, intended to be read by an administrator granting the permission on behalf of all users. This text appears in tenant-wide admin consent experiences.
    - `[AdminConsentDisplayName <String>]`: The permission's title, intended to be read by an administrator granting the permission on behalf of all users.
    - `[Id <String>]`: Unique delegated permission identifier inside the collection of delegated permissions defined for a resource application.
    - `[IsEnabled <Boolean?>]`: When you create or update a permission, this property must be set to true (which is the default). To delete a permission, this property must first be set to false.  At that point, in a subsequent call, the permission may be removed.
    - `[Origin <String>]`: 
    - `[Type <String>]`: The possible values are: User and Admin. Specifies whether this delegated permission should be considered safe for non-admin users to consent to on behalf of themselves, or whether an administrator consent should always be required. While Microsoft Graph defines the default consent requirement for each permission, the tenant administrator may override the behavior in their organization (by allowing, restricting, or limiting user consent to this delegated permission). For more information, see Configure how users consent to applications.
    - `[UserConsentDescription <String>]`: A description of the delegated permissions, intended to be read by a user granting the permission on their own behalf. This text appears in consent experiences where the user is consenting only on behalf of themselves.
    - `[UserConsentDisplayName <String>]`: A title for the permission, intended to be read by a user granting the permission on their own behalf. This text appears in consent experiences where the user is consenting only on behalf of themselves.
    - `[Value <String>]`: Specifies the value to include in the scp (scope) claim in access tokens. Must not exceed 120 characters in length. Allowed characters are : ! # $ % & ' ( ) * + , - . / : ;  =  ? @ [ ] ^ + _  {  } ~, and characters in the ranges 0-9, A-Z and a-z. Any other character, including the space character, aren't allowed. May not begin with ..
  - `[PreAuthorizedApplications <IMicrosoftGraphPreAuthorizedApplication[]>]`: Lists the client applications that are preauthorized with the specified delegated permissions to access this application's APIs. Users aren't required to consent to any preauthorized application (for the permissions specified). However, any other permissions not listed in preAuthorizedApplications (requested through incremental consent for example) will require user consent.
    - `[AppId <String>]`: The unique identifier for the application.
    - `[DelegatedPermissionIds <String[]>]`: The unique identifier for the oauth2PermissionScopes the application requires.
  - `[RequestedAccessTokenVersion <Int32?>]`: Specifies the access token version expected by this resource. This changes the version and format of the JWT produced independent of the endpoint or client used to request the access token.  The endpoint used, v1.0 or v2.0, is chosen by the client and only impacts the version of id_tokens. Resources need to explicitly configure requestedAccessTokenVersion to indicate the supported access token format.  Possible values for requestedAccessTokenVersion are 1, 2, or null. If the value is null, this defaults to 1, which corresponds to the v1.0 endpoint.  If signInAudience on the application is configured as AzureADandPersonalMicrosoftAccount or PersonalMicrosoftAccount, the value for this property must be 2.

`APPMANAGEMENTPOLICIES <IMicrosoftGraphAppManagementPolicy[]>`: The appManagementPolicy applied to this application.
  - `[Description <String>]`: Description for this policy. Required.
  - `[DisplayName <String>]`: Display name for this policy. Required.
  - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: Collection of applications and service principals to which the policy is applied.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
  - `[IsEnabled <Boolean?>]`: Denotes whether the policy is enabled.
  - `[Restrictions <IMicrosoftGraphAppManagementConfiguration>]`: appManagementConfiguration
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[KeyCredentials <IMicrosoftGraphKeyCredentialConfiguration[]>]`: Collection of keyCredential restrictions settings to be applied to an application or service principal.
      - `[MaxLifetime <TimeSpan?>]`: 
      - `[RestrictForAppsCreatedAfterDateTime <DateTime?>]`: Timestamp when the policy is enforced for all apps created on or after the specified date. For existing applications, the enforcement date would be back dated. To apply to all applications regardless of their creation date, this property would be null. Nullable.
      - `[RestrictionType <String>]`: appKeyCredentialRestrictionType
    - `[PasswordCredentials <IMicrosoftGraphPasswordCredentialConfiguration[]>]`: Collection of password restrictions settings to be applied to an application or service principal.
      - `[MaxLifetime <TimeSpan?>]`: 
      - `[RestrictForAppsCreatedAfterDateTime <DateTime?>]`: Enforces the policy for an app created on or after the enforcement date. For existing applications, the enforcement date would be back dated. To apply to all applications, enforcement datetime would be null.
      - `[RestrictionType <String>]`: appCredentialRestrictionType

`APPROLES <IMicrosoftGraphAppRole[]>`: The collection of roles defined for the application. With app role assignments, these roles can be assigned to users, groups, or service principals associated with other applications. Not nullable.
  - `[AllowedMemberTypes <String[]>]`: Specifies whether this app role can be assigned to users and groups (by setting to ['User']), to other application's (by setting to ['Application'], or both (by setting to ['User', 'Application']). App roles supporting assignment to other applications' service principals are also known as application permissions. The 'Application' value is only supported for app roles defined on application entities.
  - `[Description <String>]`: The description for the app role. This is displayed when the app role is being assigned and, if the app role functions as an application permission, during  consent experiences.
  - `[DisplayName <String>]`: Display name for the permission that appears in the app role assignment and consent experiences.
  - `[Id <String>]`: Unique role identifier inside the appRoles collection. When creating a new app role, a new GUID identifier must be provided.
  - `[IsEnabled <Boolean?>]`: When creating or updating an app role, this must be set to true (which is the default). To delete a role, this must first be set to false.  At that point, in a subsequent call, this role may be removed.
  - `[Origin <String>]`: Specifies if the app role is defined on the application object or on the servicePrincipal entity. Must not be included in any POST or PATCH requests. Read-only.
  - `[Value <String>]`: Specifies the value to include in the roles claim in ID tokens and access tokens authenticating an assigned user or service principal. Must not exceed 120 characters in length. Allowed characters are : ! # $ % & ' ( ) * + , - . / : ;  =  ? @ [ ] ^ + _  {  } ~, and characters in the ranges 0-9, A-Z and a-z. Any other character, including the space character, aren't allowed. May not begin with ..

`BODYPARAMETER <IMicrosoftGraphApplication>`: application
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AddIns <IMicrosoftGraphAddIn[]>]`: Defines custom behavior that a consuming service can use to call an app in specific contexts. For example, applications that can render file streams can set the addIns property for its 'FileHandler' functionality. This lets services like Microsoft 365 call the application in the context of a document the user is working on.
    - `[Id <String>]`: 
    - `[Properties <IMicrosoftGraphKeyValue[]>]`: 
      - `[Key <String>]`: Key for the key-value pair.
      - `[Value <String>]`: Value for the key-value pair.
    - `[Type <String>]`: 
  - `[Api <IMicrosoftGraphApiApplication>]`: apiApplication
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AcceptMappedClaims <Boolean?>]`: When true, allows an application to use claims mapping without specifying a custom signing key.
    - `[KnownClientApplications <String[]>]`: Used for bundling consent if you have a solution that contains two parts: a client app and a custom web API app. If you set the appID of the client app to this value, the user only consents once to the client app. Microsoft Entra ID knows that consenting to the client means implicitly consenting to the web API and automatically provisions service principals for both APIs at the same time. Both the client and the web API app must be registered in the same tenant.
    - `[Oauth2PermissionScopes <IMicrosoftGraphPermissionScope[]>]`: The definition of the delegated permissions exposed by the web API represented by this application registration. These delegated permissions may be requested by a client application, and may be granted by users or administrators during consent. Delegated permissions are sometimes referred to as OAuth 2.0 scopes.
      - `[AdminConsentDescription <String>]`: A description of the delegated permissions, intended to be read by an administrator granting the permission on behalf of all users. This text appears in tenant-wide admin consent experiences.
      - `[AdminConsentDisplayName <String>]`: The permission's title, intended to be read by an administrator granting the permission on behalf of all users.
      - `[Id <String>]`: Unique delegated permission identifier inside the collection of delegated permissions defined for a resource application.
      - `[IsEnabled <Boolean?>]`: When you create or update a permission, this property must be set to true (which is the default). To delete a permission, this property must first be set to false.  At that point, in a subsequent call, the permission may be removed.
      - `[Origin <String>]`: 
      - `[Type <String>]`: The possible values are: User and Admin. Specifies whether this delegated permission should be considered safe for non-admin users to consent to on behalf of themselves, or whether an administrator consent should always be required. While Microsoft Graph defines the default consent requirement for each permission, the tenant administrator may override the behavior in their organization (by allowing, restricting, or limiting user consent to this delegated permission). For more information, see Configure how users consent to applications.
      - `[UserConsentDescription <String>]`: A description of the delegated permissions, intended to be read by a user granting the permission on their own behalf. This text appears in consent experiences where the user is consenting only on behalf of themselves.
      - `[UserConsentDisplayName <String>]`: A title for the permission, intended to be read by a user granting the permission on their own behalf. This text appears in consent experiences where the user is consenting only on behalf of themselves.
      - `[Value <String>]`: Specifies the value to include in the scp (scope) claim in access tokens. Must not exceed 120 characters in length. Allowed characters are : ! # $ % & ' ( ) * + , - . / : ;  =  ? @ [ ] ^ + _  {  } ~, and characters in the ranges 0-9, A-Z and a-z. Any other character, including the space character, aren't allowed. May not begin with ..
    - `[PreAuthorizedApplications <IMicrosoftGraphPreAuthorizedApplication[]>]`: Lists the client applications that are preauthorized with the specified delegated permissions to access this application's APIs. Users aren't required to consent to any preauthorized application (for the permissions specified). However, any other permissions not listed in preAuthorizedApplications (requested through incremental consent for example) will require user consent.
      - `[AppId <String>]`: The unique identifier for the application.
      - `[DelegatedPermissionIds <String[]>]`: The unique identifier for the oauth2PermissionScopes the application requires.
    - `[RequestedAccessTokenVersion <Int32?>]`: Specifies the access token version expected by this resource. This changes the version and format of the JWT produced independent of the endpoint or client used to request the access token.  The endpoint used, v1.0 or v2.0, is chosen by the client and only impacts the version of id_tokens. Resources need to explicitly configure requestedAccessTokenVersion to indicate the supported access token format.  Possible values for requestedAccessTokenVersion are 1, 2, or null. If the value is null, this defaults to 1, which corresponds to the v1.0 endpoint.  If signInAudience on the application is configured as AzureADandPersonalMicrosoftAccount or PersonalMicrosoftAccount, the value for this property must be 2.
  - `[AppId <String>]`: The unique identifier for the application that is assigned to an application by Microsoft Entra ID. Not nullable. Read-only. Alternate key. Supports $filter (eq).
  - `[AppManagementPolicies <IMicrosoftGraphAppManagementPolicy[]>]`: The appManagementPolicy applied to this application.
    - `[Description <String>]`: Description for this policy. Required.
    - `[DisplayName <String>]`: Display name for this policy. Required.
    - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: Collection of applications and service principals to which the policy is applied.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
    - `[IsEnabled <Boolean?>]`: Denotes whether the policy is enabled.
    - `[Restrictions <IMicrosoftGraphAppManagementConfiguration>]`: appManagementConfiguration
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[KeyCredentials <IMicrosoftGraphKeyCredentialConfiguration[]>]`: Collection of keyCredential restrictions settings to be applied to an application or service principal.
        - `[MaxLifetime <TimeSpan?>]`: 
        - `[RestrictForAppsCreatedAfterDateTime <DateTime?>]`: Timestamp when the policy is enforced for all apps created on or after the specified date. For existing applications, the enforcement date would be back dated. To apply to all applications regardless of their creation date, this property would be null. Nullable.
        - `[RestrictionType <String>]`: appKeyCredentialRestrictionType
      - `[PasswordCredentials <IMicrosoftGraphPasswordCredentialConfiguration[]>]`: Collection of password restrictions settings to be applied to an application or service principal.
        - `[MaxLifetime <TimeSpan?>]`: 
        - `[RestrictForAppsCreatedAfterDateTime <DateTime?>]`: Enforces the policy for an app created on or after the enforcement date. For existing applications, the enforcement date would be back dated. To apply to all applications, enforcement datetime would be null.
        - `[RestrictionType <String>]`: appCredentialRestrictionType
  - `[AppRoles <IMicrosoftGraphAppRole[]>]`: The collection of roles defined for the application. With app role assignments, these roles can be assigned to users, groups, or service principals associated with other applications. Not nullable.
    - `[AllowedMemberTypes <String[]>]`: Specifies whether this app role can be assigned to users and groups (by setting to ['User']), to other application's (by setting to ['Application'], or both (by setting to ['User', 'Application']). App roles supporting assignment to other applications' service principals are also known as application permissions. The 'Application' value is only supported for app roles defined on application entities.
    - `[Description <String>]`: The description for the app role. This is displayed when the app role is being assigned and, if the app role functions as an application permission, during  consent experiences.
    - `[DisplayName <String>]`: Display name for the permission that appears in the app role assignment and consent experiences.
    - `[Id <String>]`: Unique role identifier inside the appRoles collection. When creating a new app role, a new GUID identifier must be provided.
    - `[IsEnabled <Boolean?>]`: When creating or updating an app role, this must be set to true (which is the default). To delete a role, this must first be set to false.  At that point, in a subsequent call, this role may be removed.
    - `[Origin <String>]`: Specifies if the app role is defined on the application object or on the servicePrincipal entity. Must not be included in any POST or PATCH requests. Read-only.
    - `[Value <String>]`: Specifies the value to include in the roles claim in ID tokens and access tokens authenticating an assigned user or service principal. Must not exceed 120 characters in length. Allowed characters are : ! # $ % & ' ( ) * + , - . / : ;  =  ? @ [ ] ^ + _  {  } ~, and characters in the ranges 0-9, A-Z and a-z. Any other character, including the space character, aren't allowed. May not begin with ..
  - `[ApplicationTemplateId <String>]`: Unique identifier of the applicationTemplate. Supports $filter (eq, not, ne). Read-only. null if the app wasn't created from an application template.
  - `[Certification <IMicrosoftGraphCertification>]`: certification
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[CertificationExpirationDateTime <DateTime?>]`: The timestamp when the current certification for the application expires.
    - `[IsPublisherAttested <Boolean?>]`: Indicates whether the application has been self-attested by the application developer or the publisher.
    - `[LastCertificationDateTime <DateTime?>]`: The timestamp when the certification for the application was most recently added or updated.
  - `[CreatedDateTime <DateTime?>]`: The date and time the application was registered. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.  Supports $filter (eq, ne, not, ge, le, in, and eq on null values) and $orderby.
  - `[CreatedOnBehalfOf <IMicrosoftGraphDirectoryObject>]`: directoryObject
  - `[DefaultRedirectUri <String>]`: 
  - `[Description <String>]`: Free text field to provide a description of the application object to end users. The maximum allowed size is 1,024 characters. Supports $filter (eq, ne, not, ge, le, startsWith) and $search.
  - `[DisabledByMicrosoftStatus <String>]`: Specifies whether Microsoft has disabled the registered application. Possible values are: null (default value), NotDisabled, and DisabledDueToViolationOfServicesAgreement (reasons include suspicious, abusive, or malicious activity, or a violation of the Microsoft Services Agreement).  Supports $filter (eq, ne, not).
  - `[DisplayName <String>]`: The display name for the application. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values), $search, and $orderby.
  - `[ExtensionProperties <IMicrosoftGraphExtensionProperty[]>]`: Read-only. Nullable. Supports $expand and $filter (/$count eq 0, /$count ne 0).
    - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[AppDisplayName <String>]`: Display name of the application object on which this extension property is defined. Read-only.
    - `[DataType <String>]`: Specifies the data type of the value the extension property can hold. Following values are supported. Binary - 256 bytes maximumBooleanDateTime - Must be specified in ISO 8601 format. Will be stored in UTC.Integer - 32-bit value.LargeInteger - 64-bit value.String - 256 characters maximumNot nullable. For multivalued directory extensions, these limits apply per value in the collection.
    - `[IsMultiValued <Boolean?>]`: Defines the directory extension as a multi-valued property. When true, the directory extension property can store a collection of objects of the dataType; for example, a collection of string types such as 'extensionb7b1c57b532f40b8b5ed4b7a7ba67401jobGroupTracker': ['String 1', 'String 2']. The default value is false. Supports $filter (eq).
    - `[IsSyncedFromOnPremises <Boolean?>]`: Indicates if this extension property was synced from on-premises active directory using Microsoft Entra Connect. Read-only.
    - `[Name <String>]`: Name of the extension property. Not nullable. Supports $filter (eq).
    - `[TargetObjects <String[]>]`: Following values are supported. Not nullable. UserGroupAdministrativeUnitApplicationDeviceOrganization
  - `[FederatedIdentityCredentials <IMicrosoftGraphFederatedIdentityCredential[]>]`: Federated identities for applications. Supports $expand and $filter (startsWith, /$count eq 0, /$count ne 0).
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Audiences <String[]>]`: The audience that can appear in the external token. This field is mandatory and should be set to api://AzureADTokenExchange for Microsoft Entra ID. It says what Microsoft identity platform should accept in the aud claim in the incoming token. This value represents Microsoft Entra ID in your external identity provider and has no fixed value across identity providers - you might need to create a new application registration in your identity provider to serve as the audience of this token. This field can only accept a single value and has a limit of 600 characters. Required.
    - `[Description <String>]`: The unvalidated description of the federated identity credential, provided by the user. It has a limit of 600 characters. Optional.
    - `[Issuer <String>]`: The URL of the external identity provider, which must match the issuer claim of the external token being exchanged. The combination of the values of issuer and subject must be unique within the app. It has a limit of 600 characters. Required.
    - `[Name <String>]`: The unique identifier for the federated identity credential, which has a limit of 120 characters and must be URL friendly. The string is immutable after it's created. Required. Not nullable. Supports $filter (eq).
    - `[Subject <String>]`: Required. The identifier of the external software workload within the external identity provider. Like the audience value, it has no fixed format; each identity provider uses their own - sometimes a GUID, sometimes a colon delimited identifier, sometimes arbitrary strings. The value here must match the sub claim within the token presented to Microsoft Entra ID. The combination of issuer and subject must be unique within the app. It has a limit of 600 characters. Supports $filter (eq).
  - `[GroupMembershipClaims <String>]`: Configures the groups claim issued in a user or OAuth 2.0 access token that the application expects. To set this attribute, use one of the following valid string values: None, SecurityGroup (for security groups and Microsoft Entra roles), All (this gets all of the security groups, distribution groups, and Microsoft Entra directory roles that the signed-in user is a member of).
  - `[HomeRealmDiscoveryPolicies <IMicrosoftGraphHomeRealmDiscoveryPolicy[]>]`: 
    - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[Definition <String[]>]`: A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.
    - `[IsOrganizationDefault <Boolean?>]`: If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.
    - `[Description <String>]`: Description for this policy. Required.
    - `[DisplayName <String>]`: Display name for this policy. Required.
    - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[IdentifierUris <String[]>]`: Also known as App ID URI, this value is set when an application is used as a resource app. The identifierUris acts as the prefix for the scopes you reference in your API's code, and it must be globally unique. You can use the default value provided, which is in the form api://<application-client-id>, or specify a more readable URI like https://contoso.com/api. For more information on valid identifierUris patterns and best practices, see Microsoft Entra application registration security best practices. Not nullable. Supports $filter (eq, ne, ge, le, startsWith).
  - `[Info <IMicrosoftGraphInformationalUrl>]`: informationalUrl
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[LogoUrl <String>]`: CDN URL to the application's logo, Read-only.
    - `[MarketingUrl <String>]`: Link to the application's marketing page. For example, https://www.contoso.com/app/marketing
    - `[PrivacyStatementUrl <String>]`: Link to the application's privacy statement. For example, https://www.contoso.com/app/privacy
    - `[SupportUrl <String>]`: Link to the application's support page. For example, https://www.contoso.com/app/support
    - `[TermsOfServiceUrl <String>]`: Link to the application's terms of service statement. For example, https://www.contoso.com/app/termsofservice
  - `[IsDeviceOnlyAuthSupported <Boolean?>]`: Specifies whether this application supports device authentication without a user. The default is false.
  - `[IsFallbackPublicClient <Boolean?>]`: Specifies the fallback application type as public client, such as an installed application running on a mobile device. The default value is false, which means the fallback application type is confidential client such as a web app. There are certain scenarios where Microsoft Entra ID can't determine the client application type. For example, the ROPC flow where it's configured without specifying a redirect URI. In those cases, Microsoft Entra ID interprets the application type based on the value of this property.
  - `[KeyCredentials <IMicrosoftGraphKeyCredential[]>]`: The collection of key credentials associated with the application. Not nullable. Supports $filter (eq, not, ge, le).
    - `[CustomKeyIdentifier <Byte[]>]`: A 40-character binary type that can be used to identify the credential. Optional. When not provided in the payload, defaults to the thumbprint of the certificate.
    - `[DisplayName <String>]`: Friendly name for the key. Optional.
    - `[EndDateTime <DateTime?>]`: The date and time at which the credential expires. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[Key <Byte[]>]`: The certificate's raw data in byte array converted to Base64 string. Returned only on $select for a single object, that is, GET applications/{applicationId}?$select=keyCredentials or GET servicePrincipals/{servicePrincipalId}?$select=keyCredentials; otherwise, it is always null.  From a .cer certificate, you can read the key using the Convert.ToBase64String() method. For more information, see Get the certificate key.
    - `[KeyId <String>]`: The unique identifier (GUID) for the key.
    - `[StartDateTime <DateTime?>]`: The date and time at which the credential becomes valid.The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[Type <String>]`: The type of key credential; for example, Symmetric, AsymmetricX509Cert.
    - `[Usage <String>]`: A string that describes the purpose for which the key can be used; for example, Verify.
  - `[Logo <Byte[]>]`: The main logo for the application. Not nullable.
  - `[Notes <String>]`: Notes relevant for the management of the application.
  - `[Oauth2RequirePostResponse <Boolean?>]`: 
  - `[OptionalClaims <IMicrosoftGraphOptionalClaims>]`: optionalClaims
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AccessToken <IMicrosoftGraphOptionalClaim[]>]`: The optional claims returned in the JWT access token.
      - `[AdditionalProperties <String[]>]`: Additional properties of the claim. If a property exists in this collection, it modifies the behavior of the optional claim specified in the name property.
      - `[Essential <Boolean?>]`: If the value is true, the claim specified by the client is necessary to ensure a smooth authorization experience for the specific task requested by the end user. The default value is false.
      - `[Name <String>]`: The name of the optional claim.
      - `[Source <String>]`: The source (directory object) of the claim. There are predefined claims and user-defined claims from extension properties. If the source value is null, the claim is a predefined optional claim. If the source value is user, the value in the name property is the extension property from the user object.
    - `[IdToken <IMicrosoftGraphOptionalClaim[]>]`: The optional claims returned in the JWT ID token.
    - `[Saml2Token <IMicrosoftGraphOptionalClaim[]>]`: The optional claims returned in the SAML token.
  - `[Owners <IMicrosoftGraphDirectoryObject[]>]`: Directory objects that are owners of the application. Read-only. Nullable. Supports $expand, $filter (/$count eq 0, /$count ne 0, /$count eq 1, /$count ne 1), and $select nested in $expand.
  - `[ParentalControlSettings <IMicrosoftGraphParentalControlSettings>]`: parentalControlSettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[CountriesBlockedForMinors <String[]>]`: Specifies the two-letter ISO country codes. Access to the application will be blocked for minors from the countries specified in this list.
    - `[LegalAgeGroupRule <String>]`: Specifies the legal age group rule that applies to users of the app. Can be set to one of the following values: ValueDescriptionAllowDefault. Enforces the legal minimum. This means parental consent is required for minors in the European Union and Korea.RequireConsentForPrivacyServicesEnforces the user to specify date of birth to comply with COPPA rules. RequireConsentForMinorsRequires parental consent for ages below 18, regardless of country minor rules.RequireConsentForKidsRequires parental consent for ages below 14, regardless of country minor rules.BlockMinorsBlocks minors from using the app.
  - `[PasswordCredentials <IMicrosoftGraphPasswordCredential[]>]`: The collection of password credentials associated with the application. Not nullable.
    - `[CustomKeyIdentifier <Byte[]>]`: Do not use.
    - `[DisplayName <String>]`: Friendly name for the password. Optional.
    - `[EndDateTime <DateTime?>]`: The date and time at which the password expires represented using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Optional.
    - `[Hint <String>]`: Contains the first three characters of the password. Read-only.
    - `[KeyId <String>]`: The unique identifier for the password.
    - `[SecretText <String>]`: Read-only; Contains the strong passwords generated by Microsoft Entra ID that are 16-64 characters in length. The generated password value is only returned during the initial POST request to addPassword. There is no way to retrieve this password in the future.
    - `[StartDateTime <DateTime?>]`: The date and time at which the password becomes valid. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Optional.
  - `[PublicClient <IMicrosoftGraphPublicClientApplication>]`: publicClientApplication
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[RedirectUris <String[]>]`: Specifies the URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent.
  - `[PublisherDomain <String>]`: The verified publisher domain for the application. Read-only. For more information, see How to: Configure an application's publisher domain. Supports $filter (eq, ne, ge, le, startsWith).
  - `[RequestSignatureVerification <IMicrosoftGraphRequestSignatureVerification>]`: requestSignatureVerification
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AllowedWeakAlgorithms <String>]`: weakAlgorithms
    - `[IsSignedRequestRequired <Boolean?>]`: Specifies whether signed authentication requests for this application should be required.
  - `[RequiredResourceAccess <IMicrosoftGraphRequiredResourceAccess[]>]`: Specifies the resources that the application needs to access. This property also specifies the set of delegated permissions and application roles that it needs for each of those resources. This configuration of access to the required resources drives the consent experience. No more than 50 resource services (APIs) can be configured. Beginning mid-October 2021, the total number of required permissions must not exceed 400. For more information, see Limits on requested permissions per app. Not nullable. Supports $filter (eq, not, ge, le).
    - `[ResourceAccess <IMicrosoftGraphResourceAccess[]>]`: The list of OAuth2.0 permission scopes and app roles that the application requires from the specified resource.
      - `[Id <String>]`: The unique identifier of an app role or delegated permission exposed by the resource application. For delegated permissions, this should match the id property of one of the delegated permissions in the oauth2PermissionScopes collection of the resource application's service principal. For app roles (application permissions), this should match the id property of an app role in the appRoles collection of the resource application's service principal.
      - `[Type <String>]`: Specifies whether the id property references a delegated permission or an app role (application permission). The possible values are: Scope (for delegated permissions) or Role (for app roles).
    - `[ResourceAppId <String>]`: The unique identifier for the resource that the application requires access to. This should be equal to the appId declared on the target resource application.
  - `[SamlMetadataUrl <String>]`: The URL where the service exposes SAML metadata for federation. This property is valid only for single-tenant applications. Nullable.
  - `[ServiceManagementReference <String>]`: References application or service contact information from a Service or Asset Management database. Nullable.
  - `[ServicePrincipalLockConfiguration <IMicrosoftGraphServicePrincipalLockConfiguration>]`: servicePrincipalLockConfiguration
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AllProperties <Boolean?>]`: Enables locking all sensitive properties. The sensitive properties are keyCredentials, passwordCredentials, and tokenEncryptionKeyId.
    - `[CredentialsWithUsageSign <Boolean?>]`: Locks the keyCredentials and passwordCredentials properties for modification where credential usage type is Sign.
    - `[CredentialsWithUsageVerify <Boolean?>]`: Locks the keyCredentials and passwordCredentials properties for modification where credential usage type is Verify. This locks OAuth service principals.
    - `[IsEnabled <Boolean?>]`: Enables or disables service principal lock configuration. To allow the sensitive properties to be updated, update this property to false to disable the lock on the service principal.
    - `[TokenEncryptionKeyId <Boolean?>]`: Locks the tokenEncryptionKeyId property for modification on the service principal.
  - `[SignInAudience <String>]`: Specifies the Microsoft accounts that are supported for the current application. The possible values are: AzureADMyOrg (default), AzureADMultipleOrgs, AzureADandPersonalMicrosoftAccount, and PersonalMicrosoftAccount. See more in the table. The value of this object also limits the number of permissions an app can request. For more information, see Limits on requested permissions per app. The value for this property has implications on other app object properties. As a result, if you change this property, you might need to change other properties first. For more information, see Validation differences for signInAudience.Supports $filter (eq, ne, not).
  - `[Spa <IMicrosoftGraphSpaApplication>]`: spaApplication
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[RedirectUris <String[]>]`: Specifies the URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent.
  - `[Synchronization <IMicrosoftGraphSynchronization>]`: synchronization
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Jobs <IMicrosoftGraphSynchronizationJob[]>]`: Performs synchronization by periodically running in the background, polling for changes in one directory, and pushing them to another directory.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[BulkUpload <IMicrosoftGraphBulkUpload>]`: bulkUpload
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Schedule <IMicrosoftGraphSynchronizationSchedule>]`: synchronizationSchedule
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Expiration <DateTime?>]`: Date and time when this job expires. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[Interval <TimeSpan?>]`: The interval between synchronization iterations. The value is represented in ISO 8601 format for durations. For example, PT1M represents a period of one month.
        - `[State <String>]`: synchronizationScheduleState
      - `[Schema <IMicrosoftGraphSynchronizationSchema>]`: synchronizationSchema
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
        - `[Directories <IMicrosoftGraphDirectoryDefinition[]>]`: Contains the collection of directories and all of their objects.
          - `[Id <String>]`: The unique identifier for an entity. Read-only.
          - `[Discoverabilities <String>]`: directoryDefinitionDiscoverabilities
          - `[DiscoveryDateTime <DateTime?>]`: Represents the discovery date and time using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
          - `[Name <String>]`: Name of the directory. Must be unique within the synchronization schema. Not nullable.
          - `[Objects <IMicrosoftGraphObjectDefinition[]>]`: Collection of objects supported by the directory.
            - `[Attributes <IMicrosoftGraphAttributeDefinition[]>]`: Defines attributes of the object.
              - `[Anchor <Boolean?>]`: true if the attribute should be used as the anchor for the object. Anchor attributes must have a unique value identifying an object, and must be immutable. Default is false. One, and only one, of the object's attributes must be designated as the anchor to support synchronization.
              - `[ApiExpressions <IMicrosoftGraphStringKeyStringValuePair[]>]`: 
                - `[Key <String>]`: Key.
                - `[Value <String>]`: Value.
              - `[CaseExact <Boolean?>]`: true if value of this attribute should be treated as case-sensitive. This setting affects how the synchronization engine detects changes for the attribute.
              - `[DefaultValue <String>]`: 
              - `[FlowNullValues <Boolean?>]`: 'true' to allow null values for attributes.
              - `[Metadata <IMicrosoftGraphAttributeDefinitionMetadataEntry[]>]`: Metadata for the given object.
                - `[Key <String>]`: attributeDefinitionMetadata
                - `[Value <String>]`: Value of the metadata property.
              - `[Multivalued <Boolean?>]`: true if an attribute can have multiple values. Default is false.
              - `[Mutability <String>]`: mutability
              - `[Name <String>]`: Name of the attribute. Must be unique within the object definition. Not nullable.
              - `[ReferencedObjects <IMicrosoftGraphReferencedObject[]>]`: For attributes with reference type, lists referenced objects (for example, the manager attribute would list User as the referenced object).
                - `[ReferencedObjectName <String>]`: Name of the referenced object. Must match one of the objects in the directory definition.
                - `[ReferencedProperty <String>]`: Currently not supported. Name of the property in the referenced object, the value for which is used as the reference.
              - `[Required <Boolean?>]`: true if attribute is required. Object can not be created if any of the required attributes are missing. If during synchronization, the required attribute has no value, the default value will be used. If default the value was not set, synchronization will record an error.
              - `[Type <String>]`: attributeType
            - `[Metadata <IMicrosoftGraphObjectDefinitionMetadataEntry[]>]`: Metadata for the given object.
              - `[Key <String>]`: objectDefinitionMetadata
              - `[Value <String>]`: Value of the metadata property.
            - `[Name <String>]`: Name of the object. Must be unique within a directory definition. Not nullable.
            - `[SupportedApis <String[]>]`: The API that the provisioning service queries to retrieve data for synchronization.
          - `[ReadOnly <Boolean?>]`: Whether this object is read-only.
          - `[Version <String>]`: Read only value that indicates version discovered. null if discovery hasn't yet occurred.
        - `[SynchronizationRules <IMicrosoftGraphSynchronizationRule[]>]`: A collection of synchronization rules configured for the synchronizationJob or synchronizationTemplate.
          - `[ContainerFilter <IMicrosoftGraphContainerFilter>]`: containerFilter
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[IncludedContainers <String[]>]`: 
          - `[Editable <Boolean?>]`: true if the synchronization rule can be customized; false if this rule is read-only and shouldn't be changed.
          - `[GroupFilter <IMicrosoftGraphGroupFilter>]`: groupFilter
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[IncludedGroups <String[]>]`: 
          - `[Id <String>]`: Synchronization rule identifier. Must be one of the identifiers recognized by the synchronization engine. Supported rule identifiers can be found in the synchronization template returned by the API.
          - `[Metadata <IMicrosoftGraphStringKeyStringValuePair[]>]`: Additional extension properties. Unless instructed explicitly by the support team, metadata values shouldn't be changed.
          - `[Name <String>]`: Human-readable name of the synchronization rule. Not nullable.
          - `[ObjectMappings <IMicrosoftGraphObjectMapping[]>]`: Collection of object mappings supported by the rule. Tells the synchronization engine which objects should be synchronized.
            - `[AttributeMappings <IMicrosoftGraphAttributeMapping[]>]`: Attribute mappings define which attributes to map from the source object into the target object and how they should flow. A number of functions are available to support the transformation of the original source values.
              - `[DefaultValue <String>]`: Default value to be used in case the source property was evaluated to null. Optional.
              - `[ExportMissingReferences <Boolean?>]`: For internal use only.
              - `[FlowBehavior <String>]`: attributeFlowBehavior
              - `[FlowType <String>]`: attributeFlowType
              - `[MatchingPriority <Int32?>]`: If higher than 0, this attribute will be used to perform an initial match of the objects between source and target directories. The synchronization engine will try to find the matching object using attribute with lowest value of matching priority first. If not found, the attribute with the next matching priority will be used, and so on a until match is found or no more matching attributes are left. Only attributes that are expected to have unique values, such as email, should be used as matching attributes.
              - `[Source <IMicrosoftGraphAttributeMappingSource>]`: attributeMappingSource
                - `[(Any) <Object>]`: This indicates any property can be added to this object.
                - `[Expression <String>]`: Equivalent expression representation of this attributeMappingSource object.
                - `[Name <String>]`: Name parameter of the mapping source. Depending on the type property value, this can be the name of the function, the name of the source attribute, or a constant value to be used.
                - `[Parameters <IMicrosoftGraphStringKeyAttributeMappingSourceValuePair[]>]`: If this object represents a function, lists function parameters. Parameters consist of attributeMappingSource objects themselves, allowing for complex expressions. If type isn't Function, this property is null/empty array.
                  - `[Key <String>]`: The name of the parameter.
                  - `[Value <IMicrosoftGraphAttributeMappingSource>]`: attributeMappingSource
                - `[Type <String>]`: attributeMappingSourceType
              - `[TargetAttributeName <String>]`: Name of the attribute on the target object.
            - `[Enabled <Boolean?>]`: When true, this object mapping will be processed during synchronization. When false, this object mapping will be skipped.
            - `[FlowTypes <String>]`: objectFlowTypes
            - `[Metadata <IMicrosoftGraphObjectMappingMetadataEntry[]>]`: Additional extension properties. Unless mentioned explicitly, metadata values should not be changed.
              - `[Key <String>]`: objectMappingMetadata
              - `[Value <String>]`: Value of the metadata property.
            - `[Name <String>]`: Human-friendly name of the object mapping.
            - `[Scope <IMicrosoftGraphFilter>]`: filter
              - `[(Any) <Object>]`: This indicates any property can be added to this object.
              - `[CategoryFilterGroups <IMicrosoftGraphFilterGroup[]>]`: *Experimental* Filter group set used to decide whether given object belongs and should be processed as part of this object mapping. An object is considered in scope if ANY of the groups in the collection is evaluated to true.
                - `[Clauses <IMicrosoftGraphFilterClause[]>]`: Filter clauses (conditions) of this group. All clauses in a group must be satisfied in order for the filter group to evaluate to true.
                  - `[OperatorName <String>]`: Name of the operator to be applied to the source and target operands. Must be one of the supported operators. Supported operators can be discovered.
                  - `[SourceOperandName <String>]`: Name of source operand (the operand being tested). The source operand name must match one of the attribute names on the source object.
                  - `[TargetOperand <IMicrosoftGraphFilterOperand>]`: filterOperand
                    - `[(Any) <Object>]`: This indicates any property can be added to this object.
                    - `[Values <String[]>]`: Collection of values.
                - `[Name <String>]`: Human-readable name of the filter group.
              - `[Groups <IMicrosoftGraphFilterGroup[]>]`: Filter group set used to decide whether given object is in scope for provisioning. This is the filter which should be used in most cases. If an object used to satisfy this filter at a given moment, and then the object or the filter was changed so that filter isn't satisfied any longer, such object will get deprovisioned'. An object is considered in scope if ANY of the groups in the collection is evaluated to true.
              - `[InputFilterGroups <IMicrosoftGraphFilterGroup[]>]`: *Experimental* Filter group set used to filter out objects at the early stage of reading them from the directory. If an object doesn't satisfy this filter, then it will not be processed further. Important to understand is that if an object used to satisfy this filter at a given moment, and then the object or the filter was changed so that filter is no longer satisfied, such object will NOT get deprovisioned. An object is considered in scope if ANY of the groups in the collection is evaluated to true.
            - `[SourceObjectName <String>]`: Name of the object in the source directory. Must match the object name from the source directory definition.
            - `[TargetObjectName <String>]`: Name of the object in target directory. Must match the object name from the target directory definition.
          - `[Priority <Int32?>]`: Priority relative to other rules in the synchronizationSchema. Rules with the lowest priority number will be processed first.
          - `[SourceDirectoryName <String>]`: Name of the source directory. Must match one of the directory definitions in synchronizationSchema.
          - `[TargetDirectoryName <String>]`: Name of the target directory. Must match one of the directory definitions in synchronizationSchema.
        - `[Version <String>]`: The version of the schema, updated automatically with every schema change.
      - `[Status <IMicrosoftGraphSynchronizationStatus>]`: synchronizationStatus
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Code <String>]`: synchronizationStatusCode
        - `[CountSuccessiveCompleteFailures <Int64?>]`: Number of consecutive times this job failed.
        - `[EscrowsPruned <Boolean?>]`: true if the job's escrows (object-level errors) were pruned during initial synchronization. Escrows can be pruned if during the initial synchronization, you reach the threshold of errors that would normally put the job in quarantine. Instead of going into quarantine, the synchronization process clears the job's errors and continues until the initial synchronization is completed. When the initial synchronization is completed, the job will pause and wait for the customer to clean up the errors.
        - `[LastExecution <IMicrosoftGraphSynchronizationTaskExecution>]`: synchronizationTaskExecution
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[ActivityIdentifier <String>]`: Identifier of the job run.
          - `[CountEntitled <Int64?>]`: Count of processed entries that were assigned for this application.
          - `[CountEntitledForProvisioning <Int64?>]`: Count of processed entries that were assigned for provisioning.
          - `[CountEscrowed <Int64?>]`: Count of entries that were escrowed (errors).
          - `[CountEscrowedRaw <Int64?>]`: Count of entries that were escrowed, including system-generated escrows.
          - `[CountExported <Int64?>]`: Count of exported entries.
          - `[CountExports <Int64?>]`: Count of entries that were expected to be exported.
          - `[CountImported <Int64?>]`: Count of imported entries.
          - `[CountImportedDeltas <Int64?>]`: Count of imported delta-changes.
          - `[CountImportedReferenceDeltas <Int64?>]`: Count of imported delta-changes pertaining to reference changes.
          - `[Error <IMicrosoftGraphSynchronizationError>]`: synchronizationError
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[Code <String>]`: The error code. For example, AzureDirectoryB2BManagementPolicyCheckFailure.
            - `[Message <String>]`: The error message. For example, Policy permitting auto-redemption of invitations not configured.
            - `[TenantActionable <Boolean?>]`: The action to take to resolve the error. For example, false.
          - `[State <String>]`: synchronizationTaskExecutionResult
          - `[TimeBegan <DateTime?>]`: Time when this job run began. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
          - `[TimeEnded <DateTime?>]`: Time when this job run ended. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[LastSuccessfulExecution <IMicrosoftGraphSynchronizationTaskExecution>]`: synchronizationTaskExecution
        - `[LastSuccessfulExecutionWithExports <IMicrosoftGraphSynchronizationTaskExecution>]`: synchronizationTaskExecution
        - `[Progress <IMicrosoftGraphSynchronizationProgress[]>]`: Details of the progress of a job toward completion.
          - `[CompletedUnits <Int64?>]`: The numerator of a progress ratio; the number of units of changes already processed.
          - `[ProgressObservationDateTime <DateTime?>]`: The time of a progress observation as an offset in minutes from UTC.
          - `[TotalUnits <Int64?>]`: The denominator of a progress ratio; a number of units of changes to be processed to accomplish synchronization.
          - `[Units <String>]`: An optional description of the units.
        - `[Quarantine <IMicrosoftGraphSynchronizationQuarantine>]`: synchronizationQuarantine
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[CurrentBegan <DateTime?>]`: Date and time when the quarantine was last evaluated and imposed. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
          - `[Error <IMicrosoftGraphSynchronizationError>]`: synchronizationError
          - `[NextAttempt <DateTime?>]`: Date and time when the next attempt to re-evaluate the quarantine will be made. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
          - `[Reason <String>]`: quarantineReason
          - `[SeriesBegan <DateTime?>]`: Date and time when the quarantine was first imposed in this series (a series starts when a quarantine is first imposed, and is reset as soon as the quarantine is lifted). The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
          - `[SeriesCount <Int64?>]`: Number of times in this series the quarantine was re-evaluated and left in effect (a series starts when quarantine is first imposed, and is reset as soon as quarantine is lifted).
        - `[SteadyStateFirstAchievedTime <DateTime?>]`: The time when steady state (no more changes to the process) was first achieved. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[SteadyStateLastAchievedTime <DateTime?>]`: The time when steady state (no more changes to the process) was last achieved. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[SynchronizedEntryCountByType <IMicrosoftGraphStringKeyLongValuePair[]>]`: Count of synchronized objects, listed by object type.
          - `[Key <String>]`: The mapping of the user type from the source system to the target system. For example:User to User - For Microsoft Entra ID to Microsoft Entra ID synchronization worker to user - For Workday to Microsoft Entra synchronization.
          - `[Value <Int64?>]`: Total number of synchronized objects.
        - `[TroubleshootingUrl <String>]`: In the event of an error, the URL with the troubleshooting steps for the issue.
      - `[SynchronizationJobSettings <IMicrosoftGraphKeyValuePair[]>]`: Settings associated with the job. Some settings are inherited from the template.
        - `[Name <String>]`: Name for this key-value pair
        - `[Value <String>]`: Value for this key-value pair
      - `[TemplateId <String>]`: Identifier of the synchronization template this job is based on.
    - `[Secrets <IMicrosoftGraphSynchronizationSecretKeyStringValuePair[]>]`: Represents a collection of credentials to access provisioned cloud applications.
      - `[Key <String>]`: synchronizationSecret
      - `[Value <String>]`: The value of the secret.
    - `[Templates <IMicrosoftGraphSynchronizationTemplate[]>]`: Preconfigured synchronization settings for a particular application.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[ApplicationId <String>]`: Identifier of the application this template belongs to.
      - `[Default <Boolean?>]`: true if this template is recommended to be the default for the application.
      - `[Description <String>]`: Description of the template.
      - `[Discoverable <Boolean?>]`: true if this template should appear in the collection of templates available for the application instance (service principal).
      - `[FactoryTag <String>]`: One of the well-known factory tags supported by the synchronization engine. The factoryTag tells the synchronization engine which implementation to use when processing jobs based on this template.
      - `[Metadata <IMicrosoftGraphSynchronizationMetadataEntry[]>]`: Additional extension properties. Unless mentioned explicitly, metadata values should not be changed.
        - `[Key <String>]`: synchronizationMetadata
        - `[Value <String>]`: Value of the metadata property.
      - `[Schema <IMicrosoftGraphSynchronizationSchema>]`: synchronizationSchema
  - `[Tags <String[]>]`: Custom strings that can be used to categorize and identify the application. Not nullable. Strings added here will also appear in the tags property of any associated service principals.Supports $filter (eq, not, ge, le, startsWith) and $search.
  - `[TokenEncryptionKeyId <String>]`: Specifies the keyId of a public key from the keyCredentials collection. When configured, Microsoft Entra ID encrypts all the tokens it emits by using the key this property points to. The application code that receives the encrypted token must use the matching private key to decrypt the token before it can be used for the signed-in user.
  - `[TokenIssuancePolicies <IMicrosoftGraphTokenIssuancePolicy[]>]`: 
    - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[Definition <String[]>]`: A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.
    - `[IsOrganizationDefault <Boolean?>]`: If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.
    - `[Description <String>]`: Description for this policy. Required.
    - `[DisplayName <String>]`: Display name for this policy. Required.
    - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[TokenLifetimePolicies <IMicrosoftGraphTokenLifetimePolicy[]>]`: 
    - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[Definition <String[]>]`: A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.
    - `[IsOrganizationDefault <Boolean?>]`: If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.
    - `[Description <String>]`: Description for this policy. Required.
    - `[DisplayName <String>]`: Display name for this policy. Required.
    - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[UniqueName <String>]`: 
  - `[VerifiedPublisher <IMicrosoftGraphVerifiedPublisher>]`: verifiedPublisher
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AddedDateTime <DateTime?>]`: The timestamp when the verified publisher was first added or most recently updated.
    - `[DisplayName <String>]`: The verified publisher name from the app publisher's Partner Center account.
    - `[VerifiedPublisherId <String>]`: The ID of the verified publisher from the app publisher's Partner Center account.
  - `[Web <IMicrosoftGraphWebApplication>]`: webApplication
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[HomePageUrl <String>]`: Home page or landing page of the application.
    - `[ImplicitGrantSettings <IMicrosoftGraphImplicitGrantSettings>]`: implicitGrantSettings
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[EnableAccessTokenIssuance <Boolean?>]`: Specifies whether this web application can request an access token using the OAuth 2.0 implicit flow.
      - `[EnableIdTokenIssuance <Boolean?>]`: Specifies whether this web application can request an ID token using the OAuth 2.0 implicit flow.
    - `[LogoutUrl <String>]`: Specifies the URL that is used by Microsoft's authorization service to log out a user using front-channel, back-channel or SAML logout protocols.
    - `[RedirectUriSettings <IMicrosoftGraphRedirectUriSettings[]>]`: 
      - `[Index <Int32?>]`: 
      - `[Uri <String>]`: 
    - `[RedirectUris <String[]>]`: Specifies the URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent.

`CERTIFICATION <IMicrosoftGraphCertification>`: certification
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CertificationExpirationDateTime <DateTime?>]`: The timestamp when the current certification for the application expires.
  - `[IsPublisherAttested <Boolean?>]`: Indicates whether the application has been self-attested by the application developer or the publisher.
  - `[LastCertificationDateTime <DateTime?>]`: The timestamp when the certification for the application was most recently added or updated.

`CREATEDONBEHALFOF <IMicrosoftGraphDirectoryObject>`: directoryObject
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.

`EXTENSIONPROPERTIES <IMicrosoftGraphExtensionProperty[]>`: Read-only. Nullable. Supports $expand and $filter (/$count eq 0, /$count ne 0).
  - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AppDisplayName <String>]`: Display name of the application object on which this extension property is defined. Read-only.
  - `[DataType <String>]`: Specifies the data type of the value the extension property can hold. Following values are supported. Binary - 256 bytes maximumBooleanDateTime - Must be specified in ISO 8601 format. Will be stored in UTC.Integer - 32-bit value.LargeInteger - 64-bit value.String - 256 characters maximumNot nullable. For multivalued directory extensions, these limits apply per value in the collection.
  - `[IsMultiValued <Boolean?>]`: Defines the directory extension as a multi-valued property. When true, the directory extension property can store a collection of objects of the dataType; for example, a collection of string types such as 'extensionb7b1c57b532f40b8b5ed4b7a7ba67401jobGroupTracker': ['String 1', 'String 2']. The default value is false. Supports $filter (eq).
  - `[IsSyncedFromOnPremises <Boolean?>]`: Indicates if this extension property was synced from on-premises active directory using Microsoft Entra Connect. Read-only.
  - `[Name <String>]`: Name of the extension property. Not nullable. Supports $filter (eq).
  - `[TargetObjects <String[]>]`: Following values are supported. Not nullable. UserGroupAdministrativeUnitApplicationDeviceOrganization

`FEDERATEDIDENTITYCREDENTIALS <IMicrosoftGraphFederatedIdentityCredential[]>`: Federated identities for applications. Supports $expand and $filter (startsWith, /$count eq 0, /$count ne 0).
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Audiences <String[]>]`: The audience that can appear in the external token. This field is mandatory and should be set to api://AzureADTokenExchange for Microsoft Entra ID. It says what Microsoft identity platform should accept in the aud claim in the incoming token. This value represents Microsoft Entra ID in your external identity provider and has no fixed value across identity providers - you might need to create a new application registration in your identity provider to serve as the audience of this token. This field can only accept a single value and has a limit of 600 characters. Required.
  - `[Description <String>]`: The unvalidated description of the federated identity credential, provided by the user. It has a limit of 600 characters. Optional.
  - `[Issuer <String>]`: The URL of the external identity provider, which must match the issuer claim of the external token being exchanged. The combination of the values of issuer and subject must be unique within the app. It has a limit of 600 characters. Required.
  - `[Name <String>]`: The unique identifier for the federated identity credential, which has a limit of 120 characters and must be URL friendly. The string is immutable after it's created. Required. Not nullable. Supports $filter (eq).
  - `[Subject <String>]`: Required. The identifier of the external software workload within the external identity provider. Like the audience value, it has no fixed format; each identity provider uses their own - sometimes a GUID, sometimes a colon delimited identifier, sometimes arbitrary strings. The value here must match the sub claim within the token presented to Microsoft Entra ID. The combination of issuer and subject must be unique within the app. It has a limit of 600 characters. Supports $filter (eq).

`HOMEREALMDISCOVERYPOLICIES <IMicrosoftGraphHomeRealmDiscoveryPolicy[]>`: .
  - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
  - `[Definition <String[]>]`: A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.
  - `[IsOrganizationDefault <Boolean?>]`: If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.
  - `[Description <String>]`: Description for this policy. Required.
  - `[DisplayName <String>]`: Display name for this policy. Required.
  - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.

`INFO <IMicrosoftGraphInformationalUrl>`: informationalUrl
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[LogoUrl <String>]`: CDN URL to the application's logo, Read-only.
  - `[MarketingUrl <String>]`: Link to the application's marketing page. For example, https://www.contoso.com/app/marketing
  - `[PrivacyStatementUrl <String>]`: Link to the application's privacy statement. For example, https://www.contoso.com/app/privacy
  - `[SupportUrl <String>]`: Link to the application's support page. For example, https://www.contoso.com/app/support
  - `[TermsOfServiceUrl <String>]`: Link to the application's terms of service statement. For example, https://www.contoso.com/app/termsofservice

`KEYCREDENTIALS <IMicrosoftGraphKeyCredential[]>`: The collection of key credentials associated with the application. Not nullable. Supports $filter (eq, not, ge, le).
  - `[CustomKeyIdentifier <Byte[]>]`: A 40-character binary type that can be used to identify the credential. Optional. When not provided in the payload, defaults to the thumbprint of the certificate.
  - `[DisplayName <String>]`: Friendly name for the key. Optional.
  - `[EndDateTime <DateTime?>]`: The date and time at which the credential expires. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[Key <Byte[]>]`: The certificate's raw data in byte array converted to Base64 string. Returned only on $select for a single object, that is, GET applications/{applicationId}?$select=keyCredentials or GET servicePrincipals/{servicePrincipalId}?$select=keyCredentials; otherwise, it is always null.  From a .cer certificate, you can read the key using the Convert.ToBase64String() method. For more information, see Get the certificate key.
  - `[KeyId <String>]`: The unique identifier (GUID) for the key.
  - `[StartDateTime <DateTime?>]`: The date and time at which the credential becomes valid.The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[Type <String>]`: The type of key credential; for example, Symmetric, AsymmetricX509Cert.
  - `[Usage <String>]`: A string that describes the purpose for which the key can be used; for example, Verify.

`OPTIONALCLAIMS <IMicrosoftGraphOptionalClaims>`: optionalClaims
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AccessToken <IMicrosoftGraphOptionalClaim[]>]`: The optional claims returned in the JWT access token.
    - `[AdditionalProperties <String[]>]`: Additional properties of the claim. If a property exists in this collection, it modifies the behavior of the optional claim specified in the name property.
    - `[Essential <Boolean?>]`: If the value is true, the claim specified by the client is necessary to ensure a smooth authorization experience for the specific task requested by the end user. The default value is false.
    - `[Name <String>]`: The name of the optional claim.
    - `[Source <String>]`: The source (directory object) of the claim. There are predefined claims and user-defined claims from extension properties. If the source value is null, the claim is a predefined optional claim. If the source value is user, the value in the name property is the extension property from the user object.
  - `[IdToken <IMicrosoftGraphOptionalClaim[]>]`: The optional claims returned in the JWT ID token.
  - `[Saml2Token <IMicrosoftGraphOptionalClaim[]>]`: The optional claims returned in the SAML token.

`OWNERS <IMicrosoftGraphDirectoryObject[]>`: Directory objects that are owners of the application. Read-only. Nullable. Supports $expand, $filter (/$count eq 0, /$count ne 0, /$count eq 1, /$count ne 1), and $select nested in $expand.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.

`PARENTALCONTROLSETTINGS <IMicrosoftGraphParentalControlSettings>`: parentalControlSettings
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CountriesBlockedForMinors <String[]>]`: Specifies the two-letter ISO country codes. Access to the application will be blocked for minors from the countries specified in this list.
  - `[LegalAgeGroupRule <String>]`: Specifies the legal age group rule that applies to users of the app. Can be set to one of the following values: ValueDescriptionAllowDefault. Enforces the legal minimum. This means parental consent is required for minors in the European Union and Korea.RequireConsentForPrivacyServicesEnforces the user to specify date of birth to comply with COPPA rules. RequireConsentForMinorsRequires parental consent for ages below 18, regardless of country minor rules.RequireConsentForKidsRequires parental consent for ages below 14, regardless of country minor rules.BlockMinorsBlocks minors from using the app.

`PASSWORDCREDENTIALS <IMicrosoftGraphPasswordCredential[]>`: The collection of password credentials associated with the application. Not nullable.
  - `[CustomKeyIdentifier <Byte[]>]`: Do not use.
  - `[DisplayName <String>]`: Friendly name for the password. Optional.
  - `[EndDateTime <DateTime?>]`: The date and time at which the password expires represented using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Optional.
  - `[Hint <String>]`: Contains the first three characters of the password. Read-only.
  - `[KeyId <String>]`: The unique identifier for the password.
  - `[SecretText <String>]`: Read-only; Contains the strong passwords generated by Microsoft Entra ID that are 16-64 characters in length. The generated password value is only returned during the initial POST request to addPassword. There is no way to retrieve this password in the future.
  - `[StartDateTime <DateTime?>]`: The date and time at which the password becomes valid. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Optional.

`PUBLICCLIENT <IMicrosoftGraphPublicClientApplication>`: publicClientApplication
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[RedirectUris <String[]>]`: Specifies the URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent.

`REQUESTSIGNATUREVERIFICATION <IMicrosoftGraphRequestSignatureVerification>`: requestSignatureVerification
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AllowedWeakAlgorithms <String>]`: weakAlgorithms
  - `[IsSignedRequestRequired <Boolean?>]`: Specifies whether signed authentication requests for this application should be required.

`REQUIREDRESOURCEACCESS <IMicrosoftGraphRequiredResourceAccess[]>`: Specifies the resources that the application needs to access. This property also specifies the set of delegated permissions and application roles that it needs for each of those resources. This configuration of access to the required resources drives the consent experience. No more than 50 resource services (APIs) can be configured. Beginning mid-October 2021, the total number of required permissions must not exceed 400. For more information, see Limits on requested permissions per app. Not nullable. Supports $filter (eq, not, ge, le).
  - `[ResourceAccess <IMicrosoftGraphResourceAccess[]>]`: The list of OAuth2.0 permission scopes and app roles that the application requires from the specified resource.
    - `[Id <String>]`: The unique identifier of an app role or delegated permission exposed by the resource application. For delegated permissions, this should match the id property of one of the delegated permissions in the oauth2PermissionScopes collection of the resource application's service principal. For app roles (application permissions), this should match the id property of an app role in the appRoles collection of the resource application's service principal.
    - `[Type <String>]`: Specifies whether the id property references a delegated permission or an app role (application permission). The possible values are: Scope (for delegated permissions) or Role (for app roles).
  - `[ResourceAppId <String>]`: The unique identifier for the resource that the application requires access to. This should be equal to the appId declared on the target resource application.

`SERVICEPRINCIPALLOCKCONFIGURATION <IMicrosoftGraphServicePrincipalLockConfiguration>`: servicePrincipalLockConfiguration
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AllProperties <Boolean?>]`: Enables locking all sensitive properties. The sensitive properties are keyCredentials, passwordCredentials, and tokenEncryptionKeyId.
  - `[CredentialsWithUsageSign <Boolean?>]`: Locks the keyCredentials and passwordCredentials properties for modification where credential usage type is Sign.
  - `[CredentialsWithUsageVerify <Boolean?>]`: Locks the keyCredentials and passwordCredentials properties for modification where credential usage type is Verify. This locks OAuth service principals.
  - `[IsEnabled <Boolean?>]`: Enables or disables service principal lock configuration. To allow the sensitive properties to be updated, update this property to false to disable the lock on the service principal.
  - `[TokenEncryptionKeyId <Boolean?>]`: Locks the tokenEncryptionKeyId property for modification on the service principal.

`SPA <IMicrosoftGraphSpaApplication>`: spaApplication
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[RedirectUris <String[]>]`: Specifies the URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent.

`SYNCHRONIZATION <IMicrosoftGraphSynchronization>`: synchronization
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Jobs <IMicrosoftGraphSynchronizationJob[]>]`: Performs synchronization by periodically running in the background, polling for changes in one directory, and pushing them to another directory.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[BulkUpload <IMicrosoftGraphBulkUpload>]`: bulkUpload
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Schedule <IMicrosoftGraphSynchronizationSchedule>]`: synchronizationSchedule
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Expiration <DateTime?>]`: Date and time when this job expires. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[Interval <TimeSpan?>]`: The interval between synchronization iterations. The value is represented in ISO 8601 format for durations. For example, PT1M represents a period of one month.
      - `[State <String>]`: synchronizationScheduleState
    - `[Schema <IMicrosoftGraphSynchronizationSchema>]`: synchronizationSchema
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Directories <IMicrosoftGraphDirectoryDefinition[]>]`: Contains the collection of directories and all of their objects.
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
        - `[Discoverabilities <String>]`: directoryDefinitionDiscoverabilities
        - `[DiscoveryDateTime <DateTime?>]`: Represents the discovery date and time using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[Name <String>]`: Name of the directory. Must be unique within the synchronization schema. Not nullable.
        - `[Objects <IMicrosoftGraphObjectDefinition[]>]`: Collection of objects supported by the directory.
          - `[Attributes <IMicrosoftGraphAttributeDefinition[]>]`: Defines attributes of the object.
            - `[Anchor <Boolean?>]`: true if the attribute should be used as the anchor for the object. Anchor attributes must have a unique value identifying an object, and must be immutable. Default is false. One, and only one, of the object's attributes must be designated as the anchor to support synchronization.
            - `[ApiExpressions <IMicrosoftGraphStringKeyStringValuePair[]>]`: 
              - `[Key <String>]`: Key.
              - `[Value <String>]`: Value.
            - `[CaseExact <Boolean?>]`: true if value of this attribute should be treated as case-sensitive. This setting affects how the synchronization engine detects changes for the attribute.
            - `[DefaultValue <String>]`: 
            - `[FlowNullValues <Boolean?>]`: 'true' to allow null values for attributes.
            - `[Metadata <IMicrosoftGraphAttributeDefinitionMetadataEntry[]>]`: Metadata for the given object.
              - `[Key <String>]`: attributeDefinitionMetadata
              - `[Value <String>]`: Value of the metadata property.
            - `[Multivalued <Boolean?>]`: true if an attribute can have multiple values. Default is false.
            - `[Mutability <String>]`: mutability
            - `[Name <String>]`: Name of the attribute. Must be unique within the object definition. Not nullable.
            - `[ReferencedObjects <IMicrosoftGraphReferencedObject[]>]`: For attributes with reference type, lists referenced objects (for example, the manager attribute would list User as the referenced object).
              - `[ReferencedObjectName <String>]`: Name of the referenced object. Must match one of the objects in the directory definition.
              - `[ReferencedProperty <String>]`: Currently not supported. Name of the property in the referenced object, the value for which is used as the reference.
            - `[Required <Boolean?>]`: true if attribute is required. Object can not be created if any of the required attributes are missing. If during synchronization, the required attribute has no value, the default value will be used. If default the value was not set, synchronization will record an error.
            - `[Type <String>]`: attributeType
          - `[Metadata <IMicrosoftGraphObjectDefinitionMetadataEntry[]>]`: Metadata for the given object.
            - `[Key <String>]`: objectDefinitionMetadata
            - `[Value <String>]`: Value of the metadata property.
          - `[Name <String>]`: Name of the object. Must be unique within a directory definition. Not nullable.
          - `[SupportedApis <String[]>]`: The API that the provisioning service queries to retrieve data for synchronization.
        - `[ReadOnly <Boolean?>]`: Whether this object is read-only.
        - `[Version <String>]`: Read only value that indicates version discovered. null if discovery hasn't yet occurred.
      - `[SynchronizationRules <IMicrosoftGraphSynchronizationRule[]>]`: A collection of synchronization rules configured for the synchronizationJob or synchronizationTemplate.
        - `[ContainerFilter <IMicrosoftGraphContainerFilter>]`: containerFilter
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[IncludedContainers <String[]>]`: 
        - `[Editable <Boolean?>]`: true if the synchronization rule can be customized; false if this rule is read-only and shouldn't be changed.
        - `[GroupFilter <IMicrosoftGraphGroupFilter>]`: groupFilter
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[IncludedGroups <String[]>]`: 
        - `[Id <String>]`: Synchronization rule identifier. Must be one of the identifiers recognized by the synchronization engine. Supported rule identifiers can be found in the synchronization template returned by the API.
        - `[Metadata <IMicrosoftGraphStringKeyStringValuePair[]>]`: Additional extension properties. Unless instructed explicitly by the support team, metadata values shouldn't be changed.
        - `[Name <String>]`: Human-readable name of the synchronization rule. Not nullable.
        - `[ObjectMappings <IMicrosoftGraphObjectMapping[]>]`: Collection of object mappings supported by the rule. Tells the synchronization engine which objects should be synchronized.
          - `[AttributeMappings <IMicrosoftGraphAttributeMapping[]>]`: Attribute mappings define which attributes to map from the source object into the target object and how they should flow. A number of functions are available to support the transformation of the original source values.
            - `[DefaultValue <String>]`: Default value to be used in case the source property was evaluated to null. Optional.
            - `[ExportMissingReferences <Boolean?>]`: For internal use only.
            - `[FlowBehavior <String>]`: attributeFlowBehavior
            - `[FlowType <String>]`: attributeFlowType
            - `[MatchingPriority <Int32?>]`: If higher than 0, this attribute will be used to perform an initial match of the objects between source and target directories. The synchronization engine will try to find the matching object using attribute with lowest value of matching priority first. If not found, the attribute with the next matching priority will be used, and so on a until match is found or no more matching attributes are left. Only attributes that are expected to have unique values, such as email, should be used as matching attributes.
            - `[Source <IMicrosoftGraphAttributeMappingSource>]`: attributeMappingSource
              - `[(Any) <Object>]`: This indicates any property can be added to this object.
              - `[Expression <String>]`: Equivalent expression representation of this attributeMappingSource object.
              - `[Name <String>]`: Name parameter of the mapping source. Depending on the type property value, this can be the name of the function, the name of the source attribute, or a constant value to be used.
              - `[Parameters <IMicrosoftGraphStringKeyAttributeMappingSourceValuePair[]>]`: If this object represents a function, lists function parameters. Parameters consist of attributeMappingSource objects themselves, allowing for complex expressions. If type isn't Function, this property is null/empty array.
                - `[Key <String>]`: The name of the parameter.
                - `[Value <IMicrosoftGraphAttributeMappingSource>]`: attributeMappingSource
              - `[Type <String>]`: attributeMappingSourceType
            - `[TargetAttributeName <String>]`: Name of the attribute on the target object.
          - `[Enabled <Boolean?>]`: When true, this object mapping will be processed during synchronization. When false, this object mapping will be skipped.
          - `[FlowTypes <String>]`: objectFlowTypes
          - `[Metadata <IMicrosoftGraphObjectMappingMetadataEntry[]>]`: Additional extension properties. Unless mentioned explicitly, metadata values should not be changed.
            - `[Key <String>]`: objectMappingMetadata
            - `[Value <String>]`: Value of the metadata property.
          - `[Name <String>]`: Human-friendly name of the object mapping.
          - `[Scope <IMicrosoftGraphFilter>]`: filter
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[CategoryFilterGroups <IMicrosoftGraphFilterGroup[]>]`: *Experimental* Filter group set used to decide whether given object belongs and should be processed as part of this object mapping. An object is considered in scope if ANY of the groups in the collection is evaluated to true.
              - `[Clauses <IMicrosoftGraphFilterClause[]>]`: Filter clauses (conditions) of this group. All clauses in a group must be satisfied in order for the filter group to evaluate to true.
                - `[OperatorName <String>]`: Name of the operator to be applied to the source and target operands. Must be one of the supported operators. Supported operators can be discovered.
                - `[SourceOperandName <String>]`: Name of source operand (the operand being tested). The source operand name must match one of the attribute names on the source object.
                - `[TargetOperand <IMicrosoftGraphFilterOperand>]`: filterOperand
                  - `[(Any) <Object>]`: This indicates any property can be added to this object.
                  - `[Values <String[]>]`: Collection of values.
              - `[Name <String>]`: Human-readable name of the filter group.
            - `[Groups <IMicrosoftGraphFilterGroup[]>]`: Filter group set used to decide whether given object is in scope for provisioning. This is the filter which should be used in most cases. If an object used to satisfy this filter at a given moment, and then the object or the filter was changed so that filter isn't satisfied any longer, such object will get deprovisioned'. An object is considered in scope if ANY of the groups in the collection is evaluated to true.
            - `[InputFilterGroups <IMicrosoftGraphFilterGroup[]>]`: *Experimental* Filter group set used to filter out objects at the early stage of reading them from the directory. If an object doesn't satisfy this filter, then it will not be processed further. Important to understand is that if an object used to satisfy this filter at a given moment, and then the object or the filter was changed so that filter is no longer satisfied, such object will NOT get deprovisioned. An object is considered in scope if ANY of the groups in the collection is evaluated to true.
          - `[SourceObjectName <String>]`: Name of the object in the source directory. Must match the object name from the source directory definition.
          - `[TargetObjectName <String>]`: Name of the object in target directory. Must match the object name from the target directory definition.
        - `[Priority <Int32?>]`: Priority relative to other rules in the synchronizationSchema. Rules with the lowest priority number will be processed first.
        - `[SourceDirectoryName <String>]`: Name of the source directory. Must match one of the directory definitions in synchronizationSchema.
        - `[TargetDirectoryName <String>]`: Name of the target directory. Must match one of the directory definitions in synchronizationSchema.
      - `[Version <String>]`: The version of the schema, updated automatically with every schema change.
    - `[Status <IMicrosoftGraphSynchronizationStatus>]`: synchronizationStatus
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Code <String>]`: synchronizationStatusCode
      - `[CountSuccessiveCompleteFailures <Int64?>]`: Number of consecutive times this job failed.
      - `[EscrowsPruned <Boolean?>]`: true if the job's escrows (object-level errors) were pruned during initial synchronization. Escrows can be pruned if during the initial synchronization, you reach the threshold of errors that would normally put the job in quarantine. Instead of going into quarantine, the synchronization process clears the job's errors and continues until the initial synchronization is completed. When the initial synchronization is completed, the job will pause and wait for the customer to clean up the errors.
      - `[LastExecution <IMicrosoftGraphSynchronizationTaskExecution>]`: synchronizationTaskExecution
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[ActivityIdentifier <String>]`: Identifier of the job run.
        - `[CountEntitled <Int64?>]`: Count of processed entries that were assigned for this application.
        - `[CountEntitledForProvisioning <Int64?>]`: Count of processed entries that were assigned for provisioning.
        - `[CountEscrowed <Int64?>]`: Count of entries that were escrowed (errors).
        - `[CountEscrowedRaw <Int64?>]`: Count of entries that were escrowed, including system-generated escrows.
        - `[CountExported <Int64?>]`: Count of exported entries.
        - `[CountExports <Int64?>]`: Count of entries that were expected to be exported.
        - `[CountImported <Int64?>]`: Count of imported entries.
        - `[CountImportedDeltas <Int64?>]`: Count of imported delta-changes.
        - `[CountImportedReferenceDeltas <Int64?>]`: Count of imported delta-changes pertaining to reference changes.
        - `[Error <IMicrosoftGraphSynchronizationError>]`: synchronizationError
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Code <String>]`: The error code. For example, AzureDirectoryB2BManagementPolicyCheckFailure.
          - `[Message <String>]`: The error message. For example, Policy permitting auto-redemption of invitations not configured.
          - `[TenantActionable <Boolean?>]`: The action to take to resolve the error. For example, false.
        - `[State <String>]`: synchronizationTaskExecutionResult
        - `[TimeBegan <DateTime?>]`: Time when this job run began. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[TimeEnded <DateTime?>]`: Time when this job run ended. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[LastSuccessfulExecution <IMicrosoftGraphSynchronizationTaskExecution>]`: synchronizationTaskExecution
      - `[LastSuccessfulExecutionWithExports <IMicrosoftGraphSynchronizationTaskExecution>]`: synchronizationTaskExecution
      - `[Progress <IMicrosoftGraphSynchronizationProgress[]>]`: Details of the progress of a job toward completion.
        - `[CompletedUnits <Int64?>]`: The numerator of a progress ratio; the number of units of changes already processed.
        - `[ProgressObservationDateTime <DateTime?>]`: The time of a progress observation as an offset in minutes from UTC.
        - `[TotalUnits <Int64?>]`: The denominator of a progress ratio; a number of units of changes to be processed to accomplish synchronization.
        - `[Units <String>]`: An optional description of the units.
      - `[Quarantine <IMicrosoftGraphSynchronizationQuarantine>]`: synchronizationQuarantine
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[CurrentBegan <DateTime?>]`: Date and time when the quarantine was last evaluated and imposed. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[Error <IMicrosoftGraphSynchronizationError>]`: synchronizationError
        - `[NextAttempt <DateTime?>]`: Date and time when the next attempt to re-evaluate the quarantine will be made. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[Reason <String>]`: quarantineReason
        - `[SeriesBegan <DateTime?>]`: Date and time when the quarantine was first imposed in this series (a series starts when a quarantine is first imposed, and is reset as soon as the quarantine is lifted). The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[SeriesCount <Int64?>]`: Number of times in this series the quarantine was re-evaluated and left in effect (a series starts when quarantine is first imposed, and is reset as soon as quarantine is lifted).
      - `[SteadyStateFirstAchievedTime <DateTime?>]`: The time when steady state (no more changes to the process) was first achieved. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[SteadyStateLastAchievedTime <DateTime?>]`: The time when steady state (no more changes to the process) was last achieved. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[SynchronizedEntryCountByType <IMicrosoftGraphStringKeyLongValuePair[]>]`: Count of synchronized objects, listed by object type.
        - `[Key <String>]`: The mapping of the user type from the source system to the target system. For example:User to User - For Microsoft Entra ID to Microsoft Entra ID synchronization worker to user - For Workday to Microsoft Entra synchronization.
        - `[Value <Int64?>]`: Total number of synchronized objects.
      - `[TroubleshootingUrl <String>]`: In the event of an error, the URL with the troubleshooting steps for the issue.
    - `[SynchronizationJobSettings <IMicrosoftGraphKeyValuePair[]>]`: Settings associated with the job. Some settings are inherited from the template.
      - `[Name <String>]`: Name for this key-value pair
      - `[Value <String>]`: Value for this key-value pair
    - `[TemplateId <String>]`: Identifier of the synchronization template this job is based on.
  - `[Secrets <IMicrosoftGraphSynchronizationSecretKeyStringValuePair[]>]`: Represents a collection of credentials to access provisioned cloud applications.
    - `[Key <String>]`: synchronizationSecret
    - `[Value <String>]`: The value of the secret.
  - `[Templates <IMicrosoftGraphSynchronizationTemplate[]>]`: Preconfigured synchronization settings for a particular application.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[ApplicationId <String>]`: Identifier of the application this template belongs to.
    - `[Default <Boolean?>]`: true if this template is recommended to be the default for the application.
    - `[Description <String>]`: Description of the template.
    - `[Discoverable <Boolean?>]`: true if this template should appear in the collection of templates available for the application instance (service principal).
    - `[FactoryTag <String>]`: One of the well-known factory tags supported by the synchronization engine. The factoryTag tells the synchronization engine which implementation to use when processing jobs based on this template.
    - `[Metadata <IMicrosoftGraphSynchronizationMetadataEntry[]>]`: Additional extension properties. Unless mentioned explicitly, metadata values should not be changed.
      - `[Key <String>]`: synchronizationMetadata
      - `[Value <String>]`: Value of the metadata property.
    - `[Schema <IMicrosoftGraphSynchronizationSchema>]`: synchronizationSchema

`TOKENISSUANCEPOLICIES <IMicrosoftGraphTokenIssuancePolicy[]>`: .
  - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
  - `[Definition <String[]>]`: A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.
  - `[IsOrganizationDefault <Boolean?>]`: If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.
  - `[Description <String>]`: Description for this policy. Required.
  - `[DisplayName <String>]`: Display name for this policy. Required.
  - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.

`TOKENLIFETIMEPOLICIES <IMicrosoftGraphTokenLifetimePolicy[]>`: .
  - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
  - `[Definition <String[]>]`: A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.
  - `[IsOrganizationDefault <Boolean?>]`: If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.
  - `[Description <String>]`: Description for this policy. Required.
  - `[DisplayName <String>]`: Display name for this policy. Required.
  - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.

`VERIFIEDPUBLISHER <IMicrosoftGraphVerifiedPublisher>`: verifiedPublisher
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AddedDateTime <DateTime?>]`: The timestamp when the verified publisher was first added or most recently updated.
  - `[DisplayName <String>]`: The verified publisher name from the app publisher's Partner Center account.
  - `[VerifiedPublisherId <String>]`: The ID of the verified publisher from the app publisher's Partner Center account.

`WEB <IMicrosoftGraphWebApplication>`: webApplication
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[HomePageUrl <String>]`: Home page or landing page of the application.
  - `[ImplicitGrantSettings <IMicrosoftGraphImplicitGrantSettings>]`: implicitGrantSettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[EnableAccessTokenIssuance <Boolean?>]`: Specifies whether this web application can request an access token using the OAuth 2.0 implicit flow.
    - `[EnableIdTokenIssuance <Boolean?>]`: Specifies whether this web application can request an ID token using the OAuth 2.0 implicit flow.
  - `[LogoutUrl <String>]`: Specifies the URL that is used by Microsoft's authorization service to log out a user using front-channel, back-channel or SAML logout protocols.
  - `[RedirectUriSettings <IMicrosoftGraphRedirectUriSettings[]>]`: 
    - `[Index <Int32?>]`: 
    - `[Uri <String>]`: 
  - `[RedirectUris <String[]>]`: Specifies the URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent.

## RELATED LINKS

