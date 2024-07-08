### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	outputName = "Export reviewset query via API"
	description = "Export for the Contoso investigation 2"
	exportOptions = "originalFiles,fileInfo,tags"
	exportStructure = "directory"
}

Export-MgBetaSecurityCaseEdiscoveryCaseReviewSetQuery -EdiscoveryCaseId $ediscoveryCaseId -EdiscoveryReviewSetId $ediscoveryReviewSetId -EdiscoveryReviewSetQueryId $ediscoveryReviewSetQueryId -BodyParameter $params

```
This example shows how to use the Export-MgBetaSecurityCaseEdiscoveryCaseReviewSetQuery Cmdlet.

