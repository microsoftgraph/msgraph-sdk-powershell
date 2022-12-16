### Example 1: Using the New-MgUserOutlookTaskGroup Cmdlet
```powershell
Import-Module Microsoft.Graph.Users
$params = @{
	Name = "Leisure tasks"
}
# A UPN can also be used as -UserId.
New-MgUserOutlookTaskGroup -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgUserOutlookTaskGroup Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
