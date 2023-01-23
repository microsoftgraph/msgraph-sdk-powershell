### Example 1: Using the Update-MgBetaOrganizationSettingProfileCardProperty Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement
$params = @{
	Annotations = @(
		@{
			Localizations = @(
				@{
					LanguageTag = "no-NB"
					DisplayName = "Kostnads Senter"
				}
			)
		}
	)
}
Update-MgBetaOrganizationSettingProfileCardProperty -OrganizationId $organizationId -ProfileCardPropertyId $profileCardPropertyId -BodyParameter $params
```
This example shows how to use the Update-MgBetaOrganizationSettingProfileCardProperty Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
