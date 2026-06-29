### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

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

New-MgBetaAdminPeopleProfileSource -BodyParameter $params

```
This example shows how to use the New-MgBetaAdminPeopleProfileSource Cmdlet.

