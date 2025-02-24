### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	statisticsOptions = "includeRefiners, includeQueryStats, includeUnindexedStats, advancedIndexing, locationsWithoutHits"
}

Invoke-MgBetaEstimateSecurityCaseEdiscoveryCaseSearchStatistics -EdiscoveryCaseId $ediscoveryCaseId -EdiscoverySearchId $ediscoverySearchId -BodyParameter $params

```
This example shows how to use the Invoke-MgBetaEstimateSecurityCaseEdiscoveryCaseSearchStatistics Cmdlet.

