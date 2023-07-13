### Example 1: Using the Set-MgBetaUserPresenceUserPreferredPresence Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users.Actions
$params = @{
	Availability = "DoNotDisturb"
	Activity = "DoNotDisturb"
	ExpirationDuration = "PT8H"
}
Set-MgBetaUserPresenceUserPreferredPresence -UserId $userId -BodyParameter $params
```
This example shows how to use the Set-MgBetaUserPresenceUserPreferredPresence Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
