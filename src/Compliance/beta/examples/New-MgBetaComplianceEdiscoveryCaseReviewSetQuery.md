### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Compliance

$params = @{
	displayName = "My Query 1"
	query = "(subject:"Quarterly Financials")"
}

New-MgBetaComplianceEdiscoveryCaseReviewSetQuery -CaseId $caseId -ReviewSetId $reviewSetId -BodyParameter $params

```
This example shows how to use the New-MgBetaComplianceEdiscoveryCaseReviewSetQuery Cmdlet.

