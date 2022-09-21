### Example 1: Using the Get-MgComplianceEdiscoveryCaseSourceCollection Cmdlet
```powershell
Import-Module Microsoft.Graph.Compliance
Get-MgComplianceEdiscoveryCaseSourceCollection -CaseId $caseId -SourceCollectionId $sourceCollectionId -ExpandProperty "addToReviewSetOperation,custodianSources,lastEstimateStatisticsOperation" 
```
This example shows how to use the Get-MgComplianceEdiscoveryCaseSourceCollection Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgComplianceEdiscoveryCaseSourceCollection Cmdlet
```powershell
Import-Module Microsoft.Graph.Compliance
Get-MgComplianceEdiscoveryCaseSourceCollection -CaseId $caseId
```
This example shows how to use the Get-MgComplianceEdiscoveryCaseSourceCollection Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
