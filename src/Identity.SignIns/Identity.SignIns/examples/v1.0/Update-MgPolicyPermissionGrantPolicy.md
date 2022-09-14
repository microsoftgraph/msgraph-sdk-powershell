### Example 1: Using the Update-MgPolicyPermissionGrantPolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	DisplayName = "Custom permission grant policy"
}
Update-MgPolicyPermissionGrantPolicy -PermissionGrantPolicyId $permissionGrantPolicyId -BodyParameter $params
```
This example shows how to use the Update-MgPolicyPermissionGrantPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
