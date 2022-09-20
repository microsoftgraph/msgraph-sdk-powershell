### Example 1: Using the New-MgSearchAcronym Cmdlet
```powershell
Import-Module Microsoft.Graph.Search
$params = @{
	DisplayName = "DNN"
	StandsFor = "Deep Neural Network"
	Description = "A deep neural network is a neural network with a certain level of complexity, a neural network with more than two layers."
	WebUrl = "http://microsoft.com/deep-neural-network"
	State = "draft"
}
New-MgSearchAcronym -BodyParameter $params
```
This example shows how to use the New-MgSearchAcronym Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
