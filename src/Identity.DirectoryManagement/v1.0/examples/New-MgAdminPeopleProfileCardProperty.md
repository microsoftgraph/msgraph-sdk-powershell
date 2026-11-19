### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.DirectoryManagement

$params = @{
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
	directoryPropertyName = "CustomAttribute1"
	isVisible = $true
}

New-MgAdminPeopleProfileCardProperty -BodyParameter $params

```
This example shows how to use the New-MgAdminPeopleProfileCardProperty Cmdlet.

