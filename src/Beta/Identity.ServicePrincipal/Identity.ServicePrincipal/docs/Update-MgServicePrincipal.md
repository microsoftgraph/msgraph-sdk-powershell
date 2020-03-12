---
external help file:
Module Name: Microsoft.Graph.Identity.ServicePrincipal
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.serviceprincipal/update-mgserviceprincipal
schema: 2.0.0
---

# Update-MgServicePrincipal

## SYNOPSIS
Update entity in servicePrincipals

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgServicePrincipal -ServicePrincipalId <String> [-AccountEnabled] [-AddIns <IMicrosoftGraphAddIn[]>]
 [-AlternativeNames <String[]>] [-AppDisplayName <String>] [-AppId <String>] [-ApplicationTemplateId <String>]
 [-AppOwnerOrganizationId <String>] [-AppRoleAssignedTo <IMicrosoftGraphAppRoleAssignment[]>]
 [-AppRoleAssignmentRequired] [-AppRoleAssignments <IMicrosoftGraphAppRoleAssignment[]>]
 [-AppRoles <IMicrosoftGraphAppRole[]>] [-ClaimsMappingPolicies <IMicrosoftGraphClaimsMappingPolicy[]>]
 [-CreatedObjects <IMicrosoftGraphDirectoryObject[]>] [-DeletedDateTime <DateTime>] [-DisplayName <String>]
 [-Endpoints <IMicrosoftGraphEndpoint[]>] [-ErrorUrl <String>] [-Homepage <String>]
 [-HomeRealmDiscoveryPolicies <IMicrosoftGraphHomeRealmDiscoveryPolicy[]>] [-Id <String>]
 [-InfoLogoUrl <String>] [-InfoMarketingUrl <String>] [-InfoPrivacyStatementUrl <String>]
 [-InfoSupportUrl <String>] [-InfoTermsOfServiceUrl <String>]
 [-KeyCredentials <IMicrosoftGraphKeyCredential[]>] [-LicenseDetails <IMicrosoftGraphLicenseDetails[]>]
 [-LoginUrl <String>] [-LogoutUrl <String>] [-MemberOf <IMicrosoftGraphDirectoryObject[]>]
 [-NotificationEmailAddresses <String[]>] [-Oauth2PermissionGrants <IMicrosoftGraphOAuth2PermissionGrant[]>]
 [-OwnedObjects <IMicrosoftGraphDirectoryObject[]>] [-Owners <IMicrosoftGraphDirectoryObject[]>]
 [-PasswordCredentials <IMicrosoftGraphPasswordCredential[]>] [-PreferredSingleSignOnMode <String>]
 [-PreferredTokenSigningKeyEndDateTime <DateTime>] [-PreferredTokenSigningKeyThumbprint <String>]
 [-PublishedPermissionScopes <IMicrosoftGraphPermissionScope[]>] [-PublisherName <String>]
 [-ReplyUrls <String[]>] [-SamlMetadataUrl <String>] [-SamlSingleSignOnSettingRelayState <String>]
 [-ServicePrincipalNames <String[]>] [-ServicePrincipalType <String>] [-SignInAudience <String>]
 [-SynchronizationId <String>] [-SynchronizationJobs <IMicrosoftGraphSynchronizationJob[]>]
 [-SynchronizationSecrets <IMicrosoftGraphSynchronizationSecretKeyStringValuePair[]>]
 [-SynchronizationTemplates <IMicrosoftGraphSynchronizationTemplate[]>] [-Tags <String[]>]
 [-TokenEncryptionKeyId <String>] [-TokenIssuancePolicies <IMicrosoftGraphTokenIssuancePolicy[]>]
 [-TokenLifetimePolicies <IMicrosoftGraphTokenLifetimePolicy[]>]
 [-TransitiveMemberOf <IMicrosoftGraphDirectoryObject[]>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgServicePrincipal -ServicePrincipalId <String> -BodyParameter <IMicrosoftGraphServicePrincipal>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgServicePrincipal -InputObject <IIdentityServicePrincipalIdentity>
 -BodyParameter <IMicrosoftGraphServicePrincipal> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgServicePrincipal -InputObject <IIdentityServicePrincipalIdentity> [-AccountEnabled]
 [-AddIns <IMicrosoftGraphAddIn[]>] [-AlternativeNames <String[]>] [-AppDisplayName <String>]
 [-AppId <String>] [-ApplicationTemplateId <String>] [-AppOwnerOrganizationId <String>]
 [-AppRoleAssignedTo <IMicrosoftGraphAppRoleAssignment[]>] [-AppRoleAssignmentRequired]
 [-AppRoleAssignments <IMicrosoftGraphAppRoleAssignment[]>] [-AppRoles <IMicrosoftGraphAppRole[]>]
 [-ClaimsMappingPolicies <IMicrosoftGraphClaimsMappingPolicy[]>]
 [-CreatedObjects <IMicrosoftGraphDirectoryObject[]>] [-DeletedDateTime <DateTime>] [-DisplayName <String>]
 [-Endpoints <IMicrosoftGraphEndpoint[]>] [-ErrorUrl <String>] [-Homepage <String>]
 [-HomeRealmDiscoveryPolicies <IMicrosoftGraphHomeRealmDiscoveryPolicy[]>] [-Id <String>]
 [-InfoLogoUrl <String>] [-InfoMarketingUrl <String>] [-InfoPrivacyStatementUrl <String>]
 [-InfoSupportUrl <String>] [-InfoTermsOfServiceUrl <String>]
 [-KeyCredentials <IMicrosoftGraphKeyCredential[]>] [-LicenseDetails <IMicrosoftGraphLicenseDetails[]>]
 [-LoginUrl <String>] [-LogoutUrl <String>] [-MemberOf <IMicrosoftGraphDirectoryObject[]>]
 [-NotificationEmailAddresses <String[]>] [-Oauth2PermissionGrants <IMicrosoftGraphOAuth2PermissionGrant[]>]
 [-OwnedObjects <IMicrosoftGraphDirectoryObject[]>] [-Owners <IMicrosoftGraphDirectoryObject[]>]
 [-PasswordCredentials <IMicrosoftGraphPasswordCredential[]>] [-PreferredSingleSignOnMode <String>]
 [-PreferredTokenSigningKeyEndDateTime <DateTime>] [-PreferredTokenSigningKeyThumbprint <String>]
 [-PublishedPermissionScopes <IMicrosoftGraphPermissionScope[]>] [-PublisherName <String>]
 [-ReplyUrls <String[]>] [-SamlMetadataUrl <String>] [-SamlSingleSignOnSettingRelayState <String>]
 [-ServicePrincipalNames <String[]>] [-ServicePrincipalType <String>] [-SignInAudience <String>]
 [-SynchronizationId <String>] [-SynchronizationJobs <IMicrosoftGraphSynchronizationJob[]>]
 [-SynchronizationSecrets <IMicrosoftGraphSynchronizationSecretKeyStringValuePair[]>]
 [-SynchronizationTemplates <IMicrosoftGraphSynchronizationTemplate[]>] [-Tags <String[]>]
 [-TokenEncryptionKeyId <String>] [-TokenIssuancePolicies <IMicrosoftGraphTokenIssuancePolicy[]>]
 [-TokenLifetimePolicies <IMicrosoftGraphTokenLifetimePolicy[]>]
 [-TransitiveMemberOf <IMicrosoftGraphDirectoryObject[]>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update entity in servicePrincipals

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

### -AccountEnabled
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

### -AddIns
.
To construct, see NOTES section for ADDINS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAddIn[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -AlternativeNames
.

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

### -AppDisplayName
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
Dynamic: False
```

### -AppId
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
Dynamic: False
```

### -ApplicationTemplateId
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
Dynamic: False
```

### -AppOwnerOrganizationId
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
Dynamic: False
```

### -AppRoleAssignedTo
.
To construct, see NOTES section for APPROLEASSIGNEDTO properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAppRoleAssignment[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -AppRoleAssignmentRequired
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

### -AppRoleAssignments
.
To construct, see NOTES section for APPROLEASSIGNMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAppRoleAssignment[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -AppRoles
.
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphServicePrincipal
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

### -CreatedObjects
.
To construct, see NOTES section for CREATEDOBJECTS properties and create a hash table.

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
Dynamic: False
```

### -Endpoints
.
To construct, see NOTES section for ENDPOINTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEndpoint[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ErrorUrl
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
Dynamic: False
```

### -Homepage
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
Type: Microsoft.Graph.PowerShell.Models.IIdentityServicePrincipalIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -KeyCredentials
.
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

### -LicenseDetails
.
To construct, see NOTES section for LICENSEDETAILS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphLicenseDetails[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -LoginUrl
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
Dynamic: False
```

### -LogoutUrl
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
Dynamic: False
```

### -MemberOf
.
To construct, see NOTES section for MEMBEROF properties and create a hash table.

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

### -NotificationEmailAddresses
.

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

### -Oauth2PermissionGrants
.
To construct, see NOTES section for OAUTH2PERMISSIONGRANTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOAuth2PermissionGrant[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -OwnedObjects
.
To construct, see NOTES section for OWNEDOBJECTS properties and create a hash table.

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

### -Owners
.
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
.
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

### -PreferredSingleSignOnMode
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
Dynamic: False
```

### -PreferredTokenSigningKeyEndDateTime
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

### -PreferredTokenSigningKeyThumbprint
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
Dynamic: False
```

### -PublishedPermissionScopes
.
To construct, see NOTES section for PUBLISHEDPERMISSIONSCOPES properties and create a hash table.

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

### -PublisherName
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
Dynamic: False
```

### -ReplyUrls
.

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

### -SamlMetadataUrl
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
Dynamic: False
```

### -SamlSingleSignOnSettingRelayState
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
Dynamic: False
```

### -ServicePrincipalId
key: servicePrincipal-id of servicePrincipal

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

### -ServicePrincipalNames
.

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

### -ServicePrincipalType
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
Dynamic: False
```

### -SignInAudience
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
.

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

### -TransitiveMemberOf
.
To construct, see NOTES section for TRANSITIVEMEMBEROF properties and create a hash table.

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

### Microsoft.Graph.PowerShell.Models.IIdentityServicePrincipalIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphServicePrincipal

## OUTPUTS

### System.Boolean

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### ADDINS <IMicrosoftGraphAddIn[]>: .
  - `[Id <String>]`: 
  - `[Properties <IMicrosoftGraphKeyValue[]>]`: 
    - `[Key <String>]`: Key for the key-value pair.
    - `[Value <String>]`: Value for the key-value pair.
  - `[Type <String>]`: 

#### APPROLEASSIGNEDTO <IMicrosoftGraphAppRoleAssignment[]>: .
  - `[Id <String>]`: Read-only.
  - `[AppRoleId <String>]`: 
  - `[CreationTimestamp <DateTime?>]`: 
  - `[PrincipalDisplayName <String>]`: 
  - `[PrincipalId <String>]`: 
  - `[PrincipalType <String>]`: 
  - `[ResourceDisplayName <String>]`: 
  - `[ResourceId <String>]`: 

#### APPROLEASSIGNMENTS <IMicrosoftGraphAppRoleAssignment[]>: .
  - `[Id <String>]`: Read-only.
  - `[AppRoleId <String>]`: 
  - `[CreationTimestamp <DateTime?>]`: 
  - `[PrincipalDisplayName <String>]`: 
  - `[PrincipalId <String>]`: 
  - `[PrincipalType <String>]`: 
  - `[ResourceDisplayName <String>]`: 
  - `[ResourceId <String>]`: 

#### APPROLES <IMicrosoftGraphAppRole[]>: .
  - `[AllowedMemberTypes <String[]>]`: Specifies whether this app role definition can be assigned to users and groups by setting to 'User', or to other applications (that are accessing this application in daemon service scenarios) by setting to 'Application', or to both.
  - `[Description <String>]`: Permission help text that appears in the admin app assignment and consent experiences.
  - `[DisplayName <String>]`: Display name for the permission that appears in the admin consent and app assignment experiences.
  - `[Id <String>]`: Unique role identifier inside the appRoles collection. When creating a new app role, a new Guid identifier must be provided.
  - `[IsEnabled <Boolean?>]`: When creating or updating an app role, this must be set to true (which is the default). To delete a role, this must first be set to false.  At that point, in a subsequent call, this role may be removed.
  - `[Origin <String>]`: Read-only. Specifies if the app role is defined on the Application object . Must not be included in any POST or PATCH requests.
  - `[Value <String>]`: Specifies the value which will be included in the roles claim in authentication and access tokens. Must not exceed 120 characters in length. Allowed characters are : ! # $ % & ' ( ) * + , - . / : ;  =  ? @ [ ] ^ + _  {  } ~, as well as characters in the ranges 0-9, A-Z and a-z. Any other character, including the space character, are not allowed.

#### BODYPARAMETER <IMicrosoftGraphServicePrincipal>: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
  - `[DeletedDateTime <DateTime?>]`: 
  - `[Id <String>]`: Read-only.
  - `[AccountEnabled <Boolean?>]`: 
  - `[AddIns <IMicrosoftGraphAddIn[]>]`: 
    - `[Id <String>]`: 
    - `[Properties <IMicrosoftGraphKeyValue[]>]`: 
      - `[Key <String>]`: Key for the key-value pair.
      - `[Value <String>]`: Value for the key-value pair.
    - `[Type <String>]`: 
  - `[AlternativeNames <String[]>]`: 
  - `[AppDisplayName <String>]`: 
  - `[AppId <String>]`: 
  - `[AppOwnerOrganizationId <String>]`: 
  - `[AppRoleAssignedTo <IMicrosoftGraphAppRoleAssignment[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AppRoleId <String>]`: 
    - `[CreationTimestamp <DateTime?>]`: 
    - `[PrincipalDisplayName <String>]`: 
    - `[PrincipalId <String>]`: 
    - `[PrincipalType <String>]`: 
    - `[ResourceDisplayName <String>]`: 
    - `[ResourceId <String>]`: 
  - `[AppRoleAssignmentRequired <Boolean?>]`: 
  - `[AppRoleAssignments <IMicrosoftGraphAppRoleAssignment[]>]`: 
  - `[AppRoles <IMicrosoftGraphAppRole[]>]`: 
    - `[AllowedMemberTypes <String[]>]`: Specifies whether this app role definition can be assigned to users and groups by setting to 'User', or to other applications (that are accessing this application in daemon service scenarios) by setting to 'Application', or to both.
    - `[Description <String>]`: Permission help text that appears in the admin app assignment and consent experiences.
    - `[DisplayName <String>]`: Display name for the permission that appears in the admin consent and app assignment experiences.
    - `[Id <String>]`: Unique role identifier inside the appRoles collection. When creating a new app role, a new Guid identifier must be provided.
    - `[IsEnabled <Boolean?>]`: When creating or updating an app role, this must be set to true (which is the default). To delete a role, this must first be set to false.  At that point, in a subsequent call, this role may be removed.
    - `[Origin <String>]`: Read-only. Specifies if the app role is defined on the Application object . Must not be included in any POST or PATCH requests.
    - `[Value <String>]`: Specifies the value which will be included in the roles claim in authentication and access tokens. Must not exceed 120 characters in length. Allowed characters are : ! # $ % & ' ( ) * + , - . / : ;  =  ? @ [ ] ^ + _  {  } ~, as well as characters in the ranges 0-9, A-Z and a-z. Any other character, including the space character, are not allowed.
  - `[ApplicationTemplateId <String>]`: 
  - `[ClaimsMappingPolicies <IMicrosoftGraphClaimsMappingPolicy[]>]`: 
    - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[DeletedDateTime <DateTime?>]`: 
    - `[Definition <String[]>]`: 
    - `[IsOrganizationDefault <Boolean?>]`: 
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[Id <String>]`: Read-only.
  - `[CreatedObjects <IMicrosoftGraphDirectoryObject[]>]`: 
  - `[DisplayName <String>]`: 
  - `[Endpoints <IMicrosoftGraphEndpoint[]>]`: 
    - `[DeletedDateTime <DateTime?>]`: 
    - `[Id <String>]`: Read-only.
    - `[Capability <String>]`: 
    - `[ProviderId <String>]`: 
    - `[ProviderName <String>]`: 
    - `[ProviderResourceId <String>]`: 
    - `[Uri <String>]`: 
  - `[ErrorUrl <String>]`: 
  - `[HomeRealmDiscoveryPolicies <IMicrosoftGraphHomeRealmDiscoveryPolicy[]>]`: 
    - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[Definition <String[]>]`: 
    - `[IsOrganizationDefault <Boolean?>]`: 
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[Id <String>]`: Read-only.
  - `[Homepage <String>]`: 
  - `[InfoLogoUrl <String>]`: CDN URL to the application's logo, Read-only.
  - `[InfoMarketingUrl <String>]`: Link to the application's marketing page. For example, https://www.contoso.com/app/marketing
  - `[InfoPrivacyStatementUrl <String>]`: Link to the application's privacy statement. For example, https://www.contoso.com/app/privacy
  - `[InfoSupportUrl <String>]`: Link to the application's support page. For example, https://www.contoso.com/app/support
  - `[InfoTermsOfServiceUrl <String>]`: Link to the application's terms of service statement. For example, https://www.contoso.com/app/termsofservice
  - `[KeyCredentials <IMicrosoftGraphKeyCredential[]>]`: 
    - `[CustomKeyIdentifier <Byte[]>]`: Custom key identifier
    - `[DisplayName <String>]`: Friendly name for the key. Optional.
    - `[EndDateTime <DateTime?>]`: The date and time at which the credential expires.The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
    - `[Key <Byte[]>]`: Value for the key credential. Should be a base 64 encoded value.
    - `[KeyId <String>]`: The unique identifier (GUID) for the key.
    - `[StartDateTime <DateTime?>]`: The date and time at which the credential becomes valid.The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
    - `[Type <String>]`: The type of key credential; for example, 'Symmetric'.
    - `[Usage <String>]`: A string that describes the purpose for which the key can be used; for example, 'Verify'.
  - `[LicenseDetails <IMicrosoftGraphLicenseDetails[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[ServicePlans <IMicrosoftGraphServicePlanInfo[]>]`: Information about the service plans assigned with the license. Read-only, Not nullable
      - `[AppliesTo <String>]`: The object the service plan can be assigned to. Possible values:'User' - service plan can be assigned to individual users.'Company' - service plan can be assigned to the entire tenant.
      - `[ProvisioningStatus <String>]`: The provisioning status of the service plan. Possible values:'Success' - Service is fully provisioned.'Disabled' - Service has been disabled.'PendingInput' - Service is not yet provisioned; awaiting service confirmation.'PendingActivation' - Service is provisioned but requires explicit activation by administrator (for example, Intune_O365 service plan)'PendingProvisioning' - Microsoft has added a new service to the product SKU and it has not been activated in the tenant, yet.
      - `[ServicePlanId <String>]`: The unique identifier of the service plan.
      - `[ServicePlanName <String>]`: The name of the service plan.
    - `[SkuId <String>]`: Unique identifier (GUID) for the service SKU. Equal to the skuId property on the related SubscribedSku object. Read-only
    - `[SkuPartNumber <String>]`: Unique SKU display name. Equal to the skuPartNumber on the related SubscribedSku object; for example: 'AAD_Premium'. Read-only
  - `[LoginUrl <String>]`: 
  - `[LogoutUrl <String>]`: 
  - `[MemberOf <IMicrosoftGraphDirectoryObject[]>]`: 
  - `[NotificationEmailAddresses <String[]>]`: 
  - `[Oauth2PermissionGrants <IMicrosoftGraphOAuth2PermissionGrant[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[ClientId <String>]`: 
    - `[ConsentType <String>]`: 
    - `[ExpiryTime <DateTime?>]`: 
    - `[PrincipalId <String>]`: 
    - `[ResourceId <String>]`: 
    - `[Scope <String>]`: 
    - `[StartTime <DateTime?>]`: 
  - `[OwnedObjects <IMicrosoftGraphDirectoryObject[]>]`: 
  - `[Owners <IMicrosoftGraphDirectoryObject[]>]`: 
  - `[PasswordCredentials <IMicrosoftGraphPasswordCredential[]>]`: 
    - `[CustomKeyIdentifier <Byte[]>]`: Do not use.
    - `[DisplayName <String>]`: Friendly name for the password. Optional.
    - `[EndDateTime <DateTime?>]`: The date and time at which the password expires represented using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Optional.
    - `[Hint <String>]`: Contains the first three characters of the password. Read-only.
    - `[KeyId <String>]`: The unique identifier for the password.
    - `[SecretText <String>]`: Read-only; Contains the strong passwords generated by Azure AD that are 16-64 characters in length. The generated password value is only returned during the initial POST request to addPassword. There is no way to retrieve this password in the future.
    - `[StartDateTime <DateTime?>]`: The date and time at which the password becomes valid. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Optional.
  - `[PreferredSingleSignOnMode <String>]`: 
  - `[PreferredTokenSigningKeyEndDateTime <DateTime?>]`: 
  - `[PreferredTokenSigningKeyThumbprint <String>]`: 
  - `[PublishedPermissionScopes <IMicrosoftGraphPermissionScope[]>]`: 
    - `[AdminConsentDescription <String>]`: Permission help text that appears in the admin consent and app assignment experiences.
    - `[AdminConsentDisplayName <String>]`: Display name for the permission that appears in the admin consent and app assignment experiences.
    - `[Id <String>]`: Unique scope permission identifier inside the oauth2Permissions collection.
    - `[IsEnabled <Boolean?>]`: When creating or updating a permission, this property must be set to true (which is the default). To delete a permission, this property must first be set to false. At that point, in a subsequent call, the permission may be removed.
    - `[Origin <String>]`: For internal use.
    - `[Type <String>]`: Specifies whether this scope permission can be consented to by an end user, or whether it is a tenant-wide permission that must be consented to by a company administrator. Possible values are User or Admin.
    - `[UserConsentDescription <String>]`: Permission help text that appears in the end-user consent experience.
    - `[UserConsentDisplayName <String>]`: Display name for the permission that appears in the end-user consent experience.
    - `[Value <String>]`: The value of the scope claim that the resource application should expect in the OAuth 2.0 access token.
  - `[PublisherName <String>]`: 
  - `[ReplyUrls <String[]>]`: 
  - `[SamlMetadataUrl <String>]`: 
  - `[SamlSingleSignOnSettingRelayState <String>]`: 
  - `[ServicePrincipalNames <String[]>]`: 
  - `[ServicePrincipalType <String>]`: 
  - `[SignInAudience <String>]`: 
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
  - `[Tags <String[]>]`: 
  - `[TokenEncryptionKeyId <String>]`: 
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
  - `[TransitiveMemberOf <IMicrosoftGraphDirectoryObject[]>]`: 

#### CLAIMSMAPPINGPOLICIES <IMicrosoftGraphClaimsMappingPolicy[]>: .
  - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[DeletedDateTime <DateTime?>]`: 
  - `[Definition <String[]>]`: 
  - `[IsOrganizationDefault <Boolean?>]`: 
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: 
  - `[Id <String>]`: Read-only.

#### CREATEDOBJECTS <IMicrosoftGraphDirectoryObject[]>: .
  - `[Id <String>]`: Read-only.
  - `[DeletedDateTime <DateTime?>]`: 

#### ENDPOINTS <IMicrosoftGraphEndpoint[]>: .
  - `[DeletedDateTime <DateTime?>]`: 
  - `[Id <String>]`: Read-only.
  - `[Capability <String>]`: 
  - `[ProviderId <String>]`: 
  - `[ProviderName <String>]`: 
  - `[ProviderResourceId <String>]`: 
  - `[Uri <String>]`: 

#### HOMEREALMDISCOVERYPOLICIES <IMicrosoftGraphHomeRealmDiscoveryPolicy[]>: .
  - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[DeletedDateTime <DateTime?>]`: 
  - `[Definition <String[]>]`: 
  - `[IsOrganizationDefault <Boolean?>]`: 
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: 
  - `[Id <String>]`: Read-only.

#### INPUTOBJECT <IIdentityServicePrincipalIdentity>: Identity Parameter
  - `[AppRoleAssignmentId <String>]`: key: appRoleAssignment-id of appRoleAssignment
  - `[ClaimsMappingPolicyId <String>]`: key: claimsMappingPolicy-id of claimsMappingPolicy
  - `[DirectoryDefinitionId <String>]`: key: directoryDefinition-id of directoryDefinition
  - `[DirectoryObjectId <String>]`: key: directoryObject-id of directoryObject
  - `[EndpointId <String>]`: key: endpoint-id of endpoint
  - `[HomeRealmDiscoveryPolicyId <String>]`: key: homeRealmDiscoveryPolicy-id of homeRealmDiscoveryPolicy
  - `[LicenseDetailsId <String>]`: key: licenseDetails-id of licenseDetails
  - `[OAuth2PermissionGrantId <String>]`: key: oAuth2PermissionGrant-id of oAuth2PermissionGrant
  - `[ServicePrincipalId <String>]`: key: servicePrincipal-id of servicePrincipal
  - `[SynchronizationJobId <String>]`: key: synchronizationJob-id of synchronizationJob
  - `[SynchronizationTemplateId <String>]`: key: synchronizationTemplate-id of synchronizationTemplate
  - `[TokenIssuancePolicyId <String>]`: key: tokenIssuancePolicy-id of tokenIssuancePolicy
  - `[TokenLifetimePolicyId <String>]`: key: tokenLifetimePolicy-id of tokenLifetimePolicy

#### KEYCREDENTIALS <IMicrosoftGraphKeyCredential[]>: .
  - `[CustomKeyIdentifier <Byte[]>]`: Custom key identifier
  - `[DisplayName <String>]`: Friendly name for the key. Optional.
  - `[EndDateTime <DateTime?>]`: The date and time at which the credential expires.The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
  - `[Key <Byte[]>]`: Value for the key credential. Should be a base 64 encoded value.
  - `[KeyId <String>]`: The unique identifier (GUID) for the key.
  - `[StartDateTime <DateTime?>]`: The date and time at which the credential becomes valid.The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
  - `[Type <String>]`: The type of key credential; for example, 'Symmetric'.
  - `[Usage <String>]`: A string that describes the purpose for which the key can be used; for example, 'Verify'.

#### LICENSEDETAILS <IMicrosoftGraphLicenseDetails[]>: .
  - `[Id <String>]`: Read-only.
  - `[ServicePlans <IMicrosoftGraphServicePlanInfo[]>]`: Information about the service plans assigned with the license. Read-only, Not nullable
    - `[AppliesTo <String>]`: The object the service plan can be assigned to. Possible values:'User' - service plan can be assigned to individual users.'Company' - service plan can be assigned to the entire tenant.
    - `[ProvisioningStatus <String>]`: The provisioning status of the service plan. Possible values:'Success' - Service is fully provisioned.'Disabled' - Service has been disabled.'PendingInput' - Service is not yet provisioned; awaiting service confirmation.'PendingActivation' - Service is provisioned but requires explicit activation by administrator (for example, Intune_O365 service plan)'PendingProvisioning' - Microsoft has added a new service to the product SKU and it has not been activated in the tenant, yet.
    - `[ServicePlanId <String>]`: The unique identifier of the service plan.
    - `[ServicePlanName <String>]`: The name of the service plan.
  - `[SkuId <String>]`: Unique identifier (GUID) for the service SKU. Equal to the skuId property on the related SubscribedSku object. Read-only
  - `[SkuPartNumber <String>]`: Unique SKU display name. Equal to the skuPartNumber on the related SubscribedSku object; for example: 'AAD_Premium'. Read-only

#### MEMBEROF <IMicrosoftGraphDirectoryObject[]>: .
  - `[Id <String>]`: Read-only.
  - `[DeletedDateTime <DateTime?>]`: 

#### OAUTH2PERMISSIONGRANTS <IMicrosoftGraphOAuth2PermissionGrant[]>: .
  - `[Id <String>]`: Read-only.
  - `[ClientId <String>]`: 
  - `[ConsentType <String>]`: 
  - `[ExpiryTime <DateTime?>]`: 
  - `[PrincipalId <String>]`: 
  - `[ResourceId <String>]`: 
  - `[Scope <String>]`: 
  - `[StartTime <DateTime?>]`: 

#### OWNEDOBJECTS <IMicrosoftGraphDirectoryObject[]>: .
  - `[Id <String>]`: Read-only.
  - `[DeletedDateTime <DateTime?>]`: 

#### OWNERS <IMicrosoftGraphDirectoryObject[]>: .
  - `[Id <String>]`: Read-only.
  - `[DeletedDateTime <DateTime?>]`: 

#### PASSWORDCREDENTIALS <IMicrosoftGraphPasswordCredential[]>: .
  - `[CustomKeyIdentifier <Byte[]>]`: Do not use.
  - `[DisplayName <String>]`: Friendly name for the password. Optional.
  - `[EndDateTime <DateTime?>]`: The date and time at which the password expires represented using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Optional.
  - `[Hint <String>]`: Contains the first three characters of the password. Read-only.
  - `[KeyId <String>]`: The unique identifier for the password.
  - `[SecretText <String>]`: Read-only; Contains the strong passwords generated by Azure AD that are 16-64 characters in length. The generated password value is only returned during the initial POST request to addPassword. There is no way to retrieve this password in the future.
  - `[StartDateTime <DateTime?>]`: The date and time at which the password becomes valid. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Optional.

#### PUBLISHEDPERMISSIONSCOPES <IMicrosoftGraphPermissionScope[]>: .
  - `[AdminConsentDescription <String>]`: Permission help text that appears in the admin consent and app assignment experiences.
  - `[AdminConsentDisplayName <String>]`: Display name for the permission that appears in the admin consent and app assignment experiences.
  - `[Id <String>]`: Unique scope permission identifier inside the oauth2Permissions collection.
  - `[IsEnabled <Boolean?>]`: When creating or updating a permission, this property must be set to true (which is the default). To delete a permission, this property must first be set to false. At that point, in a subsequent call, the permission may be removed.
  - `[Origin <String>]`: For internal use.
  - `[Type <String>]`: Specifies whether this scope permission can be consented to by an end user, or whether it is a tenant-wide permission that must be consented to by a company administrator. Possible values are User or Admin.
  - `[UserConsentDescription <String>]`: Permission help text that appears in the end-user consent experience.
  - `[UserConsentDisplayName <String>]`: Display name for the permission that appears in the end-user consent experience.
  - `[Value <String>]`: The value of the scope claim that the resource application should expect in the OAuth 2.0 access token.

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

#### TRANSITIVEMEMBEROF <IMicrosoftGraphDirectoryObject[]>: .
  - `[Id <String>]`: Read-only.
  - `[DeletedDateTime <DateTime?>]`: 

## RELATED LINKS

