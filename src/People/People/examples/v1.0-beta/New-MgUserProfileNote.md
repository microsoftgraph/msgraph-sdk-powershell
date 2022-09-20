### Example 1: Using the New-MgUserProfileNote Cmdlet
```powershell
Import-Module Microsoft.Graph.People
$params = @{
	Detail = @{
		ContentType = "text"
		Content = "I am originally from Australia, but grew up in Moscow, Russia."
	}
	DisplayName = "About Me"
}
# A UPN can also be used as -UserId.
New-MgUserProfileNote -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgUserProfileNote Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
