### Example 1: Using the Update-MgOrganizationSettingProfileCardProperty Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
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
Update-MgOrganizationSettingProfileCardProperty -OrganizationId $organizationId -ProfileCardPropertyId $profileCardPropertyId -BodyParameter $params
```
This example shows how to use the Update-MgOrganizationSettingProfileCardProperty Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
