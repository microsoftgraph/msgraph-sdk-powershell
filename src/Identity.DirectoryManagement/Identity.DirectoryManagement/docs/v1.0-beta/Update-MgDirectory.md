---
external help file: Microsoft.Graph.Identity.DirectoryManagement-help.xml
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
 [-AdministrativeUnits <IMicrosoftGraphAdministrativeUnit[]>]
 [-DeletedItems <IMicrosoftGraphDirectoryObject[]>]
 [-FeatureRolloutPolicies <IMicrosoftGraphFeatureRolloutPolicy[]>] [-Id <String>]
 [-SharedEmailDomains <IMicrosoftGraphSharedEmailDomain[]>] [-PassThru] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### Update
```
Update-MgDirectory -BodyParameter <IMicrosoftGraphDirectory> [-PassThru] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

## DESCRIPTION
Update directory

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AdministrativeUnits
.
To construct, see NOTES section for ADMINISTRATIVEUNITS properties and create a hash table.

```yaml
Type: IMicrosoftGraphAdministrativeUnit[]
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
Type: IMicrosoftGraphDirectory
Parameter Sets: Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DeletedItems
Recently deleted items.
Read-only.
Nullable.
To construct, see NOTES section for DELETEDITEMS properties and create a hash table.

```yaml
Type: IMicrosoftGraphDirectoryObject[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FeatureRolloutPolicies
Nullable.
To construct, see NOTES section for FEATUREROLLOUTPOLICIES properties and create a hash table.

```yaml
Type: IMicrosoftGraphFeatureRolloutPolicy[]
Parameter Sets: UpdateExpanded
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
Type: String
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
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

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
Type: IMicrosoftGraphSharedEmailDomain[]
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
Type: SwitchParameter
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
Type: SwitchParameter
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


ADMINISTRATIVEUNITS <IMicrosoftGraphAdministrativeUnit[]>: .
  - `[DeletedDateTime <DateTime?>]`: 
  - `[Id <String>]`: Read-only.
  - `[Description <String>]`: An optional description for the administrative unit.
  - `[DisplayName <String>]`: Display name for the administrative unit.
  - `[Extensions <IMicrosoftGraphExtension[]>]`: The collection of open extensions defined for this Administrative Unit. Nullable.
    - `[Id <String>]`: Read-only.
  - `[Members <IMicrosoftGraphDirectoryObject[]>]`: Users and groups that are members of this Adminsitrative Unit. HTTP Methods: GET (list members), POST (add members), DELETE (remove members).
    - `[Id <String>]`: Read-only.
    - `[DeletedDateTime <DateTime?>]`: 
  - `[ScopedRoleMembers <IMicrosoftGraphScopedRoleMembership[]>]`: Scoped-role members of this Administrative Unit.  HTTP Methods: GET (list scopedRoleMemberships), POST (add scopedRoleMembership), DELETE (remove scopedRoleMembership).
    - `[Id <String>]`: Read-only.
    - `[AdministrativeUnitId <String>]`: Unique identifier for the administrative unit that the directory role is scoped to
    - `[RoleId <String>]`: Unique identifier for the directory role that the member is in.
    - `[RoleMemberInfo <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
  - `[Visibility <String>]`: Controls whether the administrative unit and its members are hidden or public. Can be set to HiddenMembership or Public. If not set, default behavior is Public. When set to HiddenMembership, only members of the administrative unit can list other members of the administrative unit.

BODYPARAMETER <IMicrosoftGraphDirectory>: directory
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[AdministrativeUnits <IMicrosoftGraphAdministrativeUnit[]>]`: 
    - `[DeletedDateTime <DateTime?>]`: 
    - `[Id <String>]`: Read-only.
    - `[Description <String>]`: An optional description for the administrative unit.
    - `[DisplayName <String>]`: Display name for the administrative unit.
    - `[Extensions <IMicrosoftGraphExtension[]>]`: The collection of open extensions defined for this Administrative Unit. Nullable.
      - `[Id <String>]`: Read-only.
    - `[Members <IMicrosoftGraphDirectoryObject[]>]`: Users and groups that are members of this Adminsitrative Unit. HTTP Methods: GET (list members), POST (add members), DELETE (remove members).
      - `[Id <String>]`: Read-only.
      - `[DeletedDateTime <DateTime?>]`: 
    - `[ScopedRoleMembers <IMicrosoftGraphScopedRoleMembership[]>]`: Scoped-role members of this Administrative Unit.  HTTP Methods: GET (list scopedRoleMemberships), POST (add scopedRoleMembership), DELETE (remove scopedRoleMembership).
      - `[Id <String>]`: Read-only.
      - `[AdministrativeUnitId <String>]`: Unique identifier for the administrative unit that the directory role is scoped to
      - `[RoleId <String>]`: Unique identifier for the directory role that the member is in.
      - `[RoleMemberInfo <IMicrosoftGraphIdentity>]`: identity
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
        - `[Id <String>]`: Unique identifier for the identity.
    - `[Visibility <String>]`: Controls whether the administrative unit and its members are hidden or public. Can be set to HiddenMembership or Public. If not set, default behavior is Public. When set to HiddenMembership, only members of the administrative unit can list other members of the administrative unit.
  - `[DeletedItems <IMicrosoftGraphDirectoryObject[]>]`: Recently deleted items. Read-only. Nullable.
  - `[FeatureRolloutPolicies <IMicrosoftGraphFeatureRolloutPolicy[]>]`: Nullable.
    - `[Id <String>]`: Read-only.
    - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: Nullable. Specifies a list of directoryObjects that feature is enabled for.
    - `[Description <String>]`: A description for this feature rollout policy.
    - `[DisplayName <String>]`: The display name for this  feature rollout policy.
    - `[Feature <String>]`: stagedFeatureName
    - `[IsAppliedToOrganization <Boolean?>]`: Indicates whether this feature rollout policy should be applied to the entire organization.
    - `[IsEnabled <Boolean?>]`: Indicates whether the feature rollout is enabled.
  - `[SharedEmailDomains <IMicrosoftGraphSharedEmailDomain[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[ProvisioningStatus <String>]`: 

DELETEDITEMS <IMicrosoftGraphDirectoryObject[]>: Recently deleted items. Read-only. Nullable.
  - `[Id <String>]`: Read-only.
  - `[DeletedDateTime <DateTime?>]`: 

FEATUREROLLOUTPOLICIES <IMicrosoftGraphFeatureRolloutPolicy[]>: Nullable.
  - `[Id <String>]`: Read-only.
  - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: Nullable. Specifies a list of directoryObjects that feature is enabled for.
    - `[Id <String>]`: Read-only.
    - `[DeletedDateTime <DateTime?>]`: 
  - `[Description <String>]`: A description for this feature rollout policy.
  - `[DisplayName <String>]`: The display name for this  feature rollout policy.
  - `[Feature <String>]`: stagedFeatureName
  - `[IsAppliedToOrganization <Boolean?>]`: Indicates whether this feature rollout policy should be applied to the entire organization.
  - `[IsEnabled <Boolean?>]`: Indicates whether the feature rollout is enabled.

SHAREDEMAILDOMAINS <IMicrosoftGraphSharedEmailDomain[]>: .
  - `[Id <String>]`: Read-only.
  - `[ProvisioningStatus <String>]`: 

## RELATED LINKS
