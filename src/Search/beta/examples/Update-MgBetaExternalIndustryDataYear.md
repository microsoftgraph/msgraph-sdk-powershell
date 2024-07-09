### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Search

$params = @{
	displayName = "Fiscal Year 2022"
	id = "ebf18762-ab92-487e-21d1-08daddab28bb"
}

Update-MgBetaExternalIndustryDataYear -YearTimePeriodDefinitionId $yearTimePeriodDefinitionId -BodyParameter $params

```
This example shows how to use the Update-MgBetaExternalIndustryDataYear Cmdlet.

