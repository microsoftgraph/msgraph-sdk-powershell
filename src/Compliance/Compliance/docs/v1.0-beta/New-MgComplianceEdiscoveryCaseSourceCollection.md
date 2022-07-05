---
external help file:
Module Name: Microsoft.Graph.Compliance
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.compliance/new-mgcomplianceediscoverycasesourcecollection
schema: 2.0.0
---

# New-MgComplianceEdiscoveryCaseSourceCollection

## SYNOPSIS
Create new navigation property to sourceCollections for compliance

## SYNTAX

### CreateExpanded (Default)
```
New-MgComplianceEdiscoveryCaseSourceCollection -CaseId <String> [-AdditionalProperties <Hashtable>]
 [-AdditionalSources <IMicrosoftGraphEdiscoveryDataSource[]>]
 [-AddToReviewSetOperation <IMicrosoftGraphEdiscoveryAddToReviewSetOperation>] [-ContentQuery <String>]
 [-CreatedBy <IMicrosoftGraphIdentitySet>] [-CreatedDateTime <DateTime>]
 [-CustodianSources <IMicrosoftGraphEdiscoveryDataSource[]>] [-DataSourceScopes <String>]
 [-Description <String>] [-DisplayName <String>] [-Id <String>]
 [-LastEstimateStatisticsOperation <IMicrosoftGraphEdiscoveryEstimateStatisticsOperation>]
 [-LastModifiedBy <IMicrosoftGraphIdentitySet>] [-LastModifiedDateTime <DateTime>]
 [-NoncustodialSources <IMicrosoftGraphEdiscoveryNoncustodialDataSource[]>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgComplianceEdiscoveryCaseSourceCollection -CaseId <String>
 -BodyParameter <IMicrosoftGraphEdiscoverySourceCollection> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgComplianceEdiscoveryCaseSourceCollection -InputObject <IComplianceIdentity>
 -BodyParameter <IMicrosoftGraphEdiscoverySourceCollection> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgComplianceEdiscoveryCaseSourceCollection -InputObject <IComplianceIdentity>
 [-AdditionalProperties <Hashtable>] [-AdditionalSources <IMicrosoftGraphEdiscoveryDataSource[]>]
 [-AddToReviewSetOperation <IMicrosoftGraphEdiscoveryAddToReviewSetOperation>] [-ContentQuery <String>]
 [-CreatedBy <IMicrosoftGraphIdentitySet>] [-CreatedDateTime <DateTime>]
 [-CustodianSources <IMicrosoftGraphEdiscoveryDataSource[]>] [-DataSourceScopes <String>]
 [-Description <String>] [-DisplayName <String>] [-Id <String>]
 [-LastEstimateStatisticsOperation <IMicrosoftGraphEdiscoveryEstimateStatisticsOperation>]
 [-LastModifiedBy <IMicrosoftGraphIdentitySet>] [-LastModifiedDateTime <DateTime>]
 [-NoncustodialSources <IMicrosoftGraphEdiscoveryNoncustodialDataSource[]>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to sourceCollections for compliance

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AdditionalSources
Adds an additional source to the sourceCollection.
To construct, please use Get-Help -Online and see NOTES section for ADDITIONALSOURCES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEdiscoveryDataSource[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AddToReviewSetOperation
addToReviewSetOperation
To construct, please use Get-Help -Online and see NOTES section for ADDTOREVIEWSETOPERATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEdiscoveryAddToReviewSetOperation
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
sourceCollection
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEdiscoverySourceCollection
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CaseId
key: id of case

```yaml
Type: System.String
Parameter Sets: Create, CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ContentQuery
The query string in KQL (Keyword Query Language) query.
For details, see Keyword queries and search conditions for Content Search and eDiscovery.
You can refine searches by using fields paired with values; for example, subject:'Quarterly Financials' AND Date\>=06/01/2016 AND Date\<=07/01/2016.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedBy
identitySet
To construct, please use Get-Help -Online and see NOTES section for CREATEDBY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIdentitySet
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedDateTime
The date and time the sourceCollection was created.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CustodianSources
Custodian sources that are included in the sourceCollection.
To construct, please use Get-Help -Online and see NOTES section for CUSTODIANSOURCES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEdiscoveryDataSource[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
The description of the sourceCollection.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
The display name of the sourceCollection.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IComplianceIdentity
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LastEstimateStatisticsOperation
estimateStatisticsOperation
To construct, please use Get-Help -Online and see NOTES section for LASTESTIMATESTATISTICSOPERATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEdiscoveryEstimateStatisticsOperation
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastModifiedBy
identitySet
To construct, please use Get-Help -Online and see NOTES section for LASTMODIFIEDBY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIdentitySet
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastModifiedDateTime
The last date and time the sourceCollection was modified.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NoncustodialSources
noncustodialDataSource sources that are included in the sourceCollection
To construct, please use Get-Help -Online and see NOTES section for NONCUSTODIALSOURCES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEdiscoveryNoncustodialDataSource[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IComplianceIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEdiscoverySourceCollection

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEdiscoverySourceCollection

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ADDITIONALSOURCES <IMicrosoftGraphEdiscoveryDataSource[]>: Adds an additional source to the sourceCollection.
  - `[Id <String>]`: 
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
      - `[Id <String>]`: The identifier of the identity. This property is read-only.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: The date and time the dataSource was created.
  - `[DisplayName <String>]`: The display name of the dataSource. This will be the name of the SharePoint site.
  - `[HoldStatus <String>]`: dataSourceHoldStatus

ADDTOREVIEWSETOPERATION <IMicrosoftGraphEdiscoveryAddToReviewSetOperation>: addToReviewSetOperation
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Action <String>]`: caseAction
  - `[CompletedDateTime <DateTime?>]`: The date and time the operation was completed.
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
      - `[Id <String>]`: The identifier of the identity. This property is read-only.
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
  - `[Id <String>]`: 
  - `[ReviewSet <IMicrosoftGraphEdiscoveryReviewSet>]`: reviewSet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: The datetime when the review set was created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    - `[DisplayName <String>]`: The review set name. The name is unique with a maximum limit of 64 characters.
    - `[Queries <IMicrosoftGraphEdiscoveryReviewSetQuery[]>]`: 
      - `[Id <String>]`: 
      - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[CreatedDateTime <DateTime?>]`: The time and date when the query was created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
      - `[DisplayName <String>]`: The name of the query.
      - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[LastModifiedDateTime <DateTime?>]`: The date and time the query was last modified. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
      - `[Query <String>]`: The query string in KQL (Keyword Query Language) query. For details, see Document metadata fields in Advanced eDiscovery.  This field maps directly to the keywords condition.  You can refine searches by using fields listed in the searchable field name paired with values; for example, subject:'Quarterly Financials' AND Date>=06/01/2016 AND Date<=07/01/2016.
  - `[SourceCollection <IMicrosoftGraphEdiscoverySourceCollection>]`: sourceCollection
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[AddToReviewSetOperation <IMicrosoftGraphEdiscoveryAddToReviewSetOperation>]`: addToReviewSetOperation
    - `[AdditionalSources <IMicrosoftGraphEdiscoveryDataSource[]>]`: Adds an additional source to the sourceCollection.
      - `[Id <String>]`: 
      - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[CreatedDateTime <DateTime?>]`: The date and time the dataSource was created.
      - `[DisplayName <String>]`: The display name of the dataSource. This will be the name of the SharePoint site.
      - `[HoldStatus <String>]`: dataSourceHoldStatus
    - `[ContentQuery <String>]`: The query string in KQL (Keyword Query Language) query. For details, see Keyword queries and search conditions for Content Search and eDiscovery. You can refine searches by using fields paired with values; for example, subject:'Quarterly Financials' AND Date>=06/01/2016 AND Date<=07/01/2016.
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: The date and time the sourceCollection was created.
    - `[CustodianSources <IMicrosoftGraphEdiscoveryDataSource[]>]`: Custodian sources that are included in the sourceCollection.
    - `[DataSourceScopes <String>]`: dataSourceScopes
    - `[Description <String>]`: The description of the sourceCollection.
    - `[DisplayName <String>]`: The display name of the sourceCollection.
    - `[LastEstimateStatisticsOperation <IMicrosoftGraphEdiscoveryEstimateStatisticsOperation>]`: estimateStatisticsOperation
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Action <String>]`: caseAction
      - `[CompletedDateTime <DateTime?>]`: The date and time the operation was completed.
      - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[CreatedDateTime <DateTime?>]`: The date and time the operation was created.
      - `[PercentProgress <Int32?>]`: The progress of the operation.
      - `[ResultInfo <IMicrosoftGraphResultInfo>]`: resultInfo
      - `[Status <String>]`: caseOperationStatus
      - `[Id <String>]`: 
      - `[IndexedItemCount <Int64?>]`: The estimated count of items for the sourceCollection that matched the content query.
      - `[IndexedItemsSize <Int64?>]`: The estimated size of items for the sourceCollection that matched the content query.
      - `[MailboxCount <Int32?>]`: The number of mailboxes that had search hits.
      - `[SiteCount <Int32?>]`: The number of mailboxes that had search hits.
      - `[SourceCollection <IMicrosoftGraphEdiscoverySourceCollection>]`: sourceCollection
      - `[UnindexedItemCount <Int64?>]`: The estimated count of unindexed items for the collection.
      - `[UnindexedItemsSize <Int64?>]`: The estimated size of unindexed items for the collection.
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: The last date and time the sourceCollection was modified.
    - `[NoncustodialSources <IMicrosoftGraphEdiscoveryNoncustodialDataSource[]>]`: noncustodialDataSource sources that are included in the sourceCollection
      - `[CreatedDateTime <DateTime?>]`: Created date and time of the dataSourceContainer entity.
      - `[DisplayName <String>]`: Display name of the dataSourceContainer entity.
      - `[HoldStatus <String>]`: dataSourceHoldStatus
      - `[LastIndexOperation <IMicrosoftGraphEdiscoveryCaseIndexOperation>]`: caseIndexOperation
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Action <String>]`: caseAction
        - `[CompletedDateTime <DateTime?>]`: The date and time the operation was completed.
        - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
        - `[CreatedDateTime <DateTime?>]`: The date and time the operation was created.
        - `[PercentProgress <Int32?>]`: The progress of the operation.
        - `[ResultInfo <IMicrosoftGraphResultInfo>]`: resultInfo
        - `[Status <String>]`: caseOperationStatus
        - `[Id <String>]`: 
      - `[LastModifiedDateTime <DateTime?>]`: Last modified date and time of the dataSourceContainer.
      - `[ReleasedDateTime <DateTime?>]`: Date and time that the dataSourceContainer was released from the case.
      - `[Status <String>]`: dataSourceContainerStatus
      - `[Id <String>]`: 
      - `[ApplyHoldToSource <Boolean?>]`: Indicates if hold is applied to non-custodial data source (such as mailbox or site).
      - `[DataSource <IMicrosoftGraphEdiscoveryDataSource>]`: dataSource

BODYPARAMETER <IMicrosoftGraphEdiscoverySourceCollection>: sourceCollection
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[AddToReviewSetOperation <IMicrosoftGraphEdiscoveryAddToReviewSetOperation>]`: addToReviewSetOperation
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Action <String>]`: caseAction
    - `[CompletedDateTime <DateTime?>]`: The date and time the operation was completed.
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Application <IMicrosoftGraphIdentity>]`: identity
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
        - `[Id <String>]`: The identifier of the identity. This property is read-only.
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
    - `[Id <String>]`: 
    - `[ReviewSet <IMicrosoftGraphEdiscoveryReviewSet>]`: reviewSet
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: 
      - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[CreatedDateTime <DateTime?>]`: The datetime when the review set was created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
      - `[DisplayName <String>]`: The review set name. The name is unique with a maximum limit of 64 characters.
      - `[Queries <IMicrosoftGraphEdiscoveryReviewSetQuery[]>]`: 
        - `[Id <String>]`: 
        - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
        - `[CreatedDateTime <DateTime?>]`: The time and date when the query was created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        - `[DisplayName <String>]`: The name of the query.
        - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
        - `[LastModifiedDateTime <DateTime?>]`: The date and time the query was last modified. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        - `[Query <String>]`: The query string in KQL (Keyword Query Language) query. For details, see Document metadata fields in Advanced eDiscovery.  This field maps directly to the keywords condition.  You can refine searches by using fields listed in the searchable field name paired with values; for example, subject:'Quarterly Financials' AND Date>=06/01/2016 AND Date<=07/01/2016.
    - `[SourceCollection <IMicrosoftGraphEdiscoverySourceCollection>]`: sourceCollection
  - `[AdditionalSources <IMicrosoftGraphEdiscoveryDataSource[]>]`: Adds an additional source to the sourceCollection.
    - `[Id <String>]`: 
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: The date and time the dataSource was created.
    - `[DisplayName <String>]`: The display name of the dataSource. This will be the name of the SharePoint site.
    - `[HoldStatus <String>]`: dataSourceHoldStatus
  - `[ContentQuery <String>]`: The query string in KQL (Keyword Query Language) query. For details, see Keyword queries and search conditions for Content Search and eDiscovery. You can refine searches by using fields paired with values; for example, subject:'Quarterly Financials' AND Date>=06/01/2016 AND Date<=07/01/2016.
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[CreatedDateTime <DateTime?>]`: The date and time the sourceCollection was created.
  - `[CustodianSources <IMicrosoftGraphEdiscoveryDataSource[]>]`: Custodian sources that are included in the sourceCollection.
  - `[DataSourceScopes <String>]`: dataSourceScopes
  - `[Description <String>]`: The description of the sourceCollection.
  - `[DisplayName <String>]`: The display name of the sourceCollection.
  - `[LastEstimateStatisticsOperation <IMicrosoftGraphEdiscoveryEstimateStatisticsOperation>]`: estimateStatisticsOperation
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Action <String>]`: caseAction
    - `[CompletedDateTime <DateTime?>]`: The date and time the operation was completed.
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: The date and time the operation was created.
    - `[PercentProgress <Int32?>]`: The progress of the operation.
    - `[ResultInfo <IMicrosoftGraphResultInfo>]`: resultInfo
    - `[Status <String>]`: caseOperationStatus
    - `[Id <String>]`: 
    - `[IndexedItemCount <Int64?>]`: The estimated count of items for the sourceCollection that matched the content query.
    - `[IndexedItemsSize <Int64?>]`: The estimated size of items for the sourceCollection that matched the content query.
    - `[MailboxCount <Int32?>]`: The number of mailboxes that had search hits.
    - `[SiteCount <Int32?>]`: The number of mailboxes that had search hits.
    - `[SourceCollection <IMicrosoftGraphEdiscoverySourceCollection>]`: sourceCollection
    - `[UnindexedItemCount <Int64?>]`: The estimated count of unindexed items for the collection.
    - `[UnindexedItemsSize <Int64?>]`: The estimated size of unindexed items for the collection.
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: The last date and time the sourceCollection was modified.
  - `[NoncustodialSources <IMicrosoftGraphEdiscoveryNoncustodialDataSource[]>]`: noncustodialDataSource sources that are included in the sourceCollection
    - `[CreatedDateTime <DateTime?>]`: Created date and time of the dataSourceContainer entity.
    - `[DisplayName <String>]`: Display name of the dataSourceContainer entity.
    - `[HoldStatus <String>]`: dataSourceHoldStatus
    - `[LastIndexOperation <IMicrosoftGraphEdiscoveryCaseIndexOperation>]`: caseIndexOperation
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Action <String>]`: caseAction
      - `[CompletedDateTime <DateTime?>]`: The date and time the operation was completed.
      - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[CreatedDateTime <DateTime?>]`: The date and time the operation was created.
      - `[PercentProgress <Int32?>]`: The progress of the operation.
      - `[ResultInfo <IMicrosoftGraphResultInfo>]`: resultInfo
      - `[Status <String>]`: caseOperationStatus
      - `[Id <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: Last modified date and time of the dataSourceContainer.
    - `[ReleasedDateTime <DateTime?>]`: Date and time that the dataSourceContainer was released from the case.
    - `[Status <String>]`: dataSourceContainerStatus
    - `[Id <String>]`: 
    - `[ApplyHoldToSource <Boolean?>]`: Indicates if hold is applied to non-custodial data source (such as mailbox or site).
    - `[DataSource <IMicrosoftGraphEdiscoveryDataSource>]`: dataSource

CREATEDBY <IMicrosoftGraphIdentitySet>: identitySet
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
    - `[Id <String>]`: The identifier of the identity. This property is read-only.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

CUSTODIANSOURCES <IMicrosoftGraphEdiscoveryDataSource[]>: Custodian sources that are included in the sourceCollection.
  - `[Id <String>]`: 
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
      - `[Id <String>]`: The identifier of the identity. This property is read-only.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: The date and time the dataSource was created.
  - `[DisplayName <String>]`: The display name of the dataSource. This will be the name of the SharePoint site.
  - `[HoldStatus <String>]`: dataSourceHoldStatus

INPUTOBJECT <IComplianceIdentity>: Identity Parameter
  - `[CaseId <String>]`: key: id of case
  - `[CaseOperationId <String>]`: key: id of caseOperation
  - `[CustodianId <String>]`: key: id of custodian
  - `[DataSourceId <String>]`: key: id of dataSource
  - `[LegalHoldId <String>]`: key: id of legalHold
  - `[NoncustodialDataSourceId <String>]`: key: id of noncustodialDataSource
  - `[ReviewSetId <String>]`: key: id of reviewSet
  - `[ReviewSetQueryId <String>]`: key: id of reviewSetQuery
  - `[SiteSourceId <String>]`: key: id of siteSource
  - `[SourceCollectionId <String>]`: key: id of sourceCollection
  - `[TagId <String>]`: key: id of tag
  - `[TagId1 <String>]`: key: id of tag
  - `[UnifiedGroupSourceId <String>]`: key: id of unifiedGroupSource
  - `[UserSourceId <String>]`: key: id of userSource

LASTESTIMATESTATISTICSOPERATION <IMicrosoftGraphEdiscoveryEstimateStatisticsOperation>: estimateStatisticsOperation
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Action <String>]`: caseAction
  - `[CompletedDateTime <DateTime?>]`: The date and time the operation was completed.
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
      - `[Id <String>]`: The identifier of the identity. This property is read-only.
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
  - `[Id <String>]`: 
  - `[IndexedItemCount <Int64?>]`: The estimated count of items for the sourceCollection that matched the content query.
  - `[IndexedItemsSize <Int64?>]`: The estimated size of items for the sourceCollection that matched the content query.
  - `[MailboxCount <Int32?>]`: The number of mailboxes that had search hits.
  - `[SiteCount <Int32?>]`: The number of mailboxes that had search hits.
  - `[SourceCollection <IMicrosoftGraphEdiscoverySourceCollection>]`: sourceCollection
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[AddToReviewSetOperation <IMicrosoftGraphEdiscoveryAddToReviewSetOperation>]`: addToReviewSetOperation
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Action <String>]`: caseAction
      - `[CompletedDateTime <DateTime?>]`: The date and time the operation was completed.
      - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[CreatedDateTime <DateTime?>]`: The date and time the operation was created.
      - `[PercentProgress <Int32?>]`: The progress of the operation.
      - `[ResultInfo <IMicrosoftGraphResultInfo>]`: resultInfo
      - `[Status <String>]`: caseOperationStatus
      - `[Id <String>]`: 
      - `[ReviewSet <IMicrosoftGraphEdiscoveryReviewSet>]`: reviewSet
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: 
        - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
        - `[CreatedDateTime <DateTime?>]`: The datetime when the review set was created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
        - `[DisplayName <String>]`: The review set name. The name is unique with a maximum limit of 64 characters.
        - `[Queries <IMicrosoftGraphEdiscoveryReviewSetQuery[]>]`: 
          - `[Id <String>]`: 
          - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
          - `[CreatedDateTime <DateTime?>]`: The time and date when the query was created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
          - `[DisplayName <String>]`: The name of the query.
          - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
          - `[LastModifiedDateTime <DateTime?>]`: The date and time the query was last modified. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
          - `[Query <String>]`: The query string in KQL (Keyword Query Language) query. For details, see Document metadata fields in Advanced eDiscovery.  This field maps directly to the keywords condition.  You can refine searches by using fields listed in the searchable field name paired with values; for example, subject:'Quarterly Financials' AND Date>=06/01/2016 AND Date<=07/01/2016.
      - `[SourceCollection <IMicrosoftGraphEdiscoverySourceCollection>]`: sourceCollection
    - `[AdditionalSources <IMicrosoftGraphEdiscoveryDataSource[]>]`: Adds an additional source to the sourceCollection.
      - `[Id <String>]`: 
      - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[CreatedDateTime <DateTime?>]`: The date and time the dataSource was created.
      - `[DisplayName <String>]`: The display name of the dataSource. This will be the name of the SharePoint site.
      - `[HoldStatus <String>]`: dataSourceHoldStatus
    - `[ContentQuery <String>]`: The query string in KQL (Keyword Query Language) query. For details, see Keyword queries and search conditions for Content Search and eDiscovery. You can refine searches by using fields paired with values; for example, subject:'Quarterly Financials' AND Date>=06/01/2016 AND Date<=07/01/2016.
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: The date and time the sourceCollection was created.
    - `[CustodianSources <IMicrosoftGraphEdiscoveryDataSource[]>]`: Custodian sources that are included in the sourceCollection.
    - `[DataSourceScopes <String>]`: dataSourceScopes
    - `[Description <String>]`: The description of the sourceCollection.
    - `[DisplayName <String>]`: The display name of the sourceCollection.
    - `[LastEstimateStatisticsOperation <IMicrosoftGraphEdiscoveryEstimateStatisticsOperation>]`: estimateStatisticsOperation
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: The last date and time the sourceCollection was modified.
    - `[NoncustodialSources <IMicrosoftGraphEdiscoveryNoncustodialDataSource[]>]`: noncustodialDataSource sources that are included in the sourceCollection
      - `[CreatedDateTime <DateTime?>]`: Created date and time of the dataSourceContainer entity.
      - `[DisplayName <String>]`: Display name of the dataSourceContainer entity.
      - `[HoldStatus <String>]`: dataSourceHoldStatus
      - `[LastIndexOperation <IMicrosoftGraphEdiscoveryCaseIndexOperation>]`: caseIndexOperation
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Action <String>]`: caseAction
        - `[CompletedDateTime <DateTime?>]`: The date and time the operation was completed.
        - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
        - `[CreatedDateTime <DateTime?>]`: The date and time the operation was created.
        - `[PercentProgress <Int32?>]`: The progress of the operation.
        - `[ResultInfo <IMicrosoftGraphResultInfo>]`: resultInfo
        - `[Status <String>]`: caseOperationStatus
        - `[Id <String>]`: 
      - `[LastModifiedDateTime <DateTime?>]`: Last modified date and time of the dataSourceContainer.
      - `[ReleasedDateTime <DateTime?>]`: Date and time that the dataSourceContainer was released from the case.
      - `[Status <String>]`: dataSourceContainerStatus
      - `[Id <String>]`: 
      - `[ApplyHoldToSource <Boolean?>]`: Indicates if hold is applied to non-custodial data source (such as mailbox or site).
      - `[DataSource <IMicrosoftGraphEdiscoveryDataSource>]`: dataSource
  - `[UnindexedItemCount <Int64?>]`: The estimated count of unindexed items for the collection.
  - `[UnindexedItemsSize <Int64?>]`: The estimated size of unindexed items for the collection.

LASTMODIFIEDBY <IMicrosoftGraphIdentitySet>: identitySet
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
    - `[Id <String>]`: The identifier of the identity. This property is read-only.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

NONCUSTODIALSOURCES <IMicrosoftGraphEdiscoveryNoncustodialDataSource[]>: noncustodialDataSource sources that are included in the sourceCollection
  - `[CreatedDateTime <DateTime?>]`: Created date and time of the dataSourceContainer entity.
  - `[DisplayName <String>]`: Display name of the dataSourceContainer entity.
  - `[HoldStatus <String>]`: dataSourceHoldStatus
  - `[LastIndexOperation <IMicrosoftGraphEdiscoveryCaseIndexOperation>]`: caseIndexOperation
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Action <String>]`: caseAction
    - `[CompletedDateTime <DateTime?>]`: The date and time the operation was completed.
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Application <IMicrosoftGraphIdentity>]`: identity
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
        - `[Id <String>]`: The identifier of the identity. This property is read-only.
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
    - `[Id <String>]`: 
  - `[LastModifiedDateTime <DateTime?>]`: Last modified date and time of the dataSourceContainer.
  - `[ReleasedDateTime <DateTime?>]`: Date and time that the dataSourceContainer was released from the case.
  - `[Status <String>]`: dataSourceContainerStatus
  - `[Id <String>]`: 
  - `[ApplyHoldToSource <Boolean?>]`: Indicates if hold is applied to non-custodial data source (such as mailbox or site).
  - `[DataSource <IMicrosoftGraphEdiscoveryDataSource>]`: dataSource
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: The date and time the dataSource was created.
    - `[DisplayName <String>]`: The display name of the dataSource. This will be the name of the SharePoint site.
    - `[HoldStatus <String>]`: dataSourceHoldStatus

## RELATED LINKS

