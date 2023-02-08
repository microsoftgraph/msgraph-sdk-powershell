### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Identity.SignIns

$params = @{
	DisplayName = "CrossTenantAccessPolicy"
}

Update-MgPolicyCrossTenantAccessPolicy -BodyParameter $params
```
This example shows how to use the Remove-MgPolicyCrossTenantAccessPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

