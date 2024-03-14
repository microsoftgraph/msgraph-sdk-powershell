---
external help file:
Module Name: Microsoft.Graph.Beta.Identity.DirectoryManagement
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.identity.directorymanagement/update-mgbetadirectory
schema: 2.0.0
---

# Update-MgBetaDirectory

## SYNOPSIS
Update directory

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaDirectory [-AdditionalProperties <Hashtable>]
 [-AdministrativeUnits <IMicrosoftGraphAdministrativeUnit[]>] [-AttributeSets <IMicrosoftGraphAttributeSet[]>]
 [-CertificateAuthorities <IMicrosoftGraphCertificateAuthorityPath>]
 [-CustomSecurityAttributeDefinitions <IMicrosoftGraphCustomSecurityAttributeDefinition[]>]
 [-DeletedItems <IMicrosoftGraphDirectoryObject[]>]
 [-DeviceLocalCredentials <IMicrosoftGraphDeviceLocalCredentialInfo[]>]
 [-ExternalUserProfiles <IMicrosoftGraphExternalUserProfile[]>]
 [-FeatureRolloutPolicies <IMicrosoftGraphFeatureRolloutPolicy[]>]
 [-FederationConfigurations <IMicrosoftGraphIdentityProviderBase[]>] [-Id <String>]
 [-ImpactedResources <IMicrosoftGraphImpactedResource[]>]
 [-InboundSharedUserProfiles <IMicrosoftGraphInboundSharedUserProfile[]>]
 [-OnPremisesSynchronization <IMicrosoftGraphOnPremisesDirectorySynchronization[]>]
 [-OutboundSharedUserProfiles <IMicrosoftGraphOutboundSharedUserProfile[]>]
 [-PendingExternalUserProfiles <IMicrosoftGraphPendingExternalUserProfile[]>]
 [-Recommendations <IMicrosoftGraphRecommendation[]>] [-ResponseHeadersVariable <String>]
 [-SharedEmailDomains <IMicrosoftGraphSharedEmailDomain[]>]
 [-Subscriptions <IMicrosoftGraphCompanySubscription[]>] [-Headers <IDictionary>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgBetaDirectory -BodyParameter <IMicrosoftGraphDirectory> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update directory

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
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AdministrativeUnits
Conceptual container for user and group directory objects.
To construct, see NOTES section for ADMINISTRATIVEUNITS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAdministrativeUnit[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AttributeSets
Group of related custom security attribute definitions.
To construct, see NOTES section for ATTRIBUTESETS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAttributeSet[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
directory
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDirectory
Parameter Sets: Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CertificateAuthorities
certificateAuthorityPath
To construct, see NOTES section for CERTIFICATEAUTHORITIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCertificateAuthorityPath
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CustomSecurityAttributeDefinitions
Schema of a custom security attributes (key-value pairs).
To construct, see NOTES section for CUSTOMSECURITYATTRIBUTEDEFINITIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCustomSecurityAttributeDefinition[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeletedItems
Recently deleted items.
Read-only.
Nullable.
To construct, see NOTES section for DELETEDITEMS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDirectoryObject[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceLocalCredentials
The credentials of the device's local administrator account backed up to Microsoft Entra ID.
To construct, see NOTES section for DEVICELOCALCREDENTIALS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDeviceLocalCredentialInfo[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExternalUserProfiles
Collection of external user profiles that represent collaborators in the directory.
To construct, see NOTES section for EXTERNALUSERPROFILES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphExternalUserProfile[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FeatureRolloutPolicies
.
To construct, see NOTES section for FEATUREROLLOUTPOLICIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphFeatureRolloutPolicy[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FederationConfigurations
Configure domain federation with organizations whose identity provider (IdP) supports either the SAML or WS-Fed protocol.
To construct, see NOTES section for FEDERATIONCONFIGURATIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphIdentityProviderBase[]
Parameter Sets: UpdateExpanded
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
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ImpactedResources
.
To construct, see NOTES section for IMPACTEDRESOURCES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphImpactedResource[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InboundSharedUserProfiles
A collection of external users whose profile data is shared with the Microsoft Entra tenant.
Nullable.
To construct, see NOTES section for INBOUNDSHAREDUSERPROFILES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphInboundSharedUserProfile[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OnPremisesSynchronization
A container for on-premises directory synchronization functionalities that are available for the organization.
To construct, see NOTES section for ONPREMISESSYNCHRONIZATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphOnPremisesDirectorySynchronization[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OutboundSharedUserProfiles
.
To construct, see NOTES section for OUTBOUNDSHAREDUSERPROFILES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphOutboundSharedUserProfile[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PendingExternalUserProfiles
Collection of pending external user profiles representing collaborators in the directory that are unredeemed.
To construct, see NOTES section for PENDINGEXTERNALUSERPROFILES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPendingExternalUserProfile[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Recommendations
List of recommended improvements to improve tenant posture.
To construct, see NOTES section for RECOMMENDATIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphRecommendation[]
Parameter Sets: UpdateExpanded
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

### -SharedEmailDomains
.
To construct, see NOTES section for SHAREDEMAILDOMAINS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSharedEmailDomain[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Subscriptions
List of commercial subscriptions that an organization has.
To construct, see NOTES section for SUBSCRIPTIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCompanySubscription[]
Parameter Sets: UpdateExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDirectory

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDirectory

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`ADMINISTRATIVEUNITS <IMicrosoftGraphAdministrativeUnit[]>`: Conceptual container for user and group directory objects.
  - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Description <String>]`: An optional description for the administrative unit. Supports $filter (eq, ne, in, startsWith), $search.
  - `[DisplayName <String>]`: Display name for the administrative unit. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values), $search, and $orderby.
  - `[Extensions <IMicrosoftGraphExtension[]>]`: The collection of open extensions defined for this administrative unit. Nullable.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[IsMemberManagementRestricted <Boolean?>]`: true if members of this administrative unit should be treated as sensitive, which requires specific permissions to manage. Default value is false. Use this property to define administrative units whose roles don't inherit from tenant-level administrators, and management of individual member objects is limited to administrators scoped to a restricted management administrative unit. Immutable, so can't be changed later.  For more information about working with restricted management administrative units, see Restricted management administrative units in Microsoft Entra ID.
  - `[Members <IMicrosoftGraphDirectoryObject[]>]`: Users and groups that are members of this administrative unit. Supports $expand.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
  - `[MembershipRule <String>]`: Dynamic membership rule for the administrative unit. For more about the rules that you can use for dynamic administrative units and dynamic groups, see Using attributes to create advanced rules.
  - `[MembershipRuleProcessingState <String>]`: Used to control whether the dynamic membership rule is actively processed. Set to On when you want the dynamic membership rule to be active and Paused if you want to stop updating membership dynamically. If not set, the default behavior is Paused.
  - `[MembershipType <String>]`: Membership type for the administrative unit. Can be dynamic or assigned. If not set, the default behavior is assigned.
  - `[ScopedRoleMembers <IMicrosoftGraphScopedRoleMembership[]>]`: Scoped-role members of this administrative unit.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[AdministrativeUnitId <String>]`: Unique identifier for the administrative unit that the directory role is scoped to
    - `[RoleId <String>]`: Unique identifier for the directory role that the member is in.
    - `[RoleMemberInfo <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. The display name might not always be available or up to date. For example, if a user changes their display name the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity. When the unique identifier is unavailable, the displayName property is provided for the identity, but the id property isn't included in the response.
  - `[Visibility <String>]`: Controls whether the administrative unit and its members are hidden or public. Can be set to HiddenMembership or Public. If not set, the default behavior is Public. When set to HiddenMembership, only members of the administrative unit can list other members of the administrative unit.

`ATTRIBUTESETS <IMicrosoftGraphAttributeSet[]>`: Group of related custom security attribute definitions.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Description <String>]`: Description of the attribute set. Can be up to 128 characters long and include Unicode characters. Can be changed later.
  - `[MaxAttributesPerSet <Int32?>]`: Maximum number of custom security attributes that can be defined in this attribute set. Default value is null. If not specified, the administrator can add up to the maximum of 500 active attributes per tenant. Can be changed later.

`BODYPARAMETER <IMicrosoftGraphDirectory>`: directory
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AdministrativeUnits <IMicrosoftGraphAdministrativeUnit[]>]`: Conceptual container for user and group directory objects.
    - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Description <String>]`: An optional description for the administrative unit. Supports $filter (eq, ne, in, startsWith), $search.
    - `[DisplayName <String>]`: Display name for the administrative unit. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values), $search, and $orderby.
    - `[Extensions <IMicrosoftGraphExtension[]>]`: The collection of open extensions defined for this administrative unit. Nullable.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[IsMemberManagementRestricted <Boolean?>]`: true if members of this administrative unit should be treated as sensitive, which requires specific permissions to manage. Default value is false. Use this property to define administrative units whose roles don't inherit from tenant-level administrators, and management of individual member objects is limited to administrators scoped to a restricted management administrative unit. Immutable, so can't be changed later.  For more information about working with restricted management administrative units, see Restricted management administrative units in Microsoft Entra ID.
    - `[Members <IMicrosoftGraphDirectoryObject[]>]`: Users and groups that are members of this administrative unit. Supports $expand.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
    - `[MembershipRule <String>]`: Dynamic membership rule for the administrative unit. For more about the rules that you can use for dynamic administrative units and dynamic groups, see Using attributes to create advanced rules.
    - `[MembershipRuleProcessingState <String>]`: Used to control whether the dynamic membership rule is actively processed. Set to On when you want the dynamic membership rule to be active and Paused if you want to stop updating membership dynamically. If not set, the default behavior is Paused.
    - `[MembershipType <String>]`: Membership type for the administrative unit. Can be dynamic or assigned. If not set, the default behavior is assigned.
    - `[ScopedRoleMembers <IMicrosoftGraphScopedRoleMembership[]>]`: Scoped-role members of this administrative unit.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[AdministrativeUnitId <String>]`: Unique identifier for the administrative unit that the directory role is scoped to
      - `[RoleId <String>]`: Unique identifier for the directory role that the member is in.
      - `[RoleMemberInfo <IMicrosoftGraphIdentity>]`: identity
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: The display name of the identity. The display name might not always be available or up to date. For example, if a user changes their display name the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
        - `[Id <String>]`: Unique identifier for the identity. When the unique identifier is unavailable, the displayName property is provided for the identity, but the id property isn't included in the response.
    - `[Visibility <String>]`: Controls whether the administrative unit and its members are hidden or public. Can be set to HiddenMembership or Public. If not set, the default behavior is Public. When set to HiddenMembership, only members of the administrative unit can list other members of the administrative unit.
  - `[AttributeSets <IMicrosoftGraphAttributeSet[]>]`: Group of related custom security attribute definitions.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Description <String>]`: Description of the attribute set. Can be up to 128 characters long and include Unicode characters. Can be changed later.
    - `[MaxAttributesPerSet <Int32?>]`: Maximum number of custom security attributes that can be defined in this attribute set. Default value is null. If not specified, the administrator can add up to the maximum of 500 active attributes per tenant. Can be changed later.
  - `[CertificateAuthorities <IMicrosoftGraphCertificateAuthorityPath>]`: certificateAuthorityPath
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[CertificateBasedApplicationConfigurations <IMicrosoftGraphCertificateBasedApplicationConfiguration[]>]`: Defines the trusted certificate authorities for certificates that can be added to apps and service principals in the tenant.
      - `[TrustedCertificateAuthorities <IMicrosoftGraphCertificateAuthorityAsEntity[]>]`: Collection of trusted certificate authorities.
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
        - `[Certificate <Byte[]>]`: The trusted certificate.
        - `[IsRootAuthority <Boolean?>]`: Indicates if the certificate is a root authority. In a certificateBasedApplicationConfiguration object, at least one object in the trustedCertificateAuthorities collection must be a root authority.
        - `[Issuer <String>]`: The issuer of the trusted certificate.
        - `[IssuerSubjectKeyIdentifier <String>]`: The subject key identifier of the trusted certificate.
      - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Description <String>]`: The description of the trusted certificate authorities.
      - `[DisplayName <String>]`: The display name of the trusted certificate authorities.
  - `[CustomSecurityAttributeDefinitions <IMicrosoftGraphCustomSecurityAttributeDefinition[]>]`: Schema of a custom security attributes (key-value pairs).
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[AllowedValues <IMicrosoftGraphAllowedValue[]>]`: Values that are predefined for this custom security attribute. This navigation property is not returned by default and must be specified in an $expand query. For example, /directory/customSecurityAttributeDefinitions?$expand=allowedValues.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[IsActive <Boolean?>]`: Indicates whether the predefined value is active or deactivated. If set to false, this predefined value can't be assigned to any more supported directory objects.
    - `[AttributeSet <String>]`: Name of the attribute set. Case insensitive.
    - `[Description <String>]`: Description of the custom security attribute. Can be up to 128 characters long and include Unicode characters. Can be changed later.
    - `[IsCollection <Boolean?>]`: Indicates whether multiple values can be assigned to the custom security attribute. Cannot be changed later. If type is set to Boolean, isCollection cannot be set to true.
    - `[IsSearchable <Boolean?>]`: Indicates whether custom security attribute values are indexed for searching on objects that are assigned attribute values. Cannot be changed later.
    - `[Name <String>]`: Name of the custom security attribute. Must be unique within an attribute set. Can be up to 32 characters long and include Unicode characters. Cannot contain spaces or special characters. Cannot be changed later. Case insensitive.
    - `[Status <String>]`: Specifies whether the custom security attribute is active or deactivated. Acceptable values are: Available and Deprecated. Can be changed later.
    - `[Type <String>]`: Data type for the custom security attribute values. Supported types are: Boolean, Integer, and String. Cannot be changed later.
    - `[UsePreDefinedValuesOnly <Boolean?>]`: Indicates whether only predefined values can be assigned to the custom security attribute. If set to false, free-form values are allowed. Can later be changed from true to false, but cannot be changed from false to true. If type is set to Boolean, usePreDefinedValuesOnly cannot be set to true.
  - `[DeletedItems <IMicrosoftGraphDirectoryObject[]>]`: Recently deleted items. Read-only. Nullable.
  - `[DeviceLocalCredentials <IMicrosoftGraphDeviceLocalCredentialInfo[]>]`: The credentials of the device's local administrator account backed up to Microsoft Entra ID.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Credentials <IMicrosoftGraphDeviceLocalCredential[]>]`: The credentials of the device's local administrator account backed up to Azure Active Directory.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[AccountName <String>]`: The name of the local admin account for which LAPS is enabled.
      - `[AccountSid <String>]`: The SID of the local admin account for which LAPS is enabled.
      - `[BackupDateTime <DateTime?>]`: When the local adminstrator account credential for the device object was backed up to Microsoft Entra ID.
      - `[PasswordBase64 <String>]`: The password for the local administrator account that is backed up to Microsoft Entra ID and returned as a base 64 encoded value.
    - `[DeviceName <String>]`: Display name of the device that the local credentials are associated with.
    - `[LastBackupDateTime <DateTime?>]`: When the local administrator account credential was backed up to Microsoft Entra ID.
    - `[RefreshDateTime <DateTime?>]`: When the local administrator account credential will be refreshed and backed up to Microsoft Entra ID.
  - `[ExternalUserProfiles <IMicrosoftGraphExternalUserProfile[]>]`: Collection of external user profiles that represent collaborators in the directory.
    - `[Address <IMicrosoftGraphPhysicalOfficeAddress>]`: physicalOfficeAddress
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[City <String>]`: The city.
      - `[CountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
      - `[OfficeLocation <String>]`: Office location such as building and office number for an organizational contact.
      - `[PostalCode <String>]`: The postal code.
      - `[State <String>]`: The state.
      - `[Street <String>]`: The street.
    - `[CompanyName <String>]`: The company name of the external user profile. Supports $filter (eq, startswith).
    - `[CreatedBy <String>]`: The object ID of the user who created the external user profile. Read-only. Not nullable.
    - `[CreatedDateTime <DateTime?>]`: Date and time when this external user was created. Not nullable. Read-only.
    - `[Department <String>]`: The department of the external user profile.
    - `[DisplayName <String>]`: The display name of the external user profile.
    - `[IsDiscoverable <Boolean?>]`: Represents whether the external user profile is discoverable in the directory. When true, this external profile shows up in Teams search.
    - `[IsEnabled <Boolean?>]`: Represents whether the external user profile is enabled in the directory. This property is peer to the accountEnabled property on the user object.
    - `[JobTitle <String>]`: The job title of the external user profile.
    - `[PhoneNumber <String>]`: The phone number of the external user profile. Must be in E164 format.
    - `[SupervisorId <String>]`: The object ID of the supervisor of the external user profile. Supports $filter (eq, startswith).
    - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[FeatureRolloutPolicies <IMicrosoftGraphFeatureRolloutPolicy[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: Nullable. Specifies a list of directoryObjects that feature is enabled for.
    - `[Description <String>]`: A description for this feature rollout policy.
    - `[DisplayName <String>]`: The display name for this  feature rollout policy.
    - `[Feature <String>]`: stagedFeatureName
    - `[IsAppliedToOrganization <Boolean?>]`: Indicates whether this feature rollout policy should be applied to the entire organization.
    - `[IsEnabled <Boolean?>]`: Indicates whether the feature rollout is enabled.
  - `[FederationConfigurations <IMicrosoftGraphIdentityProviderBase[]>]`: Configure domain federation with organizations whose identity provider (IdP) supports either the SAML or WS-Fed protocol.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[DisplayName <String>]`: The display name of the identity provider.
  - `[ImpactedResources <IMicrosoftGraphImpactedResource[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[AddedDateTime <DateTime?>]`: The date and time when the impactedResource object was initially associated with the recommendation.
    - `[AdditionalDetails <IMicrosoftGraphKeyValue[]>]`: Additional information unique to the impactedResource to help contextualize the recommendation.
      - `[Key <String>]`: Contains the name of the field that a value is associated with.
      - `[Value <String>]`: Contains the corresponding value for the specified key.
    - `[ApiUrl <String>]`: The URL link to the corresponding Microsoft Entra resource.
    - `[DisplayName <String>]`: Friendly name of the Microsoft Entra resource.
    - `[LastModifiedBy <String>]`: Name of the user or service that last updated the status.
    - `[LastModifiedDateTime <String>]`: The date and time when the status was last updated.
    - `[Owner <String>]`: The user responsible for maintaining the resource.
    - `[PortalUrl <String>]`: The URL link to the corresponding Microsoft Entra admin center page of the resource.
    - `[PostponeUntilDateTime <DateTime?>]`: The future date and time when the status of a postponed impactedResource will be active again.
    - `[Rank <Int32?>]`: Indicates the importance of the resource. A resource with a rank equal to 1 is of the highest importance.
    - `[RecommendationId <String>]`: The unique identifier of the recommendation that the resource is associated with.
    - `[ResourceType <String>]`: Indicates the type of Microsoft Entra resource. Examples include user, application.
    - `[Status <String>]`: recommendationStatus
    - `[SubjectId <String>]`: The related unique identifier, depending on the resourceType. For example, this property is set to the applicationId if the resourceType is an application.
  - `[InboundSharedUserProfiles <IMicrosoftGraphInboundSharedUserProfile[]>]`: A collection of external users whose profile data is shared with the Microsoft Entra tenant. Nullable.
    - `[DisplayName <String>]`: The name displayed in the address book for the user at the time when the sharing record was created. Read-only.
    - `[HomeTenantId <String>]`: The home tenant id of the external user. Read-only.
    - `[UserId <String>]`: The object id of the external user. Read-only.
    - `[UserPrincipalName <String>]`: The user principal name (UPN) of the external user. Read-only.
  - `[OnPremisesSynchronization <IMicrosoftGraphOnPremisesDirectorySynchronization[]>]`: A container for on-premises directory synchronization functionalities that are available for the organization.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Configuration <IMicrosoftGraphOnPremisesDirectorySynchronizationConfiguration>]`: onPremisesDirectorySynchronizationConfiguration
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AccidentalDeletionPrevention <IMicrosoftGraphOnPremisesAccidentalDeletionPrevention>]`: onPremisesAccidentalDeletionPrevention
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[AlertThreshold <Int32?>]`: Threshold value which triggers accidental deletion prevention. The threshold is either an absolute number of objects or a percentage number of objects.
        - `[SynchronizationPreventionType <String>]`: onPremisesDirectorySynchronizationDeletionPreventionType
      - `[AnchorAttribute <String>]`: The anchor attribute allows customers to customize the property used to create source anchors for synchronization enabled objects.
      - `[ApplicationId <String>]`: The identifier of the on-premises directory synchronization client application that is configured for the tenant.
      - `[CurrentExportData <IMicrosoftGraphOnPremisesCurrentExportData>]`: onPremisesCurrentExportData
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[ClientMachineName <String>]`: The name of the onPremises client machine that ran the last export.
        - `[PendingObjectsAddition <Int32?>]`: The count of pending adds from on-premises directory.
        - `[PendingObjectsDeletion <Int32?>]`: The count of pending deletes from on-premises directory.
        - `[PendingObjectsUpdate <Int32?>]`: The count of pending updates from on-premises directory.
        - `[ServiceAccount <String>]`: The name of the dirsync service account that is configured to connect to the directory.
        - `[SuccessfulLinksProvisioningCount <Int64?>]`: The count of updated links during the current directory sync export run.
        - `[SuccessfulObjectsProvisioningCount <Int32?>]`: The count of objects that were successfully provisioned during the current directory sync export run.
        - `[TotalConnectorSpaceObjects <Int32?>]`: The total number of objects in the AAD Connector Space.
      - `[CustomerRequestedSynchronizationInterval <TimeSpan?>]`: Interval of time that the customer requested the sync client waits between sync cycles.
      - `[SynchronizationClientVersion <String>]`: Indicates the version of the on-premises directory synchronization application.
      - `[SynchronizationInterval <TimeSpan?>]`: Interval of time the sync client should honor between sync cycles
      - `[WritebackConfiguration <IMicrosoftGraphOnPremisesWritebackConfiguration>]`: onPremisesWritebackConfiguration
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[UnifiedGroupContainer <String>]`: The distinguished name of the on-premises container that the customer is using to store unified groups which are created in the cloud.
        - `[UserContainer <String>]`: The distinguished name of the on-premises container that the customer is using to store users which are created in the cloud.
    - `[Features <IMicrosoftGraphOnPremisesDirectorySynchronizationFeature>]`: onPremisesDirectorySynchronizationFeature
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[BlockCloudObjectTakeoverThroughHardMatchEnabled <Boolean?>]`: Used to block cloud object takeover via source anchor hard match if enabled.
      - `[BlockSoftMatchEnabled <Boolean?>]`: Use to block soft match for all objects if enabled for the  tenant. Customers are encouraged to enable this feature and keep it enabled until soft matching is required again for their tenancy. This flag should be enabled again after any soft matching has been completed and is no longer needed.
      - `[BypassDirSyncOverridesEnabled <Boolean?>]`: When true, persists the values of Mobile and OtherMobile in on-premises AD during sync cycles instead of values of MobilePhone or AlternateMobilePhones in Microsoft Entra ID.
      - `[CloudPasswordPolicyForPasswordSyncedUsersEnabled <Boolean?>]`: Used to indicate that cloud password policy applies to users whose passwords are synchronized from on-premises.
      - `[ConcurrentCredentialUpdateEnabled <Boolean?>]`: Used to enable concurrent user credentials update in OrgId.
      - `[ConcurrentOrgIdProvisioningEnabled <Boolean?>]`: Used to enable concurrent user creation in OrgId.
      - `[DeviceWritebackEnabled <Boolean?>]`: Used to indicate that device write-back is enabled.
      - `[DirectoryExtensionsEnabled <Boolean?>]`: Used to indicate that directory extensions are being synced from on-premises AD to Microsoft Entra ID.
      - `[FopeConflictResolutionEnabled <Boolean?>]`: Used to indicate that for a Microsoft Forefront Online Protection for Exchange (FOPE) migrated tenant, the conflicting proxy address should be migrated over.
      - `[GroupWriteBackEnabled <Boolean?>]`: Used to enable object-level group writeback feature for additional group types.
      - `[PasswordSyncEnabled <Boolean?>]`: Used to indicate on-premise password synchronization is enabled.
      - `[PasswordWritebackEnabled <Boolean?>]`: Used to indicate that writeback of password resets from Microsoft Entra ID to on-premises AD is enabled.
      - `[QuarantineUponProxyAddressesConflictEnabled <Boolean?>]`: Used to indicate that we should quarantine objects with conflicting proxy address.
      - `[QuarantineUponUpnConflictEnabled <Boolean?>]`: Used to indicate that we should quarantine objects conflicting with duplicate userPrincipalName.
      - `[SoftMatchOnUpnEnabled <Boolean?>]`: Used to indicate that we should soft match objects based on userPrincipalName.
      - `[SynchronizeUpnForManagedUsersEnabled <Boolean?>]`: Used to indicate that we should synchronize userPrincipalName objects for managed users with licenses.
      - `[UnifiedGroupWritebackEnabled <Boolean?>]`: Used to indicate that Microsoft 365 Group write-back is enabled.
      - `[UserForcePasswordChangeOnLogonEnabled <Boolean?>]`: Used to indicate that feature to force password change for a user on logon is enabled while synchronizing on-premise credentials.
      - `[UserWritebackEnabled <Boolean?>]`: Used to indicate that user writeback is enabled.
  - `[OutboundSharedUserProfiles <IMicrosoftGraphOutboundSharedUserProfile[]>]`: 
    - `[Tenants <IMicrosoftGraphTenantReference[]>]`: The collection of external Microsoft Entra tenants that the user has shared profile data with. Read-only.
      - `[TenantId <String>]`: The identifier of the Microsoft Entra tenant. Read-only. Key.
    - `[UserId <String>]`: The object id of the external user. Read-only.
  - `[PendingExternalUserProfiles <IMicrosoftGraphPendingExternalUserProfile[]>]`: Collection of pending external user profiles representing collaborators in the directory that are unredeemed.
    - `[Address <IMicrosoftGraphPhysicalOfficeAddress>]`: physicalOfficeAddress
    - `[CompanyName <String>]`: The company name of the external user profile. Supports $filter (eq, startswith).
    - `[CreatedBy <String>]`: The object ID of the user who created the external user profile. Read-only. Not nullable.
    - `[CreatedDateTime <DateTime?>]`: Date and time when this external user was created. Not nullable. Read-only.
    - `[Department <String>]`: The department of the external user profile.
    - `[DisplayName <String>]`: The display name of the external user profile.
    - `[IsDiscoverable <Boolean?>]`: Represents whether the external user profile is discoverable in the directory. When true, this external profile shows up in Teams search.
    - `[IsEnabled <Boolean?>]`: Represents whether the external user profile is enabled in the directory. This property is peer to the accountEnabled property on the user object.
    - `[JobTitle <String>]`: The job title of the external user profile.
    - `[PhoneNumber <String>]`: The phone number of the external user profile. Must be in E164 format.
    - `[SupervisorId <String>]`: The object ID of the supervisor of the external user profile. Supports $filter (eq, startswith).
    - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Recommendations <IMicrosoftGraphRecommendation[]>]`: List of recommended improvements to improve tenant posture.
    - `[ActionSteps <IMicrosoftGraphActionStep[]>]`: List of actions to take to complete a recommendation.
      - `[ActionUrl <IMicrosoftGraphActionUrl>]`: actionUrl
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: Brief title for the page that the links directs to.
        - `[Url <String>]`: The URL to the documentation or Microsoft Entra admin center page.
      - `[StepNumber <Int64?>]`: Indicates the position for this action in the order of the collection of actions to be taken.
      - `[Text <String>]`: Friendly description of the action to take.
    - `[Benefits <String>]`: An explanation of why completing the recommendation will benefit you. Corresponds to the Value section of a recommendation shown in the Microsoft Entra admin center.
    - `[Category <String>]`: recommendationCategory
    - `[CreatedDateTime <DateTime?>]`: The date and time when the recommendation was detected as applicable to your directory.
    - `[CurrentScore <Double?>]`: The number of points the tenant has attained. Only applies to recommendations with category set to identitySecureScore.
    - `[DisplayName <String>]`: The title of the recommendation.
    - `[FeatureAreas <String[]>]`: The directory feature that the recommendation is related to.
    - `[ImpactStartDateTime <DateTime?>]`: The future date and time when a recommendation should be completed.
    - `[ImpactType <String>]`: Indicates the scope of impact of a recommendation. Tenant level indicates that the recommendation impacts the whole tenant. Other possible values include users, applications.
    - `[ImpactedResources <IMicrosoftGraphImpactedResource[]>]`: The list of directory objects associated with the recommendation.
    - `[Insights <String>]`: Describes why a recommendation uniquely applies to your directory. Corresponds to the Description section of a recommendation shown in the Microsoft Entra admin center.
    - `[LastCheckedDateTime <DateTime?>]`: The most recent date and time a recommendation was deemed applicable to your directory.
    - `[LastModifiedBy <String>]`: Name of the user who last updated the status of the recommendation.
    - `[LastModifiedDateTime <DateTime?>]`: The date and time the status of a recommendation was last updated.
    - `[MaxScore <Double?>]`: The maximum number of points attainable. Only applies to recommendations with category set to identitySecureScore.
    - `[PostponeUntilDateTime <DateTime?>]`: The future date and time when the status of a postponed recommendation will be active again.
    - `[Priority <String>]`: recommendationPriority
    - `[RecommendationType <String>]`: recommendationType
    - `[ReleaseType <String>]`: The current release type of the recommendation. The possible values are: preview, generallyAvailable, unknownFutureValue.
    - `[RemediationImpact <String>]`: Description of the impact on users of the remediation. Only applies to recommendations with category set to identitySecureScore.
    - `[Status <String>]`: recommendationStatus
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[SharedEmailDomains <IMicrosoftGraphSharedEmailDomain[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[ProvisioningStatus <String>]`: 
  - `[Subscriptions <IMicrosoftGraphCompanySubscription[]>]`: List of commercial subscriptions that an organization has.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[CommerceSubscriptionId <String>]`: The ID of this subscription in the commerce system. Alternate key.
    - `[CreatedDateTime <DateTime?>]`: The date and time when this subscription was created. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[IsTrial <Boolean?>]`: Whether the subscription is a free trial or purchased.
    - `[NextLifecycleDateTime <DateTime?>]`: The date and time when the subscription will move to the next state (as defined by the status property) if not renewed by the tenant. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[OcpSubscriptionId <String>]`: 
    - `[OwnerId <String>]`: The object ID of the account admin.
    - `[OwnerTenantId <String>]`: The unique identifier for the Microsoft partner tenant that created the subscription on a customer tenant.
    - `[OwnerType <String>]`: Indicates the entity that ownerId belongs to, for example, 'User'.
    - `[ServiceStatus <IMicrosoftGraphServicePlanInfo[]>]`: The provisioning status of each service that's included in this subscription.
      - `[AppliesTo <String>]`: The object the service plan can be assigned to. The possible values are: User - service plan can be assigned to individual users.Company - service plan can be assigned to the entire tenant.
      - `[ProvisioningStatus <String>]`: The provisioning status of the service plan. The possible values are:Success - Service is fully provisioned.Disabled - Service is disabled.Error - The service plan isn't provisioned and is in an error state.PendingInput - The service isn't provisioned and is awaiting service confirmation.PendingActivation - The service is provisioned but requires explicit activation by an administrator (for example, Intune_O365 service plan)PendingProvisioning - Microsoft has added a new service to the product SKU and it isn't activated in the tenant.
      - `[ServicePlanId <String>]`: The unique identifier of the service plan.
      - `[ServicePlanName <String>]`: The name of the service plan.
    - `[SkuId <String>]`: The object ID of the SKU associated with this subscription.
    - `[SkuPartNumber <String>]`: The SKU associated with this subscription.
    - `[Status <String>]`: The status of this subscription. Possible values are: Enabled, Deleted, Suspended, Warning, LockedOut.
    - `[TotalLicenses <Int32?>]`: The number of seats included in this subscription.

`CERTIFICATEAUTHORITIES <IMicrosoftGraphCertificateAuthorityPath>`: certificateAuthorityPath
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[CertificateBasedApplicationConfigurations <IMicrosoftGraphCertificateBasedApplicationConfiguration[]>]`: Defines the trusted certificate authorities for certificates that can be added to apps and service principals in the tenant.
    - `[TrustedCertificateAuthorities <IMicrosoftGraphCertificateAuthorityAsEntity[]>]`: Collection of trusted certificate authorities.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Certificate <Byte[]>]`: The trusted certificate.
      - `[IsRootAuthority <Boolean?>]`: Indicates if the certificate is a root authority. In a certificateBasedApplicationConfiguration object, at least one object in the trustedCertificateAuthorities collection must be a root authority.
      - `[Issuer <String>]`: The issuer of the trusted certificate.
      - `[IssuerSubjectKeyIdentifier <String>]`: The subject key identifier of the trusted certificate.
    - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Description <String>]`: The description of the trusted certificate authorities.
    - `[DisplayName <String>]`: The display name of the trusted certificate authorities.

`CUSTOMSECURITYATTRIBUTEDEFINITIONS <IMicrosoftGraphCustomSecurityAttributeDefinition[]>`: Schema of a custom security attributes (key-value pairs).
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AllowedValues <IMicrosoftGraphAllowedValue[]>]`: Values that are predefined for this custom security attribute. This navigation property is not returned by default and must be specified in an $expand query. For example, /directory/customSecurityAttributeDefinitions?$expand=allowedValues.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[IsActive <Boolean?>]`: Indicates whether the predefined value is active or deactivated. If set to false, this predefined value can't be assigned to any more supported directory objects.
  - `[AttributeSet <String>]`: Name of the attribute set. Case insensitive.
  - `[Description <String>]`: Description of the custom security attribute. Can be up to 128 characters long and include Unicode characters. Can be changed later.
  - `[IsCollection <Boolean?>]`: Indicates whether multiple values can be assigned to the custom security attribute. Cannot be changed later. If type is set to Boolean, isCollection cannot be set to true.
  - `[IsSearchable <Boolean?>]`: Indicates whether custom security attribute values are indexed for searching on objects that are assigned attribute values. Cannot be changed later.
  - `[Name <String>]`: Name of the custom security attribute. Must be unique within an attribute set. Can be up to 32 characters long and include Unicode characters. Cannot contain spaces or special characters. Cannot be changed later. Case insensitive.
  - `[Status <String>]`: Specifies whether the custom security attribute is active or deactivated. Acceptable values are: Available and Deprecated. Can be changed later.
  - `[Type <String>]`: Data type for the custom security attribute values. Supported types are: Boolean, Integer, and String. Cannot be changed later.
  - `[UsePreDefinedValuesOnly <Boolean?>]`: Indicates whether only predefined values can be assigned to the custom security attribute. If set to false, free-form values are allowed. Can later be changed from true to false, but cannot be changed from false to true. If type is set to Boolean, usePreDefinedValuesOnly cannot be set to true.

`DELETEDITEMS <IMicrosoftGraphDirectoryObject[]>`: Recently deleted items. Read-only. Nullable.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.

`DEVICELOCALCREDENTIALS <IMicrosoftGraphDeviceLocalCredentialInfo[]>`: The credentials of the device's local administrator account backed up to Microsoft Entra ID.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Credentials <IMicrosoftGraphDeviceLocalCredential[]>]`: The credentials of the device's local administrator account backed up to Azure Active Directory.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[AccountName <String>]`: The name of the local admin account for which LAPS is enabled.
    - `[AccountSid <String>]`: The SID of the local admin account for which LAPS is enabled.
    - `[BackupDateTime <DateTime?>]`: When the local adminstrator account credential for the device object was backed up to Microsoft Entra ID.
    - `[PasswordBase64 <String>]`: The password for the local administrator account that is backed up to Microsoft Entra ID and returned as a base 64 encoded value.
  - `[DeviceName <String>]`: Display name of the device that the local credentials are associated with.
  - `[LastBackupDateTime <DateTime?>]`: When the local administrator account credential was backed up to Microsoft Entra ID.
  - `[RefreshDateTime <DateTime?>]`: When the local administrator account credential will be refreshed and backed up to Microsoft Entra ID.

`EXTERNALUSERPROFILES <IMicrosoftGraphExternalUserProfile[]>`: Collection of external user profiles that represent collaborators in the directory.
  - `[Address <IMicrosoftGraphPhysicalOfficeAddress>]`: physicalOfficeAddress
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[City <String>]`: The city.
    - `[CountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
    - `[OfficeLocation <String>]`: Office location such as building and office number for an organizational contact.
    - `[PostalCode <String>]`: The postal code.
    - `[State <String>]`: The state.
    - `[Street <String>]`: The street.
  - `[CompanyName <String>]`: The company name of the external user profile. Supports $filter (eq, startswith).
  - `[CreatedBy <String>]`: The object ID of the user who created the external user profile. Read-only. Not nullable.
  - `[CreatedDateTime <DateTime?>]`: Date and time when this external user was created. Not nullable. Read-only.
  - `[Department <String>]`: The department of the external user profile.
  - `[DisplayName <String>]`: The display name of the external user profile.
  - `[IsDiscoverable <Boolean?>]`: Represents whether the external user profile is discoverable in the directory. When true, this external profile shows up in Teams search.
  - `[IsEnabled <Boolean?>]`: Represents whether the external user profile is enabled in the directory. This property is peer to the accountEnabled property on the user object.
  - `[JobTitle <String>]`: The job title of the external user profile.
  - `[PhoneNumber <String>]`: The phone number of the external user profile. Must be in E164 format.
  - `[SupervisorId <String>]`: The object ID of the supervisor of the external user profile. Supports $filter (eq, startswith).
  - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.

`FEATUREROLLOUTPOLICIES <IMicrosoftGraphFeatureRolloutPolicy[]>`: .
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: Nullable. Specifies a list of directoryObjects that feature is enabled for.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
  - `[Description <String>]`: A description for this feature rollout policy.
  - `[DisplayName <String>]`: The display name for this  feature rollout policy.
  - `[Feature <String>]`: stagedFeatureName
  - `[IsAppliedToOrganization <Boolean?>]`: Indicates whether this feature rollout policy should be applied to the entire organization.
  - `[IsEnabled <Boolean?>]`: Indicates whether the feature rollout is enabled.

`FEDERATIONCONFIGURATIONS <IMicrosoftGraphIdentityProviderBase[]>`: Configure domain federation with organizations whose identity provider (IdP) supports either the SAML or WS-Fed protocol.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[DisplayName <String>]`: The display name of the identity provider.

`IMPACTEDRESOURCES <IMicrosoftGraphImpactedResource[]>`: .
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AddedDateTime <DateTime?>]`: The date and time when the impactedResource object was initially associated with the recommendation.
  - `[AdditionalDetails <IMicrosoftGraphKeyValue[]>]`: Additional information unique to the impactedResource to help contextualize the recommendation.
    - `[Key <String>]`: Contains the name of the field that a value is associated with.
    - `[Value <String>]`: Contains the corresponding value for the specified key.
  - `[ApiUrl <String>]`: The URL link to the corresponding Microsoft Entra resource.
  - `[DisplayName <String>]`: Friendly name of the Microsoft Entra resource.
  - `[LastModifiedBy <String>]`: Name of the user or service that last updated the status.
  - `[LastModifiedDateTime <String>]`: The date and time when the status was last updated.
  - `[Owner <String>]`: The user responsible for maintaining the resource.
  - `[PortalUrl <String>]`: The URL link to the corresponding Microsoft Entra admin center page of the resource.
  - `[PostponeUntilDateTime <DateTime?>]`: The future date and time when the status of a postponed impactedResource will be active again.
  - `[Rank <Int32?>]`: Indicates the importance of the resource. A resource with a rank equal to 1 is of the highest importance.
  - `[RecommendationId <String>]`: The unique identifier of the recommendation that the resource is associated with.
  - `[ResourceType <String>]`: Indicates the type of Microsoft Entra resource. Examples include user, application.
  - `[Status <String>]`: recommendationStatus
  - `[SubjectId <String>]`: The related unique identifier, depending on the resourceType. For example, this property is set to the applicationId if the resourceType is an application.

`INBOUNDSHAREDUSERPROFILES <IMicrosoftGraphInboundSharedUserProfile[]>`: A collection of external users whose profile data is shared with the Microsoft Entra tenant. Nullable.
  - `[DisplayName <String>]`: The name displayed in the address book for the user at the time when the sharing record was created. Read-only.
  - `[HomeTenantId <String>]`: The home tenant id of the external user. Read-only.
  - `[UserId <String>]`: The object id of the external user. Read-only.
  - `[UserPrincipalName <String>]`: The user principal name (UPN) of the external user. Read-only.

`ONPREMISESSYNCHRONIZATION <IMicrosoftGraphOnPremisesDirectorySynchronization[]>`: A container for on-premises directory synchronization functionalities that are available for the organization.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Configuration <IMicrosoftGraphOnPremisesDirectorySynchronizationConfiguration>]`: onPremisesDirectorySynchronizationConfiguration
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AccidentalDeletionPrevention <IMicrosoftGraphOnPremisesAccidentalDeletionPrevention>]`: onPremisesAccidentalDeletionPrevention
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AlertThreshold <Int32?>]`: Threshold value which triggers accidental deletion prevention. The threshold is either an absolute number of objects or a percentage number of objects.
      - `[SynchronizationPreventionType <String>]`: onPremisesDirectorySynchronizationDeletionPreventionType
    - `[AnchorAttribute <String>]`: The anchor attribute allows customers to customize the property used to create source anchors for synchronization enabled objects.
    - `[ApplicationId <String>]`: The identifier of the on-premises directory synchronization client application that is configured for the tenant.
    - `[CurrentExportData <IMicrosoftGraphOnPremisesCurrentExportData>]`: onPremisesCurrentExportData
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ClientMachineName <String>]`: The name of the onPremises client machine that ran the last export.
      - `[PendingObjectsAddition <Int32?>]`: The count of pending adds from on-premises directory.
      - `[PendingObjectsDeletion <Int32?>]`: The count of pending deletes from on-premises directory.
      - `[PendingObjectsUpdate <Int32?>]`: The count of pending updates from on-premises directory.
      - `[ServiceAccount <String>]`: The name of the dirsync service account that is configured to connect to the directory.
      - `[SuccessfulLinksProvisioningCount <Int64?>]`: The count of updated links during the current directory sync export run.
      - `[SuccessfulObjectsProvisioningCount <Int32?>]`: The count of objects that were successfully provisioned during the current directory sync export run.
      - `[TotalConnectorSpaceObjects <Int32?>]`: The total number of objects in the AAD Connector Space.
    - `[CustomerRequestedSynchronizationInterval <TimeSpan?>]`: Interval of time that the customer requested the sync client waits between sync cycles.
    - `[SynchronizationClientVersion <String>]`: Indicates the version of the on-premises directory synchronization application.
    - `[SynchronizationInterval <TimeSpan?>]`: Interval of time the sync client should honor between sync cycles
    - `[WritebackConfiguration <IMicrosoftGraphOnPremisesWritebackConfiguration>]`: onPremisesWritebackConfiguration
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[UnifiedGroupContainer <String>]`: The distinguished name of the on-premises container that the customer is using to store unified groups which are created in the cloud.
      - `[UserContainer <String>]`: The distinguished name of the on-premises container that the customer is using to store users which are created in the cloud.
  - `[Features <IMicrosoftGraphOnPremisesDirectorySynchronizationFeature>]`: onPremisesDirectorySynchronizationFeature
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[BlockCloudObjectTakeoverThroughHardMatchEnabled <Boolean?>]`: Used to block cloud object takeover via source anchor hard match if enabled.
    - `[BlockSoftMatchEnabled <Boolean?>]`: Use to block soft match for all objects if enabled for the  tenant. Customers are encouraged to enable this feature and keep it enabled until soft matching is required again for their tenancy. This flag should be enabled again after any soft matching has been completed and is no longer needed.
    - `[BypassDirSyncOverridesEnabled <Boolean?>]`: When true, persists the values of Mobile and OtherMobile in on-premises AD during sync cycles instead of values of MobilePhone or AlternateMobilePhones in Microsoft Entra ID.
    - `[CloudPasswordPolicyForPasswordSyncedUsersEnabled <Boolean?>]`: Used to indicate that cloud password policy applies to users whose passwords are synchronized from on-premises.
    - `[ConcurrentCredentialUpdateEnabled <Boolean?>]`: Used to enable concurrent user credentials update in OrgId.
    - `[ConcurrentOrgIdProvisioningEnabled <Boolean?>]`: Used to enable concurrent user creation in OrgId.
    - `[DeviceWritebackEnabled <Boolean?>]`: Used to indicate that device write-back is enabled.
    - `[DirectoryExtensionsEnabled <Boolean?>]`: Used to indicate that directory extensions are being synced from on-premises AD to Microsoft Entra ID.
    - `[FopeConflictResolutionEnabled <Boolean?>]`: Used to indicate that for a Microsoft Forefront Online Protection for Exchange (FOPE) migrated tenant, the conflicting proxy address should be migrated over.
    - `[GroupWriteBackEnabled <Boolean?>]`: Used to enable object-level group writeback feature for additional group types.
    - `[PasswordSyncEnabled <Boolean?>]`: Used to indicate on-premise password synchronization is enabled.
    - `[PasswordWritebackEnabled <Boolean?>]`: Used to indicate that writeback of password resets from Microsoft Entra ID to on-premises AD is enabled.
    - `[QuarantineUponProxyAddressesConflictEnabled <Boolean?>]`: Used to indicate that we should quarantine objects with conflicting proxy address.
    - `[QuarantineUponUpnConflictEnabled <Boolean?>]`: Used to indicate that we should quarantine objects conflicting with duplicate userPrincipalName.
    - `[SoftMatchOnUpnEnabled <Boolean?>]`: Used to indicate that we should soft match objects based on userPrincipalName.
    - `[SynchronizeUpnForManagedUsersEnabled <Boolean?>]`: Used to indicate that we should synchronize userPrincipalName objects for managed users with licenses.
    - `[UnifiedGroupWritebackEnabled <Boolean?>]`: Used to indicate that Microsoft 365 Group write-back is enabled.
    - `[UserForcePasswordChangeOnLogonEnabled <Boolean?>]`: Used to indicate that feature to force password change for a user on logon is enabled while synchronizing on-premise credentials.
    - `[UserWritebackEnabled <Boolean?>]`: Used to indicate that user writeback is enabled.

`OUTBOUNDSHAREDUSERPROFILES <IMicrosoftGraphOutboundSharedUserProfile[]>`: .
  - `[Tenants <IMicrosoftGraphTenantReference[]>]`: The collection of external Microsoft Entra tenants that the user has shared profile data with. Read-only.
    - `[TenantId <String>]`: The identifier of the Microsoft Entra tenant. Read-only. Key.
  - `[UserId <String>]`: The object id of the external user. Read-only.

`PENDINGEXTERNALUSERPROFILES <IMicrosoftGraphPendingExternalUserProfile[]>`: Collection of pending external user profiles representing collaborators in the directory that are unredeemed.
  - `[Address <IMicrosoftGraphPhysicalOfficeAddress>]`: physicalOfficeAddress
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[City <String>]`: The city.
    - `[CountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
    - `[OfficeLocation <String>]`: Office location such as building and office number for an organizational contact.
    - `[PostalCode <String>]`: The postal code.
    - `[State <String>]`: The state.
    - `[Street <String>]`: The street.
  - `[CompanyName <String>]`: The company name of the external user profile. Supports $filter (eq, startswith).
  - `[CreatedBy <String>]`: The object ID of the user who created the external user profile. Read-only. Not nullable.
  - `[CreatedDateTime <DateTime?>]`: Date and time when this external user was created. Not nullable. Read-only.
  - `[Department <String>]`: The department of the external user profile.
  - `[DisplayName <String>]`: The display name of the external user profile.
  - `[IsDiscoverable <Boolean?>]`: Represents whether the external user profile is discoverable in the directory. When true, this external profile shows up in Teams search.
  - `[IsEnabled <Boolean?>]`: Represents whether the external user profile is enabled in the directory. This property is peer to the accountEnabled property on the user object.
  - `[JobTitle <String>]`: The job title of the external user profile.
  - `[PhoneNumber <String>]`: The phone number of the external user profile. Must be in E164 format.
  - `[SupervisorId <String>]`: The object ID of the supervisor of the external user profile. Supports $filter (eq, startswith).
  - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.

`RECOMMENDATIONS <IMicrosoftGraphRecommendation[]>`: List of recommended improvements to improve tenant posture.
  - `[ActionSteps <IMicrosoftGraphActionStep[]>]`: List of actions to take to complete a recommendation.
    - `[ActionUrl <IMicrosoftGraphActionUrl>]`: actionUrl
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: Brief title for the page that the links directs to.
      - `[Url <String>]`: The URL to the documentation or Microsoft Entra admin center page.
    - `[StepNumber <Int64?>]`: Indicates the position for this action in the order of the collection of actions to be taken.
    - `[Text <String>]`: Friendly description of the action to take.
  - `[Benefits <String>]`: An explanation of why completing the recommendation will benefit you. Corresponds to the Value section of a recommendation shown in the Microsoft Entra admin center.
  - `[Category <String>]`: recommendationCategory
  - `[CreatedDateTime <DateTime?>]`: The date and time when the recommendation was detected as applicable to your directory.
  - `[CurrentScore <Double?>]`: The number of points the tenant has attained. Only applies to recommendations with category set to identitySecureScore.
  - `[DisplayName <String>]`: The title of the recommendation.
  - `[FeatureAreas <String[]>]`: The directory feature that the recommendation is related to.
  - `[ImpactStartDateTime <DateTime?>]`: The future date and time when a recommendation should be completed.
  - `[ImpactType <String>]`: Indicates the scope of impact of a recommendation. Tenant level indicates that the recommendation impacts the whole tenant. Other possible values include users, applications.
  - `[ImpactedResources <IMicrosoftGraphImpactedResource[]>]`: The list of directory objects associated with the recommendation.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[AddedDateTime <DateTime?>]`: The date and time when the impactedResource object was initially associated with the recommendation.
    - `[AdditionalDetails <IMicrosoftGraphKeyValue[]>]`: Additional information unique to the impactedResource to help contextualize the recommendation.
      - `[Key <String>]`: Contains the name of the field that a value is associated with.
      - `[Value <String>]`: Contains the corresponding value for the specified key.
    - `[ApiUrl <String>]`: The URL link to the corresponding Microsoft Entra resource.
    - `[DisplayName <String>]`: Friendly name of the Microsoft Entra resource.
    - `[LastModifiedBy <String>]`: Name of the user or service that last updated the status.
    - `[LastModifiedDateTime <String>]`: The date and time when the status was last updated.
    - `[Owner <String>]`: The user responsible for maintaining the resource.
    - `[PortalUrl <String>]`: The URL link to the corresponding Microsoft Entra admin center page of the resource.
    - `[PostponeUntilDateTime <DateTime?>]`: The future date and time when the status of a postponed impactedResource will be active again.
    - `[Rank <Int32?>]`: Indicates the importance of the resource. A resource with a rank equal to 1 is of the highest importance.
    - `[RecommendationId <String>]`: The unique identifier of the recommendation that the resource is associated with.
    - `[ResourceType <String>]`: Indicates the type of Microsoft Entra resource. Examples include user, application.
    - `[Status <String>]`: recommendationStatus
    - `[SubjectId <String>]`: The related unique identifier, depending on the resourceType. For example, this property is set to the applicationId if the resourceType is an application.
  - `[Insights <String>]`: Describes why a recommendation uniquely applies to your directory. Corresponds to the Description section of a recommendation shown in the Microsoft Entra admin center.
  - `[LastCheckedDateTime <DateTime?>]`: The most recent date and time a recommendation was deemed applicable to your directory.
  - `[LastModifiedBy <String>]`: Name of the user who last updated the status of the recommendation.
  - `[LastModifiedDateTime <DateTime?>]`: The date and time the status of a recommendation was last updated.
  - `[MaxScore <Double?>]`: The maximum number of points attainable. Only applies to recommendations with category set to identitySecureScore.
  - `[PostponeUntilDateTime <DateTime?>]`: The future date and time when the status of a postponed recommendation will be active again.
  - `[Priority <String>]`: recommendationPriority
  - `[RecommendationType <String>]`: recommendationType
  - `[ReleaseType <String>]`: The current release type of the recommendation. The possible values are: preview, generallyAvailable, unknownFutureValue.
  - `[RemediationImpact <String>]`: Description of the impact on users of the remediation. Only applies to recommendations with category set to identitySecureScore.
  - `[Status <String>]`: recommendationStatus
  - `[Id <String>]`: The unique identifier for an entity. Read-only.

`SHAREDEMAILDOMAINS <IMicrosoftGraphSharedEmailDomain[]>`: .
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[ProvisioningStatus <String>]`: 

`SUBSCRIPTIONS <IMicrosoftGraphCompanySubscription[]>`: List of commercial subscriptions that an organization has.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[CommerceSubscriptionId <String>]`: The ID of this subscription in the commerce system. Alternate key.
  - `[CreatedDateTime <DateTime?>]`: The date and time when this subscription was created. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[IsTrial <Boolean?>]`: Whether the subscription is a free trial or purchased.
  - `[NextLifecycleDateTime <DateTime?>]`: The date and time when the subscription will move to the next state (as defined by the status property) if not renewed by the tenant. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[OcpSubscriptionId <String>]`: 
  - `[OwnerId <String>]`: The object ID of the account admin.
  - `[OwnerTenantId <String>]`: The unique identifier for the Microsoft partner tenant that created the subscription on a customer tenant.
  - `[OwnerType <String>]`: Indicates the entity that ownerId belongs to, for example, 'User'.
  - `[ServiceStatus <IMicrosoftGraphServicePlanInfo[]>]`: The provisioning status of each service that's included in this subscription.
    - `[AppliesTo <String>]`: The object the service plan can be assigned to. The possible values are: User - service plan can be assigned to individual users.Company - service plan can be assigned to the entire tenant.
    - `[ProvisioningStatus <String>]`: The provisioning status of the service plan. The possible values are:Success - Service is fully provisioned.Disabled - Service is disabled.Error - The service plan isn't provisioned and is in an error state.PendingInput - The service isn't provisioned and is awaiting service confirmation.PendingActivation - The service is provisioned but requires explicit activation by an administrator (for example, Intune_O365 service plan)PendingProvisioning - Microsoft has added a new service to the product SKU and it isn't activated in the tenant.
    - `[ServicePlanId <String>]`: The unique identifier of the service plan.
    - `[ServicePlanName <String>]`: The name of the service plan.
  - `[SkuId <String>]`: The object ID of the SKU associated with this subscription.
  - `[SkuPartNumber <String>]`: The SKU associated with this subscription.
  - `[Status <String>]`: The status of this subscription. Possible values are: Enabled, Deleted, Suspended, Warning, LockedOut.
  - `[TotalLicenses <Int32?>]`: The number of seats included in this subscription.

## RELATED LINKS

