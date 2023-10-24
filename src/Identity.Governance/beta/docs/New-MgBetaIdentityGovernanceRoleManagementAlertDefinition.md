---
external help file:
Module Name: Microsoft.Graph.Beta.Identity.Governance
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.identity.governance/new-mgbetaidentitygovernancerolemanagementalertdefinition
schema: 2.0.0
---

# New-MgBetaIdentityGovernanceRoleManagementAlertDefinition

## SYNOPSIS
Create new navigation property to alertDefinitions for identityGovernance

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaIdentityGovernanceRoleManagementAlertDefinition [-AdditionalProperties <Hashtable>]
 [-Description <String>] [-DisplayName <String>] [-HowToPrevent <String>] [-Id <String>] [-IsConfigurable]
 [-IsRemediatable] [-MitigationSteps <String>] [-ScopeId <String>] [-ScopeType <String>]
 [-SecurityImpact <String>] [-SeverityLevel <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgBetaIdentityGovernanceRoleManagementAlertDefinition
 -BodyParameter <IMicrosoftGraphUnifiedRoleManagementAlertDefinition> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to alertDefinitions for identityGovernance

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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
unifiedRoleManagementAlertDefinition
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphUnifiedRoleManagementAlertDefinition
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Description
The description of the alert.

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

### -DisplayName
The friendly display name that renders in Privileged Identity Management (PIM) alerts in the Microsoft Entra admin center.

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

### -HowToPrevent
Long-form text that indicates the ways to prevent the alert from being triggered in your tenant.

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

### -IsConfigurable
true if the alert configuration can be customized in the tenant, and false otherwise.
For example, the number and percentage thresholds of the 'There are too many global administrators' alert can be configured by users, while the 'This organization doesn't have Azure AD Premium P2' can't be configured, because the criteria are restricted.

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

### -IsRemediatable
true if the alert can be remediated, and false otherwise.

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

### -MitigationSteps
The methods to mitigate the alert when it's triggered in the tenant.
For example, to mitigate the 'There are too many global administrators', you could remove redundant privileged role assignments.

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

### -ScopeId
The identifier of the scope where the alert is related.
/ is the only supported one for the tenant.
Supports $filter (eq, ne).

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

### -ScopeType
The type of scope where the alert is created.
DirectoryRole is the only currently supported scope type for Azure AD Roles.

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

### -SecurityImpact
Security impact of the alert.
For example, it could be information leaks or unauthorized access.

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

### -SeverityLevel
alertSeverity

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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphUnifiedRoleManagementAlertDefinition

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphUnifiedRoleManagementAlertDefinition

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphUnifiedRoleManagementAlertDefinition>`: unifiedRoleManagementAlertDefinition
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Description <String>]`: The description of the alert.
  - `[DisplayName <String>]`: The friendly display name that renders in Privileged Identity Management (PIM) alerts in the Microsoft Entra admin center.
  - `[HowToPrevent <String>]`: Long-form text that indicates the ways to prevent the alert from being triggered in your tenant.
  - `[IsConfigurable <Boolean?>]`: true if the alert configuration can be customized in the tenant, and false otherwise. For example, the number and percentage thresholds of the 'There are too many global administrators' alert can be configured by users, while the 'This organization doesn't have Azure AD Premium P2' can't be configured, because the criteria are restricted.
  - `[IsRemediatable <Boolean?>]`: true if the alert can be remediated, and false otherwise.
  - `[MitigationSteps <String>]`: The methods to mitigate the alert when it's triggered in the tenant. For example, to mitigate the 'There are too many global administrators', you could remove redundant privileged role assignments.
  - `[ScopeId <String>]`: The identifier of the scope where the alert is related. / is the only supported one for the tenant. Supports $filter (eq, ne).
  - `[ScopeType <String>]`: The type of scope where the alert is created. DirectoryRole is the only currently supported scope type for Azure AD Roles.
  - `[SecurityImpact <String>]`: Security impact of the alert. For example, it could be information leaks or unauthorized access.
  - `[SeverityLevel <String>]`: alertSeverity

## RELATED LINKS

