---
external help file:
Module Name: Microsoft.Graph.Beta.Security
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.security/new-mgsecurityincident
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
 [-CreatedDateTime <DateTime>] [-Determination <String>] [-DisplayName <String>] [-Id <String>]
 [-IncidentWebUrl <String>] [-LastUpdateDateTime <DateTime>] [-RedirectIncidentId <String>]
 [-Severity <String>] [-Status <String>] [-Tags <String[]>] [-TenantId <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgBetaSecurityIncident -BodyParameter <IMicrosoftGraphSecurityIncident> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to incidents for security

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

### -Alerts
The list of related alerts.
Supports $expand.
To construct, please use Get-Help -Online and see NOTES section for ALERTS properties and create a hash table.

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
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

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
To construct, please use Get-Help -Online and see NOTES section for COMMENTS properties and create a hash table.

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

### -Tags
Array of custom tags associated with an incident.

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
The Azure Active Directory tenant in which the alert was created.

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

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecurityIncident

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ALERTS <IMicrosoftGraphSecurityAlert[]>: The list of related alerts. Supports $expand.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[ActorDisplayName <String>]`: The adversary or activity group that is associated with this alert.
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
  - `[Evidence <IMicrosoftGraphSecurityAlertEvidence1[]>]`: Collection of evidence related to the alert.
    - `[CreatedDateTime <DateTime?>]`: The time the evidence was created and added to the alert.
    - `[RemediationStatus <String>]`: evidenceRemediationStatus
    - `[RemediationStatusDetails <String>]`: Details about the remediation status.
    - `[Roles <String[]>]`: The role/s that an evidence entity represents in an alert, e.g., an IP address that is associated with an attacker will have the evidence role 'Attacker'.
    - `[Tags <String[]>]`: Array of custom tags associated with an evidence instance, for example to denote a group of devices, high value assets, etc.
    - `[Verdict <String>]`: evidenceVerdict
  - `[FirstActivityDateTime <DateTime?>]`: The earliest activity associated with the alert.
  - `[IncidentId <String>]`: Unique identifier to represent the incident this alert resource is associated with.
  - `[IncidentWebUrl <String>]`: URL for the incident page in the Microsoft 365 Defender portal.
  - `[LastActivityDateTime <DateTime?>]`: The oldest activity associated with the alert.
  - `[LastUpdateDateTime <DateTime?>]`: Time when the alert was last updated at Microsoft 365 Defender.
  - `[MitreTechniques <String[]>]`: The attack techniques, as aligned with the MITRE ATT&CK framework.
  - `[ProviderAlertId <String>]`: The ID of the alert as it appears in the security provider product that generated the alert.
  - `[RecommendedActions <String>]`: Recommended response and remediation actions to take in the event this alert was generated.
  - `[ResolvedDateTime <DateTime?>]`: Time when the alert was resolved.
  - `[ServiceSource <String>]`: serviceSource
  - `[Severity <String>]`: alertSeverity
  - `[Status <String>]`: alertStatus
  - `[TenantId <String>]`: The Azure Active Directory tenant the alert was created in.
  - `[ThreatDisplayName <String>]`: The threat associated with this alert.
  - `[ThreatFamilyName <String>]`: Threat family associated with this alert.
  - `[Title <String>]`: Brief identifying string value describing the alert.

BODYPARAMETER <IMicrosoftGraphSecurityIncident>: incident
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Alerts <IMicrosoftGraphSecurityAlert[]>]`: The list of related alerts. Supports $expand.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[ActorDisplayName <String>]`: The adversary or activity group that is associated with this alert.
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
    - `[Evidence <IMicrosoftGraphSecurityAlertEvidence1[]>]`: Collection of evidence related to the alert.
      - `[CreatedDateTime <DateTime?>]`: The time the evidence was created and added to the alert.
      - `[RemediationStatus <String>]`: evidenceRemediationStatus
      - `[RemediationStatusDetails <String>]`: Details about the remediation status.
      - `[Roles <String[]>]`: The role/s that an evidence entity represents in an alert, e.g., an IP address that is associated with an attacker will have the evidence role 'Attacker'.
      - `[Tags <String[]>]`: Array of custom tags associated with an evidence instance, for example to denote a group of devices, high value assets, etc.
      - `[Verdict <String>]`: evidenceVerdict
    - `[FirstActivityDateTime <DateTime?>]`: The earliest activity associated with the alert.
    - `[IncidentId <String>]`: Unique identifier to represent the incident this alert resource is associated with.
    - `[IncidentWebUrl <String>]`: URL for the incident page in the Microsoft 365 Defender portal.
    - `[LastActivityDateTime <DateTime?>]`: The oldest activity associated with the alert.
    - `[LastUpdateDateTime <DateTime?>]`: Time when the alert was last updated at Microsoft 365 Defender.
    - `[MitreTechniques <String[]>]`: The attack techniques, as aligned with the MITRE ATT&CK framework.
    - `[ProviderAlertId <String>]`: The ID of the alert as it appears in the security provider product that generated the alert.
    - `[RecommendedActions <String>]`: Recommended response and remediation actions to take in the event this alert was generated.
    - `[ResolvedDateTime <DateTime?>]`: Time when the alert was resolved.
    - `[ServiceSource <String>]`: serviceSource
    - `[Severity <String>]`: alertSeverity
    - `[Status <String>]`: alertStatus
    - `[TenantId <String>]`: The Azure Active Directory tenant the alert was created in.
    - `[ThreatDisplayName <String>]`: The threat associated with this alert.
    - `[ThreatFamilyName <String>]`: Threat family associated with this alert.
    - `[Title <String>]`: Brief identifying string value describing the alert.
  - `[AssignedTo <String>]`: Owner of the incident, or null if no owner is assigned. Free editable text.
  - `[Classification <String>]`: alertClassification
  - `[Comments <IMicrosoftGraphSecurityAlertComment[]>]`: Array of comments created by the Security Operations (SecOps) team when the incident is managed.
  - `[CreatedDateTime <DateTime?>]`: Time when the incident was first created.
  - `[Determination <String>]`: alertDetermination
  - `[DisplayName <String>]`: The incident name.
  - `[IncidentWebUrl <String>]`: The URL for the incident page in the Microsoft 365 Defender portal.
  - `[LastUpdateDateTime <DateTime?>]`: Time when the incident was last updated.
  - `[RedirectIncidentId <String>]`: Only populated in case an incident is grouped together with another incident, as part of the logic that processes incidents. In such a case, the status property is redirected.
  - `[Severity <String>]`: alertSeverity
  - `[Status <String>]`: incidentStatus
  - `[Tags <String[]>]`: Array of custom tags associated with an incident.
  - `[TenantId <String>]`: The Azure Active Directory tenant in which the alert was created.

COMMENTS <IMicrosoftGraphSecurityAlertComment[]>: Array of comments created by the Security Operations (SecOps) team when the incident is managed.
  - `[Comment <String>]`: The comment text.
  - `[CreatedByDisplayName <String>]`: The person or app name that submitted the comment.
  - `[CreatedDateTime <DateTime?>]`: The time when the comment was submitted.

## RELATED LINKS

