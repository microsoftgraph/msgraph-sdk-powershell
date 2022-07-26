---
external help file:
Module Name: Microsoft.Graph.Applications
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.applications/new-mgserviceprincipal
schema: 2.0.0
---

# New-MgServicePrincipal

## SYNOPSIS
Create servicePrincipal

## SYNTAX

### CreateExpanded (Default)
```
New-MgServicePrincipal [-AccountEnabled] [-AddIns <IMicrosoftGraphAddIn[]>]
 [-AdditionalProperties <Hashtable>] [-AlternativeNames <String[]>] [-AppDescription <String>]
 [-AppDisplayName <String>] [-AppId <String>] [-ApplicationTemplateId <String>]
 [-AppManagementPolicies <IMicrosoftGraphAppManagementPolicy[]>] [-AppOwnerOrganizationId <String>]
 [-AppRoleAssignedTo <IMicrosoftGraphAppRoleAssignment1[]>] [-AppRoleAssignmentRequired]
 [-AppRoleAssignments <IMicrosoftGraphAppRoleAssignment1[]>] [-AppRoles <IMicrosoftGraphAppRole[]>]
 [-ClaimsMappingPolicies <IMicrosoftGraphClaimsMappingPolicy1[]>]
 [-CreatedObjects <IMicrosoftGraphDirectoryObject[]>] [-CustomSecurityAttributes <Hashtable>]
 [-DelegatedPermissionClassifications <IMicrosoftGraphDelegatedPermissionClassification[]>]
 [-DeletedDateTime <DateTime>] [-Description <String>] [-DisabledByMicrosoftStatus <String>]
 [-DisplayName <String>] [-Endpoints <IMicrosoftGraphEndpoint[]>] [-ErrorUrl <String>]
 [-FederatedIdentityCredentials <IMicrosoftGraphFederatedIdentityCredential[]>] [-Homepage <String>]
 [-HomeRealmDiscoveryPolicies <IMicrosoftGraphHomeRealmDiscoveryPolicy1[]>] [-Id <String>]
 [-Info <IMicrosoftGraphInformationalUrl>] [-KeyCredentials <IMicrosoftGraphKeyCredential[]>]
 [-LicenseDetails <IMicrosoftGraphLicenseDetails[]>] [-LoginUrl <String>] [-LogoutUrl <String>]
 [-MemberOf <IMicrosoftGraphDirectoryObject[]>] [-Notes <String>] [-NotificationEmailAddresses <String[]>]
 [-Oauth2PermissionGrants <IMicrosoftGraphOAuth2PermissionGrant1[]>]
 [-OwnedObjects <IMicrosoftGraphDirectoryObject[]>] [-Owners <IMicrosoftGraphDirectoryObject[]>]
 [-PasswordCredentials <IMicrosoftGraphPasswordCredential[]>]
 [-PasswordSingleSignOnSettings <IMicrosoftGraphPasswordSingleSignOnSettings>]
 [-PreferredSingleSignOnMode <String>] [-PreferredTokenSigningKeyEndDateTime <DateTime>]
 [-PreferredTokenSigningKeyThumbprint <String>]
 [-PublishedPermissionScopes <IMicrosoftGraphPermissionScope[]>] [-PublisherName <String>]
 [-ReplyUrls <String[]>] [-SamlMetadataUrl <String>]
 [-SamlSingleSignOnSettings <IMicrosoftGraphSamlSingleSignOnSettings>] [-ServicePrincipalNames <String[]>]
 [-ServicePrincipalType <String>] [-SignInAudience <String>]
 [-Synchronization <IMicrosoftGraphSynchronization>] [-Tags <String[]>] [-TokenEncryptionKeyId <String>]
 [-TokenIssuancePolicies <IMicrosoftGraphTokenIssuancePolicy1[]>]
 [-TokenLifetimePolicies <IMicrosoftGraphTokenLifetimePolicy1[]>]
 [-TransitiveMemberOf <IMicrosoftGraphDirectoryObject[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgServicePrincipal -BodyParameter <IMicrosoftGraphServicePrincipal1> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create servicePrincipal

## EXAMPLES

### Example 1: Create a new service principal object
```powershell
$ServicePrincipalID=@{
  "AppId" = "fc876dd1-6bcb-4304-b9b6-18ddf1526b62"
  }
New-MgServicePrincipal -BodyParameter $ServicePrincipalId | 
  Format-List id, DisplayName, AppId, SignInAudience

