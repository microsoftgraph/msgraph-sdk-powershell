---
external help file:
Module Name: Microsoft.Graph.Security
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.security/update-mgsecuritythreatintelligencehostreputation
schema: 2.0.0
---

# Update-MgSecurityThreatIntelligenceHostReputation

## SYNOPSIS
Update the navigation property reputation in security

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgSecurityThreatIntelligenceHostReputation -HostId <String> [-AdditionalProperties <Hashtable>]
 [-Classification <String>] [-Id <String>] [-Rules <IMicrosoftGraphSecurityHostReputationRule[]>]
 [-Score <Int32>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgSecurityThreatIntelligenceHostReputation -HostId <String>
 -BodyParameter <IMicrosoftGraphSecurityHostReputation> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgSecurityThreatIntelligenceHostReputation -InputObject <ISecurityIdentity>
 -BodyParameter <IMicrosoftGraphSecurityHostReputation> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgSecurityThreatIntelligenceHostReputation -InputObject <ISecurityIdentity>
 [-AdditionalProperties <Hashtable>] [-Classification <String>] [-Id <String>]
 [-Rules <IMicrosoftGraphSecurityHostReputationRule[]>] [-Score <Int32>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property reputation in security

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

### -BodyParameter
hostReputation
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityHostReputation
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Classification
hostReputationClassification

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

### -HostId
The unique identifier of host

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

### -Id
The unique idenfier for an entity.
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
Type: Microsoft.Graph.PowerShell.Models.ISecurityIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Rules
A collection of rules that have been used to calculate the classification and score.
To construct, see NOTES section for RULES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityHostReputationRule[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Score
The calculated score (0-100) of the requested host.
A higher value indicates that this host is more likely to be suspicious or malicious.

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityHostReputation

### Microsoft.Graph.PowerShell.Models.ISecurityIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityHostReputation

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphSecurityHostReputation>`: hostReputation
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Classification <String>]`: hostReputationClassification
  - `[Rules <IMicrosoftGraphSecurityHostReputationRule[]>]`: A collection of rules that have been used to calculate the classification and score.
    - `[Description <String>]`: The description of the rule that gives more context.
    - `[Name <String>]`: The name of the rule.
    - `[RelatedDetailsUrl <String>]`: Link to a web page with details related to this rule.
    - `[Severity <String>]`: hostReputationRuleSeverity
  - `[Score <Int32?>]`: The calculated score (0-100) of the requested host. A higher value indicates that this host is more likely to be suspicious or malicious.

`INPUTOBJECT <ISecurityIdentity>`: Identity Parameter
  - `[AlertId <String>]`: The unique identifier of alert
  - `[ArticleId <String>]`: The unique identifier of article
  - `[ArticleIndicatorId <String>]`: The unique identifier of articleIndicator
  - `[CaseOperationId <String>]`: The unique identifier of caseOperation
  - `[DataSourceId <String>]`: The unique identifier of dataSource
  - `[EdiscoveryCaseId <String>]`: The unique identifier of ediscoveryCase
  - `[EdiscoveryCustodianId <String>]`: The unique identifier of ediscoveryCustodian
  - `[EdiscoveryNoncustodialDataSourceId <String>]`: The unique identifier of ediscoveryNoncustodialDataSource
  - `[EdiscoveryReviewSetId <String>]`: The unique identifier of ediscoveryReviewSet
  - `[EdiscoveryReviewSetQueryId <String>]`: The unique identifier of ediscoveryReviewSetQuery
  - `[EdiscoveryReviewTagId <String>]`: The unique identifier of ediscoveryReviewTag
  - `[EdiscoveryReviewTagId1 <String>]`: The unique identifier of ediscoveryReviewTag
  - `[EdiscoverySearchId <String>]`: The unique identifier of ediscoverySearch
  - `[HostComponentId <String>]`: The unique identifier of hostComponent
  - `[HostCookieId <String>]`: The unique identifier of hostCookie
  - `[HostId <String>]`: The unique identifier of host
  - `[HostTrackerId <String>]`: The unique identifier of hostTracker
  - `[IncidentId <String>]`: The unique identifier of incident
  - `[IntelligenceProfileId <String>]`: The unique identifier of intelligenceProfile
  - `[IntelligenceProfileIndicatorId <String>]`: The unique identifier of intelligenceProfileIndicator
  - `[PassiveDnsRecordId <String>]`: The unique identifier of passiveDnsRecord
  - `[RetentionEventId <String>]`: The unique identifier of retentionEvent
  - `[RetentionEventTypeId <String>]`: The unique identifier of retentionEventType
  - `[SecureScoreControlProfileId <String>]`: The unique identifier of secureScoreControlProfile
  - `[SecureScoreId <String>]`: The unique identifier of secureScore
  - `[SimulationAutomationId <String>]`: The unique identifier of simulationAutomation
  - `[SimulationAutomationRunId <String>]`: The unique identifier of simulationAutomationRun
  - `[SimulationId <String>]`: The unique identifier of simulation
  - `[SiteSourceId <String>]`: The unique identifier of siteSource
  - `[UnifiedGroupSourceId <String>]`: The unique identifier of unifiedGroupSource
  - `[UserSourceId <String>]`: The unique identifier of userSource
  - `[VulnerabilityComponentId <String>]`: The unique identifier of vulnerabilityComponent
  - `[VulnerabilityId <String>]`: The unique identifier of vulnerability

`RULES <IMicrosoftGraphSecurityHostReputationRule[]>`: A collection of rules that have been used to calculate the classification and score.
  - `[Description <String>]`: The description of the rule that gives more context.
  - `[Name <String>]`: The name of the rule.
  - `[RelatedDetailsUrl <String>]`: Link to a web page with details related to this rule.
  - `[Severity <String>]`: hostReputationRuleSeverity

## RELATED LINKS

