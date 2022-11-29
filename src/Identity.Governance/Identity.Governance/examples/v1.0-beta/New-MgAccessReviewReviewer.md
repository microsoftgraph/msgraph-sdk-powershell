### Example 1: Using the New-MgAccessReviewReviewer Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	Id = "006111db-0810-4494-a6df-904d368bd81b"
}
New-MgAccessReviewReviewer -AccessReviewId $accessReviewId -BodyParameter $params
```
This example shows how to use the New-MgAccessReviewReviewer Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
