---
external help file:
Module Name: Microsoft.Graph.Applications
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.applications/update-mgapplication
schema: 2.0.0
---

# Update-MgApplication

## SYNOPSIS
Update entity in applications

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgApplication -ApplicationId <String> [-AdditionalProperties <Hashtable>]
 [-Api <IMicrosoftGraphApiApplication1>] [-AppId <String>] [-AppRoles <IMicrosoftGraphAppRole[]>]
 [-ConnectorGroup <IMicrosoftGraphConnectorGroup>] [-CreatedDateTime <DateTime>]
 [-CreatedOnBehalfOf <IMicrosoftGraphDirectoryObject>] [-DeletedDateTime <DateTime>] [-Description <String>]
 [-DisplayName <String>] [-ExtensionProperties <IMicrosoftGraphExtensionProperty[]>]
 [-GroupMembershipClaims <String>] [-HomeRealmDiscoveryPolicies <IMicrosoftGraphHomeRealmDiscoveryPolicy1[]>]
 [-Id <String>] [-IdentifierUris <String[]>] [-Info <IMicrosoftGraphInformationalUrl>]
 [-IsDeviceOnlyAuthSupported] [-IsFallbackPublicClient] [-KeyCredentials <IMicrosoftGraphKeyCredential[]>]
 [-LogoInputFile <String>] [-Notes <String>] [-OnPremisesPublishing <IMicrosoftGraphOnPremisesPublishing>]
 [-OptionalClaims <IMicrosoftGraphOptionalClaims>] [-Owners <IMicrosoftGraphDirectoryObject[]>]
 [-ParentalControlSettings <IMicrosoftGraphParentalControlSettings>]
 [-PasswordCredentials <IMicrosoftGraphPasswordCredential[]>]
 [-PublicClient <IMicrosoftGraphPublicClientApplication>] [-PublisherDomain <String>]
 [-RequiredResourceAccess <IMicrosoftGraphRequiredResourceAccess[]>] [-SignInAudience <String>]
 [-Synchronization <IMicrosoftGraphSynchronization>] [-Tags <String[]>] [-TokenEncryptionKeyId <String>]
 [-TokenIssuancePolicies <IMicrosoftGraphTokenIssuancePolicy1[]>]
 [-TokenLifetimePolicies <IMicrosoftGraphTokenLifetimePolicy1[]>] [-UniqueName <String>]
 [-Web <IMicrosoftGraphWebApplication1>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgApplication -ApplicationId <String> -BodyParameter <IMicrosoftGraphApplication> [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgApplication -InputObject <IApplicationsIdentity> -BodyParameter <IMicrosoftGraphApplication>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgApplication -InputObject <IApplicationsIdentity> [-AdditionalProperties <Hashtable>]
 [-Api <IMicrosoftGraphApiApplication1>] [-AppId <String>] [-AppRoles <IMicrosoftGraphAppRole[]>]
 [-ConnectorGroup <IMicrosoftGraphConnectorGroup>] [-CreatedDateTime <DateTime>]
 [-CreatedOnBehalfOf <IMicrosoftGraphDirectoryObject>] [-DeletedDateTime <DateTime>] [-Description <String>]
 [-DisplayName <String>] [-ExtensionProperties <IMicrosoftGraphExtensionProperty[]>]
 [-GroupMembershipClaims <String>] [-HomeRealmDiscoveryPolicies <IMicrosoftGraphHomeRealmDiscoveryPolicy1[]>]
 [-Id <String>] [-IdentifierUris <String[]>] [-Info <IMicrosoftGraphInformationalUrl>]
 [-IsDeviceOnlyAuthSupported] [-IsFallbackPublicClient] [-KeyCredentials <IMicrosoftGraphKeyCredential[]>]
 [-LogoInputFile <String>] [-Notes <String>] [-OnPremisesPublishing <IMicrosoftGraphOnPremisesPublishing>]
 [-OptionalClaims <IMicrosoftGraphOptionalClaims>] [-Owners <IMicrosoftGraphDirectoryObject[]>]
 [-ParentalControlSettings <IMicrosoftGraphParentalControlSettings>]
 [-PasswordCredentials <IMicrosoftGraphPasswordCredential[]>]
 [-PublicClient <IMicrosoftGraphPublicClientApplication>] [-PublisherDomain <String>]
 [-RequiredResourceAccess <IMicrosoftGraphRequiredResourceAccess[]>] [-SignInAudience <String>]
 [-Synchronization <IMicrosoftGraphSynchronization>] [-Tags <String[]>] [-TokenEncryptionKeyId <String>]
 [-TokenIssuancePolicies <IMicrosoftGraphTokenIssuancePolicy1[]>]
 [-TokenLifetimePolicies <IMicrosoftGraphTokenLifetimePolicy1[]>] [-UniqueName <String>]
 [-Web <IMicrosoftGraphWebApplication1>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
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

### -Api
apiApplication
To construct, see NOTES section for API properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphApiApplication1
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
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
```

### -ApplicationId
key: id of application

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

### -AppRoles
The collection of roles the application declares.
With app role assignments, these roles can be assigned to users, groups, or other applications' service principals.
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
```

### -ConnectorGroup
connectorGroup
To construct, see NOTES section for CONNECTORGROUP properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphConnectorGroup
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
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
```

### -Description
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
```

### -HomeRealmDiscoveryPolicies
.
To construct, see NOTES section for HOMEREALMDISCOVERYPOLICIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphHomeRealmDiscoveryPolicy1[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
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
```

### -Info
informationalUrl
To construct, see NOTES section for INFO properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphInformationalUrl
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
Type: Microsoft.Graph.PowerShell.Models.IApplicationsIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
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
```

### -Notes
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

### -OnPremisesPublishing
onPremisesPublishing
To construct, see NOTES section for ONPREMISESPUBLISHING properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOnPremisesPublishing
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
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
```

### -ParentalControlSettings
parentalControlSettings
To construct, see NOTES section for PARENTALCONTROLSETTINGS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphParentalControlSettings
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
```

### -Synchronization
synchronization
To construct, see NOTES section for SYNCHRONIZATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSynchronization
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
```

### -TokenIssuancePolicies
.
To construct, see NOTES section for TOKENISSUANCEPOLICIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTokenIssuancePolicy1[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTokenLifetimePolicy1[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWebApplication1
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

### Microsoft.Graph.PowerShell.Models.IApplicationsIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphApplication

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


API <IMicrosoftGraphApiApplication1>: apiApplication
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AcceptMappedClaims <Boolean?>]`: When true, allows an application to use claims mapping without specifying a custom signing key.
  - `[KnownClientApplications <String[]>]`: Used for bundling consent if you have a solution that contains two parts: a client app and a custom web API app. If you set the appID of the client app to this value, the user only consents once to the client app. Azure AD knows that consenting to the client means implicitly consenting to the web API and automatically provisions service principals for both APIs at the same time. Both the client and the web API app must be registered in the same tenant.
  - `[Oauth2PermissionScopes <IMicrosoftGraphPermissionScope[]>]`: The definition of the delegated permissions exposed by the web API represented by this application registration. These delegated permissions may be requested by a client application, and may be granted by users or administrators during consent. Delegated permissions are sometimes referred to as OAuth 2.0 scopes.
    - `[AdminConsentDescription <String>]`: A description of the delegated permissions, intended to be read by an administrator granting the permission on behalf of all users. This text appears in tenant-wide admin consent experiences.
    - `[AdminConsentDisplayName <String>]`: The permission's title, intended to be read by an administrator granting the permission on behalf of all users.
    - `[Id <String>]`: Unique delegated permission identifier inside the collection of delegated permissions defined for a resource application.
    - `[IsEnabled <Boolean?>]`: When creating or updating a permission, this property must be set to true (which is the default). To delete a permission, this property must first be set to false.  At that point, in a subsequent call, the permission may be removed.
    - `[Origin <String>]`: 
    - `[Type <String>]`: Specifies whether this delegated permission should be considered safe for non-admin users to consent to on behalf of themselves, or whether an administrator should be required for consent to the permissions. This will be the default behavior, but each customer can choose to customize the behavior in their organization (by allowing, restricting or limiting user consent to this delegated permission.)
    - `[UserConsentDescription <String>]`: A description of the delegated permissions, intended to be read by a user granting the permission on their own behalf. This text appears in consent experiences where the user is consenting only on behalf of themselves.
    - `[UserConsentDisplayName <String>]`: A title for the permission, intended to be read by a user granting the permission on their own behalf. This text appears in consent experiences where the user is consenting only on behalf of themselves.
    - `[Value <String>]`: Specifies the value to include in the scp (scope) claim in access tokens. Must not exceed 120 characters in length. Allowed characters are : ! # $ % & ' ( ) * + , - . / : ;  =  ? @ [ ] ^ + _  {  } ~, as well as characters in the ranges 0-9, A-Z and a-z. Any other character, including the space character, are not allowed.
  - `[PreAuthorizedApplications <IMicrosoftGraphPreAuthorizedApplication1[]>]`: Lists the client applications that are pre-authorized with the specified delegated permissions to access this application's APIs. Users are not required to consent to any pre-authorized application (for the permissions specified). However, any additional permissions not listed in preAuthorizedApplications (requested through incremental consent for example) will require user consent.
    - `[AppId <String>]`: The unique identifier for the application.
    - `[PermissionIds <String[]>]`: 
  - `[RequestedAccessTokenVersion <Int32?>]`: Specifies the access token version expected by this resource. This changes the version and format of the JWT produced independent of the endpoint or client used to request the access token.  The endpoint used, v1.0 or v2.0, is chosen by the client and only impacts the version of id_tokens. Resources need to explicitly configure requestedAccessTokenVersion to indicate the supported access token format.  Possible values for requestedAccessTokenVersion are 1, 2, or null. If the value is null, this defaults to 1, which corresponds to the v1.0 endpoint.  If signInAudience on the application is configured as AzureADandPersonalMicrosoftAccount, the value for this property must be 2

APPROLES <IMicrosoftGraphAppRole[]>: The collection of roles the application declares. With app role assignments, these roles can be assigned to users, groups, or other applications' service principals. Not nullable.
  - `[AllowedMemberTypes <String[]>]`: Specifies whether this app role can be assigned to users and groups (by setting to ['User']), to other application's (by setting to ['Application'], or both (by setting to ['User', 'Application']). App roles supporting assignment of other applications' service principals are also known as application permissions.
  - `[Description <String>]`: The description for the app role. This is displayed when the app role is being assigned and, if the app role functions as an application permission, during  consent experiences.
  - `[DisplayName <String>]`: Display name for the permission that appears in the app role assignment and consent experiences.
  - `[Id <String>]`: Unique role identifier inside the appRoles collection. When creating a new app role, a new Guid identifier must be provided.
  - `[IsEnabled <Boolean?>]`: When creating or updating an app role, this must be set to true (which is the default). To delete a role, this must first be set to false.  At that point, in a subsequent call, this role may be removed.
  - `[Origin <String>]`: Specifies if the app role is defined on the application object or on the servicePrincipal entity. Must not be included in any POST or PATCH requests. Read-only.
  - `[Value <String>]`: Specifies the value to include in the roles claim in ID tokens and access tokens authenticating an assigned user or service principal. Must not exceed 120 characters in length. Allowed characters are : ! # $ % & ' ( ) * + , - . / : ;  =  ? @ [ ] ^ + _  {  } ~, as well as characters in the ranges 0-9, A-Z and a-z. Any other character, including the space character, are not allowed.

BODYPARAMETER <IMicrosoftGraphApplication>: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DeletedDateTime <DateTime?>]`: 
  - `[Id <String>]`: Read-only.
  - `[Api <IMicrosoftGraphApiApplication1>]`: apiApplication
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AcceptMappedClaims <Boolean?>]`: When true, allows an application to use claims mapping without specifying a custom signing key.
    - `[KnownClientApplications <String[]>]`: Used for bundling consent if you have a solution that contains two parts: a client app and a custom web API app. If you set the appID of the client app to this value, the user only consents once to the client app. Azure AD knows that consenting to the client means implicitly consenting to the web API and automatically provisions service principals for both APIs at the same time. Both the client and the web API app must be registered in the same tenant.
    - `[Oauth2PermissionScopes <IMicrosoftGraphPermissionScope[]>]`: The definition of the delegated permissions exposed by the web API represented by this application registration. These delegated permissions may be requested by a client application, and may be granted by users or administrators during consent. Delegated permissions are sometimes referred to as OAuth 2.0 scopes.
      - `[AdminConsentDescription <String>]`: A description of the delegated permissions, intended to be read by an administrator granting the permission on behalf of all users. This text appears in tenant-wide admin consent experiences.
      - `[AdminConsentDisplayName <String>]`: The permission's title, intended to be read by an administrator granting the permission on behalf of all users.
      - `[Id <String>]`: Unique delegated permission identifier inside the collection of delegated permissions defined for a resource application.
      - `[IsEnabled <Boolean?>]`: When creating or updating a permission, this property must be set to true (which is the default). To delete a permission, this property must first be set to false.  At that point, in a subsequent call, the permission may be removed.
      - `[Origin <String>]`: 
      - `[Type <String>]`: Specifies whether this delegated permission should be considered safe for non-admin users to consent to on behalf of themselves, or whether an administrator should be required for consent to the permissions. This will be the default behavior, but each customer can choose to customize the behavior in their organization (by allowing, restricting or limiting user consent to this delegated permission.)
      - `[UserConsentDescription <String>]`: A description of the delegated permissions, intended to be read by a user granting the permission on their own behalf. This text appears in consent experiences where the user is consenting only on behalf of themselves.
      - `[UserConsentDisplayName <String>]`: A title for the permission, intended to be read by a user granting the permission on their own behalf. This text appears in consent experiences where the user is consenting only on behalf of themselves.
      - `[Value <String>]`: Specifies the value to include in the scp (scope) claim in access tokens. Must not exceed 120 characters in length. Allowed characters are : ! # $ % & ' ( ) * + , - . / : ;  =  ? @ [ ] ^ + _  {  } ~, as well as characters in the ranges 0-9, A-Z and a-z. Any other character, including the space character, are not allowed.
    - `[PreAuthorizedApplications <IMicrosoftGraphPreAuthorizedApplication1[]>]`: Lists the client applications that are pre-authorized with the specified delegated permissions to access this application's APIs. Users are not required to consent to any pre-authorized application (for the permissions specified). However, any additional permissions not listed in preAuthorizedApplications (requested through incremental consent for example) will require user consent.
      - `[AppId <String>]`: The unique identifier for the application.
      - `[PermissionIds <String[]>]`: 
    - `[RequestedAccessTokenVersion <Int32?>]`: Specifies the access token version expected by this resource. This changes the version and format of the JWT produced independent of the endpoint or client used to request the access token.  The endpoint used, v1.0 or v2.0, is chosen by the client and only impacts the version of id_tokens. Resources need to explicitly configure requestedAccessTokenVersion to indicate the supported access token format.  Possible values for requestedAccessTokenVersion are 1, 2, or null. If the value is null, this defaults to 1, which corresponds to the v1.0 endpoint.  If signInAudience on the application is configured as AzureADandPersonalMicrosoftAccount, the value for this property must be 2
  - `[AppId <String>]`: The unique identifier for the application that is assigned to an application by Azure AD. Not nullable. Read-only.
  - `[AppRoles <IMicrosoftGraphAppRole[]>]`: The collection of roles the application declares. With app role assignments, these roles can be assigned to users, groups, or other applications' service principals. Not nullable.
    - `[AllowedMemberTypes <String[]>]`: Specifies whether this app role can be assigned to users and groups (by setting to ['User']), to other application's (by setting to ['Application'], or both (by setting to ['User', 'Application']). App roles supporting assignment of other applications' service principals are also known as application permissions.
    - `[Description <String>]`: The description for the app role. This is displayed when the app role is being assigned and, if the app role functions as an application permission, during  consent experiences.
    - `[DisplayName <String>]`: Display name for the permission that appears in the app role assignment and consent experiences.
    - `[Id <String>]`: Unique role identifier inside the appRoles collection. When creating a new app role, a new Guid identifier must be provided.
    - `[IsEnabled <Boolean?>]`: When creating or updating an app role, this must be set to true (which is the default). To delete a role, this must first be set to false.  At that point, in a subsequent call, this role may be removed.
    - `[Origin <String>]`: Specifies if the app role is defined on the application object or on the servicePrincipal entity. Must not be included in any POST or PATCH requests. Read-only.
    - `[Value <String>]`: Specifies the value to include in the roles claim in ID tokens and access tokens authenticating an assigned user or service principal. Must not exceed 120 characters in length. Allowed characters are : ! # $ % & ' ( ) * + , - . / : ;  =  ? @ [ ] ^ + _  {  } ~, as well as characters in the ranges 0-9, A-Z and a-z. Any other character, including the space character, are not allowed.
  - `[ConnectorGroup <IMicrosoftGraphConnectorGroup>]`: connectorGroup
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[Applications <IMicrosoftGraphApplication[]>]`: 
    - `[ConnectorGroupType <String>]`: connectorGroupType
    - `[IsDefault <Boolean?>]`: 
    - `[Members <IMicrosoftGraphConnector[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[ExternalIP <String>]`: 
      - `[MachineName <String>]`: 
      - `[MemberOf <IMicrosoftGraphConnectorGroup[]>]`: 
      - `[Status <String>]`: connectorStatus
    - `[Name <String>]`: 
    - `[Region <String>]`: connectorGroupRegion
  - `[CreatedDateTime <DateTime?>]`: The date and time the application was registered. Read-only.
  - `[CreatedOnBehalfOf <IMicrosoftGraphDirectoryObject>]`: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[DeletedDateTime <DateTime?>]`: 
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
  - `[HomeRealmDiscoveryPolicies <IMicrosoftGraphHomeRealmDiscoveryPolicy1[]>]`: 
    - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[Definition <String[]>]`: A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.
    - `[IsOrganizationDefault <Boolean?>]`: If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.
    - `[Description <String>]`: Description for this policy.
    - `[DisplayName <String>]`: Display name for this policy.
    - `[DeletedDateTime <DateTime?>]`: 
    - `[Id <String>]`: Read-only.
  - `[IdentifierUris <String[]>]`: The URIs that identify the application within its Azure AD tenant, or within a verified custom domain if the application is multi-tenant. For more information see Application Objects and Service Principal Objects. The any operator is required for filter expressions on multi-valued properties. Not nullable.
  - `[Info <IMicrosoftGraphInformationalUrl>]`: informationalUrl
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[LogoUrl <String>]`: CDN URL to the application's logo, Read-only.
    - `[MarketingUrl <String>]`: Link to the application's marketing page. For example, https://www.contoso.com/app/marketing
    - `[PrivacyStatementUrl <String>]`: Link to the application's privacy statement. For example, https://www.contoso.com/app/privacy
    - `[SupportUrl <String>]`: Link to the application's support page. For example, https://www.contoso.com/app/support
    - `[TermsOfServiceUrl <String>]`: Link to the application's terms of service statement. For example, https://www.contoso.com/app/termsofservice
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
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
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
    - `[SingleSignOnSettings <IMicrosoftGraphOnPremisesPublishingSingleSignOn>]`: onPremisesPublishingSingleSignOn
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[KerberosSignOnSettings <IMicrosoftGraphKerberosSignOnSettings>]`: kerberosSignOnSettings
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[KerberosServicePrincipalName <String>]`: 
        - `[KerberosSignOnMappingAttributeType <String>]`: kerberosSignOnMappingAttributeType
      - `[SingleSignOnMode <String>]`: singleSignOnMode
    - `[UseAlternateUrlForTranslationAndRedirect <Boolean?>]`: 
    - `[VerifiedCustomDomainCertificatesMetadata <IMicrosoftGraphVerifiedCustomDomainCertificatesMetadata>]`: verifiedCustomDomainCertificatesMetadata
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ExpiryDate <DateTime?>]`: 
      - `[IssueDate <DateTime?>]`: 
      - `[IssuerName <String>]`: 
      - `[SubjectName <String>]`: 
      - `[Thumbprint <String>]`: 
    - `[VerifiedCustomDomainKeyCredential <IMicrosoftGraphKeyCredential>]`: keyCredential
    - `[VerifiedCustomDomainPasswordCredential <IMicrosoftGraphPasswordCredential>]`: passwordCredential
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[CustomKeyIdentifier <Byte[]>]`: Do not use.
      - `[DisplayName <String>]`: Friendly name for the password. Optional.
      - `[EndDateTime <DateTime?>]`: The date and time at which the password expires represented using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Optional.
      - `[Hint <String>]`: Contains the first three characters of the password. Read-only.
      - `[KeyId <String>]`: The unique identifier for the password.
      - `[SecretText <String>]`: Read-only; Contains the strong passwords generated by Azure AD that are 16-64 characters in length. The generated password value is only returned during the initial POST request to addPassword. There is no way to retrieve this password in the future.
      - `[StartDateTime <DateTime?>]`: The date and time at which the password becomes valid. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Optional.
  - `[OptionalClaims <IMicrosoftGraphOptionalClaims>]`: optionalClaims
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AccessToken <IMicrosoftGraphOptionalClaim[]>]`: The optional claims returned in the JWT access token.
      - `[AdditionalProperties <String[]>]`: Additional properties of the claim. If a property exists in this collection, it modifies the behavior of the optional claim specified in the name property.
      - `[Essential <Boolean?>]`: If the value is true, the claim specified by the client is necessary to ensure a smooth authorization experience for the specific task requested by the end user. The default value is false.
      - `[Name <String>]`: The name of the optional claim.
      - `[Source <String>]`: The source (directory object) of the claim. There are predefined claims and user-defined claims from extension properties. If the source value is null, the claim is a predefined optional claim. If the source value is user, the value in the name property is the extension property from the user object.
    - `[IdToken <IMicrosoftGraphOptionalClaim[]>]`: The optional claims returned in the JWT ID token.
    - `[Saml2Token <IMicrosoftGraphOptionalClaim[]>]`: The optional claims returned in the SAML token.
  - `[Owners <IMicrosoftGraphDirectoryObject[]>]`: Directory objects that are owners of the application. The owners are a set of non-admin users who are allowed to modify this object. Requires version 2013-11-08 or newer. Read-only. Nullable.
  - `[ParentalControlSettings <IMicrosoftGraphParentalControlSettings>]`: parentalControlSettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[CountriesBlockedForMinors <String[]>]`: Specifies the two-letter ISO country codes. Access to the application will be blocked for minors from the countries specified in this list.
    - `[LegalAgeGroupRule <String>]`: Specifies the legal age group rule that applies to users of the app. Can be set to one of the following values: ValueDescriptionAllowDefault. Enforces the legal minimum. This means parental consent is required for minors in the European Union and Korea.RequireConsentForPrivacyServicesEnforces the user to specify date of birth to comply with COPPA rules. RequireConsentForMinorsRequires parental consent for ages below 18, regardless of country minor rules.RequireConsentForKidsRequires parental consent for ages below 14, regardless of country minor rules.BlockMinorsBlocks minors from using the app.
  - `[PasswordCredentials <IMicrosoftGraphPasswordCredential[]>]`: The collection of password credentials associated with the application. Not nullable.
  - `[PublicClient <IMicrosoftGraphPublicClientApplication>]`: publicClientApplication
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[RedirectUris <String[]>]`: Specifies the URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent.
  - `[PublisherDomain <String>]`: The verified publisher domain for the application. Read-only.
  - `[RequiredResourceAccess <IMicrosoftGraphRequiredResourceAccess[]>]`: Specifies resources that this application requires access to and the set of OAuth permission scopes and application roles that it needs under each of those resources. This pre-configuration of required resource access drives the consent experience. Not nullable.
    - `[ResourceAccess <IMicrosoftGraphResourceAccess[]>]`: The list of OAuth2.0 permission scopes and app roles that the application requires from the specified resource.
      - `[Id <String>]`: The unique identifier for one of the oauth2PermissionScopes or appRole instances that the resource application exposes.
      - `[Type <String>]`: Specifies whether the id property references an oauth2PermissionScopes or an appRole. Possible values are Scope or Role.
    - `[ResourceAppId <String>]`: The unique identifier for the resource that the application requires access to.  This should be equal to the appId declared on the target resource application.
  - `[SignInAudience <String>]`: Specifies what Microsoft accounts are supported for the current application. Supported values are:AzureADMyOrg: Users with a Microsoft work or school account in my organization’s Azure AD tenant (i.e. single tenant)AzureADMultipleOrgs: Users with a Microsoft work or school account in any organization’s Azure AD tenant (i.e. multi-tenant) AzureADandPersonalMicrosoftAccount: Users with a personal Microsoft account, or a work or school account in any organization’s Azure AD tenant
  - `[Synchronization <IMicrosoftGraphSynchronization>]`: synchronization
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[Jobs <IMicrosoftGraphSynchronizationJob[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[Schedule <IMicrosoftGraphSynchronizationSchedule>]`: synchronizationSchedule
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Expiration <DateTime?>]`: 
        - `[Interval <TimeSpan?>]`: 
        - `[State <String>]`: synchronizationScheduleState
      - `[Schema <IMicrosoftGraphSynchronizationSchema>]`: synchronizationSchema
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: Read-only.
        - `[Directories <IMicrosoftGraphDirectoryDefinition[]>]`: 
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
              - `[FlowNullValues <Boolean?>]`: 
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
        - `[SynchronizationRules <IMicrosoftGraphSynchronizationRule[]>]`: 
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
              - `[Source <IMicrosoftGraphAttributeMappingSource>]`: attributeMappingSource
                - `[(Any) <Object>]`: This indicates any property can be added to this object.
                - `[Expression <String>]`: 
                - `[Name <String>]`: 
                - `[Parameters <IMicrosoftGraphStringKeyAttributeMappingSourceValuePair[]>]`: 
                  - `[Key <String>]`: 
                  - `[Value <IMicrosoftGraphAttributeMappingSource>]`: attributeMappingSource
                - `[Type <String>]`: attributeMappingSourceType
              - `[TargetAttributeName <String>]`: 
            - `[Enabled <Boolean?>]`: 
            - `[FlowTypes <String>]`: objectFlowTypes
            - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: 
            - `[Name <String>]`: 
            - `[Scope <IMicrosoftGraphFilter>]`: filter
              - `[(Any) <Object>]`: This indicates any property can be added to this object.
              - `[CategoryFilterGroups <IMicrosoftGraphFilterGroup[]>]`: 
                - `[Clauses <IMicrosoftGraphFilterClause[]>]`: 
                  - `[OperatorName <String>]`: 
                  - `[SourceOperandName <String>]`: 
                  - `[TargetOperand <IMicrosoftGraphFilterOperand>]`: filterOperand
                    - `[(Any) <Object>]`: This indicates any property can be added to this object.
                    - `[Values <String[]>]`: 
                - `[Name <String>]`: 
              - `[Groups <IMicrosoftGraphFilterGroup[]>]`: 
              - `[InputFilterGroups <IMicrosoftGraphFilterGroup[]>]`: 
            - `[SourceObjectName <String>]`: 
            - `[TargetObjectName <String>]`: 
          - `[Priority <Int32?>]`: 
          - `[SourceDirectoryName <String>]`: 
          - `[TargetDirectoryName <String>]`: 
        - `[Version <String>]`: 
      - `[Status <IMicrosoftGraphSynchronizationStatus>]`: synchronizationStatus
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Code <String>]`: synchronizationStatusCode
        - `[CountSuccessiveCompleteFailures <Int64?>]`: 
        - `[EscrowsPruned <Boolean?>]`: 
        - `[LastExecution <IMicrosoftGraphSynchronizationTaskExecution>]`: synchronizationTaskExecution
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[ActivityIdentifier <String>]`: 
          - `[CountEntitled <Int64?>]`: 
          - `[CountEntitledForProvisioning <Int64?>]`: 
          - `[CountEscrowed <Int64?>]`: 
          - `[CountEscrowedRaw <Int64?>]`: 
          - `[CountExported <Int64?>]`: 
          - `[CountExports <Int64?>]`: 
          - `[CountImported <Int64?>]`: 
          - `[CountImportedDeltas <Int64?>]`: 
          - `[CountImportedReferenceDeltas <Int64?>]`: 
          - `[Error <IMicrosoftGraphSynchronizationError>]`: synchronizationError
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[Code <String>]`: 
            - `[Message <String>]`: 
            - `[TenantActionable <Boolean?>]`: 
          - `[State <String>]`: synchronizationTaskExecutionResult
          - `[TimeBegan <DateTime?>]`: 
          - `[TimeEnded <DateTime?>]`: 
        - `[LastSuccessfulExecution <IMicrosoftGraphSynchronizationTaskExecution>]`: synchronizationTaskExecution
        - `[LastSuccessfulExecutionWithExports <IMicrosoftGraphSynchronizationTaskExecution>]`: synchronizationTaskExecution
        - `[Progress <IMicrosoftGraphSynchronizationProgress[]>]`: 
          - `[CompletedUnits <Int64?>]`: 
          - `[ProgressObservationDateTime <DateTime?>]`: 
          - `[TotalUnits <Int64?>]`: 
          - `[Units <String>]`: 
        - `[Quarantine <IMicrosoftGraphSynchronizationQuarantine>]`: synchronizationQuarantine
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[CurrentBegan <DateTime?>]`: 
          - `[Error <IMicrosoftGraphSynchronizationError>]`: synchronizationError
          - `[NextAttempt <DateTime?>]`: 
          - `[Reason <String>]`: quarantineReason
          - `[SeriesBegan <DateTime?>]`: 
          - `[SeriesCount <Int64?>]`: 
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
    - `[Secrets <IMicrosoftGraphSynchronizationSecretKeyStringValuePair[]>]`: 
      - `[Key <String>]`: synchronizationSecret
      - `[Value <String>]`: 
    - `[Templates <IMicrosoftGraphSynchronizationTemplate[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[ApplicationId <String>]`: 
      - `[Default <Boolean?>]`: 
      - `[Description <String>]`: 
      - `[Discoverable <Boolean?>]`: 
      - `[FactoryTag <String>]`: 
      - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: 
      - `[Schema <IMicrosoftGraphSynchronizationSchema>]`: synchronizationSchema
  - `[Tags <String[]>]`: Custom strings that can be used to categorize and identify the application. Not nullable.
  - `[TokenEncryptionKeyId <String>]`: Specifies the keyId of a public key from the keyCredentials collection. When configured, Azure AD encrypts all the tokens it emits by using the key this property points to. The application code that receives the encrypted token must use the matching private key to decrypt the token before it can be used for the signed-in user.
  - `[TokenIssuancePolicies <IMicrosoftGraphTokenIssuancePolicy1[]>]`: 
    - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[Definition <String[]>]`: A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.
    - `[IsOrganizationDefault <Boolean?>]`: If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.
    - `[Description <String>]`: Description for this policy.
    - `[DisplayName <String>]`: Display name for this policy.
    - `[DeletedDateTime <DateTime?>]`: 
    - `[Id <String>]`: Read-only.
  - `[TokenLifetimePolicies <IMicrosoftGraphTokenLifetimePolicy1[]>]`: 
    - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[Definition <String[]>]`: A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.
    - `[IsOrganizationDefault <Boolean?>]`: If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.
    - `[Description <String>]`: Description for this policy.
    - `[DisplayName <String>]`: Display name for this policy.
    - `[DeletedDateTime <DateTime?>]`: 
    - `[Id <String>]`: Read-only.
  - `[UniqueName <String>]`: 
  - `[Web <IMicrosoftGraphWebApplication1>]`: webApplication
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[HomePageUrl <String>]`: Home page or landing page of the application.
    - `[ImplicitGrantSettings <IMicrosoftGraphImplicitGrantSettings>]`: implicitGrantSettings
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[EnableAccessTokenIssuance <Boolean?>]`: Specifies whether this web application can request an access token using the OAuth 2.0 implicit flow.
      - `[EnableIdTokenIssuance <Boolean?>]`: Specifies whether this web application can request an ID token using the OAuth 2.0 implicit flow.
    - `[LogoutUrl <String>]`: Specifies the URL that will be used by Microsoft's authorization service to logout an user using front-channel, back-channel or SAML logout protocols.
    - `[Oauth2AllowImplicitFlow <Boolean?>]`: 
    - `[RedirectUris <String[]>]`: Specifies the URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent.

CONNECTORGROUP <IMicrosoftGraphConnectorGroup>: connectorGroup
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[Applications <IMicrosoftGraphApplication[]>]`: 
    - `[DeletedDateTime <DateTime?>]`: 
    - `[Id <String>]`: Read-only.
    - `[Api <IMicrosoftGraphApiApplication1>]`: apiApplication
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AcceptMappedClaims <Boolean?>]`: When true, allows an application to use claims mapping without specifying a custom signing key.
      - `[KnownClientApplications <String[]>]`: Used for bundling consent if you have a solution that contains two parts: a client app and a custom web API app. If you set the appID of the client app to this value, the user only consents once to the client app. Azure AD knows that consenting to the client means implicitly consenting to the web API and automatically provisions service principals for both APIs at the same time. Both the client and the web API app must be registered in the same tenant.
      - `[Oauth2PermissionScopes <IMicrosoftGraphPermissionScope[]>]`: The definition of the delegated permissions exposed by the web API represented by this application registration. These delegated permissions may be requested by a client application, and may be granted by users or administrators during consent. Delegated permissions are sometimes referred to as OAuth 2.0 scopes.
        - `[AdminConsentDescription <String>]`: A description of the delegated permissions, intended to be read by an administrator granting the permission on behalf of all users. This text appears in tenant-wide admin consent experiences.
        - `[AdminConsentDisplayName <String>]`: The permission's title, intended to be read by an administrator granting the permission on behalf of all users.
        - `[Id <String>]`: Unique delegated permission identifier inside the collection of delegated permissions defined for a resource application.
        - `[IsEnabled <Boolean?>]`: When creating or updating a permission, this property must be set to true (which is the default). To delete a permission, this property must first be set to false.  At that point, in a subsequent call, the permission may be removed.
        - `[Origin <String>]`: 
        - `[Type <String>]`: Specifies whether this delegated permission should be considered safe for non-admin users to consent to on behalf of themselves, or whether an administrator should be required for consent to the permissions. This will be the default behavior, but each customer can choose to customize the behavior in their organization (by allowing, restricting or limiting user consent to this delegated permission.)
        - `[UserConsentDescription <String>]`: A description of the delegated permissions, intended to be read by a user granting the permission on their own behalf. This text appears in consent experiences where the user is consenting only on behalf of themselves.
        - `[UserConsentDisplayName <String>]`: A title for the permission, intended to be read by a user granting the permission on their own behalf. This text appears in consent experiences where the user is consenting only on behalf of themselves.
        - `[Value <String>]`: Specifies the value to include in the scp (scope) claim in access tokens. Must not exceed 120 characters in length. Allowed characters are : ! # $ % & ' ( ) * + , - . / : ;  =  ? @ [ ] ^ + _  {  } ~, as well as characters in the ranges 0-9, A-Z and a-z. Any other character, including the space character, are not allowed.
      - `[PreAuthorizedApplications <IMicrosoftGraphPreAuthorizedApplication1[]>]`: Lists the client applications that are pre-authorized with the specified delegated permissions to access this application's APIs. Users are not required to consent to any pre-authorized application (for the permissions specified). However, any additional permissions not listed in preAuthorizedApplications (requested through incremental consent for example) will require user consent.
        - `[AppId <String>]`: The unique identifier for the application.
        - `[PermissionIds <String[]>]`: 
      - `[RequestedAccessTokenVersion <Int32?>]`: Specifies the access token version expected by this resource. This changes the version and format of the JWT produced independent of the endpoint or client used to request the access token.  The endpoint used, v1.0 or v2.0, is chosen by the client and only impacts the version of id_tokens. Resources need to explicitly configure requestedAccessTokenVersion to indicate the supported access token format.  Possible values for requestedAccessTokenVersion are 1, 2, or null. If the value is null, this defaults to 1, which corresponds to the v1.0 endpoint.  If signInAudience on the application is configured as AzureADandPersonalMicrosoftAccount, the value for this property must be 2
    - `[AppId <String>]`: The unique identifier for the application that is assigned to an application by Azure AD. Not nullable. Read-only.
    - `[AppRoles <IMicrosoftGraphAppRole[]>]`: The collection of roles the application declares. With app role assignments, these roles can be assigned to users, groups, or other applications' service principals. Not nullable.
      - `[AllowedMemberTypes <String[]>]`: Specifies whether this app role can be assigned to users and groups (by setting to ['User']), to other application's (by setting to ['Application'], or both (by setting to ['User', 'Application']). App roles supporting assignment of other applications' service principals are also known as application permissions.
      - `[Description <String>]`: The description for the app role. This is displayed when the app role is being assigned and, if the app role functions as an application permission, during  consent experiences.
      - `[DisplayName <String>]`: Display name for the permission that appears in the app role assignment and consent experiences.
      - `[Id <String>]`: Unique role identifier inside the appRoles collection. When creating a new app role, a new Guid identifier must be provided.
      - `[IsEnabled <Boolean?>]`: When creating or updating an app role, this must be set to true (which is the default). To delete a role, this must first be set to false.  At that point, in a subsequent call, this role may be removed.
      - `[Origin <String>]`: Specifies if the app role is defined on the application object or on the servicePrincipal entity. Must not be included in any POST or PATCH requests. Read-only.
      - `[Value <String>]`: Specifies the value to include in the roles claim in ID tokens and access tokens authenticating an assigned user or service principal. Must not exceed 120 characters in length. Allowed characters are : ! # $ % & ' ( ) * + , - . / : ;  =  ? @ [ ] ^ + _  {  } ~, as well as characters in the ranges 0-9, A-Z and a-z. Any other character, including the space character, are not allowed.
    - `[ConnectorGroup <IMicrosoftGraphConnectorGroup>]`: connectorGroup
    - `[CreatedDateTime <DateTime?>]`: The date and time the application was registered. Read-only.
    - `[CreatedOnBehalfOf <IMicrosoftGraphDirectoryObject>]`: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[DeletedDateTime <DateTime?>]`: 
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
    - `[HomeRealmDiscoveryPolicies <IMicrosoftGraphHomeRealmDiscoveryPolicy1[]>]`: 
      - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
      - `[Definition <String[]>]`: A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.
      - `[IsOrganizationDefault <Boolean?>]`: If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.
      - `[Description <String>]`: Description for this policy.
      - `[DisplayName <String>]`: Display name for this policy.
      - `[DeletedDateTime <DateTime?>]`: 
      - `[Id <String>]`: Read-only.
    - `[IdentifierUris <String[]>]`: The URIs that identify the application within its Azure AD tenant, or within a verified custom domain if the application is multi-tenant. For more information see Application Objects and Service Principal Objects. The any operator is required for filter expressions on multi-valued properties. Not nullable.
    - `[Info <IMicrosoftGraphInformationalUrl>]`: informationalUrl
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[LogoUrl <String>]`: CDN URL to the application's logo, Read-only.
      - `[MarketingUrl <String>]`: Link to the application's marketing page. For example, https://www.contoso.com/app/marketing
      - `[PrivacyStatementUrl <String>]`: Link to the application's privacy statement. For example, https://www.contoso.com/app/privacy
      - `[SupportUrl <String>]`: Link to the application's support page. For example, https://www.contoso.com/app/support
      - `[TermsOfServiceUrl <String>]`: Link to the application's terms of service statement. For example, https://www.contoso.com/app/termsofservice
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
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
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
      - `[SingleSignOnSettings <IMicrosoftGraphOnPremisesPublishingSingleSignOn>]`: onPremisesPublishingSingleSignOn
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[KerberosSignOnSettings <IMicrosoftGraphKerberosSignOnSettings>]`: kerberosSignOnSettings
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[KerberosServicePrincipalName <String>]`: 
          - `[KerberosSignOnMappingAttributeType <String>]`: kerberosSignOnMappingAttributeType
        - `[SingleSignOnMode <String>]`: singleSignOnMode
      - `[UseAlternateUrlForTranslationAndRedirect <Boolean?>]`: 
      - `[VerifiedCustomDomainCertificatesMetadata <IMicrosoftGraphVerifiedCustomDomainCertificatesMetadata>]`: verifiedCustomDomainCertificatesMetadata
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[ExpiryDate <DateTime?>]`: 
        - `[IssueDate <DateTime?>]`: 
        - `[IssuerName <String>]`: 
        - `[SubjectName <String>]`: 
        - `[Thumbprint <String>]`: 
      - `[VerifiedCustomDomainKeyCredential <IMicrosoftGraphKeyCredential>]`: keyCredential
      - `[VerifiedCustomDomainPasswordCredential <IMicrosoftGraphPasswordCredential>]`: passwordCredential
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[CustomKeyIdentifier <Byte[]>]`: Do not use.
        - `[DisplayName <String>]`: Friendly name for the password. Optional.
        - `[EndDateTime <DateTime?>]`: The date and time at which the password expires represented using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Optional.
        - `[Hint <String>]`: Contains the first three characters of the password. Read-only.
        - `[KeyId <String>]`: The unique identifier for the password.
        - `[SecretText <String>]`: Read-only; Contains the strong passwords generated by Azure AD that are 16-64 characters in length. The generated password value is only returned during the initial POST request to addPassword. There is no way to retrieve this password in the future.
        - `[StartDateTime <DateTime?>]`: The date and time at which the password becomes valid. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Optional.
    - `[OptionalClaims <IMicrosoftGraphOptionalClaims>]`: optionalClaims
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AccessToken <IMicrosoftGraphOptionalClaim[]>]`: The optional claims returned in the JWT access token.
        - `[AdditionalProperties <String[]>]`: Additional properties of the claim. If a property exists in this collection, it modifies the behavior of the optional claim specified in the name property.
        - `[Essential <Boolean?>]`: If the value is true, the claim specified by the client is necessary to ensure a smooth authorization experience for the specific task requested by the end user. The default value is false.
        - `[Name <String>]`: The name of the optional claim.
        - `[Source <String>]`: The source (directory object) of the claim. There are predefined claims and user-defined claims from extension properties. If the source value is null, the claim is a predefined optional claim. If the source value is user, the value in the name property is the extension property from the user object.
      - `[IdToken <IMicrosoftGraphOptionalClaim[]>]`: The optional claims returned in the JWT ID token.
      - `[Saml2Token <IMicrosoftGraphOptionalClaim[]>]`: The optional claims returned in the SAML token.
    - `[Owners <IMicrosoftGraphDirectoryObject[]>]`: Directory objects that are owners of the application. The owners are a set of non-admin users who are allowed to modify this object. Requires version 2013-11-08 or newer. Read-only. Nullable.
    - `[ParentalControlSettings <IMicrosoftGraphParentalControlSettings>]`: parentalControlSettings
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[CountriesBlockedForMinors <String[]>]`: Specifies the two-letter ISO country codes. Access to the application will be blocked for minors from the countries specified in this list.
      - `[LegalAgeGroupRule <String>]`: Specifies the legal age group rule that applies to users of the app. Can be set to one of the following values: ValueDescriptionAllowDefault. Enforces the legal minimum. This means parental consent is required for minors in the European Union and Korea.RequireConsentForPrivacyServicesEnforces the user to specify date of birth to comply with COPPA rules. RequireConsentForMinorsRequires parental consent for ages below 18, regardless of country minor rules.RequireConsentForKidsRequires parental consent for ages below 14, regardless of country minor rules.BlockMinorsBlocks minors from using the app.
    - `[PasswordCredentials <IMicrosoftGraphPasswordCredential[]>]`: The collection of password credentials associated with the application. Not nullable.
    - `[PublicClient <IMicrosoftGraphPublicClientApplication>]`: publicClientApplication
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[RedirectUris <String[]>]`: Specifies the URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent.
    - `[PublisherDomain <String>]`: The verified publisher domain for the application. Read-only.
    - `[RequiredResourceAccess <IMicrosoftGraphRequiredResourceAccess[]>]`: Specifies resources that this application requires access to and the set of OAuth permission scopes and application roles that it needs under each of those resources. This pre-configuration of required resource access drives the consent experience. Not nullable.
      - `[ResourceAccess <IMicrosoftGraphResourceAccess[]>]`: The list of OAuth2.0 permission scopes and app roles that the application requires from the specified resource.
        - `[Id <String>]`: The unique identifier for one of the oauth2PermissionScopes or appRole instances that the resource application exposes.
        - `[Type <String>]`: Specifies whether the id property references an oauth2PermissionScopes or an appRole. Possible values are Scope or Role.
      - `[ResourceAppId <String>]`: The unique identifier for the resource that the application requires access to.  This should be equal to the appId declared on the target resource application.
    - `[SignInAudience <String>]`: Specifies what Microsoft accounts are supported for the current application. Supported values are:AzureADMyOrg: Users with a Microsoft work or school account in my organization’s Azure AD tenant (i.e. single tenant)AzureADMultipleOrgs: Users with a Microsoft work or school account in any organization’s Azure AD tenant (i.e. multi-tenant) AzureADandPersonalMicrosoftAccount: Users with a personal Microsoft account, or a work or school account in any organization’s Azure AD tenant
    - `[Synchronization <IMicrosoftGraphSynchronization>]`: synchronization
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[Jobs <IMicrosoftGraphSynchronizationJob[]>]`: 
        - `[Id <String>]`: Read-only.
        - `[Schedule <IMicrosoftGraphSynchronizationSchedule>]`: synchronizationSchedule
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Expiration <DateTime?>]`: 
          - `[Interval <TimeSpan?>]`: 
          - `[State <String>]`: synchronizationScheduleState
        - `[Schema <IMicrosoftGraphSynchronizationSchema>]`: synchronizationSchema
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Id <String>]`: Read-only.
          - `[Directories <IMicrosoftGraphDirectoryDefinition[]>]`: 
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
                - `[FlowNullValues <Boolean?>]`: 
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
          - `[SynchronizationRules <IMicrosoftGraphSynchronizationRule[]>]`: 
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
                - `[Source <IMicrosoftGraphAttributeMappingSource>]`: attributeMappingSource
                  - `[(Any) <Object>]`: This indicates any property can be added to this object.
                  - `[Expression <String>]`: 
                  - `[Name <String>]`: 
                  - `[Parameters <IMicrosoftGraphStringKeyAttributeMappingSourceValuePair[]>]`: 
                    - `[Key <String>]`: 
                    - `[Value <IMicrosoftGraphAttributeMappingSource>]`: attributeMappingSource
                  - `[Type <String>]`: attributeMappingSourceType
                - `[TargetAttributeName <String>]`: 
              - `[Enabled <Boolean?>]`: 
              - `[FlowTypes <String>]`: objectFlowTypes
              - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: 
              - `[Name <String>]`: 
              - `[Scope <IMicrosoftGraphFilter>]`: filter
                - `[(Any) <Object>]`: This indicates any property can be added to this object.
                - `[CategoryFilterGroups <IMicrosoftGraphFilterGroup[]>]`: 
                  - `[Clauses <IMicrosoftGraphFilterClause[]>]`: 
                    - `[OperatorName <String>]`: 
                    - `[SourceOperandName <String>]`: 
                    - `[TargetOperand <IMicrosoftGraphFilterOperand>]`: filterOperand
                      - `[(Any) <Object>]`: This indicates any property can be added to this object.
                      - `[Values <String[]>]`: 
                  - `[Name <String>]`: 
                - `[Groups <IMicrosoftGraphFilterGroup[]>]`: 
                - `[InputFilterGroups <IMicrosoftGraphFilterGroup[]>]`: 
              - `[SourceObjectName <String>]`: 
              - `[TargetObjectName <String>]`: 
            - `[Priority <Int32?>]`: 
            - `[SourceDirectoryName <String>]`: 
            - `[TargetDirectoryName <String>]`: 
          - `[Version <String>]`: 
        - `[Status <IMicrosoftGraphSynchronizationStatus>]`: synchronizationStatus
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Code <String>]`: synchronizationStatusCode
          - `[CountSuccessiveCompleteFailures <Int64?>]`: 
          - `[EscrowsPruned <Boolean?>]`: 
          - `[LastExecution <IMicrosoftGraphSynchronizationTaskExecution>]`: synchronizationTaskExecution
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[ActivityIdentifier <String>]`: 
            - `[CountEntitled <Int64?>]`: 
            - `[CountEntitledForProvisioning <Int64?>]`: 
            - `[CountEscrowed <Int64?>]`: 
            - `[CountEscrowedRaw <Int64?>]`: 
            - `[CountExported <Int64?>]`: 
            - `[CountExports <Int64?>]`: 
            - `[CountImported <Int64?>]`: 
            - `[CountImportedDeltas <Int64?>]`: 
            - `[CountImportedReferenceDeltas <Int64?>]`: 
            - `[Error <IMicrosoftGraphSynchronizationError>]`: synchronizationError
              - `[(Any) <Object>]`: This indicates any property can be added to this object.
              - `[Code <String>]`: 
              - `[Message <String>]`: 
              - `[TenantActionable <Boolean?>]`: 
            - `[State <String>]`: synchronizationTaskExecutionResult
            - `[TimeBegan <DateTime?>]`: 
            - `[TimeEnded <DateTime?>]`: 
          - `[LastSuccessfulExecution <IMicrosoftGraphSynchronizationTaskExecution>]`: synchronizationTaskExecution
          - `[LastSuccessfulExecutionWithExports <IMicrosoftGraphSynchronizationTaskExecution>]`: synchronizationTaskExecution
          - `[Progress <IMicrosoftGraphSynchronizationProgress[]>]`: 
            - `[CompletedUnits <Int64?>]`: 
            - `[ProgressObservationDateTime <DateTime?>]`: 
            - `[TotalUnits <Int64?>]`: 
            - `[Units <String>]`: 
          - `[Quarantine <IMicrosoftGraphSynchronizationQuarantine>]`: synchronizationQuarantine
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[CurrentBegan <DateTime?>]`: 
            - `[Error <IMicrosoftGraphSynchronizationError>]`: synchronizationError
            - `[NextAttempt <DateTime?>]`: 
            - `[Reason <String>]`: quarantineReason
            - `[SeriesBegan <DateTime?>]`: 
            - `[SeriesCount <Int64?>]`: 
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
      - `[Secrets <IMicrosoftGraphSynchronizationSecretKeyStringValuePair[]>]`: 
        - `[Key <String>]`: synchronizationSecret
        - `[Value <String>]`: 
      - `[Templates <IMicrosoftGraphSynchronizationTemplate[]>]`: 
        - `[Id <String>]`: Read-only.
        - `[ApplicationId <String>]`: 
        - `[Default <Boolean?>]`: 
        - `[Description <String>]`: 
        - `[Discoverable <Boolean?>]`: 
        - `[FactoryTag <String>]`: 
        - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: 
        - `[Schema <IMicrosoftGraphSynchronizationSchema>]`: synchronizationSchema
    - `[Tags <String[]>]`: Custom strings that can be used to categorize and identify the application. Not nullable.
    - `[TokenEncryptionKeyId <String>]`: Specifies the keyId of a public key from the keyCredentials collection. When configured, Azure AD encrypts all the tokens it emits by using the key this property points to. The application code that receives the encrypted token must use the matching private key to decrypt the token before it can be used for the signed-in user.
    - `[TokenIssuancePolicies <IMicrosoftGraphTokenIssuancePolicy1[]>]`: 
      - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
      - `[Definition <String[]>]`: A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.
      - `[IsOrganizationDefault <Boolean?>]`: If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.
      - `[Description <String>]`: Description for this policy.
      - `[DisplayName <String>]`: Display name for this policy.
      - `[DeletedDateTime <DateTime?>]`: 
      - `[Id <String>]`: Read-only.
    - `[TokenLifetimePolicies <IMicrosoftGraphTokenLifetimePolicy1[]>]`: 
      - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
      - `[Definition <String[]>]`: A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.
      - `[IsOrganizationDefault <Boolean?>]`: If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.
      - `[Description <String>]`: Description for this policy.
      - `[DisplayName <String>]`: Display name for this policy.
      - `[DeletedDateTime <DateTime?>]`: 
      - `[Id <String>]`: Read-only.
    - `[UniqueName <String>]`: 
    - `[Web <IMicrosoftGraphWebApplication1>]`: webApplication
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[HomePageUrl <String>]`: Home page or landing page of the application.
      - `[ImplicitGrantSettings <IMicrosoftGraphImplicitGrantSettings>]`: implicitGrantSettings
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[EnableAccessTokenIssuance <Boolean?>]`: Specifies whether this web application can request an access token using the OAuth 2.0 implicit flow.
        - `[EnableIdTokenIssuance <Boolean?>]`: Specifies whether this web application can request an ID token using the OAuth 2.0 implicit flow.
      - `[LogoutUrl <String>]`: Specifies the URL that will be used by Microsoft's authorization service to logout an user using front-channel, back-channel or SAML logout protocols.
      - `[Oauth2AllowImplicitFlow <Boolean?>]`: 
      - `[RedirectUris <String[]>]`: Specifies the URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent.
  - `[ConnectorGroupType <String>]`: connectorGroupType
  - `[IsDefault <Boolean?>]`: 
  - `[Members <IMicrosoftGraphConnector[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[ExternalIP <String>]`: 
    - `[MachineName <String>]`: 
    - `[MemberOf <IMicrosoftGraphConnectorGroup[]>]`: 
    - `[Status <String>]`: connectorStatus
  - `[Name <String>]`: 
  - `[Region <String>]`: connectorGroupRegion

CREATEDONBEHALFOF <IMicrosoftGraphDirectoryObject>: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[DeletedDateTime <DateTime?>]`: 

EXTENSIONPROPERTIES <IMicrosoftGraphExtensionProperty[]>: Read-only. Nullable.
  - `[DeletedDateTime <DateTime?>]`: 
  - `[Id <String>]`: Read-only.
  - `[AppDisplayName <String>]`: Display name of the application object on which this extension property is defined. Read-only.
  - `[DataType <String>]`: Specifies the data type of the value the extension property can hold. Following values are supported. Not nullable. Binary - 256 bytes maximumBooleanDateTime - Must be specified in ISO 8601 format. Will be stored in UTC.Integer - 32-bit value.LargeInteger - 64-bit value.String - 256 characters maximum
  - `[IsSyncedFromOnPremises <Boolean?>]`: Indicates if this extension property was sycned from onpremises directory using Azure AD Connect. Read-only.
  - `[Name <String>]`: Name of the extension property. Not nullable.
  - `[TargetObjects <String[]>]`: Following values are supported. Not nullable. UserGroupOrganizationDeviceApplication

HOMEREALMDISCOVERYPOLICIES <IMicrosoftGraphHomeRealmDiscoveryPolicy1[]>: .
  - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[DeletedDateTime <DateTime?>]`: 
  - `[Definition <String[]>]`: A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.
  - `[IsOrganizationDefault <Boolean?>]`: If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.
  - `[Description <String>]`: Description for this policy.
  - `[DisplayName <String>]`: Display name for this policy.
  - `[DeletedDateTime <DateTime?>]`: 
  - `[Id <String>]`: Read-only.

INFO <IMicrosoftGraphInformationalUrl>: informationalUrl
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[LogoUrl <String>]`: CDN URL to the application's logo, Read-only.
  - `[MarketingUrl <String>]`: Link to the application's marketing page. For example, https://www.contoso.com/app/marketing
  - `[PrivacyStatementUrl <String>]`: Link to the application's privacy statement. For example, https://www.contoso.com/app/privacy
  - `[SupportUrl <String>]`: Link to the application's support page. For example, https://www.contoso.com/app/support
  - `[TermsOfServiceUrl <String>]`: Link to the application's terms of service statement. For example, https://www.contoso.com/app/termsofservice

INPUTOBJECT <IApplicationsIdentity>: Identity Parameter
  - `[AppRoleAssignmentId <String>]`: key: id of appRoleAssignment
  - `[ApplicationId <String>]`: key: id of application
  - `[ApplicationTemplateId <String>]`: key: id of applicationTemplate
  - `[ClaimsMappingPolicyId <String>]`: key: id of claimsMappingPolicy
  - `[ConnectorGroupId <String>]`: key: id of connectorGroup
  - `[ConnectorId <String>]`: key: id of connector
  - `[DirectoryDefinitionId <String>]`: key: id of directoryDefinition
  - `[DirectoryObjectId <String>]`: key: id of directoryObject
  - `[EndpointId <String>]`: key: id of endpoint
  - `[ExtensionPropertyId <String>]`: key: id of extensionProperty
  - `[GroupId <String>]`: key: id of group
  - `[HomeRealmDiscoveryPolicyId <String>]`: key: id of homeRealmDiscoveryPolicy
  - `[LicenseDetailsId <String>]`: key: id of licenseDetails
  - `[OAuth2PermissionGrantId <String>]`: key: id of oAuth2PermissionGrant
  - `[OnPremisesAgentGroupId <String>]`: key: id of onPremisesAgentGroup
  - `[OnPremisesAgentGroupId1 <String>]`: key: id of onPremisesAgentGroup
  - `[OnPremisesAgentId <String>]`: key: id of onPremisesAgent
  - `[OnPremisesAgentId1 <String>]`: key: id of onPremisesAgent
  - `[OnPremisesPublishingProfileId <String>]`: key: id of onPremisesPublishingProfile
  - `[PublishedResourceId <String>]`: key: id of publishedResource
  - `[PublishedResourceId1 <String>]`: key: id of publishedResource
  - `[ServicePrincipalId <String>]`: key: id of servicePrincipal
  - `[SynchronizationJobId <String>]`: key: id of synchronizationJob
  - `[SynchronizationTemplateId <String>]`: key: id of synchronizationTemplate
  - `[TokenIssuancePolicyId <String>]`: key: id of tokenIssuancePolicy
  - `[TokenLifetimePolicyId <String>]`: key: id of tokenLifetimePolicy
  - `[UserId <String>]`: key: id of user

KEYCREDENTIALS <IMicrosoftGraphKeyCredential[]>: The collection of key credentials associated with the application Not nullable.
  - `[CustomKeyIdentifier <Byte[]>]`: Custom key identifier
  - `[DisplayName <String>]`: Friendly name for the key. Optional.
  - `[EndDateTime <DateTime?>]`: The date and time at which the credential expires.The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
  - `[Key <Byte[]>]`: Value for the key credential. Should be a base 64 encoded value.
  - `[KeyId <String>]`: The unique identifier (GUID) for the key.
  - `[StartDateTime <DateTime?>]`: The date and time at which the credential becomes valid.The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
  - `[Type <String>]`: The type of key credential; for example, 'Symmetric'.
  - `[Usage <String>]`: A string that describes the purpose for which the key can be used; for example, 'Verify'.

ONPREMISESPUBLISHING <IMicrosoftGraphOnPremisesPublishing>: onPremisesPublishing
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
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
  - `[SingleSignOnSettings <IMicrosoftGraphOnPremisesPublishingSingleSignOn>]`: onPremisesPublishingSingleSignOn
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[KerberosSignOnSettings <IMicrosoftGraphKerberosSignOnSettings>]`: kerberosSignOnSettings
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[KerberosServicePrincipalName <String>]`: 
      - `[KerberosSignOnMappingAttributeType <String>]`: kerberosSignOnMappingAttributeType
    - `[SingleSignOnMode <String>]`: singleSignOnMode
  - `[UseAlternateUrlForTranslationAndRedirect <Boolean?>]`: 
  - `[VerifiedCustomDomainCertificatesMetadata <IMicrosoftGraphVerifiedCustomDomainCertificatesMetadata>]`: verifiedCustomDomainCertificatesMetadata
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ExpiryDate <DateTime?>]`: 
    - `[IssueDate <DateTime?>]`: 
    - `[IssuerName <String>]`: 
    - `[SubjectName <String>]`: 
    - `[Thumbprint <String>]`: 
  - `[VerifiedCustomDomainKeyCredential <IMicrosoftGraphKeyCredential>]`: keyCredential
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[CustomKeyIdentifier <Byte[]>]`: Custom key identifier
    - `[DisplayName <String>]`: Friendly name for the key. Optional.
    - `[EndDateTime <DateTime?>]`: The date and time at which the credential expires.The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
    - `[Key <Byte[]>]`: Value for the key credential. Should be a base 64 encoded value.
    - `[KeyId <String>]`: The unique identifier (GUID) for the key.
    - `[StartDateTime <DateTime?>]`: The date and time at which the credential becomes valid.The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
    - `[Type <String>]`: The type of key credential; for example, 'Symmetric'.
    - `[Usage <String>]`: A string that describes the purpose for which the key can be used; for example, 'Verify'.
  - `[VerifiedCustomDomainPasswordCredential <IMicrosoftGraphPasswordCredential>]`: passwordCredential
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[CustomKeyIdentifier <Byte[]>]`: Do not use.
    - `[DisplayName <String>]`: Friendly name for the password. Optional.
    - `[EndDateTime <DateTime?>]`: The date and time at which the password expires represented using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Optional.
    - `[Hint <String>]`: Contains the first three characters of the password. Read-only.
    - `[KeyId <String>]`: The unique identifier for the password.
    - `[SecretText <String>]`: Read-only; Contains the strong passwords generated by Azure AD that are 16-64 characters in length. The generated password value is only returned during the initial POST request to addPassword. There is no way to retrieve this password in the future.
    - `[StartDateTime <DateTime?>]`: The date and time at which the password becomes valid. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Optional.

OPTIONALCLAIMS <IMicrosoftGraphOptionalClaims>: optionalClaims
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AccessToken <IMicrosoftGraphOptionalClaim[]>]`: The optional claims returned in the JWT access token.
    - `[AdditionalProperties <String[]>]`: Additional properties of the claim. If a property exists in this collection, it modifies the behavior of the optional claim specified in the name property.
    - `[Essential <Boolean?>]`: If the value is true, the claim specified by the client is necessary to ensure a smooth authorization experience for the specific task requested by the end user. The default value is false.
    - `[Name <String>]`: The name of the optional claim.
    - `[Source <String>]`: The source (directory object) of the claim. There are predefined claims and user-defined claims from extension properties. If the source value is null, the claim is a predefined optional claim. If the source value is user, the value in the name property is the extension property from the user object.
  - `[IdToken <IMicrosoftGraphOptionalClaim[]>]`: The optional claims returned in the JWT ID token.
  - `[Saml2Token <IMicrosoftGraphOptionalClaim[]>]`: The optional claims returned in the SAML token.

OWNERS <IMicrosoftGraphDirectoryObject[]>: Directory objects that are owners of the application. The owners are a set of non-admin users who are allowed to modify this object. Requires version 2013-11-08 or newer. Read-only. Nullable.
  - `[Id <String>]`: Read-only.
  - `[DeletedDateTime <DateTime?>]`: 

PARENTALCONTROLSETTINGS <IMicrosoftGraphParentalControlSettings>: parentalControlSettings
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CountriesBlockedForMinors <String[]>]`: Specifies the two-letter ISO country codes. Access to the application will be blocked for minors from the countries specified in this list.
  - `[LegalAgeGroupRule <String>]`: Specifies the legal age group rule that applies to users of the app. Can be set to one of the following values: ValueDescriptionAllowDefault. Enforces the legal minimum. This means parental consent is required for minors in the European Union and Korea.RequireConsentForPrivacyServicesEnforces the user to specify date of birth to comply with COPPA rules. RequireConsentForMinorsRequires parental consent for ages below 18, regardless of country minor rules.RequireConsentForKidsRequires parental consent for ages below 14, regardless of country minor rules.BlockMinorsBlocks minors from using the app.

PASSWORDCREDENTIALS <IMicrosoftGraphPasswordCredential[]>: The collection of password credentials associated with the application. Not nullable.
  - `[CustomKeyIdentifier <Byte[]>]`: Do not use.
  - `[DisplayName <String>]`: Friendly name for the password. Optional.
  - `[EndDateTime <DateTime?>]`: The date and time at which the password expires represented using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Optional.
  - `[Hint <String>]`: Contains the first three characters of the password. Read-only.
  - `[KeyId <String>]`: The unique identifier for the password.
  - `[SecretText <String>]`: Read-only; Contains the strong passwords generated by Azure AD that are 16-64 characters in length. The generated password value is only returned during the initial POST request to addPassword. There is no way to retrieve this password in the future.
  - `[StartDateTime <DateTime?>]`: The date and time at which the password becomes valid. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Optional.

PUBLICCLIENT <IMicrosoftGraphPublicClientApplication>: publicClientApplication
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[RedirectUris <String[]>]`: Specifies the URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent.

REQUIREDRESOURCEACCESS <IMicrosoftGraphRequiredResourceAccess[]>: Specifies resources that this application requires access to and the set of OAuth permission scopes and application roles that it needs under each of those resources. This pre-configuration of required resource access drives the consent experience. Not nullable.
  - `[ResourceAccess <IMicrosoftGraphResourceAccess[]>]`: The list of OAuth2.0 permission scopes and app roles that the application requires from the specified resource.
    - `[Id <String>]`: The unique identifier for one of the oauth2PermissionScopes or appRole instances that the resource application exposes.
    - `[Type <String>]`: Specifies whether the id property references an oauth2PermissionScopes or an appRole. Possible values are Scope or Role.
  - `[ResourceAppId <String>]`: The unique identifier for the resource that the application requires access to.  This should be equal to the appId declared on the target resource application.

SYNCHRONIZATION <IMicrosoftGraphSynchronization>: synchronization
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[Jobs <IMicrosoftGraphSynchronizationJob[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Schedule <IMicrosoftGraphSynchronizationSchedule>]`: synchronizationSchedule
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Expiration <DateTime?>]`: 
      - `[Interval <TimeSpan?>]`: 
      - `[State <String>]`: synchronizationScheduleState
    - `[Schema <IMicrosoftGraphSynchronizationSchema>]`: synchronizationSchema
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[Directories <IMicrosoftGraphDirectoryDefinition[]>]`: 
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
            - `[FlowNullValues <Boolean?>]`: 
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
      - `[SynchronizationRules <IMicrosoftGraphSynchronizationRule[]>]`: 
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
            - `[Source <IMicrosoftGraphAttributeMappingSource>]`: attributeMappingSource
              - `[(Any) <Object>]`: This indicates any property can be added to this object.
              - `[Expression <String>]`: 
              - `[Name <String>]`: 
              - `[Parameters <IMicrosoftGraphStringKeyAttributeMappingSourceValuePair[]>]`: 
                - `[Key <String>]`: 
                - `[Value <IMicrosoftGraphAttributeMappingSource>]`: attributeMappingSource
              - `[Type <String>]`: attributeMappingSourceType
            - `[TargetAttributeName <String>]`: 
          - `[Enabled <Boolean?>]`: 
          - `[FlowTypes <String>]`: objectFlowTypes
          - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: 
          - `[Name <String>]`: 
          - `[Scope <IMicrosoftGraphFilter>]`: filter
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[CategoryFilterGroups <IMicrosoftGraphFilterGroup[]>]`: 
              - `[Clauses <IMicrosoftGraphFilterClause[]>]`: 
                - `[OperatorName <String>]`: 
                - `[SourceOperandName <String>]`: 
                - `[TargetOperand <IMicrosoftGraphFilterOperand>]`: filterOperand
                  - `[(Any) <Object>]`: This indicates any property can be added to this object.
                  - `[Values <String[]>]`: 
              - `[Name <String>]`: 
            - `[Groups <IMicrosoftGraphFilterGroup[]>]`: 
            - `[InputFilterGroups <IMicrosoftGraphFilterGroup[]>]`: 
          - `[SourceObjectName <String>]`: 
          - `[TargetObjectName <String>]`: 
        - `[Priority <Int32?>]`: 
        - `[SourceDirectoryName <String>]`: 
        - `[TargetDirectoryName <String>]`: 
      - `[Version <String>]`: 
    - `[Status <IMicrosoftGraphSynchronizationStatus>]`: synchronizationStatus
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Code <String>]`: synchronizationStatusCode
      - `[CountSuccessiveCompleteFailures <Int64?>]`: 
      - `[EscrowsPruned <Boolean?>]`: 
      - `[LastExecution <IMicrosoftGraphSynchronizationTaskExecution>]`: synchronizationTaskExecution
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[ActivityIdentifier <String>]`: 
        - `[CountEntitled <Int64?>]`: 
        - `[CountEntitledForProvisioning <Int64?>]`: 
        - `[CountEscrowed <Int64?>]`: 
        - `[CountEscrowedRaw <Int64?>]`: 
        - `[CountExported <Int64?>]`: 
        - `[CountExports <Int64?>]`: 
        - `[CountImported <Int64?>]`: 
        - `[CountImportedDeltas <Int64?>]`: 
        - `[CountImportedReferenceDeltas <Int64?>]`: 
        - `[Error <IMicrosoftGraphSynchronizationError>]`: synchronizationError
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Code <String>]`: 
          - `[Message <String>]`: 
          - `[TenantActionable <Boolean?>]`: 
        - `[State <String>]`: synchronizationTaskExecutionResult
        - `[TimeBegan <DateTime?>]`: 
        - `[TimeEnded <DateTime?>]`: 
      - `[LastSuccessfulExecution <IMicrosoftGraphSynchronizationTaskExecution>]`: synchronizationTaskExecution
      - `[LastSuccessfulExecutionWithExports <IMicrosoftGraphSynchronizationTaskExecution>]`: synchronizationTaskExecution
      - `[Progress <IMicrosoftGraphSynchronizationProgress[]>]`: 
        - `[CompletedUnits <Int64?>]`: 
        - `[ProgressObservationDateTime <DateTime?>]`: 
        - `[TotalUnits <Int64?>]`: 
        - `[Units <String>]`: 
      - `[Quarantine <IMicrosoftGraphSynchronizationQuarantine>]`: synchronizationQuarantine
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[CurrentBegan <DateTime?>]`: 
        - `[Error <IMicrosoftGraphSynchronizationError>]`: synchronizationError
        - `[NextAttempt <DateTime?>]`: 
        - `[Reason <String>]`: quarantineReason
        - `[SeriesBegan <DateTime?>]`: 
        - `[SeriesCount <Int64?>]`: 
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
  - `[Secrets <IMicrosoftGraphSynchronizationSecretKeyStringValuePair[]>]`: 
    - `[Key <String>]`: synchronizationSecret
    - `[Value <String>]`: 
  - `[Templates <IMicrosoftGraphSynchronizationTemplate[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[ApplicationId <String>]`: 
    - `[Default <Boolean?>]`: 
    - `[Description <String>]`: 
    - `[Discoverable <Boolean?>]`: 
    - `[FactoryTag <String>]`: 
    - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: 
    - `[Schema <IMicrosoftGraphSynchronizationSchema>]`: synchronizationSchema

TOKENISSUANCEPOLICIES <IMicrosoftGraphTokenIssuancePolicy1[]>: .
  - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[DeletedDateTime <DateTime?>]`: 
  - `[Definition <String[]>]`: A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.
  - `[IsOrganizationDefault <Boolean?>]`: If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.
  - `[Description <String>]`: Description for this policy.
  - `[DisplayName <String>]`: Display name for this policy.
  - `[DeletedDateTime <DateTime?>]`: 
  - `[Id <String>]`: Read-only.

TOKENLIFETIMEPOLICIES <IMicrosoftGraphTokenLifetimePolicy1[]>: .
  - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[DeletedDateTime <DateTime?>]`: 
  - `[Definition <String[]>]`: A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.
  - `[IsOrganizationDefault <Boolean?>]`: If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.
  - `[Description <String>]`: Description for this policy.
  - `[DisplayName <String>]`: Display name for this policy.
  - `[DeletedDateTime <DateTime?>]`: 
  - `[Id <String>]`: Read-only.

WEB <IMicrosoftGraphWebApplication1>: webApplication
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[HomePageUrl <String>]`: Home page or landing page of the application.
  - `[ImplicitGrantSettings <IMicrosoftGraphImplicitGrantSettings>]`: implicitGrantSettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[EnableAccessTokenIssuance <Boolean?>]`: Specifies whether this web application can request an access token using the OAuth 2.0 implicit flow.
    - `[EnableIdTokenIssuance <Boolean?>]`: Specifies whether this web application can request an ID token using the OAuth 2.0 implicit flow.
  - `[LogoutUrl <String>]`: Specifies the URL that will be used by Microsoft's authorization service to logout an user using front-channel, back-channel or SAML logout protocols.
  - `[Oauth2AllowImplicitFlow <Boolean?>]`: 
  - `[RedirectUris <String[]>]`: Specifies the URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent.

## RELATED LINKS

