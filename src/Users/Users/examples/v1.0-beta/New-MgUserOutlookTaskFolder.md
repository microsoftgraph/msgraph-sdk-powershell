### Example 1: Using the New-MgBetaUserOutlookTaskFolder Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users
$params = @{
	Name = "Volunteer"
}
# A UPN can also be used as -UserId.
New-MgBetaUserOutlookTaskFolder -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserOutlookTaskFolder Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
