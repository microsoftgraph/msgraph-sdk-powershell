### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	allowExternalIdentitiesToLeave = $false
}

Update-MgBetaPolicyExternalIdentityPolicy -BodyParameter $params

```
This example shows how to use the Update-MgBetaPolicyExternalIdentityPolicy Cmdlet.

