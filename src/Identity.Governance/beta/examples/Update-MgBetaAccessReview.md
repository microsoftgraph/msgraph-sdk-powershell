### Example 1: Using the Update-MgBetaAccessReview Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.Governance
$params = @{
	DisplayName = "TestReview new name"
}
Update-MgBetaAccessReview -AccessReviewId $accessReviewId -BodyParameter $params
```
This example shows how to use the Update-MgBetaAccessReview Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
