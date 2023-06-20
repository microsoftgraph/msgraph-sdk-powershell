### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	backgroundColor = "#00000F"
	id = "fr-FR"
	signInPageText = " "
}

New-MgBetaOrganizationBrandingLocalization -OrganizationId $organizationId -BodyParameter $params
```
This example shows how to use the New-MgBetaOrganizationBrandingLocalization Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

