### Example 1: Using the New-MgUserOutlookTaskFolder Cmdlet
```powershell
Import-Module Microsoft.Graph.Users
$params = @{
	Name = "Volunteer"
}
# A UPN can also be used as -UserId.
New-MgUserOutlookTaskFolder -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgUserOutlookTaskFolder Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
