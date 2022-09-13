###Example 1
```
Import-Module Microsoft.Graph.Identity.DirectoryManagement
$params = @{
	BackgroundColor = "#00000F"
	SignInPageText = "Welcome to Contoso France"
}
Update-MgOrganizationBrandingLocalization -OrganizationId $organizationId -OrganizationalBrandingLocalizationId $organizationalBrandingLocalizationId -BodyParameter $params
```
###Example 2
```
Import-Module Microsoft.Graph.Identity.DirectoryManagement
$params = @{
	SignInPageText = "Welcome to Contoso France."
	UsernameHintText = " "
}
Update-MgOrganizationBrandingLocalization -OrganizationId $organizationId -OrganizationalBrandingLocalizationId $organizationalBrandingLocalizationId -BodyParameter $params
```
