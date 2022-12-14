### Example 1: Using the New-MgBetaIdentityUserFlowAttribute Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	DisplayName = "Hobby"
	Description = "Your hobby"
	DataType = "string"
}
New-MgBetaIdentityUserFlowAttribute -BodyParameter $params
```
This example shows how to use the New-MgBetaIdentityUserFlowAttribute Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
