### Example 1: Using the Set-MgUserPresenceUserPreferredPresence Cmdlet
```powershell
Import-Module Microsoft.Graph.Users.Actions
$params = @{
	Availability = "DoNotDisturb"
	Activity = "DoNotDisturb"
	ExpirationDuration = "PT8H"
}
Set-MgUserPresenceUserPreferredPresence -UserId $userId -BodyParameter $params
```
This example shows how to use the Set-MgUserPresenceUserPreferredPresence Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
