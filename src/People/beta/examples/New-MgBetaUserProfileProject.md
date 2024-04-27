### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.People

$params = @{
	categories = @(
	"Branding"
)
client = @{
	displayName = "Contoso Ltd."
	department = "Corporate Marketing"
	webUrl = "https://www.contoso.com"
}
displayName = "Contoso Re-branding Project"
detail = @{
	company = @{
		displayName = "Adventureworks Inc."
		department = "Consulting"
		webUrl = "https://adventureworks.com"
	}
	description = "Rebranding of Contoso Ltd."
	jobTitle = "Lead PM Rebranding"
	role = "project management"
	summary = "A 6 month project to help Contoso rebrand after they were divested from a parent organization."
}
}

# A UPN can also be used as -UserId.
New-MgBetaUserProfileProject -UserId $userId -BodyParameter $params

```
This example shows how to use the New-MgBetaUserProfileProject Cmdlet.

