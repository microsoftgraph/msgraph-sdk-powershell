### Example 1: Using the Update-MgBetaUserOutlookTask Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users
$params = @{
	DueDateTime = @{
		DateTime = "2016-05-06T16:00:00"
		TimeZone = "Eastern Standard Time"
	}
}
# A UPN can also be used as -UserId.
Update-MgBetaUserOutlookTask -UserId $userId -OutlookTaskId $outlookTaskId -BodyParameter $params
```
This example shows how to use the Update-MgBetaUserOutlookTask Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
