### Example 1: Using the Invoke-MgBetaRenewGroupLifecyclePolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Groups
$params = @{
	GroupId = "ffffffff-ffff-ffff-ffff-ffffffffffff"
}
Invoke-MgBetaRenewGroupLifecyclePolicy -BodyParameter $params
```
This example shows how to use the Invoke-MgBetaRenewGroupLifecyclePolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
