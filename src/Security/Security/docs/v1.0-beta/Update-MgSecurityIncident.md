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
 [-Alerts <IMicrosoftGraphSecurityAlert[]>] [-AssignedTo <String>] [-Classification <String>]
 [-Comments <IMicrosoftGraphSecurityAlertComment[]>] [-CreatedDateTime <DateTime>] [-Determination <String>]
 [-DisplayName <String>] [-Id <String>] [-IncidentWebUrl <String>] [-LastUpdateDateTime <DateTime>]
 [-RedirectIncidentId <String>] [-Severity <String>] [-Status <String>] [-Tags <String[]>]
 [-TenantId <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgSecurityIncident -IncidentId <String> -BodyParameter <IMicrosoftGraphSecurityIncident> [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgSecurityIncident -InputObject <ISecurityIdentity> -BodyParameter <IMicrosoftGraphSecurityIncident>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgSecurityIncident -InputObject <ISecurityIdentity> [-AdditionalProperties <Hashtable>]
 [-Alerts <IMicrosoftGraphSecurityAlert[]>] [-AssignedTo <String>] [-Classification <String>]
 [-Comments <IMicrosoftGraphSecurityAlertComment[]>] [-CreatedDateTime <DateTime>] [-Determination <String>]
 [-DisplayName <String>] [-Id <String>] [-IncidentWebUrl <String>] [-LastUpdateDateTime <DateTime>]
 [-RedirectIncidentId <String>] [-Severity <String>] [-Status <String>] [-Tags <String[]>]
 [-TenantId <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityAlert[]
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityIncident
Parameter Sets: Update, UpdateViaIdentity
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityAlertComment[]
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
alertDetermination

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

### Microsoft.Graph.PowerShell.Models.ISecurityIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ALERTS <IMicrosoftGraphSecurityAlert[]>: .
  - `[Id <String>]`: 
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
  - `[Id <String>]`: 
  - `[Alerts <IMicrosoftGraphSecurityAlert[]>]`: 
    - `[Id <String>]`: 
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
  - `[Determination <String>]`: alertDetermination
  - `[DisplayName <String>]`: 
  - `[IncidentWebUrl <String>]`: 
  - `[LastUpdateDateTime <DateTime?>]`: 
  - `[RedirectIncidentId <String>]`: 
  - `[Severity <String>]`: alertSeverity
  - `[Status <String>]`: incidentStatus
  - `[Tags <String[]>]`: 
  - `[TenantId <String>]`: 

COMMENTS <IMicrosoftGraphSecurityAlertComment[]>: .
  - `[Comment <String>]`: 
  - `[CreatedByDisplayName <String>]`: 
  - `[CreatedDateTime <DateTime?>]`: 

INPUTOBJECT <ISecurityIdentity>: Identity Parameter
  - `[AlertId <String>]`: key: id of alert
  - `[AuthoredNoteId <String>]`: key: id of authoredNote
  - `[CaseOperationId <String>]`: key: id of caseOperation
  - `[CloudAppSecurityProfileId <String>]`: key: id of cloudAppSecurityProfile
  - `[DataSourceId <String>]`: key: id of dataSource
  - `[DispositionReviewStageId <String>]`: key: id of dispositionReviewStage
  - `[DomainSecurityProfileId <String>]`: key: id of domainSecurityProfile
  - `[EdiscoveryCaseId <String>]`: key: id of ediscoveryCase
  - `[EdiscoveryCustodianId <String>]`: key: id of ediscoveryCustodian
  - `[EdiscoveryFileId <String>]`: key: id of ediscoveryFile
  - `[EdiscoveryHoldPolicyId <String>]`: key: id of ediscoveryHoldPolicy
  - `[EdiscoveryNoncustodialDataSourceId <String>]`: key: id of ediscoveryNoncustodialDataSource
  - `[EdiscoveryReviewSetId <String>]`: key: id of ediscoveryReviewSet
  - `[EdiscoveryReviewSetQueryId <String>]`: key: id of ediscoveryReviewSetQuery
  - `[EdiscoveryReviewTagId <String>]`: key: id of ediscoveryReviewTag
  - `[EdiscoveryReviewTagId1 <String>]`: key: id of ediscoveryReviewTag
  - `[EdiscoverySearchId <String>]`: key: id of ediscoverySearch
  - `[EmailThreatSubmissionId <String>]`: key: id of emailThreatSubmission
  - `[EmailThreatSubmissionPolicyId <String>]`: key: id of emailThreatSubmissionPolicy
  - `[FileSecurityProfileId <String>]`: key: id of fileSecurityProfile
  - `[FileThreatSubmissionId <String>]`: key: id of fileThreatSubmission
  - `[HostSecurityProfileId <String>]`: key: id of hostSecurityProfile
  - `[IPSecurityProfileId <String>]`: key: id of ipSecurityProfile
  - `[IncidentId <String>]`: key: id of incident
  - `[ProviderTenantSettingId <String>]`: key: id of providerTenantSetting
  - `[RetentionEventId <String>]`: key: id of retentionEvent
  - `[RetentionEventTypeId <String>]`: key: id of retentionEventType
  - `[RetentionLabelId <String>]`: key: id of retentionLabel
  - `[SecureScoreControlProfileId <String>]`: key: id of secureScoreControlProfile
  - `[SecureScoreId <String>]`: key: id of secureScore
  - `[SecurityActionId <String>]`: key: id of securityAction
  - `[SensitivityLabelId <String>]`: key: id of sensitivityLabel
  - `[SimulationAutomationId <String>]`: key: id of simulationAutomation
  - `[SimulationAutomationRunId <String>]`: key: id of simulationAutomationRun
  - `[SimulationId <String>]`: key: id of simulation
  - `[SiteSourceId <String>]`: key: id of siteSource
  - `[SubjectRightsRequestId <String>]`: key: id of subjectRightsRequest
  - `[TiIndicatorId <String>]`: key: id of tiIndicator
  - `[UnifiedGroupSourceId <String>]`: key: id of unifiedGroupSource
  - `[UrlThreatSubmissionId <String>]`: key: id of urlThreatSubmission
  - `[UserSecurityProfileId <String>]`: key: id of userSecurityProfile
  - `[UserSourceId <String>]`: key: id of userSource

## RELATED LINKS

