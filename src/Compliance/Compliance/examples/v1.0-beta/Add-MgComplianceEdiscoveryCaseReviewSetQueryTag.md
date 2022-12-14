### Example 1: Using the Add-MgBetaComplianceEdiscoveryCaseReviewSetQueryTag Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Compliance
$params = @{
	TagsToAdd = @(
		@{
			Id = "b4798d14-748d-468e-a1ec-96a2b1d49677"
		}
	)
}
Add-MgBetaComplianceEdiscoveryCaseReviewSetQueryTag -CaseId $caseId -ReviewSetId $reviewSetId -ReviewSetQueryId $reviewSetQueryId -BodyParameter $params
```
This example shows how to use the Add-MgBetaComplianceEdiscoveryCaseReviewSetQueryTag Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
