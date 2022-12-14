### Example 1: Using the New-MgBetaUserOnenoteNotebook Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Notes
$params = @{
	DisplayName = "My Private notebook"
}
# A UPN can also be used as -UserId.
New-MgBetaUserOnenoteNotebook -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserOnenoteNotebook Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
