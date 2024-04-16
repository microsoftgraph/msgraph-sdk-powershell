---
external help file:
Module Name: Microsoft.Graph.Beta.Security
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.security/update-mgbetasecurityruledetectionrule
schema: 2.0.0
---

# Update-MgBetaSecurityRuleDetectionRule

## SYNOPSIS
Update the navigation property detectionRules in security

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaSecurityRuleDetectionRule -DetectionRuleId <String> [-AdditionalProperties <Hashtable>]
 [-CreatedBy <String>] [-CreatedDateTime <DateTime>]
 [-DetectionAction <IMicrosoftGraphSecurityDetectionAction>] [-DetectorId <String>] [-DisplayName <String>]
 [-Id <String>] [-IsEnabled] [-LastModifiedBy <String>] [-LastModifiedDateTime <DateTime>]
 [-LastRunDetails <IMicrosoftGraphSecurityRunDetails>]
 [-QueryCondition <IMicrosoftGraphSecurityQueryCondition>] [-ResponseHeadersVariable <String>]
 [-Schedule <IMicrosoftGraphSecurityRuleSchedule>] [-Headers <IDictionary>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgBetaSecurityRuleDetectionRule -DetectionRuleId <String>
 -BodyParameter <IMicrosoftGraphSecurityDetectionRule> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBetaSecurityRuleDetectionRule -InputObject <ISecurityIdentity>
 -BodyParameter <IMicrosoftGraphSecurityDetectionRule> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBetaSecurityRuleDetectionRule -InputObject <ISecurityIdentity> [-AdditionalProperties <Hashtable>]
 [-CreatedBy <String>] [-CreatedDateTime <DateTime>]
 [-DetectionAction <IMicrosoftGraphSecurityDetectionAction>] [-DetectorId <String>] [-DisplayName <String>]
 [-Id <String>] [-IsEnabled] [-LastModifiedBy <String>] [-LastModifiedDateTime <DateTime>]
 [-LastRunDetails <IMicrosoftGraphSecurityRunDetails>]
 [-QueryCondition <IMicrosoftGraphSecurityQueryCondition>] [-ResponseHeadersVariable <String>]
 [-Schedule <IMicrosoftGraphSecurityRuleSchedule>] [-Headers <IDictionary>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property detectionRules in security

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
detectionRule
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecurityDetectionRule
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedBy
Name of the user or application that created the rule.

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
Timestamp of rule creation.

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

### -DetectionAction
detectionAction
To construct, see NOTES section for DETECTIONACTION properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecurityDetectionAction
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DetectionRuleId
The unique identifier of detectionRule

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

### -DetectorId
The ID of the detector that triggered the alert.
Also see the 'detectorId' field in microsoft.graph.security.alert.

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
Name of the rule.

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
Type: Microsoft.Graph.Beta.PowerShell.Models.ISecurityIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IsEnabled
Whether rule is turned on for the tenant.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastModifiedBy
Name of the user or application who last updated the rule.

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

### -LastModifiedDateTime
Timestamp of when the rule was last updated.

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

### -LastRunDetails
runDetails
To construct, see NOTES section for LASTRUNDETAILS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecurityRunDetails
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -QueryCondition
queryCondition
To construct, see NOTES section for QUERYCONDITION properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecurityQueryCondition
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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

### -Schedule
ruleSchedule
To construct, see NOTES section for SCHEDULE properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecurityRuleSchedule
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecurityDetectionRule

### Microsoft.Graph.Beta.PowerShell.Models.ISecurityIdentity

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecurityDetectionRule

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphSecurityDetectionRule>`: detectionRule
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CreatedBy <String>]`: Name of the user or application that created the rule.
  - `[CreatedDateTime <DateTime?>]`: Timestamp of rule creation.
  - `[DisplayName <String>]`: Name of the rule.
  - `[IsEnabled <Boolean?>]`: Whether rule is turned on for the tenant.
  - `[LastModifiedBy <String>]`: Name of the user or application who last updated the rule.
  - `[LastModifiedDateTime <DateTime?>]`: Timestamp of when the rule was last updated.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[DetectionAction <IMicrosoftGraphSecurityDetectionAction>]`: detectionAction
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AlertTemplate <IMicrosoftGraphSecurityAlertTemplate>]`: alertTemplate
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Category <String>]`: Category assigned to the alert triggered by the custom detection rule.
      - `[Description <String>]`: Description of the alert triggered by the custom detection rule.
      - `[ImpactedAssets <IMicrosoftGraphSecurityImpactedAsset[]>]`: Which asset or assets were impacted based on the alert triggered by the custom detection rule.
      - `[MitreTechniques <String[]>]`: MITRE technique assigned to the alert triggered by the custom detection rule.
      - `[RecommendedActions <String>]`: Recommended actions to mitigate the threat related to the alert triggered by the custom detection rule.
      - `[Severity <String>]`: alertSeverity
      - `[Title <String>]`: Name of the alert triggered by the custom detection rule.
    - `[OrganizationalScope <IMicrosoftGraphSecurityOrganizationalScope>]`: organizationalScope
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ScopeNames <String[]>]`: List of groups to which the custom detection rule applies.
      - `[ScopeType <String>]`: scopeType
    - `[ResponseActions <IMicrosoftGraphSecurityResponseAction[]>]`: Actions taken on impacted assets as set in the custom detection rule.
  - `[DetectorId <String>]`: The ID of the detector that triggered the alert. Also see the 'detectorId' field in microsoft.graph.security.alert.
  - `[LastRunDetails <IMicrosoftGraphSecurityRunDetails>]`: runDetails
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ErrorCode <String>]`: huntingRuleErrorCode
    - `[FailureReason <String>]`: Reason for failure when the custom detection last ran and failed. See the table below.
    - `[LastRunDateTime <DateTime?>]`: Timestamp when the custom detection was last run.
    - `[Status <String>]`: huntingRuleRunStatus
  - `[QueryCondition <IMicrosoftGraphSecurityQueryCondition>]`: queryCondition
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[LastModifiedDateTime <DateTime?>]`: Timestamp of when the query in the custom detection rule was last updated.
    - `[QueryText <String>]`: Contents of the query.
  - `[Schedule <IMicrosoftGraphSecurityRuleSchedule>]`: ruleSchedule
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[NextRunDateTime <DateTime?>]`: Timestamp of the custom detection rule's next scheduled run.
    - `[Period <String>]`: How often the detection rule is set to run. The allowed values are: 0, 1H, 3H, 12H, or 24H. '0' signifies the rule is run continuously.

`DETECTIONACTION <IMicrosoftGraphSecurityDetectionAction>`: detectionAction
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AlertTemplate <IMicrosoftGraphSecurityAlertTemplate>]`: alertTemplate
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Category <String>]`: Category assigned to the alert triggered by the custom detection rule.
    - `[Description <String>]`: Description of the alert triggered by the custom detection rule.
    - `[ImpactedAssets <IMicrosoftGraphSecurityImpactedAsset[]>]`: Which asset or assets were impacted based on the alert triggered by the custom detection rule.
    - `[MitreTechniques <String[]>]`: MITRE technique assigned to the alert triggered by the custom detection rule.
    - `[RecommendedActions <String>]`: Recommended actions to mitigate the threat related to the alert triggered by the custom detection rule.
    - `[Severity <String>]`: alertSeverity
    - `[Title <String>]`: Name of the alert triggered by the custom detection rule.
  - `[OrganizationalScope <IMicrosoftGraphSecurityOrganizationalScope>]`: organizationalScope
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ScopeNames <String[]>]`: List of groups to which the custom detection rule applies.
    - `[ScopeType <String>]`: scopeType
  - `[ResponseActions <IMicrosoftGraphSecurityResponseAction[]>]`: Actions taken on impacted assets as set in the custom detection rule.