Id             : ac483a5f-f291-4499-8a62-058547724579
DisplayName    : Example App
AppId          : ffdf268a-2fe2-49e1-8cd7-66ecb61641ec
SignInAudience : AzureADandPersonalMicrosoftAccount
```

In this example, the first command defines the service principal object in the variable $ServiceprincipalId.
The second command creates a new service principal object.

## PARAMETERS

### -AccountEnabled
true if the service principal account is enabled; otherwise, false.
Supports $filter (eq, ne, not, in).

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

### -AddIns
Defines custom behavior that a consuming service can use to call an app in specific contexts.
For example, applications that can render file streams may set the addIns property for its 'FileHandler' functionality.
This will let services like Microsoft 365 call the application in the context of a document the user is working on.
To construct, please use Get-Help -Online and see NOTES section for ADDINS properties and create a hash table.

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

### -AlternativeNames
Used to retrieve service principals by subscription, identify resource group and full resource ids for managed identities.
Supports $filter (eq, not, ge, le, startsWith).

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

### -AppDescription
The description exposed by the associated application.

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

### -AppDisplayName
The display name exposed by the associated application.

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

### -AppId
The unique identifier for the associated application (its appId property).
Supports $filter (eq, ne, not, in, startsWith).

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
Unique identifier of the applicationTemplate that the servicePrincipal was created from.
Read-only.
Supports $filter (eq, ne, NOT, startsWith).

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
The appManagementPolicy applied to this service principal.
To construct, please use Get-Help -Online and see NOTES section for APPMANAGEMENTPOLICIES properties and create a hash table.

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

### -AppOwnerOrganizationId
Contains the tenant id where the application is registered.
This is applicable only to service principals backed by applications.Supports $filter (eq, ne, NOT, ge, le).

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

### -AppRoleAssignedTo
App role assignments for this app or service, granted to users, groups, and other service principals.Supports $expand.
To construct, please use Get-Help -Online and see NOTES section for APPROLEASSIGNEDTO properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAppRoleAssignment1[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AppRoleAssignmentRequired
Specifies whether users or other service principals need to be granted an app role assignment for this service principal before users can sign in or apps can get tokens.
The default value is false.
Not nullable.
Supports $filter (eq, ne, NOT).

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

### -AppRoleAssignments
App role assignment for another app or service, granted to this service principal.
Supports $expand.
To construct, please use Get-Help -Online and see NOTES section for APPROLEASSIGNMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAppRoleAssignment1[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AppRoles
The roles exposed by the application which this service principal represents.
For more information see the appRoles property definition on the application entity.
Not nullable.
To construct, please use Get-Help -Online and see NOTES section for APPROLES properties and create a hash table.

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
servicePrincipal
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphServicePrincipal1
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ClaimsMappingPolicies
The claimsMappingPolicies assigned to this service principal.
Supports $expand.
To construct, please use Get-Help -Online and see NOTES section for CLAIMSMAPPINGPOLICIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphClaimsMappingPolicy1[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedObjects
Directory objects created by this service principal.
Read-only.
Nullable.
To construct, please use Get-Help -Online and see NOTES section for CREATEDOBJECTS properties and create a hash table.

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

### -CustomSecurityAttributes
customSecurityAttributeValue

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

### -DelegatedPermissionClassifications
The permission classifications for delegated permissions exposed by the app that this service principal represents.
Supports $expand.
To construct, please use Get-Help -Online and see NOTES section for DELEGATEDPERMISSIONCLASSIFICATIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDelegatedPermissionClassification[]
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
Free text field to provide an internal end-user facing description of the service principal.
End-user portals such MyApps will display the application description in this field.
The maximum allowed size is 1024 characters.
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
Possible values are: null (default value), NotDisabled, and DisabledDueToViolationOfServicesAgreement (reasons may include suspicious, abusive, or malicious activity, or a violation of the Microsoft Services Agreement).
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
The display name for the service principal.
Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values), $search, and $orderBy.

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

### -Endpoints
Endpoints available for discovery.
Services like Sharepoint populate this property with a tenant specific SharePoint endpoints that other applications can discover and use in their experiences.
To construct, please use Get-Help -Online and see NOTES section for ENDPOINTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEndpoint[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ErrorUrl
Deprecated.
Don't use.

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

### -FederatedIdentityCredentials
.
To construct, please use Get-Help -Online and see NOTES section for FEDERATEDIDENTITYCREDENTIALS properties and create a hash table.

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

### -Homepage
Home page or landing page of the application.

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

### -HomeRealmDiscoveryPolicies
The homeRealmDiscoveryPolicies assigned to this service principal.
Supports $expand.
To construct, please use Get-Help -Online and see NOTES section for HOMEREALMDISCOVERYPOLICIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphHomeRealmDiscoveryPolicy1[]
Parameter Sets: CreateExpanded
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
To construct, please use Get-Help -Online and see NOTES section for INFO properties and create a hash table.

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

### -KeyCredentials
The collection of key credentials associated with the service principal.
Not nullable.
Supports $filter (eq, not, ge, le).
To construct, please use Get-Help -Online and see NOTES section for KEYCREDENTIALS properties and create a hash table.

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

### -LicenseDetails
.
To construct, please use Get-Help -Online and see NOTES section for LICENSEDETAILS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphLicenseDetails[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LoginUrl
Specifies the URL where the service provider redirects the user to Azure AD to authenticate.
Azure AD uses the URL to launch the application from Microsoft 365 or the Azure AD My Apps.
When blank, Azure AD performs IdP-initiated sign-on for applications configured with SAML-based single sign-on.
The user launches the application from Microsoft 365, the Azure AD My Apps, or the Azure AD SSO URL.

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

### -LogoutUrl
Specifies the URL that will be used by Microsoft's authorization service to logout an user using OpenId Connect front-channel, back-channel or SAML logout protocols.

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

### -MemberOf
Roles that this service principal is a member of.
HTTP Methods: GET Read-only.
Nullable.
Supports $expand.
To construct, please use Get-Help -Online and see NOTES section for MEMBEROF properties and create a hash table.

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

### -Notes
Free text field to capture information about the service principal, typically used for operational purposes.
Maximum allowed size is 1024 characters.

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

### -NotificationEmailAddresses
Specifies the list of email addresses where Azure AD sends a notification when the active certificate is near the expiration date.
This is only for the certificates used to sign the SAML token issued for Azure AD Gallery applications.

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

### -Oauth2PermissionGrants
Delegated permission grants authorizing this service principal to access an API on behalf of a signed-in user.
Read-only.
Nullable.
To construct, please use Get-Help -Online and see NOTES section for OAUTH2PERMISSIONGRANTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOAuth2PermissionGrant1[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OwnedObjects
Directory objects that are owned by this service principal.
Read-only.
Nullable.
Supports $expand.
To construct, please use Get-Help -Online and see NOTES section for OWNEDOBJECTS properties and create a hash table.

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

### -Owners
Directory objects that are owners of this servicePrincipal.
The owners are a set of non-admin users or servicePrincipals who are allowed to modify this object.
Read-only.
Nullable.
Supports $expand.
To construct, please use Get-Help -Online and see NOTES section for OWNERS properties and create a hash table.

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

### -PasswordCredentials
The collection of password credentials associated with the service principal.
Not nullable.
To construct, please use Get-Help -Online and see NOTES section for PASSWORDCREDENTIALS properties and create a hash table.

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

### -PasswordSingleSignOnSettings
passwordSingleSignOnSettings
To construct, please use Get-Help -Online and see NOTES section for PASSWORDSINGLESIGNONSETTINGS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPasswordSingleSignOnSettings
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PreferredSingleSignOnMode
Specifies the single sign-on mode configured for this application.
Azure AD uses the preferred single sign-on mode to launch the application from Microsoft 365 or the Azure AD My Apps.
The supported values are password, saml, notSupported, and oidc.

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

### -PreferredTokenSigningKeyEndDateTime
Specifies the expiration date of the keyCredential used for token signing, marked by preferredTokenSigningKeyThumbprint.

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

### -PreferredTokenSigningKeyThumbprint
Reserved for internal use only.
Do not write or otherwise rely on this property.
May be removed in future versions.

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

### -PublishedPermissionScopes
The delegated permissions exposed by the application.
For more information see the oauth2PermissionScopes property on the application entity's api property.
Not nullable.
Note: This property is named oauth2PermissionScopes in v1.0.
To construct, please use Get-Help -Online and see NOTES section for PUBLISHEDPERMISSIONSCOPES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPermissionScope[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PublisherName
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

### -ReplyUrls
The URLs that user tokens are sent to for sign in with the associated application, or the redirect URIs that OAuth 2.0 authorization codes and access tokens are sent to for the associated application.
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

### -SamlMetadataUrl
The url where the service exposes SAML metadata for federation.

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

### -SamlSingleSignOnSettings
samlSingleSignOnSettings
To construct, please use Get-Help -Online and see NOTES section for SAMLSINGLESIGNONSETTINGS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSamlSingleSignOnSettings
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ServicePrincipalNames
Contains the list of identifiersUris, copied over from the associated application.
Additional values can be added to hybrid applications.
These values can be used to identify the permissions exposed by this app within Azure AD.
For example,Client apps can specify a resource URI which is based on the values of this property to acquire an access token, which is the URI returned in the 'aud' claim.The any operator is required for filter expressions on multi-valued properties.
Not nullable.
Supports $filter (eq, not, ge, le, startsWith).

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

### -ServicePrincipalType
Identifies if the service principal represents an application or a managed identity.
This is set by Azure AD internally.
For a service principal that represents an application this is set as Application.
For a service principal that represent a managed identity this is set as ManagedIdentity.
The SocialIdp type is for internal use.

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

### -SignInAudience
Specifies the Microsoft accounts that are supported for the current application.
Read-only.
Supported values are:AzureADMyOrg: Users with a Microsoft work or school account in my organization’s Azure AD tenant (single-tenant).AzureADMultipleOrgs: Users with a Microsoft work or school account in any organization’s Azure AD tenant (multi-tenant).AzureADandPersonalMicrosoftAccount: Users with a personal Microsoft account, or a work or school account in any organization’s Azure AD tenant.PersonalMicrosoftAccount: Users with a personal Microsoft account only.

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

### -Synchronization
synchronization
To construct, please use Get-Help -Online and see NOTES section for SYNCHRONIZATION properties and create a hash table.

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
Custom strings that can be used to categorize and identify the service principal.
Not nullable.
Supports $filter (eq, not, ge, le, startsWith).

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
When configured, Azure AD issues tokens for this application encrypted using the key specified by this property.
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
The tokenIssuancePolicies assigned to this service principal.
Supports $expand.
To construct, please use Get-Help -Online and see NOTES section for TOKENISSUANCEPOLICIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTokenIssuancePolicy1[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TokenLifetimePolicies
The tokenLifetimePolicies assigned to this service principal.
Supports $expand.
To construct, please use Get-Help -Online and see NOTES section for TOKENLIFETIMEPOLICIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTokenLifetimePolicy1[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TransitiveMemberOf
.
To construct, please use Get-Help -Online and see NOTES section for TRANSITIVEMEMBEROF properties and create a hash table.

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphServicePrincipal1

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphServicePrincipal1

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ADDINS <IMicrosoftGraphAddIn[]>: Defines custom behavior that a consuming service can use to call an app in specific contexts. For example, applications that can render file streams may set the addIns property for its 'FileHandler' functionality. This will let services like Microsoft 365 call the application in the context of a document the user is working on.
  - `[Id <String>]`: 
  - `[Properties <IMicrosoftGraphKeyValue[]>]`: 
    - `[Key <String>]`: Contains the name of the field that a value is associated with. When a sign in or domain hint is included in the sign-in request, corresponding fields are included as key-value pairs. Possible keys: Login hint present, Domain hint present.
    - `[Value <String>]`: Contains the corresponding value for the specified key. The value is true if a sign in hint was included in the sign-in request; otherwise false. The value is true if a domain hint was included in the sign-in request; otherwise false.
  - `[Type <String>]`: 

APPMANAGEMENTPOLICIES <IMicrosoftGraphAppManagementPolicy[]>: The appManagementPolicy applied to this service principal.
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

APPROLEASSIGNEDTO <IMicrosoftGraphAppRoleAssignment1[]>: App role assignments for this app or service, granted to users, groups, and other service principals.Supports $expand.
  - `[Id <String>]`: 
  - `[AppRoleId <String>]`: The identifier (id) for the app role which is assigned to the principal. This app role must be exposed in the appRoles property on the resource application's service principal (resourceId). If the resource application has not declared any app roles, a default app role ID of 00000000-0000-0000-0000-000000000000 can be specified to signal that the principal is assigned to the resource app without any specific app roles. Required on create.
  - `[CreationTimestamp <DateTime?>]`: The time when the app role assignment was created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
  - `[PrincipalDisplayName <String>]`: The display name of the user, group, or service principal that was granted the app role assignment. Read-only. Supports $filter (eq and startswith).
  - `[PrincipalId <String>]`: The unique identifier (id) for the user, group, or service principal being granted the app role. Required on create.
  - `[PrincipalType <String>]`: The type of the assigned principal. This can either be User, Group, or ServicePrincipal. Read-only.
  - `[ResourceDisplayName <String>]`: The display name of the resource app's service principal to which the assignment is made.
  - `[ResourceId <String>]`: The unique identifier (id) for the resource service principal for which the assignment is made. Required on create. Supports $filter (eq only).

APPROLEASSIGNMENTS <IMicrosoftGraphAppRoleAssignment1[]>: App role assignment for another app or service, granted to this service principal. Supports $expand.
  - `[Id <String>]`: 
  - `[AppRoleId <String>]`: The identifier (id) for the app role which is assigned to the principal. This app role must be exposed in the appRoles property on the resource application's service principal (resourceId). If the resource application has not declared any app roles, a default app role ID of 00000000-0000-0000-0000-000000000000 can be specified to signal that the principal is assigned to the resource app without any specific app roles. Required on create.
  - `[CreationTimestamp <DateTime?>]`: The time when the app role assignment was created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
  - `[PrincipalDisplayName <String>]`: The display name of the user, group, or service principal that was granted the app role assignment. Read-only. Supports $filter (eq and startswith).
  - `[PrincipalId <String>]`: The unique identifier (id) for the user, group, or service principal being granted the app role. Required on create.
  - `[PrincipalType <String>]`: The type of the assigned principal. This can either be User, Group, or ServicePrincipal. Read-only.
  - `[ResourceDisplayName <String>]`: The display name of the resource app's service principal to which the assignment is made.
  - `[ResourceId <String>]`: The unique identifier (id) for the resource service principal for which the assignment is made. Required on create. Supports $filter (eq only).

APPROLES <IMicrosoftGraphAppRole[]>: The roles exposed by the application which this service principal represents. For more information see the appRoles property definition on the application entity. Not nullable.
  - `[AllowedMemberTypes <String[]>]`: Specifies whether this app role can be assigned to users and groups (by setting to ['User']), to other application's (by setting to ['Application'], or both (by setting to ['User', 'Application']). App roles supporting assignment to other applications' service principals are also known as application permissions. The 'Application' value is only supported for app roles defined on application entities.
  - `[Description <String>]`: The description for the app role. This is displayed when the app role is being assigned and, if the app role functions as an application permission, during  consent experiences.
  - `[DisplayName <String>]`: Display name for the permission that appears in the app role assignment and consent experiences.
  - `[Id <String>]`: Unique role identifier inside the appRoles collection. When creating a new app role, a new GUID identifier must be provided.
  - `[IsEnabled <Boolean?>]`: When creating or updating an app role, this must be set to true (which is the default). To delete a role, this must first be set to false.  At that point, in a subsequent call, this role may be removed.
  - `[Origin <String>]`: Specifies if the app role is defined on the application object or on the servicePrincipal entity. Must not be included in any POST or PATCH requests. Read-only.
  - `[Value <String>]`: Specifies the value to include in the roles claim in ID tokens and access tokens authenticating an assigned user or service principal. Must not exceed 120 characters in length. Allowed characters are : ! # $ % & ' ( ) * + , - . / : ;  =  ? @ [ ] ^ + _  {  } ~, as well as characters in the ranges 0-9, A-Z and a-z. Any other character, including the space character, are not allowed. May not begin with ..

BODYPARAMETER <IMicrosoftGraphServicePrincipal1>: servicePrincipal
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
  - `[Id <String>]`: 
  - `[AccountEnabled <Boolean?>]`: true if the service principal account is enabled; otherwise, false. Supports $filter (eq, ne, not, in).
  - `[AddIns <IMicrosoftGraphAddIn[]>]`: Defines custom behavior that a consuming service can use to call an app in specific contexts. For example, applications that can render file streams may set the addIns property for its 'FileHandler' functionality. This will let services like Microsoft 365 call the application in the context of a document the user is working on.
    - `[Id <String>]`: 
    - `[Properties <IMicrosoftGraphKeyValue[]>]`: 
      - `[Key <String>]`: Contains the name of the field that a value is associated with. When a sign in or domain hint is included in the sign-in request, corresponding fields are included as key-value pairs. Possible keys: Login hint present, Domain hint present.
      - `[Value <String>]`: Contains the corresponding value for the specified key. The value is true if a sign in hint was included in the sign-in request; otherwise false. The value is true if a domain hint was included in the sign-in request; otherwise false.
    - `[Type <String>]`: 
  - `[AlternativeNames <String[]>]`: Used to retrieve service principals by subscription, identify resource group and full resource ids for managed identities. Supports $filter (eq, not, ge, le, startsWith).
  - `[AppDescription <String>]`: The description exposed by the associated application.
  - `[AppDisplayName <String>]`: The display name exposed by the associated application.
  - `[AppId <String>]`: The unique identifier for the associated application (its appId property). Supports $filter (eq, ne, not, in, startsWith).
  - `[AppManagementPolicies <IMicrosoftGraphAppManagementPolicy[]>]`: The appManagementPolicy applied to this service principal.
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
  - `[AppOwnerOrganizationId <String>]`: Contains the tenant id where the application is registered. This is applicable only to service principals backed by applications.Supports $filter (eq, ne, NOT, ge, le).
  - `[AppRoleAssignedTo <IMicrosoftGraphAppRoleAssignment1[]>]`: App role assignments for this app or service, granted to users, groups, and other service principals.Supports $expand.
    - `[Id <String>]`: 
    - `[AppRoleId <String>]`: The identifier (id) for the app role which is assigned to the principal. This app role must be exposed in the appRoles property on the resource application's service principal (resourceId). If the resource application has not declared any app roles, a default app role ID of 00000000-0000-0000-0000-000000000000 can be specified to signal that the principal is assigned to the resource app without any specific app roles. Required on create.
    - `[CreationTimestamp <DateTime?>]`: The time when the app role assignment was created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    - `[PrincipalDisplayName <String>]`: The display name of the user, group, or service principal that was granted the app role assignment. Read-only. Supports $filter (eq and startswith).
    - `[PrincipalId <String>]`: The unique identifier (id) for the user, group, or service principal being granted the app role. Required on create.
    - `[PrincipalType <String>]`: The type of the assigned principal. This can either be User, Group, or ServicePrincipal. Read-only.
    - `[ResourceDisplayName <String>]`: The display name of the resource app's service principal to which the assignment is made.
    - `[ResourceId <String>]`: The unique identifier (id) for the resource service principal for which the assignment is made. Required on create. Supports $filter (eq only).
  - `[AppRoleAssignmentRequired <Boolean?>]`: Specifies whether users or other service principals need to be granted an app role assignment for this service principal before users can sign in or apps can get tokens. The default value is false. Not nullable. Supports $filter (eq, ne, NOT).
  - `[AppRoleAssignments <IMicrosoftGraphAppRoleAssignment1[]>]`: App role assignment for another app or service, granted to this service principal. Supports $expand.
  - `[AppRoles <IMicrosoftGraphAppRole[]>]`: The roles exposed by the application which this service principal represents. For more information see the appRoles property definition on the application entity. Not nullable.
    - `[AllowedMemberTypes <String[]>]`: Specifies whether this app role can be assigned to users and groups (by setting to ['User']), to other application's (by setting to ['Application'], or both (by setting to ['User', 'Application']). App roles supporting assignment to other applications' service principals are also known as application permissions. The 'Application' value is only supported for app roles defined on application entities.
    - `[Description <String>]`: The description for the app role. This is displayed when the app role is being assigned and, if the app role functions as an application permission, during  consent experiences.
    - `[DisplayName <String>]`: Display name for the permission that appears in the app role assignment and consent experiences.
    - `[Id <String>]`: Unique role identifier inside the appRoles collection. When creating a new app role, a new GUID identifier must be provided.
    - `[IsEnabled <Boolean?>]`: When creating or updating an app role, this must be set to true (which is the default). To delete a role, this must first be set to false.  At that point, in a subsequent call, this role may be removed.
    - `[Origin <String>]`: Specifies if the app role is defined on the application object or on the servicePrincipal entity. Must not be included in any POST or PATCH requests. Read-only.
    - `[Value <String>]`: Specifies the value to include in the roles claim in ID tokens and access tokens authenticating an assigned user or service principal. Must not exceed 120 characters in length. Allowed characters are : ! # $ % & ' ( ) * + , - . / : ;  =  ? @ [ ] ^ + _  {  } ~, as well as characters in the ranges 0-9, A-Z and a-z. Any other character, including the space character, are not allowed. May not begin with ..
  - `[ApplicationTemplateId <String>]`: Unique identifier of the applicationTemplate that the servicePrincipal was created from. Read-only. Supports $filter (eq, ne, NOT, startsWith).
  - `[ClaimsMappingPolicies <IMicrosoftGraphClaimsMappingPolicy1[]>]`: The claimsMappingPolicies assigned to this service principal. Supports $expand.
    - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[Definition <String[]>]`: A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.
    - `[IsOrganizationDefault <Boolean?>]`: If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.
    - `[Description <String>]`: Description for this policy. Required.
    - `[DisplayName <String>]`: Display name for this policy. Required.
    - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
    - `[Id <String>]`: 
  - `[CreatedObjects <IMicrosoftGraphDirectoryObject[]>]`: Directory objects created by this service principal. Read-only. Nullable.
  - `[CustomSecurityAttributes <IMicrosoftGraphCustomSecurityAttributeValue>]`: customSecurityAttributeValue
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DelegatedPermissionClassifications <IMicrosoftGraphDelegatedPermissionClassification[]>]`: The permission classifications for delegated permissions exposed by the app that this service principal represents. Supports $expand.
    - `[Id <String>]`: 
    - `[Classification <String>]`: permissionClassificationType
    - `[PermissionId <String>]`: The unique identifier (id) for the delegated permission listed in the publishedPermissionScopes collection of the servicePrincipal. Required on create. Does not support $filter.
    - `[PermissionName <String>]`: The claim value (value) for the delegated permission listed in the publishedPermissionScopes collection of the servicePrincipal. Does not support $filter.
  - `[Description <String>]`: Free text field to provide an internal end-user facing description of the service principal. End-user portals such MyApps will display the application description in this field. The maximum allowed size is 1024 characters. Supports $filter (eq, ne, not, ge, le, startsWith) and $search.
  - `[DisabledByMicrosoftStatus <String>]`: Specifies whether Microsoft has disabled the registered application. Possible values are: null (default value), NotDisabled, and DisabledDueToViolationOfServicesAgreement (reasons may include suspicious, abusive, or malicious activity, or a violation of the Microsoft Services Agreement).  Supports $filter (eq, ne, not).
  - `[DisplayName <String>]`: The display name for the service principal. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values), $search, and $orderBy.
  - `[Endpoints <IMicrosoftGraphEndpoint[]>]`: Endpoints available for discovery. Services like Sharepoint populate this property with a tenant specific SharePoint endpoints that other applications can discover and use in their experiences.
    - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
    - `[Id <String>]`: 
    - `[Capability <String>]`: Describes the capability that is associated with this resource. (e.g. Messages, Conversations, etc.) Not nullable. Read-only.
    - `[ProviderId <String>]`: Application id of the publishing underlying service. Not nullable. Read-only.
    - `[ProviderName <String>]`: Name of the publishing underlying service. Read-only.
    - `[ProviderResourceId <String>]`: For Microsoft 365 groups, this is set to a well-known name for the resource (e.g. Yammer.FeedURL etc.). Not nullable. Read-only.
    - `[Uri <String>]`: URL of the published resource. Not nullable. Read-only.
  - `[ErrorUrl <String>]`: Deprecated. Don't use.
  - `[FederatedIdentityCredentials <IMicrosoftGraphFederatedIdentityCredential[]>]`: 
    - `[Id <String>]`: 
    - `[Audiences <String[]>]`: Lists the audiences that can appear in the external token. This field is mandatory, and defaults to 'api://AzureADTokenExchange'. It says what Microsoft identity platform should accept in the aud claim in the incoming token. This value represents Azure AD in your external identity provider and has no fixed value across identity providers - you may need to create a new application registration in your identity provider to serve as the audience of this token. Required.
    - `[Description <String>]`: The un-validated, user-provided description of the federated identity credential. Optional.
    - `[Issuer <String>]`: The URL of the external identity provider and must match the issuer claim of the external token being exchanged. The combination of the values of issuer and subject must be unique on the app. Required.
    - `[Name <String>]`: is the unique identifier for the federated identity credential, which has a character limit of 120 characters and must be URL friendly. It is immutable once created. Required. Not nullable. Supports $filter (eq).
    - `[Subject <String>]`: Required. The identifier of the external software workload within the external identity provider. Like the audience value, it has no fixed format, as each identity provider uses their own - sometimes a GUID, sometimes a colon delimited identifier, sometimes arbitrary strings. The value here must match the sub claim within the token presented to Azure AD. The combination of issuer and subject must be unique on the app. Supports $filter (eq).
  - `[HomeRealmDiscoveryPolicies <IMicrosoftGraphHomeRealmDiscoveryPolicy1[]>]`: The homeRealmDiscoveryPolicies assigned to this service principal. Supports $expand.
    - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[Definition <String[]>]`: A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.
    - `[IsOrganizationDefault <Boolean?>]`: If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.
    - `[Description <String>]`: Description for this policy. Required.
    - `[DisplayName <String>]`: Display name for this policy. Required.
    - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
    - `[Id <String>]`: 
  - `[Homepage <String>]`: Home page or landing page of the application.
  - `[Info <IMicrosoftGraphInformationalUrl>]`: informationalUrl
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[LogoUrl <String>]`: CDN URL to the application's logo, Read-only.
    - `[MarketingUrl <String>]`: Link to the application's marketing page. For example, https://www.contoso.com/app/marketing
    - `[PrivacyStatementUrl <String>]`: Link to the application's privacy statement. For example, https://www.contoso.com/app/privacy
    - `[SupportUrl <String>]`: Link to the application's support page. For example, https://www.contoso.com/app/support
    - `[TermsOfServiceUrl <String>]`: Link to the application's terms of service statement. For example, https://www.contoso.com/app/termsofservice
  - `[KeyCredentials <IMicrosoftGraphKeyCredential[]>]`: The collection of key credentials associated with the service principal. Not nullable. Supports $filter (eq, not, ge, le).
    - `[CustomKeyIdentifier <Byte[]>]`: Custom key identifier
    - `[DisplayName <String>]`: Friendly name for the key. Optional.
    - `[EndDateTime <DateTime?>]`: The date and time at which the credential expires. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[Key <Byte[]>]`: Value for the key credential. Should be a Base64 encoded value. Returned only on $select for a single object, that is, GET applications/{applicationId}?$select=keyCredentials or GET servicePrincipals/{servicePrincipalId}?$select=keyCredentials; otherwise, it is always null.
    - `[KeyId <String>]`: The unique identifier for the key.
    - `[StartDateTime <DateTime?>]`: The date and time at which the credential becomes valid.The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[Type <String>]`: The type of key credential; for example, Symmetric, AsymmetricX509Cert.
    - `[Usage <String>]`: A string that describes the purpose for which the key can be used; for example, Verify.
  - `[LicenseDetails <IMicrosoftGraphLicenseDetails[]>]`: 
    - `[Id <String>]`: 
    - `[ServicePlans <IMicrosoftGraphServicePlanInfo[]>]`: Information about the service plans assigned with the license. Read-only, Not nullable
      - `[AppliesTo <String>]`: The object the service plan can be assigned to. The possible values are:User - service plan can be assigned to individual users.Company - service plan can be assigned to the entire tenant.
      - `[ProvisioningStatus <String>]`: The provisioning status of the service plan. The possible values are:Success - Service is fully provisioned.Disabled - Service has been disabled.ErrorStatus - The service plan has not been provisioned and is in an error state.PendingInput - Service is not yet provisioned; awaiting service confirmation.PendingActivation - Service is provisioned but requires explicit activation by administrator (for example, Intune_O365 service plan)PendingProvisioning - Microsoft has added a new service to the product SKU and it has not been activated in the tenant, yet.
      - `[ServicePlanId <String>]`: The unique identifier of the service plan.
      - `[ServicePlanName <String>]`: The name of the service plan.
    - `[SkuId <String>]`: Unique identifier (GUID) for the service SKU. Equal to the skuId property on the related SubscribedSku object. Read-only
    - `[SkuPartNumber <String>]`: Unique SKU display name. Equal to the skuPartNumber on the related SubscribedSku object; for example: 'AAD_Premium'. Read-only
  - `[LoginUrl <String>]`: Specifies the URL where the service provider redirects the user to Azure AD to authenticate. Azure AD uses the URL to launch the application from Microsoft 365 or the Azure AD My Apps. When blank, Azure AD performs IdP-initiated sign-on for applications configured with SAML-based single sign-on. The user launches the application from Microsoft 365, the Azure AD My Apps, or the Azure AD SSO URL.
  - `[LogoutUrl <String>]`: Specifies the URL that will be used by Microsoft's authorization service to logout an user using OpenId Connect front-channel, back-channel or SAML logout protocols.
  - `[MemberOf <IMicrosoftGraphDirectoryObject[]>]`: Roles that this service principal is a member of. HTTP Methods: GET Read-only. Nullable. Supports $expand.
  - `[Notes <String>]`: Free text field to capture information about the service principal, typically used for operational purposes. Maximum allowed size is 1024 characters.
  - `[NotificationEmailAddresses <String[]>]`: Specifies the list of email addresses where Azure AD sends a notification when the active certificate is near the expiration date. This is only for the certificates used to sign the SAML token issued for Azure AD Gallery applications.
  - `[Oauth2PermissionGrants <IMicrosoftGraphOAuth2PermissionGrant1[]>]`: Delegated permission grants authorizing this service principal to access an API on behalf of a signed-in user. Read-only. Nullable.
    - `[Id <String>]`: 
    - `[ClientId <String>]`: The id of the client service principal for the application which is authorized to act on behalf of a signed-in user when accessing an API. Required. Supports $filter (eq only).
    - `[ConsentType <String>]`: Indicates whether authorization is granted for the client application to impersonate all users or only a specific user. AllPrincipals indicates authorization to impersonate all users. Principal indicates authorization to impersonate a specific user. Consent on behalf of all users can be granted by an administrator. Non-admin users may be authorized to consent on behalf of themselves in some cases, for some delegated permissions. Required. Supports $filter (eq only).
    - `[ExpiryTime <DateTime?>]`: Currently, the end time value is ignored, but a value is required when creating an oAuth2PermissionGrant. Required.
    - `[PrincipalId <String>]`: The id of the user on behalf of whom the client is authorized to access the resource, when consentType is Principal. If consentType is AllPrincipals this value is null. Required when consentType is Principal. Supports $filter (eq only).
    - `[ResourceId <String>]`: The id of the resource service principal to which access is authorized. This identifies the API which the client is authorized to attempt to call on behalf of a signed-in user. Supports $filter (eq only).
    - `[Scope <String>]`: A space-separated list of the claim values for delegated permissions which should be included in access tokens for the resource application (the API). For example, openid User.Read GroupMember.Read.All. Each claim value should match the value field of one of the delegated permissions defined by the API, listed in the publishedPermissionScopes property of the resource service principal.
    - `[StartTime <DateTime?>]`: Currently, the start time value is ignored, but a value is required when creating an oAuth2PermissionGrant. Required.
  - `[OwnedObjects <IMicrosoftGraphDirectoryObject[]>]`: Directory objects that are owned by this service principal. Read-only. Nullable. Supports $expand.
  - `[Owners <IMicrosoftGraphDirectoryObject[]>]`: Directory objects that are owners of this servicePrincipal. The owners are a set of non-admin users or servicePrincipals who are allowed to modify this object. Read-only. Nullable. Supports $expand.
  - `[PasswordCredentials <IMicrosoftGraphPasswordCredential[]>]`: The collection of password credentials associated with the service principal. Not nullable.
    - `[CustomKeyIdentifier <Byte[]>]`: Do not use.
    - `[DisplayName <String>]`: Friendly name for the password. Optional.
    - `[EndDateTime <DateTime?>]`: The date and time at which the password expires represented using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Optional.
    - `[Hint <String>]`: Contains the first three characters of the password. Read-only.
    - `[KeyId <String>]`: The unique identifier for the password.
    - `[SecretText <String>]`: Read-only; Contains the strong passwords generated by Azure AD that are 16-64 characters in length. The generated password value is only returned during the initial POST request to addPassword. There is no way to retrieve this password in the future.
    - `[StartDateTime <DateTime?>]`: The date and time at which the password becomes valid. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Optional.
  - `[PasswordSingleSignOnSettings <IMicrosoftGraphPasswordSingleSignOnSettings>]`: passwordSingleSignOnSettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Fields <IMicrosoftGraphPasswordSingleSignOnField[]>]`: 
      - `[CustomizedLabel <String>]`: Title/label override for customization.
      - `[DefaultLabel <String>]`: Label that would be used if no customizedLabel is provided. Read only.
      - `[FieldId <String>]`: Id used to identity the field type. This is an internal id and possible values are param_1, param_2, param_userName, param_password.
      - `[Type <String>]`: Type of the credential. The values can be text, password.
  - `[PreferredSingleSignOnMode <String>]`: Specifies the single sign-on mode configured for this application. Azure AD uses the preferred single sign-on mode to launch the application from Microsoft 365 or the Azure AD My Apps. The supported values are password, saml, notSupported, and oidc.
  - `[PreferredTokenSigningKeyEndDateTime <DateTime?>]`: Specifies the expiration date of the keyCredential used for token signing, marked by preferredTokenSigningKeyThumbprint.
  - `[PreferredTokenSigningKeyThumbprint <String>]`: Reserved for internal use only. Do not write or otherwise rely on this property. May be removed in future versions.
  - `[PublishedPermissionScopes <IMicrosoftGraphPermissionScope[]>]`: The delegated permissions exposed by the application. For more information see the oauth2PermissionScopes property on the application entity's api property. Not nullable. Note: This property is named oauth2PermissionScopes in v1.0.
    - `[AdminConsentDescription <String>]`: A description of the delegated permissions, intended to be read by an administrator granting the permission on behalf of all users. This text appears in tenant-wide admin consent experiences.
    - `[AdminConsentDisplayName <String>]`: The permission's title, intended to be read by an administrator granting the permission on behalf of all users.
    - `[Id <String>]`: Unique delegated permission identifier inside the collection of delegated permissions defined for a resource application.
    - `[IsEnabled <Boolean?>]`: When creating or updating a permission, this property must be set to true (which is the default). To delete a permission, this property must first be set to false.  At that point, in a subsequent call, the permission may be removed.
    - `[Origin <String>]`: 
    - `[Type <String>]`: The possible values are: User and Admin. Specifies whether this delegated permission should be considered safe for non-admin users to consent to on behalf of themselves, or whether an administrator consent should always be required. While Microsoft Graph defines the default consent requirement for each permission, the tenant administrator may override the behavior in their organization (by allowing, restricting, or limiting user consent to this delegated permission). For more information, see Configure how users consent to applications.
    - `[UserConsentDescription <String>]`: A description of the delegated permissions, intended to be read by a user granting the permission on their own behalf. This text appears in consent experiences where the user is consenting only on behalf of themselves.
    - `[UserConsentDisplayName <String>]`: A title for the permission, intended to be read by a user granting the permission on their own behalf. This text appears in consent experiences where the user is consenting only on behalf of themselves.
    - `[Value <String>]`: Specifies the value to include in the scp (scope) claim in access tokens. Must not exceed 120 characters in length. Allowed characters are : ! # $ % & ' ( ) * + , - . / : ;  =  ? @ [ ] ^ + _  {  } ~, as well as characters in the ranges 0-9, A-Z and a-z. Any other character, including the space character, are not allowed. May not begin with ..
  - `[PublisherName <String>]`: 
  - `[ReplyUrls <String[]>]`: The URLs that user tokens are sent to for sign in with the associated application, or the redirect URIs that OAuth 2.0 authorization codes and access tokens are sent to for the associated application. Not nullable.
  - `[SamlMetadataUrl <String>]`: The url where the service exposes SAML metadata for federation.
  - `[SamlSingleSignOnSettings <IMicrosoftGraphSamlSingleSignOnSettings>]`: samlSingleSignOnSettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[RelayState <String>]`: The relative URI the service provider would redirect to after completion of the single sign-on flow.
  - `[ServicePrincipalNames <String[]>]`: Contains the list of identifiersUris, copied over from the associated application. Additional values can be added to hybrid applications. These values can be used to identify the permissions exposed by this app within Azure AD. For example,Client apps can specify a resource URI which is based on the values of this property to acquire an access token, which is the URI returned in the 'aud' claim.The any operator is required for filter expressions on multi-valued properties. Not nullable.  Supports $filter (eq, not, ge, le, startsWith).
  - `[ServicePrincipalType <String>]`: Identifies if the service principal represents an application or a managed identity. This is set by Azure AD internally. For a service principal that represents an application this is set as Application. For a service principal that represent a managed identity this is set as ManagedIdentity. The SocialIdp type is for internal use.
  - `[SignInAudience <String>]`: Specifies the Microsoft accounts that are supported for the current application. Read-only. Supported values are:AzureADMyOrg: Users with a Microsoft work or school account in my organization’s Azure AD tenant (single-tenant).AzureADMultipleOrgs: Users with a Microsoft work or school account in any organization’s Azure AD tenant (multi-tenant).AzureADandPersonalMicrosoftAccount: Users with a personal Microsoft account, or a work or school account in any organization’s Azure AD tenant.PersonalMicrosoftAccount: Users with a personal Microsoft account only.
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
  - `[Tags <String[]>]`: Custom strings that can be used to categorize and identify the service principal. Not nullable. Supports $filter (eq, not, ge, le, startsWith).
  - `[TokenEncryptionKeyId <String>]`: Specifies the keyId of a public key from the keyCredentials collection. When configured, Azure AD issues tokens for this application encrypted using the key specified by this property. The application code that receives the encrypted token must use the matching private key to decrypt the token before it can be used for the signed-in user.
  - `[TokenIssuancePolicies <IMicrosoftGraphTokenIssuancePolicy1[]>]`: The tokenIssuancePolicies assigned to this service principal. Supports $expand.
    - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[Definition <String[]>]`: A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.
    - `[IsOrganizationDefault <Boolean?>]`: If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.
    - `[Description <String>]`: Description for this policy. Required.
    - `[DisplayName <String>]`: Display name for this policy. Required.
    - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
    - `[Id <String>]`: 
  - `[TokenLifetimePolicies <IMicrosoftGraphTokenLifetimePolicy1[]>]`: The tokenLifetimePolicies assigned to this service principal. Supports $expand.
    - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[Definition <String[]>]`: A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.
    - `[IsOrganizationDefault <Boolean?>]`: If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.
    - `[Description <String>]`: Description for this policy. Required.
    - `[DisplayName <String>]`: Display name for this policy. Required.
    - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
    - `[Id <String>]`: 
  - `[TransitiveMemberOf <IMicrosoftGraphDirectoryObject[]>]`: 

CLAIMSMAPPINGPOLICIES <IMicrosoftGraphClaimsMappingPolicy1[]>: The claimsMappingPolicies assigned to this service principal. Supports $expand.
  - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[Id <String>]`: 
    - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
  - `[Definition <String[]>]`: A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.
  - `[IsOrganizationDefault <Boolean?>]`: If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.
  - `[Description <String>]`: Description for this policy. Required.
  - `[DisplayName <String>]`: Display name for this policy. Required.
  - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
  - `[Id <String>]`: 

