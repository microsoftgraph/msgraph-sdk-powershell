---
external help file:
Module Name: Microsoft.Graph.Beta.Security
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.security/new-mgbetasecurityincident
schema: 2.0.0
---

# New-MgBetaSecurityIncident

## SYNOPSIS
Create new navigation property to incidents for security

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaSecurityIncident [-AdditionalProperties <Hashtable>] [-Alerts <IMicrosoftGraphSecurityAlert[]>]
 [-AssignedTo <String>] [-Classification <String>] [-Comments <IMicrosoftGraphSecurityAlertComment[]>]
 [-CreatedDateTime <DateTime>] [-CustomTags <String[]>] [-Description <String>] [-Determination <String>]
 [-DisplayName <String>] [-Id <String>] [-IncidentWebUrl <String>] [-LastModifiedBy <String>]
 [-LastUpdateDateTime <DateTime>] [-RecommendedActions <String>]
 [-RecommendedHuntingQueries <IMicrosoftGraphSecurityRecommendedHuntingQuery[]>]
 [-RedirectIncidentId <String>] [-ResponseHeadersVariable <String>] [-Severity <String>] [-Status <String>]
 [-SystemTags <String[]>] [-TenantId <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgBetaSecurityIncident -BodyParameter <IMicrosoftGraphSecurityIncident>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to incidents for security

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

### -Alerts
The list of related alerts.
Supports $expand.
To construct, see NOTES section for ALERTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecurityAlert[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AssignedTo
Owner of the incident, or null if no owner is assigned.
Free editable text.

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
incident
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecurityIncident
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Classification
alertClassification

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

### -Comments
Array of comments created by the Security Operations (SecOps) team when the incident is managed.
To construct, see NOTES section for COMMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecurityAlertComment[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedDateTime
Time when the incident was first created.

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

### -CustomTags
The collection of custom tags that are associated with an incident.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
A rich text string describing the incident

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

### -Determination
alertDetermination

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
The incident name.

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

### -IncidentWebUrl
The URL for the incident page in the Microsoft 365 Defender portal.

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

### -LastModifiedBy
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

### -LastUpdateDateTime
Time when the incident was last updated.

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

### -RecommendedActions
A rich text string that represents the actions that are reccomnded to take in order to resolve the incident

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

### -RecommendedHuntingQueries
List of hunting Kusto Query Language (KQL) queries related to the incident
To construct, see NOTES section for RECOMMENDEDHUNTINGQUERIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecurityRecommendedHuntingQuery[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RedirectIncidentId
Only populated in case an incident is grouped together with another incident, as part of the logic that processes incidents.
In such a case, the status property is redirected.

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

### -Status
incidentStatus

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

### -SystemTags
The collection of system tags that are associated with the incident.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TenantId
The Microsoft Entra tenant in which the alert was created.

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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecurityIncident

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecurityIncident

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`ALERTS <IMicrosoftGraphSecurityAlert[]>`: The list of related alerts. Supports $expand.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[ActorDisplayName <String>]`: The adversary or activity group that is associated with this alert.
  - `[AdditionalData <IMicrosoftGraphSecurityDictionary>]`: dictionary
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AlertPolicyId <String>]`: 
  - `[AlertWebUrl <String>]`: URL for the alert page in the Microsoft 365 Defender portal.
  - `[AssignedTo <String>]`: Owner of the alert, or null if no owner is assigned.
  - `[Category <String>]`: The attack kill-chain category that the alert belongs to. Aligned with the MITRE ATT&CK framework.
  - `[Classification <String>]`: alertClassification
  - `[Comments <IMicrosoftGraphSecurityAlertComment[]>]`: Array of comments created by the Security Operations (SecOps) team during the alert management process.
    - `[Comment <String>]`: The comment text.
    - `[CreatedByDisplayName <String>]`: The person or app name that submitted the comment.
    - `[CreatedDateTime <DateTime?>]`: The time when the comment was submitted.
  - `[CreatedDateTime <DateTime?>]`: Time when Microsoft 365 Defender created the alert.
  - `[Description <String>]`: String value describing each alert.
  - `[DetectionSource <String>]`: detectionSource
  - `[DetectorId <String>]`: The ID of the detector that triggered the alert.
  - `[Determination <String>]`: alertDetermination
  - `[Evidence <IMicrosoftGraphSecurityAlertEvidence[]>]`: Collection of evidence related to the alert.
    - `[CreatedDateTime <DateTime?>]`: The date and time when the evidence was created and added to the alert. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[DetailedRoles <String[]>]`: Detailed description of the entity role/s in an alert. Values are free-form.
    - `[RemediationStatus <String>]`: evidenceRemediationStatus
    - `[RemediationStatusDetails <String>]`: Details about the remediation status.
    - `[Roles <String[]>]`: The role/s that an evidence entity represents in an alert, for example, an IP address that is associated with an attacker has the evidence role Attacker.
    - `[Tags <String[]>]`: Array of custom tags associated with an evidence instance, for example, to denote a group of devices, high-value assets, etc.
    - `[Verdict <String>]`: evidenceVerdict
  - `[FirstActivityDateTime <DateTime?>]`: The earliest activity associated with the alert.
  - `[IncidentId <String>]`: Unique identifier to represent the incident this alert resource is associated with.
  - `[IncidentWebUrl <String>]`: URL for the incident page in the Microsoft 365 Defender portal.
  - `[LastActivityDateTime <DateTime?>]`: The oldest activity associated with the alert.
  - `[LastUpdateDateTime <DateTime?>]`: Time when the alert was last updated at Microsoft 365 Defender.
  - `[MitreTechniques <String[]>]`: The attack techniques, as aligned with the MITRE ATT&CK framework.
  - `[ProductName <String>]`: 
  - `[ProviderAlertId <String>]`: The ID of the alert as it appears in the security provider product that generated the alert.
  - `[RecommendedActions <String>]`: Recommended response and remediation actions to take in the event this alert was generated.
  - `[ResolvedDateTime <DateTime?>]`: Time when the alert was resolved.
  - `[ServiceSource <String>]`: serviceSource
  - `[Severity <String>]`: alertSeverity
  - `[Status <String>]`: alertStatus
  - `[SystemTags <String[]>]`: The system tags associated with the alert
  - `[TenantId <String>]`: The Microsoft Entra tenant the alert was created in.
  - `[ThreatDisplayName <String>]`: The threat associated with this alert.
  - `[ThreatFamilyName <String>]`: Threat family associated with this alert.
  - `[Title <String>]`: Brief identifying string value describing the alert.

`BODYPARAMETER <IMicrosoftGraphSecurityIncident>`: incident
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Alerts <IMicrosoftGraphSecurityAlert[]>]`: The list of related alerts. Supports $expand.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[ActorDisplayName <String>]`: The adversary or activity group that is associated with this alert.
    - `[AdditionalData <IMicrosoftGraphSecurityDictionary>]`: dictionary
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AlertPolicyId <String>]`: 
    - `[AlertWebUrl <String>]`: URL for the alert page in the Microsoft 365 Defender portal.
    - `[AssignedTo <String>]`: Owner of the alert, or null if no owner is assigned.
    - `[Category <String>]`: The attack kill-chain category that the alert belongs to. Aligned with the MITRE ATT&CK framework.
    - `[Classification <String>]`: alertClassification
    - `[Comments <IMicrosoftGraphSecurityAlertComment[]>]`: Array of comments created by the Security Operations (SecOps) team during the alert management process.
      - `[Comment <String>]`: The comment text.
      - `[CreatedByDisplayName <String>]`: The person or app name that submitted the comment.
      - `[CreatedDateTime <DateTime?>]`: The time when the comment was submitted.
    - `[CreatedDateTime <DateTime?>]`: Time when Microsoft 365 Defender created the alert.
    - `[Description <String>]`: String value describing each alert.
    - `[DetectionSource <String>]`: detectionSource
    - `[DetectorId <String>]`: The ID of the detector that triggered the alert.
    - `[Determination <String>]`: alertDetermination
    - `[Evidence <IMicrosoftGraphSecurityAlertEvidence[]>]`: Collection of evidence related to the alert.
      - `[CreatedDateTime <DateTime?>]`: The date and time when the evidence was created and added to the alert. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[DetailedRoles <String[]>]`: Detailed description of the entity role/s in an alert. Values are free-form.
      - `[RemediationStatus <String>]`: evidenceRemediationStatus
      - `[RemediationStatusDetails <String>]`: Details about the remediation status.
      - `[Roles <String[]>]`: The role/s that an evidence entity represents in an alert, for example, an IP address that is associated with an attacker has the evidence role Attacker.
      - `[Tags <String[]>]`: Array of custom tags associated with an evidence instance, for example, to denote a group of devices, high-value assets, etc.
      - `[Verdict <String>]`: evidenceVerdict
    - `[FirstActivityDateTime <DateTime?>]`: The earliest activity associated with the alert.
    - `[IncidentId <String>]`: Unique identifier to represent the incident this alert resource is associated with.
    - `[IncidentWebUrl <String>]`: URL for the incident page in the Microsoft 365 Defender portal.
    - `[LastActivityDateTime <DateTime?>]`: The oldest activity associated with the alert.
    - `[LastUpdateDateTime <DateTime?>]`: Time when the alert was last updated at Microsoft 365 Defender.
    - `[MitreTechniques <String[]>]`: The attack techniques, as aligned with the MITRE ATT&CK framework.
    - `[ProductName <String>]`: 
    - `[ProviderAlertId <String>]`: The ID of the alert as it appears in the security provider product that generated the alert.
    - `[RecommendedActions <String>]`: Recommended response and remediation actions to take in the event this alert was generated.
    - `[ResolvedDateTime <DateTime?>]`: Time when the alert was resolved.
    - `[ServiceSource <String>]`: serviceSource
    - `[Severity <String>]`: alertSeverity
    - `[Status <String>]`: alertStatus
    - `[SystemTags <String[]>]`: The system tags associated with the alert
    - `[TenantId <String>]`: The Microsoft Entra tenant the alert was created in.
    - `[ThreatDisplayName <String>]`: The threat associated with this alert.
    - `[ThreatFamilyName <String>]`: Threat family associated with this alert.
    - `[Title <String>]`: Brief identifying string value describing the alert.
  - `[AssignedTo <String>]`: Owner of the incident, or null if no owner is assigned. Free editable text.
  - `[Classification <String>]`: alertClassification
  - `[Comments <IMicrosoftGraphSecurityAlertComment[]>]`: Array of comments created by the Security Operations (SecOps) team when the incident is managed.
  - `[CreatedDateTime <DateTime?>]`: Time when the incident was first created.
  - `[CustomTags <String[]>]`: The collection of custom tags that are associated with an incident.
  - `[Description <String>]`: A rich text string describing the incident
  - `[Determination <String>]`: alertDetermination
  - `[DisplayName <String>]`: The incident name.
  - `[IncidentWebUrl <String>]`: The URL for the incident page in the Microsoft 365 Defender portal.
  - `[LastModifiedBy <String>]`: 
  - `[LastUpdateDateTime <DateTime?>]`: Time when the incident was last updated.
  - `[RecommendedActions <String>]`: A rich text string that represents the actions that are reccomnded to take in order to resolve the incident
  - `[RecommendedHuntingQueries <IMicrosoftGraphSecurityRecommendedHuntingQuery[]>]`: List of hunting Kusto Query Language (KQL) queries related to the incident
    - `[KqlText <String>]`: The query string.
  - `[RedirectIncidentId <String>]`: Only populated in case an incident is grouped together with another incident, as part of the logic that processes incidents. In such a case, the status property is redirected.
  - `[Severity <String>]`: alertSeverity
  - `[Status <String>]`: incidentStatus
  - `[SystemTags <String[]>]`: The collection of system tags that are associated with the incident.
  - `[TenantId <String>]`: The Microsoft Entra tenant in which the alert was created.

`COMMENTS <IMicrosoftGraphSecurityAlertComment[]>`: Array of comments created by the Security Operations (SecOps) team when the incident is managed.
  - `[Comment <String>]`: The comment text.
  - `[CreatedByDisplayName <String>]`: The person or app name that submitted the comment.
  - `[CreatedDateTime <DateTime?>]`: The time when the comment was submitted.

`RECOMMENDEDHUNTINGQUERIES <IMicrosoftGraphSecurityRecommendedHuntingQuery[]>`: List of hunting Kusto Query Language (KQL) queries related to the incident
  - `[KqlText <String>]`: The query string.

## RELATED LINKS

