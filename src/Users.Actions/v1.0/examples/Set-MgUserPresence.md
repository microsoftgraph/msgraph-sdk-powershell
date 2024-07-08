### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Users.Actions

$params = @{
	sessionId = "22553876-f5ab-4529-bffb-cfe50aa89f87"
	availability = "Available"
	activity = "Available"
	expirationDuration = "PT1H"
}

Set-MgUserPresence -UserId $userId -BodyParameter $params

```
This example shows how to use the Set-MgUserPresence Cmdlet.

