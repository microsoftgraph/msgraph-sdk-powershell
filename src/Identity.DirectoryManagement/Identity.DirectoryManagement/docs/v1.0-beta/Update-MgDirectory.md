---
external help file:
Module Name: Microsoft.Graph.Identity.DirectoryManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.directorymanagement/update-mgdirectory
schema: 2.0.0
---

# Update-MgDirectory

## SYNOPSIS
Update directory

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgDirectory [-AdditionalProperties <Hashtable>]
 [-AdministrativeUnits <IMicrosoftGraphAdministrativeUnit1[]>]
 [-AttributeSets <IMicrosoftGraphAttributeSet[]>]
 [-CustomSecurityAttributeDefinitions <IMicrosoftGraphCustomSecurityAttributeDefinition[]>]
 [-DeletedItems <IMicrosoftGraphDirectoryObject[]>]
 [-FeatureRolloutPolicies <IMicrosoftGraphFeatureRolloutPolicy[]>]
 [-FederationConfigurations <IMicrosoftGraphIdentityProviderBase[]>] [-Id <String>]
 [-ImpactedResources <IMicrosoftGraphRecommendationResource[]>]
 [-InboundSharedUserProfiles <IMicrosoftGraphInboundSharedUserProfile[]>]
 [-OnPremisesSynchronization <IMicrosoftGraphOnPremisesDirectorySynchronization[]>]
 [-OutboundSharedUserProfiles <IMicrosoftGraphOutboundSharedUserProfile[]>]
 [-Recommendations <IMicrosoftGraphRecommendation[]>]
 [-SharedEmailDomains <IMicrosoftGraphSharedEmailDomain[]>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgDirectory -BodyParameter <IMicrosoftGraphDirectory> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update directory

## EXAMPLES

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
To construct, please use Get-Help -Online and see NOTES section for ADMINISTRATIVEUNITS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAdministrativeUnit1[]
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
To construct, please use Get-Help -Online and see NOTES section for ATTRIBUTESETS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAttributeSet[]
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
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectory
Parameter Sets: Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CustomSecurityAttributeDefinitions
Schema of a custom security attributes (key-value pairs).
To construct, please use Get-Help -Online and see NOTES section for CUSTOMSECURITYATTRIBUTEDEFINITIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCustomSecurityAttributeDefinition[]
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
To construct, please use Get-Help -Online and see NOTES section for DELETEDITEMS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectoryObject[]
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
To construct, please use Get-Help -Online and see NOTES section for FEATUREROLLOUTPOLICIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphFeatureRolloutPolicy[]
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
To construct, please use Get-Help -Online and see NOTES section for FEDERATIONCONFIGURATIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIdentityProviderBase[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
The unique idenfier for an entity.
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
To construct, please use Get-Help -Online and see NOTES section for IMPACTEDRESOURCES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRecommendationResource[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InboundSharedUserProfiles
.
To construct, please use Get-Help -Online and see NOTES section for INBOUNDSHAREDUSERPROFILES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphInboundSharedUserProfile[]
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
To construct, please use Get-Help -Online and see NOTES section for ONPREMISESSYNCHRONIZATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOnPremisesDirectorySynchronization[]
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
To construct, please use Get-Help -Online and see NOTES section for OUTBOUNDSHAREDUSERPROFILES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOutboundSharedUserProfile[]
Parameter Sets: UpdateExpanded
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

### -Recommendations
.
To construct, please use Get-Help -Online and see NOTES section for RECOMMENDATIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRecommendation[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SharedEmailDomains
.
To construct, please use Get-Help -Online and see NOTES section for SHAREDEMAILDOMAINS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSharedEmailDomain[]
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectory

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ADMINISTRATIVEUNITS <IMicrosoftGraphAdministrativeUnit1[]>: Conceptual container for user and group directory objects.
  - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Description <String>]`: An optional description for the administrative unit. Supports $filter (eq, ne, in, startsWith), $search.
  - `[DisplayName <String>]`: Display name for the administrative unit. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values), $search, and $orderBy.
  - `[Extensions <IMicrosoftGraphExtension[]>]`: The collection of open extensions defined for this administrative unit. Nullable.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[IsMemberManagementRestricted <Boolean?>]`: 
  - `[Members <IMicrosoftGraphDirectoryObject[]>]`: Users and groups that are members of this administrative unit. Supports $expand.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
  - `[ScopedRoleMembers <IMicrosoftGraphScopedRoleMembership[]>]`: Scoped-role members of this administrative unit.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[AdministrativeUnitId <String>]`: Unique identifier for the administrative unit that the directory role is scoped to
    - `[RoleId <String>]`: Unique identifier for the directory role that the member is in.
    - `[RoleMemberInfo <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
  - `[Visibility <String>]`: Controls whether the administrative unit and its members are hidden or public. Can be set to HiddenMembership or Public. If not set, the default behavior is Public. When set to HiddenMembership, only members of the administrative unit can list other members of the administrative unit.

ATTRIBUTESETS <IMicrosoftGraphAttributeSet[]>: Group of related custom security attribute definitions.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Description <String>]`: Description of the attribute set. Can be up to 128 characters long and include Unicode characters. Can be changed later.
  - `[MaxAttributesPerSet <Int32?>]`: Maximum number of custom security attributes that can be defined in this attribute set. Default value is null. If not specified, the administrator can add up to the maximum of 500 active attributes per tenant. Can be changed later.

BODYPARAMETER <IMicrosoftGraphDirectory>: directory
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[AdministrativeUnits <IMicrosoftGraphAdministrativeUnit1[]>]`: Conceptual container for user and group directory objects.
    - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Description <String>]`: An optional description for the administrative unit. Supports $filter (eq, ne, in, startsWith), $search.
    - `[DisplayName <String>]`: Display name for the administrative unit. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values), $search, and $orderBy.
    - `[Extensions <IMicrosoftGraphExtension[]>]`: The collection of open extensions defined for this administrative unit. Nullable.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[IsMemberManagementRestricted <Boolean?>]`: 
    - `[Members <IMicrosoftGraphDirectoryObject[]>]`: Users and groups that are members of this administrative unit. Supports $expand.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
    - `[ScopedRoleMembers <IMicrosoftGraphScopedRoleMembership[]>]`: Scoped-role members of this administrative unit.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[AdministrativeUnitId <String>]`: Unique identifier for the administrative unit that the directory role is scoped to
      - `[RoleId <String>]`: Unique identifier for the directory role that the member is in.
      - `[RoleMemberInfo <IMicrosoftGraphIdentity>]`: identity
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
        - `[Id <String>]`: Unique identifier for the identity.
    - `[Visibility <String>]`: Controls whether the administrative unit and its members are hidden or public. Can be set to HiddenMembership or Public. If not set, the default behavior is Public. When set to HiddenMembership, only members of the administrative unit can list other members of the administrative unit.
  - `[AttributeSets <IMicrosoftGraphAttributeSet[]>]`: Group of related custom security attribute definitions.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Description <String>]`: Description of the attribute set. Can be up to 128 characters long and include Unicode characters. Can be changed later.
    - `[MaxAttributesPerSet <Int32?>]`: Maximum number of custom security attributes that can be defined in this attribute set. Default value is null. If not specified, the administrator can add up to the maximum of 500 active attributes per tenant. Can be changed later.
  - `[CustomSecurityAttributeDefinitions <IMicrosoftGraphCustomSecurityAttributeDefinition[]>]`: Schema of a custom security attributes (key-value pairs).
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[AllowedValues <IMicrosoftGraphAllowedValue[]>]`: Values that are predefined for this custom security attribute.This navigation property is not returned by default and must be specified in an $expand query. For example, /directory/customSecurityAttributeDefinitions?$expand=allowedValues.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[IsActive <Boolean?>]`: Indicates whether the predefined value is active or deactivated. If set to false, this predefined value cannot be assigned to any additional supported directory objects.
    - `[AttributeSet <String>]`: Name of the attribute set. Case insensitive.
    - `[Description <String>]`: Description of the custom security attribute. Can be up to 128 characters long and include Unicode characters. Can be changed later.
    - `[IsCollection <Boolean?>]`: Indicates whether multiple values can be assigned to the custom security attribute. Cannot be changed later. If type is set to Boolean, isCollection cannot be set to true.
    - `[IsSearchable <Boolean?>]`: Indicates whether custom security attribute values will be indexed for searching on objects that are assigned attribute values. Cannot be changed later.
    - `[Name <String>]`: Name of the custom security attribute. Must be unique within an attribute set. Can be up to 32 characters long and include Unicode characters. Cannot contain spaces or special characters. Cannot be changed later. Case insensitive.
    - `[Status <String>]`: Specifies whether the custom security attribute is active or deactivated. Acceptable values are Available and Deprecated. Can be changed later.
    - `[Type <String>]`: Data type for the custom security attribute values. Supported types are Boolean, Integer, and String. Cannot be changed later.
    - `[UsePreDefinedValuesOnly <Boolean?>]`: Indicates whether only predefined values can be assigned to the custom security attribute. If set to false, free-form values are allowed. Can later be changed from true to false, but cannot be changed from false to true. If type is set to Boolean, usePreDefinedValuesOnly cannot be set to true.
  - `[DeletedItems <IMicrosoftGraphDirectoryObject[]>]`: Recently deleted items. Read-only. Nullable.
  - `[FeatureRolloutPolicies <IMicrosoftGraphFeatureRolloutPolicy[]>]`: 
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: Nullable. Specifies a list of directoryObjects that feature is enabled for.
    - `[Description <String>]`: A description for this feature rollout policy.
    - `[DisplayName <String>]`: The display name for this  feature rollout policy.
    - `[Feature <String>]`: stagedFeatureName
    - `[IsAppliedToOrganization <Boolean?>]`: Indicates whether this feature rollout policy should be applied to the entire organization.
    - `[IsEnabled <Boolean?>]`: Indicates whether the feature rollout is enabled.
  - `[FederationConfigurations <IMicrosoftGraphIdentityProviderBase[]>]`: Configure domain federation with organizations whose identity provider (IdP) supports either the SAML or WS-Fed protocol.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[DisplayName <String>]`: The display name of the identity provider.
  - `[ImpactedResources <IMicrosoftGraphRecommendationResource[]>]`: 
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[AddedDateTime <DateTime?>]`: 
    - `[AdditionalDetails <IMicrosoftGraphKeyValue[]>]`: 
      - `[Key <String>]`: Key.
      - `[Value <String>]`: Value.
    - `[ApiUrl <String>]`: 
    - `[DisplayName <String>]`: 
    - `[Owner <String>]`: 
    - `[PortalUrl <String>]`: 
    - `[Rank <Int32?>]`: 
    - `[RecommendationId <String>]`: 
    - `[ResourceType <String>]`: 
    - `[Status <String>]`: recommendationStatus
  - `[InboundSharedUserProfiles <IMicrosoftGraphInboundSharedUserProfile[]>]`: 
    - `[DisplayName <String>]`: 
    - `[HomeTenantId <String>]`: 
    - `[UserId <String>]`: 
    - `[UserPrincipalName <String>]`: 
  - `[OnPremisesSynchronization <IMicrosoftGraphOnPremisesDirectorySynchronization[]>]`: A container for on-premises directory synchronization functionalities that are available for the organization.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Configuration <IMicrosoftGraphOnPremisesDirectorySynchronizationConfiguration>]`: onPremisesDirectorySynchronizationConfiguration
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AccidentalDeletionPrevention <IMicrosoftGraphOnPremisesAccidentalDeletionPrevention>]`: onPremisesAccidentalDeletionPrevention
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[AlertThreshold <Int32?>]`: Threshold value which triggers accidental deletion prevention. The threshold is either an absolute number of objects or a percentage number of objects.
        - `[SynchronizationPreventionType <String>]`: onPremisesDirectorySynchronizationDeletionPreventionType
      - `[CustomerRequestedSynchronizationInterval <TimeSpan?>]`: Interval of time that the customer requested the sync client waits between sync cycles.
      - `[SynchronizationInterval <TimeSpan?>]`: Interval of time the sync client should honor between sync cycles
    - `[Features <IMicrosoftGraphOnPremisesDirectorySynchronizationFeature>]`: onPremisesDirectorySynchronizationFeature
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[BlockCloudObjectTakeoverThroughHardMatchEnabled <Boolean?>]`: Used to block cloud object takeover via source anchor hard match if enabled.
      - `[BlockSoftMatchEnabled <Boolean?>]`: Use to block soft match for all objects if enabled for the  tenant. Customers are encouraged to enable this feature and keep it enabled until soft matching is required again for their tenancy. This flag should be enabled again after any soft matching has been completed and is no longer needed.
      - `[BypassDirSyncOverridesEnabled <Boolean?>]`: When true, persists the values of Mobile and OtherMobile in on-premises AD during sync cycles instead of values of MobilePhone or AlternateMobilePhones in Azure AD.
      - `[CloudPasswordPolicyForPasswordSyncedUsersEnabled <Boolean?>]`: Used to indicate that cloud password policy applies to users whose passwords are synchronized from on-premises.
      - `[ConcurrentCredentialUpdateEnabled <Boolean?>]`: Used to enable concurrent user credentials update in OrgId.
      - `[ConcurrentOrgIdProvisioningEnabled <Boolean?>]`: Used to enable concurrent user creation in OrgId.
      - `[DeviceWritebackEnabled <Boolean?>]`: Used to indicate that device write-back is enabled.
      - `[DirectoryExtensionsEnabled <Boolean?>]`: Used to indicate that directory extensions are being synced from on-premises AD to Azure AD.
      - `[FopeConflictResolutionEnabled <Boolean?>]`: Used to indicate that for a Microsoft Forefront Online Protection for Exchange (FOPE) migrated tenant, the conflicting proxy address should be migrated over.
      - `[GroupWriteBackEnabled <Boolean?>]`: Used to enable object-level group writeback feature for additional group types.
      - `[PasswordSyncEnabled <Boolean?>]`: Used to indicate on-premise password synchronization is enabled.
      - `[PasswordWritebackEnabled <Boolean?>]`: Used to indicate that writeback of password resets from Azure AD to on-premises AD is enabled.
      - `[QuarantineUponProxyAddressesConflictEnabled <Boolean?>]`: Used to indicate that we should quarantine objects with conflicting proxy address.
      - `[QuarantineUponUpnConflictEnabled <Boolean?>]`: Used to indicate that we should quarantine objects conflicting with duplicate userPrincipalName.
      - `[SoftMatchOnUpnEnabled <Boolean?>]`: Used to indicate that we should soft match objects based on userPrincipalName.
      - `[SynchronizeUpnForManagedUsersEnabled <Boolean?>]`: Used to indicate that we should synchronize userPrincipalName objects for managed users with licenses.
      - `[UnifiedGroupWritebackEnabled <Boolean?>]`: Used to indicate that Microsoft 365 Group write-back is enabled.
      - `[UserForcePasswordChangeOnLogonEnabled <Boolean?>]`: Used to indicate that feature to force password change for a user on logon is enabled while synchronizing on-premise credentials.
      - `[UserWritebackEnabled <Boolean?>]`: Used to indicate that user writeback is enabled.
  - `[OutboundSharedUserProfiles <IMicrosoftGraphOutboundSharedUserProfile[]>]`: 
    - `[Tenants <IMicrosoftGraphTenantReference[]>]`: 
      - `[TenantId <String>]`: 
    - `[UserId <String>]`: 
  - `[Recommendations <IMicrosoftGraphRecommendation[]>]`: 
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[ActionSteps <IMicrosoftGraphActionStep[]>]`: 
      - `[ActionUrl <IMicrosoftGraphActionUrl>]`: actionUrl
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: 
        - `[Url <String>]`: 
      - `[StepNumber <Int64?>]`: 
      - `[Text <String>]`: 
    - `[Benefits <String>]`: 
    - `[Category <String>]`: recommendationCategory
    - `[CreatedDateTime <DateTime?>]`: 
    - `[DisplayName <String>]`: 
    - `[ImpactStartDateTime <DateTime?>]`: 
    - `[ImpactType <String>]`: 
    - `[ImpactedResources <IMicrosoftGraphRecommendationResource[]>]`: 
    - `[Insights <String>]`: 
    - `[LastCheckedDateTime <DateTime?>]`: 
    - `[LastModifiedBy <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[PostponeUntilDateTime <DateTime?>]`: 
    - `[Priority <String>]`: recommendationPriority
    - `[Status <String>]`: recommendationStatus
  - `[SharedEmailDomains <IMicrosoftGraphSharedEmailDomain[]>]`: 
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[ProvisioningStatus <String>]`: 

CUSTOMSECURITYATTRIBUTEDEFINITIONS <IMicrosoftGraphCustomSecurityAttributeDefinition[]>: Schema of a custom security attributes (key-value pairs).
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[AllowedValues <IMicrosoftGraphAllowedValue[]>]`: Values that are predefined for this custom security attribute.This navigation property is not returned by default and must be specified in an $expand query. For example, /directory/customSecurityAttributeDefinitions?$expand=allowedValues.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[IsActive <Boolean?>]`: Indicates whether the predefined value is active or deactivated. If set to false, this predefined value cannot be assigned to any additional supported directory objects.
  - `[AttributeSet <String>]`: Name of the attribute set. Case insensitive.
  - `[Description <String>]`: Description of the custom security attribute. Can be up to 128 characters long and include Unicode characters. Can be changed later.
  - `[IsCollection <Boolean?>]`: Indicates whether multiple values can be assigned to the custom security attribute. Cannot be changed later. If type is set to Boolean, isCollection cannot be set to true.
  - `[IsSearchable <Boolean?>]`: Indicates whether custom security attribute values will be indexed for searching on objects that are assigned attribute values. Cannot be changed later.
  - `[Name <String>]`: Name of the custom security attribute. Must be unique within an attribute set. Can be up to 32 characters long and include Unicode characters. Cannot contain spaces or special characters. Cannot be changed later. Case insensitive.
  - `[Status <String>]`: Specifies whether the custom security attribute is active or deactivated. Acceptable values are Available and Deprecated. Can be changed later.
  - `[Type <String>]`: Data type for the custom security attribute values. Supported types are Boolean, Integer, and String. Cannot be changed later.
  - `[UsePreDefinedValuesOnly <Boolean?>]`: Indicates whether only predefined values can be assigned to the custom security attribute. If set to false, free-form values are allowed. Can later be changed from true to false, but cannot be changed from false to true. If type is set to Boolean, usePreDefinedValuesOnly cannot be set to true.

DELETEDITEMS <IMicrosoftGraphDirectoryObject[]>: Recently deleted items. Read-only. Nullable.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.

FEATUREROLLOUTPOLICIES <IMicrosoftGraphFeatureRolloutPolicy[]>: .
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: Nullable. Specifies a list of directoryObjects that feature is enabled for.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
  - `[Description <String>]`: A description for this feature rollout policy.
  - `[DisplayName <String>]`: The display name for this  feature rollout policy.
  - `[Feature <String>]`: stagedFeatureName
  - `[IsAppliedToOrganization <Boolean?>]`: Indicates whether this feature rollout policy should be applied to the entire organization.
  - `[IsEnabled <Boolean?>]`: Indicates whether the feature rollout is enabled.

FEDERATIONCONFIGURATIONS <IMicrosoftGraphIdentityProviderBase[]>: Configure domain federation with organizations whose identity provider (IdP) supports either the SAML or WS-Fed protocol.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[DisplayName <String>]`: The display name of the identity provider.

IMPACTEDRESOURCES <IMicrosoftGraphRecommendationResource[]>: .
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[AddedDateTime <DateTime?>]`: 
  - `[AdditionalDetails <IMicrosoftGraphKeyValue[]>]`: 
    - `[Key <String>]`: Key.
    - `[Value <String>]`: Value.
  - `[ApiUrl <String>]`: 
  - `[DisplayName <String>]`: 
  - `[Owner <String>]`: 
  - `[PortalUrl <String>]`: 
  - `[Rank <Int32?>]`: 
  - `[RecommendationId <String>]`: 
  - `[ResourceType <String>]`: 
  - `[Status <String>]`: recommendationStatus

INBOUNDSHAREDUSERPROFILES <IMicrosoftGraphInboundSharedUserProfile[]>: .
  - `[DisplayName <String>]`: 
  - `[HomeTenantId <String>]`: 
  - `[UserId <String>]`: 
  - `[UserPrincipalName <String>]`: 

ONPREMISESSYNCHRONIZATION <IMicrosoftGraphOnPremisesDirectorySynchronization[]>: A container for on-premises directory synchronization functionalities that are available for the organization.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Configuration <IMicrosoftGraphOnPremisesDirectorySynchronizationConfiguration>]`: onPremisesDirectorySynchronizationConfiguration
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AccidentalDeletionPrevention <IMicrosoftGraphOnPremisesAccidentalDeletionPrevention>]`: onPremisesAccidentalDeletionPrevention
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AlertThreshold <Int32?>]`: Threshold value which triggers accidental deletion prevention. The threshold is either an absolute number of objects or a percentage number of objects.
      - `[SynchronizationPreventionType <String>]`: onPremisesDirectorySynchronizationDeletionPreventionType
    - `[CustomerRequestedSynchronizationInterval <TimeSpan?>]`: Interval of time that the customer requested the sync client waits between sync cycles.
    - `[SynchronizationInterval <TimeSpan?>]`: Interval of time the sync client should honor between sync cycles
  - `[Features <IMicrosoftGraphOnPremisesDirectorySynchronizationFeature>]`: onPremisesDirectorySynchronizationFeature
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[BlockCloudObjectTakeoverThroughHardMatchEnabled <Boolean?>]`: Used to block cloud object takeover via source anchor hard match if enabled.
    - `[BlockSoftMatchEnabled <Boolean?>]`: Use to block soft match for all objects if enabled for the  tenant. Customers are encouraged to enable this feature and keep it enabled until soft matching is required again for their tenancy. This flag should be enabled again after any soft matching has been completed and is no longer needed.
    - `[BypassDirSyncOverridesEnabled <Boolean?>]`: When true, persists the values of Mobile and OtherMobile in on-premises AD during sync cycles instead of values of MobilePhone or AlternateMobilePhones in Azure AD.
    - `[CloudPasswordPolicyForPasswordSyncedUsersEnabled <Boolean?>]`: Used to indicate that cloud password policy applies to users whose passwords are synchronized from on-premises.
    - `[ConcurrentCredentialUpdateEnabled <Boolean?>]`: Used to enable concurrent user credentials update in OrgId.
    - `[ConcurrentOrgIdProvisioningEnabled <Boolean?>]`: Used to enable concurrent user creation in OrgId.
    - `[DeviceWritebackEnabled <Boolean?>]`: Used to indicate that device write-back is enabled.
    - `[DirectoryExtensionsEnabled <Boolean?>]`: Used to indicate that directory extensions are being synced from on-premises AD to Azure AD.
    - `[FopeConflictResolutionEnabled <Boolean?>]`: Used to indicate that for a Microsoft Forefront Online Protection for Exchange (FOPE) migrated tenant, the conflicting proxy address should be migrated over.
    - `[GroupWriteBackEnabled <Boolean?>]`: Used to enable object-level group writeback feature for additional group types.
    - `[PasswordSyncEnabled <Boolean?>]`: Used to indicate on-premise password synchronization is enabled.
    - `[PasswordWritebackEnabled <Boolean?>]`: Used to indicate that writeback of password resets from Azure AD to on-premises AD is enabled.
    - `[QuarantineUponProxyAddressesConflictEnabled <Boolean?>]`: Used to indicate that we should quarantine objects with conflicting proxy address.
    - `[QuarantineUponUpnConflictEnabled <Boolean?>]`: Used to indicate that we should quarantine objects conflicting with duplicate userPrincipalName.
    - `[SoftMatchOnUpnEnabled <Boolean?>]`: Used to indicate that we should soft match objects based on userPrincipalName.
    - `[SynchronizeUpnForManagedUsersEnabled <Boolean?>]`: Used to indicate that we should synchronize userPrincipalName objects for managed users with licenses.
    - `[UnifiedGroupWritebackEnabled <Boolean?>]`: Used to indicate that Microsoft 365 Group write-back is enabled.
    - `[UserForcePasswordChangeOnLogonEnabled <Boolean?>]`: Used to indicate that feature to force password change for a user on logon is enabled while synchronizing on-premise credentials.
    - `[UserWritebackEnabled <Boolean?>]`: Used to indicate that user writeback is enabled.

