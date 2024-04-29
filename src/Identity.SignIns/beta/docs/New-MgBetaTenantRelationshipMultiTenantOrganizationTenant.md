---
external help file:
Module Name: Microsoft.Graph.Beta.Identity.SignIns
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.identity.signins/new-mgbetatenantrelationshipmultitenantorganizationtenant
schema: 2.0.0
---

# New-MgBetaTenantRelationshipMultiTenantOrganizationTenant

## SYNOPSIS
Add a tenant to a multitenant organization.
The administrator of an owner tenant has the permissions to add tenants to the multitenant organization.
The added tenant is in the pending state until the administrator of the added tenant joins the multitenant organization by submitting a join request.
A tenant can be part of only one multitenant organization.

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaTenantRelationshipMultiTenantOrganizationTenant [-AddedByTenantId <String>]
 [-AddedDateTime <DateTime>] [-AdditionalProperties <Hashtable>] [-DeletedDateTime <DateTime>]
 [-DisplayName <String>] [-Id <String>] [-JoinedDateTime <DateTime>] [-Role <String>] [-State <String>]
 [-TenantId <String>] [-TransitionDetails <IMicrosoftGraphMultiTenantOrganizationMemberTransitionDetails>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgBetaTenantRelationshipMultiTenantOrganizationTenant
 -BodyParameter <IMicrosoftGraphMultiTenantOrganizationMember> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Add a tenant to a multitenant organization.
The administrator of an owner tenant has the permissions to add tenants to the multitenant organization.
The added tenant is in the pending state until the administrator of the added tenant joins the multitenant organization by submitting a join request.
A tenant can be part of only one multitenant organization.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```



### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```



## PARAMETERS

### -AddedByTenantId
Tenant ID of the tenant that added the tenant to the multitenant organization.
Read-only.

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

### -AddedDateTime
Date and time when the tenant was added to the multitenant organization.
Read-only.

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

### -BodyParameter
multiTenantOrganizationMember
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphMultiTenantOrganizationMember
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### -DisplayName
Display name of the tenant added to the multitenant organization.

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

### -Id
The unique identifier for an entity.
Read-only.

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

### -JoinedDateTime
Date and time when the tenant joined the multitenant organization.
Read-only.

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

### -Role
multiTenantOrganizationMemberRole

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

### -State
multiTenantOrganizationMemberState

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

### -TenantId
Tenant ID of the Microsoft Entra tenant added to the multitenant organization.
Set at the time tenant is added.Supports $filter.
Key.

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

### -TransitionDetails
multiTenantOrganizationMemberTransitionDetails
To construct, see NOTES section for TRANSITIONDETAILS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphMultiTenantOrganizationMemberTransitionDetails
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphMultiTenantOrganizationMember

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphMultiTenantOrganizationMember

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphMultiTenantOrganizationMember>`: multiTenantOrganizationMember
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AddedByTenantId <String>]`: Tenant ID of the tenant that added the tenant to the multitenant organization. Read-only.
  - `[AddedDateTime <DateTime?>]`: Date and time when the tenant was added to the multitenant organization. Read-only.
  - `[DisplayName <String>]`: Display name of the tenant added to the multitenant organization.
  - `[JoinedDateTime <DateTime?>]`: Date and time when the tenant joined the multitenant organization. Read-only.
  - `[Role <String>]`: multiTenantOrganizationMemberRole
  - `[State <String>]`: multiTenantOrganizationMemberState
  - `[TenantId <String>]`: Tenant ID of the Microsoft Entra tenant added to the multitenant organization. Set at the time tenant is added.Supports $filter. Key.
  - `[TransitionDetails <IMicrosoftGraphMultiTenantOrganizationMemberTransitionDetails>]`: multiTenantOrganizationMemberTransitionDetails
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DesiredRole <String>]`: multiTenantOrganizationMemberRole
    - `[DesiredState <String>]`: multiTenantOrganizationMemberState
    - `[Details <String>]`: Details that explain the processing status if any. Read-only.
    - `[Status <String>]`: multiTenantOrganizationMemberProcessingStatus

`TRANSITIONDETAILS <IMicrosoftGraphMultiTenantOrganizationMemberTransitionDetails>`: multiTenantOrganizationMemberTransitionDetails
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DesiredRole <String>]`: multiTenantOrganizationMemberRole
  - `[DesiredState <String>]`: multiTenantOrganizationMemberState
  - `[Details <String>]`: Details that explain the processing status if any. Read-only.
  - `[Status <String>]`: multiTenantOrganizationMemberProcessingStatus

## RELATED LINKS

