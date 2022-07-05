---
external help file:
Module Name: Microsoft.Graph.Identity.SignIns
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.signins/new-mgriskyserviceprincipal
schema: 2.0.0
---

# New-MgRiskyServicePrincipal

## SYNOPSIS
Create new navigation property to riskyServicePrincipals for identityProtection

## SYNTAX

### CreateExpanded (Default)
```
New-MgRiskyServicePrincipal [-AccountEnabled] [-AdditionalProperties <Hashtable>] [-AppId <String>]
 [-DisplayName <String>] [-History <IMicrosoftGraphRiskyServicePrincipalHistoryItem[]>] [-Id <String>]
 [-IsProcessing] [-RiskDetail <String>] [-RiskLastUpdatedDateTime <DateTime>] [-RiskLevel <String>]
 [-RiskState <String>] [-ServicePrincipalType <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgRiskyServicePrincipal -BodyParameter <IMicrosoftGraphRiskyServicePrincipal> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to riskyServicePrincipals for identityProtection

## EXAMPLES

## PARAMETERS

### -AccountEnabled
true if the service principal account is enabled; otherwise, false.

```yaml
Type: System.Management.Automation.SwitchParameter
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

### -AppId
The globally unique identifier for the associated application (its appId property), if any.

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
riskyServicePrincipal
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRiskyServicePrincipal
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DisplayName
The display name for the service principal.

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

### -History
Represents the risk history of Azure AD service principals.
To construct, please use Get-Help -Online and see NOTES section for HISTORY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRiskyServicePrincipalHistoryItem[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
.

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

### -IsProcessing
Indicates whether Azure AD is currently processing the service principal's risky state.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RiskDetail
.

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

### -RiskLastUpdatedDateTime
The date and time that the risk state was last updated.
The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2021 is 2021-01-01T00:00:00Z.
Supports $filter (eq).

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

### -RiskLevel
riskLevel

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

### -RiskState
riskState

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

### -ServicePrincipalType
Identifies whether the service principal represents an Application, a ManagedIdentity, or a legacy application (socialIdp).
This is set by Azure AD internally and is inherited from servicePrincipal.

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRiskyServicePrincipal

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRiskyServicePrincipal

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphRiskyServicePrincipal>: riskyServicePrincipal
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[AccountEnabled <Boolean?>]`: true if the service principal account is enabled; otherwise, false.
  - `[AppId <String>]`: The globally unique identifier for the associated application (its appId property), if any.
  - `[DisplayName <String>]`: The display name for the service principal.
  - `[History <IMicrosoftGraphRiskyServicePrincipalHistoryItem[]>]`: Represents the risk history of Azure AD service principals.
    - `[AccountEnabled <Boolean?>]`: true if the service principal account is enabled; otherwise, false.
    - `[AppId <String>]`: The globally unique identifier for the associated application (its appId property), if any.
    - `[DisplayName <String>]`: The display name for the service principal.
    - `[History <IMicrosoftGraphRiskyServicePrincipalHistoryItem[]>]`: Represents the risk history of Azure AD service principals.
    - `[IsProcessing <Boolean?>]`: Indicates whether Azure AD is currently processing the service principal's risky state.
    - `[RiskDetail <String>]`: 
    - `[RiskLastUpdatedDateTime <DateTime?>]`: The date and time that the risk state was last updated. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2021 is 2021-01-01T00:00:00Z. Supports $filter (eq).
    - `[RiskLevel <String>]`: riskLevel
    - `[RiskState <String>]`: riskState
    - `[ServicePrincipalType <String>]`: Identifies whether the service principal represents an Application, a ManagedIdentity, or a legacy application (socialIdp). This is set by Azure AD internally and is inherited from servicePrincipal.
    - `[Id <String>]`: 
    - `[Activity <IMicrosoftGraphRiskServicePrincipalActivity>]`: riskServicePrincipalActivity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Detail <String>]`: 
      - `[RiskEventTypes <String[]>]`: 
    - `[InitiatedBy <String>]`: The identifier of the actor of the operation.
    - `[ServicePrincipalId <String>]`: The identifier of the service principal.
  - `[IsProcessing <Boolean?>]`: Indicates whether Azure AD is currently processing the service principal's risky state.
  - `[RiskDetail <String>]`: 
  - `[RiskLastUpdatedDateTime <DateTime?>]`: The date and time that the risk state was last updated. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2021 is 2021-01-01T00:00:00Z. Supports $filter (eq).
  - `[RiskLevel <String>]`: riskLevel
  - `[RiskState <String>]`: riskState
  - `[ServicePrincipalType <String>]`: Identifies whether the service principal represents an Application, a ManagedIdentity, or a legacy application (socialIdp). This is set by Azure AD internally and is inherited from servicePrincipal.

HISTORY <IMicrosoftGraphRiskyServicePrincipalHistoryItem[]>: Represents the risk history of Azure AD service principals.
  - `[AccountEnabled <Boolean?>]`: true if the service principal account is enabled; otherwise, false.
  - `[AppId <String>]`: The globally unique identifier for the associated application (its appId property), if any.
  - `[DisplayName <String>]`: The display name for the service principal.
  - `[History <IMicrosoftGraphRiskyServicePrincipalHistoryItem[]>]`: Represents the risk history of Azure AD service principals.
  - `[IsProcessing <Boolean?>]`: Indicates whether Azure AD is currently processing the service principal's risky state.
  - `[RiskDetail <String>]`: 
  - `[RiskLastUpdatedDateTime <DateTime?>]`: The date and time that the risk state was last updated. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2021 is 2021-01-01T00:00:00Z. Supports $filter (eq).
  - `[RiskLevel <String>]`: riskLevel
  - `[RiskState <String>]`: riskState
  - `[ServicePrincipalType <String>]`: Identifies whether the service principal represents an Application, a ManagedIdentity, or a legacy application (socialIdp). This is set by Azure AD internally and is inherited from servicePrincipal.
  - `[Id <String>]`: 
  - `[Activity <IMicrosoftGraphRiskServicePrincipalActivity>]`: riskServicePrincipalActivity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Detail <String>]`: 
    - `[RiskEventTypes <String[]>]`: 
  - `[InitiatedBy <String>]`: The identifier of the actor of the operation.
  - `[ServicePrincipalId <String>]`: The identifier of the service principal.

## RELATED LINKS