`INPUTOBJECT <ISecurityIdentity>`: Identity Parameter
  - `[AlertId <String>]`: The unique identifier of alert
  - `[AnalyzedEmailId <String>]`: The unique identifier of analyzedEmail
  - `[ArticleId <String>]`: The unique identifier of article
  - `[ArticleIndicatorId <String>]`: The unique identifier of articleIndicator
  - `[AttackSimulationOperationId <String>]`: The unique identifier of attackSimulationOperation
  - `[AuditLogQueryId <String>]`: The unique identifier of auditLogQuery
  - `[AuditLogRecordId <String>]`: The unique identifier of auditLogRecord
  - `[AuthoredNoteId <String>]`: The unique identifier of authoredNote
  - `[AuthorityTemplateId <String>]`: The unique identifier of authorityTemplate
  - `[CaseOperationId <String>]`: The unique identifier of caseOperation
  - `[CategoryTemplateId <String>]`: The unique identifier of categoryTemplate
  - `[CitationTemplateId <String>]`: The unique identifier of citationTemplate
  - `[CloudAppSecurityProfileId <String>]`: The unique identifier of cloudAppSecurityProfile
  - `[DataSourceId <String>]`: The unique identifier of dataSource
  - `[DepartmentTemplateId <String>]`: The unique identifier of departmentTemplate
  - `[DetectionRuleId <String>]`: The unique identifier of detectionRule
  - `[DispositionReviewStageNumber <String>]`: The unique identifier of dispositionReviewStage
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
  - `[EndUserNotificationDetailId <String>]`: The unique identifier of endUserNotificationDetail
  - `[EndUserNotificationId <String>]`: The unique identifier of endUserNotification
  - `[FilePlanReferenceTemplateId <String>]`: The unique identifier of filePlanReferenceTemplate
  - `[FileSecurityProfileId <String>]`: The unique identifier of fileSecurityProfile
  - `[FileThreatSubmissionId <String>]`: The unique identifier of fileThreatSubmission
  - `[HealthIssueId <String>]`: The unique identifier of healthIssue
  - `[HostComponentId <String>]`: The unique identifier of hostComponent
  - `[HostCookieId <String>]`: The unique identifier of hostCookie
  - `[HostId <String>]`: The unique identifier of host
  - `[HostPairId <String>]`: The unique identifier of hostPair
  - `[HostPortId <String>]`: The unique identifier of hostPort
  - `[HostSecurityProfileId <String>]`: The unique identifier of hostSecurityProfile
  - `[HostSslCertificateId <String>]`: The unique identifier of hostSslCertificate
  - `[HostTrackerId <String>]`: The unique identifier of hostTracker
  - `[IPSecurityProfileId <String>]`: The unique identifier of ipSecurityProfile
  - `[IncidentId <String>]`: The unique identifier of incident
  - `[IntelligenceProfileId <String>]`: The unique identifier of intelligenceProfile
  - `[IntelligenceProfileIndicatorId <String>]`: The unique identifier of intelligenceProfileIndicator
  - `[LandingPageDetailId <String>]`: The unique identifier of landingPageDetail
  - `[LandingPageId <String>]`: The unique identifier of landingPage
  - `[LoginPageId <String>]`: The unique identifier of loginPage
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
  - `[SslCertificateId <String>]`: The unique identifier of sslCertificate
  - `[SubcategoryTemplateId <String>]`: The unique identifier of subcategoryTemplate
  - `[SubdomainId <String>]`: The unique identifier of subdomain
  - `[SubjectRightsRequestId <String>]`: The unique identifier of subjectRightsRequest
  - `[TiIndicatorId <String>]`: The unique identifier of tiIndicator
  - `[TrainingCampaignId <String>]`: The unique identifier of trainingCampaign
  - `[TrainingId <String>]`: The unique identifier of training
  - `[TrainingLanguageDetailId <String>]`: The unique identifier of trainingLanguageDetail
  - `[UnifiedGroupSourceId <String>]`: The unique identifier of unifiedGroupSource
  - `[UrlThreatSubmissionId <String>]`: The unique identifier of urlThreatSubmission
  - `[UserId <String>]`: The unique identifier of user
  - `[UserSecurityProfileId <String>]`: The unique identifier of userSecurityProfile
  - `[UserSourceId <String>]`: The unique identifier of userSource
  - `[VulnerabilityComponentId <String>]`: The unique identifier of vulnerabilityComponent
  - `[VulnerabilityId <String>]`: The unique identifier of vulnerability
  - `[WhoisHistoryRecordId <String>]`: The unique identifier of whoisHistoryRecord
  - `[WhoisRecordId <String>]`: The unique identifier of whoisRecord

`LASTRUNDETAILS <IMicrosoftGraphSecurityRunDetails>`: runDetails
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ErrorCode <String>]`: huntingRuleErrorCode
  - `[FailureReason <String>]`: Reason for failure when the custom detection last ran and failed. See the table below.
  - `[LastRunDateTime <DateTime?>]`: Timestamp when the custom detection was last run.
  - `[Status <String>]`: huntingRuleRunStatus

`QUERYCONDITION <IMicrosoftGraphSecurityQueryCondition>`: queryCondition
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[LastModifiedDateTime <DateTime?>]`: Timestamp of when the query in the custom detection rule was last updated.
  - `[QueryText <String>]`: Contents of the query.

`SCHEDULE <IMicrosoftGraphSecurityRuleSchedule>`: ruleSchedule
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[NextRunDateTime <DateTime?>]`: Timestamp of the custom detection rule's next scheduled run.
  - `[Period <String>]`: How often the detection rule is set to run. The allowed values are: 0, 1H, 3H, 12H, or 24H. '0' signifies the rule is run continuously.

## RELATED LINKS

