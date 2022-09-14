### Example 1: Using the Update-MgSecurityCaseEdiscoveryCaseReviewSetQuery Cmdlet
```powershell
Import-Module Microsoft.Graph.Security
$params = @{
	DisplayName = "My Query 1 (update)"
	ContentQuery = "(Author="edisons")"
}
Update-MgSecurityCaseEdiscoveryCaseReviewSetQuery -EdiscoveryCaseId $ediscoveryCaseId -EdiscoveryReviewSetId $ediscoveryReviewSetId -EdiscoveryReviewSetQueryId $ediscoveryReviewSetQueryId -BodyParameter $params
```
This example shows how to use the Update-MgSecurityCaseEdiscoveryCaseReviewSetQuery Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
