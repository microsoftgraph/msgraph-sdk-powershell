---
external help file:
Module Name: Microsoft.Graph.Beta.ManagedTenants
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.managedtenants/new-mgbetatenantrelationshipmanagedtenantapinotification
schema: 2.0.0
---

# New-MgBetaTenantRelationshipManagedTenantApiNotification

## SYNOPSIS
Create new navigation property to managedTenantApiNotifications for tenantRelationships

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaTenantRelationshipManagedTenantApiNotification [-AdditionalProperties <Hashtable>]
 [-Alert <IMicrosoftGraphManagedTenantsManagedTenantAlert>] [-CreatedByUserId <String>]
 [-CreatedDateTime <DateTime>] [-Id <String>] [-IsAcknowledged] [-LastActionByUserId <String>]
 [-LastActionDateTime <DateTime>] [-Message <String>] [-ResponseHeadersVariable <String>] [-Title <String>]
 [-UserId <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgBetaTenantRelationshipManagedTenantApiNotification
 -BodyParameter <IMicrosoftGraphManagedTenantsManagedTenantApiNotification>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to managedTenantApiNotifications for tenantRelationships

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

### -Alert
managedTenantAlert
To construct, see NOTES section for ALERT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedTenantsManagedTenantAlert
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
managedTenantApiNotification
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedTenantsManagedTenantApiNotification
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

### -IsAcknowledged
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

### -Message
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

### -Title
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

### -UserId
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedTenantsManagedTenantApiNotification

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedTenantsManagedTenantApiNotification

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`ALERT <IMicrosoftGraphManagedTenantsManagedTenantAlert>`: managedTenantAlert
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
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
      - `[TenantId <String>]`: The Microsoft Entra tenant identifier for the managed tenant. Optional.
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

`BODYPARAMETER <IMicrosoftGraphManagedTenantsManagedTenantApiNotification>`: managedTenantApiNotification
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Alert <IMicrosoftGraphManagedTenantsManagedTenantAlert>]`: managedTenantAlert
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
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
        - `[TenantId <String>]`: The Microsoft Entra tenant identifier for the managed tenant. Optional.
    - `[AlertRuleDisplayName <String>]`: 
    - `[ApiNotifications <IMicrosoftGraphManagedTenantsManagedTenantApiNotification[]>]`: 
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
  - `[IsAcknowledged <Boolean?>]`: 
  - `[LastActionByUserId <String>]`: 
  - `[LastActionDateTime <DateTime?>]`: 
  - `[Message <String>]`: 
  - `[Title <String>]`: 
  - `[UserId <String>]`: 

## RELATED LINKS

