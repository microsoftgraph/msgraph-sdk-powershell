### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Search

$params = @{
	vendor = "LMS Vendor"
}

Update-MgBetaExternalIndustryDataSourceSystem -SourceSystemDefinitionId $sourceSystemDefinitionId -BodyParameter $params

```
This example shows how to use the Update-MgBetaExternalIndustryDataSourceSystem Cmdlet.

