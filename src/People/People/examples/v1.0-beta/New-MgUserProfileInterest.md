### Example 1: Using the New-MgBetaUserProfileInterest Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
$params = @{
	Categories = @(
		"Sports"
	)
	Description = "World's greatest football club"
	DisplayName = "Chelsea FC"
	WebUrl = "https://www.chelseafc.com"
}
# A UPN can also be used as -UserId.
New-MgBetaUserProfileInterest -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserProfileInterest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
