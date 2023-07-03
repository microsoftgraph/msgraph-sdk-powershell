### Example 1: Using the Get-MgBetaComplianceEdiscoveryCaseSourceCollection Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Compliance
Get-MgBetaComplianceEdiscoveryCaseSourceCollection -CaseId $caseId -SourceCollectionId $sourceCollectionId -ExpandProperty "addToReviewSetOperation,custodianSources,lastEstimateStatisticsOperation" 
```
This example shows how to use the Get-MgBetaComplianceEdiscoveryCaseSourceCollection Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaComplianceEdiscoveryCaseSourceCollection Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Compliance
Get-MgBetaComplianceEdiscoveryCaseSourceCollection -CaseId $caseId
```
This example shows how to use the Get-MgBetaComplianceEdiscoveryCaseSourceCollection Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
