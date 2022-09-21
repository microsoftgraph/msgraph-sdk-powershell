### Example 1: Using the Update-MgSearchAcronym Cmdlet
```powershell
Import-Module Microsoft.Graph.Search
$params = @{
	Description = "A deep neural network is a neural network with a certain level of complexity, a neural network with more than two layers."
}
Update-MgSearchAcronym -AcronymId $acronymId -BodyParameter $params
```
This example shows how to use the Update-MgSearchAcronym Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
