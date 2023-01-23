### Example 1: Using the Get-MgBetaServicePrincipalPasswordSingleSignOnCredentials Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Applications
$params = @{
	Id = "5793aa3b-cca9-4794-679a240f8b58"
}
Get-MgBetaServicePrincipalPasswordSingleSignOnCredentials -ServicePrincipalId $servicePrincipalId -BodyParameter $params
```
This example shows how to use the Get-MgBetaServicePrincipalPasswordSingleSignOnCredentials Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
