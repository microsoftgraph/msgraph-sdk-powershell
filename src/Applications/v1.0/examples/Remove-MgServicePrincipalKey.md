### Example 1: Using the Remove-MgServicePrincipalKey Cmdlet
```powershell
Import-Module Microsoft.Graph.Applications
$params = @{
	KeyId = "f0b0b335-1d71-4883-8f98-567911bfdca6"
	Proof = "eyJ0eXAiOiJ..."
}
Remove-MgServicePrincipalKey -ServicePrincipalId $servicePrincipalId -BodyParameter $params
```
This example shows how to use the Remove-MgServicePrincipalKey Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
