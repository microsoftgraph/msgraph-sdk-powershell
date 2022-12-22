### Example 1: Using the Update-MgBetaUserOutlookTaskGroup Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users
$params = @{
	Name = "Personal Tasks"
}
# A UPN can also be used as -UserId.
Update-MgBetaUserOutlookTaskGroup -UserId $userId -OutlookTaskGroupId $outlookTaskGroupId -BodyParameter $params
```
This example shows how to use the Update-MgBetaUserOutlookTaskGroup Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
