---
external help file:
Module Name: Microsoft.Graph.Applications
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.applications/update-mgapplication
schema: 2.0.0
---

# Update-MgApplication

## SYNOPSIS
Update application

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgApplication -ApplicationId <String> [-AdditionalProperties <Hashtable>]
 [-Api <IMicrosoftGraphApiApplication1>] [-AppId <String>]
 [-AppManagementPolicies <IMicrosoftGraphAppManagementPolicy[]>] [-AppRoles <IMicrosoftGraphAppRole[]>]
 [-Certification <IMicrosoftGraphCertification>] [-ConnectorGroup <IMicrosoftGraphConnectorGroup>]
 [-CreatedDateTime <DateTime>] [-CreatedOnBehalfOf <IMicrosoftGraphDirectoryObject>]
 [-DefaultRedirectUri <String>] [-DeletedDateTime <DateTime>] [-Description <String>]
 [-DisabledByMicrosoftStatus <String>] [-DisplayName <String>]
 [-ExtensionProperties <IMicrosoftGraphExtensionProperty[]>]
 [-FederatedIdentityCredentials <IMicrosoftGraphFederatedIdentityCredential[]>]
 [-GroupMembershipClaims <String>] [-HomeRealmDiscoveryPolicies <IMicrosoftGraphHomeRealmDiscoveryPolicy1[]>]
 [-Id <String>] [-IdentifierUris <String[]>] [-Info <IMicrosoftGraphInformationalUrl>]
 [-IsDeviceOnlyAuthSupported] [-IsFallbackPublicClient] [-KeyCredentials <IMicrosoftGraphKeyCredential[]>]
 [-LogoInputFile <String>] [-Notes <String>] [-OnPremisesPublishing <IMicrosoftGraphOnPremisesPublishing>]
 [-OptionalClaims <IMicrosoftGraphOptionalClaims>] [-Owners <IMicrosoftGraphDirectoryObject[]>]
 [-ParentalControlSettings <IMicrosoftGraphParentalControlSettings>]
 [-PasswordCredentials <IMicrosoftGraphPasswordCredential[]>]
 [-PublicClient <IMicrosoftGraphPublicClientApplication>] [-PublisherDomain <String>]
 [-RequiredResourceAccess <IMicrosoftGraphRequiredResourceAccess[]>] [-SamlMetadataUrl <String>]
 [-ServiceManagementReference <String>] [-SignInAudience <String>] [-Spa <IMicrosoftGraphSpaApplication>]
 [-Synchronization <IMicrosoftGraphSynchronization>] [-Tags <String[]>] [-TokenEncryptionKeyId <String>]
 [-TokenIssuancePolicies <IMicrosoftGraphTokenIssuancePolicy1[]>]
 [-TokenLifetimePolicies <IMicrosoftGraphTokenLifetimePolicy1[]>] [-UniqueName <String>]
 [-VerifiedPublisher <IMicrosoftGraphVerifiedPublisher>] [-Web <IMicrosoftGraphWebApplication1>]
 [-Windows <IMicrosoftGraphWindowsApplication>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
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
 [-Api <IMicrosoftGraphApiApplication1>] [-AppId <String>]
 [-AppManagementPolicies <IMicrosoftGraphAppManagementPolicy[]>] [-AppRoles <IMicrosoftGraphAppRole[]>]
 [-Certification <IMicrosoftGraphCertification>] [-ConnectorGroup <IMicrosoftGraphConnectorGroup>]
 [-CreatedDateTime <DateTime>] [-CreatedOnBehalfOf <IMicrosoftGraphDirectoryObject>]
 [-DefaultRedirectUri <String>] [-DeletedDateTime <DateTime>] [-Description <String>]
 [-DisabledByMicrosoftStatus <String>] [-DisplayName <String>]
 [-ExtensionProperties <IMicrosoftGraphExtensionProperty[]>]
 [-FederatedIdentityCredentials <IMicrosoftGraphFederatedIdentityCredential[]>]
 [-GroupMembershipClaims <String>] [-HomeRealmDiscoveryPolicies <IMicrosoftGraphHomeRealmDiscoveryPolicy1[]>]
 [-Id <String>] [-IdentifierUris <String[]>] [-Info <IMicrosoftGraphInformationalUrl>]
 [-IsDeviceOnlyAuthSupported] [-IsFallbackPublicClient] [-KeyCredentials <IMicrosoftGraphKeyCredential[]>]
 [-LogoInputFile <String>] [-Notes <String>] [-OnPremisesPublishing <IMicrosoftGraphOnPremisesPublishing>]
 [-OptionalClaims <IMicrosoftGraphOptionalClaims>] [-Owners <IMicrosoftGraphDirectoryObject[]>]
 [-ParentalControlSettings <IMicrosoftGraphParentalControlSettings>]
 [-PasswordCredentials <IMicrosoftGraphPasswordCredential[]>]
 [-PublicClient <IMicrosoftGraphPublicClientApplication>] [-PublisherDomain <String>]
 [-RequiredResourceAccess <IMicrosoftGraphRequiredResourceAccess[]>] [-SamlMetadataUrl <String>]
 [-ServiceManagementReference <String>] [-SignInAudience <String>] [-Spa <IMicrosoftGraphSpaApplication>]
 [-Synchronization <IMicrosoftGraphSynchronization>] [-Tags <String[]>] [-TokenEncryptionKeyId <String>]
 [-TokenIssuancePolicies <IMicrosoftGraphTokenIssuancePolicy1[]>]
 [-TokenLifetimePolicies <IMicrosoftGraphTokenLifetimePolicy1[]>] [-UniqueName <String>]
 [-VerifiedPublisher <IMicrosoftGraphVerifiedPublisher>] [-Web <IMicrosoftGraphWebApplication1>]
 [-Windows <IMicrosoftGraphWindowsApplication>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update application

## EXAMPLES

### Example 1: Update an application
```powershell
Update-MgApplication `
  -ApplicationId 'f6b30057-7095-4e2c-89f8-224149f591b7' `
  -DisplayName 'Testing App'
```

This example updates the specified application's display name.

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
To construct, please use Get-Help -Online and see NOTES section for API properties and create a hash table.

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
The unique identifier for the application that is assigned by Azure AD.
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

### -AppManagementPolicies
The appManagementPolicy applied to this application.
To construct, please use Get-Help -Online and see NOTES section for APPMANAGEMENTPOLICIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAppManagementPolicy[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AppRoles
The collection of roles assigned to the application.
With app role assignments, these roles can be assigned to users, groups, or service principals associated with other applications.
Not nullable.
To construct, please use Get-Help -Online and see NOTES section for APPROLES properties and create a hash table.

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
application
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

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

### -Certification
certification
To construct, please use Get-Help -Online and see NOTES section for CERTIFICATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCertification
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ConnectorGroup
connectorGroup
To construct, please use Get-Help -Online and see NOTES section for CONNECTORGROUP properties and create a hash table.

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
The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
Read-only.
Supports $filter (eq, ne, not, ge, le, in, and eq on null values) and $orderBy.

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
directoryObject
To construct, please use Get-Help -Online and see NOTES section for CREATEDONBEHALFOF properties and create a hash table.

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

### -DefaultRedirectUri
The default redirect URI.
If specified and there is no explicit redirect URI in the sign-in request for SAML and OIDC flows, Azure AD sends the token to this redirect URI.
Azure AD also sends the token to this default URI in SAML IdP-initiated single sign-on.
The value must match one of the configured redirect URIs for the application.

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

### -DeletedDateTime
Date and time when this object was deleted.
Always null when the object hasn't been deleted.

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
Free text field to provide a description of the application object to end users.
The maximum allowed size is 1024 characters.
Returned by default.
Supports $filter (eq, ne, not, ge, le, startsWith) and $search.

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

### -DisabledByMicrosoftStatus
Specifies whether Microsoft has disabled the registered application.
Possible values are: null (default value), NotDisabled, and DisabledDueToViolationOfServicesAgreement (reasons may include suspicious, abusive, or malicious activity, or a violation of the Microsoft Services Agreement).
Supports $filter (eq, ne, not).

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
Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values), $search, and $orderBy.

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
Supports $expand and $filter (eq when counting empty collections).
To construct, please use Get-Help -Online and see NOTES section for EXTENSIONPROPERTIES properties and create a hash table.

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

### -FederatedIdentityCredentials
Federated identities for applications.
Supports $expand and $filter (eq when counting empty collections).
To construct, please use Get-Help -Online and see NOTES section for FEDERATEDIDENTITYCREDENTIALS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphFederatedIdentityCredential[]
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
To set this attribute, use one of the following string values: None, SecurityGroup (for security groups and Azure AD roles), All (this gets all security groups, distribution groups, and Azure AD directory roles that the signed-in user is a member of).

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
To construct, please use Get-Help -Online and see NOTES section for HOMEREALMDISCOVERYPOLICIES properties and create a hash table.

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

### -IdentifierUris
Also known as App ID URI, this value is set when an application is used as a resource app.
The identifierUris acts as the prefix for the scopes you'll reference in your API's code, and it must be globally unique.
You can use the default value provided, which is in the form api://\<application-client-id\>, or specify a more readable URI like https://contoso.com/api.
For more information on valid identifierUris patterns and best practices, see Azure AD application registration security best practices.
Not nullable.
Supports $filter (eq, ne, ge, le, startsWith).

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
To construct, please use Get-Help -Online and see NOTES section for INFO properties and create a hash table.

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
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

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
Specifies whether this application supports device authentication without a user.
The default is false.

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
The default value is false which means the fallback application type is confidential client such as a web app.
There are certain scenarios where Azure AD cannot determine the client application type.
For example, the ROPC flow where the application is configured without specifying a redirect URI.
In those cases Azure AD interprets the application type based on the value of this property.

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
The collection of key credentials associated with the application.
Not nullable.
Supports $filter (eq, not, ge, le).
To construct, please use Get-Help -Online and see NOTES section for KEYCREDENTIALS properties and create a hash table.

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
Notes relevant for the management of the application.

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
To construct, please use Get-Help -Online and see NOTES section for ONPREMISESPUBLISHING properties and create a hash table.

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
To construct, please use Get-Help -Online and see NOTES section for OPTIONALCLAIMS properties and create a hash table.

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
Read-only.
Nullable.
Supports $expand.
To construct, please use Get-Help -Online and see NOTES section for OWNERS properties and create a hash table.

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
To construct, please use Get-Help -Online and see NOTES section for PARENTALCONTROLSETTINGS properties and create a hash table.

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
To construct, please use Get-Help -Online and see NOTES section for PASSWORDCREDENTIALS properties and create a hash table.

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
To construct, please use Get-Help -Online and see NOTES section for PUBLICCLIENT properties and create a hash table.

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
Supports $filter (eq, ne, ge, le, startsWith).

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
Specifies the resources that the application needs to access.
This property also specifies the set of delegated permissions and application roles that it needs for each of those resources.
This configuration of access to the required resources drives the consent experience.
No more than 50 resource services (APIs) can be configured.
Beginning mid-October 2021, the total number of required permissions must not exceed 400.
Not nullable.
Supports $filter (eq, not, ge, le).
To construct, please use Get-Help -Online and see NOTES section for REQUIREDRESOURCEACCESS properties and create a hash table.

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

### -SamlMetadataUrl
The URL where the service exposes SAML metadata for federation.
This property is valid only for single-tenant applications.
Nullable.

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

### -ServiceManagementReference
References application or service contact information from a Service or Asset Management database.
Nullable.

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

### -SignInAudience
Specifies the Microsoft accounts that are supported for the current application.
The possible values are: AzureADMyOrg, AzureADMultipleOrgs, AzureADandPersonalMicrosoftAccount (default), and PersonalMicrosoftAccount.
See more in the table below.
Supports $filter (eq, ne, not).

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

### -Spa
spaApplication
To construct, please use Get-Help -Online and see NOTES section for SPA properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSpaApplication
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
To construct, please use Get-Help -Online and see NOTES section for SYNCHRONIZATION properties and create a hash table.

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
Not nullable.Supports $filter (eq, not, ge, le, startsWith).

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
To construct, please use Get-Help -Online and see NOTES section for TOKENISSUANCEPOLICIES properties and create a hash table.

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
The tokenLifetimePolicies assigned to this application.
Supports $expand.
To construct, please use Get-Help -Online and see NOTES section for TOKENLIFETIMEPOLICIES properties and create a hash table.

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
The unique identifier that can be assigned to an application as an alternative identifier.
Immutable.
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

### -VerifiedPublisher
verifiedPublisher
To construct, please use Get-Help -Online and see NOTES section for VERIFIEDPUBLISHER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphVerifiedPublisher
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
To construct, please use Get-Help -Online and see NOTES section for WEB properties and create a hash table.

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

### -Windows
windowsApplication
To construct, please use Get-Help -Online and see NOTES section for WINDOWS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsApplication
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
    - `[Type <String>]`: The possible values are: User and Admin. Specifies whether this delegated permission should be considered safe for non-admin users to consent to on behalf of themselves, or whether an administrator consent should always be required. While Microsoft Graph defines the default consent requirement for each permission, the tenant administrator may override the behavior in their organization (by allowing, restricting, or limiting user consent to this delegated permission). For more information, see Configure how users consent to applications.
    - `[UserConsentDescription <String>]`: A description of the delegated permissions, intended to be read by a user granting the permission on their own behalf. This text appears in consent experiences where the user is consenting only on behalf of themselves.
    - `[UserConsentDisplayName <String>]`: A title for the permission, intended to be read by a user granting the permission on their own behalf. This text appears in consent experiences where the user is consenting only on behalf of themselves.
    - `[Value <String>]`: Specifies the value to include in the scp (scope) claim in access tokens. Must not exceed 120 characters in length. Allowed characters are : ! # $ % & ' ( ) * + , - . / : ;  =  ? @ [ ] ^ + _  {  } ~, as well as characters in the ranges 0-9, A-Z and a-z. Any other character, including the space character, are not allowed. May not begin with ..
  - `[PreAuthorizedApplications <IMicrosoftGraphPreAuthorizedApplication1[]>]`: Lists the client applications that are pre-authorized with the specified delegated permissions to access this application's APIs. Users are not required to consent to any pre-authorized application (for the permissions specified). However, any additional permissions not listed in preAuthorizedApplications (requested through incremental consent for example) will require user consent.
    - `[AppId <String>]`: The unique identifier for the client application.
    - `[PermissionIds <String[]>]`: The unique identifier for the scopes the client application is granted.
  - `[RequestedAccessTokenVersion <Int32?>]`: Specifies the access token version expected by this resource. This changes the version and format of the JWT produced independent of the endpoint or client used to request the access token.  The endpoint used, v1.0 or v2.0, is chosen by the client and only impacts the version of id_tokens. Resources need to explicitly configure requestedAccessTokenVersion to indicate the supported access token format.  Possible values for requestedAccessTokenVersion are 1, 2, or null. If the value is null, this defaults to 1, which corresponds to the v1.0 endpoint.  If signInAudience on the application is configured as AzureADandPersonalMicrosoftAccount, the value for this property must be 2

APPMANAGEMENTPOLICIES <IMicrosoftGraphAppManagementPolicy[]>: The appManagementPolicy applied to this application.
  - `[Description <String>]`: Description for this policy. Required.
  - `[DisplayName <String>]`: Display name for this policy. Required.
  - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
  - `[Id <String>]`: 
  - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[Id <String>]`: 
    - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
  - `[IsEnabled <Boolean?>]`: 
  - `[Restrictions <IMicrosoftGraphAppManagementConfiguration>]`: appManagementConfiguration
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[KeyCredentials <IMicrosoftGraphKeyCredentialConfiguration[]>]`: Collection of keyCredential restrictions settings to be applied to an application or service principal.
      - `[MaxLifetime <TimeSpan?>]`: 
      - `[RestrictForAppsCreatedAfterDateTime <DateTime?>]`: Timestamp when the policy is enforced for all apps created on or after the specified date. For existing applications, the enforcement date would be back dated. To apply to all applications regardless of their creation date, this property would be null. Nullable.
      - `[RestrictionType <String>]`: appKeyCredentialRestrictionType
    - `[PasswordCredentials <IMicrosoftGraphPasswordCredentialConfiguration[]>]`: Collection of password restrictions settings to be applied to an application or service principal.
      - `[MaxLifetime <TimeSpan?>]`: 
      - `[RestrictForAppsCreatedAfterDateTime <DateTime?>]`: Enforces the policy for an app created on or after the enforcement date. For existing applications, the enforcement date would be backdated. To apply to all applications, this date would be null.
      - `[RestrictionType <String>]`: appCredentialRestrictionType

APPROLES <IMicrosoftGraphAppRole[]>: The collection of roles assigned to the application. With app role assignments, these roles can be assigned to users, groups, or service principals associated with other applications. Not nullable.
  - `[AllowedMemberTypes <String[]>]`: Specifies whether this app role can be assigned to users and groups (by setting to ['User']), to other application's (by setting to ['Application'], or both (by setting to ['User', 'Application']). App roles supporting assignment to other applications' service principals are also known as application permissions. The 'Application' value is only supported for app roles defined on application entities.
  - `[Description <String>]`: The description for the app role. This is displayed when the app role is being assigned and, if the app role functions as an application permission, during  consent experiences.
  - `[DisplayName <String>]`: Display name for the permission that appears in the app role assignment and consent experiences.
  - `[Id <String>]`: Unique role identifier inside the appRoles collection. When creating a new app role, a new GUID identifier must be provided.
  - `[IsEnabled <Boolean?>]`: When creating or updating an app role, this must be set to true (which is the default). To delete a role, this must first be set to false.  At that point, in a subsequent call, this role may be removed.
  - `[Origin <String>]`: Specifies if the app role is defined on the application object or on the servicePrincipal entity. Must not be included in any POST or PATCH requests. Read-only.
  - `[Value <String>]`: Specifies the value to include in the roles claim in ID tokens and access tokens authenticating an assigned user or service principal. Must not exceed 120 characters in length. Allowed characters are : ! # $ % & ' ( ) * + , - . / : ;  =  ? @ [ ] ^ + _  {  } ~, as well as characters in the ranges 0-9, A-Z and a-z. Any other character, including the space character, are not allowed. May not begin with ..

BODYPARAMETER <IMicrosoftGraphApplication>: application
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
  - `[Id <String>]`: 
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
      - `[Type <String>]`: The possible values are: User and Admin. Specifies whether this delegated permission should be considered safe for non-admin users to consent to on behalf of themselves, or whether an administrator consent should always be required. While Microsoft Graph defines the default consent requirement for each permission, the tenant administrator may override the behavior in their organization (by allowing, restricting, or limiting user consent to this delegated permission). For more information, see Configure how users consent to applications.
      - `[UserConsentDescription <String>]`: A description of the delegated permissions, intended to be read by a user granting the permission on their own behalf. This text appears in consent experiences where the user is consenting only on behalf of themselves.
      - `[UserConsentDisplayName <String>]`: A title for the permission, intended to be read by a user granting the permission on their own behalf. This text appears in consent experiences where the user is consenting only on behalf of themselves.
      - `[Value <String>]`: Specifies the value to include in the scp (scope) claim in access tokens. Must not exceed 120 characters in length. Allowed characters are : ! # $ % & ' ( ) * + , - . / : ;  =  ? @ [ ] ^ + _  {  } ~, as well as characters in the ranges 0-9, A-Z and a-z. Any other character, including the space character, are not allowed. May not begin with ..
    - `[PreAuthorizedApplications <IMicrosoftGraphPreAuthorizedApplication1[]>]`: Lists the client applications that are pre-authorized with the specified delegated permissions to access this application's APIs. Users are not required to consent to any pre-authorized application (for the permissions specified). However, any additional permissions not listed in preAuthorizedApplications (requested through incremental consent for example) will require user consent.
      - `[AppId <String>]`: The unique identifier for the client application.
      - `[PermissionIds <String[]>]`: The unique identifier for the scopes the client application is granted.
    - `[RequestedAccessTokenVersion <Int32?>]`: Specifies the access token version expected by this resource. This changes the version and format of the JWT produced independent of the endpoint or client used to request the access token.  The endpoint used, v1.0 or v2.0, is chosen by the client and only impacts the version of id_tokens. Resources need to explicitly configure requestedAccessTokenVersion to indicate the supported access token format.  Possible values for requestedAccessTokenVersion are 1, 2, or null. If the value is null, this defaults to 1, which corresponds to the v1.0 endpoint.  If signInAudience on the application is configured as AzureADandPersonalMicrosoftAccount, the value for this property must be 2
  - `[AppId <String>]`: The unique identifier for the application that is assigned by Azure AD. Not nullable. Read-only.
  - `[AppManagementPolicies <IMicrosoftGraphAppManagementPolicy[]>]`: The appManagementPolicy applied to this application.
    - `[Description <String>]`: Description for this policy. Required.
    - `[DisplayName <String>]`: Display name for this policy. Required.
    - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
    - `[Id <String>]`: 
    - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
      - `[Id <String>]`: 
      - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
    - `[IsEnabled <Boolean?>]`: 
    - `[Restrictions <IMicrosoftGraphAppManagementConfiguration>]`: appManagementConfiguration
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[KeyCredentials <IMicrosoftGraphKeyCredentialConfiguration[]>]`: Collection of keyCredential restrictions settings to be applied to an application or service principal.
        - `[MaxLifetime <TimeSpan?>]`: 
        - `[RestrictForAppsCreatedAfterDateTime <DateTime?>]`: Timestamp when the policy is enforced for all apps created on or after the specified date. For existing applications, the enforcement date would be back dated. To apply to all applications regardless of their creation date, this property would be null. Nullable.
        - `[RestrictionType <String>]`: appKeyCredentialRestrictionType
      - `[PasswordCredentials <IMicrosoftGraphPasswordCredentialConfiguration[]>]`: Collection of password restrictions settings to be applied to an application or service principal.
        - `[MaxLifetime <TimeSpan?>]`: 
        - `[RestrictForAppsCreatedAfterDateTime <DateTime?>]`: Enforces the policy for an app created on or after the enforcement date. For existing applications, the enforcement date would be backdated. To apply to all applications, this date would be null.
        - `[RestrictionType <String>]`: appCredentialRestrictionType
  - `[AppRoles <IMicrosoftGraphAppRole[]>]`: The collection of roles assigned to the application. With app role assignments, these roles can be assigned to users, groups, or service principals associated with other applications. Not nullable.
    - `[AllowedMemberTypes <String[]>]`: Specifies whether this app role can be assigned to users and groups (by setting to ['User']), to other application's (by setting to ['Application'], or both (by setting to ['User', 'Application']). App roles supporting assignment to other applications' service principals are also known as application permissions. The 'Application' value is only supported for app roles defined on application entities.
    - `[Description <String>]`: The description for the app role. This is displayed when the app role is being assigned and, if the app role functions as an application permission, during  consent experiences.
    - `[DisplayName <String>]`: Display name for the permission that appears in the app role assignment and consent experiences.
    - `[Id <String>]`: Unique role identifier inside the appRoles collection. When creating a new app role, a new GUID identifier must be provided.
    - `[IsEnabled <Boolean?>]`: When creating or updating an app role, this must be set to true (which is the default). To delete a role, this must first be set to false.  At that point, in a subsequent call, this role may be removed.
    - `[Origin <String>]`: Specifies if the app role is defined on the application object or on the servicePrincipal entity. Must not be included in any POST or PATCH requests. Read-only.
    - `[Value <String>]`: Specifies the value to include in the roles claim in ID tokens and access tokens authenticating an assigned user or service principal. Must not exceed 120 characters in length. Allowed characters are : ! # $ % & ' ( ) * + , - . / : ;  =  ? @ [ ] ^ + _  {  } ~, as well as characters in the ranges 0-9, A-Z and a-z. Any other character, including the space character, are not allowed. May not begin with ..
  - `[Certification <IMicrosoftGraphCertification>]`: certification
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[CertificationDetailsUrl <String>]`: URL that shows certification details for the application.
    - `[CertificationExpirationDateTime <DateTime?>]`: The timestamp when the current certification for the application will expire.
    - `[IsCertifiedByMicrosoft <Boolean?>]`: Indicates whether the application is certified by Microsoft.
    - `[IsPublisherAttested <Boolean?>]`: Indicates whether the application has been self-attested by the application developer or the publisher.
    - `[LastCertificationDateTime <DateTime?>]`: The timestamp when the certification for the application was most recently added or updated.
  - `[ConnectorGroup <IMicrosoftGraphConnectorGroup>]`: connectorGroup
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[Applications <IMicrosoftGraphApplication[]>]`: 
    - `[ConnectorGroupType <String>]`: connectorGroupType
    - `[IsDefault <Boolean?>]`: Indicates if the connectorGroup is the default connectorGroup. Only a single connector group can be the default connectorGroup and this is pre-set by the system. Read-only.
    - `[Members <IMicrosoftGraphConnector[]>]`: 
      - `[Id <String>]`: 
      - `[ExternalIP <String>]`: The external IP address as detected by the the connector server. Read-only.
      - `[MachineName <String>]`: The machine name the connector is installed and running on.
      - `[MemberOf <IMicrosoftGraphConnectorGroup[]>]`: The connectorGroup that the connector is a member of. Read-only.
      - `[Status <String>]`: connectorStatus
    - `[Name <String>]`: The name associated with the connectorGroup.
    - `[Region <String>]`: connectorGroupRegion
  - `[CreatedDateTime <DateTime?>]`: The date and time the application was registered. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.  Supports $filter (eq, ne, not, ge, le, in, and eq on null values) and $orderBy.
  - `[CreatedOnBehalfOf <IMicrosoftGraphDirectoryObject>]`: directoryObject
  - `[DefaultRedirectUri <String>]`: The default redirect URI. If specified and there is no explicit redirect URI in the sign-in request for SAML and OIDC flows, Azure AD sends the token to this redirect URI. Azure AD also sends the token to this default URI in SAML IdP-initiated single sign-on. The value must match one of the configured redirect URIs for the application.
  - `[Description <String>]`: Free text field to provide a description of the application object to end users. The maximum allowed size is 1024 characters. Returned by default. Supports $filter (eq, ne, not, ge, le, startsWith) and $search.
  - `[DisabledByMicrosoftStatus <String>]`: Specifies whether Microsoft has disabled the registered application. Possible values are: null (default value), NotDisabled, and DisabledDueToViolationOfServicesAgreement (reasons may include suspicious, abusive, or malicious activity, or a violation of the Microsoft Services Agreement).  Supports $filter (eq, ne, not).
  - `[DisplayName <String>]`: The display name for the application. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values), $search, and $orderBy.
  - `[ExtensionProperties <IMicrosoftGraphExtensionProperty[]>]`: Read-only. Nullable. Supports $expand and $filter (eq when counting empty collections).
    - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
    - `[Id <String>]`: 
    - `[AppDisplayName <String>]`: Display name of the application object on which this extension property is defined. Read-only.
    - `[DataType <String>]`: Specifies the data type of the value the extension property can hold. Following values are supported. Not nullable. Binary - 256 bytes maximumBooleanDateTime - Must be specified in ISO 8601 format. Will be stored in UTC.Integer - 32-bit value.LargeInteger - 64-bit value.String - 256 characters maximum
    - `[IsSyncedFromOnPremises <Boolean?>]`: Indicates if this extension property was synced from on-premises active directory using Azure AD Connect. Read-only.
    - `[Name <String>]`: Name of the extension property. Not nullable.
    - `[TargetObjects <String[]>]`: Following values are supported. Not nullable. UserGroupOrganizationDeviceApplication
  - `[FederatedIdentityCredentials <IMicrosoftGraphFederatedIdentityCredential[]>]`: Federated identities for applications. Supports $expand and $filter (eq when counting empty collections).
    - `[Id <String>]`: 
    - `[Audiences <String[]>]`: Lists the audiences that can appear in the external token. This field is mandatory, and defaults to 'api://AzureADTokenExchange'. It says what Microsoft identity platform should accept in the aud claim in the incoming token. This value represents Azure AD in your external identity provider and has no fixed value across identity providers - you may need to create a new application registration in your identity provider to serve as the audience of this token. Required.
    - `[Description <String>]`: The un-validated, user-provided description of the federated identity credential. Optional.
    - `[Issuer <String>]`: The URL of the external identity provider and must match the issuer claim of the external token being exchanged. The combination of the values of issuer and subject must be unique on the app. Required.
    - `[Name <String>]`: is the unique identifier for the federated identity credential, which has a character limit of 120 characters and must be URL friendly. It is immutable once created. Required. Not nullable. Supports $filter (eq).
    - `[Subject <String>]`: Required. The identifier of the external software workload within the external identity provider. Like the audience value, it has no fixed format, as each identity provider uses their own - sometimes a GUID, sometimes a colon delimited identifier, sometimes arbitrary strings. The value here must match the sub claim within the token presented to Azure AD. The combination of issuer and subject must be unique on the app. Supports $filter (eq).
  - `[GroupMembershipClaims <String>]`: Configures the groups claim issued in a user or OAuth 2.0 access token that the application expects. To set this attribute, use one of the following string values: None, SecurityGroup (for security groups and Azure AD roles), All (this gets all security groups, distribution groups, and Azure AD directory roles that the signed-in user is a member of).
  - `[HomeRealmDiscoveryPolicies <IMicrosoftGraphHomeRealmDiscoveryPolicy1[]>]`: 
    - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[Definition <String[]>]`: A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.
    - `[IsOrganizationDefault <Boolean?>]`: If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.
    - `[Description <String>]`: Description for this policy. Required.
    - `[DisplayName <String>]`: Display name for this policy. Required.
    - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
    - `[Id <String>]`: 
  - `[IdentifierUris <String[]>]`: Also known as App ID URI, this value is set when an application is used as a resource app. The identifierUris acts as the prefix for the scopes you'll reference in your API's code, and it must be globally unique. You can use the default value provided, which is in the form api://<application-client-id>, or specify a more readable URI like https://contoso.com/api. For more information on valid identifierUris patterns and best practices, see Azure AD application registration security best practices. Not nullable. Supports $filter (eq, ne, ge, le, startsWith).
  - `[Info <IMicrosoftGraphInformationalUrl>]`: informationalUrl
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[LogoUrl <String>]`: CDN URL to the application's logo, Read-only.
    - `[MarketingUrl <String>]`: Link to the application's marketing page. For example, https://www.contoso.com/app/marketing
    - `[PrivacyStatementUrl <String>]`: Link to the application's privacy statement. For example, https://www.contoso.com/app/privacy
    - `[SupportUrl <String>]`: Link to the application's support page. For example, https://www.contoso.com/app/support
    - `[TermsOfServiceUrl <String>]`: Link to the application's terms of service statement. For example, https://www.contoso.com/app/termsofservice
  - `[IsDeviceOnlyAuthSupported <Boolean?>]`: Specifies whether this application supports device authentication without a user. The default is false.
  - `[IsFallbackPublicClient <Boolean?>]`: Specifies the fallback application type as public client, such as an installed application running on a mobile device. The default value is false which means the fallback application type is confidential client such as a web app. There are certain scenarios where Azure AD cannot determine the client application type. For example, the ROPC flow where the application is configured without specifying a redirect URI. In those cases Azure AD interprets the application type based on the value of this property.
  - `[KeyCredentials <IMicrosoftGraphKeyCredential[]>]`: The collection of key credentials associated with the application. Not nullable. Supports $filter (eq, not, ge, le).
    - `[CustomKeyIdentifier <Byte[]>]`: Custom key identifier
    - `[DisplayName <String>]`: Friendly name for the key. Optional.
    - `[EndDateTime <DateTime?>]`: The date and time at which the credential expires. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[Key <Byte[]>]`: Value for the key credential. Should be a Base64 encoded value. Returned only on $select for a single object, that is, GET applications/{applicationId}?$select=keyCredentials or GET servicePrincipals/{servicePrincipalId}?$select=keyCredentials; otherwise, it is always null.
    - `[KeyId <String>]`: The unique identifier for the key.
    - `[StartDateTime <DateTime?>]`: The date and time at which the credential becomes valid.The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[Type <String>]`: The type of key credential; for example, Symmetric, AsymmetricX509Cert.
    - `[Usage <String>]`: A string that describes the purpose for which the key can be used; for example, Verify.
  - `[Logo <Byte[]>]`: The main logo for the application. Not nullable.
  - `[Notes <String>]`: Notes relevant for the management of the application.
  - `[OnPremisesPublishing <IMicrosoftGraphOnPremisesPublishing>]`: onPremisesPublishing
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AlternateUrl <String>]`: If you are configuring a traffic manager in front of multiple App Proxy applications, the alternateUrl is the user-friendly URL that will point to the traffic manager.
    - `[ApplicationServerTimeout <String>]`: The duration the connector will wait for a response from the backend application before closing the connection. Possible values are default, long. When set to default, the backend application timeout has a length of 85 seconds. When set to long, the backend timeout is increased to 180 seconds. Use long if your server takes more than 85 seconds to respond to requests or if you are unable to access the application and the error status is 'Backend Timeout'. Default value is default.
    - `[ApplicationType <String>]`: Indicates if this application is an Application Proxy configured application. This is pre-set by the system. Read-only.
    - `[ExternalAuthenticationType <String>]`: externalAuthenticationType
    - `[ExternalUrl <String>]`: The published external url for the application. For example, https://intranet-contoso.msappproxy.net/.
    - `[InternalUrl <String>]`: The internal url of the application. For example, https://intranet/.
    - `[IsBackendCertificateValidationEnabled <Boolean?>]`: Indicates whether backend SSL certificate validation is enabled for the application. For all new Application Proxy apps, the property will be set to true by default. For all existing apps, the property will be set to false.
    - `[IsHttpOnlyCookieEnabled <Boolean?>]`: Indicates if the HTTPOnly cookie flag should be set in the HTTP response headers. Set this value to true to have Application Proxy cookies include the HTTPOnly flag in the HTTP response headers. If using Remote Desktop Services, set this value to False. Default value is false.
    - `[IsOnPremPublishingEnabled <Boolean?>]`: Indicates if the application is currently being published via Application Proxy or not. This is pre-set by the system. Read-only.
    - `[IsPersistentCookieEnabled <Boolean?>]`: Indicates if the Persistent cookie flag should be set in the HTTP response headers. Keep this value set to false. Only use this setting for applications that can't share cookies between processes. For more information about cookie settings, see Cookie settings for accessing on-premises applications in Azure Active Directory. Default value is false.
    - `[IsSecureCookieEnabled <Boolean?>]`: Indicates if the Secure cookie flag should be set in the HTTP response headers. Set this value to true to transmit cookies over a secure channel such as an encrypted HTTPS request. Default value is true.
    - `[IsStateSessionEnabled <Boolean?>]`: Indicates whether validation of the state parameter when the client uses the OAuth 2.0 authorization code grant flow is enabled. This setting allows admins to specify whether they want to enable CSRF protection for their apps.
    - `[IsTranslateHostHeaderEnabled <Boolean?>]`: Indicates if the application should translate urls in the reponse headers. Keep this value as true unless your application required the original host header in the authentication request. Default value is true.
    - `[IsTranslateLinksInBodyEnabled <Boolean?>]`: Indicates if the application should translate urls in the application body. Keep this value as false unless you have hardcoded HTML links to other on-premises applications and don't use custom domains. For more information, see Link translation with Application Proxy. Default value is false.
    - `[OnPremisesApplicationSegments <IMicrosoftGraphOnPremisesApplicationSegment[]>]`: 
      - `[AlternateUrl <String>]`: 
      - `[CorsConfigurations <IMicrosoftGraphCorsConfiguration[]>]`: 
        - `[AllowedHeaders <String[]>]`: 
        - `[AllowedMethods <String[]>]`: 
        - `[AllowedOrigins <String[]>]`: 
        - `[MaxAgeInSeconds <Int32?>]`: 
        - `[Resource <String>]`: 
      - `[ExternalUrl <String>]`: 
      - `[InternalUrl <String>]`: 
    - `[SingleSignOnSettings <IMicrosoftGraphOnPremisesPublishingSingleSignOn>]`: onPremisesPublishingSingleSignOn
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[KerberosSignOnSettings <IMicrosoftGraphKerberosSignOnSettings>]`: kerberosSignOnSettings
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[KerberosServicePrincipalName <String>]`: The Internal Application SPN of the application server. This SPN needs to be in the list of services to which the connector can present delegated credentials.
        - `[KerberosSignOnMappingAttributeType <String>]`: kerberosSignOnMappingAttributeType
      - `[SingleSignOnMode <String>]`: singleSignOnMode
    - `[UseAlternateUrlForTranslationAndRedirect <Boolean?>]`: 
    - `[VerifiedCustomDomainCertificatesMetadata <IMicrosoftGraphVerifiedCustomDomainCertificatesMetadata>]`: verifiedCustomDomainCertificatesMetadata
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ExpiryDate <DateTime?>]`: The expiry date of the custom domain certificate. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[IssueDate <DateTime?>]`: The issue date of the custom domain. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[IssuerName <String>]`: The issuer name of the custom domain certificate.
      - `[SubjectName <String>]`: The subject name of the custom domain certificate.
      - `[Thumbprint <String>]`: The thumbprint associated with the custom domain certificate.
    - `[VerifiedCustomDomainKeyCredential <IMicrosoftGraphKeyCredential>]`: keyCredential
    - `[VerifiedCustomDomainPasswordCredential <IMicrosoftGraphPasswordCredential>]`: passwordCredential
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[CustomKeyIdentifier <Byte[]>]`: Do not use.
      - `[DisplayName <String>]`: Friendly name for the password. Optional.
      - `[EndDateTime <DateTime?>]`: The date and time at which the password expires represented using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Optional.
      - `[Hint <String>]`: Contains the first three characters of the password. Read-only.
      - `[KeyId <String>]`: The unique identifier for the password.
      - `[SecretText <String>]`: Read-only; Contains the strong passwords generated by Azure AD that are 16-64 characters in length. The generated password value is only returned during the initial POST request to addPassword. There is no way to retrieve this password in the future.
      - `[StartDateTime <DateTime?>]`: The date and time at which the password becomes valid. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Optional.
  - `[OptionalClaims <IMicrosoftGraphOptionalClaims>]`: optionalClaims
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AccessToken <IMicrosoftGraphOptionalClaim[]>]`: The optional claims returned in the JWT access token.
      - `[AdditionalProperties <String[]>]`: Additional properties of the claim. If a property exists in this collection, it modifies the behavior of the optional claim specified in the name property.
      - `[Essential <Boolean?>]`: If the value is true, the claim specified by the client is necessary to ensure a smooth authorization experience for the specific task requested by the end user. The default value is false.
      - `[Name <String>]`: The name of the optional claim.
      - `[Source <String>]`: The source (directory object) of the claim. There are predefined claims and user-defined claims from extension properties. If the source value is null, the claim is a predefined optional claim. If the source value is user, the value in the name property is the extension property from the user object.
    - `[IdToken <IMicrosoftGraphOptionalClaim[]>]`: The optional claims returned in the JWT ID token.
    - `[Saml2Token <IMicrosoftGraphOptionalClaim[]>]`: The optional claims returned in the SAML token.
  - `[Owners <IMicrosoftGraphDirectoryObject[]>]`: Directory objects that are owners of the application. Read-only. Nullable. Supports $expand.
  - `[ParentalControlSettings <IMicrosoftGraphParentalControlSettings>]`: parentalControlSettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[CountriesBlockedForMinors <String[]>]`: Specifies the two-letter ISO country codes. Access to the application will be blocked for minors from the countries specified in this list.
    - `[LegalAgeGroupRule <String>]`: Specifies the legal age group rule that applies to users of the app. Can be set to one of the following values: ValueDescriptionAllowDefault. Enforces the legal minimum. This means parental consent is required for minors in the European Union and Korea.RequireConsentForPrivacyServicesEnforces the user to specify date of birth to comply with COPPA rules. RequireConsentForMinorsRequires parental consent for ages below 18, regardless of country minor rules.RequireConsentForKidsRequires parental consent for ages below 14, regardless of country minor rules.BlockMinorsBlocks minors from using the app.
  - `[PasswordCredentials <IMicrosoftGraphPasswordCredential[]>]`: The collection of password credentials associated with the application. Not nullable.
  - `[PublicClient <IMicrosoftGraphPublicClientApplication>]`: publicClientApplication
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[RedirectUris <String[]>]`: Specifies the URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent.
  - `[PublisherDomain <String>]`: The verified publisher domain for the application. Read-only. Supports $filter (eq, ne, ge, le, startsWith).
  - `[RequiredResourceAccess <IMicrosoftGraphRequiredResourceAccess[]>]`: Specifies the resources that the application needs to access. This property also specifies the set of delegated permissions and application roles that it needs for each of those resources. This configuration of access to the required resources drives the consent experience. No more than 50 resource services (APIs) can be configured. Beginning mid-October 2021, the total number of required permissions must not exceed 400. Not nullable. Supports $filter (eq, not, ge, le).
    - `[ResourceAccess <IMicrosoftGraphResourceAccess[]>]`: The list of OAuth2.0 permission scopes and app roles that the application requires from the specified resource.
      - `[Id <String>]`: The unique identifier of an app role or delegated permission exposed by the resource application. For delegated permissions, this should match the id property of one of the delegated permissions in the oauth2PermissionScopes collection of the resource application's service principal. For app roles (application permissions), this should match the id property of an app role in the appRoles collection of the resource application's service principal.
      - `[Type <String>]`: Specifies whether the id property references a delegated permission or an app role (application permission). The possible values are: Scope (for delegated permissions) or Role (for app roles).
    - `[ResourceAppId <String>]`: The unique identifier for the resource that the application requires access to. This should be equal to the appId declared on the target resource application.
  - `[SamlMetadataUrl <String>]`: The URL where the service exposes SAML metadata for federation. This property is valid only for single-tenant applications. Nullable.
  - `[ServiceManagementReference <String>]`: References application or service contact information from a Service or Asset Management database. Nullable.
  - `[SignInAudience <String>]`: Specifies the Microsoft accounts that are supported for the current application. The possible values are: AzureADMyOrg, AzureADMultipleOrgs, AzureADandPersonalMicrosoftAccount (default), and PersonalMicrosoftAccount. See more in the table below. Supports $filter (eq, ne, not).
  - `[Spa <IMicrosoftGraphSpaApplication>]`: spaApplication
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[RedirectUris <String[]>]`: Specifies the URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent.
  - `[Synchronization <IMicrosoftGraphSynchronization>]`: synchronization
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[Jobs <IMicrosoftGraphSynchronizationJob[]>]`: Performs synchronization by periodically running in the background, polling for changes in one directory, and pushing them to another directory.
      - `[Id <String>]`: 
      - `[Schedule <IMicrosoftGraphSynchronizationSchedule>]`: synchronizationSchedule
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Expiration <DateTime?>]`: Date and time when this job will expire. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[Interval <TimeSpan?>]`: The interval between synchronization iterations.
        - `[State <String>]`: synchronizationScheduleState
      - `[Schema <IMicrosoftGraphSynchronizationSchema>]`: synchronizationSchema
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: 
        - `[Directories <IMicrosoftGraphDirectoryDefinition[]>]`: Contains the collection of directories and all of their objects.
          - `[Id <String>]`: 
          - `[Discoverabilities <String>]`: directoryDefinitionDiscoverabilities
          - `[DiscoveryDateTime <DateTime?>]`: Represents the discovery date and time using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
          - `[Name <String>]`: Name of the directory. Must be unique within the synchronization schema. Not nullable.
          - `[Objects <IMicrosoftGraphObjectDefinition[]>]`: Collection of objects supported by the directory.
            - `[Attributes <IMicrosoftGraphAttributeDefinition[]>]`: 
              - `[Anchor <Boolean?>]`: true if the attribute should be used as the anchor for the object. Anchor attributes must have a unique value identifying an object, and must be immutable. Default is false. One, and only one, of the object's attributes must be designated as the anchor to support synchronization.
              - `[ApiExpressions <IMicrosoftGraphStringKeyStringValuePair[]>]`: 
                - `[Key <String>]`: Key.
                - `[Value <String>]`: Value.
              - `[CaseExact <Boolean?>]`: true if value of this attribute should be treated as case-sensitive. This setting affects how the synchronization engine detects changes for the attribute.
              - `[DefaultValue <String>]`: 
              - `[FlowNullValues <Boolean?>]`: 'true' to allow null values for attributes.
              - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: Additional extension properties. Unless mentioned explicitly, metadata values should not be changed.
                - `[Key <String>]`: Name of the metadata property.
                - `[Value <String>]`: Value of the metadata property.
              - `[Multivalued <Boolean?>]`: true if an attribute can have multiple values. Default is false.
              - `[Mutability <String>]`: mutability
              - `[Name <String>]`: Name of the attribute. Must be unique within the object definition. Not nullable.
              - `[ReferencedObjects <IMicrosoftGraphReferencedObject[]>]`: For attributes with reference type, lists referenced objects (for example, the manager attribute would list User as the referenced object).
                - `[ReferencedObjectName <String>]`: Name of the referenced object. Must match one of the objects in the directory definition.
                - `[ReferencedProperty <String>]`: Currently not supported. Name of the property in the referenced object, the value for which is used as the reference.
              - `[Required <Boolean?>]`: true if attribute is required. Object can not be created if any of the required attributes are missing. If during synchronization, the required attribute has no value, the default value will be used. If default the value was not set, synchronization will record an error.
              - `[Type <String>]`: attributeType
            - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: 
            - `[Name <String>]`: 
            - `[SupportedApis <String[]>]`: 
          - `[ReadOnly <Boolean?>]`: 
          - `[Version <String>]`: Read only value that indicates version discovered. null if discovery has not yet occurred.
        - `[SynchronizationRules <IMicrosoftGraphSynchronizationRule[]>]`: A collection of synchronization rules configured for the synchronizationJob or synchronizationTemplate.
          - `[Editable <Boolean?>]`: true if the synchronization rule can be customized; false if this rule is read-only and should not be changed.
          - `[Id <String>]`: Synchronization rule identifier. Must be one of the identifiers recognized by the synchronization engine. Supported rule identifiers can be found in the synchronization template returned by the API.
          - `[Metadata <IMicrosoftGraphStringKeyStringValuePair[]>]`: Additional extension properties. Unless instructed explicitly by the support team, metadata values should not be changed.
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
                - `[Expression <String>]`: 
                - `[Name <String>]`: 
                - `[Parameters <IMicrosoftGraphStringKeyAttributeMappingSourceValuePair[]>]`: 
                  - `[Key <String>]`: The name of the parameter.
                  - `[Value <IMicrosoftGraphAttributeMappingSource>]`: attributeMappingSource
                - `[Type <String>]`: attributeMappingSourceType
              - `[TargetAttributeName <String>]`: Name of the attribute on the target object.
            - `[Enabled <Boolean?>]`: When true, this object mapping will be processed during synchronization. When false, this object mapping will be skipped.
            - `[FlowTypes <String>]`: objectFlowTypes
            - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: Additional extension properties. Unless mentioned explicitly, metadata values should not be changed.
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
              - `[Groups <IMicrosoftGraphFilterGroup[]>]`: Filter group set used to decide whether given object is in scope for provisioning. This is the filter which should be used in most cases. If an object used to satisfy this filter at a given moment, and then the object or the filter was changed so that filter is not satisfied any longer, such object will get de-provisioned'. An object is considered in scope if ANY of the groups in the collection is evaluated to true.
              - `[InputFilterGroups <IMicrosoftGraphFilterGroup[]>]`: *Experimental* Filter group set used to filter out objects at the early stage of reading them from the directory. If an object doesn't satisfy this filter it will not be processed further. Important to understand is that if an object used to satisfy this filter at a given moment, and then the object or the filter was changed so that filter is no longer satisfied, such object will NOT get de-provisioned. An object is considered in scope if ANY of the groups in the collection is evaluated to true.
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
            - `[Code <String>]`: 
            - `[Message <String>]`: 
            - `[TenantActionable <Boolean?>]`: 
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
          - `[Key <String>]`: Key.
          - `[Value <Int64?>]`: Value.
        - `[TroubleshootingUrl <String>]`: In the event of an error, the URL with the troubleshooting steps for the issue.
      - `[SynchronizationJobSettings <IMicrosoftGraphKeyValuePair[]>]`: Settings associated with the job. Some settings are inherited from the template.
        - `[Name <String>]`: Name for this key-value pair
        - `[Value <String>]`: Value for this key-value pair
      - `[TemplateId <String>]`: Identifier of the synchronization template this job is based on.
    - `[Secrets <IMicrosoftGraphSynchronizationSecretKeyStringValuePair[]>]`: Represents a collection of credentials to access provisioned cloud applications.
      - `[Key <String>]`: synchronizationSecret
      - `[Value <String>]`: The value of the secret.
    - `[Templates <IMicrosoftGraphSynchronizationTemplate[]>]`: Pre-configured synchronization settings for a particular application.
      - `[Id <String>]`: 
      - `[ApplicationId <String>]`: Identifier of the application this template belongs to.
      - `[Default <Boolean?>]`: true if this template is recommended to be the default for the application.
      - `[Description <String>]`: Description of the template.
      - `[Discoverable <Boolean?>]`: true if this template should appear in the collection of templates available for the application instance (service principal).
      - `[FactoryTag <String>]`: One of the well-known factory tags supported by the synchronization engine. The factoryTag tells the synchronization engine which implementation to use when processing jobs based on this template.
      - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: Additional extension properties. Unless mentioned explicitly, metadata values should not be changed.
      - `[Schema <IMicrosoftGraphSynchronizationSchema>]`: synchronizationSchema
  - `[Tags <String[]>]`: Custom strings that can be used to categorize and identify the application. Not nullable.Supports $filter (eq, not, ge, le, startsWith).
  - `[TokenEncryptionKeyId <String>]`: Specifies the keyId of a public key from the keyCredentials collection. When configured, Azure AD encrypts all the tokens it emits by using the key this property points to. The application code that receives the encrypted token must use the matching private key to decrypt the token before it can be used for the signed-in user.
  - `[TokenIssuancePolicies <IMicrosoftGraphTokenIssuancePolicy1[]>]`: 
    - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[Definition <String[]>]`: A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.
    - `[IsOrganizationDefault <Boolean?>]`: If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.
    - `[Description <String>]`: Description for this policy. Required.
    - `[DisplayName <String>]`: Display name for this policy. Required.
    - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
    - `[Id <String>]`: 
  - `[TokenLifetimePolicies <IMicrosoftGraphTokenLifetimePolicy1[]>]`: The tokenLifetimePolicies assigned to this application. Supports $expand.
    - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[Definition <String[]>]`: A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.
    - `[IsOrganizationDefault <Boolean?>]`: If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.
    - `[Description <String>]`: Description for this policy. Required.
    - `[DisplayName <String>]`: Display name for this policy. Required.
    - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
    - `[Id <String>]`: 
  - `[UniqueName <String>]`: The unique identifier that can be assigned to an application as an alternative identifier. Immutable. Read-only.
  - `[VerifiedPublisher <IMicrosoftGraphVerifiedPublisher>]`: verifiedPublisher
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AddedDateTime <DateTime?>]`: The timestamp when the verified publisher was first added or most recently updated.
    - `[DisplayName <String>]`: The verified publisher name from the app publisher's Microsoft Partner Network (MPN) account.
    - `[VerifiedPublisherId <String>]`: The ID of the verified publisher from the app publisher's Partner Center account.
  - `[Web <IMicrosoftGraphWebApplication1>]`: webApplication
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[HomePageUrl <String>]`: Home page or landing page of the application.
    - `[ImplicitGrantSettings <IMicrosoftGraphImplicitGrantSettings>]`: implicitGrantSettings
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[EnableAccessTokenIssuance <Boolean?>]`: Specifies whether this web application can request an access token using the OAuth 2.0 implicit flow.
      - `[EnableIdTokenIssuance <Boolean?>]`: Specifies whether this web application can request an ID token using the OAuth 2.0 implicit flow.
    - `[LogoutUrl <String>]`: Specifies the URL that will be used by Microsoft's authorization service to logout an user using front-channel, back-channel or SAML logout protocols.
    - `[Oauth2AllowImplicitFlow <Boolean?>]`: 
    - `[RedirectUriSettings <IMicrosoftGraphRedirectUriSettings[]>]`: Specifies the index of the URLs where user tokens are sent for sign-in. This is only valid for applications using SAML.
      - `[Index <Int32?>]`: Identifies the specific URI within the redirectURIs collection in SAML SSO flows. Defaults to null. The index is unique across all the redirectUris for the application.
      - `[Uri <String>]`: Specifies the URI that tokens are sent to.
    - `[RedirectUris <String[]>]`: Specifies the URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent.
  - `[Windows <IMicrosoftGraphWindowsApplication>]`: windowsApplication
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[PackageSid <String>]`: The package security identifier that Microsoft has assigned the application. Optional. Read-only.
    - `[RedirectUris <String[]>]`: Specifies the URLs where user tokens are sent for sign-in or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent. Only available for applications that support the PersonalMicrosoftAccount signInAudience.

CERTIFICATION <IMicrosoftGraphCertification>: certification
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CertificationDetailsUrl <String>]`: URL that shows certification details for the application.
  - `[CertificationExpirationDateTime <DateTime?>]`: The timestamp when the current certification for the application will expire.
  - `[IsCertifiedByMicrosoft <Boolean?>]`: Indicates whether the application is certified by Microsoft.
  - `[IsPublisherAttested <Boolean?>]`: Indicates whether the application has been self-attested by the application developer or the publisher.
  - `[LastCertificationDateTime <DateTime?>]`: The timestamp when the certification for the application was most recently added or updated.

