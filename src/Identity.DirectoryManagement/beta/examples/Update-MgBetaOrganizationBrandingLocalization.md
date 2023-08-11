### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	backgroundColor = "#00000F"
	signInPageText = "Welcome to Contoso France"
}

Update-MgBetaOrganizationBrandingLocalization -OrganizationId $organizationId -OrganizationalBrandingLocalizationId $organizationalBrandingLocalizationId -BodyParameter $params
```
This example shows how to use the Update-MgBetaOrganizationBrandingLocalization Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

