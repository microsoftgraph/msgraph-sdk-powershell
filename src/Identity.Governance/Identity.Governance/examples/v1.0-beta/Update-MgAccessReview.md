### Example 1: Using the Update-MgAccessReview Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	DisplayName = "TestReview new name"
}
Update-MgAccessReview -AccessReviewId $accessReviewId -BodyParameter $params
```
This example shows how to use the Update-MgAccessReview Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
