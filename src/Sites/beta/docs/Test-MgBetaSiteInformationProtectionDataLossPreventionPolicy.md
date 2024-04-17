---
external help file:
Module Name: Microsoft.Graph.Beta.Sites
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.sites/test-mgbetasiteinformationprotectiondatalosspreventionpolicy
schema: 2.0.0
---

# Test-MgBetaSiteInformationProtectionDataLossPreventionPolicy

## SYNOPSIS
Invoke action evaluate

## SYNTAX

### EvaluateExpanded (Default)
```
Test-MgBetaSiteInformationProtectionDataLossPreventionPolicy -SiteId <String>
 [-AdditionalProperties <Hashtable>] [-EvaluationInput <IMicrosoftGraphDlpEvaluationInput>]
 [-NotificationInfo <IMicrosoftGraphDlpNotification>] [-ResponseHeadersVariable <String>] [-Target <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Evaluate
```
Test-MgBetaSiteInformationProtectionDataLossPreventionPolicy -SiteId <String>
 -BodyParameter <IPathsJb4Y6TSitesSiteIdInformationprotectionDatalosspreventionpoliciesMicrosoftGraphEvaluatePostRequestbodyContentApplicationJsonSchema>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### EvaluateViaIdentity
```
Test-MgBetaSiteInformationProtectionDataLossPreventionPolicy -InputObject <ISitesIdentity>
 -BodyParameter <IPathsJb4Y6TSitesSiteIdInformationprotectionDatalosspreventionpoliciesMicrosoftGraphEvaluatePostRequestbodyContentApplicationJsonSchema>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### EvaluateViaIdentityExpanded
```
Test-MgBetaSiteInformationProtectionDataLossPreventionPolicy -InputObject <ISitesIdentity>
 [-AdditionalProperties <Hashtable>] [-EvaluationInput <IMicrosoftGraphDlpEvaluationInput>]
 [-NotificationInfo <IMicrosoftGraphDlpNotification>] [-ResponseHeadersVariable <String>] [-Target <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action evaluate

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
Parameter Sets: EvaluateExpanded, EvaluateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IPathsJb4Y6TSitesSiteIdInformationprotectionDatalosspreventionpoliciesMicrosoftGraphEvaluatePostRequestbodyContentApplicationJsonSchema
Parameter Sets: Evaluate, EvaluateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -EvaluationInput
dlpEvaluationInput
To construct, see NOTES section for EVALUATIONINPUT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDlpEvaluationInput
Parameter Sets: EvaluateExpanded, EvaluateViaIdentityExpanded
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

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.ISitesIdentity
Parameter Sets: EvaluateViaIdentity, EvaluateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -NotificationInfo
dlpNotification
To construct, see NOTES section for NOTIFICATIONINFO properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDlpNotification
Parameter Sets: EvaluateExpanded, EvaluateViaIdentityExpanded
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

### -SiteId
The unique identifier of site

```yaml
Type: System.String
Parameter Sets: Evaluate, EvaluateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Target
.

```yaml
Type: System.String
Parameter Sets: EvaluateExpanded, EvaluateViaIdentityExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IPathsJb4Y6TSitesSiteIdInformationprotectionDatalosspreventionpoliciesMicrosoftGraphEvaluatePostRequestbodyContentApplicationJsonSchema

### Microsoft.Graph.Beta.PowerShell.Models.ISitesIdentity

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDlpEvaluatePoliciesJobResponse

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IPathsJb4Y6TSitesSiteIdInformationprotectionDatalosspreventionpoliciesMicrosoftGraphEvaluatePostRequestbodyContentApplicationJsonSchema>`: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[EvaluationInput <IMicrosoftGraphDlpEvaluationInput>]`: dlpEvaluationInput
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[CurrentLabel <IMicrosoftGraphCurrentLabel>]`: currentLabel
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ApplicationMode <String>]`: applicationMode
      - `[Id <String>]`: 
    - `[DiscoveredSensitiveTypes <IMicrosoftGraphDiscoveredSensitiveType[]>]`: 
      - `[ClassificationAttributes <IMicrosoftGraphClassificationAttribute[]>]`: 
        - `[Confidence <Int32?>]`: 
        - `[Count <Int32?>]`: 
      - `[Confidence <Int32?>]`: 
      - `[Count <Int32?>]`: 
      - `[Id <String>]`: 
  - `[NotificationInfo <IMicrosoftGraphDlpNotification>]`: dlpNotification
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Author <String>]`: 
  - `[Target <String>]`: 

`EVALUATIONINPUT <IMicrosoftGraphDlpEvaluationInput>`: dlpEvaluationInput
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CurrentLabel <IMicrosoftGraphCurrentLabel>]`: currentLabel
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ApplicationMode <String>]`: applicationMode
    - `[Id <String>]`: 
  - `[DiscoveredSensitiveTypes <IMicrosoftGraphDiscoveredSensitiveType[]>]`: 
    - `[ClassificationAttributes <IMicrosoftGraphClassificationAttribute[]>]`: 
      - `[Confidence <Int32?>]`: 
      - `[Count <Int32?>]`: 
    - `[Confidence <Int32?>]`: 
    - `[Count <Int32?>]`: 
    - `[Id <String>]`: 

`INPUTOBJECT <ISitesIdentity>`: Identity Parameter
  - `[BaseItemId <String>]`: The unique identifier of baseItem
  - `[BaseSitePageId <String>]`: The unique identifier of baseSitePage
  - `[BitlockerRecoveryKeyId <String>]`: The unique identifier of bitlockerRecoveryKey
  - `[ColumnDefinitionId <String>]`: The unique identifier of columnDefinition
  - `[ColumnLinkId <String>]`: The unique identifier of columnLink
  - `[ContentTypeId <String>]`: The unique identifier of contentType
  - `[ContentTypeId1 <String>]`: The unique identifier of contentType
  - `[DataLossPreventionPolicyId <String>]`: The unique identifier of dataLossPreventionPolicy
  - `[DocumentSetVersionId <String>]`: The unique identifier of documentSetVersion
  - `[DriveId <String>]`: The unique identifier of drive
  - `[EndDateTime <String>]`: Usage: endDateTime='{endDateTime}'
  - `[GroupId <String>]`: The unique identifier of group
  - `[GroupId1 <String>]`: The unique identifier of group
  - `[HorizontalSectionColumnId <String>]`: The unique identifier of horizontalSectionColumn
  - `[HorizontalSectionId <String>]`: The unique identifier of horizontalSection
  - `[IncludePersonalNotebooks <Boolean?>]`: Usage: includePersonalNotebooks={includePersonalNotebooks}
  - `[InformationProtectionLabelId <String>]`: The unique identifier of informationProtectionLabel
  - `[Interval <String>]`: Usage: interval='{interval}'
  - `[ItemActivityId <String>]`: The unique identifier of itemActivity
  - `[ItemActivityOldId <String>]`: The unique identifier of itemActivityOLD
  - `[ItemActivityStatId <String>]`: The unique identifier of itemActivityStat
  - `[ListId <String>]`: The unique identifier of list
  - `[ListItemId <String>]`: The unique identifier of listItem
  - `[ListItemVersionId <String>]`: The unique identifier of listItemVersion
  - `[NotebookId <String>]`: The unique identifier of notebook
  - `[OnenoteOperationId <String>]`: The unique identifier of onenoteOperation
  - `[OnenotePageId <String>]`: The unique identifier of onenotePage
  - `[OnenoteResourceId <String>]`: The unique identifier of onenoteResource
  - `[OnenoteSectionId <String>]`: The unique identifier of onenoteSection
  - `[Path <String>]`: Usage: path='{path}'
  - `[Path1 <String>]`: Usage: path='{path1}'
  - `[PermissionId <String>]`: The unique identifier of permission
  - `[RecycleBinItemId <String>]`: The unique identifier of recycleBinItem
  - `[RelationId <String>]`: The unique identifier of relation
  - `[RichLongRunningOperationId <String>]`: The unique identifier of richLongRunningOperation
  - `[SectionGroupId <String>]`: The unique identifier of sectionGroup
  - `[SectionGroupId1 <String>]`: The unique identifier of sectionGroup
  - `[SensitivityLabelId <String>]`: The unique identifier of sensitivityLabel
  - `[SensitivityLabelId1 <String>]`: The unique identifier of sensitivityLabel
  - `[SetId <String>]`: The unique identifier of set
  - `[SetId1 <String>]`: The unique identifier of set
  - `[SiteId <String>]`: The unique identifier of site
  - `[SiteId1 <String>]`: The unique identifier of site
  - `[StartDateTime <String>]`: Usage: startDateTime='{startDateTime}'
  - `[SubscriptionId <String>]`: The unique identifier of subscription
  - `[TermId <String>]`: The unique identifier of term
  - `[TermId1 <String>]`: The unique identifier of term
  - `[ThreatAssessmentRequestId <String>]`: The unique identifier of threatAssessmentRequest
  - `[ThreatAssessmentResultId <String>]`: The unique identifier of threatAssessmentResult
  - `[Token <String>]`: Usage: token='{token}'
  - `[UserId <String>]`: The unique identifier of user
  - `[WebPartId <String>]`: The unique identifier of webPart

`NOTIFICATIONINFO <IMicrosoftGraphDlpNotification>`: dlpNotification
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Author <String>]`: 

## RELATED LINKS

