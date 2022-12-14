### Example 1: Using the New-MgBetaUserProfileWebsite Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
$params = @{
	Categories = @(
		"football"
	)
	DisplayName = "Lyn Damer"
	WebUrl = "www.lyndamer.no"
}
# A UPN can also be used as -UserId.
New-MgBetaUserProfileWebsite -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserProfileWebsite Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
