### Example 1: Using the New-MgComplianceEdiscoveryCaseReviewSet Cmdlet
```powershell
Import-Module Microsoft.Graph.Compliance
$params = @{
	DisplayName = "My Reviewset 3"
}
New-MgComplianceEdiscoveryCaseReviewSet -CaseId $caseId -BodyParameter $params
```
This example shows how to use the New-MgComplianceEdiscoveryCaseReviewSet Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
