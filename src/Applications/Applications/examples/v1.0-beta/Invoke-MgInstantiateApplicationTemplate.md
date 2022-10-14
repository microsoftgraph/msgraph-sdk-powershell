### Example 1: Using the Invoke-MgInstantiateApplicationTemplate Cmdlet
```powershell
Import-Module Microsoft.Graph.Applications
$params = @{
	DisplayName = "testProperties"
}
Invoke-MgInstantiateApplicationTemplate -ApplicationTemplateId $applicationTemplateId -BodyParameter $params
```
This example shows how to use the Invoke-MgInstantiateApplicationTemplate Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
