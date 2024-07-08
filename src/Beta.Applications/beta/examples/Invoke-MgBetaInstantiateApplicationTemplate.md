### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Applications

$params = @{
	displayName = "testProperties"
}

Invoke-MgBetaInstantiateApplicationTemplate -ApplicationTemplateId $applicationTemplateId -BodyParameter $params

```
This example shows how to use the Invoke-MgBetaInstantiateApplicationTemplate Cmdlet.

