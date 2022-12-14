---
external help file:
Module Name: Microsoft.Graph.Beta.Security
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.security/clear-mgsecuritycaseediscoverycasesearchdata
schema: 2.0.0
---

# Clear-MgBetaSecurityCaseEdiscoveryCaseSearchData

## SYNOPSIS
Permanently delete Microsoft Teams messages contained in a eDiscovery search.
You can collect and purge the following categories of Teams content:\n- **Teams 1:1 chats** - Chat messages, posts, and attachments shared in a Teams conversation between two people.
Teams 1:1 chats are also called *conversations*.\n- **Teams group chats** - Chat messages, posts, and attachments shared in a Teams conversation between three or more people.
Also called *1:N* chats or *group conversations*.\n- **Teams channels** - Chat messages, posts, replies, and attachments shared in a standard Teams channel.\n- **Private channels** - Message posts, replies, and attachments shared in a private Teams channel.\n- **Shared channels** - Message posts, replies, and attachments shared in a shared Teams channel.
For more information about purging Teams messages, see:\n- eDiscovery solution series: Data spillage scenario - Search and purge\n- eDiscovery (Premium) workflow for content in Microsoft Teams

## SYNTAX

### PurgeExpanded (Default)
```
Clear-MgBetaSecurityCaseEdiscoveryCaseSearchData -EdiscoveryCaseId <String> -EdiscoverySearchId <String>
 [-AdditionalProperties <Hashtable>] [-PurgeAreas <String>] [-PurgeType <String>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Purge
```
Clear-MgBetaSecurityCaseEdiscoveryCaseSearchData -EdiscoveryCaseId <String> -EdiscoverySearchId <String>
 -BodyParameter <IPathsMs4I8WSecurityCasesEdiscoverycasesEdiscoverycaseIdSearchesEdiscoverysearchIdMicrosoftGraphSecurityPurgedataPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### PurgeViaIdentity
```
Clear-MgBetaSecurityCaseEdiscoveryCaseSearchData -InputObject <ISecurityIdentity>
 -BodyParameter <IPathsMs4I8WSecurityCasesEdiscoverycasesEdiscoverycaseIdSearchesEdiscoverysearchIdMicrosoftGraphSecurityPurgedataPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### PurgeViaIdentityExpanded
```
Clear-MgBetaSecurityCaseEdiscoveryCaseSearchData -InputObject <ISecurityIdentity>
 [-AdditionalProperties <Hashtable>] [-PurgeAreas <String>] [-PurgeType <String>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Permanently delete Microsoft Teams messages contained in a eDiscovery search.
You can collect and purge the following categories of Teams content:\n- **Teams 1:1 chats** - Chat messages, posts, and attachments shared in a Teams conversation between two people.
Teams 1:1 chats are also called *conversations*.\n- **Teams group chats** - Chat messages, posts, and attachments shared in a Teams conversation between three or more people.
Also called *1:N* chats or *group conversations*.\n- **Teams channels** - Chat messages, posts, replies, and attachments shared in a standard Teams channel.\n- **Private channels** - Message posts, replies, and attachments shared in a private Teams channel.\n- **Shared channels** - Message posts, replies, and attachments shared in a shared Teams channel.
For more information about purging Teams messages, see:\n- eDiscovery solution series: Data spillage scenario - Search and purge\n- eDiscovery (Premium) workflow for content in Microsoft Teams

## EXAMPLES

### Example 1: Using the Clear-MgBetaSecurityCaseEdiscoveryCaseSearchData Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Security
Clear-MgBetaSecurityCaseEdiscoveryCaseSearchData -EdiscoveryCaseId $ediscoveryCaseId -EdiscoverySearchId $ediscoverySearchId
```

This example shows how to use the Clear-MgBetaSecurityCaseEdiscoveryCaseSearchData Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: PurgeExpanded, PurgeViaIdentityExpanded
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IPathsMs4I8WSecurityCasesEdiscoverycasesEdiscoverycaseIdSearchesEdiscoverysearchIdMicrosoftGraphSecurityPurgedataPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Purge, PurgeViaIdentity
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
Parameter Sets: Purge, PurgeExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EdiscoverySearchId
key: id of ediscoverySearch

```yaml
Type: System.String
Parameter Sets: Purge, PurgeExpanded
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
Type: Microsoft.Graph.Beta.PowerShell.Models.ISecurityIdentity
Parameter Sets: PurgeViaIdentity, PurgeViaIdentityExpanded
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

### -PurgeAreas
purgeAreas

```yaml
Type: System.String
Parameter Sets: PurgeExpanded, PurgeViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PurgeType
purgeType

```yaml
Type: System.String
Parameter Sets: PurgeExpanded, PurgeViaIdentityExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IPathsMs4I8WSecurityCasesEdiscoverycasesEdiscoverycaseIdSearchesEdiscoverysearchIdMicrosoftGraphSecurityPurgedataPostRequestbodyContentApplicationJsonSchema

### Microsoft.Graph.Beta.PowerShell.Models.ISecurityIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPathsMs4I8WSecurityCasesEdiscoverycasesEdiscoverycaseIdSearchesEdiscoverysearchIdMicrosoftGraphSecurityPurgedataPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[PurgeAreas <String>]`: purgeAreas
  - `[PurgeType <String>]`: purgeType

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

