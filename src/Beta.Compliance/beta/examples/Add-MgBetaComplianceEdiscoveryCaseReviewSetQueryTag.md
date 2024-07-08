### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Compliance

$params = @{
	tagsToAdd = @(
		@{
			id = "b4798d14-748d-468e-a1ec-96a2b1d49677"
		}
	)
}

Add-MgBetaComplianceEdiscoveryCaseReviewSetQueryTag -CaseId $caseId -ReviewSetId $reviewSetId -ReviewSetQueryId $reviewSetQueryId -BodyParameter $params

```
This example shows how to use the Add-MgBetaComplianceEdiscoveryCaseReviewSetQueryTag Cmdlet.

