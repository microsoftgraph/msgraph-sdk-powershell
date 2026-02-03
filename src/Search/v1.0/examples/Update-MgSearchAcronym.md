### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Search

$params = @{
	description = "A deep neural network is a neural network with a certain level of complexity, a neural network with more than two layers."
}

Update-MgSearchAcronym -AcronymId $acronymId -BodyParameter $params

```
This example shows how to use the Update-MgSearchAcronym Cmdlet.

