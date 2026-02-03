### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Search

$params = @{
	description = "A deep neural network is a neural network with a certain level of complexity, a neural network with more than two layers."
}

Update-MgBetaSearchAcronym -AcronymId $acronymId -BodyParameter $params

```
This example shows how to use the Update-MgBetaSearchAcronym Cmdlet.

