---
external help file:
Module Name: Microsoft.Graph.Identity.Partner
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.identity.partner/update-mgtenantrelationshipdelegatedadminrelationshipaccessassignment
schema: 2.0.0
---

# Update-MgTenantRelationshipDelegatedAdminRelationshipAccessAssignment

## SYNOPSIS
Update the properties of a delegatedAdminAccessAssignment object.

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgTenantRelationshipDelegatedAdminRelationshipAccessAssignment
 -DelegatedAdminAccessAssignmentId <String> -DelegatedAdminRelationshipId <String>
 [-AccessContainer <IMicrosoftGraphDelegatedAdminAccessContainer>]
 [-AccessDetails <IMicrosoftGraphDelegatedAdminAccessDetails>] [-AdditionalProperties <Hashtable>]
 [-CreatedDateTime <DateTime>] [-Id <String>] [-LastModifiedDateTime <DateTime>]
 [-ResponseHeadersVariable <String>] [-Status <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgTenantRelationshipDelegatedAdminRelationshipAccessAssignment
 -DelegatedAdminAccessAssignmentId <String> -DelegatedAdminRelationshipId <String>
 -BodyParameter <IMicrosoftGraphDelegatedAdminAccessAssignment> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgTenantRelationshipDelegatedAdminRelationshipAccessAssignment -InputObject <IIdentityPartnerIdentity>
 -BodyParameter <IMicrosoftGraphDelegatedAdminAccessAssignment> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgTenantRelationshipDelegatedAdminRelationshipAccessAssignment -InputObject <IIdentityPartnerIdentity>
 [-AccessContainer <IMicrosoftGraphDelegatedAdminAccessContainer>]
 [-AccessDetails <IMicrosoftGraphDelegatedAdminAccessDetails>] [-AdditionalProperties <Hashtable>]
 [-CreatedDateTime <DateTime>] [-Id <String>] [-LastModifiedDateTime <DateTime>]
 [-ResponseHeadersVariable <String>] [-Status <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update the properties of a delegatedAdminAccessAssignment object.

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

### -AccessContainer
delegatedAdminAccessContainer
To construct, see NOTES section for ACCESSCONTAINER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDelegatedAdminAccessContainer
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AccessDetails
delegatedAdminAccessDetails
To construct, see NOTES section for ACCESSDETAILS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDelegatedAdminAccessDetails
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
delegatedAdminAccessAssignment
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDelegatedAdminAccessAssignment
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedDateTime
The date and time in ISO 8601 format and in UTC time when the access assignment was created.
Read-only.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DelegatedAdminAccessAssignmentId
The unique identifier of delegatedAdminAccessAssignment

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DelegatedAdminRelationshipId
The unique identifier of delegatedAdminRelationship

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IIdentityPartnerIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LastModifiedDateTime
The date and time in ISO 8601 and in UTC time when this access assignment was last modified.
Read-only.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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

### -Status
delegatedAdminAccessAssignmentStatus

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IIdentityPartnerIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDelegatedAdminAccessAssignment

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDelegatedAdminAccessAssignment

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`ACCESSCONTAINER <IMicrosoftGraphDelegatedAdminAccessContainer>`: delegatedAdminAccessContainer
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AccessContainerId <String>]`: The identifier of the access container (for example, a security group). For 'securityGroup' access containers, this must be a valid ID of a Microsoft Entra security group in the Microsoft partner's tenant.
  - `[AccessContainerType <String>]`: delegatedAdminAccessContainerType

`ACCESSDETAILS <IMicrosoftGraphDelegatedAdminAccessDetails>`: delegatedAdminAccessDetails
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[UnifiedRoles <IMicrosoftGraphUnifiedRole[]>]`: The directory roles that the Microsoft partner is assigned in the customer tenant.
    - `[RoleDefinitionId <String>]`: The unified role definition ID of the directory role. Refer to unifiedRoleDefinition resource.

`BODYPARAMETER <IMicrosoftGraphDelegatedAdminAccessAssignment>`: delegatedAdminAccessAssignment
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AccessContainer <IMicrosoftGraphDelegatedAdminAccessContainer>]`: delegatedAdminAccessContainer
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AccessContainerId <String>]`: The identifier of the access container (for example, a security group). For 'securityGroup' access containers, this must be a valid ID of a Microsoft Entra security group in the Microsoft partner's tenant.
    - `[AccessContainerType <String>]`: delegatedAdminAccessContainerType
  - `[AccessDetails <IMicrosoftGraphDelegatedAdminAccessDetails>]`: delegatedAdminAccessDetails
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[UnifiedRoles <IMicrosoftGraphUnifiedRole[]>]`: The directory roles that the Microsoft partner is assigned in the customer tenant.
      - `[RoleDefinitionId <String>]`: The unified role definition ID of the directory role. Refer to unifiedRoleDefinition resource.
  - `[CreatedDateTime <DateTime?>]`: The date and time in ISO 8601 format and in UTC time when the access assignment was created. Read-only.
  - `[LastModifiedDateTime <DateTime?>]`: The date and time in ISO 8601 and in UTC time when this access assignment was last modified. Read-only.
  - `[Status <String>]`: delegatedAdminAccessAssignmentStatus

`INPUTOBJECT <IIdentityPartnerIdentity>`: Identity Parameter
  - `[DelegatedAdminAccessAssignmentId <String>]`: The unique identifier of delegatedAdminAccessAssignment
  - `[DelegatedAdminCustomerId <String>]`: The unique identifier of delegatedAdminCustomer
  - `[DelegatedAdminRelationshipId <String>]`: The unique identifier of delegatedAdminRelationship
  - `[DelegatedAdminRelationshipOperationId <String>]`: The unique identifier of delegatedAdminRelationshipOperation
  - `[DelegatedAdminRelationshipRequestId <String>]`: The unique identifier of delegatedAdminRelationshipRequest
  - `[DelegatedAdminServiceManagementDetailId <String>]`: The unique identifier of delegatedAdminServiceManagementDetail

## RELATED LINKS

