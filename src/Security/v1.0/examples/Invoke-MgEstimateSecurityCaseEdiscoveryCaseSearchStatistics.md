### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Security

$params = @{
	statisticsOptions = "includeRefiners, includeQueryStats, includeUnindexedStats, advancedIndexing, locationsWithoutHits"
}

Invoke-MgEstimateSecurityCaseEdiscoveryCaseSearchStatistics -EdiscoveryCaseId $ediscoveryCaseId -EdiscoverySearchId $ediscoverySearchId -BodyParameter $params

```
This example shows how to use the Invoke-MgEstimateSecurityCaseEdiscoveryCaseSearchStatistics Cmdlet.

