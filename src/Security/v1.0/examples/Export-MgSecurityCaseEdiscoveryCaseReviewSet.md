### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Security

$params = @{
	outputName = "Export via API"
	description = "Export for the Contoso investigation"
	exportOptions = "originalFiles,tags"
	exportStructure = "directory"
}

Export-MgSecurityCaseEdiscoveryCaseReviewSet -EdiscoveryCaseId $ediscoveryCaseId -EdiscoveryReviewSetId $ediscoveryReviewSetId -BodyParameter $params

```
This example shows how to use the Export-MgSecurityCaseEdiscoveryCaseReviewSet Cmdlet.

