---
external help file:
Module Name: Microsoft.Graph.Beta.ManagedTenants
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.managedtenants/update-mgbetatenantrelationshipmanagedtenantalert
schema: 2.0.0
---

# Update-MgBetaTenantRelationshipManagedTenantAlert

## SYNOPSIS
Update the navigation property managedTenantAlerts in tenantRelationships

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaTenantRelationshipManagedTenantAlert -ManagedTenantAlertId <String>
 [-AdditionalProperties <Hashtable>] [-AlertData <IMicrosoftGraphManagedTenantsAlertData>]
 [-AlertDataReferenceStrings <IMicrosoftGraphManagedTenantsAlertDataReferenceString[]>]
 [-AlertLogs <IMicrosoftGraphManagedTenantsManagedTenantAlertLog[]>]
 [-AlertRule <IMicrosoftGraphManagedTenantsManagedTenantAlertRule>] [-AlertRuleDisplayName <String>]
 [-ApiNotifications <IMicrosoftGraphManagedTenantsManagedTenantApiNotification[]>]
 [-AssignedToUserId <String>] [-CorrelationCount <Int32>] [-CorrelationId <String>]
 [-CreatedByUserId <String>] [-CreatedDateTime <DateTime>]
 [-EmailNotifications <IMicrosoftGraphManagedTenantsManagedTenantEmailNotification[]>] [-Id <String>]
 [-LastActionByUserId <String>] [-LastActionDateTime <DateTime>] [-Message <String>] [-Severity <String>]
 [-Status <String>] [-TenantId <String>] [-Title <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaTenantRelationshipManagedTenantAlert -ManagedTenantAlertId <String>
 -BodyParameter <IMicrosoftGraphManagedTenantsManagedTenantAlert> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBetaTenantRelationshipManagedTenantAlert -InputObject <IManagedTenantsIdentity>
 -BodyParameter <IMicrosoftGraphManagedTenantsManagedTenantAlert> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBetaTenantRelationshipManagedTenantAlert -InputObject <IManagedTenantsIdentity>
 [-AdditionalProperties <Hashtable>] [-AlertData <IMicrosoftGraphManagedTenantsAlertData>]
 [-AlertDataReferenceStrings <IMicrosoftGraphManagedTenantsAlertDataReferenceString[]>]
 [-AlertLogs <IMicrosoftGraphManagedTenantsManagedTenantAlertLog[]>]
 [-AlertRule <IMicrosoftGraphManagedTenantsManagedTenantAlertRule>] [-AlertRuleDisplayName <String>]
 [-ApiNotifications <IMicrosoftGraphManagedTenantsManagedTenantApiNotification[]>]
 [-AssignedToUserId <String>] [-CorrelationCount <Int32>] [-CorrelationId <String>]
 [-CreatedByUserId <String>] [-CreatedDateTime <DateTime>]
 [-EmailNotifications <IMicrosoftGraphManagedTenantsManagedTenantEmailNotification[]>] [-Id <String>]
 [-LastActionByUserId <String>] [-LastActionDateTime <DateTime>] [-Message <String>] [-Severity <String>]
 [-Status <String>] [-TenantId <String>] [-Title <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property managedTenantAlerts in tenantRelationships

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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AlertData
alertData
To construct, see NOTES section for ALERTDATA properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedTenantsAlertData
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AlertDataReferenceStrings
.
To construct, see NOTES section for ALERTDATAREFERENCESTRINGS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedTenantsAlertDataReferenceString[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AlertLogs
.
To construct, see NOTES section for ALERTLOGS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedTenantsManagedTenantAlertLog[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AlertRule
managedTenantAlertRule
To construct, see NOTES section for ALERTRULE properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedTenantsManagedTenantAlertRule
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AlertRuleDisplayName
.

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

### -ApiNotifications
.
To construct, see NOTES section for APINOTIFICATIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedTenantsManagedTenantApiNotification[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AssignedToUserId
.

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

### -BodyParameter
managedTenantAlert
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedTenantsManagedTenantAlert
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CorrelationCount
.

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CorrelationId
.

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

### -CreatedByUserId
.

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

### -CreatedDateTime
.

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

### -EmailNotifications
.
To construct, see NOTES section for EMAILNOTIFICATIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedTenantsManagedTenantEmailNotification[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IManagedTenantsIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LastActionByUserId
.

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

### -LastActionDateTime
.

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

### -ManagedTenantAlertId
The unique identifier of managedTenantAlert

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

### -Message
.

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

### -Severity
alertSeverity

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

### -Status
alertStatus

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

### -TenantId
.

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

### -Title
.

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

### Microsoft.Graph.Beta.PowerShell.Models.IManagedTenantsIdentity

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedTenantsManagedTenantAlert

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedTenantsManagedTenantAlert

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`ALERTDATA <IMicrosoftGraphManagedTenantsAlertData>`: alertData
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DisplayName <String>]`: 

`ALERTDATAREFERENCESTRINGS <IMicrosoftGraphManagedTenantsAlertDataReferenceString[]>`: .
  - `[DisplayName <String>]`: 

`ALERTLOGS <IMicrosoftGraphManagedTenantsManagedTenantAlertLog[]>`: .
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
  - `[Content <IMicrosoftGraphManagedTenantsAlertLogContent>]`: alertLogContent
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: 
  - `[CreatedByUserId <String>]`: 
  - `[CreatedDateTime <DateTime?>]`: 
  - `[LastActionByUserId <String>]`: 
  - `[LastActionDateTime <DateTime?>]`: 

`ALERTRULE <IMicrosoftGraphManagedTenantsManagedTenantAlertRule>`: managedTenantAlertRule
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

`APINOTIFICATIONS <IMicrosoftGraphManagedTenantsManagedTenantApiNotification[]>`: .
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
        - `[TenantId <String>]`: The Azure Active Directory tenant identifier for the managed tenant. Optional.
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

`BODYPARAMETER <IMicrosoftGraphManagedTenantsManagedTenantAlert>`: managedTenantAlert
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

`EMAILNOTIFICATIONS <IMicrosoftGraphManagedTenantsManagedTenantEmailNotification[]>`: .
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
    - `[LastActionByUserId <String>]`: 
    - `[LastActionDateTime <DateTime?>]`: 
    - `[Message <String>]`: 
    - `[Severity <String>]`: alertSeverity
    - `[Status <String>]`: alertStatus
    - `[TenantId <String>]`: 
    - `[Title <String>]`: 
  - `[CreatedByUserId <String>]`: 
  - `[CreatedDateTime <DateTime?>]`: 
  - `[EmailAddresses <IMicrosoftGraphManagedTenantsEmail[]>]`: 
    - `[EmailAddress <String>]`: 
  - `[EmailBody <String>]`: 
  - `[LastActionByUserId <String>]`: 
  - `[LastActionDateTime <DateTime?>]`: 
  - `[Subject <String>]`: 

`INPUTOBJECT <IManagedTenantsIdentity>`: Identity Parameter
  - `[AggregatedPolicyComplianceId <String>]`: The unique identifier of aggregatedPolicyCompliance
  - `[AppPerformanceId <String>]`: The unique identifier of appPerformance
  - `[AuditEventId <String>]`: The unique identifier of auditEvent
  - `[CloudPcConnectionId <String>]`: The unique identifier of cloudPcConnection
  - `[CloudPcDeviceId <String>]`: The unique identifier of cloudPcDevice
  - `[CloudPcOverviewTenantId <String>]`: The unique identifier of cloudPcOverview
  - `[ConditionalAccessPolicyCoverageId <String>]`: The unique identifier of conditionalAccessPolicyCoverage
  - `[CredentialUserRegistrationsSummaryId <String>]`: The unique identifier of credentialUserRegistrationsSummary
  - `[DeviceAppPerformanceId <String>]`: The unique identifier of deviceAppPerformance
  - `[DeviceCompliancePolicySettingStateSummaryId <String>]`: The unique identifier of deviceCompliancePolicySettingStateSummary
  - `[DeviceHealthStatusId <String>]`: The unique identifier of deviceHealthStatus
  - `[ManagedDeviceComplianceId <String>]`: The unique identifier of managedDeviceCompliance
  - `[ManagedDeviceComplianceTrendId <String>]`: The unique identifier of managedDeviceComplianceTrend
  - `[ManagedTenantAlertId <String>]`: The unique identifier of managedTenantAlert
  - `[ManagedTenantAlertLogId <String>]`: The unique identifier of managedTenantAlertLog
  - `[ManagedTenantAlertRuleDefinitionId <String>]`: The unique identifier of managedTenantAlertRuleDefinition
  - `[ManagedTenantAlertRuleId <String>]`: The unique identifier of managedTenantAlertRule
  - `[ManagedTenantApiNotificationId <String>]`: The unique identifier of managedTenantApiNotification
  - `[ManagedTenantEmailNotificationId <String>]`: The unique identifier of managedTenantEmailNotification
  - `[ManagedTenantTicketingEndpointId <String>]`: The unique identifier of managedTenantTicketingEndpoint
  - `[ManagementActionId <String>]`: The unique identifier of managementAction
  - `[ManagementActionTenantDeploymentStatusId <String>]`: The unique identifier of managementActionTenantDeploymentStatus
  - `[ManagementIntentId <String>]`: The unique identifier of managementIntent
  - `[ManagementTemplateCollectionId <String>]`: The unique identifier of managementTemplateCollection
  - `[ManagementTemplateCollectionTenantSummaryId <String>]`: The unique identifier of managementTemplateCollectionTenantSummary
  - `[ManagementTemplateId <String>]`: The unique identifier of managementTemplate
  - `[ManagementTemplateStepDeploymentId <String>]`: The unique identifier of managementTemplateStepDeployment
  - `[ManagementTemplateStepId <String>]`: The unique identifier of managementTemplateStep
  - `[ManagementTemplateStepTenantSummaryId <String>]`: The unique identifier of managementTemplateStepTenantSummary
  - `[ManagementTemplateStepVersionId <String>]`: The unique identifier of managementTemplateStepVersion
  - `[MyRoleTenantId <String>]`: The unique identifier of myRole
  - `[TenantCustomizedInformationId <String>]`: The unique identifier of tenantCustomizedInformation
  - `[TenantDetailedInformationId <String>]`: The unique identifier of tenantDetailedInformation
  - `[TenantGroupId <String>]`: The unique identifier of tenantGroup
  - `[TenantId <String>]`: The unique identifier of tenant
  - `[TenantTagId <String>]`: The unique identifier of tenantTag
  - `[WindowsDeviceMalwareStateId <String>]`: The unique identifier of windowsDeviceMalwareState
  - `[WindowsProtectionStateId <String>]`: The unique identifier of windowsProtectionState

## RELATED LINKS

