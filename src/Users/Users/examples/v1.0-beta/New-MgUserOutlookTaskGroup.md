### Example 1: Using the New-MgBetaUserOutlookTaskGroup Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users
$params = @{
	Name = "Leisure tasks"
}
# A UPN can also be used as -UserId.
New-MgBetaUserOutlookTaskGroup -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserOutlookTaskGroup Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