CONNECTORGROUP <IMicrosoftGraphConnectorGroup>: connectorGroup
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[Applications <IMicrosoftGraphApplication[]>]`: 
    - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
    - `[Id <String>]`: 
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
        - `[Type <String>]`: The possible values are: User and Admin. Specifies whether this delegated permission should be considered safe for non-admin users to consent to on behalf of themselves, or whether an administrator consent should always be required. While Microsoft Graph defines the default consent requirement for each permission, the tenant administrator may override the behavior in their organization (by allowing, restricting, or limiting user consent to this delegated permission). For more information, see Configure how users consent to applications.
        - `[UserConsentDescription <String>]`: A description of the delegated permissions, intended to be read by a user granting the permission on their own behalf. This text appears in consent experiences where the user is consenting only on behalf of themselves.
        - `[UserConsentDisplayName <String>]`: A title for the permission, intended to be read by a user granting the permission on their own behalf. This text appears in consent experiences where the user is consenting only on behalf of themselves.
        - `[Value <String>]`: Specifies the value to include in the scp (scope) claim in access tokens. Must not exceed 120 characters in length. Allowed characters are : ! # $ % & ' ( ) * + , - . / : ;  =  ? @ [ ] ^ + _  {  } ~, as well as characters in the ranges 0-9, A-Z and a-z. Any other character, including the space character, are not allowed. May not begin with ..
      - `[PreAuthorizedApplications <IMicrosoftGraphPreAuthorizedApplication1[]>]`: Lists the client applications that are pre-authorized with the specified delegated permissions to access this application's APIs. Users are not required to consent to any pre-authorized application (for the permissions specified). However, any additional permissions not listed in preAuthorizedApplications (requested through incremental consent for example) will require user consent.
        - `[AppId <String>]`: The unique identifier for the client application.
        - `[PermissionIds <String[]>]`: The unique identifier for the scopes the client application is granted.
      - `[RequestedAccessTokenVersion <Int32?>]`: Specifies the access token version expected by this resource. This changes the version and format of the JWT produced independent of the endpoint or client used to request the access token.  The endpoint used, v1.0 or v2.0, is chosen by the client and only impacts the version of id_tokens. Resources need to explicitly configure requestedAccessTokenVersion to indicate the supported access token format.  Possible values for requestedAccessTokenVersion are 1, 2, or null. If the value is null, this defaults to 1, which corresponds to the v1.0 endpoint.  If signInAudience on the application is configured as AzureADandPersonalMicrosoftAccount, the value for this property must be 2
    - `[AppId <String>]`: The unique identifier for the application that is assigned by Azure AD. Not nullable. Read-only.
    - `[AppManagementPolicies <IMicrosoftGraphAppManagementPolicy[]>]`: The appManagementPolicy applied to this application.
      - `[Description <String>]`: Description for this policy. Required.
      - `[DisplayName <String>]`: Display name for this policy. Required.
      - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
      - `[Id <String>]`: 
      - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
        - `[Id <String>]`: 
        - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
      - `[IsEnabled <Boolean?>]`: 
      - `[Restrictions <IMicrosoftGraphAppManagementConfiguration>]`: appManagementConfiguration
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[KeyCredentials <IMicrosoftGraphKeyCredentialConfiguration[]>]`: Collection of keyCredential restrictions settings to be applied to an application or service principal.
          - `[MaxLifetime <TimeSpan?>]`: 
          - `[RestrictForAppsCreatedAfterDateTime <DateTime?>]`: Timestamp when the policy is enforced for all apps created on or after the specified date. For existing applications, the enforcement date would be back dated. To apply to all applications regardless of their creation date, this property would be null. Nullable.
          - `[RestrictionType <String>]`: appKeyCredentialRestrictionType
        - `[PasswordCredentials <IMicrosoftGraphPasswordCredentialConfiguration[]>]`: Collection of password restrictions settings to be applied to an application or service principal.
          - `[MaxLifetime <TimeSpan?>]`: 
          - `[RestrictForAppsCreatedAfterDateTime <DateTime?>]`: Enforces the policy for an app created on or after the enforcement date. For existing applications, the enforcement date would be backdated. To apply to all applications, this date would be null.
          - `[RestrictionType <String>]`: appCredentialRestrictionType
    - `[AppRoles <IMicrosoftGraphAppRole[]>]`: The collection of roles assigned to the application. With app role assignments, these roles can be assigned to users, groups, or service principals associated with other applications. Not nullable.
      - `[AllowedMemberTypes <String[]>]`: Specifies whether this app role can be assigned to users and groups (by setting to ['User']), to other application's (by setting to ['Application'], or both (by setting to ['User', 'Application']). App roles supporting assignment to other applications' service principals are also known as application permissions. The 'Application' value is only supported for app roles defined on application entities.
      - `[Description <String>]`: The description for the app role. This is displayed when the app role is being assigned and, if the app role functions as an application permission, during  consent experiences.
      - `[DisplayName <String>]`: Display name for the permission that appears in the app role assignment and consent experiences.
      - `[Id <String>]`: Unique role identifier inside the appRoles collection. When creating a new app role, a new GUID identifier must be provided.
      - `[IsEnabled <Boolean?>]`: When creating or updating an app role, this must be set to true (which is the default). To delete a role, this must first be set to false.  At that point, in a subsequent call, this role may be removed.
      - `[Origin <String>]`: Specifies if the app role is defined on the application object or on the servicePrincipal entity. Must not be included in any POST or PATCH requests. Read-only.
      - `[Value <String>]`: Specifies the value to include in the roles claim in ID tokens and access tokens authenticating an assigned user or service principal. Must not exceed 120 characters in length. Allowed characters are : ! # $ % & ' ( ) * + , - . / : ;  =  ? @ [ ] ^ + _  {  } ~, as well as characters in the ranges 0-9, A-Z and a-z. Any other character, including the space character, are not allowed. May not begin with ..
    - `[Certification <IMicrosoftGraphCertification>]`: certification
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[CertificationDetailsUrl <String>]`: URL that shows certification details for the application.
      - `[CertificationExpirationDateTime <DateTime?>]`: The timestamp when the current certification for the application will expire.
      - `[IsCertifiedByMicrosoft <Boolean?>]`: Indicates whether the application is certified by Microsoft.
      - `[IsPublisherAttested <Boolean?>]`: Indicates whether the application has been self-attested by the application developer or the publisher.
      - `[LastCertificationDateTime <DateTime?>]`: The timestamp when the certification for the application was most recently added or updated.
    - `[ConnectorGroup <IMicrosoftGraphConnectorGroup>]`: connectorGroup
    - `[CreatedDateTime <DateTime?>]`: The date and time the application was registered. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.  Supports $filter (eq, ne, not, ge, le, in, and eq on null values) and $orderBy.
    - `[CreatedOnBehalfOf <IMicrosoftGraphDirectoryObject>]`: directoryObject
    - `[DefaultRedirectUri <String>]`: The default redirect URI. If specified and there is no explicit redirect URI in the sign-in request for SAML and OIDC flows, Azure AD sends the token to this redirect URI. Azure AD also sends the token to this default URI in SAML IdP-initiated single sign-on. The value must match one of the configured redirect URIs for the application.
    - `[Description <String>]`: Free text field to provide a description of the application object to end users. The maximum allowed size is 1024 characters. Returned by default. Supports $filter (eq, ne, not, ge, le, startsWith) and $search.
    - `[DisabledByMicrosoftStatus <String>]`: Specifies whether Microsoft has disabled the registered application. Possible values are: null (default value), NotDisabled, and DisabledDueToViolationOfServicesAgreement (reasons may include suspicious, abusive, or malicious activity, or a violation of the Microsoft Services Agreement).  Supports $filter (eq, ne, not).
    - `[DisplayName <String>]`: The display name for the application. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values), $search, and $orderBy.
    - `[ExtensionProperties <IMicrosoftGraphExtensionProperty[]>]`: Read-only. Nullable. Supports $expand and $filter (eq when counting empty collections).
      - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
      - `[Id <String>]`: 
      - `[AppDisplayName <String>]`: Display name of the application object on which this extension property is defined. Read-only.
      - `[DataType <String>]`: Specifies the data type of the value the extension property can hold. Following values are supported. Not nullable. Binary - 256 bytes maximumBooleanDateTime - Must be specified in ISO 8601 format. Will be stored in UTC.Integer - 32-bit value.LargeInteger - 64-bit value.String - 256 characters maximum
      - `[IsSyncedFromOnPremises <Boolean?>]`: Indicates if this extension property was synced from on-premises active directory using Azure AD Connect. Read-only.
      - `[Name <String>]`: Name of the extension property. Not nullable.
      - `[TargetObjects <String[]>]`: Following values are supported. Not nullable. UserGroupOrganizationDeviceApplication
    - `[FederatedIdentityCredentials <IMicrosoftGraphFederatedIdentityCredential[]>]`: Federated identities for applications. Supports $expand and $filter (eq when counting empty collections).
      - `[Id <String>]`: 
      - `[Audiences <String[]>]`: Lists the audiences that can appear in the external token. This field is mandatory, and defaults to 'api://AzureADTokenExchange'. It says what Microsoft identity platform should accept in the aud claim in the incoming token. This value represents Azure AD in your external identity provider and has no fixed value across identity providers - you may need to create a new application registration in your identity provider to serve as the audience of this token. Required.
      - `[Description <String>]`: The un-validated, user-provided description of the federated identity credential. Optional.
      - `[Issuer <String>]`: The URL of the external identity provider and must match the issuer claim of the external token being exchanged. The combination of the values of issuer and subject must be unique on the app. Required.
      - `[Name <String>]`: is the unique identifier for the federated identity credential, which has a character limit of 120 characters and must be URL friendly. It is immutable once created. Required. Not nullable. Supports $filter (eq).
      - `[Subject <String>]`: Required. The identifier of the external software workload within the external identity provider. Like the audience value, it has no fixed format, as each identity provider uses their own - sometimes a GUID, sometimes a colon delimited identifier, sometimes arbitrary strings. The value here must match the sub claim within the token presented to Azure AD. The combination of issuer and subject must be unique on the app. Supports $filter (eq).
    - `[GroupMembershipClaims <String>]`: Configures the groups claim issued in a user or OAuth 2.0 access token that the application expects. To set this attribute, use one of the following string values: None, SecurityGroup (for security groups and Azure AD roles), All (this gets all security groups, distribution groups, and Azure AD directory roles that the signed-in user is a member of).
    - `[HomeRealmDiscoveryPolicies <IMicrosoftGraphHomeRealmDiscoveryPolicy1[]>]`: 
      - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
      - `[Definition <String[]>]`: A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.
      - `[IsOrganizationDefault <Boolean?>]`: If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.
      - `[Description <String>]`: Description for this policy. Required.
      - `[DisplayName <String>]`: Display name for this policy. Required.
      - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
      - `[Id <String>]`: 
    - `[IdentifierUris <String[]>]`: Also known as App ID URI, this value is set when an application is used as a resource app. The identifierUris acts as the prefix for the scopes you'll reference in your API's code, and it must be globally unique. You can use the default value provided, which is in the form api://<application-client-id>, or specify a more readable URI like https://contoso.com/api. For more information on valid identifierUris patterns and best practices, see Azure AD application registration security best practices. Not nullable. Supports $filter (eq, ne, ge, le, startsWith).
    - `[Info <IMicrosoftGraphInformationalUrl>]`: informationalUrl
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[LogoUrl <String>]`: CDN URL to the application's logo, Read-only.
      - `[MarketingUrl <String>]`: Link to the application's marketing page. For example, https://www.contoso.com/app/marketing
      - `[PrivacyStatementUrl <String>]`: Link to the application's privacy statement. For example, https://www.contoso.com/app/privacy
      - `[SupportUrl <String>]`: Link to the application's support page. For example, https://www.contoso.com/app/support
      - `[TermsOfServiceUrl <String>]`: Link to the application's terms of service statement. For example, https://www.contoso.com/app/termsofservice
    - `[IsDeviceOnlyAuthSupported <Boolean?>]`: Specifies whether this application supports device authentication without a user. The default is false.
    - `[IsFallbackPublicClient <Boolean?>]`: Specifies the fallback application type as public client, such as an installed application running on a mobile device. The default value is false which means the fallback application type is confidential client such as a web app. There are certain scenarios where Azure AD cannot determine the client application type. For example, the ROPC flow where the application is configured without specifying a redirect URI. In those cases Azure AD interprets the application type based on the value of this property.
    - `[KeyCredentials <IMicrosoftGraphKeyCredential[]>]`: The collection of key credentials associated with the application. Not nullable. Supports $filter (eq, not, ge, le).
      - `[CustomKeyIdentifier <Byte[]>]`: Custom key identifier
      - `[DisplayName <String>]`: Friendly name for the key. Optional.
      - `[EndDateTime <DateTime?>]`: The date and time at which the credential expires. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[Key <Byte[]>]`: Value for the key credential. Should be a Base64 encoded value. Returned only on $select for a single object, that is, GET applications/{applicationId}?$select=keyCredentials or GET servicePrincipals/{servicePrincipalId}?$select=keyCredentials; otherwise, it is always null.
      - `[KeyId <String>]`: The unique identifier for the key.
      - `[StartDateTime <DateTime?>]`: The date and time at which the credential becomes valid.The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[Type <String>]`: The type of key credential; for example, Symmetric, AsymmetricX509Cert.
      - `[Usage <String>]`: A string that describes the purpose for which the key can be used; for example, Verify.
    - `[Logo <Byte[]>]`: The main logo for the application. Not nullable.
    - `[Notes <String>]`: Notes relevant for the management of the application.
    - `[OnPremisesPublishing <IMicrosoftGraphOnPremisesPublishing>]`: onPremisesPublishing
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AlternateUrl <String>]`: If you are configuring a traffic manager in front of multiple App Proxy applications, the alternateUrl is the user-friendly URL that will point to the traffic manager.
      - `[ApplicationServerTimeout <String>]`: The duration the connector will wait for a response from the backend application before closing the connection. Possible values are default, long. When set to default, the backend application timeout has a length of 85 seconds. When set to long, the backend timeout is increased to 180 seconds. Use long if your server takes more than 85 seconds to respond to requests or if you are unable to access the application and the error status is 'Backend Timeout'. Default value is default.
      - `[ApplicationType <String>]`: Indicates if this application is an Application Proxy configured application. This is pre-set by the system. Read-only.
      - `[ExternalAuthenticationType <String>]`: externalAuthenticationType
      - `[ExternalUrl <String>]`: The published external url for the application. For example, https://intranet-contoso.msappproxy.net/.
      - `[InternalUrl <String>]`: The internal url of the application. For example, https://intranet/.
      - `[IsBackendCertificateValidationEnabled <Boolean?>]`: Indicates whether backend SSL certificate validation is enabled for the application. For all new Application Proxy apps, the property will be set to true by default. For all existing apps, the property will be set to false.
      - `[IsHttpOnlyCookieEnabled <Boolean?>]`: Indicates if the HTTPOnly cookie flag should be set in the HTTP response headers. Set this value to true to have Application Proxy cookies include the HTTPOnly flag in the HTTP response headers. If using Remote Desktop Services, set this value to False. Default value is false.
      - `[IsOnPremPublishingEnabled <Boolean?>]`: Indicates if the application is currently being published via Application Proxy or not. This is pre-set by the system. Read-only.
      - `[IsPersistentCookieEnabled <Boolean?>]`: Indicates if the Persistent cookie flag should be set in the HTTP response headers. Keep this value set to false. Only use this setting for applications that can't share cookies between processes. For more information about cookie settings, see Cookie settings for accessing on-premises applications in Azure Active Directory. Default value is false.
      - `[IsSecureCookieEnabled <Boolean?>]`: Indicates if the Secure cookie flag should be set in the HTTP response headers. Set this value to true to transmit cookies over a secure channel such as an encrypted HTTPS request. Default value is true.
      - `[IsStateSessionEnabled <Boolean?>]`: Indicates whether validation of the state parameter when the client uses the OAuth 2.0 authorization code grant flow is enabled. This setting allows admins to specify whether they want to enable CSRF protection for their apps.
      - `[IsTranslateHostHeaderEnabled <Boolean?>]`: Indicates if the application should translate urls in the reponse headers. Keep this value as true unless your application required the original host header in the authentication request. Default value is true.
      - `[IsTranslateLinksInBodyEnabled <Boolean?>]`: Indicates if the application should translate urls in the application body. Keep this value as false unless you have hardcoded HTML links to other on-premises applications and don't use custom domains. For more information, see Link translation with Application Proxy. Default value is false.
      - `[OnPremisesApplicationSegments <IMicrosoftGraphOnPremisesApplicationSegment[]>]`: 
        - `[AlternateUrl <String>]`: 
        - `[CorsConfigurations <IMicrosoftGraphCorsConfiguration[]>]`: 
          - `[AllowedHeaders <String[]>]`: 
          - `[AllowedMethods <String[]>]`: 
          - `[AllowedOrigins <String[]>]`: 
          - `[MaxAgeInSeconds <Int32?>]`: 
          - `[Resource <String>]`: 
        - `[ExternalUrl <String>]`: 
        - `[InternalUrl <String>]`: 
      - `[SingleSignOnSettings <IMicrosoftGraphOnPremisesPublishingSingleSignOn>]`: onPremisesPublishingSingleSignOn
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[KerberosSignOnSettings <IMicrosoftGraphKerberosSignOnSettings>]`: kerberosSignOnSettings
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[KerberosServicePrincipalName <String>]`: The Internal Application SPN of the application server. This SPN needs to be in the list of services to which the connector can present delegated credentials.
          - `[KerberosSignOnMappingAttributeType <String>]`: kerberosSignOnMappingAttributeType
        - `[SingleSignOnMode <String>]`: singleSignOnMode
      - `[UseAlternateUrlForTranslationAndRedirect <Boolean?>]`: 
      - `[VerifiedCustomDomainCertificatesMetadata <IMicrosoftGraphVerifiedCustomDomainCertificatesMetadata>]`: verifiedCustomDomainCertificatesMetadata
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[ExpiryDate <DateTime?>]`: The expiry date of the custom domain certificate. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[IssueDate <DateTime?>]`: The issue date of the custom domain. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[IssuerName <String>]`: The issuer name of the custom domain certificate.
        - `[SubjectName <String>]`: The subject name of the custom domain certificate.
        - `[Thumbprint <String>]`: The thumbprint associated with the custom domain certificate.
      - `[VerifiedCustomDomainKeyCredential <IMicrosoftGraphKeyCredential>]`: keyCredential
      - `[VerifiedCustomDomainPasswordCredential <IMicrosoftGraphPasswordCredential>]`: passwordCredential
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[CustomKeyIdentifier <Byte[]>]`: Do not use.
        - `[DisplayName <String>]`: Friendly name for the password. Optional.
        - `[EndDateTime <DateTime?>]`: The date and time at which the password expires represented using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Optional.
        - `[Hint <String>]`: Contains the first three characters of the password. Read-only.
        - `[KeyId <String>]`: The unique identifier for the password.
        - `[SecretText <String>]`: Read-only; Contains the strong passwords generated by Azure AD that are 16-64 characters in length. The generated password value is only returned during the initial POST request to addPassword. There is no way to retrieve this password in the future.
        - `[StartDateTime <DateTime?>]`: The date and time at which the password becomes valid. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Optional.
    - `[OptionalClaims <IMicrosoftGraphOptionalClaims>]`: optionalClaims
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AccessToken <IMicrosoftGraphOptionalClaim[]>]`: The optional claims returned in the JWT access token.
        - `[AdditionalProperties <String[]>]`: Additional properties of the claim. If a property exists in this collection, it modifies the behavior of the optional claim specified in the name property.
        - `[Essential <Boolean?>]`: If the value is true, the claim specified by the client is necessary to ensure a smooth authorization experience for the specific task requested by the end user. The default value is false.
        - `[Name <String>]`: The name of the optional claim.
        - `[Source <String>]`: The source (directory object) of the claim. There are predefined claims and user-defined claims from extension properties. If the source value is null, the claim is a predefined optional claim. If the source value is user, the value in the name property is the extension property from the user object.
      - `[IdToken <IMicrosoftGraphOptionalClaim[]>]`: The optional claims returned in the JWT ID token.
      - `[Saml2Token <IMicrosoftGraphOptionalClaim[]>]`: The optional claims returned in the SAML token.
    - `[Owners <IMicrosoftGraphDirectoryObject[]>]`: Directory objects that are owners of the application. Read-only. Nullable. Supports $expand.
    - `[ParentalControlSettings <IMicrosoftGraphParentalControlSettings>]`: parentalControlSettings
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[CountriesBlockedForMinors <String[]>]`: Specifies the two-letter ISO country codes. Access to the application will be blocked for minors from the countries specified in this list.
      - `[LegalAgeGroupRule <String>]`: Specifies the legal age group rule that applies to users of the app. Can be set to one of the following values: ValueDescriptionAllowDefault. Enforces the legal minimum. This means parental consent is required for minors in the European Union and Korea.RequireConsentForPrivacyServicesEnforces the user to specify date of birth to comply with COPPA rules. RequireConsentForMinorsRequires parental consent for ages below 18, regardless of country minor rules.RequireConsentForKidsRequires parental consent for ages below 14, regardless of country minor rules.BlockMinorsBlocks minors from using the app.
    - `[PasswordCredentials <IMicrosoftGraphPasswordCredential[]>]`: The collection of password credentials associated with the application. Not nullable.
    - `[PublicClient <IMicrosoftGraphPublicClientApplication>]`: publicClientApplication
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[RedirectUris <String[]>]`: Specifies the URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent.
    - `[PublisherDomain <String>]`: The verified publisher domain for the application. Read-only. Supports $filter (eq, ne, ge, le, startsWith).
    - `[RequiredResourceAccess <IMicrosoftGraphRequiredResourceAccess[]>]`: Specifies the resources that the application needs to access. This property also specifies the set of delegated permissions and application roles that it needs for each of those resources. This configuration of access to the required resources drives the consent experience. No more than 50 resource services (APIs) can be configured. Beginning mid-October 2021, the total number of required permissions must not exceed 400. Not nullable. Supports $filter (eq, not, ge, le).
      - `[ResourceAccess <IMicrosoftGraphResourceAccess[]>]`: The list of OAuth2.0 permission scopes and app roles that the application requires from the specified resource.
        - `[Id <String>]`: The unique identifier of an app role or delegated permission exposed by the resource application. For delegated permissions, this should match the id property of one of the delegated permissions in the oauth2PermissionScopes collection of the resource application's service principal. For app roles (application permissions), this should match the id property of an app role in the appRoles collection of the resource application's service principal.
        - `[Type <String>]`: Specifies whether the id property references a delegated permission or an app role (application permission). The possible values are: Scope (for delegated permissions) or Role (for app roles).
      - `[ResourceAppId <String>]`: The unique identifier for the resource that the application requires access to. This should be equal to the appId declared on the target resource application.
    - `[SamlMetadataUrl <String>]`: The URL where the service exposes SAML metadata for federation. This property is valid only for single-tenant applications. Nullable.
    - `[ServiceManagementReference <String>]`: References application or service contact information from a Service or Asset Management database. Nullable.
    - `[SignInAudience <String>]`: Specifies the Microsoft accounts that are supported for the current application. The possible values are: AzureADMyOrg, AzureADMultipleOrgs, AzureADandPersonalMicrosoftAccount (default), and PersonalMicrosoftAccount. See more in the table below. Supports $filter (eq, ne, not).
    - `[Spa <IMicrosoftGraphSpaApplication>]`: spaApplication
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[RedirectUris <String[]>]`: Specifies the URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent.
    - `[Synchronization <IMicrosoftGraphSynchronization>]`: synchronization
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: 
      - `[Jobs <IMicrosoftGraphSynchronizationJob[]>]`: Performs synchronization by periodically running in the background, polling for changes in one directory, and pushing them to another directory.
        - `[Id <String>]`: 
        - `[Schedule <IMicrosoftGraphSynchronizationSchedule>]`: synchronizationSchedule
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Expiration <DateTime?>]`: Date and time when this job will expire. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
          - `[Interval <TimeSpan?>]`: The interval between synchronization iterations.
          - `[State <String>]`: synchronizationScheduleState
        - `[Schema <IMicrosoftGraphSynchronizationSchema>]`: synchronizationSchema
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Id <String>]`: 
          - `[Directories <IMicrosoftGraphDirectoryDefinition[]>]`: Contains the collection of directories and all of their objects.
            - `[Id <String>]`: 
            - `[Discoverabilities <String>]`: directoryDefinitionDiscoverabilities
            - `[DiscoveryDateTime <DateTime?>]`: Represents the discovery date and time using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
            - `[Name <String>]`: Name of the directory. Must be unique within the synchronization schema. Not nullable.
            - `[Objects <IMicrosoftGraphObjectDefinition[]>]`: Collection of objects supported by the directory.
              - `[Attributes <IMicrosoftGraphAttributeDefinition[]>]`: 
                - `[Anchor <Boolean?>]`: true if the attribute should be used as the anchor for the object. Anchor attributes must have a unique value identifying an object, and must be immutable. Default is false. One, and only one, of the object's attributes must be designated as the anchor to support synchronization.
                - `[ApiExpressions <IMicrosoftGraphStringKeyStringValuePair[]>]`: 
                  - `[Key <String>]`: Key.
                  - `[Value <String>]`: Value.
                - `[CaseExact <Boolean?>]`: true if value of this attribute should be treated as case-sensitive. This setting affects how the synchronization engine detects changes for the attribute.
                - `[DefaultValue <String>]`: 
                - `[FlowNullValues <Boolean?>]`: 'true' to allow null values for attributes.
                - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: Additional extension properties. Unless mentioned explicitly, metadata values should not be changed.
                  - `[Key <String>]`: Name of the metadata property.
                  - `[Value <String>]`: Value of the metadata property.
                - `[Multivalued <Boolean?>]`: true if an attribute can have multiple values. Default is false.
                - `[Mutability <String>]`: mutability
                - `[Name <String>]`: Name of the attribute. Must be unique within the object definition. Not nullable.
                - `[ReferencedObjects <IMicrosoftGraphReferencedObject[]>]`: For attributes with reference type, lists referenced objects (for example, the manager attribute would list User as the referenced object).
                  - `[ReferencedObjectName <String>]`: Name of the referenced object. Must match one of the objects in the directory definition.
                  - `[ReferencedProperty <String>]`: Currently not supported. Name of the property in the referenced object, the value for which is used as the reference.
                - `[Required <Boolean?>]`: true if attribute is required. Object can not be created if any of the required attributes are missing. If during synchronization, the required attribute has no value, the default value will be used. If default the value was not set, synchronization will record an error.
                - `[Type <String>]`: attributeType
              - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: 
              - `[Name <String>]`: 
              - `[SupportedApis <String[]>]`: 
            - `[ReadOnly <Boolean?>]`: 
            - `[Version <String>]`: Read only value that indicates version discovered. null if discovery has not yet occurred.
          - `[SynchronizationRules <IMicrosoftGraphSynchronizationRule[]>]`: A collection of synchronization rules configured for the synchronizationJob or synchronizationTemplate.
            - `[Editable <Boolean?>]`: true if the synchronization rule can be customized; false if this rule is read-only and should not be changed.
            - `[Id <String>]`: Synchronization rule identifier. Must be one of the identifiers recognized by the synchronization engine. Supported rule identifiers can be found in the synchronization template returned by the API.
            - `[Metadata <IMicrosoftGraphStringKeyStringValuePair[]>]`: Additional extension properties. Unless instructed explicitly by the support team, metadata values should not be changed.
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
                  - `[Expression <String>]`: 
                  - `[Name <String>]`: 
                  - `[Parameters <IMicrosoftGraphStringKeyAttributeMappingSourceValuePair[]>]`: 
                    - `[Key <String>]`: The name of the parameter.
                    - `[Value <IMicrosoftGraphAttributeMappingSource>]`: attributeMappingSource
                  - `[Type <String>]`: attributeMappingSourceType
                - `[TargetAttributeName <String>]`: Name of the attribute on the target object.
              - `[Enabled <Boolean?>]`: When true, this object mapping will be processed during synchronization. When false, this object mapping will be skipped.
              - `[FlowTypes <String>]`: objectFlowTypes
              - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: Additional extension properties. Unless mentioned explicitly, metadata values should not be changed.
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
                - `[Groups <IMicrosoftGraphFilterGroup[]>]`: Filter group set used to decide whether given object is in scope for provisioning. This is the filter which should be used in most cases. If an object used to satisfy this filter at a given moment, and then the object or the filter was changed so that filter is not satisfied any longer, such object will get de-provisioned'. An object is considered in scope if ANY of the groups in the collection is evaluated to true.
                - `[InputFilterGroups <IMicrosoftGraphFilterGroup[]>]`: *Experimental* Filter group set used to filter out objects at the early stage of reading them from the directory. If an object doesn't satisfy this filter it will not be processed further. Important to understand is that if an object used to satisfy this filter at a given moment, and then the object or the filter was changed so that filter is no longer satisfied, such object will NOT get de-provisioned. An object is considered in scope if ANY of the groups in the collection is evaluated to true.
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
              - `[Code <String>]`: 
              - `[Message <String>]`: 
              - `[TenantActionable <Boolean?>]`: 
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
            - `[Key <String>]`: Key.
            - `[Value <Int64?>]`: Value.
          - `[TroubleshootingUrl <String>]`: In the event of an error, the URL with the troubleshooting steps for the issue.
        - `[SynchronizationJobSettings <IMicrosoftGraphKeyValuePair[]>]`: Settings associated with the job. Some settings are inherited from the template.
          - `[Name <String>]`: Name for this key-value pair
          - `[Value <String>]`: Value for this key-value pair
        - `[TemplateId <String>]`: Identifier of the synchronization template this job is based on.
      - `[Secrets <IMicrosoftGraphSynchronizationSecretKeyStringValuePair[]>]`: Represents a collection of credentials to access provisioned cloud applications.
        - `[Key <String>]`: synchronizationSecret
        - `[Value <String>]`: The value of the secret.
      - `[Templates <IMicrosoftGraphSynchronizationTemplate[]>]`: Pre-configured synchronization settings for a particular application.
        - `[Id <String>]`: 
        - `[ApplicationId <String>]`: Identifier of the application this template belongs to.
        - `[Default <Boolean?>]`: true if this template is recommended to be the default for the application.
        - `[Description <String>]`: Description of the template.
        - `[Discoverable <Boolean?>]`: true if this template should appear in the collection of templates available for the application instance (service principal).
        - `[FactoryTag <String>]`: One of the well-known factory tags supported by the synchronization engine. The factoryTag tells the synchronization engine which implementation to use when processing jobs based on this template.
        - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: Additional extension properties. Unless mentioned explicitly, metadata values should not be changed.
        - `[Schema <IMicrosoftGraphSynchronizationSchema>]`: synchronizationSchema
    - `[Tags <String[]>]`: Custom strings that can be used to categorize and identify the application. Not nullable.Supports $filter (eq, not, ge, le, startsWith).
    - `[TokenEncryptionKeyId <String>]`: Specifies the keyId of a public key from the keyCredentials collection. When configured, Azure AD encrypts all the tokens it emits by using the key this property points to. The application code that receives the encrypted token must use the matching private key to decrypt the token before it can be used for the signed-in user.
    - `[TokenIssuancePolicies <IMicrosoftGraphTokenIssuancePolicy1[]>]`: 
      - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
      - `[Definition <String[]>]`: A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.
      - `[IsOrganizationDefault <Boolean?>]`: If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.
      - `[Description <String>]`: Description for this policy. Required.
      - `[DisplayName <String>]`: Display name for this policy. Required.
      - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
      - `[Id <String>]`: 
    - `[TokenLifetimePolicies <IMicrosoftGraphTokenLifetimePolicy1[]>]`: The tokenLifetimePolicies assigned to this application. Supports $expand.
      - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
      - `[Definition <String[]>]`: A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.
      - `[IsOrganizationDefault <Boolean?>]`: If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.
      - `[Description <String>]`: Description for this policy. Required.
      - `[DisplayName <String>]`: Display name for this policy. Required.
      - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
      - `[Id <String>]`: 
    - `[UniqueName <String>]`: The unique identifier that can be assigned to an application as an alternative identifier. Immutable. Read-only.
    - `[VerifiedPublisher <IMicrosoftGraphVerifiedPublisher>]`: verifiedPublisher
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AddedDateTime <DateTime?>]`: The timestamp when the verified publisher was first added or most recently updated.
      - `[DisplayName <String>]`: The verified publisher name from the app publisher's Microsoft Partner Network (MPN) account.
      - `[VerifiedPublisherId <String>]`: The ID of the verified publisher from the app publisher's Partner Center account.
    - `[Web <IMicrosoftGraphWebApplication1>]`: webApplication
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[HomePageUrl <String>]`: Home page or landing page of the application.
      - `[ImplicitGrantSettings <IMicrosoftGraphImplicitGrantSettings>]`: implicitGrantSettings
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[EnableAccessTokenIssuance <Boolean?>]`: Specifies whether this web application can request an access token using the OAuth 2.0 implicit flow.
        - `[EnableIdTokenIssuance <Boolean?>]`: Specifies whether this web application can request an ID token using the OAuth 2.0 implicit flow.
      - `[LogoutUrl <String>]`: Specifies the URL that will be used by Microsoft's authorization service to logout an user using front-channel, back-channel or SAML logout protocols.
      - `[Oauth2AllowImplicitFlow <Boolean?>]`: 
      - `[RedirectUriSettings <IMicrosoftGraphRedirectUriSettings[]>]`: Specifies the index of the URLs where user tokens are sent for sign-in. This is only valid for applications using SAML.
        - `[Index <Int32?>]`: Identifies the specific URI within the redirectURIs collection in SAML SSO flows. Defaults to null. The index is unique across all the redirectUris for the application.
        - `[Uri <String>]`: Specifies the URI that tokens are sent to.
      - `[RedirectUris <String[]>]`: Specifies the URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent.
    - `[Windows <IMicrosoftGraphWindowsApplication>]`: windowsApplication
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[PackageSid <String>]`: The package security identifier that Microsoft has assigned the application. Optional. Read-only.
      - `[RedirectUris <String[]>]`: Specifies the URLs where user tokens are sent for sign-in or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent. Only available for applications that support the PersonalMicrosoftAccount signInAudience.
  - `[ConnectorGroupType <String>]`: connectorGroupType
  - `[IsDefault <Boolean?>]`: Indicates if the connectorGroup is the default connectorGroup. Only a single connector group can be the default connectorGroup and this is pre-set by the system. Read-only.
  - `[Members <IMicrosoftGraphConnector[]>]`: 
    - `[Id <String>]`: 
    - `[ExternalIP <String>]`: The external IP address as detected by the the connector server. Read-only.
    - `[MachineName <String>]`: The machine name the connector is installed and running on.
    - `[MemberOf <IMicrosoftGraphConnectorGroup[]>]`: The connectorGroup that the connector is a member of. Read-only.
    - `[Status <String>]`: connectorStatus
  - `[Name <String>]`: The name associated with the connectorGroup.
  - `[Region <String>]`: connectorGroupRegion

CREATEDONBEHALFOF <IMicrosoftGraphDirectoryObject>: directoryObject
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.

EXTENSIONPROPERTIES <IMicrosoftGraphExtensionProperty[]>: Read-only. Nullable. Supports $expand and $filter (eq when counting empty collections).
  - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
  - `[Id <String>]`: 
  - `[AppDisplayName <String>]`: Display name of the application object on which this extension property is defined. Read-only.
  - `[DataType <String>]`: Specifies the data type of the value the extension property can hold. Following values are supported. Not nullable. Binary - 256 bytes maximumBooleanDateTime - Must be specified in ISO 8601 format. Will be stored in UTC.Integer - 32-bit value.LargeInteger - 64-bit value.String - 256 characters maximum
  - `[IsSyncedFromOnPremises <Boolean?>]`: Indicates if this extension property was synced from on-premises active directory using Azure AD Connect. Read-only.
  - `[Name <String>]`: Name of the extension property. Not nullable.
  - `[TargetObjects <String[]>]`: Following values are supported. Not nullable. UserGroupOrganizationDeviceApplication

FEDERATEDIDENTITYCREDENTIALS <IMicrosoftGraphFederatedIdentityCredential[]>: Federated identities for applications. Supports $expand and $filter (eq when counting empty collections).
  - `[Id <String>]`: 
  - `[Audiences <String[]>]`: Lists the audiences that can appear in the external token. This field is mandatory, and defaults to 'api://AzureADTokenExchange'. It says what Microsoft identity platform should accept in the aud claim in the incoming token. This value represents Azure AD in your external identity provider and has no fixed value across identity providers - you may need to create a new application registration in your identity provider to serve as the audience of this token. Required.
  - `[Description <String>]`: The un-validated, user-provided description of the federated identity credential. Optional.
  - `[Issuer <String>]`: The URL of the external identity provider and must match the issuer claim of the external token being exchanged. The combination of the values of issuer and subject must be unique on the app. Required.
  - `[Name <String>]`: is the unique identifier for the federated identity credential, which has a character limit of 120 characters and must be URL friendly. It is immutable once created. Required. Not nullable. Supports $filter (eq).
  - `[Subject <String>]`: Required. The identifier of the external software workload within the external identity provider. Like the audience value, it has no fixed format, as each identity provider uses their own - sometimes a GUID, sometimes a colon delimited identifier, sometimes arbitrary strings. The value here must match the sub claim within the token presented to Azure AD. The combination of issuer and subject must be unique on the app. Supports $filter (eq).

HOMEREALMDISCOVERYPOLICIES <IMicrosoftGraphHomeRealmDiscoveryPolicy1[]>: .
  - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[Id <String>]`: 
    - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
  - `[Definition <String[]>]`: A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.
  - `[IsOrganizationDefault <Boolean?>]`: If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.
  - `[Description <String>]`: Description for this policy. Required.
  - `[DisplayName <String>]`: Display name for this policy. Required.
  - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
  - `[Id <String>]`: 

