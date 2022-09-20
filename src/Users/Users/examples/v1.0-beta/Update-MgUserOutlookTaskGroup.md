### Example 1: Using the Update-MgUserOutlookTaskGroup Cmdlet
```powershell
Import-Module Microsoft.Graph.Users
$params = @{
	Name = "Personal Tasks"
}
# A UPN can also be used as -UserId.
Update-MgUserOutlookTaskGroup -UserId $userId -OutlookTaskGroupId $outlookTaskGroupId -BodyParameter $params
```
This example shows how to use the Update-MgUserOutlookTaskGroup Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
