### Example 1: Using the New-MgBetaOrganizationSettingProfileCardProperty Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement
$params = @{
	DirectoryPropertyName = "CustomAttribute1"
	Annotations = @(
		@{
			DisplayName = "Cost Center"
			Localizations = @(
				@{
					LanguageTag = "ru-RU"
					DisplayName = "центр затрат"
				}
			)
		}
	)
}
New-MgBetaOrganizationSettingProfileCardProperty -OrganizationId $organizationId -BodyParameter $params
```
This example shows how to use the New-MgBetaOrganizationSettingProfileCardProperty Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
