### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.CloudCommunications

$params = @{
	sessionId = "22553876-f5ab-4529-bffb-cfe50aa89f87"
}

Clear-MgUserPresence -UserId $userId -BodyParameter $params

```
This example shows how to use the Clear-MgUserPresence Cmdlet.

