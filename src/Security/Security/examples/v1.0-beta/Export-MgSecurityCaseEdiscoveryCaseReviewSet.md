### Example 1: Using the Export-MgSecurityCaseEdiscoveryCaseReviewSet Cmdlet
```powershell
Import-Module Microsoft.Graph.Security
$params = @{
	OutputName = "Export via API"
	Description = "Export for the Contoso investigation"
	ExportOptions = "originalFiles,fileInfo,tags"
	ExportStructure = "directory"
}
Export-MgSecurityCaseEdiscoveryCaseReviewSet -EdiscoveryCaseId $ediscoveryCaseId -EdiscoveryReviewSetId $ediscoveryReviewSetId -BodyParameter $params
```
This example shows how to use the Export-MgSecurityCaseEdiscoveryCaseReviewSet Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
