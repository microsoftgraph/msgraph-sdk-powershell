### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.CloudCommunications

$params = @{
	sessionId = "22553876-f5ab-4529-bffb-cfe50aa89f87"
	availability = "Available"
	activity = "Available"
	expirationDuration = "PT1H"
}

Set-MgBetaUserPresence -UserId $userId -BodyParameter $params

```
This example shows how to use the Set-MgBetaUserPresence Cmdlet.

