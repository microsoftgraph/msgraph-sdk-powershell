### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	tagsToAdd = @(
		@{
			id = "d3d99dc704a74801b792b3e1e722aa0d"
		}
	)
}

Add-MgBetaSecurityCaseEdiscoveryCaseReviewSetQueryTag -EdiscoveryCaseId $ediscoveryCaseId -EdiscoveryReviewSetId $ediscoveryReviewSetId -EdiscoveryReviewSetQueryId $ediscoveryReviewSetQueryId -BodyParameter $params

```
This example shows how to use the Add-MgBetaSecurityCaseEdiscoveryCaseReviewSetQueryTag Cmdlet.

