---
external help file:
Module Name: Microsoft.Graph.ManagedTenants
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.managedtenants/new-mgtenantrelationshipmanagedtenantalertrule
schema: 2.0.0
---

# New-MgTenantRelationshipManagedTenantAlertRule

## SYNOPSIS
Create new navigation property to managedTenantAlertRules for tenantRelationships

## SYNTAX

### CreateExpanded (Default)
```
New-MgTenantRelationshipManagedTenantAlertRule [-AdditionalProperties <Hashtable>]
 [-AlertDisplayName <String>] [-Alerts <IMicrosoftGraphManagedTenantsManagedTenantAlert[]>]
 [-AlertTtl <Int32>] [-CreatedByUserId <String>] [-CreatedDateTime <DateTime>] [-Description <String>]
 [-DisplayName <String>] [-Id <String>] [-LastActionByUserId <String>] [-LastActionDateTime <DateTime>]
 [-LastRunDateTime <DateTime>] [-NotificationFinalDestinations <String>]
 [-RuleDefinition <IMicrosoftGraphManagedTenantsManagedTenantAlertRuleDefinition>] [-Severity <String>]
 [-Targets <IMicrosoftGraphManagedTenantsNotificationTarget[]>]
 [-TenantIds <IMicrosoftGraphManagedTenantsTenantInfo[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgTenantRelationshipManagedTenantAlertRule
 -BodyParameter <IMicrosoftGraphManagedTenantsManagedTenantAlertRule> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to managedTenantAlertRules for tenantRelationships

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

### -AlertDisplayName
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

### -Alerts
.
To construct, please use Get-Help -Online and see NOTES section for ALERTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedTenantsManagedTenantAlert[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AlertTtl
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

### -BodyParameter
managedTenantAlertRule
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedTenantsManagedTenantAlertRule
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedByUserId
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

### -CreatedDateTime
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

### -Description
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

### -DisplayName
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

### -LastActionByUserId
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

### -LastActionDateTime
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

### -LastRunDateTime
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

### -NotificationFinalDestinations
notificationDestination

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

### -RuleDefinition
managedTenantAlertRuleDefinition
To construct, please use Get-Help -Online and see NOTES section for RULEDEFINITION properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedTenantsManagedTenantAlertRuleDefinition
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Severity
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

### -Targets
.
To construct, please use Get-Help -Online and see NOTES section for TARGETS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedTenantsNotificationTarget[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TenantIds
.
To construct, please use Get-Help -Online and see NOTES section for TENANTIDS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedTenantsTenantInfo[]
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedTenantsManagedTenantAlertRule

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedTenantsManagedTenantAlertRule

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ALERTS <IMicrosoftGraphManagedTenantsManagedTenantAlert[]>: .
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AlertData <IMicrosoftGraphManagedTenantsAlertData>]`: alertData
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: 
  - `[AlertDataReferenceStrings <IMicrosoftGraphManagedTenantsAlertDataReferenceString[]>]`: 
    - `[DisplayName <String>]`: 
  - `[AlertLogs <IMicrosoftGraphManagedTenantsManagedTenantAlertLog[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Alert <IMicrosoftGraphManagedTenantsManagedTenantAlert>]`: managedTenantAlert
    - `[Content <IMicrosoftGraphManagedTenantsAlertLogContent>]`: alertLogContent
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: 
    - `[CreatedByUserId <String>]`: 
    - `[CreatedDateTime <DateTime?>]`: 
    - `[LastActionByUserId <String>]`: 
    - `[LastActionDateTime <DateTime?>]`: 
  - `[AlertRule <IMicrosoftGraphManagedTenantsManagedTenantAlertRule>]`: managedTenantAlertRule
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[AlertDisplayName <String>]`: 
    - `[AlertTtl <Int32?>]`: 
    - `[Alerts <IMicrosoftGraphManagedTenantsManagedTenantAlert[]>]`: 
    - `[CreatedByUserId <String>]`: 
    - `[CreatedDateTime <DateTime?>]`: 
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[LastActionByUserId <String>]`: 
    - `[LastActionDateTime <DateTime?>]`: 
    - `[LastRunDateTime <DateTime?>]`: 
    - `[NotificationFinalDestinations <String>]`: notificationDestination
    - `[RuleDefinition <IMicrosoftGraphManagedTenantsManagedTenantAlertRuleDefinition>]`: managedTenantAlertRuleDefinition
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[AlertRules <IMicrosoftGraphManagedTenantsManagedTenantAlertRule[]>]`: 
      - `[CreatedByUserId <String>]`: 
      - `[CreatedDateTime <DateTime?>]`: 
      - `[DefinitionTemplate <IMicrosoftGraphManagedTenantsAlertRuleDefinitionTemplate>]`: alertRuleDefinitionTemplate
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DefaultSeverity <String>]`: alertSeverity
      - `[DisplayName <String>]`: 
      - `[LastActionByUserId <String>]`: 
      - `[LastActionDateTime <DateTime?>]`: 
    - `[Severity <String>]`: alertSeverity
    - `[Targets <IMicrosoftGraphManagedTenantsNotificationTarget[]>]`: 
      - `[DisplayName <String>]`: 
    - `[TenantIds <IMicrosoftGraphManagedTenantsTenantInfo[]>]`: 
      - `[TenantId <String>]`: The Azure Active Directory tenant identifier for the managed tenant. Optional.
  - `[AlertRuleDisplayName <String>]`: 
  - `[ApiNotifications <IMicrosoftGraphManagedTenantsManagedTenantApiNotification[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Alert <IMicrosoftGraphManagedTenantsManagedTenantAlert>]`: managedTenantAlert
    - `[CreatedByUserId <String>]`: 
    - `[CreatedDateTime <DateTime?>]`: 
    - `[IsAcknowledged <Boolean?>]`: 
    - `[LastActionByUserId <String>]`: 
    - `[LastActionDateTime <DateTime?>]`: 
    - `[Message <String>]`: 
    - `[Title <String>]`: 
    - `[UserId <String>]`: 
  - `[AssignedToUserId <String>]`: 
  - `[CorrelationCount <Int32?>]`: 
  - `[CorrelationId <String>]`: 
  - `[CreatedByUserId <String>]`: 
  - `[CreatedDateTime <DateTime?>]`: 
  - `[EmailNotifications <IMicrosoftGraphManagedTenantsManagedTenantEmailNotification[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Alert <IMicrosoftGraphManagedTenantsManagedTenantAlert>]`: managedTenantAlert
    - `[CreatedByUserId <String>]`: 
    - `[CreatedDateTime <DateTime?>]`: 
    - `[EmailAddresses <IMicrosoftGraphManagedTenantsEmail[]>]`: 
      - `[EmailAddress <String>]`: 
    - `[EmailBody <String>]`: 
    - `[LastActionByUserId <String>]`: 
    - `[LastActionDateTime <DateTime?>]`: 
    - `[Subject <String>]`: 
  - `[LastActionByUserId <String>]`: 
  - `[LastActionDateTime <DateTime?>]`: 
  - `[Message <String>]`: 
  - `[Severity <String>]`: alertSeverity
  - `[Status <String>]`: alertStatus
  - `[TenantId <String>]`: 
  - `[Title <String>]`: 

