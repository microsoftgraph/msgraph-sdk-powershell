### Example 1: Using the Update-MgBetaSearchAcronym Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Search
$params = @{
	Description = "A deep neural network is a neural network with a certain level of complexity, a neural network with more than two layers."
}
Update-MgBetaSearchAcronym -AcronymId $acronymId -BodyParameter $params
```
This example shows how to use the Update-MgBetaSearchAcronym Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
