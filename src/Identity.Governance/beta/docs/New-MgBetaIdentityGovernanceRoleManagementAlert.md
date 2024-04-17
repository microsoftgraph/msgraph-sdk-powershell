---
external help file:
Module Name: Microsoft.Graph.Beta.Identity.Governance
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.identity.governance/new-mgbetaidentitygovernancerolemanagementalert
schema: 2.0.0
---

# New-MgBetaIdentityGovernanceRoleManagementAlert

## SYNOPSIS
Create new navigation property to alerts for identityGovernance

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaIdentityGovernanceRoleManagementAlert [-AdditionalProperties <Hashtable>]
 [-AlertConfiguration <IMicrosoftGraphUnifiedRoleManagementAlertConfiguration>]
 [-AlertDefinition <IMicrosoftGraphUnifiedRoleManagementAlertDefinition>] [-AlertDefinitionId <String>]
 [-AlertIncidents <IMicrosoftGraphUnifiedRoleManagementAlertIncident[]>] [-Id <String>]
 [-IncidentCount <Int32>] [-IsActive] [-LastModifiedDateTime <DateTime>] [-LastScannedDateTime <DateTime>]
 [-ResponseHeadersVariable <String>] [-ScopeId <String>] [-ScopeType <String>] [-Headers <IDictionary>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgBetaIdentityGovernanceRoleManagementAlert -BodyParameter <IMicrosoftGraphUnifiedRoleManagementAlert>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to alerts for identityGovernance

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

### -AlertConfiguration
unifiedRoleManagementAlertConfiguration
To construct, see NOTES section for ALERTCONFIGURATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphUnifiedRoleManagementAlertConfiguration
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
To construct, see NOTES section for ALERTDEFINITION properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphUnifiedRoleManagementAlertDefinition
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AlertDefinitionId
The identifier of an alert definition.
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

### -AlertIncidents
Represents the incidents of this type of alert that have been triggered in Privileged Identity Management (PIM) for Microsoft Entra roles in the tenant.
Supports $expand.
To construct, see NOTES section for ALERTINCIDENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphUnifiedRoleManagementAlertIncident[]
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
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphUnifiedRoleManagementAlert
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IncidentCount
The number of incidents triggered in the tenant and relating to the alert.
Can only be a positive integer.

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
false by default.
true if the alert is active.

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
The date time when the alert configuration was updated or new incidents generated.

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
The date time when the tenant was last scanned for incidents that trigger this alert.

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
DirectoryRole is the only currently supported scope type for Microsoft Entra roles.

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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphUnifiedRoleManagementAlert

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphUnifiedRoleManagementAlert

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`ALERTCONFIGURATION <IMicrosoftGraphUnifiedRoleManagementAlertConfiguration>`: unifiedRoleManagementAlertConfiguration
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AlertDefinition <IMicrosoftGraphUnifiedRoleManagementAlertDefinition>]`: unifiedRoleManagementAlertDefinition
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Description <String>]`: The description of the alert.
    - `[DisplayName <String>]`: The friendly display name that renders in Privileged Identity Management (PIM) alerts in the Microsoft Entra admin center.
    - `[HowToPrevent <String>]`: Long-form text that indicates the ways to prevent the alert from being triggered in your tenant.
    - `[IsConfigurable <Boolean?>]`: true if the alert configuration can be customized in the tenant, and false otherwise. For example, the number and percentage thresholds of the 'There are too many global administrators' alert can be configured by users, while the 'This organization doesn't have Microsoft Entra ID P2' can't be configured, because the criteria are restricted.
    - `[IsRemediatable <Boolean?>]`: true if the alert can be remediated, and false otherwise.
    - `[MitigationSteps <String>]`: The methods to mitigate the alert when it's triggered in the tenant. For example, to mitigate the 'There are too many global administrators', you could remove redundant privileged role assignments.
    - `[ScopeId <String>]`: The identifier of the scope where the alert is related. / is the only supported one for the tenant. Supports $filter (eq, ne).
    - `[ScopeType <String>]`: The type of scope where the alert is created. DirectoryRole is the only currently supported scope type for Microsoft Entra roles.
    - `[SecurityImpact <String>]`: Security impact of the alert. For example, it could be information leaks or unauthorized access.
    - `[SeverityLevel <String>]`: alertSeverity
  - `[AlertDefinitionId <String>]`: The identifier of an alert definition. Supports $filter (eq, ne).
  - `[IsEnabled <Boolean?>]`: true if the alert is enabled. Setting it to false disables PIM scanning the tenant to identify instances that trigger the alert.
  - `[ScopeId <String>]`: The identifier of the scope to which the alert is related. Only / is supported to represent the tenant scope. Supports $filter (eq, ne).
  - `[ScopeType <String>]`: The type of scope where the alert is created. DirectoryRole is the only currently supported scope type for Microsoft Entra roles.

