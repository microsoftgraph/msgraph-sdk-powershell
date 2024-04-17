---
external help file:
Module Name: Microsoft.Graph.Identity.Partner
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.identity.partner/update-mgtenantrelationshipdelegatedadminrelationship
schema: 2.0.0
---

# Update-MgTenantRelationshipDelegatedAdminRelationship

## SYNOPSIS
Update the properties of a delegatedAdminRelationship object.
You can only update a relationship when it's in the created status.
However, you can update the autoExtendDuration property when the relationship is in either the created or active status.

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgTenantRelationshipDelegatedAdminRelationship -DelegatedAdminRelationshipId <String>
 [-AccessAssignments <IMicrosoftGraphDelegatedAdminAccessAssignment[]>]
 [-AccessDetails <IMicrosoftGraphDelegatedAdminAccessDetails>] [-ActivatedDateTime <DateTime>]
 [-AdditionalProperties <Hashtable>] [-AutoExtendDuration <TimeSpan>] [-CreatedDateTime <DateTime>]
 [-Customer <IMicrosoftGraphDelegatedAdminRelationshipCustomerParticipant>] [-DisplayName <String>]
 [-Duration <TimeSpan>] [-EndDateTime <DateTime>] [-Id <String>] [-LastModifiedDateTime <DateTime>]
 [-Operations <IMicrosoftGraphDelegatedAdminRelationshipOperation[]>]
 [-Requests <IMicrosoftGraphDelegatedAdminRelationshipRequest[]>] [-ResponseHeadersVariable <String>]
 [-Status <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgTenantRelationshipDelegatedAdminRelationship -DelegatedAdminRelationshipId <String>
 -BodyParameter <IMicrosoftGraphDelegatedAdminRelationship> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgTenantRelationshipDelegatedAdminRelationship -InputObject <IIdentityPartnerIdentity>
 -BodyParameter <IMicrosoftGraphDelegatedAdminRelationship> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgTenantRelationshipDelegatedAdminRelationship -InputObject <IIdentityPartnerIdentity>
 [-AccessAssignments <IMicrosoftGraphDelegatedAdminAccessAssignment[]>]
 [-AccessDetails <IMicrosoftGraphDelegatedAdminAccessDetails>] [-ActivatedDateTime <DateTime>]
 [-AdditionalProperties <Hashtable>] [-AutoExtendDuration <TimeSpan>] [-CreatedDateTime <DateTime>]
 [-Customer <IMicrosoftGraphDelegatedAdminRelationshipCustomerParticipant>] [-DisplayName <String>]
 [-Duration <TimeSpan>] [-EndDateTime <DateTime>] [-Id <String>] [-LastModifiedDateTime <DateTime>]
 [-Operations <IMicrosoftGraphDelegatedAdminRelationshipOperation[]>]
 [-Requests <IMicrosoftGraphDelegatedAdminRelationshipRequest[]>] [-ResponseHeadersVariable <String>]
 [-Status <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the properties of a delegatedAdminRelationship object.
You can only update a relationship when it's in the created status.
However, you can update the autoExtendDuration property when the relationship is in either the created or active status.

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

### -AccessAssignments
The access assignments associated with the delegated admin relationship.
To construct, see NOTES section for ACCESSASSIGNMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDelegatedAdminAccessAssignment[]
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

### -ActivatedDateTime
The date and time in ISO 8601 format and in UTC time when the relationship became active.
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

### -AutoExtendDuration
The duration by which the validity of the relationship is automatically extended, denoted in ISO 8601 format.
Supported values are: P0D, PT0S, P180D.
The default value is PT0S.
PT0S indicates that the relationship expires when the endDateTime is reached and it isn't automatically extended.

```yaml
Type: System.TimeSpan
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
delegatedAdminRelationship
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDelegatedAdminRelationship
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedDateTime
The date and time in ISO 8601 format and in UTC time when the relationship was created.
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

### -Customer
delegatedAdminRelationshipCustomerParticipant
To construct, see NOTES section for CUSTOMER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDelegatedAdminRelationshipCustomerParticipant
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
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

### -DisplayName
The display name of the relationship used for ease of identification.
Must be unique across all delegated admin relationships of the partner and is set by the partner only when the relationship is in the created status and can't be changed by the customer.
Maximum length is 50 characters.

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

### -Duration
The duration of the relationship in ISO 8601 format.
Must be a value between P1D and P2Y inclusive.
This is set by the partner only when the relationship is in the created status and can't be changed by the customer.

```yaml
Type: System.TimeSpan
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EndDateTime
The date and time in ISO 8601 format and in UTC time when the status of relationship changes to either terminated or expired.
Calculated as endDateTime = activatedDateTime + duration.
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
The date and time in ISO 8601 format and in UTC time when the relationship was last modified.
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

### -Operations
The long running operations associated with the delegated admin relationship.
To construct, see NOTES section for OPERATIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDelegatedAdminRelationshipOperation[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Requests
The requests associated with the delegated admin relationship.
To construct, see NOTES section for REQUESTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDelegatedAdminRelationshipRequest[]
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
delegatedAdminRelationshipStatus

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDelegatedAdminRelationship

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDelegatedAdminRelationship

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`ACCESSASSIGNMENTS <IMicrosoftGraphDelegatedAdminAccessAssignment[]>`: The access assignments associated with the delegated admin relationship.
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

`ACCESSDETAILS <IMicrosoftGraphDelegatedAdminAccessDetails>`: delegatedAdminAccessDetails
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[UnifiedRoles <IMicrosoftGraphUnifiedRole[]>]`: The directory roles that the Microsoft partner is assigned in the customer tenant.
    - `[RoleDefinitionId <String>]`: The unified role definition ID of the directory role. Refer to unifiedRoleDefinition resource.

`BODYPARAMETER <IMicrosoftGraphDelegatedAdminRelationship>`: delegatedAdminRelationship
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AccessAssignments <IMicrosoftGraphDelegatedAdminAccessAssignment[]>]`: The access assignments associated with the delegated admin relationship.
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
  - `[AccessDetails <IMicrosoftGraphDelegatedAdminAccessDetails>]`: delegatedAdminAccessDetails
  - `[ActivatedDateTime <DateTime?>]`: The date and time in ISO 8601 format and in UTC time when the relationship became active. Read-only.
  - `[AutoExtendDuration <TimeSpan?>]`: The duration by which the validity of the relationship is automatically extended, denoted in ISO 8601 format. Supported values are: P0D, PT0S, P180D. The default value is PT0S. PT0S indicates that the relationship expires when the endDateTime is reached and it isn't automatically extended.
  - `[CreatedDateTime <DateTime?>]`: The date and time in ISO 8601 format and in UTC time when the relationship was created. Read-only.
  - `[Customer <IMicrosoftGraphDelegatedAdminRelationshipCustomerParticipant>]`: delegatedAdminRelationshipCustomerParticipant
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The display name of the customer tenant as set by Microsoft Entra ID. Read-only
    - `[TenantId <String>]`: The Microsoft Entra ID-assigned tenant ID of the customer tenant.
  - `[DisplayName <String>]`: The display name of the relationship used for ease of identification. Must be unique across all delegated admin relationships of the partner and is set by the partner only when the relationship is in the created status and can't be changed by the customer. Maximum length is 50 characters.
  - `[Duration <TimeSpan?>]`: The duration of the relationship in ISO 8601 format. Must be a value between P1D and P2Y inclusive. This is set by the partner only when the relationship is in the created status and can't be changed by the customer.
  - `[EndDateTime <DateTime?>]`: The date and time in ISO 8601 format and in UTC time when the status of relationship changes to either terminated or expired. Calculated as endDateTime = activatedDateTime + duration. Read-only.
  - `[LastModifiedDateTime <DateTime?>]`: The date and time in ISO 8601 format and in UTC time when the relationship was last modified. Read-only.
  - `[Operations <IMicrosoftGraphDelegatedAdminRelationshipOperation[]>]`: The long running operations associated with the delegated admin relationship.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[CreatedDateTime <DateTime?>]`: The time in ISO 8601 format and in UTC time when the long-running operation was created. Read-only.
    - `[Data <String>]`: The data (payload) for the operation. Read-only.
    - `[LastModifiedDateTime <DateTime?>]`: The time in ISO 8601 format and in UTC time when the long-running operation was last modified. Read-only.
    - `[OperationType <String>]`: delegatedAdminRelationshipOperationType
    - `[Status <String>]`: longRunningOperationStatus
  - `[Requests <IMicrosoftGraphDelegatedAdminRelationshipRequest[]>]`: The requests associated with the delegated admin relationship.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Action <String>]`: delegatedAdminRelationshipRequestAction
    - `[CreatedDateTime <DateTime?>]`: The date and time in ISO 8601 format and in UTC time when the relationship request was created. Read-only.
    - `[LastModifiedDateTime <DateTime?>]`: The date and time in ISO 8601 format and UTC time when this relationship request was last modified. Read-only.
    - `[Status <String>]`: delegatedAdminRelationshipRequestStatus
  - `[Status <String>]`: delegatedAdminRelationshipStatus

`CUSTOMER <IMicrosoftGraphDelegatedAdminRelationshipCustomerParticipant>`: delegatedAdminRelationshipCustomerParticipant
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DisplayName <String>]`: The display name of the customer tenant as set by Microsoft Entra ID. Read-only
  - `[TenantId <String>]`: The Microsoft Entra ID-assigned tenant ID of the customer tenant.

`INPUTOBJECT <IIdentityPartnerIdentity>`: Identity Parameter
  - `[DelegatedAdminAccessAssignmentId <String>]`: The unique identifier of delegatedAdminAccessAssignment
  - `[DelegatedAdminCustomerId <String>]`: The unique identifier of delegatedAdminCustomer
  - `[DelegatedAdminRelationshipId <String>]`: The unique identifier of delegatedAdminRelationship
  - `[DelegatedAdminRelationshipOperationId <String>]`: The unique identifier of delegatedAdminRelationshipOperation
  - `[DelegatedAdminRelationshipRequestId <String>]`: The unique identifier of delegatedAdminRelationshipRequest
  - `[DelegatedAdminServiceManagementDetailId <String>]`: The unique identifier of delegatedAdminServiceManagementDetail

`OPERATIONS <IMicrosoftGraphDelegatedAdminRelationshipOperation[]>`: The long running operations associated with the delegated admin relationship.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[CreatedDateTime <DateTime?>]`: The time in ISO 8601 format and in UTC time when the long-running operation was created. Read-only.
  - `[Data <String>]`: The data (payload) for the operation. Read-only.
  - `[LastModifiedDateTime <DateTime?>]`: The time in ISO 8601 format and in UTC time when the long-running operation was last modified. Read-only.
  - `[OperationType <String>]`: delegatedAdminRelationshipOperationType
  - `[Status <String>]`: longRunningOperationStatus

`REQUESTS <IMicrosoftGraphDelegatedAdminRelationshipRequest[]>`: The requests associated with the delegated admin relationship.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Action <String>]`: delegatedAdminRelationshipRequestAction
  - `[CreatedDateTime <DateTime?>]`: The date and time in ISO 8601 format and in UTC time when the relationship request was created. Read-only.
  - `[LastModifiedDateTime <DateTime?>]`: The date and time in ISO 8601 format and UTC time when this relationship request was last modified. Read-only.
  - `[Status <String>]`: delegatedAdminRelationshipRequestStatus

## RELATED LINKS

