### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	displayName = "Hobby"
	description = "Your hobby"
	dataType = "string"
}

New-MgBetaIdentityUserFlowAttribute -BodyParameter $params
```
This example shows how to use the New-MgBetaBetaIdentityUserFlowAttribute Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

