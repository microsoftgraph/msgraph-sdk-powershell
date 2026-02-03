### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

$params = @{
	id = "006111db-0810-4494-a6df-904d368bd81b"
}

New-MgBetaAccessReviewReviewer -AccessReviewId $accessReviewId -BodyParameter $params

```
This example shows how to use the New-MgBetaAccessReviewReviewer Cmdlet.