INFO <IMicrosoftGraphInformationalUrl>: informationalUrl
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[LogoUrl <String>]`: CDN URL to the application's logo, Read-only.
  - `[MarketingUrl <String>]`: Link to the application's marketing page. For example, https://www.contoso.com/app/marketing
  - `[PrivacyStatementUrl <String>]`: Link to the application's privacy statement. For example, https://www.contoso.com/app/privacy
  - `[SupportUrl <String>]`: Link to the application's support page. For example, https://www.contoso.com/app/support
  - `[TermsOfServiceUrl <String>]`: Link to the application's terms of service statement. For example, https://www.contoso.com/app/termsofservice

INPUTOBJECT <IApplicationsIdentity>: Identity Parameter
  - `[AppManagementPolicyId <String>]`: key: id of appManagementPolicy
  - `[AppRoleAssignmentId <String>]`: key: id of appRoleAssignment
  - `[ApplicationId <String>]`: key: id of application
  - `[ApplicationTemplateId <String>]`: key: id of applicationTemplate
  - `[ClaimsMappingPolicyId <String>]`: key: id of claimsMappingPolicy
  - `[ConnectorGroupId <String>]`: key: id of connectorGroup
  - `[ConnectorId <String>]`: key: id of connector
  - `[DelegatedPermissionClassificationId <String>]`: key: id of delegatedPermissionClassification
  - `[DirectoryDefinitionId <String>]`: key: id of directoryDefinition
  - `[DirectoryObjectId <String>]`: key: id of directoryObject
  - `[EndpointId <String>]`: key: id of endpoint
  - `[ExtensionPropertyId <String>]`: key: id of extensionProperty
  - `[FederatedIdentityCredentialId <String>]`: key: id of federatedIdentityCredential
  - `[GroupId <String>]`: key: id of group
  - `[HomeRealmDiscoveryPolicyId <String>]`: key: id of homeRealmDiscoveryPolicy
  - `[LicenseDetailsId <String>]`: key: id of licenseDetails
  - `[OAuth2PermissionGrantId <String>]`: key: id of oAuth2PermissionGrant
  - `[OnPremisesAgentGroupId <String>]`: key: id of onPremisesAgentGroup
  - `[OnPremisesAgentGroupId1 <String>]`: key: id of onPremisesAgentGroup
  - `[OnPremisesAgentId <String>]`: key: id of onPremisesAgent
  - `[OnPremisesPublishingProfileId <String>]`: key: id of onPremisesPublishingProfile
  - `[PublishedResourceId <String>]`: key: id of publishedResource
  - `[ServicePrincipalId <String>]`: key: id of servicePrincipal
  - `[SynchronizationJobId <String>]`: key: id of synchronizationJob
  - `[SynchronizationTemplateId <String>]`: key: id of synchronizationTemplate
  - `[TokenIssuancePolicyId <String>]`: key: id of tokenIssuancePolicy
  - `[TokenLifetimePolicyId <String>]`: key: id of tokenLifetimePolicy
  - `[UserId <String>]`: key: id of user

KEYCREDENTIALS <IMicrosoftGraphKeyCredential[]>: The collection of key credentials associated with the application. Not nullable. Supports $filter (eq, not, ge, le).
  - `[CustomKeyIdentifier <Byte[]>]`: Custom key identifier
  - `[DisplayName <String>]`: Friendly name for the key. Optional.
  - `[EndDateTime <DateTime?>]`: The date and time at which the credential expires. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[Key <Byte[]>]`: Value for the key credential. Should be a Base64 encoded value. Returned only on $select for a single object, that is, GET applications/{applicationId}?$select=keyCredentials or GET servicePrincipals/{servicePrincipalId}?$select=keyCredentials; otherwise, it is always null.
  - `[KeyId <String>]`: The unique identifier for the key.
  - `[StartDateTime <DateTime?>]`: The date and time at which the credential becomes valid.The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[Type <String>]`: The type of key credential; for example, Symmetric, AsymmetricX509Cert.
  - `[Usage <String>]`: A string that describes the purpose for which the key can be used; for example, Verify.

ONPREMISESPUBLISHING <IMicrosoftGraphOnPremisesPublishing>: onPremisesPublishing
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AlternateUrl <String>]`: If you are configuring a traffic manager in front of multiple App Proxy applications, the alternateUrl is the user-friendly URL that will point to the traffic manager.
  - `[ApplicationServerTimeout <String>]`: The duration the connector will wait for a response from the backend application before closing the connection. Possible values are default, long. When set to default, the backend application timeout has a length of 85 seconds. When set to long, the backend timeout is increased to 180 seconds. Use long if your server takes more than 85 seconds to respond to requests or if you are unable to access the application and the error status is 'Backend Timeout'. Default value is default.
  - `[ApplicationType <String>]`: Indicates if this application is an Application Proxy configured application. This is pre-set by the system. Read-only.
  - `[ExternalAuthenticationType <String>]`: externalAuthenticationType
  - `[ExternalUrl <String>]`: The published external url for the application. For example, https://intranet-contoso.msappproxy.net/.
  - `[InternalUrl <String>]`: The internal url of the application. For example, https://intranet/.
  - `[IsBackendCertificateValidationEnabled <Boolean?>]`: Indicates whether backend SSL certificate validation is enabled for the application. For all new Application Proxy apps, the property will be set to true by default. For all existing apps, the property will be set to false.
  - `[IsHttpOnlyCookieEnabled <Boolean?>]`: Indicates if the HTTPOnly cookie flag should be set in the HTTP response headers. Set this value to true to have Application Proxy cookies include the HTTPOnly flag in the HTTP response headers. If using Remote Desktop Services, set this value to False. Default value is false.
  - `[IsOnPremPublishingEnabled <Boolean?>]`: Indicates if the application is currently being published via Application Proxy or not. This is pre-set by the system. Read-only.
  - `[IsPersistentCookieEnabled <Boolean?>]`: Indicates if the Persistent cookie flag should be set in the HTTP response headers. Keep this value set to false. Only use this setting for applications that can't share cookies between processes. For more information about cookie settings, see Cookie settings for accessing on-premises applications in Azure Active Directory. Default value is false.
  - `[IsSecureCookieEnabled <Boolean?>]`: Indicates if the Secure cookie flag should be set in the HTTP response headers. Set this value to true to transmit cookies over a secure channel such as an encrypted HTTPS request. Default value is true.
  - `[IsStateSessionEnabled <Boolean?>]`: Indicates whether validation of the state parameter when the client uses the OAuth 2.0 authorization code grant flow is enabled. This setting allows admins to specify whether they want to enable CSRF protection for their apps.
  - `[IsTranslateHostHeaderEnabled <Boolean?>]`: Indicates if the application should translate urls in the reponse headers. Keep this value as true unless your application required the original host header in the authentication request. Default value is true.
  - `[IsTranslateLinksInBodyEnabled <Boolean?>]`: Indicates if the application should translate urls in the application body. Keep this value as false unless you have hardcoded HTML links to other on-premises applications and don't use custom domains. For more information, see Link translation with Application Proxy. Default value is false.
  - `[OnPremisesApplicationSegments <IMicrosoftGraphOnPremisesApplicationSegment[]>]`: 
    - `[AlternateUrl <String>]`: 
    - `[CorsConfigurations <IMicrosoftGraphCorsConfiguration[]>]`: 
      - `[AllowedHeaders <String[]>]`: 
      - `[AllowedMethods <String[]>]`: 
      - `[AllowedOrigins <String[]>]`: 
      - `[MaxAgeInSeconds <Int32?>]`: 
      - `[Resource <String>]`: 
    - `[ExternalUrl <String>]`: 
    - `[InternalUrl <String>]`: 
  - `[SingleSignOnSettings <IMicrosoftGraphOnPremisesPublishingSingleSignOn>]`: onPremisesPublishingSingleSignOn
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[KerberosSignOnSettings <IMicrosoftGraphKerberosSignOnSettings>]`: kerberosSignOnSettings
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[KerberosServicePrincipalName <String>]`: The Internal Application SPN of the application server. This SPN needs to be in the list of services to which the connector can present delegated credentials.
      - `[KerberosSignOnMappingAttributeType <String>]`: kerberosSignOnMappingAttributeType
    - `[SingleSignOnMode <String>]`: singleSignOnMode
  - `[UseAlternateUrlForTranslationAndRedirect <Boolean?>]`: 
  - `[VerifiedCustomDomainCertificatesMetadata <IMicrosoftGraphVerifiedCustomDomainCertificatesMetadata>]`: verifiedCustomDomainCertificatesMetadata
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ExpiryDate <DateTime?>]`: The expiry date of the custom domain certificate. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[IssueDate <DateTime?>]`: The issue date of the custom domain. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[IssuerName <String>]`: The issuer name of the custom domain certificate.
    - `[SubjectName <String>]`: The subject name of the custom domain certificate.
    - `[Thumbprint <String>]`: The thumbprint associated with the custom domain certificate.
  - `[VerifiedCustomDomainKeyCredential <IMicrosoftGraphKeyCredential>]`: keyCredential
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[CustomKeyIdentifier <Byte[]>]`: Custom key identifier
    - `[DisplayName <String>]`: Friendly name for the key. Optional.
    - `[EndDateTime <DateTime?>]`: The date and time at which the credential expires. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[Key <Byte[]>]`: Value for the key credential. Should be a Base64 encoded value. Returned only on $select for a single object, that is, GET applications/{applicationId}?$select=keyCredentials or GET servicePrincipals/{servicePrincipalId}?$select=keyCredentials; otherwise, it is always null.
    - `[KeyId <String>]`: The unique identifier for the key.
    - `[StartDateTime <DateTime?>]`: The date and time at which the credential becomes valid.The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[Type <String>]`: The type of key credential; for example, Symmetric, AsymmetricX509Cert.
    - `[Usage <String>]`: A string that describes the purpose for which the key can be used; for example, Verify.
  - `[VerifiedCustomDomainPasswordCredential <IMicrosoftGraphPasswordCredential>]`: passwordCredential
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[CustomKeyIdentifier <Byte[]>]`: Do not use.
    - `[DisplayName <String>]`: Friendly name for the password. Optional.
    - `[EndDateTime <DateTime?>]`: The date and time at which the password expires represented using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Optional.
    - `[Hint <String>]`: Contains the first three characters of the password. Read-only.
    - `[KeyId <String>]`: The unique identifier for the password.
    - `[SecretText <String>]`: Read-only; Contains the strong passwords generated by Azure AD that are 16-64 characters in length. The generated password value is only returned during the initial POST request to addPassword. There is no way to retrieve this password in the future.
    - `[StartDateTime <DateTime?>]`: The date and time at which the password becomes valid. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Optional.

OPTIONALCLAIMS <IMicrosoftGraphOptionalClaims>: optionalClaims
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AccessToken <IMicrosoftGraphOptionalClaim[]>]`: The optional claims returned in the JWT access token.
    - `[AdditionalProperties <String[]>]`: Additional properties of the claim. If a property exists in this collection, it modifies the behavior of the optional claim specified in the name property.
    - `[Essential <Boolean?>]`: If the value is true, the claim specified by the client is necessary to ensure a smooth authorization experience for the specific task requested by the end user. The default value is false.
    - `[Name <String>]`: The name of the optional claim.
    - `[Source <String>]`: The source (directory object) of the claim. There are predefined claims and user-defined claims from extension properties. If the source value is null, the claim is a predefined optional claim. If the source value is user, the value in the name property is the extension property from the user object.
  - `[IdToken <IMicrosoftGraphOptionalClaim[]>]`: The optional claims returned in the JWT ID token.
  - `[Saml2Token <IMicrosoftGraphOptionalClaim[]>]`: The optional claims returned in the SAML token.

