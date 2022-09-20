### Example 1: Using the Add-MgComplianceEdiscoveryCaseReviewSetQueryTag Cmdlet
```powershell
Import-Module Microsoft.Graph.Compliance
$params = @{
	TagsToAdd = @(
		@{
			Id = "b4798d14-748d-468e-a1ec-96a2b1d49677"
		}
	)
}
Add-MgComplianceEdiscoveryCaseReviewSetQueryTag -CaseId $caseId -ReviewSetId $reviewSetId -ReviewSetQueryId $reviewSetQueryId -BodyParameter $params
```
This example shows how to use the Add-MgComplianceEdiscoveryCaseReviewSetQueryTag Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
