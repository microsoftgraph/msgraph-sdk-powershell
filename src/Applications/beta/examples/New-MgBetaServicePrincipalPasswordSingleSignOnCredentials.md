### Example 1: Using the New-MgBetaServicePrincipalPasswordSingleSignOnCredentials Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Applications
$params = @{
	Id = "5793aa3b-cca9-4794-679a240f8b58"
	Credentials = @(
		@{
			FieldId = "param_username"
			Value = "myusername"
			Type = "username"
		}
		@{
			FieldId = "param_password"
			Value = "pa$$w0rd"
			Type = "password"
		}
	)
}
New-MgBetaServicePrincipalPasswordSingleSignOnCredentials -ServicePrincipalId $servicePrincipalId -BodyParameter $params
```
This example shows how to use the New-MgBetaServicePrincipalPasswordSingleSignOnCredentials Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
