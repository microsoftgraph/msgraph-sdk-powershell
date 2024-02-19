### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.DirectoryManagement

$params = @{
	backgroundColor = "#00000F"
	id = "fr-FR"
	signInPageText = " "
}

New-MgOrganizationBrandingLocalization -OrganizationId $organizationId -BodyParameter $params

```
This example shows how to use the New-MgOrganizationBrandingLocalization Cmdlet.

