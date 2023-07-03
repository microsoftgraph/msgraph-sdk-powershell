### Example 1: Using the Add-MgServicePrincipalPassword Cmdlet
```powershell
Import-Module Microsoft.Graph.Applications
$params = @{
	PasswordCredential = @{
		DisplayName = "Password friendly name"
	}
}
Add-MgServicePrincipalPassword -ServicePrincipalId $servicePrincipalId -BodyParameter $params
```
This example shows how to use the Add-MgServicePrincipalPassword Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
