### Example 1: Using the New-MgOrganizationBrandingLocalization Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
$params = @{
	BackgroundColor = "#00000F"
	Id = "fr-FR"
	SignInPageText = " "
}
New-MgOrganizationBrandingLocalization -OrganizationId $organizationId -BodyParameter $params
```
This example shows how to use the New-MgOrganizationBrandingLocalization Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
