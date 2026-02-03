### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Compliance

$params = @{
	displayName = "My Query 1 - Renamed"
}

Update-MgBetaComplianceEdiscoveryCaseReviewSetQuery -CaseId $caseId -ReviewSetId $reviewSetId -ReviewSetQueryId $reviewSetQueryId -BodyParameter $params

```
This example shows how to use the Update-MgBetaComplianceEdiscoveryCaseReviewSetQuery Cmdlet.

