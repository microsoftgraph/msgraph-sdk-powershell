### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Identity.SignIns

$params = @{
	description = "Your new hobby"
}

Update-MgIdentityUserFlowAttribute -IdentityUserFlowAttributeId $identityUserFlowAttributeId -BodyParameter $params
```
This example shows how to use the Remove-MgIdentityUserFlowAttribute Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

