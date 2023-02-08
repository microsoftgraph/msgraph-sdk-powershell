### Example 1: Using the New-MgBetaSearchAcronym Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Search
$params = @{
	DisplayName = "DNN"
	StandsFor = "Deep Neural Network"
	Description = "A deep neural network is a neural network with a certain level of complexity, a neural network with more than two layers."
	WebUrl = "http://microsoft.com/deep-neural-network"
	State = "draft"
}
New-MgBetaSearchAcronym -BodyParameter $params
```
This example shows how to use the New-MgBetaSearchAcronym Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
