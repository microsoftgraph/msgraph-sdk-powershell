### Example 1: Using the Update-MgBetaComplianceEdiscoveryCaseReviewSetQuery Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Compliance
$params = @{
	DisplayName = "My Query 1 - Renamed"
}
Update-MgBetaComplianceEdiscoveryCaseReviewSetQuery -CaseId $caseId -ReviewSetId $reviewSetId -ReviewSetQueryId $reviewSetQueryId -BodyParameter $params
```
This example shows how to use the Update-MgBetaComplianceEdiscoveryCaseReviewSetQuery Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