CREATEDOBJECTS <IMicrosoftGraphDirectoryObject[]>: Directory objects created by this service principal. Read-only. Nullable.
  - `[Id <String>]`: 
  - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.

DELEGATEDPERMISSIONCLASSIFICATIONS <IMicrosoftGraphDelegatedPermissionClassification[]>: The permission classifications for delegated permissions exposed by the app that this service principal represents. Supports $expand.
  - `[Id <String>]`: 
  - `[Classification <String>]`: permissionClassificationType
  - `[PermissionId <String>]`: The unique identifier (id) for the delegated permission listed in the publishedPermissionScopes collection of the servicePrincipal. Required on create. Does not support $filter.
  - `[PermissionName <String>]`: The claim value (value) for the delegated permission listed in the publishedPermissionScopes collection of the servicePrincipal. Does not support $filter.

ENDPOINTS <IMicrosoftGraphEndpoint[]>: Endpoints available for discovery. Services like Sharepoint populate this property with a tenant specific SharePoint endpoints that other applications can discover and use in their experiences.
  - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
  - `[Id <String>]`: 
  - `[Capability <String>]`: Describes the capability that is associated with this resource. (e.g. Messages, Conversations, etc.) Not nullable. Read-only.
  - `[ProviderId <String>]`: Application id of the publishing underlying service. Not nullable. Read-only.
  - `[ProviderName <String>]`: Name of the publishing underlying service. Read-only.
  - `[ProviderResourceId <String>]`: For Microsoft 365 groups, this is set to a well-known name for the resource (e.g. Yammer.FeedURL etc.). Not nullable. Read-only.
  - `[Uri <String>]`: URL of the published resource. Not nullable. Read-only.

