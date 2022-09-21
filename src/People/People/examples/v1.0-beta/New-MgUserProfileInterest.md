### Example 1: Using the New-MgUserProfileInterest Cmdlet
```powershell
Import-Module Microsoft.Graph.People
$params = @{
	Categories = @(
		"Sports"
	)
	Description = "World's greatest football club"
	DisplayName = "Chelsea FC"
	WebUrl = "https://www.chelseafc.com"
}
# A UPN can also be used as -UserId.
New-MgUserProfileInterest -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgUserProfileInterest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
