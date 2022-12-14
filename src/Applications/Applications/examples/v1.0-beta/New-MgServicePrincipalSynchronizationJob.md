### Example 1: Using the New-MgBetaServicePrincipalSynchronizationJob Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Applications
$params = @{
	TemplateId = "BoxOutDelta"
}
New-MgBetaServicePrincipalSynchronizationJob -ServicePrincipalId $servicePrincipalId -BodyParameter $params
```
This example shows how to use the New-MgBetaServicePrincipalSynchronizationJob Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
