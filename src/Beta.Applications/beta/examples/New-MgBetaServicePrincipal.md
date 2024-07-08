### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Applications

$params = @{
	appId = "65415bb1-9267-4313-bbf5-ae259732ee12"
}

New-MgBetaServicePrincipal -BodyParameter $params

```
This example shows how to use the New-MgBetaServicePrincipal Cmdlet.

