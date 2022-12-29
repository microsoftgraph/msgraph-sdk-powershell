### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Users.Actions

$params = @{
	Schedules = @(
		"adelev@contoso.onmicrosoft.com"
		"meganb@contoso.onmicrosoft.com"
	)
	StartTime = @{
		DateTime = "2019-03-15T09:00:00"
		TimeZone = "Pacific Standard Time"
	}
	EndTime = @{
		DateTime = "2019-03-15T18:00:00"
		TimeZone = "Pacific Standard Time"
	}
	AvailabilityViewInterval = 60
}

# A UPN can also be used as -UserId.
Get-MgBetaUserDefaultCalendarSchedule -UserId $userId -BodyParameter $params
```
This example shows how to use the Get-MgBetaUserCalendarSchedule Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