BODYPARAMETER <IMicrosoftGraphManagedTenantsManagedTenantAlertRule>: managedTenantAlertRule
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AlertDisplayName <String>]`: 
  - `[AlertTtl <Int32?>]`: 
  - `[Alerts <IMicrosoftGraphManagedTenantsManagedTenantAlert[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[AlertData <IMicrosoftGraphManagedTenantsAlertData>]`: alertData
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: 
    - `[AlertDataReferenceStrings <IMicrosoftGraphManagedTenantsAlertDataReferenceString[]>]`: 
      - `[DisplayName <String>]`: 
    - `[AlertLogs <IMicrosoftGraphManagedTenantsManagedTenantAlertLog[]>]`: 
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Alert <IMicrosoftGraphManagedTenantsManagedTenantAlert>]`: managedTenantAlert
      - `[Content <IMicrosoftGraphManagedTenantsAlertLogContent>]`: alertLogContent
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: 
      - `[CreatedByUserId <String>]`: 
      - `[CreatedDateTime <DateTime?>]`: 
      - `[LastActionByUserId <String>]`: 
      - `[LastActionDateTime <DateTime?>]`: 
    - `[AlertRule <IMicrosoftGraphManagedTenantsManagedTenantAlertRule>]`: managedTenantAlertRule
    - `[AlertRuleDisplayName <String>]`: 
    - `[ApiNotifications <IMicrosoftGraphManagedTenantsManagedTenantApiNotification[]>]`: 
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Alert <IMicrosoftGraphManagedTenantsManagedTenantAlert>]`: managedTenantAlert
      - `[CreatedByUserId <String>]`: 
      - `[CreatedDateTime <DateTime?>]`: 
      - `[IsAcknowledged <Boolean?>]`: 
      - `[LastActionByUserId <String>]`: 
      - `[LastActionDateTime <DateTime?>]`: 
      - `[Message <String>]`: 
      - `[Title <String>]`: 
      - `[UserId <String>]`: 
    - `[AssignedToUserId <String>]`: 
    - `[CorrelationCount <Int32?>]`: 
    - `[CorrelationId <String>]`: 
    - `[CreatedByUserId <String>]`: 
    - `[CreatedDateTime <DateTime?>]`: 
    - `[EmailNotifications <IMicrosoftGraphManagedTenantsManagedTenantEmailNotification[]>]`: 
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Alert <IMicrosoftGraphManagedTenantsManagedTenantAlert>]`: managedTenantAlert
      - `[CreatedByUserId <String>]`: 
      - `[CreatedDateTime <DateTime?>]`: 
      - `[EmailAddresses <IMicrosoftGraphManagedTenantsEmail[]>]`: 
        - `[EmailAddress <String>]`: 
      - `[EmailBody <String>]`: 
      - `[LastActionByUserId <String>]`: 
      - `[LastActionDateTime <DateTime?>]`: 
      - `[Subject <String>]`: 
    - `[LastActionByUserId <String>]`: 
    - `[LastActionDateTime <DateTime?>]`: 
    - `[Message <String>]`: 
    - `[Severity <String>]`: alertSeverity
    - `[Status <String>]`: alertStatus
    - `[TenantId <String>]`: 
    - `[Title <String>]`: 
  - `[CreatedByUserId <String>]`: 
  - `[CreatedDateTime <DateTime?>]`: 
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: 
  - `[LastActionByUserId <String>]`: 
  - `[LastActionDateTime <DateTime?>]`: 
  - `[LastRunDateTime <DateTime?>]`: 
  - `[NotificationFinalDestinations <String>]`: notificationDestination
  - `[RuleDefinition <IMicrosoftGraphManagedTenantsManagedTenantAlertRuleDefinition>]`: managedTenantAlertRuleDefinition
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[AlertRules <IMicrosoftGraphManagedTenantsManagedTenantAlertRule[]>]`: 
    - `[CreatedByUserId <String>]`: 
    - `[CreatedDateTime <DateTime?>]`: 
    - `[DefinitionTemplate <IMicrosoftGraphManagedTenantsAlertRuleDefinitionTemplate>]`: alertRuleDefinitionTemplate
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DefaultSeverity <String>]`: alertSeverity
    - `[DisplayName <String>]`: 
    - `[LastActionByUserId <String>]`: 
    - `[LastActionDateTime <DateTime?>]`: 
  - `[Severity <String>]`: alertSeverity
  - `[Targets <IMicrosoftGraphManagedTenantsNotificationTarget[]>]`: 
    - `[DisplayName <String>]`: 
  - `[TenantIds <IMicrosoftGraphManagedTenantsTenantInfo[]>]`: 
    - `[TenantId <String>]`: The Azure Active Directory tenant identifier for the managed tenant. Optional.

RULEDEFINITION <IMicrosoftGraphManagedTenantsManagedTenantAlertRuleDefinition>: managedTenantAlertRuleDefinition
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AlertRules <IMicrosoftGraphManagedTenantsManagedTenantAlertRule[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[AlertDisplayName <String>]`: 
    - `[AlertTtl <Int32?>]`: 
    - `[Alerts <IMicrosoftGraphManagedTenantsManagedTenantAlert[]>]`: 
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[AlertData <IMicrosoftGraphManagedTenantsAlertData>]`: alertData
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: 
      - `[AlertDataReferenceStrings <IMicrosoftGraphManagedTenantsAlertDataReferenceString[]>]`: 
        - `[DisplayName <String>]`: 
      - `[AlertLogs <IMicrosoftGraphManagedTenantsManagedTenantAlertLog[]>]`: 
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
        - `[Alert <IMicrosoftGraphManagedTenantsManagedTenantAlert>]`: managedTenantAlert
        - `[Content <IMicrosoftGraphManagedTenantsAlertLogContent>]`: alertLogContent
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[DisplayName <String>]`: 
        - `[CreatedByUserId <String>]`: 
        - `[CreatedDateTime <DateTime?>]`: 
        - `[LastActionByUserId <String>]`: 
        - `[LastActionDateTime <DateTime?>]`: 
      - `[AlertRule <IMicrosoftGraphManagedTenantsManagedTenantAlertRule>]`: managedTenantAlertRule
      - `[AlertRuleDisplayName <String>]`: 
      - `[ApiNotifications <IMicrosoftGraphManagedTenantsManagedTenantApiNotification[]>]`: 
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
        - `[Alert <IMicrosoftGraphManagedTenantsManagedTenantAlert>]`: managedTenantAlert
        - `[CreatedByUserId <String>]`: 
        - `[CreatedDateTime <DateTime?>]`: 
        - `[IsAcknowledged <Boolean?>]`: 
        - `[LastActionByUserId <String>]`: 
        - `[LastActionDateTime <DateTime?>]`: 
        - `[Message <String>]`: 
        - `[Title <String>]`: 
        - `[UserId <String>]`: 
      - `[AssignedToUserId <String>]`: 
      - `[CorrelationCount <Int32?>]`: 
      - `[CorrelationId <String>]`: 
      - `[CreatedByUserId <String>]`: 
      - `[CreatedDateTime <DateTime?>]`: 
      - `[EmailNotifications <IMicrosoftGraphManagedTenantsManagedTenantEmailNotification[]>]`: 
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
        - `[Alert <IMicrosoftGraphManagedTenantsManagedTenantAlert>]`: managedTenantAlert
        - `[CreatedByUserId <String>]`: 
        - `[CreatedDateTime <DateTime?>]`: 
        - `[EmailAddresses <IMicrosoftGraphManagedTenantsEmail[]>]`: 
          - `[EmailAddress <String>]`: 
        - `[EmailBody <String>]`: 
        - `[LastActionByUserId <String>]`: 
        - `[LastActionDateTime <DateTime?>]`: 
        - `[Subject <String>]`: 
      - `[LastActionByUserId <String>]`: 
      - `[LastActionDateTime <DateTime?>]`: 
      - `[Message <String>]`: 
      - `[Severity <String>]`: alertSeverity
      - `[Status <String>]`: alertStatus
      - `[TenantId <String>]`: 
      - `[Title <String>]`: 
    - `[CreatedByUserId <String>]`: 
    - `[CreatedDateTime <DateTime?>]`: 
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[LastActionByUserId <String>]`: 
    - `[LastActionDateTime <DateTime?>]`: 
    - `[LastRunDateTime <DateTime?>]`: 
    - `[NotificationFinalDestinations <String>]`: notificationDestination
    - `[RuleDefinition <IMicrosoftGraphManagedTenantsManagedTenantAlertRuleDefinition>]`: managedTenantAlertRuleDefinition
    - `[Severity <String>]`: alertSeverity
    - `[Targets <IMicrosoftGraphManagedTenantsNotificationTarget[]>]`: 
      - `[DisplayName <String>]`: 
    - `[TenantIds <IMicrosoftGraphManagedTenantsTenantInfo[]>]`: 
      - `[TenantId <String>]`: The Azure Active Directory tenant identifier for the managed tenant. Optional.
  - `[CreatedByUserId <String>]`: 
  - `[CreatedDateTime <DateTime?>]`: 
  - `[DefinitionTemplate <IMicrosoftGraphManagedTenantsAlertRuleDefinitionTemplate>]`: alertRuleDefinitionTemplate
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DefaultSeverity <String>]`: alertSeverity
  - `[DisplayName <String>]`: 
  - `[LastActionByUserId <String>]`: 
  - `[LastActionDateTime <DateTime?>]`: 

TARGETS <IMicrosoftGraphManagedTenantsNotificationTarget[]>: .
  - `[DisplayName <String>]`: 

TENANTIDS <IMicrosoftGraphManagedTenantsTenantInfo[]>: .
  - `[TenantId <String>]`: The Azure Active Directory tenant identifier for the managed tenant. Optional.

## RELATED LINKS
