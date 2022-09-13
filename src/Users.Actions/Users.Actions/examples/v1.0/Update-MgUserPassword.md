###Example 1
```
Import-Module Microsoft.Graph.Users.Actions
$params = @{
	CurrentPassword = "xWwvJ]6NMw+bWH-d"
	NewPassword = "0eM85N54wFxWwvJ]"
}
# A UPN can also be used as -UserId.
Update-MgUserPassword -UserId $userId -BodyParameter $params
```
