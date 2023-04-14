---
external help file:
Module Name: Microsoft.Graph.Identity.Governance
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/new-mgidentitygovernancerolemanagementalert
schema: 2.0.0
---

# New-MgIdentityGovernanceRoleManagementAlert

## SYNOPSIS
Create new navigation property to alerts for identityGovernance

## SYNTAX

### CreateExpanded (Default)
```
New-MgIdentityGovernanceRoleManagementAlert [-AdditionalProperties <Hashtable>]
 [-AlertConfiguration <IMicrosoftGraphUnifiedRoleManagementAlertConfiguration>]
 [-AlertDefinition <IMicrosoftGraphUnifiedRoleManagementAlertDefinition>] [-AlertDefinitionId <String>]
 [-AlertIncidents <IMicrosoftGraphUnifiedRoleManagementAlertIncident[]>] [-Id <String>]
 [-IncidentCount <Int32>] [-IsActive] [-LastModifiedDateTime <DateTime>] [-LastScannedDateTime <DateTime>]
 [-ScopeId <String>] [-ScopeType <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgIdentityGovernanceRoleManagementAlert -BodyParameter <IMicrosoftGraphUnifiedRoleManagementAlert>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to alerts for identityGovernance

## EXAMPLES

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

### -AlertConfiguration
unifiedRoleManagementAlertConfiguration
To construct, please use Get-Help -Online and see NOTES section for ALERTCONFIGURATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUnifiedRoleManagementAlertConfiguration
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AlertDefinition
unifiedRoleManagementAlertDefinition
To construct, please use Get-Help -Online and see NOTES section for ALERTDEFINITION properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUnifiedRoleManagementAlertDefinition
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AlertDefinitionId
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

### -AlertIncidents
.
To construct, please use Get-Help -Online and see NOTES section for ALERTINCIDENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUnifiedRoleManagementAlertIncident[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
unifiedRoleManagementAlert
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUnifiedRoleManagementAlert
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Id
The unique idenfier for an entity.
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

### -IncidentCount
.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsActive
.

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

### -LastModifiedDateTime
.

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

### -LastScannedDateTime
.

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

### -ScopeId
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

### -ScopeType
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUnifiedRoleManagementAlert

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUnifiedRoleManagementAlert

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ALERTCONFIGURATION <IMicrosoftGraphUnifiedRoleManagementAlertConfiguration>: unifiedRoleManagementAlertConfiguration
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[AlertDefinition <IMicrosoftGraphUnifiedRoleManagementAlertDefinition>]`: unifiedRoleManagementAlertDefinition
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[HowToPrevent <String>]`: 
    - `[IsConfigurable <Boolean?>]`: 
    - `[IsRemediatable <Boolean?>]`: 
    - `[MitigationSteps <String>]`: 
    - `[ScopeId <String>]`: 
    - `[ScopeType <String>]`: 
    - `[SecurityImpact <String>]`: 
    - `[SeverityLevel <String>]`: alertSeverity
  - `[AlertDefinitionId <String>]`: 
  - `[IsEnabled <Boolean?>]`: 
  - `[ScopeId <String>]`: 
  - `[ScopeType <String>]`: 

ALERTDEFINITION <IMicrosoftGraphUnifiedRoleManagementAlertDefinition>: unifiedRoleManagementAlertDefinition
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: 
  - `[HowToPrevent <String>]`: 
  - `[IsConfigurable <Boolean?>]`: 
  - `[IsRemediatable <Boolean?>]`: 
  - `[MitigationSteps <String>]`: 
  - `[ScopeId <String>]`: 
  - `[ScopeType <String>]`: 
  - `[SecurityImpact <String>]`: 
  - `[SeverityLevel <String>]`: alertSeverity

ALERTINCIDENTS <IMicrosoftGraphUnifiedRoleManagementAlertIncident[]>: .
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.

BODYPARAMETER <IMicrosoftGraphUnifiedRoleManagementAlert>: unifiedRoleManagementAlert
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[AlertConfiguration <IMicrosoftGraphUnifiedRoleManagementAlertConfiguration>]`: unifiedRoleManagementAlertConfiguration
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[AlertDefinition <IMicrosoftGraphUnifiedRoleManagementAlertDefinition>]`: unifiedRoleManagementAlertDefinition
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[Description <String>]`: 
      - `[DisplayName <String>]`: 
      - `[HowToPrevent <String>]`: 
      - `[IsConfigurable <Boolean?>]`: 
      - `[IsRemediatable <Boolean?>]`: 
      - `[MitigationSteps <String>]`: 
      - `[ScopeId <String>]`: 
      - `[ScopeType <String>]`: 
      - `[SecurityImpact <String>]`: 
      - `[SeverityLevel <String>]`: alertSeverity
    - `[AlertDefinitionId <String>]`: 
    - `[IsEnabled <Boolean?>]`: 
    - `[ScopeId <String>]`: 
    - `[ScopeType <String>]`: 
  - `[AlertDefinition <IMicrosoftGraphUnifiedRoleManagementAlertDefinition>]`: unifiedRoleManagementAlertDefinition
  - `[AlertDefinitionId <String>]`: 
  - `[AlertIncidents <IMicrosoftGraphUnifiedRoleManagementAlertIncident[]>]`: 
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[IncidentCount <Int32?>]`: 
  - `[IsActive <Boolean?>]`: 
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[LastScannedDateTime <DateTime?>]`: 
  - `[ScopeId <String>]`: 
  - `[ScopeType <String>]`: 

## RELATED LINKS

