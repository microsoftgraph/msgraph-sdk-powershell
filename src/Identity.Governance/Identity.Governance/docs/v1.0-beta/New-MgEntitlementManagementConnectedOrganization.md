---
external help file: Microsoft.Graph.Identity.Governance-help.xml
Module Name: Microsoft.Graph.Identity.Governance
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/new-mgentitlementmanagementconnectedorganization
schema: 2.0.0
---

# New-MgEntitlementManagementConnectedOrganization

## SYNOPSIS
Create new navigation property to connectedOrganizations for identityGovernance

## SYNTAX

### CreateWithDomainIdentitySource (Default)
```
New-MgEntitlementManagementConnectedOrganization [-Description <String>] [-DisplayName <String>]
 [-State <String>] -DomainName <String> [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Create
```
New-MgEntitlementManagementConnectedOrganization -BodyParameter <IMicrosoftGraphConnectedOrganization>
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### CreateExpanded
```
New-MgEntitlementManagementConnectedOrganization [-AdditionalProperties <Hashtable>] [-CreatedBy <String>]
 [-CreatedDateTime <DateTime>] [-Description <String>] [-DisplayName <String>]
 [-ExternalSponsors <IMicrosoftGraphDirectoryObject[]>] [-Id <String>]
 [-IdentitySources <IMicrosoftGraphIdentitySource[]>] [-InternalSponsors <IMicrosoftGraphDirectoryObject[]>]
 [-ModifiedBy <String>] [-ModifiedDateTime <DateTime>] [-State <String>] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to connectedOrganizations for identityGovernance

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
connectedOrganization
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphConnectedOrganization
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedBy
UPN of the user who created this resource.
Read-only.

```yaml
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedDateTime
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
Read-only.

```yaml
Type: DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
The description of the connected organization.

```yaml
Type: String
Parameter Sets: CreateWithDomainIdentitySource, CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
The display name of the connected organization.

```yaml
Type: String
Parameter Sets: CreateWithDomainIdentitySource, CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DomainName
The domain name of the connected organization identity source.

```yaml
Type: String
Parameter Sets: CreateWithDomainIdentitySource
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExternalSponsors
Nullable.
To construct, see NOTES section for EXTERNALSPONSORS properties and create a hash table.

```yaml
Type: IMicrosoftGraphDirectoryObject[]
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IdentitySources
.

```yaml
Type: IMicrosoftGraphIdentitySource[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InternalSponsors
Nullable.
To construct, see NOTES section for INTERNALSPONSORS properties and create a hash table.

```yaml
Type: IMicrosoftGraphDirectoryObject[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ModifiedBy
UPN of the user who last modified this resource.
Read-only.

```yaml
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ModifiedDateTime
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
Read-only.

```yaml
Type: DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -State
connectedOrganizationState

```yaml
Type: String
Parameter Sets: CreateWithDomainIdentitySource, CreateExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphConnectedOrganization
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphConnectedOrganization
## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphConnectedOrganization>: connectedOrganization
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[CreatedBy <String>]`: UPN of the user who created this resource. Read-only.
  - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
  - `[Description <String>]`: The description of the connected organization.
  - `[DisplayName <String>]`: The display name of the connected organization.
  - `[ExternalSponsors <IMicrosoftGraphDirectoryObject[]>]`: Nullable.
    - `[Id <String>]`: Read-only.
    - `[DeletedDateTime <DateTime?>]`: 
  - `[IdentitySources <IMicrosoftGraphIdentitySource[]>]`: 
  - `[InternalSponsors <IMicrosoftGraphDirectoryObject[]>]`: Nullable.
  - `[ModifiedBy <String>]`: UPN of the user who last modified this resource. Read-only.
  - `[ModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
  - `[State <String>]`: connectedOrganizationState

EXTERNALSPONSORS <IMicrosoftGraphDirectoryObject[]>: Nullable.
  - `[Id <String>]`: Read-only.
  - `[DeletedDateTime <DateTime?>]`: 

INTERNALSPONSORS <IMicrosoftGraphDirectoryObject[]>: Nullable.
  - `[Id <String>]`: Read-only.
  - `[DeletedDateTime <DateTime?>]`: 

## RELATED LINKS
