---
external help file:
Module Name: Microsoft.Graph.Beta.Compliance
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.compliance/new-mgbetacomplianceediscoverycasenoncustodialdatasource
schema: 2.0.0
---

# New-MgBetaComplianceEdiscoveryCaseNoncustodialDataSource

## SYNOPSIS
Create a new noncustodialDataSource object.
This API is available in the following national cloud deployments.

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaComplianceEdiscoveryCaseNoncustodialDataSource -CaseId <String> [-AdditionalProperties <Hashtable>]
 [-ApplyHoldToSource] [-CreatedDateTime <DateTime>] [-DataSource <IMicrosoftGraphEdiscoveryDataSource>]
 [-DisplayName <String>] [-HoldStatus <String>] [-Id <String>] [-LastIndexOperation <Hashtable>]
 [-LastModifiedDateTime <DateTime>] [-ReleasedDateTime <DateTime>] [-Status <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgBetaComplianceEdiscoveryCaseNoncustodialDataSource -CaseId <String>
 -BodyParameter <IMicrosoftGraphEdiscoveryNoncustodialDataSource> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgBetaComplianceEdiscoveryCaseNoncustodialDataSource -InputObject <IComplianceIdentity>
 -BodyParameter <IMicrosoftGraphEdiscoveryNoncustodialDataSource> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgBetaComplianceEdiscoveryCaseNoncustodialDataSource -InputObject <IComplianceIdentity>
 [-AdditionalProperties <Hashtable>] [-ApplyHoldToSource] [-CreatedDateTime <DateTime>]
 [-DataSource <IMicrosoftGraphEdiscoveryDataSource>] [-DisplayName <String>] [-HoldStatus <String>]
 [-Id <String>] [-LastIndexOperation <Hashtable>] [-LastModifiedDateTime <DateTime>]
 [-ReleasedDateTime <DateTime>] [-Status <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create a new noncustodialDataSource object.
This API is available in the following national cloud deployments.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.Compliance
$params = @{
	ApplyHoldToSource = $true
	DataSource = @{
		"@odata.type" = "microsoft.graph.ediscovery.userSource"
		Email = "adelev@contoso.com"
	}
}
New-MgBetaComplianceEdiscoveryCaseNoncustodialDataSource -CaseId $caseId -BodyParameter $params
```



### -------------------------- EXAMPLE 2 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.Compliance
$params = @{
	ApplyHoldToSource = $false
	DataSource = @{
		"@odata.type" = "microsoft.graph.ediscovery.siteSource"
	}
}
New-MgBetaComplianceEdiscoveryCaseNoncustodialDataSource -CaseId $caseId -BodyParameter $params
```



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

### -ApplyHoldToSource
Indicates if hold is applied to noncustodial data source (such as mailbox or site).

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
noncustodialDataSource
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphEdiscoveryNoncustodialDataSource
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CaseId
The unique identifier of case

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

### -CreatedDateTime
Created date and time of the dataSourceContainer entity.

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

### -DataSource
dataSource
To construct, see NOTES section for DATASOURCE properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphEdiscoveryDataSource
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
Display name of the dataSourceContainer entity.

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

### -HoldStatus
dataSourceHoldStatus

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
The unique identifier for an entity.
Read-only.

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
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IComplianceIdentity
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LastIndexOperation
caseIndexOperation

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

### -LastModifiedDateTime
Last modified date and time of the dataSourceContainer.

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

### -ReleasedDateTime
Date and time that the dataSourceContainer was released from the case.

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

### -Status
dataSourceContainerStatus

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

### Microsoft.Graph.Beta.PowerShell.Models.IComplianceIdentity

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphEdiscoveryNoncustodialDataSource

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphEdiscoveryNoncustodialDataSource

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphEdiscoveryNoncustodialDataSource>`: noncustodialDataSource
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
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
        - `[DisplayName <String>]`: The display name of the identity. This might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
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
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[LastModifiedDateTime <DateTime?>]`: Last modified date and time of the dataSourceContainer.
  - `[ReleasedDateTime <DateTime?>]`: Date and time that the dataSourceContainer was released from the case.
  - `[Status <String>]`: dataSourceContainerStatus
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[ApplyHoldToSource <Boolean?>]`: Indicates if hold is applied to noncustodial data source (such as mailbox or site).
  - `[DataSource <IMicrosoftGraphEdiscoveryDataSource>]`: dataSource
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: The date and time the dataSource was created.
    - `[DisplayName <String>]`: The display name of the dataSource, and is the name of the SharePoint site.
    - `[HoldStatus <String>]`: dataSourceHoldStatus

`DATASOURCE <IMicrosoftGraphEdiscoveryDataSource>`: dataSource
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. This might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: The date and time the dataSource was created.
  - `[DisplayName <String>]`: The display name of the dataSource, and is the name of the SharePoint site.
  - `[HoldStatus <String>]`: dataSourceHoldStatus

`INPUTOBJECT <IComplianceIdentity>`: Identity Parameter
  - `[AuthoredNoteId <String>]`: The unique identifier of authoredNote
  - `[CaseId <String>]`: The unique identifier of case
  - `[CaseOperationId <String>]`: The unique identifier of caseOperation
  - `[CustodianId <String>]`: The unique identifier of custodian
  - `[DataSourceId <String>]`: The unique identifier of dataSource
  - `[LegalHoldId <String>]`: The unique identifier of legalHold
  - `[NoncustodialDataSourceId <String>]`: The unique identifier of noncustodialDataSource
  - `[ReviewSetId <String>]`: The unique identifier of reviewSet
  - `[ReviewSetQueryId <String>]`: The unique identifier of reviewSetQuery
  - `[SiteSourceId <String>]`: The unique identifier of siteSource
  - `[SourceCollectionId <String>]`: The unique identifier of sourceCollection
  - `[SubjectRightsRequestId <String>]`: The unique identifier of subjectRightsRequest
  - `[TagId <String>]`: The unique identifier of tag
  - `[TagId1 <String>]`: The unique identifier of tag
  - `[UnifiedGroupSourceId <String>]`: The unique identifier of unifiedGroupSource
  - `[UserId <String>]`: The unique identifier of user
  - `[UserSourceId <String>]`: The unique identifier of userSource

## RELATED LINKS

