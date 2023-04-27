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
 [-ImpactedResources <IMicrosoftGraphImpactedResource[]>]
 [-InboundSharedUserProfiles <IMicrosoftGraphInboundSharedUserProfile[]>]
 [-OnPremisesSynchronization <IMicrosoftGraphOnPremisesDirectorySynchronization1[]>]
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphImpactedResource[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InboundSharedUserProfiles
A collection of external Azure AD users whose profile data has been shared with the Azure AD tenant.
Nullable.
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOnPremisesDirectorySynchronization1[]
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
List of recommended improvements to improve tenant posture.
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
  - `[Description <String>]`: 
  - `[MaxAttributesPerSet <Int32?>]`: 

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
    - `[Description <String>]`: 
    - `[MaxAttributesPerSet <Int32?>]`: 
  - `[CustomSecurityAttributeDefinitions <IMicrosoftGraphCustomSecurityAttributeDefinition[]>]`: Schema of a custom security attributes (key-value pairs).
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[AllowedValues <IMicrosoftGraphAllowedValue[]>]`: 
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[IsActive <Boolean?>]`: 
    - `[AttributeSet <String>]`: 
    - `[Description <String>]`: 
    - `[IsCollection <Boolean?>]`: 
    - `[IsSearchable <Boolean?>]`: 
    - `[Name <String>]`: 
    - `[Status <String>]`: 
    - `[Type <String>]`: 
    - `[UsePreDefinedValuesOnly <Boolean?>]`: 
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
  - `[ImpactedResources <IMicrosoftGraphImpactedResource[]>]`: 
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[AddedDateTime <DateTime?>]`: The date and time when the impactedResource object was initially associated with the recommendation.
    - `[AdditionalDetails <IMicrosoftGraphKeyValue[]>]`: Additional information unique to the impactedResource to help contextualize the recommendation.
      - `[Key <String>]`: Key for the key-value pair.
      - `[Value <String>]`: Value for the key-value pair.
    - `[ApiUrl <String>]`: The URL link to the corresponding Azure AD resource.
    - `[DisplayName <String>]`: Friendly name of the Azure AD resource.
    - `[LastModifiedBy <String>]`: Name of the user or service that last updated the status.
    - `[LastModifiedDateTime <String>]`: The date and time when the status was last updated.
    - `[Owner <String>]`: The user responsible for maintaining the resource.
    - `[PortalUrl <String>]`: The URL link to the corresponding Azure AD portal page of the resource.
    - `[PostponeUntilDateTime <DateTime?>]`: The future date and time when the status of a postponed impactedResource will be active again.
    - `[Rank <Int32?>]`: Indicates the importance of the resource. A resource with a rank equal to 1 is of the highest importance.
    - `[RecommendationId <String>]`: The unique identifier of the recommendation that the resource is associated with.
    - `[ResourceType <String>]`: Indicates the type of Azure AD resource. Examples include user, application.
    - `[Status <String>]`: recommendationStatus
    - `[SubjectId <String>]`: The related unique identifier, depending on the resourceType. For example, this property is set to the applicationId if the resourceType is an application.
  - `[InboundSharedUserProfiles <IMicrosoftGraphInboundSharedUserProfile[]>]`: A collection of external Azure AD users whose profile data has been shared with the Azure AD tenant. Nullable.
    - `[DisplayName <String>]`: The name displayed in the address book for teh user at the time when the sharing record was created. Read-only.
    - `[HomeTenantId <String>]`: The home tenant id of the external user. Read-only.
    - `[UserId <String>]`: The object id of the external user. Read-only.
    - `[UserPrincipalName <String>]`: The user principal name (UPN) of the external user. Read-only.
  - `[OnPremisesSynchronization <IMicrosoftGraphOnPremisesDirectorySynchronization1[]>]`: A container for on-premises directory synchronization functionalities that are available for the organization.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Configuration <IMicrosoftGraphOnPremisesDirectorySynchronizationConfiguration1>]`: onPremisesDirectorySynchronizationConfiguration
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
    - `[Tenants <IMicrosoftGraphTenantReference[]>]`: The collection of external Azure AD tenants that the user has shared profile data with. Read-only.
      - `[TenantId <String>]`: The identifier of the Azure AD tenant. Read-only. Key.
    - `[UserId <String>]`: The object id of the external user. Read-only.
  - `[Recommendations <IMicrosoftGraphRecommendation[]>]`: List of recommended improvements to improve tenant posture.
    - `[ActionSteps <IMicrosoftGraphActionStep[]>]`: List of actions to take to complete a recommendation.
      - `[ActionUrl <IMicrosoftGraphActionUrl>]`: actionUrl
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: Brief title for the page that the links directs to.
        - `[Url <String>]`: The URL to the documentation or Azure portal page.
      - `[StepNumber <Int64?>]`: Indicates the position for this action in the order of the collection of actions to be taken.
      - `[Text <String>]`: Friendly description of the action to take.
    - `[Benefits <String>]`: An explanation of why completing the recommendation will benefit you. Corresponds to the Value section of a recommendation shown in the Azure AD portal.
    - `[Category <String>]`: recommendationCategory
    - `[CreatedDateTime <DateTime?>]`: The date and time when the recommendation was detected as applicable to your directory.
    - `[CurrentScore <Double?>]`: The number of points the tenant has attained. Only applies to recommendations with category set to identitySecureScore.
    - `[DisplayName <String>]`: The title of the recommendation.
    - `[FeatureAreas <String[]>]`: The directory feature that the recommendation is related to.
    - `[ImpactStartDateTime <DateTime?>]`: The future date and time when a recommendation should be completed.
    - `[ImpactType <String>]`: Indicates the scope of impact of a recommendation. Tenant level indicates that the recommendation impacts the whole tenant. Other possible values include users, applications.
    - `[ImpactedResources <IMicrosoftGraphImpactedResource[]>]`: The list of directory objects associated with the recommendation.
    - `[Insights <String>]`: Describes why a recommendation uniquely applies to your directory. Corresponds to the Description section of a recommendation shown in the Azure AD portal.
    - `[LastCheckedDateTime <DateTime?>]`: The most recent date and time a recommendation was deemed applicable to your directory.
    - `[LastModifiedBy <String>]`: Name of the user who last updated the status of the recommendation.
    - `[LastModifiedDateTime <DateTime?>]`: The date and time the status of a recommendation was last updated.
    - `[MaxScore <Double?>]`: The maximum number of points attainable. Only applies to recommendations with category set to identitySecureScore.
    - `[PostponeUntilDateTime <DateTime?>]`: The future date and time when the status of a postponed recommendation will be active again.
    - `[Priority <String>]`: recommendationPriority
    - `[RecommendationType <String>]`: recommendationType
    - `[RemediationImpact <String>]`: Description of the impact on users of the remediation. Only applies to recommendations with category set to identitySecureScore.
    - `[Status <String>]`: recommendationStatus
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[SharedEmailDomains <IMicrosoftGraphSharedEmailDomain[]>]`: 
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[ProvisioningStatus <String>]`: 

CUSTOMSECURITYATTRIBUTEDEFINITIONS <IMicrosoftGraphCustomSecurityAttributeDefinition[]>: Schema of a custom security attributes (key-value pairs).
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[AllowedValues <IMicrosoftGraphAllowedValue[]>]`: 
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[IsActive <Boolean?>]`: 
  - `[AttributeSet <String>]`: 
  - `[Description <String>]`: 
  - `[IsCollection <Boolean?>]`: 
  - `[IsSearchable <Boolean?>]`: 
  - `[Name <String>]`: 
  - `[Status <String>]`: 
  - `[Type <String>]`: 
  - `[UsePreDefinedValuesOnly <Boolean?>]`: 

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

IMPACTEDRESOURCES <IMicrosoftGraphImpactedResource[]>: .
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[AddedDateTime <DateTime?>]`: The date and time when the impactedResource object was initially associated with the recommendation.
  - `[AdditionalDetails <IMicrosoftGraphKeyValue[]>]`: Additional information unique to the impactedResource to help contextualize the recommendation.
    - `[Key <String>]`: Key for the key-value pair.
    - `[Value <String>]`: Value for the key-value pair.
  - `[ApiUrl <String>]`: The URL link to the corresponding Azure AD resource.
  - `[DisplayName <String>]`: Friendly name of the Azure AD resource.
  - `[LastModifiedBy <String>]`: Name of the user or service that last updated the status.
  - `[LastModifiedDateTime <String>]`: The date and time when the status was last updated.
  - `[Owner <String>]`: The user responsible for maintaining the resource.
  - `[PortalUrl <String>]`: The URL link to the corresponding Azure AD portal page of the resource.
  - `[PostponeUntilDateTime <DateTime?>]`: The future date and time when the status of a postponed impactedResource will be active again.
  - `[Rank <Int32?>]`: Indicates the importance of the resource. A resource with a rank equal to 1 is of the highest importance.
  - `[RecommendationId <String>]`: The unique identifier of the recommendation that the resource is associated with.
  - `[ResourceType <String>]`: Indicates the type of Azure AD resource. Examples include user, application.
  - `[Status <String>]`: recommendationStatus
  - `[SubjectId <String>]`: The related unique identifier, depending on the resourceType. For example, this property is set to the applicationId if the resourceType is an application.

INBOUNDSHAREDUSERPROFILES <IMicrosoftGraphInboundSharedUserProfile[]>: A collection of external Azure AD users whose profile data has been shared with the Azure AD tenant. Nullable.
  - `[DisplayName <String>]`: The name displayed in the address book for teh user at the time when the sharing record was created. Read-only.
  - `[HomeTenantId <String>]`: The home tenant id of the external user. Read-only.
  - `[UserId <String>]`: The object id of the external user. Read-only.
  - `[UserPrincipalName <String>]`: The user principal name (UPN) of the external user. Read-only.

ONPREMISESSYNCHRONIZATION <IMicrosoftGraphOnPremisesDirectorySynchronization1[]>: A container for on-premises directory synchronization functionalities that are available for the organization.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Configuration <IMicrosoftGraphOnPremisesDirectorySynchronizationConfiguration1>]`: onPremisesDirectorySynchronizationConfiguration
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
  - `[Tenants <IMicrosoftGraphTenantReference[]>]`: The collection of external Azure AD tenants that the user has shared profile data with. Read-only.
    - `[TenantId <String>]`: The identifier of the Azure AD tenant. Read-only. Key.
  - `[UserId <String>]`: The object id of the external user. Read-only.

RECOMMENDATIONS <IMicrosoftGraphRecommendation[]>: List of recommended improvements to improve tenant posture.
  - `[ActionSteps <IMicrosoftGraphActionStep[]>]`: List of actions to take to complete a recommendation.
    - `[ActionUrl <IMicrosoftGraphActionUrl>]`: actionUrl
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: Brief title for the page that the links directs to.
      - `[Url <String>]`: The URL to the documentation or Azure portal page.
    - `[StepNumber <Int64?>]`: Indicates the position for this action in the order of the collection of actions to be taken.
    - `[Text <String>]`: Friendly description of the action to take.
  - `[Benefits <String>]`: An explanation of why completing the recommendation will benefit you. Corresponds to the Value section of a recommendation shown in the Azure AD portal.
  - `[Category <String>]`: recommendationCategory
  - `[CreatedDateTime <DateTime?>]`: The date and time when the recommendation was detected as applicable to your directory.
  - `[CurrentScore <Double?>]`: The number of points the tenant has attained. Only applies to recommendations with category set to identitySecureScore.
  - `[DisplayName <String>]`: The title of the recommendation.
  - `[FeatureAreas <String[]>]`: The directory feature that the recommendation is related to.
  - `[ImpactStartDateTime <DateTime?>]`: The future date and time when a recommendation should be completed.
  - `[ImpactType <String>]`: Indicates the scope of impact of a recommendation. Tenant level indicates that the recommendation impacts the whole tenant. Other possible values include users, applications.
  - `[ImpactedResources <IMicrosoftGraphImpactedResource[]>]`: The list of directory objects associated with the recommendation.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[AddedDateTime <DateTime?>]`: The date and time when the impactedResource object was initially associated with the recommendation.
    - `[AdditionalDetails <IMicrosoftGraphKeyValue[]>]`: Additional information unique to the impactedResource to help contextualize the recommendation.
      - `[Key <String>]`: Key for the key-value pair.
      - `[Value <String>]`: Value for the key-value pair.
    - `[ApiUrl <String>]`: The URL link to the corresponding Azure AD resource.
    - `[DisplayName <String>]`: Friendly name of the Azure AD resource.
    - `[LastModifiedBy <String>]`: Name of the user or service that last updated the status.
    - `[LastModifiedDateTime <String>]`: The date and time when the status was last updated.
    - `[Owner <String>]`: The user responsible for maintaining the resource.
    - `[PortalUrl <String>]`: The URL link to the corresponding Azure AD portal page of the resource.
    - `[PostponeUntilDateTime <DateTime?>]`: The future date and time when the status of a postponed impactedResource will be active again.
    - `[Rank <Int32?>]`: Indicates the importance of the resource. A resource with a rank equal to 1 is of the highest importance.
    - `[RecommendationId <String>]`: The unique identifier of the recommendation that the resource is associated with.
    - `[ResourceType <String>]`: Indicates the type of Azure AD resource. Examples include user, application.
    - `[Status <String>]`: recommendationStatus
    - `[SubjectId <String>]`: The related unique identifier, depending on the resourceType. For example, this property is set to the applicationId if the resourceType is an application.
  - `[Insights <String>]`: Describes why a recommendation uniquely applies to your directory. Corresponds to the Description section of a recommendation shown in the Azure AD portal.
  - `[LastCheckedDateTime <DateTime?>]`: The most recent date and time a recommendation was deemed applicable to your directory.
  - `[LastModifiedBy <String>]`: Name of the user who last updated the status of the recommendation.
  - `[LastModifiedDateTime <DateTime?>]`: The date and time the status of a recommendation was last updated.
  - `[MaxScore <Double?>]`: The maximum number of points attainable. Only applies to recommendations with category set to identitySecureScore.
  - `[PostponeUntilDateTime <DateTime?>]`: The future date and time when the status of a postponed recommendation will be active again.
  - `[Priority <String>]`: recommendationPriority
  - `[RecommendationType <String>]`: recommendationType
  - `[RemediationImpact <String>]`: Description of the impact on users of the remediation. Only applies to recommendations with category set to identitySecureScore.
  - `[Status <String>]`: recommendationStatus
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.

SHAREDEMAILDOMAINS <IMicrosoftGraphSharedEmailDomain[]>: .
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[ProvisioningStatus <String>]`: 

## RELATED LINKS

