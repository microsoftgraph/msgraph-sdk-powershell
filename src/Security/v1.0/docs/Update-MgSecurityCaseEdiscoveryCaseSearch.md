---
external help file:
Module Name: Microsoft.Graph.Security
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.security/update-mgsecuritycaseediscoverycasesearch
schema: 2.0.0
---

# Update-MgSecurityCaseEdiscoveryCaseSearch

## SYNOPSIS
Update the properties of an ediscoverySearch object.

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgSecurityCaseEdiscoveryCaseSearch -EdiscoveryCaseId <String> -EdiscoverySearchId <String>
 [-AdditionalProperties <Hashtable>] [-AdditionalSources <IMicrosoftGraphSecurityDataSource[]>]
 [-AddToReviewSetOperation <IMicrosoftGraphSecurityEdiscoveryAddToReviewSetOperation>]
 [-ContentQuery <String>] [-CreatedBy <IMicrosoftGraphIdentitySet>] [-CreatedDateTime <DateTime>]
 [-CustodianSources <IMicrosoftGraphSecurityDataSource[]>] [-DataSourceScopes <String>]
 [-Description <String>] [-DisplayName <String>] [-Id <String>]
 [-LastEstimateStatisticsOperation <IMicrosoftGraphSecurityEdiscoveryEstimateOperation>]
 [-LastModifiedBy <IMicrosoftGraphIdentitySet>] [-LastModifiedDateTime <DateTime>]
 [-NoncustodialSources <IMicrosoftGraphSecurityEdiscoveryNoncustodialDataSource[]>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgSecurityCaseEdiscoveryCaseSearch -EdiscoveryCaseId <String> -EdiscoverySearchId <String>
 -BodyParameter <IMicrosoftGraphSecurityEdiscoverySearch> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgSecurityCaseEdiscoveryCaseSearch -InputObject <ISecurityIdentity>
 -BodyParameter <IMicrosoftGraphSecurityEdiscoverySearch> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgSecurityCaseEdiscoveryCaseSearch -InputObject <ISecurityIdentity> [-AdditionalProperties <Hashtable>]
 [-AdditionalSources <IMicrosoftGraphSecurityDataSource[]>]
 [-AddToReviewSetOperation <IMicrosoftGraphSecurityEdiscoveryAddToReviewSetOperation>]
 [-ContentQuery <String>] [-CreatedBy <IMicrosoftGraphIdentitySet>] [-CreatedDateTime <DateTime>]
 [-CustodianSources <IMicrosoftGraphSecurityDataSource[]>] [-DataSourceScopes <String>]
 [-Description <String>] [-DisplayName <String>] [-Id <String>]
 [-LastEstimateStatisticsOperation <IMicrosoftGraphSecurityEdiscoveryEstimateOperation>]
 [-LastModifiedBy <IMicrosoftGraphIdentitySet>] [-LastModifiedDateTime <DateTime>]
 [-NoncustodialSources <IMicrosoftGraphSecurityEdiscoveryNoncustodialDataSource[]>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update the properties of an ediscoverySearch object.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Import-Module Microsoft.Graph.Security
```

$params = @{
	displayName = "Teams search"
}

Update-MgSecurityCaseEdiscoveryCaseSearch -EdiscoveryCaseId $ediscoveryCaseId -EdiscoverySearchId $ediscoverySearchId -BodyParameter $params

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

### -AdditionalSources
Adds an additional source to the eDiscovery search.
To construct, see NOTES section for ADDITIONALSOURCES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityDataSource[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AddToReviewSetOperation
ediscoveryAddToReviewSetOperation
To construct, see NOTES section for ADDTOREVIEWSETOPERATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityEdiscoveryAddToReviewSetOperation
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
ediscoverySearch
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityEdiscoverySearch
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ContentQuery
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

### -CreatedBy
identitySet
To construct, see NOTES section for CREATEDBY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIdentitySet
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

### -CustodianSources
Custodian sources that are included in the eDiscovery search.
To construct, see NOTES section for CUSTODIANSOURCES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityDataSource[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DataSourceScopes
dataSourceScopes

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

### -Description
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

### -EdiscoveryCaseId
The unique identifier of ediscoveryCase

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

### -EdiscoverySearchId
The unique identifier of ediscoverySearch

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
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

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

### -LastEstimateStatisticsOperation
ediscoveryEstimateOperation
To construct, see NOTES section for LASTESTIMATESTATISTICSOPERATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityEdiscoveryEstimateOperation
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastModifiedBy
identitySet
To construct, see NOTES section for LASTMODIFIEDBY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIdentitySet
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastModifiedDateTime
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

### -NoncustodialSources
noncustodialDataSource sources that are included in the eDiscovery search
To construct, see NOTES section for NONCUSTODIALSOURCES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityEdiscoveryNoncustodialDataSource[]
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityEdiscoverySearch

### Microsoft.Graph.PowerShell.Models.ISecurityIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityEdiscoverySearch

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`ADDITIONALSOURCES <IMicrosoftGraphSecurityDataSource[]>`: Adds an additional source to the eDiscovery search.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: The date and time the dataSource was created.
  - `[DisplayName <String>]`: The display name of the dataSource. This will be the name of the SharePoint site.
  - `[HoldStatus <String>]`: dataSourceHoldStatus

`ADDTOREVIEWSETOPERATION <IMicrosoftGraphSecurityEdiscoveryAddToReviewSetOperation>`: ediscoveryAddToReviewSetOperation
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Action <String>]`: caseAction
  - `[CompletedDateTime <DateTime?>]`: The date and time the operation was completed.
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: The date and time the operation was created.
  - `[PercentProgress <Int32?>]`: The progress of the operation.
  - `[ResultInfo <IMicrosoftGraphResultInfo>]`: resultInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Code <Int32?>]`: The result code.
    - `[Message <String>]`: The message.
    - `[Subcode <Int32?>]`: The result sub-code.
  - `[Status <String>]`: caseOperationStatus
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[ReviewSet <IMicrosoftGraphSecurityEdiscoveryReviewSet>]`: ediscoveryReviewSet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: 
    - `[DisplayName <String>]`: 
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Queries <IMicrosoftGraphSecurityEdiscoveryReviewSetQuery[]>]`: Represents queries within the review set.
      - `[ContentQuery <String>]`: 
      - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[CreatedDateTime <DateTime?>]`: 
      - `[Description <String>]`: 
      - `[DisplayName <String>]`: 
      - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[LastModifiedDateTime <DateTime?>]`: 
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Search <IMicrosoftGraphSecurityEdiscoverySearch>]`: ediscoverySearch
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ContentQuery <String>]`: 
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: 
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[AddToReviewSetOperation <IMicrosoftGraphSecurityEdiscoveryAddToReviewSetOperation>]`: ediscoveryAddToReviewSetOperation
    - `[AdditionalSources <IMicrosoftGraphSecurityDataSource[]>]`: Adds an additional source to the eDiscovery search.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[CreatedDateTime <DateTime?>]`: The date and time the dataSource was created.
      - `[DisplayName <String>]`: The display name of the dataSource. This will be the name of the SharePoint site.
      - `[HoldStatus <String>]`: dataSourceHoldStatus
    - `[CustodianSources <IMicrosoftGraphSecurityDataSource[]>]`: Custodian sources that are included in the eDiscovery search.
    - `[DataSourceScopes <String>]`: dataSourceScopes
    - `[LastEstimateStatisticsOperation <IMicrosoftGraphSecurityEdiscoveryEstimateOperation>]`: ediscoveryEstimateOperation
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Action <String>]`: caseAction
      - `[CompletedDateTime <DateTime?>]`: The date and time the operation was completed.
      - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[CreatedDateTime <DateTime?>]`: The date and time the operation was created.
      - `[PercentProgress <Int32?>]`: The progress of the operation.
      - `[ResultInfo <IMicrosoftGraphResultInfo>]`: resultInfo
      - `[Status <String>]`: caseOperationStatus
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[IndexedItemCount <Int64?>]`: The estimated count of items for the search that matched the content query.
      - `[IndexedItemsSize <Int64?>]`: The estimated size of items for the search that matched the content query.
      - `[MailboxCount <Int32?>]`: The number of mailboxes that had search hits.
      - `[Search <IMicrosoftGraphSecurityEdiscoverySearch>]`: ediscoverySearch
      - `[SiteCount <Int32?>]`: The number of mailboxes that had search hits.
      - `[UnindexedItemCount <Int64?>]`: The estimated count of unindexed items for the collection.
      - `[UnindexedItemsSize <Int64?>]`: The estimated size of unindexed items for the collection.
    - `[NoncustodialSources <IMicrosoftGraphSecurityEdiscoveryNoncustodialDataSource[]>]`: noncustodialDataSource sources that are included in the eDiscovery search
      - `[CreatedDateTime <DateTime?>]`: Created date and time of the dataSourceContainer entity.
      - `[DisplayName <String>]`: Display name of the dataSourceContainer entity.
      - `[HoldStatus <String>]`: dataSourceHoldStatus
      - `[LastModifiedDateTime <DateTime?>]`: Last modified date and time of the dataSourceContainer.
      - `[ReleasedDateTime <DateTime?>]`: Date and time that the dataSourceContainer was released from the case.
      - `[Status <String>]`: dataSourceContainerStatus
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[DataSource <IMicrosoftGraphSecurityDataSource>]`: dataSource
      - `[LastIndexOperation <IMicrosoftGraphSecurityEdiscoveryIndexOperation>]`: ediscoveryIndexOperation
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Action <String>]`: caseAction
        - `[CompletedDateTime <DateTime?>]`: The date and time the operation was completed.
        - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
        - `[CreatedDateTime <DateTime?>]`: The date and time the operation was created.
        - `[PercentProgress <Int32?>]`: The progress of the operation.
        - `[ResultInfo <IMicrosoftGraphResultInfo>]`: resultInfo
        - `[Status <String>]`: caseOperationStatus
        - `[Id <String>]`: The unique idenfier for an entity. Read-only.

