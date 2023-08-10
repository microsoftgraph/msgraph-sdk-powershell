### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Applications

$params = @{
	passwordCredential = @{
		displayName = "Password friendly name"
	}
}

Add-MgServicePrincipalPassword -ServicePrincipalId $servicePrincipalId -BodyParameter $params

```
This example shows how to use the Add-MgServicePrincipalPassword Cmdlet.