FEDERATEDIDENTITYCREDENTIALS <IMicrosoftGraphFederatedIdentityCredential[]>: .
  - `[Id <String>]`: 
  - `[Audiences <String[]>]`: Lists the audiences that can appear in the external token. This field is mandatory, and defaults to 'api://AzureADTokenExchange'. It says what Microsoft identity platform should accept in the aud claim in the incoming token. This value represents Azure AD in your external identity provider and has no fixed value across identity providers - you may need to create a new application registration in your identity provider to serve as the audience of this token. Required.
  - `[Description <String>]`: The un-validated, user-provided description of the federated identity credential. Optional.
  - `[Issuer <String>]`: The URL of the external identity provider and must match the issuer claim of the external token being exchanged. The combination of the values of issuer and subject must be unique on the app. Required.
  - `[Name <String>]`: is the unique identifier for the federated identity credential, which has a character limit of 120 characters and must be URL friendly. It is immutable once created. Required. Not nullable. Supports $filter (eq).
  - `[Subject <String>]`: Required. The identifier of the external software workload within the external identity provider. Like the audience value, it has no fixed format, as each identity provider uses their own - sometimes a GUID, sometimes a colon delimited identifier, sometimes arbitrary strings. The value here must match the sub claim within the token presented to Azure AD. The combination of issuer and subject must be unique on the app. Supports $filter (eq).

