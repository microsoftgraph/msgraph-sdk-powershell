### Example 1: Create a new servicePrincipal if it doesn't exist

```powershell

Import-Module Microsoft.Graph.Beta.Applications

$params = @{
	displayName = "My app instance"
}

Update-MgBetaServicePrincipalByAppId -BodyParameter $params

```
This example will create a new serviceprincipal if it doesn't exist

### Example 2: Update an existing servicePrincipal

```powershell

Import-Module Microsoft.Graph.Beta.Applications

$params = @{
	displayName = "My app instance"
}

Update-MgBetaServicePrincipalByAppId -BodyParameter $params

```
This example will update an existing serviceprincipal