OWNERS <IMicrosoftGraphDirectoryObject[]>: Directory objects that are owners of the application. Read-only. Nullable. Supports $expand.
  - `[Id <String>]`: 
  - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.

PARENTALCONTROLSETTINGS <IMicrosoftGraphParentalControlSettings>: parentalControlSettings
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CountriesBlockedForMinors <String[]>]`: Specifies the two-letter ISO country codes. Access to the application will be blocked for minors from the countries specified in this list.
  - `[LegalAgeGroupRule <String>]`: Specifies the legal age group rule that applies to users of the app. Can be set to one of the following values: ValueDescriptionAllowDefault. Enforces the legal minimum. This means parental consent is required for minors in the European Union and Korea.RequireConsentForPrivacyServicesEnforces the user to specify date of birth to comply with COPPA rules. RequireConsentForMinorsRequires parental consent for ages below 18, regardless of country minor rules.RequireConsentForKidsRequires parental consent for ages below 14, regardless of country minor rules.BlockMinorsBlocks minors from using the app.

PASSWORDCREDENTIALS <IMicrosoftGraphPasswordCredential[]>: The collection of password credentials associated with the application. Not nullable.
  - `[CustomKeyIdentifier <Byte[]>]`: Do not use.
  - `[DisplayName <String>]`: Friendly name for the password. Optional.
  - `[EndDateTime <DateTime?>]`: The date and time at which the password expires represented using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Optional.
  - `[Hint <String>]`: Contains the first three characters of the password. Read-only.
  - `[KeyId <String>]`: The unique identifier for the password.
  - `[SecretText <String>]`: Read-only; Contains the strong passwords generated by Azure AD that are 16-64 characters in length. The generated password value is only returned during the initial POST request to addPassword. There is no way to retrieve this password in the future.
  - `[StartDateTime <DateTime?>]`: The date and time at which the password becomes valid. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Optional.

PUBLICCLIENT <IMicrosoftGraphPublicClientApplication>: publicClientApplication
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[RedirectUris <String[]>]`: Specifies the URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent.

