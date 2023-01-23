### Example 1: Using the Update-MgOrganizationBrandingLocalization Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
$params = @{
	BackgroundColor = "#00000F"
	SignInPageText = "Welcome to Contoso France"
}
Update-MgOrganizationBrandingLocalization -OrganizationId $organizationId -OrganizationalBrandingLocalizationId $organizationalBrandingLocalizationId -BodyParameter $params
```
This example shows how to use the Update-MgOrganizationBrandingLocalization Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Update-MgOrganizationBrandingLocalization Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
$params = @{
	SignInPageText = "Welcome to Contoso France."
	UsernameHintText = " "
}
Update-MgOrganizationBrandingLocalization -OrganizationId $organizationId -OrganizationalBrandingLocalizationId $organizationalBrandingLocalizationId -BodyParameter $params
```
This example shows how to use the Update-MgOrganizationBrandingLocalization Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
