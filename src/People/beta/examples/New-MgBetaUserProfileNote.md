### Example 1: Using the New-MgBetaUserProfileNote Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
$params = @{
	Detail = @{
		ContentType = "text"
		Content = "I am originally from Australia, but grew up in Moscow, Russia."
	}
	DisplayName = "About Me"
}
# A UPN can also be used as -UserId.
New-MgBetaUserProfileNote -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserProfileNote Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