`BODYPARAMETER <IMicrosoftGraphSecurityEdiscoverySearch>`: ediscoverySearch
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ContentQuery <String>]`: 
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: 
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: 
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[AddToReviewSetOperation <IMicrosoftGraphSecurityEdiscoveryAddToReviewSetOperation>]`: ediscoveryAddToReviewSetOperation
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Action <String>]`: caseAction
    - `[CompletedDateTime <DateTime?>]`: The date and time the operation was completed.
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: The date and time the operation was created.
    - `[PercentProgress <Int32?>]`: The progress of the operation.
    - `[ResultInfo <IMicrosoftGraphResultInfo>]`: resultInfo
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Code <Int32?>]`: The result code.
      - `[Message <String>]`: The message.
      - `[Subcode <Int32?>]`: The result sub-code.
    - `[Status <String>]`: caseOperationStatus
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[ReviewSet <IMicrosoftGraphSecurityEdiscoveryReviewSet>]`: ediscoveryReviewSet
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[CreatedDateTime <DateTime?>]`: 
      - `[DisplayName <String>]`: 
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[Queries <IMicrosoftGraphSecurityEdiscoveryReviewSetQuery[]>]`: Represents queries within the review set.
        - `[ContentQuery <String>]`: 
        - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
        - `[CreatedDateTime <DateTime?>]`: 
        - `[Description <String>]`: 
        - `[DisplayName <String>]`: 
        - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
        - `[LastModifiedDateTime <DateTime?>]`: 
        - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Search <IMicrosoftGraphSecurityEdiscoverySearch>]`: ediscoverySearch
  - `[AdditionalSources <IMicrosoftGraphSecurityDataSource[]>]`: Adds an additional source to the eDiscovery search.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: The date and time the dataSource was created.
    - `[DisplayName <String>]`: The display name of the dataSource. This will be the name of the SharePoint site.
    - `[HoldStatus <String>]`: dataSourceHoldStatus
  - `[CustodianSources <IMicrosoftGraphSecurityDataSource[]>]`: Custodian sources that are included in the eDiscovery search.
  - `[DataSourceScopes <String>]`: dataSourceScopes
  - `[LastEstimateStatisticsOperation <IMicrosoftGraphSecurityEdiscoveryEstimateOperation>]`: ediscoveryEstimateOperation
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Action <String>]`: caseAction
    - `[CompletedDateTime <DateTime?>]`: The date and time the operation was completed.
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: The date and time the operation was created.
    - `[PercentProgress <Int32?>]`: The progress of the operation.
    - `[ResultInfo <IMicrosoftGraphResultInfo>]`: resultInfo
    - `[Status <String>]`: caseOperationStatus
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[IndexedItemCount <Int64?>]`: The estimated count of items for the search that matched the content query.
    - `[IndexedItemsSize <Int64?>]`: The estimated size of items for the search that matched the content query.
    - `[MailboxCount <Int32?>]`: The number of mailboxes that had search hits.
    - `[Search <IMicrosoftGraphSecurityEdiscoverySearch>]`: ediscoverySearch
    - `[SiteCount <Int32?>]`: The number of mailboxes that had search hits.
    - `[UnindexedItemCount <Int64?>]`: The estimated count of unindexed items for the collection.
    - `[UnindexedItemsSize <Int64?>]`: The estimated size of unindexed items for the collection.
  - `[NoncustodialSources <IMicrosoftGraphSecurityEdiscoveryNoncustodialDataSource[]>]`: noncustodialDataSource sources that are included in the eDiscovery search
    - `[CreatedDateTime <DateTime?>]`: Created date and time of the dataSourceContainer entity.
    - `[DisplayName <String>]`: Display name of the dataSourceContainer entity.
    - `[HoldStatus <String>]`: dataSourceHoldStatus
    - `[LastModifiedDateTime <DateTime?>]`: Last modified date and time of the dataSourceContainer.
    - `[ReleasedDateTime <DateTime?>]`: Date and time that the dataSourceContainer was released from the case.
    - `[Status <String>]`: dataSourceContainerStatus
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[DataSource <IMicrosoftGraphSecurityDataSource>]`: dataSource
    - `[LastIndexOperation <IMicrosoftGraphSecurityEdiscoveryIndexOperation>]`: ediscoveryIndexOperation
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Action <String>]`: caseAction
      - `[CompletedDateTime <DateTime?>]`: The date and time the operation was completed.
      - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[CreatedDateTime <DateTime?>]`: The date and time the operation was created.
      - `[PercentProgress <Int32?>]`: The progress of the operation.
      - `[ResultInfo <IMicrosoftGraphResultInfo>]`: resultInfo
      - `[Status <String>]`: caseOperationStatus
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.

`CREATEDBY <IMicrosoftGraphIdentitySet>`: identitySet
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

`CUSTODIANSOURCES <IMicrosoftGraphSecurityDataSource[]>`: Custodian sources that are included in the eDiscovery search.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: The date and time the dataSource was created.
  - `[DisplayName <String>]`: The display name of the dataSource. This will be the name of the SharePoint site.
  - `[HoldStatus <String>]`: dataSourceHoldStatus

`INPUTOBJECT <ISecurityIdentity>`: Identity Parameter
  - `[AlertId <String>]`: The unique identifier of alert
  - `[ArticleId <String>]`: The unique identifier of article
  - `[ArticleIndicatorId <String>]`: The unique identifier of articleIndicator
  - `[CaseOperationId <String>]`: The unique identifier of caseOperation
  - `[DataSourceId <String>]`: The unique identifier of dataSource
  - `[EdiscoveryCaseId <String>]`: The unique identifier of ediscoveryCase
  - `[EdiscoveryCustodianId <String>]`: The unique identifier of ediscoveryCustodian
  - `[EdiscoveryNoncustodialDataSourceId <String>]`: The unique identifier of ediscoveryNoncustodialDataSource
  - `[EdiscoveryReviewSetId <String>]`: The unique identifier of ediscoveryReviewSet
  - `[EdiscoveryReviewSetQueryId <String>]`: The unique identifier of ediscoveryReviewSetQuery
  - `[EdiscoveryReviewTagId <String>]`: The unique identifier of ediscoveryReviewTag
  - `[EdiscoveryReviewTagId1 <String>]`: The unique identifier of ediscoveryReviewTag
  - `[EdiscoverySearchId <String>]`: The unique identifier of ediscoverySearch
  - `[HostComponentId <String>]`: The unique identifier of hostComponent
  - `[HostCookieId <String>]`: The unique identifier of hostCookie
  - `[HostId <String>]`: The unique identifier of host
  - `[HostTrackerId <String>]`: The unique identifier of hostTracker
  - `[IncidentId <String>]`: The unique identifier of incident
  - `[IntelligenceProfileId <String>]`: The unique identifier of intelligenceProfile
  - `[IntelligenceProfileIndicatorId <String>]`: The unique identifier of intelligenceProfileIndicator
  - `[PassiveDnsRecordId <String>]`: The unique identifier of passiveDnsRecord
  - `[RetentionEventId <String>]`: The unique identifier of retentionEvent
  - `[RetentionEventTypeId <String>]`: The unique identifier of retentionEventType
  - `[SecureScoreControlProfileId <String>]`: The unique identifier of secureScoreControlProfile
  - `[SecureScoreId <String>]`: The unique identifier of secureScore
  - `[SimulationAutomationId <String>]`: The unique identifier of simulationAutomation
  - `[SimulationAutomationRunId <String>]`: The unique identifier of simulationAutomationRun
  - `[SimulationId <String>]`: The unique identifier of simulation
  - `[SiteSourceId <String>]`: The unique identifier of siteSource
  - `[UnifiedGroupSourceId <String>]`: The unique identifier of unifiedGroupSource
  - `[UserSourceId <String>]`: The unique identifier of userSource
  - `[VulnerabilityComponentId <String>]`: The unique identifier of vulnerabilityComponent
  - `[VulnerabilityId <String>]`: The unique identifier of vulnerability

`LASTESTIMATESTATISTICSOPERATION <IMicrosoftGraphSecurityEdiscoveryEstimateOperation>`: ediscoveryEstimateOperation
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Action <String>]`: caseAction
  - `[CompletedDateTime <DateTime?>]`: The date and time the operation was completed.
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: The date and time the operation was created.
  - `[PercentProgress <Int32?>]`: The progress of the operation.
  - `[ResultInfo <IMicrosoftGraphResultInfo>]`: resultInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Code <Int32?>]`: The result code.
    - `[Message <String>]`: The message.
    - `[Subcode <Int32?>]`: The result sub-code.
  - `[Status <String>]`: caseOperationStatus
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[IndexedItemCount <Int64?>]`: The estimated count of items for the search that matched the content query.
  - `[IndexedItemsSize <Int64?>]`: The estimated size of items for the search that matched the content query.
  - `[MailboxCount <Int32?>]`: The number of mailboxes that had search hits.
  - `[Search <IMicrosoftGraphSecurityEdiscoverySearch>]`: ediscoverySearch
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ContentQuery <String>]`: 
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: 
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[AddToReviewSetOperation <IMicrosoftGraphSecurityEdiscoveryAddToReviewSetOperation>]`: ediscoveryAddToReviewSetOperation
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Action <String>]`: caseAction
      - `[CompletedDateTime <DateTime?>]`: The date and time the operation was completed.
      - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[CreatedDateTime <DateTime?>]`: The date and time the operation was created.
      - `[PercentProgress <Int32?>]`: The progress of the operation.
      - `[ResultInfo <IMicrosoftGraphResultInfo>]`: resultInfo
      - `[Status <String>]`: caseOperationStatus
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[ReviewSet <IMicrosoftGraphSecurityEdiscoveryReviewSet>]`: ediscoveryReviewSet
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
        - `[CreatedDateTime <DateTime?>]`: 
        - `[DisplayName <String>]`: 
        - `[Id <String>]`: The unique idenfier for an entity. Read-only.
        - `[Queries <IMicrosoftGraphSecurityEdiscoveryReviewSetQuery[]>]`: Represents queries within the review set.
          - `[ContentQuery <String>]`: 
          - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
          - `[CreatedDateTime <DateTime?>]`: 
          - `[Description <String>]`: 
          - `[DisplayName <String>]`: 
          - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
          - `[LastModifiedDateTime <DateTime?>]`: 
          - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[Search <IMicrosoftGraphSecurityEdiscoverySearch>]`: ediscoverySearch
    - `[AdditionalSources <IMicrosoftGraphSecurityDataSource[]>]`: Adds an additional source to the eDiscovery search.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[CreatedDateTime <DateTime?>]`: The date and time the dataSource was created.
      - `[DisplayName <String>]`: The display name of the dataSource. This will be the name of the SharePoint site.
      - `[HoldStatus <String>]`: dataSourceHoldStatus
    - `[CustodianSources <IMicrosoftGraphSecurityDataSource[]>]`: Custodian sources that are included in the eDiscovery search.
    - `[DataSourceScopes <String>]`: dataSourceScopes
    - `[LastEstimateStatisticsOperation <IMicrosoftGraphSecurityEdiscoveryEstimateOperation>]`: ediscoveryEstimateOperation
    - `[NoncustodialSources <IMicrosoftGraphSecurityEdiscoveryNoncustodialDataSource[]>]`: noncustodialDataSource sources that are included in the eDiscovery search
      - `[CreatedDateTime <DateTime?>]`: Created date and time of the dataSourceContainer entity.
      - `[DisplayName <String>]`: Display name of the dataSourceContainer entity.
      - `[HoldStatus <String>]`: dataSourceHoldStatus
      - `[LastModifiedDateTime <DateTime?>]`: Last modified date and time of the dataSourceContainer.
      - `[ReleasedDateTime <DateTime?>]`: Date and time that the dataSourceContainer was released from the case.
      - `[Status <String>]`: dataSourceContainerStatus
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[DataSource <IMicrosoftGraphSecurityDataSource>]`: dataSource
      - `[LastIndexOperation <IMicrosoftGraphSecurityEdiscoveryIndexOperation>]`: ediscoveryIndexOperation
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Action <String>]`: caseAction
        - `[CompletedDateTime <DateTime?>]`: The date and time the operation was completed.
        - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
        - `[CreatedDateTime <DateTime?>]`: The date and time the operation was created.
        - `[PercentProgress <Int32?>]`: The progress of the operation.
        - `[ResultInfo <IMicrosoftGraphResultInfo>]`: resultInfo
        - `[Status <String>]`: caseOperationStatus
        - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[SiteCount <Int32?>]`: The number of mailboxes that had search hits.
  - `[UnindexedItemCount <Int64?>]`: The estimated count of unindexed items for the collection.
  - `[UnindexedItemsSize <Int64?>]`: The estimated size of unindexed items for the collection.

