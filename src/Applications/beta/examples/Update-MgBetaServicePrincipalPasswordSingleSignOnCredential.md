### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Applications

$params = @{
	id = "5793aa3b-cca9-4794-679a240f8b58"
	credentials = @(
		@{
			fieldId = "param_username"
			value = "myusername"
			type = "username"
		}
		@{
			fieldId = "param_password"
			value = "pa$$w0rd"
			type = "password"
		}
	)
}

Update-MgBetaServicePrincipalPasswordSingleSignOnCredential -ServicePrincipalId $servicePrincipalId -BodyParameter $params

```
This example shows how to use the Update-MgBetaServicePrincipalPasswordSingleSignOnCredential Cmdlet.

