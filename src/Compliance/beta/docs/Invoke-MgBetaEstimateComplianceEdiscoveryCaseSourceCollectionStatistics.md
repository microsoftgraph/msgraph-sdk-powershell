---
external help file:
Module Name: Microsoft.Graph.Beta.Compliance
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.compliance/invoke-mgbetaestimatecomplianceediscoverycasesourcecollectionstatistics
schema: 2.0.0
---

# Invoke-MgBetaEstimateComplianceEdiscoveryCaseSourceCollectionStatistics

## SYNOPSIS
Run an estimate of the number of emails and documents in the source collection.
To learn more about source collections (also known as searches in eDiscovery), see Collect data for a case in Advanced eDiscovery.

## SYNTAX

### Estimate (Default)
```
Invoke-MgBetaEstimateComplianceEdiscoveryCaseSourceCollectionStatistics -CaseId <String>
 -SourceCollectionId <String> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### EstimateViaIdentity
```
Invoke-MgBetaEstimateComplianceEdiscoveryCaseSourceCollectionStatistics -InputObject <IComplianceIdentity>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Run an estimate of the number of emails and documents in the source collection.
To learn more about source collections (also known as searches in eDiscovery), see Collect data for a case in Advanced eDiscovery.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.Compliance
Invoke-MgBetaEstimateComplianceEdiscoveryCaseSourceCollectionStatistics -CaseId $caseId -SourceCollectionId $sourceCollectionId
```



## PARAMETERS

### -CaseId
The unique identifier of case

```yaml
Type: System.String
Parameter Sets: Estimate
Aliases:

Required: True
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
Parameter Sets: EstimateViaIdentity
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

### -SourceCollectionId
The unique identifier of sourceCollection

```yaml
Type: System.String
Parameter Sets: Estimate
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

### Microsoft.Graph.Beta.PowerShell.Models.IComplianceIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


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

