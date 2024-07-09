### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Applications

$params = @{
	id = "5793aa3b-cca9-4794-679a240f8b58"
}

Get-MgBetaServicePrincipalPasswordSingleSignOnCredential -ServicePrincipalId $servicePrincipalId -BodyParameter $params

```
This example shows how to use the Get-MgBetaServicePrincipalPasswordSingleSignOnCredential Cmdlet.

