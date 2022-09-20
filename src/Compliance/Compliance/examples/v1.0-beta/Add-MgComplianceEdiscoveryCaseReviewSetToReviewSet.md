### Example 1: Using the Add-MgComplianceEdiscoveryCaseReviewSetToReviewSet Cmdlet
```powershell
Import-Module Microsoft.Graph.Compliance
$params = @{
	SourceCollection = @{
		Id = "1a9b4145d8f84e39bc45a7f68c5c5119"
	}
	AdditionalData = "linkedFiles"
}
Add-MgComplianceEdiscoveryCaseReviewSetToReviewSet -CaseId $caseId -ReviewSetId $reviewSetId -BodyParameter $params
```
This example shows how to use the Add-MgComplianceEdiscoveryCaseReviewSetToReviewSet Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
