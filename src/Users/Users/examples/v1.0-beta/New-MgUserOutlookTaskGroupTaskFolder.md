### Example 1: Using the New-MgUserOutlookTaskGroupTaskFolder Cmdlet
```powershell
Import-Module Microsoft.Graph.Users
$params = @{
	Name = "Cooking"
}
# A UPN can also be used as -UserId.
New-MgUserOutlookTaskGroupTaskFolder -UserId $userId -OutlookTaskGroupId $outlookTaskGroupId -BodyParameter $params
```
This example shows how to use the New-MgUserOutlookTaskGroupTaskFolder Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
