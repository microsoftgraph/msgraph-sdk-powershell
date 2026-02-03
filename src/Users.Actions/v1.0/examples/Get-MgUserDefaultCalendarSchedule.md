### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Users.Actions

$params = @{
	schedules = @(
	"adelev@contoso.com"
"meganb@contoso.com"
)
startTime = @{
dateTime = "2019-03-15T09:00:00"
timeZone = "Pacific Standard Time"
}
endTime = @{
dateTime = "2019-03-15T18:00:00"
timeZone = "Pacific Standard Time"
}
availabilityViewInterval = 60
}

# A UPN can also be used as -UserId.
Get-MgUserDefaultCalendarSchedule -UserId $userId -BodyParameter $params

```
This example shows how to use the Get-MgUserDefaultCalendarSchedule Cmdlet.

