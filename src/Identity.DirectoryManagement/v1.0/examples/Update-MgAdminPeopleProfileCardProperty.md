### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.DirectoryManagement

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

Update-MgAdminPeopleProfileCardProperty -ProfileCardPropertyId $profileCardPropertyId -BodyParameter $params

```
This example shows how to use the Update-MgAdminPeopleProfileCardProperty Cmdlet.

