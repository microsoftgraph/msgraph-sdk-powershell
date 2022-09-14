### Example 1
```powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
$params = @{
	BackgroundColor = "#00000F"
	Id = "fr-FR"
	SignInPageText = " "
}
New-MgOrganizationBrandingLocalization -OrganizationId $organizationId -BodyParameter $params
```