`LASTMODIFIEDBY <IMicrosoftGraphIdentitySet>`: identitySet
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

`NONCUSTODIALSOURCES <IMicrosoftGraphSecurityEdiscoveryNoncustodialDataSource[]>`: noncustodialDataSource sources that are included in the eDiscovery search
  - `[CreatedDateTime <DateTime?>]`: Created date and time of the dataSourceContainer entity.
  - `[DisplayName <String>]`: Display name of the dataSourceContainer entity.
  - `[HoldStatus <String>]`: dataSourceHoldStatus
  - `[LastModifiedDateTime <DateTime?>]`: Last modified date and time of the dataSourceContainer.
  - `[ReleasedDateTime <DateTime?>]`: Date and time that the dataSourceContainer was released from the case.
  - `[Status <String>]`: dataSourceContainerStatus
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[DataSource <IMicrosoftGraphSecurityDataSource>]`: dataSource
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
    - `[CreatedDateTime <DateTime?>]`: The date and time the dataSource was created.
    - `[DisplayName <String>]`: The display name of the dataSource. This will be the name of the SharePoint site.
    - `[HoldStatus <String>]`: dataSourceHoldStatus
  - `[LastIndexOperation <IMicrosoftGraphSecurityEdiscoveryIndexOperation>]`: ediscoveryIndexOperation
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Action <String>]`: caseAction
    - `[CompletedDateTime <DateTime?>]`: The date and time the operation was completed.
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: The date and time the operation was created.
    - `[PercentProgress <Int32?>]`: The progress of the operation.
    - `[ResultInfo <IMicrosoftGraphResultInfo>]`: resultInfo
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Code <Int32?>]`: The result code.
      - `[Message <String>]`: The message.
      - `[Subcode <Int32?>]`: The result sub-code.
    - `[Status <String>]`: caseOperationStatus
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.

## RELATED LINKS