REQUIREDRESOURCEACCESS <IMicrosoftGraphRequiredResourceAccess[]>: Specifies the resources that the application needs to access. This property also specifies the set of delegated permissions and application roles that it needs for each of those resources. This configuration of access to the required resources drives the consent experience. No more than 50 resource services (APIs) can be configured. Beginning mid-October 2021, the total number of required permissions must not exceed 400. Not nullable. Supports $filter (eq, not, ge, le).
  - `[ResourceAccess <IMicrosoftGraphResourceAccess[]>]`: The list of OAuth2.0 permission scopes and app roles that the application requires from the specified resource.
    - `[Id <String>]`: The unique identifier of an app role or delegated permission exposed by the resource application. For delegated permissions, this should match the id property of one of the delegated permissions in the oauth2PermissionScopes collection of the resource application's service principal. For app roles (application permissions), this should match the id property of an app role in the appRoles collection of the resource application's service principal.
    - `[Type <String>]`: Specifies whether the id property references a delegated permission or an app role (application permission). The possible values are: Scope (for delegated permissions) or Role (for app roles).
  - `[ResourceAppId <String>]`: The unique identifier for the resource that the application requires access to. This should be equal to the appId declared on the target resource application.

SPA <IMicrosoftGraphSpaApplication>: spaApplication
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[RedirectUris <String[]>]`: Specifies the URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent.

SYNCHRONIZATION <IMicrosoftGraphSynchronization>: synchronization
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[Jobs <IMicrosoftGraphSynchronizationJob[]>]`: Performs synchronization by periodically running in the background, polling for changes in one directory, and pushing them to another directory.
    - `[Id <String>]`: 
    - `[Schedule <IMicrosoftGraphSynchronizationSchedule>]`: synchronizationSchedule
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Expiration <DateTime?>]`: Date and time when this job will expire. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[Interval <TimeSpan?>]`: The interval between synchronization iterations.
      - `[State <String>]`: synchronizationScheduleState
    - `[Schema <IMicrosoftGraphSynchronizationSchema>]`: synchronizationSchema
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: 
      - `[Directories <IMicrosoftGraphDirectoryDefinition[]>]`: Contains the collection of directories and all of their objects.
        - `[Id <String>]`: 
        - `[Discoverabilities <String>]`: directoryDefinitionDiscoverabilities
        - `[DiscoveryDateTime <DateTime?>]`: Represents the discovery date and time using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[Name <String>]`: Name of the directory. Must be unique within the synchronization schema. Not nullable.
        - `[Objects <IMicrosoftGraphObjectDefinition[]>]`: Collection of objects supported by the directory.
          - `[Attributes <IMicrosoftGraphAttributeDefinition[]>]`: 
            - `[Anchor <Boolean?>]`: true if the attribute should be used as the anchor for the object. Anchor attributes must have a unique value identifying an object, and must be immutable. Default is false. One, and only one, of the object's attributes must be designated as the anchor to support synchronization.
            - `[ApiExpressions <IMicrosoftGraphStringKeyStringValuePair[]>]`: 
              - `[Key <String>]`: Key.
              - `[Value <String>]`: Value.
            - `[CaseExact <Boolean?>]`: true if value of this attribute should be treated as case-sensitive. This setting affects how the synchronization engine detects changes for the attribute.
            - `[DefaultValue <String>]`: 
            - `[FlowNullValues <Boolean?>]`: 'true' to allow null values for attributes.
            - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: Additional extension properties. Unless mentioned explicitly, metadata values should not be changed.
              - `[Key <String>]`: Name of the metadata property.
              - `[Value <String>]`: Value of the metadata property.
            - `[Multivalued <Boolean?>]`: true if an attribute can have multiple values. Default is false.
            - `[Mutability <String>]`: mutability
            - `[Name <String>]`: Name of the attribute. Must be unique within the object definition. Not nullable.
            - `[ReferencedObjects <IMicrosoftGraphReferencedObject[]>]`: For attributes with reference type, lists referenced objects (for example, the manager attribute would list User as the referenced object).
              - `[ReferencedObjectName <String>]`: Name of the referenced object. Must match one of the objects in the directory definition.
              - `[ReferencedProperty <String>]`: Currently not supported. Name of the property in the referenced object, the value for which is used as the reference.
            - `[Required <Boolean?>]`: true if attribute is required. Object can not be created if any of the required attributes are missing. If during synchronization, the required attribute has no value, the default value will be used. If default the value was not set, synchronization will record an error.
            - `[Type <String>]`: attributeType
          - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: 
          - `[Name <String>]`: 
          - `[SupportedApis <String[]>]`: 
        - `[ReadOnly <Boolean?>]`: 
        - `[Version <String>]`: Read only value that indicates version discovered. null if discovery has not yet occurred.
      - `[SynchronizationRules <IMicrosoftGraphSynchronizationRule[]>]`: A collection of synchronization rules configured for the synchronizationJob or synchronizationTemplate.
        - `[Editable <Boolean?>]`: true if the synchronization rule can be customized; false if this rule is read-only and should not be changed.
        - `[Id <String>]`: Synchronization rule identifier. Must be one of the identifiers recognized by the synchronization engine. Supported rule identifiers can be found in the synchronization template returned by the API.
        - `[Metadata <IMicrosoftGraphStringKeyStringValuePair[]>]`: Additional extension properties. Unless instructed explicitly by the support team, metadata values should not be changed.
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
              - `[Expression <String>]`: 
              - `[Name <String>]`: 
              - `[Parameters <IMicrosoftGraphStringKeyAttributeMappingSourceValuePair[]>]`: 
                - `[Key <String>]`: The name of the parameter.
                - `[Value <IMicrosoftGraphAttributeMappingSource>]`: attributeMappingSource
              - `[Type <String>]`: attributeMappingSourceType
            - `[TargetAttributeName <String>]`: Name of the attribute on the target object.
          - `[Enabled <Boolean?>]`: When true, this object mapping will be processed during synchronization. When false, this object mapping will be skipped.
          - `[FlowTypes <String>]`: objectFlowTypes
          - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: Additional extension properties. Unless mentioned explicitly, metadata values should not be changed.
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
            - `[Groups <IMicrosoftGraphFilterGroup[]>]`: Filter group set used to decide whether given object is in scope for provisioning. This is the filter which should be used in most cases. If an object used to satisfy this filter at a given moment, and then the object or the filter was changed so that filter is not satisfied any longer, such object will get de-provisioned'. An object is considered in scope if ANY of the groups in the collection is evaluated to true.
            - `[InputFilterGroups <IMicrosoftGraphFilterGroup[]>]`: *Experimental* Filter group set used to filter out objects at the early stage of reading them from the directory. If an object doesn't satisfy this filter it will not be processed further. Important to understand is that if an object used to satisfy this filter at a given moment, and then the object or the filter was changed so that filter is no longer satisfied, such object will NOT get de-provisioned. An object is considered in scope if ANY of the groups in the collection is evaluated to true.
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
          - `[Code <String>]`: 
          - `[Message <String>]`: 
          - `[TenantActionable <Boolean?>]`: 
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
        - `[Key <String>]`: Key.
        - `[Value <Int64?>]`: Value.
      - `[TroubleshootingUrl <String>]`: In the event of an error, the URL with the troubleshooting steps for the issue.
    - `[SynchronizationJobSettings <IMicrosoftGraphKeyValuePair[]>]`: Settings associated with the job. Some settings are inherited from the template.
      - `[Name <String>]`: Name for this key-value pair
      - `[Value <String>]`: Value for this key-value pair
    - `[TemplateId <String>]`: Identifier of the synchronization template this job is based on.
  - `[Secrets <IMicrosoftGraphSynchronizationSecretKeyStringValuePair[]>]`: Represents a collection of credentials to access provisioned cloud applications.
    - `[Key <String>]`: synchronizationSecret
    - `[Value <String>]`: The value of the secret.
  - `[Templates <IMicrosoftGraphSynchronizationTemplate[]>]`: Pre-configured synchronization settings for a particular application.
    - `[Id <String>]`: 
    - `[ApplicationId <String>]`: Identifier of the application this template belongs to.
    - `[Default <Boolean?>]`: true if this template is recommended to be the default for the application.
    - `[Description <String>]`: Description of the template.
    - `[Discoverable <Boolean?>]`: true if this template should appear in the collection of templates available for the application instance (service principal).
    - `[FactoryTag <String>]`: One of the well-known factory tags supported by the synchronization engine. The factoryTag tells the synchronization engine which implementation to use when processing jobs based on this template.
    - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: Additional extension properties. Unless mentioned explicitly, metadata values should not be changed.
    - `[Schema <IMicrosoftGraphSynchronizationSchema>]`: synchronizationSchema

TOKENISSUANCEPOLICIES <IMicrosoftGraphTokenIssuancePolicy1[]>: .
  - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[Id <String>]`: 
    - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
  - `[Definition <String[]>]`: A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.
  - `[IsOrganizationDefault <Boolean?>]`: If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.
  - `[Description <String>]`: Description for this policy. Required.
  - `[DisplayName <String>]`: Display name for this policy. Required.
  - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
  - `[Id <String>]`: 

