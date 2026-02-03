### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Users.Actions

$params = @{
	availability = "DoNotDisturb"
	activity = "DoNotDisturb"
	expirationDuration = "PT8H"
}

Set-MgBetaUserPresenceUserPreferredPresence -UserId $userId -BodyParameter $params

```
This example shows how to use the Set-MgBetaUserPresenceUserPreferredPresence Cmdlet.

