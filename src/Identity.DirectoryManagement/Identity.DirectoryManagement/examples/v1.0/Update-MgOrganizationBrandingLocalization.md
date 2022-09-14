### Example 1
``` powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
$params = @{
	BackgroundColor = "#00000F"
	SignInPageText = "Welcome to Contoso France"
}
Update-MgOrganizationBrandingLocalization -OrganizationId $organizationId -OrganizationalBrandingLocalizationId $organizationalBrandingLocalizationId -BodyParameter $params
```
### Example 2
``` powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
$params = @{
	SignInPageText = "Welcome to Contoso France."
	UsernameHintText = " "
}
Update-MgOrganizationBrandingLocalization -OrganizationId $organizationId -OrganizationalBrandingLocalizationId $organizationalBrandingLocalizationId -BodyParameter $params
```
