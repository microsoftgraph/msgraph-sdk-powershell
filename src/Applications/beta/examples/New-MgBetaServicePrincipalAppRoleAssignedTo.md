### Example 1: Using the New-MgBetaServicePrincipalAppRoleAssignedTo Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Applications
$params = @{
	PrincipalId = "33ad69f9-da99-4bed-acd0-3f24235cb296"
	ResourceId = "9028d19c-26a9-4809-8e3f-20ff73e2d75e"
	AppRoleId = "ef7437e6-4f94-4a0a-a110-a439eb2aa8f7"
}
New-MgBetaServicePrincipalAppRoleAssignedTo -ServicePrincipalId $servicePrincipalId -BodyParameter $params
```
This example shows how to use the New-MgBetaServicePrincipalAppRoleAssignedTo Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
