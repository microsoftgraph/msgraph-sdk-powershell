### Example 1: Using the Add-MgSecurityCaseEdiscoveryCaseReviewSetToReviewSet Cmdlet
```powershell
Import-Module Microsoft.Graph.Security
$params = @{
	Search = @{
		Id = "c17e91d6-6bc0-4ecb-b388-269ea3d4ffb7"
	}
	AdditionalDataOptions = "linkedFiles"
}
Add-MgSecurityCaseEdiscoveryCaseReviewSetToReviewSet -EdiscoveryCaseId $ediscoveryCaseId -EdiscoveryReviewSetId $ediscoveryReviewSetId -BodyParameter $params
```
This example shows how to use the Add-MgSecurityCaseEdiscoveryCaseReviewSetToReviewSet Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
