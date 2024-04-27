### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Compliance

$params = @{
	outputName = "2020-12-06 Contoso investigation export"
	description = "Export for the Contoso investigation"
	exportOptions = "originalFiles,fileInfo,tags"
	exportStructure = "directory"
}

Export-MgBetaComplianceEdiscoveryCaseReviewSet -CaseId $caseId -ReviewSetId $reviewSetId -BodyParameter $params

```
This example shows how to use the Export-MgBetaComplianceEdiscoveryCaseReviewSet Cmdlet.

