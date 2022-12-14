### Example 1: Using the New-MgBetaComplianceEdiscoveryCaseReviewSet Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Compliance
$params = @{
	DisplayName = "My Reviewset 3"
}
New-MgBetaComplianceEdiscoveryCaseReviewSet -CaseId $caseId -BodyParameter $params
```
This example shows how to use the New-MgBetaComplianceEdiscoveryCaseReviewSet Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
