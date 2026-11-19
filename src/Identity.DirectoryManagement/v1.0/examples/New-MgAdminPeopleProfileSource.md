### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.DirectoryManagement

$params = @{
	sourceId = "bamboohr1"
	displayName = "HR Platform"
	kind = "BambooHR"
	webUrl = "https://bamboohr.contoso.com/login"
	localizations = @(
		@{
			displayName = "HR-Plattform"
			webUrl = "http://bamboohr.contoso.com/de/login"
			languageTag = "de"
		}
	)
}

New-MgAdminPeopleProfileSource -BodyParameter $params

```
This example shows how to use the New-MgAdminPeopleProfileSource Cmdlet.

