### Example 1
``` powershell
Import-Module Microsoft.Graph.Users.Actions
$params = @{
	SessionId = "22553876-f5ab-4529-bffb-cfe50aa89f87"
	Availability = "Available"
	Activity = "Available"
	ExpirationDuration = "PT1H"
}
Set-MgUserPresence -UserId $userId -BodyParameter $params
```
