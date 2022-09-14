### Example 1
``` powershell
Import-Module Microsoft.Graph.Calendar
$params = @{
	Name = "Personal events"
}
# A UPN can also be used as -UserId.
New-MgUserCalendarGroup -UserId $userId -BodyParameter $params
```