HOMEREALMDISCOVERYPOLICIES <IMicrosoftGraphHomeRealmDiscoveryPolicy1[]>: The homeRealmDiscoveryPolicies assigned to this service principal. Supports $expand.
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

KEYCREDENTIALS <IMicrosoftGraphKeyCredential[]>: The collection of key credentials associated with the service principal. Not nullable. Supports $filter (eq, not, ge, le).
  - `[CustomKeyIdentifier <Byte[]>]`: Custom key identifier
  - `[DisplayName <String>]`: Friendly name for the key. Optional.
  - `[EndDateTime <DateTime?>]`: The date and time at which the credential expires. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[Key <Byte[]>]`: Value for the key credential. Should be a Base64 encoded value. Returned only on $select for a single object, that is, GET applications/{applicationId}?$select=keyCredentials or GET servicePrincipals/{servicePrincipalId}?$select=keyCredentials; otherwise, it is always null.
  - `[KeyId <String>]`: The unique identifier for the key.
  - `[StartDateTime <DateTime?>]`: The date and time at which the credential becomes valid.The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[Type <String>]`: The type of key credential; for example, Symmetric, AsymmetricX509Cert.
  - `[Usage <String>]`: A string that describes the purpose for which the key can be used; for example, Verify.

LICENSEDETAILS <IMicrosoftGraphLicenseDetails[]>: .
  - `[Id <String>]`: 
  - `[ServicePlans <IMicrosoftGraphServicePlanInfo[]>]`: Information about the service plans assigned with the license. Read-only, Not nullable
    - `[AppliesTo <String>]`: The object the service plan can be assigned to. The possible values are:User - service plan can be assigned to individual users.Company - service plan can be assigned to the entire tenant.
    - `[ProvisioningStatus <String>]`: The provisioning status of the service plan. The possible values are:Success - Service is fully provisioned.Disabled - Service has been disabled.ErrorStatus - The service plan has not been provisioned and is in an error state.PendingInput - Service is not yet provisioned; awaiting service confirmation.PendingActivation - Service is provisioned but requires explicit activation by administrator (for example, Intune_O365 service plan)PendingProvisioning - Microsoft has added a new service to the product SKU and it has not been activated in the tenant, yet.
    - `[ServicePlanId <String>]`: The unique identifier of the service plan.
    - `[ServicePlanName <String>]`: The name of the service plan.
  - `[SkuId <String>]`: Unique identifier (GUID) for the service SKU. Equal to the skuId property on the related SubscribedSku object. Read-only
  - `[SkuPartNumber <String>]`: Unique SKU display name. Equal to the skuPartNumber on the related SubscribedSku object; for example: 'AAD_Premium'. Read-only

