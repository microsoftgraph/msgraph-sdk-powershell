---
external help file:
Module Name: Microsoft.Graph.Beta.Security
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.security/update-mgbetasecuritysubjectrightsrequestcollaboratormailboxsetting
schema: 2.0.0
---

# Update-MgBetaSecuritySubjectRightsRequestCollaboratorMailboxSetting

## SYNOPSIS
Update property mailboxSettings value.

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaSecuritySubjectRightsRequestCollaboratorMailboxSetting -SubjectRightsRequestId <String>
 -UserId <String> [-AdditionalProperties <Hashtable>] [-ArchiveFolder <String>]
 [-AutomaticRepliesSetting <IMicrosoftGraphAutomaticRepliesSetting>] [-DateFormat <String>]
 [-DelegateMeetingMessageDeliveryOptions <String>] [-Language <IMicrosoftGraphLocaleInfo>]
 [-TimeFormat <String>] [-TimeZone <String>] [-UserPurpose <String>] [-UserPurposeV2 <String>]
 [-WorkingHours <IMicrosoftGraphWorkingHours>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaSecuritySubjectRightsRequestCollaboratorMailboxSetting -SubjectRightsRequestId <String>
 -UserId <String> -BodyParameter <IMicrosoftGraphMailboxSettings> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBetaSecuritySubjectRightsRequestCollaboratorMailboxSetting -InputObject <ISecurityIdentity>
 -BodyParameter <IMicrosoftGraphMailboxSettings> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBetaSecuritySubjectRightsRequestCollaboratorMailboxSetting -InputObject <ISecurityIdentity>
 [-AdditionalProperties <Hashtable>] [-ArchiveFolder <String>]
 [-AutomaticRepliesSetting <IMicrosoftGraphAutomaticRepliesSetting>] [-DateFormat <String>]
 [-DelegateMeetingMessageDeliveryOptions <String>] [-Language <IMicrosoftGraphLocaleInfo>]
 [-TimeFormat <String>] [-TimeZone <String>] [-UserPurpose <String>] [-UserPurposeV2 <String>]
 [-WorkingHours <IMicrosoftGraphWorkingHours>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update property mailboxSettings value.

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

### -ArchiveFolder
Folder ID of an archive folder for the user.
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

### -AutomaticRepliesSetting
automaticRepliesSetting
To construct, see NOTES section for AUTOMATICREPLIESSETTING properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAutomaticRepliesSetting
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
mailboxSettings
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphMailboxSettings
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DateFormat
The date format for the user's mailbox.

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

### -DelegateMeetingMessageDeliveryOptions
delegateMeetingMessageDeliveryOptions

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

### -Language
localeInfo
To construct, see NOTES section for LANGUAGE properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphLocaleInfo
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubjectRightsRequestId
The unique identifier of subjectRightsRequest

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

### -TimeFormat
The time format for the user's mailbox.

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

### -TimeZone
The default time zone for the user's mailbox.

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

### -UserId
The unique identifier of user

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

### -UserPurpose
userPurpose

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

### -UserPurposeV2
mailboxRecipientType

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

### -WorkingHours
workingHours
To construct, see NOTES section for WORKINGHOURS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphWorkingHours
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphMailboxSettings

### Microsoft.Graph.Beta.PowerShell.Models.ISecurityIdentity

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphMailboxSettings

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`AUTOMATICREPLIESSETTING <IMicrosoftGraphAutomaticRepliesSetting>`: automaticRepliesSetting
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ExternalAudience <String>]`: externalAudienceScope
  - `[ExternalReplyMessage <String>]`: The automatic reply to send to the specified external audience, if Status is AlwaysEnabled or Scheduled.
  - `[InternalReplyMessage <String>]`: The automatic reply to send to the audience internal to the signed-in user's organization, if Status is AlwaysEnabled or Scheduled.
  - `[ScheduledEndDateTime <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}). For example, '2019-04-16T09:00:00'.
    - `[TimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for possible values.
  - `[ScheduledStartDateTime <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
  - `[Status <String>]`: automaticRepliesStatus

`BODYPARAMETER <IMicrosoftGraphMailboxSettings>`: mailboxSettings
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ArchiveFolder <String>]`: Folder ID of an archive folder for the user. Read-only.
  - `[AutomaticRepliesSetting <IMicrosoftGraphAutomaticRepliesSetting>]`: automaticRepliesSetting
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ExternalAudience <String>]`: externalAudienceScope
    - `[ExternalReplyMessage <String>]`: The automatic reply to send to the specified external audience, if Status is AlwaysEnabled or Scheduled.
    - `[InternalReplyMessage <String>]`: The automatic reply to send to the audience internal to the signed-in user's organization, if Status is AlwaysEnabled or Scheduled.
    - `[ScheduledEndDateTime <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}). For example, '2019-04-16T09:00:00'.
      - `[TimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for possible values.
    - `[ScheduledStartDateTime <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
    - `[Status <String>]`: automaticRepliesStatus
  - `[DateFormat <String>]`: The date format for the user's mailbox.
  - `[DelegateMeetingMessageDeliveryOptions <String>]`: delegateMeetingMessageDeliveryOptions
  - `[Language <IMicrosoftGraphLocaleInfo>]`: localeInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: A name representing the user's locale in natural language, for example, 'English (United States)'.
    - `[Locale <String>]`: A locale representation for the user, which includes the user's preferred language and country/region. For example, 'en-us'. The language component follows 2-letter codes as defined in ISO 639-1, and the country component follows 2-letter codes as defined in ISO 3166-1 alpha-2.
  - `[TimeFormat <String>]`: The time format for the user's mailbox.
  - `[TimeZone <String>]`: The default time zone for the user's mailbox.
  - `[UserPurpose <String>]`: userPurpose
  - `[UserPurposeV2 <String>]`: mailboxRecipientType
  - `[WorkingHours <IMicrosoftGraphWorkingHours>]`: workingHours
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DaysOfWeek <String[]>]`: The days of the week on which the user works.
    - `[EndTime <String>]`: The time of the day that the user stops working.
    - `[StartTime <String>]`: The time of the day that the user starts working.
    - `[TimeZone <IMicrosoftGraphTimeZoneBase>]`: timeZoneBase
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Name <String>]`: The name of a time zone. It can be a standard time zone name such as 'Hawaii-Aleutian Standard Time', or 'Customized Time Zone' for a custom time zone.

`INPUTOBJECT <ISecurityIdentity>`: Identity Parameter
  - `[AlertId <String>]`: The unique identifier of alert
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
  - `[EndUserNotificationDetailId <String>]`: The unique identifier of endUserNotificationDetail
  - `[EndUserNotificationId <String>]`: The unique identifier of endUserNotification
  - `[FilePlanReferenceTemplateId <String>]`: The unique identifier of filePlanReferenceTemplate
  - `[FileSecurityProfileId <String>]`: The unique identifier of fileSecurityProfile
  - `[FileThreatSubmissionId <String>]`: The unique identifier of fileThreatSubmission
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
  - `[SubCategoryTemplateId <String>]`: The unique identifier of subCategoryTemplate
  - `[SubdomainId <String>]`: The unique identifier of subdomain
  - `[SubjectRightsRequestId <String>]`: The unique identifier of subjectRightsRequest
  - `[TiIndicatorId <String>]`: The unique identifier of tiIndicator
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

`LANGUAGE <IMicrosoftGraphLocaleInfo>`: localeInfo
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DisplayName <String>]`: A name representing the user's locale in natural language, for example, 'English (United States)'.
  - `[Locale <String>]`: A locale representation for the user, which includes the user's preferred language and country/region. For example, 'en-us'. The language component follows 2-letter codes as defined in ISO 639-1, and the country component follows 2-letter codes as defined in ISO 3166-1 alpha-2.

`WORKINGHOURS <IMicrosoftGraphWorkingHours>`: workingHours
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DaysOfWeek <String[]>]`: The days of the week on which the user works.
  - `[EndTime <String>]`: The time of the day that the user stops working.
  - `[StartTime <String>]`: The time of the day that the user starts working.
  - `[TimeZone <IMicrosoftGraphTimeZoneBase>]`: timeZoneBase
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Name <String>]`: The name of a time zone. It can be a standard time zone name such as 'Hawaii-Aleutian Standard Time', or 'Customized Time Zone' for a custom time zone.

## RELATED LINKS

