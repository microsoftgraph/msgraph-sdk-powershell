### Example 1: Using the New-MgBetaSecurityCaseEdiscoveryCaseReviewSetQuery Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Security
$params = @{
	DisplayName = "My Query 1"
	ContentQuery = "(Author="edison")"
}
New-MgBetaSecurityCaseEdiscoveryCaseReviewSetQuery -EdiscoveryCaseId $ediscoveryCaseId -EdiscoveryReviewSetId $ediscoveryReviewSetId -BodyParameter $params
```
This example shows how to use the New-MgBetaSecurityCaseEdiscoveryCaseReviewSetQuery Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