MEMBEROF <IMicrosoftGraphDirectoryObject[]>: Roles that this service principal is a member of. HTTP Methods: GET Read-only. Nullable. Supports $expand.
  - `[Id <String>]`: 
  - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.

OAUTH2PERMISSIONGRANTS <IMicrosoftGraphOAuth2PermissionGrant1[]>: Delegated permission grants authorizing this service principal to access an API on behalf of a signed-in user. Read-only. Nullable.
  - `[Id <String>]`: 
  - `[ClientId <String>]`: The id of the client service principal for the application which is authorized to act on behalf of a signed-in user when accessing an API. Required. Supports $filter (eq only).
  - `[ConsentType <String>]`: Indicates whether authorization is granted for the client application to impersonate all users or only a specific user. AllPrincipals indicates authorization to impersonate all users. Principal indicates authorization to impersonate a specific user. Consent on behalf of all users can be granted by an administrator. Non-admin users may be authorized to consent on behalf of themselves in some cases, for some delegated permissions. Required. Supports $filter (eq only).
  - `[ExpiryTime <DateTime?>]`: Currently, the end time value is ignored, but a value is required when creating an oAuth2PermissionGrant. Required.
  - `[PrincipalId <String>]`: The id of the user on behalf of whom the client is authorized to access the resource, when consentType is Principal. If consentType is AllPrincipals this value is null. Required when consentType is Principal. Supports $filter (eq only).
  - `[ResourceId <String>]`: The id of the resource service principal to which access is authorized. This identifies the API which the client is authorized to attempt to call on behalf of a signed-in user. Supports $filter (eq only).
  - `[Scope <String>]`: A space-separated list of the claim values for delegated permissions which should be included in access tokens for the resource application (the API). For example, openid User.Read GroupMember.Read.All. Each claim value should match the value field of one of the delegated permissions defined by the API, listed in the publishedPermissionScopes property of the resource service principal.
  - `[StartTime <DateTime?>]`: Currently, the start time value is ignored, but a value is required when creating an oAuth2PermissionGrant. Required.

