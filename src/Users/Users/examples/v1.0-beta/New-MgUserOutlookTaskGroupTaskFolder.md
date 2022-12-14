### Example 1: Using the New-MgBetaUserOutlookTaskGroupTaskFolder Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users
$params = @{
	Name = "Cooking"
}
# A UPN can also be used as -UserId.
New-MgBetaUserOutlookTaskGroupTaskFolder -UserId $userId -OutlookTaskGroupId $outlookTaskGroupId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserOutlookTaskGroupTaskFolder Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
