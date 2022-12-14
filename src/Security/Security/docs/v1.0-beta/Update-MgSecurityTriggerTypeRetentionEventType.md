---
external help file:
Module Name: Microsoft.Graph.Beta.Security
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.security/update-mgsecuritytriggertyperetentioneventtype
schema: 2.0.0
---

# Update-MgBetaSecurityTriggerTypeRetentionEventType

## SYNOPSIS
Update the navigation property retentionEventTypes in security

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaSecurityTriggerTypeRetentionEventType -RetentionEventTypeId <String>
 [-AdditionalProperties <Hashtable>] [-CreatedBy <IMicrosoftGraphIdentitySet>] [-CreatedDateTime <DateTime>]
 [-Description <String>] [-DisplayName <String>] [-Id <String>] [-LastModifiedBy <IMicrosoftGraphIdentitySet>]
 [-LastModifiedDateTime <DateTime>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaSecurityTriggerTypeRetentionEventType -RetentionEventTypeId <String>
 -BodyParameter <IMicrosoftGraphSecurityRetentionEventType> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBetaSecurityTriggerTypeRetentionEventType -InputObject <ISecurityIdentity>
 -BodyParameter <IMicrosoftGraphSecurityRetentionEventType> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBetaSecurityTriggerTypeRetentionEventType -InputObject <ISecurityIdentity>
 [-AdditionalProperties <Hashtable>] [-CreatedBy <IMicrosoftGraphIdentitySet>] [-CreatedDateTime <DateTime>]
 [-Description <String>] [-DisplayName <String>] [-Id <String>] [-LastModifiedBy <IMicrosoftGraphIdentitySet>]
 [-LastModifiedDateTime <DateTime>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property retentionEventTypes in security

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

### -BodyParameter
retentionEventType
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecurityRetentionEventType
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedBy
identitySet
To construct, please use Get-Help -Online and see NOTES section for CREATEDBY properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphIdentitySet
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedDateTime
The date time when the retentionEventType was created.

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
Optional information about the event type.

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
Name of the event type.

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
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

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

### -LastModifiedBy
identitySet
To construct, please use Get-Help -Online and see NOTES section for LASTMODIFIEDBY properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphIdentitySet
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastModifiedDateTime
The latest date time when the retentionEventType was modified.

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

### -RetentionEventTypeId
key: id of retentionEventType

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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecurityRetentionEventType

### Microsoft.Graph.Beta.PowerShell.Models.ISecurityIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphSecurityRetentionEventType>: retentionEventType
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: The date time when the retentionEventType was created.
  - `[Description <String>]`: Optional information about the event type.
  - `[DisplayName <String>]`: Name of the event type.
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: The latest date time when the retentionEventType was modified.

CREATEDBY <IMicrosoftGraphIdentitySet>: identitySet
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

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

LASTMODIFIEDBY <IMicrosoftGraphIdentitySet>: identitySet
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

## RELATED LINKS

