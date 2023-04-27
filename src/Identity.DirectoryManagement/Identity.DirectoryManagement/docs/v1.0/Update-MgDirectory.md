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

### UpdateExpanded1 (Default)
```
Update-MgDirectory [-AdditionalProperties <Hashtable>]
 [-AdministrativeUnits <IMicrosoftGraphAdministrativeUnit[]>] [-AttributeSets <IMicrosoftGraphAttributeSet[]>]
 [-CustomSecurityAttributeDefinitions <IMicrosoftGraphCustomSecurityAttributeDefinition[]>]
 [-DeletedItems <IMicrosoftGraphDirectoryObject[]>]
 [-FederationConfigurations <IMicrosoftGraphIdentityProviderBase[]>] [-Id <String>]
 [-OnPremisesSynchronization <IMicrosoftGraphOnPremisesDirectorySynchronization[]>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Update1
```
Update-MgDirectory -BodyParameter <IMicrosoftGraphDirectory1> [-PassThru] [-Confirm] [-WhatIf]
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
Parameter Sets: UpdateExpanded1
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAdministrativeUnit[]
Parameter Sets: UpdateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AttributeSets
.
To construct, please use Get-Help -Online and see NOTES section for ATTRIBUTESETS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAttributeSet[]
Parameter Sets: UpdateExpanded1
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectory1
Parameter Sets: Update1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CustomSecurityAttributeDefinitions
.
To construct, please use Get-Help -Online and see NOTES section for CUSTOMSECURITYATTRIBUTEDEFINITIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCustomSecurityAttributeDefinition[]
Parameter Sets: UpdateExpanded1
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
Parameter Sets: UpdateExpanded1
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
Parameter Sets: UpdateExpanded1
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
Parameter Sets: UpdateExpanded1
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
Parameter Sets: UpdateExpanded1
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectory1

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ADMINISTRATIVEUNITS <IMicrosoftGraphAdministrativeUnit[]>: Conceptual container for user and group directory objects.
  - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Description <String>]`: An optional description for the administrative unit. Supports $filter (eq, ne, in, startsWith), $search.
  - `[DisplayName <String>]`: Display name for the administrative unit. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values), $search, and $orderBy.
  - `[Extensions <IMicrosoftGraphExtension[]>]`: The collection of open extensions defined for this administrative unit. Nullable.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
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
  - `[Visibility <String>]`: Controls whether the administrative unit and its members are hidden or public. Can be set to HiddenMembership. If not set (value is null), the default behavior is public. When set to HiddenMembership, only members of the administrative unit can list other members of the administrative unit.

ATTRIBUTESETS <IMicrosoftGraphAttributeSet[]>: .
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Description <String>]`: 
  - `[MaxAttributesPerSet <Int32?>]`: 

BODYPARAMETER <IMicrosoftGraphDirectory1>: directory
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[AdministrativeUnits <IMicrosoftGraphAdministrativeUnit[]>]`: Conceptual container for user and group directory objects.
    - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Description <String>]`: An optional description for the administrative unit. Supports $filter (eq, ne, in, startsWith), $search.
    - `[DisplayName <String>]`: Display name for the administrative unit. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values), $search, and $orderBy.
    - `[Extensions <IMicrosoftGraphExtension[]>]`: The collection of open extensions defined for this administrative unit. Nullable.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
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
    - `[Visibility <String>]`: Controls whether the administrative unit and its members are hidden or public. Can be set to HiddenMembership. If not set (value is null), the default behavior is public. When set to HiddenMembership, only members of the administrative unit can list other members of the administrative unit.
  - `[AttributeSets <IMicrosoftGraphAttributeSet[]>]`: 
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Description <String>]`: 
    - `[MaxAttributesPerSet <Int32?>]`: 
  - `[CustomSecurityAttributeDefinitions <IMicrosoftGraphCustomSecurityAttributeDefinition[]>]`: 
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
  - `[FederationConfigurations <IMicrosoftGraphIdentityProviderBase[]>]`: Configure domain federation with organizations whose identity provider (IdP) supports either the SAML or WS-Fed protocol.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[DisplayName <String>]`: The display name of the identity provider.
  - `[OnPremisesSynchronization <IMicrosoftGraphOnPremisesDirectorySynchronization[]>]`: A container for on-premises directory synchronization functionalities that are available for the organization.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Configuration <IMicrosoftGraphOnPremisesDirectorySynchronizationConfiguration>]`: onPremisesDirectorySynchronizationConfiguration
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AccidentalDeletionPrevention <IMicrosoftGraphOnPremisesAccidentalDeletionPrevention>]`: onPremisesAccidentalDeletionPrevention
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[AlertThreshold <Int32?>]`: Threshold value which triggers accidental deletion prevention. The threshold is either an absolute number of objects or a percentage number of objects.
        - `[SynchronizationPreventionType <String>]`: onPremisesDirectorySynchronizationDeletionPreventionType
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

CUSTOMSECURITYATTRIBUTEDEFINITIONS <IMicrosoftGraphCustomSecurityAttributeDefinition[]>: .
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

FEDERATIONCONFIGURATIONS <IMicrosoftGraphIdentityProviderBase[]>: Configure domain federation with organizations whose identity provider (IdP) supports either the SAML or WS-Fed protocol.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[DisplayName <String>]`: The display name of the identity provider.

ONPREMISESSYNCHRONIZATION <IMicrosoftGraphOnPremisesDirectorySynchronization[]>: A container for on-premises directory synchronization functionalities that are available for the organization.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Configuration <IMicrosoftGraphOnPremisesDirectorySynchronizationConfiguration>]`: onPremisesDirectorySynchronizationConfiguration
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AccidentalDeletionPrevention <IMicrosoftGraphOnPremisesAccidentalDeletionPrevention>]`: onPremisesAccidentalDeletionPrevention
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AlertThreshold <Int32?>]`: Threshold value which triggers accidental deletion prevention. The threshold is either an absolute number of objects or a percentage number of objects.
      - `[SynchronizationPreventionType <String>]`: onPremisesDirectorySynchronizationDeletionPreventionType
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

## RELATED LINKS

