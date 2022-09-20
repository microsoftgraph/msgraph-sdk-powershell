### Example 1: Using the New-MgServicePrincipalSynchronizationJob Cmdlet
```powershell
Import-Module Microsoft.Graph.Applications
$params = @{
	TemplateId = "BoxOutDelta"
}
New-MgServicePrincipalSynchronizationJob -ServicePrincipalId $servicePrincipalId -BodyParameter $params
```
This example shows how to use the New-MgServicePrincipalSynchronizationJob Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
