---
external help file:
Module Name: Microsoft.Graph.Security
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.security/add-mgsecuritycaseediscoverycasenoncustodialdatasourcehold
schema: 2.0.0
---

# Add-MgSecurityCaseEdiscoveryCaseNoncustodialDataSourceHold

## SYNOPSIS
Start the process of applying hold on eDiscovery non-custodial data sources.
After the operation is created, you can get the status by retrieving the `Location` parameter from the response headers.
The location provides a URL that will return an eDiscoveryHoldOperation object.

## SYNTAX

### ApplyExpanded (Default)
```
Add-MgSecurityCaseEdiscoveryCaseNoncustodialDataSourceHold -EdiscoveryCaseId <String>
 [-AdditionalProperties <Hashtable>] [-Ids <String[]>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Apply
```
Add-MgSecurityCaseEdiscoveryCaseNoncustodialDataSourceHold -EdiscoveryCaseId <String>
 -EdiscoveryNoncustodialDataSourceId <String> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Apply1
```
Add-MgSecurityCaseEdiscoveryCaseNoncustodialDataSourceHold -EdiscoveryCaseId <String>
 -BodyParameter <IPathsUr2Sc1SecurityCasesEdiscoverycasesEdiscoverycaseIdNoncustodialdatasourcesMicrosoftGraphSecurityApplyholdPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ApplyViaIdentity
```
Add-MgSecurityCaseEdiscoveryCaseNoncustodialDataSourceHold -InputObject <ISecurityIdentity> [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ApplyViaIdentity1
```
Add-MgSecurityCaseEdiscoveryCaseNoncustodialDataSourceHold -InputObject <ISecurityIdentity>
 -BodyParameter <IPathsUr2Sc1SecurityCasesEdiscoverycasesEdiscoverycaseIdNoncustodialdatasourcesMicrosoftGraphSecurityApplyholdPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ApplyViaIdentityExpanded
```
Add-MgSecurityCaseEdiscoveryCaseNoncustodialDataSourceHold -InputObject <ISecurityIdentity>
 [-AdditionalProperties <Hashtable>] [-Ids <String[]>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Start the process of applying hold on eDiscovery non-custodial data sources.
After the operation is created, you can get the status by retrieving the `Location` parameter from the response headers.
The location provides a URL that will return an eDiscoveryHoldOperation object.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Import-Module Microsoft.Graph.Security
Add-MgSecurityCaseEdiscoveryCaseNoncustodialDataSourceHold -EdiscoveryCaseId $ediscoveryCaseId -EdiscoveryNoncustodialDataSourceId $ediscoveryNoncustodialDataSourceId
```



### -------------------------- EXAMPLE 2 --------------------------
```powershell
Import-Module Microsoft.Graph.Security
Add-MgSecurityCaseEdiscoveryCaseNoncustodialDataSourceHold -EdiscoveryCaseId $ediscoveryCaseId -EdiscoveryNoncustodialDataSourceId $ediscoveryNoncustodialDataSourceId
```



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
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IPathsUr2Sc1SecurityCasesEdiscoverycasesEdiscoverycaseIdNoncustodialdatasourcesMicrosoftGraphSecurityApplyholdPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Apply1, ApplyViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -EdiscoveryCaseId
The unique identifier of ediscoveryCase

```yaml
Type: System.String
Parameter Sets: Apply, Apply1, ApplyExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EdiscoveryNoncustodialDataSourceId
The unique identifier of ediscoveryNoncustodialDataSource

```yaml
Type: System.String
Parameter Sets: Apply
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Ids
.

```yaml
Type: System.String[]
Parameter Sets: ApplyExpanded, ApplyViaIdentityExpanded
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
Parameter Sets: ApplyViaIdentity, ApplyViaIdentity1, ApplyViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IPathsUr2Sc1SecurityCasesEdiscoverycasesEdiscoverycaseIdNoncustodialdatasourcesMicrosoftGraphSecurityApplyholdPostRequestbodyContentApplicationJsonSchema

### Microsoft.Graph.PowerShell.Models.ISecurityIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IPathsUr2Sc1SecurityCasesEdiscoverycasesEdiscoverycaseIdNoncustodialdatasourcesMicrosoftGraphSecurityApplyholdPostRequestbodyContentApplicationJsonSchema>`: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Ids <String[]>]`: 

`INPUTOBJECT <ISecurityIdentity>`: Identity Parameter
  - `[AlertId <String>]`: The unique identifier of alert
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
  - `[IncidentId <String>]`: The unique identifier of incident
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

## RELATED LINKS

