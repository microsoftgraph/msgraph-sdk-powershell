### Example 1: Using the Update-MgBetaPolicyAccessReviewPolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	IsGroupOwnerManagementEnabled = $true
}
Update-MgBetaPolicyAccessReviewPolicy -BodyParameter $params
```
This example shows how to use the Update-MgBetaPolicyAccessReviewPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
