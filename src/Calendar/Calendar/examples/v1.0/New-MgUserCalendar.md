###Example 1
```
Import-Module Microsoft.Graph.Calendar
$params = @{
	Name = "Volunteer"
}
# A UPN can also be used as -UserId.
New-MgUserCalendar -UserId $userId -BodyParameter $params
```