OWNEDOBJECTS <IMicrosoftGraphDirectoryObject[]>: Directory objects that are owned by this service principal. Read-only. Nullable. Supports $expand.
  - `[Id <String>]`: 
  - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.

OWNERS <IMicrosoftGraphDirectoryObject[]>: Directory objects that are owners of this servicePrincipal. The owners are a set of non-admin users or servicePrincipals who are allowed to modify this object. Read-only. Nullable. Supports $expand.
  - `[Id <String>]`: 
  - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.

PASSWORDCREDENTIALS <IMicrosoftGraphPasswordCredential[]>: The collection of password credentials associated with the service principal. Not nullable.
  - `[CustomKeyIdentifier <Byte[]>]`: Do not use.
  - `[DisplayName <String>]`: Friendly name for the password. Optional.
  - `[EndDateTime <DateTime?>]`: The date and time at which the password expires represented using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Optional.
  - `[Hint <String>]`: Contains the first three characters of the password. Read-only.
  - `[KeyId <String>]`: The unique identifier for the password.
  - `[SecretText <String>]`: Read-only; Contains the strong passwords generated by Azure AD that are 16-64 characters in length. The generated password value is only returned during the initial POST request to addPassword. There is no way to retrieve this password in the future.
  - `[StartDateTime <DateTime?>]`: The date and time at which the password becomes valid. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Optional.