`ALERTDEFINITION <IMicrosoftGraphUnifiedRoleManagementAlertDefinition>`: unifiedRoleManagementAlertDefinition
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Description <String>]`: The description of the alert.
  - `[DisplayName <String>]`: The friendly display name that renders in Privileged Identity Management (PIM) alerts in the Microsoft Entra admin center.
  - `[HowToPrevent <String>]`: Long-form text that indicates the ways to prevent the alert from being triggered in your tenant.
  - `[IsConfigurable <Boolean?>]`: true if the alert configuration can be customized in the tenant, and false otherwise. For example, the number and percentage thresholds of the 'There are too many global administrators' alert can be configured by users, while the 'This organization doesn't have Microsoft Entra ID P2' can't be configured, because the criteria are restricted.
  - `[IsRemediatable <Boolean?>]`: true if the alert can be remediated, and false otherwise.
  - `[MitigationSteps <String>]`: The methods to mitigate the alert when it's triggered in the tenant. For example, to mitigate the 'There are too many global administrators', you could remove redundant privileged role assignments.
  - `[ScopeId <String>]`: The identifier of the scope where the alert is related. / is the only supported one for the tenant. Supports $filter (eq, ne).
  - `[ScopeType <String>]`: The type of scope where the alert is created. DirectoryRole is the only currently supported scope type for Microsoft Entra roles.
  - `[SecurityImpact <String>]`: Security impact of the alert. For example, it could be information leaks or unauthorized access.
  - `[SeverityLevel <String>]`: alertSeverity

`ALERTINCIDENTS <IMicrosoftGraphUnifiedRoleManagementAlertIncident[]>`: Represents the incidents of this type of alert that have been triggered in Privileged Identity Management (PIM) for Microsoft Entra roles in the tenant. Supports $expand.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.

`BODYPARAMETER <IMicrosoftGraphUnifiedRoleManagementAlert>`: unifiedRoleManagementAlert
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AlertConfiguration <IMicrosoftGraphUnifiedRoleManagementAlertConfiguration>]`: unifiedRoleManagementAlertConfiguration
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[AlertDefinition <IMicrosoftGraphUnifiedRoleManagementAlertDefinition>]`: unifiedRoleManagementAlertDefinition
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Description <String>]`: The description of the alert.
      - `[DisplayName <String>]`: The friendly display name that renders in Privileged Identity Management (PIM) alerts in the Microsoft Entra admin center.
      - `[HowToPrevent <String>]`: Long-form text that indicates the ways to prevent the alert from being triggered in your tenant.
      - `[IsConfigurable <Boolean?>]`: true if the alert configuration can be customized in the tenant, and false otherwise. For example, the number and percentage thresholds of the 'There are too many global administrators' alert can be configured by users, while the 'This organization doesn't have Microsoft Entra ID P2' can't be configured, because the criteria are restricted.
      - `[IsRemediatable <Boolean?>]`: true if the alert can be remediated, and false otherwise.
      - `[MitigationSteps <String>]`: The methods to mitigate the alert when it's triggered in the tenant. For example, to mitigate the 'There are too many global administrators', you could remove redundant privileged role assignments.
      - `[ScopeId <String>]`: The identifier of the scope where the alert is related. / is the only supported one for the tenant. Supports $filter (eq, ne).
      - `[ScopeType <String>]`: The type of scope where the alert is created. DirectoryRole is the only currently supported scope type for Microsoft Entra roles.
      - `[SecurityImpact <String>]`: Security impact of the alert. For example, it could be information leaks or unauthorized access.
      - `[SeverityLevel <String>]`: alertSeverity
    - `[AlertDefinitionId <String>]`: The identifier of an alert definition. Supports $filter (eq, ne).
    - `[IsEnabled <Boolean?>]`: true if the alert is enabled. Setting it to false disables PIM scanning the tenant to identify instances that trigger the alert.
    - `[ScopeId <String>]`: The identifier of the scope to which the alert is related. Only / is supported to represent the tenant scope. Supports $filter (eq, ne).
    - `[ScopeType <String>]`: The type of scope where the alert is created. DirectoryRole is the only currently supported scope type for Microsoft Entra roles.
  - `[AlertDefinition <IMicrosoftGraphUnifiedRoleManagementAlertDefinition>]`: unifiedRoleManagementAlertDefinition
  - `[AlertDefinitionId <String>]`: The identifier of an alert definition. Supports $filter (eq, ne).
  - `[AlertIncidents <IMicrosoftGraphUnifiedRoleManagementAlertIncident[]>]`: Represents the incidents of this type of alert that have been triggered in Privileged Identity Management (PIM) for Microsoft Entra roles in the tenant. Supports $expand.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[IncidentCount <Int32?>]`: The number of incidents triggered in the tenant and relating to the alert. Can only be a positive integer.
  - `[IsActive <Boolean?>]`: false by default. true if the alert is active.
  - `[LastModifiedDateTime <DateTime?>]`: The date time when the alert configuration was updated or new incidents generated.
  - `[LastScannedDateTime <DateTime?>]`: The date time when the tenant was last scanned for incidents that trigger this alert.
  - `[ScopeId <String>]`: The identifier of the scope where the alert is related. / is the only supported one for the tenant. Supports $filter (eq, ne).
  - `[ScopeType <String>]`: The type of scope where the alert is created. DirectoryRole is the only currently supported scope type for Microsoft Entra roles.

## RELATED LINKS

