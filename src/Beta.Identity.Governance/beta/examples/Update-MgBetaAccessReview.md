### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

$params = @{
	displayName = "TestReview new name"
}

Update-MgBetaAccessReview -AccessReviewId $accessReviewId -BodyParameter $params

```
This example shows how to use the Update-MgBetaAccessReview Cmdlet.

