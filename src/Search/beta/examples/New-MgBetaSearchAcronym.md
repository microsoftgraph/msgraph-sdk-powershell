### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Search

$params = @{
	displayName = "DNN"
	standsFor = "Deep Neural Network"
	description = "A deep neural network is a neural network with a certain level of complexity, a neural network with more than two layers."
	webUrl = "http://microsoft.com/deep-neural-network"
	state = "draft"
}

New-MgBetaSearchAcronym -BodyParameter $params

```
This example shows how to use the New-MgBetaSearchAcronym Cmdlet.

