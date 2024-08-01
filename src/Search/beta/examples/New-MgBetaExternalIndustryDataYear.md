### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Search

$params = @{
	displayName = "Fiscal Year 2022"
	endDate = "2023-06-15"
	startDate = "2022-09-01"
	year = @{
		code = "2022"
	}
}

New-MgBetaExternalIndustryDataYear -BodyParameter $params

```
This example shows how to use the New-MgBetaExternalIndustryDataYear Cmdlet.

