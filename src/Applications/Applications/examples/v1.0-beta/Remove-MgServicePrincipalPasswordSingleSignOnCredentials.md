### Example 1: Using the Remove-MgBetaServicePrincipalPasswordSingleSignOnCredentials Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Applications
$params = @{
	Id = "5793aa3b-cca9-4794-679a240f8b58"
}
Remove-MgBetaServicePrincipalPasswordSingleSignOnCredentials -ServicePrincipalId $servicePrincipalId -BodyParameter $params
```
This example shows how to use the Remove-MgBetaServicePrincipalPasswordSingleSignOnCredentials Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
