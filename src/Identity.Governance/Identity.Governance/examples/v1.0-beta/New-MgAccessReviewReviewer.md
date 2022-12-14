### Example 1: Using the New-MgBetaAccessReviewReviewer Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.Governance
$params = @{
	Id = "006111db-0810-4494-a6df-904d368bd81b"
}
New-MgBetaAccessReviewReviewer -AccessReviewId $accessReviewId -BodyParameter $params
```
This example shows how to use the New-MgBetaAccessReviewReviewer Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
