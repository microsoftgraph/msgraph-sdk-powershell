### Example 1: Using the New-MgOrganizationSettingProfileCardProperty Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
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
New-MgOrganizationSettingProfileCardProperty -OrganizationId $organizationId -BodyParameter $params
```
This example shows how to use the New-MgOrganizationSettingProfileCardProperty Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
