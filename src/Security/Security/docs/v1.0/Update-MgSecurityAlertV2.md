---
external help file:
Module Name: Microsoft.Graph.Security
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.security/update-mgsecurityalertv2
schema: 2.0.0
---

# Update-MgSecurityAlertV2

## SYNOPSIS
Update the navigation property alerts_v2 in security

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgSecurityAlertV2 -AlertId <String> [-ActorDisplayName <String>] [-AdditionalProperties <Hashtable>]
 [-AlertWebUrl <String>] [-AssignedTo <String>] [-Category <String>] [-Classification <String>]
 [-Comments <IMicrosoftGraphSecurityAlertComment[]>] [-CreatedDateTime <DateTime>] [-Description <String>]
 [-DetectionSource <String>] [-DetectorId <String>] [-Determination <String>]
 [-Evidence <IMicrosoftGraphSecurityAlertEvidence1[]>] [-FirstActivityDateTime <DateTime>] [-Id <String>]
 [-IncidentId <String>] [-IncidentWebUrl <String>] [-LastActivityDateTime <DateTime>]
 [-LastUpdateDateTime <DateTime>] [-MitreTechniques <String[]>] [-ProviderAlertId <String>]
 [-RecommendedActions <String>] [-ResolvedDateTime <DateTime>] [-ServiceSource <String>] [-Severity <String>]
 [-Status <String>] [-TenantId <String>] [-ThreatDisplayName <String>] [-ThreatFamilyName <String>]
 [-Title <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgSecurityAlertV2 -AlertId <String> -BodyParameter <IMicrosoftGraphSecurityAlert> [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgSecurityAlertV2 -InputObject <ISecurityIdentity> -BodyParameter <IMicrosoftGraphSecurityAlert>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgSecurityAlertV2 -InputObject <ISecurityIdentity> [-ActorDisplayName <String>]
 [-AdditionalProperties <Hashtable>] [-AlertWebUrl <String>] [-AssignedTo <String>] [-Category <String>]
 [-Classification <String>] [-Comments <IMicrosoftGraphSecurityAlertComment[]>] [-CreatedDateTime <DateTime>]
 [-Description <String>] [-DetectionSource <String>] [-DetectorId <String>] [-Determination <String>]
 [-Evidence <IMicrosoftGraphSecurityAlertEvidence1[]>] [-FirstActivityDateTime <DateTime>] [-Id <String>]
 [-IncidentId <String>] [-IncidentWebUrl <String>] [-LastActivityDateTime <DateTime>]
 [-LastUpdateDateTime <DateTime>] [-MitreTechniques <String[]>] [-ProviderAlertId <String>]
 [-RecommendedActions <String>] [-ResolvedDateTime <DateTime>] [-ServiceSource <String>] [-Severity <String>]
 [-Status <String>] [-TenantId <String>] [-ThreatDisplayName <String>] [-ThreatFamilyName <String>]
 [-Title <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property alerts_v2 in security

## EXAMPLES

## PARAMETERS

### -ActorDisplayName
The adversary or activity group that is associated with this alert.

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

### -AlertId
The unique identifier of alert

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

### -AlertWebUrl
URL for the alert page in the Microsoft 365 Defender portal.

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

### -AssignedTo
Owner of the alert, or null if no owner is assigned.

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
alert
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityAlert
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Category
The attack kill-chain category that the alert belongs to.
Aligned with the MITRE ATT&CK framework.

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
Array of comments created by the Security Operations (SecOps) team during the alert management process.
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
Time when Microsoft 365 Defender created the alert.

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

### -Description
String value describing each alert.

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

### -DetectionSource
detectionSource

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

### -DetectorId
The ID of the detector that triggered the alert.

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

### -Evidence
Collection of evidence related to the alert.
To construct, please use Get-Help -Online and see NOTES section for EVIDENCE properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityAlertEvidence1[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FirstActivityDateTime
The earliest activity associated with the alert.

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

### -IncidentId
Unique identifier to represent the incident this alert resource is associated with.

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

### -IncidentWebUrl
URL for the incident page in the Microsoft 365 Defender portal.

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

### -LastActivityDateTime
The oldest activity associated with the alert.

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

### -LastUpdateDateTime
Time when the alert was last updated at Microsoft 365 Defender.

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

### -MitreTechniques
The attack techniques, as aligned with the MITRE ATT&CK framework.

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

### -ProviderAlertId
The ID of the alert as it appears in the security provider product that generated the alert.

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

### -RecommendedActions
Recommended response and remediation actions to take in the event this alert was generated.

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

### -ResolvedDateTime
Time when the alert was resolved.

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

### -ServiceSource
serviceSource

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
The Azure Active Directory tenant the alert was created in.

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

### -ThreatDisplayName
The threat associated with this alert.

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

### -ThreatFamilyName
Threat family associated with this alert.

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
Brief identifying string value describing the alert.

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityAlert

### Microsoft.Graph.PowerShell.Models.ISecurityIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphSecurityAlert>: alert
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
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

COMMENTS <IMicrosoftGraphSecurityAlertComment[]>: Array of comments created by the Security Operations (SecOps) team during the alert management process.
  - `[Comment <String>]`: The comment text.
  - `[CreatedByDisplayName <String>]`: The person or app name that submitted the comment.
  - `[CreatedDateTime <DateTime?>]`: The time when the comment was submitted.

EVIDENCE <IMicrosoftGraphSecurityAlertEvidence1[]>: Collection of evidence related to the alert.
  - `[CreatedDateTime <DateTime?>]`: The time the evidence was created and added to the alert.
  - `[RemediationStatus <String>]`: evidenceRemediationStatus
  - `[RemediationStatusDetails <String>]`: Details about the remediation status.
  - `[Roles <String[]>]`: The role/s that an evidence entity represents in an alert, e.g., an IP address that is associated with an attacker will have the evidence role 'Attacker'.
  - `[Tags <String[]>]`: Array of custom tags associated with an evidence instance, for example to denote a group of devices, high value assets, etc.
  - `[Verdict <String>]`: evidenceVerdict

INPUTOBJECT <ISecurityIdentity>: Identity Parameter
  - `[AlertId <String>]`: The unique identifier of alert
  - `[ArticleId <String>]`: The unique identifier of article
  - `[ArticleIndicatorId <String>]`: The unique identifier of articleIndicator
  - `[AttackSimulationOperationId <String>]`: The unique identifier of attackSimulationOperation
  - `[AuthoredNoteId <String>]`: The unique identifier of authoredNote
  - `[CaseOperationId <String>]`: The unique identifier of caseOperation
  - `[CloudAppSecurityProfileId <String>]`: The unique identifier of cloudAppSecurityProfile
  - `[DataSourceId <String>]`: The unique identifier of dataSource
  - `[DispositionReviewStageId <String>]`: The unique identifier of dispositionReviewStage
  - `[DomainSecurityProfileId <String>]`: The unique identifier of domainSecurityProfile
  - `[EdiscoveryCaseId <String>]`: The unique identifier of ediscoveryCase
  - `[EdiscoveryCustodianId <String>]`: The unique identifier of ediscoveryCustodian
  - `[EdiscoveryFileId <String>]`: The unique identifier of ediscoveryFile
  - `[EdiscoveryHoldPolicyId <String>]`: The unique identifier of ediscoveryHoldPolicy
  - `[EdiscoveryNoncustodialDataSourceId <String>]`: The unique identifier of ediscoveryNoncustodialDataSource
  - `[EdiscoveryReviewSetId <String>]`: The unique identifier of ediscoveryReviewSet
  - `[EdiscoveryReviewSetQueryId <String>]`: The unique identifier of ediscoveryReviewSetQuery
  - `[EdiscoveryReviewTagId <String>]`: The unique identifier of ediscoveryReviewTag
  - `[EdiscoveryReviewTagId1 <String>]`: The unique identifier of ediscoveryReviewTag
  - `[EdiscoverySearchId <String>]`: The unique identifier of ediscoverySearch
  - `[EmailThreatSubmissionId <String>]`: The unique identifier of emailThreatSubmission
  - `[EmailThreatSubmissionPolicyId <String>]`: The unique identifier of emailThreatSubmissionPolicy
  - `[FileSecurityProfileId <String>]`: The unique identifier of fileSecurityProfile
  - `[FileThreatSubmissionId <String>]`: The unique identifier of fileThreatSubmission
  - `[HostComponentId <String>]`: The unique identifier of hostComponent
  - `[HostCookieId <String>]`: The unique identifier of hostCookie
  - `[HostId <String>]`: The unique identifier of host
  - `[HostSecurityProfileId <String>]`: The unique identifier of hostSecurityProfile
  - `[HostTrackerId <String>]`: The unique identifier of hostTracker
  - `[IPSecurityProfileId <String>]`: The unique identifier of ipSecurityProfile
  - `[IncidentId <String>]`: The unique identifier of incident
  - `[IntelligenceProfileId <String>]`: The unique identifier of intelligenceProfile
  - `[IntelligenceProfileIndicatorId <String>]`: The unique identifier of intelligenceProfileIndicator
  - `[PassiveDnsRecordId <String>]`: The unique identifier of passiveDnsRecord
  - `[PayloadId <String>]`: The unique identifier of payload
  - `[ProviderTenantSettingId <String>]`: The unique identifier of providerTenantSetting
  - `[RetentionEventId <String>]`: The unique identifier of retentionEvent
  - `[RetentionEventTypeId <String>]`: The unique identifier of retentionEventType
  - `[RetentionLabelId <String>]`: The unique identifier of retentionLabel
  - `[SecureScoreControlProfileId <String>]`: The unique identifier of secureScoreControlProfile
  - `[SecureScoreId <String>]`: The unique identifier of secureScore
  - `[SecurityActionId <String>]`: The unique identifier of securityAction
  - `[SensitivityLabelId <String>]`: The unique identifier of sensitivityLabel
  - `[SimulationAutomationId <String>]`: The unique identifier of simulationAutomation
  - `[SimulationAutomationRunId <String>]`: The unique identifier of simulationAutomationRun
  - `[SimulationId <String>]`: The unique identifier of simulation
  - `[SiteSourceId <String>]`: The unique identifier of siteSource
  - `[SubjectRightsRequestId <String>]`: The unique identifier of subjectRightsRequest
  - `[TiIndicatorId <String>]`: The unique identifier of tiIndicator
  - `[UnifiedGroupSourceId <String>]`: The unique identifier of unifiedGroupSource
  - `[UrlThreatSubmissionId <String>]`: The unique identifier of urlThreatSubmission
  - `[UserId <String>]`: The unique identifier of user
  - `[UserSecurityProfileId <String>]`: The unique identifier of userSecurityProfile
  - `[UserSourceId <String>]`: The unique identifier of userSource
  - `[VulnerabilityComponentId <String>]`: The unique identifier of vulnerabilityComponent
  - `[VulnerabilityId <String>]`: The unique identifier of vulnerability

## RELATED LINKS

