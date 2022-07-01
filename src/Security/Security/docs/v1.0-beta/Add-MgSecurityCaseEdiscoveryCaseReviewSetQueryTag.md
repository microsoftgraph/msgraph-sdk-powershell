---
external help file:
Module Name: Microsoft.Graph.Security
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.security/add-mgsecuritycaseediscoverycasereviewsetquerytag
schema: 2.0.0
---

# Add-MgSecurityCaseEdiscoveryCaseReviewSetQueryTag

## SYNOPSIS
Invoke action applyTags

## SYNTAX

### ApplyExpanded (Default)
```
Add-MgSecurityCaseEdiscoveryCaseReviewSetQueryTag -EdiscoveryCaseId <String> -EdiscoveryReviewSetId <String>
 -EdiscoveryReviewSetQueryId <String> [-AdditionalProperties <Hashtable>]
 [-TagsToAdd <IMicrosoftGraphSecurityEdiscoveryReviewTag[]>]
 [-TagsToRemove <IMicrosoftGraphSecurityEdiscoveryReviewTag[]>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Apply
```
Add-MgSecurityCaseEdiscoveryCaseReviewSetQueryTag -EdiscoveryCaseId <String> -EdiscoveryReviewSetId <String>
 -EdiscoveryReviewSetQueryId <String>
 -BodyParameter <IPathsA2Ja7OSecurityCasesEdiscoverycasesEdiscoverycaseIdReviewsetsEdiscoveryreviewsetIdQueriesEdiscoveryreviewsetqueryIdMicrosoftGraphSecurityApplytagsPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ApplyViaIdentity
```
Add-MgSecurityCaseEdiscoveryCaseReviewSetQueryTag -InputObject <ISecurityIdentity>
 -BodyParameter <IPathsA2Ja7OSecurityCasesEdiscoverycasesEdiscoverycaseIdReviewsetsEdiscoveryreviewsetIdQueriesEdiscoveryreviewsetqueryIdMicrosoftGraphSecurityApplytagsPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ApplyViaIdentityExpanded
```
Add-MgSecurityCaseEdiscoveryCaseReviewSetQueryTag -InputObject <ISecurityIdentity>
 [-AdditionalProperties <Hashtable>] [-TagsToAdd <IMicrosoftGraphSecurityEdiscoveryReviewTag[]>]
 [-TagsToRemove <IMicrosoftGraphSecurityEdiscoveryReviewTag[]>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Invoke action applyTags

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: ApplyExpanded, ApplyViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IPathsA2Ja7OSecurityCasesEdiscoverycasesEdiscoverycaseIdReviewsetsEdiscoveryreviewsetIdQueriesEdiscoveryreviewsetqueryIdMicrosoftGraphSecurityApplytagsPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Apply, ApplyViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -EdiscoveryCaseId
key: id of ediscoveryCase

```yaml
Type: System.String
Parameter Sets: Apply, ApplyExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EdiscoveryReviewSetId
key: id of ediscoveryReviewSet

```yaml
Type: System.String
Parameter Sets: Apply, ApplyExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EdiscoveryReviewSetQueryId
key: id of ediscoveryReviewSetQuery

```yaml
Type: System.String
Parameter Sets: Apply, ApplyExpanded
Aliases:

Required: True
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
Parameter Sets: ApplyViaIdentity, ApplyViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### -TagsToAdd
.
To construct, please use Get-Help -Online and see NOTES section for TAGSTOADD properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityEdiscoveryReviewTag[]
Parameter Sets: ApplyExpanded, ApplyViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TagsToRemove
.
To construct, please use Get-Help -Online and see NOTES section for TAGSTOREMOVE properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityEdiscoveryReviewTag[]
Parameter Sets: ApplyExpanded, ApplyViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IPathsA2Ja7OSecurityCasesEdiscoverycasesEdiscoverycaseIdReviewsetsEdiscoveryreviewsetIdQueriesEdiscoveryreviewsetqueryIdMicrosoftGraphSecurityApplytagsPostRequestbodyContentApplicationJsonSchema

### Microsoft.Graph.PowerShell.Models.ISecurityIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPathsA2Ja7OSecurityCasesEdiscoverycasesEdiscoverycaseIdReviewsetsEdiscoveryreviewsetIdQueriesEdiscoveryreviewsetqueryIdMicrosoftGraphSecurityApplytagsPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[TagsToAdd <IMicrosoftGraphSecurityEdiscoveryReviewTag[]>]`: 
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Application <IMicrosoftGraphIdentity>]`: identity
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
        - `[Id <String>]`: Unique identifier for the identity.
      - `[Device <IMicrosoftGraphIdentity>]`: identity
      - `[User <IMicrosoftGraphIdentity>]`: identity
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Id <String>]`: 
    - `[ChildSelectability <String>]`: childSelectability
    - `[ChildTags <IMicrosoftGraphSecurityEdiscoveryReviewTag[]>]`: Returns the tags that are a child of a tag.
    - `[Parent <IMicrosoftGraphSecurityEdiscoveryReviewTag>]`: ediscoveryReviewTag
  - `[TagsToRemove <IMicrosoftGraphSecurityEdiscoveryReviewTag[]>]`: 

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
  - `[FileSecurityProfileId <String>]`: key: id of fileSecurityProfile
  - `[HostSecurityProfileId <String>]`: key: id of hostSecurityProfile
  - `[IPSecurityProfileId <String>]`: key: id of ipSecurityProfile
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
  - `[UserSecurityProfileId <String>]`: key: id of userSecurityProfile
  - `[UserSourceId <String>]`: key: id of userSource

TAGSTOADD <IMicrosoftGraphSecurityEdiscoveryReviewTag[]>: .
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: 
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Id <String>]`: 
  - `[ChildSelectability <String>]`: childSelectability
  - `[ChildTags <IMicrosoftGraphSecurityEdiscoveryReviewTag[]>]`: Returns the tags that are a child of a tag.
  - `[Parent <IMicrosoftGraphSecurityEdiscoveryReviewTag>]`: ediscoveryReviewTag

TAGSTOREMOVE <IMicrosoftGraphSecurityEdiscoveryReviewTag[]>: .
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: 
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Id <String>]`: 
  - `[ChildSelectability <String>]`: childSelectability
  - `[ChildTags <IMicrosoftGraphSecurityEdiscoveryReviewTag[]>]`: Returns the tags that are a child of a tag.
  - `[Parent <IMicrosoftGraphSecurityEdiscoveryReviewTag>]`: ediscoveryReviewTag

## RELATED LINKS

