### Example 1: Using the Export-MgBetaSecurityCaseEdiscoveryCaseReviewSet Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Security
$params = @{
	OutputName = "Export via API"
	Description = "Export for the Contoso investigation"
	ExportOptions = "originalFiles,fileInfo,tags"
	ExportStructure = "directory"
}
Export-MgBetaSecurityCaseEdiscoveryCaseReviewSet -EdiscoveryCaseId $ediscoveryCaseId -EdiscoveryReviewSetId $ediscoveryReviewSetId -BodyParameter $params
```
This example shows how to use the Export-MgBetaSecurityCaseEdiscoveryCaseReviewSet Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