TOKENLIFETIMEPOLICIES <IMicrosoftGraphTokenLifetimePolicy1[]>: The tokenLifetimePolicies assigned to this application. Supports $expand.
  - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[Id <String>]`: 
    - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
  - `[Definition <String[]>]`: A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.
  - `[IsOrganizationDefault <Boolean?>]`: If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.
  - `[Description <String>]`: Description for this policy. Required.
  - `[DisplayName <String>]`: Display name for this policy. Required.
  - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
  - `[Id <String>]`: 

VERIFIEDPUBLISHER <IMicrosoftGraphVerifiedPublisher>: verifiedPublisher
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AddedDateTime <DateTime?>]`: The timestamp when the verified publisher was first added or most recently updated.
  - `[DisplayName <String>]`: The verified publisher name from the app publisher's Microsoft Partner Network (MPN) account.
  - `[VerifiedPublisherId <String>]`: The ID of the verified publisher from the app publisher's Partner Center account.

WEB <IMicrosoftGraphWebApplication1>: webApplication
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[HomePageUrl <String>]`: Home page or landing page of the application.
  - `[ImplicitGrantSettings <IMicrosoftGraphImplicitGrantSettings>]`: implicitGrantSettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[EnableAccessTokenIssuance <Boolean?>]`: Specifies whether this web application can request an access token using the OAuth 2.0 implicit flow.
    - `[EnableIdTokenIssuance <Boolean?>]`: Specifies whether this web application can request an ID token using the OAuth 2.0 implicit flow.
  - `[LogoutUrl <String>]`: Specifies the URL that will be used by Microsoft's authorization service to logout an user using front-channel, back-channel or SAML logout protocols.
  - `[Oauth2AllowImplicitFlow <Boolean?>]`: 
  - `[RedirectUriSettings <IMicrosoftGraphRedirectUriSettings[]>]`: Specifies the index of the URLs where user tokens are sent for sign-in. This is only valid for applications using SAML.
    - `[Index <Int32?>]`: Identifies the specific URI within the redirectURIs collection in SAML SSO flows. Defaults to null. The index is unique across all the redirectUris for the application.
    - `[Uri <String>]`: Specifies the URI that tokens are sent to.
  - `[RedirectUris <String[]>]`: Specifies the URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent.

WINDOWS <IMicrosoftGraphWindowsApplication>: windowsApplication
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[PackageSid <String>]`: The package security identifier that Microsoft has assigned the application. Optional. Read-only.
  - `[RedirectUris <String[]>]`: Specifies the URLs where user tokens are sent for sign-in or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent. Only available for applications that support the PersonalMicrosoftAccount signInAudience.

## RELATED LINKS

