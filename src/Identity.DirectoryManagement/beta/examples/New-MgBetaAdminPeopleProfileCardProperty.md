### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	directoryPropertyName = "CustomAttribute1"
	annotations = @(
		@{
			displayName = "Cost Center"
			localizations = @(
				@{
					languageTag = "ru"
					displayName = "центр затрат"
				}
			)
		}
	)
}

New-MgBetaAdminPeopleProfileCardProperty -BodyParameter $params

```
This example shows how to use the New-MgBetaAdminPeopleProfileCardProperty Cmdlet.

