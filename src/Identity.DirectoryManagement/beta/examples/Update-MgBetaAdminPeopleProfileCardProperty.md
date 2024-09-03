### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	annotations = @(
		@{
			displayName = "Cost Center"
			localizations = @(
				@{
					languageTag = "no"
					displayName = "Kostnadssenter"
				}
			)
		}
	)
}

Update-MgBetaAdminPeopleProfileCardProperty -ProfileCardPropertyId $profileCardPropertyId -BodyParameter $params

```
This example shows how to use the Update-MgBetaAdminPeopleProfileCardProperty Cmdlet.

