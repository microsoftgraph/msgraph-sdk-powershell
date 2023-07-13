### Example 1: Using the Invoke-MgBetaInstantiateApplicationTemplate Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Applications
$params = @{
	DisplayName = "testProperties"
}
Invoke-MgBetaInstantiateApplicationTemplate -ApplicationTemplateId $applicationTemplateId -BodyParameter $params
```
This example shows how to use the Invoke-MgBetaInstantiateApplicationTemplate Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
