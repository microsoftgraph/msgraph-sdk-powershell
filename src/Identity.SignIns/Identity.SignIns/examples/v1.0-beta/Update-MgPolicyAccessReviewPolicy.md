### Example 1: Using the Update-MgPolicyAccessReviewPolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	IsGroupOwnerManagementEnabled = $true
}
Update-MgPolicyAccessReviewPolicy -BodyParameter $params
```
This example shows how to use the Update-MgPolicyAccessReviewPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
