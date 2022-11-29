### Example 1: Using the Invoke-MgRenewGroupLifecyclePolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.Groups
$params = @{
	GroupId = "ffffffff-ffff-ffff-ffff-ffffffffffff"
}
Invoke-MgRenewGroupLifecyclePolicy -BodyParameter $params
```
This example shows how to use the Invoke-MgRenewGroupLifecyclePolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
