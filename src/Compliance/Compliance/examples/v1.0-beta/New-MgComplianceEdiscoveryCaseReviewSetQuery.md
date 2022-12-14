### Example 1: Using the New-MgBetaComplianceEdiscoveryCaseReviewSetQuery Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Compliance
$params = @{
	DisplayName = "My Query 1"
	Query = "(subject:"Quarterly Financials")"
}
New-MgBetaComplianceEdiscoveryCaseReviewSetQuery -CaseId $caseId -ReviewSetId $reviewSetId -BodyParameter $params
```
This example shows how to use the New-MgBetaComplianceEdiscoveryCaseReviewSetQuery Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
