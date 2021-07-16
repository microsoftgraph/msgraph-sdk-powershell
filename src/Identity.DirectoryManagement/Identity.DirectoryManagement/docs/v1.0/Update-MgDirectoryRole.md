---
external help file:
Module Name: Microsoft.Graph.Identity.DirectoryManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.directorymanagement/update-mgdirectoryrole
schema: 2.0.0
---

# Update-MgDirectoryRole

## SYNOPSIS
Represents an Azure Active Directory object.
The directoryObject type is the base type for many other directory entity types.

## SYNTAX

### UpdateExpanded1 (Default)
```
Update-MgDirectoryRole -DirectoryRoleId <String> [-AdditionalProperties <Hashtable>]
 [-DeletedDateTime <DateTime>] [-Description <String>] [-DisplayName <String>] [-Id <String>]
 [-Members <IMicrosoftGraphDirectoryObject[]>] [-RoleTemplateId <String>]
 [-ScopedMembers <IMicrosoftGraphScopedRoleMembership[]>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update1
```
Update-MgDirectoryRole -DirectoryRoleId <String> -BodyParameter <IMicrosoftGraphDirectoryRole> [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity1
```
Update-MgDirectoryRole -InputObject <IIdentityDirectoryManagementIdentity>
 -BodyParameter <IMicrosoftGraphDirectoryRole> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded1
```
Update-MgDirectoryRole -InputObject <IIdentityDirectoryManagementIdentity> [-AdditionalProperties <Hashtable>]
 [-DeletedDateTime <DateTime>] [-Description <String>] [-DisplayName <String>] [-Id <String>]
 [-Members <IMicrosoftGraphDirectoryObject[]>] [-RoleTemplateId <String>]
 [-ScopedMembers <IMicrosoftGraphScopedRoleMembership[]>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Represents an Azure Active Directory object.
The directoryObject type is the base type for many other directory entity types.

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectoryRole
Parameter Sets: Update1, UpdateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DeletedDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
The description for the directory role.
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DirectoryRoleId
key: id of directoryRole

```yaml
Type: System.String
Parameter Sets: Update1, UpdateExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
The display name for the directory role.
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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
Type: Microsoft.Graph.PowerShell.Models.IIdentityDirectoryManagementIdentity
Parameter Sets: UpdateViaIdentity1, UpdateViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Members
Users that are members of this directory role.
HTTP Methods: GET, POST, DELETE.
Read-only.
Nullable.
To construct, see NOTES section for MEMBERS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectoryObject[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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

### -RoleTemplateId
The id of the directoryRoleTemplate that this role is based on.
The property must be specified when activating a directory role in a tenant with a POST operation.
After the directory role has been activated, the property is read only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ScopedMembers
Members of this directory role that are scoped to administrative units.
Read-only.
Nullable.
To construct, see NOTES section for SCOPEDMEMBERS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphScopedRoleMembership[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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

### Microsoft.Graph.PowerShell.Models.IIdentityDirectoryManagementIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectoryRole

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphDirectoryRole>: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DeletedDateTime <DateTime?>]`: 
  - `[Id <String>]`: Read-only.
  - `[Description <String>]`: The description for the directory role. Read-only.
  - `[DisplayName <String>]`: The display name for the directory role. Read-only.
  - `[Members <IMicrosoftGraphDirectoryObject[]>]`: Users that are members of this directory role. HTTP Methods: GET, POST, DELETE. Read-only. Nullable.
    - `[Id <String>]`: Read-only.
    - `[DeletedDateTime <DateTime?>]`: 
  - `[RoleTemplateId <String>]`: The id of the directoryRoleTemplate that this role is based on. The property must be specified when activating a directory role in a tenant with a POST operation. After the directory role has been activated, the property is read only.
  - `[ScopedMembers <IMicrosoftGraphScopedRoleMembership[]>]`: Members of this directory role that are scoped to administrative units. Read-only. Nullable.
    - `[Id <String>]`: Read-only.
    - `[AdministrativeUnitId <String>]`: Unique identifier for the administrative unit that the directory role is scoped to
    - `[RoleId <String>]`: Unique identifier for the directory role that the member is in.
    - `[RoleMemberInfo <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.

INPUTOBJECT <IIdentityDirectoryManagementIdentity>: Identity Parameter
  - `[AdministrativeUnitId <String>]`: key: id of administrativeUnit
  - `[CommandId <String>]`: key: id of command
  - `[ContractId <String>]`: key: id of contract
  - `[DeviceId <String>]`: key: id of device
  - `[DirectoryObjectId <String>]`: key: id of directoryObject
  - `[DirectoryRoleId <String>]`: key: id of directoryRole
  - `[DirectoryRoleTemplateId <String>]`: key: id of directoryRoleTemplate
  - `[DirectorySettingId <String>]`: key: id of directorySetting
  - `[DirectorySettingTemplateId <String>]`: key: id of directorySettingTemplate
  - `[DomainDnsRecordId <String>]`: key: id of domainDnsRecord
  - `[DomainId <String>]`: key: id of domain
  - `[ExtensionId <String>]`: key: id of extension
  - `[FeatureRolloutPolicyId <String>]`: key: id of featureRolloutPolicy
  - `[OrgContactId <String>]`: key: id of orgContact
  - `[OrganizationId <String>]`: key: id of organization
  - `[ProfileCardPropertyId <String>]`: key: id of profileCardProperty
  - `[ScopedRoleMembershipId <String>]`: key: id of scopedRoleMembership
  - `[SharedEmailDomainId <String>]`: key: id of sharedEmailDomain
  - `[SharedEmailDomainInvitationId <String>]`: key: id of sharedEmailDomainInvitation
  - `[SubscribedSkuId <String>]`: key: id of subscribedSku
  - `[UsageRightId <String>]`: key: id of usageRight
  - `[UserId <String>]`: key: id of user

MEMBERS <IMicrosoftGraphDirectoryObject[]>: Users that are members of this directory role. HTTP Methods: GET, POST, DELETE. Read-only. Nullable.
  - `[Id <String>]`: Read-only.
  - `[DeletedDateTime <DateTime?>]`: 

SCOPEDMEMBERS <IMicrosoftGraphScopedRoleMembership[]>: Members of this directory role that are scoped to administrative units. Read-only. Nullable.
  - `[Id <String>]`: Read-only.
  - `[AdministrativeUnitId <String>]`: Unique identifier for the administrative unit that the directory role is scoped to
  - `[RoleId <String>]`: Unique identifier for the directory role that the member is in.
  - `[RoleMemberInfo <IMicrosoftGraphIdentity>]`: identity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.

## RELATED LINKS

