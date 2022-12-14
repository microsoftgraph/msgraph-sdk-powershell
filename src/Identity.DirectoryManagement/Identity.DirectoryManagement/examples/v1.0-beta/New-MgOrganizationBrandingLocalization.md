### Example 1: Using the New-MgBetaOrganizationBrandingLocalization Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement
$params = @{
	BackgroundColor = "#00000F"
	Id = "fr-FR"
	SignInPageText = " "
}
New-MgBetaOrganizationBrandingLocalization -OrganizationId $organizationId -BodyParameter $params
```
This example shows how to use the New-MgBetaOrganizationBrandingLocalization Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
