### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	search = @{
		id = "c17e91d6-6bc0-4ecb-b388-269ea3d4ffb7"
	}
	additionalDataOptions = "linkedFiles"
	cloudAttachmentVersion = "latest"
	documentVersion = "recent10"
}

Add-MgBetaSecurityCaseEdiscoveryCaseReviewSetToReviewSet -EdiscoveryCaseId $ediscoveryCaseId -EdiscoveryReviewSetId $ediscoveryReviewSetId -BodyParameter $params

```
This example shows how to use the Add-MgBetaSecurityCaseEdiscoveryCaseReviewSetToReviewSet Cmdlet.

