---
external help file:
Module Name: Microsoft.Graph.Beta.Identity.Partner
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.identity.partner/new-mgbetatenantrelationshipdelegatedadmincustomerservicemanagementdetail
schema: 2.0.0
---

# New-MgBetaTenantRelationshipDelegatedAdminCustomerServiceManagementDetail

## SYNOPSIS
Create new navigation property to serviceManagementDetails for tenantRelationships

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaTenantRelationshipDelegatedAdminCustomerServiceManagementDetail -DelegatedAdminCustomerId <String>
 [-AdditionalProperties <Hashtable>] [-Id <String>] [-ServiceManagementUrl <String>] [-ServiceName <String>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgBetaTenantRelationshipDelegatedAdminCustomerServiceManagementDetail -DelegatedAdminCustomerId <String>
 -BodyParameter <IMicrosoftGraphDelegatedAdminServiceManagementDetail> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgBetaTenantRelationshipDelegatedAdminCustomerServiceManagementDetail
 -InputObject <IIdentityPartnerIdentity> -BodyParameter <IMicrosoftGraphDelegatedAdminServiceManagementDetail>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgBetaTenantRelationshipDelegatedAdminCustomerServiceManagementDetail
 -InputObject <IIdentityPartnerIdentity> [-AdditionalProperties <Hashtable>] [-Id <String>]
 [-ServiceManagementUrl <String>] [-ServiceName <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to serviceManagementDetails for tenantRelationships

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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
delegatedAdminServiceManagementDetail
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDelegatedAdminServiceManagementDetail
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DelegatedAdminCustomerId
The unique identifier of delegatedAdminCustomer

```yaml
Type: System.String
Parameter Sets: Create, CreateExpanded
Aliases:

Required: True
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IIdentityPartnerIdentity
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ServiceManagementUrl
The URL of the management portal for the managed service.
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ServiceName
The name of a managed service.
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IIdentityPartnerIdentity

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDelegatedAdminServiceManagementDetail

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDelegatedAdminServiceManagementDetail

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphDelegatedAdminServiceManagementDetail>`: delegatedAdminServiceManagementDetail
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[ServiceManagementUrl <String>]`: The URL of the management portal for the managed service. Read-only.
  - `[ServiceName <String>]`: The name of a managed service. Read-only.

`INPUTOBJECT <IIdentityPartnerIdentity>`: Identity Parameter
  - `[DelegatedAdminAccessAssignmentId <String>]`: The unique identifier of delegatedAdminAccessAssignment
  - `[DelegatedAdminCustomerId <String>]`: The unique identifier of delegatedAdminCustomer
  - `[DelegatedAdminRelationshipId <String>]`: The unique identifier of delegatedAdminRelationship
  - `[DelegatedAdminRelationshipOperationId <String>]`: The unique identifier of delegatedAdminRelationshipOperation
  - `[DelegatedAdminRelationshipRequestId <String>]`: The unique identifier of delegatedAdminRelationshipRequest
  - `[DelegatedAdminServiceManagementDetailId <String>]`: The unique identifier of delegatedAdminServiceManagementDetail

## RELATED LINKS