PASSWORDSINGLESIGNONSETTINGS <IMicrosoftGraphPasswordSingleSignOnSettings>: passwordSingleSignOnSettings
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Fields <IMicrosoftGraphPasswordSingleSignOnField[]>]`: 
    - `[CustomizedLabel <String>]`: Title/label override for customization.
    - `[DefaultLabel <String>]`: Label that would be used if no customizedLabel is provided. Read only.
    - `[FieldId <String>]`: Id used to identity the field type. This is an internal id and possible values are param_1, param_2, param_userName, param_password.
    - `[Type <String>]`: Type of the credential. The values can be text, password.

PUBLISHEDPERMISSIONSCOPES <IMicrosoftGraphPermissionScope[]>: The delegated permissions exposed by the application. For more information see the oauth2PermissionScopes property on the application entity's api property. Not nullable. Note: This property is named oauth2PermissionScopes in v1.0.
  - `[AdminConsentDescription <String>]`: A description of the delegated permissions, intended to be read by an administrator granting the permission on behalf of all users. This text appears in tenant-wide admin consent experiences.
  - `[AdminConsentDisplayName <String>]`: The permission's title, intended to be read by an administrator granting the permission on behalf of all users.
  - `[Id <String>]`: Unique delegated permission identifier inside the collection of delegated permissions defined for a resource application.
  - `[IsEnabled <Boolean?>]`: When creating or updating a permission, this property must be set to true (which is the default). To delete a permission, this property must first be set to false.  At that point, in a subsequent call, the permission may be removed.
  - `[Origin <String>]`: 
  - `[Type <String>]`: The possible values are: User and Admin. Specifies whether this delegated permission should be considered safe for non-admin users to consent to on behalf of themselves, or whether an administrator consent should always be required. While Microsoft Graph defines the default consent requirement for each permission, the tenant administrator may override the behavior in their organization (by allowing, restricting, or limiting user consent to this delegated permission). For more information, see Configure how users consent to applications.
  - `[UserConsentDescription <String>]`: A description of the delegated permissions, intended to be read by a user granting the permission on their own behalf. This text appears in consent experiences where the user is consenting only on behalf of themselves.
  - `[UserConsentDisplayName <String>]`: A title for the permission, intended to be read by a user granting the permission on their own behalf. This text appears in consent experiences where the user is consenting only on behalf of themselves.
  - `[Value <String>]`: Specifies the value to include in the scp (scope) claim in access tokens. Must not exceed 120 characters in length. Allowed characters are : ! # $ % & ' ( ) * + , - . / : ;  =  ? @ [ ] ^ + _  {  } ~, as well as characters in the ranges 0-9, A-Z and a-z. Any other character, including the space character, are not allowed. May not begin with ..

SAMLSINGLESIGNONSETTINGS <IMicrosoftGraphSamlSingleSignOnSettings>: samlSingleSignOnSettings
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[RelayState <String>]`: The relative URI the service provider would redirect to after completion of the single sign-on flow.

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

TOKENISSUANCEPOLICIES <IMicrosoftGraphTokenIssuancePolicy1[]>: The tokenIssuancePolicies assigned to this service principal. Supports $expand.
  - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[Id <String>]`: 
    - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
  - `[Definition <String[]>]`: A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.
  - `[IsOrganizationDefault <Boolean?>]`: If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.
  - `[Description <String>]`: Description for this policy. Required.
  - `[DisplayName <String>]`: Display name for this policy. Required.
  - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
  - `[Id <String>]`: 

TOKENLIFETIMEPOLICIES <IMicrosoftGraphTokenLifetimePolicy1[]>: The tokenLifetimePolicies assigned to this service principal. Supports $expand.
  - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[Id <String>]`: 
    - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
  - `[Definition <String[]>]`: A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.
  - `[IsOrganizationDefault <Boolean?>]`: If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.
  - `[Description <String>]`: Description for this policy. Required.
  - `[DisplayName <String>]`: Display name for this policy. Required.
  - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
  - `[Id <String>]`: 

TRANSITIVEMEMBEROF <IMicrosoftGraphDirectoryObject[]>: .
  - `[Id <String>]`: 
  - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.

## RELATED LINKS

