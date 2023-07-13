### Example 1: Using the New-MgBetaUserOutlookTask Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users
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
New-MgBetaUserOutlookTask -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserOutlookTask Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
