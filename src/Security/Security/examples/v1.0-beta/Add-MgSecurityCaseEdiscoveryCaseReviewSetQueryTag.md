### Example 1: Using the Add-MgBetaSecurityCaseEdiscoveryCaseReviewSetQueryTag Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Security
$params = @{
	TagsToAdd = @(
		@{
			Id = "d3d99dc704a74801b792b3e1e722aa0d"
		}
	)
}
Add-MgBetaSecurityCaseEdiscoveryCaseReviewSetQueryTag -EdiscoveryCaseId $ediscoveryCaseId -EdiscoveryReviewSetId $ediscoveryReviewSetId -EdiscoveryReviewSetQueryId $ediscoveryReviewSetQueryId -BodyParameter $params
```
This example shows how to use the Add-MgBetaSecurityCaseEdiscoveryCaseReviewSetQueryTag Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
