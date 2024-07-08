### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Applications

$params = @{
	keyId = "f0b0b335-1d71-4883-8f98-567911bfdca6"
}

Remove-MgServicePrincipalPassword -ServicePrincipalId $servicePrincipalId -BodyParameter $params

```
This example shows how to use the Remove-MgServicePrincipalPassword Cmdlet.

