### Example 1: Using the New-MgIdentityUserFlowAttribute Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	DisplayName = "Hobby"
	Description = "Your hobby"
	DataType = "string"
}
New-MgIdentityUserFlowAttribute -BodyParameter $params
```
This example shows how to use the New-MgIdentityUserFlowAttribute Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
