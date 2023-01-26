### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	DisplayName = "CrossTenantAccessPolicy"
}

Update-MgBetaPolicyCrossTenantAccessPolicy -BodyParameter $params
```
This example shows how to use the Remove-MgBetaPolicyCrossTenantAccessPolicy Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

