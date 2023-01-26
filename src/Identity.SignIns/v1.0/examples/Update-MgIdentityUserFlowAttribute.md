### Example 1: Using the Update-MgIdentityUserFlowAttribute Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	Description = "Your new hobby"
}
Update-MgIdentityUserFlowAttribute -IdentityUserFlowAttributeId $identityUserFlowAttributeId -BodyParameter $params
```
This example shows how to use the Update-MgIdentityUserFlowAttribute Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
