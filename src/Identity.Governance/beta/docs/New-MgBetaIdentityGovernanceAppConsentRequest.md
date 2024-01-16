---
external help file:
Module Name: Microsoft.Graph.Beta.Identity.Governance
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.identity.governance/new-mgbetaidentitygovernanceappconsentrequest
schema: 2.0.0
---

# New-MgBetaIdentityGovernanceAppConsentRequest

## SYNOPSIS
Create new navigation property to appConsentRequests for identityGovernance

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaIdentityGovernanceAppConsentRequest [-AdditionalProperties <Hashtable>] [-AppDisplayName <String>]
 [-AppId <String>] [-ConsentType <String>] [-Id <String>]
 [-PendingScopes <IMicrosoftGraphAppConsentRequestScope[]>]
 [-UserConsentRequests <IMicrosoftGraphUserConsentRequest[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgBetaIdentityGovernanceAppConsentRequest -BodyParameter <IMicrosoftGraphAppConsentRequest> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to appConsentRequests for identityGovernance

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

## PARAMETERS

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

### -AppDisplayName
The display name of the app for which consent is requested.
Required.
Supports $filter (eq only) and $orderby.

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

### -AppId
The identifier of the application.
Required.
Supports $filter (eq only) and $orderby.

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

### -BodyParameter
appConsentRequest
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAppConsentRequest
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ConsentType
The consent type of the request.
Possible values are: Static and Dynamic.
These represent static and dynamic permissions, respectively, requested in the consent workflow.
Supports $filter (eq only) and $orderby.
Required.

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

### -PendingScopes
A list of pending scopes waiting for approval.
This is empty if the consentType is Static.
Required.
To construct, see NOTES section for PENDINGSCOPES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAppConsentRequestScope[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserConsentRequests
A list of pending user consent requests.
Supports $filter (eq).
To construct, see NOTES section for USERCONSENTREQUESTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphUserConsentRequest[]
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAppConsentRequest

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAppConsentRequest

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphAppConsentRequest>`: appConsentRequest
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AppDisplayName <String>]`: The display name of the app for which consent is requested. Required. Supports $filter (eq only) and $orderby.
  - `[AppId <String>]`: The identifier of the application. Required. Supports $filter (eq only) and $orderby.
  - `[ConsentType <String>]`: The consent type of the request. Possible values are: Static and Dynamic. These represent static and dynamic permissions, respectively, requested in the consent workflow. Supports $filter (eq only) and $orderby. Required.
  - `[PendingScopes <IMicrosoftGraphAppConsentRequestScope[]>]`: A list of pending scopes waiting for approval. This is empty if the consentType is Static. Required.
    - `[DisplayName <String>]`: The name of the scope.
  - `[UserConsentRequests <IMicrosoftGraphUserConsentRequest[]>]`: A list of pending user consent requests. Supports $filter (eq).
    - `[ApprovalId <String>]`: The identifier of the approval of the request.
    - `[CompletedDateTime <DateTime?>]`: The request completion date time.
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Application <IMicrosoftGraphIdentity>]`: identity
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: The display name of the identity. The display name might not always be available or up to date. For example, if a user changes their display name the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
        - `[Id <String>]`: Unique identifier for the identity. When the unique identifier is unavailable, the displayName property is provided for the identity, but the id property isn't included in the response.
      - `[Device <IMicrosoftGraphIdentity>]`: identity
      - `[User <IMicrosoftGraphIdentity>]`: identity
    - `[CreatedDateTime <DateTime?>]`: The request creation date time.
    - `[CustomData <String>]`: Free text field to define any custom data for the request. Not used.
    - `[Status <String>]`: The status of the request. Not nullable. The possible values are: Canceled, Denied, Failed, Granted, PendingAdminDecision, PendingApproval, PendingProvisioning, PendingScheduleCreation, Provisioned, Revoked, and ScheduleCreated. Not nullable.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Approval <IMicrosoftGraphApproval>]`: approval
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Steps <IMicrosoftGraphApprovalStep[]>]`: Used to represent the decision associated with a single step in the approval process configured in approvalStage.
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
        - `[AssignedToMe <Boolean?>]`: Indicates whether the step is assigned to the calling user to review. Read-only.
        - `[DisplayName <String>]`: The label provided by the policy creator to identify an approval step. Read-only.
        - `[Justification <String>]`: The justification associated with the approval step decision.
        - `[ReviewResult <String>]`: The result of this approval record. Possible values include: NotReviewed, Approved, Denied.
        - `[ReviewedBy <IMicrosoftGraphIdentity>]`: identity
        - `[ReviewedDateTime <DateTime?>]`: The date and time when a decision was recorded. The date and time information uses ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
        - `[Status <String>]`: The step status. Possible values: InProgress, Initializing, Completed, Expired. Read-only.
    - `[Reason <String>]`: The user's justification for requiring access to the app. Supports $filter (eq only) and $orderby.

`PENDINGSCOPES <IMicrosoftGraphAppConsentRequestScope[]>`: A list of pending scopes waiting for approval. This is empty if the consentType is Static. Required.
  - `[DisplayName <String>]`: The name of the scope.

`USERCONSENTREQUESTS <IMicrosoftGraphUserConsentRequest[]>`: A list of pending user consent requests. Supports $filter (eq).
  - `[ApprovalId <String>]`: The identifier of the approval of the request.
  - `[CompletedDateTime <DateTime?>]`: The request completion date time.
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. The display name might not always be available or up to date. For example, if a user changes their display name the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity. When the unique identifier is unavailable, the displayName property is provided for the identity, but the id property isn't included in the response.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: The request creation date time.
  - `[CustomData <String>]`: Free text field to define any custom data for the request. Not used.
  - `[Status <String>]`: The status of the request. Not nullable. The possible values are: Canceled, Denied, Failed, Granted, PendingAdminDecision, PendingApproval, PendingProvisioning, PendingScheduleCreation, Provisioned, Revoked, and ScheduleCreated. Not nullable.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Approval <IMicrosoftGraphApproval>]`: approval
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Steps <IMicrosoftGraphApprovalStep[]>]`: Used to represent the decision associated with a single step in the approval process configured in approvalStage.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[AssignedToMe <Boolean?>]`: Indicates whether the step is assigned to the calling user to review. Read-only.
      - `[DisplayName <String>]`: The label provided by the policy creator to identify an approval step. Read-only.
      - `[Justification <String>]`: The justification associated with the approval step decision.
      - `[ReviewResult <String>]`: The result of this approval record. Possible values include: NotReviewed, Approved, Denied.
      - `[ReviewedBy <IMicrosoftGraphIdentity>]`: identity
      - `[ReviewedDateTime <DateTime?>]`: The date and time when a decision was recorded. The date and time information uses ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
      - `[Status <String>]`: The step status. Possible values: InProgress, Initializing, Completed, Expired. Read-only.
  - `[Reason <String>]`: The user's justification for requiring access to the app. Supports $filter (eq only) and $orderby.

## RELATED LINKS

