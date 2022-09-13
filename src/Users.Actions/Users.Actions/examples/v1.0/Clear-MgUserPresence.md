###Example 1
```
Import-Module Microsoft.Graph.Users.Actions
$params = @{
	SessionId = "22553876-f5ab-4529-bffb-cfe50aa89f87"
}
Clear-MgUserPresence -UserId $userId -BodyParameter $params
```
