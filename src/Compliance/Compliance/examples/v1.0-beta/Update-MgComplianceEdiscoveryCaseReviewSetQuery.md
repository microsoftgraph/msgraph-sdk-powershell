### Example 1: Using the Update-MgComplianceEdiscoveryCaseReviewSetQuery Cmdlet
```powershell
Import-Module Microsoft.Graph.Compliance
$params = @{
	DisplayName = "My Query 1 - Renamed"
}
Update-MgComplianceEdiscoveryCaseReviewSetQuery -CaseId $caseId -ReviewSetId $reviewSetId -ReviewSetQueryId $reviewSetQueryId -BodyParameter $params
```
This example shows how to use the Update-MgComplianceEdiscoveryCaseReviewSetQuery Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
