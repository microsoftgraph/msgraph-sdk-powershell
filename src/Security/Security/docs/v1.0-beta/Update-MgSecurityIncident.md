---
external help file:
Module Name: Microsoft.Graph.Security
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.security/update-mgsecurityincident
schema: 2.0.0
---

# Update-MgSecurityIncident

## SYNOPSIS
Update the navigation property incidents in security

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgSecurityIncident -IncidentId <String> [-AdditionalProperties <Hashtable>]
 [-Alerts <IMicrosoftGraphAlertV2[]>] [-AssignedTo <String>] [-Classification <String>]
 [-Comments <IMicrosoftGraphAlertCommentV2[]>] [-CreatedDateTime <DateTime>] [-Determination <String>]
 [-DisplayName <String>] [-Id <String>] [-IncidentWebUrl <String>] [-LastUpdateDateTime <DateTime>]
 [-RedirectIncidentId <String>] [-Severity <String>] [-Status <String>] [-Tags <String[]>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgSecurityIncident -IncidentId <String> -BodyParameter <IMicrosoftGraphIncident> [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgSecurityIncident -InputObject <ISecurityIdentity> -BodyParameter <IMicrosoftGraphIncident>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgSecurityIncident -InputObject <ISecurityIdentity> [-AdditionalProperties <Hashtable>]
 [-Alerts <IMicrosoftGraphAlertV2[]>] [-AssignedTo <String>] [-Classification <String>]
 [-Comments <IMicrosoftGraphAlertCommentV2[]>] [-CreatedDateTime <DateTime>] [-Determination <String>]
 [-DisplayName <String>] [-Id <String>] [-IncidentWebUrl <String>] [-LastUpdateDateTime <DateTime>]
 [-RedirectIncidentId <String>] [-Severity <String>] [-Status <String>] [-Tags <String[]>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property incidents in security

## EXAMPLES

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

### -Alerts
.
To construct, please use Get-Help -Online and see NOTES section for ALERTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAlertV2[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIncident
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Classification
alertClassification_v2

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

### -Comments
.
To construct, please use Get-Help -Online and see NOTES section for COMMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAlertCommentV2[]
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

### -Determination
alertDetermination_v2

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

### -DisplayName
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

### -Id
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

### -IncidentId
key: id of incident

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

### -IncidentWebUrl
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

### -InputObject
Identity Parameter
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

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

### -LastUpdateDateTime
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

### -PassThru
Returns true when the command succeeds

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Severity
alertSeverity_v2

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
incidentStatus

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

### -Tags
.

```yaml
Type: System.String[]
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIncident

### Microsoft.Graph.PowerShell.Models.ISecurityIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ALERTS <IMicrosoftGraphAlertV2[]>: .
  - `[Id <String>]`: Read-only.
  - `[AadTenantId <String>]`: 
  - `[ActorDisplayName <String>]`: 
  - `[AlertWebUrl <String>]`: 
  - `[AssignedTo <String>]`: 
  - `[Category <String>]`: 
  - `[Classification <String>]`: alertClassification_v2
  - `[Comments <IMicrosoftGraphAlertCommentV2[]>]`: 
    - `[Comment <String>]`: 
    - `[CreatedByDisplayName <String>]`: 
    - `[CreatedDateTime <DateTime?>]`: 
  - `[CreatedDateTime <DateTime?>]`: 
  - `[Description <String>]`: 
  - `[DetectorId <String>]`: 
  - `[Determination <String>]`: alertDetermination_v2
  - `[FirstActivityDateTime <DateTime?>]`: 
  - `[IncidentId <String>]`: 
  - `[IncidentWebUrl <String>]`: 
  - `[LastActivityDateTime <DateTime?>]`: 
  - `[LastUpdateDateTime <DateTime?>]`: 
  - `[MitreTechniques <String[]>]`: 
  - `[ProviderAlertId <String>]`: 
  - `[ResolvedDateTime <DateTime?>]`: 
  - `[ServiceSource <String>]`: serviceSource
  - `[Severity <String>]`: alertSeverity_v2
  - `[Status <String>]`: alertStatus_v2
  - `[ThreatDisplayName <String>]`: 
  - `[ThreatFamilyName <String>]`: 
  - `[Title <String>]`: 

BODYPARAMETER <IMicrosoftGraphIncident>: incident
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[Alerts <IMicrosoftGraphAlertV2[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AadTenantId <String>]`: 
    - `[ActorDisplayName <String>]`: 
    - `[AlertWebUrl <String>]`: 
    - `[AssignedTo <String>]`: 
    - `[Category <String>]`: 
    - `[Classification <String>]`: alertClassification_v2
    - `[Comments <IMicrosoftGraphAlertCommentV2[]>]`: 
      - `[Comment <String>]`: 
      - `[CreatedByDisplayName <String>]`: 
      - `[CreatedDateTime <DateTime?>]`: 
    - `[CreatedDateTime <DateTime?>]`: 
    - `[Description <String>]`: 
    - `[DetectorId <String>]`: 
    - `[Determination <String>]`: alertDetermination_v2
    - `[FirstActivityDateTime <DateTime?>]`: 
    - `[IncidentId <String>]`: 
    - `[IncidentWebUrl <String>]`: 
    - `[LastActivityDateTime <DateTime?>]`: 
    - `[LastUpdateDateTime <DateTime?>]`: 
    - `[MitreTechniques <String[]>]`: 
    - `[ProviderAlertId <String>]`: 
    - `[ResolvedDateTime <DateTime?>]`: 
    - `[ServiceSource <String>]`: serviceSource
    - `[Severity <String>]`: alertSeverity_v2
    - `[Status <String>]`: alertStatus_v2
    - `[ThreatDisplayName <String>]`: 
    - `[ThreatFamilyName <String>]`: 
    - `[Title <String>]`: 
  - `[AssignedTo <String>]`: 
  - `[Classification <String>]`: alertClassification_v2
  - `[Comments <IMicrosoftGraphAlertCommentV2[]>]`: 
  - `[CreatedDateTime <DateTime?>]`: 
  - `[Determination <String>]`: alertDetermination_v2
  - `[DisplayName <String>]`: 
  - `[IncidentWebUrl <String>]`: 
  - `[LastUpdateDateTime <DateTime?>]`: 
  - `[RedirectIncidentId <String>]`: 
  - `[Severity <String>]`: alertSeverity_v2
  - `[Status <String>]`: incidentStatus
  - `[Tags <String[]>]`: 

COMMENTS <IMicrosoftGraphAlertCommentV2[]>: .
  - `[Comment <String>]`: 
  - `[CreatedByDisplayName <String>]`: 
  - `[CreatedDateTime <DateTime?>]`: 

INPUTOBJECT <ISecurityIdentity>: Identity Parameter
  - `[AlertId <String>]`: key: id of alert
  - `[CloudAppSecurityProfileId <String>]`: key: id of cloudAppSecurityProfile
  - `[DomainSecurityProfileId <String>]`: key: id of domainSecurityProfile
  - `[FileSecurityProfileId <String>]`: key: id of fileSecurityProfile
  - `[HostSecurityProfileId <String>]`: key: id of hostSecurityProfile
  - `[IPSecurityProfileId <String>]`: key: id of ipSecurityProfile
  - `[IncidentId <String>]`: key: id of incident
  - `[ProviderTenantSettingId <String>]`: key: id of providerTenantSetting
  - `[SecureScoreControlProfileId <String>]`: key: id of secureScoreControlProfile
  - `[SecureScoreId <String>]`: key: id of secureScore
  - `[SecurityActionId <String>]`: key: id of securityAction
  - `[SimulationId <String>]`: key: id of simulation
  - `[TiIndicatorId <String>]`: key: id of tiIndicator
  - `[UserSecurityProfileId <String>]`: key: id of userSecurityProfile

## RELATED LINKS

