---
external help file:
Module Name: Microsoft.Graph.Beta.Identity.SignIns
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.identity.signins/update-mgbetatenantrelationshipmultitenantorganization
schema: 2.0.0
---

# Update-MgBetaTenantRelationshipMultiTenantOrganization

## SYNOPSIS
Update the properties of a multi-tenant organization.

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaTenantRelationshipMultiTenantOrganization [-AdditionalProperties <Hashtable>]
 [-CreatedDateTime <DateTime>] [-Description <String>] [-DisplayName <String>] [-Id <String>]
 [-JoinRequest <IMicrosoftGraphMultiTenantOrganizationJoinRequestRecord>] [-ResponseHeadersVariable <String>]
 [-State <String>] [-Tenants <IMicrosoftGraphMultiTenantOrganizationMember[]>] [-Headers <IDictionary>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaTenantRelationshipMultiTenantOrganization -BodyParameter <IMicrosoftGraphMultiTenantOrganization>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the properties of a multi-tenant organization.

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

### -BodyParameter
multiTenantOrganization
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphMultiTenantOrganization
Parameter Sets: Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedDateTime
Date when multitenant organization was created.
Read-only.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
Description of the multitenant organization.

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

### -DisplayName
Display name of the multitenant organization.

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

### -JoinRequest
multiTenantOrganizationJoinRequestRecord
To construct, see NOTES section for JOINREQUEST properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphMultiTenantOrganizationJoinRequestRecord
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

### -State
multiTenantOrganizationState

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

### -Tenants
Defines tenants added to a multitenant organization.
To construct, see NOTES section for TENANTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphMultiTenantOrganizationMember[]
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphMultiTenantOrganization

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphMultiTenantOrganization

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphMultiTenantOrganization>`: multiTenantOrganization
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[CreatedDateTime <DateTime?>]`: Date when multitenant organization was created. Read-only.
  - `[Description <String>]`: Description of the multitenant organization.
  - `[DisplayName <String>]`: Display name of the multitenant organization.
  - `[JoinRequest <IMicrosoftGraphMultiTenantOrganizationJoinRequestRecord>]`: multiTenantOrganizationJoinRequestRecord
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[AddedByTenantId <String>]`: Tenant ID of the Microsoft Entra tenant that added a tenant to the multi-tenant organization. To reset a failed join request, set addedByTenantId to 00000000-0000-0000-0000-000000000000. Required.
    - `[MemberState <String>]`: multiTenantOrganizationMemberState
    - `[Role <String>]`: multiTenantOrganizationMemberRole
    - `[TransitionDetails <IMicrosoftGraphMultiTenantOrganizationJoinRequestTransitionDetails>]`: multiTenantOrganizationJoinRequestTransitionDetails
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DesiredMemberState <String>]`: multiTenantOrganizationMemberState
      - `[Details <String>]`: Details that explain the processing status if any. Read-only.
      - `[Status <String>]`: multiTenantOrganizationMemberProcessingStatus
  - `[State <String>]`: multiTenantOrganizationState
  - `[Tenants <IMicrosoftGraphMultiTenantOrganizationMember[]>]`: Defines tenants added to a multitenant organization.
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

`JOINREQUEST <IMicrosoftGraphMultiTenantOrganizationJoinRequestRecord>`: multiTenantOrganizationJoinRequestRecord
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AddedByTenantId <String>]`: Tenant ID of the Microsoft Entra tenant that added a tenant to the multi-tenant organization. To reset a failed join request, set addedByTenantId to 00000000-0000-0000-0000-000000000000. Required.
  - `[MemberState <String>]`: multiTenantOrganizationMemberState
  - `[Role <String>]`: multiTenantOrganizationMemberRole
  - `[TransitionDetails <IMicrosoftGraphMultiTenantOrganizationJoinRequestTransitionDetails>]`: multiTenantOrganizationJoinRequestTransitionDetails
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DesiredMemberState <String>]`: multiTenantOrganizationMemberState
    - `[Details <String>]`: Details that explain the processing status if any. Read-only.
    - `[Status <String>]`: multiTenantOrganizationMemberProcessingStatus

`TENANTS <IMicrosoftGraphMultiTenantOrganizationMember[]>`: Defines tenants added to a multitenant organization.
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

## RELATED LINKS

