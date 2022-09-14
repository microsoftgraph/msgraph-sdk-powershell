### Example 1: Using the New-MgUserOnenoteNotebook Cmdlet
```powershell
Import-Module Microsoft.Graph.Notes
$params = @{
	DisplayName = "My Private notebook"
}
# A UPN can also be used as -UserId.
New-MgUserOnenoteNotebook -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgUserOnenoteNotebook Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