OUTBOUNDSHAREDUSERPROFILES <IMicrosoftGraphOutboundSharedUserProfile[]>: .
  - `[Tenants <IMicrosoftGraphTenantReference[]>]`: 
    - `[TenantId <String>]`: 
  - `[UserId <String>]`: 

RECOMMENDATIONS <IMicrosoftGraphRecommendation[]>: .
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[ActionSteps <IMicrosoftGraphActionStep[]>]`: 
    - `[ActionUrl <IMicrosoftGraphActionUrl>]`: actionUrl
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: 
      - `[Url <String>]`: 
    - `[StepNumber <Int64?>]`: 
    - `[Text <String>]`: 
  - `[Benefits <String>]`: 
  - `[Category <String>]`: recommendationCategory
  - `[CreatedDateTime <DateTime?>]`: 
  - `[DisplayName <String>]`: 
  - `[ImpactStartDateTime <DateTime?>]`: 
  - `[ImpactType <String>]`: 
  - `[ImpactedResources <IMicrosoftGraphRecommendationResource[]>]`: 
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[AddedDateTime <DateTime?>]`: 
    - `[AdditionalDetails <IMicrosoftGraphKeyValue[]>]`: 
      - `[Key <String>]`: Key.
      - `[Value <String>]`: Value.
    - `[ApiUrl <String>]`: 
    - `[DisplayName <String>]`: 
    - `[Owner <String>]`: 
    - `[PortalUrl <String>]`: 
    - `[Rank <Int32?>]`: 
    - `[RecommendationId <String>]`: 
    - `[ResourceType <String>]`: 
    - `[Status <String>]`: recommendationStatus
  - `[Insights <String>]`: 
  - `[LastCheckedDateTime <DateTime?>]`: 
  - `[LastModifiedBy <String>]`: 
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[PostponeUntilDateTime <DateTime?>]`: 
  - `[Priority <String>]`: recommendationPriority
  - `[Status <String>]`: recommendationStatus

SHAREDEMAILDOMAINS <IMicrosoftGraphSharedEmailDomain[]>: .
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[ProvisioningStatus <String>]`: 

## RELATED LINKS

