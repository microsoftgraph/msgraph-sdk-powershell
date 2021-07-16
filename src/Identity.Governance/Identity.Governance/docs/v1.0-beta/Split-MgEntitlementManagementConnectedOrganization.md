---
external help file: Microsoft.Graph.Identity.Governance-help.xml
Module Name: Microsoft.Graph.Identity.Governance
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/split-mgentitlementmanagementconnectedorganization
schema: 2.0.0
---

# Split-MgEntitlementManagementConnectedOrganization

## SYNOPSIS
Split elements of a connectedOrganization

## SYNTAX

```
Split-MgEntitlementManagementConnectedOrganization [-ByIdentitySource]
 [-ConnectedOrganization <IMicrosoftGraphConnectedOrganization[]>] [<CommonParameters>]
```

## DESCRIPTION
Split elements of one or more Azure AD entitlement management connected organizations, returned by Get-MgEntitlementManagementConnectedOrganization, to simplify reporting.

## EXAMPLES

## PARAMETERS

### -ByIdentitySource

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ConnectedOrganization
The connected organization.
To construct, see NOTES section for CONNECTEDORGANIZATION properties and create a hash table.

```yaml
Type: IMicrosoftGraphConnectedOrganization[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphConnectedOrganization[]
## OUTPUTS

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


CONNECTEDORGANIZATION <IMicrosoftGraphConnectedOrganization[]>: The connected organization.
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

## RELATED LINKS
