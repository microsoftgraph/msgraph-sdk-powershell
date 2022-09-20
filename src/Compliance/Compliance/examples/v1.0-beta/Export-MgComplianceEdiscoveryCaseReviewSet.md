### Example 1: Using the Export-MgComplianceEdiscoveryCaseReviewSet Cmdlet
```powershell
Import-Module Microsoft.Graph.Compliance
$params = @{
	OutputName = "2020-12-06 Contoso investigation export"
	Description = "Export for the Contoso investigation"
	ExportOptions = "originalFiles,fileInfo,tags"
	ExportStructure = "directory"
}
Export-MgComplianceEdiscoveryCaseReviewSet -CaseId $caseId -ReviewSetId $reviewSetId -BodyParameter $params
```
This example shows how to use the Export-MgComplianceEdiscoveryCaseReviewSet Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
