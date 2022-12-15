---
external help file:
Module Name: Microsoft.Graph.Security
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.security/new-mgsecurityincident
schema: 2.0.0
---

# New-MgSecurityIncident

## SYNOPSIS
Create new navigation property to incidents for security

## SYNTAX

### CreateExpanded1 (Default)
```
New-MgSecurityIncident [-AdditionalProperties <Hashtable>] [-Alerts <IMicrosoftGraphSecurityAlert[]>]
 [-AssignedTo <String>] [-Classification <String>] [-Comments <IMicrosoftGraphSecurityAlertComment[]>]
 [-CreatedDateTime <DateTime>] [-CustomTags <String[]>] [-Determination <String>] [-DisplayName <String>]
 [-Id <String>] [-IncidentWebUrl <String>] [-LastUpdateDateTime <DateTime>] [-RedirectIncidentId <String>]
 [-Severity <String>] [-Status <String>] [-TenantId <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create1
```
New-MgSecurityIncident -BodyParameter <IMicrosoftGraphSecurityIncident> [-Confirm] [-WhatIf]
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
Parameter Sets: CreateExpanded1
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityAlert[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AssignedTo
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityIncident
Parameter Sets: Create1
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
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Comments
.
To construct, please use Get-Help -Online and see NOTES section for COMMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityAlertComment[]
Parameter Sets: CreateExpanded1
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
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CustomTags
.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded1
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
Parameter Sets: CreateExpanded1
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
Parameter Sets: CreateExpanded1
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
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IncidentWebUrl
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastUpdateDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RedirectIncidentId
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
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
Parameter Sets: CreateExpanded1
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
Parameter Sets: CreateExpanded1
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
Parameter Sets: CreateExpanded1
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityIncident

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityIncident

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ALERTS <IMicrosoftGraphSecurityAlert[]>: .
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[ActorDisplayName <String>]`: 
  - `[AlertWebUrl <String>]`: 
  - `[AssignedTo <String>]`: 
  - `[Category <String>]`: 
  - `[Classification <String>]`: alertClassification
  - `[Comments <IMicrosoftGraphSecurityAlertComment[]>]`: 
    - `[Comment <String>]`: 
    - `[CreatedByDisplayName <String>]`: 
    - `[CreatedDateTime <DateTime?>]`: 
  - `[CreatedDateTime <DateTime?>]`: 
  - `[Description <String>]`: 
  - `[DetectionSource <String>]`: detectionSource
  - `[DetectorId <String>]`: 
  - `[Determination <String>]`: alertDetermination
  - `[Evidence <IMicrosoftGraphSecurityAlertEvidence1[]>]`: 
    - `[CreatedDateTime <DateTime?>]`: 
    - `[RemediationStatus <String>]`: evidenceRemediationStatus
    - `[RemediationStatusDetails <String>]`: 
    - `[Roles <String[]>]`: 
    - `[Tags <String[]>]`: 
    - `[Verdict <String>]`: evidenceVerdict
  - `[FirstActivityDateTime <DateTime?>]`: 
  - `[IncidentId <String>]`: 
  - `[IncidentWebUrl <String>]`: 
  - `[LastActivityDateTime <DateTime?>]`: 
  - `[LastUpdateDateTime <DateTime?>]`: 
  - `[MitreTechniques <String[]>]`: 
  - `[ProviderAlertId <String>]`: 
  - `[RecommendedActions <String>]`: 
  - `[ResolvedDateTime <DateTime?>]`: 
  - `[ServiceSource <String>]`: serviceSource
  - `[Severity <String>]`: alertSeverity
  - `[Status <String>]`: alertStatus
  - `[TenantId <String>]`: 
  - `[ThreatDisplayName <String>]`: 
  - `[ThreatFamilyName <String>]`: 
  - `[Title <String>]`: 

BODYPARAMETER <IMicrosoftGraphSecurityIncident>: incident
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Alerts <IMicrosoftGraphSecurityAlert[]>]`: 
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[ActorDisplayName <String>]`: 
    - `[AlertWebUrl <String>]`: 
    - `[AssignedTo <String>]`: 
    - `[Category <String>]`: 
    - `[Classification <String>]`: alertClassification
    - `[Comments <IMicrosoftGraphSecurityAlertComment[]>]`: 
      - `[Comment <String>]`: 
      - `[CreatedByDisplayName <String>]`: 
      - `[CreatedDateTime <DateTime?>]`: 
    - `[CreatedDateTime <DateTime?>]`: 
    - `[Description <String>]`: 
    - `[DetectionSource <String>]`: detectionSource
    - `[DetectorId <String>]`: 
    - `[Determination <String>]`: alertDetermination
    - `[Evidence <IMicrosoftGraphSecurityAlertEvidence1[]>]`: 
      - `[CreatedDateTime <DateTime?>]`: 
      - `[RemediationStatus <String>]`: evidenceRemediationStatus
      - `[RemediationStatusDetails <String>]`: 
      - `[Roles <String[]>]`: 
      - `[Tags <String[]>]`: 
      - `[Verdict <String>]`: evidenceVerdict
    - `[FirstActivityDateTime <DateTime?>]`: 
    - `[IncidentId <String>]`: 
    - `[IncidentWebUrl <String>]`: 
    - `[LastActivityDateTime <DateTime?>]`: 
    - `[LastUpdateDateTime <DateTime?>]`: 
    - `[MitreTechniques <String[]>]`: 
    - `[ProviderAlertId <String>]`: 
    - `[RecommendedActions <String>]`: 
    - `[ResolvedDateTime <DateTime?>]`: 
    - `[ServiceSource <String>]`: serviceSource
    - `[Severity <String>]`: alertSeverity
    - `[Status <String>]`: alertStatus
    - `[TenantId <String>]`: 
    - `[ThreatDisplayName <String>]`: 
    - `[ThreatFamilyName <String>]`: 
    - `[Title <String>]`: 
  - `[AssignedTo <String>]`: 
  - `[Classification <String>]`: alertClassification
  - `[Comments <IMicrosoftGraphSecurityAlertComment[]>]`: 
  - `[CreatedDateTime <DateTime?>]`: 
  - `[CustomTags <String[]>]`: 
  - `[Determination <String>]`: alertDetermination
  - `[DisplayName <String>]`: 
  - `[IncidentWebUrl <String>]`: 
  - `[LastUpdateDateTime <DateTime?>]`: 
  - `[RedirectIncidentId <String>]`: 
  - `[Severity <String>]`: alertSeverity
  - `[Status <String>]`: incidentStatus
  - `[TenantId <String>]`: 

COMMENTS <IMicrosoftGraphSecurityAlertComment[]>: .
  - `[Comment <String>]`: 
  - `[CreatedByDisplayName <String>]`: 
  - `[CreatedDateTime <DateTime?>]`: 

## RELATED LINKS

