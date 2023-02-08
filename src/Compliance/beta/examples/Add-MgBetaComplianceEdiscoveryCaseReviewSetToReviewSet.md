### Example 1: Using the Add-MgBetaComplianceEdiscoveryCaseReviewSetToReviewSet Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Compliance
$params = @{
	SourceCollection = @{
		Id = "1a9b4145d8f84e39bc45a7f68c5c5119"
	}
	AdditionalData = "linkedFiles"
}
Add-MgBetaComplianceEdiscoveryCaseReviewSetToReviewSet -CaseId $caseId -ReviewSetId $reviewSetId -BodyParameter $params
```
This example shows how to use the Add-MgBetaComplianceEdiscoveryCaseReviewSetToReviewSet Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
