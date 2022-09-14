### Example 1: Using the New-MgSecurityCaseEdiscoveryCaseReviewSetQuery Cmdlet
```powershell
Import-Module Microsoft.Graph.Security
$params = @{
	DisplayName = "My Query 1"
	ContentQuery = "(Author="edison")"
}
New-MgSecurityCaseEdiscoveryCaseReviewSetQuery -EdiscoveryCaseId $ediscoveryCaseId -EdiscoveryReviewSetId $ediscoveryReviewSetId -BodyParameter $params
```
This example shows how to use the New-MgSecurityCaseEdiscoveryCaseReviewSetQuery Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
