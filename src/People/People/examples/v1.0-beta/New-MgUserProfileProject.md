### Example 1: Using the New-MgUserProfileProject Cmdlet
```powershell
Import-Module Microsoft.Graph.People
$params = @{
	Categories = @(
		"Branding"
	)
	Client = @{
		DisplayName = "Contoso Ltd."
		Department = "Corporate Marketing"
		WebUrl = "https://www.contoso.com"
	}
	DisplayName = "Contoso Re-branding Project"
	Detail = @{
		Company = @{
			DisplayName = "Adventureworks Inc."
			Department = "Consulting"
			WebUrl = "https://adventureworks.com"
		}
		Description = "Rebranding of Contoso Ltd."
		JobTitle = "Lead PM Rebranding"
		Role = "project management"
		Summary = "A 6 month project to help Contoso rebrand after they were divested from a parent organization."
	}
}
# A UPN can also be used as -UserId.
New-MgUserProfileProject -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgUserProfileProject Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
