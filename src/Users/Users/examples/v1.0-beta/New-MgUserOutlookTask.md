### Example 1: Using the New-MgUserOutlookTask Cmdlet
```powershell
Import-Module Microsoft.Graph.Users
$params = @{
	Subject = "Shop for children's weekend"
	StartDateTime = @{
		DateTime = "2016-05-03T09:00:00"
		TimeZone = "Eastern Standard Time"
	}
	DueDateTime = @{
		DateTime = "2016-05-05T16:00:00"
		TimeZone = "Eastern Standard Time"
	}
}
# A UPN can also be used as -UserId.
New-MgUserOutlookTask -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgUserOutlookTask Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
